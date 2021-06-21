<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewProveedor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVProveedores = New System.Windows.Forms.DataGridView()
        Me.btnAcept = New System.Windows.Forms.Button()
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVProveedores
        '
        Me.DGVProveedores.AllowUserToAddRows = False
        Me.DGVProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVProveedores.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.DGVProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVProveedores.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVProveedores.EnableHeadersVisualStyles = False
        Me.DGVProveedores.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGVProveedores.Location = New System.Drawing.Point(12, 12)
        Me.DGVProveedores.Name = "DGVProveedores"
        Me.DGVProveedores.ReadOnly = True
        Me.DGVProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVProveedores.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVProveedores.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.DGVProveedores.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProveedores.Size = New System.Drawing.Size(990, 192)
        Me.DGVProveedores.TabIndex = 73
        '
        'btnAcept
        '
        Me.btnAcept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcept.Location = New System.Drawing.Point(511, 210)
        Me.btnAcept.Name = "btnAcept"
        Me.btnAcept.Size = New System.Drawing.Size(130, 39)
        Me.btnAcept.TabIndex = 74
        Me.btnAcept.Text = "Seleccionar"
        Me.btnAcept.UseVisualStyleBackColor = True
        '
        'viewProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 261)
        Me.Controls.Add(Me.btnAcept)
        Me.Controls.Add(Me.DGVProveedores)
        Me.Name = "viewProveedor"
        Me.Text = "viewProveedor"
        CType(Me.DGVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVProveedores As DataGridView
    Friend WithEvents btnAcept As Button
End Class
