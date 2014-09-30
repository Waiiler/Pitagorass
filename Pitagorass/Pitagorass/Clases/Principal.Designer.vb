<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeoremaPitagorasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaCircunferenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircuitoSerieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircuitoParaleloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.OperacionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(325, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeoremaPitagorasToolStripMenuItem, Me.AreaCircunferenciaToolStripMenuItem, Me.CircuitoSerieToolStripMenuItem, Me.CircuitoParaleloToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(99, 24)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'TeoremaPitagorasToolStripMenuItem
        '
        Me.TeoremaPitagorasToolStripMenuItem.Name = "TeoremaPitagorasToolStripMenuItem"
        Me.TeoremaPitagorasToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.TeoremaPitagorasToolStripMenuItem.Text = "Teorema Pitagoras"
        '
        'AreaCircunferenciaToolStripMenuItem
        '
        Me.AreaCircunferenciaToolStripMenuItem.Name = "AreaCircunferenciaToolStripMenuItem"
        Me.AreaCircunferenciaToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.AreaCircunferenciaToolStripMenuItem.Text = "Area Circunferencia"
        '
        'CircuitoSerieToolStripMenuItem
        '
        Me.CircuitoSerieToolStripMenuItem.Name = "CircuitoSerieToolStripMenuItem"
        Me.CircuitoSerieToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.CircuitoSerieToolStripMenuItem.Text = "Circuito Serie"
        '
        'CircuitoParaleloToolStripMenuItem
        '
        Me.CircuitoParaleloToolStripMenuItem.Name = "CircuitoParaleloToolStripMenuItem"
        Me.CircuitoParaleloToolStripMenuItem.Size = New System.Drawing.Size(200, 24)
        Me.CircuitoParaleloToolStripMenuItem.Text = "Circuito Paralelo"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(325, 259)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeoremaPitagorasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AreaCircunferenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CircuitoSerieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CircuitoParaleloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
