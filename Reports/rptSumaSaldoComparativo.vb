Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptSumaSaldoComparativo
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
   Private Label10 As DataDynamics.ActiveReports.Label
   Public WithEvents lblSaldoAnt As DataDynamics.ActiveReports.Label
   Public WithEvents lblDebito As DataDynamics.ActiveReports.Label
   Public WithEvents lblCredito As DataDynamics.ActiveReports.Label
   Public WithEvents lblSaldo As DataDynamics.ActiveReports.Label
   Public WithEvents lblSaldoAnt2 As DataDynamics.ActiveReports.Label
   Public WithEvents lblDebito2 As DataDynamics.ActiveReports.Label
   Private TextBox1 As DataDynamics.ActiveReports.TextBox
   Private txtPlanDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtDebito As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtCredito As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtSaldo As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtSaldoAnt2 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtDebito2 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtSaldoAnt As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Public WithEvents lblCentroCosto As DataDynamics.ActiveReports.Label
   Public WithEvents txtCentroCostoCod As DataDynamics.ActiveReports.TextBox
   Public WithEvents lblTitulo As DataDynamics.ActiveReports.Label
   Public WithEvents lblEmpresa1 As DataDynamics.ActiveReports.Label
   Public WithEvents lblCredito2 As DataDynamics.ActiveReports.Label
   Public WithEvents lblSaldo2 As DataDynamics.ActiveReports.Label
   Public WithEvents lblEmpresa2 As DataDynamics.ActiveReports.Label
   Public WithEvents txtCredito2 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtSaldo2 As DataDynamics.ActiveReports.TextBox
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSumaSaldoComparativo))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanDes = New DataDynamics.ActiveReports.TextBox
      Me.txtDebito = New DataDynamics.ActiveReports.TextBox
      Me.txtCredito = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldo = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldoAnt2 = New DataDynamics.ActiveReports.TextBox
      Me.txtDebito2 = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldoAnt = New DataDynamics.ActiveReports.TextBox
      Me.txtCredito2 = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldo2 = New DataDynamics.ActiveReports.TextBox
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
      Me.lblCentroCosto = New DataDynamics.ActiveReports.Label
      Me.txtCentroCostoCod = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.lblSaldoAnt = New DataDynamics.ActiveReports.Label
      Me.lblSaldoAnt2 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.lblDebito = New DataDynamics.ActiveReports.Label
      Me.lblCredito = New DataDynamics.ActiveReports.Label
      Me.lblSaldo = New DataDynamics.ActiveReports.Label
      Me.lblDebito2 = New DataDynamics.ActiveReports.Label
      Me.lblEmpresa1 = New DataDynamics.ActiveReports.Label
      Me.lblCredito2 = New DataDynamics.ActiveReports.Label
      Me.lblSaldo2 = New DataDynamics.ActiveReports.Label
      Me.lblEmpresa2 = New DataDynamics.ActiveReports.Label
      Me.lblTitulo = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebito, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCredito, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldoAnt2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebito2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCredito2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldo2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSaldoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSaldoAnt2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDebito, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCredito, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDebito2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblEmpresa1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCredito2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSaldo2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblEmpresa2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.txtPlanDes, Me.txtDebito, Me.txtCredito, Me.txtSaldo, Me.txtSaldoAnt2, Me.txtDebito2, Me.txtSaldoAnt, Me.txtCredito2, Me.txtSaldo2})
      Me.Detail.Height = 0.1875!
      Me.Detail.Name = "Detail"
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
      Me.TextBox1.DataField = "PlanCta"
      Me.TextBox1.Height = 0.1875!
      Me.TextBox1.Left = 0.0!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox1.Text = Nothing
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 0.75!
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
      Me.txtPlanDes.Left = 0.75!
      Me.txtPlanDes.Name = "txtPlanDes"
      Me.txtPlanDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPlanDes.Text = Nothing
      Me.txtPlanDes.Top = 0.0!
      Me.txtPlanDes.Width = 2.75!
      '
      'txtDebito
      '
      Me.txtDebito.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDebito.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebito.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDebito.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebito.Border.RightColor = System.Drawing.Color.Black
      Me.txtDebito.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebito.Border.TopColor = System.Drawing.Color.Black
      Me.txtDebito.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebito.DataField = "Debe0"
      Me.txtDebito.Height = 0.1875!
      Me.txtDebito.Left = 4.3125!
      Me.txtDebito.Name = "txtDebito"
      Me.txtDebito.OutputFormat = resources.GetString("txtDebito.OutputFormat")
      Me.txtDebito.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtDebito.Text = "Debe0"
      Me.txtDebito.Top = 0.0!
      Me.txtDebito.Width = 0.8125!
      '
      'txtCredito
      '
      Me.txtCredito.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCredito.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCredito.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCredito.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCredito.Border.RightColor = System.Drawing.Color.Black
      Me.txtCredito.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCredito.Border.TopColor = System.Drawing.Color.Black
      Me.txtCredito.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCredito.DataField = "Haber0"
      Me.txtCredito.Height = 0.1875!
      Me.txtCredito.Left = 5.125!
      Me.txtCredito.Name = "txtCredito"
      Me.txtCredito.OutputFormat = resources.GetString("txtCredito.OutputFormat")
      Me.txtCredito.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCredito.Text = "Haber0"
      Me.txtCredito.Top = 0.0!
      Me.txtCredito.Width = 0.8125!
      '
      'txtSaldo
      '
      Me.txtSaldo.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSaldo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSaldo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo.Border.RightColor = System.Drawing.Color.Black
      Me.txtSaldo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo.Border.TopColor = System.Drawing.Color.Black
      Me.txtSaldo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo.DataField = "Saldo0"
      Me.txtSaldo.Height = 0.1875!
      Me.txtSaldo.Left = 5.9375!
      Me.txtSaldo.Name = "txtSaldo"
      Me.txtSaldo.OutputFormat = resources.GetString("txtSaldo.OutputFormat")
      Me.txtSaldo.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtSaldo.Text = "Saldo0"
      Me.txtSaldo.Top = 0.0!
      Me.txtSaldo.Width = 0.8125!
      '
      'txtSaldoAnt2
      '
      Me.txtSaldoAnt2.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSaldoAnt2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoAnt2.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSaldoAnt2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoAnt2.Border.RightColor = System.Drawing.Color.Black
      Me.txtSaldoAnt2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoAnt2.Border.TopColor = System.Drawing.Color.Black
      Me.txtSaldoAnt2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoAnt2.DataField = "SaldoAnt1"
      Me.txtSaldoAnt2.Height = 0.1875!
      Me.txtSaldoAnt2.Left = 6.75!
      Me.txtSaldoAnt2.Name = "txtSaldoAnt2"
      Me.txtSaldoAnt2.OutputFormat = resources.GetString("txtSaldoAnt2.OutputFormat")
      Me.txtSaldoAnt2.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtSaldoAnt2.Text = "SaldoAnt1"
      Me.txtSaldoAnt2.Top = 0.0!
      Me.txtSaldoAnt2.Width = 0.8125!
      '
      'txtDebito2
      '
      Me.txtDebito2.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDebito2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebito2.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDebito2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebito2.Border.RightColor = System.Drawing.Color.Black
      Me.txtDebito2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebito2.Border.TopColor = System.Drawing.Color.Black
      Me.txtDebito2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebito2.DataField = "Debe1"
      Me.txtDebito2.Height = 0.1875!
      Me.txtDebito2.Left = 7.5625!
      Me.txtDebito2.Name = "txtDebito2"
      Me.txtDebito2.OutputFormat = resources.GetString("txtDebito2.OutputFormat")
      Me.txtDebito2.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtDebito2.Text = "Debe1"
      Me.txtDebito2.Top = 0.0!
      Me.txtDebito2.Width = 0.8125!
      '
      'txtSaldoAnt
      '
      Me.txtSaldoAnt.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSaldoAnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoAnt.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSaldoAnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoAnt.Border.RightColor = System.Drawing.Color.Black
      Me.txtSaldoAnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoAnt.Border.TopColor = System.Drawing.Color.Black
      Me.txtSaldoAnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoAnt.DataField = "SaldoAnt0"
      Me.txtSaldoAnt.Height = 0.1875!
      Me.txtSaldoAnt.Left = 3.5!
      Me.txtSaldoAnt.Name = "txtSaldoAnt"
      Me.txtSaldoAnt.OutputFormat = resources.GetString("txtSaldoAnt.OutputFormat")
      Me.txtSaldoAnt.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtSaldoAnt.Text = "SaldoAnt0"
      Me.txtSaldoAnt.Top = 0.0!
      Me.txtSaldoAnt.Width = 0.8125!
      '
      'txtCredito2
      '
      Me.txtCredito2.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCredito2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCredito2.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCredito2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCredito2.Border.RightColor = System.Drawing.Color.Black
      Me.txtCredito2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCredito2.Border.TopColor = System.Drawing.Color.Black
      Me.txtCredito2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCredito2.DataField = "Haber1"
      Me.txtCredito2.Height = 0.1875!
      Me.txtCredito2.Left = 8.375!
      Me.txtCredito2.Name = "txtCredito2"
      Me.txtCredito2.OutputFormat = resources.GetString("txtCredito2.OutputFormat")
      Me.txtCredito2.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCredito2.Text = "Haber1"
      Me.txtCredito2.Top = 0.0!
      Me.txtCredito2.Width = 0.8125!
      '
      'txtSaldo2
      '
      Me.txtSaldo2.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSaldo2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo2.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSaldo2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo2.Border.RightColor = System.Drawing.Color.Black
      Me.txtSaldo2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo2.Border.TopColor = System.Drawing.Color.Black
      Me.txtSaldo2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo2.DataField = "Saldo1"
      Me.txtSaldo2.Height = 0.1875!
      Me.txtSaldo2.Left = 9.1875!
      Me.txtSaldo2.Name = "txtSaldo2"
      Me.txtSaldo2.OutputFormat = resources.GetString("txtSaldo2.OutputFormat")
      Me.txtSaldo2.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtSaldo2.Text = "Saldo1"
      Me.txtSaldo2.Top = 0.0!
      Me.txtSaldo2.Width = 0.8125!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label4, Me.txtFechaIni, Me.Label5, Me.txtFechaFin, Me.Label6, Me.txtMoneda, Me.lblCentroCosto, Me.txtCentroCostoCod})
      Me.ReportHeader.Height = 1.208333!
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
      Me.Line1.Left = 0.0625!
      Me.Line1.LineWeight = 5.0!
      Me.Line1.Name = "Line1"
      Me.Line1.Top = 0.625!
      Me.Line1.Width = 9.8975!
      Me.Line1.X1 = 0.0625!
      Me.Line1.X2 = 9.96!
      Me.Line1.Y1 = 0.625!
      Me.Line1.Y2 = 0.625!
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
      Me.Label4.Left = 7.0!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label4.Text = "Fecha Inicial"
      Me.Label4.Top = 0.6875!
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
      Me.txtFechaIni.Left = 7.75!
      Me.txtFechaIni.Name = "txtFechaIni"
      Me.txtFechaIni.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaIni.Text = Nothing
      Me.txtFechaIni.Top = 0.6875!
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
      Me.Label5.Left = 8.5!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label5.Text = "Fecha Final"
      Me.Label5.Top = 0.6875!
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
      Me.txtFechaFin.Left = 9.25!
      Me.txtFechaFin.Name = "txtFechaFin"
      Me.txtFechaFin.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaFin.Text = Nothing
      Me.txtFechaFin.Top = 0.6875!
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
      Me.Label6.Left = 5.75!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Moneda"
      Me.Label6.Top = 0.6875!
      Me.Label6.Width = 0.5!
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
      Me.txtMoneda.Left = 6.25!
      Me.txtMoneda.Name = "txtMoneda"
      Me.txtMoneda.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMoneda.Text = Nothing
      Me.txtMoneda.Top = 0.6875!
      Me.txtMoneda.Width = 0.625!
      '
      'lblCentroCosto
      '
      Me.lblCentroCosto.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCentroCosto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCosto.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCentroCosto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCosto.Border.RightColor = System.Drawing.Color.Black
      Me.lblCentroCosto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCentroCosto.Border.TopColor = System.Drawing.Color.Black
      Me.lblCentroCosto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCosto.Height = 0.1875!
      Me.lblCentroCosto.HyperLink = Nothing
      Me.lblCentroCosto.Left = 0.0625!
      Me.lblCentroCosto.Name = "lblCentroCosto"
      Me.lblCentroCosto.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblCentroCosto.Text = "Centro Costo"
      Me.lblCentroCosto.Top = 0.9375!
      Me.lblCentroCosto.Width = 0.8125!
      '
      'txtCentroCostoCod
      '
      Me.txtCentroCostoCod.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCentroCostoCod.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCentroCostoCod.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCentroCostoCod.Height = 0.1875!
      Me.txtCentroCostoCod.Left = 0.875!
      Me.txtCentroCostoCod.Name = "txtCentroCostoCod"
      Me.txtCentroCostoCod.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtCentroCostoCod.Text = Nothing
      Me.txtCentroCostoCod.Top = 0.9375!
      Me.txtCentroCostoCod.Width = 6.0!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblSaldoAnt, Me.lblSaldoAnt2, Me.Label7, Me.Label10, Me.lblDebito, Me.lblCredito, Me.lblSaldo, Me.lblDebito2, Me.lblEmpresa1, Me.lblCredito2, Me.lblSaldo2, Me.lblEmpresa2, Me.lblTitulo})
      Me.PageHeader.Height = 0.3854167!
      Me.PageHeader.Name = "PageHeader"
      '
      'lblSaldoAnt
      '
      Me.lblSaldoAnt.Border.BottomColor = System.Drawing.Color.Black
      Me.lblSaldoAnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldoAnt.Border.LeftColor = System.Drawing.Color.Black
      Me.lblSaldoAnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldoAnt.Border.RightColor = System.Drawing.Color.Black
      Me.lblSaldoAnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldoAnt.Border.TopColor = System.Drawing.Color.Black
      Me.lblSaldoAnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldoAnt.Height = 0.1875!
      Me.lblSaldoAnt.HyperLink = Nothing
      Me.lblSaldoAnt.Left = 3.5!
      Me.lblSaldoAnt.Name = "lblSaldoAnt"
      Me.lblSaldoAnt.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblSaldoAnt.Text = "Saldo Ant."
      Me.lblSaldoAnt.Top = 0.1875!
      Me.lblSaldoAnt.Width = 0.8125!
      '
      'lblSaldoAnt2
      '
      Me.lblSaldoAnt2.Border.BottomColor = System.Drawing.Color.Black
      Me.lblSaldoAnt2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldoAnt2.Border.LeftColor = System.Drawing.Color.Black
      Me.lblSaldoAnt2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldoAnt2.Border.RightColor = System.Drawing.Color.Black
      Me.lblSaldoAnt2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldoAnt2.Border.TopColor = System.Drawing.Color.Black
      Me.lblSaldoAnt2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldoAnt2.Height = 0.1875!
      Me.lblSaldoAnt2.HyperLink = Nothing
      Me.lblSaldoAnt2.Left = 6.75!
      Me.lblSaldoAnt2.Name = "lblSaldoAnt2"
      Me.lblSaldoAnt2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblSaldoAnt2.Text = "Saldo Ant."
      Me.lblSaldoAnt2.Top = 0.1875!
      Me.lblSaldoAnt2.Width = 0.8125!
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
      Me.Label7.Text = "Cuenta"
      Me.Label7.Top = 0.1875!
      Me.Label7.Width = 0.75!
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
      Me.Label10.Left = 0.75!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label10.Text = "Descripción"
      Me.Label10.Top = 0.1875!
      Me.Label10.Width = 2.75!
      '
      'lblDebito
      '
      Me.lblDebito.Border.BottomColor = System.Drawing.Color.Black
      Me.lblDebito.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblDebito.Border.LeftColor = System.Drawing.Color.Black
      Me.lblDebito.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDebito.Border.RightColor = System.Drawing.Color.Black
      Me.lblDebito.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDebito.Border.TopColor = System.Drawing.Color.Black
      Me.lblDebito.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblDebito.Height = 0.1875!
      Me.lblDebito.HyperLink = Nothing
      Me.lblDebito.Left = 4.3125!
      Me.lblDebito.Name = "lblDebito"
      Me.lblDebito.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblDebito.Text = "Débito"
      Me.lblDebito.Top = 0.1875!
      Me.lblDebito.Width = 0.8125!
      '
      'lblCredito
      '
      Me.lblCredito.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCredito.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCredito.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCredito.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCredito.Border.RightColor = System.Drawing.Color.Black
      Me.lblCredito.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCredito.Border.TopColor = System.Drawing.Color.Black
      Me.lblCredito.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCredito.Height = 0.1875!
      Me.lblCredito.HyperLink = Nothing
      Me.lblCredito.Left = 5.125!
      Me.lblCredito.Name = "lblCredito"
      Me.lblCredito.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCredito.Text = "Crédito"
      Me.lblCredito.Top = 0.1875!
      Me.lblCredito.Width = 0.8125!
      '
      'lblSaldo
      '
      Me.lblSaldo.Border.BottomColor = System.Drawing.Color.Black
      Me.lblSaldo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo.Border.LeftColor = System.Drawing.Color.Black
      Me.lblSaldo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldo.Border.RightColor = System.Drawing.Color.Black
      Me.lblSaldo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldo.Border.TopColor = System.Drawing.Color.Black
      Me.lblSaldo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo.Height = 0.1875!
      Me.lblSaldo.HyperLink = Nothing
      Me.lblSaldo.Left = 5.9375!
      Me.lblSaldo.Name = "lblSaldo"
      Me.lblSaldo.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblSaldo.Text = "Saldo"
      Me.lblSaldo.Top = 0.1875!
      Me.lblSaldo.Width = 0.8125!
      '
      'lblDebito2
      '
      Me.lblDebito2.Border.BottomColor = System.Drawing.Color.Black
      Me.lblDebito2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblDebito2.Border.LeftColor = System.Drawing.Color.Black
      Me.lblDebito2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDebito2.Border.RightColor = System.Drawing.Color.Black
      Me.lblDebito2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDebito2.Border.TopColor = System.Drawing.Color.Black
      Me.lblDebito2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblDebito2.Height = 0.1875!
      Me.lblDebito2.HyperLink = Nothing
      Me.lblDebito2.Left = 7.5625!
      Me.lblDebito2.Name = "lblDebito2"
      Me.lblDebito2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblDebito2.Text = "Débito"
      Me.lblDebito2.Top = 0.1875!
      Me.lblDebito2.Width = 0.8125!
      '
      'lblEmpresa1
      '
      Me.lblEmpresa1.Border.BottomColor = System.Drawing.Color.Black
      Me.lblEmpresa1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa1.Border.LeftColor = System.Drawing.Color.Black
      Me.lblEmpresa1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa1.Border.RightColor = System.Drawing.Color.Black
      Me.lblEmpresa1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa1.Border.TopColor = System.Drawing.Color.Black
      Me.lblEmpresa1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa1.Height = 0.1875!
      Me.lblEmpresa1.HyperLink = Nothing
      Me.lblEmpresa1.Left = 3.5!
      Me.lblEmpresa1.Name = "lblEmpresa1"
      Me.lblEmpresa1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblEmpresa1.Text = ""
      Me.lblEmpresa1.Top = 0.0!
      Me.lblEmpresa1.Width = 3.25!
      '
      'lblCredito2
      '
      Me.lblCredito2.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCredito2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCredito2.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCredito2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCredito2.Border.RightColor = System.Drawing.Color.Black
      Me.lblCredito2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCredito2.Border.TopColor = System.Drawing.Color.Black
      Me.lblCredito2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCredito2.Height = 0.1875!
      Me.lblCredito2.HyperLink = Nothing
      Me.lblCredito2.Left = 8.375!
      Me.lblCredito2.Name = "lblCredito2"
      Me.lblCredito2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCredito2.Text = "Crédito"
      Me.lblCredito2.Top = 0.1875!
      Me.lblCredito2.Width = 0.8125!
      '
      'lblSaldo2
      '
      Me.lblSaldo2.Border.BottomColor = System.Drawing.Color.Black
      Me.lblSaldo2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo2.Border.LeftColor = System.Drawing.Color.Black
      Me.lblSaldo2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldo2.Border.RightColor = System.Drawing.Color.Black
      Me.lblSaldo2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo2.Border.TopColor = System.Drawing.Color.Black
      Me.lblSaldo2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo2.Height = 0.1875!
      Me.lblSaldo2.HyperLink = Nothing
      Me.lblSaldo2.Left = 9.1875!
      Me.lblSaldo2.Name = "lblSaldo2"
      Me.lblSaldo2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblSaldo2.Text = "Saldo"
      Me.lblSaldo2.Top = 0.1875!
      Me.lblSaldo2.Width = 0.8125!
      '
      'lblEmpresa2
      '
      Me.lblEmpresa2.Border.BottomColor = System.Drawing.Color.Black
      Me.lblEmpresa2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa2.Border.LeftColor = System.Drawing.Color.Black
      Me.lblEmpresa2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa2.Border.RightColor = System.Drawing.Color.Black
      Me.lblEmpresa2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa2.Border.TopColor = System.Drawing.Color.Black
      Me.lblEmpresa2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa2.Height = 0.1875!
      Me.lblEmpresa2.HyperLink = Nothing
      Me.lblEmpresa2.Left = 6.75!
      Me.lblEmpresa2.Name = "lblEmpresa2"
      Me.lblEmpresa2.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblEmpresa2.Text = ""
      Me.lblEmpresa2.Top = 0.0!
      Me.lblEmpresa2.Width = 3.25!
      '
      'lblTitulo
      '
      Me.lblTitulo.Border.BottomColor = System.Drawing.Color.Black
      Me.lblTitulo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitulo.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTitulo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitulo.Border.RightColor = System.Drawing.Color.Black
      Me.lblTitulo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitulo.Border.TopColor = System.Drawing.Color.Black
      Me.lblTitulo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitulo.Height = 0.1875!
      Me.lblTitulo.HyperLink = Nothing
      Me.lblTitulo.Left = 0.0!
      Me.lblTitulo.Name = "lblTitulo"
      Me.lblTitulo.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblTitulo.Text = "Empresas:"
      Me.lblTitulo.Top = 0.0!
      Me.lblTitulo.Width = 3.5!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.3847222!
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
      Me.txtPageCount.Left = 9.5625!
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
      Me.txtPageNOfM.Left = 8.875!
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
      Me.Label3.Left = 9.3125!
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
      Me.Line2.Width = 9.949167!
      Me.Line2.X1 = 0.02083333!
      Me.Line2.X2 = 9.97!
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
      'rptSumaSaldoComparativo
      '
      Me.MasterReport = False
      Me.PageSettings.DefaultPaperSize = False
      Me.PageSettings.Margins.Bottom = 0.3!
      Me.PageSettings.Margins.Left = 0.5!
      Me.PageSettings.Margins.Right = 0.5!
      Me.PageSettings.Margins.Top = 0.5!
      Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
      Me.PageSettings.PaperHeight = 11.69!
      Me.PageSettings.PaperWidth = 8.27!
      Me.PrintWidth = 10.0!
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
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebito, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCredito, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldoAnt2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebito2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCredito2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldo2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSaldoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSaldoAnt2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDebito, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCredito, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSaldo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDebito2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblEmpresa1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCredito2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSaldo2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblEmpresa2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitulo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private mboolSaldoAnterior As Boolean
   Public Property SaldoAnterior() As Boolean
      Get
         Return mboolSaldoAnterior
      End Get
      Set(ByVal value As Boolean)
         mboolSaldoAnterior = value
      End Set
   End Property

   Private Sub rptSumaSaldoComparativo_DataInitialize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
      If Not mboolSaldoAnterior Then
         txtSaldoAnt.Visible = False
         txtPlanDes.Width = txtPlanDes.Width + txtSaldoAnt.Width
         txtSaldoAnt2.Visible = False
         lblSaldoAnt.Text = ""
         lblSaldoAnt2.Text = ""
      End If
   End Sub
End Class