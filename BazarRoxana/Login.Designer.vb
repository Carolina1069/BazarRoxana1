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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.cbxMostrarContra = New System.Windows.Forms.CheckBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(700, 559)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(121, 32)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(337, 386)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(167, 32)
        Me.btnIngresar.TabIndex = 14
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'cbxMostrarContra
        '
        Me.cbxMostrarContra.AutoSize = True
        Me.cbxMostrarContra.Location = New System.Drawing.Point(337, 359)
        Me.cbxMostrarContra.Name = "cbxMostrarContra"
        Me.cbxMostrarContra.Size = New System.Drawing.Size(148, 21)
        Me.cbxMostrarContra.TabIndex = 13
        Me.cbxMostrarContra.Text = "Mostrar contaseña"
        Me.cbxMostrarContra.UseVisualStyleBackColor = True
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(337, 291)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(167, 22)
        Me.txtContrasena.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Contraseña"
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.Location = New System.Drawing.Point(337, 251)
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(167, 22)
        Me.txtCodEmpleado.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Codigo de empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(337, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 99)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 601)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.cbxMostrarContra)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
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
    Friend WithEvents txtCodEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
