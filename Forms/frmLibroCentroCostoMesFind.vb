Public Class frmLibroCentroCostoMesFind
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan
   Private moCentroCosto As clsCentroCosto
   Private mlngEmpresaId As Long

   Private mboolShow As Boolean
   Private mboolSelected As Boolean
   Private mlngID As Long

   Private mboolMain As Boolean
   Friend WithEvents ebrMainBottom As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl1 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMainBottom As Janus.Windows.GridEX.GridEX
   Friend WithEvents ebrMainTop As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMainTop As Janus.Windows.GridEX.GridEX
   Friend WithEvents grbFac As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optConFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optSinFac As Janus.Windows.EditControls.UIRadioButton
   Private mboolCentroCosto As Boolean

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
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

      Call FormCenterChild(Me)

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
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
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
   Friend WithEvents chkOrdenarFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents grpFecha As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents chkSaldoAnterior As Janus.Windows.EditControls.UICheckBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroCentroCostoMesFind))
      Me.ExplorerBarContainerControl1 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMainBottom = New Janus.Windows.GridEX.GridEX
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMainTop = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grbFac = New Janus.Windows.EditControls.UIGroupBox
      Me.optConFac = New Janus.Windows.EditControls.UIRadioButton
      Me.optSinFac = New Janus.Windows.EditControls.UIRadioButton
      Me.ebrMainBottom = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.ebrMainTop = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkSaldoAnterior = New Janus.Windows.EditControls.UICheckBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.chkOrdenarFecha = New Janus.Windows.EditControls.UICheckBox
      Me.chkFecha = New Janus.Windows.EditControls.UICheckBox
      Me.grpFecha = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
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
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.CheckTrue = New Janus.Windows.UI.CommandBars.UICommand("CheckTrue")
      Me.CheckFalse = New Janus.Windows.UI.CommandBars.UICommand("CheckFalse")
      Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl1.SuspendLayout()
      CType(Me.grdMainBottom, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMainTop, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbFac.SuspendLayout()
      CType(Me.ebrMainBottom, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMainBottom.SuspendLayout()
      CType(Me.ebrMainTop, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMainTop.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.grpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpFecha.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl1
      '
      Me.ExplorerBarContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl1.Controls.Add(Me.grdMainBottom)
      Me.ExplorerBarContainerControl1.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl1.Name = "ExplorerBarContainerControl1"
      Me.ExplorerBarContainerControl1.Size = New System.Drawing.Size(728, 123)
      Me.ExplorerBarContainerControl1.TabIndex = 1
      '
      'grdMainBottom
      '
      Me.grdMainBottom.AllowCardSizing = False
      Me.grdMainBottom.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdMainBottom.AlternatingColors = True
      Me.grdMainBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdMainBottom.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdMainBottom.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdMainBottom.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdMainBottom.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdMainBottom.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdMainBottom.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdMainBottom.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdMainBottom.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdMainBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdMainBottom.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdMainBottom.GroupByBoxVisible = False
      Me.grdMainBottom.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdMainBottom.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdMainBottom.Location = New System.Drawing.Point(0, 0)
      Me.grdMainBottom.Name = "grdMainBottom"
      Me.grdMainBottom.RecordNavigator = True
      Me.grdMainBottom.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdMainBottom.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdMainBottom.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdMainBottom.Size = New System.Drawing.Size(728, 123)
      Me.grdMainBottom.TabIndex = 3
      Me.grdMainBottom.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMainBottom.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMainBottom.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMainBottom.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdMainTop)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 125)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdMainTop
      '
      Me.grdMainTop.AllowCardSizing = False
      Me.grdMainTop.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdMainTop.AlternatingColors = True
      Me.grdMainTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdMainTop.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdMainTop.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdMainTop.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdMainTop.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdMainTop.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdMainTop.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdMainTop.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdMainTop.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdMainTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdMainTop.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdMainTop.GroupByBoxVisible = False
      Me.grdMainTop.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdMainTop.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdMainTop.Location = New System.Drawing.Point(0, 0)
      Me.grdMainTop.Name = "grdMainTop"
      Me.grdMainTop.RecordNavigator = True
      Me.grdMainTop.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdMainTop.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdMainTop.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdMainTop.Size = New System.Drawing.Size(728, 125)
      Me.grdMainTop.TabIndex = 3
      Me.grdMainTop.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMainTop.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMainTop.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMainTop.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grbFac)
      Me.bcgMain.Controls.Add(Me.ebrMainBottom)
      Me.bcgMain.Controls.Add(Me.ebrMainTop)
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Controls.Add(Me.chkOrdenarFecha)
      Me.bcgMain.Controls.Add(Me.chkFecha)
      Me.bcgMain.Controls.Add(Me.grpFecha)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(752, 414)
      Me.bcgMain.TabIndex = 163
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grbFac
      '
      Me.grbFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grbFac.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbFac.Controls.Add(Me.optConFac)
      Me.grbFac.Controls.Add(Me.optSinFac)
      Me.grbFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbFac.Location = New System.Drawing.Point(392, 336)
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
      'ebrMainBottom
      '
      Me.ebrMainBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMainBottom.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMainBottom.Controls.Add(Me.ExplorerBarContainerControl1)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl1
      ExplorerBarGroup1.ContainerHeight = 124
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMainBottom.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMainBottom.GroupSeparation = 4
      Me.ebrMainBottom.Location = New System.Drawing.Point(4, 168)
      Me.ebrMainBottom.Name = "ebrMainBottom"
      Me.ebrMainBottom.Size = New System.Drawing.Size(744, 156)
      Me.ebrMainBottom.TabIndex = 11
      Me.ebrMainBottom.Text = "ExplorerBar2"
      Me.ebrMainBottom.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMainBottom.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMainBottom.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMainBottom.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'ebrMainTop
      '
      Me.ebrMainTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMainTop.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMainTop.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup2.Container = True
      ExplorerBarGroup2.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup2.ContainerHeight = 126
      ExplorerBarGroup2.Expandable = False
      ExplorerBarGroup2.Key = "Group1"
      Me.ebrMainTop.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup2})
      Me.ebrMainTop.GroupSeparation = 4
      Me.ebrMainTop.Location = New System.Drawing.Point(4, 6)
      Me.ebrMainTop.Name = "ebrMainTop"
      Me.ebrMainTop.Size = New System.Drawing.Size(744, 158)
      Me.ebrMainTop.TabIndex = 10
      Me.ebrMainTop.Text = "ExplorerBar2"
      Me.ebrMainTop.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMainTop.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMainTop.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMainTop.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.chkSaldoAnterior)
      Me.UiGroupBox2.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox2.Controls.Add(Me.Label5)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(196, 334)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(188, 72)
      Me.UiGroupBox2.TabIndex = 9
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkSaldoAnterior
      '
      Me.chkSaldoAnterior.BackColor = System.Drawing.Color.Transparent
      Me.chkSaldoAnterior.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSaldoAnterior.Enabled = False
      Me.chkSaldoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSaldoAnterior.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkSaldoAnterior.Location = New System.Drawing.Point(8, 48)
      Me.chkSaldoAnterior.Name = "chkSaldoAnterior"
      Me.chkSaldoAnterior.Size = New System.Drawing.Size(172, 16)
      Me.chkSaldoAnterior.TabIndex = 11
      Me.chkSaldoAnterior.Text = "Incluir Saldo Anterior"
      Me.chkSaldoAnterior.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(64, 20)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(116, 20)
      Me.cboMoneda.TabIndex = 10
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 24)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(52, 16)
      Me.Label5.TabIndex = 161
      Me.Label5.Text = "Moneda"
      '
      'chkOrdenarFecha
      '
      Me.chkOrdenarFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkOrdenarFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkOrdenarFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkOrdenarFecha.Checked = True
      Me.chkOrdenarFecha.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkOrdenarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkOrdenarFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkOrdenarFecha.Location = New System.Drawing.Point(136, 330)
      Me.chkOrdenarFecha.Name = "chkOrdenarFecha"
      Me.chkOrdenarFecha.Size = New System.Drawing.Size(44, 20)
      Me.chkOrdenarFecha.TabIndex = 5
      Me.chkOrdenarFecha.Text = "Ord."
      Me.chkOrdenarFecha.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkFecha
      '
      Me.chkFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFecha.Location = New System.Drawing.Point(16, 330)
      Me.chkFecha.Name = "chkFecha"
      Me.chkFecha.Size = New System.Drawing.Size(112, 20)
      Me.chkFecha.TabIndex = 4
      Me.chkFecha.Text = "Habilitar Fechas"
      Me.chkFecha.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grpFecha
      '
      Me.grpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grpFecha.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpFecha.Controls.Add(Me.dtpFechaFin)
      Me.grpFecha.Controls.Add(Me.dtpFechaIni)
      Me.grpFecha.Controls.Add(Me.Label3)
      Me.grpFecha.Controls.Add(Me.Label4)
      Me.grpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpFecha.Location = New System.Drawing.Point(8, 334)
      Me.grpFecha.Name = "grpFecha"
      Me.grpFecha.Size = New System.Drawing.Size(180, 72)
      Me.grpFecha.TabIndex = 6
      Me.grpFecha.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dtpFechaFin
      '
      Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaFin.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaFin.DropDownCalendar.FirstMonth = New Date(2008, 5, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.DropDownCalendar.Name = ""
      Me.dtpFechaFin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaFin.Enabled = False
      Me.dtpFechaFin.Location = New System.Drawing.Point(56, 44)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(116, 20)
      Me.dtpFechaFin.TabIndex = 8
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'dtpFechaIni
      '
      Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaIni.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaIni.DropDownCalendar.FirstMonth = New Date(2008, 5, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.DropDownCalendar.Name = ""
      Me.dtpFechaIni.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaIni.Enabled = False
      Me.dtpFechaIni.Location = New System.Drawing.Point(56, 20)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(116, 20)
      Me.dtpFechaIni.TabIndex = 7
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
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.CheckTrue, Me.CheckFalse, Me.ViewAll2, Me.Exit2})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.CheckTrue1, Me.Separator2, Me.CheckFalse1, Me.Separator3, Me.ViewAll1, Me.Separator4, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(260, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Movimiento"
      Me.Book1.ToolTipText = "Movimiento de Clientes"
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
      'frmLibroCentroCostoMesFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmLibroCentroCostoMesFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Criterios Movimiento Centros de Costos Comparativo"
      Me.ExplorerBarContainerControl1.ResumeLayout(False)
      CType(Me.grdMainBottom, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMainTop, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbFac.ResumeLayout(False)
      CType(Me.ebrMainBottom, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMainBottom.ResumeLayout(False)
      CType(Me.ebrMainTop, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMainTop.ResumeLayout(False)
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      CType(Me.grpFecha, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpFecha.ResumeLayout(False)
      Me.grpFecha.PerformLayout()
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
            Call frmKardexLoad()

         Case "ViewAll"
            cboMoneda.Select()

            If mboolMain Then
               Call grdMainTopDataViewAll()
            End If

            If mboolCentroCosto Then
               Call grdMainBottomDataViewAll()
            End If

         Case "CheckTrue"
            cboMoneda.Select()

            If mboolMain Then
               Call grdMainTopCheck(True)
            End If

            If mboolCentroCosto Then
               Call grdMainBottomCheck(True)
            End If

         Case "CheckFalse"
            cboMoneda.Select()

            If mboolMain Then
               Call grdMainTopCheck(False)
            End If

            If mboolCentroCosto Then
               Call grdMainBottomCheck(False)
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmLibroCentroCostoCompFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmLibroCentroCostoCompFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call ComboLoad()
      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainTopLoad()
      Call grdMainBottomLoad()
      Call ClearMemory()

      mboolSelected = False

      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainTopLoad()
      Try
         With moPlan
            .SelectFilter = clsPlan.SelectFilters.GridCheck
            .WhereFilter = clsPlan.WhereFilters.GridSucCCOId
            .OrderByFilter = clsPlan.OrderByFilters.PlanCta
            .EmpresaId = mlngEmpresaId
            .EsAna = 1
            .SucCCOId = 2

            If .Open() Then
               Call grdMainTopDataViewAll()
               grdMainTop.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMainTop.RetrieveStructure()
               Call grdMainTopInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdMainBottomLoad()
      Try
         With moCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.GridCheck
            .WhereFilter = clsCentroCosto.WhereFilters.Grid
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = mlngEmpresaId

            If .Open() Then
               Call grdMainBottomDataViewAll()
               grdMainBottom.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMainBottom.RetrieveStructure()
               Call grdMainBottomInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub frmKardexLoad()
      Dim oListaPlan As New Queue
      Dim oListaCentroCosto As New Queue

      Try
         If FormCheck() Then
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMainTop.GetCheckedRows
               oListaPlan.Enqueue(oRow.Cells("PlanId").Value)
            Next

            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMainBottom.GetCheckedRows
               oListaCentroCosto.Enqueue(oRow.Cells("CentroCostoId").Value)
            Next

            If (oListaPlan.Count > 0) And (oListaCentroCosto.Count > 0) Then
               Dim frm As New frmLibroCentroCostoMes

               With frm
                  .EmpresaId = mlngEmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                  .SaldoAnterior = ToBoolean(chkSaldoAnterior.Checked)
                  .IntervaloFecha = ToBoolean(chkFecha.Checked)
                  .FechaIni = ToDate(dtpFechaIni.Value)
                  .FechaFin = ToDate(dtpFechaFin.Value)
                  .OrdenarFecha = ToBoolean(chkOrdenarFecha.Checked)
                  .SinFac = ToBoolean(optSinFac.Checked)
                  .ConFac = ToBoolean(optConFac.Checked)

                  .ListaPlan = oListaPlan
                  .ListaCentroCosto = oListaCentroCosto
                  .MdiParent = Me.MdiParent
                  .Show()

                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, Me.ToString)
               End With
            Else
               MessageBox.Show("Debe Seleccionar al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) = 0 Then
         strMsg &= "Seleccione la Moneda" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function GestionIdFind(ByVal strFecha As String) As String
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         GestionIdFind = 0

         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
            .EmpresaId = mlngEmpresaId
            .FechaIni = strFecha
            .EstadoId = 11

            If .Find Then
               GestionIdFind = .GestionId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Sub grdMainTopDataViewAll()
      grdMainTop.RemoveFilters()
   End Sub

   Private Sub grdMainBottomDataViewAll()
      grdMainBottom.RemoveFilters()
   End Sub

   Private Sub grdMainTopCheck(ByVal boolValue As Boolean)
      Dim oRow As DataRowView

      grdMainTop.MoveLast()
      grdMainTop.MoveFirst()

      With moPlan
         For Each oRow In .DataSet.Tables(.TableName).DefaultView
            oRow("Sel") = boolValue
         Next
      End With
   End Sub

   Private Sub grdMainBottomCheck(ByVal boolValue As Boolean)
      Dim oRow As DataRowView

      grdMainBottom.MoveLast()
      grdMainBottom.MoveFirst()

      With moCentroCosto
         For Each oRow In .DataSet.Tables(.TableName).DefaultView
            oRow("Sel") = boolValue
         Next
      End With
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
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
      moPlan = New clsPlan(clsAppInfo.ConnectString)
      moCentroCosto = New clsCentroCosto(clsAppInfo.ConnectString)

      Dim datFechaFin As Date
      Dim datFechaIni As Date = GestionFechaIni(clsAppInfo.GestionId, datFechaFin)

      dtpFechaIni.MinDate = datFechaIni
      dtpFechaIni.MaxDate = datFechaFin
      dtpFechaIni.Value = datFechaIni

      dtpFechaFin.MinDate = datFechaIni
      dtpFechaFin.MaxDate = datFechaFin

      If (Now.Date > datFechaIni) And (Now.Date < datFechaFin) Then
         dtpFechaFin.Value = Now.Date
      Else
         dtpFechaFin.Value = datFechaFin
      End If

      cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)

      If Not clsAppInfo.MultipleNro Then
         optSinFac.Checked = True
         grbFac.Visible = False
      End If
   End Sub

   Private Sub grdMainTopInit()
      With grdMainTop
         ebrMainTop.Groups(0).Text = "Plan de Cuentas"

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

         .RootTable.Columns("EsAna").Visible = False

         .RootTable.Columns("PlanPadreId").Visible = False

         .RootTable.Columns("Orden").Visible = False

         .RootTable.Columns("Nivel").Visible = False

         .RootTable.Columns("TipoPlanId").Visible = False

         .RootTable.Columns("TipoPlanDes").Caption = "Tipo Cuenta"
         .RootTable.Columns("TipoPlanDes").Width = 100
         .RootTable.Columns("TipoPlanDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoPlanDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoGrupoId").Visible = False

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TieneAnaAdd").Caption = "Ana Ad"
         .RootTable.Columns("TieneAnaAdd").Width = 50
         .RootTable.Columns("TieneAnaAdd").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
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
   End Sub

   Private Sub grdMainBottomInit()
      With grdMainBottom
         ebrMainBottom.Groups(0).Text = "Centros de Costo"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("CentroCostoId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("CentroCostoCod").Caption = "Código"
         .RootTable.Columns("CentroCostoCod").Width = 100
         .RootTable.Columns("CentroCostoCod").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CentroCostoCod").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CentroCostoDes").Caption = "Descripción"
         .RootTable.Columns("CentroCostoDes").Width = 200
         .RootTable.Columns("CentroCostoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("CentroCostoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdMainTop_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMainTop.LostFocus
      mboolMain = True
      mboolCentroCosto = False
   End Sub

   Private Sub grdMainBottom_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMainBottom.LostFocus
      mboolMain = False
      mboolCentroCosto = True
   End Sub

   Private Sub grdMainTop_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMainTop.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMainTop.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMainTop.GetRow.Cells(grdMainTop.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub grdMainBottom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMainBottom.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMainBottom.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMainBottom.GetRow.Cells(grdMainBottom.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
      dtpFechaIni.Enabled = chkFecha.Checked
      dtpFechaFin.Enabled = chkFecha.Checked
      chkSaldoAnterior.Enabled = chkFecha.Checked
      chkSaldoAnterior.Checked = chkFecha.Checked
   End Sub

   Private Sub frmLibroCentroCostoCompFind_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
      If Me.WindowState <> FormWindowState.Minimized Then
         ebrMainTop.Location = New Point(5, 5)
         ebrMainTop.Height = ((Me.ClientSize.Height - Me.TopRebar1.Height - Me.grpFecha.Height) / 2) - 10
         grdMainTop.Height = ebrMainTop.Height - 20

         ebrMainBottom.Location = New Point(5, ebrMainTop.Height + 10)
         ebrMainBottom.Height = ebrMainTop.Height - 5
         grdMainBottom.Height = ebrMainBottom.Height - 20
      End If
   End Sub

   Private Sub frmLibroCentroCostoCompFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmKardexLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmLibroCentroCostoCompFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      moCentroCosto.Dispose()
      Call ClearMemory()
   End Sub

   Public Overrides Function ToString() As String
      Dim strCuentas As String = ""
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMainTop.GetCheckedRows
         strCuentas &= oRow.Cells("PlanCta").Value.ToString & ";"
      Next

      Dim strCentroCosto As String = ""
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMainBottom.GetCheckedRows
         strCentroCosto &= oRow.Cells("CentroCostoCod").Value.ToString & ";"
      Next

      Return "Gestión: " & clsAppInfo.Gestion & "; " & If(chkFecha.Checked, " Desde " & dtpFechaIni.Text & " Hasta " & dtpFechaFin.Text, "") & "; " & If(chkOrdenarFecha.Checked, "Ordenar por Fecha", "") & "; Moneda: " & cboMoneda.Text & "; Incluir Saldo Anterior: " & If(chkSaldoAnterior.Checked, "Sí", "No") & "; Cuentas: " & strCuentas & "; C.C.: " & strCentroCosto
   End Function
End Class
