Public Class frmSucursalEdit
   Inherits System.Windows.Forms.Form

   Private moSucursal As clsSucursal

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents cboCiudad As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents txtTelefono As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtDireccion As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents Label24 As System.Windows.Forms.Label
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

   WriteOnly Property DataObject() As clsSucursal
      Set(ByVal Value As clsSucursal)
         moSucursal = Value
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
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents txtSucursalId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtSucursalCod As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtSucursalDes As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSucursalEdit))
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
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCiudad = New Janus.Windows.EditControls.UIComboBox
      Me.txtTelefono = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtDireccion = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label22 = New System.Windows.Forms.Label
      Me.Label23 = New System.Windows.Forms.Label
      Me.Label24 = New System.Windows.Forms.Label
      Me.txtSucursalDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtSucursalCod = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtSucursalId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.lblId = New System.Windows.Forms.Label
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.SuspendLayout()
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
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("3cc94466-25d5-4396-a445-8229f795ae5d")
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
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 195)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboCiudad)
      Me.grpMain.Controls.Add(Me.txtTelefono)
      Me.grpMain.Controls.Add(Me.txtDireccion)
      Me.grpMain.Controls.Add(Me.Label22)
      Me.grpMain.Controls.Add(Me.Label23)
      Me.grpMain.Controls.Add(Me.Label24)
      Me.grpMain.Controls.Add(Me.txtSucursalDes)
      Me.grpMain.Controls.Add(Me.txtSucursalCod)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtSucursalId)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.lblId)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 188)
      Me.grpMain.TabIndex = 159
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCiudad
      '
      Me.cboCiudad.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCiudad.Location = New System.Drawing.Point(116, 136)
      Me.cboCiudad.Name = "cboCiudad"
      Me.cboCiudad.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboCiudad.Size = New System.Drawing.Size(320, 20)
      Me.cboCiudad.TabIndex = 5
      Me.cboCiudad.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtTelefono
      '
      Me.txtTelefono.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTelefono.Location = New System.Drawing.Point(116, 160)
      Me.txtTelefono.MaxLength = 100
      Me.txtTelefono.Name = "txtTelefono"
      Me.txtTelefono.Size = New System.Drawing.Size(124, 20)
      Me.txtTelefono.TabIndex = 6
      Me.txtTelefono.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTelefono.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtDireccion
      '
      Me.txtDireccion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDireccion.Location = New System.Drawing.Point(116, 112)
      Me.txtDireccion.MaxLength = 200
      Me.txtDireccion.Name = "txtDireccion"
      Me.txtDireccion.Size = New System.Drawing.Size(320, 20)
      Me.txtDireccion.TabIndex = 4
      Me.txtDireccion.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDireccion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.Location = New System.Drawing.Point(8, 140)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(104, 16)
      Me.Label22.TabIndex = 181
      Me.Label22.Text = "Ciudad"
      '
      'Label23
      '
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.Location = New System.Drawing.Point(8, 164)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(104, 16)
      Me.Label23.TabIndex = 180
      Me.Label23.Text = "Telefono"
      '
      'Label24
      '
      Me.Label24.BackColor = System.Drawing.Color.Transparent
      Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label24.Location = New System.Drawing.Point(8, 116)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(104, 16)
      Me.Label24.TabIndex = 179
      Me.Label24.Text = "Dirección"
      '
      'txtSucursalDes
      '
      Me.txtSucursalDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSucursalDes.Location = New System.Drawing.Point(116, 88)
      Me.txtSucursalDes.MaxLength = 100
      Me.txtSucursalDes.Name = "txtSucursalDes"
      Me.txtSucursalDes.Size = New System.Drawing.Size(320, 20)
      Me.txtSucursalDes.TabIndex = 3
      Me.txtSucursalDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtSucursalDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtSucursalCod
      '
      Me.txtSucursalCod.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSucursalCod.Location = New System.Drawing.Point(116, 64)
      Me.txtSucursalCod.MaxLength = 50
      Me.txtSucursalCod.Name = "txtSucursalCod"
      Me.txtSucursalCod.Size = New System.Drawing.Size(124, 20)
      Me.txtSucursalCod.TabIndex = 2
      Me.txtSucursalCod.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtSucursalCod.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(116, 40)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(320, 20)
      Me.txtEmpresaId.TabIndex = 1
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtSucursalId
      '
      Me.txtSucursalId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtSucursalId.Location = New System.Drawing.Point(116, 16)
      Me.txtSucursalId.Name = "txtSucursalId"
      Me.txtSucursalId.ReadOnly = True
      Me.txtSucursalId.Size = New System.Drawing.Size(124, 20)
      Me.txtSucursalId.TabIndex = 0
      Me.txtSucursalId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtSucursalId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 92)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 175
      Me.Label3.Text = "Sucursal"
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 174
      Me.Label1.Text = "Empresa"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 68)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 173
      Me.Label2.Text = "Código"
      '
      'lblId
      '
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblId.Location = New System.Drawing.Point(8, 20)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(104, 16)
      Me.lblId.TabIndex = 172
      Me.lblId.Text = "ID"
      '
      'frmSucursalEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 223)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmSucursalEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Sucursal Edit"
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
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
               mlngID = moSucursal.SucursalId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmSucursalEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmSucursalEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Sucursal"
         Else
            Me.Text = "Editar Sucursal"
         End If
      Else
         Me.Text = "Nueva Sucursal"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moSucursal
         txtSucursalId.Text = ToStr(.SucursalId)
         Call txtEmpresaIdLoad(.EmpresaId)
         txtSucursalCod.Text = ToStr(.SucursalCod)
         txtSucursalDes.Text = ToStr(.SucursalDes)
         txtDireccion.Text = ToStr(.Direccion)
         cboCiudad.SelectedIndex = ListFindItem(cboCiudad, .CiudadId)
         txtTelefono.Text = ToStr(.Telefono)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Sucursal"
               .VMOld.ToShowOpe()
            End If
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsSucursalVM)
      oVM = New clsSucursalVM

      With oVM
         .SucursalId = moSucursal.SucursalId
         .EmpresaId = moSucursal.EmpresaId
         .SucursalDes = moSucursal.SucursalDes
         .SucursalCod = moSucursal.SucursalCod
         .Direccion = moSucursal.Direccion
         .CiudadId = moSucursal.CiudadId
         .CiudadDes = cboCiudad.Text
         .Telefono = moSucursal.Telefono

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moSucursal
         txtSucursalId.Text = String.Empty
         Call txtEmpresaIdLoad(.EmpresaId)
         txtSucursalCod.Text = String.Empty
         txtSucursalDes.Text = String.Empty
         txtDireccion.Text = String.Empty
         cboCiudad.SelectedIndex = -1
         txtTelefono.Text = String.Empty
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtSucursalId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      txtSucursalCod.ReadOnly = True
      txtSucursalDes.ReadOnly = True
      txtDireccion.ReadOnly = True
      cboCiudad.Enabled = False
      txtTelefono.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moSucursal
         If Not mboolAdding Then
            .SucursalId = ToLong(txtSucursalId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .SucursalCod = ToStr(txtSucursalCod.Text)
         .SucursalDes = ToStr(txtSucursalDes.Text)
         .Direccion = ToStr(txtDireccion.Text)
         .CiudadId = ListPosition(cboCiudad, cboCiudad.SelectedIndex)
         .Telefono = ToStr(txtTelefono.Text)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtSucursalCod.Select()
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

         If moSucursal.Insert() Then
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

         If moSucursal.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

   End Sub

   Private Sub ComboLoad()
      Call cboCiudadLoad()
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

   Private Sub txtEmpresaIdLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      Try
         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               txtEmpresaId.Tag = .EmpresaId
               txtEmpresaId.Text = ToStr(.EmpresaDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Sub

   Private Sub frmSucursalEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moSucursal.SucursalId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmSucursalEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moSucursal.Dispose()
      Call ClearMemory()
   End Sub

End Class
