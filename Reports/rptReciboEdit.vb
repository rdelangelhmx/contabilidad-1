Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptReciboEdit 
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
   Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource
   Public lblCompany As DataDynamics.ActiveReports.Label
   Public lblTitle As DataDynamics.ActiveReports.Label
   Private Label As DataDynamics.ActiveReports.Label
   Private Label1 As DataDynamics.ActiveReports.Label
   Private Shape2 As DataDynamics.ActiveReports.Shape
   Private Shape1 As DataDynamics.ActiveReports.Shape
   Public lblEntregadoA As DataDynamics.ActiveReports.Label
   Public lblPorConcepto As DataDynamics.ActiveReports.Label
   Private Label3 As DataDynamics.ActiveReports.Label
   Private Label4 As DataDynamics.ActiveReports.Label
   Private Label6 As DataDynamics.ActiveReports.Label
   Private TextBox1 As DataDynamics.ActiveReports.TextBox
   Private TextBox2 As DataDynamics.ActiveReports.TextBox
   Private TextBox3 As DataDynamics.ActiveReports.TextBox
   Private txtReciboNro As DataDynamics.ActiveReports.TextBox
   Private TextBox5 As DataDynamics.ActiveReports.TextBox
   Private TextBox6 As DataDynamics.ActiveReports.TextBox
   Private TextBox9 As DataDynamics.ActiveReports.TextBox
   Private Label12 As DataDynamics.ActiveReports.Label
   Private Label2 As DataDynamics.ActiveReports.Label
   Private Label14 As DataDynamics.ActiveReports.Label
   Private txtLiteral As DataDynamics.ActiveReports.TextBox
   Private Label15 As DataDynamics.ActiveReports.Label
   Private TextBox10 As DataDynamics.ActiveReports.TextBox
   Private Label16 As DataDynamics.ActiveReports.Label
   Private TextBox11 As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label13 As DataDynamics.ActiveReports.Label
   Private Line2 As DataDynamics.ActiveReports.Line
   Public lblDate As DataDynamics.ActiveReports.Label
   Public lblTime As DataDynamics.ActiveReports.Label
   Public lblLogin As DataDynamics.ActiveReports.Label
   Public lblFirma As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptReciboEdit))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.Shape2 = New DataDynamics.ActiveReports.Shape
      Me.Shape1 = New DataDynamics.ActiveReports.Shape
      Me.lblEntregadoA = New DataDynamics.ActiveReports.Label
      Me.lblPorConcepto = New DataDynamics.ActiveReports.Label
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
      Me.txtReciboNro = New DataDynamics.ActiveReports.TextBox
      Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.Label14 = New DataDynamics.ActiveReports.Label
      Me.txtLiteral = New DataDynamics.ActiveReports.TextBox
      Me.Label15 = New DataDynamics.ActiveReports.Label
      Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
      Me.Label16 = New DataDynamics.ActiveReports.Label
      Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblCompany = New DataDynamics.ActiveReports.Label
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.lblFirma = New DataDynamics.ActiveReports.Label
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label13 = New DataDynamics.ActiveReports.Label
      Me.Line2 = New DataDynamics.ActiveReports.Line
      Me.lblDate = New DataDynamics.ActiveReports.Label
      Me.lblTime = New DataDynamics.ActiveReports.Label
      Me.lblLogin = New DataDynamics.ActiveReports.Label
      CType(Me.lblEntregadoA, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPorConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtReciboNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblFirma, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape2, Me.Shape1, Me.lblEntregadoA, Me.lblPorConcepto, Me.Label3, Me.Label4, Me.Label6, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.txtReciboNro, Me.TextBox5, Me.TextBox6, Me.TextBox9, Me.Label12, Me.Label2, Me.Label14, Me.txtLiteral, Me.Label15, Me.TextBox10, Me.Label16, Me.TextBox11})
      Me.Detail.Height = 1.708333!
      Me.Detail.Name = "Detail"
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
      Me.Shape2.Top = 0.0!
      Me.Shape2.Width = 1.364583!
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
      Me.Shape1.Top = 0.0!
      Me.Shape1.Width = 6.0625!
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
      Me.lblEntregadoA.Top = 0.0625!
      Me.lblEntregadoA.Width = 1.125!
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
      Me.lblPorConcepto.Top = 0.3125!
      Me.lblPorConcepto.Width = 1.125!
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
      Me.Label3.Left = 0.0625!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label3.Text = "La Suma de :"
      Me.Label3.Top = 0.5625!
      Me.Label3.Width = 1.125!
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
      Me.Label4.Top = 0.0625!
      Me.Label4.Width = 0.4375!
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
      Me.Label6.Top = 0.3125!
      Me.Label6.Width = 0.4375!
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
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox1.Text = "EntregadoA"
      Me.TextBox1.Top = 0.0625!
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
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox2.Text = "PorConcepto"
      Me.TextBox2.Top = 0.3125!
      Me.TextBox2.Width = 4.75!
      '
      'TextBox3
      '
      Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.DataField = "MonedaDes"
      Me.TextBox3.Height = 0.1875!
      Me.TextBox3.Left = 6.6875!
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox3.Text = "MonedaDes"
      Me.TextBox3.Top = 0.5625!
      Me.TextBox3.Width = 0.75!
      '
      'txtReciboNro
      '
      Me.txtReciboNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtReciboNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtReciboNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtReciboNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtReciboNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtReciboNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtReciboNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtReciboNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtReciboNro.DataField = "ReciboNro"
      Me.txtReciboNro.Height = 0.1875!
      Me.txtReciboNro.Left = 6.6875!
      Me.txtReciboNro.Name = "txtReciboNro"
      Me.txtReciboNro.Style = "ddo-char-set: 0; font-weight: bold; font-size: 12pt; vertical-align: middle; "
      Me.txtReciboNro.Text = "ReciboNro"
      Me.txtReciboNro.Top = 0.0625!
      Me.txtReciboNro.Width = 0.75!
      '
      'TextBox5
      '
      Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.DataField = "Fecha"
      Me.TextBox5.Height = 0.1875!
      Me.TextBox5.Left = 6.6875!
      Me.TextBox5.Name = "TextBox5"
      Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
      Me.TextBox5.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox5.Text = "Fecha"
      Me.TextBox5.Top = 0.3125!
      Me.TextBox5.Width = 0.75!
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
      Me.TextBox6.DataField = "Monto"
      Me.TextBox6.Height = 0.1875!
      Me.TextBox6.Left = 1.25!
      Me.TextBox6.Name = "TextBox6"
      Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
      Me.TextBox6.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; vertical-align: middle; "
      Me.TextBox6.Text = "Monto"
      Me.TextBox6.Top = 0.5625!
      Me.TextBox6.Width = 0.75!
      '
      'TextBox9
      '
      Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.DashDot
      Me.TextBox9.DataField = "Glosa"
      Me.TextBox9.Height = 0.2!
      Me.TextBox9.Left = 0.0!
      Me.TextBox9.Name = "TextBox9"
      Me.TextBox9.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.TextBox9.Text = "Glosa"
      Me.TextBox9.Top = 1.5!
      Me.TextBox9.Width = 7.5!
      '
      'Label12
      '
      Me.Label12.Border.BottomColor = System.Drawing.Color.Black
      Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Border.LeftColor = System.Drawing.Color.Black
      Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Border.RightColor = System.Drawing.Color.Black
      Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Border.TopColor = System.Drawing.Color.Black
      Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label12.Height = 0.25!
      Me.Label12.HyperLink = Nothing
      Me.Label12.Left = 0.0!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "text-align: left; font-weight: bold; font-style: italic; vertical-align: bottom; " & _
          ""
      Me.Label12.Text = "Glosa General"
      Me.Label12.Top = 1.25!
      Me.Label12.Width = 1.125!
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
      Me.Label2.Left = 6.1875!
      Me.Label2.Name = "Label2"
      Me.Label2.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label2.Text = "Moneda"
      Me.Label2.Top = 0.5625!
      Me.Label2.Width = 0.5!
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
      Me.Label14.Left = 0.0!
      Me.Label14.Name = "Label14"
      Me.Label14.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label14.Text = "Son :"
      Me.Label14.Top = 0.9375!
      Me.Label14.Width = 0.3125!
      '
      'txtLiteral
      '
      Me.txtLiteral.Border.BottomColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtLiteral.Border.LeftColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.RightColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Border.TopColor = System.Drawing.Color.Black
      Me.txtLiteral.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtLiteral.Height = 0.1875!
      Me.txtLiteral.Left = 0.375!
      Me.txtLiteral.Name = "txtLiteral"
      Me.txtLiteral.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtLiteral.Text = Nothing
      Me.txtLiteral.Top = 0.9375!
      Me.txtLiteral.Width = 7.125!
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
      Me.Label15.Height = 0.1875!
      Me.Label15.HyperLink = Nothing
      Me.Label15.Left = 3.0625!
      Me.Label15.Name = "Label15"
      Me.Label15.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.Label15.Text = "Doc. de Respaldo :"
      Me.Label15.Top = 0.5625!
      Me.Label15.Width = 1.0625!
      '
      'TextBox10
      '
      Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.DataField = "RespaldoDes"
      Me.TextBox10.Height = 0.1875!
      Me.TextBox10.Left = 4.125!
      Me.TextBox10.Name = "TextBox10"
      Me.TextBox10.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox10.Text = "RespaldoDes"
      Me.TextBox10.Top = 0.5625!
      Me.TextBox10.Width = 1.0!
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
      Me.Label16.Left = 5.1875!
      Me.Label16.Name = "Label16"
      Me.Label16.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8pt; vertical-al" & _
          "ign: middle; "
      Me.Label16.Text = "Nro."
      Me.Label16.Top = 0.5625!
      Me.Label16.Width = 0.25!
      '
      'TextBox11
      '
      Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.DataField = "RespaldoNro"
      Me.TextBox11.Height = 0.2!
      Me.TextBox11.Left = 5.5!
      Me.TextBox11.Name = "TextBox11"
      Me.TextBox11.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.TextBox11.Text = "RespaldoNro"
      Me.TextBox11.Top = 0.5625!
      Me.TextBox11.Width = 0.5!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblCompany, Me.lblTitle, Me.Label, Me.Label1})
      Me.ReportHeader.Height = 0.6763889!
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
      Me.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.LeftColor = System.Drawing.Color.Black
      Me.lblTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.RightColor = System.Drawing.Color.Black
      Me.lblTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Border.TopColor = System.Drawing.Color.Black
      Me.lblTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblTitle.Height = 0.25!
      Me.lblTitle.HyperLink = Nothing
      Me.lblTitle.Left = 2.75!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14pt; vertical" & _
          "-align: middle; "
      Me.lblTitle.Text = ""
      Me.lblTitle.Top = 0.3125!
      Me.lblTitle.Width = 2.0!
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
      Me.Label.Left = 2.0!
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
      Me.Label1.Left = 4.75!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 16pt; vertical" & _
          "-align: middle; "
      Me.Label1.Text = ">>>>>"
      Me.Label1.Top = 0.3125!
      Me.Label1.Width = 0.75!
      '
      'ReportFooter
      '
      Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblFirma})
      Me.ReportFooter.Height = 0.375!
      Me.ReportFooter.Name = "ReportFooter"
      Me.ReportFooter.PrintAtBottom = True
      '
      'lblFirma
      '
      Me.lblFirma.Border.BottomColor = System.Drawing.Color.Black
      Me.lblFirma.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFirma.Border.LeftColor = System.Drawing.Color.Black
      Me.lblFirma.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFirma.Border.RightColor = System.Drawing.Color.Black
      Me.lblFirma.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFirma.Border.TopColor = System.Drawing.Color.Black
      Me.lblFirma.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblFirma.Height = 0.375!
      Me.lblFirma.HyperLink = Nothing
      Me.lblFirma.Left = 0.0!
      Me.lblFirma.Name = "lblFirma"
      Me.lblFirma.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 8pt; vertica" & _
          "l-align: top; "
      Me.lblFirma.Text = "VoBo"
      Me.lblFirma.Top = 0.0!
      Me.lblFirma.Width = 7.5!
      '
      'PageHeader
      '
      Me.PageHeader.Height = 0.0!
      Me.PageHeader.Name = "PageHeader"
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPageCount, Me.txtPageNOfM, Me.Label13, Me.Line2, Me.lblDate, Me.lblTime, Me.lblLogin})
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
      'rptReciboEdit
      '
      Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
            "Catalog=CONDOBO;Data Source=JQuintanilla"
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
      CType(Me.lblEntregadoA, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPorConcepto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtReciboNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtLiteral, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblCompany, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblFirma, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTime, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblLogin, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
      txtLiteral.Text = CifraLiteral(Me.Fields("Monto").Value) + "  " + UCase(Me.Fields("MonedaDes").Value)

      txtReciboNro.Text = ToCeroComplete(txtReciboNro.Text, 5)
   End Sub

End Class