Public Class frmCompFacturaAgruEdit
   Inherits System.Windows.Forms.Form

   Private moFacturaAgru As clsFacturaAgru
   Private mdecTipoCambio As Decimal
   Private mboolAnulada As Boolean
   Private mstrCompFecha As String

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mlngID As Long

   Property TipoCambio() As Decimal
      Get
         Return mdecTipoCambio
      End Get

      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

   WriteOnly Property Anulada() As Boolean
      Set(ByVal Value As Boolean)
         mboolAnulada = Value
      End Set
   End Property

   Property CompFecha() As String
      Get
         Return mstrCompFecha
      End Get

      Set(ByVal Value As String)
         mstrCompFecha = Value
      End Set
   End Property

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

   WriteOnly Property DataObject() As clsFacturaAgru
      Set(ByVal Value As clsFacturaAgru)
         moFacturaAgru = Value
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
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents dtpFacturaFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtFacturaMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIceIehd As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtExento As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNeto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtImporteIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
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
   Friend WithEvents txtFacturaAgruId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtFacturaNroIni As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtFacturaNroFin As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtNroAutorizacion As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtFacturaObs As Janus.Windows.GridEX.EditControls.EditBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompFacturaAgruEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtFacturaObs = New Janus.Windows.GridEX.EditControls.EditBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtImporteIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtNeto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtExento = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIceIehd = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtFacturaMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtNroAutorizacion = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.txtFacturaNroFin = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtFacturaNroIni = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.dtpFacturaFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtFacturaAgruId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label21 = New System.Windows.Forms.Label
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 313)
      Me.bcgMain.TabIndex = 185
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.txtFacturaObs)
      Me.UiGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 260)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(444, 44)
      Me.UiGroupBox2.TabIndex = 14
      Me.UiGroupBox2.Text = "Observación"
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtFacturaObs
      '
      Me.txtFacturaObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtFacturaObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtFacturaObs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaObs.Location = New System.Drawing.Point(8, 16)
      Me.txtFacturaObs.MaxLength = 255
      Me.txtFacturaObs.Multiline = True
      Me.txtFacturaObs.Name = "txtFacturaObs"
      Me.txtFacturaObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtFacturaObs.Size = New System.Drawing.Size(428, 20)
      Me.txtFacturaObs.TabIndex = 15
      Me.txtFacturaObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtImporteIVA)
      Me.UiGroupBox1.Controls.Add(Me.txtIVA)
      Me.UiGroupBox1.Controls.Add(Me.txtNeto)
      Me.UiGroupBox1.Controls.Add(Me.txtExento)
      Me.UiGroupBox1.Controls.Add(Me.txtIceIehd)
      Me.UiGroupBox1.Controls.Add(Me.txtFacturaMonto)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.Label8)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 164)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 92)
      Me.UiGroupBox1.TabIndex = 7
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtImporteIVA
      '
      Me.txtImporteIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporteIVA.FormatString = "##,##0.000"
      Me.txtImporteIVA.Location = New System.Drawing.Point(328, 64)
      Me.txtImporteIVA.Name = "txtImporteIVA"
      Me.txtImporteIVA.ReadOnly = True
      Me.txtImporteIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtImporteIVA.TabIndex = 13
      Me.txtImporteIVA.TabStop = False
      Me.txtImporteIVA.Text = "0,000"
      Me.txtImporteIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporteIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporteIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIVA
      '
      Me.txtIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIVA.FormatString = "##,##0.000"
      Me.txtIVA.Location = New System.Drawing.Point(328, 40)
      Me.txtIVA.Name = "txtIVA"
      Me.txtIVA.ReadOnly = True
      Me.txtIVA.Size = New System.Drawing.Size(108, 20)
      Me.txtIVA.TabIndex = 12
      Me.txtIVA.TabStop = False
      Me.txtIVA.Text = "0,000"
      Me.txtIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNeto
      '
      Me.txtNeto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNeto.FormatString = "##,##0.000"
      Me.txtNeto.Location = New System.Drawing.Point(328, 16)
      Me.txtNeto.Name = "txtNeto"
      Me.txtNeto.ReadOnly = True
      Me.txtNeto.Size = New System.Drawing.Size(108, 20)
      Me.txtNeto.TabIndex = 11
      Me.txtNeto.TabStop = False
      Me.txtNeto.Text = "0,000"
      Me.txtNeto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtNeto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtNeto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtExento
      '
      Me.txtExento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtExento.FormatString = "##,##0.000"
      Me.txtExento.Location = New System.Drawing.Point(116, 64)
      Me.txtExento.Name = "txtExento"
      Me.txtExento.Size = New System.Drawing.Size(108, 20)
      Me.txtExento.TabIndex = 10
      Me.txtExento.Text = "0,000"
      Me.txtExento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtExento.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtExento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIceIehd
      '
      Me.txtIceIehd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIceIehd.FormatString = "##,##0.000"
      Me.txtIceIehd.Location = New System.Drawing.Point(116, 40)
      Me.txtIceIehd.Name = "txtIceIehd"
      Me.txtIceIehd.Size = New System.Drawing.Size(108, 20)
      Me.txtIceIehd.TabIndex = 9
      Me.txtIceIehd.Text = "0,000"
      Me.txtIceIehd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIceIehd.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIceIehd.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtFacturaMonto
      '
      Me.txtFacturaMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaMonto.FormatString = "##,##0.000"
      Me.txtFacturaMonto.Location = New System.Drawing.Point(116, 16)
      Me.txtFacturaMonto.Name = "txtFacturaMonto"
      Me.txtFacturaMonto.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaMonto.TabIndex = 8
      Me.txtFacturaMonto.Text = "0,000"
      Me.txtFacturaMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtFacturaMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtFacturaMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(240, 68)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(84, 16)
      Me.Label3.TabIndex = 194
      Me.Label3.Text = "Importe - IVA"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(296, 44)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(28, 16)
      Me.Label4.TabIndex = 193
      Me.Label4.Text = "IVA"
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(244, 20)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(80, 16)
      Me.Label5.TabIndex = 192
      Me.Label5.Text = "Importe Neto"
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 68)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 191
      Me.Label6.Text = "Exento"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 44)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 190
      Me.Label7.Text = "ICE / IEHD"
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 20)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 189
      Me.Label8.Text = "Importe Bruto"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtNroAutorizacion)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.txtFacturaNroFin)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtFacturaNroIni)
      Me.grpMain.Controls.Add(Me.dtpFacturaFecha)
      Me.grpMain.Controls.Add(Me.txtFacturaAgruId)
      Me.grpMain.Controls.Add(Me.Label14)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label21)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 164)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtNroAutorizacion
      '
      Me.txtNroAutorizacion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroAutorizacion.FormatString = "###############0"
      Me.txtNroAutorizacion.Location = New System.Drawing.Point(116, 136)
      Me.txtNroAutorizacion.MaxLength = 15
      Me.txtNroAutorizacion.Name = "txtNroAutorizacion"
      Me.txtNroAutorizacion.Size = New System.Drawing.Size(108, 20)
      Me.txtNroAutorizacion.TabIndex = 6
      Me.txtNroAutorizacion.TabStop = False
      Me.txtNroAutorizacion.Text = "0"
      Me.txtNroAutorizacion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroAutorizacion.Value = CType(0, Long)
      Me.txtNroAutorizacion.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtNroAutorizacion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 140)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 211
      Me.Label2.Text = "Nro Autorizacion"
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(116, 40)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.ReadOnly = True
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(108, 20)
      Me.cboEstado.TabIndex = 2
      Me.cboEstado.TabStop = False
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtFacturaNroFin
      '
      Me.txtFacturaNroFin.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaNroFin.FormatString = "##################"
      Me.txtFacturaNroFin.Location = New System.Drawing.Point(116, 88)
      Me.txtFacturaNroFin.MaxLength = 18
      Me.txtFacturaNroFin.Name = "txtFacturaNroFin"
      Me.txtFacturaNroFin.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaNroFin.TabIndex = 4
      Me.txtFacturaNroFin.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaNroFin.Value = CType(0, Long)
      Me.txtFacturaNroFin.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtFacturaNroFin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 92)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 205
      Me.Label1.Text = "Factura Final"
      '
      'txtFacturaNroIni
      '
      Me.txtFacturaNroIni.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaNroIni.FormatString = "##################"
      Me.txtFacturaNroIni.Location = New System.Drawing.Point(116, 64)
      Me.txtFacturaNroIni.MaxLength = 18
      Me.txtFacturaNroIni.Name = "txtFacturaNroIni"
      Me.txtFacturaNroIni.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaNroIni.TabIndex = 3
      Me.txtFacturaNroIni.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaNroIni.Value = CType(0, Long)
      Me.txtFacturaNroIni.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtFacturaNroIni.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'dtpFacturaFecha
      '
      Me.dtpFacturaFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFacturaFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFacturaFecha.DropDownCalendar.FirstMonth = New Date(2008, 2, 1, 0, 0, 0, 0)
      Me.dtpFacturaFecha.DropDownCalendar.Name = ""
      Me.dtpFacturaFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFacturaFecha.Location = New System.Drawing.Point(116, 112)
      Me.dtpFacturaFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFacturaFecha.Name = "dtpFacturaFecha"
      Me.dtpFacturaFecha.Size = New System.Drawing.Size(108, 20)
      Me.dtpFacturaFecha.TabIndex = 5
      Me.dtpFacturaFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtFacturaAgruId
      '
      Me.txtFacturaAgruId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFacturaAgruId.Location = New System.Drawing.Point(116, 16)
      Me.txtFacturaAgruId.Name = "txtFacturaAgruId"
      Me.txtFacturaAgruId.ReadOnly = True
      Me.txtFacturaAgruId.Size = New System.Drawing.Size(108, 20)
      Me.txtFacturaAgruId.TabIndex = 1
      Me.txtFacturaAgruId.TabStop = False
      Me.txtFacturaAgruId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFacturaAgruId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(8, 44)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(104, 16)
      Me.Label14.TabIndex = 203
      Me.Label14.Text = "Estado"
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 68)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 202
      Me.Label15.Text = "Factura Inicial"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(8, 116)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 201
      Me.Label16.Text = "Fecha"
      '
      'Label21
      '
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label21.Location = New System.Drawing.Point(8, 20)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(104, 16)
      Me.Label21.TabIndex = 196
      Me.Label21.Text = "ID"
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
      Me.cdmMain.Id = New System.Guid("bc0ea4be-0c5e-474a-80d6-e1e004a3cc09")
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
      'frmCompFacturaAgruEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 341)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompFacturaAgruEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "FacturaAgru Edit"
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
               mlngID = moFacturaAgru.FacturaAgruId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmFacturaAgruEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmFacturaAgruEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Factura de Venta Agrupada"
         Else
            Me.Text = "Editar  Factura de Venta Agrupada"
         End If
      Else
         Me.Text = "Nueva  Factura de Venta Agrupada"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moFacturaAgru
         txtFacturaAgruId.Text = ToStr(.FacturaAgruId)
         dtpFacturaFecha.Text = .FacturaFecha
         txtNroAutorizacion.Text = ToStr(.NroAutorizacion)

         txtFacturaNroIni.Text = ToStr(.FacturaNroIni)
         txtFacturaNroFin.Text = ToStr(.FacturaNroFin)
         txtFacturaMonto.Text = ToDecStr(.FacturaMonto)
         txtIceIehd.Text = ToDecStr(.IceIehd)
         txtExento.Text = ToDecStr(.Exento)
         txtNeto.Text = ToDecStr(.FacturaMonto - (.Exento + .IceIehd))
         txtIVA.Text = ToDecStr(.IVA)
         txtImporteIVA.Text = ToDecStr(.FacturaMonto - .IVA)
         txtFacturaObs.Text = ToStr(.FacturaObs)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         If mboolAnulada Then
            txtFacturaMonto.ReadOnly = True
            txtIceIehd.ReadOnly = True
            txtExento.ReadOnly = True
            txtNeto.ReadOnly = True
            txtIVA.ReadOnly = True
            txtImporteIVA.ReadOnly = True
         End If

         dtpFacturaFecha.Select()
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moFacturaAgru
         txtFacturaAgruId.Text = String.Empty
         dtpFacturaFecha.Text = .FacturaFecha
         Call EmpresaParaLoad(clsAppInfo.EmpresaId)

         txtFacturaNroIni.Text = String.Empty
         txtFacturaNroFin.Text = String.Empty
         txtFacturaMonto.Text = ToDecStr(.FacturaMonto)
         txtIceIehd.Text = "0"
         txtExento.Text = "0"
         txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
         txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
         txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))
         txtFacturaObs.Text = String.Empty
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)

         If mboolAnulada Then
            Me.Text = "Nueva Factura Anulada"

            txtFacturaMonto.ReadOnly = True
            txtIceIehd.ReadOnly = True
            txtExento.ReadOnly = True
            txtNeto.ReadOnly = True
            txtIVA.ReadOnly = True
            txtImporteIVA.ReadOnly = True
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtFacturaAgruId.ReadOnly = True
      dtpFacturaFecha.ReadOnly = True
      txtNroAutorizacion.ReadOnly = True
      txtFacturaNroIni.ReadOnly = True
      txtFacturaNroFin.ReadOnly = True
      txtFacturaMonto.ReadOnly = True
      txtIceIehd.ReadOnly = True
      txtExento.ReadOnly = True
      txtNeto.ReadOnly = True
      txtIVA.ReadOnly = True
      txtImporteIVA.ReadOnly = True
      txtFacturaObs.ReadOnly = True
      cboEstado.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moFacturaAgru
         If Not mboolAdding Then
            .FacturaAgruId = ToLong(txtFacturaAgruId.Text)
         End If

         .MesId = dtpFacturaFecha.Value.Month
         .FacturaFecha = ToDate(dtpFacturaFecha.Value)
         .FacturaNroIni = ToLong(txtFacturaNroIni.Text)
         .FacturaNroFin = ToLong(txtFacturaNroFin.Text)
         .FacturaMonto = ToDecimal(txtFacturaMonto.Text)
         .NroAutorizacion = ToStr(txtNroAutorizacion.Text)
         .CodControl = "0"
         .IVA = ToDecimal(txtIVA.Text)
         .IceIehd = ToDecimal(txtIceIehd.Text)
         .Exento = ToDecimal(txtExento.Text)
         .FacturaObs = ToStr(txtFacturaObs.Text)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtFacturaNroIni.Select()
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

         If CompDetUpdateResto(moFacturaAgru.CompId) Then
            If FormCheck() Then
               If moFacturaAgru.Insert() Then
                  mboolAdding = False
                  DataAdd = True
               End If
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If CompDetUpdateResto(moFacturaAgru.CompId) Then
            If FormCheck() Then
               If moFacturaAgru.Update() Then
                  DataUpdate = True
               End If
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      FormCheck = True

      If Not mboolAnulada Then
         If Format(dtpFacturaFecha.Value, "MM/yyyy") <> Microsoft.VisualBasic.Right(mstrCompFecha, 7) Then
            FormCheck = False
            Throw New Exception("El Mes de la Fecha no Corresponde al Mes del Comprobante")
         End If

         If ToLong(txtFacturaNroIni.Text) > ToLong(txtFacturaNroFin.Text) Then
            FormCheck = False
            Throw New Exception("Número de Factura Final debe Ser Mayor o Igual a la Inicial")
         End If

         If ToDecimal(txtFacturaMonto.Text) <= 0 Then
            FormCheck = False
            Throw New Exception("Ingrese el Importe de la Factura")
         End If

         If ((ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)) >= ToDecimal(txtFacturaMonto.Text)) And (ToDecimal(txtFacturaMonto.Text) > 0) Then
            FormCheck = False
            Throw New Exception("El ICE/IEHD y el Exento Deben Ser Menor al Importe")
         End If

         If ToDecimal(txtFacturaMonto.Text) > CompDetFacturaAgruSaldo(moFacturaAgru.CompId, moFacturaAgru.CompDetId, CompDetMontoBs(moFacturaAgru.CompDetId)) Then
            FormCheck = False
            Throw New Exception("El Monto de la Factura Excede al Monto de la Cuenta")
         End If
      End If
   End Function

   Private Function CompDetFacturaAgruSaldo(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal decCompDetMonto As Decimal) As Decimal
      Dim oFacturaAgru As New clsFacturaAgru(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         CompDetFacturaAgruSaldo = 0
         decMonto = 0

         With oFacturaAgru
            .SelectFilter = clsFacturaAgru.SelectFilters.All
            .WhereFilter = clsFacturaAgru.WhereFilters.CompDetId
            .EmpresaId = moFacturaAgru.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  If mboolEditing Then
                     If ToLong(txtFacturaAgruId.Text) <> .FacturaAgruId Then
                        decMonto = decMonto + ToDecimal(.FacturaMonto)
                     End If
                  Else
                     decMonto = decMonto + ToDecimal(.FacturaMonto)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         CompDetFacturaAgruSaldo = ToDecimal(decCompDetMonto - decMonto)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oFacturaAgru.Dispose()

      End Try
   End Function

   Private Function CompDetMontoBs(ByVal lngCompDetId As Long) As Decimal
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         CompDetMontoBs = 0

         With oCompDet
            .CompDetId = lngCompDetId

            If .FindByPK Then
               If .DebeBs <> 0 Then
                  CompDetMontoBs = ToDecimal(.DebeBs)

               ElseIf .HaberBs <> 0 Then
                  CompDetMontoBs = ToDecimal(.HaberBs)
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompMontoBs(ByVal lngCompId As Long) As Decimal
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         CompMontoBs = 0
         decMonto = 0

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
            .EmpresaId = moFacturaAgru.EmpresaId
            .CompId = lngCompId
            .Automatico = 0

            If .Open Then
               Do While .Read()
                  decMonto = decMonto + ToDecimal(.HaberBs)

                  .MoveNext()
               Loop
            End If
         End With

         CompMontoBs = ToDecimal(decMonto)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompDetUpdateResto(ByVal lngCompId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      Try
         CompDetUpdateResto = False

         With oCompDet
            .SelectFilter = clsCompDet.SelectFilters.All
            .WhereFilter = clsCompDet.WhereFilters.CompId
            .EmpresaId = moFacturaAgru.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read()
                  .Fecha = ToDate(.Fecha)
                  .EstadoId = 13

                  If .MonedaId = 1 Then
                     If .DebeOrg <> 0 Then
                        .DebeBs = .DebeOrg
                        .HaberBs = 0
                        .DebeUs = ToDecimal(.DebeOrg / mdecTipoCambio)
                        .HaberUs = 0
                     ElseIf .HaberOrg <> 0 Then
                        .DebeBs = 0
                        .HaberBs = .HaberOrg
                        .DebeUs = 0
                        .HaberUs = ToDecimal(.HaberOrg / mdecTipoCambio)
                     End If
                  ElseIf .MonedaId = 2 Then
                     If .DebeOrg <> 0 Then
                        .DebeBs = ToDecimal(.DebeOrg * mdecTipoCambio)
                        .HaberBs = 0
                        .DebeUs = .DebeOrg
                        .HaberUs = 0
                     ElseIf .HaberOrg <> 0 Then
                        .DebeBs = 0
                        .HaberBs = ToDecimal(.HaberOrg * mdecTipoCambio)
                        .DebeUs = 0
                        .HaberUs = .HaberOrg
                     End If
                  End If

                  If .Update() Then
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         CompDetUpdateResto = True

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtFacturaMonto.FormatString = DecimalMask()
      txtIceIehd.FormatString = DecimalMask()
      txtExento.FormatString = DecimalMask()
      txtNeto.FormatString = DecimalMask()
      txtIVA.FormatString = DecimalMask()
      txtImporteIVA.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()
      Call cboEstadoLoad()
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

   Private Sub EmpresaParaLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresaPara As New clsEmpresaPara(clsAppInfo.ConnectString)

      Try
         With oEmpresaPara
            .SelectFilter = clsEmpresaPara.SelectFilters.All
            .WhereFilter = clsEmpresaPara.WhereFilters.EmpresaId
            .EmpresaId = lngEmpresaId

            If .Find Then
               'txtNroAutorizacion.Text = ToStr(.FacNroAutorizacion)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresaPara.Dispose()

      End Try
   End Sub

   Private Sub DosificaLoad(ByVal lngEmpresaId As Long)
      Dim oDosifica As New clsDosifica(clsAppInfo.ConnectString)

      Try
         With oDosifica
            .SelectFilter = clsDosifica.SelectFilters.All
            .WhereFilter = clsDosifica.WhereFilters.TipoDosificaId
            .OrderByFilter = clsDosifica.OrderByFilters.NumeroIni
            .EmpresaId = lngEmpresaId
            .TipoDosificaId = 1 'Manual
            .SucursalId = moFacturaAgru.SucursalId
            .EstadoId = 11

            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If ((ToLong(txtFacturaNroIni.Text) >= oRow("NumeroIni")) And (ToLong(txtFacturaNroIni.Text) <= oRow("NumeroFin"))) _
                  And ((ToLong(txtFacturaNroFin.Text) >= oRow("NumeroIni")) And (ToLong(txtFacturaNroFin.Text) <= oRow("NumeroFin"))) Then
                     moFacturaAgru.SucursalId = oRow("SucursalId")
                     moFacturaAgru.DosificaId = oRow("DosificaId")
                     txtNroAutorizacion.Text = ToStr(oRow("NroAutorizacion"))
                  End If
               Next
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosifica.Dispose()

      End Try
   End Sub

   Private Sub txtFacturaNroIni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturaNroIni.LostFocus
      If txtFacturaNroIni.Tag <> txtFacturaNroIni.Text Then
         txtFacturaNroIni.Tag = txtFacturaNroIni.Text

         txtNroAutorizacion.Text = "0"
         Call DosificaLoad(moFacturaAgru.EmpresaId)
      End If
   End Sub

   Private Sub txtFacturaNroFin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFacturaNroFin.LostFocus
      If txtFacturaNroFin.Tag <> txtFacturaNroFin.Text Then
         txtFacturaNroFin.Tag = txtFacturaNroFin.Text

         txtNroAutorizacion.Text = "0"
         Call DosificaLoad(moFacturaAgru.EmpresaId)
      End If
   End Sub

   Private Sub txtFacturaMonto_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFacturaMonto.KeyUp
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))
   End Sub

   Private Sub txtIceIehd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIceIehd.KeyUp
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))
   End Sub

   Private Sub txtExento_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtExento.KeyUp
      txtNeto.Text = ToDecStr(ToDecimal(txtFacturaMonto.Text) - (ToDecimal(txtIceIehd.Text) + ToDecimal(txtExento.Text)))
      txtIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) * clsAppInfo.IVA)
      txtImporteIVA.Text = ToDecStr(ToDecimal(txtNeto.Text) - ToDecimal(txtIVA.Text))
   End Sub

   Private Sub frmFacturaAgruEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moFacturaAgru.FacturaAgruId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmFacturaAgruEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moFacturaAgru.Dispose()
      Call ClearMemory()
   End Sub

End Class
