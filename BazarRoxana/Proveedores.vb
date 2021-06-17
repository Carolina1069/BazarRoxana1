Imports System.Data.SqlClient
Imports System.Net.Mail
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
        TxtBusqueda.Clear()
        chkEstado.Checked = True


    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            Dim mail As New System.Net.Mail.MailAddress(txCorreoEmpresa.Text)
            Dim mail2 As New System.Net.Mail.MailAddress(TxtCorreoProv.Text)
            abrir()
            If (txNomProv.TextLength < 3) Then
                MessageBox.Show("Debe ingresar como mínimo 3 letras en nombre de la empreaa proveedora.")
            ElseIf (TxtTelfonoEmpresa.TextLength < 8) Then
                MessageBox.Show("Debe ingresar como mínimo 8 números en el teléfono de la empresa proveedora.")
            ElseIf (txCorreoEmpresa.TextLength < 10) Then
                MessageBox.Show("Debe ingresar como mínimo 10 caracteres en el correo de la empresa.")
            ElseIf (txtNombrePreEm.TextLength < 3) Then
                MessageBox.Show("Debe ingresar como mínimo 3 letras en el nombre del proveedor(empleado(a)).")
            ElseIf (txtTelProv.TextLength < 8) Then
                MessageBox.Show("Debe ingresar como mínimo 8 números en el teléfono del proveedor.")
            ElseIf (RTBDirec.TextLength < 8) Then
                MessageBox.Show("Debe ingresar como mínimo 10 caracteres en la dirección de la empresa proveedora.")
            Else
                If txNomProv.Text = "" Or TxtTelfonoEmpresa.Text = "" Or txtNombrePreEm.Text = "" Or txCorreoEmpresa.Text = "" Or TxtCorreoProv.Text = "" Or txtTelProv.Text = "" Or RTBDirec.Text = "" Or chkEstado.Checked = False Then
                    MsgBox("Hay campos vacios")
                Else
                    If RegistradoProveedores(txCodProve.Text) = False Then
                        Dim ConsultaGuardar As String = "insert into Proveedores( NombProv,TelProv, NombContProv,CorreoProv, CorreoContProv, TelContProv, DirecProv,EstadoProv) values(@NombProv, @TelProv, @NombContProv, @CorreoProv, @CorreoContProv, @TelContProv, @DirecProv,1)"
                        Dim ejecutar As New SqlCommand(ConsultaGuardar, conexion)
                        'ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))
                        ejecutar.Parameters.AddWithValue("@NombProv", (txNomProv.Text))
                        ejecutar.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoEmpresa.Text))
                        ejecutar.Parameters.AddWithValue("@NombContProv", (txtNombrePreEm.Text))
                        ejecutar.Parameters.AddWithValue("@CorreoProv", (txCorreoEmpresa.Text))
                        ejecutar.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoProv.Text))
                        ejecutar.Parameters.AddWithValue("@TelContProv", Val(txtTelProv.Text))
                        ejecutar.Parameters.AddWithValue("@DirecProv", (RTBDirec.Text))

                        ejecutar.ExecuteNonQuery()
                        MsgBox("El proveedor se a guardado")
                    Else
                        MsgBox("El Proveedor ya esta registrado")
                    End If
                End If
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try



        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", conexion)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor

        conexion.Close()




    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        abrir()
        Try
            Dim mail As New System.Net.Mail.MailAddress(txCorreoEmpresa.Text)
            Dim mail2 As New System.Net.Mail.MailAddress(TxtCorreoProv.Text)
            abrir()
            If (txNomProv.TextLength < 3) Then
                MessageBox.Show("Debe ingresar como mínimo 3 letras en nombre de la empreaa proveedora.")
            ElseIf (TxtTelfonoEmpresa.TextLength < 8) Then
                MessageBox.Show("Debe ingresar como mínimo 8 números en el teléfono de la empresa proveedora.")
            ElseIf (txCorreoEmpresa.TextLength < 10) Then
                MessageBox.Show("Debe ingresar como mínimo 10 caracteres en el correo de la empresa.")
            ElseIf (txtNombrePreEm.TextLength < 3) Then
                MessageBox.Show("Debe ingresar como mínimo 3 letras en el nombre del proveedor(empleado(a)).")
            ElseIf (txtTelProv.TextLength < 8) Then
                MessageBox.Show("Debe ingresar como mínimo 8 números en el teléfono del proveedor.")
            ElseIf (RTBDirec.TextLength < 8) Then
                MessageBox.Show("Debe ingresar como mínimo 10 caracteres en la dirección de la empresa proveedora.")
            Else
                If txNomProv.Text = "" Or TxtTelfonoEmpresa.Text = "" Or txtNombrePreEm.Text = "" Or txCorreoEmpresa.Text = "" Or TxtCorreoProv.Text = "" Or txtTelProv.Text = "" Or RTBDirec.Text = "" Then
                    MsgBox("Hay campos vacios")
                Else
                    Dim estado As Integer

                    If chkEstado.Checked = True Then

                        estado = 1
                    Else

                        estado = 0
                    End If
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
                    MsgBox("El proveedor se a actualizado")
                    chkInhabil.Checked = False
                End If
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try



        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", conexion)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
        conexion.Close()

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        abrir()
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere eliminar este proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            If txCodProve.Text = "" Then
                MsgBox("Hay campos vacios")
            Else

                Dim ConsultaEliminar As String = "Update Proveedores set EstadoProv=0  where CodProv=@CodProv"
                Dim ejecutar As New SqlCommand(ConsultaEliminar, conexion)
                ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))

                ejecutar.ExecuteNonQuery()
                txCodProve.Clear()
                txNomProv.Clear()
                TxtTelfonoEmpresa.Clear()
                txtNombrePreEm.Clear()
                txCorreoEmpresa.Clear()
                TxtCorreoProv.Clear()
                txtTelProv.Clear()
                RTBDirec.Clear()
                chkEstado.Checked = True
                chkInhabil.Checked = True
            End If
        End If
        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProv as 'Codigo del Proveedor', NombProv as 'Nombre de Empresa Proveedora', TelProv as 'Telefono de Empresa Proveedora', NombContProv as 'Nombre del Empleado del Proveedor', CorreoProv as 'Correo de la Empresa Proveedora',CorreoContProv as 'Correo del Empleado del Proveedor', TelContProv as 'Telefono del Empleado del Proveedor', DirecProv as 'Direccion de la Empresa Proveedora', case when EstadoProv=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del Proveedor' from Proveedores where EstadoProv=1", conexion)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
        conexion.Close()



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
        If Len(Me.TxtTelfonoEmpresa.Text) = "0" Then
            If InStr(1, "2,3,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("Solo numero inical en 2,3,8 o 9")
            End If
        End If
    End Sub

    Private Sub txtTelProv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtTelProv.KeyPress
        SoloNumeros(e)
        If Len(Me.txtTelProv.Text) = "0" Then
            If InStr(1, "2,3,8,9" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = ""
                MsgBox("Solo numero inical en 2,3,8 o 9")
            End If
        End If
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
        Labelcontador7.Text = TxtBusqueda.Text.Length
        Dim filtro As String = CType(sender, TextBox).Text
        If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
            filtrarDatos(filtro)
        End If
    End Sub

    Private Sub TxtTelfonoEmpresa_TextChanged(sender As Object, e As EventArgs) Handles TxtTelfonoEmpresa.TextChanged
        LbContador.Text = TxtTelfonoEmpresa.Text.Length
    End Sub

    Private Sub txNomProv_TextChanged(sender As Object, e As EventArgs) Handles txNomProv.TextChanged
        Labelcontador1.Text = txNomProv.Text.Length
    End Sub

    Private Sub txCorreoEmpresa_TextChanged(sender As Object, e As EventArgs) Handles txCorreoEmpresa.TextChanged
        Labelcontador2.Text = txCorreoEmpresa.Text.Length
    End Sub

    Private Sub txtTelProv_TextChanged(sender As Object, e As EventArgs) Handles txtTelProv.TextChanged
        Labelcontador3.Text = txtTelProv.Text.Length
    End Sub

    Private Sub txtNombrePreEm_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePreEm.TextChanged
        Labelcontador4.Text = txtNombrePreEm.Text.Length
    End Sub

    Private Sub TxtCorreoProv_TextChanged(sender As Object, e As EventArgs) Handles TxtCorreoProv.TextChanged
        Labelcontador5.Text = TxtCorreoProv.Text.Length
    End Sub

    Private Sub RTBDirec_TextChanged(sender As Object, e As EventArgs) Handles RTBDirec.TextChanged
        Labelcontador6.Text = RTBDirec.Text.Length

    End Sub

    Private Sub txNomProv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txNomProv.KeyPress
        Dim caracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM123456789 " & Convert.ToChar(8)
        Dim c As Char = e.KeyChar
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Solo se puede ingresar valores de tipo texto y numericos.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True

        End If
    End Sub

    Private Sub txCorreoEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCorreoEmpresa.KeyPress

        Dim caracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890@._-" & Convert.ToChar(8)
        Dim c As Char = e.KeyChar
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Ingrese solamente letras, numeros, carectes especiales( @ . - _ ).", "ERROR de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True

        End If
    End Sub

    Private Sub TxtCorreoProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorreoProv.KeyPress
        Dim caracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890@._-" & Convert.ToChar(8)
        Dim c As Char = e.KeyChar
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Ingrese solamente letras, numeros, carectes especiales( @ . - _ ).", "ERROR de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Handled = True

        End If
    End Sub

    Private Sub txtNombrePreEm_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtNombrePreEm.KeyPress
        Dim caracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM123456789 " & Convert.ToChar(8)
        Dim c As Char = e.KeyChar
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Solo se puede ingresar valores de tipo texto y numericos.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True

        End If
    End Sub

    Private Sub RTBDirec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTBDirec.KeyPress
        Dim caracteresPermitidos As String = "áéíóúÁÉÍÓÚqwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM123456789-,. " & Convert.ToChar(8)
        Dim c As Char = e.KeyChar
        If (Not (caracteresPermitidos.Contains(c))) Then

            MessageBox.Show("Solo se puede ingresar valores de tipo texto, numericos y caracteres especiales como -,.", "ERROR de escritura",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            ' Deshechamos el carácter
            e.Handled = True

        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        txCodProve.Clear()
        txNomProv.Clear()
        TxtTelfonoEmpresa.Clear()
        txtNombrePreEm.Clear()
        txCorreoEmpresa.Clear()
        TxtCorreoProv.Clear()
        txtTelProv.Clear()
        TxtBusqueda.Clear()
        RTBDirec.Clear()
        chkEstado.Checked = True
    End Sub

    Private Sub DGVProveedores_DoubleClick_1(sender As Object, e As EventArgs) Handles DGVProveedores.DoubleClick
        txCodProve.Text = DGVProveedores.CurrentRow.Cells(0).Value
        txNomProv.Text = DGVProveedores.CurrentRow.Cells(1).Value
        TxtTelfonoEmpresa.Text = DGVProveedores.CurrentRow.Cells(2).Value
        txtNombrePreEm.Text = DGVProveedores.CurrentRow.Cells(3).Value
        txCorreoEmpresa.Text = DGVProveedores.CurrentRow.Cells(4).Value
        TxtCorreoProv.Text = DGVProveedores.CurrentRow.Cells(5).Value
        txtTelProv.Text = DGVProveedores.CurrentRow.Cells(6).Value
        RTBDirec.Text = DGVProveedores.CurrentRow.Cells(7).Value
    End Sub
End Class