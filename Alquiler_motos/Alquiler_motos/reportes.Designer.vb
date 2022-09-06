<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportes))
        Me.ComprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlquilermotosDataSetcomprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet_comprobante = New Alquiler_motos.Alquiler_motosDataSet_comprobante()
        Me.SpmostrarempresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlquilermotosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet = New Alquiler_motos.Alquiler_motosDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlquilermotosDataSetreservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet_reserva = New Alquiler_motos.Alquiler_motosDataSet_reserva()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cbx_reporte = New System.Windows.Forms.ComboBox()
        Me.ClienteTableAdapter = New Alquiler_motos.Alquiler_motosDataSetTableAdapters.clienteTableAdapter()
        Me.MotoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlquilermotosDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet2 = New Alquiler_motos.Alquiler_motosDataSet2()
        Me.Sp_mostrarempresaTableAdapter = New Alquiler_motos.Alquiler_motosDataSetTableAdapters.sp_mostrarempresaTableAdapter()
        Me.ReservaTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_reservaTableAdapters.reservaTableAdapter()
        Me.MotoTableAdapter = New Alquiler_motos.Alquiler_motosDataSet2TableAdapters.motoTableAdapter()
        Me.Alquiler_motosDataSet1 = New Alquiler_motos.Alquiler_motosDataSet1()
        Me.AlquilermotosDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrabajadorTableAdapter = New Alquiler_motos.Alquiler_motosDataSet1TableAdapters.trabajadorTableAdapter()
        Me.ComprobanteTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_comprobanteTableAdapters.comprobanteTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSetcomprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet_comprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpmostrarempresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSetreservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet_reserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SpmostrarempresaBindingSource.DataSource = Me.AlquilermotosDataSetBindingSource
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
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.AlquilermotosDataSetBindingSource
        '
        'ReservaBindingSource
        '
        Me.ReservaBindingSource.DataMember = "reserva"
        Me.ReservaBindingSource.DataSource = Me.AlquilermotosDataSetreservaBindingSource
        '
        'AlquilermotosDataSetreservaBindingSource
        '
        Me.AlquilermotosDataSetreservaBindingSource.DataSource = Me.Alquiler_motosDataSet_reserva
        Me.AlquilermotosDataSetreservaBindingSource.Position = 0
        '
        'Alquiler_motosDataSet_reserva
        '
        Me.Alquiler_motosDataSet_reserva.DataSetName = "Alquiler_motosDataSet_reserva"
        Me.Alquiler_motosDataSet_reserva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dscomprobante"
        ReportDataSource1.Value = Me.ComprobanteBindingSource
        ReportDataSource2.Name = "dsempresa"
        ReportDataSource2.Value = Me.SpmostrarempresaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_comprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 62)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1070, 537)
        Me.ReportViewer1.TabIndex = 0
        '
        'cbx_reporte
        '
        Me.cbx_reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_reporte.FormattingEnabled = True
        Me.cbx_reporte.Items.AddRange(New Object() {"Clientes", "Reservas", "Motos", "Trabajadores", "Comprobantes"})
        Me.cbx_reporte.Location = New System.Drawing.Point(369, 24)
        Me.cbx_reporte.Name = "cbx_reporte"
        Me.cbx_reporte.Size = New System.Drawing.Size(241, 24)
        Me.cbx_reporte.TabIndex = 1
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'MotoBindingSource
        '
        Me.MotoBindingSource.DataMember = "moto"
        Me.MotoBindingSource.DataSource = Me.AlquilermotosDataSet2BindingSource
        '
        'AlquilermotosDataSet2BindingSource
        '
        Me.AlquilermotosDataSet2BindingSource.DataSource = Me.Alquiler_motosDataSet2
        Me.AlquilermotosDataSet2BindingSource.Position = 0
        '
        'Alquiler_motosDataSet2
        '
        Me.Alquiler_motosDataSet2.DataSetName = "Alquiler_motosDataSet2"
        Me.Alquiler_motosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_mostrarempresaTableAdapter
        '
        Me.Sp_mostrarempresaTableAdapter.ClearBeforeFill = True
        '
        'ReservaTableAdapter
        '
        Me.ReservaTableAdapter.ClearBeforeFill = True
        '
        'MotoTableAdapter
        '
        Me.MotoTableAdapter.ClearBeforeFill = True
        '
        'Alquiler_motosDataSet1
        '
        Me.Alquiler_motosDataSet1.DataSetName = "Alquiler_motosDataSet1"
        Me.Alquiler_motosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlquilermotosDataSet1BindingSource
        '
        Me.AlquilermotosDataSet1BindingSource.DataSource = Me.Alquiler_motosDataSet1
        Me.AlquilermotosDataSet1BindingSource.Position = 0
        '
        'TrabajadorBindingSource
        '
        Me.TrabajadorBindingSource.DataMember = "trabajador"
        Me.TrabajadorBindingSource.DataSource = Me.AlquilermotosDataSet1BindingSource
        '
        'TrabajadorTableAdapter
        '
        Me.TrabajadorTableAdapter.ClearBeforeFill = True
        '
        'ComprobanteTableAdapter
        '
        Me.ComprobanteTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Reporte "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(634, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 35)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Buscar Reporte"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 611)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbx_reporte)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSetcomprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet_comprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpmostrarempresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSetreservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet_reserva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cbx_reporte As ComboBox
    Friend WithEvents Alquiler_motosDataSet_reserva As Alquiler_motosDataSet_reserva
    Friend WithEvents AlquilermotosDataSetreservaBindingSource As BindingSource
    Friend WithEvents ReservaBindingSource As BindingSource
    Friend WithEvents ReservaTableAdapter As Alquiler_motosDataSet_reservaTableAdapters.reservaTableAdapter
    Friend WithEvents Alquiler_motosDataSet As Alquiler_motosDataSet
    Friend WithEvents AlquilermotosDataSetBindingSource As BindingSource
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As Alquiler_motosDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents Alquiler_motosDataSet2 As Alquiler_motosDataSet2
    Friend WithEvents AlquilermotosDataSet2BindingSource As BindingSource
    Friend WithEvents MotoBindingSource As BindingSource
    Friend WithEvents MotoTableAdapter As Alquiler_motosDataSet2TableAdapters.motoTableAdapter
    Friend WithEvents SpmostrarempresaBindingSource As BindingSource
    Friend WithEvents Sp_mostrarempresaTableAdapter As Alquiler_motosDataSetTableAdapters.sp_mostrarempresaTableAdapter
    Friend WithEvents Alquiler_motosDataSet1 As Alquiler_motosDataSet1
    Friend WithEvents AlquilermotosDataSet1BindingSource As BindingSource
    Friend WithEvents TrabajadorBindingSource As BindingSource
    Friend WithEvents TrabajadorTableAdapter As Alquiler_motosDataSet1TableAdapters.trabajadorTableAdapter
    Friend WithEvents Alquiler_motosDataSet_comprobante As Alquiler_motosDataSet_comprobante
    Friend WithEvents AlquilermotosDataSetcomprobanteBindingSource As BindingSource
    Friend WithEvents ComprobanteBindingSource As BindingSource
    Friend WithEvents ComprobanteTableAdapter As Alquiler_motosDataSet_comprobanteTableAdapters.comprobanteTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
