<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUI_MostrarErrores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_MostrarErrores))
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_Header = New System.Windows.Forms.Panel()
        Me.btnMoveraCarpeta = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.Label()
        Me.diaCarpeta = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabla
        '
        Me.Tabla.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.Tabla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Tabla.BackgroundColor = System.Drawing.Color.White
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Tabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabla.Location = New System.Drawing.Point(0, 95)
        Me.Tabla.MultiSelect = False
        Me.Tabla.Name = "Tabla"
        Me.Tabla.ReadOnly = True
        Me.Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla.Size = New System.Drawing.Size(743, 389)
        Me.Tabla.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.HeaderText = "No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 64
        '
        'Column2
        '
        Me.Column2.HeaderText = "Archivo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 98
        '
        'Column3
        '
        Me.Column3.HeaderText = "Error"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 77
        '
        'P_Header
        '
        Me.P_Header.BackgroundImage = Global.AdministradorTicketsBanco.My.Resources.Resources.Textura
        Me.P_Header.Controls.Add(Me.btnMoveraCarpeta)
        Me.P_Header.Controls.Add(Me.txtTitulo)
        Me.P_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Header.Location = New System.Drawing.Point(0, 0)
        Me.P_Header.Name = "P_Header"
        Me.P_Header.Size = New System.Drawing.Size(743, 95)
        Me.P_Header.TabIndex = 8
        '
        'btnMoveraCarpeta
        '
        Me.btnMoveraCarpeta.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnMoveraCarpeta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMoveraCarpeta.FlatAppearance.BorderSize = 0
        Me.btnMoveraCarpeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMoveraCarpeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnMoveraCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveraCarpeta.ForeColor = System.Drawing.Color.White
        Me.btnMoveraCarpeta.Location = New System.Drawing.Point(0, 53)
        Me.btnMoveraCarpeta.Name = "btnMoveraCarpeta"
        Me.btnMoveraCarpeta.Size = New System.Drawing.Size(743, 42)
        Me.btnMoveraCarpeta.TabIndex = 1
        Me.btnMoveraCarpeta.Text = "Mover archivos a carpeta"
        Me.btnMoveraCarpeta.UseVisualStyleBackColor = False
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.Transparent
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitulo.Font = New System.Drawing.Font("Arial", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(743, 53)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.Text = "Archivos no importados:"
        Me.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'diaCarpeta
        '
        Me.diaCarpeta.Description = "Seleccionar Carpeta"
        Me.diaCarpeta.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'GUI_MostrarErrores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 484)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.P_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "GUI_MostrarErrores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Archivos no importados"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tabla As DataGridView
    Friend WithEvents P_Header As Panel
    Friend WithEvents txtTitulo As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnMoveraCarpeta As Button
    Friend WithEvents diaCarpeta As FolderBrowserDialog
End Class
