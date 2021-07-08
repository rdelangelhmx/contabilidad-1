Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptEstadoResultadoComparativoExt
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
   Private Label10 As DataDynamics.ActiveReports.Label
   Public WithEvents lblCol01 As DataDynamics.ActiveReports.Label
   Public WithEvents lblCol02 As DataDynamics.ActiveReports.Label
   Public WithEvents lblCol03 As DataDynamics.ActiveReports.Label
   Public WithEvents lblCol04 As DataDynamics.ActiveReports.Label
   Public WithEvents lblCol05 As DataDynamics.ActiveReports.Label
   Public WithEvents lblCol06 As DataDynamics.ActiveReports.Label
   Private txtPlanCta As DataDynamics.ActiveReports.TextBox
   Private txtPlanDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtCol02 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtCol03 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtCol04 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtCol05 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtCol06 As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtCol01 As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Private WithEvents Label8 As DataDynamics.ActiveReports.Label
   Public WithEvents txtFechaIni As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label9 As DataDynamics.ActiveReports.Label
   Public WithEvents txtFechaFin As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtCentroCosto As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label18 As DataDynamics.ActiveReports.Label
   Public WithEvents txtMoneda As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label6 As DataDynamics.ActiveReports.Label
   Public WithEvents lblEmpresa01 As DataDynamics.ActiveReports.Label
   Public WithEvents lblEmpresa02 As DataDynamics.ActiveReports.Label
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptEstadoResultadoComparativoExt))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtPlanCta = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCol02 = New DataDynamics.ActiveReports.TextBox
      Me.txtCol03 = New DataDynamics.ActiveReports.TextBox
      Me.txtCol04 = New DataDynamics.ActiveReports.TextBox
      Me.txtCol05 = New DataDynamics.ActiveReports.TextBox
      Me.txtCol06 = New DataDynamics.ActiveReports.TextBox
      Me.txtCol01 = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.txtFechaIni = New DataDynamics.ActiveReports.TextBox
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.txtFechaFin = New DataDynamics.ActiveReports.TextBox
      Me.txtCentroCosto = New DataDynamics.ActiveReports.TextBox
      Me.Label18 = New DataDynamics.ActiveReports.Label
      Me.txtMoneda = New DataDynamics.ActiveReports.TextBox
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.lblCol01 = New DataDynamics.ActiveReports.Label
      Me.lblCol02 = New DataDynamics.ActiveReports.Label
      Me.lblCol03 = New DataDynamics.ActiveReports.Label
      Me.lblCol04 = New DataDynamics.ActiveReports.Label
      Me.lblCol05 = New DataDynamics.ActiveReports.Label
      Me.lblCol06 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.lblEmpresa01 = New DataDynamics.ActiveReports.Label
      Me.lblEmpresa02 = New DataDynamics.ActiveReports.Label
      CType(Me.txtPlanCta, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCol02, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCol03, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCol04, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCol05, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCol06, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCol01, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCol01, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCol02, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCol03, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCol04, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCol05, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCol06, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblEmpresa01, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblEmpresa02, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPlanCta, Me.txtPlanDes, Me.txtCol02, Me.txtCol03, Me.txtCol04, Me.txtCol05, Me.txtCol06, Me.txtCol01})
      Me.Detail.Height = 0.1875!
      Me.Detail.Name = "Detail"
      '
      'txtPlanCta
      '
      Me.txtPlanCta.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPlanCta.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanCta.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPlanCta.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanCta.Border.RightColor = System.Drawing.Color.Black
      Me.txtPlanCta.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanCta.Border.TopColor = System.Drawing.Color.Black
      Me.txtPlanCta.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanCta.DataField = "PlanCta"
      Me.txtPlanCta.Height = 0.1875!
      Me.txtPlanCta.Left = 0.0!
      Me.txtPlanCta.Name = "txtPlanCta"
      Me.txtPlanCta.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPlanCta.Text = "TextBox1"
      Me.txtPlanCta.Top = 0.0!
      Me.txtPlanCta.Width = 0.75!
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
      Me.txtPlanDes.Text = "TextBox2"
      Me.txtPlanDes.Top = 0.0!
      Me.txtPlanDes.Width = 2.25!
      '
      'txtCol02
      '
      Me.txtCol02.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCol02.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol02.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCol02.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol02.Border.RightColor = System.Drawing.Color.Black
      Me.txtCol02.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol02.Border.TopColor = System.Drawing.Color.Black
      Me.txtCol02.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol02.Height = 0.1875!
      Me.txtCol02.Left = 3.75!
      Me.txtCol02.Name = "txtCol02"
      Me.txtCol02.OutputFormat = resources.GetString("txtCol02.OutputFormat")
      Me.txtCol02.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCol02.Text = "TextBox3"
      Me.txtCol02.Top = 0.0!
      Me.txtCol02.Width = 0.75!
      '
      'txtCol03
      '
      Me.txtCol03.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCol03.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol03.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCol03.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol03.Border.RightColor = System.Drawing.Color.Black
      Me.txtCol03.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol03.Border.TopColor = System.Drawing.Color.Black
      Me.txtCol03.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol03.Height = 0.1875!
      Me.txtCol03.Left = 4.5!
      Me.txtCol03.Name = "txtCol03"
      Me.txtCol03.OutputFormat = resources.GetString("txtCol03.OutputFormat")
      Me.txtCol03.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCol03.Text = "TextBox4"
      Me.txtCol03.Top = 0.0!
      Me.txtCol03.Width = 0.75!
      '
      'txtCol04
      '
      Me.txtCol04.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCol04.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol04.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCol04.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol04.Border.RightColor = System.Drawing.Color.Black
      Me.txtCol04.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol04.Border.TopColor = System.Drawing.Color.Black
      Me.txtCol04.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol04.Height = 0.1875!
      Me.txtCol04.Left = 5.25!
      Me.txtCol04.Name = "txtCol04"
      Me.txtCol04.OutputFormat = resources.GetString("txtCol04.OutputFormat")
      Me.txtCol04.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCol04.Text = "TextBox5"
      Me.txtCol04.Top = 0.0!
      Me.txtCol04.Width = 0.75!
      '
      'txtCol05
      '
      Me.txtCol05.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCol05.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol05.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCol05.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol05.Border.RightColor = System.Drawing.Color.Black
      Me.txtCol05.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol05.Border.TopColor = System.Drawing.Color.Black
      Me.txtCol05.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol05.Height = 0.1875!
      Me.txtCol05.Left = 6.0!
      Me.txtCol05.Name = "txtCol05"
      Me.txtCol05.OutputFormat = resources.GetString("txtCol05.OutputFormat")
      Me.txtCol05.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCol05.Text = "TextBox6"
      Me.txtCol05.Top = 0.0!
      Me.txtCol05.Width = 0.75!
      '
      'txtCol06
      '
      Me.txtCol06.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCol06.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol06.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCol06.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol06.Border.RightColor = System.Drawing.Color.Black
      Me.txtCol06.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol06.Border.TopColor = System.Drawing.Color.Black
      Me.txtCol06.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol06.Height = 0.1875!
      Me.txtCol06.Left = 6.75!
      Me.txtCol06.Name = "txtCol06"
      Me.txtCol06.OutputFormat = resources.GetString("txtCol06.OutputFormat")
      Me.txtCol06.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCol06.Text = "TextBox7"
      Me.txtCol06.Top = 0.0!
      Me.txtCol06.Width = 0.7395827!
      '
      'txtCol01
      '
      Me.txtCol01.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCol01.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol01.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCol01.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol01.Border.RightColor = System.Drawing.Color.Black
      Me.txtCol01.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol01.Border.TopColor = System.Drawing.Color.Black
      Me.txtCol01.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCol01.Height = 0.1875!
      Me.txtCol01.Left = 3.0!
      Me.txtCol01.Name = "txtCol01"
      Me.txtCol01.OutputFormat = resources.GetString("txtCol01.OutputFormat")
      Me.txtCol01.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtCol01.Text = "TextBox"
      Me.txtCol01.Top = 0.0!
      Me.txtCol01.Width = 0.75!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1, Me.Label8, Me.txtFechaIni, Me.Label9, Me.txtFechaFin, Me.txtCentroCosto, Me.Label18, Me.txtMoneda, Me.Label6})
      Me.ReportHeader.Height = 1.072917!
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
      'Label8
      '
      Me.Label8.Border.BottomColor = System.Drawing.Color.Black
      Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.LeftColor = System.Drawing.Color.Black
      Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.RightColor = System.Drawing.Color.Black
      Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Border.TopColor = System.Drawing.Color.Black
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Height = 0.1875!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 4.4375!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label8.Text = "Del"
      Me.Label8.Top = 0.75!
      Me.Label8.Width = 0.25!
      '
      'txtFechaIni
      '
      Me.txtFechaIni.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaIni.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaIni.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaIni.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaIni.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaIni.Height = 0.1875!
      Me.txtFechaIni.Left = 4.6875!
      Me.txtFechaIni.Name = "txtFechaIni"
      Me.txtFechaIni.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaIni.Text = Nothing
      Me.txtFechaIni.Top = 0.75!
      Me.txtFechaIni.Width = 0.625!
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
      Me.Label9.Left = 5.3125!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; background-color: Silver;" & _
          " font-size: 8pt; vertical-align: middle; "
      Me.Label9.Text = "al"
      Me.Label9.Top = 0.75!
      Me.Label9.Width = 0.1875!
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
      Me.txtFechaFin.Left = 5.5!
      Me.txtFechaFin.Name = "txtFechaFin"
      Me.txtFechaFin.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtFechaFin.Text = Nothing
      Me.txtFechaFin.Top = 0.75!
      Me.txtFechaFin.Width = 0.625!
      '
      'txtCentroCosto
      '
      Me.txtCentroCosto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCosto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCentroCosto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCosto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCosto.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCosto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCentroCosto.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCosto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCentroCosto.Height = 0.1875!
      Me.txtCentroCosto.Left = 0.8125!
      Me.txtCentroCosto.Name = "txtCentroCosto"
      Me.txtCentroCosto.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtCentroCosto.Text = Nothing
      Me.txtCentroCosto.Top = 0.75!
      Me.txtCentroCosto.Width = 2.8125!
      '
      'Label18
      '
      Me.Label18.Border.BottomColor = System.Drawing.Color.Black
      Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label18.Border.LeftColor = System.Drawing.Color.Black
      Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label18.Border.RightColor = System.Drawing.Color.Black
      Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label18.Border.TopColor = System.Drawing.Color.Black
      Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label18.Height = 0.1875!
      Me.Label18.HyperLink = Nothing
      Me.Label18.Left = 0.0!
      Me.Label18.Name = "Label18"
      Me.Label18.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label18.Text = "Centro Costo"
      Me.Label18.Top = 0.75!
      Me.Label18.Width = 0.8125!
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
      Me.txtMoneda.Left = 6.6875!
      Me.txtMoneda.Name = "txtMoneda"
      Me.txtMoneda.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMoneda.Text = Nothing
      Me.txtMoneda.Top = 0.75!
      Me.txtMoneda.Width = 0.75!
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
      Me.Label6.Left = 6.1875!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Moneda"
      Me.Label6.Top = 0.75!
      Me.Label6.Width = 0.5!
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label7, Me.Label10, Me.lblCol01, Me.lblCol02, Me.lblCol03, Me.lblCol04, Me.lblCol05, Me.lblCol06, Me.lblEmpresa01, Me.lblEmpresa02})
      Me.PageHeader.Height = 0.4479167!
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
      Me.Label7.Height = 0.4375!
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
      Me.Label10.Height = 0.4375!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 0.75!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label10.Text = "Descripción"
      Me.Label10.Top = 0.0!
      Me.Label10.Width = 2.25!
      '
      'lblCol01
      '
      Me.lblCol01.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCol01.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol01.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCol01.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol01.Border.RightColor = System.Drawing.Color.Black
      Me.lblCol01.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol01.Border.TopColor = System.Drawing.Color.Black
      Me.lblCol01.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol01.Height = 0.125!
      Me.lblCol01.HyperLink = Nothing
      Me.lblCol01.Left = 3.0!
      Me.lblCol01.Name = "lblCol01"
      Me.lblCol01.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCol01.Text = "Detalle"
      Me.lblCol01.Top = 0.3125!
      Me.lblCol01.Width = 0.75!
      '
      'lblCol02
      '
      Me.lblCol02.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCol02.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol02.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCol02.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol02.Border.RightColor = System.Drawing.Color.Black
      Me.lblCol02.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol02.Border.TopColor = System.Drawing.Color.Black
      Me.lblCol02.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol02.Height = 0.125!
      Me.lblCol02.HyperLink = Nothing
      Me.lblCol02.Left = 3.75!
      Me.lblCol02.Name = "lblCol02"
      Me.lblCol02.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCol02.Text = "Saldo"
      Me.lblCol02.Top = 0.3125!
      Me.lblCol02.Width = 0.75!
      '
      'lblCol03
      '
      Me.lblCol03.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCol03.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol03.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCol03.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol03.Border.RightColor = System.Drawing.Color.Black
      Me.lblCol03.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol03.Border.TopColor = System.Drawing.Color.Black
      Me.lblCol03.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol03.Height = 0.125!
      Me.lblCol03.HyperLink = Nothing
      Me.lblCol03.Left = 4.5!
      Me.lblCol03.Name = "lblCol03"
      Me.lblCol03.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCol03.Text = "Detalle"
      Me.lblCol03.Top = 0.3125!
      Me.lblCol03.Width = 0.75!
      '
      'lblCol04
      '
      Me.lblCol04.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCol04.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol04.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCol04.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol04.Border.RightColor = System.Drawing.Color.Black
      Me.lblCol04.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol04.Border.TopColor = System.Drawing.Color.Black
      Me.lblCol04.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol04.Height = 0.125!
      Me.lblCol04.HyperLink = Nothing
      Me.lblCol04.Left = 5.25!
      Me.lblCol04.Name = "lblCol04"
      Me.lblCol04.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCol04.Text = "Saldo"
      Me.lblCol04.Top = 0.3125!
      Me.lblCol04.Width = 0.75!
      '
      'lblCol05
      '
      Me.lblCol05.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCol05.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol05.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCol05.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol05.Border.RightColor = System.Drawing.Color.Black
      Me.lblCol05.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol05.Border.TopColor = System.Drawing.Color.Black
      Me.lblCol05.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol05.Height = 0.4375!
      Me.lblCol05.HyperLink = Nothing
      Me.lblCol05.Left = 6.0!
      Me.lblCol05.Name = "lblCol05"
      Me.lblCol05.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCol05.Text = ""
      Me.lblCol05.Top = 0.0!
      Me.lblCol05.Width = 0.75!
      '
      'lblCol06
      '
      Me.lblCol06.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCol06.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol06.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCol06.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCol06.Border.RightColor = System.Drawing.Color.Black
      Me.lblCol06.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol06.Border.TopColor = System.Drawing.Color.Black
      Me.lblCol06.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCol06.Height = 0.4375!
      Me.lblCol06.HyperLink = Nothing
      Me.lblCol06.Left = 6.75!
      Me.lblCol06.Name = "lblCol06"
      Me.lblCol06.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.lblCol06.Text = ""
      Me.lblCol06.Top = 0.0!
      Me.lblCol06.Width = 0.75!
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
      'lblEmpresa01
      '
      Me.lblEmpresa01.Border.BottomColor = System.Drawing.Color.Black
      Me.lblEmpresa01.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblEmpresa01.Border.LeftColor = System.Drawing.Color.Black
      Me.lblEmpresa01.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa01.Border.RightColor = System.Drawing.Color.Black
      Me.lblEmpresa01.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa01.Border.TopColor = System.Drawing.Color.Black
      Me.lblEmpresa01.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblEmpresa01.Height = 0.3125!
      Me.lblEmpresa01.HyperLink = Nothing
      Me.lblEmpresa01.Left = 3.0!
      Me.lblEmpresa01.Name = "lblEmpresa01"
      Me.lblEmpresa01.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblEmpresa01.Text = ""
      Me.lblEmpresa01.Top = 0.0!
      Me.lblEmpresa01.Width = 1.5!
      '
      'lblEmpresa02
      '
      Me.lblEmpresa02.Border.BottomColor = System.Drawing.Color.Black
      Me.lblEmpresa02.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblEmpresa02.Border.LeftColor = System.Drawing.Color.Black
      Me.lblEmpresa02.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa02.Border.RightColor = System.Drawing.Color.Black
      Me.lblEmpresa02.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEmpresa02.Border.TopColor = System.Drawing.Color.Black
      Me.lblEmpresa02.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblEmpresa02.Height = 0.3125!
      Me.lblEmpresa02.HyperLink = Nothing
      Me.lblEmpresa02.Left = 4.5!
      Me.lblEmpresa02.Name = "lblEmpresa02"
      Me.lblEmpresa02.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblEmpresa02.Text = ""
      Me.lblEmpresa02.Top = 0.0!
      Me.lblEmpresa02.Width = 1.5!
      '
      'rptEstadoResultadoComparativoExt
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
      CType(Me.txtPlanCta, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCol02, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCol03, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCol04, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCol05, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCol06, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCol01, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaIni, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaFin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMoneda, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCol01, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCol02, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCol03, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCol04, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCol05, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCol06, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblEmpresa01, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblEmpresa02, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      If ToBoolean(Me.Fields("EsAna").Value) = 0 Then
         txtPlanCta.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)

      Else
         txtPlanCta.Font = New System.Drawing.Font("Arial", 8.0!)
      End If

      txtPlanDes.Font = txtPlanCta.Font
      txtCol01.Font = txtPlanCta.Font
      txtCol02.Font = txtPlanCta.Font
      txtCol03.Font = txtPlanCta.Font
      txtCol04.Font = txtPlanCta.Font
      txtCol05.Font = txtPlanCta.Font
      txtCol06.Font = txtPlanCta.Font
   End Sub

End Class