<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptSucursal 
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptSucursal))
      Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
      Me.lblCentroCostoCod = New DataDynamics.ActiveReports.Label
      Me.lblCentroCostoDes = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Detail1 = New DataDynamics.ActiveReports.Detail
      Me.txtSucursalCod1 = New DataDynamics.ActiveReports.TextBox
      Me.txtSucursalDes1 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
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
      CType(Me.lblCentroCostoCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCentroCostoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSucursalCod1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSucursalDes1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'PageHeader1
      '
      Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCentroCostoCod, Me.lblCentroCostoDes, Me.Label6, Me.Label8, Me.Label9})
      Me.PageHeader1.Height = 0.25!
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
      Me.lblCentroCostoDes.Text = "Sucursal"
      Me.lblCentroCostoDes.Top = 0.0!
      Me.lblCentroCostoDes.Width = 3.5!
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
      Me.Label6.Height = 0.1875!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 4.375!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Dirección"
      Me.Label6.Top = 0.0!
      Me.Label6.Width = 1.5!
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
      Me.Label8.Left = 5.875!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label8.Text = "Ciudad"
      Me.Label8.Top = 0.0!
      Me.Label8.Width = 0.9375!
      '
      'Label9
      '
      Me.Label9.Border.BottomColor = System.Drawing.Color.Black
      Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.LeftColor = System.Drawing.Color.Black
      Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.RightColor = System.Drawing.Color.Black
      Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.TopColor = System.Drawing.Color.Black
      Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Height = 0.1875!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 6.8125!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label9.Text = "Telefono"
      Me.Label9.Top = 0.0!
      Me.Label9.Width = 0.6875!
      '
      'Detail1
      '
      Me.Detail1.ColumnSpacing = 0.0!
      Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSucursalCod1, Me.txtSucursalDes1, Me.TextBox3, Me.TextBox4, Me.TextBox5})
      Me.Detail1.Height = 0.1875!
      Me.Detail1.Name = "Detail1"
      '
      'txtSucursalCod1
      '
      Me.txtSucursalCod1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSucursalCod1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalCod1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSucursalCod1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalCod1.Border.RightColor = System.Drawing.Color.Black
      Me.txtSucursalCod1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalCod1.Border.TopColor = System.Drawing.Color.Black
      Me.txtSucursalCod1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalCod1.DataField = "SucursalCod"
      Me.txtSucursalCod1.Height = 0.1875!
      Me.txtSucursalCod1.Left = 0.0!
      Me.txtSucursalCod1.Name = "txtSucursalCod1"
      Me.txtSucursalCod1.Style = "font-size: 8pt; "
      Me.txtSucursalCod1.Text = "txtSucursalCod1"
      Me.txtSucursalCod1.Top = 0.0!
      Me.txtSucursalCod1.Width = 0.875!
      '
      'txtSucursalDes1
      '
      Me.txtSucursalDes1.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSucursalDes1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalDes1.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSucursalDes1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalDes1.Border.RightColor = System.Drawing.Color.Black
      Me.txtSucursalDes1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalDes1.Border.TopColor = System.Drawing.Color.Black
      Me.txtSucursalDes1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSucursalDes1.DataField = "SucursalDes"
      Me.txtSucursalDes1.Height = 0.1875!
      Me.txtSucursalDes1.Left = 0.875!
      Me.txtSucursalDes1.Name = "txtSucursalDes1"
      Me.txtSucursalDes1.Style = "font-size: 8pt; "
      Me.txtSucursalDes1.Text = "txtSucursalDes1"
      Me.txtSucursalDes1.Top = 0.0!
      Me.txtSucursalDes1.Width = 3.5!
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
      Me.TextBox3.DataField = "Direccion"
      Me.TextBox3.Height = 0.1875!
      Me.TextBox3.Left = 4.375!
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox3.Text = "Direccion"
      Me.TextBox3.Top = 0.0!
      Me.TextBox3.Width = 1.5!
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
      Me.TextBox4.DataField = "CiudadDes"
      Me.TextBox4.Height = 0.1875!
      Me.TextBox4.Left = 5.875!
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox4.Text = "CiudadDes"
      Me.TextBox4.Top = 0.0!
      Me.TextBox4.Width = 0.9375!
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
      Me.TextBox5.DataField = "Telefono"
      Me.TextBox5.Height = 0.1875!
      Me.TextBox5.Left = 6.8125!
      Me.TextBox5.Name = "TextBox5"
      Me.TextBox5.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox5.Text = "Telefono"
      Me.TextBox5.Top = 0.0!
      Me.TextBox5.Width = 0.6875!
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
      Me.ReportHeader1.Height = 0.6979167!
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
      'rptSucursal
      '
      Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
            "Catalog=CONDOBO;Data Source=JQuintanilla"
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
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSucursalCod1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSucursalDes1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub
   Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
   Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
   Public WithEvents lblCompany As DataDynamics.ActiveReports.Label
   Public WithEvents lblTitle As DataDynamics.ActiveReports.Label
   Private WithEvents Line1 As DataDynamics.ActiveReports.Line
   Public WithEvents lblCentroCostoCod As DataDynamics.ActiveReports.Label
   Public WithEvents lblCentroCostoDes As DataDynamics.ActiveReports.Label
   Friend WithEvents txtSucursalCod1 As DataDynamics.ActiveReports.TextBox
   Friend WithEvents txtSucursalDes1 As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtPageCount As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label3 As DataDynamics.ActiveReports.Label
   Private WithEvents Line2 As DataDynamics.ActiveReports.Line
   Public WithEvents lblDate As DataDynamics.ActiveReports.Label
   Public WithEvents lblTime As DataDynamics.ActiveReports.Label
   Public WithEvents lblLogin As DataDynamics.ActiveReports.Label
   Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label6 As DataDynamics.ActiveReports.Label
   Private WithEvents Label8 As DataDynamics.ActiveReports.Label
   Private WithEvents Label9 As DataDynamics.ActiveReports.Label
End Class 
