Public Class frmCierreGestionSucCCO
   Inherits System.Windows.Forms.Form

   Private mlngEmpresaId As Long
   Private mlngGestionIdNew As Long
   Private mlngGestionNew As Long

   'Private mdecDebeBs As Decimal
   'Private mdecHaberBs As Decimal
   'Private mdecDebeUs As Decimal
   'Private mdecHaberUs As Decimal

   Private mstrFechaIni As String

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mlngID As Long

   Private moCompDet As clsCompDet
   Private moCompPlanAdd As clsCompPlanAdd

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

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
   Friend WithEvents txtTipoCambio As Janus.Windows.GridEX.EditControls.NumericEditBox
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
   Friend WithEvents cboGestion As Janus.Windows.EditControls.UIComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCierreGestionSucCCO))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboGestion = New Janus.Windows.EditControls.UIComboBox
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
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
      Me.bcgMain.Size = New System.Drawing.Size(262, 77)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboGestion)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(244, 68)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboGestion
      '
      Me.cboGestion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboGestion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboGestion.Location = New System.Drawing.Point(112, 16)
      Me.cboGestion.Name = "cboGestion"
      Me.cboGestion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboGestion.Size = New System.Drawing.Size(124, 20)
      Me.cboGestion.TabIndex = 1
      Me.cboGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(112, 40)
      Me.txtTipoCambio.Name = "txtTipoCambio"
      Me.txtTipoCambio.Size = New System.Drawing.Size(124, 20)
      Me.txtTipoCambio.TabIndex = 2
      Me.txtTipoCambio.Text = "0,000"
      Me.txtTipoCambio.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtTipoCambio.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtTipoCambio.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 20)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(100, 16)
      Me.Label3.TabIndex = 152
      Me.Label3.Text = "Gestión a  Cerrar"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 44)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(100, 16)
      Me.Label4.TabIndex = 151
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
      Me.cdmMain.Id = New System.Guid("5033e457-dd60-4879-8e21-4c01e8889c3c")
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(144, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      Me.Save1.Text = "Cierre"
      Me.Save1.ToolTipText = "Cierre de Gestión"
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
      'frmCierreGestionSucCCO
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(262, 105)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCierreGestionSucCCO"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Cierre de Gestión"
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
            If RealizarCierreGestion() Then
               MessageBox.Show("Cierre de Gestión Realizado Exitosamente, Verifique el Comprobante en la Nueva Gestión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCierreGestionSucCCO_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCierreGestionSucCCO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ComboLoad()
      Call FormShow()
      Call ClearMemory()

      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      mboolShow = True
      cboGestion.SelectedIndex = ListFindItem(cboGestion, clsAppInfo.GestionId)
      Call txtTipoCambioFind(ToDate(Now.Date))
      mboolShow = False
   End Sub

   Private Function RealizarCierreGestion() As Boolean
      Dim lngGestionId As Long

      RealizarCierreGestion = False

      If ListPosition(cboGestion, cboGestion.SelectedIndex) <> 0 Then
         If ToDecimal(txtTipoCambio.Text) > 0 Then 'yovana

            lngGestionId = ListPosition(cboGestion, cboGestion.SelectedIndex)
            mlngGestionIdNew = GestionIdNextFind(GestionFind(lngGestionId), mlngEmpresaId)

            If mlngGestionIdNew > 0 Then
               If CompParaExits(mlngEmpresaId, mlngGestionIdNew) Then
                  If Not GestionMovimiento(mlngGestionIdNew, mlngEmpresaId) Then
                     If MessageBox.Show("Este Proceso Cierra la Gestión Seleccionada e Inicializa una Nueva con los Saldos Actuales" + vbCrLf + vbCrLf + "¿Realmente quiere Cerrar la Gestión?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        mlngGestionNew = GestionFind(mlngGestionIdNew)

                        RealizarCierreGestion = CierreGestion(mlngGestionIdNew)
                     End If

                  Else
                     MessageBox.Show("La Nueva Gestión ya Tiene un Comprobante de Traspaso Nro. 1, Revise por Favor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  End If

               Else
                  MessageBox.Show("No Existen Parámetros Para la Nueva Gestión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               End If

            Else
               MessageBox.Show("No Existe una Gestión Nueva o en Estado Abierto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
         Else
            MessageBox.Show("Tipo de Cambio Inválido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         End If
      Else
         MessageBox.Show("Debe Seleccionar la Gestión a Cerrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Function CierreGestion(ByRef lngGestionIdNew As Long) As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim decTotalBs As Decimal = 0
      Dim decTotalUs As Decimal = 0
      Dim decSaldoBs As Decimal
      Dim decSaldoUs As Decimal
      Dim lngGrupo As Long
      Dim boolCompNew As Boolean = True
      Dim lngCompId As Long
      Dim lngCompDetId As Long
      Dim lngSucursalId As Long
      Dim lngCentroCostoId As Long
      CierreGestion = False

      Try

         Call BitacoraAdd()
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.EsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanCta
            .EmpresaId = mlngEmpresaId
            .EsAna = 1

            mstrFechaIni = GestionFechaIni(lngGestionIdNew)

            If .Open() Then
               Do While .Read()
                  decSaldoBs = 0
                  decSaldoUs = 0
                  lngSucursalId = 0
                  lngCentroCostoId = 0
                  lngGrupo = .TipoGrupoId

                  If PlanSaldoGestionSucCCO(clsAppInfo.GestionId, lngGrupo, .PlanId, .SucCCOId) Then
                     For Each oRow In moCompDet.DataSet.Tables(moCompDet.TableName).Rows
                        If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                           decSaldoBs = (ToDecimal(oRow("DebeBs")) - ToDecimal(oRow("HaberBs")))
                           decSaldoUs = (ToDecimal(oRow("DebeUs")) - ToDecimal(oRow("HaberUs")))

                        ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                           decSaldoBs = (ToDecimal(oRow("HaberBs")) - ToDecimal(oRow("DebeBs")))
                           decSaldoUs = (ToDecimal(oRow("HaberUs")) - ToDecimal(oRow("DebeUs")))
                        End If

                        Dim strDetdes = ""

                        If .SucCCOId = 1 Then
                           lngSucursalId = ToLong(oRow("SucursalId"))
                           strDetdes = "Suc.: " & ToStr(oRow("SucursalDes"))
                        End If
                        If .SucCCOId = 2 Then
                           lngCentroCostoId = ToLong(oRow("CentroCostoId"))
                           strDetdes = "C.C.: " & ToStr(oRow("CentroCostoDes"))
                        End If

                        If (decSaldoBs <> 0) Or (decSaldoUs <> 0) Then
                           If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                              If (decSaldoBs > 0) And (decSaldoUs > 0) Then
                                 If boolCompNew Then
                                    If CompAdd(lngGestionIdNew, lngCompId) Then
                                       boolCompNew = False
                                    End If
                                 End If

                                 If CompDetAdd(lngGestionIdNew, lngCompId, .PlanId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1, lngCompDetId, lngSucursalId, lngCentroCostoId, strDetdes) Then
                                    CierreGestion = True

                                    If ToBoolean(.TieneAnaAdd) Then
                                       If PlanAddNew(lngGestionIdNew, lngCompId, lngCompDetId, .PlanId, lngGrupo, .SucCCOId, If(.SucCCOId = 1, lngSucursalId, lngCentroCostoId)) Then
                                       End If
                                    End If

                                    If lngCentroCostoId <> 0 Then
                                       Call CentroCostoDetNew(lngGestionIdNew, lngCompId, lngCompDetId, .PlanId, lngGrupo, lngCentroCostoId)
                                    End If
                                 End If

                              ElseIf (decSaldoBs < 0) And (decSaldoUs < 0) Then
                                 If boolCompNew Then
                                    If CompAdd(lngGestionIdNew, lngCompId) Then
                                       boolCompNew = False
                                    End If
                                 End If

                                 If CompDetAdd(lngGestionIdNew, lngCompId, .PlanId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2, lngCompDetId, lngSucursalId, lngCentroCostoId, strDetdes) Then
                                    CierreGestion = True

                                    If ToBoolean(.TieneAnaAdd) Then
                                       If PlanAddNew(lngGestionIdNew, lngCompId, lngCompDetId, .PlanId, lngGrupo, .SucCCOId, If(.SucCCOId = 1, lngSucursalId, lngCentroCostoId)) Then
                                       End If
                                    End If

                                    If lngCentroCostoId <> 0 Then
                                       Call CentroCostoDetNew(lngGestionIdNew, lngCompId, lngCompDetId, .PlanId, lngGrupo, lngCentroCostoId)
                                    End If
                                 End If
                              End If

                           ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                              If (decSaldoBs > 0) And (decSaldoUs > 0) Then
                                 If boolCompNew Then
                                    If CompAdd(lngGestionIdNew, lngCompId) Then
                                       boolCompNew = False
                                    End If
                                 End If

                                 If CompDetAdd(lngGestionIdNew, lngCompId, .PlanId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2, lngCompDetId, lngSucursalId, lngCentroCostoId, strDetdes) Then
                                    CierreGestion = True

                                    If ToBoolean(.TieneAnaAdd) Then
                                       If PlanAddNew(lngGestionIdNew, lngCompId, lngCompDetId, .PlanId, lngGrupo, .SucCCOId, If(.SucCCOId = 1, lngSucursalId, lngCentroCostoId)) Then
                                       End If
                                    End If

                                    If lngCentroCostoId <> 0 Then
                                       Call CentroCostoDetNew(lngGestionIdNew, lngCompId, lngCompDetId, .PlanId, lngGrupo, lngCentroCostoId)
                                    End If
                                 End If

                              ElseIf (decSaldoBs < 0) And (decSaldoUs < 0) Then
                                 If boolCompNew Then
                                    If CompAdd(lngGestionIdNew, lngCompId) Then
                                       boolCompNew = False
                                    End If
                                 End If

                                 If CompDetAdd(lngGestionIdNew, lngCompId, .PlanId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1, lngCompDetId, lngSucursalId, lngCentroCostoId, strDetdes) Then
                                    CierreGestion = True

                                    If ToBoolean(.TieneAnaAdd) Then
                                       If PlanAddNew(lngGestionIdNew, lngCompId, lngCompDetId, .PlanId, lngGrupo, .SucCCOId, If(.SucCCOId = 1, lngSucursalId, lngCentroCostoId)) Then
                                       End If
                                    End If

                                    If lngCentroCostoId <> 0 Then
                                       Call CentroCostoDetNew(lngGestionIdNew, lngCompId, lngCompDetId, .PlanId, lngGrupo, lngCentroCostoId)
                                    End If
                                 End If
                              End If
                           End If
                        End If
                     Next
                  End If
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function PlanAddNew(ByVal lngGestionId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngGrupo As Long, ByVal lngSucCCOId As Long, ByVal lngId As Long) As Boolean
      moCompPlanAdd = New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0
      Dim decSaldoUs As Decimal = 0

      Try
         With moCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuentaSucCCO
            .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayorSaldoAnteriorSucCCO
            .GroupByFilter = clsCompPlanAdd.GroupByFilters.LibroMayorSaldoAnteriorSucCCO
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .PlanId = lngPlanId
            .CompDetId = lngSucCCOId
            .CompId = lngId

            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                     decSaldoBs = ToDecimal(oRow("DebeBs") - oRow("HaberBs"))
                     decSaldoUs = ToDecimal(oRow("DebeUs") - oRow("HaberUs"))

                  ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                     decSaldoBs = ToDecimal(oRow("HaberBs") - oRow("DebeBs"))
                     decSaldoUs = ToDecimal(oRow("HaberUs") - oRow("DebeUs"))
                  End If

                  If decSaldoBs <> 0 Then
                     If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                        If decSaldoBs > 0 Then
                           If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, ToLong(oRow("PlanAddId")), Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
                              PlanAddNew = True
                           End If

                        ElseIf decSaldoBs < 0 Then
                           If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, ToLong(oRow("PlanAddId")), Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
                              PlanAddNew = True
                           End If
                        End If

                     ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                        If decSaldoBs > 0 Then
                           If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, ToLong(oRow("PlanAddId")), Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
                              PlanAddNew = True
                           End If

                        ElseIf decSaldoBs < 0 Then
                           If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, ToLong(oRow("PlanAddId")), Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
                              PlanAddNew = True
                           End If
                        End If
                     End If
                  End If
               Next
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   Private Sub CloneVMComp(ByRef oComp As clsComp)
      If clsAppInfo.RegistrarBitacora Then
         With oComp
            .VMNew.TipoCompId = .TipoCompId
            .VMNew.CompNro = .CompNro
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
            .VMNew.TipoAsientoId = .TipoAsientoId
            .VMNew.Glosa = .Glosa
            .VMNew.EstadoId = .EstadoId

            .VMNew.FormName = Me.Name
            .VMNew.FormText = Me.Text
         End With
      End If
   End Sub

   Private Function CompAdd(ByRef lngGestionId As Long, ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = mlngEmpresaId
            .GestionId = lngGestionId
            .TipoCompId = clsTipoComp.TRASPASO
            .CompNro = 0
            .Fecha = mstrFechaIni
            .MonedaId = clsAppInfo.MonedaId
            .TipoCambio = ToDecimal(txtTipoCambio.Text)
            .EntregadoA = "Balance Inicial"
            .PorConcepto = "Gestión : " + ToStr(mlngGestionNew)
            .DebeBs = 0
            .HaberBs = 0
            .DebeUs = 0
            .HaberUs = 0
            .PorIVA = 0
            .PorIT = 0
            .PorITF = 0
            .ConFac = 0
            .SinFac = 1
            .Automatico = 0
            .TipoAsientoId = clsTipoAsiento.APERTURA
            .Glosa = ""
            .EstadoId = clsEstado.PENDIENTE

            Call CloneVMComp(oComp)
            If .Insert() Then
               CompAdd = True
               lngCompId = .CompId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function CompDetAdd(ByRef lngGestionId As Long, ByVal lngCompId As Long, ByVal lngPlanId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, ByRef lngCompDetId As Long, Optional ByVal lngSucursalId As Long = 0, Optional ByVal lngCentroCostoId As Long = 0, Optional ByVal strDetalleDes As String = "") As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = mlngEmpresaId
            .GestionId = lngGestionId
            .TipoCompId = 3
            .Fecha = mstrFechaIni
            .PlanId = lngPlanId
            .CompDetDes = "Saldo Inicial Gestión : " + ToStr(mlngGestionNew) & If(String.IsNullOrEmpty(strDetalleDes), "", " - " & strDetalleDes)
            .SucursalId = lngSucursalId
            .CentroCostoId = lngCentroCostoId
            .MonedaId = clsAppInfo.MonedaId

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorBs
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeBs = 0
                  .DebeUs = 0
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .DebeBs = decValorBs
                  .DebeUs = decValorUs

                  .HaberOrg = 0
                  .HaberBs = 0
                  .HaberUs = 0

               ElseIf lngCol = 2 Then
                  .HaberOrg = decValorUs
                  .HaberBs = decValorBs
                  .HaberUs = decValorUs

                  .DebeOrg = 0
                  .DebeUs = 0
                  .DebeBs = 0
               End If
            End If

            .Orden = 0
            .Automatico = 0
            .EstadoId = 13

            If .Insert() Then
               lngCompDetId = .CompDetId
               CompDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompDet.Dispose()

      End Try
   End Function

   Private Function CompPlanAddAdd(ByVal lngGestionId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, _
                                 ByVal lngPlanAddId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long) As Boolean

      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)

      CompPlanAddAdd = False

      Try
         With oCompPlanAdd
            .EmpresaId = mlngEmpresaId
            .GestionId = lngGestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = mstrFechaIni
            .PlanId = lngPlanId
            .MonedaId = clsAppInfo.MonedaId
            .PlanAddId = lngPlanAddId

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorBs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorUs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If
            End If

            .EstadoId = 13

            If .Insert() Then
               CompPlanAddAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

   Private Function CentroCostoDetNew(ByVal lngGestionId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngGrupo As Long, ByVal mlngCentroCostoId As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0
      Dim decSaldoUs As Decimal = 0
      Dim lngCentroCostoDetId = 0
      Try
         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.LibroMayorCuentaCentroCosto
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.LibroMayorFechaCentroCosto
            .GroupByFilter = clsCompCentroCostoDet.GroupByFilters.LibroMayorFechaCentroCosto
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .PlanId = lngPlanId
            .CentroCostoId = mlngCentroCostoId
            '.Fecha = mstrFechaIni

            If .Open() Then
               Do While .Read()
                  lngCentroCostoDetId = .CentroCostoDetId
                  If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                     decSaldoBs = ToDecimal(.DebeBs - .HaberBs)
                     decSaldoUs = ToDecimal(.DebeUs - .HaberUs)

                  ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                     decSaldoBs = ToDecimal(.HaberBs - .DebeBs)
                     decSaldoUs = ToDecimal(.HaberUs - .DebeUs)
                  End If

                  If decSaldoBs <> 0 Then
                     If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                        If decSaldoBs > 0 Then
                           If CompCentroCostoDetAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, mlngCentroCostoId, lngCentroCostoDetId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
                              CentroCostoDetNew = True
                           End If
                        ElseIf decSaldoBs < 0 Then
                           If CompCentroCostoDetAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, mlngCentroCostoId, lngCentroCostoDetId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
                              CentroCostoDetNew = True
                           End If
                        End If

                     ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                        If decSaldoBs > 0 Then
                           If CompCentroCostoDetAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, mlngCentroCostoId, lngCentroCostoDetId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
                              CentroCostoDetNew = True
                           End If
                        ElseIf decSaldoBs < 0 Then
                           If CompCentroCostoDetAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, mlngCentroCostoId, lngCentroCostoDetId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
                              CentroCostoDetNew = True
                           End If
                        End If
                     End If
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function CompCentroCostoDetAdd(ByVal lngGestionId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngCentroCostoId As Long, _
                              ByVal lngCentroCostoDetId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long) As Boolean

      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompCentroCostoDetAdd = False

      Try
         With oCompCentroCostoDet
            .EmpresaId = mlngEmpresaId
            .GestionId = lngGestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = mstrFechaIni
            .PlanId = lngPlanId
            .MonedaId = clsAppInfo.MonedaId
            .CentroCostoId = lngCentroCostoId
            .CentroCostoDetId = lngCentroCostoDetId

            If .MonedaId = 1 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorBs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorBs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If

            ElseIf .MonedaId = 2 Then
               If lngCol = 1 Then
                  .DebeOrg = decValorUs
                  .HaberOrg = 0
                  .DebeBs = decValorBs
                  .HaberBs = 0
                  .DebeUs = decValorUs
                  .HaberUs = 0
               Else
                  .DebeOrg = 0
                  .HaberOrg = decValorUs
                  .DebeBs = 0
                  .HaberBs = decValorBs
                  .DebeUs = 0
                  .HaberUs = decValorUs
               End If
            End If

            .EstadoId = 13

            If .Insert() Then
               CompCentroCostoDetAdd = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompCentroCostoDet.Dispose()
      End Try
   End Function

   'Private Sub SumaColumnas(ByRef lngGestionId As Long, ByVal lngPlanId As Long)
   '   Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

   '   Try
   '      With oCompDet
   '         .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
   '         .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoGestion
   '         .EmpresaId = mlngEmpresaId
   '         .GestionId = lngGestionId
   '         .PlanId = lngPlanId

   '         If .Open() Then
   '            For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
   '               mdecDebeBs = mdecDebeBs + ToDecimal(oRow("DebeBs"))
   '               mdecHaberBs = mdecHaberBs + ToDecimal(oRow("HaberBs"))

   '               mdecDebeUs = mdecDebeUs + ToDecimal(oRow("DebeUs"))
   '               mdecHaberUs = mdecHaberUs + ToDecimal(oRow("HaberUs"))
   '            Next
   '         End If
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oCompDet.Dispose()

   '   End Try
   'End Sub

   Private Function PlanSaldoGestionSucCCO(ByRef lngGestionId As Long, ByVal lngGrupo As Long, ByVal lngPlanId As Long, ByVal lngSucCCOId As Long) As Boolean
      moCompDet = New clsCompDet(clsAppInfo.ConnectString)
      PlanSaldoGestionSucCCO = False
      Try
         With moCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuentaSucCCO
            .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoActualSucCCO   'LibroMayorSaldoGestion
            .GroupByFilter = clsCompDet.GroupByFilters.LibroMayorCuentaSucCCO
            .EmpresaId = mlngEmpresaId
            .GestionId = lngGestionId
            .PlanId = lngPlanId
            .SucursalId = lngSucCCOId

            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               PlanSaldoGestionSucCCO = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   'Private Function PlanAddSaldoBsGestion(ByRef lngGestionId As Long, ByVal lngPlanId As Long, ByVal lngGrupo As Long) As Decimal
   '   Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)
   '   Dim decSaldoBs As Decimal = 0

   '   decSaldoUs = 0

   '   Try
   '      With oCompDet
   '         .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuenta
   '         .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoGestion
   '         .EmpresaId = mlngEmpresaId
   '         .GestionId = lngGestionId
   '         .PlanId = lngPlanId

   '         If .Open() Then
   '            For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
   '               If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
   '                  decSaldoBs = decSaldoBs + (ToDecimal(oRow("DebeBs")) - ToDecimal(oRow("HaberBs")))
   '                  decSaldoUs = decSaldoUs + (ToDecimal(oRow("DebeUs")) - ToDecimal(oRow("HaberUs")))

   '               ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
   '                  decSaldoBs = decSaldoBs + (ToDecimal(oRow("HaberBs")) - ToDecimal(oRow("DebeBs")))
   '                  decSaldoUs = decSaldoUs + (ToDecimal(oRow("HaberUs")) - ToDecimal(oRow("DebeUs")))
   '               End If
   '            Next

   '            PlanSaldoBsGestion = decSaldoBs
   '         End If
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oCompDet.Dispose()

   '   End Try
   'End Function

   Private Sub txtTipoCambioFind(ByVal strFecha As String)
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      Try
         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = strFecha

            If .Find Then
               txtTipoCambio.Tag = .TipoCambioId
               txtTipoCambio.Text = ToStr(.Valor)
            Else
               txtTipoCambio.Tag = 0
               txtTipoCambio.Text = ""
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub

   Private Function GestionIdNextFind(ByVal lngGestion As Long, ByVal lngEmpresaId As Long) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdNextFind = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.Gestion
            .EmpresaId = lngEmpresaId
            .Gestion = lngGestion + 1
            .EstadoId = 11

            If .Find Then
               GestionIdNextFind = .GestionId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function CompParaExits(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long) As Boolean
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      CompParaExits = False

      Try
         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.GestionId
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .EstadoId = 11

            If .Find Then
               CompParaExits = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Function

   Private Function GestionFechaIni(ByVal GestionId As Long) As String
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = GestionId

            If .FindByPK Then
               GestionFechaIni = ToDate(.DataSet.Tables(.TableName).Rows(0).Item("FechaIni"))
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Function GestionMovimiento(ByVal lngGestionId As Long, ByVal lngEmpresaId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      GestionMovimiento = False

      Try
         With oComp
            .RowCountFilter = clsComp.RowCountFilters.All
            .WhereFilter = clsComp.WhereFilters.CompNro
            .EmpresaId = lngEmpresaId
            .GestionId = lngGestionId
            .TipoCompId = 3
            .CompNro = 1

            If .Find Then
               GestionMovimiento = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Sub ComboLoad()
      Call cboGestionLoad()
   End Sub

   Private Sub cboGestionLoad()
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboGestion.Items.Clear()

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.EmpresaId
            .OrderByFilter = clsGestion.OrderByFilters.Gestion
            .EmpresaId = mlngEmpresaId
            .EstadoId = 11

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.GestionId, .Gestion)

                  cboGestion.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      txtTipoCambio.FormatString = DecimalMask()
   End Sub

   Private Sub frmCierreGestionSucCCO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If RealizarCierreGestion() Then
                  MessageBox.Show("El Cierre de Gestión se Realizo Exitosamente, Verifique el Comprobante en la Nueva Gestión", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                  Me.Close()
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCierreGestionSucCCO_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

   Private Function MonedaDesFind(ByVal lngmonedaid As Long) As String
      Dim omoneda As New clsMoneda(clsAppInfo.ConnectString)

      Try
         With omoneda
            .MonedaId = lngmonedaid

            If .FindByPK Then
               MonedaDesFind = .MonedaDes
            End If
         End With
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function TipoCompDesFind(ByVal lngTipoCompid As Long) As String
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)

      Try
         With oTipoComp
            .TipoCompId = lngTipoCompid

            If .FindByPK Then
               TipoCompDesFind = .TipoCompDes
            End If
         End With
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function EstadoDesFind(ByVal lngEstadoid As Long) As String
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)

      Try
         With oEstado
            .EstadoId = lngEstadoid

            If .FindByPK Then
               EstadoDesFind = .EstadoDes
            End If
         End With
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function GestionFind(ByVal lngGestionId As Long) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               GestionFind = .Gestion
            End If
         End With
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Sub BitacoraAdd()
      '* BITACORA CIERRE GESTION.
      Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.CIERRE_GESTION, "Gestion a: " & cboGestion.Text & "; Tipo de Cambio: " & txtTipoCambio.Text)
   End Sub
End Class
