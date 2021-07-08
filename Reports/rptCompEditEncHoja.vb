Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class rptCompEditEncHoja
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
   Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
   Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
   Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
   Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
   Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
   Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource
   Private picAnulado As DataDynamics.ActiveReports.Picture
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Label As DataDynamics.ActiveReports.Label
   Private Label1 As DataDynamics.ActiveReports.Label
   Private Shape2 As DataDynamics.ActiveReports.Shape
   Private TextBox6 As DataDynamics.ActiveReports.TextBox
   Private Shape1 As DataDynamics.ActiveReports.Shape
   Private TextBox1 As DataDynamics.ActiveReports.TextBox
   Private TextBox2 As DataDynamics.ActiveReports.TextBox
   Private txtMonedaDes As DataDynamics.ActiveReports.TextBox
   Public lblEntregadoA As DataDynamics.ActiveReports.Label
   Private TextBox4 As DataDynamics.ActiveReports.TextBox
   Public lblPorConcepto As DataDynamics.ActiveReports.Label
   Private Label2 As DataDynamics.ActiveReports.Label
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Label4 As DataDynamics.ActiveReports.Label
   Private txtCompNro As DataDynamics.ActiveReports.TextBox
   Private TextBox7 As DataDynamics.ActiveReports.TextBox
   Private Label5 As DataDynamics.ActiveReports.Label
   Private Label6 As DataDynamics.ActiveReports.Label
   Private txtEstadoId As DataDynamics.ActiveReports.TextBox
   Private Shape3 As DataDynamics.ActiveReports.Shape
   Private lblEqui As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private Label9 As DataDynamics.ActiveReports.Label
   Private Label10 As DataDynamics.ActiveReports.Label
   Private Label7 As DataDynamics.ActiveReports.Label
   Private txtPlanCta As DataDynamics.ActiveReports.TextBox
   Private txtPlanDesDebe As DataDynamics.ActiveReports.TextBox
   Private txtDebe As DataDynamics.ActiveReports.TextBox
   Private txtHaber As DataDynamics.ActiveReports.TextBox
   Private txtEqui As DataDynamics.ActiveReports.TextBox
   Private txtPlanDesHaber As DataDynamics.ActiveReports.TextBox
   Private txtLiteral As DataDynamics.ActiveReports.TextBox
   Private txtDebeTot As DataDynamics.ActiveReports.TextBox
   Private txtHaberTot As DataDynamics.ActiveReports.TextBox
   Private txtEquiTot As DataDynamics.ActiveReports.TextBox
   Private txtGlosa As DataDynamics.ActiveReports.TextBox
   Private lblGlosa As DataDynamics.ActiveReports.Label
   Private Shape4 As DataDynamics.ActiveReports.Shape
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label13 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblTime As DataDynamics.ActiveReports.Label
   Public lblLogin As DataDynamics.ActiveReports.Label
   Public lblCompPie As DataDynamics.ActiveReports.Label
   Public WithEvents lblDate As DataDynamics.ActiveReports.Label
   Public WithEvents srptCompEEFF As DataDynamics.ActiveReports.SubReport
   Public WithEvents txtFirma As DataDynamics.ActiveReports.TextBox

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCompEditEncHoja))
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtPlanCta = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanDesDebe = New DataDynamics.ActiveReports.TextBox
      Me.txtDebe = New DataDynamics.ActiveReports.TextBox
      Me.txtHaber = New DataDynamics.ActiveReports.TextBox
      Me.txtEqui = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanDesHaber = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.picAnulado = New DataDynamics.ActiveReports.Picture
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Shape2 = New DataDynamics.ActiveReports.Shape
      Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
      Me.Shape1 = New DataDynamics.ActiveReports.Shape
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
      Me.txtMonedaDes = New DataDynamics.ActiveReports.TextBox
      Me.lblEntregadoA = New DataDynamics.ActiveReports.Label
      Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
      Me.lblPorConcepto = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.txtCompNro = New DataDynamics.ActiveReports.TextBox
      Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.txtEstadoId = New DataDynamics.ActiveReports.TextBox
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.txtFirma = New DataDynamics.ActiveReports.TextBox
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      Me.lblCompPie = New DataDynamics.ActiveReports.Label
      Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
      Me.Shape3 = New DataDynamics.ActiveReports.Shape
      Me.lblEqui = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.txtDebeTot = New DataDynamics.ActiveReports.TextBox
      Me.txtHaberTot = New DataDynamics.ActiveReports.TextBox
      Me.txtEquiTot = New DataDynamics.ActiveReports.TextBox
      Me.txtGlosa = New DataDynamics.ActiveReports.TextBox
      Me.lblGlosa = New DataDynamics.ActiveReports.Label
      Me.Shape4 = New DataDynamics.ActiveReports.Shape
      Me.srptCompEEFF = New DataDynamics.ActiveReports.SubReport
      CType(Me.txtPlanCta, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanDesDebe, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebe, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtHaber, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanDesHaber, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblEntregadoA, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPorConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCompNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompPie, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebeTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtHaberTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEquiTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPlanCta, Me.txtPlanDesDebe, Me.txtDebe, Me.txtHaber, Me.txtEqui, Me.txtPlanDesHaber})
      Me.Detail.Height = 0.2395833!
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
      Me.txtPlanCta.Text = "PlanCta"
      Me.txtPlanCta.Top = 0.0!
      Me.txtPlanCta.Width = 0.75!
      '
      'txtPlanDesDebe
      '
      Me.txtPlanDesDebe.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPlanDesDebe.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDesDebe.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPlanDesDebe.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDesDebe.Border.RightColor = System.Drawing.Color.Black
      Me.txtPlanDesDebe.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDesDebe.Border.TopColor = System.Drawing.Color.Black
      Me.txtPlanDesDebe.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDesDebe.Height = 0.1875!
      Me.txtPlanDesDebe.Left = 0.75!
      Me.txtPlanDesDebe.Name = "txtPlanDesDebe"
      Me.txtPlanDesDebe.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPlanDesDebe.Text = Nothing
      Me.txtPlanDesDebe.Top = 0.0!
      Me.txtPlanDesDebe.Width = 4.125!
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
      Me.txtDebe.Height = 0.1875!
      Me.txtDebe.Left = 4.875!
      Me.txtDebe.Name = "txtDebe"
      Me.txtDebe.OutputFormat = resources.GetString("txtDebe.OutputFormat")
      Me.txtDebe.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtDebe.Text = Nothing
      Me.txtDebe.Top = 0.0!
      Me.txtDebe.Width = 0.875!
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
      Me.txtHaber.Height = 0.1875!
      Me.txtHaber.Left = 5.75!
      Me.txtHaber.Name = "txtHaber"
      Me.txtHaber.OutputFormat = resources.GetString("txtHaber.OutputFormat")
      Me.txtHaber.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtHaber.Text = Nothing
      Me.txtHaber.Top = 0.0!
      Me.txtHaber.Width = 0.875!
      '
      'txtEqui
      '
      Me.txtEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEqui.Border.RightColor = System.Drawing.Color.Black
      Me.txtEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEqui.Border.TopColor = System.Drawing.Color.Black
      Me.txtEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEqui.Height = 0.1875!
      Me.txtEqui.Left = 6.625!
      Me.txtEqui.Name = "txtEqui"
      Me.txtEqui.OutputFormat = resources.GetString("txtEqui.OutputFormat")
      Me.txtEqui.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtEqui.Text = Nothing
      Me.txtEqui.Top = 0.0!
      Me.txtEqui.Width = 0.875!
      '
      'txtPlanDesHaber
      '
      Me.txtPlanDesHaber.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPlanDesHaber.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDesHaber.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPlanDesHaber.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDesHaber.Border.RightColor = System.Drawing.Color.Black
      Me.txtPlanDesHaber.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDesHaber.Border.TopColor = System.Drawing.Color.Black
      Me.txtPlanDesHaber.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanDesHaber.Height = 0.1875!
      Me.txtPlanDesHaber.Left = 1.375!
      Me.txtPlanDesHaber.Name = "txtPlanDesHaber"
      Me.txtPlanDesHaber.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtPlanDesHaber.Text = Nothing
      Me.txtPlanDesHaber.Top = 0.0!
      Me.txtPlanDesHaber.Width = 3.5!
      '
      'ReportHeader
      '
      Me.ReportHeader.Height = 0.0!
      Me.ReportHeader.Name = "ReportHeader"
      '
      'picAnulado
      '
      Me.picAnulado.Border.BottomColor = System.Drawing.Color.Black
      Me.picAnulado.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picAnulado.Border.LeftColor = System.Drawing.Color.Black
      Me.picAnulado.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picAnulado.Border.RightColor = System.Drawing.Color.Black
      Me.picAnulado.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picAnulado.Border.TopColor = System.Drawing.Color.Black
      Me.picAnulado.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.picAnulado.Height = 0.625!
      Me.picAnulado.Image = CType(resources.GetObject("picAnulado.Image"), System.Drawing.Image)
      Me.picAnulado.ImageData = CType(resources.GetObject("picAnulado.ImageData"), System.IO.Stream)
      Me.picAnulado.Left = 0.125!
      Me.picAnulado.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.picAnulado.LineWeight = 0.0!
      Me.picAnulado.Name = "picAnulado"
      Me.picAnulado.SizeMode = DataDynamics.ActiveReports.SizeModes.Stretch
      Me.picAnulado.Top = 0.8125!
      Me.picAnulado.Visible = False
      Me.picAnulado.Width = 5.8125!
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
      Me.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.RightColor = System.Drawing.Color.Black
      Me.lblTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.TopColor = System.Drawing.Color.Black
      Me.lblTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Height = 0.25!
      Me.lblTitle.HyperLink = Nothing
      Me.lblTitle.Left = 2.125!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.lblTitle.Text = ""
      Me.lblTitle.Top = 0.3125!
      Me.lblTitle.Width = 3.25!
      '
      'Label
      '
      Me.Label.Border.BottomColor = System.Drawing.Color.Black
      Me.Label.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.LeftColor = System.Drawing.Color.Black
      Me.Label.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.RightColor = System.Drawing.Color.Black
      Me.Label.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Border.TopColor = System.Drawing.Color.Black
      Me.Label.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label.Height = 0.25!
      Me.Label.HyperLink = Nothing
      Me.Label.Left = 1.375!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 16pt; vertical" & _
          "-align: middle; "
      Me.Label.Text = "<<<<<"
      Me.Label.Top = 0.3125!
      Me.Label.Width = 0.75!
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
      Me.Label1.Height = 0.25!
      Me.Label1.HyperLink = Nothing
      Me.Label1.Left = 5.375!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 16pt; vertical" & _
          "-align: middle; "
      Me.Label1.Text = ">>>>>"
      Me.Label1.Top = 0.3125!
      Me.Label1.Width = 0.75!
      '
      'Shape2
      '
      Me.Shape2.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape2.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape2.Border.RightColor = System.Drawing.Color.Black
      Me.Shape2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape2.Border.TopColor = System.Drawing.Color.Black
      Me.Shape2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape2.Height = 0.8125!
      Me.Shape2.Left = 6.125!
      Me.Shape2.LineWeight = 2.0!
      Me.Shape2.Name = "Shape2"
      Me.Shape2.RoundingRadius = 9.999999!
      Me.Shape2.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape2.Top = 0.6875!
      Me.Shape2.Width = 1.364583!
      '
      'TextBox6
      '
      Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.DataField = "Fecha"
      Me.TextBox6.Height = 0.1875!
      Me.TextBox6.Left = 6.6875!
      Me.TextBox6.Name = "TextBox6"
      Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
      Me.TextBox6.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; vertical-align: middle; "
      Me.TextBox6.Text = "Fecha"
      Me.TextBox6.Top = 1.0!
      Me.TextBox6.Width = 0.75!
      '
      'Shape1
      '
      Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape1.Border.RightColor = System.Drawing.Color.Black
      Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape1.Border.TopColor = System.Drawing.Color.Black
      Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape1.Height = 0.8125!
      Me.Shape1.Left = 0.0!
      Me.Shape1.LineWeight = 2.0!
      Me.Shape1.Name = "Shape1"
      Me.Shape1.RoundingRadius = 9.999999!
      Me.Shape1.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape1.Top = 0.6875!
      Me.Shape1.Width = 6.0625!
      '
      'TextBox1
      '
      Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox1.DataField = "EntregadoA"
      Me.TextBox1.Height = 0.1875!
      Me.TextBox1.Left = 1.25!
      Me.TextBox1.MultiLine = False
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox1.Text = "EntregadoA"
      Me.TextBox1.Top = 0.75!
      Me.TextBox1.Width = 4.75!
      '
      'TextBox2
      '
      Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.DataField = "PorConcepto"
      Me.TextBox2.Height = 0.1875!
      Me.TextBox2.Left = 1.25!
      Me.TextBox2.MultiLine = False
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox2.Text = "PorConcepto"
      Me.TextBox2.Top = 1.0!
      Me.TextBox2.Width = 4.749999!
      '
      'txtMonedaDes
      '
      Me.txtMonedaDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtMonedaDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtMonedaDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonedaDes.DataField = "MonedaDes"
      Me.txtMonedaDes.Height = 0.1875!
      Me.txtMonedaDes.Left = 1.25!
      Me.txtMonedaDes.MultiLine = False
      Me.txtMonedaDes.Name = "txtMonedaDes"
      Me.txtMonedaDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtMonedaDes.Text = "MonedaDes"
      Me.txtMonedaDes.Top = 1.25!
      Me.txtMonedaDes.Width = 0.625!
      '
      'lblEntregadoA
      '
      Me.lblEntregadoA.Border.BottomColor = System.Drawing.Color.Black
      Me.lblEntregadoA.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEntregadoA.Border.LeftColor = System.Drawing.Color.Black
      Me.lblEntregadoA.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEntregadoA.Border.RightColor = System.Drawing.Color.Black
      Me.lblEntregadoA.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEntregadoA.Border.TopColor = System.Drawing.Color.Black
      Me.lblEntregadoA.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEntregadoA.Height = 0.1875!
      Me.lblEntregadoA.HyperLink = Nothing
      Me.lblEntregadoA.Left = 0.0625!
      Me.lblEntregadoA.Name = "lblEntregadoA"
      Me.lblEntregadoA.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblEntregadoA.Text = "Entregado A :"
      Me.lblEntregadoA.Top = 0.75!
      Me.lblEntregadoA.Width = 1.125!
      '
      'TextBox4
      '
      Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox4.DataField = "EstadoDes"
      Me.TextBox4.Height = 0.1875!
      Me.TextBox4.Left = 5.375!
      Me.TextBox4.MultiLine = False
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox4.Text = "EstadoDes"
      Me.TextBox4.Top = 1.25!
      Me.TextBox4.Width = 0.625!
      '
      'lblPorConcepto
      '
      Me.lblPorConcepto.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPorConcepto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPorConcepto.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPorConcepto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPorConcepto.Border.RightColor = System.Drawing.Color.Black
      Me.lblPorConcepto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPorConcepto.Border.TopColor = System.Drawing.Color.Black
      Me.lblPorConcepto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblPorConcepto.Height = 0.1875!
      Me.lblPorConcepto.HyperLink = Nothing
      Me.lblPorConcepto.Left = 0.0625!
      Me.lblPorConcepto.Name = "lblPorConcepto"
      Me.lblPorConcepto.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblPorConcepto.Text = "Por concepto de :"
      Me.lblPorConcepto.Top = 1.0!
      Me.lblPorConcepto.Width = 1.125!
      '
      'Label2
      '
      Me.Label2.Border.BottomColor = System.Drawing.Color.Black
      Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.LeftColor = System.Drawing.Color.Black
      Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.RightColor = System.Drawing.Color.Black
      Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Border.TopColor = System.Drawing.Color.Black
      Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label2.Height = 0.1875!
      Me.Label2.HyperLink = Nothing
      Me.Label2.Left = 0.0625!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label2.Text = "Moneda :"
      Me.Label2.Top = 1.25!
      Me.Label2.Width = 1.125!
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
      Me.Label3.Height = 0.1875!
      Me.Label3.HyperLink = Nothing
      Me.Label3.Left = 4.8125!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label3.Text = "Estado :"
      Me.Label3.Top = 1.25!
      Me.Label3.Width = 0.5!
      '
      'Label4
      '
      Me.Label4.Border.BottomColor = System.Drawing.Color.Black
      Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.LeftColor = System.Drawing.Color.Black
      Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.RightColor = System.Drawing.Color.Black
      Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Border.TopColor = System.Drawing.Color.Black
      Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label4.Height = 0.1875!
      Me.Label4.HyperLink = Nothing
      Me.Label4.Left = 6.1875!
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label4.Text = "Nro. "
      Me.Label4.Top = 0.75!
      Me.Label4.Width = 0.4375!
      '
      'txtCompNro
      '
      Me.txtCompNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCompNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.DataField = "CompNro"
      Me.txtCompNro.Height = 0.1875!
      Me.txtCompNro.Left = 6.6875!
      Me.txtCompNro.Name = "txtCompNro"
      Me.txtCompNro.Style = "text-align: left; font-weight: bold; font-size: 12pt; vertical-align: middle; "
      Me.txtCompNro.Text = "CompNro"
      Me.txtCompNro.Top = 0.75!
      Me.txtCompNro.Width = 0.75!
      '
      'TextBox7
      '
      Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.DataField = "TipoCambio"
      Me.TextBox7.Height = 0.1875!
      Me.TextBox7.Left = 6.6875!
      Me.TextBox7.Name = "TextBox7"
      Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
      Me.TextBox7.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; "
      Me.TextBox7.Text = "TipoCambio"
      Me.TextBox7.Top = 1.25!
      Me.TextBox7.Width = 0.75!
      '
      'Label5
      '
      Me.Label5.Border.BottomColor = System.Drawing.Color.Black
      Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.LeftColor = System.Drawing.Color.Black
      Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.RightColor = System.Drawing.Color.Black
      Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Border.TopColor = System.Drawing.Color.Black
      Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Height = 0.1875!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 6.1875!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; "
      Me.Label5.Text = "T.C."
      Me.Label5.Top = 1.25!
      Me.Label5.Width = 0.4375!
      '
      'Label6
      '
      Me.Label6.Border.BottomColor = System.Drawing.Color.Black
      Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.LeftColor = System.Drawing.Color.Black
      Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.RightColor = System.Drawing.Color.Black
      Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Border.TopColor = System.Drawing.Color.Black
      Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Height = 0.1875!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 6.1875!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label6.Text = "Fecha"
      Me.Label6.Top = 1.0!
      Me.Label6.Width = 0.4375!
      '
      'txtEstadoId
      '
      Me.txtEstadoId.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEstadoId.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoId.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEstadoId.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoId.Border.RightColor = System.Drawing.Color.Black
      Me.txtEstadoId.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoId.Border.TopColor = System.Drawing.Color.Black
      Me.txtEstadoId.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoId.DataField = "EstadoId"
      Me.txtEstadoId.Height = 0.1875!
      Me.txtEstadoId.Left = 6.6875!
      Me.txtEstadoId.Name = "txtEstadoId"
      Me.txtEstadoId.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtEstadoId.Text = "EstadoId"
      Me.txtEstadoId.Top = 0.375!
      Me.txtEstadoId.Visible = False
      Me.txtEstadoId.Width = 0.5!
      '
      'ReportFooter
      '
      Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtFirma})
      Me.ReportFooter.Height = 0.3958333!
      Me.ReportFooter.Name = "ReportFooter"
      Me.ReportFooter.PrintAtBottom = True
      '
      'txtFirma
      '
      Me.txtFirma.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFirma.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFirma.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFirma.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFirma.Border.RightColor = System.Drawing.Color.Black
      Me.txtFirma.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFirma.Border.TopColor = System.Drawing.Color.Black
      Me.txtFirma.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFirma.Height = 0.375!
      Me.txtFirma.Left = 0.0!
      Me.txtFirma.Name = "txtFirma"
      Me.txtFirma.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtFirma.Text = "VoBo"
      Me.txtFirma.Top = 0.0!
      Me.txtFirma.Width = 7.5!
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.picAnulado, Me.lblTitle, Me.Label, Me.Label1, Me.Shape2, Me.TextBox6, Me.Shape1, Me.TextBox1, Me.TextBox2, Me.txtMonedaDes, Me.lblEntregadoA, Me.TextBox4, Me.lblPorConcepto, Me.Label2, Me.Label3, Me.Label4, Me.txtCompNro, Me.TextBox7, Me.Label5, Me.Label6, Me.txtEstadoId, Me.Label10, Me.lblEqui, Me.Label11, Me.Label9, Me.Shape3, Me.Label7})
      Me.PageHeader.Height = 1.854167!
      Me.PageHeader.Name = "PageHeader"
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label13, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin, Me.lblCompPie})
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
      'Label13
      '
      Me.Label13.Border.BottomColor = System.Drawing.Color.Black
      Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.LeftColor = System.Drawing.Color.Black
      Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.RightColor = System.Drawing.Color.Black
      Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Border.TopColor = System.Drawing.Color.Black
      Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label13.Height = 0.2!
      Me.Label13.HyperLink = Nothing
      Me.Label13.Left = 6.885408!
      Me.Label13.Name = "Label13"
      Me.Label13.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.Label13.Text = "de"
      Me.Label13.Top = 0.1875!
      Me.Label13.Width = 0.1875!
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
      Me.lblDate.Visible = False
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
      Me.lblLogin.Width = 1.375!
      '
      'lblCompPie
      '
      Me.lblCompPie.Border.BottomColor = System.Drawing.Color.Black
      Me.lblCompPie.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompPie.Border.LeftColor = System.Drawing.Color.Black
      Me.lblCompPie.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompPie.Border.RightColor = System.Drawing.Color.Black
      Me.lblCompPie.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompPie.Border.TopColor = System.Drawing.Color.Black
      Me.lblCompPie.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblCompPie.Height = 0.1875!
      Me.lblCompPie.HyperLink = Nothing
      Me.lblCompPie.Left = 5.0625!
      Me.lblCompPie.Name = "lblCompPie"
      Me.lblCompPie.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.lblCompPie.Text = ""
      Me.lblCompPie.Top = 0.1875!
      Me.lblCompPie.Width = 1.3125!
      '
      'GroupHeader1
      '
      Me.GroupHeader1.Height = 0.01041667!
      Me.GroupHeader1.Name = "GroupHeader1"
      '
      'Shape3
      '
      Me.Shape3.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape3.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape3.Border.RightColor = System.Drawing.Color.Black
      Me.Shape3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape3.Border.TopColor = System.Drawing.Color.Black
      Me.Shape3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape3.Height = 0.1979165!
      Me.Shape3.Left = 0.0!
      Me.Shape3.LineWeight = 2.0!
      Me.Shape3.Name = "Shape3"
      Me.Shape3.RoundingRadius = 9.999999!
      Me.Shape3.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape3.Top = 1.625!
      Me.Shape3.Width = 7.5!
      '
      'lblEqui
      '
      Me.lblEqui.Border.BottomColor = System.Drawing.Color.Black
      Me.lblEqui.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEqui.Border.LeftColor = System.Drawing.Color.Black
      Me.lblEqui.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEqui.Border.RightColor = System.Drawing.Color.Black
      Me.lblEqui.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEqui.Border.TopColor = System.Drawing.Color.Black
      Me.lblEqui.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblEqui.Height = 0.1875!
      Me.lblEqui.HyperLink = Nothing
      Me.lblEqui.Left = 6.625!
      Me.lblEqui.Name = "lblEqui"
      Me.lblEqui.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; "
      Me.lblEqui.Text = "EQUIVAL."
      Me.lblEqui.Top = 1.625!
      Me.lblEqui.Width = 0.875!
      '
      'Label11
      '
      Me.Label11.Border.BottomColor = System.Drawing.Color.Black
      Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.LeftColor = System.Drawing.Color.Black
      Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.RightColor = System.Drawing.Color.Black
      Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label11.Border.TopColor = System.Drawing.Color.Black
      Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Height = 0.1875!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 5.75!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; "
      Me.Label11.Text = "HABER"
      Me.Label11.Top = 1.625!
      Me.Label11.Width = 0.875!
      '
      'Label9
      '
      Me.Label9.Border.BottomColor = System.Drawing.Color.Black
      Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.LeftColor = System.Drawing.Color.Black
      Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Border.RightColor = System.Drawing.Color.Black
      Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.TopColor = System.Drawing.Color.Black
      Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label9.Height = 0.1875!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 4.875!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; "
      Me.Label9.Text = "DEBE"
      Me.Label9.Top = 1.625!
      Me.Label9.Width = 0.875!
      '
      'Label10
      '
      Me.Label10.Border.BottomColor = System.Drawing.Color.Black
      Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.LeftColor = System.Drawing.Color.Black
      Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.RightColor = System.Drawing.Color.Black
      Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label10.Border.TopColor = System.Drawing.Color.Black
      Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Height = 0.1875!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 0.75!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; "
      Me.Label10.Text = "DESCRIPCIÓN / GLOSA"
      Me.Label10.Top = 1.625!
      Me.Label10.Width = 4.125!
      '
      'Label7
      '
      Me.Label7.Border.BottomColor = System.Drawing.Color.Black
      Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.LeftColor = System.Drawing.Color.Black
      Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Border.RightColor = System.Drawing.Color.Black
      Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.TopColor = System.Drawing.Color.Black
      Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label7.Height = 0.1875!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 0.0!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9pt; "
      Me.Label7.Text = "CUENTA"
      Me.Label7.Top = 1.625!
      Me.Label7.Width = 0.75!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtLiteral, Me.txtDebeTot, Me.txtHaberTot, Me.txtEquiTot, Me.txtGlosa, Me.lblGlosa, Me.Shape4, Me.srptCompEEFF})
      Me.GroupFooter1.Height = 1.25!
      Me.GroupFooter1.Name = "GroupFooter1"
      '
      'txtLiteral
      '
      Me.txtLiteral.Border.BottomColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.LeftColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.RightColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.TopColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Height = 0.3125!
      Me.txtLiteral.Left = 0.0!
      Me.txtLiteral.Name = "txtLiteral"
      Me.txtLiteral.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtLiteral.Text = Nothing
      Me.txtLiteral.Top = 0.0!
      Me.txtLiteral.Width = 4.875!
      '
      'txtDebeTot
      '
      Me.txtDebeTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDebeTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDebeTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDebeTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtDebeTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtDebeTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDebeTot.Height = 0.3125!
      Me.txtDebeTot.Left = 4.875!
      Me.txtDebeTot.Name = "txtDebeTot"
      Me.txtDebeTot.OutputFormat = resources.GetString("txtDebeTot.OutputFormat")
      Me.txtDebeTot.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtDebeTot.Text = Nothing
      Me.txtDebeTot.Top = 0.0!
      Me.txtDebeTot.Width = 0.875!
      '
      'txtHaberTot
      '
      Me.txtHaberTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtHaberTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtHaberTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtHaberTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtHaberTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtHaberTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtHaberTot.Height = 0.3125!
      Me.txtHaberTot.Left = 5.75!
      Me.txtHaberTot.Name = "txtHaberTot"
      Me.txtHaberTot.OutputFormat = resources.GetString("txtHaberTot.OutputFormat")
      Me.txtHaberTot.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtHaberTot.Text = Nothing
      Me.txtHaberTot.Top = 0.0!
      Me.txtHaberTot.Width = 0.875!
      '
      'txtEquiTot
      '
      Me.txtEquiTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEquiTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEquiTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEquiTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEquiTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtEquiTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEquiTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtEquiTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEquiTot.Height = 0.3125!
      Me.txtEquiTot.Left = 6.625!
      Me.txtEquiTot.Name = "txtEquiTot"
      Me.txtEquiTot.OutputFormat = resources.GetString("txtEquiTot.OutputFormat")
      Me.txtEquiTot.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtEquiTot.Text = Nothing
      Me.txtEquiTot.Top = 0.0!
      Me.txtEquiTot.Width = 0.875!
      '
      'txtGlosa
      '
      Me.txtGlosa.Border.BottomColor = System.Drawing.Color.Black
      Me.txtGlosa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtGlosa.Border.LeftColor = System.Drawing.Color.Black
      Me.txtGlosa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtGlosa.Border.RightColor = System.Drawing.Color.Black
      Me.txtGlosa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtGlosa.Border.TopColor = System.Drawing.Color.Black
      Me.txtGlosa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.txtGlosa.DataField = "Glosa"
      Me.txtGlosa.Height = 0.1875!
      Me.txtGlosa.Left = 0.0!
      Me.txtGlosa.Name = "txtGlosa"
      Me.txtGlosa.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtGlosa.Text = "Glosa"
      Me.txtGlosa.Top = 0.6875!
      Me.txtGlosa.Width = 7.5!
      '
      'lblGlosa
      '
      Me.lblGlosa.Border.BottomColor = System.Drawing.Color.Black
      Me.lblGlosa.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblGlosa.Border.LeftColor = System.Drawing.Color.Black
      Me.lblGlosa.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblGlosa.Border.RightColor = System.Drawing.Color.Black
      Me.lblGlosa.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblGlosa.Border.TopColor = System.Drawing.Color.Black
      Me.lblGlosa.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblGlosa.Height = 0.1875!
      Me.lblGlosa.HyperLink = Nothing
      Me.lblGlosa.Left = 0.0!
      Me.lblGlosa.Name = "lblGlosa"
      Me.lblGlosa.Style = "text-align: left; font-weight: bold; font-style: italic; vertical-align: bottom; " & _
          ""
      Me.lblGlosa.Text = "Glosa General"
      Me.lblGlosa.Top = 0.5!
      Me.lblGlosa.Width = 1.125!
      '
      'Shape4
      '
      Me.Shape4.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Border.RightColor = System.Drawing.Color.Black
      Me.Shape4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Border.TopColor = System.Drawing.Color.Black
      Me.Shape4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape4.Height = 0.3125!
      Me.Shape4.Left = 0.0!
      Me.Shape4.LineWeight = 2.0!
      Me.Shape4.Name = "Shape4"
      Me.Shape4.RoundingRadius = 9.999999!
      Me.Shape4.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape4.Top = 0.0!
      Me.Shape4.Width = 7.5!
      '
      'srptCompEEFF
      '
      Me.srptCompEEFF.Border.BottomColor = System.Drawing.Color.Black
      Me.srptCompEEFF.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptCompEEFF.Border.LeftColor = System.Drawing.Color.Black
      Me.srptCompEEFF.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptCompEEFF.Border.RightColor = System.Drawing.Color.Black
      Me.srptCompEEFF.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptCompEEFF.Border.TopColor = System.Drawing.Color.Black
      Me.srptCompEEFF.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.srptCompEEFF.CloseBorder = False
      Me.srptCompEEFF.Height = 0.1875!
      Me.srptCompEEFF.Left = 0.0!
      Me.srptCompEEFF.Name = "srptCompEEFF"
      Me.srptCompEEFF.Report = Nothing
      Me.srptCompEEFF.ReportName = "SubReport1"
      Me.srptCompEEFF.Top = 1.0!
      Me.srptCompEEFF.Width = 7.5!
      '
      'rptCompEditEncHoja
      '
      Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=sqloledb;Data Source=JQuintanilla;Initial Catalog=CONDOBO;User ID=sa;Pa" & _
          "ssword=sa;Current Language=us_english"
      OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
      Me.DataSource = OleDBDataSource1
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
      CType(Me.txtPlanCta, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanDesDebe, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebe, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtHaber, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanDesHaber, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.picAnulado, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonedaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblEntregadoA, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPorConcepto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCompNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoId, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFirma, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompPie, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebeTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtHaberTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEquiTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblGlosa, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub PageHeader_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader.Format
      If txtEstadoId.Text = "12" Then
         picAnulado.Visible = True
      End If

      txtCompNro.Text = ToCeroComplete(txtCompNro.Text, 5)
   End Sub

   Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
      Dim strBanco As String
      Dim strPlanAdd As String
      Dim strCentroCostoDet As String

      If ToLong(Me.Fields("MonedaId").Value) = 1 Then
         If ToDecimal(Me.Fields("DetDebeBs").Value) <> 0 Then
            txtDebe.Text = ToDecStrDos(Me.Fields("DetDebeBs").Value)
            txtHaber.Text = ""
            txtEqui.Text = ToDecStrDos(Me.Fields("DetDebeUs").Value)
            txtPlanDesDebe.Text = ToStr(Me.Fields("PlanDes").Value)

            If ToStr(Me.Fields("CompDetDes").Value) <> "" Then
               txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + "Glosa: " + ToStr(Me.Fields("CompDetDes").Value)
            End If

            strPlanAdd = PlanAddFind(ToLong(Me.Fields("CompId").Value), ToLong(Me.Fields("CompDetId").Value))
            If strPlanAdd <> "" Then
               txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + strPlanAdd
            End If

            If ToLong(Me.Fields("SucCCOId").Value) = 2 Then 'Centro de Costo 
               If ToLong(Me.Fields("CentroCostoId").Value) <> 0 Then
                  txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + "C.C. " + ToStr(Me.Fields("CentroCostoDes").Value)

                  strCentroCostoDet = CentroCostoDetFind(ToLong(Me.Fields("CompId").Value), ToLong(Me.Fields("CompDetId").Value))
                  If strCentroCostoDet <> "" Then
                     txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + strCentroCostoDet
                  End If
               End If

            ElseIf ToLong(Me.Fields("SucCCOId").Value) = 1 Then 'Sucursal
               If ToLong(Me.Fields("SucursalId").Value) <> 0 Then
                  txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + "Suc. " + ToStr(Me.Fields("SucursalDes").Value)
               End If
            End If

            If txtPlanDesDebe.Text <> ToStr(Me.Fields("PlanDes").Value) Then
               txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf
            End If

            txtPlanDesHaber.Text = ""

         ElseIf ToDecimal(Me.Fields("DetHaberBs").Value) <> 0 Then
            txtDebe.Text = ""
            txtHaber.Text = ToDecStrDos(Me.Fields("DetHaberBs").Value)
            txtEqui.Text = ToDecStrDos(Me.Fields("DetHaberUs").Value)
            txtPlanDesHaber.Text = ToStr(Me.Fields("PlanDes").Value)

            If ToStr(Me.Fields("CompDetDes").Value) <> "" Then
               txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + "Glosa: " + ToStr(Me.Fields("CompDetDes").Value)
            End If

            strPlanAdd = PlanAddFind(ToLong(Me.Fields("CompId").Value), ToLong(Me.Fields("CompDetId").Value))
            If strPlanAdd <> "" Then
               txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + strPlanAdd
            End If

            If ToLong(Me.Fields("SucCCOId").Value) = 2 Then 'Centro de Costo 
               If ToLong(Me.Fields("CentroCostoId").Value) <> 0 Then
                  txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + "C.C. " + ToStr(Me.Fields("CentroCostoDes").Value)

                  strCentroCostoDet = CentroCostoDetFind(ToLong(Me.Fields("CompId").Value), ToLong(Me.Fields("CompDetId").Value))
                  If strCentroCostoDet <> "" Then
                     txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + strCentroCostoDet
                  End If
               End If

            ElseIf ToLong(Me.Fields("SucCCOId").Value) = 1 Then 'Sucursal
               If ToLong(Me.Fields("SucursalId").Value) <> 0 Then
                  txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + "Suc. " + ToStr(Me.Fields("SucursalDes").Value)
               End If
            End If

            strBanco = BancoFind(ToLong(Me.Fields("CompDetId").Value))
            If strBanco <> "" Then
               txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + strBanco
            End If

            If txtPlanDesHaber.Text <> ToStr(Me.Fields("PlanDes").Value) Then
               txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf
            End If

            txtPlanDesDebe.Text = ""

         Else 'Ajuste por diferencia de cambio
            If ToDecimalCinco(Me.Fields("DetDebeUs").Value) <> 0 Then
               txtDebe.Text = ""
               txtHaber.Text = ""
               txtEqui.Text = ToDecStrDos(Me.Fields("DetDebeUs").Value)
               txtPlanDesDebe.Text = ToStr(Me.Fields("PlanDes").Value)

               If ToStr(Me.Fields("CompDetDes").Value) <> "" Then
                  txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + "Glosa: " + ToStr(Me.Fields("CompDetDes").Value)
               End If

               If txtPlanDesDebe.Text <> ToStr(Me.Fields("PlanDes").Value) Then
                  txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf
               End If

               txtPlanDesHaber.Text = ""

            ElseIf ToDecimalCinco(Me.Fields("DetHaberUs").Value) <> 0 Then
               txtDebe.Text = ""
               txtHaber.Text = ""
               txtEqui.Text = ToDecStrDos(Me.Fields("DetHaberUs").Value)
               txtPlanDesHaber.Text = ToStr(Me.Fields("PlanDes").Value)

               If ToStr(Me.Fields("CompDetDes").Value) <> "" Then
                  txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + "Glosa: " + ToStr(Me.Fields("CompDetDes").Value)
               End If

               If txtPlanDesHaber.Text <> ToStr(Me.Fields("PlanDes").Value) Then
                  txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf
               End If

               txtPlanDesDebe.Text = ""
            End If
         End If

      ElseIf ToLong(Me.Fields("MonedaId").Value) = 2 Then
         If ToDecimal(Me.Fields("DetDebeUs").Value) <> 0 Then
            txtDebe.Text = ToDecStrDos(Me.Fields("DetDebeUs").Value)
            txtHaber.Text = ""
            txtEqui.Text = ToDecStrDos(Me.Fields("DetDebeBs").Value)
            txtPlanDesDebe.Text = ToStr(Me.Fields("PlanDes").Value)

            If ToStr(Me.Fields("CompDetDes").Value) <> "" Then
               txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + "Glosa: " + ToStr(Me.Fields("CompDetDes").Value)
            End If

            strPlanAdd = PlanAddFind(ToLong(Me.Fields("CompId").Value), ToLong(Me.Fields("CompDetId").Value))
            If strPlanAdd <> "" Then
               txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + strPlanAdd
            End If

            If ToLong(Me.Fields("SucCCOId").Value) = 2 Then 'Centro de Costo 
               If ToLong(Me.Fields("CentroCostoId").Value) <> 0 Then
                  txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + "C.C. " + ToStr(Me.Fields("CentroCostoDes").Value)

                  strCentroCostoDet = CentroCostoDetFind(ToLong(Me.Fields("CompId").Value), ToLong(Me.Fields("CompDetId").Value))
                  If strCentroCostoDet <> "" Then
                     txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + strCentroCostoDet
                  End If
               End If

            ElseIf ToLong(Me.Fields("SucCCOId").Value) = 1 Then 'Sucursal
               If ToLong(Me.Fields("SucursalId").Value) <> 0 Then
                  txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + "Suc. " + ToStr(Me.Fields("SucursalDes").Value)
               End If
            End If

            If txtPlanDesDebe.Text <> ToStr(Me.Fields("PlanDes").Value) Then
               txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf
            End If

            txtPlanDesHaber.Text = ""

         ElseIf ToDecimal(Me.Fields("DetHaberUs").Value) <> 0 Then
            txtDebe.Text = ""
            txtHaber.Text = ToDecStrDos(Me.Fields("DetHaberUs").Value)
            txtEqui.Text = ToDecStrDos(Me.Fields("DetHaberBs").Value)
            txtPlanDesHaber.Text = ToStr(Me.Fields("PlanDes").Value)

            If ToStr(Me.Fields("CompDetDes").Value) <> "" Then
               txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + "Glosa: " + ToStr(Me.Fields("CompDetDes").Value)
            End If

            strPlanAdd = PlanAddFind(ToLong(Me.Fields("CompId").Value), ToLong(Me.Fields("CompDetId").Value))
            If strPlanAdd <> "" Then
               txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + strPlanAdd
            End If

            If ToLong(Me.Fields("SucCCOId").Value) = 2 Then 'Centro de Costo 
               If ToLong(Me.Fields("CentroCostoId").Value) <> 0 Then
                  txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + "C.C. " + ToStr(Me.Fields("CentroCostoDes").Value)

                  strCentroCostoDet = CentroCostoDetFind(ToLong(Me.Fields("CompId").Value), ToLong(Me.Fields("CompDetId").Value))
                  If strCentroCostoDet <> "" Then
                     txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + strCentroCostoDet
                  End If
               End If

            ElseIf ToLong(Me.Fields("SucCCOId").Value) = 1 Then 'Sucursal
               If ToLong(Me.Fields("SucursalId").Value) <> 0 Then
                  txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + "Suc. " + ToStr(Me.Fields("SucursalDes").Value)
               End If
            End If

            strBanco = BancoFind(ToLong(Me.Fields("CompDetId").Value))
            If strBanco <> "" Then
               txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + strBanco
            End If

            If txtPlanDesHaber.Text <> ToStr(Me.Fields("PlanDes").Value) Then
               txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf
            End If

            txtPlanDesDebe.Text = ""

         Else 'Ajuste por diferencia de cambio
            If ToDecimalCinco(Me.Fields("DetDebeBs").Value) <> 0 Then
               txtDebe.Text = ""
               txtHaber.Text = ""
               txtEqui.Text = ToDecStrDos(Me.Fields("DetDebeBs").Value)
               txtPlanDesDebe.Text = ToStr(Me.Fields("PlanDes").Value)

               If ToStr(Me.Fields("CompDetDes").Value) <> "" Then
                  txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf + "Glosa: " + ToStr(Me.Fields("CompDetDes").Value)
               End If

               If txtPlanDesDebe.Text <> ToStr(Me.Fields("PlanDes").Value) Then
                  txtPlanDesDebe.Text = txtPlanDesDebe.Text + vbCrLf
               End If

               txtPlanDesHaber.Text = ""

            ElseIf ToDecimalCinco(Me.Fields("DetHaberBs").Value) <> 0 Then
               txtDebe.Text = ""
               txtHaber.Text = ""
               txtEqui.Text = ToDecStrDos(Me.Fields("DetHaberBs").Value)
               txtPlanDesHaber.Text = ToStr(Me.Fields("PlanDes").Value)

               If ToStr(Me.Fields("CompDetDes").Value) <> "" Then
                  txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf + "Glosa: " + ToStr(Me.Fields("CompDetDes").Value)
               End If

               If txtPlanDesHaber.Text <> ToStr(Me.Fields("PlanDes").Value) Then
                  txtPlanDesHaber.Text = txtPlanDesHaber.Text + vbCrLf
               End If

               txtPlanDesDebe.Text = ""
            End If
         End If
      End If
   End Sub

   Private Sub GroupHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
      If ToLong(Me.Fields("MonedaId").Value) = 1 Then
         txtDebeTot.Text = ToDecStrDos(Me.Fields("DebeBs").Value)
         txtHaberTot.Text = ToDecStrDos(Me.Fields("HaberBs").Value)
         txtEquiTot.Text = ToDecStrDos(Me.Fields("DebeUs").Value)
         lblEqui.Text = "EQUI. " & UCase(MonedaSiglaFind(2))

         txtLiteral.Text = "SON: " + CifraLiteral(Me.Fields("DebeBs").Value) & " " & UCase(txtMonedaDes.Text)

      ElseIf ToLong(Me.Fields("MonedaId").Value) = 2 Then
         txtDebeTot.Text = ToDecStrDos(Me.Fields("DebeUs").Value)
         txtHaberTot.Text = ToDecStrDos(Me.Fields("HaberUs").Value)
         txtEquiTot.Text = ToDecStrDos(Me.Fields("DebeBs").Value)
         lblEqui.Text = "EQUI. " & UCase(MonedaSiglaFind(1))

         txtLiteral.Text = "SON: " + CifraLiteral(Me.Fields("DebeUs").Value) & " " & UCase(txtMonedaDes.Text)
      End If
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      If ToStr(txtGlosa.Text) = "" Then
         GroupFooter1.Height = 0.313
         lblGlosa.Height = 0
         txtGlosa.Height = 0
         lblGlosa.Visible = False
         txtGlosa.Visible = False
         srptCompEEFF.Location = New PointF(0, 0.513)
      End If
   End Sub

   Private Function BancoFind(ByVal lngCompDetId As Long) As String
      Dim oCompCheque As New clsCompCheque(clsAppInfo.ConnectString)
      Dim oCheque As New clsCheque(clsAppInfo.ConnectString)

      Try
         BancoFind = ""

         With oCompCheque
            .SelectFilter = clsCompCheque.SelectFilters.All
            .WhereFilter = clsCompCheque.WhereFilters.CompDetId
            .EmpresaId = clsAppInfo.EmpresaId
            .CompDetId = lngCompDetId

            If .Find Then
               With oCheque
                  .ChequeId = oCompCheque.ChequeId

                  If .FindByPK Then
                     BancoFind = ToStr(oCompCheque.ChequeDes) + " - Cuenta " + ToStr(oCheque.BancoCta) + " - Cheque " + ToStr(oCompCheque.ChequeNro)
                  End If
               End With
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oCompCheque.Dispose()
         oCheque.Dispose()

      End Try
   End Function

   Private Function PlanAddFind(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As String
      Dim oCompPlanAdd As New clsCompPlanAdd(clsAppInfo.ConnectString)
      Dim oPlanAdd As New clsPlanAdd(clsAppInfo.ConnectString)
      Dim strPlanAdd As String

      Try
         PlanAddFind = ""
         strPlanAdd = ""

         With oCompPlanAdd
            .SelectFilter = clsCompPlanAdd.SelectFilters.All
            .WhereFilter = clsCompPlanAdd.WhereFilters.CompDetId
            .EmpresaId = clsAppInfo.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  With oPlanAdd
                     .PlanAddId = oCompPlanAdd.PlanAddId

                     If .FindByPK Then
                        If strPlanAdd <> "" Then
                           strPlanAdd = strPlanAdd + vbCrLf
                        End If

                        strPlanAdd = strPlanAdd + "A.A. " + ToStr(oPlanAdd.PlanAddDes)

                        If oCompPlanAdd.MonedaId = 1 Then
                           If oCompPlanAdd.DebeBs <> 0 Then
                              strPlanAdd = strPlanAdd + "      " + ToDecStrDos(oCompPlanAdd.DebeBs)

                           ElseIf oCompPlanAdd.HaberBs <> 0 Then
                              strPlanAdd = strPlanAdd + "      " + ToDecStrDos(oCompPlanAdd.HaberBs)
                           End If

                        ElseIf oCompPlanAdd.MonedaId = 2 Then
                           If oCompPlanAdd.DebeUs <> 0 Then
                              strPlanAdd = strPlanAdd + "      " + ToDecStrDos(oCompPlanAdd.DebeUs)

                           ElseIf oCompPlanAdd.HaberUs <> 0 Then
                              strPlanAdd = strPlanAdd + "      " + ToDecStrDos(oCompPlanAdd.HaberUs)
                           End If
                        End If
                     End If
                  End With

                  .MoveNext()
               Loop
            End If
         End With

         PlanAddFind = strPlanAdd

      Catch exp As Exception
         Throw exp

      Finally
         oCompPlanAdd.Dispose()
         oPlanAdd.Dispose()

      End Try
   End Function

   Private Function CentroCostoDetFind(ByVal lngCompId As Long, ByVal lngCompDetId As Long) As String
      Dim oCompCentroCostoDet As New clsCompCentroCostoDet(clsAppInfo.ConnectString)
      Dim oCentroCostoDet As New clsCentroCostoDet(clsAppInfo.ConnectString)
      Dim strCentroCostoDet As String

      Try
         CentroCostoDetFind = ""
         strCentroCostoDet = ""

         With oCompCentroCostoDet
            .SelectFilter = clsCompCentroCostoDet.SelectFilters.All
            .WhereFilter = clsCompCentroCostoDet.WhereFilters.CompDetId
            .EmpresaId = clsAppInfo.EmpresaId
            .CompId = lngCompId
            .CompDetId = lngCompDetId

            If .Open Then
               Do While .Read()
                  With oCentroCostoDet
                     .CentroCostoDetId = oCompCentroCostoDet.CentroCostoDetId

                     If .FindByPK Then
                        If strCentroCostoDet <> "" Then
                           strCentroCostoDet = strCentroCostoDet + vbCrLf
                        End If

                        strCentroCostoDet = strCentroCostoDet + "Act. " + ToStr(oCentroCostoDet.CentroCostoDetDes)

                        If oCompCentroCostoDet.MonedaId = 1 Then
                           If oCompCentroCostoDet.DebeBs <> 0 Then
                              strCentroCostoDet = strCentroCostoDet + "      " + ToDecStrDos(oCompCentroCostoDet.DebeBs)

                           ElseIf oCompCentroCostoDet.HaberBs <> 0 Then
                              strCentroCostoDet = strCentroCostoDet + "      " + ToDecStrDos(oCompCentroCostoDet.HaberBs)
                           End If

                        ElseIf oCompCentroCostoDet.MonedaId = 2 Then
                           If oCompCentroCostoDet.DebeUs <> 0 Then
                              strCentroCostoDet = strCentroCostoDet + "      " + ToDecStrDos(oCompCentroCostoDet.DebeUs)

                           ElseIf oCompCentroCostoDet.HaberUs <> 0 Then
                              strCentroCostoDet = strCentroCostoDet + "      " + ToDecStrDos(oCompCentroCostoDet.HaberUs)
                           End If
                        End If
                     End If
                  End With

                  .MoveNext()
               Loop
            End If
         End With

         CentroCostoDetFind = strCentroCostoDet

      Catch exp As Exception
         Throw exp

      Finally
         oCompCentroCostoDet.Dispose()
         oCentroCostoDet.Dispose()

      End Try
   End Function

   Private Function MonedaSiglaFind(ByVal lngMonedaId As Long) As String
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      MonedaSiglaFind = ""

      Try
         With oMoneda
            .MonedaId = lngMonedaId

            If .FindByPK Then
               MonedaSiglaFind = .MonedaSigla
            End If
         End With

      Catch exp As Exception
         Throw exp

      Finally
         oMoneda.Dispose()

      End Try
   End Function

End Class