Imports System.Data.SqlClient

Public Class DashboardForm
    Private timeFormat As String = "dddd, MMMM dd, yyyy  hh:mm:ss tt"

    Private Sub DashboardForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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

        ' Initialize both DataGridViews
        InitializeInventoryGrid()
        InitializeActivityGrid()

        ' Load all data
        DisplayOverallInventorySummary()
        LoadInventoryStatus()
        LoadRecentActivity()

        ' Start the timer for real-time clock
        Timer1.Interval = 1000 ' 1 second
        Timer1.Start()
        UpdateTimeDisplay()
    End Sub

    Private Sub InitializeInventoryGrid()
        ' Setup Inventory Status DataGridView
        With dgvInventoryStatus
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

            ' Column Header Style
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(9, 64, 103)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 35
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            ' Default Cell Style
            .DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
            .DefaultCellStyle.ForeColor = Color.White
            .DefaultCellStyle.Font = New Font("Segoe UI", 9.0!)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(61, 169, 252)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.Padding = New Padding(5)

            ' Alternating Row Style
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)

            ' Grid Line Color
            .GridColor = Color.FromArgb(40, 40, 40)

            ' Add color coding for status
            AddHandler .CellFormatting, AddressOf dgvInventoryStatus_CellFormatting
        End With
    End Sub

    Private Sub InitializeActivityGrid()
        ' Setup Recent Activity DataGridView
        With dgvRecentActivity
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

            ' Column Header Style
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(9, 64, 103)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 35
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

            ' Default Cell Style
            .DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
            .DefaultCellStyle.ForeColor = Color.White
            .DefaultCellStyle.Font = New Font("Segoe UI", 9.0!)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(61, 169, 252)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.Padding = New Padding(5)

            ' Alternating Row Style
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)

            ' Grid Line Color
            .GridColor = Color.FromArgb(40, 40, 40)

            ' Auto size columns to fill
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Add color coding for actions
            AddHandler .CellFormatting, AddressOf dgvRecentActivity_CellFormatting
        End With
    End Sub

    Private Sub LoadInventoryStatus()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                conn.Open()

                ' Query to get all products with their status
                Dim query As String = "SELECT " & _
                                      "Id, " & _
                                      "Name, " & _
                                      "Quantity, " & _
                                      "MinLevel, " & _
                                      "MaxLevel, " & _
                                      "CASE " & _
                                      "    WHEN Quantity < MinLevel THEN 'LOW STOCK' " & _
                                      "    WHEN Quantity > MaxLevel THEN 'OVERSTOCK' " & _
                                      "    ELSE 'NORMAL' " & _
                                      "END AS Status " & _
                                      "FROM Products " & _
                                      "WHERE Quantity < MinLevel OR Quantity > MaxLevel " & _
                                      "ORDER BY " & _
                                      "    CASE " & _
                                      "        WHEN Quantity < MinLevel THEN 1 " & _
                                      "        WHEN Quantity > MaxLevel THEN 2 " & _
                                      "        ELSE 3 " & _
                                      "    END, Name"

                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                dgvInventoryStatus.DataSource = dt

                ' Format columns
                If dgvInventoryStatus.Columns.Contains("Id") Then
                    dgvInventoryStatus.Columns("Id").Visible = False
                End If

                If dgvInventoryStatus.Columns.Contains("Name") Then
                    dgvInventoryStatus.Columns("Name").HeaderText = "PRODUCT NAME"
                    dgvInventoryStatus.Columns("Name").Width = 200
                    dgvInventoryStatus.Columns("Name").DefaultCellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
                End If

                If dgvInventoryStatus.Columns.Contains("Quantity") Then
                    dgvInventoryStatus.Columns("Quantity").HeaderText = "CURRENT QTY"
                    dgvInventoryStatus.Columns("Quantity").Width = 100
                    dgvInventoryStatus.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If dgvInventoryStatus.Columns.Contains("MinLevel") Then
                    dgvInventoryStatus.Columns("MinLevel").HeaderText = "MIN LEVEL"
                    dgvInventoryStatus.Columns("MinLevel").Width = 90
                    dgvInventoryStatus.Columns("MinLevel").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If dgvInventoryStatus.Columns.Contains("MaxLevel") Then
                    dgvInventoryStatus.Columns("MaxLevel").HeaderText = "MAX LEVEL"
                    dgvInventoryStatus.Columns("MaxLevel").Width = 90
                    dgvInventoryStatus.Columns("MaxLevel").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                If dgvInventoryStatus.Columns.Contains("Status") Then
                    dgvInventoryStatus.Columns("Status").HeaderText = "STATUS"
                    dgvInventoryStatus.Columns("Status").Width = 100
                    dgvInventoryStatus.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvInventoryStatus.Columns("Status").DefaultCellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
                End If

                ' Update summary labels
                UpdateInventorySummary()

            Catch ex As Exception
                MessageBox.Show("Error loading inventory status: " & ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub dgvInventoryStatus_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs)
        ' Color code the rows based on status
        If e.RowIndex >= 0 AndAlso dgvInventoryStatus.Columns.Contains("Status") Then
            Dim statusCell As DataGridViewCell = dgvInventoryStatus.Rows(e.RowIndex).Cells("Status")

            If statusCell.Value IsNot Nothing AndAlso Not IsDBNull(statusCell.Value) Then
                Dim status As String = statusCell.Value.ToString()

                Select Case status
                    Case "LOW STOCK"
                        ' Light red background for low stock
                        dgvInventoryStatus.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(70, 40, 40)
                        dgvInventoryStatus.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(255, 150, 150)
                        statusCell.Style.BackColor = Color.FromArgb(180, 70, 70)
                        statusCell.Style.ForeColor = Color.White
                        statusCell.Style.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)

                    Case "OVERSTOCK"
                        ' Light orange background for overstock
                        dgvInventoryStatus.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(70, 50, 30)
                        dgvInventoryStatus.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(255, 180, 100)
                        statusCell.Style.BackColor = Color.FromArgb(200, 120, 30)
                        statusCell.Style.ForeColor = Color.White
                        statusCell.Style.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)

                    Case "NORMAL"
                        ' Light green background for normal
                        dgvInventoryStatus.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(30, 70, 40)
                        dgvInventoryStatus.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(150, 255, 150)
                        statusCell.Style.BackColor = Color.FromArgb(50, 150, 50)
                        statusCell.Style.ForeColor = Color.White
                        statusCell.Style.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
                End Select
            End If
        End If
    End Sub

    Private Sub UpdateInventorySummary()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                conn.Open()

                ' Total Products
                Dim totalProductsQuery As String = "SELECT COUNT(Id) FROM Products"
                Using cmdTotalProducts As New SqlCommand(totalProductsQuery, conn)
                    Dim totalProducts As Integer = CInt(cmdTotalProducts.ExecuteScalar())
                    lblTotalProducts.Text = "Total Products: " & totalProducts.ToString()
                    lblTotalProducts.Visible = True
                End Using

                ' Total Stock
                Dim totalStockQuery As String = "SELECT ISNULL(SUM(Quantity), 0) FROM Products"
                Using cmdTotalStock As New SqlCommand(totalStockQuery, conn)
                    Dim totalStock As Integer = CInt(cmdTotalStock.ExecuteScalar())
                    lblTotalStock.Text = "Total Stock: " & totalStock.ToString()
                    lblTotalStock.Visible = True
                End Using

                ' Low Stock Count
                Dim lowStockQuery As String = "SELECT COUNT(Id) FROM Products WHERE Quantity < MinLevel"
                Using cmdLowStock As New SqlCommand(lowStockQuery, conn)
                    Dim lowStockCount As Integer = CInt(cmdLowStock.ExecuteScalar())
                    If lowStockCount > 0 Then
                        lblLowStockAlert.Text = "Low Stock Items: " & lowStockCount.ToString()
                        lblLowStockAlert.ForeColor = Color.FromArgb(255, 150, 150)
                        lblLowStockAlert.Visible = True
                    Else
                        lblLowStockAlert.Text = "No Low Stock Items"
                        lblLowStockAlert.ForeColor = Color.FromArgb(150, 255, 150)
                        lblLowStockAlert.Visible = True
                    End If
                End Using

                ' Overstock Count
                Dim overstockQuery As String = "SELECT COUNT(Id) FROM Products WHERE Quantity > MaxLevel"
                Using cmdOverstock As New SqlCommand(overstockQuery, conn)
                    Dim overstockCount As Integer = CInt(cmdOverstock.ExecuteScalar())
                    If overstockCount > 0 Then
                        lblOverstockCount.Text = "Overstock Items: " & overstockCount.ToString()
                        lblOverstockCount.ForeColor = Color.FromArgb(255, 180, 100)
                        lblOverstockCount.Visible = True
                    Else
                        lblOverstockCount.Text = "No Overstock Items"
                        lblOverstockCount.ForeColor = Color.FromArgb(150, 255, 150)
                        lblOverstockCount.Visible = True
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading inventory summary: " & ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LoadRecentActivity()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                ' Load raw data without formatting in SQL
                Dim query As String = "SELECT TOP 10 " & _
                                      "a.AuditDate, " & _
                                      "ISNULL(u.Username, 'System') AS [User], " & _
                                      "ISNULL(p.Name, 'Unknown') AS [Product], " & _
                                      "ISNULL(a.Notes, 'No details') AS [Details] " & _
                                      "FROM Audits a " & _
                                      "LEFT JOIN Products p ON a.ProductId = p.Id " & _
                                      "LEFT JOIN Users u ON a.UserId = u.Id " & _
                                      "ORDER BY a.AuditDate DESC"

                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Create a new DataTable with formatted columns
                Dim formattedDt As New DataTable()
                formattedDt.Columns.Add("Time", GetType(String))
                formattedDt.Columns.Add("User", GetType(String))
                formattedDt.Columns.Add("Product", GetType(String))
                formattedDt.Columns.Add("Action", GetType(String))
                formattedDt.Columns.Add("Details", GetType(String))

                ' Format each row
                For Each row As DataRow In dt.Rows
                    Dim formattedRow As DataRow = formattedDt.NewRow()

                    ' Handle potential null dates
                    If row("AuditDate") IsNot Nothing AndAlso Not IsDBNull(row("AuditDate")) Then
                        Dim auditDate As DateTime = Convert.ToDateTime(row("AuditDate"))
                        formattedRow("Time") = auditDate.ToString("dd MMM HH:mm")
                    Else
                        formattedRow("Time") = "Unknown"
                    End If

                    formattedRow("User") = row("User").ToString()
                    formattedRow("Product") = row("Product").ToString()

                    ' Determine action based on notes
                    Dim notes As String = row("Details").ToString()
                    If notes.Contains("Add") OrElse notes.Contains("add") Then
                        formattedRow("Action") = "➕ ADD"
                    ElseIf notes.Contains("Reduce") OrElse notes.Contains("reduce") Then
                        formattedRow("Action") = "➖ REDUCE"
                    Else
                        formattedRow("Action") = "📝 AUDIT"
                    End If

                    formattedRow("Details") = notes

                    formattedDt.Rows.Add(formattedRow)
                Next

                dgvRecentActivity.DataSource = formattedDt

                ' Configure column display properly
                ConfigureRecentActivityColumns()

            Catch ex As Exception
                MessageBox.Show("Error loading recent activity: " & ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ConfigureRecentActivityColumns()
        ' Make sure all columns are visible and properly sized
        With dgvRecentActivity
            ' Set auto-size mode to fill first
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            ' Hide the Details column completely
            If .Columns.Contains("Details") Then
                .Columns("Details").Visible = False
            End If

            ' Configure each column
            If .Columns.Contains("Time") Then
                .Columns("Time").HeaderText = "TIME"
                .Columns("Time").Width = 100
                .Columns("Time").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Time").DefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200)
                .Columns("Time").Visible = True
            End If

            If .Columns.Contains("User") Then
                .Columns("User").HeaderText = "USER"
                .Columns("User").Width = 80
                .Columns("User").DefaultCellStyle.ForeColor = Color.FromArgb(200, 200, 200)
                .Columns("User").Visible = True
            End If

            If .Columns.Contains("Product") Then
                .Columns("Product").HeaderText = "PRODUCT"
                .Columns("Product").Width = 200
                .Columns("Product").DefaultCellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
                .Columns("Product").DefaultCellStyle.ForeColor = Color.White
                .Columns("Product").Visible = True
            End If

            If .Columns.Contains("Action") Then
                .Columns("Action").HeaderText = "ACTION"
                .Columns("Action").Width = 90
                .Columns("Action").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns("Action").Visible = True

                ' Apply action colors
                For Each row As DataGridViewRow In .Rows
                    If row.Cells("Action").Value IsNot Nothing Then
                        Dim action As String = row.Cells("Action").Value.ToString()
                        Select Case action
                            Case "➕ ADD"
                                row.Cells("Action").Style.BackColor = Color.FromArgb(30, 70, 40)
                                row.Cells("Action").Style.ForeColor = Color.FromArgb(150, 255, 150)
                                row.Cells("Action").Style.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
                            Case "➖ REDUCE"
                                row.Cells("Action").Style.BackColor = Color.FromArgb(70, 40, 40)
                                row.Cells("Action").Style.ForeColor = Color.FromArgb(255, 150, 150)
                                row.Cells("Action").Style.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
                            Case "📝 AUDIT"
                                row.Cells("Action").Style.BackColor = Color.FromArgb(40, 40, 70)
                                row.Cells("Action").Style.ForeColor = Color.FromArgb(150, 150, 255)
                                row.Cells("Action").Style.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
                        End Select
                    End If
                Next
            End If

            ' Make the grid fill the available space
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Clear any selection
            .ClearSelection()
        End With
    End Sub

    Private Sub dgvRecentActivity_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs)
        ' This is kept for backward compatibility but we're now using ConfigureRecentActivityColumns for coloring
    End Sub

    Private Sub DisplayOverallInventorySummary()
        UpdateInventorySummary()
    End Sub

    ' --- Navigation Button Click Event Handlers ---

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        UpdateInventorySummary()
        LoadInventoryStatus()
        LoadRecentActivity()
    End Sub

    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        Me.Hide()
        Try
            Dim frm As New ProductListForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing ProductListForm: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End Try
    End Sub

    Private Sub btnAdjustStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjustStock.Click
        Me.Hide()
        Try
            Dim frm As New AdjustStockForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing AdjustStockForm: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End Try
    End Sub

    Private Sub btnNewAudit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewAudit.Click
        Me.Hide()
        Try
            Dim frm As New AuditForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing AuditForm: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End Try
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Me.Hide()
        Try
            Dim frm As New ReportsForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing ReportsForm: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End Try
    End Sub

    Private Sub btnUserManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserManagement.Click
        Me.Hide()
        Try
            Dim frm As New UserManagementForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing UserManagementForm: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End Try
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to log out?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Me.Close()
            Try
                Dim loginForm As New LoginForm()
                loginForm.Show()
            Catch ex As Exception
                MessageBox.Show("Error showing LoginForm: " & ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint
        ' This event handler can usually be left empty
    End Sub

    Private Sub lblLowStockAlert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLowStockAlert.Click

    End Sub

    ' ========== TIME FUNCTIONALITY ==========

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
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
End Class