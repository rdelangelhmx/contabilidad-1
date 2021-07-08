Public Class clsRegRucVM
   Public RegRucId As Long
   Public RegRucDes As String
   Public NroRuc As String
   Public PlanId As Long
   Public PlanDes As String
   Public NroAutorizacion As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef RegRucId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And RegRucId > 0 Then

         If NroRuc <> "" Then
            strMsg &= "NIT: " & NroRuc & "; "
         End If

         If RegRucDes <> "" Then
            strMsg &= "Razón Social: " & RegRucDes & "; "
         End If

         If NroAutorizacion <> "" Then
            strMsg &= "Nro Autorización: " & NroAutorizacion & "; "
         End If

         If PlanDes <> "" Then
            strMsg &= "Cta. Contable: " & PlanDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & RegRucId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsRegRucVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And RegRucId > 0 Then

         If NroRuc <> oVMOld.NroRuc Then
            strMsg &= "NIT: " & NroRuc & "; "
         End If

         If RegRucDes <> oVMOld.RegRucDes Then
            strMsg &= "Razón Social: " & RegRucDes & "; "
         End If

         If NroAutorizacion <> oVMOld.NroAutorizacion Then
            strMsg &= "Nro Autorización: " & NroAutorizacion & "; "
         End If

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cta. Contable: " & PlanDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & RegRucId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If RegRucId > 0 Then

            If NroRuc <> "" Then
               strMsg &= "NIT: " & NroRuc & "; "
            End If

            If RegRucDes <> "" Then
               strMsg &= "Razón Social: " & RegRucDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & RegRucId & "; " & strMsg)

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
         If RegRucId > 0 Then

            If NroRuc <> "" Then
               strMsg &= "NIT: " & NroRuc & "; "
            End If

            If RegRucDes <> "" Then
               strMsg &= "Razón Social: " & RegRucDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & RegRucId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
