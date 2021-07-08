Public Class frmReciboParaEdit
   Inherits System.Windows.Forms.Form

   Private moReciboPara As clsReciboPara

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
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

   WriteOnly Property DataObject() As clsReciboPara
      Set(ByVal Value As clsReciboPara)
         moReciboPara = Value
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
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtReciboParaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtGestionId As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtTipoCompId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtNroIni As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtNroActual As Janus.Windows.GridEX.EditControls.NumericEditBox
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
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtFirma As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboTipoHoja As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboParaEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboTipoHoja = New Janus.Windows.EditControls.UIComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtFirma = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtNroActual = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtNroIni = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtTipoCompId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtGestionId = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtReciboParaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 262)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboTipoHoja)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtFirma)
      Me.grpMain.Controls.Add(Me.Label18)
      Me.grpMain.Controls.Add(Me.txtNroActual)
      Me.grpMain.Controls.Add(Me.txtNroIni)
      Me.grpMain.Controls.Add(Me.txtTipoCompId)
      Me.grpMain.Controls.Add(Me.txtGestionId)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtReciboParaId)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.Label7)
      Me.grpMain.Controls.Add(Me.Label8)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label11)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 252)
      Me.grpMain.TabIndex = 159
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboTipoHoja
      '
      Me.cboTipoHoja.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.Location = New System.Drawing.Point(116, 224)
      Me.cboTipoHoja.Name = "cboTipoHoja"
      Me.cboTipoHoja.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoHoja.Size = New System.Drawing.Size(320, 20)
      Me.cboTipoHoja.TabIndex = 7
      Me.cboTipoHoja.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 228)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 205
      Me.Label1.Text = "Tamaño Hoja"
      '
      'txtFirma
      '
      Me.txtFirma.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFirma.Location = New System.Drawing.Point(116, 160)
      Me.txtFirma.MaxLength = 1000
      Me.txtFirma.Multiline = True
      Me.txtFirma.Name = "txtFirma"
      Me.txtFirma.ScrollBars = System.Windows.Forms.ScrollBars.Both
      Me.txtFirma.Size = New System.Drawing.Size(320, 60)
      Me.txtFirma.TabIndex = 6
      Me.txtFirma.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFirma.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      Me.txtFirma.WordWrap = False
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 164)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(104, 16)
      Me.Label18.TabIndex = 201
      Me.Label18.Text = "Firma"
      '
      'txtNroActual
      '
      Me.txtNroActual.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroActual.Location = New System.Drawing.Point(116, 136)
      Me.txtNroActual.Name = "txtNroActual"
      Me.txtNroActual.Size = New System.Drawing.Size(124, 20)
      Me.txtNroActual.TabIndex = 5
      Me.txtNroActual.Text = "0"
      Me.txtNroActual.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroActual.Value = 0
      Me.txtNroActual.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtNroActual.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtNroIni
      '
      Me.txtNroIni.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtNroIni.Location = New System.Drawing.Point(116, 112)
      Me.txtNroIni.Name = "txtNroIni"
      Me.txtNroIni.Size = New System.Drawing.Size(124, 20)
      Me.txtNroIni.TabIndex = 4
      Me.txtNroIni.Text = "0"
      Me.txtNroIni.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtNroIni.Value = 0
      Me.txtNroIni.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtNroIni.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtTipoCompId
      '
      Me.txtTipoCompId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCompId.Location = New System.Drawing.Point(116, 88)
      Me.txtTipoCompId.Name = "txtTipoCompId"
      Me.txtTipoCompId.ReadOnly = True
      Me.txtTipoCompId.Size = New System.Drawing.Size(320, 20)
      Me.txtTipoCompId.TabIndex = 3
      Me.txtTipoCompId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtTipoCompId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtGestionId
      '
      Me.txtGestionId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtGestionId.Location = New System.Drawing.Point(116, 64)
      Me.txtGestionId.Name = "txtGestionId"
      Me.txtGestionId.ReadOnly = True
      Me.txtGestionId.Size = New System.Drawing.Size(124, 20)
      Me.txtGestionId.TabIndex = 2
      Me.txtGestionId.Text = "0"
      Me.txtGestionId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtGestionId.Value = 0
      Me.txtGestionId.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtGestionId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      'txtReciboParaId
      '
      Me.txtReciboParaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtReciboParaId.Location = New System.Drawing.Point(116, 16)
      Me.txtReciboParaId.Name = "txtReciboParaId"
      Me.txtReciboParaId.ReadOnly = True
      Me.txtReciboParaId.Size = New System.Drawing.Size(124, 20)
      Me.txtReciboParaId.TabIndex = 0
      Me.txtReciboParaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtReciboParaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 92)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 190
      Me.Label6.Text = "Tipo Comprobante"
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 140)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(104, 16)
      Me.Label7.TabIndex = 189
      Me.Label7.Text = "Número Actual"
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 116)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(104, 16)
      Me.Label8.TabIndex = 188
      Me.Label8.Text = "Número Inicial"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 44)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 186
      Me.Label10.Text = "Empresa"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 68)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(104, 16)
      Me.Label11.TabIndex = 185
      Me.Label11.Text = "Gestión"
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 20)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 184
      Me.Label12.Text = "ID"
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
      Me.cdmMain.Id = New System.Guid("0da42c1f-4b6d-4f6c-8b74-ff497ec5f8c5")
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
      'frmReciboParaEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 290)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmReciboParaEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ReciboPara Edit"
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
               mlngID = moReciboPara.ReciboParaId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmReciboParaEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmReciboParaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Parámetro de Recibo"
         Else
            Me.Text = "Editar Parámetro de Recibo"
         End If
      Else
         Me.Text = "Nuevo Parámetro de Recibo"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moReciboPara
         txtReciboParaId.Text = ToStr(.ReciboParaId)
         Call txtEmpresaIdLoad(.EmpresaId)
         Call txtGestionIdLoad(.GestionId)
         Call txtTipoCompIdLoad(.TipoCompId)
         txtNroIni.Text = ToStr(.NroIni)
         txtNroActual.Text = ToStr(.NroActual)
         txtFirma.Text = ToStr(.Firma)
         cboTipoHoja.SelectedIndex = ListFindItem(cboTipoHoja, .TipoHojaId)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Parámetro de Recibo"
               .VMOld.ToShowOpe()
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsReciboParaVM)
      oVM = New clsReciboParaVM

      With oVM
         .ReciboParaId = moReciboPara.ReciboParaId
         .EmpresaId = moReciboPara.EmpresaId
         .GestionId = moReciboPara.GestionId
         .Gestion = txtGestionId.Text
         .TipoCompId = moReciboPara.TipoCompId
         .TipoCompDes = txtTipoCompId.Text
         .NroIni = moReciboPara.NroIni
         .NroActual = moReciboPara.NroActual
         .Firma = moReciboPara.Firma
         .TipoHojaId = moReciboPara.TipoHojaId
         .TipoHojaDes = cboTipoHoja.Text

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moReciboPara
         'txtReciboParaId.Text = String.Empty
         'Call txtEmpresaIdLoad(.EmpresaId)
         'txtReciboPara.Text = ToStr(Now.Year)
         'Call txtFechaLoad(.EmpresaId)
         'cboEstado.SelectedIndex = ListFindItem(cboEstado, 11)
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtReciboParaId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      txtGestionId.ReadOnly = True
      txtTipoCompId.ReadOnly = True
      txtNroIni.ReadOnly = True
      txtNroActual.ReadOnly = True
      txtFirma.ReadOnly = True
      cboTipoHoja.Enabled = False

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moReciboPara
         If Not mboolAdding Then
            .ReciboParaId = ToLong(txtReciboParaId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .GestionId = ToLong(txtGestionId.Tag)
         .TipoCompId = ToLong(txtTipoCompId.Tag)
         .NroIni = ToLong(txtNroIni.Text)
         .NroActual = ToLong(txtNroActual.Text)
         .Firma = txtFirma.Text
         .TipoHojaId = ListPosition(cboTipoHoja, cboTipoHoja.SelectedIndex)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtNroIni.Select()
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

         If moReciboPara.Insert() Then
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

         If moReciboPara.Update() Then
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
      Call cboTipoHojaLoad()
   End Sub

   Private Sub cboTipoHojaLoad()
      Dim oTipoHoja As New clsTipoHoja(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoHoja.Items.Clear()

      Try
         With oTipoHoja
            .SelectFilter = clsTipoHoja.SelectFilters.ListBox
            .OrderByFilter = clsTipoHoja.OrderByFilters.TipoHojaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoHojaId, .TipoHojaDes)

                  cboTipoHoja.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoHoja.Dispose()
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

   Private Sub txtGestionIdLoad(ByVal lngGestionId As Long)
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               txtGestionId.Tag = .GestionId
               txtGestionId.Text = ToStr(.Gestion)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Sub

   Private Sub txtTipoCompIdLoad(ByVal lngTipoCompId As Long)
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)

      Try
         With oTipoComp
            .TipoCompId = lngTipoCompId

            If .FindByPK Then
               txtTipoCompId.Tag = .TipoCompId
               txtTipoCompId.Text = ToStr(.TipoCompDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoComp.Dispose()

      End Try
   End Sub

   Private Sub frmReciboParaEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moReciboPara.ReciboParaId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmReciboParaEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moReciboPara.Dispose()
      Call ClearMemory()
   End Sub

End Class
