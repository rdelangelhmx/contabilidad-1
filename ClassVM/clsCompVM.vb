Public Class clsCompVM
   Public CompId As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public CompNro As Long
   Public Fecha As String
   Public MonedaId As Long
   Public MonedaDes As String
   Public TipoCambio As Decimal
   Public EntregadoA As String
   Public PorConcepto As String
   Public DebeBs As Decimal
   Public HaberBs As Decimal
   Public DebeUs As Decimal
   Public HaberUs As Decimal
   Public PorIVA As Decimal
   Public PorIT As Decimal
   Public PorITF As Decimal
   Public ConFac As Byte
   Public SinFac As Byte
   Public Automatico As Byte
   Public TipoAsientoId As Long
   Public TipoAsientoDes As String
   Public Glosa As String
   Public TipoNotaId As Long
   Public TipoNotaDes As String
   Public NotaNro As Long
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String
   Public TipoOpera As Byte
   Public TipoOperaDes As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef CompId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompId > 0 Then

         If CompNro <> 0 Then
            strMsg &= "Número: " & CompNro & "; "
         End If

         If TipoCompDes <> "" Then
            strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
         ElseIf TipoCompId <> 0 Then
            TipoCompDes = TipoCompDesFind(TipoCompId)
            strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
         End If

         If MonedaDes <> "" Then
            strMsg &= "Moneda: " & MonedaDes & "; "
         ElseIf MonedaId <> 0 Then
            MonedaDes = MonedaDesFind(MonedaId)
            strMsg &= "Moneda: " & MonedaDes & "; "
         End If

         If TipoAsientoDes <> "" Then
            strMsg &= "Asiento: " & TipoAsientoDes & "; "
         ElseIf TipoAsientoId <> 0 Then
            strMsg &= "Asiento: " & TipoAsientoDesFind(TipoAsientoId) & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If TipoCambio <> 0 Then
            strMsg &= "Tipo Cambio: " & ToDecStr(TipoCambio) & "; "
         End If

         Dim strEntregadoA As String = ""
         Dim strPorConcepto As String = ""

         If TipoCompId = clsTipoComp.TRASPASO Then
            strEntregadoA = "Por concepto de:"
            strPorConcepto = ""
         ElseIf TipoCompId = clsTipoComp.INGRESO Then
            strEntregadoA = "Hemos recibido de:"
            strPorConcepto = "Por concepto de:"
         ElseIf TipoCompId = clsTipoComp.EGRESO Then
            strEntregadoA = "Hemos entregado a:"
            strPorConcepto = "Por concepto de:"
         End If

         If EntregadoA <> "" Then
            strMsg &= strEntregadoA & ": " & EntregadoA & "; "
         End If

         If PorConcepto <> "" Then
            strMsg &= strPorConcepto & ": " & PorConcepto & "; "
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

         If PorIVA <> 0 Then
            strMsg &= "PorIVA: " & ToDecimalCinco(PorIVA) & "; "
         End If
         If PorIT <> 0 Then
            strMsg &= "PorIT: " & ToDecimalCinco(PorIT) & "; "
         End If
         If PorITF <> 0 Then
            strMsg &= "PorITF: " & ToDecimalCinco(PorITF) & "; "
         End If

         If ConFac <> 0 Then
            strMsg &= "ConFac: " & ToByteStr(ConFac) & "; "
         End If

         If SinFac <> 0 Then
            strMsg &= "SinFac: " & ToByteStr(SinFac) & "; "
         End If

         If Automatico <> 0 Then
            strMsg &= "Automatico: " & ToByteStr(Automatico) & "; "
         End If

         If Glosa <> "" Then
            strMsg &= "Glosa: " & Glosa & "; "
         End If

         If TipoNotaDes <> "" Then
            strMsg &= "Tipo Nota: " & TipoNotaDes & "; "
         ElseIf TipoNotaId <> 0 Then
            strMsg &= "Tipo Nota: " & TipoNotaDesFind(TipoNotaId) & "; "
         End If

         If NotaNro <> 0 Then
            strMsg &= "Nota Nro.: " & NotaNro & "; "
         End If

         If EstadoId <> 0 Then
            strMsg &= "Estado: " & EstadoDesFind(EstadoId) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, If(Not String.IsNullOrEmpty(TipoOperaDes), TipoOperaDes & "; ", "") & "Id: " & CompId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, bytTipoOpera, 0, "", If(Not String.IsNullOrEmpty(TipoOperaDes), TipoOperaDes & "; ", "") & strMsg)
            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCompVM) As Boolean
      Dim strMsg As String = String.Empty

      If TipoOpera = 0 Then
         TipoOpera = clsTipoOpera.MODIFICA
      End If

      If clsAppInfo.RegistrarBitacora And CompId > 0 Then

         If CompNro <> oVMOld.CompNro Then
            strMsg &= "Número: " & CompNro & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
         ElseIf TipoCompId <> oVMOld.TipoCompId Then
            TipoCompDes = TipoCompDesFind(TipoCompId)
            strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
         End If

         If MonedaDes <> oVMOld.MonedaDes Then
            strMsg &= "Moneda: " & MonedaDes & "; "
         ElseIf MonedaId <> oVMOld.MonedaId Then
            MonedaDes = MonedaDesFind(MonedaId)
            strMsg &= "Moneda: " & MonedaDes & "; "
         End If

         If TipoAsientoDes <> oVMOld.TipoAsientoDes Then
            strMsg &= "Asiento: " & TipoAsientoDes & "; "
         ElseIf TipoAsientoId <> oVMOld.TipoAsientoId Then
            TipoAsientoDes = TipoAsientoDesFind(TipoAsientoId)
            strMsg &= "Asiento: " & TipoAsientoDes & "; "
         End If

         If Fecha <> oVMOld.Fecha Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If TipoCambio <> oVMOld.TipoCambio Then
            strMsg &= "Tipo Cambio: " & ToDecStr(TipoCambio) & "; "
         End If

         Dim strEntregadoA As String = ""
         Dim strPorConcepto As String = ""

         If TipoCompId = clsTipoComp.TRASPASO Then
            strEntregadoA = "Por concepto de:"
            strPorConcepto = ""
         ElseIf TipoCompId = clsTipoComp.INGRESO Then
            strEntregadoA = "Hemos recibido de:"
            strPorConcepto = "Por concepto de:"
         ElseIf TipoCompId = clsTipoComp.EGRESO Then
            strEntregadoA = "Hemos entregado a:"
            strPorConcepto = "Por concepto de:"
         End If

         If EntregadoA <> oVMOld.EntregadoA Then
            strMsg &= strEntregadoA & ": " & EntregadoA & "; "
         End If

         If PorConcepto <> oVMOld.PorConcepto Then
            strMsg &= strPorConcepto & ": " & PorConcepto & "; "
         End If

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

         If PorIVA <> oVMOld.PorIVA Then
            strMsg &= "PorIVA: " & ToDecimalCinco(PorIVA) & "; "
         End If
         If PorIT <> oVMOld.PorIT Then
            strMsg &= "PorIT: " & ToDecimalCinco(PorIT) & "; "
         End If
         If PorITF <> oVMOld.PorITF Then
            strMsg &= "PorITF: " & ToDecimalCinco(PorITF) & "; "
         End If

         If ConFac <> oVMOld.ConFac Then
            strMsg &= "ConFac: " & ToByteStr(ConFac) & "; "
         End If

         If SinFac <> oVMOld.SinFac Then
            strMsg &= "SinFac: " & ToByteStr(SinFac) & "; "
         End If

         If Automatico <> oVMOld.Automatico Then
            strMsg &= "Automatico: " & ToByteStr(Automatico) & "; "
         End If

         If Glosa <> oVMOld.Glosa Then
            strMsg &= "Glosa: " & Glosa & "; "
         End If

         If TipoNotaDes <> oVMOld.TipoNotaDes Then
            strMsg &= "Tipo Nota: " & TipoNotaDes & "; "
         ElseIf TipoNotaId <> oVMOld.TipoNotaId Then
            TipoNotaDes = TipoNotaDesFind(TipoNotaId)
            strMsg &= "Tipo Nota: " & TipoNotaDes & "; "
         End If

         If NotaNro <> oVMOld.NotaNro Then
            strMsg &= "Nota Nro.: " & NotaNro & "; "
         End If

         If EstadoId <> oVMOld.EstadoId Then
            EstadoDes = EstadoDesFind(EstadoId)
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, TipoOpera, "Id: " & CompId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(CompId, CompNro, TipoCompDes, TipoOpera, 0, "", strMsg)
            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If CompId > 0 Then

            If CompNro <> 0 Then
               strMsg &= "Número: " & CompNro & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & CompId & "; " & strMsg)
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

         If CompId > 0 Then

            If CompNro <> 0 Then
               strMsg &= "Número: " & CompNro & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo Comp.: " & TipoCompDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, TipoOpera, "Id: " & CompId & "; " & strMsg)
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

End Class
