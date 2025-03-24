<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSecuenciado = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.btnSalir = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNpallet = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2AnimateWindow3 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(235, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo de secuenciado"
        '
        'txtSecuenciado
        '
        Me.txtSecuenciado.Location = New System.Drawing.Point(509, 147)
        Me.txtSecuenciado.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSecuenciado.Name = "txtSecuenciado"
        Me.txtSecuenciado.Size = New System.Drawing.Size(357, 32)
        Me.txtSecuenciado.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(60, 216)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(992, 285)
        Me.DataGridView1.TabIndex = 6
        '
        'btnSalir
        '
        Me.btnSalir.Animated = True
        Me.btnSalir.AutoRoundedCorners = True
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BorderColor = System.Drawing.Color.Transparent
        Me.btnSalir.BorderRadius = 23
        Me.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSalir.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.Prototipe.My.Resources.Resources.salida_boton
        Me.btnSalir.Location = New System.Drawing.Point(636, 663)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.PressedColor = System.Drawing.Color.Transparent
        Me.btnSalir.Size = New System.Drawing.Size(230, 49)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'btnNpallet
        '
        Me.btnNpallet.Animated = True
        Me.btnNpallet.AutoRoundedCorners = True
        Me.btnNpallet.BackColor = System.Drawing.Color.Transparent
        Me.btnNpallet.BorderColor = System.Drawing.Color.Transparent
        Me.btnNpallet.BorderRadius = 23
        Me.btnNpallet.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNpallet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNpallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNpallet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNpallet.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnNpallet.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNpallet.ForeColor = System.Drawing.Color.White
        Me.btnNpallet.Location = New System.Drawing.Point(197, 663)
        Me.btnNpallet.Name = "btnNpallet"
        Me.btnNpallet.Size = New System.Drawing.Size(242, 49)
        Me.btnNpallet.TabIndex = 8
        Me.btnNpallet.Text = "Borrar"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.Prototipe.My.Resources.Resources.confirmacion_boton
        Me.Guna2Button1.Location = New System.Drawing.Point(623, 563)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(230, 49)
        Me.Guna2Button1.TabIndex = 9
        Me.Guna2Button1.Text = "Confirmar Datos"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(386, 41)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(290, 39)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "REGISTRO DE CAJAS"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Prototipe.My.Resources.Resources.Fondo2
        Me.ClientSize = New System.Drawing.Size(1122, 750)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnNpallet)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSecuenciado)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form2"
        Me.Text = "Registro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecuenciado As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Guna2DataGridViewStyler1 As Guna.UI2.WinForms.Guna2DataGridViewStyler
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents btnSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNpallet As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2AnimateWindow3 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
