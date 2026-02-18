Imports System.Data.SqlClient

Public Class AuditForm
    Private Sub AuditForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Dim query As String = "SELECT Id, Name, Quantity FROM Products ORDER BY Name"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvProducts.DataSource = dt
            dgvProducts.Columns("Id").Visible = False
        End Using
    End Sub

    Private Sub btnStartAudit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStartAudit.Click
        If dgvProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a product to audit.")
            Return
        End If
        Dim productId As Integer = dgvProducts.SelectedRows(0).Cells("Id").Value
        Dim productName As String = dgvProducts.SelectedRows(0).Cells("Name").Value.ToString()
        Dim systemQty As Integer = Convert.ToInt32(dgvProducts.SelectedRows(0).Cells("Quantity").Value)

        ' Show a simple input box (or a small form) to enter physical count
        Dim input As String = InputBox("Enter physical count for " & productName, "Audit", systemQty)
        If input <> "" Then
            Dim physical As Integer
            If Integer.TryParse(input, physical) Then
                ' Save audit
                Using conn As SqlConnection = DatabaseHelper.GetConnection()
                    Dim query As String = "INSERT INTO Audits (ProductId, UserId, PhysicalCount, SystemCount, Notes) VALUES (@pid, @uid, @phys, @sys, @notes)"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@pid", productId)
                        cmd.Parameters.AddWithValue("@uid", CurrentUser.Id)
                        cmd.Parameters.AddWithValue("@phys", physical)
                        cmd.Parameters.AddWithValue("@sys", systemQty)
                        cmd.Parameters.AddWithValue("@notes", "") ' you could add a notes field
                        conn.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Audit recorded. Discrepancy: " & (physical - systemQty))
                LoadProducts() ' refresh
            Else
                MessageBox.Show("Invalid number.")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DashboardForm.Show()
        Me.Close()
    End Sub
End Class