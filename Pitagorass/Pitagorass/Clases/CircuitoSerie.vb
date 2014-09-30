Public Class CircuitoSerie

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim R1, R2, R3 As Double
        Dim resultado As Double

        R1 = Double.Parse(txtR1.Text)
        R2 = Double.Parse(txtR2.Text)
        R3 = Double.Parse(txtR3.Text)

        Dim Cir As ClaseCS = New ClaseCS
        resultado = Cir.CalcularCS(R1, R2, R3)
        txtResultado.Text = resultado.ToString()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtR1.Text = ""
        txtR2.Text = ""
        txtR3.Text = ""
        txtResultado.Text = ""
    End Sub
End Class