Public Class Pitagoras

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim catetoa As Double
        Dim catetob As Double
        Dim hipotenusa As Double

        catetoa = Double.Parse(txtCA.Text)
        catetob = Double.Parse(txtCB.Text)

        Dim hipo As ClasePitagoras = New ClasePitagoras

        hipotenusa = hipo.CalcularHipotenusa(catetoa, catetob)
        txtHipotenusa.Text = hipotenusa.ToString()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCA.Text = ""
        txtCB.Text = ""
        txtHipotenusa.Text = ""
    End Sub
End Class