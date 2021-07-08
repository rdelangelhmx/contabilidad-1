Public Class frmChequeDetEdit
   Inherits System.Windows.Forms.Form

   Private moChequeDet As clsChequeDet

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Design As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboBanco As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtBancoCta As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents txtChequeDetNro As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblNro As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
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

   WriteOnly Property DataObject() As clsChequeDet
      Set(ByVal Value As clsChequeDet)
         moChequeDet = Value
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
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents txtChequeDetDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtChequeDetId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtChequeActual As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtChequeFin As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtChequeIni As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeDetEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtChequeDetNro = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.lblNro = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtChequeDetDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtChequeIni = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtChequeFin = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.txtChequeActual = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboBanco = New Janus.Windows.EditControls.UIComboBox
      Me.txtBancoCta = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label14 = New System.Windows.Forms.Label
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.txtChequeDetId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Design = New Janus.Windows.UI.CommandBars.UICommand("Design")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
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
      Me.bcgMain.Size = New System.Drawing.Size(459, 309)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.txtChequeDetNro)
      Me.UiGroupBox1.Controls.Add(Me.lblNro)
      Me.UiGroupBox1.Controls.Add(Me.Label12)
      Me.UiGroupBox1.Controls.Add(Me.Label10)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.txtChequeDetDes)
      Me.UiGroupBox1.Controls.Add(Me.dtpFecha)
      Me.UiGroupBox1.Controls.Add(Me.txtChequeIni)
      Me.UiGroupBox1.Controls.Add(Me.Label1)
      Me.UiGroupBox1.Controls.Add(Me.txtChequeFin)
      Me.UiGroupBox1.Controls.Add(Me.cboEstado)
      Me.UiGroupBox1.Controls.Add(Me.txtChequeActual)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 112)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 192)
      Me.UiGroupBox1.TabIndex = 5
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtChequeDetNro
      '
      Me.txtChequeDetNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeDetNro.FormatString = "##################"
      Me.txtChequeDetNro.Location = New System.Drawing.Point(116, 16)
      Me.txtChequeDetNro.Name = "txtChequeDetNro"
      Me.txtChequeDetNro.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeDetNro.TabIndex = 6
      Me.txtChequeDetNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeDetNro.Value = CType(0, Long)
      Me.txtChequeDetNro.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtChequeDetNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblNro
      '
      Me.lblNro.BackColor = System.Drawing.Color.Transparent
      Me.lblNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblNro.Location = New System.Drawing.Point(8, 20)
      Me.lblNro.Name = "lblNro"
      Me.lblNro.Size = New System.Drawing.Size(104, 16)
      Me.lblNro.TabIndex = 227
      Me.lblNro.Text = "Nro"
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 68)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 186
      Me.Label12.Text = "Cheque Inicial"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 140)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 188
      Me.Label10.Text = "Descripción"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 92)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 190
      Me.Label7.Text = "Cheque Final"
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 116)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 191
      Me.Label6.Text = "Cheque Actual"
      '
      'txtChequeDetDes
      '
      Me.txtChequeDetDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeDetDes.Location = New System.Drawing.Point(116, 136)
      Me.txtChequeDetDes.Name = "txtChequeDetDes"
      Me.txtChequeDetDes.Size = New System.Drawing.Size(320, 20)
      Me.txtChequeDetDes.TabIndex = 11
      Me.txtChequeDetDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeDetDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.dtpFecha.Location = New System.Drawing.Point(116, 40)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(124, 20)
      Me.dtpFecha.TabIndex = 7
      Me.dtpFecha.Value = New Date(2015, 12, 3, 0, 0, 0, 0)
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtChequeIni
      '
      Me.txtChequeIni.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeIni.FormatString = "##################"
      Me.txtChequeIni.Location = New System.Drawing.Point(116, 64)
      Me.txtChequeIni.Name = "txtChequeIni"
      Me.txtChequeIni.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeIni.TabIndex = 8
      Me.txtChequeIni.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeIni.Value = CType(0, Long)
      Me.txtChequeIni.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtChequeIni.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 221
      Me.Label1.Text = "Fecha"
      '
      'txtChequeFin
      '
      Me.txtChequeFin.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeFin.FormatString = "##################"
      Me.txtChequeFin.Location = New System.Drawing.Point(116, 88)
      Me.txtChequeFin.Name = "txtChequeFin"
      Me.txtChequeFin.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeFin.TabIndex = 9
      Me.txtChequeFin.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeFin.Value = CType(0, Long)
      Me.txtChequeFin.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtChequeFin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(116, 160)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(320, 20)
      Me.cboEstado.TabIndex = 12
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtChequeActual
      '
      Me.txtChequeActual.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeActual.FormatString = "##################"
      Me.txtChequeActual.Location = New System.Drawing.Point(116, 112)
      Me.txtChequeActual.Name = "txtChequeActual"
      Me.txtChequeActual.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeActual.TabIndex = 10
      Me.txtChequeActual.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeActual.Value = CType(0, Long)
      Me.txtChequeActual.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtChequeActual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 164)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 219
      Me.Label4.Text = "Estado"
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboBanco)
      Me.grpMain.Controls.Add(Me.txtBancoCta)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.Label14)
      Me.grpMain.Controls.Add(Me.cboPlan)
      Me.grpMain.Controls.Add(Me.txtChequeDetId)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 112)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboBanco
      '
      Me.cboBanco.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboBanco.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboBanco.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboBanco.Location = New System.Drawing.Point(116, 64)
      Me.cboBanco.Name = "cboBanco"
      Me.cboBanco.ReadOnly = True
      Me.cboBanco.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboBanco.Size = New System.Drawing.Size(320, 20)
      Me.cboBanco.TabIndex = 3
      Me.cboBanco.TabStop = False
      Me.cboBanco.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtBancoCta
      '
      Me.txtBancoCta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtBancoCta.Location = New System.Drawing.Point(116, 88)
      Me.txtBancoCta.MaxLength = 50
      Me.txtBancoCta.Name = "txtBancoCta"
      Me.txtBancoCta.ReadOnly = True
      Me.txtBancoCta.Size = New System.Drawing.Size(124, 20)
      Me.txtBancoCta.TabIndex = 4
      Me.txtBancoCta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtBancoCta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 68)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 225
      Me.Label9.Text = "Banco"
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(8, 92)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(104, 16)
      Me.Label14.TabIndex = 224
      Me.Label14.Text = "Cuenta Banco"
      '
      'cboPlan
      '
      cboPlan_DesignTimeLayout.LayoutString = resources.GetString("cboPlan_DesignTimeLayout.LayoutString")
      Me.cboPlan.DesignTimeLayout = cboPlan_DesignTimeLayout
      Me.cboPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlan.Location = New System.Drawing.Point(116, 40)
      Me.cboPlan.Name = "cboPlan"
      Me.cboPlan.ReadOnly = True
      Me.cboPlan.SelectedIndex = -1
      Me.cboPlan.SelectedItem = Nothing
      Me.cboPlan.Size = New System.Drawing.Size(320, 20)
      Me.cboPlan.TabIndex = 2
      Me.cboPlan.TabStop = False
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtChequeDetId
      '
      Me.txtChequeDetId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeDetId.Location = New System.Drawing.Point(116, 16)
      Me.txtChequeDetId.Name = "txtChequeDetId"
      Me.txtChequeDetId.ReadOnly = True
      Me.txtChequeDetId.Size = New System.Drawing.Size(124, 20)
      Me.txtChequeDetId.TabIndex = 1
      Me.txtChequeDetId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtChequeDetId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 44)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(104, 16)
      Me.Label11.TabIndex = 187
      Me.Label11.Text = "Cuenta"
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator2, Me.Exit1})
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
      Me.TopRebar1.Size = New System.Drawing.Size(459, 28)
      '
      'frmChequeDetEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(459, 337)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmChequeDetEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ChequeDet Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
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
               mlngID = moChequeDet.ChequeDetId
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

   Private Sub frmChequeDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmChequeDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      With moChequeDet
         txtChequeDetId.Text = ToStr(.ChequeDetId)
         Call txtChequeIdLoad(.ChequeId)
         txtChequeDetNro.Text = ToStr(.ChequeDetNro)
         dtpFecha.Value = ToStr(.Fecha)
         ''cboPlan.Value = ListFindItem(cboPlan, .PlanId)
         ''cboBanco.SelectedIndex = ListFindItem(cboBanco, .BancoId)
         ''txtBancoCta.Text = ToStr(.BancoCta)
         txtChequeIni.Text = ToStr(.ChequeIni)
         txtChequeFin.Text = ToStr(.ChequeFin)
         txtChequeActual.Text = ToStr(.ChequeActual)
         txtChequeDetDes.Text = ToStr(.ChequeDetDes)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Chequera"
               .VMOld.ToShowOpe()
            End If
         End If
      End With
      mboolShow = False

      dtpFecha.Select()
   End Sub

   Private Sub CloneVM(ByRef oVM As clsChequeDetVM)
      oVM = New clsChequeDetVM

      With oVM
         .ChequeDetId = moChequeDet.ChequeDetId
         .EmpresaId = moChequeDet.EmpresaId
         .ChequeId = moChequeDet.ChequeId
         .PlanId = moChequeDet.PlanId
         .PlanDes = cboPlan.Text
         .BancoId = moChequeDet.BancoId
         .BancoCta = txtBancoCta.Text
         .BancoDes = cboBanco.Text
         .ChequeDetNro = txtChequeDetNro.Text
         .Fecha = dtpFecha.Text
         .ChequeIni = moChequeDet.ChequeIni
         .ChequeFin = moChequeDet.ChequeFin
         .ChequeActual = moChequeDet.ChequeActual
         .ChequeDetDes = moChequeDet.ChequeDetDes
         .EstadoId = moChequeDet.EstadoId
         .EstadoDes = ToStr(cboEstado.Text)

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moChequeDet
         txtChequeDetId.Text = String.Empty
         Call txtChequeIdLoad(.ChequeId) ''Modificacion en Cotablidad 16-07-16
         dtpFecha.Value = Now
         txtChequeIni.Text = String.Empty
         txtChequeFin.Text = String.Empty
         txtChequeActual.Text = "0"
         txtChequeDetDes.Text = String.Empty
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtChequeDetId.ReadOnly = True
      txtChequeDetNro.ReadOnly = True
      dtpFecha.ReadOnly = True
      cboPlan.ReadOnly = True
      cboBanco.ReadOnly = True
      txtBancoCta.ReadOnly = True
      txtChequeIni.ReadOnly = True
      txtChequeFin.ReadOnly = True
      txtChequeActual.ReadOnly = True
      txtChequeDetDes.ReadOnly = True
      cboEstado.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moChequeDet
         If Not mboolAdding Then
            .ChequeDetId = ToLong(txtChequeDetId.Text)
         End If

         .ChequeDetNro = ToLong(txtChequeDetNro.Text)
         .Fecha = ToDate(dtpFecha.Value)
         ''.PlanId = ListPosition(cboPlan)
         ''.BancoId = ListPosition(cboBanco, cboBanco.SelectedIndex)
         .ChequeIni = ToLong(txtChequeIni.Text)
         .ChequeFin = ToLong(txtChequeFin.Text)
         .ChequeActual = ToLong(txtChequeActual.Text)
         .chequeDetDes = ToStr(txtChequeDetDes.Text)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

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

         If moChequeDet.Insert() Then
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

         If moChequeDet.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If (moChequeDet.ChequeActual + 1) < moChequeDet.ChequeIni Then
         strMsg &= "El Número Actual es Inferior al Número Inicial" & vbCrLf

      ElseIf moChequeDet.ChequeActual > moChequeDet.ChequeFin Then
         strMsg &= "El Número Actual es Superior al Número Final" & vbCrLf
      End If

      If cboPlan.SelectedIndex > -1 Then
         If ToLong(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("EstadoId").Value) = 0 Then
            strMsg &= "La Cuenta seleccionada " & ToStr(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("PlanCta").Value) & "-" & ToStr(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("PlanDes").Value) & " esta Inactiva." & vbCrLf
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub frmChequeImpEditLoad()
      Try
         ''With moChequeDet
         ''   Dim frm As New frmChequeImp

         ''   frm.DataObjectCheque = moChequeDet
         ''   frm.ShowDialog()

         ''   If frm.Changed Then
         ''      .OrientacionId = frm.DataObjectCheque.OrientacionId
         ''      .ChequeWidth = frm.DataObjectCheque.ChequeWidth
         ''      .ChequeHeight = frm.DataObjectCheque.ChequeHeight
         ''   End If

         ''   frm.Dispose()
         ''End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

   End Sub

   Private Sub ComboLoad()
      Call cboPlanLoad()
      Call cboBancoLoad()
      Call cboEstadoLoad()
   End Sub

   Private Sub txtChequeIdLoad(ByVal lngChequeId As Long)
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      Try
         With oCheque
            .ChequeId = lngChequeId

            If .FindByPK Then
               cboPlan.Value = ListFindItem(cboPlan, .PlanId)
               cboBanco.SelectedIndex = ListFindItem(cboBanco, .BancoId)
               txtBancoCta.Text = ToStr(.BancoCta)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCheque.Dispose()

      End Try
   End Sub

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.TipoPlanId
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moChequeDet.EmpresaId
            .TipoPlanId = 3
            .EstadoId = clsEstado.ACTIVO
            .PlanId = moChequeDet.PlanId

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
            .OrderByFilter = clsBanco.OrderByFilters.BancoDes

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

   Private Sub cboEstadoLoad()
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboEstado.Items.Clear()

      Try
         With oEstado
            .SelectFilter = clsEstado.SelectFilters.ListBox
            .OrderByFilter = clsEstado.OrderByFilters.EstadoDes

            If .Open() Then
               Do While .Read()
                  If (.EstadoId = 10) Or (.EstadoId = 11) Then
                     oItem = New clsListItem(.EstadoId, .EstadoDes)
                     cboEstado.Items.Add(oItem)
                  End If

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

   Private Sub frmChequeDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moChequeDet.ChequeId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmChequeDetEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moChequeDet.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub txtChequeDetNro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChequeDetNro.Click

   End Sub
End Class
