Imports System.Data.SqlClient
Public Class garaje
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub garaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GarajeTableAdapter.Fill(Me.Alquiler_motosDataSet_garaje.garaje)

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")

    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_garaje.garaje' Puede moverla o quitarla según sea necesario.
        Me.GarajeTableAdapter.Fill(Me.Alquiler_motosDataSet_garaje.garaje)

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrargaraje '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                'muestra el garaje de acuerdo al idgaraje
                GarajeTableAdapter.FillBy(Alquiler_motosDataSet_garaje.garaje, txt_id.Text)

                txt_direccion.Text = data(1)
                nud_capacidad.Value = data(2)
                MessageBox.Show("Garaje encontrado", "Garaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Garaje No encontrado", "Garaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_direccion.Text = ""
                nud_capacidad.Value = 0
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminargaraje '" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Garaje Eliminado", "Garaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_direccion.Text = ""
                nud_capacidad.Value = 0
            Else
                MessageBox.Show("Garaje No Eliminado", "Garaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_actualizargaraje '" + txt_id.Text + "','" + txt_direccion.Text + "'," + nud_capacidad.Value.ToString
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Garaje Actualizado", "Garaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_direccion.Text = ""
                nud_capacidad.Value = 0

            Else
                MessageBox.Show("Garaje No Actualizado", "Garaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click

        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_insertargaraje '" + txt_direccion.Text + "'," + nud_capacidad.Value.ToString
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Garaje Agregado", "Garaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                txt_direccion.Text = ""
                nud_capacidad.Value = 0
            Else
                MessageBox.Show("Garaje No Agregado", "Garaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception
            MessageBox.Show("Garaje No Agregado", "Garaje", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class