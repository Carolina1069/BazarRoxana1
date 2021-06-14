Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        LbPorcentaje.Visible = False



    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        abrir()
        Try
            If usuarioRegistrado(txtNombreEmpleado.Text) = True Then
                'Timer1.Start()
                Dim contra As String = contrasena(txtNombreEmpleado.Text)
                If contra.Equals(txtContrasena.Text) = True Then
                    If ConsultarTipoUsuario(txtNombreEmpleado.Text) = 1 Then
                        Timer1.Start()

                    Else
                        Timer1.Start()
                        MenuPrincipal.EmpleadoToolStripMenuItem1.Enabled = False
                        MenuPrincipal.ClientesToolStripMenuItem.Enabled = False
                        MenuPrincipal.CategoriaToolStripMenuItem.Enabled = False
                        MenuPrincipal.ProveedoresToolStripMenuItem.Enabled = False
                        MenuPrincipal.ProductoToolStripMenuItem.Enabled = False
                        MenuPrincipal.ReportesToolStripMenuItem.Enabled = False
                    End If
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)

                    txtContrasena.Text = ""
                End If

                txtContrasena.Text = ""
                cbxMostrarContra.Checked = False
            Else
                MsgBox("El Empleado: " + txtNombreEmpleado.Text + " no se encuentra registrado")

                txtContrasena.Text = ""
                cbxMostrarContra.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub cbxMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMostrarContra.CheckedChanged
        Dim Text As String
        Text = txtContrasena.Text
        If cbxMostrarContra.Checked = True Then

            txtContrasena.UseSystemPasswordChar = False
            txtContrasena.Text = Text
        Else
            txtContrasena.UseSystemPasswordChar = True
            txtContrasena.Text = Text
        End If
        txtContrasena.UseSystemPasswordChar = Not cbxMostrarContra.Checked
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        LbPorcentaje.Visible = True
        btnIngresar.Enabled = False
        ProgressBar1.Increment(5)
                LbPorcentaje.Text = ProgressBar1.Value & ("%")
                If ProgressBar1.Value = 100 Then

            MenuPrincipal.Show()
            Me.Hide()

            Timer1.Stop()
            ProgressBar1.Value = 0
            LbPorcentaje.Text = "0%"
            LbPorcentaje.Visible = False
            ProgressBar1.Visible = False
            btnIngresar.Enabled = True
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Esta Seguro que quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub


    'Private Function validar_campos(T As Control) As Boolean

    '    For Each T In Me.Controls
    '        If TypeOf T Is TextBox Then
    '            If Trim(T.Text) = "" Then
    '                MsgBox("Campo por validar", vbInformation)
    '                'Else   
    '                '    MessageBox.Show("Dot Net Perls is awesome.")
    '            End If
    '        Else
    '            ' mesagebox aqui hay otro control diferente de textbox

    '        End If
    '    Next
    'End Function
End Class