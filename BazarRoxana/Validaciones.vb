Module Validaciones
    Public Function Minusculas(ByVal Texto As String, ByVal TXT As TextBox) As String
        Minusculas = LCase(Texto) ' LCase se encarga de transformar el texto en minuscula UCase a mayuscula
        TXT.SelectionStart = Len(Texto) ' Dejamos el cursor al final del texto
    End Function

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
    Sub SoloLetrascorreo(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        ' Lista con los caracteres que deseo permitir.
        '
        Dim caracteresPermitidos As String = "qwertyuiopasdfghjklñzxcvbnmQWERTYUIOPASDFGHJKLÑZXCVBNM1234567890@._-" & Convert.ToChar(8)
        ' Carácter presionado.
        '
        Dim c As Char = e.KeyChar
        ' Si la tecla presionada no se encuentra en la matriz 
        ' de caracteres permitidos, anulamos la tecla pulsada.
        '
        If (Not (caracteresPermitidos.Contains(c))) Then
            MessageBox.Show("Ingrese solamente letras, numeros, carectes especiales( @ . - _ ).", "ERROR de escritura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Deshechamos el carácter
            e.Handled = True

        End If
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

End Module
