Public Class clsCompParaMesVM
   Public CompParaMesId As Long
   Public EmpresaId As Long
   Public GestionId As Long
   Public Gestion As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public MesId As Long
   Public MesDes As String
   Public NroIni As Long
   Public NroActual As Long
   Public NroIniFis As Long
   Public NroActualFis As Long

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompParaMesId > 0 Then

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompParaMesId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCompParaMesVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompParaMesId > 0 Then

         If Gestion <> oVMOld.Gestion Then
            strMsg &= "Gestión: " & Gestion & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         End If

         If MesDes <> oVMOld.MesDes Then
            strMsg &= "Mes: " & MesDes & "; "
         End If

         If NroIni <> oVMOld.NroIni Then
            strMsg &= "Nro Inicial: " & NroIni & "; "
         End If

         If NroActual <> oVMOld.NroActual Then
            strMsg &= "Nro Actual: " & NroActual & "; "
         End If

         If NroIniFis <> oVMOld.NroIniFis Then
            strMsg &= "Nro Inicial 2.: " & NroIniFis & "; "
         End If

         If NroActualFis <> oVMOld.NroActualFis Then
            strMsg &= "Nro Actual 2: " & NroActualFis & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompParaMesId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If CompParaMesId > 0 Then

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & CompParaMesId & "; " & strMsg)

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
         If CompParaMesId > 0 Then

            If Gestion <> 0 Then
               strMsg &= "Gestión: " & Gestion & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo: " & TipoCompDes & "; "
            End If

            If MesDes <> "" Then
               strMsg &= "Mes: " & MesDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & CompParaMesId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
