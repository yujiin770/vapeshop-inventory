Imports System.Data.SqlClient

Public Class ProductListForm
    Private Sub ProductListForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Dim query As String = "SELECT Id, Name, Description, Quantity, MinLevel, MaxLevel FROM Products ORDER BY Name"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvProducts.DataSource = table
            ' Hide Id column
            dgvProducts.Columns("Id").Visible = False
        End Using
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        LoadProducts()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Dim frm As New ProductEditForm()  ' we'll create this next
        frm.ShowDialog()
        LoadProducts()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEdit.Click
        If dgvProducts.SelectedRows.Count > 0 Then
            Dim productId As Integer = dgvProducts.SelectedRows(0).Cells("Id").Value
            Dim frm As New ProductEditForm(productId)
            frm.ShowDialog()
            LoadProducts()
        Else
            MessageBox.Show("Select a product to edit.")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a product to delete.")
            Return
        End If

        If MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim productId As Integer = dgvProducts.SelectedRows(0).Cells("Id").Value
            Using conn As SqlConnection = DatabaseHelper.GetConnection()
                conn.Open()
                Dim cmd As New SqlCommand("DELETE FROM Products WHERE Id = @id", conn)
                cmd.Parameters.AddWithValue("@id", productId)
                cmd.ExecuteNonQuery()
            End Using
            LoadProducts()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DashboardForm.Show()
        Me.Close()
    End Sub
End Class