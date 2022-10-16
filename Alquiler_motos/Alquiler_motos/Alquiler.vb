Imports System.Data.SqlClient


Public Class Alquiler
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader


    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        moto.ShowDialog()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        reserva.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_seleccionarcliente.Click
        cliente.btn_seleccionar.Enabled = True
        cliente.btn_seleccionar.Visible = True
        cliente.txt_id.Text = Me.cbx_idcliente.Text
        cliente.ShowDialog()
    End Sub

    Private Sub Alquiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_formapago.forma_pago' Puede moverla o quitarla según sea necesario.
        Me.Forma_pagoTableAdapter.Fill(Me.Modelo_cbx_formapago.forma_pago)
        cbx_formapago.Text = ""
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_dreserva.detalle_reserva' Puede moverla o quitarla según sea necesario.
        'Me.Detalle_reservaTableAdapter.Fill(Me.Alquiler_motosDataSet_dreserva.detalle_reserva)

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")
        'Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True

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

        btn_seleccionarcliente.Enabled = False
        btn_seleccionarcliente.Visible = False


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
        Dim finicio, ffin, hinicio, hfin, minicio, mfin As String
        If e.ColumnIndex = 0 Then
            columna = e.ColumnIndex
            fila = e.RowIndex

            'colocar los valores del detalle a la interfaz
            txt_idmoto.Text = tablaproductos.Item(columna + 2, fila).Value.ToString
            finicio = Mid(tablaproductos.Item(columna + 3, fila).Value.ToString, 1, 10)
            hinicio = Mid(tablaproductos.Item(columna + 3, fila).Value.ToString, 12, 2)
            minicio = Mid(tablaproductos.Item(columna + 3, fila).Value.ToString, 15, 2)

            ffin = Mid(tablaproductos.Item(columna + 4, fila).Value.ToString, 1, 10)
            hfin = Mid(tablaproductos.Item(columna + 4, fila).Value.ToString, 12, 2)
            mfin = Mid(tablaproductos.Item(columna + 4, fila).Value.ToString, 15, 2)

            Me.datetime_finicio.Value = finicio
            Me.nud_hinicio.Value = Val(hinicio)
            Me.nud_mininicio.Value = Val(minicio)

            Me.datetime_ffin.Value = ffin
            Me.nud_hfin.Value = Val(hfin)
            Me.nud_minfin.Value = Val(mfin)
            MessageBox.Show("Producto seleccionado", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Else
            MessageBox.Show("error en selección seleccione el id_detalle", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If detalle_reserva.eliminar_dreserva(tablaproductos.Item(columna, fila).Value.ToString) Then
            txt_idmoto.Text = ""
            datetime_finicio.Value = DateTime.Now
            nud_hinicio.Value = 0
            nud_mininicio.Value = 0

            datetime_ffin.Value = DateTime.Now
            nud_hfin.Value = 0
            nud_minfin.Value = 0
        End If

        'muetra los detalles(simulacion de que elimina los productos) de la reserva en cuestion
        Detalle_reservaTableAdapter.FillByidreserva(Me.Alquiler_motosDataSet_dreserva.detalle_reserva, txt_idreserva.Text)

    End Sub

    Private Sub txt_idcomprobante_TextChanged(sender As Object, e As EventArgs) Handles txt_idcomprobante.TextChanged
        cn.Close()
        'agregar metodo de busqueda de comprobante
        Dim fecha_datetime As DateTime
        Dim fecha As String, horas As String, minutos As String
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrarcomprobante '" + txt_idcomprobante.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                cbx_tcomprobante.Text = Tipo_comprobanteTableAdapter.FillBygetdescripcion(data(1))
                cbx_formapago.Text = data(2)
                txt_idreserva.Text = data(3)

                fecha_datetime = data(4)
                fecha = fecha_datetime.Date
                horas = fecha_datetime.Hour
                minutos = fecha_datetime.Minute

                Me.datetime_fecha.Value = fecha
                Me.nud_hora.Value = horas
                Me.nud_minuto.Value = minutos

                txt_subtotal.Text = data(5)
                txt_igv.Text = data(6)
                txt_total.Text = data(7)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_generarcomprobante_Click(sender As Object, e As EventArgs) Handles btn_generarcomprobante.Click
        cn.Close()

        Dim idcomprobante As String

        If cbx_tcomprobante.Text <> "" And cbx_formapago.Text <> "" Then
            Try
                cn.Open()
                comando = cn.CreateCommand()

                idcomprobante = Tipo_comprobanteTableAdapter.FillBygettipo(cbx_tcomprobante.Text)

                comando.CommandText = "declare @id char(4) exec sp_insertarcomprobante " + "'" + idcomprobante + "','" + cbx_formapago.Text + "','" + txt_idreserva.Text + "',@id output select @id as id"
                data = comando.ExecuteReader()
                If (data.RecordsAffected = False) Then
                    MessageBox.Show("Comprobante No Agregado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                If (data.Read) Then
                    MessageBox.Show("Comprobante Agregado con id: " + data(0), "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    txt_idcomprobante.Text = data(0)
                End If
                cn.Close()

            Catch ex As Exception
                MessageBox.Show("Ya existe comprobante de pago para esta reserva")
            End Try
        Else
            MessageBox.Show("Complete los espacios en blanco")
        End If


    End Sub

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        impresicion.Show()
    End Sub


End Class