Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptConciliaBancoDiferencia
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
   Private Label4 As DataDynamics.ActiveReports.Label
   Public txtFechaIni As DataDynamics.ActiveReports.TextBox
   Private Label5 As DataDynamics.ActiveReports.Label
   Public txtFechaFin As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label10 As DataDynamics.ActiveReports.Label
   Public WithEvents txtMonedaDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents lblCompany As DataDynamics.ActiveReports.Label
   Public WithEvents lblTitle As DataDynamics.ActiveReports.Label
   Private WithEvents txtPageCount As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label3 As DataDynamics.ActiveReports.Label
   Private WithEvents Line2 As DataDynamics.ActiveReports.Line
   Public WithEvents lblDate As DataDynamics.ActiveReports.Label
   Public WithEvents lblTime As DataDynamics.ActiveReports.Label
   Public WithEvents lblLogin As DataDynamics.ActiveReports.Label
   Private WithEvents Label6 As DataDynamics.ActiveReports.Label
   Public WithEvents lblNroCuenta As DataDynamics.ActiveReports.Label
   Public WithEvents lblBanco As DataDynamics.ActiveReports.Label
   Private WithEvents Label2 As DataDynamics.ActiveReports.Label
   Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
   Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
   Private WithEvents Label35 As DataDynamics.ActiveReports.Label
   Private WithEvents Label36 As DataDynamics.ActiveReports.Label
   Public WithEvents txtExtracto As DataDynamics.ActiveReports.Label
   Public WithEvents txtDebitoSinC As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label1 As DataDynamics.ActiveReports.Label
   Public WithEvents txtSaldoLibro As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label12 As DataDynamics.ActiveReports.Label
   Private WithEvents Label7 As DataDynamics.ActiveReports.Label
   Private WithEvents Label8 As DataDynamics.ActiveReports.Label
   Private WithEvents Label9 As DataDynamics.ActiveReports.Label
   Private WithEvents Label11 As DataDynamics.ActiveReports.Label
   Private WithEvents lblTotales As DataDynamics.ActiveReports.Label
   Private WithEvents txtTotalSaldoLibro As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label13 As DataDynamics.ActiveReports.Label
   Public WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
   Private WithEvents lblTotal As DataDynamics.ActiveReports.Label
   Public WithEvents txtCreditoSinC As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label16 As DataDynamics.ActiveReports.Label
   Private WithEvents Line3 As DataDynamics.ActiveReports.Line
   Private WithEvents Label14 As DataDynamics.ActiveReports.Label
   Private WithEvents Line4 As DataDynamics.ActiveReports.Line
   Public WithEvents txtDiferenciaSinC As DataDynamics.ActiveReports.TextBox
   Private WithEvents Line5 As DataDynamics.ActiveReports.Line
   Private WithEvents txtDiferencia As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label15 As DataDynamics.ActiveReports.Label
   Private WithEvents txtTotalBanco As DataDynamics.ActiveReports.TextBox
   Private WithEvents Line6 As DataDynamics.ActiveReports.Line
   Private WithEvents txtEncargado As DataDynamics.ActiveReports.TextBox
   Public WithEvents srptConciliaIngresoEgreso As DataDynamics.ActiveReports.SubReport
   Public WithEvents srptConciliaDiferencia As DataDynamics.ActiveReports.SubReport
   Public WithEvents Label17 As DataDynamics.ActiveReports.Label
   Public WithEvents Label18 As DataDynamics.ActiveReports.Label
   Public WithEvents Label19 As DataDynamics.ActiveReports.Label
   Public WithEvents Label20 As DataDynamics.ActiveReports.Label
   Private WithEvents Line1 As DataDynamics.ActiveReports.Line

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptConciliaBancoDiferencia))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.srptConciliaIngresoEgreso = New DataDynamics.ActiveReports.SubReport
      Me.srptConciliaDiferencia = New DataDynamics.ActiveReports.SubReport
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.txtFechaIni = New DataDynamics.ActiveReports.TextBox
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.txtFechaFin = New DataDynamics.ActiveReports.TextBox
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.lblNroCuenta = New DataDynamics.ActiveReports.Label
      Me.lblBanco = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.txtEncargado = New DataDynamics.ActiveReports.TextBox
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
      Me.Label35 = New DataDynamics.ActiveReports.Label
      Me.Label36 = New DataDynamics.ActiveReports.Label
      Me.txtExtracto = New DataDynamics.ActiveReports.Label
      Me.txtDebitoSinC = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldoLibro = New DataDynamics.ActiveReports.TextBox
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.lblTotales = New DataDynamics.ActiveReports.Label
      Me.txtTotalSaldoLibro = New DataDynamics.ActiveReports.TextBox
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.txtCreditoSinC = New DataDynamics.ActiveReports.TextBox
      Me.Label16 = New DataDynamics.ActiveReports.Label
      Me.Label14 = New DataDynamics.ActiveReports.Label
      Me.Line4 = New DataDynamics.ActiveReports.Line
      Me.txtDiferenciaSinC = New DataDynamics.ActiveReports.TextBox
      Me.Line5 = New DataDynamics.ActiveReports.Line
      Me.txtDiferencia = New DataDynamics.ActiveReports.TextBox
      Me.Label15 = New DataDynamics.ActiveReports.Label
      Me.txtTotalBanco = New DataDynamics.ActiveReports.TextBox
      Me.Line6 = New DataDynamics.ActiveReports.Line
      Me.Label17 = New DataDynamics.ActiveReports.Label
      Me.Label18 = New DataDynamics.ActiveReports.Label
      Me.Label19 = New DataDynamics.ActiveReports.Label
      Me.Label20 = New DataDynamics.ActiveReports.Label
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.txtTotal = New DataDynamics.ActiveReports.TextBox
      Me.lblTotal = New DataDynamics.ActiveReports.Label
      Me.Line3 = New DataDynamics.ActiveReports.Line
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblNroCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblBanco, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEncargado, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtExtracto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebitoSinC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldoLibro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTotales, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotalSaldoLibro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCreditoSinC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDiferenciaSinC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDiferencia, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotalBanco, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.srptConciliaIngresoEgreso, Me.srptConciliaDiferencia})
      Me.Detail.Height = 0.2916667!
      Me.Detail.Name = "Detail"
      '
      'srptConciliaIngresoEgreso
      '
      Me.srptConciliaIngresoEgreso.Border.BottomColor = System.Drawing.Color.Black
      Me.srptConciliaIngresoEgreso.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptConciliaIngresoEgreso.Border.LeftColor = System.Drawing.Color.Black
      Me.srptConciliaIngresoEgreso.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptConciliaIngresoEgreso.Border.RightColor = System.Drawing.Color.Black
      Me.srptConciliaIngresoEgreso.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptConciliaIngresoEgreso.Border.TopColor = System.Drawing.Color.Black
      Me.srptConciliaIngresoEgreso.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptConciliaIngresoEgreso.CloseBorder = False
      Me.srptConciliaIngresoEgreso.Height = 0.1875!
      Me.srptConciliaIngresoEgreso.Left = 0.0!
      Me.srptConciliaIngresoEgreso.Name = "srptConciliaIngresoEgreso"
      Me.srptConciliaIngresoEgreso.Report = Nothing
      Me.srptConciliaIngresoEgreso.ReportName = "SubReport1"
      Me.srptConciliaIngresoEgreso.Top = 0.0!
      Me.srptConciliaIngresoEgreso.Width = 4.4375!
      '
      'srptConciliaDiferencia
      '
      Me.srptConciliaDiferencia.Border.BottomColor = System.Drawing.Color.Black
      Me.srptConciliaDiferencia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptConciliaDiferencia.Border.LeftColor = System.Drawing.Color.Black
      Me.srptConciliaDiferencia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptConciliaDiferencia.Border.RightColor = System.Drawing.Color.Black
      Me.srptConciliaDiferencia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptConciliaDiferencia.Border.TopColor = System.Drawing.Color.Black
      Me.srptConciliaDiferencia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptConciliaDiferencia.CloseBorder = False
      Me.srptConciliaDiferencia.Height = 0.1875!
      Me.srptConciliaDiferencia.Left = 4.5!
      Me.srptConciliaDiferencia.Name = "srptConciliaDiferencia"
      Me.srptConciliaDiferencia.Report = Nothing
      Me.srptConciliaDiferencia.ReportName = "SubReport1"
      Me.srptConciliaDiferencia.Top = 0.0!
      Me.srptConciliaDiferencia.Width = 3.0!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label4, Me.txtFechaIni, Me.Label5, Me.txtFechaFin, Me.Label10, Me.txtMonedaDes, Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label6, Me.lblNroCuenta, Me.lblBanco, Me.Label2})
      Me.ReportHeader.Height = 1.520833!
      Me.ReportHeader.Name = "ReportHeader"
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
      Me.Label4.Left = 1.599409!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label4.Text = "Fecha Inicial"
      Me.Label4.Top = 0.738189!
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
      Me.txtFechaIni.Left = 2.337599!
      Me.txtFechaIni.Name = "txtFechaIni"
      Me.txtFechaIni.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaIni.Text = Nothing
      Me.txtFechaIni.Top = 0.738189!
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
      Me.Label5.Left = 3.075788!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label5.Text = "Fecha Final"
      Me.Label5.Top = 0.738189!
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
      Me.txtFechaFin.Left = 3.838583!
      Me.txtFechaFin.Name = "txtFechaFin"
      Me.txtFechaFin.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaFin.Text = Nothing
      Me.txtFechaFin.Top = 0.738189!
      Me.txtFechaFin.Width = 0.625!
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
      Me.Label10.Height = 0.1875!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 0.0738189!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label10.Text = "Moneda"
      Me.Label10.Top = 1.033465!
      Me.Label10.Width = 0.75!
      '
      'txtMonedaDes
      '
      Me.txtMonedaDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMonedaDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMonedaDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMonedaDes.Height = 0.1875!
      Me.txtMonedaDes.Left = 0.8120079!
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMonedaDes.Text = Nothing
      Me.txtMonedaDes.Top = 1.033465!
      Me.txtMonedaDes.Width = 0.625!
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
      Me.Label6.Left = 0.0738189!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Nro Cuenta:"
      Me.Label6.Top = 1.254921!
      Me.Label6.Width = 0.875!
      '
      'lblNroCuenta
      '
      Me.lblNroCuenta.Border.BottomColor = System.Drawing.Color.Black
      Me.lblNroCuenta.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblNroCuenta.Border.LeftColor = System.Drawing.Color.Black
      Me.lblNroCuenta.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblNroCuenta.Border.RightColor = System.Drawing.Color.Black
      Me.lblNroCuenta.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblNroCuenta.Border.TopColor = System.Drawing.Color.Black
      Me.lblNroCuenta.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblNroCuenta.Height = 0.1864337!
      Me.lblNroCuenta.HyperLink = Nothing
      Me.lblNroCuenta.Left = 0.9350393!
      Me.lblNroCuenta.Name = "lblNroCuenta"
      Me.lblNroCuenta.Style = "ddo-char-set: 0; font-size: 8pt; "
      Me.lblNroCuenta.Text = ""
      Me.lblNroCuenta.Top = 1.254921!
      Me.lblNroCuenta.Width = 2.116142!
      '
      'lblBanco
      '
      Me.lblBanco.Border.BottomColor = System.Drawing.Color.Black
      Me.lblBanco.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblBanco.Border.LeftColor = System.Drawing.Color.Black
      Me.lblBanco.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblBanco.Border.RightColor = System.Drawing.Color.Black
      Me.lblBanco.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblBanco.Border.TopColor = System.Drawing.Color.Black
      Me.lblBanco.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblBanco.Height = 0.1770833!
      Me.lblBanco.HyperLink = Nothing
      Me.lblBanco.Left = 3.937008!
      Me.lblBanco.Name = "lblBanco"
      Me.lblBanco.Style = "ddo-char-set: 0; font-size: 8pt; "
      Me.lblBanco.Text = ""
      Me.lblBanco.Top = 1.254921!
      Me.lblBanco.Width = 3.520833!
      '
      'Label2
      '
      Me.Label2.Border.BottomColor = System.Drawing.Color.Black
      Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Border.LeftColor = System.Drawing.Color.Black
      Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.RightColor = System.Drawing.Color.Black
      Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.TopColor = System.Drawing.Color.Black
      Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Height = 0.1875!
      Me.Label2.HyperLink = Nothing
      Me.Label2.Left = 3.051181!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label2.Text = "Banco:"
      Me.Label2.Top = 1.254921!
      Me.Label2.Width = 0.875!
      '
      'ReportFooter
      '
      Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtEncargado})
      Me.ReportFooter.Height = 1.083333!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'txtEncargado
      '
      Me.txtEncargado.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEncargado.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEncargado.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEncargado.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEncargado.Border.RightColor = System.Drawing.Color.Black
      Me.txtEncargado.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEncargado.Border.TopColor = System.Drawing.Color.Black
      Me.txtEncargado.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEncargado.Height = 0.1968504!
      Me.txtEncargado.Left = 2.312992!
      Me.txtEncargado.Name = "txtEncargado"
      Me.txtEncargado.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertic" & _
          "al-align: middle; "
      Me.txtEncargado.Text = "ELABORADO POR"
      Me.txtEncargado.Top = 0.8120079!
      Me.txtEncargado.Width = 2.214567!
      '
      'PageHeader
      '
      Me.PageHeader.Height = 0.0!
      Me.PageHeader.Name = "PageHeader"
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.2395833!
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
      Me.txtPageCount.Top = 0.0416667!
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
      Me.txtPageNOfM.Top = 0.0416667!
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
      Me.Label3.Top = 0.0416667!
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
      Me.Line2.Top = 0.0!
      Me.Line2.Width = 7.5!
      Me.Line2.X1 = 0.02083333!
      Me.Line2.X2 = 7.520833!
      Me.Line2.Y1 = 0.0!
      Me.Line2.Y2 = 0.0!
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
      Me.lblDate.Top = 0.0416667!
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
      Me.lblTime.Top = 0.0416667!
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
      Me.lblLogin.Top = 0.0416667!
      Me.lblLogin.Width = 2.0!
      '
      'GroupHeader1
      '
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label35, Me.Label36, Me.txtExtracto, Me.txtDebitoSinC, Me.txtSaldoLibro, Me.Label1, Me.lblTotales, Me.txtTotalSaldoLibro, Me.Label11, Me.Label9, Me.Label7, Me.Label8, Me.Label12, Me.Label13, Me.txtCreditoSinC, Me.Label16, Me.Label14, Me.Line4, Me.txtDiferenciaSinC, Me.Line5, Me.txtDiferencia, Me.Label15, Me.txtTotalBanco, Me.Line6, Me.Label17, Me.Label18, Me.Label19, Me.Label20})
      Me.GroupHeader1.Height = 3.083333!
      Me.GroupHeader1.Name = "GroupHeader1"
      '
      'Label35
      '
      Me.Label35.Border.BottomColor = System.Drawing.Color.Black
      Me.Label35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label35.Border.LeftColor = System.Drawing.Color.Black
      Me.Label35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label35.Border.RightColor = System.Drawing.Color.Black
      Me.Label35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label35.Border.TopColor = System.Drawing.Color.Black
      Me.Label35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label35.Height = 0.1875!
      Me.Label35.HyperLink = Nothing
      Me.Label35.Left = 0.6458333!
      Me.Label35.Name = "Label35"
      Me.Label35.Style = "ddo-char-set: 0; font-weight: normal; font-size: 8.25pt; "
      Me.Label35.Text = "(-) Cheques en tránsito"
      Me.Label35.Top = 0.4791667!
      Me.Label35.Width = 1.416667!
      '
      'Label36
      '
      Me.Label36.Border.BottomColor = System.Drawing.Color.Black
      Me.Label36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label36.Border.LeftColor = System.Drawing.Color.Black
      Me.Label36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label36.Border.RightColor = System.Drawing.Color.Black
      Me.Label36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label36.Border.TopColor = System.Drawing.Color.Black
      Me.Label36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label36.Height = 0.1875!
      Me.Label36.HyperLink = Nothing
      Me.Label36.Left = 0.5208333!
      Me.Label36.Name = "Label36"
      Me.Label36.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9pt; "
      Me.Label36.Text = "Saldo anterior según Banco"
      Me.Label36.Top = 0.0!
      Me.Label36.Width = 1.9375!
      '
      'txtExtracto
      '
      Me.txtExtracto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtExtracto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtExtracto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtExtracto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtExtracto.Border.RightColor = System.Drawing.Color.Black
      Me.txtExtracto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtExtracto.Border.TopColor = System.Drawing.Color.Black
      Me.txtExtracto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtExtracto.Height = 0.1875!
      Me.txtExtracto.HyperLink = Nothing
      Me.txtExtracto.Left = 5.145834!
      Me.txtExtracto.Name = "txtExtracto"
      Me.txtExtracto.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 9pt; "
      Me.txtExtracto.Text = "Extracto"
      Me.txtExtracto.Top = 0.0!
      Me.txtExtracto.Width = 1.3125!
      '
      'txtDebitoSinC
      '
      Me.txtDebitoSinC.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDebitoSinC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebitoSinC.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDebitoSinC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebitoSinC.Border.RightColor = System.Drawing.Color.Black
      Me.txtDebitoSinC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebitoSinC.Border.TopColor = System.Drawing.Color.Black
      Me.txtDebitoSinC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebitoSinC.Height = 0.1875!
      Me.txtDebitoSinC.Left = 2.072916!
      Me.txtDebitoSinC.Name = "txtDebitoSinC"
      Me.txtDebitoSinC.OutputFormat = resources.GetString("txtDebitoSinC.OutputFormat")
      Me.txtDebitoSinC.Style = "text-align: right; font-size: 8pt; "
      Me.txtDebitoSinC.Text = "ChequesTransito"
      Me.txtDebitoSinC.Top = 0.4791667!
      Me.txtDebitoSinC.Width = 0.90625!
      '
      'txtSaldoLibro
      '
      Me.txtSaldoLibro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSaldoLibro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoLibro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSaldoLibro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoLibro.Border.RightColor = System.Drawing.Color.Black
      Me.txtSaldoLibro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoLibro.Border.TopColor = System.Drawing.Color.Black
      Me.txtSaldoLibro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldoLibro.Height = 0.1875!
      Me.txtSaldoLibro.Left = 3.282645!
      Me.txtSaldoLibro.Name = "txtSaldoLibro"
      Me.txtSaldoLibro.OutputFormat = resources.GetString("txtSaldoLibro.OutputFormat")
      Me.txtSaldoLibro.Style = "text-align: right; font-weight: normal; font-size: 9pt; "
      Me.txtSaldoLibro.Text = "SaldoLibro"
      Me.txtSaldoLibro.Top = 1.286499!
      Me.txtSaldoLibro.Width = 1.3125!
      '
      'Label1
      '
      Me.Label1.Border.BottomColor = System.Drawing.Color.Black
      Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.LeftColor = System.Drawing.Color.Black
      Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.RightColor = System.Drawing.Color.Black
      Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.TopColor = System.Drawing.Color.Black
      Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Height = 0.1875!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 0.5357613!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9pt; font-family: Arial; "
      Me.Label1.Text = "Saldo según Libro Banco"
      Me.Label1.Top = 1.286499!
      Me.Label1.Width = 1.9375!
      '
      'lblTotales
      '
      Me.lblTotales.Border.BottomColor = System.Drawing.Color.Black
      Me.lblTotales.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTotales.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTotales.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTotales.Border.RightColor = System.Drawing.Color.Black
      Me.lblTotales.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTotales.Border.TopColor = System.Drawing.Color.Black
      Me.lblTotales.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTotales.Height = 0.1968503!
      Me.lblTotales.HyperLink = Nothing
      Me.lblTotales.Left = 0.5659449!
      Me.lblTotales.Name = "lblTotales"
      Me.lblTotales.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.lblTotales.Text = "SUMAS IGUALES  "
      Me.lblTotales.Top = 1.550197!
      Me.lblTotales.Width = 1.574803!
      '
      'txtTotalSaldoLibro
      '
      Me.txtTotalSaldoLibro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotalSaldoLibro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalSaldoLibro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotalSaldoLibro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalSaldoLibro.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotalSaldoLibro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalSaldoLibro.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotalSaldoLibro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalSaldoLibro.Height = 0.1875!
      Me.txtTotalSaldoLibro.Left = 3.282645!
      Me.txtTotalSaldoLibro.Name = "txtTotalSaldoLibro"
      Me.txtTotalSaldoLibro.OutputFormat = resources.GetString("txtTotalSaldoLibro.OutputFormat")
      Me.txtTotalSaldoLibro.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; "
      Me.txtTotalSaldoLibro.Text = "SumLibro"
      Me.txtTotalSaldoLibro.Top = 1.553395!
      Me.txtTotalSaldoLibro.Width = 1.311024!
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
      Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Height = 0.1875!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 0.1230315!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; "
      Me.Label11.Text = "Detalle de Cheques y  otras Operaciones en Tránsito"
      Me.Label11.Top = 2.600722!
      Me.Label11.Width = 4.0!
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
      Me.Label9.Left = 0.0246063!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label9.Text = "Fecha"
      Me.Label9.Top = 2.871392!
      Me.Label9.Width = 0.6875!
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
      Me.Label7.Height = 0.1875!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 3.715551!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label7.Text = "Monto"
      Me.Label7.Top = 2.871392!
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
      Me.Label8.Left = 0.7135827!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label8.Text = "Número"
      Me.Label8.Top = 2.871392!
      Me.Label8.Width = 0.625!
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
      Me.Label12.Left = 1.968504!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label12.Text = "A la Orden De"
      Me.Label12.Top = 2.871392!
      Me.Label12.Width = 1.75!
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
      Me.Label13.Left = 1.32874!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label13.Text = "Cheque"
      Me.Label13.Top = 2.871392!
      Me.Label13.Width = 0.625!
      '
      'txtCreditoSinC
      '
      Me.txtCreditoSinC.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCreditoSinC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCreditoSinC.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCreditoSinC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCreditoSinC.Border.RightColor = System.Drawing.Color.Black
      Me.txtCreditoSinC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCreditoSinC.Border.TopColor = System.Drawing.Color.Black
      Me.txtCreditoSinC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCreditoSinC.Height = 0.1875!
      Me.txtCreditoSinC.Left = 2.074311!
      Me.txtCreditoSinC.Name = "txtCreditoSinC"
      Me.txtCreditoSinC.OutputFormat = resources.GetString("txtCreditoSinC.OutputFormat")
      Me.txtCreditoSinC.Style = "text-align: right; font-size: 8pt; "
      Me.txtCreditoSinC.Text = "CreditoSinC"
      Me.txtCreditoSinC.Top = 0.679626!
      Me.txtCreditoSinC.Width = 0.90625!
      '
      'Label16
      '
      Me.Label16.Border.BottomColor = System.Drawing.Color.Black
      Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Border.LeftColor = System.Drawing.Color.Black
      Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Border.RightColor = System.Drawing.Color.Black
      Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Border.TopColor = System.Drawing.Color.Black
      Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label16.Height = 0.1875!
      Me.Label16.HyperLink = Nothing
      Me.Label16.Left = 0.648376!
      Me.Label16.Name = "Label16"
      Me.Label16.Style = "ddo-char-set: 0; font-weight: normal; font-size: 8.25pt; "
      Me.Label16.Text = "(+) Depósitos en tránsito"
      Me.Label16.Top = 0.679626!
      Me.Label16.Width = 1.416667!
      '
      'Label14
      '
      Me.Label14.Border.BottomColor = System.Drawing.Color.Black
      Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Border.LeftColor = System.Drawing.Color.Black
      Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Border.RightColor = System.Drawing.Color.Black
      Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Border.TopColor = System.Drawing.Color.Black
      Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label14.Height = 0.1875!
      Me.Label14.HyperLink = Nothing
      Me.Label14.Left = 0.4166667!
      Me.Label14.Name = "Label14"
      Me.Label14.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: bottom; "
      Me.Label14.Text = "MENOS:"
      Me.Label14.Top = 0.28125!
      Me.Label14.Width = 1.5625!
      '
      'Line4
      '
      Me.Line4.Border.BottomColor = System.Drawing.Color.Black
      Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line4.Border.LeftColor = System.Drawing.Color.Black
      Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line4.Border.RightColor = System.Drawing.Color.Black
      Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line4.Border.TopColor = System.Drawing.Color.Black
      Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line4.Height = 0.0!
      Me.Line4.Left = 0.6349246!
      Me.Line4.LineWeight = 2.0!
      Me.Line4.Name = "Line4"
      Me.Line4.Top = 0.8612205!
      Me.Line4.Width = 5.807086!
      Me.Line4.X1 = 0.6349246!
      Me.Line4.X2 = 6.442011!
      Me.Line4.Y1 = 0.8612205!
      Me.Line4.Y2 = 0.8612205!
      '
      'txtDiferenciaSinC
      '
      Me.txtDiferenciaSinC.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDiferenciaSinC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDiferenciaSinC.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDiferenciaSinC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDiferenciaSinC.Border.RightColor = System.Drawing.Color.Black
      Me.txtDiferenciaSinC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDiferenciaSinC.Border.TopColor = System.Drawing.Color.Black
      Me.txtDiferenciaSinC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDiferenciaSinC.Height = 0.2214567!
      Me.txtDiferenciaSinC.Left = 5.142717!
      Me.txtDiferenciaSinC.Name = "txtDiferenciaSinC"
      Me.txtDiferenciaSinC.OutputFormat = resources.GetString("txtDiferenciaSinC.OutputFormat")
      Me.txtDiferenciaSinC.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; "
      Me.txtDiferenciaSinC.Text = "txtTotalMenos"
      Me.txtDiferenciaSinC.Top = 0.8716372!
      Me.txtDiferenciaSinC.Width = 1.311024!
      '
      'Line5
      '
      Me.Line5.Border.BottomColor = System.Drawing.Color.Black
      Me.Line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line5.Border.LeftColor = System.Drawing.Color.Black
      Me.Line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line5.Border.RightColor = System.Drawing.Color.Black
      Me.Line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line5.Border.TopColor = System.Drawing.Color.Black
      Me.Line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line5.Height = 0.0!
      Me.Line5.Left = 2.091536!
      Me.Line5.LineWeight = 2.0!
      Me.Line5.Name = "Line5"
      Me.Line5.Top = 1.550197!
      Me.Line5.Width = 4.404527!
      Me.Line5.X1 = 2.091536!
      Me.Line5.X2 = 6.496063!
      Me.Line5.Y1 = 1.550197!
      Me.Line5.Y2 = 1.550197!
      '
      'txtDiferencia
      '
      Me.txtDiferencia.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDiferencia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDiferencia.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDiferencia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDiferencia.Border.RightColor = System.Drawing.Color.Black
      Me.txtDiferencia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDiferencia.Border.TopColor = System.Drawing.Color.Black
      Me.txtDiferencia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDiferencia.Height = 0.1875!
      Me.txtDiferencia.Left = 5.167323!
      Me.txtDiferencia.Name = "txtDiferencia"
      Me.txtDiferencia.OutputFormat = resources.GetString("txtDiferencia.OutputFormat")
      Me.txtDiferencia.Style = "text-align: right; font-weight: bold; font-size: 9pt; "
      Me.txtDiferencia.Text = "Diferencia"
      Me.txtDiferencia.Top = 1.837927!
      Me.txtDiferencia.Width = 1.311024!
      '
      'Label15
      '
      Me.Label15.Border.BottomColor = System.Drawing.Color.Black
      Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.LeftColor = System.Drawing.Color.Black
      Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.RightColor = System.Drawing.Color.Black
      Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Border.TopColor = System.Drawing.Color.Black
      Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label15.Height = 0.1889764!
      Me.Label15.HyperLink = Nothing
      Me.Label15.Left = 2.436024!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; vertical-a" & _
          "lign: middle; "
      Me.Label15.Text = "DIFERENCIA  ="
      Me.Label15.Top = 1.837927!
      Me.Label15.Width = 1.894685!
      '
      'txtTotalBanco
      '
      Me.txtTotalBanco.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotalBanco.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalBanco.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotalBanco.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalBanco.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotalBanco.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalBanco.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotalBanco.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotalBanco.Height = 0.1875!
      Me.txtTotalBanco.Left = 5.167323!
      Me.txtTotalBanco.Name = "txtTotalBanco"
      Me.txtTotalBanco.OutputFormat = resources.GetString("txtTotalBanco.OutputFormat")
      Me.txtTotalBanco.Style = "text-align: right; font-weight: bold; font-size: 8.25pt; "
      Me.txtTotalBanco.Text = "SumBanco"
      Me.txtTotalBanco.Top = 1.57103!
      Me.txtTotalBanco.Width = 1.311024!
      '
      'Line6
      '
      Me.Line6.Border.BottomColor = System.Drawing.Color.Black
      Me.Line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line6.Border.LeftColor = System.Drawing.Color.Black
      Me.Line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line6.Border.RightColor = System.Drawing.Color.Black
      Me.Line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line6.Border.TopColor = System.Drawing.Color.Black
      Me.Line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line6.Height = 0.0!
      Me.Line6.Left = 3.272638!
      Me.Line6.LineWeight = 3.0!
      Me.Line6.Name = "Line6"
      Me.Line6.Top = 1.820866!
      Me.Line6.Width = 3.24311!
      Me.Line6.X1 = 3.272638!
      Me.Line6.X2 = 6.515748!
      Me.Line6.Y1 = 1.820866!
      Me.Line6.Y2 = 1.820866!
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
      Me.Label17.Left = 4.5!
      Me.Label17.Name = "Label17"
      Me.Label17.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label17.Text = "Fecha"
      Me.Label17.Top = 2.875!
      Me.Label17.Width = 0.6875!
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
      Me.Label18.Left = 5.1875!
      Me.Label18.Name = "Label18"
      Me.Label18.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label18.Text = "Descripción"
      Me.Label18.Top = 2.875!
      Me.Label18.Width = 1.5625!
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
      Me.Label19.Left = 6.75!
      Me.Label19.Name = "Label19"
      Me.Label19.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label19.Text = "Monto"
      Me.Label19.Top = 2.875!
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
      Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label20.Height = 0.1875!
      Me.Label20.HyperLink = Nothing
      Me.Label20.Left = 4.6875!
      Me.Label20.Name = "Label20"
      Me.Label20.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; "
      Me.Label20.Text = "Diferencias Conciliatorias"
      Me.Label20.Top = 2.625!
      Me.Label20.Width = 2.625!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTotal, Me.lblTotal, Me.Line3})
      Me.GroupFooter1.Height = 0.3020833!
      Me.GroupFooter1.Name = "GroupFooter1"
      '
      'txtTotal
      '
      Me.txtTotal.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Height = 0.2!
      Me.txtTotal.Left = 3.666339!
      Me.txtTotal.Name = "txtTotal"
      Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
      Me.txtTotal.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; "
      Me.txtTotal.SummaryGroup = "GroupHeader1"
      Me.txtTotal.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
      Me.txtTotal.Text = "txtTotal"
      Me.txtTotal.Top = 0.0!
      Me.txtTotal.Width = 0.75!
      '
      'lblTotal
      '
      Me.lblTotal.Border.BottomColor = System.Drawing.Color.Black
      Me.lblTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTotal.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTotal.Border.RightColor = System.Drawing.Color.Black
      Me.lblTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTotal.Border.TopColor = System.Drawing.Color.Black
      Me.lblTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTotal.Height = 0.1968504!
      Me.lblTotal.HyperLink = Nothing
      Me.lblTotal.Left = 3.149606!
      Me.lblTotal.Name = "lblTotal"
      Me.lblTotal.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblTotal.Text = "TOTAL"
      Me.lblTotal.Top = 0.0!
      Me.lblTotal.Width = 0.492126!
      '
      'Line3
      '
      Me.Line3.Border.BottomColor = System.Drawing.Color.Black
      Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line3.Border.LeftColor = System.Drawing.Color.Black
      Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line3.Border.RightColor = System.Drawing.Color.Black
      Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line3.Border.TopColor = System.Drawing.Color.Black
      Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Line3.Height = 0.0!
      Me.Line3.Left = 0.0!
      Me.Line3.LineWeight = 3.0!
      Me.Line3.Name = "Line3"
      Me.Line3.Top = 0.0!
      Me.Line3.Width = 4.453741!
      Me.Line3.X1 = 0.0!
      Me.Line3.X2 = 4.453741!
      Me.Line3.Y1 = 0.0!
      Me.Line3.Y2 = 0.0!
      '
      'rptConciliaBancoDiferencia
      '
      Me.MasterReport = False
      Me.PageSettings.DefaultPaperSize = False
      Me.PageSettings.Margins.Bottom = 0.3!
      Me.PageSettings.Margins.Left = 0.5!
      Me.PageSettings.Margins.Right = 0.5!
      Me.PageSettings.Margins.Top = 0.5!
      Me.PageSettings.PaperHeight = 11.69!
      Me.PageSettings.PaperWidth = 8.27!
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
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblNroCuenta, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblBanco, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEncargado, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtExtracto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebitoSinC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldoLibro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTotales, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotalSaldoLibro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCreditoSinC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDiferenciaSinC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDiferencia, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotalBanco, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
      txtTotal.Text = 0
      'txtDiferencia.Text = ToDecimalDos(txtExtracto.Text) - ToDecimalDos(txtDebitoSinC.Text) + ToDecimalDos(txtCreditoSinC.Text) - ToDecimalDos(txtSaldoLibro.Text)
      txtTotalSaldoLibro.Text = ToDecimalDos(txtSaldoLibro.Text)
      txtTotalBanco.Text = ToDecimalDos(txtExtracto.Text) + ToDecimalDos(txtDiferenciaSinC.Text)
      txtDiferencia.Text = ToDecimalDos(txtTotalBanco.Text) - ToDecimalDos(txtTotalSaldoLibro.Text)
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      Dim oReport = CType(srptConciliaIngresoEgreso.Report, rptConciliaIngresoEgreso)
      txtTotal.Text = oReport.Total
   End Sub
End Class