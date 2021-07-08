Public Class frmCompDetDescuentoEdit
   Inherits System.Windows.Forms.Form

   Private moCompDet As clsCompDet
   Private moTipoRetencion As clsTipoRetencion

   Private mdecTipoCambio As Decimal
   Private mdecUfv As Decimal
   Private mstrEntregadoA As String
   Private mlnMonedaId As Long
   Private mlngPlanIdOld As Long

   Private mlngCol As Long
   Private mdecCompDetMonto As Decimal
   Private mlngPlanAddId As Long
   Private mlngCentroCostoDetId As Long

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mlngID As Long

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

   Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get

      Set(ByVal Value As Boolean)
         mboolChanged = Value
      End Set
   End Property

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property

   WriteOnly Property DataObject() As clsCompDet
      Set(ByVal Value As clsCompDet)
         moCompDet = Value
      End Set
   End Property

   Property TipoCambio() As Decimal
      Get
         Return mdecTipoCambio
      End Get

      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

   ReadOnly Property PlanAddId() As Long
      Get
         Return mlngPlanAddId
      End Get
   End Property

   ReadOnly Property CentroCostoDetId() As Long
      Get
         Return mlngCentroCostoDetId
      End Get
   End Property
#End Region

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
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents txtCompDetId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
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
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboCentroCosto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents chkCentroCosto As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkPlan As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents LibroMayor As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents LibroMayor1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand

   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboCentroCosto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompDetDescuentoEdit))
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCosto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.chkCentroCosto = New Janus.Windows.EditControls.UICheckBox
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.chkPlan = New Janus.Windows.EditControls.UICheckBox
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.txtCompDetId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label17 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.LibroMayor1 = New Janus.Windows.UI.CommandBars.UICommand("LibroMayor")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LibroMayor = New Janus.Windows.UI.CommandBars.UICommand("LibroMayor")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
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
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 167)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.cboCentroCosto)
      Me.UiGroupBox1.Controls.Add(Me.chkCentroCosto)
      Me.UiGroupBox1.Controls.Add(Me.cboEstado)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.Label13)
      Me.UiGroupBox1.Controls.Add(Me.cboSucursal)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 68)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 92)
      Me.UiGroupBox1.TabIndex = 12
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCosto
      '
      cboCentroCosto_DesignTimeLayout.LayoutString = resources.GetString("cboCentroCosto_DesignTimeLayout.LayoutString")
      Me.cboCentroCosto.DesignTimeLayout = cboCentroCosto_DesignTimeLayout
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(116, 40)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedIndex = -1
      Me.cboCentroCosto.SelectedItem = Nothing
      Me.cboCentroCosto.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCosto.TabIndex = 15
      Me.cboCentroCosto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboCentroCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'chkCentroCosto
      '
      Me.chkCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.chkCentroCosto.Checked = True
      Me.chkCentroCosto.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkCentroCosto.Location = New System.Drawing.Point(100, 44)
      Me.chkCentroCosto.Name = "chkCentroCosto"
      Me.chkCentroCosto.Size = New System.Drawing.Size(16, 16)
      Me.chkCentroCosto.TabIndex = 14
      Me.chkCentroCosto.TabStop = False
      Me.chkCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(116, 64)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(320, 20)
      Me.cboEstado.TabIndex = 17
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 208
      Me.Label5.Text = "Centro Costo"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 20)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 207
      Me.Label4.Text = "Sucursal"
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(8, 68)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(104, 16)
      Me.Label13.TabIndex = 206
      Me.Label13.Text = "Estado"
      '
      'cboSucursal
      '
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(116, 16)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(320, 20)
      Me.cboSucursal.TabIndex = 13
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.chkPlan)
      Me.grpMain.Controls.Add(Me.cboPlan)
      Me.grpMain.Controls.Add(Me.txtCompDetId)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.Controls.Add(Me.Label19)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 68)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkPlan
      '
      Me.chkPlan.BackColor = System.Drawing.Color.Transparent
      Me.chkPlan.Checked = True
      Me.chkPlan.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkPlan.Location = New System.Drawing.Point(100, 44)
      Me.chkPlan.Name = "chkPlan"
      Me.chkPlan.Size = New System.Drawing.Size(16, 16)
      Me.chkPlan.TabIndex = 3
      Me.chkPlan.TabStop = False
      Me.chkPlan.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboPlan
      '
      cboPlan_DesignTimeLayout.LayoutString = resources.GetString("cboPlan_DesignTimeLayout.LayoutString")
      Me.cboPlan.DesignTimeLayout = cboPlan_DesignTimeLayout
      Me.cboPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlan.Location = New System.Drawing.Point(116, 40)
      Me.cboPlan.Name = "cboPlan"
      Me.cboPlan.SelectedIndex = -1
      Me.cboPlan.SelectedItem = Nothing
      Me.cboPlan.Size = New System.Drawing.Size(320, 20)
      Me.cboPlan.TabIndex = 4
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCompDetId
      '
      Me.txtCompDetId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompDetId.Location = New System.Drawing.Point(116, 16)
      Me.txtCompDetId.Name = "txtCompDetId"
      Me.txtCompDetId.ReadOnly = True
      Me.txtCompDetId.Size = New System.Drawing.Size(124, 20)
      Me.txtCompDetId.TabIndex = 1
      Me.txtCompDetId.TabStop = False
      Me.txtCompDetId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompDetId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(8, 44)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(104, 16)
      Me.Label17.TabIndex = 200
      Me.Label17.Text = "Cuenta"
      '
      'Label19
      '
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(8, 20)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(104, 16)
      Me.Label19.TabIndex = 198
      Me.Label19.Text = "ID"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      Me.ilsMain.Images.SetKeyName(2, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.LibroMayor})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("bc30fc1a-bff7-4021-abd5-fd301850db3f")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.LibroMayor1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(155, 28)
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
      'LibroMayor1
      '
      Me.LibroMayor1.Key = "LibroMayor"
      Me.LibroMayor1.Name = "LibroMayor1"
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
      'LibroMayor
      '
      Me.LibroMayor.ImageIndex = 2
      Me.LibroMayor.Key = "LibroMayor"
      Me.LibroMayor.Name = "LibroMayor"
      Me.LibroMayor.Text = "Libro Mayor"
      Me.LibroMayor.Visible = Janus.Windows.UI.InheritableBoolean.[False]
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
      Me.TopRebar1.Size = New System.Drawing.Size(462, 28)
      '
      'frmCompDetDescuentoEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 195)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompDetDescuentoEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompDet Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
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
            cboPlan.Select()

            If DataSave() Then
               mlngID = moCompDet.CompDetId
               mboolChanged = True
               Me.Close()
            End If

         Case "LibroMayor"
            Call frmLibroMayorLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompDetDescuentoEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompDetDescuentoEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Asiento de Descuento"
         Else
            Me.Text = "Editar Asiento de Descuento"
            mlngPlanIdOld = moCompDet.PlanId
         End If
      Else
         Me.Text = "Nuevo Asiento de Descuento"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      mlnMonedaId = moCompDet.MonedaId
      mdecUfv = UfvFind(moCompDet.Fecha)
   End Sub

   Private Sub ComboLoad()
      Call cboPlanLoad()
      Call cboSucursalLoad()
      Call cboCentroCostoLoad()
      Call cboEstadoLoad()
   End Sub

#Region " ComboLoads "
   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.MultiComboBox
            .WhereFilter = clsPlan.WhereFilters.EsAnaTipoPlanId
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moCompDet.EmpresaId
            .EsAna = 1
            .TipoPlanId = 0
            .EstadoId = clsEstado.ACTIVO
            .PlanId = moCompDet.PlanId

            If .Open() Then
               With cboPlan
                  .DropDownList.Columns.Clear()

                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("TipoGrupoId")
                  .DropDownList.Columns("TipoGrupoId").DataMember = "TipoGrupoId"
                  .DropDownList.Columns("TipoGrupoId").Visible = False

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

                  If clsAppInfo.PlanCtaShow Then
                     .ValueMember = "PlanId"
                     .DisplayMember = "PlanCta"
                     chkPlan.Checked = False
                  Else
                     .ValueMember = "PlanId"
                     .DisplayMember = "PlanDes"
                     chkPlan.Checked = True
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

   Private Sub cboSucursalLoad()
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSucursal.Items.Clear()
      Try
         With oSucursal
            .SelectFilter = clsSucursal.SelectFilters.ListBox
            .WhereFilter = clsSucursal.WhereFilters.EmpresaId
            .OrderByFilter = clsSucursal.OrderByFilters.SucursalDes

            .EmpresaId = moCompDet.EmpresaId
            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.SucursalId, .SucursalDes)

                  cboSucursal.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oSucursal.Dispose()
         oItem = Nothing
      End Try
   End Sub

   Private Sub cboCentroCostoLoad()
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.All
            .WhereFilter = clsCentroCosto.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = moCompDet.EmpresaId
            .CentroCostoId = moCompDet.CentroCostoId
            .EstadoId = 1

            If .Open() Then
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
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCentroCosto.Dispose()
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

   'Private Sub cboTipoRetencionLoad(ByVal lngAsume As Long)
   '   Dim oItem As clsListItem

   '   cboTipoRetencion.Items.Clear()
   '   cboTipoRetencion.Text = ""

   '   Try
   '      With moTipoRetencion
   '         .SelectFilter = clsTipoRetencion.SelectFilters.ListBox
   '         .OrderByFilter = clsTipoRetencion.OrderByFilters.TipoRetencionId

   '         If .Open() Then
   '            If lngAsume = 1 Then 'Empresa
   '               Do While .Read()
   '                  If (.TipoRetencionId = 1) Or (.TipoRetencionId = 2) Or (.TipoRetencionId = 3) Then
   '                     oItem = New clsListItem(.TipoRetencionId, .TipoRetencionDes)

   '                     cboTipoRetencion.Items.Add(oItem)
   '                  End If

   '                  .MoveNext()
   '               Loop

   '            ElseIf lngAsume = 2 Then 'Proveedor
   '               Do While .Read()
   '                  If (.TipoRetencionId = 4) Or (.TipoRetencionId = 5) Or (.TipoRetencionId = 6) Then
   '                     oItem = New clsListItem(.TipoRetencionId, .TipoRetencionDes)

   '                     cboTipoRetencion.Items.Add(oItem)
   '                  End If

   '                  .MoveNext()
   '               Loop
   '            End If
   '         End If
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oItem = Nothing

   '   End Try
   'End Sub
#End Region

   Private Sub FormNew()
      mboolAdding = True

      cboPlan.Select()
      Call DataClear()
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCompDet
         txtCompDetId.Text = ToStr(.CompDetId)
         cboPlan.Value = ListFindItem(cboPlan, .PlanId)

         'If .MonedaId = 1 Then
         '   txtDebe.Text = ToDecStr(.DebeOrg)
         '   txtHaber.Text = ToDecStr(.HaberOrg)

         '   txtDebe.Tag = txtDebe.Text
         '   txtHaber.Tag = txtHaber.Text

         '   If .DebeOrg <> 0 Then
         '      txtEqui.Text = ToDecStr(ToDecimal(.DebeOrg / mdecTipoCambio))
         '      If mdecUfv > 0 Then
         '         txtEquiUfv.Text = ToDecStr(ToDecimal(.DebeOrg / mdecUfv))
         '      End If

         '   ElseIf .HaberOrg <> 0 Then
         '      txtEqui.Text = ToDecStr(ToDecimal(.HaberOrg / mdecTipoCambio))
         '      If mdecUfv > 0 Then
         '         txtEquiUfv.Text = ToDecStr(ToDecimal(.HaberOrg / mdecUfv))
         '      End If
         '   End If

         'ElseIf .MonedaId = 2 Then
         '   txtDebe.Text = ToDecStr(.DebeOrg)
         '   txtHaber.Text = ToDecStr(.HaberOrg)

         '   If .DebeOrg <> 0 Then
         '      txtEqui.Text = ToDecStr(ToDecimal(.DebeOrg * mdecTipoCambio))
         '      If mdecUfv > 0 Then
         '         txtEquiUfv.Text = ToDecStr(ToDecimal((.DebeOrg * mdecTipoCambio) / mdecUfv))
         '      End If

         '   ElseIf .HaberOrg <> 0 Then
         '      txtEqui.Text = ToDecStr(ToDecimal(.HaberOrg * mdecTipoCambio))
         '      If mdecUfv > 0 Then
         '         txtEquiUfv.Text = ToDecStr(ToDecimal((.HaberOrg * mdecTipoCambio) / mdecUfv))
         '      End If
         '   End If
         'End If

         Dim lngPlanId As Long = ListPosition(cboPlan)
         Dim lngTipoGrupoId As Long = 0
         Dim lngSucCCO As Long = TieneSucCCO(lngPlanId, lngTipoGrupoId)

         If lngSucCCO = 1 Then
            cboSucursal.SelectedIndex = -1
            cboSucursal.Enabled = True
            cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)

            cboCentroCosto.Value = Nothing
            cboCentroCosto.Enabled = False

         ElseIf lngSucCCO = 2 Then
            cboSucursal.SelectedIndex = -1
            cboSucursal.Enabled = False

            cboCentroCosto.Value = Nothing
            cboCentroCosto.Enabled = True
            cboCentroCosto.Value = ListFindItem(cboCentroCosto, .CentroCostoId)

         Else
            cboSucursal.SelectedIndex = -1
            cboSucursal.Enabled = False
            cboCentroCosto.Value = Nothing
            cboCentroCosto.Enabled = False
         End If

         'If ToDecimal(txtDebe.Text) > 0 Then
         '   If moCompDet.TipoCompId > 1 Then
         '      If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 5) Or (lngTipoGrupoId = 6) Then
         '         Call cboTipoRetencionLoad(1)
         '      End If
         '   End If

         'ElseIf ToDecimal(txtHaber.Text) > 0 Then
         '   If moCompDet.TipoCompId > 1 Then
         '      If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 2) Then
         '         Call cboTipoRetencionLoad(2)
         '      End If
         '   End If
         'End If

         'cboTipoRetencion.SelectedIndex = ListFindItem(cboTipoRetencion, .TipoRetencionId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         cboEstado.Enabled = False

         cboPlan.Select()
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCompDet
         txtCompDetId.Text = String.Empty
         cboPlan.Value = Nothing
         'txtCompDetDes.Text = .CompDetDes
         'txtDebe.Text = "0.0"
         'txtHaber.Text = "0.0"
         'txtEqui.Text = "0.0"
         cboSucursal.SelectedIndex = -1
         cboCentroCosto.Value = Nothing
         'cboTipoRetencion.SelectedIndex = -1
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         cboSucursal.Enabled = False
         cboCentroCosto.Enabled = False
         cboEstado.Enabled = False

         'If clsAppInfo.AplicarDescuento Then
         '   If moCompDet.TipoId = clsCompDet.DESCUENTO Then
         '      Call txtMontoDescuentoLoad()
         '   End If
         'End If
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCompDetId.ReadOnly = True
      cboPlan.ReadOnly = True
      'txtCompDetDes.ReadOnly = True
      'txtDebe.ReadOnly = True
      'txtHaber.ReadOnly = True
      'txtEqui.ReadOnly = True
      cboSucursal.Enabled = False
      cboCentroCosto.Enabled = False
      'cboTipoRetencion.Enabled = False
      cboEstado.Enabled = False

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCompDet
         If mboolAdding Then
            .CompDetId = 0
         Else
            .CompDetId = ToLong(txtCompDetId.Text)
         End If
         .PlanId = ListPosition(cboPlan)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
         .CentroCostoId = ListPosition(cboCentroCosto)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
      End With
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If cboPlan.SelectedIndex > -1 Then
         If ToLong(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("EstadoId").Value) = 0 Then
            strMsg &= "La Cuenta seleccionada " & ToStr(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("PlanDes").Value) & " esta Inactiva." & vbCrLf
         End If
      End If

      If cboSucursal.Enabled Then
         If ListPosition(cboSucursal, cboSucursal.SelectedIndex) = 0 Then
            strMsg &= "Seleccione la Sucursal" & vbCrLf
         End If
      End If

      If cboCentroCosto.Enabled Then
         If ListPosition(cboCentroCosto) = 0 Then
            strMsg &= "Seleccione el Centro de Costo" & vbCrLf
         End If
      End If

      If String.IsNullOrEmpty(strMsg.Trim) Then
         If TieneAnaAdd(moCompDet.PlanId) Then
            If MessageBox.Show("La Cuenta Tiene Analíticos Adicionales, ¿Desea Ingresarlos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               Call frmCompPlanAddEditLoad()
            End If

            If mlngPlanAddId = 0 Then
               strMsg &= "Seleccione el Análitico Adicional para la Cuenta de Descuento" & vbCrLf
            End If
         End If

         If TieneCentroCostoDet(moCompDet.CentroCostoId) Then
            If MessageBox.Show("El Centro de Costo Tiene Actividades, ¿Desea Ingresarlos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               Call frmCompCentroCostoDetEditLoad()
            End If

            If mlngCentroCostoDetId = 0 Then
               strMsg &= "Seleccione la Actividad para la Cuenta de Descuento" & vbCrLf
            End If
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If FormCheck() Then
            If mboolAdding Then
               DataSave = True
            Else
               DataSave = True
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   'Private Function DataAdd() As Boolean
   '   Try
   '      DataAdd = False

   '      If moCompDet.Insert() Then
   '         mboolAdding = False
   '         DataAdd = True
   '      End If

   '   Catch exp As Exception
   '      Throw exp

   '   End Try
   'End Function

   'Private Function DataUpdate() As Boolean
   '   Try
   '      DataUpdate = False

   '      If moCompDet.Update() Then
   '         If mlngPlanIdOld <> moCompDet.PlanId Then
   '            Call DeleteFactura(moCompDet.CompDetId)
   '            Call DeleteFacturaAgru(moCompDet.CompDetId)
   '            Call DeleteCompCheque(moCompDet.CompDetId)
   '            Call DeleteCompPlanAdd(moCompDet.CompDetId)
   '            Call DeleteCompCentroCostoDet(moCompDet.CompDetId)
   '         End If

   '         DataUpdate = True
   '      End If

   '   Catch exp As Exception
   '      Throw exp

   '   End Try
   'End Function

   Private Sub frmLibroMayorLoad()
      Dim oLista As New Queue
      Dim lngPlanId As Long

      lngPlanId = ListPosition(cboPlan)

      If lngPlanId > 0 Then
         oLista.Enqueue(lngPlanId)
      End If

      If oLista.Count Then
         Dim frm As New frmLibroMayor

         With frm
            .EmpresaId = moCompDet.EmpresaId
            .GestionId = clsAppInfo.GestionId
            .MonedaId = moCompDet.MonedaId
            .SaldoAnterior = False
            .Cuenta = True
            .SinMovimiento = False
            .IntervaloFecha = False
            '.FechaIni = mstrFechaIni
            '.FechaFin = mstrFechaFin
            .Lista = oLista

            frm.ShowDialog()
            frm.Dispose()
         End With
      Else
         MessageBox.Show("Cuenta Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub frmCompDetDescuentoEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               cboPlan.Select()

               If DataSave() Then
                  mlngID = moCompDet.CompDetId
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompDetDescuentoEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompDet.Dispose()
      Call ClearMemory()
   End Sub

#Region " Otros Metodos "
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

   'Private Sub txtEquiUfvLoad(ByVal decValue As Decimal)
   '   If mdecUfv > 0 Then
   '      If moCompDet.MonedaId = 1 Then
   '         txtEquiUfv.Text = ToDecimal(decValue / mdecUfv)

   '      ElseIf moCompDet.MonedaId = 2 Then
   '         txtEquiUfv.Text = ToDecimal((decValue * mdecTipoCambio) / mdecUfv)
   '      End If
   '   Else
   '      txtEquiUfv.Text = "0"
   '   End If
   'End Sub

   Private Function CompCentroCostoDetMoveCol(ByVal lngCompDetId As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      Dim boolUpdate As Boolean

      CompCentroCostoDetMoveCol = False

      Try
         With oCompCentroCostoDet
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read
                  boolUpdate = False

                  If mlngCol = 1 Then 'Debe
                     If .HaberOrg > 0 Then
                        .DebeOrg = .HaberOrg
                        .DebeBs = .HaberBs
                        .DebeOrg = .HaberOrg

                        .HaberOrg = 0
                        .HaberBs = 0
                        .HaberUs = 0

                        .Fecha = ToDate(.Fecha)

                        boolUpdate = True
                     End If

                  ElseIf mlngCol = 2 Then 'Haber
                     If .DebeOrg > 0 Then
                        .HaberOrg = .DebeOrg
                        .HaberBs = .DebeBs
                        .HaberUs = .DebeUs

                        .DebeOrg = 0
                        .DebeBs = 0
                        .DebeOrg = 0

                        .Fecha = ToDate(.Fecha)

                        boolUpdate = True
                     End If
                  End If

                  If boolUpdate Then
                     If .Update Then
                        'CompCentroCostoDetMoveCol = True
                     End If
                  End If

                  .MoveNext()
               Loop

               CompCentroCostoDetMoveCol = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddMoveCol(ByVal lngCompDetId As Long) As Boolean
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim boolUpdate As Boolean

      CompPlanAddMoveCol = False

      Try
         With oCompPlanAdd
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read
                  boolUpdate = False

                  If mlngCol = 1 Then 'Debe
                     If .HaberOrg > 0 Then
                        .DebeOrg = .HaberOrg
                        .DebeBs = .HaberBs
                        .DebeOrg = .HaberOrg

                        .HaberOrg = 0
                        .HaberBs = 0
                        .HaberUs = 0

                        .Fecha = ToDate(.Fecha)

                        boolUpdate = True
                     End If

                  ElseIf mlngCol = 2 Then 'Haber
                     If .DebeOrg > 0 Then
                        .HaberOrg = .DebeOrg
                        .HaberBs = .DebeBs
                        .HaberUs = .DebeUs

                        .DebeOrg = 0
                        .DebeBs = 0
                        .DebeOrg = 0

                        .Fecha = ToDate(.Fecha)

                        boolUpdate = True
                     End If
                  End If

                  If boolUpdate Then
                     If .Update Then
                        'CompPlanAddMoveCol = True
                     End If
                  End If

                  .MoveNext()
               Loop

               CompPlanAddMoveCol = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function TieneChequera(ByVal lngPlanId As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TieneChequera = False

         oPlan.PlanId = lngPlanId

         If oPlan.FindByPK Then
            If oPlan.TipoPlanId = 3 Then
               TieneChequera = True
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function TieneAnaAdd(ByVal lngPlanId As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TieneAnaAdd = False

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               If ToBoolean(.TieneAnaAdd) Then
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

   Private Function TieneSucCCO(ByVal lngPlanId As Long, ByRef lngTipoGrupoId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         TieneSucCCO = 0

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               lngTipoGrupoId = .TipoGrupoId
               TieneSucCCO = .SucCCOId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function MonedaIdFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         MonedaIdFind = False

         oPlan.PlanId = lngPlanId

         If oPlan.FindByPK Then
            MonedaIdFind = oPlan.MonedaId
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function frmCompChequeEditLoad(ByVal lngCompDetId As Long) As Boolean
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      Dim frm As New frmCompChequeEdit

      Try
         frmCompChequeEditLoad = False

         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompDetId
            .CompDetId = lngCompDetId

            Dim lngMonedaId As Long = MonedaIdFind(moCompDet.PlanId)

            If .Find Then
               frm.NewRecord = False
               frm.Editing = True

               If lngMonedaId = 1 Then
                  .ChequeMonto = ToDecimal(moCompDet.HaberBs)

               ElseIf lngMonedaId = 2 Then
                  .ChequeMonto = ToDecimal(moCompDet.HaberUs)
               End If

            Else
               frm.NewRecord = True
               frm.Editing = False

               .EmpresaId = ToLong(moCompDet.EmpresaId)
               .GestionId = ToLong(moCompDet.GestionId)
               .CompId = ToLong(moCompDet.CompId)
               .CompDetId = ToLong(moCompDet.CompDetId)
               .PlanId = ToLong(moCompDet.PlanId)
               .Fecha = ConvertDMY(moCompDet.Fecha)
               .ChequeDes = ToStr(mstrEntregadoA)
               .TipoCambio = mdecTipoCambio

               If lngMonedaId = 1 Then
                  .ChequeMonto = ToDecimal(moCompDet.HaberBs)

               ElseIf lngMonedaId = 2 Then
                  .ChequeMonto = ToDecimal(moCompDet.HaberUs)
               End If
            End If

            frm.DataObject = oCompCheque
            frm.ShowDialog()

            If frm.Changed Then
               frmCompChequeEditLoad = True
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Function TieneChequeraCreada(ByVal lngPlanId As Long) As Boolean
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      TieneChequeraCreada = False

      Try
         With oCheque
            .SelectFilter = clsCheque.SelectFilters.All
            .WhereFilter = clsCheque.WhereFilters.PlanId
            .EmpresaId = moCompDet.EmpresaId
            .PlanId = lngPlanId

            If .Find Then
               TieneChequeraCreada = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCheque.Dispose()

      End Try
   End Function

   Private Function TieneCentroCostoDet(ByVal lngCentroCostoId As Long) As Boolean
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)

      Try
         TieneCentroCostoDet = False

         With oCentroCostoDet
            .SelectFilter = clsCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCentroCostoDet.WhereFilters.EstadoId
            .EmpresaId = moCompDet.EmpresaId
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

   Private Function TieneRetencionDiferente() As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim boolTieneRet As Boolean = False
      Dim lngCol As Long = 0

      TieneRetencionDiferente = False

      Try
         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .OrderByFilter = clsCompDet.OrderByFilters.CompDetId
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId

            If .Open Then
               If moCompDet.DebeOrg > 0 Then
                  lngCol = 1

               ElseIf moCompDet.HaberOrg > 0 Then
                  lngCol = 2
               End If

               Do While .Read
                  If .TipoRetencionId > 0 Then
                     If moCompDet.CompDetId <> .CompDetId Then
                        If lngCol = 1 Then
                           If .HaberOrg > 0 Then
                              Return True
                           End If

                        ElseIf lngCol = 2 Then
                           If .DebeOrg > 0 Then
                              Return True
                           End If
                        End If
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
   End Function

   Private Function TieneFactura(ByVal lngCompDetId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      Try
         TieneFactura = False

         With oFactura
            .SelectFilter = clsFactura.SelectFilters.All
            .WhereFilter = clsFactura.WhereFilters.CompDetId
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
            .CompDetId = lngCompDetId

            If .Find Then
               TieneFactura = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFactura.Dispose()

      End Try
   End Function

   Private Function UfvFind(ByVal strFecha As String) As Decimal
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      UfvFind = 0

      Try
         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = strFecha

            If .Find Then
               UfvFind = .Ufv
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oTipoCambio.Dispose()
      End Try
   End Function

   Private Function DeleteFactura(ByVal lngCompDetId As Long) As Boolean
      Dim oFactura As New clsFactura(clsAppInfo.ConnectString)

      DeleteFactura = False

      Try
         With oFactura
            .WhereFilter = clsFactura.WhereFilters.CompDetId
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
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
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
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
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
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

   Private Function DeleteCompCentroCostoDet(ByVal lngCompDetId As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      DeleteCompCentroCostoDet = False

      Try
         With oCompCentroCostoDet
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
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
#End Region

   Private Sub frmCompPlanAddEditLoad()
      Dim frm As New frmCompPlanAddEdit
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      Try
         With oCompPlanAdd
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
            .CompDetId = moCompDet.CompDetId
            .GestionId = moCompDet.GestionId
            .Fecha = ConvertDMY(moCompDet.Fecha)
            .PlanId = moCompDet.PlanId
            .MonedaId = moCompDet.MonedaId
            .EstadoId = 13

            'If mlngCol = 1 Then
            '   .DebeOrg = decCompPlanAddSaldo

            'ElseIf mlngCol = 2 Then
            '   .HaberOrg = decCompPlanAddSaldo
            'End If

            frm.NewRecord = True
            frm.Editing = False
            frm.Changed = False
            frm.TipoCambio = mdecTipoCambio
            frm.CompMonedaId = moCompDet.MonedaId
            'frm.Col = mlngCol
            'frm.CompDetMonto = mdecCompDetMonto
            frm.AsientoDescuento = True
            frm.DataObject = oCompPlanAdd
            frm.ShowDialog()

            If frm.Changed Then
               ' decCompPlanAddSaldo = CompPlanAddSaldo(.CompId, .CompDetId)
               mlngPlanAddId = frm.PlanAddId
            Else
               Exit Sub
            End If
         End With
         frm.Dispose()


      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()
      End Try
   End Sub

   Private Sub frmCompCentroCostoDetEditLoad()
      Dim frm As New frmCompCentroCostoDetEdit
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      ' Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      ' Dim decCompCentroCostoDetSaldo As Decimal

      Try
         '  With oCompDet
         ' .CompDetId = moCompDet.CompDetId

         ' If .FindByPK Then
         'Call CompPlanAddParametro(.DebeOrg, .HaberOrg)
         'decCompCentroCostoDetSaldo = CompCentroCostoDetSaldo(.CompId, .CompDetId, .CentroCostoId)

         'If decCompCentroCostoDetSaldo = 0 Then
         '   MessageBox.Show("El Monto de la(s) Actividad(es) ya esta Balanceado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         '   Exit Sub

         'ElseIf decCompCentroCostoDetSaldo < 0 Then
         '   MessageBox.Show("El Monto de la(s) Actividad(es) no Puede Ser Mayor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         '   Exit Sub
         'End If

         ' Do While decCompCentroCostoDetSaldo > 0
         With oCompCentroCostoDet
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
            .CompDetId = moCompDet.CompDetId
            .GestionId = moCompDet.GestionId
            .Fecha = ConvertDMY(moCompDet.Fecha)
            .PlanId = moCompDet.PlanId
            .CentroCostoId = moCompDet.CentroCostoId
            .MonedaId = moCompDet.MonedaId
            .EstadoId = 13

            'If mlngCol = 1 Then
            '   .DebeOrg = decCompCentroCostoDetSaldo

            'ElseIf mlngCol = 2 Then
            '   .HaberOrg = decCompCentroCostoDetSaldo
            'End If

            frm.NewRecord = True
            frm.Editing = False
            frm.Changed = False
            frm.TipoCambio = mdecTipoCambio
            frm.CompMonedaId = moCompDet.MonedaId
            frm.AsientoDescuento = True
            'frm.Col = mlngCol
            ' frm.CompDetMonto = mdecCompDetMonto
            frm.DataObject = oCompCentroCostoDet
            frm.ShowDialog()

            If frm.Changed Then
               ' decCompCentroCostoDetSaldo = CompCentroCostoDetSaldo(.CompId, .CompDetId, .CentroCostoId)
               mlngCentroCostoDetId = frm.CentroCostoDetId
               'Else
               '   Exit Sub
            End If
         End With
         '  Loop
         ' End If

         frm.Dispose()
         '  End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()
         ' oCompDet.Dispose()

      End Try
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
            .EmpresaId = moCompDet.EmpresaId
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
         CompPlanAddSaldo = Math.Abs(mdecCompDetMonto - decSaldo)

         'If mlngCol = 1 Then 'Debe
         '   CompPlanAddSaldo = Math.Abs(mdecCompDetMonto - decDebe)
         'Else
         '   CompPlanAddSaldo = Math.Abs(mdecCompDetMonto - decHaber)
         'End If

         CompPlanAddSaldo = ToDecimalMinor(CompPlanAddSaldo)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetSaldo(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngCentroCostoId As Long) As Decimal
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      Dim decDebe As Decimal = 0
      Dim decHaber As Decimal = 0

      Try
         CompCentroCostoDetSaldo = 0

         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CentroCostoId
            .EmpresaId = moCompDet.EmpresaId
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

         If mlngCol = 1 Then 'Debe
            CompCentroCostoDetSaldo = Math.Abs(mdecCompDetMonto - decDebe)
         Else
            CompCentroCostoDetSaldo = Math.Abs(mdecCompDetMonto - decHaber)
         End If

         CompCentroCostoDetSaldo = ToDecimalMinor(CompCentroCostoDetSaldo)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

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

#Region " F3 "
   Private Sub cboPlan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPlan.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F2 Then
            Dim frm As New frmPlanFind

            Try
               With frm
                  .EmpresaId = moCompDet.EmpresaId
                  .ShowDialog()

                  If .Changed Then
                     cboPlan.Value = ListFindItem(cboPlan, ToLong(frm.ID))
                     cboPlan.Refresh()
                  End If

                  frm.Dispose()
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try

         ElseIf e.KeyCode = Keys.F3 Then
            Dim frm As New frmPlan

            frm.Find = True
            frm.EmpresaId = moCompDet.EmpresaId
            frm.ShowDialog()

            If frm.Changed Then
               Call cboPlanLoad()
               cboPlan.Value = ListFindItem(cboPlan, ToLong(frm.ID))
            End If

            frm.Dispose()

         ElseIf e.KeyCode = Keys.F5 Then
            Dim frm As New frmPlanFill

            With frm
               .FindAll = False
               .EmpresaId = moCompDet.EmpresaId
               .ShowDialog()

               If frm.Selected Then
                  Call cboPlanLoad()
                  cboPlan.Value = ListFindItem(cboPlan, ToLong(frm.ID))
               End If

               frm.Dispose()
            End With
         End If
      End If
   End Sub

   Private Sub cboCentroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCentroCosto.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            Dim frm As New frmCentroCostoEdit
            Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)

            Try
               With frm
                  .NewRecord = True
                  .Editing = False

                  oCentroCosto.EmpresaId = moCompDet.EmpresaId
                  .DataObject = oCentroCosto
                  .ShowDialog()

                  If .Changed Then
                     Call cboCentroCostoLoad()
                     cboCentroCosto.Value = ListFindItem(cboCentroCosto, ToLong(frm.ID))
                  End If

                  frm.Dispose()
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Finally
               oCentroCosto.Dispose()
            End Try
         End If
      End If
   End Sub
#End Region

#Region " Evento cboPlan "
   Private Sub cboPlan_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPlan.ValueChanged
      If Not mboolLoading Then
         Dim lngPlanId As Long = ListPosition(cboPlan)
         Dim lngTipoGrupoId As Long = 0
         Dim lngSucCCO As Long = TieneSucCCO(lngPlanId, lngTipoGrupoId)

         If lngSucCCO = 1 Then
            cboSucursal.SelectedIndex = -1
            cboSucursal.Enabled = True
            cboCentroCosto.Value = Nothing
            cboCentroCosto.Enabled = False

         ElseIf lngSucCCO = 2 Then
            cboSucursal.SelectedIndex = -1
            cboSucursal.Enabled = False
            cboCentroCosto.Value = Nothing
            cboCentroCosto.Enabled = True
         Else
            cboSucursal.SelectedIndex = -1
            cboSucursal.Enabled = False
            cboCentroCosto.Value = Nothing
            cboCentroCosto.Enabled = False
         End If

         'If ToDecimal(txtDebe.Text) > 0 Then
         '   If moCompDet.TipoCompId > 1 Then
         '      If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 5) Or (lngTipoGrupoId = 6) Then
         '         Call cboTipoRetencionLoad(1)
         '      End If
         '   End If

         'ElseIf ToDecimal(txtHaber.Text) > 0 Then
         '   If moCompDet.TipoCompId > 1 Then
         '      If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 2) Then
         '         Call cboTipoRetencionLoad(2)
         '      End If
         '   End If

         'Else
         '   cboTipoRetencion.Items.Clear()
         '   cboTipoRetencion.Text = ""
         'End If
      End If
   End Sub
#End Region

   '#Region " Evento txtDebe "
   '   Private Sub txtDebe_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
   '      If cboPlan.Value IsNot Nothing Then
   '         If txtDebe.Tag <> txtDebe.Text Then
   '            txtDebe.Tag = txtDebe.Text

   '            If ToDecimal(txtDebe.Text) > 0 Then
   '               If moCompDet.TipoCompId > 1 Then
   '                  Dim lngTipoGrupoId As Long = PlanGrupoFind(ListPosition(cboPlan)) ' ToLong(cboPlan.DropDownList.GetRow.Cells("TipoGrupoId").Value)

   '                  cboTipoRetencion.Items.Clear()
   '                  cboTipoRetencion.Text = ""

   '                  If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 5) Or (lngTipoGrupoId = 6) Then
   '                     Call cboTipoRetencionLoad(1)
   '                  End If
   '               End If
   '            End If
   '         End If
   '      End If
   '   End Sub

   '   Private Sub txtDebe_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
   '      If ToDecimal(txtDebe.Text) <> 0 Then
   '         Call txtEquiLoad(ToDecimal(txtDebe.Text))
   '         Call txtEquiUfvLoad(ToDecimal(txtDebe.Text))
   '         txtHaber.Text = "0.0"
   '         txtHaber.Tag = ""
   '      End If
   '   End Sub

   '   Private Sub txtEquiLoad(ByVal decValue As Decimal)
   '      If moCompDet.MonedaId = 1 Then
   '         txtEqui.Text = ToDecimal(decValue / mdecTipoCambio)

   '      ElseIf moCompDet.MonedaId = 2 Then
   '         txtEqui.Text = ToDecimal(decValue * mdecTipoCambio)
   '      End If
   '   End Sub
   '#End Region

   '#Region " Evento txtHaber "
   '   Private Sub txtHaber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
   '      If cboPlan.Value IsNot Nothing Then
   '         If txtHaber.Tag <> txtHaber.Text Then
   '            txtHaber.Tag = txtHaber.Text

   '            If ToDecimal(txtHaber.Text) > 0 Then
   '               If moCompDet.TipoCompId > 1 Then
   '                  Dim lngTipoGrupoId As Long = PlanGrupoFind(ListPosition(cboPlan)) ' ToLong(cboPlan.DropDownList.SelectedItems.Item("TipoGrupoId"))
   '                  cboTipoRetencion.Items.Clear()
   '                  cboTipoRetencion.Text = ""

   '                  If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 2) Then
   '                     Call cboTipoRetencionLoad(2)
   '                  End If
   '               End If
   '            End If
   '         End If
   '      End If
   '   End Sub

   '   Private Sub txtHaber_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
   '      If ToDecimal(txtHaber.Text) <> 0 Then
   '         Call txtEquiLoad(ToDecimal(txtHaber.Text))
   '         Call txtEquiUfvLoad(ToDecimal(txtHaber.Text))
   '         txtDebe.Text = "0.0"
   '         txtDebe.Tag = ""
   '      End If
   '   End Sub
   '#End Region

#Region " Check "
   Private Sub chkPlan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlan.CheckedChanged
      If chkPlan.Checked Then
         cboPlan.DisplayMember = "PlanDes"
      Else
         cboPlan.DisplayMember = "PlanCta"
      End If
   End Sub

   Private Sub chkCentroCosto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCentroCosto.CheckedChanged
      If chkCentroCosto.Checked Then
         cboCentroCosto.DisplayMember = "CentroCostoDes"
      Else
         cboCentroCosto.DisplayMember = "CentroCostoCod"
      End If
   End Sub
#End Region

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
End Class
