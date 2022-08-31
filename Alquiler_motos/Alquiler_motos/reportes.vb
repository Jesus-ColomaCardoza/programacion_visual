Imports Microsoft.Reporting.WinForms

Public Class reportes

    Private Sub reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet.sp_mostrarempresa' Puede moverla o quitarla según sea necesario.
        Me.Sp_mostrarempresaTableAdapter.Fill(Me.Alquiler_motosDataSet.sp_mostrarempresa)

        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet.sp_mostrarempresa' Puede moverla o quitarla según sea necesario.
        Me.Sp_mostrarempresaTableAdapter.Fill(Me.Alquiler_motosDataSet.sp_mostrarempresa)
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.Alquiler_motosDataSet.cliente)
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_reserva.reserva' Puede moverla o quitarla según sea necesario.
        Me.ReservaTableAdapter.Fill(Me.Alquiler_motosDataSet_reserva.reserva)
        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet2.moto' Puede moverla o quitarla según sea necesario.
        Me.MotoTableAdapter.Fill(Me.Alquiler_motosDataSet2.moto)


        ReportViewer1.RefreshReport()


    End Sub

    Private Sub cambiarReporte(nombre_reporte As String)

        Dim nuevaFuenteDatos As ReportDataSource
        Dim nuevaFuenteDatos1 As ReportDataSource

        nuevaFuenteDatos = New ReportDataSource()
        nuevaFuenteDatos1 = New ReportDataSource()


        ReportViewer1.LocalReport.DataSources.Clear()

        If (nombre_reporte.ToLower.Equals("clientes")) Then

            ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_cliente.rdlc"
            nuevaFuenteDatos.Name = "dscliente"
            nuevaFuenteDatos.Value = ClienteBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos)

            nuevaFuenteDatos1.Name = "dsempresa"
            nuevaFuenteDatos1.Value = SpmostrarempresaBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos1)

        ElseIf (nombre_reporte.ToLower.Equals("reservas")) Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_reserva.rdlc"
            nuevaFuenteDatos.Name = "dsreserva"
            nuevaFuenteDatos.Value = ReservaBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos)


        ElseIf (nombre_reporte.ToLower.Equals("motos")) Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_motos.rdlc"
            nuevaFuenteDatos.Name = "dsmoto"
            nuevaFuenteDatos.Value = motoBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos)



        End If

        ReportViewer1.RefreshReport()




    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        cambiarReporte(cbx_reporte.Text)
    End Sub
End Class