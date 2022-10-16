Imports System.Data.SqlClient

Public Class usuarios
        Public cn As SqlConnection
        Public comando As SqlCommand
        Public data As SqlDataReader
    Private Sub usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_tusuarios.tipo_usuario' Puede moverla o quitarla según sea necesario.
        Me.Tipo_usuarioTableAdapter.Fill(Me.Alquiler_motosDataSet_tusuarios.tipo_usuario)
        cbx_tu.Text = ""
        txt_idtrabajador.Enabled = False
        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")


    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_usuarios.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.Alquiler_motosDataSet_usuarios.usuarios)

    End Sub

    Private Sub btn_buscartrabajador_Click(sender As Object, e As EventArgs) Handles btn_buscartrabajador.Click
        trabajador.btn_seleccionar.Enabled = True
        trabajador.btn_seleccionar.Visible = True
        trabajador.txt_id.Text = Me.txt_idtrabajador.Text
        trabajador.Show()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrarusuario '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then

                UsuariosTableAdapter.FillBy(Alquiler_motosDataSet_usuarios.usuarios, txt_id.Text)
                'ClienteTableAdapter.Fill(Alquiler_motosDataSet.cliente)

                cbx_tu.Text = Tipo_usuarioTableAdapter.Fillby_getdescripcion(data(1))
                txt_idtrabajador.Text = data(2)
                txt_clave.Text = data(3)

                MessageBox.Show("Usuario encontrado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Usuario No encontrado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbx_tu.Text = ""
                txt_idtrabajador.Text = ""
                txt_clave.Text = ""
            End If
            cn.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Dim tu As String
        Try
            cn.Open()
            comando = cn.CreateCommand()

            tu = Tipo_usuarioTableAdapter.Fillby_gettipo(cbx_tu.Text)
            comando.CommandText = "exec sp_insertarusuario " + "'" + tu + "','" + txt_idtrabajador.Text + "','" + txt_clave.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                cbx_tu.Text = ""
                txt_idtrabajador.Text = ""
                txt_clave.Text = ""

                MessageBox.Show("Usuario Agregado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                MessageBox.Show("Usuario No Agregado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim tu As String
        Try
            cn.Open()
            comando = cn.CreateCommand()

            tu = Tipo_usuarioTableAdapter.Fillby_gettipo(cbx_tu.Text)
            comando.CommandText = "exec sp_actualizarusuario " + "'" + txt_id.Text + "','" + tu + "','" + txt_idtrabajador.Text + "','" + txt_clave.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                cbx_tu.Text = ""
                txt_idtrabajador.Text = ""
                txt_clave.Text = ""

                MessageBox.Show("Usuario Actuzalizado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                MessageBox.Show("Usuario No Actuzalizado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminarusuario " + "'" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Usuario Eliminado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                cbx_tu.Text = ""
                txt_idtrabajador.Text = ""
                txt_clave.Text = ""
            Else
                MessageBox.Show("Usuario No Eliminado", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class