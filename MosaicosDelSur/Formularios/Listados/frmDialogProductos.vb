Public Class frmDialogProductos
    Private Desde As Integer
    ' 1: desde factura
    ' 2: desde orden de trabajo
    ' 3: desde cotizacion

    Private Sub frmDialogProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TamaniosTableAdapter.Fill(DsCatalogos.Tamanios)
        ProductosTableAdapter.Fill(DsCatalogos.Productos)
    End Sub

    Private Sub txtBuscar_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.EditValueChanged
        ProductosTableAdapter.FillByNombre(DsCatalogos.Productos, String.Format("%{0}%", txtBuscar.EditValue))
    End Sub

    Private Function dameId() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdProducto")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function dameStock() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "UnidadesEnStock")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick
        Agregar()
    End Sub

    Public Property Desde1() As Integer
        Get
            Return Desde
        End Get
        Set(value As Integer)
            Desde = Value
        End Set
    End Property

    Private Sub GridControl1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.KeyPress
        If e.KeyChar = ChrW(13) Then
            Agregar()
        End If
    End Sub

    Sub Agregar()
        Dim ID As Integer = dameId()
        Dim Stock As Integer = dameStock()

        If Desde = 1 Then
            If Stock < 1 Then
                MsgBox("No puedes facturar este producto porque no hay en existencia", MsgBoxStyle.Exclamation, "No hay existencia")
            Else
                With frmFacturar
                    .IdProductoTextEdit.EditValue = ID
                End With
                Close()
            End If
        ElseIf Desde = 2 Then
            With frmOrdenesTrabajo
                .IdProductoTextEdit.EditValue = ID
            End With
            Close()
        ElseIf Desde = 3 Then
            With frmCotizacion
                .IdProductoTextEdit.EditValue = ID
            End With
            Close()
        End If
    End Sub
End Class