Public Class frmPlanEdit
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboTipoGrupo As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents chkMostrarAnaAdd As Janus.Windows.EditControls.UICheckBox
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

   WriteOnly Property DataObject() As clsPlan
      Set(ByVal Value As clsPlan)
         moPlan = Value
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
   Friend WithEvents txtPlanId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPlanPadreId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPlanCta As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPlanDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtNivel As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents chkEsAna As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents chkTieneAnaAdd As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents grbDetail As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents txtOrden As Janus.Windows.GridEX.EditControls.NumericEditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboTipoPlan As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboSucCCO As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grbDetail = New Janus.Windows.EditControls.UIGroupBox
      Me.chkMostrarAnaAdd = New Janus.Windows.EditControls.UICheckBox
      Me.cboSucCCO = New Janus.Windows.EditControls.UIComboBox
      Me.cboTipoPlan = New Janus.Windows.EditControls.UIComboBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.chkTieneAnaAdd = New Janus.Windows.EditControls.UICheckBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label14 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboTipoGrupo = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.txtOrden = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.chkEsAna = New Janus.Windows.EditControls.UICheckBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtNivel = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPlanDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPlanCta = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPlanPadreId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtPlanId = New Janus.Windows.GridEX.EditControls.EditBox
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
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grbDetail, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbDetail.SuspendLayout()
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
      Me.bcgMain.Controls.Add(Me.grbDetail)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 381)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grbDetail
      '
      Me.grbDetail.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbDetail.Controls.Add(Me.chkMostrarAnaAdd)
      Me.grbDetail.Controls.Add(Me.cboSucCCO)
      Me.grbDetail.Controls.Add(Me.cboTipoPlan)
      Me.grbDetail.Controls.Add(Me.cboMoneda)
      Me.grbDetail.Controls.Add(Me.chkTieneAnaAdd)
      Me.grbDetail.Controls.Add(Me.Label5)
      Me.grbDetail.Controls.Add(Me.Label7)
      Me.grbDetail.Controls.Add(Me.Label14)
      Me.grbDetail.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbDetail.Location = New System.Drawing.Point(8, 236)
      Me.grbDetail.Name = "grbDetail"
      Me.grbDetail.Size = New System.Drawing.Size(444, 140)
      Me.grbDetail.TabIndex = 10
      Me.grbDetail.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkMostrarAnaAdd
      '
      Me.chkMostrarAnaAdd.BackColor = System.Drawing.Color.Transparent
      Me.chkMostrarAnaAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkMostrarAnaAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkMostrarAnaAdd.Location = New System.Drawing.Point(240, 116)
      Me.chkMostrarAnaAdd.Name = "chkMostrarAnaAdd"
      Me.chkMostrarAnaAdd.Size = New System.Drawing.Size(196, 20)
      Me.chkMostrarAnaAdd.TabIndex = 15
      Me.chkMostrarAnaAdd.Text = "Mostrar Analíticos Adicionales"
      Me.chkMostrarAnaAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboSucCCO
      '
      Me.cboSucCCO.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucCCO.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucCCO.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucCCO.Location = New System.Drawing.Point(116, 64)
      Me.cboSucCCO.Name = "cboSucCCO"
      Me.cboSucCCO.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucCCO.Size = New System.Drawing.Size(320, 20)
      Me.cboSucCCO.TabIndex = 13
      Me.cboSucCCO.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboTipoPlan
      '
      Me.cboTipoPlan.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPlan.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoPlan.Location = New System.Drawing.Point(116, 40)
      Me.cboTipoPlan.Name = "cboTipoPlan"
      Me.cboTipoPlan.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoPlan.Size = New System.Drawing.Size(320, 20)
      Me.cboTipoPlan.TabIndex = 12
      Me.cboTipoPlan.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(116, 16)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(320, 20)
      Me.cboMoneda.TabIndex = 11
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkTieneAnaAdd
      '
      Me.chkTieneAnaAdd.BackColor = System.Drawing.Color.Transparent
      Me.chkTieneAnaAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkTieneAnaAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkTieneAnaAdd.Location = New System.Drawing.Point(252, 92)
      Me.chkTieneAnaAdd.Name = "chkTieneAnaAdd"
      Me.chkTieneAnaAdd.Size = New System.Drawing.Size(184, 20)
      Me.chkTieneAnaAdd.TabIndex = 14
      Me.chkTieneAnaAdd.Text = "Tiene Analíticos Adicionales"
      Me.chkTieneAnaAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 68)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 180
      Me.Label5.Text = "Sucursal / CCO"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 20)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 179
      Me.Label7.Text = "Moneda"
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(8, 44)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(104, 16)
      Me.Label14.TabIndex = 178
      Me.Label14.Text = "Tipo Cuenta"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboTipoGrupo)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.txtOrden)
      Me.grpMain.Controls.Add(Me.chkEsAna)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.txtNivel)
      Me.grpMain.Controls.Add(Me.txtPlanDes)
      Me.grpMain.Controls.Add(Me.txtPlanCta)
      Me.grpMain.Controls.Add(Me.txtPlanPadreId)
      Me.grpMain.Controls.Add(Me.txtPlanId)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 236)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboTipoGrupo
      '
      Me.cboTipoGrupo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoGrupo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoGrupo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoGrupo.Location = New System.Drawing.Point(116, 112)
      Me.cboTipoGrupo.Name = "cboTipoGrupo"
      Me.cboTipoGrupo.ReadOnly = True
      Me.cboTipoGrupo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoGrupo.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoGrupo.TabIndex = 5
      Me.cboTipoGrupo.TabStop = False
      Me.cboTipoGrupo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 116)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 194
      Me.Label1.Text = "Grupo Cuenta"
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
      'chkEsAna
      '
      Me.chkEsAna.BackColor = System.Drawing.Color.Transparent
      Me.chkEsAna.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkEsAna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkEsAna.Location = New System.Drawing.Point(268, 212)
      Me.chkEsAna.Name = "chkEsAna"
      Me.chkEsAna.Size = New System.Drawing.Size(168, 20)
      Me.chkEsAna.TabIndex = 9
      Me.chkEsAna.Text = "Cuenta de Nivel Analítico"
      Me.chkEsAna.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      'txtPlanDes
      '
      Me.txtPlanDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanDes.Location = New System.Drawing.Point(116, 88)
      Me.txtPlanDes.MaxLength = 255
      Me.txtPlanDes.Name = "txtPlanDes"
      Me.txtPlanDes.Size = New System.Drawing.Size(320, 20)
      Me.txtPlanDes.TabIndex = 4
      Me.txtPlanDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPlanCta
      '
      Me.txtPlanCta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanCta.Location = New System.Drawing.Point(116, 64)
      Me.txtPlanCta.MaxLength = 50
      Me.txtPlanCta.Name = "txtPlanCta"
      Me.txtPlanCta.Size = New System.Drawing.Size(124, 20)
      Me.txtPlanCta.TabIndex = 3
      Me.txtPlanCta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanCta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPlanPadreId
      '
      Me.txtPlanPadreId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanPadreId.Location = New System.Drawing.Point(116, 40)
      Me.txtPlanPadreId.Name = "txtPlanPadreId"
      Me.txtPlanPadreId.ReadOnly = True
      Me.txtPlanPadreId.Size = New System.Drawing.Size(320, 20)
      Me.txtPlanPadreId.TabIndex = 2
      Me.txtPlanPadreId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanPadreId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtPlanId
      '
      Me.txtPlanId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPlanId.Location = New System.Drawing.Point(116, 16)
      Me.txtPlanId.Name = "txtPlanId"
      Me.txtPlanId.ReadOnly = True
      Me.txtPlanId.Size = New System.Drawing.Size(124, 20)
      Me.txtPlanId.TabIndex = 1
      Me.txtPlanId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPlanId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.Label15.Location = New System.Drawing.Point(8, 92)
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
      'frmPlanEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 409)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmPlanEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Plan Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grbDetail, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbDetail.ResumeLayout(False)
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
               mlngID = moPlan.PlanId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPlanEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPlanEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Cuenta"

         Else
            Me.Text = "Editar Cuenta"

            If EsAnaFind(moPlan.PlanId) Then
               If TieneMovimiento(moPlan.PlanId) Then
                  chkEsAna.Enabled = False
                  'grbDetail.Enabled = False
                  Call grpDetailShow(False)
               End If

            ElseIf NumeroHijos(moPlan.PlanId) > 0 Then
               chkEsAna.Enabled = False
               'grbDetail.Enabled = False
               Call grpDetailShow(False)
            Else
               Call grpDetailShow(False)
            End If
         End If

      Else
         Me.Text = "Nueva Cuenta"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moPlan
         txtPlanId.Text = ToStr(.PlanId)
         Call txtPlanPadreIdLoad(.PlanPadreId, 0)
         txtPlanCta.Text = ToStr(.PlanCta)
         txtPlanDes.Text = ToStr(.PlanDes)
         txtNivel.Text = ToStr(.Nivel)
         txtOrden.Text = ToStr(.Orden)
         cboTipoGrupo.SelectedIndex = ListFindItem(cboTipoGrupo, .TipoGrupoId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         chkEsAna.Checked = .EsAna

         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         cboTipoPlan.SelectedIndex = ListFindItem(cboTipoPlan, .TipoPlanId)
         cboSucCCO.SelectedIndex = ListFindItem(cboSucCCO, .SucCCOId)
         chkTieneAnaAdd.Checked = .TieneAnaAdd
         chkMostrarAnaAdd.Checked = .MostrarAnaAdd

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Cuenta"
               .VMOld.ToShowOpe()
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsPlanVM)
      oVM = New clsPlanVM

      With oVM
         .PlanId = moPlan.PlanId
         .EmpresaId = moPlan.EmpresaId
         .PlanDes = moPlan.PlanDes
         .PlanCta = moPlan.PlanCta
         .EsAna = ToByte(chkEsAna.Checked)
         .PlanPadreId = moPlan.PlanPadreId
         .PlanPadreDes = txtPlanPadreId.Text
         .Orden = moPlan.Orden
         .Nivel = moPlan.Nivel
         .TipoPlanId = moPlan.TipoPlanId
         .TipoPlanDes = cboTipoPlan.Text
         .TipoGrupoId = moPlan.TipoGrupoId
         .TipoGrupoDes = cboTipoGrupo.Text
         .MonedaId = moPlan.MonedaId
         .MonedaDes = cboMoneda.Text
         .TieneAnaAdd = ToByte(chkTieneAnaAdd.Checked)
         .MostrarAnaAdd = ToByte(chkMostrarAnaAdd.Checked)
         .SucCCOId = moPlan.SucCCOId
         .SucCCODes = cboSucCCO.Text
         .EstadoId = moPlan.EstadoId
         .EstadoDes = cboEstado.Text
         
         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      Dim lngTipoGrupoId As Long = 0

      mboolShow = True
      With moPlan
         txtPlanId.Text = String.Empty
         Call txtPlanPadreIdLoad(.PlanPadreId, lngTipoGrupoId)
         txtPlanDes.Text = String.Empty
         Call txtPlanCuentaLoad()
         cboTipoGrupo.SelectedIndex = ListFindItem(cboTipoGrupo, lngTipoGrupoId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 1)
         chkEsAna.Checked = False

         cboMoneda.SelectedIndex = -1
         cboTipoPlan.SelectedIndex = -1
         cboSucCCO.SelectedIndex = -1
         chkTieneAnaAdd.Checked = False
         chkMostrarAnaAdd.Checked = False

         'grbDetail.Enabled = False
         Call grpDetailShow(False)
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtPlanId.ReadOnly = True
      txtPlanPadreId.ReadOnly = True
      txtPlanDes.ReadOnly = True
      txtPlanCta.ReadOnly = True
      cboTipoGrupo.ReadOnly = True
      txtNivel.ReadOnly = True
      txtOrden.ReadOnly = True
      cboEstado.ReadOnly = True
      chkEsAna.Enabled = False

      cboMoneda.Enabled = False
      cboTipoPlan.Enabled = False
      cboSucCCO.Enabled = False
      chkTieneAnaAdd.Enabled = False
      chkMostrarAnaAdd.Enabled = False

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moPlan
         If Not mboolAdding Then
            .PlanId = ToLong(txtPlanId.Text)
         End If

         .PlanPadreId = ToLong(txtPlanPadreId.Tag)
         .PlanDes = ToStr(txtPlanDes.Text)
         .PlanCta = ToStr(txtPlanCta.Text)
         .Nivel = ToLong(txtNivel.Text)
         .Orden = ToLong(txtOrden.Text)
         .TipoGrupoId = ListPosition(cboTipoGrupo, cboTipoGrupo.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
         .EsAna = ToBoolean(chkEsAna.Checked)

         If .EsAna = 1 Then
            .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
            .TipoPlanId = ListPosition(cboTipoPlan, cboTipoPlan.SelectedIndex)
            .SucCCOId = ListPosition(cboSucCCO, cboSucCCO.SelectedIndex)
            .TieneAnaAdd = ToBoolean(chkTieneAnaAdd.Checked)

            If .TieneAnaAdd = 1 Then
               .MostrarAnaAdd = ToBoolean(chkMostrarAnaAdd.Checked)
            Else
               .MostrarAnaAdd = 0
            End If
         Else
            .MonedaId = 0
            .TipoPlanId = 0
            .SucCCOId = 0
            .TieneAnaAdd = 0
            .MostrarAnaAdd = 0
         End If

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtPlanDes.Select()
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMessage As String = ""

      FormCheck = True

      If NumeroHijos(moPlan.PlanPadreId, moPlan.PlanId) > 0 Then
         If PadreTieneHijosGrupo(moPlan.PlanPadreId) Then
            If chkEsAna.Checked Then
               MessageBox.Show("Solo puede agregar Cuentas No Análiticas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Return False
            End If
         Else
            If Not chkEsAna.Checked Then
               MessageBox.Show("Solo puede agregar Cuentas Análiticas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Return False
            End If
         End If
      End If

      If strMessage <> "" Then
         FormCheck = False
         MessageBox.Show(strMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

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

         If moPlan.Insert() Then
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

         If moPlan.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtPlanId.MaxLength = 20
      txtPlanPadreId.MaxLength = 255
      txtPlanDes.MaxLength = 255
      txtPlanCta.MaxLength = 50
      txtNivel.MaxLength = 20
      txtOrden.MaxLength = 20
   End Sub

   Private Sub ComboLoad()
      Call cboTipoPlanLoad()
      Call cboTipoGrupoLoad()
      Call cboEstadoLoad()
      Call cboSucCCOLoad()
      Call cboMonedaLoad()
   End Sub

   Private Function EsAnaFind(ByVal lngPlanId As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         EsAnaFind = False

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               EsAnaFind = ToBoolean(.EsAna)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function TieneMovimiento(ByVal lngPlanId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         TieneMovimiento = True

         With oCompDet
            .RowCountFilter = clsCompDet.RowCountFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanId
            .EmpresaId = moPlan.EmpresaId
            .PlanId = lngPlanId

            If ToLong(.RowCount) = 0 Then
               TieneMovimiento = False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function NumeroHijos(ByVal lngPlanPadreId As Long, Optional ByVal lngPlanHijoId As Long = 0) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         NumeroHijos = 0

         With oPlan
            .RowCountFilter = clsPlan.RowCountFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanPadreId
            .EmpresaId = moPlan.EmpresaId
            .PlanPadreId = lngPlanPadreId
            .PlanId = lngPlanHijoId
            NumeroHijos = ToLong(.RowCount)
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function PadreTieneHijosGrupo(ByVal lngPlanPadreId As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      PadreTieneHijosGrupo = False
      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanPadreId
            .EmpresaId = moPlan.EmpresaId
            .PlanPadreId = lngPlanPadreId

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
         oPlan.Dispose()
      End Try
   End Function

   Private Sub txtPlanPadreIdLoad(ByVal lngPlanId As Long, ByRef lngTipoGrupoId As Long)
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               txtPlanPadreId.Tag = .PlanId
               txtPlanPadreId.Text = .PlanDes

               lngTipoGrupoId = .TipoGrupoId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Sub txtPlanCuentaLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim intRowMax As Integer

      Try
         With oPlan
            .RowMaxFilter = clsPlan.RowMaxFilters.Orden
            .WhereFilter = clsPlan.WhereFilters.PlanPadreId
            .EmpresaId = moPlan.EmpresaId
            .PlanPadreId = moPlan.PlanPadreId
            intRowMax = .RowMax

            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.Orden
            .EmpresaId = moPlan.EmpresaId
            .PlanPadreId = moPlan.PlanPadreId
            .Orden = intRowMax

            If .Find Then
               txtPlanCta.Text = CStr(ToLong(.PlanCta) + 1)
               txtNivel.Text = ToStr(.Nivel)
               txtOrden.Text = ToStr(.Orden + 1)
            Else
               .PlanId = moPlan.PlanPadreId

               If .FindByPK Then
                  txtPlanCta.Text = ToStr(.PlanCta)
                  txtNivel.Text = ToStr(.Nivel + 1)
                  txtOrden.Text = "1"
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Sub cboTipoPlanLoad()
      Dim oTipoPlan As New clsTipoPlan(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoPlan.Items.Clear()

      Try
         With oTipoPlan
            .SelectFilter = clsTipoPlan.SelectFilters.ListBox
            .OrderByFilter = clsTipoPlan.OrderByFilters.TipoPlanDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoPlanId, .TipoPlanDes)

                  cboTipoPlan.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoPlan.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoGrupoLoad()
      Dim oTipoGrupo As New clsTipoGrupo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoGrupo.Items.Clear()

      Try
         With oTipoGrupo
            .SelectFilter = clsTipoGrupo.SelectFilters.ListBox
            .OrderByFilter = clsTipoGrupo.OrderByFilters.TipoGrupoDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoGrupoId, .TipoGrupoDes)

                  cboTipoGrupo.Items.Add(oItem)
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

   Private Sub cboSucCCOLoad()
      Dim oSucCCO As New clsSucCCO(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSucCCO.Items.Clear()

      Try
         With oSucCCO
            .SelectFilter = clsSucCCO.SelectFilters.ListBox
            .OrderByFilter = clsSucCCO.OrderByFilters.SucCCODes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.SucCCOId, .SucCCODes)

                  cboSucCCO.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oSucCCO.Dispose()
         oItem = Nothing

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

   Private Sub chkEsAna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEsAna.CheckedChanged
      If chkEsAna.Checked = True Then
         'grbDetail.Enabled = True
         Call grpDetailShow(True)

         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, MonedaIdPredeterminada(moPlan.EmpresaId))
         cboTipoPlan.SelectedIndex = ListFindItem(cboTipoPlan, 0)
         cboSucCCO.SelectedIndex = ListFindItem(cboSucCCO, 0)
      Else
         'grbDetail.Enabled = False
         Call grpDetailShow(False)

         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, -1)
         cboTipoPlan.SelectedIndex = ListFindItem(cboTipoPlan, -1)
         cboSucCCO.SelectedIndex = ListFindItem(cboSucCCO, -1)
         chkTieneAnaAdd.Checked = False
         chkMostrarAnaAdd.Checked = False
      End If
   End Sub

   Private Sub frmPlanEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moPlan.PlanId
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPlanEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub grpDetailShow(ByVal boolEnabled As Boolean)
      cboMoneda.Enabled = boolEnabled
      cboTipoPlan.Enabled = boolEnabled
      cboSucCCO.Enabled = boolEnabled
      chkTieneAnaAdd.Enabled = boolEnabled
      If chkTieneAnaAdd.Checked Then
         chkMostrarAnaAdd.Enabled = True
      Else
         chkMostrarAnaAdd.Enabled = False
      End If
   End Sub

   Private Sub chkTieneAnaAdd_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTieneAnaAdd.CheckedChanged
      If chkTieneAnaAdd.Checked Then
         chkMostrarAnaAdd.Enabled = True
      Else
         chkMostrarAnaAdd.Enabled = False
      End If
   End Sub
End Class
