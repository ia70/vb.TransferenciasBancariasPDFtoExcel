<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI_EmpresaVincular
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_EmpresaVincular))
        Me.P_Body = New System.Windows.Forms.Panel()
        Me.P_BodyBancos = New System.Windows.Forms.Panel()
        Me.ListaBancos = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAgregarCuenta = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListaVinculo = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.P_Body_Header = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtListaEmpresas = New System.Windows.Forms.ComboBox()
        Me.P_Header = New System.Windows.Forms.Panel()
        Me.txtTitulo = New System.Windows.Forms.Label()
        Me.P_Body.SuspendLayout()
        Me.P_BodyBancos.SuspendLayout()
        CType(Me.ListaBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ListaVinculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_Body_Header.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.P_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Body
        '
        Me.P_Body.AutoScroll = True
        Me.P_Body.BackColor = System.Drawing.Color.WhiteSmoke
        Me.P_Body.Controls.Add(Me.P_BodyBancos)
        Me.P_Body.Controls.Add(Me.Panel2)
        Me.P_Body.Controls.Add(Me.P_Body_Header)
        Me.P_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_Body.Location = New System.Drawing.Point(0, 95)
        Me.P_Body.Name = "P_Body"
        Me.P_Body.Size = New System.Drawing.Size(1019, 567)
        Me.P_Body.TabIndex = 12
        '
        'P_BodyBancos
        '
        Me.P_BodyBancos.Controls.Add(Me.ListaBancos)
        Me.P_BodyBancos.Controls.Add(Me.Panel4)
        Me.P_BodyBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.P_BodyBancos.Location = New System.Drawing.Point(0, 458)
        Me.P_BodyBancos.Name = "P_BodyBancos"
        Me.P_BodyBancos.Size = New System.Drawing.Size(1019, 109)
        Me.P_BodyBancos.TabIndex = 16
        '
        'ListaBancos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.ListaBancos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListaBancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListaBancos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ListaBancos.BackgroundColor = System.Drawing.Color.White
        Me.ListaBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaBancos.Location = New System.Drawing.Point(0, 64)
        Me.ListaBancos.MultiSelect = False
        Me.ListaBancos.Name = "ListaBancos"
        Me.ListaBancos.ReadOnly = True
        Me.ListaBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaBancos.Size = New System.Drawing.Size(1019, 45)
        Me.ListaBancos.TabIndex = 18
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1019, 64)
        Me.Panel4.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(238, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(781, 64)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Todas las cuentas:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnAgregarCuenta)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 64)
        Me.Panel5.TabIndex = 0
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAgregarCuenta.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(6, 10)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(228, 44)
        Me.btnAgregarCuenta.TabIndex = 0
        Me.btnAgregarCuenta.Text = "Agregar seleccionado"
        Me.btnAgregarCuenta.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListaVinculo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 182)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.Panel2.Size = New System.Drawing.Size(1019, 276)
        Me.Panel2.TabIndex = 15
        '
        'ListaVinculo
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        Me.ListaVinculo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ListaVinculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListaVinculo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ListaVinculo.BackgroundColor = System.Drawing.Color.White
        Me.ListaVinculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaVinculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListaVinculo.Location = New System.Drawing.Point(10, 42)
        Me.ListaVinculo.MultiSelect = False
        Me.ListaVinculo.Name = "ListaVinculo"
        Me.ListaVinculo.ReadOnly = True
        Me.ListaVinculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListaVinculo.Size = New System.Drawing.Size(999, 224)
        Me.ListaVinculo.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(999, 42)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cuentas Vinculadas:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P_Body_Header
        '
        Me.P_Body_Header.Controls.Add(Me.Panel1)
        Me.P_Body_Header.Controls.Add(Me.txtEmpresa)
        Me.P_Body_Header.Controls.Add(Me.Label1)
        Me.P_Body_Header.Controls.Add(Me.txtListaEmpresas)
        Me.P_Body_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Body_Header.Location = New System.Drawing.Point(0, 0)
        Me.P_Body_Header.Name = "P_Body_Header"
        Me.P_Body_Header.Padding = New System.Windows.Forms.Padding(10)
        Me.P_Body_Header.Size = New System.Drawing.Size(1019, 182)
        Me.P_Body_Header.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtRFC)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(578, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 104)
        Me.Panel1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 44)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "RFC:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRFC.Location = New System.Drawing.Point(87, 50)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(321, 44)
        Me.txtRFC.TabIndex = 11
        Me.txtRFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BackColor = System.Drawing.Color.SteelBlue
        Me.txtEmpresa.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtEmpresa.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.ForeColor = System.Drawing.Color.White
        Me.txtEmpresa.Location = New System.Drawing.Point(10, 10)
        Me.txtEmpresa.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(999, 58)
        Me.txtEmpresa.TabIndex = 9
        Me.txtEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Location = New System.Drawing.Point(8, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtListaEmpresas
        '
        Me.txtListaEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtListaEmpresas.FormattingEnabled = True
        Me.txtListaEmpresas.Location = New System.Drawing.Point(8, 132)
        Me.txtListaEmpresas.Name = "txtListaEmpresas"
        Me.txtListaEmpresas.Size = New System.Drawing.Size(460, 30)
        Me.txtListaEmpresas.TabIndex = 8
        '
        'P_Header
        '
        Me.P_Header.BackgroundImage = Global.AdministradorTicketsBanco.My.Resources.Resources.Textura
        Me.P_Header.Controls.Add(Me.txtTitulo)
        Me.P_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.P_Header.Location = New System.Drawing.Point(0, 0)
        Me.P_Header.Name = "P_Header"
        Me.P_Header.Size = New System.Drawing.Size(1019, 95)
        Me.P_Header.TabIndex = 11
        '
        'txtTitulo
        '
        Me.txtTitulo.BackColor = System.Drawing.Color.Transparent
        Me.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTitulo.Font = New System.Drawing.Font("Arial", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.ForeColor = System.Drawing.Color.White
        Me.txtTitulo.Location = New System.Drawing.Point(0, 0)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(1019, 95)
        Me.txtTitulo.TabIndex = 0
        Me.txtTitulo.Text = "Vincular cuentas"
        Me.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GUI_EmpresaVincular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 662)
        Me.Controls.Add(Me.P_Body)
        Me.Controls.Add(Me.P_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "GUI_EmpresaVincular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vincular cuentas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.P_Body.ResumeLayout(False)
        Me.P_BodyBancos.ResumeLayout(False)
        CType(Me.ListaBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ListaVinculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_Body_Header.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.P_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents P_Body As Panel
    Friend WithEvents txtListaEmpresas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents P_Header As Panel
    Friend WithEvents txtTitulo As Label
    Friend WithEvents txtEmpresa As Label
    Friend WithEvents txtRFC As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents P_Body_Header As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ListaVinculo As DataGridView
    Friend WithEvents P_BodyBancos As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListaBancos As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnAgregarCuenta As Button
End Class
