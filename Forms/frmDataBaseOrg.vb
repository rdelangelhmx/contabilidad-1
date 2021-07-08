Public Class frmDataBaseOrg
   Inherits System.Windows.Forms.Form

   Private mstrDataBaseOrg As String
   Private mstrConnectStringOrg As String

   Private mboolShow As Boolean
   Private mboolChanged As Boolean

   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents cboDataBase As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtServer As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtUser As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Connet1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Sel1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Connet As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Sel As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents txtPass As Janus.Windows.GridEX.EditControls.EditBox

   ReadOnly Property ConnectStringOrg() As String
      Get
         Return mstrConnectStringOrg
      End Get
   End Property

   ReadOnly Property DataBaseOrg() As String
      Get
         Return mstrDataBaseOrg
      End Get
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
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
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents ToolBar As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataBaseOrg))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtPass = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtUser = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtServer = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.cboDataBase = New Janus.Windows.EditControls.UIComboBox
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ToolBar = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Connet1 = New Janus.Windows.UI.CommandBars.UICommand("Connect")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Sel1 = New Janus.Windows.UI.CommandBars.UICommand("Sel")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Connet = New Janus.Windows.UI.CommandBars.UICommand("Connect")
      Me.Sel = New Janus.Windows.UI.CommandBars.UICommand("Sel")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.bcgMain.Size = New System.Drawing.Size(460, 124)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtPass)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtUser)
      Me.grpMain.Controls.Add(Me.txtServer)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.cboDataBase)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 116)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtPass
      '
      Me.txtPass.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPass.Location = New System.Drawing.Point(116, 64)
      Me.txtPass.MaxLength = 100
      Me.txtPass.Name = "txtPass"
      Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPass.Size = New System.Drawing.Size(124, 20)
      Me.txtPass.TabIndex = 3
      Me.txtPass.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 92)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 195
      Me.Label3.Text = "Base de Datos"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 68)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 194
      Me.Label2.Text = "Contraseña"
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 193
      Me.Label1.Text = "Usuario"
      '
      'txtUser
      '
      Me.txtUser.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtUser.Location = New System.Drawing.Point(116, 40)
      Me.txtUser.MaxLength = 50
      Me.txtUser.Name = "txtUser"
      Me.txtUser.Size = New System.Drawing.Size(124, 20)
      Me.txtUser.TabIndex = 2
      Me.txtUser.Text = "sa"
      Me.txtUser.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtUser.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtServer
      '
      Me.txtServer.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtServer.Location = New System.Drawing.Point(116, 16)
      Me.txtServer.MaxLength = 100
      Me.txtServer.Name = "txtServer"
      Me.txtServer.Size = New System.Drawing.Size(320, 20)
      Me.txtServer.TabIndex = 1
      Me.txtServer.Text = "(local)"
      Me.txtServer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtServer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 20)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(104, 16)
      Me.Label10.TabIndex = 189
      Me.Label10.Text = "Servidor"
      '
      'cboDataBase
      '
      Me.cboDataBase.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboDataBase.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDataBase.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboDataBase.Location = New System.Drawing.Point(116, 88)
      Me.cboDataBase.Name = "cboDataBase"
      Me.cboDataBase.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboDataBase.Size = New System.Drawing.Size(320, 20)
      Me.cboDataBase.TabIndex = 4
      Me.cboDataBase.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.ToolBar})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Exit2, Me.Connet, Me.Sel})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("07079e7f-00da-4c19-a723-59e48c61dabb")
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
      'ToolBar
      '
      Me.ToolBar.CommandManager = Me.cdmMain
      Me.ToolBar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Connet1, Me.Separator1, Me.Sel1, Me.Separator2, Me.Exit1})
      Me.ToolBar.Key = "CommandBar1"
      Me.ToolBar.Location = New System.Drawing.Point(0, 0)
      Me.ToolBar.Name = "ToolBar"
      Me.ToolBar.RowIndex = 0
      Me.ToolBar.Size = New System.Drawing.Size(256, 28)
      Me.ToolBar.Text = "CommandBar1"
      '
      'Connet1
      '
      Me.Connet1.Key = "Connect"
      Me.Connet1.Name = "Connet1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Sel1
      '
      Me.Sel1.Key = "Sel"
      Me.Sel1.Name = "Sel1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 2
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'Connet
      '
      Me.Connet.ImageIndex = 0
      Me.Connet.Key = "Connect"
      Me.Connet.Name = "Connet"
      Me.Connet.Text = "Conectar"
      '
      'Sel
      '
      Me.Sel.ImageIndex = 1
      Me.Sel.Key = "Sel"
      Me.Sel.Name = "Sel"
      Me.Sel.Text = "Seleccionar"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "Database (Add).ico")
      Me.ilsMain.Images.SetKeyName(1, "Check.ico")
      Me.ilsMain.Images.SetKeyName(2, "")
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
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.ToolBar})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.ToolBar)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(460, 28)
      '
      'frmDataBaseOrg
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(460, 152)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Name = "frmDataBaseOrg"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Base de Datos Origen"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
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
         Case "Connect"
            If cboDataBaseLoad(ToStr(txtServer.Text), ToStr(txtUser.Text), ToStr(txtPass.Text)) Then
               cdmMain.Commands.Item("Connect").Enabled = Janus.Windows.UI.InheritableBoolean.False
               cdmMain.Commands.Item("Sel").Enabled = Janus.Windows.UI.InheritableBoolean.True
               cboDataBase.Select()

            Else
               cdmMain.Commands.Item("Sel").Enabled = Janus.Windows.UI.InheritableBoolean.False
            End If

         Case "Sel"
            If DatabaseSelect() Then
               mboolChanged = True
               Me.Close()

            Else
               MessageBox.Show("Seleccione la base datos origen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub DataBaseOrg_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub DataBaseOrg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ClearMemory()

      Me.Cursor = oCursor
   End Sub

   Private Function cboDataBaseLoad(ByVal strServer As String, ByVal strUser As String, ByVal strPass As String) As Boolean
      Dim oItem As clsListItem
      Dim strBaseSys() As String = {"master", "model", "msdb", "tempdb"}
      Dim oDataTable As New DataTable
      Dim strConnectionString As String = "Provider=sqloledb;Data Source=" & strServer & _
                                          ";Initial Catalog=master;User ID=" & strUser & _
                                          ";Password=" & strPass & ";Current Language=us_english"

      Dim strSQL As String = "SELECT dbid, name FROM master.dbo.sysdatabases ORDER BY name"

      cboDataBaseLoad = False
      cboDataBase.Items.Clear()
      cboDataBase.Text = ""

      Try
         Dim oDataAdapter As New Data.OleDb.OleDbDataAdapter(strSQL, strConnectionString)
         oDataAdapter.Fill(oDataTable)

         For i As Integer = 0 To oDataTable.Rows.Count - 1
            If Array.IndexOf(strBaseSys, oDataTable.Rows(i).Item("name").ToString()) = -1 Then
               oItem = New clsListItem(ToLong(oDataTable.Rows(i).Item("dbid")), ToStr(oDataTable.Rows(i).Item("name")))

               cboDataBase.Items.Add(oItem)
               cboDataBaseLoad = True
            End If
         Next
         cboDataBase.SelectedIndex = 0
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem = Nothing

      End Try
   End Function

   Private Function DatabaseSelect() As Boolean
      DatabaseSelect = False

      If cboDataBase.SelectedIndex <> -1 Then
         mstrConnectStringOrg = "Provider=sqloledb;Data Source=" & ToStr(txtServer.Text) & _
                                 ";Initial Catalog=" & ToStr(cboDataBase.Text) & ";User ID=" & ToStr(txtUser.Text) & _
                                 ";Password=" & ToStr(txtPass.Text) & ";Current Language=us_english"

         mstrDataBaseOrg = ToStr(txtServer.Text) & "." & ToStr(cboDataBase.Text)

         DatabaseSelect = True
      End If
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      mboolChanged = False
      txtServer.Text = clsAppInfo.DataBaseSource
      cdmMain.Commands.Item("Sel").Enabled = Janus.Windows.UI.InheritableBoolean.False

   End Sub

   Private Sub DataBaseOrg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DatabaseSelect() Then
               mboolChanged = True
               Me.Close()

            Else
               MessageBox.Show("Seleccione la base datos origen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub DataBaseOrg_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

End Class
