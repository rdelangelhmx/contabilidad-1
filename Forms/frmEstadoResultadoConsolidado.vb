Public Class frmEstadoResultadoConsolidado
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan

   Private moListaTipoAsiento As New Queue
   Private moDataTableEmpresas As New DataTable
   Private moDataTableErrores As DataTable
   Private mstrTipoAsientoId As String
   Private mstrCentroCostoCod As String
   Private mstrCentroCostoDes As String
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long
   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mdatFechaIniInt As Date
   Private mdatFechaFinInt As Date
   Private mdatFechaIni As Date
   Private mdatFechaFin As Date
   Private mlngNivel As Long
   Private mboolIncluirPlanAdd As Boolean
   Private mboolTotalizar As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean
   Private mboolIntervaloFecha As Boolean 'Solo se ocupa en LibroMayor
   Private mboolSaldoGestion As Boolean
   Private mlngpos As Long
   Private moRowEmpresa As DataRow
   Private mstrConnectString As String
   Private mboolConsolidar As Boolean
   Private mdatFechaIniOri As Date
   Private mdatFechaFinOri As Date
   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moDataTableAux As DataTable

   Private mdecHaberBs As Decimal
   Private mdecDebeBs As Decimal
   Private mdecHaberUs As Decimal
   Friend WithEvents VerListadoObs1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents VerListadoObs As Janus.Windows.UI.CommandBars.UICommand
   Private mdecDebeUs As Decimal

   Public Enum Tipo
      Cuenta = 1
      Analitico = 2
   End Enum

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

   Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngMonedaId = Value
      End Set
   End Property

   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   Property CentroCostoCod() As String
      Get
         Return mstrCentroCostoCod
      End Get

      Set(ByVal Value As String)
         mstrCentroCostoCod = Value
      End Set
   End Property

   Property CentroCostoDes() As String
      Get
         Return mstrCentroCostoDes
      End Get

      Set(ByVal Value As String)
         mstrCentroCostoDes = Value
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

   Property IntervaloFecha() As Boolean
      Get
         Return mboolIntervaloFecha
      End Get

      Set(ByVal Value As Boolean)
         mboolIntervaloFecha = Value
      End Set
   End Property

   Property FechaIni() As Date
      Get
         Return mdatFechaIniInt
      End Get

      Set(ByVal Value As Date)
         mdatFechaIniInt = Value
      End Set
   End Property

   Property FechaFin() As Date
      Get
         Return mdatFechaFinInt
      End Get

      Set(ByVal Value As Date)
         mdatFechaFinInt = Value
      End Set
   End Property

   Property FechaIniGestion() As Date
      Get
         Return mdatFechaIni
      End Get

      Set(ByVal Value As Date)
         mdatFechaIni = Value
      End Set
   End Property

   Property FechaFinGestion() As Date
      Get
         Return mdatFechaFin
      End Get

      Set(ByVal Value As Date)
         mdatFechaFin = Value
      End Set
   End Property

   Property Nivel() As Long
      Get
         Return mlngNivel
      End Get

      Set(ByVal Value As Long)
         mlngNivel = Value
      End Set
   End Property

   Property Totalizar() As Boolean
      Get
         Return mboolTotalizar
      End Get

      Set(ByVal Value As Boolean)
         mboolTotalizar = Value
      End Set
   End Property

   Property IncluirPlanAdd() As Boolean
      Get
         Return mboolIncluirPlanAdd
      End Get

      Set(ByVal Value As Boolean)
         mboolIncluirPlanAdd = Value
      End Set
   End Property

   Property SaldoGestion() As Boolean
      Get
         Return mboolSaldoGestion
      End Get

      Set(ByVal Value As Boolean)
         mboolSaldoGestion = Value
      End Set
   End Property

   Property SinFac() As Boolean
      Get
         Return mboolSinFac
      End Get

      Set(ByVal Value As Boolean)
         mboolSinFac = Value
      End Set
   End Property

   Property ConFac() As Boolean
      Get
         Return mboolConFac
      End Get

      Set(ByVal Value As Boolean)
         mboolConFac = Value
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

   Property ListaEmpresas() As DataTable
      Get
         Return moDataTableEmpresas
      End Get

      Set(ByVal Value As DataTable)
         moDataTableEmpresas = Value
      End Set
   End Property

   Property ListaErrores() As DataTable
      Get
         Return moDataTableErrores
      End Get

      Set(ByVal Value As DataTable)
         moDataTableErrores = Value
      End Set
   End Property

   Property Consolidar() As Boolean
      Get
         Return mboolConsolidar
      End Get

      Set(ByVal Value As Boolean)
         mboolConsolidar = Value
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
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoResultadoConsolidado))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.VerListadoObs1 = New Janus.Windows.UI.CommandBars.UICommand("VerListadoObs")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.VerListadoObs = New Janus.Windows.UI.CommandBars.UICommand("VerListadoObs")
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
      Me.uiBackground.TabIndex = 6
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
      Me.ilsMain.Images.SetKeyName(7, "checklist_16.png")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2, Me.VerListadoObs})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("79b9b60f-728a-409f-9d5a-a4700487a55f")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.VerListadoObs1, Me.Separator4, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(352, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
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
      'VerListadoObs1
      '
      Me.VerListadoObs1.Key = "VerListadoObs"
      Me.VerListadoObs1.Name = "VerListadoObs1"
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
      Me.Book.Visible = Janus.Windows.UI.InheritableBoolean.[False]
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
      'VerListadoObs
      '
      Me.VerListadoObs.ImageIndex = 7
      Me.VerListadoObs.Key = "VerListadoObs"
      Me.VerListadoObs.Name = "VerListadoObs"
      Me.VerListadoObs.Text = "Observaciones"
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
      'frmEstadoResultadoConsolidado
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmEstadoResultadoConsolidado"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Estado de Resultados Consolidado"
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
         Case "Book"
            Call frmLibroMayorLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "VerListadoObs"
            Call ListadoObsShow()

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
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moPlan = New clsPlan(clsAppInfo.ConnectString)

      mdatFechaIniOri = mdatFechaIniInt
      mdatFechaFinOri = mdatFechaFinInt

      If mboolSaldoGestion And mlngMonedaId = 4 And mboolTotalizar Then
         Print1.Visible = Janus.Windows.UI.InheritableBoolean.False
      End If
   End Sub

   Private Sub frmLibroMayorLoad()
      Dim oLista As New Queue

      If grdMain.GetRow.Selected Then
         If IsNumeric(grdMain.CurrentColumn.Tag) Then

            Dim lngPlanId As Long
            Dim lngEmpresapos As Long = ToLong(grdMain.CurrentColumn.Tag)

            If (ToLong(grdMain.GetValue("PlanId" & lngEmpresapos)) > 0) And (ToBoolean(grdMain.GetValue("EsAna"))) Then
               oLista.Enqueue(ToLong(grdMain.GetValue("PlanId" & lngEmpresapos)))
               lngPlanId = ToLong(grdMain.GetValue("PlanId" & lngEmpresapos))
            End If

            mlngEmpresaId = moDataTableEmpresas.Rows.Item(lngEmpresapos)("EmpresaId")
            mlngGestionId = moDataTableEmpresas.Rows.Item(lngEmpresapos)("GestionId")
            mstrConnectString = moDataTableEmpresas.Rows.Item(lngEmpresapos)("ConnectString")

            Dim lngCentroCostoId = 0
            If Not String.IsNullOrEmpty(mstrCentroCostoCod) Then
               lngCentroCostoId = CentroCostoIdFind(mstrCentroCostoCod, mlngEmpresaId, mstrConnectString)
            End If

            If lngCentroCostoId = 0 Then

               If oLista.Count Then
                  Dim frm As New frmLibroMayorEmpresa

                  With frm
                     .EmpresaId = mlngEmpresaId
                     .GestionId = mlngGestionId
                     Call FechasEmpresaLoad(mlngGestionId)
                     .MonedaId = mlngMonedaId
                     .SaldoAnterior = False
                     .Cuenta = True
                     .SinMovimiento = False
                     .IntervaloFecha = mboolIntervaloFecha
                     Dim strFechaIniInt As String = ""
                     Dim strFechaFinInt As String = ""
                     .FechaIni = ToDate(mdatFechaIniInt)
                     .FechaFin = ToDate(mdatFechaFinInt)
                     .OrdenarFecha = True
                     .Lista = oLista
                     .SinFac = mboolSinFac
                     .ConFac = mboolConFac
                     .ListaTipoAsiento = moListaTipoAsiento
                     .ConnectString = mstrConnectString
                     .Text = .Text & "  " & moDataTableEmpresas.Rows.Item(lngEmpresapos)("EmpresaDes") & "  Gestion " & moDataTableEmpresas.Rows.Item(lngEmpresapos)("Gestion")
                     Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & PlanDesFind(lngPlanId))
                     frm.ShowDialog()
                     If frm.Changed Then
                        Call grdMainLoad()
                        Call grdMainFindRow(lngPlanId)
                     End If

                     frm.Dispose()
                  End With
               Else
                  MessageBox.Show("Cuenta Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               Dim listaCC As New Queue
               listaCC.Enqueue(lngCentroCostoId)

               If oLista.Count Then
                  Dim frm As New frmLibroCentroCostoEmpresas

                  With frm
                     .EmpresaId = mlngEmpresaId
                     .GestionId = mlngGestionId
                     .MonedaId = mlngMonedaId
                     Call FechasEmpresaLoad(mlngGestionId)

                     '.PlanId = lngPlanId
                     .SaldoAnterior = False
                     .Cuenta = True
                     .IncluirDetalle = True
                     .IntervaloFecha = True
                     .FechaIni = ToDate(mdatFechaIni)
                     .FechaFin = ToDate(mdatFechaFin)
                     .OrdenarFecha = True
                     .SinFac = mboolSinFac
                     .ConFac = mboolConFac

                     .Lista = listaCC
                     .ListaPlan = oLista
                     .ListaTipoAsiento = moListaTipoAsiento

                     .ConnectString = mstrConnectString
                     .Text = .Text & "  " & moDataTableEmpresas.Rows.Item(lngEmpresapos)("EmpresaDes") & "  Gestion " & moDataTableEmpresas.Rows.Item(lngEmpresapos)("Gestion")

                     .MdiParent = Me.MdiParent
                     .Show()
                     Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & PlanDesFind(ToLong(grdMain.GetValue("PlanId"))))
                  End With
               Else
                  MessageBox.Show("Cuenta Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         End If
      End If
   End Sub

   Private Sub ListadoObsShow()
      If moDataTableErrores.Rows.Count > 0 Then
         Dim frm As New frmPlanCuentaError
         frm.DataTableObj = moDataTableErrores
         frm.MdiParent = Me.MdiParent
         frm.Show()
      Else
         MessageBox.Show("El reporte se realizo satisfactoriamente, " & vbCrLf & "No se encontraron observaciones.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
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

   Public Function Gestiones() As String
      Dim strGestiones As String = "("
      For Each orow In moDataTableEmpresas.Rows
         strGestiones &= orow("Gestion") & ", "
      Next

      strGestiones = strGestiones.Substring(0, strGestiones.Length - 2)

      Return strGestiones & ")"
   End Function

   Private Sub PrintReport()
      Dim rpt As New rptEstadoResultadoConsolidado
      Dim strMonedaSigla As String

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moPlan.TableName))

      rpt.lblTitle.Text = "Estado de Resultados Consolidado"
      rpt.Document.Name = "Estado de Resultados Consolidado"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniInt) ' ConvertDMY(mstrFechaIni)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinInt) 'ConvertDMY(mstrFechaFin)
      rpt.txtGestiones.Text = Gestiones()
      rpt.txtCentroCosto.Text = If(String.IsNullOrEmpty(mstrCentroCostoCod), "(Todos)", mstrCentroCostoDes)

      If mlngMonedaId = 1 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId, strMonedaSigla)
         rpt.txtPlanDes.Width = 5

         If mboolSaldoGestion Then
            rpt.lblCol02.Text = "General " & strMonedaSigla
            rpt.txtCol02.DataField = "GralBs"

            rpt.lblCol03.Text = "Detalle " & strMonedaSigla
            rpt.txtCol03.DataField = "GralBsDet"

            rpt.lblCol04.Text = "Saldo " & strMonedaSigla & " Ges."
            rpt.txtCol04.DataField = "GralBsGes"

            rpt.txtCol01.Visible = False

            If Not mboolTotalizar Then
               rpt.lblCol02.Text = ""
               rpt.txtCol02.Visible = False
            End If
         Else
            rpt.lblCol03.Text = "General " & strMonedaSigla
            rpt.txtCol03.DataField = "GralBs"

            rpt.lblCol04.Text = "Detalle " & strMonedaSigla
            rpt.txtCol04.DataField = "GralBsDet"

            rpt.txtCol01.Visible = False
            rpt.txtCol02.Visible = False

            If Not mboolTotalizar Then
               rpt.lblCol03.Text = ""
               rpt.txtCol03.Visible = False
            End If
         End If
      ElseIf mlngMonedaId = 2 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId, strMonedaSigla)
         rpt.txtPlanDes.Width = 5

         If mboolSaldoGestion Then
            rpt.lblCol02.Text = "General " & strMonedaSigla
            rpt.txtCol02.DataField = "GralUs"

            rpt.lblCol03.Text = "Detalle " & strMonedaSigla
            rpt.txtCol03.DataField = "GralUSDet"

            rpt.lblCol04.Text = "Saldo " & strMonedaSigla & " Ges."
            rpt.txtCol04.DataField = "GralUsGes"

            rpt.txtCol01.Visible = False

            If Not mboolTotalizar Then
               rpt.lblCol02.Text = ""
               rpt.txtCol02.Visible = False
            End If
         Else
            rpt.lblCol03.Text = "General " & strMonedaSigla
            rpt.txtCol03.DataField = "GralUs"

            rpt.lblCol04.Text = "Detalle " & strMonedaSigla
            rpt.txtCol04.DataField = "GralUsDet"

            rpt.txtCol01.Visible = False
            rpt.txtCol02.Visible = False

            If Not mboolTotalizar Then
               rpt.lblCol03.Text = ""
               rpt.txtCol03.Visible = False
            End If
         End If

      ElseIf mlngMonedaId = 4 Then
         If Not mboolSaldoGestion Then
            rpt.txtMoneda.Text = MonedaDesFind(1, strMonedaSigla)

            rpt.lblCol01.Text = "General " & strMonedaSigla
            rpt.txtCol01.DataField = "GralBs"

            rpt.lblCol02.Text = "Detalle " & strMonedaSigla
            rpt.txtCol02.DataField = "GralBsDet"

            rpt.txtMoneda.Text &= " / " & MonedaDesFind(2, strMonedaSigla)

            rpt.lblCol03.Text = "General " & strMonedaSigla
            rpt.txtCol03.DataField = "GralUs"

            rpt.lblCol04.Text = "Detalle " & strMonedaSigla
            rpt.txtCol04.DataField = "GralUsDet"

            If Not mboolTotalizar Then
               rpt.lblCol03.Text = rpt.lblCol02.Text
               rpt.txtCol03.DataField = "GralBsDet"
               rpt.lblCol04.Text = rpt.lblCol04.Text
               rpt.txtCol04.DataField = "GralUsDet"

               rpt.lblCol01.Text = ""
               rpt.txtCol01.Visible = False
               rpt.lblCol02.Text = ""
               rpt.txtCol02.Visible = False
            End If
         Else
            rpt.txtMoneda.Text = MonedaDesFind(1, strMonedaSigla)

            rpt.lblCol01.Text = "Detalle " & strMonedaSigla
            rpt.txtCol01.DataField = "GralBsDet"

            rpt.lblCol02.Text = "Saldo " & strMonedaSigla & " Ges"
            rpt.txtCol02.DataField = "GralBsGes"

            rpt.txtMoneda.Text &= " / " & MonedaDesFind(2, strMonedaSigla)

            rpt.lblCol03.Text = "Detalle " & strMonedaSigla
            rpt.txtCol03.DataField = "GralUsDet"

            rpt.lblCol04.Text = "Saldo " & strMonedaSigla & " Ges"
            rpt.txtCol04.DataField = "GralUsGes"
         End If
      End If

      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniInt).Substring(0, 5)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinInt).Substring(0, 5)

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub


   Private Sub frmEstadoResultadoConsolidado_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
   End Sub

#Region " Otros Metodos "
   Private Function MonedaDesFind(ByVal lngMonedaId As Long, ByRef strMonedaSigla As String) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      MonedaDesFind = ""

      Try
         With oMoneda
            .MonedaId = lngMonedaId

            If .FindByPK Then
               strMonedaSigla = .MonedaSigla
               MonedaDesFind = .MonedaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMoneda.Dispose()

      End Try
   End Function

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

   Private Function CentroCostoDesFind(ByVal lngCentroCostoId As Long) As String
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)

      CentroCostoDesFind = ""

      Try
         With oCentroCosto
            .CentroCostoId = lngCentroCostoId

            If .FindByPK Then
               CentroCostoDesFind = .CentroCostoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()

      End Try
   End Function
#End Region

#Region " ESTADO RESULTADO "

#Region " DataSet-Estado Resultado "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")

      moDataTable = moDataSet.Tables.Add(moPlan.TableName)
      moDataTable.Columns.Add("Id", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("EsAna", Type.GetType("System.Byte"))
      moDataTable.Columns.Add("SucCCOID", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoGrupoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Nivel", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanPadreId", Type.GetType("System.Int32"))

      moDataTable.Columns.Add("GralBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralBsDet", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralBsGes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUsDet", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUsGes", Type.GetType("System.Decimal"))

      moDataTable.Columns.Add("GralBsaux", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralBsDetaux", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralBsGesaux", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUsaux", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUsDetaux", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUsGesaux", Type.GetType("System.Decimal"))

      moDataTable.Columns.Add("SW", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Del", Type.GetType("System.Int32"))

      moDataTableAux = moDataSet.Tables.Add(moPlan.TableName & "Aux")
      moDataTableAux.Columns.Add("GralBs", Type.GetType("System.Decimal"))
      moDataTableAux.Columns.Add("GralUs", Type.GetType("System.Decimal"))
      moDataTableAux.Columns.Add("PlanPadreId", Type.GetType("System.Int32"))
   End Sub

   Private Sub GetRowNull()
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      oRow("Nivel") = mlngNivel
      moDataTable.Rows.Add(oRow)
   End Sub
#End Region

#Region " Metodo-Estado Resultado "

   Private Function LoadCompDet(ByVal lngPlanId As Long, ByVal bytWhere As Byte) As DataTable
      Dim oCompDet As New clsCompDet(mstrConnectString)

      LoadCompDet = Nothing
      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.AllComp
            .WhereFilter = bytWhere
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .CentroCostoId = mlngCentroCostoId
            .SucursalId = mlngSucursalId
            .Fecha = ToDate(mdatFechaIni)
            .CompDetDes = ToDate(mdatFechaFin)
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId

            If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               LoadCompDet = .DataSet.Tables(0)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompDet.Dispose()
      End Try
   End Function

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("PlanId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Id"), Janus.Windows.GridEX.ConditionOperator.GreaterThan, 0)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EsAna"), Janus.Windows.GridEX.ConditionOperator.Equal, False)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " Grid-Balance "

   Public Sub FechasEmpresaLoad(ByVal lngGestionId As Long)
      Dim oGestion As New clsGestion(mstrConnectString)
      Dim lngDiaIni As Long = mdatFechaIniOri.Day
      Dim lngDiaFin As Long = mdatFechaFinOri.Day
      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               Dim datFechaIniGes As Date = .FechaIni


               If mdatFechaIniOri.Day = 29 And mdatFechaIniOri.Month = 2 Then
                  Dim lngyear = datFechaIniGes.Year + Math.Abs(mdatFechaIni.Year - mdatFechaIniInt.Year)
                  If Not Date.IsLeapYear(lngyear) Then
                     lngDiaIni = mdatFechaIniOri.Day - 1
                  Else
                     lngDiaIni = mdatFechaIniOri.Day
                  End If
               End If


               If mdatFechaFinOri.Day = 29 And mdatFechaFinOri.Month = 2 Then
                  Dim lngyear = datFechaIniGes.Year + Math.Abs(mdatFechaIni.Year - mdatFechaFinInt.Year)
                  If Not Date.IsLeapYear(lngyear) Then
                     lngDiaFin = mdatFechaFinOri.Day - 1
                  Else
                     lngDiaFin = mdatFechaFinOri.Day
                  End If
               End If

               Dim datFechaIniAux = New Date(datFechaIniGes.Year + Math.Abs(mdatFechaIni.Year - mdatFechaIniInt.Year), mdatFechaIniInt.Month, lngDiaIni)
               Dim datFechaFinAux = New Date(datFechaIniGes.Year + Math.Abs(mdatFechaIni.Year - mdatFechaFinInt.Year), mdatFechaFinInt.Month, lngDiaFin)
               mdatFechaIniInt = datFechaIniAux
               mdatFechaFinInt = datFechaFinAux
               mdatFechaIni = .FechaIni
               mdatFechaFin = .FechaFin
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oGestion.Dispose()
      End Try
   End Sub

   Private Function CentroCostoIdFind(ByVal strCentroCostoCod As String, ByVal lngEmpresaId As Long, ByVal strConnectString As String) As Long
      Dim oCentroCosto As New clsCentroCosto(strConnectString)
      CentroCostoIdFind = -1

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.All
            .WhereFilter = clsCentroCosto.WhereFilters.CentroCostoCod
            .EmpresaId = lngEmpresaId
            .CentroCostoCod = strCentroCostoCod

            If .Find Then
               CentroCostoIdFind = .CentroCostoId
            End If
         End With
      Catch ex As Exception
         Throw ex
      Finally
         oCentroCosto.Dispose()
      End Try
   End Function

   Private Sub grdMainLoad()
      Call moDataSetInit()

      If mboolIncluirPlanAdd Then
         moDataTable.Columns.Add("PlanCtaAux", Type.GetType("System.String"))
         moDataTable.Columns.Add("TieneAnaAdd", Type.GetType("System.Boolean"))
      End If

      mstrTipoAsientoId = TipoAsientoIdListaLoad()

      'generar estado de resultado por empresa
      For Me.mlngpos = 0 To moDataTableEmpresas.Rows.Count - 1

         moDataTableAux.Rows.Clear()
         mstrConnectString = moDataTableEmpresas.Rows.Item(mlngpos)("ConnectString")
         mlngEmpresaId = moDataTableEmpresas.Rows.Item(mlngpos)("EmpresaId")
         mlngGestionId = moDataTableEmpresas.Rows.Item(mlngpos)("GestionId")

         mlngCentroCostoId = 0
         If Not String.IsNullOrEmpty(mstrCentroCostoCod) Then
            mlngCentroCostoId = CentroCostoIdFind(mstrCentroCostoCod, mlngEmpresaId, mstrConnectString)
         End If

         Call FechasEmpresaLoad(mlngGestionId)
         Call grdMainLoadEmpresas(0, "")

         For Each oRow In moDataTable.Rows
            oRow("SW") = 0
            oRow("PlanId") = 0
            oRow("PlanPadreId") = 0

            If ToLong(oRow("Del")) = 1 Then
               If ToBoolean(oRow("EsAna")) Then
                  oRow("GralBsDet") = ToDecimal(oRow("GralBsDet")) + ToDecimal(oRow("GralBsDetaux"))
                  oRow("GralUsDet") = ToDecimal(oRow("GralUsDet")) + ToDecimal(oRow("GralUsDetaux"))
               Else
                  oRow("GralBs") = ToDecimal(oRow("GralBs")) + ToDecimal(oRow("GralBsaux"))
                  oRow("GralUs") = ToDecimal(oRow("GralUs")) + ToDecimal(oRow("GralUsaux"))
               End If
               oRow("GralBsGes") = ToDecimal(oRow("GralBsGes")) + ToDecimal(oRow("GralBsGesaux"))
               oRow("GralUsGes") = ToDecimal(oRow("GralUsGes")) + ToDecimal(oRow("GralUsGesaux"))
            End If

            If ToLong(oRow("Id")) = 4 Or ToLong(oRow("Id")) = 5 Or ToLong(oRow("Id")) = 6 Then 'Sum cuentas agrupadoras
               oRow("GralBsDet") = ToDecimal(oRow("GralBsDet")) + ToDecimal(oRow("GralBsDetaux"))
               oRow("GralUsDet") = ToDecimal(oRow("GralUsDet")) + ToDecimal(oRow("GralUsDetaux"))
               oRow("GralBsGes") = ToDecimal(oRow("GralBsGes")) + ToDecimal(oRow("GralBsGesaux"))
               oRow("GralUsGes") = ToDecimal(oRow("GralUsGes")) + ToDecimal(oRow("GralUsGesaux"))
            End If

            oRow("GralBsaux") = 0
            oRow("GralUsaux") = 0
            oRow("GralBsDetaux") = 0
            oRow("GralUsDetaux") = 0
            oRow("GralBsGesaux") = 0
            oRow("GralUsGesaux") = 0
         Next
      Next

      Call addEstadoResultadoEmpresas()

      moDataTable.AcceptChanges()

      If mboolIncluirPlanAdd Then
         Dim strPlanCta As String = ""
         For Each row In moDataTable.Rows
            If ToLong(row("Del")) = 2 And ToBoolean(row("TieneAnaAdd")) Then
               strPlanCta = ToStr(row("PlanCta"))
            End If
            If ToLong(row("TipoId")) = Tipo.Analitico And strPlanCta = ToStr(row("PlanCtaAux")) Then
               row("Del") = 2
            End If
         Next
      End If

      Dim lngConer As Long = 0

      For Each row In moDataTable.Rows
         If ToLong(row("Nivel")) > mlngNivel Then
            moDataTable.Rows(lngConer).Delete()
         Else
            If ToLong(row("Del")) = 2 Then
               moDataTable.Rows(lngConer).Delete()
            End If
         End If
         lngConer += 1
      Next
      moDataTable.AcceptChanges()

      grdMain.DataSource = moDataTable.DefaultView
      grdMain.RetrieveStructure()
      Call grdMainInit()
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Estado de Resultados Consolidado"

         .RootTable.Columns("Id").Visible = False

         .RootTable.Columns("TipoId").Visible = False

         If mboolIncluirPlanAdd Then
            .RootTable.Columns("PlanCtaAux").Visible = False
            .RootTable.Columns("TieneAnaAdd").Visible = False
         End If

         .RootTable.Columns("PlanCta").Caption = "Código"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripción"
         .RootTable.Columns("PlanDes").Width = 370
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EsAna").Visible = False

         .RootTable.Columns("SucCCOId").Visible = False

         .RootTable.Columns("TipoGrupoId").Visible = False

         .RootTable.Columns("Nivel").Visible = False

         .RootTable.Columns("SW").Visible = False
         .RootTable.Columns("Del").Visible = False

         .RootTable.Columns("PlanId").Visible = False
         .RootTable.Columns("PlanPadreId").Visible = False

         .RootTable.Columns("GralBsaux").Visible = False
         .RootTable.Columns("GralUsaux").Visible = False
         .RootTable.Columns("GralBsDetaux").Visible = False
         .RootTable.Columns("GralUsDetaux").Visible = False
         .RootTable.Columns("GralBsGesaux").Visible = False
         .RootTable.Columns("GralUsGesaux").Visible = False

         If mlngMonedaId = 1 Then
            .RootTable.Columns("GralUs").Visible = False
            .RootTable.Columns("GralUsDet").Visible = False
         ElseIf mlngMonedaId = 2 Then
            .RootTable.Columns("GralBs").Visible = False
            .RootTable.Columns("GralBsDet").Visible = False
         End If

         If Not mboolTotalizar Then
            .RootTable.Columns("GralUs").Visible = False
            .RootTable.Columns("GralBs").Visible = False
         End If

         .RootTable.Columns("GralUsGes").Visible = False
         .RootTable.Columns("GralBsGes").Visible = False

         If mboolSaldoGestion Then
            If mlngMonedaId = 1 Then
               .RootTable.Columns("GralUsGes").Visible = False
               .RootTable.Columns("GralBsGes").Visible = True
            ElseIf mlngMonedaId = 2 Then
               .RootTable.Columns("GralUsGes").Visible = True
               .RootTable.Columns("GralBsGes").Visible = False
            Else
               .RootTable.Columns("GralUsGes").Visible = True
               .RootTable.Columns("GralBsGes").Visible = True
            End If
         End If

         .RootTable.Columns("GralBs").Caption = "General Bs."
         .RootTable.Columns("GralBs").FormatString = DecimalMask()
         .RootTable.Columns("GralBs").Width = 100
         .RootTable.Columns("GralBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GralBsDet").Caption = "Detalle Bs."
         .RootTable.Columns("GralBsDet").FormatString = DecimalMask()
         .RootTable.Columns("GralBsDet").Width = 100
         .RootTable.Columns("GralBsDet").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralBsDet").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GralBsGes").Caption = "Saldo Bs. Ges."
         .RootTable.Columns("GralBsGes").FormatString = DecimalMask()
         .RootTable.Columns("GralBsGes").Width = 100
         .RootTable.Columns("GralBsGes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralBsGes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GralUs").Caption = "General Us."
         .RootTable.Columns("GralUs").FormatString = DecimalMask()
         .RootTable.Columns("GralUs").Width = 100
         .RootTable.Columns("GralUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GralUsDet").Caption = "Detalle Us."
         .RootTable.Columns("GralUsDet").FormatString = DecimalMask()
         .RootTable.Columns("GralUsDet").Width = 100
         .RootTable.Columns("GralUsDet").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralUsDet").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GralUsGes").Caption = "Saldo Us. Ges."
         .RootTable.Columns("GralUsGes").FormatString = DecimalMask()
         .RootTable.Columns("GralUsGes").Width = 100
         .RootTable.Columns("GralUsGes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralUsGes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      If Not mboolConsolidar Then
         Call frmLibroMayorLoad()
      End If
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmEstadoResultadoConsolidado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If Not mboolConsolidar Then
               Call frmLibroMayorLoad()
            End If
         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub
#End Region
#End Region

#Region "otro prueba"

   Private Sub grdMainLoadEmpresas(ByVal lngPlanPadreId As Long, ByVal strTab As String)
      Dim oPlan As New clsPlan(mstrConnectString)
      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.Grid

            If lngPlanPadreId = 0 Then
               .WhereFilter = clsPlan.WhereFilters.GridEstadoResultado
               .OrderByFilter = clsPlan.OrderByFilters.PlanCta
            Else
               .WhereFilter = clsPlan.WhereFilters.Grid
               .OrderByFilter = clsPlan.OrderByFilters.Orden
            End If

            .EmpresaId = mlngEmpresaId
            .PlanPadreId = lngPlanPadreId
            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               strTab = strTab & "     "
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  Dim lngIndex As Long = AddRowDataTableEmpresas(oRow, strTab)
                  grdMainLoadEmpresas(ToLong(oRow("PlanId")), strTab)
                  UpdateRowDataTableEmpresas(lngIndex, oRow)

                  If ToLong(oRow("PlanPadreId")) = 0 Then
                     Call addTotalCuentaAgrupadoraEmpresas(ToLong(oRow("PlanId")), ToStr(oRow("PlanDes")), ToStr(oRow("PlanCta")), ToLong(oRow("TipoGrupoId")))
                     If mlngpos = 0 Then
                        Call GetRowNull()
                     End If
                  End If
               Next

               strTab = Mid(strTab, 1, Len(strTab) - 5)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Sub

   Private Function BuscarPosicion(ByVal oRow As DataRow, ByVal lngcount As Long) As Integer
      Dim lngPos As Integer = 0
      If mboolIncluirPlanAdd Then
         If ToBoolean(oRow("TieneAnaAdd")) Then
            If lngcount = 1 And moDataTable.Select("PlanCtaAux = '" & oRow("PlanCta") & "' and TipoId = " & Tipo.Analitico).Length > 0 Then
               Dim rowAA = moDataTable.Select("PlanCtaAux = '" & oRow("PlanCta") & "' and TipoId = " & Tipo.Analitico).Last
               lngPos = moDataTable.Rows.IndexOf(rowAA) + 1
            Else
               lngPos = moDataTable.Rows.IndexOf(oRow) + lngcount
            End If
         Else
            lngPos = moDataTable.Rows.IndexOf(oRow) + lngcount
         End If
      Else
         lngPos = moDataTable.Rows.IndexOf(oRow) + lngcount
      End If
      Return lngPos
   End Function

   Private Function AddRowDataTableEmpresas(ByVal oDataRow As DataRow, ByVal strTab As String) As Long
      Dim lngpos As Long = moDataTable.Rows.Count

      If ToLong(oDataRow("TipoGrupoId")) = 4 Or ToLong(oDataRow("TipoGrupoId")) = 5 Or ToLong(oDataRow("TipoGrupoId")) = 6 Then

         If moDataTable.Select("PlanCta = '" & oDataRow("PlanCta") & "' AND TipoId = " & Tipo.Cuenta).Length > 0 Then 'Si encontro Plan de Cuenta
            Dim oRowCuenta = moDataTable.Select("PlanCta = '" & oDataRow("PlanCta") & "' AND TipoId = " & Tipo.Cuenta).First
            'lngpos = moDataTable.Rows.IndexOf(oRowCuenta)
            lngpos = BuscarPosicion(oRowCuenta, 0)
            oRowCuenta("PlanId") = oDataRow("PlanId") 'oRowCuenta("PlanId" & mlngpos) = oDataRow("PlanId")
            oRowCuenta("PlanPadreId") = oDataRow("PlanPadreId") 'oRowCuenta("PlanPadreId" & mlngpos) = oDataRow("PlanPadreId")
            oRowCuenta("Nivel") = oDataRow("Nivel")
         Else  'Agregar Plan de Cuenta
            Dim oRow As DataRow
            oRow = moDataTable.NewRow
            oRow("PlanId") = oDataRow("PlanId") 'oRow("PlanId" & mlngpos) = oDataRow("PlanId")
            oRow("TipoId") = Tipo.Cuenta
            oRow("EsAna") = oDataRow("EsAna")
            oRow("SucCCOId") = oDataRow("SucCCOId")
            oRow("PlanCta") = oDataRow("PlanCta")
            oRow("PlanDes") = strTab & oDataRow("PlanDes")
            oRow("Nivel") = oDataRow("Nivel")
            oRow("PlanPadreId") = oDataRow("PlanPadreId") 'oRow("PlanPadreId" & mlngpos) = oDataRow("PlanPadreId")
            oRow("TipoGrupoId") = oDataRow("TipoGrupoId")
            If moDataTable.Select("TipoGrupoId = " & oRow("TipoGrupoId") & " AND PlanCta <= '" & oDataRow("PlanCta") & "'  AND TipoId = " & Tipo.Cuenta, "PlanCta").Length > 0 Then
               Dim oRowCuenta = moDataTable.Select("TipoGrupoId = " & oRow("TipoGrupoId") & " AND PlanCta <= '" & oDataRow("PlanCta") & "' AND TipoId = " & Tipo.Cuenta, "PlanCta").Last
               'lngpos = moDataTable.Rows.IndexOf(oRowCuenta)
               ' lngpos += 1
               lngpos = BuscarPosicion(oRowCuenta, 1)
            Else
               'PrintError
            End If
            If mlngpos > 0 Then
               moDataTableErrores.Rows.Add(3, "", oRow("PlanCta") & " - " & oDataRow("PlanDes") & " :: Se añadio la Cuenta", _
                                           ToLong(moDataTableEmpresas.Rows.Item(mlngpos)("EmpresaId")), _
                                           ToStr(moDataTableEmpresas.Rows.Item(mlngpos)("EmpresaDes")), _
                                           ToLong(moDataTableEmpresas.Rows.Item(mlngpos)("GestionId")), _
                                                  ToLong(moDataTableEmpresas.Rows.Item(mlngpos)("Gestion")))
            End If

            moDataTable.Rows.InsertAt(oRow, lngpos)
         End If

         If ToBoolean(oDataRow("TieneAnaAdd")) And mboolIncluirPlanAdd And ToBoolean(oDataRow("MostrarAnaAdd")) Then

            moDataTable.Rows(lngpos)("TieneAnaAdd") = True
            Call PlanAddLoad(oDataRow("PlanId"), oDataRow("PlanCta"), strTab & "     ", ToLong(oDataRow("Nivel")), ToLong(oDataRow("TipoGrupoId")), lngpos)
         End If

         Return lngpos
      End If
   End Function

   Private Sub PlanAddLoad(ByVal lngPlanId As Long, ByRef strPlanCta As String, ByVal strTab As String, ByVal lngNivel As Long _
         , ByVal lngTipoGrupoId As Long, ByVal lngPosCuenta As Long)
      Dim lngpos As Long = moDataTable.Rows.Count
      Dim oPlanAdd As New clsPlanAdd(mstrConnectString)

      Dim decPlanAddBs As Decimal
      Dim decPlanAddUs As Decimal
      Dim decPlanAddGesBs As Decimal = 0
      Dim decPlanAddGesUs As Decimal = 0
      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.All
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes
            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanId

            If .Open Then
               Do While .Read
                  Dim oDataTableCompPlanAdd = LoadCompPlanAdd(.PlanId, .PlanAddId)

                  If oDataTableCompPlanAdd IsNot Nothing Then
                     Dim strFiltro As String = ""

                     If mboolIntervaloFecha Then
                        strFiltro = "Fecha >= '" & ToDateDMY(mdatFechaIniInt) & "' AND Fecha <= '" & ToDateDMY(mdatFechaFinInt) & "'"
                     End If

                     If mboolSaldoGestion Then
                        decPlanAddGesBs = SaldoPlanAddBs(oDataTableCompPlanAdd, decPlanAddGesUs, lngTipoGrupoId, "")
                     End If

                     decPlanAddBs = SaldoPlanAddBs(oDataTableCompPlanAdd, decPlanAddUs, lngTipoGrupoId, strFiltro)

                     If ToDecimalMinor(Math.Abs(decPlanAddBs)) > 0 And ToDecimalMinor(Math.Abs(decPlanAddUs)) > 0 Then
                        If moDataTable.Select("PlanCtaAux = '" & strPlanCta & "' AND PlanCta = '" & .PlanAddCta & "' and TipoId = " & Tipo.Analitico).Length > 0 Then 'Si encontro 
                           Dim oRowAnalitico = moDataTable.Select("PlanCtaAux = '" & strPlanCta & "' AND PlanCta = '" & .PlanAddCta & "' and TipoId = " & Tipo.Analitico).First
                           oRowAnalitico("GralBsDet") = ToDecimal(oRowAnalitico("GralBsDet")) + decPlanAddBs
                           oRowAnalitico("GralUsDet") = ToDecimal(oRowAnalitico("GralUsDet")) + decPlanAddUs
                           oRowAnalitico("GralBsGes") = ToDecimal(oRowAnalitico("GralBsGes")) + decPlanAddGesBs
                           oRowAnalitico("GralUsGes") = ToDecimal(oRowAnalitico("GralUsGes")) + decPlanAddGesUs
                        Else
                           Dim oRow As DataRow
                           oRow = moDataTable.NewRow
                           oRow("TipoId") = Tipo.Analitico
                           oRow("EsAna") = 1
                           oRow("PlanCtaAux") = strPlanCta
                           oRow("PlanCta") = .PlanAddCta
                           oRow("PlanDes") = strTab & .PlanAddDes
                           oRow("GralBsDet") = decPlanAddBs
                           oRow("GralUsDet") = decPlanAddUs
                           oRow("GralBsGes") = decPlanAddGesBs
                           oRow("GralUsGes") = decPlanAddGesUs

                           oRow("Nivel") = lngNivel

                           If moDataTable.Select("PlanCtaAux = '" & strPlanCta & "' AND PlanCta <= '" & .PlanAddCta & "' and TipoId = " & Tipo.Analitico, "PlanCta").Length > 0 Then
                              Dim oRowAnaAdd = moDataTable.Select("PlanCtaAux = '" & strPlanCta & "' AND PlanCta <= '" & .PlanAddCta & "' and TipoId = " & Tipo.Analitico, "PlanCta").Last
                              lngpos = moDataTable.Rows.IndexOf(oRowAnaAdd)
                              lngpos += 1
                           Else
                              lngpos = lngPosCuenta + 1
                           End If

                           moDataTable.Rows.InsertAt(oRow, lngpos)
                        End If
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanAdd.Dispose()
      End Try
   End Sub

   Private Function SaldoPlanAddBs(ByVal oDataTable As DataTable, ByRef decSaldoUs As Decimal, ByVal lngTipoGrupoId As Long, _
                                   ByVal strFiltro As String) As Decimal
      Dim decSaldoBs As Decimal = 0
      decSaldoUs = 0
      Dim decDebeBs As Decimal = 0, decDebeUs As Decimal = 0, decHaberBs As Decimal = 0, decHaberUs As Decimal = 0

      Try

         decDebeBs = ToDecimal(oDataTable.Compute("SUM(DebeBs)", strFiltro))
         decHaberBs = ToDecimal(oDataTable.Compute("SUM(HaberBs)", strFiltro))
         decDebeUs = ToDecimal(oDataTable.Compute("SUM(DebeUs)", strFiltro))
         decHaberUs = ToDecimal(oDataTable.Compute("SUM(HaberUs)", strFiltro))

         If lngTipoGrupoId = 1 Or lngTipoGrupoId = 5 Or lngTipoGrupoId = 6 Or lngTipoGrupoId = 7 Then
            decSaldoBs = ToDecimal(decDebeBs - decHaberBs)
            decSaldoUs = ToDecimal(decDebeUs - decHaberUs)

         ElseIf lngTipoGrupoId = 2 Or lngTipoGrupoId = 3 Or lngTipoGrupoId = 4 Or lngTipoGrupoId = 8 Then
            decSaldoBs = ToDecimal(decHaberBs - decDebeBs)
            decSaldoUs = ToDecimal(decHaberUs - decDebeUs)
         End If

         SaldoPlanAddBs = decSaldoBs

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   Private Function LoadCompPlanAdd(ByVal lngPlanId As Long, ByVal lngPlanAddId As Long) As DataTable
      Dim oCompPlanAdd As New clsCompPlanAdd(mstrConnectString)
      LoadCompPlanAdd = Nothing

      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayorFecha

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .PlanAddId = lngPlanAddId
            .Fecha = ToDate(mdatFechaIni)
            .LastUpdateId = ToDate(mdatFechaFin)
            .CompId = mlngCentroCostoId 'CentroCostoId
            '.CompDetId = mlngSucursalId 'SucursalId
            .MonedaId = ToBoolean(mboolSinFac) 'SinFac
            .EstadoId = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'temp
            If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               'For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
               '   If lngTipoGrupoId = 1 Or lngTipoGrupoId = 5 Or lngTipoGrupoId = 6 Or lngTipoGrupoId = 7 Then
               '      decSaldoBs += ToDecimal(oRow("DebeBs") - oRow("HaberBs"))
               '      decSaldoUs += ToDecimal(oRow("DebeUs") - oRow("HaberUs"))

               '   ElseIf lngTipoGrupoId = 2 Or lngTipoGrupoId = 3 Or lngTipoGrupoId = 4 Or lngTipoGrupoId = 8 Then
               '      decSaldoBs += ToDecimal(oRow("HaberBs") - oRow("DebeBs"))
               '      decSaldoUs += ToDecimal(oRow("HaberUs") - oRow("DebeUs"))
               '   End If
               'Next
               LoadCompPlanAdd = .DataSet.Tables(0)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompPlanAdd.Dispose()
      End Try
   End Function

   Private Sub addEstadoResultadoEmpresas()
      Dim oRow As DataRow

      If moDataTable.Select("Id = " & 10).Length > 0 Then
         oRow = moDataTable.Select("Id = " & 10).Last
      Else
         oRow = moDataTable.NewRow
         oRow("Id") = 10
         oRow("PlanDes") = "RESULTADO DEL EJERCICIO"
         oRow("Nivel") = mlngNivel
         moDataTable.Rows.Add(oRow)
      End If

      For Each row In moDataTable.Rows
         If ToLong(row("PlanPadreId")) = 0 And ToStr(row("PlanCta")).Equals("4") Then
            oRow("GralBsDet") = ToDecimal(oRow("GralBsDet")) + ToDecimal(row("GralBs"))
            oRow("GralUsDet") = ToDecimal(oRow("GralUsDet")) + ToDecimal(row("GralUs"))
         ElseIf ToLong(row("PlanPadreId")) = 0 And (ToStr(row("PlanCta")).Equals("5") Or ToStr(row("PlanCta")).Equals("6")) Then
            oRow("GralBsDet") = ToDecimal(oRow("GralBsDet")) - ToDecimal(row("GralBs"))
            oRow("GralUsDet") = ToDecimal(oRow("GralUsDet")) - ToDecimal(row("GralUs"))
         End If
      Next
   End Sub

   Private Sub UpdateRowDataTableEmpresas(ByVal lngIndex As Long, ByVal oDataRowCuenta As DataRow)
      Dim datatableCompDet As DataTable
      Dim oRow As DataRow
      oRow = moDataTable.Rows(lngIndex)

      If ToBoolean(oDataRowCuenta("EsAna")) Then
         ' If (mlngSucursalId > 0 And ToLong(oRow("SucCCOId")) = 1) Or _
         '(mlngCentroCostoId > 0 And ToLong(oRow("SucCCOId")) = 2) Or _
         ' (mlngCentroCostoId = 0 And mlngSucursalId = 0) Then

         datatableCompDet = LoadCompDet(ToLong(oDataRowCuenta("PlanId")), clsCompDet.WhereFilters.RowSumFecha)
         If datatableCompDet IsNot Nothing Then
            Dim datFechaIni As Date
            Dim datFechaFin As Date
            For index As Integer = 1 To 2
               If index = 1 Then
                  datFechaIni = mdatFechaIniInt
                  datFechaFin = mdatFechaFinInt
               Else
                  datFechaIni = mdatFechaIni
                  datFechaFin = mdatFechaFin
               End If

               Dim strFiltro As String = "Fecha >= '" & ToDateDMY(datFechaIni) & "' and Fecha <= '" & ToDateDMY(datFechaFin) & "'"
               If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                  mdecDebeBs = ToDecimal(datatableCompDet.Compute("Sum(DebeBs)", strFiltro))
                  mdecHaberBs = ToDecimal(datatableCompDet.Compute("Sum(HaberBs)", strFiltro))
                  mdecDebeUs = 0
                  mdecHaberUs = 0
               ElseIf mlngMonedaId = clsMoneda.DOLARES Then
                  mdecDebeBs = 0
                  mdecHaberBs = 0
                  mdecDebeUs = ToDecimal(datatableCompDet.Compute("Sum(DebeUs)", strFiltro))
                  mdecHaberUs = ToDecimal(datatableCompDet.Compute("Sum(HaberUs)", strFiltro))
               ElseIf mlngMonedaId = 4 Then 'AMBOS
                  mdecDebeBs = ToDecimal(datatableCompDet.Compute("Sum(DebeBs)", strFiltro))
                  mdecHaberBs = ToDecimal(datatableCompDet.Compute("Sum(HaberBs)", strFiltro))
                  mdecDebeUs = ToDecimal(datatableCompDet.Compute("Sum(DebeUs)", strFiltro))
                  mdecHaberUs = ToDecimal(datatableCompDet.Compute("Sum(HaberUs)", strFiltro))
               End If

               If ToLong(oDataRowCuenta("TipoGrupoId")) = 1 Or ToLong(oDataRowCuenta("TipoGrupoId")) = 5 Or ToLong(oDataRowCuenta("TipoGrupoId")) = 6 Or ToLong(oDataRowCuenta("TipoGrupoId")) = 7 Then
                  If index = 1 Then
                     oRow("GralBsDetaux") = ToDecimal(mdecDebeBs - mdecHaberBs)
                     oRow("GralUsDetaux") = ToDecimal(mdecDebeUs - mdecHaberUs)
                  Else
                     oRow("GralBsGesaux") = ToDecimal(mdecDebeBs - mdecHaberBs)
                     oRow("GralUsGesaux") = ToDecimal(mdecDebeUs - mdecHaberUs)
                  End If
               ElseIf ToLong(oDataRowCuenta("TipoGrupoId")) = 2 Or ToLong(oDataRowCuenta("TipoGrupoId")) = 3 Or ToLong(oDataRowCuenta("TipoGrupoId")) = 4 Or ToLong(oDataRowCuenta("TipoGrupoId")) = 8 Then
                  If index = 1 Then
                     oRow("GralBsDetaux") = ToDecimal(mdecHaberBs - mdecDebeBs)
                     oRow("GralUsDetaux") = ToDecimal(mdecHaberUs - mdecDebeUs)
                  Else
                     oRow("GralBsGesaux") = ToDecimal(mdecHaberBs - mdecDebeBs)
                     oRow("GralUsGesaux") = ToDecimal(mdecHaberUs - mdecDebeUs)
                  End If
               End If
            Next

            If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsDetaux")))) = 0 And ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsDetaux")))) = 0 Then 'If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsDet" & mlngpos)))) = 0 And ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsDet" & mlngpos)))) = 0 Then
               If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsGesaux")))) > 0 Or ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsGesaux")))) > 0 Then 'If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsGes" & mlngpos)))) > 0 Or ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsGes" & mlngpos)))) > 0 Then
                  AddRowDataTableAuxEmpresas(oRow)
                  oRow("GralBsDetaux") = DBNull.Value
                  oRow("GralUsDetaux") = DBNull.Value
                  oRow("GralBsGesaux") = DBNull.Value
                  oRow("GralUsGesaux") = DBNull.Value
               End If

               ' DeleteCuentaAndAnaliticoAddEmpresas(lngIndex, ToLong(oRow("PlanId"))) 
               oRow("Del") = If(ToLong(oRow("Del")) = 1, 1, 2)
            Else
               oRow("Del") = 1
            End If
         Else
            '  DeleteCuentaAndAnaliticoAddEmpresas(lngIndex, ToLong(oRow("PlanId"))) 
            oRow("Del") = If(ToLong(oRow("Del")) = 1, 1, 2)
         End If
         'Else
         '   DeleteCuentaAndAnaliticoAdd(lngIndex, ToLong(oRow("PlanId")))
         '  End If
      Else
         oRow("GralBsaux") = ToDecimal(moDataTable.Compute("Sum(GralBsDetaux)", "PlanPadreId = " & ToLong(oRow("PlanId")))) + ToDecimal(moDataTable.Compute("Sum(GralBsaux)", "PlanPadreId = " & ToLong(oRow("PlanId")))) 'oRow("GralBs" & mlngpos) = ToDecimal(moDataTable.Compute("Sum(GralBsDet" & mlngpos & ")", "PlanPadreId" & mlngpos & " = " & ToLong(oRow("PlanId" & mlngpos)))) + ToDecimal(moDataTable.Compute("Sum(GralBs" & mlngpos & ")", "PlanPadreId" & mlngpos & " = " & ToLong(oRow("PlanId" & mlngpos)))) ' ToDecimal(decTotalNivelBs)
         oRow("GralUsaux") = ToDecimal(moDataTable.Compute("Sum(GralUsDetaux)", "PlanPadreId = " & ToLong(oRow("PlanId")))) + ToDecimal(moDataTable.Compute("Sum(GralUsaux)", "PlanPadreId = " & ToLong(oRow("PlanId")))) ' ToDecimal(decTotalNivelBs)' ToDecimal(decTotalNivelUs)
         oRow("GralBsGesaux") = ToDecimal(moDataTable.Compute("Sum(GralBsGesaux)", "PlanPadreId = " & ToLong(oRow("PlanId")))) + ToDecimal(moDataTableAux.Compute("Sum(GralBs)", "PlanPadreId = " & ToLong(oRow("PlanId"))))
         oRow("GralUsGesaux") = ToDecimal(moDataTable.Compute("Sum(GralUsGesaux)", "PlanPadreId = " & ToLong(oRow("PlanId")))) + ToDecimal(moDataTableAux.Compute("Sum(GralUs)", "PlanPadreId = " & ToLong(oRow("PlanId"))))

         If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsaux")))) = 0 And ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsaux")))) = 0 Then
            If Not TieneMovimientoEmpresas(ToLong(oRow("PlanId")), ToLong(oRow("Nivel"))) Then
               If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsGesaux")))) > 0 Or ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsGesaux")))) > 0 Then
                  AddRowDataTableAuxEmpresas(oRow)
               End If

               '   moDataTable.Rows.RemoveAt(lngIndex)
               oRow("Del") = If(ToLong(oRow("Del")) = 1, 1, 2)
               oRow("GralBsaux") = DBNull.Value
               oRow("GralUsaux") = DBNull.Value
               oRow("GralBsGesaux") = DBNull.Value
               oRow("GralUsGesaux") = DBNull.Value
            Else
               oRow("SW") = ToLong(1)
               oRow("Del") = 1
            End If
         Else
            oRow("Del") = 1
         End If
      End If
   End Sub

   Private Sub addTotalCuentaAgrupadoraEmpresas(ByVal lngPlanId As Long, ByVal strPlanDes As String, ByVal strPlanCta As String, ByVal lngTipoGrupoId As Long)
      Dim oRow As DataRow

      If moDataTable.Select("Id = " & lngTipoGrupoId).Length > 0 Then
         oRow = moDataTable.Select("Id = " & lngTipoGrupoId).Last
      Else
         oRow = moDataTable.NewRow
         oRow("Id") = lngTipoGrupoId
         oRow("PlanDes") = "TOTAL " & strPlanDes
         moDataTable.Rows.Add(oRow)
      End If

      oRow("GralBsDetaux") = ToDecimal(moDataTable.Compute("Sum(GralBsDetaux)", "PlanPadreId = " & lngPlanId)) + ToDecimal(moDataTable.Compute("Sum(GralBsaux)", "PlanPadreId = " & lngPlanId)) ' ToDecimal(decTotalNivelBs) TotalNivel(decTotalNivelUs, lngPlanId)
      oRow("GralUsDetaux") = ToDecimal(moDataTable.Compute("Sum(GralUsDetaux)", "PlanPadreId = " & lngPlanId)) + ToDecimal(moDataTable.Compute("Sum(GralUsaux)", "PlanPadreId = " & lngPlanId)) ' ToDecimal(decTotalNivelBs) TotalNivel(decTotalNivelUs, lngPlanId) decTotalNivelUs

      oRow("GralBsGesaux") = ToDecimal(moDataTable.Compute("Sum(GralBsGesaux)", "PlanPadreId = " & lngPlanId)) + ToDecimal(moDataTableAux.Compute("Sum(GralBs)", "PlanPadreId = " & lngPlanId))
      oRow("GralUsGesaux") = ToDecimal(moDataTable.Compute("Sum(GralUsGesaux)", "PlanPadreId = " & lngPlanId)) + ToDecimal(moDataTableAux.Compute("Sum(GralUs)", "PlanPadreId = " & lngPlanId))

      oRow("Nivel") = mlngNivel

   End Sub

   Private Function TieneMovimientoEmpresas(ByVal lngPlanId As Long, ByVal lngNivel As Long) As Boolean
      TieneMovimientoEmpresas = False
      For Each row In moDataTable.Rows
         If ToLong(row("PlanPadreId")) = lngPlanId And ToLong(row("Nivel")) = lngNivel + 1 Then
            If ToDecimalMinor(Math.Abs(ToDecimal(row("GralBsDetaux")) + ToDecimal(row("GralBsaux")))) > 0 Or _
            ToDecimalMinor(Math.Abs(ToDecimal(row("GralUsDetaux")) + ToDecimal(row("GralUsaux")))) > 0 Or _
            ToLong(row("SW")) = 1 Then
               TieneMovimientoEmpresas = True
               Exit For
            End If
         End If
      Next
   End Function

   Private Sub AddRowDataTableAuxEmpresas(ByVal oDataRow As DataRow)
      Dim oRowAux As DataRow
      oRowAux = moDataTableAux.NewRow
      oRowAux("GralBs") = ToDecimal(oDataRow("GralBsGesaux"))
      oRowAux("GralUs") = ToDecimal(oDataRow("GralUsGesaux"))
      oRowAux("PlanPadreId") = oDataRow("PlanPadreId")

      moDataTableAux.Rows.Add(oRowAux)
   End Sub

#End Region

   Private Function PlanDesFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanDesFind = ""

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanDesFind = .PlanCta & " " & .PlanDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function
End Class
