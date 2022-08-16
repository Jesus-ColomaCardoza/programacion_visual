Public Class detalle_reserva
    Private Sub detalle_reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_reserva.reserva' Puede moverla o quitarla según sea necesario.
        Me.ReservaTableAdapter.Fill(Me.Modelo_cbx_reserva.reserva)
        cbx_idreserva.Text = ""


    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        moto.btn_seleccionar.Visible = True
        moto.btn_seleccionar.Enabled = True
        moto.Show()
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click


        If (cbx_listar.Text Like "Listar todos los detalles") Then
            'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_dreserva.detalle_reserva' Puede moverla o quitarla según sea necesario.
            Me.Detalle_reservaTableAdapter.Fill(Me.Alquiler_motosDataSet_dreserva.detalle_reserva)
        ElseIf (cbx_listar.Text Like "Listar por reserva") Then
            Me.Detalle_reservaTableAdapter.FillByidreserva(Me.Alquiler_motosDataSet_dreserva.detalle_reserva, cbx_idreserva.Text)
        End If


    End Sub
End Class