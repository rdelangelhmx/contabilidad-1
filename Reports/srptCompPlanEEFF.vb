Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class srptCompPlanEEFF
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
   Private Shape3 As DataDynamics.ActiveReports.Shape
   Private lblEqui As DataDynamics.ActiveReports.Label
   Private Label11 As DataDynamics.ActiveReports.Label
   Private Label9 As DataDynamics.ActiveReports.Label
   Private Label10 As DataDynamics.ActiveReports.Label
   Private Label7 As DataDynamics.ActiveReports.Label
   Private txtPlanCta As DataDynamics.ActiveReports.TextBox
   Private txtPlanEEFFDesDebe As DataDynamics.ActiveReports.TextBox
   Private txtDebe As DataDynamics.ActiveReports.TextBox
   Private txtHaber As DataDynamics.ActiveReports.TextBox
   Private txtEqui As DataDynamics.ActiveReports.TextBox
   Private txtPlanEEFFDesHaber As DataDynamics.ActiveReports.TextBox
   Private txtLiteral As DataDynamics.ActiveReports.TextBox
   Private txtDebeTot As DataDynamics.ActiveReports.TextBox
   Private txtHaberTot As DataDynamics.ActiveReports.TextBox
   Private txtEquiTot As DataDynamics.ActiveReports.TextBox
   Private WithEvents Label1 As DataDynamics.ActiveReports.Label
   Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
   Private Shape4 As DataDynamics.ActiveReports.Shape

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(srptCompPlanEEFF))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtPlanCta = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanEEFFDesDebe = New DataDynamics.ActiveReports.TextBox
      Me.txtDebe = New DataDynamics.ActiveReports.TextBox
      Me.txtHaber = New DataDynamics.ActiveReports.TextBox
      Me.txtEqui = New DataDynamics.ActiveReports.TextBox
      Me.txtPlanEEFFDesHaber = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
      Me.lblEqui = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.Shape3 = New DataDynamics.ActiveReports.Shape
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.txtDebeTot = New DataDynamics.ActiveReports.TextBox
      Me.txtHaberTot = New DataDynamics.ActiveReports.TextBox
      Me.txtEquiTot = New DataDynamics.ActiveReports.TextBox
      Me.Shape4 = New DataDynamics.ActiveReports.Shape
      Me.Line1 = New DataDynamics.ActiveReports.Line
      CType(Me.txtPlanCta, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanEEFFDesDebe, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebe, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtHaber, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPlanEEFFDesHaber, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblEqui, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDebeTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtHaberTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEquiTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPlanCta, Me.txtPlanEEFFDesDebe, Me.txtDebe, Me.txtHaber, Me.txtEqui, Me.txtPlanEEFFDesHaber})
      Me.Detail.Height = 0.15625!
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
      Me.txtPlanCta.DataField = "PlanEEFFCta"
      Me.txtPlanCta.Height = 0.1476378!
      Me.txtPlanCta.Left = 0.0!
      Me.txtPlanCta.Name = "txtPlanCta"
      Me.txtPlanCta.Style = "ddo-char-set: 0; font-size: 6.75pt; font-family: Arial; "
      Me.txtPlanCta.Text = "PlanCta"
      Me.txtPlanCta.Top = 0.0!
      Me.txtPlanCta.Width = 0.738189!
      '
      'txtPlanEEFFDesDebe
      '
      Me.txtPlanEEFFDesDebe.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDesDebe.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDesDebe.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDesDebe.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDesDebe.Border.RightColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDesDebe.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDesDebe.Border.TopColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDesDebe.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDesDebe.Height = 0.1476378!
      Me.txtPlanEEFFDesDebe.Left = 0.738189!
      Me.txtPlanEEFFDesDebe.Name = "txtPlanEEFFDesDebe"
      Me.txtPlanEEFFDesDebe.Style = "ddo-char-set: 0; font-size: 6.75pt; font-family: Arial; "
      Me.txtPlanEEFFDesDebe.Text = Nothing
      Me.txtPlanEEFFDesDebe.Top = 0.0!
      Me.txtPlanEEFFDesDebe.Width = 4.133858!
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
      Me.txtDebe.Height = 0.1476378!
      Me.txtDebe.Left = 4.872047!
      Me.txtDebe.Name = "txtDebe"
      Me.txtDebe.OutputFormat = resources.GetString("txtDebe.OutputFormat")
      Me.txtDebe.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Arial; "
      Me.txtDebe.Text = Nothing
      Me.txtDebe.Top = 0.0!
      Me.txtDebe.Width = 0.8858268!
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
      Me.txtHaber.Height = 0.1476378!
      Me.txtHaber.Left = 5.757874!
      Me.txtHaber.Name = "txtHaber"
      Me.txtHaber.OutputFormat = resources.GetString("txtHaber.OutputFormat")
      Me.txtHaber.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Arial; "
      Me.txtHaber.Text = Nothing
      Me.txtHaber.Top = 0.0!
      Me.txtHaber.Width = 0.8612205!
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
      Me.txtEqui.Height = 0.1476378!
      Me.txtEqui.Left = 6.619095!
      Me.txtEqui.Name = "txtEqui"
      Me.txtEqui.OutputFormat = resources.GetString("txtEqui.OutputFormat")
      Me.txtEqui.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Arial; "
      Me.txtEqui.Text = Nothing
      Me.txtEqui.Top = 0.0!
      Me.txtEqui.Width = 0.8120077!
      '
      'txtPlanEEFFDesHaber
      '
      Me.txtPlanEEFFDesHaber.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDesHaber.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDesHaber.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDesHaber.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDesHaber.Border.RightColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDesHaber.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDesHaber.Border.TopColor = System.Drawing.Color.Black
      Me.txtPlanEEFFDesHaber.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPlanEEFFDesHaber.Height = 0.1476378!
      Me.txtPlanEEFFDesHaber.Left = 1.377953!
      Me.txtPlanEEFFDesHaber.Name = "txtPlanEEFFDesHaber"
      Me.txtPlanEEFFDesHaber.Style = "ddo-char-set: 0; font-size: 6.75pt; font-family: Arial; "
      Me.txtPlanEEFFDesHaber.Text = Nothing
      Me.txtPlanEEFFDesHaber.Top = 0.0!
      Me.txtPlanEEFFDesHaber.Width = 3.494095!
      '
      'ReportHeader
      '
      Me.ReportHeader.Height = 0.0!
      Me.ReportHeader.Name = "ReportHeader"
      '
      'ReportFooter
      '
      Me.ReportFooter.Height = 0.0!
      Me.ReportFooter.Name = "ReportFooter"
      Me.ReportFooter.PrintAtBottom = True
      '
      'PageHeader
      '
      Me.PageHeader.Height = 0.0!
      Me.PageHeader.Name = "PageHeader"
      '
      'PageFooter
      '
      Me.PageFooter.Height = 0.02083333!
      Me.PageFooter.Name = "PageFooter"
      '
      'GroupHeader1
      '
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblEqui, Me.Label11, Me.Label9, Me.Label10, Me.Label7, Me.Label1, Me.Shape3})
      Me.GroupHeader1.Height = 0.40625!
      Me.GroupHeader1.Name = "GroupHeader1"
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
      Me.lblEqui.Height = 0.1476378!
      Me.lblEqui.HyperLink = Nothing
      Me.lblEqui.Left = 6.619095!
      Me.lblEqui.Name = "lblEqui"
      Me.lblEqui.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-style: italic; font-" & _
          "size: 8.25pt; font-family: Arial Narrow; "
      Me.lblEqui.Text = "EQUIVAL."
      Me.lblEqui.Top = 0.246063!
      Me.lblEqui.Width = 0.8120077!
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
      Me.Label11.Height = 0.1476378!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 5.757874!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-style: italic; font-" & _
          "size: 8.25pt; font-family: Arial Narrow; "
      Me.Label11.Text = "HABER"
      Me.Label11.Top = 0.246063!
      Me.Label11.Width = 0.8612205!
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
      Me.Label9.Height = 0.1476378!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 4.872047!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-style: italic; font-" & _
          "size: 8.25pt; font-family: Arial Narrow; "
      Me.Label9.Text = "DEBE"
      Me.Label9.Top = 0.246063!
      Me.Label9.Width = 0.8858268!
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
      Me.Label10.Height = 0.1476378!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 0.738189!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-style: italic; font-" & _
          "size: 8.25pt; font-family: Arial Narrow; "
      Me.Label10.Text = "DESCRIPCIÓN"
      Me.Label10.Top = 0.246063!
      Me.Label10.Width = 4.133858!
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
      Me.Label7.Height = 0.1476378!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 0.0!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-style: italic; font-" & _
          "size: 8.25pt; font-family: Arial Narrow; "
      Me.Label7.Text = "CUENTA"
      Me.Label7.Top = 0.246063!
      Me.Label7.Width = 0.738189!
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
      Me.Label1.Left = 0.0!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-style: italic; font-si" & _
          "ze: 9.75pt; font-family: Arial Narrow; "
      Me.Label1.Text = "FLUJOS DE EFECTIVO"
      Me.Label1.Top = 0.0!
      Me.Label1.Width = 4.1875!
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
      Me.Shape3.Height = 0.1476378!
      Me.Shape3.Left = 0.0!
      Me.Shape3.LineWeight = 2.0!
      Me.Shape3.Name = "Shape3"
      Me.Shape3.RoundingRadius = 9.999999!
      Me.Shape3.Style = DataDynamics.ActiveReports.ShapeType.RoundRect
      Me.Shape3.Top = 0.246063!
      Me.Shape3.Width = 7.431103!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtLiteral, Me.txtDebeTot, Me.txtHaberTot, Me.txtEquiTot, Me.Shape4, Me.Line1})
      Me.GroupFooter1.Height = 0.04166667!
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
      Me.txtLiteral.Style = "ddo-char-set: 0; font-size: 6.75pt; vertical-align: middle; "
      Me.txtLiteral.Text = Nothing
      Me.txtLiteral.Top = 0.0!
      Me.txtLiteral.Visible = False
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
      Me.txtDebeTot.DataField = "DebeOrg"
      Me.txtDebeTot.Height = 0.3125!
      Me.txtDebeTot.Left = 4.875!
      Me.txtDebeTot.Name = "txtDebeTot"
      Me.txtDebeTot.OutputFormat = resources.GetString("txtDebeTot.OutputFormat")
      Me.txtDebeTot.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; "
      Me.txtDebeTot.SummaryGroup = "GroupHeader1"
      Me.txtDebeTot.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
      Me.txtDebeTot.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtDebeTot.Text = Nothing
      Me.txtDebeTot.Top = 0.0!
      Me.txtDebeTot.Visible = False
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
      Me.txtHaberTot.DataField = "HaberOrg"
      Me.txtHaberTot.Height = 0.3125!
      Me.txtHaberTot.Left = 5.75!
      Me.txtHaberTot.Name = "txtHaberTot"
      Me.txtHaberTot.OutputFormat = resources.GetString("txtHaberTot.OutputFormat")
      Me.txtHaberTot.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; "
      Me.txtHaberTot.SummaryGroup = "GroupHeader1"
      Me.txtHaberTot.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
      Me.txtHaberTot.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtHaberTot.Text = Nothing
      Me.txtHaberTot.Top = 0.0!
      Me.txtHaberTot.Visible = False
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
      Me.txtEquiTot.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; "
      Me.txtEquiTot.Text = Nothing
      Me.txtEquiTot.Top = 0.0!
      Me.txtEquiTot.Visible = False
      Me.txtEquiTot.Width = 0.8125!
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
      Me.Shape4.Visible = False
      Me.Shape4.Width = 7.4375!
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
      Me.Line1.Left = 0.0!
      Me.Line1.LineWeight = 1.0!
      Me.Line1.Name = "Line1"
      Me.Line1.Top = 0.0246063!
      Me.Line1.Width = 7.431103!
      Me.Line1.X1 = 0.0!
      Me.Line1.X2 = 7.431103!
      Me.Line1.Y1 = 0.0246063!
      Me.Line1.Y2 = 0.0246063!
      '
      'rptCompEdit3
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
      Me.PageSettings.PaperHeight = 11.69!
      Me.PageSettings.PaperWidth = 8.27!
      Me.PrintWidth = 7.447917!
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
      CType(Me.txtPlanEEFFDesDebe, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebe, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtHaber, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPlanEEFFDesHaber, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblEqui, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDebeTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtHaberTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEquiTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
      If ToLong(Me.Fields("MonedaId").Value) = 1 Then
         If ToDecimal(Me.Fields("DebeBs").Value) <> 0 Then
            txtDebe.Text = ToDecStrDos(Me.Fields("DebeBs").Value)
            txtHaber.Text = ""
            txtEqui.Text = ToDecStrDos(Me.Fields("DebeUs").Value)
            txtPlanEEFFDesDebe.Text = ToStr(Me.Fields("PlanEEFFDes").Value)

            If txtPlanEEFFDesDebe.Text <> ToStr(Me.Fields("PlanEEFFDes").Value) Then
               txtPlanEEFFDesDebe.Text = txtPlanEEFFDesDebe.Text + vbCrLf
            End If

            txtPlanEEFFDesHaber.Text = ""

         ElseIf ToDecimal(Me.Fields("HaberBs").Value) <> 0 Then
            txtDebe.Text = ""
            txtHaber.Text = ToDecStrDos(Me.Fields("HaberBs").Value)
            txtEqui.Text = ToDecStrDos(Me.Fields("HaberUs").Value)
            txtPlanEEFFDesHaber.Text = ToStr(Me.Fields("PlanEEFFDes").Value)

            If txtPlanEEFFDesHaber.Text <> ToStr(Me.Fields("PlanEEFFDes").Value) Then
               txtPlanEEFFDesHaber.Text = txtPlanEEFFDesHaber.Text + vbCrLf
            End If

            txtPlanEEFFDesDebe.Text = ""
         End If

      ElseIf ToLong(Me.Fields("MonedaId").Value) = 2 Then
         If ToDecimal(Me.Fields("DebeUs").Value) <> 0 Then
            txtDebe.Text = ToDecStrDos(Me.Fields("DebeUs").Value)
            txtHaber.Text = ""
            txtEqui.Text = ToDecStrDos(Me.Fields("DebeBs").Value)
            txtPlanEEFFDesDebe.Text = ToStr(Me.Fields("PlanEEFFDes").Value)

            If txtPlanEEFFDesDebe.Text <> ToStr(Me.Fields("PlanEEFFDes").Value) Then
               txtPlanEEFFDesDebe.Text = txtPlanEEFFDesDebe.Text + vbCrLf
            End If

            txtPlanEEFFDesHaber.Text = ""

         ElseIf ToDecimal(Me.Fields("HaberUs").Value) <> 0 Then
            txtDebe.Text = ""
            txtHaber.Text = ToDecStrDos(Me.Fields("HaberUs").Value)
            txtEqui.Text = ToDecStrDos(Me.Fields("HaberBs").Value)
            txtPlanEEFFDesHaber.Text = ToStr(Me.Fields("PlanEEFFDes").Value)

            If txtPlanEEFFDesHaber.Text <> ToStr(Me.Fields("PlanEEFFDes").Value) Then
               txtPlanEEFFDesHaber.Text = txtPlanEEFFDesHaber.Text + vbCrLf
            End If

            txtPlanEEFFDesDebe.Text = ""
         End If
      End If
   End Sub

End Class