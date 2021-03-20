Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrir()
        txtContrasena.PasswordChar = "*"
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If usuarioRegistrado(txtNombreEmpleado.Text) = True Then
                Dim contra As String = contrasena(txtNombreEmpleado.Text)
                If contra.Equals(txtContrasena.Text) = True Then
                    Me.Hide()
                    If ConsultarTipoUsuario(txtNombreEmpleado.Text) = 1 Then
                        Compras.ShowDialog()
                    Else
                        Empleado.ShowDialog()
                    End If
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Empleado: " + txtNombreEmpleado.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cbxMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMostrarContra.CheckedChanged
        If cbxMostrarContra.Checked = True Then ' si el checbox es verdadero
            txtContrasena.PasswordChar = "" ' mostrara la contraseña
        ElseIf cbxMostrarContra.Checked = False Then ' sino, si el checbox es falso
            txtContrasena.PasswordChar = "*" ' mostrara asteriscos
        End If ' fin de desicion
    End Sub
End Class