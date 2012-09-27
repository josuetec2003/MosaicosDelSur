<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProductos
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TamanioLabel As System.Windows.Forms.Label
        Dim PrecioUnitarioLabel As System.Windows.Forms.Label
        Dim UnidadesEnStockLabel As System.Windows.Forms.Label
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAgregarMedida = New DevExpress.XtraEditors.SimpleButton()
        Me.btnActualizarStock = New DevExpress.XtraEditors.SimpleButton()
        Me.txtActualizarStock = New DevExpress.XtraEditors.TextEdit()
        Me.btnCerrar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOpenFile = New DevExpress.XtraEditors.SimpleButton()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCatalogos = New MosaicosDelSur.dsCatalogos()
        Me.btnListado = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.TamaniosLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.TamaniosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkDescontinuado = New System.Windows.Forms.CheckBox()
        Me.NombreTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PrecioUnitarioTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnidadesEnStockTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProductosTableAdapter = New MosaicosDelSur.dsCatalogosTableAdapters.ProductosTableAdapter()
        Me.TableAdapterManager = New MosaicosDelSur.dsCatalogosTableAdapters.TableAdapterManager()
        Me.TamaniosTableAdapter = New MosaicosDelSur.dsCatalogosTableAdapters.TamaniosTableAdapter()
        Me.OpenF = New System.Windows.Forms.OpenFileDialog()
        NombreLabel = New System.Windows.Forms.Label()
        TamanioLabel = New System.Windows.Forms.Label()
        PrecioUnitarioLabel = New System.Windows.Forms.Label()
        UnidadesEnStockLabel = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtActualizarStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TamaniosLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TamaniosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrecioUnitarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnidadesEnStockTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Arial", 12.0!)
        NombreLabel.Location = New System.Drawing.Point(103, 48)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(64, 18)
        NombreLabel.TabIndex = 9
        NombreLabel.Text = "Nombre"
        '
        'TamanioLabel
        '
        TamanioLabel.AutoSize = True
        TamanioLabel.Font = New System.Drawing.Font("Arial", 12.0!)
        TamanioLabel.Location = New System.Drawing.Point(104, 89)
        TamanioLabel.Name = "TamanioLabel"
        TamanioLabel.Size = New System.Drawing.Size(63, 18)
        TamanioLabel.TabIndex = 4
        TamanioLabel.Text = "Tamaño"
        '
        'PrecioUnitarioLabel
        '
        PrecioUnitarioLabel.AutoSize = True
        PrecioUnitarioLabel.Font = New System.Drawing.Font("Arial", 12.0!)
        PrecioUnitarioLabel.Location = New System.Drawing.Point(58, 131)
        PrecioUnitarioLabel.Name = "PrecioUnitarioLabel"
        PrecioUnitarioLabel.Size = New System.Drawing.Size(109, 18)
        PrecioUnitarioLabel.TabIndex = 6
        PrecioUnitarioLabel.Text = "Precio unitario"
        '
        'UnidadesEnStockLabel
        '
        UnidadesEnStockLabel.AutoSize = True
        UnidadesEnStockLabel.Font = New System.Drawing.Font("Arial", 12.0!)
        UnidadesEnStockLabel.Location = New System.Drawing.Point(30, 176)
        UnidadesEnStockLabel.Name = "UnidadesEnStockLabel"
        UnidadesEnStockLabel.Size = New System.Drawing.Size(137, 18)
        UnidadesEnStockLabel.TabIndex = 8
        UnidadesEnStockLabel.Text = "Unidades en stock"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(836, 38)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Label1"
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
        Me.PanelControl1.Controls.Add(Me.btnAgregarMedida)
        Me.PanelControl1.Controls.Add(Me.btnActualizarStock)
        Me.PanelControl1.Controls.Add(Me.txtActualizarStock)
        Me.PanelControl1.Controls.Add(Me.btnCerrar)
        Me.PanelControl1.Controls.Add(Me.btnOpenFile)
        Me.PanelControl1.Controls.Add(Me.FotoPictureBox)
        Me.PanelControl1.Controls.Add(Me.btnListado)
        Me.PanelControl1.Controls.Add(Me.btnGuardar)
        Me.PanelControl1.Controls.Add(Me.TamaniosLookUpEdit)
        Me.PanelControl1.Controls.Add(Me.chkDescontinuado)
        Me.PanelControl1.Controls.Add(NombreLabel)
        Me.PanelControl1.Controls.Add(Me.NombreTextEdit)
        Me.PanelControl1.Controls.Add(TamanioLabel)
        Me.PanelControl1.Controls.Add(PrecioUnitarioLabel)
        Me.PanelControl1.Controls.Add(Me.PrecioUnitarioTextEdit)
        Me.PanelControl1.Controls.Add(UnidadesEnStockLabel)
        Me.PanelControl1.Controls.Add(Me.UnidadesEnStockTextEdit)
        Me.PanelControl1.Location = New System.Drawing.Point(25, 74)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(783, 347)
        Me.PanelControl1.TabIndex = 1
        '
        'btnAgregarMedida
        '
        Me.btnAgregarMedida.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnAgregarMedida.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnAgregarMedida.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnAgregarMedida.Appearance.Options.UseFont = True
        Me.btnAgregarMedida.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnAgregarMedida.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnAgregarMedida.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnAgregarMedida.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnAgregarMedida.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnAgregarMedida.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnAgregarMedida.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAgregarMedida.Image = Global.MosaicosDelSur.My.Resources.Resources.addnew
        Me.btnAgregarMedida.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnAgregarMedida.Location = New System.Drawing.Point(389, 86)
        Me.btnAgregarMedida.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnAgregarMedida.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnAgregarMedida.Name = "btnAgregarMedida"
        Me.btnAgregarMedida.Size = New System.Drawing.Size(36, 25)
        Me.btnAgregarMedida.TabIndex = 13
        Me.btnAgregarMedida.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnActualizarStock
        '
        Me.btnActualizarStock.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnActualizarStock.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnActualizarStock.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnActualizarStock.Appearance.Options.UseFont = True
        Me.btnActualizarStock.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnActualizarStock.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnActualizarStock.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnActualizarStock.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnActualizarStock.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnActualizarStock.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnActualizarStock.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnActualizarStock.Image = Global.MosaicosDelSur.My.Resources.Resources.update
        Me.btnActualizarStock.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnActualizarStock.Location = New System.Drawing.Point(359, 173)
        Me.btnActualizarStock.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnActualizarStock.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnActualizarStock.Name = "btnActualizarStock"
        Me.btnActualizarStock.Size = New System.Drawing.Size(36, 26)
        Me.btnActualizarStock.TabIndex = 5
        Me.btnActualizarStock.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtActualizarStock
        '
        Me.txtActualizarStock.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtActualizarStock.EditValue = "0"
        Me.txtActualizarStock.Location = New System.Drawing.Point(306, 173)
        Me.txtActualizarStock.Name = "txtActualizarStock"
        Me.txtActualizarStock.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtActualizarStock.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtActualizarStock.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtActualizarStock.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtActualizarStock.Properties.Appearance.Options.UseFont = True
        Me.txtActualizarStock.Properties.Appearance.Options.UseTextOptions = True
        Me.txtActualizarStock.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtActualizarStock.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtActualizarStock.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtActualizarStock.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtActualizarStock.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtActualizarStock.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtActualizarStock.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtActualizarStock.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtActualizarStock.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtActualizarStock.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtActualizarStock.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtActualizarStock.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtActualizarStock.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtActualizarStock.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtActualizarStock.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtActualizarStock.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtActualizarStock.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtActualizarStock.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtActualizarStock.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtActualizarStock.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtActualizarStock.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtActualizarStock.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtActualizarStock.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtActualizarStock.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtActualizarStock.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtActualizarStock.Properties.DisplayFormat.FormatString = "n0"
        Me.txtActualizarStock.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtActualizarStock.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtActualizarStock.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtActualizarStock.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtActualizarStock.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtActualizarStock.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtActualizarStock.Properties.Mask.BeepOnError = True
        Me.txtActualizarStock.Properties.Mask.EditMask = "n0"
        Me.txtActualizarStock.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtActualizarStock.Size = New System.Drawing.Size(54, 26)
        Me.txtActualizarStock.TabIndex = 4
        Me.txtActualizarStock.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnCerrar
        '
        Me.btnCerrar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnCerrar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnCerrar.Appearance.Options.UseFont = True
        Me.btnCerrar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnCerrar.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnCerrar.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnCerrar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnCerrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnCerrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnCerrar.Location = New System.Drawing.Point(751, 5)
        Me.btnCerrar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnCerrar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(27, 25)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnOpenFile
        '
        Me.btnOpenFile.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnOpenFile.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnOpenFile.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnOpenFile.Appearance.Options.UseFont = True
        Me.btnOpenFile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnOpenFile.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnOpenFile.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnOpenFile.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnOpenFile.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnOpenFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnOpenFile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOpenFile.Image = Global.MosaicosDelSur.My.Resources.Resources.search_flat
        Me.btnOpenFile.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnOpenFile.Location = New System.Drawing.Point(533, 279)
        Me.btnOpenFile.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnOpenFile.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(202, 41)
        Me.btnOpenFile.TabIndex = 7
        Me.btnOpenFile.ToolTip = "Buscar imágen"
        Me.btnOpenFile.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductosBindingSource, "Imagen", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(533, 44)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(202, 236)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPictureBox.TabIndex = 12
        Me.FotoPictureBox.TabStop = False
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
        'btnListado
        '
        Me.btnListado.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnListado.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnListado.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnListado.Appearance.Options.UseFont = True
        Me.btnListado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnListado.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnListado.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnListado.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnListado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnListado.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnListado.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnListado.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnListado.Location = New System.Drawing.Point(194, 280)
        Me.btnListado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnListado.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(115, 41)
        Me.btnListado.TabIndex = 9
        Me.btnListado.Text = "Ver listado"
        Me.btnListado.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnGuardar
        '
        Me.btnGuardar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
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
        Me.btnGuardar.Location = New System.Drawing.Point(23, 280)
        Me.btnGuardar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(165, 41)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'TamaniosLookUpEdit
        '
        Me.TamaniosLookUpEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TamaniosLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductosBindingSource, "IdTamanio", True))
        Me.TamaniosLookUpEdit.Location = New System.Drawing.Point(207, 86)
        Me.TamaniosLookUpEdit.Name = "TamaniosLookUpEdit"
        Me.TamaniosLookUpEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.TamaniosLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.TamaniosLookUpEdit.Properties.Appearance.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TamaniosLookUpEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TamaniosLookUpEdit.Properties.Appearance.Options.UseFont = True
        Me.TamaniosLookUpEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TamaniosLookUpEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TamaniosLookUpEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TamaniosLookUpEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDown.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDown.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDown.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDown.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDown.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDownHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDownHeader.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDownHeader.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDownHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceDropDownHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TamaniosLookUpEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.TamaniosLookUpEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.TamaniosLookUpEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TamaniosLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.None
        Me.TamaniosLookUpEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        SerializableAppearanceObject1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        SerializableAppearanceObject1.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        SerializableAppearanceObject1.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        SerializableAppearanceObject1.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        SerializableAppearanceObject1.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.TamaniosLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.TamaniosLookUpEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TamaniosLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IdTamanio", "Id Tamanio", 100, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tamanio", "Tamaños", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.TamaniosLookUpEdit.Properties.DataSource = Me.TamaniosBindingSource
        Me.TamaniosLookUpEdit.Properties.DisplayMember = "Tamanio"
        Me.TamaniosLookUpEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.TamaniosLookUpEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.TamaniosLookUpEdit.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.Sorting
        Me.TamaniosLookUpEdit.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.[Default]
        Me.TamaniosLookUpEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.TamaniosLookUpEdit.Properties.NullText = "Seleccione tamaño"
        Me.TamaniosLookUpEdit.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.[Default]
        Me.TamaniosLookUpEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter
        Me.TamaniosLookUpEdit.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
        Me.TamaniosLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.TamaniosLookUpEdit.Properties.ValueMember = "IdTamanio"
        Me.TamaniosLookUpEdit.Size = New System.Drawing.Size(183, 25)
        Me.TamaniosLookUpEdit.TabIndex = 1
        Me.TamaniosLookUpEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'TamaniosBindingSource
        '
        Me.TamaniosBindingSource.DataMember = "Tamanios"
        Me.TamaniosBindingSource.DataSource = Me.DsCatalogos
        '
        'chkDescontinuado
        '
        Me.chkDescontinuado.AutoSize = True
        Me.chkDescontinuado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductosBindingSource, "Descontinuado", True))
        Me.chkDescontinuado.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.chkDescontinuado.Location = New System.Drawing.Point(207, 220)
        Me.chkDescontinuado.Name = "chkDescontinuado"
        Me.chkDescontinuado.Size = New System.Drawing.Size(132, 22)
        Me.chkDescontinuado.TabIndex = 6
        Me.chkDescontinuado.Text = "Descontinuado"
        Me.chkDescontinuado.UseVisualStyleBackColor = True
        '
        'NombreTextEdit
        '
        Me.NombreTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductosBindingSource, "Nombre", True))
        Me.NombreTextEdit.Location = New System.Drawing.Point(207, 44)
        Me.NombreTextEdit.Name = "NombreTextEdit"
        Me.NombreTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.NombreTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.NombreTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.NombreTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreTextEdit.Properties.Appearance.Options.UseFont = True
        Me.NombreTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.NombreTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.NombreTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.NombreTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.NombreTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.NombreTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.NombreTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.NombreTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.NombreTextEdit.Properties.MaxLength = 100
        Me.NombreTextEdit.Size = New System.Drawing.Size(316, 26)
        Me.NombreTextEdit.TabIndex = 0
        Me.NombreTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'PrecioUnitarioTextEdit
        '
        Me.PrecioUnitarioTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.PrecioUnitarioTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductosBindingSource, "PrecioUnitario", True))
        Me.PrecioUnitarioTextEdit.Location = New System.Drawing.Point(207, 128)
        Me.PrecioUnitarioTextEdit.Name = "PrecioUnitarioTextEdit"
        Me.PrecioUnitarioTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.PrecioUnitarioTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PrecioUnitarioTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PrecioUnitarioTextEdit.Properties.Appearance.Options.UseFont = True
        Me.PrecioUnitarioTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PrecioUnitarioTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PrecioUnitarioTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PrecioUnitarioTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PrecioUnitarioTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PrecioUnitarioTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PrecioUnitarioTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PrecioUnitarioTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PrecioUnitarioTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PrecioUnitarioTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.PrecioUnitarioTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.PrecioUnitarioTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.PrecioUnitarioTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrecioUnitarioTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PrecioUnitarioTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.PrecioUnitarioTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.PrecioUnitarioTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PrecioUnitarioTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.PrecioUnitarioTextEdit.Properties.Mask.BeepOnError = True
        Me.PrecioUnitarioTextEdit.Properties.Mask.EditMask = "c"
        Me.PrecioUnitarioTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.PrecioUnitarioTextEdit.Size = New System.Drawing.Size(100, 26)
        Me.PrecioUnitarioTextEdit.TabIndex = 2
        Me.PrecioUnitarioTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'UnidadesEnStockTextEdit
        '
        Me.UnidadesEnStockTextEdit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.UnidadesEnStockTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductosBindingSource, "UnidadesEnStock", True))
        Me.UnidadesEnStockTextEdit.Location = New System.Drawing.Point(207, 173)
        Me.UnidadesEnStockTextEdit.Name = "UnidadesEnStockTextEdit"
        Me.UnidadesEnStockTextEdit.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.UnidadesEnStockTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.UnidadesEnStockTextEdit.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.UnidadesEnStockTextEdit.Properties.Appearance.Options.UseFont = True
        Me.UnidadesEnStockTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.UnidadesEnStockTextEdit.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.UnidadesEnStockTextEdit.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.UnidadesEnStockTextEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.UnidadesEnStockTextEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.UnidadesEnStockTextEdit.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.UnidadesEnStockTextEdit.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.UnidadesEnStockTextEdit.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.UnidadesEnStockTextEdit.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.UnidadesEnStockTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.UnidadesEnStockTextEdit.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UnidadesEnStockTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.UnidadesEnStockTextEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.UnidadesEnStockTextEdit.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.UnidadesEnStockTextEdit.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.UnidadesEnStockTextEdit.Properties.Mask.BeepOnError = True
        Me.UnidadesEnStockTextEdit.Properties.Mask.EditMask = "n0"
        Me.UnidadesEnStockTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.UnidadesEnStockTextEdit.Properties.ReadOnly = True
        Me.UnidadesEnStockTextEdit.Size = New System.Drawing.Size(100, 26)
        Me.UnidadesEnStockTextEdit.TabIndex = 3
        Me.UnidadesEnStockTextEdit.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DatosGeneralesTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosNombreCompletoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EstadoOrdenTrabajoTableAdapter = Nothing
        Me.TableAdapterManager.LocacionesTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.TamaniosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MosaicosDelSur.dsCatalogosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TamaniosTableAdapter
        '
        Me.TamaniosTableAdapter.ClearBeforeFill = True
        '
        'OpenF
        '
        Me.OpenF.FileName = "OpenFileDialog1"
        '
        'frmAddProductos
        '
        Me.AcceptButton = Me.btnGuardar
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(836, 463)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.lblTitulo)
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.Name = "frmAddProductos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtActualizarStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TamaniosLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TamaniosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombreTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrecioUnitarioTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnidadesEnStockTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DsCatalogos As MosaicosDelSur.dsCatalogos
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As MosaicosDelSur.dsCatalogosTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As MosaicosDelSur.dsCatalogosTableAdapters.TableAdapterManager
    Friend WithEvents NombreTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PrecioUnitarioTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnidadesEnStockTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkDescontinuado As System.Windows.Forms.CheckBox
    Friend WithEvents TamaniosLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TamaniosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TamaniosTableAdapter As MosaicosDelSur.dsCatalogosTableAdapters.TamaniosTableAdapter
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnListado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOpenFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents OpenF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtActualizarStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnActualizarStock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAgregarMedida As DevExpress.XtraEditors.SimpleButton
End Class
