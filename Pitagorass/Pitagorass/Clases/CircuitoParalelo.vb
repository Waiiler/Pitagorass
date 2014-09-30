Public Class CircuitoParalelo

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim R1, R2, R3 As Double
        Dim IT As Double
        Dim RT As Double
        Dim voltaje As Double

        voltaje = Double.Parse(txtVoltaje.Text)
        R1 = Double.Parse(txtR1.Text)
        R2 = Double.Parse(txtR2.Text)
        R3 = Double.Parse(txtR3.Text)

        Dim CirP As ClaseCP = New ClaseCP

        RT = CirP.CalcularCP(R1, R2, R3, voltaje)
        txtRT.Text = RT.ToString()
        IT = CirP.EnviarIT(RT, voltaje)
        txtIT.Text = IT.ToString()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtR1.Text = ""
        txtR2.Text = ""
        txtR3.Text = ""
        txtVoltaje.Text = ""
        txtIT.Text = ""
        txtRT.Text = ""
    End Sub
End Class