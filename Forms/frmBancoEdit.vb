Public Class frmBancoEdit
   Inherits System.Windows.Forms.Form

   Private moBanco As clsBanco

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtBancoCod As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
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

   WriteOnly Property DataObject() As clsBanco
      Set(ByVal Value As clsBanco)
         moBanco = Value
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
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents tbrMain As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents txtBancoId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtBancoDes As Janus.Windows.GridEX.EditControls.EditBox
   Public WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBancoEdit))
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.tbrMain = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtBancoCod = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtBancoDes = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtBancoId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.lblId = New System.Windows.Forms.Label
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.tbrMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.tbrMain})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("a62f8993-ffbc-4290-ba9b-a9c5964d0714")
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
      Me.BottomRebar1.Location = New System.Drawing.Point(0, 152)
      Me.BottomRebar1.Name = "BottomRebar1"
      Me.BottomRebar1.Size = New System.Drawing.Size(462, 0)
      '
      'tbrMain
      '
      Me.tbrMain.CommandManager = Me.cdmMain
      Me.tbrMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Exit1})
      Me.tbrMain.Key = "tbrMain"
      Me.tbrMain.Location = New System.Drawing.Point(0, 0)
      Me.tbrMain.Name = "tbrMain"
      Me.tbrMain.RowIndex = 0
      Me.tbrMain.Size = New System.Drawing.Size(155, 28)
      Me.tbrMain.Text = "tbrMain"
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
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 28)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 124)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(462, 28)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 124)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.tbrMain})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.tbrMain)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(462, 28)
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtBancoCod)
      Me.grpMain.Controls.Add(Me.Label2)
      Me.grpMain.Controls.Add(Me.cboPlan)
      Me.grpMain.Controls.Add(Me.Label9)
      Me.grpMain.Controls.Add(Me.txtBancoDes)
      Me.grpMain.Controls.Add(Me.txtBancoId)
      Me.grpMain.Controls.Add(Me.Label1)
      Me.grpMain.Controls.Add(Me.lblId)
      Me.grpMain.Location = New System.Drawing.Point(8, 28)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 120)
      Me.grpMain.TabIndex = 157
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtBancoCod
      '
      Me.txtBancoCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtBancoCod.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtBancoCod.Location = New System.Drawing.Point(116, 88)
      Me.txtBancoCod.MaxLength = 50
      Me.txtBancoCod.Name = "txtBancoCod"
      Me.txtBancoCod.Size = New System.Drawing.Size(124, 20)
      Me.txtBancoCod.TabIndex = 3
      Me.txtBancoCod.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtBancoCod.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 92)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 16)
      Me.Label2.TabIndex = 174
      Me.Label2.Text = "Código"
      '
      'cboPlan
      '
      cboPlan_DesignTimeLayout.LayoutString = resources.GetString("cboPlan_DesignTimeLayout.LayoutString")
      Me.cboPlan.DesignTimeLayout = cboPlan_DesignTimeLayout
      Me.cboPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlan.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlan.Location = New System.Drawing.Point(116, 64)
      Me.cboPlan.Name = "cboPlan"
      Me.cboPlan.SelectedIndex = -1
      Me.cboPlan.SelectedItem = Nothing
      Me.cboPlan.Size = New System.Drawing.Size(320, 20)
      Me.cboPlan.TabIndex = 2
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 68)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(104, 16)
      Me.Label9.TabIndex = 172
      Me.Label9.Text = "Cuenta Contable"
      '
      'txtBancoDes
      '
      Me.txtBancoDes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtBancoDes.Location = New System.Drawing.Point(116, 40)
      Me.txtBancoDes.MaxLength = 100
      Me.txtBancoDes.Name = "txtBancoDes"
      Me.txtBancoDes.Size = New System.Drawing.Size(320, 20)
      Me.txtBancoDes.TabIndex = 1
      Me.txtBancoDes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtBancoDes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtBancoId
      '
      Me.txtBancoId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtBancoId.Location = New System.Drawing.Point(116, 16)
      Me.txtBancoId.Name = "txtBancoId"
      Me.txtBancoId.ReadOnly = True
      Me.txtBancoId.Size = New System.Drawing.Size(124, 20)
      Me.txtBancoId.TabIndex = 0
      Me.txtBancoId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtBancoId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(104, 16)
      Me.Label1.TabIndex = 169
      Me.Label1.Text = "Banco"
      '
      'lblId
      '
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblId.Location = New System.Drawing.Point(8, 20)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(104, 16)
      Me.lblId.TabIndex = 168
      Me.lblId.Text = "ID"
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(462, 124)
      Me.bcgMain.TabIndex = 158
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'frmBancoEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 152)
      Me.Controls.Add(Me.grpMain)
      Me.Controls.Add(Me.RightRebar1)
      Me.Controls.Add(Me.BottomRebar1)
      Me.Controls.Add(Me.LeftRebar1)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmBancoEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Banco Edit"
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.tbrMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
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
               mlngID = moBanco.BancoId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmBancoEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmBancoEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call ComboLoad()

      If Not mboolAdding Then
         Call FormShow()
         If Not mboolEditing Then
            Call DataReadOnly()
            Me.Text = "Consulta Banco"
         Else
            Me.Text = "Editar Banco"
         End If
      Else
         Me.Text = "Nuevo Banco"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moBanco
         txtBancoId.Text = ToStr(.BancoId)
         txtBancoDes.Text = ToStr(.BancoDes)
         cboPlan.Value = ListFindItem(cboPlan, .PlanId)
         txtBancoCod.Text = ToStr(.BancoCod)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.FormText = "Consulta Banco"
               .VMOld.ToShowOpe()
            End If
         End If

      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsBancoVM)
      oVM = New clsBancoVM

      With oVM
         .BancoId = moBanco.BancoId
         .EmpresaId = moBanco.EmpresaId
         .BancoDes = moBanco.BancoDes
         .BancoCod = moBanco.BancoCod
         .PlanId = moBanco.PlanId
         .PlanDes = cboPlan.Text

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moBanco
         txtBancoId.Text = String.Empty
         txtBancoDes.Text = String.Empty
         cboPlan.Value = Nothing
         txtBancoCod.Text = String.Empty
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtBancoId.ReadOnly = True
      txtBancoDes.ReadOnly = True
      cboPlan.ReadOnly = False
      txtBancoCod.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moBanco
         If Not mboolAdding Then
            .BancoId = ToLong(txtBancoId.Text)
         End If

         .BancoDes = ToStr(txtBancoDes.Text)
         .PlanId = ListPosition(cboPlan)
         .BancoCod = ToStr(txtBancoCod.Text)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      txtBancoDes.Select()
   End Sub

   Private Function FormCheck() As Boolean
      FormCheck = True
      Dim strMessage As String = ""
      Try
         If cboPlan.SelectedIndex > -1 Then
            If ToLong(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("EstadoId").Value) = 0 Then
               strMessage &= "La Cuenta seleccionada " & ToStr(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("PlanCta").Value) & "-" & ToStr(cboPlan.DropDownList.GetRow(cboPlan.SelectedIndex).Cells("PlanDes").Value) & " esta Inactiva." & vbCrLf
            End If
         End If

         If Not String.IsNullOrEmpty(strMessage.Trim) Then
            FormCheck = False
            Throw New Exception(strMessage)
         End If

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If FormCheck() Then
            If mboolAdding Then
               DataSave = DataAdd()
            Else
               DataSave = DataUpdate()
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

         If moBanco.Insert() Then
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

         If moBanco.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)
   End Sub

   Private Sub ComboLoad()
      Call cboPlanLoad()
   End Sub

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.EsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = moBanco.EmpresaId
            .EsAna = 1
            .EstadoId = clsEstado.ACTIVO
            .PlanId = moBanco.PlanId

            If .Open() Then
               With cboPlan
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DropDownList.Columns.Add("EstadoId")
                  .DropDownList.Columns("EstadoId").DataMember = "EstadoId"
                  .DropDownList.Columns("EstadoId").Visible = False

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Sub frmBancoEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moBanco.BancoId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmBancoEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moBanco.Dispose()
      Call ClearMemory()
   End Sub

End Class
