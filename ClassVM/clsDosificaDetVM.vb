Public Class clsDosificaDetVM
   Public DosificaDetId As Long
   Public EmpresaId As Long
   Public DosificaId As Long
   Public NroAutorizacion As String
   Public Orden As Long
   Public TipoActEcoId As Long
   Public TipoActEcoDes As String
   Public ImpTipoActEco As Byte
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef DosificaDetId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And DosificaDetId > 0 Then

         If NroAutorizacion <> "" Then
            strMsg &= "Nro Autorizacion: " & NroAutorizacion & "; "
         ElseIf DosificaId > 0 Then
            strMsg &= "Nro Autorizacion: " & NroAutorizacionFind(DosificaId) & "; "
         End If

         If TipoActEcoDes <> "" Then
            strMsg &= "Act. Economica: " & TipoActEcoDes & "; "
         End If

         If Orden <> 0 Then
            strMsg &= "Orden: " & Orden & "; "
         End If

         If ImpTipoActEco <> 0 Then
            strMsg &= "Imprimir Act. Económica: " & ToByteStr(ImpTipoActEco) & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & DosificaDetId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsDosificaDetVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And DosificaDetId > 0 Then

         If TipoActEcoDes <> oVMOld.TipoActEcoDes Then
            strMsg &= "Act. Economica: " & TipoActEcoDes & "; "
         End If

         If Orden <> oVMOld.Orden Then
            strMsg &= "Orden: " & Orden & "; "
         End If

         If ImpTipoActEco <> oVMOld.ImpTipoActEco Then
            strMsg &= "Imprimir Act. Económica: " & ToByteStr(ImpTipoActEco) & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & DosificaDetId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If DosificaDetId > 0 Then

            If NroAutorizacion <> "" Then
               strMsg &= "Nro Autorizacion: " & NroAutorizacion & "; "
            ElseIf DosificaId > 0 Then
               strMsg &= "Nro Autorizacion: " & NroAutorizacionFind(DosificaId) & "; "
            End If

            If TipoActEcoDes <> "" Then
               strMsg &= "Act. Economica: " & TipoActEcoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & DosificaDetId & "; " & strMsg)

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
         If DosificaDetId > 0 Then

            If NroAutorizacion <> "" Then
               strMsg &= "Nro Autorizacion: " & NroAutorizacion & "; "
            ElseIf DosificaId > 0 Then
               strMsg &= "Nro Autorizacion: " & NroAutorizacionFind(DosificaId) & "; "
            End If

            If TipoActEcoDes <> "" Then
               strMsg &= "Act. Economica: " & TipoActEcoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & DosificaDetId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   Public Function NroAutorizacionFind(ByVal lngDosificaId As Long) As String
      Dim oDosifica As New clsDosifica(clsAppInfo.ConnectString)
      oDosifica.DosificaId = lngDosificaId
      oDosifica.FindByPK()
      Return oDosifica.NroAutorizacion
   End Function
End Class
