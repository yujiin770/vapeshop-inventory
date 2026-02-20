Imports System.Data.SqlClient

Public Class AdjustStockForm
    Private timeFormat As String = "dddd, MMMM dd, yyyy  hh:mm:ss tt"
    Private currentStock As Integer = 0

    Private Sub AdjustStockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        ' Apply modern styling to controls
        ApplyModernStyle()

        LoadProductsIntoComboBox()
        rbAdd.Checked = True ' Default to 'Add' operation
        nudQuantity.Minimum = 1 ' Ensure quantity is at least 1
        nudQuantity.Maximum = 10000 ' Set reasonable maximum

        ' Start timer for real-time clock
        Timer1.Interval = 1000
        Timer1.Start()
        UpdateTimeDisplay()

        ' Update welcome label
        lblWelcome.Text = "Welcome, " & CurrentUser.Username & " (" & CurrentUser.Role & ")"
    End Sub

    Private Sub ApplyModernStyle()
        ' Style the panel to match dashboard
        Guna2Panel1.BackColor = Color.FromArgb(9, 64, 103)
        Guna2Panel1.BorderRadius = 12

       
        ' Style action buttons
        StyleActionButton(btnSave, "SAVE", Color.FromArgb(0, 120, 215))
        StyleActionButton(btnBack, "BACK", Color.FromArgb(100, 100, 120))

        ' Style radio buttons
        rbAdd.ForeColor = Color.White
        rbAdd.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        rbReduce.ForeColor = Color.White
        rbReduce.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        ' Style labels
        Label1.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label2.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label3.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Label3.ForeColor = Color.White
        lblStockStatus.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblStockStatus.ForeColor = Color.FromArgb(255, 180, 100)

        ' Style combo box
        cmbProduct.FlatStyle = FlatStyle.Flat
        cmbProduct.BackColor = Color.FromArgb(30, 30, 40)
        cmbProduct.ForeColor = Color.White
        cmbProduct.Font = New Font("Segoe UI", 10)

        ' Style text box
        txtNotes.BackColor = Color.FromArgb(30, 30, 40)
        txtNotes.ForeColor = Color.White
        txtNotes.Font = New Font("Segoe UI", 10)
        txtNotes.BorderStyle = BorderStyle.FixedSingle

        ' Style numeric up-down
        nudQuantity.BackColor = Color.FromArgb(30, 30, 40)
        nudQuantity.ForeColor = Color.White
        nudQuantity.Font = New Font("Segoe UI", 10)
    End Sub

    Private Sub StyleNavigationButton(ByVal btn As Guna.UI2.WinForms.Guna2Button, ByVal text As String, ByVal icon As String, Optional ByVal isLogout As Boolean = False)
        btn.Text = text
        btn.Font = New Font("Segoe UI", 10.8, FontStyle.Bold)
        btn.ForeColor = Color.White
        btn.FillColor = Color.FromArgb(9, 64, 103)
        btn.HoverState.FillColor = If(isLogout, Color.FromArgb(255, 77, 77), Color.FromArgb(61, 169, 252))
        btn.HoverState.ForeColor = If(isLogout, Color.White, Color.FromArgb(9, 64, 103))
        btn.BorderRadius = 6
        btn.BorderThickness = 2
        btn.BorderColor = Color.FromArgb(9, 64, 103)
        btn.Cursor = Cursors.Hand
        btn.ImageSize = New Size(25, 25)
        btn.ImageOffset = New Point(15, 0)
        btn.TextOffset = New Point(5, 0)

        ' Set icons (you can replace with actual images)
        Select Case text
            Case "Dashboard"
                btn.Image = My.Resources.DashboardIcon2 ' Use your existing resources
            Case "Products"
                btn.Image = My.Resources.product2
            Case "Stocks"
                btn.Image = My.Resources.trend2
            Case "New Audit"
                btn.Image = My.Resources.add_product
            Case "Reports"
                btn.Image = My.Resources.report
            Case "Users"
                ' Add user icon if available
            Case "Logout"
                btn.Image = My.Resources.logout
        End Select
    End Sub

    Private Sub StyleActionButton(ByVal btn As Button, ByVal text As String, ByVal color As Color)
        btn.Text = text
        btn.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btn.BackColor = color
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 1
        btn.FlatAppearance.BorderColor = color
        btn.Cursor = Cursors.Hand
        btn.Height = 45

        ' Add hover effect
        AddHandler btn.MouseEnter, AddressOf ActionButton_MouseEnter
        AddHandler btn.MouseLeave, AddressOf ActionButton_MouseLeave
    End Sub

    Private Sub ActionButton_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(61, 169, 252)
        btn.FlatAppearance.BorderColor = Color.White
    End Sub

    Private Sub ActionButton_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        If btn Is btnSave Then
            btn.BackColor = Color.FromArgb(0, 120, 215)
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 120, 215)
        ElseIf btn Is btnBack Then
            btn.BackColor = Color.FromArgb(100, 100, 120)
            btn.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 120)
        End If
    End Sub

    Private Sub LoadProductsIntoComboBox()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                Dim query As String = "SELECT Id, Name, Quantity FROM Products ORDER BY Name"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                cmbProduct.DataSource = dt
                cmbProduct.DisplayMember = "Name"
                cmbProduct.ValueMember = "Id"
                cmbProduct.SelectedIndex = -1 ' No product selected initially

                ' Store quantities in a dictionary for quick access
                Dim productQuantities As New Dictionary(Of Integer, Integer)
                For Each row As DataRow In dt.Rows
                    productQuantities.Add(CInt(row("Id")), CInt(row("Quantity")))
                Next
            Catch ex As Exception
                MessageBox.Show("Error loading products: " & ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbProduct.SelectedValue IsNot Nothing AndAlso IsNumeric(cmbProduct.SelectedValue) Then
            UpdateCurrentStockDisplay()
        End If
    End Sub

    Private Sub UpdateCurrentStockDisplay()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                conn.Open()
                Dim productId As Integer = CInt(cmbProduct.SelectedValue)
                Dim query As String = "SELECT Quantity FROM Products WHERE Id = @id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", productId)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        currentStock = Convert.ToInt32(result)
                        lblStockStatus.Text = "Current Stock: " & currentStock.ToString()
                        lblStockStatus.Visible = True
                    End If
                End Using
            Catch ex As Exception
                ' Ignore errors when no product selected
            End Try
        End Using
    End Sub

    Private Sub rbAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Update visual feedback
        If rbAdd.Checked Then
            rbAdd.Font = New Font("Segoe UI", 10, FontStyle.Bold Or FontStyle.Underline)
            rbReduce.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            lblStockStatus.ForeColor = Color.FromArgb(150, 255, 150)
        ElseIf rbReduce.Checked Then
            rbReduce.Font = New Font("Segoe UI", 10, FontStyle.Bold Or FontStyle.Underline)
            rbAdd.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            lblStockStatus.ForeColor = Color.FromArgb(255, 150, 150)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' --- Input Validation ---
        If cmbProduct.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a product.", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbProduct.Focus()
            Return
        End If

        If nudQuantity.Value <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.", "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nudQuantity.Focus()
            Return
        End If

        Dim productId As Integer = CInt(cmbProduct.SelectedValue)
        Dim quantityChange As Integer = CInt(nudQuantity.Value)
        Dim notes As String = txtNotes.Text.Trim()
        Dim operationType As String = If(rbAdd.Checked, "Add", "Reduce")

        Using conn As New SqlConnection(DatabaseHelper.ConnectionString)
            Try
                conn.Open()

                ' Get current stock for validation
                Dim getQtyQuery As String = "SELECT Quantity FROM Products WHERE Id = @productId"
                Using cmdGetQty As New SqlCommand(getQtyQuery, conn)
                    cmdGetQty.Parameters.AddWithValue("@productId", productId)
                    Dim result As Object = cmdGetQty.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        currentStock = Convert.ToInt32(result)
                    Else
                        MessageBox.Show("Product not found or has no quantity recorded.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Validate reduction
                If operationType = "Reduce" AndAlso quantityChange > currentStock Then
                    MessageBox.Show("Cannot reduce stock by " & quantityChange & " units. " &
                                  "Only " & currentStock & " units are currently in stock.",
                                  "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Begin transaction
                Using transaction As SqlTransaction = conn.BeginTransaction()
                    Try
                        ' Update product quantity
                        Dim updateQuery As String
                        If rbAdd.Checked Then
                            updateQuery = "UPDATE Products SET Quantity = Quantity + @qtyChange, UpdatedAt = GETDATE() WHERE Id = @productId"
                        Else
                            updateQuery = "UPDATE Products SET Quantity = Quantity - @qtyChange, UpdatedAt = GETDATE() WHERE Id = @productId"
                        End If

                        Using cmdUpdate As New SqlCommand(updateQuery, conn, transaction)
                            cmdUpdate.Parameters.AddWithValue("@qtyChange", quantityChange)
                            cmdUpdate.Parameters.AddWithValue("@productId", productId)
                            cmdUpdate.ExecuteNonQuery()
                        End Using

                        ' Calculate new quantity for audit
                        Dim newQuantity As Integer
                        If operationType = "Add" Then
                            newQuantity = currentStock + quantityChange
                        Else
                            newQuantity = currentStock - quantityChange
                        End If

                        ' Record in audit log
                        Dim logQuery As String = "INSERT INTO Audits (ProductId, UserId, SystemCount, PhysicalCount, Notes, AuditDate) " & _
                                                "VALUES (@pid, @uid, @sysCount, @physCount, @notes, GETDATE())"
                        Using cmdLog As New SqlCommand(logQuery, conn, transaction)
                            cmdLog.Parameters.AddWithValue("@pid", productId)
                            cmdLog.Parameters.AddWithValue("@uid", CurrentUser.Id)
                            cmdLog.Parameters.AddWithValue("@sysCount", currentStock)
                            cmdLog.Parameters.AddWithValue("@physCount", newQuantity)
                            cmdLog.Parameters.AddWithValue("@notes", String.Format("Stock {0} by {1}. {2}",
                                                                                  operationType, quantityChange, notes))
                            cmdLog.ExecuteNonQuery()
                        End Using

                        ' Commit transaction
                        transaction.Commit()

                        ' Visual feedback
                        btnSave.BackColor = Color.LightGreen
                        TimerColorReset.Interval = 200
                        TimerColorReset.Start()

                        MessageBox.Show("Stock adjusted successfully!" & vbCrLf &
                                      "Previous: " & currentStock & vbCrLf &
                                      "New: " & newQuantity,
                                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear form and refresh
                        cmbProduct.SelectedIndex = -1
                        nudQuantity.Value = 1
                        txtNotes.Clear()
                        lblStockStatus.Visible = False

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using

            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Visual feedback
        btnBack.BackColor = Color.LightGreen
        TimerColorReset.Interval = 200
        TimerColorReset.Start()

        ' Return to previous form
        Me.Hide()
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
    End Sub

    ' ========== NAVIGATION BUTTON HANDLERS ==========
    Private Sub btnDashboard_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub btnProducts_Click(ByVal sender As Object, ByVal e As EventArgs)
   
    End Sub

    Private Sub btnStocks_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStocks.Click
        ' Already on Stocks form, just refresh
        LoadProductsIntoComboBox()
        rbAdd.Checked = True
        nudQuantity.Value = 1
        txtNotes.Clear()
        lblStockStatus.Visible = False

        ' Visual feedback
        btnStocks.BackColor = Color.LightGreen
        TimerColorReset.Interval = 200
        TimerColorReset.Start()
    End Sub

    Private Sub btnNewAudit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewAudit.Click
        Me.Hide()
        Dim auditForm As New AuditForm()
        auditForm.Show()
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
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        UpdateTimeDisplay()
    End Sub

    Private Sub lblTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTime.Click
        If timeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt" Then
            timeFormat = "MM/dd/yyyy  HH:mm:ss"
        ElseIf timeFormat = "MM/dd/yyyy  HH:mm:ss" Then
            timeFormat = "dd-MMM-yyyy  hh:mm tt"
        Else
            timeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt"
        End If
        UpdateTimeDisplay()

        Dim tooltip As New ToolTip()
        tooltip.Show("Format changed", lblTime, 0, -20, 1000)
    End Sub

    Private Sub UpdateTimeDisplay()
        If lblTime IsNot Nothing AndAlso Not lblTime.IsDisposed Then
            lblTime.Text = DateTime.Now.ToString(timeFormat)
        End If
    End Sub

    ' Timer for button color reset
    Private Sub TimerColorReset_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerColorReset.Tick
        btnSave.BackColor = Color.FromArgb(0, 120, 215)
        btnBack.BackColor = Color.FromArgb(100, 100, 120)
        TimerColorReset.Stop()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

    End Sub

    Private Sub btnProducts_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        Me.Hide()
        Dim productsForm As New ProductListForm()
        productsForm.Show()
    End Sub

    Private Sub btnDashboard_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        Me.Close()
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()

    End Sub
End Class