Imports System.Data.SqlClient

Public Class moto
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub moto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet3.garaje' Puede moverla o quitarla según sea necesario.
        Me.GarajeTableAdapter.Fill(Me.Alquiler_motosDataSet3.garaje)
        cbx_g.Text = ""

        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet2.moto' Puede moverla o quitarla según sea necesario.
        Me.MotoTableAdapter.Fill(Me.Alquiler_motosDataSet2.moto)

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")

    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrarmoto '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                'para actuzaliar la tabla de las motos
                'MotoTableAdapter.GetDataBy(txt_id.Text)
                MotoTableAdapter.FillBy(Alquiler_motosDataSet2.moto, txt_id.Text)

                'para que aparezca la direccion del garaje en vez del codigo del garaje
                cbx_g.Text = GarajeTableAdapter.FillBygetdireccion(data(1))
                txt_placa.Text = data(2)
                txt_marca.Text = data(3)
                txt_modelo.Text = data(4)
                txt_color.Text = data(5)
                txt_motor.Text = data(6)
                txt_cili.Text = data(7)
                txt_precio.Text = data(8)
                cbox_estado.Checked = data(9)
                MessageBox.Show("Moto encontrado", "Moto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Moto No encontrado", "Moto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbx_g.Text = ""
                txt_placa.Text = ""
                txt_marca.Text = ""
                txt_modelo.Text = ""
                txt_color.Text = ""
                txt_motor.Text = ""
                txt_cili.Text = ""
                txt_precio.Text = ""
                cbox_estado.Checked = False
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Me.MotoTableAdapter.Fill(Me.Alquiler_motosDataSet2.moto)
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminarmoto" + "'" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Moto Eliminado", "Moto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cbx_g.Text = ""
                txt_placa.Text = ""
                txt_marca.Text = ""
                txt_modelo.Text = ""
                txt_color.Text = ""
                txt_motor.Text = ""
                txt_cili.Text = ""
                txt_precio.Text = ""
                cbox_estado.Checked = False
            Else
                MessageBox.Show("Moto No Eliminado", "Moto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Dim idgaraje As String
        Try
            cn.Open()
            comando = cn.CreateCommand()

            'comvertir de direccion de garaje a codigo de garaje
            idgaraje = GarajeTableAdapter.FillBygetid(cbx_g.Text)

            comando.CommandText = "exec sp_insertarmoto " + "'" + idgaraje + "','" + txt_placa.Text + "','" + txt_marca.Text + "','" + txt_modelo.Text + "','" + txt_color.Text + "','" + txt_motor.Text + "'," + txt_cili.Text + "," + txt_precio.Text + "," + cbox_estado.Checked.ToString
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Moto Agregado", "Moto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                cbx_g.Text = ""
                txt_placa.Text = ""
                txt_marca.Text = ""
                txt_modelo.Text = ""
                txt_color.Text = ""
                txt_motor.Text = ""
                txt_cili.Text = ""
                txt_precio.Text = ""
                cbox_estado.Checked = False
            Else
                MessageBox.Show("Moto No Agregado", "Moto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim idgaraje As String
        Try
            cn.Open()
            comando = cn.CreateCommand()

            'comvertir de direccion de garaje a codigo de garaje
            idgaraje = GarajeTableAdapter.FillBygetid(cbx_g.Text)

            comando.CommandText = "exec sp_actualizarmoto '" + txt_id.Text + "','" + idgaraje + "','" + txt_placa.Text + "','" + txt_marca.Text + "','" + txt_modelo.Text + "','" + txt_color.Text + "','" + txt_motor.Text + "'," + txt_cili.Text + "," + txt_precio.Text + "," + cbox_estado.Checked.ToString
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Moto Actualizado", "Moto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                cbx_g.Text = ""
                txt_placa.Text = ""
                txt_marca.Text = ""
                txt_modelo.Text = ""
                txt_color.Text = ""
                txt_motor.Text = ""
                txt_cili.Text = ""
                txt_precio.Text = ""
                cbox_estado.Checked = False
            Else
                MessageBox.Show("Moto No Actualizado", "Moto", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbox_estado_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_estado.CheckedChanged
        If cbox_estado.Checked = True Then
            cbox_estado.Text = "Disponible"
        Else
            cbox_estado.Text = "No Disponible"
        End If
    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        detalle_reserva.txt_idmoto.Text = Me.txt_id.Text
        Me.Close()
    End Sub

    Private Sub txt_filtro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_filtro.KeyPress
        If (cbx_filtro.Text Like "Marca") Then
            MotoTableAdapter.FillBy_filtromarca(Alquiler_motosDataSet2.moto, txt_filtro.Text)
        ElseIf (cbx_filtro.Text Like "Modelo") Then
            MotoTableAdapter.FillBy_filtromodelo(Alquiler_motosDataSet2.moto, txt_filtro.Text)
        ElseIf (cbx_filtro.Text Like "Color") Then
            MotoTableAdapter.FillBy_filtrocolor(Alquiler_motosDataSet2.moto, txt_filtro.Text)
        End If
    End Sub

    Private Sub cbx_filtro_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbx_filtro.SelectedValueChanged
        If (cbx_filtro.Text Like "Precio") Then
            txt_filtro.Text = "Precio ordenado: bajo a alto"
            MotoTableAdapter.FillBy_filtroprecio_asc(Alquiler_motosDataSet2.moto)
        Else
            txt_filtro.Text = ""
        End If
    End Sub
End Class