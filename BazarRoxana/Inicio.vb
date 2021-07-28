Imports System.Data.SqlClient
Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Login.TxtNombreEmpleado.Text
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        AbrirConexion()
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
            ElseIf Mostrar(2) = 2 Then
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

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click

        Shell("cmd /cstart C:\Users\carlo\source\repos\BazarRoxana1\help.chm")

    End Sub
End Class