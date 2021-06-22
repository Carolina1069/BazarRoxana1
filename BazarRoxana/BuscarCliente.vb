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

        Dim frm As Ventas = CType(Owner, Ventas)
        frm.TxtCodCli.Text = DGV.CurrentRow.Cells(0).Value
        frm.TxtNombreCliente.Text = DGV.CurrentRow.Cells(1).Value
        Me.Close()

    End Sub

    Public Sub filtrarDatos(ByVal buscar As String)

        Try
            Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                Dim query = "select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1 and NombCli LIKE @filtro"

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
            Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
    End Sub
End Class