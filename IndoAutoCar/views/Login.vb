Public Class Login

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        openConnection()
        ExecuteReader("t_pengguna", "id_pengguna, nama_lengkap,hak_akses", "WHERE username='" + txtUsername.Text + "' AND password=SHA1('" + txtPassword.Text + "')")
        If dataReader.Read Then
            id_user = dataReader.GetValue(0)
            Dashboard.labelFullname.Text = dataReader.GetValue(1).ToString.ToUpper
            role = dataReader.GetValue(2)
            Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password anda salah!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
        closeConnection()
    End Sub

End Class