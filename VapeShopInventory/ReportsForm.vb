Imports System.Data.SqlClient

Public Class ReportsForm
    Private Sub btnOverstock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOverstock.Click
        LoadReport("SELECT Name, Quantity, MaxLevel FROM Products WHERE Quantity > MaxLevel")
    End Sub

    Private Sub btnUnderstock_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUnderstock.Click
        LoadReport("SELECT Name, Quantity, MinLevel FROM Products WHERE Quantity < MinLevel")
    End Sub

    Private Sub LoadReport(ByVal query As String)
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvReport.DataSource = dt
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DashboardForm.Show()
        Me.Close()
    End Sub
End Class