Public Class clsCompPlanAddVM
   Public CompPlanAddId As Long
   Public CompId As Long
   Public CompNro As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public PlanId As Long
   Public PlanDes As String
   Public PlanAddId As Long
   Public PlanAddDes As String
   Public DebeOrg As Decimal
   Public HaberOrg As Decimal

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef CompPlanAddId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompPlanAddId > 0 Then

         If CompNro <> 0 Then
            strMsg &= "Nro Comp.: " & CompNro & "; "
            'ElseIf CompId <> 0 Then
            '   CompNro = CompNroFind(CompId)
            '   strMsg &= "Nro Comp.: " & CompNro & "; "
         End If

         If TipoCompDes <> "" Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
            'ElseIf TipoCompId <> 0 Then
            '   TipoCompDes = TipoCompDesFind(TipoCompId)
            '   strMsg &= "Tipo: " & TipoCompDes & "; "
         End If

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            PlanDes = PlanDesFind(PlanId)
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If PlanAddDes <> "" Then
            strMsg &= "Análitico: " & PlanAddDes & "; "
         ElseIf PlanAddId <> 0 Then
            PlanAddDes = PlanAddDesFind(PlanAddId)
            strMsg &= "Análitico: " & PlanAddDes & "; "
         End If

         If DebeOrg <> 0 Then
            strMsg &= "Debe: " & ToDecStr(DebeOrg) & "; "
         End If

         If HaberOrg <> 0 Then
            strMsg &= "Haber: " & ToDecStr(HaberOrg) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompPlanAddId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & CompPlanAddId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCompPlanAddVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompPlanAddId > 0 Then

         If CompNro <> oVMOld.CompNro Then
            strMsg &= "Nro Comp.: " & CompNro & "; "
            'ElseIf CompNro <> oVMOld.CompNro Then
            '   CompNro = CompNroFind(CompId)
            '   strMsg &= "Nro Comp.: " & CompNro & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
            'ElseIf TipoCompId <> oVMOld.TipoCompId Then
            '   TipoCompDes = TipoCompDesFind(TipoCompId)
            '   strMsg &= "Tipo: " & TipoCompDes & "; "
         End If

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> oVMOld.PlanId Then
            PlanDes = PlanDesFind(PlanId)
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If PlanAddDes <> oVMOld.PlanAddDes Then
            strMsg &= "Análitico: " & PlanAddDes & "; "
         ElseIf PlanAddId <> oVMOld.PlanAddId Then
            strMsg &= "Análitico: " & PlanAddDesFind(PlanAddId) & "; "
         End If

         If DebeOrg <> oVMOld.DebeOrg Then
            strMsg &= "Debe: " & ToDecStr(DebeOrg) & "; "
         End If

         If HaberOrg <> oVMOld.HaberOrg Then
            strMsg &= "Haber: " & ToDecStr(HaberOrg) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.MODIFICA, "Id: " & CompPlanAddId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, clsTipoOpera.MODIFICA, 0, "", strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If CompPlanAddId > 0 Then

            If CompNro <> 0 Then
               strMsg &= "Nro Comp.: " & CompNro & "; "
               'ElseIf CompNro <> 0 Then
               '   CompNro = CompNroFind(CompId)
               '   strMsg &= "Nro Comp.: " & CompNro & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo: " & TipoCompDes & "; "
               'ElseIf TipoCompId <> 0 Then
               '   TipoCompDes = TipoCompDesFind(TipoCompId)
               '   strMsg &= "Tipo: " & TipoCompDes & "; "
            End If

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            ElseIf PlanId <> 0 Then
               PlanDes = PlanDesFind(PlanId)
               strMsg &= "Cuenta: " & PlanDes & "; "
            End If

            If PlanAddDes <> "" Then
               strMsg &= "Análitico: " & PlanAddDes & "; "
            ElseIf PlanAddId <> 0 Then
               PlanAddDes = PlanAddDesFind(PlanAddId)
               strMsg &= "Análitico: " & PlanAddDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & CompPlanAddId & "; " & strMsg)
               Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, clsTipoOpera.ELIMINA, 0, "", strMsg)
               ToDeleteOpe = True
            Else
               ToDeleteOpe = False
            End If
         End If
      End If
   End Function

   Public Function ToShowOpe(ByRef TipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then

         If CompPlanAddId > 0 Then

            If CompNro <> 0 Then
               strMsg &= "Nro Comp.: " & CompNro & "; "
            ElseIf CompNro <> 0 Then
               CompNro = CompNroFind(CompId)
               strMsg &= "Nro Comp.: " & CompNro & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo: " & TipoCompDes & "; "
            ElseIf TipoCompId <> 0 Then
               TipoCompDes = TipoCompDesFind(TipoCompId)
               strMsg &= "Tipo: " & TipoCompDes & "; "
            End If

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            ElseIf PlanId <> 0 Then
               PlanDes = PlanDesFind(PlanId)
               strMsg &= "Cuenta: " & PlanDes & "; "
            End If

            If PlanAddDes <> "" Then
               strMsg &= "Análitico: " & PlanAddDes & "; "
            ElseIf PlanAddId <> 0 Then
               PlanAddDes = PlanAddDesFind(PlanAddId)
               strMsg &= "Análitico: " & PlanAddDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, TipoOpera, "Id: " & CompPlanAddId & "; " & strMsg)
               Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, TipoOpera, 0, "", strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   Public Function TipoCompDesFind(ByVal lngTipoCompId As Long)
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      oTipoComp.TipoCompId = lngTipoCompId
      oTipoComp.FindByPK()
      Return oTipoComp.TipoCompDes
   End Function

   Public Function MonedaDesFind(ByVal lngMonedaId As Long)
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)
      oMoneda.MonedaId = lngMonedaId
      oMoneda.FindByPK()
      Return oMoneda.MonedaDes
   End Function

   Public Function TipoAsientoDesFind(ByVal lngTipoAsientoId As Long)
      Dim oTipoAsiento As New clsTipoAsiento(clsAppInfo.ConnectString)
      oTipoAsiento.TipoAsientoId = lngTipoAsientoId
      oTipoAsiento.FindByPK()
      Return oTipoAsiento.TipoAsientoDes
   End Function

   Public Function TipoNotaDesFind(ByVal lngTipoNotaId As Long)
      Dim oTipoNota As New clsTipoNota(clsAppInfo.ConnectString)
      oTipoNota.TipoNotaId = lngTipoNotaId
      oTipoNota.FindByPK()
      Return oTipoNota.TipoNotaDes
   End Function

   Public Function EstadoDesFind(ByVal lngEstadoId As Long)
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)
      oEstado.EstadoId = lngEstadoId
      oEstado.FindByPK()
      Return oEstado.EstadoDes
   End Function

   Public Function CompNroFind(ByVal lngCompId As Long)
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      oComp.CompId = lngCompId
      oComp.FindByPK()
      Return oComp.CompNro
   End Function

   Public Function PlanDesFind(ByVal lngPlanId As Long)
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      oPlan.PlanId = lngPlanId
      oPlan.FindByPK()
      Return oPlan.PlanDes
   End Function

   Public Function PlanAddDesFind(ByVal lngPlanAddId As Long)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      oPlanAdd.PlanAddId = lngPlanAddId
      oPlanAdd.FindByPK()
      Return oPlanAdd.PlanAddDes
   End Function

   Public Function SucursalDesFind(ByVal lngSucursalId As Long)
      Dim oSucursal As New clsSucursal(clsAppInfo.ConnectString)
      oSucursal.SucursalId = lngSucursalId
      oSucursal.FindByPK()
      Return oSucursal.SucursalDes
   End Function

   Public Function CentroCostoDesFind(ByVal lngCentroCostoId As Long)
      Dim oCentroCosto As New clsCentroCosto(clsAppInfo.ConnectString)
      oCentroCosto.CentroCostoId = lngCentroCostoId
      oCentroCosto.FindByPK()
      Return oCentroCosto.CentroCostoDes
   End Function

   Public Function TipoRetencionDesFind(ByVal lngTipoRetencionId As Long)
      Dim oTipoRetencion As New clsTipoRetencion(clsAppInfo.ConnectString)
      oTipoRetencion.TipoRetencionId = lngTipoRetencionId
      oTipoRetencion.FindByPK()
      Return oTipoRetencion.TipoRetencionDes
   End Function

End Class
