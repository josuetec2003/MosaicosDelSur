<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFrmPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.BarBtnCambiarUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnProductos = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenuProductos = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarBtnAgregarProducto = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnListadoProductos = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnEmpleados = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenuEmpleados = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarBtnAgregarEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnListadoEmpleados = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenuClientes = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarBtnAgregarCliente = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnListadoClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnTamanios = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnEmpresa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnFacturar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnOrdenTrabajo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnCotizacion = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnListadoFacturas = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnListadoOrdenes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnAgregarUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnListadoUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnPermisos = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnListadoCotizaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnColectaDiaria = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnGraficoVentas = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnCambiarPass = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnReiniciar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarBtnRecibos = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarTxtUser = New DevExpress.XtraBars.BarStaticItem()
        Me.BarTxtFecha = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.ClientPanel = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonDropDownControl = Me.ApplicationMenu1
        Me.RibbonControl.ApplicationButtonText = Nothing
        Me.RibbonControl.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.[Default]
        Me.RibbonControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarBtnCambiarUsuario, Me.BarBtnSalir, Me.BarBtnProductos, Me.BarBtnAgregarProducto, Me.BarBtnListadoProductos, Me.BarBtnEmpleados, Me.BarBtnAgregarEmpleado, Me.BarBtnListadoEmpleados, Me.BarBtnClientes, Me.BarBtnAgregarCliente, Me.BarBtnListadoClientes, Me.BarBtnTamanios, Me.BarBtnEmpresa, Me.BarBtnFacturar, Me.BarBtnOrdenTrabajo, Me.BarBtnCotizacion, Me.BarBtnListadoFacturas, Me.BarBtnListadoOrdenes, Me.BarBtnAgregarUsuario, Me.BarBtnListadoUsuario, Me.BarBtnPermisos, Me.BarBtnListadoCotizaciones, Me.BarBtnColectaDiaria, Me.BarBtnGraficoVentas, Me.BarBtnCambiarPass, Me.BarBtnReiniciar, Me.BarBtnRecibos, Me.BarStaticItem1, Me.BarTxtUser, Me.BarTxtFecha})
        Me.RibbonControl.ItemsVertAlign = DevExpress.Utils.VertAlignment.[Default]
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 34
        Me.RibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.[Default]
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.[Default]
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2, Me.RibbonPage1, Me.RibbonPage3})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTimeEdit1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl.SelectedPage = Me.RibbonPage2
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.[Default]
        Me.RibbonControl.Size = New System.Drawing.Size(751, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.[Default]
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.BottomPaneControlContainer = Nothing
        Me.ApplicationMenu1.ItemLinks.Add(Me.BarBtnCambiarUsuario)
        Me.ApplicationMenu1.ItemLinks.Add(Me.BarBtnSalir)
        Me.ApplicationMenu1.MenuAppearance.Menu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ApplicationMenu1.MenuAppearance.Menu.Options.UseTextOptions = True
        Me.ApplicationMenu1.MenuAppearance.Menu.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ApplicationMenu1.MenuAppearance.Menu.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ApplicationMenu1.MenuAppearance.Menu.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ApplicationMenu1.MenuAppearance.Menu.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ApplicationMenu1.MenuAppearance.Menu.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ApplicationMenu1.MenuAppearance.MenuBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ApplicationMenu1.MenuAppearance.MenuBar.Options.UseTextOptions = True
        Me.ApplicationMenu1.MenuAppearance.MenuBar.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ApplicationMenu1.MenuAppearance.MenuBar.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ApplicationMenu1.MenuAppearance.MenuBar.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ApplicationMenu1.MenuAppearance.MenuBar.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.ApplicationMenu1.MenuAppearance.MenuBar.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStrip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ApplicationMenu1.MenuAppearance.SideStrip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStrip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStrip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStrip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStrip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStripNonRecent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ApplicationMenu1.MenuAppearance.SideStripNonRecent.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStripNonRecent.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStripNonRecent.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStripNonRecent.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ApplicationMenu1.MenuAppearance.SideStripNonRecent.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ApplicationMenu1.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.[Default]
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        Me.ApplicationMenu1.Ribbon = Me.RibbonControl
        Me.ApplicationMenu1.RightPaneControlContainer = Nothing
        Me.ApplicationMenu1.ShowRightPane = True
        '
        'BarBtnCambiarUsuario
        '
        Me.BarBtnCambiarUsuario.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnCambiarUsuario.Appearance.Options.UseTextOptions = True
        Me.BarBtnCambiarUsuario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.BarBtnCambiarUsuario.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnCambiarUsuario.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnCambiarUsuario.Caption = "Cambiar de usuario"
        Me.BarBtnCambiarUsuario.Id = 2
        Me.BarBtnCambiarUsuario.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnCambiarUsuario.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.ceo
        Me.BarBtnCambiarUsuario.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnCambiarUsuario.Name = "BarBtnCambiarUsuario"
        Me.BarBtnCambiarUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnSalir
        '
        Me.BarBtnSalir.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnSalir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnSalir.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnSalir.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnSalir.Caption = "Salir"
        Me.BarBtnSalir.Id = 3
        Me.BarBtnSalir.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnSalir.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.door_out
        Me.BarBtnSalir.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnSalir.Name = "BarBtnSalir"
        Me.BarBtnSalir.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnProductos
        '
        Me.BarBtnProductos.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnProductos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnProductos.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnProductos.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarBtnProductos.Caption = "Productos"
        Me.BarBtnProductos.DropDownControl = Me.PopupMenuProductos
        Me.BarBtnProductos.Id = 5
        Me.BarBtnProductos.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnProductos.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.basket
        Me.BarBtnProductos.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnProductos.Name = "BarBtnProductos"
        Me.BarBtnProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'PopupMenuProductos
        '
        Me.PopupMenuProductos.ItemLinks.Add(Me.BarBtnAgregarProducto)
        Me.PopupMenuProductos.ItemLinks.Add(Me.BarBtnListadoProductos)
        Me.PopupMenuProductos.MenuAppearance.Menu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuProductos.MenuAppearance.Menu.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.Menu.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuProductos.MenuAppearance.Menu.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuProductos.MenuAppearance.Menu.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.Menu.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuProductos.MenuAppearance.MenuBar.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuBar.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuBar.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuBar.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuBar.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuProductos.MenuAppearance.MenuCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.MenuCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStrip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuProductos.MenuAppearance.SideStrip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStrip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStrip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStrip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStrip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStripNonRecent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuProductos.MenuAppearance.SideStripNonRecent.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStripNonRecent.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStripNonRecent.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStripNonRecent.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuProductos.MenuAppearance.SideStripNonRecent.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuProductos.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.[Default]
        Me.PopupMenuProductos.Name = "PopupMenuProductos"
        Me.PopupMenuProductos.Ribbon = Me.RibbonControl
        '
        'BarBtnAgregarProducto
        '
        Me.BarBtnAgregarProducto.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnAgregarProducto.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnAgregarProducto.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnAgregarProducto.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnAgregarProducto.Caption = "Agregar &producto"
        Me.BarBtnAgregarProducto.Glyph = Global.MosaicosDelSur.My.Resources.Resources.add
        Me.BarBtnAgregarProducto.Id = 6
        Me.BarBtnAgregarProducto.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnAgregarProducto.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnAgregarProducto.Name = "BarBtnAgregarProducto"
        Me.BarBtnAgregarProducto.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnListadoProductos
        '
        Me.BarBtnListadoProductos.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnListadoProductos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoProductos.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoProductos.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnListadoProductos.Caption = "Listado de productos"
        Me.BarBtnListadoProductos.Glyph = Global.MosaicosDelSur.My.Resources.Resources.application_view_detail
        Me.BarBtnListadoProductos.Id = 7
        Me.BarBtnListadoProductos.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnListadoProductos.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnListadoProductos.Name = "BarBtnListadoProductos"
        Me.BarBtnListadoProductos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnEmpleados
        '
        Me.BarBtnEmpleados.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnEmpleados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnEmpleados.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnEmpleados.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarBtnEmpleados.Caption = "Empleados"
        Me.BarBtnEmpleados.DropDownControl = Me.PopupMenuEmpleados
        Me.BarBtnEmpleados.Id = 8
        Me.BarBtnEmpleados.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnEmpleados.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.user_green
        Me.BarBtnEmpleados.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnEmpleados.Name = "BarBtnEmpleados"
        Me.BarBtnEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'PopupMenuEmpleados
        '
        Me.PopupMenuEmpleados.ItemLinks.Add(Me.BarBtnAgregarEmpleado)
        Me.PopupMenuEmpleados.ItemLinks.Add(Me.BarBtnListadoEmpleados)
        Me.PopupMenuEmpleados.MenuAppearance.Menu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuEmpleados.MenuAppearance.Menu.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.Menu.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.Menu.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.Menu.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.Menu.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuEmpleados.MenuAppearance.MenuBar.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuBar.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuBar.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuBar.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuBar.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuEmpleados.MenuAppearance.MenuCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.MenuCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStrip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuEmpleados.MenuAppearance.SideStrip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStrip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStrip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStrip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStrip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStripNonRecent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuEmpleados.MenuAppearance.SideStripNonRecent.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStripNonRecent.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStripNonRecent.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStripNonRecent.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuEmpleados.MenuAppearance.SideStripNonRecent.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuEmpleados.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.[Default]
        Me.PopupMenuEmpleados.Name = "PopupMenuEmpleados"
        Me.PopupMenuEmpleados.Ribbon = Me.RibbonControl
        '
        'BarBtnAgregarEmpleado
        '
        Me.BarBtnAgregarEmpleado.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnAgregarEmpleado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnAgregarEmpleado.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnAgregarEmpleado.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnAgregarEmpleado.Caption = "Agregar empleado"
        Me.BarBtnAgregarEmpleado.Glyph = Global.MosaicosDelSur.My.Resources.Resources.add
        Me.BarBtnAgregarEmpleado.Id = 9
        Me.BarBtnAgregarEmpleado.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnAgregarEmpleado.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnAgregarEmpleado.Name = "BarBtnAgregarEmpleado"
        Me.BarBtnAgregarEmpleado.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnListadoEmpleados
        '
        Me.BarBtnListadoEmpleados.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnListadoEmpleados.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoEmpleados.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoEmpleados.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnListadoEmpleados.Caption = "Listado de empleados"
        Me.BarBtnListadoEmpleados.Glyph = Global.MosaicosDelSur.My.Resources.Resources.application_view_detail
        Me.BarBtnListadoEmpleados.Id = 10
        Me.BarBtnListadoEmpleados.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnListadoEmpleados.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnListadoEmpleados.Name = "BarBtnListadoEmpleados"
        Me.BarBtnListadoEmpleados.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnClientes
        '
        Me.BarBtnClientes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnClientes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnClientes.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnClientes.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarBtnClientes.Caption = "Clientes"
        Me.BarBtnClientes.DropDownControl = Me.PopupMenuClientes
        Me.BarBtnClientes.Id = 11
        Me.BarBtnClientes.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnClientes.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.user_blondy
        Me.BarBtnClientes.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnClientes.Name = "BarBtnClientes"
        Me.BarBtnClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'PopupMenuClientes
        '
        Me.PopupMenuClientes.ItemLinks.Add(Me.BarBtnAgregarCliente)
        Me.PopupMenuClientes.ItemLinks.Add(Me.BarBtnListadoClientes)
        Me.PopupMenuClientes.MenuAppearance.Menu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuClientes.MenuAppearance.Menu.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.Menu.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuClientes.MenuAppearance.Menu.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuClientes.MenuAppearance.Menu.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.Menu.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuClientes.MenuAppearance.MenuBar.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuBar.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuBar.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuBar.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuBar.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuClientes.MenuAppearance.MenuCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.MenuCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStrip.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuClientes.MenuAppearance.SideStrip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStrip.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStrip.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStrip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStrip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStripNonRecent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PopupMenuClientes.MenuAppearance.SideStripNonRecent.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStripNonRecent.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStripNonRecent.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStripNonRecent.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PopupMenuClientes.MenuAppearance.SideStripNonRecent.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PopupMenuClientes.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.[Default]
        Me.PopupMenuClientes.Name = "PopupMenuClientes"
        Me.PopupMenuClientes.Ribbon = Me.RibbonControl
        '
        'BarBtnAgregarCliente
        '
        Me.BarBtnAgregarCliente.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnAgregarCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnAgregarCliente.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnAgregarCliente.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnAgregarCliente.Caption = "Agregar cliente"
        Me.BarBtnAgregarCliente.Glyph = Global.MosaicosDelSur.My.Resources.Resources.add
        Me.BarBtnAgregarCliente.Id = 12
        Me.BarBtnAgregarCliente.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnAgregarCliente.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnAgregarCliente.Name = "BarBtnAgregarCliente"
        Me.BarBtnAgregarCliente.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnListadoClientes
        '
        Me.BarBtnListadoClientes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnListadoClientes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoClientes.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoClientes.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnListadoClientes.Caption = "Listado de clientes"
        Me.BarBtnListadoClientes.Glyph = Global.MosaicosDelSur.My.Resources.Resources.application_view_detail
        Me.BarBtnListadoClientes.Id = 13
        Me.BarBtnListadoClientes.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnListadoClientes.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnListadoClientes.Name = "BarBtnListadoClientes"
        Me.BarBtnListadoClientes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnTamanios
        '
        Me.BarBtnTamanios.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnTamanios.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnTamanios.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnTamanios.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnTamanios.Caption = "Tamaños"
        Me.BarBtnTamanios.Id = 14
        Me.BarBtnTamanios.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnTamanios.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.layer_to_image_size
        Me.BarBtnTamanios.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnTamanios.Name = "BarBtnTamanios"
        Me.BarBtnTamanios.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnEmpresa
        '
        Me.BarBtnEmpresa.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnEmpresa.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnEmpresa.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnEmpresa.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnEmpresa.Caption = "Empresa"
        Me.BarBtnEmpresa.Id = 16
        Me.BarBtnEmpresa.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnEmpresa.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.company
        Me.BarBtnEmpresa.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnEmpresa.Name = "BarBtnEmpresa"
        Me.BarBtnEmpresa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnFacturar
        '
        Me.BarBtnFacturar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnFacturar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnFacturar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnFacturar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnFacturar.Caption = "Facturar"
        Me.BarBtnFacturar.Id = 17
        Me.BarBtnFacturar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnFacturar.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.cash_register
        Me.BarBtnFacturar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnFacturar.Name = "BarBtnFacturar"
        Me.BarBtnFacturar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnOrdenTrabajo
        '
        Me.BarBtnOrdenTrabajo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnOrdenTrabajo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnOrdenTrabajo.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnOrdenTrabajo.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnOrdenTrabajo.Caption = "Orden de Trabajo"
        Me.BarBtnOrdenTrabajo.Id = 18
        Me.BarBtnOrdenTrabajo.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnOrdenTrabajo.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.work_order
        Me.BarBtnOrdenTrabajo.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnOrdenTrabajo.Name = "BarBtnOrdenTrabajo"
        Me.BarBtnOrdenTrabajo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnCotizacion
        '
        Me.BarBtnCotizacion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnCotizacion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnCotizacion.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnCotizacion.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnCotizacion.Caption = "Cotización"
        Me.BarBtnCotizacion.Id = 19
        Me.BarBtnCotizacion.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnCotizacion.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.quote
        Me.BarBtnCotizacion.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnCotizacion.Name = "BarBtnCotizacion"
        Me.BarBtnCotizacion.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnListadoFacturas
        '
        Me.BarBtnListadoFacturas.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnListadoFacturas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoFacturas.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoFacturas.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnListadoFacturas.Caption = "Listado de Facturas"
        Me.BarBtnListadoFacturas.Id = 20
        Me.BarBtnListadoFacturas.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnListadoFacturas.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.lists
        Me.BarBtnListadoFacturas.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnListadoFacturas.Name = "BarBtnListadoFacturas"
        Me.BarBtnListadoFacturas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnListadoOrdenes
        '
        Me.BarBtnListadoOrdenes.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnListadoOrdenes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoOrdenes.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoOrdenes.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnListadoOrdenes.Caption = "Listado Ordenes Trabajo"
        Me.BarBtnListadoOrdenes.Id = 21
        Me.BarBtnListadoOrdenes.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnListadoOrdenes.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.lists
        Me.BarBtnListadoOrdenes.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnListadoOrdenes.Name = "BarBtnListadoOrdenes"
        Me.BarBtnListadoOrdenes.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnAgregarUsuario
        '
        Me.BarBtnAgregarUsuario.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnAgregarUsuario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnAgregarUsuario.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnAgregarUsuario.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnAgregarUsuario.Caption = "Agregar usuario"
        Me.BarBtnAgregarUsuario.Id = 22
        Me.BarBtnAgregarUsuario.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnAgregarUsuario.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.user_add
        Me.BarBtnAgregarUsuario.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnAgregarUsuario.Name = "BarBtnAgregarUsuario"
        Me.BarBtnAgregarUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnListadoUsuario
        '
        Me.BarBtnListadoUsuario.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnListadoUsuario.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoUsuario.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoUsuario.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnListadoUsuario.Caption = "Listado de usuarios"
        Me.BarBtnListadoUsuario.Id = 23
        Me.BarBtnListadoUsuario.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnListadoUsuario.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.application_view_list
        Me.BarBtnListadoUsuario.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnListadoUsuario.Name = "BarBtnListadoUsuario"
        Me.BarBtnListadoUsuario.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnPermisos
        '
        Me.BarBtnPermisos.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnPermisos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnPermisos.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnPermisos.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnPermisos.Caption = "Permisos de usuario"
        Me.BarBtnPermisos.Id = 24
        Me.BarBtnPermisos.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnPermisos.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.user_permission
        Me.BarBtnPermisos.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnPermisos.Name = "BarBtnPermisos"
        Me.BarBtnPermisos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnListadoCotizaciones
        '
        Me.BarBtnListadoCotizaciones.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnListadoCotizaciones.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoCotizaciones.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnListadoCotizaciones.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnListadoCotizaciones.Caption = "Listado de Cotizaciones"
        Me.BarBtnListadoCotizaciones.Id = 25
        Me.BarBtnListadoCotizaciones.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnListadoCotizaciones.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.lists
        Me.BarBtnListadoCotizaciones.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnListadoCotizaciones.Name = "BarBtnListadoCotizaciones"
        Me.BarBtnListadoCotizaciones.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnColectaDiaria
        '
        Me.BarBtnColectaDiaria.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnColectaDiaria.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnColectaDiaria.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnColectaDiaria.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnColectaDiaria.Caption = "Colecta Diaria"
        Me.BarBtnColectaDiaria.Id = 26
        Me.BarBtnColectaDiaria.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnColectaDiaria.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.calendar
        Me.BarBtnColectaDiaria.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnColectaDiaria.Name = "BarBtnColectaDiaria"
        Me.BarBtnColectaDiaria.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnGraficoVentas
        '
        Me.BarBtnGraficoVentas.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnGraficoVentas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnGraficoVentas.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnGraficoVentas.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnGraficoVentas.Caption = "Gráfico de Ventas"
        Me.BarBtnGraficoVentas.Id = 27
        Me.BarBtnGraficoVentas.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnGraficoVentas.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.chart_bar
        Me.BarBtnGraficoVentas.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnGraficoVentas.Name = "BarBtnGraficoVentas"
        Me.BarBtnGraficoVentas.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnCambiarPass
        '
        Me.BarBtnCambiarPass.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnCambiarPass.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnCambiarPass.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnCambiarPass.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnCambiarPass.Caption = "Cambiar mi contraseña"
        Me.BarBtnCambiarPass.Id = 28
        Me.BarBtnCambiarPass.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnCambiarPass.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.key_go
        Me.BarBtnCambiarPass.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnCambiarPass.Name = "BarBtnCambiarPass"
        Me.BarBtnCambiarPass.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnReiniciar
        '
        Me.BarBtnReiniciar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnReiniciar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnReiniciar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnReiniciar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnReiniciar.Caption = "Eliminar datos"
        Me.BarBtnReiniciar.Id = 29
        Me.BarBtnReiniciar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnReiniciar.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.bomb
        Me.BarBtnReiniciar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnReiniciar.Name = "BarBtnReiniciar"
        Me.BarBtnReiniciar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarBtnRecibos
        '
        Me.BarBtnRecibos.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarBtnRecibos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnRecibos.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarBtnRecibos.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarBtnRecibos.Caption = "Recibos"
        Me.BarBtnRecibos.Id = 30
        Me.BarBtnRecibos.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarBtnRecibos.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.lists
        Me.BarBtnRecibos.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarBtnRecibos.Name = "BarBtnRecibos"
        Me.BarBtnRecibos.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarStaticItem1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Content
        Me.BarStaticItem1.Caption = "Conectado como"
        Me.BarStaticItem1.Id = 31
        Me.BarStaticItem1.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarStaticItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarTxtUser
        '
        Me.BarTxtUser.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarTxtUser.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarTxtUser.Appearance.Options.UseFont = True
        Me.BarTxtUser.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarTxtUser.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarTxtUser.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Content
        Me.BarTxtUser.Id = 32
        Me.BarTxtUser.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarTxtUser.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarTxtUser.Name = "BarTxtUser"
        Me.BarTxtUser.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarTxtUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarTxtFecha
        '
        Me.BarTxtFecha.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarTxtFecha.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarTxtFecha.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarTxtFecha.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Content
        Me.BarTxtFecha.Id = 33
        Me.BarTxtFecha.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarTxtFecha.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarTxtFecha.Name = "BarTxtFecha"
        Me.BarTxtFecha.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarTxtFecha.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup5, Me.RibbonPageGroup6})
        Me.RibbonPage2.ImageAlign = DevExpress.Utils.HorzAlignment.[Default]
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Procesos"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarBtnFacturar)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarBtnOrdenTrabajo)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarBtnCotizacion)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Ventas"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarBtnListadoFacturas)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarBtnListadoOrdenes)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarBtnListadoCotizaciones)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarBtnRecibos)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Listados"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarBtnColectaDiaria)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarBtnGraficoVentas)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Arqueo"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.ImageAlign = DevExpress.Utils.HorzAlignment.[Default]
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Mantenimiento"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarBtnProductos, "P")
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarBtnClientes, "C")
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarBtnEmpleados, "E")
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarBtnTamanios)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Catálogos"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarBtnEmpresa)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Información general"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4, Me.RibbonPageGroup7})
        Me.RibbonPage3.ImageAlign = DevExpress.Utils.HorzAlignment.[Default]
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Seguridad"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarBtnAgregarUsuario)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarBtnListadoUsuario)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarBtnPermisos)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarBtnCambiarPass)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Usuarios y permisos"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarBtnReiniciar)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "Respaldo y reinicio"
        '
        'RepositoryItemTimeEdit1
        '
        Me.RepositoryItemTimeEdit1.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.RepositoryItemTimeEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.RepositoryItemTimeEdit1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemTimeEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemTimeEdit1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemTimeEdit1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemTimeEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemTimeEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemTimeEdit1.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemTimeEdit1.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemTimeEdit1.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.RepositoryItemTimeEdit1.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.RepositoryItemTimeEdit1.AutoHeight = False
        Me.RepositoryItemTimeEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.RepositoryItemTimeEdit1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.RepositoryItemTimeEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.RepositoryItemTimeEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.RepositoryItemTimeEdit1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.RepositoryItemTimeEdit1.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.RepositoryItemTimeEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
        Me.RepositoryItemTimeEdit1.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.RepositoryItemTimeEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarTxtUser)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarTxtFecha)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 424)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(751, 25)
        '
        'ClientPanel
        '
        Me.ClientPanel.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ClientPanel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ClientPanel.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ClientPanel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ClientPanel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ClientPanel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ClientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ClientPanel.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ClientPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientPanel.Location = New System.Drawing.Point(0, 143)
        Me.ClientPanel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ClientPanel.Name = "ClientPanel"
        Me.ClientPanel.Size = New System.Drawing.Size(751, 281)
        Me.ClientPanel.TabIndex = 2
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.AllowDragDrop = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabbedMdiManager1.AppearancePage.PageClient.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabbedMdiManager1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.XtraTabbedMdiManager1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.XtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPagesAndTabControlHeader
        Me.XtraTabbedMdiManager1.FloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.HeaderButtons = DevExpress.XtraTab.TabButtons.[Default]
        Me.XtraTabbedMdiManager1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.[Default]
        Me.XtraTabbedMdiManager1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.XtraTabbedMdiManager1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.[Default]
        Me.XtraTabbedMdiManager1.MdiParent = Me
        Me.XtraTabbedMdiManager1.MultiLine = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Near
        Me.XtraTabbedMdiManager1.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.[Default]
        Me.XtraTabbedMdiManager1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabbedMdiManager1.ShowToolTips = DevExpress.Utils.DefaultBoolean.[Default]
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarButtonItem1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonItem1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.BarButtonItem1.Caption = "Listado de Cotizaciones"
        Me.BarButtonItem1.Id = 25
        Me.BarButtonItem1.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarButtonItem1.LargeGlyph = Global.MosaicosDelSur.My.Resources.Resources.lists
        Me.BarButtonItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'RFrmPrincipal
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 449)
        Me.Controls.Add(Me.ClientPanel)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "RFrmPrincipal"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "RFrmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents ClientPanel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents BarBtnCambiarUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnProductos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnAgregarProducto As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnListadoProductos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenuProductos As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarBtnEmpleados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnAgregarEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnListadoEmpleados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenuEmpleados As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarBtnClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenuClientes As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarBtnAgregarCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnListadoClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BarBtnTamanios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarBtnEmpresa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarBtnFacturar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnOrdenTrabajo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnCotizacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnListadoFacturas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnListadoOrdenes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarBtnAgregarUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnListadoUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnPermisos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnListadoCotizaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarBtnColectaDiaria As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarBtnGraficoVentas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnCambiarPass As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarBtnReiniciar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarBtnRecibos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarTxtUser As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarTxtFecha As DevExpress.XtraBars.BarStaticItem


End Class
