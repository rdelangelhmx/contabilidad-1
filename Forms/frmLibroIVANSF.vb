Public Class frmLibroIVANSF
   Inherits System.Windows.Forms.Form

   Private moFactura As clsFactura
   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngSucursalId As Long
   Private mstrSucursalDes As String
   Private mlngTipoFacturaId As Long
   Private mboolOrdenarFecha As Boolean
   Private mlngMesIdIni As Long

   Private moListaTipoAsiento As New Queue
   Private mstrTipoAsientoId As String

   Private mlngCantidad As Long
   Private mdecImporte As Decimal
   Private mdecIceIehd As Decimal
   Private mdecExento As Decimal
   Private mdecNeto As Decimal
   Private mdecIVA As Decimal

   Private moDataSet As DataSet
   Private moDataTable As DataTable

#Region " Set and Get "
   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property GestionId() As Long
      Get
         Return mlngGestionId
      End Get

      Set(ByVal Value As Long)
         mlngGestionId = Value
      End Set
   End Property

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
      End Set
   End Property

   Property SucursalDes() As String
      Get
         Return mstrSucursalDes
      End Get

      Set(ByVal Value As String)
         mstrSucursalDes = Value
      End Set
   End Property

   Property TipoFacturaId() As Long
      Get
         Return mlngTipoFacturaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoFacturaId = Value
      End Set
   End Property

   Property OrdenarFecha() As Boolean
      Get
         Return mboolOrdenarFecha
      End Get

      Set(ByVal Value As Boolean)
         mboolOrdenarFecha = Value
      End Set
   End Property

   Property ListaTipoAsiento() As Queue
      Get
         Return moListaTipoAsiento
      End Get

      Set(ByVal Value As Queue)
         moListaTipoAsiento = Value
      End Set
   End Property

   Property Lista() As Queue
      Get
         Return moLista
      End Get

      Set(ByVal Value As Queue)
         moLista = Value
      End Set
   End Property
#End Region

#Region " C�digo generado por el Dise�ador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Dise�ador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

   End Sub

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Dise�ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Dise�ador de Windows Forms. 
   'No lo modifique con el editor de c�digo.
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents Export As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Export1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents PrintIN As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents PrintIN1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtCantidad As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIceIehd As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtExento As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNeto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroIVANSF))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtCantidad = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIceIehd = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtExento = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtNeto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Export1 = New Janus.Windows.UI.CommandBars.UICommand("Export")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.PrintIN1 = New Janus.Windows.UI.CommandBars.UICommand("PrintIN")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Export = New Janus.Windows.UI.CommandBars.UICommand("Export")
      Me.PrintIN = New Janus.Windows.UI.CommandBars.UICommand("PrintIN")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdMain)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 309)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdMain
      '
      Me.grdMain.AllowCardSizing = False
      Me.grdMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdMain.AlternatingColors = True
      Me.grdMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdMain.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdMain.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdMain.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdMain.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdMain.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdMain.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdMain.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdMain.GroupByBoxVisible = False
      Me.grdMain.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdMain.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdMain.Location = New System.Drawing.Point(0, 0)
      Me.grdMain.Name = "grdMain"
      Me.grdMain.RecordNavigator = True
      Me.grdMain.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdMain.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdMain.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdMain.Size = New System.Drawing.Size(728, 309)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Controls.Add(Me.grpMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 9
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 310
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 342)
      Me.ebrMain.TabIndex = 6
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtCantidad)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtImporte)
      Me.grpMain.Controls.Add(Me.txtIceIehd)
      Me.grpMain.Controls.Add(Me.txtExento)
      Me.grpMain.Controls.Add(Me.txtNeto)
      Me.grpMain.Controls.Add(Me.txtIVA)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.Label8)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 350)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(736, 56)
      Me.grpMain.TabIndex = 5
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtCantidad
      '
      Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCantidad.BackColor = System.Drawing.SystemColors.Info
      Me.txtCantidad.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCantidad.FormatString = "##########0"
      Me.txtCantidad.Location = New System.Drawing.Point(204, 28)
      Me.txtCantidad.Name = "txtCantidad"
      Me.txtCantidad.ReadOnly = True
      Me.txtCantidad.Size = New System.Drawing.Size(84, 20)
      Me.txtCantidad.TabIndex = 3
      Me.txtCantidad.Text = "0"
      Me.txtCantidad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCantidad.Value = New Decimal(New Integer() {0, 0, 0, 0})
      Me.txtCantidad.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label1.Location = New System.Drawing.Point(204, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(84, 16)
      Me.Label1.TabIndex = 142
      Me.Label1.Text = "Cant. Facturas"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtImporte
      '
      Me.txtImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtImporte.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporte.FormatString = "##,##0.000"
      Me.txtImporte.Location = New System.Drawing.Point(292, 28)
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.ReadOnly = True
      Me.txtImporte.Size = New System.Drawing.Size(84, 20)
      Me.txtImporte.TabIndex = 5
      Me.txtImporte.Text = "0,000"
      Me.txtImporte.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporte.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporte.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIceIehd
      '
      Me.txtIceIehd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtIceIehd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIceIehd.FormatString = "##,##0.000"
      Me.txtIceIehd.Location = New System.Drawing.Point(380, 28)
      Me.txtIceIehd.Name = "txtIceIehd"
      Me.txtIceIehd.ReadOnly = True
      Me.txtIceIehd.Size = New System.Drawing.Size(84, 20)
      Me.txtIceIehd.TabIndex = 6
      Me.txtIceIehd.Text = "0,000"
      Me.txtIceIehd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIceIehd.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIceIehd.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtExento
      '
      Me.txtExento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtExento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtExento.FormatString = "##,##0.000"
      Me.txtExento.Location = New System.Drawing.Point(468, 28)
      Me.txtExento.Name = "txtExento"
      Me.txtExento.ReadOnly = True
      Me.txtExento.Size = New System.Drawing.Size(84, 20)
      Me.txtExento.TabIndex = 7
      Me.txtExento.Text = "0,000"
      Me.txtExento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtExento.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtExento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNeto
      '
      Me.txtNeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtNeto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNeto.FormatString = "##,##0.000"
      Me.txtNeto.Location = New System.Drawing.Point(556, 28)
      Me.txtNeto.Name = "txtNeto"
      Me.txtNeto.ReadOnly = True
      Me.txtNeto.Size = New System.Drawing.Size(84, 20)
      Me.txtNeto.TabIndex = 8
      Me.txtNeto.Text = "0,000"
      Me.txtNeto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtNeto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtNeto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIVA
      '
      Me.txtIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIVA.FormatString = "##,##0.000"
      Me.txtIVA.Location = New System.Drawing.Point(644, 28)
      Me.txtIVA.Name = "txtIVA"
      Me.txtIVA.ReadOnly = True
      Me.txtIVA.Size = New System.Drawing.Size(84, 20)
      Me.txtIVA.TabIndex = 9
      Me.txtIVA.Text = "0,000"
      Me.txtIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label6.Location = New System.Drawing.Point(292, 12)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(84, 16)
      Me.Label6.TabIndex = 140
      Me.Label6.Text = "Importe"
      Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label7
      '
      Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label7.Location = New System.Drawing.Point(380, 12)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(84, 16)
      Me.Label7.TabIndex = 139
      Me.Label7.Text = "ICE/IEHD"
      Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label8
      '
      Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label8.Location = New System.Drawing.Point(468, 12)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(84, 16)
      Me.Label8.TabIndex = 138
      Me.Label8.Text = "Exento"
      Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label9
      '
      Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label9.Location = New System.Drawing.Point(556, 12)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(84, 16)
      Me.Label9.TabIndex = 137
      Me.Label9.Text = "Neto"
      Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label10
      '
      Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label10.Location = New System.Drawing.Point(644, 12)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(84, 16)
      Me.Label10.TabIndex = 136
      Me.Label10.Text = "IVA"
      Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      Me.ilsMain.Images.SetKeyName(2, "")
      Me.ilsMain.Images.SetKeyName(3, "")
      Me.ilsMain.Images.SetKeyName(4, "")
      Me.ilsMain.Images.SetKeyName(5, "")
      Me.ilsMain.Images.SetKeyName(6, "")
      Me.ilsMain.Images.SetKeyName(7, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2, Me.Export, Me.PrintIN})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("718f24d3-fdb8-4b13-ae9e-72bb63cbee32")
      Me.cdmMain.ImageList = Me.ilsMain
      Me.cdmMain.LeftRebar = Me.LeftRebar1
      Me.cdmMain.RightRebar = Me.RightRebar1
      Me.cdmMain.TopRebar = Me.TopRebar1
      Me.cdmMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'BottomRebar1
      '
      Me.BottomRebar1.CommandManager = Me.cdmMain
      Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
      Me.BottomRebar1.Name = "BottomRebar1"
      Me.BottomRebar1.Size = New System.Drawing.Size(0, 0)
      '
      'UiCommandBar1
      '
      Me.UiCommandBar1.CommandManager = Me.cdmMain
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.Export1, Me.Separator4, Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator5, Me.PrintIN1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(579, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.ImageIndex = 1
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Documento"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Export1
      '
      Me.Export1.Key = "Export"
      Me.Export1.Name = "Export1"
      Me.Export1.ToolTipText = "Exportar a Documento TXT"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'ViewAll1
      '
      Me.ViewAll1.Key = "ViewAll"
      Me.ViewAll1.Name = "ViewAll1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      Me.Print1.Text = "Impresi�n Estandar"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'PrintIN1
      '
      Me.PrintIN1.Key = "PrintIN"
      Me.PrintIN1.Name = "PrintIN1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Book
      '
      Me.Book.ImageIndex = 6
      Me.Book.Key = "Book"
      Me.Book.Name = "Book"
      Me.Book.Text = "Libro Mayor"
      '
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 3
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
      '
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Export
      '
      Me.Export.ImageIndex = 7
      Me.Export.Key = "Export"
      Me.Export.Name = "Export"
      Me.Export.Text = "Exportar"
      '
      'PrintIN
      '
      Me.PrintIN.ImageIndex = 4
      Me.PrintIN.Key = "PrintIN"
      Me.PrintIN.Name = "PrintIN"
      Me.PrintIN.Text = "Impresi�n NSF"
      Me.PrintIN.ToolTipText = "Impresi�n Nuevo Sistema de Facturaci�n"
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 0)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 0)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(752, 28)
      '
      'frmLibroIVANSF
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmLibroIVANSF"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Libros IVA"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Book"
            If ToLong(grdMain.GetValue("TipoFacturaId")) = 1 Then 'Ventas
               Call CompEdit()

            ElseIf ToLong(grdMain.GetValue("TipoFacturaId")) = 2 Then 'Compras
               Call CompEdit()

            ElseIf ToLong(grdMain.GetValue("TipoFacturaId")) = 3 Then 'Polizas
               Call PolizaEdit()
            End If

         Case "ViewAll"
            Call DataViewAll()

         Case "Export"
            Call ExportText()

         Case "Print"
            Call PrintReport()
            Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.IMPRESION_INFORME, e.Command.Text & ": " & Me.Text)

         Case "PrintIN"
            Call PrintReportIN()
            Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.IMPRESION_INFORME, e.Command.Text & ": " & Me.Text)

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmLibroIVA_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmLibroIVA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      If mlngTipoFacturaId = 1 Then
         Me.Text = "Libro de Ventas IVA"

      ElseIf mlngTipoFacturaId = 2 Then
         Me.Text = "Libro de Compras IVA"
      End If

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moFactura = New clsFactura(clsAppInfo.ConnectString)
   End Sub

   Private Sub CompEdit()
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("CompId")) > 0 Then
         Dim oComp As New clsComp(clsAppInfo.ConnectString)
         Dim lngFacturaId As Long
         Try
            With oComp
               .CompId = ToLong(grdMain.GetValue("CompId"))
               lngFacturaId = ToLong(grdMain.GetValue("FacturaId"))

               If .FindByPK Then
                  Dim frm As New frmCompEdit

                  If oComp.EstadoId = clsEstado.ANULADO Or oComp.EstadoId = clsEstado.CERRADO Then
                     frm.NewRecord = False
                     frm.Editing = False
                  Else
                     frm.NewRecord = False
                     frm.Editing = True
                  End If

                  frm.DataObject = oComp
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdMainLoad()
                     Call grdMainFindRow(lngFacturaId)
                  End If

                  frm.Dispose()
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Finally
            oComp.Dispose()
         End Try
      Else
         MessageBox.Show("Seleccione un Comprobante", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub PolizaEdit()
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("FacturaId")) > 0 Then
         Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)
         Dim lngPolizaId As Long
         Try
            With oPoliza
               .PolizaId = ToLong(grdMain.GetValue("FacturaId"))
               lngPolizaId = ToLong(grdMain.GetValue("FacturaId"))

               If .FindByPK Then
                  Dim frm As New frmPolizaEdit

                  frm.NewRecord = False
                  frm.Editing = True
                  frm.DataObject = oPoliza
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdMainLoad()
                     Call grdMainFindRow(lngPolizaId)
                  End If

                  frm.Dispose()
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Finally
            oPoliza.Dispose()
         End Try
      Else
         MessageBox.Show("Registro Inv�lido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub frmLibroIVA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If ToLong(grdMain.GetValue("TipoFacturaId")) = 1 Then 'Ventas
               Call CompEdit()

            ElseIf ToLong(grdMain.GetValue("TipoFacturaId")) = 2 Then 'Compras
               Call CompEdit()

            ElseIf ToLong(grdMain.GetValue("TipoFacturaId")) = 3 Then 'Polizas
               Call PolizaEdit()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmLibroIVA_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moFactura.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub ExportText()
      Dim frm As New frmLibroIVAExport
      Dim strFilename As String
      Dim strLine As String
      Dim strPeriodo As String
      Dim strEmpresaNIT As String
      Dim sfd As New SaveFileDialog
      Dim oRow As DataRow

      Try
         If moDataSet.Tables(moFactura.TableName).Rows.Count > 1 Then
            If IsDate(moDataSet.Tables(moFactura.TableName).Rows(0).Item("FacturaFecha")) Then
               frm.Fecha = moDataSet.Tables(moFactura.TableName).Rows(0).Item("FacturaFecha")
            Else
               frm.Fecha = Now.Date
            End If
         Else
            frm.Fecha = Now.Date
         End If

         frm.ShowDialog()

         If frm.Selected Then
            strPeriodo = Replace(frm.Periodo, "/", "")
            strEmpresaNIT = frm.EmpresaNIT

            sfd.DefaultExt = "txt"
            sfd.Filter = "Text Files (*.txt)|*.txt"
            sfd.FilterIndex = 2
            sfd.RestoreDirectory = True

            If mlngTipoFacturaId = 1 Then 'Ventas
               sfd.FileName = "ventas_" & strPeriodo & "_" & strEmpresaNIT & ".txt"

            ElseIf mlngTipoFacturaId = 2 Then 'Compras
               sfd.FileName = "compras_" & strPeriodo & "_" & strEmpresaNIT & ".txt"
            End If

            If sfd.ShowDialog() = DialogResult.OK Then
               strFilename = sfd.FileName
               Dim file As New System.IO.StreamWriter(strFilename)

               If mlngTipoFacturaId = 1 Then 'Ventas
                  For Each oRow In moDataTable.DataSet.Tables(moFactura.TableName).Rows
                     If ToLong(oRow("FacturaId")) <> 0 Then
                        strLine = ToStr(oRow("NroRUC")) & "|" & ToStr(oRow("RegRUCDes")) & "|" & _
                        ToStr(oRow("FacturaNro")) & "|" & ToStr(oRow("NroAutorizacion")) & "|" & _
                        ToDateDMY(oRow("FacturaFecha")) & "|" & _
                        Replace(Format(oRow("FacturaMonto"), "###0.00"), ",", ".") & "|" & _
                        Replace(Format(oRow("IceIehd"), "###0.00"), ",", ".") & "|" & _
                        Replace(Format(oRow("Exento"), "###0.00"), ",", ".") & "|" & _
                        Replace(Format(oRow("Neto"), "###0.00"), ",", ".") & "|" & _
                        Replace(Format(oRow("IVA"), "###0.00"), ",", ".") & "|"

                        If ToDecimal(oRow("FacturaMonto")) > 0 Then 'Validas
                           strLine &= "V"

                        ElseIf UCase(ToStr(oRow("RegRUCDes"))) = "ANULADA" Then
                           strLine &= "A"

                        ElseIf UCase(ToStr(oRow("RegRUCDes"))) = "EXTRAVIADA" Then
                           strLine &= "E"

                        ElseIf UCase(ToStr(oRow("RegRUCDes"))) = "NO UTILIZADA" Then
                           strLine &= "N"

                        Else
                           strLine &= "A"
                        End If

                        If ToStr(oRow("CodControl")) = "" Then
                           strLine &= "|" & "0"
                        Else
                           strLine &= "|" & ToStr(oRow("CodControl"))
                        End If

                        file.WriteLine(strLine)
                     End If
                  Next

               ElseIf mlngTipoFacturaId = 2 Then 'Compras
                  For Each oRow In moDataTable.DataSet.Tables(moFactura.TableName).Rows
                     If ToLong(oRow("FacturaId")) <> 0 Then
                        strLine = ToStr(oRow("TipoFacturaId")) & "|" & ToStr(oRow("NroRUC")) & "|" & _
                        ToStr(oRow("RegRUCDes")) & "|"

                        If ToLong(oRow("TipoFacturaId")) = 1 Then
                           strLine &= ToStr(oRow("FacturaNro")) & "|" & "0" & "|" & ToStr(oRow("NroAutorizacion")) & "|"

                        ElseIf ToLong(oRow("TipoFacturaId")) = 3 Then
                           strLine &= "0" & "|" & ToStr(oRow("FacturaNro")) & "|" & "3" & "|"
                        End If

                        strLine &= ToDateDMY(oRow("FacturaFecha")) & "|" & Replace(Format(oRow("FacturaMonto"), "###0.00"), ",", ".") _
                        & "|" & Replace(Format(oRow("IceIehd"), "###0.00"), ",", ".") & "|" & Replace(Format(oRow("Exento"), "###0.00"), ",", ".") _
                        & "|" & Replace(Format(oRow("Neto"), "###0.00"), ",", ".") & "|" & Replace(Format(oRow("IVA"), "###0.00"), ",", ".")

                        If ToStr(oRow("CodControl")) = "" Then
                           strLine &= "|" & "0"
                        Else
                           strLine &= "|" & ToStr(oRow("CodControl"))
                        End If

                        file.WriteLine(strLine)
                     End If
                  Next
               End If

               file.Close()
               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.EXPORTAR, frm.Text & " Periodo " & frm.Periodo)
               MessageBox.Show("Se Exporto Exitosamente el Documento de Texto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If

         frm.Dispose()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub PrintReport()
      Dim rpt As New rptLibroIVA

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moFactura.TableName))

      If mlngTipoFacturaId = 1 Then 'Ventas
         rpt.lblTitle.Text = "Libro de Ventas IVA"
         rpt.Document.Name = "Libro de Ventas IVA"
         rpt.lblIVA.Text = "D�bito"

      ElseIf mlngTipoFacturaId = 2 Then 'Compras
         rpt.lblTitle.Text = "Libro de Compras IVA"
         rpt.Document.Name = "Libro de Compras IVA"
         rpt.lblIVA.Text = "Cr�dito"
      End If

      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      If moDataSet.Tables(moFactura.TableName).Rows.Count > 1 Then
         If IsDate(moDataSet.Tables(moFactura.TableName).Rows(0).Item("FacturaFecha")) Then
            rpt.txtGestion.Text = Format(moDataSet.Tables(moFactura.TableName).Rows(0).Item("FacturaFecha"), "yyyy")
         Else
            rpt.txtGestion.Text = Format(Now.Date, "yyyy")
         End If
      Else
         rpt.txtGestion.Text = Format(Now.Date, "yyyy")
      End If

      rpt.txtSucursalDes.Text = mstrSucursalDes

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document)
      frm.Show()
   End Sub

   Private Sub PrintReportIN()
      Dim rpt As New rptLibroIVANSF
      Dim strDireccion As String = ""
      Dim frmRes As New frmLibroIVARes

      frmRes.ShowDialog()

      rpt.txtResponsableCI.Text = frmRes.ResponsableCI
      rpt.txtResponsableDes.Text = frmRes.ResponsableDes

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moFactura.TableName))

      If mlngTipoFacturaId = 1 Then 'Venta
         rpt.lblTitle.Text = "LIBRO DE VENTAS IVA DEL PERIODO"
         rpt.Document.Name = "LIBRO DE VENTAS"
         rpt.lblIVA.Text = "D�BITO FISCAL I.V.A."
         rpt.lblNroRUC.Text = "N� DE NIT / CI DEL CLIENTE"
         rpt.lblRegRUCDes.Text = "NOMBRE O RAZ�N SOCIAL DEL CLIENTE"

      ElseIf mlngTipoFacturaId = 2 Then 'Compra
         rpt.lblTitle.Text = "LIBRO DE COMPRAS IVA DEL PERIODO"
         rpt.Document.Name = "LIBRO DE COMPRAS"
         rpt.lblIVA.Text = "CR�DITO FISCAL I.V.A."
         rpt.lblNroRUC.Text = "N� DE NIT DEL PROVEEDOR"
         rpt.lblRegRUCDes.Text = "NOMBRE O RAZ�N SOCIAL DEL PROVEEDOR"
      End If

      If moDataSet.Tables(moFactura.TableName).Rows.Count > 0 Then
         If IsDate(moDataSet.Tables(moFactura.TableName).Rows(0).Item("FacturaFecha")) Then
            rpt.lblGestion.Text = Format(moDataSet.Tables(moFactura.TableName).Rows(0).Item("FacturaFecha"), "yyyy")
            rpt.lblMes.Text = ToLong(Format(moDataSet.Tables(moFactura.TableName).Rows(0).Item("FacturaFecha"), "MM"))
         Else
            rpt.lblGestion.Text = ToStr(clsAppInfo.Gestion) 'Format(Now.Date, "yyyy")
         End If
      Else
         rpt.lblGestion.Text = ToStr(clsAppInfo.Gestion) 'Format(Now.Date, "yyyy")
         rpt.lblMes.Text = ToStr(mlngMesIdIni)
      End If

      rpt.txtEmpresaDes.Text = clsAppInfo.EmpresaDes
      rpt.txtEmpresaRUC.Text = EmpresaRUCFind(clsAppInfo.EmpresaId, strDireccion)

      If mlngSucursalId = 0 Then
         rpt.txtSucursalCod.Text = "0"
         rpt.txtDireccion.Text = strDireccion

      Else
         rpt.txtSucursalCod.Text = SucursalCodFind(mlngSucursalId, strDireccion)
         rpt.txtDireccion.Text = strDireccion
      End If

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      With rpt.PageSettings
         .Margins.Left = 0.3
         .Margins.Right = 0.3
         .Margins.Top = 0.8
         .Margins.Bottom = 0.3
      End With

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document)
      frm.Show()

      frmRes.Dispose()
   End Sub

   Private Function GetDataView(ByVal oDataTableOrg As DataTable) As System.Data.DataView
      If grdMain.RootTable.FilterApplied Is Nothing Then
         Return oDataTableOrg.DefaultView

      Else
         Dim oDataTable As DataTable
         Dim oRow As DataRow

         oDataTable = oDataTableOrg.Clone

         For Each oRowMain In grdMain.GetRows()
            oRow = oDataTable.NewRow

            For i = 0 To oRowMain.Cells.Count - 1
               oRow(i) = oRowMain.Cells(i).Value
            Next

            oDataTable.Rows.Add(oRow)
         Next

         Return oDataTable.DefaultView
      End If
   End Function

   Public Function EmpresaRUCFind(ByVal lngEmpresaId As Long, ByRef strDireccion As String) As String
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      Try
         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               strDireccion = .Direccion
               EmpresaRUCFind = .EmpresaRUC
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Function

   Public Function SucursalCodFind(ByVal lngSucursalId As Long, ByRef strDireccion As String) As String
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)

      Try
         With oSucursal
            .SucursalId = lngSucursalId

            If .FindByPK Then
               strDireccion = .Direccion
               SucursalCodFind = .SucursalCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()

      End Try
   End Function

#Region " LIBRO-IVANSF "
#Region " DataSet-LibroIVANSF "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moFactura.TableName)

      moDataTable.Columns.Add("FacturaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoFacturaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SucursalId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SucursalDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("FacturaFecha", Type.GetType("System.DateTime"))
      moDataTable.Columns.Add("RegRUCId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("NroRUC", Type.GetType("System.String"))
      moDataTable.Columns.Add("RegRUCDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("FacturaNro", Type.GetType("System.String"))
      moDataTable.Columns.Add("NroAutorizacion", Type.GetType("System.String"))
      moDataTable.Columns.Add("CodControl", Type.GetType("System.String"))
      moDataTable.Columns.Add("FacturaMonto", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("IceIehd", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Exento", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Neto", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("IVA", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("TipoCompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCompDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompNro", Type.GetType("System.String"))
      moDataTable.Columns.Add("FacturaObs", Type.GetType("System.String"))
      moDataTable.Columns.Add("EstadoId", Type.GetType("System.Int32"))
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      If mlngTipoFacturaId = 1 Then 'Ventas
         oRow("TipoFacturaId") = 2

      ElseIf mlngTipoFacturaId = 2 Then 'Compras
         oRow("TipoFacturaId") = 1
      End If

      oRow("FacturaId") = oDataRow("FacturaId")
      oRow("TipoCompId") = oDataRow("TipoCompId")
      oRow("TipoCompDes") = oDataRow("TipoCompDes")
      oRow("CompId") = oDataRow("CompId")
      oRow("CompNro") = oDataRow("CompNro")
      oRow("SucursalId") = oDataRow("SucursalId")
      oRow("SucursalDes") = oDataRow("SucursalDes")
      oRow("FacturaFecha") = oDataRow("FacturaFecha")
      oRow("RegRUCId") = oDataRow("RegRUCId")
      oRow("NroRUC") = oDataRow("NroRUC")
      oRow("RegRUCDes") = oDataRow("RegRUCDes")
      oRow("FacturaNro") = oDataRow("FacturaNro")
      oRow("NroAutorizacion") = oDataRow("NroAutorizacion")

      If ToStr(oDataRow("CodControl")) <> "" Then
         oRow("CodControl") = oDataRow("CodControl")
      Else
         oRow("CodControl") = "0"
      End If

      oRow("FacturaMonto") = oDataRow("FacturaMonto")
      oRow("Exento") = oDataRow("Exento")
      oRow("IceIehd") = oDataRow("IceIehd")
      oRow("Neto") = oDataRow("Neto")
      oRow("IVA") = oDataRow("IVA")
      oRow("FacturaObs") = oDataRow("FacturaObs")
      oRow("EstadoId") = oDataRow("EstadoId")

      mlngCantidad += 1
      mdecImporte = mdecImporte + oDataRow("FacturaMonto")
      mdecExento = mdecExento + oDataRow("Exento")
      mdecIceIehd = mdecIceIehd + oDataRow("IceIehd")
      mdecNeto = mdecNeto + oDataRow("Neto")
      mdecIVA = mdecIVA + oDataRow("IVA")

      Return oRow
   End Function

   Private Function GetRowPoliza(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("FacturaId") = oDataRow("PolizaId")
      oRow("TipoFacturaId") = 3
      oRow("SucursalId") = oDataRow("SucursalId")
      oRow("SucursalDes") = oDataRow("SucursalDes")
      oRow("FacturaFecha") = ToDateDMY(oDataRow("PolizaFecha"))
      oRow("RegRUCId") = oDataRow("AduanaId")
      oRow("NroRUC") = oDataRow("AduanaNIT")
      oRow("RegRUCDes") = oDataRow("AduanaDes")
      oRow("FacturaNro") = oDataRow("PolizaNro")
      oRow("NroAutorizacion") = "3"
      oRow("CodControl") = "0"
      oRow("FacturaMonto") = oDataRow("PolizaMonto")
      oRow("IceIehd") = oDataRow("IceIehd")
      oRow("Exento") = 0
      oRow("Neto") = oDataRow("PolizaMonto") - oDataRow("IceIehd")
      oRow("IVA") = oDataRow("IVA")
      oRow("EstadoId") = oDataRow("EstadoId")

      mlngCantidad += 1
      mdecImporte = mdecImporte + oRow("FacturaMonto")
      mdecIceIehd = mdecIceIehd + oDataRow("IceIehd")
      mdecNeto = mdecNeto + oRow("Neto")
      mdecIVA = mdecIVA + oDataRow("IVA")

      Return oRow
   End Function
#End Region

#Region " Metodo-LibroIVANSF "
   Public Sub TotalesLoad()
      txtCantidad.Text = ToStr(moDataSet.Tables(moFactura.TableName).Rows.Count())
      txtImporte.Text = ToDecStr(mdecImporte)
      txtIceIehd.Text = ToDecStr(mdecIceIehd)
      txtExento.Text = ToDecStr(mdecExento)
      txtNeto.Text = ToDecStr(mdecNeto)
      txtIVA.Text = ToDecStr(mdecIVA)
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("FacturaId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Function TipoAsientoIdListaLoad() As String
      Dim strTipoAsientoId As String = String.Empty
      Dim i As Integer = 0

      TipoAsientoIdListaLoad = 0
      For Each lngTipoAsientoId As Long In moListaTipoAsiento
         i += 1

         If i < moListaTipoAsiento.Count Then
            strTipoAsientoId &= ToStr(lngTipoAsientoId) & ", "

         Else
            strTipoAsientoId &= ToStr(lngTipoAsientoId)
         End If
      Next

      If strTipoAsientoId = "-1" Then
         Return ""

      ElseIf i = 1 Then
         Return ToLong(moListaTipoAsiento(0))

      Else
         Return strTipoAsientoId
      End If
   End Function
#End Region

#Region " Grid-LibroIVANSF "
   Private Sub grdMainInit()
      With grdMain
         If mlngTipoFacturaId = 1 Then
            ebrMain.Groups(0).Text = "Libro de Ventas IVA"

         ElseIf mlngTipoFacturaId = 2 Then
            ebrMain.Groups(0).Text = "Libro de Compras IVA"
         End If

         .RootTable.Columns("FacturaId").Visible = False

         .RootTable.Columns("TipoFacturaId").Visible = False

         .RootTable.Columns("SucursalId").Visible = False

         .RootTable.Columns("SucursalDes").Caption = "Sucursal"
         .RootTable.Columns("SucursalDes").Width = 100
         .RootTable.Columns("SucursalDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("SucursalDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaFecha").Caption = "Fecha"
         .RootTable.Columns("FacturaFecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FacturaFecha").Width = 100
         .RootTable.Columns("FacturaFecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FacturaFecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("RegRUCId").Visible = False

         .RootTable.Columns("NroRUC").Caption = "NIT"
         .RootTable.Columns("NroRUC").Width = 100
         .RootTable.Columns("NroRUC").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("NroRUC").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("RegRUCDes").Caption = "Razon Social"
         .RootTable.Columns("RegRUCDes").Width = 200
         .RootTable.Columns("RegRUCDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("RegRUCDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaNro").Caption = "Nro Factura"
         .RootTable.Columns("FacturaNro").Width = 100
         .RootTable.Columns("FacturaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FacturaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroAutorizacion").Caption = "Nro Autorizaci�n"
         .RootTable.Columns("NroAutorizacion").Width = 100
         .RootTable.Columns("NroAutorizacion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("NroAutorizacion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CodControl").Caption = "C�digo Control"
         .RootTable.Columns("CodControl").Width = 100
         .RootTable.Columns("CodControl").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CodControl").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaMonto").Caption = "Importe"
         .RootTable.Columns("FacturaMonto").FormatString = DecimalMask()
         .RootTable.Columns("FacturaMonto").Width = 100
         .RootTable.Columns("FacturaMonto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("FacturaMonto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Exento").Caption = "Exento"
         .RootTable.Columns("Exento").FormatString = DecimalMask()
         .RootTable.Columns("Exento").Width = 100
         .RootTable.Columns("Exento").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Exento").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("IceIehd").Caption = "ICE/IEHD"
         .RootTable.Columns("IceIehd").FormatString = DecimalMask()
         .RootTable.Columns("IceIehd").Width = 100
         .RootTable.Columns("IceIehd").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IceIehd").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Neto").Caption = "Neto"
         .RootTable.Columns("Neto").FormatString = DecimalMask()
         .RootTable.Columns("Neto").Width = 100
         .RootTable.Columns("Neto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Neto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mlngTipoFacturaId = 1 Then
            .RootTable.Columns("IVA").Caption = "D�bito"

         ElseIf mlngTipoFacturaId = 2 Then
            .RootTable.Columns("IVA").Caption = "Cr�dito"
         End If

         .RootTable.Columns("IVA").FormatString = DecimalMask()
         .RootTable.Columns("IVA").Width = 100
         .RootTable.Columns("IVA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IVA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo"
         .RootTable.Columns("TipoCompDes").Width = 100
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("CompNro").Caption = "Nro"
         .RootTable.Columns("CompNro").Width = 100
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaObs").Caption = "Observaci�n"
         .RootTable.Columns("FacturaObs").Width = 100
         .RootTable.Columns("FacturaObs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FacturaObs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False
      End With
   End Sub

   Private Sub grdMainLoad()
      Try
         Call moDataSetInit()
         mstrTipoAsientoId = TipoAsientoIdListaLoad()

         With moFactura
            mlngCantidad = 0
            mdecImporte = 0
            mdecIceIehd = 0
            mdecExento = 0
            mdecNeto = 0
            mdecIVA = 0

            mlngMesIdIni = moLista(0)

            For Each lngMesId As Long In moLista
               .SelectFilter = clsFactura.SelectFilters.LibroIVANSF
               .WhereFilter = clsFactura.WhereFilters.LibroIVANSF

               If mboolOrdenarFecha Then
                  .OrderByFilter = clsFactura.OrderByFilters.LibroIVAFecha
               Else
                  .OrderByFilter = clsFactura.OrderByFilters.LibroIVAFacturaNro
               End If

               .EmpresaId = mlngEmpresaId
               .GestionId = mlngGestionId
               .SucursalId = mlngSucursalId
               .TipoFacturaId = mlngTipoFacturaId
               .MesId = lngMesId
               .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
               If .Open() Then
                  For Each oRow In .DataSet.Tables(.TableName).Rows
                     moDataTable.Rows.Add(GetRow(oRow))
                  Next

                  If mlngTipoFacturaId = 2 Then 'Compras
                     Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)

                     With oPoliza
                        .SelectFilter = clsPoliza.SelectFilters.LibroIVANSF
                        .WhereFilter = clsPoliza.WhereFilters.LibroIVANSF
                        .OrderByFilter = clsPoliza.OrderByFilters.LibroIVA

                        .EmpresaId = mlngEmpresaId
                        .SucursalId = mlngSucursalId
                        .GestionId = mlngGestionId
                        .MesId = lngMesId
                        .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
                        If .Open() Then
                           For Each oRow In .DataSet.Tables(.TableName).Rows
                              moDataTable.Rows.Add(GetRowPoliza(oRow))
                           Next
                        End If

                        .Dispose()
                     End With
                  End If
               End If
            Next

            If mboolOrdenarFecha Then
               moDataSet.Tables(.TableName).DefaultView.Sort = "FacturaFecha"
            End If

            grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()
            Call TotalesLoad()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      If ToLong(grdMain.GetValue("TipoFacturaId")) = 1 Then 'Ventas
         Call CompEdit()

      ElseIf ToLong(grdMain.GetValue("TipoFacturaId")) = 2 Then 'Compras
         Call CompEdit()

      ElseIf ToLong(grdMain.GetValue("TipoFacturaId")) = 3 Then 'Polizas
         Call PolizaEdit()
      End If
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub
#End Region
#End Region
End Class
