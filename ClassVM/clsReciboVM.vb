Public Class clsReciboVM
   Public ReciboId As Long
   Public EmpresaId As Long
   Public GestionId As Long
   Public ReciboNro As Long
   Public CompId As Long
   Public CompNro As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public Fecha As String
   Public EntregadoA As String
   Public PorConcepto As String
   Public Glosa As String
   Public MonedaId As Long
   Public MonedaDes As String
   Public Monto As Decimal
   Public RespaldoId As Long
   Public RespaldoNro As Long
   Public RespaldoDes As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef ReciboId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ReciboId > 0 Then

         If ReciboNro <> 0 Then
            strMsg &= "Número: " & ReciboNro & "; "
         End If

         If TipoCompDes <> "" Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If EntregadoA <> "" Then
            strMsg &= "Entregado a: " & EntregadoA & "; "
         End If

         If PorConcepto <> "" Then
            strMsg &= "Por Concepto: " & PorConcepto & "; "
         End If

         If Glosa <> "" Then
            strMsg &= "Glosa: " & Glosa & "; "
         End If

         If MonedaDes <> "" Then
            strMsg &= "Moneda: " & MonedaDes & "; "
         End If

         If Monto <> 0 Then
            strMsg &= "Monto: " & ToDecimal(Monto) & "; "
         End If

         If RespaldoNro <> 0 Then
            strMsg &= "Nro Respaldo: " & RespaldoNro & "; "
         End If

         If RespaldoDes <> "" Then
            strMsg &= "Respaldo: " & RespaldoDes & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ReciboId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(ReciboId, ReciboNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & ReciboId & "; " & strMsg)
            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsReciboVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ReciboId > 0 Then

         If ReciboNro <> oVMOld.ReciboNro Then
            strMsg &= "Número: " & ReciboNro & "; "
         End If

         If Fecha <> oVMOld.Fecha Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         End If

         If CompNro <> oVMOld.CompNro Then
            strMsg &= "Comp. Nro: " & CompNro & "; "
         End If

         If EntregadoA <> oVMOld.EntregadoA Then
            strMsg &= "Entregado a: " & EntregadoA & "; "
         End If

         If PorConcepto <> oVMOld.PorConcepto Then
            strMsg &= "Por Concepto: " & PorConcepto & "; "
         End If

         If Glosa <> oVMOld.Glosa Then
            strMsg &= "Glosa: " & Glosa & "; "
         End If

         If MonedaDes <> oVMOld.MonedaDes Then
            strMsg &= "Moneda: " & MonedaDes & "; "
         End If

         If Monto <> oVMOld.Monto Then
            strMsg &= "Monto: " & ToDecimal(Monto) & "; "
         End If

         If RespaldoNro <> oVMOld.RespaldoNro Then
            strMsg &= "Nro Respaldo: " & RespaldoNro & "; "
         End If

         If RespaldoDes <> oVMOld.RespaldoDes Then
            strMsg &= "Respaldo: " & RespaldoDes & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ReciboId & "; " & strMsg)
            Call modAuditoria.AudiDocAdd(ReciboId, ReciboNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & ReciboId & "; " & strMsg)
            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If ReciboId > 0 Then

            If ReciboNro <> 0 Then
               strMsg &= "Número: " & ReciboNro & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo: " & TipoCompDes & "; "
            End If
            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & ReciboId & "; " & strMsg)
               Call modAuditoria.AudiDocAdd(ReciboId, ReciboNro, TipoCompDes, clsTipoOpera.ELIMINA, 0, "", "Id: " & ReciboId & "; " & strMsg)
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
         If ReciboId > 0 Then

            If ReciboNro <> 0 Then
               strMsg &= "Número: " & ReciboNro & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo: " & TipoCompDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ReciboId & "; " & strMsg)
               Call modAuditoria.AudiDocAdd(ReciboId, ReciboNro, TipoCompDes, bytTipoOpera, 0, "", "Id: " & ReciboId & "; " & strMsg)
               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class