Public Class frmDialogOrdenes 

    Private Sub frmDialogOrdenes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListadoOrdenesTrabajoTableAdapter.FillByEstado(DsProcesos.ListadoOrdenesTrabajo, "En proceso")
    End Sub

    Private Function DameID() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdOrdenTrabajo")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick
        Dim id As Integer = DameID()
        With frmFacturar
            .txtOrdenTrabajo.EditValue = id
            .ProcesarOrdenTrabajo(id)
        End With
        Close()
    End Sub

    Private Sub txtBuscarOrden_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscarOrden.EditValueChanged
        ListadoOrdenesTrabajoTableAdapter.FillByIdOrdenEnProceso(DsProcesos.ListadoOrdenesTrabajo, CInt(txtBuscarOrden.EditValue), 1)
    End Sub

    Private Sub txtBuscarRecibo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscarRecibo.EditValueChanged
        ListadoOrdenesTrabajoTableAdapter.FillByReciboEnProceso(DsProcesos.ListadoOrdenesTrabajo, CInt(txtBuscarRecibo.EditValue), 1)
    End Sub

    Private Sub txtBuscarCliente_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscarCliente.EditValueChanged
        ListadoOrdenesTrabajoTableAdapter.FillByClienteEnProceso(DsProcesos.ListadoOrdenesTrabajo, String.Format("%{0}%", txtBuscarCliente.EditValue), 1)
    End Sub
End Class