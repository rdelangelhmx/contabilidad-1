Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptLibroAgruIVA 
    Inherits DataDynamics.ActiveReports.ActiveReport3

#Region " ActiveReports Designer generated code "
    Public Sub New() 

        'This call is required by the ActiveReports Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub 

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean) 
        If disposing Then 
        End If 
        MyBase.Dispose(disposing) 
    End Sub 

   Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
   Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
   Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
   Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
   Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
   Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
   Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Line1 As DataDynamics.ActiveReports.Line
   Private Label4 As DataDynamics.ActiveReports.Label
   Public txtMesDes As DataDynamics.ActiveReports.TextBox
   Private Label5 As DataDynamics.ActiveReports.Label
   Public txtGestion As DataDynamics.ActiveReports.TextBox
   Private Label18 As DataDynamics.ActiveReports.Label
   Private Label17 As DataDynamics.ActiveReports.Label
   Private Label19 As DataDynamics.ActiveReports.Label
   Private Label20 As DataDynamics.ActiveReports.Label
   Private Label15 As DataDynamics.ActiveReports.Label
   Private Label14 As DataDynamics.ActiveReports.Label
   Private Label13 As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private lblIVA As DataDynamics.ActiveReports.Label
   Private Label7 As DataDynamics.ActiveReports.Label
   Private TextBox4 As DataDynamics.ActiveReports.TextBox
   Private TextBox3 As DataDynamics.ActiveReports.TextBox
   Private TextBox2 As DataDynamics.ActiveReports.TextBox
   Private TextBox5 As DataDynamics.ActiveReports.TextBox
   Private TextBox7 As DataDynamics.ActiveReports.TextBox
   Private TextBox8 As DataDynamics.ActiveReports.TextBox
   Private TextBox9 As DataDynamics.ActiveReports.TextBox
   Private TextBox10 As DataDynamics.ActiveReports.TextBox
   Private TextBox11 As DataDynamics.ActiveReports.TextBox
   Private TextBox As DataDynamics.ActiveReports.TextBox
   Private TextBox1 As DataDynamics.ActiveReports.TextBox
   Private TextBox12 As DataDynamics.ActiveReports.TextBox
   Private TextBox13 As DataDynamics.ActiveReports.TextBox
   Private TextBox14 As DataDynamics.ActiveReports.TextBox
   Private TextBox15 As DataDynamics.ActiveReports.TextBox
   Private TextBox16 As DataDynamics.ActiveReports.TextBox
   Private TextBox17 As DataDynamics.ActiveReports.TextBox
   Private TextBox18 As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Public lblLogin As DataDynamics.ActiveReports.Label

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptLibroAgruIVA))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.txtMesDes = New DataDynamics.ActiveReports.TextBox
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.txtGestion = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label18 = New DataDynamics.ActiveReports.Label
      Me.Label17 = New DataDynamics.ActiveReports.Label
      Me.Label19 = New DataDynamics.ActiveReports.Label
      Me.Label20 = New DataDynamics.ActiveReports.Label
      Me.Label15 = New DataDynamics.ActiveReports.Label
      Me.Label14 = New DataDynamics.ActiveReports.Label
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.lblIVA = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMesDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtGestion, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblIVA, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox4, Me.TextBox3, Me.TextBox2, Me.TextBox5, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox})
      Me.Detail.Height = 0.1875!
      Me.Detail.Name = "Detail"
      '
      'TextBox4
      '
      Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.DataField = "NroAutorizacion"
      Me.TextBox4.Height = 0.1875!
      Me.TextBox4.Left = 1.4375!
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox4.Text = "NroAutorizacion"
      Me.TextBox4.Top = 0.0!
      Me.TextBox4.Width = 0.9375!
      '
      'TextBox3
      '
      Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.DataField = "CodControl"
      Me.TextBox3.Height = 0.1875!
      Me.TextBox3.Left = 0.75!
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox3.Text = "CodControl"
      Me.TextBox3.Top = 0.0!
      Me.TextBox3.Width = 0.6875!
      '
      'TextBox2
      '
      Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.DataField = "FacturaNroIni"
      Me.TextBox2.Height = 0.1875!
      Me.TextBox2.Left = 2.375!
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox2.Text = "FacturaNro"
      Me.TextBox2.Top = 0.0!
      Me.TextBox2.Width = 0.75!
      '
      'TextBox5
      '
      Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.DataField = "FacturaNroFin"
      Me.TextBox5.Height = 0.1875!
      Me.TextBox5.Left = 3.125!
      Me.TextBox5.Name = "TextBox5"
      Me.TextBox5.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox5.Text = "FacturaNro"
      Me.TextBox5.Top = 0.0!
      Me.TextBox5.Width = 0.75!
      '
      'TextBox7
      '
      Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.DataField = "FacturaMonto"
      Me.TextBox7.Height = 0.1875!
      Me.TextBox7.Left = 3.875!
      Me.TextBox7.Name = "TextBox7"
      Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
      Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox7.Text = "FacturaMonto"
      Me.TextBox7.Top = 0.0!
      Me.TextBox7.Width = 0.7499993!
      '
      'TextBox8
      '
      Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.DataField = "IceIehd"
      Me.TextBox8.Height = 0.1875!
      Me.TextBox8.Left = 4.625!
      Me.TextBox8.Name = "TextBox8"
      Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
      Me.TextBox8.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox8.Text = "IceIehd"
      Me.TextBox8.Top = 0.0!
      Me.TextBox8.Width = 0.6874995!
      '
      'TextBox9
      '
      Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox9.DataField = "Exento"
      Me.TextBox9.Height = 0.1875!
      Me.TextBox9.Left = 5.3125!
      Me.TextBox9.Name = "TextBox9"
      Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
      Me.TextBox9.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox9.Text = "Exento"
      Me.TextBox9.Top = 0.0!
      Me.TextBox9.Width = 0.6874995!
      '
      'TextBox10
      '
      Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.DataField = "Neto"
      Me.TextBox10.Height = 0.1875!
      Me.TextBox10.Left = 6.0!
      Me.TextBox10.Name = "TextBox10"
      Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
      Me.TextBox10.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox10.Text = "Neto"
      Me.TextBox10.Top = 0.0!
      Me.TextBox10.Width = 0.7499993!
      '
      'TextBox11
      '
      Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.DataField = "IVA"
      Me.TextBox11.Height = 0.1875!
      Me.TextBox11.Left = 6.75!
      Me.TextBox11.Name = "TextBox11"
      Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
      Me.TextBox11.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox11.Text = "IVA"
      Me.TextBox11.Top = 0.0!
      Me.TextBox11.Width = 0.75!
      '
      'TextBox
      '
      Me.TextBox.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox.DataField = "FacturaFecha"
      Me.TextBox.Height = 0.1875!
      Me.TextBox.Left = 0.0!
      Me.TextBox.Name = "TextBox"
      Me.TextBox.OutputFormat = resources.GetString("TextBox.OutputFormat")
      Me.TextBox.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; vertical-align: top; "
      Me.TextBox.Text = "FacturaFecha"
      Me.TextBox.Top = 0.0!
      Me.TextBox.Width = 0.75!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label4, Me.txtMesDes, Me.Label5, Me.txtGestion})
      Me.ReportHeader.Height = 1.072222!
      Me.ReportHeader.Name = "ReportHeader"
      '
      'lblCompany
      '
      Me.lblCompany.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCompany.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickDouble
      Me.lblCompany.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCompany.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompany.Border.RightColor = System.Drawing.Color.Black
      Me.lblCompany.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompany.Border.TopColor = System.Drawing.Color.Black
      Me.lblCompany.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
      Me.lblCompany.Height = 0.25!
      Me.lblCompany.HyperLink = Nothing
      Me.lblCompany.Left = 0.0625!
      Me.lblCompany.Name = "lblCompany"
      Me.lblCompany.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 8pt; vertical-" & _
          "align: top; "
      Me.lblCompany.Text = ""
      Me.lblCompany.Top = 0.0!
      Me.lblCompany.Width = 7.375!
      '
      'lblTitle
      '
      Me.lblTitle.Border.BottomColor = System.Drawing.Color.Black
      Me.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblTitle.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
      Me.lblTitle.Border.RightColor = System.Drawing.Color.Black
      Me.lblTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
      Me.lblTitle.Border.TopColor = System.Drawing.Color.Black
      Me.lblTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
      Me.lblTitle.Height = 0.25!
      Me.lblTitle.HyperLink = Nothing
      Me.lblTitle.Left = 0.0!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "text-align: center; font-weight: bold; font-size: 12pt; vertical-align: middle; "
      Me.lblTitle.Text = ""
      Me.lblTitle.Top = 0.3125!
      Me.lblTitle.Width = 7.5!
      '
      'Line1
      '
      Me.Line1.Border.BottomColor = System.Drawing.Color.Black
      Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line1.Border.LeftColor = System.Drawing.Color.Black
      Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line1.Border.RightColor = System.Drawing.Color.Black
      Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line1.Border.TopColor = System.Drawing.Color.Black
      Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line1.Height = 0.0!
      Me.Line1.Left = 0.03472221!
      Me.Line1.LineWeight = 5.0!
      Me.Line1.Name = "Line1"
      Me.Line1.Top = 0.5972219!
      Me.Line1.Width = 7.4375!
      Me.Line1.X1 = 0.03472221!
      Me.Line1.X2 = 7.472222!
      Me.Line1.Y1 = 0.5972219!
      Me.Line1.Y2 = 0.5972219!
      '
      'Label4
      '
      Me.Label4.Border.BottomColor = System.Drawing.Color.Black
      Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.LeftColor = System.Drawing.Color.Black
      Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.RightColor = System.Drawing.Color.Black
      Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.TopColor = System.Drawing.Color.Black
      Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Height = 0.1875!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 4.5!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label4.Text = "Periodo"
      Me.Label4.Top = 0.75!
      Me.Label4.Width = 0.75!
      '
      'txtMesDes
      '
      Me.txtMesDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMesDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMesDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMesDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMesDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtMesDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMesDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtMesDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMesDes.Height = 0.1875!
      Me.txtMesDes.Left = 5.25!
      Me.txtMesDes.Name = "txtMesDes"
      Me.txtMesDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMesDes.Text = Nothing
      Me.txtMesDes.Top = 0.75!
      Me.txtMesDes.Width = 0.6875!
      '
      'Label5
      '
      Me.Label5.Border.BottomColor = System.Drawing.Color.Black
      Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Border.LeftColor = System.Drawing.Color.Black
      Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Border.RightColor = System.Drawing.Color.Black
      Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.TopColor = System.Drawing.Color.Black
      Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Height = 0.1875!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 6.125!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label5.Text = "Gestión"
      Me.Label5.Top = 0.75!
      Me.Label5.Width = 0.75!
      '
      'txtGestion
      '
      Me.txtGestion.Border.BottomColor = System.Drawing.Color.Black
      Me.txtGestion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtGestion.Border.LeftColor = System.Drawing.Color.Black
      Me.txtGestion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtGestion.Border.RightColor = System.Drawing.Color.Black
      Me.txtGestion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtGestion.Border.TopColor = System.Drawing.Color.Black
      Me.txtGestion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtGestion.Height = 0.1875!
      Me.txtGestion.Left = 6.875!
      Me.txtGestion.Name = "txtGestion"
      Me.txtGestion.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtGestion.Text = Nothing
      Me.txtGestion.Top = 0.75!
      Me.txtGestion.Width = 0.625!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label18, Me.Label17, Me.Label19, Me.Label20, Me.Label15, Me.Label14, Me.Label13, Me.Label11, Me.lblIVA, Me.Label7})
      Me.PageHeader.Height = 0.2388889!
      Me.PageHeader.Name = "PageHeader"
      '
      'Label18
      '
      Me.Label18.Border.BottomColor = System.Drawing.Color.Black
      Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label18.Border.LeftColor = System.Drawing.Color.Black
      Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label18.Border.RightColor = System.Drawing.Color.Black
      Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label18.Border.TopColor = System.Drawing.Color.Black
      Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label18.Height = 0.1875!
      Me.Label18.HyperLink = Nothing
      Me.Label18.Left = 0.75!
      Me.Label18.Name = "Label18"
      Me.Label18.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
          "ont-size: 8pt; vertical-align: middle; "
      Me.Label18.Text = "Cod Control"
      Me.Label18.Top = 0.0!
      Me.Label18.Width = 0.6875!
      '
      'Label17
      '
      Me.Label17.Border.BottomColor = System.Drawing.Color.Black
      Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label17.Border.LeftColor = System.Drawing.Color.Black
      Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Border.RightColor = System.Drawing.Color.Black
      Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label17.Border.TopColor = System.Drawing.Color.Black
      Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label17.Height = 0.1875!
      Me.Label17.HyperLink = Nothing
      Me.Label17.Left = 1.4375!
      Me.Label17.Name = "Label17"
      Me.Label17.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
          "ont-size: 8pt; vertical-align: middle; "
      Me.Label17.Text = "Autorización"
      Me.Label17.Top = 0.0!
      Me.Label17.Width = 0.9375!
      '
      'Label19
      '
      Me.Label19.Border.BottomColor = System.Drawing.Color.Black
      Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label19.Border.LeftColor = System.Drawing.Color.Black
      Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Border.RightColor = System.Drawing.Color.Black
      Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label19.Border.TopColor = System.Drawing.Color.Black
      Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label19.Height = 0.1875!
      Me.Label19.HyperLink = Nothing
      Me.Label19.Left = 2.375!
      Me.Label19.Name = "Label19"
      Me.Label19.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
          "ont-size: 8pt; vertical-align: middle; "
      Me.Label19.Text = "Fact. Inicial"
      Me.Label19.Top = 0.0!
      Me.Label19.Width = 0.75!
      '
      'Label20
      '
      Me.Label20.Border.BottomColor = System.Drawing.Color.Black
      Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label20.Border.LeftColor = System.Drawing.Color.Black
      Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label20.Border.RightColor = System.Drawing.Color.Black
      Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label20.Border.TopColor = System.Drawing.Color.Black
      Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label20.Height = 0.1875!
      Me.Label20.HyperLink = Nothing
      Me.Label20.Left = 3.125!
      Me.Label20.Name = "Label20"
      Me.Label20.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; background-color: Silver; f" & _
          "ont-size: 8pt; vertical-align: middle; "
      Me.Label20.Text = "Fact. Final"
      Me.Label20.Top = 0.0!
      Me.Label20.Width = 0.75!
      '
      'Label15
      '
      Me.Label15.Border.BottomColor = System.Drawing.Color.Black
      Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label15.Border.LeftColor = System.Drawing.Color.Black
      Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.RightColor = System.Drawing.Color.Black
      Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.TopColor = System.Drawing.Color.Black
      Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label15.Height = 0.1875!
      Me.Label15.HyperLink = Nothing
      Me.Label15.Left = 3.875!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label15.Text = "Importe"
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 0.7499993!
      '
      'Label14
      '
      Me.Label14.Border.BottomColor = System.Drawing.Color.Black
      Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label14.Border.LeftColor = System.Drawing.Color.Black
      Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Border.RightColor = System.Drawing.Color.Black
      Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Border.TopColor = System.Drawing.Color.Black
      Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label14.Height = 0.1875!
      Me.Label14.HyperLink = Nothing
      Me.Label14.Left = 4.625!
      Me.Label14.Name = "Label14"
      Me.Label14.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label14.Text = "ICE"
      Me.Label14.Top = 0.0!
      Me.Label14.Width = 0.6875!
      '
      'Label13
      '
      Me.Label13.Border.BottomColor = System.Drawing.Color.Black
      Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Border.LeftColor = System.Drawing.Color.Black
      Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.RightColor = System.Drawing.Color.Black
      Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.TopColor = System.Drawing.Color.Black
      Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Height = 0.1875!
      Me.Label13.HyperLink = Nothing
      Me.Label13.Left = 5.3125!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label13.Text = "Exento"
      Me.Label13.Top = 0.0!
      Me.Label13.Width = 0.6979167!
      '
      'Label11
      '
      Me.Label11.Border.BottomColor = System.Drawing.Color.Black
      Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label11.Border.LeftColor = System.Drawing.Color.Black
      Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.RightColor = System.Drawing.Color.Black
      Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.TopColor = System.Drawing.Color.Black
      Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label11.Height = 0.1875!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 6.0!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label11.Text = "Neto"
      Me.Label11.Top = 0.0!
      Me.Label11.Width = 0.75!
      '
      'lblIVA
      '
      Me.lblIVA.Border.BottomColor = System.Drawing.Color.Black
      Me.lblIVA.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblIVA.Border.LeftColor = System.Drawing.Color.Black
      Me.lblIVA.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblIVA.Border.RightColor = System.Drawing.Color.Black
      Me.lblIVA.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblIVA.Border.TopColor = System.Drawing.Color.Black
      Me.lblIVA.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblIVA.Height = 0.1875!
      Me.lblIVA.HyperLink = Nothing
      Me.lblIVA.Left = 6.75!
      Me.lblIVA.Name = "lblIVA"
      Me.lblIVA.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblIVA.Text = "Débito"
      Me.lblIVA.Top = 0.0!
      Me.lblIVA.Width = 0.7395744!
      '
      'Label7
      '
      Me.Label7.Border.BottomColor = System.Drawing.Color.Black
      Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.LeftColor = System.Drawing.Color.Black
      Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.RightColor = System.Drawing.Color.Black
      Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.TopColor = System.Drawing.Color.Black
      Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Height = 0.1875!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 0.0!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label7.Text = "Fecha"
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 0.75!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.3868056!
      Me.PageFooter.Name = "PageFooter"
      '
      'txtPageCount
      '
      Me.txtPageCount.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageCount.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageCount.Border.RightColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageCount.Border.TopColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageCount.Height = 0.1875!
      Me.txtPageCount.Left = 7.125!
      Me.txtPageCount.Name = "txtPageCount"
      Me.txtPageCount.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
      Me.txtPageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageCount.Text = "PageCount"
      Me.txtPageCount.Top = 0.1875!
      Me.txtPageCount.Width = 0.375!
      '
      'txtPageNOfM
      '
      Me.txtPageNOfM.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageNOfM.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageNOfM.Border.RightColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageNOfM.Border.TopColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageNOfM.Height = 0.1875!
      Me.txtPageNOfM.Left = 6.4375!
      Me.txtPageNOfM.Name = "txtPageNOfM"
      Me.txtPageNOfM.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPageNOfM.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
      Me.txtPageNOfM.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageNOfM.Text = "PageNumber"
      Me.txtPageNOfM.Top = 0.1875!
      Me.txtPageNOfM.Width = 0.375!
      '
      'Label3
      '
      Me.Label3.Border.BottomColor = System.Drawing.Color.Black
      Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label3.Border.LeftColor = System.Drawing.Color.Black
      Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label3.Border.RightColor = System.Drawing.Color.Black
      Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label3.Border.TopColor = System.Drawing.Color.Black
      Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label3.Height = 0.2!
      Me.Label3.HyperLink = Nothing
      Me.Label3.Left = 6.885411!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.Label3.Text = "de"
      Me.Label3.Top = 0.1875!
      Me.Label3.Width = 0.1875!
      '
      'Line2
      '
      Me.Line2.Border.BottomColor = System.Drawing.Color.Black
      Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line2.Border.LeftColor = System.Drawing.Color.Black
      Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line2.Border.RightColor = System.Drawing.Color.Black
      Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line2.Border.TopColor = System.Drawing.Color.Black
      Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line2.Height = 0.0!
      Me.Line2.Left = 0.02083333!
      Me.Line2.LineWeight = 3.0!
      Me.Line2.Name = "Line2"
      Me.Line2.Top = 0.1458333!
      Me.Line2.Width = 7.5!
      Me.Line2.X1 = 0.02083333!
      Me.Line2.X2 = 7.520833!
      Me.Line2.Y1 = 0.1458333!
      Me.Line2.Y2 = 0.1458333!
      '
      'lblDate
      '
      Me.lblDate.Border.BottomColor = System.Drawing.Color.Black
      Me.lblDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDate.Border.LeftColor = System.Drawing.Color.Black
      Me.lblDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDate.Border.RightColor = System.Drawing.Color.Black
      Me.lblDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDate.Border.TopColor = System.Drawing.Color.Black
      Me.lblDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDate.Height = 0.1875!
      Me.lblDate.HyperLink = Nothing
      Me.lblDate.Left = 0.0!
      Me.lblDate.Name = "lblDate"
      Me.lblDate.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.lblDate.Text = ""
      Me.lblDate.Top = 0.1875!
      Me.lblDate.Width = 2.375!
      '
      'lblTime
      '
      Me.lblTime.Border.BottomColor = System.Drawing.Color.Black
      Me.lblTime.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTime.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTime.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTime.Border.RightColor = System.Drawing.Color.Black
      Me.lblTime.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTime.Border.TopColor = System.Drawing.Color.Black
      Me.lblTime.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTime.Height = 0.1875!
      Me.lblTime.HyperLink = Nothing
      Me.lblTime.Left = 2.4375!
      Me.lblTime.Name = "lblTime"
      Me.lblTime.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.lblTime.Text = ""
      Me.lblTime.Top = 0.1875!
      Me.lblTime.Width = 1.125!
      '
      'lblLogin
      '
      Me.lblLogin.Border.BottomColor = System.Drawing.Color.Black
      Me.lblLogin.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblLogin.Border.LeftColor = System.Drawing.Color.Black
      Me.lblLogin.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblLogin.Border.RightColor = System.Drawing.Color.Black
      Me.lblLogin.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblLogin.Border.TopColor = System.Drawing.Color.Black
      Me.lblLogin.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblLogin.Height = 0.1875!
      Me.lblLogin.HyperLink = Nothing
      Me.lblLogin.Left = 3.625!
      Me.lblLogin.Name = "lblLogin"
      Me.lblLogin.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.lblLogin.Text = ""
      Me.lblLogin.Top = 0.1875!
      Me.lblLogin.Width = 2.0!
      '
      'GroupHeader1
      '
      Me.GroupHeader1.Height = 0.0!
      Me.GroupHeader1.Name = "GroupHeader1"
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox12, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18})
      Me.GroupFooter1.Height = 0.1875!
      Me.GroupFooter1.Name = "GroupFooter1"
      '
      'TextBox1
      '
      Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.DataField = "FacturaMonto"
      Me.TextBox1.Height = 0.1875!
      Me.TextBox1.Left = 3.875!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
      Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox1.SummaryGroup = "GroupHeader1"
      Me.TextBox1.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.TextBox1.Text = "FacturaMonto"
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 0.75!
      '
      'TextBox12
      '
      Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox12.DataField = "IceIehd"
      Me.TextBox12.Height = 0.1875!
      Me.TextBox12.Left = 4.625!
      Me.TextBox12.Name = "TextBox12"
      Me.TextBox12.OutputFormat = resources.GetString("TextBox12.OutputFormat")
      Me.TextBox12.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox12.SummaryGroup = "GroupHeader1"
      Me.TextBox12.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.TextBox12.Text = "IceIehd"
      Me.TextBox12.Top = 0.0!
      Me.TextBox12.Width = 0.6875!
      '
      'TextBox13
      '
      Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox13.DataField = "Exento"
      Me.TextBox13.Height = 0.1875!
      Me.TextBox13.Left = 5.3125!
      Me.TextBox13.Name = "TextBox13"
      Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
      Me.TextBox13.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox13.SummaryGroup = "GroupHeader1"
      Me.TextBox13.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.TextBox13.Text = "Exento"
      Me.TextBox13.Top = 0.0!
      Me.TextBox13.Width = 0.6875!
      '
      'TextBox14
      '
      Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.DataField = "Neto"
      Me.TextBox14.Height = 0.1875!
      Me.TextBox14.Left = 6.0!
      Me.TextBox14.Name = "TextBox14"
      Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
      Me.TextBox14.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox14.SummaryGroup = "GroupHeader1"
      Me.TextBox14.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.TextBox14.Text = "Neto"
      Me.TextBox14.Top = 0.0!
      Me.TextBox14.Width = 0.75!
      '
      'TextBox15
      '
      Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox15.DataField = "IVA"
      Me.TextBox15.Height = 0.1875!
      Me.TextBox15.Left = 6.75!
      Me.TextBox15.Name = "TextBox15"
      Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
      Me.TextBox15.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox15.SummaryGroup = "GroupHeader1"
      Me.TextBox15.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.TextBox15.Text = "IVA"
      Me.TextBox15.Top = 0.0!
      Me.TextBox15.Width = 0.75!
      '
      'TextBox16
      '
      Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Height = 0.1875!
      Me.TextBox16.Left = 3.125!
      Me.TextBox16.Name = "TextBox16"
      Me.TextBox16.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
      Me.TextBox16.Text = "Totales"
      Me.TextBox16.Top = 0.0!
      Me.TextBox16.Width = 0.75!
      '
      'TextBox17
      '
      Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox17.Height = 0.1875!
      Me.TextBox17.Left = 1.4375!
      Me.TextBox17.Name = "TextBox17"
      Me.TextBox17.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; "
      Me.TextBox17.Text = "Cantidad"
      Me.TextBox17.Top = 0.0!
      Me.TextBox17.Width = 0.9375!
      '
      'TextBox18
      '
      Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.DataField = "FacturaNroIni"
      Me.TextBox18.Height = 0.1875!
      Me.TextBox18.Left = 2.375!
      Me.TextBox18.Name = "TextBox18"
      Me.TextBox18.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox18.SummaryFunc = DataDynamics.ActiveReports.SummaryFunc.Count
      Me.TextBox18.SummaryGroup = "GroupHeader1"
      Me.TextBox18.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.TextBox18.Text = "FacturaNroIni"
      Me.TextBox18.Top = 0.0!
      Me.TextBox18.Width = 0.75!
      '
      'rptLibroAgruIVA
      '
      Me.MasterReport = False
      Me.PageSettings.DefaultPaperSize = False
      Me.PageSettings.Margins.Bottom = 0.3!
      Me.PageSettings.Margins.Left = 0.5!
      Me.PageSettings.Margins.Right = 0.5!
      Me.PageSettings.Margins.Top = 0.5!
      Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
      Me.PageSettings.PaperHeight = 11.0!
      Me.PageSettings.PaperWidth = 8.5!
      Me.PrintWidth = 7.5!
      Me.Sections.Add(Me.ReportHeader)
      Me.Sections.Add(Me.PageHeader)
      Me.Sections.Add(Me.GroupHeader1)
      Me.Sections.Add(Me.Detail)
      Me.Sections.Add(Me.GroupFooter1)
      Me.Sections.Add(Me.PageFooter)
      Me.Sections.Add(Me.ReportFooter)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                  "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMesDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtGestion, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblIVA, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

End Class