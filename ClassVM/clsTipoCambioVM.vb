Public Class clsTipoCambioVM
   Public TipoCambioId As Long
   Public Fecha As String
   Public Valor As Decimal
   Public UFV As Decimal

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef TipoCambioId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And TipoCambioId > 0 Then

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If Valor <> 0 Then
            strMsg &= "Tipo de Cambio: " & ToDecStr(Valor) & "; "
         End If

         If UFV <> 0 Then
            strMsg &= "U.F.V.: " & ToDecStrCinco(UFV) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & TipoCambioId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsTipoCambioVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And TipoCambioId > 0 Then

         If Fecha <> oVMOld.Fecha Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If Valor <> oVMOld.Valor Then
            strMsg &= "Tipo de Cambio: " & ToDecStr(Valor) & "; "
         End If

         If UFV <> oVMOld.UFV Then
            strMsg &= "U.F.V.: " & ToDecStrCinco(UFV) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & TipoCambioId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If TipoCambioId > 0 Then

            If Fecha <> "" Then
               strMsg &= "Fecha: " & Fecha & "; "
            End If

            If Valor <> 0 Then
               strMsg &= "Tipo de Cambio: " & ToDecStr(Valor) & "; "
            End If

            If UFV <> 0 Then
               strMsg &= "U.F.V.: " & ToDecStrCinco(UFV) & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & TipoCambioId & "; " & strMsg)

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
         If TipoCambioId > 0 Then
            If Fecha <> "" Then
               strMsg &= "Fecha: " & Fecha & "; "
            End If

            If Valor <> 0 Then
               strMsg &= "Tipo de Cambio: " & ToDecStr(Valor) & "; "
            End If

            If UFV <> 0 Then
               strMsg &= "U.F.V.: " & ToDecStrCinco(UFV) & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & TipoCambioId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
