﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.txCodEmple = New System.Windows.Forms.TextBox()
        Me.txtNumVenta = New System.Windows.Forms.TextBox()
        Me.lbCodEmple = New System.Windows.Forms.Label()
        Me.lbCodigoCli = New System.Windows.Forms.Label()
        Me.txCodCli = New System.Windows.Forms.TextBox()
        Me.lbNumeroVenta = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(312, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 63)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btSalir)
        Me.GroupBox1.Controls.Add(Me.btEliminar)
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.btGuardar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btBuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 334)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(709, 338)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de la Venta"
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(597, 300)
        Me.btSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(100, 28)
        Me.btSalir.TabIndex = 25
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btEliminar
        '
        Me.btEliminar.Location = New System.Drawing.Point(424, 300)
        Me.btEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(100, 28)
        Me.btEliminar.TabIndex = 24
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(232, 300)
        Me.btActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(100, 28)
        Me.btActualizar.TabIndex = 23
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(41, 300)
        Me.btGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(100, 28)
        Me.btGuardar.TabIndex = 22
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 91)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(681, 185)
        Me.DataGridView1.TabIndex = 21
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(41, 55)
        Me.btBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(100, 28)
        Me.btBuscar.TabIndex = 18
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'txCodEmple
        '
        Me.txCodEmple.Location = New System.Drawing.Point(164, 196)
        Me.txCodEmple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txCodEmple.Name = "txCodEmple"
        Me.txCodEmple.Size = New System.Drawing.Size(132, 22)
        Me.txCodEmple.TabIndex = 28
        '
        'txtNumVenta
        '
        Me.txtNumVenta.Location = New System.Drawing.Point(164, 128)
        Me.txtNumVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumVenta.Name = "txtNumVenta"
        Me.txtNumVenta.Size = New System.Drawing.Size(132, 22)
        Me.txtNumVenta.TabIndex = 27
        '
        'lbCodEmple
        '
        Me.lbCodEmple.AutoSize = True
        Me.lbCodEmple.Location = New System.Drawing.Point(28, 199)
        Me.lbCodEmple.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodEmple.Name = "lbCodEmple"
        Me.lbCodEmple.Size = New System.Drawing.Size(139, 17)
        Me.lbCodEmple.TabIndex = 25
        Me.lbCodEmple.Text = "Codigo de Empleado"
        '
        'lbCodigoCli
        '
        Me.lbCodigoCli.AutoSize = True
        Me.lbCodigoCli.Location = New System.Drawing.Point(433, 128)
        Me.lbCodigoCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbCodigoCli.Name = "lbCodigoCli"
        Me.lbCodigoCli.Size = New System.Drawing.Size(122, 17)
        Me.lbCodigoCli.TabIndex = 23
        Me.lbCodigoCli.Text = "Codigo del Cliente"
        '
        'txCodCli
        '
        Me.txCodCli.Location = New System.Drawing.Point(569, 119)
        Me.txCodCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txCodCli.Name = "txCodCli"
        Me.txCodCli.Size = New System.Drawing.Size(132, 22)
        Me.txCodCli.TabIndex = 22
        '
        'lbNumeroVenta
        '
        Me.lbNumeroVenta.AutoSize = True
        Me.lbNumeroVenta.Location = New System.Drawing.Point(20, 133)
        Me.lbNumeroVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNumeroVenta.Name = "lbNumeroVenta"
        Me.lbNumeroVenta.Size = New System.Drawing.Size(119, 17)
        Me.lbNumeroVenta.TabIndex = 21
        Me.lbNumeroVenta.Text = "Numero de Venta"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 682)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txCodEmple)
        Me.Controls.Add(Me.txtNumVenta)
        Me.Controls.Add(Me.lbCodEmple)
        Me.Controls.Add(Me.lbCodigoCli)
        Me.Controls.Add(Me.txCodCli)
        Me.Controls.Add(Me.lbNumeroVenta)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btSalir As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btBuscar As Button
    Friend WithEvents txCodEmple As TextBox
    Friend WithEvents txtNumVenta As TextBox
    Friend WithEvents lbCodEmple As Label
    Friend WithEvents lbCodigoCli As Label
    Friend WithEvents txCodCli As TextBox
    Friend WithEvents lbNumeroVenta As Label
End Class
