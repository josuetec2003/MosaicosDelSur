Public Class frmListadoOrdenesTrabajo

    Private Sub frmListadoOrdenesTrabajo_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CargarDatos()
    End Sub

    Private Sub frmListadoOrdenesTrabajo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        ListadoOrdenesTrabajoTableAdapter.FillByEstado(DsProcesos.ListadoOrdenesTrabajo, "En proceso")
    End Sub

    Private Sub RadioProceso_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioProceso.CheckedChanged
        If RadioProceso.Checked Then
            ListadoOrdenesTrabajoTableAdapter.FillByEstado(DsProcesos.ListadoOrdenesTrabajo, "En proceso")
            FacturarOrdenDeTrabajoToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub RadioEntregado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioEntregado.CheckedChanged
        If RadioEntregado.Checked Then
            ListadoOrdenesTrabajoTableAdapter.FillByEstado(DsProcesos.ListadoOrdenesTrabajo, "Entregado")
            FacturarOrdenDeTrabajoToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub txtOrdenNo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtOrdenNo.EditValueChanged
        If RadioProceso.Checked Then
            ListadoOrdenesTrabajoTableAdapter.FillByIdOrdenEnProceso(DsProcesos.ListadoOrdenesTrabajo, CInt(txtOrdenNo.EditValue), 1)
        ElseIf RadioEntregado.Checked Then
            ListadoOrdenesTrabajoTableAdapter.FillByIdOrdenEnProceso(DsProcesos.ListadoOrdenesTrabajo, CInt(txtOrdenNo.EditValue), 2)
        End If
    End Sub

    Private Sub txtRecibo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtRecibo.EditValueChanged
        If RadioProceso.Checked Then
            ListadoOrdenesTrabajoTableAdapter.FillByReciboEnProceso(DsProcesos.ListadoOrdenesTrabajo, CInt(txtRecibo.EditValue), 1)
        ElseIf RadioEntregado.Checked Then
            ListadoOrdenesTrabajoTableAdapter.FillByReciboEnProceso(DsProcesos.ListadoOrdenesTrabajo, CInt(txtRecibo.EditValue), 2)
        End If
    End Sub

    Private Sub txtCliente_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtCliente.EditValueChanged
        If RadioProceso.Checked Then
            ListadoOrdenesTrabajoTableAdapter.FillByClienteEnProceso(DsProcesos.ListadoOrdenesTrabajo, String.Format("%{0}%", txtCliente.EditValue), 1)
        ElseIf RadioEntregado.Checked Then
            ListadoOrdenesTrabajoTableAdapter.FillByClienteEnProceso(DsProcesos.ListadoOrdenesTrabajo, String.Format("%{0}%", txtCliente.EditValue), 2)
        End If
    End Sub

    Private Function DameOrden() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdOrdenTrabajo")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub FacturarOrdenDeTrabajoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturarOrdenDeTrabajoToolStripMenuItem.Click
        Try
            frmFacturar.Close()
        Catch ex As Exception
        End Try

        Dim ID As Integer = DameOrden()
        With frmFacturar
            .MdiParent = Me.MdiParent
            .txtOrdenTrabajo.EditValue = ID
            .txtNumFactura.EditValue = GenerarNumero(DameCodigoSiguiente("IdFactura", "Facturas", My.Settings.MosaicosDelSurDBConnectionString))
            .btnBuscarCliente.Enabled = False
            .ProcesarOrdenTrabajo(ID)
            .Show()
            .Focus()
        End With
    End Sub
End Class