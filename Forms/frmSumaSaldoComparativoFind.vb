Public Class frmSumaSaldoComparativoFind
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mlngEmpresaId As Long

   'Conexion a la otra BD
   Private mstrDataBaseOrg As String
   Private mstrConnectStringOrg As String
   Private mlngEmpresaIdOrg As Long
   Private mstrEmpresaDesOrg As String
   Private mlngGestionIdOrg As Long
   Private mlngGestionOrg As Long
   Private moDataTable As DataTable


   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cboCentroCosto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents chkConsolidar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Conexion As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Conexion1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents grpEmpresa As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboEmpresa As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Private mboolCheckTipoAsientoAll As Boolean


   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
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
   Friend WithEvents chkSaldoCero As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboTipoAsiento As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents grbFac As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optConFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optSinFac As Janus.Windows.EditControls.UIRadioButton
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkUltimoPeriodo As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckTrue As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckFalse As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckTrue1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckFalse1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents chkSaldoAnterior As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboEmpresa_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboCentroCosto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSumaSaldoComparativoFind))
      Dim cboTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpEmpresa = New Janus.Windows.EditControls.UIGroupBox
      Me.cboEmpresa = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.chkConsolidar = New Janus.Windows.EditControls.UICheckBox
      Me.grbFac = New Janus.Windows.EditControls.UIGroupBox
      Me.optConFac = New Janus.Windows.EditControls.UIRadioButton
      Me.optSinFac = New Janus.Windows.EditControls.UIRadioButton
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCosto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label5 = New System.Windows.Forms.Label
      Me.cboTipoAsiento = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.chkFecha = New Janus.Windows.EditControls.UICheckBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkSaldoCero = New Janus.Windows.EditControls.UICheckBox
      Me.chkSaldoAnterior = New Janus.Windows.EditControls.UICheckBox
      Me.chkUltimoPeriodo = New Janus.Windows.EditControls.UICheckBox
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckTrue1 = New Janus.Windows.UI.CommandBars.UICommand("CheckTrue")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckFalse1 = New Janus.Windows.UI.CommandBars.UICommand("CheckFalse")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Conexion1 = New Janus.Windows.UI.CommandBars.UICommand("Conexion")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.CheckTrue = New Janus.Windows.UI.CommandBars.UICommand("CheckTrue")
      Me.CheckFalse = New Janus.Windows.UI.CommandBars.UICommand("CheckFalse")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Conexion = New Janus.Windows.UI.CommandBars.UICommand("Conexion")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpEmpresa.SuspendLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbFac.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(853, 215)
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
      Me.grdMain.Size = New System.Drawing.Size(853, 215)
      Me.grdMain.TabIndex = 1
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpEmpresa)
      Me.bcgMain.Controls.Add(Me.grbFac)
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox3)
      Me.bcgMain.Controls.Add(Me.chkFecha)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(875, 414)
      Me.bcgMain.TabIndex = 164
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpEmpresa
      '
      Me.grpEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpEmpresa.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpEmpresa.Controls.Add(Me.cboEmpresa)
      Me.grpEmpresa.Controls.Add(Me.Label6)
      Me.grpEmpresa.Controls.Add(Me.chkConsolidar)
      Me.grpEmpresa.Location = New System.Drawing.Point(4, 0)
      Me.grpEmpresa.Name = "grpEmpresa"
      Me.grpEmpresa.Size = New System.Drawing.Size(869, 60)
      Me.grpEmpresa.TabIndex = 0
      Me.grpEmpresa.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboEmpresa
      '
      Me.cboEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cboEmpresa.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
      Me.cboEmpresa.ControlStyle.ControlTextColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.ControlStyle.WindowTextColor = System.Drawing.SystemColors.HotTrack
      cboEmpresa_DesignTimeLayout.LayoutString = resources.GetString("cboEmpresa_DesignTimeLayout.LayoutString")
      Me.cboEmpresa.DesignTimeLayout = cboEmpresa_DesignTimeLayout
      Me.cboEmpresa.DropDownButtonsVisible = False
      Me.cboEmpresa.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.Location = New System.Drawing.Point(76, 12)
      Me.cboEmpresa.Name = "cboEmpresa"
      Me.cboEmpresa.SaveSettings = False
      Me.cboEmpresa.Size = New System.Drawing.Size(785, 20)
      Me.cboEmpresa.TabIndex = 1
      Me.cboEmpresa.ValuesDataMember = Nothing
      Me.cboEmpresa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label6.Location = New System.Drawing.Point(8, 16)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(64, 16)
      Me.Label6.TabIndex = 235
      Me.Label6.Text = "Empresas"
      '
      'chkConsolidar
      '
      Me.chkConsolidar.BackColor = System.Drawing.Color.Transparent
      Me.chkConsolidar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkConsolidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkConsolidar.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkConsolidar.Location = New System.Drawing.Point(8, 40)
      Me.chkConsolidar.Name = "chkConsolidar"
      Me.chkConsolidar.Size = New System.Drawing.Size(144, 16)
      Me.chkConsolidar.TabIndex = 2
      Me.chkConsolidar.Text = "Consolidar Empresas"
      Me.chkConsolidar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grbFac
      '
      Me.grbFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grbFac.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbFac.Controls.Add(Me.optConFac)
      Me.grbFac.Controls.Add(Me.optSinFac)
      Me.grbFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbFac.Location = New System.Drawing.Point(720, 364)
      Me.grbFac.Name = "grbFac"
      Me.grbFac.Size = New System.Drawing.Size(84, 32)
      Me.grbFac.TabIndex = 12
      Me.grbFac.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'optConFac
      '
      Me.optConFac.BackColor = System.Drawing.Color.Transparent
      Me.optConFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optConFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optConFac.Location = New System.Drawing.Point(48, 12)
      Me.optConFac.Name = "optConFac"
      Me.optConFac.Size = New System.Drawing.Size(28, 16)
      Me.optConFac.TabIndex = 14
      Me.optConFac.Text = "F"
      Me.optConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optSinFac
      '
      Me.optSinFac.BackColor = System.Drawing.Color.Transparent
      Me.optSinFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optSinFac.Checked = True
      Me.optSinFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optSinFac.Location = New System.Drawing.Point(8, 12)
      Me.optSinFac.Name = "optSinFac"
      Me.optSinFac.Size = New System.Drawing.Size(28, 16)
      Me.optSinFac.TabIndex = 13
      Me.optSinFac.TabStop = True
      Me.optSinFac.Text = "I"
      Me.optSinFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup2.Container = True
      ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup2.ContainerHeight = 216
      ExplorerBarGroup2.Expandable = False
      ExplorerBarGroup2.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 64)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(869, 248)
      Me.ebrMain.TabIndex = 9
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.cboCentroCosto)
      Me.UiGroupBox3.Controls.Add(Me.Label5)
      Me.UiGroupBox3.Controls.Add(Me.cboTipoAsiento)
      Me.UiGroupBox3.Controls.Add(Me.Label2)
      Me.UiGroupBox3.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox3.Controls.Add(Me.Label1)
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(184, 320)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(336, 92)
      Me.UiGroupBox3.TabIndex = 3
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCosto
      '
      cboCentroCosto_DesignTimeLayout.LayoutString = resources.GetString("cboCentroCosto_DesignTimeLayout.LayoutString")
      Me.cboCentroCosto.DesignTimeLayout = cboCentroCosto_DesignTimeLayout
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(88, 16)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedIndex = -1
      Me.cboCentroCosto.SelectedItem = Nothing
      Me.cboCentroCosto.Size = New System.Drawing.Size(244, 20)
      Me.cboCentroCosto.TabIndex = 1
      Me.cboCentroCosto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboCentroCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(4, 20)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(80, 16)
      Me.Label5.TabIndex = 227
      Me.Label5.Text = "Centro Costo"
      '
      'cboTipoAsiento
      '
      Me.cboTipoAsiento.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
      Me.cboTipoAsiento.ControlStyle.ControlTextColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAsiento.ControlStyle.WindowTextColor = System.Drawing.SystemColors.HotTrack
      cboTipoAsiento_DesignTimeLayout.LayoutString = resources.GetString("cboTipoAsiento_DesignTimeLayout.LayoutString")
      Me.cboTipoAsiento.DesignTimeLayout = cboTipoAsiento_DesignTimeLayout
      Me.cboTipoAsiento.DropDownButtonsVisible = False
      Me.cboTipoAsiento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAsiento.Location = New System.Drawing.Point(88, 64)
      Me.cboTipoAsiento.Name = "cboTipoAsiento"
      Me.cboTipoAsiento.SaveSettings = False
      Me.cboTipoAsiento.Size = New System.Drawing.Size(244, 20)
      Me.cboTipoAsiento.TabIndex = 3
      Me.cboTipoAsiento.ValuesDataMember = Nothing
      Me.cboTipoAsiento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(3, 68)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(81, 18)
      Me.Label2.TabIndex = 226
      Me.Label2.Text = "Tipo Asiento"
      '
      'cboMoneda
      '
      Me.cboMoneda.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(88, 40)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(108, 20)
      Me.cboMoneda.TabIndex = 2
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(3, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(52, 16)
      Me.Label1.TabIndex = 161
      Me.Label1.Text = "Moneda"
      '
      'chkFecha
      '
      Me.chkFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFecha.Location = New System.Drawing.Point(16, 316)
      Me.chkFecha.Name = "chkFecha"
      Me.chkFecha.Size = New System.Drawing.Size(112, 20)
      Me.chkFecha.TabIndex = 3
      Me.chkFecha.Text = "Habilitar Fechas"
      Me.chkFecha.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.dtpFechaFin)
      Me.grpMain.Controls.Add(Me.dtpFechaIni)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(4, 320)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(176, 92)
      Me.grpMain.TabIndex = 2
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dtpFechaFin
      '
      Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaFin.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaFin.DropDownCalendar.Name = ""
      Me.dtpFechaFin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaFin.Enabled = False
      Me.dtpFechaFin.Location = New System.Drawing.Point(56, 44)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(112, 20)
      Me.dtpFechaFin.TabIndex = 5
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'dtpFechaIni
      '
      Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaIni.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaIni.DropDownCalendar.Name = ""
      Me.dtpFechaIni.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaIni.Enabled = False
      Me.dtpFechaIni.Location = New System.Drawing.Point(56, 20)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(112, 20)
      Me.dtpFechaIni.TabIndex = 4
      Me.dtpFechaIni.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(8, 24)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(44, 16)
      Me.Label3.TabIndex = 154
      Me.Label3.Text = "Desde"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 48)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(44, 16)
      Me.Label4.TabIndex = 153
      Me.Label4.Text = "Hasta"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.chkSaldoCero)
      Me.UiGroupBox2.Controls.Add(Me.chkSaldoAnterior)
      Me.UiGroupBox2.Controls.Add(Me.chkUltimoPeriodo)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(524, 320)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(190, 92)
      Me.UiGroupBox2.TabIndex = 4
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkSaldoCero
      '
      Me.chkSaldoCero.BackColor = System.Drawing.Color.Transparent
      Me.chkSaldoCero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSaldoCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSaldoCero.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkSaldoCero.Location = New System.Drawing.Point(4, 64)
      Me.chkSaldoCero.Name = "chkSaldoCero"
      Me.chkSaldoCero.Size = New System.Drawing.Size(179, 16)
      Me.chkSaldoCero.TabIndex = 11
      Me.chkSaldoCero.Text = "Cuentas con Saldo Cero"
      Me.chkSaldoCero.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkSaldoAnterior
      '
      Me.chkSaldoAnterior.BackColor = System.Drawing.Color.Transparent
      Me.chkSaldoAnterior.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSaldoAnterior.Enabled = False
      Me.chkSaldoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSaldoAnterior.Location = New System.Drawing.Point(5, 14)
      Me.chkSaldoAnterior.Name = "chkSaldoAnterior"
      Me.chkSaldoAnterior.Size = New System.Drawing.Size(178, 16)
      Me.chkSaldoAnterior.TabIndex = 9
      Me.chkSaldoAnterior.Text = "Incluir Saldo Anterior"
      Me.chkSaldoAnterior.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkUltimoPeriodo
      '
      Me.chkUltimoPeriodo.BackColor = System.Drawing.Color.Transparent
      Me.chkUltimoPeriodo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkUltimoPeriodo.Enabled = False
      Me.chkUltimoPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkUltimoPeriodo.Location = New System.Drawing.Point(4, 40)
      Me.chkUltimoPeriodo.Name = "chkUltimoPeriodo"
      Me.chkUltimoPeriodo.Size = New System.Drawing.Size(179, 16)
      Me.chkUltimoPeriodo.TabIndex = 10
      Me.chkUltimoPeriodo.Text = "Incluir Saldos de la Gestión"
      Me.chkUltimoPeriodo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      Me.ilsMain.Images.SetKeyName(6, "enable_server_icon-icons.com_76722.ico")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.CheckTrue, Me.CheckFalse, Me.ViewAll, Me.Exit2, Me.Conexion})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("4774fd51-7cca-4d18-98a3-351f62d894a6")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.CheckTrue1, Me.Separator2, Me.CheckFalse1, Me.Separator3, Me.Conexion1, Me.Separator5, Me.ViewAll1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(442, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Balance Comparativo"
      Me.Book1.ToolTipText = "Balance Comparativo de Sumas y Saldos"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'CheckTrue1
      '
      Me.CheckTrue1.Key = "CheckTrue"
      Me.CheckTrue1.Name = "CheckTrue1"
      Me.CheckTrue1.Text = "Seleccionar Todos"
      Me.CheckTrue1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'CheckFalse1
      '
      Me.CheckFalse1.Key = "CheckFalse"
      Me.CheckFalse1.Name = "CheckFalse1"
      Me.CheckFalse1.Text = "Quitar Selección"
      Me.CheckFalse1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Conexion1
      '
      Me.Conexion1.Key = "Conexion"
      Me.Conexion1.Name = "Conexion1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'ViewAll1
      '
      Me.ViewAll1.Key = "ViewAll"
      Me.ViewAll1.Name = "ViewAll1"
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
      Me.Book.ImageIndex = 0
      Me.Book.Key = "Book"
      Me.Book.Name = "Book"
      Me.Book.Text = "Libro"
      '
      'CheckTrue
      '
      Me.CheckTrue.ImageIndex = 1
      Me.CheckTrue.Key = "CheckTrue"
      Me.CheckTrue.Name = "CheckTrue"
      '
      'CheckFalse
      '
      Me.CheckFalse.ImageIndex = 2
      Me.CheckFalse.Key = "CheckFalse"
      Me.CheckFalse.Name = "CheckFalse"
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
      'Conexion
      '
      Me.Conexion.ImageIndex = 6
      Me.Conexion.Key = "Conexion"
      Me.Conexion.Name = "Conexion"
      Me.Conexion.Text = "Configurar Conexión"
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
      Me.TopRebar1.Size = New System.Drawing.Size(875, 28)
      '
      'frmSumaSaldoComparativoFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(875, 442)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmSumaSaldoComparativoFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Criterios Balance de Sumas y Saldos Comparativo"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpEmpresa.ResumeLayout(False)
      Me.grpEmpresa.PerformLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbFac.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      Me.UiGroupBox3.PerformLayout()
      CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
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
            'If frmDataBaseOrgLoad() Then
            Call frmSumaSaldoLoad()
            'End If

         Case "Conexion"
            Call frmDataBaseOrgLoad(True)

         Case "ViewAll"
            Call DataViewAll()

         Case "CheckTrue"
            Call grdMainCheck(True)

         Case "CheckFalse"
            Call grdMainCheck(False)

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmSumaSaldoComparativoFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmSumaSaldoComparativoFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call ComboLoad()
      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboTipoAsientoLoad()
      Call cboCentroCostoLoad()
   End Sub

#Region " ComboLoads "

   Private Sub CargarEmpresas()
      Dim oEmpresa As New clsEmpresa(mstrConnectStringOrg)
      Dim pos As Long = moDataTable.Rows.Count + 1

      Try
         With oEmpresa
            .SelectFilter = clsEmpresa.SelectFilters.EmpresaGestion
            .WhereFilter = clsEmpresa.WhereFilters.EmpresaGestion
            .OrderByFilter = clsEmpresa.OrderByFilters.EmpresaGestion


            If .Open Then
               Dim oRow As DataRow

               For Each row In .DataSet.Tables(.TableName).Rows
                  If Not (clsAppInfo.ConnectString = mstrConnectStringOrg And clsAppInfo.EmpresaId = ToLong(row("EmpresaId")) And clsAppInfo.GestionId = ToLong(row("GestionId"))) Then
                     If (mlngEmpresaIdOrg = 0 Or mlngEmpresaIdOrg = ToLong(row("EmpresaId"))) And (mlngGestionIdOrg = 0 Or mlngGestionIdOrg = ToLong(row("GestionId"))) Then
                        oRow = moDataTable.NewRow
                        oRow("Id") = pos
                        oRow("DataBase") = mstrDataBaseOrg
                        oRow("ConnectString") = mstrConnectStringOrg
                        oRow("EmpresaGestion") = row("EmpresaDes") & " - " & row("Gestion")
                        oRow("EmpresaId") = row("EmpresaId")
                        oRow("EmpresaDes") = row("EmpresaDes")
                        oRow("GestionId") = row("GestionId")
                        oRow("Gestion") = row("Gestion")
                        moDataTable.Rows.Add(oRow)
                        pos += 1
                     End If
                  End If
               Next

               Call cboEmpresaLoad()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oEmpresa.Dispose()
      End Try
   End Sub

   Private Sub cboEmpresaLoad()
      With cboEmpresa
         .DropDownDataSource = moDataTable
         .RetrieveStructure()
         .DropDownList.Columns(0).UseHeaderSelector = True

         .ValueItemDataMember = "Id"
         .DropDownValueMember = "Id"
         .DropDownDisplayMember = "EmpresaGestion"
         .DropDownList.Columns("Id").Visible = False
         .DropDownList.Columns("EmpresaId").Visible = False

         .DropDownList.Columns("EmpresaDes").Caption = "Empresa"
         .DropDownList.Columns("EmpresaDes").Width = 200

         .DropDownList.Columns("GestionId").Visible = False

         .DropDownList.Columns("Gestion").Caption = "Gestión"
         .DropDownList.Columns("Gestion").Width = 60

         .DropDownList.Columns("DataBase").Caption = "Base de Datos"
         .DropDownList.Columns("DataBase").Width = 200

         .DropDownList.Columns("ConnectString").Caption = "Conexión"
         .DropDownList.Columns("ConnectString").Width = 700

         .DropDownList.Columns("EmpresaGestion").Visible = False
      End With
   End Sub

   Private Sub cboCentroCostoLoad()
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.All
            .WhereFilter = clsCentroCosto.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = mlngEmpresaId
            .EstadoId = 1

            If .Open() Then
               Dim oRow = .DataSet.Tables(.TableName).NewRow
               oRow("CentroCostoId") = 0
               oRow("CentroCostoCod") = "(Todos)"
               oRow("CentroCostoDes") = "(Todos)"
               .DataSet.Tables(.TableName).Rows.InsertAt(oRow, 0)

               With cboCentroCosto
                  .DropDownList.Columns.Clear()

                  .DropDownList.Columns.Add("CentroCostoId")
                  .DropDownList.Columns("CentroCostoId").DataMember = "CentroCostoId"
                  .DropDownList.Columns("CentroCostoId").Visible = False

                  .DropDownList.Columns.Add("CentroCostoCod")
                  .DropDownList.Columns("CentroCostoCod").Caption = "Código"
                  .DropDownList.Columns("CentroCostoCod").DataMember = "CentroCostoCod"
                  .DropDownList.Columns("CentroCostoCod").Width = 100

                  .DropDownList.Columns.Add("CentroCostoDes")
                  .DropDownList.Columns("CentroCostoDes").Caption = "Descripción"
                  .DropDownList.Columns("CentroCostoDes").DataMember = "CentroCostoDes"
                  .DropDownList.Columns("CentroCostoDes").Width = 400

                  .DataMember = oCentroCosto.TableName
                  .DataSource = oCentroCosto.DataSet

                  .ValueMember = "CentroCostoId"
                  .DisplayMember = "CentroCostoDes"
               End With

               cboCentroCosto.Value = ListFindItem(cboCentroCosto, 0)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCentroCosto.Dispose()
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
                  If .MonedaId <> 0 Then
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

   Private Sub cboTipoAsientoLoad()
      Dim oTipoAsiento As New clsTipoAsiento(clsAppInfo.ConnectString)

      Try
         With oTipoAsiento
            .SelectFilter = clsTipoAsiento.SelectFilters.ListBox
            .OrderByFilter = clsTipoAsiento.OrderByFilters.TipoAsientoDes

            If .Open() Then
               Dim oRow As DataRow

               oRow = .DataSet.Tables(.TableName).NewRow
               oRow("TipoAsientoId") = -1
               oRow("TipoAsientoDes") = "(Todos)"

               .DataSet.Tables(.TableName).Rows.InsertAt(oRow, 0)

               With cboTipoAsiento
                  .DropDownDataSource = oTipoAsiento.DataSet.Tables(oTipoAsiento.TableName)
                  .RetrieveStructure()

                  .ValueItemDataMember = "TipoAsientoId"
                  .DropDownValueMember = "TipoAsientoId"
                  .DropDownDisplayMember = "TipoAsientoDes"
                  .DropDownList.Columns(0).UseHeaderSelector = True

                  .DropDownList.Columns("TipoAsientoId").Visible = False

                  .DropDownList.Columns("TipoAsientoDes").Caption = "Descripción"
                  .DropDownList.Columns("TipoAsientoDes").Width = 300

                  Call cboTipoAsientoEventos()
               End With

               'cboPlan.Value = ListFindItem(cboPlan, 0)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoAsiento.Dispose()

      End Try
   End Sub
#End Region

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moPlan = New clsPlan(clsAppInfo.ConnectString)
      If GestionFecha(clsAppInfo.GestionId, mstrFechaIni, mstrFechaFin) Then
         dtpFechaIni.Value = mstrFechaIni
         dtpFechaFin.Value = mstrFechaFin
      End If

      dtpFechaIni.MaxDate = mstrFechaFin
      dtpFechaIni.MinDate = mstrFechaIni
      dtpFechaFin.MaxDate = mstrFechaFin
      dtpFechaFin.MinDate = mstrFechaIni

      dtpFechaFin.Value = Date.Now

      cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
      cboTipoAsiento.DropDownList.GetRows(0).IsChecked = True
      cboTipoAsiento.Text = cboTipoAsiento.DropDownList.GetRows(0).Cells("TipoAsientoDes").Value
      If Not clsAppInfo.MultipleNro Then
         optSinFac.Checked = True
         grbFac.Visible = False
      End If

      Call moDataTableInit()
   End Sub

   Private Sub moDataTableInit()
      moDataTable = New DataTable("cboEmpresa")

      moDataTable.Columns.Add("Id", Type.GetType("System.Int32"))

      moDataTable.Columns.Add("EmpresaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EmpresaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("GestionId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Gestion", Type.GetType("System.Int32"))

      moDataTable.Columns.Add("DataBase", Type.GetType("System.String"))
      moDataTable.Columns.Add("ConnectString", Type.GetType("System.String"))
      moDataTable.Columns.Add("EmpresaGestion", Type.GetType("System.String"))

      Call cboEmpresaLoad()
   End Sub

   Private Sub grdMainCheck(ByVal boolValue As Boolean)
      Dim oRow As DataRowView

      grdMain.MoveLast()
      grdMain.MoveFirst()

      With moPlan
         For Each oRow In .DataSet.Tables(.TableName).DefaultView
            oRow("Sel") = boolValue
         Next
      End With
   End Sub

   Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
      If ToBoolean(chkFecha.Checked) = 0 Then
         dtpFechaFin.Value = Date.Now
         dtpFechaIni.Value = mstrFechaIni
      End If

      dtpFechaIni.Enabled = chkFecha.Checked
      dtpFechaFin.Enabled = chkFecha.Checked

      chkUltimoPeriodo.Enabled = chkFecha.Checked
      chkUltimoPeriodo.Checked = False

      chkSaldoAnterior.Enabled = chkFecha.Checked
      chkSaldoAnterior.Checked = False
   End Sub

   Private Sub frmSumaSaldoComparativoFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmSumaSaldoLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Function ValidarGestionesEmpresas(ByRef strMsg As String) As Boolean
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)
      ValidarGestionesEmpresas = True

      With oGestion
         .GestionId = clsAppInfo.GestionId

         If .FindByPK Then
            For Each oRow In cboEmpresa.DropDownList.GetCheckedRows
               Dim oGestionEmpresa As New clsGestion(oRow.Cells("ConnectString").Value)
               oGestionEmpresa.GestionId = ToLong(oRow.Cells("GestionId").Value)

               If oGestionEmpresa.FindByPK Then
                  If ToDate2(oGestionEmpresa.FechaIni).Day <> ToDate2(oGestion.FechaIni).Day Or ToDate2(oGestionEmpresa.FechaIni).Month <> ToDate2(oGestion.FechaIni).Month _
                  Or ToDate2(oGestionEmpresa.FechaFin).Day <> ToDate2(oGestion.FechaFin).Day Or ToDate2(oGestionEmpresa.FechaFin).Month <> ToDate2(oGestion.FechaFin).Month _
                  Or ToDate2(oGestionEmpresa.FechaFin).Year - ToDate2(oGestionEmpresa.FechaIni).Year <> ToDate2(oGestion.FechaFin).Year - ToDate2(oGestion.FechaIni).Year Then
                     ValidarGestionesEmpresas = False
                     strMsg &= "Intervalos de Gestiones no coincide" & ".- " & ToStr(oRow.Cells("EmpresaDes").Value) & ": " & ToStr(oRow.Cells("Gestion").Value) & ": " & _
                                               ToDateDMY(oGestionEmpresa.FechaIni) & " - " & ToDateDMY(oGestionEmpresa.FechaFin) & " <> " & _
                                               ToDateDMY(oGestion.FechaIni) & " - " & ToDateDMY(oGestion.FechaFin) & " " & vbCrLf

                  End If
               End If
            Next
         End If
      End With
   End Function

   Private Function FormCheck() As Boolean
      Dim strMessage As String = ""
      FormCheck = True

      If cboEmpresa.DropDownList.GetCheckedRows.Count = 0 Then
         strMessage &= "Debe Seleccionar una Empresa." & vbCrLf
      End If

      Dim strGestiones As String = String.Empty
      If Not ValidarGestionesEmpresas(strGestiones) Then
         FormCheck = False
         strMessage &= strGestiones
      End If

      If grdMain.GetCheckedRows.Count = 0 Then
         strMessage &= "Debe Seleccionar al menos una Cuenta Contable." & vbCrLf
      End If

      If ListPosition(cboCentroCosto) < 0 Then
         strMessage &= "Debe Seleccionar un Centro de Costo." & vbCrLf
      End If

      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) <= 0 Then
         strMessage &= "Debe Seleccionar la Moneda." & vbCrLf
      End If

      If cboTipoAsiento.DropDownList.GetCheckedRows.Count = 0 Then
         strMessage &= "Debe Seleccionar al Menos un Tipo de Asiento." & vbCrLf
      End If

      If strMessage <> "" Then
         FormCheck = False
         MessageBox.Show(strMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Function frmDataBaseOrgLoad(Optional ByVal ModificarConexion As Boolean = False) As Boolean
      Dim frm As New frmDataBaseOrgEmpresa

      frmDataBaseOrgLoad = False

      If Not clsAppInfo.Recordar Or ModificarConexion Then
         With frm
            .Todos = True 'agrega el ListItem(Todos) a empresa y Gestion
            .ShowDialog()

            If .Changed Then
               mstrConnectStringOrg = .ConnectStringOrg
               mstrDataBaseOrg = .DataBaseOrg
               mlngEmpresaIdOrg = .EmpresaId
               mstrEmpresaDesOrg = .EmpresaDes
               mlngGestionIdOrg = .GestionId
               mlngGestionOrg = .Gestion
               frmDataBaseOrgLoad = True

               Call CargarEmpresas()
            End If
         End With
      Else
         mstrConnectStringOrg = clsAppInfo.ConnectStringTemp
         mstrDataBaseOrg = clsAppInfo.DataBaseTemp
         mlngEmpresaIdOrg = clsAppInfo.EmpresaIdTemp
         mstrEmpresaDesOrg = clsAppInfo.EmpresaDesTemp
         mlngGestionIdOrg = clsAppInfo.GestionIdTemp
         mlngGestionOrg = clsAppInfo.GestionTemp
         frmDataBaseOrgLoad = True
      End If

      frm.Dispose()
   End Function

   Private Sub frmSumaSaldoLoad()
      Dim oLista As New List(Of String)

      If FormCheck() Then
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            oLista.Add(oRow.Cells("PlanCta").Value)
         Next

         Dim oListaTipoAsiento As New Queue
         For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetCheckedRows
            oListaTipoAsiento.Enqueue(oRow.Cells("TipoAsientoId").Value)
         Next

         Dim frm As New frmSumaSaldoComparativo

         With frm
            .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)

            .IntervaloFecha = ToBoolean(chkFecha.Checked)
            .FechaIniInt = dtpFechaIni.Value
            .FechaFinInt = dtpFechaFin.Value

            Call GestionFecha(clsAppInfo.GestionId, .FechaIni, .FechaFin)

            .UltimoPeriodo = ToBoolean(chkUltimoPeriodo.Checked)
            .SaldoAnterior = ToBoolean(chkSaldoAnterior.Checked)
            .SaldoCero = ToBoolean(chkSaldoCero.Checked)

            .SinFac = ToBoolean(optSinFac.Checked)
            .ConFac = ToBoolean(optConFac.Checked)

            .CentroCostoDes = ToStr(cboCentroCosto.Text)
            .CentroCostoCod = ToStr(cboCentroCosto.DropDownList.GetRow().Cells("CentroCostoCod").Value)
            .SeleccionoTodosCC = ToLong(ListPosition(cboCentroCosto)) = 0

            .Consolidado = ToBoolean(chkConsolidar.Checked)

            .IncluirCuentasEmpresas = grdMain.GetCheckedRows.Count = CType(grdMain.DataSource, DataView).Count

            .ListaEmpresas.Add(New Contabilidad.frmSumaSaldoComparativo.EmpresaData(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, clsAppInfo.GestionId, clsAppInfo.EmpresaDes, clsAppInfo.Gestion))
            For Each row In cboEmpresa.DropDownList.GetCheckedRows
               .ListaEmpresas.Add(New Contabilidad.frmSumaSaldoComparativo.EmpresaData(ToStr(row.Cells("ConnectString").Value), ToLong(row.Cells("EmpresaId").Value), ToLong(row.Cells("GestionId").Value), ToStr(row.Cells("EmpresaDes").Value), ToLong(row.Cells("Gestion").Value)))
            Next

            .ListaTipoAsiento = oListaTipoAsiento
            .Lista = oLista
            .MdiParent = Me.MdiParent
            .Show()

            Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, Me.ToString)
         End With
      End If
   End Sub

   Private Sub frmSumaSaldoComparativoFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
   End Sub

#Region " PLAN "
#Region " Metodo Plan "
   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("TieneAnaAdd"), Janus.Windows.GridEX.ConditionOperator.Equal, True)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("TieneAnaAdd"), Janus.Windows.GridEX.ConditionOperator.Equal, False)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EsAna"), Janus.Windows.GridEX.ConditionOperator.Equal, False)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " Grid Plan "
   Private Sub grdMainLoad()
      Try
         With moPlan
            .SelectFilter = clsPlan.SelectFilters.GridPadreCheck
            .WhereFilter = clsPlan.WhereFilters.GridFind
            .OrderByFilter = clsPlan.OrderByFilters.PlanCta

            .EmpresaId = mlngEmpresaId
            .EsAna = 1
            If .Open() Then
               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Plan de Cuentas"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("PlanCta").Caption = "Código"
         .RootTable.Columns("PlanCta").Width = 100
         .RootTable.Columns("PlanCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDes").Caption = "Descripción"
         .RootTable.Columns("PlanDes").Width = 200
         .RootTable.Columns("PlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanCtaPadre").Caption = "Código Padre"
         .RootTable.Columns("PlanCtaPadre").Width = 100
         .RootTable.Columns("PlanCtaPadre").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanCtaPadre").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanDesPadre").Caption = "Descripción Padre"
         .RootTable.Columns("PlanDesPadre").Width = 200
         .RootTable.Columns("PlanDesPadre").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanDesPadre").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EsAna").Visible = False

         .RootTable.Columns("PlanPadreId").Visible = False

         .RootTable.Columns("Orden").Visible = False

         .RootTable.Columns("Nivel").Visible = False

         .RootTable.Columns("TipoPlanId").Visible = False

         .RootTable.Columns("TipoPlanDes").Caption = "Tipo Cuenta"
         .RootTable.Columns("TipoPlanDes").Width = 100
         .RootTable.Columns("TipoPlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoPlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TieneAnaAdd").Caption = "Ana Ad"
         .RootTable.Columns("TieneAnaAdd").Width = 50
         .RootTable.Columns("TieneAnaAdd").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TieneAnaAdd").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("SucCCOId").Visible = False

         .RootTable.Columns("SucCCODes").Caption = "Suc. / C.C."
         .RootTable.Columns("SucCCODes").Width = 100
         .RootTable.Columns("SucCCODes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("SucCCODes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

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

#Region " Otros Metodos "
   Private Function GestionFecha(ByVal GestionId As Long, ByRef strFechaIni As String, ByRef strFechaFin As String) As Boolean
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionFecha = False
      Try
         With oGestion
            .GestionId = GestionId

            If .FindByPK Then
               strFechaIni = .FechaIni
               strFechaFin = .FechaFin
               GestionFecha = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oGestion.Dispose()
      End Try
   End Function
#End Region

#Region " cboTipoAsiento-Metodos "
   Private Sub cboTipoAsientoEventos()
      Dim b As New Janus.Windows.GridEX.RowCheckStateChangeEventHandler(AddressOf cboTipoAsiento_RowCheckStateChanged)
      AddHandler cboTipoAsiento.DropDownList.RowCheckStateChanged, b

      Dim c As New Janus.Windows.GridEX.RowCheckStateChangingEventHandler(AddressOf cboTipoAsiento_RowCheckStateChanging)
      AddHandler cboTipoAsiento.DropDownList.RowCheckStateChanging, c
   End Sub

   Private Sub cboTipoAsiento_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs)
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         cboTipoAsientoCheckAll(True)
      End If
   End Sub

   Private Sub cboTipoAsiento_RowCheckStateChanging(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangingEventArgs)
      If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
         If cboTipoAsiento.DropDownList.GetRow.Cells("TipoAsientoId").Value = -1 And (cboTipoAsiento.DropDownList.GetCheckedRows.Count > 0) Then
            If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
               cboTipoAsientoCheckAll(True)
            End If

            e.Cancel = True

         ElseIf cboTipoAsiento.DropDownList.GetRow.Cells("TipoAsientoId").Value <> -1 Then
            cboTipoAsiento_CheckTodos(False)
         End If
      End If
   End Sub

   Private Sub cboTipoAsientoCheckAll(ByVal boolValue As Boolean)
      If mboolCheckTipoAsientoAll Then
         mboolCheckTipoAsientoAll = False
      Else
         mboolCheckTipoAsientoAll = True
      End If

      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetRows
         oRow.BeginEdit()

         If oRow.Cells("TipoAsientoId").Value = -1 Then
            oRow.IsChecked = False
         Else
            oRow.IsChecked = mboolCheckTipoAsientoAll
         End If

         oRow.EndEdit()
      Next
   End Sub

   Private Sub cboTipoAsiento_CheckTodos(ByVal boolValue As Boolean)
      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetRows
         oRow.BeginEdit()

         If oRow.Cells("TipoAsientoId").Value = -1 Then
            oRow.IsChecked = boolValue
         End If

         oRow.EndEdit()

         Exit For
      Next
   End Sub
#End Region

   Public Overrides Function ToString() As String
      Return "Gestión: " & clsAppInfo.Gestion & If(chkFecha.Checked, "; Desde " & dtpFechaIni.Text & " Hasta " & dtpFechaFin.Text, "") & "; CC : " & cboCentroCosto.Text & "; Moneda : " & cboMoneda.Text & "; Tipo Asiento: " & cboTipoAsiento.Text & "; Incluir Saldo Anterior.: " & If(chkSaldoAnterior.Checked, "Sí", "No") & "; Incluir Saldo Gestion: " & If(chkUltimoPeriodo.Checked, "Sí", "No") & "; Cuentas con saldo Cero: " & If(chkSaldoCero.Checked, "Sí", "No")
   End Function

   Private Sub chkConsolidar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkConsolidar.CheckedChanged
      If chkConsolidar.Checked Then
         Book1.Text = "Balance Consolidado"
         Me.Text = "Criterios Balance de Sumas y Saldos Consolidado"
      Else
         Book1.Text = "Balance Comparativo"
         Me.Text = "Criterios Balance de Sumas y Saldos Comparativo"
      End If
   End Sub

End Class
