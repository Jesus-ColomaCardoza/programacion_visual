<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class moto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(moto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_filtro = New System.Windows.Forms.TextBox()
        Me.cbx_filtro = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.tablacliente = New System.Windows.Forms.DataGridView()
        Me.IdmotoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcarajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CilindrajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciohoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MotoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet2 = New Alquiler_motos.Alquiler_motosDataSet2()
        Me.p_cliente = New System.Windows.Forms.Panel()
        Me.cbx_g = New System.Windows.Forms.ComboBox()
        Me.GarajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alquiler_motosDataSet3 = New Alquiler_motos.Alquiler_motosDataSet3()
        Me.cbox_estado = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_motor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cili = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.MotoTableAdapter = New Alquiler_motos.Alquiler_motosDataSet2TableAdapters.motoTableAdapter()
        Me.GarajeTableAdapter = New Alquiler_motos.Alquiler_motosDataSet3TableAdapters.garajeTableAdapter()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p_cliente.SuspendLayout()
        CType(Me.GarajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alquiler_motosDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.Label11.Location = New System.Drawing.Point(32, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 37)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Motos"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_filtro)
        Me.Panel1.Controls.Add(Me.cbx_filtro)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btn_listar)
        Me.Panel1.Controls.Add(Me.tablacliente)
        Me.Panel1.Location = New System.Drawing.Point(209, 314)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 274)
        Me.Panel1.TabIndex = 34
        '
        'txt_filtro
        '
        Me.txt_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filtro.Location = New System.Drawing.Point(374, 13)
        Me.txt_filtro.Name = "txt_filtro"
        Me.txt_filtro.Size = New System.Drawing.Size(205, 22)
        Me.txt_filtro.TabIndex = 29
        '
        'cbx_filtro
        '
        Me.cbx_filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_filtro.FormattingEnabled = True
        Me.cbx_filtro.Items.AddRange(New Object() {"Marca", "Modelo", "Color", "Precio"})
        Me.cbx_filtro.Location = New System.Drawing.Point(241, 12)
        Me.cbx_filtro.Name = "cbx_filtro"
        Me.cbx_filtro.Size = New System.Drawing.Size(120, 24)
        Me.cbx_filtro.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Detalle de Moto"
        '
        'btn_listar
        '
        Me.btn_listar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listar.ForeColor = System.Drawing.Color.White
        Me.btn_listar.Image = CType(resources.GetObject("btn_listar.Image"), System.Drawing.Image)
        Me.btn_listar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_listar.Location = New System.Drawing.Point(718, 3)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(141, 41)
        Me.btn_listar.TabIndex = 24
        Me.btn_listar.Text = "Listar Todo"
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
        Me.tablacliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmotoDataGridViewTextBoxColumn, Me.IdcarajeDataGridViewTextBoxColumn, Me.PlacaDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.MotorDataGridViewTextBoxColumn, Me.CilindrajeDataGridViewTextBoxColumn, Me.PreciohoraDataGridViewTextBoxColumn, Me.EstadoDataGridViewCheckBoxColumn})
        Me.tablacliente.DataSource = Me.MotoBindingSource
        Me.tablacliente.Location = New System.Drawing.Point(8, 52)
        Me.tablacliente.Name = "tablacliente"
        Me.tablacliente.Size = New System.Drawing.Size(851, 201)
        Me.tablacliente.TabIndex = 20
        '
        'IdmotoDataGridViewTextBoxColumn
        '
        Me.IdmotoDataGridViewTextBoxColumn.DataPropertyName = "id_moto"
        Me.IdmotoDataGridViewTextBoxColumn.HeaderText = "id_moto"
        Me.IdmotoDataGridViewTextBoxColumn.Name = "IdmotoDataGridViewTextBoxColumn"
        '
        'IdcarajeDataGridViewTextBoxColumn
        '
        Me.IdcarajeDataGridViewTextBoxColumn.DataPropertyName = "id_caraje"
        Me.IdcarajeDataGridViewTextBoxColumn.HeaderText = "id_caraje"
        Me.IdcarajeDataGridViewTextBoxColumn.Name = "IdcarajeDataGridViewTextBoxColumn"
        '
        'PlacaDataGridViewTextBoxColumn
        '
        Me.PlacaDataGridViewTextBoxColumn.DataPropertyName = "placa"
        Me.PlacaDataGridViewTextBoxColumn.HeaderText = "placa"
        Me.PlacaDataGridViewTextBoxColumn.Name = "PlacaDataGridViewTextBoxColumn"
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'MotorDataGridViewTextBoxColumn
        '
        Me.MotorDataGridViewTextBoxColumn.DataPropertyName = "motor"
        Me.MotorDataGridViewTextBoxColumn.HeaderText = "motor"
        Me.MotorDataGridViewTextBoxColumn.Name = "MotorDataGridViewTextBoxColumn"
        '
        'CilindrajeDataGridViewTextBoxColumn
        '
        Me.CilindrajeDataGridViewTextBoxColumn.DataPropertyName = "cilindraje"
        Me.CilindrajeDataGridViewTextBoxColumn.HeaderText = "cilindraje"
        Me.CilindrajeDataGridViewTextBoxColumn.Name = "CilindrajeDataGridViewTextBoxColumn"
        '
        'PreciohoraDataGridViewTextBoxColumn
        '
        Me.PreciohoraDataGridViewTextBoxColumn.DataPropertyName = "precio_hora"
        Me.PreciohoraDataGridViewTextBoxColumn.HeaderText = "precio_hora"
        Me.PreciohoraDataGridViewTextBoxColumn.Name = "PreciohoraDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewCheckBoxColumn
        '
        Me.EstadoDataGridViewCheckBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewCheckBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewCheckBoxColumn.Name = "EstadoDataGridViewCheckBoxColumn"
        '
        'MotoBindingSource
        '
        Me.MotoBindingSource.DataMember = "moto"
        Me.MotoBindingSource.DataSource = Me.Alquiler_motosDataSet2
        '
        'Alquiler_motosDataSet2
        '
        Me.Alquiler_motosDataSet2.DataSetName = "Alquiler_motosDataSet2"
        Me.Alquiler_motosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'p_cliente
        '
        Me.p_cliente.BackColor = System.Drawing.Color.Transparent
        Me.p_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p_cliente.Controls.Add(Me.cbx_g)
        Me.p_cliente.Controls.Add(Me.cbox_estado)
        Me.p_cliente.Controls.Add(Me.Label14)
        Me.p_cliente.Controls.Add(Me.Label13)
        Me.p_cliente.Controls.Add(Me.txt_precio)
        Me.p_cliente.Controls.Add(Me.Label9)
        Me.p_cliente.Controls.Add(Me.txt_marca)
        Me.p_cliente.Controls.Add(Me.txt_modelo)
        Me.p_cliente.Controls.Add(Me.txt_motor)
        Me.p_cliente.Controls.Add(Me.Label2)
        Me.p_cliente.Controls.Add(Me.Label3)
        Me.p_cliente.Controls.Add(Me.Label4)
        Me.p_cliente.Controls.Add(Me.Label8)
        Me.p_cliente.Controls.Add(Me.txt_placa)
        Me.p_cliente.Controls.Add(Me.Label7)
        Me.p_cliente.Controls.Add(Me.txt_color)
        Me.p_cliente.Controls.Add(Me.Label6)
        Me.p_cliente.Controls.Add(Me.txt_cili)
        Me.p_cliente.Controls.Add(Me.Label5)
        Me.p_cliente.Location = New System.Drawing.Point(209, 66)
        Me.p_cliente.Name = "p_cliente"
        Me.p_cliente.Size = New System.Drawing.Size(717, 222)
        Me.p_cliente.TabIndex = 33
        '
        'cbx_g
        '
        Me.cbx_g.DataSource = Me.GarajeBindingSource
        Me.cbx_g.DisplayMember = "direccion"
        Me.cbx_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_g.FormattingEnabled = True
        Me.cbx_g.Location = New System.Drawing.Point(147, 48)
        Me.cbx_g.Name = "cbx_g"
        Me.cbx_g.Size = New System.Drawing.Size(180, 24)
        Me.cbx_g.TabIndex = 28
        Me.cbx_g.ValueMember = "direccion"
        '
        'GarajeBindingSource
        '
        Me.GarajeBindingSource.DataMember = "garaje"
        Me.GarajeBindingSource.DataSource = Me.Alquiler_motosDataSet3
        '
        'Alquiler_motosDataSet3
        '
        Me.Alquiler_motosDataSet3.DataSetName = "Alquiler_motosDataSet3"
        Me.Alquiler_motosDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbox_estado
        '
        Me.cbox_estado.AutoSize = True
        Me.cbox_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_estado.Location = New System.Drawing.Point(522, 176)
        Me.cbox_estado.Name = "cbox_estado"
        Me.cbox_estado.Size = New System.Drawing.Size(125, 20)
        Me.cbox_estado.TabIndex = 27
        Me.cbox_estado.Text = "No Disponible"
        Me.cbox_estado.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(422, 180)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Estado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(422, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 16)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Precio/Hora"
        '
        'txt_precio
        '
        Me.txt_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precio.Location = New System.Drawing.Point(522, 133)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(166, 22)
        Me.txt_precio.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Datos de Moto"
        '
        'txt_marca
        '
        Me.txt_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_marca.Location = New System.Drawing.Point(147, 130)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(180, 22)
        Me.txt_marca.TabIndex = 1
        '
        'txt_modelo
        '
        Me.txt_modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_modelo.Location = New System.Drawing.Point(147, 169)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.Size = New System.Drawing.Size(180, 22)
        Me.txt_modelo.TabIndex = 2
        '
        'txt_motor
        '
        Me.txt_motor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_motor.Location = New System.Drawing.Point(522, 60)
        Me.txt_motor.Name = "txt_motor"
        Me.txt_motor.Size = New System.Drawing.Size(166, 22)
        Me.txt_motor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(422, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Motor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(422, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cilindraje"
        '
        'txt_placa
        '
        Me.txt_placa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_placa.Location = New System.Drawing.Point(147, 93)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(180, 22)
        Me.txt_placa.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(422, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Color"
        '
        'txt_color
        '
        Me.txt_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Location = New System.Drawing.Point(522, 20)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(166, 22)
        Me.txt_color.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Placa"
        '
        'txt_cili
        '
        Me.txt_cili.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cili.Location = New System.Drawing.Point(522, 97)
        Me.txt_cili.Name = "txt_cili"
        Me.txt_cili.Size = New System.Drawing.Size(166, 22)
        Me.txt_cili.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ID de Garaje"
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
        Me.Label1.Location = New System.Drawing.Point(448, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID de Moto"
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
        'MotoTableAdapter
        '
        Me.MotoTableAdapter.ClearBeforeFill = True
        '
        'GarajeTableAdapter
        '
        Me.GarajeTableAdapter.ClearBeforeFill = True
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_seleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seleccionar.ForeColor = System.Drawing.Color.White
        Me.btn_seleccionar.Image = CType(resources.GetObject("btn_seleccionar.Image"), System.Drawing.Image)
        Me.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionar.Location = New System.Drawing.Point(806, 11)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(171, 45)
        Me.btn_seleccionar.TabIndex = 36
        Me.btn_seleccionar.Text = "Seleccionar Moto"
        Me.btn_seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionar.UseVisualStyleBackColor = False
        '
        'moto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 611)
        Me.Controls.Add(Me.btn_seleccionar)
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
        Me.Name = "moto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Moto"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tablacliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p_cliente.ResumeLayout(False)
        Me.p_cliente.PerformLayout()
        CType(Me.GarajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alquiler_motosDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents txt_motor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_color As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cili As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Alquiler_motosDataSet2 As Alquiler_motosDataSet2
    Friend WithEvents MotoBindingSource As BindingSource
    Friend WithEvents MotoTableAdapter As Alquiler_motosDataSet2TableAdapters.motoTableAdapter
    Friend WithEvents IdmotoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdcarajeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlacaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CilindrajeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciohoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents cbx_g As ComboBox
    Friend WithEvents cbox_estado As CheckBox
    Friend WithEvents Alquiler_motosDataSet3 As Alquiler_motosDataSet3
    Friend WithEvents GarajeBindingSource As BindingSource
    Friend WithEvents GarajeTableAdapter As Alquiler_motosDataSet3TableAdapters.garajeTableAdapter
    Friend WithEvents txt_filtro As TextBox
    Friend WithEvents cbx_filtro As ComboBox
    Friend WithEvents btn_seleccionar As Button
End Class
