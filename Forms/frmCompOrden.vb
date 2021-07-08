Public Class frmCompOrden
   Inherits System.Windows.Forms.Form

   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moDataTableOrigen As DataTable
   Private moComp As clsComp

   Private mlngActual As Long

   Private mboolChanged As Boolean
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents indexar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents up As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents down As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboTipoComp As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refresh1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refresh As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents mnucalcular As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnucalcular1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
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


   Property CompId() As Long
      Get
         Return mlngCompId
      End Get
      Set(ByVal value As Long)
         mlngCompId = value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompOrden))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboTipoComp = New Janus.Windows.EditControls.UIComboBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refresh1 = New Janus.Windows.UI.CommandBars.UICommand("Refresh")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
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
      Me.Refresh = New Janus.Windows.UI.CommandBars.UICommand("Refresh")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.mnucalcular = New Janus.Windows.UI.CommandBars.UICommand("mnucalcular")
      Me.mnucalcular1 = New Janus.Windows.UI.CommandBars.UICommand("mnucalcular")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(932, 467)
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
      Me.grdMain.Size = New System.Drawing.Size(932, 467)
      Me.grdMain.TabIndex = 20
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Controls.Add(Me.UiGroupBox1)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(952, 551)
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
      ExplorerBarGroup1.ContainerHeight = 468
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(0, 4)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(948, 500)
      Me.ebrMain.TabIndex = 157
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.cboTipoComp)
      Me.UiGroupBox1.Controls.Add(Me.dtpFechaFin)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 504)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(413, 44)
      Me.UiGroupBox1.TabIndex = 156
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboTipoComp
      '
      Me.cboTipoComp.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoComp.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoComp.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoComp.Location = New System.Drawing.Point(284, 16)
      Me.cboTipoComp.Name = "cboTipoComp"
      Me.cboTipoComp.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoComp.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoComp.TabIndex = 4
      Me.cboTipoComp.Visible = False
      Me.cboTipoComp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'dtpFechaFin
      '
      Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaFin.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaFin.DropDownCalendar.FirstMonth = New Date(2008, 4, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.DropDownCalendar.Name = ""
      Me.dtpFechaFin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFechaFin.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dtpFechaFin.Location = New System.Drawing.Point(68, 16)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaFin.TabIndex = 154
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(12, 20)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(52, 16)
      Me.Label4.TabIndex = 155
      Me.Label4.Text = "Hasta"
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(228, 18)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(52, 15)
      Me.Label5.TabIndex = 161
      Me.Label5.Text = "Tipo"
      Me.Label5.Visible = False
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New2, Me.Edit, Me.Delete, Me.Find1, Me.Print, Me.Exit2, Me.Check, Me.Refrescar, Me.FindFast, Me.Anal, Me.Save, Me.indexar, Me.up, Me.down, Me.Refresh, Me.mnucalcular})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnucalcular1, Me.Separator2, Me.Save1, Me.Separator1, Me.Refresh1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.FloatingSize = New System.Drawing.Size(320, 44)
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(319, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      Me.UiCommandBar1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Refresh1
      '
      Me.Refresh1.Key = "Refresh"
      Me.Refresh1.Name = "Refresh1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
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
      'Refresh
      '
      Me.Refresh.ImageIndex = 11
      Me.Refresh.Key = "Refresh"
      Me.Refresh.Name = "Refresh"
      Me.Refresh.Text = "Actualizar"
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
      Me.TopRebar1.Size = New System.Drawing.Size(952, 28)
      Me.TopRebar1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'mnucalcular
      '
      Me.mnucalcular.ImageIndex = 8
      Me.mnucalcular.Key = "mnucalcular"
      Me.mnucalcular.Name = "mnucalcular"
      Me.mnucalcular.Text = "Calcular"
      '
      'mnucalcular1
      '
      Me.mnucalcular1.Key = "mnucalcular"
      Me.mnucalcular1.Name = "mnucalcular1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'frmCompOrden
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(952, 579)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmCompOrden"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Reordenar Numeración"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
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
         Case "mnucalcular"
            Call grdMainLoad(True)

         Case "Save"
            If DataSave() Then
               mboolChanged = True
               Me.Close()
            End If

         Case "Refresh"
            Call grdMainLoad(False)

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompOrden_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call ComboLoad()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad(False)
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      moComp = New clsComp(clsAppInfo.ConnectString)
      Dim strFechaIni As String
      Dim strFechaFin As String

      If GestionFecha(clsAppInfo.GestionId, strFechaIni, strFechaFin) Then
         dtpFechaFin.Value = strFechaIni
         dtpFechaFin.Value = strFechaFin
      End If

      dtpFechaFin.MaxDate = strFechaFin
      dtpFechaFin.MinDate = strFechaIni

      dtpFechaFin.Value = Date.Now
   End Sub

   Private Function GestionFecha(ByVal GestionId As Long, ByRef strFechaIni As String, ByRef strFechaFin As String) As Boolean
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionFecha = False
      Try
         With oGestion
            .GestionId = GestionId

            If .FindByPK Then
               strFechaIni = .FechaIni
               strFechaFin = .FechaFin
               GestionFecha = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oGestion.Dispose()
      End Try
   End Function

   Private Sub ComboLoad()
      Call cboTipoCompLoad()
   End Sub

   Private Sub cboTipoCompLoad()
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoComp.Items.Clear()
      Try
         With oTipoComp
            .SelectFilter = clsTipoComp.SelectFilters.ListBox
            .OrderByFilter = clsTipoComp.OrderByFilters.TipoCompDes

            If .Open() Then
               Do While .Read()
                  If .TipoCompId > 0 Then
                     oItem = New clsListItem(.TipoCompId, .TipoCompDes)

                     cboTipoComp.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         cboTipoComp.SelectedIndex = ListFindItem(cboTipoComp, clsTipoComp.INGRESO)
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oTipoComp.Dispose()
         oItem = Nothing
      End Try
   End Sub

   'Private Sub grdMainLoad()
   '   Dim lngTipoCompId As Long = 0
   '   Dim lngMesId As Long = 0
   '   Dim boolConFac As Boolean = False
   '   Dim lngCompParaId As Long

   '   Dim boolCompSinFac As Boolean = False
   '   Dim boolCompConFac As Boolean = False
   '   Dim boolNroAutoGestion As Boolean = False
   '   Try
   '      Call moDataSetInit()

   '      With moComp
   '         .SelectFilter = clsComp.SelectFilters.Reordenar
   '         .WhereFilter = clsComp.WhereFilters.Reordenar
   '         .OrderByFilter = clsComp.OrderByFilters.Reordenar
   '         .EmpresaId = clsAppInfo.EmpresaId
   '         .GestionId = clsAppInfo.GestionId
   '         ' .Fecha = ToDate(dtpFechaFin.Text)

   '         If .Open Then
   '            Dim drComprobantes = .DataSet.Tables(.TableName).AsEnumerable.ToList.Where(Function(condicion) condicion.Item("Fecha") <= dtpFechaFin.Value)

   '            For Each oRow In drComprobantes '.DataSet.Tables(.TableName).Rows
   '               boolCompConFac = oRow("ConFac")
   '               boolCompSinFac = oRow("SinFac")
   '               boolNroAutoGestion = oRow("NroAutoGestion")

   '               If oRow("NroAuto") Then '
   '                  If lngTipoCompId <> oRow("TipoCompId") Or boolConFac <> boolCompConFac Or (Not boolNroAutoGestion And lngMesId <> ToDate2(oRow("Fecha")).Month) Then
   '                     If Not oRow("NroAutoGestion") Then 'lngMesId <> ToDate2(oRow("Fecha")).Month And 
   '                        If Not clsAppInfo.MultipleNro And Not boolCompConFac Then
   '                           mlngActual = oRow("NroIniMes")
   '                        Else
   '                           If boolCompConFac Then
   '                              mlngActual = oRow("NroIniFisMes")
   '                           Else
   '                              mlngActual = oRow("NroIniMes")
   '                           End If
   '                        End If

   '                        lngTipoCompId = oRow("TipoCompId")
   '                        lngMesId = ToDate2(oRow("Fecha")).Month
   '                        boolConFac = oRow("ConFac")
   '                     End If
   '                  Else
   '                     If lngTipoCompId <> oRow("TipoCompId") Or boolConFac <> boolCompConFac Then
   '                        If Not clsAppInfo.MultipleNro And Not boolCompConFac Then
   '                           mlngActual = oRow("NroIni")
   '                        Else
   '                           If boolCompConFac Then
   '                              mlngActual = oRow("NroIniFis")
   '                           Else
   '                              mlngActual = oRow("NroIni")
   '                           End If
   '                        End If

   '                        lngTipoCompId = oRow("TipoCompId")
   '                        lngMesId = ToDate2(oRow("Fecha")).Month
   '                        boolConFac = oRow("ConFac")

   '                     End If
   '                     ' End If
   '                     'lngCompParaId = ToLong(oRow("CompParaId"))

   '                  End If

   '                  While ExisteNroComp(lngTipoCompId, mlngActual, boolCompSinFac, boolCompConFac)
   '                     mlngActual += 1
   '                  End While

   '                  moDataTable.Rows.Add(GetRowShow(oRow, mlngActual))
   '                  mlngActual += 1

   '               End If
   '            Next
   '         End If
   '      End With

   '      grdMain.DataSource = moDataTable.DefaultView
   '      grdMain.RetrieveStructure()
   '      Call grdMainInit()

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '   End Try
   'End Sub

   Private Sub grdMainLoad(ByVal boolCalcular As Boolean)
      Dim lngTipoCompId As Long = 0
      Dim lngMesId As Long = 0
      Dim boolConFac As Boolean = False
      Dim lngCompParaId As Long
      mlngActual = 0
      Try
         Call moDataSetInit()

         With moComp
            .SelectFilter = clsComp.SelectFilters.Reordenar
            .WhereFilter = clsComp.WhereFilters.Reordenar
            .OrderByFilter = clsComp.OrderByFilters.Reordenar
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            ' .Fecha = ToDate(dtpFechaFin.Text)

            If .Open Then
               Dim drComprobantes = .DataSet.Tables(.TableName).AsEnumerable.ToList.Where(Function(condicion) condicion.Item("Fecha") <= dtpFechaFin.Value)

               For Each oRow In drComprobantes
                  If boolCalcular Then
                     If oRow("NroAuto") Then

                        If boolConFac <> oRow("ConFac") Then
                           Call getNroIni(mlngActual, oRow)
                        ElseIf lngTipoCompId <> oRow("TipoCompId") Then
                           Call getNroIni(mlngActual, oRow)
                        ElseIf Not oRow("NroAutoGestion") And lngMesId <> ToDate2(oRow("Fecha")).Month Then
                           Call getNroIni(mlngActual, oRow)
                        End If

                        lngTipoCompId = oRow("TipoCompId")
                        lngMesId = ToDate2(oRow("Fecha")).Month
                        boolConFac = oRow("ConFac")

                        While ExisteNroComp(lngTipoCompId, oRow("NroAutoGestion"), mlngActual, lngMesId, oRow("SinFac"), oRow("ConFac"))
                           mlngActual += 1
                        End While

                        moDataTable.Rows.Add(GetRowShow(oRow, mlngActual))
                        mlngActual += 1
                     End If
                  Else
                     moDataTable.Rows.Add(GetRowShow(oRow, mlngActual))
                  End If
               Next
            End If
         End With

         grdMain.DataSource = moDataTable.DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   'boolCompConFac = oRow("ConFac")
   'boolCompSinFac = oRow("SinFac")
   'boolNroAutoGestion = oRow("NroAutoGestion")


   'If lngTipoCompId <> oRow("TipoCompId") Or boolConFac <> boolCompConFac Or (Not boolNroAutoGestion And lngMesId <> ToDate2(oRow("Fecha")).Month) Then
   '   lngTipoCompId = oRow("TipoCompId")
   '   lngMesId = ToDate2(oRow("Fecha")).Month
   '   boolConFac = oRow("ConFac")

   'Else
   '   If lngTipoCompId <> oRow("TipoCompId") Or boolConFac <> boolCompConFac Then
   '      lngTipoCompId = oRow("TipoCompId")
   '      lngMesId = ToDate2(oRow("Fecha")).Month
   '      boolConFac = oRow("ConFac")
   '   End If
   'End If

   Private Function getNroIni(ByRef lngNroIni As Long, ByVal oRow As DataRow) As Boolean
      ' Dim lngTipoCompId As Long = oRow("TipoCompId")
      ' Dim lngMesId As Long = oRow("MesId")
      Dim boolConFac As Boolean = oRow("ConFac")
      Dim boolSinFac As Boolean = oRow("SinFac")
      Dim boolNroAutoGestion As Boolean = oRow("NroAutoGestion")

      If boolNroAutoGestion Then
         If Not clsAppInfo.MultipleNro Then
            lngNroIni = oRow("NroIni")
         Else
            If boolConFac Then
               lngNroIni = oRow("NroIniFis")
            ElseIf boolSinFac Then
               lngNroIni = oRow("NroIni")
            End If
         End If
      Else
         If Not clsAppInfo.MultipleNro Then
            lngNroIni = oRow("NroIniMes")
         Else
            If boolConFac Then
               lngNroIni = oRow("NroIniFisMes")
            ElseIf boolSinFac Then
               lngNroIni = oRow("NroIniMes")
            End If
         End If
      End If
      
   End Function

   Public Function ExisteNroComp(ByVal lngTipoCompId As Long, ByVal boolNroAutoGestion As Boolean, ByVal lngCompNro As Long, ByVal lngMesId As Long, ByVal boolSinFac As Boolean, ByVal boolConFac As Boolean) As Boolean
      ExisteNroComp = False

      Try
         With moComp
            If .DataSet.Tables(.TableName).Rows.Count > 0 Then

               Dim drComprobantes = .DataSet.Tables(.TableName).AsEnumerable.ToList.Where(Function(condicion) condicion.Item("Fecha") > dtpFechaFin.Value _
                                                                                        And condicion.Item("TipoCompId") = lngTipoCompId And condicion.Item("CompNro") = lngCompNro)

               If Not boolNroAutoGestion Then
                  drComprobantes = drComprobantes.Where(Function(condicion) ToDate2(condicion.Item("Fecha")).Month = lngMesId)
               End If

               For Each orow In drComprobantes
                  If orow("SinFac") = boolSinFac And orow("ConFac") = boolConFac Then
                     ExisteNroComp = True
                  End If
               Next
            End If
         End With
      Catch ex As Exception

      End Try
   End Function

   Private Function GetRowShow(ByVal oDataRow As DataRow, ByVal lngCompNroNew As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompId") = oDataRow("CompId")
      oRow("EmpresaId") = oDataRow("EmpresaId")
      oRow("GestionId") = oDataRow("GestionId")
      oRow("Fecha") = oDataRow("Fecha")
      oRow("TipoCompId") = oDataRow("TipoCompId")
      oRow("TipoCompDes") = oDataRow("TipoCompDes")
      oRow("EstadoId") = oDataRow("EstadoId")
      oRow("EstadoDes") = oDataRow("EstadoDes")
      oRow("CompNro") = oDataRow("CompNro")
      oRow("CompNroNew") = lngCompNroNew
      oRow("MonedaId") = oDataRow("MonedaId")
      oRow("MonedaDes") = oDataRow("MonedaDes")
      oRow("TipoCambio") = oDataRow("TipoCambio")
      oRow("DebeBs") = oDataRow("DebeBs")
      oRow("DebeUs") = oDataRow("DebeUs")
      oRow("EntregadoA") = oDataRow("EntregadoA")
      oRow("PorConcepto") = oDataRow("PorConcepto")
      oRow("TipoNotaId") = oDataRow("TipoNotaId")
      oRow("TipoNotaDes") = oDataRow("TipoNotaDes")
      oRow("NotaNro") = oDataRow("NotaNro")
      oRow("SinFac") = oDataRow("SinFac")
      oRow("ConFac") = oDataRow("ConFac")
      oRow("TipoAsientoId") = oDataRow("TipoAsientoId")
      oRow("TipoAsientoDes") = oDataRow("TipoAsientoDes")
      Return oRow
   End Function

   Private Sub frmCompOrden_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompOrden_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

#Region " grid "

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add("Tabla")

      moDataTable.Columns.Add("CompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EmpresaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("GestionId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.DateTime"))
      moDataTable.Columns.Add("TipoCompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCompDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("EstadoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EstadoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompNroNew", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MonedaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MonedaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoCambio", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("EntregadoA", Type.GetType("System.String"))
      moDataTable.Columns.Add("PorConcepto", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoNotaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoNotaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("NotaNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SinFac", Type.GetType("System.Boolean"))
      moDataTable.Columns.Add("ConFac", Type.GetType("System.Boolean"))
      moDataTable.Columns.Add("TipoAsientoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoAsientoDes", Type.GetType("System.String"))
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Comprobantes"

         .RootTable.Columns("CompId").Visible = False
         .RootTable.Columns("EmpresaId").Visible = False
         .RootTable.Columns("GestionId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 100
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo"
         .RootTable.Columns("TipoCompDes").Width = 100
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 80
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNro").Caption = "Número"
         .RootTable.Columns("CompNro").Width = 80
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNroNew").Caption = "Número Nuevo"
         .RootTable.Columns("CompNroNew").Width = 100
         .RootTable.Columns("CompNroNew").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompNroNew").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("MonedaDes").Visible = False

         .RootTable.Columns("TipoCambio").Caption = "Tipo Cambio"
         .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
         .RootTable.Columns("TipoCambio").Width = 100
         .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("TipoCambio").Visible = False

         .RootTable.Columns("DebeBs").Caption = "Monto Bs"
         .RootTable.Columns("DebeBs").FormatString = DecimalMask()
         .RootTable.Columns("DebeBs").Width = 100
         .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("DebeBs").Visible = False

         .RootTable.Columns("DebeUs").Caption = "Monto $us"
         .RootTable.Columns("DebeUs").FormatString = DecimalMask()
         .RootTable.Columns("DebeUs").Width = 100
         .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("DebeUs").Visible = False

         .RootTable.Columns("EntregadoA").Caption = "Detalle 1"
         .RootTable.Columns("EntregadoA").Width = 150
         .RootTable.Columns("EntregadoA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EntregadoA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("EntregadoA").Visible = False

         .RootTable.Columns("PorConcepto").Caption = "Detalle 2"
         .RootTable.Columns("PorConcepto").Width = 150
         .RootTable.Columns("PorConcepto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PorConcepto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("PorConcepto").Visible = False

         .RootTable.Columns("TipoNotaId").Visible = False

         .RootTable.Columns("TipoNotaDes").Caption = "Tipo Nota"
         .RootTable.Columns("TipoNotaDes").Width = 100
         .RootTable.Columns("TipoNotaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoNotaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("TipoNotaDes").Visible = False

         .RootTable.Columns("NotaNro").Caption = "Nro Nota"
         .RootTable.Columns("NotaNro").Width = 100
         .RootTable.Columns("NotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NotaNro").Visible = False

         If clsAppInfo.MultipleNro Then
            .RootTable.Columns("SinFac").Caption = "I"
            .RootTable.Columns("SinFac").Width = 50
            .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ConFac").Caption = "F"
            .RootTable.Columns("ConFac").Width = 50
            .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         Else
            .RootTable.Columns("SinFac").Visible = False
            .RootTable.Columns("ConFac").Visible = False
         End If

         .RootTable.Columns("TipoAsientoId").Visible = False

         .RootTable.Columns("TipoAsientoDes").Caption = "Asiento"
         .RootTable.Columns("TipoAsientoDes").Width = 100
         .RootTable.Columns("TipoAsientoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoAsientoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 12)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 11)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 10)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      FormCheck = True

      If moDataTable.Rows.Count = 0 Then
         strMsg &= "No existe Registros por Actualizar."
         FormCheck = False
      End If

      If moDataTable.AsEnumerable.ToList.Exists(Function(f) f("CompNroNew") = 0) Then
         strMsg &= "Debe realizar el calculo, No se puede guardar Comprobante con Numeracion 0."
         FormCheck = False
      End If

      'For Each row In moDataTable.Rows
      '   If row("Estado") = "Edit" Then
      '      FormCheck = True
      '      Exit For
      '   End If
      'Next

      If Not FormCheck Then
         Throw New Exception(strMsg)
      End If
   End Function

   Private Function DataSave() As Boolean
      DataSave = False
      Dim lngCompId As Long
      Dim lngCompNro As Long
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Try
         If FormCheck() Then
            If MessageBox.Show("Esta seguro de guardar la nueva Numeracion de Comprobantes?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               With oComp
                  For Each oRow In moDataTable.Rows
                     .CompId = oRow("CompId")
                     .CompNro = oRow("CompNroNew")
                     .UpdateFilter = clsComp.UpdateFilters.CompNro
                     Call oComp.UpdateOnly()
                  Next
               End With

               If UpdateCompParaNroActual() Then
                  DataSave = True
               End If
            End If
         End If
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End Try
   End Function

   Private Function UpdateCompParaNroActual() As Boolean
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)
      Dim lngIni As Long = clsTipoComp.INGRESO

      Dim lngCompNroActual As Long = 0
      Dim lngCompNroFisActual As Long = 0
      Try

         While lngIni <= clsTipoComp.TRASPASO
            With oCompPara
               .SelectFilter = clsCompPara.SelectFilters.All
               .WhereFilter = clsCompPara.WhereFilters.TipoCompId
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .TipoCompId = lngIni

               If .Find Then
                  If .NroAutoGestion Then
                     .UpdateFilter = clsCompPara.UpdateFilters.NroActual

                     lngCompNroActual = MaxCompNroActual(lngIni, lngCompNroFisActual)
                     If lngCompNroActual > 0 Then
                        .NroActual = lngCompNroActual
                     End If

                     If lngCompNroFisActual > 0 Then
                        .NroActualFis = lngCompNroFisActual
                     End If

                     If .Update() Then
                        UpdateCompParaNroActual = True
                     End If
                  Else
                     UpdateCompParaNroActual = UpdateCompParaNroActualMes(lngIni)
                  End If
               End If

               lngCompNroActual = 0
               lngCompNroFisActual = 0
               lngIni += 1
            End With
         End While
      Catch exp As Exception
         Throw exp
      Finally
         oCompPara.Dispose()
      End Try
   End Function

   Private Function UpdateCompParaNroActualMes(ByVal lngTipoCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Dim oCompParaMes As New clsCompParaMes(clsAppInfo.ConnectString)
      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.MaxCompNro
            .WhereFilter = clsComp.WhereFilters.MaxCompNro
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoCompId = lngTipoCompId
            .CompId = 1 'Agrupar por Mes

            If .Open Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  With oCompParaMes
                     .SelectFilter = clsCompParaMes.SelectFilters.All
                     .WhereFilter = clsCompParaMes.WhereFilters.MesId
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .TipoCompId = lngTipoCompId
                     .MesId = oRow("MesId")

                     If .Find Then
                        .UpdateFilter = clsCompPara.UpdateFilters.NroActual

                        If oRow("ConFac") Then
                           .NroActualFis = oRow("MaxCompNro")
                        Else
                           .NroActual = oRow("MaxCompNro")
                        End If

                        If .Update() Then
                           UpdateCompParaNroActualMes = True
                        End If
                     End If
                  End With

               Next
            End If
         End With
      Catch exp As Exception
         Throw exp
      Finally
         oComp.Dispose()
         oCompParaMes.Dispose()
      End Try
   End Function

   Private Function MaxCompNroActual(ByVal lngTipoCompId As Long, ByRef lngMaxCompNroFisActual As Long) As Long
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      Try
         With oComp
            .SelectFilter = clsComp.SelectFilters.MaxCompNro
            .WhereFilter = clsComp.WhereFilters.MaxCompNro
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoCompId = lngTipoCompId

            If .Open Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  If oRow("ConFac") Then
                     lngMaxCompNroFisActual = oRow("MaxCompNro")
                  ElseIf Not oRow("ConFac") Then
                     MaxCompNroActual = oRow("MaxCompNro")
                  End If
               Next
            End If
         End With
      Catch exp As Exception
         Throw exp
      Finally
         oComp.Dispose()
      End Try
   End Function
End Class
