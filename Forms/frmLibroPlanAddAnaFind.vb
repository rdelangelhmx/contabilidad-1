Public Class frmLibroPlanAddAnaFind
   Inherits System.Windows.Forms.Form

   Private moPlanAdd As clsPlanAdd
   Private mlngEmpresaId As Long

   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mboolCheckTipoAsientoAll As Boolean

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

#Region " C�digo generado por el Dise�ador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Dise�ador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

   'Requerido por el Dise�ador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Dise�ador de Windows Forms. 
   'No lo modifique con el editor de c�digo.
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents cboTipoAsiento As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents grbFac As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optConFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optSinFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optCuenta As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optGeneral As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents chkFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkSaldoAnterior As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkIncluirDetalle As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents CheckTrue As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckFalse As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckTrue1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckFalse1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents chkSaldoCero As Janus.Windows.EditControls.UICheckBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLibroPlanAddAnaFind))
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.optCuenta = New Janus.Windows.EditControls.UIRadioButton
      Me.optGeneral = New Janus.Windows.EditControls.UIRadioButton
      Me.grbFac = New Janus.Windows.EditControls.UIGroupBox
      Me.optConFac = New Janus.Windows.EditControls.UIRadioButton
      Me.optSinFac = New Janus.Windows.EditControls.UIRadioButton
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboTipoAsiento = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.chkFecha = New Janus.Windows.EditControls.UICheckBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkSaldoCero = New Janus.Windows.EditControls.UICheckBox
      Me.chkIncluirDetalle = New Janus.Windows.EditControls.UICheckBox
      Me.chkSaldoAnterior = New Janus.Windows.EditControls.UICheckBox
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckTrue1 = New Janus.Windows.UI.CommandBars.UICommand("CheckTrue")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckFalse1 = New Janus.Windows.UI.CommandBars.UICommand("CheckFalse")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit3 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.CheckTrue = New Janus.Windows.UI.CommandBars.UICommand("CheckTrue")
      Me.CheckFalse = New Janus.Windows.UI.CommandBars.UICommand("CheckFalse")
      Me.ViewAll2 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbFac.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox4.SuspendLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(842, 277)
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
      Me.grdMain.Size = New System.Drawing.Size(842, 277)
      Me.grdMain.TabIndex = 1
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.UiGroupBox3)
      Me.bcgMain.Controls.Add(Me.grbFac)
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox4)
      Me.bcgMain.Controls.Add(Me.chkFecha)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(866, 414)
      Me.bcgMain.TabIndex = 164
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.optCuenta)
      Me.UiGroupBox3.Controls.Add(Me.optGeneral)
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(735, 320)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(132, 50)
      Me.UiGroupBox3.TabIndex = 4
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'optCuenta
      '
      Me.optCuenta.BackColor = System.Drawing.Color.Transparent
      Me.optCuenta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optCuenta.Checked = True
      Me.optCuenta.CheckedValue = False
      Me.optCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optCuenta.Location = New System.Drawing.Point(8, 32)
      Me.optCuenta.Name = "optCuenta"
      Me.optCuenta.Size = New System.Drawing.Size(116, 16)
      Me.optCuenta.TabIndex = 2
      Me.optCuenta.TabStop = True
      Me.optCuenta.Text = "Glosa por Cuenta"
      Me.optCuenta.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optGeneral
      '
      Me.optGeneral.BackColor = System.Drawing.Color.Transparent
      Me.optGeneral.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optGeneral.Location = New System.Drawing.Point(8, 12)
      Me.optGeneral.Name = "optGeneral"
      Me.optGeneral.Size = New System.Drawing.Size(116, 16)
      Me.optGeneral.TabIndex = 1
      Me.optGeneral.Text = "Glosa General"
      Me.optGeneral.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grbFac
      '
      Me.grbFac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.grbFac.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbFac.Controls.Add(Me.optConFac)
      Me.grbFac.Controls.Add(Me.optSinFac)
      Me.grbFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbFac.Location = New System.Drawing.Point(735, 372)
      Me.grbFac.Name = "grbFac"
      Me.grbFac.Size = New System.Drawing.Size(84, 32)
      Me.grbFac.TabIndex = 5
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
      Me.optConFac.TabIndex = 2
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
      Me.optSinFac.TabIndex = 1
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
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 278
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(858, 310)
      Me.ebrMain.TabIndex = 6
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'UiGroupBox4
      '
      Me.UiGroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox4.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox4.Controls.Add(Me.Label7)
      Me.UiGroupBox4.Controls.Add(Me.cboTipoAsiento)
      Me.UiGroupBox4.Controls.Add(Me.Label2)
      Me.UiGroupBox4.Controls.Add(Me.Label1)
      Me.UiGroupBox4.Controls.Add(Me.cboCentroCosto)
      Me.UiGroupBox4.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox4.Controls.Add(Me.Label5)
      Me.UiGroupBox4.Controls.Add(Me.cboPlan)
      Me.UiGroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox4.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox4.Location = New System.Drawing.Point(204, 320)
      Me.UiGroupBox4.Name = "UiGroupBox4"
      Me.UiGroupBox4.Size = New System.Drawing.Size(364, 88)
      Me.UiGroupBox4.TabIndex = 2
      Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(188, 13)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(50, 28)
      Me.Label7.TabIndex = 229
      Me.Label7.Text = "Tipo de Asiento"
      '
      'cboTipoAsiento
      '
      Me.cboTipoAsiento.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
      Me.cboTipoAsiento.ControlStyle.ControlTextColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAsiento.ControlStyle.WindowTextColor = System.Drawing.SystemColors.HotTrack
      cboTipoAsiento_DesignTimeLayout.LayoutString = resources.GetString("cboTipoAsiento_DesignTimeLayout.LayoutString")
      Me.cboTipoAsiento.DesignTimeLayout = cboTipoAsiento_DesignTimeLayout
      Me.cboTipoAsiento.DropDownButtonsVisible = False
      Me.cboTipoAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoAsiento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAsiento.Location = New System.Drawing.Point(241, 12)
      Me.cboTipoAsiento.Name = "cboTipoAsiento"
      Me.cboTipoAsiento.SaveSettings = False
      Me.cboTipoAsiento.Size = New System.Drawing.Size(115, 20)
      Me.cboTipoAsiento.TabIndex = 4
      Me.cboTipoAsiento.ValuesDataMember = Nothing
      Me.cboTipoAsiento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 36)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(52, 16)
      Me.Label2.TabIndex = 166
      Me.Label2.Text = "C. C."
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(52, 16)
      Me.Label1.TabIndex = 165
      Me.Label1.Text = "Cuenta"
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(63, 36)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(115, 20)
      Me.cboCentroCosto.TabIndex = 2
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(63, 60)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(115, 20)
      Me.cboMoneda.TabIndex = 3
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(7, 62)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(52, 16)
      Me.Label5.TabIndex = 163
      Me.Label5.Text = "Moneda"
      '
      'cboPlan
      '
      cboPlan_DesignTimeLayout.LayoutString = resources.GetString("cboPlan_DesignTimeLayout.LayoutString")
      Me.cboPlan.DesignTimeLayout = cboPlan_DesignTimeLayout
      Me.cboPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlan.Location = New System.Drawing.Point(63, 12)
      Me.cboPlan.Name = "cboPlan"
      Me.cboPlan.SelectedIndex = -1
      Me.cboPlan.SelectedItem = Nothing
      Me.cboPlan.Size = New System.Drawing.Size(115, 20)
      Me.cboPlan.TabIndex = 1
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'chkFecha
      '
      Me.chkFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.chkFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFecha.Location = New System.Drawing.Point(16, 320)
      Me.chkFecha.Name = "chkFecha"
      Me.chkFecha.Size = New System.Drawing.Size(112, 20)
      Me.chkFecha.TabIndex = 1
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
      Me.grpMain.Location = New System.Drawing.Point(8, 320)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(188, 88)
      Me.grpMain.TabIndex = 1
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
      Me.dtpFechaFin.Location = New System.Drawing.Point(56, 52)
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
      Me.dtpFechaIni.Enabled = False
      Me.dtpFechaIni.Location = New System.Drawing.Point(56, 28)
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
      Me.Label3.Location = New System.Drawing.Point(8, 32)
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
      Me.Label4.Location = New System.Drawing.Point(8, 56)
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
      Me.UiGroupBox2.Controls.Add(Me.chkIncluirDetalle)
      Me.UiGroupBox2.Controls.Add(Me.chkSaldoAnterior)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(575, 320)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(152, 88)
      Me.UiGroupBox2.TabIndex = 3
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkSaldoCero
      '
      Me.chkSaldoCero.BackColor = System.Drawing.Color.Transparent
      Me.chkSaldoCero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSaldoCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSaldoCero.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkSaldoCero.Location = New System.Drawing.Point(8, 64)
      Me.chkSaldoCero.Name = "chkSaldoCero"
      Me.chkSaldoCero.Size = New System.Drawing.Size(140, 16)
      Me.chkSaldoCero.TabIndex = 3
      Me.chkSaldoCero.Text = "Anal. con Saldo Cero"
      Me.chkSaldoCero.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkIncluirDetalle
      '
      Me.chkIncluirDetalle.BackColor = System.Drawing.Color.Transparent
      Me.chkIncluirDetalle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkIncluirDetalle.Checked = True
      Me.chkIncluirDetalle.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkIncluirDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkIncluirDetalle.Location = New System.Drawing.Point(8, 16)
      Me.chkIncluirDetalle.Name = "chkIncluirDetalle"
      Me.chkIncluirDetalle.Size = New System.Drawing.Size(140, 16)
      Me.chkIncluirDetalle.TabIndex = 1
      Me.chkIncluirDetalle.Text = "Det. de Anal. Adic."
      Me.chkIncluirDetalle.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkSaldoAnterior
      '
      Me.chkSaldoAnterior.BackColor = System.Drawing.Color.Transparent
      Me.chkSaldoAnterior.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSaldoAnterior.Enabled = False
      Me.chkSaldoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSaldoAnterior.Location = New System.Drawing.Point(8, 40)
      Me.chkSaldoAnterior.Name = "chkSaldoAnterior"
      Me.chkSaldoAnterior.Size = New System.Drawing.Size(140, 16)
      Me.chkSaldoAnterior.TabIndex = 2
      Me.chkSaldoAnterior.Text = "Saldo Anterior"
      Me.chkSaldoAnterior.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.CheckTrue, Me.CheckFalse, Me.ViewAll2, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("bc680a04-a190-4bd0-a4fa-b6d6cd9a08ef")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator4, Me.CheckTrue1, Me.Separator5, Me.CheckFalse1, Me.Separator6, Me.ViewAll1, Me.Separator7, Me.Exit3})
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
      Me.Book1.ToolTipText = "Movimiento de Anal�ticos Adicionales"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'CheckTrue1
      '
      Me.CheckTrue1.Key = "CheckTrue"
      Me.CheckTrue1.Name = "CheckTrue1"
      Me.CheckTrue1.Text = "Seleccionar Todos"
      Me.CheckTrue1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'CheckFalse1
      '
      Me.CheckFalse1.Key = "CheckFalse"
      Me.CheckFalse1.Name = "CheckFalse1"
      Me.CheckFalse1.Text = "Quitar Selecci�n"
      Me.CheckFalse1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'ViewAll1
      '
      Me.ViewAll1.Key = "ViewAll"
      Me.ViewAll1.Name = "ViewAll1"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
      '
      'Exit3
      '
      Me.Exit3.Key = "Exit"
      Me.Exit3.Name = "Exit3"
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
      Me.TopRebar1.Size = New System.Drawing.Size(866, 28)
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
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
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'frmLibroPlanAddAnaFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(866, 442)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmLibroPlanAddAnaFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Criterios Movimiento de Anal�ticos Adicionales Por Anal�ticos"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbFac.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox4.ResumeLayout(False)
      Me.UiGroupBox4.PerformLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).EndInit()
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
            Call frmLibroPlanAddAnaLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmLibroPlanAddAnaFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmLibroPlanAddAnaFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      Call cboPlanLoad()
      Call cboCentroCostoLoad()
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

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.TieneAnaAdd
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = mlngEmpresaId
            .TieneAnaAdd = 1

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
                  .DropDownList.Columns("PlanDes").Caption = "Descripci�n"
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

   Private Sub cboCentroCostoLoad()
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCosto.Items.Clear()
      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.ListBox
            .WhereFilter = clsCentroCosto.WhereFilters.EmpresaId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = mlngEmpresaId

            If .Open() Then
               oItem = New clsListItem(0, "(Todos)")
               cboCentroCosto.Items.Add(oItem)

               Do While .Read()
                  If .CentroCostoId <> 0 Then
                     oItem = New clsListItem(.CentroCostoId, .CentroCostoDes)

                     cboCentroCosto.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop

               cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, 0)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCentroCosto.Dispose()
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

                  .DropDownList.Columns("TipoAsientoDes").Caption = "Descripci�n"
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

      If GestionFecha(clsAppInfo.GestionId, mstrFechaIni, mstrFechaFin) Then
         dtpFechaIni.Value = mstrFechaIni
         dtpFechaFin.Value = mstrFechaFin
      End If

      dtpFechaIni.MaxDate = mstrFechaFin
      dtpFechaIni.MinDate = mstrFechaIni
      dtpFechaFin.MaxDate = mstrFechaFin
      dtpFechaFin.MinDate = mstrFechaIni

      dtpFechaFin.Value = Date.Now

      moPlanAdd = New clsPlanAdd(clsAppInfo.ConnectString)
      cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
      cboTipoAsiento.DropDownList.GetRows(0).IsChecked = True
      cboTipoAsiento.Text = cboTipoAsiento.DropDownList.GetRows(0).Cells("TipoAsientoDes").Value

      If Not clsAppInfo.MultipleNro Then
         optSinFac.Checked = True
         grbFac.Visible = False
      End If
   End Sub

   Private Sub frmLibroPlanAddAnaLoad()
      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) <> 0 Then
         Dim oLista As New Queue
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            oLista.Enqueue(oRow.Cells("PlanAddId").Value)
         Next

         If oLista.Count Then
            Dim oListaTipoAsiento As New Queue
            For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetCheckedRows
               oListaTipoAsiento.Enqueue(oRow.Cells("TipoAsientoId").Value)
            Next

            If oListaTipoAsiento.Count Then
               Dim frm As New frmLibroPlanAddAna

               With frm
                  .EmpresaId = mlngEmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .PlanId = ListPosition(cboPlan)
                  .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
                  .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                  .SaldoAnterior = ToBoolean(chkSaldoAnterior.Checked)
                  .Cuenta = ToBoolean(optCuenta.Checked)
                  .IncluirDetalle = ToBoolean(chkIncluirDetalle.Checked)
                  .IntervaloFecha = ToBoolean(chkFecha.Checked)
                  .FechaIni = ToDate(dtpFechaIni.Value)
                  .FechaFin = ToDate(dtpFechaFin.Value)
                  .SaldoCero = ToBoolean(chkSaldoCero.Checked)
                  .SinFac = ToBoolean(optSinFac.Checked)
                  .ConFac = ToBoolean(optConFac.Checked)
                  .ListaTipoAsiento = oListaTipoAsiento
                  .Lista = oLista
                  .MdiParent = Me.MdiParent
                  .Show()

                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, Me.ToString)
               End With
            Else
               MessageBox.Show("Debe Seleccionar al Menos un Tipo de Asiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar la Moneda", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub frmLibroPlanAddAnaFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmLibroPlanAddAnaLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmLibroPlanAddAnaFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlanAdd.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
      If ToBoolean(chkFecha.Checked) = 0 Then
         dtpFechaFin.Value = Date.Now
         dtpFechaIni.Value = mstrFechaIni
      End If

      dtpFechaIni.Enabled = chkFecha.Checked
      dtpFechaFin.Enabled = chkFecha.Checked
      chkSaldoAnterior.Enabled = chkFecha.Checked
      chkSaldoAnterior.Checked = chkFecha.Checked
   End Sub

   Private Sub cboPlan_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPlan.ValueChanged
      If cboPlan.Tag <> cboPlan.Text Then
         cboPlan.Tag = cboPlan.Text

         Call grdMainLoad()
      End If
   End Sub

#Region " LIBRO-PLAN-ANA "
#Region " Metodo-LibroPlanAna "
   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("PlanAddId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub
#End Region

#Region " Grid-LibroPlanAna "
   Private Sub grdMainLoad()
      Try
         With moPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.GridCheck
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes

            .EmpresaId = mlngEmpresaId
            .PlanId = ListPosition(cboPlan)
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

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Anal�ticos Adicionales"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("PlanAddId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("PlanId").Visible = False

         .RootTable.Columns("PlanAddCta").Caption = "C�digo"
         .RootTable.Columns("PlanAddCta").Width = 100
         .RootTable.Columns("PlanAddCta").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanAddCta").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PlanAddDes").Caption = "Descripci�n"
         .RootTable.Columns("PlanAddDes").Width = 200
         .RootTable.Columns("PlanAddDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PlanAddDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
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
      Return "Gesti�n: " & clsAppInfo.Gestion & If(chkFecha.Checked, " Desde " & dtpFechaIni.Text & " Hasta " & dtpFechaFin.Text, "") & "; Cuenta: " & cboPlan.Text & "; C.C.: " & cboCentroCosto.Text & "; Moneda: " & cboMoneda.Text & "; Tipo Asiento: " & cboTipoAsiento.Text & "; Detalle de A.A.: " & If(chkIncluirDetalle.Checked, "S�", "No") & "; Saldo Anterior: " & If(chkSaldoAnterior.Checked, "S�", "No") & "; Analiticos con Saldo Cero: " & If(chkSaldoCero.Checked, "S�", "No") & "; " & If(optGeneral.Checked, optGeneral.Text, optCuenta.Text)
   End Function

End Class
