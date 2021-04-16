Imports System.Data.SqlClient

Public Class Empleado
    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Cat As Integer
        abrir()

        If TxtCodigoEmpleado.Text = "" Or txtNombreEmpleado.Text = "" Or TxtContraseña.Text = "" Or chkEstado.Checked = False Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            If RegistradoEmpleados(TxtCodigoEmpleado.Text) = False Then

                If CbxNivel.SelectedItem = "Gerente" Then
                    Cat = 1

                Else
                    Cat = 2

                End If

                Dim consultaGuardar As String = "insert into Empleados(CodEmple, NombEmple, Contraseña,NivelEmple,EstadoEmple) values(@CodEmple, @NombEmple,@Contraseña,@NivelEmple,1)"
                Dim ejecutar As New SqlCommand(consultaGuardar, conexion)
                ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))
                ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
                ejecutar.Parameters.AddWithValue("@Contraseña", (TxtContraseña.Text))
                ejecutar.Parameters.AddWithValue("@NivelEmple", (Cat))

                ejecutar.ExecuteNonQuery()
            Else
                MsgBox("El Empleado ya esta registrado")
            End If
        End If

            Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()
        TxtCodigoEmpleado.Clear()
        txtNombreEmpleado.Clear()
        TxtContraseña.Clear()
        CbxNivel.Text = ""
        chkEstado.Checked = False

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        abrir()

        If TxtCodigoEmpleado.Text = "" Or txtNombreEmpleado.Text = "" Or TxtContraseña.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            Dim Cat As Integer
            Dim estado As Integer

            If CbxNivel.SelectedItem = "Gerente" And chkEstado.Checked = True Then
                Cat = 1
                estado = 1
            Else
                Cat = 2
                estado = 0
            End If

            Dim consultaAct As String = "update Empleados set NombEmple=@NombEmple, Contraseña=@Contraseña ,NivelEmple=@NivelEmple, EstadoEmple=@EstadoEmple where CodEmple= @CodEmple"
            Dim ejecutar As New SqlCommand(consultaAct, conexion)
            ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))
            ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
            ejecutar.Parameters.AddWithValue("@Contraseña", (TxtContraseña.Text))
            ejecutar.Parameters.AddWithValue("@NivelEmple", (Cat))
            ejecutar.Parameters.AddWithValue("@EstadoEmple", (estado))
            ejecutar.ExecuteNonQuery()

        End If

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGV.DataSource = DatosEmp
        conexion.Close()

        TxtCodigoEmpleado.Clear()
        txtNombreEmpleado.Clear()
        TxtContraseña.Clear()
        CbxNivel.Text = ""
        chkEstado.Checked = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        abrir()

        If TxtCodigoEmpleado.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaElim As String = "Update Empleados set EstadoEmple=0   where CodEmple= @CodEmple"
            Dim ejecutar As New SqlCommand(consultaElim, conexion)
            ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))

            ejecutar.ExecuteNonQuery()
        End If


        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()

        TxtCodigoEmpleado.Clear()
        txtNombreEmpleado.Clear()
        TxtContraseña.Clear()
        CbxNivel.Text = ""
        chkEstado.Checked = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        abrir()
        Dim busqueda As Integer
        busqueda = InputBox("Ingrese Codigo", "Busqueda")

        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where CodEmple=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        Me.Close()
        Login.Show()
    End Sub


    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        TxtCodigoEmpleado.Text = DGV.CurrentRow.Cells(0).Value
        txtNombreEmpleado.Text = DGV.CurrentRow.Cells(1).Value
        TxtContraseña.Text = DGV.CurrentRow.Cells(2).Value
        CbxNivel.Text = DGV.CurrentRow.Cells(3).Value
    End Sub

    Private Sub btnActTabla_Click(sender As Object, e As EventArgs) Handles btnActTabla.Click
        abrir()
        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()
    End Sub


    'Funcion  que solo permite el ingreso de caracteres tipo letra
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

    'Funcion  que solo permite el ingreso de caracteres tipo numerico
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
    Private Sub TxtCodigoEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigoEmpleado.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtNombreEmpleado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreEmpleado.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub cbxMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMostrarContra.CheckedChanged
        TxtContraseña.UseSystemPasswordChar = Not cbxMostrarContra.Checked

    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged
        abrir()

        If chkInhabil.Checked = True Then

            Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 0", conexion)
                adaptador.Fill(DatosEmp)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosEmp

        Else

            Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
                adaptador.Fill(DatosEmp)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGV.DataSource = DatosEmp

        End If
        conexion.Close()
    End Sub
End Class