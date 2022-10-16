Imports System.Data.SqlClient
Public Class cliente
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_tcliente.tipo_cliente' Puede moverla o quitarla según sea necesario.
        Me.Tipo_clienteTableAdapter.Fill(Me.Modelo_cbx_tcliente.tipo_cliente)
        cbx_tc.Text = ""

        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Alquiler_motosDataSet.cliente)

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")
        'Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True


    End Sub
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrarcliente '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then

                ClienteTableAdapter.FillBy(Alquiler_motosDataSet.cliente, txt_id.Text)
                'ClienteTableAdapter.Fill(Alquiler_motosDataSet.cliente)

                cbx_tc.Text = Tipo_clienteTableAdapter.FillBygetdireccion(data(1))
                txt_dni.Text = data(2)
                txt_nom.Text = data(3)
                txt_ape.Text = data(4)
                txt_direc.Text = data(5)
                txt_tele.Text = data(6)
                txt_correo.Text = data(7)
                MessageBox.Show("Cliente encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Cliente No encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbx_tc.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""
            End If
            cn.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Dim tc As String
        Try
            cn.Open()
            comando = cn.CreateCommand()

            tc = Tipo_clienteTableAdapter.FillBygettipo(cbx_tc.Text)
            comando.CommandText = "declare @id char(4) exec sp_insertarcliente " + "'" + tc + "','" + txt_dni.Text + "','" + txt_nom.Text + "','" + txt_ape.Text + "','" + txt_direc.Text + "','" + txt_tele.Text + "','" + txt_correo.Text + "',@id output select @id as id"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                cbx_tc.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""

            Else
                MessageBox.Show("Cliente No Agregado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If (data.Read) Then
                MessageBox.Show("Cliente Agregado con id: " + data(0), "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = data(0)
            End If

            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminarcliente " + "'" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Cliente Eliminado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                cbx_tc.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""
            Else
                MessageBox.Show("Cliente No Eliminado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim tc As String
        Try
            cn.Open()
            comando = cn.CreateCommand()

            tc = Tipo_clienteTableAdapter.FillBygettipo(cbx_tc.Text)
            comando.CommandText = "exec sp_actualizarcliente " + "'" + txt_id.Text + "','" + tc + "','" + txt_dni.Text + "','" + txt_nom.Text + "','" + txt_ape.Text + "','" + txt_direc.Text + "','" + txt_tele.Text + "','" + txt_correo.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Cliente Actualizado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                cbx_tc.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""
            Else
                MessageBox.Show("Cliente No Actualizado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Me.ClienteTableAdapter.Fill(Me.Alquiler_motosDataSet.cliente)
    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        Alquiler.cbx_idcliente.Text = Me.txt_id.Text
        reserva.cbx_idcliente.Text = Me.txt_id.Text
        Me.Close()

    End Sub

    Private Sub txt_filtro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_filtro.KeyPress
        If (cbx_filtro.Text Like "DNI") Then
            ClienteTableAdapter.FillBy_filtrodni(Alquiler_motosDataSet.cliente, txt_filtro.Text)
        ElseIf (cbx_filtro.Text Like "Nombres") Then
            ClienteTableAdapter.FillBy_filtronombres(Alquiler_motosDataSet.cliente, txt_filtro.Text)
        ElseIf (cbx_filtro.Text Like "Apellidos") Then
            ClienteTableAdapter.FillBy_filtroapellidos(Alquiler_motosDataSet.cliente, txt_filtro.Text)
        End If
    End Sub
End Class