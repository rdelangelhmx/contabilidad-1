Public Class frmPlanEEFFEdit
   Inherits System.Windows.Forms.Form

   Private moPlanEEFF As clsPlanEEFF
   
   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboTipoEEFF As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents chkEsAna As Janus.Windows.EditControls.UICheckBox
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

   WriteOnly Property DataObject() As clsPlanEEFF
      Set(ByVal Value As clsPlanEEFF)
         moPlanEEFF = Value
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
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents txtPlanEEFFId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPlanEEFFPadreId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPlanEEFFCta As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPlanEEFFDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtNivel As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
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
   Friend WithEvents txtOrden As Janus.Windows.GridEX.EditControls.NumericEditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanEEFFEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboTipoEEFF = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.txtOrden = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtNivel = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPlanEEFFDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPlanEEFFCta = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPlanEEFFPadreId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPlanEEFFId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.chkEsAna = New Janus.Windows.EditControls.UICheckBox
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
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
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 244)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.chkEsAna)
      Me.grpMain.Controls.Add(Me.cboTipoEEFF)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.txtOrden)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.txtNivel)
      Me.grpMain.Controls.Add(Me.txtPlanEEFFDes)
      Me.grpMain.Controls.Add(Me.txtPlanEEFFCta)
      Me.grpMain.Controls.Add(Me.txtPlanEEFFPadreId)
      Me.grpMain.Controls.Add(Me.txtPlanEEFFId)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(448, 236)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboTipoEEFF
      '
      Me.cboTipoEEFF.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoEEFF.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoEEFF.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoEEFF.Location = New System.Drawing.Point(116, 88)
      Me.cboTipoEEFF.Name = "cboTipoEEFF"
      Me.cboTipoEEFF.ReadOnly = True
      Me.cboTipoEEFF.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoEEFF.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoEEFF.TabIndex = 5
      Me.cboTipoEEFF.TabStop = False
      Me.cboTipoEEFF.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 92)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 194
      Me.Label1.Text = "Tipo"
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(116, 184)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(320, 20)
      Me.cboEstado.TabIndex = 8
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtOrden
      '
      Me.txtOrden.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtOrden.FormatString = "##"
      Me.txtOrden.Location = New System.Drawing.Point(116, 160)
      Me.txtOrden.MaxLength = 4
      Me.txtOrden.Name = "txtOrden"
      Me.txtOrden.Size = New System.Drawing.Size(124, 20)
      Me.txtOrden.TabIndex = 7
      Me.txtOrden.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtOrden.Value = 0
      Me.txtOrden.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtOrden.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 164)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 192
      Me.Label18.Text = "Orden"
      '
      'txtNivel
      '
      Me.txtNivel.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNivel.Location = New System.Drawing.Point(116, 136)
      Me.txtNivel.Name = "txtNivel"
      Me.txtNivel.ReadOnly = True
      Me.txtNivel.Size = New System.Drawing.Size(124, 20)
      Me.txtNivel.TabIndex = 6
      Me.txtNivel.TabStop = False
      Me.txtNivel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNivel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPlanEEFFDes
      '
      Me.txtPlanEEFFDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanEEFFDes.Location = New System.Drawing.Point(116, 112)
      Me.txtPlanEEFFDes.MaxLength = 255
      Me.txtPlanEEFFDes.Name = "txtPlanEEFFDes"
      Me.txtPlanEEFFDes.Size = New System.Drawing.Size(320, 20)
      Me.txtPlanEEFFDes.TabIndex = 4
      Me.txtPlanEEFFDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanEEFFDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPlanEEFFCta
      '
      Me.txtPlanEEFFCta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanEEFFCta.Location = New System.Drawing.Point(116, 64)
      Me.txtPlanEEFFCta.MaxLength = 50
      Me.txtPlanEEFFCta.Name = "txtPlanEEFFCta"
      Me.txtPlanEEFFCta.Size = New System.Drawing.Size(124, 20)
      Me.txtPlanEEFFCta.TabIndex = 3
      Me.txtPlanEEFFCta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanEEFFCta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPlanEEFFPadreId
      '
      Me.txtPlanEEFFPadreId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanEEFFPadreId.Location = New System.Drawing.Point(116, 40)
      Me.txtPlanEEFFPadreId.Name = "txtPlanEEFFPadreId"
      Me.txtPlanEEFFPadreId.ReadOnly = True
      Me.txtPlanEEFFPadreId.Size = New System.Drawing.Size(320, 20)
      Me.txtPlanEEFFPadreId.TabIndex = 2
      Me.txtPlanEEFFPadreId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanEEFFPadreId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPlanEEFFId
      '
      Me.txtPlanEEFFId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanEEFFId.Location = New System.Drawing.Point(116, 16)
      Me.txtPlanEEFFId.Name = "txtPlanEEFFId"
      Me.txtPlanEEFFId.ReadOnly = True
      Me.txtPlanEEFFId.Size = New System.Drawing.Size(124, 20)
      Me.txtPlanEEFFId.TabIndex = 1
      Me.txtPlanEEFFId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanEEFFId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 188)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 185
      Me.Label6.Text = "Estado"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 140)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 183
      Me.Label10.Text = "Nivel"
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 44)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 182
      Me.Label12.Text = "Cuenta Padre"
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 116)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 181
      Me.Label15.Text = "Descripción"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(8, 68)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 180
      Me.Label16.Text = "Código Cuenta"
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(8, 20)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(104, 16)
      Me.Label17.TabIndex = 179
      Me.Label17.Text = "ID"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("6d5a6891-6dac-48b9-97e9-39ff09a926c6")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Exit1})
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
      'chkEsAna
      '
      Me.chkEsAna.BackColor = System.Drawing.Color.Transparent
      Me.chkEsAna.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkEsAna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkEsAna.Location = New System.Drawing.Point(268, 212)
      Me.chkEsAna.Name = "chkEsAna"
      Me.chkEsAna.Size = New System.Drawing.Size(168, 20)
      Me.chkEsAna.TabIndex = 196
      Me.chkEsAna.Text = "Cuenta de Nivel Analítico"
      Me.chkEsAna.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'frmPlanEEFFEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 272)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmPlanEEFFEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Plan Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
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
         Case "Save"
            If DataSave() Then
               mlngID = moPlanEEFF.PlanEEFFId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPlanEEFFEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPlanEEFFEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Cuenta Flujo de Efectivo"

         Else
            Me.Text = "Editar Cuenta Flujo de Efectivo"

            If EsAnaFind(moPlanEEFF.PlanEEFFId) Then
               If TieneMovimiento(moPlanEEFF.PlanEEFFId) Then
                  chkEsAna.Enabled = False
               ElseIf NumeroHijos(moPlanEEFF.PlanEEFFPadreId, moPlanEEFF.PlanEEFFId) > 0 Then
                  chkEsAna.Enabled = False
               End If
            ElseIf NumeroHijos(moPlanEEFF.PlanEEFFId) > 0 Then
               chkEsAna.Enabled = False
            ElseIf NumeroHijos(moPlanEEFF.PlanEEFFPadreId, moPlanEEFF.PlanEEFFId) > 0 Then
               chkEsAna.Enabled = False
            End If
         End If
      Else
         Me.Text = "Nueva Cuenta Flujo de Efectivo"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      Dim lngTipoEEFFId As Long = 0
      With moPlanEEFF
         txtPlanEEFFId.Text = ToStr(.PlanEEFFId)
         Call txtPlanEEFFPadreIdLoad(.PlanEEFFPadreId, lngTipoEEFFId) ', 0)
         txtPlanEEFFCta.Text = ToStr(.PlanEEFFCta)
         txtPlanEEFFDes.Text = ToStr(.PlanEEFFDes)
         txtNivel.Text = ToStr(.Nivel)
         txtOrden.Text = ToStr(.Orden)

         If .Nivel = 2 Then
            txtOrden.ReadOnly = True
         End If

         cboTipoEEFF.SelectedIndex = ListFindItem(cboTipoEEFF, .TipoEEFFId)
         chkEsAna.Checked = ToBoolean(.EsAna)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Cuenta Flujo de Efectivo"
               .VMOld.ToShowOpe()
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsPlanEEFFVM)
      oVM = New clsPlanEEFFVM

      With oVM
         .PlanEEFFId = moPlanEEFF.PlanEEFFId
         .EmpresaId = moPlanEEFF.EmpresaId
         .TipoEEFFId = moPlanEEFF.TipoEEFFId
         .PlanEEFFPadreId = moPlanEEFF.PlanEEFFPadreId
         .PlanEEFFPadreDes = txtPlanEEFFPadreId.Text
         .PlanEEFFDes = moPlanEEFF.PlanEEFFDes
         .PlanEEFFCta = moPlanEEFF.PlanEEFFCta
         .Nivel = moPlanEEFF.Nivel
         .Orden = moPlanEEFF.Orden
         .EsAna = ToByte(chkEsAna.Checked)
         .EstadoId = moPlanEEFF.EstadoId
         .EstadoDes = cboEstado.Text

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      Dim lngTipoEEFFId As Long = 0
      mboolShow = True
      With moPlanEEFF
         txtPlanEEFFId.Text = String.Empty
         Call txtPlanEEFFPadreIdLoad(.PlanEEFFPadreId, lngTipoEEFFId)
         txtPlanEEFFDes.Text = String.Empty
         Call txtPlanEEFFCuentaLoad()
         cboTipoEEFF.SelectedIndex = ListFindItem(cboTipoEEFF, lngTipoEEFFId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 1)
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtPlanEEFFId.ReadOnly = True
      txtPlanEEFFPadreId.ReadOnly = True
      txtPlanEEFFDes.ReadOnly = True
      txtPlanEEFFCta.ReadOnly = True
      cboTipoEEFF.ReadOnly = True
      txtNivel.ReadOnly = True
      txtOrden.ReadOnly = True
      cboEstado.ReadOnly = True
      chkEsAna.Enabled = False
      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moPlanEEFF
         If Not mboolAdding Then
            .PlanEEFFId = ToLong(txtPlanEEFFId.Text)
         End If

         .PlanEEFFPadreId = ToLong(txtPlanEEFFPadreId.Tag)
         .PlanEEFFDes = ToStr(txtPlanEEFFDes.Text)
         .PlanEEFFCta = ToStr(txtPlanEEFFCta.Text)
         .Nivel = ToLong(txtNivel.Text)
         .Orden = ToLong(txtOrden.Text)
         .TipoEEFFId = ListPosition(cboTipoEEFF, cboTipoEEFF.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         .EsAna = ToBoolean(chkEsAna.Checked)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtPlanEEFFDes.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()
         If FormCheck() Then
            If mboolAdding Then
               DataSave = DataAdd()
            Else
               DataSave = DataUpdate()
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

         If moPlanEEFF.Insert() Then
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

         If moPlanEEFF.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtPlanEEFFId.MaxLength = 20
      txtPlanEEFFPadreId.MaxLength = 255
      txtPlanEEFFDes.MaxLength = 255
      txtPlanEEFFCta.MaxLength = 50
      txtNivel.MaxLength = 20
      txtOrden.MaxLength = 20
   End Sub

   Private Sub ComboLoad()
      'Call cboPlanLoad()
      Call cboTipoGrupoLoad()
      Call cboEstadoLoad()
      Call cboTipoEEFFLoad()
      'Call cboMonedaLoad()
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMessage As String = ""

      FormCheck = True

      If mboolAdding Then
         If NumeroHijos(moPlanEEFF.PlanEEFFPadreId) > 0 Then
            If PadreTieneHijosGrupo(moPlanEEFF.PlanEEFFPadreId) Then
               If chkEsAna.Checked Then
                  MessageBox.Show("Solo puede agregar Flujos de Efectivo No Análiticos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Return False
               End If
            Else
               If Not chkEsAna.Checked Then
                  MessageBox.Show("Solo puede agregar Flujos de Efectivo Análiticos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Return False
               End If
            End If
         End If
      End If
      'If NumeroHijos(moPlanEEFF.PlanEEFFPadreId) > 0 Then
      '   If PadreTieneHijosGrupo(moPlanEEFF.PlanEEFFPadreId) Then
      '      If chkEsAna.Checked Then
      '         MessageBox.Show("Solo puede agregar Flujos de Efectivo No Análiticos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      '         Return False
      '      End If
      '   Else
      '      If Not chkEsAna.Checked Then
      '         MessageBox.Show("Solo puede agregar Flujos de Efectivo Análiticos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      '         Return False
      '      End If
      '   End If
      'End If
      'If grdMain.GetCheckedRows.Count = 0 Then

      'End If

      'If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
      '   strMessage &= "Fecha no Corresponde a la Gestion en Uso" & vbCrLf
      'End If

      'If ToDecimal(txtTipoCambio.Text) <= 0 Then
      '   strMessage &= "Tipo de Cambio Inválido" & vbCrLf
      'End If

      'If ListPosition(cboPlan) = 0 Then
      '   strMessage &= "Contra Cuenta Inválida" & vbCrLf
      'End If

      If strMessage <> "" Then
         FormCheck = False
         MessageBox.Show(strMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Function PadreTieneHijosGrupo(ByVal lngPlanEEFFPadreId As Long) As Boolean
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      PadreTieneHijosGrupo = False
      Try
         With oPlanEEFF
            .SelectFilter = clsPlanEEFF.SelectFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
            .EmpresaId = moPlanEEFF.EmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId

            If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               .Read()
               If Not .EsAna Then
                  PadreTieneHijosGrupo = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Function

   Private Function TieneMovimiento(ByVal lngPlanEEFFId As Long) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

      Try
         TieneMovimiento = True

         With oCompPlanEEFF
            .RowCountFilter = clsCompPlanEEFF.RowCountFilters.All
            .WhereFilter = clsCompPlanEEFF.WhereFilters.PlanEEFFId
            .EmpresaId = moPlanEEFF.EmpresaId
            .PlanEEFFId = lngPlanEEFFId

            If ToLong(.RowCount) = 0 Then
               TieneMovimiento = False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompPlanEEFF.Dispose()
      End Try
   End Function

   Private Function NumeroHijos(ByVal lngPlanEEFFPadreId As Long, Optional ByVal lngPlanEEFFHijoId As Long = 0) As Long
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      Try
         NumeroHijos = 0

         With oPlanEEFF
            .RowCountFilter = clsPlanEEFF.RowCountFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
            .EmpresaId = moPlanEEFF.EmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId
            .PlanEEFFId = lngPlanEEFFHijoId
            NumeroHijos = ToLong(.RowCount)
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Function

   Private Function EsAnaFind(ByVal lngPlanEEFFId As Long) As Boolean
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      Try
         EsAnaFind = False

         With oPlanEEFF
            .PlanEEFFId = lngPlanEEFFId

            If .FindByPK Then
               EsAnaFind = ToBoolean(.EsAna)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Function

   Private Sub txtPlanEEFFPadreIdLoad(ByVal lngPlanEEFFId As Long, ByRef lngTipoEEFFId As Long)
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      Try
         With oPlanEEFF
            .PlanEEFFId = lngPlanEEFFId

            If .FindByPK Then
               txtPlanEEFFPadreId.Tag = .PlanEEFFId
               txtPlanEEFFPadreId.Text = .PlanEEFFDes
               lngTipoEEFFId = .TipoEEFFId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Sub

   Private Sub txtPlanEEFFCuentaLoad()
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      Dim intRowMax As Integer

      Try
         With oPlanEEFF
            .RowMaxFilter = clsPlanEEFF.RowMaxFilters.Orden
            .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
            .EmpresaId = moPlanEEFF.EmpresaId
            .PlanEEFFPadreId = moPlanEEFF.PlanEEFFPadreId
            intRowMax = .RowMax

            .SelectFilter = clsPlanEEFF.SelectFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.Orden
            .EmpresaId = moPlanEEFF.EmpresaId
            .PlanEEFFPadreId = moPlanEEFF.PlanEEFFPadreId
            .Orden = intRowMax

            If .Find Then
               '  txtPlanEEFFCta.Text = CStr(ToLong(.PlanEEFFCta) + 1)
               txtNivel.Text = ToStr(.Nivel)
               txtOrden.Text = ToStr(.Orden + 1)
               txtPlanEEFFCta.Text = ToNextCod(.PlanEEFFCta, .PlanEEFFCta.Length) 'ToLong(.PlanEEFFCta) + 1
            Else
               .PlanEEFFId = moPlanEEFF.PlanEEFFPadreId

               If .FindByPK Then
                  '  txtPlanEEFFCta.Text = ToStr(.PlanEEFFCta)
                  txtNivel.Text = ToStr(.Nivel + 1)
                  txtOrden.Text = "1"
                  txtPlanEEFFCta.Text = .PlanEEFFCta & ToNextCod("0", If(.Nivel + 1 > 1, 2, 1))
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Sub

   Private Sub cboTipoPlanLoad()
      'Dim oTipoPlan As New clsTipoPlan(clsAppInfo.ConnectString)
      'Dim oItem As clsListItem

      'cboTipoPlan.Items.Clear()

      'Try
      '   With oTipoPlan
      '      .SelectFilter = clsTipoPlan.SelectFilters.ListBox
      '      .OrderByFilter = clsTipoPlan.OrderByFilters.TipoPlanDes

      '      If .Open() Then
      '         Do While .Read()
      '            oItem = New clsListItem(.TipoPlanId, .TipoPlanDes)

      '            cboTipoPlan.Items.Add(oItem)
      '            .MoveNext()
      '         Loop
      '      End If
      '   End With

      'Catch exp As Exception
      '   MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      'Finally
      '   oTipoPlan.Dispose()
      '   oItem = Nothing

      'End Try
   End Sub

   Private Sub cboTipoGrupoLoad()
      Dim oTipoGrupo As New clsTipoGrupo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoEEFF.Items.Clear()

      Try
         With oTipoGrupo
            .SelectFilter = clsTipoGrupo.SelectFilters.ListBox
            .OrderByFilter = clsTipoGrupo.OrderByFilters.TipoGrupoDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoGrupoId, .TipoGrupoDes)

                  cboTipoEEFF.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoGrupo.Dispose()
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
            .TipoId = 1

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

   Private Sub cboTipoEEFFLoad()
      Dim oItem As clsListItem
      cboTipoEEFF.Items.Clear()
      Try
         oItem = New clsListItem(1, "INGRESO")
         cboTipoEEFF.Items.Add(oItem)
         oItem = New clsListItem(2, "EGRESO")
         cboTipoEEFF.Items.Add(oItem)
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oItem = Nothing
      End Try
   End Sub

   Private Sub cboMonedaLoad()
      'Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)
      'Dim oItem As clsListItem

      'cboMoneda.Items.Clear()

      'Try
      '   With oMoneda
      '      .SelectFilter = clsMoneda.SelectFilters.ListBox
      '      .OrderByFilter = clsMoneda.OrderByFilters.MonedaDes

      '      If .Open() Then
      '         Do While .Read()
      '            If .MonedaId > 0 Then
      '               oItem = New clsListItem(.MonedaId, .MonedaDes)

      '               cboMoneda.Items.Add(oItem)
      '            End If

      '            .MoveNext()
      '         Loop
      '      End If
      '   End With

      'Catch exp As Exception
      '   MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      'Finally
      '   oMoneda.Dispose()
      '   oItem = Nothing

      'End Try
   End Sub

   Private Function MonedaIdPredeterminada(ByVal lngEmpresaId As Long) As Long
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      Try
         MonedaIdPredeterminada = 0

         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               MonedaIdPredeterminada = .MonedaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Function

   Private Sub frmPlanEEFFEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moPlanEEFF.PlanEEFFId
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPlanEEFFEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlanEEFF.Dispose()
      Call ClearMemory()
   End Sub

End Class
