Public Class frmListadoFacturas

    Private Sub frmListadoFacturas_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CargarDatos()
    End Sub

    Private Sub frmListadoFacturas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        VerFacturaCompletaToolStripMenuItem.Enabled = False
        CargarDatos()
    End Sub

    Sub CargarDatos()
        Dim Tipo As Boolean
        Dim Cancelada As Boolean

        If radioContado.Checked Then
            Tipo = False
            Cancelada = True
        ElseIf radioCreditoPendientes.Checked Then
            Tipo = True
            Cancelada = False
        ElseIf radioCreditoCanceladas.Checked Then
            Tipo = True
            Cancelada = True
        End If
        ListadoFacturasTableAdapter.FillByCredito(DsProcesos.ListadoFacturas, Tipo, Cancelada)
    End Sub

    Private Sub txtNumFactura_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtNumFactura.EditValueChanged
        ListadoFacturasTableAdapter.FillByIdFactura(DsProcesos.ListadoFacturas, CInt(txtNumFactura.EditValue))
    End Sub

    Private Sub txtCliente_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtCliente.EditValueChanged
        ListadoFacturasTableAdapter.FillByCliente(DsProcesos.ListadoFacturas, String.Format("%{0}%", txtCliente.EditValue))
    End Sub

    Private Sub radioCreditoPendientes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioCreditoPendientes.CheckedChanged
        If radioCreditoPendientes.Checked Then
            VerFacturaCompletaToolStripMenuItem.Enabled = True
            ListadoFacturasTableAdapter.FillByCredito(DsProcesos.ListadoFacturas, True, False)
        End If
    End Sub

    Private Sub radioCreditoCanceladas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioCreditoCanceladas.CheckedChanged
        If radioCreditoCanceladas.Checked Then
            VerFacturaCompletaToolStripMenuItem.Enabled = False
            ListadoFacturasTableAdapter.FillByCredito(DsProcesos.ListadoFacturas, True, True)
        End If
    End Sub

    Private Sub radioContado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioContado.CheckedChanged
        If radioContado.Checked Then
            VerFacturaCompletaToolStripMenuItem.Enabled = False
            ListadoFacturasTableAdapter.FillByCredito(DsProcesos.ListadoFacturas, False, True)
        End If
    End Sub

    Private Sub VerFacturaCompletaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerFacturaCompletaToolStripMenuItem.Click
        Try
            frmFacturar.Close()
        Catch ex As Exception
        End Try
        Dim ID As Integer = DameFactura()
        With frmFacturar
            .MdiParent = Me.MdiParent
            .InfoFactura(ID, True)
            .btnEliminarDeFactura.Enabled = False
            .btnAgregarAFactura.Enabled = False
            .btnBuscarProducto.Enabled = False
            .btnBuscarCliente.Enabled = False
            .btnBuscarOrden.Enabled = False
            .btnGuardar.Enabled = False
            .Show()
            .Focus()
        End With
    End Sub

    Private Function DameFactura() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdFactura")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class