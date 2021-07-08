Public Class clsPaisVM
   Public PaisId As Long
   Public PaisCod As String
   Public PaisDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef PaisId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PaisId > 0 Then

         If PaisCod <> "" Then
            strMsg &= "Código: " & PaisCod & "; "
         End If

         If PaisDes <> "" Then
            strMsg &= "País: " & PaisDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PaisId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsPaisVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PaisId > 0 Then

         If PaisCod <> oVMOld.PaisCod Then
            strMsg &= "Código: " & PaisCod & "; "
         End If

         If PaisDes <> oVMOld.PaisDes Then
            strMsg &= "País: " & PaisDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PaisId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If PaisId > 0 Then

            If PaisCod <> "" Then
               strMsg &= "Código: " & PaisCod & "; "
            End If

            If PaisDes <> "" Then
               strMsg &= "País: " & PaisDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & PaisId & "; " & strMsg)

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
         If PaisId > 0 Then

            If PaisCod <> "" Then
               strMsg &= "Código: " & PaisCod & "; "
            End If

            If PaisDes <> "" Then
               strMsg &= "País: " & PaisDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & PaisId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
