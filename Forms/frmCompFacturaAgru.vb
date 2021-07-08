Public Class frmCompFacturaAgru
   Inherits System.Windows.Forms.Form

   Private moFacturaAgru As clsFacturaAgru
   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompId As Long
   Private mdecTipoCambio As Decimal
   Private mstrFecha As String

   Private mdecImporte As Decimal
   Private mdecIceIehd As Decimal
   Private mdecExento As Decimal
   Private mdecNeto As Decimal
   Private mdecIVA As Decimal
   Private mdecImporteIVA As Decimal

   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Private mboolChanged As Boolean

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property CompId() As Long
      Get
         Return mlngCompId
      End Get

      Set(ByVal Value As Long)
         mlngCompId = Value
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

   Property TipoCompId() As Long
      Get
         Return mlngTipoCompId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCompId = Value
      End Set
   End Property

   Property TipoCambio() As Decimal
      Get
         Return mdecTipoCambio
      End Get

      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

   Property Fecha() As String
      Get
         Return mstrFecha
      End Get

      Set(ByVal Value As String)
         mstrFecha = Value
      End Set
   End Property

   WriteOnly Property NewRecord() As Boolean
      Set(ByVal Value As Boolean)
         mboolAdding = Value
      End Set
   End Property

   WriteOnly Property Editing() As Boolean
      Set(ByVal Value As Boolean)
         mboolEditing = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

#Region " Código generado por el Diseñador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Diseñador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Diseñador de Windows Forms. 
   'No lo modifique con el editor de código.
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents txtImporteIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNeto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtExento As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIceIehd As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompFacturaAgru))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
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
      Me.Label11 = New System.Windows.Forms.Label
      Me.txtImporteIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
      Me.mnuEdit = New System.Windows.Forms.MenuItem
      Me.mnuDelete = New System.Windows.Forms.MenuItem
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Edit1 = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Delete1 = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 313)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 313)
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
      Me.uiBackground.TabIndex = 5
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
      ExplorerBarGroup1.ContainerHeight = 314
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 346)
      Me.ebrMain.TabIndex = 161
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
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.txtImporteIVA)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 350)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(736, 56)
      Me.grpMain.TabIndex = 160
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtImporte
      '
      Me.txtImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtImporte.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporte.FormatString = "##,##0.000"
      Me.txtImporte.Location = New System.Drawing.Point(108, 28)
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.ReadOnly = True
      Me.txtImporte.Size = New System.Drawing.Size(100, 20)
      Me.txtImporte.TabIndex = 1
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
      Me.txtIceIehd.Location = New System.Drawing.Point(212, 28)
      Me.txtIceIehd.Name = "txtIceIehd"
      Me.txtIceIehd.ReadOnly = True
      Me.txtIceIehd.Size = New System.Drawing.Size(100, 20)
      Me.txtIceIehd.TabIndex = 2
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
      Me.txtExento.Location = New System.Drawing.Point(316, 28)
      Me.txtExento.Name = "txtExento"
      Me.txtExento.ReadOnly = True
      Me.txtExento.Size = New System.Drawing.Size(100, 20)
      Me.txtExento.TabIndex = 3
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
      Me.txtNeto.Location = New System.Drawing.Point(420, 28)
      Me.txtNeto.Name = "txtNeto"
      Me.txtNeto.ReadOnly = True
      Me.txtNeto.Size = New System.Drawing.Size(100, 20)
      Me.txtNeto.TabIndex = 4
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
      Me.txtIVA.Location = New System.Drawing.Point(524, 28)
      Me.txtIVA.Name = "txtIVA"
      Me.txtIVA.ReadOnly = True
      Me.txtIVA.Size = New System.Drawing.Size(100, 20)
      Me.txtIVA.TabIndex = 5
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
      Me.Label6.Location = New System.Drawing.Point(108, 12)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(100, 16)
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
      Me.Label7.Location = New System.Drawing.Point(212, 12)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(100, 16)
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
      Me.Label8.Location = New System.Drawing.Point(316, 12)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(100, 16)
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
      Me.Label9.Location = New System.Drawing.Point(420, 12)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(100, 16)
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
      Me.Label10.Location = New System.Drawing.Point(524, 12)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(100, 16)
      Me.Label10.TabIndex = 136
      Me.Label10.Text = "IVA"
      Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label11
      '
      Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label11.Location = New System.Drawing.Point(628, 12)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(100, 16)
      Me.Label11.TabIndex = 135
      Me.Label11.Text = "Importe - IVA"
      Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'txtImporteIVA
      '
      Me.txtImporteIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtImporteIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporteIVA.FormatString = "##,##0.000"
      Me.txtImporteIVA.Location = New System.Drawing.Point(628, 28)
      Me.txtImporteIVA.Name = "txtImporteIVA"
      Me.txtImporteIVA.ReadOnly = True
      Me.txtImporteIVA.Size = New System.Drawing.Size(100, 20)
      Me.txtImporteIVA.TabIndex = 6
      Me.txtImporteIVA.Text = "0,000"
      Me.txtImporteIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporteIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporteIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuEdit, Me.mnuDelete})
      '
      'mnuShow
      '
      Me.mnuShow.Index = 0
      Me.mnuShow.Text = "Consultar"
      '
      'mnuEdit
      '
      Me.mnuEdit.Index = 1
      Me.mnuEdit.Text = "Editar"
      '
      'mnuDelete
      '
      Me.mnuDelete.Index = 2
      Me.mnuDelete.Text = "Eliminar"
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New2, Me.Edit, Me.Delete, Me.ViewAll, Me.Print, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("0a57b409-ff70-4bcf-927c-baf0c53e9f5d")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Edit1, Me.Separator2, Me.Delete1, Me.Separator3, Me.ViewAll1, Me.Separator4, Me.Print1, Me.Separator5, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(384, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Edit1
      '
      Me.Edit1.Key = "Edit"
      Me.Edit1.Name = "Edit1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Delete1
      '
      Me.Delete1.Key = "Delete"
      Me.Delete1.Name = "Delete1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'ViewAll1
      '
      Me.ViewAll1.Key = "ViewAll"
      Me.ViewAll1.Name = "ViewAll1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'New2
      '
      Me.New2.ImageIndex = 0
      Me.New2.Key = "New"
      Me.New2.Name = "New2"
      Me.New2.Text = "Nuevo"
      '
      'Edit
      '
      Me.Edit.ImageIndex = 1
      Me.Edit.Key = "Edit"
      Me.Edit.Name = "Edit"
      Me.Edit.Text = "Editar"
      '
      'Delete
      '
      Me.Delete.ImageIndex = 2
      Me.Delete.Key = "Delete"
      Me.Delete.Name = "Delete"
      Me.Delete.Text = "Eliminar"
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
      'frmCompFacturaAgru
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MinimizeBox = False
      Me.Name = "frmCompFacturaAgru"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Facturas de Venta Agrupadas"
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
         Case "New"
            'Call FormNew()

         Case "Edit"
            Call DataEdit()

         Case "Delete"
            Call DataDelete()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmFacturaAgru_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmFacturaAgru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call ClearMemory()

      If Not mboolEditing Then
         cdmMain.Commands.Item("Edit").Enabled = Janus.Windows.UI.InheritableBoolean.False
         cdmMain.Commands.Item("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.False
      End If

      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad()
      Try
         With moFacturaAgru
            .SelectFilter = clsFacturaAgru.SelectFilters.Grid
            .WhereFilter = clsFacturaAgru.WhereFilters.Grid
            .OrderByFilter = clsFacturaAgru.OrderByFilters.Grid
            .EmpresaId = mlngEmpresaId
            .CompId = mlngCompId

            If .Open() Then
               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
               Call TotalesLoad()

               txtImporte.Text = ToDecStr(mdecImporte)
               txtIceIehd.Text = ToDecStr(mdecIceIehd)
               txtExento.Text = ToDecStr(mdecExento)
               txtNeto.Text = ToDecStr(mdecNeto)
               txtIVA.Text = ToDecStr(mdecIVA)
               txtImporteIVA.Text = ToDecStr(mdecImporteIVA)
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataShow()
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("FacturaAgruId")) > 0) Then
            With oFacturaAgru
               .FacturaAgruId = ToLong(grdMain.GetValue("FacturaAgruId"))

               If .FindByPK Then
                  Dim frm As New frmCompFacturaAgruEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oFacturaAgru

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Sub

   Private Sub FormNew()
      'Dim frm As New frmFacturaAgruEdit
      'Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)

      ''Nueva FacturaAgru Anulada
      'Try
      '   With frm
      '      .NewRecord = True
      '      .Editing = False
      '      .Anulada = True

      '      oFacturaAgru.EmpresaId = mlngEmpresaId
      '      oFacturaAgru.CompId = mlngCompId
      '      oFacturaAgru.GestionId = mlngGestionId
      '      oFacturaAgru.TipoCompId = mlngTipoCompId
      '      oFacturaAgru.TipoFacturaAgruId = mlngTipoFacturaAgruId
      '      oFacturaAgru.FacturaAgruFecha = mstrFecha

      '      .CompFecha = mstrFecha
      '      .TipoCambio = mdecTipoCambio
      '      .DataObject = oFacturaAgru
      '      .ShowDialog()

      '      If .Changed Then
      '         Call grdMainLoad()
      '         Call grdMainFindRow(frm.ID)
      '         frm = Nothing
      '         mboolChanged = True
      '      End If
      '   End With

      'Catch exp As Exception
      '   MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      'Finally
      '   oFacturaAgru.Dispose()

      'End Try
   End Sub

   Private Sub DataEdit()
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            With oFacturaAgru
               .FacturaAgruId = ToLong(grdMain.GetValue("FacturaAgruId"))

               If .FindByPK Then
                  Dim frm As New frmCompFacturaAgruEdit

                  frm.NewRecord = False
                  frm.Editing = True

                  If .FacturaMonto = 0 Then
                     frm.Anulada = True
                  Else
                     frm.Anulada = False
                  End If

                  frm.CompFecha = mstrFecha
                  frm.TipoCambio = mdecTipoCambio
                  frm.DataObject = oFacturaAgru
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdMainLoad()
                     Call grdMainFindRow(frm.ID)
                     mboolChanged = True
                  End If

                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Sub

   Private Sub DataDelete()
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               With oFacturaAgru
                  .WhereFilter = clsFacturaAgru.WhereFilters.PrimaryKey
                  .FacturaAgruId = ToLong(grdMain.GetValue("FacturaAgruId"))

                  If .Delete Then
                     .CloseConection()
                     If DataUpDateResto(moFacturaAgru.CompId) Then
                        Call grdMainLoad()
                        mboolChanged = True
                     End If
                  End If
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Sub

   Public Sub TotalesLoad()
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)

      Try
         mdecImporte = 0
         mdecIceIehd = 0
         mdecExento = 0
         mdecNeto = 0
         mdecIVA = 0
         mdecImporteIVA = 0

         With oFacturaAgru
            .SelectFilter = clsFacturaAgru.SelectFilters.All
            .WhereFilter = clsFacturaAgru.WhereFilters.CompId
            .EmpresaId = mlngEmpresaId
            .CompId = mlngCompId

            If .Open Then
               Do While .Read
                  mdecImporte = ToDecimal(mdecImporte + .FacturaMonto)
                  mdecIceIehd = ToDecimal(mdecIceIehd + .IceIehd)
                  mdecExento = ToDecimal(mdecExento + .Exento)
                  mdecNeto = ToDecimal(mdecNeto + (.FacturaMonto - (.Exento + .IceIehd)))
                  mdecIVA = ToDecimal(mdecIVA + .IVA)
                  mdecImporteIVA = ToDecimal(mdecImporteIVA + ((.FacturaMonto - (.Exento + .IceIehd)) - .IVA))

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Sub

   Private Function DataUpDateResto(ByVal lngCompId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         DataUpDateResto = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moFacturaAgru.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read()
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = 13

                  If .MonedaId = 1 Then
                     If .DebeOrg <> 0 Then
                        .DebeBs = .DebeOrg
                        .HaberBs = 0
                        .DebeUs = ToDecimal(.DebeOrg / mdecTipoCambio)
                        .HaberUs = 0
                     ElseIf .HaberOrg <> 0 Then
                        .DebeBs = 0
                        .HaberBs = .HaberOrg
                        .DebeUs = 0
                        .HaberUs = ToDecimal(.HaberOrg / mdecTipoCambio)
                     End If
                  ElseIf .MonedaId = 2 Then
                     If .DebeOrg <> 0 Then
                        .DebeBs = ToDecimal(.DebeOrg * mdecTipoCambio)
                        .HaberBs = 0
                        .DebeUs = .DebeOrg
                        .HaberUs = 0
                     ElseIf .HaberOrg <> 0 Then
                        .DebeBs = 0
                        .HaberBs = ToDecimal(.HaberOrg * mdecTipoCambio)
                        .DebeUs = 0
                        .HaberUs = .HaberOrg
                     End If
                  End If

                  If .Update() Then
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         DataUpDateResto = True

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
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

   Private Sub PrintReport()
      Dim rpt As New rptLibroAgruIVA

      rpt.DataSource = GetDataView(moFacturaAgru.DataSet.Tables(moFacturaAgru.TableName))

      rpt.lblTitle.Text = "Facturas de Ventas Agrupadas"
      rpt.Document.Name = "Facturas de Ventas Agrupadas"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document)
      frm.Show()
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("FacturaAgruId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      txtImporte.FormatString = DecimalMask()
      txtIceIehd.FormatString = DecimalMask()
      txtExento.FormatString = DecimalMask()
      txtNeto.FormatString = DecimalMask()
      txtIVA.FormatString = DecimalMask()
      txtImporteIVA.FormatString = DecimalMask()

      moFacturaAgru = New clsFacturaAgru(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Facturas de Ventas Agrupadas"
         .ContextMenu = mnuMain

         .RootTable.Columns("FacturaAgruId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("CompDetId").Visible = False

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("PlanDes").Caption = "Cuenta"
         .RootTable.Columns("PlanDes").Width = 150
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GestionId").Visible = False

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("FacturaNroIni").Caption = "Nro Inicial"
         .RootTable.Columns("FacturaNroIni").Width = 100
         .RootTable.Columns("FacturaNroIni").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FacturaNroIni").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaNroFin").Caption = "Nro Final"
         .RootTable.Columns("FacturaNroFin").Width = 100
         .RootTable.Columns("FacturaNroFin").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FacturaNroFin").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaFecha").Caption = "Fecha"
         .RootTable.Columns("FacturaFecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FacturaFecha").Width = 100
         .RootTable.Columns("FacturaFecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FacturaFecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroAutorizacion").Caption = "Nro Autorización"
         .RootTable.Columns("NroAutorizacion").Width = 100
         .RootTable.Columns("NroAutorizacion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("NroAutorizacion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaMonto").Caption = "Importe"
         .RootTable.Columns("FacturaMonto").FormatString = DecimalMask()
         .RootTable.Columns("FacturaMonto").Width = 80
         .RootTable.Columns("FacturaMonto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("FacturaMonto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("IceIehd").Caption = "ICE/IEHD"
         .RootTable.Columns("IceIehd").FormatString = DecimalMask()
         .RootTable.Columns("IceIehd").Width = 100
         .RootTable.Columns("IceIehd").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IceIehd").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Exento").Caption = "Exento"
         .RootTable.Columns("Exento").FormatString = DecimalMask()
         .RootTable.Columns("Exento").Width = 100
         .RootTable.Columns("Exento").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Exento").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Neto").Caption = "Neto"
         .RootTable.Columns("Neto").FormatString = DecimalMask()
         .RootTable.Columns("Neto").Width = 100
         .RootTable.Columns("Neto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Neto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("IVA").Caption = "IVA"
         .RootTable.Columns("IVA").FormatString = DecimalMask()
         .RootTable.Columns("IVA").Width = 100
         .RootTable.Columns("IVA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("IVA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImporteIVA").Caption = "Importe - IVA"
         .RootTable.Columns("ImporteIVA").FormatString = DecimalMask()
         .RootTable.Columns("ImporteIVA").Width = 100
         .RootTable.Columns("ImporteIVA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("ImporteIVA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("FacturaObs").Caption = "Observación"
         .RootTable.Columns("FacturaObs").Width = 100
         .RootTable.Columns("FacturaObs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("FacturaObs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call DataShow()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         mnuShow.Enabled = True
         mnuEdit.Enabled = JanusToBooleam(cdmMain.Commands.Item("Edit").Enabled)
         mnuDelete.Enabled = JanusToBooleam(cdmMain.Commands.Item("Delete").Enabled)
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call DataShow()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      Call DataEdit()
   End Sub

   Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
      Call DataDelete()
   End Sub

   Private Sub frmFacturaAgru_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            'Call FormNew()

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Edit").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               Call DataEdit()
            End If

         ElseIf (e.KeyCode = Keys.Delete) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               Call DataDelete()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmFacturaAgru_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moFacturaAgru.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub grdMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMain.MouseDown
      If e.Button = MouseButtons.Right Then
         If grdMain.RowCount > 0 Then
            mnuShow.Enabled = True
            mnuEdit.Enabled = JanusToBooleam(cdmMain.Commands.Item("Edit").Enabled)
            mnuDelete.Enabled = JanusToBooleam(cdmMain.Commands.Item("Delete").Enabled)
         Else
            mnuShow.Enabled = False
            mnuEdit.Enabled = False
            mnuDelete.Enabled = False
         End If
      End If
   End Sub
End Class
