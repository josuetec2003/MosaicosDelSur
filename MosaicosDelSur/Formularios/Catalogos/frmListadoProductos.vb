Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview

Public Class frmListadoProductos
    Private stream As New MemoryStream

    Private Sub frmListadoProductos_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        If rbtnCon.Checked Then
            ProductosTableAdapter.FillByConExistencia(DsCatalogos.Productos)
        ElseIf rbtnSin.Checked Then
            ProductosTableAdapter.FillBySinExistencia(DsCatalogos.Productos)
        ElseIf rbtnTodo.Checked Then
            ProductosTableAdapter.Fill(DsCatalogos.Productos)
        End If
    End Sub

    Private Sub btnListadoProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TamaniosTableAdapter.Fill(DsCatalogos.Tamanios)
        ProductosTableAdapter.FillByConExistencia(DsCatalogos.Productos)
    End Sub

    Private Sub txtBuscar_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.EditValueChanged
        If rbtnCon.Checked Then
            ProductosTableAdapter.FillByNombreConExistencia(DsCatalogos.Productos, String.Format("%{0}%", txtBuscar.EditValue))
        ElseIf rbtnSin.Checked Then
            ProductosTableAdapter.FillByNombreSinExistencia(DsCatalogos.Productos, String.Format("%{0}%", txtBuscar.EditValue))
        ElseIf rbtnTodo.Checked Then
            ProductosTableAdapter.FillByNombre(DsCatalogos.Productos, String.Format("%{0}%", txtBuscar.EditValue))
        End If
    End Sub

    Private Sub rbtnCon_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtnCon.CheckedChanged
        ProductosTableAdapter.FillByConExistencia(DsCatalogos.Productos)
    End Sub

    Private Sub rbtnSin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtnSin.CheckedChanged
        ProductosTableAdapter.FillBySinExistencia(DsCatalogos.Productos)
    End Sub

    Private Sub rbtnTodo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtnTodo.CheckedChanged
        ProductosTableAdapter.Fill(DsCatalogos.Productos)
    End Sub

    Private Sub EditarItemToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditarItemToolStripMenuItem.Click, GridControl1.DoubleClick
        Try
            frmAddProductos.Close()
        Catch ex As Exception
        End Try

        Dim ID As Integer = DameId()
        With frmAddProductos
            .MdiParent = Me.MdiParent
            .EsNuevo1 = False
            .IdProducto1 = ID
            .Show()
            .Focus()
        End With
    End Sub

    Private Function DameId() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdProducto")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub GridControl1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.KeyPress
        If e.KeyChar = ChrW(13) Then
            Try
                frmAddProductos.Close()
            Catch ex As Exception
            End Try

            Dim ID As Integer = DameId()
            With frmAddProductos
                .MdiParent = Me.MdiParent
                .EsNuevo1 = False
                .IdProducto1 = ID
                .Show()
                .Focus()
            End With
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Dim ps As New PrintingSystem
        Dim preview As New PrintPreviewFormEx()

        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.PrintingSystem.SaveDocument(stream)
        ps.LoadDocument(stream)
        With preview
            .PrintingSystem = ps
            .Text = "Reporte de productos"
            .MdiParent = Me.MdiParent
            .Show()
        End With
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Try
            frmAddProductos.Close()
        Catch ex As Exception
        End Try

        With frmAddProductos
            .MdiParent = Me.MdiParent
            .EsNuevo1 = True
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub TamanioLookUpEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles TamanioLookUpEdit.EditValueChanged
        ProductosTableAdapter.FillByTamanio(DsCatalogos.Productos, TamanioLookUpEdit.EditValue)
    End Sub
End Class