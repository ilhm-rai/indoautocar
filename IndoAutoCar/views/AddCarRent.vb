Public Class AddCarRent

    Private Sub AddCarRent_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim carRental As New CarRental
        addControlsToPanel(carRental, Dashboard.panelControls)
    End Sub

    Private Sub AddCarRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'IndoautocarDataSet.t_pelanggan' table. You can move, or remove it, as needed.
        Me.T_pelangganTableAdapter.Fill(Me.IndoautocarDataSet.t_pelanggan)
        'TODO: This line of code loads data into the 'IndoautocarDataSet.t_mobil' table. You can move, or remove it, as needed.
        Me.T_mobilTableAdapter.Fill(Me.IndoautocarDataSet.t_mobil)
        If addNew Then
            cbCar.Text = "- Pilih Mobil -"
            cbCustomer.Text = "- Pilih Pelanggan -"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dtpRent.Format = DateTimePickerFormat.Custom
        dtpRent.CustomFormat = "yyyy-MM-dd"
        If Not (cbCar.Text.Equals("") And cbCustomer.Text.Equals("")) Then
            If addNew Then
                AddNewData("t_rental", "tanggal, no_plat, no_ktp, lama_rental", "'" & dtpRent.Text & "','" & cbCar.SelectedValue & "','" _
                           & cbCustomer.SelectedValue & "'," & txtLongRent.Text)
            Else
                UpdateData("t_rental", "tanggal='" & dtpRent.Text & "',no_plat='" & cbCar.SelectedValue & "',no_ktp='" & cbCustomer.SelectedValue _
                           & "', lama_rental=" & txtLongRent.Text, "id_rental", txtIdRental.Text)
            End If
        End If
        dtpRent.Format = DateTimePickerFormat.Long
    End Sub
End Class