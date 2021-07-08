Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptLibroDispoConsolidado
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
   Public WithEvents lblFechaIni As DataDynamics.ActiveReports.Label
   Public txtFechaIni As DataDynamics.ActiveReports.TextBox
   Public WithEvents lblFechaFin As DataDynamics.ActiveReports.Label
   Public txtFechaFin As DataDynamics.ActiveReports.TextBox
   Private Label6 As DataDynamics.ActiveReports.Label
   Public txtMoneda As DataDynamics.ActiveReports.TextBox
   Private Label7 As DataDynamics.ActiveReports.Label
   Private Label10 As DataDynamics.ActiveReports.Label
   Public WithEvents lblSaldoAnt As DataDynamics.ActiveReports.Label
   Public WithEvents lblDebe As DataDynamics.ActiveReports.Label
   Public WithEvents lblHaber As DataDynamics.ActiveReports.Label
   Public WithEvents lblSaldo1 As DataDynamics.ActiveReports.Label
   Public WithEvents txtSaldo1 As DataDynamics.ActiveReports.TextBox
   Private TextBox1 As DataDynamics.ActiveReports.TextBox
   Private txtPlanDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtHaber As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtDebe As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtSaldoAnt As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Public WithEvents lblSaldo2 As DataDynamics.ActiveReports.Label
   Public WithEvents txtSaldo2 As DataDynamics.ActiveReports.TextBox
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptLibroDispoConsolidado))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtSaldo1 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanDes = New DataDynamics.ActiveReports.TextBox
      Me.txtHaber = New DataDynamics.ActiveReports.TextBox
      Me.txtDebe = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldoAnt = New DataDynamics.ActiveReports.TextBox
      Me.txtSaldo2 = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.lblFechaIni = New DataDynamics.ActiveReports.Label
      Me.txtFechaIni = New DataDynamics.ActiveReports.TextBox
      Me.lblFechaFin = New DataDynamics.ActiveReports.Label
      Me.txtFechaFin = New DataDynamics.ActiveReports.TextBox
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.txtMoneda = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.lblSaldoAnt = New DataDynamics.ActiveReports.Label
      Me.lblDebe = New DataDynamics.ActiveReports.Label
      Me.lblHaber = New DataDynamics.ActiveReports.Label
      Me.lblSaldo1 = New DataDynamics.ActiveReports.Label
      Me.lblSaldo2 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      CType(Me.txtSaldo1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtHaber, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebe, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSaldo2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSaldoAnt, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDebe, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblHaber, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSaldo1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSaldo2, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSaldo1, Me.TextBox1, Me.txtPlanDes, Me.txtHaber, Me.txtDebe, Me.txtSaldoAnt, Me.txtSaldo2})
      Me.Detail.Height = 0.1979167!
      Me.Detail.Name = "Detail"
      '
      'txtSaldo1
      '
      Me.txtSaldo1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSaldo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSaldo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo1.Border.RightColor = System.Drawing.Color.Black
      Me.txtSaldo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo1.Border.TopColor = System.Drawing.Color.Black
      Me.txtSaldo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSaldo1.DataField = "Saldo"
      Me.txtSaldo1.Height = 0.1875!
      Me.txtSaldo1.Left = 5.875!
      Me.txtSaldo1.Name = "txtSaldo1"
      Me.txtSaldo1.OutputFormat = resources.GetString("txtSaldo1.OutputFormat")
      Me.txtSaldo1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtSaldo1.Text = "Saldo"
      Me.txtSaldo1.Top = 0.0!
      Me.txtSaldo1.Width = 0.8125!
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
      Me.TextBox1.Text = "PlanCta"
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 1.0!
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
      Me.txtPlanDes.Left = 1.0!
      Me.txtPlanDes.Name = "txtPlanDes"
      Me.txtPlanDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPlanDes.Text = "PlanDes"
      Me.txtPlanDes.Top = 0.0!
      Me.txtPlanDes.Width = 2.4375!
      '
      'txtHaber
      '
      Me.txtHaber.Border.BottomColor = System.Drawing.Color.Black
      Me.txtHaber.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaber.Border.LeftColor = System.Drawing.Color.Black
      Me.txtHaber.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaber.Border.RightColor = System.Drawing.Color.Black
      Me.txtHaber.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaber.Border.TopColor = System.Drawing.Color.Black
      Me.txtHaber.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaber.DataField = "Haber"
      Me.txtHaber.Height = 0.1875!
      Me.txtHaber.Left = 5.0625!
      Me.txtHaber.Name = "txtHaber"
      Me.txtHaber.OutputFormat = resources.GetString("txtHaber.OutputFormat")
      Me.txtHaber.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtHaber.Text = "Haber"
      Me.txtHaber.Top = 0.0!
      Me.txtHaber.Width = 0.8125!
      '
      'txtDebe
      '
      Me.txtDebe.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDebe.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebe.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDebe.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebe.Border.RightColor = System.Drawing.Color.Black
      Me.txtDebe.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebe.Border.TopColor = System.Drawing.Color.Black
      Me.txtDebe.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebe.DataField = "Debe"
      Me.txtDebe.Height = 0.1875!
      Me.txtDebe.Left = 4.25!
      Me.txtDebe.Name = "txtDebe"
      Me.txtDebe.OutputFormat = resources.GetString("txtDebe.OutputFormat")
      Me.txtDebe.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtDebe.Text = "Debe"
      Me.txtDebe.Top = 0.0!
      Me.txtDebe.Width = 0.8125!
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
      Me.txtSaldoAnt.DataField = "SaldoAnt"
      Me.txtSaldoAnt.Height = 0.1875!
      Me.txtSaldoAnt.Left = 3.4375!
      Me.txtSaldoAnt.Name = "txtSaldoAnt"
      Me.txtSaldoAnt.OutputFormat = resources.GetString("txtSaldoAnt.OutputFormat")
      Me.txtSaldoAnt.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtSaldoAnt.Text = "SaldoAnt"
      Me.txtSaldoAnt.Top = 0.0!
      Me.txtSaldoAnt.Width = 0.8125!
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
      Me.txtSaldo2.DataField = "Saldo"
      Me.txtSaldo2.Height = 0.1875!
      Me.txtSaldo2.Left = 6.6875!
      Me.txtSaldo2.Name = "txtSaldo2"
      Me.txtSaldo2.OutputFormat = resources.GetString("txtSaldo2.OutputFormat")
      Me.txtSaldo2.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.txtSaldo2.Text = "Saldo"
      Me.txtSaldo2.Top = 0.0!
      Me.txtSaldo2.Width = 0.8125!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.lblFechaIni, Me.txtFechaIni, Me.lblFechaFin, Me.txtFechaFin, Me.Label6, Me.txtMoneda})
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
      'lblFechaIni
      '
      Me.lblFechaIni.Border.BottomColor = System.Drawing.Color.Black
      Me.lblFechaIni.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblFechaIni.Border.LeftColor = System.Drawing.Color.Black
      Me.lblFechaIni.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblFechaIni.Border.RightColor = System.Drawing.Color.Black
      Me.lblFechaIni.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFechaIni.Border.TopColor = System.Drawing.Color.Black
      Me.lblFechaIni.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblFechaIni.Height = 0.1875!
      Me.lblFechaIni.HyperLink = Nothing
      Me.lblFechaIni.Left = 1.5625!
      Me.lblFechaIni.Name = "lblFechaIni"
      Me.lblFechaIni.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblFechaIni.Text = "Fecha Inicial"
      Me.lblFechaIni.Top = 0.75!
      Me.lblFechaIni.Width = 0.75!
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
      Me.txtFechaIni.Left = 2.3125!
      Me.txtFechaIni.Name = "txtFechaIni"
      Me.txtFechaIni.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaIni.Text = Nothing
      Me.txtFechaIni.Top = 0.75!
      Me.txtFechaIni.Width = 0.625!
      '
      'lblFechaFin
      '
      Me.lblFechaFin.Border.BottomColor = System.Drawing.Color.Black
      Me.lblFechaFin.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblFechaFin.Border.LeftColor = System.Drawing.Color.Black
      Me.lblFechaFin.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblFechaFin.Border.RightColor = System.Drawing.Color.Black
      Me.lblFechaFin.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFechaFin.Border.TopColor = System.Drawing.Color.Black
      Me.lblFechaFin.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblFechaFin.Height = 0.1875!
      Me.lblFechaFin.HyperLink = Nothing
      Me.lblFechaFin.Left = 3.0625!
      Me.lblFechaFin.Name = "lblFechaFin"
      Me.lblFechaFin.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblFechaFin.Text = "Fecha Final"
      Me.lblFechaFin.Top = 0.75!
      Me.lblFechaFin.Width = 0.75!
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
      Me.txtFechaFin.Left = 3.8125!
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
      Me.Label6.Left = 0.0625!
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
      Me.txtMoneda.Left = 0.8125!
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
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label7, Me.Label10, Me.lblSaldoAnt, Me.lblDebe, Me.lblHaber, Me.lblSaldo1, Me.lblSaldo2})
      Me.PageHeader.Height = 0.1979167!
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
      Me.Label7.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label7.Text = "Cuenta"
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 1.0!
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
      Me.Label10.Left = 1.0!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label10.Text = "Descripción"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 2.4375!
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
      Me.lblSaldoAnt.Left = 3.4375!
      Me.lblSaldoAnt.Name = "lblSaldoAnt"
      Me.lblSaldoAnt.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblSaldoAnt.Text = "Saldo Ant."
      Me.lblSaldoAnt.Top = 0.0!
      Me.lblSaldoAnt.Width = 0.8125!
      '
      'lblDebe
      '
      Me.lblDebe.Border.BottomColor = System.Drawing.Color.Black
      Me.lblDebe.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblDebe.Border.LeftColor = System.Drawing.Color.Black
      Me.lblDebe.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDebe.Border.RightColor = System.Drawing.Color.Black
      Me.lblDebe.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblDebe.Border.TopColor = System.Drawing.Color.Black
      Me.lblDebe.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblDebe.Height = 0.1875!
      Me.lblDebe.HyperLink = Nothing
      Me.lblDebe.Left = 4.25!
      Me.lblDebe.Name = "lblDebe"
      Me.lblDebe.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblDebe.Text = "Debe"
      Me.lblDebe.Top = 0.0!
      Me.lblDebe.Width = 0.8125!
      '
      'lblHaber
      '
      Me.lblHaber.Border.BottomColor = System.Drawing.Color.Black
      Me.lblHaber.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblHaber.Border.LeftColor = System.Drawing.Color.Black
      Me.lblHaber.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblHaber.Border.RightColor = System.Drawing.Color.Black
      Me.lblHaber.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblHaber.Border.TopColor = System.Drawing.Color.Black
      Me.lblHaber.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblHaber.Height = 0.1875!
      Me.lblHaber.HyperLink = Nothing
      Me.lblHaber.Left = 5.0625!
      Me.lblHaber.Name = "lblHaber"
      Me.lblHaber.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblHaber.Text = "Haber"
      Me.lblHaber.Top = 0.0!
      Me.lblHaber.Width = 0.8125!
      '
      'lblSaldo1
      '
      Me.lblSaldo1.Border.BottomColor = System.Drawing.Color.Black
      Me.lblSaldo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo1.Border.LeftColor = System.Drawing.Color.Black
      Me.lblSaldo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldo1.Border.RightColor = System.Drawing.Color.Black
      Me.lblSaldo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSaldo1.Border.TopColor = System.Drawing.Color.Black
      Me.lblSaldo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSaldo1.Height = 0.1875!
      Me.lblSaldo1.HyperLink = Nothing
      Me.lblSaldo1.Left = 5.875!
      Me.lblSaldo1.Name = "lblSaldo1"
      Me.lblSaldo1.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblSaldo1.Text = "Saldo"
      Me.lblSaldo1.Top = 0.0!
      Me.lblSaldo1.Width = 0.8125!
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
      Me.lblSaldo2.Left = 6.6875!
      Me.lblSaldo2.Name = "lblSaldo2"
      Me.lblSaldo2.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblSaldo2.Text = "Saldo"
      Me.lblSaldo2.Top = 0.0!
      Me.lblSaldo2.Width = 0.8125!
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
      Me.txtPageCount.Left = 7.125!
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
      Me.txtPageNOfM.Left = 6.4375!
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
      Me.Label3.Left = 6.885411!
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
      Me.Line2.Width = 7.5!
      Me.Line2.X1 = 0.02083333!
      Me.Line2.X2 = 7.520833!
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
      'rptLibroDispoConsolidado
      '
      Me.MasterReport = False
      Me.PageSettings.Margins.Bottom = 0.3!
      Me.PageSettings.Margins.Left = 0.5!
      Me.PageSettings.Margins.Right = 0.5!
      Me.PageSettings.Margins.Top = 0.5!
      Me.PageSettings.PaperHeight = 11.69!
      Me.PageSettings.PaperWidth = 8.27!
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
      CType(Me.txtSaldo1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtHaber, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebe, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSaldo2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSaldoAnt, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDebe, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblHaber, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSaldo1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSaldo2, System.ComponentModel.ISupportInitialize).EndInit()
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


   Private mboolIntervaloFecha As Boolean
   Public Property IntervaloFecha() As Boolean
      Get
         Return mboolIntervaloFecha
      End Get
      Set(ByVal value As Boolean)
         mboolIntervaloFecha = value
      End Set
   End Property


   Private mlngMonedaId As Long
   Public Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get
      Set(ByVal value As Long)
         mlngMonedaId = value
      End Set
   End Property

   Private Sub rptLibroDispoConsolidado_DataInitialize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DataInitialize
      lblFechaIni.Visible = mboolIntervaloFecha
      txtFechaIni.Visible = mboolIntervaloFecha
      lblFechaFin.Visible = mboolIntervaloFecha
      txtFechaFin.Visible = mboolIntervaloFecha

      If mlngMonedaId = clsMoneda.BOLIVIANOS Then
         lblSaldoAnt.Text = "Saldo Ant. Bs"
         txtSaldoAnt.DataField = "SaldoAntBs"
         lblDebe.Text = "Debe Bs"
         txtDebe.DataField = "DebeBs"
         lblHaber.Text = "Haber Bs"
         txtHaber.DataField = "HaberBs"
         lblSaldo1.Text = "Saldo Bs"
         txtSaldo1.DataField = "SaldoBs"
         lblSaldo2.Text = "Saldo Us"
         txtSaldo2.DataField = "SaldoUs"
      End If
      If mlngMonedaId = clsMoneda.DOLARES Then
         lblSaldoAnt.Text = "Saldo Ant. Us"
         txtSaldoAnt.DataField = "SaldoAntUs"
         lblDebe.Text = "Debe Us"
         txtDebe.DataField = "DebeUs"
         lblHaber.Text = "Haber Us"
         txtHaber.DataField = "HaberUs"
         lblSaldo1.Text = "Saldo Us"
         txtSaldo1.DataField = "SaldoUs"
         lblSaldo2.Text = "Saldo Bs"
         txtSaldo2.DataField = "SaldoBs"
      End If

      If Not mboolSaldoAnterior Then
         lblSaldoAnt.Text = ""
         txtSaldoAnt.Text = ""
         txtSaldoAnt.DataField = ""
         txtPlanDes.Width = txtPlanDes.Width + txtSaldoAnt.Width
      End If
   End Sub

End Class