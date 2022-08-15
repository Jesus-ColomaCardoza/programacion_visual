Public Class menu_principal


    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        cliente.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        login.Close()
    End Sub

    Private Sub TrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrabajadorToolStripMenuItem.Click
        trabajador.Show()
    End Sub



    Private Sub MotosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotosToolStripMenuItem.Click
        moto.Show()
    End Sub

    Private Sub ReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservaToolStripMenuItem.Click
        reserva.Show()
        reserva.btn_dreserva.Visible() = False
        reserva.btn_dreserva.Enabled() = False

    End Sub

    Private Sub DetalleReservaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DetalleReservaToolStripMenuItem1.Click
        reserva.Show()
        reserva.btn_dreserva.Visible() = True
        reserva.btn_dreserva.Enabled() = True
    End Sub
End Class