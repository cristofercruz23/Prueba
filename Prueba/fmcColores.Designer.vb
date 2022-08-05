<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmcColores
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
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRojo
        '
        Me.btnRojo.Location = New System.Drawing.Point(81, 35)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(84, 32)
        Me.btnRojo.TabIndex = 0
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(81, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(81, 202)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(81, 294)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 34)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(81, 386)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 33)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(214, 44)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(556, 375)
        Me.txtColores.TabIndex = 5
        Me.txtColores.Text = "txtColores"
        '
        'fmcColores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRojo)
        Me.Name = "fmcColores"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRojo As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents txtColores As TextBox
End Class
