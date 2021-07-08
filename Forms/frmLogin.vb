Public Class frmLogin
   Inherits System.Windows.Forms.Form

   Private moUser As clsUser
   Private mlngNumFailedCount As Long = 0

   Private mboolLoading As Boolean
   Private mboolAceptar As Boolean = False
   Private mlngID As Long

   Private milsList As ImageList

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
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
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents lblAppId As System.Windows.Forms.Label
   Friend WithEvents txtPass As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents btnCancelar As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnAceptar As Janus.Windows.EditControls.UIButton
   Friend WithEvents cboUser As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboUser = New Janus.Windows.EditControls.UIComboBox
      Me.lblAppId = New System.Windows.Forms.Label
      Me.btnCancelar = New Janus.Windows.EditControls.UIButton
      Me.btnAceptar = New Janus.Windows.EditControls.UIButton
      Me.txtPass = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.SuspendLayout()
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 0)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 108)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboUser)
      Me.grpMain.Controls.Add(Me.lblAppId)
      Me.grpMain.Controls.Add(Me.btnCancelar)
      Me.grpMain.Controls.Add(Me.btnAceptar)
      Me.grpMain.Controls.Add(Me.txtPass)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 100)
      Me.grpMain.TabIndex = 159
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboUser
      '
      Me.cboUser.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboUser.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboUser.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboUser.Location = New System.Drawing.Point(80, 16)
      Me.cboUser.Name = "cboUser"
      Me.cboUser.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboUser.Size = New System.Drawing.Size(272, 20)
      Me.cboUser.TabIndex = 0
      Me.cboUser.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblAppId
      '
      Me.lblAppId.BackColor = System.Drawing.Color.Transparent
      Me.lblAppId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblAppId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAppId.Location = New System.Drawing.Point(8, 72)
      Me.lblAppId.Name = "lblAppId"
      Me.lblAppId.Size = New System.Drawing.Size(428, 20)
      Me.lblAppId.TabIndex = 4
      Me.lblAppId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'btnCancelar
      '
      Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCancelar.Location = New System.Drawing.Point(360, 44)
      Me.btnCancelar.Name = "btnCancelar"
      Me.btnCancelar.Size = New System.Drawing.Size(76, 20)
      Me.btnCancelar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnCancelar.TabIndex = 3
      Me.btnCancelar.Text = "Cancelar"
      Me.btnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnAceptar
      '
      Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnAceptar.Location = New System.Drawing.Point(360, 16)
      Me.btnAceptar.Name = "btnAceptar"
      Me.btnAceptar.Size = New System.Drawing.Size(76, 20)
      Me.btnAceptar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnAceptar.TabIndex = 2
      Me.btnAceptar.Text = "Aceptar"
      Me.btnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtPass
      '
      Me.txtPass.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtPass.Location = New System.Drawing.Point(80, 44)
      Me.txtPass.MaxLength = 100
      Me.txtPass.Name = "txtPass"
      Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.txtPass.Size = New System.Drawing.Size(272, 20)
      Me.txtPass.TabIndex = 1
      Me.txtPass.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 20)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(72, 16)
      Me.Label1.TabIndex = 182
      Me.Label1.Text = "Usuario"
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 48)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(72, 16)
      Me.Label3.TabIndex = 181
      Me.Label3.Text = "Contraseña"
      '
      'frmLogin
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 108)
      Me.ControlBox = False
      Me.Controls.Add(Me.bcgMain)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmLogin"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Autentificación"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub frmUserEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmUserEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      AddHandler Me.KeyDown, AddressOf Me.frmUserEdit_KeyDown

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()
      Call ClearMemory()

      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub Autentification()
      If FormCheck() Then
         clsAppInfo.UserId = ListPosition(cboUser, cboUser.SelectedIndex)
         clsAppInfo.Password = Trim$(txtPass.Text)

         If UserTableCheck() Then
            Me.Close()
         End If
      End If
   End Sub

   Private Function FormCheck()
      Dim boolValid As Integer
      boolValid = True

      If ListPosition(cboUser, cboUser.SelectedIndex) = 0 Then
         MessageBox.Show("Nombre de Usuario Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         cboUser.Select()
         boolValid = False
      End If

      FormCheck = boolValid
   End Function

   Public Function UserTableCheck() As Boolean
      Dim oUser As New clsUser(clsAppInfo.ConnectString)

      Try
         With oUser
            .UserId = clsAppInfo.UserId

            If .FindByPK Then
               If .Pass = EncryptPWD(clsAppInfo.Password) Then
                  clsAppInfo.GroupId = .GroupId
                  clsAppInfo.UserName = .LastName & ", " & .FirstName
                  clsAppInfo.LoginId = .LoginId

                  Call StatusLoginDisplay(clsAppInfo.LoginId)
                  Call StatusFormDisplay("")

                  UserTableCheck = True
                  mboolAceptar = True

               Else
                  MessageBox.Show("Contraseña de Usuario Inválida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  '*BITACORA
                  Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INICIO_SESION, "Intento de Inicio de Sesion Fallido Usuario Id. : " + cboUser.Text)

                  UserTableCheck = False

                  If clsAppInfo.NumFailed > 0 Then
                     mlngNumFailedCount += 1

                     If mlngNumFailedCount >= clsAppInfo.NumFailed Then
                        End
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oUser.Dispose()

      End Try
   End Function

   Private Sub ComboLoad()
      Call cboUserLoad()
   End Sub

   Private Sub cboUserLoad()
      Dim oUser As New clsUser(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboUser.Items.Clear()

      Try
         With oUser
            .SelectFilter = clsUser.SelectFilters.All
            .WhereFilter = clsUser.WhereFilters.EstadoId
            .OrderByFilter = clsUser.OrderByFilters.LastName
            .AppId = clsAppInfo.AppId
            .EstadoId = 1
            .UserId = 0

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.UserId, .LastName + ", " + .FirstName)

                  cboUser.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oUser.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      Me.Top = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 80

      moUser = New clsUser(clsAppInfo.ConnectString)

      lblAppId.Tag = ToLong(clsAppInfo.AppId)
      lblAppId.Text = ToStr(clsAppInfo.AppDes)
   End Sub

   Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
      Call Autentification()
   End Sub

   Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
      End
   End Sub

   Private Sub frmUserEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) And Not e.Handled Then
            e.Handled = True
            Call Autentification()

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            e.Handled = True
            End

         ElseIf (e.Alt) And (e.KeyValue = Keys.F4) Then
            e.Handled = True
         End If
      End If
   End Sub

   Private Sub frmUserEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moUser.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      If Not mboolAceptar Then
         e.Cancel = True
      End If
   End Sub
End Class
