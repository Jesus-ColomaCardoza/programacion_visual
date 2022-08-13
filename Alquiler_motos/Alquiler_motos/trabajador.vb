Imports System.Data.SqlClient

Public Class trabajador
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrartrabajador '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                TrabajadorTableAdapter.GetDataBy(txt_id.Text)
                TrabajadorTableAdapter.FillBy(Alquiler_motosDataSet1.trabajador, txt_id.Text)

                txt_c.Text = data(1)
                txt_dni.Text = data(2)
                txt_nom.Text = data(3)
                txt_ape.Text = data(4)
                txt_direc.Text = data(5)
                txt_tele.Text = data(6)
                txt_correo.Text = data(7)
                MessageBox.Show("Trabajador encontrado", "Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Trabajador No encontrado", "Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_c.Text = ""
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

    Private Sub trabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source=DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet1.trabajador' Puede moverla o quitarla según sea necesario.
        Me.TrabajadorTableAdapter.Fill(Me.Alquiler_motosDataSet1.trabajador)
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Me.TrabajadorTableAdapter.Fill(Me.Alquiler_motosDataSet1.trabajador)
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_insertartrabajador " + "'" + txt_c.Text + "','" + txt_dni.Text + "','" + txt_nom.Text + "','" + txt_ape.Text + "','" + txt_direc.Text + "','" + txt_tele.Text + "','" + txt_correo.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Trabajador Agregado", "Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                txt_c.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""
            Else
                MessageBox.Show("Trabajador No Agregado", "Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminartrabajador " + "'" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Trabajador Eliminado", "Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_c.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""
            Else
                MessageBox.Show("Trabajador No Eliminado", "Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_actualizartrabajador " + "'" + txt_id.Text + "','" + txt_c.Text + "','" + txt_dni.Text + "','" + txt_nom.Text + "','" + txt_ape.Text + "','" + txt_direc.Text + "','" + txt_tele.Text + "','" + txt_correo.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Trabajador Actualizado", "Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_c.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""
            Else
                MessageBox.Show("Trabajador No Actualizado", "Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class