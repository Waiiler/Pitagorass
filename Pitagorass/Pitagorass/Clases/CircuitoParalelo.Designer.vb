<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CircuitoParalelo
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
        Me.txtIT = New System.Windows.Forms.TextBox()
        Me.txtRT = New System.Windows.Forms.TextBox()
        Me.txtR3 = New System.Windows.Forms.TextBox()
        Me.txtR2 = New System.Windows.Forms.TextBox()
        Me.txtR1 = New System.Windows.Forms.TextBox()
        Me.txtVoltaje = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIT
        '
        Me.txtIT.Location = New System.Drawing.Point(104, 161)
        Me.txtIT.Name = "txtIT"
        Me.txtIT.Size = New System.Drawing.Size(100, 20)
        Me.txtIT.TabIndex = 27
        '
        'txtRT
        '
        Me.txtRT.Location = New System.Drawing.Point(104, 126)
        Me.txtRT.Name = "txtRT"
        Me.txtRT.Size = New System.Drawing.Size(100, 20)
        Me.txtRT.TabIndex = 26
        '
        'txtR3
        '
        Me.txtR3.Location = New System.Drawing.Point(57, 81)
        Me.txtR3.Name = "txtR3"
        Me.txtR3.Size = New System.Drawing.Size(100, 20)
        Me.txtR3.TabIndex = 25
        '
        'txtR2
        '
        Me.txtR2.Location = New System.Drawing.Point(57, 59)
        Me.txtR2.Name = "txtR2"
        Me.txtR2.Size = New System.Drawing.Size(100, 20)
        Me.txtR2.TabIndex = 24
        '
        'txtR1
        '
        Me.txtR1.Location = New System.Drawing.Point(57, 32)
        Me.txtR1.Name = "txtR1"
        Me.txtR1.Size = New System.Drawing.Size(100, 20)
        Me.txtR1.TabIndex = 23
        '
        'txtVoltaje
        '
        Me.txtVoltaje.Location = New System.Drawing.Point(57, 9)
        Me.txtVoltaje.Name = "txtVoltaje"
        Me.txtVoltaje.Size = New System.Drawing.Size(100, 20)
        Me.txtVoltaje.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Intensidad Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Resistencia Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "R3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "R2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "R1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Voltaje"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(111, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(15, 226)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 14
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'CircuitoParalelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 261)
        Me.Controls.Add(Me.txtIT)
        Me.Controls.Add(Me.txtRT)
        Me.Controls.Add(Me.txtR3)
        Me.Controls.Add(Me.txtR2)
        Me.Controls.Add(Me.txtR1)
        Me.Controls.Add(Me.txtVoltaje)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "CircuitoParalelo"
        Me.Text = "CircuitoParalelovb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIT As System.Windows.Forms.TextBox
    Friend WithEvents txtRT As System.Windows.Forms.TextBox
    Friend WithEvents txtR3 As System.Windows.Forms.TextBox
    Friend WithEvents txtR2 As System.Windows.Forms.TextBox
    Friend WithEvents txtR1 As System.Windows.Forms.TextBox
    Friend WithEvents txtVoltaje As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
End Class
