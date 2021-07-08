Public Class frmTipoCambioRangeEdit
   Inherits System.Windows.Forms.Form

   Private moTipoCambio As clsTipoCambio

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents dtpFechaFin As Janus.Windows.CalendarCombo.CalendarCombo
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
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

   WriteOnly Property DataObject() As clsTipoCambio
      Set(ByVal Value As clsTipoCambio)
         moTipoCambio = Value
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
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtValor As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents dtpFechaIni As Janus.Windows.CalendarCombo.CalendarCombo
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipoCambioRangeEdit))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.dtpFechaFin = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.dtpFechaIni = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtValor = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label4 = New System.Windows.Forms.Label
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
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(262, 125)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.UiGroupBox1)
      Me.grpMain.Controls.Add(Me.txtValor)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(244, 116)
      Me.grpMain.TabIndex = 159
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Controls.Add(Me.dtpFechaFin)
      Me.UiGroupBox1.Controls.Add(Me.dtpFechaIni)
      Me.UiGroupBox1.Controls.Add(Me.Label1)
      Me.UiGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox1.Location = New System.Drawing.Point(24, 12)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(200, 68)
      Me.UiGroupBox1.TabIndex = 0
      Me.UiGroupBox1.Text = "Intervalo"
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 20)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(52, 16)
      Me.Label3.TabIndex = 153
      Me.Label3.Text = "Desde"
      '
      'dtpFechaFin
      '
      Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaFin.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaFin.DropDownCalendar.Name = ""
      Me.dtpFechaFin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFechaFin.Location = New System.Drawing.Point(68, 40)
      Me.dtpFechaFin.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaFin.Name = "dtpFechaFin"
      Me.dtpFechaFin.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaFin.TabIndex = 2
      Me.dtpFechaFin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'dtpFechaIni
      '
      Me.dtpFechaIni.CustomFormat = "dd/MM/yyyy"
      Me.dtpFechaIni.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFechaIni.DropDownCalendar.Name = ""
      Me.dtpFechaIni.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFechaIni.Location = New System.Drawing.Point(68, 16)
      Me.dtpFechaIni.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFechaIni.Name = "dtpFechaIni"
      Me.dtpFechaIni.Size = New System.Drawing.Size(124, 20)
      Me.dtpFechaIni.TabIndex = 1
      Me.dtpFechaIni.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 44)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(52, 16)
      Me.Label1.TabIndex = 155
      Me.Label1.Text = "Hasta"
      '
      'txtValor
      '
      Me.txtValor.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtValor.FormatString = "##,##0.000"
      Me.txtValor.Location = New System.Drawing.Point(108, 88)
      Me.txtValor.Name = "txtValor"
      Me.txtValor.Size = New System.Drawing.Size(124, 20)
      Me.txtValor.TabIndex = 1
      Me.txtValor.Text = "0.000"
      Me.txtValor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtValor.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtValor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 92)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(96, 16)
      Me.Label4.TabIndex = 152
      Me.Label4.Text = "Tipo de Cambio"
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
      Me.cdmMain.Id = New System.Guid("b50eb266-db63-4929-957f-70003a512f95")
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
      Me.TopRebar1.Size = New System.Drawing.Size(262, 28)
      '
      'frmTipoCambioRangeEdit
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(262, 153)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmTipoCambioRangeEdit"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Tipo Cambio Edit"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
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
               mlngID = moTipoCambio.TipoCambioId
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmTipoCambioRangeEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmTipoCambioRangeEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.Text = "Consulta Tipo de Cambio"
         Else
            Me.Text = "Editar Tipo de Cambio"
         End If
      Else
         Me.Text = "Nuevo Tipo de Cambio"
         Call FormNew()
      End If

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moTipoCambio
         dtpFechaIni.Text = .Fecha
         txtValor.Text = ToDecStr(.Valor)
      End With
      mboolShow = False
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moTipoCambio
         dtpFechaIni.Value = .Fecha
         dtpFechaIni.Value = .Fecha
         txtValor.Text = String.Empty
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      dtpFechaIni.Enabled = False
      dtpFechaFin.Enabled = False
      txtValor.ReadOnly = True

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moTipoCambio
         .Valor = ToDecimal(txtValor.Text)
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      dtpFechaIni.Select()
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMessage As String = ""

      FormCheck = True

      If dtpFechaIni.Value > dtpFechaFin.Value Then
         strMessage &= "Fecha Desde debe ser menor o igual a Fecha Hasta" & vbCrLf
      End If

      If ToDecimal(txtValor.Text) <= 0 Then
         strMessage &= "Tipo de Cambio Inválido" & vbCrLf
      End If

      If strMessage <> "" Then
         FormCheck = False
         MessageBox.Show(strMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Function DataSave() As Boolean
      Dim datFecha As Date = dtpFechaIni.Value

      Try
         With moTipoCambio
            If FormCheck() Then
               While datFecha <= dtpFechaFin.Value
                  .Fecha = ToDate(datFecha)
                  .WhereFilter = clsTipoCambio.WhereFilters.Fecha

                  If Not .Find() Then
                     .Valor = ToDecimal(txtValor.Text)
                     DataSave = DataAdd()
                  Else
                     .Valor = ToDecimal(txtValor.Text)
                     .Fecha = ToDate(datFecha)
                     DataSave = DataUpdate()
                  End If

                  datFecha = datFecha.AddDays(1)
               End While
            End If

            If DataSave Then
               Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.NUEVO, "Desde: " & dtpFechaIni.Text & "; Hasta: " & dtpFechaFin.Text & "; T.C. " & txtValor.Text)
            End If
         End With
      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moTipoCambio.Insert() Then
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

         If moTipoCambio.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtValor.FormatString = DecimalMask()
   End Sub

   Private Sub ComboLoad()

   End Sub

   Private Sub frmTipoCambioRangeEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moTipoCambio.TipoCambioId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmTipoCambioRangeEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moTipoCambio.Dispose()
      Call ClearMemory()
   End Sub

   Private Function Exist(ByVal strFecha As String, ByRef lngTipoCambioId As Long) As Boolean
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)
      Exist = False
      Try
         With oTipoCambio
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = strFecha

            If .Find Then
               lngTipoCambioId = .TipoCambioId
               Exist = True
            End If
         End With
      Catch ex As Exception
         Throw ex
      Finally
         oTipoCambio.Dispose()
      End Try
   End Function
End Class
