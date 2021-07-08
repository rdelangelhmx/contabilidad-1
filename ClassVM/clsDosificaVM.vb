Public Class clsDosificaVM
   Public DosificaId As Long
   Public EmpresaId As Long
   Public SucursalId As Long
   Public SucursalDes As String
   Public TipoDosificaId As Long
   Public TipoDosificaDes As String
   Public NroAutorizacion As String
   Public LlaveDosifica As String
   Public NumeroSFC As Long
   Public NumeroIni As Long
   Public NumeroFin As Long
   Public NumeroActual As Long
   Public FechaIni As String
   Public FechaFin As String
   Public DosificaLeyId As Long
   Public DosificaLeyDes As String
   Public ImpDosificaLey As Byte
   Public TipoImpresionId As Long
   Public TipoImpresionDes As String
   Public TipoFormImpId As Long
   Public TipoFormImpDes As String
   Public NroCopia As Long
   Public PrintOrigCopia As Byte
   Public CantItem As Long
   Public DosificaVentaId As Long
   Public DosificaVentaDes As String
   Public DosificaDes As String
   Public EstadoId As Long
   Public EstadoDes As String
   
   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef DosificaId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And DosificaId > 0 Then

         If SucursalDes <> "" Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         End If

         If TipoDosificaDes <> "" Then
            strMsg &= "Tipo Dosifica.: " & TipoDosificaDes & "; "
         End If

         If NroAutorizacion <> "" Then
            strMsg &= "Nro Autorizacion: " & NroAutorizacion & "; "
         End If

         If NumeroSFC <> 0 Then
            strMsg &= "SFC: " & NumeroSFC & "; "
         End If

         If LlaveDosifica <> "" Then
            strMsg &= "Llave Dosifica.: " & LlaveDosifica & "; "
         End If

         If NumeroIni <> 0 Then
            strMsg &= "Número Inicial: " & NumeroIni & "; "
         End If

         If NumeroFin <> 0 Then
            strMsg &= "Número Final: " & NumeroFin & "; "
         End If

         If NumeroActual <> 0 Then
            strMsg &= "Número Actual: " & NumeroActual & "; "
         End If

         If FechaIni <> "" Then
            strMsg &= "Fecha Inicial: " & FechaIni & "; "
         End If

         If FechaFin <> "" Then
            strMsg &= "Fecha Final: " & FechaFin & "; "
         End If

         If DosificaLeyDes <> "" Then
            strMsg &= "Mensaje 1: " & DosificaLeyDes & "; "
         End If

         If ImpDosificaLey <> 0 Then
            strMsg &= "Imprimir Ley: " & ToByteStr(ImpDosificaLey) & "; "
         End If

         If TipoImpresionDes <> "" Then
            strMsg &= "Impresión: " & TipoImpresionDes & "; "
         End If

         If TipoFormImpDes <> "" Then
            strMsg &= "Formato Impresión: " & TipoFormImpDes & "; "
         End If

         If NroCopia <> 0 Then
            strMsg &= "Nro. Copias: " & ToStr(NroCopia) & "; "
         End If

         If PrintOrigCopia <> 0 Then
            strMsg &= "Leyenda Org/Copia: " & ToByteStr(PrintOrigCopia) & "; "
         End If

         If CantItem <> 0 Then
            strMsg &= "Cantidad Item: " & ToStr(CantItem) & "; "
         End If

         If DosificaVentaDes <> "" Then
            strMsg &= "Dosificación: " & DosificaVentaDes & "; "
         End If

         If DosificaDes <> "" Then
            strMsg &= "Descripción: " & DosificaDes & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & DosificaId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsDosificaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And DosificaId > 0 Then

         If SucursalDes <> oVMOld.SucursalDes Then
            strMsg &= "Sucursal: " & SucursalDes & "; "
         End If

         If TipoDosificaDes <> oVMOld.TipoDosificaDes Then
            strMsg &= "Tipo Dosifica.: " & TipoDosificaDes & "; "
         End If

         If NroAutorizacion <> oVMOld.NroAutorizacion Then
            strMsg &= "Nro Autorizacion: " & NroAutorizacion & "; "
         End If

         If NumeroSFC <> oVMOld.NumeroSFC Then
            strMsg &= "SFC: " & NumeroSFC & "; "
         End If

         If LlaveDosifica <> oVMOld.LlaveDosifica Then
            strMsg &= "Llave Dosifica.: " & LlaveDosifica & "; "
         End If

         If NumeroIni <> oVMOld.NumeroIni Then
            strMsg &= "Número Inicial: " & NumeroIni & "; "
         End If

         If NumeroFin <> oVMOld.NumeroFin Then
            strMsg &= "Número Final: " & NumeroFin & "; "
         End If

         If NumeroActual <> oVMOld.NumeroActual Then
            strMsg &= "Número Actual: " & NumeroActual & "; "
         End If

         If FechaIni <> oVMOld.FechaIni Then
            strMsg &= "Fecha Inicial: " & FechaIni & "; "
         End If

         If FechaFin <> oVMOld.FechaFin Then
            strMsg &= "Fecha Final: " & FechaFin & "; "
         End If

         If DosificaLeyDes <> oVMOld.DosificaLeyDes Then
            strMsg &= "Mensaje 1: " & DosificaLeyDes & "; "
         End If

         If ImpDosificaLey <> oVMOld.ImpDosificaLey Then
            strMsg &= "Imprimir Ley: " & ToByteStr(ImpDosificaLey) & "; "
         End If

         If TipoImpresionDes <> oVMOld.TipoImpresionDes Then
            strMsg &= "Impresión: " & TipoImpresionDes & "; "
         End If

         If TipoFormImpDes <> oVMOld.TipoFormImpDes Then
            strMsg &= "Formato Impresión: " & TipoFormImpDes & "; "
         End If

         If NroCopia <> oVMOld.NroCopia Then
            strMsg &= "Nro. Copias: " & ToStr(NroCopia) & "; "
         End If

         If PrintOrigCopia <> oVMOld.PrintOrigCopia Then
            strMsg &= "Leyenda Org/Copia: " & ToByteStr(PrintOrigCopia) & "; "
         End If

         If CantItem <> oVMOld.CantItem Then
            strMsg &= "Cantidad Item: " & ToStr(CantItem) & "; "
         End If

         If DosificaVentaDes <> oVMOld.DosificaVentaDes Then
            strMsg &= "Dosificación: " & DosificaVentaDes & "; "
         End If

         If DosificaDes <> oVMOld.DosificaDes Then
            strMsg &= "Descripción: " & DosificaDes & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & DosificaId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If DosificaId > 0 Then
            If SucursalDes <> "" Then
               strMsg &= "Sucursal: " & SucursalDes & "; "
            End If

            If TipoDosificaDes <> "" Then
               strMsg &= "Tipo Dosifica.: " & TipoDosificaDes & "; "
            End If

            If NroAutorizacion <> 0 Then
               strMsg &= "Nro Autorizacion: " & NroAutorizacion & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & DosificaId & "; " & strMsg)

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
         If DosificaId > 0 Then

            If SucursalDes <> "" Then
               strMsg &= "Sucursal: " & SucursalDes & "; "
            End If

            If TipoDosificaDes <> "" Then
               strMsg &= "Tipo Dosifica.: " & TipoDosificaDes & "; "
            End If

            If NroAutorizacion <> 0 Then
               strMsg &= "Nro Autorizacion: " & NroAutorizacion & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & DosificaId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class
