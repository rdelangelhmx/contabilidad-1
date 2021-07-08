Public Class frmCompEdit
   Inherits System.Windows.Forms.Form

   Private moComp As clsComp
   Private moCompDet As clsCompDet
   Private mdecDebe As Decimal
   Private mdecHaber As Decimal
   Private mdecDebeEqui As Decimal
   Private mdecHaberEqui As Decimal
   Private mdecDebeDifRet As Decimal
   Private mdecHaberDifRet As Decimal

   Private mboolITF As Boolean
   Private mstrChequeNro As String
   Private mboolAplicarImpuestoDescuento As Boolean = False

   Dim moDataSet As DataSet
   Dim moDataTable As DataTable

   Private mlngCol As Long
   Private mdecCompDetMonto As Decimal

   Private mdicListaPlanEEFFporITF As Dictionary(Of String, Long)
   Private mlistaITFAutomatico As New List(Of strucPlanIdAutomatico)
   Private mlistaIVAAutomatico As New List(Of strucPlanIdAutomatico)
   Private mlistaExentoAutomatico As New List(Of strucPlanIdAutomatico)
   Private mlistaITAutomatico As New List(Of strucPlanIdAutomatico)
   Private mlistaIVADescuentoAutomatico As New List(Of strucPlanIdAutomatico)

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditGrid As Boolean
   Private mlngID As Long
   Private mlngCompNro As Long
   Private mboolNroAuto As Boolean
   Friend WithEvents Reorden1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator12 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Reorden As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
   Friend WithEvents mnuAplicarDescuento As System.Windows.Forms.MenuItem
   Friend WithEvents mnuAplicarDescuentoConsolidado As System.Windows.Forms.MenuItem
   Friend WithEvents mnuCompPlanEEFFEdit As System.Windows.Forms.MenuItem
   Friend WithEvents Separator13 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents FlujoEfectivo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents FlujoEfectivo As Janus.Windows.UI.CommandBars.UICommand
   Private mboolNroAutoGestion As Boolean
   Friend WithEvents mnuDescuento As System.Windows.Forms.MenuItem

   Private mboolNew As Boolean

   Structure strucPlanIdAutomatico
      'Dim PlanId As Long
      Dim CentroCostoId As Long
      Dim SucursalId As Decimal
      Dim Monto As Decimal
      Dim CompDetDes As String
   End Structure

#Region " Set and Get "
   WriteOnly Property NewRecord() As Boolean
      Set(ByVal Value As Boolean)
         mboolAdding = Value
      End Set
   End Property

   WriteOnly Property Editing() As Boolean
      Set(ByVal Value As Boolean)
         mboolEditing = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
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

   Property CompNro() As Long
      Get
         Return mlngCompNro
      End Get

      Set(ByVal Value As Long)
         mlngCompNro = Value
      End Set
   End Property

   WriteOnly Property DataObject() As clsComp
      Set(ByVal Value As clsComp)
         moComp = Value
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
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuConsultar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEliminar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNuevo As System.Windows.Forms.MenuItem
   Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFacturaIndi As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFacturaGral As System.Windows.Forms.MenuItem
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents txtCompId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtGestion As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtCompNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents lblPorConcepto As System.Windows.Forms.Label
   Friend WithEvents lblEntregadoA As System.Windows.Forms.Label
   Friend WithEvents txtEntregadoA As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPorConcepto As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtHaberDif As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtHaber As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtDebe As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtDebeDif As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents ToolBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents SaveTemp As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents SaveTemp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Anular As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Anular1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Listado As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Listado1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Factura As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Factura1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Cheque As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Cheque1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Sucursal As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Sucursal1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CentroCosto As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CentroCosto1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents PlanAdd As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents PlanAdd1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents txtGlosa As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
   Friend WithEvents mnuCompPlanAddEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFacturaAgru As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFactura As System.Windows.Forms.MenuItem
   Friend WithEvents FacturaAgru As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents FacturaAgru1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
   Friend WithEvents mnuFacturaAgruAnu As System.Windows.Forms.MenuItem
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboTipoComp As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Bloquear As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Bloquear1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFacturaAnu As System.Windows.Forms.MenuItem
   Friend WithEvents chkConFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents mnuCompCentroCostoDetEdit As System.Windows.Forms.MenuItem
   Friend WithEvents CentroCostoDet As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CentroCostoDet1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator10 As Janus.Windows.UI.CommandBars.UICommand

   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents chkSinFac As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cboTipoAsiento As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents ExportTXT As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ExportTXT1 As Janus.Windows.UI.CommandBars.UICommand

   Friend WithEvents Separator11 As Janus.Windows.UI.CommandBars.UICommand


   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuConsultar = New System.Windows.Forms.MenuItem
      Me.mnuNuevo = New System.Windows.Forms.MenuItem
      Me.mnuEditar = New System.Windows.Forms.MenuItem
      Me.mnuEliminar = New System.Windows.Forms.MenuItem
      Me.MenuItem1 = New System.Windows.Forms.MenuItem
      Me.mnuFactura = New System.Windows.Forms.MenuItem
      Me.mnuFacturaIndi = New System.Windows.Forms.MenuItem
      Me.mnuFacturaGral = New System.Windows.Forms.MenuItem
      Me.mnuFacturaAnu = New System.Windows.Forms.MenuItem
      Me.MenuItem3 = New System.Windows.Forms.MenuItem
      Me.mnuFacturaAgru = New System.Windows.Forms.MenuItem
      Me.mnuFacturaAgruAnu = New System.Windows.Forms.MenuItem
      Me.MenuItem2 = New System.Windows.Forms.MenuItem
      Me.mnuCompPlanAddEdit = New System.Windows.Forms.MenuItem
      Me.mnuCompCentroCostoDetEdit = New System.Windows.Forms.MenuItem
      Me.mnuCompPlanEEFFEdit = New System.Windows.Forms.MenuItem
      Me.MenuItem6 = New System.Windows.Forms.MenuItem
      Me.mnuDescuento = New System.Windows.Forms.MenuItem
      Me.mnuAplicarDescuento = New System.Windows.Forms.MenuItem
      Me.mnuAplicarDescuentoConsolidado = New System.Windows.Forms.MenuItem
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtDebeDif = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtDebe = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtHaber = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtHaberDif = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkSinFac = New Janus.Windows.EditControls.UICheckBox
      Me.txtGlosa = New Janus.Windows.GridEX.EditControls.EditBox
      Me.chkConFac = New Janus.Windows.EditControls.UICheckBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtPorConcepto = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEntregadoA = New Janus.Windows.GridEX.EditControls.EditBox
      Me.lblPorConcepto = New System.Windows.Forms.Label
      Me.lblEntregadoA = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.cboTipoAsiento = New Janus.Windows.EditControls.UIComboBox
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.cboTipoComp = New Janus.Windows.EditControls.UIComboBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.txtCompNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtGestion = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtCompId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ToolBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.SaveTemp1 = New Janus.Windows.UI.CommandBars.UICommand("SaveTemp")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Bloquear1 = New Janus.Windows.UI.CommandBars.UICommand("Bloquear")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Anular1 = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Reorden1 = New Janus.Windows.UI.CommandBars.UICommand("Reorden")
      Me.Separator12 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Listado1 = New Janus.Windows.UI.CommandBars.UICommand("Listado")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ExportTXT1 = New Janus.Windows.UI.CommandBars.UICommand("ExportTXT")
      Me.Separator11 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.SaveTemp = New Janus.Windows.UI.CommandBars.UICommand("SaveTemp")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Anular = New Janus.Windows.UI.CommandBars.UICommand("Anular")
      Me.Listado = New Janus.Windows.UI.CommandBars.UICommand("Listado")
      Me.PlanAdd1 = New Janus.Windows.UI.CommandBars.UICommand("PlanAdd")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Factura1 = New Janus.Windows.UI.CommandBars.UICommand("Factura")
      Me.FacturaAgru1 = New Janus.Windows.UI.CommandBars.UICommand("FacturaAgru")
      Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CentroCosto1 = New Janus.Windows.UI.CommandBars.UICommand("CentroCosto")
      Me.CentroCostoDet1 = New Janus.Windows.UI.CommandBars.UICommand("CentroCostoDet")
      Me.Separator10 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Cheque1 = New Janus.Windows.UI.CommandBars.UICommand("Cheque")
      Me.Sucursal1 = New Janus.Windows.UI.CommandBars.UICommand("Sucursal")
      Me.Separator13 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.FlujoEfectivo1 = New Janus.Windows.UI.CommandBars.UICommand("FlujoEfectivo")
      Me.Factura = New Janus.Windows.UI.CommandBars.UICommand("Factura")
      Me.Cheque = New Janus.Windows.UI.CommandBars.UICommand("Cheque")
      Me.Sucursal = New Janus.Windows.UI.CommandBars.UICommand("Sucursal")
      Me.CentroCosto = New Janus.Windows.UI.CommandBars.UICommand("CentroCosto")
      Me.PlanAdd = New Janus.Windows.UI.CommandBars.UICommand("PlanAdd")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.FacturaAgru = New Janus.Windows.UI.CommandBars.UICommand("FacturaAgru")
      Me.Bloquear = New Janus.Windows.UI.CommandBars.UICommand("Bloquear")
      Me.CentroCostoDet = New Janus.Windows.UI.CommandBars.UICommand("CentroCostoDet")
      Me.ExportTXT = New Janus.Windows.UI.CommandBars.UICommand("ExportTXT")
      Me.Reorden = New Janus.Windows.UI.CommandBars.UICommand("Reorden")
      Me.FlujoEfectivo = New Janus.Windows.UI.CommandBars.UICommand("FlujoEfectivo")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(720, 171)
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
      Me.grdMain.Size = New System.Drawing.Size(720, 171)
      Me.grdMain.TabIndex = 13
      Me.grdMain.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConsultar, Me.mnuNuevo, Me.mnuEditar, Me.mnuEliminar, Me.MenuItem1, Me.mnuFactura, Me.MenuItem2, Me.mnuCompPlanAddEdit, Me.mnuCompCentroCostoDetEdit, Me.mnuCompPlanEEFFEdit, Me.MenuItem6, Me.mnuDescuento})
      '
      'mnuConsultar
      '
      Me.mnuConsultar.Index = 0
      Me.mnuConsultar.Text = "Consultar"
      '
      'mnuNuevo
      '
      Me.mnuNuevo.Index = 1
      Me.mnuNuevo.Text = "Nuevo"
      '
      'mnuEditar
      '
      Me.mnuEditar.Index = 2
      Me.mnuEditar.Text = "Editar"
      '
      'mnuEliminar
      '
      Me.mnuEliminar.Index = 3
      Me.mnuEliminar.Text = "Eliminar"
      '
      'MenuItem1
      '
      Me.MenuItem1.Index = 4
      Me.MenuItem1.Text = "-"
      '
      'mnuFactura
      '
      Me.mnuFactura.Index = 5
      Me.mnuFactura.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFacturaIndi, Me.mnuFacturaGral, Me.mnuFacturaAnu, Me.MenuItem3, Me.mnuFacturaAgru, Me.mnuFacturaAgruAnu})
      Me.mnuFactura.Text = "Nueva Factura"
      '
      'mnuFacturaIndi
      '
      Me.mnuFacturaIndi.Index = 0
      Me.mnuFacturaIndi.Text = "Individual"
      '
      'mnuFacturaGral
      '
      Me.mnuFacturaGral.Index = 1
      Me.mnuFacturaGral.Text = "Global"
      '
      'mnuFacturaAnu
      '
      Me.mnuFacturaAnu.Index = 2
      Me.mnuFacturaAnu.Text = "Anulada"
      Me.mnuFacturaAnu.Visible = False
      '
      'MenuItem3
      '
      Me.MenuItem3.Index = 3
      Me.MenuItem3.Text = "-"
      '
      'mnuFacturaAgru
      '
      Me.mnuFacturaAgru.Index = 4
      Me.mnuFacturaAgru.Text = "Agrupada"
      '
      'mnuFacturaAgruAnu
      '
      Me.mnuFacturaAgruAnu.Index = 5
      Me.mnuFacturaAgruAnu.Text = "Agrupada Anulada"
      '
      'MenuItem2
      '
      Me.MenuItem2.Index = 6
      Me.MenuItem2.Text = "-"
      '
      'mnuCompPlanAddEdit
      '
      Me.mnuCompPlanAddEdit.Index = 7
      Me.mnuCompPlanAddEdit.Text = "Nuevo Mov. Analítico Adicional"
      '
      'mnuCompCentroCostoDetEdit
      '
      Me.mnuCompCentroCostoDetEdit.Index = 8
      Me.mnuCompCentroCostoDetEdit.Text = "Nuevo Mov. Actividad de C.C."
      '
      'mnuCompPlanEEFFEdit
      '
      Me.mnuCompPlanEEFFEdit.Index = 9
      Me.mnuCompPlanEEFFEdit.Text = "Nuevo Mov. Flujo de Efectivo"
      '
      'MenuItem6
      '
      Me.MenuItem6.Index = 10
      Me.MenuItem6.Text = "-"
      '
      'mnuDescuento
      '
      Me.mnuDescuento.Index = 11
      Me.mnuDescuento.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAplicarDescuento, Me.mnuAplicarDescuentoConsolidado})
      Me.mnuDescuento.Text = "Aplicar Descuento de Factura(s)"
      '
      'mnuAplicarDescuento
      '
      Me.mnuAplicarDescuento.Index = 0
      Me.mnuAplicarDescuento.Text = "Por Factura"
      '
      'mnuAplicarDescuentoConsolidado
      '
      Me.mnuAplicarDescuentoConsolidado.Index = 1
      Me.mnuAplicarDescuentoConsolidado.Text = "Consolidado"
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox3)
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(752, 414)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
      ExplorerBarGroup1.ContainerHeight = 172
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(8, 132)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(736, 204)
      Me.ebrMain.TabIndex = 12
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.Label1)
      Me.UiGroupBox3.Controls.Add(Me.Label2)
      Me.UiGroupBox3.Controls.Add(Me.txtDebeDif)
      Me.UiGroupBox3.Controls.Add(Me.txtDebe)
      Me.UiGroupBox3.Controls.Add(Me.txtHaber)
      Me.UiGroupBox3.Controls.Add(Me.txtHaberDif)
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(476, 340)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(268, 68)
      Me.UiGroupBox3.TabIndex = 18
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(4, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(68, 16)
      Me.Label1.TabIndex = 191
      Me.Label1.Text = "Diferencia"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(20, 20)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(52, 16)
      Me.Label2.TabIndex = 190
      Me.Label2.Text = "Totales"
      '
      'txtDebeDif
      '
      Me.txtDebeDif.BackColor = System.Drawing.SystemColors.Info
      Me.txtDebeDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDebeDif.FormatString = "##,##0.000"
      Me.txtDebeDif.Location = New System.Drawing.Point(76, 40)
      Me.txtDebeDif.Name = "txtDebeDif"
      Me.txtDebeDif.ReadOnly = True
      Me.txtDebeDif.Size = New System.Drawing.Size(92, 20)
      Me.txtDebeDif.TabIndex = 21
      Me.txtDebeDif.TabStop = False
      Me.txtDebeDif.Text = "0.000"
      Me.txtDebeDif.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDebeDif.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDebeDif.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtDebe
      '
      Me.txtDebe.BackColor = System.Drawing.SystemColors.Info
      Me.txtDebe.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDebe.FormatString = "##,##0.000"
      Me.txtDebe.Location = New System.Drawing.Point(76, 16)
      Me.txtDebe.Name = "txtDebe"
      Me.txtDebe.ReadOnly = True
      Me.txtDebe.Size = New System.Drawing.Size(92, 20)
      Me.txtDebe.TabIndex = 19
      Me.txtDebe.TabStop = False
      Me.txtDebe.Text = "0.000"
      Me.txtDebe.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDebe.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDebe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtHaber
      '
      Me.txtHaber.BackColor = System.Drawing.SystemColors.Info
      Me.txtHaber.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtHaber.FormatString = "##,##0.000"
      Me.txtHaber.Location = New System.Drawing.Point(172, 16)
      Me.txtHaber.Name = "txtHaber"
      Me.txtHaber.ReadOnly = True
      Me.txtHaber.Size = New System.Drawing.Size(92, 20)
      Me.txtHaber.TabIndex = 20
      Me.txtHaber.TabStop = False
      Me.txtHaber.Text = "0.000"
      Me.txtHaber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtHaber.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtHaber.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtHaberDif
      '
      Me.txtHaberDif.BackColor = System.Drawing.SystemColors.Info
      Me.txtHaberDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtHaberDif.FormatString = "##,##0.000"
      Me.txtHaberDif.Location = New System.Drawing.Point(172, 40)
      Me.txtHaberDif.Name = "txtHaberDif"
      Me.txtHaberDif.ReadOnly = True
      Me.txtHaberDif.Size = New System.Drawing.Size(92, 20)
      Me.txtHaberDif.TabIndex = 22
      Me.txtHaberDif.TabStop = False
      Me.txtHaberDif.Text = "0.000"
      Me.txtHaberDif.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtHaberDif.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtHaberDif.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.chkSinFac)
      Me.UiGroupBox2.Controls.Add(Me.txtGlosa)
      Me.UiGroupBox2.Controls.Add(Me.chkConFac)
      Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 340)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(460, 68)
      Me.UiGroupBox2.TabIndex = 14
      Me.UiGroupBox2.Text = "Glosa"
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkSinFac
      '
      Me.chkSinFac.BackColor = System.Drawing.Color.Transparent
      Me.chkSinFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSinFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSinFac.Location = New System.Drawing.Point(60, 0)
      Me.chkSinFac.Name = "chkSinFac"
      Me.chkSinFac.Size = New System.Drawing.Size(28, 16)
      Me.chkSinFac.TabIndex = 15
      Me.chkSinFac.Text = "I"
      Me.chkSinFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtGlosa
      '
      Me.txtGlosa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtGlosa.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtGlosa.Location = New System.Drawing.Point(8, 16)
      Me.txtGlosa.Multiline = True
      Me.txtGlosa.Name = "txtGlosa"
      Me.txtGlosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtGlosa.Size = New System.Drawing.Size(444, 44)
      Me.txtGlosa.TabIndex = 16
      Me.txtGlosa.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtGlosa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'chkConFac
      '
      Me.chkConFac.BackColor = System.Drawing.Color.Transparent
      Me.chkConFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkConFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkConFac.Location = New System.Drawing.Point(100, 0)
      Me.chkConFac.Name = "chkConFac"
      Me.chkConFac.Size = New System.Drawing.Size(28, 16)
      Me.chkConFac.TabIndex = 16
      Me.chkConFac.Text = "F"
      Me.chkConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtPorConcepto)
      Me.UiGroupBox1.Controls.Add(Me.txtEntregadoA)
      Me.UiGroupBox1.Controls.Add(Me.lblPorConcepto)
      Me.UiGroupBox1.Controls.Add(Me.lblEntregadoA)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 64)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(736, 64)
      Me.UiGroupBox1.TabIndex = 9
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtPorConcepto
      '
      Me.txtPorConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPorConcepto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPorConcepto.Location = New System.Drawing.Point(144, 36)
      Me.txtPorConcepto.MaxLength = 1000
      Me.txtPorConcepto.Multiline = True
      Me.txtPorConcepto.Name = "txtPorConcepto"
      Me.txtPorConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtPorConcepto.Size = New System.Drawing.Size(584, 20)
      Me.txtPorConcepto.TabIndex = 11
      Me.txtPorConcepto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPorConcepto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEntregadoA
      '
      Me.txtEntregadoA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtEntregadoA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEntregadoA.Location = New System.Drawing.Point(144, 12)
      Me.txtEntregadoA.MaxLength = 1000
      Me.txtEntregadoA.Multiline = True
      Me.txtEntregadoA.Name = "txtEntregadoA"
      Me.txtEntregadoA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtEntregadoA.Size = New System.Drawing.Size(584, 20)
      Me.txtEntregadoA.TabIndex = 10
      Me.txtEntregadoA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEntregadoA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblPorConcepto
      '
      Me.lblPorConcepto.BackColor = System.Drawing.Color.Transparent
      Me.lblPorConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPorConcepto.Location = New System.Drawing.Point(8, 40)
      Me.lblPorConcepto.Name = "lblPorConcepto"
      Me.lblPorConcepto.Size = New System.Drawing.Size(132, 16)
      Me.lblPorConcepto.TabIndex = 191
      '
      'lblEntregadoA
      '
      Me.lblEntregadoA.BackColor = System.Drawing.Color.Transparent
      Me.lblEntregadoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblEntregadoA.Location = New System.Drawing.Point(8, 16)
      Me.lblEntregadoA.Name = "lblEntregadoA"
      Me.lblEntregadoA.Size = New System.Drawing.Size(132, 16)
      Me.lblEntregadoA.TabIndex = 190
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.cboTipoAsiento)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.cboTipoComp)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.txtCompNro)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.txtGestion)
      Me.grpMain.Controls.Add(Me.txtCompId)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Controls.Add(Me.Label14)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(736, 64)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 40)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(52, 16)
      Me.Label3.TabIndex = 203
      Me.Label3.Text = "Asiento"
      '
      'cboTipoAsiento
      '
      Me.cboTipoAsiento.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoAsiento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAsiento.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAsiento.Location = New System.Drawing.Point(60, 36)
      Me.cboTipoAsiento.Name = "cboTipoAsiento"
      Me.cboTipoAsiento.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoAsiento.Size = New System.Drawing.Size(100, 20)
      Me.cboTipoAsiento.TabIndex = 5
      Me.cboTipoAsiento.TabStop = False
      Me.cboTipoAsiento.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(60, 36)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(100, 20)
      Me.cboEstado.TabIndex = 5
      Me.cboEstado.TabStop = False
      Me.cboEstado.Visible = False
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboTipoComp
      '
      Me.cboTipoComp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboTipoComp.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoComp.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoComp.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoComp.Location = New System.Drawing.Point(628, 12)
      Me.cboTipoComp.Name = "cboTipoComp"
      Me.cboTipoComp.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoComp.Size = New System.Drawing.Size(100, 20)
      Me.cboTipoComp.TabIndex = 4
      Me.cboTipoComp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(448, 12)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(100, 20)
      Me.cboMoneda.TabIndex = 3
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtCompNro
      '
      Me.txtCompNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCompNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompNro.FormatString = "########"
      Me.txtCompNro.Location = New System.Drawing.Point(628, 36)
      Me.txtCompNro.Name = "txtCompNro"
      Me.txtCompNro.ReadOnly = True
      Me.txtCompNro.Size = New System.Drawing.Size(100, 20)
      Me.txtCompNro.TabIndex = 8
      Me.txtCompNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompNro.Value = 0
      Me.txtCompNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtCompNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(448, 36)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
      Me.txtTipoCambio.TabIndex = 7
      Me.txtTipoCambio.Text = "0.000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'dtpFecha
      '
      Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFecha.DropDownCalendar.FirstMonth = New Date(2008, 3, 1, 0, 0, 0, 0)
      Me.dtpFecha.DropDownCalendar.Name = ""
      Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFecha.Location = New System.Drawing.Point(244, 36)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
      Me.dtpFecha.TabIndex = 6
      Me.dtpFecha.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtGestion
      '
      Me.txtGestion.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.txtGestion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtGestion.FormatString = "####"
      Me.txtGestion.Location = New System.Drawing.Point(244, 12)
      Me.txtGestion.MaxLength = 4
      Me.txtGestion.Name = "txtGestion"
      Me.txtGestion.ReadOnly = True
      Me.txtGestion.Size = New System.Drawing.Size(100, 20)
      Me.txtGestion.TabIndex = 2
      Me.txtGestion.TabStop = False
      Me.txtGestion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtGestion.Value = 0
      Me.txtGestion.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtGestion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCompId
      '
      Me.txtCompId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompId.Location = New System.Drawing.Point(60, 12)
      Me.txtCompId.Name = "txtCompId"
      Me.txtCompId.ReadOnly = True
      Me.txtCompId.Size = New System.Drawing.Size(100, 20)
      Me.txtCompId.TabIndex = 1
      Me.txtCompId.TabStop = False
      Me.txtCompId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 40)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(46, 16)
      Me.Label6.TabIndex = 201
      Me.Label6.Text = "Estado"
      Me.Label6.Visible = False
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(36, 16)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(20, 16)
      Me.Label7.TabIndex = 200
      Me.Label7.Text = "ID"
      '
      'Label11
      '
      Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(364, 40)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(80, 16)
      Me.Label11.TabIndex = 199
      Me.Label11.Text = "Tipo Cambio"
      '
      'Label12
      '
      Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(572, 40)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(52, 16)
      Me.Label12.TabIndex = 198
      Me.Label12.Text = "Número"
      '
      'Label14
      '
      Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(188, 16)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(52, 16)
      Me.Label14.TabIndex = 197
      Me.Label14.Text = "Gestión"
      '
      'Label15
      '
      Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(392, 16)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(52, 16)
      Me.Label15.TabIndex = 196
      Me.Label15.Text = "Moneda"
      '
      'Label16
      '
      Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(196, 40)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(44, 16)
      Me.Label16.TabIndex = 195
      Me.Label16.Text = "Fecha"
      '
      'Label17
      '
      Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(588, 16)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(34, 16)
      Me.Label17.TabIndex = 194
      Me.Label17.Text = "Tipo"
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
      Me.ilsMain.Images.SetKeyName(7, "1444682493_txt2.ico")
      Me.ilsMain.Images.SetKeyName(8, "Opciones1.png")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.ToolBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.SaveTemp, Me.Save, Me.Anular, Me.Listado, Me.Factura, Me.Cheque, Me.Sucursal, Me.CentroCosto, Me.PlanAdd, Me.Print, Me.Exit2, Me.FacturaAgru, Me.Bloquear, Me.CentroCostoDet, Me.ExportTXT, Me.Reorden, Me.FlujoEfectivo})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("31b20525-af8f-4590-ac5d-e3db09d50923")
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
      Me.ToolBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.SaveTemp1, Me.Separator1, Me.Save1, Me.Separator2, Me.Bloquear1, Me.Separator6, Me.Anular1, Me.Separator3, Me.Reorden1, Me.Separator12, Me.Listado1, Me.Separator4, Me.ExportTXT1, Me.Separator11, Me.Print1, Me.Separator5, Me.Exit1})
      Me.ToolBar1.Key = "ToolBar"
      Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
      Me.ToolBar1.Name = "ToolBar1"
      Me.ToolBar1.RowIndex = 0
      Me.ToolBar1.Size = New System.Drawing.Size(712, 28)
      Me.ToolBar1.Text = "ToolBar"
      '
      'SaveTemp1
      '
      Me.SaveTemp1.Key = "SaveTemp"
      Me.SaveTemp1.Name = "SaveTemp1"
      Me.SaveTemp1.ToolTipText = "Guardar en Forma Pendiente"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      Me.Save1.ToolTipText = "Guardar"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Bloquear1
      '
      Me.Bloquear1.Key = "Bloquear"
      Me.Bloquear1.Name = "Bloquear1"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'Anular1
      '
      Me.Anular1.Key = "Anular"
      Me.Anular1.Name = "Anular1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Reorden1
      '
      Me.Reorden1.Key = "Reorden"
      Me.Reorden1.Name = "Reorden1"
      '
      'Separator12
      '
      Me.Separator12.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator12.Key = "Separator"
      Me.Separator12.Name = "Separator12"
      '
      'Listado1
      '
      Me.Listado1.Key = "Listado"
      Me.Listado1.Name = "Listado1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'ExportTXT1
      '
      Me.ExportTXT1.Key = "ExportTXT"
      Me.ExportTXT1.Name = "ExportTXT1"
      '
      'Separator11
      '
      Me.Separator11.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator11.Key = "Separator"
      Me.Separator11.Name = "Separator11"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'SaveTemp
      '
      Me.SaveTemp.ImageIndex = 0
      Me.SaveTemp.Key = "SaveTemp"
      Me.SaveTemp.Name = "SaveTemp"
      Me.SaveTemp.Text = "Pendiente"
      Me.SaveTemp.ToolTipText = "Guardar en Forma Pendiente"
      '
      'Save
      '
      Me.Save.ImageIndex = 1
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.Text = "Guardar"
      Me.Save.ToolTipText = "Guardar"
      '
      'Anular
      '
      Me.Anular.ImageIndex = 2
      Me.Anular.Key = "Anular"
      Me.Anular.Name = "Anular"
      Me.Anular.Text = "Anular"
      '
      'Listado
      '
      Me.Listado.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.PlanAdd1, Me.Separator7, Me.Factura1, Me.FacturaAgru1, Me.Separator8, Me.Separator9, Me.CentroCosto1, Me.CentroCostoDet1, Me.Separator10, Me.Cheque1, Me.Sucursal1, Me.Separator13, Me.FlujoEfectivo1})
      Me.Listado.ImageIndex = 3
      Me.Listado.Key = "Listado"
      Me.Listado.Name = "Listado"
      Me.Listado.Text = "Listado"
      '
      'PlanAdd1
      '
      Me.PlanAdd1.Key = "PlanAdd"
      Me.PlanAdd1.Name = "PlanAdd1"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
      '
      'Factura1
      '
      Me.Factura1.Key = "Factura"
      Me.Factura1.Name = "Factura1"
      '
      'FacturaAgru1
      '
      Me.FacturaAgru1.Key = "FacturaAgru"
      Me.FacturaAgru1.Name = "FacturaAgru1"
      '
      'Separator8
      '
      Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator8.Key = "Separator"
      Me.Separator8.Name = "Separator8"
      '
      'Separator9
      '
      Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator9.Key = "Separator"
      Me.Separator9.Name = "Separator9"
      '
      'CentroCosto1
      '
      Me.CentroCosto1.Key = "CentroCosto"
      Me.CentroCosto1.Name = "CentroCosto1"
      '
      'CentroCostoDet1
      '
      Me.CentroCostoDet1.Key = "CentroCostoDet"
      Me.CentroCostoDet1.Name = "CentroCostoDet1"
      '
      'Separator10
      '
      Me.Separator10.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator10.Key = "Separator"
      Me.Separator10.Name = "Separator10"
      '
      'Cheque1
      '
      Me.Cheque1.Key = "Cheque"
      Me.Cheque1.Name = "Cheque1"
      '
      'Sucursal1
      '
      Me.Sucursal1.Key = "Sucursal"
      Me.Sucursal1.Name = "Sucursal1"
      '
      'Separator13
      '
      Me.Separator13.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator13.Key = "Separator"
      Me.Separator13.Name = "Separator13"
      '
      'FlujoEfectivo1
      '
      Me.FlujoEfectivo1.Key = "FlujoEfectivo"
      Me.FlujoEfectivo1.Name = "FlujoEfectivo1"
      '
      'Factura
      '
      Me.Factura.Key = "Factura"
      Me.Factura.Name = "Factura"
      Me.Factura.Text = "Facturas"
      '
      'Cheque
      '
      Me.Cheque.Key = "Cheque"
      Me.Cheque.Name = "Cheque"
      Me.Cheque.Text = "Cheques"
      '
      'Sucursal
      '
      Me.Sucursal.Key = "Sucursal"
      Me.Sucursal.Name = "Sucursal"
      Me.Sucursal.Text = "Sucursales"
      '
      'CentroCosto
      '
      Me.CentroCosto.Key = "CentroCosto"
      Me.CentroCosto.Name = "CentroCosto"
      Me.CentroCosto.Text = "Centros de Costo"
      '
      'PlanAdd
      '
      Me.PlanAdd.Key = "PlanAdd"
      Me.PlanAdd.Name = "PlanAdd"
      Me.PlanAdd.Text = "Analíticos Adicionales"
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
      'FacturaAgru
      '
      Me.FacturaAgru.Key = "FacturaAgru"
      Me.FacturaAgru.Name = "FacturaAgru"
      Me.FacturaAgru.Text = "Facturas Agrupadas"
      '
      'Bloquear
      '
      Me.Bloquear.ImageIndex = 6
      Me.Bloquear.Key = "Bloquear"
      Me.Bloquear.Name = "Bloquear"
      Me.Bloquear.Text = "Bloquear"
      '
      'CentroCostoDet
      '
      Me.CentroCostoDet.Key = "CentroCostoDet"
      Me.CentroCostoDet.Name = "CentroCostoDet"
      Me.CentroCostoDet.Text = "Actividades de C.C."
      '
      'ExportTXT
      '
      Me.ExportTXT.ImageIndex = 7
      Me.ExportTXT.Key = "ExportTXT"
      Me.ExportTXT.Name = "ExportTXT"
      Me.ExportTXT.Text = "Texto"
      Me.ExportTXT.ToolTipText = "Exportar a Formato Texto"
      '
      'Reorden
      '
      Me.Reorden.ImageIndex = 8
      Me.Reorden.Key = "Reorden"
      Me.Reorden.Name = "Reorden"
      Me.Reorden.Text = "Reordenar"
      '
      'FlujoEfectivo
      '
      Me.FlujoEfectivo.Key = "FlujoEfectivo"
      Me.FlujoEfectivo.Name = "FlujoEfectivo"
      Me.FlujoEfectivo.Text = "Flujos de Efectivo"
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
      'frmCompEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MinimizeBox = False
      Me.Name = "frmCompEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Comprobante Edit"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      Me.UiGroupBox3.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).EndInit()
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
         Case "SaveTemp"
            oTipoOperacion = numTipoOperacion.GUARDAR
            If DataSave(13) Then
               txtCompId.Text = moComp.CompId
               mlngID = moComp.CompId
               mlngCompNro = moComp.CompNro
               mboolChanged = True
               mboolNew = False
               cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

               If MessageBox.Show("Comprobante Guardado en Estado Pendiente" + vbCrLf + "¿Quiere Salir del Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Me.Close()
               End If
            End If

         Case "Save"
            txtCompId.Focus()

            If mboolEditGrid Then
               Dim strMensaje As String
               mboolITF = False
               If ListPosition(cboTipoAsiento, cboTipoAsiento.SelectedIndex) = clsTipoAsiento.OPERATIVO Then
                  If CompITFCheck(strMensaje) Then
                     If MessageBox.Show("A las Siguientes Cuentas se Aplica el Impuesto a las Transacciones Financieras" & vbCrLf & vbCrLf & strMensaje & vbCrLf & "¿Desea Aplicar I.T.F. a las Mismas?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        mboolITF = True

                        If moComp.PorITF <> clsAppInfo.ITF And Not mboolAdding Then
                           If MessageBox.Show("El Impuesto a las Transacciones Financieras en Sistema a cambiado" & vbCrLf & vbCrLf & "Actual ITF: " & ToDecStrDos(moComp.PorITF * 100) & vbCrLf & "Nuevo ITF : " & ToDecStrDos(clsAppInfo.ITF * 100) & vbCrLf & vbCrLf & "¿Desea aplicar el nuevo valor del ITF a este Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                              moComp.PorITF = clsAppInfo.ITF
                           End If
                        End If

                        If clsAppInfo.ExigirEEFF Then
                           Call frmCompPlanEEFFSelectLoad()
                        End If
                     End If
                  End If

                  If clsAppInfo.AplicarDescuento Then
                     If ExisteFacturaconDescuento(moComp.CompId) Then
                        If MessageBox.Show("Desea Aplicar IVA a los Descuentos de Facturas?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                           mboolAplicarImpuestoDescuento = True
                        End If
                     End If
                  End If
               End If
            End If

            If DataSave() Then
               If mboolEditGrid Then
                  mboolEditGrid = False
                  Call grdMainLoad()
                  Call CompSaldoUpdate(moComp.CompId)
               End If

               cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
               cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

               mlngID = moComp.CompId
               mlngCompNro = moComp.CompNro
               mboolChanged = True

               Me.Close()
            End If

         Case "Factura"
            Call frmFacturaLoad()

         Case "FacturaAgru"
            Call frmFacturaAgruLoad()

         Case "Cheque"
            Call frmCompChequeLoad()

         Case "CentroCosto"
            Call frmCompCentroCostoLoad()

         Case "CentroCostoDet"
            Call frmCompCentroCostoDetLoad()

         Case "Sucursal"
            Call frmCompSucursalLoad()

         Case "PlanAdd"
            Call frmCompPlanAddLoad()

         Case "FlujoEfectivo"
            Call frmCompPlanEEFFLoad()

         Case "Bloquear"
            If moComp.EstadoId = 11 Then
               If MessageBox.Show("¿Realmente quiere Bloquear el Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                  If DataSave(10) Then
                     mlngID = moComp.CompId
                     mboolChanged = True

                     mboolAdding = False
                     mboolEditing = False

                     If MessageBox.Show("Comprobante Bloqueado" + vbCrLf + "¿Quiere Salir del Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Me.Close()
                     Else
                        cdmMain.Commands.Item("SaveTemp").Enabled = Janus.Windows.UI.InheritableBoolean.False
                        cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
                        cdmMain.Commands.Item("Bloquear").Enabled = Janus.Windows.UI.InheritableBoolean.False
                        cdmMain.Commands.Item("Reorden").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     End If
                  End If
               End If
            Else
               MessageBox.Show("Comprobante Fuera de Balance", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "Anular"
            If MessageBox.Show("¿Realmente quiere Anular el Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

               If DataSave(12) Then
                  mlngID = moComp.CompId
                  mboolChanged = True

                  mboolAdding = False
                  mboolEditing = False

                  If MessageBox.Show("Comprobante Anulado de Forma Permanente" + vbCrLf + "¿Quiere Salir del Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     Me.Close()
                  Else
                     cdmMain.Commands.Item("SaveTemp").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     cdmMain.Commands.Item("Bloquear").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
                     cdmMain.Commands.Item("Reorden").Enabled = Janus.Windows.UI.InheritableBoolean.False
                  End If
               End If
            End If

         Case "Reorden"
            Call grdMainReordenar()

         Case "ExportTXT"
            Call ExportToTXT()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ComboLoad()
      If Not mboolAdding Then
         Call FormShow()

         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta Comprobante"
         ElseIf OperaFechaHabil(ToDate(dtpFecha.Value)) Then
            Call HeaderReadOnly()
            Me.Text = "Editar Comprobante"
         Else
            MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mboolEditing = False
            Call DataReadOnly()
            Me.Text = "Consulta Comprobante"
         End If

      Else
         Me.Text = "Nuevo Comprobante"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      'Bitacora
      oTipoOperacion = 0

      txtTipoCambio.FormatString = DecimalMask()
      txtDebe.FormatString = DecimalMask()
      txtHaber.FormatString = DecimalMask()
      txtDebeDif.FormatString = DecimalMask()
      txtHaberDif.FormatString = DecimalMask()

      If clsAppInfo.AplicarDescuento Then
         mnuDescuento.Visible = True
         MenuItem6.Visible = True
      Else
         mnuDescuento.Visible = False
         MenuItem6.Visible = False
      End If

      moCompDet = New clsCompDet(clsAppInfo.ConnectString)

      If Not clsAppInfo.ExigirEEFF Then
         mnuCompPlanEEFFEdit.Visible = False
         FlujoEfectivo.Visible = Janus.Windows.UI.InheritableBoolean.False
      End If
   End Sub

   Private Sub ComboLoad()
      Call cboTipoCompLoad()
      Call cboTipoAsientoLoad()
      Call cboMonedaLoad()
      Call cboEstadoLoad()
   End Sub

#Region " ComboLoads "
   Private Sub cboTipoCompLoad()
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoComp.Items.Clear()
      Try
         With oTipoComp
            .SelectFilter = clsTipoComp.SelectFilters.ListBox
            .OrderByFilter = clsTipoComp.OrderByFilters.TipoCompDes

            If .Open() Then
               Do While .Read()
                  If .TipoCompId > 0 Then
                     oItem = New clsListItem(.TipoCompId, .TipoCompDes)

                     cboTipoComp.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oTipoComp.Dispose()
         oItem = Nothing
      End Try
   End Sub

   Private Sub cboTipoAsientoLoad()
      Dim oTipoAsiento As New clsTipoAsiento(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoAsiento.Items.Clear()
      Try
         With oTipoAsiento
            .SelectFilter = clsTipoAsiento.SelectFilters.ListBox

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoAsientoId, .TipoAsientoDes)

                  cboTipoAsiento.Items.Add(oItem)

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oTipoAsiento.Dispose()
         oItem = Nothing
      End Try
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

   Private Sub cboEstadoLoad()
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboEstado.Items.Clear()
      Try
         With oEstado
            .SelectFilter = clsEstado.SelectFilters.ListBox
            .WhereFilter = clsEstado.WhereFilters.TipoId
            .OrderByFilter = clsEstado.OrderByFilters.EstadoDes

            .TipoId = 2
            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.EstadoId, .EstadoDes)

                  cboEstado.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oEstado.Dispose()
         oItem = Nothing
      End Try
   End Sub
#End Region

   Private Sub FormNew()
      mboolAdding = True
      mboolNew = True
      cboMoneda.Select()
      Call DataClear()
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moComp
         txtCompId.Text = ToStr(.CompId)
         Call txtGestionIdLoad(.GestionId)
         dtpFecha.Tag = .Fecha
         dtpFecha.Value = .Fecha
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtTipoCambio.Tag = .TipoCambio
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         cboTipoComp.SelectedIndex = ListFindItem(cboTipoComp, .TipoCompId)
         cboTipoAsiento.SelectedIndex = ListFindItem(cboTipoAsiento, .TipoAsientoId)
         txtCompNro.Text = ToStr(.CompNro)
         txtEntregadoA.Text = ToStr(.EntregadoA)
         txtPorConcepto.Text = ToStr(.PorConcepto)
         chkConFac.Checked = .ConFac
         chkSinFac.Checked = .SinFac
         txtGlosa.Text = ToStr(.Glosa)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         If .EstadoId = clsEstado.PENDIENTE And (mboolAdding Or mboolEditing) Then
            mboolEditGrid = True
         End If

         If Not clsAppInfo.MultipleNro Then
            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If

         If .TipoCompId <> 3 Then
            cboTipoAsiento.ReadOnly = True
         End If

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Comprobante"
               .VMOld.ToShowOpe(clsTipoOpera.CONSULTA)
            End If
         End If
      End With

      Call grdMainLoad()
      mboolNew = False
      mboolShow = False
   End Sub

   Private Sub HeaderReadOnly()
      txtCompId.ReadOnly = True
      txtGestion.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboTipoComp.ReadOnly = True
      cboEstado.ReadOnly = True

      If moComp.EstadoId = 13 Then
         chkConFac.Enabled = True
         chkSinFac.Enabled = True
      Else
         chkConFac.Enabled = False
         chkSinFac.Enabled = False
      End If

      grdMain.Select()

      If moComp.EstadoId = 11 Then
         cdmMain.Commands.Item("SaveTemp").Enabled = Janus.Windows.UI.InheritableBoolean.False
         cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True
      End If
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moComp
         txtCompId.Text = String.Empty
         Call txtGestionIdFind(clsAppInfo.GestionId)
         dtpFecha.Text = .Fecha  'String.Empty
         If .MonedaId = 0 Then
            cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
         Else
            cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         End If
         txtTipoCambio.Text = .TipoCambio 'String.Empty
         cboTipoComp.SelectedIndex = ListFindItem(cboTipoComp, .TipoCompId) '-1
         cboTipoAsiento.SelectedIndex = ListFindItem(cboTipoAsiento, .TipoAsientoId) '0)
         txtCompNro.Text = String.Empty
         txtEntregadoA.Text = .EntregadoA 'String.Empty
         txtPorConcepto.Text = .PorConcepto 'String.Empty
         txtGlosa.Text = .Glosa 'String.Empty
         cboEstado.SelectedIndex = ListFindItem(cboEstado, clsEstado.PENDIENTE)
         cboEstado.ReadOnly = True

         If clsAppInfo.MultipleNro Then
            chkConFac.Checked = False
            chkSinFac.Checked = False
         Else
            chkConFac.Checked = False
            chkSinFac.Checked = True

            chkConFac.Visible = False
            chkSinFac.Visible = False
         End If
         cboTipoAsiento.ReadOnly = True

         cdmMain.Commands.Item("Bloquear").Enabled = Janus.Windows.UI.InheritableBoolean.False
         cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
         cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.False
         cdmMain.Commands.Item("Reorden").Enabled = Janus.Windows.UI.InheritableBoolean.False
         Call grdMainLoad()
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCompId.ReadOnly = True
      txtGestion.ReadOnly = True
      cboMoneda.ReadOnly = True
      cboTipoComp.ReadOnly = True
      cboTipoAsiento.ReadOnly = True
      dtpFecha.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtCompNro.ReadOnly = True
      txtEntregadoA.ReadOnly = True
      txtPorConcepto.ReadOnly = True
      chkConFac.Enabled = False
      chkSinFac.Enabled = False
      txtGlosa.ReadOnly = True
      cboEstado.ReadOnly = True

      grdMain.Select()

      cdmMain.Commands.Item("SaveTemp").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Bloquear").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Reorden").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moComp
         If Not mboolAdding Then
            .CompId = ToLong(txtCompId.Text)
         Else
            .PorIVA = clsAppInfo.IVA
            .PorIT = clsAppInfo.IT
            .PorITF = clsAppInfo.ITF
         End If

         .GestionId = ToLong(txtGestion.Tag)
         .TipoCompId = ListPosition(cboTipoComp, cboTipoComp.SelectedIndex)
         .TipoAsientoId = ListPosition(cboTipoAsiento, cboTipoAsiento.SelectedIndex)
         .CompNro = ToLong(txtCompNro.Text)

         If IsDate(dtpFecha.Text) Then
            .Fecha = ToDate(dtpFecha.Value)
         Else
            .Fecha = ""
         End If

         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .EntregadoA = ToStr(txtEntregadoA.Text)
         .PorConcepto = ToStr(txtPorConcepto.Text)

         If .MonedaId = 1 Then
            .DebeBs = ToDecimal(txtDebe.Text)
            .HaberBs = ToDecimal(txtHaber.Text)

            If ToDecimal(txtTipoCambio.Text) > 0 Then
               .DebeUs = ToDecimal(.DebeBs / ToDecimal(txtTipoCambio.Text))
               .HaberUs = ToDecimal(.HaberBs / ToDecimal(txtTipoCambio.Text))
            End If

         ElseIf .MonedaId = 2 Then
            .DebeUs = ToDecimal(txtDebe.Text)
            .HaberUs = ToDecimal(txtHaber.Text)
            .DebeBs = ToDecimal(.DebeUs * ToDecimal(txtTipoCambio.Text))
            .HaberBs = ToDecimal(.HaberUs * ToDecimal(txtTipoCambio.Text))
         End If

         .ConFac = ToBoolean(chkConFac.Checked)
         .SinFac = ToBoolean(chkSinFac.Checked)
         '.Automatico = 0
         .Glosa = ToStr(txtGlosa.Text)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)

            If mboolNew Then
               .VMNew.TipoOpera = clsTipoOpera.NUEVO
            Else
               .VMNew.TipoOpera = clsTipoOpera.MODIFICA
            End If
         End If
      End With
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMessage As String

      FormCheck = True

      If moDataSet.Tables(moCompDet.TableName).Rows.Count = 0 Then
         FormCheck = False
         Throw New Exception("Comprobante Sin Asientos Contables")
      End If

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         FormCheck = False
         Throw New Exception("Fecha no Corresponde a la Gestion en Uso")

      ElseIf Not OperaFechaHabil(ToDate(dtpFecha.Value)) Then
         FormCheck = False
         Throw New Exception("Fecha de Operación Inhábil para el Usuario")
      End If

      If cboTipoAsiento.SelectedIndex = -1 Then
         FormCheck = False
         Throw New Exception("Tipo de Asiento Inválido")
      End If

      If moComp.CompNro <= 0 Then
         If Not mboolNroAuto Then
            FormCheck = False
            Throw New Exception("Número de Comprobante Inválido")
         End If
      End If

      If Not ValidarFecha(dtpFecha.Value, dtpFecha.Tag) Then
         FormCheck = False
         Throw New Exception("Debe Seleccionar una Fecha dentro del Mes correspondiente a la Numeración del Comprobante")
      End If

      If (Not chkConFac.Checked) And (Not chkSinFac.Checked) Then
         FormCheck = False
         Throw New Exception("Valores Inválidos en (I o F)")
      End If

      If (ToDecimal(txtDebeDif.Text) <> 0) Or (ToDecimal(txtHaberDif.Text) <> 0) Then
         FormCheck = False
         Throw New Exception("Comprobante Fuera de Balance")
      End If

      If moComp.Automatico = 0 Then
         If Not FacturaCheck(moComp.CompId) Then
            FormCheck = False
            Throw New Exception("Importe Base de Factura(s) no Coincide con el Valor de la(s) Cuenta(s)")
         End If

         If Not FacturaAgruCheck(moComp.CompId) Then
            FormCheck = False
            Throw New Exception("Monto de Factura(s) Agrupada(s) no Coincide con el Valor de la Cuenta")
         End If

         If TieneRetencionDiferente() Then
            FormCheck = False
            Throw New Exception("Existen Tipos Diferentes de Rentención (Asume Empresa / Asume Proveedor)" & vbCrLf & strMessage)
         End If

         If Not CompPlanAddCheck(strMessage) Then
            FormCheck = False
            Throw New Exception("Monto Inválido en Analíticos Adicionales de las Siguientes Cuentas" & vbCrLf & strMessage)
         End If

         If Not CompCentroCostoDetCheck(strMessage) Then
            FormCheck = False
            Throw New Exception("Monto Inválido en Actividades de Centros de Costo de las Siguientes Cuentas" & vbCrLf & strMessage)
         End If

         If clsAppInfo.AplicarDescuento Then
            If Not FacturaDescuentoCheck() Then
               FormCheck = False
               Throw New Exception("El valor de la(s) cuenta(s) de Descuento no coincide con el Monto de Descuento de Facturas" & vbCrLf)
            End If
         End If

         If clsAppInfo.ExigirEEFF Then
            If Not CompPlanEEFFCheck(strMessage) Then
               FormCheck = False
               Throw New Exception("Monto Inválido en Flujos de Efectivo de las Siguientes Cuentas Disponibles" & vbCrLf & strMessage)
            End If

            If mboolITF Then
               Dim lngcount As Long = mdicListaPlanEEFFporITF.AsEnumerable.Where(Function(f) f.Value = 0).ToList.Count
               If lngcount > 0 Then
                  FormCheck = False
                  Throw New Exception("Monto Inválido en Flujos de Efectivo, no selecciono cuentas de Flujo para el monto de I.T.F." & vbCrLf & strMessage)
               End If
            End If
         End If

         If clsAppInfo.ValidarSaldoCajaBanco Then
            If Not ValidarSaldoCajaBancoCheck(strMessage) Then
               FormCheck = False
               Throw New Exception("Saldo Insuficiente en la(s) sgte(s) cuenta(s) Disponible(s): " & vbCrLf & strMessage)
            End If
         End If
      End If
   End Function

   Private Sub CloneVM(ByRef oVM As clsCompVM)
      oVM = New clsCompVM

      If clsAppInfo.RegistrarBitacora And (Not mboolNew Or oTipoOperacion = numTipoOperacion.GUARDAR) Then
         With oVM
            .CompId = moComp.CompId
            .TipoCompId = moComp.TipoCompId
            .TipoCompDes = cboTipoComp.Text
            .CompNro = moComp.CompNro
            .Fecha = dtpFecha.Text
            .MonedaId = moComp.MonedaId
            .MonedaDes = cboMoneda.Text
            .TipoCambio = moComp.TipoCambio
            .EntregadoA = moComp.EntregadoA
            .PorConcepto = moComp.PorConcepto
            .DebeBs = moComp.DebeBs
            .HaberBs = moComp.HaberBs
            .DebeUs = moComp.DebeUs
            .HaberUs = moComp.HaberUs
            .PorIVA = moComp.PorIVA
            .PorIT = moComp.PorIT
            .PorITF = moComp.PorITF
            .ConFac = ToByte(chkConFac.Checked)
            .SinFac = ToByte(chkSinFac.Checked)
            .Automatico = moComp.Automatico
            .TipoAsientoId = moComp.TipoAsientoId
            .TipoAsientoDes = cboTipoAsiento.Text
            .Glosa = moComp.Glosa
            .TipoNotaId = moComp.TipoNotaId
            .NotaNro = moComp.NotaNro
            .EstadoId = moComp.EstadoId
            .EstadoDes = ToStr(cboEstado.Text)

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Function DataSave(ByVal lngEstadoId As Long) As Boolean
      Try
         Call DataMove()
         moComp.EstadoId = lngEstadoId
         moComp.VMNew.EstadoId = lngEstadoId
         If mboolAdding Then
            If mboolNroAuto Then
               moComp.CompNro = 0
            Else
               moComp.CompNro = ToLong(txtCompNro.Text)
            End If
            moComp.VMNew.CompNro = moComp.CompNro
            If moComp.Validate Then
               If GestionIdFind(ToDate(dtpFecha.Value)) = clsAppInfo.GestionId Then
                  If OperaFechaHabil(ToDate(dtpFecha.Value)) Then
                     If DataAdd() Then
                        mlngID = moComp.CompId
                        mboolChanged = True
                        DataSave = True
                     End If
                  Else
                     MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Fecha no Corresponde a la Gestion Seleccionada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         Else
            If DataUpdate() Then
               If UpdateCompDetTemp(moComp.CompId, lngEstadoId) Then
                  If UpdateFacturaTemp(moComp.CompId, lngEstadoId) Then
                     If UpdateCompChequeTemp(moComp.CompId, lngEstadoId) Then
                        If UpdateCompPlanAddTemp(moComp.CompId, lngEstadoId) Then
                           If UpdateCompCentroCostoDetTemp(moComp.CompId, lngEstadoId) Then
                              If UpdateCompPlanEEFFTemp(moComp.CompId, lngEstadoId) Then
                                 DataSave = True
                                 cboEstado.SelectedIndex = ListFindItem(cboEstado, lngEstadoId)
                              End If
                           End If
                        End If
                     End If
                  End If
               End If
            End If
         End If

      Catch exp As Exception
         oTipoOperacion = 0
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End Try
   End Function

   Private Function DataSave() As Boolean
      Try
         oTipoOperacion = numTipoOperacion.GUARDAR
         Call DataMove()

         If FormCheck() Then
            If mboolNroAuto Then
               If mboolNroAutoGestion Then
                  If moComp.CompNro = 0 Then
                     moComp.CompNro = CompNroNext(moComp.TipoCompId, moComp.GestionId)
                  End If
               Else
                  If moComp.CompNro = 0 Then
                     moComp.CompNro = CompNroMesNext(moComp.TipoCompId, moComp.GestionId, dtpFecha.Value.Month)
                  End If
               End If
            End If

            Dim lngEstadoId = 11
            Call esBloqueoAutomatico(moComp.TipoCompId, lngEstadoId)

            moComp.EstadoId = lngEstadoId
            moComp.VMNew.EstadoId = moComp.EstadoId
            moComp.VMNew.CompNro = moComp.CompNro

            If mboolAdding Then
               DataSave = DataAdd()
            Else
               If DataUpdate() Then
                  If CompDetUpdate(moComp.CompId, lngEstadoId) Then
                     txtCompNro.Text = ToStr(moComp.CompNro)
                     cboEstado.SelectedIndex = ListFindItem(cboEstado, lngEstadoId)

                     If UpdateCompDetTemp(moComp.CompId, lngEstadoId) Then
                        If UpdateFacturaTemp(moComp.CompId, lngEstadoId) Then
                           If UpdateCompChequeTemp(moComp.CompId, lngEstadoId) Then
                              If UpdateCompPlanAddTemp(moComp.CompId, lngEstadoId) Then
                                 If UpdateCompCentroCostoDetTemp(moComp.CompId, lngEstadoId) Then
                                    If UpdateCompPlanEEFFTemp(moComp.CompId, lngEstadoId) Then

                                       DataSave = True
                                    End If
                                 End If
                              End If
                           End If
                        End If
                     End If
                  Else
                     DataSave = False
                  End If
               Else
                  DataSave = False
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         oTipoOperacion = 0
         DataSave = False
      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moComp.Insert() Then
            moComp.CloseConection()
            mboolAdding = False
            DataAdd = True
            Call CloneVM(moComp.VMOld)
         End If

      Catch exp As Exception
         Throw exp
      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moComp.Update() Then
            moComp.CloseConection()
            DataUpdate = True
            Call CloneVM(moComp.VMOld)
         End If

      Catch exp As Exception
         Throw exp
      End Try
   End Function

   Private Sub frmCompEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               txtCompId.Focus()

               If mboolEditGrid Then
                  Dim strMensaje As String
                  mboolITF = False
                  If ListPosition(cboTipoAsiento, cboTipoAsiento.SelectedIndex) = clsTipoAsiento.OPERATIVO Then
                     If CompITFCheck(strMensaje) Then
                        If MessageBox.Show("A las Siguientes Cuentas se Aplica el Impuesto a las Transacciones Financieras" & vbCrLf & vbCrLf & strMensaje & vbCrLf & "¿Desea Aplicar I.T.F. a las Mismas?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                           mboolITF = True

                           If moComp.PorITF <> clsAppInfo.ITF And Not mboolAdding Then
                              If MessageBox.Show("El Impuesto a las Transacciones Financieras en Sistema a cambiado" & vbCrLf & vbCrLf & "Actual ITF: " & ToDecStrDos(moComp.PorITF * 100) & vbCrLf & "Nuevo ITF : " & ToDecStrDos(clsAppInfo.ITF * 100) & vbCrLf & vbCrLf & "¿Desea aplicar el nuevo valor del ITF a este Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                 moComp.PorITF = clsAppInfo.ITF
                              End If
                           End If

                           If clsAppInfo.ExigirEEFF Then
                              Call frmCompPlanEEFFSelectLoad()
                           End If
                        End If
                     End If

                     If clsAppInfo.AplicarDescuento Then
                        If ExisteFacturaconDescuento(moComp.CompId) Then
                           If MessageBox.Show("Desea Aplicar IVA a los Descuentos de Facturas?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                              mboolAplicarImpuestoDescuento = True
                           End If
                        End If
                     End If
                  End If
               End If

               If DataSave() Then
                  If mboolEditGrid Then
                     mboolEditGrid = False
                     Call grdMainLoad()
                     Call CompSaldoUpdate(moComp.CompId)
                  End If

                  cdmMain.Commands.Item("Anular").Enabled = Janus.Windows.UI.InheritableBoolean.True
                  cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.True

                  mlngID = moComp.CompId
                  mlngCompNro = moComp.CompNro
                  mboolChanged = True

                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            e.Handled = True
            If ToBoolean(moComp.Automatico) = 0 Then
               Call grdMainFormNew()
            End If

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            e.Handled = True
            If ToBoolean(moComp.Automatico) = 0 Then
               Call grdMainDataEdit()
            End If

         ElseIf (e.KeyCode = Keys.Delete) And (e.Shift = True) Then
            e.Handled = True
            If ToBoolean(moComp.Automatico) = 0 Then
               Call grdMainDataDelete()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            e.Handled = True
            Me.Close()
         End If
      End If

   End Sub

   Private Sub frmCompEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call DataDelete()

      moComp.Dispose()
      moCompDet.Dispose()

      Call ClearMemory()
   End Sub

   Private Function CompITFCheck(ByRef strMessage As String) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim strPlanDes As String
      Dim strDes As String
      Try
         strMessage = ""

         mdicListaPlanEEFFporITF = New Dictionary(Of String, Long)

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId

            If .Open Then
               Do While .Read()
                  If .Automatico = 0 Then
                     If TieneITF(.PlanId, strPlanDes) Then
                        strMessage &= strPlanDes & vbCrLf

                        strDes = "" & .PlanId & "," & .CentroCostoId & "," & .SucursalId
                        If Not mdicListaPlanEEFFporITF.ContainsKey(strDes) Then
                           mdicListaPlanEEFFporITF.Add(strDes, 0)
                        End If
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         If strMessage = "" Then
            CompITFCheck = False
         Else
            CompITFCheck = True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Sub frmFacturaLoad()
      Dim frm As New frmCompFactura

      With frm
         .NewRecord = mboolAdding
         .Editing = mboolEditing
         .NuevoComprobante = mboolNew
         .EmpresaId = moComp.EmpresaId
         .CompId = moComp.CompId
         .GestionId = moComp.GestionId
         .TipoCompId = moComp.TipoCompId
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .Fecha = ToDateDMY(dtpFecha.Value)

         If .TipoCompId = 3 Then
            If EsIngreso() Then
               .TipoFacturaId = 1

            ElseIf EsEgreso() Then
               .TipoFacturaId = 2

            Else
               .TipoFacturaId = TipoFacturaIdFind(moComp.CompId)
            End If

         Else
            .TipoFacturaId = moComp.TipoCompId
         End If

         .ShowDialog()

         If frm.Changed Then
            mboolEditGrid = True
            Call DataSave(13)
            Call grdMainLoad()
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub frmCompChequeLoad()
      Dim frm As New frmCompCheque

      With frm
         .NewRecord = mboolAdding
         .Editing = mboolEditing
         .NuevoComprobante = mboolNew
         .EmpresaId = moComp.EmpresaId
         .CompId = moComp.CompId

         .ShowDialog()

         If frm.Changed Then
            mboolEditGrid = True
            Call DataSave(13)
            Call grdMainLoad()
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub frmCompCentroCostoLoad()
      Dim frm As New frmCompCentroCosto

      With frm
         .NewRecord = mboolAdding
         .Editing = mboolEditing
         .EmpresaId = moComp.EmpresaId
         .CompId = moComp.CompId

         .ShowDialog()
         frm.Dispose()
      End With
   End Sub

   Private Sub frmCompSucursalLoad()
      Dim frm As New frmCompSucursal

      With frm
         .NewRecord = mboolAdding
         .Editing = mboolEditing
         .EmpresaId = moComp.EmpresaId
         .CompId = moComp.CompId

         .ShowDialog()
         frm.Dispose()
      End With
   End Sub

   Private Sub frmFacturaAgruLoad()
      Dim frm As New frmCompFacturaAgru

      With frm
         .NewRecord = mboolAdding
         .Editing = mboolEditing
         .EmpresaId = moComp.EmpresaId
         .CompId = moComp.CompId
         .GestionId = moComp.GestionId
         .TipoCompId = moComp.TipoCompId
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .Fecha = ToDateDMY(dtpFecha.Value)

         .ShowDialog()

         If frm.Changed Then
            mboolEditGrid = True
            Call DataSave(13)
            Call grdMainLoad()
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub frmCompPlanEEFFLoad()
      Dim frm As New frmCompPlanEEFF

      With frm
         .NewRecord = mboolAdding
         .Editing = mboolEditing
         .NuevoComprobante = mboolNew
         .EmpresaId = moComp.EmpresaId
         .CompId = moComp.CompId
         .TipoCambio = moComp.TipoCambio
         .CompMonedaId = moComp.MonedaId
         .CompDetMonto = mdecCompDetMonto

         .ShowDialog()

         If frm.Changed Then
            mboolEditGrid = True
            Call DataSave(13)
            Call grdMainLoad()
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub frmCompPlanAddLoad()
      Dim frm As New frmCompPlanAdd

      With frm
         .NewRecord = mboolAdding
         .Editing = mboolEditing
         .NuevoComprobante = mboolNew
         .EmpresaId = moComp.EmpresaId
         .CompId = moComp.CompId
         .TipoCambio = moComp.TipoCambio
         .CompMonedaId = moComp.MonedaId
         .CompDetMonto = mdecCompDetMonto

         .ShowDialog()

         If frm.Changed Then
            mboolEditGrid = True
            Call DataSave(13)
            Call grdMainLoad()
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub frmCompCentroCostoDetLoad()
      Dim frm As New frmCompCentroCostoDet

      With frm
         .NewRecord = mboolAdding
         .Editing = mboolEditing
         .NuevoComprobante = mboolNew
         .EmpresaId = moComp.EmpresaId
         .CompId = moComp.CompId
         .TipoCambio = moComp.TipoCambio
         .CompMonedaId = moComp.MonedaId
         .CompDetMonto = mdecCompDetMonto

         .ShowDialog()

         If frm.Changed Then
            mboolEditGrid = True
            Call DataSave(13)
            Call grdMainLoad()
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub ExportToTXT()
      Dim strFilename As String
      Dim strLine As String
      Dim lngCorrelativo As Long = 0
      Dim sfd As New SaveFileDialog
      Dim strPlanCta As String

      Try
         sfd.DefaultExt = "txt"
         sfd.Filter = "Text Files (*.txt)|*.txt"
         sfd.FilterIndex = 2
         sfd.RestoreDirectory = True

         If sfd.ShowDialog() = DialogResult.OK Then
            Dim strCabecera As String = "Sueldos" & ConvertMMYYYY(moComp.Fecha) 'Se adiciona aparte Cabecera y Descripcion por la razond de Otros Anticipos difiere Cabecera de Detalle
            Dim strDescripcion As String = "Sueldos"

            If moComp.TipoCompId = clsTipoComp.EGRESO Then
               strCabecera = "Otant" & Format(dtpFecha.Value, "MMyy") & "_" & GetUltimo_NroComp(dtpFecha.Value.Month, moComp.CompNro)
               strDescripcion = moComp.PorConcepto
            End If

            strFilename = sfd.FileName
            Dim file As New System.IO.StreamWriter(strFilename)

            strLine = "C" & ";" & _
                     ConvertDDMMYYYY(moComp.Fecha) & ";" & _
                     ConvertDDMMYYYY(moComp.Fecha) & ";" & _
                     "BO20" & ";" & _
                     strCabecera & ";" & _
                     strCabecera & ";" & _
                     "BOB" & ";;;;;;"

            file.WriteLine(strLine)

            For Each oRow As DataRow In moDataSet.Tables(moCompDet.TableName).Rows
               'If clsAppInfo.PlanDifId <> ToLong(oRow("PlanId")) Then
               If (ToDecimalDos(oRow("Debe")) > 0) Or (ToDecimalDos(oRow("Haber")) > 0) Then
                  strPlanCta = ToStr(oRow("PlanCta"))

                  If Mid$(oRow("PlanCta"), 1, 1) = "5" Then
                     strPlanCta = "4" & Mid$(strPlanCta, 2, strPlanCta.Length - 1)
                  End If

                  strLine = "D" & ";;;;;;;" & _
                           strPlanCta & ";" & _
                           strDescripcion & ConvertMMYYYY(moComp.Fecha) & ";" & _
                           strDescripcion & ConvertMMYYYY(moComp.Fecha) & ";" & _
                           CentroCostoCodFind(oRow("CentroCostoId"), "") & ";" & _
                           "" & ";"

                  If ToDecimal(oRow("Debe")) > 0 Then
                     strLine &= Replace(Replace(ToDecStrDos(oRow("Debe")), ".", ""), ",", ".")

                  ElseIf ToDecimal(oRow("Haber")) > 0 Then
                     strLine &= "-" & Replace(Replace(ToDecStrDos(oRow("Haber")), ".", ""), ",", ".")
                  End If

                  file.WriteLine(strLine)
               End If
               'End If
            Next

            file.Close()

            Dim oComp As New clsComp(clsAppInfo.ConnectString)
            Call CloneVM(oComp.VMNew)
            oComp.VMNew.ToShowOpe(clsTipoOpera.EXPORTAR)

            MessageBox.Show("Se Exporto Exitosamente el Documento de Texto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Function GetUltimo_NroComp(ByVal lngMesId As Long, ByVal lngCompNro As Long) As String
      If lngCompNro > 0 And EsCompNroPorPeriodo(moComp.TipoCompId, moComp.GestionId) Then
         Dim strTexto As String = ToStr(lngCompNro)
         strTexto = strTexto.Substring(ToStr(lngMesId).Length)
         Dim strTextoClone As String = strTexto

         If ToLong(strTexto) > 0 Then
            For Each c In strTextoClone
               If c = "0" Then
                  strTexto = strTexto.Substring(1)
               Else
                  Exit For
               End If
            Next
         Else
            strTexto = "0"
         End If

         Return strTexto
      Else
         Return ToStr(lngCompNro)
      End If
   End Function

   Private Function EsCompNroPorPeriodo(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long) As Boolean
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         EsCompNroPorPeriodo = False

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moComp.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId

            If .Find Then
               If ToBoolean(.NroAuto) Then
                  EsCompNroPorPeriodo = Not ToBoolean(.NroAutoGestion)
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Function

#Region "Reordenar"

   Private Sub grdMainReordenar()
      Dim frm As New frmCompDetOrden

      Try
         If grdMain.RowCount > 0 Then

            With frm
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .CompNro = moComp.CompNro
               .TipoCompId = moComp.TipoCompId
               .TipoCompDes = cboTipoComp.Text
               .DataTable = moDataTable
               .ShowDialog()

               If .Changed Then
                  Call grdMainLoad()
               End If

            End With
         Else

         End If
         frm.Dispose()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

#End Region

#Region " Print "
   Private Function CompParaFirma(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByRef lngTipoHojaId As Long, ByRef lngTipoRespImpId As Long) As String
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompParaFirma = ""

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moComp.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId

            If .Find Then
               CompParaFirma = .Firma
               lngTipoHojaId = .TipoHojaId
               lngTipoRespImpId = .TipoRespImpId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Function

   Public Sub PrintReport()
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moComp.EmpresaId
            .TipoCompId = moComp.TipoCompId
            .GestionId = moComp.GestionId

            If .Find Then
               If .TipoImpresionId = 1 Then 'Gráfica
                  If .EncabezadoPorHoja Then
                     Call PrintReportGraphicEncHoja()
                  Else
                     Call PrintReportGraphic()
                  End If
               ElseIf .TipoImpresionId = 2 Then 'Texto
                  If .EncabezadoPorHoja Then
                     Call PrintReportTextEncHoja()
                  Else
                     Call PrintReportText()
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Sub

   Private Sub PrintReportGraphic()
      Dim rpt As New rptCompEdit
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim lngTipoRespImpId As Long

      Try
         oComp.SelectFilter = clsComp.SelectFilters.Report
         oComp.WhereFilter = clsComp.WhereFilters.Report
         oComp.OrderByFilter = clsComp.OrderByFilters.Report
         oComp.CompId = moComp.CompId

         If oComp.Find Then
            'Dim oDs As New DataDynamics.ActiveReports.DataSources.OleDBDataSource

            'oDs.ConnectionString = clsAppInfo.ConnectString
            'oDs.SQL = oComp.SQL

            'rpt.ds = oDs

            'rpt.ds.ConnectionString = oComp.ConnectionString
            'rpt.ds.SQL = oComp.SQL

            rpt.DataSource = oComp.DataSet.Tables(oComp.TableName).DefaultView

            If moComp.TipoCompId = 1 Then
               rpt.lblTitle.Text = "Comprobante de Ingreso"
               rpt.Document.Name = "Comprobante de Ingreso"

               rpt.lblEntregadoA.Text = "Hemos recibido de:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.lblCompPie.Text = "CI : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

            ElseIf moComp.TipoCompId = 2 Then
               rpt.lblTitle.Text = "Comprobante de Egreso"
               rpt.Document.Name = "Comprobante de Egreso"

               rpt.lblEntregadoA.Text = "Hemos entregado a:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.lblCompPie.Text = "CE : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

            ElseIf moComp.TipoCompId = 3 Then
               rpt.lblTitle.Text = "Comprobante de Traspaso"
               rpt.Document.Name = "Comprobante de Traspaso"

               rpt.lblEntregadoA.Text = "Por concepto de:"
               rpt.lblPorConcepto.Text = ""

               rpt.lblCompPie.Text = "CT : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))
            End If

            rpt.txtFirma.Text = CompParaFirma(moComp.TipoCompId, moComp.GestionId, lngTipoHojaId, lngTipoRespImpId)
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")

            If lngTipoRespImpId = 1 Then
               rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            ElseIf lngTipoRespImpId = 2 Then
               rpt.lblLogin.Text = "Usuario: " + ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("sLastUpdate_id"))
            End If

            'Subreport(PlanEEFF)
            If clsAppInfo.ExigirEEFF Then
               Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

               With oCompPlanEEFF
                  .SelectFilter = clsCompPlanEEFF.SelectFilters.PrintReport
                  .WhereFilter = clsCompPlanEEFF.WhereFilters.PrintReport
                  .OrderByFilter = clsCompPlanEEFF.OrderByFilters.CompPlanEEFFId
                  .CompId = moComp.CompId

                  If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
                     Dim srptPlanEEFF As New srptCompPlanEEFF
                     srptPlanEEFF.DataSource = .DataSet.Tables(.TableName).DefaultView
                     rpt.srptCompEEFF.Report = srptPlanEEFF
                  End If
               End With
            End If

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

            If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = lngTipoHojaId
               frm.Show()
            End If

            If clsAppInfo.RegistrarBitacora Then
               Call CloneVM(oComp.VMNew)
               oComp.VMNew.ToShowOpe(clsTipoOpera.IMPRESION_INFORME)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Sub

   Private Sub PrintReportText()
      Dim rpt As New rptCompEditText
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim lngTipoRespImpId As Long

      Try
         oComp.SelectFilter = clsComp.SelectFilters.Report
         oComp.WhereFilter = clsComp.WhereFilters.Report
         oComp.OrderByFilter = clsComp.OrderByFilters.Report
         oComp.CompId = moComp.CompId

         If oComp.Find Then
            rpt.DataSource = oComp.DataSet.Tables(oComp.TableName).DefaultView

            If moComp.TipoCompId = 1 Then
               rpt.lblTitle.Text = "Comprobante de Ingreso"
               rpt.Document.Name = "Comprobante de Ingreso"

               rpt.lblEntregadoA.Text = "Hemos recibido de:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.lblCompPie.Text = "CI : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

            ElseIf moComp.TipoCompId = 2 Then
               rpt.lblTitle.Text = "Comprobante de Egreso"
               rpt.Document.Name = "Comprobante de Egreso"

               rpt.lblEntregadoA.Text = "Hemos entregado a:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.lblCompPie.Text = "CE : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

            ElseIf moComp.TipoCompId = 3 Then
               rpt.lblTitle.Text = "Comprobante de Traspaso"
               rpt.Document.Name = "Comprobante de Traspaso"

               rpt.lblEntregadoA.Text = "Por concepto de:"
               rpt.lblPorConcepto.Text = ""

               rpt.lblCompPie.Text = "CT : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))
            End If

            rpt.txtFirma.Text = CompParaFirma(moComp.TipoCompId, moComp.GestionId, lngTipoHojaId, lngTipoRespImpId)
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")

            If lngTipoRespImpId = 1 Then
               rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            ElseIf lngTipoRespImpId = 2 Then
               rpt.lblLogin.Text = "Usuario: " + ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("sLastUpdate_id"))
            End If

            'Subreport(PlanEEFF)
            If clsAppInfo.ExigirEEFF Then
               Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

               With oCompPlanEEFF
                  .SelectFilter = clsCompPlanEEFF.SelectFilters.PrintReport
                  .WhereFilter = clsCompPlanEEFF.WhereFilters.PrintReport
                  .OrderByFilter = clsCompPlanEEFF.OrderByFilters.CompPlanEEFFId
                  .CompId = moComp.CompId

                  If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
                     Dim srptPlanEEFF As New srptCompPlanEEFF
                     srptPlanEEFF.DataSource = .DataSet.Tables(.TableName).DefaultView
                     rpt.srptCompEEFF.Report = srptPlanEEFF
                  End If
               End With
            End If

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

            If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = lngTipoHojaId
               frm.Show()
            End If

            If clsAppInfo.RegistrarBitacora Then
               Call CloneVM(oComp.VMNew)
               oComp.VMNew.ToShowOpe(clsTipoOpera.IMPRESION_INFORME)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Sub

   Private Sub PrintReportGraphicEncHoja()
      Dim rpt As New rptCompEditEncHoja
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim lngTipoRespImpId As Long

      Try
         oComp.SelectFilter = clsComp.SelectFilters.Report
         oComp.WhereFilter = clsComp.WhereFilters.Report
         oComp.OrderByFilter = clsComp.OrderByFilters.Report
         oComp.CompId = moComp.CompId

         If oComp.Find Then
            'Dim oDs As New DataDynamics.ActiveReports.DataSources.OleDBDataSource

            'oDs.ConnectionString = clsAppInfo.ConnectString
            'oDs.SQL = oComp.SQL

            'rpt.ds = oDs

            'rpt.ds.ConnectionString = oComp.ConnectionString
            'rpt.ds.SQL = oComp.SQL

            rpt.DataSource = oComp.DataSet.Tables(oComp.TableName).DefaultView

            If moComp.TipoCompId = 1 Then
               rpt.lblTitle.Text = "Comprobante de Ingreso"
               rpt.Document.Name = "Comprobante de Ingreso"

               rpt.lblEntregadoA.Text = "Hemos recibido de:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.lblCompPie.Text = "CI : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

            ElseIf moComp.TipoCompId = 2 Then
               rpt.lblTitle.Text = "Comprobante de Egreso"
               rpt.Document.Name = "Comprobante de Egreso"

               rpt.lblEntregadoA.Text = "Hemos entregado a:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.lblCompPie.Text = "CE : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

            ElseIf moComp.TipoCompId = 3 Then
               rpt.lblTitle.Text = "Comprobante de Traspaso"
               rpt.Document.Name = "Comprobante de Traspaso"

               rpt.lblEntregadoA.Text = "Por concepto de:"
               rpt.lblPorConcepto.Text = ""

               rpt.lblCompPie.Text = "CT : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))
            End If

            rpt.txtFirma.Text = CompParaFirma(moComp.TipoCompId, moComp.GestionId, lngTipoHojaId, lngTipoRespImpId)
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")

            If lngTipoRespImpId = 1 Then
               rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            ElseIf lngTipoRespImpId = 2 Then
               rpt.lblLogin.Text = "Usuario: " + ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("sLastUpdate_id"))
            End If

            'Subreport(PlanEEFF)
            If clsAppInfo.ExigirEEFF Then
               Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

               With oCompPlanEEFF
                  .SelectFilter = clsCompPlanEEFF.SelectFilters.PrintReport
                  .WhereFilter = clsCompPlanEEFF.WhereFilters.PrintReport
                  .OrderByFilter = clsCompPlanEEFF.OrderByFilters.CompPlanEEFFId
                  .CompId = moComp.CompId

                  If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
                     Dim srptPlanEEFF As New srptCompPlanEEFF
                     srptPlanEEFF.DataSource = .DataSet.Tables(.TableName).DefaultView
                     rpt.srptCompEEFF.Report = srptPlanEEFF
                  End If
               End With
            End If

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

            If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = lngTipoHojaId
               frm.Show()
            End If

            If clsAppInfo.RegistrarBitacora Then
               Call CloneVM(oComp.VMNew)
               oComp.VMNew.ToShowOpe(clsTipoOpera.IMPRESION_INFORME)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Sub

   Private Sub PrintReportTextEncHoja()
      Dim rpt As New rptCompEditTextEncHoja
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long
      Dim lngTipoRespImpId As Long

      Try
         oComp.SelectFilter = clsComp.SelectFilters.Report
         oComp.WhereFilter = clsComp.WhereFilters.Report
         oComp.OrderByFilter = clsComp.OrderByFilters.Report
         oComp.CompId = moComp.CompId

         If oComp.Find Then
            rpt.DataSource = oComp.DataSet.Tables(oComp.TableName).DefaultView

            If moComp.TipoCompId = 1 Then
               rpt.lblTitle.Text = "Comprobante de Ingreso"
               rpt.Document.Name = "Comprobante de Ingreso"

               rpt.lblEntregadoA.Text = "Hemos recibido de:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.lblCompPie.Text = "CI : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

            ElseIf moComp.TipoCompId = 2 Then
               rpt.lblTitle.Text = "Comprobante de Egreso"
               rpt.Document.Name = "Comprobante de Egreso"

               rpt.lblEntregadoA.Text = "Hemos entregado a:"
               rpt.lblPorConcepto.Text = "Por concepto de:"

               rpt.lblCompPie.Text = "CE : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

            ElseIf moComp.TipoCompId = 3 Then
               rpt.lblTitle.Text = "Comprobante de Traspaso"
               rpt.Document.Name = "Comprobante de Traspaso"

               rpt.lblEntregadoA.Text = "Por concepto de:"
               rpt.lblPorConcepto.Text = ""

               rpt.lblCompPie.Text = "CT : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))
            End If

            rpt.txtFirma.Text = CompParaFirma(moComp.TipoCompId, moComp.GestionId, lngTipoHojaId, lngTipoRespImpId)
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")

            If lngTipoRespImpId = 1 Then
               rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            ElseIf lngTipoRespImpId = 2 Then
               rpt.lblLogin.Text = "Usuario: " + ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("sLastUpdate_id"))
            End If

            'Subreport(PlanEEFF)
            If clsAppInfo.ExigirEEFF Then
               Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

               With oCompPlanEEFF
                  .SelectFilter = clsCompPlanEEFF.SelectFilters.PrintReport
                  .WhereFilter = clsCompPlanEEFF.WhereFilters.PrintReport
                  .OrderByFilter = clsCompPlanEEFF.OrderByFilters.CompPlanEEFFId
                  .CompId = moComp.CompId

                  If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
                     Dim srptPlanEEFF As New srptCompPlanEEFF
                     srptPlanEEFF.DataSource = .DataSet.Tables(.TableName).DefaultView
                     rpt.srptCompEEFF.Report = srptPlanEEFF
                  End If
               End With
            End If

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

            If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = lngTipoHojaId
               frm.Show()
            End If

            If clsAppInfo.RegistrarBitacora Then
               Call CloneVM(oComp.VMNew)
               oComp.VMNew.ToShowOpe(clsTipoOpera.IMPRESION_INFORME)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Sub
#End Region

#Region " Otros Metodos "
   Private Function TipoFacturaIdFind(ByVal lngCompId As Long) As Long
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         TipoFacturaIdFind = 0

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Find Then
               TipoFacturaIdFind = .TipoFacturaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function CentroCostoCodFind(ByVal lngCentroCostoId As Long, ByRef strCentroCostoDes As String) As String
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)

      CentroCostoCodFind = ""

      Try
         If lngCentroCostoId > 0 Then
            With oCentroCosto
               .CentroCostoId = lngCentroCostoId

               If .FindByPK Then
                  CentroCostoCodFind = .CentroCostoCod
                  strCentroCostoDes = .CentroCostoDes
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()

      End Try
   End Function

   Private Function CentroCostoDetDesFind(ByVal lngCentroCostoDetId As Long) As String
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)

      Try
         If lngCentroCostoDetId > 0 Then

            With oCentroCostoDet
               .CentroCostoDetId = lngCentroCostoDetId

               If .FindByPK Then
                  CentroCostoDetDesFind = .CentroCostoDetDes
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCentroCostoDet.Dispose()
      End Try
   End Function

   Private Function SucursalDesFind(ByVal lngSucursalId As Long) As String
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)

      SucursalDesFind = ""

      Try
         If lngSucursalId > 0 Then
            With oSucursal
               .SucursalId = lngSucursalId

               If .FindByPK Then
                  SucursalDesFind = .SucursalDes
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()

      End Try
   End Function

   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0
      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo

            .EmpresaId = moComp.EmpresaId
            .FechaIni = strFecha
            .EstadoId = clsEstado.ABIERTO
            If .Find Then
               GestionIdFind = ToLong(.GestionId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oGestion.Dispose()
      End Try
   End Function

   Private Sub txtGestionIdLoad(ByVal lngGestionId As Long)
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               txtGestion.Tag = .GestionId
               txtGestion.Text = ToStr(.Gestion)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Sub

   Private Sub txtGestionIdFind(ByVal lngGestionId As Long)
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               txtGestion.Tag = .GestionId
               txtGestion.Text = ToStr(.Gestion)
            Else
               txtGestion.Tag = 0
               txtGestion.Text = "0"
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Sub

   Private Function CompSaldoUpdate(ByVal lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      Try
         CompSaldoUpdate = False

         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               If .MonedaId = 1 Then
                  .DebeBs = ToDecimal(txtDebe.Text)
                  .HaberBs = ToDecimal(txtHaber.Text)

                  If ToDecimal(txtTipoCambio.Text) > 0 Then
                     .DebeUs = ToDecimal(.DebeBs / ToDecimal(txtTipoCambio.Text))
                     .HaberUs = ToDecimal(.HaberBs / ToDecimal(txtTipoCambio.Text))
                  End If

               ElseIf .MonedaId = 2 Then
                  .DebeUs = ToDecimal(txtDebe.Text)
                  .HaberUs = ToDecimal(txtHaber.Text)

                  .DebeBs = ToDecimal(.DebeUs * ToDecimal(txtTipoCambio.Text))
                  .HaberBs = ToDecimal(.HaberUs * ToDecimal(txtTipoCambio.Text))
               End If

               .Fecha = ToDate(.Fecha)

               .VMOld = moComp.VMOld
               Call CloneVM(.VMNew)
               .VMNew.DebeBs = .DebeBs
               .VMNew.DebeUs = .DebeUs
               .VMNew.HaberBs = .HaberBs
               .VMNew.HaberUs = .HaberUs

               If .Update Then
                  CompSaldoUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompPlanEEFFCheck(ByRef strMessage As String) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim strPlanDes As String
      Dim strDetalleDes As String
      Try
         strMessage = ""

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .Automatico = 0

            If .Open Then
               Do While .Read()
                  If EsCuentaDisponible(.PlanId, strPlanDes) Then
                     Call CompPlanAddParametro(.DebeOrg, .HaberOrg)
                     Dim decCompPlanEEFFSaldo = CompPlanEEFFSaldo(.CompId, .CompDetId)

                     If decCompPlanEEFFSaldo <> 0 Then
                        strMessage &= strPlanDes & " - Diferencia : " & ToDecStr(decCompPlanEEFFSaldo) & vbCrLf
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         If strMessage = "" Then
            CompPlanEEFFCheck = True
         Else
            CompPlanEEFFCheck = False
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddCheck(ByRef strMessage As String) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim strPlanDes As String
      Dim strDetalleDes As String
      Try
         strMessage = ""

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .Automatico = 0

            If .Open Then
               Do While .Read()
                  If TieneAnaAdd(.PlanId, strPlanDes) Then
                     Call CompPlanAddParametro(.DebeOrg, .HaberOrg)
                     Dim decCompPlanAddSaldo = CompPlanAddSaldo(.CompId, .CompDetId)

                     If decCompPlanAddSaldo <> 0 Then
                        If .CentroCostoId > 0 Then
                           Call CentroCostoCodFind(.CentroCostoId, strDetalleDes)
                           strDetalleDes = "C.C. " & strDetalleDes
                        ElseIf .SucursalId > 0 Then
                           strDetalleDes = "Suc." & SucursalDesFind(.SucursalId)
                        End If

                        strMessage &= strPlanDes & " - " & strDetalleDes & " - Diferencia : " & ToDecStr(decCompPlanAddSaldo) & vbCrLf
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         If strMessage = "" Then
            CompPlanAddCheck = True
         Else
            CompPlanAddCheck = False
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function PlanDesFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanDesFind = ""

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanDesFind = .PlanDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetCheck(ByRef strMessage As String) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim strPlanDes As String
      Dim strDetalleDes As String

      Try
         strMessage = ""

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .Automatico = 0

            If .Open Then
               Do While .Read()
                  If .CentroCostoId > 0 Then
                     If TieneCentroCostoDet(.CentroCostoId) Then
                        Call CompPlanAddParametro(.DebeOrg, .HaberOrg)

                        Dim decCompCentroCostoDetSaldo = CompCentroCostoDetSaldo(.CompId, .CompDetId, .CentroCostoId)

                        If decCompCentroCostoDetSaldo <> 0 Then
                           Call CentroCostoCodFind(.CentroCostoId, strDetalleDes)
                           strDetalleDes = "C.C. " & strDetalleDes
                           strMessage &= PlanDesFind(.PlanId) & " - " & strDetalleDes & " - Diferencia : " & ToDecStr(decCompCentroCostoDetSaldo) & vbCrLf
                        End If
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         If strMessage = "" Then
            CompCentroCostoDetCheck = True
         Else
            CompCentroCostoDetCheck = False
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function ValidarSaldoCajaBancoCheck(ByRef strMessage As String) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decSaldo As Decimal

      Try
         strMessage = ""

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.SaldoCajaBanco
            .WhereFilter = clsCompDet.WhereFilters.SaldoCajaBanco
            .GroupByFilter = clsCompDet.GroupByFilters.SaldoCajaBanco
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .Automatico = 0

            If .Open() Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  Dim decPlanSaldo As Decimal = 0

                  If moComp.MonedaId = clsMoneda.BOLIVIANOS Then
                     decSaldo = oRow("DebeBs") - oRow("HaberBs")
                     decPlanSaldo = PlanSaldoGestionBs(oRow("PlanId"), 0)
                  Else
                     decSaldo = oRow("DebeUs") - oRow("HaberUs")
                     Call PlanSaldoGestionBs(oRow("PlanId"), decPlanSaldo)
                  End If

                  If decSaldo < 0 Then
                     If (decPlanSaldo - Math.Abs(decSaldo) < 0) Then
                        strMessage &= oRow("PlanCta") & " - " & oRow("PlanDes") & " Saldo Cuenta: " & ToDecStr(decPlanSaldo) & vbCrLf
                     End If
                  End If
               Next
            End If
         End With

         If strMessage = "" Then
            ValidarSaldoCajaBancoCheck = True
         Else
            ValidarSaldoCajaBancoCheck = False
         End If

      Catch exp As Exception
         Throw exp

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function FacturaAgruPorCompDet(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Decimal
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         FacturaAgruPorCompDet = 0
         decMonto = 0

         With oFacturaAgru
            .SelectFilter = clsFacturaAgru.SelectFilters.All
            .WhereFilter = clsFacturaAgru.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  decMonto = decMonto + ToDecimal(.FacturaMonto)

                  .MoveNext()
               Loop
            End If
         End With

         FacturaAgruPorCompDet = ToDecimal(decMonto)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Function

   Private Function FacturaAgruCheck(ByVal lngCompId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decFacturaAgru As Decimal

      Try
         FacturaAgruCheck = True

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read()
                  If moComp.TipoCompId = 1 Then
                     If .HaberOrg <> 0 Then
                        decFacturaAgru = FacturaAgruPorCompDet(lngCompId, .CompDetId)

                        If decFacturaAgru > 0 Then
                           If .MonedaId = 1 Then
                              'If .HaberOrg <> decFacturaAgru Then
                              If Math.Abs(.HaberOrg - decFacturaAgru) > 0.1 Then
                                 Return False
                              End If

                           ElseIf .MonedaId = 2 Then
                              'If ToDecimal(.HaberOrg * moComp.TipoCambio) <> decFacturaAgru Then
                              If Math.Abs((.HaberOrg * moComp.TipoCambio) - decFacturaAgru) > 0.1 Then
                                 Return False
                              End If
                           End If
                        End If
                     End If

                  ElseIf moComp.TipoCompId = 2 Then
                     If .DebeOrg <> 0 Then
                        decFacturaAgru = FacturaAgruPorCompDet(lngCompId, .CompDetId)

                        If decFacturaAgru > 0 Then
                           If .MonedaId = 1 Then
                              'If .DebeOrg <> decFacturaAgru Then
                              If Math.Abs(.HaberOrg - decFacturaAgru) > 0.1 Then
                                 Return False
                              End If

                           ElseIf .MonedaId = 2 Then
                              'If ToDecimal(.DebeOrg * moComp.TipoCambio) <> decFacturaAgru Then
                              If Math.Abs((.HaberOrg * moComp.TipoCambio) - decFacturaAgru) > 0.1 Then
                                 Return False
                              End If
                           End If
                        End If
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function FacturaPorCompDet(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Decimal
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         FacturaPorCompDet = 0
         decMonto = 0

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If clsAppInfo.AplicarDescuento Then
                     decMonto += .FacturaMonto + .Recargo
                  Else
                     decMonto += .FacturaMonto + .Recargo - .Descuento
                  End If
                  .MoveNext()
               Loop
            End If
         End With

         FacturaPorCompDet = ToDecimal(decMonto)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function FacturaPorComp(ByVal lngCompId As Long) As Decimal
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         FacturaPorComp = 0

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Find Then
               If clsAppInfo.AplicarDescuento Then
                  FacturaPorComp = .FacturaMonto + .Recargo
               Else
                  FacturaPorComp = .FacturaMonto + .Recargo - .Descuento
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function FacturaCheck(ByVal lngCompId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decFactura As Decimal

      Try
         FacturaCheck = True

         If TieneFacturaIndi(moComp.CompId) > 0 Then
            With oCompDet
               .SelectFilter = clsCompDet.SelectFilters.All
               .WhereFilter = clsCompDet.WhereFilters.CompId
               .EmpresaId = moComp.EmpresaId
               .CompId = lngCompId

               If .Open Then
                  Do While .Read()
                     If moComp.TipoCompId = 1 Then
                        If .HaberOrg <> 0 Then
                           decFactura = FacturaPorCompDet(lngCompId, .CompDetId)

                           If decFactura > 0 Then
                              If .MonedaId = 1 Then
                                 'If .HaberOrg <> decFactura Then
                                 If Math.Abs(.HaberOrg - decFactura) > 0.1 Then
                                    Return False
                                 End If

                              ElseIf .MonedaId = 2 Then
                                 'If ToDecimal(.HaberOrg * moComp.TipoCambio) <> decFactura Then
                                 If Math.Abs((.HaberOrg * moComp.TipoCambio) - decFactura) > 0.1 Then
                                    Return False
                                 End If
                              End If
                           End If
                        End If

                     ElseIf moComp.TipoCompId = 2 Then
                        If .DebeOrg <> 0 Then
                           decFactura = FacturaPorCompDet(lngCompId, .CompDetId)

                           If decFactura > 0 Then
                              If .MonedaId = 1 Then
                                 'If .DebeOrg <> decFactura Then
                                 If Math.Abs(.DebeOrg - decFactura) > 0.1 Then
                                    Return False
                                 End If

                              ElseIf .MonedaId = 2 Then
                                 'If ToDecimal(.DebeOrg * moComp.TipoCambio) <> decFactura Then
                                 If Math.Abs((.DebeOrg * moComp.TipoCambio) - decFactura) > 0.1 Then
                                    Return False
                                 End If
                              End If
                           End If
                        End If
                     ElseIf moComp.TipoCompId = clsTipoComp.TRASPASO Then
                        Dim decMonto As Decimal = 0
                        If .DebeOrg <> 0 Then
                           decMonto = .DebeOrg
                        Else
                           decMonto = .HaberOrg
                        End If

                        decFactura = FacturaPorCompDet(lngCompId, .CompDetId)

                        If decFactura > 0 Then
                           If .MonedaId = 1 Then
                              If Math.Abs(decMonto - decFactura) > 0.1 Then
                                 Return False
                              End If
                           ElseIf .MonedaId = 2 Then
                              If Math.Abs((decMonto * moComp.TipoCambio) - decFactura) > 0.1 Then
                                 Return False
                              End If
                           End If
                        End If

                     End If

                     .MoveNext()
                  Loop
               End If
            End With

         ElseIf TieneFacturaGlobal(moComp.CompId) > 0 Then
            decFactura = FacturaPorComp(lngCompId)

            'If CompMontoBs(lngCompId) <> decFactura Then
            If Math.Abs(CompMontoBs(lngCompId, 1) - decFactura) > 0.1 Then
               Return False
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function TieneRetencionDiferente() As Boolean
      Dim boolTieneRet As Boolean = False
      Dim lngCol As Long = 0

      TieneRetencionDiferente = False

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If ToLong(oRow.Cells("TipoRetencionId").Value) > 0 Then
            If boolTieneRet Then
               If lngCol = 1 Then
                  If ToDecimal(oRow.Cells("Haber").Value) > 0 Then
                     Return True
                  End If

               ElseIf lngCol = 2 Then
                  If ToDecimal(oRow.Cells("Debe").Value) > 0 Then
                     Return True
                  End If
               End If
            End If

            If Not boolTieneRet Then
               boolTieneRet = True

               If ToDecimal(oRow.Cells("Debe").Value) > 0 Then
                  lngCol = 1

               ElseIf ToDecimal(oRow.Cells("Haber").Value) > 0 Then
                  lngCol = 2
               End If
            End If
         End If
      Next
   End Function

   Private Function CompNroNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long) As Long
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompNroNext = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moComp.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId

            If .Find Then
               If ToBoolean(.NroAuto) Then
                  If ToBoolean(.NroAutoGestion) Then
                     .UpdateFilter = clsCompPara.UpdateFilters.NroActual

                     If Not clsAppInfo.MultipleNro Then
                        .NroActual = .NroActual + 1

                        If .Update Then
                           CompNroNext = .NroActual
                        End If

                     Else
                        If chkConFac.Checked Then
                           .NroActualFis = .NroActualFis + 1

                           If .Update Then
                              CompNroNext = .NroActualFis
                           End If

                        ElseIf chkSinFac.Checked Then
                           .NroActual = .NroActual + 1

                           If .Update Then
                              CompNroNext = .NroActual
                           End If
                        End If
                     End If
                  Else
                     CompNroNext = CompNroMesNext(lngTipoCompId, lngGestionId, dtpFecha.Value.Month)
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Function

   Private Function CompNroMesNext(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByVal intMesId As Integer) As Long
      Dim oCompParaMes As New clsCompParaMes(clsAppInfo.ConnectString)

      Try
         CompNroMesNext = 0

         With oCompParaMes
            .SelectFilter = clsCompParaMes.SelectFilters.All
            .WhereFilter = clsCompParaMes.WhereFilters.MesId
            .EmpresaId = moComp.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId
            .MesId = intMesId

            If .Find Then
               .UpdateFilter = clsCompParaMes.UpdateFilters.NroActual

               If Not clsAppInfo.MultipleNro Then
                  .NroActual = .NroActual + 1

                  If .Update Then
                     CompNroMesNext = .NroActual
                  End If

               Else
                  If chkConFac.Checked Then
                     .NroActualFis = .NroActualFis + 1

                     If .Update Then
                        CompNroMesNext = .NroActualFis
                     End If

                  ElseIf chkSinFac.Checked Then
                     .NroActual = .NroActual + 1

                     If .Update Then
                        CompNroMesNext = .NroActual
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompParaMes.Dispose()

      End Try
   End Function
#End Region

#Region " DETALLE "
#Region " Metodo-Detalle "
   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Debe"), Janus.Windows.GridEX.ConditionOperator.NotEqual, System.Convert.DBNull)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Haber"), Janus.Windows.GridEX.ConditionOperator.NotEqual, System.Convert.DBNull)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Automatico"), Janus.Windows.GridEX.ConditionOperator.Equal, 255)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompDetId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Function DataSaveRetencion(ByVal decIT As Decimal, ByVal strDes As String, ByVal lngPlanId As Long, ByVal lngCentroCostoId As Long, ByVal lngSucursalId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim lngSucCCOId As Long = PlanIdSucCCOFind(lngPlanId)
      Try
         DataSaveRetencion = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdAutomaticoSucCCO
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .PlanId = lngPlanId
            If lngSucCCOId = clsSucCCO.CENTRO_COSTO Then
               .CentroCostoId = lngCentroCostoId
            ElseIf lngSucCCOId = clsSucCCO.SUCURSAL Then
               .SucursalId = lngSucursalId
            End If
            .Automatico = 1

            If Not .Find Then
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .GestionId = moComp.GestionId
               .TipoCompId = moComp.TipoCompId
               .Fecha = moComp.Fecha
               .PlanId = lngPlanId
               .CompDetDes = RetencionGlosa()
               .SucursalId = lngSucursalId
               .CentroCostoId = lngCentroCostoId
               .MonedaId = moComp.MonedaId

               .DebeOrg = 0
               .HaberOrg = decIT

               If .MonedaId = 1 Then
                  .DebeBs = 0
                  .HaberBs = decIT
                  .DebeUs = 0
                  .HaberUs = ToDecimal(decIT / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .DebeBs = 0
                  .HaberBs = ToDecimal(decIT * moComp.TipoCambio)
                  .DebeUs = 0
                  .HaberUs = decIT
               End If

               .Orden = 0
               .Automatico = 1
               .EstadoId = lngEstadoId

               If .Insert Then
                  DataSaveRetencion = True
               End If
            Else
               .DebeOrg = 0
               .HaberOrg += decIT

               If .MonedaId = 1 Then
                  .DebeBs = 0
                  .HaberBs += decIT
                  .DebeUs = 0
                  .HaberUs += ToDecimal(decIT / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .DebeBs = 0
                  .HaberBs += ToDecimal(decIT * moComp.TipoCambio)
                  .DebeUs = 0
                  .HaberUs += decIT
               End If

               .Fecha = moComp.Fecha
               .EstadoId = lngEstadoId

               If .Update Then
                  DataSaveRetencion = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function RetencionGlosa() As String
      Dim strGlosa As String = ""

      If ToLong(ListPosition(cboTipoComp, cboTipoComp.SelectedIndex)) = clsTipoComp.EGRESO Then
         strGlosa = "Entregado a " & txtEntregadoA.Text & "; por Concepto de " & txtPorConcepto.Text
      ElseIf ToLong(ListPosition(cboTipoComp, cboTipoComp.SelectedIndex)) = clsTipoComp.TRASPASO Then
         strGlosa = "Por Concepto de " & txtEntregadoA.Text & "; " & txtPorConcepto.Text
      End If

      Return strGlosa
   End Function

   Private Function DataSaveRetenciones(ByVal lngTipoRetencionId As Long, ByVal lngEstadoId As Long, ByVal decIVARetTotal As Decimal, ByVal decITRetTotal As Decimal, ByVal decIUETotal As Decimal, ByVal lngCentroCostoId As Long, ByVal lngSucursalId As Long) As Boolean
      If lngTipoRetencionId = 1 Then 'Prestación de Servicios (Empresa)
         If decITRetTotal > 0 Then
            If DataSaveRetencion(decITRetTotal, "", clsAppInfo.PlanITRetId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
               If DataSaveRetencion(decIUETotal, "", clsAppInfo.PlanIUERetSerId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
                  DataSaveRetenciones = True
               End If
            End If
         End If

      ElseIf lngTipoRetencionId = 2 Then 'Compra de Bienes (Empresa)
         If decITRetTotal > 0 Then
            If DataSaveRetencion(decITRetTotal, "", clsAppInfo.PlanITRetId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
               If DataSaveRetencion(decIUETotal, "", clsAppInfo.PlanIUERetBieId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
                  DataSaveRetenciones = True
               End If
            End If
         End If

      ElseIf lngTipoRetencionId = 3 Then 'Alquiler de Bienes e Inmuebles (Empresa)
         If decITRetTotal > 0 Then
            If DataSaveRetencion(decITRetTotal, "", clsAppInfo.PlanITRetId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
               If DataSaveRetencion(decIVARetTotal, "", clsAppInfo.PlanCreRetId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
                  DataSaveRetenciones = True
               End If
            End If
         End If

      ElseIf lngTipoRetencionId = 4 Then 'Prestación de Servicios (Proveedor)
         If decITRetTotal > 0 Then
            If DataSaveRetencion(decITRetTotal, "", clsAppInfo.PlanITRetId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
               If DataSaveRetencion(decIUETotal, "", clsAppInfo.PlanIUERetSerId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
                  DataSaveRetenciones = True
               End If
            End If
         End If

      ElseIf lngTipoRetencionId = 5 Then 'Compra de Bienes (Proveedor)
         If decITRetTotal > 0 Then
            If DataSaveRetencion(decITRetTotal, "", clsAppInfo.PlanITRetId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
               If DataSaveRetencion(decIUETotal, "", clsAppInfo.PlanIUERetBieId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
                  DataSaveRetenciones = True
               End If
            End If
         End If

      ElseIf lngTipoRetencionId = 6 Then 'Alquiler de Bienes e Inmuebles (Proveedor)
         If decITRetTotal > 0 Then
            If DataSaveRetencion(decITRetTotal, "", clsAppInfo.PlanITRetId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
               If DataSaveRetencion(decIVARetTotal, "", clsAppInfo.PlanCreRetId, lngCentroCostoId, lngSucursalId, lngEstadoId) Then
                  DataSaveRetenciones = True
               End If
            End If
         End If
      End If
   End Function

   Private Sub CompDetMontoEqui(ByVal lngCompId As Long, ByVal lngPlanDifId As Long)
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               mdecDebeEqui = 0
               mdecHaberEqui = 0

               mdecDebeDifRet = 0
               mdecHaberDifRet = 0

               Do While .Read
                  If .PlanId <> lngPlanDifId Then
                     If .MonedaId = 1 Then
                        mdecDebeEqui += .DebeUs
                        mdecHaberEqui += .HaberUs

                        mdecDebeDifRet += .DebeBs
                        mdecHaberDifRet += .HaberBs

                     ElseIf .MonedaId = 2 Then
                        mdecDebeEqui += .DebeBs
                        mdecHaberEqui += .HaberBs

                        mdecDebeDifRet += .DebeUs
                        mdecHaberDifRet += .HaberUs
                     End If

                  ElseIf Not CBool(.Automatico) Then
                     If .MonedaId = 1 Then
                        mdecDebeEqui += .DebeUs
                        mdecHaberEqui += .HaberUs

                        mdecDebeDifRet += .DebeBs
                        mdecHaberDifRet += .HaberBs

                     ElseIf .MonedaId = 2 Then
                        mdecDebeEqui += .DebeBs
                        mdecHaberEqui += .HaberBs

                        mdecDebeDifRet += .DebeUs
                        mdecHaberDifRet += .HaberUs
                     End If
                  End If

                  Call .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Sub

   Private Function DataSavePlanIdDif(ByVal lngCompId As Long, ByVal lngPlanId As Long, ByVal lngMonedaId As Long, ByVal decValor As Decimal, ByVal lngCol As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         DataSavePlanIdDif = False

         With oCompDet
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .GestionId = moComp.GestionId
            .TipoCompId = moComp.TipoCompId
            .Fecha = moComp.Fecha
            .PlanId = lngPlanId
            .CompDetDes = ""
            .SucursalId = 0
            .CentroCostoId = 0
            .MonedaId = moComp.MonedaId

            If lngCol = 1 Then
               .DebeOrg = decValor

               If lngMonedaId = 1 Then
                  .DebeBs = decValor
                  .DebeUs = 0

               ElseIf lngMonedaId = 2 Then
                  .DebeBs = 0
                  .DebeUs = decValor
               End If

               .HaberOrg = 0
               .HaberUs = 0
               .HaberBs = 0

            ElseIf lngCol = 2 Then
               .HaberOrg = decValor

               If lngMonedaId = 1 Then
                  .HaberBs = decValor
                  .HaberUs = 0

               ElseIf lngMonedaId = 2 Then
                  .HaberBs = 0
                  .HaberUs = decValor
               End If

               .DebeOrg = 0
               .DebeUs = 0
               .DebeBs = 0
            End If

            .Orden = 0
            .Automatico = 1
            .EstadoId = lngEstadoId

            If .Insert Then
               DataSavePlanIdDif = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddIVA(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decMontoOrg As Decimal, ByVal decIVAOrg As Decimal) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      Try
         CompPlanAddIVA = False

         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.All
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If moComp.MonedaId = 1 Then
                     If .DebeOrg > 0 Then
                        .DebeBs = .DebeBs - ToDecimal((.DebeBs / decMontoOrg) * decIVAOrg)
                        .DebeUs = ToDecimal(.DebeBs / moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberBs = .HaberBs - ToDecimal((.HaberBs / decMontoOrg) * decIVAOrg)
                        .HaberUs = ToDecimal(.HaberBs / moComp.TipoCambio)
                     End If

                  ElseIf moComp.MonedaId = 2 Then
                     If .DebeOrg > 0 Then
                        .DebeUs = .DebeUs - ToDecimal((.DebeUs / decMontoOrg) * decIVAOrg)
                        .DebeBs = ToDecimal(.DebeUs * moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberUs = .HaberUs - ToDecimal((.HaberUs / decMontoOrg) * decIVAOrg)
                        .HaberBs = ToDecimal(.HaberUs * moComp.TipoCambio)
                     End If
                  End If

                  .Fecha = ToDate(.Fecha)

                  If .Update() Then
                     CompPlanAddIVA = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CompPlanEEFFIVA(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decMontoOrg As Decimal, ByVal decIVAOrg As Decimal) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

      Try
         CompPlanEEFFIVA = False

         With oCompPlanEEFF
            .SelectFilter = clsCompPlanEEFF.SelectFilters.All
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If moComp.MonedaId = 1 Then
                     If .DebeOrg > 0 Then
                        .DebeBs = .DebeBs - ToDecimal((.DebeBs / decMontoOrg) * decIVAOrg)
                        .DebeUs = ToDecimal(.DebeBs / moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberBs = .HaberBs - ToDecimal((.HaberBs / decMontoOrg) * decIVAOrg)
                        .HaberUs = ToDecimal(.HaberBs / moComp.TipoCambio)
                     End If

                  ElseIf moComp.MonedaId = 2 Then
                     If .DebeOrg > 0 Then
                        .DebeUs = .DebeUs - ToDecimal((.DebeUs / decMontoOrg) * decIVAOrg)
                        .DebeBs = ToDecimal(.DebeUs * moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberUs = .HaberUs - ToDecimal((.HaberUs / decMontoOrg) * decIVAOrg)
                        .HaberBs = ToDecimal(.HaberUs * moComp.TipoCambio)
                     End If
                  End If

                  .Fecha = ToDate(.Fecha)

                  If .Update() Then
                     CompPlanEEFFIVA = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         Throw exp
      Finally
         oCompPlanEEFF.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetIVA(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decMontoOrg As Decimal, ByVal decIVAOrg As Decimal) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      Try
         CompCentroCostoDetIVA = False

         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If moComp.MonedaId = 1 Then
                     If .DebeOrg > 0 Then
                        .DebeBs = .DebeBs - ToDecimal((.DebeBs / decMontoOrg) * decIVAOrg)
                        .DebeUs = ToDecimal(.DebeBs / moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberBs = .HaberBs - ToDecimal((.HaberBs / decMontoOrg) * decIVAOrg)
                        .HaberUs = ToDecimal(.HaberBs / moComp.TipoCambio)
                     End If

                  ElseIf moComp.MonedaId = 2 Then
                     If .DebeOrg > 0 Then
                        .DebeUs = .DebeUs - ToDecimal((.DebeUs / decMontoOrg) * decIVAOrg)
                        .DebeBs = ToDecimal(.DebeUs * moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberUs = .HaberUs - ToDecimal((.HaberUs / decMontoOrg) * decIVAOrg)
                        .HaberBs = ToDecimal(.HaberUs * moComp.TipoCambio)
                     End If
                  End If

                  .Fecha = ToDate(.Fecha)

                  If .Update() Then
                     CompCentroCostoDetIVA = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function DataSaveITFHaber(ByVal decITF As Decimal, ByVal strDes As String, ByVal lngPlanId As Long, ByVal lngSucursalId As Long, _
                                   ByVal lngCentroCostoId As Long, ByVal lngEstadoId As Long, ByRef lngCompDetId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         DataSaveITFHaber = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdAutomaticoSucCCO
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .PlanId = lngPlanId
            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId
            .Automatico = 1

            If Not .Find Then
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .GestionId = moComp.GestionId
               .TipoCompId = moComp.TipoCompId
               .Fecha = moComp.Fecha
               .PlanId = lngPlanId
               .CompDetDes = strDes
               .SucursalId = lngSucursalId
               .CentroCostoId = lngCentroCostoId
               .MonedaId = moComp.MonedaId

               .DebeOrg = 0
               .HaberOrg = decITF

               If .MonedaId = 1 Then
                  .DebeBs = 0
                  .HaberBs = decITF
                  .DebeUs = 0
                  .HaberUs = ToDecimal(decITF / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .DebeBs = 0
                  .HaberBs = ToDecimal(decITF * moComp.TipoCambio)
                  .DebeUs = 0
                  .HaberUs = decITF
               End If

               .Orden = 0
               .Automatico = 1
               .EstadoId = lngEstadoId

               If .Insert Then
                  lngCompDetId = .CompDetId
                  DataSaveITFHaber = True
               End If
            Else
               .CompDetDes &= " " & strDes

               .DebeOrg = 0
               .HaberOrg = decITF

               If .MonedaId = 1 Then
                  .DebeBs = 0
                  .HaberBs += decITF
                  .DebeUs = 0
                  .HaberUs += ToDecimal(decITF / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .DebeBs = 0
                  .HaberBs += ToDecimal(decITF * moComp.TipoCambio)
                  .DebeUs = 0
                  .HaberUs += decITF
               End If

               .Fecha = moComp.Fecha
               .EstadoId = lngEstadoId

               If .Update Then
                  lngCompDetId = .CompDetId
                  DataSaveITFHaber = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function DataSaveCompPlanEEFFHaber(ByVal decITF As Decimal, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
                                  ByVal lngPlanEEFFId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

      Try
         DataSaveCompPlanEEFFHaber = False

         With oCompPlanEEFF
            .SelectFilter = clsCompPlanEEFF.SelectFilters.All
            .WhereFilter = clsCompPlanEEFF.WhereFilters.FindPlanEEFFId
            .EmpresaId = moComp.EmpresaId
            .GestionId = moComp.GestionId
            .CompId = moComp.CompId
            .CompDetId = lngCompDetId
            .PlanEEFFId = lngPlanEEFFId
            .PlanId = lngPlanId

            If Not .Find Then
               .Fecha = moComp.Fecha
               .MonedaId = moComp.MonedaId
               .DebeOrg = 0
               .HaberOrg = decITF

               If .MonedaId = 1 Then
                  .DebeBs = 0
                  .HaberBs = decITF
                  .DebeUs = 0
                  .HaberUs = ToDecimal(decITF / moComp.TipoCambio)
               ElseIf .MonedaId = 2 Then
                  .DebeBs = 0
                  .HaberBs = ToDecimal(decITF * moComp.TipoCambio)
                  .DebeUs = 0
                  .HaberUs = decITF
               End If

               .EstadoId = lngEstadoId
               .PlanId = lngPlanId

               If .Insert() Then
                  DataSaveCompPlanEEFFHaber = True
               End If
            Else
               .Fecha = moComp.Fecha
               .MonedaId = moComp.MonedaId
               .DebeOrg = 0
               .HaberOrg += decITF

               If .MonedaId = 1 Then
                  .DebeBs = 0
                  .HaberBs += decITF
                  .DebeUs = 0
                  .HaberUs += ToDecimal(decITF / moComp.TipoCambio)
               ElseIf .MonedaId = 2 Then
                  .DebeBs = 0
                  .HaberBs += ToDecimal(decITF * moComp.TipoCambio)
                  .DebeUs = 0
                  .HaberUs += decITF
               End If

               If .Update() Then
                  DataSaveCompPlanEEFFHaber = True
               End If
            End If
         End With

      Catch exp As Exception
         Throw exp
      Finally
         oCompPlanEEFF.Dispose()
      End Try
   End Function

   Private Function CompDetChequeNro(ByVal lngCompDetId As Long, ByVal lngPlanId As Long) As String
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      Try
         CompDetChequeNro = ""

         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompDetId
            .EmpresaId = clsAppInfo.EmpresaId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read
                  With oCheque
                     .SelectFilter = clsCheque.SelectFilters.All
                     .WhereFilter = clsCheque.WhereFilters.PrimaryKey
                     .ChequeId = oCompCheque.ChequeId

                     If .Open Then
                        Do While .Read
                           If CompDetChequeNro <> "" Then
                              CompDetChequeNro += "; "
                           End If

                           CompDetChequeNro += ToStr(oCompCheque.ChequeDes) + " - Cuenta " + ToStr(oCheque.BancoCta) + " - Cheque " + ToStr(oCompCheque.ChequeNro) + "; "

                           .MoveNext()
                        Loop
                     End If
                  End With

                  .MoveNext()
               Loop
            End If
         End With

         If CompDetChequeNro = "" Then
            Dim oBanco As New clsBanco(clsAppInfo.ConnectString)

            With oCheque
               .SelectFilter = clsCheque.SelectFilters.All
               .WhereFilter = clsCheque.WhereFilters.PlanId
               .EmpresaId = clsAppInfo.EmpresaId
               .PlanId = lngPlanId

               If .Open Then
                  Do While .Read
                     oBanco.BancoId = .BancoId

                     If oBanco.FindByPK Then
                        If CompDetChequeNro <> "" Then
                           CompDetChequeNro += "; "
                        End If

                        CompDetChequeNro += "Banco " + ToStr(oBanco.BancoDes) + " - Cuenta " + ToStr(oCheque.BancoCta) + "; "
                     End If

                     .MoveNext()
                  Loop
               End If
            End With
         End If

         ' If String.IsNullOrEmpty(mstrChequeNro.Trim) Then
         mstrChequeNro &= CompDetChequeNro
         ' Else
         ' mstrChequeNro &= " " & CompDetChequeNro
         ' End If

      Catch exp As Exception
         Throw exp

      Finally
         oCompCheque.Dispose()
         oCheque.Dispose()

      End Try
   End Function

   Private Function TieneCheque(ByVal lngCompDetId As Long) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)

      TieneCheque = False
      Try
         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompDetId

            .CompDetId = lngCompDetId
            If .Find Then
               TieneCheque = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompCheque.Dispose()
      End Try
   End Function

   Private Function TieneFacturaIndividual(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      TieneFacturaIndividual = False
      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompDetId

            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            If .Find Then
               TieneFacturaIndividual = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oFactura.Dispose()
      End Try
   End Function

   Private Function TieneFacturaAgrupada(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Boolean
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)

      Try
         TieneFacturaAgrupada = False

         With oFacturaAgru
            .SelectFilter = clsFacturaAgru.SelectFilters.All
            .WhereFilter = clsFacturaAgru.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Find Then
               TieneFacturaAgrupada = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Function

   Private Function IVAIndividual(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByRef decExento As Decimal, ByRef decIT As Decimal, ByRef decDescuento As Decimal) As Decimal
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decIVA As Decimal = 0
      'Dim decMontoIT As Decimal = 0
      Dim decFacturaMonto As Decimal = 0

      Try
         IVAIndividual = 0
         decIT = 0
         decExento = 0

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If moComp.MonedaId = 1 Then
                     decFacturaMonto += .FacturaMonto + .Recargo
                     decIVA += .IVA
                     decIT += (.FacturaMonto + .Recargo - .Descuento) * moComp.PorIT
                     decExento += .Exento * moComp.PorIVA
                     decDescuento += .Descuento * moComp.PorIVA
                  ElseIf moComp.MonedaId = 2 Then
                     decFacturaMonto += .FacturaMonto + .Recargo / moComp.TipoCambio
                     decIVA += .IVA / moComp.TipoCambio
                     decIT += ((.FacturaMonto + .Recargo - .Descuento) * moComp.PorIT) / moComp.TipoCambio
                     decExento += (.Exento * moComp.PorIVA) / moComp.TipoCambio
                     decDescuento += (.Descuento * moComp.PorIVA) / moComp.TipoCambio
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         If decFacturaMonto <= 0 Then 'Factura Anulada
            decIT = 0
         End If

         decIT = ToDecimal(decIT)
         decExento = ToDecimal(decExento)
         IVAIndividual = ToDecimal(decIVA)
         decDescuento = ToDecimal(decDescuento)
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function IvaAgrupada(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Decimal
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         IvaAgrupada = 0
         decMonto = 0

         With oFacturaAgru
            .SelectFilter = clsFacturaAgru.SelectFilters.All
            .WhereFilter = clsFacturaAgru.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If moComp.MonedaId = 1 Then
                     decMonto += .IVA

                  ElseIf moComp.MonedaId = 2 Then
                     decMonto += (.IVA / moComp.TipoCambio)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         IvaAgrupada = ToDecimal(decMonto)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Function

   Private Function TieneITF(ByVal lngPlanId As Long, ByRef strPlanDes As String) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TieneITF = False

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               If (.TipoPlanId = 3) And (.MonedaId = 2) Then 'Cuenta Corriente y Moneda Dolares
                  strPlanDes = .PlanDes
                  TieneITF = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function IngresoUpdate(ByVal oCompDet As clsCompDet, ByVal boolFacturaGlobal As Boolean, ByVal decExePorcentaje As Decimal, ByVal decDescPorcentaje As Decimal, ByVal lngEstadoId As Long) As Boolean
      Dim decIVA As Decimal
      Dim decIT As Decimal
      Dim decITF As Decimal
      Dim decExeMonto As Decimal
      Dim decHaberMonto As Decimal
      Dim decHaber As Decimal
      Dim boolFacturaIndividual As Boolean = False
      Dim boolFacturaAgrupada As Boolean = False
      Dim decDescuentoIva As Decimal = 0

      With oCompDet
         If boolFacturaGlobal Then
            If (.HaberOrg <> 0) And (.Automatico = 0) Then
               decExeMonto = ToDecimal(.HaberOrg * decExePorcentaje)
               decHaberMonto = ToDecimal(.HaberOrg - decExeMonto)

               If clsAppInfo.AplicarDescuento Then
                  decHaberMonto = ToDecimal(decHaberMonto - ToDecimal(.HaberOrg * decDescPorcentaje))
                  decIVA = ToDecimal(decHaberMonto * moComp.PorIVA)
                  decIT = ToDecimal((.HaberOrg - (.HaberOrg * decDescPorcentaje)) * moComp.PorIT)

                  If mboolAplicarImpuestoDescuento And decDescPorcentaje > 0 Then
                     decDescuentoIva = .HaberOrg * decDescPorcentaje * moComp.PorIVA
                     Call AddCuentaAutomatica(mlistaIVADescuentoAutomatico, .CentroCostoId, .SucursalId, decDescuentoIva, "")
                  End If
               Else
                  decIVA = ToDecimal(decHaberMonto * moComp.PorIVA)
                  decIT = ToDecimal(.HaberOrg * moComp.PorIT)
               End If

               Call AddCuentaAutomatica(mlistaIVAAutomatico, .CentroCostoId, .SucursalId, decIVA, "")
               Call AddCuentaAutomatica(mlistaITAutomatico, .CentroCostoId, .SucursalId, decIT, "")
               decHaber = .HaberOrg - decIVA

               If .MonedaId = 1 Then
                  .HaberBs = decHaber
                  .HaberUs = ToDecimal(decHaber / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .HaberBs = ToDecimal(decHaber * moComp.TipoCambio)
                  .HaberUs = decHaber
               End If

               If decIVA > 0 Then
                  Call CompPlanAddIVA(.CompId, .CompDetId, .HaberOrg, decIVA)
                  Call CompCentroCostoDetIVA(.CompId, .CompDetId, .HaberOrg, decIVA)
                  Call CompPlanEEFFIVA(.CompId, .CompDetId, .HaberOrg, decIVA)
               End If
            End If

         ElseIf TieneFacturaIndividual(.CompId, .CompDetId) Then
            If (.HaberOrg <> 0) And (.Automatico = 0) Then 'Monto 500
               boolFacturaIndividual = True
               decIVA = IVAIndividual(.CompId, .CompDetId, 0, decIT, decDescuentoIva) '52

               decHaber = .HaberOrg - decIVA  '448

               If clsAppInfo.AplicarDescuento And mboolAplicarImpuestoDescuento And decDescuentoIva > 0 Then
                  Call AddCuentaAutomatica(mlistaIVADescuentoAutomatico, .CentroCostoId, .SucursalId, decDescuentoIva, "")
                  decIVA += decDescuentoIva
                  decHaber -= decDescuentoIva
               End If

               Call AddCuentaAutomatica(mlistaIVAAutomatico, .CentroCostoId, .SucursalId, decIVA, "")
               Call AddCuentaAutomatica(mlistaITAutomatico, .CentroCostoId, .SucursalId, decIT, "")

               If .MonedaId = 1 Then
                  .HaberBs = decHaber
                  .HaberUs = ToDecimal(decHaber / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .HaberBs = ToDecimal(decHaber * moComp.TipoCambio)
                  .HaberUs = decHaber
               End If

               If decIVA > 0 Then
                  Call CompPlanAddIVA(.CompId, .CompDetId, .HaberOrg, decIVA)
                  Call CompCentroCostoDetIVA(.CompId, .CompDetId, .HaberOrg, decIVA)
               End If
               Call CompPlanEEFFIVA(.CompId, .CompDetId, .HaberOrg, decIVA)
            End If

         ElseIf TieneFacturaAgrupada(.CompId, .CompDetId) Then
            If (.HaberOrg <> 0) And (.Automatico = 0) Then
               boolFacturaAgrupada = True
               decIVA = IvaAgrupada(.CompId, .CompDetId)
               decIT = ToDecimal(.HaberOrg * moComp.PorIT)

               Call AddCuentaAutomatica(mlistaIVAAutomatico, .CentroCostoId, .SucursalId, decIVA, "")
               Call AddCuentaAutomatica(mlistaITAutomatico, .CentroCostoId, .SucursalId, decIT, "")
               decHaber = .HaberOrg - decIVA '448

               If .MonedaId = 1 Then
                  .HaberBs = decHaber
                  .HaberUs = ToDecimal(decHaber / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .HaberBs = ToDecimal(decHaber * moComp.TipoCambio)
                  .HaberUs = decHaber
               End If

               If decIVA > 0 Then
                  Call CompPlanAddIVA(.CompId, .CompDetId, .HaberOrg, decIVA)
                  Call CompCentroCostoDetIVA(.CompId, .CompDetId, .HaberOrg, decIVA)
               End If
               Call CompPlanEEFFIVA(.CompId, .CompDetId, .HaberOrg, decIVA)
            End If
         End If


         If mboolITF Then 'ITF
            If TieneITF(.PlanId, "") Then
               If (.DebeOrg <> 0) And (.Automatico = 0) Then '1000
                  decITF = ToDecimal(.DebeOrg * moComp.PorITF) '2.5

                  If .MonedaId = 1 Then
                     .DebeBs = .DebeOrg
                     .DebeUs = ToDecimal(.DebeOrg / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = ToDecimal(.DebeOrg * moComp.TipoCambio)
                     .DebeUs = .DebeOrg
                  End If
               ElseIf (.HaberOrg <> 0) And (.Automatico = 0) Then '1000
                  decITF = ToDecimal(.HaberOrg * moComp.PorITF) '2.5

                  If .MonedaId = 1 Then
                     .HaberBs = .HaberOrg
                     .HaberUs = ToDecimal(.HaberOrg / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .HaberBs = ToDecimal(.HaberOrg * moComp.TipoCambio)
                     .HaberUs = .HaberOrg
                  End If
               End If

               If decITF > 0 Then
                  Dim lngCompDetId As Long = 0
                  Dim strCompDetChequeNro As String = CompDetChequeNro(.CompDetId, .PlanId)
                  Call DataSaveITFHaber(decITF, strCompDetChequeNro, .PlanId, .SucursalId, .CentroCostoId, lngEstadoId, lngCompDetId)
                  Call AddCuentaAutomatica(mlistaITFAutomatico, .CentroCostoId, .SucursalId, decITF, strCompDetChequeNro)

                  If clsAppInfo.ExigirEEFF Then
                     Dim lngPlanEEFFId As Long = mdicListaPlanEEFFporITF.Item("" & .PlanId & "," & .CentroCostoId & "," & .SucursalId)
                     Call DataSaveCompPlanEEFFHaber(decITF, lngCompDetId, .PlanId, lngPlanEEFFId, lngEstadoId)
                  End If
               End If
            End If
         End If

         If .TipoId = clsCompDet.DESCUENTO Then 'Detalle de Descuento
            If .DebeOrg > 0 Then
               If mboolAplicarImpuestoDescuento Then
                  decDescuentoIva = .DebeOrg * moComp.PorIVA
               Else
                  decDescuentoIva = 0
               End If

               If .MonedaId = 1 Then
                  .DebeBs = .DebeOrg - decDescuentoIva
                  .DebeUs = ToDecimal(.DebeBs / moComp.TipoCambio)
               ElseIf .MonedaId = 2 Then
                  .DebeUs = .DebeOrg - decDescuentoIva
                  .DebeBs = ToDecimal(.DebeUs * moComp.TipoCambio)
               End If

               If decDescuentoIva > 0 Then
                  Call CompPlanAddIVA(.CompId, .CompDetId, .DebeOrg, decDescuentoIva)
                  Call CompCentroCostoDetIVA(.CompId, .CompDetId, .DebeOrg, decDescuentoIva)
               End If
            End If
         End If

         If (Not boolFacturaGlobal) And (Not boolFacturaIndividual) And (Not boolFacturaAgrupada) And (Not mboolITF) And .TipoId = 0 Then
            If .DebeOrg <> 0 Then
               If .MonedaId = 1 Then
                  .DebeBs = .DebeOrg
                  .HaberBs = 0
                  .DebeUs = ToDecimal(.DebeOrg / moComp.TipoCambio)
                  .HaberUs = 0

               ElseIf .MonedaId = 2 Then
                  .DebeBs = ToDecimal(.DebeOrg * moComp.TipoCambio)
                  .HaberBs = 0
                  .DebeUs = .DebeOrg
                  .HaberUs = 0
               End If

            ElseIf .HaberOrg <> 0 Then
               If .MonedaId = 1 Then
                  .DebeBs = 0
                  .HaberBs = .HaberOrg
                  .DebeUs = 0
                  .HaberUs = ToDecimal(.HaberOrg / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .DebeBs = 0
                  .HaberBs = ToDecimal(.HaberOrg * moComp.TipoCambio)
                  .DebeUs = 0
                  .HaberUs = .HaberOrg
               End If
            End If
         End If

         .Fecha = ToDate(.Fecha)
         .EstadoId = lngEstadoId

         If .Update() Then
            IngresoUpdate = True
         End If
      End With
   End Function

   Private Function CompPlanAddRetencion(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decMontoOrg As Decimal, ByVal decRetencionOrg As Decimal) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      Try
         CompPlanAddRetencion = False

         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.All
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If moComp.MonedaId = 1 Then
                     If .DebeOrg > 0 Then
                        .DebeBs = .DebeBs + ToDecimal((.DebeBs / decMontoOrg) * decRetencionOrg)
                        .DebeUs = ToDecimal(.DebeBs / moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberBs = .HaberBs - ToDecimal((.HaberBs / decMontoOrg) * decRetencionOrg)
                        .HaberUs = ToDecimal(.HaberBs / moComp.TipoCambio)
                     End If

                  ElseIf moComp.MonedaId = 2 Then
                     If .DebeOrg > 0 Then
                        .DebeUs = .DebeUs + ToDecimal((.DebeUs / decMontoOrg) * decRetencionOrg)
                        .DebeBs = ToDecimal(.DebeUs * moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberUs = .HaberUs - ToDecimal((.HaberUs / decMontoOrg) * decRetencionOrg)
                        .HaberBs = ToDecimal(.HaberUs * moComp.TipoCambio)
                     End If
                  End If

                  .Fecha = ToDate(.Fecha)

                  If .Update() Then
                     CompPlanAddRetencion = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CompPlanEEFFRetencion(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decMontoOrg As Decimal, ByVal decRetencionOrg As Decimal) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

      Try
         CompPlanEEFFRetencion = False

         With oCompPlanEEFF
            .SelectFilter = clsCompPlanEEFF.SelectFilters.All
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If moComp.MonedaId = 1 Then
                     If .DebeOrg > 0 Then
                        .DebeBs = .DebeBs + ToDecimal((.DebeBs / decMontoOrg) * decRetencionOrg)
                        .DebeUs = ToDecimal(.DebeBs / moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberBs = .HaberBs - ToDecimal((.HaberBs / decMontoOrg) * decRetencionOrg)
                        .HaberUs = ToDecimal(.HaberBs / moComp.TipoCambio)
                     End If

                  ElseIf moComp.MonedaId = 2 Then
                     If .DebeOrg > 0 Then
                        .DebeUs = .DebeUs + ToDecimal((.DebeUs / decMontoOrg) * decRetencionOrg)
                        .DebeBs = ToDecimal(.DebeUs * moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberUs = .HaberUs - ToDecimal((.HaberUs / decMontoOrg) * decRetencionOrg)
                        .HaberBs = ToDecimal(.HaberUs * moComp.TipoCambio)
                     End If
                  End If

                  .Fecha = ToDate(.Fecha)

                  If .Update() Then
                     CompPlanEEFFRetencion = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         Throw exp
      Finally
         oCompPlanEEFF.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetRetencion(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decMontoOrg As Decimal, ByVal decRetencionOrg As Decimal) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      Try
         CompCentroCostoDetRetencion = False

         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If moComp.MonedaId = 1 Then
                     If .DebeOrg > 0 Then
                        .DebeBs = .DebeBs + ToDecimal((.DebeBs / decMontoOrg) * decRetencionOrg)
                        .DebeUs = ToDecimal(.DebeBs / moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberBs = .HaberBs - ToDecimal((.HaberBs / decMontoOrg) * decRetencionOrg)
                        .HaberUs = ToDecimal(.HaberBs / moComp.TipoCambio)
                     End If

                  ElseIf moComp.MonedaId = 2 Then
                     If .DebeOrg > 0 Then
                        .DebeUs = .DebeUs + ToDecimal((.DebeUs / decMontoOrg) * decRetencionOrg)
                        .DebeBs = ToDecimal(.DebeUs * moComp.TipoCambio)

                     ElseIf .HaberOrg > 0 Then
                        .HaberUs = .HaberUs - ToDecimal((.HaberUs / decMontoOrg) * decRetencionOrg)
                        .HaberBs = ToDecimal(.HaberUs * moComp.TipoCambio)
                     End If
                  End If

                  .Fecha = ToDate(.Fecha)

                  If .Update() Then
                     CompCentroCostoDetRetencion = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompChequeRetencion(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decMontoBs As Decimal, ByVal decMontoUs As Decimal) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)

      Try
         CompChequeRetencion = False

         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If .ChequeMonto > 0 Then
                     If oCompCheque.MonedaId = clsMoneda.BOLIVIANOS Then
                        .ChequeMonto = decMontoBs
                     Else
                        .ChequeMonto = decMontoUs
                     End If
                  End If

                  .Fecha = ToDate(.Fecha)
                  .FechaCob = ToDate(.FechaCob)

                  If .Update() Then
                     CompChequeRetencion = True
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Function ExentoAgrupada(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Decimal
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         ExentoAgrupada = 0
         decMonto = 0

         With oFacturaAgru
            .SelectFilter = clsFacturaAgru.SelectFilters.All
            .WhereFilter = clsFacturaAgru.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read
                  If moComp.MonedaId = 1 Then
                     decMonto += .Exento + .IceIehd

                  ElseIf moComp.MonedaId = 2 Then
                     decMonto += ((.Exento + .IceIehd) / moComp.TipoCambio)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         ExentoAgrupada = decMonto

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Function

   Private Function EgresoUpdate(ByVal oCompDet As clsCompDet, ByVal boolFacturaGlobal As Boolean, ByVal decExePorcentaje As Decimal, _
                                 ByRef decIVARetTotal As Decimal, ByRef decITRetTotal As Decimal, ByRef decIUETotal As Decimal, _
                                 ByVal decDescPorcentaje As Decimal, ByVal lngEstadoId As Long) As Boolean
      Dim decIVA As Decimal
      Dim decITF As Decimal
      Dim decRetencion As Decimal
      Dim decExeMonto As Decimal
      Dim decDebeMonto As Decimal
      Dim decDebe As Decimal
      Dim boolFacturaIndividual As Boolean = False
      Dim boolFacturaAgrupada As Boolean = False
      Dim decExentoIva As Decimal = 0
      Dim decDescuentoIva As Decimal = 0

      With oCompDet
         If boolFacturaGlobal Then
            If (.DebeOrg > 0) And (.Automatico = 0) Then
               decExeMonto = ToDecimal(.DebeOrg * decExePorcentaje)
               decDebeMonto = ToDecimal(.DebeOrg - decExeMonto)

               If clsAppInfo.AplicarDescuento Then
                  If mboolAplicarImpuestoDescuento And decDescPorcentaje > 0 Then
                     decIVA = ToDecimal(decDebeMonto * moComp.PorIVA)

                     decDescuentoIva = .DebeOrg * decDescPorcentaje * moComp.PorIVA
                     Call AddCuentaAutomatica(mlistaIVADescuentoAutomatico, .CentroCostoId, .SucursalId, decDescuentoIva, "")
                  Else
                     decIVA = (ToDecimal(decDebeMonto - ToDecimal(.DebeOrg * decDescPorcentaje)) * moComp.PorIVA)
                  End If
               Else
                  decIVA = ToDecimal(decDebeMonto * moComp.PorIVA)
               End If

               Call AddCuentaAutomatica(mlistaIVAAutomatico, .CentroCostoId, .SucursalId, decIVA, "")

               If clsAppInfo.SepararExento Then
                  decExentoIva = ToDecimal(decExeMonto * moComp.PorIVA)
                  Call AddCuentaAutomatica(mlistaExentoAutomatico, .CentroCostoId, .SucursalId, decExentoIva, "")
               End If

               decDebe = .DebeOrg - decIVA - decExentoIva

               If .MonedaId = 1 Then
                  .DebeBs = decDebe
                  .DebeUs = ToDecimal(decDebe / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .DebeBs = ToDecimal(decDebe * moComp.TipoCambio)
                  .DebeUs = decDebe
               End If

               If decIVA > 0 Then
                  Call CompPlanAddIVA(.CompId, .CompDetId, .DebeOrg, decIVA)
                  Call CompCentroCostoDetIVA(.CompId, .CompDetId, .DebeOrg, decIVA)
                  Call CompPlanEEFFIVA(.CompId, .CompDetId, .DebeOrg, decIVA)
               End If
            End If

         ElseIf TieneFacturaIndividual(.CompId, .CompDetId) Then
            If (.DebeOrg > 0) And (.Automatico = 0) Then
               boolFacturaIndividual = True
               decIVA = IVAIndividual(.CompId, .CompDetId, decExeMonto, 0, decDescuentoIva)

               If clsAppInfo.SepararExento Then
                  Call AddCuentaAutomatica(mlistaExentoAutomatico, .CentroCostoId, .SucursalId, decExeMonto, "")
                  decDebe = .DebeOrg - decIVA - decExeMonto
               Else
                  decDebe = .DebeOrg - decIVA
               End If

               If clsAppInfo.AplicarDescuento And mboolAplicarImpuestoDescuento And decDescuentoIva > 0 Then
                  Call AddCuentaAutomatica(mlistaIVADescuentoAutomatico, .CentroCostoId, .SucursalId, decDescuentoIva, "")
                  decIVA += decDescuentoIva
                  decDebe -= decDescuentoIva
               End If

               Call AddCuentaAutomatica(mlistaIVAAutomatico, .CentroCostoId, .SucursalId, decIVA, "")

               If .MonedaId = 1 Then
                  .DebeBs = decDebe
                  .DebeUs = ToDecimal(decDebe / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .DebeBs = ToDecimal(decDebe * moComp.TipoCambio)
                  .DebeUs = decDebe
               End If

               If decIVA > 0 Then
                  Call CompPlanAddIVA(.CompId, .CompDetId, .DebeOrg, decIVA)
                  Call CompCentroCostoDetIVA(.CompId, .CompDetId, .DebeOrg, decIVA)
                  Call CompPlanEEFFIVA(.CompId, .CompDetId, .DebeOrg, decIVA)
               End If
            End If

            ElseIf TieneFacturaAgrupada(.CompId, .CompDetId) Then
               If (.DebeOrg > 0) And (.Automatico = 0) Then
                  boolFacturaAgrupada = True
                  decIVA = IvaAgrupada(.CompId, .CompDetId)
                  decExeMonto = ExentoAgrupada(.CompId, .CompDetId)
                  Call AddCuentaAutomatica(mlistaIVAAutomatico, .CentroCostoId, .SucursalId, decIVA, "")
                  If clsAppInfo.SepararExento Then
                     Call AddCuentaAutomatica(mlistaExentoAutomatico, .CentroCostoId, .SucursalId, ToDecimal(decExeMonto * moComp.PorIVA), "")
                     decDebe = .DebeOrg - decIVA - ToDecimal(decExeMonto * moComp.PorIVA)
                  Else
                     decDebe = .DebeOrg - decIVA
                  End If

                  If .MonedaId = 1 Then
                     .DebeBs = decDebe
                     .DebeUs = ToDecimal(decDebe / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = ToDecimal(decDebe * moComp.TipoCambio)
                     .DebeUs = decDebe
                  End If

                  If decIVA > 0 Then
                     Call CompPlanAddIVA(.CompId, .CompDetId, .DebeOrg, decIVA)
                     Call CompCentroCostoDetIVA(.CompId, .CompDetId, .DebeOrg, decIVA)
                     Call CompPlanEEFFIVA(.CompId, .CompDetId, .DebeOrg, decIVA)
                  End If
               End If

            ElseIf .TipoRetencionId > 0 Then 'Retencion
               If (.DebeOrg > 0) And (.Automatico = 0) Then
                  If .TipoRetencionId = 1 Then 'Prestación de Servicios (Empresa)
                     decRetencion = (.DebeOrg / (1 - (moComp.PorIT + clsAppInfo.IUEServicio))) - .DebeOrg
                     decIUETotal = ToDecimal((.DebeOrg + decRetencion) * clsAppInfo.IUEServicio)

                  ElseIf .TipoRetencionId = 2 Then 'Compra de Bienes (Empresa)
                     decRetencion = (.DebeOrg / (1 - (moComp.PorIT + clsAppInfo.IUEBien))) - .DebeOrg
                     decIUETotal = ToDecimal((.DebeOrg + decRetencion) * clsAppInfo.IUEBien)

                  ElseIf .TipoRetencionId = 3 Then 'Alquiler de Bienes e Inmuebles (Empresa)
                     decRetencion = (.DebeOrg / (1 - (moComp.PorIT + moComp.PorIVA))) - .DebeOrg
                     decIVARetTotal = ToDecimal((.DebeOrg + decRetencion) * moComp.PorIVA)
                  End If

                  decITRetTotal = ToDecimal((.DebeOrg + decRetencion) * moComp.PorIT)

                  If .MonedaId = 1 Then
                     .DebeBs = ToDecimal(.DebeOrg + decRetencion)
                     .DebeUs = ToDecimal((.DebeOrg + decRetencion) / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = ToDecimal((.DebeOrg + decRetencion) * moComp.TipoCambio)
                     .DebeUs = ToDecimal(.DebeOrg + decRetencion)
                  End If

                  If decRetencion > 0 Then
                     Call CompPlanAddRetencion(.CompId, .CompDetId, .DebeOrg, decRetencion)
                     Call CompCentroCostoDetRetencion(.CompId, .CompDetId, .DebeOrg, decRetencion)
                     Call CompPlanEEFFRetencion(.CompId, .CompDetId, .DebeOrg, decRetencion)
                  End If

               ElseIf (.HaberOrg > 0) And (.Automatico = 0) Then
                  decITRetTotal = ToDecimal(.HaberOrg * moComp.PorIT)

                  If .TipoRetencionId = 4 Then 'Prestación de Servicios (Proveedor)
                     decIUETotal = ToDecimal(.HaberOrg * clsAppInfo.IUEServicio)
                     decRetencion = ToDecimal(.HaberOrg * (moComp.PorIT + clsAppInfo.IUEServicio))

                  ElseIf .TipoRetencionId = 5 Then 'Compra de Bienes (Proveedor)
                     decIUETotal = ToDecimal(.HaberOrg * clsAppInfo.IUEBien)
                     decRetencion = ToDecimal(.HaberOrg * (moComp.PorIT + clsAppInfo.IUEBien))

                  ElseIf .TipoRetencionId = 6 Then 'Alquiler de Bienes e Inmuebles (Proveedor)
                     decIVARetTotal = ToDecimal(.HaberOrg * moComp.PorIVA)
                     decRetencion = ToDecimal(.HaberOrg * (moComp.PorIT + moComp.PorIVA))
                  End If

                  If .MonedaId = 1 Then
                     .HaberBs = ToDecimal(.HaberOrg - decRetencion)
                     .HaberUs = ToDecimal((.HaberOrg - decRetencion) / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .HaberBs = ToDecimal((.HaberOrg - decRetencion) * moComp.TipoCambio)
                     .HaberUs = ToDecimal(.HaberOrg - decRetencion)
                  End If

                  If decRetencion > 0 Then
                     Call CompPlanAddRetencion(.CompId, .CompDetId, .HaberOrg, decRetencion)
                     Call CompCentroCostoDetRetencion(.CompId, .CompDetId, .HaberOrg, decRetencion)
                     Call CompPlanEEFFRetencion(.CompId, .CompDetId, .HaberOrg, decRetencion)
                     Call CompChequeRetencion(.CompId, .CompDetId, .HaberBs, .HaberUs)
                  End If
               End If
            End If

         If mboolITF Then 'ITF
            If TieneITF(.PlanId, "") Then
               If (.DebeOrg > 0) And (.Automatico = 0) Then '1000
                  decITF = ToDecimal(.DebeOrg * moComp.PorITF) '2.5

                  If .MonedaId = 1 Then
                     .DebeBs = .DebeOrg
                     .DebeUs = ToDecimal(.DebeOrg / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = ToDecimal(.DebeOrg * moComp.TipoCambio)
                     .DebeUs = .DebeOrg
                  End If

               ElseIf (.HaberOrg > 0) And (.Automatico = 0) Then '1000
                  If .TipoRetencionId = 0 Then
                     decITF = ToDecimal(.HaberOrg * moComp.PorITF) '2.5

                     If .MonedaId = 1 Then
                        .HaberBs = .HaberOrg
                        .HaberUs = ToDecimal(.HaberOrg / moComp.TipoCambio)

                     ElseIf .MonedaId = 2 Then
                        .HaberBs = ToDecimal(.HaberOrg * moComp.TipoCambio)
                        .HaberUs = .HaberOrg
                     End If
                  Else 'Existe Retencion con descuento 
                     If .MonedaId = 1 Then
                        decITF = ToDecimal(.HaberBs * moComp.PorITF) '2.5
                     ElseIf .MonedaId = 2 Then
                        decITF = ToDecimal(.HaberUs * moComp.PorITF) '2.5
                     End If
                  End If
               End If

               If decITF > 0 Then
                  Dim lngCompDetId As Long = 0
                  Dim strCompDetChequeNro As String = CompDetChequeNro(.CompDetId, .PlanId)
                  Call DataSaveITFHaber(decITF, strCompDetChequeNro, .PlanId, .SucursalId, .CentroCostoId, lngEstadoId, lngCompDetId)
                  Call AddCuentaAutomatica(mlistaITFAutomatico, .CentroCostoId, .SucursalId, decITF, strCompDetChequeNro)

                  If clsAppInfo.ExigirEEFF Then
                     Dim lngPlanEEFFId As Long = mdicListaPlanEEFFporITF.Item("" & .PlanId & "," & .CentroCostoId & "," & .SucursalId)
                     Call DataSaveCompPlanEEFFHaber(decITF, lngCompDetId, .PlanId, lngPlanEEFFId, lngEstadoId)
                  End If
               End If
            End If
         End If

         If .TipoId = clsCompDet.DESCUENTO Then 'Detalle de Descuento
            If .HaberOrg > 0 Then
               If mboolAplicarImpuestoDescuento Then
                  decDescuentoIva = .HaberOrg * moComp.PorIVA
               Else
                  decDescuentoIva = 0
               End If

               If .MonedaId = 1 Then
                  .HaberBs = .HaberOrg - decDescuentoIva
                  .HaberUs = ToDecimal(.HaberBs / moComp.TipoCambio)
               ElseIf .MonedaId = 2 Then
                  .HaberUs = .HaberOrg - decDescuentoIva
                  .HaberBs = ToDecimal(.HaberUs * moComp.TipoCambio)
               End If

               If decDescuentoIva > 0 Then
                  Call CompPlanAddIVA(.CompId, .CompDetId, .HaberOrg, decDescuentoIva)
                  Call CompCentroCostoDetIVA(.CompId, .CompDetId, .HaberOrg, decDescuentoIva)
               End If
            End If
         End If

         If (Not boolFacturaGlobal) And (Not boolFacturaIndividual) And (Not boolFacturaAgrupada) And (.TipoRetencionId = 0) And (Not mboolITF) And .TipoId = 0 Then
            If .DebeOrg > 0 Then
               If .MonedaId = 1 Then
                  .DebeBs = .DebeOrg
                  .HaberBs = 0
                  .DebeUs = ToDecimal(.DebeOrg / moComp.TipoCambio)
                  .HaberUs = 0

               ElseIf .MonedaId = 2 Then
                  .DebeBs = ToDecimal(.DebeOrg * moComp.TipoCambio)
                  .HaberBs = 0
                  .DebeUs = .DebeOrg
                  .HaberUs = 0
               End If

            ElseIf .HaberOrg > 0 Then
               If .MonedaId = 1 Then
                  .DebeBs = 0
                  .HaberBs = .HaberOrg
                  .DebeUs = 0
                  .HaberUs = ToDecimal(.HaberOrg / moComp.TipoCambio)

               ElseIf .MonedaId = 2 Then
                  .DebeBs = 0
                  .HaberBs = ToDecimal(.HaberOrg * moComp.TipoCambio)
                  .DebeUs = 0
                  .HaberUs = .HaberOrg
               End If
            End If
         End If

         .Fecha = ToDate(.Fecha)
         .EstadoId = lngEstadoId

         If .Update() Then
            EgresoUpdate = True
         End If
      End With
   End Function

   Private Sub AddCuentaAutomatica(ByRef lista As List(Of strucPlanIdAutomatico), ByVal lngCentroCostoId As Long, ByVal lngSucursalId As Long, ByVal decMonto As Decimal, ByVal strCompDetDes As String)
      If decMonto > 0 Then
         Dim DetAutomatico As New strucPlanIdAutomatico
         With DetAutomatico
            .CentroCostoId = lngCentroCostoId
            .SucursalId = lngSucursalId
            .Monto = decMonto
            .CompDetDes = strCompDetDes
         End With

         lista.Add(DetAutomatico)
      End If
   End Sub

   Private Function DeleteCompDetAuto() As Boolean
      If moComp.Automatico = 0 Then
         Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

         Try
            DeleteCompDetAuto = False

            With oCompDet
               .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .Automatico = 1

               Call DeleteCompPlanEEFFAuto()

               If .Delete Then
                  DeleteCompDetAuto = True
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         Finally
            oCompDet.Dispose()

         End Try

      Else
         DeleteCompDetAuto = True
      End If
   End Function

   Private Function DeleteCompPlanEEFFAuto() As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)
      Try
         DeleteCompPlanEEFFAuto = False

         With oCompPlanEEFF
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompDetIdAutomatico
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId

            If .Delete() Then
               DeleteCompPlanEEFFAuto = True
            End If
         End With

      Catch exp As Exception
         Throw exp
      Finally
         oCompPlanEEFF.Dispose()
      End Try
   End Function

   Private Function DataSavePlanIdIT(ByVal lngPlanId As Long, ByVal lngEstadoId As Long, ByVal strListaFactura As String) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim lngSucCCOId As Long = PlanIdSucCCOFind(lngPlanId)
      Dim decMonto As Decimal = 0
      Try
         DataSavePlanIdIT = False

         For Each item In mlistaITAutomatico
            decMonto = item.Monto

            With oCompDet
               .SelectFilter = clsCompDet.SelectFilters.All
               .WhereFilter = clsCompDet.WhereFilters.PlanIdAutomaticoSucCCO
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .PlanId = lngPlanId
               If lngSucCCOId = clsSucCCO.CENTRO_COSTO Then
                  .CentroCostoId = item.CentroCostoId
               ElseIf lngSucCCOId = clsSucCCO.SUCURSAL Then
                  .SucursalId = item.SucursalId
               End If

               .Automatico = 1

               If Not .Find Then
                  .EmpresaId = moComp.EmpresaId
                  .CompId = moComp.CompId
                  .GestionId = moComp.GestionId
                  .TipoCompId = moComp.TipoCompId
                  .Fecha = moComp.Fecha
                  .PlanId = lngPlanId
                  .CompDetDes = strListaFactura
                  .SucursalId = item.SucursalId
                  .CentroCostoId = item.CentroCostoId
                  .MonedaId = moComp.MonedaId

                  .DebeOrg = decMonto
                  .HaberOrg = 0

                  If .MonedaId = 1 Then
                     .DebeBs = decMonto
                     .HaberBs = 0
                     .DebeUs = ToDecimal(decMonto / moComp.TipoCambio)
                     .HaberUs = 0

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = ToDecimal(decMonto * moComp.TipoCambio)
                     .HaberBs = 0
                     .DebeUs = decMonto
                     .HaberUs = 0
                  End If

                  .Orden = 0
                  .Automatico = 1
                  .EstadoId = lngEstadoId

                  If .Insert Then
                     DataSavePlanIdIT = True
                  End If

               Else
                  .DebeOrg += decMonto
                  .HaberOrg = 0

                  If .MonedaId = 1 Then
                     .DebeBs += decMonto
                     .HaberBs = 0
                     .DebeUs += ToDecimal(decMonto / moComp.TipoCambio)
                     .HaberUs = 0

                  ElseIf .MonedaId = 2 Then
                     .DebeBs += ToDecimal(decMonto * moComp.TipoCambio)
                     .HaberBs = 0
                     .DebeUs += decMonto
                     .HaberUs = 0
                  End If

                  .CompDetDes = strListaFactura
                  .Fecha = moComp.Fecha
                  .EstadoId = lngEstadoId

                  If .Update Then
                     DataSavePlanIdIT = True
                  End If
               End If
            End With
         Next
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function DataSavePlanIdITP(ByVal lngPlanId As Long, ByVal lngEstadoId As Long, ByVal strListaFactura As String) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim lngSucCCOId As Long = PlanIdSucCCOFind(lngPlanId)
      Dim decMonto As Decimal = 0

      Try
         DataSavePlanIdITP = False

         For Each item In mlistaITAutomatico
            decMonto = item.Monto

            With oCompDet
               .SelectFilter = clsCompDet.SelectFilters.All
               .WhereFilter = clsCompDet.WhereFilters.PlanIdAutomaticoSucCCO
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .PlanId = lngPlanId
               If lngSucCCOId = clsSucCCO.CENTRO_COSTO Then
                  .CentroCostoId = item.CentroCostoId
               ElseIf lngSucCCOId = clsSucCCO.SUCURSAL Then
                  .SucursalId = item.SucursalId
               End If
               .Automatico = 1

               If Not .Find Then
                  .EmpresaId = moComp.EmpresaId
                  .CompId = moComp.CompId
                  .GestionId = moComp.GestionId
                  .TipoCompId = moComp.TipoCompId
                  .Fecha = moComp.Fecha
                  .PlanId = lngPlanId
                  .CompDetDes = strListaFactura
                  .SucursalId = item.SucursalId
                  .CentroCostoId = item.CentroCostoId
                  .MonedaId = moComp.MonedaId

                  .DebeOrg = 0
                  .HaberOrg = decMonto

                  If .MonedaId = 1 Then
                     .DebeBs = 0
                     .HaberBs = decMonto
                     .DebeUs = 0
                     .HaberUs = ToDecimal(decMonto / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = 0
                     .HaberBs = ToDecimal(decMonto * moComp.TipoCambio)
                     .DebeUs = 0
                     .HaberUs = decMonto
                  End If

                  .Orden = 0
                  .Automatico = 1
                  .EstadoId = lngEstadoId

                  If .Insert Then
                     DataSavePlanIdITP = True
                  End If
               Else
                  .DebeOrg = 0
                  .HaberOrg += decMonto

                  If .MonedaId = 1 Then
                     .DebeBs = 0
                     .HaberBs += decMonto
                     .DebeUs = 0
                     .HaberUs += ToDecimal(decMonto / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = 0
                     .HaberBs += ToDecimal(decMonto * moComp.TipoCambio)
                     .DebeUs = 0
                     .HaberUs += decMonto
                  End If

                  .CompDetDes = strListaFactura
                  .Fecha = moComp.Fecha
                  .EstadoId = lngEstadoId

                  If .Update Then
                     DataSavePlanIdITP = True
                  End If
               End If
            End With
         Next
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function DataSavePlanIdDeb(ByVal listaDeb As List(Of strucPlanIdAutomatico), ByVal lngPlanId As Long, ByVal lngEstadoId As Long, ByVal strListaFactura As String) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim lngSucCCOId As Long = PlanIdSucCCOFind(lngPlanId)
      Dim decMonto As Decimal = 0

      Try
         DataSavePlanIdDeb = False

         For Each item In listaDeb
            decMonto = item.Monto

            With oCompDet
               .SelectFilter = clsCompDet.SelectFilters.All
               .WhereFilter = clsCompDet.WhereFilters.PlanIdAutomaticoSucCCO
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .PlanId = lngPlanId
               If lngSucCCOId = clsSucCCO.CENTRO_COSTO Then
                  .CentroCostoId = item.CentroCostoId
               ElseIf lngSucCCOId = clsSucCCO.SUCURSAL Then
                  .SucursalId = item.SucursalId
               End If
               .Automatico = 1

               If Not .Find Then
                  .EmpresaId = moComp.EmpresaId
                  .CompId = moComp.CompId
                  .GestionId = moComp.GestionId
                  .TipoCompId = moComp.TipoCompId
                  .Fecha = moComp.Fecha
                  .PlanId = lngPlanId
                  .CompDetDes = strListaFactura
                  .SucursalId = item.SucursalId
                  .CentroCostoId = item.CentroCostoId
                  .MonedaId = moComp.MonedaId

                  .DebeOrg = 0
                  .HaberOrg = decMonto

                  If .MonedaId = 1 Then
                     .DebeBs = 0
                     .HaberBs = decMonto
                     .DebeUs = 0
                     .HaberUs = ToDecimal(decMonto / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = 0
                     .HaberBs = ToDecimal(decMonto * moComp.TipoCambio)
                     .DebeUs = 0
                     .HaberUs = decMonto
                  End If

                  .Orden = 0
                  .Automatico = 1
                  .EstadoId = lngEstadoId

                  If .Insert Then
                     DataSavePlanIdDeb = True
                  End If

               Else
                  .DebeOrg = 0
                  .HaberOrg += decMonto

                  If .MonedaId = 1 Then
                     .DebeBs = 0
                     .HaberBs += decMonto
                     .DebeUs = 0
                     .HaberUs += ToDecimal(decMonto / moComp.TipoCambio)

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = 0
                     .HaberBs += ToDecimal(decMonto * moComp.TipoCambio)
                     .DebeUs = 0
                     .HaberUs += decMonto
                  End If

                  .CompDetDes = strListaFactura
                  .Fecha = moComp.Fecha
                  .EstadoId = lngEstadoId

                  If .Update Then
                     DataSavePlanIdDeb = True
                  End If
               End If
            End With
         Next
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function DataSavePlanIdCred(ByVal listaCred As List(Of strucPlanIdAutomatico), ByVal lngPlanId As Long, ByVal lngEstadoId As Long, ByVal strListaFactura As String) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim lngSucCCOId As Long = PlanIdSucCCOFind(lngPlanId)
      Dim decIVATotal As Decimal = 0

      Try
         DataSavePlanIdCred = False

         For Each item In listaCred
            decIVATotal = item.Monto

            With oCompDet
               .SelectFilter = clsCompDet.SelectFilters.All
               .WhereFilter = clsCompDet.WhereFilters.PlanIdAutomaticoSucCCO
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .PlanId = lngPlanId
               If lngSucCCOId = clsSucCCO.CENTRO_COSTO Then
                  .CentroCostoId = item.CentroCostoId
               ElseIf lngSucCCOId = clsSucCCO.SUCURSAL Then
                  .SucursalId = item.SucursalId
               End If
               .Automatico = 1

               If Not .Find Then
                  .EmpresaId = moComp.EmpresaId
                  .CompId = moComp.CompId
                  .GestionId = moComp.GestionId
                  .TipoCompId = moComp.TipoCompId
                  .Fecha = moComp.Fecha
                  .PlanId = lngPlanId
                  .CompDetDes = strListaFactura
                  .SucursalId = item.SucursalId
                  .CentroCostoId = item.CentroCostoId
                  .MonedaId = moComp.MonedaId

                  .DebeOrg = decIVATotal
                  .HaberOrg = 0

                  If .MonedaId = 1 Then
                     .DebeBs = decIVATotal
                     .HaberBs = 0
                     .DebeUs = ToDecimal(decIVATotal / moComp.TipoCambio)
                     .HaberUs = 0

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = ToDecimal(decIVATotal * moComp.TipoCambio)
                     .HaberBs = 0
                     .DebeUs = decIVATotal
                     .HaberUs = 0
                  End If

                  .Orden = 0
                  .Automatico = 1
                  .EstadoId = lngEstadoId

                  If .Insert Then
                     DataSavePlanIdCred = True
                  End If
               Else
                  .DebeOrg += decIVATotal
                  .HaberOrg = 0

                  If .MonedaId = 1 Then
                     .DebeBs += decIVATotal
                     .HaberBs = 0
                     .DebeUs += ToDecimal(decIVATotal / moComp.TipoCambio)
                     .HaberUs = 0

                  ElseIf .MonedaId = 2 Then
                     .DebeBs += ToDecimal(decIVATotal * moComp.TipoCambio)
                     .HaberBs = 0
                     .DebeUs += decIVATotal
                     .HaberUs = 0
                  End If

                  .CompDetDes = strListaFactura
                  .Fecha = moComp.Fecha
                  .EstadoId = lngEstadoId

                  If .Update Then
                     DataSavePlanIdCred = True
                  End If
               End If
            End With
         Next
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function PlanIdSucCCOFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      PlanIdSucCCOFind = 0
      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanIdSucCCOFind = .SucCCOId
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Function DataSaveITFDebe(ByVal lngPlanId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim lngSucCCOId As Long = PlanIdSucCCOFind(lngPlanId)
      Dim decITFTotal As Decimal
      Dim strDes As String
      Try
         DataSaveITFDebe = False

         For Each item In mlistaITFAutomatico
            decITFTotal = item.Monto
            strDes = item.CompDetDes

            With oCompDet
               .SelectFilter = clsCompDet.SelectFilters.All
               .WhereFilter = clsCompDet.WhereFilters.PlanIdAutomaticoSucCCO
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .PlanId = lngPlanId

               If lngSucCCOId = clsSucCCO.CENTRO_COSTO Then
                  .CentroCostoId = item.CentroCostoId
               ElseIf lngSucCCOId = clsSucCCO.SUCURSAL Then
                  .SucursalId = item.SucursalId
               End If

               .Automatico = 1

               If Not .Find Then
                  .EmpresaId = moComp.EmpresaId
                  .CompId = moComp.CompId
                  .GestionId = moComp.GestionId
                  .TipoCompId = moComp.TipoCompId
                  .Fecha = moComp.Fecha
                  .PlanId = lngPlanId
                  .CompDetDes = strDes
                  .SucursalId = item.SucursalId
                  .CentroCostoId = item.CentroCostoId
                  .MonedaId = moComp.MonedaId

                  .DebeOrg = decITFTotal
                  .HaberOrg = 0

                  If .MonedaId = 1 Then
                     .DebeBs = decITFTotal
                     .HaberBs = 0
                     .DebeUs = ToDecimal(decITFTotal / moComp.TipoCambio)
                     .HaberUs = 0

                  ElseIf .MonedaId = 2 Then
                     .DebeBs = ToDecimal(decITFTotal * moComp.TipoCambio)
                     .HaberBs = 0
                     .DebeUs = decITFTotal
                     .HaberUs = 0
                  End If

                  .Orden = 0
                  .Automatico = 1
                  .EstadoId = lngEstadoId

                  If .Insert Then
                     DataSaveITFDebe = True
                  End If

               Else
                  If Not String.IsNullOrEmpty(strDes) Then
                     .CompDetDes &= ", " & strDes
                  End If

                  .DebeOrg += decITFTotal
                  .HaberOrg = 0

                  If .MonedaId = 1 Then
                     .DebeBs += decITFTotal
                     .HaberBs = 0
                     .DebeUs += ToDecimal(decITFTotal / moComp.TipoCambio)
                     .HaberUs = 0

                  ElseIf .MonedaId = 2 Then
                     .DebeBs += ToDecimal(decITFTotal * moComp.TipoCambio)
                     .HaberBs = 0
                     .DebeUs += decITFTotal
                     .HaberUs = 0
                  End If

                  .Fecha = moComp.Fecha
                  .EstadoId = lngEstadoId

                  If .Update Then
                     DataSaveITFDebe = True
                  End If
                  End If
            End With
         Next

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function ListaFacturaNro(ByVal lngCompId As Long, ByRef strFacturaNroExe As String) As String
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim strFacturaNro As String = ""

      Try
         ListaFacturaNro = ""
         strFacturaNroExe = ""

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read
                  If strFacturaNro <> "" Then
                     strFacturaNro &= "; "
                  End If

                  strFacturaNro &= "NIT: " & ToStr(.NroRUC) & " Fact: " & ToStr(.FacturaNro)

                  If .Exento > 0 Then
                     If strFacturaNroExe <> "" Then
                        strFacturaNroExe &= "; "
                     End If

                     strFacturaNroExe &= "NIT: " & ToStr(.NroRUC) & " Fact: " & ToStr(.FacturaNro)
                  End If

                  .MoveNext()
               Loop
            End If

            strFacturaNroExe = Microsoft.VisualBasic.Left(strFacturaNroExe, 1000)
            ListaFacturaNro = Microsoft.VisualBasic.Left(strFacturaNro, 1000)
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function ExentoGlobal(ByVal lngCompId As Long) As Decimal
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         ExentoGlobal = 0
         decMonto = 0

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = 0

            If .Find Then
               If .FacturaMonto <> 0 Then
                  If clsAppInfo.AplicarDescuento Then
                     decMonto = (.Exento + .IceIehd) / (.FacturaMonto + .Recargo)
                  Else
                     decMonto = (.Exento + .IceIehd) / (.FacturaMonto + .Recargo - .Descuento)
                  End If
               Else
                  decMonto = 0
               End If
            End If
         End With

         ExentoGlobal = decMonto

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function DeleteFactura(ByVal lngCompDetId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      DeleteFactura = False

      Try
         With oFactura
            .WhereFilter = clsFactura.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .CompDetId = lngCompDetId

            If .Delete Then
               DeleteFactura = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function DeleteFacturaAgru(ByVal lngCompDetId As Long) As Boolean
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)

      DeleteFacturaAgru = False

      Try
         With oFacturaAgru
            .WhereFilter = clsFacturaAgru.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .CompDetId = lngCompDetId

            If .Delete Then
               DeleteFacturaAgru = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Function

   Private Function DeleteCompCheque(ByVal lngCompDetId As Long) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)

      DeleteCompCheque = False

      Try
         With oCompCheque
            .WhereFilter = clsCompCheque.WhereFilters.CompDetId
            .CompDetId = lngCompDetId

            If .Delete Then
               DeleteCompCheque = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Function DeleteCompPlanAdd(ByVal lngCompDetId As Long) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      DeleteCompPlanAdd = False

      Try
         With oCompPlanAdd
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .CompDetId = lngCompDetId

            If .Delete Then
               DeleteCompPlanAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function DeleteCompPlanEEFF(ByVal lngCompDetId As Long) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

      DeleteCompPlanEEFF = False

      Try
         With oCompPlanEEFF
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompDetId
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
            .CompDetId = lngCompDetId

            If .Delete() Then
               DeleteCompPlanEEFF = True
            End If
         End With

      Catch exp As Exception
         'MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Throw exp
      Finally
         oCompPlanEEFF.Dispose()

      End Try
   End Function

   Private Function DeleteCompCentroCostoDet(ByVal lngCompDetId As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      DeleteCompCentroCostoDet = False

      Try
         With oCompCentroCostoDet
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .CompDetId = lngCompDetId

            If .Delete Then
               DeleteCompCentroCostoDet = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function AutomaticoUpDate(ByVal lngPlanId As Long, ByVal lngMonedaId As Long, ByVal decValor As Decimal, ByVal lngCol As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim intRow As Integer = 0

      Try
         AutomaticoUpDate = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanIdporCompId
            .EmpresaId = moComp.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .CompId = moComp.CompId
            .PlanId = lngPlanId

            If .Find Then
               If .DebeOrg <> 0 Then
                  If lngCol = 1 Then
                     If lngMonedaId = 1 Then
                        .DebeOrg = .DebeOrg + decValor
                        .DebeBs = .DebeBs + decValor

                     ElseIf lngMonedaId = 2 Then
                        .DebeOrg = .DebeOrg + decValor
                        .DebeUs = .DebeUs + decValor
                     End If

                  ElseIf lngCol = 2 Then
                     If lngMonedaId = 1 Then
                        .DebeOrg = .DebeOrg - decValor
                        .DebeBs = .DebeBs - decValor
                     Else
                        .DebeOrg = .DebeOrg - decValor
                        .DebeUs = .DebeUs - decValor
                     End If
                  End If

               ElseIf .HaberOrg <> 0 Then
                  If lngCol = 1 Then
                     If lngMonedaId = 1 Then
                        .DebeOrg = .DebeOrg - decValor
                        .DebeBs = .DebeBs - decValor

                     ElseIf lngMonedaId = 2 Then
                        .DebeOrg = .DebeOrg - decValor
                        .DebeUs = .DebeUs - decValor
                     End If

                  ElseIf lngCol = 2 Then
                     If lngMonedaId = 1 Then
                        .DebeOrg = .DebeOrg + decValor
                        .DebeBs = .DebeBs + decValor
                     Else
                        .DebeOrg = .DebeOrg + decValor
                        .DebeUs = .DebeUs + decValor
                     End If
                  End If
               End If

               .UpdateFilter = clsCompDet.UpdateFilters.All
               .Fecha = ToDate(.Fecha)

               If .Update Then
                  AutomaticoUpDate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function
#End Region

#Region " DataSet-Detalle "
   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moCompDet.TableName)

      moDataTable.Columns.Add("CompDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EmpresaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("CompDetDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Debe", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Haber", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Equi", Type.GetType("System.Decimal"))
      moDataTable.Columns.Add("Orden", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Automatico", Type.GetType("System.Byte"))
      moDataTable.Columns.Add("TipoRetencionId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SucursalId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CentroCostoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EstadoId", Type.GetType("System.Int32"))
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompDetId") = ToLong(oDataRow("CompDetId"))
      oRow("EmpresaId") = ToLong(oDataRow("EmpresaId"))
      oRow("CompId") = ToLong(oDataRow("CompId"))
      oRow("PlanId") = ToLong(oDataRow("PlanId"))
      oRow("PlanCta") = ToStr(oDataRow("PlanCta"))
      oRow("PlanDes") = ToStr(oDataRow("PlanDes"))
      oRow("CompDetDes") = ToStr(oDataRow("CompDetDes"))

      If mboolEditGrid Then
         If moComp.MonedaId = 1 Then
            If ToDecimal(oDataRow("DebeOrg")) <> 0 Then
               oRow("Debe") = ToDecimal(oDataRow("DebeOrg"))
               oRow("Equi") = ToDecimal(oDataRow("DebeOrg") / moComp.TipoCambio)
               mdecDebe += ToDecimal(oDataRow("DebeOrg"))

            ElseIf ToDecimal(oDataRow("HaberOrg")) <> 0 Then
               oRow("Haber") = ToDecimal(oDataRow("HaberOrg"))
               oRow("Equi") = ToDecimal(oDataRow("HaberOrg") / moComp.TipoCambio)
               mdecHaber += ToDecimal(oDataRow("HaberOrg"))
            End If

         ElseIf moComp.MonedaId = 2 Then
            If ToDecimal(oDataRow("DebeOrg")) <> 0 Then
               oRow("Debe") = ToDecimal(oDataRow("DebeOrg"))
               oRow("Equi") = ToDecimal(oDataRow("DebeOrg") * moComp.TipoCambio)
               mdecDebe += ToDecimal(oDataRow("DebeOrg"))

            ElseIf ToDecimal(oDataRow("HaberOrg")) <> 0 Then
               oRow("Haber") = ToDecimal(oDataRow("HaberOrg"))
               oRow("Equi") = ToDecimal(oDataRow("HaberOrg") * moComp.TipoCambio)
               mdecHaber += ToDecimal(oDataRow("HaberOrg"))
            End If
         End If
      Else
         If moComp.MonedaId = 1 Then
            If ToDecimal(oDataRow("DebeBs")) <> 0 Then
               oRow("Debe") = ToDecimal(oDataRow("DebeBs"))
               oRow("Equi") = ToDecimal(oDataRow("DebeUs"))
               mdecDebe += ToDecimal(oDataRow("DebeBs"))

            ElseIf ToDecimal(oDataRow("HaberBs")) <> 0 Then
               oRow("Haber") = ToDecimal(oDataRow("HaberBs"))
               oRow("Equi") = ToDecimal(oDataRow("HaberUs"))
               mdecHaber += ToDecimal(oDataRow("HaberBs"))

            Else 'Ajuste por diferencia de cambio
               If ToDecimal(oDataRow("DebeUs")) <> 0 Then
                  oRow("Equi") = ToDecimal(oDataRow("DebeUs"))

               ElseIf ToDecimal(oDataRow("HaberUs")) <> 0 Then
                  oRow("Equi") = ToDecimal(oDataRow("HaberUs"))
               End If
            End If

         ElseIf moComp.MonedaId = 2 Then
            If ToDecimal(oDataRow("DebeUs")) <> 0 Then
               oRow("Debe") = ToDecimal(oDataRow("DebeUs"))
               oRow("Equi") = ToDecimal(oDataRow("DebeBs"))
               mdecDebe += ToDecimal(oDataRow("DebeUs"))

            ElseIf ToDecimal(oDataRow("HaberUs")) <> 0 Then
               oRow("Haber") = ToDecimal(oDataRow("HaberUs"))
               oRow("Equi") = ToDecimal(oDataRow("HaberBs"))
               mdecHaber += ToDecimal(oDataRow("HaberUs"))

            Else 'Ajuste por diferencia de cambio
               If ToDecimal(oDataRow("DebeBs")) <> 0 Then
                  oRow("Equi") = ToDecimal(oDataRow("DebeBs"))

               ElseIf ToDecimal(oDataRow("HaberBs")) <> 0 Then
                  oRow("Equi") = ToDecimal(oDataRow("HaberBs"))
               End If
            End If
         End If
      End If

      oRow("Orden") = ToLong(oDataRow("Orden"))
      oRow("Automatico") = ToByte(oDataRow("Automatico"))
      oRow("TipoRetencionId") = ToLong(oDataRow("TipoRetencionId"))
      oRow("SucursalId") = ToLong(oDataRow("SucursalId"))
      oRow("CentroCostoId") = ToLong(oDataRow("CentroCostoId"))
      oRow("TipoId") = ToLong(oDataRow("TipoId"))
      oRow("EstadoId") = ToLong(oDataRow("EstadoId"))

      Return oRow
   End Function
#End Region

#Region " Grid-Detalle "
   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Detalle del Comprobante"
         .ContextMenu = mnuMain

         .RootTable.Columns("CompDetId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("PlanCta").Caption = "Código"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripción"
         .RootTable.Columns("PlanDes").Width = 200
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompDetDes").Caption = "Glosa"
         .RootTable.Columns("CompDetDes").Width = 100
         .RootTable.Columns("CompDetDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CompDetDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Debe").Caption = "Debe"
         .RootTable.Columns("Debe").FormatString = DecimalMask()
         .RootTable.Columns("Debe").Width = 90
         .RootTable.Columns("Debe").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Debe").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Haber").Caption = "Haber"
         .RootTable.Columns("Haber").FormatString = DecimalMask()
         .RootTable.Columns("Haber").Width = 90
         .RootTable.Columns("Haber").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Haber").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Equi").Caption = "Equiv."
         .RootTable.Columns("Equi").FormatString = DecimalMask()
         .RootTable.Columns("Equi").Width = 90
         .RootTable.Columns("Equi").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("Equi").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Orden").Visible = False

         .RootTable.Columns("Automatico").Visible = False

         .RootTable.Columns("TipoRetencionId").Visible = False

         .RootTable.Columns("SucursalId").Visible = False

         .RootTable.Columns("CentroCostoId").Visible = False

         '.RootTable.Columns("TipoGrupoId").Visible = False

         .RootTable.Columns("TipoId").Visible = False

         .RootTable.Columns("EstadoId").Visible = False
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub grdMainLoad()
      Try
         Call moDataSetInit()

         With moCompDet
            .SelectFilter = clsCompDet.SelectFilters.Grid
            .WhereFilter = clsCompDet.WhereFilters.Grid
            .OrderByFilter = clsCompDet.OrderByFilters.Grid

            .CompId = moComp.CompId
            .EmpresaId = moComp.EmpresaId
            If .Open() Then
               mdecDebe = 0
               mdecHaber = 0

               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If mboolEditGrid Then
                     If oRow("Automatico") = 0 Or ToBoolean(moComp.Automatico) Then
                        moDataTable.Rows.Add(GetRow(oRow))
                     End If
                  Else
                     moDataTable.Rows.Add(GetRow(oRow))
                  End If
               Next

               grdMain.DataSource = moDataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()

               txtDebe.Text = ToDecStr(mdecDebe)
               txtHaber.Text = ToDecStr(mdecHaber)

               If mdecDebe > mdecHaber Then
                  txtDebeDif.Text = "0.0"
                  txtHaberDif.Text = ToDecStr(mdecDebe - mdecHaber)
               ElseIf mdecHaber > mdecDebe Then
                  txtDebeDif.Text = ToDecStr(mdecHaber - mdecDebe)
                  txtHaberDif.Text = "0.0"
               Else
                  txtDebeDif.Text = "0.0"
                  txtHaberDif.Text = "0.0"
               End If
            End If

            .CloseConection()
         End With
         Call grdMainInit()
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdMainFormNew()
      Dim frm As New frmCompDetEdit
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         Do
            If mboolAdding Then
               If DataSave(13) Then
                  txtCompId.Text = moComp.CompId
                  Call HeaderReadOnly()

                  With frm
                     .NewRecord = True
                     .Editing = False
                     .Changed = False
                     .NuevoComprobante = mboolNew
                     .TipoCambio = ToDecimal(txtTipoCambio.Text)
                     .IVA = If(moComp.PorIVA <> 0, moComp.PorIVA, clsAppInfo.IVA)
                     .IT = If(moComp.PorIT <> 0, moComp.PorIT, clsAppInfo.IT)
                     .EntregadoA = ToStr(moComp.EntregadoA)

                     oCompDet.EmpresaId = ToLong(moComp.EmpresaId)
                     oCompDet.CompId = ToLong(moComp.CompId)
                     oCompDet.GestionId = ToLong(moComp.GestionId)
                     oCompDet.TipoCompId = ToLong(moComp.TipoCompId)
                     oCompDet.Fecha = ToDate(dtpFecha.Value)
                     oCompDet.MonedaId = ToLong(moComp.MonedaId)
                     oCompDet.EstadoId = 13

                     .TipoAsientoId = ListPosition(cboTipoAsiento, cboTipoAsiento.SelectedIndex)

                     If grdMain.RowCount > 0 Then
                        oCompDet.CompDetDes = ToStr(grdMain.GetValue("CompDetDes"))
                     Else
                        oCompDet.CompDetDes = String.Empty
                     End If

                     .DataObject = oCompDet
                     .ShowDialog()

                     If .Changed Then
                        mboolEditGrid = True
                        Call grdMainLoad()
                        Call grdMainFindRow(frm.ID)
                     End If

                     mboolEditing = True
                  End With
               End If

            ElseIf mboolEditing Then
               With frm
                  .NewRecord = True
                  .Editing = False
                  .Changed = False
                  .NuevoComprobante = mboolNew
                  .TipoCambio = ToDecimal(txtTipoCambio.Text)
                  .IVA = If(moComp.PorIVA <> 0, moComp.PorIVA, clsAppInfo.IVA)
                  .IT = If(moComp.PorIT <> 0, moComp.PorIT, clsAppInfo.IT)
                  .EntregadoA = ToStr(moComp.EntregadoA)

                  oCompDet.EmpresaId = moComp.EmpresaId
                  oCompDet.CompId = moComp.CompId
                  oCompDet.GestionId = moComp.GestionId
                  oCompDet.TipoCompId = moComp.TipoCompId
                  oCompDet.Fecha = ToDate(dtpFecha.Value)
                  oCompDet.MonedaId = moComp.MonedaId
                  oCompDet.EstadoId = 13

                  If grdMain.RowCount > 0 Then
                     oCompDet.CompDetDes = ToStr(grdMain.GetValue("CompDetDes"))
                  Else
                     oCompDet.CompDetDes = String.Empty
                  End If

                  .TipoAsientoId = ListPosition(cboTipoAsiento, cboTipoAsiento.SelectedIndex)
                  .DataObject = oCompDet
                  .ShowDialog()

                  If .Changed Then
                     mboolEditGrid = True
                     Call DataSave(13)
                     Call grdMainLoad()
                     Call grdMainFindRow(frm.ID)
                  End If
               End With
            End If
         Loop Until frm.Changed = False

         frm.Dispose()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Sub

   Private Sub grdMainDataEdit()
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            With oCompDet
               .CompDetId = ToLong(grdMain.GetValue("CompDetId"))

               If .FindByPK Then
                  If ToDecimal(txtTipoCambio.Text) > 0 Then
                     If Not .TipoId = clsCompDet.DESCUENTO Then
                        Dim frm As New frmCompDetEdit

                        frm.NewRecord = False
                        frm.Editing = True
                        frm.NuevoComprobante = mboolNew
                        frm.TipoCambio = ToDecimal(txtTipoCambio.Text)
                        frm.IVA = If(moComp.PorIVA <> 0, moComp.PorIVA, clsAppInfo.IVA)
                        frm.IT = If(moComp.PorIT <> 0, moComp.PorIT, clsAppInfo.IT)
                        frm.EntregadoA = ToStr(moComp.EntregadoA)
                        .Fecha = ToDate(.Fecha)
                        frm.DataObject = oCompDet
                        frm.TipoAsientoId = ListPosition(cboTipoAsiento, cboTipoAsiento.SelectedIndex)
                        frm.ShowDialog()

                        If frm.Changed Then
                           mboolEditGrid = True
                           Call DataSave(13)
                           Call grdMainLoad()
                           Call grdMainFindRow(frm.ID)
                        End If

                        frm.Dispose()
                     Else
                        Dim frm As New frmCompDetEdit

                        frm.NewRecord = False
                        frm.Editing = True
                        frm.NuevoComprobante = mboolNew
                        frm.TipoCambio = ToDecimal(txtTipoCambio.Text)
                        frm.IVA = If(moComp.PorIVA <> 0, moComp.PorIVA, clsAppInfo.IVA)
                        frm.IT = If(moComp.PorIT <> 0, moComp.PorIT, clsAppInfo.IT)

                        frm.EntregadoA = ToStr(moComp.EntregadoA)
                        .Fecha = ToDate(.Fecha)
                        frm.ColDescuento = TipoFacturaIdFind(moComp.CompId)
                        'frm.DescuentoSaldo = CompDetDescuentoSaldo()
                        frm.DataObject = oCompDet
                        frm.TipoAsientoId = ListPosition(cboTipoAsiento, cboTipoAsiento.SelectedIndex)
                        frm.ShowDialog()

                        If frm.Changed Then
                           mboolEditGrid = True
                           Call DataSave(13)
                           Call grdMainLoad()
                           Call grdMainFindRow(frm.ID)
                        End If

                        frm.Dispose()
                     End If
                  Else
                     MessageBox.Show("Tipo Cambio Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               End If
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompDet.Dispose()
      End Try
   End Sub

   Private Sub CloneCompDetVM(ByRef oVM As clsCompDetVM)
      If clsAppInfo.RegistrarBitacora And Not mboolNew Then
         oVM = New clsCompDetVM

         With oVM
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))
            .CompId = moComp.CompId
            .CompNro = moComp.CompNro
            .TipoCompId = moComp.TipoCompId
            .TipoCompDes = cboTipoComp.Text
            .PlanId = ToLong(grdMain.GetValue("PlanId"))
            .PlanDes = ToStr(grdMain.GetValue("PlanDes"))
            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Sub grdMainDataDelete()
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("CompId")) > 0 Then
         If Not TieneFacturaIndividual(ToLong(grdMain.GetValue("CompId")), ToLong(grdMain.GetValue("CompDetId"))) Then
            If Not TieneCheque(ToLong(grdMain.GetValue("CompDetId"))) Then
               If MessageBox.Show("¿Realmente Quiere Eliminar el Registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
                  Dim lngCol As Long
                  Dim decValor As Decimal
                  Try
                     If ToDecimal(grdMain.GetValue("Debe")) <> 0 Then
                        lngCol = 1
                        decValor = ToDecimal(grdMain.GetValue("Debe"))

                     ElseIf ToDecimal(grdMain.GetValue("Haber")) <> 0 Then
                        lngCol = 2
                        decValor = ToDecimal(grdMain.GetValue("Haber"))
                     End If

                     With oCompDet
                        .WhereFilter = clsCompDet.WhereFilters.PrimaryKey
                        .CompDetId = ToLong(grdMain.GetValue("CompDetId"))

                        Call CloneCompDetVM(.VMNew)
                        If .Delete Then
                           .CloseConection()

                           If ToBoolean(moComp.Automatico) Then
                              Call AutomaticoUpDate(clsAppInfo.PlanDifId, moComp.MonedaId, decValor, lngCol)
                           End If

                           Call DeleteFactura(ToLong(grdMain.GetValue("CompDetId")))
                           Call DeleteFacturaAgru(ToLong(grdMain.GetValue("CompDetId")))
                           Call DeleteCompCheque(ToLong(grdMain.GetValue("CompDetId")))
                           Call DeleteCompPlanAdd(ToLong(grdMain.GetValue("CompDetId")))
                           Call DeleteCompCentroCostoDet(ToLong(grdMain.GetValue("CompDetId")))
                           Call DeleteCompPlanEEFF(ToLong(grdMain.GetValue("CompDetId")))

                           Call DeleteAllAsientoDescuento(moComp.CompId, ToLong(grdMain.GetValue("CompDetId")))

                           mboolEditGrid = True
                           Call DataSave(13)
                           Call grdMainLoad()
                        End If
                     End With

                  Catch exp As Exception
                     MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                  Finally
                     oCompDet.Dispose()
                  End Try
               End If
            Else
               MessageBox.Show("Imposible Eliminar el Asiento, Debido a Que Tiene Cheque(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Imposible Eliminar el Asiento, Debido a Que Tiene Factura(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub grdMainDataShow()
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Try
         With oCompDet
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))

            If .FindByPK Then
               Dim frm As New frmCompDetEdit

               frm.NewRecord = False
               frm.Editing = False
               .Fecha = ToDate(.Fecha)
               frm.DataObject = oCompDet
               frm.TipoCambio = ToDecimal(txtTipoCambio.Text)
               frm.ShowDialog()
               frm.Dispose()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompDet.Dispose()
      End Try
   End Sub

   Private Sub mnuNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevo.Click
      Call grdMainFormNew()
   End Sub

   Private Sub mnuEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar.Click
      Call grdMainDataEdit()
   End Sub

   Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
      Call grdMainDataDelete()
   End Sub

   Private Sub mnuConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultar.Click
      Call grdMainDataShow()
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call grdMainDataShow()
   End Sub

   Private Sub grdMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMain.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdMain.RowCount > 0 Then
               If ToByte(grdMain.GetValue("Automatico")) = 0 Then
                  mnuConsultar.Enabled = True
                  mnuNuevo.Enabled = True
                  mnuEditar.Enabled = True
                  mnuEliminar.Enabled = True
                  mnuFacturaIndi.Enabled = True
                  mnuFacturaGral.Enabled = True
                  mnuFacturaAnu.Enabled = True
                  mnuFacturaAgru.Enabled = True
                  mnuFacturaAgruAnu.Enabled = True
                  mnuCompPlanAddEdit.Enabled = True
                  mnuCompPlanEEFFEdit.Enabled = True
                  mnuCompCentroCostoDetEdit.Enabled = True
                  mnuAplicarDescuento.Enabled = True
                  mnuAplicarDescuentoConsolidado.Enabled = True
                  If ToLong(grdMain.GetValue("TipoId")) = 1 Then
                     mnuFacturaIndi.Enabled = False
                     mnuFacturaGral.Enabled = False
                     mnuFacturaAnu.Enabled = False
                     mnuFacturaAgru.Enabled = False
                     mnuFacturaAgruAnu.Enabled = False
                  End If
               Else
                  mnuConsultar.Enabled = True
                  If ToBoolean(moComp.Automatico) Then
                     mnuNuevo.Enabled = False
                  Else
                     mnuNuevo.Enabled = True
                  End If
                  mnuEditar.Enabled = False
                  mnuEliminar.Enabled = False
                  mnuFacturaIndi.Enabled = False
                  mnuFacturaGral.Enabled = False
                  mnuFacturaAnu.Enabled = False
                  mnuFacturaAgru.Enabled = False
                  mnuFacturaAgruAnu.Enabled = False
                  mnuCompPlanAddEdit.Enabled = False
                  mnuCompPlanEEFFEdit.Enabled = False
                  mnuCompCentroCostoDetEdit.Enabled = False
                  mnuAplicarDescuento.Enabled = False
                  mnuAplicarDescuentoConsolidado.Enabled = False
               End If
            Else
               mnuConsultar.Enabled = False
               If ToBoolean(moComp.Automatico) Then
                  mnuNuevo.Enabled = False
               Else
                  mnuNuevo.Enabled = True
               End If
               mnuEditar.Enabled = False
               mnuEliminar.Enabled = False
               mnuFacturaIndi.Enabled = False
               mnuFacturaGral.Enabled = False
               mnuFacturaAnu.Enabled = False
               mnuFacturaAgru.Enabled = False
               mnuFacturaAgruAnu.Enabled = False
               mnuCompPlanAddEdit.Enabled = False
               mnuCompPlanEEFFEdit.Enabled = False
               mnuCompCentroCostoDetEdit.Enabled = False
               mnuAplicarDescuento.Enabled = False
               mnuAplicarDescuentoConsolidado.Enabled = False
            End If
         Else
            mnuConsultar.Enabled = True
            mnuNuevo.Enabled = False
            mnuEditar.Enabled = False
            mnuEliminar.Enabled = False
            mnuFacturaIndi.Enabled = False
            mnuFacturaGral.Enabled = False
            mnuFacturaAnu.Enabled = False
            mnuFacturaAgru.Enabled = False
            mnuFacturaAgruAnu.Enabled = False
            mnuCompPlanAddEdit.Enabled = False
            mnuCompPlanEEFFEdit.Enabled = False
            mnuCompCentroCostoDetEdit.Enabled = False
            mnuAplicarDescuento.Enabled = False
            mnuAplicarDescuentoConsolidado.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdMain.RowCount > 0 Then
               If ToByte(grdMain.GetValue("Automatico")) = 0 Then
                  mnuConsultar.Enabled = True
                  mnuNuevo.Enabled = True
                  mnuEditar.Enabled = True
                  mnuEliminar.Enabled = True
                  mnuFacturaIndi.Enabled = True
                  mnuFacturaGral.Enabled = True
                  mnuFacturaAnu.Enabled = True
                  mnuFacturaAgru.Enabled = True
                  mnuFacturaAgruAnu.Enabled = True
                  mnuCompPlanAddEdit.Enabled = True
                  mnuCompPlanEEFFEdit.Enabled = True
                  mnuCompCentroCostoDetEdit.Enabled = True
                  mnuAplicarDescuento.Enabled = True
                  mnuAplicarDescuentoConsolidado.Enabled = True
                  If ToLong(grdMain.GetValue("TipoId")) = 1 Then
                     mnuFacturaIndi.Enabled = False
                     mnuFacturaGral.Enabled = False
                     mnuFacturaAnu.Enabled = False
                     mnuFacturaAgru.Enabled = False
                     mnuFacturaAgruAnu.Enabled = False
                  End If
               Else
                  mnuConsultar.Enabled = True
                  If ToBoolean(moComp.Automatico) Then
                     mnuNuevo.Enabled = False
                  Else
                     mnuNuevo.Enabled = True
                  End If
                  mnuEditar.Enabled = False
                  mnuEliminar.Enabled = False
                  mnuFacturaIndi.Enabled = False
                  mnuFacturaGral.Enabled = False
                  mnuFacturaAnu.Enabled = False
                  mnuFacturaAgru.Enabled = False
                  mnuFacturaAgruAnu.Enabled = False
                  mnuCompPlanAddEdit.Enabled = False
                  mnuCompPlanEEFFEdit.Enabled = False
                  mnuCompCentroCostoDetEdit.Enabled = False
                  mnuAplicarDescuento.Enabled = False
                  mnuAplicarDescuentoConsolidado.Enabled = False
               End If
            Else
               mnuConsultar.Enabled = False
               If ToBoolean(moComp.Automatico) Then
                  mnuNuevo.Enabled = False
               Else
                  mnuNuevo.Enabled = True
               End If
               mnuEditar.Enabled = False
               mnuEliminar.Enabled = False
               mnuFacturaIndi.Enabled = False
               mnuFacturaGral.Enabled = False
               mnuFacturaAnu.Enabled = False
               mnuFacturaAgru.Enabled = False
               mnuFacturaAgruAnu.Enabled = False
               mnuCompPlanAddEdit.Enabled = False
               mnuCompPlanEEFFEdit.Enabled = False
               mnuCompCentroCostoDetEdit.Enabled = False
               mnuAplicarDescuento.Enabled = False
               mnuAplicarDescuentoConsolidado.Enabled = False
            End If
         Else
            mnuConsultar.Enabled = True
            mnuNuevo.Enabled = False
            mnuEditar.Enabled = False
            mnuEliminar.Enabled = False
            mnuFacturaIndi.Enabled = False
            mnuFacturaGral.Enabled = False
            mnuFacturaAnu.Enabled = False
            mnuFacturaAgru.Enabled = False
            mnuFacturaAgruAnu.Enabled = False
            mnuCompPlanAddEdit.Enabled = False
            mnuCompPlanEEFFEdit.Enabled = False
            mnuCompCentroCostoDetEdit.Enabled = False
            mnuAplicarDescuento.Enabled = False
            mnuAplicarDescuentoConsolidado.Enabled = False
         End If
      End If
   End Sub

   Private Sub ListaInit()
      mlistaITFAutomatico.Clear()
      mlistaIVAAutomatico.Clear()
      mlistaExentoAutomatico.Clear()
      mlistaITAutomatico.Clear()
   End Sub

   Private Function CompDetUpdate(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decExePorcentaje As Decimal = 0
      Dim boolFacturaGlobal As Boolean
      Dim boolEsIngreso As Boolean
      Dim decIVARetTotal As Decimal = 0
      Dim decITRetTotal As Decimal = 0
      Dim decIUETotal As Decimal = 0
      Dim strFacturaNro As String
      Dim strFacturaNroExe As String
      Dim decDescPorcentaje As Decimal = 0
      Dim decDescuento As Decimal = 0

      Try
         Call ListaInit()
         CompDetUpdate = False

         If mboolEditGrid Or (moComp.EstadoId = 13) Then
            With oCompDet
               .SelectFilter = clsCompDet.SelectFilters.All
               .WhereFilter = clsCompDet.WhereFilters.CompId
               .EmpresaId = moComp.EmpresaId
               .CompId = lngCompId

               If .Find Then
                  If ToBoolean(moComp.Automatico) = 0 Then
                     Call DeleteCompDetAuto()
                  End If

                  If TieneFacturaGlobal(lngCompId) > 0 Then
                     boolFacturaGlobal = True
                  Else
                     boolFacturaGlobal = False
                  End If

                  If boolFacturaGlobal Then
                     decExePorcentaje = ExentoGlobal(lngCompId) 'Porcentaje
                  End If

                  If clsAppInfo.AplicarDescuento Then
                     decDescuento = TotalDescuentoFacturas(moComp.CompId, 0)
                     decDescPorcentaje = decDescuento / ToDecimal(txtDebe.Text)
                  End If

                  boolEsIngreso = EsIngreso()
                  mstrChequeNro = ""

                  Do While .Read()
                     decIVARetTotal = 0
                     decITRetTotal = 0
                     decIUETotal = 0

                     .Fecha = ToDateDMY(dtpFecha.Value)

                     If ToBoolean(moComp.Automatico) = 0 Then
                        If .TipoCompId = 1 Then 'Ingreso
                           Call IngresoUpdate(oCompDet, boolFacturaGlobal, decExePorcentaje, decDescPorcentaje, lngEstadoId)

                        ElseIf .TipoCompId = 2 Then 'Egreso
                           Call EgresoUpdate(oCompDet, boolFacturaGlobal, decExePorcentaje, decIVARetTotal, decITRetTotal, decIUETotal, decDescPorcentaje, lngEstadoId)

                           If .TipoRetencionId > 0 Then 'Retencion
                              Call DataSaveRetenciones(.TipoRetencionId, lngEstadoId, decIVARetTotal, decITRetTotal, decIUETotal, .CentroCostoId, .SucursalId)
                           End If

                        ElseIf .TipoCompId = 3 Then 'Traspaso
                           If boolEsIngreso Then
                              Call IngresoUpdate(oCompDet, boolFacturaGlobal, decExePorcentaje, decDescPorcentaje, lngEstadoId)

                           Else
                              Call EgresoUpdate(oCompDet, boolFacturaGlobal, decExePorcentaje, decIVARetTotal, decITRetTotal, decIUETotal, decDescPorcentaje, lngEstadoId)

                              If .TipoRetencionId > 0 Then 'Retencion
                                 Call DataSaveRetenciones(.TipoRetencionId, lngEstadoId, decIVARetTotal, decITRetTotal, decIUETotal, .CentroCostoId, .SucursalId)
                              End If
                           End If
                        End If

                     Else
                        .Fecha = ToDate(.Fecha)
                        .EstadoId = lngEstadoId

                        If .Update() Then
                           CompDetUpdate = True
                        End If
                     End If

                     .MoveNext()
                  Loop

                  If mlistaITFAutomatico.Count > 0 Then
                     If DataSaveITFDebe(clsAppInfo.PlanITFId, lngEstadoId) Then
                        CompDetUpdate = True
                     End If
                  End If

                  strFacturaNro = ListaFacturaNro(.CompId, strFacturaNroExe)

                  If .TipoCompId = 1 Then 'Ingreso
                     If mlistaIVAAutomatico.Count > 0 Then
                        If DataSavePlanIdDeb(mlistaIVAAutomatico, clsAppInfo.PlanDebId, lngEstadoId, strFacturaNro) Then
                           If mlistaITAutomatico.Count > 0 Then
                              If DataSavePlanIdIT(clsAppInfo.PlanITId, lngEstadoId, strFacturaNro) Then
                                 If DataSavePlanIdITP(clsAppInfo.PlanITPId, lngEstadoId, strFacturaNro) Then
                                    CompDetUpdate = True
                                 End If
                              End If
                           Else
                              CompDetUpdate = True
                           End If
                        End If

                     ElseIf mlistaITAutomatico.Count > 0 Then
                        If DataSavePlanIdIT(clsAppInfo.PlanITId, lngEstadoId, strFacturaNro) Then
                           If DataSavePlanIdITP(clsAppInfo.PlanITPId, lngEstadoId, strFacturaNro) Then
                              CompDetUpdate = True
                           End If
                        End If
                     Else
                        CompDetUpdate = True
                     End If

                     If mlistaIVADescuentoAutomatico.Count > 0 Then 'Descuento Iva
                        Call DataSavePlanIdCred(mlistaIVADescuentoAutomatico, clsAppInfo.PlanCreId, lngEstadoId, strFacturaNro)
                     End If

                  ElseIf .TipoCompId = 2 Then 'Egreso
                     If mlistaIVAAutomatico.Count > 0 Then
                        If DataSavePlanIdCred(mlistaIVAAutomatico, clsAppInfo.PlanCreId, lngEstadoId, strFacturaNro) Then
                           CompDetUpdate = True
                        End If
                     Else
                        CompDetUpdate = True
                     End If

                     If mlistaExentoAutomatico.Count > 0 Then 'Exento
                        If DataSavePlanIdCred(mlistaExentoAutomatico, clsAppInfo.PlanExentoId, lngEstadoId, strFacturaNroExe) Then
                           CompDetUpdate = True
                        End If
                     Else
                        CompDetUpdate = True
                     End If

                     If mlistaIVADescuentoAutomatico.Count > 0 Then 'Descuento Iva
                        Call DataSavePlanIdDeb(mlistaIVADescuentoAutomatico, clsAppInfo.PlanDebId, lngEstadoId, strFacturaNro)
                     End If

                  ElseIf .TipoCompId = 3 Then 'Traspaso
                     If boolEsIngreso Then
                        If mlistaIVAAutomatico.Count > 0 Then
                           If DataSavePlanIdDeb(mlistaIVAAutomatico, clsAppInfo.PlanDebId, lngEstadoId, strFacturaNro) Then
                              If DataSavePlanIdIT(clsAppInfo.PlanITId, lngEstadoId, strFacturaNro) Then
                                 If DataSavePlanIdITP(clsAppInfo.PlanITPId, lngEstadoId, strFacturaNro) Then
                                    CompDetUpdate = True
                                 End If
                              End If
                           End If

                        ElseIf mlistaITAutomatico.Count > 0 Then
                           If DataSavePlanIdIT(clsAppInfo.PlanITId, lngEstadoId, strFacturaNro) Then
                              If DataSavePlanIdITP(clsAppInfo.PlanITPId, lngEstadoId, strFacturaNro) Then
                                 CompDetUpdate = True
                              End If
                           End If
                        Else
                           CompDetUpdate = True
                        End If

                        If mlistaIVADescuentoAutomatico.Count > 0 Then 'Descuento Iva
                           Call DataSavePlanIdCred(mlistaIVADescuentoAutomatico, clsAppInfo.PlanCreId, lngEstadoId, strFacturaNro)
                        Else
                           CompDetUpdate = True
                        End If
                     Else
                        If mlistaIVAAutomatico.Count > 0 Then
                           If DataSavePlanIdCred(mlistaIVAAutomatico, clsAppInfo.PlanCreId, lngEstadoId, strFacturaNro) Then
                              CompDetUpdate = True
                           End If
                        Else
                           CompDetUpdate = True
                        End If

                        If mlistaExentoAutomatico.Count > 0 Then 'Exento
                           If DataSavePlanIdCred(mlistaExentoAutomatico, clsAppInfo.PlanExentoId, lngEstadoId, strFacturaNroExe) Then
                              CompDetUpdate = True
                           End If
                        Else
                           CompDetUpdate = True
                        End If

                        If mlistaIVADescuentoAutomatico.Count > 0 Then 'Descuento Iva
                           Call DataSavePlanIdDeb(mlistaIVADescuentoAutomatico, clsAppInfo.PlanDebId, lngEstadoId, strFacturaNro)
                        Else
                           CompDetUpdate = True
                        End If
                     End If
                  End If

                  Call CompDetMontoEqui(moComp.CompId, clsAppInfo.PlanDifId) 'Ajuste por diferencia de cambio 

                  If mdecDebeEqui > mdecHaberEqui Then
                     If moComp.MonedaId = 1 Then
                        If DataSavePlanIdDif(lngCompId, clsAppInfo.PlanDifId, 2, mdecDebeEqui - mdecHaberEqui, 2, lngEstadoId) Then
                           CompDetUpdate = True
                        End If
                     Else
                        If DataSavePlanIdDif(lngCompId, clsAppInfo.PlanDifId, 1, mdecDebeEqui - mdecHaberEqui, 2, lngEstadoId) Then
                           CompDetUpdate = True
                        End If
                     End If

                  ElseIf mdecHaberEqui > mdecDebeEqui Then
                     If moComp.MonedaId = 1 Then
                        If DataSavePlanIdDif(lngCompId, clsAppInfo.PlanDifId, 2, mdecHaberEqui - mdecDebeEqui, 1, lngEstadoId) Then
                           CompDetUpdate = True
                        End If
                     Else
                        If DataSavePlanIdDif(lngCompId, clsAppInfo.PlanDifId, 1, mdecHaberEqui - mdecDebeEqui, 1, lngEstadoId) Then
                           CompDetUpdate = True
                        End If
                     End If
                  Else
                     CompDetUpdate = True
                  End If

                  If mdecDebeDifRet > mdecHaberDifRet Then 'Ajuste por redondeo en rentenciones
                     If moComp.MonedaId = 1 Then
                        If DataSavePlanIdDif(lngCompId, clsAppInfo.PlanDifId, 1, mdecDebeDifRet - mdecHaberDifRet, 2, lngEstadoId) Then
                           CompDetUpdate = True
                        End If
                     Else
                        If DataSavePlanIdDif(lngCompId, clsAppInfo.PlanDifId, 2, mdecDebeDifRet - mdecHaberDifRet, 2, lngEstadoId) Then
                           CompDetUpdate = True
                        End If
                     End If

                  ElseIf mdecHaberDifRet > mdecDebeDifRet Then
                     If moComp.MonedaId = 1 Then
                        If DataSavePlanIdDif(lngCompId, clsAppInfo.PlanDifId, 1, mdecHaberDifRet - mdecDebeDifRet, 1, lngEstadoId) Then
                           CompDetUpdate = True
                        End If
                     Else
                        If DataSavePlanIdDif(lngCompId, clsAppInfo.PlanDifId, 2, mdecHaberDifRet - mdecDebeDifRet, 1, lngEstadoId) Then
                           CompDetUpdate = True
                        End If
                     End If
                  Else
                     CompDetUpdate = True
                  End If
               End If
            End With

         Else
            CompDetUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function UpdateCompDetTemp(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      UpdateCompDetTemp = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read
                  .Fecha = ToDate(dtpFecha.Value)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     'UpdateCompDetTemp = True
                  End If

                  .MoveNext()
               Loop

               UpdateCompDetTemp = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function UpdateFacturaTemp(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      UpdateFacturaTemp = False

      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read
                  .FacturaFecha = ToDate(.FacturaFecha)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     'UpdateFacturaTemp = True
                  End If

                  .MoveNext()
               Loop

               UpdateFacturaTemp = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function UpdateCompChequeTemp(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)

      UpdateCompChequeTemp = False

      Try
         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read
                  .Fecha = ToDate(.Fecha)
                  .FechaCob = ToDate(.FechaCob)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     'UpdateCompChequeTemp = True
                  End If

                  .MoveNext()
               Loop

               UpdateCompChequeTemp = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Function UpdateCompPlanEEFFTemp(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

      UpdateCompPlanEEFFTemp = False

      Try
         With oCompPlanEEFF
            .SelectFilter = clsCompPlanEEFF.SelectFilters.All
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read
                  If lngEstadoId = 13 Then
                     If moComp.MonedaId = 1 Then
                        .DebeBs = .DebeOrg
                        .HaberBs = .HaberOrg
                        .DebeUs = ToDecimal(.DebeOrg / moComp.TipoCambio)
                        .HaberUs = ToDecimal(.HaberOrg / moComp.TipoCambio)

                     ElseIf moComp.MonedaId = 2 Then
                        .DebeBs = ToDecimal(.DebeOrg * moComp.TipoCambio)
                        .HaberBs = ToDecimal(.HaberOrg * moComp.TipoCambio)
                        .DebeUs = .DebeOrg
                        .HaberUs = .HaberOrg
                     End If

                     .Fecha = ToDate(dtpFecha.Value)
                  Else
                     .UpdateFilter = clsCompPlanEEFF.UpdateFilters.EstadoId
                  End If

                  .EstadoId = lngEstadoId

                  If .Update() Then
                     'UpdateCompPlanEEFFTemp = True
                  End If

                  .MoveNext()
               Loop

               UpdateCompPlanEEFFTemp = True
            End If
         End With

      Catch exp As Exception
         Throw exp
      Finally
         oCompPlanEEFF.Dispose()
      End Try
   End Function

   Private Function UpdateCompPlanAddTemp(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      UpdateCompPlanAddTemp = False

      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.All
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read
                  If lngEstadoId = 13 Then
                     If moComp.MonedaId = 1 Then
                        .DebeBs = .DebeOrg
                        .HaberBs = .HaberOrg
                        .DebeUs = ToDecimal(.DebeOrg / moComp.TipoCambio)
                        .HaberUs = ToDecimal(.HaberOrg / moComp.TipoCambio)

                     ElseIf moComp.MonedaId = 2 Then
                        .DebeBs = ToDecimal(.DebeOrg * moComp.TipoCambio)
                        .HaberBs = ToDecimal(.HaberOrg * moComp.TipoCambio)
                        .DebeUs = .DebeOrg
                        .HaberUs = .HaberOrg
                     End If
                  End If

                  .Fecha = ToDate(dtpFecha.Value)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     'UpdateCompPlanAddTemp = True
                  End If

                  .MoveNext()
               Loop

               UpdateCompPlanAddTemp = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function UpdateCompCentroCostoDetTemp(ByVal lngCompId As Long, ByVal lngEstadoId As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      UpdateCompCentroCostoDetTemp = False

      Try
         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read
                  If lngEstadoId = 13 Then
                     If moComp.MonedaId = 1 Then
                        .DebeBs = .DebeOrg
                        .HaberBs = .HaberOrg
                        .DebeUs = ToDecimal(.DebeOrg / moComp.TipoCambio)
                        .HaberUs = ToDecimal(.HaberOrg / moComp.TipoCambio)

                     ElseIf moComp.MonedaId = 2 Then
                        .DebeBs = ToDecimal(.DebeOrg * moComp.TipoCambio)
                        .HaberBs = ToDecimal(.HaberOrg * moComp.TipoCambio)
                        .DebeUs = .DebeOrg
                        .HaberUs = .HaberOrg
                     End If
                  End If

                  .Fecha = ToDate(dtpFecha.Value)
                  .EstadoId = lngEstadoId

                  If .Update Then
                     'UpdateCompCentroCostoDetTemp = True
                  End If

                  .MoveNext()
               Loop

               UpdateCompCentroCostoDetTemp = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function
#End Region
#End Region

#Region " FACTURA "
#Region " Metodo-Factura "
   Private Function EsIngreso() As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim intRow As Integer = 0

      Try
         EsIngreso = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.Grid
            .WhereFilter = clsCompDet.WhereFilters.GridAutomatico
            .OrderByFilter = clsCompDet.OrderByFilters.Grid
            .CompId = moComp.CompId
            .Automatico = 0

            If .Open() Then
               Do While intRow < .DataSet.Tables(.TableName).Rows.Count

                  'If Microsoft.VisualBasic.Left(.DataSet.Tables(.TableName).Rows(intRow).Item("PlanCta"), 1) = "4" Then
                  If ToLong(.DataSet.Tables(.TableName).Rows(intRow).Item("TipoGrupoId")) = 4 And ToLong(.DataSet.Tables(.TableName).Rows(intRow).Item("TipoId")) = 0 Then
                     Return True
                  End If

                  intRow += 1
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function EsEgreso() As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim intRow As Integer = 0
      'Dim strPlanGrupo As String
      Dim lngPlanGrupoId As Long
      Try
         EsEgreso = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.Grid
            .WhereFilter = clsCompDet.WhereFilters.GridAutomatico
            .OrderByFilter = clsCompDet.OrderByFilters.Grid
            .CompId = moComp.CompId
            .Automatico = 0

            If .Open() Then
               Do While intRow < .DataSet.Tables(.TableName).Rows.Count
                  'strPlanGrupo = Microsoft.VisualBasic.Left(.DataSet.Tables(.TableName).Rows(intRow).Item("PlanCta"), 1)
                  lngPlanGrupoId = ToLong(.DataSet.Tables(.TableName).Rows(intRow).Item("TipoGrupoId"))

                  If (lngPlanGrupoId = 1) Or (lngPlanGrupoId = 2) Or (lngPlanGrupoId = 5) Or (lngPlanGrupoId = 6) Then
                     If ToLong(.DataSet.Tables(.TableName).Rows(intRow).Item("TipoId")) = 0 Then
                        Return True
                     End If
                  End If

                  intRow += 1
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function TieneFacturaAgru(ByVal lngCompId As Long) As Long
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)

      Try
         TieneFacturaAgru = 0

         With oFacturaAgru
            .RowCountFilter = clsFacturaAgru.RowCountFilters.All
            .WhereFilter = clsFacturaAgru.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            TieneFacturaAgru = .RowCount()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Function

   Private Function TieneFacturaGlobal(ByVal lngCompId As Long) As Long
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         TieneFacturaGlobal = 0

         With oFactura
            .RowCountFilter = clsFactura.RowCountFilters.All
            .WhereFilter = clsFactura.WhereFilters.FacturaGral
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = 0

            TieneFacturaGlobal = .RowCount()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function FacturaSaldo(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decCompDetMonto As Decimal) As Decimal
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         FacturaSaldo = 0
         decMonto = 0

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If clsAppInfo.AplicarDescuento Then
                     decMonto += .FacturaMonto + .Recargo
                  Else
                     decMonto += .FacturaMonto + .Recargo - .Descuento
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         FacturaSaldo = ToDecimal(decCompDetMonto - decMonto)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Sub frmFacturaIndiLoad()
      Dim frm As New frmCompFacturaEdit
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decFacturaSaldo As Decimal
      Dim decDescuento As Decimal = 0
      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))

            If Not .Find Then
               .FacturaMonto = CompDetMontoBs(.CompDetId)

            Else
               decFacturaSaldo = FacturaSaldo(.CompId, .CompDetId, CompDetMontoBs(.CompDetId))

               If decFacturaSaldo > 0 Then
                  .FacturaMonto = decFacturaSaldo

               ElseIf decFacturaSaldo = 0 Then
                  MessageBox.Show("El Monto de la(s) Factura(s) ya esta Balanceado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub

               Else
                  MessageBox.Show("El Monto de la(s) Factura(s) no Puede Ser Mayor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub
               End If
            End If

            .EmpresaId = moComp.EmpresaId
            .GestionId = moComp.GestionId
            .CompId = moComp.CompId
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))
            .SucursalId = CompDetSucursalIdFind(.CompDetId)
            .TipoCompId = moComp.TipoCompId
            .FacturaFecha = ToDateDMY(dtpFecha.Value)

            If .TipoCompId = 3 Then
               If EsIngreso() Then
                  .TipoFacturaId = 1 'Venta
               Else
                  .TipoFacturaId = 2 'Compra
               End If
            Else
               .TipoFacturaId = moComp.TipoCompId
            End If

            frm.NewRecord = True
            frm.Editing = False
            frm.NuevoComprobante = mboolNew
            frm.TipoCambio = moComp.TipoCambio
            frm.CompFecha = ToDateDMY(dtpFecha.Value)
            frm.DataObject = oFactura
            frm.ShowDialog()

            If frm.Changed Then
               decFacturaSaldo = FacturaSaldo(.CompId, .CompDetId, CompDetMontoBs(.CompDetId))
               decDescuento += .Descuento
               Do While decFacturaSaldo > 0
                  .FacturaFecha = ToDateDMY(dtpFecha.Value)
                  .FacturaMonto = decFacturaSaldo

                  frm.NewRecord = True
                  frm.Editing = False
                  frm.NuevoComprobante = mboolNew
                  frm.Changed = False
                  frm.TipoCambio = moComp.TipoCambio
                  frm.CompFecha = ToDateDMY(dtpFecha.Value)
                  frm.DataObject = oFactura
                  frm.ShowDialog()

                  If frm.Changed Then
                     decFacturaSaldo = FacturaSaldo(.CompId, .CompDetId, CompDetMontoBs(.CompDetId))
                     decDescuento += .Descuento
                  Else
                     Exit Do
                  End If
               Loop

               Dim lngCompDetId As Long = ToLong(grdMain.GetValue("CompDetId"))

               mboolEditGrid = True
               Call DataSave(13)
               Call grdMainLoad()
               Call grdMainFindRow(lngCompDetId)

               Call ContabilizarDescuento(decDescuento)
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Sub

   Private Function TieneFacturaIndi(ByVal lngCompId As Long) As Long
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         TieneFacturaIndi = 0

         With oFactura
            .RowCountFilter = clsFactura.RowCountFilters.All
            .WhereFilter = clsFactura.WhereFilters.FacturaIndi
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = 0

            TieneFacturaIndi = .RowCount()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function CompMontoBs(ByVal lngCompId As Long, ByVal lngCol As Long) As Decimal
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         CompMontoBs = 0
         decMonto = 0

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read()
                  If .Automatico = 0 Then
                     If lngCol = 1 Then
                        If .MonedaId = 1 Then
                           decMonto = decMonto + ToDecimal(.DebeOrg)
                        ElseIf .MonedaId = 2 Then
                           decMonto = decMonto + ToDecimal(.DebeOrg * moComp.TipoCambio)
                        End If
                     Else
                        If .MonedaId = 1 Then
                           decMonto = decMonto + ToDecimal(.HaberOrg)
                        ElseIf .MonedaId = 2 Then
                           decMonto = decMonto + ToDecimal(.HaberOrg * moComp.TipoCambio)
                        End If
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         CompMontoBs = ToDecimal(decMonto)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Sub frmFacturaGralLoad()
      Dim frm As New frmCompFacturaEdit
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decDescuentoFactura As Decimal = 0
      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId

            If Not .Find Then
               .EmpresaId = moComp.EmpresaId
               .GestionId = moComp.GestionId
               .SucursalId = CompDetSucursalIdFind(ToLong(grdMain.GetValue("CompDetId")))
               .CompId = moComp.CompId
               .CompDetId = 0
               .TipoCompId = moComp.TipoCompId
               .FacturaFecha = ToDateDMY(dtpFecha.Value)

               If .TipoCompId = 3 Then
                  If EsIngreso() Then
                     .TipoFacturaId = 1
                  Else
                     .TipoFacturaId = 2
                  End If
               Else
                  .TipoFacturaId = moComp.TipoCompId
               End If

               If Not clsAppInfo.AplicarDescuento Then
                  .FacturaMonto = CompMontoBs(.CompId, 1)
               Else
                  If .TipoFacturaId = 1 Then
                     .FacturaMonto = CompMontoBs(.CompId, 2)
                  Else
                     .FacturaMonto = CompMontoBs(.CompId, 1)
                  End If
               End If
               frm.NewRecord = True
               frm.Editing = False
               frm.NuevoComprobante = mboolNew
            Else
               frm.NewRecord = False
               frm.Editing = True
               frm.NuevoComprobante = mboolNew
            End If

            frm.TipoCambio = moComp.TipoCambio
            frm.CompFecha = ToDateDMY(dtpFecha.Value)
            frm.DataObject = oFactura
            frm.ShowDialog()

            If frm.Changed Then
               Dim lngCompDetId As Long = ToLong(grdMain.GetValue("CompDetId"))
               mboolEditGrid = True
               Call DataSave(13)
               Call grdMainLoad()
               Call grdMainFindRow(lngCompDetId)

               decDescuentoFactura += oFactura.Descuento
               Call ContabilizarDescuento(decDescuentoFactura)
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Sub

   Private Function TieneRetencion() As Boolean
      TieneRetencion = False

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         If ToLong(oRow.Cells("TipoRetencionId").Value) > 0 Then
            Return True
         End If
      Next
   End Function

   Private Function PlanGrupoFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanGrupoFind = ""

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

   Private Function CompDetSucursalIdFind(ByVal lngCompDetId As Long) As Long
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetSucursalIdFind = 0

      Try
         With oCompDet
            .CompDetId = lngCompDetId

            If .FindByPK Then
               Return .SucursalId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Sub frmFacturaAnuLoad()
      Dim frm As New frmCompFacturaEdit
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         With oFactura
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))
            .GestionId = moComp.GestionId
            .SucursalId = CompDetSucursalIdFind(ToLong(grdMain.GetValue("CompDetId")))
            .TipoCompId = moComp.TipoCompId
            .TipoFacturaId = 1
            .FacturaFecha = ToDateDMY(dtpFecha.Value)
            .FacturaMonto = 0

            frm.NewRecord = True
            frm.Editing = False
            frm.NuevoComprobante = mboolNew
            frm.Anulada = True

            frm.TipoCambio = moComp.TipoCambio
            frm.CompFecha = ToDateDMY(dtpFecha.Value)
            frm.DataObject = oFactura
            frm.ShowDialog()

            If frm.Changed Then
               Dim lngCompDetId As Long = ToLong(grdMain.GetValue("CompDetId"))
               mboolEditGrid = True
               Call DataSave(13)
               Call grdMainLoad()
               Call grdMainFindRow(lngCompDetId)
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Sub

   Private Function CompDetMontoBs(ByVal lngCompDetId As Long) As Decimal
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         CompDetMontoBs = 0

         With oCompDet
            .CompDetId = lngCompDetId

            If .FindByPK Then
               If .MonedaId = 1 Then
                  If .DebeOrg <> 0 Then
                     CompDetMontoBs = ToDecimal(.DebeOrg)

                  ElseIf .HaberOrg <> 0 Then
                     CompDetMontoBs = ToDecimal(.HaberOrg)
                  End If

               ElseIf .MonedaId = 2 Then
                  If .DebeOrg <> 0 Then
                     CompDetMontoBs = ToDecimal(.DebeOrg * moComp.TipoCambio)

                  ElseIf .HaberOrg <> 0 Then
                     CompDetMontoBs = ToDecimal(.HaberOrg * moComp.TipoCambio)
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function FacturaAgruSaldo(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decCompDetMonto As Decimal) As Decimal
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         FacturaAgruSaldo = 0
         decMonto = 0

         With oFacturaAgru
            .SelectFilter = clsFacturaAgru.SelectFilters.All
            .WhereFilter = clsFacturaAgru.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  decMonto = decMonto + ToDecimal(.FacturaMonto)

                  .MoveNext()
               Loop
            End If
         End With

         FacturaAgruSaldo = ToDecimal(decCompDetMonto - decMonto)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Function

   Private Sub frmFacturaAgruEditLoad()
      Dim frm As New frmCompFacturaAgruEdit
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)
      Dim decFacturaAgruSaldo As Decimal

      Try
         With oFacturaAgru
            .SelectFilter = clsFacturaAgru.SelectFilters.All
            .WhereFilter = clsFacturaAgru.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))

            If Not .Find Then
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .CompDetId = ToLong(grdMain.GetValue("CompDetId"))
               .GestionId = moComp.GestionId
               .SucursalId = CompDetSucursalIdFind(ToLong(grdMain.GetValue("CompDetId")))
               .TipoCompId = moComp.TipoCompId
               .FacturaFecha = ToDateDMY(dtpFecha.Value)
               .FacturaMonto = CompDetMontoBs(.CompDetId)

               frm.NewRecord = True
               frm.Editing = False

            Else
               decFacturaAgruSaldo = FacturaAgruSaldo(.CompId, .CompDetId, CompDetMontoBs(.CompDetId))

               If decFacturaAgruSaldo > 0 Then
                  .EmpresaId = moComp.EmpresaId
                  .CompId = moComp.CompId
                  .CompDetId = ToLong(grdMain.GetValue("CompDetId"))
                  .GestionId = moComp.GestionId
                  .SucursalId = CompDetSucursalIdFind(ToLong(grdMain.GetValue("CompDetId")))
                  .TipoCompId = moComp.TipoCompId
                  .FacturaFecha = ToDateDMY(dtpFecha.Value)
                  .FacturaMonto = decFacturaAgruSaldo

                  frm.NewRecord = True
                  frm.Editing = False

               ElseIf decFacturaAgruSaldo = 0 Then
                  MessageBox.Show("El Monto de la(s) Factura(s) ya esta Balanceado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub

               Else
                  MessageBox.Show("El Monto de la(s) Factura(s) no Puede Ser Mayor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub
               End If
            End If

            frm.TipoCambio = moComp.TipoCambio
            frm.CompFecha = ToDateDMY(dtpFecha.Value)
            frm.DataObject = oFacturaAgru
            frm.ShowDialog()

            If frm.Changed Then
               Dim lngCompDetId As Long = ToLong(grdMain.GetValue("CompDetId"))
               mboolEditGrid = True
               Call DataSave(13)
               Call grdMainLoad()
               Call grdMainFindRow(lngCompDetId)
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Sub

   Private Sub frmFacturaAgruAnuLoad()
      Dim frm As New frmCompFacturaAgruEdit
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)
      Dim decFacturaAgruSaldo As Decimal

      Try
         With oFacturaAgru
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))
            .GestionId = moComp.GestionId
            .SucursalId = CompDetSucursalIdFind(ToLong(grdMain.GetValue("CompDetId")))
            .TipoCompId = moComp.TipoCompId
            .FacturaFecha = ToDateDMY(dtpFecha.Value)
            .FacturaMonto = 0

            frm.NewRecord = True
            frm.Editing = False
            frm.Anulada = True

            frm.TipoCambio = moComp.TipoCambio
            frm.CompFecha = ToDateDMY(dtpFecha.Value)
            frm.DataObject = oFacturaAgru
            frm.ShowDialog()

            If frm.Changed Then
               Dim lngCompDetId As Long = ToLong(grdMain.GetValue("CompDetId"))
               mboolEditGrid = True
               Call DataSave(13)
               Call grdMainLoad()
               Call grdMainFindRow(lngCompDetId)
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Sub
#End Region

#Region " Grid-Factura "
   Private Sub mnuFacturaIndi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFacturaIndi.Click
      Dim strPlanGrupo As String = PlanGrupoFind(ToLong(grdMain.GetValue("PlanId")))

      If moComp.TipoCompId = 1 Then 'Ingreso
         If strPlanGrupo = "4" Then
            If ToDecimal(grdMain.GetValue("Haber")) <> 0 Then
               If TieneFacturaAgru(moComp.CompId) = 0 Then
                  If TieneFacturaGlobal(moComp.CompId) = 0 Then
                     Call frmFacturaIndiLoad()
                  Else
                     MessageBox.Show("El Comprobante ya Tiene Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("El Comprobante ya Tiene Factura(s) Agrupada(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Monto Deudor Invalido Para Registro de Factura de Venta en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Cuenta Inválida Para Registro de Factura de Venta en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      ElseIf moComp.TipoCompId = 2 Then 'Egreso
         If (strPlanGrupo = "1") Or (strPlanGrupo = "2") Or (strPlanGrupo = "5") Or (strPlanGrupo = "6") Then
            If ToDecimal(grdMain.GetValue("Debe")) <> 0 Then
               If TieneFacturaAgru(moComp.CompId) = 0 Then
                  If TieneFacturaGlobal(moComp.CompId) = 0 Then
                     If ToLong(grdMain.GetValue("TipoRetencionId")) = 0 Then
                        Call frmFacturaIndiLoad()
                     Else
                        MessageBox.Show("La Cuenta ya Tiene Asignada una Retención", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("El Comprobante ya Tiene Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("El Comprobante ya Tiene Factura(s) Agrupada(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Monto Acreedor Inválido Para Registro de Factura de Compra en Comprobante de Egreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Cuenta Inválida Para Registro de Factura de Compra en Comprobante de Egreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      ElseIf moComp.TipoCompId = 3 Then ' Traspaso
         If EsIngreso() Then
            If strPlanGrupo = "4" Then
               If ToDecimal(grdMain.GetValue("Haber")) <> 0 Then
                  If TieneFacturaAgru(moComp.CompId) = 0 Then
                     If TieneFacturaGlobal(moComp.CompId) = 0 Then
                        Call frmFacturaIndiLoad()
                     Else
                        MessageBox.Show("El Comprobante ya Tiene Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("El Comprobante ya Tiene Factura(s) Agrupada(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Monto Deudor Invalido Para la Registro de Factura de Venta en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Cuenta Inválida Para Registro de Factura de Venta en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Else
            If (strPlanGrupo = "1") Or (strPlanGrupo = "2") Or (strPlanGrupo = "5") Or (strPlanGrupo = "6") Then
               If ToDecimal(grdMain.GetValue("Debe")) <> 0 Then
                  If TieneFacturaAgru(moComp.CompId) = 0 Then
                     If TieneFacturaGlobal(moComp.CompId) = 0 Then
                        If ToLong(grdMain.GetValue("TipoRetencionId")) = 0 Then
                           Call frmFacturaIndiLoad()
                        Else
                           MessageBox.Show("La Cuenta ya Tiene Asignada una Retención", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                     Else
                        MessageBox.Show("El Comprobante ya Tiene una Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("El Comprobante ya Tiene Factura(s) Agrupada(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Monto Acreedor Inválido Para Registro de Factura de Compra en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Cuenta Inválida Para Registro de Factura de Compra en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If
      End If
   End Sub

   Private Sub mnuFacturaGral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFacturaGral.Click
      Dim strPlanGrupo As String = PlanGrupoFind(ToLong(grdMain.GetValue("PlanId")))

      If ((ToLong(txtDebeDif.Text) = 0) And (ToLong(txtHaberDif.Text) = 0)) Or clsAppInfo.AplicarDescuento Then
         If moComp.TipoCompId = 1 Then 'Ingreso
            If strPlanGrupo = "4" Then
               If ToDecimal(grdMain.GetValue("Haber")) <> 0 Then
                  If TieneFacturaAgru(moComp.CompId) = 0 Then
                     If TieneFacturaIndi(moComp.CompId) = 0 Then
                        If TieneFacturaGlobal(moComp.CompId) = 0 Then
                           Call frmFacturaGralLoad()
                        Else
                           MessageBox.Show("El Comprobante ya Tiene Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                     Else
                        MessageBox.Show("El Comprobante ya Tiene Factura Individual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("El Comprobante ya Tiene Factura(s) Agrupada(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Monto Deudor Invalido Para la Registro de Factura de Venta en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Cuenta Inválida Para Registro de Factura de Venta en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         ElseIf moComp.TipoCompId = 2 Then 'Egreso
            If (strPlanGrupo = "1") Or (strPlanGrupo = "2") Or (strPlanGrupo = "5") Or (strPlanGrupo = "6") Then
               If ToDecimal(grdMain.GetValue("Debe")) <> 0 Then
                  If TieneFacturaAgru(moComp.CompId) = 0 Then
                     If TieneFacturaIndi(moComp.CompId) = 0 Then
                        If TieneFacturaGlobal(moComp.CompId) = 0 Then
                           If Not TieneRetencion() Then
                              Call frmFacturaGralLoad()
                           Else
                              MessageBox.Show("Una o Mas Cuentas ya Tienen Asignada una Retención ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                           End If
                        Else
                           MessageBox.Show("El Comprobante ya Tiene una Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                     Else
                        MessageBox.Show("El Comprobante ya Tiene una Factura Individual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("El Comprobante ya Tiene Factura(s) Agrupada(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Monto Acreedor Inválido Para Registro de Factura de Compra en Comprobante de Egreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Cuenta Inválida Para Registro de Factura de Compra en Comprobante de Egreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         ElseIf moComp.TipoCompId = 3 Then ' Traspaso
            If EsIngreso() Then
               If strPlanGrupo = "4" Then
                  If ToDecimal(grdMain.GetValue("Haber")) <> 0 Then
                     If TieneFacturaAgru(moComp.CompId) = 0 Then
                        If TieneFacturaIndi(moComp.CompId) = 0 Then
                           If TieneFacturaGlobal(moComp.CompId) = 0 Then
                              Call frmFacturaGralLoad()
                           Else
                              MessageBox.Show("El Comprobante ya Tiene Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                           End If
                        Else
                           MessageBox.Show("El Comprobante ya Tiene Factura Individual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                     Else
                        MessageBox.Show("El Comprobante ya Tiene Factura(s) Agrupada(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("Monto Deudor Invalido Para la Registro de Factura de Venta en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Cuenta Inválida Para Registro de Factura de Venta en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If

            Else
               If (strPlanGrupo = "1") Or (strPlanGrupo = "2") Or (strPlanGrupo = "5") Or (strPlanGrupo = "6") Then
                  If ToDecimal(grdMain.GetValue("Debe")) <> 0 Then
                     If TieneFacturaAgru(moComp.CompId) = 0 Then
                        If TieneFacturaIndi(moComp.CompId) = 0 Then
                           If TieneFacturaGlobal(moComp.CompId) = 0 Then
                              If Not TieneRetencion() Then
                                 Call frmFacturaGralLoad()
                              Else
                                 MessageBox.Show("Una o Mas Cuentas ya Tienen Asignada una Retención ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                              End If
                           Else
                              MessageBox.Show("El Comprobante ya Tiene Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                           End If
                        Else
                           MessageBox.Show("El Comprobante ya Tiene Factura Individual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                     Else
                        MessageBox.Show("El Comprobante ya Tiene Factura(s) Agrupada(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("Monto Acreedor Inválido Para Registro de Factura de Compra en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Cuenta Inválida Para Registro de Factura de Compra en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If
         End If
      Else
         MessageBox.Show("Comprobante Fuera de Balance", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub mnuFacturaAnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFacturaAnu.Click
      If ToDecimal(grdMain.GetValue("Haber")) <> 0 Then
         If PlanGrupoFind(ToLong(grdMain.GetValue("PlanId"))) = "4" Then
            Call frmFacturaAnuLoad()
         Else
            MessageBox.Show("Ingreso de Factura de Venta Inválido en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Ingreso de Factura de Venta Inválido en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub mnuFacturaAgru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFacturaAgru.Click
      If moComp.TipoCompId = 1 Then 'Ingreso
         If PlanGrupoFind(ToLong(grdMain.GetValue("PlanId"))) = "4" Then
            If ToDecimal(grdMain.GetValue("Haber")) <> 0 Then
               If TieneFacturaIndi(moComp.CompId) = 0 Then
                  If TieneFacturaGlobal(moComp.CompId) = 0 Then
                     Call frmFacturaAgruEditLoad()
                  Else
                     MessageBox.Show("El Comprobante ya Tiene Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("El Comprobante ya Tiene Factura(s) Individual(es)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Monto Deudor Invalido Para la Asignación de Factura de Venta en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Cuenta Inválida Para Registro de Factura Inválido de Venta en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      ElseIf moComp.TipoCompId = 2 Then 'Egreso
         MessageBox.Show("Registro de Factura de Venta en Comprobante de Egreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      ElseIf moComp.TipoCompId = 3 Then ' Traspaso
         If EsIngreso() Then
            If PlanGrupoFind(ToLong(grdMain.GetValue("PlanId"))) = "4" Then
               If ToDecimal(grdMain.GetValue("Haber")) <> 0 Then
                  If TieneFacturaIndi(moComp.CompId) = 0 Then
                     If TieneFacturaGlobal(moComp.CompId) = 0 Then
                        Call frmFacturaAgruEditLoad()
                     Else
                        MessageBox.Show("El Comprobante ya Tiene una Factura Global", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  Else
                     MessageBox.Show("El Comprobante ya Tiene Factura(s) Individual(es)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Monto Deudor Invalido Para la Asignación de Factura de Venta en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Cuenta Inválida Para Asignación de Factura de Venta en Comprobante de Traspaso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Else
            MessageBox.Show("Registro de Factura de Venta Inválido en Comprobante de Egreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      End If
   End Sub

   Private Sub mnuFacturaAgruAnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFacturaAgruAnu.Click
      If moComp.TipoCompId = 1 Then
         If ToDecimal(grdMain.GetValue("Haber")) <> 0 Then
            If PlanGrupoFind(ToLong(grdMain.GetValue("PlanId"))) = "4" Then
               Call frmFacturaAgruAnuLoad()
            Else
               MessageBox.Show("Ingreso de Factura de Venta inválido en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Ingreso de Factura de Venta inválido en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Facturas Anuladas Solo en Comprobante de Ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub
#End Region
#End Region

#Region " ANALITICO-ADICIONALES "
#Region " Metodo-AnaliticoAdicional "
   Private Function TieneAnaAdd(ByVal lngPlanId As Long, ByRef strPlanDes As String) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TieneAnaAdd = False

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               If ToBoolean(.TieneAnaAdd) Then
                  strPlanDes = .PlanDes
                  TieneAnaAdd = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Sub CompPlanAddParametro(ByVal decDebeOrg As Decimal, ByVal decHaberOrg As Decimal)
      mlngCol = 0
      mdecCompDetMonto = 0

      If decDebeOrg <> 0 Then
         mlngCol = 1
         mdecCompDetMonto = decDebeOrg

      ElseIf decHaberOrg <> 0 Then
         mlngCol = 2
         mdecCompDetMonto = decHaberOrg
      End If
   End Sub

   Private Function CompPlanAddSaldo(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Decimal
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim decDebe As Decimal = 0
      Dim decHaber As Decimal = 0
      Dim decSaldo As Decimal = 0

      Try
         CompPlanAddSaldo = 0

         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.All
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  decDebe += .DebeOrg
                  decHaber += .HaberOrg

                  .MoveNext()
               Loop
            End If
         End With

         If moComp.TipoAsientoId = clsTipoAsiento.CIERRE Or moComp.TipoAsientoId = clsTipoAsiento.APERTURA Then
            decSaldo = Math.Abs(decDebe - decHaber)
            CompPlanAddSaldo = Math.Abs(mdecCompDetMonto - decSaldo)
         Else
            If mlngCol = 1 Then 'Debe
               CompPlanAddSaldo = Math.Abs(mdecCompDetMonto - decDebe)
            Else
               CompPlanAddSaldo = Math.Abs(mdecCompDetMonto - decHaber)
            End If
         End If
         'If CompPlanAddSaldo < 0.01 Then
         '   CompPlanAddSaldo = 0
         'End If
         CompPlanAddSaldo = ToDecimalMinor(CompPlanAddSaldo)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Sub frmCompPlanAddEditLoad()
      Dim frm As New frmCompPlanAddEdit
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decCompPlanAddSaldo As Decimal

      Try
         With oCompDet
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))

            If .FindByPK Then
               Call CompPlanAddParametro(.DebeOrg, .HaberOrg)
               decCompPlanAddSaldo = CompPlanAddSaldo(.CompId, .CompDetId)

               If decCompPlanAddSaldo = 0 Then
                  MessageBox.Show("El Monto de lo(s) Analítico(s) ya esta Balanceado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub

               ElseIf decCompPlanAddSaldo < 0 Then
                  MessageBox.Show("El Monto de lo(s) Analítico(s) no Puede Ser Mayor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub
               End If

               Do While decCompPlanAddSaldo > 0
                  With oCompPlanAdd
                     .EmpresaId = oCompDet.EmpresaId
                     .CompId = oCompDet.CompId
                     .CompDetId = oCompDet.CompDetId
                     .GestionId = oCompDet.GestionId
                     .Fecha = ToDate(dtpFecha.Value)
                     .PlanId = oCompDet.PlanId
                     .MonedaId = oCompDet.MonedaId
                     .EstadoId = 13

                     If mlngCol = 1 Then
                        .DebeOrg = decCompPlanAddSaldo

                     ElseIf mlngCol = 2 Then
                        .HaberOrg = decCompPlanAddSaldo
                     End If

                     frm.NewRecord = True
                     frm.Editing = False
                     frm.Changed = False
                     frm.TipoCambio = moComp.TipoCambio
                     frm.CompMonedaId = moComp.MonedaId
                     frm.Col = mlngCol
                     frm.CompDetMonto = mdecCompDetMonto
                     frm.DataObject = oCompPlanAdd
                     frm.ShowDialog()

                     If frm.Changed Then
                        decCompPlanAddSaldo = CompPlanAddSaldo(.CompId, .CompDetId)

                        If decCompPlanAddSaldo > 0 Then
                           mboolEditGrid = True
                           Call DataSave(13)
                           Call grdMainLoad()
                           Call grdMainFindRow(.CompDetId)
                        End If
                     Else
                        Exit Sub
                     End If
                  End With
               Loop
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()
         oCompDet.Dispose()

      End Try
   End Sub
#End Region

#Region " Grid-AnaliticoAdicional "
   Private Sub mnuCompPlanAddEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompPlanAddEdit.Click
      If grdMain.RowCount > 0 Then
         If TieneAnaAdd(ToLong(grdMain.GetValue("PlanId")), "") Then
            Call frmCompPlanAddEditLoad()
         Else
            MessageBox.Show("La Cuenta no Contiene Analíticos Adicionales", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub
#End Region
#End Region

#Region " CENTRO-COSTO "
#Region " Metodo-CentroCosto "
   Private Function CompDetCentroCostoIdFind(ByVal lngCompDetId As Long) As Long
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetCentroCostoIdFind = 0

      Try
         With oCompDet
            .CompDetId = lngCompDetId

            If .FindByPK Then
               Return .CentroCostoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function TieneCentroCostoDet(ByVal lngCentroCostoId As Long) As Boolean
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)

      Try
         TieneCentroCostoDet = False

         With oCentroCostoDet
            .SelectFilter = clsCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCentroCostoDet.WhereFilters.EstadoId
            .EmpresaId = moComp.EmpresaId
            .CentroCostoId = lngCentroCostoId
            .CentroCostoDetId = 0
            .EstadoId = 1

            If .Find Then
               TieneCentroCostoDet = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetSaldo(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngCentroCostoId As Long) As Decimal
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      Dim decDebe As Decimal = 0
      Dim decHaber As Decimal = 0
      Dim decSaldo As Decimal = 0
      Try
         CompCentroCostoDetSaldo = 0

         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CentroCostoId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .CentroCostoId = lngCentroCostoId

            If .Open Then
               Do While .Read()
                  decDebe += .DebeOrg
                  decHaber += .HaberOrg

                  .MoveNext()
               Loop
            End If
         End With

         If moComp.TipoAsientoId = clsTipoAsiento.CIERRE Or moComp.TipoAsientoId = clsTipoAsiento.APERTURA Then
            decSaldo = Math.Abs(decDebe - decHaber)
            CompCentroCostoDetSaldo = Math.Abs(mdecCompDetMonto - decSaldo)
         Else
            If mlngCol = 1 Then 'Debe
               CompCentroCostoDetSaldo = Math.Abs(mdecCompDetMonto - decDebe)
            Else
               CompCentroCostoDetSaldo = Math.Abs(mdecCompDetMonto - decHaber)
            End If
         End If
         'If CompCentroCostoDetSaldo < 0.01 Then
         '   CompCentroCostoDetSaldo = 0
         'End If

         CompCentroCostoDetSaldo = ToDecimalMinor(CompCentroCostoDetSaldo)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Sub frmCompCentroCostoDetEditLoad()
      Dim frm As New frmCompCentroCostoDetEdit
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decCompCentroCostoDetSaldo As Decimal

      Try
         With oCompDet
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))

            If .FindByPK Then
               Call CompPlanAddParametro(.DebeOrg, .HaberOrg)
               decCompCentroCostoDetSaldo = CompCentroCostoDetSaldo(.CompId, .CompDetId, .CentroCostoId)

               If decCompCentroCostoDetSaldo = 0 Then
                  MessageBox.Show("El Monto de la(s) Actividad(es) ya esta Balanceado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub

               ElseIf decCompCentroCostoDetSaldo < 0 Then
                  MessageBox.Show("El Monto de la(s) Actividad(es) no Puede Ser Mayor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub
               End If

               Do While decCompCentroCostoDetSaldo > 0
                  With oCompCentroCostoDet
                     .EmpresaId = oCompDet.EmpresaId
                     .CompId = oCompDet.CompId
                     .CompDetId = oCompDet.CompDetId
                     .GestionId = oCompDet.GestionId
                     .Fecha = ToDate(dtpFecha.Value)
                     .PlanId = oCompDet.PlanId
                     .CentroCostoId = oCompDet.CentroCostoId
                     .MonedaId = oCompDet.MonedaId
                     .EstadoId = 13

                     If mlngCol = 1 Then
                        .DebeOrg = decCompCentroCostoDetSaldo

                     ElseIf mlngCol = 2 Then
                        .HaberOrg = decCompCentroCostoDetSaldo
                     End If

                     frm.NewRecord = True
                     frm.Editing = False
                     frm.Changed = False
                     frm.TipoCambio = moComp.TipoCambio
                     frm.CompMonedaId = moComp.MonedaId
                     frm.Col = mlngCol
                     frm.CompDetMonto = mdecCompDetMonto
                     frm.DataObject = oCompCentroCostoDet
                     frm.ShowDialog()

                     If frm.Changed Then
                        decCompCentroCostoDetSaldo = CompCentroCostoDetSaldo(.CompId, .CompDetId, .CentroCostoId)

                        If decCompCentroCostoDetSaldo > 0 Then
                           mboolEditGrid = True
                           Call DataSave(13)
                           Call grdMainLoad()
                           Call grdMainFindRow(.CompDetId)
                        End If
                     Else
                        Exit Sub
                     End If
                  End With
               Loop
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()
         oCompDet.Dispose()

      End Try
   End Sub
#End Region

#Region " Grid-CentroCosto "
   Private Sub mnuCompCentroCostoDetEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompCentroCostoDetEdit.Click
      If grdMain.RowCount > 0 Then
         Dim lngCentroCostoId As Long = CompDetCentroCostoIdFind(ToLong(grdMain.GetValue("CompDetId")))

         If lngCentroCostoId > 0 Then
            If TieneCentroCostoDet(lngCentroCostoId) Then
               Call frmCompCentroCostoDetEditLoad()
            Else
               MessageBox.Show("La Cuenta no Contiene Actividades", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub
#End Region
#End Region

#Region " Evento Tipo-Comp "
   Private Sub cboTipoComp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoComp.SelectedIndexChanged
      If cboTipoComp.Tag <> cboTipoComp.Text Then
         cboTipoComp.Tag = cboTipoComp.Text

         Dim lngTipoCompId As Long = ListPosition(cboTipoComp, cboTipoComp.SelectedIndex)

         If lngTipoCompId = 1 Then
            lblEntregadoA.Text = "Hemos recibido de:"
            lblPorConcepto.Text = "Por concepto de:"

            cboTipoAsiento.SelectedIndex = ListFindItem(cboTipoAsiento, 0)
            cboTipoAsiento.ReadOnly = True

         ElseIf lngTipoCompId = 2 Then
            lblEntregadoA.Text = "Hemos entregado a:"
            lblPorConcepto.Text = "Por concepto de:"

            cboTipoAsiento.SelectedIndex = ListFindItem(cboTipoAsiento, 0)
            cboTipoAsiento.ReadOnly = True

         ElseIf lngTipoCompId = 3 Then
            lblEntregadoA.Text = "Por concepto de:"
            lblPorConcepto.Text = ""

            cboTipoAsiento.ReadOnly = False
         End If

         mboolNroAuto = CompParaNroAuto(lngTipoCompId, clsAppInfo.GestionId, mboolNroAutoGestion)

         If mboolAdding Then
            If mboolNroAuto Then
               txtCompNro.ReadOnly = True
               txtCompNro.Text = ""
            Else
               txtCompNro.ReadOnly = False
               txtCompNro.Text = ""
            End If
         End If

         If mboolEditing Then
            If mboolNroAuto Then
               txtCompNro.ReadOnly = True
            Else
               txtCompNro.ReadOnly = False
            End If
         End If
      End If
   End Sub

   Private Function CompParaNroAuto(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByRef boolNroAutoGestion As Boolean) As Boolean
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompParaNroAuto = False

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moComp.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId

            If .Find Then
               boolNroAutoGestion = ToBoolean(.NroAutoGestion)
               CompParaNroAuto = ToBoolean(.NroAuto)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Function
#End Region

#Region " Evento Fecha "
   Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
      If Not IsNothing(moComp) Then
         If dtpFecha.Tag <> dtpFecha.Text Then
            If IsDate(dtpFecha.Text) Then
               If ValidarFecha(dtpFecha.Value, dtpFecha.Tag) Then
                  Call txtTipoCambioFind(ToDate(dtpFecha.Value))
                  dtpFecha.Tag = dtpFecha.Text

                  If ToDecimal(txtTipoCambio.Text) > 0 Then
                     If mboolEditing Then
                        txtTipoCambio.Tag = ToDecimal(txtTipoCambio.Text)
                        mboolEditGrid = True
                        Call DataSave(13)
                        Call grdMainLoad()
                     End If
                  End If
               Else
                  MessageBox.Show("Debe Seleccionar una Fecha dentro del Mes correspondiente a la Numeración del Comprobante", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  dtpFecha.Text = dtpFecha.Tag
               End If
            Else
               txtTipoCambio.Text = 0
            End If
         End If
      End If
   End Sub

   Private Sub txtTipoCambioFind(ByVal strFecha As String)
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      Try
         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = strFecha

            If .Find Then
               txtTipoCambio.Text = ToStr(.Valor)
            Else
               txtTipoCambio.Text = 0
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub
#End Region

#Region " Evento Tipo-Cambio "
   Private Sub txtTipoCambio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoCambio.LostFocus
      If txtTipoCambio.Tag <> ToDecimal(txtTipoCambio.Text) Then
         If ToDecimal(txtTipoCambio.Text) > 0 Then
            If mboolEditing Then
               mboolEditGrid = True
               txtTipoCambio.Tag = ToDecimal(txtTipoCambio.Text)
               Call DataSave(13)
               Call grdMainLoad()
            End If
         End If
      End If
   End Sub
#End Region

   Private Function esBloqueoAutomatico(ByVal lngTipoCompId As Long, ByRef lngEstadoId As Long) As Boolean
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId
            .EmpresaId = moComp.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = moComp.GestionId

            If .Find Then
               esBloqueoAutomatico = ToBoolean(.BloqueoAuto)
               If ToBoolean(.BloqueoAuto) Then
                  lngEstadoId = clsEstado.CERRADO
               End If
            End If
         End With
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Finally
         oCompPara.Dispose()
      End Try
   End Function

#Region "Descuento"
   Private Function TotalDescuentoFacturas(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Decimal
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      Dim decDescuento As Decimal = 0

      Try
         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.FacturaConDescuento
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               While .Read

                  If moComp.MonedaId = clsMoneda.BOLIVIANOS Then
                     decDescuento += .Descuento
                  Else
                     decDescuento += ToDecimal((.Descuento) / moComp.TipoCambio)
                  End If

                  .MoveNext()
               End While
            End If
         End With

         Return decDescuento
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Finally
         oFactura.Dispose()
      End Try
   End Function

   Private Function FacturaDescuentoCheck() As Boolean
      Dim strMsg As String = ""
      FacturaDescuentoCheck = True

      If ExisteFacturaconDescuento(moComp.CompId) Then
         If TieneFacturaIndi(moComp.CompId) Then
            Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

            With oCompDet
               .SelectFilter = clsCompDet.SelectFilters.All
               .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
               .EmpresaId = moComp.EmpresaId
               .CompId = moComp.CompId
               .Automatico = 0

               If .Find Then
                  Do While .Read
                     If .CompDetIdOrg = 0 Then
                        Dim decDescuentoFacturas As Decimal = 0
                        Dim decDescuentoContable As Decimal = 0

                        Call TieneFacturaconDescuento(moComp.CompId, .CompDetId, decDescuentoFacturas)
                        Call TieneAsientosconDescuento(moComp.CompId, .CompDetId, decDescuentoContable)

                        If ToDecimalMinor(Math.Abs(decDescuentoFacturas - decDescuentoContable)) > 0 Then
                           FacturaDescuentoCheck = False
                        End If


                     End If
                     .MoveNext()
                  Loop
               End If
            End With

         ElseIf TieneFacturaGlobal(moComp.CompId) Then
            Dim decDescuentoFacturas As Decimal = 0
            Dim decDescuentoContable As Decimal = 0

            Call TieneFacturaconDescuento(moComp.CompId, 0, decDescuentoFacturas)
            Call TieneAsientosconDescuento(moComp.CompId, 0, decDescuentoContable)

            If ToDecimalMinor(Math.Abs(decDescuentoFacturas - decDescuentoContable)) > 0 Then
               FacturaDescuentoCheck = False
            End If
         End If
      End If

      'If Not String.IsNullOrEmpty(strMsg.Trim) Then
      '   FacturaDescuentoCheck = False
      '   MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      'Else
      '   FacturaDescuentoCheck = True
      'End If
   End Function

   Private Sub mnuAgregarDescuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAplicarDescuento.Click
      If clsAppInfo.AplicarDescuento Then
         If grdMain.RowCount > 0 Then
            'Global
            If TieneFacturaconDescuento(moComp.CompId, 0) Then
               Call frmCompDetDescuentoAddEditLoad(moComp.CompId, 0, True)
               'Individual
            ElseIf TieneFacturaconDescuento(moComp.CompId, ToLong(grdMain.GetValue("CompDetId"))) Then
               Call frmCompDetDescuentoAddEditLoad(moComp.CompId, ToLong(grdMain.GetValue("CompDetId")), True)
            Else
               MessageBox.Show("La Cuenta seleccionada no tiene registrado Facturas con Descuento.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If
      End If
   End Sub

   Private Sub CloneCompDetVM(ByRef oVM As clsCompDetVM, ByVal oCompdet As clsCompDet)
      If clsAppInfo.RegistrarBitacora And Not mboolNew Then
         oVM = New clsCompDetVM

         With oVM
            .CompDetId = oCompdet.CompDetId
            .CompId = oCompdet.CompId
            .CompNro = ToLong(txtCompNro.Text)
            .TipoCompId = oCompdet.TipoCompId
            .TipoCompDes = cboTipoComp.Text
            .PlanId = oCompdet.PlanId
            .CompDetDes = oCompdet.CompDetDes
            .DebeOrg = oCompdet.DebeOrg
            .HaberOrg = oCompdet.HaberOrg
            .DebeBs = oCompdet.DebeBs
            .HaberBs = oCompdet.HaberBs
            .DebeUs = oCompdet.DebeUs
            .HaberUs = oCompdet.HaberUs
            .SucursalId = oCompdet.SucursalId
            .CentroCostoId = oCompdet.CentroCostoId
            .Orden = oCompdet.Orden
            .TipoId = oCompdet.TipoId

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Function frmCompDetDescuentoAddEditLoad(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal BoolDescuentoPorFactura As Boolean) As Decimal
      Dim frm As New frmCompDetDescuentoEdit
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      'Variables Auxiliares
      Dim lngPlanAddId As Long
      Dim lngCentroCostoDetId As Long
      Dim lngCol As Long
      Dim decDescuentoConsolidado As Decimal
      Dim strFacturaNro As String

      Try
         lngCol = TipoFacturaIdFind(moComp.CompId)

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.FacturaConDescuento
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Find Then

               With frm
                  .NewRecord = True
                  .Editing = False
                  .Changed = False
                  .TipoCambio = ToDecimal(txtTipoCambio.Text)

                  oCompDet.EmpresaId = ToLong(moComp.EmpresaId)
                  oCompDet.CompId = ToLong(moComp.CompId)
                  oCompDet.GestionId = ToLong(moComp.GestionId)
                  oCompDet.TipoCompId = ToLong(moComp.TipoCompId)
                  oCompDet.Fecha = ToDate(dtpFecha.Value)
                  'PlanId, 'SucursalId, 'CentroCostoId, 'CompDetDes
                  oCompDet.MonedaId = ToLong(moComp.MonedaId)
                  'DebeOrg, 'HaberOrg, 'DebeBs, 'HaberBs, 'DebeUs, 'HaberUs, 'Orden
                  oCompDet.Automatico = 0
                  oCompDet.EstadoId = 13
                  oCompDet.TipoRetencionId = 0
                  oCompDet.TipoId = clsCompDet.DESCUENTO
                  oCompDet.CompDetIdOrg = lngCompDetId

                  .DataObject = oCompDet
                  .ShowDialog()

                  If .Changed Then
                     lngPlanAddId = .PlanAddId
                     lngCentroCostoDetId = .CentroCostoDetId

                     'Factura Consolidado
                     If Not BoolDescuentoPorFactura Then
                        Do While oFactura.Read
                           decDescuentoConsolidado += oFactura.Descuento
                           If strFacturaNro <> "" Then
                              strFacturaNro &= "; "
                           End If
                           strFacturaNro &= "NIT: " & ToStr(oFactura.NroRUC) & " Fact: " & ToStr(oFactura.FacturaNro)
                           oFactura.MoveNext()
                        Loop

                        oCompDet.CompDetDes = strFacturaNro
                        oCompDet.Orden = MaxOrden()

                        If lngCol = 1 Then
                           If moComp.MonedaId = clsMoneda.BOLIVIANOS Then
                              oCompDet.DebeBs = ToDecimal(decDescuentoConsolidado)
                              oCompDet.DebeUs = ToDecimal(oCompDet.DebeBs / ToDecimal(txtTipoCambio.Text))
                              oCompDet.DebeOrg = oCompDet.DebeBs
                           Else
                              oCompDet.DebeBs = ToDecimal(decDescuentoConsolidado)
                              oCompDet.DebeUs = ToDecimal(oCompDet.DebeBs / ToDecimal(txtTipoCambio.Text))
                              oCompDet.DebeOrg = oCompDet.DebeUs
                           End If

                           oCompDet.HaberOrg = 0
                           oCompDet.HaberBs = 0
                           oCompDet.HaberUs = 0

                        ElseIf lngCol = 2 Then
                           If moComp.MonedaId = clsMoneda.BOLIVIANOS Then
                              oCompDet.HaberBs = ToDecimal(decDescuentoConsolidado)
                              oCompDet.HaberUs = ToDecimal(oCompDet.HaberBs / ToDecimal(txtTipoCambio.Text))
                              oCompDet.HaberOrg = oCompDet.HaberBs
                           Else
                              oCompDet.HaberBs = ToDecimal(decDescuentoConsolidado)
                              oCompDet.HaberUs = ToDecimal(oCompDet.HaberBs / ToDecimal(txtTipoCambio.Text))
                              oCompDet.HaberOrg = oCompDet.HaberUs
                           End If

                           oCompDet.DebeOrg = 0
                           oCompDet.DebeBs = 0
                           oCompDet.DebeUs = 0
                        End If

                        Call CloneCompDetVM(oCompDet.VMNew, oCompDet)
                        If oCompDet.Insert Then
                           Call DataSaveCompPlanAddDescuento(oCompDet, lngPlanAddId)
                           Call DataSaveCompCentroCostoDetDescuento(oCompDet, lngCentroCostoDetId)
                        End If
                        'Factura Individual
                     Else
                        Do While oFactura.Read
                           decDescuentoConsolidado = oFactura.Descuento
                           strFacturaNro = "NIT: " & ToStr(oFactura.NroRUC) & " Fact: " & ToStr(oFactura.FacturaNro)
                           oCompDet.CompDetDes = strFacturaNro
                           oCompDet.Orden = MaxOrden()

                           If lngCol = 1 Then
                              If moComp.MonedaId = clsMoneda.BOLIVIANOS Then
                                 oCompDet.DebeBs = ToDecimal(decDescuentoConsolidado)
                                 oCompDet.DebeUs = ToDecimal(oCompDet.DebeBs / ToDecimal(txtTipoCambio.Text))
                                 oCompDet.DebeOrg = oCompDet.DebeBs
                              Else
                                 oCompDet.DebeBs = ToDecimal(decDescuentoConsolidado)
                                 oCompDet.DebeUs = ToDecimal(oCompDet.DebeBs / ToDecimal(txtTipoCambio.Text))
                                 oCompDet.DebeOrg = oCompDet.DebeUs
                              End If

                              oCompDet.HaberOrg = 0
                              oCompDet.HaberBs = 0
                              oCompDet.HaberUs = 0

                           ElseIf lngCol = 2 Then
                              If moComp.MonedaId = clsMoneda.BOLIVIANOS Then
                                 oCompDet.HaberBs = ToDecimal(decDescuentoConsolidado)
                                 oCompDet.HaberUs = ToDecimal(oCompDet.HaberBs / ToDecimal(txtTipoCambio.Text))
                                 oCompDet.HaberOrg = oCompDet.HaberBs
                              Else
                                 oCompDet.HaberBs = ToDecimal(decDescuentoConsolidado)
                                 oCompDet.HaberUs = ToDecimal(oCompDet.HaberBs / ToDecimal(txtTipoCambio.Text))
                                 oCompDet.HaberOrg = oCompDet.HaberUs
                              End If

                              oCompDet.DebeOrg = 0
                              oCompDet.DebeBs = 0
                              oCompDet.DebeUs = 0
                           End If

                           Call CloneCompDetVM(oCompDet.VMNew, oCompDet)
                           If oCompDet.Insert Then
                              Call DataSaveCompPlanAddDescuento(oCompDet, lngPlanAddId)
                              Call DataSaveCompCentroCostoDetDescuento(oCompDet, lngCentroCostoDetId)
                           End If

                           oFactura.MoveNext()
                        Loop
                     End If

                     mboolEditGrid = True
                     Call grdMainLoad()
                     Call grdMainFindRow(oCompDet.CompDetId)
                  End If

                  mboolEditing = True
               End With
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompDet.Dispose()
      End Try
   End Function

   Private Sub CloneCompPlanAddVM(ByRef oVM As clsCompPlanAddVM, ByVal oCompPlanAdd As clsCompPlanAdd)
      If clsAppInfo.RegistrarBitacora And Not mboolNew Then
         oVM = New clsCompPlanAddVM

         With oVM
            .CompId = oCompPlanAdd.CompId
            .CompNro = ToLong(txtCompNro.Text)
            .TipoCompId = moComp.TipoCompId
            .TipoCompDes = cboTipoComp.Text
            .PlanId = oCompPlanAdd.PlanId
            .PlanAddId = oCompPlanAdd.PlanAddId
            .DebeOrg = oCompPlanAdd.DebeOrg
            .HaberOrg = oCompPlanAdd.HaberOrg

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Function DataSaveCompPlanAddDescuento(ByVal oCompDet As clsCompDet, ByVal lngPlanAddId As Long) As Boolean
      If lngPlanAddId > 0 Then
         Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

         Try
            With oCompPlanAdd
               .EmpresaId = oCompDet.EmpresaId
               .GestionId = oCompDet.GestionId
               .CompId = oCompDet.CompId
               .CompDetId = oCompDet.CompDetId
               .Fecha = oCompDet.Fecha
               .PlanId = oCompDet.PlanId
               .MonedaId = oCompDet.MonedaId
               .PlanAddId = lngPlanAddId
               .DebeOrg = oCompDet.DebeOrg
               .HaberOrg = oCompDet.HaberOrg
               .DebeBs = oCompDet.DebeBs
               .HaberBs = oCompDet.HaberBs
               .DebeUs = oCompDet.DebeUs
               .HaberUs = oCompDet.HaberUs
               .EstadoId = oCompDet.EstadoId

               Call CloneCompPlanAddVM(.VMNew, oCompPlanAdd)
               If .Insert Then
                  DataSaveCompPlanAddDescuento = True
               End If
            End With
         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Finally
            oCompPlanAdd.Dispose()
         End Try
      End If
   End Function

   Private Sub CloneCompCentroCostoDetVM(ByRef oVM As clsCompCentroCostoDetVM, ByVal oCompCentroCostoDet As clsCompCentroCostoDet)
      If clsAppInfo.RegistrarBitacora And Not mboolNew Then
         oVM = New clsCompCentroCostoDetVM

         With oVM
            .CompId = oCompCentroCostoDet.CompId
            .CompNro = ToLong(txtCompNro.Text)
            .TipoCompId = moComp.TipoCompId
            .TipoCompDes = cboTipoComp.Text
            .PlanId = oCompCentroCostoDet.PlanId
            .CentroCostoId = oCompCentroCostoDet.CentroCostoId
            .CentroCostoDetId = oCompCentroCostoDet.CentroCostoDetId
            .DebeOrg = oCompCentroCostoDet.DebeOrg
            .HaberOrg = oCompCentroCostoDet.HaberOrg

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Function DataSaveCompCentroCostoDetDescuento(ByVal oCompDet As clsCompDet, ByVal lngCentroCostoDetId As Long) As Boolean
      If lngCentroCostoDetId > 0 Then
         Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
         Try
            With oCompCentroCostoDet
               .EmpresaId = oCompDet.EmpresaId
               .GestionId = oCompDet.GestionId
               .CompId = oCompDet.CompId
               .CompDetId = oCompDet.CompDetId
               .Fecha = oCompDet.Fecha
               .PlanId = oCompDet.PlanId
               .MonedaId = oCompDet.MonedaId
               .CentroCostoId = oCompDet.CentroCostoId
               .CentroCostoDetId = lngCentroCostoDetId
               .DebeOrg = oCompDet.DebeOrg
               .HaberOrg = oCompDet.HaberOrg
               .DebeBs = oCompDet.DebeBs
               .HaberBs = oCompDet.HaberBs
               .DebeUs = oCompDet.DebeUs
               .HaberUs = oCompDet.HaberUs
               .EstadoId = oCompDet.EstadoId

               Call CloneCompCentroCostoDetVM(.VMNew, oCompCentroCostoDet)
               If .Insert Then
                  DataSaveCompCentroCostoDetDescuento = True
               End If
            End With
         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Finally
            oCompCentroCostoDet.Dispose()
         End Try
      End If
   End Function

   Private Function MaxOrden() As Long
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      MaxOrden = 0
      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
            .OrderByFilter = clsCompDet.OrderByFilters.OrdenDesc
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
            .Automatico = 0

            If .Find Then
               Return .Orden + 1
            End If
         End With
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompDet.Dispose()
      End Try
   End Function

   Private Function ContabilizarDescuento(ByVal decdescuento As Decimal) As Boolean
      If clsAppInfo.AplicarDescuento Then
         If decdescuento > 0 Then
            If MessageBox.Show("Factura con Descuento. ¿Quiere agregar asiento contable para el Descuento?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               If MessageBox.Show("¿Desea aplicar Descuento por Factura?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call mnuAgregarDescuento_Click(Nothing, Nothing)
               ElseIf MessageBox.Show("¿Desea aplicar Descuento por Factura Consolidado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call mnuAplicarDescuentoConsolidado_Click(Nothing, Nothing)
               End If
            End If
         End If
      End If
   End Function

   Private Sub mnuAplicarDescuentoConsolidado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAplicarDescuentoConsolidado.Click
      If clsAppInfo.AplicarDescuento Then
         If grdMain.RowCount > 0 Then
            'Global
            If TieneFacturaconDescuento(moComp.CompId, 0) Then
               Call frmCompDetDescuentoAddEditLoad(moComp.CompId, 0, False)
               'Individual
            ElseIf TieneFacturaconDescuento(moComp.CompId, ToLong(grdMain.GetValue("CompDetId"))) Then
               Call frmCompDetDescuentoAddEditLoad(moComp.CompId, ToLong(grdMain.GetValue("CompDetId")), False)
            Else
               MessageBox.Show("La Cuenta seleccionada no tiene registrado Facturas con Descuento.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If
      End If
   End Sub

   Private Function TieneFacturaconDescuento(ByVal lngCompId As Long, ByVal lngCompDetId As Long, Optional ByRef decDescuento As Decimal = 0) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         TieneFacturaconDescuento = False

         With oFactura
            .SelectFilter = clsFactura.RowCountFilters.All
            .WhereFilter = clsFactura.WhereFilters.FacturaConDescuento
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Find Then
               TieneFacturaconDescuento = True

               Do While .Read
                  decDescuento += .Descuento
                  .MoveNext()
               Loop

               If moComp.MonedaId = clsMoneda.DOLARES Then
                  decDescuento = ToDecimal(decDescuento / moComp.TipoCambio)
               End If
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oFactura.Dispose()
      End Try
   End Function

   Private Function ExisteFacturaconDescuento(ByVal lngCompId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
      ExisteFacturaconDescuento = False
      Try

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId

            If .Find Then
               Do While .Read
                  If .Descuento > 0 Then
                     ExisteFacturaconDescuento = True
                     Exit Function
                  End If
                  .MoveNext()
               Loop
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oFactura.Dispose()
      End Try
   End Function

   Private Function TieneAsientosconDescuento(ByVal lngCompId As Long, ByVal lngCompDetIdOrg As Long, Optional ByRef decDescuento As Decimal = 0) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         TieneAsientosconDescuento = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .Automatico = 0

            If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               Do While .Read
                  If .CompDetIdOrg = lngCompDetIdOrg And .TipoId = clsCompDet.DESCUENTO Then
                     If .HaberOrg > 0 Then
                        decDescuento += .HaberOrg
                     Else
                        decDescuento += .DebeOrg
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompDet.Dispose()
      End Try
   End Function

   Private Function DeleteAllAsientoDescuento(ByVal lngCompId As Long, ByVal lngCompDetIdOrg As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      DeleteAllAsientoDescuento = False
      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
            .EmpresaId = moComp.EmpresaId
            .CompId = moComp.CompId
            .Automatico = 0

            If .Find Then
               Do While .Read
                  If .TipoId = clsCompDet.DESCUENTO Then
                     If lngCompDetIdOrg <> 0 Then 'Factura Individual
                        If .CompDetIdOrg = lngCompDetIdOrg Then
                           .WhereFilter = clsCompDet.WhereFilters.PrimaryKey

                           Call CloneCompDetVM(oCompDet.VMNew, oCompDet)
                           If .Delete() Then
                              Call DeleteCompPlanAdd(.CompDetId)
                              Call DeleteCompCentroCostoDet(.CompDetId)
                              DeleteAllAsientoDescuento = True
                           End If
                        End If
                     Else 'Factura Global
                        .WhereFilter = clsCompDet.WhereFilters.PrimaryKey

                        Call CloneCompDetVM(oCompDet.VMNew, oCompDet)
                        If .Delete() Then
                           Call DeleteCompPlanAdd(.CompDetId)
                           Call DeleteCompCentroCostoDet(.CompDetId)
                           DeleteAllAsientoDescuento = True
                        End If
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompDet.Dispose()
      End Try
   End Function

#End Region

   Private Sub DataDelete()
      If moComp.EstadoId = clsEstado.PENDIENTE And mboolNew Then

         Dim oComp As New clsComp(clsAppInfo.ConnectString)
         oComp.CompId = moComp.CompId
         oComp.FindByPK()

         If oComp.CompId > 0 And oComp.CompNro = 0 Then
            Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
            Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
            Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
            Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
            Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)
            Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
            Try
               'Call OpenConectionTransaction()

               oComp.WhereFilter = clsComp.WhereFilters.PrimaryKey
               oComp.CompId = moComp.CompId
               Call oComp.Delete()
               ' oComp.CloseConection()

               oCompDet.WhereFilter = clsCompDet.WhereFilters.CompId
               oCompDet.EmpresaId = moComp.EmpresaId
               oCompDet.CompId = moComp.CompId
               Call oCompDet.Delete()
               '   oCompDet.CloseConection()

               oFactura.WhereFilter = clsFactura.WhereFilters.CompId
               oFactura.EmpresaId = moComp.EmpresaId
               oFactura.CompId = moComp.CompId
               Call oFactura.Delete()
               '    oFactura.CloseConection()

               oCompCheque.WhereFilter = clsCompCheque.WhereFilters.CompId
               oCompCheque.EmpresaId = moComp.EmpresaId
               oCompCheque.CompId = moComp.CompId
               Call oCompCheque.Delete()
               '    oCompCheque.CloseConection()

               oCompPlanAdd.WhereFilter = clsCompPlanAdd.WhereFilters.CompId
               oCompPlanAdd.EmpresaId = moComp.EmpresaId
               oCompPlanAdd.CompId = moComp.CompId
               Call oCompPlanAdd.Delete()
               '  oCompPlanAdd.CloseConection()

               oCompPlanEEFF.WhereFilter = clsCompPlanEEFF.WhereFilters.CompId
               oCompPlanEEFF.EmpresaId = moComp.EmpresaId
               oCompPlanEEFF.CompId = moComp.CompId
               Call oCompPlanEEFF.Delete()
               '  oCompPlanAdd.CloseConection()

               oCompCentroCostoDet.WhereFilter = clsCompCentroCostoDet.WhereFilters.CompId
               oCompCentroCostoDet.EmpresaId = moComp.EmpresaId
               oCompCentroCostoDet.CompId = moComp.CompId
               Call oCompCentroCostoDet.Delete()
               '  oCompCentroCostoDet.CloseConection()
               mboolChanged = False
            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
               oComp.Dispose()
               oCompDet.Dispose()
               oFactura.Dispose()
               oCompCheque.Dispose()
               oCompPlanAdd.Dispose()
               oCompPlanEEFF.Dispose()
               oCompCentroCostoDet.Dispose()
            End Try
         End If
      End If
   End Sub

#Region " Flujos de Efectivo "
#Region " Metodo-Flujos de Efectivo "

   Private Function EsCuentaDisponible(ByVal lngPlanId As Long, Optional ByRef strMessage As String = "") As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         EsCuentaDisponible = False

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               If .TipoPlanId = clsTipoPlan.CAJA Or .TipoPlanId = clsTipoPlan.CUENTA_CORRIENTE Then
                  EsCuentaDisponible = True
                  strMessage = .PlanDes
               End If
            End If
         End With

      Catch exp As Exception
         Throw exp
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Function CompPlanEEFFSaldo(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Decimal
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)
      Dim decDebe As Decimal = 0
      Dim decHaber As Decimal = 0
      Dim decSaldo As Decimal = 0

      Try
         CompPlanEEFFSaldo = 0

         With oCompPlanEEFF
            .SelectFilter = clsCompPlanEEFF.SelectFilters.All
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompDetId
            .EmpresaId = moComp.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  decDebe += .DebeOrg
                  decHaber += .HaberOrg

                  .MoveNext()
               Loop
            End If
         End With

         decSaldo = Math.Abs(decDebe - decHaber)
         CompPlanEEFFSaldo = Math.Abs(mdecCompDetMonto - decSaldo)

         'If CompPlanEEFFSaldo < 0.01 Then
         '   CompPlanEEFFSaldo = 0
         'End If
         CompPlanEEFFSaldo = ToDecimalMinor(CompPlanEEFFSaldo)

         If CompPlanEEFFSaldo <> 0 Then
            CompPlanEEFFSaldo = mdecCompDetMonto - decSaldo
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanEEFF.Dispose()

      End Try
   End Function

   Private Sub frmCompPlanEEFFEditLoad()
      Dim frm As New frmCompPlanEEFFEdit
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decCompPlanEEFFSaldo As Decimal

      Try
         With oCompDet
            .CompDetId = ToLong(grdMain.GetValue("CompDetId"))

            If .FindByPK Then
               Call CompPlanAddParametro(.DebeOrg, .HaberOrg)
               decCompPlanEEFFSaldo = CompPlanEEFFSaldo(.CompId, .CompDetId)

               If decCompPlanEEFFSaldo = 0 Then
                  MessageBox.Show("El Monto de la(s) Cuenta(s) de Flujo ya esta Balanceado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub

               ElseIf decCompPlanEEFFSaldo < 0 Then
                  MessageBox.Show("El Monto de la(s) Cuentas(s) de Flujo no puede ser Mayor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub
               End If

               Do While decCompPlanEEFFSaldo > 0
                  With oCompPlanEEFF
                     .EmpresaId = oCompDet.EmpresaId
                     .CompId = oCompDet.CompId
                     .CompDetId = oCompDet.CompDetId
                     .GestionId = oCompDet.GestionId
                     .Fecha = ToDate(dtpFecha.Value)
                     .PlanId = oCompDet.PlanId
                     .MonedaId = oCompDet.MonedaId
                     .EstadoId = 13

                     If mlngCol = 1 Then
                        .DebeOrg = decCompPlanEEFFSaldo

                     ElseIf mlngCol = 2 Then
                        .HaberOrg = decCompPlanEEFFSaldo
                     End If

                     frm.NewRecord = True
                     frm.Editing = False
                     frm.Changed = False
                     frm.TipoCambio = moComp.TipoCambio
                     frm.CompMonedaId = moComp.MonedaId
                     frm.Col = mlngCol
                     frm.CompDetMonto = mdecCompDetMonto
                     frm.DataObject = oCompPlanEEFF
                     frm.ShowDialog()

                     If frm.Changed Then
                        decCompPlanEEFFSaldo = CompPlanEEFFSaldo(.CompId, .CompDetId)

                        If decCompPlanEEFFSaldo > 0 Then
                           mboolEditGrid = True
                           Call DataSave(13)
                           Call grdMainLoad()
                           Call grdMainFindRow(oCompDet.CompDetId)
                        End If
                     Else
                        Exit Sub
                     End If
                  End With
               Loop
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanEEFF.Dispose()
         oCompDet.Dispose()

      End Try
   End Sub

   Private Sub frmCompPlanEEFFSelectLoad()
      Dim frm As New frmCompPlanEEFFSelect
      Try
         With frm
            For Each item In mdicListaPlanEEFFporITF.ToList
               Dim plan As String() = item.Key.Split(",")
               .PlanId = ToLong(plan(0))
               .PlanDes = ToStr((From row In grdMain.GetRows.AsEnumerable() Select PlanDes = row.Cells.Item("PlanDes").Value, PlanId = row.Cells.Item("PlanId").Value Where PlanId = ToLong(plan(0))).First.PlanDes)
               .NewRecord = True
               .Editing = False
               .ShowDialog()

               If .Changed Then
                  mdicListaPlanEEFFporITF.Item(item.Key) = .ID
               End If
            Next
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

#End Region

#Region " Grid-Flujo de Efectivo"
   Private Sub mnuCompPlanEEFFEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompPlanEEFFEdit.Click
      If grdMain.RowCount > 0 Then
         If EsCuentaDisponible(ToLong(grdMain.GetValue("PlanId"))) Then
            Call frmCompPlanEEFFEditLoad()
         Else
            MessageBox.Show("La Cuenta no es de Tipo Disponible", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub
#End Region

#End Region

   Private Function ValidarFecha(ByVal datFecha As Date, ByVal strFechaOrg As String) As Boolean
      ValidarFecha = True
      If ToLong(txtCompNro.Text) <> 0 And Not mboolNroAutoGestion Then
         If datFecha.Month <> ToDate2(strFechaOrg).Month Then
            ValidarFecha = False
         End If
      End If
   End Function

   Private Function PlanSaldoGestionBs(ByVal lngPlanId As Long, ByRef decSaldoUs As Decimal) As Decimal
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decDebeBs As Decimal = 0
      Dim decDebeUs As Decimal = 0
      Dim decHaberBs As Decimal = 0
      Dim decHaberUs As Decimal = 0
      Dim decSaldoBs As Decimal = 0
      decSaldoUs = 0
      Try

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuentaSucCCO
            .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoActualSucCCO
            .GroupByFilter = clsCompDet.GroupByFilters.LibroMayorCuentaSucCCO
            .EmpresaId = moComp.EmpresaId
            .GestionId = moComp.GestionId
            .PlanId = lngPlanId
            .CompId = moComp.CompId

            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  decDebeBs += ToDecimal(oRow("DebeBs"))
                  decDebeUs += ToDecimal(oRow("DebeUs"))
                  decHaberBs += ToDecimal(oRow("HaberBs"))
                  decHaberUs += ToDecimal(oRow("HaberUs"))
               Next

               PlanSaldoGestionBs = decDebeBs - decHaberBs
               decSaldoUs = decDebeUs - decHaberUs
            End If
         End With

      Catch exp As Exception
         Throw exp
      Finally
         oCompDet.Dispose()
      End Try
  
   End Function

#Region "Bitacora"
   Private oTipoOperacion As numTipoOperacion = 0

   Private Enum numTipoOperacion
      GUARDAR = 1
   End Enum

#End Region

End Class