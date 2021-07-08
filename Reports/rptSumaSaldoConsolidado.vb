Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptSumaSaldoConsolidado
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
   Private Label As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private Label12 As DataDynamics.ActiveReports.Label
   Private Label13 As DataDynamics.ActiveReports.Label
   Private TextBox1 As DataDynamics.ActiveReports.TextBox
   Private TextBox2 As DataDynamics.ActiveReports.TextBox
   Private TextBox3 As DataDynamics.ActiveReports.TextBox
   Private TextBox4 As DataDynamics.ActiveReports.TextBox
   Private TextBox5 As DataDynamics.ActiveReports.TextBox
   Private TextBox As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Private WithEvents Label1 As DataDynamics.ActiveReports.Label
   Public WithEvents txtCentroCostoCod As DataDynamics.ActiveReports.TextBox
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSumaSaldoConsolidado))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
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
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
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
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.txtCentroCostoCod = New DataDynamics.ActiveReports.TextBox
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox})
      Me.Detail.Height = 0.1763889!
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
      Me.TextBox1.Text = "TextBox1"
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 0.75!
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
      Me.TextBox2.DataField = "PlanDes"
      Me.TextBox2.Height = 0.1875!
      Me.TextBox2.Left = 0.75!
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox2.Text = "TextBox2"
      Me.TextBox2.Top = 0.0!
      Me.TextBox2.Width = 3.3125!
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
      Me.TextBox3.DataField = "Debe"
      Me.TextBox3.Height = 0.1875!
      Me.TextBox3.Left = 4.9375!
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
      Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox3.Text = "TextBox3"
      Me.TextBox3.Top = 0.0!
      Me.TextBox3.Width = 0.875!
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
      Me.TextBox4.DataField = "Haber"
      Me.TextBox4.Height = 0.1875!
      Me.TextBox4.Left = 5.8125!
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
      Me.TextBox4.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox4.Text = "TextBox4"
      Me.TextBox4.Top = 0.0!
      Me.TextBox4.Width = 0.875!
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
      Me.TextBox5.DataField = "Saldo"
      Me.TextBox5.Height = 0.1875!
      Me.TextBox5.Left = 6.6875!
      Me.TextBox5.Name = "TextBox5"
      Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
      Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox5.Text = "TextBox5"
      Me.TextBox5.Top = 0.0!
      Me.TextBox5.Width = 0.8125!
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
      Me.TextBox.DataField = "SaldoAnt"
      Me.TextBox.Height = 0.1875!
      Me.TextBox.Left = 4.0625!
      Me.TextBox.Name = "TextBox"
      Me.TextBox.OutputFormat = resources.GetString("TextBox.OutputFormat")
      Me.TextBox.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.TextBox.Text = "TextBox"
      Me.TextBox.Top = 0.0!
      Me.TextBox.Width = 0.875!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label4, Me.txtFechaIni, Me.Label5, Me.txtFechaFin, Me.Label6, Me.txtMoneda, Me.Label1, Me.txtCentroCostoCod})
      Me.ReportHeader.Height = 1.260417!
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
      Me.Line1.Top = 0.597222!
      Me.Line1.Width = 7.4375!
      Me.Line1.X1 = 0.03472221!
      Me.Line1.X2 = 7.472222!
      Me.Line1.Y1 = 0.597222!
      Me.Line1.Y2 = 0.597222!
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
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label7, Me.Label10, Me.Label, Me.Label11, Me.Label12, Me.Label13})
      Me.PageHeader.Height = 0.21875!
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
      Me.Label7.Text = "Cuenta"
      Me.Label7.Top = 0.0!
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
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 3.3125!
      '
      'Label
      '
      Me.Label.Border.BottomColor = System.Drawing.Color.Black
      Me.Label.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label.Border.LeftColor = System.Drawing.Color.Black
      Me.Label.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.RightColor = System.Drawing.Color.Black
      Me.Label.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.TopColor = System.Drawing.Color.Black
      Me.Label.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label.Height = 0.1875!
      Me.Label.HyperLink = Nothing
      Me.Label.Left = 4.0625!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label.Text = "Saldo Ant."
      Me.Label.Top = 0.0!
      Me.Label.Width = 0.875!
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
      Me.Label11.Text = "Débito"
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
      Me.Label12.Text = "Crédito"
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
      Me.Label3.Left = 6.885413!
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
      'Label1
      '
      Me.Label1.Border.BottomColor = System.Drawing.Color.Black
      Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Border.LeftColor = System.Drawing.Color.Black
      Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Border.RightColor = System.Drawing.Color.Black
      Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.TopColor = System.Drawing.Color.Black
      Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Height = 0.1875!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 0.0625!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label1.Text = "Centro Costo "
      Me.Label1.Top = 1.0!
      Me.Label1.Width = 0.8125!
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
      Me.txtCentroCostoCod.Top = 1.0!
      Me.txtCentroCostoCod.Width = 6.625!
      '
      'rptSumaSaldoConsolidado
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
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

End Class