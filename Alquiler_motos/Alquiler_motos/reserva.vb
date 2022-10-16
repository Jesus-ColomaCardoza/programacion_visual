Imports System.Data.SqlClient
Public Class reserva

    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub cbox_estado_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_estado.CheckedChanged
        If cbox_estado.Checked = True Then
            cbox_estado.Text = "Pagada"
        Else
            cbox_estado.Text = "No Pagada"

        End If
    End Sub

    Private Sub reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_cliente.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Modelo_cbx_cliente.cliente)
        cbx_idcliente.Text = ""

        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_trabajador.trabajador' Puede moverla o quitarla según sea necesario.
        Me.TrabajadorTableAdapter.Fill(Me.Modelo_cbx_trabajador.trabajador)
        cbx_idtrabajador.Text = ""

        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_agencia.agencia' Puede moverla o quitarla según sea necesario.
        Me.AgenciaTableAdapter.Fill(Me.Modelo_cbx_agencia.agencia)
        cbx_agencia.Text = ""

        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_reserva.reserva' Puede moverla o quitarla según sea necesario.
        Me.ReservaTableAdapter.Fill(Me.Alquiler_motosDataSet_reserva.reserva)

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrarreserva '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                'para actuzaliar la tabla de las Reserva
                ReservaTableAdapter.FillBy(Alquiler_motosDataSet_reserva.reserva, txt_id.Text)

                cbx_agencia.Text = AgenciaTableAdapter.FillBygetnombre(data(1))
                cbx_idtrabajador.Text = data(2)
                cbx_idcliente.Text = data(3)
                cbox_estado.Checked = data(5)
                MessageBox.Show("Reserva encontrado", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Reserva No encontrado", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbx_agencia.Text = ""
                cbx_idtrabajador.Text = ""
                cbx_idcliente.Text = ""
                cbox_estado.Checked = False
            End If
            cn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_reserva.reserva' Puede moverla o quitarla según sea necesario.
        Me.ReservaTableAdapter.Fill(Me.Alquiler_motosDataSet_reserva.reserva)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminarreserva" + "'" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Reserva Eliminado", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cbx_agencia.Text = ""
                cbx_idtrabajador.Text = ""
                cbx_idcliente.Text = ""
                cbox_estado.Checked = False
            Else
                MessageBox.Show("Reserva No Eliminado", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim idagencia, idtrabajador, idcliente As String

        Try
            cn.Open()
            comando = cn.CreateCommand()

            'comvertir de direccion de garaje a codigo de garaje
            idagencia = AgenciaTableAdapter.FillBygetid(cbx_agencia.Text)
            idtrabajador = cbx_idtrabajador.Text
            idcliente = cbx_idcliente.Text

            comando.CommandText = "exec sp_actualizarreserva '" + txt_id.Text + "','" + idagencia + "','" + idtrabajador + "','" + idcliente + "'," + cbox_estado.Checked.ToString
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Reserva actualizada", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                cbx_agencia.Text = ""
                cbx_idtrabajador.Text = ""
                cbx_idcliente.Text = ""
                cbox_estado.Checked = False
            Else
                MessageBox.Show("Reserva No Actualizada", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Dim idagencia, idtrabajador, idcliente As String

        Try
            cn.Open()
            comando = cn.CreateCommand()

            'comvertir de direccion de garaje a codigo de garaje
            idagencia = AgenciaTableAdapter.FillBygetid(cbx_agencia.Text)
            idtrabajador = cbx_idtrabajador.Text
            idcliente = cbx_idcliente.Text

            comando.CommandText = "exec sp_insertarreserva " + "'" + idagencia + "','" + idtrabajador + "','" + idcliente + "'," + cbox_estado.Checked.ToString
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Reserva Agregado", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                cbx_agencia.Text = ""
                cbx_idtrabajador.Text = ""
                cbox_estado.Checked = False
            Else
                MessageBox.Show("Reserva No Agregado", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_seleccionarreserva_Click(sender As Object, e As EventArgs) Handles btn_seleccionarreserva.Click

        'realizar la busqueda en la interfaz de reserva y luego click en selecionarreserva
        Alquiler.cbx_agencia.Text = Me.cbx_agencia.Text
        Alquiler.cbx_idtrabajador.Text = Me.cbx_idtrabajador.Text
        Alquiler.cbx_idcliente.Text = Me.cbx_idcliente.Text
        Alquiler.cbox_estado.Checked = Me.cbox_estado.Checked

        Alquiler.txt_idreserva.Text = Me.txt_id.Text
        Alquiler.Detalle_reservaTableAdapter.FillByidreserva(Alquiler.Alquiler_motosDataSet_dreserva.detalle_reserva, Alquiler.txt_idreserva.Text)

        Me.Close()
    End Sub

    Private Sub btn_seleccionarcliente_Click(sender As Object, e As EventArgs) Handles btn_seleccionarcliente.Click
        cliente.Show()
    End Sub
End Class