<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.cbxMostrarContra = New System.Windows.Forms.CheckBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbPorcentaje = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(317, 203)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(164, 34)
        Me.btnIngresar.TabIndex = 14
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'cbxMostrarContra
        '
        Me.cbxMostrarContra.AutoSize = True
        Me.cbxMostrarContra.BackColor = System.Drawing.Color.Transparent
        Me.cbxMostrarContra.BackgroundImage = CType(resources.GetObject("cbxMostrarContra.BackgroundImage"), System.Drawing.Image)
        Me.cbxMostrarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cbxMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxMostrarContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMostrarContra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxMostrarContra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbxMostrarContra.Location = New System.Drawing.Point(507, 157)
        Me.cbxMostrarContra.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxMostrarContra.Name = "cbxMostrarContra"
        Me.cbxMostrarContra.Size = New System.Drawing.Size(47, 17)
        Me.cbxMostrarContra.TabIndex = 13
        Me.cbxMostrarContra.Text = "      "
        Me.cbxMostrarContra.UseVisualStyleBackColor = False
        '
        'txtContrasena
        '
        Me.txtContrasena.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContrasena.BackColor = System.Drawing.SystemColors.Control
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasena.Location = New System.Drawing.Point(2, 2)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContrasena.Multiline = True
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(199, 29)
        Me.txtContrasena.TabIndex = 12
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(2, 2)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreEmpleado.Multiline = True
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(201, 25)
        Me.txtNombreEmpleado.TabIndex = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(244, 321)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(326, 30)
        Me.ProgressBar1.TabIndex = 16
        '
        'Timer1
        '
        '
        'LbPorcentaje
        '
        Me.LbPorcentaje.AutoSize = True
        Me.LbPorcentaje.BackColor = System.Drawing.Color.Transparent
        Me.LbPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPorcentaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbPorcentaje.Location = New System.Drawing.Point(210, 330)
        Me.LbPorcentaje.Name = "LbPorcentaje"
        Me.LbPorcentaje.Size = New System.Drawing.Size(27, 13)
        Me.LbPorcentaje.TabIndex = 17
        Me.LbPorcentaje.Text = "0 %"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.BazarRoxana.My.Resources.Resources.Usuarios1
        Me.PictureBox1.Location = New System.Drawing.Point(357, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 385)
        Me.Panel1.TabIndex = 18
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = Global.BazarRoxana.My.Resources.Resources.Logo
        Me.PictureBox4.Location = New System.Drawing.Point(2, 105)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(197, 114)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 71
        Me.PictureBox4.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.DimGray
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.DimGray
        Me.btnSalir.Location = New System.Drawing.Point(536, 12)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 31)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(244, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(244, 146)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtContrasena)
        Me.Panel3.Location = New System.Drawing.Point(297, 143)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(205, 40)
        Me.Panel3.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtNombreEmpleado)
        Me.Panel2.Location = New System.Drawing.Point(297, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 40)
        Me.Panel2.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(241, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Cargando..."
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(579, 387)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LbPorcentaje)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.cbxMostrarContra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIngresar As Button
    Friend WithEvents cbxMostrarContra As CheckBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LbPorcentaje As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ErrorValidacion As ErrorProvider
End Class
