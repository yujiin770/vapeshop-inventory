Imports System.Data.SqlClient

Public Class LoginForm
   

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnLogin
        gunatransitionentrance()
        txtPassword.UseSystemPasswordChar = Not chkShowHidePassword.Checked
    End Sub

    Sub gunatransitionentrance()
        pictureboxTransition.Show(PictureBox1)
        labeltransition.Show(Label1)
        labeltransition.Show(Label2)
        labeltransition.Show(Label4)
        textboxtransition.Show(txtUsername)
        textboxtransition.Show(txtPassword)
        buttontransition.Show(btnLogin)
        Showpasswordtransition.Show(chkShowHidePassword)
    End Sub



    Private Sub FileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Changed

    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtUsername_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter username and password.")
            Return
        End If

        Using conn As New SqlConnection("Data Source=LAPTOP-542UCCR5\SQLEXPRESS;Database=InventoryDB;Integrated Security=SSPI")
            Try
                conn.Open()
                Dim query As String = "SELECT Id, Username, Role FROM Users WHERE Username = @user AND Password = @pass"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", password)   ' Plain text – okay for school project
                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Login successful – store user info in a global module
                        CurrentUser.Id = reader("Id")
                        CurrentUser.Username = reader("Username").ToString()
                        CurrentUser.Role = reader("Role").ToString()

                        ' Open the main dashboard
                        Dim dashboard As New DashboardForm()
                        dashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using
    End Sub

  

    Private Sub Guna2CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowHidePassword.CheckedChanged
        ' Toggle the password character visibility based on the checkbox state
        txtPassword.UseSystemPasswordChar = Not chkShowHidePassword.Checked
        ' Ensure the textbox retains focus
        txtPassword.Focus()
    End Sub
End Class
