Public Class ClaseAC
    Public Function CalcularAC(ByVal radio As Double, ByVal area As Double) As Double

        Dim Pi As Double
        Pi = 3.14159265358979

        area = Pi * Math.Pow(radio, 2)
        Return area

    End Function
End Class
