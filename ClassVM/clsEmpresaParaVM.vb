Public Class clsEmpresaParaVM
   Public EmpresaParaId As Long
   Public EmpresaId As Long
   Public EmpresaDes As String
   Public DecimalNro As Long
   Public DecimalCant As Long
   Public EmpresaGral As String
   Public PlanCreId As Long
   Public PlanCreDes As String
   Public PlanCreDifId As Long
   Public PlanCreDifDes As String
   Public PlanDebId As Long
   Public PlanDebDes As String
   Public PlanDebDifId As Long
   Public PlanDebDifDes As String
   Public PlanITId As Long
   Public PlanITDes As String
   Public PlanITPId As Long
   Public PlanITPDes As String
   Public PlanITFId As Long
   Public PlanITFDes As String
   Public PlanIceIehdId As Long
   Public PlanIceIehdDes As String
   Public PlanIceIehdDifId As Long
   Public PlanIceIehdDifDes As String
   Public PlanExentoId As Long
   Public PlanExentoDes As String
   Public PlanDifId As Long
   Public PlanDifDes As String
   Public PlanAitbId As Long
   Public PlanAitbDes As String
   Public PlanResId As Long
   Public PlanResDes As String
   Public PlanCreRetId As Long
   Public PlanCreRetDes As String
   Public PlanITRetId As Long
   Public PlanITRetDes As String
   Public PlanIUERetSerId As Long
   Public PlanIUERetSerDes As String
   Public PlanIUERetBieId As Long
   Public PlanIUERetBieDes As String
   Public TipoHojaId As Long
   Public TipoHojaDes As String
   Public Inventario As Byte
   Public ItemCodShow As Byte
   Public PlanCtaShow As Byte
   Public CodBarra As Byte
   Public MultipleNro As Byte
   Public FechaOpera As Byte
   Public CentroCostoApli As Byte
   Public SepararExento As Byte
   Public AplicarDescuento As Byte
   Public MontoMinOpe As Decimal
   Public MontoMinFac As Decimal
   Public AplicarITPDif As Byte
   Public PlanITPDifId As Long
   Public PlanITPDifDes As String
   Public ExigirEEFF As Byte
   Public ValidarSaldoCajaBanco As Byte

   Public AplicarMedAlternativa As Byte
   Public AplicarControlInv As Byte
   Public AplicarDosificaVend As Byte
   Public RepSinGestion As Byte
   Public Repositorio As String
   Public ExigirActAnaAdd As Byte

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And EmpresaId > 0 Then

         If EmpresaDes <> "" Then
            strMsg &= "Empresa: " & EmpresaDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, strMsg & " Se crearon los Parametros de Empresa.")
            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsEmpresaParaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And EmpresaId > 0 Then

         If DecimalCant <> oVMOld.DecimalCant Then
            strMsg &= "Decimales para Cantidad: " & DecimalCant & "; "
         End If

         If DecimalNro <> oVMOld.DecimalNro Then
            strMsg &= "Decimales: " & DecimalNro & "; "
         End If

         If TipoHojaDes <> oVMOld.TipoHojaDes Then
            strMsg &= "Tamaño Hoja: " & TipoHojaDes & "; "
         End If

         If EmpresaGral <> oVMOld.EmpresaGral Then
            strMsg &= "Cabecera Reporte: " & EmpresaGral & "; "
         End If

         If MontoMinOpe <> oVMOld.MontoMinOpe Then
            strMsg &= "Monto Min Oper: " & ToDecStr(MontoMinOpe) & "; "
         End If

         If MontoMinFac <> oVMOld.MontoMinFac Then
            strMsg &= "M. Min Factura: " & ToDecStr(MontoMinFac) & "; "
         End If

         If Repositorio <> oVMOld.Repositorio Then
            strMsg &= "Repositorio: " & Repositorio & "; "
         End If

         If PlanCreDes <> oVMOld.PlanCreDes Then
            strMsg &= "Crédito Fiscal: " & PlanCreDes & "; "
         End If

         If PlanDebDes <> oVMOld.PlanDebDes Then
            strMsg &= "Débito Fiscal: " & PlanDebDes & "; "
         End If

         If PlanITDes <> oVMOld.PlanITDes Then
            strMsg &= "Imp. Transac.: " & PlanITDes & "; "
         End If

         If PlanITPDes <> oVMOld.PlanITPDes Then
            strMsg &= "I.T. Por Pagar: " & PlanITPDes & "; "
         End If

         If PlanITFDes <> oVMOld.PlanITFDes Then
            strMsg &= "I.T.F.: " & PlanITFDes & "; "
         End If

         If PlanIceIehdDes <> oVMOld.PlanIceIehdDes Then
            strMsg &= "ICE / IEHD: " & PlanIceIehdDes & "; "
         End If

         If PlanExentoDes <> oVMOld.PlanExentoDes Then
            strMsg &= "Exento: " & PlanExentoDes & "; "
         End If

         If PlanDifDes <> oVMOld.PlanDifDes Then
            strMsg &= "Dif. Cambio: " & PlanDifDes & "; "
         End If

         If PlanAitbDes <> oVMOld.PlanAitbDes Then
            strMsg &= "A.I.T.B.: " & PlanAitbDes & "; "
         End If

         If PlanResDes <> oVMOld.PlanResDes Then
            strMsg &= "Resultado: " & PlanResDes & "; "
         End If

         If PlanCreDifDes <> oVMOld.PlanCreDifDes Then
            strMsg &= "Créd. Fis. Diferido: " & PlanCreDifDes & "; "
         End If

         If PlanDebDifDes <> oVMOld.PlanDebDifDes Then
            strMsg &= "Déb. Fis. Diferido: " & PlanDebDifDes & "; "
         End If

         If PlanIceIehdDifDes <> oVMOld.PlanIceIehdDifDes Then
            strMsg &= "ICE / IEHD Diferido: " & PlanIceIehdDifDes & "; "
         End If

         If PlanITPDifDes <> oVMOld.PlanITPDifDes Then
            strMsg &= "IT Diferido: " & PlanITPDifDes & "; "
         End If

         If PlanCreRetDes <> oVMOld.PlanCreRetDes Then
            strMsg &= "IVA: " & PlanCreRetDes & "; "
         End If

         If PlanITRetDes <> oVMOld.PlanITRetDes Then
            strMsg &= "I.T.: " & PlanITRetDes & "; "
         End If

         If PlanIUERetSerDes <> oVMOld.PlanIUERetSerDes Then
            strMsg &= "I.U.E. Servicios: " & PlanIUERetSerDes & "; "
         End If

         If PlanIUERetBieDes <> oVMOld.PlanIUERetBieDes Then
            strMsg &= "I.U.E. Bienes: " & PlanIUERetBieDes & "; "
         End If

         If Inventario <> oVMOld.Inventario Then
            strMsg &= "Integrar el Módulo de Inventario a Contabilidad: " & ToByteStr(Inventario) & "; "
         End If

         If MultipleNro <> oVMOld.MultipleNro Then
            strMsg &= "Multiple Numeración en Contabilidad: " & ToByteStr(MultipleNro) & "; "
         End If

         If PlanCtaShow <> oVMOld.PlanCtaShow Then
            strMsg &= "Mostrar el Código de la Cuenta en Listas Desplegables: " & ToByteStr(PlanCtaShow) & "; "
         End If

         If ItemCodShow <> oVMOld.ItemCodShow Then
            strMsg &= "Mostrar el Código del Item en Listas Desplegables: " & ToByteStr(ItemCodShow) & "; "
         End If

         If CodBarra <> oVMOld.CodBarra Then
            strMsg &= "Permitir Uso de Lector de Código de Barra y/o QR: " & ToByteStr(CodBarra) & "; "
         End If

         If FechaOpera <> oVMOld.FechaOpera Then
            strMsg &= "Control de Seguridad en Fechas de Operación: " & ToByteStr(FechaOpera) & "; "
         End If

         If CentroCostoApli <> oVMOld.CentroCostoApli Then
            strMsg &= "Aplicar Centros de Costos en Operaciones: " & ToByteStr(CentroCostoApli) & "; "
         End If

         If SepararExento <> oVMOld.SepararExento Then
            strMsg &= "Separar Importe Exento en Asientos Contables: " & ToByteStr(SepararExento) & "; "
         End If

         If AplicarITPDif <> oVMOld.AplicarITPDif Then
            strMsg &= "Aplicar IT por pagar Diferido en Asientos Contables: " & ToByteStr(AplicarITPDif) & "; "
         End If

         If ExigirEEFF <> oVMOld.ExigirEEFF Then
            strMsg &= "Habilitar Flujo de Efectivo: " & ToByteStr(ExigirEEFF) & "; "
         End If

         If AplicarDescuento <> oVMOld.AplicarDescuento Then
            strMsg &= "Aplicar Descuento de Facturas en Asientos Contables: " & ToByteStr(AplicarDescuento) & "; "
         End If

         If ValidarSaldoCajaBanco <> oVMOld.ValidarSaldoCajaBanco Then
            strMsg &= "Validar Saldos de Cuentas Caja / Banco: " & ToByteStr(ValidarSaldoCajaBanco) & "; "
         End If

         If AplicarMedAlternativa <> oVMOld.AplicarMedAlternativa Then
            strMsg &= "Aplicar Medida Alternativa en los Ítems: " & ToByteStr(AplicarMedAlternativa) & "; "
         End If

         If RepSinGestion <> oVMOld.RepSinGestion Then
            strMsg &= "Aplicar Reportes sin Gestiones: " & ToByteStr(RepSinGestion) & "; "
         End If

         If AplicarControlInv <> oVMOld.AplicarControlInv Then
            strMsg &= "Aplicar Control de Inventario: " & ToByteStr(AplicarControlInv) & "; "
         End If

         If AplicarDosificaVend <> oVMOld.AplicarDosificaVend Then
            strMsg &= "Asignar Dosificaciones por Vendedor: " & ToByteStr(AplicarDosificaVend) & "; "
         End If

         If ExigirActAnaAdd <> oVMOld.ExigirActAnaAdd Then
            strMsg &= "Control de Registro de Actividades y Analiticos Adicionales: " & ToByteStr(ExigirActAnaAdd) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & EmpresaParaId & "; " & strMsg)
            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToShowOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If EmpresaParaId > 0 Then

            If EmpresaDes <> "" Then
               strMsg &= "Empresa: " & EmpresaDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & EmpresaParaId & "; " & strMsg)
               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   Private Function PlanDesFind(ByVal PlanId As Long) As String
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)
      oPlan.PlanId = PlanId
      oPlan.FindByPK()
      Return oPlan.PlanDes
   End Function

End Class