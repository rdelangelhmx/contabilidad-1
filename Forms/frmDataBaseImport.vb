Public Class frmDataBaseImport
   Inherits System.Windows.Forms.Form

   Private moComp As clsComp
   Private moCompOrg As clsComp
   Private moCompDes As clsComp
   Private moCompDetOrg As clsCompDet
   Private moCompDetDes As clsCompDet
   Private moCompPlanAddOrg As clsCompPlanAdd
   Private moCompPlanAddDes As clsCompPlanAdd
   Private moCompCentroCostoDetOrg As clsCompCentroCostoDet
   Private moCompCentroCostoDetDes As clsCompCentroCostoDet
   Private moFacturaOrg As clsFactura
   Private moFacturaDes As clsFactura
   Private moCompChequeOrg As clsCompCheque
   Private moCompChequeDes As clsCompCheque

   Private mlngEmpresaIdOrg As Long
   Private mlngGestionIdOrg As Long

   Private mintRowSel As Integer
   Private mintRowExport As Integer

   Private mstrServerOrg As String
   Private mstrUserOrg As String
   Private mstrPassOrg As String
   Private mstrDataBaseOrg As String
   Private mstrConnectStringOrg As String

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moDataTablePlan As DataTable

   Private moStopwatch As Stopwatch
   Private moTimeSpan As TimeSpan

   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboGestion As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboEmpresa As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents DataBaseOrg As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents DataBaseOrg1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Import1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Import As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents pbrMain As Janus.Windows.EditControls.UIProgressBar
   Friend WithEvents txtDataBaseOrg As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX

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
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataBaseImport))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.pbrMain = New Janus.Windows.EditControls.UIProgressBar
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtDataBaseOrg = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboGestion = New Janus.Windows.EditControls.UIComboBox
      Me.cboEmpresa = New Janus.Windows.EditControls.UIComboBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.DataBaseOrg1 = New Janus.Windows.UI.CommandBars.UICommand("DataBaseOrg")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Import1 = New Janus.Windows.UI.CommandBars.UICommand("Import")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.DataBaseOrg = New Janus.Windows.UI.CommandBars.UICommand("DataBaseOrg")
      Me.Import = New Janus.Windows.UI.CommandBars.UICommand("Import")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 303)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 303)
      Me.grdMain.TabIndex = 5
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.pbrMain)
      Me.uiBackground.Controls.Add(Me.grpMain)
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 5
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'pbrMain
      '
      Me.pbrMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.pbrMain.Location = New System.Drawing.Point(4, 388)
      Me.pbrMain.Name = "pbrMain"
      Me.pbrMain.ShowPercentage = True
      Me.pbrMain.Size = New System.Drawing.Size(744, 23)
      Me.pbrMain.TabIndex = 6
      Me.pbrMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtDataBaseOrg)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.cboGestion)
      Me.grpMain.Controls.Add(Me.cboEmpresa)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Location = New System.Drawing.Point(4, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(744, 44)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtDataBaseOrg
      '
      Me.txtDataBaseOrg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDataBaseOrg.Location = New System.Drawing.Point(80, 16)
      Me.txtDataBaseOrg.MaxLength = 255
      Me.txtDataBaseOrg.Name = "txtDataBaseOrg"
      Me.txtDataBaseOrg.ReadOnly = True
      Me.txtDataBaseOrg.Size = New System.Drawing.Size(176, 20)
      Me.txtDataBaseOrg.TabIndex = 1
      Me.txtDataBaseOrg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDataBaseOrg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label7.Location = New System.Drawing.Point(8, 20)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(68, 16)
      Me.Label7.TabIndex = 185
      Me.Label7.Text = "DB Origen"
      '
      'cboGestion
      '
      Me.cboGestion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.Location = New System.Drawing.Point(636, 16)
      Me.cboGestion.Name = "cboGestion"
      Me.cboGestion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboGestion.Size = New System.Drawing.Size(100, 20)
      Me.cboGestion.TabIndex = 3
      Me.cboGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboEmpresa
      '
      Me.cboEmpresa.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.Location = New System.Drawing.Point(328, 16)
      Me.cboEmpresa.Name = "cboEmpresa"
      Me.cboEmpresa.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEmpresa.Size = New System.Drawing.Size(240, 20)
      Me.cboEmpresa.TabIndex = 2
      Me.cboEmpresa.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label9.Location = New System.Drawing.Point(580, 20)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(52, 16)
      Me.Label9.TabIndex = 183
      Me.Label9.Text = "Gestión"
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label5.Location = New System.Drawing.Point(268, 20)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(56, 16)
      Me.Label5.TabIndex = 175
      Me.Label5.Text = "Empresa"
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
      ExplorerBarGroup1.ContainerHeight = 304
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 48)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 336)
      Me.ebrMain.TabIndex = 4
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
      Me.ilsMain.Images.SetKeyName(0, "Database (Add).ico")
      Me.ilsMain.Images.SetKeyName(1, "70.ICO")
      Me.ilsMain.Images.SetKeyName(2, "")
      Me.ilsMain.Images.SetKeyName(3, "")
      Me.ilsMain.Images.SetKeyName(4, "")
      Me.ilsMain.Images.SetKeyName(5, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ViewAll, Me.Print, Me.Exit2, Me.Refrescar, Me.DataBaseOrg, Me.Import})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("14565a15-ea74-408e-b698-fb1d6c9d5b6b")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.DataBaseOrg1, Me.Separator1, Me.Refrescar1, Me.Separator3, Me.Import1, Me.Separator7, Me.ViewAll1, Me.Separator4, Me.Print1, Me.Separator5, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(494, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'DataBaseOrg1
      '
      Me.DataBaseOrg1.Key = "DataBaseOrg"
      Me.DataBaseOrg1.Name = "DataBaseOrg1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Import1
      '
      Me.Import1.Key = "Import"
      Me.Import1.Name = "Import1"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
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
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 2
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
      '
      'Print
      '
      Me.Print.ImageIndex = 3
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 4
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 5
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
      '
      'DataBaseOrg
      '
      Me.DataBaseOrg.ImageIndex = 0
      Me.DataBaseOrg.Key = "DataBaseOrg"
      Me.DataBaseOrg.Name = "DataBaseOrg"
      Me.DataBaseOrg.Text = "BD Origen"
      Me.DataBaseOrg.ToolTipText = "Base de Datos Origen"
      '
      'Import
      '
      Me.Import.ImageIndex = 1
      Me.Import.Key = "Import"
      Me.Import.Name = "Import"
      Me.Import.Text = "Importar"
      Me.Import.ToolTipText = "Importar Información desde la Base de Datos Origen"
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
      'frmDataBaseImport
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmDataBaseImport"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Importar Información Desde Otra Base de Datos"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
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
         Case "DataBaseOrg"
            Call frmDataBaseOrgLoad()

         Case "Refrescar"
            Call grdMainLoad()

         Case "Import"
            If DataImport() Then
               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.IMPORTAR, ToStr(mintRowExport) & " de " & ToStr(mintRowSel) & " Registros Importados Exitosamente" & vbCrLf & "Tiempo Estimado " & moTimeSpan.ToString)
               MessageBox.Show(ToStr(mintRowExport) & " de " & ToStr(mintRowSel) & " Registros Importados Exitosamente" & vbCrLf & "Tiempo Estimado " & moTimeSpan.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmDataBaseImport_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmDataBaseImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ClearMemory()

        'mstrConnectStringOrg = "Provider=sqloledb;Data Source=(local);Initial Catalog=CONDOBOOld;User ID=sa;Password=sa;Current Language=us_english"
      'txtDataBaseOrg.Text = "(local).DelfinNetOld"

      'Call ComboLoad()
      'cboEmpresa.SelectedIndex = ListFindItem(cboEmpresa, 1)
      'cboGestion.SelectedIndex = ListFindItem(cboGestion, 75)
      'Call grdMainLoad()

      Me.Cursor = oCursor
   End Sub

   Private Sub frmDataBaseOrgLoad()
      Dim frm As New frmDataBaseOrgEmpresa

      With frm
         .ShowDialog()

         If .Changed Then
            mstrConnectStringOrg = .ConnectStringOrg
            txtDataBaseOrg.Text = .DataBaseOrg
            Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.CONSULTA, frm.Text & " " & .ConnectStringOrg & "-" & .DataBaseOrg)
            mlngEmpresaIdOrg = .EmpresaId
            mlngGestionIdOrg = .GestionId

            Call ComboLoad()
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub grdMainLoad()
      Try
         mlngEmpresaIdOrg = ListPosition(cboEmpresa, cboEmpresa.SelectedIndex)
         mlngGestionIdOrg = ListPosition(cboGestion, cboGestion.SelectedIndex)

         If FormCheck() Then
            moComp = New clsComp(mstrConnectStringOrg)

            With moComp
               .SelectFilter = clsComp.SelectFilters.GridImport
               .WhereFilter = clsComp.WhereFilters.Grid
               .OrderByFilter = clsComp.OrderByFilters.GridFecha
               .EmpresaId = mlngEmpresaIdOrg
               .GestionId = mlngGestionIdOrg

               If .Open() Then
                  grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
                  grdMain.RetrieveStructure()
                  Call grdMainInit()
               End If

               .CloseConection()
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If mstrConnectStringOrg = "" Then
         strMsg &= "Cadena de Conexión de la Base de Datos Origen Inválida" & vbCrLf
      End If

      If cboEmpresa.SelectedIndex = -1 Then
         strMsg &= "Empresa Inválida" & vbCrLf
      End If

      If cboGestion.SelectedIndex = -1 Then
         strMsg &= "Gestión Inválida" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function GridCheck() As Boolean
      Dim strMsg As String = String.Empty

      If grdMain.GetCheckedRows.Count <= 0 Then
         Throw New Exception("Debe Seleccionar al Menos un Registro")
         GridCheck = False
      End If

      If Not CompEstadoIdCheck(13) Then
         Throw New Exception("Existen Comprobantes con Estado Pendiente en Base de Datos Origen")
         GridCheck = False
      End If

      If Not CompDesbalanceadoCheck() Then
         Throw New Exception("Existen Comprobantes Sin Detalle o Fuera de Balance en Base de Datos Origen")
         GridCheck = False
      End If

      If Not CompDuplicadoCheck() Then
         Throw New Exception("Existen Números de Comprobante Duplicados")
         GridCheck = False
      End If

      If Not PlanCheck() Then
         Throw New Exception("Una o Mas Cuentas No Existen o Tienen Propiedades Diferentes en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not PlanAddCheck() Then
         Throw New Exception("Uno o Mas Analíticos Adicionales No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not CentroCostoCheck() Then
         Throw New Exception("Uno o Mas Centros de Costos No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not SucursalCheck() Then
         Throw New Exception("Una o Mas Sucursales No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not DosificaCheck() Then
         Throw New Exception("Una o Mas Dosificaciones No Existen en la Base de Datos Destino")
         GridCheck = False
      End If

      If Not FacturaOrgCheck() Then
         Throw New Exception("Existen Una o Mas Facturas Duplicadas en la Base de Datos Origen")
         GridCheck = False
      End If

      If Not FacturaDesCheck() Then
         Throw New Exception("Existen Una o Mas Facturas Duplicadas en la Base de Datos Destino")
         GridCheck = False
      End If

      GridCheck = True
   End Function

   Private Function CompEstadoIdCheck(ByVal lngEstadoId As Long) As Boolean
      CompEstadoIdCheck = True

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("EstadoId").Value) = lngEstadoId Then
               moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompId").Value), 0, ToLong(oRow.Cells("TipoCompId").Value), ToLong(oRow.Cells("CompNro").Value), "tblComp", ToLong(oRow.Cells("CompId").Value), "Estado Pendiente"))

               CompEstadoIdCheck = False
            End If
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function CompDesbalanceadoCheck() As Boolean
      Dim decDebeBs As Decimal
      Dim decHaberBs As Decimal
      Dim decDebeUs As Decimal
      Dim decHaberUs As Decimal

      CompDesbalanceadoCheck = True

      moCompDetOrg = New clsCompDet(mstrConnectStringOrg)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            If ToLong(oRow.Cells("EstadoId").Value) <> 12 Then
               decDebeBs = 0
               decHaberBs = 0
               decDebeUs = 0
               decHaberUs = 0

               With moCompDetOrg
                  .SelectFilter = clsCompDet.SelectFilters.All
                  .WhereFilter = clsCompDet.WhereFilters.CompId
                  .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
                  .CompId = ToLong(oRow.Cells("CompId").Value)

                  If .Open() Then
                     For Each oRowCompDet As DataRow In .DataSet.Tables(.TableName).Rows
                        decDebeBs += oRowCompDet("DebeBs")
                        decHaberBs += oRowCompDet("HaberBs")
                        decDebeUs += oRowCompDet("DebeUs")
                        decHaberUs += oRowCompDet("HaberUs")
                     Next
                  End If

                  If .DataSet.Tables(.TableName).Rows.Count = 0 Then
                     moDataTable.Rows.Add(GetRow(.CompId, 0, ToLong(oRow.Cells("TipoCompId").Value), ToLong(oRow.Cells("CompNro").Value), "tblComp", .CompId, "Comprobante Sin Detalle"))
                     CompDesbalanceadoCheck = False
                     'temp
                     'ElseIf (Math.Abs(decDebeBs - decHaberBs) > 0.05) Or (Math.Abs(decDebeUs - decHaberUs) > 0.05) Then
                     '   moDataTable.Rows.Add(GetRow(.CompId, 0, ToLong(oRow.Cells("TipoCompId").Value), ToLong(oRow.Cells("CompNro").Value), "tblComp", .CompId, "Comprobante Fuera de Balance"))
                     '   CompDesbalanceadoCheck = False
                     'End If
                  ElseIf (ToDecimalMinor(Math.Abs(decDebeBs - decHaberBs)) > 0) Or (ToDecimalMinor(Math.Abs(decDebeUs - decHaberUs)) > 0) Then
                     moDataTable.Rows.Add(GetRow(.CompId, 0, ToLong(oRow.Cells("TipoCompId").Value), ToLong(oRow.Cells("CompNro").Value), "tblComp", .CompId, "Comprobante Fuera de Balance"))
                     CompDesbalanceadoCheck = False
                  End If
               End With
            End If
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function CompDuplicadoCheck() As Boolean
      Dim boolFind As Boolean

      CompDuplicadoCheck = True

      moCompDes = New clsComp(clsAppInfo.ConnectString)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            For Each oRowFind As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
               boolFind = False

               If (oRow.Cells("CompNro").Value = oRowFind.Cells("CompNro").Value) _
                  And (oRow.Cells("TipoCompId").Value = oRowFind.Cells("TipoCompId").Value) _
                  And (oRow.Cells("CompId").Value <> oRowFind.Cells("CompId").Value) Then

                  boolFind = True
                  Exit For
               End If
            Next

            If boolFind Then
               moDataTable.Rows.Add(GetRow(ToLong(oRow.Cells("CompId").Value), 0, ToLong(oRow.Cells("TipoCompId").Value), ToLong(oRow.Cells("CompNro").Value), "tblComp", ToLong(oRow.Cells("CompId").Value), "Número de Comprobante Duplicado en Base de Datos Origen"))

               CompDuplicadoCheck = False
            End If

            With moCompDes
               .SelectFilter = clsComp.SelectFilters.All
               .WhereFilter = clsComp.WhereFilters.CompNro
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .TipoCompId = ToLong(oRow.Cells("TipoCompId").Value)
               .CompNro = ToLong(oRow.Cells("CompNro").Value)

               If .Find Then
                  moDataTable.Rows.Add(GetRow(.CompId, 0, .TipoCompId, .CompNro, .TableName, .CompId, "Número de Comprobante Duplicado en Base de Datos Destino"))

                  CompDuplicadoCheck = False
               End If
            End With
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function PlanCheck() As Boolean
      Dim oPlanDes As New clsPlan(clsAppInfo.ConnectString)

      PlanCheck = True

      moCompDetOrg = New clsCompDet(mstrConnectStringOrg)

      Try
         For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
            With moCompDetOrg
               .SelectFilter = clsCompDet.SelectFilters.CompIdPlan
               .WhereFilter = clsCompDet.WhereFilters.CompIdPlan
               .EmpresaId = ToLong(oRow.Cells("EmpresaId").Value)
               .CompId = ToLong(oRow.Cells("CompId").Value)

               If .Open() Then
                  For Each oRowCompDet As DataRow In .DataSet.Tables(.TableName).Rows
                     If Not IsDBNull(oRowCompDet("PlanPlanId")) Then
                        If Not moDataTablePlanCtaFind(ToStr(oRowCompDet("PlanCta"))) Then
                           moDataTablePlan.Rows.Add(GetRowPlan(oRowCompDet("CompDetId"), oRowCompDet("PlanPlanId"), oRowCompDet("PlanCta"), oRowCompDet("PlanDes"), oRowCompDet("EsAna"), oRowCompDet("TipoPlanId"), oRowCompDet("MonedaId"), oRowCompDet("TieneAnaAdd"), oRowCompDet("SucCCOId")))
                        End If

                     Else
                        moDataTable.Rows.Add(GetRow(ToLong(oRowCompDet("CompId")), ToLong(oRowCompDet("CompDetId")), 0, 0, "tblPlan", ToLong(oRowCompDet("CompDetPlanId")), "ID de Cuenta No Existe en tblPlan de la Base de Datos Origen"))
                        PlanCheck = False
                     End If
                  Next
               End If
            End With
         Next

         For Each oRow As DataRow In moDataTablePlan.Rows
            With oPlanDes
               .SelectFilter = clsPlan.SelectFilters.All
               .WhereFilter = clsPlan.WhereFilters.PlanCta
               .EmpresaId = clsAppInfo.EmpresaId
               .PlanCta = ToStr(oRow("PlanCtaOrg"))

               If .Find Then
                  oRow("PlanIdDes") = .PlanId

                  If oRow("EsAnaOrg") <> .EsAna Then
                     moDataTable.Rows.Add(GetRow(0, 0, 0, 0, .TableName, ToLong(oRow("PlanIdOrg")), ToStr(oRow("PlanCtaOrg")) & " - Nivel Analítico es Diferente en la Base de Datos Destino"))
                     PlanCheck = False
                  End If

                  If oRow("TipoPlanIdOrg") <> .TipoPlanId Then
                     moDataTable.Rows.Add(GetRow(0, 0, 0, 0, .TableName, ToLong(oRow("PlanIdOrg")), ToStr(oRow("PlanCtaOrg")) & " - Tipo de Cuenta Diferente en la Base de Datos Destino"))
                     PlanCheck = False
                  End If

                  If oRow("MonedaIdOrg") <> .MonedaId Then
                     moDataTable.Rows.Add(GetRow(0, 0, 0, 0, .TableName, ToLong(oRow("PlanIdOrg")), ToStr(oRow("PlanCtaOrg")) & " - Moneda de Cuenta Diferente en la Base de Datos Destino"))
                     PlanCheck = False
                  End If

                  If oRow("TieneAnaAddOrg") <> .TieneAnaAdd Then
                     moDataTable.Rows.Add(GetRow(0, 0, 0, 0, .TableName, ToLong(oRow("PlanIdOrg")), ToStr(oRow("PlanCtaOrg")) & " - Propiedad Analíticos Adicionales Diferente en la Base de Datos Destino"))
                     PlanCheck = False
                  End If

                  If oRow("SucCCOIdOrg") <> .SucCCOId Then
                     moDataTable.Rows.Add(GetRow(0, 0, 0, 0, .TableName, ToLong(oRow("PlanIdOrg")), ToStr(oRow("PlanCtaOrg")) & " - Propiedad Sucursal/CCO Diferente en la Base de Datos Destino"))
                     PlanCheck = False
                  End If

               Else
                  moDataTable.Rows.Add(GetRow(0, 0, 0, 0, .TableName, ToLong(oRow("PlanIdOrg")), ToStr(oRow("PlanCtaOrg")) & " " & ToStr(oRow("PlanDesOrg")) & " - No existe la Cuenta en la Base de Datos Destino"))
                  PlanCheck = False
               End If
            End With
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanDes.Dispose()
      End Try
   End Function

   Private Function PlanAddCheck() As Boolean
      Dim oCompPlanAddOrg As New clsCompPlanAdd(mstrConnectStringOrg)
      Dim oPlanAddDes As New clsPlanAdd(clsAppInfo.ConnectString)

      PlanAddCheck = True

      Try
         For Each oRow As DataRow In moDataTablePlan.Rows
            If ToBoolean(oRow("TieneAnaAddOrg")) = 1 Then
               With oCompPlanAddOrg
                  .SelectFilter = clsCompPlanAdd.SelectFilters.PlanAddIdDistinct
                  .WhereFilter = clsCompPlanAdd.WhereFilters.PlanAddIdDistinct
                  .OrderByFilter = clsCompPlanAdd.OrderByFilters.PlanCta
                  .EmpresaId = mlngEmpresaIdOrg
                  .GestionId = mlngGestionIdOrg
                  .PlanId = ToLong(oRow("PlanIdOrg"))

                  If .Open Then
                     For Each oRowCompPlanAdd As DataRow In .DataSet.Tables(.TableName).Rows
                        oPlanAddDes.SelectFilter = clsPlanAdd.SelectFilters.All
                        oPlanAddDes.WhereFilter = clsPlanAdd.WhereFilters.PlanAddCta
                        oPlanAddDes.EmpresaId = clsAppInfo.EmpresaId
                        oPlanAddDes.PlanId = ToLong(oRow("PlanIdDes"))
                        oPlanAddDes.PlanAddCta = ToStr(oRowCompPlanAdd("PlanAddCta"))

                        If Not oPlanAddDes.Find Then
                           moDataTable.Rows.Add(GetRow(0, 0, 0, 0, oPlanAddDes.TableName, ToLong(oRowCompPlanAdd("PlanAddId")), "Cuenta " & ToStr(oRow("PlanCtaOrg")) & " A.A. " & ToStr(oRowCompPlanAdd("PlanAddCta")) & " - Analítico Adicional No Existe en la Base de Datos Destino"))
                           PlanAddCheck = False
                        End If
                     Next
                  End If
               End With
            End If
         Next

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAddOrg.Dispose()
         oPlanAddDes.Dispose()
      End Try
   End Function

   Private Function CentroCostoCheck() As Boolean
      Dim oCentroCostoDes As New clsCentroCosto(clsAppInfo.ConnectString)

      CentroCostoCheck = True

      Try
         moCompDetOrg = New clsCompDet(mstrConnectStringOrg)

         With moCompDetOrg
            .SelectFilter = clsCompDet.SelectFilters.CentroCostoDistinct
            .WhereFilter = clsCompDet.WhereFilters.CentroCostoDistinct
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If ToLong(oRow("CentroCostoId")) > 0 Then
                     oCentroCostoDes.SelectFilter = clsCentroCosto.SelectFilters.All
                     oCentroCostoDes.WhereFilter = clsCentroCosto.WhereFilters.CentroCostoCod
                     oCentroCostoDes.EmpresaId = clsAppInfo.EmpresaId
                     oCentroCostoDes.CentroCostoCod = ToStr(oRow("CentroCostoCod"))

                     If Not oCentroCostoDes.Find Then
                        moDataTable.Rows.Add(GetRow(0, 0, 0, 0, oCentroCostoDes.TableName, ToLong(oRow("CentroCostoId")), ToStr(oRow("CentroCostoCod")) & " - Centro de Costo No Existe en la Base de Datos Destino"))
                        CentroCostoCheck = False

                     Else
                        If Not CentroCostoDetCheck(ToLong(oRow("CentroCostoId")), oCentroCostoDes.CentroCostoId, ToStr(oRow("CentroCostoCod"))) Then
                           CentroCostoCheck = False
                        End If
                     End If
                  End If
               Next
            End If
         End With

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function CentroCostoDetCheck(ByVal lngCentroCostoIdOrg As Long, ByVal lngCentroCostoIdDes As Long, ByVal strCentroCostoCod As String) As Boolean
      Dim oCompCentroCostoDetOrg As New clsCompCentroCostoDet(mstrConnectStringOrg)
      Dim oCentroCostoDetDes As New clsCentroCostoDet(clsAppInfo.ConnectString)

      CentroCostoDetCheck = True

      Try
         With oCompCentroCostoDetOrg
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.CentroCostoDetIdDistinct
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CentroCostoDetIdDistinct
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg
            .CentroCostoId = lngCentroCostoIdOrg

            If .Open Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  oCentroCostoDetDes.SelectFilter = clsCentroCostoDet.SelectFilters.All
                  oCentroCostoDetDes.WhereFilter = clsCentroCostoDet.WhereFilters.CentroCostoDetCod
                  oCentroCostoDetDes.EmpresaId = clsAppInfo.EmpresaId
                  oCentroCostoDetDes.CentroCostoId = lngCentroCostoIdDes
                  oCentroCostoDetDes.CentroCostoDetCod = ToStr(oRow("CentroCostoDetCod"))

                  If Not oCentroCostoDetDes.Find Then
                     moDataTable.Rows.Add(GetRow(0, 0, 0, 0, oCentroCostoDetDes.TableName, ToLong(oRow("CentroCostoDetId")), "C.C. " & strCentroCostoCod & " Act. " & ToStr(oRow("CentroCostoDetCod")) & " - Actividad de Centro de Costo No Existe en la Base de Datos Destino"))
                     CentroCostoDetCheck = False
                  End If
               Next
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDetOrg.Dispose()
         oCentroCostoDetDes.Dispose()
      End Try
   End Function

   Private Function SucursalCheck() As Boolean
      Dim oSucursalDes As New clsSucursal(clsAppInfo.ConnectString)

      SucursalCheck = True

      Try
         moCompDetOrg = New clsCompDet(mstrConnectStringOrg)

         With moCompDetOrg
            .SelectFilter = clsCompDet.SelectFilters.SucursalDistinct
            .WhereFilter = clsCompDet.WhereFilters.SucursalDistinct
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg

            If .Open Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If ToLong(oRow("SucursalId")) > 0 Then
                     oSucursalDes.SelectFilter = clsSucursal.SelectFilters.All
                     oSucursalDes.WhereFilter = clsSucursal.WhereFilters.SucursalCod
                     oSucursalDes.EmpresaId = clsAppInfo.EmpresaId
                     oSucursalDes.SucursalCod = ToStr(oRow("SucursalCod"))

                     If Not oSucursalDes.Find Then
                        moDataTable.Rows.Add(GetRow(0, 0, 0, 0, oSucursalDes.TableName, ToLong(oRow("SucursalId")), ToStr(oRow("SucursalCod")) & " - Sucursal No Existe en la Base de Datos Destino"))
                        SucursalCheck = False
                     End If
                  End If
               Next
            End If
         End With

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursalDes.Dispose()
      End Try
   End Function

   Private Function DosificaCheck() As Boolean
      Dim oFacturaOrg As New clsFactura(mstrConnectStringOrg)
      Dim oDosificaDes As New clsDosifica(clsAppInfo.ConnectString)

      DosificaCheck = True

      Try
         With oFacturaOrg
            .SelectFilter = clsFactura.SelectFilters.DosificaIdDistinct
            .WhereFilter = clsFactura.WhereFilters.DosificaIdDistinct
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg
            .TipoFacturaId = 1 'Facturas de Venta

            If .Open Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If ToLong(oRow("DosificaId")) > 0 Then
                     oDosificaDes.SelectFilter = clsDosifica.SelectFilters.All
                     oDosificaDes.WhereFilter = clsDosifica.WhereFilters.NroAutorizacion
                     oDosificaDes.EmpresaId = clsAppInfo.EmpresaId
                     oDosificaDes.SucursalId = ToLong(oRow("SucursalId"))
                     oDosificaDes.NroAutorizacion = ToStr(oRow("NroAutorizacion"))

                     If Not oDosificaDes.Find Then
                        moDataTable.Rows.Add(GetRow(0, 0, 0, 0, oDosificaDes.TableName, ToLong(oRow("DosificaId")), ToStr(oRow("NroAutorizacion")) & " - Dosificación No Existe en la Base de Datos Destino"))
                        DosificaCheck = False
                     End If
                  End If
               Next
            End If
         End With

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaOrg.Dispose()
         oDosificaDes.Dispose()
      End Try
   End Function

   Private Function FacturaOrgCheck() As Boolean
      Dim oFacturaOrg As New clsFactura(mstrConnectStringOrg)

      FacturaOrgCheck = True

      Try
         With oFacturaOrg
            .SelectFilter = clsFactura.SelectFilters.FacturaNroCount
            .WhereFilter = clsFactura.WhereFilters.FacturaNroCount
            .EmpresaId = mlngEmpresaIdOrg
            .GestionId = mlngGestionIdOrg
            .TipoFacturaId = 1 'Facturas de Venta

            If .Open Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRow(0, 0, 0, 0, .TableName, ToLong(oRow("FacturaNro")), "Nro. Autorización " & ToStr(oRow("NroAutorizacion")) & " - Nro. de Factura " & ToStr(oRow("FacturaCant")) & " Veces Duplicada en la Base de Datos Origen"))
                  FacturaOrgCheck = False
               Next
            End If
         End With

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaOrg.Dispose()
      End Try
   End Function

   Private Function FacturaDesCheck() As Boolean
      Dim oFacturaOrg As New clsFactura(mstrConnectStringOrg)
      Dim oFacturaDes As New clsFactura(clsAppInfo.ConnectString)

      FacturaDesCheck = True

      Try
         With oFacturaOrg
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.TipoFacturaId
            .EmpresaId = mlngEmpresaIdOrg
            .TipoFacturaId = 1 'Facturas de Venta

            If .Open Then
               For Each oRowFactura As DataRow In .DataSet.Tables(.TableName).Rows
                  oFacturaDes.SelectFilter = clsFactura.SelectFilters.All
                  oFacturaDes.WhereFilter = clsFactura.WhereFilters.FacturaNroDuplicada
                  oFacturaDes.EmpresaId = clsAppInfo.EmpresaId
                  oFacturaDes.NroAutorizacion = ToStr(oRowFactura("NroAutorizacion"))
                  oFacturaDes.FacturaNro = ToLong(oRowFactura("FacturaNro"))
                  oFacturaDes.TipoFacturaId = ToLong(oRowFactura("TipoFacturaId"))

                  If oFacturaDes.Find Then
                     moDataTable.Rows.Add(GetRow(0, 0, 0, 0, .TableName, ToLong(oRowFactura("FacturaNro")), "Nro. Autorización " & ToStr(oRowFactura("NroAutorizacion")) & " - Nro. de Factura Duplicada en la Base de Datos Destino"))
                     FacturaDesCheck = False
                  End If
               Next
            End If
         End With

         If moDataSet.Tables("Errores").Rows.Count() > 0 Then
            Dim frm As New frmDataBaseError
            frm.MdiParent = Me.MdiParent
            frm.DataObject = moDataSet
            frm.Show()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaOrg.Dispose()
         oFacturaDes.Dispose()
      End Try
   End Function

   Private Function DataImport() As Boolean
      Dim lngCompIdDes As Long

      moStopwatch = Stopwatch.StartNew()
      DataImport = False

      Try
         Call moDataSetInit()

         If GridCheck() Then
            If MessageBox.Show("¿Realmente Quiere Importar la Información Seleccionada?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               mintRowSel = grdMain.GetCheckedRows.Count
               mintRowExport = 0

               pbrMain.Minimum = 0
               pbrMain.Maximum = mintRowSel
               pbrMain.Value = 0
               pbrMain.Show()

               For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetCheckedRows
                  If CompAdd(ToLong(oRow.Cells("CompId").Value), lngCompIdDes) Then
                     If CompDetAdd(ToLong(oRow.Cells("CompId").Value), lngCompIdDes) Then
                        Call FacturaGralAdd(ToLong(oRow.Cells("CompId").Value), lngCompIdDes)

                        oRow.BeginEdit()
                        oRow.Cells("RowImport").Value = 1
                        oRow.EndEdit()

                        mintRowExport += 1

                        pbrMain.Value = mintRowExport
                        pbrMain.Update()
                     End If
                  End If
               Next

               If mintRowExport = mintRowSel Then
                  DataImport = True

               Else
                  If moDataSet.Tables("Errores").Rows.Count() > 0 Then
                     Dim frm As New frmDataBaseError
                     frm.MdiParent = Me.MdiParent
                     frm.DataObject = moDataSet
                     frm.Show()

                  Else
                     MessageBox.Show(ToStr(mintRowExport) & " de " & ToStr(mintRowSel) & " Registros Importados Exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               End If
            End If
         End If

         moTimeSpan = moStopwatch.Elapsed

      Catch exp As Exception
         moTimeSpan = moStopwatch.Elapsed

         MessageBox.Show(exp.Message & vbCrLf & "Tiempo Estimado " & moTimeSpan.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Function

   Private Function CompAdd(ByVal lngCompIdOrg As Long, ByRef lngCompIdDes As Long) As Boolean
      moCompOrg = New clsComp(mstrConnectStringOrg)
      moCompDes = New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         moCompOrg.CompId = lngCompIdOrg

         If moCompOrg.FindByPK Then
            With moCompDes
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .TipoCompId = moCompOrg.TipoCompId
               .CompNro = moCompOrg.CompNro 'Analizar
               .Fecha = ToDate(moCompOrg.Fecha)
               .MonedaId = moCompOrg.MonedaId
               .TipoCambio = moCompOrg.TipoCambio
               .EntregadoA = moCompOrg.EntregadoA
               .PorConcepto = moCompOrg.PorConcepto
               .DebeBs = moCompOrg.DebeBs
               .HaberBs = moCompOrg.HaberBs
               .DebeUs = moCompOrg.DebeUs
               .HaberUs = moCompOrg.HaberUs
               .PorIVA = moCompOrg.PorIVA
               .PorIT = moCompOrg.PorIT
               .PorITF = moCompOrg.PorITF
               .Automatico = moCompOrg.Automatico
               .Glosa = moCompOrg.Glosa
               .TipoNotaId = moCompOrg.TipoNotaId 'Analizar
               .NotaNro = moCompOrg.NotaNro 'Analizar
               .SinFac = moCompOrg.SinFac
               .ConFac = moCompOrg.ConFac
               .EstadoId = moCompOrg.EstadoId

               If .Insert() Then
                  lngCompIdDes = .CompId
                  CompAdd = True
               End If
            End With
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompIdOrg, 0, moCompOrg.TipoCompId, moCompOrg.CompNro, moCompOrg.TableName, lngCompIdOrg, exp.Message))

      End Try
   End Function

   Private Function CompDetAdd(ByVal lngCompIdOrg As Long, ByVal lngCompIdDes As Long) As Boolean
      Dim strPlanCtaOrg As String
      Dim lngPlanIdDes As Long

      CompDetAdd = False

      moCompDetOrg = New clsCompDet(mstrConnectStringOrg)
      moCompDetDes = New clsCompDet(clsAppInfo.ConnectString)

      Try
         moCompDetOrg.SelectFilter = clsCompDet.SelectFilters.All
         moCompDetOrg.WhereFilter = clsCompDet.WhereFilters.CompId
         moCompDetOrg.OrderByFilter = clsCompDet.OrderByFilters.CompDetId
         moCompDetOrg.EmpresaId = mlngEmpresaIdOrg
         moCompDetOrg.CompId = lngCompIdOrg

         If moCompDetOrg.Open() Then
            If moCompDetOrg.DataSet.Tables(moCompDetOrg.TableName).Rows.Count > 0 Then
               Do While moCompDetOrg.Read()
                  strPlanCtaOrg = PlanCtaFind(mstrConnectStringOrg, moCompDetOrg.PlanId)
                  lngPlanIdDes = PlanIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strPlanCtaOrg)

                  If lngPlanIdDes > 0 Then
                     With moCompDetDes
                        .CompId = lngCompIdDes
                        .EmpresaId = clsAppInfo.EmpresaId
                        .GestionId = clsAppInfo.GestionId
                        .TipoCompId = moCompDetOrg.TipoCompId
                        .Fecha = ToDate(moCompDetOrg.Fecha)
                        .PlanId = lngPlanIdDes
                        .CompDetDes = moCompDetOrg.CompDetDes
                        .SucursalId = moCompDetOrg.SucursalId
                        .CentroCostoId = moCompDetOrg.CentroCostoId
                        .MonedaId = moCompDetOrg.MonedaId
                        .DebeOrg = moCompDetOrg.DebeOrg
                        .DebeBs = moCompDetOrg.DebeBs
                        .DebeUs = moCompDetOrg.DebeUs
                        .HaberOrg = moCompDetOrg.HaberOrg
                        .HaberBs = moCompDetOrg.HaberBs
                        .HaberUs = moCompDetOrg.HaberUs
                        .Orden = moCompDetOrg.Orden
                        .Automatico = moCompDetOrg.Automatico
                        .EstadoId = moCompDetOrg.EstadoId

                        If .Insert() Then
                           Call CompPlanAddAdd(lngCompIdOrg, moCompDetOrg.CompDetId, lngCompIdDes, .CompDetId, lngPlanIdDes)
                           Call CompCentroCostoDetAdd(lngCompIdOrg, moCompDetOrg.CompDetId, lngCompIdDes, .CompDetId, lngPlanIdDes)
                           Call CompChequeAdd(lngCompIdOrg, moCompDetOrg.CompDetId, lngCompIdDes, .CompDetId, lngPlanIdDes)

                           If Not .Automatico Then
                              Call FacturaIndiAdd(lngCompIdOrg, moCompDetOrg.CompDetId, lngCompIdDes, .CompDetId)
                           End If

                           CompDetAdd = True
                        End If
                     End With
                  End If

                  moCompDetOrg.MoveNext()
               Loop

            Else
               CompDetAdd = True
            End If
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompIdOrg, moCompDetOrg.CompDetId, moCompOrg.TipoCompId, moCompOrg.CompNro, moCompDetOrg.TableName, moCompDetOrg.CompDetId, exp.Message))

      End Try
   End Function

   Private Function CompPlanAddAdd(ByVal lngCompIdOrg As Long, ByVal lngCompDetIdOrg As Long, ByVal lngCompIdDes As Long, ByVal lngCompDetIdDes As Long, ByVal lngPlanIdDes As Long) As Boolean
      Dim strPlanAddCtaOrg As String
      Dim lngPlanAddIdDes As Long

      CompPlanAddAdd = False

      moCompPlanAddOrg = New clsCompPlanAdd(mstrConnectStringOrg)
      moCompPlanAddDes = New clsCompPlanAdd(clsAppInfo.ConnectString)

      Try
         moCompPlanAddOrg.SelectFilter = clsCompPlanAdd.SelectFilters.All
         moCompPlanAddOrg.WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
         moCompPlanAddOrg.OrderByFilter = clsCompPlanAdd.OrderByFilters.CompPlanAddId
         moCompPlanAddOrg.EmpresaId = mlngEmpresaIdOrg
         moCompPlanAddOrg.CompId = lngCompIdOrg
         moCompPlanAddOrg.CompDetId = lngCompDetIdOrg

         If moCompPlanAddOrg.Open() Then
            Do While moCompPlanAddOrg.Read()
               strPlanAddCtaOrg = PlanAddCtaFind(mstrConnectStringOrg, moCompPlanAddOrg.PlanAddId)
               lngPlanAddIdDes = PlanAddIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, lngPlanIdDes, strPlanAddCtaOrg)

               If lngPlanAddIdDes > 0 Then
                  With moCompPlanAddDes
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .CompId = lngCompIdDes
                     .CompDetId = lngCompDetIdDes
                     .Fecha = ToDate(moCompPlanAddOrg.Fecha)
                     .PlanId = lngPlanIdDes
                     .MonedaId = moCompPlanAddOrg.MonedaId
                     .PlanAddId = lngPlanAddIdDes
                     .DebeOrg = moCompPlanAddOrg.DebeOrg
                     .HaberOrg = moCompPlanAddOrg.HaberOrg
                     .DebeBs = moCompPlanAddOrg.DebeBs
                     .HaberBs = moCompPlanAddOrg.HaberBs
                     .DebeUs = moCompPlanAddOrg.DebeUs
                     .HaberUs = moCompPlanAddOrg.HaberUs
                     .EstadoId = moCompPlanAddOrg.EstadoId

                     If .Insert() Then
                        CompPlanAddAdd = True
                     End If
                  End With
               End If

               moCompPlanAddOrg.MoveNext()
            Loop
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompIdOrg, lngCompDetIdOrg, moCompOrg.TipoCompId, moCompOrg.CompNro, moCompPlanAddOrg.TableName, moCompPlanAddOrg.CompPlanAddId, exp.Message))

      End Try
   End Function

   Private Function CompCentroCostoDetAdd(ByVal lngCompIdOrg As Long, ByVal lngCompDetIdOrg As Long, ByVal lngCompIdDes As Long, ByVal lngCompDetIdDes As Long, ByVal lngPlanIdDes As Long) As Boolean
      Dim strCentroCostoCodOrg As String
      Dim lngCentroCostoIdDes As Long
      Dim strCentroCostoDetCodOrg As String
      Dim lngCentroCostoDetIdDes As Long
      Dim boolCentroCostoFind As Boolean = False

      CompCentroCostoDetAdd = False

      moCompCentroCostoDetOrg = New clsCompCentroCostoDet(mstrConnectStringOrg)
      moCompCentroCostoDetDes = New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      Try
         moCompCentroCostoDetOrg.SelectFilter = clsCompCentroCostoDet.SelectFilters.All
         moCompCentroCostoDetOrg.WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
         moCompCentroCostoDetOrg.OrderByFilter = clsCompCentroCostoDet.OrderByFilters.CompCentroCostoDetId
         moCompCentroCostoDetOrg.EmpresaId = mlngEmpresaIdOrg
         moCompCentroCostoDetOrg.CompId = lngCompIdOrg
         moCompCentroCostoDetOrg.CompDetId = lngCompDetIdOrg

         If moCompCentroCostoDetOrg.Open() Then
            Do While moCompCentroCostoDetOrg.Read()
               If Not boolCentroCostoFind Then
                  strCentroCostoCodOrg = CentroCostoCodFind(mstrConnectStringOrg, moCompCentroCostoDetOrg.CentroCostoId)
                  lngCentroCostoIdDes = CentroCostoIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strCentroCostoCodOrg)

                  boolCentroCostoFind = True
               End If

               strCentroCostoDetCodOrg = CentroCostoDetCodFind(mstrConnectStringOrg, moCompCentroCostoDetOrg.CentroCostoDetId)
               lngCentroCostoDetIdDes = CentroCostoDetIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, lngCentroCostoIdDes, strCentroCostoDetCodOrg)

               If lngCentroCostoDetIdDes > 0 Then
                  With moCompCentroCostoDetDes
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .CompId = lngCompIdDes
                     .CompDetId = lngCompDetIdDes
                     .Fecha = ToDate(moCompCentroCostoDetOrg.Fecha)
                     .PlanId = lngPlanIdDes
                     .MonedaId = moCompCentroCostoDetOrg.MonedaId
                     .CentroCostoId = lngCentroCostoIdDes
                     .CentroCostoDetId = lngCentroCostoDetIdDes
                     .DebeOrg = moCompCentroCostoDetOrg.DebeOrg
                     .HaberOrg = moCompCentroCostoDetOrg.HaberOrg
                     .DebeBs = moCompCentroCostoDetOrg.DebeBs
                     .HaberBs = moCompCentroCostoDetOrg.HaberBs
                     .DebeUs = moCompCentroCostoDetOrg.DebeUs
                     .HaberUs = moCompCentroCostoDetOrg.HaberUs
                     .EstadoId = moCompCentroCostoDetOrg.EstadoId

                     If .Insert() Then
                        CompCentroCostoDetAdd = True
                     End If
                  End With
               End If

               moCompCentroCostoDetOrg.MoveNext()
            Loop
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompIdOrg, lngCompDetIdOrg, moCompOrg.TipoCompId, moCompOrg.CompNro, moCompCentroCostoDetOrg.TableName, moCompCentroCostoDetOrg.CompCentroCostoDetId, exp.Message))

      End Try
   End Function

   Private Function CompChequeAdd(ByVal lngCompIdOrg As Long, ByVal lngCompDetIdOrg As Long, ByVal lngCompIdDes As Long, ByVal lngCompDetIdDes As Long, ByVal lngPlanIdDes As Long) As Boolean
      Dim strBancoCtaOrg As String
      Dim lngChequeIdDes As Long

      CompChequeAdd = False

      moCompChequeOrg = New clsCompCheque(mstrConnectStringOrg)
      moCompChequeDes = New clsCompCheque(clsAppInfo.ConnectString)

      Try
         moCompChequeOrg.SelectFilter = clsCompCheque.SelectFilters.All
         moCompChequeOrg.WhereFilter = clsCompCheque.WhereFilters.CompDetId
         moCompChequeOrg.OrderByFilter = clsCompCheque.OrderByFilters.CompChequeId
         moCompChequeOrg.EmpresaId = mlngEmpresaIdOrg
         moCompChequeOrg.CompId = lngCompIdOrg
         moCompChequeOrg.CompDetId = lngCompDetIdOrg

         If moCompChequeOrg.Open() Then
            Do While moCompChequeOrg.Read()
               strBancoCtaOrg = ChequeCtaFind(mstrConnectStringOrg, moCompChequeOrg.ChequeId)
               lngChequeIdDes = ChequeIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, lngPlanIdDes, strBancoCtaOrg)

               If lngChequeIdDes > 0 Then
                  With moCompChequeDes
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .CompId = lngCompIdDes
                     .CompDetId = lngCompDetIdDes
                     .PlanId = lngPlanIdDes
                     .ChequeId = lngChequeIdDes
                     .Fecha = ToDate(moCompChequeOrg.Fecha)
                     .ChequeNro = moCompChequeOrg.ChequeNro
                     .ChequeDes = moCompChequeOrg.ChequeDes
                     .ChequeMonto = moCompChequeOrg.ChequeMonto
                     .EstadoId = moCompChequeOrg.EstadoId

                     If .Insert() Then
                        CompChequeAdd = True
                     End If
                  End With
               End If

               moCompChequeOrg.MoveNext()
            Loop
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompIdOrg, lngCompDetIdOrg, moCompOrg.TipoCompId, moCompOrg.CompNro, moCompChequeOrg.TableName, moCompChequeOrg.CompChequeId, exp.Message))

      End Try
   End Function

   Private Function FacturaIndiAdd(ByVal lngCompIdOrg As Long, ByVal lngCompDetIdOrg As Long, ByVal lngCompIdDes As Long, ByVal lngCompDetIdDes As Long) As Boolean
      Dim strSucursalCodOrg As String
      Dim lngSucursalIdDes As Long
      Dim lngDosificaIdDes As Long

      FacturaIndiAdd = False

      moFacturaOrg = New clsFactura(mstrConnectStringOrg)
      moFacturaDes = New clsFactura(clsAppInfo.ConnectString)

      Try
         moFacturaOrg.SelectFilter = clsFactura.SelectFilters.All
         moFacturaOrg.WhereFilter = clsFactura.WhereFilters.CompDetId
         moFacturaOrg.OrderByFilter = clsFactura.OrderByFilters.FacturaId
         moFacturaOrg.EmpresaId = mlngEmpresaIdOrg
         moFacturaOrg.CompId = lngCompIdOrg
         moFacturaOrg.CompDetId = lngCompDetIdOrg

         If moFacturaOrg.Open() Then
            Do While moFacturaOrg.Read()
               strSucursalCodOrg = SucursalCodFind(mstrConnectStringOrg, moFacturaOrg.SucursalId)
               lngSucursalIdDes = SucursalIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strSucursalCodOrg)

               If moFacturaOrg.TipoFacturaId = 1 Then 'Solo Facturas de Ventas
                  lngDosificaIdDes = DosificaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, lngSucursalIdDes, moFacturaOrg.NroAutorizacion)
               End If

               If ((moFacturaOrg.TipoFacturaId = 1) And (lngSucursalIdDes > 0) And (lngDosificaIdDes > 0)) Or (moFacturaOrg.TipoFacturaId = 2) Then
                  With moFacturaDes
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .MesId = moFacturaOrg.MesId
                     .SucursalId = lngSucursalIdDes
                     .DosificaId = lngDosificaIdDes
                     .TipoCompId = moFacturaOrg.TipoCompId
                     .CompId = lngCompIdDes
                     .CompDetId = lngCompDetIdDes
                     .TipoFacturaId = moFacturaOrg.TipoFacturaId
                     .FacturaFecha = ToDate(moFacturaOrg.FacturaFecha)
                     .FacturaNro = moFacturaOrg.FacturaNro
                     .FacturaMonto = moFacturaOrg.FacturaMonto
                     .RegRUCId = 0
                     .NroRUC = moFacturaOrg.NroRUC
                     .RegRUCDes = moFacturaOrg.RegRUCDes
                     .NroAutorizacion = moFacturaOrg.NroAutorizacion
                     .CodControl = moFacturaOrg.CodControl
                     .IVA = moFacturaOrg.IVA
                     .IceIehd = moFacturaOrg.IceIehd
                     .Exento = moFacturaOrg.Exento
                     .Descuento = moFacturaOrg.Descuento
                     .Recargo = moFacturaOrg.Recargo
                     .FacturaObs = moFacturaOrg.FacturaObs
                     .EstadoId = moFacturaOrg.EstadoId

                     If .InsertAll Then
                        FacturaIndiAdd = True
                     End If
                  End With
               End If

               moFacturaOrg.MoveNext()
            Loop
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompIdOrg, lngCompDetIdOrg, moCompOrg.TipoCompId, moCompOrg.CompNro, moFacturaOrg.TableName, moFacturaOrg.FacturaId, exp.Message))

      End Try
   End Function

   Private Function FacturaGralAdd(ByVal lngCompIdOrg As Long, ByVal lngCompIdDes As Long) As Boolean
      Dim strSucursalCodOrg As String
      Dim lngSucursalIdDes As Long
      Dim lngDosificaIdDes As Long

      FacturaGralAdd = False

      moFacturaOrg = New clsFactura(mstrConnectStringOrg)
      moFacturaDes = New clsFactura(clsAppInfo.ConnectString)

      Try
         moFacturaOrg.SelectFilter = clsFactura.SelectFilters.All
         moFacturaOrg.WhereFilter = clsFactura.WhereFilters.CompDetId
         moFacturaOrg.OrderByFilter = clsFactura.OrderByFilters.FacturaId
         moFacturaOrg.EmpresaId = mlngEmpresaIdOrg
         moFacturaOrg.CompId = lngCompIdOrg
         moFacturaOrg.CompDetId = 0

         If moFacturaOrg.Open() Then
            Do While moFacturaOrg.Read()
               strSucursalCodOrg = SucursalCodFind(mstrConnectStringOrg, moFacturaOrg.SucursalId)
               lngSucursalIdDes = SucursalIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, strSucursalCodOrg)

               If moFacturaOrg.TipoFacturaId = 1 Then 'Solo Facturas de Ventas
                  lngDosificaIdDes = DosificaIdFind(clsAppInfo.ConnectString, clsAppInfo.EmpresaId, lngSucursalIdDes, moFacturaOrg.NroAutorizacion)
               End If

               If ((moFacturaOrg.TipoFacturaId = 1) And (lngSucursalIdDes > 0) And (lngDosificaIdDes > 0)) Or (moFacturaOrg.TipoFacturaId = 2) Then
                  With moFacturaDes
                     .EmpresaId = clsAppInfo.EmpresaId
                     .GestionId = clsAppInfo.GestionId
                     .MesId = moFacturaOrg.MesId
                     .SucursalId = lngSucursalIdDes
                     .DosificaId = lngDosificaIdDes
                     .TipoCompId = moFacturaOrg.TipoCompId
                     .CompId = lngCompIdDes
                     .CompDetId = moFacturaOrg.CompDetId
                     .TipoFacturaId = moFacturaOrg.TipoFacturaId
                     .FacturaFecha = ToDate(moFacturaOrg.FacturaFecha)
                     .FacturaNro = moFacturaOrg.FacturaNro
                     .FacturaMonto = moFacturaOrg.FacturaMonto
                     .RegRUCId = 0
                     .NroRUC = moFacturaOrg.NroRUC
                     .RegRUCDes = moFacturaOrg.RegRUCDes
                     .NroAutorizacion = moFacturaOrg.NroAutorizacion
                     .CodControl = moFacturaOrg.CodControl
                     .IVA = moFacturaOrg.IVA
                     .IceIehd = moFacturaOrg.IceIehd
                     .Exento = moFacturaOrg.Exento
                     .Descuento = moFacturaOrg.Descuento
                     .Recargo = moFacturaOrg.Recargo
                     .FacturaObs = moFacturaOrg.FacturaObs
                     .EstadoId = moFacturaOrg.EstadoId

                     If .InsertAll Then
                        FacturaGralAdd = True
                     End If
                  End With
               End If

               moFacturaOrg.MoveNext()
            Loop
         End If

      Catch exp As Exception
         moDataTable.Rows.Add(GetRow(lngCompIdOrg, 0, moCompOrg.TipoCompId, moCompOrg.CompNro, moFacturaOrg.TableName, moFacturaOrg.FacturaId, exp.Message))

      End Try
   End Function

   Private Function PlanCtaFind(ByVal strConnectString As String, ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(strConnectString)

      PlanCtaFind = ""

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanCtaFind = .PlanCta
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function PlanIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strPlanCta As String) As Long
      Dim oPlan As New clsPlan(strConnectString)

      PlanIdFind = 0

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanCta
            .EmpresaId = lngEmpresaId
            .PlanCta = strPlanCta

            If .Find Then
               PlanIdFind = .PlanId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function PlanAddCtaFind(ByVal strConnectString As String, ByVal lngPlanAddId As Long) As String
      Dim oPlanAdd As New clsPlanAdd(strConnectString)

      PlanAddCtaFind = ""

      Try
         With oPlanAdd
            .PlanAddId = lngPlanAddId

            If .FindByPK Then
               PlanAddCtaFind = .PlanAddCta
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanAdd.Dispose()

      End Try
   End Function

   Private Function PlanAddIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngPlanId As Long, ByVal strPlanAddCta As String) As Long
      Dim oPlanAdd As New clsPlanAdd(strConnectString)

      PlanAddIdFind = 0

      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.All
            .WhereFilter = clsPlanAdd.WhereFilters.PlanAddCta
            .EmpresaId = lngEmpresaId
            .PlanId = lngPlanId
            .PlanAddCta = strPlanAddCta

            If .Find Then
               PlanAddIdFind = .PlanAddId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanAdd.Dispose()

      End Try
   End Function

   Private Function CentroCostoCodFind(ByVal strConnectString As String, ByVal lngCentroCostoId As Long) As String
      Dim oCentroCosto As New clsCentroCosto(strConnectString)

      CentroCostoCodFind = ""

      Try
         With oCentroCosto
            .CentroCostoId = lngCentroCostoId

            If .FindByPK Then
               CentroCostoCodFind = .CentroCostoCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()

      End Try
   End Function

   Private Function CentroCostoIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strCentroCostoCod As String) As Long
      Dim oCentroCosto As New clsCentroCosto(strConnectString)

      CentroCostoIdFind = 0

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.All
            .WhereFilter = clsCentroCosto.WhereFilters.CentroCostoCod
            .EmpresaId = lngEmpresaId
            .CentroCostoCod = strCentroCostoCod

            If .Find Then
               CentroCostoIdFind = .CentroCostoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()

      End Try
   End Function

   Private Function CentroCostoDetCodFind(ByVal strConnectString As String, ByVal lngCentroCostoDetId As Long) As String
      Dim oCentroCostoDet As New clsCentroCostoDet(strConnectString)

      CentroCostoDetCodFind = ""

      Try
         With oCentroCostoDet
            .CentroCostoDetId = lngCentroCostoDetId

            If .FindByPK Then
               CentroCostoDetCodFind = .CentroCostoDetCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CentroCostoDetIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngCentroCostoId As Long, ByVal strCentroCostoDetCod As String) As Long
      Dim oCentroCostoDet As New clsCentroCostoDet(strConnectString)

      CentroCostoDetIdFind = 0

      Try
         With oCentroCostoDet
            .SelectFilter = clsCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCentroCostoDet.WhereFilters.CentroCostoDetCod
            .EmpresaId = lngEmpresaId
            .CentroCostoId = lngCentroCostoId
            .CentroCostoDetCod = strCentroCostoDetCod

            If .Find Then
               CentroCostoDetIdFind = .CentroCostoDetId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function SucursalCodFind(ByVal strConnectString As String, ByVal lngSucursalId As Long) As String
      Dim oSucursal As New clsSucursal(strConnectString)

      SucursalCodFind = ""

      Try
         With oSucursal
            .SucursalId = lngSucursalId

            If .FindByPK Then
               SucursalCodFind = .SucursalCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()

      End Try
   End Function

   Private Function SucursalIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal strSucursalCod As String) As Long
      Dim oSucursal As New clsSucursal(strConnectString)

      SucursalIdFind = 0

      Try
         With oSucursal
            .SelectFilter = clsSucursal.SelectFilters.All
            .WhereFilter = clsSucursal.WhereFilters.SucursalCod
            .EmpresaId = lngEmpresaId
            .SucursalCod = strSucursalCod

            If .Find Then
               SucursalIdFind = .SucursalId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucursal.Dispose()

      End Try
   End Function

   Private Function ChequeCtaFind(ByVal strConnectString As String, ByVal lngChequeId As Long) As String
      Dim oCheque As New clsCheque(strConnectString)

      ChequeCtaFind = ""

      Try
         With oCheque
            .ChequeId = lngChequeId

            If .FindByPK Then
               ChequeCtaFind = .BancoCta
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCheque.Dispose()

      End Try
   End Function

   Private Function ChequeIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngPlanId As Long, ByVal strBancoCta As String) As Long
      Dim oCheque As New clsCheque(strConnectString)

      ChequeIdFind = 0

      Try
         With oCheque
            .SelectFilter = clsCheque.SelectFilters.All
            .WhereFilter = clsCheque.WhereFilters.BancoCta
            .EmpresaId = lngEmpresaId
            .PlanId = lngPlanId
            .BancoCta = strBancoCta

            If .Find Then
               ChequeIdFind = .ChequeId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCheque.Dispose()

      End Try
   End Function

   Private Function DosificaIdFind(ByVal strConnectString As String, ByVal lngEmpresaId As Long, ByVal lngSucursalId As Long, ByVal strNroAutorizacion As String) As Long
      Dim oDosifica As New clsDosifica(strConnectString)

      DosificaIdFind = 0

      Try
         With oDosifica
            .SelectFilter = clsDosifica.SelectFilters.All
            .WhereFilter = clsDosifica.WhereFilters.NroAutorizacion
            .EmpresaId = lngEmpresaId
            .SucursalId = lngSucursalId
            .NroAutorizacion = strNroAutorizacion

            If .Find Then
               DosificaIdFind = .DosificaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosifica.Dispose()

      End Try
   End Function

   Private Sub ComboLoad()
      Call cboEmpresaLoad()
   End Sub

   Private Sub cboEmpresaLoad()
      Dim oEmpresa As New clsEmpresa(mstrConnectStringOrg)
      Dim oItem As clsListItem

      cboEmpresa.Items.Clear()
      cboEmpresa.Text = ""

      Try
         With oEmpresa
            .SelectFilter = clsEmpresa.SelectFilters.ListBox
            .OrderByFilter = clsEmpresa.OrderByFilters.EmpresaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.EmpresaId, .EmpresaDes)

                  cboEmpresa.Items.Add(oItem)
                  .MoveNext()
               Loop

               cboEmpresa.SelectedIndex = ListFindItem(cboEmpresa, mlngEmpresaIdOrg)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboGestionLoad(ByVal lngEmpresaId As Long)
      Dim oGestion As New clsGestion(mstrConnectStringOrg)
      Dim oItem As clsListItem

      cboGestion.Items.Clear()
      cboGestion.Text = ""

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.EmpresaId
            .OrderByFilter = clsGestion.OrderByFilters.Gestion

            .EmpresaId = lngEmpresaId
            .EstadoId = 11

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.GestionId, ToStr(.Gestion))

                  cboGestion.Items.Add(oItem)
                  .MoveNext()
               Loop

               cboGestion.SelectedIndex = ListFindItem(cboGestion, mlngGestionIdOrg)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add("Errores")
      moDataTablePlan = moDataSet.Tables.Add("Plan")

      moDataTable.Columns.Add("CompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCompId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("CompNro", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TablaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("DocumentoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("ErrorDes", Type.GetType("System.String"))

      moDataTablePlan.Columns.Add("CompDetIdOrg", Type.GetType("System.Int32"))
      moDataTablePlan.Columns.Add("PlanIdOrg", Type.GetType("System.Int32"))
      moDataTablePlan.Columns.Add("PlanCtaOrg", Type.GetType("System.String"))
      moDataTablePlan.Columns.Add("PlanDesOrg", Type.GetType("System.String"))
      moDataTablePlan.Columns.Add("EsAnaOrg", Type.GetType("System.Byte"))
      moDataTablePlan.Columns.Add("TipoPlanIdOrg", Type.GetType("System.Int32"))
      moDataTablePlan.Columns.Add("MonedaIdOrg", Type.GetType("System.Int32"))
      moDataTablePlan.Columns.Add("TieneAnaAddOrg", Type.GetType("System.Byte"))
      moDataTablePlan.Columns.Add("SucCCOIdOrg", Type.GetType("System.Int32"))
      moDataTablePlan.Columns.Add("PlanIdDes", Type.GetType("System.Int32"))
   End Sub

   Private Function GetRow(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngTipoCompId As Long, ByVal lngCompNro As Long, _
                           ByVal strTablaDes As String, ByVal lngDocumentoId As Long, ByVal strErrorDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("CompId") = lngCompId
      oRow("CompDetId") = lngCompDetId
      oRow("TipoCompId") = lngTipoCompId
      oRow("CompNro") = lngCompNro
      oRow("TablaDes") = strTablaDes
      oRow("DocumentoId") = lngDocumentoId
      oRow("ErrorDes") = strErrorDes

      Return oRow
   End Function

   Private Function GetRowPlan(ByVal lngCompDetIdOrg As Long, ByVal lngPlanIdOrg As Long, ByVal strPlanCtaOrg As String, ByVal strPlanDesOrg As String, ByVal bytEsAnaOrg As Byte, _
                              ByVal lngTipoPlanIdOrg As Long, ByVal lngMonedaIdOrg As Long, ByVal bytTieneAnaAddOrg As Byte, ByVal lngSucCCOIdOrg As Long) As DataRow
      Dim oRow As DataRow
      oRow = moDataTablePlan.NewRow

      oRow("CompDetIdOrg") = lngCompDetIdOrg
      oRow("PlanIdOrg") = lngPlanIdOrg
      oRow("PlanCtaOrg") = strPlanCtaOrg
      oRow("PlanDesOrg") = strPlanDesOrg
      oRow("EsAnaOrg") = bytEsAnaOrg
      oRow("TipoPlanIdOrg") = lngTipoPlanIdOrg
      oRow("MonedaIdOrg") = lngMonedaIdOrg
      oRow("TieneAnaAddOrg") = bytTieneAnaAddOrg
      oRow("SucCCOIdOrg") = lngSucCCOIdOrg

      Return oRow
   End Function

   Private Function moDataTablePlanCtaFind(ByVal strPlanCta As String) As Boolean
      moDataTablePlanCtaFind = False

      For Each oRow As DataRow In moDataTablePlan.Rows
         If ToStr(oRow("PlanCtaOrg")) = strPlanCta Then
            Return True
         End If
      Next
   End Function

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

   Private Sub PrintReport()
      Dim rpt As New rptComp

      rpt.DataSource = GetDataView(moComp.DataSet.Tables(moComp.TableName))

      rpt.lblTitle.Text = "Listado de Comprobantes"
      rpt.Document.Name = "Listado de Comprobantes"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Comprobantes"

         .RootTable.Columns("Sel").Width = 50
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").ActAsSelector = True

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("GestionId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 100
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo"
         .RootTable.Columns("TipoCompDes").Width = 100
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNro").Caption = "Número"
         .RootTable.Columns("CompNro").Width = 100
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCambio").Caption = "Tipo Cambio"
         .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
         .RootTable.Columns("TipoCambio").Width = 100
         .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("DebeBs").Caption = "Monto Bs"
         .RootTable.Columns("DebeBs").FormatString = DecimalMask()
         .RootTable.Columns("DebeBs").Width = 100
         .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("DebeUs").Caption = "Monto $us"
         .RootTable.Columns("DebeUs").FormatString = DecimalMask()
         .RootTable.Columns("DebeUs").Width = 100
         .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EntregadoA").Caption = "Detalle 1"
         .RootTable.Columns("EntregadoA").Width = 100
         .RootTable.Columns("EntregadoA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EntregadoA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PorConcepto").Caption = "Detalle 2"
         .RootTable.Columns("PorConcepto").Width = 100
         .RootTable.Columns("PorConcepto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PorConcepto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoNotaId").Visible = False

         .RootTable.Columns("TipoNotaDes").Caption = "Tipo Nota"
         .RootTable.Columns("TipoNotaDes").Width = 100
         .RootTable.Columns("TipoNotaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoNotaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NotaNro").Caption = "Nro Nota"
         .RootTable.Columns("NotaNro").Width = 100
         .RootTable.Columns("NotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoAsientoId").Visible = False

         .RootTable.Columns("TipoAsientoDes").Caption = "Asiento"
         .RootTable.Columns("TipoAsientoDes").Width = 100
         .RootTable.Columns("TipoAsientoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoAsientoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("RowImport").Caption = "Importado"
         .RootTable.Columns("RowImport").Width = 100
         .RootTable.Columns("RowImport").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("RowImport").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 12)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 11)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 10)
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

   Private Sub cboEmpresa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEmpresa.SelectedIndexChanged
      If cboEmpresa.Tag <> cboEmpresa.Text Then
         cboEmpresa.Tag = cboEmpresa.Text

         Call cboGestionLoad(ListPosition(cboEmpresa, cboEmpresa.SelectedIndex))
      End If
   End Sub

   Private Sub frmDataBaseImport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmDataBaseImport_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

End Class
