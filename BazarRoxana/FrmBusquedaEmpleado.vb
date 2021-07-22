Imports System.Data.SqlClient
Public Class FrmBusquedaEmpleado
    Private Sub FrmBusquedaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConeccion()

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", ConexionBase)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        ConexionBase.Close()
    End Sub
    Public Sub filtrarDatos(ByVal buscar As String) '<-Funcion para filtrar datos que se mostraran en el DataGridView.

        Try
            Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                Dim query = "select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 0 and NombEmple LIKE @filtro"

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
        LbContador8.Text = TxtBusqueda.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        Dim filtro As String = CType(sender, TextBox).Text
        If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(filtro)
        Else
            AbrirConeccion()
            Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodEmple as 'Código del empleado', NombEmple as 'Nombre del empleado', case when NivelEmple=1 Then 'Administrador' when NivelEmple=2 Then 'Gerente' else 'Vendedor' end as 'Nivel del empleado', case 
        when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", ConexionBase)
                adaptador.Fill(DatosEmp)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosEmp

            ConexionBase.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        Dim frm As FrmUsuario = CType(Owner, FrmUsuario)
        frm.TxtCodigoEmpleado.Text = DGV.CurrentRow.Cells(0).Value
        frm.txtNombreEmpleado.Text = DGV.CurrentRow.Cells(1).Value

        Me.Close()
    End Sub
End Class