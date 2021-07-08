Public Class clsSucursalVM
   Public SucursalId As Long
   Public EmpresaId As Long
   Public SucursalDes As String
   Public SucursalCod As String
   Public Direccion As String
   Public CiudadId As Long
   Public CiudadDes As String
   Public Telefono As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef SucursalId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And SucursalId > 0 Then

         If SucursalCod <> "" Then
            strMsg &= "Código: " & SucursalCod & "; "
         End If

         If SucursalDes <> "" Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         End If

         If Direccion <> "" Then
            strMsg &= "Dirección: " & Direccion & "; "
         End If

         If CiudadDes <> "" Then
            strMsg &= "Ciudad: " & CiudadDes & "; "
         End If

         If Telefono <> "" Then
            strMsg &= "Telefono: " & Telefono & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & SucursalId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsSucursalVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And SucursalId > 0 Then

         If SucursalCod <> oVMOld.SucursalCod Then
            strMsg &= "Código: " & SucursalCod & "; "
         End If

         If SucursalDes <> oVMOld.SucursalDes Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         End If

         If Direccion <> oVMOld.Direccion Then
            strMsg &= "Dirección: " & Direccion & "; "
         End If

         If CiudadDes <> oVMOld.CiudadDes Then
            strMsg &= "Ciudad: " & CiudadDes & "; "
         End If

         If Telefono <> oVMOld.Telefono Then
            strMsg &= "Telefono: " & Telefono & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & SucursalId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If SucursalId > 0 Then
            If SucursalCod <> "" Then
               strMsg &= "Código: " & SucursalCod & "; "
            End If

            If SucursalDes <> "" Then
               strMsg &= "Sucursal: " & SucursalDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & SucursalId & "; " & strMsg)

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
         If SucursalId > 0 Then
            If SucursalCod <> "" Then
               strMsg &= "Código: " & SucursalCod & "; "
            End If

            If SucursalDes <> "" Then
               strMsg &= "Sucursal: " & SucursalDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & SucursalId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
