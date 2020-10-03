<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_EmpresaAgregar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_EmpresaAgregar))
        Me.P_Header = New System.Windows.Forms.Panel()
        Me.txtTitulo = New System.Windows.Forms.Label()
        Me.P_Body = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRazonsocial = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.P_Header.SuspendLayout()
        Me.P_Body.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Header
        '
        Me.P_Header.BackgroundImage = Global.AdministradorTicketsBanco.My.Resources.Resources.Textura
        Me.P_Header.Controls.Add(Me.txtTitulo)
        Me.P_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Header.Location = New System.Drawing.Point(0, 0)
        Me.P_Header.Name = "P_Header"
        Me.P_Header.Size = New System.Drawing.Size(521, 95)
        Me.P_Header.TabIndex = 7
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.Transparent
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTitulo.Font = New System.Drawing.Font("Arial", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(521, 95)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.Text = "Agregar Empresa"
        Me.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_Body
        '
        Me.P_Body.BackColor = System.Drawing.Color.WhiteSmoke
        Me.P_Body.Controls.Add(Me.btnLimpiar)
        Me.P_Body.Controls.Add(Me.btnAgregar)
        Me.P_Body.Controls.Add(Me.txtDescripcion)
        Me.P_Body.Controls.Add(Me.Label3)
        Me.P_Body.Controls.Add(Me.txtRFC)
        Me.P_Body.Controls.Add(Me.Label2)
        Me.P_Body.Controls.Add(Me.txtRazonsocial)
        Me.P_Body.Controls.Add(Me.Label1)
        Me.P_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Body.Location = New System.Drawing.Point(0, 95)
        Me.P_Body.Name = "P_Body"
        Me.P_Body.Size = New System.Drawing.Size(521, 409)
        Me.P_Body.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(33, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Razon social"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRazonsocial
        '
        Me.txtRazonsocial.Location = New System.Drawing.Point(33, 74)
        Me.txtRazonsocial.Name = "txtRazonsocial"
        Me.txtRazonsocial.Size = New System.Drawing.Size(460, 29)
        Me.txtRazonsocial.TabIndex = 1
        Me.txtRazonsocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(33, 169)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(460, 29)
        Me.txtRFC.TabIndex = 3
        Me.txtRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Location = New System.Drawing.Point(33, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(459, 44)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RFC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(34, 263)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescripcion.Size = New System.Drawing.Size(460, 71)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Location = New System.Drawing.Point(34, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(459, 44)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(386, 358)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(106, 35)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Gold
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(261, 358)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(106, 35)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'GUI_EmpresaAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 504)
        Me.Controls.Add(Me.P_Body)
        Me.Controls.Add(Me.P_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "GUI_EmpresaAgregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Empresa"
        Me.P_Header.ResumeLayout(False)
        Me.P_Body.ResumeLayout(False)
        Me.P_Body.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_Header As Panel
    Friend WithEvents txtTitulo As Label
    Friend WithEvents P_Body As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRazonsocial As TextBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
End Class
