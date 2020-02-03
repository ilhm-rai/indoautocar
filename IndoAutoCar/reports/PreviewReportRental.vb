Public Class PreviewReportRental

    Private Sub PreviewReportRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.t_rentalTableAdapter.Fill(Me.indoautocarDataSet.t_rental)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnCarRent_Click(sender As Object, e As EventArgs) Handles btnCarRent.Click
        Dim carRental As New CarRental
        addControlsToPanel(carRental, Dashboard.panelControls)
    End Sub
End Class
