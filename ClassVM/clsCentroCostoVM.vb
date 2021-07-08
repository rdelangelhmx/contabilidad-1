Public Class clsCentroCostoVM
   Public CentroCostoId As Long
   Public EmpresaId As Long
   Public CentroCostoDes As String
   Public CentroCostoCod As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef CentroCostoId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CentroCostoId > 0 Then

         If CentroCostoCod <> "" Then
            strMsg &= "Código: " & CentroCostoCod & "; "
         End If

         If CentroCostoDes <> "" Then
            strMsg &= "Centro Costo: " & CentroCostoDes & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CentroCostoId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCentroCostoVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CentroCostoId > 0 Then

         If CentroCostoCod <> oVMOld.CentroCostoCod Then
            strMsg &= "Código: " & CentroCostoCod & "; "
         End If

         If CentroCostoDes <> oVMOld.CentroCostoDes Then
            strMsg &= "Centro Costo: " & CentroCostoDes & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CentroCostoId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If CentroCostoId > 0 Then

            If CentroCostoCod <> "" Then
               strMsg &= "Código: " & CentroCostoCod & "; "
            End If

            If CentroCostoDes <> "" Then
               strMsg &= "Centro Costo: " & CentroCostoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & CentroCostoId & "; " & strMsg)

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
         If CentroCostoId > 0 Then

            If CentroCostoCod <> "" Then
               strMsg &= "Código: " & CentroCostoCod & "; "
            End If

            If CentroCostoDes <> "" Then
               strMsg &= "Centro Costo: " & CentroCostoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & CentroCostoId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
