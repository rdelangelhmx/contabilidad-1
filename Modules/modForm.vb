Module modForm

   Public Const PlanDesWidth As Long = 400

    Sub FormCenter(ByVal frmCurrent As Form)
      'frmCurrent.Top = (Screen.PrimaryScreen.WorkingArea.Height - frmCurrent.Height) \ 2
      'frmCurrent.Left = (Screen.PrimaryScreen.WorkingArea.Width - frmCurrent.Width) \ 2
   End Sub

   Public Sub FormCenterChild(ByVal frmCurrent As Form)
      'frmCurrent.Top = ((frmMain.ActiveForm.Height) - frmCurrent.Height) \ 2
      'frmCurrent.Left = (frmMain.ActiveForm.Width - frmCurrent.Width) \ 2

      'frmCurrent.Top = (gfrmMain.Height - frmCurrent.Height) \ 2
      'frmCurrent.Left = (gfrmMain.Width - frmCurrent.Width) \ 2

      If frmCurrent.WindowState <> FormWindowState.Minimized Then
         frmCurrent.Location = New Point(20, 20)
         frmCurrent.Height = gfrmMain.ClientSize.Height - gfrmMain.TopRebar1.Height - gfrmMain.sbrMain.Height - 40
         frmCurrent.Width = gfrmMain.ClientSize.Width - 40
      End If
   End Sub

   'Public Function ForcePageSize(ByRef oPrintDocument As System.Drawing.Printing.PrintDocument, ByVal oPaperKind As System.Drawing.Printing.PaperKind) As Boolean
   '   For i As Integer = 0 To oPrintDocument.PrinterSettings.PaperSizes.Count
   '      If oPrintDocument.PrinterSettings.PaperSizes(i).Kind = oPaperKind Then
   '         oPrintDocument.DefaultPageSettings.PaperSize = oPrintDocument.PrinterSettings.PaperSizes(i)

   '         Return True
   '      End If
   '   Next

   '   Return False
   'End Function

   Public Sub ForcePageSize(ByRef oPrinter As DataDynamics.ActiveReports.Document.Printer, ByRef oPageSettings As DataDynamics.ActiveReports.PageSettings, ByVal lngTipoHojaId As Long)
      oPrinter.PrinterName = ""

      With oPageSettings
         .Margins.Left = 0.5
         .Margins.Right = 0.5
         .Margins.Top = 0.5
         .Margins.Bottom = 0.3
      End With

      If lngTipoHojaId = 1 Then 'Carta
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Letter
         End With

      ElseIf lngTipoHojaId = 2 Then 'Media Carta
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Custom
            .PaperHeight = 5.5
            .PaperWidth = 8.5
         End With

      ElseIf lngTipoHojaId = 3 Then 'Oficio
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Custom
            .PaperHeight = 13
            .PaperWidth = 8.5
         End With

      ElseIf lngTipoHojaId = 4 Then 'Medio Oficio
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Custom
            .PaperHeight = 6.5
            .PaperWidth = 8.5
         End With

      Else
         With oPageSettings
            .PaperKind = Drawing.Printing.PaperKind.Letter
         End With
      End If
   End Sub

End Module
