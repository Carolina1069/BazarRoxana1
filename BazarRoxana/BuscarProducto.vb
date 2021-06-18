﻿Imports System.Data.SqlClient
Public Class BuscarProducto
    Private Sub BuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat


        conexion.Close()
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick

        Dim BuscarP As New Ventas

        BuscarP.TxtCodProducto.Text = DGV.CurrentRow.Cells(0).Value
        BuscarP.TxtNombreProducto.Text = DGV.CurrentRow.Cells(1).Value
        BuscarP.TxtUnidades.Text = DGV.CurrentRow.Cells(8).Value
        BuscarP.txMinimo.Text = DGV.CurrentRow.Cells(9).Value

        'MenuPrincipal.ToolStripContainer1.ContentPanel.Controls.Clear()
        BuscarP.MdiParent = MenuPrincipal
        MenuPrincipal.ToolStripContainer1.ContentPanel.Controls.Add(BuscarP)
        BuscarP.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim BuscarP As New Ventas


        BuscarP.MdiParent = MenuPrincipal
        MenuPrincipal.ToolStripContainer1.ContentPanel.Controls.Add(BuscarP)
        BuscarP.Show()
        Me.Close()

    End Sub

    Public Sub filtrarDatos(ByVal buscar As String)

        Try
            Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                Dim query = "select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto where NombProduc LIKE @filtro"

                Dim adapter As New SqlDataAdapter(query, con)
                adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))

                Dim table As New DataTable
                adapter.Fill(table)

                DGV.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged


        If TxtBusqueda.Text = "" Then

            abrir()

            Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto ", conexion)
                adaptador.Fill(DatosCliente)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosCliente
            conexion.Close()

        Else
            LbContador8.Text = TxtBusqueda.Text.Length
            Dim filtro As String = CType(sender, TextBox).Text
            If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
                filtrarDatos(filtro)
            End If

        End If
    End Sub
End Class