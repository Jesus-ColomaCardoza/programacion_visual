Imports System.Data.SqlClient

Public Class Forma_pago
    'falta delete y update
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub Forma_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")

    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_formapago.forma_pago' Puede moverla o quitarla según sea necesario.
        Me.Forma_pagoTableAdapter.Fill(Me.Alquiler_motosDataSet_formapago.forma_pago)

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "select * from forma_pago where id_forma_pago='" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then

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

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "insert into forma_pago values('" + txt_id.Text + "','" + txt_descripcion.Text + "')"
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