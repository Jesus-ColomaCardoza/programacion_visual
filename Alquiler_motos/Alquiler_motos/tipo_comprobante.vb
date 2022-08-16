Imports System.Data.SqlClient
Public Class tipo_comprobante
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub tipo_comprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_tcomprobante.tipo_comprobante' Puede moverla o quitarla según sea necesario.
        Me.Tipo_comprobanteTableAdapter.Fill(Me.Alquiler_motosDataSet_tcomprobante.tipo_comprobante)

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")
        'Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_tcomprobante.tipo_comprobante' Puede moverla o quitarla según sea necesario.
        Me.Tipo_comprobanteTableAdapter.Fill(Me.Alquiler_motosDataSet_tcomprobante.tipo_comprobante)

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrartcomprobante '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                Tipo_comprobanteTableAdapter.FillBy(Alquiler_motosDataSet_tcomprobante.tipo_comprobante, txt_id.Text)
                'ClienteTableAdapter.Fill(Alquiler_motosDataSet.cliente)

                txt_descripcion.Text = data(1)
                MessageBox.Show("Tipo de Comprobante encontrado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Tipo de Comprobante No encontrado", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            comando.CommandText = "exec sp_eliminartcomprobante '" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Tipo de Comprobante Eliminado", "Tipo de Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_descripcion.Text = ""
            Else
                MessageBox.Show("Tipo de Comprobante No Eliminado", "Tipo de Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_actualizartcomprobante '" + txt_id.Text + "','" + txt_descripcion.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Tipo de Comprobante Actualizado", "Tipo de Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_descripcion.Text = ""
            Else
                MessageBox.Show("Tipo de Comprobante No Actualizado", "Tipo de Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_insertartcomprobante '" + txt_descripcion.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Tipo de Comprobante Agregado", "Tipo de Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                txt_descripcion.Text = ""
            Else
                MessageBox.Show("Tipo de Comprobante No Agregado", "Tipo de Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class