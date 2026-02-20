Imports System.Data.SqlClient

Public Class ProductListForm
    Private timeFormat As String = "dddd, MMMM dd, yyyy  hh:mm:ss tt"

    Private Sub ProductListForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Apply modern styling to DataGridView
        ApplyDataGridViewStyle()

        LoadProducts() ' Load all products initially
        lblWelcome.Text = "Welcome, " & CurrentUser.Username & " (" & CurrentUser.Role & ")"

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

    
    End Sub

    Private Sub ApplyDataGridViewStyle()
        ' Basic settings
        With dgvProducts
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ColumnHeadersVisible = True
            .BackgroundColor = Color.FromArgb(11, 14, 20)
            .BorderStyle = BorderStyle.None
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .EnableHeadersVisualStyles = False
            .MultiSelect = False

            ' Enable double buffering for smooth rendering
            .GetType().InvokeMember("DoubleBuffered",
                Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.SetProperty,
                Nothing, dgvProducts, New Object() {True})

            ' Column Header Style
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(9, 64, 103)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Padding = New Padding(5)
            .ColumnHeadersHeight = 45
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            ' Default Cell Style
            .DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
            .DefaultCellStyle.ForeColor = Color.White
            .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(61, 169, 252)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.Padding = New Padding(5)
            .RowTemplate.Height = 40

            ' Alternating Row Style
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)

            ' Grid Line Color
            .GridColor = Color.FromArgb(40, 40, 40)

            ' Add color coding for stock status
            AddHandler .CellFormatting, AddressOf dgvProducts_CellFormatting
            AddHandler .DataBindingComplete, AddressOf dgvProducts_DataBindingComplete
        End With
    End Sub

    Private Sub LoadProducts(Optional ByVal searchTerm As String = "")
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                ' Enhanced query with stock status calculation
                Dim query As String = "SELECT " & _
                                      "Id, " & _
                                      "Name, " & _
                                      "Description, " & _
                                      "Quantity, " & _
                                      "MinLevel, " & _
                                      "MaxLevel, " & _
                                      "CASE " & _
                                      "    WHEN Quantity < MinLevel THEN 'LOW STOCK' " & _
                                      "    WHEN Quantity > MaxLevel THEN 'OVERSTOCK' " & _
                                      "    ELSE 'NORMAL' " & _
                                      "END AS Status, " & _
                                      "CASE " & _
                                      "    WHEN Quantity < MinLevel THEN (MinLevel - Quantity) " & _
                                      "    WHEN Quantity > MaxLevel THEN (Quantity - MaxLevel) " & _
                                      "    ELSE 0 " & _
                                      "END AS Variance " & _
                                      "FROM Products"

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " WHERE Name LIKE @searchTerm OR Description LIKE @searchTerm"
                End If

                query &= " ORDER BY " & _
                        "    CASE " & _
                        "        WHEN Quantity < MinLevel THEN 1 " & _
                        "        WHEN Quantity > MaxLevel THEN 2 " & _
                        "        ELSE 3 " & _
                        "    END, Name"

                Dim adapter As New SqlDataAdapter(query, conn)

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                End If

                Dim table As New DataTable()
                adapter.Fill(table)

                ' Clear existing data source to prevent column caching
                dgvProducts.DataSource = Nothing
                dgvProducts.Columns.Clear()

                ' Set new data source
                dgvProducts.DataSource = table

                ' Configure columns
                ConfigureProductColumns()

            Catch ex As Exception
                MessageBox.Show("Error loading products: " & ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ConfigureProductColumns()
        If dgvProducts.Columns.Count = 0 Then Exit Sub

        ' Hide ID column
        If dgvProducts.Columns.Contains("Id") Then
            dgvProducts.Columns("Id").Visible = False
        End If

        ' Set auto-size mode to none first for manual sizing
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        ' Configure Name column
        If dgvProducts.Columns.Contains("Name") Then
            With dgvProducts.Columns("Name")
                .HeaderText = "PRODUCT NAME"
                .Width = 180
                .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .DefaultCellStyle.ForeColor = Color.White
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True ' Allow text wrapping
            End With
        End If

        ' Configure Description column
        If dgvProducts.Columns.Contains("Description") Then
            With dgvProducts.Columns("Description")
                .HeaderText = "DESCRIPTION"
                .Width = 250
                .DefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200)
                .DefaultCellStyle.WrapMode = DataGridViewTriState.True ' Allow text wrapping
            End With
        End If

        ' Configure Quantity column
        If dgvProducts.Columns.Contains("Quantity") Then
            With dgvProducts.Columns("Quantity")
                .HeaderText = "QTY"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            End With
        End If

        ' Configure MinLevel column
        If dgvProducts.Columns.Contains("MinLevel") Then
            With dgvProducts.Columns("MinLevel")
                .HeaderText = "MIN"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.ForeColor = Color.FromArgb(150, 150, 255)
            End With
        End If

        ' Configure MaxLevel column
        If dgvProducts.Columns.Contains("MaxLevel") Then
            With dgvProducts.Columns("MaxLevel")
                .HeaderText = "MAX"
                .Width = 60
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.ForeColor = Color.FromArgb(255, 150, 150)
            End With
        End If

        ' Configure Status column
        If dgvProducts.Columns.Contains("Status") Then
            With dgvProducts.Columns("Status")
                .HeaderText = "STATUS"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                .Visible = True
            End With
        End If

        ' Configure Variance column (hide by default)
        If dgvProducts.Columns.Contains("Variance") Then
            dgvProducts.Columns("Variance").Visible = False
        End If

        ' Enable horizontal scrollbar if content exceeds width
        dgvProducts.ScrollBars = ScrollBars.Both

        ' Set row height to accommodate wrapped text
        dgvProducts.RowTemplate.Height = 45

        ' Enable column reordering for user preference
        dgvProducts.AllowUserToOrderColumns = True
    End Sub

    Private Sub dgvProducts_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs)
        ' Color code the rows based on status
        If e.RowIndex >= 0 AndAlso dgvProducts.Columns.Contains("Status") Then
            Dim statusCell As DataGridViewCell = dgvProducts.Rows(e.RowIndex).Cells("Status")

            If statusCell.Value IsNot Nothing AndAlso Not IsDBNull(statusCell.Value) Then
                Dim status As String = statusCell.Value.ToString()

                ' Reset to default colors first
                dgvProducts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
                dgvProducts.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White

                Select Case status
                    Case "LOW STOCK"
                        ' Light red background for low stock
                        dgvProducts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(70, 40, 40)
                        dgvProducts.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(255, 150, 150)
                        statusCell.Style.BackColor = Color.FromArgb(180, 70, 70)
                        statusCell.Style.ForeColor = Color.White
                        statusCell.Style.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                        ' Add variance tooltip
                        If dgvProducts.Columns.Contains("Variance") Then
                            Dim variance As Object = dgvProducts.Rows(e.RowIndex).Cells("Variance").Value
                            If variance IsNot Nothing AndAlso Not IsDBNull(variance) Then
                                dgvProducts.Rows(e.RowIndex).Cells("Quantity").ToolTipText =
                                    "Needs " & variance.ToString() & " more units to reach minimum"
                            End If
                        End If

                    Case "OVERSTOCK"
                        ' Light orange background for overstock
                        dgvProducts.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(70, 50, 30)
                        dgvProducts.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(255, 180, 100)
                        statusCell.Style.BackColor = Color.FromArgb(200, 120, 30)
                        statusCell.Style.ForeColor = Color.White
                        statusCell.Style.Font = New Font("Segoe UI", 10, FontStyle.Bold)

                        ' Add variance tooltip
                        If dgvProducts.Columns.Contains("Variance") Then
                            Dim variance As Object = dgvProducts.Rows(e.RowIndex).Cells("Variance").Value
                            If variance IsNot Nothing AndAlso Not IsDBNull(variance) Then
                                dgvProducts.Rows(e.RowIndex).Cells("Quantity").ToolTipText =
                                    "Exceeds maximum by " & variance.ToString() & " units"
                            End If
                        End If

                    Case "NORMAL"
                        ' Light green background for normal (but keep subtle)
                        statusCell.Style.BackColor = Color.FromArgb(50, 150, 50)
                        statusCell.Style.ForeColor = Color.White
                        statusCell.Style.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                End Select
            End If
        End If

        ' Format Quantity column with visual indicators
        If e.ColumnIndex >= 0 AndAlso dgvProducts.Columns(e.ColumnIndex).Name = "Quantity" Then
            If e.Value IsNot Nothing AndAlso Not IsDBNull(e.Value) Then
                Dim qty As Integer = Convert.ToInt32(e.Value)

                ' Add visual indicator
                If qty = 0 Then
                    e.CellStyle.ForeColor = Color.Red
                    e.CellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                End If
            End If
        End If
    End Sub

    Private Sub dgvProducts_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs)
        ' Add status icons or additional formatting after data binding
        For Each row As DataGridViewRow In dgvProducts.Rows
            If row.Cells("Status").Value IsNot Nothing Then
                Dim status As String = row.Cells("Status").Value.ToString()

                ' Add a small indicator in the row header (if we enable row headers)
                Select Case status
                    Case "LOW STOCK"
                        row.HeaderCell.Value = "⚠️"
                        row.HeaderCell.Style.ForeColor = Color.Red
                        row.HeaderCell.Style.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                    Case "OVERSTOCK"
                        row.HeaderCell.Value = "📈"
                        row.HeaderCell.Style.ForeColor = Color.Orange
                        row.HeaderCell.Style.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                    Case "NORMAL"
                        row.HeaderCell.Value = "✓"
                        row.HeaderCell.Style.ForeColor = Color.Green
                        row.HeaderCell.Style.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                End Select
            End If
        Next

        ' Make row headers visible for indicators
        dgvProducts.RowHeadersVisible = True
        dgvProducts.RowHeadersWidth = 35
    End Sub

 


 



    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts(txtSearch.Text)
    End Sub

    ' --- Navigation Buttons ---
    Private Sub btnDashboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDashboard.Click
        Me.Close()
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
    End Sub

    Private Sub btnProducts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProducts.Click
        LoadProducts()
        If Not IsNothing(txtSearch) Then
            txtSearch.Clear()
        End If
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

    Private Sub btnUserManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserManagement.Click
        Me.Hide()
        Try
            Dim frm As New UserManagementForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing UserManagementForm: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End Try
    End Sub

    Private Sub btnLogout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to log out?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If result = DialogResult.Yes Then
            Me.Close()
            Dim loginForm As New LoginForm()
            loginForm.Show()
        End If
    End Sub

    ' ========== TIME FUNCTIONALITY ==========

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateTimeDisplay()
    End Sub

    Private Sub lblTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTime.Click
        ' Toggle between different time formats when clicked
        If timeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt" Then
            timeFormat = "MM/dd/yyyy  HH:mm:ss"
        ElseIf timeFormat = "MM/dd/yyyy  HH:mm:ss" Then
            timeFormat = "dd-MMM-yyyy  hh:mm tt"
        Else
            timeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt"
        End If
        UpdateTimeDisplay()

        ' Show a brief tooltip to indicate format changed
        Dim tooltip As New ToolTip()
        tooltip.Show("Format changed", lblTime, 0, -20, 1000)
    End Sub

    Private Sub UpdateTimeDisplay()
        ' Update the time label with current date and time
        If lblTime IsNot Nothing AndAlso Not lblTime.IsDisposed Then
            lblTime.Text = DateTime.Now.ToString(timeFormat)
        End If
    End Sub

    ' Timer for button color reset
    Private Sub TimerColorReset_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerColorReset.Tick
   
    End Sub

    Private Sub dgvProducts_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click, btnLogin.Click
        Dim frm As New ProductEditForm()
        If frm.ShowDialog() = DialogResult.OK Then
            If Not IsNothing(txtSearch) Then
                LoadProducts(txtSearch.Text)
            Else
                LoadProducts()
            End If
        End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim productId As Integer = dgvProducts.SelectedRows(0).Cells("Id").Value
            Dim frm As New ProductEditForm(productId)
            If frm.ShowDialog() = DialogResult.OK Then
                If Not IsNothing(txtSearch) Then
                    LoadProducts(txtSearch.Text)
                Else
                    LoadProducts()
                End If

                ' Visual feedback
                EditBtn.BackColor = Color.LightGreen
                TimerColorReset.Interval = 200
                TimerColorReset.Start()
            End If
        Else
            MessageBox.Show("Select a product to edit.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a product to delete.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim productName As String = dgvProducts.SelectedRows(0).Cells("Name").Value.ToString()
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to delete '" & productName & "'? This action cannot be undone.",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If result = DialogResult.Yes Then
            Dim productId As Integer = dgvProducts.SelectedRows(0).Cells("Id").Value
            Using conn As SqlConnection = DatabaseHelper.GetConnection()
                conn.Open()
                Dim cmd As New SqlCommand("DELETE FROM Products WHERE Id = @id", conn)
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.ExecuteNonQuery()
            End Using
            If Not IsNothing(txtSearch) Then
                LoadProducts(txtSearch.Text)
            Else
                LoadProducts()
            End If

            ' Visual feedback
            DeleteBtn.BackColor = Color.LightGreen
            TimerColorReset.Interval = 200
            TimerColorReset.Start()
        End If
    End Sub
End Class