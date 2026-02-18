Imports System.Data.SqlClient
Public Class ProductEditForm
    Private _productId As Integer? = Nothing

    ' Constructor for Add
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor for Edit
    Public Sub New(ByVal productId As Integer)
        InitializeComponent()
        _productId = productId
        LoadProduct()
    End Sub

    Private Sub LoadProduct()
        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            Dim query As String = "SELECT Name, Description, Quantity, MinLevel, MaxLevel FROM Products WHERE Id = @id"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", _productId)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtName.Text = reader("Name").ToString()
                    txtDescription.Text = reader("Description").ToString()
                    nudQuantity.Value = Convert.ToInt32(reader("Quantity"))
                    nudMinLevel.Value = Convert.ToInt32(reader("MinLevel"))
                    nudMaxLevel.Value = Convert.ToInt32(reader("MaxLevel"))  ' also need to set MaxLevel
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If txtName.Text.Trim() = "" Then
            MessageBox.Show("Product name is required.")
            Return
        End If

        Using conn As SqlConnection = DatabaseHelper.GetConnection()
            conn.Open()
            If _productId Is Nothing Then
                ' Insert new product
                Dim query As String = "INSERT INTO Products (Name, Description, Quantity, MinLevel, MaxLevel) VALUES (@name, @desc, @qty, @min, @max)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@qty", nudQuantity.Value)
                    cmd.Parameters.AddWithValue("@min", nudMinLevel.Value)
                    cmd.Parameters.AddWithValue("@max", nudMaxLevel.Value)
                    cmd.ExecuteNonQuery()
                End Using
            Else
                ' Update existing product
                Dim query As String = "UPDATE Products SET Name=@name, Description=@desc, Quantity=@qty, MinLevel=@min, MaxLevel=@max, UpdatedAt=GETDATE() WHERE Id=@id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", _productId)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text)
                    cmd.Parameters.AddWithValue("@qty", nudQuantity.Value)
                    cmd.Parameters.AddWithValue("@min", nudMinLevel.Value)
                    cmd.Parameters.AddWithValue("@max", nudMaxLevel.Value)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Using
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ProductEditForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DashboardForm.Show()
        Me.Hide()
    End Sub
End Class