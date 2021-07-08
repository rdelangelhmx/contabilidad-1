Public Class frmCompDetEdit
   Inherits System.Windows.Forms.Form

   Private moCompDet As clsCompDet
   Private moTipoRetencion As clsTipoRetencion

   Private mdecTipoCambio As Decimal
   Private mdecUfv As Decimal
   Private mdecIva As Decimal
   Private mdecIT As Decimal

   Private mstrEntregadoA As String
   Private mlnMonedaId As Long
   Private mlngPlanIdOld As Long
   Private mlngCol As Long
   Private mdecCompDetMonto As Decimal
   Private mlngTipoAsientoId As Long
   Private mlngColDescuento As Long
   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolNuevoComprobante As Boolean
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

   Public Property NuevoComprobante() As Boolean
      Get
         Return mboolNuevoComprobante
      End Get
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

   Property TipoAsientoId() As Long
      Get
         Return mlngTipoAsientoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoAsientoId = Value
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

   Property EntregadoA() As String
      Get
         Return mstrEntregadoA
      End Get

      Set(ByVal Value As String)
         mstrEntregadoA = Value
      End Set
   End Property

   Property ColDescuento() As Long
      Get
         Return mlngColDescuento
      End Get
      Set(ByVal value As Long)
         mlngColDescuento = value
      End Set
   End Property

   Property IVA() As Decimal
      Get
         Return mdecIva
      End Get

      Set(ByVal Value As Decimal)
         mdecIva = Value
      End Set
   End Property

   Property IT() As Decimal
      Get
         Return mdecIT
      End Get

      Set(ByVal Value As Decimal)
         mdecIT = Value
      End Set
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
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents txtCompDetId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtCompDetDes As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtDebe As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtEqui As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtHaber As Janus.Windows.GridEX.EditControls.NumericEditBox
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
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtEquiUfv As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboCentroCosto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents chkCentroCosto As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkPlan As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents LibroMayor As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents LibroMayor1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents lblTipoRetencion As System.Windows.Forms.Label
   Friend WithEvents cboTipoRetencion As Janus.Windows.EditControls.UIComboBox

   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboCentroCosto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompDetEdit))
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.txtEqui = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtEquiUfv = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.lblTipoRetencion = New System.Windows.Forms.Label
      Me.cboCentroCosto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboTipoRetencion = New Janus.Windows.EditControls.UIComboBox
      Me.chkCentroCosto = New Janus.Windows.EditControls.UICheckBox
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.chkPlan = New Janus.Windows.EditControls.UICheckBox
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.txtHaber = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtDebe = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtCompDetDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtCompDetId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label17 = New System.Windows.Forms.Label
      Me.Label18 = New System.Windows.Forms.Label
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
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
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
      Me.bcgMain.Controls.Add(Me.UiGroupBox2)
      Me.bcgMain.Controls.Add(Me.UiGroupBox1)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 287)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.txtEqui)
      Me.UiGroupBox2.Controls.Add(Me.Label1)
      Me.UiGroupBox2.Controls.Add(Me.txtEquiUfv)
      Me.UiGroupBox2.Controls.Add(Me.Label12)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 120)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(444, 44)
      Me.UiGroupBox2.TabIndex = 8
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtEqui
      '
      Me.txtEqui.BackColor = System.Drawing.SystemColors.Info
      Me.txtEqui.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEqui.FormatString = "##,##0.000"
      Me.txtEqui.Location = New System.Drawing.Point(116, 16)
      Me.txtEqui.Name = "txtEqui"
      Me.txtEqui.ReadOnly = True
      Me.txtEqui.Size = New System.Drawing.Size(124, 20)
      Me.txtEqui.TabIndex = 9
      Me.txtEqui.TabStop = False
      Me.txtEqui.Text = "0,000"
      Me.txtEqui.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtEqui.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtEqui.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(244, 20)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(64, 16)
      Me.Label1.TabIndex = 207
      Me.Label1.Text = "Equi. UFV"
      '
      'txtEquiUfv
      '
      Me.txtEquiUfv.BackColor = System.Drawing.SystemColors.Info
      Me.txtEquiUfv.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEquiUfv.FormatString = "##,##0.000"
      Me.txtEquiUfv.Location = New System.Drawing.Point(312, 16)
      Me.txtEquiUfv.Name = "txtEquiUfv"
      Me.txtEquiUfv.ReadOnly = True
      Me.txtEquiUfv.Size = New System.Drawing.Size(124, 20)
      Me.txtEquiUfv.TabIndex = 10
      Me.txtEquiUfv.TabStop = False
      Me.txtEquiUfv.Text = "0,000"
      Me.txtEquiUfv.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtEquiUfv.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtEquiUfv.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 20)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 204
      Me.Label12.Text = "Equival."
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.lblTipoRetencion)
      Me.UiGroupBox1.Controls.Add(Me.cboCentroCosto)
      Me.UiGroupBox1.Controls.Add(Me.cboTipoRetencion)
      Me.UiGroupBox1.Controls.Add(Me.chkCentroCosto)
      Me.UiGroupBox1.Controls.Add(Me.cboEstado)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.Label13)
      Me.UiGroupBox1.Controls.Add(Me.cboSucursal)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 164)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 116)
      Me.UiGroupBox1.TabIndex = 12
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'lblTipoRetencion
      '
      Me.lblTipoRetencion.BackColor = System.Drawing.Color.Transparent
      Me.lblTipoRetencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTipoRetencion.Location = New System.Drawing.Point(8, 68)
      Me.lblTipoRetencion.Name = "lblTipoRetencion"
      Me.lblTipoRetencion.Size = New System.Drawing.Size(104, 16)
      Me.lblTipoRetencion.TabIndex = 209
      Me.lblTipoRetencion.Text = "Retención Por"
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
      'cboTipoRetencion
      '
      Me.cboTipoRetencion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoRetencion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoRetencion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoRetencion.Location = New System.Drawing.Point(116, 64)
      Me.cboTipoRetencion.Name = "cboTipoRetencion"
      Me.cboTipoRetencion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoRetencion.Size = New System.Drawing.Size(320, 20)
      Me.cboTipoRetencion.TabIndex = 16
      Me.cboTipoRetencion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      Me.cboEstado.Location = New System.Drawing.Point(116, 88)
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
      Me.Label13.Location = New System.Drawing.Point(8, 92)
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
      Me.grpMain.Controls.Add(Me.txtHaber)
      Me.grpMain.Controls.Add(Me.txtDebe)
      Me.grpMain.Controls.Add(Me.txtCompDetDes)
      Me.grpMain.Controls.Add(Me.txtCompDetId)
      Me.grpMain.Controls.Add(Me.Label14)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.Label19)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 120)
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
      'txtHaber
      '
      Me.txtHaber.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtHaber.FormatString = "##,##0.000"
      Me.txtHaber.Location = New System.Drawing.Point(312, 92)
      Me.txtHaber.Name = "txtHaber"
      Me.txtHaber.Size = New System.Drawing.Size(124, 20)
      Me.txtHaber.TabIndex = 7
      Me.txtHaber.Text = "0,000"
      Me.txtHaber.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtHaber.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtHaber.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtDebe
      '
      Me.txtDebe.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDebe.FormatString = "##,##0.000"
      Me.txtDebe.Location = New System.Drawing.Point(116, 92)
      Me.txtDebe.Name = "txtDebe"
      Me.txtDebe.Size = New System.Drawing.Size(124, 20)
      Me.txtDebe.TabIndex = 6
      Me.txtDebe.Text = "0,000"
      Me.txtDebe.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtDebe.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtDebe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCompDetDes
      '
      Me.txtCompDetDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompDetDes.Location = New System.Drawing.Point(116, 64)
      Me.txtCompDetDes.MaxLength = 255
      Me.txtCompDetDes.Multiline = True
      Me.txtCompDetDes.Name = "txtCompDetDes"
      Me.txtCompDetDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtCompDetDes.Size = New System.Drawing.Size(320, 20)
      Me.txtCompDetDes.TabIndex = 5
      Me.txtCompDetDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompDetDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(268, 96)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(40, 16)
      Me.Label14.TabIndex = 203
      Me.Label14.Text = "Haber"
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 96)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 202
      Me.Label15.Text = "Debe"
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
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 68)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 199
      Me.Label18.Text = "Glosa"
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(250, 28)
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
      'frmCompDetEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 315)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompDetEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompDet Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
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

               ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
               If clsAppInfo.ExigirEEFF Then
                  If EsCuentaDisponible(moCompDet.PlanId) Then
                     Call CompPlanAddParametro(moCompDet.DebeOrg, moCompDet.HaberOrg)

                     '26-06-2020
                     'If mlngTipoAsientoId = clsTipoAsiento.OPERATIVO Then 'Operativo
                     Call CompPlanEEFFMoveCol(moCompDet.CompDetId)

                     If CompPlanEEFFSaldo2(moCompDet.CompId, moCompDet.CompDetId) > 0 Then

                        If MessageBox.Show("La Cuenta es de Tipo Disponible, Debe agregar las Cuentas de Flujo de Efectivo. Desea Ingresarlos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                           Call frmCompPlanEEFFEditLoad()
                        End If
                     End If
                     'End If
                  End If
               End If
               ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
               If TieneAnaAdd(moCompDet.PlanId) Then
                  Call CompPlanAddParametro(moCompDet.DebeOrg, moCompDet.HaberOrg)

                  If mlngTipoAsientoId = clsTipoAsiento.OPERATIVO Then 'Operativo
                     Call CompPlanAddMoveCol(moCompDet.CompDetId)
                  End If

                  If CompPlanAddSaldo(moCompDet.CompId, moCompDet.CompDetId) > 0 Then
                     If MessageBox.Show("La Cuenta Tiene Analíticos Adicionales, ¿Desea Ingresarlos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Call frmCompPlanAddEditLoad()
                     End If
                  End If
               End If

               If TieneCentroCostoDet(moCompDet.CentroCostoId) Then
                  Call CompPlanAddParametro(moCompDet.DebeOrg, moCompDet.HaberOrg)

                  If mlngTipoAsientoId = clsTipoAsiento.OPERATIVO Then 'Operativo
                     Call CompCentroCostoDetMoveCol(moCompDet.CompDetId)
                  End If

                  If CompCentroCostoDetSaldo(moCompDet.CompId, moCompDet.CompDetId, moCompDet.CentroCostoId) > 0 Then
                     If MessageBox.Show("El Centro de Costo Tiene Actividades, ¿Desea Ingresarlos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Call frmCompCentroCostoDetEditLoad()
                     End If
                  End If
               End If

               If TieneChequera(moCompDet.PlanId) Then
                  If ToDecimal(moCompDet.HaberOrg) <> 0 Then
                     If TieneChequeraCreada(moCompDet.PlanId) Then
                        Call frmCompChequeEditLoad(moCompDet.CompDetId)
                     Else
                        MessageBox.Show("Debe Definir la Chequera para Esta Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  End If
               End If

               Me.Close()
            End If

         Case "LibroMayor"
            Call frmLibroMayorLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Asiento"
         Else
            Me.Text = "Editar Asiento"
            mlngPlanIdOld = moCompDet.PlanId
         End If
      Else
         Me.Text = "Nuevo Asiento"
         Call FormNew()
      End If

      If moCompDet.TipoCompId = 1 Then
         cboTipoRetencion.Enabled = False
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      mlnMonedaId = moCompDet.MonedaId
      mdecUfv = UfvFind(moCompDet.Fecha)

      txtEqui.FormatString = DecimalMask()
      txtDebe.FormatString = DecimalMask()
      txtHaber.FormatString = DecimalMask()

      moTipoRetencion = New clsTipoRetencion(clsAppInfo.ConnectString)
      'Call moTipoRetencionLoad()

      If moCompDet.TipoId = clsCompDet.DESCUENTO Then
         cboTipoRetencion.Enabled = False
         If mlngColDescuento = 1 Then
            txtHaber.Enabled = False

            If mboolEditing Then
               If moCompDet.HaberOrg <> 0 Then
                  moCompDet.DebeOrg = moCompDet.HaberOrg
                  moCompDet.HaberOrg = 0
               End If
            End If
         ElseIf mlngColDescuento = 2 Then
            txtDebe.Enabled = False
            If mboolEditing Then
               If mboolEditing Then
                  If moCompDet.DebeOrg <> 0 Then
                     moCompDet.HaberOrg = moCompDet.DebeOrg
                     moCompDet.DebeOrg = 0
                  End If
               End If
            End If
         End If
      End If
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
            If moCompDet.TipoId = clsCompDet.DESCUENTO Then
               .WhereFilter = clsPlan.WhereFilters.EsAnaTipoPlanId
               .TipoPlanId = 0
            Else
               .WhereFilter = clsPlan.WhereFilters.EsAna
            End If
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moCompDet.EmpresaId
            .EsAna = 1
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

   Private Sub cboTipoRetencionLoad(ByVal lngAsume As Long)
      Dim oItem As clsListItem

      cboTipoRetencion.Items.Clear()
      cboTipoRetencion.Text = ""

      Try
         With moTipoRetencion
            .SelectFilter = clsTipoRetencion.SelectFilters.ListBox
            .OrderByFilter = clsTipoRetencion.OrderByFilters.TipoRetencionId

            If .Open() Then
               If lngAsume = 1 Then 'Empresa
                  Do While .Read()
                     If (.TipoRetencionId = 1) Or (.TipoRetencionId = 2) Or (.TipoRetencionId = 3) Then
                        oItem = New clsListItem(.TipoRetencionId, .TipoRetencionDes)

                        cboTipoRetencion.Items.Add(oItem)
                     End If

                     .MoveNext()
                  Loop

               ElseIf lngAsume = 2 Then 'Proveedor
                  Do While .Read()
                     If (.TipoRetencionId = 4) Or (.TipoRetencionId = 5) Or (.TipoRetencionId = 6) Then
                        oItem = New clsListItem(.TipoRetencionId, .TipoRetencionDes)

                        cboTipoRetencion.Items.Add(oItem)
                     End If

                     .MoveNext()
                  Loop
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem = Nothing

      End Try
   End Sub
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
         txtCompDetDes.Text = ToStr(.CompDetDes)

         If .MonedaId = 1 Then
            txtDebe.Text = ToDecStr(.DebeOrg)
            txtHaber.Text = ToDecStr(.HaberOrg)

            txtDebe.Tag = txtDebe.Text
            txtHaber.Tag = txtHaber.Text

            If .DebeOrg <> 0 Then
               txtEqui.Text = ToDecStr(ToDecimal(.DebeOrg / mdecTipoCambio))
               If mdecUfv > 0 Then
                  txtEquiUfv.Text = ToDecStr(ToDecimal(.DebeOrg / mdecUfv))
               End If

            ElseIf .HaberOrg <> 0 Then
               txtEqui.Text = ToDecStr(ToDecimal(.HaberOrg / mdecTipoCambio))
               If mdecUfv > 0 Then
                  txtEquiUfv.Text = ToDecStr(ToDecimal(.HaberOrg / mdecUfv))
               End If
            End If

         ElseIf .MonedaId = 2 Then
            txtDebe.Text = ToDecStr(.DebeOrg)
            txtHaber.Text = ToDecStr(.HaberOrg)

            If .DebeOrg <> 0 Then
               txtEqui.Text = ToDecStr(ToDecimal(.DebeOrg * mdecTipoCambio))
               If mdecUfv > 0 Then
                  txtEquiUfv.Text = ToDecStr(ToDecimal((.DebeOrg * mdecTipoCambio) / mdecUfv))
               End If

            ElseIf .HaberOrg <> 0 Then
               txtEqui.Text = ToDecStr(ToDecimal(.HaberOrg * mdecTipoCambio))
               If mdecUfv > 0 Then
                  txtEquiUfv.Text = ToDecStr(ToDecimal((.HaberOrg * mdecTipoCambio) / mdecUfv))
               End If
            End If
         End If

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

         If ToDecimal(txtDebe.Text) > 0 Then
            If moCompDet.TipoCompId > 1 Then
               If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 5) Or (lngTipoGrupoId = 6) Then
                  Call cboTipoRetencionLoad(1)
               End If
            End If

         ElseIf ToDecimal(txtHaber.Text) > 0 Then
            If moCompDet.TipoCompId > 1 Then
               If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 2) Then
                  Call cboTipoRetencionLoad(2)
               End If
            End If
         End If

         cboTipoRetencion.SelectedIndex = ListFindItem(cboTipoRetencion, .TipoRetencionId)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)
         cboEstado.Enabled = False

         cboPlan.Select()

         If clsAppInfo.RegistrarBitacora And Not mboolNuevoComprobante Then

            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Asiento"
               .VMOld.ToShowOpe(clsTipoOpera.CONSULTA)
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Public Function CompNroFind(ByVal lngCompId As Long)
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      oComp.CompId = lngCompId
      oComp.FindByPK()
      Return oComp.CompNro
   End Function

   Public Function TipoCompDesFind(ByVal lngTipoCompId As Long)
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      oTipoComp.TipoCompId = lngTipoCompId
      oTipoComp.FindByPK()
      Return oTipoComp.TipoCompDes
   End Function

   Private Sub CloneVM(ByRef oVM As clsCompDetVM)
      oVM = New clsCompDetVM

      With oVM
         .CompDetId = moCompDet.CompDetId
         .CompId = moCompDet.CompId
         .CompNro = CompNroFind(moCompDet.CompId)
         .TipoCompId = moCompDet.TipoCompId
         .TipoCompDes = TipoCompDesFind(moCompDet.TipoCompId)
         .PlanId = moCompDet.PlanId
         .PlanDes = cboPlan.Text
         .CompDetDes = moCompDet.CompDetDes
         .DebeOrg = moCompDet.DebeOrg
         .HaberOrg = moCompDet.HaberOrg
         .DebeBs = moCompDet.DebeBs
         .HaberBs = moCompDet.HaberBs
         .DebeUs = moCompDet.DebeUs
         .HaberUs = moCompDet.HaberUs
         .SucursalId = moCompDet.SucursalId
         .SucursalDes = cboSucursal.Text
         .CentroCostoId = moCompDet.CentroCostoId
         .CentroCostoDes = cboCentroCosto.Text
         .TipoRetencionId = moCompDet.TipoRetencionId
         .TipoRetencionDes = cboTipoRetencion.Text
         .Orden = moCompDet.Orden

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCompDet
         txtCompDetId.Text = String.Empty
         cboPlan.Value = Nothing
         txtCompDetDes.Text = .CompDetDes
         txtDebe.Text = "0.0"
         txtHaber.Text = "0.0"
         txtEqui.Text = "0.0"
         cboSucursal.SelectedIndex = -1
         cboSucursal.Text = ""
         cboCentroCosto.Value = Nothing
         cboTipoRetencion.SelectedIndex = -1
         cboTipoRetencion.Text = ""
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         cboSucursal.Enabled = False
         cboCentroCosto.Enabled = False
         cboEstado.Enabled = False
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCompDetId.ReadOnly = True
      cboPlan.ReadOnly = True
      txtCompDetDes.ReadOnly = True
      txtDebe.ReadOnly = True
      txtHaber.ReadOnly = True
      txtEqui.ReadOnly = True
      cboSucursal.Enabled = False
      cboCentroCosto.Enabled = False
      cboTipoRetencion.Enabled = False
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
         .CompDetDes = ToStr(txtCompDetDes.Text)
         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
         .CentroCostoId = ListPosition(cboCentroCosto)
         .DebeOrg = ToDecimal(txtDebe.Text)
         .HaberOrg = ToDecimal(txtHaber.Text)

         If .MonedaId = 1 Then
            If ToDecimal(txtDebe.Text) <> 0 Then
               .DebeBs = ToDecimal(txtDebe.Text)
               .HaberBs = 0
               .DebeUs = ToDecimal(txtEqui.Text)
               .HaberUs = 0

            ElseIf ToDecimal(txtHaber.Text) <> 0 Then
               .DebeBs = 0
               .HaberBs = ToDecimal(txtHaber.Text)
               .DebeUs = 0
               .HaberUs = ToDecimal(txtEqui.Text)
            End If

         ElseIf .MonedaId = 2 Then
            If ToDecimal(txtDebe.Text) <> 0 Then
               .DebeBs = ToDecimal(txtEqui.Text)
               .HaberBs = 0
               .DebeUs = ToDecimal(txtDebe.Text)
               .HaberUs = 0

            ElseIf ToDecimal(txtHaber.Text) <> 0 Then
               .DebeBs = 0
               .HaberBs = ToDecimal(txtEqui.Text)
               .DebeUs = 0
               .HaberUs = ToDecimal(txtHaber.Text)
            End If
         End If

         If mboolAdding Then
            .Orden = MaxOrden()
         End If

         .Automatico = 0
         .TipoRetencionId = ListPosition(cboTipoRetencion, cboTipoRetencion.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

         If clsAppInfo.RegistrarBitacora And Not mboolNuevoComprobante Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

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

      If cboTipoRetencion.Enabled Then
         If ListPosition(cboTipoRetencion, cboTipoRetencion.SelectedIndex) > 0 Then
            If mboolAdding Then
               If TieneFactura(0) Then
                  strMsg &= "El Comprobante ya Tiene Una Factura Global" & vbCrLf
               End If

            ElseIf mboolEditing Then
               If TieneFactura(moCompDet.CompDetId) Then
                  strMsg &= "La Cuenta ya Tiene Una o Mas Facturas Individuales" & vbCrLf

               ElseIf TieneFactura(0) Then
                  strMsg &= "El Comprobante ya Tiene Una Factura Global" & vbCrLf
               End If
            End If

            If TieneRetencionDiferente() Then
               strMsg &= "Ya Existe un Tipo Diferente de Rentención (Asume Empresa / Asume Proveedor)" & vbCrLf
            End If
         End If
      End If

      If cboPlan.SelectedIndex > -1 Then
         If ToLong(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("EstadoId").Value) = 0 Then
            strMsg &= "La Cuenta seleccionada " & ToStr(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("PlanDes").Value) & " esta Inactiva." & vbCrLf
         End If
      End If

      If mboolEditing And mlngPlanIdOld <> moCompDet.PlanId Then
         If TieneFactura(moCompDet.CompDetId) Then
            strMsg &= "Imposible cambiar la Cuenta, Debido a Que Tiene Factura(s)" & vbCrLf
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

         If moCompDet.Insert() Then
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

         If moCompDet.Update() Then
            If mlngPlanIdOld <> moCompDet.PlanId Then
               Call DeleteFactura(moCompDet.CompDetId)
               Call DeleteFacturaAgru(moCompDet.CompDetId)
               Call DeleteCompCheque(moCompDet.CompDetId)
               Call DeleteCompPlanAdd(moCompDet.CompDetId)
               Call DeleteCompCentroCostoDet(moCompDet.CompDetId)
               Call DeleteCompPlanEEFF(moCompDet.CompDetId)
            End If

            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

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

            Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, frm.Text & "; Cuenta: " & cboPlan.Text)

            frm.ShowDialog()
            frm.Dispose()


         End With
      Else
         MessageBox.Show("Cuenta Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub frmCompDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               cboPlan.Select()

               If DataSave() Then
                  mlngID = moCompDet.CompDetId
                  mboolChanged = True


                  ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                  If clsAppInfo.ExigirEEFF Then
                     If EsCuentaDisponible(moCompDet.PlanId) Then
                        Call CompPlanAddParametro(moCompDet.DebeOrg, moCompDet.HaberOrg)

                        If mlngTipoAsientoId = clsTipoAsiento.OPERATIVO Then 'Operativo
                           Call CompPlanEEFFMoveCol(moCompDet.CompDetId)

                           If CompPlanEEFFSaldo2(moCompDet.CompId, moCompDet.CompDetId) > 0 Then
                              If MessageBox.Show("La Cuenta es de Tipo Disponible, Debe agregar las Cuentas de Flujo de Efectivo. Desea Ingresarlos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                 Call frmCompPlanEEFFEditLoad()
                              End If
                           End If
                        End If
                     End If
                  End If
                  ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                  If TieneAnaAdd(moCompDet.PlanId) Then
                     Call CompPlanAddParametro(moCompDet.DebeOrg, moCompDet.HaberOrg)
                     If mlngTipoAsientoId = clsTipoAsiento.OPERATIVO Then 'Operativo
                        Call CompPlanAddMoveCol(moCompDet.CompDetId)
                     End If
                     If CompPlanAddSaldo(moCompDet.CompId, moCompDet.CompDetId) > 0 Then
                        If MessageBox.Show("La Cuenta Tiene Analíticos Adicionales, ¿Desea Ingresarlos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                           Call frmCompPlanAddEditLoad()
                        End If
                     End If
                  End If

                  If moCompDet.CentroCostoId > 0 Then
                     If TieneCentroCostoDet(moCompDet.CentroCostoId) Then
                        Call CompPlanAddParametro(moCompDet.DebeOrg, moCompDet.HaberOrg)
                        If mlngTipoAsientoId = clsTipoAsiento.OPERATIVO Then 'Operativo
                           Call CompCentroCostoDetMoveCol(moCompDet.CompDetId)
                        End If
                        If CompCentroCostoDetSaldo(moCompDet.CompId, moCompDet.CompDetId, moCompDet.CentroCostoId) > 0 Then
                           If MessageBox.Show("El Centro de Costo Tiene Actividades, ¿Desea Ingresarlos?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                              Call frmCompCentroCostoDetEditLoad()
                           End If
                        End If
                     End If
                  End If

                  If TieneChequera(moCompDet.PlanId) Then
                     If ToDecimal(moCompDet.HaberOrg) <> 0 Then
                        If TieneChequeraCreada(moCompDet.PlanId) Then
                           Call frmCompChequeEditLoad(moCompDet.CompDetId)
                        Else
                           MessageBox.Show("Debe Definir la Chequera para Esta Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                     End If
                  End If

                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompDetEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
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

   Private Sub txtEquiUfvLoad(ByVal decValue As Decimal)
      If mdecUfv > 0 Then
         If moCompDet.MonedaId = 1 Then
            txtEquiUfv.Text = ToDecimal(decValue / mdecUfv)

         ElseIf moCompDet.MonedaId = 2 Then
            txtEquiUfv.Text = ToDecimal((decValue * mdecTipoCambio) / mdecUfv)
         End If
      Else
         txtEquiUfv.Text = "0"
      End If
   End Sub

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
               frm.NuevoComprobante = mboolNuevoComprobante
               frm.DesdeComp = True

               If lngMonedaId = 1 Then
                  .ChequeMonto = ToDecimal(moCompDet.HaberBs)

               ElseIf lngMonedaId = 2 Then
                  .ChequeMonto = ToDecimal(moCompDet.HaberUs)
               End If

            Else
               frm.NewRecord = True
               frm.Editing = False
               frm.NuevoComprobante = mboolNuevoComprobante
               frm.DesdeComp = True

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

            If moCompDet.TipoRetencionId <> 0 Then
               'En caso de que exista Retencion es necesario tomar en cuenta en el cheque la retencion
               Dim decRetencion As Decimal = 0
               If moCompDet.TipoRetencionId = 4 Then 'Prestación de Servicios (Proveedor)
                  decRetencion = ToDecimal(moCompDet.HaberOrg * (mdecIT + clsAppInfo.IUEServicio))
               ElseIf moCompDet.TipoRetencionId = 5 Then 'Compra de Bienes (Proveedor)
                  decRetencion = ToDecimal(moCompDet.HaberOrg * (mdecIT + clsAppInfo.IUEBien))
               ElseIf moCompDet.TipoRetencionId = 6 Then 'Alquiler de Bienes e Inmuebles (Proveedor)
                  decRetencion = ToDecimal(moCompDet.HaberOrg * (mdecIT + mdecIva))
               End If

               If decRetencion > 0 Then
                  If lngMonedaId = 1 Then
                     If moCompDet.MonedaId <> lngMonedaId Then
                        .ChequeMonto = ToDecimal(moCompDet.HaberOrg - decRetencion) * mdecTipoCambio
                     Else
                        .ChequeMonto = ToDecimal(moCompDet.HaberOrg - decRetencion)
                     End If
                  ElseIf lngMonedaId = 2 Then
                     If moCompDet.MonedaId <> lngMonedaId Then
                        .ChequeMonto = ToDecimal(moCompDet.HaberOrg - decRetencion) / mdecTipoCambio
                     Else
                        .ChequeMonto = ToDecimal(moCompDet.HaberOrg - decRetencion)
                     End If
                  End If
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
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decCompPlanAddSaldo As Decimal

      Try
         With oCompDet
            .CompDetId = moCompDet.CompDetId

            If .FindByPK Then
               Call CompPlanAddParametro(.DebeOrg, .HaberOrg)
               decCompPlanAddSaldo = CompPlanAddSaldo(.CompId, .CompDetId)

               If decCompPlanAddSaldo = 0 Then
                  MessageBox.Show("El Monto de lo(s) Analítico(s) ya esta Balanceado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub

               ElseIf decCompPlanAddSaldo < 0 Then
                  MessageBox.Show("El Monto de lo(s) Analítico(s) no Puede Ser Mayor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub
               End If

               Do While decCompPlanAddSaldo > 0
                  With oCompPlanAdd
                     .EmpresaId = oCompDet.EmpresaId
                     .CompId = oCompDet.CompId
                     .CompDetId = oCompDet.CompDetId
                     .GestionId = oCompDet.GestionId
                     .Fecha = ConvertDMY(oCompDet.Fecha)
                     .PlanId = oCompDet.PlanId
                     .MonedaId = oCompDet.MonedaId
                     .EstadoId = 13

                     If mlngCol = 1 Then
                        .DebeOrg = decCompPlanAddSaldo

                     ElseIf mlngCol = 2 Then
                        .HaberOrg = decCompPlanAddSaldo
                     End If

                     frm.NewRecord = True
                     frm.Editing = False
                     frm.Changed = False
                     frm.NuevoComprobante = mboolNuevoComprobante
                     frm.TipoCambio = mdecTipoCambio
                     frm.CompMonedaId = moCompDet.MonedaId
                     frm.Col = mlngCol
                     frm.CompDetMonto = mdecCompDetMonto
                     frm.DataObject = oCompPlanAdd
                     frm.ShowDialog()

                     If frm.Changed Then
                        decCompPlanAddSaldo = CompPlanAddSaldo(.CompId, .CompDetId)
                     Else
                        Exit Sub
                     End If
                  End With
               Loop
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()
         oCompDet.Dispose()

      End Try
   End Sub

   Private Sub frmCompCentroCostoDetEditLoad()
      Dim frm As New frmCompCentroCostoDetEdit
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decCompCentroCostoDetSaldo As Decimal

      Try
         With oCompDet
            .CompDetId = moCompDet.CompDetId

            If .FindByPK Then
               Call CompPlanAddParametro(.DebeOrg, .HaberOrg)
               decCompCentroCostoDetSaldo = CompCentroCostoDetSaldo(.CompId, .CompDetId, .CentroCostoId)

               If decCompCentroCostoDetSaldo = 0 Then
                  MessageBox.Show("El Monto de la(s) Actividad(es) ya esta Balanceado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub

               ElseIf decCompCentroCostoDetSaldo < 0 Then
                  MessageBox.Show("El Monto de la(s) Actividad(es) no Puede Ser Mayor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub
               End If

               Do While decCompCentroCostoDetSaldo > 0
                  With oCompCentroCostoDet
                     .EmpresaId = oCompDet.EmpresaId
                     .CompId = oCompDet.CompId
                     .CompDetId = oCompDet.CompDetId
                     .GestionId = oCompDet.GestionId
                     .Fecha = ConvertDMY(oCompDet.Fecha)
                     .PlanId = oCompDet.PlanId
                     .CentroCostoId = oCompDet.CentroCostoId
                     .MonedaId = oCompDet.MonedaId
                     .EstadoId = 13

                     If mlngCol = 1 Then
                        .DebeOrg = decCompCentroCostoDetSaldo

                     ElseIf mlngCol = 2 Then
                        .HaberOrg = decCompCentroCostoDetSaldo
                     End If

                     frm.NewRecord = True
                     frm.Editing = False
                     frm.Changed = False
                     frm.NuevoComprobante = mboolNuevoComprobante
                     frm.TipoCambio = mdecTipoCambio
                     frm.CompMonedaId = moCompDet.MonedaId
                     frm.Col = mlngCol
                     frm.CompDetMonto = mdecCompDetMonto
                     frm.DataObject = oCompCentroCostoDet
                     frm.ShowDialog()

                     If frm.Changed Then
                        decCompCentroCostoDetSaldo = CompCentroCostoDetSaldo(.CompId, .CompDetId, .CentroCostoId)
                     Else
                        Exit Sub
                     End If
                  End With
               Loop
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()
         oCompDet.Dispose()

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

         If mlngTipoAsientoId = clsTipoAsiento.CIERRE Or mlngTipoAsientoId = clsTipoAsiento.APERTURA Then
            decSaldo = Math.Abs(decDebe - decHaber)
            CompPlanAddSaldo = Math.Abs(mdecCompDetMonto - decSaldo)
         Else
            If mlngCol = 1 Then 'Debe
               CompPlanAddSaldo = Math.Abs(mdecCompDetMonto - decDebe)
            Else
               CompPlanAddSaldo = Math.Abs(mdecCompDetMonto - decHaber)
            End If
         End If

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
      Dim decSaldo As Decimal = 0

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

         If mlngTipoAsientoId = clsTipoAsiento.CIERRE Or mlngTipoAsientoId = clsTipoAsiento.APERTURA Then
            decSaldo = Math.Abs(decDebe - decHaber)
            CompCentroCostoDetSaldo = Math.Abs(mdecCompDetMonto - decSaldo)
         Else
            If mlngCol = 1 Then 'Debe
               CompCentroCostoDetSaldo = Math.Abs(mdecCompDetMonto - decDebe)
            Else
               CompCentroCostoDetSaldo = Math.Abs(mdecCompDetMonto - decHaber)
            End If
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

         If ToDecimal(txtDebe.Text) > 0 Then
            If moCompDet.TipoCompId > 1 Then
               If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 5) Or (lngTipoGrupoId = 6) Then
                  Call cboTipoRetencionLoad(1)
               End If
            End If

         ElseIf ToDecimal(txtHaber.Text) > 0 Then
            If moCompDet.TipoCompId > 1 Then
               If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 2) Then
                  Call cboTipoRetencionLoad(2)
               End If
            End If

         Else
            cboTipoRetencion.Items.Clear()
            cboTipoRetencion.Text = ""
         End If
      End If
   End Sub
#End Region

#Region " Evento txtDebe "
   Private Sub txtDebe_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDebe.LostFocus
      If cboPlan.Value IsNot Nothing Then
         If txtDebe.Tag <> txtDebe.Text Then
            txtDebe.Tag = txtDebe.Text

            If ToDecimal(txtDebe.Text) > 0 Then
               If moCompDet.TipoCompId > 1 Then
                  Dim lngTipoGrupoId As Long = PlanGrupoFind(ListPosition(cboPlan)) ' ToLong(cboPlan.DropDownList.GetRow.Cells("TipoGrupoId").Value)

                  cboTipoRetencion.Items.Clear()
                  cboTipoRetencion.Text = ""

                  If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 5) Or (lngTipoGrupoId = 6) Then
                     Call cboTipoRetencionLoad(1)
                  End If
               End If
            End If
         End If
      End If
   End Sub

   Private Sub txtDebe_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDebe.Validating
      If ToDecimal(txtDebe.Text) <> 0 Then
         Call txtEquiLoad(ToDecimal(txtDebe.Text))
         Call txtEquiUfvLoad(ToDecimal(txtDebe.Text))
         txtHaber.Text = "0.0"
         txtHaber.Tag = ""
      End If
   End Sub

   Private Sub txtEquiLoad(ByVal decValue As Decimal)
      If moCompDet.MonedaId = 1 Then
         txtEqui.Text = ToDecimal(decValue / mdecTipoCambio)

      ElseIf moCompDet.MonedaId = 2 Then
         txtEqui.Text = ToDecimal(decValue * mdecTipoCambio)
      End If
   End Sub
#End Region

#Region " Evento txtHaber "
   Private Sub txtHaber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHaber.LostFocus
      If cboPlan.Value IsNot Nothing Then
         If txtHaber.Tag <> txtHaber.Text Then
            txtHaber.Tag = txtHaber.Text

            If ToDecimal(txtHaber.Text) > 0 Then
               If moCompDet.TipoCompId > 1 Then
                  Dim lngTipoGrupoId As Long = PlanGrupoFind(ListPosition(cboPlan)) ' ToLong(cboPlan.DropDownList.SelectedItems.Item("TipoGrupoId"))
                  cboTipoRetencion.Items.Clear()
                  cboTipoRetencion.Text = ""

                  If (lngTipoGrupoId = 1) Or (lngTipoGrupoId = 2) Then
                     Call cboTipoRetencionLoad(2)
                  End If
               End If
            End If
         End If
      End If
   End Sub

   Private Sub txtHaber_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHaber.Validating
      If ToDecimal(txtHaber.Text) <> 0 Then
         Call txtEquiLoad(ToDecimal(txtHaber.Text))
         Call txtEquiUfvLoad(ToDecimal(txtHaber.Text))
         txtDebe.Text = "0.0"
         txtDebe.Tag = ""
      End If
   End Sub
#End Region

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

#Region "Flujo de Efectivo"
   Private Function EsCuentaDisponible(ByVal lngPlanId As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         EsCuentaDisponible = False

         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               If .TipoPlanId = clsTipoPlan.CAJA Or .TipoPlanId = clsTipoPlan.CUENTA_CORRIENTE Then
                  EsCuentaDisponible = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Function CompPlanEEFFMoveCol(ByVal lngCompDetId As Long) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)
      Dim boolUpdate As Boolean

      CompPlanEEFFMoveCol = False

      Try
         'Call OpenConectionTransaction()
         With oCompPlanEEFF
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompDetId
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
                     If .Update() Then
                        'CompPlanEEFFMoveCol = True
                     End If
                  End If

                  .MoveNext()
               Loop

               CompPlanEEFFMoveCol = True
            End If
         End With

         'Call CloseConectionTransaction(True)
      Catch exp As Exception
         'Call CloseConectionTransaction(False)
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompPlanEEFF.Dispose()
      End Try
   End Function

   Private Function CompPlanEEFFSaldo2(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As Decimal
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)
      Dim decDebe As Decimal = 0
      Dim decHaber As Decimal = 0
      Dim decSaldo As Decimal = 0
      Try
         CompPlanEEFFSaldo2 = 0

         With oCompPlanEEFF
            .SelectFilter = clsCompPlanEEFF.SelectFilters.All
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompDetId
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
         CompPlanEEFFSaldo2 = Math.Abs(mdecCompDetMonto - decSaldo)

         'If mlngCol = 1 Then 'Debe
         '   CompPlanEEFFSaldo2 = Math.Abs(mdecCompDetMonto - decDebe)
         'Else
         '   CompPlanEEFFSaldo2 = Math.Abs(mdecCompDetMonto - decHaber)
         'End If

         CompPlanEEFFSaldo2 = ToDecimalMinor(CompPlanEEFFSaldo2)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanEEFF.Dispose()

      End Try
   End Function

   Private Sub frmCompPlanEEFFEditLoad()
      Dim frm As New frmCompPlanEEFFEdit
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
      Dim decCompPlanEEFFSaldo As Decimal

      Try
         With oCompDet
            .CompDetId = moCompDet.CompDetId

            If .FindByPK Then
               Call CompPlanAddParametro(.DebeOrg, .HaberOrg)
               decCompPlanEEFFSaldo = CompPlanEEFFSaldo2(.CompId, .CompDetId)

               If decCompPlanEEFFSaldo = 0 Then
                  MessageBox.Show("El Monto de la(s) Cuenta(s) de Flujo ya esta Balanceado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub

               ElseIf decCompPlanEEFFSaldo < 0 Then
                  MessageBox.Show("El Monto de la(s) Cuentas(s) de Flujo no puede ser Mayor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Exit Sub
               End If

               Do While decCompPlanEEFFSaldo > 0
                  With oCompPlanEEFF
                     .EmpresaId = oCompDet.EmpresaId
                     .CompId = oCompDet.CompId
                     .CompDetId = oCompDet.CompDetId
                     .GestionId = oCompDet.GestionId
                     .Fecha = ConvertDMY(oCompDet.Fecha)
                     .PlanId = oCompDet.PlanId
                     .MonedaId = oCompDet.MonedaId
                     .EstadoId = 13

                     If mlngCol = 1 Then
                        .DebeOrg = decCompPlanEEFFSaldo

                     ElseIf mlngCol = 2 Then
                        .HaberOrg = decCompPlanEEFFSaldo
                     End If

                     frm.NewRecord = True
                     frm.Editing = False
                     frm.Changed = False
                     frm.NuevoComprobante = mboolNuevoComprobante
                     frm.TipoCambio = mdecTipoCambio
                     frm.CompMonedaId = moCompDet.MonedaId
                     frm.Col = mlngCol
                     frm.CompDetMonto = mdecCompDetMonto
                     frm.DataObject = oCompPlanEEFF
                     frm.ShowDialog()

                     If frm.Changed Then
                        decCompPlanEEFFSaldo = CompPlanEEFFSaldo2(.CompId, .CompDetId)
                     Else
                        Exit Sub
                     End If
                  End With
               Loop
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompPlanEEFF.Dispose()
         oCompDet.Dispose()

      End Try
   End Sub

   Private Function DeleteCompPlanEEFF(ByVal lngCompDetId As Long) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

      DeleteCompPlanEEFF = False

      Try
         With oCompPlanEEFF
            .WhereFilter = clsCompPlanEEFF.WhereFilters.CompDetId
            .EmpresaId = moCompDet.EmpresaId
            .CompId = moCompDet.CompId
            .CompDetId = lngCompDetId

            If .Delete() Then
               DeleteCompPlanEEFF = True
            End If
         End With

      Catch exp As Exception
         'MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Throw exp
      Finally
         oCompPlanEEFF.Dispose()

      End Try
   End Function
#End Region

End Class
