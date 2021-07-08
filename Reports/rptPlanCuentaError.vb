Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document


Public Class rptPlanCuentaError
   Dim imgWarning As Image
   Dim imgError As Image
   Dim imgInfo As Image

   WriteOnly Property WarningImage() As Image
      Set(ByVal value As Image)
         imgWarning = value
      End Set
   End Property

   WriteOnly Property ErrorImage() As Image
      Set(ByVal value As Image)
         imgError = value
      End Set
   End Property

   WriteOnly Property InfoImage() As Image
      Set(ByVal value As Image)
         imgInfo = value
      End Set
   End Property

   Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
      If ToLong(Me.Fields("Prioridad").Value) = 1 Then
         Picture1.Image = imgError
      ElseIf ToLong(Me.Fields("Prioridad").Value) = 2 Then
         Picture1.Image = imgWarning
      ElseIf ToLong(Me.Fields("Prioridad").Value) = 3 Then
         Picture1.Image = imgInfo
      End If
   End Sub

   Private Sub ReportHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportHeader1.Format
      picError.Image = imgError
      picWarning.Image = imgWarning
      picInfo.Image = imgInfo
      lblError.Text = "Error"
      lblWarning.Text = "Advertencia"
      lblInfo.Text = "Informacion"
   End Sub
End Class
