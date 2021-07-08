Public Class frmDataBaseOrgEmpresa
   Inherits System.Windows.Forms.Form

   Private mstrDataBaseOrg As String
   Private mstrConnectStringOrg As String
   Private mlngEmpresaId As Long
   Private mstrEmpresaDes As String
   Private mlngGestionId As Long
   Private mlngGestion As Long
   Private mboolRecordar As Boolean

   Private mboolShow As Boolean
   Private mboolChanged As Boolean

   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents cboDataBase As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtServer As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtUser As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Connet1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Sel1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Connet As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Sel As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents chkRecordar As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cboEmpresa As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cboGestion As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtPass As Janus.Windows.GridEX.EditControls.EditBox

   Property ConnectStringOrg() As String
      Get
         Return mstrConnectStringOrg
      End Get
      Set(ByVal value As String)
         mstrConnectStringOrg = value
      End Set
   End Property

   Property DataBaseOrg() As String
      Get
         Return mstrDataBaseOrg
      End Get
      Set(ByVal value As String)
         mstrDataBaseOrg = value
      End Set
   End Property


   Private mboolTodos As Boolean 'agrega el ListItem(Todos) a empresa y Gestion
   Public Property Todos() As Boolean
      Get
         Return mboolTodos
      End Get
      Set(ByVal value As Boolean)
         mboolTodos = value
      End Set
   End Property


   Private mstrServer As String
   Public Property Server() As String
      Get
         Return mstrServer
      End Get
      Set(ByVal value As String)
         mstrServer = value
      End Set
   End Property

   Private mstrUsuario As String
   Public Property Usuario() As String
      Get
         Return mstrUsuario
      End Get
      Set(ByVal value As String)
         mstrUsuario = value
      End Set
   End Property

   Private mstrPassword As String
   Friend WithEvents grpConexion As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpBaseDatos As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents btnConectar As Janus.Windows.EditControls.UIButton
   Public Property Password() As String
      Get
         Return mstrPassword
      End Get
      Set(ByVal value As String)
         mstrPassword = value
      End Set
   End Property

   Private mstrDataBase As String
   Public Property Database() As String
      Get
         Return mstrDataBase
      End Get
      Set(ByVal value As String)
         mstrDataBase = value
      End Set
   End Property

   Public Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get
      Set(ByVal value As Long)
         mlngEmpresaId = value
      End Set
   End Property

   Public Property EmpresaDes() As String
      Get
         Return mstrEmpresaDes
      End Get
      Set(ByVal value As String)
         mstrEmpresaDes = value
      End Set
   End Property

   Public Property GestionId() As Long
      Get
         Return mlngGestionId
      End Get
      Set(ByVal value As Long)
         mlngGestionId = value
      End Set
   End Property

   Public Property Gestion() As Long
      Get
         Return mlngGestion
      End Get
      Set(ByVal value As Long)
         mlngGestion = value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   Public Property Recordar() As Boolean
      Get
         Return mboolRecordar
      End Get
      Set(ByVal value As Boolean)
         mboolRecordar = value
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
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ToolBar As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataBaseOrgEmpresa))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpBaseDatos = New Janus.Windows.EditControls.UIGroupBox
      Me.cboDataBase = New Janus.Windows.EditControls.UIComboBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.grpConexion = New Janus.Windows.EditControls.UIGroupBox
      Me.btnConectar = New Janus.Windows.EditControls.UIButton
      Me.txtServer = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.txtUser = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtPass = New Janus.Windows.GridEX.EditControls.EditBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.chkRecordar = New Janus.Windows.EditControls.UICheckBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.cboGestion = New Janus.Windows.EditControls.UIComboBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.cboEmpresa = New Janus.Windows.EditControls.UIComboBox
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ToolBar = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Connet1 = New Janus.Windows.UI.CommandBars.UICommand("Connect")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Sel1 = New Janus.Windows.UI.CommandBars.UICommand("Sel")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Connet = New Janus.Windows.UI.CommandBars.UICommand("Connect")
      Me.Sel = New Janus.Windows.UI.CommandBars.UICommand("Sel")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpBaseDatos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpBaseDatos.SuspendLayout()
      CType(Me.grpConexion, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpConexion.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpBaseDatos)
      Me.bcgMain.Controls.Add(Me.grpConexion)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(385, 215)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpBaseDatos
      '
      Me.grpBaseDatos.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpBaseDatos.Controls.Add(Me.cboDataBase)
      Me.grpBaseDatos.Controls.Add(Me.Label3)
      Me.grpBaseDatos.Enabled = False
      Me.grpBaseDatos.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpBaseDatos.Location = New System.Drawing.Point(4, 96)
      Me.grpBaseDatos.Name = "grpBaseDatos"
      Me.grpBaseDatos.Size = New System.Drawing.Size(376, 44)
      Me.grpBaseDatos.TabIndex = 1
      Me.grpBaseDatos.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboDataBase
      '
      Me.cboDataBase.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboDataBase.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDataBase.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDataBase.Location = New System.Drawing.Point(108, 16)
      Me.cboDataBase.Name = "cboDataBase"
      Me.cboDataBase.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboDataBase.Size = New System.Drawing.Size(260, 20)
      Me.cboDataBase.TabIndex = 1
      Me.cboDataBase.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 20)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(96, 16)
      Me.Label3.TabIndex = 195
      Me.Label3.Text = "Base de Datos"
      '
      'grpConexion
      '
      Me.grpConexion.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpConexion.Controls.Add(Me.btnConectar)
      Me.grpConexion.Controls.Add(Me.txtServer)
      Me.grpConexion.Controls.Add(Me.Label10)
      Me.grpConexion.Controls.Add(Me.txtUser)
      Me.grpConexion.Controls.Add(Me.Label1)
      Me.grpConexion.Controls.Add(Me.Label2)
      Me.grpConexion.Controls.Add(Me.txtPass)
      Me.grpConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grpConexion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpConexion.Location = New System.Drawing.Point(4, 4)
      Me.grpConexion.Name = "grpConexion"
      Me.grpConexion.Size = New System.Drawing.Size(376, 92)
      Me.grpConexion.TabIndex = 0
      Me.grpConexion.Text = "Conexión al Servidor"
      Me.grpConexion.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'btnConectar
      '
      Me.btnConectar.ActiveFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnConectar.Icon = CType(resources.GetObject("btnConectar.Icon"), System.Drawing.Icon)
      Me.btnConectar.Location = New System.Drawing.Point(252, 60)
      Me.btnConectar.Name = "btnConectar"
      Me.btnConectar.Size = New System.Drawing.Size(116, 24)
      Me.btnConectar.TabIndex = 4
      Me.btnConectar.Text = "Conectar"
      Me.btnConectar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtServer
      '
      Me.txtServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtServer.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtServer.Location = New System.Drawing.Point(108, 16)
      Me.txtServer.MaxLength = 100
      Me.txtServer.Name = "txtServer"
      Me.txtServer.Size = New System.Drawing.Size(260, 20)
      Me.txtServer.TabIndex = 1
      Me.txtServer.Text = "(local)"
      Me.txtServer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtServer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 20)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(96, 16)
      Me.Label10.TabIndex = 189
      Me.Label10.Text = "Servidor"
      '
      'txtUser
      '
      Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtUser.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtUser.Location = New System.Drawing.Point(108, 40)
      Me.txtUser.MaxLength = 50
      Me.txtUser.Name = "txtUser"
      Me.txtUser.Size = New System.Drawing.Size(124, 20)
      Me.txtUser.TabIndex = 2
      Me.txtUser.Text = "sa"
      Me.txtUser.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtUser.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(96, 16)
      Me.Label1.TabIndex = 193
      Me.Label1.Text = "Usuario"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 68)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(96, 16)
      Me.Label2.TabIndex = 194
      Me.Label2.Text = "Contraseña"
      '
      'txtPass
      '
      Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPass.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPass.Location = New System.Drawing.Point(108, 64)
      Me.txtPass.MaxLength = 100
      Me.txtPass.Name = "txtPass"
      Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPass.Size = New System.Drawing.Size(124, 20)
      Me.txtPass.TabIndex = 3
      Me.txtPass.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.chkRecordar)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.cboGestion)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.cboEmpresa)
      Me.grpMain.Enabled = False
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(4, 140)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(376, 68)
      Me.grpMain.TabIndex = 2
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkRecordar
      '
      Me.chkRecordar.BackColor = System.Drawing.Color.Transparent
      Me.chkRecordar.Checked = True
      Me.chkRecordar.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkRecordar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkRecordar.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkRecordar.Location = New System.Drawing.Point(236, 44)
      Me.chkRecordar.Name = "chkRecordar"
      Me.chkRecordar.Size = New System.Drawing.Size(132, 16)
      Me.chkRecordar.TabIndex = 3
      Me.chkRecordar.Text = "Recordar Conexión"
      Me.chkRecordar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(96, 16)
      Me.Label5.TabIndex = 200
      Me.Label5.Text = "Gestión"
      '
      'cboGestion
      '
      Me.cboGestion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.Location = New System.Drawing.Point(108, 40)
      Me.cboGestion.Name = "cboGestion"
      Me.cboGestion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboGestion.Size = New System.Drawing.Size(112, 20)
      Me.cboGestion.TabIndex = 2
      Me.cboGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 20)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(96, 16)
      Me.Label4.TabIndex = 198
      Me.Label4.Text = "Empresa"
      '
      'cboEmpresa
      '
      Me.cboEmpresa.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEmpresa.Location = New System.Drawing.Point(108, 16)
      Me.cboEmpresa.Name = "cboEmpresa"
      Me.cboEmpresa.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEmpresa.Size = New System.Drawing.Size(260, 20)
      Me.cboEmpresa.TabIndex = 1
      Me.cboEmpresa.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.ToolBar})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Exit2, Me.Connet, Me.Sel})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("07079e7f-00da-4c19-a723-59e48c61dabb")
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
      'ToolBar
      '
      Me.ToolBar.CommandManager = Me.cdmMain
      Me.ToolBar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Connet1, Me.Separator1, Me.Sel1, Me.Separator2, Me.Exit1})
      Me.ToolBar.Key = "CommandBar1"
      Me.ToolBar.Location = New System.Drawing.Point(0, 0)
      Me.ToolBar.Name = "ToolBar"
      Me.ToolBar.RowIndex = 0
      Me.ToolBar.Size = New System.Drawing.Size(173, 28)
      Me.ToolBar.Text = "CommandBar1"
      '
      'Connet1
      '
      Me.Connet1.Key = "Connect"
      Me.Connet1.Name = "Connet1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Sel1
      '
      Me.Sel1.Key = "Sel"
      Me.Sel1.Name = "Sel1"
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
      Me.Exit2.ImageIndex = 2
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Connet
      '
      Me.Connet.ImageIndex = 0
      Me.Connet.Key = "Connect"
      Me.Connet.Name = "Connet"
      Me.Connet.Text = "Conectar"
      Me.Connet.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Sel
      '
      Me.Sel.ImageIndex = 1
      Me.Sel.Key = "Sel"
      Me.Sel.Name = "Sel"
      Me.Sel.Text = "Seleccionar"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "Database (Add).ico")
      Me.ilsMain.Images.SetKeyName(1, "Check.ico")
      Me.ilsMain.Images.SetKeyName(2, "")
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
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.ToolBar})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.ToolBar)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(385, 28)
      '
      'frmDataBaseOrgEmpresa
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(385, 243)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Name = "frmDataBaseOrgEmpresa"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Base de Datos Comparativa"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpBaseDatos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpBaseDatos.ResumeLayout(False)
      CType(Me.grpConexion, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpConexion.ResumeLayout(False)
      Me.grpConexion.PerformLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
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
         Case "Sel"
            Call SelectConnection()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub DataBaseOrg_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub DataBaseOrg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ClearMemory()
      Call FormShow()

      Me.Cursor = oCursor
   End Sub

   Private Sub Connect()
      If cboDataBaseLoad(ToStr(txtServer.Text), ToStr(txtUser.Text), ToStr(txtPass.Text)) Then
         'cdmMain.Commands.Item("Connect").Enabled = Janus.Windows.UI.InheritableBoolean.False
         cdmMain.Commands.Item("Sel").Enabled = Janus.Windows.UI.InheritableBoolean.True
         grpBaseDatos.Enabled = True
         cboDataBase.Select()
      Else
         cdmMain.Commands.Item("Sel").Enabled = Janus.Windows.UI.InheritableBoolean.False
         grpBaseDatos.Enabled = False
      End If
   End Sub

   Private Function CheckConnection() As Boolean
      Dim strMessage As String = ""
      CheckConnection = True

      If mboolTodos Then
         If ListPosition(cboEmpresa, cboEmpresa.SelectedIndex) < 0 Then
            strMessage &= "Seleccione la Empresa." & vbCrLf
         End If
         If ListPosition(cboGestion, cboGestion.SelectedIndex) < 0 Then
            strMessage &= "Seleccione la Gestión." & vbCrLf
         End If
      Else
         If ListPosition(cboEmpresa, cboEmpresa.SelectedIndex) <= 0 Then
            strMessage &= "Seleccione la Empresa." & vbCrLf
         End If
         If ListPosition(cboGestion, cboGestion.SelectedIndex) <= 0 Then
            strMessage &= "Seleccione la Gestión." & vbCrLf
         End If
      End If

      If Not DatabaseSelect() Then
         strMessage &= "Seleccione la base de datos comparativa." & vbCrLf
      End If

      If strMessage <> "" Then
         CheckConnection = False
         MessageBox.Show(strMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Function SelectConnection() As Boolean
      'If ListPosition(cboEmpresa, cboEmpresa.SelectedIndex) > 0 Then
      '   If ListPosition(cboGestion, cboGestion.SelectedIndex) > 0 Then
      '      If DatabaseSelect() Then
      Call DataMove()
      If CheckConnection() Then
         Call RecordarConexion()
         mboolChanged = True
         Me.Close()
      End If
      '      Else
      'MessageBox.Show("Seleccione la base datos origen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      '      End If
      '   Else
      'MessageBox.Show("Seleccione la Gestión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      '   End If
      'Else
      'MessageBox.Show("Seleccione la Empresa", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      'End If
   End Function

   Private Sub FormShow()
      If clsAppInfo.Recordar Then
         mstrServer = clsAppInfo.ServerTemp
         mstrUsuario = clsAppInfo.UserTemp
         mstrPassword = clsAppInfo.PassTemp
         mstrDataBase = clsAppInfo.DataBaseTemp
         mlngEmpresaId = clsAppInfo.EmpresaIdTemp
         mlngGestionId = clsAppInfo.GestionIdTemp
         mboolRecordar = clsAppInfo.Recordar
         txtServer.Text = mstrServer
         txtUser.Text = mstrUsuario
         txtPass.Text = mstrPassword

         Call Connect()
         cboDataBase.Text = mstrDataBase
         If DatabaseSelect() Then
            Call cboEmpresaLoad()
            cboEmpresa.SelectedIndex = ListFindItem(cboEmpresa, mlngEmpresaId)
            Call cboGestionLoad(mlngEmpresaId)
            cboGestion.SelectedIndex = ListFindItem(cboGestion, mlngGestionId)
         End If
         chkRecordar.Checked = mboolRecordar
      End If
   End Sub

   Private Sub DataMove()
      mstrServer = txtServer.Text
      mstrUsuario = txtUser.Text
      mstrPassword = txtPass.Text
      mstrDataBase = cboDataBase.Text
      mlngEmpresaId = ListPosition(cboEmpresa, cboEmpresa.SelectedIndex)
      mstrEmpresaDes = cboEmpresa.Text
      mlngGestionId = ListPosition(cboGestion, cboGestion.SelectedIndex)
      mlngGestion = ToLong(cboGestion.Text)
      mboolRecordar = chkRecordar.Checked
   End Sub

   Private Sub RecordarConexion()
      If mboolRecordar Then
         clsAppInfo.ConnectStringTemp = mstrConnectStringOrg
         clsAppInfo.ServerTemp = txtServer.Text
         clsAppInfo.UserTemp = txtUser.Text
         clsAppInfo.PassTemp = txtPass.Text
         clsAppInfo.DataBaseTemp = cboDataBase.Text
         clsAppInfo.EmpresaIdTemp = ListPosition(cboEmpresa, cboEmpresa.SelectedIndex)
         clsAppInfo.EmpresaDesTemp = cboEmpresa.Text
         clsAppInfo.GestionIdTemp = ListPosition(cboGestion, cboGestion.SelectedIndex)
         clsAppInfo.GestionTemp = ToLong(cboGestion.Text)
         clsAppInfo.Recordar = chkRecordar.Checked
      Else
         clsAppInfo.ConnectStringTemp = ""
         clsAppInfo.ServerTemp = ""
         clsAppInfo.UserTemp = ""
         clsAppInfo.PassTemp = ""
         clsAppInfo.DataBaseTemp = ""
         clsAppInfo.EmpresaIdTemp = 0
         clsAppInfo.EmpresaDesTemp = ""
         clsAppInfo.GestionIdTemp = 0
         clsAppInfo.GestionTemp = 0
         clsAppInfo.Recordar = chkRecordar.Checked
      End If
   End Sub

   Private Sub cboEmpresaLoad()
      Dim oEmpresa As New clsEmpresa(mstrConnectStringOrg)
      Dim oItem As clsListItem

      cboEmpresa.Items.Clear()
      cboEmpresa.Text = ""

      Try
         With oEmpresa
            .SelectFilter = clsEmpresa.SelectFilters.ListBox
            .OrderByFilter = clsEmpresa.OrderByFilters.EmpresaDes

            If .Open() Then
               If mboolTodos Then
                  oItem = New clsListItem(0, "(Todos)")
                  cboEmpresa.Items.Add(oItem)
               End If

               Do While .Read()
                  oItem = New clsListItem(.EmpresaId, .EmpresaDes)

                  cboEmpresa.Items.Add(oItem)
                  .MoveNext()
               Loop

               cboEmpresa.SelectedIndex = ListFindItem(cboEmpresa, 0)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboGestionLoad(ByVal lngEmpresaId As Long)
      Dim oGestion As New clsGestion(mstrConnectStringOrg)
      Dim oItem As clsListItem

      cboGestion.Items.Clear()
      cboGestion.Text = ""
      If mboolTodos Then
         oItem = New clsListItem(0, "(Todos)")
         cboGestion.Items.Add(oItem)
      End If

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.EmpresaId
            .OrderByFilter = clsGestion.OrderByFilters.Gestion
            .EmpresaId = lngEmpresaId
            .EstadoId = 11

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.GestionId, ToStr(.Gestion))

                  cboGestion.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

         cboGestion.SelectedIndex = ListFindItem(cboGestion, 0)
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Public Function cboDataBaseLoad(ByVal strServer As String, ByVal strUser As String, ByVal strPass As String) As Boolean
      Dim oItem As clsListItem
      Dim strBaseSys() As String = {"master", "model", "msdb", "tempdb"}
      Dim oDataTable As New DataTable
      Dim strConnectionString As String = "Provider=sqloledb;Data Source=" & strServer & _
                                          ";Initial Catalog=master;User ID=" & strUser & _
                                          ";Password=" & strPass & ";Current Language=us_english"

      Dim strSQL As String = "SELECT dbid, name FROM master.dbo.sysdatabases ORDER BY name"

      cboDataBaseLoad = False
      cboDataBase.Items.Clear()
      cboDataBase.Text = ""

      Try
         Dim oDataAdapter As New Data.OleDb.OleDbDataAdapter(strSQL, strConnectionString)
         oDataAdapter.Fill(oDataTable)

         For i As Integer = 0 To oDataTable.Rows.Count - 1
            If Array.IndexOf(strBaseSys, oDataTable.Rows(i).Item("name").ToString()) = -1 Then
               oItem = New clsListItem(ToLong(oDataTable.Rows(i).Item("dbid")), ToStr(oDataTable.Rows(i).Item("name")))

               cboDataBase.Items.Add(oItem)
               cboDataBaseLoad = True
            End If
         Next
         cboDataBase.SelectedIndex = 0
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem = Nothing

      End Try
   End Function

   Private Function DatabaseSelect() As Boolean
      DatabaseSelect = False

      If cboDataBase.SelectedIndex <> -1 Then
         mstrConnectStringOrg = "Provider=sqloledb;Data Source=" & ToStr(txtServer.Text) & _
                                 ";Initial Catalog=" & ToStr(cboDataBase.Text) & ";User ID=" & ToStr(txtUser.Text) & _
                                 ";Password=" & ToStr(txtPass.Text) & ";Current Language=us_english"

         mstrDataBaseOrg = ToStr(txtServer.Text) & "." & ToStr(cboDataBase.Text)

         DatabaseSelect = True
         grpMain.Enabled = True
      End If
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      mboolChanged = False
      txtServer.Text = clsAppInfo.DataBaseSource
      cdmMain.Commands.Item("Sel").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub frmDataBaseOrgEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            Call SelectConnection()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub DataBaseOrg_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

   Private Sub cboDataBase_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDataBase.SelectedIndexChanged
      If DatabaseSelect() Then
         Call cboEmpresaLoad()
      End If
   End Sub

   Private Sub cboEmpresa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEmpresa.SelectedIndexChanged
      'If cboEmpresa.ContainsFocus Then
      If ListPosition(cboEmpresa, cboEmpresa.SelectedIndex) > 0 Or mboolTodos Then
         Call cboGestionLoad(ListPosition(cboEmpresa, cboEmpresa.SelectedIndex))
      End If
      'End If
   End Sub

   Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
      Call Connect()
   End Sub
End Class
