Imports System.Data.SqlClient

Public Class login
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If (cbx_tipousuario.Text <> "" And cbx_idtrabajador.Text <> "" And txtuser.Text <> "" And txtpassword.Text <> "") Then

            Try
                cn.Open()
                comando = cn.CreateCommand()
                comando.CommandText = "select tu.descripcion, t.id_trabajor,concat(t.nombres,' '+t.apellidos),u.clave from usuarios u
	                                inner join trabajador t on t.id_trabajor=u.id_trabajor
	                                inner join tipo_usuario tu on tu.id_tipo_usuario=u.id_tipo_usuario
	                                where t.id_trabajor='" + cbx_idtrabajador.Text + "'"
                data = comando.ExecuteReader()
                data.Read()
                If (data(0) = cbx_tipousuario.Text And data(1) = cbx_idtrabajador.Text And data(2) = txtuser.Text And data(3) = txtpassword.Text) Then
                    MessageBox.Show("Bienvenido al Sistema", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    If (cbx_tipousuario.Text <> "Administrador") Then
                        menu_principal.TipoToolStripMenuItem.Enabled = False
                        menu_principal.TipoComprobanteToolStripMenuItem.Enabled = False
                        menu_principal.TipoUsuariosToolStripMenuItem.Enabled = False
                        menu_principal.TrabajadorToolStripMenuItem.Enabled = False
                        menu_principal.UsuariosToolStripMenuItem.Enabled = False
                        menu_principal.FormasDePagoToolStripMenuItem.Enabled = False

                    End If
                    Me.Close()
                    'menu_principal.lbl_usuario.Text = txtuser.Text ''''

                    menu_principal.Show()
                Else
                    MessageBox.Show("Error en Ingresar, Datos incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                cn.Close()
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Complete todos los espacios en Blanco", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        menu_principal.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_trabajador.trabajador' Puede moverla o quitarla según sea necesario.
        Me.TrabajadorTableAdapter.FillBy_trabajadorconcuentausuario(Me.Modelo_cbx_trabajador.trabajador)
        cbx_idtrabajador.Text = ""

        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_tusuario.tipo_usuario' Puede moverla o quitarla según sea necesario.
        Me.Tipo_usuarioTableAdapter.Fill(Me.Modelo_cbx_tusuario.tipo_usuario)
        cbx_tipousuario.Text = ""

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")

        txtuser.Enabled = False

    End Sub

    Private Sub cbx_idtrabajador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_idtrabajador.SelectedIndexChanged
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "select * from Trabajador where id_trabajor='" + cbx_idtrabajador.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                txtuser.Text = data(3) + " " + data(4)
            End If
            cn.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class