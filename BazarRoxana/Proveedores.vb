Imports System.Data.SqlClient
Public Class Proveedores
    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim busqueda As Integer
        busqueda = InputBox("Ingrese Codigo", "Busqueda")



        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select * from Proveedores where CodProv=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
    End Sub

    Private Sub btActualizarTabla_Click(sender As Object, e As EventArgs) Handles btActualizarTabla.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCliente As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosCliente)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosCliente
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Call validar_campos(Me)
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
        If txCodProve.Text = "" Or txNomProv.Text = "" Or TxtTelfonoEmpresa.Text = "" Or txtNombrePreEm.Text = "" Or txCorreoEmpresa.Text = "" Or TxtCorreoProv.Text = "" Or txtTelProv.Text = "" Or RTBDirec.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim ConsultaGuardar As String = "insert into Proveedores(CodProv, NombProv,TelProv, NombContProv,CorreoProv, CorreoContProv, TelContProv, DirecProv,EstadoProv) 
        values(@CodProv, @NombProv, @TelProv, @NombContProv, @CorreoProv, @CorreoContProv, @TelContProv, @DirecProv,1)"
            Dim ejecutar As New SqlCommand(ConsultaGuardar, conec)
            ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))
            ejecutar.Parameters.AddWithValue("@NombProv", (txNomProv.Text))
            ejecutar.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoEmpresa.Text))
            ejecutar.Parameters.AddWithValue("@NombContProv", (txtNombrePreEm.Text))
            ejecutar.Parameters.AddWithValue("@CorreoProv", (txCorreoEmpresa.Text))
            ejecutar.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoProv.Text))
            ejecutar.Parameters.AddWithValue("@TelContProv", Val(txtTelProv.Text))
            ejecutar.Parameters.AddWithValue("@DirecProv", (RTBDirec.Text))

            ejecutar.ExecuteNonQuery()

        End If

    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
        If txCodProve.Text = "" Or txNomProv.Text = "" Or TxtTelfonoEmpresa.Text = "" Or txtNombrePreEm.Text = "" Or txCorreoEmpresa.Text = "" Or TxtCorreoProv.Text = "" Or txtTelProv.Text = "" Or RTBDirec.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim ConsultaActualizar As String = "update Proveedores set NombProv=@NombProv,TelProv=@TelProv, NombContProv=@NombContProv, CorreoProv=@CorreoProv, CorreoContProv=@CorreoContProv, TelContProv=@TelContProv, DirecProv=@DirecProv where CodProv=@CodProv"
            Dim ejecutar As New SqlCommand(ConsultaActualizar, conec)
            ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))
            ejecutar.Parameters.AddWithValue("@NombProv", (txNomProv.Text))
            ejecutar.Parameters.AddWithValue("@TelProv", Val(TxtTelfonoEmpresa.Text))
            ejecutar.Parameters.AddWithValue("@NombContProv", (txtNombrePreEm.Text))
            ejecutar.Parameters.AddWithValue("@CorreoProv", (txCorreoEmpresa.Text))
            ejecutar.Parameters.AddWithValue("@CorreoContProv", (TxtCorreoProv.Text))
            ejecutar.Parameters.AddWithValue("@TelContProv", Val(txtTelProv.Text))
            ejecutar.Parameters.AddWithValue("@DirecProv", (RTBDirec.Text))

            ejecutar.ExecuteNonQuery()

        End If

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=AMAYA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()
        Dim DatosProveedor As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Proveedores", conec)
            adaptador.Fill(DatosProveedor)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGVProveedores.DataSource = DatosProveedor
        If txCodProve.Text = "" Then
            MsgBox("Hay campos vacios")
        Else

            Dim ConsultaEliminar As String = "delete from Proveedores where CodProv=@CodProv"
            Dim ejecutar As New SqlCommand(ConsultaEliminar, conec)
            ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProve.Text))

            ejecutar.ExecuteNonQuery()

        End If

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub DGVProveedores_DoubleClick(sender As Object, e As EventArgs) Handles DGVProveedores.DoubleClick
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

    Private Sub txCodProve_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCodProve.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txNomProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txNomProv.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TxtTelfonoEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelfonoEmpresa.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtNombrePreEm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombrePreEm.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtTelProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelProv.KeyPress
        SoloNumeros(e)
    End Sub
    Private Function validar_campos(T As Control) As Boolean

        For Each T In Me.Controls
            If TypeOf T Is TextBox Then
                If Trim(T.Text) = "" Then
                    MsgBox("Campo por validar", vbInformation)
                    'Else   
                    '    MessageBox.Show("Dot Net Perls is awesome.")
                End If
            Else
                ' mesagebox aqui hay otro control diferente de textbox

            End If
        Next
    End Function
End Class