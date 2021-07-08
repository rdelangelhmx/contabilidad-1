Public Class frmDosificaDetEdit
   Inherits System.Windows.Forms.Form

   Private moDosificaDet As clsDosificaDet

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents dudOrden As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents chkImpTipoActEco As Janus.Windows.EditControls.UICheckBox
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

   Property DataObject() As clsDosificaDet
      Get
         Return moDosificaDet
      End Get
      Set(ByVal Value As clsDosificaDet)
         moDosificaDet = Value
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
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtDosificaDetId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboTipoActEco As Janus.Windows.EditControls.UIComboBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDosificaDetEdit))
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.chkImpTipoActEco = New Janus.Windows.EditControls.UICheckBox
      Me.dudOrden = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label18 = New System.Windows.Forms.Label
      Me.cboTipoActEco = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtDosificaDetId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label7 = New System.Windows.Forms.Label
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
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("0e9a011c-64a3-47fa-80f4-631873a99f25")
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
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 124)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.chkImpTipoActEco)
      Me.grpMain.Controls.Add(Me.dudOrden)
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.cboTipoActEco)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtDosificaDetId)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 116)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkImpTipoActEco
      '
      Me.chkImpTipoActEco.BackColor = System.Drawing.Color.Transparent
      Me.chkImpTipoActEco.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkImpTipoActEco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkImpTipoActEco.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkImpTipoActEco.Location = New System.Drawing.Point(280, 64)
      Me.chkImpTipoActEco.Name = "chkImpTipoActEco"
      Me.chkImpTipoActEco.Size = New System.Drawing.Size(156, 20)
      Me.chkImpTipoActEco.TabIndex = 4
      Me.chkImpTipoActEco.Text = "Imprimir Act. Económica"
      Me.chkImpTipoActEco.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'dudOrden
      '
      Me.dudOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudOrden.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudOrden.Location = New System.Drawing.Point(116, 64)
      Me.dudOrden.Maximum = 5
      Me.dudOrden.Minimum = 1
      Me.dudOrden.Name = "dudOrden"
      Me.dudOrden.Size = New System.Drawing.Size(124, 20)
      Me.dudOrden.TabIndex = 3
      Me.dudOrden.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudOrden.Value = 1
      Me.dudOrden.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.cboEstado.TabIndex = 5
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 92)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 196
      Me.Label2.Text = "Estado"
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 68)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 194
      Me.Label18.Text = "Orden"
      '
      'cboTipoActEco
      '
      Me.cboTipoActEco.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoActEco.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoActEco.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoActEco.Location = New System.Drawing.Point(116, 40)
      Me.cboTipoActEco.Name = "cboTipoActEco"
      Me.cboTipoActEco.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoActEco.Size = New System.Drawing.Size(320, 20)
      Me.cboTipoActEco.TabIndex = 2
      Me.cboTipoActEco.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 173
      Me.Label1.Text = "Act. Económica"
      '
      'txtDosificaDetId
      '
      Me.txtDosificaDetId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDosificaDetId.Location = New System.Drawing.Point(116, 16)
      Me.txtDosificaDetId.Name = "txtDosificaDetId"
      Me.txtDosificaDetId.ReadOnly = True
      Me.txtDosificaDetId.Size = New System.Drawing.Size(124, 20)
      Me.txtDosificaDetId.TabIndex = 1
      Me.txtDosificaDetId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDosificaDetId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 20)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 168
      Me.Label7.Text = "ID"
      '
      'frmDosificaDetEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 152)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmDosificaDetEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "DosificaDet Edit"
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
               mlngID = moDosificaDet.DosificaDetId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmDosificaDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmDosificaDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Actividad Economica"
         Else
            Me.Text = "Editar Actividad Economica"
         End If
      Else
         Me.Text = "Nueva Actividad Economica"
         Call FormNew()
      End If

      mboolLoading = False

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moDosificaDet
         txtDosificaDetId.Text = ToStr(.DosificaDetId)
         dudOrden.Text = ToStr(.Orden)
         cboTipoActEco.SelectedIndex = ListFindItem(cboTipoActEco, .TipoActEcoId)
         chkImpTipoActEco.Checked = ToBoolean(.ImpTipoActEco)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         If clsAppInfo.RegistrarBitacora And moDosificaDet.DosificaDetId > 0 Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Actividad Economica"
               .VMOld.ToShowOpe()
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsDosificaDetVM)
      Dim oDosificaDet As New clsDosificaDet(clsAppInfo.ConnectString)
      oDosificaDet.DosificaDetId = moDosificaDet.DosificaDetId
      oDosificaDet.FindByPK()

      oVM = New clsDosificaDetVM

      With oVM
         .DosificaDetId = oDosificaDet.DosificaDetId
         .EmpresaId = oDosificaDet.EmpresaId
         .DosificaId = oDosificaDet.DosificaId
         .TipoActEcoDes = TipoActEcoDesFind(oDosificaDet.TipoActEcoId)
         .Orden = oDosificaDet.Orden
         .ImpTipoActEco = oDosificaDet.ImpTipoActEco
         .EstadoId = oDosificaDet.EstadoId
         .EstadoDes = EstadoDesFind(oDosificaDet.EstadoId)

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moDosificaDet
         txtDosificaDetId.Text = String.Empty
         dudOrden.Text = "1"
         cboTipoActEco.SelectedIndex = -1
         chkImpTipoActEco.Checked = True
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 1)
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtDosificaDetId.ReadOnly = True
      dudOrden.ReadOnly = True
      cboTipoActEco.ReadOnly = True
      chkImpTipoActEco.Enabled = False
      cboEstado.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moDosificaDet
         If Not mboolAdding Then
            .DosificaDetId = ToLong(txtDosificaDetId.Text)
         End If

         .Orden = ToLong(dudOrden.Text)
         .TipoActEcoId = ListPosition(cboTipoActEco, cboTipoActEco.SelectedIndex)
         .ImpTipoActEco = ToBoolean(chkImpTipoActEco.Checked)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboTipoActEco.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If mboolAdding Then
            DataSave = True
         Else
            DataSave = True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)
   End Sub

   Private Sub ComboLoad()
      Call cboTipoActEcoLoad()
      Call cboEstadoLoad()
   End Sub

   Private Sub cboTipoActEcoLoad()
      Dim oTipoActEco As New clsTipoActEco(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoActEco.Items.Clear()

      Try
         With oTipoActEco
            .SelectFilter = clsTipoActEco.SelectFilters.ListBox
            .WhereFilter = clsTipoActEco.WhereFilters.EmpresaId
            .OrderByFilter = clsTipoActEco.OrderByFilters.TipoActEcoDes
            .EmpresaId = moDosificaDet.EmpresaId

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoActEcoId, .TipoActEcoDes)

                  cboTipoActEco.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoActEco.Dispose()
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
            .WhereFilter = clsEstado.WhereFilters.TipoId
            .OrderByFilter = clsEstado.OrderByFilters.EstadoDes
            .TipoId = 1

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

   Private Sub cboTipoActEco_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTipoActEco.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmTipoActEcoEdit
               Dim oTipoActEco As New clsTipoActEco(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oTipoActEco.EmpresaId = moDosificaDet.EmpresaId

                     .DataObject = oTipoActEco
                     .ShowDialog()

                     If .Changed Then
                        Call cboTipoActEcoLoad()
                        cboTipoActEco.SelectedIndex = ListFindItem(cboTipoActEco, frm.ID)
                     End If

                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oTipoActEco.Dispose()

               End Try
            End If
         End If
      End If
   End Sub

   Private Sub frmDosificaDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If Save.Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If DataSave() Then
                  mlngID = moDosificaDet.DosificaDetId
                  mboolChanged = True
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmDosificaDetEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moDosificaDet.Dispose()
      Call ClearMemory()
   End Sub

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

End Class
