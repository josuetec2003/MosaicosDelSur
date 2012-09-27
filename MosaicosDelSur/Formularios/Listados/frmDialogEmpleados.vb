Public Class frmDialogEmpleados 

    Private Sub frmDialogEmpleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        EmpleadosTableAdapter.Fill(DsCatalogos.Empleados)
    End Sub

    Private Sub txtBuscar_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.EditValueChanged
        EmpleadosTableAdapter.FillByVarios(DsCatalogos.Empleados, String.Format("%{0}%", txtBuscar.EditValue))
    End Sub

    Private Function DameID() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdEmpleado")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick
        Dim ID As Integer = DameID()
        With frmOrdenesTrabajo
            .txtIdEntregador.EditValue = ID
        End With
        Close()
    End Sub

    Private Sub GridControl1_EditorKeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.EditorKeyPress
        If e.KeyChar = ChrW(13) Then
            Dim ID As Integer = DameID()
            With frmOrdenesTrabajo
                .txtIdEntregador.EditValue = ID
            End With
            Close()
        End If
    End Sub
End Class