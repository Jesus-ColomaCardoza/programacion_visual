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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detalle_reserva))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_idreserva = New System.Windows.Forms.Label()
        Me.dtp_inicio = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fin = New System.Windows.Forms.DateTimePicker()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_elegirmoto = New System.Windows.Forms.Button()
        Me.lbl_idmoto = New System.Windows.Forms.Label()
        Me.h_inicio = New System.Windows.Forms.NumericUpDown()
        Me.h_fin = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.h_inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.h_fin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID  de Reserva"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID de Moto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Fin"
        '
        'lbl_idreserva
        '
        Me.lbl_idreserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_idreserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idreserva.Location = New System.Drawing.Point(191, 44)
        Me.lbl_idreserva.Name = "lbl_idreserva"
        Me.lbl_idreserva.Size = New System.Drawing.Size(194, 31)
        Me.lbl_idreserva.TabIndex = 4
        Me.lbl_idreserva.Text = "r001"
        Me.lbl_idreserva.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtp_inicio
        '
        Me.dtp_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_inicio.Location = New System.Drawing.Point(185, 205)
        Me.dtp_inicio.Name = "dtp_inicio"
        Me.dtp_inicio.Size = New System.Drawing.Size(200, 26)
        Me.dtp_inicio.TabIndex = 6
        '
        'dtp_fin
        '
        Me.dtp_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fin.Location = New System.Drawing.Point(185, 265)
        Me.dtp_fin.Name = "dtp_fin"
        Me.dtp_fin.Size = New System.Drawing.Size(200, 26)
        Me.dtp_fin.TabIndex = 7
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(279, 461)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(120, 44)
        Me.btn_cancelar.TabIndex = 9
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_aceptar
        '
        Me.btn_aceptar.BackColor = System.Drawing.Color.Green
        Me.btn_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.ForeColor = System.Drawing.Color.White
        Me.btn_aceptar.Location = New System.Drawing.Point(76, 461)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(120, 44)
        Me.btn_aceptar.TabIndex = 8
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = False
        '
        'btn_elegirmoto
        '
        Me.btn_elegirmoto.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_elegirmoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_elegirmoto.ForeColor = System.Drawing.Color.White
        Me.btn_elegirmoto.Image = CType(resources.GetObject("btn_elegirmoto.Image"), System.Drawing.Image)
        Me.btn_elegirmoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_elegirmoto.Location = New System.Drawing.Point(391, 104)
        Me.btn_elegirmoto.Name = "btn_elegirmoto"
        Me.btn_elegirmoto.Size = New System.Drawing.Size(132, 45)
        Me.btn_elegirmoto.TabIndex = 10
        Me.btn_elegirmoto.Text = "Elegir Moto"
        Me.btn_elegirmoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_elegirmoto.UseVisualStyleBackColor = False
        '
        'lbl_idmoto
        '
        Me.lbl_idmoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_idmoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idmoto.Location = New System.Drawing.Point(191, 112)
        Me.lbl_idmoto.Name = "lbl_idmoto"
        Me.lbl_idmoto.Size = New System.Drawing.Size(194, 31)
        Me.lbl_idmoto.TabIndex = 11
        Me.lbl_idmoto.Text = "m001"
        Me.lbl_idmoto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'h_inicio
        '
        Me.h_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h_inicio.Location = New System.Drawing.Point(403, 205)
        Me.h_inicio.Name = "h_inicio"
        Me.h_inicio.Size = New System.Drawing.Size(54, 26)
        Me.h_inicio.TabIndex = 12
        Me.h_inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.h_inicio.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'h_fin
        '
        Me.h_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h_fin.Location = New System.Drawing.Point(403, 265)
        Me.h_fin.Name = "h_fin"
        Me.h_fin.Size = New System.Drawing.Size(54, 26)
        Me.h_fin.TabIndex = 13
        Me.h_fin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.h_fin.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(451, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 35)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(451, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 35)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = ":"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(469, 205)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(54, 26)
        Me.NumericUpDown1.TabIndex = 16
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(469, 266)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(54, 26)
        Me.NumericUpDown2.TabIndex = 17
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(406, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Hora"
        '
        'detalle_reserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 535)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.h_fin)
        Me.Controls.Add(Me.h_inicio)
        Me.Controls.Add(Me.lbl_idmoto)
        Me.Controls.Add(Me.btn_elegirmoto)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.dtp_fin)
        Me.Controls.Add(Me.dtp_inicio)
        Me.Controls.Add(Me.lbl_idreserva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "detalle_reserva"
        Me.Text = "Detalle Reserva"
        CType(Me.h_inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.h_fin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_idreserva As Label
    Friend WithEvents dtp_inicio As DateTimePicker
    Friend WithEvents dtp_fin As DateTimePicker
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_elegirmoto As Button
    Friend WithEvents lbl_idmoto As Label
    Friend WithEvents h_inicio As NumericUpDown
    Friend WithEvents h_fin As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label7 As Label
End Class
