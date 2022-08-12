﻿Imports System.Data.SqlClient
Public Class cliente
    Public cn As SqlConnection
    Public comando As SqlCommand
    Public data As SqlDataReader
    Private Sub cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Alquiler_motosDataSet.cliente)
        cn = New SqlConnection("Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True")
        'Data Source = DESKTOP-AHI2VUU;Initial Catalog=Alquiler_motos;Integrated Security=True

    End Sub
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_mostrarcliente '" + txt_id.Text + "'"
            data = comando.ExecuteReader()

            ClienteTableAdapter.GetDataBy(txt_id.Text)
            ClienteTableAdapter.FillBy(Alquiler_motosDataSet.cliente, txt_id.Text)
            'ClienteTableAdapter.Fill(Alquiler_motosDataSet.cliente)

            If (data.Read) Then
                txt_tc.Text = data(1)
                txt_dni.Text = data(2)
                txt_nom.Text = data(3)
                txt_ape.Text = data(4)
                txt_direc.Text = data(5)
                txt_tele.Text = data(6)
                txt_correo.Text = data(7)
                MessageBox.Show("Cliente encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("Cliente No encontrado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_tc.Text = ""
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

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_insertarcliente " + "'" + txt_tc.Text + "','" + txt_dni.Text + "','" + txt_nom.Text + "','" + txt_ape.Text + "','" + txt_direc.Text + "','" + txt_tele.Text + "','" + txt_correo.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Cliente Agregado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_id.Text = ""
                txt_tc.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""
            Else
                MessageBox.Show("Cliente No Agregado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_eliminarcliente " + "'" + txt_id.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Cliente Eliminado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_tc.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""
            Else
                MessageBox.Show("Cliente No Eliminado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Try
            cn.Open()
            comando = cn.CreateCommand()
            comando.CommandText = "exec sp_actualizarcliente " + "'" + txt_id.Text + "','" + txt_tc.Text + "','" + txt_dni.Text + "','" + txt_nom.Text + "','" + txt_ape.Text + "','" + txt_direc.Text + "','" + txt_tele.Text + "','" + txt_correo.Text + "'"
            data = comando.ExecuteReader()
            If (data.RecordsAffected) Then
                MessageBox.Show("Cliente Actualizado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'txt_id.Text = ""
                txt_tc.Text = ""
                txt_dni.Text = ""
                txt_nom.Text = ""
                txt_ape.Text = ""
                txt_direc.Text = ""
                txt_tele.Text = ""
                txt_correo.Text = ""
            Else
                MessageBox.Show("Cliente No Actualizado", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            cn.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Me.ClienteTableAdapter.Fill(Me.Alquiler_motosDataSet.cliente)
    End Sub
End Class