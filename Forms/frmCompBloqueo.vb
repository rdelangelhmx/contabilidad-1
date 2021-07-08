Public Class frmCompBloqueo
   Inherits System.Windows.Forms.Form

   Private moComp As clsComp
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompId As Long
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolOrdenarFecha As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX

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

   Property TipoCompId() As Long
      Get
         Return mlngTipoCompId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCompId = Value
      End Set
   End Property

   Property FechaIni() As String
      Get
         Return mstrFechaIni
      End Get

      Set(ByVal Value As String)
         mstrFechaIni = Value
      End Set
   End Property

   Property FechaFin() As String
      Get
         Return mstrFechaFin
      End Get

      Set(ByVal Value As String)
         mstrFechaFin = Value
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
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents Bloquear As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Bloquear1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Desbloquear As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Desbloquear1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckTrue As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckTrue1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckFalse As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckFalse1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompBloqueo))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Bloquear1 = New Janus.Windows.UI.CommandBars.UICommand("Bloquear")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Desbloquear1 = New Janus.Windows.UI.CommandBars.UICommand("Desbloquear")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckTrue1 = New Janus.Windows.UI.CommandBars.UICommand("CheckTrue")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckFalse1 = New Janus.Windows.UI.CommandBars.UICommand("CheckFalse")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Bloquear = New Janus.Windows.UI.CommandBars.UICommand("Bloquear")
      Me.Desbloquear = New Janus.Windows.UI.CommandBars.UICommand("Desbloquear")
      Me.CheckTrue = New Janus.Windows.UI.CommandBars.UICommand("CheckTrue")
      Me.CheckFalse = New Janus.Windows.UI.CommandBars.UICommand("CheckFalse")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
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
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow})
      '
      'mnuShow
      '
      Me.mnuShow.Index = 0
      Me.mnuShow.Text = "Consultar"
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
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ViewAll, Me.Print, Me.Exit2, Me.Refrescar, Me.Bloquear, Me.Desbloquear, Me.CheckTrue, Me.CheckFalse})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("14565a15-ea74-408e-b698-fb1d6c9d5b6b")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Bloquear1, Me.Separator2, Me.Desbloquear1, Me.Separator3, Me.CheckTrue1, Me.Separator5, Me.CheckFalse1, Me.Separator1, Me.Refrescar1, Me.Separator7, Me.ViewAll1, Me.Separator4, Me.Print1, Me.Separator6, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(509, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Bloquear1
      '
      Me.Bloquear1.Key = "Bloquear"
      Me.Bloquear1.Name = "Bloquear1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Desbloquear1
      '
      Me.Desbloquear1.Key = "Desbloquear"
      Me.Desbloquear1.Name = "Desbloquear1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'CheckTrue1
      '
      Me.CheckTrue1.Key = "CheckTrue"
      Me.CheckTrue1.Name = "CheckTrue1"
      Me.CheckTrue1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'CheckFalse1
      '
      Me.CheckFalse1.Key = "CheckFalse"
      Me.CheckFalse1.Name = "CheckFalse1"
      Me.CheckFalse1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
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
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 5
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
      '
      'Print
      '
      Me.Print.ImageIndex = 6
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 7
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 4
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
      '
      'Bloquear
      '
      Me.Bloquear.ImageIndex = 0
      Me.Bloquear.Key = "Bloquear"
      Me.Bloquear.Name = "Bloquear"
      Me.Bloquear.Text = "Bloquear"
      '
      'Desbloquear
      '
      Me.Desbloquear.ImageIndex = 1
      Me.Desbloquear.Key = "Desbloquear"
      Me.Desbloquear.Name = "Desbloquear"
      Me.Desbloquear.Text = "Desbloquear"
      '
      'CheckTrue
      '
      Me.CheckTrue.ImageIndex = 2
      Me.CheckTrue.Key = "CheckTrue"
      Me.CheckTrue.Name = "CheckTrue"
      Me.CheckTrue.Text = "Seleccionar Todos"
      '
      'CheckFalse
      '
      Me.CheckFalse.ImageIndex = 3
      Me.CheckFalse.Key = "CheckFalse"
      Me.CheckFalse.Name = "CheckFalse"
      Me.CheckFalse.Text = "Quitar Selección"
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
      'frmCompBloqueo
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmCompBloqueo"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Bloqueo / Desbloqueo de Comprobantes"
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
         Case "Bloquear"
            If MessageBox.Show("Esta Seguro que Quiere Bloquear los Comprobantes", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               If CompBloqueoLoad(10) Then
                  Call grdMainLoad()
               End If
            End If

         Case "Desbloquear"
            If MessageBox.Show("Esta Seguro que Quiere Desbloquear los Comprobantes", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               If CompBloqueoLoad(11) Then
                  Call grdMainLoad()
               End If
            End If

         Case "CheckTrue"
            Call grdMainCheck(True)

         Case "CheckFalse"
            Call grdMainCheck(False)

         Case "ViewAll"
            Call DataViewAll()

         Case "Refrescar"
            Call grdMainLoad()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompBloqueo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompBloqueo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad()
      Try
         With moComp
            .SelectFilter = clsComp.SelectFilters.GridCheck
            .WhereFilter = clsComp.WhereFilters.GridFechaEstado

            If mboolOrdenarFecha Then
               .OrderByFilter = clsComp.OrderByFilters.GridFecha
            Else
               .OrderByFilter = clsComp.OrderByFilters.Grid
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .TipoCompId = mlngTipoCompId
            .Fecha = mstrFechaIni
            .EntregadoA = mstrFechaFin

            If .Open() Then
               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataShow()
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("CompId")) > 0) Then
            With oComp
               .CompId = ToLong(grdMain.GetValue("CompId"))

               If .FindByPK Then
                  Dim frm As New frmCompEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oComp

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Sub

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

   Private Function CompBloqueoLoad(ByVal lngEstadoId As Long) As Boolean
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
         If oRow.Cells("EstadoId").Value <> lngEstadoId Then
            If UpdateComp(oRow.Cells("CompId").Value, lngEstadoId) Then
               CompBloqueoLoad = True
            End If
         End If
      Next
   End Function

   Private Sub CloneVM(ByRef oComp As clsComp)
      If clsAppInfo.RegistrarBitacora Then

         With oComp.VMNew
            .CompId = oComp.CompId
            .CompNro = oComp.CompNro
            .TipoCompId = oComp.TipoCompId
            .EstadoId = oComp.EstadoId

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Function UpdateComp(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      UpdateComp = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               .Fecha = ToDate(.Fecha)
               .EstadoId = lngEstadoId

               Call CloneVM(oComp)
               If .Update Then
                  If UpdateCompDet(lngCompId, lngEstadoId) Then
                     If UpdateFactura(lngCompId, lngEstadoId) Then
                        If UpdateCompCheque(lngCompId, lngEstadoId) Then
                           If UpdateCompPlanAdd(lngCompId, lngEstadoId) Then
                              If UpdateCompCentroCostoDet(lngCompId, lngEstadoId) Then
                                 If UpdateCompPlanEEFF(lngCompId, lngEstadoId) Then
                                    UpdateComp = True
                                 End If
                              End If
                           End If
                        End If
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function UpdateCompDet(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      UpdateCompDet = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     UpdateCompDet = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function UpdateFactura(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      UpdateFactura = False

      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .FacturaFecha = ToDate(.FacturaFecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     UpdateFactura = True
                  End If

                  .MoveNext()
               Loop
            Else
               UpdateFactura = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function UpdateCompCheque(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)

      UpdateCompCheque = False

      Try
         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .FechaCob = ToDate(.FechaCob)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     UpdateCompCheque = True
                  End If
                  .MoveNext()
               Loop
            Else
               UpdateCompCheque = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Function UpdateCompPlanAdd(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      UpdateCompPlanAdd = False

      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.All
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     UpdateCompPlanAdd = True
                  End If

                  .MoveNext()
               Loop
            Else
               UpdateCompPlanAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function UpdateCompCentroCostoDet(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      UpdateCompCentroCostoDet = False

      Try
         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     UpdateCompCentroCostoDet = True
                  End If

                  .MoveNext()
               Loop
            Else
               UpdateCompCentroCostoDet = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function UpdateCompPlanEEFF(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

      UpdateCompPlanEEFF = False

      Try
         With oCompPlanEEFF
            .SelectFilter = clsCompPlanEEFF.SelectFilters.All
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     UpdateCompPlanEEFF = True
                  End If

                  .MoveNext()
               Loop
            Else
               UpdateCompPlanEEFF = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanEEFF.Dispose()

      End Try
   End Function

   Private Sub grdMainCheck(ByVal boolValue As Boolean)
      Dim oRow As DataRowView

      grdMain.MoveLast()
      grdMain.MoveFirst()

      With moComp
         For Each oRow In .DataSet.Tables(.TableName).DefaultView
            oRow("Sel") = boolValue
         Next
      End With
   End Sub

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
      Dim rpt As New rptComp

      rpt.DataSource = GetDataView(moComp.DataSet.Tables(moComp.TableName))

      rpt.lblTitle.Text = "Listado de Comprobantes"
      rpt.Document.Name = "Listado de Comprobantes"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moComp = New clsComp(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Comprobantes"
         .ContextMenu = mnuMain

         If Not grdMainLayoutLoad(System.AppDomain.CurrentDomain.BaseDirectory() + "Layout\") Then
            .RootTable.Columns("Sel").Width = 50
            .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Sel").ActAsSelector = True

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

            .RootTable.Columns("CompNro").Caption = "Número"
            .RootTable.Columns("CompNro").Width = 100
            .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("MonedaId").Visible = False

            .RootTable.Columns("MonedaDes").Caption = "Moneda"
            .RootTable.Columns("MonedaDes").Width = 100
            .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("TipoCambio").Caption = "Tipo Cambio"
            .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
            .RootTable.Columns("TipoCambio").Width = 100
            .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeBs").Caption = "Monto Bs"
            .RootTable.Columns("DebeBs").FormatString = DecimalMask()
            .RootTable.Columns("DebeBs").Width = 100
            .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeUs").Caption = "Monto $us"
            .RootTable.Columns("DebeUs").FormatString = DecimalMask()
            .RootTable.Columns("DebeUs").Width = 100
            .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("EntregadoA").Caption = "Detalle 1"
            .RootTable.Columns("EntregadoA").Width = 100
            .RootTable.Columns("EntregadoA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("EntregadoA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("PorConcepto").Caption = "Detalle 2"
            .RootTable.Columns("PorConcepto").Width = 100
            .RootTable.Columns("PorConcepto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("PorConcepto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("TipoNotaId").Visible = False

            .RootTable.Columns("TipoNotaDes").Caption = "Tipo Nota"
            .RootTable.Columns("TipoNotaDes").Width = 100
            .RootTable.Columns("TipoNotaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("TipoNotaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("NotaNro").Caption = "Nro Nota"
            .RootTable.Columns("NotaNro").Width = 100
            .RootTable.Columns("NotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("NotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("EstadoId").Visible = False

            .RootTable.Columns("EstadoDes").Caption = "Estado"
            .RootTable.Columns("EstadoDes").Width = 100
            .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         End If
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

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Call DataShow()
   End Sub

   Private Sub grdMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
      If e.Button = MouseButtons.Right Then
         mnuShow.Enabled = True
      End If
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call DataShow()
   End Sub

   Private Function grdMainLayoutLoad(ByVal strPath As String) As Boolean
      'grdMainLayoutLoad = False

      'If Dir(strPath + Me.Name) <> "" Then
      '   grdMain.LoadLayout(strPath + Me.Name)
      '   Return True
      'End If
   End Function

   Private Function grdMainLayoutSave(ByVal strPath As String) As Boolean
      'grdMainLayoutSave = False

      'If grdMain.GroupedColumns.Count = 0 Then
      '   If Dir(strPath, FileAttribute.Directory) <> "" Then
      '      Call DataViewAll()
      '      grdMain.SaveLayout(strPath + "\" + Me.Name)
      '      Return True
      '   End If
      'End If
   End Function

   Private Sub frmCompBloqueo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompBloqueo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call grdMainLayoutSave(System.AppDomain.CurrentDomain.BaseDirectory() + "Layout")
      moComp.Dispose()
      Call ClearMemory()
   End Sub

End Class
