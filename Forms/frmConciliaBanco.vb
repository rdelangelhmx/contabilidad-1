Public Class frmConciliaBanco
   Inherits System.Windows.Forms.Form

   Private moCompDet As clsCompDet
   Private moLista As New Queue
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngPlanId As Long
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

   Private mdecHaberBs As Decimal
   Private mdecDebeBs As Decimal
   Private mdecSaldoBs As Decimal
   Private mdecHaberUs As Decimal
   Private mdecDebeUs As Decimal
   Private mdecSaldoUs As Decimal
   Private mlngGrupo As Long

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mlstConciliados As New Hashtable

   Private mboolChanged As Boolean
   Private mboolSelected As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox7 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label99 As System.Windows.Forms.Label
   Friend WithEvents txtDebitoCon As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtCreditoSinC As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label100 As System.Windows.Forms.Label
   Friend WithEvents Label96 As System.Windows.Forms.Label
   Friend WithEvents txtCreditoCon As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtDebitoSinC As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label97 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox5 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtDiferenciaSinC As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtMontoDif As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label35 As System.Windows.Forms.Label
   Friend WithEvents txtDiferenciaCon As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtExtracto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label41 As System.Windows.Forms.Label
   Friend WithEvents txtResultado As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtSaldo As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtSaldoIni As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtHaber As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents txtDebe As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtSaldoOrg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Cheque As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents txtBancoCta As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Documento1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents UiGroupBox6 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents btnSaveCheque As Janus.Windows.EditControls.UIButton
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents CheckConciliaCheque As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents txtChequeNro As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents UnCheckConciliaCheque As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckConciliaCheque1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UnCheckConciliaCheque1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator10 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ConciliaDiferencia1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ConciliaDiferencia As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print21 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator11 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print2 As Janus.Windows.UI.CommandBars.UICommand
   Private mlngID As Long

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

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
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

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   ReadOnly Property Selected() As Boolean
      Get
         Return mboolSelected
      End Get
   End Property

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
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
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConciliaBanco))
      Dim ExplorerBarGroup5 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label99 = New System.Windows.Forms.Label
      Me.txtCreditoCon = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label96 = New System.Windows.Forms.Label
      Me.txtDebitoCon = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtDiferenciaCon = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox6 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtChequeNro = New Janus.Windows.GridEX.EditControls.EditBox
      Me.btnSaveCheque = New Janus.Windows.EditControls.UIButton
      Me.Label8 = New System.Windows.Forms.Label
      Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtResultado = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.UiGroupBox5 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtMontoDif = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label35 = New System.Windows.Forms.Label
      Me.txtExtracto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label41 = New System.Windows.Forms.Label
      Me.txtSaldo = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label22 = New System.Windows.Forms.Label
      Me.UiGroupBox7 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtDiferenciaSinC = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtCreditoSinC = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtDebitoSinC = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label97 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label100 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtBancoCta = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtSaldoIni = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Documento1 = New Janus.Windows.UI.CommandBars.UICommand("Cheque")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckConciliaCheque1 = New Janus.Windows.UI.CommandBars.UICommand("CheckConciliaCheque")
      Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.UnCheckConciliaCheque1 = New Janus.Windows.UI.CommandBars.UICommand("UnCheckConciliaCheque")
      Me.Separator10 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ConciliaDiferencia1 = New Janus.Windows.UI.CommandBars.UICommand("ConciliaDiferencia")
      Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Cheque = New Janus.Windows.UI.CommandBars.UICommand("Cheque")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.CheckConciliaCheque = New Janus.Windows.UI.CommandBars.UICommand("CheckConciliaCheque")
      Me.UnCheckConciliaCheque = New Janus.Windows.UI.CommandBars.UICommand("UnCheckConciliaCheque")
      Me.ConciliaDiferencia = New Janus.Windows.UI.CommandBars.UICommand("ConciliaDiferencia")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtSaldoOrg = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtHaber = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.txtDebe = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print2 = New Janus.Windows.UI.CommandBars.UICommand("Print2")
      Me.Print21 = New Janus.Windows.UI.CommandBars.UICommand("Print2")
      Me.Separator11 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox6.SuspendLayout()
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox4.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox5.SuspendLayout()
      CType(Me.UiGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox7.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(926, 195)
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
      Me.grdMain.Size = New System.Drawing.Size(926, 195)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox1.Controls.Add(Me.Label99)
      Me.UiGroupBox1.Controls.Add(Me.txtCreditoCon)
      Me.UiGroupBox1.Controls.Add(Me.Label96)
      Me.UiGroupBox1.Controls.Add(Me.txtDebitoCon)
      Me.UiGroupBox1.Controls.Add(Me.txtDiferenciaCon)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.FormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox1.FormatStyle.ForeColor = System.Drawing.Color.Maroon
      Me.UiGroupBox1.Location = New System.Drawing.Point(342, 337)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(184, 96)
      Me.UiGroupBox1.TabIndex = 292
      Me.UiGroupBox1.Text = "Libro Conciliados"
      Me.UiGroupBox1.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label99
      '
      Me.Label99.BackColor = System.Drawing.Color.Transparent
      Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label99.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label99.Location = New System.Drawing.Point(8, 48)
      Me.Label99.Name = "Label99"
      Me.Label99.Size = New System.Drawing.Size(68, 16)
      Me.Label99.TabIndex = 290
      Me.Label99.Text = "Débito (-)"
      '
      'txtCreditoCon
      '
      Me.txtCreditoCon.AccessibleDescription = ""
      Me.txtCreditoCon.BackColor = System.Drawing.SystemColors.Info
      Me.txtCreditoCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCreditoCon.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCreditoCon.FormatString = "##,##0.000"
      Me.txtCreditoCon.Location = New System.Drawing.Point(84, 20)
      Me.txtCreditoCon.Name = "txtCreditoCon"
      Me.txtCreditoCon.ReadOnly = True
      Me.txtCreditoCon.Size = New System.Drawing.Size(92, 20)
      Me.txtCreditoCon.TabIndex = 71
      Me.txtCreditoCon.Text = "0.000"
      Me.txtCreditoCon.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCreditoCon.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCreditoCon.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label96
      '
      Me.Label96.BackColor = System.Drawing.Color.Transparent
      Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label96.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label96.Location = New System.Drawing.Point(8, 24)
      Me.Label96.Name = "Label96"
      Me.Label96.Size = New System.Drawing.Size(68, 16)
      Me.Label96.TabIndex = 266
      Me.Label96.Text = "Crédito (+)"
      '
      'txtDebitoCon
      '
      Me.txtDebitoCon.BackColor = System.Drawing.SystemColors.Info
      Me.txtDebitoCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDebitoCon.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDebitoCon.FormatString = "##,##0.000"
      Me.txtDebitoCon.Location = New System.Drawing.Point(84, 44)
      Me.txtDebitoCon.Name = "txtDebitoCon"
      Me.txtDebitoCon.ReadOnly = True
      Me.txtDebitoCon.Size = New System.Drawing.Size(92, 20)
      Me.txtDebitoCon.TabIndex = 73
      Me.txtDebitoCon.Text = "0.000"
      Me.txtDebitoCon.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDebitoCon.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDebitoCon.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtDiferenciaCon
      '
      Me.txtDiferenciaCon.BackColor = System.Drawing.Color.MistyRose
      Me.txtDiferenciaCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDiferenciaCon.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDiferenciaCon.FormatString = "##,##0.000"
      Me.txtDiferenciaCon.Location = New System.Drawing.Point(84, 68)
      Me.txtDiferenciaCon.Name = "txtDiferenciaCon"
      Me.txtDiferenciaCon.ReadOnly = True
      Me.txtDiferenciaCon.Size = New System.Drawing.Size(92, 20)
      Me.txtDiferenciaCon.TabIndex = 63
      Me.txtDiferenciaCon.Text = "0.000"
      Me.txtDiferenciaCon.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDiferenciaCon.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDiferenciaCon.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 72)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(78, 16)
      Me.Label4.TabIndex = 292
      Me.Label4.Text = "Diferencia"
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.UiGroupBox6)
      Me.uiBackground.Controls.Add(Me.UiGroupBox4)
      Me.uiBackground.Controls.Add(Me.UiGroupBox2)
      Me.uiBackground.Controls.Add(Me.UiGroupBox1)
      Me.uiBackground.Controls.Add(Me.UiGroupBox5)
      Me.uiBackground.Controls.Add(Me.UiGroupBox7)
      Me.uiBackground.Controls.Add(Me.grpMain)
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(950, 435)
      Me.uiBackground.TabIndex = 9
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox6
      '
      Me.UiGroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox6.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox6.Controls.Add(Me.txtChequeNro)
      Me.UiGroupBox6.Controls.Add(Me.btnSaveCheque)
      Me.UiGroupBox6.Controls.Add(Me.Label8)
      Me.UiGroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox6.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox6.Location = New System.Drawing.Point(772, 0)
      Me.UiGroupBox6.Name = "UiGroupBox6"
      Me.UiGroupBox6.Size = New System.Drawing.Size(176, 64)
      Me.UiGroupBox6.TabIndex = 294
      Me.UiGroupBox6.Text = "Conciliar Cheque"
      Me.UiGroupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtChequeNro
      '
      Me.txtChequeNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtChequeNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeNro.Location = New System.Drawing.Point(8, 36)
      Me.txtChequeNro.MaxLength = 50
      Me.txtChequeNro.Name = "txtChequeNro"
      Me.txtChequeNro.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeNro.TabIndex = 0
      Me.txtChequeNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'btnSaveCheque
      '
      Me.btnSaveCheque.ActiveFormatStyle.ForeColor = System.Drawing.Color.White
      Me.btnSaveCheque.FlatBorderColor = System.Drawing.SystemColors.ControlDark
      Me.btnSaveCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSaveCheque.Location = New System.Drawing.Point(136, 36)
      Me.btnSaveCheque.Name = "btnSaveCheque"
      Me.btnSaveCheque.Size = New System.Drawing.Size(32, 20)
      Me.btnSaveCheque.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnSaveCheque.TabIndex = 1
      Me.btnSaveCheque.Text = "..."
      Me.btnSaveCheque.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 18)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(80, 16)
      Me.Label8.TabIndex = 213
      Me.Label8.Text = "Nro. Cheque"
      '
      'UiGroupBox4
      '
      Me.UiGroupBox4.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox4.Controls.Add(Me.Label12)
      Me.UiGroupBox4.Controls.Add(Me.Label16)
      Me.UiGroupBox4.Controls.Add(Me.dtpFechaFin)
      Me.UiGroupBox4.Controls.Add(Me.dtpFechaIni)
      Me.UiGroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox4.Location = New System.Drawing.Point(4, 0)
      Me.UiGroupBox4.Name = "UiGroupBox4"
      Me.UiGroupBox4.Size = New System.Drawing.Size(164, 64)
      Me.UiGroupBox4.TabIndex = 212
      Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 16)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(40, 16)
      Me.Label12.TabIndex = 205
      Me.Label12.Text = "Inicio"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(8, 40)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(40, 16)
      Me.Label16.TabIndex = 195
      Me.Label16.Text = "Final"
      '
      'dtpFechaFin
      '
      Me.dtpFechaFin.BackColor = System.Drawing.SystemColors.Info
      Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaFin.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaFin.DropDownCalendar.Name = ""
      Me.dtpFechaFin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaFin.Location = New System.Drawing.Point(52, 36)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.ReadOnly = True
      Me.dtpFechaFin.Size = New System.Drawing.Size(100, 20)
      Me.dtpFechaFin.TabIndex = 3
      Me.dtpFechaFin.Value = New Date(2015, 12, 3, 0, 0, 0, 0)
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'dtpFechaIni
      '
      Me.dtpFechaIni.BackColor = System.Drawing.SystemColors.Info
      Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaIni.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaIni.DropDownCalendar.Name = ""
      Me.dtpFechaIni.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaIni.Location = New System.Drawing.Point(52, 12)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.ReadOnly = True
      Me.dtpFechaIni.Size = New System.Drawing.Size(100, 20)
      Me.dtpFechaIni.TabIndex = 2
      Me.dtpFechaIni.Value = New Date(2015, 12, 3, 0, 0, 0, 0)
      Me.dtpFechaIni.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.Label5)
      Me.UiGroupBox2.Controls.Add(Me.Label7)
      Me.UiGroupBox2.Controls.Add(Me.txtResultado)
      Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(0, 338)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(334, 92)
      Me.UiGroupBox2.TabIndex = 11
      Me.UiGroupBox2.Visible = False
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label5.Location = New System.Drawing.Point(12, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(112, 16)
      Me.Label5.TabIndex = 290
      Me.Label5.Text = "Resultado"
      '
      'Label7
      '
      Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(442, 20)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(88, 16)
      Me.Label7.TabIndex = 200
      Me.Label7.Text = "Total Importe"
      '
      'txtResultado
      '
      Me.txtResultado.BackColor = System.Drawing.SystemColors.Info
      Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtResultado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtResultado.FormatString = "##,##0.000"
      Me.txtResultado.Location = New System.Drawing.Point(12, 64)
      Me.txtResultado.Name = "txtResultado"
      Me.txtResultado.ReadOnly = True
      Me.txtResultado.Size = New System.Drawing.Size(116, 20)
      Me.txtResultado.TabIndex = 61
      Me.txtResultado.Text = "0.000"
      Me.txtResultado.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtResultado.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtResultado.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'UiGroupBox5
      '
      Me.UiGroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox5.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox5.Controls.Add(Me.txtMontoDif)
      Me.UiGroupBox5.Controls.Add(Me.Label35)
      Me.UiGroupBox5.Controls.Add(Me.txtExtracto)
      Me.UiGroupBox5.Controls.Add(Me.Label41)
      Me.UiGroupBox5.Controls.Add(Me.txtSaldo)
      Me.UiGroupBox5.Controls.Add(Me.Label22)
      Me.UiGroupBox5.FormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox5.FormatStyle.ForeColor = System.Drawing.Color.Maroon
      Me.UiGroupBox5.Location = New System.Drawing.Point(734, 337)
      Me.UiGroupBox5.Name = "UiGroupBox5"
      Me.UiGroupBox5.Size = New System.Drawing.Size(208, 96)
      Me.UiGroupBox5.TabIndex = 71
      Me.UiGroupBox5.Text = "Diferencias"
      Me.UiGroupBox5.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
      Me.UiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtMontoDif
      '
      Me.txtMontoDif.BackColor = System.Drawing.Color.MistyRose
      Me.txtMontoDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoDif.FormatString = "##,##0.000"
      Me.txtMontoDif.Location = New System.Drawing.Point(100, 68)
      Me.txtMontoDif.Name = "txtMontoDif"
      Me.txtMontoDif.ReadOnly = True
      Me.txtMontoDif.Size = New System.Drawing.Size(100, 20)
      Me.txtMontoDif.TabIndex = 66
      Me.txtMontoDif.Text = "0.000"
      Me.txtMontoDif.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoDif.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoDif.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label35
      '
      Me.Label35.BackColor = System.Drawing.Color.Transparent
      Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label35.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label35.Location = New System.Drawing.Point(4, 72)
      Me.Label35.Name = "Label35"
      Me.Label35.Size = New System.Drawing.Size(92, 16)
      Me.Label35.TabIndex = 270
      Me.Label35.Text = "Diferencia"
      '
      'txtExtracto
      '
      Me.txtExtracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtExtracto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtExtracto.FormatString = "##,##0.000"
      Me.txtExtracto.Location = New System.Drawing.Point(100, 44)
      Me.txtExtracto.Name = "txtExtracto"
      Me.txtExtracto.Size = New System.Drawing.Size(100, 20)
      Me.txtExtracto.TabIndex = 62
      Me.txtExtracto.Text = "0.000"
      Me.txtExtracto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtExtracto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtExtracto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label41
      '
      Me.Label41.BackColor = System.Drawing.Color.Transparent
      Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label41.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label41.Location = New System.Drawing.Point(4, 48)
      Me.Label41.Name = "Label41"
      Me.Label41.Size = New System.Drawing.Size(92, 16)
      Me.Label41.TabIndex = 245
      Me.Label41.Text = "Saldo Extracto"
      '
      'txtSaldo
      '
      Me.txtSaldo.BackColor = System.Drawing.SystemColors.Info
      Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSaldo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSaldo.FormatString = "##,##0.000"
      Me.txtSaldo.Location = New System.Drawing.Point(100, 20)
      Me.txtSaldo.Name = "txtSaldo"
      Me.txtSaldo.ReadOnly = True
      Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
      Me.txtSaldo.TabIndex = 60
      Me.txtSaldo.Text = "0.000"
      Me.txtSaldo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtSaldo.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtSaldo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label22.Location = New System.Drawing.Point(4, 24)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(92, 16)
      Me.Label22.TabIndex = 241
      Me.Label22.Text = "Saldo Libro"
      '
      'UiGroupBox7
      '
      Me.UiGroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox7.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox7.Controls.Add(Me.txtDiferenciaSinC)
      Me.UiGroupBox7.Controls.Add(Me.txtCreditoSinC)
      Me.UiGroupBox7.Controls.Add(Me.txtDebitoSinC)
      Me.UiGroupBox7.Controls.Add(Me.Label97)
      Me.UiGroupBox7.Controls.Add(Me.Label3)
      Me.UiGroupBox7.Controls.Add(Me.Label100)
      Me.UiGroupBox7.FormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox7.FormatStyle.ForeColor = System.Drawing.Color.Maroon
      Me.UiGroupBox7.Location = New System.Drawing.Point(530, 337)
      Me.UiGroupBox7.Name = "UiGroupBox7"
      Me.UiGroupBox7.Size = New System.Drawing.Size(200, 96)
      Me.UiGroupBox7.TabIndex = 70
      Me.UiGroupBox7.Text = "Libro por Conciliar"
      Me.UiGroupBox7.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
      Me.UiGroupBox7.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtDiferenciaSinC
      '
      Me.txtDiferenciaSinC.BackColor = System.Drawing.Color.MistyRose
      Me.txtDiferenciaSinC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDiferenciaSinC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDiferenciaSinC.FormatString = "##,##0.000"
      Me.txtDiferenciaSinC.Location = New System.Drawing.Point(96, 68)
      Me.txtDiferenciaSinC.Name = "txtDiferenciaSinC"
      Me.txtDiferenciaSinC.ReadOnly = True
      Me.txtDiferenciaSinC.Size = New System.Drawing.Size(96, 20)
      Me.txtDiferenciaSinC.TabIndex = 67
      Me.txtDiferenciaSinC.Text = "0.000"
      Me.txtDiferenciaSinC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDiferenciaSinC.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDiferenciaSinC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCreditoSinC
      '
      Me.txtCreditoSinC.BackColor = System.Drawing.SystemColors.Info
      Me.txtCreditoSinC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCreditoSinC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCreditoSinC.FormatString = "##,##0.000"
      Me.txtCreditoSinC.Location = New System.Drawing.Point(96, 20)
      Me.txtCreditoSinC.Name = "txtCreditoSinC"
      Me.txtCreditoSinC.ReadOnly = True
      Me.txtCreditoSinC.Size = New System.Drawing.Size(96, 20)
      Me.txtCreditoSinC.TabIndex = 72
      Me.txtCreditoSinC.Text = "0.000"
      Me.txtCreditoSinC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCreditoSinC.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtCreditoSinC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtDebitoSinC
      '
      Me.txtDebitoSinC.BackColor = System.Drawing.SystemColors.Info
      Me.txtDebitoSinC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDebitoSinC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDebitoSinC.FormatString = "##,##0.000"
      Me.txtDebitoSinC.Location = New System.Drawing.Point(96, 44)
      Me.txtDebitoSinC.Name = "txtDebitoSinC"
      Me.txtDebitoSinC.ReadOnly = True
      Me.txtDebitoSinC.Size = New System.Drawing.Size(96, 20)
      Me.txtDebitoSinC.TabIndex = 70
      Me.txtDebitoSinC.Text = "0.000"
      Me.txtDebitoSinC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDebitoSinC.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDebitoSinC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label97
      '
      Me.Label97.BackColor = System.Drawing.Color.Transparent
      Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label97.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label97.Location = New System.Drawing.Point(8, 24)
      Me.Label97.Name = "Label97"
      Me.Label97.Size = New System.Drawing.Size(92, 16)
      Me.Label97.TabIndex = 265
      Me.Label97.Text = "Crédito (+)"
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(8, 72)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(90, 16)
      Me.Label3.TabIndex = 291
      Me.Label3.Text = "Diferencia"
      '
      'Label100
      '
      Me.Label100.BackColor = System.Drawing.Color.Transparent
      Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label100.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label100.Location = New System.Drawing.Point(8, 48)
      Me.Label100.Name = "Label100"
      Me.Label100.Size = New System.Drawing.Size(92, 16)
      Me.Label100.TabIndex = 289
      Me.Label100.Text = "Débito (-)"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtBancoCta)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.txtSaldoIni)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.cboPlan)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(172, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(592, 64)
      Me.grpMain.TabIndex = 2
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtBancoCta
      '
      Me.txtBancoCta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtBancoCta.Location = New System.Drawing.Point(84, 36)
      Me.txtBancoCta.MaxLength = 50
      Me.txtBancoCta.Name = "txtBancoCta"
      Me.txtBancoCta.ReadOnly = True
      Me.txtBancoCta.Size = New System.Drawing.Size(124, 20)
      Me.txtBancoCta.TabIndex = 210
      Me.txtBancoCta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtBancoCta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 40)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(76, 16)
      Me.Label6.TabIndex = 211
      Me.Label6.Text = "Nro. Cuenta"
      '
      'txtSaldoIni
      '
      Me.txtSaldoIni.BackColor = System.Drawing.SystemColors.Info
      Me.txtSaldoIni.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSaldoIni.FormatString = "##,##0.000"
      Me.txtSaldoIni.Location = New System.Drawing.Point(484, 36)
      Me.txtSaldoIni.Name = "txtSaldoIni"
      Me.txtSaldoIni.ReadOnly = True
      Me.txtSaldoIni.Size = New System.Drawing.Size(100, 20)
      Me.txtSaldoIni.TabIndex = 208
      Me.txtSaldoIni.Text = "0.000"
      Me.txtSaldoIni.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtSaldoIni.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtSaldoIni.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(416, 40)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(68, 16)
      Me.Label2.TabIndex = 209
      Me.Label2.Text = "Saldo Ini."
      '
      'cboPlan
      '
      Me.cboPlan.BackColor = System.Drawing.SystemColors.Info
      cboPlan_DesignTimeLayout.LayoutString = resources.GetString("cboPlan_DesignTimeLayout.LayoutString")
      Me.cboPlan.DesignTimeLayout = cboPlan_DesignTimeLayout
      Me.cboPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlan.Location = New System.Drawing.Point(84, 12)
      Me.cboPlan.Name = "cboPlan"
      Me.cboPlan.ReadOnly = True
      Me.cboPlan.SelectedIndex = -1
      Me.cboPlan.SelectedItem = Nothing
      Me.cboPlan.Size = New System.Drawing.Size(320, 20)
      Me.cboPlan.TabIndex = 206
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(72, 16)
      Me.Label1.TabIndex = 207
      Me.Label1.Text = "Cuenta"
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(484, 12)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.ReadOnly = True
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
      Me.cboMoneda.TabIndex = 5
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(428, 16)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(52, 16)
      Me.Label15.TabIndex = 196
      Me.Label15.Text = "Moneda"
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup5.Container = True
      ExplorerBarGroup5.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup5.ContainerHeight = 196
      ExplorerBarGroup5.Expandable = False
      ExplorerBarGroup5.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup5})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 68)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(942, 228)
      Me.ebrMain.TabIndex = 1
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(60, 12)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
      Me.txtTipoCambio.TabIndex = 6
      Me.txtTipoCambio.Text = "0.000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.Visible = False
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(16, 16)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(40, 16)
      Me.Label11.TabIndex = 199
      Me.Label11.Text = "T. C."
      Me.Label11.Visible = False
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
      Me.ilsMain.Images.SetKeyName(7, "actualizar.ico")
      Me.ilsMain.Images.SetKeyName(8, "Save.ico")
      Me.ilsMain.Images.SetKeyName(9, "check.ico")
      Me.ilsMain.Images.SetKeyName(10, "UnCheck.bmp")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.ViewAll, Me.Print, Me.Exit2, Me.Refrescar, Me.Cheque, Me.Save, Me.CheckConciliaCheque, Me.UnCheckConciliaCheque, Me.ConciliaDiferencia, Me.Print2})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.Documento1, Me.Separator5, Me.Save1, Me.Separator6, Me.CheckConciliaCheque1, Me.Separator8, Me.UnCheckConciliaCheque1, Me.Separator10, Me.ConciliaDiferencia1, Me.Separator9, Me.Refrescar1, Me.Separator4, Me.ViewAll1, Me.Separator2, Me.Print1, Me.Separator3, Me.Print21, Me.Separator11, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(950, 28)
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
      'Documento1
      '
      Me.Documento1.Key = "Cheque"
      Me.Documento1.Name = "Documento1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'CheckConciliaCheque1
      '
      Me.CheckConciliaCheque1.Key = "CheckConciliaCheque"
      Me.CheckConciliaCheque1.Name = "CheckConciliaCheque1"
      '
      'Separator8
      '
      Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator8.Key = "Separator"
      Me.Separator8.Name = "Separator8"
      '
      'UnCheckConciliaCheque1
      '
      Me.UnCheckConciliaCheque1.Key = "UnCheckConciliaCheque"
      Me.UnCheckConciliaCheque1.Name = "UnCheckConciliaCheque1"
      '
      'Separator10
      '
      Me.Separator10.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator10.Key = "Separator"
      Me.Separator10.Name = "Separator10"
      '
      'ConciliaDiferencia1
      '
      Me.ConciliaDiferencia1.Key = "ConciliaDiferencia"
      Me.ConciliaDiferencia1.Name = "ConciliaDiferencia1"
      '
      'Separator9
      '
      Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator9.Key = "Separator"
      Me.Separator9.Name = "Separator9"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
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
      Me.Print.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 7
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
      '
      'Cheque
      '
      Me.Cheque.ImageIndex = 1
      Me.Cheque.Key = "Cheque"
      Me.Cheque.Name = "Cheque"
      Me.Cheque.Text = "Cheque"
      '
      'Save
      '
      Me.Save.ImageIndex = 8
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.Text = "Guardar"
      '
      'CheckConciliaCheque
      '
      Me.CheckConciliaCheque.ImageIndex = 9
      Me.CheckConciliaCheque.Key = "CheckConciliaCheque"
      Me.CheckConciliaCheque.Name = "CheckConciliaCheque"
      Me.CheckConciliaCheque.Text = "Cheques Cobrados"
      Me.CheckConciliaCheque.ToolTipText = "Conciliar Cheques Cobrados"
      '
      'UnCheckConciliaCheque
      '
      Me.UnCheckConciliaCheque.ImageIndex = 10
      Me.UnCheckConciliaCheque.Key = "UnCheckConciliaCheque"
      Me.UnCheckConciliaCheque.Name = "UnCheckConciliaCheque"
      Me.UnCheckConciliaCheque.Text = "Cheques Pendientes"
      Me.UnCheckConciliaCheque.ToolTipText = "Quitar Concilliacion de Cheques Pendientes"
      '
      'ConciliaDiferencia
      '
      Me.ConciliaDiferencia.ImageIndex = 0
      Me.ConciliaDiferencia.Key = "ConciliaDiferencia"
      Me.ConciliaDiferencia.Name = "ConciliaDiferencia"
      Me.ConciliaDiferencia.Text = "Conciliar Diferencia"
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
      Me.TopRebar1.Size = New System.Drawing.Size(950, 28)
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.txtSaldoOrg)
      Me.UiGroupBox3.Controls.Add(Me.txtHaber)
      Me.UiGroupBox3.Controls.Add(Me.Label14)
      Me.UiGroupBox3.Controls.Add(Me.txtDebe)
      Me.UiGroupBox3.Controls.Add(Me.Label10)
      Me.UiGroupBox3.Controls.Add(Me.Label17)
      Me.UiGroupBox3.Controls.Add(Me.Label11)
      Me.UiGroupBox3.Controls.Add(Me.txtTipoCambio)
      Me.UiGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(4, 324)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(942, 36)
      Me.UiGroupBox3.TabIndex = 10
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtSaldoOrg
      '
      Me.txtSaldoOrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtSaldoOrg.BackColor = System.Drawing.SystemColors.Info
      Me.txtSaldoOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtSaldoOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSaldoOrg.FormatString = "##,##0.000"
      Me.txtSaldoOrg.Location = New System.Drawing.Point(830, 12)
      Me.txtSaldoOrg.Name = "txtSaldoOrg"
      Me.txtSaldoOrg.ReadOnly = True
      Me.txtSaldoOrg.Size = New System.Drawing.Size(100, 20)
      Me.txtSaldoOrg.TabIndex = 242
      Me.txtSaldoOrg.Text = "0.000"
      Me.txtSaldoOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtSaldoOrg.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtSaldoOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtHaber
      '
      Me.txtHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtHaber.BackColor = System.Drawing.SystemColors.Info
      Me.txtHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtHaber.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtHaber.FormatString = "##,##0.000"
      Me.txtHaber.Location = New System.Drawing.Point(610, 12)
      Me.txtHaber.Name = "txtHaber"
      Me.txtHaber.ReadOnly = True
      Me.txtHaber.Size = New System.Drawing.Size(100, 20)
      Me.txtHaber.TabIndex = 9
      Me.txtHaber.Text = "0.000"
      Me.txtHaber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtHaber.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtHaber.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(546, 16)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(60, 16)
      Me.Label14.TabIndex = 241
      Me.Label14.Text = "Totales"
      '
      'txtDebe
      '
      Me.txtDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtDebe.BackColor = System.Drawing.SystemColors.Info
      Me.txtDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDebe.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDebe.FormatString = "##,##0.000"
      Me.txtDebe.Location = New System.Drawing.Point(718, 12)
      Me.txtDebe.Name = "txtDebe"
      Me.txtDebe.ReadOnly = True
      Me.txtDebe.Size = New System.Drawing.Size(100, 20)
      Me.txtDebe.TabIndex = 8
      Me.txtDebe.Text = "0.000"
      Me.txtDebe.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDebe.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDebe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(1050, 44)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(88, 16)
      Me.Label10.TabIndex = 202
      Me.Label10.Text = "Cantidad Items"
      '
      'Label17
      '
      Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(1050, 20)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(88, 16)
      Me.Label17.TabIndex = 200
      Me.Label17.Text = "Total Importe"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
      '
      'Print2
      '
      Me.Print2.ImageIndex = 4
      Me.Print2.Key = "Print2"
      Me.Print2.Name = "Print2"
      Me.Print2.Text = "Imprimir"
      '
      'Print21
      '
      Me.Print21.Key = "Print2"
      Me.Print21.Name = "Print21"
      '
      'Separator11
      '
      Me.Separator11.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator11.Key = "Separator"
      Me.Separator11.Name = "Separator11"
      '
      'frmConciliaBanco
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(950, 463)
      Me.Controls.Add(Me.UiGroupBox3)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmConciliaBanco"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Conciliación Bancaria"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.UiGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox6.ResumeLayout(False)
      Me.UiGroupBox6.PerformLayout()
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox4.ResumeLayout(False)
      Me.UiGroupBox4.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox5.ResumeLayout(False)
      Me.UiGroupBox5.PerformLayout()
      CType(Me.UiGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox7.ResumeLayout(False)
      Me.UiGroupBox7.PerformLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      Me.UiGroupBox3.PerformLayout()
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Book"
            Call DataShow()

         Case "Cheque"
            Call frmCompChequeLoad()

         Case "Save"
            If DataSave() Then
               Call grdMainLoad()
            End If

         Case "Refrescar"
            Call grdMainReload()

         Case "CheckConciliaCheque"
            Call grdMainCheckChequesCob()

         Case "UnCheckConciliaCheque"
            Call grdMainUnCheckChequesPend()

         Case "ConciliaDiferencia"
            'Call grdMainUnCheckChequesPend()
            Call frmConciliaDiferenciaLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Print2"
            Call PrintReport2()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmConciliaBanco_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmConciliaBanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ComboLoad()

      cboMoneda.SelectedIndex = ListFindItem(cboMoneda, mlngMonedaId)
      cboPlan.Value = ListFindItem(cboPlan, mlngPlanId)
      txtBancoCta.Text = FindBancoCta(mlngPlanId)
      dtpFechaIni.Text = ConvertDMY(mstrFechaIni)
      dtpFechaFin.Text = ConvertDMY(mstrFechaFin)

      If Not mboolIntervaloFecha Then
         Dim datFechaFin As Date
         Dim datFechaIni As Date = GestionFechaIni(clsAppInfo.GestionId, datFechaFin)
         dtpFechaFin.Value = datFechaFin
      End If

      Call grdMainLoad()
      Call ClearMemory()

      mboolSelected = False

      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad()
      Dim lngMonedaId As Long

      Try
         Call moDataSetInit()

         With moCompDet
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
            .PlanId = mlngPlanId
            .Orden = ToBoolean(mboolSinFac) 'SinFac
            .Automatico = ToBoolean(mboolConFac) 'ConFac

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

               If lngMonedaId = 1 Then
                  txtSaldoIni.Text = mdecSaldoBs
               Else
                  txtSaldoIni.Text = mdecSaldoUs
               End If

               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRow(oRow, lngMonedaId))
               Next
            End If

            grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()
            Call TotalClear()

            Call CompDetConciliaLoad()
            Call TotalCalcular()
            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub CompDetConciliaLoad()
      Dim oCompDetCon As New clsCompDetConcilia(clsAppInfo.ConnectString)

      Try
         With oCompDetCon
            .SelectFilter = clsCompDetConcilia.SelectFilters.All
            .WhereFilter = clsCompDetConcilia.WhereFilters.EmpresaIdPlanId
            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .PlanId = mlngPlanId

            If .Open() Then
               Do While .Read()
                  Call grdMainCompDetConcilia(.CompDetId, .Concilia)

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDetCon.Dispose()

      End Try
   End Sub

   Private Sub grdMainCompDetConcilia(ByVal lngCompDetId As Long, ByVal boolValue As Boolean)
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If oRow.Cells("CompDetId").Value = lngCompDetId Then
            oRow.IsChecked = boolValue

            oRow.BeginEdit()
            oRow.Cells("Estado").Value = "Show"
            oRow.EndEdit()

            Exit For
         End If
      Next
   End Sub

   Private Sub grdMainReload(Optional ByVal boolSel As Boolean = False)
      Dim lngCompDetId As Long
      Try
         lngCompDetId = ToLong(grdMain.GetValue("CompDetId"))
         Call mlstConciliadosLoad()
         Call grdMainLoad()

         If mlstConciliados.Count > 0 Then
            Dim vecItem As Object()
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
               If mlstConciliados.ContainsKey(oRow.Cells("CompDetId").Value) Then
                  ''oRow.IsChecked = True
                  ''oRow.BeginEdit()
                  ''oRow.EndEdit()

                  vecItem = mlstConciliados.Item(oRow.Cells("CompDetId").Value)
                  oRow.BeginEdit()
                  oRow.IsChecked = vecItem(0)
                  oRow.Cells("Estado").Value = ToStr(vecItem(1))
                  oRow.EndEdit()
               End If
            Next
         End If

         Call TotalCalcular()
         Call grdMainFindRow(lngCompDetId)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function DataSave() As Boolean
      Dim bytItemRepShow As Byte
      Dim boolCheck As Boolean
      Dim boolExisteMensaje As Boolean = False
      Try
         If GridCheckChequesCob(boolExisteMensaje) Then
            If GridCheckChequesPend(boolExisteMensaje) Then
               If boolExisteMensaje Then
                  boolCheck = True
               Else
                  If MessageBox.Show("¿Realmente Quiere Guardar los Cambios?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     boolCheck = True
                  End If
               End If
            End If
         End If

         If boolCheck Then
            If GridCheck() Then
               For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
                  If ToStr(oRow.Cells("Estado").Value) = "New" Then
                     DataSave = ConciliaAdd(oRow.Cells("CompDetId").Value, oRow)

                  ElseIf ToStr(oRow.Cells("Estado").Value) = "Edit" Then
                     If oRow.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
                        bytItemRepShow = 1
                     Else
                        bytItemRepShow = 0
                     End If

                     DataSave = ConciliaUpdate(oRow.Cells("CompDetId").Value, bytItemRepShow, oRow)
                  End If
               Next

            End If
         End If
         
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function GridCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim intCol As Integer

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If (ToStr(oRow.Cells("Estado").Value) = "New") Or (ToStr(oRow.Cells("Estado").Value) = "Edit") Then
            Return True
         End If
      Next

      strMsg &= "No se Realizaron Cambios" & vbCrLf

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         GridCheck = False
      Else
         GridCheck = True
      End If
   End Function

   Private Function GridCheckChequesCob(ByRef boolMensaje As Boolean) As Boolean
      Dim lngCant As Long = 0
      Dim strNroCheques As String = ""
      Dim strMensaje As String = ""
      GridCheckChequesCob = True
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If Not IsDBNull(oRow.Cells("CompChequeId").Value) Then

            If (oRow.Cells("ChequeEstadoId").Value = 8) And (Not oRow.IsChecked) Then
               strNroCheques &= oRow.Cells("ChequeNro").Value & ", "
               lngCant += 1
            End If
         End If
      Next

      If lngCant > 0 Then
         strMensaje = " Existen Cheques Cobrandos sin conciliar  " & ToStr(lngCant) & " Cheque(s)" & vbCrLf & "     Cheques: " & strNroCheques
         If MessageBox.Show(strMensaje & vbCrLf & "¿Realmente desea Guardar la Conciliación?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GridCheckChequesCob = True
            boolMensaje = True
         Else
            GridCheckChequesCob = False
         End If
      End If
   End Function

   Private Function GridCheckChequesPend(ByRef boolMensaje As Boolean) As Boolean
      Dim lngCant As Long = 0
      Dim strNroCheques As String = ""
      Dim strMensaje As String = ""
      GridCheckChequesPend = True
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If Not IsDBNull(oRow.Cells("CompChequeId").Value) Then

            If (oRow.Cells("ChequeEstadoId").Value = 13) And (oRow.IsChecked) Then
               strNroCheques &= oRow.Cells("ChequeNro").Value & ", "
               lngCant += 1
            End If
         End If
      Next

      If lngCant > 0 Then
         strMensaje = " Existen Cheques Pendientes conciliados  " & ToStr(lngCant) & " Cheque(s)" & vbCrLf & "     Cheques: " & strNroCheques
         If MessageBox.Show(strMensaje & vbCrLf & "¿Realmente desea Guardar la Conciliación?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GridCheckChequesPend = True
            boolMensaje = True
         Else
            GridCheckChequesPend = False
         End If
      End If
   End Function

   Private Function TipoCompDesFind(ByVal lngCompId As Long) As String
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      oTipoComp.TipoCompId = lngCompId
      oTipoComp.FindByPK()
      Return oTipoComp.TipoCompDes
   End Function

   Private Function PlanDesFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      oPlan.PlanId = lngPlanId
      oPlan.FindByPK()
      Return oPlan.PlanDes
   End Function

   Private Function CompNroFind(ByVal lngCompId As Long) As String
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      oComp.CompId = lngCompId
      oComp.FindByPK()
      Return oComp.CompNro
   End Function

   Private Sub CloneVM(ByRef oVM As clsCompDetConciliaVM, ByVal oCompDetCon As clsCompDetConcilia)
      oVM = New clsCompDetConciliaVM

      With oVM
         .CompDetId = oCompDetCon.CompDetId
         .CompId = oCompDetCon.CompId
         .CompNro = CompNroFind(.CompId)
         .TipoCompId = oCompDetCon.TipoCompId
         .TipoCompDes = TipoCompDesFind(.TipoCompId)
         .Fecha = oCompDetCon.Fecha
         .PlanId = oCompDetCon.PlanId
         .PlanDes = PlanDesFind(.PlanId)
         .FechaCon = oCompDetCon.FechaCon
         .Concilia = oCompDetCon.Concilia

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Function ConciliaAdd(ByVal lngCompDetId As Long, ByVal oRow As Janus.Windows.GridEX.GridEXRow) As Boolean
      Dim oCompDetCon As New clsCompDetConcilia(clsAppInfo.ConnectString)

      ConciliaAdd = False
      Dim boolFind As Boolean = False

      Try
         With oCompDetCon
            .CompDetId = lngCompDetId

            If .FindByPK Then
               boolFind = True
               Call CloneVM(.VMOld, oCompDetCon)
            End If

            .EmpresaId = mlngEmpresaId
            .GestionId = mlngGestionId
            .CompDetId = ToLong(oRow.Cells("CompDetId").Value)
            .CompId = ToLong(oRow.Cells("CompId").Value)
            .TipoCompId = ToLong(oRow.Cells("TipoCompId").Value)
            .Fecha = ToDate(oRow.Cells("Fecha").Value)
            .PlanId = ToLong(oRow.Cells("PlanId").Value)
            .FechaCon = ToDate(dtpFechaFin.Value)
            .Concilia = 1

            Call CloneVM(.VMNew, oCompDetCon)
            .VMNew.Fecha = ConvertDMY(.Fecha)
            .VMNew.FechaCon = ConvertDMY(.FechaCon)

            If boolFind Then
               If .Update() Then
                  ConciliaAdd = True
               End If
            Else
               If .Insert() Then
                  ConciliaAdd = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDetCon.Dispose()

      End Try
   End Function

   Private Function ConciliaUpdate(ByVal lngCompDetId As Long, ByVal bytConcilia As Byte, ByVal oRow As Janus.Windows.GridEX.GridEXRow) As Boolean
      Dim oCompDetCon As New clsCompDetConcilia(clsAppInfo.ConnectString)

      ConciliaUpdate = False

      Try
         With oCompDetCon
            .CompDetId = lngCompDetId

            If .FindByPK Then
               Call CloneVM(.VMOld, oCompDetCon)

               .EmpresaId = mlngEmpresaId
               .GestionId = mlngGestionId
               .CompDetId = ToLong(oRow.Cells("CompDetId").Value)
               .CompId = ToLong(oRow.Cells("CompId").Value)
               .TipoCompId = ToLong(oRow.Cells("TipoCompId").Value)
               .Fecha = ToDate(oRow.Cells("Fecha").Value)
               .PlanId = ToLong(oRow.Cells("PlanId").Value)
               .FechaCon = ToDate(dtpFechaFin.Value)
               .Concilia = bytConcilia

               Call CloneVM(.VMNew, oCompDetCon)
               .VMNew.Fecha = ConvertDMY(.Fecha)
               .VMNew.FechaCon = ConvertDMY(.FechaCon)

               If .Update Then
                  ConciliaUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDetCon.Dispose()

      End Try
   End Function

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCompDet.TableName)

      moDataTable.Columns.Add("Tipo", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Fecha", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoCompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCompDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompNro", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompDetDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("TipoCambio", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("HaberBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoBs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("HaberUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("SaldoUs", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("DebeHaber", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Sel", Type.GetType("System.Boolean"))
      moDataTable.Columns.Add("CompChequeId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ChequeNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ChequeFecha", Type.GetType("System.String"))
      moDataTable.Columns.Add("ChequeDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("ChequeEstadoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ChequeEstado", Type.GetType("System.String"))
      moDataTable.Columns.Add("ChequeFechaCob", Type.GetType("System.String"))
      moDataTable.Columns.Add("ChequeCobDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Estado", Type.GetType("System.String"))
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow, ByVal lngMonedaId As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompDetId") = oDataRow("CompDetId")
      oRow("CompId") = oDataRow("CompId")
      oRow("PlanId") = oDataRow("PlanId")
      oRow("PlanCta") = oDataRow("PlanCta")
      oRow("PlanDes") = oDataRow("PlanDes")
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

         If mlngMonedaId = 1 Then
            oRow("DebeHaber") = Math.Abs(ToDecimal(oRow("DebeBs") - oRow("HaberBs")))
         Else
            oRow("DebeHaber") = Math.Abs(ToDecimal(oRow("DebeUs") - oRow("HaberUs")))
         End If

      ElseIf (mlngGrupo = 2) Or (mlngGrupo = 3) Or (mlngGrupo = 4) Or (mlngGrupo = 8) Then
         mdecSaldoBs += ToDecimal(oRow("HaberBs") - oRow("DebeBs"))
         mdecSaldoUs += ToDecimal(oRow("HaberUs") - oRow("DebeUs"))

         If mlngMonedaId = 1 Then
            oRow("DebeHaber") = Math.Abs(ToDecimal(oRow("DebeBs") - oRow("HaberBs")))
         Else
            oRow("DebeHaber") = Math.Abs(ToDecimal(oRow("DebeUs") - oRow("HaberUs")))
         End If
      End If

      mdecDebeBs += ToDecimal(oRow("DebeBs"))
      mdecHaberBs += ToDecimal(oRow("HaberBs"))
      mdecDebeUs += ToDecimal(oRow("DebeUs"))
      mdecHaberUs += ToDecimal(oRow("HaberUs"))

      oRow("SaldoBs") = mdecSaldoBs
      oRow("SaldoUs") = mdecSaldoUs

      If (ToDecimal(oRow("DebeBs")) = 0) Or (ToDecimal(oRow("DebeUs")) = 0) Then
         Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompDetId
            .CompDetId = ToLong(oRow("CompDetId"))

            If .Find Then
               oRow("CompChequeId") = ToLong(.CompChequeId)
               oRow("ChequeNro") = ToLong(.ChequeNro)
               oRow("ChequeFecha") = ToStr(.Fecha)
               oRow("ChequeDes") = ToStr(.ChequeDes)

               oRow("ChequeEstadoId") = ToLong(.EstadoIdCob)
               oRow("ChequeEstado") = EstadoDesFind(.EstadoIdCob)
               If oRow("ChequeEstadoId") = 8 Then
                  oRow("ChequeFechaCob") = ToStr(.FechaCob)
                  oRow("ChequeCobDes") = ToStr(.ChequeDes)
               End If
            End If

            .Dispose()
         End With
      End If

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

      oRow("Sel") = False
      oRow("Estado") = ""

      Return oRow
   End Function

   Private Sub RowNewEditCheck(ByRef oRow As Janus.Windows.GridEX.GridEXRow, ByVal boolValue As Boolean)
      oRow.BeginEdit()
      oRow.IsChecked = boolValue
      ''If oRow.Cells("Estado").Value = "" Then
      ''   oRow.Cells("Estado").Value = "New"
      ''ElseIf oRow.Cells("Estado").Value = "Show" Then
      ''   oRow.Cells("Estado").Value = "Edit"
      ''End If

      If oRow.Cells("Estado").Value = "" Then
         If oRow.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            oRow.Cells("Estado").Value = "New"
         End If

      ElseIf oRow.Cells("Estado").Value = "New" Then
         If oRow.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            oRow.Cells("Estado").Value = ""
         End If

      ElseIf oRow.Cells("Estado").Value = "Show" Then
         oRow.Cells("Estado").Value = "Edit"
      End If

      oRow.EndEdit()
   End Sub

   Private Function FindBancoCta(ByVal lngPlanId As Long) As String
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      FindBancoCta = ""

      Try
         With oCheque
            .SelectFilter = clsCheque.SelectFilters.All
            .WhereFilter = clsCheque.WhereFilters.PlanId
            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanId

            If .Find Then
               FindBancoCta = ToStr(.BancoCta)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCheque.Dispose()

      End Try
   End Function

   Private Sub TotalCalcular()
      Dim decDebeBs As Decimal = 0
      Dim decDebeUs As Decimal = 0
      Dim decHaberBs As Decimal = 0
      Dim decHaberUs As Decimal = 0
      Dim decSaldoBs As Decimal = ToDecimal(txtSaldoIni.Text)
      Dim decSaldoUs As Decimal = ToDecimal(txtSaldoIni.Text)

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If CBool(oRow.Cells("Sel").Value) Then
            decDebeBs += ToDecimal(oRow.Cells("DebeBs").Value)
            decDebeUs += ToDecimal(oRow.Cells("DebeUs").Value)
            decHaberBs += ToDecimal(oRow.Cells("HaberBs").Value)
            decHaberUs += ToDecimal(oRow.Cells("HaberUs").Value)

            decSaldoBs += ToDecimal(ToDecimal(oRow.Cells("DebeBs").Value) - ToDecimal(oRow.Cells("HaberBs").Value))
            decSaldoUs += ToDecimal(ToDecimal(oRow.Cells("DebeUs").Value) - ToDecimal(oRow.Cells("HaberUs").Value))

         End If
      Next

      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) = 1 Then
         txtCreditoCon.Text = decDebeBs
         txtDebitoCon.Text = decHaberBs
         txtDebitoSinC.Text = mdecHaberBs - decHaberBs
         txtCreditoSinC.Text = mdecDebeBs - decDebeBs
         txtSaldo.Text = decSaldoBs

      ElseIf ListPosition(cboMoneda, cboMoneda.SelectedIndex) = 2 Then
         txtCreditoCon.Text = decDebeUs
         txtDebitoCon.Text = decHaberUs
         txtDebitoSinC.Text = mdecHaberUs - decHaberUs
         txtCreditoSinC.Text = mdecDebeUs - decDebeUs
         txtSaldo.Text = decSaldoUs

      End If

      txtMontoDif.Text = ToDecimal(txtSaldo.Text) - ToDecimal(txtExtracto.Text)
      txtDiferenciaSinC.Text = ToDecimal(txtCreditoSinC.Text) - ToDecimal(txtDebitoSinC.Text)
      txtDiferenciaCon.Text = ToDecimal(txtCreditoCon.Text) - ToDecimal(txtDebitoCon.Text)
      txtResultado.Text = ToDecimal(txtMontoDif.Text) + (ToDecimal(txtDiferenciaCon.Text) + ToDecimal(txtDiferenciaSinC.Text))
      Call AddConditionalFormatting()

   End Sub

   Private Sub TotalClear()
      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) = 1 Then
         txtDebe.Text = mdecDebeBs
         txtHaber.Text = mdecHaberBs

         txtSaldoOrg.Text = mdecSaldoBs
         txtDebitoSinC.Text = mdecHaberBs
         txtCreditoSinC.Text = mdecDebeBs

      ElseIf ListPosition(cboMoneda, cboMoneda.SelectedIndex) = 2 Then
         txtDebe.Text = mdecDebeUs
         txtHaber.Text = mdecHaberUs

         txtSaldoOrg.Text = mdecSaldoUs
         txtDebitoSinC.Text = mdecHaberUs
         txtCreditoSinC.Text = mdecDebeUs
      End If

      txtSaldo.Text = txtSaldoIni.Text
      txtMontoDif.Text = ToDecimal(txtSaldo.Text) - ToDecimal(txtExtracto.Text)
      txtDiferenciaSinC.Text = ToDecimal(txtCreditoSinC.Text) - ToDecimal(txtDebitoSinC.Text)
      txtDiferenciaCon.Text = ToDecimal(txtCreditoCon.Text) - ToDecimal(txtDebitoCon.Text)
      txtResultado.Text = ToDecimal(txtMontoDif.Text) + (ToDecimal(txtDiferenciaCon.Text) + ToDecimal(txtDiferenciaSinC.Text))

   End Sub

   Private Sub mlstConciliadosLoad()
      mlstConciliados.Clear()
      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
            ''If CBool(oRow.Cells("Sel").Value) Then
            ''   mlstConciliados.Add(oRow.Cells("CompDetId").Value, oRow.Cells("Estado").Value)
            ''End If
            If (ToStr(oRow.Cells("Estado").Value) = "New") Or (ToStr(oRow.Cells("Estado").Value) = "Edit") Then
               Dim vecItem As Object() = {oRow.IsChecked, ToStr(oRow.Cells("Estado").Value)}
               mlstConciliados.Add(oRow.Cells("CompDetId").Value, vecItem)
            End If
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally

      End Try

   End Sub

   Private Sub grdMainCheckAll(ByVal boolValue As Boolean)
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         oRow.BeginEdit()

         oRow.IsChecked = boolValue

         If oRow.Cells("Estado").Value = "" Then
            If oRow.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
               oRow.Cells("Estado").Value = "New"
            End If

         ElseIf oRow.Cells("Estado").Value = "New" Then
            If oRow.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
               oRow.Cells("Estado").Value = ""
            End If

         ElseIf oRow.Cells("Estado").Value = "Show" Then
            oRow.Cells("Estado").Value = "Edit"
         End If

         oRow.EndEdit()
      Next
   End Sub

   Private Sub grdMainCheckChequesCob()
      Dim lngCant As Long = 0
      Dim strNroCheques As String = ""
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If Not IsDBNull(oRow.Cells("CompChequeId").Value) Then

            If (oRow.Cells("ChequeEstadoId").Value = 8) And (Not oRow.IsChecked) Then
               oRow.BeginEdit()

               oRow.IsChecked = True
               strNroCheques &= oRow.Cells("ChequeNro").Value & ", "

               If oRow.Cells("Estado").Value = "" Then
                  oRow.Cells("Estado").Value = "New"
               ElseIf oRow.Cells("Estado").Value = "Show" Then
                  oRow.Cells("Estado").Value = "Edit"
               End If

               oRow.EndEdit()

               lngCant += 1
            End If
         End If
      Next

      If lngCant > 0 Then
         Call TotalCalcular()
         MessageBox.Show("Se conciliaron " & ToStr(lngCant) & " Cheques" & vbCrLf & "     Cheques: " & strNroCheques, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
         MessageBox.Show("No se concilió ningun Cheque", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
   End Sub

   Private Sub grdMainUnCheckChequesPend()
      Dim lngCant As Long = 0
      Dim strNroCheques As String = ""

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If Not IsDBNull(oRow.Cells("CompChequeId").Value) Then

            If (oRow.Cells("ChequeEstadoId").Value = 13) And (oRow.IsChecked) Then
               oRow.BeginEdit()

               strNroCheques &= oRow.Cells("ChequeNro").Value & ", "
               oRow.IsChecked = False

               If oRow.Cells("Estado").Value = "" Then
                  oRow.Cells("Estado").Value = "New"
               ElseIf oRow.Cells("Estado").Value = "Show" Then
                  oRow.Cells("Estado").Value = "Edit"
               End If

               oRow.EndEdit()

               lngCant += 1
            End If
         End If
      Next

      If lngCant > 0 Then
         Call TotalCalcular()
         MessageBox.Show("Se quitó la conciliación de " & ToStr(lngCant) & " Cheque(s)" & vbCrLf & "     Cheques: " & strNroCheques, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
         MessageBox.Show("No se encontro cheques conciliados Pendientes ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
   End Sub

   Private Function PlanGrupoFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanGrupoFind = 0

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanGrupoFind = ToLong(Microsoft.VisualBasic.Left(.PlanCta, 1))
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

   Private Function EstadoDesFind(ByVal lngEstadoId As Long) As String
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)

      EstadoDesFind = ""

      Try
         With oEstado
            .EstadoId = lngEstadoId

            If .FindByPK Then
               EstadoDesFind = .EstadoDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEstado.Dispose()

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
         oCompDet.Dispose()

      End Try
   End Function

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
         MessageBox.Show("Registro Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
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
      ''Dim oIngresoEgreso As New clsIngresoEgreso(clsAppInfo.ConnectString)
      ''Dim lngCompDetId As Long
      ''Dim boolShow As Boolean = False

      ''Try
      ''   If grdMain.RowCount > 0 Then
      ''      If (ToLong(grdMain.GetValue("CompId")) > 0) Then
      ''         With oIngresoEgreso
      ''            .SelectFilter = clsIngresoEgreso.SelectFilters.All
      ''            .WhereFilter = clsIngresoEgreso.WhereFilters.CompId
      ''            .CompId = ToLong(grdMain.GetValue("CompId"))
      ''            lngCompDetId = ToLong(grdMain.GetValue("CompDetId"))

      ''            If .Find() Then
      ''               Dim frm As New frmIngresoEgresoEdit

      ''               If (.TipoReciboId = 1) Or (.TipoReciboId = 5) Then
      ''                  frm.DesdePago = False
      ''                  ''If .CobradorID = CobradorIdFind(clsAppInfo.UserId) Then
      ''                  frm.OtroCobrador = ToBoolean(False)
      ''                  If (.EstadoId <> 17) Or (.EstadoId <> 12) Then 'Arqueado
      ''                     If .PorConcepto <> "Arqueo de Caja" Then
      ''                        boolShow = True
      ''                     End If
      ''                  End If
      ''                  ''Else
      ''                  ''   frm.OtroCobrador = ToBoolean(True)
      ''                  ''End If
      ''               Else
      ''                  frm.DesdePago = True
      ''               End If

      ''               If boolShow Then
      ''                  frm.NewRecord = False
      ''                  frm.Editing = True
      ''                  frm.DataObject = oIngresoEgreso
      ''                  frm.ShowDialog()

      ''                  If frm.Changed Then
      ''                     Call grdMainReload()
      ''                     Call grdMainFindRow(lngCompDetId)
      ''                     mboolChanged = True
      ''                  End If

      ''               Else
      ''                  frm.NewRecord = False
      ''                  frm.Editing = False
      ''                  frm.DataObject = oIngresoEgreso
      ''                  frm.ShowDialog()
      ''               End If

      ''               frm.Dispose()
      ''            End If
      ''         End With
      ''      Else
      ''         MessageBox.Show("Registro Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      ''      End If
      ''   Else
      ''      MessageBox.Show("Seleccione un Comprobante", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      ''   End If

      ''Catch exp As Exception
      ''   MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      ''Finally
      ''   oIngresoEgreso.Dispose()

      ''End Try
   End Sub

   Private Sub frmCompChequeLoad()
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      Dim lngCompDetId As Long

      Try
         If (grdMain.RowCount > 0) And (ToLong(grdMain.GetValue("CompChequeId")) > 0) Then
            With oCompCheque
               .CompChequeId = ToLong(grdMain.GetValue("CompChequeId"))
               lngCompDetId = ToLong(grdMain.GetValue("CompDetId"))

               If .FindByPK Then
                  Dim frm As New frmCompChequeEdit

                  frm.NewRecord = False
                  frm.Editing = True
                  frm.EditCob = True
                  frm.DataObject = oCompCheque
                  frm.ShowDialog()

                  If frm.Changed Then
                     ''Call DataViewAll()
                     Call grdMainFindRow(lngCompDetId)
                     ''Dim oRowGrid As Janus.Windows.GridEX.GridEXRow = grdMain.GetRow
                     If oCompCheque.EstadoIdCob = 8 Then
                        RowNewEditCheck(grdMain.GetRow, True)
                     Else
                        RowNewEditCheck(grdMain.GetRow, False)
                     End If

                     Call grdMainReload()
                     Call grdMainFindRow(lngCompDetId)
                     mboolChanged = True
                  End If

                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Registro Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
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

   Private Function GetDataNoConciliados(ByVal oDataTableOrg As DataTable) As System.Data.DataView
      Dim oDataTable As DataTable
      Dim oRow As DataRow
      Dim lngPos As Long = 0

      oDataTable = oDataTableOrg.Clone

      For Each oRowMain In grdMain.GetUncheckedRows
         oRow = oDataTable.NewRow

         For i = 0 To oRowMain.Cells.Count - 1
            oRow(i) = oRowMain.Cells(i).Value
         Next

         If (Not IsDBNull(oRowMain.Cells("HaberBs").Value)) And Not (IsDBNull(oRowMain.Cells("HaberUs").Value)) Then
            oRow("Tipo") = 1
            oDataTable.Rows.InsertAt(oRow, lngPos)
            lngPos += 1
         Else
            oRow("Tipo") = 2
            oDataTable.Rows.Add(oRow)
         End If
      Next

      Return oDataTable.DefaultView

   End Function

   Private Sub PrintReport()
      Try
         If (mlngMonedaId = 1) Or (mlngMonedaId = 2) Then
            Dim rpt As New rptConciliaBanco

            rpt.DataSource = GetDataNoConciliados(moDataTable.DataSet.Tables(moCompDet.TableName))

            rpt.lblTitle.Text = "Conciliación Bancaria"
            rpt.Document.Name = "Conciliación Bancaria"
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
            rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)
            rpt.lblBanco.Text = cboPlan.Text
            rpt.lblNroCuenta.Text = txtBancoCta.Text

            rpt.txtExtracto.Text = ToDecStrDos(ToDecimal(txtExtracto.Text))
            rpt.txtDebitoSinC.Text = ToDecStrDos(ToDecimal(txtDebitoSinC.Text))
            rpt.txtCreditoSinC.Text = ToDecStrDos(ToDecimal(txtCreditoSinC.Text))
            rpt.txtDiferenciaSinC.Text = ToDecStrDos(ToDecimal(txtDiferenciaSinC.Text))
            ''rpt.txtSaldoLibro.Text = ToDecStrDos(ToDecimal(txtSaldo.Text))
            rpt.txtSaldoLibro.Text = ToDecStrDos(ToDecimal(txtSaldoOrg.Text))

            If mlngMonedaId = 1 Then
               rpt.txtMonedaDes.Text = MonedaDesFind(mlngMonedaId)
               rpt.txtMonto.DataField = "DebeHaber"
            ElseIf mlngMonedaId = 2 Then
               rpt.txtMonedaDes.Text = MonedaDesFind(mlngMonedaId)
               rpt.txtMonto.DataField = "DebeHaber"
            End If

            rpt.txtSubTotal.DataField = "DebeHaber"

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

            rpt.Run(True)
            Dim frm As frmReportPreview
            frm = New frmReportPreview(rpt.Document, Me)
            frm.Show()

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Sub

   Private Sub PrintReport2()
      Try
         If (mlngMonedaId = 1) Or (mlngMonedaId = 2) Then
            Dim rpt As New rptConciliaBancoDiferencia
            Dim srptConciliaIngresoEgreso As New rptConciliaIngresoEgreso
            Dim srptConciliaDiferencia As New rptConciliaDiferencia
            Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
            oPlan.PlanId = mlngPlanId
            oPlan.FindByPK()
            rpt.DataSource = oPlan.DataSet.Tables(oPlan.TableName) '

            rpt.lblTitle.Text = "Conciliación Bancaria"
            rpt.Document.Name = "Conciliación Bancaria"
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            rpt.txtFechaIni.Text = ConvertDMY(mstrFechaIni)
            rpt.txtFechaFin.Text = ConvertDMY(mstrFechaFin)
            rpt.lblBanco.Text = cboPlan.Text
            rpt.lblNroCuenta.Text = txtBancoCta.Text

            rpt.txtExtracto.Text = ToDecStrDos(ToDecimal(txtExtracto.Text))
            rpt.txtDebitoSinC.Text = ToDecStrDos(ToDecimal(txtDebitoSinC.Text))
            rpt.txtCreditoSinC.Text = ToDecStrDos(ToDecimal(txtCreditoSinC.Text))
            rpt.txtDiferenciaSinC.Text = ToDecStrDos(ToDecimal(txtDiferenciaSinC.Text))
            ''rpt.txtSaldoLibro.Text = ToDecStrDos(ToDecimal(txtSaldo.Text))
            rpt.txtSaldoLibro.Text = ToDecStrDos(ToDecimal(txtSaldoOrg.Text))

            ''Concilia Ingreso Egreso
            srptConciliaIngresoEgreso.DataSource = GetDataNoConciliados(moDataTable.DataSet.Tables(moCompDet.TableName))
            srptConciliaIngresoEgreso.txtMonto.DataField = "DebeHaber"
            srptConciliaIngresoEgreso.txtSubTotal.DataField = "DebeHaber"
            rpt.srptConciliaIngresoEgreso.Report = srptConciliaIngresoEgreso

            Dim oConciliaDiferencia As New clsConciliaDiferencia(clsAppInfo.ConnectString)

            With oConciliaDiferencia
               .SelectFilter = clsConciliaDiferencia.SelectFilters.PrintReport
               .WhereFilter = clsConciliaDiferencia.WhereFilters.PrintReport
               .OrderByFilter = clsConciliaDiferencia.OrderByFilters.PrintReport
               .EmpresaId = mlngEmpresaId
               .GestionId = mlngGestionId
               .PlanId = mlngPlanId
               .Fecha = mstrFechaIni
               .LastUpdateDate = mstrFechaFin

               If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
                  srptConciliaDiferencia.DataSource = .DataSet.Tables(.TableName)
                  rpt.srptConciliaDiferencia.Report = srptConciliaDiferencia
               Else
                  rpt.Label17.Visible = False
                  rpt.Label18.Visible = False
                  rpt.Label19.Visible = False
                  rpt.Label20.Visible = False
               End If
            End With

            If mlngMonedaId = 1 Then
               rpt.txtMonedaDes.Text = MonedaDesFind(mlngMonedaId)
            ElseIf mlngMonedaId = 2 Then
               rpt.txtMonedaDes.Text = MonedaDesFind(mlngMonedaId)
            End If

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

            rpt.Run(True)
            Dim frm As frmReportPreview
            frm = New frmReportPreview(rpt.Document, Me)
            frm.Show()

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Sub

   Private Sub PrintReportResu()
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
            frm = New frmReportPreview(rpt.Document)
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
            Dim frm As New frmReportPreview(rpt.Document)
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompDetId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboPlanLoad()
   End Sub

   Private Sub cboMonedaLoad()
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboMoneda.Items.Clear()

      Try
         With oMoneda
            .SelectFilter = clsMoneda.SelectFilters.ListBox
            .OrderByFilter = clsMoneda.OrderByFilters.MonedaDes

            If .Open() Then
               Do While .Read()
                  If .MonedaId > 0 Then
                     oItem = New clsListItem(.MonedaId, .MonedaDes)

                     cboMoneda.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMoneda.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.TipoPlanId
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = mlngEmpresaId
            .TipoPlanId = 3

            If .Open() Then
               With cboPlan
                  .DropDownList.Columns.Clear()

                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Function GestionFechaIni(ByVal lngGestionId As Long, ByRef datFechaFin As Date) As Date
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               datFechaFin = ToDate2(.DataSet.Tables(.TableName).Rows(0).Item("FechaFin"))
               GestionFechaIni = ToDate2(.DataSet.Tables(.TableName).Rows(0).Item("FechaIni"))
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moCompDet = New clsCompDet(clsAppInfo.ConnectString)
      txtTipoCambio.FormatString = DecimalMask()
      txtSaldoIni.FormatString = DecimalMask()
      txtSaldo.FormatString = DecimalMask()
      txtExtracto.FormatString = DecimalMask()
      txtMontoDif.FormatString = DecimalMask()

      txtCreditoSinC.FormatString = DecimalMask()
      txtDebitoSinC.FormatString = DecimalMask()
      txtDiferenciaSinC.FormatString = DecimalMask()

      txtCreditoCon.FormatString = DecimalMask()
      txtDebitoCon.FormatString = DecimalMask()
      txtDiferenciaCon.FormatString = DecimalMask()

      txtResultado.FormatString = DecimalMask()
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Libro Banco"

         .RootTable.Columns("Tipo").Visible = False

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
         .RootTable.Columns("CompDetDes").Width = 200
         .RootTable.Columns("CompDetDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompDetDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If mlngMonedaId = 1 Then
            .RootTable.Columns("TipoCambio").Visible = False

            .RootTable.Columns("DebeBs").Caption = "Crédito"
            .RootTable.Columns("DebeBs").FormatString = DecimalMask()
            .RootTable.Columns("DebeBs").Width = 80
            .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberBs").Caption = "Débito"
            .RootTable.Columns("HaberBs").FormatString = DecimalMask()
            .RootTable.Columns("HaberBs").Width = 80
            .RootTable.Columns("HaberBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoBs").Caption = "Saldo"
            .RootTable.Columns("SaldoBs").FormatString = DecimalMask()
            .RootTable.Columns("SaldoBs").Width = 80
            .RootTable.Columns("SaldoBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("SaldoBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("DebeUs").Visible = False

            .RootTable.Columns("HaberUs").Visible = False

            .RootTable.Columns("SaldoUs").Visible = False

         ElseIf mlngMonedaId = 2 Then
            .RootTable.Columns("TipoCambio").Visible = False

            .RootTable.Columns("DebeUs").Caption = "Crédito"
            .RootTable.Columns("DebeUs").FormatString = DecimalMask()
            .RootTable.Columns("DebeUs").Width = 80
            .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("HaberUs").Caption = "Débito"
            .RootTable.Columns("HaberUs").FormatString = DecimalMask()
            .RootTable.Columns("HaberUs").Width = 80
            .RootTable.Columns("HaberUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .RootTable.Columns("HaberUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("SaldoUs").Caption = "Saldo"
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

         .RootTable.Columns("DebeHaber").Visible = False

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("CompChequeId").Visible = False

         .RootTable.Columns("ChequeNro").Caption = "Cheque"
         .RootTable.Columns("ChequeNro").Width = 80
         .RootTable.Columns("ChequeNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ChequeNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ChequeFecha").Caption = "Fecha"
         .RootTable.Columns("ChequeFecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("ChequeFecha").Width = 80
         .RootTable.Columns("ChequeFecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ChequeFecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ChequeFecha").Visible = False

         .RootTable.Columns("ChequeDes").Caption = "A la orden de"
         .RootTable.Columns("ChequeDes").Width = 150
         .RootTable.Columns("ChequeDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ChequeDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ChequeEstadoId").Visible = False

         .RootTable.Columns("ChequeEstado").Caption = "Estado"
         .RootTable.Columns("ChequeEstado").Width = 80
         .RootTable.Columns("ChequeEstado").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ChequeEstado").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ChequeFechaCob").Caption = "Fecha Cob"
         .RootTable.Columns("ChequeFechaCob").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("ChequeFechaCob").Width = 80
         .RootTable.Columns("ChequeFechaCob").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ChequeFechaCob").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ChequeCobDes").Caption = "Descripción"
         .RootTable.Columns("ChequeCobDes").Width = 150
         .RootTable.Columns("ChequeCobDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("ChequeCobDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ChequeCobDes").Visible = False

         .RootTable.Columns("Estado").Visible = False
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      ''fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("SaldoBs"), Janus.Windows.GridEX.ConditionOperator.LessThan, 0)
      ''fc.FormatStyle.ForeColor = Color.DarkRed
      ''grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Sel"), Janus.Windows.GridEX.ConditionOperator.Equal, True)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      ' ''fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("CompDetId"), Janus.Windows.GridEX.ConditionOperator.Equal, -1)
      ' ''fc.FormatStyle.ForeColor = Color.DarkBlue
      ' ''grdMain.RootTable.FormatConditions.Add(fc)

      Dim filterC As Janus.Windows.GridEX.GridEXFilterCondition
      filterC = New Janus.Windows.GridEX.GridEXFilterCondition(grdMain.RootTable.Columns("ChequeEstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
      filterC.AddCondition(1, New Janus.Windows.GridEX.GridEXFilterCondition(grdMain.RootTable.Columns("Sel"), Janus.Windows.GridEX.ConditionOperator.Equal, True))

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Sel"), Janus.Windows.GridEX.ConditionOperator.Equal, True)
      fc.FilterCondition = filterC
      fc.FormatStyle.ForeColor = Color.DarkOrange
      'fc.TargetColumn = grdMain.RootTable.Columns("ChequeNro")
      grdMain.RootTable.FormatConditions.Add(fc)

      ''Nuevito
      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Estado"), Janus.Windows.GridEX.ConditionOperator.Between, "Edit", "New")
      fc.FormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Raised
      fc.FormatStyle.BackColorGradient = Color.Plum
      fc.TargetColumn = grdMain.RootTable.Columns("Sel")
      grdMain.RootTable.FormatConditions.Add(fc)

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

   Private Sub grdMain_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdMain.RowCheckStateChanged
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            Call grdMainCheckAll(True)
         ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            Call grdMainCheckAll(False)
         End If
      Else
         If ToStr(grdMain.GetValue("Estado")) = "" Then
            If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
               grdMain.SetValue("Estado", "New")
            End If

         ElseIf ToStr(grdMain.GetValue("Estado")) = "New" Then
            If e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
               grdMain.SetValue("Estado", "")
            End If

         ElseIf ToStr(grdMain.GetValue("Estado")) = "Show" Then
            grdMain.SetValue("Estado", "Edit")
         End If
      End If

      Call TotalCalcular()
   End Sub

   Private Sub txtMontoExtractoBs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExtracto.TextChanged
      If txtExtracto.ContainsFocus Then
         txtMontoDif.Text = (ToDecimal(txtSaldo.Text) - ToDecimal(txtExtracto.Text))
         txtDiferenciaSinC.Text = ToDecimal(txtCreditoSinC.Text) - ToDecimal(txtDebitoSinC.Text)
         txtDiferenciaCon.Text = ToDecimal(txtCreditoCon.Text) - ToDecimal(txtDebitoCon.Text)
         txtResultado.Text = ToDecimal(txtMontoDif.Text) - (ToDecimal(txtDiferenciaCon.Text) + ToDecimal(txtDiferenciaSinC.Text))
      End If
   End Sub

   Private Sub txtCreditoBanco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCreditoCon.TextChanged
      If txtCreditoCon.ContainsFocus Then
         txtMontoDif.Text = (ToDecimal(txtSaldo.Text) - ToDecimal(txtExtracto.Text))
         txtDiferenciaSinC.Text = ToDecimal(txtCreditoSinC.Text) - ToDecimal(txtDebitoSinC.Text)
         txtDiferenciaCon.Text = ToDecimal(txtCreditoCon.Text) - ToDecimal(txtDebitoCon.Text)
         txtResultado.Text = ToDecimal(txtMontoDif.Text) + (ToDecimal(txtDiferenciaCon.Text) + ToDecimal(txtDiferenciaSinC.Text))
      End If
   End Sub

   Private Sub txtDebitoBanco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebitoCon.TextChanged
      If txtDebitoCon.ContainsFocus Then
         txtMontoDif.Text = (ToDecimal(txtSaldo.Text) - ToDecimal(txtExtracto.Text))
         txtDiferenciaSinC.Text = ToDecimal(txtCreditoSinC.Text) - ToDecimal(txtDebitoSinC.Text)
         txtDiferenciaCon.Text = ToDecimal(txtCreditoCon.Text) - ToDecimal(txtDebitoCon.Text)
         txtResultado.Text = ToDecimal(txtMontoDif.Text) + (ToDecimal(txtDiferenciaCon.Text) + ToDecimal(txtDiferenciaSinC.Text))
      End If
   End Sub

#Region " Cheques "

   Private Sub txtChequeNro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
      'If txtChequeNro.Tag <> txtChequeNro.Text Then
      '   txtChequeNro.Tag = txtChequeNro.Text

      '   grdMainFindRow(grdCompDetIdByChequeFind(ToLong(txtChequeNro.Text)))
      'End If
   End Sub

   Private Sub txtChequeNro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtChequeNro.KeyDown
      If e.KeyCode = Keys.Return Then
         Call btnSaveCheque_Click(Nothing, Nothing)
      End If
   End Sub

   Private Sub btnSaveCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCheque.Click
      If txtChequeNro.Text <> String.Empty Then
         If IsNumeric(txtChequeNro.Text) Then
            Dim intRow As Integer = ChequeTableRowPosition(ToLong(txtChequeNro.Text), 1)
            Dim lngCompDetId As Long = 0
            If (intRow >= 0) And (intRow < moDataTable.Rows.Count) Then
               Dim oRow As DataRow = moDataTable.Rows(intRow)
               If oRow("ChequeEstadoId") = clsEstado.PENDIENTE Then
                  If CompChequeUpdate(oRow("CompChequeId"), 8) Then
                     lngCompDetId = oRow("CompDetId")
                     'Call grdMainReload()
                     Call grdMainFindRow(lngCompDetId)

                     oRow("ChequeEstadoId") = 8
                     oRow("ChequeEstado") = "Cobrado"

                     Dim oRow2 As Janus.Windows.GridEX.GridEXRow = grdMain.GetRow
                     oRow2.BeginEdit()
                     oRow2.IsChecked = True
                     If oRow2.Cells("Estado").Value = "" Then
                        oRow2.Cells("Estado").Value = "New"
                     ElseIf oRow2.Cells("Estado").Value = "Show" Then
                        oRow2.Cells("Estado").Value = "Edit"
                     End If
                     oRow2.EndEdit()

                     mboolChanged = True
                     Call TotalCalcular()
                  End If
               ElseIf oRow("ChequeEstadoId") = 8 Then
                  MessageBox.Show("Nro. de Cheque Cobrado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  txtChequeNro.Text = ""
               End If

               txtChequeNro.Text = ""
            Else
               MessageBox.Show("No existe el Nro. de Cheque Ingresado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               txtChequeNro.Text = ""
            End If

            Call grdMainFindRow(lngCompDetId)
         Else
            MessageBox.Show("Nro. de Cheque Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtChequeNro.Text = ""
         End If
      End If
   End Sub

   Private Function ChequeTableRowPosition(ByVal lngNroCheque As Long, ByRef lngPosCheque As Integer) As Integer
      Dim i As Integer = 0
      Dim intPosCheque As Integer = -1

      For Each oRow As DataRow In moDataTable.Rows
         If Not IsDBNull(oRow("CompChequeId")) Then
            '' ''If (oRow("ChequeNro") = lngNroCheque) And (oRow("ChequeEstadoId") = clsEstado.PENDIENTE) Then
            If (oRow("ChequeNro") = lngNroCheque) Then
               If (oRow("ChequeEstadoId") = clsEstado.PENDIENTE) Then
                  Return i
               Else
                  intPosCheque = i
               End If
            End If
         End If
         i += 1
      Next

      ''Return -1
      Return intPosCheque
   End Function

   Private Function grdCompDetIdByChequeFind(ByVal lngNroCheque As Long) As Integer
      Dim i As Integer = 0

      For Each oRow As DataRow In moDataTable.Rows
         If Not IsDBNull(oRow("CompChequeId")) Then
            If (oRow("ChequeNro") = lngNroCheque) And (oRow("ChequeEstadoId") = clsEstado.PENDIENTE) Then
               Return oRow("CompDetId")
            End If
         End If
      Next

      Return -1
   End Function

   Private Function CompChequeUpdate(ByVal lngCompChequeId As Long, ByVal lngEstadoId As Byte) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)

      CompChequeUpdate = False

      Try
         With oCompCheque
            .CompChequeId = lngCompChequeId

            If .FindByPK Then
               .FechaCob = ToDate(.FechaCob)
               .EstadoIdCob = lngEstadoId
               .ChequeCobDes = .ChequeCobDes

               .UpdateFilter = clsCompCheque.UpdateFilters.ChequeCob
               If .UpdateOnly Then
                  CompChequeUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Sub btnConciliaCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Call grdMainCheckChequesCob()
   End Sub

#End Region

   Private Sub frmConciliaBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call DataEdit()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmConciliaBanco_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompDet.Dispose()
      Call ClearMemory()
   End Sub

   Private Function frmConciliaDiferenciaLoad() As Boolean
      If ToDecimal(txtMontoDif.Text) < 0 Then
         Dim frm As New frmConciliaDiferencia

         With frm
            ' .MdiParent = Me.Parent
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .PlanId = ListPosition(cboPlan)
            .FechaIni = dtpFechaIni.Text
            .FechaFin = dtpFechaFin.Text
            .Diferencia = Math.Abs(ToDecimal(txtMontoDif.Text))
            .Show()
         End With
      Else
         MessageBox.Show("No existe Diferencia válida para Conciliar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If

   End Function

End Class
