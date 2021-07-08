Public Class frmCompDetOrden
   Inherits System.Windows.Forms.Form

   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngTipoCompId As Long
   Private mlngCompNro As Long
   Private mstrTipoCompDes As String
   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moDataTableOrigen As DataTable

   Private mboolFind As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents indexar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents indexar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents up As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents down As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents up1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents down1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
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

   Property Find() As Boolean
      Get
         Return mboolFind
      End Get

      Set(ByVal Value As Boolean)
         mboolFind = Value
      End Set
   End Property

   Property CompId() As Long
      Get
         Return mlngCompId
      End Get
      Set(ByVal value As Long)
         mlngCompId = value
      End Set
   End Property

   Property TipoCompId() As Long
      Get
         Return mlngTipoCompId
      End Get
      Set(ByVal value As Long)
         mlngTipoCompId = value
      End Set
   End Property

   Property CompNro() As Long
      Get
         Return mlngCompNro
      End Get
      Set(ByVal value As Long)
         mlngCompNro = value
      End Set
   End Property

   Property TipoCompDes() As String
      Get
         Return mstrTipoCompDes
      End Get
      Set(ByVal value As String)
         mstrTipoCompDes = value
      End Set
   End Property

   Property DataTable() As DataTable
      Get
         Return moDataTableOrigen
      End Get
      Set(ByVal value As DataTable)
         moDataTableOrigen = value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
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
   Friend WithEvents Anal As Janus.Windows.UI.CommandBars.UICommand
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Find1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Check As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents FindFast As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompDetOrden))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.indexar1 = New Janus.Windows.UI.CommandBars.UICommand("indexar")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.up1 = New Janus.Windows.UI.CommandBars.UICommand("up")
      Me.down1 = New Janus.Windows.UI.CommandBars.UICommand("down")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.Find1 = New Janus.Windows.UI.CommandBars.UICommand("Find")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Check = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.FindFast = New Janus.Windows.UI.CommandBars.UICommand("FindFast")
      Me.Anal = New Janus.Windows.UI.CommandBars.UICommand("Ana")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.indexar = New Janus.Windows.UI.CommandBars.UICommand("indexar")
      Me.up = New Janus.Windows.UI.CommandBars.UICommand("up")
      Me.down = New Janus.Windows.UI.CommandBars.UICommand("down")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(930, 517)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdMain
      '
      Me.grdMain.AllowCardSizing = False
      Me.grdMain.AlternatingColors = True
      Me.grdMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdMain.BackgroundImageDrawMode = Janus.Windows.GridEX.BackgroundImageDrawMode.Stretch
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
      Me.grdMain.Size = New System.Drawing.Size(930, 517)
      Me.grdMain.TabIndex = 4
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.UiGroupBox2)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 39)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(952, 561)
      Me.uiBackground.TabIndex = 5
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.ebrMain)
      Me.UiGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.UiGroupBox2.Location = New System.Drawing.Point(0, 0)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(952, 561)
      Me.UiGroupBox2.TabIndex = 1
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'ebrMain
      '
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      Me.ebrMain.Dock = System.Windows.Forms.DockStyle.Fill
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 518
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(3, 8)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(946, 550)
      Me.ebrMain.TabIndex = 4
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New2, Me.Edit, Me.Delete, Me.Find1, Me.Print, Me.Exit2, Me.Check, Me.Refrescar, Me.FindFast, Me.Anal, Me.Save, Me.indexar, Me.up, Me.down})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("cf56bcb2-a64f-42eb-bf46-c838b504a780")
      Me.cdmMain.ImageList = Me.ilsMain
      Me.cdmMain.LeftRebar = Me.LeftRebar1
      Me.cdmMain.RightRebar = Me.RightRebar1
      Me.cdmMain.TopRebar = Me.TopRebar1
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator4, Me.indexar1, Me.Separator1, Me.up1, Me.down1, Me.Separator3, Me.Refrescar1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.FloatingSize = New System.Drawing.Size(320, 44)
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(320, 39)
      Me.UiCommandBar1.Text = "tbrMain"
      Me.UiCommandBar1.TextAlign = Janus.Windows.UI.CommandBars.TextAlign.Underneath
      Me.UiCommandBar1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'indexar1
      '
      Me.indexar1.Key = "indexar"
      Me.indexar1.Name = "indexar1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'up1
      '
      Me.up1.Key = "up"
      Me.up1.Name = "up1"
      '
      'down1
      '
      Me.down1.Key = "down"
      Me.down1.Name = "down1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
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
      'Find1
      '
      Me.Find1.ImageIndex = 3
      Me.Find1.Key = "Find"
      Me.Find1.Name = "Find1"
      Me.Find1.Text = "Buscar"
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
      'Check
      '
      Me.Check.ImageIndex = 7
      Me.Check.Key = "Check"
      Me.Check.Name = "Check"
      Me.Check.Text = "Seleccionar"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 11
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Revertir"
      '
      'FindFast
      '
      Me.FindFast.ImageIndex = 9
      Me.FindFast.Key = "FindFast"
      Me.FindFast.Name = "FindFast"
      Me.FindFast.Text = "Busqueda Rápida"
      '
      'Anal
      '
      Me.Anal.CommandType = Janus.Windows.UI.CommandBars.CommandType.ToggleButton
      Me.Anal.IsEditableControl = Janus.Windows.UI.InheritableBoolean.[True]
      Me.Anal.Key = "Ana"
      Me.Anal.Name = "Anal"
      Me.Anal.Text = "Analiticos"
      Me.Anal.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Save
      '
      Me.Save.ImageIndex = 1
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.Text = "Guardar"
      '
      'indexar
      '
      Me.indexar.ImageIndex = 8
      Me.indexar.Key = "indexar"
      Me.indexar.Name = "indexar"
      Me.indexar.Text = "Indexar Orden "
      '
      'up
      '
      Me.up.ImageIndex = 9
      Me.up.Key = "up"
      Me.up.Name = "up"
      Me.up.ToolTipText = "Arriba"
      '
      'down
      '
      Me.down.ImageIndex = 10
      Me.down.Key = "down"
      Me.down.Name = "down"
      Me.down.ToolTipText = "Abajo"
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
      Me.ilsMain.Images.SetKeyName(7, "1444682493_txt2.ico")
      Me.ilsMain.Images.SetKeyName(8, "Opciones1.png")
      Me.ilsMain.Images.SetKeyName(9, "32.ico")
      Me.ilsMain.Images.SetKeyName(10, "35.ico")
      Me.ilsMain.Images.SetKeyName(11, "actualizar.ico")
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 600)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(952, 0)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 600)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(952, 39)
      Me.TopRebar1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'frmCompDetOrden
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(952, 600)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmCompDetOrden"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Reordenar Cuentas"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
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

         Case "Save"
            If DataSave() Then
               mboolChanged = True
               Me.Close()
            End If

         Case "indexar"
            Call grdMainIndexar()

         Case "up"
            Call UpLoad()

         Case "down"
            Call DownLoad()

         Case "Refrescar"
            Call grdMainLoad()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompDetOrden_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompDetOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      If Not mboolFind Then
         cdmMain.Commands.Item("Check").Visible = Janus.Windows.UI.InheritableBoolean.False
      End If
   End Sub

   Private Sub grdMainLoad()
      Call moDataSetInit()
      Try
         For Each oRow In moDataTableOrigen.Rows
            If oRow("Automatico") = 0 Then
               moDataTable.Rows.Add(GetRowShow(oRow))
            End If
         Next

         grdMain.DataSource = moDataTable.DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function GetRowShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      'oRow("Sel") = 0
      oRow("CompDetId") = oDataRow("CompDetId")
      oRow("OrdenOrg") = oDataRow("Orden")
      oRow("Orden") = oDataRow("Orden")
      oRow("PlanId") = oDataRow("PlanId")
      oRow("PlanCta") = oDataRow("PlanCta")
      oRow("PlanDes") = oDataRow("PlanDes")
      oRow("CompDetDes") = oDataRow("CompDetDes")
      oRow("Debe") = oDataRow("Debe")
      oRow("Haber") = oDataRow("Haber")
      oRow("Equi") = oDataRow("Equi")
      oRow("Automatico") = oDataRow("Automatico")
      oRow("Estado") = "Show"

      Return oRow
   End Function

   Private Sub frmCompDetOrden_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mboolChanged = True
                  Me.Close()
               End If
            End If

            'ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            '   If cdmMain.Commands.Item("Edit").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
            '      '  Call DataEdit()
            '   End If
            'ElseIf (e.KeyCode = Keys.Delete) And (e.Shift = True) Then
            '   If cdmMain.Commands.Item("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
            '      '  Call DataDelete()
            '   End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompDetOrden_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

#Region " grid "

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add("Tabla")

      moDataTable.Columns.Add("CompDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("OrdenOrg", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Orden", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompDetDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Debe", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Haber", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Equi", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Automatico", Type.GetType("System.Byte"))
      moDataTable.Columns.Add("Estado", Type.GetType("System.String"))
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Detalle del Comprobante"
         '  .ContextMenu = mnuMain

         '.RootTable.Columns("Sel").Caption = "Sel"
         '.RootTable.Columns("Sel").Width = 50
         '.RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         '.RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         '.RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("CompDetId").Caption = "Id"
         .RootTable.Columns("CompDetId").Width = 80
         .RootTable.Columns("CompDetId").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompDetId").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompDetId").EditType = Janus.Windows.GridEX.EditType.NoEdit
         .RootTable.Columns("CompDetId").Visible = False

         .RootTable.Columns("OrdenOrg").Visible = False

         .RootTable.Columns("Orden").Caption = "Orden"
         .RootTable.Columns("Orden").Width = 60
         .RootTable.Columns("Orden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Orden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Orden").EditType = Janus.Windows.GridEX.EditType.TextBox
         .RootTable.Columns("Orden").FilterEditType = Janus.Windows.GridEX.FilterEditType.TextBox
         '.RootTable.Columns("Orden").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("PlanCta").Caption = "Código"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PlanCta").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("PlanDes").Caption = "Descripción"
         .RootTable.Columns("PlanDes").Width = 200
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PlanDes").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("CompDetDes").Caption = "Glosa"
         .RootTable.Columns("CompDetDes").Width = 100
         .RootTable.Columns("CompDetDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompDetDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompDetDes").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("Debe").Caption = "Debe"
         .RootTable.Columns("Debe").FormatString = DecimalMask()
         .RootTable.Columns("Debe").Width = 90
         .RootTable.Columns("Debe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Debe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Debe").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("Haber").Caption = "Haber"
         .RootTable.Columns("Haber").FormatString = DecimalMask()
         .RootTable.Columns("Haber").Width = 90
         .RootTable.Columns("Haber").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Haber").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Haber").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("Equi").Caption = "Equiv."
         .RootTable.Columns("Equi").FormatString = DecimalMask()
         .RootTable.Columns("Equi").Width = 90
         .RootTable.Columns("Equi").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Equi").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Equi").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("Automatico").Visible = False

         .RootTable.Columns("Estado").Visible = False
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Debe"), Janus.Windows.GridEX.ConditionOperator.NotEqual, System.Convert.DBNull)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Haber"), Janus.Windows.GridEX.ConditionOperator.NotEqual, System.Convert.DBNull)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Automatico"), Janus.Windows.GridEX.ConditionOperator.Equal, 255)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

   Private Sub grdMainIndexar()
      Dim count As Long = 1
      Dim Index As Long = 1

      'If (boolMenorMayor) Then
      '   Index = grdMain.RowCount
      '   count = -1
      'End If
      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
            oRow.BeginEdit()

            oRow.Cells("Orden").Value = Index
            oRow.Cells("Estado").Value = "Edit"

            Index += count
            oRow.EndEdit()
         Next
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      FormCheck = False
      'If Not moDataTable.AsEnumerable.ToList.Exists(Function(f) f("Estado") = "Edit") Then
      '   strMsg &= "No se hicieron cambios en el orden"
      'End If
      For Each row In moDataTable.Rows
         If row("Estado") = "Edit" Then
            FormCheck = True
            Exit For
         End If
      Next

      If Not FormCheck Then
         Throw New Exception("No hubo cambios en el orden de las cuentas.")
      End If
   End Function

   Private Sub CloneVM(ByRef oCompDet As clsCompDet, ByVal row As Janus.Windows.GridEX.GridEXRow)
      If clsAppInfo.RegistrarBitacora Then

         With oCompDet.VMNew
            .CompId = mlngCompId
            .CompDetId = ToLong(row.Cells("CompDetId").Value)
            .TipoCompId = mlngTipoCompId
            .CompNro = mlngCompNro
            .TipoCompDes = mstrTipoCompDes
            .Orden = ToLong(row.Cells("Orden").Value)

            .FormName = Me.Name
            .FormText = Me.Text
         End With

         With oCompDet.VMOld
            .CompId = mlngCompId
            .CompDetId = ToLong(row.Cells("CompDetId").Value)
            .TipoCompId = mlngTipoCompId
            .CompNro = mlngCompNro
            .TipoCompDes = mstrTipoCompDes
            .Orden = ToLong(row.Cells("OrdenOrg").Value)

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Function DataSave() As Boolean
      DataSave = False
      Try
         If FormCheck() Then
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
               If ToStr(oRow.Cells("Estado").Value) = "Edit" Then
                  Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

                  With oCompDet
                     .CompDetId = oRow.Cells("CompDetId").Value
                     .Orden = oRow.Cells("Orden").Value
                     .UpdateFilter = clsCompDet.UpdateFilters.Orden

                     Call CloneVM(oCompDet, oRow)
                     If .UpdateOnly Then
                        DataSave = True
                     End If
                  End With
               End If
            Next
         End If
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End Try
   End Function

   Public Function TipoCompFind(ByVal lngTipoCompId As Long) As String
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)

      TipoCompFind = ""
      Try
         With oTipoComp
            .TipoCompId = lngTipoCompId

            If .FindByPK Then
               TipoCompFind = .TipoCompDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oTipoComp.Dispose()
      End Try
   End Function

   Private Function GetRowNewClonB(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      'oRow("Sel") = 0
      oRow("CompDetId") = oDataRow("CompDetId")
      oRow("OrdenOrg") = oDataRow("OrdenOrg")
      oRow("Orden") = oDataRow("Orden")
      oRow("PlanId") = oDataRow("PlanId")
      oRow("PlanCta") = oDataRow("PlanCta")
      oRow("PlanDes") = oDataRow("PlanDes")
      oRow("CompDetDes") = oDataRow("CompDetDes")
      oRow("Debe") = oDataRow("Debe")
      oRow("Haber") = oDataRow("Haber")
      oRow("Equi") = oDataRow("Equi")
      oRow("Automatico") = oDataRow("Automatico")
      oRow("Estado") = oDataRow("Estado")

      Return oRow
   End Function

   Private Sub UpLoad()
      Call RemoveSorKeys()
      If grdMain.CurrentRow.Position = 0 Then
         Exit Sub
      End If
      Dim index = grdMain.CurrentRow.Position
      Dim aux = GetRowNewClonB(moDataTable.Rows.Item(index))

      aux("Estado") = "Edit"
      Dim orden As Long = aux("Orden")
      aux("Orden") = moDataTable.Rows.Item(index - 1)("Orden")
      moDataTable.Rows.Item(index - 1)("Orden") = orden
      moDataTable.Rows.Item(index - 1)("Estado") = "Edit"

      moDataTable.Rows.RemoveAt(index)
      moDataTable.Rows.InsertAt(aux, index - 1)
      grdMain.Refetch()
      grdMain.Row = index - 1
   End Sub

   Private Sub DownLoad()
      Call RemoveSorKeys()
      If grdMain.CurrentRow.Position = grdMain.RowCount - 1 Then
         Exit Sub
      End If
      Dim index = grdMain.CurrentRow.Position
      Dim aux = GetRowNewClonB(moDataTable.Rows.Item(index))

      aux("Estado") = "Edit"
      Dim orden As Long = aux("Orden")
      aux("Orden") = moDataTable.Rows.Item(index + 1)("Orden")
      moDataTable.Rows.Item(index + 1)("Orden") = orden
      moDataTable.Rows.Item(index + 1)("Estado") = "Edit"

      moDataTable.Rows.RemoveAt(index)
      moDataTable.Rows.InsertAt(aux, index + 1)
      grdMain.Refetch()
      grdMain.Row = index + 1
   End Sub

   Private Sub grdMain_SortKeysChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.SortKeysChanged
      Call grdMainMove()
   End Sub

   Private Sub RemoveSorKeys()
      grdMain.RootTable.SortKeys.Clear()
      grdMain.Refetch()
   End Sub

   Private Sub grdMainMove()
      Dim Index As Long = 0
      Try
         Dim row As DataRow
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
            Dim lngCompDetId As Long = ToLong(oRow.Cells("CompDetId").Value)
            row = GetRow(lngCompDetId)
            Dim oDataRow As DataRow = GetRowNewClonB(row)
            moDataTable.Rows.InsertAt(oDataRow, Index)
            moDataTable.Rows.Remove(row)
            Index += 1
         Next
         grdMain.Refetch()
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function GetRow(ByVal lngCompDetId As Long) As DataRow
      For Each oRow In moDataTable.Rows
         If oRow("CompDetId") = lngCompDetId Then
            Return oRow
         End If
      Next
   End Function

   Private Sub grdMain_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdMain.UpdatingCell
      If e.Column.DataMember = "Orden" Then
         If e.InitialValue <> e.Value Then
            grdMain.SetValue("Estado", "Edit")
            grdMain.RootTable.SortKeys.Add(grdMain.RootTable.Columns("Orden"), Janus.Windows.GridEX.SortOrder.Ascending)
            grdMain.Refetch()
         End If
      End If
   End Sub
End Class
