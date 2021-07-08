Public Class frmSumaSaldoComparativoCC
   Inherits System.Windows.Forms.Form

   Private moListaTipoAsiento As New Queue
   Private mstrTipoAsientoId As String

   Private moCompDet As clsCompDet
   Private moPlan As clsPlan
   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long
   Private mboolIntervaloFecha As Boolean
   Private mdatFechaIni As Date
   Private mdatFechaFin As Date
   Private mboolUltimoPeriodo As Boolean
   Private mboolSaldoAnterior As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean
   Private mboolSaldoCero As Boolean
   Private moListaCC As List(Of Long)

   Private mdecSaldoAnt As Decimal
   Private mdecHaber As Decimal
   Private mdecDebe As Decimal
   Private mdecSaldo As Decimal
   Private mdecHaberPer As Decimal
   Private mdecDebePer As Decimal

   Private mdecSumSaldo As Decimal

   Private mlngGrupo As Long

   Private moDataTable As DataTable
   Friend WithEvents Export1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Export As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter

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

   Private mboolIncluirPlanAdd As Boolean
   Public Property IncluirPlanAdd() As Boolean
      Get
         Return mboolIncluirPlanAdd
      End Get
      Set(ByVal value As Boolean)
         mboolIncluirPlanAdd = value
      End Set
   End Property

   'Private mlngCentroCostoId As Long
   'Property CentroCostoId() As Long
   '   Get
   '      Return mlngCentroCostoId
   '   End Get
   '   Set(ByVal value As Long)
   '      mlngCentroCostoId = value
   '   End Set
   'End Property

   'Private mstrCentroCostoDes As String
   'Property CentroCostoDes() As String
   '   Get
   '      Return mstrCentroCostoDes
   '   End Get
   '   Set(ByVal value As String)
   '      mstrCentroCostoDes = value
   '   End Set
   'End Property

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
#End Region

   Property ListaCC() As List(Of Long)
      Get
         Return moListaCC
      End Get
      Set(ByVal value As List(Of Long))
         moListaCC = value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSumaSaldoComparativoCC))
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
      Me.Export1 = New Janus.Windows.UI.CommandBars.UICommand("Export")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.Export1, Me.Separator4, Me.Print1, Me.Separator3, Me.Exit1})
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
      'frmSumaSaldoComparativoCC
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmSumaSaldoComparativoCC"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Balance de Sumas y Saldos Comparativo por Centros de Costo"
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

         Case "Print"
            If Not mboolUltimoPeriodo Then
               Call PrintReport()
            Else
               Call PrintReportExt()
            End If

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

      moCompDet = New clsCompDet(clsAppInfo.ConnectString)
      moPlan = New clsPlan(clsAppInfo.ConnectString)

      If moListaCC.Count > 2 Then
         Print1.Visible = Janus.Windows.UI.InheritableBoolean.False
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

   Private Sub PrintReport()
      Dim rpt As New rptSumaSaldoComparativo

      rpt.DataSource = GetDataView(moDataTable)

      rpt.lblTitle.Text = "Balance de Sumas y Saldos Comparativo por Centros de Costo"
      rpt.Document.Name = "Balance de Sumas y Saldos Comparativo por Centros de Costo"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIni)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFin)
      rpt.SaldoAnterior = mboolSaldoAnterior
      rpt.lblCentroCosto.Visible = False
      rpt.txtCentroCostoCod.Visible = False
      rpt.lblTitulo.Text = "Centros de Costo: "
      rpt.lblEmpresa1.Text = CentroCostoFind(moListaCC.Item(0))
      rpt.lblEmpresa2.Text = CentroCostoFind(moListaCC.Item(1))

      rpt.txtSaldoAnt.DataField = "SaldoAnt" & moListaCC.Item(0)
      rpt.txtSaldoAnt2.DataField = "SaldoAnt" & moListaCC.Item(1)
      rpt.txtDebito.DataField = "Debe" & moListaCC.Item(0)
      rpt.txtDebito2.DataField = "Debe" & moListaCC.Item(1)
      rpt.txtCredito.DataField = "Haber" & moListaCC.Item(0)
      rpt.txtCredito2.DataField = "Haber" & moListaCC.Item(1)
      rpt.txtSaldo.DataField = "Saldo" & moListaCC.Item(0)
      rpt.txtSaldo2.DataField = "Saldo" & moListaCC.Item(1)

      If mlngMonedaId = 1 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
      ElseIf mlngMonedaId = 2 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
      End If

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub PrintReportExt()
      Dim rpt As New rptSumaSaldoComparativoExt

      rpt.DataSource = GetDataView(moDataTable)

      rpt.lblTitle.Text = "Balance de Sumas y Saldos Comparativo por Centros de Costo"
      rpt.Document.Name = "Balance de Sumas y Saldos Comparativo por Centros de Costo"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ToDateDMY(mdatFechaIni)
      rpt.txtFechaFin.Text = ToDateDMY(mdatFechaFin)
      rpt.SaldoAnterior = mboolSaldoAnterior
      rpt.lblCentroCosto.Visible = False
      rpt.txtCentroCostoCod.Visible = False
      rpt.lblTitulo.Text = "Centros de Costo: "
      rpt.lblEmpresa1.Text = CentroCostoFind(moListaCC.Item(0))
      rpt.lblEmpresa2.Text = CentroCostoFind(moListaCC.Item(1))

      rpt.txtSaldoAnt.DataField = "SaldoAnt" & moListaCC.Item(0)
      rpt.txtSaldoAnt2.DataField = "SaldoAnt" & moListaCC.Item(1)
      rpt.txtDebito.DataField = "Debe" & moListaCC.Item(0)
      rpt.txtDebito2.DataField = "Debe" & moListaCC.Item(1)
      rpt.txtCredito.DataField = "Haber" & moListaCC.Item(0)
      rpt.txtCredito2.DataField = "Haber" & moListaCC.Item(1)
      rpt.txtSaldo.DataField = "Saldo" & moListaCC.Item(0)
      rpt.txtSaldo2.DataField = "Saldo" & moListaCC.Item(1)
      rpt.txtDebitoGestion.DataField = "DebePer" & moListaCC.Item(0)
      rpt.txtDebitoGestion2.DataField = "DebePer" & moListaCC.Item(1)
      rpt.txtCreditoGestion.DataField = "HaberPer" & moListaCC.Item(0)
      rpt.txtCreditoGestion2.DataField = "HaberPer" & moListaCC.Item(1)

      If mlngMonedaId = 1 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)

      ElseIf mlngMonedaId = 2 Then
         rpt.txtMoneda.Text = MonedaDesFind(mlngMonedaId)
      End If

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

   Private Sub frmLibroMayorLoad()
      Dim oLista As New Queue
      Dim lngPlanId As Long
      Dim lngCentroCostoId As Long = 0

      If ToLong(grdMain.GetValue("PlanId")) > 0 Then
         If ToLong(grdMain.CurrentColumn.Tag) > 0 Then
            lngCentroCostoId = ToLong(grdMain.CurrentColumn.Tag)
            If ToLong(grdMain.GetValue("PlanId")) <> 0 Then
               oLista.Enqueue(ToLong(grdMain.GetValue("PlanId")))
               lngPlanId = ToLong(grdMain.GetValue("PlanId"))
            End If

            If oLista.Count Then

               Dim oListaCC As New Queue
               oListaCC.Enqueue(lngCentroCostoId)

               Dim frm As New frmLibroCentroCosto

               With frm
                  .EmpresaId = mlngEmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .MonedaId = mlngMonedaId
                  .SaldoAnterior = mboolSaldoAnterior
                  .Cuenta = True
                  .IncluirDetalle = True
                  .IntervaloFecha = mboolIntervaloFecha
                  .FechaIni = mdatFechaIni
                  .FechaFin = mdatFechaFin
                  .OrdenarFecha = True
                  .SinFac = mboolSinFac
                  .ConFac = mboolConFac

                  .Lista = oListaCC
                  .ListaPlan = oLista
                  .ListaTipoAsiento = moListaTipoAsiento

                  .MdiParent = Me.MdiParent
                  .Show()

                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, Me.ToString)
               End With
            Else
               MessageBox.Show("Debe Seleccionar al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If
      End If
   End Sub

   Private Sub frmSumaSaldoComparativoCC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmLibroMayorLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmSumaSaldoComparativoCC_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompDet.Dispose()
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
      ConMovimiento = False
      Try
         With moCompDet
            .SelectFilter = clsCompDet.SelectFilters.AllComp
            'If mboolIntervaloFecha Then
            '   .WhereFilter = clsCompDet.WhereFilters.SinMovimientoFecha
            '   .Fecha = mstrFechaIni
            '   .CompDetDes = mstrFechaFin
            'Else
            .WhereFilter = clsCompDet.WhereFilters.SinMovimiento
            'End If
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .MonedaId = ToBoolean(mboolSinFac) 'SinFac
            .EstadoId = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId
            If .Find Then
               ConMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("PlanId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      If mboolIncluirPlanAdd Then
         fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanId"), Janus.Windows.GridEX.ConditionOperator.GreaterThan, 0)
         fc.FormatStyle.ForeColor = Color.DarkBlue
         grdMain.RootTable.FormatConditions.Add(fc)
      End If

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanAddId"), Janus.Windows.GridEX.ConditionOperator.GreaterThan, 0)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("SaldoNegativo"), Janus.Windows.GridEX.ConditionOperator.Equal, True)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " DataSet Suma-Saldo "
   Private Sub moDataSetInit()
      moDataTable = New DataTable("Tabla")

      moDataTable.Columns.Add("PlanAddId", Type.GetType("System.Int32")) '1: PlanId; 2: PlanAddId
      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))

      For Each CCId In moListaCC
         moDataTable.Columns.Add("SaldoAnt" & CCId, Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Debe" & CCId, Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Haber" & CCId, Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Saldo" & CCId, Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("DebePer" & CCId, Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("HaberPer" & CCId, Type.GetType("System.Decimal"))
      Next

      moDataTable.Columns.Add("SaldoNegativo", Type.GetType("System.Boolean"))
   End Sub

   Private Function GetRowSinMov() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Try
         With moPlan
            oRow("PlanId") = ToLong(.PlanId)
            oRow("PlanCta") = ToStr(.PlanCta)
            oRow("PlanDes") = ToStr(.PlanDes)
         End With

         Return oRow
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
   End Function

   Private Function GetFooter(ByVal lngMonedaId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanId") = -1

      If lngMonedaId = 1 Then
         oRow("PlanDes") = "Total Saldos en " & MonedaDesFind(lngMonedaId)

      ElseIf lngMonedaId = 2 Then
         oRow("PlanDes") = "Total Saldos en " & MonedaDesFind(lngMonedaId)
      End If

      For Each CCId In moListaCC
         oRow("Debe" & CCId) = ToDecimal(moDataTable.Compute("SUM(Debe" & CCId & ")", "PlanId > 0"))
         oRow("Haber" & CCId) = ToDecimal(moDataTable.Compute("SUM(Haber" & CCId & ")", "PlanId > 0"))
         oRow("DebePer" & CCId) = ToDecimal(moDataTable.Compute("SUM(DebePer" & CCId & ")", "PlanId > 0"))
         oRow("HaberPer" & CCId) = ToDecimal(moDataTable.Compute("SUM(HaberPer" & CCId & ")", "PlanId > 0"))
      Next

      Return oRow
   End Function
#End Region

#Region " Grid Suma-Saldo "

   Private Function SumarColumnas(ByVal odataTable As DataTable, ByVal strFiltro As String, ByRef decDebe As Decimal, ByRef decHaber As Decimal) As Decimal
      'deben existir variables globales de la cuenta: TipoGrupoId
      'deben existir variables globales moneda del reporte, solo dos Bolivianos o dolares
      'en la odataTable debe existir DebeBs, DebeUs, HaberBs, HaberUs
      SumarColumnas = 0

      If mlngMonedaId = clsMoneda.BOLIVIANOS Then
         decDebe = ToDecimal(odataTable.Compute("SUM(DebeBs)", strFiltro))
         decHaber = ToDecimal(odataTable.Compute("SUM(HaberBs)", strFiltro))
      Else
         decDebe = ToDecimal(odataTable.Compute("SUM(DebeUs)", strFiltro))
         decHaber = ToDecimal(odataTable.Compute("SUM(HaberUs)", strFiltro))
      End If

      If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
         SumarColumnas = decDebe - decHaber
      ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
         SumarColumnas = decHaber - decDebe
      End If
   End Function

   Private Sub grdMainLoad()
      Try
         Call moDataSetInit()
         mstrTipoAsientoId = TipoAsientoIdListaLoad()

         For Each lngPlanId As Long In moLista
            With moPlan
               .PlanId = lngPlanId

               If .FindByPK Then
                  mlngGrupo = moPlan.TipoGrupoId

                  mdecDebePer = 0
                  mdecHaberPer = 0
                  mdecDebe = 0
                  mdecHaber = 0
                  mdecSaldo = 0
                  mdecSaldoAnt = 0
                  mdecSumSaldo = 0

                  If ConMovimiento(lngPlanId) Then
                     Dim strFecha As String = ""
                     Dim strFiltro As String = ""
                     Dim oRow As DataRow = moDataTable.NewRow
                     Dim datatableCompDet As DataTable = moCompDet.DataSet.Tables(moCompDet.TableName)

                     If mboolIntervaloFecha Then
                        strFecha &= "Fecha >= '" & ToDateDMY(mdatFechaIni) & "' and Fecha <= '" & ToDateDMY(mdatFechaFin) & "' AND "
                     End If

                     For Each CentroCostoId In moListaCC
                        strFiltro = strFecha & "CentroCostoId = " & CentroCostoId

                        mdecSaldo = SumarColumnas(datatableCompDet, strFiltro, mdecDebe, mdecHaber)

                        If mboolSaldoAnterior Then
                           strFiltro = "CentroCostoId = " & CentroCostoId & " and Fecha < '" & ToDateDMY(mdatFechaIni) & "'"
                           Dim decDebe As Decimal = 0
                           Dim decHaber As Decimal = 0
                           mdecSaldoAnt = SumarColumnas(datatableCompDet, strFiltro, decDebe, decHaber)
                        End If

                        If mboolUltimoPeriodo Then
                           strFiltro = "CentroCostoId = " & CentroCostoId

                           Call SumarColumnas(datatableCompDet, strFiltro, mdecDebePer, mdecHaberPer)
                        End If

                        oRow("SaldoAnt" & CentroCostoId) = ToValue(mdecSaldoAnt)
                        oRow("Debe" & CentroCostoId) = ToValue(mdecDebe)
                        oRow("Haber" & CentroCostoId) = ToValue(mdecHaber)
                        oRow("Saldo" & CentroCostoId) = ToValue(mdecSaldo)
                        oRow("DebePer" & CentroCostoId) = ToValue(mdecDebePer)
                        oRow("HaberPer" & CentroCostoId) = ToValue(mdecHaberPer)

                        If mdecSaldo < 0 Then
                           oRow("SaldoNegativo") = True
                        End If

                        mdecSumSaldo += Math.Abs(mdecSaldo)
                     Next

                     If mdecSumSaldo > 0 Or mboolSaldoCero Then
                        oRow("PlanId") = moPlan.PlanId
                        oRow("PlanCta") = moPlan.PlanCta
                        oRow("PlanDes") = moPlan.PlanDes
                        moDataTable.Rows.Add(oRow)

                        If mboolIncluirPlanAdd And moPlan.TieneAnaAdd Then
                           Call IncluirAnaliticosAdicionales(moPlan.PlanId)
                        End If
                     End If

                  ElseIf mboolSaldoCero Then
                     moDataTable.Rows.Add(GetRowSinMov())
                  End If
               End If
            End With
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

   Private Function ToValue(ByVal value As Decimal) As Object
      If value = 0 Then
         ToValue = System.Convert.DBNull
      Else
         ToValue = value
      End If
   End Function

   Private Function SaldoPlanAddBs(ByVal lngPlanId As Long, ByVal lngPlanAddId As Long) As DataTable
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      SaldoPlanAddBs = Nothing
      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayor
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .PlanAddId = lngPlanAddId
            .MonedaId = ToBoolean(mboolSinFac) 'SinFac
            .EstadoId = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'temp
            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               SaldoPlanAddBs = .DataSet.Tables(0)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompPlanAdd.Dispose()
      End Try
   End Function

   Private Sub IncluirAnaliticosAdicionales(ByVal lngPlanId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.All
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes
            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanId

            If .Open Then
               Dim strFiltro As String = ""
               Dim strFiltroFecha As String = ""

               If mboolIntervaloFecha Then
                  strFiltroFecha = "Fecha >= '" & ToDateDMY(mdatFechaIni) & "' and Fecha <= '" & ToDateDMY(mdatFechaFin) & "' AND "
               End If

               Do While .Read
                  mdecSumSaldo = 0
                  Dim dataTableCompPlanAdd As DataTable = SaldoPlanAddBs(.PlanId, .PlanAddId)
                  If dataTableCompPlanAdd IsNot Nothing Then

                     Dim oRow As DataRow = moDataTable.NewRow

                     For Each CCId In moListaCC
                        'If dataTableCompPlanAdd.AsEnumerable.ToList.Exists(Function(f) f.Field(Of Long)("CentroCostoId") = CCId) Then

                        strFiltro = strFiltroFecha & "CentroCostoId = " & CCId
                        mdecSaldo = SumarColumnas(dataTableCompPlanAdd, strFiltro, mdecDebe, mdecHaber)

                        If mboolSaldoAnterior Then
                           strFiltro = "CentroCostoId = " & CCId & " and Fecha < '" & ToDateDMY(mdatFechaIni) & "'"
                           Dim decDebe As Decimal = 0
                           Dim decHaber As Decimal = 0
                           mdecSaldoAnt = SumarColumnas(dataTableCompPlanAdd, strFiltro, decDebe, decHaber)
                        End If

                        If mboolUltimoPeriodo Then
                           strFiltro = "CentroCostoId = " & CCId
                           Call SumarColumnas(dataTableCompPlanAdd, strFiltro, mdecDebePer, mdecHaberPer)
                        End If

                        mdecSumSaldo += Math.Abs(mdecSaldo)

                        oRow("SaldoAnt" & CCId) = ToValue(mdecSaldoAnt)
                        oRow("Debe" & CCId) = ToValue(mdecDebe)
                        oRow("Haber" & CCId) = ToValue(mdecHaber)
                        oRow("Saldo" & CCId) = ToValue(mdecSaldo)
                        oRow("DebePer" & CCId) = ToValue(mdecDebePer)
                        oRow("HaberPer" & CCId) = ToValue(mdecHaberPer)
                        'End If
                     Next

                     If mdecSumSaldo > 0 Or mboolSaldoCero Then
                        oRow("PlanAddId") = oPlanAdd.PlanAddId
                        oRow("PlanCta") = oPlanAdd.PlanAddCta
                        oRow("PlanDes") = "     " & oPlanAdd.PlanAddDes
                        moDataTable.Rows.Add(oRow)
                     End If
                  End If
                  .MoveNext()
               Loop
            End If
         End With
      Catch ex As Exception
         Throw ex
      Finally
         oPlanAdd.Dispose()
      End Try
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Balance de Sumas y Saldos Comparativo por Centros de Costo"

         .RootTable.CellLayoutMode = Janus.Windows.GridEX.CellLayoutMode.UseColumnSets
         .RootTable.ColumnSetRowCount = 1
         .RootTable.ColumnSetHeaderLines = 1
         .RootTable.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True


         Dim CS = New Janus.Windows.GridEX.GridEXColumnSet
         CS.Key = "Cuenta"
         CS.Caption = ""
         CS.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
         CS.ColumnCount = 2
         .RootTable.ColumnSets.Add(CS)
         CS.Add(.RootTable.Columns("PlanCta"), 0, 0) '; // First parameter is GridEXColumn, Second is row in ColumnSet, third is col
         CS.Add(.RootTable.Columns("PlanDes"), 0, 1) ';
         CS.Width = 360

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("PlanCta").Caption = "Cuenta"
         .RootTable.Columns("PlanCta").Width = 80
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripción"
         .RootTable.Columns("PlanDes").Width = 280
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         Dim color As System.Drawing.Color = Drawing.Color.White

         For Each CCId In moListaCC
            Dim grdColumnSet = New Janus.Windows.GridEX.GridEXColumnSet
            grdColumnSet.Key = CCId
            grdColumnSet.Caption = CentroCostoFind(CCId)
            grdColumnSet.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            grdMain.RootTable.ColumnSets.Add(grdColumnSet)
            Dim lngnum = 0
            Dim width = 0

            If color = Drawing.Color.White Then
               color = color.AliceBlue
            Else
               color = color.White
            End If

            If mboolSaldoAnterior Then
               grdColumnSet.ColumnCount = lngnum + 1
               grdColumnSet.Add(grdMain.RootTable.Columns("SaldoAnt" & CCId), 0, lngnum)
               lngnum += 1

               .RootTable.Columns("SaldoAnt" & CCId).Caption = "Saldo Ant."
               .RootTable.Columns("SaldoAnt" & CCId).FormatString = DecimalMask()
               .RootTable.Columns("SaldoAnt" & CCId).Width = 80
               .RootTable.Columns("SaldoAnt" & CCId).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("SaldoAnt" & CCId).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("SaldoAnt" & CCId).CellStyle.BackColor = color
               .RootTable.Columns("SaldoAnt" & CCId).Tag = CCId
               width += .RootTable.Columns("SaldoAnt" & CCId).Width
            End If

            grdColumnSet.ColumnCount = lngnum + 1
            grdColumnSet.Add(grdMain.RootTable.Columns("Debe" & CCId), 0, lngnum)
            lngnum += 1

            .RootTable.Columns("Debe" & CCId).Caption = "Débito"
            .RootTable.Columns("Debe" & CCId).FormatString = DecimalMask()
            .RootTable.Columns("Debe" & CCId).Width = 80
            .RootTable.Columns("Debe" & CCId).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Debe" & CCId).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Debe" & CCId).CellStyle.BackColor = color
            .RootTable.Columns("Debe" & CCId).Tag = CCId
            width += .RootTable.Columns("Debe" & CCId).Width

            grdColumnSet.ColumnCount = lngnum + 1
            grdColumnSet.Add(grdMain.RootTable.Columns("Haber" & CCId), 0, lngnum)
            lngnum += 1

            .RootTable.Columns("Haber" & CCId).Caption = "Crédito"
            .RootTable.Columns("Haber" & CCId).FormatString = DecimalMask()
            .RootTable.Columns("Haber" & CCId).Width = 80
            .RootTable.Columns("Haber" & CCId).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Haber" & CCId).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Haber" & CCId).CellStyle.BackColor = color
            .RootTable.Columns("Haber" & CCId).Tag = CCId
            width += .RootTable.Columns("Haber" & CCId).Width

            grdColumnSet.ColumnCount = lngnum + 1
            grdColumnSet.Add(grdMain.RootTable.Columns("Saldo" & CCId), 0, lngnum)
            lngnum += 1

            .RootTable.Columns("Saldo" & CCId).Caption = "Saldo"
            .RootTable.Columns("Saldo" & CCId).FormatString = DecimalMask()
            .RootTable.Columns("Saldo" & CCId).Width = 80
            .RootTable.Columns("Saldo" & CCId).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("Saldo" & CCId).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("Saldo" & CCId).CellStyle.BackColor = color
            .RootTable.Columns("Saldo" & CCId).Tag = CCId
            width += .RootTable.Columns("Saldo" & CCId).Width

            If mboolUltimoPeriodo Then
               grdColumnSet.ColumnCount = lngnum + 1
               grdColumnSet.Add(grdMain.RootTable.Columns("DebePer" & CCId), 0, lngnum)
               lngnum += 1

               .RootTable.Columns("DebePer" & CCId).Caption = "Débito Gestión"
               .RootTable.Columns("DebePer" & CCId).FormatString = DecimalMask()
               .RootTable.Columns("DebePer" & CCId).Width = 80
               .RootTable.Columns("DebePer" & CCId).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("DebePer" & CCId).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("DebePer" & CCId).CellStyle.BackColor = color
               .RootTable.Columns("DebePer" & CCId).Tag = CCId
               width += .RootTable.Columns("DebePer" & CCId).Width

               grdColumnSet.ColumnCount = lngnum + 1
               grdColumnSet.Add(grdMain.RootTable.Columns("HaberPer" & CCId), 0, lngnum)
               lngnum += 1

               .RootTable.Columns("HaberPer" & CCId).Caption = "Crédito Gestión"
               .RootTable.Columns("HaberPer" & CCId).FormatString = DecimalMask()
               .RootTable.Columns("HaberPer" & CCId).Width = 80
               .RootTable.Columns("HaberPer" & CCId).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
               .RootTable.Columns("HaberPer" & CCId).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
               .RootTable.Columns("HaberPer" & CCId).CellStyle.BackColor = color
               .RootTable.Columns("HaberPer" & CCId).Tag = CCId
               width += .RootTable.Columns("HaberPer" & CCId).Width
            End If

            grdColumnSet.Width = width
         Next
      End With

      Call AddConditionalFormatting()
   End Sub

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
End Class

