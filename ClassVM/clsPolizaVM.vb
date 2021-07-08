Public Class clsPolizaVM
   Public PolizaId As Long
   Public EmpresaId As Long
   Public CompId As Long
   Public CompNro As Long
   Public MesId As Long
   Public MesDes As String
   Public PolizaFecha As String
   Public PolizaNro As String
   Public AduanaNIT As String
   Public AduanaDes As String
   Public PolizaMonto As Decimal
   Public IVA As Decimal
   Public ICEIEHD As Decimal
   Public PlanId As Long
   Public PlanDes As String
   Public PlanAddId As Long
   Public PlanAddDes As String
   Public CentroCostoId As Long
   Public CentroCostoDes As String
   Public CentroCostoDetId As Long
   Public CentroCostoDetDes As String
   Public SucursalId As Long
   Public SucursalDes As String
   Public Bancarizar As Byte
   Public BancarizarMonto As Decimal
   Public TipoFacCompraId As Long
   Public TipoFacCompraDes As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef PolizaId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PolizaId > 0 Then

         If SucursalDes <> "" Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         End If

         If PolizaFecha <> "" Then
            strMsg &= "Fecha: " & PolizaFecha & "; "
         End If

         If PolizaNro <> "" Then
            strMsg &= "Número Poliza: " & PolizaNro & "; "
         End If

         If AduanaDes <> "" Then
            strMsg &= "Agencia: " & AduanaDes & "; "
         End If

         If AduanaNIT <> "" Then
            strMsg &= "NIT Agencia Ad.: " & AduanaNIT & "; "
         End If

         If PolizaMonto <> 0 Then
            strMsg &= "Monto Imponible: " & PolizaMonto & "; "
         End If

         If IVA <> 0 Then
            strMsg &= "IVA Poliza: " & IVA & "; "
         End If

         If ICEIEHD <> 0 Then
            strMsg &= "ICE: " & ICEIEHD & "; "
         End If

         If Bancarizar <> 0 Then
            strMsg &= "Bancarizar esta Poliza: " & ToByteStr(Bancarizar) & "; "
         End If

         If TipoFacCompraDes <> "" Then
            strMsg &= "Tipo Compra: " & TipoFacCompraDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PolizaId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsPolizaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PolizaId > 0 Then

         If SucursalDes <> oVMOld.SucursalDes Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         End If

         If PolizaFecha <> oVMOld.PolizaFecha Then
            strMsg &= "Fecha: " & PolizaFecha & "; "
         End If

         If PolizaNro <> oVMOld.PolizaNro Then
            strMsg &= "Número Poliza: " & PolizaNro & "; "
         End If

         If AduanaDes <> oVMOld.AduanaDes Then
            strMsg &= "Agencia: " & AduanaDes & "; "
         End If

         If AduanaNIT <> oVMOld.AduanaNIT Then
            strMsg &= "NIT Agencia Ad.: " & AduanaNIT & "; "
         End If

         If PolizaMonto <> oVMOld.PolizaMonto Then
            strMsg &= "Monto Imponible: " & PolizaMonto & "; "
         End If

         If IVA <> oVMOld.IVA Then
            strMsg &= "IVA Poliza: " & IVA & "; "
         End If

         If ICEIEHD <> oVMOld.ICEIEHD Then
            strMsg &= "ICE: " & ICEIEHD & "; "
         End If

         If Bancarizar <> oVMOld.Bancarizar Then
            strMsg &= "Bancarizar esta Poliza: " & ToByteStr(Bancarizar) & "; "
         End If

         If TipoFacCompraDes <> oVMOld.TipoFacCompraDes Then
            strMsg &= "Tipo Compra: " & TipoFacCompraDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PolizaId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If PolizaId > 0 Then

            If PolizaNro <> "" Then
               strMsg &= "Número Poliza: " & PolizaNro & "; "
            End If

            If SucursalDes <> "" Then
               strMsg &= "Sucursal: " & SucursalDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & PolizaId & "; " & strMsg)

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
         If PolizaId > 0 Then

            If PolizaNro <> "" Then
               strMsg &= "Número Poliza: " & PolizaNro & "; "
            End If

            If SucursalDes <> "" Then
               strMsg &= "Sucursal: " & SucursalDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & PolizaId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   'Public Sub PolizaDesFind(ByVal lngPolizaId As Long, ByRef strPolizaCta As String, ByRef strPolizaDes As String)
   '   Dim oPoliza As New clsPoliza(clsAppInfo.ConnectString)
   '   oPoliza.PolizaId = lngPolizaId
   '   oPoliza.FindByPK()
   '   strPolizaCta = oPoliza.PolizaCta
   '   strPolizaDes = oPoliza.PolizaDes
   'End Sub

End Class
