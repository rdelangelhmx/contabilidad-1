Public Class clsPlanAddVM
   Public PlanAddId As Long
   Public EmpresaId As Long
   Public PlanId As Long
   Public PlanDes As String
   Public PlanAddDes As String
   Public PlanAddCta As String
   Public EstadoId As Long
   Public EstadoDes As String

   Public FormName As String
   Public FormText As String

   Public Function ToOpeAdd(ByVal bytTipoOpera As Byte, ByVal PlanAddId As Long) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PlanAddId > 0 Then

         If PlanDes <> "" Then
            strMsg &= "Cuenta Padre: " & PlanDes & "; "
         End If

         If PlanAddCta <> "" Then
            strMsg &= "Código Cuenta: " & PlanAddCta & "; "
         End If

         If PlanAddDes <> "" Then
            strMsg &= "Descripción: " & PlanAddDes & "; "
         End If

         If EstadoDes <> "" Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PlanAddId & "; " & strMsg)

            ToOpeAdd = True
         Else
            ToOpeAdd = False
         End If
      End If
   End Function

   Public Function ToChangeOpeUpdate(ByVal oVMOld As clsPlanAddVM, ByVal bytTipoOpera As Byte) As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora And PlanAddId > 0 Then

         If PlanDes <> oVMOld.PlanDes Then
            strMsg &= "Cuenta Padre: " & PlanDes & "; "
         End If

         If PlanAddCta <> oVMOld.PlanAddCta Then
            strMsg &= "Código Cuenta: " & PlanAddCta & "; "
         End If

         If PlanAddDes <> oVMOld.PlanAddDes Then
            strMsg &= "Descripción: " & PlanAddDes & "; "
         End If

         If EstadoDes <> oVMOld.EstadoDes Then
            strMsg &= "Estado: " & EstadoDes & "; "
         End If

         If strMsg.Trim <> String.Empty Then
            Call modAuditoria.AudiOpeAdd(FormName, FormText, bytTipoOpera, "Id: " & PlanAddId & "; " & strMsg)

            ToChangeOpeUpdate = True
         Else
            ToChangeOpeUpdate = False
         End If
      End If
   End Function

   Public Function ToDeleteOpe() As Boolean
      Dim strMsg As String = String.Empty

      If clsAppInfo.RegistrarBitacora Then
         If PlanAddId > 0 Then

            If PlanAddCta <> "" Then
               strMsg &= "Código Cuenta: " & PlanAddCta & "; "
            End If

            If PlanAddDes <> "" Then
               strMsg &= "Descripción: " & PlanAddDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.ELIMINA, "Id: " & PlanAddId & "; " & strMsg)

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
         If PlanAddId > 0 Then

            If PlanAddCta <> "" Then
               strMsg &= "Código Cuenta: " & PlanAddCta & "; "
            Else
               Call PlanAddDesFind(PlanAddId, PlanAddCta, PlanAddDes)
            End If

            If PlanAddDes <> "" Then
               strMsg &= "Descripción: " & PlanAddDes & "; "
            End If

            If strMsg.Trim <> String.Empty Then
               Call modAuditoria.AudiOpeAdd(FormName, FormText, clsTipoOpera.CONSULTA, "Id: " & PlanAddId & "; " & strMsg)

               ToShowOpe = True
            Else
               ToShowOpe = False
            End If
         End If
      End If
   End Function

   Public Sub PlanAddDesFind(ByVal lngPlanAddId As Long, ByRef strPlanAddCta As String, ByRef strPlanAddDes As String)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      oPlanAdd.PlanAddId = lngPlanAddId
      oPlanAdd.FindByPK()
      strPlanAddCta = oPlanAdd.PlanAddCta
      strPlanAddDes = oPlanAdd.PlanAddDes
   End Sub

End Class
