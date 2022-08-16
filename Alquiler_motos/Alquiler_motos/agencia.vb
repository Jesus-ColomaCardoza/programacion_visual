Imports System.Data.SqlClient
Public Class agencia
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub agencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_agencia.agencia' Puede moverla o quitarla según sea necesario.
        Me.AgenciaTableAdapter.Fill(Me.Alquiler_motosDataSet_agencia.agencia)

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")

    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Me.AgenciaTableAdapter.Fill(Me.Alquiler_motosDataSet_agencia.agencia)
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostraragencia '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                'muestra la agencia de acuerdo al idagencia
                AgenciaTableAdapter.FillBy(Alquiler_motosDataSet_agencia.agencia, txt_id.Text)

                txt_nombre.Text = data(1)
                txt_direccion.Text = data(2)
                MessageBox.Show("Agencia encontrado", "Agencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Agencia No encontrado", "Agencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_nombre.Text = ""
                txt_direccion.Text = ""
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminaragencia '" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Agencia Eliminado", "Agencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_nombre.Text = ""
                txt_direccion.Text = ""
            Else
                MessageBox.Show("Agencia No Eliminado", "Agencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_actualizaragencia '" + txt_id.Text + "','" + txt_nombre.Text + "','" + txt_direccion.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Agencia Actualizado", "Agencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_nombre.Text = ""
                txt_direccion.Text = ""
            Else
                MessageBox.Show("Agencia No Actualizado", "Agencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_insertaragencia '" + txt_nombre.Text + "','" + txt_direccion.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Agencia Agregado", "Agencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                txt_nombre.Text = ""
                txt_direccion.Text = ""
            Else
                MessageBox.Show("Agencia No Agregado", "Agencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class