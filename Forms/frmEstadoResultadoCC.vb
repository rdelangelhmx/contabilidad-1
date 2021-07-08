Public Class frmEstadoResultadoCC
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan

   Private moListaTipoAsiento As New Queue
   Private moListaCC As List(Of Long)
   Private mstrTipoAsientoId As String
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
   Private mboolTotalizar As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean
   Private mboolIntervaloFecha As Boolean 'Solo se ocupa en LibroMayor
   Private mboolSaldoGestion As Boolean
   Private mlngMaxColumnPrint1 As Long = 5
   Private mboolIncluirPlanAdd As Boolean

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moDataTableAux As DataTable

   Private mdecHaberBs As Decimal
   Private mdecDebeBs As Decimal
   Private mdecHaberUs As Decimal
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Private mdecDebeUs As Decimal
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportToExcel1 As Janus.Windows.UI.CommandBars.UICommand

#Region " Set and Get "
   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Private mlngMostrarCC As Long

   Public Property MostrarCC() As Long
      Get
         Return mlngMostrarCC
      End Get
      Set(ByVal value As Long)
         mlngMostrarCC = value
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

   Public Property ListaCC() As List(Of Long)
      Get
         Return moListaCC
      End Get
      Set(ByVal value As List(Of Long))
         moListaCC = value
      End Set
   End Property

#End Region

#Region " C�digo generado por el Dise�ador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Dise�ador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

   'Requerido por el Dise�ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Dise�ador de Windows Forms. 
   'No lo modifique con el editor de c�digo.
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents ExportToExcel As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoResultadoCC))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
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
      Me.ExportToExcel = New Janus.Windows.UI.CommandBars.UICommand("ExportToExcel")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.gexMain = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
      Me.ExportToExcel1 = New Janus.Windows.UI.CommandBars.UICommand("ExportToExcel")
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
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2, Me.ExportToExcel})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator4, Me.ExportToExcel1, Me.Separator3, Me.Exit1})
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
      'ExportToExcel
      '
      Me.ExportToExcel.ImageIndex = 7
      Me.ExportToExcel.Key = "ExportToExcel"
      Me.ExportToExcel.Name = "ExportToExcel"
      Me.ExportToExcel.Text = "Exportar"
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
      'ExportToExcel1
      '
      Me.ExportToExcel1.Key = "ExportToExcel"
      Me.ExportToExcel1.Name = "ExportToExcel1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'frmEstadoResultadoCC
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmEstadoResultadoCC"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Estado de Resultados Comparativo por Centros de Costo"
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

         Case "ExportToExcel"
            Call ExportToExcelLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmEstadoResultadoCC_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmEstadoResultadoCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

      'If mboolSaldoGestion Then
      '   mlngMaxColumn = 4
      'Else
      '   mlngMaxColumn = 5
      'End If
      If mlngMostrarCC > mlngMaxColumnPrint1 Then
         cdmMain.Commands.Item("Print").Visible = Janus.Windows.UI.InheritableBoolean.False
      End If

      moPlan = New clsPlan(clsAppInfo.ConnectString)
   End Sub

   Private Sub frmLibroMayorLoad()
      Dim oListaPlan As New Queue
      Dim lngPlanId As Long
      Dim oListaCC As New Queue
      Dim strCCDes As String = ""

      If (grdMain.GetRow.Selected) And grdMain.CurrentColumn IsNot Nothing Then
         If grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralBs") Or grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralUs") Then
            Dim indice As Long = ToLong(grdMain.CurrentColumn.DataMember.Substring(6))
            If indice > 0 Then
               If indice > mlngMostrarCC Then
                  For i = mlngMostrarCC To moListaCC.Count - 1
                     oListaCC.Enqueue(moListaCC.Item(i))
                  Next
               Else
                  oListaCC.Enqueue(moListaCC.Item(indice - 1))
               End If
            End If
         End If

         If (ToLong(grdMain.GetValue("PlanId")) > 0) And (ToBoolean(grdMain.GetValue("EsAna"))) Then
            oListaPlan.Enqueue(ToLong(grdMain.GetValue("PlanId")))
            lngPlanId = ToLong(grdMain.GetValue("PlanId"))
         End If

         If oListaPlan.Count Then
            If oListaCC.Count > 0 Then
               Dim frm As New frmLibroCentroCosto

               With frm
                  .EmpresaId = mlngEmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .MonedaId = mlngMonedaId
                  .SaldoAnterior = False
                  .Cuenta = True
                  ' .SinMovimiento = False
                  .IncluirDetalle = True
                  .IntervaloFecha = True
                  .FechaIni = ToDate(mdatFechaIniInt)
                  .FechaFin = ToDate(mdatFechaFinInt)
                  .OrdenarFecha = True
                  .SinFac = mboolSinFac
                  .ConFac = mboolConFac
                  .Lista = oListaCC
                  .ListaPlan = oListaPlan
                  .ListaTipoAsiento = moListaTipoAsiento
                  .FechaIni = ToDate(mdatFechaIniInt)
                  .FechaFin = ToDate(mdatFechaFinInt)
                  .Text = "Libro Mayor de " & ConvertDMY(ToDate(mdatFechaIniInt)) & " a " & ConvertDMY(ToDate(mdatFechaFinInt))
                  .MdiParent = Me.MdiParent
                  frm.Show()

                  For Each CCId In oListaCC
                     strCCDes &= CentroCostoFind(CCId) & ", "
                  Next

                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & PlanDesFind(ToLong(grdMain.GetValue("PlanId"))) & "; CC: " & strCCDes)
               End With
            End If
         Else
            MessageBox.Show("Cuenta Inv�lida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      End If

   End Sub

   'Private Sub frmLibroMayorLoad()
   '   Dim oLista As New Queue

   '   If mlngCentroCostoId = 0 Then
   '      Dim lngPlanId As Long

   '      If (ToLong(grdMain.GetValue("PlanId")) > 0) And (ToBoolean(grdMain.GetValue("EsAna"))) Then
   '         oLista.Enqueue(ToLong(grdMain.GetValue("PlanId")))
   '         lngPlanId = ToLong(grdMain.GetValue("PlanId"))
   '      End If

   '      If oLista.Count Then
   '         Dim frm As New frmLibroMayor

   '         With frm
   '            .EmpresaId = mlngEmpresaId
   '            .GestionId = clsAppInfo.GestionId
   '            .MonedaId = mlngMonedaId
   '            .SaldoAnterior = False
   '            .Cuenta = True
   '            .SinMovimiento = False
   '            .IntervaloFecha = mboolIntervaloFecha
   '            .FechaIni = ToDate(mdatFechaIniInt)
   '            .FechaFin = ToDate(mdatFechaFinInt)
   '            .OrdenarFecha = True
   '            .Lista = oLista
   '            .SinFac = mboolSinFac
   '            .ConFac = mboolConFac
   '            .ListaTipoAsiento = moListaTipoAsiento
   '            frm.ShowDialog()

   '            If frm.Changed Then
   '               Call grdMainLoad()
   '               Call grdMainFindRow(lngPlanId)
   '            End If

   '            frm.Dispose()
   '         End With
   '      Else
   '         MessageBox.Show("Cuenta Inv�lida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If

   '   Else
   '      oLista.Enqueue(mlngCentroCostoId)

   '      If oLista.Count Then
   '         If (ToLong(grdMain.GetValue("PlanId")) > 0) And (ToBoolean(grdMain.GetValue("EsAna"))) Then
   '            Dim frm As New frmLibroCentroCosto

   '            With frm
   '               .EmpresaId = mlngEmpresaId
   '               .GestionId = clsAppInfo.GestionId
   '               .MonedaId = mlngMonedaId
   '               .PlanId = ToLong(grdMain.GetValue("PlanId"))
   '               .SaldoAnterior = False
   '               .Cuenta = True
   '               .IncluirDetalle = True
   '               .IntervaloFecha = mboolIntervaloFecha
   '               .FechaIni = ToDate(mdatFechaIniInt)
   '               .FechaFin = ToDate(mdatFechaFinInt)
   '               .OrdenarFecha = True
   '               .Lista = oLista
   '               .SinFac = mboolSinFac
   '               .ConFac = mboolConFac

   '               .MdiParent = Me.MdiParent
   '               .Show()
   '            End With
   '         Else
   '            MessageBox.Show("Cuenta Inv�lida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '         End If
   '      Else
   '         MessageBox.Show("Debe Seleccionar al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '      End If
   '   End If
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
      Dim rpt As New rptEstadoResultadoCC
      Dim strMonedaSigla As String

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moPlan.TableName))

      rpt.lblTitle.Text = "Estado de Resultados Comparativo por Centros de Costo"
      rpt.Document.Name = "Estado de Resultados Comparativo por Centros de Costo"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIniInt) ' ConvertDMY(mstrFechaIni)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFinInt) 'ConvertDMY(mstrFechaFin)


      If mlngMonedaId = 1 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId, strMonedaSigla)
         'rpt.txtPlanDes.Width = 5

         rpt.lblCol07.Text = "TOTAL"
         rpt.txtCol07.DataField = "GralTotalBs"

         Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count, mlngMostrarCC + 1)

         If mlngMostrarCC < moListaCC.Count Then
            rpt.lblCol06.Text = "OTROS"
         Else
            rpt.lblCol06.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
         End If
         rpt.txtCol06.DataField = "GralBs" & lngMax

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol05.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol05.DataField = "GralBs" & lngMax
         End If

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol04.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol04.DataField = "GralBs" & lngMax
         End If

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol03.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol03.DataField = "GralBs" & lngMax
         End If

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol02.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol02.DataField = "GralBs" & lngMax
         End If

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol01.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol01.DataField = "GralBs" & lngMax
         End If

      ElseIf mlngMonedaId = 2 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId, strMonedaSigla)
         rpt.lblCol07.Text = "TOTAL"
         rpt.txtCol07.DataField = "GralTotalUs"

         Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count, mlngMostrarCC + 1)

         If mlngMostrarCC < moListaCC.Count Then
            rpt.lblCol06.Text = "OTROS"
         Else
            rpt.lblCol06.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
         End If
         rpt.txtCol06.DataField = "GralUs" & lngMax

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol05.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol05.DataField = "GralUs" & lngMax
         End If

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol04.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol04.DataField = "GralUs" & lngMax
         End If

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol03.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol03.DataField = "GralUs" & lngMax
         End If

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol02.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol02.DataField = "GralUs" & lngMax
         End If

         lngMax -= 1
         If lngMax > 0 Then
            rpt.lblCol01.Text = CentroCostoDesFind(moListaCC.Item(lngMax - 1))
            rpt.txtCol01.DataField = "GralUs" & lngMax
         End If
      End If

      'Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

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

   Private Sub frmEstadoResultadoCC_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
   End Sub


#Region " Otros Metodos "
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

   Private Function MonedaDesFind(ByVal lngMonedaId As Long, ByRef strMonedaSigla As String) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      MonedaDesFind = String.Empty
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
#End Region

#Region " ESTADO RESULTADO "
#Region " DataSet-Estado Resultado "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moPlan.TableName)

      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EsAna", Type.GetType("System.Byte"))
      moDataTable.Columns.Add("SucCCOId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))

      Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count, mlngMostrarCC + 1)

      For index As Integer = 1 To lngMax
         moDataTable.Columns.Add("GralBs" & index, Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("GralUs" & index, Type.GetType("System.Decimal"))
      Next

      moDataTable.Columns.Add("GralTotalBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralBsGes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralTotalUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralUsGes", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("TipoGrupoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Nivel", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SW", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanPadreId", Type.GetType("System.Int32"))

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

         If ToBoolean(oDataRow("TieneAnaAdd")) And mboolIncluirPlanAdd And ToBoolean(oDataRow("MostrarAnaAdd")) Then
            Call PlanAddLoad(oDataRow("PlanId"), strTab & "     ", ToLong(oDataRow("Nivel")), ToLong(oRow("TipoGrupoId")))
         End If
      End If
   End Function

   Private Sub UpdateRowDataTable(ByVal lngIndex As Long)
      Dim datatableCompDet As DataTable
      Dim oRow As DataRow
      oRow = moDataTable.Rows(lngIndex)

      If ToBoolean(oRow("EsAna")) Then
         datatableCompDet = LoadCompDet(ToLong(oRow("PlanId")), clsCompDet.WhereFilters.RowSumFecha)
         If datatableCompDet IsNot Nothing Then
            Dim datFechaIni As Date = mdatFechaIniInt
            Dim datFechaFin As Date = mdatFechaFinInt

            Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count + 1, mlngMostrarCC + 2)

            For index As Integer = 1 To lngMax
               Dim strCentroCosto As String = ""

               If (moListaCC.Count <= mlngMostrarCC And index = lngMax) Or (moListaCC.Count > mlngMostrarCC And index = lngMax) Then
                  datFechaIni = mdatFechaIni
                  datFechaFin = mdatFechaFin

                  strCentroCosto = "CentroCostoId in ("
                  For i = 0 To moListaCC.Count - 1
                     strCentroCosto &= moListaCC.Item(i) & ","
                  Next
                  strCentroCosto = strCentroCosto.Substring(0, strCentroCosto.Length - 1)
                  strCentroCosto &= ") and "
               ElseIf moListaCC.Count > mlngMostrarCC And index = lngMax - 1 Then
                  strCentroCosto = "CentroCostoId in ("
                  For i = mlngMostrarCC To moListaCC.Count - 1
                     strCentroCosto &= moListaCC.Item(i) & ","
                  Next
                  strCentroCosto = strCentroCosto.Substring(0, strCentroCosto.Length - 1)
                  strCentroCosto &= ") and "
               Else
                  strCentroCosto = "CentroCostoId = " & moListaCC.Item(index - 1) & " and "
               End If

               Dim strFiltro As String = strCentroCosto & "Fecha >= '" & ToDateDMY(datFechaIni) & "' and Fecha <= '" & ToDateDMY(datFechaFin) & "'"
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
                  If (moListaCC.Count <= mlngMostrarCC And index = lngMax) Or (moListaCC.Count > mlngMostrarCC And index = lngMax) Then
                     oRow("GralBsGes") = ToDecimal(mdecDebeBs - mdecHaberBs)
                     oRow("GralUsGes") = ToDecimal(mdecDebeUs - mdecHaberUs)
                  Else
                     oRow("GralBs" & index) = ToDecimal(mdecDebeBs - mdecHaberBs)
                     oRow("GralUs" & index) = ToDecimal(mdecDebeUs - mdecHaberUs)

                     oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
                     oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))
                  End If
               ElseIf ToLong(oRow("TipoGrupoId")) = 2 Or ToLong(oRow("TipoGrupoId")) = 3 Or ToLong(oRow("TipoGrupoId")) = 4 Or ToLong(oRow("TipoGrupoId")) = 8 Then
                  If (moListaCC.Count <= mlngMostrarCC And index = lngMax) Or (moListaCC.Count > mlngMostrarCC And index = lngMax) Then
                     oRow("GralBsGes") = ToDecimal(mdecHaberBs - mdecDebeBs)
                     oRow("GralUsGes") = ToDecimal(mdecHaberUs - mdecDebeUs)
                  Else
                     oRow("GralBs" & index) = ToDecimal(mdecHaberBs - mdecDebeBs)
                     oRow("GralUs" & index) = ToDecimal(mdecHaberUs - mdecDebeUs)

                     oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
                     oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))
                  End If
               End If
               'datFechaIni = datFechaIni.AddMonths(1)
               'datFechaIni = DateSerial(Year(datFechaIni), Month(datFechaIni), 1)
            Next

            If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralTotalBs")))) = 0 And ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralTotalUs")))) = 0 Then
               If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralBsGes")))) > 0 Or ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralUsGes")))) > 0 Then
                  AddRowDataTableAux(oRow)
               End If
               DeleteCuentaAndAnaliticoAdd(lngIndex, ToLong(oRow("PlanId")))
            End If
         Else
            DeleteCuentaAndAnaliticoAdd(lngIndex, ToLong(oRow("PlanId")))
         End If
      Else
         Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count + 1, mlngMostrarCC + 2)
         For index As Integer = 1 To lngMax
            If (moListaCC.Count <= mlngMostrarCC And index = lngMax) Or (moListaCC.Count > mlngMostrarCC And index = lngMax) Then
               oRow("GralBsGes") = ToDecimal(moDataTable.Compute("Sum(GralBsGes)", "PlanPadreId = " & ToLong(oRow("PlanId"))))
               oRow("GralUsGes") = ToDecimal(moDataTable.Compute("Sum(GralUsGes)", "PlanPadreId = " & ToLong(oRow("PlanId"))))
            Else
               oRow("GralBs" & index) = ToDecimal(moDataTable.Compute("Sum(GralBs" & index & ")", "PlanPadreId = " & ToLong(oRow("PlanId"))))
               oRow("GralUs" & index) = ToDecimal(moDataTable.Compute("Sum(GralUs" & index & ")", "PlanPadreId = " & ToLong(oRow("PlanId"))))

               oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
               oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))
            End If
         Next
         oRow("GralBsGes") += ToDecimal(moDataTableAux.Compute("Sum(GralBs)", "PlanPadreId = " & ToLong(oRow("PlanId"))))
         oRow("GralUsGes") += ToDecimal(moDataTableAux.Compute("Sum(GralUs)", "PlanPadreId = " & ToLong(oRow("PlanId"))))

         If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralTotalBs")))) = 0 And ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralTotalUs")))) = 0 Then
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
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanDes") = "TOTAL " & strPlanDes

      Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count, mlngMostrarCC + 1)
      For index As Integer = 1 To lngMax
         oRow("GralBs" & index) = ToDecimal(moDataTable.Compute("Sum(GralBs" & index & ")", "PlanPadreId = " & lngPlanId))
         oRow("GralUs" & index) = ToDecimal(moDataTable.Compute("Sum(GralUs" & index & ")", "PlanPadreId = " & lngPlanId))

         oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
         oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))
      Next
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
            Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count, mlngMostrarCC + 1)
            For index As Integer = 1 To lngMax
               oRow("GralBs" & index) = ToDecimal(oRow("GralBs" & index)) + ToDecimal(row("GralBs" & index))
               oRow("GralUs" & index) = ToDecimal(oRow("GralUs" & index)) + ToDecimal(row("GralUs" & index))
            Next
            oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(row("GralTotalBs"))
            oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(row("GralTotalUs"))

         ElseIf ToLong(row("PlanPadreId")) = 0 And (ToStr(row("PlanCta")).Equals("5") _
         Or ToStr(row("PlanCta")).Equals("6")) Then
            Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count, mlngMostrarCC + 1)
            For index As Integer = 1 To lngMax
               oRow("GralBs" & index) = ToDecimal(oRow("GralBs" & index)) - ToDecimal(row("GralBs" & index))
               oRow("GralUs" & index) = ToDecimal(oRow("GralUs" & index)) - ToDecimal(row("GralUs" & index))
            Next
            oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) - ToDecimal(row("GralTotalBs"))
            oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) - ToDecimal(row("GralTotalUs"))
         End If

         If ToLong(row("EsAna")) <> 1 And ToLong(row("PlanId")) <> 0 And Not mboolTotalizar Then
            Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count, mlngMostrarCC + 1)
            For index As Integer = 1 To lngMax
               row("GralBs" & index) = System.Convert.DBNull
               row("GralUs" & index) = System.Convert.DBNull
            Next
            row("GralTotalBs") = System.Convert.DBNull
            row("GralTotalUs") = System.Convert.DBNull
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

   Private Function TieneMovimiento(ByVal lngPlanId As Long, ByVal lngNivel As Long) As Boolean
      TieneMovimiento = False
      For Each row In moDataTable.Rows
         If ToLong(row("PlanPadreId")) = lngPlanId And ToLong(row("Nivel")) = lngNivel + 1 Then
            'temp
            'If Math.Abs(ToDecimal(row("GralTotalBs"))) > 0.05 Or _
            'Math.Abs(ToDecimal(row("GralTotalUs"))) > 0.05 Or _
            'ToLong(row("SW")) = 1 Then
            '   TieneMovimiento = True
            '   Exit For
            'End If
            If ToDecimalMinor(Math.Abs(ToDecimal(row("GralTotalBs")))) > 0 Or _
            ToDecimalMinor(Math.Abs(ToDecimal(row("GralTotalUs")))) > 0 Or _
            ToLong(row("SW")) = 1 Then
               TieneMovimiento = True
               Exit For
            End If
         End If
      Next
   End Function

   Private Function LoadCompDet(ByVal lngPlanId As Long, ByVal bytWhere As Byte) As DataTable
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

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
            '.Fecha = ToDate(mdatFechaIniInt)
            '.CompDetDes = ToDate(mdatFechaFinInt)
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

   Private Function SaldoPlanAddBs(ByVal lngPlanId As Long, ByVal lngPlanAddId As Long, _
      ByVal lngTipoGrupoId As Long) As DataTable 'As Decimal
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0
      SaldoPlanAddBs = Nothing
      'decSaldoUs = 0
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
            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               SaldoPlanAddBs = .DataSet.Tables(0)
               'For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
               '   If lngTipoGrupoId = 1 Or lngTipoGrupoId = 5 Or lngTipoGrupoId = 6 Or lngTipoGrupoId = 7 Then
               '      decSaldoBs += ToDecimal(oRow("DebeBs") - oRow("HaberBs"))
               '      decSaldoUs += ToDecimal(oRow("DebeUs") - oRow("HaberUs"))

               '   ElseIf lngTipoGrupoId = 2 Or lngTipoGrupoId = 3 Or lngTipoGrupoId = 4 Or lngTipoGrupoId = 8 Then
               '      decSaldoBs += ToDecimal(oRow("HaberBs") - oRow("DebeBs"))
               '      decSaldoUs += ToDecimal(oRow("HaberUs") - oRow("DebeUs"))
               '   End If
               'Next

               'SaldoPlanAddBs = decSaldoBs
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
      Dim dataTableCompPlanAdd As DataTable
      Dim decDebeBs As Decimal
      Dim decDebeUs As Decimal
      Dim decHaberBs As Decimal
      Dim decHaberUs As Decimal
      Dim decPlanAddBs As Decimal
      Dim decPlanAddUs As Decimal
      Dim lngIndexRow As Long = 0
      'Dim boolCreado As Boolean = False
      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.All
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes
            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanId

            If .Open Then
               Do While .Read
                  dataTableCompPlanAdd = SaldoPlanAddBs(.PlanId, .PlanAddId, lngTipoGrupoId)
                  If dataTableCompPlanAdd IsNot Nothing Then
                     Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count, mlngMostrarCC + 1)
                     lngIndexRow = 0
                     Dim datFechaIni As Date = mdatFechaIniInt
                     Dim datFechaFin As Date = mdatFechaFinInt

                     For index As Integer = 1 To lngMax
                        Dim strCentroCosto As String = ""

                        If moListaCC.Count > mlngMostrarCC And index = lngMax Then
                           strCentroCosto = "CentroCostoId in ("
                           For i = mlngMostrarCC To moListaCC.Count - 1
                              strCentroCosto &= moListaCC.Item(i) & ","
                           Next
                           strCentroCosto = strCentroCosto.Substring(0, strCentroCosto.Length - 1)
                           strCentroCosto &= ") and "
                        Else
                           strCentroCosto = "CentroCostoId = " & moListaCC.Item(index - 1) & " and "
                        End If

                        Dim strFiltro As String = strCentroCosto & "Fecha >= '" & ToDateDMY(datFechaIni) & "' and Fecha <= '" & ToDateDMY(datFechaFin) & "'"
                        If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                           decDebeBs = ToDecimal(dataTableCompPlanAdd.Compute("Sum(DebeBs)", strFiltro))
                           decHaberBs = ToDecimal(dataTableCompPlanAdd.Compute("Sum(HaberBs)", strFiltro))
                           decDebeUs = 0
                           decHaberUs = 0
                        ElseIf mlngMonedaId = clsMoneda.DOLARES Then
                           decDebeBs = 0
                           decHaberBs = 0
                           decDebeUs = ToDecimal(dataTableCompPlanAdd.Compute("Sum(DebeUs)", strFiltro))
                           decHaberUs = ToDecimal(dataTableCompPlanAdd.Compute("Sum(HaberUs)", strFiltro))
                        End If

                        If lngTipoGrupoId = 1 Or lngTipoGrupoId = 5 Or lngTipoGrupoId = 6 Or lngTipoGrupoId = 7 Then
                           decPlanAddBs = ToDecimal(decDebeBs - decHaberBs)
                           decPlanAddUs = ToDecimal(decDebeUs - decHaberUs)
                        ElseIf lngTipoGrupoId = 2 Or lngTipoGrupoId = 3 Or lngTipoGrupoId = 4 Or lngTipoGrupoId = 8 Then
                           decPlanAddBs = ToDecimal(decHaberBs - decDebeBs)
                           decPlanAddUs = ToDecimal(decHaberUs - decDebeUs)
                        End If

                        If ToDecimalMinor(Math.Abs(decPlanAddBs)) > 0 Or ToDecimalMinor(Math.Abs(decPlanAddUs)) > 0 Then
                           If lngIndexRow = 0 Then
                              oRow = moDataTable.NewRow
                              oRow("PlanId") = lngPlanId
                              oRow("EsAna") = 1
                              oRow("PlanCta") = .PlanAddCta
                              oRow("PlanDes") = strTab & .PlanAddDes
                              oRow("Nivel") = lngNivel
                              moDataTable.Rows.Add(oRow)
                              lngIndexRow = moDataTable.Rows.Count - 1
                           Else
                              oRow = moDataTable.Rows.Item(lngIndexRow)
                           End If

                           oRow("GralBs" & index) = decPlanAddBs
                           oRow("GralUs" & index) = decPlanAddUs

                           oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + decPlanAddBs
                           oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + decPlanAddUs
                        End If
                     Next

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

   Private Function CentroCostoFind(ByVal lngCentroCostoId As Long) As String
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)

      CentroCostoFind = String.Empty
      Try
         With oCentroCosto
            .CentroCostoId = lngCentroCostoId

            If .FindByPK Then
               CentroCostoFind = ToStr(.CentroCostoDes)
            End If
         End With

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCentroCosto.Dispose()
      End Try
   End Function

#End Region

#Region " Grid-Estado Resultado "
   Private Sub grdMainLoad()
      Call moDataSetInit()

      mstrTipoAsientoId = TipoAsientoIdListaLoad()
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
      Dim mstrCentroCostoDes As String
      With grdMain
         ebrMain.Groups(0).Text = "Estado de Resultados Comparativo por Centros de Costo"
         grdMain.RootTable.HeaderLines = 3
         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("SW").Visible = False

         .RootTable.Columns("TipoGrupoId").Visible = False

         .RootTable.Columns("EsAna").Visible = False

         .RootTable.Columns("SucCCOId").Visible = False

         .RootTable.Columns("PlanCta").Caption = "C�digo"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripci�n"
         .RootTable.Columns("PlanDes").Width = 370
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         Dim lngMax = If(mlngMostrarCC >= moListaCC.Count, moListaCC.Count, mlngMostrarCC + 1)
         For index As Integer = 1 To lngMax
            If index = mlngMostrarCC + 1 Then
               mstrCentroCostoDes = "OTROS"
            Else
               mstrCentroCostoDes = CentroCostoFind(moListaCC.Item(index - 1))
            End If

            .RootTable.Columns("GralBs" & index).Caption = mstrCentroCostoDes & "  Bs." ' & strMonedaSigla
            .RootTable.Columns("GralBs" & index).FormatString = DecimalMask()
            .RootTable.Columns("GralBs" & index).Width = 100
            .RootTable.Columns("GralBs" & index).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("GralBs" & index).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("GralUs" & index).Caption = mstrCentroCostoDes & "  Us." ' & strMonedaSigla
            .RootTable.Columns("GralUs" & index).FormatString = DecimalMask()
            .RootTable.Columns("GralUs" & index).Width = 100
            .RootTable.Columns("GralUs" & index).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("GralUs" & index).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            If mlngMonedaId = 1 Then
               .RootTable.Columns("GralUs" & index).Visible = False

            ElseIf mlngMonedaId = 2 Then
               .RootTable.Columns("GralBs" & index).Visible = False
            End If

            'datFechaIni = datFechaIni.AddMonths(1)
            'datFechaIni = DateSerial(Year(datFechaIni), Month(datFechaIni), 1)
         Next

         .RootTable.Columns("GralBsGes").Caption = "Saldo Bs. Ges."
         .RootTable.Columns("GralBsGes").FormatString = DecimalMask()
         .RootTable.Columns("GralBsGes").Width = 100
         .RootTable.Columns("GralBsGes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralBsGes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GralUsGes").Caption = "Saldo Us. Ges."
         .RootTable.Columns("GralUsGes").FormatString = DecimalMask()
         .RootTable.Columns("GralUsGes").Width = 100
         .RootTable.Columns("GralUsGes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralUsGes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GralTotalBs").Caption = "TOTAL Bs."
         .RootTable.Columns("GralTotalBs").FormatString = DecimalMask()
         .RootTable.Columns("GralTotalBs").Width = 100
         .RootTable.Columns("GralTotalBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralTotalBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GralTotalUs").Caption = "TOTAL Us."
         .RootTable.Columns("GralTotalUs").FormatString = DecimalMask()
         .RootTable.Columns("GralTotalUs").Width = 100
         .RootTable.Columns("GralTotalUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralTotalUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mlngMonedaId = 1 Then
            .RootTable.Columns("GralTotalUs").Visible = False
         ElseIf mlngMonedaId = 2 Then
            .RootTable.Columns("GralTotalBs").Visible = False
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

   Private Sub frmEstadoResultadoCC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
