Public Class clsDepartamentoVM
   Public DepartamentoId As Long
   Public DepartamentoCod As String
   Public DepartamentoDes As String
   Public PaisId As Long
   Public PaisDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef DepartamentoId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And DepartamentoId > 0 Then

         If PaisDes <> "" Then
            strMsg &= "País: " & PaisDes & "; "
         End If

         If DepartamentoCod <> "" Then
            strMsg &= "Código: " & DepartamentoCod & "; "
         End If

         If DepartamentoDes <> "" Then
            strMsg &= "Departamento: " & DepartamentoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & DepartamentoId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsDepartamentoVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And DepartamentoId > 0 Then

         If PaisDes <> oVMOld.PaisDes Then
            strMsg &= "País: " & PaisDes & "; "
         End If

         If DepartamentoCod <> oVMOld.DepartamentoCod Then
            strMsg &= "Código: " & DepartamentoCod & "; "
         End If

         If DepartamentoDes <> oVMOld.DepartamentoDes Then
            strMsg &= "Departamento: " & DepartamentoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & DepartamentoId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If DepartamentoId > 0 Then

            If DepartamentoCod <> "" Then
               strMsg &= "Código: " & DepartamentoCod & "; "
            End If

            If DepartamentoDes <> "" Then
               strMsg &= "Departamento: " & DepartamentoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & DepartamentoId & "; " & strMsg)

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
         If DepartamentoId > 0 Then

            If DepartamentoCod <> "" Then
               strMsg &= "Código: " & DepartamentoCod & "; "
            End If

            If DepartamentoDes <> "" Then
               strMsg &= "Departamento: " & DepartamentoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & DepartamentoId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
