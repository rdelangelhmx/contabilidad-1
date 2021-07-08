Public Class clsCompChequeVM
   Public CompChequeId As Long
   Public EmpresaId As Long
   Public CompId As Long
   Public CompNro As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public Fecha As String
   Public PlanId As Long
   Public PlanDes As String
   Public ChequeId As Long
   Public BancoDes As String
   Public ChequeDetId As Long
   Public ChequeraNro As String
   Public CiudadId As Long
   Public CiudadDes As String
   Public ChequeNro As Long
   Public ChequeDes As String
   Public MonedaId As Long
   Public MonedaDes As String
   Public TipoCambio As Decimal
   Public ChequeMonto As Decimal
   Public Concepto As String
   Public FechaCob As String
   Public ChequeCobDes As String
   Public EstadoIdCob As Long
   Public EstadoDesCob As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef CompChequeId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompChequeId > 0 Then

         If CompNro <> 0 Then
            strMsg &= "Nro Comp.: " & CompNro & "; "
         End If

         If TipoCompDes <> "" Then
            strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
         End If

         If ChequeNro <> 0 Then
            strMsg &= "Nro Cheque: " & ChequeNro & "; "
         End If

         If CiudadDes <> "" Then
            strMsg &= "Ciudad: " & CiudadDes & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If TipoCambio <> 0 Then
            strMsg &= "T.C.: " & TipoCambio & "; "
         End If

         If ChequeMonto <> 0 Then
            strMsg &= "Monto: " & ToDecStr(ChequeMonto) & "; "
         End If

         If ChequeraNro <> "" Then
            strMsg &= "Chequera: " & ChequeraNro & "; "
         End If

         If BancoDes <> "" Then
            strMsg &= "Banco: " & BancoDes & "; "
         End If

         If MonedaDes <> "" Then
            strMsg &= "Moneda: " & MonedaDes & "; "
         End If

         If ChequeDes <> "" Then
            strMsg &= "Páguese a la orden de: " & ChequeDes & "; "
         End If

         If Concepto <> "" Then
            strMsg &= "Concepto: " & Concepto & "; "
         End If

         If ChequeCobDes <> "" Then
            strMsg &= "Descripción: " & ChequeCobDes & "; "
         End If

         If FechaCob <> "" Then
            strMsg &= "Fecha Cobranza Cheque: " & FechaCob & "; "
         End If

         If EstadoDesCob <> "" Then
            strMsg &= "Estado Cobranza: " & EstadoDesCob & "; "
         End If

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         ElseIf PlanId <> 0 Then
            strMsg &= "Cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         ElseIf EstadoId <> 0 Then
            strMsg &= "Estado: " & EstadoDesFind(EstadoId) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompChequeId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & CompChequeId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCompChequeVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then

         If CompNro <> oVMOld.CompNro Then
            strMsg &= "Nro Comp.: " & CompNro & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
         End If

         If ChequeNro <> oVMOld.ChequeNro Then
            strMsg &= "Nro Cheque: " & ChequeNro & "; "
         End If

         If CiudadDes <> oVMOld.CiudadDes Then
            strMsg &= "Ciudad: " & CiudadDes & "; "
         End If

         If Fecha <> oVMOld.Fecha Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If TipoCambio <> oVMOld.TipoCambio Then
            strMsg &= "T.C.: " & TipoCambio & "; "
         End If

         If ChequeMonto <> oVMOld.ChequeMonto Then
            strMsg &= "Monto: " & ToDecStr(ChequeMonto) & "; "
         End If

         If ChequeraNro <> oVMOld.ChequeraNro Then
            strMsg &= "Chequera: " & ChequeraNro & "; "
         End If

         If MonedaDes <> oVMOld.MonedaDes Then
            strMsg &= "Moneda: " & MonedaDes & "; "
         End If

         If ChequeDes <> oVMOld.ChequeDes Then
            strMsg &= "Páguese a la orden de: " & ChequeDes & "; "
         End If

         If Concepto <> oVMOld.Concepto Then
            strMsg &= "Concepto: " & Concepto & "; "
         End If

         If ChequeCobDes <> oVMOld.ChequeCobDes Then
            strMsg &= "Descripción: " & ChequeCobDes & "; "
         End If

         If FechaCob <> oVMOld.FechaCob Then
            strMsg &= "Fecha Cobranza Cheque: " & FechaCob & "; "
         End If

         If EstadoDesCob <> oVMOld.EstadoDesCob Then
            strMsg &= "Estado Cobranza: " & EstadoDesCob & "; "
         End If

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompChequeId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & CompChequeId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If CompChequeId > 0 Then

            If ChequeNro <> 0 Then
               strMsg &= "Nro Cheque: " & ChequeNro & "; "
            End If

            If ChequeraNro <> "" Then
               strMsg &= "Chequera: " & ChequeraNro & "; "
            ElseIf ChequeDetId <> 0 Then
               strMsg &= "Chequera: " & ChequeraNroFind(ChequeDetId) & "; "
            End If

            If BancoDes <> "" Then
               strMsg &= "Banco: " & BancoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & CompChequeId & "; " & strMsg)
               Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, clsTipoOpera.ELIMINA, 0, "", "Id: " & CompChequeId & "; " & strMsg)

               ToDeleteOpe = True
            Else
               ToDeleteOpe = False
            End If
         End If
      End If
   End Function

   Public Function ToShowOpe(ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If CompChequeId > 0 Then

            If ChequeNro <> 0 Then
               strMsg &= "Nro Cheque: " & ChequeNro & "; "
            End If

            If ChequeraNro <> "" Then
               strMsg &= "Chequera: " & ChequeraNro & "; "
            End If

            If BancoDes <> "" Then
               strMsg &= "Banco: " & BancoDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompChequeId & "; " & strMsg)
               Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & CompChequeId & "; " & strMsg)
               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   Public Function ChequeraNroFind(ByVal lngChequeDetId As Long) As String
      Dim oChequeDet As New clsChequeDet(clsAppInfo.ConnectString)
      oChequeDet.ChequeDetId = lngChequeDetId
      oChequeDet.FindByPK()
      Return oChequeDet.ChequeDetNro
   End Function

   Public Function CompNroFind(ByVal lngCompId As Long) As String
      Dim oComp As New clsComp(clsAppInfo.ConnectString)
      oComp.CompId = lngCompId
      oComp.FindByPK()
      Return oComp.CompNro
   End Function

   Public Function PlanDesFind(ByVal lngPlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      oPlan.PlanId = lngPlanId
      oPlan.FindByPK()
      Return oPlan.PlanDes
   End Function

   Public Function EstadoDesFind(ByVal lngEstadoId As Long) As String
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)
      oEstado.EstadoId = lngEstadoId
      oEstado.FindByPK()
      Return oEstado.EstadoDes
   End Function

End Class
