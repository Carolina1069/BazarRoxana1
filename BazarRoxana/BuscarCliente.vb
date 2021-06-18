Imports System.Data.SqlClient
Public Class BuscarCliente
    Private Sub BuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCliente
        conexion.Close()

    End Sub

    Private Sub DGVCliente_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick

        Dim Buscar As New Ventas

        Buscar.TxtCodCli.Text = DGV.CurrentRow.Cells(0).Value
        Buscar.TxtNombreCliente.Text = DGV.CurrentRow.Cells(1).Value

        MenuPrincipal.ToolStripContainer1.ContentPanel.Controls.Clear()
        Buscar.MdiParent = MenuPrincipal
        MenuPrincipal.ToolStripContainer1.ContentPanel.Controls.Add(Buscar)
        Buscar.Show()

    End Sub


End Class