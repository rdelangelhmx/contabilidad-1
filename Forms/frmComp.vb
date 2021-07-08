Public Class frmComp
   Inherits System.Windows.Forms.Form

   Private moComp As clsComp
   Friend WithEvents Anular1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Revertir As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Reordenar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Reordenar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
   Private mlngEmpresaId As Long

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
   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents PrintMain1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents PrintMain As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents PrintSelected1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents lblMaxReg As System.Windows.Forms.Label
   Friend WithEvents txtMaxReg As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents New1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents PrintSelected As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents Refrescar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Refrescar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuMain As System.Windows.Forms.ContextMenu
   Friend WithEvents mnuShow As System.Windows.Forms.MenuItem
   Friend WithEvents mnuNew As System.Windows.Forms.MenuItem
   Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
   Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
   Friend WithEvents Duplicate As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Duplicate1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComp))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.mnuMain = New System.Windows.Forms.ContextMenu
      Me.mnuShow = New System.Windows.Forms.MenuItem
      Me.mnuNew = New System.Windows.Forms.MenuItem
      Me.mnuEdit = New System.Windows.Forms.MenuItem
      Me.mnuDelete = New System.Windows.Forms.MenuItem
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
      Me.Duplicate1 = New Janus.Windows.UI.CommandBars.UICommand("Duplicate")
      Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Anular1 = New Janus.Windows.UI.CommandBars.UICommand("Revertir")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Reordenar1 = New Janus.Windows.UI.CommandBars.UICommand("Reordenar")
      Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Refrescar1 = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.PrintMain1 = New Janus.Windows.UI.CommandBars.UICommand("PrintMain")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.PrintSelected = New Janus.Windows.UI.CommandBars.UICommand("PrintSelected")
      Me.Refrescar = New Janus.Windows.UI.CommandBars.UICommand("Refrescar")
      Me.Duplicate = New Janus.Windows.UI.CommandBars.UICommand("Duplicate")
      Me.PrintMain = New Janus.Windows.UI.CommandBars.UICommand("PrintMain")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.PrintSelected1 = New Janus.Windows.UI.CommandBars.UICommand("PrintSelected")
      Me.Revertir = New Janus.Windows.UI.CommandBars.UICommand("Revertir")
      Me.Reordenar = New Janus.Windows.UI.CommandBars.UICommand("Reordenar")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.lblMaxReg = New System.Windows.Forms.Label
      Me.txtMaxReg = New Janus.Windows.GridEX.EditControls.NumericEditBox
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
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 5
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
      'mnuMain
      '
      Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuShow, Me.mnuNew, Me.mnuEdit, Me.mnuDelete})
      '
      'mnuShow
      '
      Me.mnuShow.Index = 0
      Me.mnuShow.Text = "Consultar"
      '
      'mnuNew
      '
      Me.mnuNew.Index = 1
      Me.mnuNew.Text = "Nuevo"
      '
      'mnuEdit
      '
      Me.mnuEdit.Index = 2
      Me.mnuEdit.Text = "Editar"
      '
      'mnuDelete
      '
      Me.mnuDelete.Index = 3
      Me.mnuDelete.Text = "Eliminar"
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
      Me.ilsMain.Images.SetKeyName(9, "undoarrow_undo_1534.ico")
      Me.ilsMain.Images.SetKeyName(10, "icons8-clasificación-numérica-50.png")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New2, Me.Edit, Me.Delete, Me.ViewAll, Me.Print, Me.Exit2, Me.PrintSelected, Me.Refrescar, Me.Duplicate, Me.PrintMain, Me.Revertir, Me.Reordenar})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("14565a15-ea74-408e-b698-fb1d6c9d5b6b")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.New1, Me.Separator1, Me.Edit1, Me.Separator2, Me.Delete1, Me.Separator3, Me.Duplicate1, Me.Separator8, Me.Anular1, Me.Separator6, Me.Reordenar1, Me.Separator9, Me.Refrescar1, Me.Separator7, Me.ViewAll1, Me.Separator4, Me.PrintMain1, Me.Separator5, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(738, 28)
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
      'Duplicate1
      '
      Me.Duplicate1.Key = "Duplicate"
      Me.Duplicate1.Name = "Duplicate1"
      '
      'Separator8
      '
      Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator8.Key = "Separator"
      Me.Separator8.Name = "Separator8"
      '
      'Anular1
      '
      Me.Anular1.Key = "Revertir"
      Me.Anular1.Name = "Anular1"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'Reordenar1
      '
      Me.Reordenar1.Key = "Reordenar"
      Me.Reordenar1.Name = "Reordenar1"
      '
      'Separator9
      '
      Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator9.Key = "Separator"
      Me.Separator9.Name = "Separator9"
      '
      'Refrescar1
      '
      Me.Refrescar1.Key = "Refrescar"
      Me.Refrescar1.Name = "Refrescar1"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
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
      'PrintMain1
      '
      Me.PrintMain1.Key = "PrintMain"
      Me.PrintMain1.Name = "PrintMain1"
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
      Me.Print.Text = "Listado"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 6
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'PrintSelected
      '
      Me.PrintSelected.ImageIndex = 5
      Me.PrintSelected.Key = "PrintSelected"
      Me.PrintSelected.Name = "PrintSelected"
      Me.PrintSelected.Text = "Comprobantes Seleccionados"
      '
      'Refrescar
      '
      Me.Refrescar.ImageIndex = 7
      Me.Refrescar.Key = "Refrescar"
      Me.Refrescar.Name = "Refrescar"
      Me.Refrescar.Text = "Actualizar"
      '
      'Duplicate
      '
      Me.Duplicate.ImageIndex = 8
      Me.Duplicate.Key = "Duplicate"
      Me.Duplicate.Name = "Duplicate"
      Me.Duplicate.Text = "Duplicar"
      '
      'PrintMain
      '
      Me.PrintMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Print1, Me.PrintSelected1})
      Me.PrintMain.ImageIndex = 4
      Me.PrintMain.Key = "PrintMain"
      Me.PrintMain.Name = "PrintMain"
      Me.PrintMain.Text = "Imprimir"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'PrintSelected1
      '
      Me.PrintSelected1.Key = "PrintSelected"
      Me.PrintSelected1.Name = "PrintSelected1"
      '
      'Revertir
      '
      Me.Revertir.ImageIndex = 9
      Me.Revertir.Key = "Revertir"
      Me.Revertir.Name = "Revertir"
      Me.Revertir.Text = "Revertir"
      '
      'Reordenar
      '
      Me.Reordenar.ImageIndex = 10
      Me.Reordenar.Key = "Reordenar"
      Me.Reordenar.Name = "Reordenar"
      Me.Reordenar.Text = "Reordenar"
      Me.Reordenar.Visible = Janus.Windows.UI.InheritableBoolean.[False]
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
      Me.TopRebar1.Controls.Add(Me.lblMaxReg)
      Me.TopRebar1.Controls.Add(Me.txtMaxReg)
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(752, 28)
      '
      'lblMaxReg
      '
      Me.lblMaxReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblMaxReg.BackColor = System.Drawing.Color.Transparent
      Me.lblMaxReg.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMaxReg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblMaxReg.Location = New System.Drawing.Point(632, 8)
      Me.lblMaxReg.Name = "lblMaxReg"
      Me.lblMaxReg.Size = New System.Drawing.Size(60, 14)
      Me.lblMaxReg.TabIndex = 211
      Me.lblMaxReg.Text = "MAX REG"
      Me.lblMaxReg.TextAlign = System.Drawing.ContentAlignment.TopRight
      '
      'txtMaxReg
      '
      Me.txtMaxReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMaxReg.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMaxReg.Location = New System.Drawing.Point(692, 4)
      Me.txtMaxReg.Name = "txtMaxReg"
      Me.txtMaxReg.Size = New System.Drawing.Size(48, 20)
      Me.txtMaxReg.TabIndex = 10
      Me.txtMaxReg.TabStop = False
      Me.txtMaxReg.Text = "0"
      Me.txtMaxReg.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtMaxReg.Value = 0
      Me.txtMaxReg.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtMaxReg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'frmComp
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmComp"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Registro de Comprobantes"
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
      Me.TopRebar1.PerformLayout()
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

         Case "Duplicate"
            Call CompDuplicate()

         Case "Revertir"
            Call CompRevertir()

         Case "ReordenarDisabled"
            Call frmOrdenarNumeroLoad()

         Case "ViewAll"
            Call DataViewAll()

         Case "Refrescar"
            Call grdMainLoad()

         Case "Print"
            Call PrintReport()
            
         Case "PrintSelected"
            Call PrintReportAll()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmComp_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmComp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call grdMainLoad()
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moComp = New clsComp(clsAppInfo.ConnectString)

      txtMaxReg.Text = ToStr(CompParaRowsMaxFind(clsAppInfo.EmpresaId, clsAppInfo.GestionId, 1))
   End Sub

   Private Sub frmComp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

   Private Sub frmComp_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moComp.Dispose()
      Call ClearMemory()
   End Sub

#Region " Print "
   Private Function CompParaFirma(ByVal lngTipoCompId As Long, ByVal lngGestionId As Long, ByRef lngTipoHojaId As Long) As String
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      CompParaFirma = String.Empty
      Try
         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId

            .EmpresaId = moComp.EmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId
            If .Find Then
               CompParaFirma = .Firma
               lngTipoHojaId = .TipoHojaId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompPara.Dispose()
      End Try
   End Function

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
      Dim rpt As New rptComp

      rpt.DataSource = GetDataView(moComp.DataSet.Tables(moComp.TableName))

      rpt.lblTitle.Text = "Listado de Comprobantes"
      rpt.Document.Name = "Listado de Comprobantes"
      rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      rpt.Run(True)
      Dim frm As New frmReportPreview(rpt.Document, Me)
      frm.Show()
   End Sub

   Private Sub PrintReportAll()
      Dim rpt As rptCompEdit
      Dim rptAll As New rptCompEdit
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Dim lngTipoHojaId As Long

      Try
         If grdMain.SelectedItems.Count > 0 Then
            For Each oRow In grdMain.SelectedItems
               If ToLong(oRow.GetRow.Cells("CompId").Value) <> 0 Then
                  oComp.SelectFilter = clsComp.SelectFilters.Report
                  oComp.WhereFilter = clsComp.WhereFilters.Report
                  oComp.OrderByFilter = clsComp.OrderByFilters.Report

                  oComp.CompId = ToLong(oRow.GetRow.Cells("CompId").Value)
                  If oComp.Find Then
                     rpt = New rptCompEdit
                     rpt.DataSource = oComp.DataSet.Tables(oComp.TableName).DefaultView

                     If ToLong(oRow.GetRow.Cells("TipoCompId").Value) = 1 Then
                        rpt.lblTitle.Text = "Comprobante de Ingreso"
                        rpt.Document.Name = "Comprobante de Ingreso"

                        rpt.lblEntregadoA.Text = "Hemos recibido de:"
                        rpt.lblPorConcepto.Text = "Por concepto de:"

                        rpt.lblCompPie.Text = "CI : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

                     ElseIf ToLong(oRow.GetRow.Cells("TipoCompId").Value) = 2 Then
                        rpt.lblTitle.Text = "Comprobante de Egreso"
                        rpt.Document.Name = "Comprobante de Egreso"

                        rpt.lblEntregadoA.Text = "Hemos entregado a:"
                        rpt.lblPorConcepto.Text = "Por concepto de:"

                        rpt.lblCompPie.Text = "CE : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))

                     ElseIf ToLong(oRow.GetRow.Cells("TipoCompId").Value) = 3 Then
                        rpt.lblTitle.Text = "Comprobante de Traspaso"
                        rpt.Document.Name = "Comprobante de Traspaso"

                        rpt.lblEntregadoA.Text = "Por concepto de:"
                        rpt.lblPorConcepto.Text = ""

                        rpt.lblCompPie.Text = "CT : " & ToStr(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("CompNro")) & " - " & ToDateDMY(oComp.DataSet.Tables(oComp.TableName).Rows(0).Item("Fecha"))
                     End If

                     rpt.txtFirma.Text = CompParaFirma(ToLong(oRow.GetRow.Cells("TipoCompId").Value), ToLong(oRow.GetRow.Cells("GestionId").Value), lngTipoHojaId)
                     rpt.lblCompany.Text = clsAppInfo.EmpresaGral
                     rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
                     rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
                     rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

                     Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, lngTipoHojaId)

                     rpt.Run(True)

                     For i = 0 To rpt.Document.Pages.Count - 1
                        rptAll.Document.Pages.Add(rpt.Document.Pages(i))
                     Next
                  End If
               End If
            Next

            Call ForcePageSize(rptAll.Document.Printer, rptAll.PageSettings, lngTipoHojaId)

            If (lngTipoHojaId = 1) Or (lngTipoHojaId = 3) Then 'Carta o Oficio
               Dim frm As New frmReportPreview(rptAll.Document)
               frm.Show()

            ElseIf (lngTipoHojaId = 2) Or (lngTipoHojaId = 4) Then 'Media Carta o Medio Oficio
               Dim frm As New frmReportPreviewMultiple(rptAll.Document)
               frm.numberOfPagesPerPrinterPage = 2
               frm.TipoHojaId = lngTipoHojaId
               frm.Show()
            End If

            If clsAppInfo.RegistrarBitacora Then
               For Each oRow In grdMain.SelectedItems
                  If ToLong(oRow.GetRow.Cells("CompId").Value) <> 0 Then
                     With oComp.VMNew
                        .CompId = ToLong(oRow.GetRow.Cells("CompId").Value)
                        .CompNro = ToLong(oRow.GetRow.Cells("CompNro").Value)
                        .TipoCompId = ToLong(oRow.GetRow.Cells("TipoCompId").Value)
                        .TipoCompDes = ToStr(oRow.GetRow.Cells("TipoCompDes").Value)

                        .FormName = Me.Name
                        .FormText = Me.Text
                        .ToShowOpe(clsTipoOpera.IMPRESION_INFORME)
                     End With
                  End If
               Next
            End If
         End If
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oComp.Dispose()
      End Try
   End Sub
#End Region

#Region " COMPROBANTE "
#Region " Metodo-Comprobante "
   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 12)
      fc.FormatStyle.ForeColor = Color.DarkRed
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 13)
      fc.FormatStyle.ForeColor = Color.DarkOrange
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 11)
      fc.FormatStyle.ForeColor = Color.DarkGreen
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("EstadoId"), Janus.Windows.GridEX.ConditionOperator.Equal, 10)
      fc.FormatStyle.ForeColor = Color.DarkBlue
      grdMain.RootTable.FormatConditions.Add(fc)
   End Sub
#End Region

#Region " Grid-Comprobante "
   Private Sub grdMainInit()
      With grdMain
         ebrMain.Groups(0).Text = "Comprobantes"
         .ContextMenu = mnuMain

         .RootTable.Columns("CompId").Visible = False

         .RootTable.Columns("EmpresaId").Visible = False

         .RootTable.Columns("GestionId").Visible = False

         .RootTable.Columns("Fecha").Caption = "Fecha"
         .RootTable.Columns("Fecha").FormatString = "dd/MM/yyyy"
         .RootTable.Columns("Fecha").Width = 100
         .RootTable.Columns("Fecha").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Fecha").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCompId").Visible = False

         .RootTable.Columns("TipoCompDes").Caption = "Tipo"
         .RootTable.Columns("TipoCompDes").Width = 100
         .RootTable.Columns("TipoCompDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoCompDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EstadoId").Visible = False

         .RootTable.Columns("EstadoDes").Caption = "Estado"
         .RootTable.Columns("EstadoDes").Width = 80
         .RootTable.Columns("EstadoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EstadoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("CompNro").Caption = "Número"
         .RootTable.Columns("CompNro").Width = 80
         .RootTable.Columns("CompNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("CompNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("MonedaId").Visible = False

         .RootTable.Columns("MonedaDes").Caption = "Moneda"
         .RootTable.Columns("MonedaDes").Width = 100
         .RootTable.Columns("MonedaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("MonedaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoCambio").Caption = "Tipo Cambio"
         .RootTable.Columns("TipoCambio").FormatString = DecimalMask()
         .RootTable.Columns("TipoCambio").Width = 100
         .RootTable.Columns("TipoCambio").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("TipoCambio").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("DebeBs").Caption = "Monto Bs"
         .RootTable.Columns("DebeBs").FormatString = DecimalMask()
         .RootTable.Columns("DebeBs").Width = 100
         .RootTable.Columns("DebeBs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("DebeBs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("DebeUs").Caption = "Monto $us"
         .RootTable.Columns("DebeUs").FormatString = DecimalMask()
         .RootTable.Columns("DebeUs").Width = 100
         .RootTable.Columns("DebeUs").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
         .RootTable.Columns("DebeUs").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("EntregadoA").Caption = "Detalle 1"
         .RootTable.Columns("EntregadoA").Width = 150
         .RootTable.Columns("EntregadoA").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("EntregadoA").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("PorConcepto").Caption = "Detalle 2"
         .RootTable.Columns("PorConcepto").Width = 150
         .RootTable.Columns("PorConcepto").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("PorConcepto").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("TipoNotaId").Visible = False

         .RootTable.Columns("TipoNotaDes").Caption = "Tipo Nota"
         .RootTable.Columns("TipoNotaDes").Width = 100
         .RootTable.Columns("TipoNotaDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoNotaDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         .RootTable.Columns("NotaNro").Caption = "Nro Nota"
         .RootTable.Columns("NotaNro").Width = 100
         .RootTable.Columns("NotaNro").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("NotaNro").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If clsAppInfo.MultipleNro Then
            .RootTable.Columns("SinFac").Caption = "I"
            .RootTable.Columns("SinFac").Width = 50
            .RootTable.Columns("SinFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("SinFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ConFac").Caption = "F"
            .RootTable.Columns("ConFac").Width = 50
            .RootTable.Columns("ConFac").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            .RootTable.Columns("ConFac").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         Else
            .RootTable.Columns("SinFac").Visible = False
            .RootTable.Columns("ConFac").Visible = False
         End If

         .RootTable.Columns("TipoAsientoId").Visible = False

         .RootTable.Columns("TipoAsientoDes").Caption = "Asiento"
         .RootTable.Columns("TipoAsientoDes").Width = 100
         .RootTable.Columns("TipoAsientoDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
         .RootTable.Columns("TipoAsientoDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center


      End With

      Call AddConditionalFormatting()
   End Sub

   Private Sub DataViewAll()
      grdMain.RemoveFilters()
   End Sub

   Private Sub grdMainLoad()
      Try
         With moComp
            .SelectFilter = clsComp.SelectFilters.Grid
            .WhereFilter = clsComp.WhereFilters.Grid
            .OrderByFilter = clsComp.OrderByFilters.Grid

            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .RowsMax = ToLong(txtMaxReg.Text)
            If .Open() Then
               grdMain.DataSource = .DataSet.Tables(.TableName).DefaultView
               grdMain.RetrieveStructure()
               Call grdMainInit()
            End If

            .CloseConection()
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub FormNew()
      Dim frm As New frmCompEdit
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      Try
         With frm
            .NewRecord = True
            .Editing = False
            oComp.EmpresaId = mlngEmpresaId
            .DataObject = oComp
            .ShowDialog()
            If .Changed Then
               Call grdMainLoad()
               Call grdMainFindRow(frm.ID)

               If MessageBox.Show("Comprobante Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Call frm.PrintReport()
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         frm.Dispose()
         oComp.Dispose()
      End Try
   End Sub

   Private Sub DataEdit()
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("CompId")) > 0 Then
         If ToLong(grdMain.GetValue("EstadoId")) = clsEstado.ANULADO Or _
         ToLong(grdMain.GetValue("EstadoId")) = clsEstado.CERRADO Then
            Call DataShow()
         Else
            Dim oComp As New clsComp(clsAppInfo.ConnectString)
            Try
               With oComp
                  .CompId = ToLong(grdMain.GetValue("CompId"))

                  If .FindByPK Then
                     Dim frm As New frmCompEdit
                     frm.NewRecord = False
                     frm.Editing = True
                     frm.DataObject = oComp
                     frm.ShowDialog()

                     If frm.Changed Then
                        Call grdMainLoad()
                        Call grdMainFindRow(frm.ID)

                        If MessageBox.Show("Comprobante Guardado Exitosamente" + vbCrLf + "¿Desea Imprimir el Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                           Call frm.PrintReport()
                        End If
                     End If
                     frm.Dispose()
                  End If
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
               oComp.Dispose()
            End Try
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub DataShow()
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("CompId")) > 0 Then
         Dim oComp As New clsComp(clsAppInfo.ConnectString)
         Try
            With oComp
               .CompId = ToLong(grdMain.GetValue("CompId"))

               If .FindByPK Then
                  Dim frm As New frmCompEdit

                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oComp

                  frm.ShowDialog()
                  frm.Dispose()
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Finally
            oComp.Dispose()
         End Try
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub CloneVM(ByRef oVM As clsCompVM)
      If clsAppInfo.RegistrarBitacora Then
         oVM = New clsCompVM

         With oVM
            .CompId = ToLong(grdMain.GetValue("CompId"))
            .CompNro = ToStr(grdMain.GetValue("CompNro"))
            .TipoCompDes = ToStr(grdMain.GetValue("TipoCompDes"))

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Sub DataDelete()
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("CompId")) > 0 Then
         If OperaFechaHabil(ToDate(grdMain.GetValue("Fecha"))) Then

            Dim oComp As New clsComp(clsAppInfo.ConnectString)
            oComp.CompId = ToLong(grdMain.GetValue("CompId"))
            Call oComp.FindByPK()

            If oComp.CompNro = 0 Then
               Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
               Dim oFactura As New clsFactura(clsAppInfo.ConnectString)
               Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
               Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
               Dim oCompPlanEEFF As New clsCompPlanEEFF(clsAppInfo.ConnectString)
               Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

               Try
                  If MessageBox.Show("¿Realmente Quiere Eliminar el Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                     oComp.WhereFilter = clsComp.WhereFilters.PrimaryKey
                     oComp.CompId = ToLong(grdMain.GetValue("CompId"))
                     Call CloneVM(oComp.VMNew)
                     Call oComp.Delete()
                     oComp.CloseConection()

                     oCompDet.WhereFilter = clsCompDet.WhereFilters.CompId
                     oCompDet.EmpresaId = mlngEmpresaId
                     oCompDet.CompId = ToLong(grdMain.GetValue("CompId"))
                     Call oCompDet.Delete()
                     oCompDet.CloseConection()

                     oFactura.WhereFilter = clsFactura.WhereFilters.CompId
                     oFactura.EmpresaId = mlngEmpresaId
                     oFactura.CompId = ToLong(grdMain.GetValue("CompId"))
                     Call oFactura.Delete()
                     oFactura.CloseConection()

                     oCompCheque.WhereFilter = clsCompCheque.WhereFilters.CompId
                     oCompCheque.EmpresaId = mlngEmpresaId
                     oCompCheque.CompId = ToLong(grdMain.GetValue("CompId"))
                     Call oCompCheque.Delete()
                     oCompCheque.CloseConection()

                     oCompPlanAdd.WhereFilter = clsCompPlanAdd.WhereFilters.CompId
                     oCompPlanAdd.EmpresaId = mlngEmpresaId
                     oCompPlanAdd.CompId = ToLong(grdMain.GetValue("CompId"))
                     Call oCompPlanAdd.Delete()
                     oCompPlanAdd.CloseConection()

                     oCompCentroCostoDet.WhereFilter = clsCompCentroCostoDet.WhereFilters.CompId
                     oCompCentroCostoDet.EmpresaId = mlngEmpresaId
                     oCompCentroCostoDet.CompId = ToLong(grdMain.GetValue("CompId"))
                     Call oCompCentroCostoDet.Delete()
                     oCompCentroCostoDet.CloseConection()

                     oCompPlanEEFF.WhereFilter = clsCompPlanEEFF.WhereFilters.CompId
                     oCompPlanEEFF.EmpresaId = mlngEmpresaId
                     oCompPlanEEFF.CompId = ToLong(grdMain.GetValue("CompId"))
                     Call oCompPlanEEFF.Delete()
                     oCompPlanEEFF.CloseConection()

                     Call grdMainLoad()
                  End If

               Catch exp As Exception
                  MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Finally
                  oComp.Dispose()
                  oCompDet.Dispose()
                  oFactura.Dispose()
                  oCompCheque.Dispose()
                  oCompPlanAdd.Dispose()
                  oCompCentroCostoDet.Dispose()
                  oCompPlanEEFF.Dispose()
               End Try
            Else
               MessageBox.Show("Imposible Eliminar el Comprobante", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Call grdMainLoad()
            End If
         Else
            MessageBox.Show("Fecha de Operación Inhábil para el Usuario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub mnuShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShow.Click
      Call DataShow()
   End Sub

   Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
      Call FormNew()
   End Sub

   Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
      Call DataEdit()
   End Sub

   Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
      Call DataDelete()
   End Sub

   Private Sub grdMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdMain.DoubleClick
      Call DataShow()
   End Sub

   Private Sub grdMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdMain.MouseDown
      If e.Button = MouseButtons.Right Then
         If grdMain.RowCount > 0 Then
            mnuNew.Enabled = JanusToBooleam(cdmMain.Commands.Item("New").Enabled)
            mnuEdit.Enabled = JanusToBooleam(cdmMain.Commands.Item("Edit").Enabled)
            mnuDelete.Enabled = JanusToBooleam(cdmMain.Commands.Item("Delete").Enabled)
            mnuShow.Enabled = True
         Else
            mnuShow.Enabled = False
            mnuNew.Enabled = JanusToBooleam(cdmMain.Commands.Item("New").Enabled)
            mnuEdit.Enabled = False
            mnuDelete.Enabled = False
         End If
      End If
   End Sub

   Private Function CompRevertir() As Boolean
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("CompId")) Then
         If MessageBox.Show("¿Realmente Quiere Revertir el Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim oComp As New clsComp(clsAppInfo.ConnectString)
            Dim oCompDup As New clsComp(clsAppInfo.ConnectString)
            Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
            Dim oCompDetDup As New clsCompDet(clsAppInfo.ConnectString)
            Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
            Dim oCompPlanAddDup As New clsCompPlanAdd(clsAppInfo.ConnectString)
            Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
            Dim oCompCentroCostoDetDup As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
            Try
               With oComp
                  .CompId = ToLong(grdMain.GetValue("CompId"))

                  If .FindByPK Then
                     oCompDup.EmpresaId = .EmpresaId
                     oCompDup.GestionId = .GestionId
                     oCompDup.TipoCompId = clsTipoComp.TRASPASO
                     oCompDup.CompNro = 0
                     oCompDup.Fecha = ToDate(Now.Date)
                     oCompDup.MonedaId = .MonedaId
                     oCompDup.TipoCambio = .TipoCambio
                     oCompDup.EntregadoA = .EntregadoA
                     oCompDup.PorConcepto = .PorConcepto
                     oCompDup.DebeBs = .HaberBs
                     oCompDup.HaberBs = .DebeBs
                     oCompDup.DebeUs = .HaberUs
                     oCompDup.HaberUs = .DebeUs
                     oCompDup.PorIVA = .PorIVA
                     oCompDup.PorIT = .PorIT
                     oCompDup.PorITF = .PorITF
                     oCompDup.ConFac = .ConFac
                     oCompDup.Automatico = False
                     oCompDup.Glosa = .Glosa
                     oCompDup.TipoNotaId = .TipoNotaId
                     oCompDup.NotaNro = .NotaNro
                     oCompDup.EstadoId = clsEstado.PENDIENTE
                     oCompDup.SinFac = .SinFac
                     oCompDup.TipoAsientoId = .TipoAsientoId 'ym

                     Call CloneVMComp(oCompDup, "Revertido")
                     If oCompDup.Insert Then
                        CompRevertir = True

                        With oCompDet
                           .SelectFilter = clsCompDet.SelectFilters.All
                           .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
                           .OrderByFilter = clsCompDet.OrderByFilters.Grid 'yovana
                           .EmpresaId = oComp.EmpresaId
                           .CompId = oComp.CompId
                           .Automatico = 0

                           If .Open() Then
                              Do While .Read()
                                 oCompDetDup.EmpresaId = .EmpresaId
                                 oCompDetDup.CompId = oCompDup.CompId
                                 oCompDetDup.GestionId = .GestionId
                                 oCompDetDup.TipoCompId = clsTipoComp.TRASPASO
                                 oCompDetDup.Fecha = ToDate(Now.Date)
                                 oCompDetDup.PlanId = .PlanId
                                 oCompDetDup.CompDetDes = .CompDetDes
                                 oCompDetDup.SucursalId = .SucursalId
                                 oCompDetDup.CentroCostoId = .CentroCostoId
                                 oCompDetDup.MonedaId = .MonedaId

                                 'oCompDetDup.DebeOrg = .HaberOrg
                                 'oCompDetDup.HaberOrg = .DebeOrg

                                 'If .MonedaId = clsMoneda.BOLIVIANOS Then
                                 '   oCompDetDup.DebeOrg = .HaberOrg
                                 '   oCompDetDup.HaberOrg = .DebeOrg
                                 'Else
                                 oCompDetDup.DebeOrg = .HaberOrg
                                 oCompDetDup.HaberOrg = .DebeOrg
                                 'End If

                                 oCompDetDup.DebeBs = .HaberBs
                                 oCompDetDup.HaberBs = .DebeBs
                                 oCompDetDup.DebeUs = .HaberUs
                                 oCompDetDup.HaberUs = .DebeUs
                                 oCompDetDup.Orden = .Orden
                                 oCompDetDup.Automatico = False
                                 oCompDetDup.EstadoId = clsEstado.PENDIENTE


                                 If oCompDetDup.Insert Then
                                    With oCompPlanAdd
                                       .SelectFilter = clsCompPlanAdd.SelectFilters.All
                                       .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId

                                       .EmpresaId = oCompDet.EmpresaId
                                       .CompId = oCompDet.CompId
                                       .CompDetId = oCompDet.CompDetId
                                       If .Open() Then
                                          Do While .Read()
                                             oCompPlanAddDup.EmpresaId = .EmpresaId
                                             oCompPlanAddDup.GestionId = .GestionId
                                             oCompPlanAddDup.CompId = oCompDetDup.CompId
                                             oCompPlanAddDup.CompDetId = oCompDetDup.CompDetId
                                             oCompPlanAddDup.Fecha = ToDate(Now.Date)
                                             oCompPlanAddDup.PlanId = .PlanId
                                             oCompPlanAddDup.MonedaId = .MonedaId
                                             oCompPlanAddDup.PlanAddId = .PlanAddId

                                             'oCompPlanAddDup.DebeOrg = .HaberOrg
                                             'oCompPlanAddDup.HaberOrg = .DebeOrg

                                             If .MonedaId = clsMoneda.BOLIVIANOS Then
                                                oCompPlanAddDup.DebeOrg = .HaberBs
                                                oCompPlanAddDup.HaberOrg = .DebeBs
                                             Else
                                                oCompPlanAddDup.DebeOrg = .HaberUs
                                                oCompPlanAddDup.HaberOrg = .DebeUs
                                             End If

                                             oCompPlanAddDup.DebeBs = .HaberBs
                                             oCompPlanAddDup.HaberBs = .DebeBs
                                             oCompPlanAddDup.DebeUs = .HaberUs
                                             oCompPlanAddDup.HaberUs = .DebeUs
                                             oCompPlanAddDup.EstadoId = clsEstado.PENDIENTE

                                             If oCompPlanAddDup.Insert Then
                                                CompRevertir = True
                                             End If

                                             .MoveNext()
                                          Loop
                                       End If
                                    End With
                                    With oCompCentroCostoDet
                                       .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
                                       .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
                                       .EmpresaId = oCompDet.EmpresaId
                                       .CompId = oCompDet.CompId
                                       .CompDetId = oCompDet.CompDetId

                                       If .Open Then
                                          Do While .Read
                                             oCompCentroCostoDetDup.EmpresaId = .EmpresaId
                                             oCompCentroCostoDetDup.GestionId = .GestionId
                                             oCompCentroCostoDetDup.CompId = oCompDetDup.CompId
                                             oCompCentroCostoDetDup.CompDetId = oCompDetDup.CompDetId
                                             oCompCentroCostoDetDup.Fecha = ToDate(Now.Date)
                                             oCompCentroCostoDetDup.PlanId = .PlanId
                                             oCompCentroCostoDetDup.MonedaId = .MonedaId
                                             oCompCentroCostoDetDup.CentroCostoId = .CentroCostoId
                                             oCompCentroCostoDetDup.CentroCostoDetId = .CentroCostoDetId

                                             If .MonedaId = clsMoneda.BOLIVIANOS Then
                                                oCompCentroCostoDetDup.DebeOrg = .HaberBs
                                                oCompCentroCostoDetDup.HaberOrg = .DebeBs
                                             Else
                                                oCompCentroCostoDetDup.DebeOrg = .HaberUs
                                                oCompCentroCostoDetDup.HaberOrg = .DebeUs
                                             End If

                                             oCompCentroCostoDetDup.DebeBs = .HaberBs
                                             oCompCentroCostoDetDup.HaberBs = .DebeBs
                                             oCompCentroCostoDetDup.DebeUs = .HaberUs
                                             oCompCentroCostoDetDup.HaberUs = .DebeUs
                                             oCompCentroCostoDetDup.EstadoId = clsEstado.PENDIENTE

                                             If oCompCentroCostoDetDup.Insert Then
                                                CompRevertir = True
                                             End If

                                             .MoveNext()
                                          Loop
                                       End If
                                    End With
                                 End If

                                 .MoveNext()
                              Loop
                           End If
                        End With

                        If CompRevertir Then
                           Call grdMainLoad()
                           Call grdMainFindRow(oCompDup.CompId)
                           Call DataEdit()
                        End If
                     End If
                  End If
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Finally
               oComp.Dispose()
               oCompDup.Dispose()
               oCompDet.Dispose()
               oCompDetDup.Dispose()
               oCompPlanAdd.Dispose()
               oCompPlanAddDup.Dispose()
               oCompCentroCostoDet.Dispose()
               oCompCentroCostoDetDup.Dispose()
            End Try
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Sub CloneVMComp(ByRef oComp As clsComp, Optional ByVal TipoOperaDes As String = "")
      If clsAppInfo.RegistrarBitacora Then
         With oComp
            .VMNew.TipoCompId = .TipoCompId
            .VMNew.Fecha = ConvertDMY(.Fecha)
            .VMNew.MonedaId = .MonedaId
            .VMNew.TipoCambio = .TipoCambio
            .VMNew.EntregadoA = .EntregadoA
            .VMNew.PorConcepto = .PorConcepto
            .VMNew.DebeBs = .DebeBs
            .VMNew.DebeUs = .DebeUs
            .VMNew.HaberBs = .HaberBs
            .VMNew.HaberUs = .HaberUs
            .VMNew.PorIVA = .PorIVA
            .VMNew.PorIT = .PorIT
            .VMNew.PorITF = .PorITF
            .VMNew.ConFac = .ConFac
            .VMNew.SinFac = .SinFac
            .VMNew.Automatico = .Automatico
            .VMNew.Glosa = .Glosa
            .VMNew.TipoNotaId = .TipoNotaId
            .VMNew.NotaNro = .NotaNro
            .VMNew.EstadoId = .EstadoId

            .VMNew.FormName = Me.Name
            .VMNew.FormText = Me.Text
            .VMNew.TipoOperaDes = TipoOperaDes
         End With
      End If
   End Sub

   Private Function CompDuplicate() As Boolean
      If grdMain.RowCount > 0 And ToLong(grdMain.GetValue("CompId")) Then
         If MessageBox.Show("¿Realmente Quiere Duplicar el Comprobante?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim oComp As New clsComp(clsAppInfo.ConnectString)
            Dim oCompDup As New clsComp(clsAppInfo.ConnectString)
            Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
            Dim oCompDetDup As New clsCompDet(clsAppInfo.ConnectString)
            Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
            Dim oCompPlanAddDup As New clsCompPlanAdd(clsAppInfo.ConnectString)
            Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
            Dim oCompCentroCostoDetDup As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

            Try
               With oComp
                  .WhereFilter = clsComp.WhereFilters.PrimaryKey
                  .CompId = ToLong(grdMain.GetValue("CompId"))

                  If .FindByPK Then
                     oCompDup.EmpresaId = .EmpresaId
                     oCompDup.GestionId = .GestionId
                     oCompDup.TipoCompId = .TipoCompId
                     oCompDup.CompNro = 0
                     oCompDup.Fecha = ToDate(Now.Date)
                     oCompDup.MonedaId = .MonedaId
                     oCompDup.TipoCambio = .TipoCambio
                     oCompDup.EntregadoA = .EntregadoA
                     oCompDup.PorConcepto = .PorConcepto
                     oCompDup.DebeBs = .DebeBs
                     oCompDup.HaberBs = .HaberBs
                     oCompDup.DebeUs = .DebeUs
                     oCompDup.HaberUs = .HaberUs
                     oCompDup.PorIVA = .PorIVA
                     oCompDup.PorIT = .PorIT
                     oCompDup.PorITF = .PorITF
                     oCompDup.ConFac = .ConFac
                     oCompDup.SinFac = .SinFac
                     oCompDup.Automatico = .Automatico
                     oCompDup.Glosa = .Glosa
                     oCompDup.TipoNotaId = .TipoNotaId
                     oCompDup.NotaNro = .NotaNro
                     oCompDup.EstadoId = clsEstado.PENDIENTE

                     Call CloneVMComp(oCompDup, "Duplicado")
                     If oCompDup.Insert Then
                        CompDuplicate = True

                        With oCompDet
                           .SelectFilter = clsCompDet.SelectFilters.All
                           .WhereFilter = clsCompDet.WhereFilters.CompIdAutomatico
                           .OrderByFilter = clsCompDet.OrderByFilters.Grid 'yovana
                           .EmpresaId = oComp.EmpresaId
                           .CompId = oComp.CompId
                           .Automatico = 0

                           If .Open() Then
                              Do While .Read()
                                 oCompDetDup.EmpresaId = .EmpresaId
                                 oCompDetDup.CompId = oCompDup.CompId
                                 oCompDetDup.GestionId = .GestionId
                                 oCompDetDup.TipoCompId = .TipoCompId
                                 oCompDetDup.Fecha = ToDate(Now.Date)
                                 oCompDetDup.PlanId = .PlanId
                                 oCompDetDup.CompDetDes = .CompDetDes
                                 oCompDetDup.SucursalId = .SucursalId
                                 oCompDetDup.CentroCostoId = .CentroCostoId
                                 oCompDetDup.MonedaId = .MonedaId
                                 oCompDetDup.DebeOrg = .DebeOrg
                                 oCompDetDup.HaberOrg = .HaberOrg
                                 oCompDetDup.DebeBs = .DebeBs
                                 oCompDetDup.HaberBs = .HaberBs
                                 oCompDetDup.DebeUs = .DebeUs
                                 oCompDetDup.HaberUs = .HaberUs
                                 oCompDetDup.Orden = .Orden
                                 oCompDetDup.Automatico = .Automatico
                                 oCompDetDup.EstadoId = clsEstado.PENDIENTE
                                 oCompDetDup.TipoRetencionId = .TipoRetencionId 'ym

                                 If oCompDetDup.Insert Then
                                    With oCompPlanAdd
                                       .SelectFilter = clsCompPlanAdd.SelectFilters.All
                                       .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
                                       .EmpresaId = oCompDet.EmpresaId
                                       .CompId = oCompDet.CompId
                                       .CompDetId = oCompDet.CompDetId

                                       If .Open() Then
                                          Do While .Read()
                                             oCompPlanAddDup.EmpresaId = .EmpresaId
                                             oCompPlanAddDup.GestionId = .GestionId
                                             oCompPlanAddDup.CompId = oCompDetDup.CompId
                                             oCompPlanAddDup.CompDetId = oCompDetDup.CompDetId
                                             oCompPlanAddDup.Fecha = ToDate(Now.Date)
                                             oCompPlanAddDup.PlanId = .PlanId
                                             oCompPlanAddDup.MonedaId = .MonedaId
                                             oCompPlanAddDup.PlanAddId = .PlanAddId
                                             oCompPlanAddDup.DebeOrg = .DebeOrg
                                             oCompPlanAddDup.HaberOrg = .HaberOrg
                                             oCompPlanAddDup.DebeBs = .DebeBs
                                             oCompPlanAddDup.HaberBs = .HaberBs
                                             oCompPlanAddDup.DebeUs = .DebeUs
                                             oCompPlanAddDup.HaberUs = .HaberUs
                                             oCompPlanAddDup.EstadoId = clsEstado.PENDIENTE

                                             If oCompPlanAddDup.Insert Then
                                                CompDuplicate = True
                                             End If

                                             .MoveNext()
                                          Loop
                                       End If
                                    End With

                                    With oCompCentroCostoDet
                                       .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
                                       .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
                                       .EmpresaId = oCompDet.EmpresaId
                                       .CompId = oCompDet.CompId
                                       .CompDetId = oCompDet.CompDetId

                                       If .Open Then
                                          Do While .Read
                                             oCompCentroCostoDetDup.EmpresaId = .EmpresaId
                                             oCompCentroCostoDetDup.GestionId = .GestionId
                                             oCompCentroCostoDetDup.CompId = oCompDetDup.CompId
                                             oCompCentroCostoDetDup.CompDetId = oCompDetDup.CompDetId
                                             oCompCentroCostoDetDup.Fecha = ToDate(Now.Date)
                                             oCompCentroCostoDetDup.PlanId = .PlanId
                                             oCompCentroCostoDetDup.MonedaId = .MonedaId
                                             oCompCentroCostoDetDup.CentroCostoId = .CentroCostoId
                                             oCompCentroCostoDetDup.CentroCostoDetId = .CentroCostoDetId
                                             oCompCentroCostoDetDup.DebeOrg = .DebeOrg
                                             oCompCentroCostoDetDup.HaberOrg = .HaberOrg
                                             oCompCentroCostoDetDup.DebeBs = .DebeBs
                                             oCompCentroCostoDetDup.HaberBs = .HaberBs
                                             oCompCentroCostoDetDup.DebeUs = .DebeUs
                                             oCompCentroCostoDetDup.HaberUs = .HaberUs
                                             oCompCentroCostoDetDup.EstadoId = clsEstado.PENDIENTE

                                             If oCompCentroCostoDetDup.Insert Then
                                                CompDuplicate = True
                                             End If

                                             .MoveNext()
                                          Loop
                                       End If
                                    End With

                                 End If

                                 .MoveNext()
                              Loop
                           End If
                        End With

                        If CompDuplicate Then
                           Call grdMainLoad()
                           Call grdMainFindRow(oCompDup.CompId)
                           Call DataEdit()
                        End If
                     End If
                  End If
               End With

            Catch exp As Exception
               MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Finally
               oComp.Dispose()
               oCompDup.Dispose()
               oCompDet.Dispose()
               oCompDetDup.Dispose()
               oCompPlanAdd.Dispose()
               oCompPlanAddDup.Dispose()
               oCompCentroCostoDet.Dispose()
               oCompCentroCostoDetDup.Dispose()
            End Try
         End If
      Else
         MessageBox.Show("Debe Seleccionar un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If

      If e.KeyCode = Keys.Apps Then
         mnuShow.Enabled = True
         mnuNew.Enabled = JanusToBooleam(cdmMain.Commands.Item("New").Enabled)
         mnuEdit.Enabled = JanusToBooleam(cdmMain.Commands.Item("Edit").Enabled)
         mnuDelete.Enabled = JanusToBooleam(cdmMain.Commands.Item("Delete").Enabled)
      End If
   End Sub
#End Region
#End Region

#Region "Reordenar Numeracion"

   Private Sub frmOrdenarNumeroLoad()
      If grdMain.RowCount > 0 Then
         Dim frm As New frmCompOrden
         frm.ShowDialog()
         If frm.Changed Then
            Call grdMainLoad()
         End If
         frm.Dispose()
      End If
   End Sub

#End Region
End Class
