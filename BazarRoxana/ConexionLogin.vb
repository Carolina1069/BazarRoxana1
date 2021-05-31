Imports System.Data.Sql
Imports System.Data.SqlClient
Module ConexionLogin
    Public conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    'CAROLINA10\CAROLINA
    'AMAYA
    'DANIELRUEDA\LOCALHOST
    'localhost
    Sub abrir()

        Try
            conexion = New SqlConnection("Data Source=localhost;Initial Catalog=BazarRoxana;Integrated Security=True")
            conexion.Open()
            ' MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
        End Try
    End Sub

    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Empleados where NombEmple='" & nombreUsuario & "' and EstadoEmple=1 ", conexion)
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

    Function contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select Contraseña from Empleados where NombEmple='" & nombreUsuario & "' and EstadoEmple=1 ", conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contraseña")
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
            enunciado = New SqlCommand("Select NivelEmple from Empleados where NombEmple='" & nombreUsuario & "' and EstadoEmple=1 ", conexion)
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

    Function PersonaRegistradaClientes(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Clientes where CodCli='" & id & "'", conexion)
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
            enunciado = New SqlCommand("select*from Categoria where CodCateg='" & id & "'", conexion)
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
            enunciado = New SqlCommand("select*from Compras where NumCompra='" & id & "'", conexion)
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
            enunciado = New SqlCommand("select*from Ventas where NumVent='" & id & "'", conexion)
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
            enunciado = New SqlCommand("select*from Empleados where CodEmple='" & id & "'", conexion)
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

    Function RegistradoProducto(ByVal id As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("select*from Producto where CodProduc='" & id & "'", conexion)
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
            enunciado = New SqlCommand("select*from Proveedores where CodProv='" & id & "'", conexion)
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
