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

    Private Sub txCodProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCodProd.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txCodProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txCodProv.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtPriPre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriPre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtSegPre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegPre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtTerPre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTerPre.KeyPress

        SoloNumeros(e)

    End Sub

    Private Sub btBuscarProv_Click(sender As Object, e As EventArgs) Handles btBuscarProv.Click

        ViewBusProv.Show()

    End Sub

    Private Sub btBuscarCateg_Click(sender As Object, e As EventArgs) Handles btBuscarCateg.Click

        ViewBusCateg.Show()

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Producto", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat


    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        txtUnidStock.Text = 0

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Producto", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        If txCodProd.Text = "" Or txNomProd.Text = "" Or rtxDescProd.Text = "" Or txCodProv.Text = "" Or txCodCateg.Text = "" Or txtPriPre.Text = "" Or txtSegPre.Text = "" Or txtTerPre.Text = "" Or txtUnidStock.Text = "" Or txMin.Text = "" Or txMax.Text = "" Then
            MsgBox("Hay campos vacios")
        Else


            Dim consultaGuardar As String = "insert into Producto(CodProduc,NombProduc,DescripProduc,CodProv,CodCateg,PrimerPrecio,SegundoPrecio,TercerPrecio,UnidadesStock,Minimo,Maximo) values(@CodProduc,@NombProduc,@DescripProduc,@CodProv,@CodCateg,@PrimerPrecio,@SegundoPrecio,@TercerPrecio,@UnidadesStock,@Minimo,@Maximo)"

            Dim ejecutar As New SqlCommand(consultaGuardar, conec)

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


    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click


        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()

        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Producto", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        If txCodProd.Text = "" Or txNomProd.Text = "" Or rtxDescProd.Text = "" Or txCodProv.Text = "" Or txCodCateg.Text = "" Or txtPriPre.Text = "" Or txtSegPre.Text = "" Or txtTerPre.Text = "" Or txtUnidStock.Text = "" Or txMin.Text = "" Or txMax.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaGuardar As String = "Update  Producto set  NombProduc=@NombProduc,DescripProduc=@DescripProduc,CodProv=@CodProv,CodCateg=@CodCateg,PrimerPrecio=@PrimerPrecio,SegundoPrecio=@SegundoPrecio,TercerPrecio=@TercerPrecio,UnidadesStock=@UnidadesStock,Minimo=@Minimo,Maximo=@Maximo Where CodProduc=@CodProduc"
            Dim ejecutar As New SqlCommand(consultaGuardar, conec)
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

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()
        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Using adaptador As New SqlDataAdapter("select * from Producto", conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat
        If txCodProd.Text = "" Then
            MsgBox("Hay campos vacios")
        Else
            Dim consultaGuardar As String = "delete from  Producto  Where CodProduc=@CodProduc"
            Dim ejecutar As New SqlCommand(consultaGuardar, conec)
            ejecutar.Parameters.AddWithValue("@CodProduc", Val(txCodProd.Text))
            ejecutar.ExecuteNonQuery()

        End If

    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

        Dim conec As New SqlClient.SqlConnection
        conec.ConnectionString = "Data Source=CAROLINA10\CAROLINA;Initial Catalog=BazarRoxana;Integrated Security=True"
        conec.Open()


        Dim busqueda As Integer

        busqueda = InputBox("Ingrese Codigo", "Busqueda")


        Dim DatosCat As New DataTable 'tabla temporal que recoge los datos de la consulta
        Dim query As String = "select * from Producto where CodProduc=" & busqueda
        Using adaptador As New SqlDataAdapter(query, conec)
            adaptador.Fill(DatosCat)
        End Using 'intermediario entre la base de datos y DATOSusuario para poder ingresar a datatable

        DGV.DataSource = DatosCat

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