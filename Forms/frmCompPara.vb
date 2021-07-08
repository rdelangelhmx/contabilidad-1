Public Class frmCompPara
   Inherits System.Windows.Forms.Form

   Private moCompPara As clsCompPara
   Private mlngEmpresaId As Long
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents New1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX

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
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompPara))
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.New1 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Edit1 = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
      Me.mnuEdit = New System.Windows.Forms.MenuItem
      Me.ExplorerBarContainerControl4.SuspendLayout()
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.ebrMain.SuspendLayout()
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
      Me.ExplorerBarContainerControl4.Controls.Add(Me.grdMain)
      Me.ExplorerBarContainerControl4.Location = New System.Drawing.Point(8, 26)
      Me.ExplorerBarContainerControl4.Name = "ExplorerBarContainerControl4"
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 370)
      Me.ExplorerBarContainerControl4.TabIndex = 1
      '
      'grdMain
      '
      Me.grdMain.AllowCardSizing = False
      Me.grdMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
      Me.grdMain.AlternatingColors = True
      Me.grdMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.grdMain.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
      Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.grdMain.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
      Me.grdMain.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
      Me.grdMain.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.Info
      Me.grdMain.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
      Me.grdMain.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(232, Byte), Integer))
      Me.grdMain.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid
      Me.grdMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.grdMain.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
      Me.grdMain.GroupByBoxVisible = False
      Me.grdMain.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty
      Me.grdMain.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
      Me.grdMain.Location = New System.Drawing.Point(0, 0)
      Me.grdMain.Name = "grdMain"
      Me.grdMain.RecordNavigator = True
      Me.grdMain.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
      Me.grdMain.SelectedInactiveFormatStyle.Blend = 0.0!
      Me.grdMain.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection
      Me.grdMain.Size = New System.Drawing.Size(728, 370)
      Me.grdMain.TabIndex = 3
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
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
      Me.ilsMain.Images.SetKeyName(6, "")
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 6
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'ebrMain
      '
      Me.ebrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ebrMain.BackgroundThemeStyle = Janus.Windows.ExplorerBar.BackgroundThemeStyle.Items
      Me.ebrMain.Controls.Add(Me.ExplorerBarContainerControl4)
      ExplorerBarGroup1.Container = True
      ExplorerBarGroup1.ContainerControl = Me.ExplorerBarContainerControl4
      ExplorerBarGroup1.ContainerHeight = 371
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 6)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 403)
      Me.ebrMain.TabIndex = 1
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New2, Me.Edit, Me.Delete, Me.ViewAll, Me.Print, Me.Exit2, Me.Refrescar})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("746d8ee0-e067-4006-bbd6-f1ea8e5c647d")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New1, Me.Separator3, Me.Edit1, Me.Separator2, Me.Refrescar1, Me.Separator1, Me.ViewAll1, Me.Separator4, Me.Print1, Me.Separator5, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(477, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'New1
      '
      Me.New1.Key = "New"
      Me.New1.Name = "New1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Edit1
      '
      Me.Edit1.Key = "Edit"
      Me.Edit1.Name = "Edit1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'ViewAll1
      '
      Me.ViewAll1.Key = "ViewAll"
      Me.ViewAll1.Name = "ViewAll1"
      '
      'Separator4
      '
      Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator4.Key = "Separator"
      Me.Separator4.Name = "Separator4"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'Separator5
      '
      Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator5.Key = "Separator"
      Me.Separator5.Name = "Separator5"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'New2
      '
      Me.New2.ImageIndex = 0
      Me.New2.Key = "New"
      Me.New2.Name = "New2"
      Me.New2.Text = "Aperturar"
      '
      'Edit
      '
      Me.Edit.ImageIndex = 1
      Me.Edit.Key = "Edit"
      Me.Edit.Name = "Edit"
      Me.Edit.Text = "Editar"
      '
      'Delete
      '
      Me.Delete.ImageIndex = 2
      Me.Delete.Key = "Delete"
      Me.Delete.Name = "Delete"
      Me.Delete.Text = "Eliminar"
      '
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 3
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
      '
      'Print
      '
      Me.Print.ImageIndex = 4
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 6
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
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
      Me.TopRebar1.Size = New System.Drawing.Size(752, 28)
      '
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuEdit})
      '
      'mnuShow
      '
      Me.mnuShow.Index = 0
      Me.mnuShow.Text = "Consultar"
      '
      'mnuEdit
      '
      Me.mnuEdit.Index = 1
      Me.mnuEdit.Text = "Editar"
      '
      'frmCompPara
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmCompPara"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Parámetros de Comprobante"
      Me.ExplorerBarContainerControl4.ResumeLayout(False)
      CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.ebrMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ebrMain.ResumeLayout(False)
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
         Case "New"
            Call FormNew()

         Case "Edit"
            Call DataEdit()

         Case "Refrescar"
            Call grdMainLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCompPara_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCompPara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad()
      Try
         With moCompPara
            .SelectFilter = clsCompPara.SelectFilters.Grid
            .WhereFilter = clsCompPara.WhereFilters.Grid
            .OrderByFilter = clsCompPara.OrderByFilters.Grid
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .EstadoId = 11

            If .Open() Then
               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()

               If grdMain.RowCount > 0 Then
                  cdmMain.Commands.Item("New").Enabled = Janus.Windows.UI.InheritableBoolean.False
               Else
                  cdmMain.Commands.Item("New").Enabled = Janus.Windows.UI.InheritableBoolean.True
               End If
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub DataShow()
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         If (grdMain.GetRow.Selected) And (ToLong(grdMain.GetValue("CompParaId")) > 0) Then
            With oCompPara
               .CompParaId = ToLong(grdMain.GetValue("CompParaId"))

               If .FindByPK Then
                  Dim frm As New frmCompParaEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oCompPara

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Sub

   Private Sub FormNew()
      Try
         If Not CompParaExits(clsAppInfo.EmpresaId, clsAppInfo.GestionId) Then
            If MessageBox.Show("¿Realmente Quiere Aperturar los Parámetros?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               If CompParaAdd(clsAppInfo.GestionId) Then
                  If CompParaMesAdd(clsAppInfo.GestionId) Then
                     Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.NUEVO, "Apertura de Parámetros de Comprobante" & "; Gestión " & clsAppInfo.Gestion)
                     Call grdMainLoad()
                  End If
               End If
            End If

         Else
            MessageBox.Show("Ya Existen Parámetros Para la Gestión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub DataEdit()
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            With oCompPara
               .CompParaId = ToLong(grdMain.GetValue("CompParaId"))

               If .FindByPK Then
                  Dim frm As New frmCompParaEdit

                  frm.NewRecord = False
                  frm.Editing = True
                  frm.DataObject = oCompPara
                  frm.ShowDialog()

                  If frm.Changed Then
                     Call grdMainLoad()
                     Call grdMainFindRow(frm.ID)
                  End If

                  frm.Dispose()
               End If
            End With
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Sub

   Private Sub DataDelete()
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         If grdMain.RowCount > 0 Then
            If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
               With oCompPara
                  .WhereFilter = clsCompPara.WhereFilters.PrimaryKey
                  .CompParaId = ToLong(grdMain.GetValue("CompParaId"))

                  If .Delete Then
                     .CloseConection()
                     Call grdMainLoad()
                  End If
               End With
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Sub

   Private Function CompParaAdd(ByVal lngGestionId As Long) As Boolean
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)
      Dim oCompParaAnt As New clsCompPara(clsAppInfo.ConnectString)
      Dim lngGestionIdAnt As Long = GestionIdAnteriorExits()

      Try
         CompParaAdd = False

         If TableExits(clsAppInfo.ConnectString, oCompPara.TableName) Then
            With oCompPara
               .EmpresaId = mlngEmpresaId
               .GestionId = lngGestionId
               .EstadoId = clsEstado.ABIERTO

               oCompParaAnt.SelectFilter = clsCompPara.SelectFilters.All
               oCompParaAnt.WhereFilter = clsCompPara.WhereFilters.TipoCompId
               oCompParaAnt.EmpresaId = mlngEmpresaId
               oCompParaAnt.GestionId = lngGestionIdAnt
               oCompParaAnt.TipoCompId = clsTipoComp.INGRESO

               If oCompParaAnt.Find Then
                  .TipoCompId = oCompParaAnt.TipoCompId
                  .NroIni = oCompParaAnt.NroIni
                  .NroActual = oCompParaAnt.NroIni - 1
                  .NroIniFis = oCompParaAnt.NroIniFis
                  .NroActualFis = oCompParaAnt.NroIniFis - 1
                  .NroAuto = oCompParaAnt.NroAuto
                  .NroAutoGestion = oCompParaAnt.NroAutoGestion
                  .Firma = oCompParaAnt.Firma
                  .TipoHojaId = oCompParaAnt.TipoHojaId
                  .TipoImpresionId = oCompParaAnt.TipoImpresionId
                  .TipoRespImpId = oCompParaAnt.TipoRespImpId
                  .RowsMax = oCompParaAnt.RowsMax
                  .BloqueoAuto = oCompParaAnt.BloqueoAuto
                  .EncabezadoPorHoja = oCompParaAnt.EncabezadoPorHoja
               Else
                  .TipoCompId = clsTipoComp.INGRESO
                  .NroIni = 1
                  .NroActual = 0
                  .NroIniFis = 10001
                  .NroActualFis = 10000
                  .NroAuto = 1
                  .NroAutoGestion = 1
                  .Firma = "_________________________                    _________________________                    _________________________" & vbCrLf & "Vo Bo                                                            Contador                                                        Interesado"
                  .TipoHojaId = 2 'Media Carta
                  .TipoImpresionId = 1 'Gráfica
                  .TipoRespImpId = 1 'Usuario Conectado
                  .RowsMax = 0
                  .BloqueoAuto = 0
                  .EncabezadoPorHoja = 0
               End If

               If .Insert() Then
                  oCompParaAnt.SelectFilter = clsCompPara.SelectFilters.All
                  oCompParaAnt.WhereFilter = clsCompPara.WhereFilters.TipoCompId
                  oCompParaAnt.EmpresaId = mlngEmpresaId
                  oCompParaAnt.GestionId = lngGestionIdAnt
                  oCompParaAnt.TipoCompId = clsTipoComp.EGRESO

                  If oCompParaAnt.Find Then
                     .TipoCompId = oCompParaAnt.TipoCompId
                     .NroIni = oCompParaAnt.NroIni
                     .NroActual = oCompParaAnt.NroIni - 1
                     .NroIniFis = oCompParaAnt.NroIniFis
                     .NroActualFis = oCompParaAnt.NroIniFis - 1
                     .NroAuto = oCompParaAnt.NroAuto
                     .NroAutoGestion = oCompParaAnt.NroAutoGestion
                     .Firma = oCompParaAnt.Firma
                     .TipoHojaId = oCompParaAnt.TipoHojaId
                     .TipoImpresionId = oCompParaAnt.TipoImpresionId
                     .TipoRespImpId = oCompParaAnt.TipoRespImpId
                     .RowsMax = oCompParaAnt.RowsMax
                     .BloqueoAuto = oCompParaAnt.BloqueoAuto
                     .EncabezadoPorHoja = oCompParaAnt.EncabezadoPorHoja
                  Else
                     .TipoCompId = clsTipoComp.EGRESO
                     .NroIni = 1
                     .NroActual = 0
                     .NroIniFis = 10001
                     .NroActualFis = 10000
                     .NroAuto = 1
                     .NroAutoGestion = 1
                     .Firma = "_________________________                    _________________________                    _________________________" & vbCrLf & "Vo Bo                                                            Contador                                                        Interesado"
                     .TipoHojaId = 2 'Media Carta
                     .TipoImpresionId = 1 'Gráfica
                     .TipoRespImpId = 1 'Usuario Conectado
                     .RowsMax = 0
                     .BloqueoAuto = 0
                     .EncabezadoPorHoja = 0
                  End If

                  If .Insert() Then
                     oCompParaAnt.SelectFilter = clsCompPara.SelectFilters.All
                     oCompParaAnt.WhereFilter = clsCompPara.WhereFilters.TipoCompId
                     oCompParaAnt.EmpresaId = mlngEmpresaId
                     oCompParaAnt.GestionId = lngGestionIdAnt
                     oCompParaAnt.TipoCompId = clsTipoComp.TRASPASO

                     If oCompParaAnt.Find Then
                        .TipoCompId = oCompParaAnt.TipoCompId
                        .NroIni = oCompParaAnt.NroIni
                        .NroActual = oCompParaAnt.NroIni - 1
                        .NroIniFis = oCompParaAnt.NroIniFis
                        .NroActualFis = oCompParaAnt.NroIniFis - 1
                        .NroAuto = oCompParaAnt.NroAuto
                        .NroAutoGestion = oCompParaAnt.NroAutoGestion
                        .Firma = oCompParaAnt.Firma
                        .TipoHojaId = oCompParaAnt.TipoHojaId
                        .TipoImpresionId = oCompParaAnt.TipoImpresionId
                        .TipoRespImpId = oCompParaAnt.TipoRespImpId
                        .RowsMax = oCompParaAnt.RowsMax
                        .BloqueoAuto = oCompParaAnt.BloqueoAuto
                        .EncabezadoPorHoja = oCompParaAnt.EncabezadoPorHoja
                     Else
                        .TipoCompId = clsTipoComp.TRASPASO
                        .NroIni = 1
                        .NroActual = 0
                        .NroIniFis = 10001
                        .NroActualFis = 10000
                        .NroAuto = 1
                        .NroAutoGestion = 1
                        .Firma = "_________________________                    _________________________                    _________________________" & vbCrLf & "Vo Bo                                                            Contador                                                        Interesado"
                        .TipoHojaId = 2 'Media Carta
                        .TipoImpresionId = 1 'Gráfica
                        .TipoRespImpId = 1 'Usuario Conectado
                        .RowsMax = 0
                        .BloqueoAuto = 0
                        .EncabezadoPorHoja = 0
                     End If

                     If .Insert() Then
                        CompParaAdd = True
                     End If
                  End If
               End If
            End With
         Else
            Return True
         End If

      Catch exp As Exception
         Throw exp

      Finally
         oCompPara.Dispose()
         oCompParaAnt.Dispose()

      End Try
   End Function

   Private Function CompParaMesAdd(ByVal lngGestionId As Long) As Boolean
      Dim oCompParaMes As New clsCompParaMes(clsAppInfo.ConnectString)
      Dim lngMesId As Long

      Try
         CompParaMesAdd = False

         If TableExits(clsAppInfo.ConnectString, oCompParaMes.TableName) Then
            With oCompParaMes
               .EmpresaId = mlngEmpresaId
               .GestionId = lngGestionId
               .TipoCompId = 1

               For lngMesId = 1 To 12
                  .MesId = lngMesId
                  .NroIni = (lngMesId * 10000) + 1
                  .NroActual = lngMesId * 10000
                  .NroIniFis = (lngMesId * 10000) + 5001
                  .NroActualFis = (lngMesId * 10000) + 5000

                  If .Insert() Then
                     CompParaMesAdd = True
                  End If
               Next

               .TipoCompId = 2

               For lngMesId = 1 To 12
                  .MesId = lngMesId
                  .NroIni = (lngMesId * 10000) + 1
                  .NroActual = lngMesId * 10000
                  .NroIniFis = (lngMesId * 10000) + 5001
                  .NroActualFis = (lngMesId * 10000) + 5000

                  If .Insert() Then
                     CompParaMesAdd = True
                  End If
               Next

               .TipoCompId = 3

               For lngMesId = 1 To 12
                  .MesId = lngMesId
                  .NroIni = (lngMesId * 10000) + 1
                  .NroActual = lngMesId * 10000
                  .NroIniFis = (lngMesId * 10000) + 5001
                  .NroActualFis = (lngMesId * 10000) + 5000

                  If .Insert() Then
                     CompParaMesAdd = True
                  End If
               Next
            End With
         Else
            Return True
         End If

      Catch exp As Exception
         Throw exp

      Finally
         oCompParaMes.Dispose()

      End Try
   End Function

   Private Function GestionIdAnteriorExits() As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdAnteriorExits = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.Gestion
            .EmpresaId = mlngEmpresaId
            .Gestion = clsAppInfo.Gestion - 1
            .EstadoId = 11

            If .Find Then
               GestionIdAnteriorExits = .GestionId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function CompParaExits(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long) As Boolean
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      CompParaExits = False

      Try
         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.GestionId
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId

            If .Find Then
               Return True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Function

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Function GetDataView(ByVal oDataTableOrg As DataTable) As System.Data.DataView
      If grdMain.RootTable.FilterApplied Is Nothing Then
         Return oDataTableOrg.DefaultView

      Else
         Dim oDataTable As DataTable
         Dim oRow As DataRow

         oDataTable = oDataTableOrg.Clone

         For Each oRowMain In grdMain.GetRows()
            oRow = oDataTable.NewRow

            For i = 0 To oRowMain.Cells.Count - 1
               oRow(i) = oRowMain.Cells(i).Value
            Next

            oDataTable.Rows.Add(oRow)
         Next

         Return oDataTable.DefaultView
      End If
   End Function

   Private Sub PrintReport()
      Dim rpt As New rptCompPara

      rpt.DataSource = GetDataView(moCompPara.DataSet.Tables(moCompPara.TableName))

      rpt.lblTitle.Text = "Parámetros de Comprobante"
      rpt.Document.Name = "Parámetros de Comprobante"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompParaId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moCompPara = New clsCompPara(clsAppInfo.ConnectString)
   End Sub

   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Parámetros de Comprobante"
         .ContextMenu = mnuMain

         .RootTable.Columns("CompParaId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("GestionId").Visible = False

         .RootTable.Columns("Gestion").Caption = "Gestión"
         .RootTable.Columns("Gestion").Width = 70
         .RootTable.Columns("Gestion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Gestion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo Comprobante"
         .RootTable.Columns("TipoCompDes").Width = 120
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroIni").Caption = "Nro Inicio"
         .RootTable.Columns("NroIni").Width = 70
         .RootTable.Columns("NroIni").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NroIni").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroActual").Caption = "Nro Actual"
         .RootTable.Columns("NroActual").Width = 70
         .RootTable.Columns("NroActual").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NroActual").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroIniFis").Caption = "Nro Inicio 2"
         .RootTable.Columns("NroIniFis").Width = 70
         .RootTable.Columns("NroIniFis").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NroIniFis").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroActualFis").Caption = "Nro Actual 2"
         .RootTable.Columns("NroActualFis").Width = 70
         .RootTable.Columns("NroActualFis").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NroActualFis").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroAuto").Caption = "Autonumerar"
         .RootTable.Columns("NroAuto").Width = 70
         .RootTable.Columns("NroAuto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NroAuto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NroAutoGestion").Caption = "Por Gestión"
         .RootTable.Columns("NroAutoGestion").Width = 70
         .RootTable.Columns("NroAutoGestion").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NroAutoGestion").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("Firma").Caption = "Firma"
         .RootTable.Columns("Firma").Width = 100
         .RootTable.Columns("Firma").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("Firma").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoHojaId").Visible = False

         .RootTable.Columns("TipoHojaDes").Caption = "Tamaño Hoja"
         .RootTable.Columns("TipoHojaDes").Width = 100
         .RootTable.Columns("TipoHojaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoHojaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoImpresionId").Visible = False

         .RootTable.Columns("TipoImpresionDes").Caption = "Impresión"
         .RootTable.Columns("TipoImpresionDes").Width = 100
         .RootTable.Columns("TipoImpresionDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoImpresionDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoRespImpId").Visible = False

         .RootTable.Columns("TipoRespImpDes").Caption = "Responsable Impresión"
         .RootTable.Columns("TipoRespImpDes").Width = 100
         .RootTable.Columns("TipoRespImpDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoRespImpDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("RowsMax").Caption = "Max. Reg."
         .RootTable.Columns("RowsMax").Width = 70
         .RootTable.Columns("RowsMax").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("RowsMax").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("BloqueoAuto").Caption = "Bloquear"
         .RootTable.Columns("BloqueoAuto").Width = 70
         .RootTable.Columns("BloqueoAuto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("BloqueoAuto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 100
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      End With
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call DataShow()
   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         mnuShow.Enabled = True
         mnuEdit.Enabled = JanusToBooleam(cdmMain.Commands.Item("Edit").Enabled)
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call DataShow()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      Call DataEdit()
   End Sub

   Private Sub frmCompPara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.End) And (e.Shift = True) Then
            Call DataEdit()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCompPara_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moCompPara.Dispose()
      Call ClearMemory()
   End Sub

End Class
