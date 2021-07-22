Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkEstado.Checked = True
        AbrirConeccion() '<-- Llamado de la funcion 
        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
        ConexionBase.Close()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            Dim mail As New System.Net.Mail.MailAddress(txCorreoEmpresa.Text) '<-Validar el correro de la empresa
            Dim mail2 As New System.Net.Mail.MailAddress(TxtCorreoProv.Text) '<-Validar el correro del empleado del proveedor
            AbrirConeccion()
            If (txNomProv.TextLength < 3) Then
                MsgBox("Debe ingresar como mínimo 3 letras en nombre de la empreaa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (TxtTelfonoEmpresa.TextLength < 8) Then
                MsgBox("Debe ingresar como mínimo 8 números en el teléfono de la empresa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txCorreoEmpresa.TextLength < 10) Then
                MsgBox("Debe ingresar como mínimo 10 caracteres en el correo de la empresa.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtNombrePreEm.TextLength < 3) Then
                MsgBox("Debe ingresar como mínimo 3 letras en el nombre del proveedor(empleado(a)).", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (txtTelProv.TextLength < 8) Then
                MsgBox("Debe ingresar como mínimo 8 números en el teléfono del proveedor.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf (RTBDirec.TextLength < 8) Then
                MsgBox("Debe ingresar como mínimo 10 caracteres en la dirección de la empresa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
            ElseIf Cuantas(".", TxtCorreoProv.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Cuantas(".", txCorreoEmpresa.Text) > 1 Then
                MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                If txNomProv.Text = "" Or TxtTelfonoEmpresa.Text = "" Or txtNombrePreEm.Text = "" Or txCorreoEmpresa.Text = "" Or TxtCorreoProv.Text = "" Or txtTelProv.Text = "" Or RTBDirec.Text = "" Or chkEstado.Checked = False Then
                    MsgBox("Hay campos vacios")
                Else
                    If RegistradoProveedores(txCodProve.Text) = False Then '<-- Llamado de funcion que verifica si el codigo ya esta repetido en la base de datos.
                        Dim ConsultaGuardar As String = "insert into Proveedores( NombProv,TelProv, NombContProv,CorreoProv, CorreoContProv, TelContProv, DirecProv,EstadoProv) values(@NombProv, @TelProv, @NombContProv, @CorreoProv, @CorreoContProv, @TelContProv, @DirecProv,1)"
                        'Toma los valores de los textbox y el richtextbox y los guardas en la base de datos. 
                        Dim ejecutar As New SqlCommand(ConsultaGuardar, ConexionBase)
                        ejecutar.Parameters.AddWithValue("@NombProv", (txNomProv.Text))
                        ejecutar.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoEmpresa.Text))
                        ejecutar.Parameters.AddWithValue("@NombContProv", (txtNombrePreEm.Text))
                        ejecutar.Parameters.AddWithValue("@CorreoProv", (txCorreoEmpresa.Text))
                        ejecutar.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoProv.Text))
                        ejecutar.Parameters.AddWithValue("@TelContProv", Val(txtTelProv.Text))
                        ejecutar.Parameters.AddWithValue("@DirecProv", (RTBDirec.Text))

                        ejecutar.ExecuteNonQuery()
                        MsgBox("El proveedor se a guardado", MsgBoxStyle.Information, "Registro exitoso.")
                    Else
                        MsgBox("El Proveedor ya esta registrado", MsgBoxStyle.Exclamation, "Advertencia")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor

        ConexionBase.Close()
    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        AbrirConeccion() '<-- Llamado de la funcion 
        If txCodProve.Text = String.Empty Then
            MsgBox("Por favor haga doble click a una fila de la tabla antes de modificar algún dato deseado.", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            Try
                Dim mail As New System.Net.Mail.MailAddress(txCorreoEmpresa.Text) '<-Validar el correro de la empresa
                Dim mail2 As New System.Net.Mail.MailAddress(TxtCorreoProv.Text) '<-Validar el correro del empleado del proveedor
                AbrirConeccion()
                If (txNomProv.TextLength < 3) Then
                    MsgBox("Debe ingresar como mínimo 3 letras en nombre de la empreaa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (TxtTelfonoEmpresa.TextLength < 8) Then
                    MsgBox("Debe ingresar como mínimo 8 números en el teléfono de la empresa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (txCorreoEmpresa.TextLength < 10) Then
                    MsgBox("Debe ingresar como mínimo 10 caracteres en el correo de la empresa.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (txtNombrePreEm.TextLength < 3) Then
                    MsgBox("Debe ingresar como mínimo 3 letras en el nombre del proveedor(empleado(a)).", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (txtTelProv.TextLength < 8) Then
                    MsgBox("Debe ingresar como mínimo 8 números en el teléfono del proveedor.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf (RTBDirec.TextLength < 8) Then
                    MsgBox("Debe ingresar como mínimo 10 caracteres en la dirección de la empresa proveedora.", MsgBoxStyle.Exclamation, "Advertencia")
                ElseIf Cuantas(".", TxtCorreoProv.Text) > 1 Then
                    MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ElseIf Cuantas(".", txCorreoEmpresa.Text) > 1 Then
                    MessageBox.Show("No podes ingresar mas de 1 punto", "Error de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If txNomProv.Text = "" Or TxtTelfonoEmpresa.Text = "" Or txtNombrePreEm.Text = "" Or txCorreoEmpresa.Text = "" Or TxtCorreoProv.Text = "" Or txtTelProv.Text = "" Or RTBDirec.Text = "" Then
                        MsgBox("Hay campos vacios")
                    Else
                        Dim estado As Integer
                        If chkEstado.Checked = True Then 'El estado del checkbox de estado es capturado en valor numerico uno o cero a traves de la variable estado.
                            estado = 1
                        Else
                            estado = 0
                        End If
                        Dim ConsultaActualizar As String = "update Proveedores set NombProv=@NombProv,TelProv=@TelProv, NombContProv=@NombContProv, CorreoProv=@CorreoProv, CorreoContProv=@CorreoContProv, TelContProv=@TelContProv, DirecProv=@DirecProv, EstadoProv=@EstadoProv where CodProv=@CodProv"
                        'Toma los valores de los textbox y el richtextbox y los actualiza en la base de datos.
                        Dim ejecutar As New SqlCommand(ConsultaActualizar, ConexionBase)
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
                        MsgBox("El proveedor se a actualizado")
                        chkInhabil.Checked = False
                    End If
                End If
            Catch ex As Exception

                MessageBox.Show(ex.Message)
            End Try
        End If

        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
        ConexionBase.Close()
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        AbrirConeccion() '<-- Llamado de la funcion 
        If txCodProve.Text = String.Empty Then
            MsgBox("Por favor haga doble click a una fila de la tabla antes de eliminar algún dato deseado.", MsgBoxStyle.Exclamation, "Advertencia")
        Else
            Dim opcion As DialogResult
            opcion = MessageBox.Show("¿Esta Seguro que quiere eliminar este proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If opcion = DialogResult.Yes Then
                If txCodProve.Text = "" Then
                    MsgBox("Hay campos vacios")
                Else
                    Dim ConsultaEliminar As String = "Update Proveedores set EstadoProv=0  where CodProv=@CodProv"
                    'Toma el valor del textbox y lo deshabilita en la base de datos. 
                    Dim ejecutar As New SqlCommand(ConsultaEliminar, ConexionBase)
                    ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))
                    ejecutar.ExecuteNonQuery()
                    'Limpia los textbox, el rich y el checkbox
                    txCodProve.Clear()
                    txNomProv.Clear()
                    TxtTelfonoEmpresa.Clear()
                    txtNombrePreEm.Clear()
                    txCorreoEmpresa.Clear()
                    TxtCorreoProv.Clear()
                    txtTelProv.Clear()
                    RTBDirec.Clear()
                    chkInhabil.Checked = False
                End If
            End If
        End If

        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", ConexionBase)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        DGVProveedores.DataSource = DatosProveedor
        ConexionBase.Close()
    End Sub

    Private Sub chkInhabil_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabil.CheckedChanged 'Funcion que permite mostrar las habilitados o deshabilitados de la base de datos.
        AbrirConeccion()

        If chkInhabil.Checked = True Then

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
        ConexionBase.Close()
    End Sub

    Private Sub txCodProve_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txCodProve.KeyPress
        SoloNumeros(e) '<-- Llamado de la funcion 
    End Sub

    Private Sub TxtTelfonoEmpresa_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtTelfonoEmpresa.KeyPress '<--Valida solo numeros, la entrada del primer número que sea valido.
        SoloNumeros(e) '<-- Llamado de la funcion 
        If Len(Me.TxtTelfonoEmpresa.Text) = "0" Then
            If InStr(1, "2,3,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("Solo numero inical en 2,3,8 o 9")
            End If
        End If
    End Sub

    Private Sub txtTelProv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtTelProv.KeyPress '<--Valida solo numeros, la entrada del primer número que sea valido.
        SoloNumeros(e) '<-- Llamado de la funcion 
        If Len(Me.txtTelProv.Text) = "0" Then
            If InStr(1, "2,3,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("Solo numero inical en 2,3,8 o 9")
            End If
        End If
    End Sub

    Public Sub filtrarDatos(ByVal buscar As String) '<-Funcion para filtrar datos que se mostraran en el DataGridView.
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

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged '<--Busqueda.
        Labelcontador7.Text = TxtBusqueda.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        Dim filtro As String = CType(sender, TextBox).Text
        If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(filtro)
        Else
            AbrirConeccion() '<-- Llamado de la funcion 
            If chkInhabil.Checked = True Then
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

    Private Sub TxtTelfonoEmpresa_TextChanged(sender As Object, e As EventArgs) Handles TxtTelfonoEmpresa.TextChanged
        LbContador.Text = TxtTelfonoEmpresa.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txNomProv_TextChanged(sender As Object, e As EventArgs) Handles txNomProv.TextChanged
        Labelcontador1.Text = txNomProv.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txCorreoEmpresa_TextChanged(sender As Object, e As EventArgs) Handles txCorreoEmpresa.TextChanged
        Labelcontador2.Text = txCorreoEmpresa.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        txCorreoEmpresa.Text = Minusculas(txCorreoEmpresa.Text, txCorreoEmpresa) '<--Validacion solo minusculas haciendo el llamado a la funcion.
    End Sub

    Private Sub txtTelProv_TextChanged(sender As Object, e As EventArgs) Handles txtTelProv.TextChanged
        Labelcontador3.Text = txtTelProv.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txtNombrePreEm_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePreEm.TextChanged
        Labelcontador4.Text = txtNombrePreEm.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        txtNombrePreEm.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombrePreEm.Text) '<-- Evita que se introduzca nombres y apellidos con inicial minisculas. 
        txtNombrePreEm.SelectionStart = txtNombrePreEm.Text.Length '<-- Evitar que texto ingresado se muestre al revez(o sea de derecha a la izquierda).
    End Sub

    Private Sub TxtCorreoProv_TextChanged(sender As Object, e As EventArgs) Handles TxtCorreoProv.TextChanged
        Labelcontador5.Text = TxtCorreoProv.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
        TxtCorreoProv.Text = Minusculas(TxtCorreoProv.Text, TxtCorreoProv) '<--Validacion solo minusculas haciendo el llamado a la funcion.
    End Sub

    Private Sub RTBDirec_TextChanged(sender As Object, e As EventArgs) Handles RTBDirec.TextChanged
        Labelcontador6.Text = RTBDirec.Text.Length '<-- Muestra la cantidad de caracteres escritas en textbox.
    End Sub

    Private Sub txNomProv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txNomProv.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim caracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890 " & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (caracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Solo se puede ingresar valores de tipo texto y numericos.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.txNomProv.Text) = "0" Then
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,0,1,2,3,4,5,6,7,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub txCorreoEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCorreoEmpresa.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim caracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890@._-" & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (caracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Ingrese solamente letras, numeros, carectes especiales( @ . - _ ).", "ERROR de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True

        End If
    End Sub

    Private Sub TxtCorreoProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorreoProv.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim caracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890@._-" & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (caracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Ingrese solamente letras, numeros, carectes especiales( @ . - _ ).", "ERROR de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True

        End If
    End Sub

    Private Sub txtNombrePreEm_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtNombrePreEm.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim caracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM " & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (caracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Solo se puede ingresar valores de tipo texto (solo letras).", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.txtNombrePreEm.Text) = "0" Then 'Valida evitar que se introduscan espacio al principio. 
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub RTBDirec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTBDirec.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim caracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890-,. " & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (caracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Solo se puede ingresar valores de tipo texto, numericos y caracteres especiales como -,.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.RTBDirec.Text) = "0" Then 'Valida evitar que se introduscan espacio al principio. 
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,0,1,2,4,3,5,6,7,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click '<-- Funcion que limpias el contenido de los textbox y richtextbox
        txCodProve.Clear()
        txNomProv.Clear()
        TxtTelfonoEmpresa.Clear()
        txtNombrePreEm.Clear()
        txCorreoEmpresa.Clear()
        TxtCorreoProv.Clear()
        txtTelProv.Clear()
        TxtBusqueda.Clear()
        RTBDirec.Clear()
    End Sub

    Private Sub DGVProveedores_DoubleClick_1(sender As Object, e As EventArgs) Handles DGVProveedores.DoubleClick '<-- Con doble click en el DataGridView manda campos del DataGridView a los textbox referidos.
        txCodProve.Text = DGVProveedores.CurrentRow.Cells(0).Value
        txNomProv.Text = DGVProveedores.CurrentRow.Cells(1).Value
        TxtTelfonoEmpresa.Text = DGVProveedores.CurrentRow.Cells(2).Value
        txtNombrePreEm.Text = DGVProveedores.CurrentRow.Cells(3).Value
        txCorreoEmpresa.Text = DGVProveedores.CurrentRow.Cells(4).Value
        TxtCorreoProv.Text = DGVProveedores.CurrentRow.Cells(5).Value
        txtTelProv.Text = DGVProveedores.CurrentRow.Cells(6).Value
        RTBDirec.Text = DGVProveedores.CurrentRow.Cells(7).Value
    End Sub
    Public Function Cuantas(ByVal Letra As String, ByVal Cad As String) As Long
        Cuantas = Len(Cad) - Len(Replace(Cad, Letra, vbNullString)) '<-- Esta funcion es para poder contar cualquier caracter que usted especifique para que no se repita en el texto. 
    End Function

    Private Sub TxtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBusqueda.KeyPress
        ' Lista con los caracteres que deseo permitir.
        Dim caracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890 " & Convert.ToChar(8)
        ' Carácter presionado.
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        If (Not (caracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Solo se puede ingresar valores de tipo texto y numericos.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Deshechamos el carácter
            e.Handled = True
        ElseIf Len(Me.txNomProv.Text) = "0" Then 'Valida evitar que se introduscan espacio al principio. 
            If InStr(1, "Q,W,E,R,T,Y,U,I,O,P,A,S,D,F,G,H,J,K,L,Ñ,Z,X,C,V,B,N,M,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,ñ,z,x,c,v,b,n,m,0,1,2,3,4,5,6,7,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("No ingreses espacios al principio", MsgBoxStyle.Exclamation, "Advertencia")
            End If
        End If
    End Sub
End Class