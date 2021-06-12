Imports System.Data.SqlClient
Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Login.txtNombreEmpleado.Text
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        abrir()
        Dim Recuperar As String = "select * from Empleados where UsuarioEmple= '" & Label1.Text & "'"
        Dim Mostrar As SqlDataReader
        Dim Ejecutar As SqlCommand
        Ejecutar = New SqlCommand(Recuperar, conexion)
        Mostrar = Ejecutar.ExecuteReader
        Dim Estado As String
        Estado = Mostrar.Read
        If (Estado = True) Then
            Label2.Text = Mostrar(1)
            'Label3.Text = Mostrar(4)
            If Mostrar(4) = 1 Then
                Label3.Text = "Gerencia"
            Else
                Label3.Text = "General"
            End If
        Else
            Label2.Text = ""
        End If
        Mostrar.Close()
        conexion.Close()
    End Sub

End Class