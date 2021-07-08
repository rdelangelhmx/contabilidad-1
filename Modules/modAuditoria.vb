Imports System.Reflection

Module modAuditoria

   '*********************************************************'
   '* DESCRIPCION : Funcion que inserta en la tabla de      *'
   '*               auditoria de Documentos (secAudiDoc)    *'
   '*               las transacciones realizadas(Solo Doc.) *'
   '*               por el usuario en el sistema.           *'
   '*********************************************************'
   '* PARAMETROS  :                                         *'
   '* lngNroDocId   : Id. del nro. del doc. generado.       *'
   '* lngNroDoc     : Nro. del doc. generado.               *'
   '* lngTipoDocDes : Tipo del documento generado.          *'
   '* lngTipoOpera  : El Tipo de operacion realizada con el *'
   '*                 doc. generado (Nuevo; Modifica....).  *'
   '* lngPersonaId  : El id. de la persona que esta ligada  *'
   '*                 al documento generado si es que tiene *'
   '*                 (Cliente, Proveedor, Agente, etc.     *'
   '* strNomPersona : Nombre de la Persona.                 *' 
   '* strObserReg   : Observacion de los dato del doc.      *'
   '*********************************************************'
   '* RETORNA     : Retorna un status si inserto bien o no  *'
   '*               a la bitacora.                          *'  
   '*********************************************************'

   Public Function AudiDocAdd(ByVal lngNroDocId As Integer, ByVal lngNroDoc As Integer, _
                              ByVal strTipoDocDes As String, ByVal lngTipoOperaId As Long, _
                              ByVal lngPersonaId As Integer, ByVal strNomPersona As String, _
                              ByVal strobserReg As String, Optional ByVal lngGestionId As Long = 0, Optional ByVal lngGestion As Long = 0) As Boolean
      AudiDocAdd = False

      If clsAppInfo.RegistrarBitacora Then
         Dim oAudiDoc As New clsAudiDoc(clsAppInfo.ConnectString)
         Dim oConnection As New Data.OleDb.OleDbConnection(clsAppInfo.ConnectString)
         Dim strFechaReg As String
         Dim strEquipoReg As String

         Try
            oConnection.Open()
            With oAudiDoc
               .AppId = clsAppInfo.AppId
               .AppDes = clsAppInfo.AppDes
               .EmpresaId = clsAppInfo.EmpresaId
               .EmpresaDes = clsAppInfo.EmpresaDes
               .GestionId = If(lngGestionId = 0, clsAppInfo.GestionId, lngGestionId)
               .Gestion = If(lngGestion = 0, clsAppInfo.Gestion, lngGestion)
               .NroDocId = lngNroDocId
               .NroDoc = lngNroDoc
               .TipoDocDes = strTipoDocDes
               .FechaReg = modSysData.DateSrvNow(oConnection)
               .TipoOperaId = lngTipoOperaId 'NameTipoOpera(strTipoOpera)
               .PersonaId = lngPersonaId
               .NomPersona = strNomPersona
               .UserIdReg = clsAppInfo.UserId
               .LoginId = clsAppInfo.LoginId
               .EquipoReg = System.Net.Dns.GetHostName()
               .ObserReg = If(strobserReg.Length > 1000, strobserReg.Substring(0, 1000), strobserReg)

               If .Insert() Then
                  AudiDocAdd = True
               End If
            End With

         Catch exp As Exception
            AudiDocAdd = False

         Finally
            oAudiDoc.Dispose()
         End Try
      End If
   End Function


   '*********************************************************'
   '* DESCRIPCION : Funcion que inserta en la tabla de      *'
   '*               auditoria de operaciones (secAudiOpe)   *'
   '*               las acciones u/o operaciones realizadas *'
   '*               por el usuario desde que inicia sesion  *'
   '*               en el sistema.                          *'
   '*********************************************************'
   '* PARAMETROS  :                                         *'
   '* strFormName   : Nombre del Formulario.                *'
   '* lngTipoOperaId  : El Tipo de operacion realizada por el *'
   '*                 Usuario (Nuevo; Modifica....).        *'
   '* strObserReg   : Observacion de la operacion.          *'
   '*********************************************************'
   '* RETORNA     : Retorna un status si inserto bien o no  *'
   '*               a la bitacora de operaciones.           *'  
   '*********************************************************'

   Public Function AudiOpeAdd(ByVal strFormName As String, ByVal strFormText As String, ByVal lngTipoOperaId As Long, _
                              ByVal strObserReg As String) As Boolean
      AudiOpeAdd = False

      If clsAppInfo.RegistrarBitacora Then
         Dim oAudiOpe As New clsAudiOpe(clsAppInfo.ConnectString)
         Dim oConnection As New Data.OleDb.OleDbConnection(clsAppInfo.ConnectString)
         Try
            oConnection.Open()
            With oAudiOpe
               .AppId = clsAppInfo.AppId
               .AppDes = ToStr(clsAppInfo.AppDes)
               .EmpresaId = clsAppInfo.EmpresaId
               .EmpresaDes = ToStr(clsAppInfo.EmpresaDes)
               .UserIdReg = clsAppInfo.UserId
               .LoginId = ToStr(clsAppInfo.LoginId)
               .FechaReg = modSysData.DateSrvNow(oConnection)
               .FormName = strFormName
               .FormText = strFormText
               .TipoOperaId = lngTipoOperaId 'NameTipoOpera(strTipoOpera)
               .EquipoReg = System.Net.Dns.GetHostName()
               .ObserReg = If(strObserReg.Length > 1000, strObserReg.Substring(0, 1000), strObserReg)

               If .Insert() Then
                  AudiOpeAdd = True
               End If
            End With

         Catch exp As Exception
            MessageBox.Show(exp.Message, "modAuditoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            AudiOpeAdd = False

         Finally
            oAudiOpe.Dispose()
         End Try
      End If
   End Function

   Public Function ToByteStr(ByVal Value As Byte) As String
      If Value = 0 Then
         Return "No"
      Else
         Return "Sí"
      End If
   End Function
End Module
