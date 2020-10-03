<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_ImportarFormato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_ImportarFormato))
        Me.DialogoArchivo = New System.Windows.Forms.OpenFileDialog()
        Me.btnImportarPDF = New System.Windows.Forms.Button()
        Me.btnImportarCarpeta = New System.Windows.Forms.Button()
        Me.P_Header = New System.Windows.Forms.Panel()
        Me.txtTitulo = New System.Windows.Forms.Label()
        Me.DialogoCarpeta = New System.Windows.Forms.FolderBrowserDialog()
        Me.P_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'DialogoArchivo
        '
        Me.DialogoArchivo.Filter = "Archivo de Formato|*.nfo"
        Me.DialogoArchivo.Title = "Buscar Formato"
        '
        'btnImportarPDF
        '
        Me.btnImportarPDF.BackgroundImage = Global.AdministradorTicketsBanco.My.Resources.Resources.Archivo
        Me.btnImportarPDF.Location = New System.Drawing.Point(67, 123)
        Me.btnImportarPDF.Name = "btnImportarPDF"
        Me.btnImportarPDF.Size = New System.Drawing.Size(197, 42)
        Me.btnImportarPDF.TabIndex = 8
        Me.btnImportarPDF.Text = "Importar archivo"
        Me.btnImportarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportarPDF.UseVisualStyleBackColor = True
        '
        'btnImportarCarpeta
        '
        Me.btnImportarCarpeta.BackgroundImage = Global.AdministradorTicketsBanco.My.Resources.Resources.Carpeta
        Me.btnImportarCarpeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImportarCarpeta.Location = New System.Drawing.Point(67, 171)
        Me.btnImportarCarpeta.Name = "btnImportarCarpeta"
        Me.btnImportarCarpeta.Size = New System.Drawing.Size(199, 42)
        Me.btnImportarCarpeta.TabIndex = 7
        Me.btnImportarCarpeta.Text = "Importar carpeta"
        Me.btnImportarCarpeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportarCarpeta.UseVisualStyleBackColor = True
        '
        'P_Header
        '
        Me.P_Header.BackgroundImage = Global.AdministradorTicketsBanco.My.Resources.Resources.Textura
        Me.P_Header.Controls.Add(Me.txtTitulo)
        Me.P_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Header.Location = New System.Drawing.Point(0, 0)
        Me.P_Header.Name = "P_Header"
        Me.P_Header.Size = New System.Drawing.Size(331, 95)
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
        Me.txtTitulo.Size = New System.Drawing.Size(331, 95)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.Text = "Importar Formato"
        Me.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DialogoCarpeta
        '
        Me.DialogoCarpeta.Description = "Seleccionar Carpeta"
        Me.DialogoCarpeta.SelectedPath = "D:\Archivos\Mis documentos\Visual Studio 2017\Project\Bancos_AdministradorPDF\Doc" &
    "s\Formatos"
        '
        'GUI_ImportarFormato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 235)
        Me.Controls.Add(Me.btnImportarPDF)
        Me.Controls.Add(Me.btnImportarCarpeta)
        Me.Controls.Add(Me.P_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "GUI_ImportarFormato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Formato"
        Me.P_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_Header As Panel
    Friend WithEvents txtTitulo As Label
    Friend WithEvents btnImportarPDF As Button
    Friend WithEvents btnImportarCarpeta As Button
    Friend WithEvents DialogoArchivo As OpenFileDialog
    Friend WithEvents DialogoCarpeta As FolderBrowserDialog
End Class
