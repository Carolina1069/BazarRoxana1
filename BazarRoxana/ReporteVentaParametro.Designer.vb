﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentaParametro
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
        Me.SelectVentaFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarRoxana = New BazarRoxana()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtFecha2 = New System.Windows.Forms.TextBox()
        Me.TxtFecha1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectVentaFechaTableAdapter = New BazarRoxanaTableAdapters.SelectVentaFechaTableAdapter()
        CType(Me.SelectVentaFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectVentaFechaBindingSource
        '
        Me.SelectVentaFechaBindingSource.DataMember = "SelectVentaFecha"
        Me.SelectVentaFechaBindingSource.DataSource = Me.BazarRoxana
        '
        'BazarRoxana
        '
        Me.BazarRoxana.DataSetName = "BazarRoxana"
        Me.BazarRoxana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "VentaFecha"
        ReportDataSource1.Value = Me.SelectVentaFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BazarRoxana.RpVentaParametro.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 76)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 661)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Año/(mm)/(dd)"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(214, 25)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 21)
        Me.BtnBuscar.TabIndex = 11
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtFecha2
        '
        Me.TxtFecha2.Location = New System.Drawing.Point(99, 37)
        Me.TxtFecha2.MaxLength = 10
        Me.TxtFecha2.Name = "TxtFecha2"
        Me.TxtFecha2.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha2.TabIndex = 10
        '
        'TxtFecha1
        '
        Me.TxtFecha1.Location = New System.Drawing.Point(99, 10)
        Me.TxtFecha1.MaxLength = 10
        Me.TxtFecha1.Name = "TxtFecha1"
        Me.TxtFecha1.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Segunda Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Primer Fecha:"
        '
        'SelectVentaFechaTableAdapter
        '
        Me.SelectVentaFechaTableAdapter.ClearBeforeFill = True
        '
        'ReporteVentaParametro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtFecha2)
        Me.Controls.Add(Me.TxtFecha1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReporteVentaParametro"
        Me.Text = "Reporte de las Ventas con Intervalo de Fecha"
        CType(Me.SelectVentaFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarRoxana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SelectVentaFechaBindingSource As BindingSource
    Friend WithEvents BazarRoxana As BazarRoxana
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtFecha2 As TextBox
    Friend WithEvents TxtFecha1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SelectVentaFechaTableAdapter As BazarRoxanaTableAdapters.SelectVentaFechaTableAdapter
End Class
