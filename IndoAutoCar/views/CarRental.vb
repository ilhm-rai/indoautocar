Public Class CarRental

    Private Sub CarRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.T_view_rentTableAdapter.Fill(Me.IndoautocarDataSet.t_view_rent)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addNew = True
        addFormToPanel(AddCarRent)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData("t_view_rent", DataGridView1)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                DeleteData("t_rental", "id_rental", .Item(10, row).Value)
                LoadData("t_view_rent", DataGridView1)
            End If
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        addNew = False
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                addFormToPanel(AddCarRent)
                AddCarRent.dtpRent.Text = .Item(0, row).Value.ToString
                AddCarRent.cbCar.SelectedValue = .Item(1, row).Value
                AddCarRent.cbCustomer.SelectedValue = .Item(4, row).Value
                AddCarRent.txtLongRent.Text = .Item(8, row).Value
                AddCarRent.txtIdRental.Text = .Item(10, row).Value
            End If
        End With
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim reportRent As New PreviewReportRental
        addControlsToPanel(reportRent, Dashboard.panelControls)
    End Sub
End Class
