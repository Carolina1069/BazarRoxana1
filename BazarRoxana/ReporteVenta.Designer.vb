<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVenta
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SelectVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarRoxana = New BazarRoxana()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SelectVentasTableAdapter = New BazarRoxanaTableAdapters.SelectVentasTableAdapter()
        CType(Me.SelectVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectVentasBindingSource
        '
        Me.SelectVentasBindingSource.DataMember = "SelectVentas"
        Me.SelectVentasBindingSource.DataSource = Me.BazarRoxana
        '
        'BazarRoxana
        '
        Me.BazarRoxana.DataSetName = "BazarRoxana"
        Me.BazarRoxana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ventas"
        ReportDataSource1.Value = Me.SelectVentasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BazarRoxana.RpVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 749)
        Me.ReportViewer1.TabIndex = 0
        '
        'SelectVentasTableAdapter
        '
        Me.SelectVentasTableAdapter.ClearBeforeFill = True
        '
        'ReporteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteVenta"
        Me.Text = "ReporteVenta"
        CType(Me.SelectVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SelectVentasBindingSource As BindingSource
    Friend WithEvents BazarRoxana As BazarRoxana
    Friend WithEvents SelectVentasTableAdapter As BazarRoxanaTableAdapters.SelectVentasTableAdapter
End Class
