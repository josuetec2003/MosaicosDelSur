Public Class frmDialogFacturas 

    Private Sub frmDialogFacturas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListadoFacturasTableAdapter.Fill(DsProcesos.ListadoFacturas)
    End Sub

    Private Sub txtCliente_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtCliente.EditValueChanged
        ListadoFacturasTableAdapter.FillByCliente(DsProcesos.ListadoFacturas, String.Format("%{0}%", txtCliente.EditValue))
    End Sub

    Private Sub txtFactura_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtFactura.EditValueChanged
        ListadoFacturasTableAdapter.FillByIdFactura(DsProcesos.ListadoFacturas, CInt(txtFactura.EditValue))
    End Sub

    Private Function DameFactura() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdFactura")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function DameCredito() As Boolean
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Credito")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick
        Dim ID As Integer = DameFactura()
        Dim Credito As Boolean = DameCredito()
        With frmFacturar
            .InfoFactura(ID, Credito)
            .btnEliminarDeFactura.Enabled = False
            .btnAgregarAFactura.Enabled = False
            .btnBuscarProducto.Enabled = False
            .btnBuscarCliente.Enabled = False
            .btnBuscarOrden.Enabled = False
            .btnGuardar.Enabled = False
            .txtPago.EditValue = Nothing
            .txtCambio.EditValue = Nothing
            .PanelAbono.Visible = False
        End With
        Close()
    End Sub
End Class