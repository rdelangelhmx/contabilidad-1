Public Class clsPlanEEFFVM

   Public PlanEEFFId As Long
   Public EmpresaId As Long
   Public TipoEEFFId As Long
   Public PlanEEFFPadreId As Long
   Public PlanEEFFPadreDes As String
   Public PlanEEFFDes As String
   Public PlanEEFFCta As String
   Public Nivel As Long
   Public Orden As Long
   Public EsAna As Byte
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByRef PlanEEFFId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PlanEEFFId > 0 Then

         If PlanEEFFPadreDes <> "" Then
            strMsg &= "Cuenta Padre: " & PlanEEFFPadreDes & "; "
         ElseIf PlanEEFFPadreId <> 0 Then
            strMsg &= "Cuenta Padre: " & PlanEEFFDesFind(PlanEEFFPadreId) & "; "
         End If

         If PlanEEFFCta <> "" Then
            strMsg &= "Código Cuenta: " & PlanEEFFCta & "; "
         End If

         If TipoEEFFId <> 0 Then
            strMsg &= "Tipo: " & TipoCompDesFind(TipoEEFFId) & "; "
         End If

         If PlanEEFFDes <> "" Then
            strMsg &= "Descripción: " & PlanEEFFDes & "; "
         End If

         If Nivel <> 0 Then
            strMsg &= "Nivel: " & Nivel & "; "
         End If

         If Orden <> 0 Then
            strMsg &= "Orden: " & Orden & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         ElseIf EstadoId <> 0 Then
            strMsg &= "Estado: " & EstadoDesFind(EstadoId) & "; "
         End If

         If EsAna <> 0 Then
            strMsg &= "Cuenta Analítico: Sí; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PlanEEFFId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsPlanEEFFVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PlanEEFFId > 0 Then

         If PlanEEFFPadreDes <> oVMOld.PlanEEFFPadreDes Then
            strMsg &= "Cuenta Padre: " & PlanEEFFPadreDes & "; "
         End If

         If PlanEEFFCta <> oVMOld.PlanEEFFCta Then
            strMsg &= "Código Cuenta: " & PlanEEFFCta & "; "
         End If

         If TipoEEFFId <> oVMOld.TipoEEFFId Then
            strMsg &= "Tipo: " & TipoCompDesFind(TipoEEFFId) & "; "
         End If

         If PlanEEFFDes <> oVMOld.PlanEEFFDes Then
            strMsg &= "Descripción: " & PlanEEFFDes & "; "
         End If

         If Nivel <> oVMOld.Nivel Then
            strMsg &= "Nivel: " & Nivel & "; "
         End If

         If Orden <> oVMOld.Orden Then
            strMsg &= "Orden: " & Orden & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If EsAna <> oVMOld.EsAna Then
            strMsg &= "Cuenta Analítico: " & ToByteStr(EsAna) & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PlanEEFFId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If PlanEEFFId > 0 Then

            If PlanEEFFCta <> "" Then
               strMsg &= "Código Cuenta: " & PlanEEFFCta & "; "
            End If

            If PlanEEFFDes <> "" Then
               strMsg &= "Descripción: " & PlanEEFFDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & PlanEEFFId & "; " & strMsg)

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
         If PlanEEFFId > 0 Then

            If PlanEEFFCta <> "" Then
               strMsg &= "Código Cuenta: " & PlanEEFFCta & "; "
            End If

            If PlanEEFFDes <> "" Then
               strMsg &= "Descripción: " & PlanEEFFDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & PlanEEFFId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   Public Function TipoCompDesFind(ByVal lngTipoCompId As Long) As String
      Dim oTipoComp As New clsTipoComp(clsAppInfo.ConnectString)
      oTipoComp.TipoCompId = lngTipoCompId
      oTipoComp.FindByPK()
      Return oTipoComp.TipoCompDes
   End Function

   Public Function PlanEEFFDesFind(ByVal lngPlanEEFFId As Long) As String
      Dim oPlanEEFF As New clsPlanEEFF(clsAppInfo.ConnectString)
      oPlanEEFF.PlanEEFFId = lngPlanEEFFId
      oPlanEEFF.FindByPK()
      Return oPlanEEFF.PlanEEFFDes
   End Function

   Public Function EstadoDesFind(ByVal lngEstadoId As Long) As String
      Dim oEstado As New clsEstado(clsAppInfo.ConnectString)
      oEstado.EstadoId = lngEstadoId
      oEstado.FindByPK()
      Return oEstado.EstadoDes
   End Function

End Class
