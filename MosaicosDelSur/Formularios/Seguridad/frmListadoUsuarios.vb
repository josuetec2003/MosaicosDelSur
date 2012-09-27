Public Class frmListadoUsuarios

    Private Sub frmListadoUsuarios_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CargarDatos()
    End Sub

    Private Sub frmListadoUsuarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        EmpleadosNombreCompletoTableAdapter.Fill(DsCatalogos.EmpleadosNombreCompleto)
        UsuariosTableAdapter.Fill(DsSeguridad.Usuarios)
    End Sub

    Private Sub DeshabilitarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeshabilitarUsuarioToolStripMenuItem.Click
        If MsgBox(String.Format("¿Esta seguro de deshabilitar el usuario?{0}Recuerde que el usuario no podrá iniciar sesión.", Chr(13)), MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
            Dim id As Integer = DameId()
            UsuariosTableAdapter.UpdateEstadoUsuario(False, id)
            CargarDatos()
        End If
    End Sub

    Private Function DameId() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdUsuario")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function DameUsername() As String
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Username")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub EditarInformaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditarInformaciónToolStripMenuItem.Click
        Try
            frmUsuario.Close()
        Catch ex As Exception
        End Try
        Dim id As Integer = DameId()
        Dim user As String = DameUsername()
        With frmUsuario
            .MdiParent = Me.MdiParent
            .EsNuevo1 = False
            .IdUsuario1 = id
            .UsernameActual1 = user
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub ResetearContraseñaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResetearContraseñaToolStripMenuItem.Click
        If MsgBox("¿Esta seguro de resetear la contraseña?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
            Dim id As Integer = DameId()
            Dim user As String = DameUsername()
            UsuariosTableAdapter.UpdateResetPassword(SHA1(user), id)

            MsgBox(String.Format("Contraseña reseteada.{0}La contraseña es el mismo nombre de usuario.", Chr(13)), MsgBoxStyle.Information, "Contraseña reseteada")
        End If
    End Sub
End Class