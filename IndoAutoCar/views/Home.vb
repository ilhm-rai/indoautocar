Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closeConnection()
        openConnection()
        ExecuteReader("t_mobil", "COUNT(no_plat)")
        If dataReader.Read Then
            labelCars.Text = dataReader.GetValue(0)
        End If
        closeConnection()
        openConnection()
        ExecuteReader("t_pengguna", "COUNT(id_pengguna)")
        If dataReader.Read Then
            labelCars.Text = dataReader.GetValue(0)
        End If
        closeConnection()
        openConnection()
        ExecuteReader("t_pelanggan", "COUNT(no_ktp)")
        If dataReader.Read Then
            labelCustomers.Text = dataReader.GetValue(0)
        End If
        closeConnection()
    End Sub
End Class
