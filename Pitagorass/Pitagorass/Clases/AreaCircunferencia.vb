Public Class AreaCircunferencia

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim radio As Double
        Dim area As Double


        radio = Double.Parse(txtRadio.Text)

        Dim AreaC As ClaseAC = New ClaseAC

        area = AreaC.CalcularAC(radio, area)
        txtArea.Text = area.ToString()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtArea.Text = ""
        txtRadio.Text = ""
    End Sub
End Class