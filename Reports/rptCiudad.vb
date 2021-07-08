Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptCiudad
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
   Public lblCentroCostoCod As DataDynamics.ActiveReports.Label
   Public lblCentroCostoDes As DataDynamics.ActiveReports.Label
   Public txtCiudadCod As DataDynamics.ActiveReports.TextBox
   Public txtPaisDes As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Public WithEvents Label1 As DataDynamics.ActiveReports.Label
   Public WithEvents txtDepartamentoDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtCiudad As DataDynamics.ActiveReports.TextBox
   Public WithEvents Label2 As DataDynamics.ActiveReports.Label
   Public WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
   Public WithEvents Label4 As DataDynamics.ActiveReports.Label
   Public lblLogin As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCiudad))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtCiudadCod = New DataDynamics.ActiveReports.TextBox
      Me.txtPaisDes = New DataDynamics.ActiveReports.TextBox
      Me.txtDepartamentoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCiudad = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.lblCentroCostoCod = New DataDynamics.ActiveReports.Label
      Me.lblCentroCostoDes = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      CType(Me.txtCiudadCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPaisDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDepartamentoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCentroCostoCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCentroCostoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCiudadCod, Me.txtPaisDes, Me.txtDepartamentoDes, Me.txtCiudad, Me.TextBox1})
      Me.Detail.Height = 0.1979167!
      Me.Detail.Name = "Detail"
      '
      'txtCiudadCod
      '
      Me.txtCiudadCod.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCiudadCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudadCod.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCiudadCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudadCod.Border.RightColor = System.Drawing.Color.Black
      Me.txtCiudadCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudadCod.Border.TopColor = System.Drawing.Color.Black
      Me.txtCiudadCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudadCod.DataField = "CiudadCod"
      Me.txtCiudadCod.Height = 0.1875!
      Me.txtCiudadCod.Left = 4.875!
      Me.txtCiudadCod.Name = "txtCiudadCod"
      Me.txtCiudadCod.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCiudadCod.Text = "CiudadCod"
      Me.txtCiudadCod.Top = 0.0!
      Me.txtCiudadCod.Width = 0.8125!
      '
      'txtPaisDes
      '
      Me.txtPaisDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPaisDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPaisDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPaisDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPaisDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtPaisDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPaisDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtPaisDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPaisDes.DataField = "PaisDes"
      Me.txtPaisDes.Height = 0.1875!
      Me.txtPaisDes.Left = 0.0!
      Me.txtPaisDes.Name = "txtPaisDes"
      Me.txtPaisDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPaisDes.Text = "PaisDes"
      Me.txtPaisDes.Top = 0.0!
      Me.txtPaisDes.Width = 1.3125!
      '
      'txtDepartamentoDes
      '
      Me.txtDepartamentoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDepartamentoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDepartamentoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDepartamentoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDepartamentoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtDepartamentoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDepartamentoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtDepartamentoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDepartamentoDes.DataField = "DepartamentoDes"
      Me.txtDepartamentoDes.Height = 0.1875!
      Me.txtDepartamentoDes.Left = 1.3125!
      Me.txtDepartamentoDes.Name = "txtDepartamentoDes"
      Me.txtDepartamentoDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtDepartamentoDes.Text = "DepartamentoDes"
      Me.txtDepartamentoDes.Top = 0.0!
      Me.txtDepartamentoDes.Width = 1.625!
      '
      'txtCiudad
      '
      Me.txtCiudad.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCiudad.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudad.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCiudad.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudad.Border.RightColor = System.Drawing.Color.Black
      Me.txtCiudad.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudad.Border.TopColor = System.Drawing.Color.Black
      Me.txtCiudad.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCiudad.DataField = "CiudadDes"
      Me.txtCiudad.Height = 0.1875!
      Me.txtCiudad.Left = 5.6875!
      Me.txtCiudad.Name = "txtCiudad"
      Me.txtCiudad.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCiudad.Text = "CiudadDes"
      Me.txtCiudad.Top = 0.0!
      Me.txtCiudad.Width = 1.8125!
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
          "align: middle; "
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
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCentroCostoCod, Me.lblCentroCostoDes, Me.Label1, Me.Label2, Me.Label4})
      Me.PageHeader.Height = 0.1875!
      Me.PageHeader.Name = "PageHeader"
      '
      'lblCentroCostoCod
      '
      Me.lblCentroCostoCod.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCentroCostoCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoCod.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCentroCostoCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCentroCostoCod.Border.RightColor = System.Drawing.Color.Black
      Me.lblCentroCostoCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCentroCostoCod.Border.TopColor = System.Drawing.Color.Black
      Me.lblCentroCostoCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoCod.Height = 0.1875!
      Me.lblCentroCostoCod.HyperLink = Nothing
      Me.lblCentroCostoCod.Left = 4.875!
      Me.lblCentroCostoCod.Name = "lblCentroCostoCod"
      Me.lblCentroCostoCod.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblCentroCostoCod.Text = "Código"
      Me.lblCentroCostoCod.Top = 0.0!
      Me.lblCentroCostoCod.Width = 0.8125!
      '
      'lblCentroCostoDes
      '
      Me.lblCentroCostoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCentroCostoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCentroCostoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblCentroCostoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCentroCostoDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblCentroCostoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoDes.Height = 0.1875!
      Me.lblCentroCostoDes.HyperLink = Nothing
      Me.lblCentroCostoDes.Left = 0.0!
      Me.lblCentroCostoDes.Name = "lblCentroCostoDes"
      Me.lblCentroCostoDes.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblCentroCostoDes.Text = "País"
      Me.lblCentroCostoDes.Top = 0.0!
      Me.lblCentroCostoDes.Width = 1.3125!
      '
      'Label1
      '
      Me.Label1.Border.BottomColor = System.Drawing.Color.Black
      Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Border.LeftColor = System.Drawing.Color.Black
      Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.RightColor = System.Drawing.Color.Black
      Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label1.Border.TopColor = System.Drawing.Color.Black
      Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label1.Height = 0.1875!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 1.3125!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label1.Text = "Departamento"
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 1.625!
      '
      'Label2
      '
      Me.Label2.Border.BottomColor = System.Drawing.Color.Black
      Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Border.LeftColor = System.Drawing.Color.Black
      Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.RightColor = System.Drawing.Color.Black
      Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Border.TopColor = System.Drawing.Color.Black
      Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label2.Height = 0.1875!
      Me.Label2.HyperLink = Nothing
      Me.Label2.Left = 5.6875!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label2.Text = "Ciudad"
      Me.Label2.Top = 0.0!
      Me.Label2.Width = 1.8125!
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
      Me.Label4.Height = 0.1875!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 2.9375!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label4.Text = "Provincia"
      Me.Label4.Top = 0.0!
      Me.Label4.Width = 1.9375!
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
      Me.TextBox1.DataField = "ProvinciaDes"
      Me.TextBox1.Height = 0.1875!
      Me.TextBox1.Left = 2.9375!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox1.Text = "ProvinciaDes"
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 1.9375!
      '
      'rptCiudad
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
      Me.PrintWidth = 7.510417!
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
      CType(Me.txtCiudadCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPaisDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDepartamentoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCiudad, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCentroCostoCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCentroCostoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

End Class