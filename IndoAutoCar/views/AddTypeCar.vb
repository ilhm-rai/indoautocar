Public Class AddTypeCar

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If addNew Then
            AddNewData("t_jenis_mobil", "jenis_mobil", "'" & txtTypeCar.Text & "'")
        Else
            UpdateData("t_jenis_mobil", "jenis_mobil='" & txtTypeCar.Text & "'", "id_jenis_mobil", txtIdTypeCar.Text)
        End If
    End Sub

    Private Sub AddTypeCar_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim typeCars As New TypeCars
        addControlsToPanel(typeCars, Dashboard.panelControls)
    End Sub
End Class