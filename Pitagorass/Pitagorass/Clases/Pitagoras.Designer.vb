<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pitagoras
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
        Me.txtHipotenusa = New System.Windows.Forms.TextBox()
        Me.txtCB = New System.Windows.Forms.TextBox()
        Me.txtCA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHipotenusa
        '
        Me.txtHipotenusa.Location = New System.Drawing.Point(66, 95)
        Me.txtHipotenusa.Name = "txtHipotenusa"
        Me.txtHipotenusa.Size = New System.Drawing.Size(100, 20)
        Me.txtHipotenusa.TabIndex = 15
        '
        'txtCB
        '
        Me.txtCB.Location = New System.Drawing.Point(66, 45)
        Me.txtCB.Name = "txtCB"
        Me.txtCB.Size = New System.Drawing.Size(100, 20)
        Me.txtCB.TabIndex = 14
        '
        'txtCA
        '
        Me.txtCA.Location = New System.Drawing.Point(66, 9)
        Me.txtCA.Name = "txtCA"
        Me.txtCA.Size = New System.Drawing.Size(100, 20)
        Me.txtCA.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-2, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hipotenusa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cateto B"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cateto A"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(108, 142)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(15, 142)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Pitagoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(218, 182)
        Me.Controls.Add(Me.txtHipotenusa)
        Me.Controls.Add(Me.txtCB)
        Me.Controls.Add(Me.txtCA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalcular)
        Me.Name = "Pitagoras"
        Me.Text = "Pitagoras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHipotenusa As System.Windows.Forms.TextBox
    Friend WithEvents txtCB As System.Windows.Forms.TextBox
    Friend WithEvents txtCA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
End Class
