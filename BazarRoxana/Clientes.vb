Imports System.Data.SqlClient

Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AbrirConeccion() '<-- Llamado de la funcion 

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using Adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", ConexionBase)
            Adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvCliente.DataSource = DatosCliente
        ConexionBase.Close()
        BtnHabilitar.Visible = False
        BtnActualizar.Visible = False
        BtnEliminar.Visible = False
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try

            Dim Mail As New System.Net.Mail.MailAddress(TxtCorreocli.Text) '<-Validar el correro
            AbrirConeccion() '<-- Llamado de la funcion 
            If TxtNomcli.TextLength < 2 Then
                MsgBox("Debe ingresar como minimo 2 caracteres en nombre del cliente", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf TxtCorreocli.TextLength < 6 Then
                MsgBox("Debe ingresar como minimo 6 caracteres en el correro del cliente", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtTelcli.TextLength < 8) Then
                MsgBox("Debe ingresar 8 caracteres en el teléfono del empleado", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", TxtCorreocli.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf TxtNomcli.Text = "" Or RtbDircli.Text = "" Or TxtTelcli.Text = "" Or TxtCorreocli.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                If PersonaRegistradaClientes(TxtCodcli.Text) = False Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.
                    Dim ConsultaGuardar As String = "insert into Clientes(NombCli, DirecCli, TelCli, CorreoCli, EstadoCli) values(@NombCli, @DirecCli,@TelCli, @CorreoCli,1)" '<-- Consulta.
                    'Toma los valores de los textbox y el richtextbox y los guardas en la base de datos. 
                    Dim Ejecutar As New SqlCommand(ConsultaGuardar, ConexionBase)
                    Ejecutar.Parameters.AddWithValue("@NombCli", (TxtNomcli.Text))
                    Ejecutar.Parameters.AddWithValue("@DirecCli", (RtbDircli.Text))
                    Ejecutar.Parameters.AddWithValue("@TelCli", Val(TxtTelcli.Text))
                    Ejecutar.Parameters.AddWithValue("@CorreoCli", (TxtCorreocli.Text))
                    Ejecutar.ExecuteNonQuery()

                Else
                    MsgBox("El cliente ya esta registrado")
                End If
                BtnEliminar.Visible = False
                Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using Adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", ConexionBase)
                    Adaptador.Fill(DatosCliente)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DgvCliente.DataSource = DatosCliente
                MsgBox("El cliente se a guardado")
                ConexionBase.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try

            Dim Mail As New System.Net.Mail.MailAddress(TxtCorreocli.Text) '<-Validar el correro

            AbrirConeccion() '<-- Llamado de la funcion 

            If TxtNomcli.TextLength < 2 Then
                MsgBox("Debe ingresar como minimo 2 caracteres en nombre del cliente", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf TxtCorreocli.TextLength < 6 Then
                MsgBox("Debe ingresar como minimo 6 caracteres en el correro del cliente", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtTelcli.TextLength < 8) Then
                MsgBox("Debe ingresar 8 caracteres en el teléfono del empleado", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", TxtCorreocli.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf TxtNomcli.Text = "" Or RtbDircli.Text = "" Or TxtTelcli.Text = "" Or TxtCorreocli.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Dim ConsultaActualizar As String = "update Clientes set NombCli=@NombCli, DirecCli=@DirecCli,TelCli=@TelCli, CorreoCli=@CorreoCli, EstadoCli=1 where CodCli=@CodCli" '<--Consulta
                'Toma los valores de los textbox y el richtextbox y los actualiza en la base de datos. 
                Dim Ejecutar As New SqlCommand(ConsultaActualizar, ConexionBase)
                Ejecutar.Parameters.AddWithValue("@CodCli", (TxtCodcli.Text))
                ejecutar.Parameters.AddWithValue("@NombCli", (TxtNomcli.Text))
                ejecutar.Parameters.AddWithValue("@DirecCli", (RtbDircli.Text))
                ejecutar.Parameters.AddWithValue("@TelCli", Val(TxtTelcli.Text))
                Ejecutar.Parameters.AddWithValue("@CorreoCli", (TxtCorreocli.Text))
                Ejecutar.ExecuteNonQuery()

                Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using Adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", ConexionBase)
                    Adaptador.Fill(DatosCliente)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DgvCliente.DataSource = DatosCliente
                MsgBox("El cliente se a actualizo")
                ConexionBase.Close()
                BtnGuardar.Visible = False
                ChkInhabil.Checked = False

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            BtnActualizar.Visible = False
        End Try
        BtnEliminar.Visible = True


    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        AbrirConeccion() '<-- Llamado de la funcion 
        If TxtCodcli.Text = String.Empty Then
            MsgBox("Por favor haga doble click a una fila de la tabla antes de eliminar algún dato deseado.", MsgBoxStyle.Exclamation, "Advertencia")
        Else

            Dim Opcion As DialogResult
            Opcion = MessageBox.Show("¿Esta Seguro que quiere eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Opcion = DialogResult.Yes Then

                If TxtNomcli.Text = "" Then
                    MsgBox("Hay campos vacios")
                Else
                    Dim ConsultaEliminar As String = "Update Clientes set EstadoCli=0 where CodCli=@CodCli" '<-- Consulta
                    'Toma el valor del textbox y lo deshabilita en la base de datos. 
                    Dim Ejecutar As New SqlCommand(ConsultaEliminar, ConexionBase)
                    Ejecutar.Parameters.AddWithValue("@CodCli", Val(TxtCodcli.Text))
                    Ejecutar.ExecuteNonQuery()
                End If
            End If

            BtnEliminar.Visible = False
            BtnActualizar.Visible = False
        End If

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using Adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", ConexionBase)
            Adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DgvCliente.DataSource = DatosCliente
        ConexionBase.Close()
        'Limpia los textbox, el rich y el checkbox
        TxtCodcli.Clear()
        TxtNomcli.Clear()
        RtbDircli.Clear()
        TxtTelcli.Clear()
        TxtCorreocli.Clear()

    End Sub


    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)

        ' Lista con los caracteres que deseo permitir.
        '
        Dim CaracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM " & Convert.ToChar(8)

        ' Carácter presionado.
        '
        Dim c As Char = e.KeyChar

        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        '
        If (Not (CaracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Solo se puede ingresar valores de tipo texto.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True

        ElseIf Len(Me.TxtNomcli.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub


    Private Sub txCodCli_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub txTelCli_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInhabil.CheckedChanged

        AbrirConeccion()

        If ChkInhabil.Checked = True Then

            Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using Adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=0", ConexionBase)
                Adaptador.Fill(DatosCliente)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DgvCliente.DataSource = DatosCliente
            BtnGuardar.Visible = False
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnHabilitar.Visible = True
        Else
            Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using Adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", ConexionBase)
                Adaptador.Fill(DatosCliente)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DgvCliente.DataSource = DatosCliente
            BtnGuardar.Visible = True
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnHabilitar.Visible = False
        End If
        ConexionBase.Close()
    End Sub

    Private Sub txTelCli_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtTelcli.KeyPress '<--Valida solo numeros, la entrada del primer número que sea valido.

        SoloNumeros(e)
        If Len(Me.TxtTelcli.Text) = "0" Then
            If InStr(1, "2,3,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("Solo numero inical en 2,3,8 o 9", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Private Sub txCodCli_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtCodcli.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion 
    End Sub


    Public Sub filtrarDatos(ByVal Buscar As String) '<-Funcion para filtrar datos que se mostraran en el DataGridView.
        If ChkInhabil.Checked = False Then
            Try
                Using Con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim Query = "select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1 and NombCli LIKE @filtro"

                    Dim Adapter As New SqlDataAdapter(Query, Con)
                    Adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", Buscar))

                    Dim Table As New DataTable
                    Adapter.Fill(Table)

                    DgvCliente.DataSource = Table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Using Con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim Query = "select CodCli as 'Codigo del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Direccion del Cliente', TelCli 'Telefono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=0 and NombCli LIKE @filtro"

                    Dim Adapter As New SqlDataAdapter(Query, Con)
                    Adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", Buscar))

                    Dim Table As New DataTable
                    Adapter.Fill(table)

                    DgvCliente.DataSource = Table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub
    Private Sub TxtBusqueda_TextChanged(Sender As Object, E As EventArgs) Handles TxtBusqueda.TextChanged '<--Busqueda.
        LbContador8.Text = TxtBusqueda.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        Dim Filtro As String = CType(Sender, TextBox).Text
        If Filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(Filtro)
        Else
            AbrirConeccion()

            If ChkInhabil.Checked = True Then

                Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using Adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=0", ConexionBase)
                    Adaptador.Fill(DatosCliente)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DgvCliente.DataSource = DatosCliente

            Else
                Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using Adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", ConexionBase)
                    Adaptador.Fill(DatosCliente)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DgvCliente.DataSource = DatosCliente

            End If
            ConexionBase.Close()
        End If
    End Sub

    Private Sub txNomCli_TextChanged(sender As Object, e As EventArgs) Handles TxtNomcli.TextChanged
        LbContador4.Text = TxtNomcli.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        TxtNomcli.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNomcli.Text) '<-- Evita que se introduzca nombres y apellidos con inicial minisculas. 
        TxtNomcli.SelectionStart = TxtNomcli.Text.Length '<-- Evitar que texto ingresado se muestre al revez(o sea de derecha a la izquierda).
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click '<--Limpia los textbox, el rich
        TxtCodcli.Clear()
        TxtNomcli.Clear()
        RtbDircli.Clear()
        TxtTelcli.Clear()
        TxtCorreocli.Clear()
        BtnActualizar.Visible = False
        BtnEliminar.Visible = False
        BtnGuardar.Visible = True
    End Sub

    Private Sub txNomCli_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtNomcli.KeyPress
        SoloLetras(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub txCorreoCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorreocli.KeyPress
        SoloLetrascorreo(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub txCorreoCli_TextChanged(sender As Object, e As EventArgs) Handles TxtCorreocli.TextChanged
        LbContador6.Text = TxtCorreocli.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        TxtCorreocli.Text = Minusculas(TxtCorreocli.Text, TxtCorreocli) '<--Validacion solo minusculas.
    End Sub

    Private Sub txTelCli_TextChanged(sender As Object, e As EventArgs) Handles TxtTelcli.TextChanged
        LbContador.Text = TxtTelcli.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub rtxDirCli_TextChanged(sender As Object, e As EventArgs) Handles RtbDircli.TextChanged
        LbContador2.Text = RtbDircli.Text.Length '<-- Muestra la cantidad de caracteres escritas en richtextbox.
    End Sub

    Private Sub DGVCliente_DoubleClick(sender As Object, e As EventArgs) Handles DgvCliente.DoubleClick '<-- Con doble clic manda campos del DataGridView a los textbox referidos.
        TxtCodcli.Text = DgvCliente.CurrentRow.Cells(0).Value
        TxtNomcli.Text = DgvCliente.CurrentRow.Cells(1).Value
        RtbDircli.Text = DgvCliente.CurrentRow.Cells(2).Value
        TxtTelcli.Text = DgvCliente.CurrentRow.Cells(3).Value
        TxtCorreocli.Text = DgvCliente.CurrentRow.Cells(4).Value
        If ChkInhabil.Checked = True Then
            BtnEliminar.Visible = False
            BtnActualizar.Visible = False
            BtnGuardar.Visible = False
        Else
            BtnEliminar.Visible = True
            BtnActualizar.Visible = True
            BtnGuardar.Visible = False
        End If
    End Sub



    Private Sub rtxDirCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RtbDircli.KeyPress '<--Funcion para validar que caracteres son permitidos y evitar que se introduscan espacio al principio. 
        Dim CaracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890-,. " & Convert.ToChar(8)
        Dim C As Char = e.KeyChar
        If (Not (CaracteresPermitidos.Contains(C))) Then

            MessageBox.Show("Solo se puede ingresar valores de tipo texto, numericos y caracteres especiales como -,.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.RtbDircli.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,1,2,3,4,5,6,7,8,9,0," & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios o caracteres especiales al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnHabilitar_Click(sender As Object, e As EventArgs) Handles BtnHabilitar.Click
        AbrirConeccion()
        Dim OpcionDia As DialogResult
        OpcionDia = MessageBox.Show("¿Está seguro que quiere habilitar este cliente?", "Habilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OpcionDia = DialogResult.Yes Then
            If TxtCodcli.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Dim ConsultaHabilitar As String = "Update Clientes set EstadoCli=1  where CodCli=@CodCli"
                'Toma el valor del textbox y lo habilita en la base de datos. 
                Dim EjecutarCon As New SqlCommand(ConsultaHabilitar, ConexionBase)
                EjecutarCon.Parameters.AddWithValue("@CodCli", Val(TxtCodcli.Text))
                EjecutarCon.ExecuteNonQuery()
                'Limpia los textbox, el rich y el checkbox
                TxtCodcli.Clear()
                TxtNomcli.Clear()
                TxtTelcli.Clear()
                TxtCorreocli.Clear()
                RtbDircli.Clear()
                ChkInhabil.Checked = False
            End If
        End If
        ChkInhabil.Checked = False
        BtnEliminar.Visible = False
        BtnActualizar.Visible = False
        ConexionBase.Close()
    End Sub
End Class
