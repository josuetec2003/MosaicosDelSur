Imports System.IO

Public Class frmAddProductos
    Private EsNuevo As Boolean
    Private IdProducto As Integer

    Sub LimpiarControles()
        NombreTextEdit.EditValue = Nothing
        TamaniosLookUpEdit.EditValue = Nothing
        PrecioUnitarioTextEdit.EditValue = Nothing
        UnidadesEnStockTextEdit.EditValue = Nothing
        FotoPictureBox.Image = Nothing
        chkDescontinuado.Checked = False
        NombreTextEdit.Focus()
    End Sub

    Private Sub frmAddProductos_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        TamaniosTableAdapter.Fill(DsCatalogos.Tamanios)
        If EsNuevo Then
            NombreTextEdit.Focus()
        Else
            txtActualizarStock.Focus()
        End If
    End Sub

    Private Sub frmAddProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TamaniosTableAdapter.Fill(DsCatalogos.Tamanios)

        If EsNuevo Then
            lblTitulo.Text = "Agregar producto"
            btnGuardar.Text = "Agregar producto"
            Text = "Agregar producto"
            LimpiarControles()
            NombreTextEdit.Focus()
        Else
            lblTitulo.Text = "Editar información del producto"
            btnGuardar.Text = "Actualizar"
            Text = "Editar producto"
            txtActualizarStock.Focus()
            ProductosTableAdapter.FillByIdProducto(DsCatalogos.Productos, IdProducto)
        End If
    End Sub

    Private Function ValidarForm() As Boolean
        If NombreTextEdit.Text.Trim = "" Then
            NombreTextEdit.Focus()
            Return False
        End If

        'If TamaniosLookUpEdit.EditValue = Nothing Then
        '    TamaniosLookUpEdit.Focus()
        '    Return False
        'End If

        If PrecioUnitarioTextEdit.EditValue = Nothing Then
            PrecioUnitarioTextEdit.Focus()
            Return False
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

    Public Property IdProducto1() As Integer
        Get
            Return IdProducto
        End Get
        Set(value As Integer)
            IdProducto = value
        End Set
    End Property

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Not ValidarForm() Then
            Exit Sub
        End If

        If EsNuevo Then
            If FotoPictureBox.Image Is Nothing Then
                Dim nullFoto() As Byte = Nothing
                ProductosTableAdapter.Insert(NombreTextEdit.EditValue, TamaniosLookUpEdit.EditValue, PrecioUnitarioTextEdit.EditValue, UnidadesEnStockTextEdit.EditValue, chkDescontinuado.Checked, nullFoto)
            Else
                Dim arrFilename() As String = Split(Text, "\")
                Array.Reverse(arrFilename)

                Using ms As New MemoryStream()
                    FotoPictureBox.Image.Save(ms, FotoPictureBox.Image.RawFormat)
                    Dim arrImage() As Byte = ms.GetBuffer
                    Try
                        Dim Tamanio As Integer = Nothing
                        ProductosTableAdapter.Insert(NombreTextEdit.EditValue, Tamanio, PrecioUnitarioTextEdit.EditValue, UnidadesEnStockTextEdit.EditValue, chkDescontinuado.Checked, arrImage)
                    Catch ex As Exception
                        ProductosTableAdapter.Insert(NombreTextEdit.EditValue, TamaniosLookUpEdit.EditValue, PrecioUnitarioTextEdit.EditValue, UnidadesEnStockTextEdit.EditValue, chkDescontinuado.Checked, arrImage)
                    End Try
                End Using
            End If

            LimpiarControles()
            MsgBox("El producto fué agregago al catálogo", MsgBoxStyle.Information, "Producto agregado")
        Else
            If FotoPictureBox.Image Is Nothing Then
                Dim nullFoto() As Byte = Nothing
                Try
                    ProductosTableAdapter.UpdateIdProducto(NombreTextEdit.EditValue, TamaniosLookUpEdit.EditValue, PrecioUnitarioTextEdit.EditValue, UnidadesEnStockTextEdit.EditValue, chkDescontinuado.Checked, nullFoto, IdProducto)
                Catch ex As Exception
                    Dim Tamanio As Integer = Nothing
                    ProductosTableAdapter.UpdateIdProducto(NombreTextEdit.EditValue, Tamanio, PrecioUnitarioTextEdit.EditValue, UnidadesEnStockTextEdit.EditValue, chkDescontinuado.Checked, nullFoto, IdProducto)
                End Try

            Else
                Dim arrFilename() As String = Split(Text, "\")
                Array.Reverse(arrFilename)

                Using ms As New MemoryStream()
                    FotoPictureBox.Image.Save(ms, FotoPictureBox.Image.RawFormat)
                    Dim arrImage() As Byte = ms.GetBuffer
                    Try
                        Dim Tamanio As Integer = Nothing
                        ProductosTableAdapter.UpdateIdProducto(NombreTextEdit.EditValue, Tamanio, PrecioUnitarioTextEdit.EditValue, UnidadesEnStockTextEdit.EditValue, chkDescontinuado.Checked, arrImage, IdProducto)
                    Catch ex As Exception
                        ProductosTableAdapter.UpdateIdProducto(NombreTextEdit.EditValue, TamaniosLookUpEdit.EditValue, PrecioUnitarioTextEdit.EditValue, UnidadesEnStockTextEdit.EditValue, chkDescontinuado.Checked, arrImage, IdProducto)
                    End Try
                End Using
            End If
            MsgBox("La información del producto fue actualizada", MsgBoxStyle.Information, "Actualización")
        End If
    End Sub

    Private Sub btnListado_Click(sender As System.Object, e As System.EventArgs) Handles btnListado.Click
        With frmListadoProductos
            .MdiParent = Me.MdiParent
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnOpenFile_Click(sender As System.Object, e As System.EventArgs) Handles btnOpenFile.Click
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

    Private Sub btnActualizarStock_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizarStock.Click
        Try
            UnidadesEnStockTextEdit.EditValue = CInt(UnidadesEnStockTextEdit.EditValue) + CInt(txtActualizarStock.EditValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgregarMedida_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarMedida.Click
        Try
            frmTamanios.Close()
        Catch ex As Exception
        End Try

        With frmTamanios
            .MdiParent = Me.MdiParent
            .Show()
            .Focus()
        End With
    End Sub
End Class