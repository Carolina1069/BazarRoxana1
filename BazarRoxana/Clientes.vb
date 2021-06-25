Imports System.Data.SqlClient

Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkEstado.Checked = True
        abrir() '<-- Llamado de la funcion 

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVCliente.DataSource = DatosCliente
        conexion.Close()

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try

            Dim mail As New System.Net.Mail.MailAddress(txCorreoCli.Text) '<-Validar el correro
            abrir() '<-- Llamado de la funcion 
            If txNomCli.TextLength < 2 Then
                MsgBox("Debe ingresar como minimo 2 caracteres en nombre del cliente", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf txCorreoCli.TextLength < 6 Then
                MsgBox("Debe ingresar como minimo 6 caracteres en el correro del cliente", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txTelCli.TextLength < 8) Then
                MsgBox("Debe ingresar 8 caracteres en el teléfono del empleado", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", txCorreoCli.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf txNomCli.Text = "" Or rtxDirCli.Text = "" Or txTelCli.Text = "" Or txCorreoCli.Text = "" Or chkEstado.Checked = False Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                If PersonaRegistradaClientes(txCodCli.Text) = False Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.
                    Dim ConsultaGuardar As String = "insert into Clientes(NombCli, DirecCli, TelCli, CorreoCli, EstadoCli) values(@NombCli, @DirecCli,@TelCli, @CorreoCli,1)" '<-- Consulta.
                    'Toma los valores de los textbox y el richtextbox y los guardas en la base de datos. 
                    Dim ejecutar As New SqlCommand(ConsultaGuardar, conexion)
                    ejecutar.Parameters.AddWithValue("@NombCli", (txNomCli.Text))
                    ejecutar.Parameters.AddWithValue("@DirecCli", (rtxDirCli.Text))
                    ejecutar.Parameters.AddWithValue("@TelCli", Val(txTelCli.Text))
                    ejecutar.Parameters.AddWithValue("@CorreoCli", (txCorreoCli.Text))
                    ejecutar.ExecuteNonQuery()

                Else
                    MsgBox("El cliente ya esta registrado")
                End If

                Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
                    adaptador.Fill(DatosCliente)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DGVCliente.DataSource = DatosCliente
                MsgBox("El cliente se a guardado")
                conexion.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        Try

            Dim mail As New System.Net.Mail.MailAddress(txCorreoCli.Text) '<-Validar el correro

            abrir() '<-- Llamado de la funcion 
            Dim estado As Integer

            If chkEstado.Checked = True Then
                estado = 1
            Else

                estado = 0
        End If

            If txNomCli.TextLength < 2 Then
                MsgBox("Debe ingresar como minimo 2 caracteres en nombre del cliente", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf txCorreoCli.TextLength < 6 Then
                MsgBox("Debe ingresar como minimo 6 caracteres en el correro del cliente", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txTelCli.TextLength < 8) Then
                MsgBox("Debe ingresar 8 caracteres en el teléfono del empleado", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", txCorreoCli.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ElseIf txNomCli.Text = "" Or rtxDirCli.Text = "" Or txTelCli.Text = "" Or txCorreoCli.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Dim ConsultaActualizar As String = "update Clientes set NombCli=@NombCli, DirecCli=@DirecCli,TelCli=@TelCli, CorreoCli=@CorreoCli, EstadoCli=@EstadoCli where CodCli=@CodCli" '<--Consulta
                'Toma los valores de los textbox y el richtextbox y los actualiza en la base de datos. 
                Dim ejecutar As New SqlCommand(ConsultaActualizar, conexion)
                ejecutar.Parameters.AddWithValue("@CodCli", (txCodCli.Text))
                ejecutar.Parameters.AddWithValue("@NombCli", (txNomCli.Text))
                ejecutar.Parameters.AddWithValue("@DirecCli", (rtxDirCli.Text))
                ejecutar.Parameters.AddWithValue("@TelCli", Val(txTelCli.Text))
                ejecutar.Parameters.AddWithValue("@CorreoCli", (txCorreoCli.Text))
                ejecutar.Parameters.AddWithValue("@EstadoCli", (estado))
                ejecutar.ExecuteNonQuery()

                Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select CodCli as 'Código del Cliente', NombCli as 'Nombre del Cliente', DirecCli 'Dirección del Cliente', TelCli 'Teléfono del Cliente', CorreoCli 'Correo del Cliente', case when EstadoCli=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Cliente' from Clientes where EstadoCli=1", conexion)
                    adaptador.Fill(DatosCliente)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

                DGVCliente.DataSource = DatosCliente
                MsgBox("El cliente se a actualizo")
                conexion.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        abrir() '<-- Llamado de la funcion 
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere eliminar este cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then

            If txNomCli.Text = "" Then
                MsgBox("Hay campos vacios")
            Else
                Dim ConsultaEliminar As String = "Update Clientes set EstadoCli=0 where CodCli=@CodCli" '<-- Consulta
                'Toma el valor del textbox y lo deshabilita en la base de datos. 
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
        'Limpia los textbox, el rich y el checkbox
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

        ElseIf Len(Me.txNomCli.Text) = "0" Then
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

    Private Sub txTelCli_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txTelCli.KeyPress '<--Valida solo numeros, la entrada del primer número que sea valido.

        SoloNumeros(e)
        If Len(Me.txTelCli.Text) = "0" Then
            If InStr(1, "2,3,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("Solo numero inical en 2,3,8 o 9", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If

    End Sub

    Private Sub txCodCli_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txCodCli.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion 
    End Sub


    Public Sub filtrarDatos(ByVal buscar As String) '<-Funcion para filtrar datos que se mostraran en el DataGridView.
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
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged '<--Busqueda.
        LbContador8.Text = TxtBusqueda.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        Dim filtro As String = CType(sender, TextBox).Text
        If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(filtro)
        Else
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
        End If
    End Sub

    Private Sub txNomCli_TextChanged(sender As Object, e As EventArgs) Handles txNomCli.TextChanged
        LbContador4.Text = txNomCli.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        txNomCli.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txNomCli.Text) '<-- Evita que se introduzca nombres y apellidos con inicial minisculas. 
        txNomCli.SelectionStart = txNomCli.Text.Length '<-- Evitar que texto ingresado se muestre al revez(o sea de derecha a la izquierda).
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click '<--Limpia los textbox, el rich
        txCodCli.Clear()
        txNomCli.Clear()
        rtxDirCli.Clear()
        txTelCli.Clear()
        txCorreoCli.Clear()
    End Sub

    Private Sub txNomCli_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txNomCli.KeyPress
        SoloLetras(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub txCorreoCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCorreoCli.KeyPress
        SoloLetrascorreo(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub txCorreoCli_TextChanged(sender As Object, e As EventArgs) Handles txCorreoCli.TextChanged
        LbContador6.Text = txCorreoCli.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        txCorreoCli.Text = Minusculas(txCorreoCli.Text, txCorreoCli) '<--Validacion solo minusculas.
    End Sub

    Private Sub txTelCli_TextChanged(sender As Object, e As EventArgs) Handles txTelCli.TextChanged
        LbContador.Text = txTelCli.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub rtxDirCli_TextChanged(sender As Object, e As EventArgs) Handles rtxDirCli.TextChanged
        LbContador2.Text = rtxDirCli.Text.Length '<-- Muestra la cantidad de caracteres escritas en richtextbox.
    End Sub

    Private Sub DGVCliente_DoubleClick(sender As Object, e As EventArgs) Handles DGVCliente.DoubleClick '<-- Con doble clic manda campos del DataGridView a los textbox referidos.
        txCodCli.Text = DGVCliente.CurrentRow.Cells(0).Value
        txNomCli.Text = DGVCliente.CurrentRow.Cells(1).Value
        rtxDirCli.Text = DGVCliente.CurrentRow.Cells(2).Value
        txTelCli.Text = DGVCliente.CurrentRow.Cells(3).Value
        txCorreoCli.Text = DGVCliente.CurrentRow.Cells(4).Value
    End Sub

    Public Function Cuantas(ByVal Letra As String, ByVal Cad As String) As Long '<-- Esta funcion es para poder contar cualquier caracter que usted especifique. 
        Cuantas = Len(Cad) - Len(Replace(Cad, Letra, vbNullString))
    End Function

    Private Sub rtxDirCli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtxDirCli.KeyPress '<--Funcion para validar que caracteres son permitidos y evitar que se introduscan espacio al principio. 
        Dim caracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890-,. " & Convert.ToChar(8)
        Dim c As Char = e.KeyChar
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Solo se puede ingresar valores de tipo texto, numericos y caracteres especiales como -,.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.rtxDirCli.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,1,2,3,4,5,6,7,8,9,0," & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios o caracteres especiales al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub
End Class
