Imports System.Data.Sql
Imports System.Data.SqlClient
Module ConexionLogin
    Public ConexionBase As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    'localhost
    '(local)\SQLEXPRESS

    Sub AbrirConexion()

        Try
            'ConexionBase = New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
            ConexionBase = New SqlConnection("Data Source=localhost ;Initial Catalog=BazarRoxana; user id = sa; password =123456 ")
            ConexionBase.Open()
            ' MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function ContrasenaUsuario(ByVal NombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("select U.CodEmple, E.NombEmple,E.NivelEmple, E.EstadoEmple, U.CodUsuario, U.UsuarioEmp, CONVERT(varchar(max), DECRYPTBYPASSPHRASE(U.Llave,U.ContraseñaEmp)) as ContraseñaEmp
            from Empleados as E inner join Usuario as U 
			on E.CodEmple=U.CodEmple where U.UsuarioEmp= '" & NombreUsuario & "' and E.EstadoEmple=1", ConexionBase)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("ContraseñaEmp")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Try
            enunciado = New SqlCommand("select U.CodEmple, E.NombEmple,E.NivelEmple, E.EstadoEmple, U.CodUsuario, U.UsuarioEmp, U.ContraseñaEmp 
            from Empleados as E inner join Usuario as U on E.CodEmple=U.CodEmple where U.UsuarioEmp='" & nombreUsuario & "' and E.EstadoEmple=1 ", ConexionBase)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("NivelEmple"))
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    'khaleb metodos
    Public CodUser As String = 0
    Public CodProv As String = "1"
    Public ProductosValidar As Integer = 0
    Public CodUltmaVenta As String = 0
    Function CodUsuario(ByVal nombreUsuario As String) As String
        Dim resultado As Boolean = False
        Dim cod As String = 0
        Try
            enunciado = New SqlCommand("select U.CodEmple, E.NombEmple,E.NivelEmple, E.EstadoEmple, U.CodUsuario, U.UsuarioEmp, U.ContraseñaEmp
            from Empleados as E inner join Usuario as U on E.CodEmple=U.CodEmple where U.UsuarioEmp='" & nombreUsuario & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader()

            If respuesta.Read() Then
                cod = respuesta.Item("CodEmple").ToString()
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return cod
    End Function
    Function CodUVenta() As String
        AbrirConexion()
        Dim resultado As Boolean = False
        Dim cod As String = 0
        Try

            enunciado = New SqlCommand("Select top(1) NumCompra from Compras order by NumCompra DESC ", ConexionBase)
            respuesta = enunciado.ExecuteReader()

            If respuesta.Read() Then
                cod = Integer.Parse(respuesta.Item("NumCompra").ToString()) + 1
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox("Error venta" + ex.ToString)
        End Try

        Return cod
    End Function
    ' fin

    Function CodUltimaVenta() As String
        AbrirConexion()
        Dim resultado As Boolean = False
        Dim cod As String = 0
        Try

            enunciado = New SqlCommand("Select top(1) NumVent from Ventas order by NumVent DESC ", ConexionBase)
            respuesta = enunciado.ExecuteReader()

            If respuesta.Read() Then
                cod = Integer.Parse(respuesta.Item("NumVent").ToString()) + 1
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error venta" + ex.ToString)
        End Try

        Return cod
        ConexionBase.Close()
    End Function

    Function UsuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select U.CodEmple, E.NombEmple,E.NivelEmple, E.EstadoEmple, U.CodUsuario, U.UsuarioEmp, U.ContraseñaEmp
            from Empleados as E inner join Usuario as U on E.CodEmple=U.CodEmple where U.UsuarioEmp='" & nombreUsuario & "' and E.EstadoEmple=1 ", ConexionBase)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

    Function RegistradoUsuario(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Usuario where CodEmple='" & id & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Function RegistradoNombreUsuario(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Usuario where UsuarioEmp='" & id & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function
    Public Function mostrarProveedor() As DataTable
        Try
            ConexionBase.Open()
            enunciado = New SqlCommand("mostrar_proveedor", ConexionBase)
            enunciado.CommandType = CommandType.StoredProcedure

            enunciado.Connection = ConexionBase

            If enunciado.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(enunciado)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ConexionBase.Close()
        End Try
    End Function

    Public Function MostrarCategoria() As DataTable
        Try
            ConexionBase.Open()
            enunciado = New SqlCommand("mostrar_categoría", ConexionBase)
            enunciado.CommandType = CommandType.StoredProcedure

            enunciado.Connection = ConexionBase

            If enunciado.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(enunciado)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ConexionBase.Close()
        End Try
    End Function

    Public Function ActualizarCategoria(codigo As Integer, nombre As String, estado As Integer, descripcion As String)
        Try
            ConexionBase.Open()
            enunciado = New SqlCommand("ActualizarCategoria", ConexionBase)
            enunciado.CommandType = CommandType.StoredProcedure
            enunciado.Parameters.AddWithValue("@codigo", codigo)
            enunciado.Parameters.AddWithValue("@nombre", nombre)
            enunciado.Parameters.AddWithValue("@Descrip", descripcion)

            If enunciado.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            ConexionBase.Close()
        End Try

    End Function

    Public Function BuscarCategoriaI(Nombre As String) As DataTable
        Try
            ConexionBase.Open()
            Dim cmb As New SqlCommand("buscarCategoriaI", ConexionBase)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", Nombre)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ConexionBase.Close()
        End Try
    End Function

    Public Function buscarCategoriaH(Nombre As String) As DataTable
        Try
            ConexionBase.Open()
            Dim cmb As New SqlCommand("buscarCategoriaH", ConexionBase)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", Nombre)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ConexionBase.Close()
        End Try
    End Function

    Public Function buscarProductH(Nombre As String) As DataTable
        Try
            ConexionBase.Open()
            Dim cmb As New SqlCommand("buscarProductH", ConexionBase)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", Nombre)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ConexionBase.Close()
        End Try
    End Function

    Public Function buscarProductI(Nombre As String) As DataTable
        Try
            ConexionBase.Open()
            Dim cmb As New SqlCommand("buscarProductI", ConexionBase)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", Nombre)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ConexionBase.Close()
        End Try
    End Function


    Public Function BuscarCategoria(Nombre As String) As DataTable
        Try
            ConexionBase.Open()
            Dim cmb As New SqlCommand("buscarCategoria", ConexionBase)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", Nombre)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ConexionBase.Close()
        End Try
    End Function

    Public Function buscarProveedorH(Nombre As String) As DataTable
        Try
            ConexionBase.Open()
            Dim cmb As New SqlCommand("buscarProveedorH", ConexionBase)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", Nombre)
            If cmb.ExecuteNonQuery <> 0 Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            ConexionBase.Close()
        End Try
    End Function


    Function PersonaRegistradaClientes(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Clientes where CodCli='" & id & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Function PersonaRegistradaCategoria(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Categoria where NombCateg='" & id & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Function RegistradoCompras(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Compras where NumCompra='" & id & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Function RegistradoVentas(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Ventas where NumVent='" & id & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Function RegistradoEmpleados(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Empleados where CodEmple='" & id & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Function RegistradoProducto(ByVal Nombre As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Producto where NombProduc='" & Nombre & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Function RegistradoProveedores(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Proveedores where CodProv='" & id & "'", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

    Public Function ActualizarProducto(codprod As Integer, NomProd As String, descripcion As String, descripcion2 As String, Codprov As Integer, NombProv As String,
                             CodCateg As Integer, NombCateg As String, PrimerPrecio As Integer, SegundoPrecio As Integer,
                             TercerPrecio As Integer, Minimo As Integer, maximo As Integer)
        Try
            ConexionBase.Open()
            enunciado = New SqlCommand("Actualizar", ConexionBase)
            enunciado.CommandType = CommandType.StoredProcedure

            enunciado.Parameters.AddWithValue("@CodProd", codprod)
            enunciado.Parameters.AddWithValue("@NombProduc", NomProd)
            enunciado.Parameters.AddWithValue("@DescripProduc", descripcion)
            enunciado.Parameters.AddWithValue("@Descripcion", descripcion2)
            enunciado.Parameters.AddWithValue("@CodProv", Codprov)
            enunciado.Parameters.AddWithValue("@NombProv", NombProv)
            enunciado.Parameters.AddWithValue("@CodCateg", CodCateg)
            enunciado.Parameters.AddWithValue("@NombCateg", NombCateg)
            enunciado.Parameters.AddWithValue("@PrimerPrecio", PrimerPrecio)
            enunciado.Parameters.AddWithValue("@SegundoPrecio", SegundoPrecio)
            enunciado.Parameters.AddWithValue("@TercerPrecio", TercerPrecio)
            enunciado.Parameters.AddWithValue("@Minimo", Minimo)
            enunciado.Parameters.AddWithValue("@Maximo", maximo)

            If enunciado.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            ConexionBase.Close()
        End Try
    End Function

    Public Function GuardarProducto(NomProd As String, descripcion As String, descripcion2 As String, Codprov As Integer, NombProv As String,
                             CodCateg As Integer, NombCateg As String, PrimerPrecio As Integer, SegundoPrecio As Integer,
                             TercerPrecio As Integer, Minimo As Integer, maximo As Integer)
        Try
            ConexionBase.Open()
            enunciado = New SqlCommand("GuardarProducto", ConexionBase)
            enunciado.CommandType = CommandType.StoredProcedure


            enunciado.Parameters.AddWithValue("@NombProduc", NomProd)
            enunciado.Parameters.AddWithValue("@DescripProduc", descripcion)
            enunciado.Parameters.AddWithValue("@Descripcion", descripcion2)
            enunciado.Parameters.AddWithValue("@CodProv", Codprov)
            enunciado.Parameters.AddWithValue("@NombProv", NombProv)
            enunciado.Parameters.AddWithValue("@CodCateg", CodCateg)
            enunciado.Parameters.AddWithValue("@NombCateg", NombCateg)
            enunciado.Parameters.AddWithValue("@PrimerPrecio", PrimerPrecio)
            enunciado.Parameters.AddWithValue("@SegundoPrecio", SegundoPrecio)
            enunciado.Parameters.AddWithValue("@TercerPrecio", TercerPrecio)
            enunciado.Parameters.AddWithValue("@Minimo", Minimo)
            enunciado.Parameters.AddWithValue("@Maximo", maximo)

            If enunciado.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            ConexionBase.Close()
        End Try
    End Function

    Public Function ActualizarCategoria(codigo As Integer, nombre As String, descripcion As String)
        Try
            ConexionBase.Open()
            enunciado = New SqlCommand("ActualizarCategoria", ConexionBase)
            enunciado.CommandType = CommandType.StoredProcedure
            enunciado.Parameters.AddWithValue("@codigo", codigo)
            enunciado.Parameters.AddWithValue("@nombre", nombre)
            enunciado.Parameters.AddWithValue("@Descrip", descripcion)

            If enunciado.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            ConexionBase.Close()
        End Try

    End Function

    Function RegistradoMiEmpresa() As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from MiEmpresa where Codigo=1", ConexionBase)
            respuesta = enunciado.ExecuteReader
            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox("Error en el procedimiento: " + ex.ToString)
        End Try
        Return resultado
    End Function

End Module
