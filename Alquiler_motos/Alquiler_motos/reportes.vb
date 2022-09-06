Imports Microsoft.Reporting.WinForms

Public Class reportes
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
            'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet.cliente' Puede moverla o quitarla según sea necesario.
            Me.ClienteTableAdapter.Fill(Me.Alquiler_motosDataSet.cliente)

        ElseIf (nombre_reporte.ToLower.Equals("reservas")) Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_reserva.rdlc"
            nuevaFuenteDatos.Name = "dsreserva"
            nuevaFuenteDatos.Value = ReservaBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos)

            nuevaFuenteDatos1.Name = "dsempresa"
            nuevaFuenteDatos1.Value = SpmostrarempresaBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos1)

            'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_reserva.reserva' Puede moverla o quitarla según sea necesario.
            Me.ReservaTableAdapter.Fill(Me.Alquiler_motosDataSet_reserva.reserva)

        ElseIf (nombre_reporte.ToLower.Equals("motos")) Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_motos.rdlc"
            nuevaFuenteDatos.Name = "dsmoto"
            nuevaFuenteDatos.Value = MotoBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos)

            nuevaFuenteDatos1.Name = "dsempresa"
            nuevaFuenteDatos1.Value = SpmostrarempresaBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos1)

            'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet2.moto' Puede moverla o quitarla según sea necesario.
            Me.MotoTableAdapter.Fill(Me.Alquiler_motosDataSet2.moto)

        ElseIf (nombre_reporte.ToLower.Equals("trabajadores")) Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_trabajador.rdlc"
            nuevaFuenteDatos.Name = "dstrabajador"
            nuevaFuenteDatos.Value = TrabajadorBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos)

            nuevaFuenteDatos1.Name = "dsempresa"
            nuevaFuenteDatos1.Value = SpmostrarempresaBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos1)

            'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet1.trabajador' Puede moverla o quitarla según sea necesario.
            Me.TrabajadorTableAdapter.Fill(Me.Alquiler_motosDataSet1.trabajador)

        ElseIf (nombre_reporte.ToLower.Equals("comprobantes")) Then
            ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_comprobante.rdlc"
            nuevaFuenteDatos.Name = "dscomprobante"
            nuevaFuenteDatos.Value = ComprobanteBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos)

            nuevaFuenteDatos1.Name = "dsempresa"
            nuevaFuenteDatos1.Value = SpmostrarempresaBindingSource
            ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos1)

            'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet_comprobante.comprobante' Puede moverla o quitarla según sea necesario.
            Me.ComprobanteTableAdapter.Fill(Me.Alquiler_motosDataSet_comprobante.comprobante)
        End If


        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet.sp_mostrarempresa' Puede moverla o quitarla según sea necesario.
        Me.Sp_mostrarempresaTableAdapter.Fill(Me.Alquiler_motosDataSet.sp_mostrarempresa)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cambiarReporte(cbx_reporte.Text)
    End Sub
End Class