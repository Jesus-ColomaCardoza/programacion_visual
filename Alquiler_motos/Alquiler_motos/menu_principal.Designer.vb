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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MotosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GarajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesDePagoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprobantesDePagoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MantenimientoToolStripMenuItem, Me.GestiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 20)
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrabajadorToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.MotosToolStripMenuItem, Me.AgenciasToolStripMenuItem, Me.GarajesToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprobantesDePagoToolStripMenuItem, Me.ComprobantesDePagoToolStripMenuItem1, Me.ComprobantesDePagoToolStripMenuItem2})
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'TrabajadorToolStripMenuItem
        '
        Me.TrabajadorToolStripMenuItem.Name = "TrabajadorToolStripMenuItem"
        Me.TrabajadorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TrabajadorToolStripMenuItem.Text = "Trabajador"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClienteToolStripMenuItem.Text = "Clientes"
        '
        'MotosToolStripMenuItem
        '
        Me.MotosToolStripMenuItem.Name = "MotosToolStripMenuItem"
        Me.MotosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MotosToolStripMenuItem.Text = "Motos"
        '
        'AgenciasToolStripMenuItem
        '
        Me.AgenciasToolStripMenuItem.Name = "AgenciasToolStripMenuItem"
        Me.AgenciasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgenciasToolStripMenuItem.Text = "Agencias"
        '
        'GarajesToolStripMenuItem
        '
        Me.GarajesToolStripMenuItem.Name = "GarajesToolStripMenuItem"
        Me.GarajesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GarajesToolStripMenuItem.Text = "Garajes"
        '
        'ComprobantesDePagoToolStripMenuItem
        '
        Me.ComprobantesDePagoToolStripMenuItem.Name = "ComprobantesDePagoToolStripMenuItem"
        Me.ComprobantesDePagoToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ComprobantesDePagoToolStripMenuItem.Text = "Reservas"
        '
        'ComprobantesDePagoToolStripMenuItem1
        '
        Me.ComprobantesDePagoToolStripMenuItem1.Name = "ComprobantesDePagoToolStripMenuItem1"
        Me.ComprobantesDePagoToolStripMenuItem1.Size = New System.Drawing.Size(199, 22)
        Me.ComprobantesDePagoToolStripMenuItem1.Text = "Detalle de reservas"
        '
        'ComprobantesDePagoToolStripMenuItem2
        '
        Me.ComprobantesDePagoToolStripMenuItem2.Name = "ComprobantesDePagoToolStripMenuItem2"
        Me.ComprobantesDePagoToolStripMenuItem2.Size = New System.Drawing.Size(199, 22)
        Me.ComprobantesDePagoToolStripMenuItem2.Text = "Comprobantes de pago"
        '
        'menu_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 476)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
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
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MotosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GarajesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobantesDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprobantesDePagoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ComprobantesDePagoToolStripMenuItem2 As ToolStripMenuItem
End Class
