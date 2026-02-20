Imports System.Data.SqlClient
Imports System.IO

Public Class ReportsForm
    Private timeFormat As String = "dddd, MMMM dd, yyyy  hh:mm:ss tt"


    Private Sub ApplyDataGridViewStyle()
        With dgvReport
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ColumnHeadersVisible = True
            .BackgroundColor = Color.FromArgb(11, 14, 20)
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False

            ' Column Header Style
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(9, 64, 103)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersHeight = 40

            ' Default Cell Style
            .DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
            .DefaultCellStyle.ForeColor = Color.White
            .DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(61, 169, 252)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowTemplate.Height = 30

            ' Alternating Row Style
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30)

            ' Grid Line Color
            .GridColor = Color.FromArgb(40, 40, 40)

            ' Auto size columns
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub LoadReport(ByVal query As String)
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Try
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvReport.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading report: " & ex.Message, "Database Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


 

    Private Sub ExportToCSV(ByVal filePath As String)
        Dim sb As New System.Text.StringBuilder()

        ' Add headers
        For i As Integer = 0 To dgvReport.Columns.Count - 1
            sb.Append(dgvReport.Columns(i).HeaderText)
            If i < dgvReport.Columns.Count - 1 Then sb.Append(",")
        Next
        sb.AppendLine()

        ' Add rows
        For Each row As DataGridViewRow In dgvReport.Rows
            For i As Integer = 0 To dgvReport.Columns.Count - 1
                If row.Cells(i).Value IsNot Nothing Then
                    Dim cellValue As String = row.Cells(i).Value.ToString()
                    If cellValue.Contains(",") Then
                        cellValue = """" & cellValue & """"
                    End If
                    sb.Append(cellValue)
                End If
                If i < dgvReport.Columns.Count - 1 Then sb.Append(",")
            Next
            sb.AppendLine()
        Next

        File.WriteAllText(filePath, sb.ToString())
    End Sub

    ' ========== SIDEBAR NAVIGATION BUTTONS ==========
    

    Private Sub btnProducts_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub



    Private Sub btnReports_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Refresh current report
        LoadReport("SELECT Name, Quantity, MinLevel, MaxLevel FROM Products ORDER BY Name")
    End Sub







    Private Sub UpdateTimeDisplay()
        If lblTime IsNot Nothing AndAlso Not lblTime.IsDisposed Then
            lblTime.Text = DateTime.Now.ToString(timeFormat)
        End If
    End Sub

    Private Sub btnReports_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click

    End Sub

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        Me.Hide()
        Dim DashboardForm As New DashboardForm()
        DashboardForm.Show()
    End Sub

    Private Sub btnProducts_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        Me.Hide()
        Dim ProductListForm As New ProductListForm()
        ProductListForm.Show()
    End Sub

    Private Sub btnAdjustStock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjustStock.Click
        Me.Hide()
        Dim adjustStockForm As New AdjustStockForm()
        adjustStockForm.Show()
    End Sub

    Private Sub btnNewAudit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewAudit.Click
        Me.Hide()
        Dim auditForm As New AuditForm()
        auditForm.Show()
    End Sub

    Private Sub ReportsForm_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        ' Update welcome label
        lblWelcome.Text = "Welcome, " & CurrentUser.Username & " (" & CurrentUser.Role & ")"

        ' Style the DataGridView
        ApplyDataGridViewStyle()

        ' Load default report
        LoadReport("SELECT Name, Quantity, MinLevel, MaxLevel FROM Products ORDER BY Name")

        ' Start timer for clock
        Timer1.Interval = 1000
        Timer1.Start()
        UpdateTimeDisplay()
    End Sub

    Private Sub btnUserManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserManagement.Click
        If CurrentUser.Role = "admin" Then
            Me.Hide()
            Dim userManagementForm As New UserManagementForm()
            userManagementForm.Show()
        Else
            MessageBox.Show("Access denied. Admin privileges required.", "Access Denied",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnLogout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
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

    Private Sub btnExport_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Export Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV files (*.csv)|*.csv"
            sfd.FileName = "Report_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    ExportToCSV(sfd.FileName)
                    MessageBox.Show("Report exported successfully!", "Export Complete",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error exporting: " & ex.Message, "Export Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub lbltime_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltime.Click
        If timeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt" Then
            timeFormat = "MM/dd/yyyy  HH:mm:ss"
        ElseIf timeFormat = "MM/dd/yyyy  HH:mm:ss" Then
            timeFormat = "dd-MMM-yyyy  hh:mm tt"
        Else
            timeFormat = "dddd, MMMM dd, yyyy  hh:mm:ss tt"
        End If
        UpdateTimeDisplay()
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        UpdateTimeDisplay()
    End Sub

    Private Sub btnOverstock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverstock.Click
        LoadReport("SELECT Name, Quantity, MaxLevel FROM Products WHERE Quantity > MaxLevel ORDER BY Quantity DESC")
    End Sub

    Private Sub btnUnderstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnderstock.Click
        LoadReport("SELECT Name, Quantity, MinLevel FROM Products WHERE Quantity < MinLevel ORDER BY Quantity ASC")
    End Sub
End Class