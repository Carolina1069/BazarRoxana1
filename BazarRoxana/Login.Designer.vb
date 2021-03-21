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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.cbxMostrarContra = New System.Windows.Forms.CheckBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbPorcentaje = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(525, 454)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 26)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(253, 314)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(125, 26)
        Me.btnIngresar.TabIndex = 14
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'cbxMostrarContra
        '
        Me.cbxMostrarContra.AutoSize = True
        Me.cbxMostrarContra.Location = New System.Drawing.Point(253, 292)
        Me.cbxMostrarContra.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxMostrarContra.Name = "cbxMostrarContra"
        Me.cbxMostrarContra.Size = New System.Drawing.Size(114, 17)
        Me.cbxMostrarContra.TabIndex = 13
        Me.cbxMostrarContra.Text = "Mostrar contaseña"
        Me.cbxMostrarContra.UseVisualStyleBackColor = True
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(253, 236)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(2)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(126, 20)
        Me.txtContrasena.TabIndex = 12
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 240)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Contraseña"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(253, 204)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(126, 20)
        Me.txtNombreEmpleado.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 206)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre de empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(253, 60)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 80)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(204, 406)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(231, 30)
        Me.ProgressBar1.TabIndex = 16
        '
        'Timer1
        '
        '
        'LbPorcentaje
        '
        Me.LbPorcentaje.AutoSize = True
        Me.LbPorcentaje.BackColor = System.Drawing.Color.Transparent
        Me.LbPorcentaje.Location = New System.Drawing.Point(311, 414)
        Me.LbPorcentaje.Name = "LbPorcentaje"
        Me.LbPorcentaje.Size = New System.Drawing.Size(24, 13)
        Me.LbPorcentaje.TabIndex = 17
        Me.LbPorcentaje.Text = "0 %"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 488)
        Me.Controls.Add(Me.LbPorcentaje)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.cbxMostrarContra)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents cbxMostrarContra As CheckBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LbPorcentaje As Label
End Class
