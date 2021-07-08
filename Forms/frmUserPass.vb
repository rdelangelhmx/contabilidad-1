Public Class frmUserPass
   Inherits System.Windows.Forms.Form

   Private moUser As clsUser
   Private mlngUserId As Long
   Private mstrLoginId As String

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

   WriteOnly Property DataObject() As clsUser
      Set(ByVal Value As clsUser)
         moUser = Value
      End Set
   End Property

   Property UserId() As Long
      Get
         Return mlngUserId
      End Get

      Set(ByVal Value As Long)
         mlngUserId = Value
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
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
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
   Friend WithEvents txtUserId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtPass As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPassNew As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtPassNewConf As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserPass))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtPassNewConf = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtPassNew = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtPass = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtUserId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label14 = New System.Windows.Forms.Label
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 125)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtPassNewConf)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.txtPassNew)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.txtPass)
      Me.grpMain.Controls.Add(Me.txtUserId)
      Me.grpMain.Controls.Add(Me.Label10)
      Me.grpMain.Controls.Add(Me.Label14)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 116)
      Me.grpMain.TabIndex = 160
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtPassNewConf
      '
      Me.txtPassNewConf.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPassNewConf.Location = New System.Drawing.Point(132, 88)
      Me.txtPassNewConf.MaxLength = 50
      Me.txtPassNewConf.Name = "txtPassNewConf"
      Me.txtPassNewConf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPassNewConf.Size = New System.Drawing.Size(124, 20)
      Me.txtPassNewConf.TabIndex = 3
      Me.txtPassNewConf.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPassNewConf.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 92)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(120, 16)
      Me.Label2.TabIndex = 192
      Me.Label2.Text = "Confirmar Contraseña"
      '
      'txtPassNew
      '
      Me.txtPassNew.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPassNew.Location = New System.Drawing.Point(132, 64)
      Me.txtPassNew.MaxLength = 50
      Me.txtPassNew.Name = "txtPassNew"
      Me.txtPassNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPassNew.Size = New System.Drawing.Size(124, 20)
      Me.txtPassNew.TabIndex = 2
      Me.txtPassNew.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPassNew.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 68)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(120, 16)
      Me.Label1.TabIndex = 190
      Me.Label1.Text = "Contraseña Nueva"
      '
      'txtPass
      '
      Me.txtPass.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPass.Location = New System.Drawing.Point(132, 40)
      Me.txtPass.MaxLength = 50
      Me.txtPass.Name = "txtPass"
      Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPass.Size = New System.Drawing.Size(124, 20)
      Me.txtPass.TabIndex = 1
      Me.txtPass.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtUserId
      '
      Me.txtUserId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtUserId.Location = New System.Drawing.Point(132, 16)
      Me.txtUserId.Name = "txtUserId"
      Me.txtUserId.ReadOnly = True
      Me.txtUserId.Size = New System.Drawing.Size(304, 20)
      Me.txtUserId.TabIndex = 0
      Me.txtUserId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtUserId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 20)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(120, 16)
      Me.Label10.TabIndex = 188
      Me.Label10.Text = "Usuario"
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(8, 44)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(120, 16)
      Me.Label14.TabIndex = 185
      Me.Label14.Text = "Contraseña Actual"
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
      Me.cdmMain.Id = New System.Guid("feeb061d-8c44-493e-b717-3618014c7169")
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
      'frmUserPass
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 153)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmUserPass"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Contraseña de Usuario"
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
            If UserTableCheck() Then
               If PassNewCheck() Then
                  mboolAdding = False
                  mboolEditing = True

                  If DataSave() Then
                     mlngID = moUser.UserId
                     mboolChanged = True

                     '*BITACORA CAMBIAR
                     Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.CAMBIAR_PASSWORD, " Se cambio la Contraseña correctamente para el Usuario " & mstrLoginId & " : " & txtUserId.Text)
                     MessageBox.Show("Se Cambio la Contraseña con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     Me.Close()
                  End If
               End If
            Else
               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.CAMBIAR_PASSWORD, " Contraseña Actual Inválida para el Usuario " & mstrLoginId & " : " & txtUserId.Text)
               MessageBox.Show("Contraseña Actual Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmUserEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmUserEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call FormShow()
      Call ClearMemory()

      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moUser
         Call txtUserIdLoad(mlngUserId)
         txtPass.Text = String.Empty
         txtPassNew.Text = String.Empty
         txtPassNewConf.Text = String.Empty

         txtPass.Select()
      End With
      mboolShow = False
   End Sub

   Private Sub DataMove()
      With moUser
         .Pass = EncryptPWD(txtPassNew.Text)
      End With
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

         If moUser.Insert() Then
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

         moUser.UpdateFilter = clsUser.UpdateFilters.Pass

         If moUser.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      moUser = New clsUser(clsAppInfo.ConnectString)
   End Sub

   Public Function PassNewCheck() As Boolean
      PassNewCheck = False

      If ToStr(txtPassNew.Text) = ToStr(txtPassNewConf.Text) Then
         If ComplexPassword(ToStr(txtPassNew.Text)) Then
            PassNewCheck = True
         Else
            MessageBox.Show("Complejidad de contraseña Inválida" & vbCrLf & vbCrLf & ComplexPassError(), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Contraseñas Nuevas Diferentes", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Public Function UserTableCheck() As Boolean
      With moUser
         .UserId = mlngUserId

         If .FindByPK Then
            If .Pass = EncryptPWD(ToStr(txtPass.Text)) Then
               UserTableCheck = True
            Else
               UserTableCheck = False
            End If
         End If
      End With
   End Function

   Public Function ComplexPassError() As String
      Dim strError As String = String.Empty

      If clsAppInfo.MinLength > 0 Then strError &= "Longitud Mínima de la Contraseña : " & ToStr(clsAppInfo.MinLength) & vbCrLf
      If clsAppInfo.NumUpper > 0 Then strError &= "Cantidad Mínima de la Mayúsculas : " & ToStr(clsAppInfo.NumUpper) & vbCrLf
      If clsAppInfo.NumLower > 0 Then strError &= "Cantidad Mínima de Minúsculas : " & ToStr(clsAppInfo.NumLower) & vbCrLf
      If clsAppInfo.NumNumbers > 0 Then strError &= "Cantidad Mínima de Números : " & ToStr(clsAppInfo.NumNumbers) & vbCrLf
      If clsAppInfo.NumSpecial > 0 Then strError &= "Cantidad Mínima de Caracteres Especiales : " & ToStr(clsAppInfo.NumSpecial) & vbCrLf

      Return strError
   End Function

   Private Sub txtUserIdLoad(ByVal lngUserId As Long)
      Dim oUser As New clsUser(clsAppInfo.ConnectString)

      Try
         With oUser
            .UserId = lngUserId

            If .FindByPK Then
               txtUserId.Tag = .UserId
               txtUserId.Text = ToStr(.LastName) + ", " + ToStr(.FirstName)

               mstrLoginId = .LoginId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oUser.Dispose()

      End Try
   End Sub

   Private Sub frmUserEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If UserTableCheck() Then
                  If PassNewCheck() Then
                     mboolAdding = False
                     mboolEditing = True

                     If DataSave() Then
                        mlngID = moUser.UserId
                        mboolChanged = True

                        '*BITACORA CAMBIAR
                        Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.CAMBIAR_PASSWORD, " Se cambio la Contraseña correctamente para el Usuario " & mstrLoginId & " : " & txtUserId.Text)
                        MessageBox.Show("Se Cambio la Contraseña con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Close()
                     End If
                  End If
               Else
                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.CAMBIAR_PASSWORD, " Contraseña Actual Inválida para el Usuario " & mstrLoginId & " : " & txtUserId.Text)
                  MessageBox.Show("Contraseña Actual Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmUserEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moUser.Dispose()
      Call ClearMemory()
   End Sub

End Class
