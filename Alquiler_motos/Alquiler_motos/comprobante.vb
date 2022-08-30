Imports System.Data.SqlClient

Public Class comprobante

    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader

    Private Sub comprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_tcomprobante.tipo_comprobante' Puede moverla o quitarla según sea necesario.
        Me.Tipo_comprobanteTableAdapter.Fill(Me.Modelo_cbx_tcomprobante.tipo_comprobante)
        cbx_tcomprobante.Text = ""

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")
        'Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrarcomprobante '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                'para actuzaliar la tabla de las Reserva
                ComprobanteTableAdapter.FillBy(Alquiler_motosDataSet_comprobante.comprobante, txt_id.Text)

                cbx_tcomprobante.Text = Tipo_comprobanteTableAdapter.FillBygetdescripcion(data(1))
                txt_formapago.Text = data(2)
                txt_idreserva.Text = data(3)
                txt_subtotal.Text = data(5)
                txt_igv.Text = data(6)
                txt_total.Text = data(7)
                MessageBox.Show("Comprobante encontrado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Comprobante No encontrado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbx_tcomprobante.Text = ""
                txt_formapago.Text = ""
                txt_idreserva.Text = ""
                txt_subtotal.Text = ""
                txt_igv.Text = ""
                txt_total.Text = ""

            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminarcomprobante" + "'" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Comprobante Eliminado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cbx_tcomprobante.Text = ""
                txt_formapago.Text = ""
                txt_idreserva.Text = ""
                txt_subtotal.Text = ""
                txt_igv.Text = ""
                txt_total.Text = ""
            Else
                MessageBox.Show("Comprobante No Eliminado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim idcomprobante As String

        Try
            cn.Open()
            comando = cn.CreateCommand()

            'comvertir de direccion de garaje a codigo de garaje
            idcomprobante = Tipo_comprobanteTableAdapter.FillBygettipo(cbx_tcomprobante.Text)


            comando.CommandText = "exec sp_actualizarcomprobante '" + txt_id.Text + "','" + idcomprobante + "','" + txt_formapago.Text + "','" + txt_idreserva.Text + "'," + txt_subtotal.Text + "," + txt_igv.Text + "," + txt_total.Text
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Comprobante actualizada", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                ComprobanteTableAdapter.FillBy(Alquiler_motosDataSet_comprobante.comprobante, txt_id.Text)
                'txt_id.Text = ""
                cbx_tcomprobante.Text = ""
                txt_formapago.Text = ""
                txt_idreserva.Text = ""
                txt_subtotal.Text = ""
                txt_igv.Text = ""
                txt_total.Text = ""
            Else
                MessageBox.Show("Comprobante No Actualizada", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Dim idcomprobante As String

        Try
            cn.Open()
            comando = cn.CreateCommand()

            'comvertir de direccion de garaje a codigo de garaje
            idcomprobante = Tipo_comprobanteTableAdapter.FillBygettipo(cbx_tcomprobante.Text)


            comando.CommandText = "exec sp_insertarcomprobante " + "'" + idcomprobante + "','" + txt_formapago.Text + "','" + txt_idreserva.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Comprobante Agregado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                ' revisar esta linea de codigo, trabajar con el idreserva- ComprobanteTableAdapter.FillBy(Alquiler_motosDataSet_comprobante.comprobante, txt_id.Text)
                'txt_id.Text = ""
                cbx_tcomprobante.Text = ""
                txt_formapago.Text = ""
                txt_idreserva.Text = ""
                txt_subtotal.Text = ""
                txt_igv.Text = ""
                txt_total.Text = ""
            Else
                MessageBox.Show("Comprobante No Agregado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_comprobante.comprobante' Puede moverla o quitarla según sea necesario.
        Me.ComprobanteTableAdapter.Fill(Me.Alquiler_motosDataSet_comprobante.comprobante)
    End Sub


End Class