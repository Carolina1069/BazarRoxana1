<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FacturaVenta
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturaVenta))
        Me.SelectVentaEncabezadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarRoxana = New BazarRoxana()
        Me.SelectDetalleVentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectImpuestoSubtotalTotalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectMiEmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SelectVentaEncabezadoTableAdapter = New BazarRoxanaTableAdapters.SelectVentaEncabezadoTableAdapter()
        Me.SelectDetalleVentaTableAdapter = New BazarRoxanaTableAdapters.SelectDetalleVentaTableAdapter()
        Me.SelectImpuestoSubtotalTotalTableAdapter = New BazarRoxanaTableAdapters.SelectImpuestoSubtotalTotalTableAdapter()
        Me.SelectMiEmpresaTableAdapter = New BazarRoxanaTableAdapters.SelectMiEmpresaTableAdapter()
        CType(Me.SelectVentaEncabezadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectDetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectImpuestoSubtotalTotalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectMiEmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectVentaEncabezadoBindingSource
        '
        Me.SelectVentaEncabezadoBindingSource.DataMember = "SelectVentaEncabezado"
        Me.SelectVentaEncabezadoBindingSource.DataSource = Me.BazarRoxana
        '
        'BazarRoxana
        '
        Me.BazarRoxana.DataSetName = "BazarRoxana"
        Me.BazarRoxana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SelectDetalleVentaBindingSource
        '
        Me.SelectDetalleVentaBindingSource.DataMember = "SelectDetalleVenta"
        Me.SelectDetalleVentaBindingSource.DataSource = Me.BazarRoxana
        '
        'SelectImpuestoSubtotalTotalBindingSource
        '
        Me.SelectImpuestoSubtotalTotalBindingSource.DataMember = "SelectImpuestoSubtotalTotal"
        Me.SelectImpuestoSubtotalTotalBindingSource.DataSource = Me.BazarRoxana
        '
        'SelectMiEmpresaBindingSource
        '
        Me.SelectMiEmpresaBindingSource.DataMember = "SelectMiEmpresa"
        Me.SelectMiEmpresaBindingSource.DataSource = Me.BazarRoxana
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SelectVentaEncabezadoBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.SelectDetalleVentaBindingSource
        ReportDataSource3.Name = "Impuesto"
        ReportDataSource3.Value = Me.SelectImpuestoSubtotalTotalBindingSource
        ReportDataSource4.Name = "MiEmpresa"
        ReportDataSource4.Value = Me.SelectMiEmpresaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BazarRoxana.FacturaVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(670, 749)
        Me.ReportViewer1.TabIndex = 0
        '
        'SelectVentaEncabezadoTableAdapter
        '
        Me.SelectVentaEncabezadoTableAdapter.ClearBeforeFill = True
        '
        'SelectDetalleVentaTableAdapter
        '
        Me.SelectDetalleVentaTableAdapter.ClearBeforeFill = True
        '
        'SelectImpuestoSubtotalTotalTableAdapter
        '
        Me.SelectImpuestoSubtotalTotalTableAdapter.ClearBeforeFill = True
        '
        'SelectMiEmpresaTableAdapter
        '
        Me.SelectMiEmpresaTableAdapter.ClearBeforeFill = True
        '
        'FacturaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 749)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FacturaVenta"
        Me.Text = "Factura de la venta"
        CType(Me.SelectVentaEncabezadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectDetalleVentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectImpuestoSubtotalTotalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectMiEmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SelectVentaEncabezadoBindingSource As BindingSource
    Friend WithEvents BazarRoxana As BazarRoxana
    Friend WithEvents SelectDetalleVentaBindingSource As BindingSource
    Friend WithEvents SelectImpuestoSubtotalTotalBindingSource As BindingSource
    Friend WithEvents SelectMiEmpresaBindingSource As BindingSource
    Friend WithEvents SelectVentaEncabezadoTableAdapter As BazarRoxanaTableAdapters.SelectVentaEncabezadoTableAdapter
    Friend WithEvents SelectDetalleVentaTableAdapter As BazarRoxanaTableAdapters.SelectDetalleVentaTableAdapter
    Friend WithEvents SelectImpuestoSubtotalTotalTableAdapter As BazarRoxanaTableAdapters.SelectImpuestoSubtotalTotalTableAdapter
    Friend WithEvents SelectMiEmpresaTableAdapter As BazarRoxanaTableAdapters.SelectMiEmpresaTableAdapter
End Class
