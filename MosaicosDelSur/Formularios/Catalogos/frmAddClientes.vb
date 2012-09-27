Public Class frmAddClientes
    Private EsNuevo As Boolean
    Private IdCliente As Integer

    Private Sub frmAddClientes_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ClientesBindingSource.CancelEdit()
    End Sub

    Private Sub frmAddClientes_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmAddClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If EsNuevo Then
            lblTitulo.Text = "Agregar cliente"
            btnOK.Text = "Agregar cliente"
            Text = "Agregar cliente"
            ClientesBindingSource.AddNew()
        Else
            lblTitulo.Text = "Editar información del cliente"
            btnOK.Text = "Actualizar datos"
            Text = "Editar cliente"
            ClientesTableAdapter.FillByIdCliente(DsCatalogos.Clientes, IdCliente)
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        If NombreORazonSocialTextEdit.Text.Trim = "" Then
            NombreORazonSocialTextEdit.Focus()
            Exit Sub
        End If

        If EsNuevo Then
            Validate()
            ClientesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsCatalogos)

            MsgBox("Se agregó el cliente", MsgBoxStyle.Information, "Cliente")
            ClientesBindingSource.AddNew()
            NombreORazonSocialTextEdit.Focus()
        Else
            Validate()
            ClientesBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DsCatalogos)
            MsgBox("Se actualizó la información del cliente", MsgBoxStyle.Information, "Cliente")
        End If
    End Sub

    Private Sub btnListado_Click(sender As System.Object, e As System.EventArgs) Handles btnListado.Click
        Try
            frmListadoClientes.Close()
        Catch ex As Exception
        End Try

        With frmListadoClientes
            .MdiParent = Me.MdiParent
            .Show()
            .Focus()
        End With
    End Sub

    Public Property EsNuevo1() As Boolean
        Get
            Return EsNuevo
        End Get
        Set(value As Boolean)
            EsNuevo = Value
        End Set
    End Property

    Public Property IdCliente1() As Integer
        Get
            Return IdCliente
        End Get
        Set(value As Integer)
            IdCliente = Value
        End Set
    End Property

    Private Sub btnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
        Close()
    End Sub
End Class