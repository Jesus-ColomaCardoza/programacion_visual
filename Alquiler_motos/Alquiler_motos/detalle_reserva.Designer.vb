<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class detalle_reserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detalle_reserva))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbx_listar = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.tablacliente = New System.Windows.Forms.DataGridView()
        Me.IddetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdreservaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetallereservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet_dreserva = New Alquiler_motos.Alquiler_motosDataSet_dreserva()
        Me.p_cliente = New System.Windows.Forms.Panel()
        Me.cbx_idreserva = New System.Windows.Forms.ComboBox()
        Me.ReservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_reserva = New Alquiler_motos.modelo_cbx_reserva()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nud_minfin = New System.Windows.Forms.NumericUpDown()
        Me.nud_hfin = New System.Windows.Forms.NumericUpDown()
        Me.nud_mininicio = New System.Windows.Forms.NumericUpDown()
        Me.nud_hinicio = New System.Windows.Forms.NumericUpDown()
        Me.txt_idmoto = New System.Windows.Forms.TextBox()
        Me.datetime_ffin = New System.Windows.Forms.DateTimePicker()
        Me.datetime_finicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Detalle_reservaTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_dreservaTableAdapters.detalle_reservaTableAdapter()
        Me.ReservaTableAdapter = New Alquiler_motos.modelo_cbx_reservaTableAdapters.reservaTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallereservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet_dreserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p_cliente.SuspendLayout()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_reserva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_minfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_hfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_mininicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_hinicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(14, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 566)
        Me.Panel2.TabIndex = 45
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
        Me.Label11.Size = New System.Drawing.Size(122, 37)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Detalle"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbx_listar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btn_listar)
        Me.Panel1.Controls.Add(Me.tablacliente)
        Me.Panel1.Location = New System.Drawing.Point(211, 320)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 274)
        Me.Panel1.TabIndex = 44
        '
        'cbx_listar
        '
        Me.cbx_listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_listar.FormattingEnabled = True
        Me.cbx_listar.Items.AddRange(New Object() {"Listar por reserva", "Listar todos los detalles"})
        Me.cbx_listar.Location = New System.Drawing.Point(259, 15)
        Me.cbx_listar.Name = "cbx_listar"
        Me.cbx_listar.Size = New System.Drawing.Size(167, 24)
        Me.cbx_listar.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Lista de Detalle"
        '
        'btn_listar
        '
        Me.btn_listar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listar.ForeColor = System.Drawing.Color.White
        Me.btn_listar.Image = CType(resources.GetObject("btn_listar.Image"), System.Drawing.Image)
        Me.btn_listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_listar.Location = New System.Drawing.Point(431, 6)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(134, 41)
        Me.btn_listar.TabIndex = 24
        Me.btn_listar.Text = "Listar "
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
        Me.tablacliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IddetalleDataGridViewTextBoxColumn, Me.IdreservaDataGridViewTextBoxColumn, Me.IdmotoDataGridViewTextBoxColumn, Me.FechainicioDataGridViewTextBoxColumn, Me.FechafinDataGridViewTextBoxColumn})
        Me.tablacliente.DataSource = Me.DetallereservaBindingSource
        Me.tablacliente.Location = New System.Drawing.Point(8, 52)
        Me.tablacliente.Name = "tablacliente"
        Me.tablacliente.Size = New System.Drawing.Size(557, 201)
        Me.tablacliente.TabIndex = 20
        '
        'IddetalleDataGridViewTextBoxColumn
        '
        Me.IddetalleDataGridViewTextBoxColumn.DataPropertyName = "id_detalle"
        Me.IddetalleDataGridViewTextBoxColumn.HeaderText = "id_detalle"
        Me.IddetalleDataGridViewTextBoxColumn.Name = "IddetalleDataGridViewTextBoxColumn"
        '
        'IdreservaDataGridViewTextBoxColumn
        '
        Me.IdreservaDataGridViewTextBoxColumn.DataPropertyName = "id_reserva"
        Me.IdreservaDataGridViewTextBoxColumn.HeaderText = "id_reserva"
        Me.IdreservaDataGridViewTextBoxColumn.Name = "IdreservaDataGridViewTextBoxColumn"
        '
        'IdmotoDataGridViewTextBoxColumn
        '
        Me.IdmotoDataGridViewTextBoxColumn.DataPropertyName = "id_moto"
        Me.IdmotoDataGridViewTextBoxColumn.HeaderText = "id_moto"
        Me.IdmotoDataGridViewTextBoxColumn.Name = "IdmotoDataGridViewTextBoxColumn"
        '
        'FechainicioDataGridViewTextBoxColumn
        '
        Me.FechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio"
        Me.FechainicioDataGridViewTextBoxColumn.HeaderText = "fecha_inicio"
        Me.FechainicioDataGridViewTextBoxColumn.Name = "FechainicioDataGridViewTextBoxColumn"
        '
        'FechafinDataGridViewTextBoxColumn
        '
        Me.FechafinDataGridViewTextBoxColumn.DataPropertyName = "fecha_fin"
        Me.FechafinDataGridViewTextBoxColumn.HeaderText = "fecha_fin"
        Me.FechafinDataGridViewTextBoxColumn.Name = "FechafinDataGridViewTextBoxColumn"
        '
        'DetallereservaBindingSource
        '
        Me.DetallereservaBindingSource.DataMember = "detalle_reserva"
        Me.DetallereservaBindingSource.DataSource = Me.Alquiler_motosDataSet_dreserva
        '
        'Alquiler_motosDataSet_dreserva
        '
        Me.Alquiler_motosDataSet_dreserva.DataSetName = "Alquiler_motosDataSet_dreserva"
        Me.Alquiler_motosDataSet_dreserva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'p_cliente
        '
        Me.p_cliente.BackColor = System.Drawing.Color.Transparent
        Me.p_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p_cliente.Controls.Add(Me.cbx_idreserva)
        Me.p_cliente.Controls.Add(Me.btn_seleccionar)
        Me.p_cliente.Controls.Add(Me.Label8)
        Me.p_cliente.Controls.Add(Me.Label7)
        Me.p_cliente.Controls.Add(Me.Label3)
        Me.p_cliente.Controls.Add(Me.nud_minfin)
        Me.p_cliente.Controls.Add(Me.nud_hfin)
        Me.p_cliente.Controls.Add(Me.nud_mininicio)
        Me.p_cliente.Controls.Add(Me.nud_hinicio)
        Me.p_cliente.Controls.Add(Me.txt_idmoto)
        Me.p_cliente.Controls.Add(Me.datetime_ffin)
        Me.p_cliente.Controls.Add(Me.datetime_finicio)
        Me.p_cliente.Controls.Add(Me.Label4)
        Me.p_cliente.Controls.Add(Me.Label9)
        Me.p_cliente.Controls.Add(Me.Label2)
        Me.p_cliente.Controls.Add(Me.Label1)
        Me.p_cliente.Controls.Add(Me.Label6)
        Me.p_cliente.Location = New System.Drawing.Point(211, 72)
        Me.p_cliente.Name = "p_cliente"
        Me.p_cliente.Size = New System.Drawing.Size(448, 222)
        Me.p_cliente.TabIndex = 43
        '
        'cbx_idreserva
        '
        Me.cbx_idreserva.DataSource = Me.ReservaBindingSource
        Me.cbx_idreserva.DisplayMember = "id_reserva"
        Me.cbx_idreserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_idreserva.FormattingEnabled = True
        Me.cbx_idreserva.Location = New System.Drawing.Point(124, 43)
        Me.cbx_idreserva.Name = "cbx_idreserva"
        Me.cbx_idreserva.Size = New System.Drawing.Size(127, 24)
        Me.cbx_idreserva.TabIndex = 56
        Me.cbx_idreserva.ValueMember = "id_reserva"
        '
        'ReservaBindingSource
        '
        Me.ReservaBindingSource.DataMember = "reserva"
        Me.ReservaBindingSource.DataSource = Me.Modelo_cbx_reserva
        '
        'Modelo_cbx_reserva
        '
        Me.Modelo_cbx_reserva.DataSetName = "modelo_cbx_reserva"
        Me.Modelo_cbx_reserva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_seleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seleccionar.ForeColor = System.Drawing.Color.White
        Me.btn_seleccionar.Image = CType(resources.GetObject("btn_seleccionar.Image"), System.Drawing.Image)
        Me.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionar.Location = New System.Drawing.Point(259, 78)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(153, 35)
        Me.btn_seleccionar.TabIndex = 46
        Me.btn_seleccionar.Text = "detalle de moto"
        Me.btn_seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(387, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 22)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 22)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(371, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Hora"
        '
        'nud_minfin
        '
        Me.nud_minfin.Location = New System.Drawing.Point(406, 176)
        Me.nud_minfin.Name = "nud_minfin"
        Me.nud_minfin.Size = New System.Drawing.Size(37, 20)
        Me.nud_minfin.TabIndex = 52
        '
        'nud_hfin
        '
        Me.nud_hfin.Location = New System.Drawing.Point(347, 176)
        Me.nud_hfin.Name = "nud_hfin"
        Me.nud_hfin.Size = New System.Drawing.Size(37, 20)
        Me.nud_hfin.TabIndex = 51
        Me.nud_hfin.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nud_mininicio
        '
        Me.nud_mininicio.Location = New System.Drawing.Point(406, 137)
        Me.nud_mininicio.Name = "nud_mininicio"
        Me.nud_mininicio.Size = New System.Drawing.Size(37, 20)
        Me.nud_mininicio.TabIndex = 50
        '
        'nud_hinicio
        '
        Me.nud_hinicio.Location = New System.Drawing.Point(347, 137)
        Me.nud_hinicio.Name = "nud_hinicio"
        Me.nud_hinicio.Size = New System.Drawing.Size(37, 20)
        Me.nud_hinicio.TabIndex = 49
        Me.nud_hinicio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txt_idmoto
        '
        Me.txt_idmoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idmoto.Location = New System.Drawing.Point(124, 85)
        Me.txt_idmoto.Name = "txt_idmoto"
        Me.txt_idmoto.Size = New System.Drawing.Size(127, 22)
        Me.txt_idmoto.TabIndex = 48
        '
        'datetime_ffin
        '
        Me.datetime_ffin.Location = New System.Drawing.Point(124, 176)
        Me.datetime_ffin.Name = "datetime_ffin"
        Me.datetime_ffin.Size = New System.Drawing.Size(210, 20)
        Me.datetime_ffin.TabIndex = 34
        '
        'datetime_finicio
        '
        Me.datetime_finicio.Location = New System.Drawing.Point(124, 137)
        Me.datetime_finicio.Name = "datetime_finicio"
        Me.datetime_finicio.Size = New System.Drawing.Size(210, 20)
        Me.datetime_finicio.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Fecha fin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Datos de Detalle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha Inicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Id de Reserva"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Id de moto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(290, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Id de Detalle"
        '
        'btn_insertar
        '
        Me.btn_insertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_insertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertar.ForeColor = System.Drawing.Color.White
        Me.btn_insertar.Image = CType(resources.GetObject("btn_insertar.Image"), System.Drawing.Image)
        Me.btn_insertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_insertar.Location = New System.Drawing.Point(675, 249)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(120, 45)
        Me.btn_insertar.TabIndex = 42
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
        Me.btn_eliminar.Location = New System.Drawing.Point(675, 129)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(120, 45)
        Me.btn_eliminar.TabIndex = 41
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
        Me.btn_actualizar.Location = New System.Drawing.Point(675, 192)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(120, 45)
        Me.btn_actualizar.TabIndex = 40
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.White
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(675, 72)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(120, 45)
        Me.btn_buscar.TabIndex = 38
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(396, 28)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(183, 22)
        Me.txt_id.TabIndex = 37
        '
        'Detalle_reservaTableAdapter
        '
        Me.Detalle_reservaTableAdapter.ClearBeforeFill = True
        '
        'ReservaTableAdapter
        '
        Me.ReservaTableAdapter.ClearBeforeFill = True
        '
        'detalle_reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 611)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.p_cliente)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_id)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "detalle_reserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Reserva"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallereservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet_dreserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p_cliente.ResumeLayout(False)
        Me.p_cliente.PerformLayout()
        CType(Me.ReservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_reserva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_minfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_hfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_mininicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_hinicio, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Alquiler_motosDataSet_dreserva As Alquiler_motosDataSet_dreserva
    Friend WithEvents DetallereservaBindingSource As BindingSource
    Friend WithEvents Detalle_reservaTableAdapter As Alquiler_motosDataSet_dreservaTableAdapters.detalle_reservaTableAdapter
    Friend WithEvents IddetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdreservaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdmotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechainicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechafinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txt_idmoto As TextBox
    Friend WithEvents datetime_ffin As DateTimePicker
    Friend WithEvents datetime_finicio As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_seleccionar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nud_minfin As NumericUpDown
    Friend WithEvents nud_hfin As NumericUpDown
    Friend WithEvents nud_mininicio As NumericUpDown
    Friend WithEvents nud_hinicio As NumericUpDown
    Friend WithEvents cbx_idreserva As ComboBox
    Friend WithEvents Modelo_cbx_reserva As modelo_cbx_reserva
    Friend WithEvents ReservaBindingSource As BindingSource
    Friend WithEvents ReservaTableAdapter As modelo_cbx_reservaTableAdapters.reservaTableAdapter
    Friend WithEvents cbx_listar As ComboBox
End Class
