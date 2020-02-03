Public Class Cars

    Private Sub Cars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.T_view_carsTableAdapter.Fill(Me.IndoautocarDataSet.t_view_cars)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addNew = True
        addFormToPanel(AddCar)
        AddCar.txtNoPlat.Enabled = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData("t_view_cars", DataGridView1)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        addNew = False
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                addFormToPanel(AddCar)
                AddCar.txtNoPlat.Text = .Item(0, row).Value
                AddCar.txtNoPlat.Enabled = False
                AddCar.cbTypeCar.SelectedValue = .Item(1, row).Value
                AddCar.cbTypeCar.Text = .Item(3, row).Value
                AddCar.txtCarName.Text = .Item(2, row).Value
                AddCar.txtPabrikan.Text = .Item(4, row).Value
                AddCar.txtYear.Text = .Item(5, row).Value
                AddCar.txtTenaga.Text = .Item(6, row).Value
                AddCar.txtRentPrice.Text = .Item(7, row).Value
            End If
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                DeleteData("t_mobil", "no_plat", "'" & .Item(0, row).Value & "'")
                LoadData("t_view_cars", DataGridView1)
            End If
        End With
    End Sub
End Class
