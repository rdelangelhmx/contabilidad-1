Public Class clsAduanaVM
   Public AduanaId As Long
   Public AduanaDes As String
   Public AduanaNIT As String
   Public Direccion As String
   Public Telefono As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef AduanaId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And AduanaId > 0 Then

         If AduanaNIT <> "" Then
            strMsg &= "NIT: " & AduanaNIT & "; "
         End If

         If AduanaDes <> "" Then
            strMsg &= "Agencia: " & AduanaDes & "; "
         End If

         If Direccion <> "" Then
            strMsg &= "Dirección: " & Direccion & "; "
         End If

         If Telefono <> "" Then
            strMsg &= "Telefono: " & Telefono & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & AduanaId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsAduanaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And AduanaId > 0 Then

         If AduanaNIT <> oVMOld.AduanaNIT Then
            strMsg &= "NIT: " & AduanaNIT & "; "
         End If

         If AduanaDes <> oVMOld.AduanaDes Then
            strMsg &= "Aduana: " & AduanaDes & "; "
         End If

         If Direccion <> oVMOld.Direccion Then
            strMsg &= "Dirección: " & Direccion & "; "
         End If

         If Telefono <> oVMOld.Telefono Then
            strMsg &= "Telefono: " & Telefono & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & AduanaId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If AduanaId > 0 Then

            If AduanaNIT <> "" Then
               strMsg &= "NIT: " & AduanaNIT & "; "
            End If

            If AduanaDes <> "" Then
               strMsg &= "Aduana: " & AduanaDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & AduanaId & "; " & strMsg)

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
         If AduanaId > 0 Then

            If AduanaNIT <> "" Then
               strMsg &= "NIT: " & AduanaNIT & "; "
            End If

            If AduanaDes <> "" Then
               strMsg &= "Aduana: " & AduanaDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & AduanaId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
