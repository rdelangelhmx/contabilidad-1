Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls

Public Class frmSort
   Inherits System.Windows.Forms.Form

   Private moGrid As GridEX
   Private moSortKeys As GridEXSortKey()

   Private mboolLoading As Boolean
   Friend WithEvents grbSort4 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboColumn3 As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents optDescending3 As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optAscending3 As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents grbSort2 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboColumn1 As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents optDescending1 As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optAscending1 As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents grbSort1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboColumn0 As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents optDescending0 As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optAscending0 As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents grbSort3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboColumn2 As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents optDescending2 As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optAscending2 As Janus.Windows.EditControls.UIRadioButton
   Private mboolChanged As Boolean

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   WriteOnly Property oGrid() As GridEX
      Set(ByVal Value As GridEX)
         moGrid = Value
      End Set
   End Property

   ReadOnly Property oSortKeys() As GridEXSortKey()
      Get
         Return moSortKeys
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
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSort))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grbSort4 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboColumn3 = New Janus.Windows.EditControls.UIComboBox
      Me.optDescending3 = New Janus.Windows.EditControls.UIRadioButton
      Me.optAscending3 = New Janus.Windows.EditControls.UIRadioButton
      Me.grbSort2 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboColumn1 = New Janus.Windows.EditControls.UIComboBox
      Me.optDescending1 = New Janus.Windows.EditControls.UIRadioButton
      Me.optAscending1 = New Janus.Windows.EditControls.UIRadioButton
      Me.grbSort1 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboColumn0 = New Janus.Windows.EditControls.UIComboBox
      Me.optDescending0 = New Janus.Windows.EditControls.UIRadioButton
      Me.optAscending0 = New Janus.Windows.EditControls.UIRadioButton
      Me.grbSort3 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboColumn2 = New Janus.Windows.EditControls.UIComboBox
      Me.optDescending2 = New Janus.Windows.EditControls.UIRadioButton
      Me.optAscending2 = New Janus.Windows.EditControls.UIRadioButton
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
      CType(Me.grbSort4, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbSort4.SuspendLayout()
      CType(Me.grbSort2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbSort2.SuspendLayout()
      CType(Me.grbSort1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbSort1.SuspendLayout()
      CType(Me.grbSort3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grbSort3.SuspendLayout()
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
      Me.bcgMain.Controls.Add(Me.grbSort4)
      Me.bcgMain.Controls.Add(Me.grbSort2)
      Me.bcgMain.Controls.Add(Me.grbSort1)
      Me.bcgMain.Controls.Add(Me.grbSort3)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(320, 302)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grbSort4
      '
      Me.grbSort4.BackColor = System.Drawing.Color.Transparent
      Me.grbSort4.Controls.Add(Me.cboColumn3)
      Me.grbSort4.Controls.Add(Me.optDescending3)
      Me.grbSort4.Controls.Add(Me.optAscending3)
      Me.grbSort4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbSort4.Location = New System.Drawing.Point(8, 228)
      Me.grbSort4.Name = "grbSort4"
      Me.grbSort4.Size = New System.Drawing.Size(304, 64)
      Me.grbSort4.TabIndex = 18
      Me.grbSort4.Text = "Luego por"
      Me.grbSort4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'cboColumn3
      '
      Me.cboColumn3.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
      Me.cboColumn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboColumn3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboColumn3.Location = New System.Drawing.Point(8, 16)
      Me.cboColumn3.Name = "cboColumn3"
      Me.cboColumn3.Size = New System.Drawing.Size(176, 20)
      Me.cboColumn3.TabIndex = 4
      Me.cboColumn3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optDescending3
      '
      Me.optDescending3.Enabled = False
      Me.optDescending3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optDescending3.Location = New System.Drawing.Point(196, 36)
      Me.optDescending3.Name = "optDescending3"
      Me.optDescending3.Size = New System.Drawing.Size(100, 16)
      Me.optDescending3.TabIndex = 2
      Me.optDescending3.Text = "Descendente"
      Me.optDescending3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optAscending3
      '
      Me.optAscending3.Checked = True
      Me.optAscending3.Enabled = False
      Me.optAscending3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optAscending3.Location = New System.Drawing.Point(196, 16)
      Me.optAscending3.Name = "optAscending3"
      Me.optAscending3.Size = New System.Drawing.Size(100, 16)
      Me.optAscending3.TabIndex = 1
      Me.optAscending3.TabStop = True
      Me.optAscending3.Text = "Ascendente"
      Me.optAscending3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grbSort2
      '
      Me.grbSort2.BackColor = System.Drawing.Color.Transparent
      Me.grbSort2.Controls.Add(Me.cboColumn1)
      Me.grbSort2.Controls.Add(Me.optDescending1)
      Me.grbSort2.Controls.Add(Me.optAscending1)
      Me.grbSort2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbSort2.Location = New System.Drawing.Point(8, 80)
      Me.grbSort2.Name = "grbSort2"
      Me.grbSort2.Size = New System.Drawing.Size(304, 64)
      Me.grbSort2.TabIndex = 19
      Me.grbSort2.Text = "Luego por"
      Me.grbSort2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'cboColumn1
      '
      Me.cboColumn1.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
      Me.cboColumn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboColumn1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboColumn1.Location = New System.Drawing.Point(8, 16)
      Me.cboColumn1.Name = "cboColumn1"
      Me.cboColumn1.Size = New System.Drawing.Size(176, 20)
      Me.cboColumn1.TabIndex = 4
      Me.cboColumn1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optDescending1
      '
      Me.optDescending1.Enabled = False
      Me.optDescending1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optDescending1.Location = New System.Drawing.Point(196, 36)
      Me.optDescending1.Name = "optDescending1"
      Me.optDescending1.Size = New System.Drawing.Size(100, 16)
      Me.optDescending1.TabIndex = 2
      Me.optDescending1.Text = "Descendente"
      Me.optDescending1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optAscending1
      '
      Me.optAscending1.Checked = True
      Me.optAscending1.Enabled = False
      Me.optAscending1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optAscending1.Location = New System.Drawing.Point(196, 16)
      Me.optAscending1.Name = "optAscending1"
      Me.optAscending1.Size = New System.Drawing.Size(100, 16)
      Me.optAscending1.TabIndex = 1
      Me.optAscending1.TabStop = True
      Me.optAscending1.Text = "Ascendente"
      Me.optAscending1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grbSort1
      '
      Me.grbSort1.BackColor = System.Drawing.Color.Transparent
      Me.grbSort1.Controls.Add(Me.cboColumn0)
      Me.grbSort1.Controls.Add(Me.optDescending0)
      Me.grbSort1.Controls.Add(Me.optAscending0)
      Me.grbSort1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbSort1.Location = New System.Drawing.Point(8, 6)
      Me.grbSort1.Name = "grbSort1"
      Me.grbSort1.Size = New System.Drawing.Size(304, 64)
      Me.grbSort1.TabIndex = 20
      Me.grbSort1.Text = "Ordenar columnas por"
      Me.grbSort1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'cboColumn0
      '
      Me.cboColumn0.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
      Me.cboColumn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboColumn0.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboColumn0.Location = New System.Drawing.Point(8, 16)
      Me.cboColumn0.Name = "cboColumn0"
      Me.cboColumn0.Size = New System.Drawing.Size(176, 20)
      Me.cboColumn0.TabIndex = 3
      Me.cboColumn0.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optDescending0
      '
      Me.optDescending0.Enabled = False
      Me.optDescending0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optDescending0.Location = New System.Drawing.Point(196, 36)
      Me.optDescending0.Name = "optDescending0"
      Me.optDescending0.Size = New System.Drawing.Size(100, 16)
      Me.optDescending0.TabIndex = 2
      Me.optDescending0.Text = "Descendente"
      Me.optDescending0.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optAscending0
      '
      Me.optAscending0.Checked = True
      Me.optAscending0.Enabled = False
      Me.optAscending0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optAscending0.Location = New System.Drawing.Point(196, 16)
      Me.optAscending0.Name = "optAscending0"
      Me.optAscending0.Size = New System.Drawing.Size(100, 16)
      Me.optAscending0.TabIndex = 1
      Me.optAscending0.TabStop = True
      Me.optAscending0.Text = "Ascendente"
      Me.optAscending0.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'grbSort3
      '
      Me.grbSort3.BackColor = System.Drawing.Color.Transparent
      Me.grbSort3.Controls.Add(Me.cboColumn2)
      Me.grbSort3.Controls.Add(Me.optDescending2)
      Me.grbSort3.Controls.Add(Me.optAscending2)
      Me.grbSort3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.grbSort3.Location = New System.Drawing.Point(8, 154)
      Me.grbSort3.Name = "grbSort3"
      Me.grbSort3.Size = New System.Drawing.Size(304, 64)
      Me.grbSort3.TabIndex = 21
      Me.grbSort3.Text = "Luego por"
      Me.grbSort3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'cboColumn2
      '
      Me.cboColumn2.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
      Me.cboColumn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboColumn2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboColumn2.Location = New System.Drawing.Point(8, 16)
      Me.cboColumn2.Name = "cboColumn2"
      Me.cboColumn2.Size = New System.Drawing.Size(176, 20)
      Me.cboColumn2.TabIndex = 4
      Me.cboColumn2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optDescending2
      '
      Me.optDescending2.Enabled = False
      Me.optDescending2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optDescending2.Location = New System.Drawing.Point(196, 36)
      Me.optDescending2.Name = "optDescending2"
      Me.optDescending2.Size = New System.Drawing.Size(100, 16)
      Me.optDescending2.TabIndex = 2
      Me.optDescending2.Text = "Descendente"
      Me.optDescending2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'optAscending2
      '
      Me.optAscending2.Checked = True
      Me.optAscending2.Enabled = False
      Me.optAscending2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optAscending2.Location = New System.Drawing.Point(196, 16)
      Me.optAscending2.Name = "optAscending2"
      Me.optAscending2.Size = New System.Drawing.Size(100, 16)
      Me.optAscending2.TabIndex = 1
      Me.optAscending2.TabStop = True
      Me.optAscending2.Text = "Ascendente"
      Me.optAscending2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "Sort.png")
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(149, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      Me.Save1.Text = "Aplicar"
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
      Me.TopRebar1.Size = New System.Drawing.Size(320, 28)
      '
      'frmSort
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(320, 330)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmSort"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ordenar"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grbSort4, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbSort4.ResumeLayout(False)
      CType(Me.grbSort2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbSort2.ResumeLayout(False)
      CType(Me.grbSort1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbSort1.ResumeLayout(False)
      CType(Me.grbSort3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grbSort3.ResumeLayout(False)
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
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmSort_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmSort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()
      Call FormShow()
      Call ClearMemory()

      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      Dim sortKey As GridEXSortKey = Nothing

      If moGrid.RootTable.SortKeys.Count = 0 Then
         SetSortKey(Nothing, True, cboColumn0, optAscending0, optDescending0)

      Else
         If moGrid.RootTable.SortKeys.Count >= 1 Then
            sortKey = moGrid.RootTable.SortKeys(0)
            SetSortKey(sortKey.Column, (sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending), cboColumn0, optAscending0, optDescending0)
         End If

         If moGrid.RootTable.SortKeys.Count >= 2 Then
            sortKey = moGrid.RootTable.SortKeys(1)
            SetSortKey(sortKey.Column, (sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending), cboColumn1, optAscending1, optDescending1)
         End If

         If moGrid.RootTable.SortKeys.Count >= 3 Then
            sortKey = moGrid.RootTable.SortKeys(2)
            SetSortKey(sortKey.Column, (sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending), cboColumn2, optAscending2, optDescending2)
         End If

         If moGrid.RootTable.SortKeys.Count >= 4 Then
            sortKey = moGrid.RootTable.SortKeys(3)
            SetSortKey(sortKey.Column, (sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending), cboColumn3, optAscending3, optDescending3)
         End If
      End If
   End Sub

   Private Sub DataMove()
      moSortKeys = CreateSortKeys()
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If FormCheck() Then
            mboolChanged = True
            Return True
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub SetSortKey(ByVal column As GridEXColumn, ByVal ascending As Boolean, ByVal combo As UIComboBox, ByVal optAscending As UIRadioButton, ByVal optDescending As UIRadioButton)
      If column Is Nothing Then
         combo.SelectedIndex = 0

      Else
         For Each item As Janus.Windows.EditControls.UIComboBoxItem In combo.Items
            If item.Value Is column Then
               combo.SelectedItem = item
               Exit For
            End If
         Next item
      End If

      If ascending Then
         optAscending.Checked = True
      Else
         optDescending.Checked = True
      End If
   End Sub

   Private Function CreateSortKeys() As GridEXSortKey()
      Dim intSortKeysCount As Integer = 0

      If cboColumn3.SelectedIndex > 0 Then
         intSortKeysCount = 4

      ElseIf cboColumn2.SelectedIndex > 0 Then
         intSortKeysCount = 3

      ElseIf cboColumn1.SelectedIndex > 0 Then
         intSortKeysCount = 2

      ElseIf cboColumn0.SelectedIndex > 0 Then
         intSortKeysCount = 1

      Else
         intSortKeysCount = 0
      End If

      Dim sortKeys As GridEXSortKey() = New GridEXSortKey(intSortKeysCount - 1) {}

      If intSortKeysCount > 0 Then
         sortKeys(0) = CreateSortKey(CType((CType(cboColumn0.SelectedItem, UIComboBoxItem)).Value, GridEXColumn), optAscending0.Checked)
      End If

      If intSortKeysCount > 1 Then
         sortKeys(1) = CreateSortKey(CType((CType(cboColumn1.SelectedItem, UIComboBoxItem)).Value, GridEXColumn), optAscending1.Checked)
      End If

      If intSortKeysCount > 2 Then
         sortKeys(2) = CreateSortKey(CType((CType(cboColumn2.SelectedItem, UIComboBoxItem)).Value, GridEXColumn), optAscending2.Checked)
      End If

      If intSortKeysCount > 3 Then
         sortKeys(3) = CreateSortKey(CType((CType(cboColumn3.SelectedItem, UIComboBoxItem)).Value, GridEXColumn), optAscending3.Checked)
      End If

      Return sortKeys
   End Function

   Private Function CreateSortKey(ByVal column As GridEXColumn, ByVal ascending As Boolean) As GridEXSortKey
      Dim sortKey As GridEXSortKey = New GridEXSortKey()

      sortKey.Column = column

      If (Not ascending) Then
         sortKey.SortOrder = Janus.Windows.GridEX.SortOrder.Descending
      End If

      Return sortKey
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)
   End Sub

   Private Sub ComboLoad()
      FillColumnList(moGrid.RootTable.Columns, cboColumn0)
      FillColumnList(moGrid.RootTable.Columns, cboColumn1)
      FillColumnList(moGrid.RootTable.Columns, cboColumn2)
      FillColumnList(moGrid.RootTable.Columns, cboColumn3)
   End Sub

   Private Sub FillColumnList(ByVal columns As GridEXColumnCollection, ByVal combo As Janus.Windows.EditControls.UIComboBox)
      Dim column As GridEXColumn = Nothing
      Dim i As Integer = 0

      'combo.DisplayMember = "Name"
      combo.Items.Clear()
      combo.Items.Add("(Ninguno)", Nothing)
      i = 0
      Do While i < columns.Count
         column = columns(i)
         If column.AllowSort Then
            combo.Items.Add(GetColumnFriendlyName(column), column)
         End If
         i += 1
      Loop
   End Sub

   Private Shared Function GetColumnFriendlyName(ByVal column As Janus.Windows.GridEX.GridEXColumn) As String
      If column.Caption.Length = 0 Then
         If Not column.Tag Is Nothing Then
            Return System.Convert.ToString(column.Tag)
         Else
            Return column.Key
         End If
      Else
         Return column.Caption
      End If
   End Function

   Private Sub cboColumn0_SelectedItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColumn0.SelectedItemChanged
      If cboColumn0.SelectedIndex = 0 Then
         optAscending0.Enabled = False
         optDescending0.Enabled = False
         cboColumn1.SelectedIndex = 0
         cboColumn1.Enabled = False

      Else
         optAscending0.Enabled = True
         optDescending0.Enabled = True
         cboColumn1.Enabled = True

         If cboColumn1.SelectedIndex = -1 Then
            cboColumn1.SelectedIndex = 0
         End If
      End If
   End Sub

   Private Sub cboColumn1_SelectedItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColumn1.SelectedItemChanged
      If cboColumn1.SelectedIndex = 0 Then
         optAscending1.Enabled = False
         optDescending1.Enabled = False
         cboColumn2.SelectedIndex = 0
         cboColumn2.Enabled = False

      Else
         optAscending1.Enabled = True
         optDescending1.Enabled = True
         cboColumn2.Enabled = True

         If cboColumn2.SelectedIndex = -1 Then
            cboColumn2.SelectedIndex = 0
         End If
      End If
   End Sub

   Private Sub cboColumn2_SelectedItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColumn2.SelectedItemChanged
      If cboColumn2.SelectedIndex = 0 Then
         optAscending2.Enabled = False
         optDescending2.Enabled = False
         cboColumn3.SelectedIndex = 0
         cboColumn3.Enabled = False

      Else
         optAscending2.Enabled = True
         optDescending2.Enabled = True
         cboColumn3.Enabled = True

         If cboColumn3.SelectedIndex = -1 Then
            cboColumn3.SelectedIndex = 0
         End If
      End If
   End Sub

   Private Sub cboColumn3_SelectedItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColumn3.SelectedItemChanged
      If cboColumn3.SelectedIndex = 0 Then
         optAscending3.Enabled = False
         optDescending3.Enabled = False

      Else
         optAscending3.Enabled = True
         optDescending3.Enabled = True
      End If
   End Sub

   Private Sub frmSort_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then

            If DataSave() Then
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmSort_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

End Class
