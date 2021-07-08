Public Class frmPlanFill
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan
   Private mlngEmpresaId As Long

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mboolFindAll As Boolean
   Private mboolSelected As Boolean
   Private mboolSw As Boolean
   Private mboolAnalitico As Boolean
   Private mlngID As Long

#Region " Set and Get "
   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property FindAll() As Boolean
      Get
         Return mboolFindAll
      End Get

      Set(ByVal Value As Boolean)
         mboolFindAll = Value
      End Set
   End Property

   ReadOnly Property Selected() As Boolean
      Get
         Return mboolSelected
      End Get
   End Property

   ReadOnly Property Sw() As Boolean
      Get
         Return mboolSw
      End Get
   End Property

   WriteOnly Property Analitico() As Boolean
      Set(ByVal Value As Boolean)
         mboolAnalitico = Value
      End Set
   End Property

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property
#End Region

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
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator11 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator12 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator13 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents Check As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Check1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Consultar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Consultar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator10 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanFill))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Check1 = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Separator11 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Consultar1 = New Janus.Windows.UI.CommandBars.UICommand("Consultar")
      Me.Separator10 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll3 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator12 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator13 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit4 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit2 = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit3 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Check = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Consultar = New Janus.Windows.UI.CommandBars.UICommand("Consultar")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 370)
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
      Me.grdMain.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
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
      Me.grdMain.Size = New System.Drawing.Size(728, 370)
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
      ExplorerBarGroup1.ContainerHeight = 371
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 403)
      Me.ebrMain.TabIndex = 1
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
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
      Me.ilsMain.Images.SetKeyName(8, "")
      '
      'Edit
      '
      Me.Edit.ImageIndex = 1
      Me.Edit.Key = "Edit"
      Me.Edit.Name = "Edit"
      Me.Edit.Text = "Editar"
      '
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 3
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
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
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New2, Me.Edit2, Me.Delete, Me.ViewAll2, Me.Print, Me.Exit3, Me.Check, Me.Refrescar, Me.Consultar})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("49225b9f-767d-4822-b58e-c3d62a3818e5")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Check1, Me.Separator11, Me.Consultar1, Me.Separator10, Me.Refrescar1, Me.Separator9, Me.ViewAll3, Me.Separator12, Me.Print1, Me.Separator13, Me.Exit4})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(507, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Check1
      '
      Me.Check1.Key = "Check"
      Me.Check1.Name = "Check1"
      '
      'Separator11
      '
      Me.Separator11.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator11.Key = "Separator"
      Me.Separator11.Name = "Separator11"
      '
      'Consultar1
      '
      Me.Consultar1.Key = "Consultar"
      Me.Consultar1.Name = "Consultar1"
      '
      'Separator10
      '
      Me.Separator10.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator10.Key = "Separator"
      Me.Separator10.Name = "Separator10"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator9
      '
      Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator9.Key = "Separator"
      Me.Separator9.Name = "Separator9"
      '
      'ViewAll3
      '
      Me.ViewAll3.Key = "ViewAll"
      Me.ViewAll3.Name = "ViewAll3"
      '
      'Separator12
      '
      Me.Separator12.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator12.Key = "Separator"
      Me.Separator12.Name = "Separator12"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'Separator13
      '
      Me.Separator13.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator13.Key = "Separator"
      Me.Separator13.Name = "Separator13"
      '
      'Exit4
      '
      Me.Exit4.Key = "Exit"
      Me.Exit4.Name = "Exit4"
      '
      'New2
      '
      Me.New2.ImageIndex = 0
      Me.New2.Key = "New"
      Me.New2.Name = "New2"
      Me.New2.Text = "Nuevo"
      '
      'Edit2
      '
      Me.Edit2.ImageIndex = 1
      Me.Edit2.Key = "Edit"
      Me.Edit2.Name = "Edit2"
      Me.Edit2.Text = "Editar"
      '
      'Delete
      '
      Me.Delete.ImageIndex = 2
      Me.Delete.Key = "Delete"
      Me.Delete.Name = "Delete"
      Me.Delete.Text = "Eliminar"
      '
      'ViewAll2
      '
      Me.ViewAll2.ImageIndex = 3
      Me.ViewAll2.Key = "ViewAll"
      Me.ViewAll2.Name = "ViewAll2"
      Me.ViewAll2.Text = "Ver Todos"
      '
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Exit3
      '
      Me.Exit3.ImageIndex = 5
      Me.Exit3.Key = "Exit"
      Me.Exit3.Name = "Exit3"
      Me.Exit3.Text = "Salir"
      '
      'Check
      '
      Me.Check.ImageIndex = 6
      Me.Check.Key = "Check"
      Me.Check.Name = "Check"
      Me.Check.Text = "Seleccionar"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 7
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
      '
      'Consultar
      '
      Me.Consultar.ImageIndex = 8
      Me.Consultar.Key = "Consultar"
      Me.Consultar.Name = "Consultar"
      Me.Consultar.Text = "Consultar"
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
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
      '
      'Separator8
      '
      Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator8.Key = "Separator"
      Me.Separator8.Name = "Separator8"
      '
      'frmPlanFill
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmPlanFill"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Plan de Cuentas"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
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
         Case "Check"
            Call RecordSelected()

         Case "Consultar"
            Call DataShow()

         Case "Refrescar"
            Call grdMainLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPlanFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPlanFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call grdMainLoad()
      grdMain.Select()
      Call ClearMemory()

      mboolSelected = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moPlan = New clsPlan(clsAppInfo.ConnectString)
   End Sub

   Private Sub frmPlanFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.Return Then
            Call RecordSelected()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPlanFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub PrintReport()
      Dim rpt As New rptPlan

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moPlan.TableName))

      rpt.lblTitle.Text = "Plan de Cuentas"
      rpt.Document.Name = "Plan de Cuentas"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
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

#Region " PLAN "
#Region " Metodo-Plan "
   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("PlanId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("TieneAnaAdd"), Janus.Windows.GridEX.ConditionOperator.Equal, True)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("TieneAnaAdd"), Janus.Windows.GridEX.ConditionOperator.Equal, False)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EsAna"), Janus.Windows.GridEX.ConditionOperator.Equal, False)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " DataSet-Plan "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moPlan.TableName)

      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EmpresaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Nivel", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MonedaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MonedaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("EsAna", Type.GetType("System.Boolean"))
      moDataTable.Columns.Add("SucCCOId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SucCCODes", Type.GetType("System.String"))
      moDataTable.Columns.Add("TieneAnaAdd", Type.GetType("System.Boolean"))
      moDataTable.Columns.Add("TipoPlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoPlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Orden", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanPadreId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EstadoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EstadoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Sw", Type.GetType("System.Boolean"))
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanId") = oDataRow("PlanId")
      oRow("EmpresaId") = oDataRow("EmpresaId")
      oRow("PlanCta") = oDataRow("PlanCta")
      oRow("PlanDes") = oDataRow("PlanDes")
      oRow("Nivel") = oDataRow("Nivel")
      oRow("MonedaId") = oDataRow("MonedaId")
      oRow("MonedaDes") = oDataRow("MonedaDes")
      oRow("EsAna") = oDataRow("EsAna")
      oRow("SucCCOId") = oDataRow("SucCCOId")
      oRow("SucCCODes") = oDataRow("SucCCODes")
      oRow("TieneAnaAdd") = oDataRow("TieneAnaAdd")
      oRow("TipoPlanId") = oDataRow("TipoPlanId")
      oRow("TipoPlanDes") = oDataRow("TipoPlanDes")
      oRow("Orden") = oDataRow("Orden")
      oRow("PlanPadreId") = oDataRow("PlanPadreId")
      oRow("EstadoId") = oDataRow("EstadoId")
      oRow("EstadoDes") = oDataRow("EstadoDes")
      oRow("Sw") = False
      Return oRow
   End Function

   Private Function GetRowAna(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanId") = oDataRow("PlanAddId")
      oRow("EmpresaId") = oDataRow("EmpresaId")
      oRow("PlanCta") = oDataRow("PlanAddCta")
      oRow("PlanDes") = oDataRow("PlanAddDes")
      oRow("Sw") = True
      Return oRow
   End Function
#End Region

#Region " Grid-Plan "
   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Plan de Cuentas"

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("PlanCta").Caption = "Código"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripción"
         .RootTable.Columns("PlanDes").Width = 200
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EsAna").Caption = "Analí."
         .RootTable.Columns("EsAna").Width = 50
         .RootTable.Columns("EsAna").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EsAna").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanPadreId").Visible = False

         .RootTable.Columns("Orden").Caption = "Orden"
         .RootTable.Columns("Orden").Width = 50
         .RootTable.Columns("Orden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Orden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Nivel").Caption = "Nivel"
         .RootTable.Columns("Nivel").Width = 50
         .RootTable.Columns("Nivel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Nivel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoPlanId").Visible = False

         .RootTable.Columns("TipoPlanDes").Caption = "Tipo Cuenta"
         .RootTable.Columns("TipoPlanDes").Width = 100
         .RootTable.Columns("TipoPlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoPlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TieneAnaAdd").Caption = "Ana Ad"
         .RootTable.Columns("TieneAnaAdd").Width = 50
         .RootTable.Columns("TieneAnaAdd").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("TieneAnaAdd").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SucCCOId").Visible = False

         .RootTable.Columns("SucCCODes").Caption = "Suc. / C.C."
         .RootTable.Columns("SucCCODes").Width = 100
         .RootTable.Columns("SucCCODes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("SucCCODes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False
         .RootTable.Columns("Sw").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainLoad()
      Call moDataSetInit()
      Call grdSubMainLoad(0)
      grdMain.DataSource = moDataTable.DefaultView
      grdMain.RetrieveStructure()
      Call grdMainInit()
   End Sub

   Private Sub grdSubMainAnaLoad(ByVal lngPlanId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.All
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddId

            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanId
            If .Open Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRowAna(oRow))
               Next
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanAdd.Dispose()
      End Try
   End Sub

   Private Sub grdSubMainLoad(ByVal lngPlanPadreId As Long)
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim index As Integer
      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.Grid
            .WhereFilter = clsPlan.WhereFilters.Grid
            .OrderByFilter = clsPlan.OrderByFilters.Orden

            .EmpresaId = mlngEmpresaId
            .PlanPadreId = lngPlanPadreId
            index = 0
            If .Open() Then
               Do While index < .DataSet.Tables(.TableName).Rows.Count
                  moDataTable.Rows.Add(GetRow(.DataSet.Tables(.TableName).Rows(index)))

                  If .DataSet.Tables(.TableName).Rows(index)("TieneAnaAdd") _
                 And mboolAnalitico Then
                     Call grdSubMainAnaLoad(.DataSet.Tables(.TableName).Rows(index)("PlanId"))
                  End If

                  Call grdSubMainLoad(.DataSet.Tables(.TableName).Rows(index)("PlanId"))
                  index += 1
               Loop
            End If

         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Sub

   Private Sub DataShowAna()
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Try
         With oPlanAdd
            .PlanAddId = ToLong(grdMain.GetValue("PlanId"))

            If .FindByPK Then
               Dim frm As New frmPlanAddEdit

               frm.NewRecord = False
               frm.Editing = False
               frm.DataObject = oPlanAdd

               frm.ShowDialog()
               frm.Dispose()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanAdd.Dispose()
      End Try
   End Sub

   Private Sub DataShowPlan()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Try
         With oPlan
            .PlanId = ToLong(grdMain.GetValue("PlanId"))

            If .FindByPK Then
               Dim frm As New frmPlanEdit

               frm.NewRecord = False
               frm.Editing = False
               frm.DataObject = oPlan

               frm.ShowDialog()
               frm.Dispose()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Sub

   Private Sub DataShow()
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("PlanId")) > 0 Then
         If ToBoolean(grdMain.GetValue("Sw")) = 1 Then
            Call DataShowAna()
         Else
            Call DataShowPlan()
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call RecordSelected()
   End Sub

   Private Sub RecordSelected()
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("PlanId")) > 0 Then
         If mboolFindAll Then
            mboolSw = ToBoolean(grdMain.GetValue("Sw"))
            mlngID = ToLong(grdMain.GetValue("PlanId"))
            mboolSelected = True
            Me.Close()

         ElseIf ToBoolean(grdMain.GetValue("EsAna")) Then
            mboolSw = ToBoolean(grdMain.GetValue("Sw"))
            mlngID = ToLong(grdMain.GetValue("PlanId"))
            mboolSelected = True
            Me.Close()
         Else
            MessageBox.Show("Debe Seleccionar una Cuenta Analitica", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar una Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
