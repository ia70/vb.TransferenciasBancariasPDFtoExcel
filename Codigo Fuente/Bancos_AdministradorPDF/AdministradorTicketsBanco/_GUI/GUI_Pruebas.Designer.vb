<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_Pruebas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Pruebas))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPDF = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.txtFin = New System.Windows.Forms.TextBox()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.txtEliminar = New System.Windows.Forms.TextBox()
        Me.txtInsertar = New System.Windows.Forms.TextBox()
        Me.txtEditar = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(831, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cargar PDF"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtPDF
        '
        Me.txtPDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPDF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPDF.Location = New System.Drawing.Point(0, 56)
        Me.txtPDF.Multiline = True
        Me.txtPDF.Name = "txtPDF"
        Me.txtPDF.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPDF.Size = New System.Drawing.Size(831, 463)
        Me.txtPDF.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 30)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'txtInicio
        '
        Me.txtInicio.Location = New System.Drawing.Point(12, 50)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(123, 20)
        Me.txtInicio.TabIndex = 3
        Me.txtInicio.Text = "1"
        Me.txtInicio.Visible = False
        '
        'txtFin
        '
        Me.txtFin.Location = New System.Drawing.Point(12, 76)
        Me.txtFin.Name = "txtFin"
        Me.txtFin.Size = New System.Drawing.Size(123, 20)
        Me.txtFin.TabIndex = 4
        Me.txtFin.Visible = False
        '
        'Tabla
        '
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Location = New System.Drawing.Point(22, 422)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(113, 82)
        Me.Tabla.TabIndex = 6
        Me.Tabla.Visible = False
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(12, 175)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(123, 31)
        Me.btnInsertar.TabIndex = 7
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        Me.btnInsertar.Visible = False
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(12, 238)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(123, 31)
        Me.btnConsultar.TabIndex = 8
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        Me.btnConsultar.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(12, 296)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(123, 31)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        Me.btnEditar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(12, 359)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(123, 31)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.btnEliminar.Visible = False
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(12, 138)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(123, 31)
        Me.btnCargar.TabIndex = 11
        Me.btnCargar.Text = "Cargar DB"
        Me.btnCargar.UseVisualStyleBackColor = True
        Me.btnCargar.Visible = False
        '
        'txtConsulta
        '
        Me.txtConsulta.Location = New System.Drawing.Point(12, 270)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(123, 20)
        Me.txtConsulta.TabIndex = 12
        Me.txtConsulta.Text = "1002"
        Me.txtConsulta.Visible = False
        '
        'txtEliminar
        '
        Me.txtEliminar.Location = New System.Drawing.Point(12, 396)
        Me.txtEliminar.Name = "txtEliminar"
        Me.txtEliminar.Size = New System.Drawing.Size(123, 20)
        Me.txtEliminar.TabIndex = 13
        Me.txtEliminar.Text = "1001"
        Me.txtEliminar.Visible = False
        '
        'txtInsertar
        '
        Me.txtInsertar.Location = New System.Drawing.Point(12, 212)
        Me.txtInsertar.Name = "txtInsertar"
        Me.txtInsertar.Size = New System.Drawing.Size(123, 20)
        Me.txtInsertar.TabIndex = 14
        Me.txtInsertar.Text = "1001"
        Me.txtInsertar.Visible = False
        '
        'txtEditar
        '
        Me.txtEditar.Location = New System.Drawing.Point(12, 333)
        Me.txtEditar.Name = "txtEditar"
        Me.txtEditar.Size = New System.Drawing.Size(123, 20)
        Me.txtEditar.TabIndex = 15
        Me.txtEditar.Text = "1002"
        Me.txtEditar.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GUI_Pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 519)
        Me.Controls.Add(Me.txtEditar)
        Me.Controls.Add(Me.txtInsertar)
        Me.Controls.Add(Me.txtEliminar)
        Me.Controls.Add(Me.txtConsulta)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.txtFin)
        Me.Controls.Add(Me.txtInicio)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPDF)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "GUI_Pruebas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modo Texto"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtPDF As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtInicio As TextBox
    Friend WithEvents txtFin As TextBox
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents txtConsulta As TextBox
    Friend WithEvents txtEliminar As TextBox
    Friend WithEvents txtInsertar As TextBox
    Friend WithEvents txtEditar As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
