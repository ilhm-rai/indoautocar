﻿Public Class Users

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.T_penggunaTableAdapter.Fill(Me.IndoautocarDataSet.t_pengguna)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addNew = True
        addFormToPanel(AddUser)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index()
                DeleteData("t_pengguna", "id_pengguna", .Item(0, row).Value)
                LoadData("t_pengguna", DataGridView1, , "ORDER BY id_pengguna ASC")
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        addNew = False
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                oldData = .Item(3, row).Value
                AddUser.txtIdUser.Text = .Item(0, row).Value
                AddUser.txtFullname.Text = .Item(1, row).Value
                AddUser.txtPhone.Text = .Item(2, row).Value
                AddUser.txtUsername.Text = .Item(3, row).Value
            End If
        End With
        addFormToPanel(AddUser)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData("t_pengguna", DataGridView1, , "ORDER BY id_pengguna ASC")
    End Sub
End Class
