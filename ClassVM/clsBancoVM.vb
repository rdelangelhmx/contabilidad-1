Public Class clsBancoVM
   Public BancoId As Long
   Public EmpresaId As Long
   Public BancoCod As String
   Public BancoDes As String
   Public PlanId As Long
   Public PlanDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef BancoId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And BancoId > 0 Then

         If BancoDes <> "" Then
            strMsg &= "Banco: " & BancoDes & "; "
         End If

         If PlanDes <> "" Then
            strMsg &= "Cuenta Contable: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta Contable: " & PlanDesFind(PlanId) & "; "
         End If

         If BancoCod <> "" Then
            strMsg &= "Código: " & BancoCod & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & BancoId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsBancoVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And BancoId > 0 Then

         If BancoDes <> oVMOld.BancoDes Then
            strMsg &= "Banco: " & BancoDes & "; "
         End If

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta Contable: " & PlanDes & "; "
         ElseIf PlanId <> oVMOld.PlanId Then
            strMsg &= "Cuenta Contable: " & PlanDesFind(PlanId) & "; "
         End If

         If BancoCod <> oVMOld.BancoCod Then
            strMsg &= "Código: " & BancoCod & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & BancoId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If BancoId > 0 Then
            If BancoCod <> "" Then
               strMsg &= "Código: " & BancoCod & "; "
            End If

            If BancoDes <> "" Then
               strMsg &= "Banco: " & BancoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & BancoId & "; " & strMsg)

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
         If BancoId > 0 Then
            If BancoCod <> "" Then
               strMsg &= "Código: " & BancoCod & "; "
            End If

            If BancoDes <> "" Then
               strMsg &= "Banco: " & BancoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & BancoId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   Public Function PlanDesFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      oPlan.PlanId = lngPlanId
      oPlan.FindByPK()
      Return oPlan.PlanDes
   End Function

End Class
