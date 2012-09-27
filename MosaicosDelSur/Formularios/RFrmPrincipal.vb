Imports DevExpress.LookAndFeel
Imports System.Data.SqlClient

Public Class RFrmPrincipal
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue")
    End Sub

    Sub GestionarPanel()
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            ClientPanel.Visible = True
        Else
            ClientPanel.Visible = False
        End If
    End Sub

    Private Sub BarBtnProductos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnProductos.ItemClick, BarBtnAgregarProducto.ItemClick
        Try
            frmAddProductos.Close()
        Catch ex As Exception
        End Try

        With frmAddProductos
            .MdiParent = Me
            .EsNuevo1 = True
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(sender As Object, e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded, XtraTabbedMdiManager1.PageRemoved
        GestionarPanel()
    End Sub

    Private Sub BarBtnListadoProductos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnListadoProductos.ItemClick
        With frmListadoProductos
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnEmpleados_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnEmpleados.ItemClick, BarBtnAgregarEmpleado.ItemClick
        With frmAddEmpleado
            .MdiParent = Me
            .EsNuevo1 = True
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnListadoEmpleados_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnListadoEmpleados.ItemClick
        Try
            frmListadoEmpleados.Close()
        Catch ex As Exception
        End Try

        With frmListadoEmpleados
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnClientes_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnClientes.ItemClick, BarBtnAgregarCliente.ItemClick
        With frmAddClientes
            .MdiParent = Me
            .EsNuevo1 = True
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnListadoClientes_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnListadoClientes.ItemClick
        Try
            frmListadoClientes.Close()
        Catch ex As Exception
        End Try

        With frmListadoClientes
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnTamanios_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnTamanios.ItemClick
        With frmTamanios
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub RFrmPrincipal_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AddAction(UsuarioActivo.IdUsuario, Now, "Cierre sesión", "Se cerró sesión")
    End Sub

    Private Sub BarBtnFacturar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnFacturar.ItemClick
        Try
            frmFacturar.Close()
        Catch ex As Exception
        End Try
        With frmFacturar
            .MdiParent = Me
            .Desde1 = 1
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnOrdenTrabajo_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnOrdenTrabajo.ItemClick
        Try
            frmOrdenesTrabajo.Close()
        Catch ex As Exception
        End Try
        With frmOrdenesTrabajo
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnListadoFacturas_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnListadoFacturas.ItemClick
        With frmListadoFacturas
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnListadoOrdenes_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnListadoOrdenes.ItemClick
        With frmListadoOrdenesTrabajo
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub RFrmPrincipal_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Using TaEmpresa As New dsCatalogosTableAdapters.DatosGeneralesTableAdapter
            Dim DtEmpresa As DataTable = TaEmpresa.GetData()
            If DtEmpresa.Rows.Count = 0 Then
                Text = "Configurar empresa"
                RibbonPage1.Visible = False
                RibbonPage2.Visible = False
                RibbonPage3.Visible = False
                With frmDatosEmpresa
                    .MdiParent = Me
                    .Text = "Definir datos de la empresa"
                    .EsNuevo1 = True
                    .Show()
                    .Focus()
                End With
            Else
                EmpresaActiva.IdEmpresa = DtEmpresa(0)(0)
                EmpresaActiva.NombreEmpresa = DtEmpresa(0)(1)
                RibbonControl.Minimized = True
                Text = EmpresaActiva.NombreEmpresa
            End If
        End Using
        BarTxtUser.Caption = String.Format("{0} {1} ( {2} )", UsuarioActivo.Nombre, UsuarioActivo.Apellido, UsuarioActivo.Username)
        BarTxtFecha.Caption = DateTime.Now.ToLongDateString
    End Sub

    Private Sub BarBtnEmpresa_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnEmpresa.ItemClick
        With frmDatosEmpresa
            .MdiParent = Me
            .EsNuevo1 = False
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnCotizacion_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnCotizacion.ItemClick
        Try
            frmCotizacion.Close()
        Catch ex As Exception
        End Try
        With frmCotizacion
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnAgregarUsuario_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnAgregarUsuario.ItemClick
        Try
            frmUsuario.Close()
        Catch ex As Exception
        End Try

        With frmUsuario
            .MdiParent = Me
            .EsNuevo1 = True
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnListadoUsuario_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnListadoUsuario.ItemClick
        With frmListadoUsuarios
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnCambiarPass_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnCambiarPass.ItemClick
        With frmCambiarPass
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub RFrmPrincipal_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim str As String = String.Format("Aplicación comercial para Terrazos y Mosaicos del Sur.{0}{0}Desarrollado por Josué Alvarez{0}(504) 9797-8830 | josuetec2003@gmail.com", Chr(13))
            MsgBox(str, MsgBoxStyle.Information, "@josuetec2003")
        End If
    End Sub

    Private Sub BarBtnColectaDiaria_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnColectaDiaria.ItemClick
        With frmColectaDiaria
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnReiniciar_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnReiniciar.ItemClick
        Dim msj As String = String.Format("Este proceso eliminará permanentemente los Recibos, Ordenes de trabajo, Facturas y los Arqueos.{0}{0}Para continuar debe ingresar nuevamente su Usuario y Contraseña.{0}{0}¿Desea continuar?", Chr(13))

        If MsgBox(msj, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Tenga cuidado") = MsgBoxResult.Yes Then
            If My.Forms.frmComprobarCredenciales.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    Using CNN As New SqlConnection(My.Settings.MosaicosDelSurDBConnectionString)
                        Using DA As New SqlDataAdapter()

                            Dim SQL As String = "DELETE FROM Recibos;"
                            SQL &= "DELETE FROM Arqueo;"
                            SQL &= "DELETE FROM DetalleOrdenTrabajo;"
                            SQL &= "DELETE FROM DetalleFactura;"
                            SQL &= "DELETE FROM Facturas;"
                            SQL &= "DELETE FROM OrdenesTrabajo;"
                            SQL &= "DBCC CHECKIDENT (OrdenesTrabajo, RESEED, 0);"
                            SQL &= "DBCC CHECKIDENT (Facturas, RESEED, 0);"
                            SQL &= "DBCC CHECKIDENT (Recibos, RESEED, 0);"
                            SQL &= "DBCC CHECKIDENT (Arqueo, RESEED, 0);"


                            DA.DeleteCommand = New SqlCommand(SQL, CNN)
                            CNN.Open()
                            DA.DeleteCommand.ExecuteNonQuery()
                            CNN.Close()
                        End Using
                    End Using

                    MsgBox("Los datos de Arqueo, Recibos, Ordenes de trabajo y Facturas han sido eliminados permanentemente", MsgBoxStyle.Information, "Datos reiniciados")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub BarBtnPermisos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnPermisos.ItemClick
        With frmPermisos
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarBtnRecibos_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarBtnRecibos.ItemClick
        With frmListadoRecibos
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub
End Class