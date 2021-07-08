Public Class frmCompCentroCostoDetEdit
   Inherits System.Windows.Forms.Form

   Private moCompCentroCostoDet As clsCompCentroCostoDet
   Private mdecTipoCambio As Decimal
   Private mlngCompMonedaId As Long
   Private mlngCol As Long
   Private mdecCompDetMonto As Decimal

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mboolNuevoComprobante As Boolean
   Private mlngID As Long
   Private mboolAsientoDescuento As Boolean = False
   Private mlngCentroCostoDetId As Long

   Property TipoCambio() As Decimal
      Get
         Return mdecTipoCambio
      End Get

      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

   Property CompMonedaId() As Long
      Get
         Return mlngCompMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngCompMonedaId = Value
      End Set
   End Property

   Property Col() As Long
      Get
         Return mlngCol
      End Get

      Set(ByVal Value As Long)
         mlngCol = Value
      End Set
   End Property

   Property CompDetMonto() As Decimal
      Get
         Return mdecCompDetMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecCompDetMonto = Value
      End Set
   End Property

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

   WriteOnly Property NuevoComprobante() As Boolean
      Set(ByVal Value As Boolean)
         mboolNuevoComprobante = Value
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

   WriteOnly Property DataObject() As clsCompCentroCostoDet
      Set(ByVal Value As clsCompCentroCostoDet)
         moCompCentroCostoDet = Value
      End Set
   End Property

   WriteOnly Property AsientoDescuento() As Boolean
      Set(ByVal Value As Boolean)
         mboolAsientoDescuento = Value
      End Set
   End Property

   ReadOnly Property CentroCostoDetId() As Long
      Get
         Return mlngCentroCostoDetId
      End Get
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
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents txtCompCentroCostoDetId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEqui As Janus.Windows.GridEX.EditControls.NumericEditBox
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
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtImporte As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents cboCentroCostoDet As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboCentroCostoDet_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompCentroCostoDetEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboCentroCostoDet = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtEqui = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtImporte = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtCompCentroCostoDetId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
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
      CType(Me.cboCentroCostoDet, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 149)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboCentroCostoDet)
      Me.grpMain.Controls.Add(Me.Label6)
      Me.grpMain.Controls.Add(Me.txtEqui)
      Me.grpMain.Controls.Add(Me.txtImporte)
      Me.grpMain.Controls.Add(Me.txtEmpresaId)
      Me.grpMain.Controls.Add(Me.txtCompCentroCostoDetId)
      Me.grpMain.Controls.Add(Me.Label12)
      Me.grpMain.Controls.Add(Me.Label15)
      Me.grpMain.Controls.Add(Me.Label16)
      Me.grpMain.Controls.Add(Me.Label19)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 140)
      Me.grpMain.TabIndex = 159
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboCentroCostoDet
      '
      cboCentroCostoDet_DesignTimeLayout.LayoutString = resources.GetString("cboCentroCostoDet_DesignTimeLayout.LayoutString")
      Me.cboCentroCostoDet.DesignTimeLayout = cboCentroCostoDet_DesignTimeLayout
      Me.cboCentroCostoDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboCentroCostoDet.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboCentroCostoDet.Location = New System.Drawing.Point(116, 64)
      Me.cboCentroCostoDet.Name = "cboCentroCostoDet"
      Me.cboCentroCostoDet.SelectedIndex = -1
      Me.cboCentroCostoDet.SelectedItem = Nothing
      Me.cboCentroCostoDet.Size = New System.Drawing.Size(320, 20)
      Me.cboCentroCostoDet.TabIndex = 2
      Me.cboCentroCostoDet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboCentroCostoDet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label6.Location = New System.Drawing.Point(8, 68)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(104, 16)
      Me.Label6.TabIndex = 211
      Me.Label6.Text = "Actividad"
      '
      'txtEqui
      '
      Me.txtEqui.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEqui.FormatString = "##,##0.000"
      Me.txtEqui.Location = New System.Drawing.Point(116, 112)
      Me.txtEqui.Name = "txtEqui"
      Me.txtEqui.ReadOnly = True
      Me.txtEqui.Size = New System.Drawing.Size(124, 20)
      Me.txtEqui.TabIndex = 5
      Me.txtEqui.TabStop = False
      Me.txtEqui.Text = "0,000"
      Me.txtEqui.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtEqui.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtEqui.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtImporte
      '
      Me.txtImporte.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtImporte.FormatString = "##,##0.000"
      Me.txtImporte.Location = New System.Drawing.Point(116, 88)
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.Size = New System.Drawing.Size(124, 20)
      Me.txtImporte.TabIndex = 3
      Me.txtImporte.Text = "0,000"
      Me.txtImporte.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtImporte.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtImporte.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      'txtCompCentroCostoDetId
      '
      Me.txtCompCentroCostoDetId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCompCentroCostoDetId.Location = New System.Drawing.Point(116, 16)
      Me.txtCompCentroCostoDetId.Name = "txtCompCentroCostoDetId"
      Me.txtCompCentroCostoDetId.ReadOnly = True
      Me.txtCompCentroCostoDetId.Size = New System.Drawing.Size(124, 20)
      Me.txtCompCentroCostoDetId.TabIndex = 0
      Me.txtCompCentroCostoDetId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCompCentroCostoDetId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 116)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(104, 16)
      Me.Label12.TabIndex = 204
      Me.Label12.Text = "Equivalencia"
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 92)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(104, 16)
      Me.Label15.TabIndex = 202
      Me.Label15.Text = "Importe"
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(8, 44)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(104, 16)
      Me.Label16.TabIndex = 201
      Me.Label16.Text = "Empresa"
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
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
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
      'frmCompCentroCostoDetEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 177)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCompCentroCostoDetEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "CompCentroCostoDet Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboCentroCostoDet, System.ComponentModel.ISupportInitialize).EndInit()
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
               mlngID = moCompCentroCostoDet.CompCentroCostoDetId
               mboolChanged = True

               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompCentroCostoDetEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompCentroCostoDetEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()

      If Not mboolAdding Then
         If Not mboolEditing Then
            Call FormShow()
            Call DataReadOnly()
            Me.Text = "Consulta Mov. Actividad"
         Else
            Call FormEdit()
            Me.Text = "Editar Mov. Actividad"
         End If
      Else
         Me.Text = "Nuevo Mov. Actividad"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moCompCentroCostoDet
         txtCompCentroCostoDetId.Text = ToStr(.CompCentroCostoDetId)
         Call txtEmpresaIdLoad(.EmpresaId)
         cboCentroCostoDet.Value = ListFindItem(cboCentroCostoDet, .CentroCostoDetId)

         If mlngCompMonedaId = 1 Then
            If mlngCol = 1 Then
               txtImporte.Text = ToDecStr(.DebeBs)
               txtEqui.Text = ToDecStr(.DebeUs)

            ElseIf mlngCol = 2 Then
               txtImporte.Text = ToDecStr(.HaberBs)
               txtEqui.Text = ToDecStr(.HaberUs)
            End If

         ElseIf mlngCompMonedaId = 2 Then
            If mlngCol = 1 Then
               txtImporte.Text = ToDecStr(.DebeUs)
               txtEqui.Text = ToDecStr(.DebeBs)

            ElseIf mlngCol = 2 Then
               txtImporte.Text = ToDecStr(.HaberUs)
               txtEqui.Text = ToDecStr(.HaberBs)
            End If
         End If

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Mov. Actividad"
               .VMOld.ToShowOpe(clsTipoOpera.CONSULTA)
            End If
         End If
      End With

      mboolShow = False
   End Sub

   Public Function TipoCompDesFind(ByVal lngTipoCompId As Long) As String
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      oTipoComp.TipoCompId = lngTipoCompId
      oTipoComp.FindByPK()
      Return oTipoComp.TipoCompDes
   End Function

   Public Function CompNroFind(ByVal lngCompId As Long, ByRef TipoCompId As Long) As Long
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      oComp.CompId = lngCompId
      oComp.FindByPK()
      TipoCompId = oComp.TipoCompId
      Return oComp.CompNro
   End Function

   Private Sub CloneVM(ByRef oVM As clsCompCentroCostoDetVM)
      oVM = New clsCompCentroCostoDetVM

      If Not mboolNuevoComprobante Then
         With oVM
            .CompCentroCostoDetId = moCompCentroCostoDet.CompCentroCostoDetId
            .CompId = moCompCentroCostoDet.CompId
            .CompNro = CompNroFind(.CompId, .TipoCompId)
            .TipoCompDes = TipoCompDesFind(.TipoCompId)
            .PlanId = moCompCentroCostoDet.PlanId
            .CentroCostoId = moCompCentroCostoDet.CentroCostoId
            .CentroCostoDetId = moCompCentroCostoDet.CentroCostoDetId
            .CentroCostoDetDes = ToStr(cboCentroCostoDet.Text)
            .DebeOrg = moCompCentroCostoDet.DebeOrg
            .HaberOrg = moCompCentroCostoDet.HaberOrg

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Sub FormEdit()
      mboolShow = True
      With moCompCentroCostoDet
         txtCompCentroCostoDetId.Text = ToStr(.CompCentroCostoDetId)
         Call txtEmpresaIdLoad(.EmpresaId)
         cboCentroCostoDet.Value = ListFindItem(cboCentroCostoDet, .CentroCostoDetId)

         If mlngCompMonedaId = 1 Then
            If mlngCol = 1 Then
               txtImporte.Text = ToDecStr(.DebeOrg)
               txtEqui.Text = ToDecStr(ToDecimal(.DebeOrg / mdecTipoCambio))

            ElseIf mlngCol = 2 Then
               txtImporte.Text = ToDecStr(.HaberOrg)
               txtEqui.Text = ToDecStr(ToDecimal(.HaberOrg / mdecTipoCambio))
            End If

         ElseIf mlngCompMonedaId = 2 Then
            If mlngCol = 1 Then
               txtImporte.Text = ToDecStr(.DebeOrg)
               txtEqui.Text = ToDecStr(ToDecimal(.DebeOrg * mdecTipoCambio))

            ElseIf mlngCol = 2 Then
               txtImporte.Text = ToDecStr(.HaberOrg)
               txtEqui.Text = ToDecStr(ToDecimal(.HaberOrg * mdecTipoCambio))
            End If
         End If

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)
         End If
      End With

      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moCompCentroCostoDet
         txtCompCentroCostoDetId.Text = String.Empty
         Call txtEmpresaIdLoad(.EmpresaId)
         cboCentroCostoDet.Value = Nothing
         cboCentroCostoDet.Text = ""

         If mlngCompMonedaId = 1 Then
            If mlngCol = 1 Then
               txtImporte.Text = ToDecStr(.DebeOrg)
               txtEqui.Text = ToDecStr(ToDecimal(.DebeOrg / mdecTipoCambio))

            ElseIf mlngCol = 2 Then
               txtImporte.Text = ToDecStr(.HaberOrg)
               txtEqui.Text = ToDecStr(ToDecimal(.HaberOrg / mdecTipoCambio))
            End If

         ElseIf mlngCompMonedaId = 2 Then
            If mlngCol = 1 Then
               txtImporte.Text = ToDecStr(.DebeOrg)
               txtEqui.Text = ToDecStr(ToDecimal(.DebeOrg * mdecTipoCambio))

            ElseIf mlngCol = 2 Then
               txtImporte.Text = ToDecStr(.HaberOrg)
               txtEqui.Text = ToDecStr(ToDecimal(.HaberOrg * mdecTipoCambio))
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtCompCentroCostoDetId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      cboCentroCostoDet.ReadOnly = True
      txtImporte.ReadOnly = True
      txtEqui.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moCompCentroCostoDet
         If Not mboolAdding Then
            .CompCentroCostoDetId = ToLong(txtCompCentroCostoDetId.Text)
         End If

         .CentroCostoDetId = ListPosition(cboCentroCostoDet)

         If mlngCompMonedaId = 1 Then
            If mlngCol = 1 Then
               .DebeOrg = ToDecimal(txtImporte.Text)
               .HaberOrg = 0
               .DebeBs = ToDecimal(txtImporte.Text)
               .HaberBs = 0
               .DebeUs = ToDecimal(txtEqui.Text)
               .HaberUs = 0

            ElseIf mlngCol = 2 Then
               .DebeOrg = 0
               .HaberOrg = ToDecimal(txtImporte.Text)
               .DebeBs = 0
               .HaberBs = ToDecimal(txtImporte.Text)
               .DebeUs = 0
               .HaberUs = ToDecimal(txtEqui.Text)
            End If

         ElseIf mlngCompMonedaId = 2 Then
            If mlngCol = 1 Then
               .DebeOrg = ToDecimal(txtImporte.Text)
               .HaberOrg = 0
               .DebeBs = ToDecimal(txtEqui.Text)
               .HaberBs = 0
               .DebeUs = ToDecimal(txtImporte.Text)
               .HaberUs = 0

            ElseIf mlngCol = 2 Then
               .DebeOrg = 0
               .HaberOrg = ToDecimal(txtImporte.Text)
               .DebeBs = 0
               .HaberBs = ToDecimal(txtEqui.Text)
               .DebeUs = 0
               .HaberUs = ToDecimal(txtImporte.Text)
            End If
         End If

         .EstadoId = 13

         If clsAppInfo.RegistrarBitacora And Not mboolNuevoComprobante Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      cboCentroCostoDet.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If FormCheck() Then
            If Not mboolAsientoDescuento Then
               If mboolAdding Then
                  DataSave = DataAdd()
               Else
                  DataSave = DataUpdate()
               End If
            Else
               mlngCentroCostoDetId = moCompCentroCostoDet.CentroCostoDetId
               DataSave = True
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

         If moCompCentroCostoDet.Insert() Then
            If CompCentroCostoDetResto(moCompCentroCostoDet.CompId) Then
               mboolAdding = False
               DataAdd = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moCompCentroCostoDet.Update() Then
            If CompCentroCostoDetResto(moCompCentroCostoDet.CompId) Then
               DataUpdate = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If Not mboolAsientoDescuento Then
         If (CompCentroCostoDetMonto() + ToDecimal(txtImporte.Text)) > mdecCompDetMonto Then
            FormCheck = False
            Throw New Exception("El Monto de Actividad Excede al Monto de la Cuenta")
         End If
      Else
         If cboCentroCostoDet.SelectedIndex = -1 Then
            strMsg &= "Seleccione la Actividad"
         End If
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Function CompCentroCostoDetMonto() As Decimal
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      Dim decMonto As Decimal

      Try
         CompCentroCostoDetMonto = 0
         decMonto = 0

         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
            .EmpresaId = moCompCentroCostoDet.EmpresaId
            .CompId = moCompCentroCostoDet.CompId
            .CompDetId = moCompCentroCostoDet.CompDetId

            If .Open Then
               Do While .Read()
                  If mboolEditing Then
                     If ToLong(txtCompCentroCostoDetId.Text) <> .CompCentroCostoDetId Then
                        If mlngCol = 1 Then
                           decMonto += .DebeOrg

                        ElseIf mlngCol = 2 Then
                           decMonto += .HaberOrg
                        End If
                     End If
                  Else
                     If mlngCol = 1 Then
                        decMonto += .DebeOrg

                     ElseIf mlngCol = 2 Then
                        decMonto += .HaberOrg
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         CompCentroCostoDetMonto = decMonto
         CompCentroCostoDetMonto = ToDecimalMinor(CompCentroCostoDetMonto)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetResto(ByVal lngCompId As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      Try
         CompCentroCostoDetResto = False

         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompId
            .EmpresaId = moCompCentroCostoDet.EmpresaId
            .CompId = lngCompId

            If .Open Then
               Do While .Read()
                  If .CompCentroCostoDetId <> moCompCentroCostoDet.CompCentroCostoDetId Then
                     If mlngCompMonedaId = 1 Then
                        .DebeBs = .DebeOrg
                        .HaberBs = .HaberOrg
                        .DebeUs = ToDecimal(.DebeOrg / mdecTipoCambio)
                        .HaberUs = ToDecimal(.HaberOrg / mdecTipoCambio)

                     ElseIf mlngCompMonedaId = 2 Then
                        .DebeBs = ToDecimal(.DebeOrg * mdecTipoCambio)
                        .HaberBs = ToDecimal(.HaberOrg * mdecTipoCambio)
                        .DebeUs = .DebeOrg
                        .HaberUs = .HaberOrg
                     End If

                     .Fecha = ToDate(.Fecha)
                     .EstadoId = 13

                     If .Update() Then
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

         CompCentroCostoDetResto = True

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

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

   Private Sub FormInit()
      Call FormCenter(Me)

      txtImporte.FormatString = DecimalMask()
      txtEqui.FormatString = DecimalMask()

      If mboolAsientoDescuento Or ExigirActividad() Then
         txtImporte.Enabled = False
         txtEqui.Enabled = False
      End If
   End Sub

   Private Sub ComboLoad()
      Call cboCentroCostoDetLoad(moCompCentroCostoDet.CentroCostoId)
   End Sub

   Private Sub cboCentroCostoDetLoad(ByVal lngCentroCostoId As Long)
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)

      Try
         With oCentroCostoDet
            .SelectFilter = clsCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCentroCostoDet.WhereFilters.EstadoId
            .OrderByFilter = clsCentroCostoDet.OrderByFilters.CentroCostoDetDes
            .EmpresaId = moCompCentroCostoDet.EmpresaId
            .CentroCostoId = lngCentroCostoId
            .CentroCostoDetId = moCompCentroCostoDet.CentroCostoDetId
            .EstadoId = 1

            If .Open() Then
               With cboCentroCostoDet
                  .DropDownList.Columns.Clear()

                  .DropDownList.Columns.Add("CentroCostoDetId")
                  .DropDownList.Columns("CentroCostoDetId").DataMember = "CentroCostoDetId"
                  .DropDownList.Columns("CentroCostoDetId").Visible = False

                  .DropDownList.Columns.Add("CentroCostoDetCod")
                  .DropDownList.Columns("CentroCostoDetCod").Caption = "Cuenta"
                  .DropDownList.Columns("CentroCostoDetCod").DataMember = "CentroCostoDetCod"
                  .DropDownList.Columns("CentroCostoDetCod").Width = 100

                  .DropDownList.Columns.Add("CentroCostoDetDes")
                  .DropDownList.Columns("CentroCostoDetDes").Caption = "Descripción"
                  .DropDownList.Columns("CentroCostoDetDes").DataMember = "CentroCostoDetDes"
                  .DropDownList.Columns("CentroCostoDetDes").Width = 205

                  .DataMember = oCentroCostoDet.TableName
                  .DataSource = oCentroCostoDet.DataSet

                  .ValueMember = "CentroCostoDetId"
                  .DisplayMember = "CentroCostoDetDes"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCentroCostoDet.Dispose()

      End Try
   End Sub

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

   Private Sub txtEquiLoad(ByVal decValue As Decimal)
      If mlngCompMonedaId = 1 Then
         txtEqui.Text = ToDecStr(decValue / mdecTipoCambio)

      ElseIf mlngCompMonedaId = 2 Then
         txtEqui.Text = ToDecStr(decValue * mdecTipoCambio)
      End If
   End Sub

   Private Sub txtImporte_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtImporte.KeyUp
      If ToDecimal(txtImporte.Text) <> 0 Then
         Call txtEquiLoad(ToDecimal(txtImporte.Text))
      Else
         txtEqui.Text = "0"
      End If
   End Sub

   Private Sub cboCentroCostoDet_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCentroCostoDet.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If e.KeyCode = Keys.F3 Then
            If mboolAdding Or mboolEditing Then
               Dim frm As New frmCentroCostoDetEdit
               Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)

               Try
                  With frm
                     .NewRecord = True
                     .Editing = False

                     oCentroCostoDet.EmpresaId = moCompCentroCostoDet.EmpresaId
                     oCentroCostoDet.CentroCostoId = moCompCentroCostoDet.CentroCostoId

                     .DataObject = oCentroCostoDet
                     .ShowDialog()

                     If .Changed Then
                        Call cboCentroCostoDetLoad(moCompCentroCostoDet.CentroCostoId)
                        cboCentroCostoDet.Value = ListFindItem(cboCentroCostoDet, ToLong(frm.ID))
                     End If

                     frm.Dispose()
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Finally
                  oCentroCostoDet.Dispose()

               End Try
            End If
         ElseIf e.KeyCode = Keys.F2 Then
            Dim frm As New frmCentroCostoDetFind

            Try
               With frm
                  .EmpresaId = moCompCentroCostoDet.EmpresaId
                  .CentroCostoId = moCompCentroCostoDet.CentroCostoId
                  .ShowDialog()

                  If .Changed Then
                     cboCentroCostoDet.Value = ListFindItem(cboCentroCostoDet, ToLong(frm.ID))
                     cboCentroCostoDet.Refresh()
                  End If

                  frm.Dispose()
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End Try
         End If
      End If
   End Sub

   Private Sub frmCompCentroCostoDetEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moCompCentroCostoDet.CompCentroCostoDetId
               mboolChanged = True

               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompCentroCostoDetEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompCentroCostoDet.Dispose()
      Call ClearMemory()
   End Sub

   Private Function ExigirActividad() As Boolean
      ExigirActividad = False

      If clsAppInfo.ExigirActAnaAdd Then
         Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

         Try
            With oCompPlanAdd
               .SelectFilter = clsCompPlanAdd.SelectFilters.All
               .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
               .EmpresaId = moCompCentroCostoDet.EmpresaId
               .CompId = moCompCentroCostoDet.CompId
               .CompDetId = moCompCentroCostoDet.CompDetId

               If .Open Then
                  If .RowsCount > 1 Then
                     ExigirActividad = True
                  End If
               End If
            End With
         Catch ex As Exception
            Throw ex
         End Try
      End If
   End Function
End Class
