Imports System.Data.SqlClient

Public Class DatabaseHelper
    ' CHANGE THIS CONNECTION STRING TO MATCH YOUR SERVER
    Public Shared ReadOnly ConnectionString As String = "Data Source=LAPTOP-542UCCR5\SQLEXPRESS;Database=InventoryDB;Integrated Security=SSPI"

    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function
End Class
