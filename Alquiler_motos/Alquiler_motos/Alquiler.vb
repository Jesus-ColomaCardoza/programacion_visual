Public Class Alquiler
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        moto.ShowDialog()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        reserva.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cliente.ShowDialog()
    End Sub

    Private Sub Alquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_dreserva.detalle_reserva' Puede moverla o quitarla según sea necesario.
        'Me.Detalle_reservaTableAdapter.Fill(Me.Alquiler_motosDataSet_dreserva.detalle_reserva)


        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_tcomprobante.tipo_comprobante' Puede moverla o quitarla según sea necesario.
        Me.Tipo_comprobanteTableAdapter.Fill(Me.Modelo_cbx_tcomprobante.tipo_comprobante)
        cbx_tcomprobante.Text = ""

        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_cliente.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Modelo_cbx_cliente.cliente)
        cbx_idcliente.Text = ""

        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_trabajador.trabajador' Puede moverla o quitarla según sea necesario.
        Me.TrabajadorTableAdapter.Fill(Me.Modelo_cbx_trabajador.trabajador)
        cbx_idtrabajador.Text = ""

        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_agencia.agencia' Puede moverla o quitarla según sea necesario.
        Me.AgenciaTableAdapter.Fill(Me.Modelo_cbx_agencia.agencia)
        cbx_agencia.Text = ""

    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        'debemos insertar el detalle primero
        If detalle_reserva.insertar_dreserva(txt_idreserva.Text, txt_idmoto.Text, datetime_finicio, nud_hinicio, nud_mininicio, datetime_ffin, nud_hfin, nud_minfin) Then
            txt_idmoto.Text = ""
            datetime_finicio.Value = DateTime.Now
            nud_hinicio.Value = 0
            nud_mininicio.Value = 0

            datetime_ffin.Value = DateTime.Now
            nud_hfin.Value = 0
            nud_minfin.Value = 0
        End If
        'muetra los detalles(simulacion de que agrega los productos) de la reserva en cuestion
        Detalle_reservaTableAdapter.FillByidreserva(Me.Alquiler_motosDataSet_dreserva.detalle_reserva, txt_idreserva.Text)
    End Sub

    Dim columna As Integer
    Dim fila As Integer
    Private Sub tablaproductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaproductos.CellDoubleClick
        If e.ColumnIndex = 0 Then
            columna = e.ColumnIndex
            fila = e.RowIndex
            'colocar los valores del detalle en la interfaz
            txt_idmoto.Text = tablaproductos.Item(columna + 2, fila).Value.ToString
        Else
            'MessageBox.Show("error")
        End If

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        detalle_reserva.eliminar_dreserva(tablaproductos.Item(columna, fila).Value.ToString)
        'vaciar los valores de la interfaz



        'muetra los detalles(simulacion de que elimina los productos) de la reserva en cuestion
        Detalle_reservaTableAdapter.FillByidreserva(Me.Alquiler_motosDataSet_dreserva.detalle_reserva, txt_idreserva.Text)

    End Sub
End Class