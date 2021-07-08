Public Class frmDosificaEdit
   Inherits System.Windows.Forms.Form

   Private moDosifica As clsDosifica
   Private moDosificaDet As clsDosificaDet

   Private mlngMaxActividad As Long

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents cboTipoDosifica As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents dudNumeroSFC As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents ebrDosificaDet As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents grdDosificaDet As Janus.Windows.GridEX.GridEX
   Friend WithEvents mnuDosificaDet As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShowDato As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNewDato As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditDato As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDeletedato As System.Windows.Forms.MenuItem
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents cboDosificaLey As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents chkImpDosificaLey As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents General As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents tabImpresion As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents grpImpresion As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkPrintOrigCopia As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents dudNroCopia As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents grbFacturaCompu As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optHojaFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optTicketFac As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtCantItem As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents cboTipoImpresion As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents cboTipoFormImp As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents cboDosificaVenta As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents txtDosificaDes As Janus.Windows.GridEX.EditControls.EditBox
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

   WriteOnly Property DataObject() As clsDosifica
      Set(ByVal Value As clsDosifica)
         moDosifica = Value
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
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
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
   Public WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents cboSucursal As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtNroAutorizacion As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents txtDosificaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtNumeroIni As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNumeroFin As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtLlaveDosifica As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtNumeroActual As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDosificaEdit))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdDosificaDet = New Janus.Windows.GridEX.GridEX
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.General = New Janus.Windows.UI.Tab.UITabPage
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboDosificaVenta = New Janus.Windows.EditControls.UIComboBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.chkImpDosificaLey = New Janus.Windows.EditControls.UICheckBox
      Me.cboDosificaLey = New Janus.Windows.EditControls.UIComboBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.dudNumeroSFC = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.Label9 = New System.Windows.Forms.Label
      Me.cboTipoDosifica = New Janus.Windows.EditControls.UIComboBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.txtNumeroActual = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtLlaveDosifica = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtNumeroFin = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtNumeroIni = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtNroAutorizacion = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label17 = New System.Windows.Forms.Label
      Me.cboSucursal = New Janus.Windows.EditControls.UIComboBox
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtDosificaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.tabImpresion = New Janus.Windows.UI.Tab.UITabPage
      Me.grpImpresion = New Janus.Windows.EditControls.UIGroupBox
      Me.txtDosificaDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.chkPrintOrigCopia = New Janus.Windows.EditControls.UICheckBox
      Me.dudNroCopia = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.Label20 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtCantItem = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.grbFacturaCompu = New Janus.Windows.EditControls.UIGroupBox
      Me.optHojaFac = New Janus.Windows.EditControls.UIRadioButton
      Me.optTicketFac = New Janus.Windows.EditControls.UIRadioButton
      Me.Label21 = New System.Windows.Forms.Label
      Me.cboTipoImpresion = New Janus.Windows.EditControls.UIComboBox
      Me.cboTipoFormImp = New Janus.Windows.EditControls.UIComboBox
      Me.Label22 = New System.Windows.Forms.Label
      Me.ebrDosificaDet = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.mnuDosificaDet = New System.Windows.Forms.ContextMenu
      Me.mnuShowDato = New System.Windows.Forms.MenuItem
      Me.mnuNewDato = New System.Windows.Forms.MenuItem
      Me.mnuEditDato = New System.Windows.Forms.MenuItem
      Me.mnuDeletedato = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdDosificaDet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabMain.SuspendLayout()
      Me.General.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.tabImpresion.SuspendLayout()
      CType(Me.grpImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpImpresion.SuspendLayout()
      CType(Me.grbFacturaCompu, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbFacturaCompu.SuspendLayout()
      CType(Me.ebrDosificaDet, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrDosificaDet.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'ExplorerBarContainerControl4
      '
      Me.ExplorerBarContainerControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdDosificaDet)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(456, 97)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdDosificaDet
      '
      Me.grdDosificaDet.AllowCardSizing = False
      Me.grdDosificaDet.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdDosificaDet.AlternatingColors = True
      Me.grdDosificaDet.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdDosificaDet.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdDosificaDet.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdDosificaDet.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdDosificaDet.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdDosificaDet.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdDosificaDet.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdDosificaDet.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdDosificaDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdDosificaDet.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdDosificaDet.GroupByBoxVisible = False
      Me.grdDosificaDet.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdDosificaDet.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdDosificaDet.Location = New System.Drawing.Point(0, 0)
      Me.grdDosificaDet.Name = "grdDosificaDet"
      Me.grdDosificaDet.RecordNavigator = True
      Me.grdDosificaDet.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdDosificaDet.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdDosificaDet.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdDosificaDet.Size = New System.Drawing.Size(456, 97)
      Me.grdDosificaDet.TabIndex = 14
      Me.grdDosificaDet.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdDosificaDet.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDosificaDet.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdDosificaDet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.tabMain)
      Me.bcgMain.Controls.Add(Me.ebrDosificaDet)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(488, 455)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(8, 4)
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(472, 312)
      Me.tabMain.TabIndex = 162
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.General, Me.tabImpresion})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'General
      '
      Me.General.Controls.Add(Me.grpMain)
      Me.General.Key = "General"
      Me.General.Location = New System.Drawing.Point(1, 21)
      Me.General.Name = "General"
      Me.General.Size = New System.Drawing.Size(470, 290)
      Me.General.TabStop = True
      Me.General.Text = "General"
      '
      'grpMain
      '
      Me.grpMain.BackColor = System.Drawing.Color.Transparent
      Me.grpMain.Controls.Add(Me.cboDosificaVenta)
      Me.grpMain.Controls.Add(Me.Label14)
      Me.grpMain.Controls.Add(Me.chkImpDosificaLey)
      Me.grpMain.Controls.Add(Me.cboDosificaLey)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Controls.Add(Me.dudNumeroSFC)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.cboTipoDosifica)
      Me.grpMain.Controls.Add(Me.Label8)
      Me.grpMain.Controls.Add(Me.txtNumeroActual)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.txtLlaveDosifica)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.dtpFechaFin)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.txtNumeroFin)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.txtNumeroIni)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.txtNroAutorizacion)
      Me.grpMain.Controls.Add(Me.Label17)
      Me.grpMain.Controls.Add(Me.cboSucursal)
      Me.grpMain.Controls.Add(Me.dtpFechaIni)
      Me.grpMain.Controls.Add(Me.txtDosificaId)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(3, -1)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(460, 285)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboDosificaVenta
      '
      Me.cboDosificaVenta.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboDosificaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboDosificaVenta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDosificaVenta.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDosificaVenta.Location = New System.Drawing.Point(328, 64)
      Me.cboDosificaVenta.Name = "cboDosificaVenta"
      Me.cboDosificaVenta.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboDosificaVenta.Size = New System.Drawing.Size(124, 20)
      Me.cboDosificaVenta.TabIndex = 4
      Me.cboDosificaVenta.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label14.Location = New System.Drawing.Point(248, 68)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(80, 16)
      Me.Label14.TabIndex = 229
      Me.Label14.Text = "Dosificación"
      '
      'chkImpDosificaLey
      '
      Me.chkImpDosificaLey.BackColor = System.Drawing.Color.Transparent
      Me.chkImpDosificaLey.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkImpDosificaLey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkImpDosificaLey.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkImpDosificaLey.Location = New System.Drawing.Point(92, 232)
      Me.chkImpDosificaLey.Name = "chkImpDosificaLey"
      Me.chkImpDosificaLey.Size = New System.Drawing.Size(17, 20)
      Me.chkImpDosificaLey.TabIndex = 13
      Me.chkImpDosificaLey.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboDosificaLey
      '
      Me.cboDosificaLey.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboDosificaLey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboDosificaLey.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDosificaLey.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDosificaLey.Location = New System.Drawing.Point(116, 232)
      Me.cboDosificaLey.Name = "cboDosificaLey"
      Me.cboDosificaLey.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboDosificaLey.Size = New System.Drawing.Size(336, 20)
      Me.cboDosificaLey.TabIndex = 14
      Me.cboDosificaLey.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 236)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 227
      Me.Label12.Text = "Mensaje 1"
      '
      'dudNumeroSFC
      '
      Me.dudNumeroSFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudNumeroSFC.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudNumeroSFC.Location = New System.Drawing.Point(116, 112)
      Me.dudNumeroSFC.Maximum = 10
      Me.dudNumeroSFC.Name = "dudNumeroSFC"
      Me.dudNumeroSFC.Size = New System.Drawing.Size(124, 20)
      Me.dudNumeroSFC.TabIndex = 6
      Me.dudNumeroSFC.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudNumeroSFC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 116)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 225
      Me.Label9.Text = "SFC"
      '
      'cboTipoDosifica
      '
      Me.cboTipoDosifica.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoDosifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoDosifica.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoDosifica.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoDosifica.Location = New System.Drawing.Point(116, 64)
      Me.cboTipoDosifica.Name = "cboTipoDosifica"
      Me.cboTipoDosifica.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoDosifica.Size = New System.Drawing.Size(124, 20)
      Me.cboTipoDosifica.TabIndex = 3
      Me.cboTipoDosifica.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label8.Location = New System.Drawing.Point(8, 68)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 223
      Me.Label8.Text = "Tipo Dosifica."
      '
      'txtNumeroActual
      '
      Me.txtNumeroActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNumeroActual.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNumeroActual.FormatString = "##################"
      Me.txtNumeroActual.Location = New System.Drawing.Point(116, 184)
      Me.txtNumeroActual.MaxLength = 18
      Me.txtNumeroActual.Name = "txtNumeroActual"
      Me.txtNumeroActual.Size = New System.Drawing.Size(124, 20)
      Me.txtNumeroActual.TabIndex = 10
      Me.txtNumeroActual.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNumeroActual.Value = CType(0, Long)
      Me.txtNumeroActual.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtNumeroActual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 188)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 221
      Me.Label5.Text = "Número Actual"
      '
      'txtLlaveDosifica
      '
      Me.txtLlaveDosifica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtLlaveDosifica.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtLlaveDosifica.Location = New System.Drawing.Point(116, 136)
      Me.txtLlaveDosifica.MaxLength = 100
      Me.txtLlaveDosifica.Name = "txtLlaveDosifica"
      Me.txtLlaveDosifica.Size = New System.Drawing.Size(336, 20)
      Me.txtLlaveDosifica.TabIndex = 7
      Me.txtLlaveDosifica.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtLlaveDosifica.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 140)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 219
      Me.Label2.Text = "Llave Dosifica."
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(116, 256)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(336, 20)
      Me.cboEstado.TabIndex = 15
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 260)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 217
      Me.Label4.Text = "Estado"
      '
      'dtpFechaFin
      '
      Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaFin.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaFin.DropDownCalendar.FirstMonth = New Date(2008, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.DropDownCalendar.Name = ""
      Me.dtpFechaFin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFechaFin.Location = New System.Drawing.Point(340, 208)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(112, 20)
      Me.dtpFechaFin.TabIndex = 12
      Me.dtpFechaFin.Value = New Date(2016, 2, 4, 0, 0, 0, 0)
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(252, 212)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(84, 16)
      Me.Label7.TabIndex = 216
      Me.Label7.Text = "Fecha Final"
      '
      'txtNumeroFin
      '
      Me.txtNumeroFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNumeroFin.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNumeroFin.FormatString = "##################"
      Me.txtNumeroFin.Location = New System.Drawing.Point(340, 160)
      Me.txtNumeroFin.MaxLength = 18
      Me.txtNumeroFin.Name = "txtNumeroFin"
      Me.txtNumeroFin.Size = New System.Drawing.Size(112, 20)
      Me.txtNumeroFin.TabIndex = 9
      Me.txtNumeroFin.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNumeroFin.Value = CType(0, Long)
      Me.txtNumeroFin.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtNumeroFin.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(252, 164)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(84, 16)
      Me.Label6.TabIndex = 214
      Me.Label6.Text = "Número Final"
      '
      'txtNumeroIni
      '
      Me.txtNumeroIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNumeroIni.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNumeroIni.FormatString = "##################"
      Me.txtNumeroIni.Location = New System.Drawing.Point(116, 160)
      Me.txtNumeroIni.MaxLength = 18
      Me.txtNumeroIni.Name = "txtNumeroIni"
      Me.txtNumeroIni.Size = New System.Drawing.Size(124, 20)
      Me.txtNumeroIni.TabIndex = 8
      Me.txtNumeroIni.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNumeroIni.Value = CType(0, Long)
      Me.txtNumeroIni.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtNumeroIni.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 164)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 212
      Me.Label3.Text = "Número Inicial"
      '
      'txtNroAutorizacion
      '
      Me.txtNroAutorizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNroAutorizacion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroAutorizacion.FormatString = "###############"
      Me.txtNroAutorizacion.Location = New System.Drawing.Point(116, 88)
      Me.txtNroAutorizacion.MaxLength = 15
      Me.txtNroAutorizacion.Name = "txtNroAutorizacion"
      Me.txtNroAutorizacion.Size = New System.Drawing.Size(124, 20)
      Me.txtNroAutorizacion.TabIndex = 5
      Me.txtNroAutorizacion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroAutorizacion.Value = CType(0, Long)
      Me.txtNroAutorizacion.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int64
      Me.txtNroAutorizacion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(8, 92)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(104, 16)
      Me.Label17.TabIndex = 210
      Me.Label17.Text = "Nro Autorizacion"
      '
      'cboSucursal
      '
      Me.cboSucursal.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSucursal.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboSucursal.Location = New System.Drawing.Point(116, 40)
      Me.cboSucursal.Name = "cboSucursal"
      Me.cboSucursal.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboSucursal.Size = New System.Drawing.Size(336, 20)
      Me.cboSucursal.TabIndex = 2
      Me.cboSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'dtpFechaIni
      '
      Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaIni.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaIni.DropDownCalendar.FirstMonth = New Date(2008, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.DropDownCalendar.Name = ""
      Me.dtpFechaIni.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFechaIni.Location = New System.Drawing.Point(116, 208)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaIni.TabIndex = 11
      Me.dtpFechaIni.Value = New Date(2016, 2, 4, 0, 0, 0, 0)
      Me.dtpFechaIni.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtDosificaId
      '
      Me.txtDosificaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDosificaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDosificaId.Location = New System.Drawing.Point(116, 16)
      Me.txtDosificaId.Name = "txtDosificaId"
      Me.txtDosificaId.ReadOnly = True
      Me.txtDosificaId.Size = New System.Drawing.Size(124, 20)
      Me.txtDosificaId.TabIndex = 1
      Me.txtDosificaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDosificaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 212)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 194
      Me.Label10.Text = "Fecha Inicial"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 20)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(104, 16)
      Me.Label11.TabIndex = 193
      Me.Label11.Text = "ID"
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 206
      Me.Label1.Text = "Sucursal"
      '
      'tabImpresion
      '
      Me.tabImpresion.Controls.Add(Me.grpImpresion)
      Me.tabImpresion.Key = "Impresiones"
      Me.tabImpresion.Location = New System.Drawing.Point(1, 21)
      Me.tabImpresion.Name = "tabImpresion"
      Me.tabImpresion.Size = New System.Drawing.Size(470, 290)
      Me.tabImpresion.TabStop = True
      Me.tabImpresion.Text = "Impresiones"
      '
      'grpImpresion
      '
      Me.grpImpresion.BackColor = System.Drawing.Color.Transparent
      Me.grpImpresion.Controls.Add(Me.txtDosificaDes)
      Me.grpImpresion.Controls.Add(Me.Label15)
      Me.grpImpresion.Controls.Add(Me.chkPrintOrigCopia)
      Me.grpImpresion.Controls.Add(Me.dudNroCopia)
      Me.grpImpresion.Controls.Add(Me.Label20)
      Me.grpImpresion.Controls.Add(Me.Label13)
      Me.grpImpresion.Controls.Add(Me.txtCantItem)
      Me.grpImpresion.Controls.Add(Me.grbFacturaCompu)
      Me.grpImpresion.Controls.Add(Me.Label21)
      Me.grpImpresion.Controls.Add(Me.cboTipoImpresion)
      Me.grpImpresion.Controls.Add(Me.cboTipoFormImp)
      Me.grpImpresion.Controls.Add(Me.Label22)
      Me.grpImpresion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpImpresion.Location = New System.Drawing.Point(7, 4)
      Me.grpImpresion.Name = "grpImpresion"
      Me.grpImpresion.Size = New System.Drawing.Size(457, 280)
      Me.grpImpresion.TabIndex = 13
      Me.grpImpresion.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtDosificaDes
      '
      Me.txtDosificaDes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtDosificaDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDosificaDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDosificaDes.Location = New System.Drawing.Point(124, 148)
      Me.txtDosificaDes.MaxLength = 255
      Me.txtDosificaDes.Multiline = True
      Me.txtDosificaDes.Name = "txtDosificaDes"
      Me.txtDosificaDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtDosificaDes.Size = New System.Drawing.Size(308, 50)
      Me.txtDosificaDes.TabIndex = 6
      Me.txtDosificaDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDosificaDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 152)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 287
      Me.Label15.Text = "Descripción"
      '
      'chkPrintOrigCopia
      '
      Me.chkPrintOrigCopia.BackColor = System.Drawing.Color.Transparent
      Me.chkPrintOrigCopia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkPrintOrigCopia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkPrintOrigCopia.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkPrintOrigCopia.Location = New System.Drawing.Point(8, 96)
      Me.chkPrintOrigCopia.Name = "chkPrintOrigCopia"
      Me.chkPrintOrigCopia.Size = New System.Drawing.Size(130, 16)
      Me.chkPrintOrigCopia.TabIndex = 4
      Me.chkPrintOrigCopia.Text = "Leyenda Org/Copia"
      Me.chkPrintOrigCopia.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'dudNroCopia
      '
      Me.dudNroCopia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudNroCopia.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudNroCopia.Location = New System.Drawing.Point(124, 68)
      Me.dudNroCopia.Maximum = 5
      Me.dudNroCopia.Minimum = 1
      Me.dudNroCopia.Name = "dudNroCopia"
      Me.dudNroCopia.Size = New System.Drawing.Size(136, 20)
      Me.dudNroCopia.TabIndex = 3
      Me.dudNroCopia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudNroCopia.Value = 1
      Me.dudNroCopia.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label20
      '
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.Location = New System.Drawing.Point(8, 124)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(96, 16)
      Me.Label20.TabIndex = 190
      Me.Label20.Text = "Cantidad Item"
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(8, 72)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(104, 16)
      Me.Label13.TabIndex = 285
      Me.Label13.Text = "Nro. Copias"
      '
      'txtCantItem
      '
      Me.txtCantItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCantItem.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCantItem.Location = New System.Drawing.Point(124, 120)
      Me.txtCantItem.Name = "txtCantItem"
      Me.txtCantItem.Size = New System.Drawing.Size(124, 20)
      Me.txtCantItem.TabIndex = 5
      Me.txtCantItem.Text = "0"
      Me.txtCantItem.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCantItem.Value = 0
      Me.txtCantItem.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtCantItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'grbFacturaCompu
      '
      Me.grbFacturaCompu.BackColor = System.Drawing.Color.Transparent
      Me.grbFacturaCompu.Controls.Add(Me.optHojaFac)
      Me.grbFacturaCompu.Controls.Add(Me.optTicketFac)
      Me.grbFacturaCompu.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grbFacturaCompu.Location = New System.Drawing.Point(8, 224)
      Me.grbFacturaCompu.Name = "grbFacturaCompu"
      Me.grbFacturaCompu.Size = New System.Drawing.Size(238, 48)
      Me.grbFacturaCompu.TabIndex = 7
      Me.grbFacturaCompu.Visible = False
      Me.grbFacturaCompu.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'optHojaFac
      '
      Me.optHojaFac.BackColor = System.Drawing.Color.Transparent
      Me.optHojaFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optHojaFac.Checked = True
      Me.optHojaFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optHojaFac.Location = New System.Drawing.Point(139, 16)
      Me.optHojaFac.Name = "optHojaFac"
      Me.optHojaFac.Size = New System.Drawing.Size(93, 16)
      Me.optHojaFac.TabIndex = 9
      Me.optHojaFac.TabStop = True
      Me.optHojaFac.Text = "Hoja Normal"
      Me.optHojaFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optTicketFac
      '
      Me.optTicketFac.BackColor = System.Drawing.Color.Transparent
      Me.optTicketFac.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.optTicketFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optTicketFac.Location = New System.Drawing.Point(54, 16)
      Me.optTicketFac.Name = "optTicketFac"
      Me.optTicketFac.Size = New System.Drawing.Size(71, 16)
      Me.optTicketFac.TabIndex = 8
      Me.optTicketFac.Text = "Tickets"
      Me.optTicketFac.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label21
      '
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label21.Location = New System.Drawing.Point(8, 24)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(104, 16)
      Me.Label21.TabIndex = 272
      Me.Label21.Text = "Impresión"
      '
      'cboTipoImpresion
      '
      Me.cboTipoImpresion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoImpresion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoImpresion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoImpresion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoImpresion.Location = New System.Drawing.Point(124, 20)
      Me.cboTipoImpresion.Name = "cboTipoImpresion"
      Me.cboTipoImpresion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoImpresion.Size = New System.Drawing.Size(136, 20)
      Me.cboTipoImpresion.TabIndex = 1
      Me.cboTipoImpresion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cboTipoFormImp
      '
      Me.cboTipoFormImp.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFormImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoFormImp.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFormImp.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoFormImp.Location = New System.Drawing.Point(124, 44)
      Me.cboTipoFormImp.Name = "cboTipoFormImp"
      Me.cboTipoFormImp.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoFormImp.Size = New System.Drawing.Size(136, 20)
      Me.cboTipoFormImp.TabIndex = 2
      Me.cboTipoFormImp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.Location = New System.Drawing.Point(8, 48)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(112, 16)
      Me.Label22.TabIndex = 283
      Me.Label22.Text = "Formato Impresión"
      '
      'ebrDosificaDet
      '
      Me.ebrDosificaDet.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrDosificaDet.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 98
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrDosificaDet.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrDosificaDet.GroupSeparation = 4
      Me.ebrDosificaDet.Location = New System.Drawing.Point(8, 320)
      Me.ebrDosificaDet.Name = "ebrDosificaDet"
      Me.ebrDosificaDet.Size = New System.Drawing.Size(472, 130)
      Me.ebrDosificaDet.TabIndex = 13
      Me.ebrDosificaDet.Text = "ExplorerBar2"
      Me.ebrDosificaDet.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrDosificaDet.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDosificaDet.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrDosificaDet.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
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
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Separator2, Me.Exit1, Me.Separator3})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(161, 28)
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
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
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
      Me.TopRebar1.Size = New System.Drawing.Size(488, 28)
      '
      'mnuDosificaDet
      '
      Me.mnuDosificaDet.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShowDato, Me.mnuNewDato, Me.mnuEditDato, Me.mnuDeletedato})
      '
      'mnuShowDato
      '
      Me.mnuShowDato.Index = 0
      Me.mnuShowDato.Text = "Consultar"
      '
      'mnuNewDato
      '
      Me.mnuNewDato.Index = 1
      Me.mnuNewDato.Text = "Nuevo"
      '
      'mnuEditDato
      '
      Me.mnuEditDato.Index = 2
      Me.mnuEditDato.Text = "Editar"
      '
      'mnuDeletedato
      '
      Me.mnuDeletedato.Index = 3
      Me.mnuDeletedato.Text = "Eliminar"
      '
      'frmDosificaEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.Beige
      Me.ClientSize = New System.Drawing.Size(488, 483)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmDosificaEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Dosifica Edit"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdDosificaDet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabMain.ResumeLayout(False)
      Me.General.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      Me.tabImpresion.ResumeLayout(False)
      CType(Me.grpImpresion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpImpresion.ResumeLayout(False)
      Me.grpImpresion.PerformLayout()
      CType(Me.grbFacturaCompu, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbFacturaCompu.ResumeLayout(False)
      CType(Me.ebrDosificaDet, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrDosificaDet.ResumeLayout(False)
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
               mlngID = moDosifica.DosificaId
               mboolChanged = True

               'If mboolAdding Then
               '   mboolAdding = False
               '   mboolEditing = True

               '   Call grdDosificaDetLoad()
               'Else
               Me.Close()
               ' End If
            End If

         Case "Exit"
            Me.Close()

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmDosificaEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmDosificaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Dosificación"
         Else
            Me.Text = "Editar Dosificación"
         End If
      Else
         Me.Text = "Nueva Dosificación"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moDosifica
         txtDosificaId.Text = ToStr(.DosificaId)
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)
         cboTipoDosifica.SelectedIndex = ListFindItem(cboTipoDosifica, .TipoDosificaId)
         cboDosificaVenta.SelectedIndex = ListFindItem(cboDosificaVenta, .DosificaVentaId)
         Call DosificaVentaFind(.DosificaVentaId)
         txtNroAutorizacion.Text = ToStr(.NroAutorizacion)
         dudNumeroSFC.Value = ToLong(.NumeroSFC)
         txtLlaveDosifica.Text = ToStr(.LlaveDosifica)
         txtNumeroIni.Text = ToStr(.NumeroIni)
         txtNumeroFin.Text = ToStr(.NumeroFin)
         txtNumeroActual.Text = ToStr(.NumeroActual)
         dtpFechaIni.Text = .FechaIni
         dtpFechaFin.Text = .FechaFin
         cboDosificaLey.SelectedIndex = ListFindItem(cboDosificaLey, .DosificaLeyId)
         chkImpDosificaLey.Checked = ToBoolean(.ImpDosificaLey)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         txtCantItem.Text = ToDecimal(.CantItem)
         cboTipoImpresion.SelectedIndex = ListFindItem(cboTipoImpresion, .TipoImpresionId)
         dudNroCopia.Value = ToLong(.NroCopia)
         chkPrintOrigCopia.Checked = ToBoolean(.PrintOrigCopia)

         cboTipoFormImp.SelectedIndex = ListFindItem(cboTipoFormImp, .TipoFormImpId)
         txtDosificaDes.Text = ToStr(.DosificaDes)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Dosificación"
               .VMOld.ToShowOpe()
            End If
         End If
      End With

      Call grdDosificaDetLoad()
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsDosificaVM)
      oVM = New clsDosificaVM

      With oVM
         .DosificaId = moDosifica.DosificaId
         .EmpresaId = moDosifica.EmpresaId
         .SucursalId = moDosifica.SucursalId
         .SucursalDes = cboSucursal.Text
         .TipoDosificaId = moDosifica.TipoDosificaId
         .TipoDosificaDes = cboTipoDosifica.Text
         .NroAutorizacion = moDosifica.NroAutorizacion
         .LlaveDosifica = moDosifica.LlaveDosifica
         .NumeroSFC = moDosifica.NumeroSFC
         .NumeroIni = moDosifica.NumeroIni
         .NumeroFin = moDosifica.NumeroFin
         .NumeroActual = moDosifica.NumeroActual
         .FechaIni = dtpFechaIni.Text
         .FechaFin = dtpFechaFin.Text
         .DosificaLeyId = moDosifica.DosificaLeyId
         .DosificaLeyDes = cboDosificaLey.Text
         .ImpDosificaLey = ToByte(chkImpDosificaLey.Checked)
         .TipoImpresionId = moDosifica.TipoImpresionId
         .TipoImpresionDes = cboTipoImpresion.Text
         .TipoFormImpId = moDosifica.TipoFormImpId
         .TipoFormImpDes = cboTipoFormImp.Text
         .NroCopia = moDosifica.NroCopia
         .PrintOrigCopia = ToByte(chkPrintOrigCopia.Checked)
         .CantItem = moDosifica.CantItem
         .DosificaVentaId = moDosifica.DosificaVentaId
         .DosificaVentaDes = cboDosificaVenta.Text
         .EstadoId = moDosifica.EstadoId
         .EstadoDes = ToStr(cboEstado.Text)

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moDosifica
         txtDosificaId.Text = String.Empty
         cboSucursal.SelectedIndex = ListFindItem(cboSucursal, .SucursalId)
         cboTipoDosifica.SelectedIndex = ListFindItem(cboTipoDosifica, .TipoDosificaId)
         cboDosificaVenta.SelectedIndex = ListFindItem(cboDosificaVenta, .DosificaVentaId)
         Call DosificaVentaFind(.DosificaVentaId)
         dudNumeroSFC.Value = ToLong(.NumeroSFC)
         txtNumeroIni.Text = ToStr(.NumeroIni)
         txtNumeroFin.Text = ToStr(.NumeroFin)

         txtNroAutorizacion.Text = String.Empty
         txtLlaveDosifica.Text = String.Empty
         txtNumeroActual.Text = String.Empty
         dtpFechaIni.Text = String.Empty
         dtpFechaFin.Text = String.Empty

         cboDosificaLey.SelectedIndex = ListFindItem(cboDosificaLey, .DosificaLeyId)
         chkImpDosificaLey.Checked = ToBoolean(.ImpDosificaLey)
         cboTipoImpresion.SelectedIndex = ListFindItem(cboTipoImpresion, .TipoImpresionId)
         txtCantItem.Text = ToDecimal(.CantItem)
         dudNroCopia.Value = ToLong(.NroCopia)
         chkPrintOrigCopia.Checked = ToBoolean(.PrintOrigCopia)
         cboTipoFormImp.SelectedIndex = ListFindItem(cboTipoFormImp, .TipoFormImpId)
         txtDosificaDes.Text = ToStr(.DosificaDes)

         cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)

         Call grdDosificaDetLoad()

         .DosificaId = 0
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtDosificaId.ReadOnly = True
      cboSucursal.ReadOnly = True
      cboTipoDosifica.ReadOnly = True
      cboDosificaVenta.ReadOnly = True
      txtNroAutorizacion.ReadOnly = True
      dudNumeroSFC.ReadOnly = True
      txtLlaveDosifica.ReadOnly = True
      txtNumeroIni.ReadOnly = True
      txtNumeroFin.ReadOnly = True
      txtNumeroActual.ReadOnly = True
      dtpFechaIni.ReadOnly = True
      dtpFechaFin.ReadOnly = True
      cboDosificaLey.ReadOnly = True
      chkImpDosificaLey.Enabled = False
      cboEstado.ReadOnly = True

      cboTipoFormImp.ReadOnly = True
      cboTipoImpresion.ReadOnly = True
      dudNroCopia.ReadOnly = True
      chkPrintOrigCopia.Enabled = False
      txtCantItem.ReadOnly = True
      txtDosificaDes.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moDosifica
         If Not mboolAdding Then
            .DosificaId = ToLong(txtDosificaId.Text)
         End If

         .SucursalId = ListPosition(cboSucursal, cboSucursal.SelectedIndex)
         .TipoDosificaId = ListPosition(cboTipoDosifica, cboTipoDosifica.SelectedIndex)
         .NroAutorizacion = ToStr(txtNroAutorizacion.Text)
         .NumeroSFC = ToLong(dudNumeroSFC.Value)
         .LlaveDosifica = ToStr(txtLlaveDosifica.Text)
         .NumeroIni = ToLong(txtNumeroIni.Text)
         .NumeroFin = ToLong(txtNumeroFin.Text)
         .NumeroActual = ToLong(txtNumeroActual.Text)
         .FechaIni = ToDate(dtpFechaIni.Value)
         .FechaFin = ToDate(dtpFechaFin.Value)
         .DosificaLeyId = ListPosition(cboDosificaLey, cboDosificaLey.SelectedIndex)
         .ImpDosificaLey = ToBoolean(chkImpDosificaLey.Checked)
         .DosificaVentaId = ListPosition(cboDosificaVenta, cboDosificaVenta.SelectedIndex)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

         .TipoImpresionId = ListPosition(cboTipoImpresion, cboTipoImpresion.SelectedIndex)
         .TipoFormImpId = ListPosition(cboTipoFormImp, cboTipoFormImp.SelectedIndex)
         .NroCopia = ToLong(dudNroCopia.Value)
         .PrintOrigCopia = ToBoolean(chkPrintOrigCopia.Checked)
         .CantItem = ToDecimal(txtCantItem.Text)
         .DosificaDes = ToStr(txtDosificaDes.Text)

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
               If DataAdd() Then
                  txtDosificaId.Text = ToStr(moDosifica.DosificaId)
                  DataSave = True
               End If
            Else
               DataSave = DataUpdate()
            End If

            If DataSave Then
               Call grdmainSave()
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

         If moDosifica.Insert() Then
            ''mboolAdding = False
            DataAdd = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moDosifica.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If (moDosifica.NumeroActual + 1) < moDosifica.NumeroIni Then
         strMsg &= "El Número Actual es Inferior al Número Inicial" & vbCrLf

      ElseIf moDosifica.NumeroActual > moDosifica.NumeroFin Then
         strMsg &= "El Número Actual es Superior al Número Final" & vbCrLf
      End If

      If dtpFechaIni.Value >= dtpFechaFin.Value Then
         strMsg &= "La Fecha Final Debe Ser Mayor a la Fecha Inicial" & vbCrLf
      End If

      If moDosifica.TipoDosificaId = 2 Then
         If moDosifica.TipoImpresionId = 0 Then
            strMsg &= "Tipo de Impresión Inválida" & vbCrLf
         End If

         If moDosifica.TipoFormImpId = 0 Then
            strMsg &= "Formato de Impresión Inválida" & vbCrLf
         End If

         If moDosifica.NroCopia <= 0 Then
            strMsg &= "Nro. de Copias de Impresión Inválida" & vbCrLf
         End If
      End If

      If grdDosificaDet.RowCount <= 0 Then
         strMsg &= "Dosificación sin Actividades" + vbCrLf
      Else
         If moDosifica.EstadoId = clsEstado.ABIERTO Then
            If moDosifica.DosificaVentaId <> clsDosificaVenta.PTO_VENTA Then
               If Not clsAppInfo.AplicarDosificaVend Then
                  If ExisteDosificaAbierta() Then
                     strMsg &= "Existe una Dosificación abierta de la misma Sucursal y con las mismas Actividades" + vbCrLf
                  End If
               End If
            End If
         End If
      End If

      'If mboolEditing Then
      '   If grdDosificaDet.RowCount <= 0 Then
      '      strMsg &= "Dosificación sin Actividades" + vbCrLf
      '   Else
      '      If moDosifica.EstadoId = 11 Then
      '         If moDosifica.DosificaVentaId <> clsDosificaVenta.PTO_VENTA Then
      '            If Not clsAppInfo.AplicarDosificaVend Then
      '               If ExisteDosificaAbierta() Then
      '                  strMsg &= "Existe una Dosificación abierta de la misma Sucursal y con las mismas Actividades" + vbCrLf
      '               End If
      '            End If
      '         End If
      '      End If
      '   End If
      'End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      moDosificaDet = New clsDosificaDet(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboSucursalLoad()
      Call cboTipoDosificaLoad()
      Call cboEstadoLoad()
      Call cboDosificaLeyLoad()
      Call cboTipoImpresionLoad()
      Call cboDosificaVentaLoad()
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
            .EmpresaId = moDosifica.EmpresaId

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

   Private Sub cboTipoDosificaLoad()
      Dim oTipoDosifica As New clsTipoDosifica(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoDosifica.Items.Clear()

      Try
         With oTipoDosifica
            .SelectFilter = clsTipoDosifica.SelectFilters.ListBox
            .OrderByFilter = clsTipoDosifica.OrderByFilters.TipoDosificaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoDosificaId, .TipoDosificaDes)
                  cboTipoDosifica.Items.Add(oItem)

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoDosifica.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboDosificaVentaLoad()
      Dim oDosificaVenta As New clsDosificaVenta(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboDosificaVenta.Items.Clear()

      Try
         With oDosificaVenta
            .SelectFilter = clsDosificaVenta.SelectFilters.ListBox
            .OrderByFilter = clsDosificaVenta.OrderByFilters.DosificaVentaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.DosificaVentaId, .DosificaVentaDes)
                  cboDosificaVenta.Items.Add(oItem)

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosificaVenta.Dispose()
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

   Private Sub cboDosificaLeyLoad()
      Dim oDosificaLey As New clsDosificaLey(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboDosificaLey.Items.Clear()

      Try
         With oDosificaLey
            .SelectFilter = clsDosificaLey.SelectFilters.ListBox
            .OrderByFilter = clsDosificaLey.OrderByFilters.DosificaLeyDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.DosificaLeyId, .DosificaLeyDes)
                  cboDosificaLey.Items.Add(oItem)

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosificaLey.Dispose()
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

   Private Sub cboTipoFormImpLoad(ByVal lngTipoImpresionId As Long)
      Dim oTipoFormImp As New clsTipoFormImp(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoFormImp.Items.Clear()
      cboTipoFormImp.Text = ""

      Try
         With oTipoFormImp
            .SelectFilter = clsTipoFormImp.SelectFilters.ListBox
            .WhereFilter = clsTipoFormImp.WhereFilters.AppId_TipoDocId
            .OrderByFilter = clsTipoFormImp.OrderByFilters.TipoFormImpDes
            .AppId = clsApp.VENTAS
            .TipoDocumentoId = clsTipoVenta.FACTURA
            .TipoImpresionId = lngTipoImpresionId
            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoFormImpId, .TipoFormImpDes)

                  cboTipoFormImp.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoFormImp.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub DosificaVentaFind(ByVal lngDosificaVentaId As Long)
      Dim oDosificaVenta As New clsDosificaVenta(clsAppInfo.ConnectString)
      mlngMaxActividad = 0

      Try
         With oDosificaVenta
            .DosificaVentaId = lngDosificaVentaId

            If .FindByPK Then
               mlngMaxActividad = .MaxActividad
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosificaVenta.Dispose()

      End Try
   End Sub

   Private Sub cboTipoDosifica_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoDosifica.SelectedIndexChanged
      If cboTipoDosifica.Tag <> cboTipoDosifica.Text Then
         cboTipoDosifica.Tag = cboTipoDosifica.Text

         If mboolAdding Or mboolEditing Then
            Dim lngTipoDosificaId As Long = ListPosition(cboTipoDosifica, cboTipoDosifica.SelectedIndex)

            If lngTipoDosificaId = 1 Then 'Manual
               dudNumeroSFC.Value = 0
               dudNumeroSFC.ReadOnly = True

               txtLlaveDosifica.Text = String.Empty
               txtLlaveDosifica.ReadOnly = True
            End If
         End If
      End If
   End Sub

   Private Sub cboTipoImpresion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoImpresion.SelectedIndexChanged
      Call cboTipoFormImpLoad(ListPosition(cboTipoImpresion, cboTipoImpresion.SelectedIndex))
   End Sub

   Private Sub cboDosificaVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDosificaVenta.SelectedIndexChanged
      If cboDosificaVenta.Tag <> cboDosificaVenta.Text Then
         cboDosificaVenta.Tag = cboDosificaVenta.Text

         If mboolAdding Or mboolEditing Then
            Call DosificaVentaFind(ListPosition(cboDosificaVenta, cboDosificaVenta.SelectedIndex))
         End If
      End If
   End Sub

   Private Function ExisteDosificaAbierta() As Boolean
      Dim oDosifica As New clsDosifica(clsAppInfo.ConnectString)

      Try
         ExisteDosificaAbierta = False

         With oDosifica
            .SelectFilter = clsDosifica.SelectFilters.All
            '.WhereFilter = clsDosifica.WhereFilters.InActividad
            .WhereFilter = clsDosifica.WhereFilters.InActividadAbierta
            .EmpresaId = moDosifica.EmpresaId
            .SucursalId = moDosifica.SucursalId
            .TipoDosificaId = moDosifica.TipoDosificaId
            .DosificaVentaId = moDosifica.DosificaVentaId
            .EstadoId = 11
            .LlaveDosifica = getConsultaActividad()
            .DosificaLeyId = grdDosificaDet.RowCount

            If .Open() Then
               If .DataSet.Tables(.TableName).Select("DosificaId<>" & moDosifica.DosificaId).Count > 0 Then
                  ExisteDosificaAbierta = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosifica.Dispose()

      End Try
   End Function

   Private Function getConsultaActividad() As String

      Dim lngCant As Long
      getConsultaActividad = ""

      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdDosificaDet.GetRows

         lngCant += 1

         If grdDosificaDet.RowCount > lngCant Then
            getConsultaActividad = getConsultaActividad & ToStr(oRow.Cells("TipoActEcoId").Value) & " , "
         Else
            getConsultaActividad = getConsultaActividad & ToStr(oRow.Cells("TipoActEcoId").Value)
         End If
      Next

      If lngCant > 0 Then
         getConsultaActividad = " ( " & getConsultaActividad & " ) "
      End If

   End Function

#Region " DosificaDet "

   Private Sub grdDosificaDetLoad()
      Try
         With moDosificaDet
            .SelectFilter = clsDosificaDet.SelectFilters.Grid
            .WhereFilter = clsDosificaDet.WhereFilters.Grid
            .OrderByFilter = clsDosificaDet.OrderByFilters.Grid
            .EmpresaId = moDosifica.EmpresaId
            .DosificaId = moDosifica.DosificaId

            If .Open() Then
               Call moDataSetInit()

               For Each oRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRowShow(oRow))
               Next

               grdDosificaDet.DataSource = moDataTable.DefaultView '.DataSet.Tables(.TableName).DefaultView
               grdDosificaDet.RetrieveStructure()
               Call grdDosificaDetInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdDosificaDetDataShow()
      Dim oDosificaDet As New clsDosificaDet(clsAppInfo.ConnectString)

      Try
         If grdDosificaDet.RowCount > 0 Then
            With oDosificaDet
               .DosificaDetId = ToLong(grdDosificaDet.GetValue("DosificaDetId"))
               .EmpresaId = moDosifica.EmpresaId
               .DosificaId = ToLong(grdDosificaDet.GetValue("DosificaId"))
               .Orden = ToLong(grdDosificaDet.GetValue("Orden"))
               .TipoActEcoId = ToLong(grdDosificaDet.GetValue("TipoActEcoId"))
               .EstadoId = ToLong(grdDosificaDet.GetValue("EstadoId"))

               Dim frm As New frmDosificaDetEdit

               frm.NewRecord = False
               frm.Editing = False
               frm.DataObject = oDosificaDet

               frm.ShowDialog()
               frm.Dispose()
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosificaDet.Dispose()

      End Try
   End Sub

   Private Sub grdDosificaDetFormNew()
      If grdDosificaDet.GetRows.Count >= mlngMaxActividad Then
         MessageBox.Show("Cantidad de Actividades completada en la Dosificación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Exit Sub
      End If

      Dim frm As New frmDosificaDetEdit
      Dim oDosificaDet As New clsDosificaDet(clsAppInfo.ConnectString)

      Try
         With frm
            .NewRecord = True
            .Editing = False

            oDosificaDet.EmpresaId = moDosifica.EmpresaId
            oDosificaDet.DosificaId = moDosifica.DosificaId

            .DataObject = oDosificaDet
            .ShowDialog()

            If .Changed Then
               moDataTable.Rows.Add(GetRowNew(frm.DataObject))
               'Call grdDosificaDetLoad()
               Call grdDosificaDetFindRow(frm.ID)
            End If

            frm.Dispose()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosificaDet.Dispose()
      End Try
   End Sub

   Private Sub grdDosificaDetDataEdit()
      Dim oDosificaDet As New clsDosificaDet(clsAppInfo.ConnectString)

      Try
         If grdDosificaDet.RowCount > 0 Then
            With oDosificaDet
               .DosificaDetId = ToLong(grdDosificaDet.GetValue("DosificaDetId"))
               .EmpresaId = moDosifica.EmpresaId
               .DosificaId = ToLong(grdDosificaDet.GetValue("DosificaId"))
               .Orden = ToLong(grdDosificaDet.GetValue("Orden"))
               .TipoActEcoId = ToLong(grdDosificaDet.GetValue("TipoActEcoId"))
               .ImpTipoActEco = ToBoolean(grdDosificaDet.GetValue("ImpTipoActEco"))
               .EstadoId = ToLong(grdDosificaDet.GetValue("EstadoId"))

               Dim lngId As Long = ToLong(grdDosificaDet.GetValue("Id"))
               Dim frm As New frmDosificaDetEdit

               frm.NewRecord = False
               frm.Editing = True
               frm.DataObject = oDosificaDet
               frm.ShowDialog()

               If frm.Changed Then
                  Call RowEdit(moDataTable.Rows(grdMainFindRowId(lngId)), frm.DataObject)
                  'Call grdDosificaDetLoad()
                  Call grdDosificaDetFindRow(frm.ID)
               End If

               frm.Dispose()
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosificaDet.Dispose()

      End Try
   End Sub

   Private Sub grdDosificaDetDelete()
      Dim oDosificaDet As New clsDosificaDet(clsAppInfo.ConnectString)

      Try
         If grdDosificaDet.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               If ToStr(grdDosificaDet.GetValue("Estado")) <> "New" Then
                  molistaEliminar.Add(ToLong(grdDosificaDet.GetValue("DosificaDetId")))
               End If
               moDataTable.Rows.RemoveAt(grdDosificaDet.Row)
               grdDosificaDet.RetrieveStructure()
               Call grdDosificaDetInit()
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDosificaDet.Dispose()

      End Try
   End Sub

   Private Sub grdDosificaDetFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdDosificaDet.RootTable.Columns("DosificaDetId")

      grdDosificaDet.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub grdDosificaDetInit()
      With grdDosificaDet
         ebrDosificaDet.Groups(0).Text = "Actividades Económicas"
         .ContextMenu = mnuDosificaDet

         .RootTable.Columns("Id").Visible = False
         .RootTable.Columns("Estado").Visible = False

         .RootTable.Columns("DosificaDetId").Visible = False

         '.RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("DosificaId").Visible = False

         .RootTable.Columns("Orden").Caption = "Orden"
         .RootTable.Columns("Orden").Width = 50
         .RootTable.Columns("Orden").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Orden").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoActEcoId").Visible = False

         .RootTable.Columns("TipoActEcoDes").Caption = "Actividad Económica"
         .RootTable.Columns("TipoActEcoDes").Width = 260
         .RootTable.Columns("TipoActEcoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoActEcoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("ImpTipoActEco").Caption = "Imprimir Actividad"
         .RootTable.Columns("ImpTipoActEco").Width = 50
         .RootTable.Columns("ImpTipoActEco").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("ImpTipoActEco").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 70
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdItemLote_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdDosificaDet.MouseDown
      If e.Button = MouseButtons.Right Then
         If mboolAdding Or mboolEditing Then
            If grdDosificaDet.RowCount > 0 Then
               mnuShowDato.Enabled = True
               mnuNewDato.Enabled = True
               mnuEditDato.Enabled = True
               mnuDeletedato.Enabled = True
            Else
               mnuShowDato.Enabled = False
               mnuNewDato.Enabled = True
               mnuEditDato.Enabled = False
               mnuDeletedato.Enabled = False
            End If
         Else
            mnuShowDato.Enabled = True
            mnuNewDato.Enabled = False
            mnuEditDato.Enabled = False
            mnuDeletedato.Enabled = False
         End If
      End If
   End Sub

   Private Sub grdDosificaDet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDosificaDet.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdDosificaDet.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdDosificaDet.GetRow.Cells(grdDosificaDet.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         If mboolAdding Or mboolEditing Then
            If grdDosificaDet.RowCount > 0 Then
               mnuShowDato.Enabled = True
               mnuNewDato.Enabled = True
               mnuEditDato.Enabled = True
               mnuDeletedato.Enabled = True
            Else
               mnuShowDato.Enabled = False
               mnuNewDato.Enabled = True
               mnuEditDato.Enabled = False
               mnuDeletedato.Enabled = False
            End If
         Else
            mnuShowDato.Enabled = True
            mnuNewDato.Enabled = False
            mnuEditDato.Enabled = False
            mnuDeletedato.Enabled = False
         End If
      End If
   End Sub

   Private Sub mnuShowDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowDato.Click
      Call grdDosificaDetDataShow()
   End Sub

   Private Sub mnuNewDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNewDato.Click
      Call grdDosificaDetFormNew()
   End Sub

   Private Sub mnuEditDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditDato.Click
      Call grdDosificaDetDataEdit()
   End Sub

   Private Sub mnuDeleteDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeletedato.Click
      Call grdDosificaDetDelete()
   End Sub

#End Region

   Private Sub frmDosificaEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If Save.Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moDosifica.DosificaId
                  mboolChanged = True

                  'If mboolAdding Then
                  '   mboolAdding = False
                  '   mboolEditing = True

                  '   Call grdDosificaDetLoad()

                  'Else
                  Me.Close()
                  'End If
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmDosificaEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moDosifica.Dispose()
      moDosificaDet.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub frmDosificaEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
      If mboolEditing Then
         If grdDosificaDet.RowCount = 0 Then
            If MessageBox.Show("Dosificación sin Actividades, no se podrán emitir Facturas" & vbCrLf & "¿Realmente quiere salir de la Edición?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
               e.Cancel = True
            End If
         End If
      End If

   End Sub

#Region "Detalle Dosificacion"
   Private moDataTable As DataTable
   Private molistaEliminar As List(Of Long)

   Private Sub moDataSetInit()
      moDataTable = New DataTable("Detalle")
      moDataTable.Columns.Add("Id", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("DosificaDetId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("DosificaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Orden", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoActEcoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoActEcoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("ImpTipoActEco", Type.GetType("System.Boolean"))
      moDataTable.Columns.Add("EstadoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EstadoDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Estado", Type.GetType("System.String"))

      molistaEliminar = New List(Of Long)
   End Sub

   Private Function GetRowNew(ByVal oDosificaDet As clsDosificaDet) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("Id") = moDataTable.Rows.Count + 1
      oRow("DosificaDetId") = 0
      oRow("DosificaId") = moDosifica.DosificaId
      oRow("Orden") = oDosificaDet.Orden
      oRow("TipoActEcoId") = oDosificaDet.TipoActEcoId
      oRow("TipoActEcoDes") = TipoActEcoDesFind(oDosificaDet.TipoActEcoId)
      oRow("ImpTipoActEco") = oDosificaDet.ImpTipoActEco
      oRow("EstadoId") = oDosificaDet.EstadoId
      oRow("EstadoDes") = EstadoDesFind(oDosificaDet.EstadoId)
      oRow("Estado") = "New"

      Return oRow
   End Function

   Private Sub RowEdit(ByRef oRow As DataRow, ByVal oDosificaDet As clsDosificaDet)
      oRow("Orden") = oDosificaDet.Orden
      oRow("TipoActEcoId") = oDosificaDet.TipoActEcoId
      oRow("TipoActEcoDes") = TipoActEcoDesFind(oDosificaDet.TipoActEcoId)
      oRow("ImpTipoActEco") = oDosificaDet.ImpTipoActEco
      oRow("EstadoId") = oDosificaDet.EstadoId
      oRow("EstadoDes") = EstadoDesFind(oDosificaDet.EstadoId)

      If oRow("Estado") = "Show" Then
         oRow("Estado") = "Edit"
      End If
   End Sub

   Private Function GetRowShow(ByVal orow As DataRow) As DataRow
      Dim oDataRow As DataRow
      oDataRow = moDataTable.NewRow

      oDataRow("Id") = moDataTable.Rows.Count + 1
      oDataRow("Orden") = orow("Orden")
      oDataRow("TipoActEcoId") = orow("TipoActEcoId")
      oDataRow("TipoActEcoDes") = orow("TipoActEcoDes")
      oDataRow("ImpTipoActEco") = orow("ImpTipoActEco")

      If mboolAdding Then 'Duplicar
         oDataRow("Estado") = "New"
         oDataRow("DosificaId") = 0
         oDataRow("DosificaDetId") = 0
         oDataRow("EstadoId") = moDosifica.EstadoId
         oDataRow("EstadoDes") = EstadoDesFind(moDosifica.EstadoId)
      Else
         oDataRow("Estado") = "Show"
         oDataRow("DosificaId") = moDosifica.DosificaId
         oDataRow("DosificaDetId") = orow("DosificaDetId")
         oDataRow("EstadoId") = orow("EstadoId")
         oDataRow("EstadoDes") = orow("EstadoDes")
      End If

      Return oDataRow
   End Function

   Private Function DosificaDetDataAdd() As Boolean
      Try
         DosificaDetDataAdd = False

         If moDosificaDet.Insert() Then
            DosificaDetDataAdd = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DosificaDetDataUpdate() As Boolean
      Try
         DosificaDetDataUpdate = False

         If moDosificaDet.Update() Then
            DosificaDetDataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function EstadoDesFind(ByVal lngEstadoId As Long) As String
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)
      oEstado.EstadoId = lngEstadoId
      oEstado.FindByPK()
      EstadoDesFind = oEstado.EstadoDes
      oEstado.Dispose()
   End Function

   Private Function TipoActEcoDesFind(ByVal lngTipoActEcoId As Long) As String
      Dim oTipoActEco As New clsTipoActEco(clsAppInfo.ConnectString)
      oTipoActEco.TipoActEcoId = lngTipoActEcoId
      oTipoActEco.FindByPK()
      TipoActEcoDesFind = oTipoActEco.TipoActEcoDes
      oTipoActEco.Dispose()
   End Function

   Private Function grdMainFindRowId(ByVal lngID As Long) As Integer
      Dim intRow As Long = 0

      For Each oRow As DataRow In moDataTable.Rows
         If oRow("Id") = lngID Then
            Return intRow
         End If

         intRow += 1
      Next

      Return 0
   End Function

   Private Function grdMainSave() As Boolean
      For Each oRow In moDataTable.Rows
         If oRow("Estado") = "New" Then
            Call grdMainMove(oRow)
            grdMainSave = DosificaDetDataAdd()

         ElseIf oRow("Estado") = "Edit" Then
            Call grdMainMove(oRow)
            grdMainSave = DosificaDetDataUpdate()
         End If
      Next

      For Each lngDosificaDetId In molistaEliminar
         Call DosificaDetDataDelete(lngDosificaDetId)
      Next
   End Function

   Private Function grdMainMove(ByVal oRow As DataRow) As Boolean
      With moDosificaDet
         .DosificaDetId = oRow("DosificaDetId")
         .EmpresaId = moDosifica.EmpresaId
         .DosificaId = moDosifica.DosificaId
         .Orden = oRow("Orden")
         .TipoActEcoId = oRow("TipoActEcoId")
         .ImpTipoActEco = oRow("ImpTipoActEco")
         .EstadoId = oRow("EstadoId")

         If clsAppInfo.RegistrarBitacora Then
            Call DosificaDetToVM(.VMOld, ToLong(oRow("DosificaDetId")))
            Call CloneVMDosificaDet(.VMNew, oRow)
         End If
      End With
   End Function

   Private Sub DosificaDetDataDelete(ByVal lngDosificaDetId As Long)
      Dim oDosificaDet As New clsDosificaDet(clsAppInfo.ConnectString)

      Try
         With oDosificaDet
            .WhereFilter = clsDosificaDet.WhereFilters.PrimaryKey
            .DosificaDetId = lngDosificaDetId

            Call DosificaDetToVM(.VMNew, lngDosificaDetId)
            Call .Delete()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oDosificaDet.Dispose()
      End Try
   End Sub

#End Region

#Region "Bitacora DosificaDet"
   Private Sub CloneVMDosificaDet(ByRef oVM As clsDosificaDetVM, ByVal oRow As DataRow)
      oVM = New clsDosificaDetVM

      With oVM
         .DosificaDetId = ToLong(oRow("DosificaDetId"))
         .DosificaId = ToLong(oRow("DosificaId"))
         .Orden = ToLong(oRow("Orden"))
         .TipoActEcoId = ToLong(oRow("TipoActEcoId"))
         .TipoActEcoDes = ToStr(oRow("TipoActEcoDes"))
         .ImpTipoActEco = ToBoolean(oRow("ImpTipoActEco"))
         .EstadoDes = ToStr(oRow("EstadoDes"))

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DosificaDetToVM(ByRef oVM As clsDosificaDetVM, ByVal lngDosificaDetId As Long)
      oVM = New clsDosificaDetVM

      Dim oDosificaDet As New clsDosificaDet(clsAppInfo.ConnectString)
      oDosificaDet.DosificaDetId = lngDosificaDetId
      oDosificaDet.FindByPK()

      With oVM
         .DosificaDetId = oDosificaDet.DosificaDetId
         .DosificaId = oDosificaDet.DosificaDetId
         .TipoActEcoId = oDosificaDet.TipoActEcoId
         .TipoActEcoDes = TipoActEcoDesFind(oDosificaDet.TipoActEcoId)
         .Orden = oDosificaDet.Orden
         .ImpTipoActEco = oDosificaDet.ImpTipoActEco
         .EstadoId = oDosificaDet.EstadoId
         .EstadoDes = EstadoDesFind(oDosificaDet.EstadoId)

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

#End Region
   
End Class

