Imports System.Data.SqlClient

Public Class detalle_reserva

    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub detalle_reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Modelo_cbx_reserva.reserva' Puede moverla o quitarla según sea necesario.
        Me.ReservaTableAdapter.Fill(Me.Modelo_cbx_reserva.reserva)
        cbx_idreserva.Text = ""

        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")

    End Sub

    Private Sub btn_seleccionar_Click(sender As Object, e As EventArgs) Handles btn_seleccionar.Click
        moto.btn_seleccionar.Visible = True
        moto.btn_seleccionar.Enabled = True
        moto.txt_id.Text = Me.txt_idmoto.Text
        moto.Show()
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click


        If (cbx_listar.Text Like "Listar todos los detalles") Then
            'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_dreserva.detalle_reserva' Puede moverla o quitarla según sea necesario.
            Me.Detalle_reservaTableAdapter.Fill(Me.Alquiler_motosDataSet_dreserva.detalle_reserva)
        ElseIf (cbx_listar.Text Like "Listar por reserva") Then
            Me.Detalle_reservaTableAdapter.FillByidreserva(Me.Alquiler_motosDataSet_dreserva.detalle_reserva, cbx_idreserva.Text)
        End If


    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim finicio, ffin, hinicio, hfin, minicio, mfin As String
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrardreserva '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            If (data.Read) Then
                'para actuzaliar la tabla de las Reserva
                Detalle_reservaTableAdapter.FillBy(Alquiler_motosDataSet_dreserva.detalle_reserva, txt_id.Text)

                '11/09/2022 01:15:00
                ' funcion :mid(cadena,startposition,number characters)
                'startposition begin from 1

                finicio = Mid(data(3), 1, 10)
                hinicio = Mid(data(3), 12, 2)
                minicio = Mid(data(3), 15, 2)

                ffin = Mid(data(4), 1, 10)
                hfin = Mid(data(4), 12, 2)
                mfin = Mid(data(4), 15, 2)

                cbx_idreserva.Text = data(1)
                txt_idmoto.Text = data(2)

                datetime_finicio.Value = finicio
                nud_hinicio.Value = Val(hinicio)
                nud_mininicio.Value = Val(minicio)

                datetime_ffin.Value = ffin
                nud_hfin.Value = Val(hfin)
                nud_minfin.Value = Val(mfin)

                MessageBox.Show("Detalle encontrado", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Detalle No encontrado", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cbx_idreserva.Text = ""
                txt_idmoto.Text = ""

                datetime_finicio.Value = DateTime.Now
                nud_hinicio.Value = 0
                nud_mininicio.Value = 0

                datetime_ffin.Value = DateTime.Now
                nud_hfin.Value = 0
                nud_minfin.Value = 0

            End If
            cn.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminardreserva" + "'" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Detalle Eliminado", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                cbx_idreserva.Text = ""
                txt_idmoto.Text = ""

                datetime_finicio.Value = DateTime.Now
                nud_hinicio.Value = 0
                nud_mininicio.Value = 0

                datetime_ffin.Value = DateTime.Now
                nud_hfin.Value = 0
                nud_minfin.Value = 0
            Else
                MessageBox.Show("Detalle No Eliminado", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim finicio, ffin, hinicio, hfin, minicio, mfin As String


        Try
            cn.Open()
            comando = cn.CreateCommand()

            finicio = datetime_finicio.Value.Date
            hinicio = nud_hinicio.Value.ToString
            minicio = nud_mininicio.Value.ToString

            ffin = datetime_finicio.Value.Date
            hfin = nud_hfin.Value.ToString
            mfin = nud_minfin.Value.ToString

            comando.CommandText = "set dateformat dmy exec sp_actualizardreserva '" + txt_id.Text + "','" + cbx_idreserva.Text + "','" + txt_idmoto.Text + "','" + finicio + " " + hinicio + ":" + minicio + "','" + ffin + " " + hfin + ":" + mfin + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Detalle actualizada", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Detalle_reservaTableAdapter.FillBy(Alquiler_motosDataSet_dreserva.detalle_reserva, txt_id.Text)
                'txt_id.Text = ""
                cbx_idreserva.Text = ""
                txt_idmoto.Text = ""

                datetime_finicio.Value = DateTime.Now
                nud_hinicio.Value = 0
                nud_mininicio.Value = 0

                datetime_ffin.Value = DateTime.Now
                nud_hfin.Value = 0
                nud_minfin.Value = 0
            Else
                MessageBox.Show("Detalle No Actualizada", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Dim finicio, ffin, hinicio, hfin, minicio, mfin As String

        Try
            cn.Open()
            comando = cn.CreateCommand()

            finicio = datetime_finicio.Value.Date
            hinicio = nud_hinicio.Value.ToString
            minicio = nud_mininicio.Value.ToString

            ffin = datetime_finicio.Value.Date
            hfin = nud_hfin.Value.ToString
            mfin = nud_minfin.Value.ToString

            comando.CommandText = "set dateformat dmy exec sp_insertardreserva '" + cbx_idreserva.Text + "','" + txt_idmoto.Text + "','" + finicio + " " + hinicio + ":" + minicio + "','" + ffin + " " + hfin + ":" + mfin + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Detalle Agregado", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                cbx_idreserva.Text = ""
                txt_idmoto.Text = ""

                datetime_finicio.Value = DateTime.Now
                nud_hinicio.Value = 0
                nud_mininicio.Value = 0

                datetime_ffin.Value = DateTime.Now
                nud_hfin.Value = 0
                nud_minfin.Value = 0
            Else
                MessageBox.Show("Detalle No Agregado", "Detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class