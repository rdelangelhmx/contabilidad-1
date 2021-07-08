Public Class clsImpuestoVM
   Public ImpuestoId As Long
   Public ImpuestoDes As String
   Public Valor As Decimal

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef ImpuestoId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ImpuestoId > 0 Then

         If ImpuestoDes <> "" Then
            strMsg &= "Impuesto: " & ImpuestoDes & "; "
         End If

         If Valor <> 0 Then
            strMsg &= "Valor: " & Valor & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ImpuestoId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsImpuestoVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ImpuestoId > 0 Then

         If ImpuestoDes <> oVMOld.ImpuestoDes Then
            strMsg &= "Impuesto: " & ImpuestoDes & "; "
         End If

         If Valor <> oVMOld.Valor Then
            strMsg &= "Valor: " & Valor & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ImpuestoId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If ImpuestoId > 0 Then

            If ImpuestoDes <> "" Then
               strMsg &= "Impuesto: " & ImpuestoDes & "; "
            End If

            If Valor <> 0 Then
               strMsg &= "Valor: " & Valor & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & ImpuestoId & "; " & strMsg)

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
         If ImpuestoId > 0 Then

            If ImpuestoDes <> "" Then
               strMsg &= "Impuesto: " & ImpuestoDes & "; "
            End If

            If Valor <> 0 Then
               strMsg &= "Valor: " & Valor & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & ImpuestoId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
