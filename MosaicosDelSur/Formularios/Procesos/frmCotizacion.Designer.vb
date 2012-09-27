<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizacion
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim lblCotizacin As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTotalDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTotalPagar = New DevExpress.XtraEditors.TextEdit()
        Me.txtSubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.btnEliminarDeFactura = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAgregarAFactura = New DevExpress.XtraEditors.SimpleButton()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCantida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrecioUnitario = New DevExpress.XtraEditors.TextEdit()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New MosaicosDelSur.dsCatalogos()
        Me.txtNombreProducto = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscarProducto = New DevExpress.XtraEditors.SimpleButton()
        Me.IdProductoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.txtTamano = New DevExpress.XtraEditors.LookUpEdit()
        Me.TamaniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCorreo = New DevExpress.XtraEditors.TextEdit()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreCliente = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscarCliente = New DevExpress.XtraEditors.SimpleButton()
        Me.IdClienteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CotizacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProcesos = New MosaicosDelSur.dsProcesos()
        Me.txtCotizacion = New DevExpress.XtraEditors.TextEdit()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New MosaicosDelSur.dsCatalogosTableAdapters.ClientesTableAdapter()
        Me.ProductosTableAdapter = New MosaicosDelSur.dsCatalogosTableAdapters.ProductosTableAdapter()
        Me.TamaniosTableAdapter = New MosaicosDelSur.dsCatalogosTableAdapters.TamaniosTableAdapter()
        Me.CotizacionesTableAdapter = New MosaicosDelSur.dsProcesosTableAdapters.CotizacionesTableAdapter()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        lblCotizacin = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTotalDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioUnitario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdProductoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTamano.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TamaniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtCorreo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCotizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label11.Location = New System.Drawing.Point(421, 400)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(97, 14)
        Label11.TabIndex = 24
        Label11.Text = "Total descuento"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label12.Location = New System.Drawing.Point(439, 423)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(79, 14)
        Label12.TabIndex = 19
        Label12.Text = "Total a pagar"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label10.Location = New System.Drawing.Point(465, 375)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(53, 14)
        Label10.TabIndex = 15
        Label10.Text = "Subtotal"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label1.Location = New System.Drawing.Point(367, 54)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(92, 14)
        Label1.TabIndex = 17
        Label1.Text = "Descuento (%)"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label9.Location = New System.Drawing.Point(545, 31)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(51, 14)
        Label9.TabIndex = 15
        Label9.Text = "Tamaño"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label8.Location = New System.Drawing.Point(217, 54)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(54, 14)
        Label8.TabIndex = 13
        Label8.Text = "Cantidad"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label7.Location = New System.Drawing.Point(23, 54)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(84, 14)
        Label7.TabIndex = 11
        Label7.Text = "Precio unitario"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label6.Location = New System.Drawing.Point(221, 29)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(50, 14)
        Label6.TabIndex = 9
        Label6.Text = "Nombre"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label5.Location = New System.Drawing.Point(9, 29)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(98, 14)
        Label5.TabIndex = 6
        Label5.Text = "Código Producto"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label4.Location = New System.Drawing.Point(416, 53)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(43, 14)
        Label4.TabIndex = 10
        Label4.Text = "Correo"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label3.Location = New System.Drawing.Point(403, 28)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(56, 14)
        Label3.TabIndex = 8
        Label3.Text = "Teléfono"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label2.Location = New System.Drawing.Point(43, 53)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(50, 14)
        Label2.TabIndex = 6
        Label2.Text = "Nombre"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        IdClienteLabel.Location = New System.Drawing.Point(9, 28)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(84, 14)
        IdClienteLabel.TabIndex = 3
        IdClienteLabel.Text = "Código cliente"
        '
        'lblCotizacin
        '
        lblCotizacin.AutoSize = True
        lblCotizacin.Location = New System.Drawing.Point(532, 11)
        lblCotizacin.Name = "lblCotizacin"
        lblCotizacin.Size = New System.Drawing.Size(76, 13)
        lblCotizacin.TabIndex = 3
        lblCotizacin.Text = "Cotización No."
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(804, 38)
        Me.lblTitulo.TabIndex = 22
        Me.lblTitulo.Text = "Cotización"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PanelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PanelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PanelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PanelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PanelControl1.Controls.Add(Me.txtTotalDescuento)
        Me.PanelControl1.Controls.Add(Label11)
        Me.PanelControl1.Controls.Add(Me.btnGuardar)
        Me.PanelControl1.Controls.Add(Me.btnNuevo)
        Me.PanelControl1.Controls.Add(Me.txtTotalPagar)
        Me.PanelControl1.Controls.Add(Label12)
        Me.PanelControl1.Controls.Add(Me.txtSubTotal)
        Me.PanelControl1.Controls.Add(Label10)
        Me.PanelControl1.Controls.Add(Me.btnEliminarDeFactura)
        Me.PanelControl1.Controls.Add(Me.btnAgregarAFactura)
        Me.PanelControl1.Controls.Add(Me.dgvDetalle)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(lblCotizacin)
        Me.PanelControl1.Controls.Add(Me.txtCotizacion)
        Me.PanelControl1.Controls.Add(Me.lblFecha)
        Me.PanelControl1.Location = New System.Drawing.Point(40, 59)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(725, 452)
        Me.PanelControl1.TabIndex = 23
        '
        'txtTotalDescuento
        '
        Me.txtTotalDescuento.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtTotalDescuento.Location = New System.Drawing.Point(524, 396)
        Me.txtTotalDescuento.Name = "txtTotalDescuento"
        Me.txtTotalDescuento.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtTotalDescuento.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtTotalDescuento.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDescuento.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTotalDescuento.Properties.Appearance.Options.UseFont = True
        Me.txtTotalDescuento.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalDescuento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalDescuento.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTotalDescuento.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTotalDescuento.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTotalDescuento.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTotalDescuento.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTotalDescuento.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTotalDescuento.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTotalDescuento.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTotalDescuento.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTotalDescuento.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTotalDescuento.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTotalDescuento.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTotalDescuento.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTotalDescuento.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTotalDescuento.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTotalDescuento.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTotalDescuento.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTotalDescuento.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTotalDescuento.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTotalDescuento.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTotalDescuento.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTotalDescuento.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTotalDescuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtTotalDescuento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalDescuento.Properties.DisplayFormat.FormatString = "C"
        Me.txtTotalDescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDescuento.Properties.EditFormat.FormatString = "C"
        Me.txtTotalDescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalDescuento.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtTotalDescuento.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtTotalDescuento.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtTotalDescuento.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtTotalDescuento.Properties.Mask.EditMask = "c"
        Me.txtTotalDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalDescuento.Properties.ReadOnly = True
        Me.txtTotalDescuento.Size = New System.Drawing.Size(128, 21)
        Me.txtTotalDescuento.TabIndex = 25
        Me.txtTotalDescuento.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnGuardar
        '
        Me.btnGuardar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.btnGuardar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnGuardar.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnGuardar.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnGuardar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnGuardar.Location = New System.Drawing.Point(108, 410)
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 31)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Imprimir cotización"
        Me.btnGuardar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnNuevo
        '
        Me.btnNuevo.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.btnNuevo.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnNuevo.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnNuevo.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnNuevo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnNuevo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnNuevo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNuevo.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnNuevo.Location = New System.Drawing.Point(21, 410)
        Me.btnNuevo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnNuevo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(81, 31)
        Me.btnNuevo.TabIndex = 21
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtTotalPagar.Location = New System.Drawing.Point(524, 420)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtTotalPagar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtTotalPagar.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPagar.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTotalPagar.Properties.Appearance.Options.UseFont = True
        Me.txtTotalPagar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalPagar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalPagar.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTotalPagar.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTotalPagar.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTotalPagar.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTotalPagar.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTotalPagar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTotalPagar.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTotalPagar.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTotalPagar.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTotalPagar.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTotalPagar.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTotalPagar.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTotalPagar.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTotalPagar.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTotalPagar.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTotalPagar.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTotalPagar.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTotalPagar.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTotalPagar.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTotalPagar.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTotalPagar.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTotalPagar.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTotalPagar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtTotalPagar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotalPagar.Properties.DisplayFormat.FormatString = "C"
        Me.txtTotalPagar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalPagar.Properties.EditFormat.FormatString = "C"
        Me.txtTotalPagar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalPagar.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtTotalPagar.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtTotalPagar.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtTotalPagar.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtTotalPagar.Properties.Mask.EditMask = "c"
        Me.txtTotalPagar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalPagar.Properties.ReadOnly = True
        Me.txtTotalPagar.Size = New System.Drawing.Size(128, 21)
        Me.txtTotalPagar.TabIndex = 20
        Me.txtTotalPagar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtSubTotal.Location = New System.Drawing.Point(524, 371)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtSubTotal.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtSubTotal.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtSubTotal.Properties.Appearance.Options.UseFont = True
        Me.txtSubTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSubTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtSubTotal.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtSubTotal.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtSubTotal.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtSubTotal.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtSubTotal.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtSubTotal.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtSubTotal.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtSubTotal.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtSubTotal.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtSubTotal.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtSubTotal.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtSubTotal.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtSubTotal.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtSubTotal.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtSubTotal.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtSubTotal.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtSubTotal.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtSubTotal.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtSubTotal.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtSubTotal.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtSubTotal.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtSubTotal.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtSubTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtSubTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSubTotal.Properties.DisplayFormat.FormatString = "C"
        Me.txtSubTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubTotal.Properties.EditFormat.FormatString = "C"
        Me.txtSubTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSubTotal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtSubTotal.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtSubTotal.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtSubTotal.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtSubTotal.Properties.Mask.EditMask = "c"
        Me.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSubTotal.Properties.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(128, 21)
        Me.txtSubTotal.TabIndex = 16
        Me.txtSubTotal.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnEliminarDeFactura
        '
        Me.btnEliminarDeFactura.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnEliminarDeFactura.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.btnEliminarDeFactura.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnEliminarDeFactura.Appearance.Options.UseFont = True
        Me.btnEliminarDeFactura.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnEliminarDeFactura.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnEliminarDeFactura.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnEliminarDeFactura.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnEliminarDeFactura.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnEliminarDeFactura.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnEliminarDeFactura.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEliminarDeFactura.Image = Global.MosaicosDelSur.My.Resources.Resources.cancelnew
        Me.btnEliminarDeFactura.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnEliminarDeFactura.Location = New System.Drawing.Point(658, 235)
        Me.btnEliminarDeFactura.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnEliminarDeFactura.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnEliminarDeFactura.Name = "btnEliminarDeFactura"
        Me.btnEliminarDeFactura.Size = New System.Drawing.Size(47, 31)
        Me.btnEliminarDeFactura.TabIndex = 1
        Me.btnEliminarDeFactura.ToolTip = "Eliminar producto de la factura"
        Me.btnEliminarDeFactura.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnAgregarAFactura
        '
        Me.btnAgregarAFactura.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnAgregarAFactura.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.btnAgregarAFactura.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnAgregarAFactura.Appearance.Options.UseFont = True
        Me.btnAgregarAFactura.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnAgregarAFactura.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnAgregarAFactura.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnAgregarAFactura.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnAgregarAFactura.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnAgregarAFactura.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAgregarAFactura.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAgregarAFactura.Image = Global.MosaicosDelSur.My.Resources.Resources.add
        Me.btnAgregarAFactura.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarAFactura.Location = New System.Drawing.Point(658, 198)
        Me.btnAgregarAFactura.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnAgregarAFactura.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAgregarAFactura.Name = "btnAgregarAFactura"
        Me.btnAgregarAFactura.Size = New System.Drawing.Size(47, 31)
        Me.btnAgregarAFactura.TabIndex = 0
        Me.btnAgregarAFactura.ToolTip = "Agregar producto a la factura"
        Me.btnAgregarAFactura.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'dgvDetalle
        '
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCodigo, Me.ColProducto, Me.ColPrecio, Me.ColCantida, Me.ColDescto, Me.ColTotal})
        Me.dgvDetalle.Location = New System.Drawing.Point(21, 198)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(631, 170)
        Me.dgvDetalle.TabIndex = 7
        '
        'ColCodigo
        '
        Me.ColCodigo.HeaderText = "Código"
        Me.ColCodigo.Name = "ColCodigo"
        Me.ColCodigo.ReadOnly = True
        Me.ColCodigo.Width = 60
        '
        'ColProducto
        '
        Me.ColProducto.HeaderText = "Producto"
        Me.ColProducto.Name = "ColProducto"
        Me.ColProducto.ReadOnly = True
        Me.ColProducto.Width = 215
        '
        'ColPrecio
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ColPrecio.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColPrecio.HeaderText = "Precio/U"
        Me.ColPrecio.Name = "ColPrecio"
        Me.ColPrecio.ReadOnly = True
        Me.ColPrecio.Width = 80
        '
        'ColCantida
        '
        Me.ColCantida.HeaderText = "Cantidad"
        Me.ColCantida.Name = "ColCantida"
        Me.ColCantida.ReadOnly = True
        Me.ColCantida.Width = 65
        '
        'ColDescto
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ColDescto.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColDescto.HeaderText = "Descto (%)"
        Me.ColDescto.Name = "ColDescto"
        Me.ColDescto.ReadOnly = True
        Me.ColDescto.Width = 85
        '
        'ColTotal
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ColTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColTotal.HeaderText = "Total"
        Me.ColTotal.Name = "ColTotal"
        Me.ColTotal.ReadOnly = True
        Me.ColTotal.Width = 80
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl2.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.[Default]
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.[Default]
        Me.GroupControl2.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.GroupControl2.Controls.Add(Me.txtDescuento)
        Me.GroupControl2.Controls.Add(Label1)
        Me.GroupControl2.Controls.Add(Label9)
        Me.GroupControl2.Controls.Add(Me.txtCantidad)
        Me.GroupControl2.Controls.Add(Label8)
        Me.GroupControl2.Controls.Add(Me.txtPrecioUnitario)
        Me.GroupControl2.Controls.Add(Label7)
        Me.GroupControl2.Controls.Add(Me.txtNombreProducto)
        Me.GroupControl2.Controls.Add(Label6)
        Me.GroupControl2.Controls.Add(Me.btnBuscarProducto)
        Me.GroupControl2.Controls.Add(Me.IdProductoTextEdit)
        Me.GroupControl2.Controls.Add(Label5)
        Me.GroupControl2.Controls.Add(Me.txtTamano)
        Me.GroupControl2.Location = New System.Drawing.Point(21, 115)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(684, 77)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Datos del producto"
        '
        'txtDescuento
        '
        Me.txtDescuento.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtDescuento.EditValue = "0"
        Me.txtDescuento.Location = New System.Drawing.Point(468, 51)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtDescuento.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtDescuento.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtDescuento.Properties.Appearance.Options.UseFont = True
        Me.txtDescuento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtDescuento.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtDescuento.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtDescuento.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtDescuento.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtDescuento.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtDescuento.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtDescuento.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtDescuento.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtDescuento.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtDescuento.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtDescuento.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtDescuento.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtDescuento.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtDescuento.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtDescuento.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtDescuento.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtDescuento.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtDescuento.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtDescuento.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtDescuento.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtDescuento.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtDescuento.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtDescuento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtDescuento.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescuento.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtDescuento.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtDescuento.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtDescuento.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtDescuento.Properties.Mask.EditMask = "n0"
        Me.txtDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuento.Size = New System.Drawing.Size(56, 21)
        Me.txtDescuento.TabIndex = 4
        Me.txtDescuento.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtCantidad
        '
        Me.txtCantidad.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtCantidad.Location = New System.Drawing.Point(277, 50)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtCantidad.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCantidad.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCantidad.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCantidad.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCantidad.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCantidad.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCantidad.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCantidad.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCantidad.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCantidad.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCantidad.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCantidad.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCantidad.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCantidad.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCantidad.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCantidad.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCantidad.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCantidad.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCantidad.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCantidad.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCantidad.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCantidad.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCantidad.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCantidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtCantidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCantidad.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtCantidad.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtCantidad.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtCantidad.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtCantidad.Properties.Mask.EditMask = "n0"
        Me.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Size = New System.Drawing.Size(56, 21)
        Me.txtCantidad.TabIndex = 3
        Me.txtCantidad.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrecioUnitario.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductosBindingSource, "PrecioUnitario", True))
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(113, 51)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtPrecioUnitario.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPrecioUnitario.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioUnitario.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrecioUnitario.Properties.Appearance.Options.UseFont = True
        Me.txtPrecioUnitario.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrecioUnitario.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrecioUnitario.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrecioUnitario.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrecioUnitario.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrecioUnitario.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrecioUnitario.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPrecioUnitario.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPrecioUnitario.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPrecioUnitario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtPrecioUnitario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPrecioUnitario.Properties.DisplayFormat.FormatString = "C"
        Me.txtPrecioUnitario.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioUnitario.Properties.EditFormat.FormatString = "C"
        Me.txtPrecioUnitario.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrecioUnitario.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPrecioUnitario.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtPrecioUnitario.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtPrecioUnitario.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtPrecioUnitario.Properties.Mask.EditMask = "C"
        Me.txtPrecioUnitario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(81, 21)
        Me.txtPrecioUnitario.TabIndex = 2
        Me.txtPrecioUnitario.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DsCatalogos
        '
        'DsCatalogos
        '
        Me.DsCatalogos.DataSetName = "dsCatalogos"
        Me.DsCatalogos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtNombreProducto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductosBindingSource, "Nombre", True))
        Me.txtNombreProducto.Location = New System.Drawing.Point(277, 26)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtNombreProducto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtNombreProducto.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreProducto.Properties.Appearance.Options.UseFont = True
        Me.txtNombreProducto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreProducto.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreProducto.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreProducto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreProducto.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreProducto.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreProducto.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreProducto.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreProducto.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreProducto.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreProducto.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreProducto.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreProducto.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreProducto.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreProducto.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreProducto.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreProducto.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreProducto.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreProducto.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreProducto.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreProducto.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreProducto.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreProducto.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreProducto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtNombreProducto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreProducto.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtNombreProducto.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtNombreProducto.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtNombreProducto.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtNombreProducto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtNombreProducto.Size = New System.Drawing.Size(247, 21)
        Me.txtNombreProducto.TabIndex = 1
        Me.txtNombreProducto.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnBuscarProducto.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnBuscarProducto.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnBuscarProducto.Appearance.Options.UseFont = True
        Me.btnBuscarProducto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnBuscarProducto.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnBuscarProducto.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnBuscarProducto.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnBuscarProducto.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnBuscarProducto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBuscarProducto.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBuscarProducto.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnBuscarProducto.Location = New System.Drawing.Point(168, 26)
        Me.btnBuscarProducto.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnBuscarProducto.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(26, 21)
        Me.btnBuscarProducto.TabIndex = 0
        Me.btnBuscarProducto.Text = "..."
        Me.btnBuscarProducto.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'IdProductoTextEdit
        '
        Me.IdProductoTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.IdProductoTextEdit.Location = New System.Drawing.Point(113, 26)
        Me.IdProductoTextEdit.Name = "IdProductoTextEdit"
        Me.IdProductoTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.IdProductoTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.IdProductoTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProductoTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdProductoTextEdit.Properties.Appearance.Options.UseFont = True
        Me.IdProductoTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdProductoTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdProductoTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdProductoTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdProductoTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdProductoTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdProductoTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdProductoTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdProductoTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdProductoTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IdProductoTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.IdProductoTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.IdProductoTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.IdProductoTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.IdProductoTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.IdProductoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.IdProductoTextEdit.Properties.ReadOnly = True
        Me.IdProductoTextEdit.Size = New System.Drawing.Size(56, 21)
        Me.IdProductoTextEdit.TabIndex = 7
        Me.IdProductoTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtTamano
        '
        Me.txtTamano.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtTamano.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductosBindingSource, "IdTamanio", True))
        Me.txtTamano.Location = New System.Drawing.Point(602, 27)
        Me.txtTamano.Name = "txtTamano"
        Me.txtTamano.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtTamano.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtTamano.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTamano.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTamano.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTamano.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTamano.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTamano.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTamano.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTamano.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTamano.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTamano.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTamano.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTamano.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTamano.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTamano.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTamano.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTamano.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTamano.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTamano.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTamano.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTamano.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTamano.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTamano.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTamano.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTamano.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTamano.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTamano.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTamano.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTamano.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTamano.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTamano.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTamano.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTamano.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTamano.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTamano.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTamano.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTamano.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTamano.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.None
        Me.txtTamano.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTamano.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtTamano.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTamano.Properties.DataSource = Me.TamaniosBindingSource
        Me.txtTamano.Properties.DisplayMember = "Tamanio"
        Me.txtTamano.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtTamano.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtTamano.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.Sorting
        Me.txtTamano.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.txtTamano.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtTamano.Properties.NullText = ""
        Me.txtTamano.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.txtTamano.Properties.ReadOnly = True
        Me.txtTamano.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter
        Me.txtTamano.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.txtTamano.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtTamano.Properties.ValueMember = "IdTamanio"
        Me.txtTamano.Size = New System.Drawing.Size(66, 20)
        Me.txtTamano.TabIndex = 16
        Me.txtTamano.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'TamaniosBindingSource
        '
        Me.TamaniosBindingSource.DataMember = "Tamanios"
        Me.TamaniosBindingSource.DataSource = Me.DsCatalogos
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.[Default]
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.[Default]
        Me.GroupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.GroupControl1.Controls.Add(Me.txtCorreo)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Me.txtTelefono)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Me.txtNombreCliente)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupControl1.Controls.Add(Me.IdClienteTextEdit)
        Me.GroupControl1.Controls.Add(IdClienteLabel)
        Me.GroupControl1.Location = New System.Drawing.Point(21, 37)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(684, 75)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Datos del cliente"
        '
        'txtCorreo
        '
        Me.txtCorreo.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtCorreo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource, "Correo", True))
        Me.txtCorreo.Location = New System.Drawing.Point(470, 49)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtCorreo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtCorreo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCorreo.Properties.Appearance.Options.UseFont = True
        Me.txtCorreo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCorreo.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCorreo.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCorreo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCorreo.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCorreo.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCorreo.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCorreo.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCorreo.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCorreo.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCorreo.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCorreo.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCorreo.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCorreo.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCorreo.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCorreo.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCorreo.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCorreo.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCorreo.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCorreo.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCorreo.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCorreo.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCorreo.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCorreo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtCorreo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCorreo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtCorreo.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtCorreo.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtCorreo.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtCorreo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtCorreo.Size = New System.Drawing.Size(199, 21)
        Me.txtCorreo.TabIndex = 3
        Me.txtCorreo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DsCatalogos
        '
        'txtTelefono
        '
        Me.txtTelefono.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource, "Telefono", True))
        Me.txtTelefono.Location = New System.Drawing.Point(470, 25)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtTelefono.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtTelefono.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTelefono.Properties.Appearance.Options.UseFont = True
        Me.txtTelefono.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTelefono.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTelefono.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTelefono.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTelefono.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTelefono.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTelefono.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTelefono.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTelefono.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTelefono.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTelefono.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTelefono.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTelefono.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTelefono.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTelefono.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTelefono.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTelefono.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTelefono.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtTelefono.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtTelefono.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtTelefono.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtTelefono.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtTelefono.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTelefono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtTelefono.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTelefono.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtTelefono.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtTelefono.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtTelefono.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtTelefono.Size = New System.Drawing.Size(107, 21)
        Me.txtTelefono.TabIndex = 2
        Me.txtTelefono.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtNombreCliente.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ClientesBindingSource, "NombreORazonSocial", True))
        Me.txtNombreCliente.Location = New System.Drawing.Point(111, 49)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtNombreCliente.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtNombreCliente.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreCliente.Properties.Appearance.Options.UseFont = True
        Me.txtNombreCliente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreCliente.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreCliente.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreCliente.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreCliente.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreCliente.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreCliente.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreCliente.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreCliente.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreCliente.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreCliente.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreCliente.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreCliente.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreCliente.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreCliente.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreCliente.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreCliente.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreCliente.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreCliente.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreCliente.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreCliente.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreCliente.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreCliente.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreCliente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtNombreCliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreCliente.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtNombreCliente.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtNombreCliente.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtNombreCliente.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtNombreCliente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtNombreCliente.Size = New System.Drawing.Size(281, 21)
        Me.txtNombreCliente.TabIndex = 1
        Me.txtNombreCliente.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnBuscarCliente.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnBuscarCliente.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnBuscarCliente.Appearance.Options.UseFont = True
        Me.btnBuscarCliente.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnBuscarCliente.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnBuscarCliente.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnBuscarCliente.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnBuscarCliente.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnBuscarCliente.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBuscarCliente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBuscarCliente.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnBuscarCliente.Location = New System.Drawing.Point(166, 25)
        Me.btnBuscarCliente.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnBuscarCliente.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(26, 21)
        Me.btnBuscarCliente.TabIndex = 0
        Me.btnBuscarCliente.Text = "..."
        Me.btnBuscarCliente.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'IdClienteTextEdit
        '
        Me.IdClienteTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.IdClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CotizacionesBindingSource, "IdCliente", True))
        Me.IdClienteTextEdit.Location = New System.Drawing.Point(111, 25)
        Me.IdClienteTextEdit.Name = "IdClienteTextEdit"
        Me.IdClienteTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.IdClienteTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.IdClienteTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdClienteTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdClienteTextEdit.Properties.Appearance.Options.UseFont = True
        Me.IdClienteTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdClienteTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdClienteTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdClienteTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdClienteTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdClienteTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdClienteTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.IdClienteTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.IdClienteTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.IdClienteTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.IdClienteTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.IdClienteTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.IdClienteTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.IdClienteTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.IdClienteTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.IdClienteTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.IdClienteTextEdit.Properties.ReadOnly = True
        Me.IdClienteTextEdit.Size = New System.Drawing.Size(56, 21)
        Me.IdClienteTextEdit.TabIndex = 4
        Me.IdClienteTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'CotizacionesBindingSource
        '
        Me.CotizacionesBindingSource.DataMember = "Cotizaciones"
        Me.CotizacionesBindingSource.DataSource = Me.DsProcesos
        '
        'DsProcesos
        '
        Me.DsProcesos.DataSetName = "dsProcesos"
        Me.DsProcesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCotizacion
        '
        Me.txtCotizacion.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtCotizacion.Location = New System.Drawing.Point(611, 8)
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtCotizacion.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtCotizacion.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCotizacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCotizacion.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCotizacion.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCotizacion.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCotizacion.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCotizacion.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCotizacion.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCotizacion.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCotizacion.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCotizacion.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCotizacion.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCotizacion.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCotizacion.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCotizacion.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCotizacion.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCotizacion.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCotizacion.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCotizacion.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtCotizacion.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtCotizacion.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtCotizacion.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtCotizacion.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtCotizacion.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtCotizacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtCotizacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCotizacion.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtCotizacion.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtCotizacion.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtCotizacion.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtCotizacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtCotizacion.Properties.ReadOnly = True
        Me.txtCotizacion.Size = New System.Drawing.Size(94, 20)
        Me.txtCotizacion.TabIndex = 4
        Me.txtCotizacion.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFecha.Location = New System.Drawing.Point(19, 11)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TamaniosTableAdapter
        '
        Me.TamaniosTableAdapter.ClearBeforeFill = True
        '
        'CotizacionesTableAdapter
        '
        Me.CotizacionesTableAdapter.ClearBeforeFill = True
        '
        'frmCotizacion
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 535)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.lblTitulo)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "frmCotizacion"
        Me.Text = "frmCotizacion"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTotalDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioUnitario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdProductoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTamano.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TamaniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtCorreo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdClienteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotizacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCotizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTotalDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTotalPagar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnEliminarDeFactura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarAFactura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents ColCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCantida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDescto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrecioUnitario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscarProducto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IdProductoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTamano As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCorreo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscarCliente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IdClienteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCotizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents DsCatalogos As MosaicosDelSur.dsCatalogos
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As MosaicosDelSur.dsCatalogosTableAdapters.ClientesTableAdapter
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As MosaicosDelSur.dsCatalogosTableAdapters.ProductosTableAdapter
    Friend WithEvents TamaniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TamaniosTableAdapter As MosaicosDelSur.dsCatalogosTableAdapters.TamaniosTableAdapter
    Friend WithEvents DsProcesos As MosaicosDelSur.dsProcesos
    Friend WithEvents CotizacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CotizacionesTableAdapter As MosaicosDelSur.dsProcesosTableAdapters.CotizacionesTableAdapter
End Class
