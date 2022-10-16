Imports System.Data.SqlClient
Public Class tipo_usuario

    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub tipo_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")

    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_tusuarios.tipo_usuario' Puede moverla o quitarla según sea necesario.
        Me.Tipo_usuarioTableAdapter.Fill(Me.Alquiler_motosDataSet_tusuarios.tipo_usuario)
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrartusuario '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then

                Tipo_usuarioTableAdapter.FillBy(Alquiler_motosDataSet_tusuarios.tipo_usuario, txt_id.Text)
                'ClienteTableAdapter.Fill(Alquiler_motosDataSet.cliente)

                txt_descripcion.Text = data(1)
                MessageBox.Show("Tipo de Usuario encontrado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Tipo de Usuario No encontrado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_descripcion.Text = ""
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminartusuario '" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Tipo de Cliente Usuario", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_descripcion.Text = ""
            Else
                MessageBox.Show("Tipo de Cliente No Usuario", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_actualizartusuario '" + txt_id.Text + "','" + txt_descripcion.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Tipo de Usuario Actualizado", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_descripcion.Text = ""
            Else
                MessageBox.Show("Tipo de Usuario No Actualizado", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_insertartusuario '" + txt_descripcion.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Tipo de Usuario Agregado", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                txt_descripcion.Text = ""
            Else
                MessageBox.Show("Tipo de Usuario No Agregado", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class