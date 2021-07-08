Public Class clsCompDetVM
   Public CompDetId As Long
   Public CompId As Long
   Public CompNro As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public Fecha As String
   Public PlanId As Long
   Public PlanDes As String
   Public CompDetDes As String
   Public SucursalId As Long
   Public SucursalDes As String
   Public CentroCostoId As Long
   Public CentroCostoDes As String
   Public TipoRetencionId As Long
   Public TipoRetencionDes As String
   Public MonedaId As Long
   Public MonedaDes As String
   Public DebeOrg As Decimal
   Public HaberOrg As Decimal
   Public DebeBs As Decimal
   Public HaberBs As Decimal
   Public DebeUs As Decimal
   Public HaberUs As Decimal
   Public Orden As Long
   Public Automatico As Byte
   Public TipoId As Long
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef CompDetId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompDetId > 0 Then

         If CompNro <> 0 Then
            strMsg &= "Nro Comp.: " & CompNro & "; "
         ElseIf CompId <> 0 Then
            strMsg &= "Nro Comp.: " & CompNroFind(CompId) & "; "
         End If

         If TipoCompDes <> "" Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         ElseIf TipoCompId <> 0 Then
            strMsg &= "Tipo: " & TipoCompDesFind(TipoCompId) & "; "
         End If

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If CompDetDes <> "" Then
            strMsg &= "Glosa: " & CompDetDes & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If DebeBs <> 0 Then
            strMsg &= "Debe Bs: " & ToDecStr(DebeBs) & "; "
         End If

         If HaberBs <> 0 Then
            strMsg &= "Haber Bs: " & ToDecStr(HaberBs) & "; "
         End If

         If DebeUs <> 0 Then
            strMsg &= "Debe Us: " & ToDecStr(DebeUs) & "; "
         End If

         If HaberUs <> 0 Then
            strMsg &= "Haber Us: " & ToDecStr(HaberUs) & "; "
         End If

         If SucursalDes <> "" Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         ElseIf SucursalId <> 0 Then
            strMsg &= "Sucursal: " & SucursalDesFind(SucursalId) & "; "
         End If

         If CentroCostoDes <> "" Then
            strMsg &= "Centro Costo: " & CentroCostoDes & "; "
         ElseIf CentroCostoId <> 0 Then
            strMsg &= "Centro Costo: " & CentroCostoDesFind(CentroCostoId) & "; "
         End If

         If TipoRetencionDes <> "" Then
            strMsg &= "Retencion Por: " & TipoRetencionDes & "; "
         ElseIf TipoRetencionId <> 0 Then
            strMsg &= "Retencion Por: " & TipoRetencionDesFind(TipoRetencionId) & "; "
         End If

         If Orden <> 0 Then
            strMsg &= "Orden: " & Orden & "; "
         End If

         If TipoId <> 0 And TipoId = clsCompDet.DESCUENTO Then
            strMsg &= "Tipo: DESCUENTO; "
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

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCompDetVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompDetId > 0 Then

         If CompNro <> oVMOld.CompNro Then
            strMsg &= "Nro Comp.: " & CompNro & "; "
         ElseIf CompId <> oVMOld.CompId Then
            strMsg &= "Nro Comp.: " & CompNroFind(CompId) & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         ElseIf TipoCompId <> oVMOld.TipoCompId Then
            TipoCompDes = TipoCompDesFind(TipoCompId)
            strMsg &= "Tipo: " & TipoCompDes & "; "
         End If

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> oVMOld.PlanId Then
            PlanDes = PlanDesFind(PlanId)
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If CompDetDes <> oVMOld.CompDetDes Then
            strMsg &= "Glosa: " & CompDetDes & "; "
         End If

         If Fecha <> oVMOld.Fecha Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         'If DebeOrg <> oVMOld.DebeOrg Then
         '   strMsg &= "Debe: " & ToDecStr(DebeOrg) & "; "
         'End If

         'If HaberOrg <> oVMOld.HaberOrg Then
         '   strMsg &= "Haber: " & ToDecStr(HaberOrg) & "; "
         'End If

         If DebeBs <> oVMOld.DebeBs Then
            strMsg &= "Debe Bs: " & ToDecStr(DebeBs) & "; "
         End If

         If HaberBs <> oVMOld.HaberBs Then
            strMsg &= "Haber Bs: " & ToDecStr(HaberBs) & "; "
         End If

         If DebeUs <> oVMOld.DebeUs Then
            strMsg &= "Debe Us: " & ToDecStr(DebeUs) & "; "
         End If

         If HaberUs <> oVMOld.HaberUs Then
            strMsg &= "Haber Us: " & ToDecStr(HaberUs) & "; "
         End If

         If SucursalDes <> oVMOld.SucursalDes Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         ElseIf SucursalId <> oVMOld.SucursalId Then
            SucursalDes = SucursalDesFind(SucursalId)
            strMsg &= "Sucursal: " & SucursalDes & "; "
         End If

         If CentroCostoDes <> oVMOld.CentroCostoDes Then
            strMsg &= "Centro Costo: " & CentroCostoDes & "; "
         ElseIf CentroCostoId <> oVMOld.CentroCostoId Then
            CentroCostoDes = CentroCostoDesFind(CentroCostoId)
            strMsg &= "Centro Costo: " & CentroCostoDes & "; "
         End If

         If TipoRetencionDes <> oVMOld.TipoRetencionDes Then
            strMsg &= "Retencion Por: " & TipoRetencionDes & "; "
         ElseIf TipoRetencionId <> oVMOld.TipoRetencionId Then
            TipoRetencionDes = TipoRetencionDesFind(TipoRetencionId)
            strMsg &= "Retencion Por: " & TipoRetencionDes & "; "
         End If

         If Orden <> oVMOld.Orden Then
            strMsg &= "Orden: " & Orden & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.MODIFICA, "Id: " & CompDetId & "; " & strMsg)
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
         If CompDetId > 0 Then

            If CompNro <> 0 Then
               strMsg &= "Nro Comp.: " & CompNro & "; "
            ElseIf CompNro <> 0 Then
               strMsg &= "Nro Comp.: " & CompNroFind(CompId) & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo: " & TipoCompDes & "; "
            ElseIf TipoCompId <> 0 Then
               strMsg &= "Tipo: " & TipoCompDesFind(TipoCompId) & "; "
            End If

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            ElseIf PlanId <> 0 Then
               strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
            End If

            If TipoId <> 0 And TipoId = clsCompDet.DESCUENTO Then
               strMsg &= "Tipo: DESCUENTO; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & CompDetId & "; " & strMsg)
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

         If CompDetId > 0 Then

            If CompNro <> 0 Then
               strMsg &= "Nro Comp.: " & CompNro & "; "
            ElseIf CompNro <> 0 Then
               strMsg &= "Nro Comp.: " & CompNroFind(CompId) & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo: " & TipoCompDes & "; "
            ElseIf TipoCompId <> 0 Then
               strMsg &= "Tipo: " & TipoCompDesFind(TipoCompId) & "; "
            End If

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            ElseIf PlanId <> 0 Then
               strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
            End If

            If TipoId <> 0 And TipoId = clsCompDet.DESCUENTO Then
               strMsg &= "Tipo: DESCUENTO; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, TipoOpera, "Id: " & CompDetId & "; " & strMsg)
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
