Public Class frmCierreCuentaSucCCO
   Inherits System.Windows.Forms.Form

   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngPlanResId As Long

   Private mdecDebeBs As Decimal
   Private mdecHaberBs As Decimal
   Private mdecDebeUs As Decimal
   Private mdecHaberUs As Decimal

   Private mstrFechaFin As String

   Private mlngCentroCostoId As Long
   Private mlngSucursalId As Long
   Private mlngCentroCostoDetId As Long
   Private moCompDet As clsCompDet
   Private moCompPlanAdd As clsCompPlanAdd
   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents cboPlan As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Private mlngID As Long

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
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents dtpFecha As Janus.Windows.CalendarCombo.CalendarCombo
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
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim cboPlan_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCierreCuentaSucCCO))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.cboPlan = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.dtpFecha = New Janus.Windows.CalendarCombo.CalendarCombo
      Me.txtTipoCambio = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
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
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.bcgMain.Size = New System.Drawing.Size(462, 102)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.cboPlan)
      Me.grpMain.Controls.Add(Me.dtpFecha)
      Me.grpMain.Controls.Add(Me.txtTipoCambio)
      Me.grpMain.Controls.Add(Me.Label3)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.Label5)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(444, 92)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
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
      Me.cboPlan.TabIndex = 3
      Me.cboPlan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'dtpFecha
      '
      Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
      Me.dtpFecha.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom
      '
      '
      '
      Me.dtpFecha.DropDownCalendar.Name = ""
      Me.dtpFecha.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      Me.dtpFecha.Location = New System.Drawing.Point(116, 16)
      Me.dtpFecha.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(124, 20)
      Me.dtpFecha.TabIndex = 1
      Me.dtpFecha.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
      '
      'txtTipoCambio
      '
      Me.txtTipoCambio.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtTipoCambio.FormatString = "##,##0.000"
      Me.txtTipoCambio.Location = New System.Drawing.Point(116, 40)
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
      Me.Label3.Size = New System.Drawing.Size(104, 16)
      Me.Label3.TabIndex = 153
      Me.Label3.Text = "Fecha de Cierre"
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 44)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 152
      Me.Label4.Text = "Tipo de Cambio"
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 68)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(104, 16)
      Me.Label5.TabIndex = 151
      Me.Label5.Text = "Contracuenta"
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
      Me.cdmMain.Id = New System.Guid("dc495a77-0324-4b3c-a7d4-8e1d12688be7")
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
      Me.Save1.ToolTipText = "Cierre Cuentas de Resultado"
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
      'frmCierreCuentaSucCCO
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(462, 130)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmCierreCuentaSucCCO"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Cierre Cuentas de Resultado"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.cboPlan, System.ComponentModel.ISupportInitialize).EndInit()
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
            If FormCheck() Then
               If MessageBox.Show("¿Realmente quiere Realizar el Cierre de Cuentas de Resultado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  If CierreCuenta() Then
                     If frmCompEditLoad(mlngCompId) Then
                        MessageBox.Show("Cierre de Cuentas de Resultado Realizado Exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     Else
                        MessageBox.Show("El Comprobante debe Guardarse para tener validez", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  End If
               End If
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmCierreCuentaSucCCO_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmCierreCuentaSucCCO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

      dtpFecha.Text = ToDateDMY(Now.Date)
      Call txtTipoCambioFind(ToDate(Now.Date))
      cboPlan.Value = ListFindItem(cboPlan, clsAppInfo.PlanResId)

      mboolShow = False
   End Sub

   Private Function FormCheck() As Boolean
      Dim strMessage As String = ""

      FormCheck = True

      If GestionIdFind(ToDate(dtpFecha.Value)) <> clsAppInfo.GestionId Then
         strMessage &= "Fecha no Corresponde a la Gestion en Uso" & vbCrLf
      End If

      If ToDecimal(txtTipoCambio.Text) <= 0 Then
         strMessage &= "Tipo de Cambio Inválido" & vbCrLf
      End If

      If ListPosition(cboPlan) = 0 Then
         strMessage &= "Contra Cuenta Inválida" & vbCrLf
      End If

      If strMessage <> "" Then
         FormCheck = False
         MessageBox.Show(strMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Function

   Private Function CierreCuenta() As Boolean
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      Dim decTotalBs As Decimal = 0
      Dim decTotalUs As Decimal = 0
      Dim lngCompDetId As Long = 0
      Dim lngGrupo As Long
      Dim boolCompNew As Boolean = True

      Call BitacoraAdd()
      CierreCuenta = False
      mlngPlanResId = ListPosition(cboPlan)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.EstadoResultado
            .EmpresaId = mlngEmpresaId
            .EsAna = 1

            mstrFechaFin = ToDate(dtpFecha.Value)

            If .Open() Then
               Do While .Read()
                  mdecDebeBs = 0
                  mdecHaberBs = 0
                  mdecDebeUs = 0
                  mdecHaberUs = 0
                  mlngSucursalId = 0
                  mlngCentroCostoId = 0

                  lngGrupo = .TipoGrupoId

                  If SumaColumnas(.PlanId, .SucCCOId) Then
                     For Each oRow In moCompDet.DataSet.Tables(moCompDet.TableName).Rows
                        mdecDebeBs = ToDecimal(oRow("DebeBs"))
                        mdecDebeUs = ToDecimal(oRow("DebeUs"))
                        mdecHaberBs = ToDecimal(oRow("HaberBs"))
                        mdecHaberUs = ToDecimal(oRow("HaberUs"))
                        Dim strDetdes = ""

                        If .SucCCOId = 1 Then
                           mlngSucursalId = ToLong(oRow("SucursalId"))
                           strDetdes = "Suc.: " & ToStr(oRow("SucursalDes"))
                        End If
                        If .SucCCOId = 2 Then
                           mlngCentroCostoId = ToLong(oRow("CentroCostoId"))
                           strDetdes = "C.C.: " & ToStr(oRow("CentroCostoDes"))
                        End If

                        If ToDecimalMinor(Math.Abs(mdecDebeBs - mdecHaberBs)) <> 0 And clsAppInfo.MonedaId = 1 Or ToDecimalMinor(Math.Abs(mdecDebeUs - mdecHaberUs)) <> 0 And clsAppInfo.MonedaId = 2 Then
                           If mdecDebeBs > mdecHaberBs Then
                              If boolCompNew Then
                                 If CompAdd(mlngCompId) Then
                                    boolCompNew = False
                                 End If
                              End If

                              If CompDetAdd(mlngCompId, lngCompDetId, .PlanId, .PlanDes, Math.Abs(mdecDebeBs - mdecHaberBs), Math.Abs(mdecDebeUs - mdecHaberUs), 2, mlngSucursalId, mlngCentroCostoId, strDetdes) Then
                                 decTotalBs = decTotalBs - Math.Abs(mdecDebeBs - mdecHaberBs)
                                 decTotalUs = decTotalUs - Math.Abs(mdecDebeUs - mdecHaberUs)
                                 CierreCuenta = True

                                 If ToBoolean(.TieneAnaAdd) Then
                                    If PlanAddNew(clsAppInfo.GestionId, mlngCompId, lngCompDetId, .PlanId, lngGrupo, .SucCCOId, If(.SucCCOId = 1, mlngSucursalId, mlngCentroCostoId)) Then
                                    End If
                                 End If

                                 If mlngCentroCostoId <> 0 Then
                                    Call CentroCostoDetNew(clsAppInfo.GestionId, mlngCompId, lngCompDetId, .PlanId, lngGrupo, mlngCentroCostoId)
                                 End If
                              End If

                           ElseIf mdecDebeBs < mdecHaberBs Then
                              If boolCompNew Then
                                 If CompAdd(mlngCompId) Then
                                    boolCompNew = False
                                 End If
                              End If

                              If CompDetAdd(mlngCompId, lngCompDetId, .PlanId, .PlanDes, Math.Abs(mdecHaberBs - mdecDebeBs), Math.Abs(mdecHaberUs - mdecDebeUs), 1, mlngSucursalId, mlngCentroCostoId, strDetdes) Then
                                 decTotalBs = decTotalBs + Math.Abs(mdecHaberBs - mdecDebeBs)
                                 decTotalUs = decTotalUs + Math.Abs(mdecHaberUs - mdecDebeUs)
                                 CierreCuenta = True

                                 If ToBoolean(.TieneAnaAdd) Then
                                    If PlanAddNew(clsAppInfo.GestionId, mlngCompId, lngCompDetId, .PlanId, lngGrupo, .SucCCOId, If(.SucCCOId = 1, mlngSucursalId, mlngCentroCostoId)) Then
                                    End If
                                 End If

                                 If mlngCentroCostoId <> 0 Then
                                    Call CentroCostoDetNew(clsAppInfo.GestionId, mlngCompId, lngCompDetId, .PlanId, lngGrupo, mlngCentroCostoId)
                                 End If
                              End If

                           ElseIf mdecDebeUs > mdecHaberUs Then
                              If boolCompNew Then
                                 If CompAdd(mlngCompId) Then
                                    boolCompNew = False
                                 End If
                              End If

                              If CompDetAdd(mlngCompId, lngCompDetId, .PlanId, .PlanDes, Math.Abs(mdecDebeBs - mdecHaberBs), Math.Abs(mdecDebeUs - mdecHaberUs), 2, mlngSucursalId, mlngCentroCostoId, strDetdes) Then
                                 decTotalBs = decTotalBs - Math.Abs(mdecDebeBs - mdecHaberBs)
                                 decTotalUs = decTotalUs - Math.Abs(mdecDebeUs - mdecHaberUs)
                                 CierreCuenta = True

                                 If ToBoolean(.TieneAnaAdd) Then
                                    If PlanAddNew(clsAppInfo.GestionId, mlngCompId, lngCompDetId, .PlanId, lngGrupo, .SucCCOId, If(.SucCCOId = 1, mlngSucursalId, mlngCentroCostoId)) Then
                                    End If
                                 End If

                                 If mlngCentroCostoId <> 0 Then
                                    Call CentroCostoDetNew(clsAppInfo.GestionId, mlngCompId, lngCompDetId, .PlanId, lngGrupo, mlngCentroCostoId)
                                 End If
                              End If

                           ElseIf mdecDebeUs < mdecHaberUs Then
                              If boolCompNew Then
                                 If CompAdd(mlngCompId) Then
                                    boolCompNew = False
                                 End If
                              End If

                              If CompDetAdd(mlngCompId, lngCompDetId, .PlanId, .PlanDes, Math.Abs(mdecHaberBs - mdecDebeBs), Math.Abs(mdecHaberUs - mdecDebeUs), 1, mlngSucursalId, mlngCentroCostoId, strDetdes) Then
                                 decTotalBs = decTotalBs + Math.Abs(mdecHaberBs - mdecDebeBs)
                                 decTotalUs = decTotalUs + Math.Abs(mdecHaberUs - mdecDebeUs)
                                 CierreCuenta = True

                                 If ToBoolean(.TieneAnaAdd) Then
                                    If PlanAddNew(clsAppInfo.GestionId, mlngCompId, lngCompDetId, .PlanId, lngGrupo, .SucCCOId, If(.SucCCOId = 1, mlngSucursalId, mlngCentroCostoId)) Then
                                    End If
                                 End If

                                 If mlngCentroCostoId <> 0 Then
                                    Call CentroCostoDetNew(clsAppInfo.GestionId, mlngCompId, lngCompDetId, .PlanId, lngGrupo, mlngCentroCostoId)
                                 End If
                              End If
                           End If
                        End If

                        mlngSucursalId = 0
                        mlngCentroCostoId = 0
                     Next
                  End If

                  .MoveNext()
               Loop

               If Not boolCompNew Then
                  If decTotalBs > 0 Then
                     If CompDetAdd(mlngCompId, lngCompDetId, mlngPlanResId, .PlanDes, Math.Abs(decTotalBs), Math.Abs(decTotalUs), 2) Then
                        CierreCuenta = True
                     End If

                  ElseIf decTotalBs < 0 Then
                     If CompDetAdd(mlngCompId, lngCompDetId, mlngPlanResId, .PlanDes, Math.Abs(decTotalBs), Math.Abs(decTotalUs), 1) Then
                        CierreCuenta = True
                     End If
                  End If
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Function

   Private Function CentroCostoDetNew(ByVal lngGestionId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngGrupo As Long, ByVal mlngCentroCostoId As Long) As Boolean
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0
      Dim decSaldoUs As Decimal = 0

      Try
         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.LibroMayorCuentaCentroCosto
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.LibroMayorFechaCentroCosto
            .GroupByFilter = clsCompCentroCostoDet.GroupByFilters.LibroMayorFechaCentroCosto
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .PlanId = lngPlanId
            .CentroCostoId = mlngCentroCostoId
            .Fecha = mstrFechaFin

            If .Open() Then
               Do While .Read()
                  mlngCentroCostoDetId = .CentroCostoDetId
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
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, lngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
                              CentroCostoDetNew = True
                           End If
                        ElseIf decSaldoBs < 0 Then
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, lngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
                              CentroCostoDetNew = True
                           End If
                        End If

                     ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                        If decSaldoBs > 0 Then
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, lngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
                              CentroCostoDetNew = True
                           End If
                        ElseIf decSaldoBs < 0 Then
                           If CompCentroCostoDetAdd(lngCompId, lngCompDetId, lngPlanId, mlngCentroCostoId, mlngCentroCostoDetId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
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

   Private Function CompCentroCostoDetAdd(ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngCentroCostoId As Long, _
                              ByVal lngCentroCostoDetId As Long, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long) As Boolean

      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)

      CompCentroCostoDetAdd = False

      Try
         With oCompCentroCostoDet
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .CompId = lngCompId
            .CompDetId = lngCompDetId
            .Fecha = mstrFechaFin
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

   'Private Function PlanAddNew(ByVal lngGestionId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngGrupo As Long) As Boolean
   '   Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
   '   Dim decSaldoBs As Decimal = 0
   '   Dim decSaldoUs As Decimal = 0

   '   Try
   '      With oPlanAdd
   '         .SelectFilter = clsPlanAdd.SelectFilters.All
   '         .WhereFilter = clsPlanAdd.WhereFilters.PlanId
   '         .OrderByFilter = clsPlanAdd.OrderByFilters.PlanAddDes
   '         .EmpresaId = mlngEmpresaId
   '         .PlanId = lngPlanId

   '         If .Open() Then
   '            Do While .Read()
   '               decSaldoBs = PlanAddSaldoBsGestion(clsAppInfo.GestionId, lngPlanId, .PlanAddId, lngGrupo, decSaldoUs)

   '               If decSaldoBs <> 0 Then
   '                  If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
   '                     If decSaldoBs > 0 Then
   '                        If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, .PlanAddId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
   '                           PlanAddNew = True
   '                        End If

   '                     ElseIf decSaldoBs < 0 Then
   '                        If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, .PlanAddId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
   '                           PlanAddNew = True
   '                        End If
   '                     End If

   '                  ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
   '                     If decSaldoBs > 0 Then
   '                        If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, .PlanAddId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
   '                           PlanAddNew = True
   '                        End If

   '                     ElseIf decSaldoBs < 0 Then
   '                        If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, .PlanAddId, Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
   '                           PlanAddNew = True
   '                        End If
   '                     End If
   '                  End If
   '               End If

   '               .MoveNext()
   '            Loop
   '         End If
   '      End With

   '   Catch exp As Exception
   '      MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

   '   Finally
   '      oPlanAdd.Dispose()

   '   End Try
   'End Function

   Private Function PlanAddNew(ByVal lngGestionId As Long, ByVal lngCompId As Long, ByVal lngCompDetId As Long, ByVal lngPlanId As Long, ByVal lngGrupo As Long, ByVal lngSucCCOId As Long, ByVal lngId As Long) As Boolean
      moCompPlanAdd = New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0
      Dim decSaldoUs As Decimal = 0

      Try
         With moCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuentaSucCCO
            .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayorSaldoAnteriorSucCCO
            .GroupByFilter = clsCompPlanAdd.GroupByfilters.LibroMayorSaldoAnteriorSucCCO
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
                           If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, ToLong(oRow("PlanAddId")), Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
                              PlanAddNew = True
                           End If

                        ElseIf decSaldoBs < 0 Then
                           If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, ToLong(oRow("PlanAddId")), Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
                              PlanAddNew = True
                           End If
                        End If

                     ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                        If decSaldoBs > 0 Then
                           If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, ToLong(oRow("PlanAddId")), Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 1) Then
                              PlanAddNew = True
                           End If

                        ElseIf decSaldoBs < 0 Then
                           If CompPlanAddAdd(lngGestionId, lngCompId, lngCompDetId, lngPlanId, ToLong(oRow("PlanAddId")), Math.Abs(decSaldoBs), Math.Abs(decSaldoUs), 2) Then
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

   Private Function CompAdd(ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      CompAdd = False

      Try
         With oComp
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoCompId = clsTipoComp.TRASPASO
            .CompNro = 0
            .Fecha = ToDate(dtpFecha.Value)
            .MonedaId = clsAppInfo.MonedaId
            .TipoCambio = ToDecimal(txtTipoCambio.Text)
            .EntregadoA = "Cierre Cuentas de Resultado"
            .PorConcepto = "Cierre Cuentas de Resultado"
            .DebeBs = 0
            .HaberBs = 0
            .DebeUs = 0
            .HaberUs = 0
            .PorIVA = 0
            .PorIT = 0
            .PorITF = 0
            .ConFac = 0
            .SinFac = 1
            .Automatico = 1
            .TipoAsientoId = clsTipoAsiento.CIERRE
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

   Private Function CompDetAdd(ByVal lngCompId As Long, ByRef lngCompDetId As Long, ByVal lngPlanId As Long, ByVal strPlanDes As String, ByVal decValorBs As Decimal, ByVal decValorUs As Decimal, ByVal lngCol As Long, Optional ByVal lngSucursalId As Long = 0, Optional ByVal lngCentroCostoId As Long = 0, Optional ByVal strDetalleDes As String = "") As Boolean
      Dim oCompDet As New clsCompDet(clsAppInfo.ConnectString)

      CompDetAdd = False

      Try
         With oCompDet
            .CompId = lngCompId
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .TipoCompId = 3
            .Fecha = ToDate(dtpFecha.Value)
            .PlanId = lngPlanId
            .CompDetDes = "Cierre Cuentas de Resultado" & If(String.IsNullOrEmpty(strDetalleDes), "", " - " & strDetalleDes)
            .SucursalId = mlngSucursalId
            .CentroCostoId = mlngCentroCostoId
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
         MessageBox.Show(exp.Message & "Cuenta: " & strPlanDes, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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
            .Fecha = ToDate(dtpFecha.Value)
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

   Private Function frmCompEditLoad(ByRef lngCompId As Long) As Boolean
      Dim oComp As New clsComp(clsAppInfo.ConnectString)

      frmCompEditLoad = False

      Try
         With oComp
            .CompId = lngCompId

            If .FindByPK Then
               Dim frm As New frmCompEdit

               If (.EstadoId <> 12) And (.EstadoId <> 10) Then
                  frm.NewRecord = False
                  frm.Editing = True
                  frm.DataObject = oComp
                  frm.ShowDialog()

                  If frm.Changed Then
                     frmCompEditLoad = True
                  End If

               Else
                  frm.NewRecord = False
                  frm.Editing = False
                  frm.DataObject = oComp
                  frm.ShowDialog()
               End If

               frm.Dispose()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oComp.Dispose()

      End Try
   End Function

   Private Function SumaColumnas(ByVal lngPlanId As Long, ByVal lngSucCCOId As Long) As Boolean
      SumaColumnas = False
      moCompDet = New clsCompDet(clsAppInfo.ConnectString)
      Try
         With moCompDet
            .SelectFilter = clsCompDet.SelectFilters.LibroMayorCuentaSucCCO
            .WhereFilter = clsCompDet.WhereFilters.LibroMayorSaldoActualSucCCO
            .GroupByFilter = clsCompDet.GroupByFilters.LibroMayorCuentaSucCCO
            .EmpresaId = mlngEmpresaId
            .GestionId = clsAppInfo.GestionId
            .PlanId = lngPlanId
            .Fecha = mstrFechaFin
            .SucursalId = lngSucCCOId

            If .Open() And .DataSet.Tables(.TableName).Rows.Count > 0 Then
               SumaColumnas = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Function

   Private Function PlanAddSaldoBsGestion(ByVal lngGestionId As Long, ByVal lngPlanId As Long, ByVal lngPlanAddId As Long, ByVal lngGrupo As Long, ByRef decSaldoUs As Decimal) As Decimal
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim decSaldoBs As Decimal = 0

      decSaldoUs = 0

      Try
         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.LibroMayorCuenta
            .WhereFilter = clsCompPlanAdd.WhereFilters.LibroMayor
            .EmpresaId = mlngEmpresaId
            .GestionId = lngGestionId
            .PlanId = lngPlanId
            .PlanAddId = lngPlanAddId

            If .Open() Then
               For Each oRow As DataRow In .DataSet.Tables(.TableName).Rows
                  If (lngGrupo = 1) Or (lngGrupo = 5) Or (lngGrupo = 6) Or (lngGrupo = 7) Then
                     decSaldoBs += ToDecimal(oRow("DebeBs") - oRow("HaberBs"))
                     decSaldoUs += ToDecimal(oRow("DebeUs") - oRow("HaberUs"))

                  ElseIf (lngGrupo = 2) Or (lngGrupo = 3) Or (lngGrupo = 4) Or (lngGrupo = 8) Then
                     decSaldoBs += ToDecimal(oRow("HaberBs") - oRow("DebeBs"))
                     decSaldoUs += ToDecimal(oRow("HaberUs") - oRow("DebeUs"))
                  End If
               Next

               PlanAddSaldoBsGestion = decSaldoBs
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPlanAdd.Dispose()

      End Try
   End Function

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

   Private Function GestionIdFind(ByVal strFecha As String) As Long
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      GestionIdFind = 0

      Try
         With oGestion
            .SelectFilter = clsGestion.SelectFilters.All
            .WhereFilter = clsGestion.WhereFilters.FechaIntervalo
            .EmpresaId = mlngEmpresaId
            .FechaIni = strFecha
            .EstadoId = 11

            If .Find Then
               GestionIdFind = .GestionId
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Function

   Private Sub ComboLoad()
      Call cboPlanLoad()
   End Sub

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.MultiComboBox
            .WhereFilter = clsPlan.WhereFilters.EsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = mlngEmpresaId
            .EsAna = 1

            If .Open() Then
               With cboPlan
                  .DropDownList.Columns.Clear()

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

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  If clsAppInfo.PlanCtaShow Then
                     .ValueMember = "PlanId"
                     .DisplayMember = "PlanCta"
                  Else
                     .ValueMember = "PlanId"
                     .DisplayMember = "PlanDes"
                  End If
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)

      txtTipoCambio.FormatString = DecimalMask()
   End Sub

   Private Sub frmCierreCuentaSucCCO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.True Then
               If MessageBox.Show("¿Realmente quiere Realizar el Cierre de Cuentas de Resultado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  If CierreCuenta() Then
                     If frmCompEditLoad(mlngCompId) Then
                        MessageBox.Show("El Cierre de Cuentas de Resultado se Realizo Exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     Else
                        MessageBox.Show("El Comprobante debe Guardarse para tener validez", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                     End If
                  End If
               End If
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmCierreCuentaSucCCO_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

   Private Sub BitacoraAdd()
      '* BITACORA CIERRE CUENTA.
      Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.CIERRE_CUENTAS, "Fecha: " & dtpFecha.Text & "; T.C.:" & txtTipoCambio.Text & "; Contracuenta : " & cboPlan.Text)
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

   Private Function ComprobanteToString(ByVal oComp As clsComp) As String
      Dim strComprobante As String
      strComprobante = "CompId: " & oComp.CompId.ToString
      strComprobante &= "; Fecha: " & dtpFecha.Text
      strComprobante &= "; Moneda: " & MonedaDesFind(oComp.MonedaId)
      strComprobante &= "; Tipo: " & TipoCompDesFind(oComp.TipoCompId)
      strComprobante &= "; detalle1: " & oComp.EntregadoA
      strComprobante &= "; detalle2: " & oComp.PorConcepto
      strComprobante &= "; Estado: " & EstadoDesFind(oComp.EstadoId)
      Return strComprobante
   End Function

End Class
