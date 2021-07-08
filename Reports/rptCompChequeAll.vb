Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptCompChequeAll
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
   Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
   Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
   Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Line1 As DataDynamics.ActiveReports.Line
   Private Label7 As DataDynamics.ActiveReports.Label
   Private Label8 As DataDynamics.ActiveReports.Label
   Private Label9 As DataDynamics.ActiveReports.Label
   Private Label10 As DataDynamics.ActiveReports.Label
   Private txtTipoCompDes As DataDynamics.ActiveReports.TextBox
   Private txtPlanDes As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Private WithEvents Label4 As DataDynamics.ActiveReports.Label
   Private WithEvents Label6 As DataDynamics.ActiveReports.Label
   Private WithEvents Label5 As DataDynamics.ActiveReports.Label
   Private WithEvents Label15 As DataDynamics.ActiveReports.Label
   Private WithEvents Label16 As DataDynamics.ActiveReports.Label
   Private WithEvents Label17 As DataDynamics.ActiveReports.Label
   Private WithEvents txtBancoCta As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtChequeDetNro As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtEstadoDesCob As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label18 As DataDynamics.ActiveReports.Label
   Private WithEvents Label1 As DataDynamics.ActiveReports.Label
   Private WithEvents txtBancoDes As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtCompNro As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtEstadoDes As DataDynamics.ActiveReports.TextBox
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCompChequeAll))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtTipoCompDes = New DataDynamics.ActiveReports.TextBox
      Me.txtBancoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanDes = New DataDynamics.ActiveReports.TextBox
      Me.txtBancoCta = New DataDynamics.ActiveReports.TextBox
      Me.txtChequeDetNro = New DataDynamics.ActiveReports.TextBox
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
      Me.txtEstadoDesCob = New DataDynamics.ActiveReports.TextBox
      Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label15 = New DataDynamics.ActiveReports.Label
      Me.Label16 = New DataDynamics.ActiveReports.Label
      Me.Label17 = New DataDynamics.ActiveReports.Label
      Me.Label18 = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.txtCompNro = New DataDynamics.ActiveReports.TextBox
      Me.txtEstadoDes = New DataDynamics.ActiveReports.TextBox
      CType(Me.txtTipoCompDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtBancoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtBancoCta, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtChequeDetNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoDesCob, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCompNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTipoCompDes, Me.txtBancoDes, Me.txtPlanDes, Me.txtBancoCta, Me.txtChequeDetNro, Me.TextBox4, Me.TextBox5, Me.txtEstadoDesCob, Me.TextBox7, Me.TextBox1, Me.txtCompNro, Me.txtEstadoDes})
      Me.Detail.Height = 0.1979167!
      Me.Detail.Name = "Detail"
      '
      'txtTipoCompDes
      '
      Me.txtTipoCompDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTipoCompDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCompDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTipoCompDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCompDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtTipoCompDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCompDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtTipoCompDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipoCompDes.DataField = "TipoCompDes"
      Me.txtTipoCompDes.Height = 0.1875!
      Me.txtTipoCompDes.Left = 8.3125!
      Me.txtTipoCompDes.Name = "txtTipoCompDes"
      Me.txtTipoCompDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: top; "
      Me.txtTipoCompDes.Text = "TipoCompDes"
      Me.txtTipoCompDes.Top = 0.0!
      Me.txtTipoCompDes.Width = 0.625!
      '
      'txtBancoDes
      '
      Me.txtBancoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtBancoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBancoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtBancoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBancoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtBancoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBancoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtBancoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBancoDes.DataField = "BancoDes"
      Me.txtBancoDes.Height = 0.1875!
      Me.txtBancoDes.Left = 1.875!
      Me.txtBancoDes.Name = "txtBancoDes"
      Me.txtBancoDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: top; "
      Me.txtBancoDes.Text = "BancoDes"
      Me.txtBancoDes.Top = 0.0!
      Me.txtBancoDes.Width = 0.8125!
      '
      'txtPlanDes
      '
      Me.txtPlanDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPlanDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPlanDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtPlanDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtPlanDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDes.DataField = "PlanDes"
      Me.txtPlanDes.Height = 0.1875!
      Me.txtPlanDes.Left = 0.0!
      Me.txtPlanDes.Name = "txtPlanDes"
      Me.txtPlanDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: top; "
      Me.txtPlanDes.Text = "PlanDes"
      Me.txtPlanDes.Top = 0.0!
      Me.txtPlanDes.Width = 1.875!
      '
      'txtBancoCta
      '
      Me.txtBancoCta.Border.BottomColor = System.Drawing.Color.Black
      Me.txtBancoCta.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBancoCta.Border.LeftColor = System.Drawing.Color.Black
      Me.txtBancoCta.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBancoCta.Border.RightColor = System.Drawing.Color.Black
      Me.txtBancoCta.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBancoCta.Border.TopColor = System.Drawing.Color.Black
      Me.txtBancoCta.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtBancoCta.DataField = "BancoCta"
      Me.txtBancoCta.Height = 0.1875!
      Me.txtBancoCta.Left = 2.6875!
      Me.txtBancoCta.Name = "txtBancoCta"
      Me.txtBancoCta.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtBancoCta.Text = "BancoCta"
      Me.txtBancoCta.Top = 0.0!
      Me.txtBancoCta.Width = 0.6875!
      '
      'txtChequeDetNro
      '
      Me.txtChequeDetNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtChequeDetNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeDetNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtChequeDetNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeDetNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtChequeDetNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeDetNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtChequeDetNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeDetNro.DataField = "ChequeDetNro"
      Me.txtChequeDetNro.Height = 0.1875!
      Me.txtChequeDetNro.Left = 4.0625!
      Me.txtChequeDetNro.Name = "txtChequeDetNro"
      Me.txtChequeDetNro.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtChequeDetNro.Text = "ChequeDetNro"
      Me.txtChequeDetNro.Top = 0.0!
      Me.txtChequeDetNro.Width = 0.625!
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
      Me.TextBox4.DataField = "Fecha"
      Me.TextBox4.Height = 0.2!
      Me.TextBox4.Left = 3.375!
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
      Me.TextBox4.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox4.Text = "Fecha"
      Me.TextBox4.Top = 0.0!
      Me.TextBox4.Width = 0.6875!
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
      Me.TextBox5.DataField = "ChequeNro"
      Me.TextBox5.Height = 0.1875!
      Me.TextBox5.Left = 4.6875!
      Me.TextBox5.Name = "TextBox5"
      Me.TextBox5.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.TextBox5.Text = "ChequeNro"
      Me.TextBox5.Top = 0.0!
      Me.TextBox5.Width = 0.5625!
      '
      'txtEstadoDesCob
      '
      Me.txtEstadoDesCob.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEstadoDesCob.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDesCob.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEstadoDesCob.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDesCob.Border.RightColor = System.Drawing.Color.Black
      Me.txtEstadoDesCob.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDesCob.Border.TopColor = System.Drawing.Color.Black
      Me.txtEstadoDesCob.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDesCob.DataField = "EstadoDesCob"
      Me.txtEstadoDesCob.Height = 0.1875!
      Me.txtEstadoDesCob.Left = 5.25!
      Me.txtEstadoDesCob.Name = "txtEstadoDesCob"
      Me.txtEstadoDesCob.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtEstadoDesCob.Text = "EstadoDesCob"
      Me.txtEstadoDesCob.Top = 0.0!
      Me.txtEstadoDesCob.Width = 0.6875!
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
      Me.TextBox7.DataField = "ChequeMonto"
      Me.TextBox7.Height = 0.1875!
      Me.TextBox7.Left = 7.5625!
      Me.TextBox7.Name = "TextBox7"
      Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
      Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox7.Text = "ChequeMonto"
      Me.TextBox7.Top = 0.0!
      Me.TextBox7.Width = 0.75!
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
      Me.TextBox1.DataField = "ChequeDes"
      Me.TextBox1.Height = 0.1875!
      Me.TextBox1.Left = 5.9375!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox1.Text = "ChequeDes"
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 1.625!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1})
      Me.ReportHeader.Height = 0.7604167!
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
      Me.lblCompany.Width = 9.875!
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
      Me.lblTitle.Width = 10.0!
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
      Me.Line1.Width = 9.9375!
      Me.Line1.X1 = 0.03472221!
      Me.Line1.X2 = 9.972222!
      Me.Line1.Y1 = 0.5972219!
      Me.Line1.Y2 = 0.5972219!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label4, Me.Label6, Me.Label5, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label1})
      Me.PageHeader.Height = 0.3229167!
      Me.PageHeader.Name = "PageHeader"
      '
      'Label7
      '
      Me.Label7.Border.BottomColor = System.Drawing.Color.Black
      Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.LeftColor = System.Drawing.Color.Black
      Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.RightColor = System.Drawing.Color.Black
      Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.TopColor = System.Drawing.Color.Black
      Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Height = 0.3125!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 8.9375!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label7.Text = "Nro Comp."
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 0.5!
      '
      'Label8
      '
      Me.Label8.Border.BottomColor = System.Drawing.Color.Black
      Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.LeftColor = System.Drawing.Color.Black
      Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.RightColor = System.Drawing.Color.Black
      Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.TopColor = System.Drawing.Color.Black
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Height = 0.3125!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 8.3125!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label8.Text = "Tipo Comp."
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 0.625!
      '
      'Label9
      '
      Me.Label9.Border.BottomColor = System.Drawing.Color.Black
      Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.LeftColor = System.Drawing.Color.Black
      Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.RightColor = System.Drawing.Color.Black
      Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.TopColor = System.Drawing.Color.Black
      Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Height = 0.3125!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 5.25!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label9.Text = "Estado Cheque"
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.6875!
      '
      'Label10
      '
      Me.Label10.Border.BottomColor = System.Drawing.Color.Black
      Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Border.LeftColor = System.Drawing.Color.Black
      Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Border.RightColor = System.Drawing.Color.Black
      Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.TopColor = System.Drawing.Color.Black
      Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Height = 0.3125!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 0.0!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label10.Text = "Descripción"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 1.875!
      '
      'Label4
      '
      Me.Label4.Border.BottomColor = System.Drawing.Color.Black
      Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Border.LeftColor = System.Drawing.Color.Black
      Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.RightColor = System.Drawing.Color.Black
      Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.TopColor = System.Drawing.Color.Black
      Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label4.Height = 0.3125!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 1.875!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label4.Text = "Banco"
      Me.Label4.Top = 0.0!
      Me.Label4.Width = 0.8125!
      '
      'Label6
      '
      Me.Label6.Border.BottomColor = System.Drawing.Color.Black
      Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Border.LeftColor = System.Drawing.Color.Black
      Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.RightColor = System.Drawing.Color.Black
      Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.TopColor = System.Drawing.Color.Black
      Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Height = 0.3125!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 2.6875!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Cuenta Banco"
      Me.Label6.Top = 0.0!
      Me.Label6.Width = 0.6875!
      '
      'Label5
      '
      Me.Label5.Border.BottomColor = System.Drawing.Color.Black
      Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Border.LeftColor = System.Drawing.Color.Black
      Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.RightColor = System.Drawing.Color.Black
      Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.TopColor = System.Drawing.Color.Black
      Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Height = 0.3125!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 3.375!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label5.Text = "Fecha"
      Me.Label5.Top = 0.0!
      Me.Label5.Width = 0.6875!
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
      Me.Label15.Height = 0.3125!
      Me.Label15.HyperLink = Nothing
      Me.Label15.Left = 7.5625!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label15.Text = "Monto"
      Me.Label15.Top = 0.0!
      Me.Label15.Width = 0.75!
      '
      'Label16
      '
      Me.Label16.Border.BottomColor = System.Drawing.Color.Black
      Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label16.Border.LeftColor = System.Drawing.Color.Black
      Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Border.RightColor = System.Drawing.Color.Black
      Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Border.TopColor = System.Drawing.Color.Black
      Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label16.Height = 0.3125!
      Me.Label16.HyperLink = Nothing
      Me.Label16.Left = 4.0625!
      Me.Label16.Name = "Label16"
      Me.Label16.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label16.Text = "Nro Chequera"
      Me.Label16.Top = 0.0!
      Me.Label16.Width = 0.625!
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
      Me.Label17.Height = 0.3125!
      Me.Label17.HyperLink = Nothing
      Me.Label17.Left = 5.9375!
      Me.Label17.Name = "Label17"
      Me.Label17.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label17.Text = "A la Orden De"
      Me.Label17.Top = 0.0!
      Me.Label17.Width = 1.625!
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
      Me.Label18.Height = 0.3125!
      Me.Label18.HyperLink = Nothing
      Me.Label18.Left = 4.6875!
      Me.Label18.Name = "Label18"
      Me.Label18.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label18.Text = "Nro Cheque"
      Me.Label18.Top = 0.0!
      Me.Label18.Width = 0.5625!
      '
      'Label1
      '
      Me.Label1.Border.BottomColor = System.Drawing.Color.Black
      Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Border.LeftColor = System.Drawing.Color.Black
      Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.RightColor = System.Drawing.Color.Black
      Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Border.TopColor = System.Drawing.Color.Black
      Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Height = 0.3125!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 9.4375!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label1.Text = "Estado Comp."
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 0.5625!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.3645833!
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
      Me.txtPageCount.Left = 9.625!
      Me.txtPageCount.Name = "txtPageCount"
      Me.txtPageCount.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
      Me.txtPageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageCount.Text = "PageCount"
      Me.txtPageCount.Top = 0.1666667!
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
      Me.txtPageNOfM.Left = 8.9375!
      Me.txtPageNOfM.Name = "txtPageNOfM"
      Me.txtPageNOfM.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtPageNOfM.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
      Me.txtPageNOfM.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageNOfM.Text = "PageNumber"
      Me.txtPageNOfM.Top = 0.1666667!
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
      Me.Label3.Left = 938.541!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.Label3.Text = "de"
      Me.Label3.Top = 0.1666667!
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
      Me.Line2.Top = 0.125!
      Me.Line2.Width = 9.999997!
      Me.Line2.X1 = 0.02083333!
      Me.Line2.X2 = 10.02083!
      Me.Line2.Y1 = 0.125!
      Me.Line2.Y2 = 0.125!
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
      Me.lblDate.Top = 0.1666667!
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
      Me.lblTime.Top = 0.1666667!
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
      Me.lblLogin.Top = 0.1666667!
      Me.lblLogin.Width = 2.0!
      '
      'txtCompNro
      '
      Me.txtCompNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.DataField = "CompNro"
      Me.txtCompNro.Height = 0.1875!
      Me.txtCompNro.Left = 8.9375!
      Me.txtCompNro.Name = "txtCompNro"
      Me.txtCompNro.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: top; "
      Me.txtCompNro.Text = "CompNro"
      Me.txtCompNro.Top = 0.0!
      Me.txtCompNro.Width = 0.5!
      '
      'txtEstadoDes
      '
      Me.txtEstadoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEstadoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEstadoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtEstadoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtEstadoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoDes.DataField = "EstadoDes"
      Me.txtEstadoDes.Height = 0.1875!
      Me.txtEstadoDes.Left = 9.4375!
      Me.txtEstadoDes.Name = "txtEstadoDes"
      Me.txtEstadoDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: top; "
      Me.txtEstadoDes.Text = "EstadoDes"
      Me.txtEstadoDes.Top = 0.0!
      Me.txtEstadoDes.Width = 0.5625!
      '
      'rptCompChequeAll
      '
      Me.MasterReport = False
      Me.PageSettings.Margins.Bottom = 0.3!
      Me.PageSettings.Margins.Left = 0.5!
      Me.PageSettings.Margins.Right = 0.5!
      Me.PageSettings.Margins.Top = 0.5!
      Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
      Me.PageSettings.PaperHeight = 11.69!
      Me.PageSettings.PaperWidth = 8.27!
      Me.PrintWidth = 10.01042!
      Me.Sections.Add(Me.ReportHeader)
      Me.Sections.Add(Me.PageHeader)
      Me.Sections.Add(Me.Detail)
      Me.Sections.Add(Me.PageFooter)
      Me.Sections.Add(Me.ReportFooter)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                  "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
      CType(Me.txtTipoCompDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtBancoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtBancoCta, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtChequeDetNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoDesCob, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCompNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

End Class