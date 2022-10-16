<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alquiler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alquiler))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.p_cliente = New System.Windows.Forms.Panel()
        Me.btn_seleccionarcliente = New System.Windows.Forms.Button()
        Me.cbx_idcliente = New System.Windows.Forms.ComboBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelocbxclienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_cliente = New Alquiler_motos.Modelo_cbx_cliente()
        Me.cbx_idtrabajador = New System.Windows.Forms.ComboBox()
        Me.TrabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelocbxtrabajadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_trabajador = New Alquiler_motos.modelo_cbx_trabajador()
        Me.cbx_agencia = New System.Windows.Forms.ComboBox()
        Me.AgenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelocbxagenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_agencia = New Alquiler_motos.modelo_cbx_agencia()
        Me.cbox_estado = New System.Windows.Forms.CheckBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_idreserva = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.nud_mininicio = New System.Windows.Forms.NumericUpDown()
        Me.nud_hinicio = New System.Windows.Forms.NumericUpDown()
        Me.datetime_finicio = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nud_minfin = New System.Windows.Forms.NumericUpDown()
        Me.nud_hfin = New System.Windows.Forms.NumericUpDown()
        Me.txt_idmoto = New System.Windows.Forms.TextBox()
        Me.datetime_ffin = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tablaproductos = New System.Windows.Forms.DataGridView()
        Me.IddetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdreservaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdmotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechainicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetallereservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlquilermotosDataSetdreservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet_dreserva = New Alquiler_motos.Alquiler_motosDataSet_dreserva()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbx_formapago = New System.Windows.Forms.ComboBox()
        Me.FormapagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_formapago = New Alquiler_motos.modelo_cbx_formapago()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_idcomprobante = New System.Windows.Forms.TextBox()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_generarcomprobante = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nud_minuto = New System.Windows.Forms.NumericUpDown()
        Me.nud_hora = New System.Windows.Forms.NumericUpDown()
        Me.datetime_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbx_tcomprobante = New System.Windows.Forms.ComboBox()
        Me.TipocomprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelocbxtcomprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Modelo_cbx_tcomprobante = New Alquiler_motos.modelo_cbx_tcomprobante()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_igv = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AgenciaTableAdapter = New Alquiler_motos.modelo_cbx_agenciaTableAdapters.agenciaTableAdapter()
        Me.TrabajadorTableAdapter = New Alquiler_motos.modelo_cbx_trabajadorTableAdapters.trabajadorTableAdapter()
        Me.ClienteTableAdapter = New Alquiler_motos.Modelo_cbx_clienteTableAdapters.clienteTableAdapter()
        Me.Tipo_comprobanteTableAdapter = New Alquiler_motos.modelo_cbx_tcomprobanteTableAdapters.tipo_comprobanteTableAdapter()
        Me.Detalle_reservaTableAdapter = New Alquiler_motos.Alquiler_motosDataSet_dreservaTableAdapters.detalle_reservaTableAdapter()
        Me.Forma_pagoTableAdapter = New Alquiler_motos.modelo_cbx_formapagoTableAdapters.forma_pagoTableAdapter()
        Me.p_cliente.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelocbxclienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelocbxtrabajadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_trabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelocbxagenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_agencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.nud_mininicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_hinicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_minfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_hfin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablaproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallereservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquilermotosDataSetdreservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet_dreserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.FormapagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_formapago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_minuto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_hora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipocomprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelocbxtcomprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Modelo_cbx_tcomprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p_cliente
        '
        Me.p_cliente.BackColor = System.Drawing.Color.Transparent
        Me.p_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p_cliente.Controls.Add(Me.btn_seleccionarcliente)
        Me.p_cliente.Controls.Add(Me.cbx_idcliente)
        Me.p_cliente.Controls.Add(Me.cbx_idtrabajador)
        Me.p_cliente.Controls.Add(Me.cbx_agencia)
        Me.p_cliente.Controls.Add(Me.cbox_estado)
        Me.p_cliente.Controls.Add(Me.btn_buscar)
        Me.p_cliente.Controls.Add(Me.Label1)
        Me.p_cliente.Controls.Add(Me.Label9)
        Me.p_cliente.Controls.Add(Me.txt_idreserva)
        Me.p_cliente.Controls.Add(Me.Label2)
        Me.p_cliente.Controls.Add(Me.Label3)
        Me.p_cliente.Controls.Add(Me.Label6)
        Me.p_cliente.Controls.Add(Me.Label5)
        Me.p_cliente.Location = New System.Drawing.Point(12, 12)
        Me.p_cliente.Name = "p_cliente"
        Me.p_cliente.Size = New System.Drawing.Size(980, 204)
        Me.p_cliente.TabIndex = 40
        '
        'btn_seleccionarcliente
        '
        Me.btn_seleccionarcliente.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_seleccionarcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seleccionarcliente.ForeColor = System.Drawing.Color.White
        Me.btn_seleccionarcliente.Image = CType(resources.GetObject("btn_seleccionarcliente.Image"), System.Drawing.Image)
        Me.btn_seleccionarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionarcliente.Location = New System.Drawing.Point(735, 89)
        Me.btn_seleccionarcliente.Name = "btn_seleccionarcliente"
        Me.btn_seleccionarcliente.Size = New System.Drawing.Size(115, 42)
        Me.btn_seleccionarcliente.TabIndex = 37
        Me.btn_seleccionarcliente.Text = "ver cliente"
        Me.btn_seleccionarcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionarcliente.UseVisualStyleBackColor = False
        '
        'cbx_idcliente
        '
        Me.cbx_idcliente.DataSource = Me.ClienteBindingSource
        Me.cbx_idcliente.DisplayMember = "id_cliente"
        Me.cbx_idcliente.Enabled = False
        Me.cbx_idcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_idcliente.FormattingEnabled = True
        Me.cbx_idcliente.Location = New System.Drawing.Point(563, 99)
        Me.cbx_idcliente.Name = "cbx_idcliente"
        Me.cbx_idcliente.Size = New System.Drawing.Size(163, 24)
        Me.cbx_idcliente.TabIndex = 31
        Me.cbx_idcliente.ValueMember = "id_cliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.ModelocbxclienteBindingSource
        '
        'ModelocbxclienteBindingSource
        '
        Me.ModelocbxclienteBindingSource.DataSource = Me.Modelo_cbx_cliente
        Me.ModelocbxclienteBindingSource.Position = 0
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
        Me.cbx_idtrabajador.Enabled = False
        Me.cbx_idtrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_idtrabajador.FormattingEnabled = True
        Me.cbx_idtrabajador.Location = New System.Drawing.Point(160, 157)
        Me.cbx_idtrabajador.Name = "cbx_idtrabajador"
        Me.cbx_idtrabajador.Size = New System.Drawing.Size(221, 24)
        Me.cbx_idtrabajador.TabIndex = 30
        Me.cbx_idtrabajador.ValueMember = "id_trabajor"
        '
        'TrabajadorBindingSource
        '
        Me.TrabajadorBindingSource.DataMember = "trabajador"
        Me.TrabajadorBindingSource.DataSource = Me.ModelocbxtrabajadorBindingSource
        '
        'ModelocbxtrabajadorBindingSource
        '
        Me.ModelocbxtrabajadorBindingSource.DataSource = Me.Modelo_cbx_trabajador
        Me.ModelocbxtrabajadorBindingSource.Position = 0
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
        Me.cbx_agencia.Enabled = False
        Me.cbx_agencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_agencia.FormattingEnabled = True
        Me.cbx_agencia.Location = New System.Drawing.Point(160, 100)
        Me.cbx_agencia.Name = "cbx_agencia"
        Me.cbx_agencia.Size = New System.Drawing.Size(221, 24)
        Me.cbx_agencia.TabIndex = 29
        Me.cbx_agencia.ValueMember = "nombre_agencia"
        '
        'AgenciaBindingSource
        '
        Me.AgenciaBindingSource.DataMember = "agencia"
        Me.AgenciaBindingSource.DataSource = Me.ModelocbxagenciaBindingSource
        '
        'ModelocbxagenciaBindingSource
        '
        Me.ModelocbxagenciaBindingSource.DataSource = Me.Modelo_cbx_agencia
        Me.ModelocbxagenciaBindingSource.Position = 0
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
        Me.cbox_estado.Location = New System.Drawing.Point(563, 156)
        Me.cbox_estado.Name = "cbox_estado"
        Me.cbox_estado.Size = New System.Drawing.Size(105, 20)
        Me.cbox_estado.TabIndex = 28
        Me.cbox_estado.Text = "No Pagada"
        Me.cbox_estado.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.White
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_buscar.Location = New System.Drawing.Point(632, 25)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(107, 43)
        Me.btn_buscar.TabIndex = 35
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ID de Reserva"
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
        'txt_idreserva
        '
        Me.txt_idreserva.Enabled = False
        Me.txt_idreserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idreserva.Location = New System.Drawing.Point(385, 39)
        Me.txt_idreserva.Name = "txt_idreserva"
        Me.txt_idreserva.Size = New System.Drawing.Size(237, 22)
        Me.txt_idreserva.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Id de cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(465, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Id de Trabajador"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 102)
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
        Me.btn_insertar.Location = New System.Drawing.Point(17, 369)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(174, 45)
        Me.btn_insertar.TabIndex = 39
        Me.btn_insertar.Text = "Agregar Producto"
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
        Me.btn_eliminar.Location = New System.Drawing.Point(378, 369)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(175, 45)
        Me.btn_eliminar.TabIndex = 38
        Me.btn_eliminar.Text = "Eliminar Producto"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.nud_mininicio)
        Me.Panel1.Controls.Add(Me.nud_hinicio)
        Me.Panel1.Controls.Add(Me.datetime_finicio)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.btn_seleccionar)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.nud_minfin)
        Me.Panel1.Controls.Add(Me.nud_hfin)
        Me.Panel1.Controls.Add(Me.txt_idmoto)
        Me.Panel1.Controls.Add(Me.datetime_ffin)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btn_eliminar)
        Me.Panel1.Controls.Add(Me.btn_insertar)
        Me.Panel1.Controls.Add(Me.tablaproductos)
        Me.Panel1.Location = New System.Drawing.Point(12, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 430)
        Me.Panel1.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(453, 103)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 22)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(436, 82)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 16)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "Hora"
        '
        'nud_mininicio
        '
        Me.nud_mininicio.Location = New System.Drawing.Point(471, 103)
        Me.nud_mininicio.Name = "nud_mininicio"
        Me.nud_mininicio.Size = New System.Drawing.Size(37, 20)
        Me.nud_mininicio.TabIndex = 73
        '
        'nud_hinicio
        '
        Me.nud_hinicio.Location = New System.Drawing.Point(412, 103)
        Me.nud_hinicio.Name = "nud_hinicio"
        Me.nud_hinicio.Size = New System.Drawing.Size(37, 20)
        Me.nud_hinicio.TabIndex = 72
        Me.nud_hinicio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'datetime_finicio
        '
        Me.datetime_finicio.Location = New System.Drawing.Point(123, 103)
        Me.datetime_finicio.Name = "datetime_finicio"
        Me.datetime_finicio.Size = New System.Drawing.Size(210, 20)
        Me.datetime_finicio.TabIndex = 71
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 103)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 16)
        Me.Label21.TabIndex = 70
        Me.Label21.Text = "Fecha Inicio"
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_seleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seleccionar.ForeColor = System.Drawing.Color.White
        Me.btn_seleccionar.Image = CType(resources.GetObject("btn_seleccionar.Image"), System.Drawing.Image)
        Me.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionar.Location = New System.Drawing.Point(257, 29)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(115, 47)
        Me.btn_seleccionar.TabIndex = 61
        Me.btn_seleccionar.Text = "Ver moto"
        Me.btn_seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(451, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 22)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = ":"
        '
        'nud_minfin
        '
        Me.nud_minfin.Location = New System.Drawing.Point(470, 136)
        Me.nud_minfin.Name = "nud_minfin"
        Me.nud_minfin.Size = New System.Drawing.Size(37, 20)
        Me.nud_minfin.TabIndex = 66
        '
        'nud_hfin
        '
        Me.nud_hfin.Location = New System.Drawing.Point(411, 136)
        Me.nud_hfin.Name = "nud_hfin"
        Me.nud_hfin.Size = New System.Drawing.Size(37, 20)
        Me.nud_hfin.TabIndex = 65
        Me.nud_hfin.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'txt_idmoto
        '
        Me.txt_idmoto.Enabled = False
        Me.txt_idmoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idmoto.Location = New System.Drawing.Point(122, 45)
        Me.txt_idmoto.Name = "txt_idmoto"
        Me.txt_idmoto.Size = New System.Drawing.Size(127, 22)
        Me.txt_idmoto.TabIndex = 62
        '
        'datetime_ffin
        '
        Me.datetime_ffin.Location = New System.Drawing.Point(122, 136)
        Me.datetime_ffin.Name = "datetime_ffin"
        Me.datetime_ffin.Size = New System.Drawing.Size(210, 20)
        Me.datetime_ffin.TabIndex = 60
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 16)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Fecha fin"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(15, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 16)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Id de moto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(209, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Lista de Productos"
        '
        'tablaproductos
        '
        Me.tablaproductos.AllowUserToAddRows = False
        Me.tablaproductos.AllowUserToDeleteRows = False
        Me.tablaproductos.AutoGenerateColumns = False
        Me.tablaproductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaproductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tablaproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaproductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IddetalleDataGridViewTextBoxColumn, Me.IdreservaDataGridViewTextBoxColumn, Me.IdmotoDataGridViewTextBoxColumn, Me.FechainicioDataGridViewTextBoxColumn, Me.FechafinDataGridViewTextBoxColumn})
        Me.tablaproductos.DataSource = Me.DetallereservaBindingSource
        Me.tablaproductos.Location = New System.Drawing.Point(8, 162)
        Me.tablaproductos.Name = "tablaproductos"
        Me.tablaproductos.ReadOnly = True
        Me.tablaproductos.Size = New System.Drawing.Size(545, 201)
        Me.tablaproductos.TabIndex = 20
        '
        'IddetalleDataGridViewTextBoxColumn
        '
        Me.IddetalleDataGridViewTextBoxColumn.DataPropertyName = "id_detalle"
        Me.IddetalleDataGridViewTextBoxColumn.HeaderText = "id_detalle"
        Me.IddetalleDataGridViewTextBoxColumn.Name = "IddetalleDataGridViewTextBoxColumn"
        Me.IddetalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdreservaDataGridViewTextBoxColumn
        '
        Me.IdreservaDataGridViewTextBoxColumn.DataPropertyName = "id_reserva"
        Me.IdreservaDataGridViewTextBoxColumn.HeaderText = "id_reserva"
        Me.IdreservaDataGridViewTextBoxColumn.Name = "IdreservaDataGridViewTextBoxColumn"
        Me.IdreservaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdmotoDataGridViewTextBoxColumn
        '
        Me.IdmotoDataGridViewTextBoxColumn.DataPropertyName = "id_moto"
        Me.IdmotoDataGridViewTextBoxColumn.HeaderText = "id_moto"
        Me.IdmotoDataGridViewTextBoxColumn.Name = "IdmotoDataGridViewTextBoxColumn"
        Me.IdmotoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechainicioDataGridViewTextBoxColumn
        '
        Me.FechainicioDataGridViewTextBoxColumn.DataPropertyName = "fecha_inicio"
        Me.FechainicioDataGridViewTextBoxColumn.HeaderText = "fecha_inicio"
        Me.FechainicioDataGridViewTextBoxColumn.Name = "FechainicioDataGridViewTextBoxColumn"
        Me.FechainicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechafinDataGridViewTextBoxColumn
        '
        Me.FechafinDataGridViewTextBoxColumn.DataPropertyName = "fecha_fin"
        Me.FechafinDataGridViewTextBoxColumn.HeaderText = "fecha_fin"
        Me.FechafinDataGridViewTextBoxColumn.Name = "FechafinDataGridViewTextBoxColumn"
        Me.FechafinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetallereservaBindingSource
        '
        Me.DetallereservaBindingSource.DataMember = "detalle_reserva"
        Me.DetallereservaBindingSource.DataSource = Me.AlquilermotosDataSetdreservaBindingSource
        '
        'AlquilermotosDataSetdreservaBindingSource
        '
        Me.AlquilermotosDataSetdreservaBindingSource.DataSource = Me.Alquiler_motosDataSet_dreserva
        Me.AlquilermotosDataSetdreservaBindingSource.Position = 0
        '
        'Alquiler_motosDataSet_dreserva
        '
        Me.Alquiler_motosDataSet_dreserva.DataSetName = "Alquiler_motosDataSet_dreserva"
        Me.Alquiler_motosDataSet_dreserva.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cbx_formapago)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.txt_idcomprobante)
        Me.Panel2.Controls.Add(Me.btn_imprimir)
        Me.Panel2.Controls.Add(Me.btn_generarcomprobante)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.nud_minuto)
        Me.Panel2.Controls.Add(Me.nud_hora)
        Me.Panel2.Controls.Add(Me.datetime_fecha)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.cbx_tcomprobante)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_igv)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt_subtotal)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txt_total)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(590, 232)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 430)
        Me.Panel2.TabIndex = 46
        '
        'cbx_formapago
        '
        Me.cbx_formapago.DataSource = Me.FormapagoBindingSource
        Me.cbx_formapago.DisplayMember = "descripcion"
        Me.cbx_formapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_formapago.FormattingEnabled = True
        Me.cbx_formapago.Location = New System.Drawing.Point(174, 126)
        Me.cbx_formapago.Name = "cbx_formapago"
        Me.cbx_formapago.Size = New System.Drawing.Size(180, 24)
        Me.cbx_formapago.TabIndex = 63
        Me.cbx_formapago.ValueMember = "descripcion"
        '
        'FormapagoBindingSource
        '
        Me.FormapagoBindingSource.DataMember = "forma_pago"
        Me.FormapagoBindingSource.DataSource = Me.Modelo_cbx_formapago
        '
        'Modelo_cbx_formapago
        '
        Me.Modelo_cbx_formapago.DataSetName = "modelo_cbx_formapago"
        Me.Modelo_cbx_formapago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(18, 45)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 16)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Id comprobante"
        '
        'txt_idcomprobante
        '
        Me.txt_idcomprobante.Enabled = False
        Me.txt_idcomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idcomprobante.Location = New System.Drawing.Point(174, 41)
        Me.txt_idcomprobante.Name = "txt_idcomprobante"
        Me.txt_idcomprobante.Size = New System.Drawing.Size(180, 22)
        Me.txt_idcomprobante.TabIndex = 61
        '
        'btn_imprimir
        '
        Me.btn_imprimir.BackColor = System.Drawing.Color.Teal
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.ForeColor = System.Drawing.Color.White
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_imprimir.Location = New System.Drawing.Point(239, 369)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(158, 45)
        Me.btn_imprimir.TabIndex = 38
        Me.btn_imprimir.Text = "Imprimir comprobante"
        Me.btn_imprimir.UseVisualStyleBackColor = False
        '
        'btn_generarcomprobante
        '
        Me.btn_generarcomprobante.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_generarcomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generarcomprobante.ForeColor = System.Drawing.Color.White
        Me.btn_generarcomprobante.Image = CType(resources.GetObject("btn_generarcomprobante.Image"), System.Drawing.Image)
        Me.btn_generarcomprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generarcomprobante.Location = New System.Drawing.Point(9, 369)
        Me.btn_generarcomprobante.Name = "btn_generarcomprobante"
        Me.btn_generarcomprobante.Size = New System.Drawing.Size(163, 45)
        Me.btn_generarcomprobante.TabIndex = 58
        Me.btn_generarcomprobante.Text = "Generar comprobante"
        Me.btn_generarcomprobante.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(330, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 22)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(313, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 16)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Hora"
        '
        'nud_minuto
        '
        Me.nud_minuto.Enabled = False
        Me.nud_minuto.Location = New System.Drawing.Point(348, 175)
        Me.nud_minuto.Name = "nud_minuto"
        Me.nud_minuto.Size = New System.Drawing.Size(37, 20)
        Me.nud_minuto.TabIndex = 58
        '
        'nud_hora
        '
        Me.nud_hora.Enabled = False
        Me.nud_hora.Location = New System.Drawing.Point(289, 175)
        Me.nud_hora.Name = "nud_hora"
        Me.nud_hora.Size = New System.Drawing.Size(37, 20)
        Me.nud_hora.TabIndex = 57
        Me.nud_hora.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'datetime_fecha
        '
        Me.datetime_fecha.Enabled = False
        Me.datetime_fecha.Location = New System.Drawing.Point(61, 176)
        Me.datetime_fecha.Name = "datetime_fecha"
        Me.datetime_fecha.Size = New System.Drawing.Size(210, 20)
        Me.datetime_fecha.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 176)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 16)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Fecha"
        '
        'cbx_tcomprobante
        '
        Me.cbx_tcomprobante.DataSource = Me.TipocomprobanteBindingSource
        Me.cbx_tcomprobante.DisplayMember = "descripcion"
        Me.cbx_tcomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_tcomprobante.FormattingEnabled = True
        Me.cbx_tcomprobante.Location = New System.Drawing.Point(174, 85)
        Me.cbx_tcomprobante.Name = "cbx_tcomprobante"
        Me.cbx_tcomprobante.Size = New System.Drawing.Size(180, 24)
        Me.cbx_tcomprobante.TabIndex = 30
        Me.cbx_tcomprobante.ValueMember = "descripcion"
        '
        'TipocomprobanteBindingSource
        '
        Me.TipocomprobanteBindingSource.DataMember = "tipo_comprobante"
        Me.TipocomprobanteBindingSource.DataSource = Me.ModelocbxtcomprobanteBindingSource
        '
        'ModelocbxtcomprobanteBindingSource
        '
        Me.ModelocbxtcomprobanteBindingSource.DataSource = Me.Modelo_cbx_tcomprobante
        Me.ModelocbxtcomprobanteBindingSource.Position = 0
        '
        'Modelo_cbx_tcomprobante
        '
        Me.Modelo_cbx_tcomprobante.DataSetName = "modelo_cbx_tcomprobante"
        Me.Modelo_cbx_tcomprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 25)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Datos de Comprobante"
        '
        'txt_igv
        '
        Me.txt_igv.Enabled = False
        Me.txt_igv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_igv.Location = New System.Drawing.Point(174, 257)
        Me.txt_igv.Name = "txt_igv"
        Me.txt_igv.Size = New System.Drawing.Size(180, 22)
        Me.txt_igv.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(85, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "IGV"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(85, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(85, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Subtotal"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal.Location = New System.Drawing.Point(174, 217)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(180, 22)
        Me.txt_subtotal.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Forma de Pago"
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(174, 294)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(180, 22)
        Me.txt_total.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Tipo de comprobante"
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
        'Tipo_comprobanteTableAdapter
        '
        Me.Tipo_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'Detalle_reservaTableAdapter
        '
        Me.Detalle_reservaTableAdapter.ClearBeforeFill = True
        '
        'Forma_pagoTableAdapter
        '
        Me.Forma_pagoTableAdapter.ClearBeforeFill = True
        '
        'Alquiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 675)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.p_cliente)
        Me.Name = "Alquiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alquiler"
        Me.p_cliente.ResumeLayout(False)
        Me.p_cliente.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelocbxclienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelocbxtrabajadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_trabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelocbxagenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_agencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nud_mininicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_hinicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_minfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_hfin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablaproductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallereservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquilermotosDataSetdreservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet_dreserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.FormapagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_formapago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_minuto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_hora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipocomprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelocbxtcomprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Modelo_cbx_tcomprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p_cliente As Panel
    Friend WithEvents cbx_idcliente As ComboBox
    Friend WithEvents cbx_idtrabajador As ComboBox
    Friend WithEvents cbx_agencia As ComboBox
    Friend WithEvents cbox_estado As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_idreserva As TextBox
    Friend WithEvents btn_seleccionarcliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents tablaproductos As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbx_tcomprobante As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_igv As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_generarcomprobante As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents nud_minuto As NumericUpDown
    Friend WithEvents nud_hora As NumericUpDown
    Friend WithEvents datetime_fecha As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents btn_seleccionar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents nud_minfin As NumericUpDown
    Friend WithEvents nud_hfin As NumericUpDown
    Friend WithEvents txt_idmoto As TextBox
    Friend WithEvents datetime_ffin As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents btn_imprimir As Button
    Friend WithEvents ModelocbxagenciaBindingSource As BindingSource
    Friend WithEvents Modelo_cbx_agencia As modelo_cbx_agencia
    Friend WithEvents AgenciaBindingSource As BindingSource
    Friend WithEvents AgenciaTableAdapter As modelo_cbx_agenciaTableAdapters.agenciaTableAdapter
    Friend WithEvents ModelocbxtrabajadorBindingSource As BindingSource
    Friend WithEvents Modelo_cbx_trabajador As modelo_cbx_trabajador
    Friend WithEvents TrabajadorBindingSource As BindingSource
    Friend WithEvents TrabajadorTableAdapter As modelo_cbx_trabajadorTableAdapters.trabajadorTableAdapter
    Friend WithEvents ModelocbxclienteBindingSource As BindingSource
    Friend WithEvents Modelo_cbx_cliente As Modelo_cbx_cliente
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As Modelo_cbx_clienteTableAdapters.clienteTableAdapter
    Friend WithEvents ModelocbxtcomprobanteBindingSource As BindingSource
    Friend WithEvents Modelo_cbx_tcomprobante As modelo_cbx_tcomprobante
    Friend WithEvents TipocomprobanteBindingSource As BindingSource
    Friend WithEvents Tipo_comprobanteTableAdapter As modelo_cbx_tcomprobanteTableAdapters.tipo_comprobanteTableAdapter
    Friend WithEvents AlquilermotosDataSetdreservaBindingSource As BindingSource
    Friend WithEvents Alquiler_motosDataSet_dreserva As Alquiler_motosDataSet_dreserva
    Friend WithEvents DetallereservaBindingSource As BindingSource
    Friend WithEvents Detalle_reservaTableAdapter As Alquiler_motosDataSet_dreservaTableAdapters.detalle_reservaTableAdapter
    Friend WithEvents IddetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdreservaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdmotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechainicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechafinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents nud_mininicio As NumericUpDown
    Friend WithEvents nud_hinicio As NumericUpDown
    Friend WithEvents datetime_finicio As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_idcomprobante As TextBox
    Friend WithEvents cbx_formapago As ComboBox
    Friend WithEvents Modelo_cbx_formapago As modelo_cbx_formapago
    Friend WithEvents FormapagoBindingSource As BindingSource
    Friend WithEvents Forma_pagoTableAdapter As modelo_cbx_formapagoTableAdapters.forma_pagoTableAdapter
End Class
