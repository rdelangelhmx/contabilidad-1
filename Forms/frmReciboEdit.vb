Public Class frmReciboEdit
   Inherits System.Windows.Forms.Form

   Private moRecibo As clsRecibo

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
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

   WriteOnly Property DataObject() As clsRecibo
      Set(ByVal Value As clsRecibo)
         moRecibo = Value
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
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents txtReciboId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
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
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Public WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Public WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtGlosa As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPorConcepto As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEntregadoA As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents lblPorConcepto As System.Windows.Forms.Label
   Friend WithEvents lblEntregadoA As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Public WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents txtLiteral As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtRespaldoNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents txtReciboNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents cboTipoComp As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboRespaldo As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboRespaldo = New Janus.Windows.EditControls.UIComboBox
      Me.txtRespaldoNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.lblId = New System.Windows.Forms.Label
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtPorConcepto = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEntregadoA = New Janus.Windows.GridEX.EditControls.EditBox
      Me.lblPorConcepto = New System.Windows.Forms.Label
      Me.lblEntregadoA = New System.Windows.Forms.Label
      Me.txtGlosa = New Janus.Windows.GridEX.EditControls.EditBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.cboTipoComp = New Janus.Windows.EditControls.UIComboBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtLiteral = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.txtMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtReciboNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtReciboId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
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
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 325)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.cboRespaldo)
      Me.UiGroupBox2.Controls.Add(Me.txtRespaldoNro)
      Me.UiGroupBox2.Controls.Add(Me.Label2)
      Me.UiGroupBox2.Controls.Add(Me.lblId)
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 252)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(444, 64)
      Me.UiGroupBox2.TabIndex = 12
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboRespaldo
      '
      Me.cboRespaldo.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboRespaldo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboRespaldo.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboRespaldo.Location = New System.Drawing.Point(128, 12)
      Me.cboRespaldo.Name = "cboRespaldo"
      Me.cboRespaldo.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboRespaldo.Size = New System.Drawing.Size(308, 20)
      Me.cboRespaldo.TabIndex = 13
      Me.cboRespaldo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtRespaldoNro
      '
      Me.txtRespaldoNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtRespaldoNro.FormatString = "########"
      Me.txtRespaldoNro.Location = New System.Drawing.Point(128, 36)
      Me.txtRespaldoNro.Name = "txtRespaldoNro"
      Me.txtRespaldoNro.Size = New System.Drawing.Size(140, 20)
      Me.txtRespaldoNro.TabIndex = 14
      Me.txtRespaldoNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtRespaldoNro.Value = 0
      Me.txtRespaldoNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtRespaldoNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 40)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(116, 16)
      Me.Label2.TabIndex = 169
      Me.Label2.Text = "Nro Doc. Respaldo"
      '
      'lblId
      '
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblId.Location = New System.Drawing.Point(8, 16)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(116, 16)
      Me.lblId.TabIndex = 168
      Me.lblId.Text = "Doc. Respaldo"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackColor = System.Drawing.Color.Beige
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.Label1)
      Me.UiGroupBox1.Controls.Add(Me.txtPorConcepto)
      Me.UiGroupBox1.Controls.Add(Me.txtEntregadoA)
      Me.UiGroupBox1.Controls.Add(Me.lblPorConcepto)
      Me.UiGroupBox1.Controls.Add(Me.lblEntregadoA)
      Me.UiGroupBox1.Controls.Add(Me.txtGlosa)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 140)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 112)
      Me.UiGroupBox1.TabIndex = 8
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label1.Location = New System.Drawing.Point(8, 64)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(116, 16)
      Me.Label1.TabIndex = 206
      Me.Label1.Text = "Glosa"
      '
      'txtPorConcepto
      '
      Me.txtPorConcepto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPorConcepto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPorConcepto.Location = New System.Drawing.Point(128, 36)
      Me.txtPorConcepto.MaxLength = 255
      Me.txtPorConcepto.Multiline = True
      Me.txtPorConcepto.Name = "txtPorConcepto"
      Me.txtPorConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtPorConcepto.Size = New System.Drawing.Size(308, 20)
      Me.txtPorConcepto.TabIndex = 10
      Me.txtPorConcepto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPorConcepto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEntregadoA
      '
      Me.txtEntregadoA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtEntregadoA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEntregadoA.Location = New System.Drawing.Point(128, 12)
      Me.txtEntregadoA.MaxLength = 255
      Me.txtEntregadoA.Multiline = True
      Me.txtEntregadoA.Name = "txtEntregadoA"
      Me.txtEntregadoA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtEntregadoA.Size = New System.Drawing.Size(308, 20)
      Me.txtEntregadoA.TabIndex = 9
      Me.txtEntregadoA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEntregadoA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblPorConcepto
      '
      Me.lblPorConcepto.BackColor = System.Drawing.Color.Transparent
      Me.lblPorConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPorConcepto.Location = New System.Drawing.Point(8, 40)
      Me.lblPorConcepto.Name = "lblPorConcepto"
      Me.lblPorConcepto.Size = New System.Drawing.Size(116, 16)
      Me.lblPorConcepto.TabIndex = 205
      '
      'lblEntregadoA
      '
      Me.lblEntregadoA.BackColor = System.Drawing.Color.Transparent
      Me.lblEntregadoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblEntregadoA.Location = New System.Drawing.Point(8, 16)
      Me.lblEntregadoA.Name = "lblEntregadoA"
      Me.lblEntregadoA.Size = New System.Drawing.Size(116, 16)
      Me.lblEntregadoA.TabIndex = 204
      '
      'txtGlosa
      '
      Me.txtGlosa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtGlosa.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtGlosa.Location = New System.Drawing.Point(128, 60)
      Me.txtGlosa.MaxLength = 255
      Me.txtGlosa.Multiline = True
      Me.txtGlosa.Name = "txtGlosa"
      Me.txtGlosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtGlosa.Size = New System.Drawing.Size(308, 44)
      Me.txtGlosa.TabIndex = 11
      Me.txtGlosa.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtGlosa.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.cboTipoComp)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.txtLiteral)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.txtMonto)
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.txtReciboNro)
      Me.grpMain.Controls.Add(Me.txtReciboId)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label13)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 140)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(92, 64)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(124, 20)
      Me.cboMoneda.TabIndex = 5
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboTipoComp
      '
      Me.cboTipoComp.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoComp.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoComp.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoComp.Location = New System.Drawing.Point(92, 40)
      Me.cboTipoComp.Name = "cboTipoComp"
      Me.cboTipoComp.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoComp.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoComp.TabIndex = 3
      Me.cboTipoComp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 44)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(80, 16)
      Me.Label3.TabIndex = 206
      Me.Label3.Text = "Tipo"
      '
      'txtLiteral
      '
      Me.txtLiteral.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtLiteral.Location = New System.Drawing.Point(92, 112)
      Me.txtLiteral.Name = "txtLiteral"
      Me.txtLiteral.ReadOnly = True
      Me.txtLiteral.Size = New System.Drawing.Size(344, 20)
      Me.txtLiteral.TabIndex = 7
      Me.txtLiteral.TabStop = False
      Me.txtLiteral.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtLiteral.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 116)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(80, 16)
      Me.Label4.TabIndex = 204
      Me.Label4.Text = "La Suma De"
      '
      'Label15
      '
      Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 68)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(80, 16)
      Me.Label15.TabIndex = 199
      Me.Label15.Text = "Moneda"
      '
      'txtMonto
      '
      Me.txtMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMonto.FormatString = "##,##0.000"
      Me.txtMonto.Location = New System.Drawing.Point(92, 88)
      Me.txtMonto.Name = "txtMonto"
      Me.txtMonto.Size = New System.Drawing.Size(124, 20)
      Me.txtMonto.TabIndex = 6
      Me.txtMonto.Text = "0,000"
      Me.txtMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'dtpFecha
      '
      Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFecha.DropDownCalendar.Name = ""
      Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFecha.Location = New System.Drawing.Point(312, 40)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(124, 20)
      Me.dtpFecha.TabIndex = 4
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtReciboNro
      '
      Me.txtReciboNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtReciboNro.FormatString = "########"
      Me.txtReciboNro.Location = New System.Drawing.Point(312, 16)
      Me.txtReciboNro.Name = "txtReciboNro"
      Me.txtReciboNro.ReadOnly = True
      Me.txtReciboNro.Size = New System.Drawing.Size(124, 20)
      Me.txtReciboNro.TabIndex = 2
      Me.txtReciboNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtReciboNro.Value = 0
      Me.txtReciboNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtReciboNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtReciboId
      '
      Me.txtReciboId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtReciboId.Location = New System.Drawing.Point(92, 16)
      Me.txtReciboId.Name = "txtReciboId"
      Me.txtReciboId.ReadOnly = True
      Me.txtReciboId.Size = New System.Drawing.Size(124, 20)
      Me.txtReciboId.TabIndex = 1
      Me.txtReciboId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtReciboId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 92)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(80, 16)
      Me.Label5.TabIndex = 195
      Me.Label5.Text = "Monto"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(256, 44)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(52, 16)
      Me.Label10.TabIndex = 194
      Me.Label10.Text = "Fecha"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 20)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(80, 16)
      Me.Label11.TabIndex = 193
      Me.Label11.Text = "ID"
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label13.Location = New System.Drawing.Point(256, 20)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(52, 16)
      Me.Label13.TabIndex = 191
      Me.Label13.Text = "Número"
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Print})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("463ebdad-b83a-4ace-97ca-7991d2904372")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Print1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(230, 28)
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
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
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
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
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
      'frmReciboEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.Beige
      Me.ClientSize = New System.Drawing.Size(462, 353)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmReciboEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Recibo Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
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
               mlngID = moRecibo.ReciboId
               mboolChanged = True
               Me.Close()
            End If

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmReciboEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmReciboEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Recibo"
         Else
            Me.Text = "Editar Recibo"
         End If
      Else
         Me.Text = "Nuevo Recibo"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moRecibo
         txtReciboId.Text = ToStr(.ReciboId)
         dtpFecha.Value = .Fecha
         cboTipoComp.SelectedIndex = ListFindItem(cboTipoComp, .TipoCompId)
         txtReciboNro.Text = ToStr(.ReciboNro)
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtMonto.Text = ToDecStr(.Monto)
         txtLiteral.Text = CifraLiteral(.Monto)
         txtEntregadoA.Text = ToStr(.EntregadoA)
         txtPorConcepto.Text = ToStr(.PorConcepto)
         txtGlosa.Text = ToStr(.Glosa)
         cboRespaldo.SelectedIndex = ListFindItem(cboRespaldo, .RespaldoId)
         txtRespaldoNro.Text = ToStr(.RespaldoNro)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Recibo"
               .VMOld.ToShowOpe(clsTipoOpera.CONSULTA)
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Function CompNroFind(ByVal lngCompId As Long) As Long
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      CompNroFind = 0
      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               CompNroFind = .CompNro
            End If
         End With
      Catch ex As Exception
         Throw ex
      Finally
         oComp.Dispose()
      End Try
   End Function

   Private Sub CloneVM(ByRef oVM As clsReciboVM)
      oVM = New clsReciboVM

      With oVM
         .ReciboId = moRecibo.ReciboId
         .ReciboNro = moRecibo.ReciboNro
         .CompId = moRecibo.CompId
         If .CompId > 0 Then
            .CompNro = CompNroFind(moRecibo.CompId)
         End If
         .TipoCompId = moRecibo.TipoCompId
         .TipoCompDes = cboTipoComp.Text
         .Fecha = dtpFecha.Text
         .EntregadoA = moRecibo.EntregadoA
         .PorConcepto = moRecibo.PorConcepto
         .Glosa = moRecibo.Glosa
         .MonedaId = moRecibo.MonedaId
         .MonedaDes = cboMoneda.Text
         .Monto = moRecibo.Monto
         .RespaldoId = moRecibo.RespaldoId
         .RespaldoNro = moRecibo.RespaldoNro
         .RespaldoDes = cboRespaldo.Text

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moRecibo
         txtReciboId.Text = String.Empty
         dtpFecha.Value = .Fecha
         cboTipoComp.SelectedIndex = -1
         txtReciboNro.Text = String.Empty
         cboMoneda.SelectedIndex = -1
         txtMonto.Text = "0"
         txtLiteral.Text = String.Empty
         txtEntregadoA.Text = String.Empty
         txtPorConcepto.Text = String.Empty
         txtGlosa.Text = String.Empty
         cboRespaldo.SelectedIndex = -1
         txtRespaldoNro.Text = String.Empty
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtReciboId.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboTipoComp.Enabled = False
      txtReciboNro.ReadOnly = True
      cboMoneda.Enabled = False
      txtMonto.ReadOnly = True
      txtLiteral.ReadOnly = True
      txtEntregadoA.ReadOnly = True
      txtPorConcepto.ReadOnly = True
      txtGlosa.ReadOnly = True
      cboRespaldo.Enabled = False
      txtRespaldoNro.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moRecibo
         If Not mboolAdding Then
            .ReciboId = ToLong(txtReciboId.Text)
            .ReciboNro = ToLong(txtReciboNro.Text)
         Else
            .ReciboNro = ReciboParaNroNext(ListPosition(cboTipoComp, cboTipoComp.SelectedIndex))
         End If

         .Fecha = ToDate(dtpFecha.Value)
         .TipoCompId = ListPosition(cboTipoComp, cboTipoComp.SelectedIndex)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .Monto = ToDecimal(txtMonto.Text)
         .EntregadoA = ToStr(txtEntregadoA.Text)
         .PorConcepto = ToStr(txtPorConcepto.Text)
         .Glosa = ToStr(txtGlosa.Text)
         .RespaldoId = ListPosition(cboRespaldo, cboRespaldo.SelectedIndex)
         .RespaldoNro = ToLong(txtRespaldoNro.Text)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      dtpFecha.Select()
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

         If moRecibo.Insert() Then
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

         If moRecibo.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         FormCheck = False
         strMsg &= "Fecha no Corresponde a la Gestion en Uso" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
            .EmpresaId = moRecibo.EmpresaId
            .FechaIni = strFecha
            .EstadoId = 11

            If .Find Then
               GestionIdFind = ToLong(.GestionId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Public Sub PrintReport()
      Dim rpt As New rptReciboEdit
      Dim oRecibo As New clsRecibo(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long

      Try
         oRecibo.SelectFilter = clsRecibo.SelectFilters.Report
         oRecibo.WhereFilter = clsRecibo.WhereFilters.Report
         oRecibo.OrderByFilter = clsRecibo.OrderByFilters.Report
         oRecibo.EmpresaId = moRecibo.EmpresaId
         oRecibo.ReciboId = moRecibo.ReciboId

         If oRecibo.Find Then
            rpt.DataSource = oRecibo.DataSet.Tables(oRecibo.TableName).DefaultView

            If moRecibo.TipoCompId = 1 Then
               rpt.lblTitle.Text = "Recibo de Ingreso"
               rpt.Document.Name = "Recibo de Ingreso"

               rpt.lblEntregadoA.Text = "Hemos recibido de:"
               rpt.lblPorConcepto.Text = "Por concepto de:"
            ElseIf moRecibo.TipoCompId = 2 Then
               rpt.lblTitle.Text = "Recibo de Egreso"
               rpt.Document.Name = "Recibo de Egreso"

               rpt.lblEntregadoA.Text = "Hemos entregado a:"
               rpt.lblPorConcepto.Text = "Por concepto de:"
            End If

            rpt.lblFirma.Text = ReciboParaFirma(moRecibo.TipoCompId, moRecibo.GestionId, lngTipoHojaId)
            rpt.lblCompany.Text = clsAppInfo.EmpresaGral
            rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
            rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
            rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

            Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

            If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreview(rpt.Document)
               frm.Show()

            ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
               rpt.Run(True)
               Dim frm As New frmReportPreviewMultiple(rpt.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = lngTipoHojaId
               frm.Show()
            End If

            If clsAppInfo.RegistrarBitacora Then
               Call CloneVM(oRecibo.VMNew)
               Call oRecibo.VMNew.ToShowOpe(clsTipoOpera.IMPRESION_INFORME)
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRecibo.Dispose()

      End Try
   End Sub

   Private Function ReciboParaFirma(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByRef lngTipoHojaId As Long) As String
      Dim oReciboPara As New clsReciboPara(clsAppInfo.ConnectString)

      Try
         ReciboParaFirma = ""

         With oReciboPara
            .SelectFilter = clsReciboPara.SelectFilters.All
            .WhereFilter = clsReciboPara.WhereFilters.TipoCompId
            .EmpresaId = moRecibo.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId

            If .Find Then
               ReciboParaFirma = .Firma
               lngTipoHojaId = .TipoHojaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oReciboPara.Dispose()

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtMonto.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()
      Call cboTipoCompLoad()
      Call cboMonedaLoad()
      Call cboRespaldoLoad()
   End Sub

   Private Sub cboTipoCompLoad()
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoComp.Items.Clear()

      Try
         With oTipoComp
            .SelectFilter = clsTipoComp.SelectFilters.ListBox
            .OrderByFilter = clsTipoComp.OrderByFilters.TipoCompDes

            If .Open() Then
               Do While .Read()
                  If (.TipoCompId > 0) And (.TipoCompId < 3) Then
                     oItem = New clsListItem(.TipoCompId, .TipoCompDes)

                     cboTipoComp.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoComp.Dispose()
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

   Private Sub cboRespaldoLoad()
      Dim oRespaldo As New clsRespaldo(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboRespaldo.Items.Clear()

      Try
         With oRespaldo
            .SelectFilter = clsRespaldo.SelectFilters.ListBox
            .OrderByFilter = clsRespaldo.OrderByFilters.RespaldoDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.RespaldoId, .RespaldoDes)

                  cboRespaldo.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRespaldo.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Function ReciboParaNroNext(ByVal lngTipoCompId As Long) As Long
      Dim oReciboPara As New clsReciboPara(clsAppInfo.ConnectString)

      Try
         With oReciboPara
            .SelectFilter = clsReciboPara.SelectFilters.All
            .WhereFilter = clsReciboPara.WhereFilters.TipoCompId
            .EmpresaId = moRecibo.EmpresaId
            .GestionId = moRecibo.GestionId
            .TipoCompId = lngTipoCompId

            If .Find Then
               If ReciboParaNroUpdate(.ReciboParaId, .NroActual + 1) Then
                  ReciboParaNroNext = .NroActual + 1
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oReciboPara.Dispose()

      End Try
   End Function

   Private Function ReciboParaNroUpdate(ByVal lngReciboParaId As Long, ByVal lngNroActual As Long) As Boolean
      Dim oReciboPara As New clsReciboPara(clsAppInfo.ConnectString)

      ReciboParaNroUpdate = False

      Try
         With oReciboPara
            .ReciboParaId = lngReciboParaId

            If .FindByPK Then
               .UpdateFilter = clsReciboPara.UpdateFilters.NroActual
               .ReciboParaId = lngReciboParaId
               .NroActual = lngNroActual

               If .Update Then
                  ReciboParaNroUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oReciboPara.Dispose()

      End Try
   End Function

   Private Sub cboTipoComp_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoComp.SelectedIndexChanged
      If cboTipoComp.Tag <> cboTipoComp.Text Then
         cboTipoComp.Tag = cboTipoComp.Text

         If ListPosition(cboTipoComp, cboTipoComp.SelectedIndex) = 1 Then
            lblEntregadoA.Text = "Hemos recibido de"
            lblPorConcepto.Text = "Por concepto de"
         ElseIf ListPosition(cboTipoComp, cboTipoComp.SelectedIndex) = 2 Then
            lblEntregadoA.Text = "Hemos entregado a"
            lblPorConcepto.Text = "Por concepto de"
         End If
      End If
   End Sub

   Private Sub txtMonto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyUp
      txtLiteral.Text = CifraLiteral(ToDecimal(txtMonto.Text))
   End Sub

   Private Sub frmReciboEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moRecibo.ReciboId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmReciboEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moRecibo.Dispose()
      Call ClearMemory()
   End Sub

End Class
