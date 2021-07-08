Public Class frmSumaSaldoAnalisisResu
   Inherits System.Windows.Forms.Form

   Private moListaTipoAsiento As New Queue
   Private mstrTipoAsientoId As String

   Private moCompDet As clsCompDet
   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolUltimoPeriodo As Boolean
   Private mboolSaldoAnterior As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean
   Private mboolSaldoCero As Boolean

   Private mdecSaldoPlanBs As Decimal
   Private mdecSaldoPlanUs As Decimal
   Private mlngGrupo As Long
   Private moPlan As clsPlan
   Private mstrMonedaDesBoliviano As String
   Private mstrMonedaDesDolares As String

   Private mlngPlanIdBaja As Long
   Private mstrPlanCtaPadreActivoFijo As String

   Private moDataSet As DataSet
   Friend WithEvents Export1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Export As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter
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

   Property UltimoPeriodo() As Boolean
      Get
         Return mboolUltimoPeriodo
      End Get

      Set(ByVal Value As Boolean)
         mboolUltimoPeriodo = Value
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

   Property SaldoCero() As Boolean
      Get
         Return mboolSaldoCero
      End Get

      Set(ByVal Value As Boolean)
         mboolSaldoCero = Value
      End Set
   End Property

   Public Property PlanIdBaja() As Long
      Get
         Return mlngPlanIdBaja
      End Get
      Set(ByVal value As Long)
         mlngPlanIdBaja = value
      End Set
   End Property

   Public Property PlanCtaPadreActivoFijo() As String
      Get
         Return mstrPlanCtaPadreActivoFijo
      End Get
      Set(ByVal value As String)
         mstrPlanCtaPadreActivoFijo = value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSumaSaldoAnalisisResu))
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
      Me.Export1 = New Janus.Windows.UI.CommandBars.UICommand("Export")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Export = New Janus.Windows.UI.CommandBars.UICommand("Export")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.gexMain = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
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
      Me.grdMain.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
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
      Me.uiBackground.TabIndex = 10
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
      Me.ilsMain.Images.SetKeyName(7, "Excel.JPG")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2, Me.Export})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("d6406ccf-5418-4fdc-87a0-25916acbbb03")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator3, Me.Export1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(245, 28)
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
      'Export1
      '
      Me.Export1.Key = "Export"
      Me.Export1.Name = "Export1"
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
      Me.Print.Visible = Janus.Windows.UI.InheritableBoolean.[False]
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
      'gexMain
      '
      Me.gexMain.GridEX = Me.grdMain
      '
      'frmSumaSaldoAnalisisResu
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmSumaSaldoAnalisisResu"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Balance de Sumas y Saldos para Análisis"
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

         Case "Export"
            Call ExportToExcelLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmSumaSaldoAnalisisResu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmSumaSaldoAnalisisResu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

      moCompDet = New clsCompDet(clsAppInfo.ConnectString)
      moPlan = New clsPlan(clsAppInfo.ConnectString)
   End Sub

#Region " Print-Report "
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

#End Region

   Private Sub ExportToExcelLoad()
      Dim sfd As New SaveFileDialog
      sfd.Title = "Export Report Document"
      sfd.AddExtension = True
      sfd.DefaultExt = "xls"
      sfd.Filter = "Microsoft Excel Files (*.xls)|*.xls"

      If sfd.ShowDialog() = DialogResult.OK Then
         Dim fs As New System.IO.FileStream(sfd.FileName, IO.FileMode.Create, IO.FileAccess.ReadWrite)

         gexMain.Export(fs)

         fs.Close()

         Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.EXPORTAR, "Exportar a Formato Excel")
      End If
   End Sub

   Private Function MonedaLoad() As Boolean
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)
      Try
         With oMoneda
            .SelectFilter = clsMoneda.SelectFilters.All
            .WhereFilter = clsMoneda.WhereFilters.None

            If .Open Then
               While .Read
                  If .MonedaId = clsMoneda.BOLIVIANOS Then
                     mstrMonedaDesBoliviano = .MonedaDes
                  ElseIf .MonedaId = clsMoneda.DOLARES Then
                     mstrMonedaDesDolares = .MonedaDes
                  End If

                  .MoveNext()
               End While
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oMoneda.Dispose()
      End Try
   End Function

   Private Sub frmSumaSaldoAnalisisResu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmLibroMayorLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmSumaSaldoAnalisisResu_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompDet.Dispose()
      Call ClearMemory()
   End Sub

#Region " SUMA-SALDO "
#Region " Metodo Suma-Saldo "
   Private Function TipoAsientoIdListaLoad(ByVal boolApertura As Boolean) As String
      Dim strTipoAsientoId As String = String.Empty
      If boolApertura Then
         strTipoAsientoId = "0,1,2"
      Else
         strTipoAsientoId = "0,2"
      End If
      Return strTipoAsientoId
   End Function

   Private Function ConMovimiento(ByVal lngPlanId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      ConMovimiento = False
      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.AllComp

            If mboolIntervaloFecha Then
               .WhereFilter = clsCompDet.WhereFilters.SinMovimientoFecha
               .Fecha = mstrFechaIni
               .CompDetDes = mstrFechaFin
            Else
               .WhereFilter = clsCompDet.WhereFilters.SinMovimiento
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId
            If .Find Then
               ConMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompDet.Dispose()
      End Try
   End Function

   Private Function PlanGrupoFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanGrupoFind = 0
      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanGrupoFind = .TipoGrupoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Function SumarSaldos(ByVal lngPlanId As Long, ByVal lngCol As Long, ByVal bytWhere As Byte) As Decimal
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      SumarSaldos = 0
      Try
         With oCompDet
            If lngCol = 1 Then
               .RowSumFilter = clsCompDet.RowSumFilters.DebeBs
            ElseIf lngCol = 2 Then
               .RowSumFilter = clsCompDet.RowSumFilters.HaberBs
            ElseIf lngCol = 3 Then
               .RowSumFilter = clsCompDet.RowSumFilters.DebeUs
            ElseIf lngCol = 4 Then
               .RowSumFilter = clsCompDet.RowSumFilters.HaberUs
            End If

            .WhereFilter = bytWhere
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .Fecha = mstrFechaIni
            .CompDetDes = mstrFechaFin
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
            SumarSaldos = .RowSum
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function PlanSaldoAnterior(ByVal lngPlanId As Long, ByVal lngMonedaId As Long) As Decimal
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decSaldo As Decimal

      decSaldo = 0
      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoAnterior
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .Fecha = mstrFechaIni
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If lngMonedaId = 1 Then
                     If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                        decSaldo += (ToDecimal(oRow("DebeBs")) - ToDecimal(oRow("HaberBs")))

                     ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                        decSaldo += (ToDecimal(oRow("HaberBs")) - ToDecimal(oRow("DebeBs")))
                     End If

                  ElseIf lngMonedaId = 2 Then
                     If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                        decSaldo += (ToDecimal(oRow("DebeUs")) - ToDecimal(oRow("HaberUs")))

                     ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                        decSaldo += (ToDecimal(oRow("HaberUs")) - ToDecimal(oRow("DebeUs")))
                     End If
                  End If
               Next

               PlanSaldoAnterior = decSaldo
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
      'Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      'fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Saldo"), Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
      'fc.FormatStyle.ForeColor = Color.DarkRed
      'grdMain.RootTable.FormatConditions.Add(fc)

      'fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanCta"), Janus.Windows.GridEX.ConditionOperator.Equal, System.Convert.DBNull)
      'fc.FormatStyle.ForeColor = Color.DarkBlue
      'grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

   Private Function GestionIdFind(ByVal strFecha As String, ByRef lngGestion As Long) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0
      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
            .FechaIni = ToDate(strFecha)
            .EstadoId = clsEstado.ABIERTO
            .EmpresaId = mlngEmpresaId

            If .Find Then
               GestionIdFind = .GestionId
               lngGestion = .Gestion
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oGestion.Dispose()
      End Try
   End Function

#Region " DataSet Suma-Saldo "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCompDet.TableName)

      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))

      Dim datFechaIni As Date = mstrFechaIni
      Dim datFechaFin As Date = mstrFechaFin

      While datFechaIni < datFechaFin
         Dim lngGestion As Long = 0
         Dim lngGestionId = GestionIdFind(datFechaIni, lngGestion)
         Dim datFechaIniGestion, datFechaFinGestion As Date
         Call GestionFecha(lngGestionId, datFechaIniGestion, datFechaFinGestion)

         If datFechaFinGestion > datFechaFin Then
            datFechaFinGestion = datFechaFin
         End If

         moDataTable.Columns.Add("Saldo" & lngGestion, Type.GetType("System.Decimal"))
         datFechaIni = datFechaFinGestion.AddDays(1)
      End While

      moDataTable.Columns.Add("SaldoAcu", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
   End Sub

   'Private Function GestionIdFind(ByVal strFecha As String) As Long
   '   Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

   '   GestionIdFind = 0
   '   Try
   '      With oGestion
   '         .SelectFilter = clsGestion.SelectFilters.All
   '         .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
   '         .FechaIni = ToDate(strFecha)
   '         .EstadoId = clsEstado.ABIERTO
   '         .EmpresaId = mlngEmpresaId

   '         If .Find Then
   '            GestionIdFind = .GestionId
   '         End If
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '   Finally
   '      oGestion.Dispose()
   '   End Try
   'End Function

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

   Private Function GetRow(ByVal lngPlanId As Long, ByRef orow As DataRow) As DataRow
      With moPlan
         Dim rowPlan = (From r In .DataSet.Tables(.TableName) Where r("PlanId") = lngPlanId Select r).FirstOrDefault

         orow("PlanId") = lngPlanId
         Dim strPlanCta As String = ToStr(rowPlan("PlanCta"))
         orow("PlanCta") = strPlanCta
         orow("PlanDes") = ToStr(rowPlan("PlanDes"))
      End With

      Return orow
   End Function

   'Public Function PlanPadreDesFind(ByVal strPlanCta As String) As String
   '   Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
   '   PlanPadreDesFind = ""
   '   Try
   '      With oPlan
   '         .SelectFilter = clsPlan.SelectFilters.All
   '         .WhereFilter = clsPlan.WhereFilters.PlanCta
   '         .EmpresaId = mlngEmpresaId
   '         .PlanCta = strPlanCta

   '         If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
   '            PlanPadreDesFind = ToStr(.DataSet.Tables(.TableName).Rows.Item(0)("PlanDes"))
   '         End If
   '      End With
   '   Catch ex As Exception
   '      Throw ex
   '   Finally
   '      oPlan.Dispose()
   '   End Try
   'End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
   End Function

   Private Function GetFooter(ByVal lngMonedaId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanCta") = "BALANCE"

      Dim datFechaIni As Date = mstrFechaIni
      Dim datFechaFin As Date = mstrFechaFin

      While datFechaIni < datFechaFin
         Dim lngGestion As Long = 0
         Dim lngGestionId = GestionIdFind(datFechaIni, lngGestion)
         Dim datFechaIniGestion, datFechaFinGestion As Date
         Call GestionFecha(lngGestionId, datFechaIniGestion, datFechaFinGestion)

         If datFechaFinGestion > datFechaFin Then
            datFechaFinGestion = datFechaFin
         End If

         oRow("Saldo" & lngGestion) = ToDecimal(moDataTable.Compute("SUM(Saldo" & lngGestion & ")", ""))
         datFechaIni = datFechaFinGestion.AddDays(1)
      End While

      oRow("SaldoAcu") = ToDecimal(moDataTable.Compute("SUM(SaldoAcu)", ""))

      Return oRow
   End Function
#End Region

#Region " Grid Suma-Saldo "

   Private Function LoadCompDet(ByVal lngPlanId As Long, ByVal datFechaIniInt As Date, ByVal datFechaFinInt As Date, ByVal bytWhere As Byte) As DataTable
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      LoadCompDet = Nothing
      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.AllComp
            .WhereFilter = bytWhere
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .CentroCostoId = 0 'mlngCentroCostoId
            .SucursalId = 0 'mlngSucursalId
            .Fecha = ToDate(datFechaIniInt)
            .CompDetDes = ToDate(datFechaFinInt)
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

   Private Function LoadCompDetActivoFijo(ByVal lngPlanId As Long, ByVal datFechaIniInt As Date, ByVal datFechaFinInt As Date) As DataTable
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.AllComp
            .WhereFilter = clsCompDet.WhereFilters.RowSumFechaconActivoFijo
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .CentroCostoId = 0 'mlngCentroCostoId
            .SucursalId = 0 'mlngSucursalId
            .Fecha = ToDate(datFechaIniInt)
            .CompDetDes = ToDate(datFechaFinInt)
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
            .LastUpdateId = " " & clsAppInfo.PlanCreId & ", " & clsAppInfo.PlanIUERetBieId & ", " & mlngPlanIdBaja
            If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               LoadCompDetActivoFijo = .DataSet.Tables(0)
            End If
         End With
      Catch ex As Exception
         Throw ex
      Finally
         oCompDet.Dispose()
      End Try
   End Function

   Private Function SaldoGestionBs(ByVal lngPlanId As Long, ByVal datFechaIni As Date, ByVal datFechaFin As Date, ByRef decSaldoUs As Decimal) As Decimal
      SaldoGestionBs = 0
      Dim datatableCompDet As DataTable
      Dim decDebeBs As Decimal = 0
      Dim decHaberBs As Decimal = 0
      Dim decDebeUs As Decimal = 0
      Dim decHaberUs As Decimal = 0
      Dim decSaldoBs As Decimal = 0

      datatableCompDet = LoadCompDet(lngPlanId, datFechaIni, datFechaFin, clsCompDet.WhereFilters.RowSumFechaSinGestion)
      If datatableCompDet IsNot Nothing Then

         decDebeBs = ToDecimal(datatableCompDet.Compute("Sum(DebeBs)", ""))
         decHaberBs = ToDecimal(datatableCompDet.Compute("Sum(HaberBs)", ""))
         decDebeUs = ToDecimal(datatableCompDet.Compute("Sum(DebeUs)", ""))
         decHaberUs = ToDecimal(datatableCompDet.Compute("Sum(HaberUs)", ""))

         If mlngGrupo = 1 Or mlngGrupo = 5 Or mlngGrupo = 6 Or mlngGrupo = 7 Then
            decSaldoBs = ToDecimal(decDebeBs - decHaberBs)
            decSaldoUs = ToDecimal(decDebeUs - decHaberUs)
         ElseIf mlngGrupo = 2 Or mlngGrupo = 3 Or mlngGrupo = 4 Or mlngGrupo = 8 Then
            decSaldoBs = ToDecimal(decHaberBs - decDebeBs)
            decSaldoUs = ToDecimal(decHaberUs - decDebeUs)
         End If

         SaldoGestionBs = decSaldoBs
      End If
   End Function

   Private Function PlanLoad() As Boolean
      moPlan = New clsPlan(clsAppInfo.ConnectString)

      With moPlan
         .SelectFilter = clsPlan.SelectFilters.All
         .WhereFilter = clsPlan.WhereFilters.EmpresaId
         .EmpresaId = mlngEmpresaId

         If .Open Then
            PlanLoad = True
         End If
      End With
   End Function

   Private Sub frmLibroMayorLoad()
      Dim oListaPlan As New Queue
      Dim lngPlanId As Long

      If ToLong(grdMain.GetValue("PlanId")) > 0 Then
         oListaPlan.Enqueue(ToLong(grdMain.GetValue("PlanId")))
         lngPlanId = ToLong(grdMain.GetValue("PlanId"))
      End If

      If oListaPlan.Count Then
         If grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralBs") Or grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralUs") Or grdMain.CurrentColumn.DataMember.Equals("SaldoAnt") Then
            Dim frm As New frmLibroMayor

            With frm
               .EmpresaId = mlngEmpresaId
               .GestionId = clsAppInfo.GestionId
               .MonedaId = mlngMonedaId
               .SaldoAnterior = False
               .Cuenta = True
               .SinMovimiento = False
               .IntervaloFecha = True

               Dim datFechaIni As Date = mstrFechaIni
               Dim datFechaFin As Date = mstrFechaFin

               mlngGestionId = GestionIdFind(mstrFechaIni, 0)

               Dim datFechaIniGestion, datFechaFinGestion As Date
               Call GestionFecha(mlngGestionId, datFechaIniGestion, datFechaFinGestion)

               moListaTipoAsiento.Clear()

               If grdMain.CurrentColumn.DataMember.Equals("SaldoAnt") Then
                  moListaTipoAsiento.Enqueue(0) 'Operativo
                  moListaTipoAsiento.Enqueue(1) 'Apertura
                  moListaTipoAsiento.Enqueue(2) 'Ajuste

                  If datFechaIni = datFechaIniGestion Then
                     Exit Sub
                  End If

                  .GestionId = mlngGestionId
                  .FechaIni = ToDate(datFechaIniGestion)
                  .FechaFin = ToDate(DateSerial(Year(datFechaIni), Month(datFechaIni), datFechaIni.Day - 1))
                  .Text = "Libro Mayor de " & ConvertDMY(.FechaIni) & " a " & ConvertDMY(.FechaFin)
               Else
                  Dim lngPos As Long = grdMain.CurrentColumn.DataMember.Substring(6)
                  Dim datFecha As Date = datFechaIni.AddMonths(lngPos)

                  If datFecha.Month = datFechaIniGestion.Month And datFecha.Year = datFechaIniGestion.Year Then
                     moListaTipoAsiento.Enqueue(1) 'Apertura
                  End If

                  moListaTipoAsiento.Enqueue(0) 'Operativo
                  moListaTipoAsiento.Enqueue(2) 'Ajuste

                  Dim datFechaIniTemp As Date = DateSerial(datFecha.Year, datFecha.Month, 1)
                  Dim datFechaFinTemp As Date = DateSerial(datFecha.Year, datFecha.Month, datFecha.DaysInMonth(Year(datFecha), Month(datFecha)))

                  If datFechaIniTemp < datFechaIni Then
                     datFechaIniTemp = datFechaIni
                  End If

                  If datFechaFinTemp > datFechaFin Then
                     datFechaFinTemp = datFechaFin
                  End If

                  .GestionId = GestionIdFind(ToDateDMY(datFechaIniTemp), 0)
                  .FechaIni = ToDate(datFechaIniTemp)
                  .FechaFin = ToDate(datFechaFinTemp)
                  .Text = "Libro Mayor de " & ConvertDMY(.FechaIni) & " a " & ConvertDMY(.FechaFin)
               End If

               .OrdenarFecha = True

               .Lista = oListaPlan
               .SinFac = mboolSinFac
               .ConFac = mboolConFac
               .ListaTipoAsiento = moListaTipoAsiento

               frm.ShowDialog()

               If frm.Changed Then
                  Call grdMainLoad()
                  Call grdMainFindRow(lngPlanId)
               End If

               frm.Dispose()

            End With
         End If
      Else
         MessageBox.Show("Cuenta Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub grdMainLoad()
      Dim oRow As DataRow
      Dim boolActivoFijo As Boolean = False
      Dim boolFirst As Boolean = True
      Dim mlngGestionIdFinal As Long = GestionIdFind(mstrFechaFin, 0)
      Dim decSaldoActivoUs As Decimal = 0
      Dim decSaldoActivoBs As Decimal = 0
      Try
         Call PlanLoad()
         Call MonedaLoad()
         Call moDataSetInit()

         For Each lngPlanId As Long In moLista
            Dim strPlanCta = ToStr((From r In moPlan.DataSet.Tables(moPlan.TableName) Where r("PlanId") = lngPlanId Select r("PlanCta")).FirstOrDefault)

            If strPlanCta.Substring(0, mstrPlanCtaPadreActivoFijo.Length) = mstrPlanCtaPadreActivoFijo Then
               boolActivoFijo = True
            End If

            Dim datFechaIni As Date = mstrFechaIni
            Dim datFechaFin As Date = mstrFechaFin
            Dim datFechaIniAux As Date
            oRow = moDataTable.NewRow
            boolFirst = True

            While datFechaIni < datFechaFin
               Dim lngGestion As Long = 0
               mlngGestionId = GestionIdFind(datFechaIni, lngGestion)
               Dim datFechaIniGestion, datFechaFinGestion As Date
               Call GestionFecha(mlngGestionId, datFechaIniGestion, datFechaFinGestion)

               If datFechaFinGestion > datFechaFin Then
                  datFechaFinGestion = datFechaFin
               End If

               mstrTipoAsientoId = TipoAsientoIdListaLoad(False)
               mlngGrupo = PlanGrupoFind(lngPlanId)

               Dim datatableCompDet As DataTable
               Dim datatableCompDetActivoFijo As DataTable
               Dim decDebeBs As Decimal = 0
               Dim decHaberBs As Decimal = 0
               Dim decDebeUs As Decimal = 0
               Dim decHaberUs As Decimal = 0
               Dim decSaldoBs As Decimal = 0
               Dim decSaldoUs As Decimal = 0

               datatableCompDet = LoadCompDet(lngPlanId, datFechaIni, datFechaFinGestion, clsCompDet.WhereFilters.RowSumFecha)

               If boolActivoFijo And mlngGestionIdFinal = mlngGestionId Then
                  datatableCompDetActivoFijo = LoadCompDetActivoFijo(lngPlanId, datFechaIni, datFechaFinGestion)
               End If

               datFechaIniAux = datFechaIni

               If datatableCompDet IsNot Nothing Then
                  Dim strFiltro As String = "Fecha >= '" & ToDateDMY(datFechaIni) & "' and Fecha <= '" & ToDateDMY(datFechaFinGestion) & "'"

                  decDebeBs = ToDecimal(datatableCompDet.Compute("Sum(DebeBs)", strFiltro))
                  decHaberBs = ToDecimal(datatableCompDet.Compute("Sum(HaberBs)", strFiltro))
                  decDebeUs = ToDecimal(datatableCompDet.Compute("Sum(DebeUs)", strFiltro))
                  decHaberUs = ToDecimal(datatableCompDet.Compute("Sum(HaberUs)", strFiltro))

                  If mlngGrupo = 1 Or mlngGrupo = 5 Or mlngGrupo = 6 Or mlngGrupo = 7 Then
                     decSaldoBs = ToDecimal(decDebeBs - decHaberBs)
                     decSaldoUs = ToDecimal(decDebeUs - decHaberUs)
                  ElseIf mlngGrupo = 2 Or mlngGrupo = 3 Or mlngGrupo = 4 Or mlngGrupo = 8 Then
                     decSaldoBs = ToDecimal(decHaberBs - decDebeBs)
                     decSaldoUs = ToDecimal(decHaberUs - decDebeUs)
                  End If

                  If mlngGrupo = 2 Or mlngGrupo = 3 Or mlngGrupo = 4 Then 'PATRIMONIO PASIVO INGRESO
                     decSaldoBs *= -1
                     decSaldoUs *= -1
                  End If

                  If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                     oRow("Saldo" & lngGestion) = decSaldoBs
                  Else
                     oRow("Saldo" & lngGestion) = decSaldoUs
                  End If

                  If ToDecimal(oRow("Saldo" & lngGestion)) = 0 Then
                     oRow("Saldo" & lngGestion) = System.Convert.DBNull
                  End If

                  If clsAppInfo.PlanAitbId = lngPlanId Or boolActivoFijo Then ' mlngGrupo = 3 Or
                     oRow("Saldo" & lngGestion) = System.Convert.DBNull
                  End If

                  decSaldoActivoBs = 0
                  decSaldoActivoUs = 0

                  If boolActivoFijo And mlngGestionIdFinal = mlngGestionId Then
                     decSaldoActivoBs = SaldoActivoFijoCompraBajaBs(datatableCompDetActivoFijo, datFechaIni, datFechaFinGestion, decSaldoActivoUs)

                     If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                        oRow("Saldo" & lngGestion) = decSaldoActivoBs
                     Else
                        oRow("Saldo" & lngGestion) = decSaldoActivoUs
                     End If

                     If ToDecimal(oRow("Saldo" & lngGestion)) = 0 Then
                        oRow("Saldo" & lngGestion) = System.Convert.DBNull
                     End If
                  End If

                  mdecSaldoPlanBs += decSaldoBs
                  mdecSaldoPlanUs += decSaldoUs
               End If

               datFechaIni = datFechaFinGestion.AddDays(1)
               boolFirst = False
            End While

            If mlngMonedaId = clsMoneda.BOLIVIANOS Then
               oRow("SaldoAcu") = mdecSaldoPlanBs
            ElseIf mlngMonedaId = clsMoneda.DOLARES Then
               oRow("SaldoAcu") = mdecSaldoPlanUs
            End If

            If mboolSaldoCero OrElse (Not mboolSaldoCero And (mdecSaldoPlanBs > 0 Or mdecSaldoPlanUs > 0)) Then
               moDataTable.Rows.Add(GetRow(lngPlanId, oRow))
            End If

            mdecSaldoPlanBs = 0
            mdecSaldoPlanUs = 0
            boolActivoFijo = False
         Next

         moDataTable.Rows.Add(GetRowNull)
         moDataTable.Rows.Add(GetFooter(mlngMonedaId))

         grdMain.DataSource = moDataTable.DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function SaldoActivoFijoCompraBajaBs(ByVal Comprobantes As DataTable, ByVal datFechaIni As Date, ByVal datFechaFin As Date, ByRef decSaldoUs As Decimal) As Decimal
      Dim decDebeBs As Decimal = 0
      Dim decDebeUs As Decimal = 0
      Dim decHaberBs As Decimal = 0
      Dim decHaberUs As Decimal = 0
      Dim decSaldoBs As Decimal = 0

      If Comprobantes IsNot Nothing Then
         If Comprobantes.Rows.Count > 0 Then
            Dim strFiltro As String = "Fecha >= '" & ToDateDMY(datFechaIni) & "' and Fecha <= '" & ToDateDMY(datFechaFin) & "'"

            decDebeBs = ToDecimal(Comprobantes.Compute("Sum(DebeBs)", strFiltro))
            decHaberBs = ToDecimal(Comprobantes.Compute("Sum(HaberBs)", strFiltro))
            decDebeUs = ToDecimal(Comprobantes.Compute("Sum(DebeUs)", strFiltro))
            decHaberUs = ToDecimal(Comprobantes.Compute("Sum(HaberUs)", strFiltro))

            If mlngGrupo = 1 Or mlngGrupo = 5 Or mlngGrupo = 6 Or mlngGrupo = 7 Then
               decSaldoBs = ToDecimal(decDebeBs - decHaberBs)
               decSaldoUs = ToDecimal(decDebeUs - decHaberUs)
            ElseIf mlngGrupo = 2 Or mlngGrupo = 3 Or mlngGrupo = 4 Or mlngGrupo = 8 Then
               decSaldoBs = ToDecimal(decHaberBs - decDebeBs)
               decSaldoUs = ToDecimal(decHaberUs - decDebeUs)
            End If

            Return decSaldoBs
         End If
      End If
   End Function

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Function MesFind(ByVal lngMesId As Long) As String
      Dim oMes As New clsMes(clsAppInfo.ConnectString)

      MesFind = String.Empty
      Try
         With oMes
            .MesId = lngMesId

            If .FindByPK Then
               MesFind = ToStr(.MesDes)
            End If
         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oMes.Dispose()
      End Try
   End Function

   Private Sub grdMainInit()
      Dim strMes As String

      With grdMain
         ebrMain.Groups(0).Text = "Balance de Sumas y Saldos"
         grdMain.RootTable.HeaderLines = 3
         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("PlanCta").Caption = "CUENTA"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         Dim datFechaIni As Date = mstrFechaIni
         Dim datFechaFin As Date = mstrFechaFin

         While datFechaIni < datFechaFin
            strMes = ""
            Dim lngGestion As Long = 0
            Dim lngGestionId = GestionIdFind(datFechaIni, lngGestion)
            Dim datFechaIniGestion, datFechaFinGestion As Date
            Call GestionFecha(lngGestionId, datFechaIniGestion, datFechaFinGestion)

            If datFechaFinGestion > datFechaFin Then
               datFechaFinGestion = datFechaFin
            End If

            If datFechaFinGestion <> datFechaFin Then
               While datFechaIni < datFechaFinGestion
                  strMes &= StrConv(Format(datFechaIni, "MMM"), VbStrConv.Uppercase) & "-"
                  datFechaIni = datFechaIni.AddMonths(1)
                  datFechaIni = DateSerial(Year(datFechaIni), Month(datFechaIni), 1)
               End While

               If strMes.Length > 0 Then
                  strMes = strMes.Substring(0, strMes.Length - 1) & " " & datFechaFinGestion.Year
               End If

            Else
               strMes = StrConv(Format(datFechaFinGestion, "MMMM"), VbStrConv.Uppercase) & "-" & datFechaFinGestion.Year
               datFechaIni = datFechaFinGestion.AddDays(1)
            End If

            .RootTable.Columns("Saldo" & lngGestion).Caption = strMes
            .RootTable.Columns("Saldo" & lngGestion).FormatString = DecimalMask()
            .RootTable.Columns("Saldo" & lngGestion).Width = 100
            .RootTable.Columns("Saldo" & lngGestion).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Saldo" & lngGestion).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         End While

         .RootTable.Columns("SaldoAcu").Caption = "Acumulado"
         .RootTable.Columns("SaldoAcu").FormatString = DecimalMask()
         .RootTable.Columns("SaldoAcu").Width = 100
         .RootTable.Columns("SaldoAcu").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SaldoAcu").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SaldoAcu").CellStyle.BackColor = Color.LightGreen

         .RootTable.Columns("PlanDes").Caption = "NOMBRE"
         .RootTable.Columns("PlanDes").Width = 270
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
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
#End Region
#End Region

End Class
