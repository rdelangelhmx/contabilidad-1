Public Class frmPlan
   Inherits System.Windows.Forms.Form

   Private moPlan As clsPlan
   Private mlngEmpresaId As Long

   Private moDataSet As DataSet
   Private moDataTable As DataTable

   Private mboolFind As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents chkIncluirPlanAdd As Janus.Windows.EditControls.UICheckBox
   Private mlngID As Long

#Region " Set and Get "
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
#End Region

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
   Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Ana1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Anal As Janus.Windows.UI.CommandBars.UICommand
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlan))
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
      Me.Ana1 = New Janus.Windows.UI.CommandBars.UICommand("Ana")
      Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
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
      Me.Anal = New Janus.Windows.UI.CommandBars.UICommand("Ana")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.chkIncluirPlanAdd = New Janus.Windows.EditControls.UICheckBox
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
      Me.ilsTree.Images.SetKeyName(3, "")
      Me.ilsTree.Images.SetKeyName(4, "AA.ico")
      Me.ilsTree.Images.SetKeyName(5, "1465520885_chart.png")
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.UiGroupBox1)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(745, 414)
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
      Me.UiGroupBox1.Size = New System.Drawing.Size(729, 406)
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
      Me.trvMain.Size = New System.Drawing.Size(713, 386)
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
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New2, Me.Edit, Me.Delete, Me.Find1, Me.Print, Me.Exit2, Me.Check, Me.Refrescar, Me.FindFast, Me.Anal})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New1, Me.Separator1, Me.Edit1, Me.Separator2, Me.Delete1, Me.Separator3, Me.Check1, Me.Separator7, Me.Refrescar1, Me.Separator6, Me.ViewAll1, Me.Separator8, Me.FindFast1, Me.Separator4, Me.Print1, Me.Separator5, Me.Ana1, Me.Separator9, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(745, 28)
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
      'Ana1
      '
      Me.Ana1.Key = "Ana"
      Me.Ana1.Name = "Ana1"
      '
      'Separator9
      '
      Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator9.Key = "Separator"
      Me.Separator9.Name = "Separator9"
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
      Me.FindFast.Text = "Busqueda Rápida"
      '
      'Anal
      '
      Me.Anal.CommandType = Janus.Windows.UI.CommandBars.CommandType.ToggleButton
      Me.Anal.IsEditableControl = Janus.Windows.UI.InheritableBoolean.[True]
      Me.Anal.Key = "Ana"
      Me.Anal.Name = "Anal"
      Me.Anal.Text = "Analiticos"
      Me.Anal.Visible = Janus.Windows.UI.InheritableBoolean.[False]
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
      Me.TopRebar1.Controls.Add(Me.chkIncluirPlanAdd)
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(745, 28)
      '
      'chkIncluirPlanAdd
      '
      Me.chkIncluirPlanAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkIncluirPlanAdd.BackColor = System.Drawing.Color.Transparent
      Me.chkIncluirPlanAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkIncluirPlanAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkIncluirPlanAdd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkIncluirPlanAdd.Location = New System.Drawing.Point(568, 4)
      Me.chkIncluirPlanAdd.Name = "chkIncluirPlanAdd"
      Me.chkIncluirPlanAdd.Size = New System.Drawing.Size(168, 20)
      Me.chkIncluirPlanAdd.TabIndex = 9
      Me.chkIncluirPlanAdd.Text = "Incluir Analítico Adicional"
      Me.chkIncluirPlanAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'frmPlan
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(745, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmPlan"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Plan de Cuentas"
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

         Case "Find"
            Call RecordFind()

         Case "FindFast"
            Call RecordFindFast()

         Case "Check"
            Call RecordSelected()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()

            'Case "Ana"
            '   Dim lngPlanId As Long
            '   If trvMain.SelectedNode.ImageIndex = 4 Then
            '      lngPlanId = trvMain.SelectedNode.Parent.Tag
            '   Else
            '      lngPlanId = trvMain.SelectedNode.Tag
            '   End If

            '   Call trvMainLoad()
            '   Call FindNodeWithAna(trvMain.Nodes, lngPlanId, False)

      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmPlan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call trvMainLoad()
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      If Not mboolFind Then
         cdmMain.Commands.Item("Check").Visible = Janus.Windows.UI.InheritableBoolean.False
      End If

      moPlan = New clsPlan(clsAppInfo.ConnectString)
   End Sub

   Private Sub RecordFind()
      Dim frm As New frmPlanFill

      With frm
         .FindAll = True
         .EmpresaId = mlngEmpresaId
         '.Analitico = cdmMain.Commands.Item("Ana").IsChecked
         .Analitico = chkIncluirPlanAdd.Checked
         .ShowDialog()

         If frm.Selected Then
            Call FindNodeWithAna(trvMain.Nodes, frm.ID, frm.Sw)
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub RecordFindFast()
      Dim frm As New frmPlanFind

      With frm
         .EmpresaId = mlngEmpresaId
         .ShowDialog()

         If .Changed Then
            Call FindNodeWithAna(trvMain.Nodes, frm.ID, False)
         End If

         frm.Dispose()
      End With
   End Sub

   Private Sub frmPlan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

   Private Sub frmPlan_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moPlan.Dispose()
      Call ClearMemory()
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

#Region " PLAN "
#Region " Metodos-Plan "
   Private Function TieneHijos(ByVal lngPlanPadreId As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      TieneHijos = False
      Try
         With oPlan
            .SelectFilter = oPlan.SelectFilters.All
            .WhereFilter = oPlan.WhereFilters.PlanPadreId

            .EmpresaId = mlngEmpresaId
            .PlanPadreId = lngPlanPadreId
            If .Find Then
               TieneHijos = True
            End If

         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Sub SetNodeImage(ByVal oNode As TreeNode, ByVal bytEsAna As Byte, ByVal bytTieneAnaAdd As Byte)
      If bytEsAna = 0 Then
         oNode.ImageIndex = 1
         oNode.SelectedImageIndex = 1
      ElseIf bytTieneAnaAdd = 0 Then
         oNode.ImageIndex = 3
         oNode.SelectedImageIndex = 3
      Else
         oNode.ImageIndex = 2
         oNode.SelectedImageIndex = 2
      End If
   End Sub

   Private Function NivelFind(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      NivelFind = 0
      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               NivelFind = ToLong(.Nivel)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Function EsAnaFind(ByVal lngPlanId As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      EsAnaFind = False
      Try
         With oPlan
            .PlanId = lngPlanId

            If .FindByPK Then
               EsAnaFind = ToBoolean(.EsAna)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Function NumeroHijos(ByVal lngPlanId As Long) As Long
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      NumeroHijos = 0
      Try
         With oPlan
            .RowCountFilter = clsPlan.RowCountFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanPadreId

            .EmpresaId = mlngEmpresaId
            .PlanPadreId = lngPlanId
            NumeroHijos = ToLong(.RowCount)
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Function

   Private Function TieneMovimiento(ByVal lngPlanId As Long) As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      TieneMovimiento = True
      Try
         With oCompDet
            .RowCountFilter = clsCompDet.RowCountFilters.All
            .WhereFilter = clsCompDet.WhereFilters.PlanId

            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanId
            If ToLong(.RowCount) = 0 Then
               TieneMovimiento = False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompDet = Nothing
      End Try
   End Function

   Private Function TienePlanAdd(ByVal lngPlanId As Long) As Boolean
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)

      TienePlanAdd = True
      Try
         With oPlanAdd
            .RowCountFilter = clsPlanAdd.RowCountFilters.All
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId

            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanId
            If ToLong(.RowCount) = 0 Then
               TienePlanAdd = False
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanAdd.Dispose()
      End Try
   End Function

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

#Region " Grid-Plan "
   Private Sub trvSubMainAnaLoad(ByVal oNodoPadre As TreeNode, ByVal lngPlanPadreId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Dim oNodeHijo As TreeNode
      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.All
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddId

            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanPadreId
            If .Open Then
               Do While .Read()
                  oNodeHijo = New TreeNode("(" + .PlanAddCta + ")  " + .PlanAddDes)
                  oNodeHijo.Tag = .PlanAddId

                  oNodeHijo.ImageIndex = 4
                  oNodeHijo.SelectedImageIndex = 4

                  oNodoPadre.Nodes.Add(oNodeHijo)
                  .MoveNext()
               Loop
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanAdd.Dispose()
      End Try
   End Sub

   Private Sub trvSubMainLoad(ByVal oNodoPadre As TreeNode, ByVal lngPlanPadreId As Long)
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim oNodeHijo As TreeNode
      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.PlanPadreId
            .OrderByFilter = clsPlan.OrderByFilters.Orden

            .EmpresaId = mlngEmpresaId
            .PlanPadreId = lngPlanPadreId
            If .Open Then
               Do While .Read()
                  oNodeHijo = New TreeNode("(" + .PlanCta + ")  " + .PlanDes)
                  oNodeHijo.Tag = .PlanId
                  If TieneHijos(.PlanId) Then
                     Call SetNodeImage(oNodeHijo, .EsAna, .TieneAnaAdd)
                     Call trvSubMainLoad(oNodeHijo, .PlanId)
                  Else
                     Call SetNodeImage(oNodeHijo, .EsAna, .TieneAnaAdd)

                     'If .TieneAnaAdd And cdmMain.Commands.Item("Ana").IsChecked Then
                     If .TieneAnaAdd And chkIncluirPlanAdd.Checked Then
                        Call trvSubMainAnaLoad(oNodeHijo, .PlanId)
                     End If
                  End If

                  oNodoPadre.Nodes.Add(oNodeHijo)
                  .MoveNext()
               Loop
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Sub

   Private Sub trvMainLoad()
      Dim oNodePadre As TreeNode
      Try
         trvMain.Nodes.Clear()

         oNodePadre = New TreeNode("Plan de Cuentas")
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

   Private Sub FormNew()
      If trvMain.SelectedNode.ImageIndex <> 4 Then
         If NivelFind(trvMain.SelectedNode.Tag) > 0 Then
            If Not EsAnaFind(trvMain.SelectedNode.Tag) Then
               Dim frm As New frmPlanEdit
               Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
               Try
                  With frm
                     .NewRecord = True
                     .Editing = False
                     oPlan.EmpresaId = mlngEmpresaId
                     oPlan.PlanPadreId = trvMain.SelectedNode.Tag
                     .DataObject = oPlan
                     .ShowDialog()

                     If .Changed Then
                        Call trvMainLoad()
                        Call FindNodeWithAna(trvMain.Nodes, frm.ID, False)
                     End If
                  End With

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Finally
                  oPlan.Dispose()
                  frm.Dispose()
               End Try
            Else
               MessageBox.Show("Seleccione una Cuenta de Grupo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Imposible Crear una Cuenta a Ese Nivel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Seleccione una Cuenta de Grupo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub DataEditPlan()
      If NivelFind(trvMain.SelectedNode.Tag) > 1 Then
         Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
         Try
            With oPlan
               .PlanId = trvMain.SelectedNode.Tag
               If .FindByPK Then
                  Dim frm As New frmPlanEdit
                  frm.NewRecord = False
                  frm.Editing = True
                  frm.DataObject = oPlan
                  frm.ShowDialog()
                  If frm.Changed Then
                     Call trvMainLoad()
                     Call FindNodeWithAna(trvMain.Nodes, frm.ID, False)
                  End If

                  frm.Dispose()
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Finally
            oPlan.Dispose()
         End Try
      Else
         MessageBox.Show("Imposible Editar una Cuenta de ese Nivel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub DataEditAna()
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Try
         With oPlanAdd
            .PlanAddId = trvMain.SelectedNode.Tag

            If .FindByPK Then
               Dim frm As New frmPlanAddEdit

               frm.NewRecord = False
               frm.Editing = True
               frm.DataObject = oPlanAdd
               frm.ShowDialog()

               If frm.Changed Then
                  Call trvMainLoad()
                  Call FindNodeWithAna(trvMain.Nodes, frm.ID, True)
               End If

               frm.Dispose()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanAdd.Dispose()
      End Try
   End Sub

   Private Sub DataEdit()
      If trvMain.SelectedNode.IsSelected Then
         If trvMain.SelectedNode.ImageIndex <> 4 Then
            Call DataEditPlan()
         Else
            Call DataEditAna()
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub DataShowAna()
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Try
         With oPlanAdd
            .PlanAddId = trvMain.SelectedNode.Tag

            If .FindByPK Then
               Dim frm As New frmPlanAddEdit

               frm.NewRecord = False
               frm.Editing = False
               frm.DataObject = oPlanAdd

               frm.ShowDialog()
               frm.Dispose()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanAdd.Dispose()
      End Try
   End Sub

   Private Sub DataShowPlan()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Try
         With oPlan
            .PlanId = trvMain.SelectedNode.Tag

            If .FindByPK Then
               Dim frm As New frmPlanEdit

               frm.NewRecord = False
               frm.Editing = False
               frm.DataObject = oPlan

               frm.ShowDialog()
               frm.Dispose()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlan.Dispose()
      End Try
   End Sub

   Private Sub DataShow()
      If trvMain.SelectedNode.IsSelected Then
         If ToLong(trvMain.SelectedNode.Tag) > 0 Then
            If trvMain.SelectedNode.ImageIndex <> 4 Then
               Call DataShowPlan()
            Else
               Call DataShowAna()
            End If
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub CloneVM(ByRef oVM As clsPlanVM)
      If clsAppInfo.RegistrarBitacora Then
         oVM = New clsPlanVM

         With oVM
            Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
            oPlan.PlanId = trvMain.SelectedNode.Tag
            oPlan.FindByPK()

            .PlanId = oPlan.PlanId
            .PlanDes = oPlan.PlanDes
            .PlanCta = oPlan.PlanCta

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Sub DataDelete()
      If trvMain.SelectedNode.IsSelected And trvMain.SelectedNode.ImageIndex <> 4 Then
         If NivelFind(trvMain.SelectedNode.Tag) > 1 Then
            If NumeroHijos(trvMain.SelectedNode.Tag) = 0 Then
               If Not TieneMovimiento(trvMain.SelectedNode.Tag) Then
                  If Not TienePlanAdd(trvMain.SelectedNode.Tag) Then
                     If MessageBox.Show("¿Realmente Quiere Eliminar el Registro?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
                        Dim lngID As Long
                        Try
                           lngID = trvMain.SelectedNode.Parent.Tag()

                           With oPlan
                              .WhereFilter = clsPlan.WhereFilters.PrimaryKey
                              .PlanId = trvMain.SelectedNode.Tag

                              'If .IsDeleted Then

                              Call CloneVM(.VMNew)
                              If .Delete Then

                                 .CloseConection()
                                 Call trvMainLoad()
                                 Call FindNodeWithAna(trvMain.Nodes, lngID, False)
                              End If
                              'Else
                              'MessageBox.Show("No se Puede Eliminar el Registro, Debido a que Tiene Movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                              'End If
                           End With

                        Catch exp As Exception
                           MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Finally
                           oPlan.Dispose()
                        End Try
                     End If
                  Else
                     MessageBox.Show("Imposible Eliminar la Cuenta Debido a que Tiene Analíticos Adicionales", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If
               Else
                  MessageBox.Show("Imposible Eliminar la Cuenta Debido a que ya Tiene Movimiento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            Else
               MessageBox.Show("Imposible Eliminar la Cuenta Debido a que Tiene Cuentas que Dependen de la Misma", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Imposible Eliminar una Cuenta de ese Nivel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar una Cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub mnuAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdicionar.Click
      Call FormNew()
   End Sub

   Private Sub mnuEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar.Click
      Call DataEdit()
   End Sub

   Private Sub mnuConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsultar.Click
      Call DataShow()
   End Sub

   Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
      Call DataDelete()
   End Sub

   Private Sub trvMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles trvMain.MouseDown
      If e.Button = MouseButtons.Right Then
         mnuConsultar.Enabled = True
         mnuEditar.Enabled = JanusToBooleam(cdmMain.Commands.Item("Edit").Enabled)
         If trvMain.SelectedNode.ImageIndex <> 4 Then
            mnuAdicionar.Enabled = JanusToBooleam(cdmMain.Commands.Item("New").Enabled)
            mnuEliminar.Enabled = JanusToBooleam(cdmMain.Commands.Item("Delete").Enabled)
         Else
            mnuAdicionar.Enabled = JanusToBooleam(False)
            mnuEliminar.Enabled = JanusToBooleam(False)
         End If
      End If
   End Sub
#End Region
#End Region

#Region " REPORTE "
   Private Sub PrintReport()
      Dim rpt As New rptPlan

      Call rptPlanLoad()

      rpt.DataSource = moDataTable.DataSet.Tables(moPlan.TableName)

      rpt.lblTitle.Text = "Plan de Cuentas"
      rpt.Document.Name = "Plan de Cuentas"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub moDataSetInit()
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add(moPlan.TableName)

      moDataTable.Columns.Add("PlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EmpresaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanCta", Type.GetType("System.String"))
      moDataTable.Columns.Add("PlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Nivel", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MonedaId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("MonedaDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("EsAna", Type.GetType("System.Byte"))
      moDataTable.Columns.Add("SucCCOId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("SucCCODes", Type.GetType("System.String"))
      moDataTable.Columns.Add("TieneAnaAdd", Type.GetType("System.Byte"))
      moDataTable.Columns.Add("TipoPlanId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("TipoPlanDes", Type.GetType("System.String"))
      moDataTable.Columns.Add("Orden", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("PlanPadreId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EstadoId", Type.GetType("System.Int32"))
      moDataTable.Columns.Add("EstadoDes", Type.GetType("System.String"))
   End Sub

   Private Sub rptPlanLoad()
      Call moDataSetInit()
      Dim strTab As String = ""
      Call grdSubMainLoad(0, strTab)
   End Sub

   Private Sub grdSubMainAnaLoad(ByVal lngPlanId As Long, ByVal strTab As String)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Try
         With oPlanAdd
            .SelectFilter = clsPlanAdd.SelectFilters.All
            .WhereFilter = clsPlanAdd.WhereFilters.PlanId
            .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddId

            .EmpresaId = mlngEmpresaId
            .PlanId = lngPlanId
            If .Open Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  moDataTable.Rows.Add(GetRowAna(oRow, strTab))
               Next
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oPlanAdd.Dispose()
      End Try
   End Sub

   Private Sub grdSubMainLoad(ByVal lngPlanPadreId As Long, ByVal strTab As String)
      Dim oEquipo As New clsPlan(clsAppInfo.ConnectString)
      Dim index As Integer
      Try
         With oEquipo
            .SelectFilter = clsPlan.SelectFilters.Grid
            .WhereFilter = clsPlan.WhereFilters.Grid
            .OrderByFilter = clsPlan.OrderByFilters.Orden

            .EmpresaId = mlngEmpresaId
            .PlanPadreId = lngPlanPadreId
            .Nivel = -1
            index = 0
            If .Open() Then
               Do While index < .DataSet.Tables(.TableName).Rows.Count
                  moDataTable.Rows.Add(GetRow(.DataSet.Tables(.TableName).Rows(index), strTab))
                  strTab = strTab & "     "
                  If .DataSet.Tables(.TableName).Rows(index)("TieneAnaAdd") _
                  And chkIncluirPlanAdd.Checked Then
                     'And cdmMain.Commands.Item("Ana").IsChecked Then

                     Call grdSubMainAnaLoad(.DataSet.Tables(.TableName).Rows(index)("PlanId"), strTab)
                  End If
                  Call grdSubMainLoad(.DataSet.Tables(.TableName).Rows(index)("PlanId"), strTab)
                  strTab = Mid(strTab, 1, Len(strTab) - 5)
                  index += 1
               Loop
            End If

         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oEquipo.Dispose()
      End Try
   End Sub

   Private Function GetRowAna(ByVal oDataRow As DataRow, ByVal strTab As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanId") = oDataRow("PlanId")
      oRow("PlanCta") = oDataRow("PlanAddCta")
      oRow("PlanDes") = strTab & oDataRow("PlanAddDes")
      oRow("EsAna") = False
      oRow("TieneAnaAdd") = False ' oDataRow("TieneAnaAdd")
      Return oRow
   End Function

   Private Function GetRow(ByVal oDataRow As DataRow, ByVal strTab As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("PlanId") = oDataRow("PlanId")
      oRow("PlanCta") = oDataRow("PlanCta")
      oRow("PlanDes") = strTab & oDataRow("PlanDes")
      oRow("Nivel") = oDataRow("Nivel")
      oRow("MonedaId") = oDataRow("MonedaId")
      oRow("MonedaDes") = oDataRow("MonedaDes")
      oRow("EsAna") = oDataRow("EsAna")
      oRow("SucCCOId") = oDataRow("SucCCOId")
      oRow("SucCCODes") = oDataRow("SucCCODes")
      oRow("TieneAnaAdd") = oDataRow("TieneAnaAdd")
      oRow("TipoPlanId") = oDataRow("TipoPlanId")
      oRow("TipoPlanDes") = oDataRow("TipoPlanDes")
      oRow("Orden") = oDataRow("Orden")
      oRow("PlanPadreId") = oDataRow("PlanPadreId")
      oRow("EstadoId") = oDataRow("EstadoId")
      oRow("EstadoDes") = oDataRow("EstadoDes")
      Return oRow
   End Function
#End Region

   Private Sub chkIncluirPlanAdd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIncluirPlanAdd.CheckedChanged
      If chkIncluirPlanAdd.ContainsFocus Then
         Dim lngPlanId As Long
         If trvMain.SelectedNode.ImageIndex = 4 Then
            lngPlanId = trvMain.SelectedNode.Parent.Tag
         Else
            lngPlanId = trvMain.SelectedNode.Tag
         End If

         Call trvMainLoad()
         Call FindNodeWithAna(trvMain.Nodes, lngPlanId, False)
      End If
   End Sub
End Class
