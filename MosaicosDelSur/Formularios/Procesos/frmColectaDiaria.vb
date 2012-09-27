Public Class frmColectaDiaria

    Private Sub frmColectaDiaria_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CargarDatos()
    End Sub

    Private Sub frmColectaDiaria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        ArqueoTableAdapter.FillByFecha(DsProcesos.Arqueo, Date.Now)
    End Sub

    Private Sub DateEditArqueos_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles DateEditArqueos.EditValueChanged
        ArqueoTableAdapter.FillByFecha(DsProcesos.Arqueo, DateEditArqueos.EditValue)
    End Sub
End Class