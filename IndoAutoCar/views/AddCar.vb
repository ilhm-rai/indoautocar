Public Class AddCar

    Private Sub AddCar_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim cars As New Cars
        addControlsToPanel(cars, Dashboard.panelControls)
    End Sub

    Private Sub AddCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IndoautocarDataSet.t_jenis_mobil' table. You can move, or remove it, as needed.
        Me.T_jenis_mobilTableAdapter.Fill(Me.IndoautocarDataSet.t_jenis_mobil)
        If addNew Then
            cbTypeCar.Text = "- Pilih Tipe Mobil -"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not cbTypeCar.Text.Equals("- Pilih Tipe Mobil -") Then
            If addNew Then
                AddNewData("t_mobil", "no_plat, id_jenis_mobil, nama_mobil, pabrikan, tahun, cc, harga_sewa", "'" & txtNoPlat.Text & "'," _
                           & cbTypeCar.SelectedValue & ",'" & txtCarName.Text & "','" & txtPabrikan.Text & "','" & txtYear.Text & "','" & txtTenaga.Text _
                           & "'," & txtRentPrice.Text)
            Else
                UpdateData("t_mobil", "id_jenis_mobil=" & cbTypeCar.SelectedValue & ",nama_mobil='" & txtCarName.Text & "',pabrikan='" & txtPabrikan.Text _
                           & "',tahun='" & txtYear.Text & "',cc='" & txtTenaga.Text & "',harga_sewa=" & txtRentPrice.Text, "no_plat", "'" & txtNoPlat.Text & "'")
            End If
        End If
    End Sub

    Private Sub clearForm()
        txtCarName.Text = ""
        txtNoPlat.Text = ""
        txtPabrikan.Text = ""
        txtRentPrice.Text = ""
        txtTenaga.Text = ""
        txtYear.Text = ""
        cbTypeCar.Text = "- Pilih Tipe Mobil -"
    End Sub
End Class