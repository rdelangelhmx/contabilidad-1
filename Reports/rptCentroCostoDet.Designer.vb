<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptCentroCostoDet 
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
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCentroCostoDet))
      Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
      Me.lblCentroCostoCod = New DataDynamics.ActiveReports.Label
      Me.lblCentroCostoDes = New DataDynamics.ActiveReports.Label
      Me.lblPlanCta = New DataDynamics.ActiveReports.Label
      Me.lblPlanDes = New DataDynamics.ActiveReports.Label
      Me.Detail1 = New DataDynamics.ActiveReports.Detail
      Me.txtCentroCostoCod1 = New DataDynamics.ActiveReports.TextBox
      Me.txtCentroCostoDes1 = New DataDynamics.ActiveReports.TextBox
      Me.txtCentroCostoDetCod1 = New DataDynamics.ActiveReports.TextBox
      Me.txtCentroCostoDetDes1 = New DataDynamics.ActiveReports.TextBox
      Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
      Me.txtEstadoDes = New DataDynamics.ActiveReports.TextBox
      Me.Label1 = New DataDynamics.ActiveReports.Label
      CType(Me.lblCentroCostoCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCentroCostoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPlanCta, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPlanDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoCod1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoDes1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoDetCod1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoDetDes1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'PageHeader1
      '
      Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCentroCostoCod, Me.lblCentroCostoDes, Me.lblPlanCta, Me.lblPlanDes, Me.Label1})
      Me.PageHeader1.Height = 0.2291667!
      Me.PageHeader1.Name = "PageHeader1"
      '
      'lblCentroCostoCod
      '
      Me.lblCentroCostoCod.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCentroCostoCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoCod.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCentroCostoCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoCod.Border.RightColor = System.Drawing.Color.Black
      Me.lblCentroCostoCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCentroCostoCod.Border.TopColor = System.Drawing.Color.Black
      Me.lblCentroCostoCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoCod.Height = 0.1875!
      Me.lblCentroCostoCod.HyperLink = Nothing
      Me.lblCentroCostoCod.Left = 0.0!
      Me.lblCentroCostoCod.Name = "lblCentroCostoCod"
      Me.lblCentroCostoCod.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblCentroCostoCod.Text = "Código"
      Me.lblCentroCostoCod.Top = 0.0!
      Me.lblCentroCostoCod.Width = 0.875!
      '
      'lblCentroCostoDes
      '
      Me.lblCentroCostoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCentroCostoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCentroCostoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCentroCostoDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblCentroCostoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCentroCostoDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblCentroCostoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblCentroCostoDes.Height = 0.1875!
      Me.lblCentroCostoDes.HyperLink = Nothing
      Me.lblCentroCostoDes.Left = 0.875!
      Me.lblCentroCostoDes.Name = "lblCentroCostoDes"
      Me.lblCentroCostoDes.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblCentroCostoDes.Text = "Centro de Costo"
      Me.lblCentroCostoDes.Top = 0.0!
      Me.lblCentroCostoDes.Width = 2.375!
      '
      'lblPlanCta
      '
      Me.lblPlanCta.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPlanCta.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPlanCta.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPlanCta.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPlanCta.Border.RightColor = System.Drawing.Color.Black
      Me.lblPlanCta.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPlanCta.Border.TopColor = System.Drawing.Color.Black
      Me.lblPlanCta.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPlanCta.Height = 0.1875!
      Me.lblPlanCta.HyperLink = Nothing
      Me.lblPlanCta.Left = 3.25!
      Me.lblPlanCta.Name = "lblPlanCta"
      Me.lblPlanCta.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblPlanCta.Text = "Código"
      Me.lblPlanCta.Top = 0.0!
      Me.lblPlanCta.Width = 0.875!
      '
      'lblPlanDes
      '
      Me.lblPlanDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPlanDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPlanDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPlanDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPlanDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblPlanDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPlanDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblPlanDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPlanDes.Height = 0.1875!
      Me.lblPlanDes.HyperLink = Nothing
      Me.lblPlanDes.Left = 4.125!
      Me.lblPlanDes.Name = "lblPlanDes"
      Me.lblPlanDes.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.lblPlanDes.Text = "Actividad"
      Me.lblPlanDes.Top = 0.0!
      Me.lblPlanDes.Width = 2.5!
      '
      'Detail1
      '
      Me.Detail1.ColumnSpacing = 0.0!
      Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCentroCostoCod1, Me.txtCentroCostoDes1, Me.txtCentroCostoDetCod1, Me.txtCentroCostoDetDes1, Me.txtEstadoDes})
      Me.Detail1.Height = 0.1875!
      Me.Detail1.Name = "Detail1"
      '
      'txtCentroCostoCod1
      '
      Me.txtCentroCostoCod1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod1.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod1.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod1.DataField = "CentroCostoCod"
      Me.txtCentroCostoCod1.Height = 0.1875!
      Me.txtCentroCostoCod1.Left = 0.0!
      Me.txtCentroCostoCod1.Name = "txtCentroCostoCod1"
      Me.txtCentroCostoCod1.Style = "font-size: 8pt; "
      Me.txtCentroCostoCod1.Text = "txtCentroCostoCod1"
      Me.txtCentroCostoCod1.Top = 0.0!
      Me.txtCentroCostoCod1.Width = 0.875!
      '
      'txtCentroCostoDes1
      '
      Me.txtCentroCostoDes1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes1.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes1.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes1.DataField = "CentroCostoDes"
      Me.txtCentroCostoDes1.Height = 0.1875!
      Me.txtCentroCostoDes1.Left = 0.875!
      Me.txtCentroCostoDes1.Name = "txtCentroCostoDes1"
      Me.txtCentroCostoDes1.Style = "font-size: 8pt; "
      Me.txtCentroCostoDes1.Text = "txtCentroCostoDes1"
      Me.txtCentroCostoDes1.Top = 0.0!
      Me.txtCentroCostoDes1.Width = 2.375!
      '
      'txtCentroCostoDetCod1
      '
      Me.txtCentroCostoDetCod1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetCod1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetCod1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetCod1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetCod1.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetCod1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetCod1.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetCod1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetCod1.DataField = "CentroCostoDetCod"
      Me.txtCentroCostoDetCod1.Height = 0.1875!
      Me.txtCentroCostoDetCod1.Left = 3.25!
      Me.txtCentroCostoDetCod1.Name = "txtCentroCostoDetCod1"
      Me.txtCentroCostoDetCod1.Style = "font-size: 8pt; "
      Me.txtCentroCostoDetCod1.Text = "txtCentroCostoDetCod1"
      Me.txtCentroCostoDetCod1.Top = 0.0!
      Me.txtCentroCostoDetCod1.Width = 0.875!
      '
      'txtCentroCostoDetDes1
      '
      Me.txtCentroCostoDetDes1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetDes1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetDes1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetDes1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetDes1.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetDes1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetDes1.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetDes1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetDes1.DataField = "CentroCostoDetDes"
      Me.txtCentroCostoDetDes1.Height = 0.1875!
      Me.txtCentroCostoDetDes1.Left = 4.125!
      Me.txtCentroCostoDetDes1.Name = "txtCentroCostoDetDes1"
      Me.txtCentroCostoDetDes1.Style = "font-size: 8pt; "
      Me.txtCentroCostoDetDes1.Text = "txtCentroCostoDetDes1"
      Me.txtCentroCostoDetDes1.Top = 0.0!
      Me.txtCentroCostoDetDes1.Width = 2.5!
      '
      'PageFooter1
      '
      Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter1.Height = 0.3854167!
      Me.PageFooter1.Name = "PageFooter1"
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
      Me.Label3.Left = 6.875!
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
      Me.Line2.Left = 0.0!
      Me.Line2.LineWeight = 3.0!
      Me.Line2.Name = "Line2"
      Me.Line2.Top = 0.125!
      Me.Line2.Width = 7.5!
      Me.Line2.X1 = 0.0!
      Me.Line2.X2 = 7.5!
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
      'ReportHeader1
      '
      Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Line1})
      Me.ReportHeader1.Height = 0.7604167!
      Me.ReportHeader1.Name = "ReportHeader1"
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
      'ReportFooter1
      '
      Me.ReportFooter1.Height = 0.0!
      Me.ReportFooter1.Name = "ReportFooter1"
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
      Me.txtEstadoDes.Left = 6.625!
      Me.txtEstadoDes.Name = "txtEstadoDes"
      Me.txtEstadoDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtEstadoDes.Text = "EstadoDes"
      Me.txtEstadoDes.Top = 0.0!
      Me.txtEstadoDes.Width = 0.875!
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
      Me.Label1.Height = 0.1875!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 6.625!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label1.Text = "Estado"
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 0.875!
      '
      'rptCentroCostoDet
      '
      Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=sqloledb;Data Source=(local);Initial Catalog=CONDOBO;User ID=sa;Pas" & _
          "sword=sa;Current Language=us_english"
      OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
      Me.DataSource = OleDBDataSource1
      Me.PageSettings.PaperHeight = 11.69!
      Me.PageSettings.PaperWidth = 8.27!
      Me.PrintWidth = 7.5!
      Me.Sections.Add(Me.ReportHeader1)
      Me.Sections.Add(Me.PageHeader1)
      Me.Sections.Add(Me.Detail1)
      Me.Sections.Add(Me.PageFooter1)
      Me.Sections.Add(Me.ReportFooter1)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                  "l; font-size: 10pt; color: Black; ", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                  "lic; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
      CType(Me.lblCentroCostoCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCentroCostoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPlanCta, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPlanDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoCod1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoDes1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoDetCod1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoDetDes1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub
   Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
   Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
   Public WithEvents lblCompany As DataDynamics.ActiveReports.Label
   Public WithEvents lblTitle As DataDynamics.ActiveReports.Label
   Public WithEvents Line1 As DataDynamics.ActiveReports.Line
   Public WithEvents lblPlanCta As DataDynamics.ActiveReports.Label
   Public WithEvents lblPlanDes As DataDynamics.ActiveReports.Label
   Public WithEvents lblCentroCostoCod As DataDynamics.ActiveReports.Label
   Public WithEvents lblCentroCostoDes As DataDynamics.ActiveReports.Label
   Private WithEvents txtPageCount As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label3 As DataDynamics.ActiveReports.Label
   Private WithEvents Line2 As DataDynamics.ActiveReports.Line
   Public WithEvents lblDate As DataDynamics.ActiveReports.Label
   Public WithEvents lblTime As DataDynamics.ActiveReports.Label
   Public WithEvents lblLogin As DataDynamics.ActiveReports.Label
   Friend WithEvents txtCentroCostoCod1 As DataDynamics.ActiveReports.TextBox
   Friend WithEvents txtCentroCostoDes1 As DataDynamics.ActiveReports.TextBox
   Friend WithEvents txtCentroCostoDetCod1 As DataDynamics.ActiveReports.TextBox
   Friend WithEvents txtCentroCostoDetDes1 As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtEstadoDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents Label1 As DataDynamics.ActiveReports.Label
End Class 
