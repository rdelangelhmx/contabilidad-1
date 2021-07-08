Public Class clsGestionVM
   Public GestionId As Long
   Public EmpresaId As Long
   Public Gestion As Long
   Public FechaIni As String
   Public FechaFin As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef GestionId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And Gestion > 0 Then

         If Gestion <> 0 Then
            strMsg &= "Gestión: " & Gestion & "; "
         End If

         If FechaIni <> "" Then
            strMsg &= "Fecha Inicial: " & FechaIni & "; "
         End If

         If FechaFin <> "" Then
            strMsg &= "Fecha Final: " & FechaFin & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & GestionId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsGestionVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And Gestion > 0 Then

         If Gestion <> oVMOld.Gestion Then
            strMsg &= "Gestión: " & Gestion & "; "
         End If

         If FechaIni <> oVMOld.FechaIni Then
            strMsg &= "Fecha Inicial: " & FechaIni & "; "
         End If

         If FechaFin <> oVMOld.FechaFin Then
            strMsg &= "Fecha Final: " & FechaFin & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & GestionId & ", " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If GestionId > 0 Then

            If Gestion <> 0 Then
               strMsg &= "Gestión: " & Gestion & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & GestionId & "; " & strMsg)

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
         If GestionId > 0 Then

            If Gestion <> 0 Then
               strMsg &= "Gestión: " & Gestion & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & GestionId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
