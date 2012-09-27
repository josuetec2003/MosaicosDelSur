Public Class frmFacturar
    Private Desde As Integer
    '1: Boton de ribbon forms
    '2: Listado de facturas

    Private Sub frmFacturar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TamaniosTableAdapter.Fill(DsCatalogos.Tamanios)
        lblFecha.Text = DateTime.Now.ToLongDateString
        btnNuevo.Enabled = False

        If Desde = 1 Then
            txtNumFactura.EditValue = GenerarNumero(DameCodigoSiguiente("IdFactura", "Facturas", My.Settings.MosaicosDelSurDBConnectionString))
        End If

    End Sub

    Private Sub IdClienteTextEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles IdClienteTextEdit.EditValueChanged
        If Not IdClienteTextEdit.EditValue Is DBNull.Value Then
            ClientesTableAdapter.FillByIdCliente(DsCatalogos.Clientes, CInt(IdClienteTextEdit.EditValue))
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarCliente.Click
        With frmDialogClientes
            .Desde1 = 1
            .ShowDialog()
        End With
        btnBuscarProducto.Focus()
    End Sub

    Private Sub IdProductoTextEdit_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles IdProductoTextEdit.EditValueChanged
        If Not IdProductoTextEdit.EditValue Is DBNull.Value Then
            ProductosTableAdapter.FillByIdProducto(DsCatalogos.Productos, CInt(IdProductoTextEdit.EditValue))
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub btnBuscarProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarProducto.Click
        With frmDialogProductos
            .Desde1 = 1
            .ShowDialog()
        End With
        txtCantidad.Focus()
    End Sub

    Private Sub btnAgregarAFactura_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAFactura.Click
        Agregar()
    End Sub

#Region "Subs"

    Sub ProcesarOrdenTrabajo(ByVal IDORDEN As Integer)
        Try
            Using TaOrden As New dsProcesosTableAdapters.OrdenesTrabajoTableAdapter
                ' Obtener datos de la orden de trabajo
                Dim DtOrden As DataTable = TaOrden.GetDataByIdOrden(IDORDEN)

                'Cargar los datos del cliente que solicitó la orden
                ClientesTableAdapter.FillByIdCliente(DsCatalogos.Clientes, CInt(DtOrden(0)(1)))

                ' Asignar el id del cliente al textedit
                If IdClienteTextEdit.EditValue Is Nothing Then
                    IdClienteTextEdit.EditValue = DtOrden(0)(1)
                    'Label18.Text = DtOrden(0)(1)
                End If
            End Using

            ' Rutina par obtener el detalle de productos de la orden
            Using TaDetalle As New dsProcesosTableAdapters.DetalleOrdenTrabajoTableAdapter
                Dim DtDetalle As DataTable = TaDetalle.GetDataByIdOrden(IDORDEN)
                dgvDetalle.Rows.Clear()

                ' Recorrer el datatable que tiene todos los registros del detalle
                For Each linea In DtDetalle.Rows
                    Dim nombreProd As String = ""
                    'Obtener el nombre del producto y tamaño que hay en el detalle
                    Using TaProd As New dsCatalogosTableAdapters.NombreProductoTableAdapter
                        Dim DtProd As DataTable = TaProd.GetData(CInt(linea(1)))
                        nombreProd = DtProd(0)(0)
                    End Using

                    Dim subtotal As Double = CDbl(linea(2)) * CInt(linea(3))
                    Dim Descuento As Double = (CDbl(linea(2)) * CInt(linea(3)) * CInt(linea(4))) / 100
                    Dim total As Double = subtotal - Descuento

                    dgvDetalle.Rows.Add(linea(1), nombreProd, linea(2), linea(3), linea(4), total)
                Next
            End Using

            CalcularTotales()

            ' Obtener el abono de la orden de trabajo
            PanelAbono.Visible = True
            Using TaRecibo As New dsProcesosTableAdapters.RecibosTableAdapter
                Dim dtRecibo As DataTable = TaRecibo.GetDataByIdOrden(IDORDEN)
                txtAbonado.EditValue = dtRecibo(0)(2)
                txtPendiente.EditValue = CDbl(txtTotalPagar.EditValue) - CDbl(txtAbonado.EditValue)
            End Using

            BloquearEnOrden()
        Catch ex As Exception
        End Try
    End Sub

    Sub BloquearEnOrden()
        CreditoCheckBox.Enabled = False
        btnBuscarCliente.Enabled = False
        btnBuscarProducto.Enabled = False
        txtNombreCliente.Enabled = False
        txtTelefono.Enabled = False
        txtCorreo.Enabled = False
        txtPrecioUnitario.Enabled = False
        txtNombreProducto.Enabled = False
        txtCantidad.Enabled = False
        txtDescuento.Enabled = False
        btnAgregarAFactura.Enabled = False
        btnEliminarDeFactura.Enabled = False
    End Sub

    Sub InfoFactura(ByVal IDFACTURA As Integer, ByVal Credito As Boolean)

        Using TaFactura As New dsProcesosTableAdapters.FacturasTableAdapter
            TaFactura.FillByIdFactura(DsProcesos.Facturas, IDFACTURA)
            Dim DtFactura As DataTable = TaFactura.GetDataByIdFactura(IDFACTURA)
            ClientesTableAdapter.FillByIdCliente(DsCatalogos.Clientes, DtFactura(0)(1))

            txtNumFactura.EditValue = GenerarNumero(IDFACTURA)

            If IdClienteTextEdit.EditValue Is Nothing Then
                IdClienteTextEdit.EditValue = DtFactura(0)(1)
            End If
        End Using

        ' Rutina par obtener el detalle de productos de la orden
        Using TaDetalle As New dsProcesosTableAdapters.DetalleFacturaTableAdapter
            Dim DtDetalle As DataTable = TaDetalle.GetDataByIdFactura(IDFACTURA)
            dgvDetalle.Rows.Clear()

            ' Recorrer el datatable que tiene todos los registros del detalle
            For Each linea In DtDetalle.Rows
                Dim nombreProd As String = ""
                'Obtener el nombre del producto y tamaño que hay en el detalle
                Using TaProd As New dsCatalogosTableAdapters.NombreProductoTableAdapter
                    Dim DtProd As DataTable = TaProd.GetData(CInt(linea(1)))
                    nombreProd = DtProd(0)(0)
                End Using

                Dim subtotal As Double = CDbl(linea(2)) * CInt(linea(3))
                Dim Descuento As Double = (CDbl(linea(2)) * CInt(linea(3)) * CInt(linea(4))) / 100
                Dim total As Double = subtotal - Descuento

                dgvDetalle.Rows.Add(linea(1), nombreProd, linea(2), linea(3), linea(4), total)
            Next
        End Using

        CalcularTotales()

        If Credito Then
            btnCancelarCredito.Visible = True
        Else
            btnCancelarCredito.Visible = False
        End If
    End Sub

    Sub Agregar()
        If IdProductoTextEdit.EditValue Is Nothing Then
            MsgBox("Debes seleccionar un producto primero", MsgBoxStyle.Exclamation, "Falta producto")
        ElseIf (txtCantidad.EditValue Is Nothing) Or (txtCantidad.EditValue < 1) Then
            MsgBox("Debes ingresar la cantidad de producto a facturar", MsgBoxStyle.Exclamation, "Falta cantidad")
            txtCantidad.Focus()
        ElseIf CInt(txtCantidad.EditValue) > CInt(txtStock.EditValue) Then
            MsgBox(String.Format("La cantidad de producto ingresado sobrepasa la existencia: {0} unidades", txtStock.EditValue), MsgBoxStyle.Exclamation, "Producto insuficiente")
            Exit Sub
        Else
            'Recorrer el grid en buscar del mismo producto
            For i As Integer = 0 To dgvDetalle.Rows.Count - 1
                If Not dgvDetalle.Rows(i).Cells(0).Value Is Nothing Then
                    If dgvDetalle.Rows(i).Cells(0).Value = IdProductoTextEdit.EditValue Then
                        MsgBox(String.Format("No puedes agregar el producto porque ya está en la lista.{0}{0}Si desea agregar mas cantidad a un producto, elimínelo de la lista y agréguelo nuevamente.", Chr(13)), MsgBoxStyle.Exclamation, "Error")
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
        txtStock.EditValue = Nothing
    End Sub

    Sub LimpiarInfoCliente()
        IdClienteTextEdit.EditValue = Nothing
        txtNombreCliente.EditValue = Nothing
        txtTelefono.EditValue = Nothing
        txtCorreo.EditValue = Nothing
    End Sub

    Sub LimpiarInfoGeneral()
        txtOrdenTrabajo.EditValue = Nothing
        txtSubTotal.EditValue = Nothing
        txtTotalDescuento.EditValue = Nothing
        txtTotalPagar.EditValue = Nothing
        txtPago.EditValue = Nothing
        txtCambio.EditValue = Nothing
        txtNumFactura.EditValue = Nothing
        CreditoCheckBox.Checked = False
        dgvDetalle.Rows.Clear()
    End Sub

    Sub BloquearControles(ByVal TS As Boolean)
        CreditoCheckBox.Enabled = TS
        txtOrdenTrabajo.Enabled = TS
        txtNombreCliente.Enabled = TS
        txtTelefono.Enabled = TS
        txtCorreo.Enabled = TS
        txtPrecioUnitario.Enabled = TS
        txtNombreProducto.Enabled = TS
        txtCantidad.Enabled = TS
        txtDescuento.Enabled = TS
        dgvDetalle.Enabled = TS
        btnBuscarOrden.Enabled = TS
        btnBuscarCliente.Enabled = TS
        btnBuscarProducto.Enabled = TS
        btnAgregarAFactura.Enabled = TS
        btnEliminarDeFactura.Enabled = TS
        btnGuardar.Enabled = TS
        btnNuevo.Enabled = TS
    End Sub

    Sub RegistrarDetalleFactura(ByVal IdFactura As Integer)
        For i As Integer = 0 To dgvDetalle.Rows.Count - 1
            If Not dgvDetalle.Rows(i).Cells(0).Value Is Nothing Then
                Try
                    Using TaDetalle As New dsProcesosTableAdapters.DetalleFacturaTableAdapter
                        ' Agrega el producto al detalle de la factura
                        TaDetalle.Insert(IdFactura, CInt(dgvDetalle.Rows(i).Cells(0).Value), CDec(dgvDetalle.Rows(i).Cells(2).Value), CInt(dgvDetalle.Rows(i).Cells(3).Value), CInt(dgvDetalle.Rows(i).Cells(4).Value))

                        ' Reduce la existencia del producto en el inventario
                        ProductosTableAdapter.UpdateStock(CInt(dgvDetalle.Rows(i).Cells(3).Value), CInt(dgvDetalle.Rows(i).Cells(0).Value))
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Next
    End Sub

    Sub RegistrarEnArqueo(ByVal Factura As String, ByVal Cliente As String, ByVal Credito As Boolean, ByVal ConOrdenTrabajo As Boolean)
        Try
            Dim Mosaico As Double
            Dim Terrazo As Double
            Dim CementoGris As Double
            Dim CementoBlanco As Double
            Dim Bloque As Double
            Dim Solidex As Double
            Dim Varios As Double

            For i As Integer = 0 To dgvDetalle.Rows.Count - 1
                If Not dgvDetalle.Rows(i).Cells(0).Value Is Nothing Then
                    Dim NombreFacturado As String = dgvDetalle.Rows(i).Cells(1).Value
                    Dim NombreRecortado As String() = NombreFacturado.Split(" ")

                    Select Case NombreRecortado(0)
                        Case "MOSAICO"
                            Mosaico += CDbl(dgvDetalle.Rows(i).Cells(5).Value)
                        Case "TERRAZO"
                            Terrazo += CDbl(dgvDetalle.Rows(i).Cells(5).Value)
                        Case "CEMENTO"
                            If NombreRecortado(1) = "GRIS" Then
                                CementoGris += CDbl(dgvDetalle.Rows(i).Cells(5).Value)
                            ElseIf NombreRecortado(1) = "BLANCO" Then
                                CementoBlanco += CDbl(dgvDetalle.Rows(i).Cells(5).Value)
                            End If
                        Case "BLOQUE"
                            Bloque += CDbl(dgvDetalle.Rows(i).Cells(5).Value)
                        Case "SOLIDEX"
                            Solidex += CDbl(dgvDetalle.Rows(i).Cells(5).Value)
                        Case Else
                            Varios += CDbl(dgvDetalle.Rows(i).Cells(5).Value)
                    End Select
                End If
            Next

            Try
                If Credito Then
                    Arqueo(Factura, Cliente, Mosaico, Terrazo, CementoGris, CementoBlanco, Bloque, Solidex, Varios, 0, CDbl(txtTotalPagar.EditValue), 0)
                Else
                    If ConOrdenTrabajo Then
                        Arqueo(Factura, Cliente, Mosaico, Terrazo, CementoGris, CementoBlanco, Bloque, Solidex, Varios, 0, CDbl(txtTotalPagar.EditValue), 0)
                    Else
                        Arqueo(Factura, Cliente, Mosaico, Terrazo, CementoGris, CementoBlanco, Bloque, Solidex, Varios, CDbl(txtTotalPagar.EditValue), 0, 0)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
#End Region

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
            MsgBox("Debes seleccionar el cliente", MsgBoxStyle.Exclamation, "Cliente")
            Exit Sub
        End If

        If dgvDetalle.RowCount = 1 Then
            MsgBox("Debes agregar al menos un producto", MsgBoxStyle.Exclamation, "No hay productos")
            Exit Sub
        End If

        Try
            If CreditoCheckBox.Checked Then
                'Las facturas al credito se almacenar como NO CANCELADAS
                FacturasTableAdapter.Insert(CInt(IdClienteTextEdit.EditValue), UsuarioActivo.IdEmpleado, txtOrdenTrabajo.EditValue, Now, CreditoCheckBox.Checked, False)
            Else
                'Las facturas al contado y ordenes de trabajo se almacenan como CANCELADAS
                FacturasTableAdapter.Insert(CInt(IdClienteTextEdit.EditValue), UsuarioActivo.IdEmpleado, txtOrdenTrabajo.EditValue, Now, CreditoCheckBox.Checked, True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        If txtOrdenTrabajo.EditValue Is Nothing Then
            Dim FacturaSinOrden As Integer = DameFacturaSinOrden(My.Settings.MosaicosDelSurDBConnectionString)
            Dim FacturaNo As String = GenerarNumero(FacturaSinOrden)

            If Not CreditoCheckBox.Checked Then
                RegistrarEnArqueo(String.Format("Factura {0}", FacturaNo), txtNombreCliente.EditValue, False, False)
            End If
        Else
            Dim numRecibo As Integer

            ' Se cambia el estado de la orden a ENTREGADA
            Using TaOrden As New dsProcesosTableAdapters.OrdenesTrabajoTableAdapter
                TaOrden.UpdateEstadoOrden(2, CInt(txtOrdenTrabajo.EditValue))
            End Using

            'Se registra un recibo con el numero de factura
            Using TaRecibo As New dsProcesosTableAdapters.RecibosTableAdapter
                TaRecibo.Insert(Nothing, CDbl(txtPendiente.EditValue), CInt(txtNumFactura.EditValue))
                numRecibo = DameUltimoCodigo("IdRecibo", "Recibos", My.Settings.MosaicosDelSurDBConnectionString)
                AddAction(UsuarioActivo.IdUsuario, Now, "Insert", String.Format("Se registró el Recibo No. {0} con la factura {1}", numRecibo, CInt(txtNumFactura.EditValue)))
            End Using

            Dim numReciboStr As String = String.Format("Recibo {0}", GenerarNumero(numRecibo))
            Arqueo(numReciboStr, txtNombreCliente.EditValue, 0, 0, 0, 0, 0, 0, 0, txtPendiente.EditValue, 0, txtPendiente.EditValue)
            RegistrarEnArqueo(String.Format("Factura {0}", txtNumFactura.EditValue), txtNombreCliente.EditValue, False, True)
        End If

        ' Se obtiene el num de factura recien agregada sin importar que tenga orden de trabajo relacionada
        Dim FacturaNumero As Integer = DameUltimoCodigo("IdFactura", "Facturas", My.Settings.MosaicosDelSurDBConnectionString)

        AddAction(UsuarioActivo.IdUsuario, Now, "Insert", String.Format("Se registró factura No. {0}", FacturaNumero))
        RegistrarDetalleFactura(FacturaNumero)

        ' '' '' Si se esta facturando una orden de trabajo
        '' ''If Not txtOrdenTrabajo.EditValue Is Nothing Then
        '' ''    ' Se cambia el estado de la orden a ENTREGADA
        '' ''    Using TaOrden As New dsProcesosTableAdapters.OrdenesTrabajoTableAdapter
        '' ''        TaOrden.UpdateEstadoOrden(2, CInt(txtOrdenTrabajo.EditValue))
        '' ''    End Using

        '' ''    'Se registra un recibo con el numero de factura
        '' ''    Using TaRecibo As New dsProcesosTableAdapters.RecibosTableAdapter
        '' ''        TaRecibo.Insert(Nothing, CDbl(txtPendiente.EditValue), FacturaNumero)
        '' ''        Dim numRecibo As Integer = DameUltimoCodigo("IdRecibo", "Recibos", My.Settings.MosaicosDelSurDBConnectionString)
        '' ''        AddAction(UsuarioActivo.IdUsuario, Now, "Insert", String.Format("Se registró el Recibo No. {0} con la factura {1}", numRecibo, FacturaNumero))
        '' ''    End Using
        '' ''End If

        LimpiarInfoProducto()
        LimpiarInfoCliente()
        LimpiarInfoGeneral()
        BloquearControles(False)
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False
        PanelAbono.Visible = False

        If MsgBox(String.Format("Proceso completo!{0}¿Desea imprimir la factura?", Chr(13)), MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Facturación") = MsgBoxResult.Yes Then

        End If
    End Sub

    Private Sub btnNuevo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click
        BloquearControles(True)
        LimpiarInfoCliente()
        LimpiarInfoProducto()
        LimpiarInfoGeneral()
        txtNumFactura.EditValue = GenerarNumero(DameCodigoSiguiente("IdFactura", "Facturas", My.Settings.MosaicosDelSurDBConnectionString))
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        btnCancelarCredito.Visible = False
        btnBuscarCliente.Focus()
    End Sub

    Private Sub txtPago_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtPago.EditValueChanged
        Try
            txtCambio.EditValue = CDbl(txtPago.EditValue) - CDbl(txtTotalPagar.EditValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(13) Then
            Agregar()
        End If
    End Sub

    Private Sub btnBuscarOrden_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarOrden.Click
        frmDialogOrdenes.ShowDialog()
    End Sub

    Private Sub txtOrdenTrabajo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtOrdenTrabajo.EditValueChanged
        'ProcesarOrdenTrabajo(CInt(txtOrdenTrabajo.EditValue))
    End Sub

    Private Sub txtTotalPagar_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txtTotalPagar.EditValueChanged
        Try
            txtPendiente.EditValue = CDbl(txtTotalPagar.EditValue) - CDbl(txtAbonado.EditValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        BloquearControles(False)
        LimpiarInfoCliente()
        LimpiarInfoProducto()
        LimpiarInfoGeneral()
        PanelAbono.Visible = False
        btnCancelarCredito.Visible = False
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        frmDialogFacturas.ShowDialog()
    End Sub

    Private Sub txtDescuento_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescuento.KeyPress
        If e.KeyChar = ChrW(13) Then
            Agregar()
        End If
    End Sub

    Private Sub btnCancelarCredito_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelarCredito.Click
        Dim numRecibo As Integer

        'Se registra un recibo con el numero de factura
        Using TaRecibo As New dsProcesosTableAdapters.RecibosTableAdapter
            TaRecibo.Insert(Nothing, CDbl(txtTotalPagar.EditValue), CInt(txtNumFactura.EditValue))
            numRecibo = DameUltimoCodigo("IdRecibo", "Recibos", My.Settings.MosaicosDelSurDBConnectionString)
            AddAction(UsuarioActivo.IdUsuario, Now, "Insert", String.Format("Se registró el Recibo No. {0} con la factura {1}", numRecibo, CInt(txtNumFactura.EditValue)))
        End Using

        RegistrarEnArqueo(String.Format("Factura {0}", txtNumFactura.EditValue), txtNombreCliente.EditValue, True, False)
        Dim numReciboStr As String = String.Format("Recibo {0}", GenerarNumero(numRecibo))
        Arqueo(numReciboStr, txtNombreCliente.EditValue, 0, 0, 0, 0, 0, 0, 0, txtTotalPagar.EditValue, 0, txtTotalPagar.EditValue)
        FacturasTableAdapter.UpdateEstadoCancelacion(True, CInt(txtNumFactura.EditValue))

        If MsgBox("¿Desea imprimir el recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Recibo") = MsgBoxResult.Yes Then

        End If
        btnCancelarCredito.Enabled = False
    End Sub

    Public Property Desde1() As Integer
        Get
            Return Desde
        End Get
        Set(value As Integer)
            Desde = Value
        End Set
    End Property

    Private Function DameProducto() As Integer
        Try
            Return dgvDetalle.Rows(dgvDetalle.CurrentCell.ColumnIndex).Cells(0).Value
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim ID As Integer = DameProducto()

        If ID = 0 Then
            MsgBox("Seleccione el producto que desea ver", MsgBoxStyle.Exclamation, "No seleccionado")
        Else
            Try
                frmAddProductos.Close()
            Catch ex As Exception
            End Try
            With frmAddProductos
                .MdiParent = Me.MdiParent
                .EsNuevo1 = False
                .IdProducto1 = ID
                .Show()
                .Focus()
            End With
        End If
    End Sub
End Class