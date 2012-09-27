Public Class frmComprobarCredenciales 

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not ValidarLogin() Then
            Exit Sub
        End If

        Using TaLogin As New dsSeguridadTableAdapters.UsuariosTableAdapter
            Dim DtLogin As DataTable = TaLogin.GetDataByLogin(txtUser.EditValue, SHA1(txtPass.EditValue))

            If DtLogin.Rows.Count = 1 Then
                AddAction(UsuarioActivo.IdUsuario, Now, "Comprobar credencial", "Se comprobó credenciales para alguna acción")
                DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("La combinación de usuario y contraseña es incorrecta", MsgBoxStyle.Critical, "Error")
            End If
        End Using
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
End Class