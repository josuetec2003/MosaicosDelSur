Public Class xfrmLogin
    Private Sub xfrmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Application.EnableVisualStyles()
    End Sub

    Private Sub txtUser_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtUser.EditValueChanged, txtPass.EditValueChanged
        lblMensaje.Visible = False
    End Sub

    Private Function ValidarLogin() As Boolean
        If txtUser.Text.Trim = "" Then
            txtUser.Focus()
            Return False
        End If

        If txtPass.Text.Trim = "" Then
            txtPass.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not ValidarLogin() Then
            Exit Sub
        End If

        Using TaLogin As New dsSeguridadTableAdapters.UsuariosTableAdapter
            Dim DtLogin As DataTable = TaLogin.GetDataByLogin(txtUser.EditValue, SHA1(txtPass.EditValue))

            If DtLogin.Rows.Count = 1 Then
                With UsuarioActivo
                    .IdUsuario = DtLogin(0)(0)
                    .Username = DtLogin(0)(2)
                    .Password = DtLogin(0)(3)
                    .EsAdmin = DtLogin(0)(4)
                    .Estado = DtLogin(0)(5)
                    .Nombre = DtLogin(0)(6)
                    .Apellido = DtLogin(0)(7)
                    .IdEmpleado = DtLogin(0)(1)
                End With

                AddAction(UsuarioActivo.IdUsuario, Now, "Inicio sesión", "Se inició sesión")
                DialogResult = Windows.Forms.DialogResult.OK
            Else
                lblMensaje.Visible = True
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
            End If
        End Using
    End Sub
End Class