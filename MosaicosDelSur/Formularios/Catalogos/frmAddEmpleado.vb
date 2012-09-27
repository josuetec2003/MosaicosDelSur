Public Class frmAddEmpleado
    Private EsNuevo As Boolean
    Private IdEmpleado As Integer

    Private Sub frmAddEmpleado_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        EmpleadosBindingSource.CancelEdit()
    End Sub

    Private Sub frmAddEmpleado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If EsNuevo Then
            lblTitulo.Text = "Registrar nuevo empleado"
            btnOK.Text = "Agregar empleado"
            Text = "Registrar nuevo empleado"
            EmpleadosBindingSource.AddNew()
        Else
            lblTitulo.Text = "Editar información del empleado"
            btnOK.Text = "Actualizar datos"
            Text = "Editar información del empleado"
            EmpleadosTableAdapter.FillByIdEmpleado(DsCatalogos.Empleados, IdEmpleado)
        End If
    End Sub



    Private Function ValidarFormulario() As Boolean
        If NombreTextEdit.Text.Trim = "" Then
            NombreTextEdit.Focus()
            Return False
        End If

        If ApellidoTextEdit.Text.Trim = "" Then
            ApellidoTextEdit.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub Limpiar()
        NombreTextEdit.EditValue = Nothing
        ApellidoTextEdit.EditValue = Nothing
        FechaContratacionDateEdit.EditValue = Nothing
        DirecciónMemoEdit.EditValue = Nothing
        TelefonoTextEdit.EditValue = Nothing
        FotoPictureBox.Image = Nothing
        NombreTextEdit.Focus()
    End Sub

    Public Property EsNuevo1() As Boolean
        Get
            Return EsNuevo
        End Get
        Set(value As Boolean)
            EsNuevo = value
        End Set
    End Property

    Public Property IdEmpleado1() As Integer
        Get
            Return IdEmpleado
        End Get
        Set(value As Integer)
            IdEmpleado = value
        End Set
    End Property


    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If Not ValidarFormulario() Then
            Exit Sub
        End If

        If EsNuevo Then
            Try
                Validate()
                EmpleadosBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DsCatalogos)
                MsgBox("El empleado ha sido registrado", MsgBoxStyle.Information, "Registro")
                Limpiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                Validate()
                EmpleadosBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DsCatalogos)
                MsgBox("La información del empleado ha sido actualizada", MsgBoxStyle.Information, "Registro")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnOpenImage_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenImage.Click
        OpenF.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        OpenF.Filter = "Imágenes (*.png, *.jpg) | *.png;*.jpg"
        OpenF.FileName = "Selecciona una imagen"
        Try
            If OpenF.ShowDialog = Windows.Forms.DialogResult.OK Then
                FotoPictureBox.Image = Image.FromFile(OpenF.FileName)
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error inesperado")
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class