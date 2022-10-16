<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class impresicion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ComprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlquilermotosDataSetcomprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet_comprobante = New Alquiler_motos.Alquiler_motosDataSet_comprobante()
        Me.SpmostrarempresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlquilermotosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet = New Alquiler_motos.Alquiler_motosDataSet()
        Me.TrabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlquilermotosDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet1 = New Alquiler_motos.Alquiler_motosDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ComprobanteTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_comprobanteTableAdapters.comprobanteTableAdapter()
        Me.Sp_mostrarempresaTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_comprobanteTableAdapters.sp_mostrarempresaTableAdapter()
        Me.ClienteTableAdapter = New Alquiler_motos.Alquiler_motosDataSetTableAdapters.clienteTableAdapter()
        Me.TrabajadorTableAdapter = New Alquiler_motos.Alquiler_motosDataSet1TableAdapters.trabajadorTableAdapter()
        Me.SpmostrardetallescomprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_mostrardetallescomprobanteTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_comprobanteTableAdapters.sp_mostrardetallescomprobanteTableAdapter()
        CType(Me.ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSetcomprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet_comprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpmostrarempresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpmostrardetallescomprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComprobanteBindingSource
        '
        Me.ComprobanteBindingSource.DataMember = "comprobante"
        Me.ComprobanteBindingSource.DataSource = Me.AlquilermotosDataSetcomprobanteBindingSource
        '
        'AlquilermotosDataSetcomprobanteBindingSource
        '
        Me.AlquilermotosDataSetcomprobanteBindingSource.DataSource = Me.Alquiler_motosDataSet_comprobante
        Me.AlquilermotosDataSetcomprobanteBindingSource.Position = 0
        '
        'Alquiler_motosDataSet_comprobante
        '
        Me.Alquiler_motosDataSet_comprobante.DataSetName = "Alquiler_motosDataSet_comprobante"
        Me.Alquiler_motosDataSet_comprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpmostrarempresaBindingSource
        '
        Me.SpmostrarempresaBindingSource.DataMember = "sp_mostrarempresa"
        Me.SpmostrarempresaBindingSource.DataSource = Me.AlquilermotosDataSetcomprobanteBindingSource
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.AlquilermotosDataSetBindingSource
        '
        'AlquilermotosDataSetBindingSource
        '
        Me.AlquilermotosDataSetBindingSource.DataSource = Me.Alquiler_motosDataSet
        Me.AlquilermotosDataSetBindingSource.Position = 0
        '
        'Alquiler_motosDataSet
        '
        Me.Alquiler_motosDataSet.DataSetName = "Alquiler_motosDataSet"
        Me.Alquiler_motosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrabajadorBindingSource
        '
        Me.TrabajadorBindingSource.DataMember = "trabajador"
        Me.TrabajadorBindingSource.DataSource = Me.AlquilermotosDataSet1BindingSource
        '
        'AlquilermotosDataSet1BindingSource
        '
        Me.AlquilermotosDataSet1BindingSource.DataSource = Me.Alquiler_motosDataSet1
        Me.AlquilermotosDataSet1BindingSource.Position = 0
        '
        'Alquiler_motosDataSet1
        '
        Me.Alquiler_motosDataSet1.DataSetName = "Alquiler_motosDataSet1"
        Me.Alquiler_motosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dscomprobante"
        ReportDataSource1.Value = Me.ComprobanteBindingSource
        ReportDataSource2.Name = "dsempresa"
        ReportDataSource2.Value = Me.SpmostrarempresaBindingSource
        ReportDataSource3.Name = "dscliente"
        ReportDataSource3.Value = Me.ClienteBindingSource
        ReportDataSource4.Name = "dstrabajador"
        ReportDataSource4.Value = Me.TrabajadorBindingSource
        ReportDataSource5.Name = "dsdetallescomprobante"
        ReportDataSource5.Value = Me.SpmostrardetallescomprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_impresicion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 43)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(515, 606)
        Me.ReportViewer1.TabIndex = 0
        '
        'ComprobanteTableAdapter
        '
        Me.ComprobanteTableAdapter.ClearBeforeFill = True
        '
        'Sp_mostrarempresaTableAdapter
        '
        Me.Sp_mostrarempresaTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TrabajadorTableAdapter
        '
        Me.TrabajadorTableAdapter.ClearBeforeFill = True
        '
        'SpmostrardetallescomprobanteBindingSource
        '
        Me.SpmostrardetallescomprobanteBindingSource.DataMember = "sp_mostrardetallescomprobante"
        Me.SpmostrardetallescomprobanteBindingSource.DataSource = Me.AlquilermotosDataSetcomprobanteBindingSource
        '
        'Sp_mostrardetallescomprobanteTableAdapter
        '
        Me.Sp_mostrardetallescomprobanteTableAdapter.ClearBeforeFill = True
        '
        'impresicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 661)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "impresicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "impresicion"
        CType(Me.ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSetcomprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet_comprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpmostrarempresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpmostrardetallescomprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Alquiler_motosDataSet_comprobante As Alquiler_motosDataSet_comprobante
    Friend WithEvents AlquilermotosDataSetcomprobanteBindingSource As BindingSource
    Friend WithEvents ComprobanteBindingSource As BindingSource
    Friend WithEvents ComprobanteTableAdapter As Alquiler_motosDataSet_comprobanteTableAdapters.comprobanteTableAdapter
    Friend WithEvents SpmostrarempresaBindingSource As BindingSource
    Friend WithEvents Sp_mostrarempresaTableAdapter As Alquiler_motosDataSet_comprobanteTableAdapters.sp_mostrarempresaTableAdapter
    Friend WithEvents Alquiler_motosDataSet As Alquiler_motosDataSet
    Friend WithEvents AlquilermotosDataSetBindingSource As BindingSource
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As Alquiler_motosDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents Alquiler_motosDataSet1 As Alquiler_motosDataSet1
    Friend WithEvents AlquilermotosDataSet1BindingSource As BindingSource
    Friend WithEvents TrabajadorBindingSource As BindingSource
    Friend WithEvents TrabajadorTableAdapter As Alquiler_motosDataSet1TableAdapters.trabajadorTableAdapter
    Friend WithEvents SpmostrardetallescomprobanteBindingSource As BindingSource
    Friend WithEvents Sp_mostrardetallescomprobanteTableAdapter As Alquiler_motosDataSet_comprobanteTableAdapters.sp_mostrardetallescomprobanteTableAdapter
End Class
