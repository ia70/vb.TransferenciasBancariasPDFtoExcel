<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_ImportarPDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_ImportarPDF))
        Me.P_Header = New System.Windows.Forms.Panel()
        Me.txtTitulo = New System.Windows.Forms.Label()
        Me.P_Body = New System.Windows.Forms.Panel()
        Me.P_Body2 = New System.Windows.Forms.Panel()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_Header2 = New System.Windows.Forms.Panel()
        Me.btnImportarPDF = New System.Windows.Forms.Button()
        Me.btnImportarCarpeta = New System.Windows.Forms.Button()
        Me.DialogoArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.DialogoCarpeta = New System.Windows.Forms.FolderBrowserDialog()
        Me.P_Header.SuspendLayout()
        Me.P_Body.SuspendLayout()
        Me.P_Body2.SuspendLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_Header2.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Header
        '
        Me.P_Header.BackgroundImage = Global.AdministradorTicketsBanco.My.Resources.Resources.Textura
        Me.P_Header.Controls.Add(Me.txtTitulo)
        Me.P_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Header.Location = New System.Drawing.Point(0, 0)
        Me.P_Header.Name = "P_Header"
        Me.P_Header.Size = New System.Drawing.Size(275, 95)
        Me.P_Header.TabIndex = 3
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.Transparent
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTitulo.Font = New System.Drawing.Font("Arial", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(275, 95)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.Text = "Importar PDF"
        Me.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_Body
        '
        Me.P_Body.Controls.Add(Me.P_Body2)
        Me.P_Body.Controls.Add(Me.P_Header2)
        Me.P_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Body.Location = New System.Drawing.Point(0, 95)
        Me.P_Body.Name = "P_Body"
        Me.P_Body.Size = New System.Drawing.Size(275, 128)
        Me.P_Body.TabIndex = 6
        '
        'P_Body2
        '
        Me.P_Body2.Controls.Add(Me.Tabla)
        Me.P_Body2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Body2.Location = New System.Drawing.Point(0, 133)
        Me.P_Body2.Name = "P_Body2"
        Me.P_Body2.Size = New System.Drawing.Size(275, 0)
        Me.P_Body2.TabIndex = 1
        '
        'Tabla
        '
        Me.Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Tabla.BackgroundColor = System.Drawing.Color.White
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.Tabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Tabla.Location = New System.Drawing.Point(0, 0)
        Me.Tabla.MultiSelect = False
        Me.Tabla.Name = "Tabla"
        Me.Tabla.ReadOnly = True
        Me.Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Tabla.ShowCellErrors = False
        Me.Tabla.ShowCellToolTips = False
        Me.Tabla.ShowEditingIcon = False
        Me.Tabla.ShowRowErrors = False
        Me.Tabla.Size = New System.Drawing.Size(275, 0)
        Me.Tabla.TabIndex = 1
        Me.Tabla.Visible = False
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
        Me.Column2.HeaderText = "Rastreo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 102
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cuenta Origen"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 143
        '
        'Column4
        '
        Me.Column4.HeaderText = "RFC Origen"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cuenta Destino"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "RFC Destino"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 132
        '
        'Column7
        '
        Me.Column7.HeaderText = "Registros Transmitidos"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 209
        '
        'Column8
        '
        Me.Column8.HeaderText = "Moneda"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 103
        '
        'Column9
        '
        Me.Column9.HeaderText = "Referencia"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 128
        '
        'Column10
        '
        Me.Column10.HeaderText = "Fólio Internet"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 133
        '
        'Column11
        '
        Me.Column11.HeaderText = "Importe"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 101
        '
        'Column12
        '
        Me.Column12.HeaderText = "Fecha"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 88
        '
        'P_Header2
        '
        Me.P_Header2.Controls.Add(Me.btnImportarPDF)
        Me.P_Header2.Controls.Add(Me.btnImportarCarpeta)
        Me.P_Header2.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Header2.Location = New System.Drawing.Point(0, 0)
        Me.P_Header2.Name = "P_Header2"
        Me.P_Header2.Size = New System.Drawing.Size(275, 133)
        Me.P_Header2.TabIndex = 0
        '
        'btnImportarPDF
        '
        Me.btnImportarPDF.BackgroundImage = Global.AdministradorTicketsBanco.My.Resources.Resources.PDF1
        Me.btnImportarPDF.Location = New System.Drawing.Point(37, 22)
        Me.btnImportarPDF.Name = "btnImportarPDF"
        Me.btnImportarPDF.Size = New System.Drawing.Size(199, 38)
        Me.btnImportarPDF.TabIndex = 6
        Me.btnImportarPDF.Text = "Importar un PDF"
        Me.btnImportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportarPDF.UseVisualStyleBackColor = True
        '
        'btnImportarCarpeta
        '
        Me.btnImportarCarpeta.BackgroundImage = Global.AdministradorTicketsBanco.My.Resources.Resources.Carpeta
        Me.btnImportarCarpeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImportarCarpeta.Location = New System.Drawing.Point(37, 66)
        Me.btnImportarCarpeta.Name = "btnImportarCarpeta"
        Me.btnImportarCarpeta.Size = New System.Drawing.Size(199, 38)
        Me.btnImportarCarpeta.TabIndex = 5
        Me.btnImportarCarpeta.Text = "Importar carpeta"
        Me.btnImportarCarpeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportarCarpeta.UseVisualStyleBackColor = True
        '
        'DialogoArchivo
        '
        Me.DialogoArchivo.Filter = "Archivo de Formato|*.pdf"
        Me.DialogoArchivo.Title = "Buscar Reporte bancario PDF"
        '
        'DialogoCarpeta
        '
        Me.DialogoCarpeta.Description = "Carpeta de reportes bancarios:"
        Me.DialogoCarpeta.SelectedPath = "D:\Archivos\Mis documentos\Visual Studio 2017\Project\Bancos_AdministradorPDF\Doc" &
    "s\Formatos"
        '
        'GUI_ImportarPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 223)
        Me.Controls.Add(Me.P_Body)
        Me.Controls.Add(Me.P_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "GUI_ImportarPDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar PDF"
        Me.P_Header.ResumeLayout(False)
        Me.P_Body.ResumeLayout(False)
        Me.P_Body2.ResumeLayout(False)
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_Header2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_Header As Panel
    Friend WithEvents txtTitulo As Label
    Friend WithEvents P_Body As Panel
    Friend WithEvents P_Body2 As Panel
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents P_Header2 As Panel
    Friend WithEvents btnImportarPDF As Button
    Friend WithEvents btnImportarCarpeta As Button
    Friend WithEvents DialogoArchivo As OpenFileDialog
    Friend WithEvents DialogoCarpeta As FolderBrowserDialog
End Class
