Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class UserManagementForm
    Private _selectedUserId As Integer? = Nothing
    Private _isEditMode As Boolean = False

    Private Sub UserManagementForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & CurrentUser.Username & " (" & CurrentUser.Role & ")"

        ' Only admin can access this form
        If CurrentUser.Role <> "admin" Then
            MessageBox.Show("Access denied. Admin privileges required.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            DashboardForm.Show()
            Return
        End If
        ' Hide buttons based on role
        Select Case CurrentUser.Role
            Case "admin"
                btnNewAudit.Visible = True
                btnProducts.Visible = True
                btnAdjustStock.Visible = True
                btnReports.Visible = True
                btnUserManagement.Visible = True
            Case "stock_manager"
                btnNewAudit.Visible = False
                btnProducts.Visible = True
                btnAdjustStock.Visible = True
                btnReports.Visible = True
                btnUserManagement.Visible = False
                btnReports.Location = New Point(3, 300)
            Case "inventory_auditor"
                btnProducts.Visible = False
                btnAdjustStock.Visible = False
                btnNewAudit.Visible = True
                btnReports.Visible = True
                btnUserManagement.Visible = False
                btnNewAudit.Location = New Point(2, 175)
                btnReports.Location = New Point(3, 225)
        End Select

        ' Apply modern styling to DataGridView
        ApplyDataGridViewStyle()

        LoadUsers()
        ClearUserForm()
    End Sub

    Private Sub ApplyDataGridViewStyle()
        ' Basic settings
        dgvUsers.BackgroundColor = Color.FromArgb(30, 30, 40)
        dgvUsers.BorderStyle = BorderStyle.None
        dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvUsers.GridColor = Color.FromArgb(50, 50, 65)
        dgvUsers.RowHeadersVisible = False
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.AllowUserToResizeRows = False
        dgvUsers.MultiSelect = False
        dgvUsers.ReadOnly = True

        ' Enable double buffering for smooth rendering
        dgvUsers.GetType().InvokeMember("DoubleBuffered",
            Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.SetProperty,
            Nothing, dgvUsers, New Object() {True})

        ' Header style
        dgvUsers.EnableHeadersVisualStyles = False
        dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215)
        dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvUsers.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        dgvUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvUsers.ColumnHeadersDefaultCellStyle.Padding = New Padding(5)
        dgvUsers.ColumnHeadersHeight = 45
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        ' Default cell style
        dgvUsers.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 50)
        dgvUsers.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220)
        dgvUsers.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 100, 200)
        dgvUsers.DefaultCellStyle.SelectionForeColor = Color.White
        dgvUsers.DefaultCellStyle.Padding = New Padding(5)
        dgvUsers.RowTemplate.Height = 40

        ' Alternating row colors
        dgvUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 60)

        ' Auto size columns to fill
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub LoadUsers(Optional ByVal searchTerm As String = "")
        Try
            Using conn As SqlConnection = DatabaseHelper.GetConnection()
                Dim query As String = "SELECT Id, Username, Role, CreatedAt FROM Users"

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " WHERE Username LIKE @searchTerm OR Role LIKE @searchTerm"
                End If

                query &= " ORDER BY Username"

                Dim adapter As New SqlDataAdapter(query, conn)

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                End If

                Dim table As New DataTable()
                adapter.Fill(table)
                dgvUsers.DataSource = table

                ' Format columns
                If dgvUsers.Columns.Contains("Id") Then
                    dgvUsers.Columns("Id").Visible = False
                End If

                If dgvUsers.Columns.Contains("Username") Then
                    dgvUsers.Columns("Username").HeaderText = "USERNAME"
                    dgvUsers.Columns("Username").DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                    dgvUsers.Columns("Username").Width = 200
                End If

                If dgvUsers.Columns.Contains("Role") Then
                    dgvUsers.Columns("Role").HeaderText = "ROLE"
                    dgvUsers.Columns("Role").Width = 150
                End If

                If dgvUsers.Columns.Contains("CreatedAt") Then
                    dgvUsers.Columns("CreatedAt").HeaderText = "CREATED DATE"
                    dgvUsers.Columns("CreatedAt").DefaultCellStyle.Format = "dd MMM yyyy HH:mm"
                    dgvUsers.Columns("CreatedAt").Width = 180
                End If

                ' Apply role color coding
                AddHandler dgvUsers.CellFormatting, AddressOf dgvUsers_CellFormatting
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvUsers_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs)
        ' Color code the Role column
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            If dgvUsers.Columns(e.ColumnIndex).Name = "Role" AndAlso e.Value IsNot Nothing Then
                Select Case e.Value.ToString().ToLower()
                    Case "admin"
                        e.CellStyle.BackColor = Color.FromArgb(70, 30, 90)
                        e.CellStyle.ForeColor = Color.FromArgb(200, 130, 250)
                        e.CellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                    Case "stock_manager"
                        e.CellStyle.BackColor = Color.FromArgb(20, 70, 60)
                        e.CellStyle.ForeColor = Color.FromArgb(100, 230, 200)
                        e.CellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                    Case "inventory_auditor"
                        e.CellStyle.BackColor = Color.FromArgb(70, 50, 30)
                        e.CellStyle.ForeColor = Color.FromArgb(250, 180, 100)
                        e.CellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                End Select
            End If
        End If
    End Sub

    Private Sub ClearUserForm()

        Label1.Visible = False
        txtUsername.Text = ""
        txtPassword.Text = ""
        cmbRole.SelectedIndex = -1
        _selectedUserId = Nothing
        _isEditMode = False




    End Sub

    Private Sub LoadUserForEdit(ByVal userId As Integer)
        Try
            Using conn As SqlConnection = DatabaseHelper.GetConnection()
                Dim query As String = "SELECT Username, Role FROM Users WHERE Id = @id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", userId)
                    conn.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtUsername.Text = reader("Username").ToString()
                        txtPassword.Text = "" ' Don't load password for security
                        Dim role As String = reader("Role").ToString()
                        If cmbRole.Items.Contains(role) Then
                            cmbRole.SelectedItem = role
                        End If
                        _selectedUserId = userId
                        _isEditMode = True
                        btnSave.Text = "Update User"
                        btnSave.BackColor = Color.FromArgb(255, 140, 0) ' Orange for update
                    End If
                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddUser.Click
        ClearUserForm()
        txtUsername.Focus()

        ' Highlight the add button temporarily
        btnAddUser.BackColor = Color.LightGreen
        Timer1.Interval = 200
        Timer1.Start()
    End Sub

    Private Sub btnEditUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEditUser.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim userId As Integer = dgvUsers.SelectedRows(0).Cells("Id").Value
            LoadUserForEdit(userId)

            ' Highlight the edit button
            btnEditUser.BackColor = Color.LightGreen
            Timer1.Interval = 200
            Timer1.Start()
        Else
            MessageBox.Show("Please select a user to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDeleteUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteUser.Click
        If dgvUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim userId As Integer = dgvUsers.SelectedRows(0).Cells("Id").Value
        Dim username As String = dgvUsers.SelectedRows(0).Cells("Username").Value.ToString()

        ' Prevent deleting yourself
        If userId = CurrentUser.Id Then
            MessageBox.Show("You cannot delete your own account.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Custom confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete user '" & username & "'?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Using conn As SqlConnection = DatabaseHelper.GetConnection()
                    conn.Open()
                    Dim cmd As New SqlCommand("DELETE FROM Users WHERE Id = @id", conn)
                    cmd.Parameters.AddWithValue("@id", userId)
                    cmd.ExecuteNonQuery()
                End Using
                LoadUsers(txtSearch.Text)
                ClearUserForm()
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error deleting user: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadUsers()
        ClearUserForm()

        ' Animate refresh button
        btnRefresh.BackColor = Color.LightGreen
        Timer1.Interval = 200
        Timer1.Start()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' Validation
        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If txtPassword.Text.Trim() = "" And Not _isEditMode Then
            MessageBox.Show("Password is required for new users.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        If cmbRole.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbRole.Focus()
            Return
        End If

        Try
            Using conn As SqlConnection = DatabaseHelper.GetConnection()
                conn.Open()

                ' Check if username already exists (for new users or if username changed)
                If Not _isEditMode Then
                    Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn)
                    checkCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Username already exists. Please choose another.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End If

                If _isEditMode Then
                    ' Update existing user
                    Dim query As String = "UPDATE Users SET Username = @username, Role = @role"

                    ' Only update password if provided
                    If txtPassword.Text.Trim() <> "" Then
                        query &= ", Password = @password"
                    End If

                    query &= " WHERE Id = @id"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", _selectedUserId)
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                        cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())

                        If txtPassword.Text.Trim() <> "" Then
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                        End If

                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Insert new user
                    Dim query As String = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                        cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            LoadUsers(txtSearch.Text)
            ClearUserForm()

            ' Flash save button on success
            btnSave.BackColor = Color.LightGreen
            Timer1.Interval = 200
            Timer1.Start()

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        ClearUserForm()
        ' Flash cancel button
        btnCancel.BackColor = Color.LightPink
        Timer1.Interval = 200
        Timer1.Start()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        LoadUsers(txtSearch.Text)
    End Sub

    ' Timer for button animations
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        ' Reset button colors
        btnAddUser.BackColor = SystemColors.Control
        btnEditUser.BackColor = SystemColors.Control
        btnDeleteUser.BackColor = SystemColors.Control
        btnRefresh.BackColor = SystemColors.Control
        btnSave.BackColor = If(_isEditMode, Color.FromArgb(255, 140, 0), Color.FromArgb(0, 120, 215))
        btnCancel.BackColor = Color.FromArgb(255, 77, 77)
        Timer1.Stop()
    End Sub

    ' --- Navigation Buttons ---
    Private Sub btnDashboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDashboard.Click
        Me.Close()
        DashboardForm.Show()
    End Sub

    Private Sub btnProducts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProducts.Click
        Me.Close()
        Dim productsForm As New ProductListForm()
        productsForm.Show()
    End Sub

    Private Sub btnAdjustStock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdjustStock.Click
        Me.Close()
        Dim adjustStockForm As New AdjustStockForm()
        adjustStockForm.Show()
    End Sub

    Private Sub btnNewAudit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewAudit.Click
        Me.Close()
        Dim auditForm As New AuditForm()
        auditForm.Show()
    End Sub

    Private Sub btnReports_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReports.Click
        Me.Close()
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
        End If
    End Sub
End Class