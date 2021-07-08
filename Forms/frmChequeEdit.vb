Public Class frmChequeEdit
   Inherits System.Windows.Forms.Form

   Private moCheque As clsCheque
   Private moChequeDet As clsChequeDet

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditGrid As Boolean

   Friend WithEvents Design1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Design As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ebrChequeDet As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdChequeDet As Janus.Windows.GridEX.GridEX
   Friend WithEvents mnuChequeDet As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNew As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
   Private mlngID As Long

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

   WriteOnly Property DataObject() As clsCheque
      Set(ByVal Value As clsCheque)
         moCheque = Value
      End Set
   End Property

#Region " Windows Form Designer generated code "

   Public Sub New()
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()

      'Add any initialization after the InitializeComponent() call

   End Sub

   'Form overrides dispose to clean up the component list.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtChequeId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtBancoCta As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents cboBanco As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdChequeDet = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrChequeDet = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboBanco = New Janus.Windows.EditControls.UIComboBox
      Me.txtBancoCta = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtChequeId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Design1 = New Janus.Windows.UI.CommandBars.UICommand("Design")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Design = New Janus.Windows.UI.CommandBars.UICommand("Design")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.mnuChequeDet = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
      Me.mnuNew = New System.Windows.Forms.MenuItem
      Me.mnuEdit = New System.Windows.Forms.MenuItem
      Me.mnuDelete = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdChequeDet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.ebrChequeDet, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrChequeDet.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdChequeDet)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(455, 97)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdChequeDet
      '
      Me.grdChequeDet.AllowCardSizing = False
      Me.grdChequeDet.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdChequeDet.AlternatingColors = True
      Me.grdChequeDet.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdChequeDet.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdChequeDet.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdChequeDet.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdChequeDet.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdChequeDet.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdChequeDet.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdChequeDet.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdChequeDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdChequeDet.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdChequeDet.GroupByBoxVisible = False
      Me.grdChequeDet.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdChequeDet.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdChequeDet.Location = New System.Drawing.Point(0, 0)
      Me.grdChequeDet.Name = "grdChequeDet"
      Me.grdChequeDet.RecordNavigator = True
      Me.grdChequeDet.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdChequeDet.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdChequeDet.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdChequeDet.Size = New System.Drawing.Size(455, 97)
      Me.grdChequeDet.TabIndex = 14
      Me.grdChequeDet.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdChequeDet.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdChequeDet.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdChequeDet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.ebrChequeDet)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(485, 281)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'ebrChequeDet
      '
      Me.ebrChequeDet.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrChequeDet.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 98
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrChequeDet.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrChequeDet.GroupSeparation = 4
      Me.ebrChequeDet.Location = New System.Drawing.Point(9, 144)
      Me.ebrChequeDet.Name = "ebrChequeDet"
      Me.ebrChequeDet.Size = New System.Drawing.Size(471, 130)
      Me.ebrChequeDet.TabIndex = 161
      Me.ebrChequeDet.Text = "ExplorerBar2"
      Me.ebrChequeDet.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrChequeDet.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrChequeDet.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrChequeDet.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboPlan)
      Me.grpMain.Controls.Add(Me.cboBanco)
      Me.grpMain.Controls.Add(Me.txtBancoCta)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtChequeId)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label14)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(472, 140)
      Me.grpMain.TabIndex = 160
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboPlan
      '
      cboPlan_DesignTimeLayout.LayoutString = resources.GetString("cboPlan_DesignTimeLayout.LayoutString")
      Me.cboPlan.DesignTimeLayout = cboPlan_DesignTimeLayout
      Me.cboPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlan.Location = New System.Drawing.Point(116, 64)
      Me.cboPlan.Name = "cboPlan"
      Me.cboPlan.SelectedIndex = -1
      Me.cboPlan.SelectedItem = Nothing
      Me.cboPlan.Size = New System.Drawing.Size(348, 20)
      Me.cboPlan.TabIndex = 2
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboBanco
      '
      Me.cboBanco.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboBanco.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboBanco.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboBanco.Location = New System.Drawing.Point(116, 88)
      Me.cboBanco.Name = "cboBanco"
      Me.cboBanco.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboBanco.Size = New System.Drawing.Size(348, 20)
      Me.cboBanco.TabIndex = 3
      Me.cboBanco.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtBancoCta
      '
      Me.txtBancoCta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtBancoCta.Location = New System.Drawing.Point(116, 112)
      Me.txtBancoCta.MaxLength = 50
      Me.txtBancoCta.Name = "txtBancoCta"
      Me.txtBancoCta.Size = New System.Drawing.Size(124, 20)
      Me.txtBancoCta.TabIndex = 4
      Me.txtBancoCta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtBancoCta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(116, 40)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(348, 20)
      Me.txtEmpresaId.TabIndex = 1
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtChequeId
      '
      Me.txtChequeId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeId.Location = New System.Drawing.Point(116, 16)
      Me.txtChequeId.Name = "txtChequeId"
      Me.txtChequeId.ReadOnly = True
      Me.txtChequeId.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeId.TabIndex = 0
      Me.txtChequeId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 92)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 189
      Me.Label9.Text = "Banco"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 44)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 188
      Me.Label10.Text = "Empresa"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 68)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(104, 16)
      Me.Label11.TabIndex = 187
      Me.Label11.Text = "Cuenta"
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(8, 116)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(104, 16)
      Me.Label14.TabIndex = 185
      Me.Label14.Text = "Cuenta Banco"
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 20)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 184
      Me.Label15.Text = "ID"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      Me.ilsMain.Images.SetKeyName(2, "1377821163_1444.ico")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Design})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("feeb061d-8c44-493e-b717-3618014c7169")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Design1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(228, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Design1
      '
      Me.Design1.Key = "Design"
      Me.Design1.Name = "Design1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Save
      '
      Me.Save.ImageIndex = 0
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.Text = "Guardar"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 1
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Design
      '
      Me.Design.ImageIndex = 2
      Me.Design.Key = "Design"
      Me.Design.Name = "Design"
      Me.Design.Text = "Diseño"
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
      Me.TopRebar1.Size = New System.Drawing.Size(485, 28)
      '
      'mnuChequeDet
      '
      Me.mnuChequeDet.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuNew, Me.mnuEdit, Me.mnuDelete})
      '
      'mnuShow
      '
      Me.mnuShow.Index = 0
      Me.mnuShow.Text = "Consultar"
      '
      'mnuNew
      '
      Me.mnuNew.Index = 1
      Me.mnuNew.Text = "Nuevo"
      '
      'mnuEdit
      '
      Me.mnuEdit.Index = 2
      Me.mnuEdit.Text = "Editar"
      '
      'mnuDelete
      '
      Me.mnuDelete.Index = 3
      Me.mnuDelete.Text = "Eliminar"
      '
      'frmChequeEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(485, 309)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmChequeEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Cheque Edit"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdChequeDet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.ebrChequeDet, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrChequeDet.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
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
         Case "Save"
            If DataSave() Then
               mlngID = moCheque.ChequeId
               mboolChanged = True
               Me.Close()
            End If

         Case "Design"
            Call frmChequeImpEditLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmChequeEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmChequeEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()

      If Not mboolAdding Then
         Call FormShow()

         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta Chequera"

         Else
            Me.Text = "Editar Chequera"
         End If

      Else
         Me.Text = "Nueva Chequera"
         Call FormNew()

         cdmMain.Commands.Item("Design").Enabled = Janus.Windows.UI.InheritableBoolean.False
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCheque
         txtChequeId.Text = ToStr(.ChequeId)
         Call txtEmpresaIdLoad(.EmpresaId)
         cboPlan.Value = ListFindItem(cboPlan, .PlanId)
         cboBanco.SelectedIndex = ListFindItem(cboBanco, .BancoId)
         txtBancoCta.Text = ToStr(.BancoCta)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Chequera"
               .VMOld.ToShowOpe()
            End If
         End If
      End With

      Call grdChequeDetLoad()
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsChequeVM)
      oVM = New clsChequeVM

      With oVM
         .ChequeId = moCheque.ChequeId
         .EmpresaId = moCheque.EmpresaId
         .PlanId = moCheque.PlanId
         .PlanDes = cboPlan.Text
         .BancoId = moCheque.BancoId
         .BancoCta = txtBancoCta.Text
         .BancoDes = cboBanco.Text

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCheque
         txtChequeId.Text = String.Empty
         Call txtEmpresaIdLoad(.EmpresaId)
         cboPlan.Value = Nothing
         cboBanco.SelectedIndex = -1
         txtBancoCta.Text = String.Empty
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtChequeId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      cboPlan.ReadOnly = True
      cboBanco.ReadOnly = True
      txtBancoCta.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCheque
         If Not mboolAdding Then
            .ChequeId = ToLong(txtChequeId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .PlanId = ListPosition(cboPlan)
         .BancoId = ListPosition(cboBanco, cboBanco.SelectedIndex)
         .BancoCta = ToStr(txtBancoCta.Text)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboPlan.Select()
   End Sub

   Private Function FormCheck() As Boolean
      FormCheck = True
      Dim strMessage As String = ""
      Try
         If cboPlan.SelectedIndex > -1 Then
            If ToLong(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("EstadoId").Value) = 0 Then
               strMessage &= "La Cuenta seleccionada " & ToStr(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("PlanCta").Value) & "-" & ToStr(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("PlanDes").Value) & " esta Inactiva." & vbCrLf
            End If
         End If

         If Not String.IsNullOrEmpty(strMessage.Trim) Then
            FormCheck = False
            Throw New Exception(strMessage)
         End If

      Catch ex As Exception
         FormCheck = False
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   Private Function DataSave() As Boolean
      Try
         Call DataMove()
         If FormCheck() Then
            If moCheque.Validate Then
               If mboolAdding Then
                  DataSave = DataAdd()
               ElseIf mboolEditing Then
                  If DataUpdate() Then
                     DataSave = grdMainSave()
                  End If
               End If
            End If
         End If
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moCheque.Insert() Then
            mboolAdding = False
            DataAdd = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moCheque.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub frmChequeImpEditLoad()
      Try
         With moCheque
            Dim frm As New frmChequeImp

            frm.DataObjectCheque = moCheque
            frm.ShowDialog()

            If frm.Changed Then
               .OrientacionId = frm.DataObjectCheque.OrientacionId
               .ChequeWidth = frm.DataObjectCheque.ChequeWidth
               .ChequeHeight = frm.DataObjectCheque.ChequeHeight
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      moChequeDet = New clsChequeDet(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboPlanLoad()
      Call cboBancoLoad()
   End Sub

   Private Sub txtEmpresaIdLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      Try
         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               txtEmpresaId.Tag = .EmpresaId
               txtEmpresaId.Text = ToStr(.EmpresaDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Sub

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.TipoPlanId
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moCheque.EmpresaId
            .TipoPlanId = 3
            .EstadoId = clsEstado.ACTIVO
            .PlanId = moCheque.PlanId

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

                  .DropDownList.Columns.Add("EstadoId")
                  .DropDownList.Columns("EstadoId").DataMember = "EstadoId"
                  .DropDownList.Columns("EstadoId").Visible = False

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

   Private Sub cboBancoLoad()
      Dim oBanco As New clsBanco(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboBanco.Items.Clear()

      Try
         With oBanco
            .SelectFilter = clsBanco.SelectFilters.ListBox
            .WhereFilter = clsBanco.WhereFilters.EmpresaId
            .OrderByFilter = clsBanco.OrderByFilters.BancoDes
            .EmpresaId = moCheque.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.BancoId, .BancoDes)

                  cboBanco.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oBanco.Dispose()
         oItem = Nothing

      End Try
   End Sub

#Region " ChequeDet "

   Private Sub grdChequeDetLoad()
      Try
         With moChequeDet
            .SelectFilter = clsChequeDet.SelectFilters.Grid
            .WhereFilter = clsChequeDet.WhereFilters.Grid
            .OrderByFilter = clsChequeDet.OrderByFilters.Grid
            .EmpresaId = moCheque.EmpresaId
            .ChequeId = moCheque.ChequeId

            If .Open() Then
               grdChequeDet.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdChequeDet.RetrieveStructure()
               Call grdChequeDetInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub ChequeDetDataShow()
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)

      Try
         If grdChequeDet.RowCount > 0 Then
            If (ToLong(grdChequeDet.GetValue("ChequeDetId")) > 0) Then
               With oChequeDet
                  .ChequeDetId = ToLong(grdChequeDet.GetValue("ChequeDetId"))

                  If .FindByPK Then
                     Dim frm As New frmChequeDetEdit

                     frm.NewRecord = False
                     frm.Editing = False
                     frm.DataObject = oChequeDet

                     frm.ShowDialog()
                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()

      End Try
   End Sub

   Private Sub ChequeDetFormNew()
      Dim frm As New frmChequeDetEdit
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oChequeDet.EmpresaId = moCheque.EmpresaId
            oChequeDet.ChequeId = moCheque.ChequeId
            oChequeDet.PlanId = moCheque.PlanId
            oChequeDet.BancoId = moCheque.BancoId
            oChequeDet.EstadoId = 11

            .DataObject = oChequeDet
            .ShowDialog()

            If .Changed Then
               Call grdChequeDetLoad()
               Call grdChequeDetFindRow(frm.ID)
               mboolEditGrid = True
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()
      End Try
   End Sub

   Private Sub ChequeDetDataEdit()
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)

      Try
         If grdChequeDet.RowCount > 0 Then
            If (ToLong(grdChequeDet.GetValue("ChequeDetId")) > 0) Then
               With oChequeDet
                  .ChequeDetId = ToLong(grdChequeDet.GetValue("ChequeDetId"))

                  If .FindByPK Then
                     Dim frm As New frmChequeDetEdit

                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oChequeDet
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdChequeDetLoad()
                        Call grdChequeDetFindRow(frm.ID)
                     End If

                     frm.Dispose()
                  End If
               End With
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()

      End Try
   End Sub

   Private Sub CloneVM(ByRef oVM As clsChequeDetVM)
      If clsAppInfo.RegistrarBitacora Then
         oVM = New clsChequeDetVM

         With oVM
            .ChequeDetId = ToLong(grdChequeDet.GetValue("ChequeDetId"))
            .EmpresaId = clsAppInfo.EmpresaId
            .PlanDes = cboPlan.Text
            .BancoDes = cboBanco.Text
            .BancoCta = txtBancoCta.Text
            .ChequeDetNro = ToStr(grdChequeDet.GetValue("ChequeDetNro"))

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Sub ChequeDetDataDelete()
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)

      Try
         If grdChequeDet.RowCount > 0 Then
            If (ToLong(grdChequeDet.GetValue("ChequeDetId")) > 0) Then
               If Not isCompChequeFind(ToLong(grdChequeDet.GetValue("ChequeDetId"))) Then
                  If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     With oChequeDet
                        .WhereFilter = clsChequeDet.WhereFilters.PrimaryKey
                        .ChequeDetId = ToLong(grdChequeDet.GetValue("ChequeDetId"))

                        Call CloneVM(.VMNew)
                        If .Delete Then
                           Call grdChequeDetLoad()
                        End If
                     End With
                  End If
               Else
                  MessageBox.Show("Imposible eliminar la Chequera", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()

      End Try
   End Sub

   Private Sub grdChequeDetFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdChequeDet.RootTable.Columns("ChequeDetId")

      grdChequeDet.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdChequeDetInit()
      With grdChequeDet
         ebrChequeDet.Groups(0).Text = "Chequeras"
         .ContextMenu = mnuChequeDet

         .RootTable.Columns("ChequeDetId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("ChequeId").Visible = False
         .RootTable.Columns("ChequeDetNro").Caption = "Nro"
         .RootTable.Columns("ChequeDetNro").Width = 50
         .RootTable.Columns("ChequeDetNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ChequeDetNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 75
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ChequeIni").Caption = "Inicial"
         .RootTable.Columns("ChequeIni").Width = 80
         .RootTable.Columns("ChequeIni").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ChequeIni").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ChequeFin").Caption = "Final"
         .RootTable.Columns("ChequeFin").Width = 80
         .RootTable.Columns("ChequeFin").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ChequeFin").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ChequeActual").Caption = "Actual"
         .RootTable.Columns("ChequeActual").Width = 80
         .RootTable.Columns("ChequeActual").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ChequeActual").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 60
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

      End With
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdChequeDet.DoubleClick
      Call ChequeDetDataShow()
   End Sub

   Private Sub grdMainDet_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdChequeDet.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdChequeDet.RowCount > 0 Then
               mnuShow.Enabled = True
               mnuNew.Enabled = True
               mnuEdit.Enabled = True
               mnuDelete.Enabled = True
            Else
               mnuShow.Enabled = False
               mnuNew.Enabled = True
               mnuEdit.Enabled = False
               mnuDelete.Enabled = False
            End If
         Else
            mnuShow.Enabled = True
            mnuNew.Enabled = False
            mnuEdit.Enabled = False
            mnuDelete.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdChequeDet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdChequeDet.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdChequeDet.GetRow.Cells(grdChequeDet.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdChequeDet.RowCount > 0 Then
               mnuShow.Enabled = True
               mnuNew.Enabled = True
               mnuEdit.Enabled = True
               mnuDelete.Enabled = True
            Else
               mnuShow.Enabled = False
               mnuNew.Enabled = True
               mnuEdit.Enabled = False
               mnuDelete.Enabled = False
            End If
         Else
            mnuShow.Enabled = True
            mnuNew.Enabled = False
            mnuEdit.Enabled = False
            mnuDelete.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call ChequeDetDataShow()
   End Sub

   Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
      Call ChequeDetFormNew()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      Call ChequeDetDataEdit()
   End Sub

   Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
      Call ChequeDetDataDelete()
   End Sub

   Private Function grdMainSave() As Boolean
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)

      Try
         grdMainSave = True

         With oChequeDet
            .SelectFilter = clsChequeDet.SelectFilters.All
            .WhereFilter = clsChequeDet.WhereFilters.ChequeId
            .EmpresaId = moCheque.EmpresaId
            .ChequeId = moCheque.ChequeId

            If .Open() Then
               Do While .Read()
                  .Fecha = ToDate(.Fecha)
                  .PlanId = moCheque.PlanId
                  .BancoId = moCheque.BancoId

                  If .Update() Then
                     grdMainSave = True
                  End If

                  .MoveNext()
               Loop

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()
      End Try

   End Function

   Private Function isCompChequeFind(ByVal lngChequeDetId As Long) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)

      Try
         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.ChequeDetId
            .EmpresaId = moCheque.EmpresaId
            .ChequeId = moCheque.ChequeId
            .ChequeDetId = lngChequeDetId

            If .Find Then
               Return True
            Else
               Return False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

#End Region

   Private Sub frmChequeEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moCheque.ChequeId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmChequeEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCheque.Dispose()
      Call ClearMemory()
   End Sub

End Class
