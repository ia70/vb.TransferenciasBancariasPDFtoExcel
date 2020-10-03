<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pruebas
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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt0 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(12, 86)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(398, 20)
        Me.txt1.TabIndex = 0
        Me.txt1.Text = "CIBanco S.A. Institución de Banca Múltiple"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(12, 112)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(398, 20)
        Me.txt2.TabIndex = 2
        '
        'txt0
        '
        Me.txt0.Location = New System.Drawing.Point(217, 44)
        Me.txt0.Name = "txt0"
        Me.txt0.Size = New System.Drawing.Size(59, 20)
        Me.txt0.TabIndex = 3
        Me.txt0.Text = "32"
        '
        'Pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 335)
        Me.Controls.Add(Me.txt0)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Pruebas"
        Me.Text = "Pruebas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt0 As TextBox
End Class
