Imports System.Data.SqlClient
Public Class tipo_cliente

    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub tipo_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_tcliente.tipo_cliente' Puede moverla o quitarla según sea necesario.
        Me.Tipo_clienteTableAdapter.Fill(Me.Alquiler_motosDataSet_tcliente.tipo_cliente)

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")
        'Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrartcliente '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then

                Tipo_clienteTableAdapter.FillBy(Alquiler_motosDataSet_tcliente.tipo_cliente, txt_id.Text)
                'ClienteTableAdapter.Fill(Alquiler_motosDataSet.cliente)

                txt_descripcion.Text = data(1)
                MessageBox.Show("Tipo de Cliente encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Tipo de Cliente No encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_descripcion.Text = ""
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_tcliente.tipo_cliente' Puede moverla o quitarla según sea necesario.
        Me.Tipo_clienteTableAdapter.Fill(Me.Alquiler_motosDataSet_tcliente.tipo_cliente)

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminartcliente '" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Tipo de Cliente Eliminado", "Tipo de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_descripcion.Text = ""
            Else
                MessageBox.Show("Tipo de Cliente No Eliminado", "Tipo de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_actualizartcliente '" + txt_id.Text + "','" + txt_descripcion.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Tipo de Cliente Actualizado", "Tipo de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_descripcion.Text = ""
            Else
                MessageBox.Show("Tipo de Cliente No Actualizado", "Tipo de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_insertartcliente '" + txt_descripcion.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Tipo de Cliente Agregado", "Tipo de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                txt_descripcion.Text = ""
            Else
                MessageBox.Show("Tipo de Cliente No Agregado", "Tipo de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class