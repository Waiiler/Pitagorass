Public Class Principal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("Desarrollado por John Cataño y Danyel Montoya", MsgBoxStyle.Information)
    End Sub

    Private Sub TeoremaPitagorasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeoremaPitagorasToolStripMenuItem.Click
        Pitagoras.Show()
    End Sub

    Private Sub AreaCircunferenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaCircunferenciaToolStripMenuItem.Click
        AreaCircunferencia.Show()
    End Sub

    Private Sub CircuitoSerieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CircuitoSerieToolStripMenuItem.Click
        CircuitoSerie.Show()
    End Sub

    Private Sub CircuitoParaleloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CircuitoParaleloToolStripMenuItem.Click
        CircuitoParalelo.Show()
    End Sub
End Class
