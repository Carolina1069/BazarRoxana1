<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarCliente
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.codcli = New System.Windows.Forms.Label()
        Me.nombcli = New System.Windows.Forms.Label()
        Me.LbContador9 = New System.Windows.Forms.Label()
        Me.LbContador8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle14
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGV.Location = New System.Drawing.Point(-1, 109)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DGV.RowHeadersWidth = 51
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(1053, 572)
        Me.DGV.TabIndex = 73
        '
        'codcli
        '
        Me.codcli.AutoSize = True
        Me.codcli.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.codcli.Location = New System.Drawing.Point(749, 390)
        Me.codcli.Name = "codcli"
        Me.codcli.Size = New System.Drawing.Size(0, 13)
        Me.codcli.TabIndex = 74
        '
        'nombcli
        '
        Me.nombcli.AutoSize = True
        Me.nombcli.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.nombcli.Location = New System.Drawing.Point(749, 428)
        Me.nombcli.Name = "nombcli"
        Me.nombcli.Size = New System.Drawing.Size(0, 13)
        Me.nombcli.TabIndex = 75
        '
        'LbContador9
        '
        Me.LbContador9.AutoSize = True
        Me.LbContador9.BackColor = System.Drawing.Color.Transparent
        Me.LbContador9.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador9.ForeColor = System.Drawing.Color.Black
        Me.LbContador9.Location = New System.Drawing.Point(442, 51)
        Me.LbContador9.Name = "LbContador9"
        Me.LbContador9.Size = New System.Drawing.Size(30, 19)
        Me.LbContador9.TabIndex = 90
        Me.LbContador9.Text = "/20"
        '
        'LbContador8
        '
        Me.LbContador8.AutoSize = True
        Me.LbContador8.BackColor = System.Drawing.Color.Transparent
        Me.LbContador8.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbContador8.ForeColor = System.Drawing.Color.Black
        Me.LbContador8.Location = New System.Drawing.Point(422, 50)
        Me.LbContador8.Name = "LbContador8"
        Me.LbContador8.Size = New System.Drawing.Size(18, 19)
        Me.LbContador8.TabIndex = 89
        Me.LbContador8.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 19)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Escriba el nombre del Cliente:"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.TxtBusqueda.Location = New System.Drawing.Point(225, 49)
        Me.TxtBusqueda.MaxLength = 20
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(189, 20)
        Me.TxtBusqueda.TabIndex = 87
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(881, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 39)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1053, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LbContador9)
        Me.Controls.Add(Me.LbContador8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.nombcli)
        Me.Controls.Add(Me.codcli)
        Me.Controls.Add(Me.DGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarCliente"
        Me.Text = "BuscarCliente"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents codcli As Label
    Friend WithEvents nombcli As Label
    Friend WithEvents LbContador9 As Label
    Friend WithEvents LbContador8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Button1 As Button
End Class
