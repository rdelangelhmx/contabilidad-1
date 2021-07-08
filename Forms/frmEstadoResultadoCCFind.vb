Public Class frmEstadoResultadoCCFind
   Inherits System.Windows.Forms.Form
   Private mlngIndex As Long
   Private moCentroCosto As clsCentroCosto
   Private mlngEmpresaId As Long
   Private moDataTable As DataTable

   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents dudMostrarCC As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents Label1 As System.Windows.Forms.Label
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
   Friend WithEvents chkIncluirPlanAdd As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents dudNivel As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents grbFac As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optConFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents cboTipoAsiento As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents optSinFac As Janus.Windows.EditControls.UIRadioButton
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents chkTotalizar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkSaldoGestion As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
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
      Dim ExplorerBarGroup4 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoResultadoCCFind))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkIncluirPlanAdd = New Janus.Windows.EditControls.UICheckBox
      Me.chkTotalizar = New Janus.Windows.EditControls.UICheckBox
      Me.chkSaldoGestion = New Janus.Windows.EditControls.UICheckBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.dudMostrarCC = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboTipoAsiento = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.dudNivel = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.chkFecha = New Janus.Windows.EditControls.UICheckBox
      Me.grbFac = New Janus.Windows.EditControls.UIGroupBox
      Me.optConFac = New Janus.Windows.EditControls.UIRadioButton
      Me.optSinFac = New Janus.Windows.EditControls.UIRadioButton
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbFac.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(914, 287)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdMain
      '
      Me.grdMain.AllowCardSizing = False
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
      Me.grdMain.Size = New System.Drawing.Size(914, 287)
      Me.grdMain.TabIndex = 18
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.UiGroupBox3)
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.chkFecha)
      Me.bcgMain.Controls.Add(Me.grbFac)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(937, 424)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.chkIncluirPlanAdd)
      Me.UiGroupBox3.Controls.Add(Me.chkTotalizar)
      Me.UiGroupBox3.Controls.Add(Me.chkSaldoGestion)
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(532, 328)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(212, 92)
      Me.UiGroupBox3.TabIndex = 2
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkIncluirPlanAdd
      '
      Me.chkIncluirPlanAdd.BackColor = System.Drawing.Color.Transparent
      Me.chkIncluirPlanAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkIncluirPlanAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkIncluirPlanAdd.Location = New System.Drawing.Point(12, 36)
      Me.chkIncluirPlanAdd.Name = "chkIncluirPlanAdd"
      Me.chkIncluirPlanAdd.Size = New System.Drawing.Size(192, 16)
      Me.chkIncluirPlanAdd.TabIndex = 13
      Me.chkIncluirPlanAdd.Text = "Incluir Analíticos Adicionales"
      Me.chkIncluirPlanAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkTotalizar
      '
      Me.chkTotalizar.BackColor = System.Drawing.Color.Transparent
      Me.chkTotalizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkTotalizar.Checked = True
      Me.chkTotalizar.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkTotalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkTotalizar.Location = New System.Drawing.Point(72, 12)
      Me.chkTotalizar.Name = "chkTotalizar"
      Me.chkTotalizar.Size = New System.Drawing.Size(132, 16)
      Me.chkTotalizar.TabIndex = 12
      Me.chkTotalizar.Text = "Totalizar Cuentas"
      Me.chkTotalizar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkSaldoGestion
      '
      Me.chkSaldoGestion.BackColor = System.Drawing.Color.Transparent
      Me.chkSaldoGestion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSaldoGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSaldoGestion.Location = New System.Drawing.Point(12, 60)
      Me.chkSaldoGestion.Name = "chkSaldoGestion"
      Me.chkSaldoGestion.Size = New System.Drawing.Size(192, 16)
      Me.chkSaldoGestion.TabIndex = 14
      Me.chkSaldoGestion.Text = "Incluir Saldos de la Gestión"
      Me.chkSaldoGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup4.Container = True
      ExplorerBarGroup4.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup4.ContainerHeight = 288
      ExplorerBarGroup4.Expandable = False
      ExplorerBarGroup4.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup4})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 4)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(930, 320)
      Me.ebrMain.TabIndex = 18
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.dudMostrarCC)
      Me.UiGroupBox1.Controls.Add(Me.Label1)
      Me.UiGroupBox1.Controls.Add(Me.cboTipoAsiento)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.dudNivel)
      Me.UiGroupBox1.Controls.Add(Me.Label2)
      Me.UiGroupBox1.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(200, 328)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(328, 92)
      Me.UiGroupBox1.TabIndex = 1
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dudMostrarCC
      '
      Me.dudMostrarCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudMostrarCC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudMostrarCC.Location = New System.Drawing.Point(252, 40)
      Me.dudMostrarCC.Maximum = 25
      Me.dudMostrarCC.Minimum = 1
      Me.dudMostrarCC.Name = "dudMostrarCC"
      Me.dudMostrarCC.Size = New System.Drawing.Size(68, 20)
      Me.dudMostrarCC.TabIndex = 7
      Me.dudMostrarCC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudMostrarCC.Value = 5
      Me.dudMostrarCC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(4, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(244, 16)
      Me.Label1.TabIndex = 228
      Me.Label1.Text = "Mostrar Centro Costo por Columna . . . . . . . . ."
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
      Me.cboTipoAsiento.Location = New System.Drawing.Point(100, 64)
      Me.cboTipoAsiento.Name = "cboTipoAsiento"
      Me.cboTipoAsiento.SaveSettings = False
      Me.cboTipoAsiento.Size = New System.Drawing.Size(220, 20)
      Me.cboTipoAsiento.TabIndex = 8
      Me.cboTipoAsiento.ValuesDataMember = Nothing
      Me.cboTipoAsiento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(4, 68)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(96, 16)
      Me.Label7.TabIndex = 226
      Me.Label7.Text = "Tipo de Asiento"
      '
      'dudNivel
      '
      Me.dudNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudNivel.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudNivel.Location = New System.Drawing.Point(252, 16)
      Me.dudNivel.Maximum = 10
      Me.dudNivel.Minimum = 1
      Me.dudNivel.Name = "dudNivel"
      Me.dudNivel.Size = New System.Drawing.Size(68, 20)
      Me.dudNivel.TabIndex = 6
      Me.dudNivel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudNivel.Value = 5
      Me.dudNivel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(212, 20)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(36, 16)
      Me.Label2.TabIndex = 214
      Me.Label2.Text = "Nivel"
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(60, 16)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(96, 20)
      Me.cboMoneda.TabIndex = 5
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(4, 20)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(52, 16)
      Me.Label5.TabIndex = 161
      Me.Label5.Text = "Moneda"
      '
      'chkFecha
      '
      Me.chkFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFecha.Checked = True
      Me.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFecha.Location = New System.Drawing.Point(12, 328)
      Me.chkFecha.Name = "chkFecha"
      Me.chkFecha.Size = New System.Drawing.Size(112, 16)
      Me.chkFecha.TabIndex = 1
      Me.chkFecha.Text = "Habilitar Fechas"
      Me.chkFecha.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grbFac
      '
      Me.grbFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grbFac.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbFac.Controls.Add(Me.optConFac)
      Me.grbFac.Controls.Add(Me.optSinFac)
      Me.grbFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbFac.Location = New System.Drawing.Point(752, 372)
      Me.grbFac.Name = "grbFac"
      Me.grbFac.Size = New System.Drawing.Size(80, 32)
      Me.grbFac.TabIndex = 9
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
      Me.optConFac.TabIndex = 16
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
      Me.optSinFac.TabIndex = 15
      Me.optSinFac.TabStop = True
      Me.optSinFac.Text = "I"
      Me.optSinFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      Me.grpMain.Location = New System.Drawing.Point(8, 328)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(188, 92)
      Me.grpMain.TabIndex = 0
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
      Me.dtpFechaFin.Location = New System.Drawing.Point(56, 44)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaFin.TabIndex = 3
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
      Me.dtpFechaIni.Location = New System.Drawing.Point(56, 20)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaIni.TabIndex = 2
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("8efaf206-bebc-40a5-80e2-61079d3ec4c2")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator2, Me.Separator3, Me.Separator4, Me.Separator1, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(170, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Resultados"
      Me.Book1.ToolTipText = "Estado de Resultados"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Book
      '
      Me.Book.ImageIndex = 5
      Me.Book.Key = "Book"
      Me.Book.Name = "Book"
      Me.Book.Text = "Balance"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 1
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
      Me.TopRebar1.Size = New System.Drawing.Size(937, 28)
      '
      'frmEstadoResultadoCCFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(937, 452)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmEstadoResultadoCCFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Estado de Resultados Comparativo por Centros de Costo"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbFac.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
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
            Call frmEstadoResultadoCCLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmEstadoResultadoCCFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmEstadoResultadoCCFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
   End Sub

#Region " ComboLoads "
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

      moCentroCosto = New clsCentroCosto(clsAppInfo.ConnectString)

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
   End Sub

   Private Sub frmEstadoResultadoCCLoad()
      Dim oListaCentroCosto As New List(Of Long)
      Try
         If ListPosition(cboMoneda, cboMoneda.SelectedIndex) <> 0 Then
            Dim oListaTipoAsiento As New Queue
            For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetCheckedRows
               oListaTipoAsiento.Enqueue(oRow.Cells("TipoAsientoId").Value)
            Next

            For Each orow In grdMain.GetCheckedRows.OrderBy(Of Long)(Function(key) key.Cells("Orden").Value)
               oListaCentroCosto.Add(orow.Cells("CentroCostoId").Value)
            Next

            If oListaTipoAsiento.Count Then
               Dim frm As New frmEstadoResultadoCC

               With frm
                  .EmpresaId = mlngEmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                  .FechaIni = dtpFechaIni.Value
                  .FechaFin = dtpFechaFin.Value
                  .FechaIniGestion = dtpFechaIni.MinDate
                  .FechaFinGestion = dtpFechaFin.MaxDate
                  .Nivel = ToLong(dudNivel.Value)
                  .ListaCC = oListaCentroCosto
                  .IncluirPlanAdd = ToBoolean(chkIncluirPlanAdd.Checked)
                  .Totalizar = ToBoolean(chkTotalizar.Checked)
                  .SinFac = ToBoolean(optSinFac.Checked)
                  .ConFac = ToBoolean(optConFac.Checked)
                  .ListaTipoAsiento = oListaTipoAsiento
                  .IntervaloFecha = ToBoolean(chkFecha.Checked)
                  .SaldoGestion = ToBoolean(chkSaldoGestion.Checked)
                  .MostrarCC = ToLong(dudMostrarCC.Value)

                  .MdiParent = Me.MdiParent
                  .Show()

                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, Me.ToString)
               End With
            Else
               MessageBox.Show("Debe Seleccionar el Centro de Costo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar la Moneda", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

#Region " Grid Centro-Costo "

   Private Sub moDataSetInit()
      moDataTable = New DataTable
      moDataTable.Columns.Add("Sel", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Orden", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CentroCostoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CentroCostoCod", Type.GetType("System.String"))
      moDataTable.Columns.Add("CentroCostoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("EstadoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EstadoDes", Type.GetType("System.String"))
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Centros de Costo"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("Orden").Caption = "Orden"
         .RootTable.Columns("Orden").Width = 60
         .RootTable.Columns("Orden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Orden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CentroCostoId").Visible = False

         .RootTable.Columns("CentroCostoCod").Caption = "Código"
         .RootTable.Columns("CentroCostoCod").Width = 100
         .RootTable.Columns("CentroCostoCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CentroCostoCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CentroCostoCod").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("CentroCostoDes").Caption = "Descripción"
         .RootTable.Columns("CentroCostoDes").Width = 200
         .RootTable.Columns("CentroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CentroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CentroCostoDes").EditType = Janus.Windows.GridEX.EditType.NoEdit

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("EstadoDes").EditType = Janus.Windows.GridEX.EditType.NoEdit
      End With
   End Sub

   Private Sub grdMainLoad()
      Call moDataSetInit()

      Try
         With moCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.GridCheck
            .WhereFilter = clsCentroCosto.WhereFilters.Grid
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = mlngEmpresaId

            If .Open() Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRowShow(oRow))
               Next

               moDataTable.Rows.Add(GetRowShowCero)
            End If

            grdMain.DataSource = moDataTable.DefaultView
            grdMain.RetrieveStructure()
            Call grdMainInit()

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function GetRowShow(ByVal oDataRow As DataRow) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("Sel") = 0
      oRow("Orden") = 0
      oRow("CentroCostoId") = oDataRow("CentroCostoId")
      oRow("CentroCostoCod") = oDataRow("CentroCostoCod")
      oRow("CentroCostoDes") = oDataRow("CentroCostoDes")
      oRow("EstadoId") = oDataRow("EstadoId")
      oRow("EstadoDes") = oDataRow("EstadoDes")

      Return oRow
   End Function

   Private Function GetRowShowCero() As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("Sel") = 0
      oRow("Orden") = 0
      oRow("CentroCostoId") = 0
      oRow("CentroCostoCod") = "SD"
      oRow("CentroCostoDes") = "Sin Definir"
      oRow("EstadoId") = 0
      oRow("EstadoDes") = "Inactivo"

      Return oRow
   End Function

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

   Private Sub frmEstadoResultadoCCFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmEstadoResultadoCCLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmEstadoResultadoCCFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

#Region " Eventos "
   Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
      If ToBoolean(chkFecha.Checked) = 0 Then
         dtpFechaFin.Value = Date.Now
         dtpFechaIni.Value = mstrFechaIni
      End If

      dtpFechaIni.Enabled = chkFecha.Checked
      dtpFechaFin.Enabled = chkFecha.Checked

      chkSaldoGestion.Enabled = chkFecha.Checked
      chkSaldoGestion.Checked = False
   End Sub
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

   'Private Sub grdMainIndexar()
   '   Dim count As Long = 1
   '   Dim Index As Long = 1

   '   'If (boolMenorMayor) Then
   '   '   Index = grdMain.RowCount
   '   '   count = -1
   '   'End If
   '   Try
   '      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
   '         oRow.BeginEdit()

   '         oRow.Cells("Orden").Value = Index

   '         Index += count
   '         oRow.EndEdit()
   '      Next
   '   Catch ex As Exception
   '      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
   '   End Try
   'End Sub

   'Private Sub RemoveSorKeys()
   '   grdMain.RootTable.SortKeys.Clear()
   '   grdMain.Refetch()
   'End Sub

   'Private Function GetRowNewClonB(ByVal oDataRow As DataRow) As DataRow
   '   Dim oRow As DataRow
   '   oRow = moDataTable.NewRow

   '   oRow("Sel") = oDataRow("Sel")
   '   oRow("Orden") = oDataRow("Orden")
   '   oRow("CentroCostoId") = oDataRow("CentroCostoId")
   '   oRow("CentroCostoCod") = oDataRow("CentroCostoCod")
   '   oRow("CentroCostoDes") = oDataRow("CentroCostoDes")
   '   oRow("EstadoId") = oDataRow("EstadoId")
   '   oRow("EstadoDes") = oDataRow("EstadoDes")

   '   Return oRow
   'End Function

   'Private Sub UpLoad()
   '   'Call RemoveSorKeys()
   '   If grdMain.CurrentRow.Position = 0 Then
   '      Exit Sub
   '   End If
   '   Dim index = grdMain.CurrentRow.Position
   '   Dim aux = GetRowNewClonB(moDataTable.Rows.Item(index))

   '   Dim orden As Long = aux("Orden")
   '   aux("Orden") = moDataTable.Rows.Item(index - 1)("Orden")
   '   moDataTable.Rows.Item(index - 1)("Orden") = orden

   '   moDataTable.Rows.RemoveAt(index)
   '   moDataTable.Rows.InsertAt(aux, index - 1)
   '   grdMain.Refetch()
   '   grdMain.Row = index - 1
   'End Sub

   'Private Sub DownLoad()
   '   ' Call RemoveSorKeys()
   '   If grdMain.CurrentRow.Position = grdMain.RowCount - 1 Then
   '      Exit Sub
   '   End If
   '   Dim index = grdMain.CurrentRow.Position
   '   Dim aux = GetRowNewClonB(moDataTable.Rows.Item(index))

   '   Dim orden As Long = aux("Orden")
   '   aux("Orden") = moDataTable.Rows.Item(index + 1)("Orden")
   '   moDataTable.Rows.Item(index + 1)("Orden") = orden

   '   moDataTable.Rows.RemoveAt(index)
   '   moDataTable.Rows.InsertAt(aux, index + 1)
   '   grdMain.Refetch()
   '   grdMain.Row = index + 1
   'End Sub

   Private Sub grdMain_RowCheckStateChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs) Handles grdMain.RowCheckStateChanged
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            mlngIndex = 0
            For Each oRow In grdMain.GetRows
               oRow.BeginEdit()
               mlngIndex += 1
               oRow.Cells.Item("Orden").Value = mlngIndex
               oRow.EndEdit()
            Next
         ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            mlngIndex = 0
            For Each oRow In grdMain.GetRows
               oRow.BeginEdit()
               oRow.Cells.Item("Orden").Value = 0
               oRow.EndEdit()
            Next
         End If
      ElseIf e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.RowChange Then
         If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
            mlngIndex += 1
            grdMain.SetValue("Orden", mlngIndex)
         ElseIf e.CheckState = Janus.Windows.GridEX.RowCheckState.Unchecked Then
            mlngIndex -= 1
            grdMain.SetValue("Orden", 0)
         End If
      End If
   End Sub

   Private Sub grdMain_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdMain.UpdatingCell
      If e.Column.DataMember = "Orden" Then
         If ToLong(e.Value) < 1 Or ToLong(e.Value) > grdMain.GetRows.Count Then
            e.Value = 0
            grdMain.SetValue("Sel", False)
         ElseIf grdMain.GetValue("Sel") = False Then
            grdMain.SetValue("Sel", True)
         End If
      End If
   End Sub

   Public Overrides Function ToString() As String
      Dim strCentrosCosto As String = "C.C.: "
      For Each row In grdMain.GetCheckedRows
         strCentrosCosto &= ToStr(row.Cells("CentroCostoDes").Value) & ", "
      Next

      Return "Gestión: " & clsAppInfo.Gestion & If(chkFecha.Checked, "; Desde " & dtpFechaIni.Text & " Hasta " & dtpFechaFin.Text, "") & "; Moneda : " & cboMoneda.Text & "; Nivel: " & dudNivel.Text & "; Tipo Asiento: " & cboTipoAsiento.Text & "; Totalizar: " & If(chkTotalizar.Checked, "Sí", "No") & "; Incluir A.A.: " & If(chkIncluirPlanAdd.Checked, "Sí", "No") & "; Incluir Saldos: " & If(chkSaldoGestion.Checked, "Sí", "No") & "; " & strCentrosCosto
   End Function

End Class

