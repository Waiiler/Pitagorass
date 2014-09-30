Public Class ClaseCP

    Public Function CalcularCP(ByRef R1 As Double, ByRef R2 As Double, ByRef R3 As Double, ByRef voltaje As Double) As Double
        Dim RT As Double
        RT = 1 / ((1 / R1) + (1 / R2) + (1 / R3))
        Return RT

    End Function

    Public Function EnviarIT(ByVal RT As Double, ByRef voltaje As Double) As Double
        Dim IT As Double
        IT = voltaje / RT
        Return IT
    End Function
End Class
