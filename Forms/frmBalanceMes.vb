Public Class frmBalanceMes
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan

   Private moListaTipoAsiento As New Queue
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
   Private mboolIncluirPlanAdd As Boolean
   Private mboolTotalizar As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean
   Private mboolMostrarResultado As Boolean
   Private mstrTitulo As String

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mdecHaberBs As Decimal
   Private mdecDebeBs As Decimal
   Private mdecHaberUs As Decimal
   Private mdecDebeUs As Decimal
   Friend WithEvents ExportToExcel As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportToExcel1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter

   Private mlngResultadoIndex As Long

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

   Property IncluirPlanAdd() As Boolean
      Get
         Return mboolIncluirPlanAdd
      End Get

      Set(ByVal Value As Boolean)
         mboolIncluirPlanAdd = Value
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

   Property MostrarResultado() As Boolean
      Get
         Return mboolMostrarResultado
      End Get

      Set(ByVal Value As Boolean)
         mboolMostrarResultado = Value
      End Set
   End Property

   Public Property Titulo() As String
      Get
         Return mstrTitulo
      End Get
      Set(ByVal value As String)
         mstrTitulo = value
      End Set
   End Property

#End Region

#Region " C?digo generado por el Dise?ador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Dise?ador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicializaci?n despu?s de la llamada a InitializeComponent()

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

   'Requerido por el Dise?ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise?ador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Dise?ador de Windows Forms. 
   'No lo modifique con el editor de c?digo.
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents ToolBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalanceMes))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ToolBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ExportToExcel1 = New Janus.Windows.UI.CommandBars.UICommand("ExportToExcel")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ExportToExcel = New Janus.Windows.UI.CommandBars.UICommand("ExportToExcel")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.gexMain = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
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
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.ToolBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Exit2, Me.ExportToExcel})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("60fbf6d9-1232-461e-b613-2ac370129d4f")
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
      'ToolBar1
      '
      Me.ToolBar1.CommandManager = Me.cdmMain
      Me.ToolBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.ViewAll1, Me.Separator2, Me.ExportToExcel1, Me.Separator3, Me.Exit1})
      Me.ToolBar1.Key = "ToolBar"
      Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
      Me.ToolBar1.Name = "ToolBar1"
      Me.ToolBar1.RowIndex = 0
      Me.ToolBar1.Size = New System.Drawing.Size(340, 28)
      Me.ToolBar1.Text = "ToolBar"
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
      'ExportToExcel1
      '
      Me.ExportToExcel1.Key = "ExportToExcel"
      Me.ExportToExcel1.Name = "ExportToExcel1"
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
      Me.ilsMain.Images.SetKeyName(7, "Excel.JPG")
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
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.ToolBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.ToolBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(752, 28)
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
      'gexMain
      '
      Me.gexMain.GridEX = Me.grdMain
      '
      'frmBalanceMes
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmBalanceMes"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Balance General"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
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

         Case "ExportToExcel"
            Call ExportToExcelLoad()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmBalanceMes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmBalanceMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      Dim oListaPlan As New Queue
      Dim lngPlanId As Long

      If (ToLong(grdMain.GetValue("PlanId")) > 0) And (ToBoolean(grdMain.GetValue("EsAna"))) Then
         oListaPlan.Enqueue(ToLong(grdMain.GetValue("PlanId")))
         lngPlanId = ToLong(grdMain.GetValue("PlanId"))
      End If

      If oListaPlan.Count Then
         If mlngCentroCostoId = 0 And mlngSucursalId = 0 Then
            Dim frm As New frmLibroMayor

            With frm
               .EmpresaId = mlngEmpresaId
               .GestionId = clsAppInfo.GestionId
               .MonedaId = mlngMonedaId
               .SaldoAnterior = False
               .Cuenta = True
               .SinMovimiento = False
               .IntervaloFecha = True
               .FechaIni = ToDate(mdatFechaIniInt) 'desde el comienzo de la gestion
               .FechaFin = ToDate(mdatFechaFinInt)
               .OrdenarFecha = True

               If grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralBs") Or grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralUs") Then
                  Dim indice As Long = ToLong(grdMain.CurrentColumn.DataMember.Substring(6))
                  If indice > 0 Then
                     Dim datFechaIni As Date = mdatFechaIniInt
                     Dim datFechaFin As Date

                     datFechaIni = DateAdd(DateInterval.Month, indice - 1, datFechaIni)
                     datFechaFin = DateSerial(datFechaIni.Year, datFechaIni.Month + 1, 0)

                     If datFechaFin > mdatFechaFinInt Then
                        datFechaFin = mdatFechaFinInt
                     End If

                     .FechaIni = ToDate(mdatFechaIniInt) 'desde el comienzo de la gestion
                     .FechaFin = ToDate(datFechaFin)
                     .Text = "Libro Mayor de " & ConvertDMY(ToDate(mdatFechaIniInt)) & " a " & ConvertDMY(ToDate(datFechaFin))
                  End If
               End If

               .Lista = oListaPlan
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
         ElseIf mlngCentroCostoId > 0 Then
            Dim frm As New frmLibroCentroCosto
            Dim oListaCC As New Queue
            oListaCC.Enqueue(mlngCentroCostoId)

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

               If grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralBs") Or grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralUs") Then
                  Dim indice As Long = ToLong(grdMain.CurrentColumn.DataMember.Substring(6))
                  If indice > 0 Then
                     Dim datFechaIni As Date = mdatFechaIniInt
                     Dim datFechaFin As Date

                     datFechaIni = DateAdd(DateInterval.Month, indice - 1, datFechaIni)
                     datFechaFin = DateSerial(datFechaIni.Year, datFechaIni.Month + 1, 0)

                     If datFechaFin > mdatFechaFinInt Then
                        datFechaFin = mdatFechaFinInt
                     End If

                     .FechaIni = ToDate(mdatFechaIniInt)
                     .FechaFin = ToDate(datFechaFin)
                     .Text = "Libro Mayor de " & ConvertDMY(ToDate(mdatFechaIniInt)) & " a " & ConvertDMY(ToDate(datFechaFin))
                  End If
               End If

               .SinFac = mboolSinFac
               .ConFac = mboolConFac
               .Lista = oListaCC
               .ListaPlan = oListaPlan
               .ListaTipoAsiento = moListaTipoAsiento
               .MdiParent = Me.MdiParent
               frm.Show()

               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & PlanDesFind(lngPlanId))
            End With
         ElseIf mlngSucursalId > 0 Then
            Dim frm As New frmLibroSucursalCuenta
            Dim olistaSuc As New Queue
            olistaSuc.Enqueue(mlngSucursalId)
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
               .PlanId = ToLong(grdMain.GetValue("PlanId"))
               ''''
               If grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralBs") Or grdMain.CurrentColumn.DataMember.Substring(0, 6).Equals("GralUs") Then
                  Dim indice As Long = ToLong(grdMain.CurrentColumn.DataMember.Substring(6))
                  If indice > 0 Then
                     Dim datFechaIni As Date = mdatFechaIniInt
                     Dim datFechaFin As Date

                     datFechaIni = DateAdd(DateInterval.Month, indice - 1, datFechaIni)
                     datFechaFin = DateSerial(datFechaIni.Year, datFechaIni.Month + 1, 0)

                     If datFechaFin > mdatFechaFinInt Then
                        datFechaFin = mdatFechaFinInt
                     End If

                     .FechaIni = ToDate(mdatFechaIniInt)
                     .FechaFin = ToDate(datFechaFin)
                     .Text = "Libro Mayor de " & ConvertDMY(ToDate(mdatFechaIniInt)) & " a " & ConvertDMY(ToDate(datFechaFin))
                  End If
               End If
               ''''
               .SinFac = mboolSinFac
               .ConFac = mboolConFac
               .ListaTipoAsiento = moListaTipoAsiento
               .Lista = olistaSuc
               .MdiParent = Me.MdiParent
               frm.Show()

               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & PlanDesFind(lngPlanId))
            End With
         End If
      Else
         MessageBox.Show("Cuenta Inv?lida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

   Private Sub frmBalanceMes_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
   End Sub

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


#Region " Otros Metodos "
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
#End Region

#Region " BALANCE "
#Region " DataSet-Balance "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moPlan.TableName)

      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EsAna", Type.GetType("System.Byte"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))

      For index As Integer = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
         moDataTable.Columns.Add("GralBs" & index, Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("GralUs" & index, Type.GetType("System.Decimal"))
      Next

      moDataTable.Columns.Add("TipoGrupoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("GralTotalBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("GralTotalUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Nivel", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SW", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanPadreId", Type.GetType("System.Int32"))
   End Sub

   Private Function AddRowDataTable(ByVal oDataRow As DataRow, ByVal strTab As String) As Long
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      If ToLong(oDataRow("TipoGrupoId")) = 1 Or ToLong(oDataRow("TipoGrupoId")) = 2 Or ToLong(oDataRow("TipoGrupoId")) = 3 Then
         oRow("PlanId") = oDataRow("PlanId")
         oRow("EsAna") = oDataRow("EsAna")
         oRow("PlanCta") = oDataRow("PlanCta")
         oRow("Nivel") = oDataRow("Nivel")
         oRow("PlanPadreId") = oDataRow("PlanPadreId")
         oRow("TipoGrupoId") = oDataRow("TipoGrupoId")
         oRow("PlanDes") = strTab & oDataRow("PlanDes")

         moDataTable.Rows.Add(oRow)
         AddRowDataTable = moDataTable.Rows.Count - 1
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
            Dim datFechaFin As Date
            For index As Integer = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
               If index = DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1 Then
                  datFechaFin = mdatFechaFinInt
               Else
                  datFechaFin = DateSerial(Year(datFechaIni), Month(datFechaIni) + 1, 0)
               End If

               Dim strFiltro As String = "Fecha >= '" & ToDateDMY(mdatFechaIniInt) & "' and Fecha <= '" & ToDateDMY(datFechaFin) & "'"
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
                  oRow("GralBs" & index) = ToDecimal(mdecDebeBs - mdecHaberBs)
                  oRow("GralUs" & index) = ToDecimal(mdecDebeUs - mdecHaberUs)

                  oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
                  oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))
               ElseIf ToLong(oRow("TipoGrupoId")) = 2 Or ToLong(oRow("TipoGrupoId")) = 3 Or ToLong(oRow("TipoGrupoId")) = 4 Or ToLong(oRow("TipoGrupoId")) = 8 Then
                  oRow("GralBs" & index) = ToDecimal(mdecHaberBs - mdecDebeBs)
                  oRow("GralUs" & index) = ToDecimal(mdecHaberUs - mdecDebeUs)

                  oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
                  oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))
               End If

               datFechaIni = datFechaIni.AddMonths(1)
               datFechaIni = DateSerial(Year(datFechaIni), Month(datFechaIni), 1)
            Next

            If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralTotalBs")))) = 0 And ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralTotalUs")))) = 0 Then
               moDataTable.Rows.RemoveAt(lngIndex)
            End If
         Else
            moDataTable.Rows.RemoveAt(lngIndex)
         End If
      Else
         For index As Integer = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
            oRow("GralBs" & index) = ToDecimal(moDataTable.Compute("Sum(GralBs" & index & ")", "PlanPadreId = " & ToLong(oRow("PlanId"))))
            oRow("GralUs" & index) = ToDecimal(moDataTable.Compute("Sum(GralUs" & index & ")", "PlanPadreId = " & ToLong(oRow("PlanId"))))

            oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
            oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))
         Next

         If ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralTotalBs")))) = 0 And ToDecimalMinor(Math.Abs(ToDecimal(oRow("GralTotalUs")))) = 0 Then
            moDataTable.Rows.RemoveAt(lngIndex)
         End If
      End If
   End Sub

   Private Sub addTotalCuentaAgrupadora(ByVal lngPlanId As Long, ByVal strPlanDes As String)
      Dim decTotalNivelUs As Decimal
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanDes") = "TOTAL " & strPlanDes

      For index As Integer = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
         oRow("GralBs" & index) = ToDecimal(moDataTable.Compute("Sum(GralBs" & index & ")", "PlanPadreId = " & lngPlanId))
         oRow("GralUs" & index) = ToDecimal(moDataTable.Compute("Sum(GralUs" & index & ")", "PlanPadreId = " & lngPlanId))

         oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
         oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))
      Next

      oRow("Nivel") = mlngNivel
      moDataTable.Rows.Add(oRow)
   End Sub

   Private Sub GetRowNull()
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      oRow("Nivel") = mlngNivel
      moDataTable.Rows.Add(oRow)
   End Sub
#End Region

#Region " Metodo-Balance "
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
            .Fecha = ToDate(mdatFechaIniInt)
            .CompDetDes = ToDate(mdatFechaFinInt)
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

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanId"), Janus.Windows.GridEX.ConditionOperator.Equal, System.Convert.DBNull)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EsAna"), Janus.Windows.GridEX.ConditionOperator.Equal, False)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub GetResultado()
      Dim oRow As DataRow
      oRow = moDataTable.NewRow
      Dim decResultadoBs As Decimal
      Dim decResultadoUs As Decimal

      oRow("PlanDes") = "RESULTADO"

      Dim datFechaIni As Date = mdatFechaIniInt
      Dim datFechaFin As Date

      For index As Integer = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
         If index = DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1 Then
            datFechaFin = mdatFechaFinInt
         Else
            datFechaFin = DateSerial(Year(datFechaIni), Month(datFechaIni) + 1, 0)
         End If
         decResultadoBs = EstadoResultadoBs(decResultadoUs, mdatFechaIniInt, datFechaFin)

         oRow("GralBs" & index) = decResultadoBs
         oRow("GralUs" & index) = decResultadoUs
         oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
         oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))

         datFechaIni = datFechaIni.AddMonths(1)
         datFechaIni = DateSerial(Year(datFechaIni), Month(datFechaIni), 1)
      Next

      moDataTable.Rows.Add(oRow)
      mlngResultadoIndex = moDataTable.Rows.Count - 1
   End Sub

   Private Function EstadoResultadoBs(ByRef decResultadoUs As Decimal, ByVal datFechaIni As Date, ByVal datFechaFin As Date) As Decimal
      Dim datatableCompDet As DataTable
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim lngGrupo As Long
      Dim decHaberBs As Decimal
      Dim decDebeBs As Decimal
      Dim decHaberUs As Decimal
      Dim decDebeUs As Decimal
      Dim decSaldoBs As Decimal
      Dim decSaldoUs As Decimal
      Dim decTotalBs As Decimal = 0
      Dim decTotalUs As Decimal = 0

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.EstadoResultado
            .OrderByFilter = clsPlan.OrderByFilters.PlanCta
            .EmpresaId = mlngEmpresaId

            If .Open Then
               Do While .Read
                  datatableCompDet = LoadCompDet(.PlanId, clsCompDet.WhereFilters.RowSumFecha)
                  If datatableCompDet IsNot Nothing Then
                     Dim strFiltro As String = "Fecha >= '" & ToDateDMY(datFechaIni) & "' and Fecha <= '" & ToDateDMY(datFechaFin) & "'"

                     decDebeBs = ToDecimal(datatableCompDet.Compute("Sum(DebeBs)", strFiltro))
                     decHaberBs = ToDecimal(datatableCompDet.Compute("Sum(HaberBs)", strFiltro))
                     decDebeUs = ToDecimal(datatableCompDet.Compute("Sum(DebeUs)", strFiltro))
                     decHaberUs = ToDecimal(datatableCompDet.Compute("Sum(HaberUs)", strFiltro))

                     lngGrupo = .TipoGrupoId

                     If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                        decSaldoBs = ToDecimal(decDebeBs - decHaberBs)
                        decSaldoUs = ToDecimal(decDebeUs - decHaberUs)

                     ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                        decSaldoBs = ToDecimal(decHaberBs - decDebeBs)
                        decSaldoUs = ToDecimal(decHaberUs - decDebeUs)
                     End If

                     If lngGrupo = 4 Then
                        decTotalBs = decTotalBs + decSaldoBs
                        decTotalUs = decTotalUs + decSaldoUs

                     ElseIf lngGrupo = 5 Then
                        decTotalBs = decTotalBs - decSaldoBs
                        decTotalUs = decTotalUs - decSaldoUs

                     ElseIf lngGrupo = 6 Then
                        decTotalBs = decTotalBs - decSaldoBs
                        decTotalUs = decTotalUs - decSaldoUs
                     End If
                  End If
                  .MoveNext()
               Loop

               decResultadoUs = ToDecimal(decTotalUs)
               Return ToDecimal(decTotalBs)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Sub addBalance()
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanDes") = "PASIVO + PATRIMONIO"
      For Each row In moDataTable.Rows
         If ToLong(row("PlanPadreId")) = 0 And (ToStr(row("PlanCta")).Equals("2") _
         Or ToStr(row("PlanCta")).Equals("3")) Then
            For index = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
               oRow("GralBs" & index) = ToDecimal(oRow("GralBs" & index)) + ToDecimal(row("GralBs" & index))
               oRow("GralUs" & index) = ToDecimal(oRow("GralUs" & index)) + ToDecimal(row("GralUs" & index))
            Next
         End If
      Next

      For index = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
         oRow("GralBs" & index) = ToDecimal(moDataTable.Rows.Item(mlngResultadoIndex)("GralBs" & index)) + ToDecimal(oRow("GralBs" & index))
         oRow("GralUs" & index) = ToDecimal(moDataTable.Rows.Item(mlngResultadoIndex)("GralUs" & index)) + ToDecimal(oRow("GralUs" & index))

         oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
         oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))
      Next

      moDataTable.Rows.Add(oRow)
   End Sub

   Private Sub GetOrdenDeudora()
      Dim decOrdenDeudorUs As Decimal
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanDes") = "TOTAL DE ORDEN DEUDOR"

      Dim datFechaIni As Date = mdatFechaIniInt
      Dim datFechaFin As Date

      For index As Integer = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
         If index = DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1 Then
            datFechaFin = mdatFechaFinInt
         Else
            datFechaFin = DateSerial(Year(datFechaIni), Month(datFechaIni) + 1, 0)
         End If

         oRow("GralBs" & index) = OrdenDeudoraBs(decOrdenDeudorUs, mdatFechaIniInt, datFechaFin)
         oRow("GralUs" & index) = decOrdenDeudorUs

         oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
         oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))

         datFechaIni = datFechaIni.AddMonths(1)
         datFechaIni = DateSerial(Year(datFechaIni), Month(datFechaIni), 1)
      Next

      Call GetRowNull()
      moDataTable.Rows.Add(oRow)
   End Sub

   Private Sub GetOrdenAcreedora()
      Dim decOrdenAcreedoraUs As Decimal
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanDes") = "TOTAL DE ORDEN ACREEDOR"

      Dim datFechaIni As Date = mdatFechaIniInt
      Dim datFechaFin As Date

      For index As Integer = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
         If index = DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1 Then
            datFechaFin = mdatFechaFinInt
         Else
            datFechaFin = DateSerial(Year(datFechaIni), Month(datFechaIni) + 1, 0)
         End If

         oRow("GralBs" & index) = OrdenAcreedoraBs(decOrdenAcreedoraUs, mdatFechaIniInt, datFechaFin)
         oRow("GralUs" & index) = decOrdenAcreedoraUs

         oRow("GralTotalBs") = ToDecimal(oRow("GralTotalBs")) + ToDecimal(oRow("GralBs" & index))
         oRow("GralTotalUs") = ToDecimal(oRow("GralTotalUs")) + ToDecimal(oRow("GralUs" & index))

         datFechaIni = datFechaIni.AddMonths(1)
         datFechaIni = DateSerial(Year(datFechaIni), Month(datFechaIni), 1)
      Next
      'Call GetRowNull()
      moDataTable.Rows.Add(oRow)
   End Sub

   Private Function OrdenDeudoraBs(ByRef decOrdenDeudoraUs As Decimal, ByVal datFechaIni As Date, ByVal datFechaFin As Date) As Decimal
      Dim datatableCompDet As DataTable
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim lngGrupo As Long
      Dim decHaberBs As Decimal
      Dim decDebeBs As Decimal
      Dim decHaberUs As Decimal
      Dim decDebeUs As Decimal
      Dim decSaldoBs As Decimal
      Dim decSaldoUs As Decimal
      Dim decTotalBs As Decimal = 0
      Dim decTotalUs As Decimal = 0

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.OrdenDeudora
            .OrderByFilter = clsPlan.OrderByFilters.PlanCta
            .EmpresaId = mlngEmpresaId

            If .Open Then
               Do While .Read
                  datatableCompDet = LoadCompDet(.PlanId, clsCompDet.WhereFilters.RowSumFecha)
                  If datatableCompDet IsNot Nothing Then
                     Dim strFiltro As String = "Fecha >= '" & ToDateDMY(datFechaIni) & "' and Fecha <= '" & ToDateDMY(datFechaFin) & "'"

                     decDebeBs = ToDecimal(datatableCompDet.Compute("Sum(DebeBs)", strFiltro))
                     decHaberBs = ToDecimal(datatableCompDet.Compute("Sum(HaberBs)", strFiltro))
                     decDebeUs = ToDecimal(datatableCompDet.Compute("Sum(DebeUs)", strFiltro))
                     decHaberUs = ToDecimal(datatableCompDet.Compute("Sum(HaberUs)", strFiltro))

                     lngGrupo = .TipoGrupoId

                     If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                        decSaldoBs = ToDecimal(decDebeBs - decHaberBs)
                        decSaldoUs = ToDecimal(decDebeUs - decHaberUs)

                     ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                        decSaldoBs = ToDecimal(decHaberBs - decDebeBs)
                        decSaldoUs = ToDecimal(decHaberUs - decDebeUs)
                     End If

                     If lngGrupo = 7 Then
                        decTotalBs = decTotalBs + decSaldoBs
                        decTotalUs = decTotalUs + decSaldoUs
                     End If
                  End If
                  .MoveNext()
               Loop

               decOrdenDeudoraUs = ToDecimal(decTotalUs)
               Return ToDecimal(decTotalBs)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function OrdenAcreedoraBs(ByRef decOrdenAcreedoraUs As Decimal, ByVal datFechaIni As Date, ByVal datFechaFin As Date) As Decimal
      Dim datatableCompDet As DataTable
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim lngGrupo As Long
      Dim decHaberBs As Decimal
      Dim decDebeBs As Decimal
      Dim decHaberUs As Decimal
      Dim decDebeUs As Decimal
      Dim decSaldoBs As Decimal
      Dim decSaldoUs As Decimal
      Dim decTotalBs As Decimal = 0
      Dim decTotalUs As Decimal = 0

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.OrdenAcreedora
            .OrderByFilter = clsPlan.OrderByFilters.PlanCta
            .EmpresaId = mlngEmpresaId

            If .Open Then
               Do While .Read
                  datatableCompDet = LoadCompDet(.PlanId, clsCompDet.WhereFilters.RowSumFecha)
                  If datatableCompDet IsNot Nothing Then
                     Dim strFiltro As String = "Fecha >= '" & ToDateDMY(datFechaIni) & "' and Fecha <= '" & ToDateDMY(datFechaFin) & "'"

                     decDebeBs = ToDecimal(datatableCompDet.Compute("Sum(DebeBs)", strFiltro))
                     decHaberBs = ToDecimal(datatableCompDet.Compute("Sum(HaberBs)", strFiltro))
                     decDebeUs = ToDecimal(datatableCompDet.Compute("Sum(DebeUs)", strFiltro))
                     decHaberUs = ToDecimal(datatableCompDet.Compute("Sum(HaberUs)", strFiltro))

                     lngGrupo = .TipoGrupoId

                     If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                        decSaldoBs = ToDecimal(decDebeBs - decHaberBs)
                        decSaldoUs = ToDecimal(decDebeUs - decHaberUs)

                     ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                        decSaldoBs = ToDecimal(decHaberBs - decDebeBs)
                        decSaldoUs = ToDecimal(decHaberUs - decDebeUs)
                     End If

                     If lngGrupo = 8 Then
                        decTotalBs = decTotalBs + decSaldoBs
                        decTotalUs = decTotalUs + decSaldoUs
                     End If
                  End If
                  .MoveNext()
               Loop

               decOrdenAcreedoraUs = ToDecimal(decTotalUs)
               Return ToDecimal(decTotalBs)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Sub DestotalizarCuentas()
      For Each row In moDataTable.Rows
         If ToLong(row("EsAna")) <> 1 And ToLong(row("PlanId")) <> 0 And Not mboolTotalizar Then
            For index As Integer = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
               row("GralBs" & index) = System.Convert.DBNull
               row("GralUs" & index) = System.Convert.DBNull
            Next
            row("GralTotalBs") = System.Convert.DBNull
            row("GralTotalUs") = System.Convert.DBNull
         End If
      Next
   End Sub

#End Region

#Region " Grid-Balance "
   Private Sub grdMainLoad()
      Call moDataSetInit()

      mstrTipoAsientoId = TipoAsientoIdListaLoad()
      Call grdMainLoad(0, "")

      If mboolMostrarResultado Then
         Call GetResultado()
      End If

      Call addBalance()
      Call GetOrdenDeudora()
      Call GetOrdenAcreedora()

      If Not mboolTotalizar Then
         Call DestotalizarCuentas()
      End If

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
               .WhereFilter = clsPlan.WhereFilters.GridBalance
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
                     Call addTotalCuentaAgrupadora(ToLong(oRow("PlanId")), ToStr(oRow("PlanDes")))
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
      Dim strMes As String
      Dim strMonedaSigla As String

      With grdMain
         ebrMain.Groups(0).Text = "Balance General"

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("SW").Visible = False

         .RootTable.Columns("TipoGrupoId").Visible = False

         .RootTable.Columns("EsAna").Visible = False

         .RootTable.Columns("PlanCta").Caption = "C?digo"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripci?n"
         .RootTable.Columns("PlanDes").Width = 370
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         Dim datFechaIni As Date = mdatFechaIniInt
         For index As Integer = 1 To DateDiff(DateInterval.Month, mdatFechaIniInt, mdatFechaFinInt) + 1
            strMes = MesFind(Month(datFechaIni))
            .RootTable.Columns("GralBs" & index).Caption = strMes & "  Bs." ' & strMonedaSigla
            .RootTable.Columns("GralBs" & index).FormatString = DecimalMask()
            .RootTable.Columns("GralBs" & index).Width = 100
            .RootTable.Columns("GralBs" & index).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("GralBs" & index).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("GralUs" & index).Caption = strMes & "  Us." ' & strMonedaSigla
            .RootTable.Columns("GralUs" & index).FormatString = DecimalMask()
            .RootTable.Columns("GralUs" & index).Width = 100
            .RootTable.Columns("GralUs" & index).CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("GralUs" & index).HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            If mlngMonedaId = 1 Then
               .RootTable.Columns("GralUs" & index).Visible = False

            ElseIf mlngMonedaId = 2 Then
               .RootTable.Columns("GralBs" & index).Visible = False
            End If

            datFechaIni = datFechaIni.AddMonths(1)
            datFechaIni = DateSerial(Year(datFechaIni), Month(datFechaIni), 1)
         Next

         .RootTable.Columns("GralTotalBs").Caption = "TOTAL Bs."
         .RootTable.Columns("GralTotalBs").FormatString = DecimalMask()
         .RootTable.Columns("GralTotalBs").Width = 100
         .RootTable.Columns("GralTotalBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralTotalBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("GralTotalBs").Visible = False

         .RootTable.Columns("GralTotalUs").Caption = "TOTAL Us."
         .RootTable.Columns("GralTotalUs").FormatString = DecimalMask()
         .RootTable.Columns("GralTotalUs").Width = 100
         .RootTable.Columns("GralTotalUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("GralTotalUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("GralTotalUs").Visible = False

         If mlngMonedaId = 1 Then
            .RootTable.Columns("GralTotalUs").Visible = False
         ElseIf mlngMonedaId = 2 Then
            .RootTable.Columns("GralTotalBs").Visible = False
         End If

         .RootTable.Columns("Nivel").Visible = False
         .RootTable.Columns("PlanPadreId").Visible = False

      End With

      Call AddConditionalFormatting()
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

   Private Sub frmBalanceMes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

End Class
