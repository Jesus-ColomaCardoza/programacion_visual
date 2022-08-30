<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reserva))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.tablacliente = New System.Windows.Forms.DataGridView()
        Me.IdreservaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdagenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtrabajadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ReservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet_reserva = New Alquiler_motos.Alquiler_motosDataSet_reserva()
        Me.p_cliente = New System.Windows.Forms.Panel()
        Me.cbx_idcliente = New System.Windows.Forms.ComboBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_cliente = New Alquiler_motos.Modelo_cbx_cliente()
        Me.cbx_idtrabajador = New System.Windows.Forms.ComboBox()
        Me.TrabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_trabajador = New Alquiler_motos.modelo_cbx_trabajador()
        Me.cbx_agencia = New System.Windows.Forms.ComboBox()
        Me.AgenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_agencia = New Alquiler_motos.modelo_cbx_agencia()
        Me.cbox_estado = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_dreserva = New System.Windows.Forms.Button()
        Me.ReservaTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_reservaTableAdapters.reservaTableAdapter()
        Me.AgenciaTableAdapter = New Alquiler_motos.modelo_cbx_agenciaTableAdapters.agenciaTableAdapter()
        Me.TrabajadorTableAdapter = New Alquiler_motos.modelo_cbx_trabajadorTableAdapters.trabajadorTableAdapter()
        Me.ClienteTableAdapter = New Alquiler_motos.Modelo_cbx_clienteTableAdapters.clienteTableAdapter()
        Me.Modelo_cbx_tcomprobante = New Alquiler_motos.modelo_cbx_tcomprobante()
        Me.TipocomprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tipo_comprobanteTableAdapter = New Alquiler_motos.modelo_cbx_tcomprobanteTableAdapters.tipo_comprobanteTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet_reserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p_cliente.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_trabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_agencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_tcomprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipocomprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight
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
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(15, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 37)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Reservas"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btn_listar)
        Me.Panel1.Controls.Add(Me.tablacliente)
        Me.Panel1.Location = New System.Drawing.Point(209, 314)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 274)
        Me.Panel1.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(194, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Lista de reservas"
        '
        'btn_listar
        '
        Me.btn_listar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listar.ForeColor = System.Drawing.Color.White
        Me.btn_listar.Image = CType(resources.GetObject("btn_listar.Image"), System.Drawing.Image)
        Me.btn_listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_listar.Location = New System.Drawing.Point(443, 4)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(220, 41)
        Me.btn_listar.TabIndex = 24
        Me.btn_listar.Text = "Listar Reservas"
        Me.btn_listar.UseVisualStyleBackColor = False
        '
        'tablacliente
        '
        Me.tablacliente.AutoGenerateColumns = False
        Me.tablacliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablacliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tablacliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablacliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdreservaDataGridViewTextBoxColumn, Me.IdagenciaDataGridViewTextBoxColumn, Me.IdtrabajadorDataGridViewTextBoxColumn, Me.IdclienteDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.EstadoDataGridViewCheckBoxColumn})
        Me.tablacliente.DataSource = Me.ReservaBindingSource
        Me.tablacliente.Location = New System.Drawing.Point(8, 52)
        Me.tablacliente.Name = "tablacliente"
        Me.tablacliente.Size = New System.Drawing.Size(655, 201)
        Me.tablacliente.TabIndex = 20
        '
        'IdreservaDataGridViewTextBoxColumn
        '
        Me.IdreservaDataGridViewTextBoxColumn.DataPropertyName = "id_reserva"
        Me.IdreservaDataGridViewTextBoxColumn.HeaderText = "id_reserva"
        Me.IdreservaDataGridViewTextBoxColumn.Name = "IdreservaDataGridViewTextBoxColumn"
        '
        'IdagenciaDataGridViewTextBoxColumn
        '
        Me.IdagenciaDataGridViewTextBoxColumn.DataPropertyName = "id_agencia"
        Me.IdagenciaDataGridViewTextBoxColumn.HeaderText = "id_agencia"
        Me.IdagenciaDataGridViewTextBoxColumn.Name = "IdagenciaDataGridViewTextBoxColumn"
        '
        'IdtrabajadorDataGridViewTextBoxColumn
        '
        Me.IdtrabajadorDataGridViewTextBoxColumn.DataPropertyName = "id_trabajador"
        Me.IdtrabajadorDataGridViewTextBoxColumn.HeaderText = "id_trabajador"
        Me.IdtrabajadorDataGridViewTextBoxColumn.Name = "IdtrabajadorDataGridViewTextBoxColumn"
        '
        'IdclienteDataGridViewTextBoxColumn
        '
        Me.IdclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente"
        Me.IdclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente"
        Me.IdclienteDataGridViewTextBoxColumn.Name = "IdclienteDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewCheckBoxColumn
        '
        Me.EstadoDataGridViewCheckBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewCheckBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewCheckBoxColumn.Name = "EstadoDataGridViewCheckBoxColumn"
        '
        'ReservaBindingSource
        '
        Me.ReservaBindingSource.DataMember = "reserva"
        Me.ReservaBindingSource.DataSource = Me.Alquiler_motosDataSet_reserva
        '
        'Alquiler_motosDataSet_reserva
        '
        Me.Alquiler_motosDataSet_reserva.DataSetName = "Alquiler_motosDataSet_reserva"
        Me.Alquiler_motosDataSet_reserva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'p_cliente
        '
        Me.p_cliente.BackColor = System.Drawing.Color.Transparent
        Me.p_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p_cliente.Controls.Add(Me.cbx_idcliente)
        Me.p_cliente.Controls.Add(Me.cbx_idtrabajador)
        Me.p_cliente.Controls.Add(Me.cbx_agencia)
        Me.p_cliente.Controls.Add(Me.cbox_estado)
        Me.p_cliente.Controls.Add(Me.Label9)
        Me.p_cliente.Controls.Add(Me.Label2)
        Me.p_cliente.Controls.Add(Me.Label3)
        Me.p_cliente.Controls.Add(Me.Label6)
        Me.p_cliente.Controls.Add(Me.Label5)
        Me.p_cliente.Location = New System.Drawing.Point(209, 66)
        Me.p_cliente.Name = "p_cliente"
        Me.p_cliente.Size = New System.Drawing.Size(448, 222)
        Me.p_cliente.TabIndex = 33
        '
        'cbx_idcliente
        '
        Me.cbx_idcliente.DataSource = Me.ClienteBindingSource
        Me.cbx_idcliente.DisplayMember = "id_cliente"
        Me.cbx_idcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_idcliente.FormattingEnabled = True
        Me.cbx_idcliente.Location = New System.Drawing.Point(160, 129)
        Me.cbx_idcliente.Name = "cbx_idcliente"
        Me.cbx_idcliente.Size = New System.Drawing.Size(237, 24)
        Me.cbx_idcliente.TabIndex = 31
        Me.cbx_idcliente.ValueMember = "id_cliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.Modelo_cbx_cliente
        '
        'Modelo_cbx_cliente
        '
        Me.Modelo_cbx_cliente.DataSetName = "Modelo_cbx_cliente"
        Me.Modelo_cbx_cliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbx_idtrabajador
        '
        Me.cbx_idtrabajador.DataSource = Me.TrabajadorBindingSource
        Me.cbx_idtrabajador.DisplayMember = "id_trabajor"
        Me.cbx_idtrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_idtrabajador.FormattingEnabled = True
        Me.cbx_idtrabajador.Location = New System.Drawing.Point(160, 93)
        Me.cbx_idtrabajador.Name = "cbx_idtrabajador"
        Me.cbx_idtrabajador.Size = New System.Drawing.Size(237, 24)
        Me.cbx_idtrabajador.TabIndex = 30
        Me.cbx_idtrabajador.ValueMember = "id_trabajor"
        '
        'TrabajadorBindingSource
        '
        Me.TrabajadorBindingSource.DataMember = "trabajador"
        Me.TrabajadorBindingSource.DataSource = Me.Modelo_cbx_trabajador
        '
        'Modelo_cbx_trabajador
        '
        Me.Modelo_cbx_trabajador.DataSetName = "modelo_cbx_trabajador"
        Me.Modelo_cbx_trabajador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbx_agencia
        '
        Me.cbx_agencia.DataSource = Me.AgenciaBindingSource
        Me.cbx_agencia.DisplayMember = "nombre_agencia"
        Me.cbx_agencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_agencia.FormattingEnabled = True
        Me.cbx_agencia.Location = New System.Drawing.Point(160, 53)
        Me.cbx_agencia.Name = "cbx_agencia"
        Me.cbx_agencia.Size = New System.Drawing.Size(237, 24)
        Me.cbx_agencia.TabIndex = 29
        Me.cbx_agencia.ValueMember = "nombre_agencia"
        '
        'AgenciaBindingSource
        '
        Me.AgenciaBindingSource.DataMember = "agencia"
        Me.AgenciaBindingSource.DataSource = Me.Modelo_cbx_agencia
        '
        'Modelo_cbx_agencia
        '
        Me.Modelo_cbx_agencia.DataSetName = "modelo_cbx_agencia"
        Me.Modelo_cbx_agencia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbox_estado
        '
        Me.cbox_estado.AutoSize = True
        Me.cbox_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_estado.Location = New System.Drawing.Point(147, 175)
        Me.cbox_estado.Name = "cbox_estado"
        Me.cbox_estado.Size = New System.Drawing.Size(105, 20)
        Me.cbox_estado.TabIndex = 28
        Me.cbox_estado.Text = "No Pagada"
        Me.cbox_estado.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Datos de Reserva"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Id de cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Id de Trabajador"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Agencia"
        '
        'btn_insertar
        '
        Me.btn_insertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertar.ForeColor = System.Drawing.Color.White
        Me.btn_insertar.Image = CType(resources.GetObject("btn_insertar.Image"), System.Drawing.Image)
        Me.btn_insertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_insertar.Location = New System.Drawing.Point(711, 243)
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
        Me.btn_eliminar.Location = New System.Drawing.Point(711, 123)
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
        Me.btn_actualizar.Location = New System.Drawing.Point(711, 186)
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
        Me.Label1.Location = New System.Drawing.Point(283, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID de Reserva"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.White
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(711, 66)
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
        Me.txt_id.Location = New System.Drawing.Point(396, 22)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(228, 22)
        Me.txt_id.TabIndex = 27
        '
        'btn_dreserva
        '
        Me.btn_dreserva.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_dreserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dreserva.ForeColor = System.Drawing.Color.White
        Me.btn_dreserva.Image = CType(resources.GetObject("btn_dreserva.Image"), System.Drawing.Image)
        Me.btn_dreserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dreserva.Location = New System.Drawing.Point(641, 11)
        Me.btn_dreserva.Name = "btn_dreserva"
        Me.btn_dreserva.Size = New System.Drawing.Size(217, 45)
        Me.btn_dreserva.TabIndex = 36
        Me.btn_dreserva.Text = "Detalle de Reserva"
        Me.btn_dreserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_dreserva.UseVisualStyleBackColor = False
        '
        'ReservaTableAdapter
        '
        Me.ReservaTableAdapter.ClearBeforeFill = True
        '
        'AgenciaTableAdapter
        '
        Me.AgenciaTableAdapter.ClearBeforeFill = True
        '
        'TrabajadorTableAdapter
        '
        Me.TrabajadorTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Modelo_cbx_tcomprobante
        '
        Me.Modelo_cbx_tcomprobante.DataSetName = "modelo_cbx_tcomprobante"
        Me.Modelo_cbx_tcomprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipocomprobanteBindingSource
        '
        Me.TipocomprobanteBindingSource.DataMember = "tipo_comprobante"
        Me.TipocomprobanteBindingSource.DataSource = Me.Modelo_cbx_tcomprobante
        '
        'Tipo_comprobanteTableAdapter
        '
        Me.Tipo_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 611)
        Me.Controls.Add(Me.btn_dreserva)
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
        Me.Name = "reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet_reserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p_cliente.ResumeLayout(False)
        Me.p_cliente.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_trabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_agencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_tcomprobante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipocomprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents cbox_estado As CheckBox
    Friend WithEvents cbx_idcliente As ComboBox
    Friend WithEvents cbx_idtrabajador As ComboBox
    Friend WithEvents cbx_agencia As ComboBox
    Friend WithEvents Alquiler_motosDataSet_reserva As Alquiler_motosDataSet_reserva
    Friend WithEvents ReservaBindingSource As BindingSource
    Friend WithEvents ReservaTableAdapter As Alquiler_motosDataSet_reservaTableAdapters.reservaTableAdapter
    Friend WithEvents IdreservaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdagenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtrabajadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdclienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents btn_dreserva As Button
    Friend WithEvents Modelo_cbx_agencia As modelo_cbx_agencia
    Friend WithEvents AgenciaBindingSource As BindingSource
    Friend WithEvents AgenciaTableAdapter As modelo_cbx_agenciaTableAdapters.agenciaTableAdapter
    Friend WithEvents Modelo_cbx_trabajador As modelo_cbx_trabajador
    Friend WithEvents TrabajadorBindingSource As BindingSource
    Friend WithEvents TrabajadorTableAdapter As modelo_cbx_trabajadorTableAdapters.trabajadorTableAdapter
    Friend WithEvents Modelo_cbx_cliente As Modelo_cbx_cliente
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As Modelo_cbx_clienteTableAdapters.clienteTableAdapter
    Friend WithEvents Modelo_cbx_tcomprobante As modelo_cbx_tcomprobante
    Friend WithEvents TipocomprobanteBindingSource As BindingSource
    Friend WithEvents Tipo_comprobanteTableAdapter As modelo_cbx_tcomprobanteTableAdapters.tipo_comprobanteTableAdapter
End Class
