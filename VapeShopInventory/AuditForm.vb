Imports System.Data.SqlClient

Public Class AuditForm
    Private timeFormat As String = "dddd, MMMM dd, yyyy  hh:mm:ss tt"
    Private selectedProductId As Integer = 0
    Private selectedProductName As String = ""
    Private selectedSystemQty As Integer = 0

    Private Sub AuditForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
        ' Set form size to match other forms (Dashboard size)


        ' Apply DataGridView styling only (no positioning)
        ApplyDataGridViewStyle()

        LoadProducts()

        ' Start timer for real-time clock
        Timer1.Interval = 1000
        Timer1.Start()
        UpdateTimeDisplay()

        ' Update welcome label
        lblWelcome.Text = "Welcome, " & CurrentUser.Username & " (" & CurrentUser.Role & ")"

        ' Hide buttons based on role
        Select Case CurrentUser.Role
            Case "admin"
                btnUserManagement.Visible = True
            Case "stock_manager"
                btnUserManagement.Visible = False
            Case "inventory_auditor"
                btnProducts.Visible = False
                btnAdjustStock.Visible = False
                btnUserManagement.Visible = False
        End Select
    End Sub

    Private Sub ApplyDataGridViewStyle()
        ' Style the DataGridView only - no positioning
        With dgvProducts
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ColumnHeadersVisible = True
            .BackgroundColor = Color.FromArgb(11, 14, 20)
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False
            .MultiSelect = False

            ' Column Header Style
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(9, 64, 103)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 45

            ' Default Cell Style
            .DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
            .DefaultCellStyle.ForeColor = Color.White
            .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(61, 169, 252)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowTemplate.Height = 35

            ' Alternating Row Style
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)

            ' Grid Line Color
            .GridColor = Color.FromArgb(40, 40, 40)
        End With
    End Sub

    Private Sub LoadProducts(Optional ByVal searchTerm As String = "")
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                Dim query As String = "SELECT Id, Name, Quantity FROM Products"

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    query &= " WHERE Name LIKE @searchTerm"
                End If

                query &= " ORDER BY Name"

                Dim adapter As New SqlDataAdapter(query, conn)

                If Not String.IsNullOrWhiteSpace(searchTerm) Then
                    adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
                End If

                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvProducts.DataSource = dt

                ' Configure columns
                If dgvProducts.Columns.Contains("Id") Then
                    dgvProducts.Columns("Id").Visible = False
                End If

                If dgvProducts.Columns.Contains("Name") Then
                    dgvProducts.Columns("Name").HeaderText = "PRODUCT NAME"
                    dgvProducts.Columns("Name").DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                End If

                If dgvProducts.Columns.Contains("Quantity") Then
                    dgvProducts.Columns("Quantity").HeaderText = "SYSTEM COUNT"
                    dgvProducts.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvProducts.Columns("Quantity").DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                End If

                ' Auto size columns to fill
                dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                dgvProducts.ClearSelection()
                ClearAuditSummary()

            Catch ex As Exception
                MessageBox.Show("Error loading products: " & ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub dgvProducts_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvProducts.SelectionChanged
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvProducts.SelectedRows(0)

            ' Check if cells exist and have values
            If selectedRow.Cells("Id").Value IsNot Nothing AndAlso
               Not IsDBNull(selectedRow.Cells("Id").Value) Then
                selectedProductId = Convert.ToInt32(selectedRow.Cells("Id").Value)
            End If

            If selectedRow.Cells("Name").Value IsNot Nothing AndAlso
               Not IsDBNull(selectedRow.Cells("Name").Value) Then
                selectedProductName = selectedRow.Cells("Name").Value.ToString()
            End If

            If selectedRow.Cells("Quantity").Value IsNot Nothing AndAlso
               Not IsDBNull(selectedRow.Cells("Quantity").Value) Then
                selectedSystemQty = Convert.ToInt32(selectedRow.Cells("Quantity").Value)
            End If

            ' Update summary panel
            lblSelectedProduct.Text = "Selected: " & selectedProductName
            lblSystemCount.Text = "System Count: " & selectedSystemQty.ToString()
            lblPhysicalCount.Text = "Physical Count: -"
            lblDiscrepancy.Text = "Discrepancy: -"
        Else
            ClearAuditSummary()
        End If
    End Sub

    Private Sub ClearAuditSummary()
        selectedProductId = 0
        selectedProductName = ""
        selectedSystemQty = 0
        lblSelectedProduct.Text = "No product selected"
        lblSystemCount.Text = "System Count: -"
        lblPhysicalCount.Text = "Physical Count: -"
        lblDiscrepancy.Text = "Discrepancy: -"
    End Sub

    Private Sub btnPerformNewAudit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPerformNewAudit.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to audit.", "No Selection",
                          MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Get physical count from user
        Dim input As String = InputBox("Enter physical count for " & selectedProductName,
                                       "Audit", selectedSystemQty.ToString())

        If input <> "" Then
            Dim physical As Integer
            If Integer.TryParse(input, physical) AndAlso physical >= 0 Then
                ' FIXED: Using empty string since txtAuditNotes doesn't exist
                SaveAudit(selectedProductId, selectedSystemQty, physical, "")
            Else
                MessageBox.Show("Please enter a valid positive number.", "Invalid Input",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub SaveAudit(ByVal productId As Integer, ByVal systemQty As Integer,
                         ByVal physicalQty As Integer, ByVal notes As String)
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                conn.Open()

                ' Save audit record
                Dim query As String = "INSERT INTO Audits (ProductId, UserId, SystemCount, PhysicalCount, Notes, AuditDate) " & _
                                    "VALUES (@pid, @uid, @sys, @phys, @notes, GETDATE())"

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@pid", productId)
                    cmd.Parameters.AddWithValue("@uid", CurrentUser.Id)
                    cmd.Parameters.AddWithValue("@sys", systemQty)
                    cmd.Parameters.AddWithValue("@phys", physicalQty)
                    cmd.Parameters.AddWithValue("@notes", notes)
                    cmd.ExecuteNonQuery()
                End Using

                ' Calculate discrepancy
                Dim discrepancy As Integer = physicalQty - systemQty

                ' Update display
                lblPhysicalCount.Text = "Physical Count: " & physicalQty.ToString()
                lblDiscrepancy.Text = "Discrepancy: " & discrepancy.ToString()

                ' Color code discrepancy
                If discrepancy > 0 Then
                    lblDiscrepancy.ForeColor = Color.Green
                ElseIf discrepancy < 0 Then
                    lblDiscrepancy.ForeColor = Color.Red
                Else
                    lblDiscrepancy.ForeColor = Color.White
                End If

                ' Visual feedback
                btnPerformNewAudit.BackColor = Color.LightGreen
                TimerColorReset.Interval = 200
                TimerColorReset.Start()

                ' Show result
                MessageBox.Show("Audit recorded successfully!" & vbCrLf &
                              "Discrepancy: " & discrepancy,
                              "Audit Complete",
                              MessageBoxButtons.OK,
                              If(discrepancy = 0, MessageBoxIcon.Information, MessageBoxIcon.Warning))

                ' Refresh data
                LoadProducts(txtSearch.Text)

            Catch ex As Exception
                MessageBox.Show("Error saving audit: " & ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnShowAuditHistory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowAuditHistory.Click
        Me.Hide()
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
    End Sub

    Private Sub btnShowProductsForAudit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowProductsForAudit.Click
        ' Refresh the product list
        LoadProducts(txtSearch.Text)

        ' Visual feedback
        btnShowProductsForAudit.BackColor = Color.LightGreen
        TimerColorReset.Interval = 200
        TimerColorReset.Start()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts(txtSearch.Text)
    End Sub

    ' ========== NAVIGATION BUTTON HANDLERS ==========
    Private Sub btnDashboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
    End Sub

    Private Sub btnProducts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProducts.Click
        Me.Hide()
        Dim productsForm As New ProductListForm()
        productsForm.Show()
    End Sub

    Private Sub btnAdjustStock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdjustStock.Click
        Me.Hide()
        Dim adjustStockForm As New AdjustStockForm()
        adjustStockForm.Show()
    End Sub

    Private Sub btnNewAudit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewAudit.Click
        ' Already on Audit form, just refresh
        LoadProducts(txtSearch.Text)
        txtSearch.Clear()
        ClearAuditSummary()
    End Sub

    Private Sub btnReports_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReports.Click
        Me.Hide()
        Dim reportsForm As New ReportsForm()
        reportsForm.Show()
    End Sub

    Private Sub btnUserManagement_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUserManagement.Click
        If CurrentUser.Role = "admin" Then
            Me.Hide()
            Dim userManagementForm As New UserManagementForm()
            userManagementForm.Show()
        Else
            MessageBox.Show("Access denied. Admin privileges required.", "Access Denied",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
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
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        UpdateTimeDisplay()
    End Sub

    Private Sub lblTime_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblTime.Click
        If timeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt" Then
            timeFormat = "MM/dd/yyyy  HH:mm:ss"
        ElseIf timeFormat = "MM/dd/yyyy  HH:mm:ss" Then
            timeFormat = "dd-MMM-yyyy  hh:mm tt"
        Else
            timeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt"
        End If
        UpdateTimeDisplay()
    End Sub

    Private Sub UpdateTimeDisplay()
        If lblTime IsNot Nothing AndAlso Not lblTime.IsDisposed Then
            lblTime.Text = DateTime.Now.ToString(timeFormat)
        End If
    End Sub

    ' Timer for button color reset
    Private Sub TimerColorReset_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerColorReset.Tick
        btnPerformNewAudit.BackColor = SystemColors.Control
        btnShowAuditHistory.BackColor = SystemColors.Control
        btnShowProductsForAudit.BackColor = SystemColors.Control
        TimerColorReset.Stop()
    End Sub
End Class