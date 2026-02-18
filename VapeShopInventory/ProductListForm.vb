Imports System.Data.SqlClient

Public Class ProductListForm

    Private Sub ProductListForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadProducts() ' Load all products initially
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
    End Sub

    Private Sub LoadProducts(Optional ByVal searchTerm As String = "")
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Dim query As String = "SELECT Id, Name, Description, Quantity, MinLevel, MaxLevel FROM Products"

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " WHERE Name LIKE @searchTerm OR Description LIKE @searchTerm"
            End If

            query &= " ORDER BY Name"

            Dim adapter As New SqlDataAdapter(query, conn)

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                adapter.SelectCommand.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
            End If

            Dim table As New DataTable()
            adapter.Fill(table)
            dgvProducts.DataSource = table

            If dgvProducts.Columns.Contains("Id") Then
                dgvProducts.Columns("Id").Visible = False
            End If
        End Using
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        If Not IsNothing(txtSearch) Then
            txtSearch.Clear()
        End If
        LoadProducts()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim frm As New ProductEditForm()
        If frm.ShowDialog() = DialogResult.OK Then
            If Not IsNothing(txtSearch) Then
                LoadProducts(txtSearch.Text)
            Else
                LoadProducts()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim productId As Integer = dgvProducts.SelectedRows(0).Cells("Id").Value
            Dim frm As New ProductEditForm(productId)
            If frm.ShowDialog() = DialogResult.OK Then
                If Not IsNothing(txtSearch) Then
                    LoadProducts(txtSearch.Text)
                Else
                    LoadProducts()
                End If
            End If
        Else
            MessageBox.Show("Select a product to edit.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a product to delete.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete the selected product? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
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
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        LoadProducts(txtSearch.Text)
    End Sub

    ' --- Navigation Buttons (copied from Dashboard) ---
    Private Sub btnDashboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDashboard.Click
        Me.Close()
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
    End Sub

    Private Sub btnProducts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProducts.Click
        ' Already on ProductListForm, perhaps just refresh or do nothing.
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

 

End Class