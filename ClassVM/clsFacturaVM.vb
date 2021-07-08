Public Class clsFacturaVM
   Public FacturaId As Long

   Public CompId As Long
   Public CompNro As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public SucursalId As Long
   Public SucursalDes As String
   Public PlanId As Long
   Public PlanDes As String
   Public TipoFacturaId As Long
   Public TipoFacturaDes As String
   Public FacturaNro As String
   Public Fecha As String
   Public NroRuc As String
   Public RegRucDes As String
   Public NroAutorizacion As String
   Public CodControl As String
   Public FacturaMonto As Decimal
   Public IceIehd As Decimal
   Public Exento As Decimal
   Public Descuento As Decimal
   Public Recargo As Decimal
   Public IVA As Decimal
   Public Bancarizar As Byte
   Public TipoFacCompraId As Long
   Public TipoFacCompraDes As String
   Public FacturaObs As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef FacturaId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And FacturaId > 0 Then

         If CompNro <> 0 Then
            strMsg &= "Nro Comp.: " & CompNro & "; "
         End If

         If TipoCompDes <> "" Then
            strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
         End If

         If plandes <> "" Then
            strMsg &= "cuenta: " & plandes & "; "
         ElseIf planid <> 0 Then
            strMsg &= "cuenta: " & PlanDesFind(planid) & "; "
         End If

         If SucursalDes <> "" Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         End If

         If TipoFacturaDes <> "" Then
            strMsg &= "Tipo Factura: " & TipoFacturaDes & "; "
         ElseIf TipoFacturaId <> 0 Then
            If TipoFacturaId = 1 Then
               strMsg &= "Tipo Factura: VENTA; "
            ElseIf TipoFacturaId = 2 Then
               strMsg &= "Tipo Factura: COMPRA; "
            End If
         End If

         If FacturaNro <> 0 Then
            strMsg &= "Nro Factura: " & FacturaNro & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If NroRuc <> "" Then
            strMsg &= "Número NIT: " & NroRuc & "; "
         End If

         If RegRucDes <> "" Then
            strMsg &= "Razón Social: " & RegRucDes & "; "
         End If

         If NroAutorizacion <> "" Then
            strMsg &= "Nro Autorización: " & NroAutorizacion & "; "
         End If

         If CodControl <> "" Then
            strMsg &= "Código Control: " & CodControl & "; "
         End If

         If FacturaMonto <> 0 Then
            strMsg &= "Importe Total: " & ToDecStr(FacturaMonto) & "; "
         End If

         If Recargo <> 0 Then
            strMsg &= "Recargo: " & ToDecStr(Recargo) & "; "
         End If

         If IceIehd <> 0 Then
            strMsg &= "ICE/IEHD: " & ToDecStr(IceIehd) & "; "
         End If

         If Exento <> 0 Then
            strMsg &= "Exento: " & ToDecStr(Exento) & "; "
         End If

         If Descuento <> 0 Then
            strMsg &= "Descuento: " & ToDecStr(Descuento) & "; "
         End If

         If IVA <> 0 Then
            strMsg &= "IVA: " & ToDecStr(IVA) & "; "
         End If

         If Bancarizar <> 0 Then
            strMsg &= "Bancarizar: " & ToByteStr(Bancarizar) & "; "
         End If

         If TipoFacCompraDes <> "" Then
            strMsg &= "Tipo Compra: " & TipoFacCompraDes & "; "
         End If

         If FacturaObs <> "" Then
            strMsg &= "Observación: " & FacturaObs & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         ElseIf EstadoId <> 0 Then
            strMsg &= "Estado: " & EstadoDesFind(EstadoId) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & FacturaId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & FacturaId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsFacturaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then

         If CompNro <> oVMOld.CompNro Then
            strMsg &= "Nro Comp.: " & CompNro & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
         End If

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "cuenta: " & PlanDes & "; "
         ElseIf PlanId <> oVMOld.PlanId Then
            strMsg &= "cuenta: " & PlanDesFind(PlanId) & "; "
         End If

         If SucursalDes <> oVMOld.SucursalDes Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         End If

         If TipoFacturaDes <> oVMOld.TipoFacturaDes Then
            strMsg &= "Tipo Factura: " & TipoFacturaDes & "; "
         ElseIf TipoFacturaId <> oVMOld.TipoFacturaId Then
            If TipoFacturaId = 1 Then
               strMsg &= "Tipo Factura: VENTA; "
            ElseIf TipoFacturaId = 2 Then
               strMsg &= "Tipo Factura: COMPRA; "
            End If
         End If

         If FacturaNro <> oVMOld.FacturaNro Then
            strMsg &= "Nro Factura: " & FacturaNro & "; "
         End If

         If Fecha <> oVMOld.Fecha Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If NroRuc <> oVMOld.NroRuc Then
            strMsg &= "Número NIT: " & NroRuc & "; "
         End If

         If RegRucDes <> oVMOld.RegRucDes Then
            strMsg &= "Razón Social: " & RegRucDes & "; "
         End If

         If NroAutorizacion <> oVMOld.NroAutorizacion Then
            strMsg &= "Nro Autorización: " & NroAutorizacion & "; "
         End If

         If CodControl <> oVMOld.CodControl Then
            strMsg &= "Código Control: " & CodControl & "; "
         End If

         If FacturaMonto <> oVMOld.FacturaMonto Then
            strMsg &= "Importe Total: " & ToDecStr(FacturaMonto) & "; "
         End If

         If Recargo <> oVMOld.Recargo Then
            strMsg &= "Recargo: " & ToDecStr(Recargo) & "; "
         End If

         If IceIehd <> oVMOld.IceIehd Then
            strMsg &= "ICE/IEHD: " & ToDecStr(IceIehd) & "; "
         End If

         If Exento <> oVMOld.Exento Then
            strMsg &= "Exento: " & ToDecStr(Exento) & "; "
         End If

         If Descuento <> oVMOld.Descuento Then
            strMsg &= "Descuento: " & ToDecStr(Descuento) & "; "
         End If

         If IVA <> oVMOld.IVA Then
            strMsg &= "IVA: " & ToDecStr(IVA) & "; "
         End If

         If Bancarizar <> oVMOld.Bancarizar Then
            strMsg &= "Bancarizar: " & ToByteStr(Bancarizar) & "; "
         End If

         If TipoFacCompraDes <> oVMOld.TipoFacCompraDes Then
            strMsg &= "Tipo Compra: " & TipoFacCompraDes & "; "
         End If

         If FacturaObs <> oVMOld.FacturaObs Then
            strMsg &= "Observación: " & FacturaObs & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         ElseIf EstadoId <> oVMOld.EstadoId Then
            strMsg &= "Estado: " & EstadoDesFind(EstadoId) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & FacturaId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & FacturaId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If FacturaId > 0 Then

            If CompNro <> 0 Then
               strMsg &= "Nro Comp.: " & CompNro & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
            End If

            If TipoFacturaDes <> "" Then
               strMsg &= "Tipo Factura: " & TipoFacturaDes & "; "
            ElseIf TipoFacturaId <> 0 Then
               If TipoFacturaId = 1 Then
                  strMsg &= "Tipo Factura: VENTA; "
               ElseIf TipoFacturaId = 2 Then
                  strMsg &= "Tipo Factura: COMPRA; "
               End If
            End If

            If NroAutorizacion <> "" Then
               strMsg &= "Nro Autorización: " & NroAutorizacion & "; "
            End If

            If FacturaNro <> 0 Then
               strMsg &= "Nro Factura: " & FacturaNro & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & FacturaId & "; " & strMsg)
               Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, clsTipoOpera.ELIMINA, 0, "", "Id: " & FacturaId & "; " & strMsg)

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
         If FacturaId > 0 Then

            If CompNro <> 0 Then
               strMsg &= "Nro Comp.: " & CompNro & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
            End If

            If TipoFacturaDes <> "" Then
               strMsg &= "Tipo Factura: " & TipoFacturaDes & "; "
            ElseIf TipoFacturaId <> 0 Then
               If TipoFacturaId = 1 Then
                  strMsg &= "Tipo Factura: VENTA; "
               ElseIf TipoFacturaId = 2 Then
                  strMsg &= "Tipo Factura: COMPRA; "
               End If
            End If

            If NroAutorizacion <> "" Then
               strMsg &= "Nro Autorización: " & NroAutorizacion & "; "
            End If

            If FacturaNro <> 0 Then
               strMsg &= "Nro Factura: " & FacturaNro & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & FacturaId & "; " & strMsg)
               Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & FacturaId & "; " & strMsg)

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
