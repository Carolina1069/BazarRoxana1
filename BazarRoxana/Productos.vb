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

    Private Sub txNomProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txNomProd.KeyPress
        SoloLetras(e)
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
End Class