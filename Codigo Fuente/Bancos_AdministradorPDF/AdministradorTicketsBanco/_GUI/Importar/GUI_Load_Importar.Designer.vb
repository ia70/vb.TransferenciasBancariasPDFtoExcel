﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Load_Importar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Load_Importar))
        Me.txtRestantes = New System.Windows.Forms.Label()
        Me.txtImportados = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.txtProgreso = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtRestantes
        '
        Me.txtRestantes.Location = New System.Drawing.Point(147, 71)
        Me.txtRestantes.Name = "txtRestantes"
        Me.txtRestantes.Size = New System.Drawing.Size(123, 23)
        Me.txtRestantes.TabIndex = 15
        Me.txtRestantes.Text = "."
        Me.txtRestantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtImportados
        '
        Me.txtImportados.Location = New System.Drawing.Point(147, 43)
        Me.txtImportados.Name = "txtImportados"
        Me.txtImportados.Size = New System.Drawing.Size(123, 23)
        Me.txtImportados.TabIndex = 14
        Me.txtImportados.Text = "."
        Me.txtImportados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(147, 15)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(123, 23)
        Me.txtTotal.TabIndex = 13
        Me.txtTotal.Text = "."
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCerrar
        '
        Me.btnCerrar.Enabled = False
        Me.btnCerrar.Location = New System.Drawing.Point(373, 150)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(101, 36)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtProgreso
        '
        Me.txtProgreso.Location = New System.Drawing.Point(16, 115)
        Me.txtProgreso.Name = "txtProgreso"
        Me.txtProgreso.Size = New System.Drawing.Size(459, 33)
        Me.txtProgreso.Step = 1
        Me.txtProgreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.txtProgreso.TabIndex = 11
        Me.txtProgreso.Value = 15
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 28)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Restantes:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 28)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Importados:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total archivos:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GUI_Load_Importar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 198)
        Me.Controls.Add(Me.txtRestantes)
        Me.Controls.Add(Me.txtImportados)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtProgreso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "GUI_Load_Importar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importando..."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtRestantes As Label
    Friend WithEvents txtImportados As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtProgreso As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
