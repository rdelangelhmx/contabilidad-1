Public Class frmCiudadEdit
   Inherits System.Windows.Forms.Form

   Private moCiudad As clsCiudad

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents txtCiudadCod As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cboPais As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents cboProvincia As Janus.Windows.EditControls.UIComboBox
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

   WriteOnly Property DataObject() As clsCiudad
      Set(ByVal Value As clsCiudad)
         moCiudad = Value
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
   Friend WithEvents txtCiudadId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtCiudadDes As Janus.Windows.GridEX.EditControls.EditBox
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
   Friend WithEvents cboDepartamento As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCiudadEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.cboProvincia = New Janus.Windows.EditControls.UIComboBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.cboPais = New Janus.Windows.EditControls.UIComboBox
      Me.txtCiudadCod = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboDepartamento = New Janus.Windows.EditControls.UIComboBox
      Me.txtCiudadDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtCiudadId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 174)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.cboProvincia)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Controls.Add(Me.cboPais)
      Me.grpMain.Controls.Add(Me.txtCiudadCod)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.cboDepartamento)
      Me.grpMain.Controls.Add(Me.txtCiudadDes)
      Me.grpMain.Controls.Add(Me.txtCiudadId)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Location = New System.Drawing.Point(9, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 168)
      Me.grpMain.TabIndex = 158
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 92)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 177
      Me.Label6.Text = "Provincia"
      '
      'cboProvincia
      '
      Me.cboProvincia.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboProvincia.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProvincia.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboProvincia.Location = New System.Drawing.Point(116, 88)
      Me.cboProvincia.Name = "cboProvincia"
      Me.cboProvincia.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboProvincia.Size = New System.Drawing.Size(320, 20)
      Me.cboProvincia.TabIndex = 3
      Me.cboProvincia.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 44)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 175
      Me.Label5.Text = "País"
      '
      'cboPais
      '
      Me.cboPais.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPais.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPais.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPais.Location = New System.Drawing.Point(116, 40)
      Me.cboPais.Name = "cboPais"
      Me.cboPais.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboPais.Size = New System.Drawing.Size(320, 20)
      Me.cboPais.TabIndex = 1
      Me.cboPais.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtCiudadCod
      '
      Me.txtCiudadCod.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCiudadCod.Location = New System.Drawing.Point(116, 112)
      Me.txtCiudadCod.MaxLength = 100
      Me.txtCiudadCod.Name = "txtCiudadCod"
      Me.txtCiudadCod.Size = New System.Drawing.Size(124, 20)
      Me.txtCiudadCod.TabIndex = 4
      Me.txtCiudadCod.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCiudadCod.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 116)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 173
      Me.Label4.Text = "Código"
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 68)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 171
      Me.Label1.Text = "Departamento"
      '
      'cboDepartamento
      '
      Me.cboDepartamento.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboDepartamento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDepartamento.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDepartamento.Location = New System.Drawing.Point(116, 64)
      Me.cboDepartamento.Name = "cboDepartamento"
      Me.cboDepartamento.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboDepartamento.Size = New System.Drawing.Size(320, 20)
      Me.cboDepartamento.TabIndex = 2
      Me.cboDepartamento.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtCiudadDes
      '
      Me.txtCiudadDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCiudadDes.Location = New System.Drawing.Point(116, 136)
      Me.txtCiudadDes.MaxLength = 100
      Me.txtCiudadDes.Name = "txtCiudadDes"
      Me.txtCiudadDes.Size = New System.Drawing.Size(320, 20)
      Me.txtCiudadDes.TabIndex = 5
      Me.txtCiudadDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCiudadDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCiudadId
      '
      Me.txtCiudadId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCiudadId.Location = New System.Drawing.Point(116, 16)
      Me.txtCiudadId.Name = "txtCiudadId"
      Me.txtCiudadId.ReadOnly = True
      Me.txtCiudadId.Size = New System.Drawing.Size(124, 20)
      Me.txtCiudadId.TabIndex = 0
      Me.txtCiudadId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCiudadId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 140)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 169
      Me.Label2.Text = "Ciudad"
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 20)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 168
      Me.Label3.Text = "ID"
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
      Me.cdmMain.Id = New System.Guid("694abc5b-24bc-4e2c-9aae-c8ef630f12ef")
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
      'frmCiudadEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 202)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCiudadEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ciudad Edit"
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
               mlngID = moCiudad.CiudadId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor


   End Sub

   Private Sub frmCiudadEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCiudadEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Ciudad"
         Else
            Me.Text = "Editar Ciudad"
         End If
      Else
         Me.Text = "Nueva Ciudad"
         Call FormNew()
      End If

      mboolLoading = False

      Me.Cursor = oCursor

      Call ClearMemory()
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCiudad
         txtCiudadId.Text = ToStr(.CiudadId)
         cboPais.SelectedIndex = ListFindItem(cboPais, .PaisId)
         cboDepartamento.SelectedIndex = ListFindItem(cboDepartamento, .DepartamentoId)
         cboProvincia.SelectedIndex = ListFindItem(cboProvincia, .ProvinciaId)
         txtCiudadCod.Text = ToStr(.CiudadCod)
         txtCiudadDes.Text = ToStr(.CiudadDes)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Ciudad"
               .VMOld.ToShowOpe()
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsCiudadVM)
      oVM = New clsCiudadVM

      With oVM
         .CiudadId = moCiudad.CiudadId
         .CiudadDes = moCiudad.CiudadDes
         .CiudadCod = moCiudad.CiudadCod
         .DepartamentoId = moCiudad.DepartamentoId
         .DepartamentoDes = ToStr(cboDepartamento.Text)
         .ProvinciaId = moCiudad.ProvinciaId
         .ProvinciaDes = ToStr(cboProvincia.Text)
         .PaisId = moCiudad.PaisId
         .PaisDes = ToStr(cboPais.Text)

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCiudad
         txtCiudadId.Text = String.Empty
         cboPais.SelectedIndex = -1
         cboDepartamento.SelectedIndex = -1
         cboProvincia.SelectedIndex = -1
         txtCiudadCod.Text = String.Empty
         txtCiudadDes.Text = String.Empty
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCiudadId.ReadOnly = True
      cboPais.ReadOnly = True
      cboDepartamento.ReadOnly = True
      cboProvincia.ReadOnly = True
      txtCiudadCod.ReadOnly = True
      txtCiudadDes.ReadOnly = True
      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCiudad
         If Not mboolAdding Then
            .CiudadId = ToLong(txtCiudadId.Text)
         End If

         .PaisId = ListPosition(cboPais, cboPais.SelectedIndex)
         .DepartamentoId = ListPosition(cboDepartamento, cboDepartamento.SelectedIndex)
         .ProvinciaId = ListPosition(cboProvincia, cboProvincia.SelectedIndex)
         .CiudadCod = ToStr(txtCiudadCod.Text)
         .CiudadDes = ToStr(txtCiudadDes.Text)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtCiudadCod.Select()
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

         If moCiudad.Insert() Then
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

         If moCiudad.Update() Then
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
      Call cboPaisload()
   End Sub

   Private Sub cboPaisLoad()
      Dim oPais As New clsPais(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboPais.Items.Clear()

      Try
         With oPais
            .SelectFilter = clsPais.SelectFilters.ListBox
            .OrderByFilter = clsPais.OrderByFilters.PaisDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.PaisId, .PaisDes)

                  cboPais.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPais.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboDepartamentoLoad(ByVal lngPaisId As Long)
      Dim oDepartamento As New clsDepartamento(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboDepartamento.Items.Clear()

      Try
         With oDepartamento
            .SelectFilter = clsDepartamento.SelectFilters.ListBox
            .WhereFilter = clsDepartamento.WhereFilters.PaisId
            .OrderByFilter = clsDepartamento.OrderByFilters.DepartamentoDes
            .PaisId = lngPaisId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.DepartamentoId, .DepartamentoDes)

                  cboDepartamento.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oDepartamento.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboProvinciaLoad(ByVal lngDepartamentoId As Long)
      Dim oProvincia As New clsProvincia(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboProvincia.Items.Clear()

      Try
         With oProvincia
            .SelectFilter = clsProvincia.SelectFilters.ListBox
            .WhereFilter = clsProvincia.WhereFilters.DepartamentoId
            .OrderByFilter = clsProvincia.OrderByFilters.ProvinciaDes
            .DepartamentoId = lngDepartamentoId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.ProvinciaId, .ProvinciaDes)

                  cboProvincia.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oProvincia.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPais.SelectedIndexChanged
      If cboPais.Tag <> cboPais.Text Then
         cboPais.Tag = cboPais.Text

         If ListPosition(cboPais, cboPais.SelectedIndex) <> 0 Then
            Call cboDepartamentoLoad(ListPosition(cboPais, cboPais.SelectedIndex))
         End If
      End If
   End Sub

   Private Sub cboDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.SelectedIndexChanged
      If cboDepartamento.Tag <> cboDepartamento.Text Then
         cboDepartamento.Tag = cboDepartamento.Text

         If ListPosition(cboDepartamento, cboDepartamento.SelectedIndex) <> 0 Then
            Call cboProvinciaLoad(ListPosition(cboDepartamento, cboDepartamento.SelectedIndex))
         End If
      End If
   End Sub

   Private Sub frmCiudadEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moCiudad.CiudadId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCiudadEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCiudad.Dispose()
      Call ClearMemory()
   End Sub

End Class
