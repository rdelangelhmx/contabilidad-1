'Option Strict On

Public Class frmChequeImp
   Private DX, DY As Integer

   'Declaraciones del API para 32 bits
   Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
   Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
   Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cX As Integer, ByVal cY As Integer, ByVal wFlags As Integer) As Integer

   'Constantes para usar con el API
   Const GWL_STYLE As Integer = (-16)
   Const WS_THICKFRAME As Integer = &H40000 ' Con borde redimensionable
   Const SWP_DRAWFRAME As Integer = &H20
   Const SWP_NOMOVE As Integer = &H2
   Const SWP_NOSIZE As Integer = &H1
   Const SWP_NOZORDER As Integer = &H4

   Private moGraphics As Graphics = Me.CreateGraphics
   Private mdecPPIX As Decimal 'Pixels per Inch
   Private mdecPPIY As Decimal 'Pixels per Inch
   Private mdecPPCMX As Decimal 'Pixels per cm
   Private mdecPPCMY As Decimal 'Pixels per cm

   Private moChequeImp As clsChequeImp
   Private moCheque As clsCheque

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean
   Private mlngID As Long

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   Property DataObjectCheque() As clsCheque
      Get
         Return moCheque
      End Get

      Set(ByVal Value As clsCheque)
         moCheque = Value
      End Set
   End Property

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Save"
            txtBancoCta.Select()

            If DataSave() Then
               mlngID = moChequeImp.ChequeImpId
               mboolChanged = True
               Me.Close()
            End If

         Case "Print"
            Call PrintReport()

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmChequeImp_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmChequeImp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True
      'Asignar a todos los controles los eventos para poder moverlos...
      AsignarEventos(Me)

      Call FormInit()
      Call ComboLoad()
      Call FormShow()

      Call ClearMemory()
      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormShow()
      Dim oTextBox As System.Windows.Forms.TextBox

      mboolShow = True

      txtBancoCta.Text = moCheque.BancoCta
      cboOrientacion.SelectedIndex = ListFindItem(cboOrientacion, moCheque.OrientacionId)
      txtChequeWidth.Text = moCheque.ChequeWidth / (mdecPPIX / 2.54)
      txtChequeHeight.Text = moCheque.ChequeHeight / (mdecPPIY / 2.54)

      With moChequeImp
         .SelectFilter = clsChequeImp.SelectFilters.All
         .WhereFilter = clsChequeImp.WhereFilters.ChequeId
         .ChequeId = moCheque.ChequeId

         If .Open Then
            If .RowCount > 0 Then
               Do While .Read
                  For Each oTextBox In Me.panMain.Controls
                     If UCase$(oTextBox.Name) = UCase$(.CtrlName) Then
                        oTextBox.Left = ToInteger(.CtrlLeft)
                        oTextBox.Top = ToInteger(.CtrlTop)

                        oTextBox.Width = ToInteger(.CtrlWidth)
                        oTextBox.Height = ToInteger(.CtrlHeight)

                        oTextBox.Tag = .CtrlVisible
                        oTextBox.MaxLength = .CtrlMaxLength

                        Exit For
                     End If
                  Next

                  .MoveNext()
               Loop

            Else
               For Each oTextBox In Me.panMain.Controls
                  oTextBox.Tag = 1
                  oTextBox.MaxLength = 0
               Next

               cdmMain.Commands.Item("Print").Enabled = Janus.Windows.UI.InheritableBoolean.False
            End If
         End If
      End With

      mboolShow = False
   End Sub

   Public Function ChequeFind(ByVal lngChequeId As Long, ByRef PlanId As Long) As String
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)
      oCheque.ChequeId = lngChequeId
      oCheque.FindByPK()
      PlanId = oCheque.PlanId
      Return oCheque.BancoCta
   End Function

   Private Sub CloneVM(ByRef oVM As clsChequeImpVM, ByVal oChequeImp As clsChequeImp)
      oVM = New clsChequeImpVM

      If clsAppInfo.RegistrarBitacora Then
         With oVM
            .ChequeImpId = oChequeImp.ChequeImpId
            .ChequeId = oChequeImp.ChequeId
            .BancoCta = ChequeFind(.ChequeId, .PlanId)
            .ChequeId = oChequeImp.ChequeId
            .CtrlName = oChequeImp.CtrlName
            .CtrlLeft = oChequeImp.CtrlLeft
            .CtrlTop = oChequeImp.CtrlTop
            .CtrlWidth = oChequeImp.CtrlWidth
            .CtrlHeight = oChequeImp.CtrlHeight
            .CtrlMaxLength = oChequeImp.CtrlMaxLength
            .CtrlVisible = ToBoolean(oChequeImp.CtrlVisible)

            .FormName = Me.Name
            .FormText = Me.Text
         End With
      End If
   End Sub

   Private Function DataSave() As Boolean
      Dim oTextBox As System.Windows.Forms.TextBox

      Try
         For Each oTextBox In Me.panMain.Controls
            With moChequeImp
               .SelectFilter = clsChequeImp.SelectFilters.All
               .WhereFilter = clsChequeImp.WhereFilters.CtrlName
               .ChequeId = moCheque.ChequeId
               .CtrlName = oTextBox.Name

               If Not .Find Then
                  .EmpresaId = clsAppInfo.EmpresaId
                  .ChequeId = moCheque.ChequeId
                  .CtrlName = ToStr(oTextBox.Name)
                  .CtrlLeft = ToLong(oTextBox.Left)
                  .CtrlTop = ToLong(oTextBox.Top)
                  .CtrlWidth = ToLong(oTextBox.Width)
                  .CtrlHeight = ToLong(oTextBox.Height)
                  .CtrlMaxLength = ToLong(oTextBox.MaxLength)
                  .CtrlVisible = ToBoolean(oTextBox.Tag)

                  Call CloneVM(.VMNew, moChequeImp)
                  DataSave = moChequeImp.Insert()
               Else
                  Call CloneVM(.VMOld, moChequeImp)

                  .CtrlLeft = ToLong(oTextBox.Left)
                  .CtrlTop = ToLong(oTextBox.Top)
                  .CtrlWidth = ToLong(oTextBox.Width)
                  .CtrlHeight = ToLong(oTextBox.Height)
                  .CtrlMaxLength = ToLong(oTextBox.MaxLength)
                  .CtrlVisible = ToBoolean(oTextBox.Tag)

                  Call CloneVM(.VMNew, moChequeImp)
                  DataSave = moChequeImp.Update()
               End If
            End With
         Next

         If DataSave Then
            moCheque.OrientacionId = ListPosition(cboOrientacion, cboOrientacion.SelectedIndex)
            moCheque.ChequeWidth = ToLong(CDec(txtChequeWidth.Text) * (mdecPPIX / 2.54))
            moCheque.ChequeHeight = ToLong(CDec(txtChequeHeight.Text) * (mdecPPIY / 2.54))
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      mdecPPIX = CDec(moGraphics.DpiX) 'Pixels per Inch
      mdecPPIY = CDec(moGraphics.DpiY) 'Pixels per Inch
      mdecPPCMX = CDec(mdecPPIX / 2.64) 'Pixels per cm
      mdecPPCMY = CDec(mdecPPIY / 2.64) 'Pixels per cm

      moChequeImp = New clsChequeImp(clsAppInfo.ConnectString)
   End Sub

   Private Sub ComboLoad()
      Call cboOrientacionLoad()
   End Sub

   Private Sub cboOrientacionLoad()
      Dim oItem As clsListItem

      cboOrientacion.Items.Clear()

      Try
         oItem = New clsListItem(1, "Vertical")
         cboOrientacion.Items.Add(oItem)

         oItem = New clsListItem(2, "Horizontal")
         cboOrientacion.Items.Add(oItem)

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oItem = Nothing
      End Try
   End Sub

   Private Sub PrintReport()
      Dim rpt As New rptChequeImp
      Dim oTextBox As DataDynamics.ActiveReports.TextBox
      Dim oChequeImp As New clsChequeImp(clsAppInfo.ConnectString)

      Try
         rpt.Document.Printer.PrinterName = ""

         rpt.PageSettings.PaperKind = Drawing.Printing.PaperKind.Custom
         rpt.PageSettings.PaperWidth = moCheque.ChequeWidth / mdecPPIX
         rpt.PageSettings.PaperHeight = moCheque.ChequeHeight / mdecPPIY

         If moCheque.OrientacionId = 1 Then 'Vertical
            rpt.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            rpt.PrintWidth = moCheque.ChequeWidth / mdecPPIX

         ElseIf moCheque.OrientacionId = 2 Then 'Horizontal
            rpt.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
            rpt.PrintWidth = moCheque.ChequeHeight / mdecPPIY
         End If

         rpt.Sections("Detail1").Height = moCheque.ChequeHeight / mdecPPIY

         With oChequeImp
            .SelectFilter = clsChequeImp.SelectFilters.All
            .WhereFilter = clsChequeImp.WhereFilters.ChequeId
            .OrderByFilter = clsChequeImp.OrderByFilters.ChequeImpId
            .ChequeId = moCheque.ChequeId

            If .Open() Then
               Do While .Read()
                  For Each oTextBox In rpt.Sections("Detail1").Controls
                     If UCase$(oTextBox.Name) = UCase$(.CtrlName) Then
                        oTextBox.Left = CSng((.CtrlLeft / moGraphics.DpiX) - 0.15)
                        oTextBox.Top = CSng((.CtrlTop / moGraphics.DpiY) - 0.15)

                        oTextBox.Width = CSng(.CtrlWidth / moGraphics.DpiX)
                        oTextBox.Height = CSng(.CtrlHeight / moGraphics.DpiY)

                        oTextBox.Visible = True

                        Exit For
                     End If
                  Next

                  .MoveNext()
               Loop
            End If
         End With

         rpt.Run(True)

         If rpt.Document.Pages.Count() > 1 Then
            rpt.Document.Pages.RemoveAt(rpt.Document.Pages.Count() - 1)
         End If

         Dim frm As New frmReportPreview(rpt.Document, Me)
         frm.Show()

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oChequeImp.Dispose()
      End Try
   End Sub

   Private Sub Control_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
      'Cuando se pulsa con el ratón
      DX = e.X
      DY = e.Y

      'Al pulsar con el botón derecho, cambiar el estilo entre redimensionable y normal
      'lblStatus.Text = "Control: " & CType(sender, Control).Name

      If (e.Button = MouseButtons.Right) And (CType(sender, Control).Name <> "panMain") Then
         'If e.Button = MouseButtons.Right Then
         CambiarEstilo(CType(sender, Control))

      Else
         'Cuando se pulsa en un control, posicionarlo encima del resto
         CType(sender, Control).BringToFront()
      End If
   End Sub

   Private Sub Control_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
      'Cuando se mueve el ratón y se pulsa el botón izquierdo... mover el control

      If (e.Button = MouseButtons.Left) And (CType(sender, Control).Name <> "panMain") Then
         'If e.Button = MouseButtons.Left Then
         CType(sender, Control).Left = e.X + CType(sender, Control).Left - DX
         CType(sender, Control).Top = e.Y + CType(sender, Control).Top - DY
      End If
   End Sub

   Private Sub Control_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
      'lblStatus.Text = CType(sender, Control).Text
   End Sub

   Private Sub AsignarEventos(ByVal elControl As Control)
      Dim ctrl As Control

      For Each ctrl In elControl.Controls
         'No asignar estos evento al botón salir

         If (ctrl.Name <> "panProperties") And (ctrl.Name <> "panCheque") And (ctrl.Name <> "TopRebar1") Then
            'Curiosamente un control GroupBox en apariencia no tiene estos eventos, pero... se le asigna y... ¡funciona!
            AddHandler ctrl.MouseDown, AddressOf Me.Control_MouseDown
            AddHandler ctrl.MouseMove, AddressOf Me.Control_MouseMove
            AddHandler ctrl.MouseEnter, AddressOf Me.Control_MouseEnter
            AsignarEventos(ctrl)
         End If
      Next
   End Sub

   Private Sub CambiarEstilo(ByVal aControl As Control)
      'Hacer este control redimensionable, usando el API
      'Pone o quita el estilo dimensionable
      Dim Style As Integer

      'Si se produce un error, no hacer nada...
      Try
         Style = GetWindowLong(aControl.Handle.ToInt32, GWL_STYLE)

         If (Style And WS_THICKFRAME) = WS_THICKFRAME Then
            'Si ya lo tiene, lo quita
            Style = Style Xor WS_THICKFRAME

         Else
            'Si no lo tiene, lo pone
            Style = Style Or WS_THICKFRAME
         End If

         SetWindowLong(aControl.Handle.ToInt32, GWL_STYLE, Style)
         SetWindowPos(aControl.Handle.ToInt32, Me.Handle.ToInt32, 0, 0, 0, 0, SWP_NOZORDER Or SWP_NOSIZE Or SWP_NOMOVE Or SWP_DRAWFRAME)

      Catch e As Exception
         MsgBox("El control " & aControl.Name & " no permite que se redimensione", MsgBoxStyle.Information)
         Exit Sub
      End Try
   End Sub

   Private Sub txtLugar_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLugar.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtLugar.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtLugar.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtLugar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLugar.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtLugar.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtLugar.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtLugar.Width / mdecPPCMX
         txtCtrlHeight.Text = txtLugar.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtLugar.Tag)
         txtCtrlMaxLength.Text = ToLong(txtLugar.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtLugar_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLugar.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtLugar.Width / mdecPPCMX
         txtCtrlHeight.Text = txtLugar.Height / mdecPPCMY
      End If
   End Sub

   Private Sub txtDia_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtDia.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtDia.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtDia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtDia.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtDia.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtDia.Width / mdecPPCMX
         txtCtrlHeight.Text = txtDia.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtDia.Tag)
         txtCtrlMaxLength.Text = ToLong(txtDia.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtDia_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDia.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtDia.Width / mdecPPCMX
         txtCtrlHeight.Text = txtDia.Height / mdecPPCMY
      End If
   End Sub

   Private Sub txtDeMes_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeMes.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtDeMes.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtDeMes.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtDeMes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeMes.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtDeMes.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtDeMes.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtDeMes.Width / mdecPPCMX
         txtCtrlHeight.Text = txtDeMes.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtDeMes.Tag)
         txtCtrlMaxLength.Text = ToLong(txtDeMes.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtDeMes_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeMes.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtDeMes.Width / mdecPPCMX
         txtCtrlHeight.Text = txtDeMes.Height / mdecPPCMY
      End If
   End Sub

   Private Sub txtMes_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtMes.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtMes.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtMes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtMes.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtMes.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtMes.Width / mdecPPCMX
         txtCtrlHeight.Text = txtMes.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtMes.Tag)
         txtCtrlMaxLength.Text = ToLong(txtMes.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtMes_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMes.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtMes.Width / mdecPPCMX
         txtCtrlHeight.Text = txtMes.Height / mdecPPCMY
      End If
   End Sub

   Private Sub txtDeAnio_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeAnio.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtDeAnio.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtDeAnio.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtDeAnio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeAnio.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtDeAnio.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtDeAnio.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtDeAnio.Width / mdecPPCMX
         txtCtrlHeight.Text = txtDeAnio.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtDeAnio.Tag)
         txtCtrlMaxLength.Text = ToLong(txtDeAnio.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtDeAnio_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeAnio.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtDeAnio.Width / mdecPPCMX
         txtCtrlHeight.Text = txtDeAnio.Height / mdecPPCMY
      End If
   End Sub

   Private Sub txtAnio_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtAnio.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtAnio.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtAnio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtAnio.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtAnio.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtAnio.Width / mdecPPCMX
         txtCtrlHeight.Text = txtAnio.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtAnio.Tag)
         txtCtrlMaxLength.Text = ToLong(txtAnio.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtAnio_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtAnio.Width / mdecPPCMX
         txtCtrlHeight.Text = txtAnio.Height / mdecPPCMY
      End If
   End Sub

   Private Sub txtImporte_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtImporte.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtImporte.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtImporte_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtImporte.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtImporte.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtImporte.Width / mdecPPCMX
         txtCtrlHeight.Text = txtImporte.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtImporte.Tag)
         txtCtrlMaxLength.Text = ToLong(txtImporte.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtImporte_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtImporte.Width / mdecPPCMX
         txtCtrlHeight.Text = txtImporte.Height / mdecPPCMY
      End If
   End Sub

   Private Sub txtPaguese_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaguese.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtPaguese.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtPaguese.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtPaguese_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaguese.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtPaguese.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtPaguese.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtPaguese.Width / mdecPPCMX
         txtCtrlHeight.Text = txtPaguese.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtPaguese.Tag)
         txtCtrlMaxLength.Text = ToLong(txtPaguese.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtPaguese_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaguese.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtPaguese.Width / mdecPPCMX
         txtCtrlHeight.Text = txtPaguese.Height / mdecPPCMY
      End If
   End Sub

   Private Sub txtLiteral_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLiteral.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtLiteral.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtLiteral.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtLiteral_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLiteral.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtLiteral.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtLiteral.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtLiteral.Width / mdecPPCMX
         txtCtrlHeight.Text = txtLiteral.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtLiteral.Tag)
         txtCtrlMaxLength.Text = ToLong(txtLiteral.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtLiteral_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLiteral.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtLiteral.Width / mdecPPCMX
         txtCtrlHeight.Text = txtLiteral.Height / mdecPPCMY
      End If
   End Sub

   Private Sub txtConcepto_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConcepto.Move
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtConcepto.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtConcepto.Top / mdecPPCMY) - 0.381
      End If
   End Sub

   Private Sub txtConcepto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConcepto.GotFocus
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlLeft.Text = (txtConcepto.Left / mdecPPCMX) - 0.381
         txtCtrlTop.Text = (txtConcepto.Top / mdecPPCMY) - 0.381

         txtCtrlWidth.Text = txtConcepto.Width / mdecPPCMX
         txtCtrlHeight.Text = txtConcepto.Height / mdecPPCMY

         chkVisible.Checked = CBool(txtConcepto.Tag)
         txtCtrlMaxLength.Text = ToLong(txtConcepto.MaxLength)

         lblStatus.Text = CType(sender, Control).Text
      End If
   End Sub

   Private Sub txtConcepto_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConcepto.SizeChanged
      If (mdecPPCMX > 0) And (mdecPPCMY > 0) Then
         txtCtrlWidth.Text = txtConcepto.Width / mdecPPCMX
         txtCtrlHeight.Text = txtConcepto.Height / mdecPPCMY
      End If
   End Sub

   Private Sub chkVisible_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkVisible.Click
      Select Case lblStatus.Text
         Case "LUGAR"
            txtLugar.Tag = ToBoolean(chkVisible.Checked)

         Case "DIA"
            txtDia.Tag = ToBoolean(chkVisible.Checked)

         Case "DE_MES"
            txtDeMes.Tag = ToBoolean(chkVisible.Checked)

         Case "MES"
            txtMes.Tag = ToBoolean(chkVisible.Checked)

         Case "DE_AÑO"
            txtDeAnio.Tag = ToBoolean(chkVisible.Checked)

         Case "AÑO"
            txtAnio.Tag = ToBoolean(chkVisible.Checked)

         Case "IMPORTE"
            txtImporte.Tag = ToBoolean(chkVisible.Checked)

         Case "PAGUESE A LA ORDEN DE"
            txtPaguese.Tag = ToBoolean(chkVisible.Checked)

         Case "LA SUMA DE"
            txtLiteral.Tag = ToBoolean(chkVisible.Checked)

         Case "CONCEPTO"
            txtConcepto.Tag = ToBoolean(chkVisible.Checked)
      End Select
   End Sub

   Private Sub txtCtrlLeft_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtrlLeft.LostFocus
      Select Case lblStatus.Text
         Case "LUGAR"
            txtLugar.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))

         Case "DIA"
            txtDia.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))

         Case "DE_MES"
            txtDeMes.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))

         Case "MES"
            txtMes.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))

         Case "DE_AÑO"
            txtDeAnio.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))

         Case "AÑO"
            txtAnio.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))

         Case "IMPORTE"
            txtImporte.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))

         Case "PAGUESE A LA ORDEN DE"
            txtPaguese.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))

         Case "LA SUMA DE"
            txtLiteral.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))

         Case "CONCEPTO"
            txtConcepto.Left = ToInteger((CDec(txtCtrlLeft.Text) * mdecPPCMX) + (0.381 * mdecPPCMX))
      End Select
   End Sub

   Private Sub txtCtrlTop_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtrlTop.LostFocus
      Select Case lblStatus.Text
         Case "LUGAR"
            txtLugar.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))

         Case "DIA"
            txtDia.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))

         Case "DE_MES"
            txtDeMes.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))

         Case "MES"
            txtMes.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))

         Case "DE_AÑO"
            txtDeAnio.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))

         Case "AÑO"
            txtAnio.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))

         Case "IMPORTE"
            txtImporte.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))

         Case "PAGUESE A LA ORDEN DE"
            txtPaguese.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))

         Case "LA SUMA DE"
            txtLiteral.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))

         Case "CONCEPTO"
            txtConcepto.Top = ToInteger((CDec(txtCtrlTop.Text) * mdecPPCMY) + (0.381 * mdecPPCMY))
      End Select
   End Sub

   Private Sub txtCtrlWidth_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtrlWidth.LostFocus
      Select Case lblStatus.Text
         Case "LUGAR"
            txtLugar.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)

         Case "DIA"
            txtDia.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)

         Case "DE_MES"
            txtDeMes.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)

         Case "MES"
            txtMes.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)

         Case "DE_AÑO"
            txtDeAnio.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)

         Case "AÑO"
            txtAnio.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)

         Case "IMPORTE"
            txtImporte.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)

         Case "PAGUESE A LA ORDEN DE"
            txtPaguese.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)

         Case "LA SUMA DE"
            txtLiteral.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)

         Case "CONCEPTO"
            txtConcepto.Width = ToInteger(CDec(txtCtrlWidth.Text) * mdecPPCMX)
      End Select
   End Sub

   Private Sub txtCtrlHeight_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtrlHeight.LostFocus
      Select Case lblStatus.Text
         Case "LUGAR"
            txtLugar.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)

         Case "DIA"
            txtDia.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)

         Case "DE_MES"
            txtDeMes.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)

         Case "MES"
            txtMes.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)

         Case "DE_AÑO"
            txtDeAnio.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)

         Case "AÑO"
            txtAnio.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)

         Case "IMPORTE"
            txtImporte.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)

         Case "PAGUESE A LA ORDEN DE"
            txtPaguese.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)

         Case "LA SUMA DE"
            txtLiteral.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)

         Case "CONCEPTO"
            txtConcepto.Height = ToInteger(CDec(txtCtrlHeight.Text) * mdecPPCMY)
      End Select
   End Sub

   Private Sub txtCtrlMaxLength_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtrlMaxLength.LostFocus
      Select Case lblStatus.Text
         Case "LUGAR"
            txtLugar.MaxLength = ToInteger(txtCtrlMaxLength.Text)

         Case "DIA"
            txtDia.MaxLength = ToInteger(txtCtrlMaxLength.Text)

         Case "DE_MES"
            txtDeMes.MaxLength = ToInteger(txtCtrlMaxLength.Text)

         Case "MES"
            txtMes.MaxLength = ToInteger(txtCtrlMaxLength.Text)

         Case "DE_AÑO"
            txtDeAnio.MaxLength = ToInteger(txtCtrlMaxLength.Text)

         Case "AÑO"
            txtAnio.MaxLength = ToInteger(txtCtrlMaxLength.Text)

         Case "IMPORTE"
            txtImporte.MaxLength = ToInteger(txtCtrlMaxLength.Text)

         Case "PAGUESE A LA ORDEN DE"
            txtPaguese.MaxLength = ToInteger(txtCtrlMaxLength.Text)

         Case "LA SUMA DE"
            txtLiteral.MaxLength = ToInteger(txtCtrlMaxLength.Text)

         Case "CONCEPTO"
            txtConcepto.MaxLength = ToInteger(txtCtrlMaxLength.Text)
      End Select
   End Sub

   Private Sub frmChequeImp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moChequeImp.ChequeImpId
               mboolChanged = True
               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmChequeImp_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moChequeImp.Dispose()
      moCheque.Dispose()
      moGraphics.Dispose()

      Call ClearMemory()
   End Sub

End Class