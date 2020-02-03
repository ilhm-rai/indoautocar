Public Class Dashboard

    Private Sub btnCars_Click(sender As Object, e As EventArgs) Handles btnCars.Click
        Dim cars As New Cars
        addControlsToPanel(cars, panelControls)
    End Sub

    Private Sub btnCarRent_Click(sender As Object, e As EventArgs) Handles btnCarRent.Click
        Dim carRent As New CarRental
        addControlsToPanel(carRent, panelControls)
    End Sub

    Private Sub btnTypeCar_Click(sender As Object, e As EventArgs) Handles btnTypeCar.Click
        Dim typeCars As New TypeCars
        addControlsToPanel(typeCars, panelControls)
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim customers As New Customers
        addControlsToPanel(customers, panelControls)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim users As New Users
        addControlsToPanel(users, panelControls)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim logoutConfirmation As Integer
        logoutConfirmation = MessageBox.Show("Apa anda yakin?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logoutConfirmation = 6 Then
            Me.Dispose()
            Login.Show()
        End If
    End Sub
End Class