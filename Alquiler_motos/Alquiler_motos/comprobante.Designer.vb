<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comprobante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comprobante))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.tablacliente = New System.Windows.Forms.DataGridView()
        Me.IdcomprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipocomprobanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormapagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdreservaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet_comprobante = New Alquiler_motos.Alquiler_motosDataSet_comprobante()
        Me.p_cliente = New System.Windows.Forms.Panel()
        Me.cbx_tcomprobante = New System.Windows.Forms.ComboBox()
        Me.TipocomprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_tcomprobante = New Alquiler_motos.modelo_cbx_tcomprobante()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_idreserva = New System.Windows.Forms.TextBox()
        Me.txt_igv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_formapago = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.ComprobanteTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_comprobanteTableAdapters.comprobanteTableAdapter()
        Me.Tipo_comprobanteTableAdapter = New Alquiler_motos.modelo_cbx_tcomprobanteTableAdapters.tipo_comprobanteTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet_comprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p_cliente.SuspendLayout()
        CType(Me.TipocomprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_tcomprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(12, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 566)
        Me.Panel2.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(19, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 148)
        Me.Label12.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(6, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 29)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Comprobante"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btn_listar)
        Me.Panel1.Controls.Add(Me.tablacliente)
        Me.Panel1.Location = New System.Drawing.Point(209, 314)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 274)
        Me.Panel1.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(251, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Lista de comprobantes"
        '
        'btn_listar
        '
        Me.btn_listar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listar.ForeColor = System.Drawing.Color.White
        Me.btn_listar.Image = CType(resources.GetObject("btn_listar.Image"), System.Drawing.Image)
        Me.btn_listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_listar.Location = New System.Drawing.Point(639, 3)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(220, 41)
        Me.btn_listar.TabIndex = 24
        Me.btn_listar.Text = "Listar Ccomprobantes"
        Me.btn_listar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_listar.UseVisualStyleBackColor = False
        '
        'tablacliente
        '
        Me.tablacliente.AutoGenerateColumns = False
        Me.tablacliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablacliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tablacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablacliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcomprobanteDataGridViewTextBoxColumn, Me.TipocomprobanteDataGridViewTextBoxColumn, Me.FormapagoDataGridViewTextBoxColumn, Me.IdreservaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.IGVDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.tablacliente.DataSource = Me.ComprobanteBindingSource
        Me.tablacliente.Location = New System.Drawing.Point(8, 52)
        Me.tablacliente.Name = "tablacliente"
        Me.tablacliente.Size = New System.Drawing.Size(851, 201)
        Me.tablacliente.TabIndex = 20
        '
        'IdcomprobanteDataGridViewTextBoxColumn
        '
        Me.IdcomprobanteDataGridViewTextBoxColumn.DataPropertyName = "id_comprobante"
        Me.IdcomprobanteDataGridViewTextBoxColumn.HeaderText = "id_comprobante"
        Me.IdcomprobanteDataGridViewTextBoxColumn.Name = "IdcomprobanteDataGridViewTextBoxColumn"
        '
        'TipocomprobanteDataGridViewTextBoxColumn
        '
        Me.TipocomprobanteDataGridViewTextBoxColumn.DataPropertyName = "tipo_comprobante"
        Me.TipocomprobanteDataGridViewTextBoxColumn.HeaderText = "tipo_comprobante"
        Me.TipocomprobanteDataGridViewTextBoxColumn.Name = "TipocomprobanteDataGridViewTextBoxColumn"
        '
        'FormapagoDataGridViewTextBoxColumn
        '
        Me.FormapagoDataGridViewTextBoxColumn.DataPropertyName = "forma_pago"
        Me.FormapagoDataGridViewTextBoxColumn.HeaderText = "forma_pago"
        Me.FormapagoDataGridViewTextBoxColumn.Name = "FormapagoDataGridViewTextBoxColumn"
        '
        'IdreservaDataGridViewTextBoxColumn
        '
        Me.IdreservaDataGridViewTextBoxColumn.DataPropertyName = "id_reserva"
        Me.IdreservaDataGridViewTextBoxColumn.HeaderText = "id_reserva"
        Me.IdreservaDataGridViewTextBoxColumn.Name = "IdreservaDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        '
        'IGVDataGridViewTextBoxColumn
        '
        Me.IGVDataGridViewTextBoxColumn.DataPropertyName = "IGV"
        Me.IGVDataGridViewTextBoxColumn.HeaderText = "IGV"
        Me.IGVDataGridViewTextBoxColumn.Name = "IGVDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'ComprobanteBindingSource
        '
        Me.ComprobanteBindingSource.DataMember = "comprobante"
        Me.ComprobanteBindingSource.DataSource = Me.Alquiler_motosDataSet_comprobante
        '
        'Alquiler_motosDataSet_comprobante
        '
        Me.Alquiler_motosDataSet_comprobante.DataSetName = "Alquiler_motosDataSet_comprobante"
        Me.Alquiler_motosDataSet_comprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'p_cliente
        '
        Me.p_cliente.BackColor = System.Drawing.Color.Transparent
        Me.p_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p_cliente.Controls.Add(Me.cbx_tcomprobante)
        Me.p_cliente.Controls.Add(Me.Label9)
        Me.p_cliente.Controls.Add(Me.txt_idreserva)
        Me.p_cliente.Controls.Add(Me.txt_igv)
        Me.p_cliente.Controls.Add(Me.Label2)
        Me.p_cliente.Controls.Add(Me.Label4)
        Me.p_cliente.Controls.Add(Me.Label8)
        Me.p_cliente.Controls.Add(Me.txt_formapago)
        Me.p_cliente.Controls.Add(Me.Label7)
        Me.p_cliente.Controls.Add(Me.txt_subtotal)
        Me.p_cliente.Controls.Add(Me.Label6)
        Me.p_cliente.Controls.Add(Me.txt_total)
        Me.p_cliente.Controls.Add(Me.Label5)
        Me.p_cliente.Location = New System.Drawing.Point(209, 66)
        Me.p_cliente.Name = "p_cliente"
        Me.p_cliente.Size = New System.Drawing.Size(717, 222)
        Me.p_cliente.TabIndex = 33
        '
        'cbx_tcomprobante
        '
        Me.cbx_tcomprobante.DataSource = Me.TipocomprobanteBindingSource
        Me.cbx_tcomprobante.DisplayMember = "descripcion"
        Me.cbx_tcomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_tcomprobante.FormattingEnabled = True
        Me.cbx_tcomprobante.Location = New System.Drawing.Point(174, 56)
        Me.cbx_tcomprobante.Name = "cbx_tcomprobante"
        Me.cbx_tcomprobante.Size = New System.Drawing.Size(180, 24)
        Me.cbx_tcomprobante.TabIndex = 30
        Me.cbx_tcomprobante.ValueMember = "descripcion"
        '
        'TipocomprobanteBindingSource
        '
        Me.TipocomprobanteBindingSource.DataMember = "tipo_comprobante"
        Me.TipocomprobanteBindingSource.DataSource = Me.Modelo_cbx_tcomprobante
        '
        'Modelo_cbx_tcomprobante
        '
        Me.Modelo_cbx_tcomprobante.DataSetName = "modelo_cbx_tcomprobante"
        Me.Modelo_cbx_tcomprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(253, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Datos de Comprobante"
        '
        'txt_idreserva
        '
        Me.txt_idreserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idreserva.Location = New System.Drawing.Point(174, 143)
        Me.txt_idreserva.Name = "txt_idreserva"
        Me.txt_idreserva.Size = New System.Drawing.Size(180, 22)
        Me.txt_idreserva.TabIndex = 1
        '
        'txt_igv
        '
        Me.txt_igv.Enabled = False
        Me.txt_igv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_igv.Location = New System.Drawing.Point(524, 93)
        Me.txt_igv.Name = "txt_igv"
        Me.txt_igv.Size = New System.Drawing.Size(166, 22)
        Me.txt_igv.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Id de reserva"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(451, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "IGV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(451, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total"
        '
        'txt_formapago
        '
        Me.txt_formapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_formapago.Location = New System.Drawing.Point(174, 97)
        Me.txt_formapago.Name = "txt_formapago"
        Me.txt_formapago.Size = New System.Drawing.Size(180, 22)
        Me.txt_formapago.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(451, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Subtotal"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(524, 53)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(166, 22)
        Me.txt_subtotal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Forma de Pago"
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(524, 130)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(166, 22)
        Me.txt_total.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tipo de comprobante"
        '
        'btn_insertar
        '
        Me.btn_insertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertar.ForeColor = System.Drawing.Color.White
        Me.btn_insertar.Image = CType(resources.GetObject("btn_insertar.Image"), System.Drawing.Image)
        Me.btn_insertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_insertar.Location = New System.Drawing.Point(940, 241)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(120, 45)
        Me.btn_insertar.TabIndex = 32
        Me.btn_insertar.Text = "Agregar"
        Me.btn_insertar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_insertar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(940, 121)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(120, 45)
        Me.btn_eliminar.TabIndex = 31
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.White
        Me.btn_actualizar.Image = CType(resources.GetObject("btn_actualizar.Image"), System.Drawing.Image)
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(940, 184)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(120, 45)
        Me.btn_actualizar.TabIndex = 30
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(419, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID de comprobante"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.White
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(940, 64)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(120, 45)
        Me.btn_buscar.TabIndex = 28
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(561, 22)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(228, 22)
        Me.txt_id.TabIndex = 27
        '
        'ComprobanteTableAdapter
        '
        Me.ComprobanteTableAdapter.ClearBeforeFill = True
        '
        'Tipo_comprobanteTableAdapter
        '
        Me.Tipo_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'comprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 611)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.p_cliente)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_id)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "comprobante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet_comprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p_cliente.ResumeLayout(False)
        Me.p_cliente.PerformLayout()
        CType(Me.TipocomprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_tcomprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_listar As Button
    Friend WithEvents tablacliente As DataGridView
    Friend WithEvents p_cliente As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_idreserva As TextBox
    Friend WithEvents txt_igv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_formapago As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Alquiler_motosDataSet_comprobante As Alquiler_motosDataSet_comprobante
    Friend WithEvents ComprobanteBindingSource As BindingSource
    Friend WithEvents ComprobanteTableAdapter As Alquiler_motosDataSet_comprobanteTableAdapters.comprobanteTableAdapter
    Friend WithEvents IdcomprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipocomprobanteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormapagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdreservaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IGVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbx_tcomprobante As ComboBox
    Friend WithEvents Modelo_cbx_tcomprobante As modelo_cbx_tcomprobante
    Friend WithEvents TipocomprobanteBindingSource As BindingSource
    Friend WithEvents Tipo_comprobanteTableAdapter As modelo_cbx_tcomprobanteTableAdapters.tipo_comprobanteTableAdapter
End Class
