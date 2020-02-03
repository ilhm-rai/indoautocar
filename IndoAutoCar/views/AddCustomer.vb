Public Class AddCustomer

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If addNew Then
            AddNewData("t_pelanggan", "no_ktp, nama_pelanggan, alamat, no_hp", "'" & txtNoKTP.Text & "','" & txtName.Text & "','" & txtAddress.Text _
                       & "','" & txtPhone.Text & "'")
        Else
            UpdateData("t_pelanggan", "nama_pelanggan='" & txtName.Text & "', alamat='" & txtAddress.Text & "', no_hp='" & txtPhone.Text & "'",
                       "no_ktp", "'" & txtNoKTP.Text & "'")
        End If
    End Sub

    Private Sub AddCustomer_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim customers As New Customers
        addControlsToPanel(customers, Dashboard.panelControls)
    End Sub

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If addNew Then
            txtNoKTP.Enabled = True
        Else
            txtNoKTP.Enabled = False
        End If
    End Sub
End Class