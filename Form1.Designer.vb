<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2NPallet = New System.Windows.Forms.Label()
        Me.Label3NParte = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.btnRegistrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSalir = New Guna.UI2.WinForms.Guna2Button()
        Me.Titulo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtNPallet = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCaptura = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnConfirmarEscaneo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBorrarEscaneo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSalirEscaneo = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSecuenciado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerEscaneo = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2NPallet
        '
        Me.Label2NPallet.AutoSize = True
        Me.Label2NPallet.BackColor = System.Drawing.Color.Transparent
        Me.Label2NPallet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2NPallet.Location = New System.Drawing.Point(424, 352)
        Me.Label2NPallet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2NPallet.Name = "Label2NPallet"
        Me.Label2NPallet.Size = New System.Drawing.Size(190, 25)
        Me.Label2NPallet.TabIndex = 1
        Me.Label2NPallet.Text = "Número de Pallet :"
        '
        'Label3NParte
        '
        Me.Label3NParte.AutoSize = True
        Me.Label3NParte.BackColor = System.Drawing.Color.Transparent
        Me.Label3NParte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3NParte.Location = New System.Drawing.Point(424, 296)
        Me.Label3NParte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3NParte.Name = "Label3NParte"
        Me.Label3NParte.Size = New System.Drawing.Size(187, 25)
        Me.Label3NParte.TabIndex = 2
        Me.Label3NParte.Text = "Número de Parte :"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Animated = True
        Me.btnRegistrar.AutoRoundedCorners = True
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.BorderColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegistrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnRegistrar.FocusedColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegistrar.Image = Global.Prototipe.My.Resources.Resources.caja_boton_registar1
        Me.btnRegistrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRegistrar.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnRegistrar.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnRegistrar.Location = New System.Drawing.Point(764, 458)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.PressedColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.Size = New System.Drawing.Size(230, 49)
        Me.btnRegistrar.TabIndex = 7
        Me.btnRegistrar.Text = "Registar Cajas"
        Me.btnRegistrar.TextFormatNoPrefix = True
        Me.btnRegistrar.TextOffset = New System.Drawing.Point(10, 0)
        '
        'BtnSalir
        '
        Me.BtnSalir.Animated = True
        Me.BtnSalir.AutoRoundedCorners = True
        Me.BtnSalir.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalir.BorderColor = System.Drawing.Color.Transparent
        Me.BtnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSalir.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Image = Global.Prototipe.My.Resources.Resources.salida_boton
        Me.BtnSalir.Location = New System.Drawing.Point(442, 458)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(230, 49)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "Salir"
        '
        'Titulo
        '
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.Location = New System.Drawing.Point(554, 237)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(346, 38)
        Me.Titulo.TabIndex = 9
        Me.Titulo.Text = "REGISTRO DE PALLET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1509, 716)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 10
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.Black
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImage = Global.Prototipe.My.Resources.Resources.Fondo2
        Me.TabPage1.Controls.Add(Me.txtNPallet)
        Me.TabPage1.Controls.Add(Me.txtCaptura)
        Me.TabPage1.Controls.Add(Me.Titulo)
        Me.TabPage1.Controls.Add(Me.Label2NPallet)
        Me.TabPage1.Controls.Add(Me.BtnSalir)
        Me.TabPage1.Controls.Add(Me.Label3NParte)
        Me.TabPage1.Controls.Add(Me.btnRegistrar)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1321, 708)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "REGISTRO DE PALLET"
        '
        'txtNPallet
        '
        Me.txtNPallet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNPallet.DefaultText = ""
        Me.txtNPallet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNPallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNPallet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNPallet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNPallet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNPallet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNPallet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNPallet.Location = New System.Drawing.Point(703, 346)
        Me.txtNPallet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNPallet.Name = "txtNPallet"
        Me.txtNPallet.PlaceholderText = ""
        Me.txtNPallet.SelectedText = ""
        Me.txtNPallet.Size = New System.Drawing.Size(275, 31)
        Me.txtNPallet.TabIndex = 11
        '
        'txtCaptura
        '
        Me.txtCaptura.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCaptura.DefaultText = ""
        Me.txtCaptura.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCaptura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCaptura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCaptura.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCaptura.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCaptura.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCaptura.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCaptura.Location = New System.Drawing.Point(703, 293)
        Me.txtCaptura.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCaptura.Name = "txtCaptura"
        Me.txtCaptura.PlaceholderText = ""
        Me.txtCaptura.SelectedText = ""
        Me.txtCaptura.Size = New System.Drawing.Size(275, 31)
        Me.txtCaptura.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnConfirmarEscaneo)
        Me.TabPage2.Controls.Add(Me.btnBorrarEscaneo)
        Me.TabPage2.Controls.Add(Me.btnSalirEscaneo)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.TabPage2.Controls.Add(Me.txtSecuenciado)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1321, 708)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ESCANEO DE CAJAS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnConfirmarEscaneo
        '
        Me.btnConfirmarEscaneo.Animated = True
        Me.btnConfirmarEscaneo.AutoRoundedCorners = True
        Me.btnConfirmarEscaneo.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirmarEscaneo.BorderColor = System.Drawing.Color.Transparent
        Me.btnConfirmarEscaneo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmarEscaneo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmarEscaneo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirmarEscaneo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirmarEscaneo.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnConfirmarEscaneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarEscaneo.ForeColor = System.Drawing.Color.White
        Me.btnConfirmarEscaneo.Image = Global.Prototipe.My.Resources.Resources.confirmacion_boton1
        Me.btnConfirmarEscaneo.Location = New System.Drawing.Point(794, 531)
        Me.btnConfirmarEscaneo.Name = "btnConfirmarEscaneo"
        Me.btnConfirmarEscaneo.Size = New System.Drawing.Size(230, 49)
        Me.btnConfirmarEscaneo.TabIndex = 17
        Me.btnConfirmarEscaneo.Text = "Confirmar Datos"
        '
        'btnBorrarEscaneo
        '
        Me.btnBorrarEscaneo.Animated = True
        Me.btnBorrarEscaneo.AutoRoundedCorners = True
        Me.btnBorrarEscaneo.BorderColor = System.Drawing.Color.Transparent
        Me.btnBorrarEscaneo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrarEscaneo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrarEscaneo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrarEscaneo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBorrarEscaneo.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnBorrarEscaneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarEscaneo.ForeColor = System.Drawing.Color.White
        Me.btnBorrarEscaneo.Location = New System.Drawing.Point(351, 531)
        Me.btnBorrarEscaneo.Name = "btnBorrarEscaneo"
        Me.btnBorrarEscaneo.Size = New System.Drawing.Size(230, 49)
        Me.btnBorrarEscaneo.TabIndex = 16
        Me.btnBorrarEscaneo.Text = "Borrar"
        '
        'btnSalirEscaneo
        '
        Me.btnSalirEscaneo.Animated = True
        Me.btnSalirEscaneo.AutoRoundedCorners = True
        Me.btnSalirEscaneo.BorderColor = System.Drawing.Color.Transparent
        Me.btnSalirEscaneo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSalirEscaneo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSalirEscaneo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSalirEscaneo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSalirEscaneo.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnSalirEscaneo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalirEscaneo.ForeColor = System.Drawing.Color.White
        Me.btnSalirEscaneo.Image = Global.Prototipe.My.Resources.Resources.salida_boton
        Me.btnSalirEscaneo.Location = New System.Drawing.Point(583, 586)
        Me.btnSalirEscaneo.Name = "btnSalirEscaneo"
        Me.btnSalirEscaneo.Size = New System.Drawing.Size(230, 49)
        Me.btnSalirEscaneo.TabIndex = 15
        Me.btnSalirEscaneo.Text = "Salir"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(351, 218)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(673, 285)
        Me.DataGridView1.TabIndex = 14
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(544, 78)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(330, 38)
        Me.Guna2HtmlLabel1.TabIndex = 13
        Me.Guna2HtmlLabel1.Text = "REGISTRO DE CAJAS"
        '
        'txtSecuenciado
        '
        Me.txtSecuenciado.Location = New System.Drawing.Point(517, 185)
        Me.txtSecuenciado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSecuenciado.Name = "txtSecuenciado"
        Me.txtSecuenciado.Size = New System.Drawing.Size(357, 27)
        Me.txtSecuenciado.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(600, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Codigo de secuenciado"
        '
        'TimerEscaneo
        '
        Me.TimerEscaneo.Interval = 300
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.Prototipe.My.Resources.Resources.Fondo2
        Me.ClientSize = New System.Drawing.Size(1509, 716)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Form1"
        Me.Text = "DATATRACK - KINFO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2NPallet As Label
    Friend WithEvents Label3NParte As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents btnRegistrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Titulo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSecuenciado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnConfirmarEscaneo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBorrarEscaneo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSalirEscaneo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCaptura As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNPallet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TimerEscaneo As Timer
End Class
