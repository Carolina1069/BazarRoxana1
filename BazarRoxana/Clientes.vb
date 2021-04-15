Imports System.Data.SqlClient
Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        conexion.Close()

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        abrir()

        If txCodCli.Text = "" Or txNomCli.Text = "" Or rtxDirCli.Text = "" Or txTelCli.Text = "" Or txCorreoCli.Text = "" Or chkEstado.Checked = False Or DGVCliente.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else

            Dim ConsultaGuardar As String = "insert into Clientes(CodCli, NombCli, DirecCli,TelCli, CorreoCli, EstadoCli) values(@CodCli, @NombCli, @DirecCli,@TelCli, @CorreoCli,1)"
            Dim ejecutar As New SqlCommand(ConsultaGuardar, conexion)
            ejecutar.Parameters.AddWithValue("@CodCli", Val(txCodCli.Text))
            ejecutar.Parameters.AddWithValue("@NombCli", (txNomCli.Text))
            ejecutar.Parameters.AddWithValue("@DirecCli", (rtxDirCli.Text))
            ejecutar.Parameters.AddWithValue("@TelCli", Val(txTelCli.Text))
            ejecutar.Parameters.AddWithValue("@CorreoCli", (txCorreoCli.Text))
            ejecutar.ExecuteNonQuery()


        End If
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        conexion.Close()
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click, btActualizarTabla.Click
        abrir()
        Dim estado As Integer

        If chkEstado.Checked = True Then

            estado = 1
        Else

            estado = 0
        End If

        If txCodCli.Text = "" Or txNomCli.Text = "" Or rtxDirCli.Text = "" Or txTelCli.Text = "" Or txCorreoCli.Text = "" Or DGVCliente.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else

            Dim ConsultaActualizar As String = "update Clientes set NombCli=@NombCli, DirecCli=@DirecCli,TelCli=@TelCli, CorreoCli=@CorreoCli, EstadoCli=@EstadoCli where CodCli=@CodCli"
            Dim ejecutar As New SqlCommand(ConsultaActualizar, conexion)
            ejecutar.Parameters.AddWithValue("@CodCli", Val(txCodCli.Text))
            ejecutar.Parameters.AddWithValue("@NombCli", (txNomCli.Text))
            ejecutar.Parameters.AddWithValue("@DirecCli", (rtxDirCli.Text))
            ejecutar.Parameters.AddWithValue("@TelCli", Val(txTelCli.Text))
            ejecutar.Parameters.AddWithValue("@CorreoCli", (txCorreoCli.Text))
            ejecutar.Parameters.AddWithValue("@EstadoCli", (estado))
            ejecutar.ExecuteNonQuery()

        End If

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        conexion.Close()
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        abrir()

        If txCodCli.Text = "" Then
            MsgBox("Hay campos vacios")
        Else

            Dim ConsultaEliminar As String = "Update Clientes set EstadoCli=0 where CodCli=@CodCli"
            Dim ejecutar As New SqlCommand(ConsultaEliminar, conexion)
            ejecutar.Parameters.AddWithValue("@CodCli", Val(txCodCli.Text))
            ejecutar.ExecuteNonQuery()

        End If
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        conexion.Close()
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        abrir()
        Dim busqueda As Integer
        busqueda = InputBox("Ingrese Codigo", "Busqueda")

      

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select * from Clientes where CodCli=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        conexion.Close()
    End Sub

    Private Sub DGVCliente_DoubleClick(sender As Object, e As EventArgs) Handles DGVCliente.DoubleClick

        txCodCli.Text = DGVCliente.CurrentRow.Cells(0).Value
        txNomCli.Text = DGVCliente.CurrentRow.Cells(1).Value
        rtxDirCli.Text = DGVCliente.CurrentRow.Cells(2).Value
        txTelCli.Text = DGVCliente.CurrentRow.Cells(3).Value
        txCorreoCli.Text = DGVCliente.CurrentRow.Cells(4).Value
        chkEstado.Checked = DGVCliente.CurrentRow.Cells(5).Value

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

    Private Sub txCodCli_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub txNomCli_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloLetras(e)
    End Sub

    Private Sub txTelCli_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged

        abrir()

        If chkInhabil.Checked = True Then

            Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=0", conexion)
                adaptador.Fill(DatosCliente)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVCliente.DataSource = DatosCliente

        Else
            Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
                adaptador.Fill(DatosCliente)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVCliente.DataSource = DatosCliente

        End If
        conexion.Close()
    End Sub
End Class
