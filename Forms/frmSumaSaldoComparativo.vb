Public Class frmSumaSaldoComparativo
   Inherits System.Windows.Forms.Form

   Private moCompDet As clsCompDet
   Private moPlan As clsPlan

   Private moListaTipoAsiento As New Queue
   Private mstrTipoAsientoId As String
   Private moLista As New List(Of String)

   Private mstrConnectString As String
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngCentroCostoId As Long
   Private mlngMonedaId As Long

   Private mboolIntervaloFecha As Boolean
   Private mboolUltimoPeriodo As Boolean
   Private mboolSaldoAnterior As Boolean
   Private mboolSaldoCero As Boolean
   Private mboolConsolidado As Boolean
   Private mboolIncluirCuentasEmpresas As Boolean

   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean

   Private mdecHaber As Decimal
   Private mdecDebe As Decimal
   Private mdecSaldoPlan As Decimal
   Private mlngGrupo As Long

   Private moDataTable As DataTable

   Private mdatFechaIni As Date
   Private mdatFechaFin As Date
   Private mdatFechaIniInt As Date
   Private mdatFechaFinInt As Date

   Private mdatFechaIniOri As Date
   Private mdatFechaFinOri As Date

   Property IncluirCuentasEmpresas() As Boolean
      Get
         Return mboolIncluirCuentasEmpresas
      End Get
      Set(ByVal value As Boolean)
         mboolIncluirCuentasEmpresas = value
      End Set
   End Property

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

   Property Lista() As List(Of String)
      Get
         Return moLista
      End Get

      Set(ByVal Value As List(Of String))
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

   Public Property Consolidado() As Boolean
      Get
         Return mboolConsolidado
      End Get
      Set(ByVal value As Boolean)
         mboolConsolidado = value
      End Set
   End Property

   Private mstrCentroCostoCod As String
   Public Property CentroCostoCod() As String
      Get
         Return mstrCentroCostoCod
      End Get
      Set(ByVal value As String)
         mstrCentroCostoCod = value
      End Set
   End Property

   Private mstrCentroCostoDes As String
   Public Property CentroCostoDes() As String
      Get
         Return mstrCentroCostoDes
      End Get
      Set(ByVal value As String)
         mstrCentroCostoDes = value
      End Set
   End Property

   Private mboolSeleccionoTodosCC As Boolean
   Friend WithEvents ExportExcel As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportExcel1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter
   Public Property SeleccionoTodosCC() As Boolean
      Get
         Return mboolSeleccionoTodosCC
      End Get
      Set(ByVal value As Boolean)
         mboolSeleccionoTodosCC = value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSumaSaldoComparativo))
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
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ExportExcel1 = New Janus.Windows.UI.CommandBars.UICommand("ExportExcel")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ExportExcel = New Janus.Windows.UI.CommandBars.UICommand("ExportExcel")
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
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2, Me.ExportExcel})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator4, Me.ExportExcel1, Me.Separator3, Me.Exit1})
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
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'ExportExcel1
      '
      Me.ExportExcel1.Key = "ExportExcel"
      Me.ExportExcel1.Name = "ExportExcel1"
      Me.ExportExcel1.Text = "Exportar"
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
      'ExportExcel
      '
      Me.ExportExcel.ImageIndex = 7
      Me.ExportExcel.Key = "ExportExcel"
      Me.ExportExcel.Name = "ExportExcel"
      Me.ExportExcel.Text = "Excel"
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
      'frmSumaSaldoComparativo
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmSumaSaldoComparativo"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Balance de Sumas y Saldos Comparativo"
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
            If mboolConsolidado Then
               If Not mboolUltimoPeriodo Then
                  Call PrintReport()
               Else
                  Call PrintReportExt()
               End If
            Else
               If Not mboolUltimoPeriodo Then
                  Call PrintReportComparativo()
               Else
                  Call PrintReportComparativoExt()
               End If
            End If

         Case "ExportExcel"
            Call ExportToExcelLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmLibroMayor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmLibroMayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
         'Libro Mayor
         Book1.Visible = Janus.Windows.UI.InheritableBoolean.False
         'se puede Imprimir en Consolidado
         Print1.Visible = Janus.Windows.UI.InheritableBoolean.True
      Else
         ExportExcel1.Visible = Janus.Windows.UI.InheritableBoolean.True
         'Libro Mayor
         Book1.Visible = Janus.Windows.UI.InheritableBoolean.True
         'no se puede Imprimir en Comparativo
         If moListaEmpresas.Count > 2 Then
            Print1.Visible = Janus.Windows.UI.InheritableBoolean.False
         End If
      End If

      mdatFechaIniOri = mdatFechaIniInt
      mdatFechaFinOri = mdatFechaFinInt

      If mboolConsolidado Then
         Me.Text = "Balance de Sumas y Saldos Consolidado"
      Else
         Me.Text = "Balance de Sumas y Saldos Comparativo"
      End If
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

   Public Sub addCuentasEmpresas()
      For i = 1 To moListaEmpresas.Count - 1 Step 1
         Dim oPlan As New clsPlan(moListaEmpresas.Item(i).ConnectString)

         With oPlan
            .SelectFilter = clsPlan.SelectFilters.GridPadreCheck
            .WhereFilter = clsPlan.WhereFilters.GridFind
            .OrderByFilter = clsPlan.OrderByFilters.PlanCta
            .EmpresaId = moListaEmpresas.Item(i).EmpresaId
            .EsAna = 1

            If .Open() Then
               For Each row In .DataSet.Tables(.TableName).Rows
                  Dim strPlanCta As String = ToStr(row("PlanCta"))

                  If Not moLista.Contains(strPlanCta) Then
                     moLista.Add(strPlanCta)
                  End If
               Next
            End If

            .CloseConection()
         End With
      Next

      moLista.Sort()
   End Sub

   Private Sub PrintReport()
      Dim rpt As New rptSumaSaldoConsolidado

      rpt.DataSource = GetDataView(moDataTable)

      rpt.lblTitle.Text = "Balance de Sumas y Saldos Consolidado"
      rpt.Document.Name = "Balance de Sumas y Saldos Consolidado"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtCentroCostoCod.Text = mstrCentroCostoDes
      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniOri)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinOri)

      If mlngMonedaId = 1 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)

      ElseIf mlngMonedaId = 2 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)

      ElseIf mlngMonedaId = 3 Then
         rpt.txtMoneda.Text = "De Cuenta"
      End If

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub PrintReportExt()
      Dim rpt As New rptSumaSaldoConsolidadoExt

      rpt.DataSource = GetDataView(moDataTable)

      rpt.lblTitle.Text = "Balance de Sumas y Saldos Consolidado"
      rpt.Document.Name = "Balance de Sumas y Saldos Consolidado"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniOri)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinOri)
      rpt.txtCentroCostoCod.Text = mstrCentroCostoDes

      If mlngMonedaId = 1 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)

      ElseIf mlngMonedaId = 2 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)

      ElseIf mlngMonedaId = 3 Then
         rpt.txtMoneda.Text = "De Cuenta"
      End If

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub PrintReportComparativo()
      Dim rpt As New rptSumaSaldoComparativo

      rpt.DataSource = GetDataView(moDataTable)

      rpt.lblTitle.Text = "Balance de Sumas y Saldos Comparativo"
      rpt.Document.Name = "Balance de Sumas y Saldos Comparativo"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniOri)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinOri)
      rpt.txtCentroCostoCod.Text = mstrCentroCostoDes
      rpt.SaldoAnterior = mboolSaldoAnterior

      If mlngMonedaId = 1 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
      ElseIf mlngMonedaId = 2 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
      End If

      rpt.lblEmpresa1.Text = moListaEmpresas.Item(0).EmpresaDes & "-" & moListaEmpresas.Item(0).Gestion
      rpt.lblEmpresa2.Text = moListaEmpresas.Item(1).EmpresaDes & "-" & moListaEmpresas.Item(1).Gestion

      'Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, )

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub PrintReportComparativoExt()
      Dim rpt As New rptSumaSaldoComparativoExt

      rpt.DataSource = GetDataView(moDataTable)

      rpt.lblTitle.Text = "Balance de Sumas y Saldos Comparativo"
      rpt.Document.Name = "Balance de Sumas y Saldos Comparativo"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniOri)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinOri)
      rpt.txtCentroCostoCod.Text = mstrCentroCostoDes
      rpt.SaldoAnterior = mboolSaldoAnterior

      If mlngMonedaId = 1 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)

      ElseIf mlngMonedaId = 2 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
      End If

      rpt.lblEmpresa1.Text = moListaEmpresas.Item(0).EmpresaDes & "-" & moListaEmpresas.Item(0).Gestion
      rpt.lblEmpresa2.Text = moListaEmpresas.Item(1).EmpresaDes & "-" & moListaEmpresas.Item(1).Gestion

      ' Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub
#End Region

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

               Dim datFechaIniAux = New Date(datFechaIniGes.Year + Math.Abs(mdatFechaIniInt.Year - mdatFechaIni.Year), mdatFechaIniOri.Month, lngDiaIni)
               Dim datFechaFinAux = New Date(datFechaIniGes.Year + Math.Abs(mdatFechaIniInt.Year - mdatFechaFinInt.Year), mdatFechaFinOri.Month, lngDiaFin)
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

   Private Sub frmLibroMayorLoad()
      If Not mboolConsolidado And grdMain.GetRow.Selected Then
         If (ToLong(grdMain.GetValue("Id")) > 0) Then
            If Not grdMain.CurrentColumn Is Nothing Then
               'Cargar Datos de Empresa seleccionada
               Dim lngEmpresapos As Long = ToLong(grdMain.CurrentColumn.Tag)
               Call CargarVariablesGlobalesEmpresa(moListaEmpresas.ElementAt(lngEmpresapos))
               'cargar cuenta seleccionada
               Dim strPlanCta As String = ToStr(grdMain.GetValue("PlanCta"))
               Dim lngPlanId As Long = PlanIdFind(strPlanCta)
               'definir centro de costo
               Dim lngCentroCostoId = If(mboolSeleccionoTodosCC, 0, CentroCostoIdFind(mstrCentroCostoCod))

               If lngCentroCostoId = 0 Then
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
               Else
                  Dim listaCC As New Queue
                  listaCC.Enqueue(lngCentroCostoId)

                  Dim frm As New frmLibroCentroCostoEmpresas

                  With frm
                     .EmpresaId = mlngEmpresaId
                     .GestionId = mlngGestionId
                     .MonedaId = mlngMonedaId
                     .SaldoAnterior = False
                     .Cuenta = True
                     .IncluirDetalle = True
                     .IntervaloFecha = True
                     .FechaIni = ToDate(mdatFechaIniInt)
                     .FechaFin = ToDate(mdatFechaFinInt)
                     .OrdenarFecha = True
                     .SinFac = mboolSinFac
                     .ConFac = mboolConFac

                     .Lista = listaCC
                     Dim lista As New Queue
                     lista.Enqueue(lngPlanId)
                     .ListaPlan = lista
                     .ListaTipoAsiento = moListaTipoAsiento

                     .ConnectString = mstrConnectString
                     .Text = .Text & "  " & moListaEmpresas.ElementAt(lngEmpresapos).EmpresaDes & "  Gestion " & moListaEmpresas.ElementAt(lngEmpresapos).Gestion

                     Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & PlanDesFind(lngPlanId) & "; Centro Costo: " & mstrCentroCostoDes)

                     .MdiParent = Me.MdiParent
                     .Show()
                  End With
               End If
            End If
         End If
      End If
   End Sub

   Private Sub frmSumaSaldoComparativo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmLibroMayorLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmSumaSaldoComparativo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      '      moCompDet.Dispose()
      Call ClearMemory()
   End Sub

#Region " SUMA-SALDO "
#Region " Metodo Suma-Saldo "
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

   Private Function ConMovimiento(ByVal lngPlanId As Long) As Boolean
      Dim oCompDet As New clsCompDet(mstrConnectString)

      ConMovimiento = False
      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.AllComp

            If mboolIntervaloFecha Then
               .WhereFilter = clsCompDet.WhereFilters.SinMovimientoFecha
               .Fecha = ToDate(mdatFechaIniInt)
               .CompDetDes = ToDate(mdatFechaFinInt)
            Else
               .WhereFilter = clsCompDet.WhereFilters.SinMovimiento
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .CentroCostoId = mlngCentroCostoId
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

   Private Function SumarSaldos(ByVal lngPlanId As Long, ByVal lngCol As Long, ByVal bytWhere As Byte) As Decimal
      Dim oCompDet As New clsCompDet(mstrConnectString)

      SumarSaldos = 0
      Try
         With oCompDet
            If lngCol = Columna.DebeBs Then
               .RowSumFilter = clsCompDet.RowSumFilters.DebeBs
            ElseIf lngCol = Columna.HaberBs Then
               .RowSumFilter = clsCompDet.RowSumFilters.HaberBs
            ElseIf lngCol = Columna.DebeUs Then
               .RowSumFilter = clsCompDet.RowSumFilters.DebeUs
            ElseIf lngCol = Columna.HaberUs Then
               .RowSumFilter = clsCompDet.RowSumFilters.HaberUs
            End If

            .WhereFilter = bytWhere
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .CentroCostoId = mlngCentroCostoId
            .Fecha = ToDate(mdatFechaIniInt)
            .CompDetDes = ToDate(mdatFechaFinInt)
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
      Dim oCompDet As New clsCompDet(mstrConnectString)
      Dim decSaldo As Decimal

      decSaldo = 0
      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoAnterior
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .CentroCostoId = mlngCentroCostoId
            .Fecha = ToDate(mdatFechaIniInt)
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
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      If mboolConsolidado Then
         fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Saldo"), Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
         fc.FormatStyle.ForeColor = Color.DarkRed
         grdMain.RootTable.FormatConditions.Add(fc)
      Else
         'For pos = 0 To moListaEmpresas.Count - 1 Step 1
         fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("SaldoNegativo"), Janus.Windows.GridEX.ConditionOperator.Equal, True)
         fc.FormatStyle.ForeColor = Color.DarkRed
         grdMain.RootTable.FormatConditions.Add(fc)
         'Next
      End If

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Id"), Janus.Windows.GridEX.ConditionOperator.Equal, System.Convert.DBNull)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " DataSet Suma-Saldo "
   Private Sub moDataSetInit()
      moDataTable = New DataTable("Detalle")

      moDataTable.Columns.Add("Id", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))

      If mboolConsolidado Then
         moDataTable.Columns.Add("SaldoAnt", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Debe", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Haber", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Saldo", Type.GetType("System.Decimal"))

         If mboolUltimoPeriodo Then
            moDataTable.Columns.Add("DebePer", Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("HaberPer", Type.GetType("System.Decimal"))
         End If
      Else
         For i = 0 To moListaEmpresas.Count - 1 Step 1
            moDataTable.Columns.Add("SaldoAnt" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("Debe" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("Haber" & i, Type.GetType("System.Decimal"))
            moDataTable.Columns.Add("Saldo" & i, Type.GetType("System.Decimal"))

            If mboolUltimoPeriodo Then
               moDataTable.Columns.Add("DebePer" & i, Type.GetType("System.Decimal"))
               moDataTable.Columns.Add("HaberPer" & i, Type.GetType("System.Decimal"))
            End If
         Next
         moDataTable.Columns.Add("SaldoNegativo", Type.GetType("System.Boolean"))
      End If
   End Sub

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
   End Function

   Private Function GetFooter(ByVal lngMonedaId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      If lngMonedaId = 1 Then
         oRow("PlanDes") = "Total Saldos en " & MonedaDesFind(lngMonedaId)
      ElseIf lngMonedaId = 2 Then
         oRow("PlanDes") = "Total Saldos en " & MonedaDesFind(lngMonedaId)
      End If

      If mboolConsolidado Then
         oRow("Debe") = moDataTable.Compute("Sum(Debe)", "id > 0")
         oRow("Haber") = moDataTable.Compute("Sum(Haber)", "id > 0")

         If mboolUltimoPeriodo Then
            oRow("DebePer") = moDataTable.Compute("Sum(DebePer)", "id > 0")
            oRow("HaberPer") = moDataTable.Compute("Sum(HaberPer)", "id > 0")
         End If
      Else
         For i = 0 To moListaEmpresas.Count - 1 Step 1
            oRow("Debe" & i) = moDataTable.Compute("Sum(Debe" & i & ")", "id > 0")
            oRow("Haber" & i) = moDataTable.Compute("Sum(Haber" & i & ")", "id > 0")

            If mboolUltimoPeriodo Then
               oRow("DebePer" & i) = moDataTable.Compute("Sum(DebePer" & i & ")", "id > 0")
               oRow("HaberPer" & i) = moDataTable.Compute("Sum(HaberPer" & i & ")", "id > 0")
            End If
         Next
      End If

      Return oRow
   End Function
#End Region

#Region " Grid Suma-Saldo "
   Private Sub VariablesPlanCuentaInit()
      mdecDebe = 0
      mdecHaber = 0
      mdecSaldoPlan = 0
   End Sub

   Private Sub SumaDebeHaber(ByRef decDebe As Decimal, ByRef decHaber As Decimal)
      With moPlan
         If mboolIntervaloFecha Then
            If mlngMonedaId = clsMoneda.BOLIVIANOS Then
               decDebe = SumarSaldos(.PlanId, Columna.DebeBs, clsCompDet.WhereFilters.RowSumFecha)
               decHaber = SumarSaldos(.PlanId, Columna.HaberBs, clsCompDet.WhereFilters.RowSumFecha)

            ElseIf mlngMonedaId = clsMoneda.DOLARES Then
               decDebe = SumarSaldos(.PlanId, Columna.DebeUs, clsCompDet.WhereFilters.RowSumFecha)
               decHaber = SumarSaldos(.PlanId, Columna.HaberUs, clsCompDet.WhereFilters.RowSumFecha)
            End If
         Else
            If mlngMonedaId = clsMoneda.BOLIVIANOS Then
               decDebe = SumarSaldos(.PlanId, Columna.DebeBs, clsCompDet.WhereFilters.RowSumGestion)
               decHaber = SumarSaldos(.PlanId, Columna.HaberBs, clsCompDet.WhereFilters.RowSumGestion)

            ElseIf mlngMonedaId = clsMoneda.DOLARES Then
               decDebe = SumarSaldos(.PlanId, Columna.DebeUs, clsCompDet.WhereFilters.RowSumGestion)
               decHaber = SumarSaldos(.PlanId, Columna.HaberUs, clsCompDet.WhereFilters.RowSumGestion)
            End If
         End If
      End With
   End Sub

   Private Sub grdMainLoad()
      Dim oRow As DataRow

      Try
         If mboolIncluirCuentasEmpresas Then
            Call addCuentasEmpresas()
         End If

         Call moDataSetInit()
         mstrTipoAsientoId = TipoAsientoIdListaLoad()

         For Each strPlanCta As String In moLista
            oRow = moDataTable.NewRow
            Call VariablesPlanCuentaInit()

            For pos = 0 To moListaEmpresas.Count - 1 Step 1
               Call CargarVariablesGlobalesEmpresa(moListaEmpresas.Item(pos))
               Call CargarCuenta(strPlanCta)

               With moPlan
                  If .PlanId > 0 Then
                     If pos = 0 Then
                        oRow("Id") = .PlanId
                        oRow("PlanCta") = .PlanCta
                        oRow("PlanDes") = .PlanDes
                     ElseIf ToLong(oRow("Id")) = 0 Then
                        oRow("Id") = .PlanId
                        oRow("PlanCta") = .PlanCta
                        oRow("PlanDes") = .PlanDes
                     End If

                     If ConMovimiento(.PlanId) Then
                        If mboolConsolidado Then

                           If mboolSaldoAnterior Then
                              oRow("SaldoAnt") = ToDecimal(oRow("SaldoAnt")) + PlanSaldoAnterior(.PlanId, mlngMonedaId)
                           End If

                           Call SumaDebeHaber(mdecDebe, mdecHaber)

                           oRow("Debe") = ToDecimal(oRow("Debe")) + mdecDebe
                           oRow("Haber") = ToDecimal(oRow("Haber")) + mdecHaber

                           If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                              oRow("Saldo") = ToDecimal(oRow("SaldoAnt")) + ToDecimal(oRow("Debe")) - ToDecimal(oRow("Haber"))

                           ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                              oRow("Saldo") = ToDecimal(oRow("SaldoAnt")) + ToDecimal(oRow("Haber")) - ToDecimal(oRow("Debe"))
                           End If

                           If ToDecimal(oRow("Debe")) = 0 Then
                              oRow("Debe") = System.Convert.DBNull
                           End If

                           If ToDecimal(oRow("Haber")) = 0 Then
                              oRow("Haber") = System.Convert.DBNull
                           End If

                           If mboolUltimoPeriodo Then
                              If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                                 oRow("DebePer") = ToDecimal(oRow("DebePer")) + SumarSaldos(.PlanId, Columna.DebeBs, clsCompDet.WhereFilters.RowSumGestion)
                                 oRow("HaberPer") = ToDecimal(oRow("HaberPer")) + SumarSaldos(.PlanId, Columna.HaberBs, clsCompDet.WhereFilters.RowSumGestion)
                              ElseIf mlngMonedaId = clsMoneda.DOLARES Then
                                 oRow("DebePer") = ToDecimal(oRow("DebePer")) + SumarSaldos(.PlanId, Columna.DebeUs, clsCompDet.WhereFilters.RowSumGestion)
                                 oRow("HaberPer") = ToDecimal(oRow("HaberPer")) + SumarSaldos(.PlanId, Columna.HaberUs, clsCompDet.WhereFilters.RowSumGestion)
                              End If

                              If ToDecimal(oRow("DebePer")) = 0 Then
                                 oRow("DebePer") = System.Convert.DBNull
                              End If

                              If ToDecimal(oRow("HaberPer")) = 0 Then
                                 oRow("HaberPer") = System.Convert.DBNull
                              End If
                           End If

                           If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                              mdecSaldoPlan = ToDecimal(oRow("Debe")) - ToDecimal(oRow("Haber"))
                           ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                              mdecSaldoPlan = ToDecimal(oRow("Haber")) - ToDecimal(oRow("Debe"))
                           End If

                        Else 'Comparativo
                           If mboolSaldoAnterior Then
                              oRow("SaldoAnt" & pos) = PlanSaldoAnterior(.PlanId, mlngMonedaId)
                           End If

                           Call SumaDebeHaber(mdecDebe, mdecHaber)

                           oRow("Debe" & pos) = mdecDebe
                           oRow("Haber" & pos) = mdecHaber

                           If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                              oRow("Saldo" & pos) = ToDecimal(oRow("SaldoAnt" & pos)) + ToDecimal(oRow("Debe" & pos)) - ToDecimal(oRow("Haber" & pos))

                           ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                              oRow("Saldo" & pos) = ToDecimal(oRow("SaldoAnt" & pos)) + ToDecimal(oRow("Haber" & pos)) - ToDecimal(oRow("Debe" & pos))
                           End If

                           If ToDecimal(oRow("Debe" & pos)) = 0 Then
                              oRow("Debe" & pos) = System.Convert.DBNull
                           End If

                           If ToDecimal(oRow("Haber" & pos)) = 0 Then
                              oRow("Haber" & pos) = System.Convert.DBNull
                           End If

                           If mboolUltimoPeriodo Then
                              If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                                 oRow("DebePer" & pos) = SumarSaldos(.PlanId, Columna.DebeBs, clsCompDet.WhereFilters.RowSumGestion)
                                 oRow("HaberPer" & pos) = SumarSaldos(.PlanId, Columna.HaberBs, clsCompDet.WhereFilters.RowSumGestion)
                              ElseIf mlngMonedaId = clsMoneda.DOLARES Then
                                 oRow("DebePer" & pos) = SumarSaldos(.PlanId, Columna.DebeUs, clsCompDet.WhereFilters.RowSumGestion)
                                 oRow("HaberPer" & pos) = SumarSaldos(.PlanId, Columna.HaberUs, clsCompDet.WhereFilters.RowSumGestion)
                              End If

                              If ToDecimal(oRow("DebePer" & pos)) = 0 Then
                                 oRow("DebePer" & pos) = System.Convert.DBNull
                              End If

                              If ToDecimal(oRow("HaberPer" & pos)) = 0 Then
                                 oRow("HaberPer" & pos) = System.Convert.DBNull
                              End If
                           End If

                           If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                              mdecSaldoPlan += Math.Abs(ToDecimal(oRow("Debe" & pos)) - ToDecimal(oRow("Haber" & pos)))
                           ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                              mdecSaldoPlan += Math.Abs(ToDecimal(oRow("Haber" & pos)) - ToDecimal(oRow("Debe" & pos)))
                           End If

                           If ToDecimal(oRow("Saldo" & pos)) < 0 Then
                              oRow("SaldoNegativo") = True
                           End If
                        End If
                     End If
                  End If
               End With
            Next

            If Math.Abs(mdecSaldoPlan) > 0 Or mboolSaldoCero Then
               moDataTable.Rows.Add(oRow)
            End If
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

   Private Sub CargarVariablesGlobalesEmpresa(ByVal empresa As EmpresaData)
      mstrConnectString = empresa.ConnectString
      mlngEmpresaId = empresa.EmpresaId
      mlngGestionId = empresa.GestionId
      Call FechasEmpresaLoad(empresa.GestionId)

      If mboolSeleccionoTodosCC Then
         mlngCentroCostoId = 0
      Else
         mlngCentroCostoId = CentroCostoIdFind(mstrCentroCostoCod)
      End If

   End Sub

   Private Function CentroCostoIdFind(ByVal strCentroCostoCod As String) As Long
      Dim oCentroCosto As New clsCentroCosto(mstrConnectString)
      CentroCostoIdFind = -1

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.All
            .WhereFilter = clsCentroCosto.WhereFilters.CentroCostoCod
            .EmpresaId = mlngEmpresaId
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

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainInit()
      With grdMain
         If mboolConsolidado Then
            ebrMain.Groups(0).Text = "Balance de Sumas y Saldos Consolidado" & If(mlngCentroCostoId <> 0, " por C.C.: " & mstrCentroCostoDes, "")
            .CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow
         Else
            ebrMain.Groups(0).Text = "Balance de Sumas y Saldos Comparativo" '& If(mlngCentroCostoId <> 0, " por C.C.: " & mstrCentroCostoDes, "")
            .CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
         End If

         .RootTable.Columns("Id").Visible = False

         .RootTable.Columns("PlanCta").Caption = "Cuenta"
         .RootTable.Columns("PlanCta").Width = 80
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripción"
         .RootTable.Columns("PlanDes").Width = 250
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mboolConsolidado Then
            .RootTable.Columns("SaldoAnt").Caption = "Saldo Ant."
            .RootTable.Columns("SaldoAnt").FormatString = DecimalMask()
            .RootTable.Columns("SaldoAnt").Width = 80
            .RootTable.Columns("SaldoAnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoAnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("SaldoAnt").Visible = mboolSaldoAnterior

            .RootTable.Columns("Debe").Caption = "Débito"
            .RootTable.Columns("Debe").FormatString = DecimalMask()
            .RootTable.Columns("Debe").Width = 80
            .RootTable.Columns("Debe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Debe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Haber").Caption = "Crédito"
            .RootTable.Columns("Haber").FormatString = DecimalMask()
            .RootTable.Columns("Haber").Width = 80
            .RootTable.Columns("Haber").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Haber").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("Saldo").Caption = "Saldo"
            .RootTable.Columns("Saldo").FormatString = DecimalMask()
            .RootTable.Columns("Saldo").Width = 80
            .RootTable.Columns("Saldo").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Saldo").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            If mboolUltimoPeriodo Then
               .RootTable.Columns("DebePer").Caption = "Débito Gestión"
               .RootTable.Columns("DebePer").FormatString = DecimalMask()
               .RootTable.Columns("DebePer").Width = 100
               .RootTable.Columns("DebePer").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("DebePer").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

               .RootTable.Columns("HaberPer").Caption = "Crédito Gestión"
               .RootTable.Columns("HaberPer").FormatString = DecimalMask()
               .RootTable.Columns("HaberPer").Width = 100
               .RootTable.Columns("HaberPer").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("HaberPer").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            End If
         Else
            .RootTable.CellLayoutMode = Janus.Windows.GridEX.CellLayoutMode.UseColumnSets
            .RootTable.ColumnSetRowCount = 1
            .RootTable.ColumnSetHeaderLines = 1
            .RootTable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True

            Dim CSCuenta = New Janus.Windows.GridEX.GridEXColumnSet
            CSCuenta.Key = "Cuenta"
            CSCuenta.Caption = If(mlngCentroCostoId > 0, "C.C.: " & mstrCentroCostoDes, "")
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
               CS.Caption = moListaEmpresas.ElementAt(pos).Gestion & " - " & moListaEmpresas.ElementAt(pos).EmpresaDes '& " - Centro Costo: " & mstrCentroCostoCod
               CS.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center

               Dim colcount = 6 '6 columnas visibles en el grid por Empresa
               If Not mboolSaldoAnterior Then
                  colcount -= 1 'no se mostrara la columna Saldo Ant
               End If
               If Not mboolUltimoPeriodo Then
                  colcount -= 2 'no se mostrara las columna por Debe Haber de la Gestion
               End If
               CS.ColumnCount = colcount

               .RootTable.ColumnSets.Add(CS)

               Dim width = 0
               Dim col = -1

               If mboolSaldoAnterior Then
                  CS.Add(.RootTable.Columns("SaldoAnt" & pos), 0, getColMasUno(col)) ';
                  .RootTable.Columns("SaldoAnt" & pos).Caption = "Saldo Ant."
                  .RootTable.Columns("SaldoAnt" & pos).FormatString = DecimalMask()
                  .RootTable.Columns("SaldoAnt" & pos).Width = 80
                  .RootTable.Columns("SaldoAnt" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                  .RootTable.Columns("SaldoAnt" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                  .RootTable.Columns("SaldoAnt" & pos).Visible = mboolSaldoAnterior
                  .RootTable.Columns("SaldoAnt" & pos).Tag = pos
                  width += .RootTable.Columns("SaldoAnt" & pos).Width
               End If

               CS.Add(.RootTable.Columns("Debe" & pos), 0, getColMasUno(col)) ';
               .RootTable.Columns("Debe" & pos).Caption = "Débito"
               .RootTable.Columns("Debe" & pos).FormatString = DecimalMask()
               .RootTable.Columns("Debe" & pos).Width = 80
               .RootTable.Columns("Debe" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("Debe" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("Debe" & pos).Tag = pos
               width += .RootTable.Columns("Debe" & pos).Width

               CS.Add(.RootTable.Columns("Haber" & pos), 0, getColMasUno(col)) ';
               .RootTable.Columns("Haber" & pos).Caption = "Crédito"
               .RootTable.Columns("Haber" & pos).FormatString = DecimalMask()
               .RootTable.Columns("Haber" & pos).Width = 80
               .RootTable.Columns("Haber" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("Haber" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("Haber" & pos).Tag = pos
               width += .RootTable.Columns("Haber" & pos).Width

               CS.Add(.RootTable.Columns("Saldo" & pos), 0, getColMasUno(col)) ';
               .RootTable.Columns("Saldo" & pos).Caption = "Saldo"
               .RootTable.Columns("Saldo" & pos).FormatString = DecimalMask()
               .RootTable.Columns("Saldo" & pos).Width = 80
               .RootTable.Columns("Saldo" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("Saldo" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("Saldo" & pos).Tag = pos
               width += .RootTable.Columns("Saldo" & pos).Width

               If mboolUltimoPeriodo Then
                  CS.Add(.RootTable.Columns("DebePer" & pos), 0, getColMasUno(col)) ';
                  .RootTable.Columns("DebePer" & pos).Caption = "Débito Gestión"
                  .RootTable.Columns("DebePer" & pos).FormatString = DecimalMask()
                  .RootTable.Columns("DebePer" & pos).Width = 100
                  .RootTable.Columns("DebePer" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                  .RootTable.Columns("DebePer" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                  .RootTable.Columns("DebePer" & pos).Tag = pos
                  width += .RootTable.Columns("DebePer" & pos).Width

                  CS.Add(.RootTable.Columns("HaberPer" & pos), 0, getColMasUno(col)) ';
                  .RootTable.Columns("HaberPer" & pos).Caption = "Crédito Gestión"
                  .RootTable.Columns("HaberPer" & pos).FormatString = DecimalMask()
                  .RootTable.Columns("HaberPer" & pos).Width = 100
                  .RootTable.Columns("HaberPer" & pos).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                  .RootTable.Columns("HaberPer" & pos).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                  .RootTable.Columns("HaberPer" & pos).Tag = pos
                  width += .RootTable.Columns("HaberPer" & pos).Width
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

   Private Sub ExportToExcelLoad()
      Dim sfd As New SaveFileDialog
      sfd.Title = "Export Report Document"
      sfd.AddExtension = True
      sfd.DefaultExt = "xls"
      sfd.Filter = "Microsoft Excel Files (*.xls)|*.xls"
      sfd.FileName = Me.Text

      If sfd.ShowDialog() = DialogResult.OK Then
         Dim fs As New System.IO.FileStream(sfd.FileName, IO.FileMode.Create, IO.FileAccess.ReadWrite)
         gexMain.SheetName = "Sumas y Saldos Comparativo"
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
End Class
