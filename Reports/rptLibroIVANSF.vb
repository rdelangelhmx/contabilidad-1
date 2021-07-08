Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptLibroIVANSF
   Inherits DataDynamics.ActiveReports.ActiveReport3

   Private mlngAnio As Long = 0
   Private mlngMesId As Long = 0

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
   Public lblTitle As DataDynamics.ActiveReports.Label
   Public lblMes As DataDynamics.ActiveReports.Label
   Public lblGestion As DataDynamics.ActiveReports.Label
   Private Shape As DataDynamics.ActiveReports.Shape
   Private Label As DataDynamics.ActiveReports.Label
   Public txtEmpresaDes As DataDynamics.ActiveReports.TextBox
   Private Label1 As DataDynamics.ActiveReports.Label
   Public txtEmpresaRUC As DataDynamics.ActiveReports.TextBox
   Private Label2 As DataDynamics.ActiveReports.Label
   Public txtSucursalCod As DataDynamics.ActiveReports.TextBox
   Public txtDireccion As DataDynamics.ActiveReports.TextBox
   Private Label3 As DataDynamics.ActiveReports.Label
   Private TextBox9 As DataDynamics.ActiveReports.TextBox
   Private txtPageCount As DataDynamics.ActiveReports.TextBox
   Private txtPageNOfM As DataDynamics.ActiveReports.TextBox
   Private Label4 As DataDynamics.ActiveReports.Label
   Private Label7 As DataDynamics.ActiveReports.Label
   Public lblIVA As DataDynamics.ActiveReports.TextBox
   Private TextBox42 As DataDynamics.ActiveReports.TextBox
   Private TextBox41 As DataDynamics.ActiveReports.TextBox
   Private TextBox6 As DataDynamics.ActiveReports.TextBox
   Private TextBox5 As DataDynamics.ActiveReports.TextBox
   Private TextBox30 As DataDynamics.ActiveReports.TextBox
   Private TextBox29 As DataDynamics.ActiveReports.TextBox
   Private TextBox14 As DataDynamics.ActiveReports.TextBox
   Private TextBox15 As DataDynamics.ActiveReports.TextBox
   Private TextBox16 As DataDynamics.ActiveReports.TextBox
   Public lblRegRUCDes As DataDynamics.ActiveReports.TextBox
   Public lblNroRUC As DataDynamics.ActiveReports.TextBox
   Private TextBox7 As DataDynamics.ActiveReports.TextBox
   Private TextBox As DataDynamics.ActiveReports.TextBox
   Private txtIVA As DataDynamics.ActiveReports.TextBox
   Private txtNeto As DataDynamics.ActiveReports.TextBox
   Private txtExento As DataDynamics.ActiveReports.TextBox
   Private txtIceIehd As DataDynamics.ActiveReports.TextBox
   Private txtFacturaMonto As DataDynamics.ActiveReports.TextBox
   Private txtCodControl As DataDynamics.ActiveReports.TextBox
   Private txtNroAutorizacion As DataDynamics.ActiveReports.TextBox
   Private txtFacturaNro As DataDynamics.ActiveReports.TextBox
   Private txtRegRUCDes As DataDynamics.ActiveReports.TextBox
   Private txtNroRUC As DataDynamics.ActiveReports.TextBox
   Private txtFechaAnio As DataDynamics.ActiveReports.TextBox
   Private txtFechaMes As DataDynamics.ActiveReports.TextBox
   Private txtFechaDia As DataDynamics.ActiveReports.TextBox
   Private Label5 As DataDynamics.ActiveReports.Label
   Public txtResponsableCI As DataDynamics.ActiveReports.TextBox
   Private Label6 As DataDynamics.ActiveReports.Label
   Public txtResponsableDes As DataDynamics.ActiveReports.TextBox
   Private txtFacturaMontoTot As DataDynamics.ActiveReports.TextBox
   Private txtFacturaMontoPag As DataDynamics.ActiveReports.TextBox
   Private txtIceIehdTot As DataDynamics.ActiveReports.TextBox
   Private txtIceIehdPag As DataDynamics.ActiveReports.TextBox
   Private txtExentoTot As DataDynamics.ActiveReports.TextBox
   Private txtExentoPag As DataDynamics.ActiveReports.TextBox
   Private txtNetoTot As DataDynamics.ActiveReports.TextBox
   Private txtNetoPag As DataDynamics.ActiveReports.TextBox
   Private txtIVATot As DataDynamics.ActiveReports.TextBox
   Private txtIVAPag As DataDynamics.ActiveReports.TextBox
   Private Label8 As DataDynamics.ActiveReports.Label
   Friend WithEvents pgbDetail As DataDynamics.ActiveReports.PageBreak
   Private Label9 As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptLibroIVANSF))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtIVA = New DataDynamics.ActiveReports.TextBox
      Me.txtNeto = New DataDynamics.ActiveReports.TextBox
      Me.txtExento = New DataDynamics.ActiveReports.TextBox
      Me.txtIceIehd = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaMonto = New DataDynamics.ActiveReports.TextBox
      Me.txtCodControl = New DataDynamics.ActiveReports.TextBox
      Me.txtNroAutorizacion = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaNro = New DataDynamics.ActiveReports.TextBox
      Me.txtRegRUCDes = New DataDynamics.ActiveReports.TextBox
      Me.txtNroRUC = New DataDynamics.ActiveReports.TextBox
      Me.txtFechaAnio = New DataDynamics.ActiveReports.TextBox
      Me.txtFechaMes = New DataDynamics.ActiveReports.TextBox
      Me.txtFechaDia = New DataDynamics.ActiveReports.TextBox
      Me.pgbDetail = New DataDynamics.ActiveReports.PageBreak
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.lblMes = New DataDynamics.ActiveReports.Label
      Me.lblGestion = New DataDynamics.ActiveReports.Label
      Me.Shape = New DataDynamics.ActiveReports.Shape
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.txtEmpresaDes = New DataDynamics.ActiveReports.TextBox
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.txtEmpresaRUC = New DataDynamics.ActiveReports.TextBox
      Me.Label2 = New DataDynamics.ActiveReports.Label
      Me.txtSucursalCod = New DataDynamics.ActiveReports.TextBox
      Me.txtDireccion = New DataDynamics.ActiveReports.TextBox
      Me.Label3 = New DataDynamics.ActiveReports.Label
      Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
      Me.txtPageCount = New DataDynamics.ActiveReports.TextBox
      Me.txtPageNOfM = New DataDynamics.ActiveReports.TextBox
      Me.Label4 = New DataDynamics.ActiveReports.Label
      Me.Label7 = New DataDynamics.ActiveReports.Label
      Me.lblIVA = New DataDynamics.ActiveReports.TextBox
      Me.TextBox42 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox41 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox30 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox29 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
      Me.lblRegRUCDes = New DataDynamics.ActiveReports.TextBox
      Me.lblNroRUC = New DataDynamics.ActiveReports.TextBox
      Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.Label5 = New DataDynamics.ActiveReports.Label
      Me.txtResponsableCI = New DataDynamics.ActiveReports.TextBox
      Me.Label6 = New DataDynamics.ActiveReports.Label
      Me.txtResponsableDes = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaMontoTot = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaMontoPag = New DataDynamics.ActiveReports.TextBox
      Me.txtIceIehdTot = New DataDynamics.ActiveReports.TextBox
      Me.txtIceIehdPag = New DataDynamics.ActiveReports.TextBox
      Me.txtExentoTot = New DataDynamics.ActiveReports.TextBox
      Me.txtExentoPag = New DataDynamics.ActiveReports.TextBox
      Me.txtNetoTot = New DataDynamics.ActiveReports.TextBox
      Me.txtNetoPag = New DataDynamics.ActiveReports.TextBox
      Me.txtIVATot = New DataDynamics.ActiveReports.TextBox
      Me.txtIVAPag = New DataDynamics.ActiveReports.TextBox
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.Label9 = New DataDynamics.ActiveReports.Label
      CType(Me.txtIVA, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNeto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtExento, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIceIehd, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaMonto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCodControl, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNroAutorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtRegRUCDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNroRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaAnio, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaMes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFechaDia, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblGestion, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEmpresaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEmpresaRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSucursalCod, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblIVA, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblRegRUCDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblNroRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtResponsableCI, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtResponsableDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaMontoTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaMontoPag, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIceIehdTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIceIehdPag, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtExentoTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtExentoPag, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNetoTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNetoPag, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIVATot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIVAPag, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtIVA, Me.txtNeto, Me.txtExento, Me.txtIceIehd, Me.txtFacturaMonto, Me.txtCodControl, Me.txtNroAutorizacion, Me.txtFacturaNro, Me.txtRegRUCDes, Me.txtNroRUC, Me.txtFechaAnio, Me.txtFechaMes, Me.txtFechaDia, Me.pgbDetail})
      Me.Detail.Height = 0.125!
      Me.Detail.Name = "Detail"
      '
      'txtIVA
      '
      Me.txtIVA.Border.BottomColor = System.Drawing.Color.Black
      Me.txtIVA.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIVA.Border.LeftColor = System.Drawing.Color.Black
      Me.txtIVA.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIVA.Border.RightColor = System.Drawing.Color.Black
      Me.txtIVA.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIVA.Border.TopColor = System.Drawing.Color.Black
      Me.txtIVA.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIVA.DataField = "IVA"
      Me.txtIVA.Height = 0.125!
      Me.txtIVA.Left = 9.5625!
      Me.txtIVA.Name = "txtIVA"
      Me.txtIVA.OutputFormat = resources.GetString("txtIVA.OutputFormat")
      Me.txtIVA.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtIVA.Text = "IVA"
      Me.txtIVA.Top = 0.0!
      Me.txtIVA.Width = 0.8125!
      '
      'txtNeto
      '
      Me.txtNeto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtNeto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNeto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtNeto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNeto.Border.RightColor = System.Drawing.Color.Black
      Me.txtNeto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNeto.Border.TopColor = System.Drawing.Color.Black
      Me.txtNeto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNeto.DataField = "Neto"
      Me.txtNeto.Height = 0.125!
      Me.txtNeto.Left = 8.75!
      Me.txtNeto.Name = "txtNeto"
      Me.txtNeto.OutputFormat = resources.GetString("txtNeto.OutputFormat")
      Me.txtNeto.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtNeto.Text = "Neto"
      Me.txtNeto.Top = 0.0!
      Me.txtNeto.Width = 0.8125!
      '
      'txtExento
      '
      Me.txtExento.Border.BottomColor = System.Drawing.Color.Black
      Me.txtExento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtExento.Border.LeftColor = System.Drawing.Color.Black
      Me.txtExento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtExento.Border.RightColor = System.Drawing.Color.Black
      Me.txtExento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtExento.Border.TopColor = System.Drawing.Color.Black
      Me.txtExento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtExento.DataField = "Exento"
      Me.txtExento.Height = 0.125!
      Me.txtExento.Left = 8.0625!
      Me.txtExento.Name = "txtExento"
      Me.txtExento.OutputFormat = resources.GetString("txtExento.OutputFormat")
      Me.txtExento.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtExento.Text = "Exento"
      Me.txtExento.Top = 0.0!
      Me.txtExento.Width = 0.6875!
      '
      'txtIceIehd
      '
      Me.txtIceIehd.Border.BottomColor = System.Drawing.Color.Black
      Me.txtIceIehd.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIceIehd.Border.LeftColor = System.Drawing.Color.Black
      Me.txtIceIehd.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIceIehd.Border.RightColor = System.Drawing.Color.Black
      Me.txtIceIehd.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIceIehd.Border.TopColor = System.Drawing.Color.Black
      Me.txtIceIehd.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIceIehd.DataField = "IceIehd"
      Me.txtIceIehd.Height = 0.125!
      Me.txtIceIehd.Left = 7.375!
      Me.txtIceIehd.Name = "txtIceIehd"
      Me.txtIceIehd.OutputFormat = resources.GetString("txtIceIehd.OutputFormat")
      Me.txtIceIehd.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtIceIehd.Text = "IceIehd"
      Me.txtIceIehd.Top = 0.0!
      Me.txtIceIehd.Width = 0.6875!
      '
      'txtFacturaMonto
      '
      Me.txtFacturaMonto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFacturaMonto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMonto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFacturaMonto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaMonto.Border.RightColor = System.Drawing.Color.Black
      Me.txtFacturaMonto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMonto.Border.TopColor = System.Drawing.Color.Black
      Me.txtFacturaMonto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaMonto.DataField = "FacturaMonto"
      Me.txtFacturaMonto.Height = 0.125!
      Me.txtFacturaMonto.Left = 6.5625!
      Me.txtFacturaMonto.Name = "txtFacturaMonto"
      Me.txtFacturaMonto.OutputFormat = resources.GetString("txtFacturaMonto.OutputFormat")
      Me.txtFacturaMonto.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtFacturaMonto.Text = "FacturaMonto"
      Me.txtFacturaMonto.Top = 0.0!
      Me.txtFacturaMonto.Width = 0.8125!
      '
      'txtCodControl
      '
      Me.txtCodControl.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCodControl.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCodControl.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCodControl.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCodControl.Border.RightColor = System.Drawing.Color.Black
      Me.txtCodControl.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtCodControl.Border.TopColor = System.Drawing.Color.Black
      Me.txtCodControl.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCodControl.DataField = "CodControl"
      Me.txtCodControl.Height = 0.125!
      Me.txtCodControl.Left = 5.625!
      Me.txtCodControl.Name = "txtCodControl"
      Me.txtCodControl.Style = "ddo-char-set: 1; font-size: 7pt; "
      Me.txtCodControl.Text = "CodControl"
      Me.txtCodControl.Top = 0.0!
      Me.txtCodControl.Width = 0.9375!
      '
      'txtNroAutorizacion
      '
      Me.txtNroAutorizacion.Border.BottomColor = System.Drawing.Color.Black
      Me.txtNroAutorizacion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNroAutorizacion.Border.LeftColor = System.Drawing.Color.Black
      Me.txtNroAutorizacion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNroAutorizacion.Border.RightColor = System.Drawing.Color.Black
      Me.txtNroAutorizacion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNroAutorizacion.Border.TopColor = System.Drawing.Color.Black
      Me.txtNroAutorizacion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNroAutorizacion.DataField = "NroAutorizacion"
      Me.txtNroAutorizacion.Height = 0.125!
      Me.txtNroAutorizacion.Left = 4.6875!
      Me.txtNroAutorizacion.Name = "txtNroAutorizacion"
      Me.txtNroAutorizacion.Style = "ddo-char-set: 1; font-size: 7pt; "
      Me.txtNroAutorizacion.Text = "NroAutorizacion"
      Me.txtNroAutorizacion.Top = 0.0!
      Me.txtNroAutorizacion.Width = 0.9375!
      '
      'txtFacturaNro
      '
      Me.txtFacturaNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFacturaNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFacturaNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtFacturaNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtFacturaNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaNro.DataField = "FacturaNro"
      Me.txtFacturaNro.Height = 0.125!
      Me.txtFacturaNro.Left = 3.6875!
      Me.txtFacturaNro.Name = "txtFacturaNro"
      Me.txtFacturaNro.Style = "ddo-char-set: 1; font-size: 7pt; "
      Me.txtFacturaNro.Text = "FacturaNro"
      Me.txtFacturaNro.Top = 0.0!
      Me.txtFacturaNro.Width = 1.0!
      '
      'txtRegRUCDes
      '
      Me.txtRegRUCDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtRegRUCDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtRegRUCDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtRegRUCDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtRegRUCDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtRegRUCDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtRegRUCDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtRegRUCDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtRegRUCDes.DataField = "RegRUCDes"
      Me.txtRegRUCDes.Height = 0.125!
      Me.txtRegRUCDes.Left = 1.5625!
      Me.txtRegRUCDes.Name = "txtRegRUCDes"
      Me.txtRegRUCDes.Style = "ddo-char-set: 1; font-size: 7pt; "
      Me.txtRegRUCDes.Text = "RegRUCDes"
      Me.txtRegRUCDes.Top = 0.0!
      Me.txtRegRUCDes.Width = 2.125!
      '
      'txtNroRUC
      '
      Me.txtNroRUC.Border.BottomColor = System.Drawing.Color.Black
      Me.txtNroRUC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNroRUC.Border.LeftColor = System.Drawing.Color.Black
      Me.txtNroRUC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNroRUC.Border.RightColor = System.Drawing.Color.Black
      Me.txtNroRUC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNroRUC.Border.TopColor = System.Drawing.Color.Black
      Me.txtNroRUC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNroRUC.DataField = "NroRUC"
      Me.txtNroRUC.Height = 0.125!
      Me.txtNroRUC.Left = 0.6875!
      Me.txtNroRUC.Name = "txtNroRUC"
      Me.txtNroRUC.Style = "ddo-char-set: 1; font-size: 7pt; "
      Me.txtNroRUC.Text = "NroRUC"
      Me.txtNroRUC.Top = 0.0!
      Me.txtNroRUC.Width = 0.875!
      '
      'txtFechaAnio
      '
      Me.txtFechaAnio.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaAnio.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaAnio.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaAnio.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaAnio.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaAnio.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaAnio.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaAnio.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaAnio.DataField = "FacturaFecha"
      Me.txtFechaAnio.Height = 0.125!
      Me.txtFechaAnio.Left = 0.375!
      Me.txtFechaAnio.Name = "txtFechaAnio"
      Me.txtFechaAnio.OutputFormat = resources.GetString("txtFechaAnio.OutputFormat")
      Me.txtFechaAnio.Style = "ddo-char-set: 1; text-decoration: none; text-align: center; font-size: 7pt; "
      Me.txtFechaAnio.Text = "FacturaFecha"
      Me.txtFechaAnio.Top = 0.0!
      Me.txtFechaAnio.Width = 0.3125!
      '
      'txtFechaMes
      '
      Me.txtFechaMes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaMes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaMes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaMes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaMes.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaMes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaMes.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaMes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaMes.DataField = "FacturaFecha"
      Me.txtFechaMes.Height = 0.125!
      Me.txtFechaMes.Left = 0.1875!
      Me.txtFechaMes.Name = "txtFechaMes"
      Me.txtFechaMes.OutputFormat = resources.GetString("txtFechaMes.OutputFormat")
      Me.txtFechaMes.Style = "ddo-char-set: 1; text-align: center; font-size: 7pt; "
      Me.txtFechaMes.Text = "FacturaFecha"
      Me.txtFechaMes.Top = 0.0!
      Me.txtFechaMes.Width = 0.1875!
      '
      'txtFechaDia
      '
      Me.txtFechaDia.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFechaDia.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaDia.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFechaDia.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaDia.Border.RightColor = System.Drawing.Color.Black
      Me.txtFechaDia.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFechaDia.Border.TopColor = System.Drawing.Color.Black
      Me.txtFechaDia.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFechaDia.DataField = "FacturaFecha"
      Me.txtFechaDia.Height = 0.125!
      Me.txtFechaDia.Left = 0.0!
      Me.txtFechaDia.Name = "txtFechaDia"
      Me.txtFechaDia.OutputFormat = resources.GetString("txtFechaDia.OutputFormat")
      Me.txtFechaDia.Style = "ddo-char-set: 1; text-align: center; font-size: 7pt; "
      Me.txtFechaDia.Text = "FacturaFecha"
      Me.txtFechaDia.Top = 0.0!
      Me.txtFechaDia.Width = 0.1875!
      '
      'pgbDetail
      '
      Me.pgbDetail.Border.BottomColor = System.Drawing.Color.Black
      Me.pgbDetail.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.pgbDetail.Border.LeftColor = System.Drawing.Color.Black
      Me.pgbDetail.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.pgbDetail.Border.RightColor = System.Drawing.Color.Black
      Me.pgbDetail.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.pgbDetail.Border.TopColor = System.Drawing.Color.Black
      Me.pgbDetail.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.pgbDetail.Enabled = False
      Me.pgbDetail.Height = 0.0625!
      Me.pgbDetail.Left = 0.0!
      Me.pgbDetail.Name = "pgbDetail"
      Me.pgbDetail.Size = New System.Drawing.SizeF(6.5!, 0.0625!)
      Me.pgbDetail.Top = 0.0!
      Me.pgbDetail.Width = 6.5!
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
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitle, Me.lblMes, Me.lblGestion, Me.Shape, Me.Label, Me.txtEmpresaDes, Me.Label1, Me.txtEmpresaRUC, Me.Label2, Me.txtSucursalCod, Me.txtDireccion, Me.Label3, Me.TextBox9, Me.txtPageCount, Me.txtPageNOfM, Me.Label4, Me.Label7, Me.lblIVA, Me.TextBox42, Me.TextBox41, Me.TextBox6, Me.TextBox5, Me.TextBox30, Me.TextBox29, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.lblRegRUCDes, Me.lblNroRUC, Me.TextBox7, Me.TextBox})
      Me.PageHeader.Height = 1.5!
      Me.PageHeader.Name = "PageHeader"
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
      Me.lblTitle.Height = 0.1875!
      Me.lblTitle.HyperLink = Nothing
      Me.lblTitle.Left = 0.0!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "ddo-char-set: 1; font-weight: bold; font-size: 13pt; "
      Me.lblTitle.Text = "LIBRO DE COMPRAS IVA DEL PERIODO"
      Me.lblTitle.Top = 0.0!
      Me.lblTitle.Width = 3.5625!
      '
      'lblMes
      '
      Me.lblMes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblMes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblMes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblMes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblMes.Border.RightColor = System.Drawing.Color.Black
      Me.lblMes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblMes.Border.TopColor = System.Drawing.Color.Black
      Me.lblMes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblMes.Height = 0.1875!
      Me.lblMes.HyperLink = Nothing
      Me.lblMes.Left = 3.5625!
      Me.lblMes.Name = "lblMes"
      Me.lblMes.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; "
      Me.lblMes.Text = ""
      Me.lblMes.Top = 0.0!
      Me.lblMes.Width = 0.375!
      '
      'lblGestion
      '
      Me.lblGestion.Border.BottomColor = System.Drawing.Color.Black
      Me.lblGestion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblGestion.Border.LeftColor = System.Drawing.Color.Black
      Me.lblGestion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblGestion.Border.RightColor = System.Drawing.Color.Black
      Me.lblGestion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblGestion.Border.TopColor = System.Drawing.Color.Black
      Me.lblGestion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblGestion.Height = 0.1875!
      Me.lblGestion.HyperLink = Nothing
      Me.lblGestion.Left = 3.9375!
      Me.lblGestion.Name = "lblGestion"
      Me.lblGestion.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; "
      Me.lblGestion.Text = ""
      Me.lblGestion.Top = 0.0!
      Me.lblGestion.Width = 0.5625!
      '
      'Shape
      '
      Me.Shape.Border.BottomColor = System.Drawing.Color.Black
      Me.Shape.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape.Border.LeftColor = System.Drawing.Color.Black
      Me.Shape.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape.Border.RightColor = System.Drawing.Color.Black
      Me.Shape.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape.Border.TopColor = System.Drawing.Color.Black
      Me.Shape.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Shape.Height = 0.5625!
      Me.Shape.Left = 0.0!
      Me.Shape.Name = "Shape"
      Me.Shape.RoundingRadius = 9.999999!
      Me.Shape.Top = 0.3125!
      Me.Shape.Width = 8.25!
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
      Me.Label.Height = 0.1875!
      Me.Label.HyperLink = Nothing
      Me.Label.Left = 0.0625!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label.Text = "NOMBRE O RAZÓN SOCIAL:"
      Me.Label.Top = 0.375!
      Me.Label.Width = 1.625!
      '
      'txtEmpresaDes
      '
      Me.txtEmpresaDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEmpresaDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEmpresaDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEmpresaDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEmpresaDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtEmpresaDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEmpresaDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtEmpresaDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEmpresaDes.Height = 0.1875!
      Me.txtEmpresaDes.Left = 1.75!
      Me.txtEmpresaDes.Name = "txtEmpresaDes"
      Me.txtEmpresaDes.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtEmpresaDes.Text = Nothing
      Me.txtEmpresaDes.Top = 0.375!
      Me.txtEmpresaDes.Width = 4.0625!
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
      Me.Label1.Left = 6.625!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label1.Text = "NIT:"
      Me.Label1.Top = 0.375!
      Me.Label1.Width = 0.3125!
      '
      'txtEmpresaRUC
      '
      Me.txtEmpresaRUC.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEmpresaRUC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEmpresaRUC.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEmpresaRUC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEmpresaRUC.Border.RightColor = System.Drawing.Color.Black
      Me.txtEmpresaRUC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEmpresaRUC.Border.TopColor = System.Drawing.Color.Black
      Me.txtEmpresaRUC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEmpresaRUC.Height = 0.1875!
      Me.txtEmpresaRUC.Left = 7.0!
      Me.txtEmpresaRUC.Name = "txtEmpresaRUC"
      Me.txtEmpresaRUC.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; vertical-align: middle; "
      Me.txtEmpresaRUC.Text = Nothing
      Me.txtEmpresaRUC.Top = 0.375!
      Me.txtEmpresaRUC.Width = 1.1875!
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
      Me.Label2.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label2.Text = "Nº. SUCURSAL:"
      Me.Label2.Top = 0.625!
      Me.Label2.Width = 1.625!
      '
      'txtSucursalCod
      '
      Me.txtSucursalCod.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSucursalCod.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSucursalCod.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSucursalCod.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSucursalCod.Border.RightColor = System.Drawing.Color.Black
      Me.txtSucursalCod.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSucursalCod.Border.TopColor = System.Drawing.Color.Black
      Me.txtSucursalCod.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSucursalCod.Height = 0.1875!
      Me.txtSucursalCod.Left = 1.75!
      Me.txtSucursalCod.Name = "txtSucursalCod"
      Me.txtSucursalCod.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; vertical-align: middle; "
      Me.txtSucursalCod.Text = Nothing
      Me.txtSucursalCod.Top = 0.625!
      Me.txtSucursalCod.Width = 0.75!
      '
      'txtDireccion
      '
      Me.txtDireccion.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDireccion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDireccion.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDireccion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDireccion.Border.RightColor = System.Drawing.Color.Black
      Me.txtDireccion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDireccion.Border.TopColor = System.Drawing.Color.Black
      Me.txtDireccion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDireccion.Height = 0.1875!
      Me.txtDireccion.Left = 3.5625!
      Me.txtDireccion.Name = "txtDireccion"
      Me.txtDireccion.Style = "ddo-char-set: 1; font-size: 8pt; vertical-align: middle; "
      Me.txtDireccion.Text = Nothing
      Me.txtDireccion.Top = 0.625!
      Me.txtDireccion.Width = 4.625!
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
      Me.Label3.Left = 2.75!
      Me.Label3.Name = "Label3"
      Me.Label3.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label3.Text = "DIRECCIÓN:"
      Me.Label3.Top = 0.625!
      Me.Label3.Width = 0.75!
      '
      'TextBox9
      '
      Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox9.Height = 0.1875!
      Me.TextBox9.Left = 6.5625!
      Me.TextBox9.Name = "TextBox9"
      Me.TextBox9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.TextBox9.Text = "CIFRAS EN BOLIVIANOS"
      Me.TextBox9.Top = 1.0!
      Me.TextBox9.Width = 3.8125!
      '
      'txtPageCount
      '
      Me.txtPageCount.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPageCount.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageCount.Border.RightColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPageCount.Border.TopColor = System.Drawing.Color.Black
      Me.txtPageCount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPageCount.Height = 0.1875!
      Me.txtPageCount.Left = 9.9375!
      Me.txtPageCount.MultiLine = False
      Me.txtPageCount.Name = "txtPageCount"
      Me.txtPageCount.Style = "ddo-char-set: 1; text-align: left; font-size: 8pt; vertical-align: middle; "
      Me.txtPageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageCount.Text = "PageCount"
      Me.txtPageCount.Top = 0.0!
      Me.txtPageCount.Width = 0.4375!
      '
      'txtPageNOfM
      '
      Me.txtPageNOfM.Border.BottomColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPageNOfM.Border.LeftColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPageNOfM.Border.RightColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtPageNOfM.Border.TopColor = System.Drawing.Color.Black
      Me.txtPageNOfM.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtPageNOfM.Height = 0.1875!
      Me.txtPageNOfM.Left = 9.3125!
      Me.txtPageNOfM.MultiLine = False
      Me.txtPageNOfM.Name = "txtPageNOfM"
      Me.txtPageNOfM.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; vertical-align: middle; "
      Me.txtPageNOfM.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
      Me.txtPageNOfM.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
      Me.txtPageNOfM.Text = "PageNumber"
      Me.txtPageNOfM.Top = 0.0!
      Me.txtPageNOfM.Width = 0.4375!
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
      Me.Label4.Left = 9.75!
      Me.Label4.MultiLine = False
      Me.Label4.Name = "Label4"
      Me.Label4.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; vertical-align: middle; "
      Me.Label4.Text = "de"
      Me.Label4.Top = 0.0!
      Me.Label4.Width = 0.1875!
      '
      'Label7
      '
      Me.Label7.Border.BottomColor = System.Drawing.Color.Black
      Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.LeftColor = System.Drawing.Color.Black
      Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.RightColor = System.Drawing.Color.Black
      Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Border.TopColor = System.Drawing.Color.Black
      Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label7.Height = 0.1875!
      Me.Label7.HyperLink = Nothing
      Me.Label7.Left = 8.8125!
      Me.Label7.Name = "Label7"
      Me.Label7.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; "
      Me.Label7.Text = "FOLIO"
      Me.Label7.Top = 0.0!
      Me.Label7.Width = 0.5!
      '
      'lblIVA
      '
      Me.lblIVA.Border.BottomColor = System.Drawing.Color.Black
      Me.lblIVA.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblIVA.Border.LeftColor = System.Drawing.Color.Black
      Me.lblIVA.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblIVA.Border.RightColor = System.Drawing.Color.Black
      Me.lblIVA.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblIVA.Border.TopColor = System.Drawing.Color.Black
      Me.lblIVA.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblIVA.Height = 0.3125!
      Me.lblIVA.Left = 9.5625!
      Me.lblIVA.Name = "lblIVA"
      Me.lblIVA.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.lblIVA.Text = "CRÉDITO FISCAL I.V.A."
      Me.lblIVA.Top = 1.1875!
      Me.lblIVA.Width = 0.8125!
      '
      'TextBox42
      '
      Me.TextBox42.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox42.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox42.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox42.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox42.Height = 0.3125!
      Me.TextBox42.Left = 8.75!
      Me.TextBox42.Name = "TextBox42"
      Me.TextBox42.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; white-spa" & _
          "ce: inherit; vertical-align: middle; "
      Me.TextBox42.Text = "IMPORTE NETO (A-B-C)"
      Me.TextBox42.Top = 1.1875!
      Me.TextBox42.Width = 0.8125!
      '
      'TextBox41
      '
      Me.TextBox41.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox41.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox41.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox41.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox41.Height = 0.3125!
      Me.TextBox41.Left = 8.0625!
      Me.TextBox41.Name = "TextBox41"
      Me.TextBox41.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.TextBox41.Text = "IMPORTE EXENTO (C)"
      Me.TextBox41.Top = 1.1875!
      Me.TextBox41.Width = 0.6875!
      '
      'TextBox6
      '
      Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.CanGrow = False
      Me.TextBox6.Height = 0.125!
      Me.TextBox6.Left = 0.1875!
      Me.TextBox6.Name = "TextBox6"
      Me.TextBox6.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 7pt; vertical-" & _
          "align: middle; "
      Me.TextBox6.Text = "M"
      Me.TextBox6.Top = 1.375!
      Me.TextBox6.Width = 0.1875!
      '
      'TextBox5
      '
      Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.CanGrow = False
      Me.TextBox5.Height = 0.125!
      Me.TextBox5.Left = 0.0!
      Me.TextBox5.Name = "TextBox5"
      Me.TextBox5.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 7pt; vertical-" & _
          "align: middle; "
      Me.TextBox5.Text = "D"
      Me.TextBox5.Top = 1.375!
      Me.TextBox5.Width = 0.1875!
      '
      'TextBox30
      '
      Me.TextBox30.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox30.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox30.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox30.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox30.Height = 0.3125!
      Me.TextBox30.Left = 7.375!
      Me.TextBox30.Name = "TextBox30"
      Me.TextBox30.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.TextBox30.Text = "TOTAL I.C.E. (B)"
      Me.TextBox30.Top = 1.1875!
      Me.TextBox30.Width = 0.6875!
      '
      'TextBox29
      '
      Me.TextBox29.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox29.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox29.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox29.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox29.Height = 0.3125!
      Me.TextBox29.Left = 6.5625!
      Me.TextBox29.Name = "TextBox29"
      Me.TextBox29.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.TextBox29.Text = "TOTAL FACTURA (A)"
      Me.TextBox29.Top = 1.1875!
      Me.TextBox29.Width = 0.8125!
      '
      'TextBox14
      '
      Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox14.Height = 0.3125!
      Me.TextBox14.Left = 5.625!
      Me.TextBox14.Name = "TextBox14"
      Me.TextBox14.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.TextBox14.Text = "CÓDIGO DE CONTROL"
      Me.TextBox14.Top = 1.1875!
      Me.TextBox14.Width = 0.9375!
      '
      'TextBox15
      '
      Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox15.Height = 0.3125!
      Me.TextBox15.Left = 4.6875!
      Me.TextBox15.Name = "TextBox15"
      Me.TextBox15.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.TextBox15.Text = "Nº DE AUTORIZACIÓN"
      Me.TextBox15.Top = 1.1875!
      Me.TextBox15.Width = 0.9375!
      '
      'TextBox16
      '
      Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox16.Height = 0.3125!
      Me.TextBox16.Left = 3.6875!
      Me.TextBox16.Name = "TextBox16"
      Me.TextBox16.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.TextBox16.Text = "Nº DE FACTURA"
      Me.TextBox16.Top = 1.1875!
      Me.TextBox16.Width = 1.0!
      '
      'lblRegRUCDes
      '
      Me.lblRegRUCDes.Border.BottomColor = System.Drawing.Color.Black
      Me.lblRegRUCDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblRegRUCDes.Border.LeftColor = System.Drawing.Color.Black
      Me.lblRegRUCDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblRegRUCDes.Border.RightColor = System.Drawing.Color.Black
      Me.lblRegRUCDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblRegRUCDes.Border.TopColor = System.Drawing.Color.Black
      Me.lblRegRUCDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblRegRUCDes.Height = 0.3125!
      Me.lblRegRUCDes.Left = 1.5625!
      Me.lblRegRUCDes.Name = "lblRegRUCDes"
      Me.lblRegRUCDes.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.lblRegRUCDes.Text = "NOMBRE O RAZÓN SOCIAL DEL PROVEEDOR"
      Me.lblRegRUCDes.Top = 1.1875!
      Me.lblRegRUCDes.Width = 2.125!
      '
      'lblNroRUC
      '
      Me.lblNroRUC.Border.BottomColor = System.Drawing.Color.Black
      Me.lblNroRUC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblNroRUC.Border.LeftColor = System.Drawing.Color.Black
      Me.lblNroRUC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblNroRUC.Border.RightColor = System.Drawing.Color.Black
      Me.lblNroRUC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblNroRUC.Border.TopColor = System.Drawing.Color.Black
      Me.lblNroRUC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblNroRUC.Height = 0.3125!
      Me.lblNroRUC.Left = 0.6875!
      Me.lblNroRUC.Name = "lblNroRUC"
      Me.lblNroRUC.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.lblNroRUC.Text = "Nº DE NIT DEL PROVEEDOR"
      Me.lblNroRUC.Top = 1.1875!
      Me.lblNroRUC.Width = 0.875!
      '
      'TextBox7
      '
      Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.CanGrow = False
      Me.TextBox7.Height = 0.125!
      Me.TextBox7.Left = 0.375!
      Me.TextBox7.Name = "TextBox7"
      Me.TextBox7.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 7pt; vertical-" & _
          "align: middle; "
      Me.TextBox7.Text = "A"
      Me.TextBox7.Top = 1.375!
      Me.TextBox7.Width = 0.3125!
      '
      'TextBox
      '
      Me.TextBox.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox.CanGrow = False
      Me.TextBox.Height = 0.1875!
      Me.TextBox.Left = 0.0!
      Me.TextBox.Name = "TextBox"
      Me.TextBox.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; vertical-" & _
          "align: middle; "
      Me.TextBox.Text = "FECHA"
      Me.TextBox.Top = 1.1875!
      Me.TextBox.Width = 0.6875!
      '
      'PageFooter
      '
      Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label5, Me.txtResponsableCI, Me.Label6, Me.txtResponsableDes, Me.txtFacturaMontoTot, Me.txtFacturaMontoPag, Me.txtIceIehdTot, Me.txtIceIehdPag, Me.txtExentoTot, Me.txtExentoPag, Me.txtNetoTot, Me.txtNetoPag, Me.txtIVATot, Me.txtIVAPag, Me.Label8, Me.Label9})
      Me.PageFooter.Height = 0.4472222!
      Me.PageFooter.Name = "PageFooter"
      '
      'Label5
      '
      Me.Label5.Border.BottomColor = System.Drawing.Color.Black
      Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Border.LeftColor = System.Drawing.Color.Black
      Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Border.RightColor = System.Drawing.Color.Black
      Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label5.Border.TopColor = System.Drawing.Color.Black
      Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label5.Height = 0.1875!
      Me.Label5.HyperLink = Nothing
      Me.Label5.Left = 0.0!
      Me.Label5.Name = "Label5"
      Me.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertic" & _
          "al-align: middle; "
      Me.Label5.Text = "C.I."
      Me.Label5.Top = 0.25!
      Me.Label5.Width = 1.625!
      '
      'txtResponsableCI
      '
      Me.txtResponsableCI.Border.BottomColor = System.Drawing.Color.Black
      Me.txtResponsableCI.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtResponsableCI.Border.LeftColor = System.Drawing.Color.Black
      Me.txtResponsableCI.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtResponsableCI.Border.RightColor = System.Drawing.Color.Black
      Me.txtResponsableCI.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtResponsableCI.Border.TopColor = System.Drawing.Color.Black
      Me.txtResponsableCI.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtResponsableCI.Height = 0.1875!
      Me.txtResponsableCI.Left = 0.0!
      Me.txtResponsableCI.Name = "txtResponsableCI"
      Me.txtResponsableCI.Style = "ddo-char-set: 1; text-align: center; font-size: 7pt; vertical-align: middle; "
      Me.txtResponsableCI.Text = Nothing
      Me.txtResponsableCI.Top = 0.0625!
      Me.txtResponsableCI.Width = 1.625!
      '
      'Label6
      '
      Me.Label6.Border.BottomColor = System.Drawing.Color.Black
      Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Border.LeftColor = System.Drawing.Color.Black
      Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Border.RightColor = System.Drawing.Color.Black
      Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label6.Border.TopColor = System.Drawing.Color.Black
      Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label6.Height = 0.1875!
      Me.Label6.HyperLink = Nothing
      Me.Label6.Left = 2.0!
      Me.Label6.Name = "Label6"
      Me.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertic" & _
          "al-align: middle; "
      Me.Label6.Text = "NOMBRE COMPLETO DEL RESPONSABLE"
      Me.Label6.Top = 0.25!
      Me.Label6.Width = 3.1875!
      '
      'txtResponsableDes
      '
      Me.txtResponsableDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtResponsableDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtResponsableDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtResponsableDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtResponsableDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtResponsableDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtResponsableDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtResponsableDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtResponsableDes.Height = 0.1875!
      Me.txtResponsableDes.Left = 2.0!
      Me.txtResponsableDes.Name = "txtResponsableDes"
      Me.txtResponsableDes.Style = "ddo-char-set: 1; text-align: center; font-size: 7pt; vertical-align: middle; "
      Me.txtResponsableDes.Text = Nothing
      Me.txtResponsableDes.Top = 0.0625!
      Me.txtResponsableDes.Width = 3.1875!
      '
      'txtFacturaMontoTot
      '
      Me.txtFacturaMontoTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFacturaMontoTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFacturaMontoTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtFacturaMontoTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtFacturaMontoTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaMontoTot.Height = 0.1875!
      Me.txtFacturaMontoTot.Left = 6.5625!
      Me.txtFacturaMontoTot.Name = "txtFacturaMontoTot"
      Me.txtFacturaMontoTot.OutputFormat = resources.GetString("txtFacturaMontoTot.OutputFormat")
      Me.txtFacturaMontoTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtFacturaMontoTot.Text = "FacturaMontoTot"
      Me.txtFacturaMontoTot.Top = 0.25!
      Me.txtFacturaMontoTot.Width = 0.8125!
      '
      'txtFacturaMontoPag
      '
      Me.txtFacturaMontoPag.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFacturaMontoPag.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoPag.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFacturaMontoPag.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoPag.Border.RightColor = System.Drawing.Color.Black
      Me.txtFacturaMontoPag.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoPag.Border.TopColor = System.Drawing.Color.Black
      Me.txtFacturaMontoPag.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoPag.DataField = "FacturaMonto"
      Me.txtFacturaMontoPag.Height = 0.1875!
      Me.txtFacturaMontoPag.Left = 6.5625!
      Me.txtFacturaMontoPag.Name = "txtFacturaMontoPag"
      Me.txtFacturaMontoPag.OutputFormat = resources.GetString("txtFacturaMontoPag.OutputFormat")
      Me.txtFacturaMontoPag.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtFacturaMontoPag.SummaryGroup = "Detail"
      Me.txtFacturaMontoPag.SummaryType = DataDynamics.ActiveReports.SummaryType.PageTotal
      Me.txtFacturaMontoPag.Text = "FacturaMontoPag"
      Me.txtFacturaMontoPag.Top = 0.0625!
      Me.txtFacturaMontoPag.Width = 0.8125!
      '
      'txtIceIehdTot
      '
      Me.txtIceIehdTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtIceIehdTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIceIehdTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtIceIehdTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIceIehdTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtIceIehdTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIceIehdTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtIceIehdTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIceIehdTot.Height = 0.1875!
      Me.txtIceIehdTot.Left = 7.375!
      Me.txtIceIehdTot.Name = "txtIceIehdTot"
      Me.txtIceIehdTot.OutputFormat = resources.GetString("txtIceIehdTot.OutputFormat")
      Me.txtIceIehdTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtIceIehdTot.Text = "IceIehdTot"
      Me.txtIceIehdTot.Top = 0.25!
      Me.txtIceIehdTot.Width = 0.6875!
      '
      'txtIceIehdPag
      '
      Me.txtIceIehdPag.Border.BottomColor = System.Drawing.Color.Black
      Me.txtIceIehdPag.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIceIehdPag.Border.LeftColor = System.Drawing.Color.Black
      Me.txtIceIehdPag.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIceIehdPag.Border.RightColor = System.Drawing.Color.Black
      Me.txtIceIehdPag.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIceIehdPag.Border.TopColor = System.Drawing.Color.Black
      Me.txtIceIehdPag.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIceIehdPag.DataField = "IceIehd"
      Me.txtIceIehdPag.Height = 0.1875!
      Me.txtIceIehdPag.Left = 7.375!
      Me.txtIceIehdPag.Name = "txtIceIehdPag"
      Me.txtIceIehdPag.OutputFormat = resources.GetString("txtIceIehdPag.OutputFormat")
      Me.txtIceIehdPag.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtIceIehdPag.SummaryGroup = "Detail"
      Me.txtIceIehdPag.SummaryType = DataDynamics.ActiveReports.SummaryType.PageTotal
      Me.txtIceIehdPag.Text = "IceIehdPag"
      Me.txtIceIehdPag.Top = 0.0625!
      Me.txtIceIehdPag.Width = 0.6875!
      '
      'txtExentoTot
      '
      Me.txtExentoTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtExentoTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtExentoTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtExentoTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtExentoTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtExentoTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtExentoTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtExentoTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtExentoTot.Height = 0.1875!
      Me.txtExentoTot.Left = 8.0625!
      Me.txtExentoTot.Name = "txtExentoTot"
      Me.txtExentoTot.OutputFormat = resources.GetString("txtExentoTot.OutputFormat")
      Me.txtExentoTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtExentoTot.Text = "ExentoTot"
      Me.txtExentoTot.Top = 0.25!
      Me.txtExentoTot.Width = 0.6875!
      '
      'txtExentoPag
      '
      Me.txtExentoPag.Border.BottomColor = System.Drawing.Color.Black
      Me.txtExentoPag.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtExentoPag.Border.LeftColor = System.Drawing.Color.Black
      Me.txtExentoPag.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtExentoPag.Border.RightColor = System.Drawing.Color.Black
      Me.txtExentoPag.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtExentoPag.Border.TopColor = System.Drawing.Color.Black
      Me.txtExentoPag.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtExentoPag.DataField = "Exento"
      Me.txtExentoPag.Height = 0.1875!
      Me.txtExentoPag.Left = 8.0625!
      Me.txtExentoPag.Name = "txtExentoPag"
      Me.txtExentoPag.OutputFormat = resources.GetString("txtExentoPag.OutputFormat")
      Me.txtExentoPag.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtExentoPag.SummaryGroup = "Detail"
      Me.txtExentoPag.SummaryType = DataDynamics.ActiveReports.SummaryType.PageTotal
      Me.txtExentoPag.Text = "ExentoPag"
      Me.txtExentoPag.Top = 0.0625!
      Me.txtExentoPag.Width = 0.6875!
      '
      'txtNetoTot
      '
      Me.txtNetoTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtNetoTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNetoTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtNetoTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNetoTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtNetoTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNetoTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtNetoTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNetoTot.Height = 0.1875!
      Me.txtNetoTot.Left = 8.75!
      Me.txtNetoTot.Name = "txtNetoTot"
      Me.txtNetoTot.OutputFormat = resources.GetString("txtNetoTot.OutputFormat")
      Me.txtNetoTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtNetoTot.Text = "NetoTot"
      Me.txtNetoTot.Top = 0.25!
      Me.txtNetoTot.Width = 0.8125!
      '
      'txtNetoPag
      '
      Me.txtNetoPag.Border.BottomColor = System.Drawing.Color.Black
      Me.txtNetoPag.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNetoPag.Border.LeftColor = System.Drawing.Color.Black
      Me.txtNetoPag.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNetoPag.Border.RightColor = System.Drawing.Color.Black
      Me.txtNetoPag.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNetoPag.Border.TopColor = System.Drawing.Color.Black
      Me.txtNetoPag.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNetoPag.DataField = "Neto"
      Me.txtNetoPag.Height = 0.1875!
      Me.txtNetoPag.Left = 8.75!
      Me.txtNetoPag.Name = "txtNetoPag"
      Me.txtNetoPag.OutputFormat = resources.GetString("txtNetoPag.OutputFormat")
      Me.txtNetoPag.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtNetoPag.SummaryGroup = "Detail"
      Me.txtNetoPag.SummaryType = DataDynamics.ActiveReports.SummaryType.PageTotal
      Me.txtNetoPag.Text = "NetoPag"
      Me.txtNetoPag.Top = 0.0625!
      Me.txtNetoPag.Width = 0.8125!
      '
      'txtIVATot
      '
      Me.txtIVATot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtIVATot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIVATot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtIVATot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIVATot.Border.RightColor = System.Drawing.Color.Black
      Me.txtIVATot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIVATot.Border.TopColor = System.Drawing.Color.Black
      Me.txtIVATot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIVATot.Height = 0.1875!
      Me.txtIVATot.Left = 9.5625!
      Me.txtIVATot.Name = "txtIVATot"
      Me.txtIVATot.OutputFormat = resources.GetString("txtIVATot.OutputFormat")
      Me.txtIVATot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtIVATot.Text = "IVATot"
      Me.txtIVATot.Top = 0.25!
      Me.txtIVATot.Width = 0.8125!
      '
      'txtIVAPag
      '
      Me.txtIVAPag.Border.BottomColor = System.Drawing.Color.Black
      Me.txtIVAPag.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIVAPag.Border.LeftColor = System.Drawing.Color.Black
      Me.txtIVAPag.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtIVAPag.Border.RightColor = System.Drawing.Color.Black
      Me.txtIVAPag.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIVAPag.Border.TopColor = System.Drawing.Color.Black
      Me.txtIVAPag.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIVAPag.DataField = "IVA"
      Me.txtIVAPag.Height = 0.1875!
      Me.txtIVAPag.Left = 9.5625!
      Me.txtIVAPag.Name = "txtIVAPag"
      Me.txtIVAPag.OutputFormat = resources.GetString("txtIVAPag.OutputFormat")
      Me.txtIVAPag.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtIVAPag.SummaryGroup = "Detail"
      Me.txtIVAPag.SummaryType = DataDynamics.ActiveReports.SummaryType.PageTotal
      Me.txtIVAPag.Text = "IVAPag"
      Me.txtIVAPag.Top = 0.0625!
      Me.txtIVAPag.Width = 0.8125!
      '
      'Label8
      '
      Me.Label8.Border.BottomColor = System.Drawing.Color.Black
      Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.LeftColor = System.Drawing.Color.Black
      Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.RightColor = System.Drawing.Color.Black
      Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Border.TopColor = System.Drawing.Color.Black
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label8.Height = 0.1875!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 5.625!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label8.Text = "TOTALES"
      Me.Label8.Top = 0.25!
      Me.Label8.Width = 0.9375!
      '
      'Label9
      '
      Me.Label9.Border.BottomColor = System.Drawing.Color.Black
      Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.LeftColor = System.Drawing.Color.Black
      Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.RightColor = System.Drawing.Color.Black
      Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Border.TopColor = System.Drawing.Color.Black
      Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label9.Height = 0.1875!
      Me.Label9.HyperLink = Nothing
      Me.Label9.Left = 5.625!
      Me.Label9.Name = "Label9"
      Me.Label9.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label9.Text = "PARCIALES"
      Me.Label9.Top = 0.0625!
      Me.Label9.Width = 0.9375!
      '
      'rptLibroIVAIN
      '
      Me.MasterReport = False
      Me.PageSettings.Margins.Bottom = 0.2!
      Me.PageSettings.Margins.Left = 0.2!
      Me.PageSettings.Margins.Right = 0.5!
      Me.PageSettings.Margins.Top = 0.5!
      Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
      Me.PageSettings.PaperHeight = 11.69!
      Me.PageSettings.PaperWidth = 8.27!
      Me.PrintWidth = 10.375!
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
      CType(Me.txtIVA, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNeto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtExento, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIceIehd, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaMonto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtCodControl, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNroAutorizacion, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtRegRUCDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNroRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaAnio, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaMes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFechaDia, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblGestion, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEmpresaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEmpresaRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSucursalCod, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDireccion, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtPageNOfM, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblIVA, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox42, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblRegRUCDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblNroRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtResponsableCI, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtResponsableDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaMontoTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaMontoPag, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIceIehdTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIceIehdPag, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtExentoTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtExentoPag, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNetoTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNetoPag, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIVATot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIVAPag, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.BeforePrint
      If txtRegRUCDes.Height > txtNroRUC.Height Then
         txtFechaDia.Height = txtRegRUCDes.Height
         txtFechaMes.Height = txtRegRUCDes.Height
         txtFechaAnio.Height = txtRegRUCDes.Height
         txtNroRUC.Height = txtRegRUCDes.Height
         txtRegRUCDes.Height = txtRegRUCDes.Height
         txtFacturaNro.Height = txtRegRUCDes.Height
         txtNroAutorizacion.Height = txtRegRUCDes.Height
         txtCodControl.Height = txtRegRUCDes.Height
         txtFacturaMonto.Height = txtRegRUCDes.Height
         txtIceIehd.Height = txtRegRUCDes.Height
         txtExento.Height = txtRegRUCDes.Height
         txtNeto.Height = txtRegRUCDes.Height
         txtIVA.Height = txtRegRUCDes.Height

      Else
         txtFechaDia.Height = txtNroRUC.Height
         txtFechaMes.Height = txtNroRUC.Height
         txtFechaAnio.Height = txtNroRUC.Height
         txtNroRUC.Height = txtNroRUC.Height
         txtRegRUCDes.Height = txtNroRUC.Height
         txtFacturaNro.Height = txtNroRUC.Height
         txtNroAutorizacion.Height = txtNroRUC.Height
         txtCodControl.Height = txtNroRUC.Height
         txtFacturaMonto.Height = txtNroRUC.Height
         txtIceIehd.Height = txtNroRUC.Height
         txtExento.Height = txtNroRUC.Height
         txtNeto.Height = txtNroRUC.Height
         txtIVA.Height = txtNroRUC.Height
      End If
   End Sub

   Private Sub PageFooter_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter.Format
      txtFacturaMontoTot.Value += txtFacturaMontoPag.Value
      txtIceIehdTot.Value += txtIceIehdPag.Value
      txtExentoTot.Value += txtExentoPag.Value
      txtNetoTot.Value += txtNetoPag.Value
      txtIVATot.Value += txtIVAPag.Value
   End Sub

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      If mlngMesId > 0 Then
         If ToLong(txtFechaMes.Text) <> mlngMesId Then
            mlngAnio = ToLong(txtFechaAnio.Text)
            mlngMesId = ToLong(txtFechaMes.Text)

            Me.pgbDetail.Enabled = True

         Else
            Me.pgbDetail.Enabled = False
         End If

      Else
         mlngAnio = ToLong(txtFechaAnio.Text)
         mlngMesId = ToLong(txtFechaMes.Text)
      End If
   End Sub

   Private Sub PageHeader_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader.Format
      If mlngMesId > 0 Then
         lblGestion.Text = ToStr(mlngAnio)
         lblMes.Text = ToStr(mlngMesId)
      End If
   End Sub

End Class