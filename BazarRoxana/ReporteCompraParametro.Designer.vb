<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteCompraParametro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteCompraParametro))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DtpSegundaFecha = New System.Windows.Forms.DateTimePicker()
        Me.DtpPrimerFecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BazarRoxana = New BazarRoxana()
        Me.SelectCompraFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectCompraFechaTableAdapter = New BazarRoxanaTableAdapters.SelectCompraFechaTableAdapter()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectCompraFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "CompraFecha"
        ReportDataSource1.Value = Me.SelectCompraFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BazarRoxana.RpCompraParametro.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 80)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(801, 671)
        Me.ReportViewer1.TabIndex = 7
        '
        'DtpSegundaFecha
        '
        Me.DtpSegundaFecha.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DtpSegundaFecha.Location = New System.Drawing.Point(134, 41)
        Me.DtpSegundaFecha.Name = "DtpSegundaFecha"
        Me.DtpSegundaFecha.Size = New System.Drawing.Size(261, 27)
        Me.DtpSegundaFecha.TabIndex = 19
        '
        'DtpPrimerFecha
        '
        Me.DtpPrimerFecha.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DtpPrimerFecha.Location = New System.Drawing.Point(134, 15)
        Me.DtpPrimerFecha.Name = "DtpPrimerFecha"
        Me.DtpPrimerFecha.Size = New System.Drawing.Size(261, 27)
        Me.DtpPrimerFecha.TabIndex = 18
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBuscar.Location = New System.Drawing.Point(401, 23)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(83, 36)
        Me.BtnBuscar.TabIndex = 17
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Segunda Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(29, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Primer Fecha:"
        '
        'BazarRoxana
        '
        Me.BazarRoxana.DataSetName = "BazarRoxana"
        Me.BazarRoxana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SelectCompraFechaBindingSource
        '
        Me.SelectCompraFechaBindingSource.DataMember = "SelectCompraFecha"
        Me.SelectCompraFechaBindingSource.DataSource = Me.BazarRoxana
        '
        'SelectCompraFechaTableAdapter
        '
        Me.SelectCompraFechaTableAdapter.ClearBeforeFill = True
        '
        'ReporteCompraParametro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.DtpSegundaFecha)
        Me.Controls.Add(Me.DtpPrimerFecha)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReporteCompraParametro"
        Me.Text = "Reporte de las compras con intervalo de fecha"
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectCompraFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DtpSegundaFecha As DateTimePicker
    Friend WithEvents DtpPrimerFecha As DateTimePicker
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectCompraFechaBindingSource As BindingSource
    Friend WithEvents BazarRoxana As BazarRoxana
    Friend WithEvents SelectCompraFechaTableAdapter As BazarRoxanaTableAdapters.SelectCompraFechaTableAdapter
End Class
