Public Class clsCompDetConciliaVM
   Public CompDetId As Long
   Public CompId As Long
   Public CompNro As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public Fecha As String
   Public PlanId As Long
   Public PlanDes As String
   Public FechaCon As String
   Public Concilia As Byte

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef CompDetId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompDetId > 0 Then

         If CompNro <> 0 Then
            strMsg &= "Nro. Comp: " & CompNro & "; "
         ElseIf CompId <> 0 Then
            strMsg &= "Nro. Comp: " & CompNroFind(CompId) & "; "
         End If

         If TipoCompDes <> "" Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         ElseIf TipoCompId <> 0 Then
            strMsg &= "Tipo: " & TipoCompDesFind(TipoCompId) & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If FechaCon <> "" Then
            strMsg &= "Fecha Conciliacion: " & FechaCon & "; "
         End If

         If Concilia <> 0 Then
            strMsg &= "Concilia: " & ToByteStr(Concilia) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompDetId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & CompDetId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCompDetConciliaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompDetId > 0 Then

         If CompNro <> oVMOld.CompNro Then
            strMsg &= "Nro. Comp: " & CompNro & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         End If

         If Fecha <> oVMOld.Fecha Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If FechaCon <> oVMOld.FechaCon Then
            strMsg &= "Fecha Conciliacion: " & FechaCon & "; "
         End If

         If Concilia <> oVMOld.Concilia Then
            strMsg &= "Concilia: " & ToByteStr(Concilia) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompDetId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & CompDetId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompDetId > 0 Then

         If CompNro <> 0 Then
            strMsg &= "Nro. Comp: " & CompNro & "; "
         ElseIf CompId <> 0 Then
            strMsg &= "Nro. Comp: " & CompNroFind(CompId) & "; "
         End If

         If TipoCompDes <> "" Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         ElseIf TipoCompId <> 0 Then
            strMsg &= "Tipo: " & TipoCompDesFind(TipoCompId) & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If FechaCon <> "" Then
            strMsg &= "Fecha Conciliacion: " & FechaCon & "; "
         End If

         If Concilia <> 0 Then
            strMsg &= "Concilia: " & ToByteStr(Concilia) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & CompDetId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, clsTipoOpera.ELIMINA, 0, "", "Id: " & CompDetId & "; " & strMsg)

            ToDeleteOpe = True
         Else
            ToDeleteOpe = False
         End If
      End If
   End Function

   Public Function ToShowOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompDetId > 0 Then

         If CompNro <> 0 Then
            strMsg &= "Nro. Comp: " & CompNro & "; "
         ElseIf CompId <> 0 Then
            strMsg &= "Nro. Comp: " & CompNroFind(CompId) & "; "
         End If

         If TipoCompDes <> "" Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         ElseIf TipoCompId <> 0 Then
            strMsg &= "Tipo: " & TipoCompDesFind(TipoCompId) & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If FechaCon <> "" Then
            strMsg &= "Fecha Conciliacion: " & FechaCon & "; "
         End If

         If Concilia <> 0 Then
            strMsg &= "Concilia: " & ToByteStr(Concilia) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & CompDetId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, clsTipoOpera.CONSULTA, 0, "", "Id: " & CompDetId & "; " & strMsg)

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
