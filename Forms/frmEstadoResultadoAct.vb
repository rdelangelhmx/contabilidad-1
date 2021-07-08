Public Class frmEstadoResultadoAct
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan

   Private moListaTipoAsiento As New Queue
   Private moListaCentroCostoDet As New Queue
   Private mstrTipoAsientoId As String
   Private mstrCentroCostoDetId As String
   Private mstrCentroCostoDetDes As String
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

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moDataTableAux As DataTable

   Private mdecHaberBs As Decimal
   Private mdecDebeBs As Decimal
   Private mdecHaberUs As Decimal
   Private mdecDebeUs As Decimal

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

   Property ListaCentroCostoDet() As Queue
      Get
         Return moListaCentroCostoDet
      End Get

      Set(ByVal Value As Queue)
         moListaCentroCostoDet = Value
      End Set
   End Property

   Public Property CentroCostoDetDes() As String
      Get
         Return mstrCentroCostoDetDes
      End Get
      Set(ByVal value As String)
         mstrCentroCostoDetDes = value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoResultadoAct))
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator3, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(336, 28)
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
      'frmEstadoResultadoAct
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmEstadoResultadoAct"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Estado de Resultados"
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

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmEstadoResultadoAct_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmEstadoResultadoAct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
   End Sub

   Private Sub frmLibroMayorLoad()
      Dim oLista As New Queue

      If mlngCentroCostoId = 0 Then
         Dim lngPlanId As Long

         If (ToLong(grdMain.GetValue("PlanId")) > 0) And (ToBoolean(grdMain.GetValue("EsAna"))) Then
            oLista.Enqueue(ToLong(grdMain.GetValue("PlanId")))
            lngPlanId = ToLong(grdMain.GetValue("PlanId"))
         End If

         If oLista.Count Then
            Dim frm As New frmLibroMayor

            With frm
               .EmpresaId = mlngEmpresaId
               .GestionId = clsAppInfo.GestionId
               .MonedaId = mlngMonedaId
               .SaldoAnterior = False
               .Cuenta = True
               .SinMovimiento = False
               .IntervaloFecha = mboolIntervaloFecha
               .FechaIni = ToDate(mdatFechaIniInt)
               .FechaFin = ToDate(mdatFechaFinInt)
               .OrdenarFecha = True
               .Lista = oLista
               .SinFac = mboolSinFac
               .ConFac = mboolConFac
               .ListaTipoAsiento = moListaTipoAsiento

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
         oLista.Enqueue(mlngCentroCostoId)

         If moListaCentroCostoDet.Count = 0 Then
            If oLista.Count Then
               If (ToLong(grdMain.GetValue("PlanId")) > 0) And (ToBoolean(grdMain.GetValue("EsAna"))) Then
                  Dim frm As New frmLibroCentroCosto

                  With frm
                     .EmpresaId = mlngEmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .MonedaId = mlngMonedaId
                     .PlanId = ToLong(grdMain.GetValue("PlanId"))
                     .SaldoAnterior = False
                     .Cuenta = True
                     .IncluirDetalle = True
                     .IntervaloFecha = mboolIntervaloFecha
                     .FechaIni = ToDate(mdatFechaIniInt)
                     .FechaFin = ToDate(mdatFechaFinInt)
                     .OrdenarFecha = True
                     .Lista = oLista
                     .SinFac = mboolSinFac
                     .ConFac = mboolConFac

                     .MdiParent = Me.MdiParent
                     .Show()

                     Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & PlanDesFind(ToLong(grdMain.GetValue("PlanId"))) & "; CC: " & CentroCostoDesFind(mlngCentroCostoId))
                  End With
               Else
                  MessageBox.Show("Cuenta Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Debe Seleccionar al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            Dim oListaAct As New Queue
            For Each CentroCostoDetId In moListaCentroCostoDet
               oListaAct.Enqueue(CentroCostoDetId)
            Next

            Dim frm As New frmLibroCentroCostoDetAct

            With frm
               .EmpresaId = mlngEmpresaId
               .GestionId = clsAppInfo.GestionId
               .CentroCostoId = mlngCentroCostoId
               .MonedaId = mlngMonedaId
               .Cuenta = True
               .IncluirDetalle = True
               .SaldoCero = False
               .IntervaloFecha = mboolIntervaloFecha
               .FechaIni = ToDate(mdatFechaIniInt)
               .FechaFin = ToDate(mdatFechaFinInt)
               .SinFac = mboolSinFac
               .ConFac = mboolConFac
               .ListaTipoAsiento = moListaTipoAsiento
               .Lista = oListaAct
               .MdiParent = Me.MdiParent
               .Show()

               Dim strAct As String = ""
               For Each ActId In oListaAct
                  strAct &= CentroCostoDetDesFind(ActId) & ", "
               Next
               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & PlanDesFind(ToLong(grdMain.GetValue("PlanId"))) & "; CC: " & CentroCostoDesFind(mlngCentroCostoId) & "; Act: " & strAct)
            End With
         End If
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

   Private Sub PrintReport()
      Dim rpt As New rptBalance1
      Dim strMonedaSigla As String

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moPlan.TableName))

      rpt.lblTitle.Text = "Estado de Resultados"
      rpt.Document.Name = "Estado de Resultados"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniInt) ' ConvertDMY(mstrFechaIni)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinInt) 'ConvertDMY(mstrFechaFin)

      If mlngCentroCostoId = 0 Then
         If mlngSucursalId = 0 Then
            rpt.lblCentroCosto.Visible = False
            rpt.txtCentroCosto.Visible = False
         Else
            rpt.lblCentroCosto.Text = "Sucursal"
            rpt.txtCentroCosto.Text = SucursalDesFind(mlngSucursalId)
         End If
      Else
         rpt.txtCentroCosto.Text = CentroCostoDesFind(mlngCentroCostoId)
         If Not String.IsNullOrEmpty(mstrCentroCostoDetDes) Then
            rpt.txtCentroCostoDetDes.Text = mstrCentroCostoDetDes
            rpt.txtCentroCostoDetDes.Visible = True
            rpt.lblCentroCostoDetDes.Visible = True
         End If
      End If

      If mlngMonedaId = 1 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId, strMonedaSigla)
         rpt.txtPlanDes.Width = 5

         rpt.lblCol03.Text = "General " & strMonedaSigla
         rpt.txtCol03.DataField = "GralBs"

         rpt.lblCol04.Text = "Detalle " & strMonedaSigla
         rpt.txtCol04.DataField = "GralBsDet"

         rpt.txtCol01.Visible = False
         rpt.txtCol02.Visible = False

      ElseIf mlngMonedaId = 2 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId, strMonedaSigla)
         rpt.txtPlanDes.Width = 5

         rpt.lblCol03.Text = "General " & strMonedaSigla
         rpt.txtCol03.DataField = "GralUs"

         rpt.lblCol04.Text = "Detalle " & strMonedaSigla
         rpt.txtCol04.DataField = "GralUsDet"

         rpt.txtCol01.Visible = False
         rpt.txtCol02.Visible = False

      ElseIf mlngMonedaId = 4 Then
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
      End If

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub frmEstadoResultadoAct_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
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

   Private Function CentroCostoDetIdListaLoad() As String
      Dim strCentroCostoDetId As String = String.Empty
      Dim i As Integer = 0

      CentroCostoDetIdListaLoad = 0
      For Each lngCentroCostoDetId As Long In moListaCentroCostoDet
         i += 1

         If i < moListaCentroCostoDet.Count Then
            strCentroCostoDetId &= ToStr(lngCentroCostoDetId) & ", "

         Else
            strCentroCostoDetId &= ToStr(lngCentroCostoDetId)
         End If
      Next

      If strCentroCostoDetId = "-1" Then
         Return ""

      ElseIf i = 1 Then
         Return ToLong(moListaCentroCostoDet(0))

      Else
         Return strCentroCostoDetId
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

   Private Function SucursalDesFind(ByVal lngSucursalId As Long) As String
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)

      SucursalDesFind = ""

      Try
         With oSucursal
            .SucursalId = lngSucursalId

            If .FindByPK Then
               SucursalDesFind = .SucursalDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()

      End Try
   End Function

   Private Function CentroCostoDetDesFind(ByVal lngCentroCostoDetId As Long) As String
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)

      CentroCostoDetDesFind = ""

      Try
         With oCentroCostoDet
            .CentroCostoDetId = lngCentroCostoDetId

            If .FindByPK Then
               CentroCostoDetDesFind = .CentroCostoDetDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCostoDet.Dispose()

      End Try
   End Function
#End Region

#Region " ESTADO RESULTADO "
#Region " DataSet-Estado Resultado "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")

      moDataTable = moDataSet.Tables.Add(moPlan.TableName)
      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EsAna", Type.GetType("System.Byte"))
      moDataTable.Columns.Add("SucCCOID", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("GralBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralBsDet", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralBsGes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUsDet", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUsGes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Nivel", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanPadreId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoGrupoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SW", Type.GetType("System.Int32"))

      moDataTableAux = moDataSet.Tables.Add(moPlan.TableName & "Aux")
      moDataTableAux.Columns.Add("GralBs", Type.GetType("System.Decimal"))
      moDataTableAux.Columns.Add("GralUs", Type.GetType("System.Decimal"))
      moDataTableAux.Columns.Add("PlanPadreId", Type.GetType("System.Int32"))
   End Sub

   Private Function AddRowDataTable(ByVal oDataRow As DataRow, ByVal strTab As String) As Long
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      If ToLong(oDataRow("TipoGrupoId")) = 4 Or ToLong(oDataRow("TipoGrupoId")) = 5 Or ToLong(oDataRow("TipoGrupoId")) = 6 Then
         oRow("PlanId") = oDataRow("PlanId")
         oRow("EsAna") = oDataRow("EsAna")
         oRow("SucCCOId") = oDataRow("SucCCOId")
         oRow("PlanCta") = oDataRow("PlanCta")
         oRow("Nivel") = oDataRow("Nivel")
         oRow("PlanPadreId") = oDataRow("PlanPadreId")
         oRow("TipoGrupoId") = oDataRow("TipoGrupoId")
         oRow("PlanDes") = strTab & oDataRow("PlanDes")

         moDataTable.Rows.Add(oRow)
         AddRowDataTable = moDataTable.Rows.Count - 1

         'If ToBoolean(oDataRow("TieneAnaAdd")) And mboolIncluirPlanAdd And ToBoolean(oDataRow("MostrarAnaAdd")) Then
         '   Call PlanAddLoad(oDataRow("PlanId"), strTab & "     ", ToLong(oDataRow("Nivel")), ToLong(oRow("TipoGrupoId")))
         'End If
      End If
   End Function

   Private Sub UpdateRowDataTable(ByVal lngIndex As Long)
      Dim datatableCompDet As DataTable
      Dim oRow As DataRow
      oRow = moDataTable.Rows(lngIndex)

      If ToBoolean(oRow("EsAna")) Then
         If (mlngSucursalId > 0 And ToLong(oRow("SucCCOId")) = 1) Or _
         (mlngCentroCostoId > 0 And ToLong(oRow("SucCCOId")) = 2) Or _
         (mlngCentroCostoId = 0 And mlngSucursalId = 0) Then

            datatableCompDet = LoadCompDet(ToLong(oRow("PlanId")))
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

                  If ToLong(oRow("TipoGrupoId")) = 1 Or ToLong(oRow("TipoGrupoId")) = 5 Or ToLong(oRow("TipoGrupoId")) = 6 Or ToLong(oRow("TipoGrupoId")) = 7 Then
                     If index = 1 Then
                        oRow("GralBsDet") = ToDecimal(mdecDebeBs - mdecHaberBs)
                        oRow("GralUsDet") = ToDecimal(mdecDebeUs - mdecHaberUs)
                     Else
                        oRow("GralBsGes") = ToDecimal(mdecDebeBs - mdecHaberBs)
                        oRow("GralUsGes") = ToDecimal(mdecDebeUs - mdecHaberUs)
                     End If
                  ElseIf ToLong(oRow("TipoGrupoId")) = 2 Or ToLong(oRow("TipoGrupoId")) = 3 Or ToLong(oRow("TipoGrupoId")) = 4 Or ToLong(oRow("TipoGrupoId")) = 8 Then
                     If index = 1 Then
                        oRow("GralBsDet") = ToDecimal(mdecHaberBs - mdecDebeBs)
                        oRow("GralUsDet") = ToDecimal(mdecHaberUs - mdecDebeUs)
                     Else
                        oRow("GralBsGes") = ToDecimal(mdecHaberBs - mdecDebeBs)
                        oRow("GralUsGes") = ToDecimal(mdecHaberUs - mdecDebeUs)
                     End If
                  End If
               Next
               'temp
               'If Math.Abs(ToDecimal(oRow("GralBsDet"))) < 0.05 And Math.Abs(ToDecimal(oRow("GralUsDet"))) < 0.05 Then
               '   If Math.Abs(ToDecimal(oRow("GralBsGes"))) > 0.05 Or Math.Abs(ToDecimal(oRow("GralUsGes"))) > 0.05 Then
               '      AddRowDataTableAux(oRow)
               '   End If

               '   DeleteCuentaAndAnaliticoAdd(lngIndex, ToLong(oRow("PlanId")))
               'End If
               If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsDet")))) = 0 And ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsDet")))) = 0 Then
                  If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsGes")))) > 0 Or ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsGes")))) > 0 Then
                     AddRowDataTableAux(oRow)
                  End If

                  DeleteCuentaAndAnaliticoAdd(lngIndex, ToLong(oRow("PlanId")))
               End If
            Else
               DeleteCuentaAndAnaliticoAdd(lngIndex, ToLong(oRow("PlanId")))
            End If
         Else
            DeleteCuentaAndAnaliticoAdd(lngIndex, ToLong(oRow("PlanId")))
         End If
      Else
         oRow("GralBs") = ToDecimal(moDataTable.Compute("Sum(GralBsDet)", "PlanPadreId = " & ToLong(oRow("PlanId")))) + ToDecimal(moDataTable.Compute("Sum(GralBs)", "PlanPadreId = " & ToLong(oRow("PlanId")))) ' ToDecimal(decTotalNivelBs)
         oRow("GralUs") = ToDecimal(moDataTable.Compute("Sum(GralUsDet)", "PlanPadreId = " & ToLong(oRow("PlanId")))) + ToDecimal(moDataTable.Compute("Sum(GralUs)", "PlanPadreId = " & ToLong(oRow("PlanId")))) ' ToDecimal(decTotalNivelBs)' ToDecimal(decTotalNivelUs)
         oRow("GralBsGes") = ToDecimal(moDataTable.Compute("Sum(GralBsGes)", "PlanPadreId = " & ToLong(oRow("PlanId")))) + ToDecimal(moDataTableAux.Compute("Sum(GralBs)", "PlanPadreId = " & ToLong(oRow("PlanId"))))
         oRow("GralUsGes") = ToDecimal(moDataTable.Compute("Sum(GralUsGes)", "PlanPadreId = " & ToLong(oRow("PlanId")))) + ToDecimal(moDataTableAux.Compute("Sum(GralUs)", "PlanPadreId = " & ToLong(oRow("PlanId"))))
         'temp
         'If Math.Abs(ToDecimal(oRow("GralBs"))) < 0.05 And Math.Abs(ToDecimal(oRow("GralUs"))) < 0.05 Then
         '   If Not TieneMovimiento(ToLong(oRow("PlanId")), ToLong(oRow("Nivel"))) Then
         '      If Math.Abs(ToDecimal(oRow("GralBsGes"))) > 0.05 Or Math.Abs(ToDecimal(oRow("GralUsGes"))) > 0.05 Then
         '         AddRowDataTableAux(oRow)
         '      End If
         '      moDataTable.Rows.RemoveAt(lngIndex)
         '   Else
         '      oRow("SW") = ToLong(1)
         '   End If
         'End If
         If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBs")))) = 0 And ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUs")))) = 0 Then
            If Not TieneMovimiento(ToLong(oRow("PlanId")), ToLong(oRow("Nivel"))) Then
               If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsGes")))) > 0 Or ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsGes")))) > 0 Then
                  AddRowDataTableAux(oRow)
               End If
               moDataTable.Rows.RemoveAt(lngIndex)
            Else
               oRow("SW") = ToLong(1)
            End If
         End If
      End If
   End Sub

   Private Sub AddRowDataTableAux(ByVal oDataRow As DataRow)
      Dim oRowAux As DataRow
      oRowAux = moDataTableAux.NewRow
      oRowAux("GralBs") = ToDecimal(oDataRow("GralBsGes"))
      oRowAux("GralUs") = ToDecimal(oDataRow("GralUsGes"))
      oRowAux("PlanPadreId") = oDataRow("PlanPadreId")

      moDataTableAux.Rows.Add(oRowAux)
   End Sub

   Private Sub addTotalCuentaAgrupadora(ByVal lngPlanId As Long, ByVal strPlanDes As String, ByVal strPlanCta As String)
      Dim decTotalNivelUs As Decimal
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanDes") = "TOTAL " & strPlanDes

      oRow("GralBsDet") = ToDecimal(moDataTable.Compute("Sum(GralBsDet)", "PlanPadreId = " & lngPlanId)) + ToDecimal(moDataTable.Compute("Sum(GralBs)", "PlanPadreId = " & lngPlanId)) ' ToDecimal(decTotalNivelBs) TotalNivel(decTotalNivelUs, lngPlanId)
      oRow("GralUsDet") = ToDecimal(moDataTable.Compute("Sum(GralUsDet)", "PlanPadreId = " & lngPlanId)) + ToDecimal(moDataTable.Compute("Sum(GralUs)", "PlanPadreId = " & lngPlanId)) ' ToDecimal(decTotalNivelBs) TotalNivel(decTotalNivelUs, lngPlanId) decTotalNivelUs

      oRow("GralBsGes") = ToDecimal(moDataTable.Compute("Sum(GralBsGes)", "PlanPadreId = " & lngPlanId)) + ToDecimal(moDataTableAux.Compute("Sum(GralBs)", "PlanPadreId = " & lngPlanId))
      oRow("GralUsGes") = ToDecimal(moDataTable.Compute("Sum(GralUsGes)", "PlanPadreId = " & lngPlanId)) + ToDecimal(moDataTableAux.Compute("Sum(GralUs)", "PlanPadreId = " & lngPlanId))

      oRow("Nivel") = mlngNivel
      moDataTable.Rows.Add(oRow)
   End Sub

   Private Sub addEstadoResultado()
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanDes") = "RESULTADO DEL EJERCICIO"
      For Each row In moDataTable.Rows
         If ToLong(row("PlanPadreId")) = 0 And ToStr(row("PlanCta")).Equals("4") Then
            oRow("GralBsDet") = ToDecimal(oRow("GralBsDet")) + ToDecimal(row("GralBs"))
            oRow("GralUsDet") = ToDecimal(oRow("GralUsDet")) + ToDecimal(row("GralUs"))
         ElseIf ToLong(row("PlanPadreId")) = 0 And (ToStr(row("PlanCta")).Equals("5") _
         Or ToStr(row("PlanCta")).Equals("6")) Then
            oRow("GralBsDet") = ToDecimal(oRow("GralBsDet")) - ToDecimal(row("GralBs"))
            oRow("GralUsDet") = ToDecimal(oRow("GralUsDet")) - ToDecimal(row("GralUs"))
         End If
      Next
      moDataTable.Rows.Add(oRow)
   End Sub

   Private Sub GetRowNull()
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      oRow("Nivel") = mlngNivel
      moDataTable.Rows.Add(oRow)
   End Sub
#End Region

#Region " Metodo-Estado Resultado "
   Private Sub DeleteCuentaAndAnaliticoAdd(ByVal lngIndex As Long, ByVal lngPlanId As Long)
      moDataTable.Rows.RemoveAt(lngIndex)

      moDataTable.AcceptChanges()
      Dim lngConer As Long = 0
      For Each row In moDataTable.Rows
         If ToLong(row("PlanId")) = lngPlanId Then
            moDataTable.Rows(lngConer).Delete()
         End If
         lngConer += 1
      Next
      moDataTable.AcceptChanges()
   End Sub

   Private Function LoadCompDet(ByVal lngPlanId As Long) As DataTable
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      LoadCompDet = Nothing
      Try
         With oCompDet
            If moListaCentroCostoDet.Count > 0 Then
               .SelectFilter = clsCompDet.SelectFilters.AllCompCentroCostoDet
               .WhereFilter = clsCompDet.WhereFilters.RowSumFechaCentroCostoDet
            Else
               .SelectFilter = clsCompDet.SelectFilters.AllComp
               .WhereFilter = clsCompDet.WhereFilters.RowSumFecha
            End If
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
            .LastUpdateId = mstrCentroCostoDetId 'Lista CentroCostoDetId
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

   Private Function TieneMovimiento(ByVal lngPlanId As Long, ByVal lngNivel As Long) As Boolean
      TieneMovimiento = False
      For Each row In moDataTable.Rows
         If ToLong(row("PlanPadreId")) = lngPlanId And ToLong(row("Nivel")) = lngNivel + 1 Then
            If ToDecimalMinor(Math.Abs(ToDecimal(row("GralBsDet")) + ToDecimal(row("GralBs")))) > 0 Or _
            ToDecimalMinor(Math.Abs(ToDecimal(row("GralUsDet")) + ToDecimal(row("GralUs")))) > 0 Or _
            ToLong(row("SW")) = 1 Then
               TieneMovimiento = True
               Exit For
            End If
            'temp
            'If Math.Abs(ToDecimal(row("GralBsDet")) + ToDecimal(row("GralBs"))) > 0.05 Or _
            'Math.Abs(ToDecimal(row("GralUsDet")) + ToDecimal(row("GralUs"))) > 0.05 Or _
            'ToLong(row("SW")) = 1 Then
            '   TieneMovimiento = True
            '   Exit For
            'End If
         End If
      Next
   End Function

   Private Function SaldoPlanAddBs(ByVal lngPlanId As Long, ByVal lngPlanAddId As Long, _
         ByRef decSaldoUs As Decimal, ByVal lngTipoGrupoId As Long) As Decimal
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0

      decSaldoUs = 0
      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayorFecha

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .PlanAddId = lngPlanAddId
            .Fecha = ToDate(mdatFechaIniInt) ' mstrFechaIni
            .LastUpdateId = ToDate(mdatFechaFinInt) ' mstrFechaFin
            .CompId = mlngCentroCostoId 'CentroCostoId
            .CompDetId = mlngSucursalId 'SucursalId
            .MonedaId = ToBoolean(mboolSinFac) 'SinFac
            .EstadoId = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'temp
            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If lngTipoGrupoId = 1 Or lngTipoGrupoId = 5 Or lngTipoGrupoId = 6 Or lngTipoGrupoId = 7 Then
                     decSaldoBs += ToDecimal(oRow("DebeBs") - oRow("HaberBs"))
                     decSaldoUs += ToDecimal(oRow("DebeUs") - oRow("HaberUs"))

                  ElseIf lngTipoGrupoId = 2 Or lngTipoGrupoId = 3 Or lngTipoGrupoId = 4 Or lngTipoGrupoId = 8 Then
                     decSaldoBs += ToDecimal(oRow("HaberBs") - oRow("DebeBs"))
                     decSaldoUs += ToDecimal(oRow("HaberUs") - oRow("DebeUs"))
                  End If
               Next

               SaldoPlanAddBs = decSaldoBs
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompPlanAdd.Dispose()
      End Try
   End Function

   Private Sub PlanAddLoad(ByVal lngPlanId As Long, ByVal strTab As String, ByVal lngNivel As Long _
             , ByVal lngTipoGrupoId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Dim oRow As DataRow

      Dim decPlanAddBs As Decimal
      Dim decPlanAddUs As Decimal
      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.All
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes

            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanId
            If .Open Then
               Do While .Read
                  decPlanAddBs = SaldoPlanAddBs(.PlanId, .PlanAddId, decPlanAddUs, lngTipoGrupoId)
                  'temp
                  'If Math.Abs(decPlanAddBs) > 0.05 And Math.Abs(decPlanAddUs) > 0.05 Then
                  If ToDecimalMinor(Math.Abs(decPlanAddBs)) > 0 And ToDecimalMinor(Math.Abs(decPlanAddUs)) > 0 Then
                     oRow = moDataTable.NewRow

                     oRow("PlanId") = lngPlanId
                     oRow("EsAna") = 1
                     oRow("PlanCta") = .PlanAddCta
                     oRow("PlanDes") = strTab & .PlanAddDes
                     oRow("GralBsDet") = decPlanAddBs
                     oRow("GralUsDet") = decPlanAddUs
                     oRow("Nivel") = lngNivel

                     moDataTable.Rows.Add(oRow)
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

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("PlanId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanId"), Janus.Windows.GridEX.ConditionOperator.Equal, System.Convert.DBNull)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EsAna"), Janus.Windows.GridEX.ConditionOperator.Equal, False)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " Grid-Balance "
   Private Sub grdMainLoad()
      Call moDataSetInit()

      mstrTipoAsientoId = TipoAsientoIdListaLoad()
      mstrCentroCostoDetId = CentroCostoDetIdListaLoad()
      Call grdMainLoad(0, "")

      Call addEstadoResultado()

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

   Private Sub grdMainLoad(ByVal lngPlanPadreId As Long, ByVal strTab As String)
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
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
                  Dim lngIndex As Long = AddRowDataTable(oRow, strTab)
                  grdMainLoad(ToLong(oRow("PlanId")), strTab)
                  UpdateRowDataTable(lngIndex)

                  If ToLong(oRow("PlanPadreId")) = 0 Then
                     Call addTotalCuentaAgrupadora(ToLong(oRow("PlanId")), ToStr(oRow("PlanDes")), ToStr(oRow("PlanCta")))
                     Call GetRowNull()
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

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainInit()
      Dim strMonedaSigla As String

      With grdMain
         ebrMain.Groups(0).Text = "Estado de Resultados"

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("SW").Visible = False

         .RootTable.Columns("TipoGrupoId").Visible = False

         .RootTable.Columns("EsAna").Visible = False

         .RootTable.Columns("SucCCOId").Visible = False

         .RootTable.Columns("PlanCta").Caption = "Código"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripción"
         .RootTable.Columns("PlanDes").Width = 370
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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

         .RootTable.Columns("Nivel").Visible = False
         .RootTable.Columns("PlanPadreId").Visible = False

      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call frmLibroMayorLoad()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmEstadoResultadoAct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmLibroMayorLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub
#End Region
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
