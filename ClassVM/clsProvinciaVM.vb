Public Class clsProvinciaVM
   Public ProvinciaId As Long
   Public ProvinciaCod As String
   Public ProvinciaDes As String
   Public PaisId As Long
   Public PaisDes As String
   Public DepartamentoId As Long
   Public DepartamentoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef ProvinciaId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ProvinciaId > 0 Then

         If PaisDes <> "" Then
            strMsg &= "País: " & PaisDes & "; "
         End If

         If DepartamentoDes <> "" Then
            strMsg &= "Departamento: " & DepartamentoDes & "; "
         End If

         If ProvinciaCod <> "" Then
            strMsg &= "Código: " & ProvinciaCod & "; "
         End If

         If ProvinciaDes <> "" Then
            strMsg &= "Provincia: " & ProvinciaDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ProvinciaId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsProvinciaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ProvinciaId > 0 Then

         If PaisDes <> oVMOld.PaisDes Then
            strMsg &= "País: " & PaisDes & "; "
         End If

         If DepartamentoDes <> oVMOld.DepartamentoDes Then
            strMsg &= "Departamento: " & DepartamentoDes & "; "
         End If

         If ProvinciaCod <> oVMOld.ProvinciaCod Then
            strMsg &= "Código: " & ProvinciaCod & "; "
         End If

         If ProvinciaDes <> oVMOld.ProvinciaDes Then
            strMsg &= "Provincia: " & ProvinciaDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ProvinciaId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If ProvinciaId > 0 Then

            If ProvinciaCod <> "" Then
               strMsg &= "Código: " & ProvinciaCod & "; "
            End If

            If ProvinciaDes <> "" Then
               strMsg &= "Provincia: " & ProvinciaDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & ProvinciaId & "; " & strMsg)

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
         If ProvinciaId > 0 Then

            If ProvinciaCod <> "" Then
               strMsg &= "Código: " & ProvinciaCod & "; "
            End If

            If ProvinciaDes <> "" Then
               strMsg &= "Provincia: " & ProvinciaDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & ProvinciaId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
