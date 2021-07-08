Public Class frmLibroMayorConsolidado
   Inherits System.Windows.Forms.Form

   Private moCompDet As clsCompDet
   Private moPlan As clsPlan

   Private moListaTipoAsiento As New Queue
   Private mstrTipoAsientoId As String
   Private moLista As New Queue
   Private moListaEmpresa_Cuenta_Totales As New Dictionary(Of Long, CuentaEmpresa_Monto_Total)

   Private mstrConnectString As String
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long

   Private mboolIntervaloFecha As Boolean 'ver
   Private mboolSaldoAnterior As Boolean
   Private mboolCuenta As Boolean 'ver
   Private mboolSinMovimiento As Boolean

   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean

   Private mstrPlanCta As String
   Private mstrPlanDes As String
   Private mlngHeaderCuentaIndex As Long
   Private mlngGrupo As Long

   Private moDataTable As DataTable

   Private mdatFechaIni As Date
   Private mdatFechaFin As Date
   Private mdatFechaIniInt As Date
   Private mdatFechaFinInt As Date

   Private mdatFechaIniOri As Date
   Private mdatFechaFinOri As Date
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter
   Friend WithEvents ExportExcel As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportExcel1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand

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

   Property Cuenta() As Boolean
      Get
         Return mboolCuenta
      End Get

      Set(ByVal Value As Boolean)
         mboolCuenta = Value
      End Set
   End Property

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

#Region "Totalizar Cuentas"
   Public Structure CuentaEmpresa_Monto_Total
      Public DebeBs As Decimal
      Public HaberBs As Decimal
      Public SaldoBs As Decimal
      Public DebeUs As Decimal
      Public HaberUs As Decimal
      Public SaldoUs As Decimal
   End Structure

   Private Sub SumarSaldoAnt(ByVal lngIndexEmpresa As Long, ByVal decSaldoAntBs As Decimal, ByVal decSaldoAntUs As Decimal)
      'se crea el total de la cuenta para la empresa 
      Dim cuenta As CuentaEmpresa_Monto_Total

      If moListaEmpresa_Cuenta_Totales.ContainsKey(lngIndexEmpresa) Then
         cuenta = moListaEmpresa_Cuenta_Totales.Item(lngIndexEmpresa)
      Else
         cuenta = New CuentaEmpresa_Monto_Total
         cuenta.SaldoBs = 0
         cuenta.SaldoUs = 0
         moListaEmpresa_Cuenta_Totales.Add(lngIndexEmpresa, cuenta)
      End If

      cuenta.SaldoBs = cuenta.SaldoBs + decSaldoAntBs
      cuenta.SaldoUs = cuenta.SaldoUs + decSaldoAntUs

      moListaEmpresa_Cuenta_Totales.Item(lngIndexEmpresa) = cuenta
   End Sub

   Private Function SumarTotales(ByVal comprobante As CuentaEmpresa_Monto_Total, ByVal lngIndexEmpresa As Long) As CuentaEmpresa_Monto_Total
      Dim item As CuentaEmpresa_Monto_Total

      If moListaEmpresa_Cuenta_Totales.ContainsKey(lngIndexEmpresa) Then
         item = moListaEmpresa_Cuenta_Totales.Item(lngIndexEmpresa)
      Else
         item = New CuentaEmpresa_Monto_Total
         moListaEmpresa_Cuenta_Totales.Add(lngIndexEmpresa, item)
      End If

      item.DebeBs += comprobante.DebeBs
      item.HaberBs += comprobante.HaberBs
      item.DebeUs += comprobante.DebeUs
      item.HaberUs += comprobante.HaberUs

      If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
         item.SaldoBs += comprobante.DebeBs - comprobante.HaberBs
         item.SaldoUs += comprobante.DebeUs - comprobante.HaberUs
      ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
         item.SaldoBs += comprobante.HaberBs - comprobante.DebeBs
         item.SaldoUs += comprobante.HaberUs - comprobante.DebeUs
      End If

      moListaEmpresa_Cuenta_Totales.Item(lngIndexEmpresa) = item

      Return item
   End Function

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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroMayorConsolidado))
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
      Me.ExportExcel1 = New Janus.Windows.UI.CommandBars.UICommand("ExportExcel")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(320, 28)
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
      'ExportExcel
      '
      Me.ExportExcel.ImageIndex = 7
      Me.ExportExcel.Key = "ExportExcel"
      Me.ExportExcel.Name = "ExportExcel"
      Me.ExportExcel.Text = "Exportar"
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
      'frmLibroMayorConsolidado
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmLibroMayorConsolidado"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Libro Mayor Consolidado por Cuentas"
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

         Case "ExportExcel"
            Call ExportToExcelLoad()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmLibroMayorConsolidado_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmLibroMayorConsolidado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

      mdatFechaIniOri = mdatFechaIniInt
      mdatFechaFinOri = mdatFechaFinInt

      moCompDet = New clsCompDet(clsAppInfo.ConnectString)
      moPlan = New clsPlan(clsAppInfo.ConnectString)
   End Sub

#Region " LIBRO-MAYOR "
#Region " Metodo-LibroMayor "

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Id"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
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

#End Region

#Region " DataSet-LibroMayor "
   Private Sub moDataSetInit()
      moDataTable = New DataTable("Detalle")

      moDataTable.Columns.Add("Id", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EmpresaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EmpresaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoCompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCompDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompNro", Type.GetType("System.String"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.DateTime"))
      moDataTable.Columns.Add("CompDetDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCambio", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("HaberBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("HaberUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoUs", Type.GetType("System.Decimal"))
   End Sub

#End Region

#Region " Grid-LibroMayor "

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Libro Mayor Consolidado por Cuentas"
         .CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.EntireRow

         .RootTable.Columns("Id").Visible = False
         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("EmpresaDes").Caption = "Empresa - Gestión"
         .RootTable.Columns("EmpresaDes").Width = 200
         .RootTable.Columns("EmpresaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EmpresaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanCta").Visible = False
         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo"
         .RootTable.Columns("TipoCompDes").Width = 70
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNro").Caption = "Nro"
         .RootTable.Columns("CompNro").Width = 80
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompDetId").Visible = False

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompDetDes").Caption = "Glosa"
         .RootTable.Columns("CompDetDes").Width = 300
         .RootTable.Columns("CompDetDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompDetDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCambio").Caption = "T.C."
         .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
         .RootTable.Columns("TipoCambio").Width = 40
         .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("TipoCambio").Visible = mlngMonedaId = 4

         .RootTable.Columns("DebeBs").Caption = "Debe Bs."
         .RootTable.Columns("DebeBs").FormatString = DecimalMask()
         .RootTable.Columns("DebeBs").Width = 80
         .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("DebeBs").Visible = mlngMonedaId = clsMoneda.BOLIVIANOS Or mlngMonedaId = 4

         .RootTable.Columns("HaberBs").Caption = "Haber Bs."
         .RootTable.Columns("HaberBs").FormatString = DecimalMask()
         .RootTable.Columns("HaberBs").Width = 80
         .RootTable.Columns("HaberBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("HaberBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("HaberBs").Visible = mlngMonedaId = clsMoneda.BOLIVIANOS Or mlngMonedaId = 4

         .RootTable.Columns("SaldoBs").Caption = "Saldo Bs."
         .RootTable.Columns("SaldoBs").FormatString = DecimalMask()
         .RootTable.Columns("SaldoBs").Width = 80
         .RootTable.Columns("SaldoBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SaldoBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SaldoBs").Visible = mlngMonedaId = clsMoneda.BOLIVIANOS Or mlngMonedaId = 4

         .RootTable.Columns("DebeUs").Caption = "Debe Us."
         .RootTable.Columns("DebeUs").FormatString = DecimalMask()
         .RootTable.Columns("DebeUs").Width = 80
         .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("DebeUs").Visible = mlngMonedaId = clsMoneda.DOLARES Or mlngMonedaId = 4

         .RootTable.Columns("HaberUs").Caption = "Haber Us."
         .RootTable.Columns("HaberUs").FormatString = DecimalMask()
         .RootTable.Columns("HaberUs").Width = 80
         .RootTable.Columns("HaberUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("HaberUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("HaberUs").Visible = mlngMonedaId = clsMoneda.DOLARES Or mlngMonedaId = 4

         .RootTable.Columns("SaldoUs").Caption = "Saldo Us."
         .RootTable.Columns("SaldoUs").FormatString = DecimalMask()
         .RootTable.Columns("SaldoUs").Width = 80
         .RootTable.Columns("SaldoUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SaldoUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("SaldoUs").Visible = mlngMonedaId = clsMoneda.DOLARES Or mlngMonedaId = 4
      End With

      Call AddConditionalFormatting()
   End Sub

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

   Private Sub CargarVariablesGlobalesEmpresa(ByVal empresa As EmpresaData)
      mstrConnectString = empresa.ConnectString
      mlngEmpresaId = empresa.EmpresaId
      mlngGestionId = empresa.GestionId
      Call FechasEmpresaLoad(empresa.GestionId)
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow, ByVal lngIndexEmpresa As Long) As DataRow
      Dim oNewRow As DataRow
      oNewRow = moDataTable.NewRow

      oNewRow("EmpresaId") = lngIndexEmpresa
      oNewRow("EmpresaDes") = moListaEmpresas.Item(lngIndexEmpresa).EmpresaDes & " - " & moListaEmpresas.Item(lngIndexEmpresa).Gestion
      oNewRow("PlanCta") = moPlan.PlanCta
      oNewRow("TipoCompId") = oDataRow("TipoCompId")
      oNewRow("TipoCompDes") = oDataRow("TipoCompDes")
      oNewRow("CompNro") = oDataRow("CompNro")
      oNewRow("Fecha") = oDataRow("Fecha")
      If mboolCuenta Then
         oNewRow("CompDetDes") = oDataRow("CompDetDes")
      Else
         oNewRow("CompDetDes") = oDataRow("EntregadoA")
      End If
      oNewRow("CompDetId") = oDataRow("CompDetId")
      oNewRow("CompId") = oDataRow("CompId")
      oNewRow("TipoCambio") = oDataRow("TipoCambio")
      oNewRow("DebeBs") = oDataRow("DebeBs")
      oNewRow("HaberBs") = oDataRow("HaberBs")
      oNewRow("DebeUs") = oDataRow("DebeUs")
      oNewRow("HaberUs") = oDataRow("HaberUs")

      Dim comprobante As New CuentaEmpresa_Monto_Total()
      comprobante.DebeBs = ToDecimal(oDataRow("DebeBs"))
      comprobante.HaberBs = ToDecimal(oDataRow("HaberBs"))
      comprobante.DebeUs = ToDecimal(oDataRow("DebeUs"))
      comprobante.HaberUs = ToDecimal(oDataRow("HaberUs"))
      comprobante = SumarTotales(comprobante, 0)

      oNewRow("SaldoBs") = comprobante.SaldoBs
      oNewRow("SaldoUs") = comprobante.SaldoUs

      If ToDecimalCinco(oNewRow("DebeBs")) = 0 Then
         oNewRow("DebeBs") = System.Convert.DBNull
      End If

      If ToDecimalCinco(oNewRow("HaberBs")) = 0 Then
         oNewRow("HaberBs") = System.Convert.DBNull
      End If

      If ToDecimalCinco(oNewRow("DebeUs")) = 0 Then
         oNewRow("DebeUs") = System.Convert.DBNull
      End If

      If ToDecimalCinco(oNewRow("HaberUs")) = 0 Then
         oNewRow("HaberUs") = System.Convert.DBNull
      End If

      Return oNewRow
   End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
   End Function

   Private Sub grdMainLoad()
      Try
         Call moDataSetInit()
         mstrTipoAsientoId = TipoAsientoIdListaLoad()

         For Each strPlanCta As String In moLista
            Call VariablesPlanCuentaInit()
            Dim odtPlanCuentaMerge As New DataTable
            Dim Clono_Estructura As Boolean = False

            For pos = 0 To moListaEmpresas.Count - 1 Step 1
               Call CargarVariablesGlobalesEmpresa(moListaEmpresas.Item(pos))
               Call CargarCuenta(strPlanCta)

               If pos = 0 Then 'se guarda el nombre y cta de la cuenta base para usar en el header
                  mstrPlanCta = moPlan.PlanCta
                  mstrPlanDes = moPlan.PlanDes
               End If

               With moCompDet
                  Dim Hay_Movimiento_Cuenta As Boolean = False
                  If CargarMovimientoCuenta(moPlan.PlanId, pos) Then
                     If Not Clono_Estructura Then
                        odtPlanCuentaMerge = moCompDet.DataSet.Tables(moCompDet.TableName).Clone
                        Clono_Estructura = True
                     End If
                     odtPlanCuentaMerge.Merge(moCompDet.DataSet.Tables(moCompDet.TableName))
                     Hay_Movimiento_Cuenta = True
                  End If

                  If Hay_Movimiento_Cuenta Or mboolSinMovimiento Then
                     Call EditHeaderCuenta(pos) 'crea la cabecera y edita.- carga el saldo anterior
                  End If
               End With
            Next

            If odtPlanCuentaMerge.Rows.Count > 0 Then 'si hay movimiento en la tabla Merge
               'odtPlanCuentaMerge.DefaultView.Sort = "Periodo Asc, CompNro, TipoCompId, MesId, Dia " 'Orden de datos de 1 cuenta de todas las empresas 
               odtPlanCuentaMerge.DefaultView.Sort = "Periodo Asc, MesId, Dia, CompNro, TipoCompId " 'Orden de datos de 1 cuenta de todas las empresas 

               Dim posEmpresa As Long = 0, lngTipoCompId As Long = 0, lngCompNro As Long = 0
               Dim posCompNro As Long = 0

               For Each oRowView As DataRowView In odtPlanCuentaMerge.DefaultView
                  Dim oRow = oRowView.Row
                  posEmpresa = ToLong(oRow("Id"))
                  moDataTable.Rows.Add(GetRow(oRow, posEmpresa))
               Next
            End If

            If mlngHeaderCuentaIndex > -1 Or mboolSinMovimiento Then
               Call GetFooterCuenta()
            End If
         Next

         grdMain.DataSource = moDataTable.DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

#Region "Cuenta"

   Private Sub VariablesPlanCuentaInit()
      mlngGrupo = 0
      mlngHeaderCuentaIndex = -1
      moListaEmpresa_Cuenta_Totales.Clear()
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

   Private Function CargarMovimientoCuenta(ByVal lngPlanId As Long, ByVal lngPos As Long) As Boolean
      moCompDet = New clsCompDet(mstrConnectString)
      CargarMovimientoCuenta = False
      Try
         With moCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorEmpresas

            If mboolIntervaloFecha Then
               .WhereFilter = clsCompDet.WhereFilters.LibroMayorFecha
               .Fecha = ToDate(mdatFechaIniInt)
               .CompDetDes = ToDate(mdatFechaFinInt)
            Else
               .WhereFilter = clsCompDet.WhereFilters.LibroMayor
            End If

            .OrderByFilter = clsCompDet.OrderByFilters.Fecha

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
            .CompDetIdOrg = lngPos
            .CompDetId = mdatFechaIni.Month
            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               CargarMovimientoCuenta = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   Private Function GetFooterCuenta() As DataRow
      moDataTable.Rows.Add(GetFooter)
      moDataTable.Rows.Add(GetRowNull)
   End Function

   Private Function GetFooter() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      oRow("Id") = -1
      oRow("TipoCompDes") = "Totales"
      oRow("CompNro") = mstrPlanCta
      oRow("CompDetDes") = mstrPlanDes

      'For IndexEmpresa = 0 To moListaEmpresas.Count - 1 Step 1
      'If moListaEmpresa_Cuenta_Totales.ContainsKey(IndexEmpresa) Then
      Dim cuenta As CuentaEmpresa_Monto_Total = moListaEmpresa_Cuenta_Totales.Item(0)
      oRow("DebeBs") = ToDecimal(oRow("DebeBs")) + ToDecimal(cuenta.DebeBs)
      oRow("HaberBs") = ToDecimal(oRow("HaberBs")) + ToDecimal(cuenta.HaberBs)
      oRow("DebeUs") = ToDecimal(oRow("DebeUs")) + ToDecimal(cuenta.DebeUs)
      oRow("HaberUs") = ToDecimal(oRow("HaberUs")) + ToDecimal(cuenta.HaberUs)
      'End If
      'Next

      Return oRow
   End Function

   Private Sub EditHeaderCuenta(ByVal pos As Long)
      If mlngHeaderCuentaIndex = -1 Then
         moDataTable.Rows.Add(GetHeader)
         mlngHeaderCuentaIndex = moDataTable.Rows.Count - 1
      End If

      Dim decSaldoAntBs As Decimal = 0, decSaldoAntUs As Decimal = 0
      If mboolSaldoAnterior Then
         Dim oRowCuenta As DataRow = moDataTable.Rows(mlngHeaderCuentaIndex)
         decSaldoAntBs = PlanSaldoAnteriorBs(moPlan.PlanId, decSaldoAntUs)
         oRowCuenta("SaldoBs") = ToDecimal(oRowCuenta("SaldoBs")) + decSaldoAntBs
         oRowCuenta("SaldoUs") = ToDecimal(oRowCuenta("SaldoUs")) + decSaldoAntUs

         'Call SumarSaldoAnt(pos, decSaldoAntBs, decSaldoAntUs) 'para los totales de la cuenta
         Call SumarSaldoAnt(0, decSaldoAntBs, decSaldoAntUs) 'para los totales de la cuenta
      End If
   End Sub

   Private Function GetHeader() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("Id") = -1
      oRow("TipoCompDes") = "Cuenta"
      oRow("CompNro") = mstrPlanCta
      oRow("CompDetDes") = mstrPlanDes

      Return oRow
   End Function

   Private Function PlanSaldoAnteriorBs(ByVal lngPlanId As Long, ByRef decSaldoUs As Decimal) As Decimal
      Dim oCompDet As New clsCompDet(mstrConnectString)
      Dim decSaldoBs As Decimal = 0

      decSaldoUs = 0

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

            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                     decSaldoBs += ToDecimalCinco(oRow("DebeBs") - oRow("HaberBs"))
                     decSaldoUs += ToDecimalCinco(oRow("DebeUs") - oRow("HaberUs"))

                  ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                     decSaldoBs += ToDecimalCinco(oRow("HaberBs") - oRow("DebeBs"))
                     decSaldoUs += ToDecimalCinco(oRow("HaberUs") - oRow("DebeUs"))
                  End If
               Next

               PlanSaldoAnteriorBs = decSaldoBs
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

#End Region

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

   Private Sub PrintReport()
      Try
         If (mlngMonedaId = 1) Or (mlngMonedaId = 2) Then
            Dim rpt As New rptLibroMayorComparativo

            rpt.DataSource = GetDataView(moDataTable)

            rpt.lblTitle.Text = "Libro Mayor Comparativo por Empresas"
            rpt.Document.Name = "Libro Mayor Comparativo por Empresas"
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            rpt.txtFechaIni.Text = Format(mdatFechaIniOri, "dd/MM/yyyy") 'ConvertDMY(mdatFechaIniOri)
            rpt.txtFechaFin.Text = Format(mdatFechaFinOri, "dd/MM/yyyy")

            If mlngMonedaId = 1 Then
               rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
               rpt.txtDebeUs.Visible = False
               rpt.txtHaberUs.Visible = False
               rpt.txtSaldoUs.Visible = False

            ElseIf mlngMonedaId = 2 Then
               rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
               rpt.txtDebeBs.Visible = False
               rpt.txtHaberBs.Visible = False
               rpt.txtSaldoBs.Visible = False
            End If

            'Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

            rpt.Run(True)
            Dim frm As frmReportPreview
            frm = New frmReportPreview(rpt.Document, Me)
            frm.Show()

         ElseIf (mlngMonedaId = 3) Or (mlngMonedaId = 4) Then
            Dim rpt As New rptLibroMayorComparativoExt

            rpt.DataSource = GetDataView(moDataTable)

            rpt.lblTitle.Text = "Libro Mayor Comparativo por Empresas"
            rpt.Document.Name = "Libro Mayor Comparativo por Empresas"
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            rpt.txtFechaIni.Text = Format(mdatFechaIniOri, "dd/MM/yyyy") 'ConvertDMY(mdatFechaIniOri)
            rpt.txtFechaFin.Text = Format(mdatFechaFinOri, "dd/MM/yyyy")

            rpt.txtMoneda.Text = "Ambas"

            'Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

            rpt.Run(True)
            Dim frm As New frmReportPreview(rpt.Document, Me)
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Sub

   Private Sub frmLibroMayorConsolidado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            'Call DataEdit()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmLibroMayorConsolidado_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompDet.Dispose()
      moPlan.Dispose()
      Call ClearMemory()
   End Sub

End Class
