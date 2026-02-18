Imports System.Data.SqlClient

Public Class DashboardForm

    Private Sub DashboardForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & CurrentUser.Username & " (" & CurrentUser.Role & ")"

        ' Hide buttons based on role
        Select Case CurrentUser.Role
            Case "admin"
                btnNewAudit.Visible = True
                btnProducts.Visible = True
                btnAdjustStock.Visible = True
                btnReports.Visible = True
            Case "stock_manager"
                btnNewAudit.Visible = False
                btnProducts.Visible = True
                btnAdjustStock.Visible = True
                btnReports.Visible = True
                btnReports.Location = New Point(3, 300)
            Case "inventory_auditor"
                btnProducts.Visible = False
                btnAdjustStock.Visible = False
                btnNewAudit.Visible = True
                btnReports.Visible = True
                btnNewAudit.Location = New Point(2, 175)
                btnReports.Location = New Point(3, 225)
        End Select

        ' --- Initial DataGridView Setup (can be set in designer too) ---
        With dgvRecentActivity
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ColumnHeadersVisible = True ' Explicitly ensure headers are visible
            .BackgroundColor = Color.FromArgb(11, 14, 20) ' Match your form's background color
            .BorderStyle = BorderStyle.None
            .AllowUserToResizeColumns = False ' Prevent user from resizing columns
            .AllowUserToResizeRows = False    ' Prevent user from resizing rows
        End With

        ' Call new dashboard summary methods
        DisplayOverallInventorySummary()
        CheckForLowStock()
        CheckForOverstock()
        LoadRecentActivity() ' Load data and apply specific styling
    End Sub

    Private Sub DisplayOverallInventorySummary()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                conn.Open()

                Dim totalProductsQuery As String = "SELECT COUNT(Id) FROM Products"
                Using cmdTotalProducts As New SqlCommand(totalProductsQuery, conn)
                    Dim totalProducts As Integer = CInt(cmdTotalProducts.ExecuteScalar())
                    lblTotalProducts.Text = "Total Products: " & totalProducts.ToString()
                    lblTotalProducts.Visible = True
                End Using

                Dim totalStockQuery As String = "SELECT ISNULL(SUM(Quantity), 0) FROM Products"
                Using cmdTotalStock As New SqlCommand(totalStockQuery, conn)
                    Dim totalStock As Integer = CInt(cmdTotalStock.ExecuteScalar())
                    lblTotalStock.Text = "Total Stock: " & totalStock.ToString()
                    lblTotalStock.Visible = True
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading inventory summary: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lblTotalProducts.Visible = False
                lblTotalStock.Visible = False
            End Try
        End Using
    End Sub

    Private Sub CheckForLowStock()
        Dim lowStockProducts As New List(Of String)()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Dim query As String = "SELECT Name FROM Products WHERE Quantity < MinLevel ORDER BY Name"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    lowStockProducts.Add(reader("Name").ToString())
                End While
                reader.Close()
            End Using
        End Using

        If lowStockProducts.Count > 0 Then
            lblLowStockAlert.Text = "Low Stock Alert: " & String.Join(", ", lowStockProducts)
            lblLowStockAlert.ForeColor = Color.Red
            lblLowStockAlert.Visible = True
        Else
            lblLowStockAlert.Text = "No low stock alerts."
            lblLowStockAlert.ForeColor = Color.Green
            lblLowStockAlert.Visible = False
        End If
    End Sub

    Private Sub CheckForOverstock()
        Dim overstockProducts As New List(Of String)()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Dim query As String = "SELECT Name FROM Products WHERE Quantity > MaxLevel ORDER BY Name"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    overstockProducts.Add(reader("Name").ToString())
                End While
                reader.Close()
            End Using
        End Using

        If overstockProducts.Count > 0 Then
            lblOverstockCount.Text = "Overstocked: " & String.Join(", ", overstockProducts)
            lblOverstockCount.ForeColor = Color.OrangeRed
            lblOverstockCount.Visible = True
        Else
            lblOverstockCount.Text = "No overstocked items."
            lblOverstockCount.ForeColor = Color.Gray
            lblOverstockCount.Visible = False
        End If
    End Sub

    Private Sub LoadRecentActivity()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                Dim query As String = "SELECT TOP 5 p.Name AS Product, u.Username AS [User], " & _
                                      "a.Notes AS Activity, a.AuditDate AS Date " & _
                                      "FROM Audits a " & _
                                      "JOIN Products p ON a.ProductId = p.Id " & _
                                      "JOIN Users u ON a.UserId = u.Id " & _
                                      "ORDER BY a.AuditDate DESC"

                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvRecentActivity.DataSource = dt

                ' --- Apply Styling to DataGridView for Fixed Headers ---
                With dgvRecentActivity
                    .EnableHeadersVisualStyles = False ' Allow custom header styling

                    ' Column Header Style (Made more distinct)
                    .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(9, 64, 103) ' Dark blue
                    .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold) ' Slightly larger, bold font
                    .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter ' Center header text
                    .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised ' More distinct header border
                    .ColumnHeadersHeight = 30 ' Explicitly set header height (adjust as needed)
                    .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing ' Prevent header height resize

                    ' Default Cell Style
                    .DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
                    .DefaultCellStyle.ForeColor = Color.White
                    .DefaultCellStyle.SelectionBackColor = Color.FromArgb(61, 169, 252)
                    .DefaultCellStyle.SelectionForeColor = Color.Black
                    .DefaultCellStyle.Padding = New Padding(5)

                    ' Alternating Row Style
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)

                    ' Grid Line Color
                    .GridColor = Color.FromArgb(40, 40, 40)

                    ' --- Column Sizing for FIXED WIDTHS ---
                    ' This is the key change for "fixed" columns.
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None ' Disable auto-sizing mode

                    ' Manually set specific widths for each column
                    ' Adjust these pixel values (e.g., 150, 100, 250, 180) to fit your dgvRecentActivity control's total width and desired look.
                    ' The sum of these should roughly match your DataGridView.Width for it to fill.
                    If .Columns.Contains("Product") Then .Columns("Product").Width = 150 ' Example width
                    If .Columns.Contains("User") Then .Columns("User").Width = 80 ' Example width
                    If .Columns.Contains("Activity") Then .Columns("Activity").Width = 200 ' Example width
                    If .Columns.Contains("Date") Then .Columns("Date").Width = 150 ' Example width

                    ' To ensure horizontal scroll bar appears if columns exceed DGV width:
                    .ScrollBars = ScrollBars.Both

                    .ClearSelection()
                    .Visible = True
                End With

            Catch ex As Exception
                MessageBox.Show("Error loading recent activity: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgvRecentActivity.Visible = False
            End Try
        End Using
    End Sub

    ' --- Navigation Button Click Event Handlers ---

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        DisplayOverallInventorySummary()
        CheckForLowStock()
        CheckForOverstock()
        LoadRecentActivity()
    End Sub

    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        Me.Hide()
        Try
            Dim frm As New ProductListForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing ProductListForm: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End Try
    End Sub

    Private Sub btnAdjustStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjustStock.Click
        Me.Hide()
        Try
            Dim frm As New AdjustStockForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing AdjustStockForm: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End Try
    End Sub

    Private Sub btnNewAudit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewAudit.Click
        Me.Hide()
        Try
            Dim frm As New AuditForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing AuditForm: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Show()
        End Try
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Me.Hide()
        Try
            Dim frm As New ReportsForm()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error showing ReportsForm: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show("Error showing LoginForm: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint
        ' This event handler can usually be left empty if no custom drawing logic is needed.
    End Sub

End Class

