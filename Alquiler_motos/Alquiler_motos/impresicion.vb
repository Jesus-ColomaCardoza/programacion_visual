Imports Microsoft.Reporting.WinForms

Public Class impresicion
    Private Sub impresicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiarReporte("")
    End Sub



    Public Sub cambiarReporte(nombre_reporte As String)

        Dim nuevaFuenteDatos As ReportDataSource
        Dim nuevaFuenteDatos1 As ReportDataSource
        Dim nuevaFuenteDatos2 As ReportDataSource
        Dim nuevaFuenteDatos3 As ReportDataSource

        nuevaFuenteDatos = New ReportDataSource()
        nuevaFuenteDatos1 = New ReportDataSource()
        nuevaFuenteDatos2 = New ReportDataSource()
        nuevaFuenteDatos3 = New ReportDataSource()


        ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_impresicion.rdlc"



        nuevaFuenteDatos1.Name = "dsempresa"
        nuevaFuenteDatos1.Value = SpmostrarempresaBindingSource
        ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos1)

        nuevaFuenteDatos2.Name = "dscliente"
        nuevaFuenteDatos2.Value = ClienteBindingSource
        ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos2)

        nuevaFuenteDatos3.Name = "dstrabjador"
        nuevaFuenteDatos3.Value = ClienteBindingSource
        ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos3)

        nuevaFuenteDatos.Name = "dscomprobante"
        nuevaFuenteDatos.Value = ComprobanteBindingSource
        ReportViewer1.LocalReport.DataSources.Add(nuevaFuenteDatos)

        'TODO: esta línea de código carga datos en la tabla 'Alquiler_motosDataSet.cliente' Puede moverla o quitarla según sea necesario.


        Me.Sp_mostrarempresaTableAdapter.Fill(Me.Alquiler_motosDataSet_comprobante.sp_mostrarempresa)


        Me.ClienteTableAdapter.FillBy(Me.Alquiler_motosDataSet.cliente, Alquiler.cbx_idcliente.Text)

        Me.TrabajadorTableAdapter.FillBy(Me.Alquiler_motosDataSet1.trabajador, Alquiler.cbx_idtrabajador.Text)

        Me.ComprobanteTableAdapter.FillBy(Me.Alquiler_motosDataSet_comprobante.comprobante, Alquiler.txt_idcomprobante.Text)




        ReportViewer1.RefreshReport()
    End Sub


End Class