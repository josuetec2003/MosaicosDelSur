Public Class frmUsuario 
    Private EsNuevo As Boolean
    Private IdUsuario As Integer
    Private UsernameActual As String

    Private Sub frmUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        EmpleadosNombreCompletoTableAdapter.Fill(DsCatalogos.EmpleadosNombreCompleto)

        If EsNuevo Then
            lblTitulo.Text = "Agregando nuevo usuario"
            btnOK.Text = "Crear usuario"
            Text = "Crear usuario"
            UsuariosBindingSource.AddNew()
        Else
            lblTitulo.Text = "Actualizar usuario"
            btnOK.Text = "Actualizar usuario"
            Text = "Actualizar usuario"

            IdEmpleadoLookUpEdit.Properties.ReadOnly = True
            PasswordTextEdit.Properties.ReadOnly = True
            ConfirmPasswordTextEdit.Properties.ReadOnly = True

            UsuariosTableAdapter.FillByIdUsuario(DsSeguridad.Usuarios, IdUsuario)
        End If
    End Sub

    Private Function ValidarFormulario() As Boolean

        If EsNuevo Then
            If IdEmpleadoLookUpEdit.EditValue Is DBNull.Value Then
                IdEmpleadoLookUpEdit.Focus()
                Return False
            End If
        End If

        If UsernameTextEdit.EditValue Is DBNull.Value Or UsernameTextEdit.Text.Trim = "" Then
            UsernameTextEdit.Focus()
            Return False
        End If

        If EsNuevo Then
            If PasswordTextEdit.EditValue Is DBNull.Value Then
                PasswordTextEdit.Focus()
                Return False
            End If

            If PasswordTextEdit.Text.Length < 6 Then
                MsgBox("La contraseña debe tener un mínimo de 6 caracteres", MsgBoxStyle.Exclamation, "Contraseña débil")
                Return False
            End If

            If ConfirmPasswordTextEdit.Text.Trim = "" Then
                ConfirmPasswordTextEdit.Focus()
                Return False
            End If

            If PasswordTextEdit.EditValue <> ConfirmPasswordTextEdit.EditValue Then
                MsgBox("Las contraseñas no coinciden, porfavor verifique", MsgBoxStyle.Exclamation, "Error")
                Return False
            End If
        End If
        
        If EsNuevo Then
            Dim DtEmp As DataTable = UsuariosTableAdapter.GetDataByIdEmpleado(IdEmpleadoLookUpEdit.EditValue)
            If DtEmp.Rows.Count = 1 Then
                MsgBox("El empleado seleccionado ya tiene un nombre de usuario asignado", MsgBoxStyle.Exclamation, "El usuario ya existe")
                Return False
            End If

            Dim DtUsers As DataTable = UsuariosTableAdapter.GetDataByUsername(UsernameTextEdit.EditValue)
            If DtUsers.Rows.Count = 1 Then
                MsgBox(String.Format("El nombre de usuario '{0}' no esta disponible", UsernameTextEdit.EditValue), MsgBoxStyle.Exclamation, "No disponible")
                Return False
            End If
        End If

        If Not EsNuevo Then
            Dim DtUserActual As DataTable = UsuariosTableAdapter.GetDataByUsernameActual(UsernameTextEdit.EditValue, UsernameActual)
            If DtUserActual.Rows.Count = 1 Then
                MsgBox(String.Format("El nombre de usuario '{0}' no esta disponible", UsernameTextEdit.EditValue), MsgBoxStyle.Exclamation, "No disponible")
                Return False
            End If
        End If

        Return True
    End Function

    Public Property EsNuevo1() As Boolean
        Get
            Return EsNuevo
        End Get
        Set(value As Boolean)
            EsNuevo = value
        End Set
    End Property

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If

        If EsNuevo Then
            UsuariosTableAdapter.Insert(IdEmpleadoLookUpEdit.EditValue, UsernameTextEdit.EditValue, SHA1(PasswordTextEdit.EditValue), EsAdminCheckBox.Checked, EstadoCheckBox.Checked)
            MsgBox("Se ha creado el usuario correctamente", MsgBoxStyle.Information, "Usuario creado")
            UsuariosBindingSource.AddNew()
        Else
            UsuariosTableAdapter.UpdateInfoUsuario(UsernameTextEdit.EditValue, EsAdminCheckBox.Checked, EstadoCheckBox.Checked, IdUsuario)
            MsgBox("Se actualizó la información del usuario", MsgBoxStyle.Information, "Usuario actualizado")
        End If
    End Sub

    Public Property IdUsuario1() As Integer
        Get
            Return IdUsuario
        End Get
        Set(value As Integer)
            IdUsuario = Value
        End Set
    End Property

    Public Property UsernameActual1() As String
        Get
            Return UsernameActual
        End Get
        Set(value As String)
            UsernameActual = Value
        End Set
    End Property
End Class