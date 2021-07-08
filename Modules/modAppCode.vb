Module modAppCode
   Public gfrmMain As frmMain

   Public Sub Main()
      Dim splash As New frmSplash

      Try
         splash.Show()
         splash.Update()

         clsAppInfo.Init()

         If AppLoad(2) Then
            gfrmMain = New frmMain

            splash.Close()
            splash.Dispose()

            gfrmMain.ShowDialog()
            gfrmMain.Update()
         Else
            End
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Public Function AppLoad(ByVal lngAppId As Long) As Boolean
      Dim oApp As New clsApp(clsAppInfo.ConnectString)

      clsAppInfo.AppId = 0
      clsAppInfo.AppDes = ""

      Try
         With oApp
            .AppId = lngAppId

            If .FindByPK Then
               clsAppInfo.AppId = ToLong(.AppId)
               clsAppInfo.AppDes = ToStr(.AppDes)
               clsAppInfo.DataBaseSource = ToStr(.DataBaseSource)
               clsAppInfo.DataBaseName = ToStr(.DataBaseName)
               clsAppInfo.RegistrarBitacora = CBool(.Bitacora)
               AppLoad = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         AppLoad = False

      Finally
         oApp.Dispose()

      End Try
   End Function

   Public Function SecurityParaLoad(ByVal lngSecurityParaId As Long) As Boolean
      Dim oSecurityPara As New clsSecurityPara(clsAppInfo.ConnectString)

      clsAppInfo.MinLength = 0
      clsAppInfo.NumUpper = 0
      clsAppInfo.NumLower = 0
      clsAppInfo.NumNumbers = 0
      clsAppInfo.NumSpecial = 0
      clsAppInfo.NumFailed = 0

      Try
         With oSecurityPara
            .SecurityParaId = lngSecurityParaId

            If .FindByPK Then
               clsAppInfo.MinLength = .MinLength
               clsAppInfo.NumUpper = .NumUpper
               clsAppInfo.NumLower = .NumLower
               clsAppInfo.NumNumbers = .NumNumbers
               clsAppInfo.NumSpecial = .NumSpecial
               clsAppInfo.NumFailed = .NumFailed

               SecurityParaLoad = True
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         SecurityParaLoad = False

      Finally
         oSecurityPara.Dispose()

      End Try
   End Function

   Public Sub PreferenceLoad(ByVal lngAppId As Long, ByVal lngUserId As Long)
      Dim oPreference As New clsPreference(clsAppInfo.ConnectString)

      clsAppInfo.EmpresaId = 0
      clsAppInfo.GestionId = 0
      clsAppInfo.Gestion = 0

      Try
         With oPreference
            .SelectFilter = clsPreference.SelectFilters.All
            .WhereFilter = clsPreference.WhereFilters.UserId
            .AppId = lngAppId
            .UserId = lngUserId

            If .Find Then
               clsAppInfo.EmpresaId = ToLong(.EmpresaId)
               clsAppInfo.GestionId = ToLong(.GestionId)

               Call GestionParaLoad(.GestionId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPreference.Dispose()
      End Try
   End Sub

   Public Sub GestionParaLoad(ByVal lngGestionId As Long)
      Dim oGestion As New clsGestion(clsAppInfo.ConnectString)

      clsAppInfo.Gestion = 0

      Try
         With oGestion
            .GestionId = lngGestionId

            If .FindByPK Then
               clsAppInfo.Gestion = ToLong(.Gestion)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oGestion.Dispose()

      End Try
   End Sub

   Public Sub EmpresaParaLoad(ByVal lngEmpresaId As Long)
      Call EmpresaLoad(lngEmpresaId)
      Call PlanIdParaLoad(lngEmpresaId)
      Call EmpresaParaCheck()
   End Sub

   Public Sub EmpresaLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      clsAppInfo.EmpresaId = 0
      clsAppInfo.EmpresaDes = ""
      clsAppInfo.EmpresaGral = ""

      Try
         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               clsAppInfo.EmpresaId = ToLong(.EmpresaId)
               clsAppInfo.EmpresaDes = ToStr(.EmpresaDes)
               clsAppInfo.MonedaId = ToLong(.MonedaId)
               clsAppInfo.CiudadId = ToLong(.CiudadId)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Sub

   Public Sub EmpresaParaCheck()
      Dim strMsg As String = String.Empty

      If clsAppInfo.PlanCreId = 0 Then
         strMsg &= "Cuenta para Crédito Fiscal" & vbCrLf
      End If

      If clsAppInfo.PlanDebId = 0 Then
         strMsg &= "Cuenta para Débito Fiscal" & vbCrLf
      End If

      If clsAppInfo.PlanITId = 0 Then
         strMsg &= "Cuenta para Impuesto a las Transacciones" & vbCrLf
      End If

      If clsAppInfo.PlanITPId = 0 Then
         strMsg &= "Cuenta para Impuesto a las Transacciones por Pagar" & vbCrLf
      End If

      If clsAppInfo.PlanITFId = 0 Then
         strMsg &= "Cuenta para Impuesto a las Transacciones Financieras" & vbCrLf
      End If

      If clsAppInfo.PlanDifId = 0 Then
         strMsg &= "Cuenta para Diferencia de Cambio" & vbCrLf
      End If

      If clsAppInfo.PlanResId = 0 Then
         strMsg &= "Cuenta para Resultado de la Gestion" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         If MessageBox.Show("No Estan Definidos los Parámetros de las Siguientes Cuentas Contables y esto Podria Ocasionar Problemas con los Asientos Automaticos" & vbCrLf & vbCrLf & strMsg & vbCrLf & "¿Desea Parametrisarlos Ahora?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim frm As New frmEmpresaPara

            With frm
               '.MdiParent = gfrmMain
               .EmpresaId = clsAppInfo.EmpresaId
               .ShowDialog()
            End With
         End If
      End If
   End Sub

   Public Sub CompParaCheck()
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.GestionId
            .EmpresaId = clsAppInfo.EmpresaId
            .GestionId = clsAppInfo.GestionId

            If Not .Find Then
               If MessageBox.Show("No Existen Parámetros de Documentos Aperturados para esta Gestión y estos son Necesarios para Generar Transacciones" & vbCrLf & vbCrLf & "¿Desea Aperturarlos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Dim frm As New frmCompPara

                  With frm
                     .MdiParent = gfrmMain
                     .EmpresaId = clsAppInfo.EmpresaId
                     .Show()
                  End With
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oCompPara.Dispose()

      End Try
   End Sub

   Public Sub ImpuestoLoad()
      Dim oImpuesto As New clsImpuesto(clsAppInfo.ConnectString)

      clsAppInfo.IVA = 0

      Try
         With oImpuesto
            .SelectFilter = clsImpuesto.SelectFilters.All

            If .Open Then
               Do While .Read
                  If .ImpuestoId = 1 Then
                     clsAppInfo.IVA = .Valor
                  ElseIf .ImpuestoId = 2 Then
                     clsAppInfo.IT = .Valor
                  ElseIf .ImpuestoId = 3 Then
                     clsAppInfo.ITF = .Valor
                  ElseIf .ImpuestoId = 5 Then
                     clsAppInfo.IUEServicio = .Valor
                  ElseIf .ImpuestoId = 6 Then
                     clsAppInfo.IUEBien = .Valor
                  End If

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oImpuesto.Dispose()

      End Try
   End Sub

   Public Sub PlanIdParaLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresaPara As New clsEmpresaPara(clsAppInfo.ConnectString)

      clsAppInfo.PlanCreId = 0

      Try
         With oEmpresaPara
            .SelectFilter = clsEmpresaPara.SelectFilters.All
            .WhereFilter = clsEmpresaPara.WhereFilters.EmpresaId
            .EmpresaId = lngEmpresaId

            If .Find Then
               clsAppInfo.DecimalNro = ToInteger(.DecimalNro)
               clsAppInfo.PlanCreId = ToLong(.PlanCreId)
               clsAppInfo.PlanDebId = ToLong(.PlanDebId)
               clsAppInfo.PlanITId = ToLong(.PlanITId)
               clsAppInfo.PlanITPId = ToLong(.PlanITPId)
               clsAppInfo.PlanITFId = ToLong(.PlanITFId)
               clsAppInfo.PlanIceIehdId = ToLong(.PlanIceIehdId)
               clsAppInfo.PlanIceIehdDifId = ToLong(.PlanIceIehdDifId)
               clsAppInfo.PlanExentoId = ToLong(.PlanExentoId)
               clsAppInfo.PlanDifId = ToLong(.PlanDifId)
               clsAppInfo.PlanAitbId = ToLong(.PlanAitbId)
               clsAppInfo.PlanResId = ToLong(.PlanResId)
               clsAppInfo.PlanCreRetId = ToLong(.PlanCreRetId)
               clsAppInfo.PlanITRetId = ToLong(.PlanITRetId)
               clsAppInfo.PlanIUERetSerId = ToLong(.PlanIUERetSerId)
               clsAppInfo.PlanIUERetBieId = ToLong(.PlanIUERetBieId)

               clsAppInfo.EmpresaGral = ToStr(.EmpresaGral)
               clsAppInfo.TipoHojaId = ToLong(.TipoHojaId)
               clsAppInfo.PlanCtaShow = ToBoolean(.PlanCtaShow)
               clsAppInfo.FechaOpera = ToBoolean(.FechaOpera)
               clsAppInfo.MultipleNro = ToBoolean(.MultipleNro)
               clsAppInfo.SepararExento = ToBoolean(.SepararExento)
               clsAppInfo.CodBarra = ToBoolean(.CodBarra)
               clsAppInfo.AplicarDescuento = ToBoolean(.AplicarDescuento)
               clsAppInfo.ExigirEEFF = ToBoolean(.ExigirEEFF)
               clsAppInfo.ValidarSaldoCajaBanco = ToBoolean(.ValidarSaldoCajaBanco)
               clsAppInfo.AplicarDosificaVend = ToBoolean(.AplicarDosificaVend)
               clsAppInfo.ExigirActAnaAdd = ToBoolean(.ExigirActAnaAdd)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresaPara.Dispose()

      End Try
   End Sub

   Public Function CompParaRowsMaxFind(ByVal lngEmpresaId As Long, ByVal lngGestionId As Long, ByVal lngTipoCompId As Long) As Integer
      Dim oCompPara As New clsCompPara(clsAppInfo.ConnectString)

      Try
         CompParaRowsMaxFind = 0

         With oCompPara
            .SelectFilter = clsCompPara.SelectFilters.All
            .WhereFilter = clsCompPara.WhereFilters.TipoCompId

            .EmpresaId = lngEmpresaId
            .TipoCompId = lngTipoCompId
            .GestionId = lngGestionId
            If .Find Then
               CompParaRowsMaxFind = .RowsMax
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
         oCompPara.Dispose()

      End Try
   End Function

   Public Function OperaFechaHabil(ByVal strFecha As String) As Boolean
      If clsAppInfo.FechaOpera Then
         Dim oOpera As New clsOpera(clsAppInfo.ConnectString)

         Try
            With oOpera
               .SelectFilter = clsOpera.SelectFilters.All
               .WhereFilter = clsOpera.WhereFilters.Fecha
               .AppId = clsAppInfo.AppId
               .GroupId = clsAppInfo.GroupId
               .EmpresaId = clsAppInfo.EmpresaId
               .GestionId = clsAppInfo.GestionId
               .Fecha = strFecha

               If .Find Then
                  OperaFechaHabil = ToBoolean(.Enabled)
               Else
                  OperaFechaHabil = False
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

         Finally
            oOpera.Dispose()
         End Try

      Else
         Return True
      End If
   End Function

   Public Sub SecuritySet(ByRef frmCurrent As Object, ByVal strAppExe As String)
      Dim ctrUno As Control
      Dim oRight As New clsRight(clsAppInfo.ConnectString)

      Try
         With oRight
            .SelectFilter = clsRight.SelectFilters.All
            .WhereFilter = clsRight.WhereFilters.FormName
            .AppExe = strAppExe
            .FormName = frmCurrent.Name
            .GroupId = clsAppInfo.GroupId

            If .Open Then
               Do While .Read
                  For Each ctrUno In frmCurrent.Controls
                     If UCase$(ctrUno.GetType.Name) = UCase$("UIReBar") Then
                        Dim ctrDos As Janus.Windows.UI.CommandBars.UICommand

                        For Each ctrDos In frmCurrent.cdmMain.Commands
                           If UCase$(ctrDos.Key) = UCase$(.CtrlName) Then
                              ctrDos.Visible = BooleamToJanus(.Visible)
                              ctrDos.Enabled = BooleamToJanus(.Enabled)

                              Exit For
                           End If
                        Next
                     End If
                  Next

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, "AppCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oRight.Dispose()

      End Try
   End Sub

   Public Function BooleamToJanus(ByVal bytValue As Byte) As Byte
      If ToBoolean(bytValue) Then
         Return Janus.Windows.UI.InheritableBoolean.True
      Else
         Return Janus.Windows.UI.InheritableBoolean.False
      End If
   End Function

   Public Function JanusToBooleam(ByVal bytValue As Byte) As Byte
      If bytValue = Janus.Windows.UI.InheritableBoolean.True Then
         Return 1
      ElseIf bytValue = Janus.Windows.UI.InheritableBoolean.False Then
         Return 0
      End If
   End Function

   Public Sub SecuritySetTouch(ByRef frmCurrent As Object, ByVal strAppExe As String)
      Dim ctrUno As Control
      Dim oRight As New clsRight(clsAppInfo.ConnectString)

      Try
         With oRight
            .SelectFilter = clsRight.SelectFilters.All
            .WhereFilter = clsRight.WhereFilters.FormName
            .AppExe = strAppExe
            .FormName = frmCurrent.Name
            .GroupId = clsAppInfo.GroupId
            Dim frmName As String = ""
            If .Open Then
               Do While .Read
                  For Each ctrUno In frmCurrent.Controls

                     frmName &= "," & ctrUno.GetType.Name

                     If SecuritySetTouchRec(ctrUno, oRight.CtrlName, oRight) Then
                        Exit For
                     End If

                  Next

                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oRight.Dispose()

      End Try
   End Sub

   Public Function SecuritySetTouchRec(ByRef ctrUno As Object, ByVal strFindControl As String, ByVal oRight As clsRight) As Boolean
      Try
         If UCase$(ctrUno.GetType.Name) = UCase$("UIButton") Then
            Dim ctrDos As Janus.Windows.EditControls.UIButton = CType(ctrUno, Janus.Windows.EditControls.UIButton)
            If ctrDos.Name = strFindControl Then
               ctrUno.Visible = ToBoolean(oRight.Visible)
               ctrUno.Enabled = ToBoolean(oRight.Enabled)

               Return True
            End If

         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UICheckBox") Then
            Dim ctrDos As Janus.Windows.EditControls.UICheckBox = CType(ctrUno, Janus.Windows.EditControls.UICheckBox)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIComboBox") Then
            Dim ctrDos As Janus.Windows.EditControls.UIComboBox = CType(ctrUno, Janus.Windows.EditControls.UIComboBox)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("CheckBox") Then
            Dim ctrDos As System.Windows.Forms.CheckBox = CType(ctrUno, System.Windows.Forms.CheckBox)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("Button") Then
            Dim ctrDos As System.Windows.Forms.Button = CType(ctrUno, System.Windows.Forms.Button)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("ComboBox") Then
            Dim ctrDos As System.Windows.Forms.ComboBox = CType(ctrUno, System.Windows.Forms.ComboBox)
            If ctrDos.Name = strFindControl Then
               ctrDos.Visible = ToBoolean(oRight.Visible)
               ctrDos.Enabled = ToBoolean(oRight.Enabled)
               Return True
            End If
            '----------------  CONTENEDORES -----------------------------------------
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIContainer") Then
            Dim ctrAux As Janus.Windows.UI.Dock.UIPanel = CType(ctrUno, Janus.Windows.UI.Dock.UIPanel)
            For Each ctrDos In ctrAux.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIPanel") Then
            Dim ctrAux As Janus.Windows.UI.Dock.UIPanel = CType(ctrUno, Janus.Windows.UI.Dock.UIPanel)
            For Each ctrDos In ctrAux.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIPanelInnerContainer") Then
            Dim ctrAux As Janus.Windows.UI.Dock.UIPanelInnerContainer = CType(ctrUno, Janus.Windows.UI.Dock.UIPanelInnerContainer)
            For Each ctrDos In ctrAux.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIReBar") Then
            Dim ctrDos As Janus.Windows.UI.CommandBars.UICommand
            For Each ctrDos In ctrUno.cdmMain.Commands
               If UCase$(ctrDos.Key) = UCase$(strFindControl) Then
                  ctrDos.Visible = BooleamToJanus(oRight.Visible)
                  ctrDos.Enabled = BooleamToJanus(oRight.Enabled)
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UITab") Then
            Dim ctrAux As Janus.Windows.UI.Tab.UITab = CType(ctrUno, Janus.Windows.UI.Tab.UITab)
            For Each ctrDos In ctrAux.TabPages
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UITabPage") Then
            Dim ctrAux As Janus.Windows.UI.Tab.UITabPage = CType(ctrUno, Janus.Windows.UI.Tab.UITabPage)
            For Each ctrDos In ctrAux.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         ElseIf UCase$(ctrUno.GetType.Name) = UCase$("UIGroupBox") Then
            'Dim ctrAux As Janus.Windows.UI.Tab.UITabPage = CType(ctrUno, Janus.Windows.UI.Tab.UITabPage)
            For Each ctrDos In ctrUno.Controls
               If SecuritySetTouchRec(ctrDos, strFindControl, oRight) Then
                  Return True
               End If
            Next
         End If

         Return False
      Catch exp As Exception
         Throw exp

      Finally
         oRight.Dispose()

      End Try
   End Function

End Module
