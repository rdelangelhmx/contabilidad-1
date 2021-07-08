Public Class clsChequeImpVM
   Public ChequeImpId As Long
   Public EmpresaId As Long
   Public ChequeId As Long
   Public PlanId As Long
   Public PlanDes As String
   Public BancoCta As String
   Public CtrlName As String
   Public CtrlLeft As Long
   Public CtrlTop As Long
   Public CtrlWidth As Long
   Public CtrlHeight As Long
   Public CtrlVisible As Byte
   Public CtrlMaxLength As Long

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef ChequeImpId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ChequeImpId > 0 Then

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If BancoCta <> "" Then
            strMsg &= "Cuenta Banco: " & BancoCta & "; "
         End If

         If CtrlName <> "" Then
            strMsg &= "Nombre: " & CtrlName & "; "
         End If

         If CtrlLeft <> 0 Then
            strMsg &= "Izquierda: " & CtrlLeft & "; "
         End If

         If CtrlTop <> 0 Then
            strMsg &= "Superior: " & CtrlTop & "; "
         End If

         If CtrlWidth <> 0 Then
            strMsg &= "Anchura: " & CtrlWidth & "; "
         End If

         If CtrlHeight <> 0 Then
            strMsg &= "Altura: " & CtrlHeight & "; "
         End If

         If CtrlVisible <> 0 Then
            strMsg &= "Visible: " & ToByteStr(CtrlVisible) & "; "
         End If

         If CtrlMaxLength <> 0 Then
            strMsg &= "Tam. Max.: " & CtrlMaxLength & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ChequeImpId & "; " & "; Nombre: " & CtrlName & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsChequeImpVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ChequeImpId > 0 Then

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If BancoCta <> oVMOld.BancoCta Then
            strMsg &= "Cuenta Banco: " & BancoCta & "; "
         End If

         If CtrlName <> oVMOld.CtrlName Then
            strMsg &= "Nombre: " & CtrlName & "; "
         End If

         If CtrlLeft <> oVMOld.CtrlLeft Then
            strMsg &= "Izquierda: " & CtrlLeft & "; "
         End If

         If CtrlTop <> oVMOld.CtrlTop Then
            strMsg &= "Superior: " & CtrlTop & "; "
         End If

         If CtrlWidth <> oVMOld.CtrlWidth Then
            strMsg &= "Anchura: " & CtrlWidth & "; "
         End If

         If CtrlHeight <> oVMOld.CtrlHeight Then
            strMsg &= "Altura: " & CtrlHeight & "; "
         End If

         If CtrlVisible <> oVMOld.CtrlVisible Then
            strMsg &= "Visible: " & ToByteStr(CtrlVisible) & "; "
         End If

         If CtrlMaxLength <> oVMOld.CtrlMaxLength Then
            strMsg &= "Tam. Max.: " & CtrlMaxLength & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ChequeImpId & "; Nombre: " & CtrlName & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If ChequeImpId > 0 Then

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            End If

            If BancoCta <> "" Then
               strMsg &= "Cuenta Banco: " & BancoCta & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & ChequeImpId & "; " & "; Nombre: " & CtrlName & "; " & strMsg)

               ToDeleteOpe = True
            Else
               ToDeleteOpe = False
            End If
         End If
      End If
   End Function

   Public Function ToShowOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If ChequeImpId > 0 Then

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            End If

            If BancoCta <> "" Then
               strMsg &= "Cuenta Banco: " & BancoCta & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & ChequeImpId & "; " & "; Nombre: " & CtrlName & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   Public Function PlanDesFind(ByVal lngPlanId As Long)
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      oPlan.PlanId = lngPlanId
      oPlan.FindByPK()
      Return oPlan.PlanDes
   End Function

End Class
