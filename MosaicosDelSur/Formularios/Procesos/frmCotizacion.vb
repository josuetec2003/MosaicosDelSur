Imports Vb = Microsoft.VisualBasic

Public Class frmCotizacion

    Private Sub frmCotizacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TamaniosTableAdapter.Fill(DsCatalogos.Tamanios)
        lblFecha.Text = DateTime.Now.ToLongDateString
        btnNuevo.Enabled = False
        CotizacionesBindingSource.AddNew()
        GenerarNumOrden()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarCliente.Click
        With frmDialogClientes
            .Desde1 = 3
            .ShowDialog()
        End With
        btnBuscarProducto.Focus()
    End Sub

#Region "Rutinas"
    Sub GenerarNumOrden()
        txtCotizacion.EditValue = Vb.Right("00000" + Trim(Str(DameCodigoSiguiente("IdCotizacion", "Cotizaciones", My.Settings.MosaicosDelSurDBConnectionString))), 6)
    End Sub

    Sub AgregarItemAFactura()
        If IdProductoTextEdit.EditValue Is Nothing Then
            MsgBox("Debes seleccionar un producto primero", MsgBoxStyle.Exclamation, "Falta producto")
            With frmDialogProductos
                .Desde1 = 3
                .ShowDialog()
            End With
            txtCantidad.Focus()
        ElseIf (txtCantidad.EditValue Is Nothing) Or (txtCantidad.EditValue < 1) Then
            MsgBox("Debes ingresar la cantidad de producto a facturar", MsgBoxStyle.Exclamation, "Falta cantidad")
            txtCantidad.Focus()
        Else

            'Recorrer el grid en buscar del mismo producto
            For i As Integer = 0 To dgvDetalle.Rows.Count - 1
                If Not dgvDetalle.Rows(i).Cells(0).Value Is Nothing Then
                    If dgvDetalle.Rows(i).Cells(0).Value = IdProductoTextEdit.EditValue Then
                        MsgBox("No puedes agregar el producto porque ya está en la lista", MsgBoxStyle.Exclamation, "Error")
                        Exit Sub
                    End If
                End If
            Next

            ' Nombre del producto mas el tamaño
            Dim nombreProducto As String = String.Format("{0} {1}", txtNombreProducto.EditValue, txtTamano.Text)

            ' Total de cada producto de la factura con el descuento aplicado: (Precio x Cantidad) - Descuento
            Dim totalLinea As Double = (CInt(txtCantidad.EditValue) * CDbl(txtPrecioUnitario.EditValue)) - (((CInt(txtCantidad.EditValue) * CDbl(txtPrecioUnitario.EditValue)) * CInt(txtDescuento.EditValue)) / 100)

            dgvDetalle.Rows.Add(IdProductoTextEdit.EditValue, nombreProducto, txtPrecioUnitario.EditValue, txtCantidad.EditValue, txtDescuento.EditValue, totalLinea)

            CalcularTotales()
            LimpiarInfoProducto()
            btnBuscarProducto.Focus()
        End If
    End Sub

    Sub LimpiarInfoProducto()
        IdProductoTextEdit.EditValue = Nothing
        txtNombreProducto.EditValue = Nothing
        txtPrecioUnitario.EditValue = Nothing
        txtTamano.EditValue = Nothing
        txtCantidad.EditValue = Nothing
        txtDescuento.EditValue = 0
    End Sub

    Sub LimpiarInfoCliente()
        IdClienteTextEdit.EditValue = Nothing
        txtNombreCliente.EditValue = Nothing
        txtTelefono.EditValue = Nothing
        txtCorreo.EditValue = Nothing
    End Sub

    Sub LimpiarInfoGeneral()
        txtSubTotal.EditValue = Nothing
        txtTotalDescuento.EditValue = Nothing
        txtTotalPagar.EditValue = Nothing
        txtCotizacion.EditValue = Nothing
    End Sub

    Sub BloquearControles(ByVal TS As Boolean)
        txtCotizacion.Enabled = TS
        txtNombreCliente.Enabled = TS
        txtTelefono.Enabled = TS
        txtCorreo.Enabled = TS
        txtPrecioUnitario.Enabled = TS
        txtNombreProducto.Enabled = TS
        txtCantidad.Enabled = TS
        txtDescuento.Enabled = TS
        dgvDetalle.Enabled = TS
        btnBuscarCliente.Enabled = TS
        btnBuscarProducto.Enabled = TS
    End Sub

    Sub CalcularTotales()
        Dim total As Double = 0
        Dim descto As Double = 0

        ' Para sumar los totales por linea
        For i As Integer = 0 To dgvDetalle.Rows.Count - 1
            If Not dgvDetalle.Rows(i).Cells(5).Value Is Nothing Then
                total += CDbl(dgvDetalle.Rows(i).Cells(2).Value) * CInt(dgvDetalle.Rows(i).Cells(3).Value)
            End If
        Next

        ' Para sumar los descuentos
        For i As Integer = 0 To dgvDetalle.Rows.Count - 1
            If Not dgvDetalle.Rows(i).Cells(5).Value Is Nothing Then
                descto += ((CInt(dgvDetalle.Rows(i).Cells(3).Value) * CDbl(dgvDetalle.Rows(i).Cells(2).Value)) * CInt(dgvDetalle.Rows(i).Cells(4).Value)) / 100
            End If
        Next

        txtSubTotal.EditValue = total
        txtTotalDescuento.EditValue = descto
        txtTotalPagar.EditValue = total - descto
    End Sub

    Sub RegistrarDetalleCotizacion(ByVal IdCotizacion As Integer)
        For i As Integer = 0 To dgvDetalle.Rows.Count - 1
            If Not dgvDetalle.Rows(i).Cells(0).Value Is Nothing Then
                Using TaDetalle As New dsProcesosTableAdapters.DetalleCotizacionTableAdapter

                    ' Agrega el producto al detalle de la factura
                    TaDetalle.Insert(IdCotizacion, CInt(dgvDetalle.Rows(i).Cells(0).Value), CDec(dgvDetalle.Rows(i).Cells(2).Value), CInt(dgvDetalle.Rows(i).Cells(3).Value), CInt(dgvDetalle.Rows(i).Cells(4).Value))
                End Using
            End If
        Next
    End Sub
#End Region

    Private Sub btnBuscarProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarProducto.Click
        With frmDialogProductos
            .Desde1 = 3
            .ShowDialog()
        End With
        txtCantidad.Focus()
    End Sub

    Private Sub IdProductoTextEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles IdProductoTextEdit.EditValueChanged
        If Not IdProductoTextEdit.EditValue Is DBNull.Value Then
            ProductosTableAdapter.FillByIdProducto(DsCatalogos.Productos, CInt(IdProductoTextEdit.EditValue))
        End If
    End Sub

    Private Sub btnAgregarAFactura_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAFactura.Click
        AgregarItemAFactura()
    End Sub

    Private Sub btnEliminarDeFactura_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarDeFactura.Click
        If dgvDetalle.RowCount > 1 Then
            If MsgBox("Confirma eliminación", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.Yes Then
                Try
                    dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow)
                    CalcularTotales()
                Catch ex As Exception
                    MsgBox("Seleccione el producto que desea eliminar", MsgBoxStyle.Exclamation, "Linea vacía")
                End Try
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If IdClienteTextEdit.Text = "" Then
            MsgBox("Debe seleccionar el cliente", MsgBoxStyle.Exclamation, "Cliente")
            Exit Sub
        End If

        If dgvDetalle.RowCount = 1 Then
            MsgBox("Debe agregar al menos un producto", MsgBoxStyle.Exclamation, "No hay productos")
            Exit Sub
        End If

        Try
            CotizacionesTableAdapter.Insert(IdClienteTextEdit.EditValue, UsuarioActivo.IdEmpleado, Now, Nothing)
            Dim NumCotizacion As Integer = DameUltimoCodigo("IdCotizacion", "Cotizaciones", My.Settings.MosaicosDelSurDBConnectionString)

            AddAction(UsuarioActivo.IdUsuario, Now, "Insert", String.Format("Se realizó una cotizacón con No. {0}", NumCotizacion))
            RegistrarDetalleCotizacion(NumCotizacion)

            btnGuardar.Enabled = False
            btnNuevo.Enabled = True
            btnAgregarAFactura.Enabled = False
            btnEliminarDeFactura.Enabled = False

            LimpiarInfoCliente()
            LimpiarInfoProducto()
            BloquearControles(False)
            dgvDetalle.Rows.Clear()
            LimpiarInfoGeneral()
            MsgBox("Cotización registrada")
            btnNuevo.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        CotizacionesBindingSource.AddNew()
        GenerarNumOrden()
        BloquearControles(True)
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        btnAgregarAFactura.Enabled = True
        btnEliminarDeFactura.Enabled = True
        btnBuscarCliente.Focus()
    End Sub

    Private Sub IdClienteTextEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles IdClienteTextEdit.EditValueChanged
        If Not IdClienteTextEdit.EditValue Is DBNull.Value Then
            ClientesTableAdapter.FillByIdCliente(DsCatalogos.Clientes, CInt(IdClienteTextEdit.EditValue))
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(13) Then
            AgregarItemAFactura()
        End If
    End Sub

    Private Sub frmCotizacion_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        btnBuscarCliente.Focus()
    End Sub
End Class