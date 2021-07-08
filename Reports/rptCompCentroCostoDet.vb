Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptCompCentroCostoDet 
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
   Private Label5 As DataDynamics.ActiveReports.Label
   Private Label6 As DataDynamics.ActiveReports.Label
   Private Label7 As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private Label12 As DataDynamics.ActiveReports.Label
   Private txtCentroCostoCod As DataDynamics.ActiveReports.TextBox
   Private txtCentroCostoDes As DataDynamics.ActiveReports.TextBox
   Private txtCentroCostoDetCod As DataDynamics.ActiveReports.TextBox
   Private txtCentroCostoDetDes As DataDynamics.ActiveReports.TextBox
   Private TextBox8 As DataDynamics.ActiveReports.TextBox
   Private TextBox7 As DataDynamics.ActiveReports.TextBox
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCompCentroCostoDet))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtCentroCostoCod = New DataDynamics.ActiveReports.TextBox
      Me.txtCentroCostoDes = New DataDynamics.ActiveReports.TextBox
      Me.txtCentroCostoDetCod = New DataDynamics.ActiveReports.TextBox
      Me.txtCentroCostoDetDes = New DataDynamics.ActiveReports.TextBox
      Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Line1 = New DataDynamics.ActiveReports.Line
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoDetCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCentroCostoDetDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
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
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCentroCostoCod, Me.txtCentroCostoDes, Me.txtCentroCostoDetCod, Me.txtCentroCostoDetDes, Me.TextBox8, Me.TextBox7})
      Me.Detail.Height = 0.1763889!
      Me.Detail.Name = "Detail"
      '
      'txtCentroCostoCod
      '
      Me.txtCentroCostoCod.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoCod.DataField = "CentroCostoCod"
      Me.txtCentroCostoCod.Height = 0.1875!
      Me.txtCentroCostoCod.Left = 0.0!
      Me.txtCentroCostoCod.Name = "txtCentroCostoCod"
      Me.txtCentroCostoCod.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCentroCostoCod.Text = "CentroCostoCod"
      Me.txtCentroCostoCod.Top = 0.0!
      Me.txtCentroCostoCod.Width = 0.8125!
      '
      'txtCentroCostoDes
      '
      Me.txtCentroCostoDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDes.DataField = "CentroCostoDes"
      Me.txtCentroCostoDes.Height = 0.1875!
      Me.txtCentroCostoDes.Left = 0.8125!
      Me.txtCentroCostoDes.Name = "txtCentroCostoDes"
      Me.txtCentroCostoDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCentroCostoDes.Text = "CentroCostoDes"
      Me.txtCentroCostoDes.Top = 0.0!
      Me.txtCentroCostoDes.Width = 2.0625!
      '
      'txtCentroCostoDetCod
      '
      Me.txtCentroCostoDetCod.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetCod.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetCod.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetCod.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetCod.DataField = "CentroCostoDetCod"
      Me.txtCentroCostoDetCod.Height = 0.1875!
      Me.txtCentroCostoDetCod.Left = 2.875!
      Me.txtCentroCostoDetCod.Name = "txtCentroCostoDetCod"
      Me.txtCentroCostoDetCod.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCentroCostoDetCod.Text = "CentroCostoDetCod"
      Me.txtCentroCostoDetCod.Top = 0.0!
      Me.txtCentroCostoDetCod.Width = 0.8125!
      '
      'txtCentroCostoDetDes
      '
      Me.txtCentroCostoDetDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtCentroCostoDetDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCentroCostoDetDes.DataField = "CentroCostoDetDes"
      Me.txtCentroCostoDetDes.Height = 0.1875!
      Me.txtCentroCostoDetDes.Left = 3.6875!
      Me.txtCentroCostoDetDes.Name = "txtCentroCostoDetDes"
      Me.txtCentroCostoDetDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtCentroCostoDetDes.Text = "CentroCostoDetDes"
      Me.txtCentroCostoDetDes.Top = 0.0!
      Me.txtCentroCostoDetDes.Width = 2.0625!
      '
      'TextBox8
      '
      Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.DataField = "Haber"
      Me.TextBox8.Height = 0.1875!
      Me.TextBox8.Left = 6.625!
      Me.TextBox8.MultiLine = False
      Me.TextBox8.Name = "TextBox8"
      Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
      Me.TextBox8.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.TextBox8.Text = "Haber"
      Me.TextBox8.Top = 0.0!
      Me.TextBox8.Width = 0.875!
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
      Me.TextBox7.DataField = "Debe"
      Me.TextBox7.Height = 0.1875!
      Me.TextBox7.Left = 5.75!
      Me.TextBox7.MultiLine = False
      Me.TextBox7.Name = "TextBox7"
      Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
      Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: top; "
      Me.TextBox7.Text = "Debe"
      Me.TextBox7.Top = 0.0!
      Me.TextBox7.Width = 0.875!
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
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label11, Me.Label12})
      Me.PageHeader.Height = 0.2388889!
      Me.PageHeader.Name = "PageHeader"
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
      Me.Label4.Left = 0.0!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label4.Text = "Cuenta"
      Me.Label4.Top = 0.0!
      Me.Label4.Width = 0.8125!
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
      Me.Label5.Height = 0.1875!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 0.8125!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label5.Text = "Descripción Cuenta"
      Me.Label5.Top = 0.0!
      Me.Label5.Width = 2.0625!
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
      Me.Label6.Left = 2.875!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label6.Text = "Código A.A."
      Me.Label6.Top = 0.0!
      Me.Label6.Width = 0.8229167!
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
      Me.Label7.Left = 3.697917!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; font-weight: bold; background-color: Silver; font-size: 8pt; ver" & _
          "tical-align: middle; "
      Me.Label7.Text = "Descripción A.A."
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 2.052083!
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
      Me.Label11.Left = 5.75!
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
      Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label12.Border.TopColor = System.Drawing.Color.Black
      Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label12.Height = 0.1875!
      Me.Label12.HyperLink = Nothing
      Me.Label12.Left = 6.625!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; background-color: Silver; " & _
          "font-size: 8pt; vertical-align: middle; "
      Me.Label12.Text = "Haber"
      Me.Label12.Top = 0.0!
      Me.Label12.Width = 0.875!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label3, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
      Me.PageFooter.Height = 0.3534722!
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
      'rptCompCentroCostoDet
      '
      Me.MasterReport = False
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
      CType(Me.txtCentroCostoCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoDetCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCentroCostoDetDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

End Class