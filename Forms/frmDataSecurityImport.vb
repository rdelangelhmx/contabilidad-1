Public Class frmDataSecurityImport
   Inherits System.Windows.Forms.Form

   Private moDataSet As DataSet
   Private moDataTable As DataTable
   Private moBoolCheck As Boolean
   Private mintTipoLista As Long
   Private moForms As Dictionary(Of String, Long)
   Private moControls As Dictionary(Of String, Long)

   Private moStopwatch As Stopwatch
   Friend WithEvents FormLoad1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ControlLoad1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents FormLoad As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ControlLoad As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckNoAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckAll2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents CheckNoAll1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
   Private moTimeSpan As TimeSpan

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
   Protected WithEvents uiBackground As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
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
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand

   Friend WithEvents ebrMain As Janus.Windows.ExplorerBar.ExplorerBar
   Friend WithEvents ExplorerBarContainerControl4 As Janus.Windows.ExplorerBar.ExplorerBarContainerControl
   Friend WithEvents pbrMain As Janus.Windows.EditControls.UIProgressBar
   Friend WithEvents grdMain As Janus.Windows.GridEX.GridEX

   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataSecurityImport))
      Me.ExplorerBarContainerControl4 = New Janus.Windows.ExplorerBar.ExplorerBarContainerControl
      Me.grdMain = New Janus.Windows.GridEX.GridEX
      Me.uiBackground = New Janus.Windows.EditControls.UIGroupBox
      Me.pbrMain = New Janus.Windows.EditControls.UIProgressBar
      Me.ebrMain = New Janus.Windows.ExplorerBar.ExplorerBar
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.FormLoad1 = New Janus.Windows.UI.CommandBars.UICommand("FormLoad")
      Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ControlLoad1 = New Janus.Windows.UI.CommandBars.UICommand("ControlLoad")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.CheckAll2 = New Janus.Windows.UI.CommandBars.UICommand("CheckAll")
      Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.ViewAll1 = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.FormLoad = New Janus.Windows.UI.CommandBars.UICommand("FormLoad")
      Me.ControlLoad = New Janus.Windows.UI.CommandBars.UICommand("ControlLoad")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.CheckAll = New Janus.Windows.UI.CommandBars.UICommand("CheckAll")
      Me.CheckNoAll = New Janus.Windows.UI.CommandBars.UICommand("CheckNoAll")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.CheckAll1 = New Janus.Windows.UI.CommandBars.UICommand("CheckAll")
      Me.CheckNoAll1 = New Janus.Windows.UI.CommandBars.UICommand("CheckNoAll")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
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
      Me.ExplorerBarContainerControl4.Size = New System.Drawing.Size(728, 347)
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
      Me.grdMain.Size = New System.Drawing.Size(728, 347)
      Me.grdMain.TabIndex = 5
      Me.grdMain.TableHeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
      Me.grdMain.TableHeaderFormatStyle.LineAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.TableHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
      Me.grdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'uiBackground
      '
      Me.uiBackground.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.uiBackground.Controls.Add(Me.pbrMain)
      Me.uiBackground.Controls.Add(Me.ebrMain)
      Me.uiBackground.Dock = System.Windows.Forms.DockStyle.Fill
      Me.uiBackground.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.uiBackground.Location = New System.Drawing.Point(0, 28)
      Me.uiBackground.Name = "uiBackground"
      Me.uiBackground.Size = New System.Drawing.Size(752, 414)
      Me.uiBackground.TabIndex = 5
      Me.uiBackground.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'pbrMain
      '
      Me.pbrMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.pbrMain.Location = New System.Drawing.Point(4, 388)
      Me.pbrMain.Name = "pbrMain"
      Me.pbrMain.ShowPercentage = True
      Me.pbrMain.Size = New System.Drawing.Size(744, 23)
      Me.pbrMain.TabIndex = 6
      Me.pbrMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
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
      ExplorerBarGroup1.ContainerHeight = 348
      ExplorerBarGroup1.Expandable = False
      ExplorerBarGroup1.Key = "Group1"
      Me.ebrMain.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1})
      Me.ebrMain.GroupSeparation = 4
      Me.ebrMain.Location = New System.Drawing.Point(4, 4)
      Me.ebrMain.Name = "ebrMain"
      Me.ebrMain.Size = New System.Drawing.Size(744, 380)
      Me.ebrMain.TabIndex = 4
      Me.ebrMain.Text = "ExplorerBar2"
      Me.ebrMain.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
      Me.ebrMain.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      Me.ebrMain.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2007
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "Form.png")
      Me.ilsMain.Images.SetKeyName(1, "Control.png")
      Me.ilsMain.Images.SetKeyName(2, "")
      Me.ilsMain.Images.SetKeyName(3, "")
      Me.ilsMain.Images.SetKeyName(4, "")
      Me.ilsMain.Images.SetKeyName(5, "checkAll.png")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ViewAll, Me.Print, Me.Exit2, Me.FormLoad, Me.ControlLoad, Me.Save, Me.CheckAll, Me.CheckNoAll})
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.FormLoad1, Me.Separator3, Me.ControlLoad1, Me.Separator7, Me.CheckAll2, Me.Separator9, Me.ViewAll1, Me.Separator4, Me.Print1, Me.Separator5, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(620, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Image = CType(resources.GetObject("Save1.Image"), System.Drawing.Image)
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'FormLoad1
      '
      Me.FormLoad1.Key = "FormLoad"
      Me.FormLoad1.Name = "FormLoad1"
      '
      'Separator3
      '
      Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator3.Key = "Separator"
      Me.Separator3.Name = "Separator3"
      '
      'ControlLoad1
      '
      Me.ControlLoad1.Key = "ControlLoad"
      Me.ControlLoad1.Name = "ControlLoad1"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
      '
      'CheckAll2
      '
      Me.CheckAll2.ImageIndex = 5
      Me.CheckAll2.Key = "CheckAll"
      Me.CheckAll2.Name = "CheckAll2"
      '
      'Separator9
      '
      Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator9.Key = "Separator"
      Me.Separator9.Name = "Separator9"
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
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 2
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
      '
      'Print
      '
      Me.Print.ImageIndex = 3
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 4
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'FormLoad
      '
      Me.FormLoad.ImageIndex = 0
      Me.FormLoad.Key = "FormLoad"
      Me.FormLoad.Name = "FormLoad"
      Me.FormLoad.Text = "Formularios"
      '
      'ControlLoad
      '
      Me.ControlLoad.ImageIndex = 1
      Me.ControlLoad.Key = "ControlLoad"
      Me.ControlLoad.Name = "ControlLoad"
      Me.ControlLoad.Text = "Controles"
      '
      'Save
      '
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.Text = "Guardar"
      '
      'CheckAll
      '
      Me.CheckAll.Key = "CheckAll"
      Me.CheckAll.Name = "CheckAll"
      Me.CheckAll.Text = "Seleccionar Todo"
      '
      'CheckNoAll
      '
      Me.CheckNoAll.Key = "CheckNoAll"
      Me.CheckNoAll.Name = "CheckNoAll"
      Me.CheckNoAll.Text = "Quitar Selección"
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
      'CheckAll1
      '
      Me.CheckAll1.Key = "CheckAll"
      Me.CheckAll1.Name = "CheckAll1"
      '
      'CheckNoAll1
      '
      Me.CheckNoAll1.Key = "CheckNoAll"
      Me.CheckNoAll1.Name = "CheckNoAll1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Separator6
      '
      Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator6.Key = "Separator"
      Me.Separator6.Name = "Separator6"
      '
      'frmDataSecurityImport
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.uiBackground)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.Name = "frmDataSecurityImport"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Listado de Formularios y Controles"
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
         Case "Save"
            Call DataSave()

         Case "FormLoad"
            Call grdMainLoad(1)

         Case "ControlLoad"
            Call grdMainLoad(2)

         Case "Import"
            'If DataImport() Then
            '   MessageBox.Show(ToStr(mintRowExport) & " de " & ToStr(mintRowSel) & " Registros Importados Exitosamente" & vbCrLf & "Tiempo Estimado " & moTimeSpan.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If

         Case "CheckAll"
            Call grdMainCheck(True)

         Case "CheckNoAll"
            Call grdMainCheck(False)

         Case "ViewAll"
            Call DataViewAll()

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmDataSecurityImport_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmDataSecurityImport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Sub grdMainLoad(ByVal lngTipoLoad As Long)
      Dim oForm As Form
      Dim oControl As Control
      Dim oRebar As Janus.Windows.UI.CommandBars.UIRebar
      Dim oCommand As Janus.Windows.UI.CommandBars.UICommand
      Dim strSql = ""
      Try
         moStopwatch = Stopwatch.StartNew()

         pbrMain.Minimum = 0
         pbrMain.Maximum = Me.GetType().Assembly.GetTypes().Count
         pbrMain.Value = 0
         pbrMain.Update()
         pbrMain.Show()

         Call moDataSetInit(lngTipoLoad)

         Call ListFormLoad()

         mintTipoLista = lngTipoLoad

         If lngTipoLoad = 1 Then

            'Dim intCount = 1
            For Each t As Type In Me.GetType().Assembly.GetTypes()
               If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then
                  If (t.Name <> "frmReportExport") And (t.Name <> "frmReportPreview") And (t.Name <> "frmReportPreviewMultiple") And (t.Name <> "frmSplash") Then
                     oForm = CType(Activator.CreateInstance(t), Form)

                     moDataTable.Rows.Add(GetRow(oForm.Name, oForm.Text))

                  End If
               End If

               pbrMain.Value += 1
               pbrMain.Update()

            Next

         Else
            Call ListControlLoad()

            For Each t As Type In Me.GetType().Assembly.GetTypes()
               If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" Then
                  If (t.Name <> "frmReportExport") And (t.Name <> "frmReportPreview") And (t.Name <> "frmReportPreviewMultiple") And (t.Name <> "frmSplash") Then
                     oForm = CType(Activator.CreateInstance(t), Form)

                     For Each oControl In oForm.Controls

                        Dim ctrObjeto As DataRow = getControl(oForm.Name, oForm.Text, oControl)

                        If ctrObjeto IsNot Nothing Then

                           moDataTable.Rows.Add(ctrObjeto)

                        End If
                     Next

                     Call ClearMemory()

                  End If
               End If

               pbrMain.Value += 1
               pbrMain.Update()

            Next

         End If


         grdMain.DataSource = moDataSet.Tables("Forms").DefaultView

         grdMain.RetrieveStructure()
         Call grdMainInit(lngTipoLoad)
         Call ClearMemory()

         moTimeSpan = moStopwatch.Elapsed

      Catch exp As Exception
         moTimeSpan = moStopwatch.Elapsed

         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub grdMainCheck(ByVal boolValue As Boolean)
      For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows
         oRow.BeginEdit()

         oRow.Cells("Sel").Value = boolValue

         oRow.EndEdit()
      Next
   End Sub

   Public Function getControl(ByVal strFomrName As String, ByVal strFormText As String, ByRef ctrUno As Object) As DataRow

      Try
         If UCase$(ctrUno.GetType.Name) = UCase$("UIButton") Then
            Dim ctrDos As Janus.Windows.EditControls.UIButton = CType(ctrUno, Janus.Windows.EditControls.UIButton)

            'If (ctrDos.Visible) Then
            Return GetRowControl(strFomrName, strFormText, ctrDos.Name, ctrDos.Text, "Boton")
            'End If

            'If ctrDos.Name = strFomrName Then
            '   ctrUno.Visible = ToBoolean(oRight.Visible)
            '   ctrUno.Enabled = ToBoolean(oRight.Enabled)
            '   Return True
            'End If

         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UICheckBox") Then
            Dim ctrDos As Janus.Windows.EditControls.UICheckBox = CType(ctrUno, Janus.Windows.EditControls.UICheckBox)

            Return GetRowControl(strFomrName, strFormText, ctrDos.Name, ctrDos.Text, "Check")

            'If ctrDos.Name = strFomrName Then
            '   ctrDos.Visible = ToBoolean(oRight.Visible)
            '   ctrDos.Enabled = ToBoolean(oRight.Enabled)
            '   Return True
            'End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIComboBox") Then
            Dim ctrDos As Janus.Windows.EditControls.UIComboBox = CType(ctrUno, Janus.Windows.EditControls.UIComboBox)

            Return GetRowControl(strFomrName, strFormText, ctrDos.Name, ctrDos.Text, "Combo")

            'If ctrDos.Name = strFomrName Then
            '   ctrDos.Visible = ToBoolean(oRight.Visible)
            '   ctrDos.Enabled = ToBoolean(oRight.Enabled)
            '   Return True
            'End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("CheckBox") Then
            Dim ctrDos As System.Windows.Forms.CheckBox = CType(ctrUno, System.Windows.Forms.CheckBox)

            Return GetRowControl(strFomrName, strFormText, ctrDos.Name, ctrDos.Text, "Check")
            'If ctrDos.Name = strFomrName Then
            '   ctrDos.Visible = ToBoolean(oRight.Visible)
            '   ctrDos.Enabled = ToBoolean(oRight.Enabled)
            '   Return True
            'End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("Button") Then
            Dim ctrDos As System.Windows.Forms.Button = CType(ctrUno, System.Windows.Forms.Button)

            Return GetRowControl(strFomrName, strFormText, ctrDos.Name, ctrDos.Text, "Boton")
            'If ctrDos.Name = strFomrName Then
            '   ctrDos.Visible = ToBoolean(oRight.Visible)
            '   ctrDos.Enabled = ToBoolean(oRight.Enabled)
            '   Return True
            'End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("ComboBox") Then
            Dim ctrDos As System.Windows.Forms.ComboBox = CType(ctrUno, System.Windows.Forms.ComboBox)

            Return GetRowControl(strFomrName, strFormText, ctrDos.Name, ctrDos.Name, "Boton") 'ctrDos.Text, "Boton")
            'If ctrDos.Name = strFomrName Then
            '   ctrDos.Visible = ToBoolean(oRight.Visible)
            '   ctrDos.Enabled = ToBoolean(oRight.Enabled)
            '   Return True
            'End If         
            '----------------  CONTENEDORES -----------------------------------------
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIContainer") Then
            Dim ctrAux As Janus.Windows.UI.Dock.UIPanel = CType(ctrUno, Janus.Windows.UI.Dock.UIPanel)
            For Each ctrDos In ctrAux.Controls
               Dim oRowAux As DataRow = getControl(strFomrName, strFormText, ctrDos)
               If oRowAux IsNot Nothing Then
                  moDataTable.Rows.Add(oRowAux)
               End If
            Next
            ' ctrAux.Dispose()
            Return Nothing

         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIPanel") Then
            Dim ctrAux As Janus.Windows.UI.Dock.UIPanel = CType(ctrUno, Janus.Windows.UI.Dock.UIPanel)
            For Each ctrDos In ctrAux.Controls
               Dim oRowAux As DataRow = getControl(strFomrName, strFormText, ctrDos)
               If oRowAux IsNot Nothing Then
                  moDataTable.Rows.Add(oRowAux)
               End If
            Next
            ' ctrAux.Dispose()
            Return Nothing

         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIPanelInnerContainer") Then
            Dim ctrAux As Janus.Windows.UI.Dock.UIPanelInnerContainer = CType(ctrUno, Janus.Windows.UI.Dock.UIPanelInnerContainer)
            For Each ctrDos In ctrAux.Controls
               Dim oRowAux As DataRow = getControl(strFomrName, strFormText, ctrDos)
               If oRowAux IsNot Nothing Then
                  moDataTable.Rows.Add(oRowAux)
               End If
            Next
            ' ctrAux.Dispose()
            Return Nothing

         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIReBar") Then
            Dim ctrDos As Janus.Windows.UI.CommandBars.UICommand
            For Each ctrDos In ctrUno.CommandManager.Commands
               moDataTable.Rows.Add(GetRowControl(strFomrName, strFormText, ctrDos.Key, ctrDos.Text, "Menu"))
            Next
            ' ctrDos.Dispose()
            Return Nothing

         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UITab") Then
            Dim ctrAux As Janus.Windows.UI.Tab.UITab = CType(ctrUno, Janus.Windows.UI.Tab.UITab)
            For Each ctrDos In ctrAux.TabPages
               Dim oRowAux As DataRow = getControl(strFomrName, strFormText, ctrDos)
               If oRowAux IsNot Nothing Then
                  moDataTable.Rows.Add(oRowAux)
               End If
            Next
            ' ctrAux.Dispose()
            Return Nothing

         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UITabPage") Then
            Dim ctrAux As Janus.Windows.UI.Tab.UITabPage = CType(ctrUno, Janus.Windows.UI.Tab.UITabPage)
            For Each ctrDos In ctrAux.Controls
               Dim oRowAux As DataRow = getControl(strFomrName, strFormText, ctrDos)
               If oRowAux IsNot Nothing Then
                  moDataTable.Rows.Add(oRowAux)
               End If
            Next
            ' ctrAux.Dispose()
            Return Nothing

         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIGroupBox") Then
            'Dim ctrAux As Janus.Windows.UI.Tab.UITabPage = CType(ctrUno, Janus.Windows.UI.Tab.UITabPage)
            For Each ctrDos In ctrUno.Controls
               Dim oRowAux As DataRow = getControl(strFomrName, strFormText, ctrDos)
               If oRowAux IsNot Nothing Then
                  moDataTable.Rows.Add(oRowAux)
               End If
            Next

            Return Nothing

         End If

         Return Nothing
      Catch exp As Exception
         Throw exp

      Finally

      End Try
   End Function


   Private Sub moDataSetInit(ByVal lngTipoLoad As Long)
      moDataSet = New DataSet("Tablas")
      moDataTable = moDataSet.Tables.Add("Forms")

      If lngTipoLoad = 1 Then
         moDataTable.Columns.Add("Sel", Type.GetType("System.Boolean"))
         moDataTable.Columns.Add("FormFis", Type.GetType("System.String"))
         moDataTable.Columns.Add("FormLog", Type.GetType("System.String"))
         moDataTable.Columns.Add("FormDes", Type.GetType("System.String"))
         moDataTable.Columns.Add("Estado", Type.GetType("System.String"))


      Else
         moDataTable.Columns.Add("Sel", Type.GetType("System.Boolean"))
         moDataTable.Columns.Add("FormId", Type.GetType("System.Int64"))
         moDataTable.Columns.Add("FormLog", Type.GetType("System.String"))
         moDataTable.Columns.Add("FormDes", Type.GetType("System.String"))
         moDataTable.Columns.Add("ControlName", Type.GetType("System.String"))
         moDataTable.Columns.Add("ControlDes", Type.GetType("System.String"))
         moDataTable.Columns.Add("ControlTipo", Type.GetType("System.String"))
         moDataTable.Columns.Add("Estado", Type.GetType("System.String"))

      End If
   End Sub

   Private Function GetRow(ByVal strFormLog As String, ByVal strFormDes As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("Sel") = False
      oRow("FormFis") = strFormLog & ".vb"
      oRow("FormLog") = strFormLog
      oRow("FormDes") = strFormDes
      oRow("Estado") = "New"

      If (moForms.ContainsKey(strFormLog)) Then
         If moForms(strFormLog) > 0 Then
            oRow("Sel") = True
            oRow("Estado") = "Show"
         ElseIf moForms(strFormLog) = -1 Then
            oRow("Sel") = True
            oRow("Estado") = "Dupl"
         End If


      End If

      Return oRow
   End Function

   Private Function GetRowControl(ByVal strFormLog As String, ByVal strFormDes As String, ByVal strControlName As String, ByVal strControlDes As String, ByVal strControlTipo As String) As DataRow
      Dim oRow As DataRow
      oRow = moDataTable.NewRow

      oRow("Sel") = False
      oRow("FormId") = 0
      If moForms.Count > 0 And moForms.ContainsKey(strFormLog) Then
         oRow("FormId") = moForms(strFormLog)
      End If

      oRow("FormLog") = strFormLog
      oRow("FormDes") = strFormDes
      oRow("ControlName") = strControlName

      If (strControlDes.Length > 0) Then
         oRow("ControlDes") = strControlDes
      Else
         oRow("ControlDes") = strControlName
      End If

      oRow("ControlTipo") = strControlTipo
      oRow("Estado") = "New"

      Dim strKey As String = ToStr(oRow("FormId")) & strControlName
      If (moControls.Count > 0 And moControls.ContainsKey(strKey)) Then
         If (moControls(strKey) > 0) Then
            oRow("Sel") = True
            oRow("Estado") = "Show"
         ElseIf moControls(strKey) = -1 Then
            oRow("Sel") = True
            oRow("Estado") = "Dupl"
         End If
      End If

      Return oRow
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
      'Dim rpt As New rptComp

      'rpt.DataSource = GetDataView(moComp.DataSet.Tables(moComp.TableName))

      'rpt.lblTitle.Text = "Listado de Comprobantes"
      'rpt.Document.Name = "Listado de Comprobantes"
      'rpt.lblCompany.Text = clsAppInfo.EmpresaGral
      'rpt.lblDate.Text = "Fecha: " + Format(Now(), "Long Date")
      'rpt.lblTime.Text = "Hora: " + Format(Now(), "Long Time")
      'rpt.lblLogin.Text = "Usuario: " + clsAppInfo.LoginId

      'Call ForcePageSize(rpt.Document.Printer, rpt.PageSettings, clsAppInfo.TipoHojaId)

      'rpt.Run(True)
      'Dim frm As New frmReportPreview(rpt.Document)
      'frm.Show()
   End Sub

   Private Sub grdMainFindRow(ByVal lngID As Long)
      Dim oCol As Janus.Windows.GridEX.GridEXColumn = Nothing

      oCol = grdMain.RootTable.Columns("CompId")

      grdMain.FindAll(oCol, Janus.Windows.GridEX.ConditionOperator.Equal, lngID)
   End Sub

   Private Sub FormInit()
      Call FormCenterChild(Me)

      moBoolCheck = True
      
   End Sub

   Private Sub grdMainInit(ByVal lngTipoLoad As Long)
      With grdMain

         .RootTable.Columns("Sel").Width = 200
         .RootTable.Columns("Sel").Width = 100
         .RootTable.Columns("Sel").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         .RootTable.Columns("Sel").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         If lngTipoLoad = 1 Then
            ebrMain.Groups(0).Text = "Formularios"

            '.RootTable.Columns("Sel").ActAsSelector = moBoolCheck

            .RootTable.Columns("FormFis").Caption = "Archivo Físico"
            .RootTable.Columns("FormFis").Width = 200
            .RootTable.Columns("FormFis").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("FormFis").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("FormLog").Caption = "Nombre Lógico"
            .RootTable.Columns("FormLog").Width = 200
            .RootTable.Columns("FormLog").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("FormLog").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("FormDes").Caption = "Descripción Formulario"
            .RootTable.Columns("FormDes").Width = 300
            .RootTable.Columns("FormDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("FormDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

         Else
            ebrMain.Groups(0).Text = "Controles"

            .RootTable.Columns("FormId").Visible = False

            .RootTable.Columns("FormLog").Caption = "Nombre Lógico"
            .RootTable.Columns("FormLog").Width = 200
            .RootTable.Columns("FormLog").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("FormLog").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("FormDes").Caption = "Descripción Formulario"
            .RootTable.Columns("FormDes").Width = 300
            .RootTable.Columns("FormDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("FormDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ControlName").Caption = "Nombre"
            .RootTable.Columns("ControlName").Width = 200
            .RootTable.Columns("ControlName").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ControlName").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center

            .RootTable.Columns("ControlDes").Caption = "Descripción"
            .RootTable.Columns("ControlDes").Width = 300
            .RootTable.Columns("ControlDes").CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .RootTable.Columns("ControlDes").HeaderStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
         End If

         .RootTable.Columns("Estado").Visible = False
         Call AddConditionalFormatting()
      End With
   End Sub

   Private Sub AddConditionalFormatting()
      Dim fc As Janus.Windows.GridEX.GridEXFormatCondition

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Estado"), Janus.Windows.GridEX.ConditionOperator.NotEqual, "New")
      fc.FormatStyle.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0FFC0)
      grdMain.RootTable.FormatConditions.Add(fc)

      fc = New Janus.Windows.GridEX.GridEXFormatCondition(grdMain.RootTable.Columns("Estado"), Janus.Windows.GridEX.ConditionOperator.Equal, "Dupl")
      fc.FormatStyle.BackColor = System.Drawing.ColorTranslator.FromOle(&HC6DDFF) 'verede&HC0FFC0) 'Amerillo calro:&HBAFFFF) 'Verde light:&HAAFFC9)
      grdMain.RootTable.FormatConditions.Add(fc)

   End Sub

   Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
      If e.Control And e.KeyCode = Keys.C Then
         If Not grdMain.CurrentColumn Is Nothing Then
            Clipboard.SetDataObject(grdMain.GetRow.Cells(grdMain.CurrentColumn).Text)
         End If
      End If
   End Sub

   Private Sub frmDataSecurityImport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmDataSecurityImport_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

#Region "Save Controles"

   Private Function DataSave() As Boolean
      Try
         If (mintTipoLista = 1) Then
            For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows

               If ToStr(oRow.Cells("Estado").Value) = "New" Then

                  DataSave = FormAdd(ToStr(oRow.Cells("FormFis").Value), ToStr(oRow.Cells("FormLog").Value), ToStr(oRow.Cells("FormDes").Value))
                  oRow.BeginEdit()
                  oRow.Cells("Estado").Value = "Show"
                  oRow.EndEdit()

               End If
            Next

            If DataSave Then
               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.NUEVO, "Lista de Formularios guardado con éxito")
            End If

            MessageBox.Show("Lista de Formularios guardado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.None)

         ElseIf (mintTipoLista = 2) Then

            If (moForms.Count > 0) Then
               For Each oRow As Janus.Windows.GridEX.GridEXRow In grdMain.GetRows

                  If CBool(oRow.Cells("Sel").Value) And ToStr(oRow.Cells("Estado").Value) = "New" And ToLong(oRow.Cells("FormId").Value) > 0 Then

                     DataSave = CtrlAdd(ToLong(oRow.Cells("FormId").Value), ToStr(oRow.Cells("ControlName").Value), ToStr(oRow.Cells("ControlDes").Value), ToStr(oRow.Cells("ControlTipo").Value))
                     oRow.BeginEdit()
                     oRow.Cells("Estado").Value = "Show"
                     oRow.EndEdit()

                  End If
               Next

               If DataSave Then
                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.NUEVO, "Lista de Controles guardado con éxito")
               End If

               MessageBox.Show("Lista de Controles guardado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.None)

            Else
               MessageBox.Show("Registrar 1ro Formularios antes de guardar los controles")
            End If

         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False
      End Try

   End Function

   Private Function FormAdd(ByVal lngOrden As String, ByVal strFormName As String, ByVal strFormText As String) As Boolean
      Dim oTipoForm As New clsForm(clsAppInfo.ConnectString)

      FormAdd = False

      Try
         With oTipoForm
            .FormFile = lngOrden
            .FormName = strFormName
            .FormText = strFormText
            .AppId = clsAppInfo.AppId

            If .Insert() Then
               FormAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoForm.Dispose()

      End Try
   End Function

   Private Function CtrlAdd(ByVal lngFormId As Long, ByVal strCtrlName As String, ByVal strCtrlText As String, ByVal strCtrlType As String) As Boolean
      Dim oTipoControl As New clsCtrl(clsAppInfo.ConnectString)

      CtrlAdd = False

      Try
         With oTipoControl

            .FormId = lngFormId
            .CtrlName = strCtrlName
            If (strCtrlText.Length > 100) Then
               .CtrlText = strCtrlText.Substring(0, 99)
            Else
               .CtrlText = strCtrlText
            End If

            .CtrlType = strCtrlType

            .AppId = clsAppInfo.AppId

            If .Insert() Then
               CtrlAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoControl.Dispose()

      End Try
   End Function

   Private Function FormUpdate(ByVal lngOrden As String, ByVal strFormName As String, ByVal strFormText As String) As Boolean
      Dim oTipoForm As New clsForm(clsAppInfo.ConnectString)

      FormUpdate = False

      Try
         With oTipoForm
            .FormFile = lngOrden
            .FormName = strFormName
            .FormText = strFormText
            .AppId = clsAppInfo.AppId

            If .Update() Then
               FormUpdate = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoForm.Dispose()

      End Try
   End Function

   Private Sub ListFormLoad()
      Dim oForm As clsForm = New clsForm(clsAppInfo.ConnectString)
      Dim strFormName As String = ""
      Dim bool As Boolean = False
      Try
         With oForm
            .SelectFilter = clsForm.SelectFilters.ListBox
            .WhereFilter = clsForm.WhereFilters.AppId
            .AppId = clsAppInfo.AppId

            moForms = New Dictionary(Of String, Long)

            If .Open Then

               For Each oRow In .DataSet.Tables(.TableName).Rows
                  Dim strKey As String = ToStr(oRow("FormName"))
                  If Not (moForms.ContainsKey(strKey)) Then
                     moForms.Add(strKey, ToLong(oRow("FormId")))
                  Else
                     moForms.Remove(strKey)
                     moForms.Add(strKey, -1)
                     bool = True
                  End If

               Next
               If bool And .DataSet.Tables(.TableName).Rows.Count > 0 Then
                  MessageBox.Show("Formulario(s) Duplicado(s) en la BD ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oForm.Dispose()

      End Try
   End Sub

   Private Sub ListControlLoad()
      Dim oControl As clsCtrl = New clsCtrl(clsAppInfo.ConnectString)
      Dim bool As Boolean = False

      Try
         With oControl
            .SelectFilter = clsCtrl.SelectFilters.All
            .WhereFilter = clsCtrl.WhereFilters.AppId
            .AppId = clsAppInfo.AppId

            moControls = New Dictionary(Of String, Long)

            If .Open Then
               For Each oRow In .DataSet.Tables(.TableName).Rows
                  Dim strKey As String = ToStr(oRow("FormId")) & ToStr(oRow("CtrlName"))
                  If Not (moControls.ContainsKey(strKey)) Then
                     moControls.Add(strKey, ToLong(oRow("CtrlId")))
                  Else
                     moControls.Remove(strKey)
                     moControls.Add(strKey, -1)
                     bool = True
                  End If

               Next
            End If

            If bool And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               MessageBox.Show("Control(es) Duplicado(s) en la BD ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oControl.Dispose()

      End Try
   End Sub

#End Region

End Class
