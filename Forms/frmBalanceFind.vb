Public Class frmBalanceFind
   Inherits System.Windows.Forms.Form

   Private mlngEmpresaId As Long

   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Friend WithEvents chkPorMes As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkMostrarResultado As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents txtTitulo As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Private mboolCheckTipoAsientoAll As Boolean

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
   Friend WithEvents grbFac As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optConFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optSinFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents chkIncluirPlanAdd As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optSucursal As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optCentroCosto As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboCentroCosto As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ToolBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Book As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Book1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit4 As Janus.Windows.UI.CommandBars.UICommand
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents chkTotalizar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents cboMoneda As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboTipoAsiento As Janus.Windows.GridEX.EditControls.CheckedComboBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dudNivel As Janus.Windows.GridEX.EditControls.IntegerUpDown
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalanceFind))
      Dim cboTipoAsiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ToolBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Book1 = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit4 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Book = New Janus.Windows.UI.CommandBars.UICommand("Book")
      Me.Exit3 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtTitulo = New Janus.Windows.GridEX.EditControls.EditBox
      Me.chkMostrarResultado = New Janus.Windows.EditControls.UICheckBox
      Me.chkPorMes = New Janus.Windows.EditControls.UICheckBox
      Me.cboTipoAsiento = New Janus.Windows.GridEX.EditControls.CheckedComboBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.optSucursal = New Janus.Windows.EditControls.UIRadioButton
      Me.optCentroCosto = New Janus.Windows.EditControls.UIRadioButton
      Me.grbFac = New Janus.Windows.EditControls.UIGroupBox
      Me.optConFac = New Janus.Windows.EditControls.UIRadioButton
      Me.optSinFac = New Janus.Windows.EditControls.UIRadioButton
      Me.Label6 = New System.Windows.Forms.Label
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.cboCentroCosto = New Janus.Windows.EditControls.UIComboBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.chkIncluirPlanAdd = New Janus.Windows.EditControls.UICheckBox
      Me.dudNivel = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboMoneda = New Janus.Windows.EditControls.UIComboBox
      Me.chkTotalizar = New Janus.Windows.EditControls.UICheckBox
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbFac.SuspendLayout()
      Me.SuspendLayout()
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
      'Exit2
      '
      Me.Exit2.ImageIndex = 1
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.ToolBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book, Me.Exit3})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("ce73c52b-7d78-4a67-a39a-113c096fe863")
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
      'ToolBar1
      '
      Me.ToolBar1.CommandManager = Me.cdmMain
      Me.ToolBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Book1, Me.Separator3, Me.Exit4})
      Me.ToolBar1.Key = "ToolBar"
      Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
      Me.ToolBar1.Name = "ToolBar1"
      Me.ToolBar1.RowIndex = 0
      Me.ToolBar1.Size = New System.Drawing.Size(156, 28)
      Me.ToolBar1.Text = "ToolBar"
      '
      'Book1
      '
      Me.Book1.Key = "Book"
      Me.Book1.Name = "Book1"
      Me.Book1.ToolTipText = "Balance General"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Exit4
      '
      Me.Exit4.Key = "Exit"
      Me.Exit4.Name = "Exit4"
      '
      'Book
      '
      Me.Book.ImageIndex = 5
      Me.Book.Key = "Book"
      Me.Book.Name = "Book"
      Me.Book.Text = "Balance"
      '
      'Exit3
      '
      Me.Exit3.ImageIndex = 1
      Me.Exit3.Key = "Exit"
      Me.Exit3.Name = "Exit3"
      Me.Exit3.Text = "Salir"
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
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.ToolBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.ToolBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(457, 28)
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(457, 240)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.txtTitulo)
      Me.grpMain.Controls.Add(Me.chkMostrarResultado)
      Me.grpMain.Controls.Add(Me.chkPorMes)
      Me.grpMain.Controls.Add(Me.cboTipoAsiento)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.UiGroupBox2)
      Me.grpMain.Controls.Add(Me.grbFac)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.cboSucursal)
      Me.grpMain.Controls.Add(Me.cboCentroCosto)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.chkIncluirPlanAdd)
      Me.grpMain.Controls.Add(Me.dudNivel)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.cboMoneda)
      Me.grpMain.Controls.Add(Me.chkTotalizar)
      Me.grpMain.Controls.Add(Me.dtpFechaFin)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 236)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 212)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 227
      Me.Label5.Text = "Titulo"
      '
      'txtTitulo
      '
      Me.txtTitulo.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTitulo.Location = New System.Drawing.Point(116, 208)
      Me.txtTitulo.MaxLength = 100
      Me.txtTitulo.Name = "txtTitulo"
      Me.txtTitulo.Size = New System.Drawing.Size(320, 20)
      Me.txtTitulo.TabIndex = 13
      Me.txtTitulo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTitulo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'chkMostrarResultado
      '
      Me.chkMostrarResultado.BackColor = System.Drawing.Color.Transparent
      Me.chkMostrarResultado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkMostrarResultado.Checked = True
      Me.chkMostrarResultado.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkMostrarResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkMostrarResultado.Location = New System.Drawing.Point(296, 164)
      Me.chkMostrarResultado.Name = "chkMostrarResultado"
      Me.chkMostrarResultado.Size = New System.Drawing.Size(140, 16)
      Me.chkMostrarResultado.TabIndex = 11
      Me.chkMostrarResultado.Text = "Mostrar Resultado"
      Me.chkMostrarResultado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkPorMes
      '
      Me.chkPorMes.BackColor = System.Drawing.Color.Transparent
      Me.chkPorMes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkPorMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkPorMes.Location = New System.Drawing.Point(296, 188)
      Me.chkPorMes.Name = "chkPorMes"
      Me.chkPorMes.Size = New System.Drawing.Size(140, 16)
      Me.chkPorMes.TabIndex = 12
      Me.chkPorMes.Text = "Comparativo por Mes"
      Me.chkPorMes.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      Me.cboTipoAsiento.Location = New System.Drawing.Point(112, 136)
      Me.cboTipoAsiento.Name = "cboTipoAsiento"
      Me.cboTipoAsiento.SaveSettings = False
      Me.cboTipoAsiento.Size = New System.Drawing.Size(324, 20)
      Me.cboTipoAsiento.TabIndex = 8
      Me.cboTipoAsiento.ValuesDataMember = Nothing
      Me.cboTipoAsiento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(6, 140)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(102, 18)
      Me.Label4.TabIndex = 224
      Me.Label4.Text = "Tipo de Asiento"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox2.Controls.Add(Me.optSucursal)
      Me.UiGroupBox2.Controls.Add(Me.optCentroCosto)
      Me.UiGroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.UiGroupBox2.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.UiGroupBox2.Location = New System.Drawing.Point(108, 64)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(24, 48)
      Me.UiGroupBox2.TabIndex = 222
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'optSucursal
      '
      Me.optSucursal.BackColor = System.Drawing.Color.Transparent
      Me.optSucursal.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.optSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optSucursal.Location = New System.Drawing.Point(4, 28)
      Me.optSucursal.Name = "optSucursal"
      Me.optSucursal.Size = New System.Drawing.Size(16, 16)
      Me.optSucursal.TabIndex = 5
      Me.optSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optCentroCosto
      '
      Me.optCentroCosto.BackColor = System.Drawing.Color.Transparent
      Me.optCentroCosto.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.optCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optCentroCosto.Location = New System.Drawing.Point(4, 4)
      Me.optCentroCosto.Name = "optCentroCosto"
      Me.optCentroCosto.Size = New System.Drawing.Size(16, 16)
      Me.optCentroCosto.TabIndex = 3
      Me.optCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grbFac
      '
      Me.grbFac.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grbFac.Controls.Add(Me.optConFac)
      Me.grbFac.Controls.Add(Me.optSinFac)
      Me.grbFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbFac.Location = New System.Drawing.Point(356, 28)
      Me.grbFac.Name = "grbFac"
      Me.grbFac.Size = New System.Drawing.Size(84, 32)
      Me.grbFac.TabIndex = 10
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
      Me.optConFac.TabIndex = 12
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
      Me.optSinFac.TabIndex = 11
      Me.optSinFac.TabStop = True
      Me.optSinFac.Text = "I"
      Me.optSinFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 92)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 221
      Me.Label6.Text = "Sucursal"
      '
      'cboSucursal
      '
      Me.cboSucursal.Enabled = False
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(132, 88)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(304, 20)
      Me.cboSucursal.TabIndex = 6
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboCentroCosto
      '
      Me.cboCentroCosto.Enabled = False
      Me.cboCentroCosto.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(132, 64)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCentroCosto.Size = New System.Drawing.Size(304, 20)
      Me.cboCentroCosto.TabIndex = 4
      Me.cboCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 68)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 219
      Me.Label3.Text = "Centro de Costo"
      '
      'chkIncluirPlanAdd
      '
      Me.chkIncluirPlanAdd.BackColor = System.Drawing.Color.Transparent
      Me.chkIncluirPlanAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkIncluirPlanAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkIncluirPlanAdd.Location = New System.Drawing.Point(8, 160)
      Me.chkIncluirPlanAdd.Name = "chkIncluirPlanAdd"
      Me.chkIncluirPlanAdd.Size = New System.Drawing.Size(228, 20)
      Me.chkIncluirPlanAdd.TabIndex = 9
      Me.chkIncluirPlanAdd.Text = "Incluir Analíticos Adicionales"
      Me.chkIncluirPlanAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'dudNivel
      '
      Me.dudNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudNivel.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudNivel.Location = New System.Drawing.Point(112, 112)
      Me.dudNivel.Maximum = 10
      Me.dudNivel.Minimum = 1
      Me.dudNivel.Name = "dudNivel"
      Me.dudNivel.Size = New System.Drawing.Size(124, 20)
      Me.dudNivel.TabIndex = 7
      Me.dudNivel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudNivel.Value = 5
      Me.dudNivel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 116)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(100, 16)
      Me.Label1.TabIndex = 212
      Me.Label1.Text = "Nivel"
      '
      'cboMoneda
      '
      Me.cboMoneda.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboMoneda.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboMoneda.Location = New System.Drawing.Point(112, 40)
      Me.cboMoneda.Name = "cboMoneda"
      Me.cboMoneda.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboMoneda.Size = New System.Drawing.Size(124, 20)
      Me.cboMoneda.TabIndex = 2
      Me.cboMoneda.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkTotalizar
      '
      Me.chkTotalizar.BackColor = System.Drawing.Color.Transparent
      Me.chkTotalizar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkTotalizar.Checked = True
      Me.chkTotalizar.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkTotalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkTotalizar.Location = New System.Drawing.Point(8, 184)
      Me.chkTotalizar.Name = "chkTotalizar"
      Me.chkTotalizar.Size = New System.Drawing.Size(228, 20)
      Me.chkTotalizar.TabIndex = 10
      Me.chkTotalizar.Text = "Totalizar Cuentas . . . . . . ."
      Me.chkTotalizar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      Me.dtpFechaFin.Location = New System.Drawing.Point(112, 16)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaFin.TabIndex = 1
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(8, 20)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(100, 16)
      Me.Label2.TabIndex = 166
      Me.Label2.Text = "Al"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label7.Location = New System.Drawing.Point(8, 44)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(100, 16)
      Me.Label7.TabIndex = 165
      Me.Label7.Text = "Moneda"
      '
      'frmBalanceFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(457, 268)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Name = "frmBalanceFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Balance General"
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      CType(Me.grbFac, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbFac.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Book"
            Call frmBalanceLoad()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmBalanceFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmBalanceFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      Call cboSucursalLoad()
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

   Private Sub cboSucursalLoad()
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboSucursal.Items.Clear()

      Try
         With oSucursal
            .SelectFilter = clsSucursal.SelectFilters.ListBox
            .WhereFilter = clsSucursal.WhereFilters.EmpresaId
            .OrderByFilter = clsSucursal.OrderByFilters.SucursalDes
            .EmpresaId = mlngEmpresaId

            If .Open() Then
               oItem = New clsListItem(0, "(Todos)")
               cboSucursal.Items.Add(oItem)

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
         dtpFechaFin.MaxDate = mstrFechaFin
         dtpFechaFin.MinDate = mstrFechaIni
      End If

      dtpFechaFin.Value = Date.Now

      cboMoneda.SelectedIndex = ListFindItem(cboMoneda, clsAppInfo.MonedaId)
      cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, 0)
      cboSucursal.SelectedIndex = ListFindItem(cboSucursal, 0)

      cboTipoAsiento.DropDownList.GetRows(0).IsChecked = True
      cboTipoAsiento.Text = cboTipoAsiento.DropDownList.GetRows(0).Cells("TipoAsientoDes").Value

      If Not clsAppInfo.MultipleNro Then
         optSinFac.Checked = True
         grbFac.Visible = False
      End If
   End Sub

   Private Sub frmBalanceLoad()
      If ListPosition(cboMoneda, cboMoneda.SelectedIndex) <> 0 Then
         Dim oListaTipoAsiento As New Queue
         For Each oRow As Janus.Windows.GridEX.GridEXRow In cboTipoAsiento.DropDownList.GetCheckedRows
            oListaTipoAsiento.Enqueue(oRow.Cells("TipoAsientoId").Value)
         Next

         If oListaTipoAsiento.Count Then
            If Not chkPorMes.Checked Then
               Dim frm As New frmBalance

               With frm
                  .EmpresaId = mlngEmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                  .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
                  .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
                  .FechaIni = dtpFechaFin.MinDate
                  .FechaFin = dtpFechaFin.Value
                  .Nivel = ToLong(dudNivel.Value)
                  .IncluirPlanAdd = ToBoolean(chkIncluirPlanAdd.Checked)
                  .Totalizar = ToBoolean(chkTotalizar.Checked)
                  .MostrarResultado = ToBoolean(chkMostrarResultado.Checked)
                  .Titulo = ToStr(txtTitulo.Text)
                  .SinFac = ToBoolean(optSinFac.Checked)
                  .ConFac = ToBoolean(optConFac.Checked)
                  .ListaTipoAsiento = oListaTipoAsiento

                  .MdiParent = Me.MdiParent
                  .Show()

                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, Me.ToString)
               End With
            Else
               Dim frm As New frmBalanceMes

               With frm
                  .EmpresaId = mlngEmpresaId
                  .GestionId = clsAppInfo.GestionId
                  .MonedaId = ListPosition(cboMoneda, cboMoneda.SelectedIndex)
                  .CentroCostoId = ListPosition(cboCentroCosto, cboCentroCosto.SelectedIndex)
                  .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
                  .FechaIni = dtpFechaFin.MinDate
                  .FechaFin = dtpFechaFin.Value
                  .FechaIniGestion = dtpFechaFin.MinDate
                  .FechaFinGestion = dtpFechaFin.MaxDate
                  .Nivel = ToLong(dudNivel.Value)
                  .IncluirPlanAdd = ToBoolean(chkIncluirPlanAdd.Checked)
                  .Totalizar = ToBoolean(chkTotalizar.Checked)
                  .MostrarResultado = ToBoolean(chkMostrarResultado.Checked)
                  .Titulo = ToStr(txtTitulo.Text)
                  .SinFac = ToBoolean(optSinFac.Checked)
                  .ConFac = ToBoolean(optConFac.Checked)
                  .ListaTipoAsiento = oListaTipoAsiento

                  .MdiParent = Me.MdiParent
                  .Show()

                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INFORME, Me.ToString)
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar al menos un Tipo de Asiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
         Else
            MessageBox.Show("Debe Seleccionar la Moneda", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
   End Sub

   Private Sub optCentroCosto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCentroCosto.CheckedChanged
      If optCentroCosto.Checked Then
         cboCentroCosto.Enabled = True
         cboSucursal.Enabled = False

         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, 0)
      End If
   End Sub

   Private Sub optSucursal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSucursal.CheckedChanged
      If optSucursal.Checked Then
         cboCentroCosto.Enabled = False
         cboSucursal.Enabled = True

         cboCentroCosto.SelectedIndex = ListFindItem(cboCentroCosto, 0)
      End If
   End Sub

   Private Sub frmBalanceFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call frmBalanceLoad()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmBalanceFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

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

   Private Sub chkPorMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPorMes.CheckedChanged
      If ToBoolean(chkPorMes.Checked) = 0 Then
         chkIncluirPlanAdd.Checked = True
         chkIncluirPlanAdd.Enabled = True
      Else
         chkIncluirPlanAdd.Checked = False
         chkIncluirPlanAdd.Enabled = False
      End If
   End Sub

   Public Overrides Function ToString() As String
      Return "Gestión: " & clsAppInfo.Gestion & "; Al " & dtpFechaFin.Text & "; Moneda : " & cboMoneda.Text & "; C.C.: " & cboCentroCosto.Text & "; Suc: " & cboSucursal.Text & "; Nivel: " & dudNivel.Text & "; Tipo Asiento: " & cboTipoAsiento.Text & "; Incluir A.A.: " & If(chkIncluirPlanAdd.Checked, "Sí", "No") & "; Totalizar: " & If(chkTotalizar.Checked, "Sí", "No") & "; Comparativo por Mes: " & If(chkPorMes.Checked, "Sí", "No") & "; Mostrar Resultado: " & If(chkMostrarResultado.Checked, "Sí", "No") & If(Not String.IsNullOrEmpty(txtTitulo.Text), "; Título: " & txtTitulo.Text, "")
   End Function
End Class
