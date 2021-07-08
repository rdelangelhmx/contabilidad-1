Public Class clsReciboParaVM
   Public ReciboParaId As Long
   Public EmpresaId As Long
   Public GestionId As Long
   Public Gestion As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public NroIni As Long
   Public NroActual As Long
   Public Firma As String
   Public TipoHojaId As Long
   Public TipoHojaDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsReciboParaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ReciboParaId > 0 Then

         If Gestion <> oVMOld.Gestion Then
            strMsg &= "Gestión: " & Gestion & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         End If

         If NroIni <> oVMOld.NroIni Then
            strMsg &= "Nro Inicial: " & NroIni & "; "
         End If

         If NroActual <> oVMOld.NroActual Then
            strMsg &= "Nro Actual: " & NroActual & "; "
         End If

         If Firma <> oVMOld.Firma Then
            strMsg &= "Se cambio la Firma; "
         End If

         If TipoHojaDes <> oVMOld.TipoHojaDes Then
            strMsg &= "Tamaño Hoja: " & TipoHojaDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ReciboParaId & ", " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If ReciboParaId > 0 Then

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & ReciboParaId & "; " & strMsg)

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
         If ReciboParaId > 0 Then

            If Gestion <> 0 Then
               strMsg &= "Gestión: " & Gestion & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo: " & TipoCompDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & ReciboParaId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
