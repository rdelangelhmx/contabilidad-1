Module modStatus

   Public Sub StatusDataBaseDisplay(ByVal strMsg As String)
      gfrmMain.sbrMain.Panels(0).Text = strMsg
   End Sub

   Public Sub StatusEnterpriseDisplay(ByVal strMsg As String)
      gfrmMain.sbrMain.Panels(1).Text = strMsg
   End Sub

   Public Sub StatusGestionDisplay(ByVal strMsg As String)
      gfrmMain.sbrMain.Panels(2).Text = strMsg
   End Sub

   Public Sub StatusLoginDisplay(ByVal strMsg As String)
      gfrmMain.sbrMain.Panels(3).Text = strMsg
   End Sub

   Public Sub StatusFormDisplay(ByVal strMsg As String)
      gfrmMain.sbrMain.Panels(4).Text = strMsg
   End Sub
End Module
