Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AbrirConeccion() '<-- Llamado de la funcion 
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
        ConexionBase.Close()
        BtnHabilitar.Visible = False
        BtnActualizar.Visible = False
        BtnEliminar.Visible = False
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim mail As New System.Net.Mail.MailAddress(TxtCorreoempresa.Text) '<-Validar el correro de la empresa
            Dim mail2 As New System.Net.Mail.MailAddress(TxtCorreoprov.Text) '<-Validar el correro del empleado del proveedor
            AbrirConeccion()
            If (TxtNomprov.TextLength < 3) Then
                MsgBox("Debe ingresar como mínimo 3 letras en nombre de la empreaa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtTelfonoempresa.TextLength < 8) Then
                MsgBox("Debe ingresar como mínimo 8 números en el teléfono de la empresa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtCorreoempresa.TextLength < 10) Then
                MsgBox("Debe ingresar como mínimo 10 caracteres en el correo de la empresa.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtNombreproem.TextLength < 3) Then
                MsgBox("Debe ingresar como mínimo 3 letras en el nombre del proveedor(empleado(a)).", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtTelprov.TextLength < 8) Then
                MsgBox("Debe ingresar como mínimo 8 números en el teléfono del proveedor.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (RtbDirec.TextLength < 8) Then
                MsgBox("Debe ingresar como mínimo 10 caracteres en la dirección de la empresa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", TxtCorreoprov.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Cuantas(".", TxtCorreoempresa.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                If TxtNomprov.Text = "" Or TxtTelfonoempresa.Text = "" Or TxtNombreproem.Text = "" Or TxtCorreoempresa.Text = "" Or TxtCorreoprov.Text = "" Or TxtTelprov.Text = "" Or RtbDirec.Text = "" Then
                    MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
                Else
                    If RegistradoProveedores(TxtCodprov.Text) = False Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.
                        Dim ConsultaGuardar As String = "insert into Proveedores( NombProv,TelProv, NombContProv,CorreoProv, CorreoContProv, TelContProv, DirecProv,EstadoProv) values(@NombProv, @TelProv, @NombContProv, @CorreoProv, @CorreoContProv, @TelContProv, @DirecProv,1)"
                        'Toma los valores de los textbox y el richtextbox y los guardas en la base de datos. 
                        Dim EjecutarCon As New SqlCommand(ConsultaGuardar, ConexionBase)
                        EjecutarCon.Parameters.AddWithValue("@NombProv", (TxtNomprov.Text))
                        EjecutarCon.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoempresa.Text))
                        EjecutarCon.Parameters.AddWithValue("@NombContProv", (TxtNombreproem.Text))
                        EjecutarCon.Parameters.AddWithValue("@CorreoProv", (TxtCorreoempresa.Text))
                        EjecutarCon.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoprov.Text))
                        EjecutarCon.Parameters.AddWithValue("@TelContProv", Val(TxtTelprov.Text))
                        EjecutarCon.Parameters.AddWithValue("@DirecProv", (RtbDirec.Text))

                        EjecutarCon.ExecuteNonQuery()
                        MsgBox("El proveedor se a guardado", MsgBoxStyle.Information, "Registro exitoso.")
                        BtnActualizar.Visible = False
                    Else
                        MsgBox("El Proveedor ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                        BtnActualizar.Visible = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnEliminar.Visible = False
        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor

        ConexionBase.Close()
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        AbrirConeccion() '<-- Llamado de la funcion 
        If TxtCodprov.Text = String.Empty Then
            MsgBox("Por favor haga doble click a una fila de la tabla antes de modificar algún dato deseado.", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            Try
                Dim Mail As New System.Net.Mail.MailAddress(TxtCorreoempresa.Text) '<-Validar el correro de la empresa
                Dim Mail2 As New System.Net.Mail.MailAddress(TxtCorreoprov.Text) '<-Validar el correro del empleado del proveedor
                AbrirConeccion()
                If (TxtNomprov.TextLength < 3) Then
                    MsgBox("Debe ingresar como mínimo 3 letras en nombre de la empreaa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (TxtTelfonoempresa.TextLength < 8) Then
                    MsgBox("Debe ingresar como mínimo 8 números en el teléfono de la empresa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (TxtCorreoempresa.TextLength < 10) Then
                    MsgBox("Debe ingresar como mínimo 10 caracteres en el correo de la empresa.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (TxtNombreproem.TextLength < 3) Then
                    MsgBox("Debe ingresar como mínimo 3 letras en el nombre del proveedor(empleado(a)).", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (TxtTelprov.TextLength < 8) Then
                    MsgBox("Debe ingresar como mínimo 8 números en el teléfono del proveedor.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (RtbDirec.TextLength < 8) Then
                    MsgBox("Debe ingresar como mínimo 10 caracteres en la dirección de la empresa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf Cuantas(".", TxtCorreoprov.Text) > 1 Then
                    MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf Cuantas(".", TxtCorreoempresa.Text) > 1 Then
                    MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If TxtNomprov.Text = "" Or TxtTelfonoempresa.Text = "" Or TxtNombreproem.Text = "" Or TxtCorreoempresa.Text = "" Or TxtCorreoprov.Text = "" Or TxtTelprov.Text = "" Or RtbDirec.Text = "" Then
                        MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
                    Else
                        Dim ConsultaActualizar As String = "update Proveedores set NombProv=@NombProv,TelProv=@TelProv, NombContProv=@NombContProv, CorreoProv=@CorreoProv, CorreoContProv=@CorreoContProv, TelContProv=@TelContProv, DirecProv=@DirecProv, EstadoProv=1 where CodProv=@CodProv"
                        'Toma los valores de los textbox y el richtextbox y los actualiza en la base de datos.
                        Dim EjecutarCon As New SqlCommand(ConsultaActualizar, ConexionBase)
                        EjecutarCon.Parameters.AddWithValue("@CodProv", Val(TxtCodprov.Text))
                        EjecutarCon.Parameters.AddWithValue("@NombProv", (TxtNomprov.Text))
                        EjecutarCon.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoempresa.Text))
                        EjecutarCon.Parameters.AddWithValue("@NombContProv", (TxtNombreproem.Text))
                        EjecutarCon.Parameters.AddWithValue("@CorreoProv", (TxtCorreoempresa.Text))
                        EjecutarCon.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoprov.Text))
                        EjecutarCon.Parameters.AddWithValue("@TelContProv", Val(TxtTelprov.Text))
                        EjecutarCon.Parameters.AddWithValue("@DirecProv", (RtbDirec.Text))
                        EjecutarCon.ExecuteNonQuery()
                        MsgBox("El proveedor se a actualizado", MsgBoxStyle.Information, "Registro exitoso.")
                        BtnGuardar.Visible = False
                        ChkInhabil.Checked = False
                    End If
                End If
            Catch ex As Exception

                MessageBox.Show(ex.Message)
                BtnActualizar.Visible = False
            End Try
        End If
        BtnEliminar.Visible = True
        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
        ConexionBase.Close()
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        AbrirConeccion() '<-- Llamado de la funcion 
        If TxtCodprov.Text = String.Empty Then
            MsgBox("Por favor haga doble click a una fila de la tabla antes de eliminar algún dato deseado.", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            Dim OpcionDia As DialogResult
            OpcionDia = MessageBox.Show("¿Esta Seguro que quiere eliminar este proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If OpcionDia = DialogResult.Yes Then
                If TxtCodprov.Text = "" Then
                    MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
                Else
                    Dim ConsultaEliminar As String = "Update Proveedores set EstadoProv=0  where CodProv=@CodProv"
                    'Toma el valor del textbox y lo deshabilita en la base de datos. 
                    Dim EjecutarCon As New SqlCommand(ConsultaEliminar, ConexionBase)
                    EjecutarCon.Parameters.AddWithValue("@CodProv", Val(TxtCodprov.Text))
                    EjecutarCon.ExecuteNonQuery()
                    'Limpia los textbox, el rich y el checkbox
                    TxtCodprov.Clear()
                    TxtNomprov.Clear()
                    TxtTelfonoempresa.Clear()
                    TxtNombreproem.Clear()
                    TxtCorreoempresa.Clear()
                    TxtCorreoprov.Clear()
                    TxtTelprov.Clear()
                    RtbDirec.Clear()
                    ChkInhabil.Checked = False
                End If
            End If
            BtnEliminar.Visible = False
            BtnActualizar.Visible = False
        End If

        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGVProveedores.DataSource = DatosProveedor
        ConexionBase.Close()
    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles ChkInhabil.CheckedChanged 'Funcion que permite mostrar las habilitados o deshabilitados de la base de datos.
        AbrirConeccion()

        If ChkInhabil.Checked = True Then

            Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=0", ConexionBase)
                adaptador.Fill(DatosProveedor)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVProveedores.DataSource = DatosProveedor
            BtnGuardar.Visible = False
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnHabilitar.Visible = True
        Else

            Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
            Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
                adaptador.Fill(DatosProveedor)
            End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

            DGVProveedores.DataSource = DatosProveedor
            BtnGuardar.Visible = True
            BtnActualizar.Visible = False
            BtnEliminar.Visible = False
            BtnHabilitar.Visible = False
        End If
        ConexionBase.Close()
    End Sub

    Private Sub txCodProve_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtCodprov.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub TxtTelfonoEmpresa_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtTelfonoempresa.KeyPress '<--Valida solo numeros, la entrada del primer número que sea valido.
        SoloNumeros(e) '<-- Llamado de la funcion 
        If Len(Me.TxtTelfonoempresa.Text) = "0" Then
            If InStr(1, "2,3,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("Solo numero inical en 2,3,8 o 9")
            End If
        End If
    End Sub

    Private Sub txtTelProv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtTelprov.KeyPress '<--Valida solo numeros, la entrada del primer número que sea valido.
        SoloNumeros(e) '<-- Llamado de la funcion 
        If Len(Me.TxtTelprov.Text) = "0" Then
            If InStr(1, "2,3,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("Solo numero inical en 2,3,8 o 9")
            End If
        End If
    End Sub

    Public Sub filtrarDatos(ByVal buscar As String) '<-Funcion para filtrar datos que se mostraran en el DataGridView.
        If ChkInhabil.Checked = False Then
            Try
                Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim Query = "select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1 and NombProv LIKE @filtro"
                    Dim Adapter As New SqlDataAdapter(Query, con)
                    Adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))
                    Dim table As New DataTable
                    Adapter.Fill(table)

                    DGVProveedores.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Using con As New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
                    Dim Query = "select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=0 and NombProv LIKE @filtro"
                    Dim Adapter As New SqlDataAdapter(Query, con)
                    Adapter.SelectCommand.Parameters.AddWithValue("@filtro", String.Format("%{0}%", buscar))
                    Dim table As New DataTable
                    Adapter.Fill(table)

                    DGVProveedores.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged '<--Busqueda.
        LabelContador7.Text = TxtBusqueda.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        Dim Filtro As String = CType(sender, TextBox).Text
        If Filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(Filtro)
        Else
            AbrirConeccion() '<-- Llamado de la funcion 
            If ChkInhabil.Checked = True Then
                Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=0", ConexionBase)
                    adaptador.Fill(DatosProveedor)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
                DGVProveedores.DataSource = DatosProveedor
            Else
                Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
                Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
                    adaptador.Fill(DatosProveedor)
                End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
                DGVProveedores.DataSource = DatosProveedor
            End If
        End If
        ConexionBase.Close()
    End Sub

    Private Sub TxtTelfonoEmpresa_TextChanged(sender As Object, e As EventArgs) Handles TxtTelfonoempresa.TextChanged
        LbContador.Text = TxtTelfonoempresa.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txNomProv_TextChanged(sender As Object, e As EventArgs) Handles TxtNomprov.TextChanged
        LabelContador1.Text = TxtNomprov.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txCorreoEmpresa_TextChanged(sender As Object, e As EventArgs) Handles TxtCorreoempresa.TextChanged
        LabelContador2.Text = TxtCorreoempresa.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        TxtCorreoempresa.Text = Minusculas(TxtCorreoempresa.Text, TxtCorreoempresa) '<--Validacion solo minusculas haciendo el llamado a la funcion.
    End Sub

    Private Sub txtTelProv_TextChanged(sender As Object, e As EventArgs) Handles TxtTelprov.TextChanged
        LabelContador3.Text = TxtTelprov.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txtNombrePreEm_TextChanged(sender As Object, e As EventArgs) Handles TxtNombreproem.TextChanged
        LabelContador4.Text = TxtNombreproem.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        TxtNombreproem.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TxtNombreproem.Text) '<-- Evita que se introduzca nombres y apellidos con inicial minisculas. 
        TxtNombreproem.SelectionStart = TxtNombreproem.Text.Length '<-- Evitar que texto ingresado se muestre al revez(o sea de derecha a la izquierda).
    End Sub

    Private Sub TxtCorreoProv_TextChanged(sender As Object, e As EventArgs) Handles TxtCorreoprov.TextChanged
        LabelContador5.Text = TxtCorreoprov.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        TxtCorreoprov.Text = Minusculas(TxtCorreoprov.Text, TxtCorreoprov) '<--Validacion solo minusculas haciendo el llamado a la funcion.
    End Sub

    Private Sub RTBDirec_TextChanged(sender As Object, e As EventArgs) Handles RtbDirec.TextChanged
        LabelContador6.Text = RtbDirec.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txNomProv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtNomprov.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim CaracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890 " & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (CaracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Solo se puede ingresar valores de tipo texto y numericos.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.TxtNomprov.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,0,1,2,3,4,5,6,7,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txCorreoEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorreoempresa.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim CaracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890@._-" & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (CaracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Ingrese solamente letras, numeros, carectes especiales( @ . - _ ).", "ERROR de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True

        End If
    End Sub

    Private Sub TxtCorreoProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorreoprov.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim CaracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890@._-" & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (CaracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Ingrese solamente letras, numeros, carectes especiales( @ . - _ ).", "ERROR de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True

        End If
    End Sub

    Private Sub txtNombrePreEm_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtNombreproem.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim CaracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM " & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (CaracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Solo se puede ingresar valores de tipo texto (solo letras).", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.TxtNombreproem.Text) = "0" Then 'Valida evitar que se introduscan espacio al principio. 
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub RTBDirec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RtbDirec.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim CaracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890-,. " & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (CaracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Solo se puede ingresar valores de tipo texto, numericos y caracteres especiales como -,.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.RtbDirec.Text) = "0" Then 'Valida evitar que se introduscan espacio al principio. 
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,0,1,2,4,3,5,6,7,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click '<-- Funcion que limpias el contenido de los textbox y richtextbox
        TxtCodprov.Clear()
        TxtNomprov.Clear()
        TxtTelfonoempresa.Clear()
        TxtNombreproem.Clear()
        TxtCorreoempresa.Clear()
        TxtCorreoprov.Clear()
        TxtTelprov.Clear()
        TxtBusqueda.Clear()
        RtbDirec.Clear()
        BtnActualizar.Visible = False
        BtnEliminar.Visible = False
        BtnGuardar.Visible = True
    End Sub

    Private Sub DGVProveedores_DoubleClick_1(sender As Object, e As EventArgs) Handles DGVProveedores.DoubleClick '<-- Con doble click en el DataGridView manda campos del DataGridView a los textbox referidos.
        TxtCodprov.Text = DGVProveedores.CurrentRow.Cells(0).Value
        TxtNomprov.Text = DGVProveedores.CurrentRow.Cells(1).Value
        TxtTelfonoempresa.Text = DGVProveedores.CurrentRow.Cells(2).Value
        TxtNombreproem.Text = DGVProveedores.CurrentRow.Cells(3).Value
        TxtCorreoempresa.Text = DGVProveedores.CurrentRow.Cells(4).Value
        TxtCorreoprov.Text = DGVProveedores.CurrentRow.Cells(5).Value
        TxtTelprov.Text = DGVProveedores.CurrentRow.Cells(6).Value
        RtbDirec.Text = DGVProveedores.CurrentRow.Cells(7).Value
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
    Public Function Cuantas(ByVal Letra As String, ByVal Cad As String) As Long
        Cuantas = Len(Cad) - Len(Replace(Cad, Letra, vbNullString)) '<-- Esta funcion es para poder contar cualquier caracter que usted especifique para que no se repita en el texto. 
    End Function

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim CaracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890 " & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (CaracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Solo se puede ingresar valores de tipo texto y numericos.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.TxtNomprov.Text) = "0" Then 'Valida evitar que se introduscan espacio al principio. 
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,0,1,2,3,4,5,6,7,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles BtnHabilitar.Click '<-- Permite habilitar datos deshabilitados en la base de datos 
        AbrirConeccion()
        Dim OpcionDia As DialogResult
        OpcionDia = MessageBox.Show("¿Está seguro que quiere habilitar este proveedor?", "Habilitar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OpcionDia = DialogResult.Yes Then
            If TxtCodprov.Text = "" Then
                MsgBox("Hay campos vacios", MsgBoxStyle.Exclamation, "Advertencia")
            Else
                Dim ConsultaHabilitar As String = "Update Proveedores set EstadoProv=1  where CodProv=@CodProv"
                'Toma el valor del textbox y lo habilita en la base de datos. 
                Dim EjecutarCon As New SqlCommand(ConsultaHabilitar, ConexionBase)
                EjecutarCon.Parameters.AddWithValue("@CodProv", Val(TxtCodprov.Text))
                EjecutarCon.ExecuteNonQuery()
                'Limpia los textbox, el rich y el checkbox
                TxtCodprov.Clear()
                TxtNomprov.Clear()
                TxtTelfonoempresa.Clear()
                TxtNombreproem.Clear()
                TxtCorreoempresa.Clear()
                TxtCorreoprov.Clear()
                TxtTelprov.Clear()
                RtbDirec.Clear()
                ChkInhabil.Checked = False
            End If
        End If
        ChkInhabil.Checked = False
        BtnEliminar.Visible = False
        BtnActualizar.Visible = False
        ConexionBase.Close()
    End Sub
End Class