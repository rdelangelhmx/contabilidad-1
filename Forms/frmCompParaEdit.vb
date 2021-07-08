Public Class frmCompParaEdit
   Inherits System.Windows.Forms.Form

   Private moCompPara As clsCompPara

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents txtNroActualFis As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNroIniFis As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cboTipoImpresion As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtRowsMax As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cboTipoRespImp As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents chkBloqueoAuto As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkEncabezadoPorHoja As Janus.Windows.EditControls.UICheckBox
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

   WriteOnly Property DataObject() As clsCompPara
      Set(ByVal Value As clsCompPara)
         moCompPara = Value
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
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtCompParaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtGestionId As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtTipoCompId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEstadoId As Janus.Windows.GridEX.EditControls.EditBox
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
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtFirma As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboTipoHoja As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtNroActual As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNroIni As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents chkNroAuto As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optNroAutoMes As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optNroAutoGestion As Janus.Windows.EditControls.UIRadioButton
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompParaEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.chkBloqueoAuto = New Janus.Windows.EditControls.UICheckBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboTipoRespImp = New Janus.Windows.EditControls.UIComboBox
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtRowsMax = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.cboTipoImpresion = New Janus.Windows.EditControls.UIComboBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.chkNroAuto = New Janus.Windows.EditControls.UICheckBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkEncabezadoPorHoja = New Janus.Windows.EditControls.UICheckBox
      Me.txtNroActualFis = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtNroIniFis = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.optNroAutoMes = New Janus.Windows.EditControls.UIRadioButton
      Me.optNroAutoGestion = New Janus.Windows.EditControls.UIRadioButton
      Me.txtNroActual = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtNroIni = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.cboTipoHoja = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtFirma = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtEstadoId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtTipoCompId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtGestionId = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtCompParaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
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
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 442)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkBloqueoAuto
      '
      Me.chkBloqueoAuto.BackColor = System.Drawing.Color.Transparent
      Me.chkBloqueoAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkBloqueoAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkBloqueoAuto.Icon = CType(resources.GetObject("chkBloqueoAuto.Icon"), System.Drawing.Icon)
      Me.chkBloqueoAuto.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText
      Me.chkBloqueoAuto.Location = New System.Drawing.Point(12, 384)
      Me.chkBloqueoAuto.Name = "chkBloqueoAuto"
      Me.chkBloqueoAuto.Size = New System.Drawing.Size(292, 20)
      Me.chkBloqueoAuto.TabIndex = 214
      Me.chkBloqueoAuto.Text = "Bloqueo Automatico al Guardar Comprobante "
      Me.chkBloqueoAuto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.chkBloqueoAuto)
      Me.grpMain.Controls.Add(Me.chkEncabezadoPorHoja)
      Me.grpMain.Controls.Add(Me.cboTipoRespImp)
      Me.grpMain.Controls.Add(Me.Label13)
      Me.grpMain.Controls.Add(Me.txtRowsMax)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.cboTipoImpresion)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.chkNroAuto)
      Me.grpMain.Controls.Add(Me.UiGroupBox1)
      Me.grpMain.Controls.Add(Me.cboTipoHoja)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtFirma)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.txtEstadoId)
      Me.grpMain.Controls.Add(Me.txtTipoCompId)
      Me.grpMain.Controls.Add(Me.txtGestionId)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtCompParaId)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 436)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboTipoRespImp
      '
      Me.cboTipoRespImp.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoRespImp.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoRespImp.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoRespImp.Location = New System.Drawing.Point(116, 332)
      Me.cboTipoRespImp.Name = "cboTipoRespImp"
      Me.cboTipoRespImp.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoRespImp.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoRespImp.TabIndex = 17
      Me.cboTipoRespImp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(8, 336)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(104, 16)
      Me.Label13.TabIndex = 213
      Me.Label13.Text = "Reponsable Imp."
      '
      'txtRowsMax
      '
      Me.txtRowsMax.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtRowsMax.Location = New System.Drawing.Point(116, 356)
      Me.txtRowsMax.Name = "txtRowsMax"
      Me.txtRowsMax.Size = New System.Drawing.Size(124, 20)
      Me.txtRowsMax.TabIndex = 18
      Me.txtRowsMax.Text = "0"
      Me.txtRowsMax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtRowsMax.Value = 0
      Me.txtRowsMax.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtRowsMax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 360)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(68, 16)
      Me.Label5.TabIndex = 211
      Me.Label5.Text = "Max. Reg."
      '
      'cboTipoImpresion
      '
      Me.cboTipoImpresion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoImpresion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoImpresion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoImpresion.Location = New System.Drawing.Point(312, 308)
      Me.cboTipoImpresion.Name = "cboTipoImpresion"
      Me.cboTipoImpresion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoImpresion.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoImpresion.TabIndex = 16
      Me.cboTipoImpresion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(248, 312)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(64, 16)
      Me.Label4.TabIndex = 205
      Me.Label4.Text = "Impresión"
      '
      'chkNroAuto
      '
      Me.chkNroAuto.BackColor = System.Drawing.Color.Transparent
      Me.chkNroAuto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkNroAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkNroAuto.Location = New System.Drawing.Point(16, 112)
      Me.chkNroAuto.Name = "chkNroAuto"
      Me.chkNroAuto.Size = New System.Drawing.Size(96, 20)
      Me.chkNroAuto.TabIndex = 5
      Me.chkNroAuto.Text = "Autonumerar"
      Me.chkNroAuto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtNroActualFis)
      Me.UiGroupBox1.Controls.Add(Me.txtNroIniFis)
      Me.UiGroupBox1.Controls.Add(Me.Label2)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.UiGroupBox3)
      Me.UiGroupBox1.Controls.Add(Me.txtNroActual)
      Me.UiGroupBox1.Controls.Add(Me.txtNroIni)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.Label8)
      Me.UiGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 116)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(428, 120)
      Me.UiGroupBox1.TabIndex = 6
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkEncabezadoPorHoja
      '
      Me.chkEncabezadoPorHoja.BackColor = System.Drawing.Color.Transparent
      Me.chkEncabezadoPorHoja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkEncabezadoPorHoja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkEncabezadoPorHoja.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText
      Me.chkEncabezadoPorHoja.Location = New System.Drawing.Point(248, 336)
      Me.chkEncabezadoPorHoja.Name = "chkEncabezadoPorHoja"
      Me.chkEncabezadoPorHoja.Size = New System.Drawing.Size(188, 20)
      Me.chkEncabezadoPorHoja.TabIndex = 215
      Me.chkEncabezadoPorHoja.Text = "Encabezado por Hoja"
      Me.chkEncabezadoPorHoja.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtNroActualFis
      '
      Me.txtNroActualFis.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroActualFis.Location = New System.Drawing.Point(108, 92)
      Me.txtNroActualFis.Name = "txtNroActualFis"
      Me.txtNroActualFis.Size = New System.Drawing.Size(124, 20)
      Me.txtNroActualFis.TabIndex = 10
      Me.txtNroActualFis.Text = "0"
      Me.txtNroActualFis.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroActualFis.Value = 0
      Me.txtNroActualFis.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtNroActualFis.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNroIniFis
      '
      Me.txtNroIniFis.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroIniFis.Location = New System.Drawing.Point(108, 68)
      Me.txtNroIniFis.Name = "txtNroIniFis"
      Me.txtNroIniFis.Size = New System.Drawing.Size(124, 20)
      Me.txtNroIniFis.TabIndex = 9
      Me.txtNroIniFis.Text = "0"
      Me.txtNroIniFis.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroIniFis.Value = 0
      Me.txtNroIniFis.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtNroIniFis.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 96)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(96, 16)
      Me.Label2.TabIndex = 197
      Me.Label2.Text = "Nro Actual 2"
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 72)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(96, 16)
      Me.Label3.TabIndex = 196
      Me.Label3.Text = "Nro Inicial 2"
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox3.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox3.Controls.Add(Me.optNroAutoMes)
      Me.UiGroupBox3.Controls.Add(Me.optNroAutoGestion)
      Me.UiGroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox3.Location = New System.Drawing.Point(244, 12)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(176, 56)
      Me.UiGroupBox3.TabIndex = 11
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'optNroAutoMes
      '
      Me.optNroAutoMes.BackColor = System.Drawing.Color.Transparent
      Me.optNroAutoMes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optNroAutoMes.Checked = True
      Me.optNroAutoMes.CheckedValue = False
      Me.optNroAutoMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optNroAutoMes.Location = New System.Drawing.Point(8, 36)
      Me.optNroAutoMes.Name = "optNroAutoMes"
      Me.optNroAutoMes.Size = New System.Drawing.Size(160, 16)
      Me.optNroAutoMes.TabIndex = 13
      Me.optNroAutoMes.TabStop = True
      Me.optNroAutoMes.Text = "Autonumerar Por Periodo"
      Me.optNroAutoMes.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optNroAutoGestion
      '
      Me.optNroAutoGestion.BackColor = System.Drawing.Color.Transparent
      Me.optNroAutoGestion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optNroAutoGestion.Checked = True
      Me.optNroAutoGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optNroAutoGestion.Location = New System.Drawing.Point(8, 12)
      Me.optNroAutoGestion.Name = "optNroAutoGestion"
      Me.optNroAutoGestion.Size = New System.Drawing.Size(160, 16)
      Me.optNroAutoGestion.TabIndex = 12
      Me.optNroAutoGestion.TabStop = True
      Me.optNroAutoGestion.Text = "Autonumerar Por Gestión"
      Me.optNroAutoGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtNroActual
      '
      Me.txtNroActual.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroActual.Location = New System.Drawing.Point(108, 44)
      Me.txtNroActual.Name = "txtNroActual"
      Me.txtNroActual.Size = New System.Drawing.Size(124, 20)
      Me.txtNroActual.TabIndex = 8
      Me.txtNroActual.Text = "0"
      Me.txtNroActual.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroActual.Value = 0
      Me.txtNroActual.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtNroActual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNroIni
      '
      Me.txtNroIni.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroIni.Location = New System.Drawing.Point(108, 20)
      Me.txtNroIni.Name = "txtNroIni"
      Me.txtNroIni.Size = New System.Drawing.Size(124, 20)
      Me.txtNroIni.TabIndex = 7
      Me.txtNroIni.Text = "0"
      Me.txtNroIni.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroIni.Value = 0
      Me.txtNroIni.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtNroIni.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 48)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(96, 16)
      Me.Label7.TabIndex = 193
      Me.Label7.Text = "Nro Actual"
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 24)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(96, 16)
      Me.Label8.TabIndex = 192
      Me.Label8.Text = "Nro Inicial"
      '
      'cboTipoHoja
      '
      Me.cboTipoHoja.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.Location = New System.Drawing.Point(116, 308)
      Me.cboTipoHoja.Name = "cboTipoHoja"
      Me.cboTipoHoja.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoHoja.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoHoja.TabIndex = 15
      Me.cboTipoHoja.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 312)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 203
      Me.Label1.Text = "Tamaño Hoja"
      '
      'txtFirma
      '
      Me.txtFirma.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFirma.Location = New System.Drawing.Point(116, 244)
      Me.txtFirma.MaxLength = 1000
      Me.txtFirma.Multiline = True
      Me.txtFirma.Name = "txtFirma"
      Me.txtFirma.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.txtFirma.Size = New System.Drawing.Size(320, 60)
      Me.txtFirma.TabIndex = 14
      Me.txtFirma.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFirma.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      Me.txtFirma.WordWrap = False
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 248)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 201
      Me.Label18.Text = "Firma"
      '
      'txtEstadoId
      '
      Me.txtEstadoId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEstadoId.Location = New System.Drawing.Point(116, 408)
      Me.txtEstadoId.Name = "txtEstadoId"
      Me.txtEstadoId.ReadOnly = True
      Me.txtEstadoId.Size = New System.Drawing.Size(320, 20)
      Me.txtEstadoId.TabIndex = 19
      Me.txtEstadoId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEstadoId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTipoCompId
      '
      Me.txtTipoCompId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCompId.Location = New System.Drawing.Point(116, 88)
      Me.txtTipoCompId.Name = "txtTipoCompId"
      Me.txtTipoCompId.ReadOnly = True
      Me.txtTipoCompId.Size = New System.Drawing.Size(320, 20)
      Me.txtTipoCompId.TabIndex = 4
      Me.txtTipoCompId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTipoCompId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtGestionId
      '
      Me.txtGestionId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtGestionId.Location = New System.Drawing.Point(116, 64)
      Me.txtGestionId.Name = "txtGestionId"
      Me.txtGestionId.ReadOnly = True
      Me.txtGestionId.Size = New System.Drawing.Size(124, 20)
      Me.txtGestionId.TabIndex = 3
      Me.txtGestionId.Text = "0"
      Me.txtGestionId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtGestionId.Value = 0
      Me.txtGestionId.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtGestionId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(116, 40)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(320, 20)
      Me.txtEmpresaId.TabIndex = 2
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCompParaId
      '
      Me.txtCompParaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompParaId.Location = New System.Drawing.Point(116, 16)
      Me.txtCompParaId.Name = "txtCompParaId"
      Me.txtCompParaId.ReadOnly = True
      Me.txtCompParaId.Size = New System.Drawing.Size(124, 20)
      Me.txtCompParaId.TabIndex = 1
      Me.txtCompParaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompParaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 92)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 190
      Me.Label6.Text = "Tipo Comprobante"
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 412)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(100, 16)
      Me.Label9.TabIndex = 187
      Me.Label9.Text = "Estado"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 44)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 186
      Me.Label10.Text = "Empresa"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 68)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(104, 16)
      Me.Label11.TabIndex = 185
      Me.Label11.Text = "Gestión"
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 20)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 184
      Me.Label12.Text = "ID"
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
      Me.cdmMain.Id = New System.Guid("0da42c1f-4b6d-4f6c-8b74-ff497ec5f8c5")
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
      'frmCompParaEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 470)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompParaEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompPara Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
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
               mlngID = moCompPara.CompParaId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompParaEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompParaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Parámetro de Comprobante"
         Else
            Me.Text = "Editar Parámetro de Comprobante"
         End If
      Else
         Me.Text = "Nuevo Parámetro de Comprobante"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCompPara
         txtCompParaId.Text = ToStr(.CompParaId)
         Call txtEmpresaIdLoad(.EmpresaId)
         Call txtGestionIdLoad(.GestionId)
         Call txtTipoCompIdLoad(.TipoCompId)
         chkNroAuto.Checked = .NroAuto
         txtNroIni.Text = ToStr(.NroIni)
         txtNroActual.Text = ToStr(.NroActual)
         txtNroIniFis.Text = ToStr(.NroIniFis)
         txtNroActualFis.Text = ToStr(.NroActualFis)
         txtFirma.Text = ToStr(.Firma)
         cboTipoHoja.SelectedIndex = ListFindItem(cboTipoHoja, .TipoHojaId)
         cboTipoImpresion.SelectedIndex = ListFindItem(cboTipoImpresion, .TipoImpresionId)
         cboTipoRespImp.SelectedIndex = ListFindItem(cboTipoRespImp, .TipoRespImpId)
         txtRowsMax.Text = ToStr(.RowsMax)
         Call txtEstadoIdLoad(.EstadoId)
         chkBloqueoAuto.Checked = ToBoolean(.BloqueoAuto)
         chkEncabezadoPorHoja.Checked = ToBoolean(.EncabezadoPorHoja)

         If ToBoolean(.NroAutoGestion) Then
            optNroAutoGestion.Checked = True
            optNroAutoMes.Checked = False
         Else
            optNroAutoGestion.Checked = False
            optNroAutoMes.Checked = True
         End If

         If chkNroAuto.Checked Then
            optNroAutoGestion.Enabled = True
            optNroAutoMes.Enabled = True

            If optNroAutoGestion.Checked Then
               txtNroIni.Enabled = True
               txtNroActual.Enabled = True
               txtNroIniFis.Enabled = True
               txtNroActualFis.Enabled = True
            Else
               txtNroIni.Enabled = False
               txtNroActual.Enabled = False
               txtNroIniFis.Enabled = False
               txtNroActualFis.Enabled = False
            End If
         Else
            txtNroIni.Enabled = False
            txtNroActual.Enabled = False
            txtNroIniFis.Enabled = False
            txtNroActualFis.Enabled = False
            optNroAutoGestion.Enabled = False
            optNroAutoMes.Enabled = False
         End If

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Parámetro de Comprobante"
               .VMOld.ToShowOpe()
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsCompParaVM)
      oVM = New clsCompParaVM

      With oVM
         .CompParaId = moCompPara.CompParaId
         .GestionId = moCompPara.GestionId
         .Gestion = txtGestionId.Text
         .TipoCompId = moCompPara.TipoCompId
         .TipoCompDes = txtTipoCompId.Text
         .NroAuto = ToByte(chkNroAuto.Checked)
         .NroAutoGestion = ToByte(optNroAutoGestion.Checked)
         .NroIni = moCompPara.NroIni
         .NroActual = moCompPara.NroActual
         .NroIniFis = moCompPara.NroIniFis
         .NroActualFis = moCompPara.NroActualFis
         .Firma = moCompPara.Firma
         .TipoHojaId = moCompPara.TipoHojaId
         .TipoHojaDes = cboTipoHoja.Text
         .TipoImpresionId = moCompPara.TipoImpresionId
         .TipoImpresionDes = cboTipoImpresion.Text
         .TipoRespImpId = moCompPara.TipoRespImpId
         .TipoRespImpDes = cboTipoRespImp.Text
         .EncabezadoPorHoja = ToByte(chkEncabezadoPorHoja.Checked)
         .RowsMax = moCompPara.RowsMax
         .BloqueoAuto = chkBloqueoAuto.Checked
         .EstadoId = moCompPara.EstadoId
         .EstadoDes = txtEstadoId.Text

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCompPara
         'txtCompParaId.Text = String.Empty
         'Call txtEmpresaIdLoad(.EmpresaId)
         'txtCompPara.Text = ToStr(Now.Year)
         'Call txtFechaLoad(.EmpresaId)
         'cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCompParaId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      txtGestionId.ReadOnly = True
      txtTipoCompId.ReadOnly = True
      txtNroIni.Enabled = False
      txtNroActual.Enabled = False
      txtNroIniFis.Enabled = False
      txtNroActualFis.Enabled = False
      chkNroAuto.Enabled = False
      optNroAutoGestion.Enabled = False
      optNroAutoMes.Enabled = False
      txtFirma.ReadOnly = True
      cboTipoHoja.ReadOnly = True
      cboTipoImpresion.ReadOnly = True
      cboTipoRespImp.ReadOnly = True
      txtRowsMax.ReadOnly = True
      txtEstadoId.ReadOnly = True
      chkBloqueoAuto.Enabled = False
      chkEncabezadoPorHoja.Enabled = False

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCompPara
         If Not mboolAdding Then
            .CompParaId = ToLong(txtCompParaId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .GestionId = ToLong(txtGestionId.Tag)
         .TipoCompId = ToLong(txtTipoCompId.Tag)
         .NroIni = ToLong(txtNroIni.Text)
         .NroActual = ToLong(txtNroActual.Text)
         .NroIniFis = ToLong(txtNroIniFis.Text)
         .NroActualFis = ToLong(txtNroActualFis.Text)
         .NroAuto = ToBoolean(chkNroAuto.Checked)
         .NroAutoGestion = ToBoolean(optNroAutoGestion.Checked)
         .Firma = txtFirma.Text
         .TipoHojaId = ListPosition(cboTipoHoja, cboTipoHoja.SelectedIndex)
         .TipoImpresionId = ListPosition(cboTipoImpresion, cboTipoImpresion.SelectedIndex)
         .TipoRespImpId = ListPosition(cboTipoRespImp, cboTipoRespImp.SelectedIndex)
         .RowsMax = ToLong(txtRowsMax.Text)
         .EstadoId = ToLong(txtEstadoId.Tag)
         .BloqueoAuto = ToBoolean(chkBloqueoAuto.Checked)
         .EncabezadoPorHoja = ToBoolean(chkEncabezadoPorHoja.Checked)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtNroIni.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If mboolAdding Then
            DataSave = DataAdd()
         Else
            DataSave = DataUpdate()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moCompPara.Insert() Then
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

         If moCompPara.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

   End Sub

   Private Sub ComboLoad()
      Call cboTipoHojaLoad()
      Call cboTipoImpresionLoad()
      Call cboTipoRespImpLoad()
   End Sub

   Private Sub cboTipoHojaLoad()
      Dim oTipoHoja As New clsTipoHoja(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoHoja.Items.Clear()

      Try
         With oTipoHoja
            .SelectFilter = clsTipoHoja.SelectFilters.ListBox
            .OrderByFilter = clsTipoHoja.OrderByFilters.TipoHojaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoHojaId, .TipoHojaDes)

                  cboTipoHoja.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoHoja.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoImpresionLoad()
      Dim oTipoImpresion As New clsTipoImpresion(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoImpresion.Items.Clear()

      Try
         With oTipoImpresion
            .SelectFilter = clsTipoImpresion.SelectFilters.ListBox
            .OrderByFilter = clsTipoImpresion.OrderByFilters.TipoImpresionDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoImpresionId, .TipoImpresionDes)

                  cboTipoImpresion.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoImpresion.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoRespImpLoad()
      Dim oTipoRespImp As New clsTipoRespImp(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoRespImp.Items.Clear()

      Try
         With oTipoRespImp
            .SelectFilter = clsTipoRespImp.SelectFilters.ListBox
            .OrderByFilter = clsTipoRespImp.OrderByFilters.TipoRespImpDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoRespImpId, .TipoRespImpDes)

                  cboTipoRespImp.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoRespImp.Dispose()
         oItem = Nothing

      End Try
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

   Private Sub txtGestionIdLoad(ByVal lngGestionId As Long)
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               txtGestionId.Tag = .GestionId
               txtGestionId.Text = ToStr(.Gestion)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Sub

   Private Sub txtTipoCompIdLoad(ByVal lngTipoCompId As Long)
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)

      Try
         With oTipoComp
            .TipoCompId = lngTipoCompId

            If .FindByPK Then
               txtTipoCompId.Tag = .TipoCompId
               txtTipoCompId.Text = ToStr(.TipoCompDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoComp.Dispose()

      End Try
   End Sub

   Private Sub txtEstadoIdLoad(ByVal lngEstadoId As Long)
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)

      Try
         With oEstado
            .EstadoId = lngEstadoId

            If .FindByPK Then
               txtEstadoId.Tag = .EstadoId
               txtEstadoId.Text = ToStr(.EstadoDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEstado.Dispose()

      End Try
   End Sub

   Private Sub chkNroAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNroAuto.CheckedChanged
      If chkNroAuto.Checked Then
         txtNroIni.Enabled = True
         txtNroActual.Enabled = True
         txtNroIniFis.Enabled = True
         txtNroActualFis.Enabled = True
         optNroAutoGestion.Enabled = True
         optNroAutoMes.Enabled = True
      Else
         txtNroIni.Enabled = False
         txtNroActual.Enabled = False
         txtNroIniFis.Enabled = False
         txtNroActualFis.Enabled = False
         optNroAutoGestion.Enabled = False
         optNroAutoMes.Enabled = False
      End If
   End Sub

   Private Sub optNroAutoGestion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNroAutoGestion.CheckedChanged
      If optNroAutoGestion.Checked Then
         txtNroIni.Enabled = True
         txtNroActual.Enabled = True
         txtNroIniFis.Enabled = True
         txtNroActualFis.Enabled = True
      Else
         txtNroIni.Enabled = False
         txtNroActual.Enabled = False
         txtNroIniFis.Enabled = False
         txtNroActualFis.Enabled = False
      End If
   End Sub

   Private Sub optNroAutoMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNroAutoMes.CheckedChanged
      If optNroAutoMes.Checked Then
         txtNroIni.Enabled = False
         txtNroActual.Enabled = False
         txtNroIniFis.Enabled = False
         txtNroActualFis.Enabled = False
      Else
         txtNroIni.Enabled = True
         txtNroActual.Enabled = True
         txtNroIniFis.Enabled = True
         txtNroActualFis.Enabled = True
      End If
   End Sub

   Private Sub frmCompParaEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moCompPara.CompParaId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompParaEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompPara.Dispose()
      Call ClearMemory()
   End Sub

End Class
