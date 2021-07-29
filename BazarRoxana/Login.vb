Imports System.ComponentModel

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        LbPorcentaje.Visible = False

    End Sub

    'Boton de ingresar, evalua si el usuario y contraseña son correctos y comienza ejecucion del cargador
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        AbrirConexion()
        Try
            If UsuarioRegistrado(TxtNombreEmpleado.Text) = True Then

                Dim ContraUsuario As String = ContrasenaUsuario(TxtNombreEmpleado.Text)
                If ContraUsuario.Equals(TxtContrasena.Text) = True Then
                    If ConsultarTipoUsuario(TxtNombreEmpleado.Text) = 1 Then
                        CodUser = CodUsuario(TxtNombreEmpleado.Text)
                        TimerLogin.Start()

                    ElseIf ConsultarTipoUsuario(TxtNombreEmpleado.Text) = 2 Then
                        CodUser = CodUsuario(TxtNombreEmpleado.Text)
                        TimerLogin.Start()
                        MenuPrincipal.UsuariosToolStripMenuItem.Visible = False
                        MenuPrincipal.MiEmpresaToolStripMenuItem.Visible = False

                    ElseIf ConsultarTipoUsuario(TxtNombreEmpleado.Text) = 3 Then
                        CodUser = CodUsuario(TxtNombreEmpleado.Text)
                        TimerLogin.Start()
                        MenuPrincipal.UsuariosToolStripMenuItem.Visible = False
                        MenuPrincipal.EmpleadoToolStripMenuItem1.Visible = False
                        MenuPrincipal.ClientesToolStripMenuItem.Visible = False
                        MenuPrincipal.CategoriaToolStripMenuItem.Visible = False
                        MenuPrincipal.ProveedoresToolStripMenuItem.Visible = False
                        MenuPrincipal.ProductoToolStripMenuItem.Visible = False
                        MenuPrincipal.ReportesToolStripMenuItem.Visible = False
                        MenuPrincipal.MiEmpresaToolStripMenuItem.Visible = False
                    End If
                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)

                    TxtContrasena.Text = ""
                End If

                TxtContrasena.Text = ""
                ChkMostrarContra.Checked = False
            Else
                MsgBox("El Empleado: " + TxtNombreEmpleado.Text + " no se encuentra registrado")

                TxtContrasena.Text = ""
                ChkMostrarContra.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CbxMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMostrarContra.CheckedChanged
        'Muestra la contraseña si el CheckBox esta seleccionado 
        Dim ContraseñaUsuario As String
        ContraseñaUsuario = TxtContrasena.Text
        If ChkMostrarContra.Checked = True Then

            TxtContrasena.UseSystemPasswordChar = True
            TxtContrasena.Text = ContraseñaUsuario
        Else
            TxtContrasena.UseSystemPasswordChar = False
            TxtContrasena.Text = ContraseñaUsuario
        End If

    End Sub

    'Muestra el porcentaje de carga del ProgressBar
    Private Sub TimerLogin_Tick(sender As Object, e As EventArgs) Handles TimerLogin.Tick

        ProgressBar1.Visible = True
        LbPorcentaje.Visible = True
        BtnIngresar.Enabled = False
        ProgressBar1.Increment(5)
        LbPorcentaje.Text = ProgressBar1.Value & ("%")
        If ProgressBar1.Value = 100 Then

            MenuPrincipal.Show()
            Me.Hide()

            TimerLogin.Stop()
            ProgressBar1.Value = 0
            LbPorcentaje.Text = "0%"
            LbPorcentaje.Visible = False
            ProgressBar1.Visible = False
            BtnIngresar.Enabled = True
        End If

    End Sub

    'Boton salir del sistema
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim OpcionSalir As DialogResult
        OpcionSalir = MessageBox.Show("¿Esta Seguro que quiere salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If OpcionSalir = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub TxtNombreEmpleado_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombreEmpleado.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 And DirectCast(sender, TextBox).Text.Length <= 50 Then  'Valida si el caja de texto esta vacia 
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtContrasena_Validating(sender As Object, e As CancelEventArgs) Handles TxtContrasena.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then   'Valida si el caja de texto esta vacia 
                Me.ErrorValidacion.SetError(sender, "")
            Else
                Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class