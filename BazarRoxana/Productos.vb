Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Productos


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

    Private Sub txCodProd_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub txCodProv_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub txtPriPre_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub txtSegPre_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub txtTerPre_KeyPress(sender As Object, e As KeyPressEventArgs)

        SoloNumeros(e)

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        txCodCateg.ReadOnly = True
        txCodProv.ReadOnly = True
        txNombCateg.ReadOnly = True
        txNombProv.ReadOnly = True

        conexion.Close()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs)

        txtUnidStock.Text = 0
        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        If txCodProd.Text = "" Or txNomProd.Text = "" Or rtxDescProd.Text = "" Or txCodProv.Text = "" Or txCodCateg.Text = "" Or txtPriPre.Text = "" Or txtSegPre.Text = "" Or txtTerPre.Text = "" Or txtUnidStock.Text = "" Or txMin.Text = "" Or txMax.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else

            If RegistradoProducto(txCodProd.Text) = False Then
                Dim consultaGuardar As String = "insert into Producto(CodProduc,NombProduc,DescripProduc,CodProv,CodCateg,PrimerPrecio,SegundoPrecio,TercerPrecio,UnidadesStock,Minimo,Maximo) values(@CodProduc,@NombProduc,@DescripProduc,@CodProv,@CodCateg,@PrimerPrecio,@SegundoPrecio,@TercerPrecio,@UnidadesStock,@Minimo,@Maximo)"

                Dim ejecutar As New SqlCommand(consultaGuardar, conexion)

                ejecutar.Parameters.AddWithValue("@CodProduc", Val(txCodProd.Text))
                ejecutar.Parameters.AddWithValue("@NombProduc", (txNomProd.Text))
                ejecutar.Parameters.AddWithValue("@DescripProduc", (rtxDescProd.Text))
                ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProv.Text))
                ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCateg.Text))
                ejecutar.Parameters.AddWithValue("@PrimerPrecio", Val(txtPriPre.Text))
                ejecutar.Parameters.AddWithValue("@SegundoPrecio", Val(txtSegPre.Text))
                ejecutar.Parameters.AddWithValue("@TercerPrecio", Val(txtTerPre.Text))
                ejecutar.Parameters.AddWithValue("@UnidadesStock", Val(txtUnidStock.Text))
                ejecutar.Parameters.AddWithValue("@Minimo", Val(txMin.Text))
                ejecutar.Parameters.AddWithValue("@Maximo", Val(txMax.Text))


                ejecutar.ExecuteNonQuery()
            Else
                MsgBox("El producto ya esta registrado")
            End If
        End If

        conexion.Close()

        txCodProd.Clear()
        txNomProd.Clear()
        rtxDescProd.Clear()
        txCodProv.Clear()
        txCodCateg.Clear()
        txtPriPre.Clear()
        txtSegPre.Clear()
        txtTerPre.Clear()
        txtUnidStock.Clear()
        txMax.Clear()
        txMin.Clear()

    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs)


        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        If txCodProd.Text = "" Or txNomProd.Text = "" Or rtxDescProd.Text = "" Or txCodProv.Text = "" Or txCodCateg.Text = "" Or txtPriPre.Text = "" Or txtSegPre.Text = "" Or txtTerPre.Text = "" Or txtUnidStock.Text = "" Or txMin.Text = "" Or txMax.Text = "" Or DGV.Rows.Count = 0 Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaGuardar As String = "Update  Producto set  NombProduc=@NombProduc,DescripProduc=@DescripProduc,CodProv=@CodProv,CodCateg=@CodCateg,PrimerPrecio=@PrimerPrecio,SegundoPrecio=@SegundoPrecio,TercerPrecio=@TercerPrecio,UnidadesStock=@UnidadesStock,Minimo=@Minimo,Maximo=@Maximo Where CodProduc=@CodProduc"
            Dim ejecutar As New SqlCommand(consultaGuardar, conexion)
            ejecutar.Parameters.AddWithValue("@CodProduc", Val(txCodProd.Text))
            ejecutar.Parameters.AddWithValue("@NombProduc", (txNomProd.Text))
            ejecutar.Parameters.AddWithValue("@DescripProduc", (rtxDescProd.Text))
            ejecutar.Parameters.AddWithValue("@CodProv", Val(txCodProv.Text))
            ejecutar.Parameters.AddWithValue("@CodCateg", Val(txCodCateg.Text))
            ejecutar.Parameters.AddWithValue("@PrimerPrecio", Val(txtPriPre.Text))
            ejecutar.Parameters.AddWithValue("@SegundoPrecio", Val(txtSegPre.Text))
            ejecutar.Parameters.AddWithValue("@TercerPrecio", Val(txtTerPre.Text))
            ejecutar.Parameters.AddWithValue("@UnidadesStock", Val(txtUnidStock.Text))
            ejecutar.Parameters.AddWithValue("@Minimo", Val(txMin.Text))
            ejecutar.Parameters.AddWithValue("@Maximo", Val(txMax.Text))


            ejecutar.ExecuteNonQuery()

        End If
        conexion.Close()

        ' txCodProd.Clear()
        'txNomProd.Clear()
        'rtxDescProd.Clear()
        'txCodProv.Clear()
        'txCodCateg.Clear()
        'txtPriPre.Clear()
        'txtSegPre.Clear()
        'txtTerPre.Clear()
        'txtUnidStock.Clear()
        'txMax.Clear()
        'txMin.Clear()

    End Sub


    Private Sub btBuscar_Click(sender As Object, e As EventArgs)
        abrir()

        Dim busqueda As Integer

        busqueda = InputBox("Ingrese Codigo", "Busqueda")


        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto where CodProduc=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

    End Sub

    Private Sub txCodProv_TextChanged(sender As Object, e As EventArgs) Handles txCodProv.TextChanged

        abrir()
        Dim Recuperar As String = "select * from Proveedores where CodProv= '" & txCodProv.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            txNombProv.Text = Mostrar(1)
        Else
            txNombProv.Text = ""
        End If
        Mostrar.Close()
        conexion.Close()

    End Sub

    Private Sub txCodCateg_TextChanged(sender As Object, e As EventArgs) Handles txCodCateg.TextChanged
        abrir()
        Dim Recuperar As String = "select * from Categoria where CodCateg= '" & txCodCateg.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            txNombCateg.Text = Mostrar(1)
        Else
            txNombCateg.Text = ""
        End If
        Mostrar.Close()
        conexion.Close()
    End Sub

    Private Sub btActualizarTabla_Click(sender As Object, e As EventArgs)

        abrir()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProduc as 'Codigo del Producto', NombProduc as 'Nombre del Producto', DescripProduc as 'Descripcion del Producto', CodProv as 'Codigo del Proveedor', CodCateg as 'Codigo de la Categoria', PrimerPrecio as 'Precio #1', SegundoPrecio as 'Precio #2', TercerPrecio as 'Precio #3', UnidadesStock as 'Unidades en Stock',Minimo as 'Unidades Minimas', Maximo as 'Unidades Maximas' from Producto", conexion)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

        conexion.Close()
        txCodProd.Clear()
        txNomProd.Clear()
        rtxDescProd.Clear()
        txCodProv.Clear()
        txCodCateg.Clear()
        txtPriPre.Clear()
        txtSegPre.Clear()
        txtTerPre.Clear()
        txtUnidStock.Clear()
        txMax.Clear()
        txMin.Clear()

    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs)
        txCodProd.Text = DGV.CurrentRow.Cells(0).Value
        txNomProd.Text = DGV.CurrentRow.Cells(1).Value
        rtxDescProd.Text = DGV.CurrentRow.Cells(2).Value
        txCodProv.Text = DGV.CurrentRow.Cells(3).Value
        txCodCateg.Text = DGV.CurrentRow.Cells(4).Value
        txtPriPre.Text = DGV.CurrentRow.Cells(5).Value
        txtSegPre.Text = DGV.CurrentRow.Cells(6).Value
        txtTerPre.Text = DGV.CurrentRow.Cells(7).Value
        txtUnidStock.Text = DGV.CurrentRow.Cells(8).Value
        txMax.Text = DGV.CurrentRow.Cells(9).Value
        txMin.Text = DGV.CurrentRow.Cells(10).Value
    End Sub

    Private Sub txCodProv_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txCodProv.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txCodCateg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCodCateg.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txCodProd_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txCodProd.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtPriPre_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtPriPre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtUnidStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidStock.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtSegPre_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtSegPre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txMax.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtTerPre_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtTerPre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txMin.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtTerPre_TextChanged(sender As Object, e As EventArgs) Handles txtTerPre.TextChanged

    End Sub

    Private Sub lbSegPre_Click(sender As Object, e As EventArgs) Handles lbSegPre.Click

    End Sub

    Private Sub lbCodCateg_Click(sender As Object, e As EventArgs) Handles lbCodCateg.Click

    End Sub

    Private Sub lbCodProv_Click(sender As Object, e As EventArgs) Handles lbCodProv.Click

    End Sub

    Private Sub txCodProd_TextChanged(sender As Object, e As EventArgs) Handles txCodProd.TextChanged

    End Sub

    Private Sub txCodProd_Validating(sender As Object, e As CancelEventArgs) Handles txCodProd.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txNomProd_TextChanged(sender As Object, e As EventArgs) Handles txNomProd.TextChanged

    End Sub

    Private Sub txNomProd_Validating(sender As Object, e As CancelEventArgs) Handles txNomProd.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 And DirectCast(sender, TextBox).Text.Length <= 10 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rtxDescProd_TextChanged(sender As Object, e As EventArgs) Handles rtxDescProd.TextChanged

    End Sub

    Private Sub txtUnidStock_TextChanged(sender As Object, e As EventArgs) Handles txtUnidStock.TextChanged

    End Sub

    Private Sub txMax_TextChanged(sender As Object, e As EventArgs) Handles txMax.TextChanged

    End Sub

    Private Sub rtxDescProd_Validating(sender As Object, e As CancelEventArgs) Handles rtxDescProd.Validating
        Try
            If DirectCast(sender, RichTextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtUnidStock_Validating(sender As Object, e As CancelEventArgs) Handles txtUnidStock.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txMax_Validating(sender As Object, e As CancelEventArgs) Handles txMax.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txMin_TextChanged(sender As Object, e As EventArgs) Handles txMin.TextChanged

    End Sub

    Private Sub txMin_Validating(sender As Object, e As CancelEventArgs) Handles txMin.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txCodProv_Validating(sender As Object, e As CancelEventArgs) Handles txCodProv.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txCodCateg_Validating(sender As Object, e As CancelEventArgs) Handles txCodCateg.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txNombProv_TextChanged(sender As Object, e As EventArgs) Handles txNombProv.TextChanged

    End Sub

    Private Sub txNombProv_Validating(sender As Object, e As CancelEventArgs) Handles txNombProv.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txNombCateg_TextChanged(sender As Object, e As EventArgs) Handles txNombCateg.TextChanged

    End Sub

    Private Sub txNombCateg_Validating(sender As Object, e As CancelEventArgs) Handles txNombCateg.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPriPre_TextChanged(sender As Object, e As EventArgs) Handles txtPriPre.TextChanged

    End Sub

    Private Sub txtPriPre_Validating(sender As Object, e As CancelEventArgs) Handles txtPriPre.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSegPre_TextChanged(sender As Object, e As EventArgs) Handles txtSegPre.TextChanged

    End Sub

    Private Sub txtTerPre_Validating(sender As Object, e As CancelEventArgs) Handles txtTerPre.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSegPre_Validating(sender As Object, e As CancelEventArgs) Handles txtSegPre.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Si se deja vacio
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        abrir()

        If txCodProd.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaElim As String = "Update Producto set Estado=0   where txCodProd= @Codprouc"
            Dim ejecutar As New SqlCommand(consultaElim, conexion)
            ejecutar.Parameters.AddWithValue("@Codprouc", Val(txCodProd.Text))

            ejecutar.ExecuteNonQuery()
        End If


        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodProd as 'Codigo del Producto', NompProd as 'Nombre del Producto', DescProd as 'Descripcion del Producto', 
        Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado',
case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end
as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()

        txCodProd.Clear()
        txNomProd.Clear()
        rtxDescProd.Clear()
        txtUnidStock.Clear()
        txMax.Clear()
        txMin.Clear()
        txCodProv.Clear()
        txCodCateg.Clear()
        txNombProv.Clear()
        txNombCateg.Clear()
        txtPriPre.Clear()
        txtSegPre.Clear()
        txtTerPre.Clear()


        '   chkEstado.Checked = False
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'abrir()
        'If (txtNombreEmpleado.TextLength < 2) Then
        '    MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")
        'ElseIf (TxtUsuario.TextLength < 2) Then
        '    MessageBox.Show("Debe ingresar como minimo 2 caracteres en usuario del empleado")
        'ElseIf (TxtContraseña.TextLength < 8) Then
        '    MessageBox.Show("Debe ingresar como minimo 8 caracteres en la contraseña del empleado")

        'Else

        '    If TxtCodigoEmpleado.Text = "" Or txtNombreEmpleado.Text = "" Or TxtContraseña.Text = "" Or DGV.Rows.Count = 0 Then
        '        MsgBox("Hay campos vacios")
        '    Else
        '        Dim Cat As Integer
        '        Dim estado As Integer

        '        If CbxNivel.SelectedItem = "Gerente" And chkEstado.Checked = True Then
        '            Cat = 1
        '            estado = 1
        '        Else
        '            Cat = 2
        '            estado = 0
        '        End If

        '        Dim consultaAct As String = "update Empleados set NombEmple=@NombEmple, Contraseña=@Contraseña ,NivelEmple=@NivelEmple, EstadoEmple=@EstadoEmple where CodEmple= @CodEmple"
        '        Dim ejecutar As New SqlCommand(consultaAct, conexion)
        '        ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))
        '        ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
        '        ejecutar.Parameters.AddWithValue("@Contraseña", (TxtContraseña.Text))
        '        ejecutar.Parameters.AddWithValue("@NivelEmple", (Cat))
        '        ejecutar.Parameters.AddWithValue("@EstadoEmple", (estado))
        '        ejecutar.ExecuteNonQuery()

        '    End If
        'End If
        'Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        'Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
        '    adaptador.Fill(DatosEmp)
        'End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable
        'DGV.DataSource = DatosEmp
        'conexion.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Dim Cat As Integer
        'abrir()
        'If (txtNombreEmpleado.TextLength < 2) Then
        '    MessageBox.Show("Debe ingresar como minimo 2 caracteres en nombre del empleado")
        'ElseIf (TxtUsuario.TextLength < 2) Then
        '    MessageBox.Show("Debe ingresar como minimo 2 caracteres en usuario del empleado")
        'ElseIf (TxtContraseña.TextLength < 8) Then
        '    MessageBox.Show("Debe ingresar como minimo 8 caracteres en la contraseña del empleado")
        'Else

        '    If TxtCodigoEmpleado.Text = "" Or txtNombreEmpleado.Text = "" Or TxtContraseña.Text = "" Or chkEstado.Checked = False Or DGV.Rows.Count = 0 Then
        '        MsgBox("Hay campos vacios")
        '    Else
        '        If RegistradoEmpleados(TxtCodigoEmpleado.Text) = False Then

        '            If CbxNivel.SelectedItem = "Gerente" Then
        '                Cat = 1

        '            Else
        '                Cat = 2

        '            End If

        '            Dim consultaGuardar As String = "insert into Empleados(CodEmple, NombEmple, Contraseña,NivelEmple,EstadoEmple) values(@CodEmple, @NombEmple,@Contraseña,@NivelEmple,1)"
        '            Dim ejecutar As New SqlCommand(consultaGuardar, conexion)
        '            ejecutar.Parameters.AddWithValue("@CodEmple", Val(TxtCodigoEmpleado.Text))
        '            ejecutar.Parameters.AddWithValue("@NombEmple", (txtNombreEmpleado.Text))
        '            ejecutar.Parameters.AddWithValue("@Contraseña", (TxtContraseña.Text))
        '            ejecutar.Parameters.AddWithValue("@NivelEmple", (Cat))

        'ejecutar.ExecuteNonQuery()
        '        Else
        '            MsgBox("El Empleado ya esta registrado")
        '        End If
        '    End If
        'End If

        'Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        'Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
        '    adaptador.Fill(DatosEmp)
        'End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        'DGV.DataSource = DatosEmp
        'conexion.Close()
    End Sub

    Private Sub btnActTabla_Click(sender As Object, e As EventArgs) Handles btnActTabla.Click
        abrir()
        chkInhabil.Checked = False
        Dim DatosEmp As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select CodEmple as 'Codigo del empleado', NombEmple as 'Nombre del empleado', Contraseña, case when NivelEmple=1 Then 'Gerente' else 'General' end as 'Nivel del empleado', case when EstadoEmple=1 then 'Habilitado' else 'Inhabilitado' end as 'Estado del empleado' from Empleados where EstadoEmple = 1", conexion)
            adaptador.Fill(DatosEmp)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosEmp
        conexion.Close()
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

    Private Sub LbContador7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LbContador6_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ocultar_columnas()
        DGV.Columns(1).Visible = False
    End Sub
    Private Sub buscar()
        Dim dt As New DataTable()
        Dim producto As String

        Try
            producto = TxtBusqueda.Text
            dt = ConexionLogin.buscarProduct(producto)

            If dt.Rows.Count <> 0 Then
                DGV.DataSource = dt
                ConexionLogin.conexion.Close()

            Else
                DGV.DataSource = Nothing
                ConexionLogin.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        'LbContador6.Text = TxtBusqueda.Text.Length
        'Dim filtro As String = CType(sender, TextBox).Text
        'If filtro.Trim() <> String.Empty Then  'Si no es vacío filtra
        '    filtrarDatos(filtro)
        'End If
        buscar()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DGV_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub btnAgg_P_Click(sender As Object, e As EventArgs) Handles btnAgg_P.Click
        FrmBusquedaProveedor.ShowDialog()

    End Sub


End Class