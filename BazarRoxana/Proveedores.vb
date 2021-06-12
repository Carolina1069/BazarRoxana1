Imports System.Data.SqlClient
Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkEstado.Checked = True
        abrir()
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
        conexion.Close()
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs)

        abrir()
        Dim busqueda As Integer
        busqueda = InputBox("Ingrese Codigo", "Busqueda")

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores  where CodProv=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
        conexion.Close()
    End Sub

    Private Sub btActualizarTabla_Click(sender As Object, e As EventArgs) Handles btActualizarTabla.Click
        abrir()
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
        conexion.Close()
        chkInhabil.Checked = False
        txCodProve.Clear()
        txNomProv.Clear()
        TxtTelfonoEmpresa.Clear()
        txtNombrePreEm.Clear()
        txCorreoEmpresa.Clear()
        TxtCorreoProv.Clear()
        txtTelProv.Clear()
        RTBDirec.Clear()
        chkEstado.Checked = False


    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        abrir()

        If txCodProve.Text = "" Or txNomProv.Text = "" Or TxtTelfonoEmpresa.Text = "" Or txtNombrePreEm.Text = "" Or txCorreoEmpresa.Text = "" Or TxtCorreoProv.Text = "" Or txtTelProv.Text = "" Or RTBDirec.Text = "" Or chkEstado.Checked = False Or DGVProveedores.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            If RegistradoProveedores(txCodProve.Text) = False Then
                Dim ConsultaGuardar As String = "insert into Proveedores(CodProv, NombProv,TelProv, NombContProv,CorreoProv, CorreoContProv, TelContProv, DirecProv,EstadoProv) values(@CodProv, @NombProv, @TelProv, @NombContProv, @CorreoProv, @CorreoContProv, @TelContProv, @DirecProv,1)"
                Dim ejecutar As New SqlCommand(ConsultaGuardar, conexion)
                ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))
                ejecutar.Parameters.AddWithValue("@NombProv", (txNomProv.Text))
                ejecutar.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoEmpresa.Text))
                ejecutar.Parameters.AddWithValue("@NombContProv", (txtNombrePreEm.Text))
                ejecutar.Parameters.AddWithValue("@CorreoProv", (txCorreoEmpresa.Text))
                ejecutar.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoProv.Text))
                ejecutar.Parameters.AddWithValue("@TelContProv", Val(txtTelProv.Text))
                ejecutar.Parameters.AddWithValue("@DirecProv", (RTBDirec.Text))

                ejecutar.ExecuteNonQuery()
            Else
                MsgBox("El Proveedor ya esta registrado")
            End If
        End If

            Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", conexion)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor

        conexion.Close()

        txCodProve.Clear()
        txNomProv.Clear()
        TxtTelfonoEmpresa.Clear()
        txtNombrePreEm.Clear()
        txCorreoEmpresa.Clear()
        TxtCorreoProv.Clear()
        txtTelProv.Clear()
        RTBDirec.Clear()
        chkEstado.Checked = False


    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        abrir()
        Dim estado As Integer

        If chkEstado.Checked = True Then

            estado = 1
        Else

            estado = 0
        End If

        If txCodProve.Text = "" Or txNomProv.Text = "" Or TxtTelfonoEmpresa.Text = "" Or txtNombrePreEm.Text = "" Or txCorreoEmpresa.Text = "" Or TxtCorreoProv.Text = "" Or txtTelProv.Text = "" Or RTBDirec.Text = "" Or DGVProveedores.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            Dim ConsultaActualizar As String = "update Proveedores set NombProv=@NombProv,TelProv=@TelProv, NombContProv=@NombContProv, CorreoProv=@CorreoProv, CorreoContProv=@CorreoContProv, TelContProv=@TelContProv, DirecProv=@DirecProv, EstadoProv=@EstadoProv where CodProv=@CodProv"
            Dim ejecutar As New SqlCommand(ConsultaActualizar, conexion)
            ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))
            ejecutar.Parameters.AddWithValue("@NombProv", (txNomProv.Text))
            ejecutar.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoEmpresa.Text))
            ejecutar.Parameters.AddWithValue("@NombContProv", (txtNombrePreEm.Text))
            ejecutar.Parameters.AddWithValue("@CorreoProv", (txCorreoEmpresa.Text))
            ejecutar.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoProv.Text))
            ejecutar.Parameters.AddWithValue("@TelContProv", Val(txtTelProv.Text))
            ejecutar.Parameters.AddWithValue("@DirecProv", (RTBDirec.Text))
            ejecutar.Parameters.AddWithValue("@EstadoProv", (estado))
            ejecutar.ExecuteNonQuery()

        End If

        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", conexion)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
        conexion.Close()
        txCodProve.Clear()
        txNomProv.Clear()
        TxtTelfonoEmpresa.Clear()
        txtNombrePreEm.Clear()
        txCorreoEmpresa.Clear()
        TxtCorreoProv.Clear()
        txtTelProv.Clear()
        RTBDirec.Clear()
        chkEstado.Checked = False

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        abrir()

        If txCodProve.Text = "" Then
            MsgBox("Hay campos vacios")
        Else

            Dim ConsultaEliminar As String = "Update Proveedores set EstadoProv=0  where CodProv=@CodProv"
            Dim ejecutar As New SqlCommand(ConsultaEliminar, conexion)
            ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))

            ejecutar.ExecuteNonQuery()

        End If

        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", conexion)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
        conexion.Close()

        txCodProve.Clear()
        txNomProv.Clear()
        TxtTelfonoEmpresa.Clear()
        txtNombrePreEm.Clear()
        txCorreoEmpresa.Clear()
        TxtCorreoProv.Clear()
        txtTelProv.Clear()
        RTBDirec.Clear()
        chkEstado.Checked = False

    End Sub


    Private Sub DGVProveedores_DoubleClick(sender As Object, e As EventArgs)
        txCodProve.Text = DGVProveedores.CurrentRow.Cells(0).Value
        txNomProv.Text = DGVProveedores.CurrentRow.Cells(1).Value
        TxtTelfonoEmpresa.Text = DGVProveedores.CurrentRow.Cells(2).Value
        txtNombrePreEm.Text = DGVProveedores.CurrentRow.Cells(3).Value
        txCorreoEmpresa.Text = DGVProveedores.CurrentRow.Cells(4).Value
        TxtCorreoProv.Text = DGVProveedores.CurrentRow.Cells(5).Value
        txtTelProv.Text = DGVProveedores.CurrentRow.Cells(6).Value
        RTBDirec.Text = DGVProveedores.CurrentRow.Cells(7).Value


    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub txCodProve_KeyPress(sender As Object, e As KeyPressEventArgs) 
        SoloNumeros(e)
    End Sub

    Private Sub txNomProv_KeyPress(sender As Object, e As KeyPressEventArgs) 
        SoloLetras(e)
    End Sub

    Private Sub TxtTelfonoEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) 
        SoloNumeros(e)
    End Sub

    Private Sub txtNombrePreEm_KeyPress(sender As Object, e As KeyPressEventArgs) 
        SoloNumeros(e)
    End Sub

    Private Sub txtTelProv_KeyPress(sender As Object, e As KeyPressEventArgs) 
        SoloNumeros(e)
    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged

        abrir()

        If chkInhabil.Checked = True Then

            Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=0", conexion)
                adaptador.Fill(DatosProveedor)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVProveedores.DataSource = DatosProveedor

        Else

            Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", conexion)
                adaptador.Fill(DatosProveedor)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVProveedores.DataSource = DatosProveedor

        End If

        conexion.Close()
    End Sub

    Private Sub txCodProve_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txCodProve.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTelfonoEmpresa_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtTelfonoEmpresa.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtTelProv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtTelProv.KeyPress
        SoloNumeros(e)
    End Sub

    Public Sub filtrarDatos(ByVal buscar As String)
        If chkInhabil.Checked = False Then
            Try
                Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim query = "select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1 and NombProv LIKE @filtro"

                    Dim adapter As New SqlDataAdapter(query, con)
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))

                    Dim table As New DataTable
                    adapter.Fill(table)

                    DGVProveedores.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim query = "select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=0 and NombProv LIKE @filtro"

                    Dim adapter As New SqlDataAdapter(query, con)
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))

                    Dim table As New DataTable
                    adapter.Fill(table)

                    DGVProveedores.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim filtro As String = CType(sender, TextBox).Text
        If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(filtro)
        End If
    End Sub
End Class