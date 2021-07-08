Public Class clsCentroCostoDetVM
   Public CentroCostoDetId As Long
   Public EmpresaId As Long
   Public CentroCostoId As Long
   Public CentroCostoDes As String
   Public CentroCostoDetDes As String
   Public CentroCostoDetCod As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef CentroCostoDetId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CentroCostoDetId > 0 Then

         If CentroCostoDetCod <> "" Then
            strMsg &= "Código: " & CentroCostoDetCod & "; "
         End If

         If CentroCostoDetDes <> "" Then
            strMsg &= "Actividad: " & CentroCostoDetDes & "; "
         End If

         If CentroCostoDes <> "" Then
            strMsg &= "Centro Costo: " & CentroCostoDes & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CentroCostoDetId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCentroCostoDetVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CentroCostoDetId > 0 Then

         If CentroCostoDetCod <> oVMOld.CentroCostoDetCod Then
            strMsg &= "Código: " & CentroCostoDetCod & "; "
         End If

         If CentroCostoDetDes <> oVMOld.CentroCostoDetDes Then
            strMsg &= "Actividad: " & CentroCostoDetDes & "; "
         End If

         If CentroCostoDes <> oVMOld.CentroCostoDes Then
            strMsg &= "Centro Costo: " & CentroCostoDes & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CentroCostoDetId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If CentroCostoDetId > 0 Then

            If CentroCostoDetCod <> "" Then
               strMsg &= "Código: " & CentroCostoDetCod & "; "
            End If

            If CentroCostoDetDes <> "" Then
               strMsg &= "Actividad: " & CentroCostoDetDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & CentroCostoDetId & "; " & strMsg)

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
         If CentroCostoDetId > 0 Then

            If CentroCostoDetCod <> "" Then
               strMsg &= "Código: " & CentroCostoDetCod & "; "
            End If

            If CentroCostoDetDes <> "" Then
               strMsg &= "Actividad: " & CentroCostoDetDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & CentroCostoDetId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
