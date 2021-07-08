Public Class frmLibroMayorDuo
   Inherits System.Windows.Forms.Form

   Private moCompDet As clsCompDet
   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMonedaId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolOrdenarFecha As Boolean
   Private mboolSaldoAnterior As Boolean
   Private mboolCuenta As Boolean
   Private mboolSinMovimiento As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean

   Private moListaTipoAsiento As New Queue
   Private mstrTipoAsientoId As String

   Private mdecHaberBs As Decimal
   Private mdecDebeBs As Decimal
   Private mdecSaldoBs As Decimal
   Private mdecHaberUs As Decimal
   Private mdecDebeUs As Decimal
   Private mdecSaldoUs As Decimal

   Private mdecHaberBsOrg As Decimal
   Private mdecDebeBsOrg As Decimal
   Private mdecSaldoBsOrg As Decimal
   Private mdecHaberUsOrg As Decimal
   Private mdecDebeUsOrg As Decimal
   Private mdecSaldoUsOrg As Decimal

   Private mlngGrupo As Long

   Private mstrConnectStringOrg As String
   Private mlngEmpresaIdOrg As Long
   Private mlngGestionIdOrg As Long

   Private moDataSet As DataSet
   Private moDataTable As DataTable

#Region " Set and Get "

   Public Property EmpresaIdOrg() As Long
      Get
         Return mlngEmpresaIdOrg
      End Get
      Set(ByVal value As Long)
         mlngEmpresaIdOrg = value
      End Set
   End Property

   Public Property GestionIdOrg() As Long
      Get
         Return mlngGestionIdOrg
      End Get
      Set(ByVal value As Long)
         mlngGestionIdOrg = value
      End Set
   End Property

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

   Property ConnectStringOrg() As String
      Get
         Return mstrConnectStringOrg
      End Get

      Set(ByVal Value As String)
         mstrConnectStringOrg = Value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroMayorDuo))
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(344, 28)
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
      'frmLibroMayorDuo
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmLibroMayorDuo"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Libro Mayor Comparativo"
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
            Call DataEdit()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmLibroMayorDuo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmLibroMayorDuo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call grdMainLoadOrg()
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moCompDet = New clsCompDet(clsAppInfo.ConnectString)
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
         If (mlngMonedaId = 1) Or (mlngMonedaId = 2) Then
            Dim rpt As New rptLibroMayor

            rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompDet.TableName))

            rpt.lblTitle.Text = "Libro Mayor"
            rpt.Document.Name = "Libro Mayor"
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
            rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)

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

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

            rpt.Run(True)
            Dim frm As frmReportPreview
            frm = New frmReportPreview(rpt.Document, Me)
            frm.Show()

         ElseIf (mlngMonedaId = 3) Or (mlngMonedaId = 4) Then
            Dim rpt As New rptLibroMayorExt

            rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompDet.TableName))

            rpt.lblTitle.Text = "Libro Mayor"
            rpt.Document.Name = "Libro Mayor"
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
            rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)

            If mlngMonedaId = 3 Then
               rpt.txtMoneda.Text = "De Cuenta"

            ElseIf mlngMonedaId = 4 Then
               rpt.txtMoneda.Text = "Ambas"
            End If

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

   Private Sub frmLibroMayorDuo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call DataEdit()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmLibroMayorDuo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompDet.Dispose()
      Call ClearMemory()
   End Sub

#Region " LIBRO-MAYOR "
#Region " Metodo-LibroMayor "
   Private Function TieneMovimiento(ByVal lngPlanId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      TieneMovimiento = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.AllComp
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac

            If mboolIntervaloFecha Then
               .WhereFilter = clsCompDet.WhereFilters.SinMovimientoFecha
               .Fecha = mstrFechaIni
               .CompDetDes = mstrFechaFin
            Else
               .WhereFilter = clsCompDet.WhereFilters.SinMovimiento
            End If

            If .Find Then
               TieneMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Separador"), Janus.Windows.GridEX.ConditionOperator.Equal, "*")
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompDetId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
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

   Private Function PlanMonedaDefecto(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanMonedaDefecto = 0

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanMonedaDefecto = ToLong(.MonedaId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function PlanSaldoAnteriorBs(ByVal lngPlanId As Long, ByRef decSaldoUs As Decimal) As Decimal
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0

      decSaldoUs = 0

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

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompDetId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub
#End Region

#Region " DataSet-LibroMayor "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCompDet.TableName)

      moDataTable.Columns.Add("CompDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.DateTime"))
      moDataTable.Columns.Add("TipoCompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCompDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompNro", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompDetDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoCambio", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("HaberBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("HaberUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoUs", Type.GetType("System.Decimal"))

      moDataTable.Columns.Add("Separador", Type.GetType("System.String"))

      moDataTable.Columns.Add("CompDetIdOrg", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompIdOrg", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanIdOrg", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCtaOrg", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDesOrg", Type.GetType("System.String"))
      moDataTable.Columns.Add("FechaOrg", Type.GetType("System.DateTime"))
      moDataTable.Columns.Add("TipoCompIdOrg", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCompDesOrg", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompNroOrg", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompDetDesOrg", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoCambioOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeBsOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("HaberBsOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoBsOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeUsOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("HaberUsOrg", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoUsOrg", Type.GetType("System.Decimal"))
   End Sub

   Private Function GetHeader(ByVal lngPlanId As Long) As DataRow
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         oRow("CompDetId") = -1
         oRow("TipoCompDes") = "Cuenta"
         oRow("SaldoBs") = mdecSaldoBs
         oRow("SaldoUs") = mdecSaldoUs

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               oRow("CompNro") = ToStr(.PlanCta)
               oRow("CompDetDes") = ToStr(.PlanDes)
            End If
         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function GetRow(ByVal oDataRow As DataRow, ByVal lngMonedaId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompDetId") = oDataRow("CompDetId")
      oRow("CompId") = oDataRow("CompId")
      oRow("PlanId") = oDataRow("PlanId")
      oRow("PlanCta") = oDataRow("PlanCta")
      oRow("PlanDes") = oDataRow("PlanDes")
      oRow("Fecha") = oDataRow("Fecha")
      oRow("TipoCompId") = oDataRow("TipoCompId")
      oRow("TipoCompDes") = oDataRow("TipoCompDes")
      oRow("CompNro") = oDataRow("CompNro")
      oRow("CompDetDes") = oDataRow("CompDetDes")
      oRow("TipoCambio") = oDataRow("TipoCambio")

      oRow("DebeBs") = oDataRow("DebeBs")
      oRow("HaberBs") = oDataRow("HaberBs")
      oRow("DebeUs") = oDataRow("DebeUs")
      oRow("HaberUs") = oDataRow("HaberUs")

      If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
         mdecSaldoBs += ToDecimalCinco(oRow("DebeBs") - oRow("HaberBs"))
         mdecSaldoUs += ToDecimalCinco(oRow("DebeUs") - oRow("HaberUs"))

      ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
         mdecSaldoBs += ToDecimalCinco(oRow("HaberBs") - oRow("DebeBs"))
         mdecSaldoUs += ToDecimalCinco(oRow("HaberUs") - oRow("DebeUs"))
      End If

      mdecDebeBs += ToDecimalCinco(oRow("DebeBs"))
      mdecHaberBs += ToDecimalCinco(oRow("HaberBs"))
      mdecDebeUs += ToDecimalCinco(oRow("DebeUs"))
      mdecHaberUs += ToDecimalCinco(oRow("HaberUs"))

      oRow("SaldoBs") = mdecSaldoBs
      oRow("SaldoUs") = mdecSaldoUs

      If ToDecimalCinco(oRow("DebeBs")) = 0 Then
         oRow("DebeBs") = System.Convert.DBNull
      End If

      If ToDecimalCinco(oRow("HaberBs")) = 0 Then
         oRow("HaberBs") = System.Convert.DBNull
      End If

      If ToDecimalCinco(oRow("DebeUs")) = 0 Then
         oRow("DebeUs") = System.Convert.DBNull
      End If

      If ToDecimalCinco(oRow("HaberUs")) = 0 Then
         oRow("HaberUs") = System.Convert.DBNull
      End If

      Return oRow
   End Function
#End Region

#Region " Grid-LibroMayor "
   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Libro Mayor"

         .RootTable.Columns("CompDetId").Visible = False

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("PlanCta").Visible = False

         .RootTable.Columns("PlanDes").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 80
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo"
         .RootTable.Columns("TipoCompDes").Width = 70
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNro").Caption = "Nro"
         .RootTable.Columns("CompNro").Width = 80
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompDetDes").Caption = "Glosa"
         .RootTable.Columns("CompDetDes").Width = 100
         .RootTable.Columns("CompDetDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompDetDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mlngMonedaId = 1 Then
            .RootTable.Columns("TipoCambio").Visible = False

            .RootTable.Columns("DebeBs").Caption = "Debe Bs."
            .RootTable.Columns("DebeBs").FormatString = DecimalMask()
            .RootTable.Columns("DebeBs").Width = 80
            .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberBs").Caption = "Haber Bs."
            .RootTable.Columns("HaberBs").FormatString = DecimalMask()
            .RootTable.Columns("HaberBs").Width = 80
            .RootTable.Columns("HaberBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoBs").Caption = "Saldo Bs."
            .RootTable.Columns("SaldoBs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoBs").Width = 80
            .RootTable.Columns("SaldoBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeUs").Visible = False

            .RootTable.Columns("HaberUs").Visible = False

            .RootTable.Columns("SaldoUs").Visible = False

         ElseIf mlngMonedaId = 2 Then
            .RootTable.Columns("TipoCambio").Visible = False

            .RootTable.Columns("DebeUs").Caption = "Debe Us"
            .RootTable.Columns("DebeUs").FormatString = DecimalMask()
            .RootTable.Columns("DebeUs").Width = 80
            .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberUs").Caption = "Haber Us."
            .RootTable.Columns("HaberUs").FormatString = DecimalMask()
            .RootTable.Columns("HaberUs").Width = 80
            .RootTable.Columns("HaberUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoUs").Caption = "Saldo Us."
            .RootTable.Columns("SaldoUs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoUs").Width = 80
            .RootTable.Columns("SaldoUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeBs").Visible = False

            .RootTable.Columns("HaberBs").Visible = False

            .RootTable.Columns("SaldoBs").Visible = False

         ElseIf mlngMonedaId = 4 Then
            .RootTable.Columns("TipoCambio").Caption = "T.C."
            .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
            .RootTable.Columns("TipoCambio").Width = 80
            .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeBs").Caption = "Debe Bs."
            .RootTable.Columns("DebeBs").FormatString = DecimalMask()
            .RootTable.Columns("DebeBs").Width = 80
            .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberBs").Caption = "Haber Bs."
            .RootTable.Columns("HaberBs").FormatString = DecimalMask()
            .RootTable.Columns("HaberBs").Width = 80
            .RootTable.Columns("HaberBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoBs").Caption = "Saldo Bs."
            .RootTable.Columns("SaldoBs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoBs").Width = 80
            .RootTable.Columns("SaldoBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeUs").Caption = "Debe Us."
            .RootTable.Columns("DebeUs").FormatString = DecimalMask()
            .RootTable.Columns("DebeUs").Width = 80
            .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberUs").Caption = "Haber Us."
            .RootTable.Columns("HaberUs").FormatString = DecimalMask()
            .RootTable.Columns("HaberUs").Width = 80
            .RootTable.Columns("HaberUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoUs").Caption = "Saldo Us."
            .RootTable.Columns("SaldoUs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoUs").Width = 80
            .RootTable.Columns("SaldoUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         End If
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub grdMainLoad()
      Dim lngMonedaId As Long

      Try
         Call moDataSetInit()
         mstrTipoAsientoId = TipoAsientoIdListaLoad()
         With moCompDet
            For Each lngPlanId As Long In moLista
               If mboolSinMovimiento Or TieneMovimiento(lngPlanId) Then
                  If mboolCuenta Then
                     .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
                  Else
                     .SelectFilter = clsCompDet.SelectFilters.LibroMayorGeneral
                  End If

                  If mboolIntervaloFecha Then
                     .WhereFilter = clsCompDet.WhereFilters.LibroMayorFecha
                     .Fecha = mstrFechaIni
                     .CompDetDes = mstrFechaFin
                  Else
                     .WhereFilter = clsCompDet.WhereFilters.LibroMayor
                  End If

                  If mboolOrdenarFecha Then
                     .OrderByFilter = clsCompDet.OrderByFilters.Fecha
                  Else
                     .OrderByFilter = clsCompDet.OrderByFilters.CompId
                  End If

                  .EmpresaId = mlngEmpresaId
                  .GestionId = mlngGestionId
                  .PlanId = lngPlanId
                  .Orden = ToBoolean(mboolSinFac) 'SinFac
                  .Automatico = ToBoolean(mboolConFac) 'ConFac
                  .LastUpdateDate = mstrTipoAsientoId
                  mdecSaldoBs = 0
                  mdecDebeBs = 0
                  mdecHaberBs = 0
                  mdecSaldoUs = 0
                  mdecDebeUs = 0
                  mdecHaberUs = 0

                  If .Open() Then
                     mlngGrupo = PlanGrupoFind(.PlanId)

                     If (mlngMonedaId = 3) Or (mlngMonedaId = 4) Then
                        lngMonedaId = PlanMonedaDefecto(.PlanId)
                     Else
                        lngMonedaId = mlngMonedaId
                     End If

                     If mboolSaldoAnterior Then
                        mdecSaldoBs = PlanSaldoAnteriorBs(.PlanId, mdecSaldoUs)
                     End If

                     moDataTable.Rows.Add(GetHeader(.PlanId))

                     For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                        moDataTable.Rows.Add(GetRow(oRow, lngMonedaId))
                     Next
                  End If
               End If
            Next

            grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call DataShow()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub DataEdit()
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("CompId")) > 0 Then
         Dim oComp As New clsComp(clsAppInfo.ConnectString)
         Dim lngCompDetId As Long

         Try
            With oComp
               .CompId = ToLong(grdMain.GetValue("CompId"))
               lngCompDetId = ToLong(grdMain.GetValue("CompDetId"))

               If .FindByPK Then
                  Dim frm As New frmCompEdit

                  If (.EstadoId <> 12) And (.EstadoId <> 10) Then
                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oComp
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdMainLoad()
                        Call grdMainFindRow(lngCompDetId)
                     End If

                  Else
                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oComp
                     frm.ShowDialog()
                  End If

                  frm.Dispose()
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Finally
            oComp.Dispose()
         End Try
      Else
         MessageBox.Show("Seleccione un Comprobante", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub DataShow()
      If grdMain.GetRow.Selected And ToLong(grdMain.GetValue("CompId")) > 0 Then
         Dim oComp As New clsComp(clsAppInfo.ConnectString)

         Try
            With oComp
               .CompId = ToLong(grdMain.GetValue("CompId"))

               If .FindByPK Then
                  Dim frm As New frmCompEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oComp

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Finally
            oComp.Dispose()
         End Try
      Else
         MessageBox.Show("Registro Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub
#End Region
#End Region

   Private Sub grdMainLoadOrg()
      Dim lngMonedaId As Long
      Dim lngPosition As Long

      Try
         'Call moDataSetInit()
         moCompDet = New clsCompDet(mstrConnectStringOrg)

         With moCompDet
            For Each lngPlanId As Long In moLista
               If Not mboolSinMovimiento Then
                  If TieneMovimiento(lngPlanId) Then
                     If mboolCuenta Then
                        .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
                     Else
                        .SelectFilter = clsCompDet.SelectFilters.LibroMayorGeneral
                     End If

                     If mboolIntervaloFecha Then
                        .WhereFilter = clsCompDet.WhereFilters.LibroMayorFecha
                        .Fecha = mstrFechaIni
                        .CompDetDes = mstrFechaFin
                     Else
                        .WhereFilter = clsCompDet.WhereFilters.LibroMayor
                     End If

                     If mboolOrdenarFecha Then
                        .OrderByFilter = clsCompDet.OrderByFilters.Fecha
                     Else
                        .OrderByFilter = clsCompDet.OrderByFilters.CompId
                     End If

                     .EmpresaId = mlngEmpresaId
                     .GestionId = mlngGestionId
                     .PlanId = lngPlanId
                     .Orden = ToBoolean(mboolSinFac) 'SinFac
                     .Automatico = ToBoolean(mboolConFac) 'ConFac

                     mdecSaldoBsOrg = 0
                     mdecDebeBsOrg = 0
                     mdecHaberBsOrg = 0
                     mdecSaldoUsOrg = 0
                     mdecDebeUsOrg = 0
                     mdecHaberUsOrg = 0

                     If .Open() Then
                        mlngGrupo = PlanGrupoFind(.PlanId)

                        If (mlngMonedaId = 3) Or (mlngMonedaId = 4) Then
                           lngMonedaId = PlanMonedaDefecto(.PlanId)
                        Else
                           lngMonedaId = mlngMonedaId
                        End If

                        If mboolSaldoAnterior Then
                           mdecSaldoBs = PlanSaldoAnteriorBs(.PlanId, mdecSaldoUs)
                        End If

                        'moDataTable.Rows.Add(GetHeader(.PlanId))

                        For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                           If RowFind(ToLong(oRow("CompDetId")), lngPosition) Then
                              Call EditRowOrg(oRow, lngPosition)

                           ElseIf RowFindByFecha(oRow("Fecha"), lngPosition) Then
                              moDataSet.Tables(moCompDet.TableName).Rows.InsertAt(NewRowOrg(oRow), lngPosition)
                           End If
                        Next

                        moDataTable.Rows.Add(GetFooter(lngMonedaId))
                        moDataTable.Rows.Add(GetRowNull)
                     End If
                  End If
               Else
                  If mboolCuenta Then
                     .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
                  Else
                     .SelectFilter = clsCompDet.SelectFilters.LibroMayorGeneral
                  End If

                  If mboolIntervaloFecha Then
                     .WhereFilter = clsCompDet.WhereFilters.LibroMayorFecha
                     .Fecha = mstrFechaIni
                     .CompDetDes = mstrFechaFin
                  Else
                     .WhereFilter = clsCompDet.WhereFilters.LibroMayor
                  End If

                  If mboolOrdenarFecha Then
                     .OrderByFilter = clsCompDet.OrderByFilters.Fecha
                  Else
                     .OrderByFilter = clsCompDet.OrderByFilters.CompId
                  End If

                  .EmpresaId = mlngEmpresaId
                  .GestionId = mlngGestionId
                  .PlanId = lngPlanId
                  .Orden = ToBoolean(mboolSinFac) 'SinFac
                  .Automatico = ToBoolean(mboolConFac) 'ConFac

                  mdecSaldoBsOrg = 0
                  mdecDebeBsOrg = 0
                  mdecHaberBsOrg = 0
                  mdecSaldoUsOrg = 0
                  mdecDebeUsOrg = 0
                  mdecHaberUsOrg = 0

                  If .Open() Then
                     mlngGrupo = PlanGrupoFind(.PlanId)

                     If (mlngMonedaId = 3) Or (mlngMonedaId = 4) Then
                        lngMonedaId = PlanMonedaDefecto(.PlanId)
                     Else
                        lngMonedaId = mlngMonedaId
                     End If

                     If mboolSaldoAnterior Then
                        mdecSaldoBs = PlanSaldoAnteriorBs(.PlanId, mdecSaldoUs)
                     End If

                     moDataTable.Rows.Add(GetHeader(.PlanId))

                     For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                        moDataTable.Rows.Add(GetRow(oRow, lngMonedaId))
                     Next

                     'moDataTable.Rows.Add(GetFooter(lngMonedaId))
                     'moDataTable.Rows.Add(GetRowNull)
                  End If
               End If
            Next

            Call RowFaltante()
            grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()
            Call grdMainInitOrg()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function RowFind(ByVal lngCompDetId As Long, ByRef lngPosition As Long) As Boolean
      Dim oRow As DataRow

      RowFind = False
      lngPosition = 0

      For Each oRow In moDataSet.Tables(moCompDet.TableName).Rows
         If ToLong(oRow("CompDetId")) = lngCompDetId Then
            RowFind = True

            Exit For
         End If

         lngPosition += 1
      Next
   End Function

   Private Function RowFindByFecha(ByVal datFecha As Date, ByRef lngPosition As Long) As Boolean
      Dim oRow As DataRow
      Dim lngPositionLast As Long = 0

      RowFindByFecha = False
      lngPosition = 0

      For Each oRow In moDataSet.Tables(moCompDet.TableName).Rows
         If ToDate2(oRow("Fecha")) >= ToDate2(datFecha) Then
            RowFindByFecha = True

            Exit For

         ElseIf IsDate(oRow("Fecha")) Then
            lngPositionLast = lngPosition
         End If

         lngPosition += 1
      Next

      If (Not RowFindByFecha) And (lngPositionLast < lngPosition) Then
         lngPosition = lngPositionLast + 1
         RowFindByFecha = True
      End If
   End Function

   Private Sub EditRowOrg(ByVal oDataRow As DataRow, ByVal lngPosition As Long)
      With moDataSet.Tables(moCompDet.TableName)
         .Rows(lngPosition).Item("CompDetIdOrg") = oDataRow("CompDetId")
         .Rows(lngPosition).Item("CompIdOrg") = oDataRow("CompId")
         .Rows(lngPosition).Item("PlanIdOrg") = oDataRow("PlanId")
         .Rows(lngPosition).Item("PlanCtaOrg") = oDataRow("PlanCta")
         .Rows(lngPosition).Item("PlanDesOrg") = oDataRow("PlanDes")
         .Rows(lngPosition).Item("FechaOrg") = oDataRow("Fecha")
         .Rows(lngPosition).Item("TipoCompIdOrg") = oDataRow("TipoCompId")
         .Rows(lngPosition).Item("TipoCompDesOrg") = oDataRow("TipoCompDes")
         .Rows(lngPosition).Item("CompNroOrg") = oDataRow("CompNro")
         .Rows(lngPosition).Item("CompDetDesOrg") = oDataRow("CompDetDes")
         .Rows(lngPosition).Item("TipoCambioOrg") = oDataRow("TipoCambio")

         .Rows(lngPosition).Item("DebeBsOrg") = oDataRow("DebeBs")
         .Rows(lngPosition).Item("HaberBsOrg") = oDataRow("HaberBs")
         .Rows(lngPosition).Item("DebeUsOrg") = oDataRow("DebeUs")
         .Rows(lngPosition).Item("HaberUsOrg") = oDataRow("HaberUs")

         If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
            mdecSaldoBsOrg += ToDecimalCinco(.Rows(lngPosition).Item("DebeBsOrg") - .Rows(lngPosition).Item("HaberBsOrg"))
            mdecSaldoUsOrg += ToDecimalCinco(.Rows(lngPosition).Item("DebeUsOrg") - .Rows(lngPosition).Item("HaberUsOrg"))

         ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
            mdecSaldoBsOrg += ToDecimalCinco(.Rows(lngPosition).Item("HaberBsOrg") - .Rows(lngPosition).Item("DebeBsOrg"))
            mdecSaldoUsOrg += ToDecimalCinco(.Rows(lngPosition).Item("HaberUsOrg") - .Rows(lngPosition).Item("DebeUsOrg"))
         End If

         mdecDebeBsOrg += ToDecimalCinco(.Rows(lngPosition).Item("DebeBsOrg"))
         mdecHaberBsOrg += ToDecimalCinco(.Rows(lngPosition).Item("HaberBsOrg"))
         mdecDebeUsOrg += ToDecimalCinco(.Rows(lngPosition).Item("DebeUsOrg"))
         mdecHaberUsOrg += ToDecimalCinco(.Rows(lngPosition).Item("HaberUsOrg"))

         .Rows(lngPosition).Item("SaldoBsOrg") = mdecSaldoBsOrg
         .Rows(lngPosition).Item("SaldoUsOrg") = mdecSaldoUsOrg

         If ToDecimalCinco(.Rows(lngPosition).Item("DebeBsOrg")) = 0 Then
            .Rows(lngPosition).Item("DebeBsOrg") = System.Convert.DBNull
         End If

         If ToDecimalCinco(.Rows(lngPosition).Item("HaberBsOrg")) = 0 Then
            .Rows(lngPosition).Item("HaberBsOrg") = System.Convert.DBNull
         End If

         If ToDecimalCinco(.Rows(lngPosition).Item("DebeUsOrg")) = 0 Then
            .Rows(lngPosition).Item("DebeUsOrg") = System.Convert.DBNull
         End If

         If ToDecimalCinco(.Rows(lngPosition).Item("HaberUsOrg")) = 0 Then
            .Rows(lngPosition).Item("HaberUsOrg") = System.Convert.DBNull
         End If
      End With
   End Sub

   Private Function NewRowOrg(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow

      oRow = moDataTable.NewRow

      oRow("Separador") = "*"
      oRow("CompDetIdOrg") = oDataRow("CompDetId")
      oRow("CompIdOrg") = oDataRow("CompId")
      oRow("PlanIdOrg") = oDataRow("PlanId")
      oRow("PlanCtaOrg") = oDataRow("PlanCta")
      oRow("PlanDesOrg") = oDataRow("PlanDes")
      oRow("FechaOrg") = oDataRow("Fecha")
      oRow("TipoCompIdOrg") = oDataRow("TipoCompId")
      oRow("TipoCompDesOrg") = oDataRow("TipoCompDes")
      oRow("CompNroOrg") = oDataRow("CompNro")
      oRow("CompDetDesOrg") = oDataRow("CompDetDes")
      oRow("TipoCambioOrg") = oDataRow("TipoCambio")

      oRow("DebeBsOrg") = oDataRow("DebeBs")
      oRow("HaberBsOrg") = oDataRow("HaberBs")
      oRow("DebeUsOrg") = oDataRow("DebeUs")
      oRow("HaberUsOrg") = oDataRow("HaberUs")

      If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
         mdecSaldoBsOrg += ToDecimalCinco(oRow("DebeBsOrg") - oRow("HaberBsOrg"))
         mdecSaldoUsOrg += ToDecimalCinco(oRow("DebeUsOrg") - oRow("HaberUsOrg"))

      ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
         mdecSaldoBsOrg += ToDecimalCinco(oRow("HaberBsOrg") - oRow("DebeBsOrg"))
         mdecSaldoUsOrg += ToDecimalCinco(oRow("HaberUsOrg") - oRow("DebeUsOrg"))
      End If

      mdecDebeBsOrg += ToDecimalCinco(oRow("DebeBsOrg"))
      mdecHaberBsOrg += ToDecimalCinco(oRow("HaberBsOrg"))
      mdecDebeUsOrg += ToDecimalCinco(oRow("DebeUsOrg"))
      mdecHaberUsOrg += ToDecimalCinco(oRow("HaberUsOrg"))

      oRow("SaldoBsOrg") = mdecSaldoBsOrg
      oRow("SaldoUsOrg") = mdecSaldoUsOrg

      If ToDecimalCinco(oRow("DebeBsOrg")) = 0 Then
         oRow("DebeBsOrg") = System.Convert.DBNull
      End If

      If ToDecimalCinco(oRow("HaberBsOrg")) = 0 Then
         oRow("HaberBsOrg") = System.Convert.DBNull
      End If

      If ToDecimalCinco(oRow("DebeUsOrg")) = 0 Then
         oRow("DebeUsOrg") = System.Convert.DBNull
      End If

      If ToDecimalCinco(oRow("HaberUsOrg")) = 0 Then
         oRow("HaberUsOrg") = System.Convert.DBNull
      End If

      Return oRow
   End Function

   Private Sub RowFaltante()
      Dim oRow As DataRow

      For Each oRow In moDataSet.Tables(moCompDet.TableName).Rows
         If (ToLong(oRow("CompDetId")) > 0) And (ToLong(oRow("CompDetIdOrg")) = 0) Then
            oRow("Separador") = "*"
         End If
      Next
   End Sub

   Private Function GetFooter(ByVal lngMonedaId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompDetId") = -1
      oRow("CompDetDes") = "Totales de Cuenta " & MonedaDesFind(lngMonedaId)

      oRow("DebeBs") = mdecDebeBs
      oRow("HaberBs") = mdecHaberBs
      oRow("DebeUs") = mdecDebeUs
      oRow("HaberUs") = mdecHaberUs

      oRow("DebeBsOrg") = mdecDebeBsOrg
      oRow("HaberBsOrg") = mdecHaberBsOrg
      oRow("DebeUsOrg") = mdecDebeUsOrg
      oRow("HaberUsOrg") = mdecHaberUsOrg

      Return oRow
   End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
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

   Private Sub grdMainInitOrg()
      With grdMain
         .RootTable.Columns("Separador").Caption = ""
         .RootTable.Columns("Separador").Width = 20
         .RootTable.Columns("Separador").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Separador").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompDetIdOrg").Visible = False

         .RootTable.Columns("CompIdOrg").Visible = False

         .RootTable.Columns("PlanIdOrg").Visible = False

         .RootTable.Columns("PlanCtaOrg").Visible = False

         .RootTable.Columns("PlanDesOrg").Visible = False

         .RootTable.Columns("FechaOrg").Caption = "Fecha"
         .RootTable.Columns("FechaOrg").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("FechaOrg").Width = 80
         .RootTable.Columns("FechaOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("FechaOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompIdOrg").Visible = False

         .RootTable.Columns("TipoCompDesOrg").Caption = "Tipo"
         .RootTable.Columns("TipoCompDesOrg").Width = 70
         .RootTable.Columns("TipoCompDesOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDesOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNroOrg").Caption = "Nro"
         .RootTable.Columns("CompNroOrg").Width = 80
         .RootTable.Columns("CompNroOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNroOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompDetDesOrg").Caption = "Glosa"
         .RootTable.Columns("CompDetDesOrg").Width = 100
         .RootTable.Columns("CompDetDesOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompDetDesOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mlngMonedaId = 1 Then
            .RootTable.Columns("TipoCambioOrg").Visible = False

            .RootTable.Columns("DebeBsOrg").Caption = "Debe Bs."
            .RootTable.Columns("DebeBsOrg").FormatString = DecimalMask()
            .RootTable.Columns("DebeBsOrg").Width = 80
            .RootTable.Columns("DebeBsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeBsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberBsOrg").Caption = "Haber Bs."
            .RootTable.Columns("HaberBsOrg").FormatString = DecimalMask()
            .RootTable.Columns("HaberBsOrg").Width = 80
            .RootTable.Columns("HaberBsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberBsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoBsOrg").Caption = "Saldo Bs."
            .RootTable.Columns("SaldoBsOrg").FormatString = DecimalMask()
            .RootTable.Columns("SaldoBsOrg").Width = 80
            .RootTable.Columns("SaldoBsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoBsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeUsOrg").Visible = False

            .RootTable.Columns("HaberUsOrg").Visible = False

            .RootTable.Columns("SaldoUsOrg").Visible = False

         ElseIf mlngMonedaId = 2 Then
            .RootTable.Columns("TipoCambioOrg").Visible = False

            .RootTable.Columns("DebeUsOrg").Caption = "Debe Us"
            .RootTable.Columns("DebeUsOrg").FormatString = DecimalMask()
            .RootTable.Columns("DebeUsOrg").Width = 80
            .RootTable.Columns("DebeUsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeUsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberUsOrg").Caption = "Haber Us."
            .RootTable.Columns("HaberUsOrg").FormatString = DecimalMask()
            .RootTable.Columns("HaberUsOrg").Width = 80
            .RootTable.Columns("HaberUsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberUsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoUsOrg").Caption = "Saldo Us."
            .RootTable.Columns("SaldoUsOrg").FormatString = DecimalMask()
            .RootTable.Columns("SaldoUsOrg").Width = 80
            .RootTable.Columns("SaldoUsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoUsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeBsOrg").Visible = False

            .RootTable.Columns("HaberBsOrg").Visible = False

            .RootTable.Columns("SaldoBsOrg").Visible = False

         ElseIf mlngMonedaId = 4 Then
            .RootTable.Columns("TipoCambioOrg").Caption = "T.C."
            .RootTable.Columns("TipoCambioOrg").FormatString = DecimalMask()
            .RootTable.Columns("TipoCambioOrg").Width = 80
            .RootTable.Columns("TipoCambioOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("TipoCambioOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeBsOrg").Caption = "Debe Bs."
            .RootTable.Columns("DebeBsOrg").FormatString = DecimalMask()
            .RootTable.Columns("DebeBsOrg").Width = 80
            .RootTable.Columns("DebeBsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeBsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberBsOrg").Caption = "Haber Bs."
            .RootTable.Columns("HaberBsOrg").FormatString = DecimalMask()
            .RootTable.Columns("HaberBsOrg").Width = 80
            .RootTable.Columns("HaberBsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberBsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoBsOrg").Caption = "Saldo Bs."
            .RootTable.Columns("SaldoBsOrg").FormatString = DecimalMask()
            .RootTable.Columns("SaldoBsOrg").Width = 80
            .RootTable.Columns("SaldoBsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoBsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeUsOrg").Caption = "Debe Us."
            .RootTable.Columns("DebeUsOrg").FormatString = DecimalMask()
            .RootTable.Columns("DebeUsOrg").Width = 80
            .RootTable.Columns("DebeUsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeUsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberUsOrg").Caption = "Haber Us."
            .RootTable.Columns("HaberUsOrg").FormatString = DecimalMask()
            .RootTable.Columns("HaberUsOrg").Width = 80
            .RootTable.Columns("HaberUsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberUsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoUsOrg").Caption = "Saldo Us."
            .RootTable.Columns("SaldoUsOrg").FormatString = DecimalMask()
            .RootTable.Columns("SaldoUsOrg").Width = 80
            .RootTable.Columns("SaldoUsOrg").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoUsOrg").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         End If
      End With

      'Call AddConditionalFormatting()
   End Sub

   Public Function TipoCompFind(ByVal lngTipoCompId As Long) As String
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)

      TipoCompFind = ""
      Try
         With oTipoComp
            .TipoCompId = lngTipoCompId

            If .FindByPK Then
               TipoCompFind = .TipoCompDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oTipoComp.Dispose()
      End Try
   End Function
End Class
