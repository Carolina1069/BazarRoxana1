Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkEstado.Checked = True
        abrir()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        conexion.Close()

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try

            Dim mail As New System.Net.Mail.MailAddress(txCorreoCli.Text)
            abrir()
            If (txNomCli.TextLength < 2) Then
                MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del cliente")
            ElseIf (txCorreoCli.TextLength < 6) Then
                MessageBox.Show("Debe ingresar como minimo 6 caracteres en el correro del cliente")
            ElseIf (txTelCli.TextLength < 8) Then
                MessageBox.Show("Debe ingresar 8 caracteres en el teléfono del empleado")

            ElseIf txNomCli.Text = "" Or rtxDirCli.Text = "" Or txTelCli.Text = "" Or txCorreoCli.Text = "" Or chkEstado.Checked = False Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                If PersonaRegistradaClientes(txCodCli.Text) = False Then
                    Dim ConsultaGuardar As String = "insert into Clientes(NombCli, DirecCli,TelCli, CorreoCli, EstadoCli) values(@NombCli, @DirecCli,@TelCli, @CorreoCli,1)"
                    Dim ejecutar As New SqlCommand(ConsultaGuardar, conexion)
                    ejecutar.Parameters.AddWithValue("@NombCli", (txNomCli.Text))
                    ejecutar.Parameters.AddWithValue("@DirecCli", (rtxDirCli.Text))
                    ejecutar.Parameters.AddWithValue("@TelCli", Val(txTelCli.Text))
                    ejecutar.Parameters.AddWithValue("@CorreoCli", (txCorreoCli.Text))
                    ejecutar.ExecuteNonQuery()

                Else
                    MsgBox("El cliente ya esta registrado")
                End If

            End If

            Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
                adaptador.Fill(DatosCliente)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVCliente.DataSource = DatosCliente
            MsgBox("El cliente sea guardado")
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        Try

            Dim mail As New System.Net.Mail.MailAddress(txCorreoCli.Text)

            abrir()
        Dim estado As Integer

        If chkEstado.Checked = True Then

            estado = 1
        Else

            estado = 0
        End If

        If (txNomCli.TextLength < 2) Then
            MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del cliente")
        ElseIf (txCorreoCli.TextLength < 6) Then
            MessageBox.Show("Debe ingresar como minimo 6 caracteres en usuario del empleado")
        ElseIf (txTelCli.TextLength < 8) Then
            MessageBox.Show("Debe ingresar 8 caracteres en el teléfono del empleado")
        Else


            If txNomCli.Text = "" Or rtxDirCli.Text = "" Or txTelCli.Text = "" Or txCorreoCli.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else

                Dim ConsultaActualizar As String = "update Clientes set NombCli=@NombCli, DirecCli=@DirecCli,TelCli=@TelCli, CorreoCli=@CorreoCli, EstadoCli=@EstadoCli where CodCli=@CodCli"
                Dim ejecutar As New SqlCommand(ConsultaActualizar, conexion)
                ejecutar.Parameters.AddWithValue("@CodCli", (txCodCli.Text))
                ejecutar.Parameters.AddWithValue("@NombCli", (txNomCli.Text))
                ejecutar.Parameters.AddWithValue("@DirecCli", (rtxDirCli.Text))
                ejecutar.Parameters.AddWithValue("@TelCli", Val(txTelCli.Text))
                ejecutar.Parameters.AddWithValue("@CorreoCli", (txCorreoCli.Text))
                ejecutar.Parameters.AddWithValue("@EstadoCli", (estado))
                ejecutar.ExecuteNonQuery()

            End If
        End If
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        MsgBox("El cliente sea actualizo")
        conexion.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub btActualizarTabla_Click(sender As Object, e As EventArgs) Handles btActualizarTabla.Click
        TxtBusqueda.Clear()
        abrir()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        conexion.Close()

        chkInhabil.Checked = False

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        abrir()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then

            If txNomCli.Text = "" Then
                MsgBox("Hay campos vacios")
            Else

                Dim ConsultaEliminar As String = "Update Clientes set EstadoCli=0 where CodCli=@CodCli"
                Dim ejecutar As New SqlCommand(ConsultaEliminar, conexion)
                ejecutar.Parameters.AddWithValue("@CodCli", Val(txCodCli.Text))
                ejecutar.ExecuteNonQuery()

            End If
        End If
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        conexion.Close()

        txCodCli.Clear()
        txNomCli.Clear()
        rtxDirCli.Clear()
        txTelCli.Clear()
        txCorreoCli.Clear()
        chkEstado.Checked = False

    End Sub


    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        ' Lista con los caracteres que deseo permitir.
        '
        Dim caracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM " & Convert.ToChar(8)

        ' Carácter presionado.
        '
        Dim c As Char = e.KeyChar

        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        '
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Solo se puede ingresar valores de tipo texto.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True

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

    Private Sub txTelCli_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged

        abrir()

        If chkInhabil.Checked = True Then

            Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=0", conexion)
                adaptador.Fill(DatosCliente)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVCliente.DataSource = DatosCliente

        Else
            Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
                adaptador.Fill(DatosCliente)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVCliente.DataSource = DatosCliente

        End If
        conexion.Close()
    End Sub

    Private Sub txTelCli_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txTelCli.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txCodCli_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txCodCli.KeyPress
        SoloNumeros(e)
    End Sub


    Public Sub filtrarDatos(ByVal buscar As String)
        If chkInhabil.Checked = False Then
            Try
                Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim query = "select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1 and NombCli LIKE @filtro"

                    Dim adapter As New SqlDataAdapter(query, con)
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))

                    Dim table As New DataTable
                    adapter.Fill(table)

                    DGVCliente.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim query = "select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=0 and NombCli LIKE @filtro"

                    Dim adapter As New SqlDataAdapter(query, con)
                    adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))

                    Dim table As New DataTable
                    adapter.Fill(table)

                    DGVCliente.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        LbContador8.Text = TxtBusqueda.Text.Length
        Dim filtro As String = CType(sender, TextBox).Text
        If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(filtro)
        End If
    End Sub

    Private Sub txNomCli_TextChanged(sender As Object, e As EventArgs) Handles txNomCli.TextChanged
        LbContador4.Text = txNomCli.Text.Length
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        txCodCli.Clear()
        txNomCli.Clear()
        rtxDirCli.Clear()
        txTelCli.Clear()
        txCorreoCli.Clear()
        chkEstado.Checked = False

    End Sub

    Private Sub txNomCli_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txNomCli.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub txCorreoCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCorreoCli.KeyPress
        SoloLetrascorreo(e)
    End Sub
    Sub SoloLetrascorreo(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        ' Lista con los caracteres que deseo permitir.
        '
        Dim caracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890@._-" & Convert.ToChar(8)

        ' Carácter presionado.
        '
        Dim c As Char = e.KeyChar

        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        '
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Ingrese solamente letras, numeros, carectes especiales( @ . - _ ).", "ERROR de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True

        End If
    End Sub

    Private Sub txCorreoCli_TextChanged(sender As Object, e As EventArgs) Handles txCorreoCli.TextChanged
        LbContador6.Text = txCorreoCli.Text.Length
    End Sub

    Private Sub txTelCli_TextChanged(sender As Object, e As EventArgs) Handles txTelCli.TextChanged
        LbContador.Text = txTelCli.Text.Length
    End Sub

    Private Sub rtxDirCli_TextChanged(sender As Object, e As EventArgs) Handles rtxDirCli.TextChanged
        LbContador2.Text = rtxDirCli.Text.Length
    End Sub

    Private Sub DGVCliente_DoubleClick(sender As Object, e As EventArgs) Handles DGVCliente.DoubleClick
        txCodCli.Text = DGVCliente.CurrentRow.Cells(0).Value
        txNomCli.Text = DGVCliente.CurrentRow.Cells(1).Value
        rtxDirCli.Text = DGVCliente.CurrentRow.Cells(2).Value
        txTelCli.Text = DGVCliente.CurrentRow.Cells(3).Value
        txCorreoCli.Text = DGVCliente.CurrentRow.Cells(4).Value
    End Sub

End Class
