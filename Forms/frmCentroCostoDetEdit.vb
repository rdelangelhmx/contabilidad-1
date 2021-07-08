Public Class frmCentroCostoDetEdit
   Inherits System.Windows.Forms.Form

   Private moCentroCostoDet As clsCentroCostoDet

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cboEstado As Janus.Windows.EditControls.UIComboBox
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

   WriteOnly Property DataObject() As clsCentroCostoDet
      Set(ByVal Value As clsCentroCostoDet)
         moCentroCostoDet = Value
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
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtCentroCostoDetId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtCentroCostoDetCod As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtCentroCostoDetDes As Janus.Windows.GridEX.EditControls.EditBox
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
   Friend WithEvents cboCentroCosto As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboCentroCosto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCentroCostoDetEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboEstado = New Janus.Windows.EditControls.UIComboBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.cboCentroCosto = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.txtCentroCostoDetDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtCentroCostoDetCod = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtCentroCostoDetId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.lblId = New System.Windows.Forms.Label
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
      CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 173)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboEstado)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.cboCentroCosto)
      Me.grpMain.Controls.Add(Me.txtCentroCostoDetDes)
      Me.grpMain.Controls.Add(Me.txtCentroCostoDetCod)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtCentroCostoDetId)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.Label8)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.lblId)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 164)
      Me.grpMain.TabIndex = 159
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboEstado
      '
      Me.cboEstado.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboEstado.Location = New System.Drawing.Point(116, 136)
      Me.cboEstado.Name = "cboEstado"
      Me.cboEstado.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboEstado.Size = New System.Drawing.Size(320, 20)
      Me.cboEstado.TabIndex = 5
      Me.cboEstado.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(8, 140)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 184
      Me.Label4.Text = "Estado"
      '
      'cboCentroCosto
      '
      cboCentroCosto_DesignTimeLayout.LayoutString = resources.GetString("cboCentroCosto_DesignTimeLayout.LayoutString")
      Me.cboCentroCosto.DesignTimeLayout = cboCentroCosto_DesignTimeLayout
      Me.cboCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCosto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCosto.Location = New System.Drawing.Point(116, 64)
      Me.cboCentroCosto.Name = "cboCentroCosto"
      Me.cboCentroCosto.SelectedIndex = -1
      Me.cboCentroCosto.SelectedItem = Nothing
      Me.cboCentroCosto.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCosto.TabIndex = 2
      Me.cboCentroCosto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboCentroCosto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCentroCostoDetDes
      '
      Me.txtCentroCostoDetDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCentroCostoDetDes.Location = New System.Drawing.Point(116, 112)
      Me.txtCentroCostoDetDes.MaxLength = 255
      Me.txtCentroCostoDetDes.Name = "txtCentroCostoDetDes"
      Me.txtCentroCostoDetDes.Size = New System.Drawing.Size(320, 20)
      Me.txtCentroCostoDetDes.TabIndex = 4
      Me.txtCentroCostoDetDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCentroCostoDetDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCentroCostoDetCod
      '
      Me.txtCentroCostoDetCod.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCentroCostoDetCod.Location = New System.Drawing.Point(116, 88)
      Me.txtCentroCostoDetCod.MaxLength = 50
      Me.txtCentroCostoDetCod.Name = "txtCentroCostoDetCod"
      Me.txtCentroCostoDetCod.Size = New System.Drawing.Size(124, 20)
      Me.txtCentroCostoDetCod.TabIndex = 3
      Me.txtCentroCostoDetCod.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCentroCostoDetCod.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      'txtCentroCostoDetId
      '
      Me.txtCentroCostoDetId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCentroCostoDetId.Location = New System.Drawing.Point(116, 16)
      Me.txtCentroCostoDetId.Name = "txtCentroCostoDetId"
      Me.txtCentroCostoDetId.ReadOnly = True
      Me.txtCentroCostoDetId.Size = New System.Drawing.Size(124, 20)
      Me.txtCentroCostoDetId.TabIndex = 0
      Me.txtCentroCostoDetId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCentroCostoDetId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 182
      Me.Label1.Text = "Empresa"
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label8.Location = New System.Drawing.Point(8, 68)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 181
      Me.Label8.Text = "Centro Costo"
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(8, 116)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 180
      Me.Label3.Text = "Actividad"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(8, 92)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 179
      Me.Label2.Text = "Código"
      '
      'lblId
      '
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblId.Location = New System.Drawing.Point(8, 20)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(104, 16)
      Me.lblId.TabIndex = 178
      Me.lblId.Text = "ID"
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
      Me.cdmMain.Id = New System.Guid("3769697d-c85b-49b1-9c13-27d82f449f93")
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
      'frmCentroCostoDetEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 201)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCentroCostoDetEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CentroCostoDet Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
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
               mlngID = moCentroCostoDet.CentroCostoDetId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCentroCostoDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCentroCostoDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Actividad"
         Else
            Me.Text = "Editar Actividad"
         End If
      Else
         Me.Text = "Nueva Actividad"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCentroCostoDet
         txtCentroCostoDetId.Text = ToStr(.CentroCostoDetId)
         Call txtEmpresaIdLoad(.EmpresaId)
         cboCentroCosto.Value = ListFindItem(cboCentroCosto, .CentroCostoId)
         txtCentroCostoDetCod.Text = ToStr(.CentroCostoDetCod)
         txtCentroCostoDetDes.Text = ToStr(.CentroCostoDetDes)
         cboEstado.SelectedIndex = ListFindItem(cboEstado, .EstadoId)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Actividad"
               .VMOld.ToShowOpe()
            End If
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsCentroCostoDetVM)
      oVM = New clsCentroCostoDetVM

      With oVM
         .CentroCostoDetId = moCentroCostoDet.CentroCostoDetId
         .EmpresaId = moCentroCostoDet.EmpresaId
         .CentroCostoDetDes = moCentroCostoDet.CentroCostoDetDes
         .CentroCostoDetCod = moCentroCostoDet.CentroCostoDetCod
         .CentroCostoId = moCentroCostoDet.CentroCostoId
         .CentroCostoDes = cboCentroCosto.Text
         .EstadoId = moCentroCostoDet.EstadoId
         .EstadoDes = cboEstado.Text

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCentroCostoDet
         txtCentroCostoDetId.Text = String.Empty
         Call txtEmpresaIdLoad(.EmpresaId)
         cboCentroCosto.Value = ListFindItem(cboCentroCosto, .CentroCostoId)
         txtCentroCostoDetCod.Text = CentroCostoDetCodNext(.CentroCostoId)
         txtCentroCostoDetDes.Text = String.Empty
         cboEstado.SelectedIndex = ListFindItem(cboEstado, 1)
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCentroCostoDetId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      cboCentroCosto.ReadOnly = True
      txtCentroCostoDetCod.ReadOnly = True
      txtCentroCostoDetDes.ReadOnly = True
      cboEstado.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCentroCostoDet
         If Not mboolAdding Then
            .CentroCostoDetId = ToLong(txtCentroCostoDetId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .CentroCostoId = ListPosition(cboCentroCosto)
         .CentroCostoDetCod = ToStr(txtCentroCostoDetCod.Text)
         .CentroCostoDetDes = ToStr(txtCentroCostoDetDes.Text)
         .EstadoId = ListPosition(cboEstado, cboEstado.SelectedIndex)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboCentroCosto.Select()
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

         If moCentroCostoDet.Insert() Then
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

         If moCentroCostoDet.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function CentroCostoDetCodNext(ByVal lngCentroCostoId As Long) As String
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)

      CentroCostoDetCodNext = ""

      Try
         With oCentroCostoDet
            .SelectFilter = clsCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCentroCostoDet.WhereFilters.CentroCostoId
            .EmpresaId = moCentroCostoDet.EmpresaId
            .CentroCostoId = lngCentroCostoId

            If .Find Then
               Return .CentroCostoDetCod
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCostoDet.Dispose()

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

   End Sub

   Private Sub ComboLoad()
      Call cboCentroCostoLoad()
      Call cboEstadoLoad()
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

   Private Sub cboCentroCostoLoad()
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)

      Try
         With oCentroCosto
            .SelectFilter = clsCentroCosto.SelectFilters.All
            .WhereFilter = clsCentroCosto.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCosto.OrderByFilters.CentroCostoDes
            .EmpresaId = moCentroCostoDet.EmpresaId
            .CentroCostoId = moCentroCostoDet.CentroCostoId
            .EstadoId = 1

            If .Open() Then
               With cboCentroCosto
                  .DropDownList.Columns.Clear()

                  .DropDownList.Columns.Add("CentroCostoId")
                  .DropDownList.Columns("CentroCostoId").DataMember = "CentroCostoId"
                  .DropDownList.Columns("CentroCostoId").Visible = False

                  .DropDownList.Columns.Add("CentroCostoCod")
                  .DropDownList.Columns("CentroCostoCod").Caption = "Cuenta"
                  .DropDownList.Columns("CentroCostoCod").DataMember = "CentroCostoCod"
                  .DropDownList.Columns("CentroCostoCod").Width = 100

                  .DropDownList.Columns.Add("CentroCostoDes")
                  .DropDownList.Columns("CentroCostoDes").Caption = "Descripción"
                  .DropDownList.Columns("CentroCostoDes").DataMember = "CentroCostoDes"
                  .DropDownList.Columns("CentroCostoDes").Width = 405

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

   Private Sub frmCentroCostoDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moCentroCostoDet.CentroCostoDetId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCentroCostoDetEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCentroCostoDet.Dispose()
      Call ClearMemory()
   End Sub

End Class
