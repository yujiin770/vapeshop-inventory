Public Class DashboardForm
    Private Sub DashboardForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & CurrentUser.Username & " (" & CurrentUser.Role & ")"

        ' Hide buttons based on role
        Select Case CurrentUser.Role
            Case "admin"
                ' all buttons visible
                btnNewAudit.Visible = True
                ' maybe hide nothing
            Case "stock_manager"
                btnNewAudit.Visible = False   ' auditor only
                ' managers can do products and stock
            Case "inventory_auditor"
                btnProducts.Visible = False    ' auditors cannot manage products
                btnAdjustStock.Visible = False ' auditors cannot adjust stock
                btnNewAudit.Visible = True
        End Select
    End Sub



    Private Sub btnAdjustStock_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As New AdjustStockForm()
        frm.ShowDialog()
    End Sub

    Private Sub btnNewAudit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frm As New AuditForm()
        frm.ShowDialog()
    End Sub



    Private Sub btnLogout_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    
    Private Sub btnAdjustStock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjustStock.Click
        Dim frm As New AdjustStockForm()
        frm.ShowDialog()
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewAudit.Click
        Dim frm As New AuditForm()
        frm.ShowDialog()
    End Sub

    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        Dim frm As New ProductListForm()
        frm.ShowDialog()
    End Sub

  
    
    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        Dim frm As New ReportsForm()
        frm.ShowDialog()
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
End Class