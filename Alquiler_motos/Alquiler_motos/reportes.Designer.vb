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
        Me.ReservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlquilermotosDataSetreservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet_reserva = New Alquiler_motos.Alquiler_motosDataSet_reserva()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cbx_reporte = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReservaTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_reservaTableAdapters.reservaTableAdapter()
        Me.Alquiler_motosDataSet = New Alquiler_motos.Alquiler_motosDataSet()
        Me.AlquilermotosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New Alquiler_motos.Alquiler_motosDataSetTableAdapters.clienteTableAdapter()
        Me.Alquiler_motosDataSet2 = New Alquiler_motos.Alquiler_motosDataSet2()
        Me.AlquilermotosDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MotoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MotoTableAdapter = New Alquiler_motos.Alquiler_motosDataSet2TableAdapters.motoTableAdapter()
        Me.SpmostrarempresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_mostrarempresaTableAdapter = New Alquiler_motos.Alquiler_motosDataSetTableAdapters.sp_mostrarempresaTableAdapter()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSetreservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet_reserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpmostrarempresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        ReportDataSource1.Name = "dscliente"
        ReportDataSource1.Value = Me.ClienteBindingSource
        ReportDataSource2.Name = "dsempresa"
        ReportDataSource2.Value = Me.SpmostrarempresaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Alquiler_motos.Report_cliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 62)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1070, 537)
        Me.ReportViewer1.TabIndex = 0
        '
        'cbx_reporte
        '
        Me.cbx_reporte.FormattingEnabled = True
        Me.cbx_reporte.Items.AddRange(New Object() {"Clientes", "Reservas", "Motos", "Trabajadores", "Comprobantes"})
        Me.cbx_reporte.Location = New System.Drawing.Point(125, 24)
        Me.cbx_reporte.Name = "cbx_reporte"
        Me.cbx_reporte.Size = New System.Drawing.Size(241, 21)
        Me.cbx_reporte.TabIndex = 1
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(413, 24)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(123, 21)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar Reporte"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Eligue reporte"
        '
        'ReservaTableAdapter
        '
        Me.ReservaTableAdapter.ClearBeforeFill = True
        '
        'Alquiler_motosDataSet
        '
        Me.Alquiler_motosDataSet.DataSetName = "Alquiler_motosDataSet"
        Me.Alquiler_motosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlquilermotosDataSetBindingSource
        '
        Me.AlquilermotosDataSetBindingSource.DataSource = Me.Alquiler_motosDataSet
        Me.AlquilermotosDataSetBindingSource.Position = 0
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.AlquilermotosDataSetBindingSource
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Alquiler_motosDataSet2
        '
        Me.Alquiler_motosDataSet2.DataSetName = "Alquiler_motosDataSet2"
        Me.Alquiler_motosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlquilermotosDataSet2BindingSource
        '
        Me.AlquilermotosDataSet2BindingSource.DataSource = Me.Alquiler_motosDataSet2
        Me.AlquilermotosDataSet2BindingSource.Position = 0
        '
        'MotoBindingSource
        '
        Me.MotoBindingSource.DataMember = "moto"
        Me.MotoBindingSource.DataSource = Me.AlquilermotosDataSet2BindingSource
        '
        'MotoTableAdapter
        '
        Me.MotoTableAdapter.ClearBeforeFill = True
        '
        'SpmostrarempresaBindingSource
        '
        Me.SpmostrarempresaBindingSource.DataMember = "sp_mostrarempresa"
        Me.SpmostrarempresaBindingSource.DataSource = Me.AlquilermotosDataSetBindingSource
        '
        'Sp_mostrarempresaTableAdapter
        '
        Me.Sp_mostrarempresaTableAdapter.ClearBeforeFill = True
        '
        'reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 611)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cbx_reporte)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSetreservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet_reserva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpmostrarempresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cbx_reporte As ComboBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Label1 As Label
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
End Class
