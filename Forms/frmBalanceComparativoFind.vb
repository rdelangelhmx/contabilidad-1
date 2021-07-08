Public Class frmBalanceComparativoFind
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan
   Private mlngEmpresaId As Long

   Private mstrDataBaseOrg As String
   Private mstrConnectStringOrg As String
   Private mstrConnectString1 As String
   Private mstrConnectString2 As String

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moDataTableEmpresas As DataTable
   Private moDataTableError As DataTable

   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Friend WithEvents Connect1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Connect As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents dudNivel As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuOrigen As System.Windows.Forms.MenuItem
   Friend WithEvents chkConsolidar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents grbFac As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optConFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optSinFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents cboCentroCosto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents grpOrigen As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkIncluirPlanAdd As Janus.Windows.EditControls.UICheckBox
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
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents cboTipoAsiento As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkTotalizar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckTrue As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckFalse As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll2 As Janus.Windows.UI.CommandBars.UICommand
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
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboCentroCosto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalanceComparativoFind))
      Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpOrigen = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCosto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label1 = New System.Windows.Forms.Label
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkIncluirPlanAdd = New Janus.Windows.EditControls.UICheckBox
      Me.chkConsolidar = New Janus.Windows.EditControls.UICheckBox
      Me.chkTotalizar = New Janus.Windows.EditControls.UICheckBox
      Me.grbFac = New Janus.Windows.EditControls.UIGroupBox
      Me.optConFac = New Janus.Windows.EditControls.UIRadioButton
      Me.optSinFac = New Janus.Windows.EditControls.UIRadioButton
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label4 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.dudNivel = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboTipoAsiento = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Connect1 = New Janus.Windows.UI.CommandBars.UICommand("Connect")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckTrue1 = New Janus.Windows.UI.CommandBars.UICommand("CheckTrue")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckFalse1 = New Janus.Windows.UI.CommandBars.UICommand("CheckFalse")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.CheckTrue = New Janus.Windows.UI.CommandBars.UICommand("CheckTrue")
      Me.CheckFalse = New Janus.Windows.UI.CommandBars.UICommand("CheckFalse")
      Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Connect = New Janus.Windows.UI.CommandBars.UICommand("Connect")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuOrigen = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpOrigen.SuspendLayout()
      CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbFac.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(803, 311)
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
      Me.grdMain.Size = New System.Drawing.Size(803, 311)
      Me.grdMain.TabIndex = 1
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpOrigen)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(827, 431)
      Me.bcgMain.TabIndex = 163
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpOrigen
      '
      Me.grpOrigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grpOrigen.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpOrigen.Controls.Add(Me.cboCentroCosto)
      Me.grpOrigen.Controls.Add(Me.Label1)
      Me.grpOrigen.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpOrigen.Location = New System.Drawing.Point(200, 352)
      Me.grpOrigen.Name = "grpOrigen"
      Me.grpOrigen.Size = New System.Drawing.Size(412, 40)
      Me.grpOrigen.TabIndex = 2
      Me.grpOrigen.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCosto
      '
      cboCentroCosto_DesignTimeLayout.LayoutString = resources.GetString("cboCentroCosto_DesignTimeLayout.LayoutString")
      Me.cboCentroCosto.DesignTimeLayout = cboCentroCosto_DesignTimeLayout
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(88, 12)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedIndex = -1
      Me.cboCentroCosto.SelectedItem = Nothing
      Me.cboCentroCosto.Size = New System.Drawing.Size(228, 20)
      Me.cboCentroCosto.TabIndex = 233
      Me.cboCentroCosto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboCentroCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(4, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(80, 16)
      Me.Label1.TabIndex = 234
      Me.Label1.Text = "Centro Costo"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.chkIncluirPlanAdd)
      Me.UiGroupBox1.Controls.Add(Me.chkConsolidar)
      Me.UiGroupBox1.Controls.Add(Me.chkTotalizar)
      Me.UiGroupBox1.Controls.Add(Me.grbFac)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(616, 351)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(204, 80)
      Me.UiGroupBox1.TabIndex = 4
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkIncluirPlanAdd
      '
      Me.chkIncluirPlanAdd.BackColor = System.Drawing.Color.Transparent
      Me.chkIncluirPlanAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkIncluirPlanAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkIncluirPlanAdd.Location = New System.Drawing.Point(4, 60)
      Me.chkIncluirPlanAdd.Name = "chkIncluirPlanAdd"
      Me.chkIncluirPlanAdd.Size = New System.Drawing.Size(192, 20)
      Me.chkIncluirPlanAdd.TabIndex = 21
      Me.chkIncluirPlanAdd.Text = "Incluir Analíticos Adicionales"
      Me.chkIncluirPlanAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkConsolidar
      '
      Me.chkConsolidar.BackColor = System.Drawing.Color.Transparent
      Me.chkConsolidar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkConsolidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkConsolidar.Location = New System.Drawing.Point(4, 12)
      Me.chkConsolidar.Name = "chkConsolidar"
      Me.chkConsolidar.Size = New System.Drawing.Size(192, 16)
      Me.chkConsolidar.TabIndex = 1
      Me.chkConsolidar.Text = "Consolidar Empresas"
      Me.chkConsolidar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkTotalizar
      '
      Me.chkTotalizar.BackColor = System.Drawing.Color.Transparent
      Me.chkTotalizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkTotalizar.Enabled = False
      Me.chkTotalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkTotalizar.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkTotalizar.Location = New System.Drawing.Point(5, 36)
      Me.chkTotalizar.Name = "chkTotalizar"
      Me.chkTotalizar.Size = New System.Drawing.Size(191, 16)
      Me.chkTotalizar.TabIndex = 2
      Me.chkTotalizar.Text = "Totalizar Cuentas"
      Me.chkTotalizar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grbFac
      '
      Me.grbFac.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbFac.Controls.Add(Me.optConFac)
      Me.grbFac.Controls.Add(Me.optSinFac)
      Me.grbFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbFac.Location = New System.Drawing.Point(36, 40)
      Me.grbFac.Name = "grbFac"
      Me.grbFac.Size = New System.Drawing.Size(84, 32)
      Me.grbFac.TabIndex = 20
      Me.grbFac.Visible = False
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
      Me.optConFac.TabIndex = 12
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
      Me.optSinFac.TabIndex = 11
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
      ExplorerBarGroup3.Container = True
      ExplorerBarGroup3.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup3.ContainerHeight = 312
      ExplorerBarGroup3.Expandable = False
      ExplorerBarGroup3.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup3})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 4)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(819, 344)
      Me.ebrMain.TabIndex = 4
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.dtpFechaFin)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 352)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(188, 79)
      Me.grpMain.TabIndex = 1
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dtpFechaFin
      '
      Me.dtpFechaFin.CustomFormat = "dd/MM"
      Me.dtpFechaFin.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaFin.DropDownCalendar.Name = ""
      Me.dtpFechaFin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaFin.Location = New System.Drawing.Point(64, 12)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(116, 20)
      Me.dtpFechaFin.TabIndex = 1
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 16)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(44, 16)
      Me.Label4.TabIndex = 153
      Me.Label4.Text = "Al"
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(64, 36)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(116, 20)
      Me.cboMoneda.TabIndex = 2
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(5, 40)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(52, 15)
      Me.Label5.TabIndex = 161
      Me.Label5.Text = "Moneda"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.dudNivel)
      Me.UiGroupBox2.Controls.Add(Me.Label2)
      Me.UiGroupBox2.Controls.Add(Me.Label7)
      Me.UiGroupBox2.Controls.Add(Me.cboTipoAsiento)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(200, 392)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(412, 36)
      Me.UiGroupBox2.TabIndex = 3
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dudNivel
      '
      Me.dudNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudNivel.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudNivel.Location = New System.Drawing.Point(372, 12)
      Me.dudNivel.Maximum = 10
      Me.dudNivel.Minimum = 1
      Me.dudNivel.Name = "dudNivel"
      Me.dudNivel.Size = New System.Drawing.Size(32, 20)
      Me.dudNivel.TabIndex = 3
      Me.dudNivel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudNivel.Value = 5
      Me.dudNivel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(324, 16)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(44, 16)
      Me.Label2.TabIndex = 232
      Me.Label2.Text = "Nivel"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(4, 16)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(79, 16)
      Me.Label7.TabIndex = 230
      Me.Label7.Text = "Tipo Asiento"
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
      Me.cboTipoAsiento.Location = New System.Drawing.Point(87, 12)
      Me.cboTipoAsiento.Name = "cboTipoAsiento"
      Me.cboTipoAsiento.SaveSettings = False
      Me.cboTipoAsiento.Size = New System.Drawing.Size(229, 20)
      Me.cboTipoAsiento.TabIndex = 1
      Me.cboTipoAsiento.ValuesDataMember = Nothing
      Me.cboTipoAsiento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.ilsMain.Images.SetKeyName(6, "server04.png")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.CheckTrue, Me.CheckFalse, Me.ViewAll2, Me.Exit2, Me.Connect})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("3585ee71-ff14-4ac4-8752-5d6b7253e051")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Connect1, Me.Separator5, Me.Book1, Me.Separator1, Me.CheckTrue1, Me.Separator2, Me.CheckFalse1, Me.Separator3, Me.ViewAll1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(448, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Connect1
      '
      Me.Connect1.Key = "Connect"
      Me.Connect1.Name = "Connect1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.ToolTipText = "Libro Mayor"
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
      Me.Book.Text = "Generar Balances"
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
      'ViewAll2
      '
      Me.ViewAll2.ImageIndex = 3
      Me.ViewAll2.Key = "ViewAll"
      Me.ViewAll2.Name = "ViewAll2"
      Me.ViewAll2.Text = "Ver Todos"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Connect
      '
      Me.Connect.ImageIndex = 6
      Me.Connect.Key = "Connect"
      Me.Connect.Name = "Connect"
      Me.Connect.Text = "Adicionar Base de Datos"
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
      Me.TopRebar1.Size = New System.Drawing.Size(827, 28)
      '
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOrigen})
      '
      'mnuOrigen
      '
      Me.mnuOrigen.Index = 0
      Me.mnuOrigen.Text = "Definir como Origen"
      '
      'frmBalanceComparativoFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(827, 459)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmBalanceComparativoFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Criterios Balance Comparativo"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpOrigen, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpOrigen.ResumeLayout(False)
      Me.grpOrigen.PerformLayout()
      CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbFac.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
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
         Case "Connect"
            Call frmDataBaseOrgLoad()

         Case "Book"
            Call frmConsolidarLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmBalanceComparativoFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmBalanceComparativoFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call ComboLoad()
      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call ClearMemory()
      Call DeshabilitarCentroCosto()

      Me.Cursor = oCursor
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboTipoAsientoLoad()
   End Sub

#Region " ComboLoads "
   Private Sub cboCentroCostoLoad(ByVal lngEmpresaId As Long, ByVal strConnectString As String)
      Dim oCentroCosto As New clsCentroCosto(strConnectString)

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.All
            .WhereFilter = clsCentroCosto.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = lngEmpresaId
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
                  .DropDownList.Columns("CentroCostoDes").Width = 205

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

               'oItem = New clsListItem(3, "De Cuenta")
               'cboMoneda.Items.Add(oItem)

               oItem = New clsListItem(4, "Ambas")
               cboMoneda.Items.Add(oItem)
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

#Region "GridCheck"

   Private Function ValidarGestionesEmpresas() As Boolean
      Dim oGestion As New clsGestion(moDataTableEmpresas.Rows.Item(0)("ConnectString"))
      ValidarGestionesEmpresas = True

      With oGestion
         .GestionId = moDataTableEmpresas.Rows.Item(0)("GestionId")

         If .FindByPK Then
            For i = 1 To moDataTableEmpresas.Rows.Count - 1
               Dim oRow = moDataTableEmpresas.Rows(i)
               Dim oGestionEmpresa As New clsGestion(oRow("ConnectString"))
               oGestionEmpresa.GestionId = ToLong(oRow("GestionId"))

               If oGestionEmpresa.FindByPK Then
                  If ToDate2(oGestionEmpresa.FechaIni).Day <> ToDate2(oGestion.FechaIni).Day Or ToDate2(oGestionEmpresa.FechaIni).Month <> ToDate2(oGestion.FechaIni).Month _
                  Or ToDate2(oGestionEmpresa.FechaFin).Day <> ToDate2(oGestion.FechaFin).Day Or ToDate2(oGestionEmpresa.FechaFin).Month <> ToDate2(oGestion.FechaFin).Month _
                  Or ToDate2(oGestionEmpresa.FechaFin).Year - ToDate2(oGestionEmpresa.FechaIni).Year <> ToDate2(oGestion.FechaFin).Year - ToDate2(oGestion.FechaIni).Year Then
                     ValidarGestionesEmpresas = False
                     moDataTableError.Rows.Add(1, "", "Intervalos de Gestiones no coincide", _
                                               oRow("EmpresaId"), oRow("EmpresaDes"), oRow("GestionId"), oRow("Gestion"), _
                                               ToDateDMY(oGestionEmpresa.FechaIni) & " - " & ToDateDMY(oGestionEmpresa.FechaFin) & " <> " & _
                                               ToDateDMY(oGestion.FechaIni) & " - " & ToDateDMY(oGestion.FechaFin), _
                                               moDataTableEmpresas.Rows.Item(0)("EmpresaId"), moDataTableEmpresas.Rows.Item(0)("EmpresaDes"), moDataTableEmpresas.Rows.Item(0)("GestionId"), moDataTableEmpresas.Rows.Item(0)("Gestion"))
                  End If
               End If
            Next
         End If
      End With
   End Function

   Private Function ValidarPlandeCuentas() As Boolean
      Dim odtPlanesCuentas As New DataTable
      Try  'Agrupamos todos los planes de cuenta en un datatable junto con un id que diferencia la empresa
         For Each oRow As DataRow In moDataTableEmpresas.Rows
            Dim oPlan As New clsPlan(oRow("ConnectString"))

            With oPlan
               .SelectFilter = clsPlan.SelectFilters.AllconID
               .WhereFilter = clsPlan.WhereFilters.ConsolidarEstadoResultado
               .OrderByFilter = clsPlan.OrderByFilters.TipoGrupoyPlanCta
               .EmpresaId = oRow("EmpresaId")
               .PlanDes = "(1, 2, 3)"
               .Orden = moDataTableEmpresas.Rows.IndexOf(oRow)  'id 

               If .Open Then
                  If .Orden = 0 Then
                     odtPlanesCuentas = .DataSet.Tables(.TableName).Clone
                  End If
                  odtPlanesCuentas.Merge(.DataSet.Tables(.TableName))
               End If
            End With
         Next
         '-----------------------------------------------************-----------------------------------------------------

         'For lngTipoGrupoId = 4 To 6
         '   Dim strGrupo As String = (From odatarow In odtPlanesCuentas Where odatarow.Field(Of Integer)("Id") = 0 _
         '                                     And odatarow.Field(Of Integer)("TipoGrupoId") = lngTipoGrupoId And odatarow.Field(Of Integer)("Nivel") = 1 Select odatarow.Field(Of String)("PlanCta")).First()
         '   For id = 0 To moDataTableEmpresas.Rows.Count - 1
         '      Dim planes As List(Of DataRow) = (From odatarow In odtPlanesCuentas Where odatarow.Field(Of Integer)("Id") = id _
         '                                  And odatarow.Field(Of Integer)("TipoGrupoId") = lngTipoGrupoId And Not odatarow.Field(Of String)("PlanCta").StartsWith(strGrupo) _
         '                                  Select odatarow).ToList()
         '      If planes.Count > 0 Then
         '         For Each oRow In planes
         '            moDataTableError.Rows.Add(1, "", oRow("PlanCta") & " - " & oRow("PlanDes") & " :: Código de Cuenta no coincide con el Grupo de Cuentas de Origen", _
         '                                      ToLong(moDataTableEmpresas.Rows.Item(id)("EmpresaId")), ToStr(moDataTableEmpresas.Rows.Item(id)("EmpresaDes")), ToLong(moDataTableEmpresas.Rows.Item(id)("GestionId")), ToLong(moDataTableEmpresas.Rows.Item(id)("Gestion")), _
         '                                      oRow("PlanCta") & " no coincide con la cuenta Padre " & strGrupo, _
         '                                      ToLong(moDataTableEmpresas.Rows.Item(0)("EmpresaId")), ToStr(moDataTableEmpresas.Rows.Item(0)("EmpresaDes")), ToLong(moDataTableEmpresas.Rows.Item(0)("GestionId")), ToLong(moDataTableEmpresas.Rows.Item(0)("Gestion")))
         '         Next
         '      End If
         '   Next
         'Next

         '------------------------------------------------************-----------------------------------------------------

         For lngEmpresa = 0 To moDataTableEmpresas.Rows.Count - 1
            'plantilla es la empresa con id 0 la primer empresa en la lista
            Dim plantilla As List(Of DataRow) = (From odatarow In odtPlanesCuentas Where odatarow.Field(Of Integer)("Id") = lngEmpresa Select odatarow).ToList()
            Dim strPlanCta As String = ""

            For Each orowCuenta In plantilla 'recorro las cuentas
               strPlanCta = orowCuenta("PlanCta") 'Cuenta a buscar de la lista de planes de la plantilla

               Dim Planes_Cuenta As List(Of DataRow) = (From odatarow In odtPlanesCuentas Where odatarow.Field(Of Integer)("Id") <> lngEmpresa And _
                                                        odatarow.Field(Of String)("PlanCta") = strPlanCta Select odatarow).ToList()
               'lista que contiene el mismo plancta por empresa

               If Planes_Cuenta.Count > 0 Then    ' verificar si la lista es mayor a 0 
                  For lngSubEmpresa = lngEmpresa + 1 To moDataTableEmpresas.Rows.Count - 1 ' recorrer por empresa y verificar q empresa tiene la cuenta y cual no
                     ' For Each oRowEmpresa In moDataTableEmpresas.Rows 
                     ' If lngEmpresa < lngSubEmpresa Then
                     Dim oRowEmpresa = moDataTableEmpresas.Rows.Item(lngSubEmpresa)
                     'no incluir a la empresa plantilla para este caso 
                     If Planes_Cuenta.Exists(Function(o) o.Item("Id") = moDataTableEmpresas.Rows.IndexOf(oRowEmpresa) And o.Item("EmpresaId") = oRowEmpresa("EmpresaId") _
                                                And o.Item("PlanCta") = strPlanCta) Then
                        Dim oRowCuentacompara As DataRow = Planes_Cuenta.Find(Function(o) o.Item("Id") = moDataTableEmpresas.Rows.IndexOf(oRowEmpresa) _
                                                                                   And o.Item("EmpresaId") = oRowEmpresa("EmpresaId") And o.Item("PlanCta") = strPlanCta)

                        '1. Verificar si es del mismo nivel
                        If Not orowCuenta("Nivel") = oRowCuentacompara("Nivel") Then
                           moDataTableError.Rows.Add(1, "", oRowCuentacompara.Item("PlanCta") & " - " & oRowCuentacompara.Item("PlanDes") & _
                                                     " :: Cuenta Inválida Nivel es Diferente", oRowEmpresa("EmpresaId"), oRowEmpresa("EmpresaDes"), oRowEmpresa("GestionId"), oRowEmpresa("Gestion"), _
                                             "Nivel : " & orowCuenta("Nivel") & " <> " & oRowCuentacompara("Nivel"), _
                                             moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaDes"), moDataTableEmpresas.Rows.Item(lngEmpresa)("GestionId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("Gestion"))
                        End If
                        '2. Es Analitico
                        If Not orowCuenta("EsAna") = oRowCuentacompara("EsAna") Then
                           moDataTableError.Rows.Add(1, "", oRowCuentacompara.Item("PlanCta") & " - " & oRowCuentacompara.Item("PlanDes") & _
                                                     " :: Cuenta Inválida Nivel Analítico es Diferente", oRowEmpresa("EmpresaId"), oRowEmpresa("EmpresaDes"), oRowEmpresa("GestionId"), oRowEmpresa("Gestion"), _
                                             If(oRowCuentacompara("EsAna"), "Es Análitico <> No es Análitico", "No es Análitico <> Es Análitico"), _
                                             moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaDes"), moDataTableEmpresas.Rows.Item(lngEmpresa)("GestionId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("Gestion"))
                        End If
                        '3. MonedaId
                        If Not orowCuenta("MonedaId") = oRowCuentacompara("MonedaId") Then
                           moDataTableError.Rows.Add(2, "", oRowCuentacompara.Item("PlanCta") & " - " & oRowCuentacompara.Item("PlanDes") & _
                                                     " :: Moneda de Cuenta Diferente", oRowEmpresa("EmpresaId"), oRowEmpresa("EmpresaDes"), oRowEmpresa("GestionId"), oRowEmpresa("Gestion"), _
                             oRowCuentacompara("MonedaDes") & " <> " & orowCuenta("MonedaDes"), _
                             moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaDes"), moDataTableEmpresas.Rows.Item(lngEmpresa)("GestionId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("Gestion"))
                        End If

                        '3. TipoPlanId
                        If Not orowCuenta("TipoPlanId") = oRowCuentacompara("TipoPlanId") Then
                           moDataTableError.Rows.Add(2, "", oRowCuentacompara.Item("PlanCta") & " - " & oRowCuentacompara.Item("PlanDes") & _
                                                     " :: Tipo de Cuenta Diferente", oRowEmpresa("EmpresaId"), oRowEmpresa("EmpresaDes"), oRowEmpresa("GestionId"), oRowEmpresa("Gestion"), _
                                                     oRowCuentacompara("TipoPlanDes") & " <> " & orowCuenta("TipoPlanDes"), _
                           moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaDes"), moDataTableEmpresas.Rows.Item(lngEmpresa)("GestionId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("Gestion"))
                        End If

                        '4. SucCCOId
                        If Not orowCuenta("SucCCOId") = oRowCuentacompara("SucCCOId") Then
                           moDataTableError.Rows.Add(2, "", oRowCuentacompara.Item("PlanCta") & " - " & oRowCuentacompara.Item("PlanDes") & _
                                                     " :: Sucursal/CCO Diferente", oRowEmpresa("EmpresaId"), oRowEmpresa("EmpresaDes"), oRowEmpresa("GestionId"), oRowEmpresa("Gestion"), _
                            oRowCuentacompara("SucCCODes") & " <> " & orowCuenta("SucCCODes"), _
moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaDes"), moDataTableEmpresas.Rows.Item(lngEmpresa)("GestionId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("Gestion"))
                        End If

                        '5. TieneAnaAdd
                        If Not orowCuenta("TieneAnaAdd") = oRowCuentacompara("TieneAnaAdd") Then
                           moDataTableError.Rows.Add(2, "", oRowCuentacompara.Item("PlanCta") & " - " & oRowCuentacompara.Item("PlanDes") & _
                                                     " :: Analíticos Adicionales Diferente", oRowEmpresa("EmpresaId"), oRowEmpresa("EmpresaDes"), oRowEmpresa("GestionId"), oRowEmpresa("Gestion"), _
                                                     If(oRowCuentacompara("TieneAnaAdd"), "Permite Analíticos Adicionales <> No Permite Analíticos Adicionales", "No Permite Analíticos Adicionales <> Permite Analíticos Adicionales"), _
                                                     moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaDes"), moDataTableEmpresas.Rows.Item(lngEmpresa)("GestionId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("Gestion"))
                        End If

                        '6. PlanDes
                        If Not orowCuenta("PlanDes") = oRowCuentacompara("PlanDes") Then
                           moDataTableError.Rows.Add(2, "", oRowCuentacompara.Item("PlanCta") & " - " & oRowCuentacompara.Item("PlanDes") & _
                                                     " :: Descripcion de Cuenta es Diferente", oRowEmpresa("EmpresaId"), oRowEmpresa("EmpresaDes"), oRowEmpresa("GestionId"), oRowEmpresa("Gestion"), _
                                                     orowCuenta("PlanDes") & " <> " & oRowCuentacompara("PlanDes"), _
                                                     moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("EmpresaDes"), moDataTableEmpresas.Rows.Item(lngEmpresa)("GestionId"), moDataTableEmpresas.Rows.Item(lngEmpresa)("Gestion"))
                        End If

                        ' Else
                        'moDataTableError.Rows.Add(1, "no existe esta cuenta en esta empresa", "")
                     End If
                     'Else
                     '   If lngSubEmpresa <> lngEmpresa Then

                     '   End If
                     'End If
                  Next
                  ' Else
                  ' moDataTableError.Rows.Add(1, "no existe esta cuenta en ninguna empresa", "")
               End If
            Next
         Next
         '-----------------------------------------------************-----------------------------------------------------

         ValidarPlandeCuentas = moDataTableError.Select("Prioridad = 1").Length = 0
      Catch ex As Exception
         MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try

   End Function

   Private Function GridCheck() As Boolean
      GridCheck = True
      Try
         If Not ValidarGestionesEmpresas() Then
            GridCheck = False
            ' Throw New Exception("Verifique Reporte de Errores - Periodo de Gestion son diferentes")
         End If

         If Not ValidarPlandeCuentas() Then
            GridCheck = False
            ' Throw New Exception("Verifique Reporte de Errores - Existen Diferencias no válidas en Plan de Cuentas")
         End If
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

#End Region

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moPlan = New clsPlan(clsAppInfo.ConnectString)

      If GestionFecha(clsAppInfo.GestionId, mstrFechaIni, mstrFechaFin) Then
         dtpFechaFin.Value = mstrFechaFin
      End If

      dtpFechaFin.MaxDate = mstrFechaFin
      dtpFechaFin.MinDate = mstrFechaIni

      dtpFechaFin.Value = Date.Now

      cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
      cboTipoAsiento.DropDownList.GetRows(0).IsChecked = True
      cboTipoAsiento.Text = cboTipoAsiento.DropDownList.GetRows(0).Cells("TipoAsientoDes").Value
   End Sub

   Private Sub frmConsolidarLoad()
      Dim oLista As New Queue
      Dim oListaTipoAsiento As New Queue

      moDataTableEmpresas.Rows.Clear()
      moDataTableError.Rows.Clear()

      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) <> 0 Then
         If grdMain.GetCheckedRows.Length > 0 Then
            If moDataTable.Select("Origen = 1").Length > 0 Then
               For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  If ToLong(oRow.Cells("Origen").Value) = 1 Then
                     Dim oDataRow = moDataTableEmpresas.NewRow()
                     oDataRow("ConnectString") = oRow.Cells("ConnectString").Value
                     oDataRow("EmpresaId") = oRow.Cells("EmpresaId").Value
                     oDataRow("EmpresaDes") = oRow.Cells("EmpresaDes").Value
                     oDataRow("GestionId") = oRow.Cells("GestionId").Value
                     oDataRow("Gestion") = oRow.Cells("Gestion").Value
                     moDataTableEmpresas.Rows.InsertAt(oDataRow, 0)
                  Else
                     moDataTableEmpresas.Rows.Add(oRow.Cells("ConnectString").Value, oRow.Cells("EmpresaId").Value, oRow.Cells("EmpresaDes").Value, oRow.Cells("GestionId").Value, _
                  oRow.Cells("Gestion").Value)
                  End If
               Next

               For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetCheckedRows
                  oListaTipoAsiento.Enqueue(oRow.Cells("TipoAsientoId").Value)
               Next

               If oListaTipoAsiento.Count Then
                  If GridCheck() Then
                     If chkConsolidar.Checked Then

                        Dim frm As New frmBalanceConsolidado
                        With frm
                           .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                           .FechaIni = dtpFechaFin.MinDate
                           .FechaFin = dtpFechaFin.Value
                           .Nivel = ToLong(dudNivel.Value)
                           .Totalizar = ToBoolean(chkTotalizar.Checked)
                           .SinFac = ToBoolean(optSinFac.Checked)
                           .ConFac = ToBoolean(optConFac.Checked)
                           .ListaTipoAsiento = oListaTipoAsiento
                           .Consolidar = ToBoolean(chkConsolidar.Checked)
                           .IncluirPlanAdd = ToBoolean(chkIncluirPlanAdd.Checked)
                           .ListaEmpresas = moDataTableEmpresas
                           .ListaErrores = moDataTableError
                           If ToLong(ListPosition(cboCentroCosto)) > 0 Then
                              .CentroCostoCod = ToStr(cboCentroCosto.DropDownList.GetValue("CentroCostoCod"))
                           End If
                           .CentroCostoDes = ToStr(cboCentroCosto.DropDownList.GetValue("CentroCostoDes"))
                           .MdiParent = Me.MdiParent
                           .Show()

                           Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & " " & Me.ToString)
                        End With

                     Else
                        Dim frm As New frmBalanceComparativo
                        With frm
                           .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                           .FechaIni = dtpFechaFin.MinDate
                           .FechaFin = dtpFechaFin.Value
                           .Nivel = ToLong(dudNivel.Value)
                           .SinFac = ToBoolean(optSinFac.Checked)
                           .ConFac = ToBoolean(optConFac.Checked)
                           .ListaTipoAsiento = oListaTipoAsiento
                           .Consolidar = ToBoolean(chkConsolidar.Checked)
                           .IncluirPlanAdd = ToBoolean(chkIncluirPlanAdd.Checked)
                           .ListaEmpresas = moDataTableEmpresas
                           .ListaErrores = moDataTableError
                           If ToLong(ListPosition(cboCentroCosto)) > 0 Then
                              .CentroCostoCod = ToStr(cboCentroCosto.DropDownList.GetValue("CentroCostoCod"))
                           End If
                           .CentroCostoDes = ToStr(cboCentroCosto.DropDownList.GetValue("CentroCostoDes"))
                           .MdiParent = Me.MdiParent
                           .Show()

                           Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & " " & Me.ToString)
                        End With
                     End If
                  End If

                  If moDataTableError.Rows.Count > 0 Then
                     Dim frm As New frmPlanCuentaError
                     If moDataTableError.Select("Prioridad = 1").Length > 0 Then
                        frm.DataTableObj = moDataTableError.Select("Prioridad = 1").CopyToDataTable()
                     Else
                        frm.DataTableObj = moDataTableError
                     End If
                     frm.MdiParent = Me.MdiParent
                     frm.Show()
                  End If

               Else
                  MessageBox.Show("Debe Seleccionar al Menos un Tipo de Asiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Debe Seleccionar una Empresa como Origen de Plan de Cuentas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar la Moneda", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Function frmDataBaseOrgLoad() As Boolean
      Dim frm As New frmDataBaseOrg

      frmDataBaseOrgLoad = False

      With frm
         .ShowDialog()

         If .Changed Then
            mstrConnectStringOrg = .ConnectStringOrg
            mstrDataBaseOrg = .DataBaseOrg
            frmDataBaseOrgLoad = True
            Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.CONSULTA, frm.Text & " " & .ConnectStringOrg & "-" & .DataBaseOrg)
            Call CargarEmpresas()
         End If

         frm.Dispose()
      End With
   End Function

   Private Sub CargarEmpresas()
      Dim oEmpresa As New clsEmpresa(mstrConnectStringOrg)

      Try
         With oEmpresa
            .SelectFilter = clsEmpresa.SelectFilters.EmpresaGestion
            .WhereFilter = clsEmpresa.WhereFilters.EmpresaGestion
            .OrderByFilter = clsEmpresa.OrderByFilters.EmpresaGestion

            If .Open Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  Dim oDataRow = moDataTable.NewRow
                  oDataRow("Sel") = False
                  oDataRow("DataBase") = mstrDataBaseOrg
                  oDataRow("EmpresaId") = oRow("EmpresaId")
                  oDataRow("EmpresaDes") = oRow("EmpresaDes")
                  oDataRow("GestionId") = oRow("GestionId")
                  oDataRow("Gestion") = oRow("Gestion")
                  oDataRow("ConnectString") = mstrConnectStringOrg
                  moDataTable.Rows.Add(oDataRow)
               Next
            End If
         End With
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub frmBalanceComparativoFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmConsolidarLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmBalanceComparativoFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
   End Sub

#Region " Dataset "

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add("Tabla")

      moDataTable.Columns.Add("Sel", Type.GetType("System.String"))
      moDataTable.Columns.Add("DataBase", Type.GetType("System.String"))
      moDataTable.Columns.Add("EmpresaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EmpresaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("GestionId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Gestion", Type.GetType("System.String"))
      moDataTable.Columns.Add("ConnectString", Type.GetType("System.String"))
      moDataTable.Columns.Add("Origen", Type.GetType("System.Int32"))

      moDataTableEmpresas = New DataTable()

      moDataTableEmpresas.Columns.Add("ConnectString", Type.GetType("System.String"))
      moDataTableEmpresas.Columns.Add("EmpresaId", Type.GetType("System.Int32"))
      moDataTableEmpresas.Columns.Add("EmpresaDes", Type.GetType("System.String"))
      moDataTableEmpresas.Columns.Add("GestionId", Type.GetType("System.Int32"))
      moDataTableEmpresas.Columns.Add("Gestion", Type.GetType("System.String"))

      moDataTableError = New DataTable()
      moDataTableError.Columns.Add("Prioridad", Type.GetType("System.Int32"))
      moDataTableError.Columns.Add("Img", Type.GetType("System.String"))
      ' moDataTableError.Columns.Add("PlanId", Type.GetType("System.Int32"))
      ' moDataTableError.Columns.Add("PlanDes", Type.GetType("System.String"))
      '  moDataTableError.Columns.Add("Error", Type.GetType("System.String"))
      moDataTableError.Columns.Add("Mensaje", Type.GetType("System.String"))
      moDataTableError.Columns.Add("EmpresaIdOri", Type.GetType("System.Int32"))
      moDataTableError.Columns.Add("EmpresaDesOri", Type.GetType("System.String"))
      moDataTableError.Columns.Add("GestionIdOri", Type.GetType("System.Int32"))
      moDataTableError.Columns.Add("GestionOri", Type.GetType("System.String"))
      moDataTableError.Columns.Add("Diferente", Type.GetType("System.String"))
      moDataTableError.Columns.Add("EmpresaIdDes", Type.GetType("System.Int32"))
      moDataTableError.Columns.Add("EmpresaDesDes", Type.GetType("System.String"))
      moDataTableError.Columns.Add("GestionIdDes", Type.GetType("System.Int32"))
      moDataTableError.Columns.Add("GestionDes", Type.GetType("System.String"))


   End Sub

#Region " Metodo-LibroMayor "
   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Origen"), Janus.Windows.GridEX.ConditionOperator.Equal, 1)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      fc.FormatStyle.BackColor = Color.Cyan
      grdMain.RootTable.FormatConditions.Add(fc)

      '   fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("TieneAnaAdd"), Janus.Windows.GridEX.ConditionOperator.Equal, False)
      '   fc.FormatStyle.ForeColor = Color.DarkGreen
      '   grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " Grid-LibroMayor "
   Private Sub grdMainInit()
      With grdMain

         .ContextMenu = mnuMain

         ebrMain.Groups(0).Text = "Seleccione las Empresas a Consolidar"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("ConnectString").Visible = False

         .RootTable.Columns("Origen").Visible = False

         .RootTable.Columns("DataBase").Caption = "Base de Datos"
         .RootTable.Columns("DataBase").Width = 300
         .RootTable.Columns("DataBase").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("DataBase").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("EmpresaDes").Caption = "Empresa"
         .RootTable.Columns("EmpresaDes").Width = 300
         .RootTable.Columns("EmpresaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EmpresaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("GestionId").Visible = False

         .RootTable.Columns("Gestion").Caption = "Gestion"
         .RootTable.Columns("Gestion").Width = 80
         .RootTable.Columns("Gestion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Gestion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub grdMainLoad()
      Try
         Call moDataSetInit()
         grdMain.DataSource = moDataTable
         grdMain.RetrieveStructure()

         Call grdMainInit()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
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

   'Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
   '   'If ToBoolean(chkFecha.Checked) = 0 Then
   '   '   dtpFechaFin.Value = Date.Now
   '   '   dtpFechaIni.Value = mstrFechaIni
   '   'End If

   '   'dtpFechaIni.Enabled = chkFecha.Checked
   '   'dtpFechaFin.Enabled = chkFecha.Checked
   '   'chkSaldoGestion.Enabled = chkFecha.Checked
   '   'chkSaldoGestion.Checked = chkFecha.Checked
   'End Sub

   Private Sub mnuOrigen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrigen.Click
      If grdMain.GetRow.Selected Then
         If moDataTable.Select("Origen = 1").Length > 0 Then
            moDataTable.Select("Origen = 1").First.Item("Origen") = 0
         End If

         grdMain.SetValue("Origen", 1)
         grdMain.UpdateData()

         Call FechasGestionLoad(ToLong(grdMain.GetValue("GestionId")), ToStr(grdMain.GetValue("ConnectString")))
         Call HabilitarCentroCosto(ToLong(grdMain.GetValue("EmpresaId")), ToStr(grdMain.GetValue("ConnectString")))

         Call AddConditionalFormatting()
      End If
   End Sub

   Public Sub FechasGestionLoad(ByVal lngGestionId As Long, ByVal strConnectString As String)
      Dim oGestion As New clsGestion(strConnectString)

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               dtpFechaFin.MinDate = "01/01/1900"
               dtpFechaFin.MaxDate = "01/01/1900"
               'dtpFechaIni.MinDate = "01/01/1900"
               'dtpFechaIni.MaxDate = "01/01/1900"

               'dtpFechaIni.MaxDate = .FechaFin
               'dtpFechaIni.MinDate = .FechaIni
               dtpFechaFin.MaxDate = .FechaFin
               dtpFechaFin.MinDate = .FechaIni
               mstrFechaIni = .FechaIni
               mstrFechaFin = .FechaFin
               'dtpFechaIni.Value = .FechaIni
               dtpFechaFin.Value = Date.Now
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oGestion.Dispose()
      End Try
   End Sub

   Private Sub grdMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMain.MouseDown
      If e.Button = MouseButtons.Right Then
         If grdMain.GetRow.Selected Then
            mnuOrigen.Visible = grdMain.GetRow.IsChecked
         End If
      End If
   End Sub

   Private Sub grdMain_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdMain.RowCheckStateChanged
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            If moDataTable.Select("Origen = 1").Length > 0 Then
               moDataTable.Select("Origen = 1").First.Item("Origen") = 0
               Call DeshabilitarCentroCosto()
            End If
         End If
      ElseIf e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.RowChange Then
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            If ToLong(grdMain.GetValue("Origen")) = 1 Then
               grdMain.SetValue("Origen", 0)
               grdMain.UpdateData()
               Call DeshabilitarCentroCosto()
            End If
         End If
      End If
   End Sub

   Private Sub chkConsolidar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConsolidar.CheckedChanged
      chkTotalizar.Enabled = chkConsolidar.Checked
      If chkConsolidar.Checked Then
         chkTotalizar.Checked = chkConsolidar.Checked
      End If
   End Sub

   Public Overrides Function ToString() As String
      Dim strEmpresas As String
      For Each oRow In moDataTableEmpresas.Rows
         strEmpresas &= oRow("EmpresaDes").ToString & "-" & oRow("Gestion").ToString & "; "
      Next
      Return "Al " & dtpFechaFin.Text & "; Tipo Asiento: " & cboTipoAsiento.Text & "; Moneda: " & cboMoneda.Text & "; Nivel: " & dudNivel.Text & "; Centro Costo: " & cboCentroCosto.Text & "; Consolidar Empresas: " & If(chkConsolidar.Checked, "Sí", "No") & "; Totalizar Cuentas: " & If(chkTotalizar.Checked, "Sí", "No") & "; Empresas:" & strEmpresas
   End Function

   Private Sub HabilitarCentroCosto(ByVal lngEmpresaId As Long, ByVal strConnectString As String)
      grpOrigen.Enabled = True
      Call cboCentroCostoLoad(lngEmpresaId, strConnectString)
   End Sub

   Private Sub DeshabilitarCentroCosto()
      If grpOrigen.Enabled Then
         grpOrigen.Enabled = False
         cboCentroCosto.Value = Nothing
         cboCentroCosto.Text = ""
      End If
   End Sub
End Class
