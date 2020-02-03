Public Class TypeCars

    Private Sub TypeCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.T_jenis_mobilTableAdapter.Fill(Me.IndoautocarDataSet.t_jenis_mobil)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addNew = True
        addFormToPanel(AddTypeCar)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                DeleteData("t_jenis_mobil", "id_jenis_mobil", .Item(0, row).Value)
                LoadData("t_jenis_mobil", DataGridView1)
            End If
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        addNew = False
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                addFormToPanel(AddTypeCar)
                AddTypeCar.txtIdTypeCar.Text = .Item(0, row).Value
                AddTypeCar.txtTypeCar.Text = .Item(1, row).Value
            End If
        End With
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData("t_jenis_mobil", DataGridView1)
    End Sub
End Class
