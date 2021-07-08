Public Class clsConciliaDiferenciaVM
   Public ConciliaDiferenciaId As Long
   Public PlanId As Long
   Public PlanDes As String
   Public Fecha As String
   Public Descripcion As String
   Public Monto As Decimal

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef ConciliaDiferenciaId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ConciliaDiferenciaId > 0 Then

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If Descripcion <> "" Then
            strMsg &= "Descripción: " & Descripcion & "; "
         End If

         If Monto <> 0 Then
            strMsg &= "Monto: " & ToDecStr(Monto) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ConciliaDiferenciaId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsConciliaDiferenciaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ConciliaDiferenciaId > 0 Then

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> oVMOld.PlanId Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If Fecha <> oVMOld.Fecha Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If Descripcion <> oVMOld.Descripcion Then
            strMsg &= "Descripción: " & Descripcion & "; "
         End If

         If Monto <> oVMOld.Monto Then
            strMsg &= "Monto: " & ToDecStr(Monto) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ConciliaDiferenciaId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ConciliaDiferenciaId > 0 Then

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If Descripcion <> "" Then
            strMsg &= "Descripción: " & Descripcion & "; "
         End If

         If Monto <> 0 Then
            strMsg &= "Monto: " & ToDecStr(Monto) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & ConciliaDiferenciaId & "; " & strMsg)

            ToDeleteOpe = True
         Else
            ToDeleteOpe = False
         End If
      End If
   End Function

   Public Function ToShowOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ConciliaDiferenciaId > 0 Then

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If Descripcion <> "" Then
            strMsg &= "Descripción: " & Descripcion & "; "
         End If

         If Monto <> 0 Then
            strMsg &= "Monto: " & ToDecStr(Monto) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & ConciliaDiferenciaId & "; " & strMsg)

            ToShowOpe = True
         Else
            ToShowOpe = False
         End If
      End If
   End Function

   Private Function TipoCompDesFind(ByVal lngCompId As Long) As String
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      oTipoComp.TipoCompId = lngCompId
      oTipoComp.FindByPK()
      Return oTipoComp.TipoCompDes
   End Function

   Private Function PlanDesFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      oPlan.PlanId = lngPlanId
      oPlan.FindByPK()
      Return oPlan.PlanDes
   End Function

   Private Function CompNroFind(ByVal lngCompId As Long) As String
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      oComp.CompId = lngCompId
      oComp.FindByPK()
      Return oComp.CompNro
   End Function

End Class
