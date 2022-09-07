Public Class menu_principal


    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        cliente.btn_seleccionar.Enabled = False
        cliente.btn_seleccionar.Visible = False
        cliente.Show()

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrabajadorToolStripMenuItem.Click
        trabajador.Show()
    End Sub



    Private Sub MotosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MotosToolStripMenuItem.Click
        moto.btn_seleccionar.Visible = False
        moto.btn_seleccionar.Enabled = False
        moto.Show()

    End Sub

    Private Sub ReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservaToolStripMenuItem.Click
        reserva.Show()
        reserva.btn_seleccionarreserva.Visible() = False
        reserva.btn_seleccionarreserva.Enabled() = False

    End Sub

    Private Sub DetalleReservaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DetalleReservaToolStripMenuItem1.Click
        detalle_reserva.Show()
        'reserva.btn_dreserva.Visible() = True
        'reserva.btn_dreserva.Enabled() = True
    End Sub

    Private Sub TiposDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeClienteToolStripMenuItem.Click
        tipo_cliente.Show()
    End Sub

    Private Sub AgenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgenciasToolStripMenuItem.Click
        agencia.Show()
    End Sub

    Private Sub GarajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GarajesToolStripMenuItem.Click
        garaje.Show()
    End Sub

    Private Sub TiposDeComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeComprobanteToolStripMenuItem.Click
        tipo_comprobante.Show()
    End Sub

    Private Sub menu_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        login.Show()
    End Sub

    Private Sub ComprobantesDePagoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ComprobantesDePagoToolStripMenuItem2.Click
        comprobante.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        reportes.Show()
    End Sub

    Private Sub AlquilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlquilerToolStripMenuItem.Click
        Alquiler.Show()
    End Sub
End Class