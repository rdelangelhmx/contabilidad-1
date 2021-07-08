Public Class frmCompPlanEEFFSelect
   Inherits System.Windows.Forms.Form

   Private mlngPlanId As String
   Private mstrPlanDes As String
   Private mdecImporteITF As Decimal
   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents txtPlanId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
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

   WriteOnly Property PlanDes() As String
      Set(ByVal Value As String)
         mstrPlanDes = Value
      End Set
   End Property

   WriteOnly Property PlanId() As Long
      Set(ByVal Value As Long)
         mlngPlanId = Value
      End Set
   End Property

   WriteOnly Property ImporteITF() As Decimal
      Set(ByVal Value As Decimal)
         mdecImporteITF = Value
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
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents txtCompPlanEEFFId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEqui As Janus.Windows.GridEX.EditControls.NumericEditBox
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
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboPlanEEFF As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboPlanEEFF_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompPlanEEFFSelect))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtPlanId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboPlanEEFF = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtEqui = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtCompPlanEEFFId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
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
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cboPlanEEFF, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 75)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtPlanId)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.cboPlanEEFF)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.txtEqui)
      Me.grpMain.Controls.Add(Me.txtImporte)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtCompPlanEEFFId)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label19)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 68)
      Me.grpMain.TabIndex = 159
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtPlanId
      '
      Me.txtPlanId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanId.Location = New System.Drawing.Point(116, 16)
      Me.txtPlanId.Name = "txtPlanId"
      Me.txtPlanId.ReadOnly = True
      Me.txtPlanId.Size = New System.Drawing.Size(320, 20)
      Me.txtPlanId.TabIndex = 212
      Me.txtPlanId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 20)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 213
      Me.Label1.Text = "Cuenta Corriente"
      '
      'cboPlanEEFF
      '
      cboPlanEEFF_DesignTimeLayout.LayoutString = resources.GetString("cboPlanEEFF_DesignTimeLayout.LayoutString")
      Me.cboPlanEEFF.DesignTimeLayout = cboPlanEEFF_DesignTimeLayout
      Me.cboPlanEEFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanEEFF.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanEEFF.Location = New System.Drawing.Point(116, 40)
      Me.cboPlanEEFF.Name = "cboPlanEEFF"
      Me.cboPlanEEFF.SelectedIndex = -1
      Me.cboPlanEEFF.SelectedItem = Nothing
      Me.cboPlanEEFF.Size = New System.Drawing.Size(320, 20)
      Me.cboPlanEEFF.TabIndex = 2
      Me.cboPlanEEFF.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanEEFF.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label6.Location = New System.Drawing.Point(8, 44)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 211
      Me.Label6.Text = "Cuenta de Flujo"
      '
      'txtEqui
      '
      Me.txtEqui.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEqui.FormatString = "##,##0.000"
      Me.txtEqui.Location = New System.Drawing.Point(116, 112)
      Me.txtEqui.Name = "txtEqui"
      Me.txtEqui.ReadOnly = True
      Me.txtEqui.Size = New System.Drawing.Size(124, 20)
      Me.txtEqui.TabIndex = 5
      Me.txtEqui.TabStop = False
      Me.txtEqui.Text = "0,000"
      Me.txtEqui.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtEqui.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtEqui.Visible = False
      Me.txtEqui.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtImporte
      '
      Me.txtImporte.BackColor = System.Drawing.SystemColors.Info
      Me.txtImporte.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporte.FormatString = "##,##0.000"
      Me.txtImporte.Location = New System.Drawing.Point(116, 64)
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.ReadOnly = True
      Me.txtImporte.Size = New System.Drawing.Size(124, 20)
      Me.txtImporte.TabIndex = 3
      Me.txtImporte.Text = "0,000"
      Me.txtImporte.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporte.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporte.Visible = False
      Me.txtImporte.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(116, 100)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(320, 20)
      Me.txtEmpresaId.TabIndex = 1
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.Visible = False
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCompPlanEEFFId
      '
      Me.txtCompPlanEEFFId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompPlanEEFFId.Location = New System.Drawing.Point(116, 16)
      Me.txtCompPlanEEFFId.Name = "txtCompPlanEEFFId"
      Me.txtCompPlanEEFFId.ReadOnly = True
      Me.txtCompPlanEEFFId.Size = New System.Drawing.Size(124, 20)
      Me.txtCompPlanEEFFId.TabIndex = 0
      Me.txtCompPlanEEFFId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompPlanEEFFId.Visible = False
      Me.txtCompPlanEEFFId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 116)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 204
      Me.Label12.Text = "Equivalencia"
      Me.Label12.Visible = False
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 68)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 202
      Me.Label15.Text = "Importe ITF"
      Me.Label15.Visible = False
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(8, 104)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 201
      Me.Label16.Text = "Empresa"
      Me.Label16.Visible = False
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
      Me.Label19.Visible = False
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
      'frmCompPlanEEFFSelect
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 103)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompPlanEEFFSelect"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompPlanEEFF Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboPlanEEFF, System.ComponentModel.ISupportInitialize).EndInit()
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
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompPlanEEFFSelect_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompPlanEEFFSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()

      If Not mboolAdding Then
         If Not mboolEditing Then
            Call FormShow()
            Call DataReadOnly()
            Me.Text = "Consulta Mov. Flujo de Efectivo"
         Else
            Call FormEdit()
            Me.Text = "Editar  Mov. Flujo de Efectivo"
         End If
      Else
         Me.Text = "Nuevo  Mov. Flujo de Efectivo por ITF"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      'With moCompPlanEEFF
      '   txtCompPlanEEFFId.Text = ToStr(.CompPlanEEFFId)
      '   Call txtEmpresaIdLoad(.EmpresaId)
      '   cboPlanEEFF.Value = ListFindItem(cboPlanEEFF, .PlanEEFFId)
      'End With

      mboolShow = False
   End Sub

   Private Sub FormEdit()
      mboolShow = True
      'With moCompPlanEEFF
      '   txtCompPlanEEFFId.Text = ToStr(.CompPlanEEFFId)
      '   cboPlanEEFF.Value = ListFindItem(cboPlanEEFF, .PlanEEFFId)
      'End With

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      '   txtCompPlanEEFFId.Text = String.Empty
      '   Call txtEmpresaIdLoad(.EmpresaId)
      'cboPlanEEFF.Value = Nothing
      'cboPlanEEFF.Text = ""
      'txtPlanId.Text = PlanDesFind()
      txtPlanId.Text = mstrPlanDes
      txtImporte.Text = ToDecimal(mdecImporteITF)
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      'txtCompPlanEEFFId.ReadOnly = True
      'txtEmpresaId.ReadOnly = True
      'cboPlanEEFF.ReadOnly = True
      'txtImporte.ReadOnly = True
      'txtEqui.ReadOnly = True

      'cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboPlanEEFF.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         If FormCheck() Then
            mlngID = ListPosition(cboPlanEEFF)
            DataSave = True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If ListPosition(cboPlanEEFF) <= 0 Then
         FormCheck = False
         Throw New Exception("Debe seleccionar una Cuenta de Flujo de Efectivo")
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)
   End Sub

   Private Sub ComboLoad()
      Call cboPlanEEFFLoad()
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

   Private Sub cboPlanEEFFLoad()
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      Try
         With oPlanEEFF
            .SelectFilter = clsPlanEEFF.SelectFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.EsAna
            .OrderByFilter = clsPlanEEFF.OrderByFilters.PlanEEFFDes
            .EmpresaId = clsAppInfo.EmpresaId
            .EsAna = ToBoolean(True)

            If .Open() Then
               With cboPlanEEFF
                  .DropDownList.Columns.Clear()

                  .DropDownList.Columns.Add("PlanEEFFId")
                  .DropDownList.Columns("PlanEEFFId").DataMember = "PlanEEFFId"
                  .DropDownList.Columns("PlanEEFFId").Visible = False

                  .DropDownList.Columns.Add("PlanEEFFCta")
                  .DropDownList.Columns("PlanEEFFCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanEEFFCta").DataMember = "PlanEEFFCta"
                  .DropDownList.Columns("PlanEEFFCta").Width = 100

                  .DropDownList.Columns.Add("PlanEEFFDes")
                  .DropDownList.Columns("PlanEEFFDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanEEFFDes").DataMember = "PlanEEFFDes"
                  .DropDownList.Columns("PlanEEFFDes").Width = 205

                  .DataMember = oPlanEEFF.TableName
                  .DataSource = oPlanEEFF.DataSet

                  .ValueMember = "PlanEEFFId"
                  .DisplayMember = "PlanEEFFDes"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Sub

   Private Sub cboPlanEEFF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPlanEEFF.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmPlanEEFFEdit
               Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False
                     oPlanEEFF.EmpresaId = clsAppInfo.EmpresaId
                     .DataObject = oPlanEEFF
                     .ShowDialog()

                     If .Changed Then
                        Call cboPlanEEFFLoad()
                        cboPlanEEFF.Value = ListFindItem(cboPlanEEFF, ToLong(frm.ID))
                     End If

                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oPlanEEFF.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub frmCompPlanEEFFSelect_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompPlanEEFFSelect_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

End Class
