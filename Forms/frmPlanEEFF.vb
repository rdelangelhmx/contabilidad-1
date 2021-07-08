Public Class frmPlanEEFF
   Inherits System.Windows.Forms.Form

   Private moPlanEEFF As clsPlanEEFF
   Private mlngEmpresaId As Long
   Private mlngTipoEEFFId As Long = 1
   Private mstrTipoEEFFDes As String = "Plan de Flujo de Efectivo"

   Dim moDataSet As DataSet
   Dim moDataTable As DataTable
   Dim moDataColumn As DataColumn
   Dim moDataRow As DataRow

   Private mboolFind As Boolean
   Private mboolChanged As Boolean
   Private mlngID As Long

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property Find() As Boolean
      Get
         Return mboolFind
      End Get

      Set(ByVal Value As Boolean)
         mboolFind = Value
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
   Friend WithEvents ilsTree As System.Windows.Forms.ImageList
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuConsultar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuAdicionar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEditar As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEliminar As System.Windows.Forms.MenuItem
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents trvMain As System.Windows.Forms.TreeView
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents New1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Find1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Check As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Check1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents FindFast As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents FindFast1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanEEFF))
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuConsultar = New System.Windows.Forms.MenuItem
      Me.mnuAdicionar = New System.Windows.Forms.MenuItem
      Me.mnuEditar = New System.Windows.Forms.MenuItem
      Me.mnuEliminar = New System.Windows.Forms.MenuItem
      Me.ilsTree = New System.Windows.Forms.ImageList(Me.components)
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.trvMain = New System.Windows.Forms.TreeView
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.New1 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Edit1 = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Delete1 = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Check1 = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("Find")
      Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.FindFast1 = New Janus.Windows.UI.CommandBars.UICommand("FindFast")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.Find1 = New Janus.Windows.UI.CommandBars.UICommand("Find")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Check = New Janus.Windows.UI.CommandBars.UICommand("Check")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.FindFast = New Janus.Windows.UI.CommandBars.UICommand("FindFast")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.uiBackground.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConsultar, Me.mnuAdicionar, Me.mnuEditar, Me.mnuEliminar})
      '
      'mnuConsultar
      '
      Me.mnuConsultar.Index = 0
      Me.mnuConsultar.Text = "Consultar"
      '
      'mnuAdicionar
      '
      Me.mnuAdicionar.Index = 1
      Me.mnuAdicionar.Text = "Nuevo"
      '
      'mnuEditar
      '
      Me.mnuEditar.Index = 2
      Me.mnuEditar.Text = "Editar"
      '
      'mnuEliminar
      '
      Me.mnuEliminar.Index = 3
      Me.mnuEliminar.Text = "Eliminar"
      '
      'ilsTree
      '
      Me.ilsTree.ImageStream = CType(resources.GetObject("ilsTree.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsTree.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsTree.Images.SetKeyName(0, "")
      Me.ilsTree.Images.SetKeyName(1, "")
      Me.ilsTree.Images.SetKeyName(2, "")
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.UiGroupBox1)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 5
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.UiGroupBox1.Controls.Add(Me.trvMain)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 0)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(736, 406)
      Me.UiGroupBox1.TabIndex = 0
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'trvMain
      '
      Me.trvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.trvMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.trvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.trvMain.ContextMenu = Me.mnuMain
      Me.trvMain.ImageIndex = 0
      Me.trvMain.ImageList = Me.ilsTree
      Me.trvMain.Location = New System.Drawing.Point(8, 12)
      Me.trvMain.Name = "trvMain"
      Me.trvMain.SelectedImageIndex = 0
      Me.trvMain.Size = New System.Drawing.Size(720, 386)
      Me.trvMain.TabIndex = 161
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
      Me.ilsMain.Images.SetKeyName(7, "")
      Me.ilsMain.Images.SetKeyName(8, "")
      Me.ilsMain.Images.SetKeyName(9, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New2, Me.Edit, Me.Delete, Me.Find1, Me.Print, Me.Exit2, Me.Check, Me.Refrescar, Me.FindFast})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("cf56bcb2-a64f-42eb-bf46-c838b504a780")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New1, Me.Separator1, Me.Edit1, Me.Separator2, Me.Delete1, Me.Separator3, Me.Check1, Me.Separator7, Me.Refrescar1, Me.Separator6, Me.ViewAll1, Me.Separator8, Me.FindFast1, Me.Separator4, Me.Print1, Me.Separator5, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(579, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'New1
      '
      Me.New1.Key = "New"
      Me.New1.Name = "New1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
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
      'Delete1
      '
      Me.Delete1.Key = "Delete"
      Me.Delete1.Name = "Delete1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'Check1
      '
      Me.Check1.Key = "Check"
      Me.Check1.Name = "Check1"
      Me.Check1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'ViewAll1
      '
      Me.ViewAll1.ImageIndex = 6
      Me.ViewAll1.Key = "Find"
      Me.ViewAll1.Name = "ViewAll1"
      Me.ViewAll1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
      '
      'Separator8
      '
      Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator8.Key = "Separator"
      Me.Separator8.Name = "Separator8"
      '
      'FindFast1
      '
      Me.FindFast1.Key = "FindFast"
      Me.FindFast1.Name = "FindFast1"
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
      Me.New2.Text = "Nuevo"
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
      'Find1
      '
      Me.Find1.ImageIndex = 3
      Me.Find1.Key = "Find"
      Me.Find1.Name = "Find1"
      Me.Find1.Text = "Buscar"
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
      'Check
      '
      Me.Check.ImageIndex = 7
      Me.Check.Key = "Check"
      Me.Check.Name = "Check"
      Me.Check.Text = "Seleccionar"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 8
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
      '
      'FindFast
      '
      Me.FindFast.ImageIndex = 9
      Me.FindFast.Key = "FindFast"
      Me.FindFast.Name = "FindFast"
      Me.FindFast.Text = "Adicionar Cuentas"
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
      'frmPlanEEFF
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmPlanEEFF"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Plan de Cuentas de Flujo de Efectivo"
      CType(Me.uiBackground, System.ComponentModel.ISupportInitialize).EndInit()
      Me.uiBackground.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
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

         Case "Delete"
            Call DataDelete()

         Case "Refrescar"
            Call trvMainLoad()

            'Case "Find"
            '   Call RecordFind()

         Case "FindFast"
            Call RecordFindFast()

         Case "Check"
            Call RecordSelected()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPlanEEFF_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPlanEEFF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call trvMainLoad()
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub trvMainLoad()
      Dim oNodePadre As TreeNode
      Try
         trvMain.Nodes.Clear()
         'trvMain.CheckBoxes = True
         oNodePadre = New TreeNode(mstrTipoEEFFDes)
         oNodePadre.Tag = 0
         oNodePadre.ImageIndex = 0
         oNodePadre.SelectedImageIndex = 0
         trvMain.Nodes.Add(oNodePadre)
         Call trvSubMainLoad(oNodePadre, 0)
         If trvMain.GetNodeCount(True) > 0 Then
            trvMain.SelectedNode = trvMain.Nodes(0)
            oNodePadre.Expand()
         End If
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub trvSubMainLoad(ByVal oNodoPadre As TreeNode, ByVal lngPlanEEFFPadreId As Long)
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      Dim oNodeHijo As TreeNode
      Try
         With oPlanEEFF
            .SelectFilter = clsPlanEEFF.SelectFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
            .OrderByFilter = clsPlanEEFF.OrderByFilters.Orden
            .EmpresaId = mlngEmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId

            If .Open Then
               Do While .Read()
                  oNodeHijo = New TreeNode("(" + .PlanEEFFCta + ")  " + .PlanEEFFDes)
                  oNodeHijo.Tag = .PlanEEFFId

                  If TieneHijos(.PlanEEFFId) Then
                     Call SetNodeImage(oNodeHijo, .EsAna) ', .TieneAnaAdd)
                     Call trvSubMainLoad(oNodeHijo, .PlanEEFFId)
                  Else
                     Call SetNodeImage(oNodeHijo, .EsAna) ', .TieneAnaAdd)

                     '   'If .TieneAnaAdd And cdmMain.Commands.Item("Ana").IsChecked Then
                     '   If .TieneAnaAdd And chkIncluirPlanAdd.Checked Then
                     '      Call trvSubMainAnaLoad(oNodeHijo, .PlanId)
                     '   End If
                  End If
                  oNodoPadre.Nodes.Add(oNodeHijo)
                  .MoveNext()
               Loop
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanEEFF.Dispose()
      End Try
   End Sub

   'Private Sub trvMainLoad()
   'Dim oNodeCero As TreeNode
   'Dim oNodeUno As TreeNode
   'Dim oNodeDos As TreeNode
   'Dim oNodeTres As TreeNode
   'Dim oNodeCuatro As TreeNode
   'Dim oNodeCinco As TreeNode

   'Dim oPlanEEFFUno As New clsPlanEEFF(clsAppInfo.ConnectString)
   'Dim oPlanEEFFDos As New clsPlanEEFF(clsAppInfo.ConnectString)
   'Dim oPlanEEFFTres As New clsPlanEEFF(clsAppInfo.ConnectString)
   'Dim oPlanEEFFCuatro As New clsPlanEEFF(clsAppInfo.ConnectString)
   'Dim oPlanEEFFCinco As New clsPlanEEFF(clsAppInfo.ConnectString)

   'Try
   '   trvMain.Nodes.Clear()

   '   oNodeCero = New TreeNode(mstrTipoEEFFDes)
   '   oNodeCero.Tag = 0
   '   oNodeCero.ImageIndex = 0
   '   oNodeCero.SelectedImageIndex = 0
   '   trvMain.Nodes.Add(oNodeCero)

   '   With oPlanEEFFUno
   '      .SelectFilter = clsPlanEEFF.SelectFilters.All
   '      .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
   '      .OrderByFilter = clsPlanEEFF.OrderByFilters.Orden
   '      .EmpresaId = mlngEmpresaId
   '      .TipoEEFFId = mlngTipoEEFFId
   '      .PlanEEFFPadreId = 0

   '      If .Open Then
   '         Do While .Read()
   '            If .PlanId > 0 Then
   '               oNodeUno = New TreeNode(PlanDesFind(.PlanId))
   '            Else
   '               oNodeUno = New TreeNode("(" + .PlanEEFFCta + ")  " + .PlanEEFFDes)
   '            End If

   '            oNodeUno.Tag = .PlanEEFFId
   '            Call SetNodeImage(oNodeUno, .PlanId)

   '            With oPlanEEFFDos
   '               .SelectFilter = clsPlanEEFF.SelectFilters.All
   '               .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
   '               .OrderByFilter = clsPlanEEFF.OrderByFilters.Orden
   '               .EmpresaId = mlngEmpresaId
   '               .TipoEEFFId = mlngTipoEEFFId
   '               .PlanEEFFPadreId = oNodeUno.Tag

   '               If .Open Then
   '                  Do While .Read()
   '                     If .PlanId > 0 Then
   '                        oNodeDos = New TreeNode(PlanDesFind(.PlanId))
   '                     Else
   '                        oNodeDos = New TreeNode("(" + .PlanEEFFCta + ")  " + .PlanEEFFDes)
   '                     End If

   '                     oNodeDos.Tag = .PlanEEFFId
   '                     Call SetNodeImage(oNodeDos, .PlanId)

   '                     With oPlanEEFFTres
   '                        .SelectFilter = clsPlanEEFF.SelectFilters.All
   '                        .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
   '                        .OrderByFilter = clsPlanEEFF.OrderByFilters.Orden
   '                        .EmpresaId = mlngEmpresaId
   '                        .TipoEEFFId = mlngTipoEEFFId
   '                        .PlanEEFFPadreId = oNodeDos.Tag

   '                        If .Open Then
   '                           Do While .Read()
   '                              If .PlanId > 0 Then
   '                                 oNodeTres = New TreeNode(PlanDesFind(.PlanId))
   '                              Else
   '                                 oNodeTres = New TreeNode("(" + .PlanEEFFCta + ")  " + .PlanEEFFDes)
   '                              End If

   '                              oNodeTres.Tag = .PlanEEFFId
   '                              Call SetNodeImage(oNodeTres, .PlanId)

   '                              With oPlanEEFFCuatro
   '                                 .SelectFilter = clsPlanEEFF.SelectFilters.All
   '                                 .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
   '                                 .OrderByFilter = clsPlanEEFF.OrderByFilters.Orden
   '                                 .EmpresaId = mlngEmpresaId
   '                                 .TipoEEFFId = mlngTipoEEFFId
   '                                 .PlanEEFFPadreId = oNodeTres.Tag

   '                                 If .Open Then
   '                                    Do While .Read()
   '                                       If .PlanId > 0 Then
   '                                          oNodeCuatro = New TreeNode(PlanDesFind(.PlanId))
   '                                       Else
   '                                          oNodeCuatro = New TreeNode("(" + .PlanEEFFCta + ")  " + .PlanEEFFDes)
   '                                       End If

   '                                       oNodeCuatro.Tag = .PlanEEFFId
   '                                       Call SetNodeImage(oNodeCuatro, .PlanId)

   '                                       With oPlanEEFFCinco
   '                                          .SelectFilter = clsPlanEEFF.SelectFilters.All
   '                                          .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
   '                                          .OrderByFilter = clsPlanEEFF.OrderByFilters.Orden
   '                                          .EmpresaId = mlngEmpresaId
   '                                          .TipoEEFFId = mlngTipoEEFFId
   '                                          .PlanEEFFPadreId = oNodeCuatro.Tag

   '                                          If .Open Then
   '                                             Do While .Read()
   '                                                oNodeCinco = New TreeNode("(" + .PlanEEFFCta + ")  " + .PlanEEFFDes)
   '                                                oNodeCinco.Tag = .PlanEEFFId
   '                                                Call SetNodeImage(oNodeCinco, .PlanId)

   '                                                oNodeCuatro.Nodes.Add(oNodeCinco)
   '                                                .MoveNext()
   '                                             Loop
   '                                          End If
   '                                       End With 'oPlanCinco

   '                                       oNodeTres.Nodes.Add(oNodeCuatro)
   '                                       .MoveNext()
   '                                    Loop
   '                                 End If
   '                              End With 'oPlanCuatro

   '                              oNodeDos.Nodes.Add(oNodeTres)
   '                              .MoveNext()
   '                           Loop
   '                        End If
   '                     End With 'oPlanTres

   '                     oNodeUno.Nodes.Add(oNodeDos)
   '                     .MoveNext()
   '                  Loop
   '               End If
   '            End With 'oPlanDos

   '            oNodeCero.Nodes.Add(oNodeUno)
   '            .MoveNext()
   '         Loop
   '      End If
   '   End With 'oPlanUno

   '   If trvMain.GetNodeCount(True) > 0 Then
   '      trvMain.SelectedNode = trvMain.Nodes(0)
   '      oNodeCero.Expand()
   '   End If

   'Catch exp As Exception
   '   MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   'Finally
   '   oPlanEEFFUno.Dispose()
   '   oPlanEEFFDos.Dispose()
   '   oPlanEEFFTres.Dispose()
   '   oPlanEEFFCuatro.Dispose()
   '   oPlanEEFFCinco.Dispose()

   'End Try
   '  End Sub

   'Private Function FindNode(ByVal lngPlanEEFFId As Long) As Boolean
   '   Dim oNodeCero As TreeNode
   '   Dim oNodeUno As TreeNode
   '   Dim oNodeDos As TreeNode
   '   Dim oNodeTres As TreeNode
   '   Dim oNodeCuatro As TreeNode
   '   Dim oNodeCinco As TreeNode
   '   Dim oNodeSeis As TreeNode
   '   Dim oNodeSiete As TreeNode
   '   Dim oNodeOcho As TreeNode
   '   Dim oNodeNueve As TreeNode
   '   Dim oNodeDiez As TreeNode

   '   Try
   '      For Each oNodeCero In trvMain.Nodes
   '         If oNodeCero.Tag = lngPlanEEFFId Then
   '            oNodeCero.Expand()
   '            trvMain.SelectedNode = oNodeCero
   '            Return True
   '         End If

   '         For Each oNodeUno In oNodeCero.Nodes
   '            If oNodeUno.Tag = lngPlanEEFFId Then
   '               oNodeUno.Expand()
   '               trvMain.SelectedNode = oNodeUno
   '               Return True
   '            End If

   '            For Each oNodeDos In oNodeUno.Nodes
   '               If oNodeDos.Tag = lngPlanEEFFId Then
   '                  oNodeDos.Expand()
   '                  trvMain.SelectedNode = oNodeDos
   '                  Return True
   '               End If

   '               For Each oNodeTres In oNodeDos.Nodes
   '                  If oNodeTres.Tag = lngPlanEEFFId Then
   '                     oNodeTres.Expand()
   '                     trvMain.SelectedNode = oNodeTres
   '                     Return True
   '                  End If

   '                  For Each oNodeCuatro In oNodeTres.Nodes
   '                     If oNodeCuatro.Tag = lngPlanEEFFId Then
   '                        oNodeCuatro.Expand()
   '                        trvMain.SelectedNode = oNodeCuatro
   '                        Return True
   '                     End If

   '                     For Each oNodeCinco In oNodeCuatro.Nodes
   '                        If oNodeCinco.Tag = lngPlanEEFFId Then
   '                           oNodeCinco.Expand()
   '                           trvMain.SelectedNode = oNodeCinco
   '                           Return True
   '                        End If
   '                     Next 'oNodeCinco
   '                  Next 'oNodeCuatro
   '               Next 'oNodeTres
   '            Next 'oNodeDos
   '         Next 'oNodeUno
   '      Next 'oNode Cero

   '      Return False

   '   Catch exp As Exception
   '      Throw exp
   '      Return False
   '   End Try
   'End Function

   Private Sub DataShow()
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      Try
         With oPlanEEFF
            .PlanEEFFId = trvMain.SelectedNode.Tag

            If .FindByPK Then
               Dim frm As New frmPlanEEFFEdit

               frm.NewRecord = False
               frm.Editing = False
               frm.DataObject = oPlanEEFF

               frm.ShowDialog()
               frm.Dispose()

            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Sub

   Private Sub FormNew()
      Dim frm As New frmPlanEEFFEdit
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      Dim lngGrupo As Long

      Try
         If NivelFind(trvMain.SelectedNode.Tag) > 1 Then
            If Not EsAnaFind(trvMain.SelectedNode.Tag) Then
               With frm
                  .NewRecord = True
                  .Editing = False

                  oPlanEEFF.EmpresaId = mlngEmpresaId
                  oPlanEEFF.TipoEEFFId = mlngTipoEEFFId
                  oPlanEEFF.PlanEEFFPadreId = ToLong(trvMain.SelectedNode.Tag)
                  'oPlanEEFF.Grupo = lngGrupo

                  .DataObject = oPlanEEFF
                  .ShowDialog()

                  If .Changed Then
                     Call trvMainLoad()
                     Call FindNodeWithAna(trvMain.Nodes, frm.ID, False)
                  End If
               End With
            Else
               MessageBox.Show("Seleccione un Grupo de Cuentas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Imposible Crear un Grupo de Cuentas a ese Nivel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()
         frm.Dispose()
      End Try
   End Sub

   Private Sub DataEdit()
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      Try
         If trvMain.SelectedNode.IsSelected Then
            If NivelFind(trvMain.SelectedNode.Tag) > 1 Then
               With oPlanEEFF
                  .PlanEEFFId = ToLong(trvMain.SelectedNode.Tag)

                  If .FindByPK Then
                     Dim frm As New frmPlanEEFFEdit

                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oPlanEEFF
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call trvMainLoad()
                        Call FindNodeWithAna(trvMain.Nodes, frm.ID, False)
                        frm = Nothing
                     End If
                  End If
               End With
            Else
               MessageBox.Show("Imposible Editar una Cuenta de ese Nivel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Sub

   Private Sub CloneVM(ByRef oVM As clsPlanEEFFVM)
      If clsAppInfo.RegistrarBitacora Then
         oVM = New clsPlanEEFFVM

         With oVM
            Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
            oPlanEEFF.PlanEEFFId = ToLong(trvMain.SelectedNode.Tag)
            oPlanEEFF.FindByPK()

            .PlanEEFFId = oPlanEEFF.PlanEEFFId
            .PlanEEFFDes = oPlanEEFF.PlanEEFFDes
            .PlanEEFFCta = oPlanEEFF.PlanEEFFCta

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Sub DataDelete()
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      Dim lngID As Long

      Try
         If trvMain.SelectedNode.IsSelected Then
            If NivelFind(trvMain.SelectedNode.Tag) > 2 Then
               If NumeroHijos(trvMain.SelectedNode.Tag) = 0 Then
                  If Not TieneMovimiento(trvMain.SelectedNode.Tag) Then
                     If MessageBox.Show("¿Realmente quiere eliminar el registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        lngID = ToLong(trvMain.SelectedNode.Parent.Tag)

                        With oPlanEEFF
                           .WhereFilter = clsPlanEEFF.WhereFilters.PrimaryKey
                           .PlanEEFFId = ToLong(trvMain.SelectedNode.Tag)

                           Call CloneVM(.VMNew)
                           If .Delete Then

                              .CloseConection()
                              Call trvMainLoad()
                              Call FindNodeWithAna(trvMain.Nodes, lngID, False)
                           End If
                        End With
                     End If
                  Else
                     MessageBox.Show("Imposible Eliminar la Cuenta Debido a que ya Tiene Movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Imposible Eliminar el Grupo Debido a que Tiene Cuentas que Dependen de la Misma", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Imposible Eliminar una Cuenta de ese Nivel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Debe Seleccionar una Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanEEFF.Dispose()
      End Try
   End Sub

   Private Function PlanDesFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      PlanDesFind = ""

      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               PlanDesFind = "(" + .PlanCta + ")  " + .PlanDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function NivelFind(ByVal lngPlanEEFFId As Long) As Long ', ByRef lngGrupo As Long) As Long
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      Try
         NivelFind = 0

         With oPlanEEFF
            .PlanEEFFId = lngPlanEEFFId

            If .FindByPK Then
               ' lngGrupo = .Grupo
               NivelFind = .Nivel
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Function

   Private Function EsAnaFind(ByVal lngPlanEEFFId As Long) As Boolean
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      Try
         EsAnaFind = False

         With oPlanEEFF
            .PlanEEFFId = lngPlanEEFFId

            If .FindByPK Then
               EsAnaFind = ToBoolean(.EsAna)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Function

   'Private Function NumeroHijos(ByVal lngPlanEEFFId As Long) As Long
   '   Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

   '   Try
   '      NumeroHijos = 0

   '      With oPlanEEFF
   '         .RowCountFilter = clsPlanEEFF.RowCountFilters.All
   '         .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
   '         .EmpresaId = mlngEmpresaId
   '         .PlanEEFFPadreId = lngPlanEEFFId

   '         NumeroHijos = .RowCount
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oPlanEEFF.Dispose()

   '   End Try
   'End Function

   Private Function TieneMovimiento(ByVal lngPlanEEFFId As Long) As Boolean
      Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)

      TieneMovimiento = True
      Try
         With oCompPlanEEFF
            .RowCountFilter = clsCompPlanEEFF.RowCountFilters.All
            .WhereFilter = clsCompPlanEEFF.WhereFilters.PlanEEFFId
            .EmpresaId = mlngEmpresaId
            .PlanEEFFId = lngPlanEEFFId
            If ToLong(.RowCount) = 0 Then
               TieneMovimiento = False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompPlanEEFF.Dispose()
      End Try
   End Function

   Private Function NumeroHijos(ByVal lngPlanEEFFPadreId As Long, Optional ByVal lngPlanEEFFHijoId As Long = 0) As Long
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      Try
         NumeroHijos = 0

         With oPlanEEFF
            .RowCountFilter = clsPlanEEFF.RowCountFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
            .EmpresaId = mlngEmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId
            .PlanEEFFId = lngPlanEEFFHijoId
            NumeroHijos = ToLong(.RowCount)
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Function

   Private Function PadreTieneHijosGrupo(ByVal lngPlanEEFFPadreId As Long) As Boolean
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      PadreTieneHijosGrupo = False
      Try
         With oPlanEEFF
            .SelectFilter = clsPlanEEFF.SelectFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
            .EmpresaId = mlngEmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId

            If .Open And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               .Read()
               If Not .EsAna Then
                  PadreTieneHijosGrupo = True
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlanEEFF.Dispose()

      End Try
   End Function

   Private Sub RecordFindFast()
      Dim frm As New frmPlanSelectFind
      Try
         If trvMain.SelectedNode.IsSelected Then
            If trvMain.SelectedNode.ImageIndex = 1 Then
               If NumeroHijos(ToLong(trvMain.SelectedNode.Tag)) = 0 Or Not PadreTieneHijosGrupo(ToLong(trvMain.SelectedNode.Tag)) Then
                  With frm
                     .EmpresaId = mlngEmpresaId
                     .ShowDialog()

                     If .Changed Then
                        Call CargarPlanCuentas(.Lista, ToLong(trvMain.SelectedNode.Tag), frm.ID)
                        Call trvMainLoad()
                        Call FindNodeWithAna(trvMain.Nodes, frm.ID, False)
                        frm = Nothing
                     End If
                  End With
               Else
                  MessageBox.Show("Solo puede agregar Flujos de Efectivo No Análiticos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Seleccione una cuenta de Grupo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
         End If
      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
      'frm.Dispose()
   End Sub

   Private Sub RecordSelected()
      If trvMain.SelectedNode.IsSelected Then
         If NivelFind(trvMain.SelectedNode.Tag) > 0 Then
            mlngID = trvMain.SelectedNode.Tag
            mboolChanged = True
            Me.Close()
         Else
            MessageBox.Show("Imposible Seleccionar una Cuenta de ese Nivel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub grdSubMainLoad(ByVal lngPlanEEFFPadreId As Long, ByVal strTab As String)
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      Dim index As Integer
      Try
         With oPlanEEFF
            .SelectFilter = clsPlanEEFF.SelectFilters.Grid
            .WhereFilter = clsPlanEEFF.WhereFilters.Grid
            .OrderByFilter = clsPlanEEFF.OrderByFilters.Orden
            .EmpresaId = mlngEmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId
            .Nivel = -1
            index = 0
            If .Open() Then
               Do While index < .DataSet.Tables(.TableName).Rows.Count
                  moDataTable.Rows.Add(GetRow(.DataSet.Tables(.TableName).Rows(index), strTab))
                  strTab = strTab & "     "
                  Call grdSubMainLoad(.DataSet.Tables(.TableName).Rows(index)("PlanEEFFId"), strTab)
                  strTab = Mid(strTab, 1, Len(strTab) - 5)
                  index += 1
               Loop
            End If

         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanEEFF.Dispose()
      End Try
   End Sub

   Private Sub rptPlanEEFFLoad()
      Call moDataSetInit()
      Dim strTab As String = ""
      Call grdSubMainLoad(0, strTab)
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moPlanEEFF.TableName)

      moDataTable.Columns.Add("PlanEEFFId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EmpresaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoEEFFId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoCompDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanEEFFPadreId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanEEFFDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanEEFFCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("Nivel", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("Orden", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EsAna", Type.GetType("System.Byte"))
      moDataTable.Columns.Add("EstadoId", Type.GetType("System.Int32"))
      'moDataTable.Columns.Add("EstadoDes", Type.GetType("System.String"))
   End Sub

   Private Function GetRow(ByVal oDataRow As DataRow, ByVal strTab As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanEEFFId") = oDataRow("PlanEEFFId")
      oRow("TipoEEFFId") = oDataRow("TipoEEFFId")
      oRow("TipoCompDes") = oDataRow("TipoCompDes")
      oRow("PlanEEFFPadreId") = oDataRow("PlanEEFFPadreId")
      oRow("PlanEEFFDes") = strTab & oDataRow("PlanEEFFDes")
      oRow("PlanEEFFCta") = oDataRow("PlanEEFFCta")
      oRow("Nivel") = oDataRow("Nivel")
      oRow("Orden") = oDataRow("Orden")
      oRow("EsAna") = oDataRow("EsAna")
      oRow("EstadoId") = oDataRow("EstadoId")
      Return oRow
   End Function

   Private Sub PrintReport()
      Dim rpt As New rptPlanEEFF

      Call rptPlanEEFFLoad()

      rpt.DataSource = moDataTable.DataSet.Tables(moPlanEEFF.TableName)

      rpt.lblTitle.Text = "Plan de Cuentas de Flujo de Efectivo"
      rpt.Document.Name = "Plan de Cuentas de Flujo de Efectivo"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      If Not mboolFind Then
         cdmMain.Commands.Item("Check").Visible = Janus.Windows.UI.InheritableBoolean.False
      End If

      moPlanEEFF = New clsPlanEEFF(clsAppInfo.ConnectString)
   End Sub

   Private Sub trvMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trvMain.MouseDown
      If e.Button = MouseButtons.Right Then
         mnuConsultar.Enabled = True
         mnuAdicionar.Enabled = JanusToBooleam(cdmMain.Commands.Item("New").Enabled)
         mnuEditar.Enabled = JanusToBooleam(cdmMain.Commands.Item("Edit").Enabled)
         mnuEliminar.Enabled = JanusToBooleam(cdmMain.Commands.Item("Delete").Enabled)
      End If
   End Sub

   Private Sub mnuConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultar.Click
      Call DataShow()
   End Sub

   Private Sub mnuAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdicionar.Click
      Call FormNew()
   End Sub

   Private Sub mnuEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar.Click
      Call DataEdit()
   End Sub

   Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
      Call DataDelete()
   End Sub

   Private Sub frmPlanEEFF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            If cdmMain.Commands.Item("New").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               Call FormNew()
            End If

         ElseIf (e.KeyCode = Keys.End) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Edit").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               Call DataEdit()
            End If

         ElseIf (e.KeyCode = Keys.Delete) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Delete").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               Call DataDelete()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmPlanEEFF_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlanEEFF.Dispose()
      Call ClearMemory()
   End Sub

#Region "Metodos - Plan"
   Private Function TieneHijos(ByVal lngPlanEEFFPadreId As Long) As Boolean
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)

      TieneHijos = False
      Try
         With oPlanEEFF
            .SelectFilter = oPlanEEFF.SelectFilters.All
            .WhereFilter = oPlanEEFF.WhereFilters.PlanEEFFPadreId
            .EmpresaId = mlngEmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId
            If .Find Then
               TieneHijos = True
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanEEFF.Dispose()
      End Try
   End Function

   'Private Sub SetNodeImage(ByVal oNode As TreeNode, ByVal bytEsAna As Byte, ByVal bytTieneAnaAdd As Byte)
   '   If bytEsAna = 0 Then
   '      oNode.ImageIndex = 1
   '      oNode.SelectedImageIndex = 1
   '   ElseIf bytTieneAnaAdd = 0 Then
   '      oNode.ImageIndex = 3
   '      oNode.SelectedImageIndex = 3
   '   Else
   '      oNode.ImageIndex = 2
   '      oNode.SelectedImageIndex = 2
   '   End If
   'End Sub

   Private Sub SetNodeImage(ByVal oNode As TreeNode, ByVal bytEsAna As Byte)
      If bytEsAna = 0 Then
         oNode.ImageIndex = 1
         oNode.SelectedImageIndex = 1
      Else
         oNode.ImageIndex = 2
         oNode.SelectedImageIndex = 2
      End If
   End Sub

   Private Sub PlanEEFFOrdenNivel(ByVal lngPlanEEFFPadreId As Long, ByRef strPlanEEFFCta As String, ByRef lngNivel As Long, ByRef lngOrden As Long)
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      Dim intRowMax As Integer
      Try
         With oPlanEEFF
            .RowMaxFilter = clsPlanEEFF.RowMaxFilters.Orden
            .WhereFilter = clsPlanEEFF.WhereFilters.PlanEEFFPadreId
            .EmpresaId = mlngEmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId
            intRowMax = .RowMax

            .SelectFilter = clsPlanEEFF.SelectFilters.All
            .WhereFilter = clsPlanEEFF.WhereFilters.Orden
            .EmpresaId = mlngEmpresaId
            .PlanEEFFPadreId = lngPlanEEFFPadreId
            .Orden = intRowMax

            If .Find Then
               lngNivel = .Nivel
               lngOrden = .Orden + 1
               strPlanEEFFCta = ToNextCod(.PlanEEFFCta, .PlanEEFFCta.Length) 'ToLong(.PlanEEFFCta) + 1
            Else
               .PlanEEFFId = lngPlanEEFFPadreId
               If .FindByPK Then
                  lngNivel = .Nivel + 1
                  lngOrden = "1"
                  strPlanEEFFCta = .PlanEEFFCta & ToNextCod("0", If(lngNivel > 1, 2, 1))
               End If
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanEEFF.Dispose()
      End Try
   End Sub

   Private Function FindNodeWithAna(ByVal oNodos As TreeNodeCollection, ByVal lngPlanId As Long, ByVal boolTipo As Boolean) As Boolean
      FindNodeWithAna = False
      Try
         For Each oNodo In oNodos
            If oNodo.Tag = lngPlanId And oNodo.ImageIndex = 4 And boolTipo Then
               oNodo.Expand()
               trvMain.Select()
               trvMain.SelectedNode = oNodo
               Return True
            ElseIf oNodo.Tag = lngPlanId And oNodo.ImageIndex <> 4 And Not boolTipo Then
               oNodo.Expand()
               trvMain.Select()
               trvMain.SelectedNode = oNodo
               Return True
            Else
               FindNodeWithAna = FindNodeWithAna(oNodo.Nodes, lngPlanId, boolTipo)
            End If
         Next

      Catch exp As Exception
         Throw exp
         Return False
      End Try
   End Function
#End Region

#Region "PlanCuenta"

   Public Function CargarPlanCuentas(ByVal oLista As Queue, ByVal lngPlanEEFFId As Long, ByRef lngId As Long) As Boolean
      CargarPlanCuentas = True
      Dim oPlanEEFFPadre As New clsPlanEEFF(clsAppInfo.ConnectString)
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      Dim strIngreso As String
      Dim strEgreso As String
      Try
         With oPlanEEFFPadre
            .PlanEEFFId = lngPlanEEFFId
            Call .FindByPK()
            Call TipoEEFFDesFind(strIngreso, strEgreso)
            For Each num As clsListItem In oLista
               oPlanEEFF.PlanEEFFId = 0
               oPlanEEFF.EmpresaId = mlngEmpresaId
               oPlanEEFF.TipoEEFFId = oPlanEEFFPadre.TipoEEFFId
               oPlanEEFF.PlanEEFFPadreId = oPlanEEFFPadre.PlanEEFFId
               oPlanEEFF.PlanEEFFDes = ToStr(num.Value)
               Call PlanEEFFOrdenNivel(oPlanEEFFPadre.PlanEEFFId, oPlanEEFF.PlanEEFFCta, oPlanEEFF.Nivel, oPlanEEFF.Orden)
               oPlanEEFF.EsAna = True
               oPlanEEFF.EstadoId = clsEstado.ACTIVO

               Call oPlanEEFF.CloneVM(oPlanEEFF.VMNew, Me.Name, Me.Text)
               Call oPlanEEFF.Insert()

               lngId = oPlanEEFF.PlanEEFFId
            Next
         End With
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function TipoEEFFDesFind(ByRef strIngreso As String, ByRef strEgreso As String) As String
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)

      Try
         With oTipoComp
            .SelectFilter = clsTipoComp.SelectFilters.All
            .OrderByFilter = clsTipoComp.OrderByFilters.TipoCompId

            If .Find Then
               strIngreso = (From row In .DataSet.Tables(.TableName) Where row.Field(Of Integer)("TipoCompId") = 1 Select row.Field(Of String)("TipoCompDes")).FirstOrDefault
               strEgreso = (From row In .DataSet.Tables(.TableName) Where row.Field(Of Integer)("TipoCompId") = 2 Select row.Field(Of String)("TipoCompDes")).FirstOrDefault
            End If
         End With
      Catch ex As Exception
         MessageBox.Show(Me.Text, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try

   End Function
#End Region

End Class
