Public Class frmCompChequeEdit
   Inherits System.Windows.Forms.Form

   Private moCompCheque As clsCompCheque
   Private mboolAnulada As Boolean
   Private mboolDesdeComp As Boolean

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolEditCob As Boolean
   Private mboolNuevoComprobante As Boolean
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtConcepto As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents cboCiudad As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents txtChequeCobDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaCob As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboEstadoCob As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtChequeId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label45 As System.Windows.Forms.Label
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Delete1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Private mlngID As Long

   WriteOnly Property Anulada() As Boolean
      Set(ByVal Value As Boolean)
         mboolAnulada = Value
      End Set
   End Property

   WriteOnly Property DesdeComp() As Boolean
      Set(ByVal Value As Boolean)
         mboolDesdeComp = Value
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

   WriteOnly Property EditCob() As Boolean
      Set(ByVal Value As Boolean)
         mboolEditCob = Value
      End Set
   End Property

   WriteOnly Property NuevoComprobante() As Boolean
      Set(ByVal value As Boolean)
         mboolNuevoComprobante = value
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

   WriteOnly Property DataObject() As clsCompCheque
      Set(ByVal Value As clsCompCheque)
         moCompCheque = Value
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
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtChequeNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtCompChequeId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents txtChequeMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtChequeDetNro As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtLiteral As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtChequeDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents lblBancoDes As System.Windows.Forms.Label
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents lblBancoCTA As System.Windows.Forms.Label
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompChequeEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaCob = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboEstadoCob = New Janus.Windows.EditControls.UIComboBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtChequeCobDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label45 = New System.Windows.Forms.Label
      Me.txtChequeId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboCiudad = New Janus.Windows.EditControls.UIComboBox
      Me.Label22 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtConcepto = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtChequeDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtLiteral = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtChequeDetNro = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtChequeMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtChequeNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtCompChequeId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.lblBancoCTA = New System.Windows.Forms.Label
      Me.lblBancoDes = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
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
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Delete1 = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
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
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 350)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.dtpFechaCob)
      Me.UiGroupBox1.Controls.Add(Me.Label2)
      Me.UiGroupBox1.Controls.Add(Me.cboEstadoCob)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.txtChequeCobDes)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 252)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 92)
      Me.UiGroupBox1.TabIndex = 12
      Me.UiGroupBox1.Text = "Cobranza Cheque"
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dtpFechaCob
      '
      Me.dtpFechaCob.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaCob.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaCob.DropDownCalendar.Name = ""
      Me.dtpFechaCob.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaCob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFechaCob.Location = New System.Drawing.Point(88, 44)
      Me.dtpFechaCob.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaCob.Name = "dtpFechaCob"
      Me.dtpFechaCob.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaCob.TabIndex = 14
      Me.dtpFechaCob.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 48)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(80, 16)
      Me.Label2.TabIndex = 206
      Me.Label2.Text = "Fecha"
      '
      'cboEstadoCob
      '
      Me.cboEstadoCob.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstadoCob.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboEstadoCob.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstadoCob.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstadoCob.Location = New System.Drawing.Point(88, 20)
      Me.cboEstadoCob.Name = "cboEstadoCob"
      Me.cboEstadoCob.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstadoCob.Size = New System.Drawing.Size(124, 20)
      Me.cboEstadoCob.TabIndex = 13
      Me.cboEstadoCob.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 24)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(80, 16)
      Me.Label6.TabIndex = 204
      Me.Label6.Text = "Estado"
      '
      'txtChequeCobDes
      '
      Me.txtChequeCobDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtChequeCobDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeCobDes.Location = New System.Drawing.Point(88, 68)
      Me.txtChequeCobDes.Name = "txtChequeCobDes"
      Me.txtChequeCobDes.Size = New System.Drawing.Size(344, 20)
      Me.txtChequeCobDes.TabIndex = 15
      Me.txtChequeCobDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeCobDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 72)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(80, 16)
      Me.Label3.TabIndex = 190
      Me.Label3.Text = "Descripción"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.Label45)
      Me.grpMain.Controls.Add(Me.txtChequeId)
      Me.grpMain.Controls.Add(Me.cboCiudad)
      Me.grpMain.Controls.Add(Me.Label22)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtConcepto)
      Me.grpMain.Controls.Add(Me.txtChequeDes)
      Me.grpMain.Controls.Add(Me.txtLiteral)
      Me.grpMain.Controls.Add(Me.txtChequeDetNro)
      Me.grpMain.Controls.Add(Me.txtChequeMonto)
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.txtChequeNro)
      Me.grpMain.Controls.Add(Me.txtCompChequeId)
      Me.grpMain.Controls.Add(Me.lblBancoCTA)
      Me.grpMain.Controls.Add(Me.lblBancoDes)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Controls.Add(Me.Label13)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 244)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(4, 116)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(84, 16)
      Me.Label7.TabIndex = 208
      Me.Label7.Text = "Chequera"
      '
      'cboMoneda
      '
      Me.cboMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(88, 136)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.ReadOnly = True
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(124, 20)
      Me.cboMoneda.TabIndex = 8
      Me.cboMoneda.TabStop = False
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(4, 136)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(84, 16)
      Me.Label15.TabIndex = 207
      Me.Label15.Text = "Moneda"
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(308, 112)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.ReadOnly = True
      Me.txtTipoCambio.Size = New System.Drawing.Size(124, 20)
      Me.txtTipoCambio.TabIndex = 5
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label45
      '
      Me.Label45.BackColor = System.Drawing.Color.Transparent
      Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label45.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label45.Location = New System.Drawing.Point(260, 116)
      Me.Label45.Name = "Label45"
      Me.Label45.Size = New System.Drawing.Size(50, 16)
      Me.Label45.TabIndex = 205
      Me.Label45.Text = "T. C."
      '
      'txtChequeId
      '
      Me.txtChequeId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeId.Location = New System.Drawing.Point(8, 88)
      Me.txtChequeId.Name = "txtChequeId"
      Me.txtChequeId.ReadOnly = True
      Me.txtChequeId.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeId.TabIndex = 203
      Me.txtChequeId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeId.Visible = False
      Me.txtChequeId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboCiudad
      '
      Me.cboCiudad.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.Location = New System.Drawing.Point(308, 64)
      Me.cboCiudad.Name = "cboCiudad"
      Me.cboCiudad.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCiudad.Size = New System.Drawing.Size(124, 20)
      Me.cboCiudad.TabIndex = 3
      Me.cboCiudad.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.Location = New System.Drawing.Point(256, 68)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(48, 16)
      Me.Label22.TabIndex = 202
      Me.Label22.Text = "Ciudad"
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(4, 216)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(84, 16)
      Me.Label1.TabIndex = 200
      Me.Label1.Text = "Concepto"
      '
      'txtConcepto
      '
      Me.txtConcepto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtConcepto.Location = New System.Drawing.Point(88, 212)
      Me.txtConcepto.MaxLength = 100
      Me.txtConcepto.Name = "txtConcepto"
      Me.txtConcepto.Size = New System.Drawing.Size(344, 20)
      Me.txtConcepto.TabIndex = 11
      Me.txtConcepto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtConcepto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtChequeDes
      '
      Me.txtChequeDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeDes.Location = New System.Drawing.Point(88, 164)
      Me.txtChequeDes.MaxLength = 100
      Me.txtChequeDes.Name = "txtChequeDes"
      Me.txtChequeDes.Size = New System.Drawing.Size(344, 20)
      Me.txtChequeDes.TabIndex = 9
      Me.txtChequeDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtLiteral
      '
      Me.txtLiteral.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtLiteral.Location = New System.Drawing.Point(88, 188)
      Me.txtLiteral.Name = "txtLiteral"
      Me.txtLiteral.ReadOnly = True
      Me.txtLiteral.Size = New System.Drawing.Size(344, 20)
      Me.txtLiteral.TabIndex = 10
      Me.txtLiteral.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtLiteral.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtChequeDetNro
      '
      Me.txtChequeDetNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeDetNro.Location = New System.Drawing.Point(88, 112)
      Me.txtChequeDetNro.Name = "txtChequeDetNro"
      Me.txtChequeDetNro.ReadOnly = True
      Me.txtChequeDetNro.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeDetNro.TabIndex = 7
      Me.txtChequeDetNro.TabStop = False
      Me.txtChequeDetNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeDetNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtChequeMonto
      '
      Me.txtChequeMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeMonto.FormatString = "##,##0.00"
      Me.txtChequeMonto.Location = New System.Drawing.Point(308, 136)
      Me.txtChequeMonto.Name = "txtChequeMonto"
      Me.txtChequeMonto.ReadOnly = True
      Me.txtChequeMonto.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeMonto.TabIndex = 6
      Me.txtChequeMonto.Text = "0,00"
      Me.txtChequeMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtChequeMonto.Value = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.txtChequeMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.dtpFecha.Location = New System.Drawing.Point(308, 88)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(124, 20)
      Me.dtpFecha.TabIndex = 4
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtChequeNro
      '
      Me.txtChequeNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeNro.FormatString = "##################"
      Me.txtChequeNro.Location = New System.Drawing.Point(308, 40)
      Me.txtChequeNro.Name = "txtChequeNro"
      Me.txtChequeNro.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeNro.TabIndex = 2
      Me.txtChequeNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeNro.Value = CType(0, Long)
      Me.txtChequeNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtChequeNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCompChequeId
      '
      Me.txtCompChequeId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompChequeId.Location = New System.Drawing.Point(308, 16)
      Me.txtCompChequeId.Name = "txtCompChequeId"
      Me.txtCompChequeId.ReadOnly = True
      Me.txtCompChequeId.Size = New System.Drawing.Size(124, 20)
      Me.txtCompChequeId.TabIndex = 1
      Me.txtCompChequeId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompChequeId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblBancoCTA
      '
      Me.lblBancoCTA.BackColor = System.Drawing.Color.Transparent
      Me.lblBancoCTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblBancoCTA.ForeColor = System.Drawing.Color.Brown
      Me.lblBancoCTA.Location = New System.Drawing.Point(4, 56)
      Me.lblBancoCTA.Name = "lblBancoCTA"
      Me.lblBancoCTA.Size = New System.Drawing.Size(244, 20)
      Me.lblBancoCTA.TabIndex = 198
      Me.lblBancoCTA.Tag = ""
      Me.lblBancoCTA.Text = "BancoCTA"
      '
      'lblBancoDes
      '
      Me.lblBancoDes.BackColor = System.Drawing.Color.Transparent
      Me.lblBancoDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblBancoDes.ForeColor = System.Drawing.Color.Brown
      Me.lblBancoDes.Location = New System.Drawing.Point(4, 16)
      Me.lblBancoDes.Name = "lblBancoDes"
      Me.lblBancoDes.Size = New System.Drawing.Size(244, 40)
      Me.lblBancoDes.TabIndex = 197
      Me.lblBancoDes.Text = "BancoDes"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(4, 192)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(84, 16)
      Me.Label4.TabIndex = 196
      Me.Label4.Text = "La suma de"
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(260, 140)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(44, 16)
      Me.Label5.TabIndex = 195
      Me.Label5.Text = "Monto"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(260, 92)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(44, 16)
      Me.Label10.TabIndex = 194
      Me.Label10.Text = "Fecha"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(284, 20)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(20, 16)
      Me.Label11.TabIndex = 193
      Me.Label11.Text = "ID"
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(4, 160)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(84, 28)
      Me.Label12.TabIndex = 192
      Me.Label12.Text = "Páguese a la orden de"
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(252, 44)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(52, 16)
      Me.Label13.TabIndex = 191
      Me.Label13.Text = "Número"
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Print, Me.Delete})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Delete1, Me.Separator3, Me.Print1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(300, 28)
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
      Me.Print.ImageIndex = 2
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
      'Delete
      '
      Me.Delete.ImageIndex = 3
      Me.Delete.Key = "Delete"
      Me.Delete.Name = "Delete"
      Me.Delete.Text = "Eliminar"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      Me.ilsMain.Images.SetKeyName(2, "")
      Me.ilsMain.Images.SetKeyName(3, "")
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Delete1
      '
      Me.Delete1.Key = "Delete"
      Me.Delete1.Name = "Delete1"
      '
      'frmCompChequeEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.Beige
      Me.ClientSize = New System.Drawing.Size(462, 378)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompChequeEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompCheque Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
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
               mlngID = moCompCheque.CompChequeId
               mboolChanged = True

               If Not mboolEditCob Then
                  If MessageBox.Show("Cheque Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Cheque?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     Call PrintReport()
                  End If
               Else
                  MessageBox.Show("Cheque Guardado Exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
               End If

               Me.Close()
            End If

         Case "Delete"
            If DataDelete() Then
               mlngID = 0
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

   Private Sub frmCompChequeEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompChequeEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Cheque"

         ElseIf mboolEditCob Then
            Call HeaderReadOnly()
            Me.Text = "Editar Cheque"

         Else
            Me.Text = "Editar Cheque"
         End If

      Else
         Me.Text = "Nuevo Cheque"
         Call FormNew()

      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCompCheque
         txtCompChequeId.Text = ToStr(.CompChequeId)
         Call txtChequeDetNroLoad()
         ''Call lblBancoCtaFind()
         Call lblBancoDesFind(lblBancoDes.Tag)
         txtChequeNro.Text = ToStr(.ChequeNro)
         txtChequeNro.Tag = txtChequeNro.Text
         cboCiudad.SelectedIndex = ListFindItem(cboCiudad, .CiudadId)
         dtpFecha.Value = .Fecha
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, .MonedaId)
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         txtChequeMonto.Text = ToDecStrDos(.ChequeMonto)
         txtChequeDes.Text = ToStr(.ChequeDes)
         txtLiteral.Text = CifraLiteral(ToDecimalDos(.ChequeMonto))
         txtConcepto.Text = ToStr(.Concepto)

         txtChequeDetNro.Tag = ToLong(.ChequeDetId)
         cboEstadoCob.SelectedIndex = ListFindItem(cboEstadoCob, .EstadoIdCob)
         dtpFechaCob.Value = ToStr(.FechaCob)
         txtChequeCobDes.Text = ToStr(.ChequeCobDes)

         If mboolAnulada Then
            txtTipoCambio.ReadOnly = False
            txtChequeMonto.ReadOnly = False
            cboEstadoCob.ReadOnly = True

            If .EstadoIdCob = 12 Then
               txtChequeNro.ReadOnly = True
            End If
            cdmMain.Commands.Item("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.False

         ElseIf Not mboolDesdeComp Then
            txtChequeNro.ReadOnly = True
         End If

         cdmMain.Commands.Item("Delete").Visible = BooleamToJanus(mboolDesdeComp)
         cdmMain.Commands.Item("Delete").Enabled = BooleamToJanus(mboolDesdeComp)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Cheque"
               .VMOld.ToShowOpe(clsTipoOpera.CONSULTA)
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Public Function CompNroFind(ByVal lngCompId As Long, ByRef TipoCompId As Long)
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      oComp.CompId = lngCompId
      oComp.FindByPK()
      TipoCompId = oComp.TipoCompId
      Return oComp.CompNro
   End Function

   Public Function TipoCompDesFind(ByVal lngTipoCompId As Long)
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      oTipoComp.TipoCompId = lngTipoCompId
      oTipoComp.FindByPK()
      Return oTipoComp.TipoCompDes
   End Function

   Private Sub CloneVM(ByRef oVM As clsCompChequeVM)
      oVM = New clsCompChequeVM

      If (mboolDesdeComp And Not mboolNuevoComprobante) Or Not mboolDesdeComp Then
         With oVM
            .CompChequeId = moCompCheque.CompChequeId
            .ChequeNro = moCompCheque.ChequeNro
            .CiudadId = moCompCheque.CiudadId
            .CiudadDes = cboCiudad.Text
            .Fecha = dtpFecha.Text
            .TipoCambio = moCompCheque.TipoCambio
            .ChequeMonto = moCompCheque.ChequeMonto
            .ChequeDetId = moCompCheque.ChequeDetId
            .ChequeraNro = txtChequeDetNro.Text
            .MonedaId = moCompCheque.MonedaId
            .MonedaDes = cboMoneda.Text
            .ChequeDes = moCompCheque.ChequeDes
            .Concepto = moCompCheque.Concepto
            .ChequeCobDes = moCompCheque.ChequeCobDes
            .FechaCob = dtpFechaCob.Text
            .EstadoDesCob = cboEstadoCob.Text
            .CompId = moCompCheque.CompId
            .CompNro = CompNroFind(moCompCheque.CompId, .TipoCompId)
            .TipoCompDes = TipoCompDesFind(.TipoCompId)
            .PlanId = moCompCheque.PlanId
            .EstadoId = moCompCheque.EstadoId

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCompCheque
         txtCompChequeId.Text = String.Empty
         ''Call txtChequeraLoad()
         Call lblBancoCtaFind()
         Call txtChequeNroNext()
         Call lblBancoDesFind(lblBancoDes.Tag)
         cboCiudad.SelectedIndex = ListFindItem(cboCiudad, clsAppInfo.CiudadId)
         dtpFecha.Value = .Fecha
         cboMoneda.SelectedIndex = ListFindItem(cboMoneda, PlanMonedaIdFind(.PlanId))
         txtTipoCambio.Text = ToDecStr(.TipoCambio)
         txtChequeMonto.Text = ToDecStrDos(.ChequeMonto)
         txtChequeDes.Text = ToStr(.ChequeDes)
         txtLiteral.Text = CifraLiteral(ToDecimalDos(.ChequeMonto))
         txtConcepto.Text = ToStr(.Concepto)

         cboEstadoCob.SelectedIndex = ListFindItem(cboEstadoCob, clsEstado.PENDIENTE)
         dtpFechaCob.Value = dtpFecha.Value
         txtChequeCobDes.Text = ""

         If mboolAnulada Then
            Me.Text = "Nuevo Cheque Anulado"

            Call txtTipoCambioLoad(ToDate(dtpFecha.Value))
            txtTipoCambio.ReadOnly = False
            txtChequeMonto.ReadOnly = False
            cboEstadoCob.ReadOnly = True

            cboEstadoCob.SelectedIndex = ListFindItem(cboEstadoCob, clsEstado.ANULADO)
         End If

      End With

      cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Delete").Visible = Janus.Windows.UI.InheritableBoolean.False

      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCompChequeId.ReadOnly = True
      txtChequeNro.ReadOnly = True
      cboCiudad.ReadOnly = True
      dtpFecha.Enabled = False
      cboMoneda.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtChequeMonto.ReadOnly = True
      txtChequeDes.ReadOnly = True
      txtLiteral.ReadOnly = True
      txtConcepto.ReadOnly = True

      dtpFechaCob.ReadOnly = True
      txtChequeCobDes.ReadOnly = True
      cboEstadoCob.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
      cdmMain.Commands.Item("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.False

   End Sub

   Private Sub HeaderReadOnly()
      txtCompChequeId.ReadOnly = True
      txtChequeNro.ReadOnly = True
      cboCiudad.ReadOnly = True
      dtpFecha.Enabled = False
      cboMoneda.ReadOnly = True
      txtTipoCambio.ReadOnly = True
      txtChequeMonto.ReadOnly = True
      txtChequeDes.ReadOnly = True
      txtLiteral.ReadOnly = True
      txtConcepto.ReadOnly = True

      dtpFechaCob.ReadOnly = False
      txtChequeCobDes.ReadOnly = False
      cboEstadoCob.ReadOnly = False

      dtpFechaCob.Select()

   End Sub

   Private Sub DataMove()
      With moCompCheque
         If Not mboolAdding Then
            .CompChequeId = ToLong(txtCompChequeId.Text)
         Else
            .EstadoId = 11
         End If

         .ChequeId = ToLong(txtChequeId.Tag)
         .ChequeDetId = ToLong(txtChequeDetNro.Tag)
         .ChequeNro = ToLong(txtChequeNro.Text)
         .CiudadId = ListPosition(cboCiudad, cboCiudad.SelectedIndex)
         .Fecha = ToDate(dtpFecha.Value)
         .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
         .TipoCambio = ToDecimal(txtTipoCambio.Text)
         .ChequeMonto = ToDecimal(txtChequeMonto.Text)
         .ChequeDes = ToStr(txtChequeDes.Text)
         .Concepto = ToStr(txtConcepto.Text)

         .FechaCob = ToDate(dtpFechaCob.Value)
         .ChequeCobDes = ToStr(txtChequeCobDes.Text)
         .EstadoIdCob = ListPosition(cboEstadoCob, cboEstadoCob.SelectedIndex)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtChequeNro.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         txtChequeId.Select()
         txtChequeNro.Select()

         Call DataMove()

         If moCompCheque.Validate Then
            If FormCheck() Then
               If mboolAdding Then
                  If Not ChequeNroRango(moCompCheque.ChequeNro) Then
                     If MessageBox.Show("Número de Cheque Fuera de Rango ¿Desea Continuar de Todas Maneras?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        DataSave = DataAdd()
                     End If
                  Else
                     If DataAdd() Then
                        DataSave = ChequeActualUpdate(moCompCheque.ChequeNro)
                     End If
                  End If
               Else
                  DataSave = DataUpdate()
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

         If moCompCheque.Insert() Then
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

         If moCompCheque.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataDelete() As Boolean
      Try
         If MessageBox.Show("¿Realmente desea Eliminar el Cheque?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            moCompCheque.WhereFilter = clsCompCheque.WhereFilters.PrimaryKey
            Call CloneVM(moCompCheque.VMNew)
            If moCompCheque.Delete() Then
               DataDelete = True
            End If
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Public Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty
      Dim lng As String = String.Empty

      If Not mboolEditCob Then

         If moCompCheque.ChequeDetId = 0 Then
            strMsg &= "Nro de Chequera Inválido" & vbCrLf
         End If

         If moCompCheque.ChequeNro <= 0 Then
            strMsg &= "Número de Cheque Inválido" & vbCrLf
         End If

         If moCompCheque.ChequeDes.Trim.Length() = 0 Then
            strMsg &= "Ingrese responsable del Cheque" & vbCrLf
         End If

         If moCompCheque.EstadoIdCob = 0 Then
            strMsg &= "Estado de Cobranza Inválido" & vbCrLf
         End If

         If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
            FormCheck = False
            Throw New Exception("Fecha no Corresponde a la Gestion en Uso")
         ElseIf GestionIdFind(ToDate(dtpFechaCob.Value)) <> clsAppInfo.GestionId Then
            FormCheck = False
            Throw New Exception("Fecha de Cobranza no Corresponde a la Gestion en Uso")
         End If

         If mboolAnulada Then

            If dtpFecha.Value > dtpFechaCob.Value Then
               strMsg &= "La Fecha Cobranza Debe Ser Mayor/igual a la Fecha de Cheque" & vbCrLf
            End If

            If moCompCheque.EstadoIdCob <> clsEstado.ANULADO Then
               strMsg &= "Estado de Cheque Inválido " & vbCrLf
            End If
         Else
            If moCompCheque.ChequeMonto = 0 Then
               strMsg &= "Monto Inválido" & vbCrLf
            End If

            If dtpFecha.Value > dtpFechaCob.Value Then
               strMsg &= "La Fecha Cobranza Debe Ser Mayor/igual a la Fecha de Cheque" & vbCrLf
            End If

            If moCompCheque.EstadoIdCob = clsEstado.ANULADO Then
               strMsg &= "Estado de Cheque Inválido en Cheques de Comprobrantes" & vbCrLf
            End If
         End If

         ''If moCompCheque.CompId = 0 Then

         ''ElseIf moCompCheque.CompId <> 0 Then

         ''   If moCompCheque.ChequeMonto = "0" Then
         ''      strMsg &= "Monto Inválido" & vbCrLf
         ''   End If

         ''   If moCompCheque.EstadoIdCob = 8 Then ''Cobrado
         ''      If dtpFecha.Value > dtpFechaCob.Value Then
         ''         strMsg &= "La Fecha Cobranza Debe Ser Mayor a la Fecha de Cheque" & vbCrLf
         ''      End If
         ''   Else
         ''      If dtpFecha.Value < dtpFechaCob.Value Then
         ''         strMsg &= "La Fecha Cobranza Debe Ser Mayor/igual a la Fecha de Cheque" & vbCrLf
         ''      End If
         ''   End If

         ''End If

         If ChequeNroDuplicate(moCompCheque.CompChequeId, moCompCheque.ChequeNro, moCompCheque.ChequeDetId) Then
            strMsg &= "Cheque Duplicado" & vbCrLf
         End If

         ''If mboolEditing Then
         If Not ChequeNroRango(moCompCheque.ChequeNro) Then
            strMsg &= "Número de Cheque Fuera de Rango" & vbCrLf
         End If
         ''End If

         ''If moCompCheque.CompId > 0 Then
         ''   If moCompCheque.EstadoIdCob = clsEstado.ANULADO Then
         ''      Throw New Exception("Estado de Cheque Inválido en Cheques de Comprobrantes")
         ''   End If
         ''End If
      Else
         If moCompCheque.EstadoIdCob = 0 Then
            strMsg &= "Estado de Cobranza Inválido" & vbCrLf
         End If

         If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
            FormCheck = False
            Throw New Exception("Fecha no Corresponde a la Gestion en Uso")
         ElseIf GestionIdFind(ToDate(dtpFechaCob.Value)) <> clsAppInfo.GestionId Then
            FormCheck = False
            Throw New Exception("Fecha de Cobranza no Corresponde a la Gestion en Uso")
         End If

         If dtpFecha.Value > dtpFechaCob.Value Then
            strMsg &= "La Fecha Cobranza Debe Ser Mayor/igual a la Fecha de Cheque" & vbCrLf
         End If

         If moCompCheque.EstadoIdCob = clsEstado.ANULADO Then
            strMsg &= "Estado de Cheque Inválido en Cheques de Comprobrantes" & vbCrLf
         End If

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
            .EmpresaId = clsAppInfo.EmpresaId
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

   Private Sub FormInit()
      Call FormCenter(Me)

      'txtChequeMonto.FormatString = DecimalMask()
      txtTipoCambio.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()
      Call cboCiudadLoad()
      Call cboEstadoLoad()
      Call cboMonedaLoad()
   End Sub

   Private Sub cboCiudadLoad()
      Dim oCiudad As New clsCiudad(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCiudad.Items.Clear()

      Try
         With oCiudad
            .SelectFilter = clsCiudad.SelectFilters.ListBox
            .OrderByFilter = clsCiudad.OrderByFilters.CiudadDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.CiudadId, .CiudadDes)

                  cboCiudad.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCiudad.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboEstadoLoad()
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboEstadoCob.Items.Clear()

      Try
         With oEstado
            .SelectFilter = clsEstado.SelectFilters.ListBox
            .WhereFilter = clsEstado.WhereFilters.TipoId
            .OrderByFilter = clsEstado.OrderByFilters.EstadoDes
            .TipoId = 2

            If .Open() Then
               Do While .Read()
                  ''Cobrado=8, Pendiente=13, Anulado, 12

                  If ((.EstadoId = 8) Or (.EstadoId = 13) Or (.EstadoId = 12)) Then
                     oItem = New clsListItem(.EstadoId, .EstadoDes)
                     cboEstadoCob.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop

               If mboolEditCob Or (Not mboolAnulada) Then
                  cboEstadoCob.Items.RemoveAt(ListFindItem(cboEstadoCob, clsEstado.ANULADO))
                  cboEstadoCob.Items.Sort()
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEstado.Dispose()
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
                  oItem = New clsListItem(.MonedaId, .MonedaDes)

                  cboMoneda.Items.Add(oItem)
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

   Private Sub PrintReport()
      Dim rpt As New rptChequeImp
      Dim oTextBox As DataDynamics.ActiveReports.TextBox
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)
      Dim oChequeImp As New clsChequeImp(clsAppInfo.ConnectString)
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)

      Dim oGraphics As Graphics = Me.CreateGraphics
      Dim decPPIX As Decimal 'Pixels per Inch
      Dim decPPIY As Decimal 'Pixels per Inch
      Dim decPPCMX As Decimal 'Pixels per cm
      Dim decPPCMY As Decimal 'Pixels per cm

      decPPIX = CDec(oGraphics.DpiX) 'Pixels per Inch
      decPPIY = CDec(oGraphics.DpiY) 'Pixels per Inch
      decPPCMX = CDec(decPPIX / 2.64) 'Pixels per cm
      decPPCMY = CDec(decPPIY / 2.64) 'Pixels per cm

      Try
         With oCheque
            .ChequeId = moCompCheque.ChequeId

            If .FindByPK Then
               rpt.Document.Printer.PrinterName = ""

               rpt.PageSettings.PaperKind = Drawing.Printing.PaperKind.Custom
               rpt.PageSettings.PaperWidth = .ChequeWidth / decPPIX
               rpt.PageSettings.PaperHeight = .ChequeHeight / decPPIY

               If .OrientacionId = 1 Then 'Vertical
                  rpt.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
                  rpt.PrintWidth = .ChequeWidth / decPPIX

               ElseIf .OrientacionId = 2 Then 'Horizontal
                  rpt.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
                  rpt.PrintWidth = .ChequeHeight / decPPIY
               End If

               rpt.Sections("Detail1").Height = .ChequeHeight / decPPIY
            End If
         End With

         With oChequeImp
            .SelectFilter = clsChequeImp.SelectFilters.All
            .WhereFilter = clsChequeImp.WhereFilters.ChequeId
            .OrderByFilter = clsChequeImp.OrderByFilters.ChequeImpId
            .ChequeId = moCompCheque.ChequeId

            If .Open() Then
               Do While .Read()
                  For Each oTextBox In rpt.Sections("Detail1").Controls
                     If UCase$(oTextBox.Name) = UCase$(.CtrlName) Then
                        oTextBox.Left = CSng((.CtrlLeft / oGraphics.DpiX) - 0.15)
                        oTextBox.Top = CSng((.CtrlTop / oGraphics.DpiY) - 0.15)

                        oTextBox.Width = CSng(.CtrlWidth / oGraphics.DpiX)
                        oTextBox.Height = CSng(.CtrlHeight / oGraphics.DpiY)

                        oTextBox.Visible = CBool(.CtrlVisible)
                        oTextBox.Tag = .CtrlMaxLength

                        oTextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
                        oTextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
                        oTextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
                        oTextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None

                        Exit For
                     End If
                  Next

                  .MoveNext()
               Loop
            End If
         End With

         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.Report
            .WhereFilter = clsCompCheque.WhereFilters.Report
            .CompChequeId = moCompCheque.CompChequeId

            If .Open Then
               If .DataSet.Tables(.TableName).Rows.Count > 0 Then
                  Dim datFecha As Date = CDate(.DataSet.Tables(.TableName).Rows(0).Item("Fecha"))

                  rpt.txtLugar.Text = ToStr(.DataSet.Tables(.TableName).Rows(0).Item("CiudadDes"))
                  rpt.txtDia.Text = Format(datFecha, "dd")

                  If ToLong(rpt.txtMes.Tag) = 2 Then
                     rpt.txtMes.Text = Format(datFecha, "MM")
                  ElseIf ToLong(rpt.txtMes.Tag) = 3 Then
                     rpt.txtMes.Text = Format(datFecha, "MMM")
                  Else
                     rpt.txtMes.Text = Format(datFecha, "MMMM")
                  End If

                  If ToLong(rpt.txtAnio.Tag) > 0 Then
                     rpt.txtAnio.Text = Microsoft.VisualBasic.Right(datFecha.Year.ToString, ToLong(rpt.txtAnio.Tag))
                  Else
                     rpt.txtAnio.Text = datFecha.Year.ToString
                  End If

                  rpt.txtImporte.Text = ToDecStrDos(.DataSet.Tables(.TableName).Rows(0).Item("ChequeMonto")) & ".-"
                  rpt.txtPaguese.Text = ToStr(.DataSet.Tables(.TableName).Rows(0).Item("ChequeDes"))
                  rpt.txtLiteral.Text = CifraLiteral(ToDecimalDos(.DataSet.Tables(.TableName).Rows(0).Item("ChequeMonto")))

                  If ToLong(rpt.txtConcepto.Tag) > 0 Then
                     rpt.txtConcepto.Text = Microsoft.VisualBasic.Left(ToStr(.DataSet.Tables(.TableName).Rows(0).Item("Concepto")), ToLong(rpt.txtConcepto.Tag))
                  Else
                     rpt.txtConcepto.Text = ToStr(.DataSet.Tables(.TableName).Rows(0).Item("Concepto"))
                  End If
               End If
            End If
         End With

         rpt.Run(False)
         'rpt.Run(True)

         If rpt.Document.Pages.Count() > 1 Then
            rpt.Document.Pages.RemoveAt(rpt.Document.Pages.Count() - 1)
         End If

         rpt.Document.Print(True, True)

         'Dim frm As New frmReportPreview(rpt.Document)
         'frm.Show()

         If (mboolDesdeComp And Not mboolNuevoComprobante) Or Not mboolDesdeComp Then
            Call CloneVM(oCompCheque.VMNew)
            Call oCompCheque.VMNew.ToShowOpe(clsTipoOpera.IMPRESION_INFORME)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCheque.Dispose()
         oChequeImp.Dispose()
         oCompCheque.Dispose()
         oGraphics.Dispose()
      End Try
   End Sub

   Private Sub txtChequeNroNext()
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)

      Try
         With oChequeDet
            .SelectFilter = clsChequeDet.SelectFilters.All
            .WhereFilter = clsChequeDet.WhereFilters.PlanId
            .EmpresaId = moCompCheque.EmpresaId
            .PlanId = moCompCheque.PlanId
            .EstadoId = 11

            If .Find Then
               txtChequeDetNro.Tag = ToLong(.ChequeDetId)
               txtChequeDetNro.Text = ToStr(.ChequeDetNro)

               txtChequeNro.Tag = ToLong(.ChequeActual) + 1
               txtChequeNro.Text = ToStr(ToLong(.ChequeActual) + 1)

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()
      End Try
   End Sub

   Private Sub txtChequeDetNroLoad()
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      Try
         With oChequeDet
            .ChequeDetId = moCompCheque.ChequeDetId

            If .FindByPK Then
               txtChequeId.Tag = ToLong(.ChequeId)
               txtChequeId.Text = ToStr(.ChequeId)

               txtChequeDetNro.Tag = ToLong(.ChequeDetId)
               txtChequeDetNro.Text = ToStr(.ChequeDetNro)

               oCheque.ChequeId = .ChequeId
               If oCheque.FindByPK Then
                  lblBancoDes.Tag = ToLong(.BancoId)
                  lblBancoCTA.Text = ToStr(oCheque.BancoCta)
               End If

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()
         oCheque.Dispose()
      End Try
   End Sub

   Private Sub lblBancoCtaFind()
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      Try
         With oCheque
            .SelectFilter = clsCheque.SelectFilters.All
            .WhereFilter = clsCheque.WhereFilters.PlanId
            .EmpresaId = moCompCheque.EmpresaId
            .PlanId = moCompCheque.PlanId

            If .Find Then
               txtChequeId.Tag = ToLong(.ChequeId)
               txtChequeId.Text = ToStr(.ChequeId)

               lblBancoDes.Tag = ToLong(.BancoId)
               lblBancoCTA.Text = ToStr(.BancoCta)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCheque.Dispose()

      End Try
   End Sub

   Private Sub lblBancoDesFind(ByVal lngBancoId As Long)
      Dim oBanco As New clsBanco(clsAppInfo.ConnectString)

      Try
         With oBanco
            .BancoId = lngBancoId

            If .FindByPK Then
               lblBancoDes.Text = ToStr(.BancoDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oBanco.Dispose()

      End Try
   End Sub

   Private Function PlanMonedaIdFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanMonedaIdFind = 0

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanMonedaIdFind = ToLong(.MonedaId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Sub txtTipoCambioLoad(ByVal strFecha As String)
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
               txtTipoCambio.Text = 0
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub

   Private Sub ChequeDetLoad(ByVal lngEmpresaId As Long)
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)

      Try
         With oChequeDet
            .SelectFilter = clsChequeDet.SelectFilters.All
            .WhereFilter = clsChequeDet.WhereFilters.PlanId
            .EmpresaId = moCompCheque.EmpresaId
            .PlanId = moCompCheque.PlanId
            .EstadoId = 11

            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If (ToLong(txtChequeNro.Text) >= oRow("ChequeIni")) And (ToLong(txtChequeNro.Text) <= oRow("ChequeFin")) Then
                     moCompCheque.ChequeDetId = oRow("ChequeDetId")
                     txtChequeDetNro.Tag = oRow("ChequeDetId")
                     txtChequeDetNro.Text = ToStr(oRow("ChequeDetNro"))

                  End If
               Next
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()

      End Try
   End Sub

   Private Function ChequeNroRango(ByVal lngChequeActual As Long) As Boolean
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)

      ChequeNroRango = False

      Try
         With oChequeDet
            .ChequeDetId = moCompCheque.ChequeDetId

            If .FindByPK Then
               If (lngChequeActual >= .ChequeIni) And (lngChequeActual <= .ChequeFin) Then
                  ChequeNroRango = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()

      End Try
   End Function

   Private Function ChequeActualUpdate(ByVal lngChequeActual As Long) As Boolean
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)

      ChequeActualUpdate = False

      Try
         With oChequeDet
            .ChequeDetId = moCompCheque.ChequeDetId

            If .FindByPK Then
               .UpdateFilter = clsChequeDet.UpdateFilters.ChequeActual
               .ChequeActual = lngChequeActual

               If .Update Then
                  ChequeActualUpdate = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeDet.Dispose()

      End Try
   End Function

   Private Function ChequeNroDuplicate(ByVal lngCompChequeId As Long, ByVal lngChequeNro As Long, ByVal lngChequeDetId As Long) As Long
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      ChequeNroDuplicate = False

      Try
         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.ChequeDup
            .EmpresaId = clsAppInfo.EmpresaId
            ''.ChequeId = lngChequeId
            .ChequeDetId = lngChequeDetId
            .ChequeNro = lngChequeNro
            .CompChequeId = lngCompChequeId
            .ChequeId = moCompCheque.ChequeId

            If .Find Then
               ''ChequeNroDuplicate = .CompChequeId
               ChequeNroDuplicate = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCheque.Dispose()

      End Try
   End Function

   Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
      If mboolAdding And (moCompCheque.CompId = 0) Then
         Call txtTipoCambioLoad(ToDate(dtpFecha.Value))
      End If
   End Sub

   Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
      If mboolAdding Then
         If Not IsNothing(moCompCheque) Then
            If moCompCheque.CompId = 0 Then
               If dtpFecha.Tag <> dtpFecha.Text Then
                  If IsDate(dtpFecha.Text) Then
                     Call txtTipoCambioLoad(ToDate(dtpFecha.Value))
                     dtpFecha.Tag = dtpFecha.Text
                  Else
                     txtTipoCambio.Text = 0
                  End If
               End If
            End If
         End If
      End If
   End Sub

   Private Sub txtChequeNro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtChequeNro.LostFocus
      If txtChequeNro.Tag <> txtChequeNro.Text Then
         txtChequeNro.Tag = txtChequeNro.Text

         txtChequeDetNro.Text = "0"
         txtChequeDetNro.Tag = 0
         Call ChequeDetLoad(moCompCheque.EmpresaId)
      End If
   End Sub

   Private Sub txtChequeMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChequeMonto.TextChanged
      If txtChequeMonto.ContainsFocus Then
         txtLiteral.Text = CifraLiteral(ToDecimalDos(txtChequeMonto.Text))
      End If
   End Sub

   Private Sub frmCompChequeEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If Save.Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moCompCheque.CompChequeId
                  mboolChanged = True

                  If Not mboolEditCob Then
                     If MessageBox.Show("Cheque Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Cheque?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Call PrintReport()
                     End If
                  Else
                     MessageBox.Show("Cheque Guardado Exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                  End If

                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompChequeEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompCheque.Dispose()
      Call ClearMemory()
   End Sub

End Class
