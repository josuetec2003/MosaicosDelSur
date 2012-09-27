Public Class frmDialogClientes
    Private Desde As Integer
    ' 1: desde factura
    ' 2: desde orden trabajo
    ' 3: desde cotizacion

    Private Sub frmDialogClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClientesTableAdapter.Fill(DsCatalogos.Clientes)
    End Sub

    Private Sub txtBuscar_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.EditValueChanged
        ClientesTableAdapter.FillByNombre(DsCatalogos.Clientes, String.Format("%{0}%", txtBuscar.EditValue))
    End Sub

    Private Function DameId() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IdCliente")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub GridControl1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GridControl1.DoubleClick
        Agregar()
    End Sub

    Sub Agregar()
        Dim ID As Integer = DameId()

        If Desde = 1 Then
            With frmFacturar
                .IdClienteTextEdit.EditValue = ID
            End With
        ElseIf Desde = 2 Then
            With frmOrdenesTrabajo
                .IdClienteTextEdit.EditValue = ID
            End With
        ElseIf Desde = 3 Then
            With frmCotizacion
                .IdClienteTextEdit.EditValue = ID
            End With
        End If

        Close()
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
End Class