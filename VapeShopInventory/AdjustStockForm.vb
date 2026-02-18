Imports System.Data.SqlClient

Public Class AdjustStockForm

    Private Sub AdjustStockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Debug message to confirm AdjustStockForm loaded (can be removed later)
        MessageBox.Show("AdjustStockForm_Load fired!", "Debug: AdjustStockForm", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LoadProductsIntoComboBox()
        rbAdd.Checked = True ' Default to 'Add' operation
        nudQuantity.Minimum = 1 ' Ensure quantity is at least 1
    End Sub

    Private Sub LoadProductsIntoComboBox()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Dim query As String = "SELECT Id, Name FROM Products ORDER BY Name"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            cmbProduct.DataSource = dt
            cmbProduct.DisplayMember = "Name"
            cmbProduct.ValueMember = "Id"
            cmbProduct.SelectedIndex = -1 ' No product selected initially
        End Using
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        ' Debug message (can be removed later)
        MessageBox.Show("btnSave_Click fired!", "Debug: AdjustStockForm", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' --- Input Validation ---
        If cmbProduct.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a product.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If nudQuantity.Value <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not rbAdd.Checked AndAlso Not rbReduce.Checked Then
            MessageBox.Show("Please select either 'Add' or 'Reduce' for the stock operation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' --- End Input Validation ---

        Dim productId As Integer = CInt(cmbProduct.SelectedValue)
        Dim quantityChange As Integer = CInt(nudQuantity.Value)
        Dim notes As String = txtNotes.Text.Trim()
        Dim operationType As String = If(rbAdd.Checked, "Add", "Reduce")
        Dim currentStock As Integer = 0 ' To store current quantity for 'Reduce' check

        Using conn As New SqlConnection(DatabaseHelper.ConnectionString)
            Try
                conn.Open()

                ' Get current stock for reduction check
                If operationType = "Reduce" Then
                    Dim getQtyQuery As String = "SELECT Quantity FROM Products WHERE Id = @productId"
                    Using cmdGetQty As New SqlCommand(getQtyQuery, conn)
                        cmdGetQty.Parameters.AddWithValue("@productId", productId)
                        Dim result As Object = cmdGetQty.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                            currentStock = Convert.ToInt32(result)
                        Else
                            MessageBox.Show("Product not found or has no quantity recorded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End Using

                    If quantityChange > currentStock Then
                        MessageBox.Show("Cannot reduce stock by " & quantityChange & " units. Only " & currentStock & " units are currently in stock.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End If

                ' Update product quantity
                Dim updateQuery As String
                If rbAdd.Checked Then
                    updateQuery = "UPDATE Products SET Quantity = Quantity + @qtyChange, UpdatedAt = GETDATE() WHERE Id = @productId"
                Else ' rbReduce.Checked
                    updateQuery = "UPDATE Products SET Quantity = Quantity - @qtyChange, UpdatedAt = GETDATE() WHERE Id = @productId"
                End If

                Using cmdUpdate As New SqlCommand(updateQuery, conn)
                    cmdUpdate.Parameters.AddWithValue("@qtyChange", quantityChange)
                    cmdUpdate.Parameters.AddWithValue("@productId", productId)
                    cmdUpdate.ExecuteNonQuery()
                End Using

                ' Record stock adjustment in an audit/transaction log
                Dim logQuery As String = "INSERT INTO Audits (ProductId, UserId, SystemCount, PhysicalCount, Notes, AuditDate) VALUES (@pid, @uid, (SELECT Quantity FROM Products WHERE Id = @pid_log), @physCount, @notes, GETDATE())"
                Using cmdLog As New SqlCommand(logQuery, conn)
                    cmdLog.Parameters.AddWithValue("@pid", productId)
                    cmdLog.Parameters.AddWithValue("@uid", CurrentUser.Id)
                    ' --- THIS IS THE MISSING LINE THAT FIXES THE ERROR ---
                    cmdLog.Parameters.AddWithValue("@pid_log", productId) ' Declare the scalar variable for the subquery
                    ' --- END FIX ---

                    Dim newQuantity As Integer ' Calculate the new quantity for logging purposes
                    If operationType = "Add" Then
                        newQuantity = currentStock + quantityChange
                    Else
                        newQuantity = currentStock - quantityChange
                    End If
                    cmdLog.Parameters.AddWithValue("@physCount", newQuantity) ' Log the adjusted quantity

                    ' Use traditional string concatenation for compatibility with older VB.NET
                    cmdLog.Parameters.AddWithValue("@notes", "Stock " & operationType & " by " & quantityChange.ToString() & ". " & notes)
                    cmdLog.ExecuteNonQuery()
                End Using


                MessageBox.Show("Stock adjusted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub txtNotes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotes.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        ' The calling form (DashboardForm) should handle showing itself again
        ' when this modal dialog is closed. If this form was opened with Show(),
        ' then this pattern is correct:
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
    End Sub
End Class