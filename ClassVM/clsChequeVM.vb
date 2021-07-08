Public Class clsChequeVM
   Public ChequeId As Long
   Public EmpresaId As Long
   Public PlanId As Long
   Public PlanDes As String
   Public BancoId As Long
   Public BancoDes As String
   Public BancoCta As String
   Public OrientacionId As Long
   Public ChequeWidth As Long
   Public ChequeHeight As Long

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef ChequeId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ChequeId > 0 Then

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If BancoDes <> "" Then
            strMsg &= "Banco: " & BancoDes & "; "
         End If

         If BancoCta <> "" Then
            strMsg &= "Cuenta Banco: " & BancoCta & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ChequeId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsChequeVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ChequeId > 0 Then

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If BancoDes <> oVMOld.BancoDes Then
            strMsg &= "Banco: " & BancoDes & "; "
         End If

         If BancoCta <> oVMOld.BancoCta Then
            strMsg &= "Cuenta Banco: " & BancoCta & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ChequeId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If ChequeId > 0 Then

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            End If

            If BancoDes <> "" Then
               strMsg &= "Banco: " & BancoDes & "; "
            End If

            If BancoCta <> "" Then
               strMsg &= "Cuenta Banco: " & BancoCta & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & ChequeId & "; " & strMsg)

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
         If ChequeId > 0 Then

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            End If

            If BancoDes <> "" Then
               strMsg &= "Banco: " & BancoDes & "; "
            End If

            If BancoCta <> "" Then
               strMsg &= "Cuenta Banco: " & BancoCta & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & ChequeId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
