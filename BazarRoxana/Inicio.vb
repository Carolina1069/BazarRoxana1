﻿Imports System.Data.SqlClient
Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Login.txtNombreEmpleado.Text
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        AbrirConeccion()
        Dim Recuperar As String = "select U.UsuarioEmp, E.NombEmple, E.NivelEmple from Empleados as E inner join Usuario as U on E.CodEmple=U.CodEmple where U.UsuarioEmp='" & Label1.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, ConexionBase)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            Label2.Text = Mostrar(1)
            If Mostrar(2) = 1 Then
                Label3.Text = "Administrador"
            ElseIf Mostrar(2) = 1 Then
                Label3.Text = "Gerente"
            Else
                Label3.Text = "Vendedor"
            End If
        Else
            Label2.Text = ""
        End If
        Mostrar.Close()
        ConexionBase.Close()
    End Sub

End Class