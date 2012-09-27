Public Class frmListadoRecibos

    Private Sub frmListadoRecibos_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CargarDatos()
    End Sub

    Private Sub frmListadoRecibos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        RecibosOrdenesTableAdapter.Fill(DsProcesos.RecibosOrdenes)
        RecibosFacturasTableAdapter.Fill(DsProcesos.RecibosFacturas)
    End Sub

End Class