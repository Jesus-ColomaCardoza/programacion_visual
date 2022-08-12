Public Class menu_principal
    Private Sub ComprobantesDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobantesDePagoToolStripMenuItem.Click

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        cliente.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        login.Close()
    End Sub
End Class