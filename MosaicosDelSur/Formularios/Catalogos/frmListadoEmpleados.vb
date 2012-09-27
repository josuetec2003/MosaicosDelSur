Public Class frmListadoEmpleados

    Private Sub frmListadoEmpleados_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CargarDatos()
    End Sub

    Private Sub XtraForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        EmpleadosTableAdapter.Fill(DsCatalogos.Empleados)
    End Sub

    Private Function DameId() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdEmpleado")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick
        Try
            frmAddEmpleado.Close()
        Catch ex As Exception
        End Try

        Dim ID As Integer = DameId()
        With frmAddEmpleado
            .MdiParent = Me.MdiParent
            .EsNuevo1 = False
            .IdEmpleado1 = ID
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub txtOK_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.EditValueChanged
        EmpleadosTableAdapter.FillByVarios(DsCatalogos.Empleados, String.Format("%{0}%", txtBuscar.EditValue))
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs)
        Try
            frmAddEmpleado.Close()
        Catch ex As Exception
        End Try

        With frmAddEmpleado
            .MdiParent = Me.MdiParent
            .EsNuevo1 = True
            .Show()
            .Focus()
        End With
    End Sub
End Class