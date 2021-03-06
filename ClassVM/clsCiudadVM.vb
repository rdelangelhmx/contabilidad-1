Public Class clsCiudadVM
   Public CiudadId As Long
   Public CiudadCod As String
   Public CiudadDes As String
   Public PaisId As Long
   Public PaisDes As String
   Public DepartamentoId As Long
   Public DepartamentoDes As String
   Public ProvinciaId As Long
   Public ProvinciaDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef CiudadId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CiudadId > 0 Then

         If PaisDes <> "" Then
            strMsg &= "País: " & PaisDes & "; "
         End If

         If DepartamentoDes <> "" Then
            strMsg &= "Departamento: " & DepartamentoDes & "; "
         End If

         If ProvinciaDes <> "" Then
            strMsg &= "Provincia: " & ProvinciaDes & "; "
         End If

         If CiudadCod <> "" Then
            strMsg &= "Código: " & CiudadCod & "; "
         End If

         If CiudadDes <> "" Then
            strMsg &= "Ciudad: " & CiudadDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CiudadId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCiudadVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CiudadId > 0 Then

         If PaisDes <> oVMOld.PaisDes Then
            strMsg &= "País: " & PaisDes & "; "
         End If

         If DepartamentoDes <> oVMOld.DepartamentoDes Then
            strMsg &= "Departamento: " & DepartamentoDes & "; "
         End If

         If ProvinciaDes <> oVMOld.ProvinciaDes Then
            strMsg &= "Provincia: " & ProvinciaDes & "; "
         End If

         If CiudadCod <> oVMOld.CiudadCod Then
            strMsg &= "Código: " & CiudadCod & "; "
         End If

         If CiudadDes <> oVMOld.CiudadDes Then
            strMsg &= "Ciudad: " & CiudadDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CiudadId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If CiudadId > 0 Then

            If CiudadCod <> "" Then
               strMsg &= "Código: " & CiudadCod & "; "
            End If

            If CiudadDes <> "" Then
               strMsg &= "Ciudad: " & CiudadDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & CiudadId & "; " & strMsg)

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
         If CiudadId > 0 Then

            If CiudadCod <> "" Then
               strMsg &= "Código: " & CiudadCod & "; "
            End If

            If CiudadDes <> "" Then
               strMsg &= "Ciudad: " & CiudadDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & CiudadId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
