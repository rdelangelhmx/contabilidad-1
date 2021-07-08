<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptChequeImp
   Inherits DataDynamics.ActiveReports.ActiveReport3

   'Form overrides dispose to clean up the component list.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
      End If
      MyBase.Dispose(disposing)
   End Sub

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.
   'Do not modify it using the code editor.
   Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
   <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptChequeImp))
      Me.Detail1 = New DataDynamics.ActiveReports.Detail
      Me.txtLugar = New DataDynamics.ActiveReports.TextBox
      Me.txtPaguese = New DataDynamics.ActiveReports.TextBox
      Me.txtDia = New DataDynamics.ActiveReports.TextBox
      Me.txtMes = New DataDynamics.ActiveReports.TextBox
      Me.txtAnio = New DataDynamics.ActiveReports.TextBox
      Me.txtImporte = New DataDynamics.ActiveReports.TextBox
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.txtConcepto = New DataDynamics.ActiveReports.TextBox
      Me.txtDeMes = New DataDynamics.ActiveReports.TextBox
      Me.txtDeAnio = New DataDynamics.ActiveReports.TextBox
      CType(Me.txtLugar, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPaguese, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDia, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDeMes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDeAnio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail1
      '
      Me.Detail1.ColumnSpacing = 0.0!
      Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtLugar, Me.txtPaguese, Me.txtDia, Me.txtMes, Me.txtAnio, Me.txtImporte, Me.txtLiteral, Me.txtConcepto, Me.txtDeMes, Me.txtDeAnio})
      Me.Detail1.Height = 2.989583!
      Me.Detail1.Name = "Detail1"
      '
      'txtLugar
      '
      Me.txtLugar.Border.BottomColor = System.Drawing.Color.Black
      Me.txtLugar.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLugar.Border.LeftColor = System.Drawing.Color.Black
      Me.txtLugar.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLugar.Border.RightColor = System.Drawing.Color.Black
      Me.txtLugar.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLugar.Border.TopColor = System.Drawing.Color.Black
      Me.txtLugar.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLugar.Height = 0.1875!
      Me.txtLugar.Left = 1.0!
      Me.txtLugar.Name = "txtLugar"
      Me.txtLugar.Style = "ddo-char-set: 0; font-style: italic; font-size: 9.75pt; font-family: Arial; verti" & _
          "cal-align: top; "
      Me.txtLugar.Text = "LUGAR"
      Me.txtLugar.Top = 0.375!
      Me.txtLugar.Width = 1.0625!
      '
      'txtPaguese
      '
      Me.txtPaguese.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPaguese.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPaguese.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPaguese.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPaguese.Border.RightColor = System.Drawing.Color.Black
      Me.txtPaguese.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPaguese.Border.TopColor = System.Drawing.Color.Black
      Me.txtPaguese.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPaguese.Height = 0.1875!
      Me.txtPaguese.Left = 1.0!
      Me.txtPaguese.Name = "txtPaguese"
      Me.txtPaguese.Style = "ddo-char-set: 0; font-style: italic; font-size: 9.75pt; font-family: Arial; "
      Me.txtPaguese.Text = "PAGUESE"
      Me.txtPaguese.Top = 0.625!
      Me.txtPaguese.Width = 4.75!
      '
      'txtDia
      '
      Me.txtDia.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDia.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDia.Border.RightColor = System.Drawing.Color.Black
      Me.txtDia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDia.Border.TopColor = System.Drawing.Color.Black
      Me.txtDia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDia.Height = 0.1875!
      Me.txtDia.Left = 2.0625!
      Me.txtDia.Name = "txtDia"
      Me.txtDia.Style = "ddo-char-set: 0; font-style: italic; font-size: 9.75pt; font-family: Arial; verti" & _
          "cal-align: top; "
      Me.txtDia.Text = "DIA"
      Me.txtDia.Top = 0.375!
      Me.txtDia.Width = 0.3125!
      '
      'txtMes
      '
      Me.txtMes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMes.Border.RightColor = System.Drawing.Color.Black
      Me.txtMes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMes.Border.TopColor = System.Drawing.Color.Black
      Me.txtMes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMes.Height = 0.1875!
      Me.txtMes.Left = 2.625!
      Me.txtMes.Name = "txtMes"
      Me.txtMes.Style = "ddo-char-set: 0; font-style: italic; font-size: 9.75pt; font-family: Arial; verti" & _
          "cal-align: top; "
      Me.txtMes.Text = "MES"
      Me.txtMes.Top = 0.375!
      Me.txtMes.Width = 0.6875!
      '
      'txtAnio
      '
      Me.txtAnio.Border.BottomColor = System.Drawing.Color.Black
      Me.txtAnio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtAnio.Border.LeftColor = System.Drawing.Color.Black
      Me.txtAnio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtAnio.Border.RightColor = System.Drawing.Color.Black
      Me.txtAnio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtAnio.Border.TopColor = System.Drawing.Color.Black
      Me.txtAnio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtAnio.Height = 0.1875!
      Me.txtAnio.Left = 3.5625!
      Me.txtAnio.Name = "txtAnio"
      Me.txtAnio.Style = "ddo-char-set: 0; font-style: italic; font-size: 9.75pt; font-family: Arial; verti" & _
          "cal-align: top; "
      Me.txtAnio.Text = "AÑO"
      Me.txtAnio.Top = 0.375!
      Me.txtAnio.Width = 0.5!
      '
      'txtImporte
      '
      Me.txtImporte.Border.BottomColor = System.Drawing.Color.Black
      Me.txtImporte.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtImporte.Border.LeftColor = System.Drawing.Color.Black
      Me.txtImporte.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtImporte.Border.RightColor = System.Drawing.Color.Black
      Me.txtImporte.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtImporte.Border.TopColor = System.Drawing.Color.Black
      Me.txtImporte.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtImporte.Height = 0.1875!
      Me.txtImporte.Left = 4.5!
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.Style = "ddo-char-set: 0; font-weight: bold; font-style: italic; font-size: 9.75pt; font-f" & _
          "amily: Arial; vertical-align: top; "
      Me.txtImporte.Text = "IMPORTE"
      Me.txtImporte.Top = 0.375!
      Me.txtImporte.Width = 1.25!
      '
      'txtLiteral
      '
      Me.txtLiteral.Border.BottomColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLiteral.Border.LeftColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLiteral.Border.RightColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLiteral.Border.TopColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLiteral.Height = 0.1875!
      Me.txtLiteral.Left = 1.0!
      Me.txtLiteral.Name = "txtLiteral"
      Me.txtLiteral.Style = "ddo-char-set: 0; font-style: italic; font-size: 9.75pt; font-family: Arial; "
      Me.txtLiteral.Text = "LITERAL"
      Me.txtLiteral.Top = 0.9375!
      Me.txtLiteral.Width = 4.75!
      '
      'txtConcepto
      '
      Me.txtConcepto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtConcepto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtConcepto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtConcepto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtConcepto.Border.RightColor = System.Drawing.Color.Black
      Me.txtConcepto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtConcepto.Border.TopColor = System.Drawing.Color.Black
      Me.txtConcepto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtConcepto.Height = 0.1875!
      Me.txtConcepto.Left = 1.0!
      Me.txtConcepto.Name = "txtConcepto"
      Me.txtConcepto.Style = "ddo-char-set: 0; font-style: italic; font-size: 9.75pt; font-family: Arial; "
      Me.txtConcepto.Text = "CONCEPTO"
      Me.txtConcepto.Top = 1.625!
      Me.txtConcepto.Width = 4.75!
      '
      'txtDeMes
      '
      Me.txtDeMes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDeMes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDeMes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDeMes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDeMes.Border.RightColor = System.Drawing.Color.Black
      Me.txtDeMes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDeMes.Border.TopColor = System.Drawing.Color.Black
      Me.txtDeMes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDeMes.Height = 0.1875!
      Me.txtDeMes.Left = 2.375!
      Me.txtDeMes.Name = "txtDeMes"
      Me.txtDeMes.Style = "ddo-char-set: 0; font-style: italic; font-size: 9.75pt; font-family: Arial; verti" & _
          "cal-align: top; "
      Me.txtDeMes.Text = "de"
      Me.txtDeMes.Top = 0.375!
      Me.txtDeMes.Width = 0.25!
      '
      'txtDeAnio
      '
      Me.txtDeAnio.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDeAnio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDeAnio.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDeAnio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDeAnio.Border.RightColor = System.Drawing.Color.Black
      Me.txtDeAnio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDeAnio.Border.TopColor = System.Drawing.Color.Black
      Me.txtDeAnio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDeAnio.Height = 0.1875!
      Me.txtDeAnio.Left = 3.3125!
      Me.txtDeAnio.Name = "txtDeAnio"
      Me.txtDeAnio.Style = "ddo-char-set: 0; font-style: italic; font-size: 9.75pt; font-family: Arial; verti" & _
          "cal-align: top; "
      Me.txtDeAnio.Text = "de"
      Me.txtDeAnio.Top = 0.375!
      Me.txtDeAnio.Width = 0.25!
      '
      'rptChequeImp
      '
      Me.MasterReport = False
      Me.PageSettings.DefaultPaperSize = False
      Me.PageSettings.Margins.Bottom = 0.0!
      Me.PageSettings.Margins.Left = 0.0!
      Me.PageSettings.Margins.Right = 0.0!
      Me.PageSettings.Margins.Top = 0.0!
      Me.PageSettings.PaperHeight = 2.75!
      Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
      Me.PageSettings.PaperName = "Custom paper"
      Me.PageSettings.PaperWidth = 6.5!
      Me.PrintWidth = 7.96875!
      Me.Sections.Add(Me.Detail1)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                  "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                  "lic; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
      CType(Me.txtLugar, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPaguese, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDia, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtConcepto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDeMes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDeAnio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub
   Public WithEvents txtLugar As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtPaguese As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtDia As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtMes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtAnio As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtImporte As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtLiteral As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtConcepto As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtDeMes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtDeAnio As DataDynamics.ActiveReports.TextBox
End Class
