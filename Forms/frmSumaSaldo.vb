Public Class frmSumaSaldo
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

   Private mdecHaber As Decimal
   Private mdecDebe As Decimal
   Private mdecHaberTotal As Decimal
   Private mdecDebeTotal As Decimal
   Private mdecHaberPerTotal As Decimal
   Private mdecDebePerTotal As Decimal
   Private mlngGrupo As Long

   Private moDataSet As DataSet
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

   Private mlngCentroCostoId As Long
   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get
      Set(ByVal value As Long)
         mlngCentroCostoId = value
      End Set
   End Property

   Private mstrCentroCostoDes As String
   Property CentroCostoDes() As String
      Get
         Return mstrCentroCostoDes
      End Get
      Set(ByVal value As String)
         mstrCentroCostoDes = value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSumaSaldo))
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2})
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
      'frmSumaSaldo
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmSumaSaldo"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Balance de Sumas y Saldos"
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
      Dim rpt As New rptSumaSaldo

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompDet.TableName))

      rpt.lblTitle.Text = "Balance de Sumas y Saldos"
      rpt.Document.Name = "Balance de Sumas y Saldos"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
      rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)
      rpt.CentroCostoId = mlngCentroCostoId
      rpt.txtCentroCostoDes.Text = mstrCentroCostoDes

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
      Dim rpt As New rptSumaSaldoExt

      rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompDet.TableName))

      rpt.lblTitle.Text = "Balance de Sumas y Saldos"
      rpt.Document.Name = "Balance de Sumas y Saldos"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
      rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)
      rpt.CentroCostoId = mlngCentroCostoId
      rpt.txtCentroCostoDes.Text = mstrCentroCostoDes

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

      If ToLong(grdMain.GetValue("PlanId")) <> 0 Then
         oLista.Enqueue(ToLong(grdMain.GetValue("PlanId")))
         lngPlanId = ToLong(grdMain.GetValue("PlanId"))
      End If

      If oLista.Count Then
         If mlngCentroCostoId = 0 Then
            Dim frm As New frmLibroMayor

            With frm
               .EmpresaId = mlngEmpresaId
               .GestionId = clsAppInfo.GestionId
               .MonedaId = mlngMonedaId
               .SaldoAnterior = mboolSaldoAnterior
               .Cuenta = True
               .SinMovimiento = False
               .IntervaloFecha = mboolIntervaloFecha
               .FechaIni = mstrFechaIni
               .FechaFin = mstrFechaFin
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
            Dim oListaCC As New Queue
            oListaCC.Enqueue(mlngCentroCostoId)

            Dim frm As New frmLibroCentroCosto

            With frm
               .EmpresaId = mlngEmpresaId
               .GestionId = clsAppInfo.GestionId
               .MonedaId = mlngMonedaId
               .SaldoAnterior = mboolSaldoAnterior
               .Cuenta = True
               .IncluirDetalle = True
               .IntervaloFecha = mboolIntervaloFecha
               .FechaIni = mstrFechaIni
               .FechaFin = mstrFechaFin
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
         End If
      Else
         MessageBox.Show("Debe Seleccionar al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub frmSumaSaldo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmLibroMayorLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmSumaSaldo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
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
            .CentroCostoId = mlngCentroCostoId
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
            .CentroCostoId = mlngCentroCostoId
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
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Saldo"), Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanCta"), Janus.Windows.GridEX.ConditionOperator.Equal, System.Convert.DBNull)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("PlanAddId"), Janus.Windows.GridEX.ConditionOperator.GreaterThan, 0)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " DataSet Suma-Saldo "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCompDet.TableName)

      If Not mboolUltimoPeriodo Then
         moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
         moDataTable.Columns.Add("PlanAddId", Type.GetType("System.Int32"))
         moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
         moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
         moDataTable.Columns.Add("SaldoAnt", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Debe", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Haber", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Saldo", Type.GetType("System.Decimal"))
      Else
         moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
         moDataTable.Columns.Add("PlanAddId", Type.GetType("System.Int32"))
         moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
         moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
         moDataTable.Columns.Add("SaldoAnt", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Debe", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Haber", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("Saldo", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("DebePer", Type.GetType("System.Decimal"))
         moDataTable.Columns.Add("HaberPer", Type.GetType("System.Decimal"))
      End If
   End Sub

   Private Function GetRow(ByVal lngPlanId As Long) As DataRow
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               oRow("PlanId") = ToLong(.PlanId)
               oRow("PlanCta") = ToStr(.PlanCta)
               oRow("PlanDes") = ToStr(.PlanDes)
            End If

            If mboolSaldoAnterior Then
               oRow("SaldoAnt") = PlanSaldoAnterior(.PlanId, mlngMonedaId)
            End If

            oRow("Debe") = mdecDebe
            oRow("Haber") = mdecHaber

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
               If mlngMonedaId = 1 Then
                  oRow("DebePer") = SumarSaldos(oRow("PlanId"), 1, clsCompDet.WhereFilters.RowSumGestion)
                  oRow("HaberPer") = SumarSaldos(oRow("PlanId"), 2, clsCompDet.WhereFilters.RowSumGestion)
               ElseIf mlngMonedaId = 2 Then
                  oRow("DebePer") = SumarSaldos(oRow("PlanId"), 3, clsCompDet.WhereFilters.RowSumGestion)
                  oRow("HaberPer") = SumarSaldos(oRow("PlanId"), 4, clsCompDet.WhereFilters.RowSumGestion)
               End If

               mdecDebePerTotal = mdecDebePerTotal + oRow("DebePer")
               mdecHaberPerTotal = mdecHaberPerTotal + oRow("HaberPer")

               If ToDecimal(oRow("DebePer")) = 0 Then
                  oRow("DebePer") = System.Convert.DBNull
               End If

               If ToDecimal(oRow("HaberPer")) = 0 Then
                  oRow("HaberPer") = System.Convert.DBNull
               End If
            End If
         End With

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
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

      If lngMonedaId = 1 Then
         oRow("PlanDes") = "Total Saldos en " & MonedaDesFind(lngMonedaId)

      ElseIf lngMonedaId = 2 Then
         oRow("PlanDes") = "Total Saldos en " & MonedaDesFind(lngMonedaId)
      End If

      oRow("Debe") = mdecDebeTotal
      oRow("Haber") = mdecHaberTotal

      If mboolUltimoPeriodo Then
         oRow("DebePer") = mdecDebePerTotal
         oRow("HaberPer") = mdecHaberPerTotal
      End If

      Return oRow
   End Function
#End Region

#Region " Grid Suma-Saldo "
   Private Sub grdMainLoad()
      Try
         Call moDataSetInit()
         mstrTipoAsientoId = TipoAsientoIdListaLoad()

         mdecDebeTotal = 0
         mdecHaberTotal = 0
         mdecDebePerTotal = 0
         mdecHaberPerTotal = 0
         For Each lngPlanId As Long In moLista
            Dim decSaldoPlan As Decimal = 0
            If ConMovimiento(lngPlanId) Then
               mlngGrupo = PlanGrupoFind(lngPlanId)

               If mboolIntervaloFecha Then
                  If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                     mdecDebe = SumarSaldos(lngPlanId, 1, clsCompDet.WhereFilters.RowSumFecha)
                     mdecHaber = SumarSaldos(lngPlanId, 2, clsCompDet.WhereFilters.RowSumFecha)

                  ElseIf mlngMonedaId = clsMoneda.DOLARES Then
                     mdecDebe = SumarSaldos(lngPlanId, 3, clsCompDet.WhereFilters.RowSumFecha)
                     mdecHaber = SumarSaldos(lngPlanId, 4, clsCompDet.WhereFilters.RowSumFecha)
                  End If
               Else
                  If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                     mdecDebe = SumarSaldos(lngPlanId, 1, clsCompDet.WhereFilters.RowSumGestion)
                     mdecHaber = SumarSaldos(lngPlanId, 2, clsCompDet.WhereFilters.RowSumGestion)

                  ElseIf mlngMonedaId = clsMoneda.DOLARES Then
                     mdecDebe = SumarSaldos(lngPlanId, 3, clsCompDet.WhereFilters.RowSumGestion)
                     mdecHaber = SumarSaldos(lngPlanId, 4, clsCompDet.WhereFilters.RowSumGestion)
                  End If
               End If

               If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                  decSaldoPlan = mdecDebe - mdecHaber

               ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                  decSaldoPlan = mdecHaber - mdecDebe
               End If

               If Math.Abs(decSaldoPlan) > 0 Or mboolSaldoCero Then
                  moDataTable.Rows.Add(GetRow(lngPlanId))

                  If mboolIncluirPlanAdd And TieneAnaAddFind(lngPlanId) Then
                     Call IncluirAnaliticosAdicionales(lngPlanId)
                  End If

                  mdecDebeTotal = mdecDebeTotal + mdecDebe
                  mdecHaberTotal = mdecHaberTotal + mdecHaber
               End If
            End If
         Next

         moDataTable.Rows.Add(GetRowNull)
         moDataTable.Rows.Add(GetFooter(mlngMonedaId))

         grdMain.DataSource = moDataSet.Tables(moCompDet.TableName).DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

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

   Private Function ToValue(ByVal value As Decimal) As Object
      If value = 0 Then
         ToValue = System.Convert.DBNull
      Else
         ToValue = value
      End If
   End Function

   Private Sub IncluirAnaliticosAdicionales(ByVal lngPlanId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      'Dim decSumSaldo As Decimal = 0
      Dim decSaldoAnt As Decimal = 0
      Dim decSaldo As Decimal = 0
      Dim decDebe As Decimal = 0
      Dim decHaber As Decimal = 0
      Dim decDebePer As Decimal = 0
      Dim decHaberPer As Decimal = 0
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
               Dim strFiltroCentroCosto As String = ""
               If mboolIntervaloFecha Then
                  strFiltroFecha = "Fecha >= '" & ConvertDMY(mstrFechaIni) & "' and Fecha <= '" & ConvertDMY(mstrFechaFin) & "' "
               End If

               If mlngCentroCostoId > 0 Then
                  strFiltroCentroCosto = "CentroCostoId = " & mlngCentroCostoId
               End If

               Do While .Read
                  'decSumSaldo = 0
                  decSaldoAnt = 0
                  decSaldo = 0
                  decDebe = 0
                  decHaber = 0
                  decDebePer = 0
                  decHaberPer = 0

                  Dim dataTableCompPlanAdd As DataTable = SaldoPlanAddBs(.PlanId, .PlanAddId)
                  If dataTableCompPlanAdd IsNot Nothing Then
                     Dim existeMovimientoCC As Boolean = mlngCentroCostoId = 0

                     If mlngCentroCostoId > 0 Then
                        existeMovimientoCC = dataTableCompPlanAdd.AsEnumerable.ToList.Exists(Function(f) f("CentroCostoId") = mlngCentroCostoId)
                     End If

                     If existeMovimientoCC Then
                        Dim oRow As DataRow = moDataTable.NewRow
                        strFiltro = strFiltroFecha & If(mboolIntervaloFecha And mlngCentroCostoId > 0, " AND ", "") & strFiltroCentroCosto
                        decSaldo = SumarColumnas(dataTableCompPlanAdd, strFiltro, decDebe, decHaber)

                        If mboolSaldoAnterior Then
                           strFiltro = "Fecha < '" & ConvertDMY(mstrFechaIni) & "'" & If(mlngCentroCostoId > 0, " AND " & strFiltroCentroCosto, "")
                           Dim decDebeTemp As Decimal = 0
                           Dim decHaberTemp As Decimal = 0
                           decSaldoAnt = SumarColumnas(dataTableCompPlanAdd, strFiltro, decDebeTemp, decHaberTemp)
                        End If

                        If mboolUltimoPeriodo Then
                           strFiltro = strFiltroCentroCosto
                           Call SumarColumnas(dataTableCompPlanAdd, strFiltro, decDebePer, decHaberPer)
                           oRow("DebePer") = ToValue(decDebePer)
                           oRow("HaberPer") = ToValue(decHaberPer)
                        End If

                        'decSumSaldo += Math.Abs(decSaldo)

                        oRow("SaldoAnt") = ToValue(decSaldoAnt)
                        oRow("Debe") = ToValue(decDebe)
                        oRow("Haber") = ToValue(decHaber)
                        oRow("Saldo") = ToValue(decSaldo)

                        oRow("PlanAddId") = oPlanAdd.PlanAddId
                        oRow("PlanCta") = oPlanAdd.PlanAddCta
                        oRow("PlanDes") = "     " & oPlanAdd.PlanAddDes

                        If (decDebe <> 0 Or decHaber <> 0) Or (mboolSaldoAnterior And decSaldoAnt <> 0) Or (mboolUltimoPeriodo And (decDebePer <> 0 Or decHaberPer <> 0)) Then
                           moDataTable.Rows.Add(oRow)
                        End If
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

   Private Function TieneAnaAddFind(ByVal lngPlanId As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      TieneAnaAddFind = False
      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               TieneAnaAddFind = .TieneAnaAdd
            End If
         End With
      Catch ex As Exception
         Throw ex
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Balance de Sumas y Saldos " & If(mlngCentroCostoId <> 0, "C.C.: " & mstrCentroCostoDes, "")

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("PlanAddId").Visible = False

         .RootTable.Columns("PlanCta").Caption = "Cuenta"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripción"
         .RootTable.Columns("PlanDes").Width = 270
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SaldoAnt").Caption = "Saldo Ant."
         .RootTable.Columns("SaldoAnt").FormatString = DecimalMask()
         .RootTable.Columns("SaldoAnt").Width = 100
         .RootTable.Columns("SaldoAnt").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("SaldoAnt").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Debe").Caption = "Débito"
         .RootTable.Columns("Debe").FormatString = DecimalMask()
         .RootTable.Columns("Debe").Width = 100
         .RootTable.Columns("Debe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Debe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Haber").Caption = "Crédito"
         .RootTable.Columns("Haber").FormatString = DecimalMask()
         .RootTable.Columns("Haber").Width = 100
         .RootTable.Columns("Haber").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Haber").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Saldo").Caption = "Saldo"
         .RootTable.Columns("Saldo").FormatString = DecimalMask()
         .RootTable.Columns("Saldo").Width = 100
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
