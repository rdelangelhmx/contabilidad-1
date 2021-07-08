Public Class clsPlanVM
   Public PlanId As Long
   Public EmpresaId As Long
   Public PlanDes As String
   Public PlanCta As String
   Public EsAna As Byte
   Public PlanPadreId As Long
   Public PlanPadreDes As String
   Public Orden As Long
   Public Nivel As Long
   Public TipoPlanId As Long
   Public TipoPlanDes As String
   Public TipoGrupoId As Long
   Public TipoGrupoDes As String
   Public MonedaId As Long
   Public MonedaDes As String
   Public TieneAnaAdd As Byte
   Public MostrarAnaAdd As Byte
   Public SucCCOId As Byte
   Public SucCCODes As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef PlanId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PlanId > 0 Then

         If PlanCta <> "" Then
            strMsg &= "Código Cuenta: " & PlanCta & "; "
         End If

         If PlanDes <> "" Then
            strMsg &= "Descripción: " & PlanDes & "; "
         End If

         If EsAna <> 0 Then
            strMsg &= "Cuenta Analítico: " & ToByteStr(EsAna) & "; "
         End If

         If PlanPadreDes <> "" Then
            strMsg &= "Cuenta Padre: " & PlanPadreDes & "; "
         End If

         If Orden <> 0 Then
            strMsg &= "Orden: " & Orden & "; "
         End If

         If Nivel <> 0 Then
            strMsg &= "Nivel: " & Nivel & "; "
         End If

         If TipoPlanDes <> "" Then
            strMsg &= "Tipo Cuenta: " & TipoPlanDes & "; "
         End If

         If TipoGrupoDes <> "" Then
            strMsg &= "Grupo Cuenta: " & TipoGrupoDes & "; "
         End If

         If MonedaDes <> "" Then
            strMsg &= "Moneda: " & MonedaDes & "; "
         End If

         If TieneAnaAdd <> 0 Then
            strMsg &= "Tiene Analíticos Adicionales: " & ToByteStr(TieneAnaAdd) & "; "
         End If

         If MostrarAnaAdd <> 0 Then
            strMsg &= "Mostrar Analíticos Adicionales: " & ToByteStr(MostrarAnaAdd) & "; "
         End If

         If SucCCODes <> "" Then
            strMsg &= "Sucursal/CCO: " & SucCCODes & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PlanId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsPlanVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PlanId > 0 Then

         If PlanCta <> oVMOld.PlanCta Then
            strMsg &= "Código Cuenta: " & PlanCta & "; "
         End If

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Descripción: " & PlanDes & "; "
         End If

         If EsAna <> oVMOld.EsAna Then
            strMsg &= "Cuenta Analítico: " & ToByteStr(EsAna) & "; "
         End If

         If PlanPadreDes <> oVMOld.PlanPadreDes Then
            strMsg &= "Cuenta Padre: " & PlanPadreDes & "; "
         End If

         If Orden <> oVMOld.Orden Then
            strMsg &= "Orden: " & Orden & "; "
         End If

         If Nivel <> oVMOld.Nivel Then
            strMsg &= "Nivel: " & Nivel & "; "
         End If

         If TipoPlanDes <> oVMOld.TipoPlanDes Then
            strMsg &= "Tipo Cuenta: " & TipoPlanDes & "; "
         End If

         If TipoGrupoDes <> oVMOld.TipoGrupoDes Then
            strMsg &= "Grupo Cuenta: " & TipoGrupoDes & "; "
         End If

         If MonedaDes <> oVMOld.MonedaDes Then
            strMsg &= "Moneda: " & MonedaDes & "; "
         End If

         If TieneAnaAdd <> oVMOld.TieneAnaAdd Then
            strMsg &= "Tiene Analíticos Adicionales: " & ToByteStr(TieneAnaAdd) & "; "
         End If

         If MostrarAnaAdd <> oVMOld.MostrarAnaAdd Then
            strMsg &= "Mostrar Analíticos Adicionales: " & ToByteStr(MostrarAnaAdd) & "; "
         End If

         If SucCCODes <> oVMOld.SucCCODes Then
            strMsg &= "Sucursal/CCO: " & SucCCODes & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PlanId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If PlanId > 0 Then

            If PlanCta <> "" Then
               strMsg &= "Código Cuenta: " & PlanCta & "; "
            End If

            If PlanDes <> "" Then
               strMsg &= "Descripción: " & PlanDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & PlanId & "; " & strMsg)

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
         If PlanId > 0 Then

            If PlanCta <> "" Then
               strMsg &= "Código Cuenta: " & PlanCta & "; "
            Else
               Call PlanDesFind(PlanId, PlanCta, PlanDes)
            End If

            If PlanDes <> "" Then
               strMsg &= "Descripción: " & PlanDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & PlanId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   Public Sub PlanDesFind(ByVal lngPlanId As Long, ByRef strPlanCta As String, ByRef strPlanDes As String)
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      oPlan.PlanId = lngPlanId
      oPlan.FindByPK()
      strPlanCta = oPlan.PlanCta
      strPlanDes = oPlan.PlanDes
   End Sub

End Class
