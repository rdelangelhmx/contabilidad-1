Public Class clsCompParaVM
   Public CompParaId As Long
   Public EmpresaId As Long
   Public GestionId As Long
   Public Gestion As Long
   Public TipoCompId As Long
   Public TipoCompDes As String
   Public NroIni As Long
   Public NroActual As Long
   Public NroIniFis As Long
   Public NroActualFis As Long
   Public NroAuto As Byte
   Public NroAutoGestion As Byte
   Public Firma As String
   Public TipoHojaId As Long
   Public TipoHojaDes As String
   Public TipoImpresionId As Long
   Public TipoImpresionDes As String
   Public TipoRespImpId As Long
   Public TipoRespImpDes As String
   Public RowsMax As Long
   Public EstadoId As Long
   Public EstadoDes As String
   Public BloqueoAuto As Byte
   Public EncabezadoPorHoja As Byte

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompParaId > 0 Then


         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompParaId & "; " & strMsg)
            '   "Apertura de Parámetros de Comprobante" & "; Gestión " & clsAppInfo.Gestion)
            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsCompParaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And CompParaId > 0 Then

         If Gestion <> oVMOld.Gestion Then
            strMsg &= "Gestión: " & Gestion & "; "
         End If

         If TipoCompDes <> oVMOld.TipoCompDes Then
            strMsg &= "Tipo: " & TipoCompDes & "; "
         End If

         If NroIni <> oVMOld.NroIni Then
            strMsg &= "Nro Inicial: " & NroIni & "; "
         End If

         If NroActual <> oVMOld.NroActual Then
            strMsg &= "Nro Actual: " & NroActual & "; "
         End If

         If NroIniFis <> oVMOld.NroIniFis Then
            strMsg &= "Nro Inicial 2.: " & NroIniFis & "; "
         End If

         If NroActualFis <> oVMOld.NroActualFis Then
            strMsg &= "Nro Actual 2: " & NroActualFis & "; "
         End If

         If NroAuto <> oVMOld.NroAuto Then
            strMsg &= "Autonumerar: " & ToByteStr(NroAuto) & "; "
         End If

         If NroAutoGestion <> oVMOld.NroAutoGestion Then
            If NroAutoGestion = 0 Then
               strMsg &= "Autonumerar por Periodo; "
            Else
               strMsg &= "Autonumerar por Gestión; "
            End If
         End If

         If Firma <> oVMOld.Firma Then
            strMsg &= "Se cambio la Firma; "
         End If

         If TipoHojaDes <> oVMOld.TipoHojaDes Then
            strMsg &= "Tamaño Hoja: " & TipoHojaDes & "; "
         End If

         If TipoImpresionDes <> oVMOld.TipoImpresionDes Then
            strMsg &= "Impresión: " & TipoImpresionDes & "; "
         End If

         If TipoRespImpDes <> oVMOld.TipoRespImpDes Then
            strMsg &= "Responsable Imp.: " & TipoRespImpDes & "; "
         End If

         If RowsMax <> oVMOld.RowsMax Then
            strMsg &= "Max. Reg.: " & RowsMax & "; "
         End If

         If BloqueoAuto <> oVMOld.BloqueoAuto Then
            strMsg &= "Bloqueo Automatico al guardar Comprobante: " & ToByteStr(BloqueoAuto) & "; "
         End If

         If EncabezadoPorHoja <> oVMOld.EncabezadoPorHoja Then
            strMsg &= "Encabezado Por Hoja: " & ToByteStr(EncabezadoPorHoja) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & CompParaId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToShowOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If CompParaId > 0 Then

            If Gestion <> 0 Then
               strMsg &= "Gestión: " & Gestion & "; "
            End If

            If TipoCompDes <> "" Then
               strMsg &= "Tipo: " & TipoCompDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & CompParaId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
