﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenesTrabajo
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
        Dim Label14 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim IdOrdenLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnBuscarEntregador = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIdEntregador = New DevExpress.XtraEditors.TextEdit()
        Me.OrdenesTrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProcesos = New MosaicosDelSur.dsProcesos()
        Me.txtNombreEntregador = New DevExpress.XtraEditors.TextEdit()
        Me.txtPendiente = New DevExpress.XtraEditors.TextEdit()
        Me.LimiteRetiroDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ProbableEntregaDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.txtAdelanto = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
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
        Me.txtOrdenTrabajo = New DevExpress.XtraEditors.TextEdit()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New MosaicosDelSur.dsCatalogosTableAdapters.ClientesTableAdapter()
        Me.ProductosTableAdapter = New MosaicosDelSur.dsCatalogosTableAdapters.ProductosTableAdapter()
        Me.OrdenesTrabajoTableAdapter = New MosaicosDelSur.dsProcesosTableAdapters.OrdenesTrabajoTableAdapter()
        Me.TamaniosTableAdapter = New MosaicosDelSur.dsCatalogosTableAdapters.TamaniosTableAdapter()
        Label14 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        IdOrdenLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtIdEntregador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProcesos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreEntregador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPendiente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LimiteRetiroDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProbableEntregaDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdelanto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtOrdenTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Label14.Location = New System.Drawing.Point(455, 448)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(63, 14)
        Label14.TabIndex = 26
        Label14.Text = "Adelanto"
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
        'IdOrdenLabel
        '
        IdOrdenLabel.AutoSize = True
        IdOrdenLabel.Location = New System.Drawing.Point(510, 11)
        IdOrdenLabel.Name = "IdOrdenLabel"
        IdOrdenLabel.Size = New System.Drawing.Size(95, 13)
        IdOrdenLabel.TabIndex = 3
        IdOrdenLabel.Text = "Orden trabajo No."
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
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label13.Location = New System.Drawing.Point(19, 378)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(137, 14)
        Label13.TabIndex = 18
        Label13.Text = "Fecha probable entrega"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label15.Location = New System.Drawing.Point(30, 402)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(122, 14)
        Label15.TabIndex = 29
        Label15.Text = "Fecha limite de retiro"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label16.Location = New System.Drawing.Point(424, 473)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(94, 14)
        Label16.TabIndex = 31
        Label16.Text = "Pago pendiente"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Label17.Location = New System.Drawing.Point(64, 427)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(86, 14)
        Label17.TabIndex = 33
        Label17.Text = "Entregado por"
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
        Me.lblTitulo.TabIndex = 21
        Me.lblTitulo.Text = "Orden de trabajo"
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
        Me.PanelControl1.Controls.Add(Me.btnBuscarEntregador)
        Me.PanelControl1.Controls.Add(Me.txtIdEntregador)
        Me.PanelControl1.Controls.Add(Me.txtNombreEntregador)
        Me.PanelControl1.Controls.Add(Label17)
        Me.PanelControl1.Controls.Add(Me.txtPendiente)
        Me.PanelControl1.Controls.Add(Label16)
        Me.PanelControl1.Controls.Add(Label15)
        Me.PanelControl1.Controls.Add(Me.LimiteRetiroDateEdit)
        Me.PanelControl1.Controls.Add(Label13)
        Me.PanelControl1.Controls.Add(Me.ProbableEntregaDateEdit)
        Me.PanelControl1.Controls.Add(Me.txtAdelanto)
        Me.PanelControl1.Controls.Add(Label14)
        Me.PanelControl1.Controls.Add(Me.txtTotalDescuento)
        Me.PanelControl1.Controls.Add(Label11)
        Me.PanelControl1.Controls.Add(Me.btnBuscar)
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
        Me.PanelControl1.Controls.Add(IdOrdenLabel)
        Me.PanelControl1.Controls.Add(Me.txtOrdenTrabajo)
        Me.PanelControl1.Controls.Add(Me.lblFecha)
        Me.PanelControl1.Location = New System.Drawing.Point(40, 42)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(725, 499)
        Me.PanelControl1.TabIndex = 22
        '
        'btnBuscarEntregador
        '
        Me.btnBuscarEntregador.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnBuscarEntregador.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.btnBuscarEntregador.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnBuscarEntregador.Appearance.Options.UseFont = True
        Me.btnBuscarEntregador.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnBuscarEntregador.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnBuscarEntregador.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnBuscarEntregador.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnBuscarEntregador.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnBuscarEntregador.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBuscarEntregador.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBuscarEntregador.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnBuscarEntregador.Location = New System.Drawing.Point(210, 426)
        Me.btnBuscarEntregador.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnBuscarEntregador.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuscarEntregador.Name = "btnBuscarEntregador"
        Me.btnBuscarEntregador.Size = New System.Drawing.Size(26, 21)
        Me.btnBuscarEntregador.TabIndex = 35
        Me.btnBuscarEntregador.Text = "..."
        Me.btnBuscarEntregador.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtIdEntregador
        '
        Me.txtIdEntregador.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtIdEntregador.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrdenesTrabajoBindingSource, "Transportara", True))
        Me.txtIdEntregador.Location = New System.Drawing.Point(162, 426)
        Me.txtIdEntregador.Name = "txtIdEntregador"
        Me.txtIdEntregador.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtIdEntregador.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtIdEntregador.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEntregador.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtIdEntregador.Properties.Appearance.Options.UseFont = True
        Me.txtIdEntregador.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtIdEntregador.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtIdEntregador.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtIdEntregador.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtIdEntregador.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtIdEntregador.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtIdEntregador.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtIdEntregador.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtIdEntregador.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtIdEntregador.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtIdEntregador.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtIdEntregador.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtIdEntregador.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtIdEntregador.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtIdEntregador.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtIdEntregador.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtIdEntregador.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtIdEntregador.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtIdEntregador.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtIdEntregador.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtIdEntregador.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtIdEntregador.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtIdEntregador.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtIdEntregador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtIdEntregador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdEntregador.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtIdEntregador.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtIdEntregador.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtIdEntregador.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtIdEntregador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtIdEntregador.Properties.ReadOnly = True
        Me.txtIdEntregador.Size = New System.Drawing.Size(49, 21)
        Me.txtIdEntregador.TabIndex = 36
        Me.txtIdEntregador.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'OrdenesTrabajoBindingSource
        '
        Me.OrdenesTrabajoBindingSource.DataMember = "OrdenesTrabajo"
        Me.OrdenesTrabajoBindingSource.DataSource = Me.DsProcesos
        '
        'DsProcesos
        '
        Me.DsProcesos.DataSetName = "dsProcesos"
        Me.DsProcesos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNombreEntregador
        '
        Me.txtNombreEntregador.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtNombreEntregador.Location = New System.Drawing.Point(235, 426)
        Me.txtNombreEntregador.Name = "txtNombreEntregador"
        Me.txtNombreEntregador.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtNombreEntregador.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtNombreEntregador.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEntregador.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreEntregador.Properties.Appearance.Options.UseFont = True
        Me.txtNombreEntregador.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreEntregador.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreEntregador.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreEntregador.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreEntregador.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreEntregador.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreEntregador.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreEntregador.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreEntregador.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreEntregador.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreEntregador.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreEntregador.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreEntregador.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreEntregador.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreEntregador.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreEntregador.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreEntregador.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreEntregador.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtNombreEntregador.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtNombreEntregador.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtNombreEntregador.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtNombreEntregador.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtNombreEntregador.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtNombreEntregador.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtNombreEntregador.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNombreEntregador.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtNombreEntregador.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtNombreEntregador.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtNombreEntregador.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtNombreEntregador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtNombreEntregador.Size = New System.Drawing.Size(178, 21)
        Me.txtNombreEntregador.TabIndex = 34
        Me.txtNombreEntregador.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtPendiente
        '
        Me.txtPendiente.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPendiente.Location = New System.Drawing.Point(524, 470)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtPendiente.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtPendiente.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPendiente.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPendiente.Properties.Appearance.Options.UseFont = True
        Me.txtPendiente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPendiente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPendiente.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPendiente.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPendiente.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPendiente.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPendiente.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPendiente.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPendiente.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPendiente.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPendiente.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPendiente.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPendiente.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPendiente.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPendiente.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPendiente.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPendiente.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPendiente.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPendiente.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtPendiente.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtPendiente.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtPendiente.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtPendiente.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtPendiente.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtPendiente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtPendiente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPendiente.Properties.DisplayFormat.FormatString = "C"
        Me.txtPendiente.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPendiente.Properties.EditFormat.FormatString = "C"
        Me.txtPendiente.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPendiente.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPendiente.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtPendiente.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtPendiente.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtPendiente.Properties.Mask.EditMask = "c"
        Me.txtPendiente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPendiente.Properties.ReadOnly = True
        Me.txtPendiente.Size = New System.Drawing.Size(128, 21)
        Me.txtPendiente.TabIndex = 32
        Me.txtPendiente.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'LimiteRetiroDateEdit
        '
        Me.LimiteRetiroDateEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.LimiteRetiroDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrdenesTrabajoBindingSource, "FechaLimiteRetiro", True))
        Me.LimiteRetiroDateEdit.EditValue = Nothing
        Me.LimiteRetiroDateEdit.Location = New System.Drawing.Point(162, 400)
        Me.LimiteRetiroDateEdit.Name = "LimiteRetiroDateEdit"
        Me.LimiteRetiroDateEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.LimiteRetiroDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.LimiteRetiroDateEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeaderHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceWeekNumber.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceWeekNumber.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceWeekNumber.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceWeekNumber.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.AppearanceWeekNumber.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.LimiteRetiroDateEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.LimiteRetiroDateEdit.Properties.DisplayFormat.FormatString = "D"
        Me.LimiteRetiroDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.LimiteRetiroDateEdit.Properties.EditFormat.FormatString = "D"
        Me.LimiteRetiroDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.LimiteRetiroDateEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.LimiteRetiroDateEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.LimiteRetiroDateEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.LimiteRetiroDateEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.LimiteRetiroDateEdit.Properties.Mask.EditMask = "D"
        Me.LimiteRetiroDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.LimiteRetiroDateEdit.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.LimiteRetiroDateEdit.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.LimiteRetiroDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LimiteRetiroDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject2.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject2.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject2.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject2.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.LimiteRetiroDateEdit.Properties.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.[Default]
        Me.LimiteRetiroDateEdit.Size = New System.Drawing.Size(251, 20)
        Me.LimiteRetiroDateEdit.TabIndex = 30
        Me.LimiteRetiroDateEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ProbableEntregaDateEdit
        '
        Me.ProbableEntregaDateEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ProbableEntregaDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrdenesTrabajoBindingSource, "FechaProbableEntrega", True))
        Me.ProbableEntregaDateEdit.EditValue = Nothing
        Me.ProbableEntregaDateEdit.Location = New System.Drawing.Point(162, 375)
        Me.ProbableEntregaDateEdit.Name = "ProbableEntregaDateEdit"
        Me.ProbableEntregaDateEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ProbableEntregaDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ProbableEntregaDateEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeaderHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHeaderHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceDropDownHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceWeekNumber.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceWeekNumber.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceWeekNumber.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceWeekNumber.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.AppearanceWeekNumber.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject3.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject3.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject3.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject3.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.ProbableEntregaDateEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ProbableEntregaDateEdit.Properties.DisplayFormat.FormatString = "D"
        Me.ProbableEntregaDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ProbableEntregaDateEdit.Properties.EditFormat.FormatString = "D"
        Me.ProbableEntregaDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ProbableEntregaDateEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ProbableEntregaDateEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ProbableEntregaDateEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ProbableEntregaDateEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.ProbableEntregaDateEdit.Properties.Mask.EditMask = "D"
        Me.ProbableEntregaDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.ProbableEntregaDateEdit.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.ProbableEntregaDateEdit.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.ProbableEntregaDateEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProbableEntregaDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject4.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject4.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject4.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject4.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Vertical
        Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.ProbableEntregaDateEdit.Properties.WeekNumberRule = DevExpress.XtraEditors.Controls.WeekNumberRule.[Default]
        Me.ProbableEntregaDateEdit.Size = New System.Drawing.Size(251, 20)
        Me.ProbableEntregaDateEdit.TabIndex = 28
        Me.ProbableEntregaDateEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtAdelanto
        '
        Me.txtAdelanto.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtAdelanto.Location = New System.Drawing.Point(524, 445)
        Me.txtAdelanto.Name = "txtAdelanto"
        Me.txtAdelanto.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtAdelanto.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtAdelanto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtAdelanto.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdelanto.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtAdelanto.Properties.Appearance.Options.UseBackColor = True
        Me.txtAdelanto.Properties.Appearance.Options.UseFont = True
        Me.txtAdelanto.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAdelanto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAdelanto.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtAdelanto.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtAdelanto.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtAdelanto.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtAdelanto.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtAdelanto.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtAdelanto.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtAdelanto.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtAdelanto.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtAdelanto.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtAdelanto.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtAdelanto.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtAdelanto.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtAdelanto.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtAdelanto.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtAdelanto.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtAdelanto.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtAdelanto.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtAdelanto.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtAdelanto.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtAdelanto.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtAdelanto.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtAdelanto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtAdelanto.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAdelanto.Properties.DisplayFormat.FormatString = "C"
        Me.txtAdelanto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdelanto.Properties.EditFormat.FormatString = "C"
        Me.txtAdelanto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAdelanto.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtAdelanto.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtAdelanto.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtAdelanto.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtAdelanto.Properties.Mask.EditMask = "c"
        Me.txtAdelanto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAdelanto.Size = New System.Drawing.Size(128, 21)
        Me.txtAdelanto.TabIndex = 27
        Me.txtAdelanto.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
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
        'btnBuscar
        '
        Me.btnBuscar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.btnBuscar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnBuscar.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnBuscar.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnBuscar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnBuscar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnBuscar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnBuscar.Location = New System.Drawing.Point(220, 460)
        Me.btnBuscar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnBuscar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 31)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "Buscar orden"
        Me.btnBuscar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
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
        Me.btnGuardar.Location = New System.Drawing.Point(109, 460)
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(105, 31)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Procesar orden"
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
        Me.btnNuevo.Location = New System.Drawing.Point(22, 460)
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
        SerializableAppearanceObject5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject5.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject5.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject5.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject5.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtTamano.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
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
        Me.IdClienteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.OrdenesTrabajoBindingSource, "IdCliente", True))
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
        'txtOrdenTrabajo
        '
        Me.txtOrdenTrabajo.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtOrdenTrabajo.Location = New System.Drawing.Point(611, 8)
        Me.txtOrdenTrabajo.Name = "txtOrdenTrabajo"
        Me.txtOrdenTrabajo.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtOrdenTrabajo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtOrdenTrabajo.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtOrdenTrabajo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtOrdenTrabajo.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtOrdenTrabajo.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtOrdenTrabajo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtOrdenTrabajo.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtOrdenTrabajo.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtOrdenTrabajo.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtOrdenTrabajo.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtOrdenTrabajo.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtOrdenTrabajo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtOrdenTrabajo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtOrdenTrabajo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtOrdenTrabajo.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtOrdenTrabajo.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtOrdenTrabajo.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtOrdenTrabajo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtOrdenTrabajo.Properties.ReadOnly = True
        Me.txtOrdenTrabajo.Size = New System.Drawing.Size(94, 20)
        Me.txtOrdenTrabajo.TabIndex = 4
        Me.txtOrdenTrabajo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
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
        'OrdenesTrabajoTableAdapter
        '
        Me.OrdenesTrabajoTableAdapter.ClearBeforeFill = True
        '
        'TamaniosTableAdapter
        '
        Me.TamaniosTableAdapter.ClearBeforeFill = True
        '
        'frmOrdenesTrabajo
        '
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 552)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.lblTitulo)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "frmOrdenesTrabajo"
        Me.Text = "Orden de trabajo"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtIdEntregador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProcesos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreEntregador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPendiente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LimiteRetiroDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LimiteRetiroDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProbableEntregaDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProbableEntregaDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdelanto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtOrdenTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtAdelanto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents txtOrdenTrabajo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LimiteRetiroDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ProbableEntregaDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtPendiente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DsCatalogos As MosaicosDelSur.dsCatalogos
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As MosaicosDelSur.dsCatalogosTableAdapters.ClientesTableAdapter
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As MosaicosDelSur.dsCatalogosTableAdapters.ProductosTableAdapter
    Friend WithEvents DsProcesos As MosaicosDelSur.dsProcesos
    Friend WithEvents OrdenesTrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdenesTrabajoTableAdapter As MosaicosDelSur.dsProcesosTableAdapters.OrdenesTrabajoTableAdapter
    Friend WithEvents txtNombreEntregador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscarEntregador As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIdEntregador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TamaniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TamaniosTableAdapter As MosaicosDelSur.dsCatalogosTableAdapters.TamaniosTableAdapter
End Class
