Imports System.Data.SqlClient
Public Class viewProveedor
    Private Sub viewProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
        ConexionBase.Close()
    End Sub

    Private Sub btnAcept_Click(sender As Object, e As EventArgs) Handles btnAcept.Click

        Dim compras As New Compras
        compras = CType(Owner, Compras)

        compras.TxtCodProv.Text = codProv
        Me.Hide()

    End Sub

    Private Sub DGVProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProveedores.CellContentClick

    End Sub

    Private Sub DGVProveedores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProveedores.CellContentDoubleClick
        codProv = DGVProveedores.Item(0, DGVProveedores.CurrentRow.Index).Value
        'MsgBox("soy codigo " + codProv)
    End Sub
End Class