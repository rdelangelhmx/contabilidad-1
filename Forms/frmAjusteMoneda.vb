Public Class frmAjusteMoneda
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan
   Private mlngEmpresaId As Long
   Private mlngPlanAitbId As Long

   Private mboolSelected As Boolean
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Private mlngID As Long

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
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
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
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblId As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjusteMoneda))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.lblId = New System.Windows.Forms.Label
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
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 297)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 297)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.ebrMain)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(752, 414)
      Me.bcgMain.TabIndex = 163
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
      ExplorerBarGroup1.ContainerHeight = 298
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 330)
      Me.ebrMain.TabIndex = 8
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
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 338)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(244, 68)
      Me.grpMain.TabIndex = 4
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dtpFecha
      '
      Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFecha.DropDownCalendar.FirstMonth = New Date(2008, 4, 1, 0, 0, 0, 0)
      Me.dtpFecha.DropDownCalendar.Name = ""
      Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFecha.Location = New System.Drawing.Point(112, 16)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(124, 20)
      Me.dtpFecha.TabIndex = 5
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(112, 40)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(124, 20)
      Me.txtTipoCambio.TabIndex = 6
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label1.Location = New System.Drawing.Point(4, 20)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 159
      Me.Label1.Text = "Fecha de Ajuste"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(4, 44)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 158
      Me.Label2.Text = "Tipo de Cambio"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.cboPlan)
      Me.UiGroupBox2.Controls.Add(Me.lblId)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(260, 338)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(420, 68)
      Me.UiGroupBox2.TabIndex = 7
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboPlan
      '
      cboPlan_DesignTimeLayout.LayoutString = resources.GetString("cboPlan_DesignTimeLayout.LayoutString")
      Me.cboPlan.DesignTimeLayout = cboPlan_DesignTimeLayout
      Me.cboPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlan.Location = New System.Drawing.Point(96, 40)
      Me.cboPlan.Name = "cboPlan"
      Me.cboPlan.SelectedIndex = -1
      Me.cboPlan.SelectedItem = Nothing
      Me.cboPlan.Size = New System.Drawing.Size(316, 20)
      Me.cboPlan.TabIndex = 8
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblId
      '
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblId.Location = New System.Drawing.Point(8, 44)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(84, 16)
      Me.lblId.TabIndex = 155
      Me.lblId.Text = "Contracuenta"
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(285, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Ajuste Monetario"
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
      'frmAjusteMoneda
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmAjusteMoneda"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ajuste Monetario"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).EndInit()
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
            Call AjusteMonetario()

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

   Private Sub frmAjusteMoneda_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmAjusteMoneda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call ComboLoad()

      dtpFecha.Text = ToDateDMY(Now.Date)
      Call txtTipoCambioFind(ToDate(dtpFecha.Value))
      cboPlan.Value = ListFindItem(cboPlan, clsAppInfo.PlanAitbId)
      Call ClearMemory()

      mboolSelected = False

      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad()
      Try
         With moPlan
            .SelectFilter = clsPlan.SelectFilters.GridCheck
            .WhereFilter = clsPlan.WhereFilters.GridEsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanCta
            .EmpresaId = mlngEmpresaId
            .EsAna = 1

            If .Open() Then
               Call grdMainDeleteRow(clsAppInfo.PlanAitbId)
               Call grdMainDeleteRow(clsAppInfo.PlanDifId)

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

   Private Function FormCheck() As Boolean
      Dim strMessage As String = ""

      FormCheck = True

      If grdMain.GetCheckedRows.Count = 0 Then
         MessageBox.Show("Debe Seleccionar al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End If

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         strMessage &= "Fecha no Corresponde a la Gestion en Uso" & vbCrLf
      End If

      If ToDecimal(txtTipoCambio.Text) <= 0 Then
         strMessage &= "Tipo de Cambio Inválido" & vbCrLf
      End If

      If ListPosition(cboPlan) = 0 Then
         strMessage &= "Contra Cuenta Inválida" & vbCrLf
      End If

      If strMessage <> "" Then
         FormCheck = False
         MessageBox.Show(strMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Sub AjusteMonetario()
      If FormCheck() Then
         mlngPlanAitbId = ListPosition(cboPlan)
         Call grdMainDeleteRow(mlngPlanAitbId)

         '* BITACORA AJUSTE MONETARIO.
         Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.AJUSTE_MONETARIO, "Fecha de Ajuste: " & dtpFecha.Text & "; Tipo de Cambio: " & txtTipoCambio.Text & "; ContraCuenta: " & cboPlan.Text)

         If MessageBox.Show("¿Realmente quiere Realizar el Ajuste Monetario?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If PlanAjusteBolivianos(1) Then
               If PlanAjusteDolares(2) Then
                  MessageBox.Show("Saldos Ajustados Exitosamente" & vbCrLf & "Favor Revisar Comprobante(s) en Estado Pendiente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Else
                  MessageBox.Show("Saldos Ajustados Exitosamente" & vbCrLf & "Favor Revisar Comprobante(s) en Estado Pendiente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If

            ElseIf PlanAjusteDolares(2) Then
               MessageBox.Show("Saldos Ajustados Exitosamente" & vbCrLf & "Favor Revisar Comprobante(s) en Estado Pendiente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
               MessageBox.Show("No Existe Diferencia de Cambio Para esta Gestión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         End If
      End If
   End Sub

   Private Function PlanAjusteBolivianos(ByVal lngMonedaId As Long) As Boolean
      Dim decSaldoBs As Decimal
      Dim decSaldoUs As Decimal
      Dim decSaldoDif As Decimal
      Dim decSaldoTotal As Decimal = 0
      Dim lngGrupo As Long
      Dim boolCompNew As Boolean = True
      Dim lngCompId As Long
      Dim decTipoCambio As Decimal = ToDecimal(txtTipoCambio.Text)
      Dim decTipoCambioSaldo As Decimal = 0

      PlanAjusteBolivianos = False

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If oRow.Cells("MonedaId").Value = lngMonedaId Then
               decSaldoBs = 0
               decSaldoUs = 0
               decSaldoDif = 0

               lngGrupo = ToLong(oRow.Cells("TipoGrupoId").Value)
               decSaldoBs = PlanSaldoActual(lngGrupo, oRow.Cells("PlanId").Value, lngMonedaId, ToDate(dtpFecha.Value), decSaldoUs)

               If oRow.Cells("PlanId").Value <> mlngPlanAitbId Then
                  If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then

                     If ((decSaldoUs >= 0) And (decSaldoBs >= 0)) Or ((decSaldoUs <= 0) And (decSaldoBs <= 0)) Then
                        decSaldoDif = Math.Abs(ToDecimal(Math.Abs(decSaldoUs) - (Math.Abs(decSaldoBs) / decTipoCambio)))

                     ElseIf (decSaldoUs > 0) And (decSaldoBs < 0) Then
                        decSaldoDif = Math.Abs(ToDecimal(Math.Abs(decSaldoUs) + (Math.Abs(decSaldoBs) / decTipoCambio)))

                     ElseIf (decSaldoUs < 0) And (decSaldoBs > 0) Then
                        decSaldoDif = Math.Abs(ToDecimal(Math.Abs(decSaldoUs) + (Math.Abs(decSaldoBs) / decTipoCambio)))
                     End If

                     If decSaldoDif > 0 Then
                        If ((decSaldoUs >= 0) And (decSaldoBs >= 0)) Or ((decSaldoUs <= 0) And (decSaldoBs <= 0)) Then
                           decTipoCambioSaldo = Math.Abs(decSaldoBs / toDivByCero(decSaldoUs))

                        ElseIf (decSaldoUs > 0) And (decSaldoBs < 0) Then
                           decTipoCambioSaldo = decTipoCambio - 1

                        ElseIf (decSaldoUs < 0) And (decSaldoBs > 0) Then
                           decTipoCambioSaldo = decTipoCambio + 1
                        End If

                        If boolCompNew Then
                           If CompAdd(2, lngCompId) Then
                              boolCompNew = False
                           End If
                        End If

                        If (decSaldoBs > 0) Or (decSaldoUs > 0) Then
                           If decTipoCambio > decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 2, decSaldoDif, 2) Then
                                 decSaldoTotal = decSaldoTotal - decSaldoDif
                                 PlanAjusteBolivianos = True
                              End If

                           ElseIf decTipoCambio < decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 2, decSaldoDif, 1) Then
                                 decSaldoTotal = decSaldoTotal + decSaldoDif
                                 PlanAjusteBolivianos = True
                              End If
                           End If

                        ElseIf (decSaldoBs < 0) Or (decSaldoUs < 0) Then
                           If decTipoCambio > decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 2, decSaldoDif, 1) Then
                                 decSaldoTotal = decSaldoTotal + decSaldoDif
                                 PlanAjusteBolivianos = True
                              End If

                           ElseIf decTipoCambio < decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 2, decSaldoDif, 2) Then
                                 decSaldoTotal = decSaldoTotal - decSaldoDif
                                 PlanAjusteBolivianos = True
                              End If
                           End If
                        End If
                     End If

                  ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then

                     If ((decSaldoUs >= 0) And (decSaldoBs >= 0)) Or ((decSaldoUs <= 0) And (decSaldoBs <= 0)) Then
                        decSaldoDif = Math.Abs(ToDecimal(Math.Abs(decSaldoUs) - (Math.Abs(decSaldoBs) / decTipoCambio)))

                     ElseIf (decSaldoUs > 0) And (decSaldoBs < 0) Then
                        decSaldoDif = Math.Abs(ToDecimal(Math.Abs(decSaldoUs) + (Math.Abs(decSaldoBs) / decTipoCambio)))

                     ElseIf (decSaldoUs < 0) And (decSaldoBs > 0) Then
                        decSaldoDif = Math.Abs(ToDecimal(Math.Abs(decSaldoUs) + (Math.Abs(decSaldoBs) / decTipoCambio)))

                     End If

                     If decSaldoDif > 0 Then
                        If ((decSaldoUs >= 0) And (decSaldoBs >= 0)) Or ((decSaldoUs <= 0) And (decSaldoBs <= 0)) Then
                           decTipoCambioSaldo = Math.Abs(decSaldoBs / toDivByCero(decSaldoUs))

                        ElseIf (decSaldoUs > 0) And (decSaldoBs < 0) Then
                           decTipoCambioSaldo = decTipoCambio - 1

                        ElseIf (decSaldoUs < 0) And (decSaldoBs > 0) Then
                           decTipoCambioSaldo = decTipoCambio + 1
                        End If

                        If boolCompNew Then
                           If CompAdd(2, lngCompId) Then
                              boolCompNew = False
                           End If
                        End If

                        If (decSaldoBs > 0) Or (decSaldoUs > 0) Then
                           If decTipoCambio > decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 2, decSaldoDif, 1) Then
                                 decSaldoTotal = decSaldoTotal + decSaldoDif
                                 PlanAjusteBolivianos = True
                              End If

                           ElseIf decTipoCambio < decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 2, decSaldoDif, 2) Then
                                 decSaldoTotal = decSaldoTotal - decSaldoDif
                                 PlanAjusteBolivianos = True
                              End If
                           End If

                        ElseIf (decSaldoBs < 0) Or (decSaldoUs < 0) Then
                           If decTipoCambio > decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 2, decSaldoDif, 2) Then
                                 decSaldoTotal = decSaldoTotal - decSaldoDif
                                 PlanAjusteBolivianos = True
                              End If

                           ElseIf decTipoCambio < decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 2, decSaldoDif, 1) Then
                                 decSaldoTotal = decSaldoTotal + decSaldoDif
                                 PlanAjusteBolivianos = True
                              End If
                           End If
                        End If
                     End If
                  End If
               End If
            End If
         Next

         If Not boolCompNew Then
            If decSaldoTotal > 0 Then
               If CompDetAdd(lngCompId, mlngPlanAitbId, "", 2, decSaldoTotal, 2) Then
                  PlanAjusteBolivianos = True
               End If
            ElseIf decSaldoTotal < 0 Then
               If CompDetAdd(lngCompId, mlngPlanAitbId, "", 2, Math.Abs(decSaldoTotal), 1) Then
                  PlanAjusteBolivianos = True
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Function

   Private Function PlanAjusteDolares(ByVal lngMonedaId As Long) As Boolean
      Dim decSaldoBs As Decimal
      Dim decSaldoUs As Decimal
      Dim decSaldoDif As Decimal
      Dim decSaldoTotal As Decimal = 0
      Dim lngGrupo As Long
      Dim boolCompNew As Boolean = True
      Dim lngCompId As Long
      Dim decTipoCambio As Decimal = ToDecimal(txtTipoCambio.Text)
      Dim decTipoCambioSaldo As Decimal = 0

      PlanAjusteDolares = False

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If oRow.Cells("MonedaId").Value = lngMonedaId Then
               decSaldoBs = 0
               decSaldoUs = 0
               decSaldoDif = 0

               lngGrupo = ToLong(oRow.Cells("TipoGrupoId").Value)
               decSaldoBs = PlanSaldoActual(lngGrupo, oRow.Cells("PlanId").Value, lngMonedaId, ToDate(dtpFecha.Value), decSaldoUs)

               If oRow.Cells("PlanId").Value <> mlngPlanAitbId Then
                  If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then

                     If ((decSaldoUs >= 0) And (decSaldoBs >= 0)) Or ((decSaldoUs <= 0) And (decSaldoBs <= 0)) Then
                        decSaldoDif = Math.Abs(ToDecimal((Math.Abs(decSaldoUs) * decTipoCambio)) - Math.Abs(decSaldoBs))

                     ElseIf (decSaldoUs > 0) And (decSaldoBs < 0) Then
                        decSaldoDif = Math.Abs(ToDecimal((Math.Abs(decSaldoUs) * decTipoCambio)) + Math.Abs(decSaldoBs))

                     ElseIf (decSaldoUs < 0) And (decSaldoBs > 0) Then
                        decSaldoDif = Math.Abs(ToDecimal((Math.Abs(decSaldoUs) * decTipoCambio)) + Math.Abs(decSaldoBs))

                     End If

                     If decSaldoDif > 0 Then
                        If ((decSaldoUs >= 0) And (decSaldoBs >= 0)) Or ((decSaldoUs <= 0) And (decSaldoBs <= 0)) Then
                           decTipoCambioSaldo = Math.Abs(decSaldoBs / toDivByCero(decSaldoUs))

                        ElseIf (decSaldoUs > 0) And (decSaldoBs < 0) Then
                           decTipoCambioSaldo = decTipoCambio - 1

                        ElseIf (decSaldoUs < 0) And (decSaldoBs > 0) Then
                           decTipoCambioSaldo = decTipoCambio + 1
                        End If

                        If boolCompNew Then
                           If CompAdd(1, lngCompId) Then
                              boolCompNew = False
                           End If
                        End If

                        If (decSaldoUs > 0) Or (decSaldoBs > 0) Then
                           If decTipoCambio > decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 1, decSaldoDif, 1) Then
                                 decSaldoTotal = decSaldoTotal + decSaldoDif
                                 PlanAjusteDolares = True
                              End If

                           ElseIf decTipoCambio < decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 1, decSaldoDif, 2) Then
                                 decSaldoTotal = decSaldoTotal - decSaldoDif
                                 PlanAjusteDolares = True
                              End If
                           End If

                        ElseIf (decSaldoUs < 0) Or (decSaldoBs < 0) Then
                           If decTipoCambio > decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 1, decSaldoDif, 2) Then
                                 decSaldoTotal = decSaldoTotal - decSaldoDif
                                 PlanAjusteDolares = True
                              End If

                           ElseIf decTipoCambio < decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 1, decSaldoDif, 1) Then
                                 decSaldoTotal = decSaldoTotal + decSaldoDif
                                 PlanAjusteDolares = True
                              End If
                           End If
                        End If
                     End If

                  ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then

                     If ((decSaldoUs >= 0) And (decSaldoBs >= 0)) Or ((decSaldoUs <= 0) And (decSaldoBs <= 0)) Then
                        decSaldoDif = Math.Abs(ToDecimal((Math.Abs(decSaldoUs) * decTipoCambio)) - Math.Abs(decSaldoBs))

                     ElseIf (decSaldoUs > 0) And (decSaldoBs < 0) Then
                        decSaldoDif = Math.Abs(ToDecimal((Math.Abs(decSaldoUs) * decTipoCambio)) + Math.Abs(decSaldoBs))

                     ElseIf (decSaldoUs < 0) And (decSaldoBs > 0) Then
                        decSaldoDif = Math.Abs(ToDecimal((Math.Abs(decSaldoUs) * decTipoCambio)) + Math.Abs(decSaldoBs))

                     End If

                     If decSaldoDif > 0 Then
                        If ((decSaldoUs >= 0) And (decSaldoBs >= 0)) Or ((decSaldoUs <= 0) And (decSaldoBs <= 0)) Then
                           decTipoCambioSaldo = Math.Abs(decSaldoBs / toDivByCero(decSaldoUs))

                        ElseIf (decSaldoUs > 0) And (decSaldoBs < 0) Then
                           decTipoCambioSaldo = decTipoCambio - 1

                        ElseIf (decSaldoUs < 0) And (decSaldoBs > 0) Then
                           decTipoCambioSaldo = decTipoCambio + 1
                        End If

                        If boolCompNew Then
                           If CompAdd(1, lngCompId) Then
                              boolCompNew = False
                           End If
                        End If

                        If (decSaldoUs > 0) Or (decSaldoBs > 0) Then
                           If decTipoCambio > decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 1, decSaldoDif, 2) Then
                                 decSaldoTotal = decSaldoTotal - decSaldoDif
                                 PlanAjusteDolares = True
                              End If

                           ElseIf decTipoCambio < decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 1, decSaldoDif, 1) Then
                                 decSaldoTotal = decSaldoTotal + decSaldoDif
                                 PlanAjusteDolares = True
                              End If
                           End If

                        ElseIf (decSaldoUs < 0) Or (decSaldoBs < 0) Then
                           If decTipoCambio > decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 1, decSaldoDif, 1) Then
                                 decSaldoTotal = decSaldoTotal + decSaldoDif
                                 PlanAjusteDolares = True
                              End If

                           ElseIf decTipoCambio < decTipoCambioSaldo Then
                              If CompDetAdd(lngCompId, oRow.Cells("PlanId").Value, oRow.Cells("PlanDes").Value, 1, decSaldoDif, 2) Then
                                 decSaldoTotal = decSaldoTotal - decSaldoDif
                                 PlanAjusteDolares = True
                              End If
                           End If
                        End If
                     End If
                  End If
               End If
            End If
         Next

         If Not boolCompNew Then
            If decSaldoTotal > 0 Then
               If CompDetAdd(lngCompId, mlngPlanAitbId, "", 1, decSaldoTotal, 2) Then
                  PlanAjusteDolares = True
               End If
            ElseIf decSaldoTotal < 0 Then
               If CompDetAdd(lngCompId, mlngPlanAitbId, "", 1, Math.Abs(decSaldoTotal), 1) Then
                  PlanAjusteDolares = True
               End If
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally

      End Try
   End Function

   Private Sub CloneVMComp(ByRef oComp As clsComp)
      If clsAppInfo.RegistrarBitacora Then
         With oComp
            .VMNew.TipoCompId = .TipoCompId
            .VMNew.CompNro = .CompNro
            .VMNew.Fecha = ConvertDMY(.Fecha)
            .VMNew.MonedaId = .MonedaId
            .VMNew.TipoCambio = .TipoCambio
            .VMNew.EntregadoA = .EntregadoA
            .VMNew.PorConcepto = .PorConcepto
            .VMNew.DebeBs = .DebeBs
            .VMNew.DebeUs = .DebeUs
            .VMNew.HaberBs = .HaberBs
            .VMNew.HaberUs = .HaberUs
            .VMNew.PorIVA = .PorIVA
            .VMNew.PorIT = .PorIT
            .VMNew.PorITF = .PorITF
            .VMNew.ConFac = .ConFac
            .VMNew.SinFac = .SinFac
            .VMNew.Automatico = .Automatico
            .VMNew.TipoAsientoId = .TipoAsientoId
            .VMNew.Glosa = .Glosa
            .VMNew.EstadoId = .EstadoId

            .VMNew.FormName = Me.Name
            .VMNew.FormText = Me.Text
         End With
      End If
   End Sub

   Private Function CompAdd(ByVal lngMonedaId As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoCompId = clsTipoComp.TRASPASO
            .CompNro = 0
            .Fecha = ToDate(dtpFecha.Value)
            .MonedaId = lngMonedaId
            .TipoCambio = ToDecimal(txtTipoCambio.Text)
            .EntregadoA = "Ajuste Monetario"
            .PorConcepto = "Por Diferencia de Cambio"
            .DebeBs = 0
            .HaberBs = 0
            .DebeUs = 0
            .HaberUs = 0
            .PorIVA = 0
            .PorIT = 0
            .PorITF = 0
            .ConFac = 0
            .SinFac = 1
            .Automatico = 1
            .TipoAsientoId = clsTipoAsiento.AJUSTE
            .Glosa = ""
            .EstadoId = clsEstado.PENDIENTE

            Call CloneVMComp(oComp)
            If .Insert() Then
               CompAdd = True
               lngCompId = .CompId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompDetAdd(ByVal lngCompId As Long, ByVal lngPlanId As Long, ByVal strPlanDes As String, ByVal lngMonedaId As Long, ByVal decValor As Decimal, ByVal lngCol As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoCompId = 3
            .Fecha = ToDate(dtpFecha.Value)
            .PlanId = lngPlanId
            .CompDetDes = "Ajuste por Diferencia de Cambio"
            .SucursalId = 0
            .CentroCostoId = 0
            .MonedaId = lngMonedaId

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
            .EstadoId = 13

            If .Insert() Then
               CompDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message & "Cuenta: " & strPlanDes, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function PlanSaldoActual(ByVal lngGrupo As Long, ByVal lngPlanId As Long, ByVal lngMonedaId As Long, ByVal strFecha As String, ByRef decSaldoUs As Decimal) As Decimal
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal

      decSaldoBs = 0

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoActual
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .PlanId = lngPlanId
            .Fecha = strFecha

            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                     decSaldoBs = decSaldoBs + (ToDecimal(oRow("DebeBs")) - ToDecimal(oRow("HaberBs")))
                     decSaldoUs = decSaldoUs + (ToDecimal(oRow("DebeUs")) - ToDecimal(oRow("HaberUs")))

                  ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                     decSaldoBs = decSaldoBs + (ToDecimal(oRow("HaberBs")) - ToDecimal(oRow("DebeBs")))
                     decSaldoUs = decSaldoUs + (ToDecimal(oRow("HaberUs")) - ToDecimal(oRow("DebeUs")))
                  End If
               Next

               PlanSaldoActual = decSaldoBs
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0

      Try
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

   Private Sub txtTipoCambioFind(ByVal strFecha As String)
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      Try
         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = strFecha

            If .Find Then
               txtTipoCambio.Tag = .TipoCambioId
               txtTipoCambio.Text = ToStr(.Valor)
            Else
               txtTipoCambio.Tag = 0
               txtTipoCambio.Text = ""
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("PlanId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
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

   Private Sub grdMainDeleteRow(ByVal lngID As Long)
      Dim i As Long

      With moPlan
         For i = 0 To .DataSet.Tables(.TableName).Rows.Count - 1
            If ToLong(.DataSet.Tables(.TableName).Rows(i).Item("PlanId")) = lngID Then
               .DataSet.Tables(.TableName).Rows.RemoveAt(i)
               Exit For
            End If
         Next
      End With
   End Sub

   Private Sub ComboLoad()
      Call cboPlanLoad()
   End Sub

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.MultiComboBox
            .WhereFilter = clsPlan.WhereFilters.EsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = mlngEmpresaId
            .EsAna = 1
            .EstadoId = clsEstado.ACTIVO

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

                  If clsAppInfo.PlanCtaShow Then
                     .ValueMember = "PlanId"
                     .DisplayMember = "PlanCta"
                  Else
                     .ValueMember = "PlanId"
                     .DisplayMember = "PlanDes"
                  End If
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moPlan = New clsPlan(clsAppInfo.ConnectString)
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

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("TieneAnaAdd"), Janus.Windows.GridEX.ConditionOperator.Equal, False)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("TieneAnaAdd"), Janus.Windows.GridEX.ConditionOperator.Equal, True)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   'Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
   '   If dtpFecha.Tag <> dtpFecha.Text Then
   '      If IsDate(dtpFecha.Text) Then
   '         Call txtTipoCambioFind(ToDate(dtpFecha.Value))
   '         dtpFecha.Tag = dtpFecha.Text
   '      Else
   '         txtTipoCambio.Text = 0
   '      End If
   '   End If
   'End Sub

   Private Sub frmAjusteMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call AjusteMonetario()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmAjusteMoneda_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
   End Sub

   Private Function MonedaDesFind(ByVal lngmonedaid As Long) As String
      Dim omoneda As New clsMoneda(clsAppInfo.ConnectString)

      Try
         With omoneda
            .MonedaId = lngmonedaid

            If .FindByPK Then
               MonedaDesFind = .MonedaDes
            End If
         End With
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function TipoCompDesFind(ByVal lngTipoCompid As Long) As String
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)

      Try
         With oTipoComp
            .TipoCompId = lngTipoCompid

            If .FindByPK Then
               TipoCompDesFind = .TipoCompDes
            End If
         End With
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function EstadoDesFind(ByVal lngEstadoid As Long) As String
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)

      Try
         With oEstado
            .EstadoId = lngEstadoid

            If .FindByPK Then
               EstadoDesFind = .EstadoDes
            End If
         End With
      Catch ex As Exception
         Throw ex
      End Try
   End Function


   Private Function ComprobanteToString(ByVal oComp As clsComp) As String
      Dim strComprobante As String
      strComprobante = "CompId: " & oComp.CompId.ToString
      strComprobante &= "; Fecha: " & dtpFecha.Text
      strComprobante &= "; Moneda: " & MonedaDesFind(oComp.MonedaId)
      strComprobante &= "; Tipo: " & TipoCompDesFind(oComp.TipoCompId)
      strComprobante &= "; detalle1: " & oComp.EntregadoA
      strComprobante &= "; detalle2: " & oComp.PorConcepto
      strComprobante &= "; Estado: " & EstadoDesFind(oComp.EstadoId)
      Return strComprobante
   End Function

   Private Sub dtpFecha_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.TextChanged
      If dtpFecha.Tag <> dtpFecha.Text Then
         If IsDate(dtpFecha.Text) Then
            Call txtTipoCambioFind(ToDate(dtpFecha.Value))
            dtpFecha.Tag = dtpFecha.Text
         Else
            txtTipoCambio.Text = 0
         End If
      End If
   End Sub
End Class
