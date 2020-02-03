Public Class Customers

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.T_pelangganTableAdapter.Fill(Me.IndoautocarDataSet.t_pelanggan)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addNew = True
        addFormToPanel(AddCustomer)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        addNew = False
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                addFormToPanel(AddCustomer)
                AddCustomer.txtNoKTP.Text = .Item(0, row).Value
                AddCustomer.txtName.Text = .Item(1, row).Value
                AddCustomer.txtAddress.Text = .Item(2, row).Value
                AddCustomer.txtPhone.Text = .Item(3, row).Value
            End If
        End With
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData("t_pelanggan", DataGridView1)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                DeleteData("t_pelanggan", "no_ktp", .Item(0, row).Value)
                LoadData("t_pelanggan", DataGridView1)
            End If
        End With
    End Sub
End Class
