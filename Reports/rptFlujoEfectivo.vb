Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptFlujoEfectivo
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
   Private Label4 As DataDynamics.ActiveReports.Label
   Public txtFechaIni As DataDynamics.ActiveReports.TextBox
   Private Label5 As DataDynamics.ActiveReports.Label
   Public txtFechaFin As DataDynamics.ActiveReports.TextBox
   Private Label6 As DataDynamics.ActiveReports.Label
   Public txtMoneda As DataDynamics.ActiveReports.TextBox
   Private Label7 As DataDynamics.ActiveReports.Label
   Private Label8 As DataDynamics.ActiveReports.Label
   Private Label9 As DataDynamics.ActiveReports.Label
   Private Label10 As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private Label12 As DataDynamics.ActiveReports.Label
   Private Label13 As DataDynamics.ActiveReports.Label
   Private TextBox3 As DataDynamics.ActiveReports.TextBox
   Private txtTipoCompDes As DataDynamics.ActiveReports.TextBox
   Private txtPlanEEFFCta As DataDynamics.ActiveReports.TextBox
   Public txtDebeBs As DataDynamics.ActiveReports.TextBox
   Public txtHaberBs As DataDynamics.ActiveReports.TextBox
   Public txtSaldoBs As DataDynamics.ActiveReports.TextBox
   Private txtPlanEEFFDes As DataDynamics.ActiveReports.TextBox
   Public txtDebeUs As DataDynamics.ActiveReports.TextBox
   Public txtHaberUs As DataDynamics.ActiveReports.TextBox
   Public txtSaldoUs As DataDynamics.ActiveReports.TextBox
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFlujoEfectivo))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
      Me.txtTipoCompDes = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanEEFFCta = New DataDynamics.ActiveReports.TextBox
      Me.txtDebeBs = New DataDynamics.ActiveReports.TextBox
      Me.txtHaberBs = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldoBs = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanEEFFDes = New DataDynamics.ActiveReports.TextBox
      Me.txtDebeUs = New DataDynamics.ActiveReports.TextBox
      Me.txtHaberUs = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldoUs = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.txtFechaIni = New DataDynamics.ActiveReports.TextBox
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.txtFechaFin = New DataDynamics.ActiveReports.TextBox
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.txtMoneda = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTipoCompDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanEEFFCta, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebeBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtHaberBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldoBs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanEEFFDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebeUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtHaberUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldoUs, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox3, Me.txtTipoCompDes, Me.txtPlanEEFFCta, Me.txtDebeBs, Me.txtHaberBs, Me.txtSaldoBs, Me.txtPlanEEFFDes, Me.txtDebeUs, Me.txtHaberUs, Me.txtSaldoUs})
      Me.Detail.Height = 0.1875!
      Me.Detail.Name = "Detail"
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
      Me.TextBox3.DataField = "Fecha"
      Me.TextBox3.Height = 0.1875!
      Me.TextBox3.Left = 0.0!
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
      Me.TextBox3.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; vertical-align: top; "
      Me.TextBox3.Text = "Fecha"
      Me.TextBox3.Top = 0.0!
      Me.TextBox3.Width = 0.75!
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
      Me.txtTipoCompDes.Left = 0.75!
      Me.txtTipoCompDes.Name = "txtTipoCompDes"
      Me.txtTipoCompDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: top; "
      Me.txtTipoCompDes.Text = "TipoCompDes"
      Me.txtTipoCompDes.Top = 0.0!
      Me.txtTipoCompDes.Width = 0.625!
      '
      'txtPlanEEFFCta
      '
      Me.txtPlanEEFFCta.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPlanEEFFCta.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFCta.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPlanEEFFCta.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFCta.Border.RightColor = System.Drawing.Color.Black
      Me.txtPlanEEFFCta.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFCta.Border.TopColor = System.Drawing.Color.Black
      Me.txtPlanEEFFCta.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFCta.DataField = "PlanEEFFCta"
      Me.txtPlanEEFFCta.Height = 0.1875!
      Me.txtPlanEEFFCta.Left = 1.375!
      Me.txtPlanEEFFCta.Name = "txtPlanEEFFCta"
      Me.txtPlanEEFFCta.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: top; "
      Me.txtPlanEEFFCta.Text = "PlanEEFFCta"
      Me.txtPlanEEFFCta.Top = 0.0!
      Me.txtPlanEEFFCta.Width = 0.75!
      '
      'txtDebeBs
      '
      Me.txtDebeBs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDebeBs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeBs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDebeBs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeBs.Border.RightColor = System.Drawing.Color.Black
      Me.txtDebeBs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeBs.Border.TopColor = System.Drawing.Color.Black
      Me.txtDebeBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeBs.DataField = "DebeBs"
      Me.txtDebeBs.Height = 0.1875!
      Me.txtDebeBs.Left = 4.9375!
      Me.txtDebeBs.Name = "txtDebeBs"
      Me.txtDebeBs.OutputFormat = resources.GetString("txtDebeBs.OutputFormat")
      Me.txtDebeBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtDebeBs.Text = "DebeBs"
      Me.txtDebeBs.Top = 0.0!
      Me.txtDebeBs.Width = 0.875!
      '
      'txtHaberBs
      '
      Me.txtHaberBs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtHaberBs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberBs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtHaberBs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberBs.Border.RightColor = System.Drawing.Color.Black
      Me.txtHaberBs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberBs.Border.TopColor = System.Drawing.Color.Black
      Me.txtHaberBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberBs.DataField = "HaberBs"
      Me.txtHaberBs.Height = 0.1875!
      Me.txtHaberBs.Left = 5.8125!
      Me.txtHaberBs.Name = "txtHaberBs"
      Me.txtHaberBs.OutputFormat = resources.GetString("txtHaberBs.OutputFormat")
      Me.txtHaberBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtHaberBs.Text = "HaberBs"
      Me.txtHaberBs.Top = 0.0!
      Me.txtHaberBs.Width = 0.875!
      '
      'txtSaldoBs
      '
      Me.txtSaldoBs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSaldoBs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoBs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSaldoBs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoBs.Border.RightColor = System.Drawing.Color.Black
      Me.txtSaldoBs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoBs.Border.TopColor = System.Drawing.Color.Black
      Me.txtSaldoBs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoBs.DataField = "SaldoBs"
      Me.txtSaldoBs.Height = 0.1875!
      Me.txtSaldoBs.Left = 6.6875!
      Me.txtSaldoBs.Name = "txtSaldoBs"
      Me.txtSaldoBs.OutputFormat = resources.GetString("txtSaldoBs.OutputFormat")
      Me.txtSaldoBs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtSaldoBs.Text = "SaldoBs"
      Me.txtSaldoBs.Top = 0.0!
      Me.txtSaldoBs.Width = 0.8125!
      '
      'txtPlanEEFFDes
      '
      Me.txtPlanEEFFDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDes.DataField = "PlanEEFFDes"
      Me.txtPlanEEFFDes.Height = 0.1875!
      Me.txtPlanEEFFDes.Left = 2.125!
      Me.txtPlanEEFFDes.Name = "txtPlanEEFFDes"
      Me.txtPlanEEFFDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: top; "
      Me.txtPlanEEFFDes.Text = "PlanEEFFDes"
      Me.txtPlanEEFFDes.Top = 0.0!
      Me.txtPlanEEFFDes.Width = 2.8125!
      '
      'txtDebeUs
      '
      Me.txtDebeUs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDebeUs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeUs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDebeUs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeUs.Border.RightColor = System.Drawing.Color.Black
      Me.txtDebeUs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeUs.Border.TopColor = System.Drawing.Color.Black
      Me.txtDebeUs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeUs.DataField = "DebeUs"
      Me.txtDebeUs.Height = 0.1875!
      Me.txtDebeUs.Left = 4.9375!
      Me.txtDebeUs.Name = "txtDebeUs"
      Me.txtDebeUs.OutputFormat = resources.GetString("txtDebeUs.OutputFormat")
      Me.txtDebeUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtDebeUs.Text = "DebeUs"
      Me.txtDebeUs.Top = 0.0!
      Me.txtDebeUs.Width = 0.875!
      '
      'txtHaberUs
      '
      Me.txtHaberUs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtHaberUs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberUs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtHaberUs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberUs.Border.RightColor = System.Drawing.Color.Black
      Me.txtHaberUs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberUs.Border.TopColor = System.Drawing.Color.Black
      Me.txtHaberUs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberUs.DataField = "HaberUs"
      Me.txtHaberUs.Height = 0.1875!
      Me.txtHaberUs.Left = 5.8125!
      Me.txtHaberUs.Name = "txtHaberUs"
      Me.txtHaberUs.OutputFormat = resources.GetString("txtHaberUs.OutputFormat")
      Me.txtHaberUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtHaberUs.Text = "HaberUs"
      Me.txtHaberUs.Top = 0.0!
      Me.txtHaberUs.Width = 0.875!
      '
      'txtSaldoUs
      '
      Me.txtSaldoUs.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSaldoUs.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoUs.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSaldoUs.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoUs.Border.RightColor = System.Drawing.Color.Black
      Me.txtSaldoUs.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoUs.Border.TopColor = System.Drawing.Color.Black
      Me.txtSaldoUs.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoUs.DataField = "SaldoUs"
      Me.txtSaldoUs.Height = 0.1875!
      Me.txtSaldoUs.Left = 6.6875!
      Me.txtSaldoUs.Name = "txtSaldoUs"
      Me.txtSaldoUs.OutputFormat = resources.GetString("txtSaldoUs.OutputFormat")
      Me.txtSaldoUs.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtSaldoUs.Text = "SaldoUs"
      Me.txtSaldoUs.Top = 0.0!
      Me.txtSaldoUs.Width = 0.8125!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label4, Me.txtFechaIni, Me.Label5, Me.txtFechaFin, Me.Label6, Me.txtMoneda})
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
      Me.Label4.Left = 4.625!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label4.Text = "Fecha Inicial"
      Me.Label4.Top = 0.75!
      Me.Label4.Width = 0.75!
      '
      'txtFechaIni
      '
      Me.txtFechaIni.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaIni.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaIni.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaIni.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaIni.Height = 0.1875!
      Me.txtFechaIni.Left = 5.375!
      Me.txtFechaIni.Name = "txtFechaIni"
      Me.txtFechaIni.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaIni.Text = Nothing
      Me.txtFechaIni.Top = 0.75!
      Me.txtFechaIni.Width = 0.625!
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
      Me.Label5.Text = "Fecha Final"
      Me.Label5.Top = 0.75!
      Me.Label5.Width = 0.75!
      '
      'txtFechaFin
      '
      Me.txtFechaFin.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaFin.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaFin.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaFin.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaFin.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaFin.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaFin.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaFin.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaFin.Height = 0.1875!
      Me.txtFechaFin.Left = 6.875!
      Me.txtFechaFin.Name = "txtFechaFin"
      Me.txtFechaFin.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaFin.Text = Nothing
      Me.txtFechaFin.Top = 0.75!
      Me.txtFechaFin.Width = 0.625!
      '
      'Label6
      '
      Me.Label6.Border.BottomColor = System.Drawing.Color.Black
      Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Border.LeftColor = System.Drawing.Color.Black
      Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Border.RightColor = System.Drawing.Color.Black
      Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.TopColor = System.Drawing.Color.Black
      Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Height = 0.1875!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 3.125!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Moneda"
      Me.Label6.Top = 0.75!
      Me.Label6.Width = 0.75!
      '
      'txtMoneda
      '
      Me.txtMoneda.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMoneda.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMoneda.Border.RightColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMoneda.Border.TopColor = System.Drawing.Color.Black
      Me.txtMoneda.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMoneda.Height = 0.1875!
      Me.txtMoneda.Left = 3.875!
      Me.txtMoneda.Name = "txtMoneda"
      Me.txtMoneda.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMoneda.Text = Nothing
      Me.txtMoneda.Top = 0.75!
      Me.txtMoneda.Width = 0.625!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13})
      Me.PageHeader.Height = 0.2388889!
      Me.PageHeader.Name = "PageHeader"
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
      Me.Label8.Height = 0.1875!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 0.75!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label8.Text = "Tipo"
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
      Me.Label9.Height = 0.1875!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 1.375!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label9.Text = "Número"
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.75!
      '
      'Label10
      '
      Me.Label10.Border.BottomColor = System.Drawing.Color.Black
      Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Border.LeftColor = System.Drawing.Color.Black
      Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.RightColor = System.Drawing.Color.Black
      Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.TopColor = System.Drawing.Color.Black
      Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Height = 0.1875!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 2.125!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label10.Text = "Detalle"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 2.8125!
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
      Me.Label11.Left = 4.9375!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label11.Text = "Debe"
      Me.Label11.Top = 0.0!
      Me.Label11.Width = 0.875!
      '
      'Label12
      '
      Me.Label12.Border.BottomColor = System.Drawing.Color.Black
      Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label12.Border.LeftColor = System.Drawing.Color.Black
      Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Border.RightColor = System.Drawing.Color.Black
      Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Border.TopColor = System.Drawing.Color.Black
      Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label12.Height = 0.1875!
      Me.Label12.HyperLink = Nothing
      Me.Label12.Left = 5.8125!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label12.Text = "Haber"
      Me.Label12.Top = 0.0!
      Me.Label12.Width = 0.875!
      '
      'Label13
      '
      Me.Label13.Border.BottomColor = System.Drawing.Color.Black
      Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Border.LeftColor = System.Drawing.Color.Black
      Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.RightColor = System.Drawing.Color.Black
      Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Border.TopColor = System.Drawing.Color.Black
      Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label13.Height = 0.1875!
      Me.Label13.HyperLink = Nothing
      Me.Label13.Left = 6.6875!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label13.Text = "Saldo"
      Me.Label13.Top = 0.0!
      Me.Label13.Width = 0.8125!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.3826389!
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
      'rptFlujoEfectivo
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
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTipoCompDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanEEFFCta, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebeBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtHaberBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldoBs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanEEFFDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebeUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtHaberUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldoUs, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      If ToLong(Me.Fields("CompPlanEEFFId").Value) < 0 Then
         Dim font As New System.Drawing.Font(txtTipoCompDes.Font, System.Drawing.FontStyle.Bold)
         txtTipoCompDes.Font = font
         txtPlanEEFFCta.Font = font
         txtPlanEEFFDes.Font = font
         txtDebeBs.Font = font
         txtDebeUs.Font = font
         txtSaldoBs.Font = font
         txtHaberBs.Font = font
         txtHaberUs.Font = font
         txtSaldoUs.Font = font
      Else
         Dim font As New System.Drawing.Font(txtTipoCompDes.Font, System.Drawing.FontStyle.Regular)
         txtTipoCompDes.Font = font
         txtPlanEEFFCta.Font = font
         txtPlanEEFFDes.Font = font
         txtDebeBs.Font = font
         txtDebeUs.Font = font
         txtSaldoBs.Font = font
         txtHaberBs.Font = font
         txtHaberUs.Font = font
         txtSaldoUs.Font = font
      End If
   End Sub
End Class