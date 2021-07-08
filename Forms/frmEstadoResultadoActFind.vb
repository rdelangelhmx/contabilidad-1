Public Class frmEstadoResultadoActFind
   Inherits System.Windows.Forms.Form

   Private mlngEmpresaId As Long

   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Friend WithEvents cboCentroCostoDet As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Private mboolCheckTipoAsientoAll As Boolean
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Private mboolCheckCentroCostoDetAll As Boolean

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

#Region " Código generado por el Diseñador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Diseñador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicialización después de la llamada a InitializeComponent()

   End Sub

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Diseñador de Windows Forms. 
   'No lo modifique con el editor de código.
   Friend WithEvents dudNivel As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents grbFac As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optConFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents cboTipoAsiento As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents optSinFac As Janus.Windows.EditControls.UIRadioButton
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkFecha As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents chkTotalizar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkSaldoGestion As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboCentroCostoDet_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoResultadoActFind))
      Dim cboTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCostoDet = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.cboTipoAsiento = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.grbFac = New Janus.Windows.EditControls.UIGroupBox
      Me.optConFac = New Janus.Windows.EditControls.UIRadioButton
      Me.optSinFac = New Janus.Windows.EditControls.UIRadioButton
      Me.dudNivel = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.chkSaldoGestion = New Janus.Windows.EditControls.UICheckBox
      Me.chkTotalizar = New Janus.Windows.EditControls.UICheckBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.chkFecha = New Janus.Windows.EditControls.UICheckBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Label6 = New System.Windows.Forms.Label
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbFac.SuspendLayout()
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
      Me.bcgMain.Controls.Add(Me.chkFecha)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(460, 252)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.cboCentroCostoDet)
      Me.UiGroupBox1.Controls.Add(Me.cboTipoAsiento)
      Me.UiGroupBox1.Controls.Add(Me.Label7)
      Me.UiGroupBox1.Controls.Add(Me.grbFac)
      Me.UiGroupBox1.Controls.Add(Me.dudNivel)
      Me.UiGroupBox1.Controls.Add(Me.Label2)
      Me.UiGroupBox1.Controls.Add(Me.cboCentroCosto)
      Me.UiGroupBox1.Controls.Add(Me.cboMoneda)
      Me.UiGroupBox1.Controls.Add(Me.Label1)
      Me.UiGroupBox1.Controls.Add(Me.chkSaldoGestion)
      Me.UiGroupBox1.Controls.Add(Me.chkTotalizar)
      Me.UiGroupBox1.Controls.Add(Me.Label5)
      Me.UiGroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 60)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(444, 184)
      Me.UiGroupBox1.TabIndex = 4
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCostoDet
      '
      Me.cboCentroCostoDet.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
      Me.cboCentroCostoDet.ControlStyle.ControlTextColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCostoDet.ControlStyle.WindowTextColor = System.Drawing.SystemColors.HotTrack
      cboCentroCostoDet_DesignTimeLayout.LayoutString = resources.GetString("cboCentroCostoDet_DesignTimeLayout.LayoutString")
      Me.cboCentroCostoDet.DesignTimeLayout = cboCentroCostoDet_DesignTimeLayout
      Me.cboCentroCostoDet.DropDownButtonsVisible = False
      Me.cboCentroCostoDet.Enabled = False
      Me.cboCentroCostoDet.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCostoDet.Location = New System.Drawing.Point(116, 64)
      Me.cboCentroCostoDet.Name = "cboCentroCostoDet"
      Me.cboCentroCostoDet.SaveSettings = False
      Me.cboCentroCostoDet.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCostoDet.TabIndex = 162
      Me.cboCentroCostoDet.ValuesDataMember = Nothing
      Me.cboCentroCostoDet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboTipoAsiento
      '
      Me.cboTipoAsiento.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
      Me.cboTipoAsiento.ControlStyle.ControlTextColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAsiento.ControlStyle.WindowTextColor = System.Drawing.SystemColors.HotTrack
      cboTipoAsiento_DesignTimeLayout.LayoutString = resources.GetString("cboTipoAsiento_DesignTimeLayout.LayoutString")
      Me.cboTipoAsiento.DesignTimeLayout = cboTipoAsiento_DesignTimeLayout
      Me.cboTipoAsiento.DropDownButtonsVisible = False
      Me.cboTipoAsiento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoAsiento.Location = New System.Drawing.Point(116, 112)
      Me.cboTipoAsiento.Name = "cboTipoAsiento"
      Me.cboTipoAsiento.SaveSettings = False
      Me.cboTipoAsiento.Size = New System.Drawing.Size(320, 20)
      Me.cboTipoAsiento.TabIndex = 11
      Me.cboTipoAsiento.ValuesDataMember = Nothing
      Me.cboTipoAsiento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(7, 114)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(102, 18)
      Me.Label7.TabIndex = 226
      Me.Label7.Text = "Tipo de Asiento"
      '
      'grbFac
      '
      Me.grbFac.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbFac.Controls.Add(Me.optConFac)
      Me.grbFac.Controls.Add(Me.optSinFac)
      Me.grbFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbFac.Location = New System.Drawing.Point(352, 131)
      Me.grbFac.Name = "grbFac"
      Me.grbFac.Size = New System.Drawing.Size(84, 32)
      Me.grbFac.TabIndex = 9
      Me.grbFac.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'optConFac
      '
      Me.optConFac.BackColor = System.Drawing.Color.Transparent
      Me.optConFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optConFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optConFac.Location = New System.Drawing.Point(48, 12)
      Me.optConFac.Name = "optConFac"
      Me.optConFac.Size = New System.Drawing.Size(28, 16)
      Me.optConFac.TabIndex = 16
      Me.optConFac.Text = "F"
      Me.optConFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optSinFac
      '
      Me.optSinFac.BackColor = System.Drawing.Color.Transparent
      Me.optSinFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optSinFac.Checked = True
      Me.optSinFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optSinFac.Location = New System.Drawing.Point(8, 12)
      Me.optSinFac.Name = "optSinFac"
      Me.optSinFac.Size = New System.Drawing.Size(28, 16)
      Me.optSinFac.TabIndex = 15
      Me.optSinFac.TabStop = True
      Me.optSinFac.Text = "I"
      Me.optSinFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'dudNivel
      '
      Me.dudNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudNivel.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudNivel.Location = New System.Drawing.Point(116, 88)
      Me.dudNivel.Maximum = 10
      Me.dudNivel.Minimum = 1
      Me.dudNivel.Name = "dudNivel"
      Me.dudNivel.Size = New System.Drawing.Size(124, 20)
      Me.dudNivel.TabIndex = 10
      Me.dudNivel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudNivel.Value = 5
      Me.dudNivel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 92)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 214
      Me.Label2.Text = "Nivel"
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(116, 40)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCosto.TabIndex = 8
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      Me.cboMoneda.TabIndex = 5
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 163
      Me.Label1.Text = "Centro de Costo"
      '
      'chkSaldoGestion
      '
      Me.chkSaldoGestion.BackColor = System.Drawing.Color.Transparent
      Me.chkSaldoGestion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSaldoGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSaldoGestion.Location = New System.Drawing.Point(8, 160)
      Me.chkSaldoGestion.Name = "chkSaldoGestion"
      Me.chkSaldoGestion.Size = New System.Drawing.Size(232, 16)
      Me.chkSaldoGestion.TabIndex = 14
      Me.chkSaldoGestion.Text = "Incluir Saldos de la Gestión"
      Me.chkSaldoGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkTotalizar
      '
      Me.chkTotalizar.BackColor = System.Drawing.Color.Transparent
      Me.chkTotalizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkTotalizar.Checked = True
      Me.chkTotalizar.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkTotalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkTotalizar.Location = New System.Drawing.Point(8, 140)
      Me.chkTotalizar.Name = "chkTotalizar"
      Me.chkTotalizar.Size = New System.Drawing.Size(232, 16)
      Me.chkTotalizar.TabIndex = 12
      Me.chkTotalizar.Text = "Totalizar Cuentas"
      Me.chkTotalizar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 20)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 161
      Me.Label5.Text = "Moneda"
      '
      'chkFecha
      '
      Me.chkFecha.BackColor = System.Drawing.Color.Transparent
      Me.chkFecha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFecha.Checked = True
      Me.chkFecha.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFecha.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkFecha.Location = New System.Drawing.Point(16, 8)
      Me.chkFecha.Name = "chkFecha"
      Me.chkFecha.Size = New System.Drawing.Size(112, 20)
      Me.chkFecha.TabIndex = 1
      Me.chkFecha.Text = "Habilitar Fechas"
      Me.chkFecha.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.dtpFechaFin)
      Me.grpMain.Controls.Add(Me.dtpFechaIni)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 12)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 48)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'dtpFechaFin
      '
      Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaFin.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaFin.DropDownCalendar.Name = ""
      Me.dtpFechaFin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaFin.Location = New System.Drawing.Point(312, 20)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaFin.TabIndex = 3
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'dtpFechaIni
      '
      Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaIni.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaIni.DropDownCalendar.Name = ""
      Me.dtpFechaIni.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaIni.Location = New System.Drawing.Point(56, 20)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaIni.TabIndex = 2
      Me.dtpFechaIni.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(8, 24)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(44, 16)
      Me.Label3.TabIndex = 154
      Me.Label3.Text = "Desde"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(264, 24)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(44, 16)
      Me.Label4.TabIndex = 153
      Me.Label4.Text = "Hasta"
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
      Me.ilsMain.Images.SetKeyName(5, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("8efaf206-bebc-40a5-80e2-61079d3ec4c2")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator1, Me.Exit1})
      Me.UiCommandBar1.Key = "ToolBar"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(170, 28)
      Me.UiCommandBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.Text = "Resultados"
      Me.Book1.ToolTipText = "Estado de Resultados"
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
      'Book
      '
      Me.Book.ImageIndex = 5
      Me.Book.Key = "Book"
      Me.Book.Name = "Book"
      Me.Book.Text = "Balance"
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
      Me.TopRebar1.Size = New System.Drawing.Size(460, 28)
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 68)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 227
      Me.Label6.Text = "Actividad"
      '
      'frmEstadoResultadoActFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(460, 280)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Name = "frmEstadoResultadoActFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Estado de Resultados"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbFac.ResumeLayout(False)
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
         Case "Book"
            Call frmEstadoResultadoLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmEstadoResultadoActFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmEstadoResultadoActFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call ComboLoad()
      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub ComboLoad()
      Call cboMonedaLoad()
      Call cboCentroCostoLoad()
      'Call cboSucursalLoad()
      Call cboTipoAsientoLoad()
   End Sub

#Region " ComboLoads "
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
                  If .MonedaId <> 0 Then
                     oItem = New clsListItem(.MonedaId, .MonedaDes)

                     cboMoneda.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop

               oItem = New clsListItem(4, "Ambas")
               cboMoneda.Items.Add(oItem)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMoneda.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboCentroCostoDetLoad(ByVal lngCentroCostoId As Long)
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)

      Try
         With oCentroCostoDet
            .SelectFilter = clsCentroCostoDet.SelectFilters.ListBox
            .WhereFilter = clsCentroCostoDet.WhereFilters.CentroCostoId
            .OrderByFilter = clsCentroCostoDet.OrderByFilters.CentroCostoDetDes
            .CentroCostoId = lngCentroCostoId
            .EmpresaId = mlngEmpresaId

            cboCentroCostoDet.DropDownDataSource = Nothing
            cboCentroCostoDet.Text = ""

            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               cboCentroCostoDet.Enabled = True

               Dim oRow As DataRow

               oRow = .DataSet.Tables(.TableName).NewRow
               oRow("CentroCostoDetId") = 0
               oRow("CentroCostoDetDes") = "(Todos)"

               .DataSet.Tables(.TableName).Rows.InsertAt(oRow, 0)

               With cboCentroCostoDet
                  .DropDownDataSource = oCentroCostoDet.DataSet.Tables(oCentroCostoDet.TableName)
                  .RetrieveStructure()

                  .ValueItemDataMember = "CentroCostoDetId"
                  .DropDownValueMember = "CentroCostoDetId"

                  .DropDownDisplayMember = "CentroCostoDetDes"
                  .DropDownList.Columns(0).UseHeaderSelector = True

                  .DropDownList.Columns("CentroCostoDetId").Visible = False

                  .DropDownList.Columns("CentroCostoDetDes").Caption = "Descripción"
                  .DropDownList.Columns("CentroCostoDetDes").Width = 300

                  Call cboCentroCostoDetEventos()

                  cboCentroCostoDet.DropDownList.GetRows(0).IsChecked = True
                  cboCentroCostoDet.Text = cboCentroCostoDet.DropDownList.GetRows(0).Cells("CentroCostoDetDes").Value
               End With
            Else
               cboCentroCostoDet.Enabled = False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCostoDet.Dispose()

      End Try
   End Sub

   Private Sub cboCentroCostoLoad()
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboCentroCosto.Items.Clear()

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.ListBox
            .WhereFilter = clsCentroCosto.WhereFilters.EmpresaId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = mlngEmpresaId

            If .Open() Then
               oItem = New clsListItem(0, "(Todos)")
               cboCentroCosto.Items.Add(oItem)

               Do While .Read()
                  If .CentroCostoId <> 0 Then
                     oItem = New clsListItem(.CentroCostoId, .CentroCostoDes)

                     cboCentroCosto.Items.Add(oItem)
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCosto.Dispose()
         oItem = Nothing

      End Try
   End Sub

   'Private Sub cboSucursalLoad()
   '   Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)
   '   Dim oItem As clsListItem

   '   cboSucursal.Items.Clear()

   '   Try
   '      With oSucursal
   '         .SelectFilter = clsSucursal.SelectFilters.ListBox
   '         .WhereFilter = clsSucursal.WhereFilters.EmpresaId
   '         .OrderByFilter = clsSucursal.OrderByFilters.SucursalDes
   '         .EmpresaId = mlngEmpresaId

   '         If .Open() Then
   '            oItem = New clsListItem(0, "(Todos)")
   '            cboSucursal.Items.Add(oItem)

   '            Do While .Read()
   '               oItem = New clsListItem(.SucursalId, .SucursalDes)

   '               cboSucursal.Items.Add(oItem)
   '               .MoveNext()
   '            Loop
   '         End If
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oSucursal.Dispose()
   '      oItem = Nothing

   '   End Try
   'End Sub

   Private Sub cboTipoAsientoLoad()
      Dim oTipoAsiento As New clsTipoAsiento(clsAppInfo.ConnectString)

      Try
         With oTipoAsiento
            .SelectFilter = clsTipoAsiento.SelectFilters.ListBox
            .OrderByFilter = clsTipoAsiento.OrderByFilters.TipoAsientoDes

            If .Open() Then
               Dim oRow As DataRow

               oRow = .DataSet.Tables(.TableName).NewRow
               oRow("TipoAsientoId") = -1
               oRow("TipoAsientoDes") = "(Todos)"

               .DataSet.Tables(.TableName).Rows.InsertAt(oRow, 0)

               With cboTipoAsiento
                  .DropDownDataSource = oTipoAsiento.DataSet.Tables(oTipoAsiento.TableName)
                  .RetrieveStructure()

                  .ValueItemDataMember = "TipoAsientoId"
                  .DropDownValueMember = "TipoAsientoId"
                  .DropDownDisplayMember = "TipoAsientoDes"
                  .DropDownList.Columns(0).UseHeaderSelector = True

                  .DropDownList.Columns("TipoAsientoId").Visible = False

                  .DropDownList.Columns("TipoAsientoDes").Caption = "Descripción"
                  .DropDownList.Columns("TipoAsientoDes").Width = 300

                  Call cboTipoAsientoEventos()
               End With

               'cboPlan.Value = ListFindItem(cboPlan, 0)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoAsiento.Dispose()

      End Try
   End Sub
#End Region

   Private Sub FormInit()
      Call FormCenter(Me)

      If GestionFecha(clsAppInfo.GestionId, mstrFechaIni, mstrFechaFin) Then
         dtpFechaIni.Value = mstrFechaIni
         dtpFechaFin.Value = mstrFechaFin
      End If

      dtpFechaIni.MaxDate = mstrFechaFin
      dtpFechaIni.MinDate = mstrFechaIni
      dtpFechaFin.MaxDate = mstrFechaFin
      dtpFechaFin.MinDate = mstrFechaIni

      dtpFechaFin.Value = Date.Now

      cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
      cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, 0)
      'cboSucursal.SelectedIndex = ListFindItem(cboSucursal, 0)
      cboTipoAsiento.DropDownList.GetRows(0).IsChecked = True
      cboTipoAsiento.Text = cboTipoAsiento.DropDownList.GetRows(0).Cells("TipoAsientoDes").Value

      If Not clsAppInfo.MultipleNro Then
         optSinFac.Checked = True
         grbFac.Visible = False
      End If
   End Sub

   Private Sub frmEstadoResultadoLoad()
      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) <> 0 Then
         If cboCentroCosto.SelectedIndex <> -1 Then
            Dim oListaTipoAsiento As New Queue
            For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetCheckedRows
               oListaTipoAsiento.Enqueue(oRow.Cells("TipoAsientoId").Value)
            Next

            Dim oListaCentroCostoDet As New Queue
            For Each oRow As Janus.Windows.GridEX.GridEXRow In cboCentroCostoDet.DropDownList.GetCheckedRows
               If oRow.Cells("CentroCostoDetId").Value <> 0 Then
                  oListaCentroCostoDet.Enqueue(oRow.Cells("CentroCostoDetId").Value)
               End If
            Next
            If oListaTipoAsiento.Count Then
               Dim frm As New frmEstadoResultadoAct

               With frm
                  .EmpresaId = mlngEmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                  .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
                  .ListaCentroCostoDet = oListaCentroCostoDet
                  .CentroCostoDetDes = cboCentroCostoDet.Text
                  ' .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
                  .FechaIni = dtpFechaIni.Value
                  .FechaFin = dtpFechaFin.Value
                  .FechaIniGestion = dtpFechaIni.MinDate
                  .FechaFinGestion = dtpFechaFin.MaxDate
                  .Nivel = ToLong(dudNivel.Value)
                  .Totalizar = ToBoolean(chkTotalizar.Checked)
                  .SinFac = ToBoolean(optSinFac.Checked)
                  .ConFac = ToBoolean(optConFac.Checked)
                  .ListaTipoAsiento = oListaTipoAsiento
                  .IntervaloFecha = ToBoolean(chkFecha.Checked)
                  .SaldoGestion = ToBoolean(chkSaldoGestion.Checked)

                  .MdiParent = Me.MdiParent
                  .Show()

                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, Me.ToString)
               End With
            Else
               MessageBox.Show("Debe Seleccionar al Menos un Tipo de Asiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar el Centro de Costo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar la Moneda", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub frmEstadoResultadoActFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmEstadoResultadoLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmEstadoResultadoActFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

#Region " Eventos "
   'Private Sub optCentroCosto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
   '   If optCentroCosto.Checked Then
   '      cboCentroCosto.Enabled = True
   '      cboSucursal.Enabled = False

   '      cboSucursal.SelectedIndex = ListFindItem(cboSucursal, 0)
   '   End If
   'End Sub

   'Private Sub optSucursal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
   '   If optSucursal.Checked Then
   '      cboCentroCosto.Enabled = False
   '      cboSucursal.Enabled = True

   '      cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, 0)
   '   End If
   'End Sub

   Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
      If ToBoolean(chkFecha.Checked) = 0 Then
         dtpFechaFin.Value = Date.Now
         dtpFechaIni.Value = mstrFechaIni
      End If

      dtpFechaIni.Enabled = chkFecha.Checked
      dtpFechaFin.Enabled = chkFecha.Checked

      chkSaldoGestion.Enabled = chkFecha.Checked
      chkSaldoGestion.Checked = False
   End Sub
#End Region

#Region " Otros Metodos "
   Private Function GestionFecha(ByVal GestionId As Long, ByRef strFechaIni As String, ByRef strFechaFin As String) As Boolean
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionFecha = False
      Try
         With oGestion
            .GestionId = GestionId

            If .FindByPK Then
               strFechaIni = .FechaIni
               strFechaFin = .FechaFin
               GestionFecha = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oGestion.Dispose()
      End Try
   End Function
#End Region

#Region " cboTipoAsiento-Metodos "
   Private Sub cboTipoAsientoEventos()
      Dim b As New Janus.Windows.GridEX.RowCheckStateChangeEventHandler(AddressOf cboTipoAsiento_RowCheckStateChanged)
      AddHandler cboTipoAsiento.DropDownList.RowCheckStateChanged, b

      Dim c As New Janus.Windows.GridEX.RowCheckStateChangingEventHandler(AddressOf cboTipoAsiento_RowCheckStateChanging)
      AddHandler cboTipoAsiento.DropDownList.RowCheckStateChanging, c
   End Sub

   Private Sub cboTipoAsiento_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs)
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         cboTipoAsientoCheckAll(True)
      End If
   End Sub

   Private Sub cboTipoAsiento_RowCheckStateChanging(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangingEventArgs)
      If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
         If cboTipoAsiento.DropDownList.GetRow.Cells("TipoAsientoId").Value = -1 And (cboTipoAsiento.DropDownList.GetCheckedRows.Count > 0) Then
            If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
               cboTipoAsientoCheckAll(True)
            End If

            e.Cancel = True

         ElseIf cboTipoAsiento.DropDownList.GetRow.Cells("TipoAsientoId").Value <> -1 Then
            cboTipoAsiento_CheckTodos(False)
         End If
      End If
   End Sub

   Private Sub cboTipoAsientoCheckAll(ByVal boolValue As Boolean)
      If mboolCheckTipoAsientoAll Then
         mboolCheckTipoAsientoAll = False
      Else
         mboolCheckTipoAsientoAll = True
      End If

      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetRows
         oRow.BeginEdit()

         If oRow.Cells("TipoAsientoId").Value = -1 Then
            oRow.IsChecked = False
         Else
            oRow.IsChecked = mboolCheckTipoAsientoAll
         End If

         oRow.EndEdit()
      Next
   End Sub

   Private Sub cboTipoAsiento_CheckTodos(ByVal boolValue As Boolean)
      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetRows
         oRow.BeginEdit()

         If oRow.Cells("TipoAsientoId").Value = -1 Then
            oRow.IsChecked = boolValue
         End If

         oRow.EndEdit()

         Exit For
      Next
   End Sub
#End Region

#Region " cboCentroCostoDet-Metodos "
   Private Sub cboCentroCostoDetEventos()
      Dim b As New Janus.Windows.GridEX.RowCheckStateChangeEventHandler(AddressOf cboCentroCostoDet_RowCheckStateChanged)
      AddHandler cboCentroCostoDet.DropDownList.RowCheckStateChanged, b

      Dim c As New Janus.Windows.GridEX.RowCheckStateChangingEventHandler(AddressOf cboCentroCostoDet_RowCheckStateChanging)
      AddHandler cboCentroCostoDet.DropDownList.RowCheckStateChanging, c
   End Sub

   Private Sub cboCentroCostoDet_RowCheckStateChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangeEventArgs)
      If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
         cboCentroCostoDetCheckAll(True)
      End If
   End Sub

   Private Sub cboCentroCostoDet_RowCheckStateChanging(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowCheckStateChangingEventArgs)
      If e.CheckState = Janus.Windows.GridEX.RowCheckState.Checked Then
         If cboCentroCostoDet.DropDownList.GetRow.Cells("CentroCostoDetId").Value = 0 And (cboCentroCostoDet.DropDownList.GetCheckedRows.Count > 0) Then
            If e.ChangeType = Janus.Windows.GridEX.CheckStateChangeType.ColumnHeaderChange Then
               cboCentroCostoDetCheckAll(True)
            End If

            e.Cancel = True

         ElseIf cboCentroCostoDet.DropDownList.GetRow.Cells("CentroCostoDetId").Value <> 0 Then
            cboCentroCostoDet_CheckTodos(False)
         End If
      End If
   End Sub

   Private Sub cboCentroCostoDetCheckAll(ByVal boolValue As Boolean)
      If mboolCheckCentroCostoDetAll Then
         mboolCheckCentroCostoDetAll = False
      Else
         mboolCheckCentroCostoDetAll = True
      End If

      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboCentroCostoDet.DropDownList.GetRows
         oRow.BeginEdit()

         If oRow.Cells("CentroCostoDetId").Value = 0 Then
            oRow.IsChecked = False
         Else
            oRow.IsChecked = mboolCheckCentroCostoDetAll
         End If

         oRow.EndEdit()
      Next
   End Sub

   Private Sub cboCentroCostoDet_CheckTodos(ByVal boolValue As Boolean)
      For Each oRow As Janus.Windows.GridEX.GridEXRow In cboCentroCostoDet.DropDownList.GetRows
         oRow.BeginEdit()

         If oRow.Cells("CentroCostoDetId").Value = 0 Then
            oRow.IsChecked = boolValue
         End If

         oRow.EndEdit()

         Exit For
      Next
   End Sub
#End Region

   Private Sub cboCentroCosto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentroCosto.SelectedIndexChanged
      If cboCentroCosto.ContainsFocus Then
         Dim lngCentroCostoId As Long = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
         Call cboCentroCostoDetLoad(lngCentroCostoId)
      End If
   End Sub

   Public Overrides Function ToString() As String
      Return "Gestión: " & clsAppInfo.Gestion & If(chkFecha.Checked, "; Desde " & dtpFechaIni.Text & " Hasta " & dtpFechaFin.Text, "") & "; Moneda : " & cboMoneda.Text & "; C.C.: " & cboCentroCosto.Text & "; Act: " & cboCentroCostoDet.Text & "; Nivel: " & dudNivel.Text & "; Tipo Asiento: " & cboTipoAsiento.Text & "; Totalizar: " & If(chkTotalizar.Checked, "Sí", "No") & "; Incluir Saldos: " & If(chkSaldoGestion.Checked, "Sí", "No")
   End Function
End Class
