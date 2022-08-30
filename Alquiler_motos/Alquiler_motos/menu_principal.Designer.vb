<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GarajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleReservaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesDePagoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeComprobanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.GestiónToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrabajadorToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.MotosToolStripMenuItem, Me.AgenciasToolStripMenuItem, Me.GarajesToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Image = CType(resources.GetObject("MantenimientoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(123, 21)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'TrabajadorToolStripMenuItem
        '
        Me.TrabajadorToolStripMenuItem.Name = "TrabajadorToolStripMenuItem"
        Me.TrabajadorToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TrabajadorToolStripMenuItem.Text = "Trabajador"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ClienteToolStripMenuItem.Text = "Clientes"
        '
        'MotosToolStripMenuItem
        '
        Me.MotosToolStripMenuItem.Name = "MotosToolStripMenuItem"
        Me.MotosToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.MotosToolStripMenuItem.Text = "Motos"
        '
        'AgenciasToolStripMenuItem
        '
        Me.AgenciasToolStripMenuItem.Name = "AgenciasToolStripMenuItem"
        Me.AgenciasToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.AgenciasToolStripMenuItem.Text = "Agencias"
        '
        'GarajesToolStripMenuItem
        '
        Me.GarajesToolStripMenuItem.Name = "GarajesToolStripMenuItem"
        Me.GarajesToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.GarajesToolStripMenuItem.Text = "Garajes"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservaToolStripMenuItem, Me.DetalleReservaToolStripMenuItem1, Me.ComprobantesDePagoToolStripMenuItem2})
        Me.GestiónToolStripMenuItem.Image = CType(resources.GetObject("GestiónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(80, 21)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'ReservaToolStripMenuItem
        '
        Me.ReservaToolStripMenuItem.Name = "ReservaToolStripMenuItem"
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ReservaToolStripMenuItem.Text = "Reservas"
        '
        'DetalleReservaToolStripMenuItem1
        '
        Me.DetalleReservaToolStripMenuItem1.Name = "DetalleReservaToolStripMenuItem1"
        Me.DetalleReservaToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
        Me.DetalleReservaToolStripMenuItem1.Text = "Detalle de Reserva"
        '
        'ComprobantesDePagoToolStripMenuItem2
        '
        Me.ComprobantesDePagoToolStripMenuItem2.Name = "ComprobantesDePagoToolStripMenuItem2"
        Me.ComprobantesDePagoToolStripMenuItem2.Size = New System.Drawing.Size(217, 22)
        Me.ComprobantesDePagoToolStripMenuItem2.Text = "Comprobantes de pago"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Image = CType(resources.GetObject("ConsultasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(159, 21)
        Me.ConsultasToolStripMenuItem.Text = "Consultas y Reportes"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.TiposDeClienteToolStripMenuItem, Me.TiposDeComprobanteToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(94, 21)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'TiposDeClienteToolStripMenuItem
        '
        Me.TiposDeClienteToolStripMenuItem.Name = "TiposDeClienteToolStripMenuItem"
        Me.TiposDeClienteToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.TiposDeClienteToolStripMenuItem.Text = "Tipos de cliente"
        '
        'TiposDeComprobanteToolStripMenuItem
        '
        Me.TiposDeComprobanteToolStripMenuItem.Name = "TiposDeComprobanteToolStripMenuItem"
        Me.TiposDeComprobanteToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.TiposDeComprobanteToolStripMenuItem.Text = "Tipos de comprobante"
        '
        'menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 476)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "menu_principal"
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MotosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GarajesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetalleReservaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ComprobantesDePagoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeComprobanteToolStripMenuItem As ToolStripMenuItem
End Class
