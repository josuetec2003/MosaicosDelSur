Public Class frmCambiarPass 

    Private Sub btnCambiar_Click(sender As System.Object, e As System.EventArgs) Handles btnCambiar.Click
        If Not validar() Then
            Exit Sub
        End If

        Using TaUser As New dsSeguridadTableAdapters.UsuariosTableAdapter
            TaUser.UpdateResetPassword(SHA1(txtPassNuevo.EditValue), UsuarioActivo.IdUsuario)
            MsgBox("La contraseña ha sido actualizada", MsgBoxStyle.Information, "Nueva contraseña")
            txtPassActual.Text = ""
            txtPassNuevo.Text = ""
            txtConfPassNuevo.Text = ""
            txtPassActual.Focus()
        End Using

    End Sub

    Private Function validar() As Boolean
        If txtPassActual.Text.Trim = "" Then
            txtPassActual.Focus()
            Return False
        End If

        Using TaUser As New dsSeguridadTableAdapters.UsuariosTableAdapter
            Dim DtUser As DataTable = TaUser.GetDataByPassword(UsuarioActivo.IdUsuario, SHA1(txtPassActual.EditValue))
            If DtUser.Rows.Count = 0 Then
                MsgBox("La contraseña actual no es la correcta", MsgBoxStyle.Exclamation, "Error")
                txtPassActual.Focus()
                Return False
            End If
        End Using

        If txtPassNuevo.Text.Trim = "" Then
            txtPassNuevo.Focus()
            Return False
        End If

        If txtPassNuevo.Text.Length < 6 Then
            MsgBox("La contraseña debe tener como mínimo 6 caracteres", MsgBoxStyle.Exclamation, "Contraseña débil")
            txtPassNuevo.Focus()
            Return False
        End If

        If txtConfPassNuevo.Text.Trim = "" Then
            txtConfPassNuevo.Focus()
            Return False
        End If

        If txtPassNuevo.EditValue <> txtConfPassNuevo.EditValue Then
            MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Exclamation, "Error")
            txtPassNuevo.Focus()
            Return False
        End If

        Return True
    End Function
End Class