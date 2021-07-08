Public Class frmPolizaEdit
   Inherits System.Windows.Forms.Form

   Private moPoliza As clsPoliza
   Private mdecTipoCambio As Decimal
   Private mboolAnulada As Boolean
   Private mstrCompFecha As String

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents chkBancarizar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboTipoFacCompra As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents lblTipoFacCompraId As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtPolizaObs As Janus.Windows.GridEX.EditControls.EditBox
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

   WriteOnly Property DataObject() As clsPoliza
      Set(ByVal Value As clsPoliza)
         moPoliza = Value
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
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents txtPolizaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents dtpPolizaFecha As Janus.Windows.CalendarCombo.CalendarCombo
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
   Friend WithEvents txtAduanaNIT As Janus.Windows.GridEX.EditControls.NumericEditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents cboAduana As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtIVA As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtIceIehd As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtPolizaNro As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPolizaMonto As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPolizaEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboTipoFacCompra = New Janus.Windows.EditControls.UIComboBox
      Me.lblTipoFacCompraId = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.chkBancarizar = New Janus.Windows.EditControls.UICheckBox
      Me.txtPolizaMonto = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtPolizaNro = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtIVA = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtIceIehd = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboAduana = New Janus.Windows.EditControls.UIComboBox
      Me.txtAduanaNIT = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.dtpPolizaFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtPolizaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.Label20 = New System.Windows.Forms.Label
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
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtPolizaObs = New Janus.Windows.GridEX.EditControls.EditBox
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 315)
      Me.bcgMain.TabIndex = 185
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.txtPolizaObs)
      Me.grpMain.Controls.Add(Me.cboTipoFacCompra)
      Me.grpMain.Controls.Add(Me.lblTipoFacCompraId)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.cboSucursal)
      Me.grpMain.Controls.Add(Me.chkBancarizar)
      Me.grpMain.Controls.Add(Me.txtPolizaMonto)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtPolizaNro)
      Me.grpMain.Controls.Add(Me.txtIVA)
      Me.grpMain.Controls.Add(Me.txtIceIehd)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.cboAduana)
      Me.grpMain.Controls.Add(Me.txtAduanaNIT)
      Me.grpMain.Controls.Add(Me.dtpPolizaFecha)
      Me.grpMain.Controls.Add(Me.txtPolizaId)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label19)
      Me.grpMain.Controls.Add(Me.Label20)
      Me.grpMain.Controls.Add(Me.Label21)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 308)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboTipoFacCompra
      '
      Me.cboTipoFacCompra.DropListFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFacCompra.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFacCompra.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFacCompra.Location = New System.Drawing.Point(112, 256)
      Me.cboTipoFacCompra.Name = "cboTipoFacCompra"
      Me.cboTipoFacCompra.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoFacCompra.Size = New System.Drawing.Size(320, 20)
      Me.cboTipoFacCompra.TabIndex = 11
      Me.cboTipoFacCompra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblTipoFacCompraId
      '
      Me.lblTipoFacCompraId.BackColor = System.Drawing.Color.Transparent
      Me.lblTipoFacCompraId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTipoFacCompraId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblTipoFacCompraId.Location = New System.Drawing.Point(4, 260)
      Me.lblTipoFacCompraId.Name = "lblTipoFacCompraId"
      Me.lblTipoFacCompraId.Size = New System.Drawing.Size(104, 16)
      Me.lblTipoFacCompraId.TabIndex = 220
      Me.lblTipoFacCompraId.Text = "Tipo Compra"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 44)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 210
      Me.Label2.Text = "Sucursal"
      '
      'cboSucursal
      '
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(116, 40)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(320, 20)
      Me.cboSucursal.TabIndex = 2
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkBancarizar
      '
      Me.chkBancarizar.BackColor = System.Drawing.Color.Transparent
      Me.chkBancarizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkBancarizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkBancarizar.Location = New System.Drawing.Point(8, 232)
      Me.chkBancarizar.Name = "chkBancarizar"
      Me.chkBancarizar.Size = New System.Drawing.Size(232, 20)
      Me.chkBancarizar.TabIndex = 10
      Me.chkBancarizar.TabStop = False
      Me.chkBancarizar.Text = "Bancarizar esta Poliza"
      Me.chkBancarizar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtPolizaMonto
      '
      Me.txtPolizaMonto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPolizaMonto.FormatString = "##,##0.000"
      Me.txtPolizaMonto.Location = New System.Drawing.Point(116, 160)
      Me.txtPolizaMonto.Name = "txtPolizaMonto"
      Me.txtPolizaMonto.ReadOnly = True
      Me.txtPolizaMonto.Size = New System.Drawing.Size(124, 20)
      Me.txtPolizaMonto.TabIndex = 7
      Me.txtPolizaMonto.Text = "0,000"
      Me.txtPolizaMonto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtPolizaMonto.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtPolizaMonto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 164)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 208
      Me.Label1.Text = "Monto Imponible"
      '
      'txtPolizaNro
      '
      Me.txtPolizaNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPolizaNro.Location = New System.Drawing.Point(116, 88)
      Me.txtPolizaNro.MaxLength = 50
      Me.txtPolizaNro.Name = "txtPolizaNro"
      Me.txtPolizaNro.Size = New System.Drawing.Size(124, 20)
      Me.txtPolizaNro.TabIndex = 4
      Me.txtPolizaNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPolizaNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIVA
      '
      Me.txtIVA.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIVA.FormatString = "##,##0.000"
      Me.txtIVA.Location = New System.Drawing.Point(116, 184)
      Me.txtIVA.Name = "txtIVA"
      Me.txtIVA.Size = New System.Drawing.Size(124, 20)
      Me.txtIVA.TabIndex = 8
      Me.txtIVA.Text = "0,000"
      Me.txtIVA.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIVA.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIVA.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtIceIehd
      '
      Me.txtIceIehd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtIceIehd.FormatString = "##,##0.000"
      Me.txtIceIehd.Location = New System.Drawing.Point(116, 208)
      Me.txtIceIehd.Name = "txtIceIehd"
      Me.txtIceIehd.Size = New System.Drawing.Size(124, 20)
      Me.txtIceIehd.TabIndex = 9
      Me.txtIceIehd.Text = "0,000"
      Me.txtIceIehd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtIceIehd.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtIceIehd.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 188)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 206
      Me.Label4.Text = "IVA Poliza"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 212)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 205
      Me.Label7.Text = "ICE"
      '
      'cboAduana
      '
      Me.cboAduana.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboAduana.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAduana.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboAduana.Location = New System.Drawing.Point(116, 112)
      Me.cboAduana.Name = "cboAduana"
      Me.cboAduana.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboAduana.Size = New System.Drawing.Size(320, 20)
      Me.cboAduana.TabIndex = 5
      Me.cboAduana.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtAduanaNIT
      '
      Me.txtAduanaNIT.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtAduanaNIT.FormatString = "###############"
      Me.txtAduanaNIT.Location = New System.Drawing.Point(116, 136)
      Me.txtAduanaNIT.MaxLength = 15
      Me.txtAduanaNIT.Name = "txtAduanaNIT"
      Me.txtAduanaNIT.Size = New System.Drawing.Size(124, 20)
      Me.txtAduanaNIT.TabIndex = 6
      Me.txtAduanaNIT.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtAduanaNIT.Value = CType(0, Long)
      Me.txtAduanaNIT.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtAduanaNIT.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'dtpPolizaFecha
      '
      Me.dtpPolizaFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpPolizaFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpPolizaFecha.DropDownCalendar.Name = ""
      Me.dtpPolizaFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpPolizaFecha.Location = New System.Drawing.Point(116, 64)
      Me.dtpPolizaFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpPolizaFecha.Name = "dtpPolizaFecha"
      Me.dtpPolizaFecha.Size = New System.Drawing.Size(124, 20)
      Me.dtpPolizaFecha.TabIndex = 3
      Me.dtpPolizaFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtPolizaId
      '
      Me.txtPolizaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPolizaId.Location = New System.Drawing.Point(116, 16)
      Me.txtPolizaId.Name = "txtPolizaId"
      Me.txtPolizaId.ReadOnly = True
      Me.txtPolizaId.Size = New System.Drawing.Size(124, 20)
      Me.txtPolizaId.TabIndex = 1
      Me.txtPolizaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPolizaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 92)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 202
      Me.Label15.Text = "Número Poliza"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(8, 68)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 201
      Me.Label16.Text = "Fecha"
      '
      'Label19
      '
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(8, 116)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(104, 16)
      Me.Label19.TabIndex = 198
      Me.Label19.Text = "Agencia Aduanera"
      '
      'Label20
      '
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.Location = New System.Drawing.Point(8, 140)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(104, 16)
      Me.Label20.TabIndex = 197
      Me.Label20.Text = "NIT Agencia Ad."
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
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(4, 284)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 239
      Me.Label3.Text = "Observación"
      '
      'txtPolizaObs
      '
      Me.txtPolizaObs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtPolizaObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPolizaObs.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPolizaObs.Location = New System.Drawing.Point(112, 280)
      Me.txtPolizaObs.MaxLength = 255
      Me.txtPolizaObs.Multiline = True
      Me.txtPolizaObs.Name = "txtPolizaObs"
      Me.txtPolizaObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtPolizaObs.Size = New System.Drawing.Size(320, 20)
      Me.txtPolizaObs.TabIndex = 238
      Me.txtPolizaObs.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPolizaObs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'frmPolizaEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 343)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmPolizaEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Poliza Edit"
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
               mlngID = moPoliza.PolizaId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPolizaEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPolizaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Poliza de Importación"
         Else
            Me.Text = "Editar Poliza de Importación"
         End If
      Else
         Me.Text = "Nueva Poliza de Importación"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub CloneVM(ByRef oVM As clsPolizaVM)
      oVM = New clsPolizaVM

      With oVM
         .PolizaId = moPoliza.PolizaId
         .SucursalId = moPoliza.SucursalId
         .SucursalDes = cboSucursal.Text
         .PolizaFecha = dtpPolizaFecha.Text
         .AduanaNIT = moPoliza.AduanaNIT
         .AduanaDes = moPoliza.AduanaDes
         .PolizaNro = moPoliza.PolizaNro
         .PolizaMonto = moPoliza.PolizaMonto
         .IVA = moPoliza.IVA
         .ICEIEHD = moPoliza.IceIehd
         .Bancarizar = ToByte(chkBancarizar.Checked)
         .TipoFacCompraId = moPoliza.TipoFacCompraId
         .TipoFacCompraDes = cboTipoFacCompra.Text

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moPoliza
         txtPolizaId.Text = ToStr(.PolizaId)
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)
         dtpPolizaFecha.Text = .PolizaFecha
         cboAduana.Text = ToStr(.AduanaDes)
         txtAduanaNIT.Text = ToStr(.AduanaNIT)
         txtPolizaNro.Text = ToStr(.PolizaNro)
         txtPolizaMonto.Text = ToDecStr(.PolizaMonto)
         txtIVA.Text = ToDecStr(.IVA)
         txtIceIehd.Text = ToDecStr(.IceIehd)
         txtPolizaObs.Text = .PolizaObs
         chkBancarizar.Checked = .Bancarizar
         cboTipoFacCompra.SelectedIndex = ListFindItem(cboTipoFacCompra, .TipoFacCompraId)

         cboSucursal.Select()

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Poliza de Importación"
               .VMOld.ToShowOpe()
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moPoliza
         txtPolizaId.Text = String.Empty
         cboSucursal.SelectedIndex = -1
         dtpPolizaFecha.Text = .PolizaFecha
         cboAduana.SelectedIndex = -1
         txtAduanaNIT.Text = String.Empty
         txtPolizaNro.Text = String.Empty
         txtPolizaMonto.Text = "0"
         txtIVA.Text = "0"
         txtIceIehd.Text = "0"
         txtPolizaObs.Text = ""
         cboTipoFacCompra.SelectedIndex = -1

         If .PolizaMonto >= 50000 Then
            chkBancarizar.Checked = True
         Else
            chkBancarizar.Checked = False
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtPolizaId.ReadOnly = True
      cboSucursal.ReadOnly = True
      dtpPolizaFecha.ReadOnly = True
      cboAduana.ReadOnly = True
      txtAduanaNIT.ReadOnly = True
      txtPolizaNro.ReadOnly = True
      txtPolizaMonto.ReadOnly = True
      txtIVA.ReadOnly = True
      txtIceIehd.ReadOnly = True
      chkBancarizar.Enabled = False
      txtPolizaObs.ReadOnly = True
      cboTipoFacCompra.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moPoliza
         If Not mboolAdding Then
            .PolizaId = ToLong(txtPolizaId.Text)
         End If

         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
         .MesId = dtpPolizaFecha.Value.Month
         .PolizaFecha = ToDate(dtpPolizaFecha.Value)
         .PolizaNro = ToStr(txtPolizaNro.Text)
         .AduanaId = ListPosition(cboAduana, cboAduana.SelectedIndex)
         .AduanaDes = ToStr(cboAduana.Text)
         .AduanaNIT = ToStr(txtAduanaNIT.Text)
         .PolizaMonto = ToDecimal(txtPolizaMonto.Text)
         .IVA = ToDecimal(txtIVA.Text)
         .IceIehd = ToDecimal(txtIceIehd.Text)
         .Bancarizar = ToBoolean(chkBancarizar.Checked)
         .TipoFacCompraId = ListPosition(cboTipoFacCompra, cboTipoFacCompra.SelectedIndex)
         .PolizaObs = txtPolizaObs.Text

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboSucursal.Select()
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

         If moPoliza.Insert() Then
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

         If moPoliza.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If GestionIdFind(ToDate(dtpPolizaFecha.Value)) <> clsAppInfo.GestionId Then
         FormCheck = False
         Throw New Exception("Fecha no Corresponde a la Gestion en Uso")
      End If

      If moPoliza.TipoFacCompraId <= 0 Then
         strMsg &= "Tipo de Compra Inválido" & vbCrLf
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
            .EmpresaId = moPoliza.EmpresaId
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

   End Sub

   Private Sub ComboLoad()
      Call cboSucursalLoad()
      Call cboAduanaLoad()
      Call cboTipoFacCompraLoad()
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
            .EmpresaId = moPoliza.EmpresaId

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

   Private Sub cboAduanaLoad()
      Dim oAduana As New clsAduana(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboAduana.Items.Clear()

      Try
         With oAduana
            .SelectFilter = clsAduana.SelectFilters.ListBox
            .OrderByFilter = clsAduana.OrderByFilters.AduanaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.AduanaId, .AduanaDes)

                  cboAduana.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAduana.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboTipoFacCompraLoad()
      Dim oTipoFacCompra As New clsTipoFacCompra(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoFacCompra.Items.Clear()

      Try
         With oTipoFacCompra
            .SelectFilter = clsTipoFacCompra.SelectFilters.ListBox
            .OrderByFilter = clsTipoFacCompra.OrderByFilters.TipoFacCompraId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoFacCompraId, .TipoFacCompraDes)

                  cboTipoFacCompra.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoFacCompra.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Function AduanaNitFind(ByVal lngAduanaId As Long) As String
      Dim oAduana As New clsAduana(clsAppInfo.ConnectString)

      Try
         AduanaNitFind = ""

         With oAduana
            .AduanaId = lngAduanaId

            If .FindByPK Then
               AduanaNitFind = .AduanaNIT
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oAduana.Dispose()

      End Try
   End Function

   Private Sub cboAduana_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAduana.LostFocus
      If cboAduana.Tag <> cboAduana.Text Then
         cboAduana.Tag = cboAduana.Text

         If ListPosition(cboAduana, cboAduana.SelectedIndex) <> 0 Then
            txtAduanaNIT.Text = AduanaNitFind(ListPosition(cboAduana, cboAduana.SelectedIndex))
         End If
      End If
   End Sub

   Private Sub txtIVA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIVA.TextChanged
      txtPolizaMonto.Text = ToDecimal((ToDecimal(txtIVA.Text) / clsAppInfo.IVA) + ToDecimal(txtIceIehd.Text))
      txtPolizaMonto.Text = (txtPolizaMonto.Text) + (txtIceIehd.Text)
   End Sub

   Private Sub txtIceIehd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIceIehd.TextChanged
      txtPolizaMonto.Text = ToDecimal((ToDecimal(txtIVA.Text) / clsAppInfo.IVA) + ToDecimal(txtIceIehd.Text))
      txtPolizaMonto.Text = (txtPolizaMonto.Text) + (txtIceIehd.Text)
   End Sub

   Private Sub txtPolizaMonto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPolizaMonto.TextChanged
      If ToDecimal(txtPolizaMonto.Text) >= 50000 Then
         chkBancarizar.Checked = True
      Else
         chkBancarizar.Checked = False
      End If
   End Sub

   Private Sub frmPolizaEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moPoliza.PolizaId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPolizaEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPoliza.Dispose()
      Call ClearMemory()
   End Sub

End Class
