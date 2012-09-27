Public Class frmListadoClientes

    Private Sub frmListadoClientes_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        CargarDatos()
    End Sub

    Private Sub frmListadoClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Sub CargarDatos()
        ClientesTableAdapter.Fill(DsCatalogos.Clientes)
    End Sub

    Private Function DameId() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdCliente")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick, EditarInformaciónToolStripMenuItem.Click
        Try
            frmAddClientes.Close()
        Catch ex As Exception
        End Try
        Dim ID As Integer = DameId()

        With frmAddClientes
            .MdiParent = Me.MdiParent
            .EsNuevo1 = False
            .IdCliente1 = ID
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Try
            frmAddClientes.Close()
        Catch ex As Exception
        End Try

        With frmAddClientes
            .MdiParent = Me.MdiParent
            .EsNuevo1 = True
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub GridControl1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl1.KeyPress
        If e.KeyChar = ChrW(13) Then
            Try
                frmAddClientes.Close()
            Catch ex As Exception
            End Try
            Dim ID As Integer = DameId()

            With frmAddClientes
                .MdiParent = Me.MdiParent
                .EsNuevo1 = False
                .IdCliente1 = ID
                .Show()
                .Focus()
            End With
        End If
    End Sub

    Private Sub txtBuscar_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.EditValueChanged
        ClientesTableAdapter.FillByNombre(DsCatalogos.Clientes, String.Format("%{0}%", txtBuscar.EditValue))
    End Sub
End Class