Public Class frmLibroDispoComparativo
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan

   Private moLista As New Queue
   Private moListaTipoAsiento As New Queue
   Private mstrTipoAsientoId As String

   Private mstrConnectString As String
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long

   Private mboolIntervaloFecha As Boolean
   Private mboolSaldoAnterior As Boolean
   Private mboolConsolidado As Boolean

   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean

   'Private mdecSaldoBs As Decimal
   'Private mdecSaldoUs As Decimal
   Private mdecSaldoAnt As Decimal
   Private mlngGrupo As Long

   Private moDataTable As DataTable

   Private mdatFechaIni As Date
   Private mdatFechaFin As Date
   Private mdatFechaIniInt As Date
   Private mdatFechaFinInt As Date

   Private mdatFechaIniOri As Date
   Private mdatFechaFinOri As Date
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter
   Friend WithEvents ExportExcel1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportExcel As Janus.Windows.UI.CommandBars.UICommand

#Region " Set and Get "

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

   Property FechaIni() As Date
      Get
         Return mdatFechaIni
      End Get

      Set(ByVal Value As Date)
         mdatFechaIni = Value
      End Set
   End Property

   Property FechaFin() As Date
      Get
         Return mdatFechaFin
      End Get

      Set(ByVal Value As Date)
         mdatFechaFin = Value
      End Set
   End Property

   Property FechaIniInt() As Date
      Get
         Return mdatFechaIniInt
      End Get

      Set(ByVal Value As Date)
         mdatFechaIniInt = Value
      End Set
   End Property

   Property FechaFinInt() As Date
      Get
         Return mdatFechaFinInt
      End Get

      Set(ByVal Value As Date)
         mdatFechaFinInt = Value
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

   Public Property Consolidado() As Boolean
      Get
         Return mboolConsolidado
      End Get
      Set(ByVal value As Boolean)
         mboolConsolidado = value
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

   Property ListaTipoAsiento() As Queue
      Get
         Return moListaTipoAsiento
      End Get

      Set(ByVal Value As Queue)
         moListaTipoAsiento = Value
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

   Public Enum Columna
      DebeBs = 1
      HaberBs = 2
      DebeUs = 3
      HaberUs = 4
   End Enum

#End Region

#Region "ListaEmpresa"
   Private moListaEmpresas As New List(Of EmpresaData)

   Public Property ListaEmpresas() As List(Of EmpresaData)
      Get
         Return moListaEmpresas
      End Get
      Set(ByVal value As List(Of EmpresaData))
         moListaEmpresas = value
      End Set
   End Property

   Public Structure EmpresaData
      Public ConnectString As String
      Public EmpresaId As Long
      Public GestionId As Long
      Public EmpresaDes As String
      Public Gestion As Long

      Public Sub New(ByVal strconnectString As String, ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal strEmpresaDes As String, ByVal lngGestion As Long)
         Me.ConnectString = strconnectString
         Me.EmpresaId = lngEmpresaId
         Me.GestionId = lngGestionId
         Me.EmpresaDes = strEmpresaDes
         Me.Gestion = lngGestion
      End Sub
   End Structure
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroDispoComparativo))
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
      Me.gexMain = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
      Me.ExportExcel = New Janus.Windows.UI.CommandBars.UICommand("ExportExcel")
      Me.ExportExcel1 = New Janus.Windows.UI.CommandBars.UICommand("ExportExcel")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
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
      Me.ilsMain.Images.SetKeyName(7, "Excel.JPG")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2, Me.ExportExcel})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator3, Me.ExportExcel1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(415, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Libro Mayor"
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
      'gexMain
      '
      Me.gexMain.GridEX = Me.grdMain
      '
      'ExportExcel
      '
      Me.ExportExcel.ImageIndex = 7
      Me.ExportExcel.Key = "ExportExcel"
      Me.ExportExcel.Name = "ExportExcel"
      Me.ExportExcel.Text = "Exportar"
      '
      'ExportExcel1
      '
      Me.ExportExcel1.Key = "ExportExcel"
      Me.ExportExcel1.Name = "ExportExcel1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'frmLibroDispoComparativo
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmLibroDispoComparativo"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Disponibilidad"
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

         Case "ExportExcel"
            Call ExportToExcelLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmLibroDispoComparativo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmLibroDispoComparativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

      If mboolConsolidado Then
         ExportExcel1.Visible = Janus.Windows.UI.InheritableBoolean.False
         'se puede Imprimir en Consolidado
         Print1.Visible = Janus.Windows.UI.InheritableBoolean.True
      Else
         ExportExcel1.Visible = Janus.Windows.UI.InheritableBoolean.True
         'Libro Mayor
         Book1.Visible = Janus.Windows.UI.InheritableBoolean.True
         'no se puede Imprimir en Comparativo
         Print1.Visible = Janus.Windows.UI.InheritableBoolean.False
      End If

      mdatFechaIniOri = mdatFechaIniInt
      mdatFechaFinOri = mdatFechaFinInt

      If mboolConsolidado Then
         Me.Text = "Disponibilidad Consolidado"
      Else
         Me.Text = "Disponibilidad Comparativo"
      End If

      'moPlan = New clsPlan(clsAppInfo.ConnectString)
   End Sub

   Private Sub frmLibroMayorLoad()
      If Not mboolConsolidado And grdMain.GetRow.Selected Then
         If (ToLong(grdMain.GetValue("PlanId")) > 0) Then
            'Cargar Datos de Empresa seleccionada
            Dim lngEmpresapos As Long = ToLong(grdMain.CurrentColumn.Tag)
            Call CargarVariablesGlobalesEmpresa(moListaEmpresas.ElementAt(lngEmpresapos))
            'cargar cuenta seleccionada
            Dim strPlanCta As String = ToStr(grdMain.GetValue("PlanCta"))
            Dim lngPlanId As Long = PlanIdFind(strPlanCta)

            Dim frm As New frmLibroMayorEmpresa

            With frm
               .EmpresaId = mlngEmpresaId
               .GestionId = mlngGestionId
               .MonedaId = mlngMonedaId
               .SaldoAnterior = False
               .Cuenta = True
               .SinMovimiento = False
               .IntervaloFecha = True
               .FechaIni = ToDate(mdatFechaIniInt)
               .FechaFin = ToDate(mdatFechaFinInt)
               .OrdenarFecha = True
               Dim lista As New Queue
               lista.Enqueue(lngPlanId)
               .Lista = lista 'New Queue([lngPlanId])
               .SinFac = mboolSinFac
               .ConFac = mboolConFac
               .ListaTipoAsiento = moListaTipoAsiento
               .ConnectString = mstrConnectString
               .Text = .Text & "  " & moListaEmpresas.ElementAt(lngEmpresapos).EmpresaDes & "  Gestion " & moListaEmpresas.ElementAt(lngEmpresapos).Gestion

               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & PlanDesFind(lngPlanId))

               .MdiParent = Me.MdiParent
               .Show()
            End With
         End If
      ElseIf mboolConsolidado And grdMain.GetRow.Selected Then
         If (ToLong(grdMain.GetValue("PlanId")) > 0) Then
            Dim strPlanCta As String = ToStr(grdMain.GetValue("PlanCta"))
            Dim strPlanDes As String = ToStr(grdMain.GetValue("PlanDes"))

            Dim frm As New frmLibroMayorConsolidado

            With frm
               .MonedaId = mlngMonedaId

               .IntervaloFecha = mboolIntervaloFecha
               .FechaIniInt = mdatFechaIniOri
               .FechaFinInt = mdatFechaFinOri

               'la Empresa base es en la que el sistema esta ejecutando el reporte
               'igual como en libro mayor comparativo
               Call GestionFecha(clsAppInfo.GestionId, .FechaIni, .FechaFin)

               .SaldoAnterior = mboolSaldoAnterior
               .Cuenta = True
               .SinMovimiento = False

               .SinFac = mboolSinFac
               .ConFac = mboolConFac

               For Each empresa In moListaEmpresas
                  .ListaEmpresas.Add(New Contabilidad.frmLibroMayorConsolidado.EmpresaData(empresa.ConnectString, empresa.EmpresaId, empresa.GestionId, empresa.EmpresaDes, empresa.Gestion))
               Next

               .ListaTipoAsiento = moListaTipoAsiento
               Dim lista As New Queue
               lista.Enqueue(strPlanCta)
               .Lista = lista
               .MdiParent = Me.MdiParent
               .Show()

               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & strPlanDes)
            End With
         End If
      End If
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

   Private Function PlanIdFind(ByVal strPlanCta As String) As Long
      Dim oPlan As New clsPlan(mstrConnectString)
      PlanIdFind = 0

      Try
         With moPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanCta
            .EmpresaId = mlngEmpresaId
            .PlanCta = strPlanCta

            If .Find Then
               PlanIdFind = .PlanId
            End If
         End With
      Catch ex As Exception
         Throw ex
      Finally
         oPlan.Dispose()
      End Try
   End Function

   'Private Sub grdMainFindRow(ByVal lngID As Long)
   '   Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

   '   oCol = grdMain.RootTable.Columns("CompDetId")

   '   grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   'End Sub

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
         If mlngMonedaId <> 4 Then
            Dim rpt As New rptLibroDispoConsolidado

            rpt.DataSource = moDataTable.DefaultView

            rpt.lblTitle.Text = "Disponibilidad Consolidado"
            rpt.Document.Name = "Disponibilidad Consolidado"
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            rpt.IntervaloFecha = mboolIntervaloFecha
            rpt.SaldoAnterior = mboolSaldoAnterior
            rpt.MonedaId = mlngMonedaId

            rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniOri)
            rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinOri)

            If mlngMonedaId = 1 Then
               rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)

            ElseIf mlngMonedaId = 2 Then
               rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)


            ElseIf mlngMonedaId = 4 Then
               rpt.txtMoneda.Text = "Ambas"
            End If

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

            rpt.Run(True)
            Dim frm As New frmReportPreview(rpt.Document, Me)
            frm.Show()
         Else
            Dim rpt As New rptLibroDispoConsolidadoExt

            rpt.DataSource = moDataTable.DefaultView

            rpt.lblTitle.Text = "Disponibilidad Consolidado"
            rpt.Document.Name = "Disponibilidad Consolidado"
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            rpt.SaldoAnterior = mboolSaldoAnterior
            rpt.IntervaloFecha = mboolIntervaloFecha

            rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniOri)
            rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinOri)

            rpt.txtMoneda.Text = "Ambas"

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

            rpt.Run(True)
            Dim frm As New frmReportPreview(rpt.Document, Me)
            frm.Show()
         End If
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Sub

   Private Sub frmLibroDispoComparativo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmLibroMayorLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmLibroDispoComparativo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
   End Sub

#Region " LIBRO-DISPO "
#Region " Metodo-LibroDispo "
   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      If mboolConsolidado Then
         fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("SaldoBs"), Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
         fc.FormatStyle.ForeColor = Color.DarkRed
         grdMain.RootTable.FormatConditions.Add(fc)
      Else
         For pos = 0 To moListaEmpresas.Count - 1 Step 1
            fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("SaldoBs" & pos), Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
            fc.FormatStyle.ForeColor = Color.DarkRed
            grdMain.RootTable.FormatConditions.Add(fc)
         Next
      End If

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Function PlanSaldoAnteriorBs(ByVal lngPlanId As Long, ByRef decSaldoAnteriorUs As Decimal) As Decimal
      Dim oCompDet As New clsCompDet(mstrConnectString)
      Dim decSaldoAnteriorBs As Decimal

      decSaldoAnteriorBs = 0
      decSaldoAnteriorUs = 0

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoAnterior
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .Fecha = ToDate(mdatFechaIniInt)
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId

            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows

                  If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                     decSaldoAnteriorBs += (ToDecimal(oRow("DebeBs")) - ToDecimal(oRow("HaberBs")))

                  ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                     decSaldoAnteriorBs += (ToDecimal(oRow("HaberBs")) - ToDecimal(oRow("DebeBs")))
                  End If

                  If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                     decSaldoAnteriorUs += (ToDecimal(oRow("DebeUs")) - ToDecimal(oRow("HaberUs")))

                  ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                     decSaldoAnteriorUs += (ToDecimal(oRow("HaberUs")) - ToDecimal(oRow("DebeUs")))
                  End If

               Next

               PlanSaldoAnteriorBs = decSaldoAnteriorBs
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function PlanSaldoActual(ByVal lngPlanId As Long, ByVal lngMonedaId As Long, ByRef decDebe As Decimal, ByRef decHaber As Decimal) As Decimal
      Dim oCompDet As New clsCompDet(mstrConnectString)
      Dim decSaldo As Decimal

      decSaldo = 0

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoActual
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .Fecha = ToDate(Now.Date)
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

                     decDebe += ToDecimal(oRow("DebeBs"))
                     decHaber += ToDecimal(oRow("HaberBs"))

                  ElseIf lngMonedaId = 2 Then
                     If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                        decSaldo += (ToDecimal(oRow("DebeUs")) - ToDecimal(oRow("HaberUs")))

                     ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                        decSaldo += (ToDecimal(oRow("HaberUs")) - ToDecimal(oRow("DebeUs")))
                     End If

                     decDebe += ToDecimal(oRow("DebeUs"))
                     decHaber += ToDecimal(oRow("HaberUs"))
                  End If
               Next

               PlanSaldoActual = decSaldo
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function PlanSaldoIntervaloBs(ByVal lngPlanId As Long, ByRef decSaldoUs As Decimal, ByRef decDebeBs As Decimal, ByRef decHaberBs As Decimal, ByRef decDebeUs As Decimal, ByRef decHaberUs As Decimal) As Decimal
      Dim oCompDet As New clsCompDet(mstrConnectString)
      Dim decSaldoBs As Decimal
      decDebeBs = 0
      decHaberBs = 0
      decDebeUs = 0
      decHaberUs = 0

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompDet.WhereFilters.LibroMayorFecha
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .Fecha = ToDate(mdatFechaIniInt)
            .CompDetDes = ToDate(mdatFechaFinInt)
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                     decSaldoBs += (ToDecimal(oRow("DebeBs")) - ToDecimal(oRow("HaberBs")))

                  ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                     decSaldoBs += (ToDecimal(oRow("HaberBs")) - ToDecimal(oRow("DebeBs")))
                  End If

                  decDebeBs += ToDecimal(oRow("DebeBs"))
                  decHaberBs += ToDecimal(oRow("HaberBs"))

                  If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                     decSaldoUs += (ToDecimal(oRow("DebeUs")) - ToDecimal(oRow("HaberUs")))

                  ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                     decSaldoUs += (ToDecimal(oRow("HaberUs")) - ToDecimal(oRow("DebeUs")))
                  End If

                  decDebeUs += ToDecimal(oRow("DebeUs"))
                  decHaberUs += ToDecimal(oRow("HaberUs"))
               Next

               PlanSaldoIntervaloBs = decSaldoBs
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

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

#Region " DataSet-LibroDispo "
   Private Sub moDataSetInit()
      moDataTable = New DataTable("Tabla")

      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))

      If mboolConsolidado Then
         If mlngMonedaId = 4 Or mlngMonedaId = clsMoneda.BOLIVIANOS Then
            moDataTable.Columns.Add("SaldoAntBs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("DebeBs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("HaberBs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("SaldoBs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("SaldoAntUs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("DebeUs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("HaberUs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("SaldoUs", Type.GetType("System.Decimal"))
         Else ' a pedido de Maria Eugenia que se muestre el saldo Bs y Saldo Us 
            moDataTable.Columns.Add("SaldoAntBs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("DebeBs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("HaberBs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("SaldoAntUs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("DebeUs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("HaberUs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("SaldoUs", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("SaldoBs", Type.GetType("System.Decimal"))
         End If
      Else
         For i = 0 To moListaEmpresas.Count Step 1
            moDataTable.Columns.Add("SaldoAntBs" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("DebeBs" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("HaberBs" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("SaldoBs" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("SaldoAntUs" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("DebeUs" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("HaberUs" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("SaldoUs" & i, Type.GetType("System.Decimal"))
         Next
      End If
   End Sub

   Private Function GetFooter() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanId") = -1
      oRow("PlanDes") = "Total "

      Dim decSaldoBs As Decimal = 0
      Dim decSaldoUs As Decimal = 0

      If mboolConsolidado Then
         decSaldoBs = ToDecimal(moDataTable.Compute("Sum(SaldoBs)", "PlanId > 0"))
         decSaldoUs = ToDecimal(moDataTable.Compute("Sum(SaldoUs)", "PlanId > 0"))
         oRow("SaldoBs") = decSaldoBs
         oRow("SaldoUs") = decSaldoUs
      Else
         For i = 0 To moListaEmpresas.Count Step 1
            decSaldoBs = ToDecimal(moDataTable.Compute("Sum(SaldoBs" & i & ")", "PlanId > 0"))
            decSaldoUs = ToDecimal(moDataTable.Compute("Sum(SaldoUs" & i & ")", "PlanId > 0"))
            oRow("SaldoBs" & i) = decSaldoBs
            oRow("SaldoUs" & i) = decSaldoUs
         Next
      End If

      Return oRow
   End Function
#End Region

#Region " Grid-LibroDispo "
   Private Sub grdMainInit()
      With grdMain
         If mboolConsolidado Then
            ebrMain.Groups(0).Text = "Disponibilidad Consolidado"
            .CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
         Else
            ebrMain.Groups(0).Text = "Disponibilidad Comparativo"
            .CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
         End If

         .RootTable.Columns("PlanId").Visible = False

         If mboolConsolidado Then

            .RootTable.Columns("PlanCta").Caption = "Cuenta"
            .RootTable.Columns("PlanCta").Width = 80
            .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("PlanDes").Caption = "Descripción"
            .RootTable.Columns("PlanDes").Width = 200
            .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            If mboolSaldoAnterior Then
               .RootTable.Columns("SaldoAntBs").Caption = "Saldo Ant. Bs"
               .RootTable.Columns("SaldoAntBs").FormatString = DecimalMask()
               .RootTable.Columns("SaldoAntBs").Width = 80
               .RootTable.Columns("SaldoAntBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("SaldoAntBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("SaldoAntBs").Visible = ((mlngMonedaId = clsMoneda.BOLIVIANOS) Or mlngMonedaId = 4)

               .RootTable.Columns("SaldoAntUs").Caption = "Saldo Ant. Us"
               .RootTable.Columns("SaldoAntUs").FormatString = DecimalMask()
               .RootTable.Columns("SaldoAntUs").Width = 80
               .RootTable.Columns("SaldoAntUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("SaldoAntUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("SaldoAntUs").Visible = ((mlngMonedaId = clsMoneda.DOLARES) Or mlngMonedaId = 4)
            Else
               .RootTable.Columns("SaldoAntBs").Visible = False
               .RootTable.Columns("SaldoAntUs").Visible = False
            End If

            .RootTable.Columns("DebeBs").Caption = "Debe Bs"
            .RootTable.Columns("DebeBs").FormatString = DecimalMask()
            .RootTable.Columns("DebeBs").Width = 80
            .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("DebeBs").Visible = ((mlngMonedaId = clsMoneda.BOLIVIANOS) Or mlngMonedaId = 4)

            .RootTable.Columns("DebeUs").Caption = "Debe Us"
            .RootTable.Columns("DebeUs").FormatString = DecimalMask()
            .RootTable.Columns("DebeUs").Width = 80
            .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("DebeUs").Visible = ((mlngMonedaId = clsMoneda.DOLARES) Or mlngMonedaId = 4)

            .RootTable.Columns("HaberBs").Caption = "Haber Bs"
            .RootTable.Columns("HaberBs").FormatString = DecimalMask()
            .RootTable.Columns("HaberBs").Width = 80
            .RootTable.Columns("HaberBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("HaberBs").Visible = ((mlngMonedaId = clsMoneda.BOLIVIANOS) Or mlngMonedaId = 4)

            .RootTable.Columns("HaberUs").Caption = "Haber Us"
            .RootTable.Columns("HaberUs").FormatString = DecimalMask()
            .RootTable.Columns("HaberUs").Width = 80
            .RootTable.Columns("HaberUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("HaberUs").Visible = ((mlngMonedaId = clsMoneda.DOLARES) Or mlngMonedaId = 4)

            .RootTable.Columns("SaldoBs").Caption = "Saldo Bs"
            .RootTable.Columns("SaldoBs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoBs").Width = 80
            .RootTable.Columns("SaldoBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            '.RootTable.Columns("SaldoBs").Visible = ((mlngMonedaId = clsMoneda.BOLIVIANOS) Or mlngMonedaId = 4)

            .RootTable.Columns("SaldoUs").Caption = "Saldo Us"
            .RootTable.Columns("SaldoUs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoUs").Width = 80
            .RootTable.Columns("SaldoUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            '.RootTable.Columns("SaldoUs").Visible = ((mlngMonedaId = clsMoneda.DOLARES) Or mlngMonedaId = 4)
         Else
            .RootTable.CellLayoutMode = Janus.Windows.GridEX.CellLayoutMode.UseColumnSets
            .RootTable.ColumnSetRowCount = 1
            .RootTable.ColumnSetHeaderLines = 1
            .RootTable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True

            Dim CSCuenta = New Janus.Windows.GridEX.GridEXColumnSet
            CSCuenta.Key = "Cuenta"
            CSCuenta.Caption = ""
            CSCuenta.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            CSCuenta.ColumnCount = 2
            .RootTable.ColumnSets.Add(CSCuenta)

            CSCuenta.Add(.RootTable.Columns("PlanCta"), 0, 0) '; // First parameter is GridEXColumn, Second is row in ColumnSet, third is col
            .RootTable.Columns("PlanCta").Caption = "Cuenta"
            .RootTable.Columns("PlanCta").Width = 80
            .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            CSCuenta.Add(.RootTable.Columns("PlanDes"), 0, 1) ';
            .RootTable.Columns("PlanDes").Caption = "Descripción"
            .RootTable.Columns("PlanDes").Width = 250
            .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            CSCuenta.Width = 330

            For pos = 0 To moListaEmpresas.Count - 1 Step 1
               Dim CS = New Janus.Windows.GridEX.GridEXColumnSet
               CS.Key = pos
               CS.Caption = moListaEmpresas.ElementAt(pos).Gestion & " - " & moListaEmpresas.ElementAt(pos).EmpresaDes
               CS.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center

               Dim colcount = 8 '8 columnas visibles en el grid por Empresa

               If mlngMonedaId = clsMoneda.BOLIVIANOS Or mlngMonedaId = clsMoneda.DOLARES Then
                  colcount -= 2 'no se mostrara la columna Saldo Ant 
               End If

               If Not mboolSaldoAnterior Then
                  colcount -= 2 'no se mostrara la columna Saldo Ant
               ElseIf mlngMonedaId = clsMoneda.BOLIVIANOS Or mlngMonedaId = clsMoneda.DOLARES Then
                  colcount -= 1 'no se mostrara la columna Saldo Ant
               End If

               CS.ColumnCount = colcount

               .RootTable.ColumnSets.Add(CS)

               Dim width = 0
               Dim col = -1

               If Not mboolSaldoAnterior Then
                  .RootTable.Columns("SaldoAntBs" & pos).Visible = False
                  .RootTable.Columns("SaldoAntUs" & pos).Visible = False
               End If

               If mlngMonedaId = clsMoneda.BOLIVIANOS Or mlngMonedaId = 4 Then
                  If mboolSaldoAnterior Then
                     CS.Add(.RootTable.Columns("SaldoAntBs" & pos), 0, getColMasUno(col)) ';
                     .RootTable.Columns("SaldoAntBs" & pos).Caption = "Saldo Ant. Bs"
                     .RootTable.Columns("SaldoAntBs" & pos).FormatString = DecimalMask()
                     .RootTable.Columns("SaldoAntBs" & pos).Width = 80
                     .RootTable.Columns("SaldoAntBs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                     .RootTable.Columns("SaldoAntBs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                     .RootTable.Columns("SaldoAntBs" & pos).Tag = pos
                     width += .RootTable.Columns("SaldoAntBs" & pos).Width
                  End If

                  CS.Add(.RootTable.Columns("DebeBs" & pos), 0, getColMasUno(col)) ';
                  .RootTable.Columns("DebeBs" & pos).Caption = "Debe Bs"
                  .RootTable.Columns("DebeBs" & pos).FormatString = DecimalMask()
                  .RootTable.Columns("DebeBs" & pos).Width = 80
                  .RootTable.Columns("DebeBs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                  .RootTable.Columns("DebeBs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                  .RootTable.Columns("DebeBs" & pos).Tag = pos
                  .RootTable.Columns("DebeBs" & pos).Visible = ((mlngMonedaId = clsMoneda.BOLIVIANOS) Or mlngMonedaId = 4)
                  width += .RootTable.Columns("DebeBs" & pos).Width

                  CS.Add(.RootTable.Columns("HaberBs" & pos), 0, getColMasUno(col)) ';
                  .RootTable.Columns("HaberBs" & pos).Caption = "Haber Bs"
                  .RootTable.Columns("HaberBs" & pos).FormatString = DecimalMask()
                  .RootTable.Columns("HaberBs" & pos).Width = 80
                  .RootTable.Columns("HaberBs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                  .RootTable.Columns("HaberBs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                  .RootTable.Columns("HaberBs" & pos).Tag = pos
                  .RootTable.Columns("HaberBs" & pos).Visible = ((mlngMonedaId = clsMoneda.BOLIVIANOS) Or mlngMonedaId = 4)
                  width += .RootTable.Columns("HaberBs" & pos).Width

                  CS.Add(.RootTable.Columns("SaldoBs" & pos), 0, getColMasUno(col)) ';
                  .RootTable.Columns("SaldoBs" & pos).Caption = "Saldo Bs"
                  .RootTable.Columns("SaldoBs" & pos).FormatString = DecimalMask()
                  .RootTable.Columns("SaldoBs" & pos).Width = 100
                  .RootTable.Columns("SaldoBs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                  .RootTable.Columns("SaldoBs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                  .RootTable.Columns("SaldoBs" & pos).Visible = ((mlngMonedaId = clsMoneda.BOLIVIANOS) Or mlngMonedaId = 4)
                  .RootTable.Columns("SaldoBs" & pos).Tag = pos
                  width += .RootTable.Columns("SaldoBs" & pos).Width

                  If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                     CS.Add(.RootTable.Columns("SaldoUs" & pos), 0, getColMasUno(col)) ';
                     .RootTable.Columns("SaldoUs" & pos).Caption = "Saldo Us"
                     .RootTable.Columns("SaldoUs" & pos).FormatString = DecimalMask()
                     .RootTable.Columns("SaldoUs" & pos).Width = 100
                     .RootTable.Columns("SaldoUs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                     .RootTable.Columns("SaldoUs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                     .RootTable.Columns("SaldoUs" & pos).Tag = pos
                     width += .RootTable.Columns("SaldoUs" & pos).Width
                  End If
               End If

               If mlngMonedaId = clsMoneda.DOLARES Or mlngMonedaId = 4 Then
                  If mboolSaldoAnterior Then
                     CS.Add(.RootTable.Columns("SaldoAntUs" & pos), 0, getColMasUno(col)) ';
                     .RootTable.Columns("SaldoAntUs" & pos).Caption = "Saldo Ant. Us"
                     .RootTable.Columns("SaldoAntUs" & pos).FormatString = DecimalMask()
                     .RootTable.Columns("SaldoAntUs" & pos).Width = 80
                     .RootTable.Columns("SaldoAntUs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                     .RootTable.Columns("SaldoAntUs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                     .RootTable.Columns("SaldoAntUs" & pos).Tag = pos
                     width += .RootTable.Columns("SaldoAntUs" & pos).Width

                     .RootTable.Columns("SaldoAntUs" & pos).Visible = (mlngMonedaId = clsMoneda.DOLARES Or mlngMonedaId = 4)
                  End If

                  CS.Add(.RootTable.Columns("DebeUs" & pos), 0, getColMasUno(col)) ';
                  .RootTable.Columns("DebeUs" & pos).Caption = "Debe Us"
                  .RootTable.Columns("DebeUs" & pos).FormatString = DecimalMask()
                  .RootTable.Columns("DebeUs" & pos).Width = 80
                  .RootTable.Columns("DebeUs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                  .RootTable.Columns("DebeUs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                  .RootTable.Columns("DebeUs" & pos).Tag = pos
                  .RootTable.Columns("DebeUs" & pos).Visible = ((mlngMonedaId = clsMoneda.DOLARES) Or mlngMonedaId = 4)
                  width += .RootTable.Columns("DebeUs" & pos).Width

                  CS.Add(.RootTable.Columns("HaberUs" & pos), 0, getColMasUno(col)) ';
                  .RootTable.Columns("HaberUs" & pos).Caption = "Haber Us"
                  .RootTable.Columns("HaberUs" & pos).FormatString = DecimalMask()
                  .RootTable.Columns("HaberUs" & pos).Width = 80
                  .RootTable.Columns("HaberUs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                  .RootTable.Columns("HaberUs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                  .RootTable.Columns("HaberUs" & pos).Tag = pos
                  .RootTable.Columns("HaberUs" & pos).Visible = ((mlngMonedaId = clsMoneda.DOLARES) Or mlngMonedaId = 4)
                  width += .RootTable.Columns("HaberUs" & pos).Width

                  CS.Add(.RootTable.Columns("SaldoUs" & pos), 0, getColMasUno(col)) ';
                  .RootTable.Columns("SaldoUs" & pos).Caption = "Saldo Us"
                  .RootTable.Columns("SaldoUs" & pos).FormatString = DecimalMask()
                  .RootTable.Columns("SaldoUs" & pos).Width = 100
                  .RootTable.Columns("SaldoUs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                  .RootTable.Columns("SaldoUs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                  .RootTable.Columns("SaldoUs" & pos).Visible = ((mlngMonedaId = clsMoneda.DOLARES) Or mlngMonedaId = 4)
                  .RootTable.Columns("SaldoUs" & pos).Tag = pos
                  width += .RootTable.Columns("SaldoUs" & pos).Width

                  If mlngMonedaId = clsMoneda.DOLARES Then
                     CS.Add(.RootTable.Columns("SaldoBs" & pos), 0, getColMasUno(col)) ';
                     .RootTable.Columns("SaldoBs" & pos).Caption = "Saldo Bs"
                     .RootTable.Columns("SaldoBs" & pos).FormatString = DecimalMask()
                     .RootTable.Columns("SaldoBs" & pos).Width = 100
                     .RootTable.Columns("SaldoBs" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                     .RootTable.Columns("SaldoBs" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                     .RootTable.Columns("SaldoBs" & pos).Tag = pos
                     width += .RootTable.Columns("SaldoBs" & pos).Width
                  End If
               End If

               CS.Width = width
            Next
         End If
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Function getColMasUno(ByRef col As Long) As Long
      col += 1
      Return col
   End Function

   Private Sub grdMainLoad()
      Dim oRow As DataRow
      Try
         Call moDataSetInit()
         mstrTipoAsientoId = TipoAsientoIdListaLoad()

         With moPlan
            For Each strPlanCta As String In moLista
               oRow = moDataTable.NewRow
               Dim decSaldoAntUs As Decimal = 0, decSaldoAntBs As Decimal = 0
               Dim decSaldoBs As Decimal = 0, decSaldoUs As Decimal = 0, decDebeBs As Decimal = 0, decHaberBs As Decimal = 0, decDebeUs As Decimal = 0, decHaberUs As Decimal = 0

               For pos = 0 To moListaEmpresas.Count - 1 Step 1
                  Dim col = ""
                  Call CargarVariablesGlobalesEmpresa(moListaEmpresas.Item(pos))
                  Call CargarCuenta(strPlanCta)

                  If pos = 0 Then
                     oRow("PlanId") = moPlan.PlanId
                     oRow("PlanCta") = moPlan.PlanCta
                     oRow("PlanDes") = moPlan.PlanDes
                  End If

                  If mboolConsolidado Then
                     Dim decSaldoAntBsTemp As Decimal = 0, decSaldoAntUsTemp As Decimal = 0, decSaldoBsTemp As Decimal = 0, decSaldoUsTemp As Decimal = 0
                     Dim decDebeBsTemp As Decimal = 0, decDebeUsTemp As Decimal = 0, decHaberBsTemp As Decimal = 0, decHaberUsTemp As Decimal = 0

                     decSaldoAntBsTemp = PlanSaldoAnteriorBs(moPlan.PlanId, decSaldoAntUsTemp)
                     decSaldoBsTemp = PlanSaldoIntervaloBs(moPlan.PlanId, decSaldoUsTemp, decDebeBsTemp, decHaberBsTemp, decDebeUsTemp, decHaberUsTemp)

                     decSaldoAntBs += decSaldoAntBsTemp
                     decSaldoAntUs += decSaldoAntUsTemp
                     decSaldoBs += decSaldoBsTemp
                     decSaldoUs += decSaldoUsTemp
                     decDebeBs += decDebeBsTemp
                     decDebeUs += decDebeUsTemp
                     decHaberBs += decHaberBsTemp
                     decHaberUs += decHaberUsTemp
                  Else
                     decSaldoAntBs = PlanSaldoAnteriorBs(moPlan.PlanId, decSaldoAntUs)
                     decSaldoBs = PlanSaldoIntervaloBs(moPlan.PlanId, decSaldoUs, decDebeBs, decHaberBs, decDebeUs, decHaberUs)
                     col &= pos
                  End If

                  If mboolSaldoAnterior Then
                     oRow("SaldoAntBs" & col) = decSaldoAntBs
                     oRow("SaldoAntUs" & col) = decSaldoAntUs
                  Else
                     oRow("SaldoAntBs" & col) = 0
                     oRow("SaldoAntUs" & col) = 0
                  End If

                  oRow("SaldoBs" & col) = decSaldoAntBs + decSaldoBs
                  oRow("SaldoUs" & col) = decSaldoAntUs + decSaldoUs
                  oRow("DebeBs" & col) = decDebeBs
                  oRow("HaberBs" & col) = decHaberBs
                  oRow("DebeUs" & col) = decDebeUs
                  oRow("HaberUs" & col) = decHaberUs
               Next

               moDataTable.Rows.Add(oRow)
            Next

            moDataTable.Rows.Add(GetFooter)

            grdMain.DataSource = moDataTable.DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()

            moplan.CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function CargarCuenta(ByVal strPlanCta As String) As Boolean
      moPlan = New clsPlan(mstrConnectString)
      CargarCuenta = False

      Try
         With moPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanCta
            .EmpresaId = mlngEmpresaId
            .PlanCta = strPlanCta

            If .Find Then
               mlngGrupo = moPlan.TipoGrupoId
               CargarCuenta = True
            End If
         End With
      Catch ex As Exception
         Throw ex
      End Try
   End Function

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
                  Dim lngyear = datFechaIniGes.Year + Math.Abs(mdatFechaIniInt.Year - mdatFechaIni.Year)
                  If Not Date.IsLeapYear(lngyear) Then
                     lngDiaIni = mdatFechaIniOri.Day - 1
                  Else
                     lngDiaIni = mdatFechaIniOri.Day
                  End If
               End If

               If mdatFechaFinOri.Day = 29 And mdatFechaFinOri.Month = 2 Then
                  Dim lngyear = datFechaIniGes.Year + Math.Abs(mdatFechaIniInt.Year - mdatFechaFinInt.Year)
                  If Not Date.IsLeapYear(lngyear) Then
                     lngDiaFin = mdatFechaFinOri.Day - 1
                  Else
                     lngDiaFin = mdatFechaFinOri.Day
                  End If
               End If

               Dim datFechaIniAux = New Date(datFechaIniGes.Year + Math.Abs(mdatFechaIniInt.Year - mdatFechaini.Year), mdatFechaIniOri.Month, lngDiaIni)
               Dim datFechaFinAux = New Date(datFechaIniGes.Year + Math.Abs(mdatFechaIniInt.Year - mdatFechaFinInt.Year), mdatFechaFinOri.Month, lngDiaFin)
               mdatFechaIniInt = datFechaIniAux
               mdatFechaFinInt = datFechaFinAux
               mdatFechaInI = .FechaIni
               mdatFechaFin = .FechaFin
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oGestion.Dispose()
      End Try
   End Sub

   Private Sub CargarVariablesGlobalesEmpresa(ByVal empresa As EmpresaData)
      mstrConnectString = empresa.ConnectString
      mlngEmpresaId = empresa.EmpresaId
      mlngGestionId = empresa.GestionId
      Call FechasEmpresaLoad(empresa.GestionId)
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
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

   Private Function PlanDesFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(mstrConnectString)

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

   Private Sub ExportToExcelLoad()
      Dim sfd As New SaveFileDialog
      sfd.Title = "Export Report Document"
      sfd.AddExtension = True
      sfd.DefaultExt = "xls"
      sfd.Filter = "Microsoft Excel Files (*.xls)|*.xls"
      sfd.FileName = Me.Text

      If sfd.ShowDialog() = DialogResult.OK Then
         Dim fs As New System.IO.FileStream(sfd.FileName, IO.FileMode.Create, IO.FileAccess.ReadWrite)
         gexMain.Export(fs)
         Dim strDir As String = sfd.FileName
         fs.Close()

         Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.EXPORTAR, "Exportar a Formato Excel")

         If MessageBox.Show("Desea Abrir el Archivo Excel?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            Try
               System.Diagnostics.Process.Start(strDir)
            Catch ex As Exception
               MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try
         End If
      End If
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call frmLibroMayorLoad()
   End Sub
End Class
