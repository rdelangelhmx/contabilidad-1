Public Class frmLibroPlanAddAna
   Inherits System.Windows.Forms.Form

   Private moCompPlanAdd As clsCompPlanAdd
   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngPlanId As Long
   Private mlngCentroCostoId As Long
   Private mlngMonedaId As Long
   Private mboolIntervaloFecha As Boolean
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolSaldoAnterior As Boolean
   Private mboolCuenta As Boolean
   Private mboolIncluirDetalle As Boolean
   Private mboolSaldoCero As Boolean
   Private mboolSinFac As Boolean
   Private mboolConFac As Boolean

   Private moListaTipoAsiento As New Queue
   Private mstrTipoAsientoId As String

   Private mdecHaberBs As Decimal
   Private mdecDebeBs As Decimal
   Private mdecSaldoBs As Decimal
   Private mdecSaldoPlanAddBs As Decimal

   Private mdecHaberUs As Decimal
   Private mdecDebeUs As Decimal
   Private mdecSaldoUs As Decimal
   Private mdecSaldoPlanAddUs As Decimal

   Private mdecHaberPlanBs As Decimal
   Private mdecDebePlanBs As Decimal
   Private mdecSaldoPlanBs As Decimal

   Private mdecHaberPlanUs As Decimal
   Private mdecDebePlanUs As Decimal
   Private mdecSaldoPlanUs As Decimal

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

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
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

   Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngMonedaId = Value
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

   Property IncluirDetalle() As Boolean
      Get
         Return mboolIncluirDetalle
      End Get

      Set(ByVal Value As Boolean)
         mboolIncluirDetalle = Value
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroPlanAddAna))
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
      Me.cdmMain.Id = New System.Guid("2271b7ee-5728-4de4-a273-0898d1b78e80")
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
      Me.Book1.ImageIndex = 1
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
      'frmLibroPlanAddAna
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmLibroPlanAddAna"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Movimiento de Anal?ticos Adicionales"
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

   Private Sub frmLibroPlanAddAna_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmLibroPlanAddAna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

      moCompPlanAdd = New clsCompPlanAdd(clsAppInfo.ConnectString)
   End Sub

   Private Sub DataShow()
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("CompId")) > 0) Then
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
         Else
            MessageBox.Show("Registro Invalido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
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

   Private Sub DataEdit()
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            With oComp
               .CompId = ToLong(grdMain.GetValue("CompId"))

               If .FindByPK Then
                  Dim frm As New frmCompEdit

                  If (.EstadoId <> 12) And (.EstadoId <> 10) Then
                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oComp
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdMainLoad()
                        Call grdMainFindRow(frm.ID)
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
         Else
            MessageBox.Show("Seleccione un Comprobante", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompDetId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

#Region " Print "
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
            Dim rpt As New rptLibroPlanAdd

            rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompPlanAdd.TableName))

            rpt.lblTitle.Text = "Movimiento de Anal?ticos Adicionales"
            rpt.Document.Name = "Movimiento de Anal?ticos Adicionales"
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
            Dim rpt As New rptLibroPlanAddExt

            rpt.DataSource = GetDataView(moDataTable.DataSet.Tables(moCompPlanAdd.TableName))

            rpt.lblTitle.Text = "Movimiento de Anal?ticos Adicionales"
            rpt.Document.Name = "Movimiento de Anal?ticos Adicionales"
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
#End Region

   Private Sub frmLibroPlanAddAna_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call DataEdit()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmLibroPlanAddAna_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompPlanAdd.Dispose()
      Call ClearMemory()
   End Sub

#Region " LIBRO-PLAN-ADD-ANA "
#Region " Metodo-LibroPlanAddAna "
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

   Private Function PlanSaldoAnteriorBs(ByVal lngPlanId As Long, ByVal lngPlanAddId As Long, ByRef decSaldoUs As Decimal) As Decimal
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0

      decSaldoUs = 0

      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayorSaldoAnterior

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .Fecha = mstrFechaIni
            .PlanAddId = lngPlanAddId
            .CompId = mlngCentroCostoId 'CentroCostoId
            .MonedaId = ToBoolean(mboolSinFac) 'SinFac
            .EstadoId = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                     decSaldoBs += ToDecimal(oRow("DebeBs") - oRow("HaberBs"))
                     decSaldoUs += ToDecimal(oRow("DebeUs") - oRow("HaberUs"))

                  ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                     decSaldoBs += ToDecimal(oRow("HaberBs") - oRow("DebeBs"))
                     decSaldoUs += ToDecimal(oRow("HaberUs") - oRow("DebeUs"))
                  End If
               Next

               PlanSaldoAnteriorBs = decSaldoBs
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function SaldoPlanAddBs(ByVal lngPlanId As Long, ByVal lngPlanAddId As Long, ByRef decSaldoUs As Decimal, ByRef boolTieneMov As Boolean) As Decimal
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0

      decSaldoUs = 0
      boolTieneMov = False

      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuenta

            If mboolIntervaloFecha Then
               .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayorFecha
               .Fecha = mstrFechaIni
               .LastUpdateId = mstrFechaFin
            Else
               .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayor
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = lngPlanId
            .PlanAddId = lngPlanAddId
            .CompId = mlngCentroCostoId 'CentroCostoId
            .MonedaId = ToBoolean(mboolSinFac) 'SinFac
            .EstadoId = ToBoolean(mboolConFac) 'ConFac
            .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If (mlngGrupo = 1) Or (mlngGrupo = 5) Or (mlngGrupo = 6) Or (mlngGrupo = 7) Then
                     decSaldoBs += ToDecimal(oRow("DebeBs") - oRow("HaberBs"))
                     decSaldoUs += ToDecimal(oRow("DebeUs") - oRow("HaberUs"))

                  ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
                     decSaldoBs += ToDecimal(oRow("HaberBs") - oRow("DebeBs"))
                     decSaldoUs += ToDecimal(oRow("HaberUs") - oRow("DebeUs"))
                  End If

                  boolTieneMov = True
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
            .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
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

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("SaldoBs"), Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompDetId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompDetId"), Janus.Windows.GridEX.ConditionOperator.Equal, -2)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " DataSet-LibroPlanAddAna "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCompPlanAdd.TableName)

      moDataTable.Columns.Add("CompDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.String"))
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
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow, ByVal lngMonedaId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompDetId") = oDataRow("CompDetId")
      oRow("CompId") = oDataRow("CompId")
      oRow("PlanId") = oDataRow("PlanId")
      oRow("Fecha") = ToDateDMY(oDataRow("Fecha"))
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
         mdecSaldoBs += ToDecimal(oRow("DebeBs") - oRow("HaberBs"))
         mdecSaldoUs += ToDecimal(oRow("DebeUs") - oRow("HaberUs"))

      ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
         mdecSaldoBs += ToDecimal(oRow("HaberBs") - oRow("DebeBs"))
         mdecSaldoUs += ToDecimal(oRow("HaberUs") - oRow("DebeUs"))
      End If

      mdecDebeBs += ToDecimal(oRow("DebeBs"))
      mdecHaberBs += ToDecimal(oRow("HaberBs"))
      mdecDebeUs += ToDecimal(oRow("DebeUs"))
      mdecHaberUs += ToDecimal(oRow("HaberUs"))

      mdecDebePlanBs += oRow("DebeBs")
      mdecHaberPlanBs += oRow("HaberBs")
      mdecDebePlanUs += oRow("DebeUs")
      mdecHaberPlanUs += oRow("HaberUs")

      oRow("SaldoBs") = mdecSaldoBs
      oRow("SaldoUs") = mdecSaldoUs

      If ToDecimal(oRow("DebeBs")) = 0 Then
         oRow("DebeBs") = System.Convert.DBNull
      End If

      If ToDecimal(oRow("HaberBs")) = 0 Then
         oRow("HaberBs") = System.Convert.DBNull
      End If

      If ToDecimal(oRow("DebeUs")) = 0 Then
         oRow("DebeUs") = System.Convert.DBNull
      End If

      If ToDecimal(oRow("HaberUs")) = 0 Then
         oRow("HaberUs") = System.Convert.DBNull
      End If

      Return oRow
   End Function

   Private Function GetHeader(ByVal lngPlanId As Long) As DataRow
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         oRow("CompDetId") = -1
         oRow("TipoCompDes") = "Cuenta"

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

   Private Function GetHeaderPlanAdd(ByVal strPlanAddCta As String, ByVal strPlanAddDes As String, ByVal lngPlanId As Long, ByVal lngPlanAddId As Long, ByVal lngMonedaId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Try
         oRow("CompDetId") = -2
         oRow("TipoCompDes") = "Ana. Adic."
         oRow("CompNro") = strPlanAddCta
         oRow("CompDetDes") = strPlanAddDes

         If mboolIncluirDetalle Then
            oRow("SaldoBs") = mdecSaldoPlanAddBs
            oRow("SaldoUs") = mdecSaldoPlanAddUs

         Else
            mdecSaldoBs = SaldoPlanAddBs(lngPlanId, lngPlanAddId, mdecSaldoUs, 0)
            mdecSaldoBs = mdecSaldoPlanAddBs + mdecSaldoBs
            oRow("SaldoBs") = mdecSaldoBs

            mdecSaldoUs = mdecSaldoPlanAddUs + mdecSaldoUs
            oRow("SaldoUs") = mdecSaldoUs
         End If

         Return oRow

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function GetFooterPlanAdd(ByVal strPlanAddDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompDetId") = -2

      If mlngMonedaId = 1 Then
         oRow("CompDetDes") = "Totales de " + strPlanAddDes + " en " & MonedaDesFind(mlngMonedaId)

      ElseIf mlngMonedaId = 2 Then
         oRow("CompDetDes") = "Totales de " + strPlanAddDes + " en " & MonedaDesFind(mlngMonedaId)

      Else
         oRow("CompDetDes") = "Totales "
      End If

      oRow("DebeBs") = mdecDebeBs
      oRow("HaberBs") = mdecHaberBs

      oRow("DebeUs") = mdecDebeUs
      oRow("HaberUs") = mdecHaberUs

      Return oRow
   End Function

   Private Function GetFooter(ByVal lngPlanId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompDetId") = -1

      If mlngMonedaId = 1 Then
         oRow("CompDetDes") = "Totales de Cuenta " & MonedaDesFind(mlngMonedaId)

      ElseIf mlngMonedaId = 2 Then
         oRow("CompDetDes") = "Totales de Cuenta " & MonedaDesFind(mlngMonedaId)

      Else
         oRow("CompDetDes") = "Totales "
      End If

      If mboolIncluirDetalle Then
         oRow("DebeBs") = mdecDebePlanBs
         oRow("HaberBs") = mdecHaberPlanBs
         oRow("SaldoBs") = mdecSaldoPlanBs

         oRow("DebeUs") = mdecDebePlanUs
         oRow("HaberUs") = mdecHaberPlanUs
         oRow("SaldoUs") = mdecSaldoPlanUs
      Else
         oRow("SaldoBs") = mdecSaldoPlanBs
         oRow("SaldoUs") = mdecSaldoPlanUs
      End If

      Return oRow
   End Function

   Private Function GetRowNull() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      Return oRow
   End Function
#End Region

#Region " Grid-LibroPlanAddAna "
   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Movimiento de Anal?ticos Adicionales"

         .RootTable.Columns("CompDetId").Visible = False

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("PlanId").Visible = False

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
         .RootTable.Columns("CompDetDes").Width = 200
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

            'ElseIf mlngMonedaId = 3 Then
            '   .RootTable.Columns("TipoCambio").Caption = "T.C."
            '   .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
            '   .RootTable.Columns("TipoCambio").Width = 80
            '   .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '   .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            '   .RootTable.Columns("DebeBs").Caption = "Debe Bs."
            '   .RootTable.Columns("DebeBs").FormatString = DecimalMask()
            '   .RootTable.Columns("DebeBs").Width = 80
            '   .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '   .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            '   .RootTable.Columns("HaberBs").Caption = "Haber Bs."
            '   .RootTable.Columns("HaberBs").FormatString = DecimalMask()
            '   .RootTable.Columns("HaberBs").Width = 80
            '   .RootTable.Columns("HaberBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '   .RootTable.Columns("HaberBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            '   .RootTable.Columns("SaldoBs").Caption = "Saldo Bs."
            '   .RootTable.Columns("SaldoBs").FormatString = DecimalMask()
            '   .RootTable.Columns("SaldoBs").Width = 80
            '   .RootTable.Columns("SaldoBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '   .RootTable.Columns("SaldoBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            '   .RootTable.Columns("DebeUs").Caption = "Debe Us."
            '   .RootTable.Columns("DebeUs").FormatString = DecimalMask()
            '   .RootTable.Columns("DebeUs").Width = 80
            '   .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '   .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            '   .RootTable.Columns("HaberUs").Caption = "Haber Us."
            '   .RootTable.Columns("HaberUs").FormatString = DecimalMask()
            '   .RootTable.Columns("HaberUs").Width = 80
            '   .RootTable.Columns("HaberUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '   .RootTable.Columns("HaberUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            '   .RootTable.Columns("SaldoUs").Caption = "Saldo Us."
            '   .RootTable.Columns("SaldoUs").FormatString = DecimalMask()
            '   .RootTable.Columns("SaldoUs").Width = 80
            '   .RootTable.Columns("SaldoUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            '   .RootTable.Columns("SaldoUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

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
      Dim oRow As DataRow
      Dim intRow As Integer
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)

      'Dim decSaldo As Decimal
      Dim decPlanAddBs As Decimal
      Dim decPlanAddUs As Decimal
      Dim boolTieneMov As Boolean

      Try
         Call moDataSetInit()
         mstrTipoAsientoId = TipoAsientoIdListaLoad()

         If ConMovimiento(mlngPlanId) Then
            mdecSaldoPlanBs = 0
            mdecDebePlanBs = 0
            mdecHaberPlanBs = 0

            mdecSaldoPlanUs = 0
            mdecDebePlanUs = 0
            mdecHaberPlanUs = 0

            mlngGrupo = PlanGrupoFind(mlngPlanId)

            moDataTable.Rows.Add(GetHeader(mlngPlanId))

            For Each lngPlanAddId As Long In moLista
               With oPlanAdd
                  .PlanAddId = lngPlanAddId

                  If .FindByPK Then
                     If mboolSaldoAnterior Then
                        mdecSaldoPlanAddBs = PlanSaldoAnteriorBs(.PlanId, .PlanAddId, mdecSaldoPlanAddUs)
                     Else
                        mdecSaldoPlanAddBs = 0
                        mdecSaldoPlanAddUs = 0
                     End If

                     If Not mboolSaldoCero Then
                        decPlanAddBs = SaldoPlanAddBs(.PlanId, .PlanAddId, decPlanAddUs, boolTieneMov)

                        'If mlngMonedaId = 1 Then
                        '   decSaldo = decPlanAddBs
                        'Else
                        '   decSaldo = decPlanAddUs
                        'End If

                        Dim boolMovimiento As Boolean = False

                        If mlngMonedaId = clsMoneda.BOLIVIANOS Then
                           boolMovimiento = (decPlanAddBs + mdecSaldoPlanAddBs) <> 0
                        ElseIf mlngMonedaId = clsMoneda.DOLARES Then
                           boolMovimiento = (decPlanAddUs + mdecSaldoPlanAddUs) <> 0
                        ElseIf mlngMonedaId = 4 Then
                           boolMovimiento = ((decPlanAddBs + mdecSaldoPlanAddBs) <> 0) Or ((decPlanAddUs + mdecSaldoPlanAddUs) <> 0)
                        End If

                        If boolMovimiento Then
                           'If Math.Abs(decSaldo) >= 0.01 Then
                           moDataTable.Rows.Add(GetHeaderPlanAdd(.PlanAddCta, .PlanAddDes, .PlanId, .PlanAddId, mlngMonedaId))

                           If mboolIncluirDetalle Then
                              With moCompPlanAdd
                                 If mboolCuenta Then
                                    .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuenta
                                 Else
                                    .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorGeneral
                                 End If

                                 If mboolIntervaloFecha Then
                                    .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayorFecha
                                    .Fecha = mstrFechaIni
                                    .LastUpdateId = mstrFechaFin
                                 Else
                                    .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayor
                                 End If

                                 .OrderByFilter = clsCompPlanAdd.OrderByFilters.LibroMayor
                                 .EmpresaId = mlngEmpresaId
                                 .GestionId = mlngGestionId
                                 .PlanId = mlngPlanId
                                 .PlanAddId = oPlanAdd.PlanAddId
                                 .CompId = mlngCentroCostoId 'CentroCostoId
                                 .MonedaId = ToBoolean(mboolSinFac) 'SinFac
                                 .EstadoId = ToBoolean(mboolConFac) 'ConFac
                                 .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
                                 intRow = 0
                                 mdecSaldoBs = mdecSaldoPlanAddBs
                                 mdecDebeBs = 0
                                 mdecHaberBs = 0

                                 mdecSaldoUs = mdecSaldoPlanAddUs
                                 mdecDebeUs = 0
                                 mdecHaberUs = 0

                                 If .Open() Then
                                    Do While intRow < .DataSet.Tables(.TableName).Rows.Count
                                       moDataTable.Rows.Add(GetRow(.DataSet.Tables(.TableName).Rows(intRow), mlngMonedaId))

                                       intRow += 1
                                    Loop

                                    moDataTable.Rows.Add(GetFooterPlanAdd(oPlanAdd.PlanAddDes))
                                    moDataTable.Rows.Add(GetRowNull)
                                 End If
                              End With
                           End If

                           mdecSaldoPlanBs = mdecSaldoPlanBs + mdecSaldoBs
                           mdecSaldoPlanUs = mdecSaldoPlanUs + mdecSaldoUs
                        End If

                     Else
                        decPlanAddBs = SaldoPlanAddBs(.PlanId, .PlanAddId, decPlanAddUs, boolTieneMov)

                        If boolTieneMov Then
                           moDataTable.Rows.Add(GetHeaderPlanAdd(.PlanAddCta, .PlanAddDes, .PlanId, .PlanAddId, mlngMonedaId))

                           If mboolIncluirDetalle Then
                              With moCompPlanAdd
                                 If mboolCuenta Then
                                    .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuenta
                                 Else
                                    .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorGeneral
                                 End If

                                 If mboolIntervaloFecha Then
                                    .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayorFecha
                                    .Fecha = mstrFechaIni
                                    .LastUpdateId = mstrFechaFin
                                 Else
                                    .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayor
                                 End If

                                 .OrderByFilter = clsCompPlanAdd.OrderByFilters.LibroMayor
                                 .EmpresaId = mlngEmpresaId
                                 .GestionId = mlngGestionId
                                 .PlanId = mlngPlanId
                                 .PlanAddId = oPlanAdd.PlanAddId
                                 .CompId = mlngCentroCostoId 'CentroCostoId
                                 .MonedaId = ToBoolean(mboolSinFac) 'SinFac
                                 .EstadoId = ToBoolean(mboolConFac) 'ConFac
                                 .LastUpdateDate = mstrTipoAsientoId 'Lista TipoCuentaId
                                 intRow = 0
                                 mdecSaldoBs = mdecSaldoPlanAddBs
                                 mdecDebeBs = 0
                                 mdecHaberBs = 0

                                 mdecSaldoUs = mdecSaldoPlanAddUs
                                 mdecDebeUs = 0
                                 mdecHaberUs = 0

                                 If .Open() Then
                                    Do While intRow < .DataSet.Tables(.TableName).Rows.Count
                                       moDataTable.Rows.Add(GetRow(.DataSet.Tables(.TableName).Rows(intRow), mlngMonedaId))

                                       intRow += 1
                                    Loop

                                    moDataTable.Rows.Add(GetFooterPlanAdd(oPlanAdd.PlanAddDes))
                                    moDataTable.Rows.Add(GetRowNull)
                                 End If
                              End With
                           End If

                           mdecSaldoPlanBs = mdecSaldoPlanBs + mdecSaldoBs
                           mdecSaldoPlanUs = mdecSaldoPlanUs + mdecSaldoUs
                        End If
                     End If
                  End If
               End With
            Next

            moDataTable.Rows.Add(GetFooter(mlngPlanId))
            moDataTable.Rows.Add(GetRowNull)
         End If

         grdMain.DataSource = moDataSet.Tables(moCompPlanAdd.TableName).DefaultView
         grdMain.RetrieveStructure()
         Call grdMainInit()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanAdd.Dispose()

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
#End Region
#End Region

End Class
