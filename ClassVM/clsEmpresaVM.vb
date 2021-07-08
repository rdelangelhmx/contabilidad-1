Public Class clsEmpresaVM
   Public EmpresaId As Long
   Public EmpresaDes As String
   Public EmpresaRUC As String
   Public Direccion As String
   Public CiudadId As Long
   Public CiudadDes As String
   Public Telefono1 As String
   Public Telefono2 As String
   Public Movil As String
   Public Fax As String
   Public CodPostal As String
   Public Email As String
   Public Web As String
   Public MesAperturaId As Long
   Public MesAperturaDes As String
   Public MesCierreId As Long
   Public MesCierreDes As String
   Public MonedaId As Long
   Public MonedaDes As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef EmpresaId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And EmpresaId > 0 Then

         If EmpresaDes <> "" Then
            strMsg &= "Empresa: " & EmpresaDes & "; "
         End If

         If EmpresaRUC <> "" Then
            strMsg &= "NIT: " & EmpresaRUC & "; "
         End If

         If Direccion <> "" Then
            strMsg &= "Dirección: " & Direccion & "; "
         End If

         If CiudadDes <> "" Then
            strMsg &= "Ciudad: " & CiudadDes & "; "
         End If

         If Telefono1 <> "" Then
            strMsg &= "Telefono 1: " & Telefono1 & "; "
         End If

         If Telefono2 <> "" Then
            strMsg &= "Telefono 2: " & Telefono2 & "; "
         End If

         If Movil <> "" Then
            strMsg &= "Movil: " & Movil & "; "
         End If

         If Fax <> "" Then
            strMsg &= "Fax: " & Fax & "; "
         End If

         If CodPostal <> "" Then
            strMsg &= "Código Postal: " & CodPostal & "; "
         End If

         If Email <> "" Then
            strMsg &= "Correo: " & Email & "; "
         End If

         If Web <> "" Then
            strMsg &= "Página Web: " & Web & "; "
         End If

         If MesAperturaId <> 0 Then
            Dim oMes As New clsMes(clsAppInfo.ConnectString)
            oMes.MesId = MesAperturaId
            oMes.FindByPK()
            MesAperturaDes = oMes.MesDes

            If MesAperturaDes <> "" Then
               strMsg &= "Mes Apertura: " & MesAperturaDes & "; "
            End If
         End If

         If MesCierreDes <> "" Then
            strMsg &= "Cierre de Gestión en el Mes: " & MesCierreDes & "; "
         End If

         If MonedaDes <> "" Then
            strMsg &= "Moneda por Defecto: " & MonedaDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & EmpresaId & "; " & strMsg)
            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsEmpresaVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And EmpresaId > 0 Then

         If EmpresaDes <> oVMOld.EmpresaDes Then
            strMsg &= "Empresa: " & EmpresaDes & "; "
         End If

         If EmpresaRUC <> oVMOld.EmpresaRUC Then
            strMsg &= "NIT: " & EmpresaRUC & "; "
         End If

         If Direccion <> oVMOld.Direccion Then
            strMsg &= "Dirección: " & Direccion & "; "
         End If

         If CiudadDes <> oVMOld.CiudadDes Then
            strMsg &= "Ciudad: " & CiudadDes & "; "
         End If

         If Telefono1 <> oVMOld.Telefono1 Then
            strMsg &= "Telefono 1: " & Telefono1 & "; "
         End If

         If Telefono2 <> oVMOld.Telefono2 Then
            strMsg &= "Telefono 2: " & Telefono2 & "; "
         End If

         If Movil <> oVMOld.Movil Then
            strMsg &= "Movil: " & Movil & "; "
         End If

         If Fax <> oVMOld.Fax Then
            strMsg &= "Fax: " & Fax & "; "
         End If

         If CodPostal <> oVMOld.CodPostal Then
            strMsg &= "Código Postal: " & CodPostal & "; "
         End If

         If Email <> oVMOld.Email Then
            strMsg &= "Correo: " & Email & "; "
         End If

         If Web <> oVMOld.Web Then
            strMsg &= "Página Web: " & Web & "; "
         End If

         If MesAperturaId <> oVMOld.MesAperturaId Then
            Dim oMes As New clsMes(clsAppInfo.ConnectString)
            oMes.MesId = MesAperturaId
            oMes.FindByPK()
            MesAperturaDes = oMes.MesDes

            If MesAperturaDes <> "" Then
               strMsg &= "Mes Apertura: " & MesAperturaDes & "; "
            End If
         End If

         If MesCierreDes <> oVMOld.MesCierreDes Then
            strMsg &= "Cierre de Gestión en el Mes: " & MesCierreDes & "; "
         End If

         If MonedaDes <> oVMOld.MonedaDes Then
            strMsg &= "Moneda por Defecto: " & MonedaDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & EmpresaId & "; " & strMsg)
            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If EmpresaId > 0 Then

            If EmpresaDes <> "" Then
               strMsg &= "Empresa: " & EmpresaDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & EmpresaId & "; " & strMsg)
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
         If EmpresaId > 0 Then

            If EmpresaDes <> "" Then
               strMsg &= "Empresa: " & EmpresaDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & EmpresaId & "; " & strMsg)
               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

End Class