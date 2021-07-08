Public Class frmEstadoFlujoEfectivo
   Inherits System.Windows.Forms.Form

   Private moCompPlanEEFF As clsCompPlanEEFF
   Private moPlanEEFF As clsPlanEEFF
   Private moLista As New Queue
   Private moListaTipoAsiento As New Queue
   Private mstrTipoAsientoId As String
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolOrdenarFecha As Boolean
   Private mboolSaldoAnterior As Boolean
   Private mboolIncluirPlanAdd As Boolean
   Private mboolTotalizar As Boolean
   Private mlngNivel As Long
   Private mboolSinMovimiento As Boolean
   'Private mboolResumido As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean
   Private mstrFechaIniGestion As String
   Private mstrFechaFinGestion As String
   Private mboolSaldoGestion As Boolean
   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private mboolChanged As Boolean

   Private mdecCajaInicialBs As Decimal
   Private mdecCajaInicialUs As Decimal
   Private mdecBancoInicialBs As Decimal
   Private mdecBancoInicialUs As Decimal

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

   Property IntervaloFecha() As Boolean
      Get
         Return mboolIntervaloFecha
      End Get

      Set(ByVal Value As Boolean)
         mboolIntervaloFecha = Value
      End Set
   End Property

   'Property Resumido() As Boolean
   '   Get
   '      Return mboolResumido
   '   End Get

   '   Set(ByVal Value As Boolean)
   '      mboolResumido = Value
   '   End Set
   'End Property

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

   Property FechaIniGestion() As String
      Get
         Return mstrFechaIniGestion
      End Get

      Set(ByVal Value As String)
         mstrFechaIniGestion = Value
      End Set
   End Property

   Property FechaFinGestion() As String
      Get
         Return mstrFechaFinGestion
      End Get

      Set(ByVal Value As String)
         mstrFechaFinGestion = Value
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

   Property SaldoAnterior() As Boolean
      Get
         Return mboolSaldoAnterior
      End Get

      Set(ByVal Value As Boolean)
         mboolSaldoAnterior = Value
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

   Property IncluirPlanAdd() As Boolean
      Get
         Return mboolIncluirPlanAdd
      End Get

      Set(ByVal Value As Boolean)
         mboolIncluirPlanAdd = Value
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

   'Property Cuenta() As Boolean
   '   Get
   '      Return mboolCuenta
   '   End Get

   '   Set(ByVal Value As Boolean)
   '      mboolCuenta = Value
   '   End Set
   'End Property

   Property SinMovimiento() As Boolean
      Get
         Return mboolSinMovimiento
      End Get

      Set(ByVal Value As Boolean)
         mboolSinMovimiento = Value
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

   Property Lista() As Queue
      Get
         Return moLista
      End Get

      Set(ByVal Value As Queue)
         moLista = Value
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

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoFlujoEfectivo))
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
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("aea013d3-db27-46fd-b9c2-6b48dddfb8f8")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(241, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Comprobante"
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
      'frmEstadoFlujoEfectivo
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmEstadoFlujoEfectivo"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ESTADO DE FLUJOS DE EFECTIVO"
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
         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmEstadoFlujoEfectivo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmEstadoFlujoEfectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      Call FormCenterChild(Me)

      moCompPlanEEFF = New clsCompPlanEEFF(clsAppInfo.ConnectString)
      moPlanEEFF = New clsPlanEEFF(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("PlanEEFFId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
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
      Try
         Dim rpt As New rptEstadoFlujoEfectivo
         rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompPlanEEFF.TableName))

         rpt.lblTitle.Text = "ESTADO DE FLUJOS DE EFECTIVO"
         rpt.Document.Name = "ESTADO DE FLUJOS DE EFECTIVO"

         rpt.lblCompany.Text = clsAppInfo.EmpresaGral
         rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
         rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
         rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

         rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
         rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)

         If mlngMonedaId = 1 Then
            rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
            rpt.lblCol03.Text = ""
            rpt.txtCol01.Visible = False
            rpt.lblCol04.Text = "Saldo Bs."
            rpt.txtCol02.DataField = "SaldoBs"

         ElseIf mlngMonedaId = 2 Then
            rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
            rpt.lblCol03.Text = ""
            rpt.txtCol01.Visible = False
         ElseIf mlngMonedaId = 4 Then
            rpt.txtMoneda.Text = "Ambas"
         End If

         Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

         rpt.Run(True)
         Dim frm As frmReportPreview
         frm = New frmReportPreview(rpt.Document, Me)
         frm.Show()
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

#Region " FLUJO EFECTIVO "
#Region " Metodo- ESTADO FLUJO EFECTIVO "
   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Nivel"), Janus.Windows.GridEX.ConditionOperator.Equal, 2)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanEEFFId"), Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      'fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompPlanEEFFId"), Janus.Windows.GridEX.ConditionOperator.Equal, -2)
      'fc.FormatStyle.ForeColor = Color.DarkBlue
      'grdMain.RootTable.FormatConditions.Add(fc)

      'fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompPlanEEFFId"), Janus.Windows.GridEX.ConditionOperator.Equal, -4)
      'fc.FormatStyle.ForeColor = Color.DarkBlue
      'grdMain.RootTable.FormatConditions.Add(fc)
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

   Private Function TipoEEFFIdDesFind(ByVal lngTipoEEFFId As Long, ByVal lngNivel As Long) As String
      TipoEEFFIdDesFind = ""
      If lngNivel = 2 Then
         If lngTipoEEFFId = clsTipoComp.INGRESO Then
            TipoEEFFIdDesFind = "INGRESOS POR "
         ElseIf lngTipoEEFFId = clsTipoComp.EGRESO Then
            TipoEEFFIdDesFind = "EGRESOS POR "
         End If
      End If
   End Function
#End Region

#Region " Grid-FLUJO EFECTIVO "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCompPlanEEFF.TableName)

      moDataTable.Columns.Add("PlanEEFFId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanEEFFCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanEEFFDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoEEFFId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanEEFFPadreId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Nivel", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Orden", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SaldoBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("EsAna", Type.GetType("System.Byte"))
   End Sub

   Private Function AddRowDataTable(ByVal oDataRow As DataRow, ByVal strTab As String) As Long
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanEEFFId") = oDataRow("PlanEEFFId")
      oRow("PlanEEFFCta") = oDataRow("PlanEEFFCta")
      oRow("PlanEEFFDes") = strTab & TipoEEFFIdDesFind(ToLong(oDataRow("TipoEEFFId")), ToLong(oDataRow("Nivel"))) & oDataRow("PlanEEFFDes")
      oRow("EsAna") = oDataRow("EsAna")
      oRow("Orden") = oDataRow("Orden")
      oRow("Nivel") = oDataRow("Nivel")
      oRow("PlanEEFFPadreId") = oDataRow("PlanEEFFPadreId")
      oRow("TipoEEFFId") = oDataRow("TipoEEFFId")

      moDataTable.Rows.Add(oRow)
      AddRowDataTable = moDataTable.Rows.Count - 1
   End Function

   Private Function GetSubFooter(ByVal lngId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Dim lngPlanEEFFIdIng As Long = ToLong((From row In moPlanEEFF.DataSet.Tables(moPlanEEFF.TableName) Where row.Field(Of Integer)("Orden") = lngId And row.Field(Of Integer)("TipoEEFFId") = clsTipoComp.INGRESO Select row.Field(Of Integer)("PlanEEFFId")).FirstOrDefault)
      Dim lngPlanEEFFIdEgr As Long = ToLong((From row In moPlanEEFF.DataSet.Tables(moPlanEEFF.TableName) Where row.Field(Of Integer)("Orden") = lngId And row.Field(Of Integer)("TipoEEFFId") = clsTipoComp.EGRESO Select row.Field(Of Integer)("PlanEEFFId")).FirstOrDefault)

      Dim decSaldoIngBs As Decimal = 0
      Dim decSaldoIngUs As Decimal = 0
      Dim decSaldoEgrBs As Decimal = 0
      Dim decSaldoEgrUs As Decimal = 0
      Dim strDes As String = ""

      oRow("PlanEEFFId") = lngId * -1

      decSaldoIngBs = ToDecimal(moDataTable.Compute("SUM(SaldoBs)", "PlanEEFFId = " & ToStr(lngPlanEEFFIdIng)))
      decSaldoIngUs = ToDecimal(moDataTable.Compute("SUM(SaldoUs)", "PlanEEFFId = " & ToStr(lngPlanEEFFIdIng)))
      decSaldoEgrBs = ToDecimal(moDataTable.Compute("SUM(SaldoBs)", "PlanEEFFId = " & ToStr(lngPlanEEFFIdEgr)))
      decSaldoEgrUs = ToDecimal(moDataTable.Compute("SUM(SaldoUs)", "PlanEEFFId = " & ToStr(lngPlanEEFFIdEgr)))

      strDes = ToStr((From row In moPlanEEFF.DataSet.Tables(moPlanEEFF.TableName) Where row.Field(Of Integer)("PlanEEFFId") = lngPlanEEFFIdIng Select row.Field(Of String)("PlanEEFFDes")).First)
      oRow("PlanEEFFDes") = "FLUJO NETO DE EFECTIVO POR " & strDes
      'oRow("SaldoBs") = decSaldoIngBs - decSaldoEgrBs 'decDebeBs - decHaberBs
      'oRow("SaldoUs") = decSaldoIngUs - decSaldoEgrUs
      oRow("SaldoBs") = decSaldoIngBs + decSaldoEgrBs 'decDebeBs - decHaberBs
      oRow("SaldoUs") = decSaldoIngUs + decSaldoEgrUs

      Return oRow
   End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      oRow("Nivel") = mlngNivel
      Return oRow
   End Function

   Private Sub grdMainLoad()
      Call moDataSetInit()
      Call CompPlanEEFFLoad(mlngGestionId)
      Call PlanEEFFLoad()

      mstrTipoAsientoId = TipoAsientoIdListaLoad()
      Call grdMainLoad(0, "")

      moDataTable.Rows.Add(getSuperavit_Deficit())
      moDataTable.Rows.Add(GetRowNull())
      Call GetEfectivoInicial()
      Call GetEfectivoFinal()
      moDataTable.AcceptChanges()
      Dim lngConer As Long = 0
      For Each row In moDataTable.Rows

         If ToLong(row("Nivel")) > mlngNivel Then
            moDataTable.Rows(lngConer).Delete()
         End If
         lngConer += 1
      Next
      moDataTable.AcceptChanges()

      grdMain.DataSource = moDataTable.DefaultView
      grdMain.RetrieveStructure()
      Call grdMainInit()
   End Sub

   Private Function getSuperavit_Deficit() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Dim decSaldoBsIng As Decimal = ToDecimal(moDataTable.Compute("SUM(SaldoBs)", "PlanEEFFId = -1"))
      Dim decSaldoUsIng As Decimal = ToDecimal(moDataTable.Compute("SUM(SaldoUs)", "PlanEEFFId = -1"))
      Dim decSaldoBsEgr As Decimal = ToDecimal(moDataTable.Compute("SUM(SaldoBs)", "PlanEEFFId = -3"))
      Dim decSaldoUsEgr As Decimal = ToDecimal(moDataTable.Compute("SUM(SaldoUs)", "PlanEEFFId = -3"))

      oRow("PlanEEFFId") = -100
      oRow("PlanEEFFDes") = "SUPERAVIT/DEFICIT DE LA GESTIÓN(FLUJO NETO DE EFECTIVO)"
      oRow("SaldoBs") = Math.Abs(decSaldoBsIng) - Math.Abs(decSaldoBsEgr)
      oRow("SaldoUs") = Math.Abs(decSaldoUsIng) - Math.Abs(decSaldoUsEgr)

      Return oRow
   End Function

   Private Function GestionFecha(ByVal lngGestion As Long, ByRef strFechaIni As String, ByRef strFechaFin As String, ByRef lngGestionId As Long) As Boolean
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionFecha = False
      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.Gestion
            .Gestion = lngGestion
            .EmpresaId = mlngEmpresaId
            .EstadoId = clsEstado.ABIERTO

            If .Find Then
               lngGestionId = .GestionId
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

   Private Function PlanCtaFind(ByVal strPlanDes As String, ByRef strPlanCta As String) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      PlanCtaFind = False

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanDes
            .EmpresaId = mlngEmpresaId
            .PlanDes = strPlanDes
            If .Find Then
               strPlanCta = .PlanCta
               Return True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Sub GetEfectivoInicial()
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Dim lngIndexEfectivo As Long = 0
      Dim lngIndexSaldoInicial As Long = 0
      Dim lngGestionId As Long
      Dim strFiltro As String = ""

      oRow("PlanEEFFId") = -101
      oRow("PlanEEFFDes") = "EFECTIVO INICIAL"
      moDataTable.Rows.Add(oRow)
      lngIndexEfectivo = moDataTable.Rows.Count - 1

      oRow = moDataTable.NewRow
      oRow("PlanEEFFId") = -102
      oRow("PlanEEFFDes") = "SALDO INICIAL DISPONIBLE"
      moDataTable.Rows.Add(oRow)
      lngIndexSaldoInicial = moDataTable.Rows.Count - 1

      If mboolIntervaloFecha Then
         strFiltro = "(Fecha >= '" & ConvertDMY(mstrFechaIniGestion) & "' AND Fecha < '" & ConvertDMY(mstrFechaIni) & "') AND "
      Else
         If moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).AsEnumerable.ToList.Exists(Function(row) row.Field(Of Integer)("TipoAsientoId") = clsTipoAsiento.APERTURA) Then
            strFiltro = "TipoAsientoId = " & clsTipoAsiento.APERTURA & " AND "
         ElseIf GestionFecha(clsAppInfo.Gestion - 1, mstrFechaIniGestion, mstrFechaFinGestion, lngGestionId) Then
            Call CompPlanEEFFLoad(lngGestionId)
            strFiltro = "(Fecha >= '" & mstrFechaIniGestion & "' AND Fecha <= '" & mstrFechaFinGestion & "') AND "
         Else
            strFiltro = "TipoAsientoId = " & clsTipoAsiento.APERTURA & " AND "
         End If
      End If

      oRow = moDataTable.NewRow
      oRow("PlanEEFFId") = -103
      oRow("PlanEEFFDes") = "CAJA"
      oRow("PlanEEFFCta") = ""
      Call PlanCtaFind(oRow("PlanEEFFDes"), oRow("PlanEEFFCta"))

      Dim decDebeBs As Decimal = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(DebeBs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CAJA)))
      Dim decDebeUs As Decimal = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(DebeUs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CAJA)))
      Dim decHaberBs As Decimal = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(HaberBs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CAJA)))
      Dim decHaberUs As Decimal = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(HaberUs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CAJA)))

      mdecCajaInicialBs = decDebeBs - decHaberBs
      mdecCajaInicialUs = decDebeUs - decHaberUs

      oRow("SaldoBs") = mdecCajaInicialBs
      oRow("SaldoUs") = mdecCajaInicialUs
      moDataTable.Rows.Add(oRow)

      oRow = moDataTable.NewRow
      oRow("PlanEEFFId") = -104
      oRow("PlanEEFFDes") = "BANCO"
      oRow("PlanEEFFCta") = ""
      Call PlanCtaFind(oRow("PlanEEFFDes"), oRow("PlanEEFFCta"))

      decDebeBs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(DebeBs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CUENTA_CORRIENTE)))
      decDebeUs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(DebeUs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CUENTA_CORRIENTE)))
      decHaberBs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(HaberBs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CUENTA_CORRIENTE)))
      decHaberUs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(HaberUs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CUENTA_CORRIENTE)))

      mdecBancoInicialBs = decDebeBs - decHaberBs
      mdecBancoInicialUs = decDebeUs - decHaberUs

      oRow("SaldoBs") = mdecBancoInicialBs
      oRow("SaldoUs") = mdecBancoInicialUs
      moDataTable.Rows.Add(oRow)

      oRow = moDataTable.Rows(lngIndexSaldoInicial)
      oRow("SaldoBs") = mdecCajaInicialBs + mdecBancoInicialBs
      oRow("SaldoUs") = mdecCajaInicialUs + mdecBancoInicialUs

      oRow = moDataTable.Rows(lngIndexEfectivo)
      oRow("SaldoBs") = mdecCajaInicialBs + mdecBancoInicialBs
      oRow("SaldoUs") = mdecCajaInicialUs + mdecBancoInicialUs

      moDataTable.Rows.Add(GetRowNull())
   End Sub

   Private Sub GetEfectivoFinal()
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Dim lngIndexEfectivo As Long = 0
      Dim lngIndexSaldoFinal As Long = 0
      Dim strFiltro As String = ""

      oRow("PlanEEFFId") = -105
      oRow("PlanEEFFDes") = "EFECTIVO FINAL"
      moDataTable.Rows.Add(oRow)
      lngIndexEfectivo = moDataTable.Rows.Count - 1

      oRow = moDataTable.NewRow
      oRow("PlanEEFFId") = -106
      oRow("PlanEEFFDes") = "SALDO FINAL DISPONIBLE"
      moDataTable.Rows.Add(oRow)
      lngIndexSaldoFinal = moDataTable.Rows.Count - 1

      Call CompPlanEEFFLoad(mlngGestionId)

      If mboolIntervaloFecha Then
         strFiltro = "Fecha >= '" & ConvertDMY(mstrFechaIni) & "' AND Fecha <= '" & ConvertDMY(mstrFechaFin) & "' AND "
      End If

      oRow = moDataTable.NewRow
      oRow("PlanEEFFId") = -107
      oRow("PlanEEFFDes") = "CAJA"
      oRow("PlanEEFFCta") = ""
      Call PlanCtaFind(oRow("PlanEEFFDes"), oRow("PlanEEFFCta"))

      Dim decDebeBs As Decimal = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(DebeBs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CAJA)))
      Dim decDebeUs As Decimal = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(DebeUs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CAJA)))
      Dim decHaberBs As Decimal = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(HaberBs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CAJA)))
      Dim decHaberUs As Decimal = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(HaberUs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CAJA)))

      mdecCajaInicialBs += (decDebeBs - decHaberBs)
      mdecCajaInicialUs += (decDebeUs - decHaberUs)
      oRow("SaldoBs") = mdecCajaInicialBs
      oRow("SaldoUs") = mdecCajaInicialUs

      moDataTable.Rows.Add(oRow)

      oRow = moDataTable.NewRow
      oRow("PlanEEFFId") = -108
      oRow("PlanEEFFDes") = "BANCO"
      oRow("PlanEEFFCta") = ""
      Call PlanCtaFind(oRow("PlanEEFFDes"), oRow("PlanEEFFCta"))

      decDebeBs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(DebeBs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CUENTA_CORRIENTE)))
      decDebeUs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(DebeUs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CUENTA_CORRIENTE)))
      decHaberBs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(HaberBs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CUENTA_CORRIENTE)))
      decHaberUs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("SUM(HaberUs)", strFiltro & "TipoPlanId = " & NumberToField(clsTipoPlan.CUENTA_CORRIENTE)))

      mdecBancoInicialBs += (decDebeBs - decHaberBs)
      mdecBancoInicialUs += (decDebeUs - decHaberUs)
      oRow("SaldoBs") = mdecBancoInicialBs
      oRow("SaldoUs") = mdecBancoInicialUs

      moDataTable.Rows.Add(oRow)

      oRow = moDataTable.Rows(lngIndexSaldoFinal)
      oRow("SaldoBs") = mdecCajaInicialBs + mdecBancoInicialBs
      oRow("SaldoUs") = mdecCajaInicialUs + mdecBancoInicialUs

      oRow = moDataTable.Rows(lngIndexEfectivo)
      oRow("SaldoBs") = mdecCajaInicialBs + mdecBancoInicialBs
      oRow("SaldoUs") = mdecCajaInicialUs + mdecBancoInicialUs

      moDataTable.Rows.Add(GetRowNull())
   End Sub

   Private Sub grdMainLoad(ByVal lngPlanEEFFPadreId As Long, ByVal strTab As String)
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      Try
         With oPlanEEFF
            .SelectFilter = clsPlanEEFF.SelectFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.GridEstado
            .OrderByFilter = clsPlanEEFF.OrderByFilters.Orden
            .EmpresaId = mlngEmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId
            If lngPlanEEFFPadreId = 0 Then .Nivel = 2

            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               strTab = strTab & "     "
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  Dim lngIndex As Long = AddRowDataTable(oRow, strTab)
                  grdMainLoad(ToLong(oRow("PlanEEFFId")), strTab)
                  UpdateRowDataTable(lngIndex)

                  If ToLong(oRow("EsAna")) = 0 And ToLong(oRow("TipoEEFFId")) = clsTipoComp.EGRESO And ToLong(oRow("Nivel")) = 2 Then
                     Call moDataTable.Rows.Add(GetSubFooter(ToLong(oRow("Orden"))))
                     moDataTable.Rows.Add(GetRowNull())
                  End If
               Next
               strTab = Mid(strTab, 1, Len(strTab) - 5)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function PlanEEFFIdEgresoFind(ByVal lngTipoEEFFId As Long, ByVal lngOrden As Long, ByVal lngNivel As Long) As Long
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      PlanEEFFIdEgresoFind = 0
      Try
         With oPlanEEFF
            .SelectFilter = clsPlanEEFF.SelectFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.TipoEEFFIdOrdenNivel
            .EmpresaId = mlngEmpresaId
            .TipoEEFFId = lngTipoEEFFId
            .Orden = lngOrden
            .Nivel = lngNivel

            If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               PlanEEFFIdEgresoFind = ToLong(.DataSet.Tables(.TableName).Rows(0)("PlanEEFFId"))
            End If
         End With
      Catch ex As Exception
         MessageBox.Show(Me.Text, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanEEFF.Dispose()
      End Try
   End Function

   Private Function CompPlanEEFFLoad(ByVal lngGestionId As Long) As Boolean
      CompPlanEEFFLoad = False
      Try
         With moCompPlanEEFF
            .SelectFilter = clsCompPlanEEFF.SelectFilters.FlujoEfectivoTipoPlan
            .WhereFilter = clsCompPlanEEFF.WhereFilters.FlujoEfectivoTipoPlan
            .OrderByFilter = clsCompPlanEEFF.OrderByFilters.FlujoEfectivo
            .EmpresaId = mlngEmpresaId
            .GestionId = lngGestionId
            .LastUpdateId = ""
            .CompPlanEEFFId = 0
            .Aux = mstrTipoAsientoId
            If .Open Then
               Return True
            End If
         End With
      Catch ex As Exception
         MessageBox.Show(Me.Text, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   Private Function PlanEEFFLoad() As Boolean
      PlanEEFFLoad = False
      Try
         With moPlanEEFF
            .SelectFilter = clsPlanEEFF.SelectFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.TipoEEFFIdOrdenNivel
            .OrderByFilter = clsPlanEEFF.OrderByFilters.Orden
            .EmpresaId = mlngEmpresaId
            .Nivel = 2

            If .Open Then
               Return True
            End If
         End With
      Catch ex As Exception
         MessageBox.Show(Me.Text, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   Private Sub UpdateRowDataTable(ByVal lngIndex As Long)
      Dim datatableCompDet As DataTable
      Dim oRow As DataRow
      oRow = moDataTable.Rows(lngIndex)
      Dim strFiltro As String = ""
      Dim decDebeBs As Decimal = 0
      Dim decHaberBs As Decimal = 0
      Dim decDebeUs As Decimal = 0
      Dim decHaberUs As Decimal = 0

      If ToBoolean(oRow("EsAna")) Then
         strFiltro = "PlanEEFFId = " & ToLong(oRow("PlanEEFFId"))
         If mboolIntervaloFecha Then
            strFiltro &= " AND (Fecha >= '" & ConvertDMY(mstrFechaIni) & "' AND Fecha <= '" & ConvertDMY(mstrFechaFin) & "')"
         End If

         strFiltro &= " AND TipoAsientoId IN (" & mstrTipoAsientoId & ")"

         decDebeBs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("Sum(DebeBs)", strFiltro))
         decHaberBs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("Sum(HaberBs)", strFiltro))
         decDebeUs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("Sum(DebeUs)", strFiltro))
         decHaberUs = ToDecimal(moCompPlanEEFF.DataSet.Tables(moCompPlanEEFF.TableName).Compute("Sum(HaberUs)", strFiltro))

         oRow("SaldoBs") = decDebeBs - decHaberBs
         oRow("SaldoUs") = decDebeUs - decHaberUs
      Else
         strFiltro = "PlanEEFFPadreId = " & ToLong(oRow("PlanEEFFId"))
         Dim decSaldoBs As Decimal = ToDecimal(moDataTable.Compute("Sum(SaldoBs)", strFiltro))
         Dim decSaldoUs As Decimal = ToDecimal(moDataTable.Compute("Sum(SaldoUs)", strFiltro))

         oRow("SaldoBs") = decSaldoBs
         oRow("SaldoUs") = decSaldoUs
      End If
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Estado de Flujos de Efectivo"

         .RootTable.Columns("PlanEEFFId").Visible = False

         .RootTable.Columns("PlanEEFFCta").Caption = "Cuenta"
         .RootTable.Columns("PlanEEFFCta").Width = 80
         .RootTable.Columns("PlanEEFFCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanEEFFCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanEEFFDes").Caption = "Descripción"
         .RootTable.Columns("PlanEEFFDes").Width = 500
         .RootTable.Columns("PlanEEFFDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanEEFFDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoEEFFId").Visible = False
         .RootTable.Columns("PlanEEFFPadreId").Visible = False

         .RootTable.Columns("Nivel").Visible = False
         .RootTable.Columns("Orden").Visible = False
         .RootTable.Columns("EsAna").Visible = False

         If mlngMonedaId = 1 Then
            .RootTable.Columns("SaldoBs").Caption = "Saldo Bs."
            .RootTable.Columns("SaldoBs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoBs").Width = 100
            .RootTable.Columns("SaldoBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoUs").Visible = False

         ElseIf mlngMonedaId = 2 Then
            ' .RootTable.Columns("DebeUs").Caption = "Debe Us"

            .RootTable.Columns("SaldoUs").Caption = "Saldo Us."
            .RootTable.Columns("SaldoUs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoUs").Width = 100
            .RootTable.Columns("SaldoUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoBs").Visible = False

         ElseIf mlngMonedaId = 4 Then
            .RootTable.Columns("SaldoBs").Caption = "Saldo Bs."
            .RootTable.Columns("SaldoBs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoBs").Width = 100
            .RootTable.Columns("SaldoBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoUs").Caption = "Saldo Us."
            .RootTable.Columns("SaldoUs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoUs").Width = 100
            .RootTable.Columns("SaldoUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         End If
      End With

      Call AddConditionalFormatting()
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

#Region "Metodos Auxiliares"
   Private Function MonedaDesFind(ByVal lngMonedaId As Long) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      MonedaDesFind = ""
      Try
         With oMoneda
            .MonedaId = lngMonedaId

            If .FindByPK Then
               MonedaDesFind = .MonedaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oMoneda.Dispose()
      End Try
   End Function
#End Region

   Private Sub frmEstadoFlujoEfectivo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompPlanEEFF.Dispose()
      moPlanEEFF.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub frmEstadoFlujoEfectivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            'Call DataEdit()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub
End Class
