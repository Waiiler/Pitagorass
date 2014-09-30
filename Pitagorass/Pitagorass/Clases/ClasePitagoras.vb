Public Class ClasePitagoras
    Public Function CalcularHipotenusa(ByVal catetoa As Double, ByVal catetob As Double) As Double
        Dim hipotenusa As Double
        hipotenusa = Math.Sqrt(Math.Pow(catetoa, 2) + Math.Pow(catetob, 2))
        Return hipotenusa
    End Function
End Class
