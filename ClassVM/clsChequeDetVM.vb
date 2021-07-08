Public Class clsChequeDetVM
   Public ChequeDetId As Long
   Public EmpresaId As Long
   Public ChequeId As Long
   Public PlanId As Long
   Public PlanDes As String
   Public BancoId As Long
   Public BancoCta As String
   Public BancoDes As String
   Public ChequeDetNro As Long
   Public Fecha As String
   Public ChequeIni As Long
   Public ChequeFin As Long
   Public ChequeActual As Long
   Public ChequeDetDes As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef ChequeDetId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ChequeDetId > 0 Then

         If PlanDes <> "" Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If BancoDes <> "" Then
            strMsg &= "Banco: " & BancoDes & "; "
         End If

         If BancoCta <> "" Then
            strMsg &= "Cuenta Banco: " & BancoCta & "; "
         End If

         If ChequeDetNro <> 0 Then
            strMsg &= "Nro: " & ToStr(ChequeDetNro) & "; "
         End If

         If Fecha <> "" Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If ChequeIni <> -1 Then
            strMsg &= "Cheque Inicial: " & ChequeIni & "; "
         End If

         If ChequeFin <> -1 Then
            strMsg &= "Cheque Final: " & ChequeFin & "; "
         End If

         If ChequeActual <> -1 Then
            strMsg &= "Cheque Actual: " & ChequeActual & "; "
         End If

         If ChequeDetDes <> "" Then
            strMsg &= "Descripción: " & ChequeDetDes & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ChequeDetId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsChequeDetVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And ChequeDetId > 0 Then

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta: " & PlanDes & "; "
         End If

         If BancoDes <> oVMOld.BancoDes Then
            strMsg &= "Banco: " & BancoDes & "; "
         End If

         If BancoCta <> oVMOld.BancoCta Then
            strMsg &= "Cuenta Banco: " & BancoCta & "; "
         End If

         If ChequeDetNro <> oVMOld.ChequeDetNro Then
            strMsg &= "Nro: " & ToStr(ChequeDetNro) & "; "
         End If

         If Fecha <> oVMOld.Fecha Then
            strMsg &= "Fecha: " & Fecha & "; "
         End If

         If ChequeIni <> oVMOld.ChequeIni Then
            strMsg &= "Cheque Inicial: " & ChequeIni & "; "
         End If

         If ChequeFin <> oVMOld.ChequeFin Then
            strMsg &= "Cheque Final: " & ChequeFin & "; "
         End If

         If ChequeActual <> oVMOld.ChequeActual Then
            strMsg &= "Cheque Actual: " & ChequeActual & "; "
         End If

         If ChequeDetDes <> oVMOld.ChequeDetDes Then
            strMsg &= "Descripción: " & ChequeDetDes & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & ChequeDetId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If ChequeDetId > 0 Then

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            End If

            If BancoDes <> "" Then
               strMsg &= "Banco: " & BancoDes & "; "
            End If

            If BancoCta <> "" Then
               strMsg &= "Cuenta Banco: " & BancoCta & "; "
            End If

            If ChequeDetNro <> 0 Then
               strMsg &= "Nro: " & ToStr(ChequeDetNro) & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & ChequeDetId & "; " & strMsg)

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
         If ChequeDetId > 0 Then

            If PlanDes <> "" Then
               strMsg &= "Cuenta: " & PlanDes & "; "
            End If

            If BancoDes <> "" Then
               strMsg &= "Banco: " & BancoDes & "; "
            End If

            If BancoCta <> "" Then
               strMsg &= "Cuenta Banco: " & BancoCta & "; "
            End If

            If ChequeDetNro <> 0 Then
               strMsg &= "Nro: " & ToStr(ChequeDetNro) & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & ChequeDetId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
