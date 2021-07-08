Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptLibroIVAVenta
   Inherits DataDynamics.ActiveReports.ActiveReport3

   Private mlngAnio As Long = 0
   Friend WithEvents pgbDetail As DataDynamics.ActiveReports.PageBreak
   Public WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtEstadoFac As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtIceIehd As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtExento As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtExentoTot As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtVentaTasaCeroTot As DataDynamics.ActiveReports.TextBox
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
   Private Label As DataDynamics.ActiveReports.Label
   Public txtEmpresaDes As DataDynamics.ActiveReports.TextBox
   Private Label1 As DataDynamics.ActiveReports.Label
   Public txtEmpresaRUC As DataDynamics.ActiveReports.TextBox
   Private TextBox29 As DataDynamics.ActiveReports.TextBox
   Private TextBox14 As DataDynamics.ActiveReports.TextBox
   Private TextBox15 As DataDynamics.ActiveReports.TextBox
   Private TextBox16 As DataDynamics.ActiveReports.TextBox
   Public lblRegRUCDes As DataDynamics.ActiveReports.TextBox
   Public lblNroRUC As DataDynamics.ActiveReports.TextBox
   Private TextBox As DataDynamics.ActiveReports.TextBox
   Private txtIVA As DataDynamics.ActiveReports.TextBox
   Private txtNeto As DataDynamics.ActiveReports.TextBox
   Private txtSubTotal As DataDynamics.ActiveReports.TextBox
   Private txtVentaTasaCero As DataDynamics.ActiveReports.TextBox
   Private txtFacturaMonto As DataDynamics.ActiveReports.TextBox
   Private txtCodControl As DataDynamics.ActiveReports.TextBox
   Private txtNroAutorizacion As DataDynamics.ActiveReports.TextBox
   Private txtFacturaNro As DataDynamics.ActiveReports.TextBox
   Private txtRegRUCDes As DataDynamics.ActiveReports.TextBox
   Private txtNroRUC As DataDynamics.ActiveReports.TextBox
   Private txtFacturaMontoTot As DataDynamics.ActiveReports.TextBox
   Private txtIceIehdTot As DataDynamics.ActiveReports.TextBox
   Private txtSubTotalTot As DataDynamics.ActiveReports.TextBox
   Private txtNetoTot As DataDynamics.ActiveReports.TextBox
   Private txtIVATot As DataDynamics.ActiveReports.TextBox
   Private Label8 As DataDynamics.ActiveReports.Label

   Private WithEvents Label10 As DataDynamics.ActiveReports.Label
   Private WithEvents Label11 As DataDynamics.ActiveReports.Label
   Private WithEvents Label12 As DataDynamics.ActiveReports.Label
   Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtNroCorre As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtFacturaFecha As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
   Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtDescuento As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtDescuentoTot As DataDynamics.ActiveReports.TextBox
   Public WithEvents lblPeriodo As DataDynamics.ActiveReports.Label

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptLibroIVAVenta))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtCodControl = New DataDynamics.ActiveReports.TextBox
      Me.txtIVA = New DataDynamics.ActiveReports.TextBox
      Me.txtNeto = New DataDynamics.ActiveReports.TextBox
      Me.txtDescuento = New DataDynamics.ActiveReports.TextBox
      Me.txtSubTotal = New DataDynamics.ActiveReports.TextBox
      Me.txtVentaTasaCero = New DataDynamics.ActiveReports.TextBox
      Me.pgbDetail = New DataDynamics.ActiveReports.PageBreak
      Me.txtExento = New DataDynamics.ActiveReports.TextBox
      Me.txtIceIehd = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaMonto = New DataDynamics.ActiveReports.TextBox
      Me.txtRegRUCDes = New DataDynamics.ActiveReports.TextBox
      Me.txtNroRUC = New DataDynamics.ActiveReports.TextBox
      Me.txtEstadoFac = New DataDynamics.ActiveReports.TextBox
      Me.txtNroAutorizacion = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaNro = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtNroCorre = New DataDynamics.ActiveReports.TextBox
      Me.ReportHeader = New DataDynamics.ActiveReports.ReportHeader
      Me.lblTitle = New DataDynamics.ActiveReports.Label
      Me.lblMes = New DataDynamics.ActiveReports.Label
      Me.lblGestion = New DataDynamics.ActiveReports.Label
      Me.Label = New DataDynamics.ActiveReports.Label
      Me.txtEmpresaDes = New DataDynamics.ActiveReports.TextBox
      Me.Label1 = New DataDynamics.ActiveReports.Label
      Me.txtEmpresaRUC = New DataDynamics.ActiveReports.TextBox
      Me.Label10 = New DataDynamics.ActiveReports.Label
      Me.Label11 = New DataDynamics.ActiveReports.Label
      Me.Label12 = New DataDynamics.ActiveReports.Label
      Me.lblPeriodo = New DataDynamics.ActiveReports.Label
      Me.ReportFooter = New DataDynamics.ActiveReports.ReportFooter
      Me.txtIVATot = New DataDynamics.ActiveReports.TextBox
      Me.txtNetoTot = New DataDynamics.ActiveReports.TextBox
      Me.txtDescuentoTot = New DataDynamics.ActiveReports.TextBox
      Me.txtSubTotalTot = New DataDynamics.ActiveReports.TextBox
      Me.txtIceIehdTot = New DataDynamics.ActiveReports.TextBox
      Me.txtFacturaMontoTot = New DataDynamics.ActiveReports.TextBox
      Me.Label8 = New DataDynamics.ActiveReports.Label
      Me.txtExentoTot = New DataDynamics.ActiveReports.TextBox
      Me.txtVentaTasaCeroTot = New DataDynamics.ActiveReports.TextBox
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox19 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox29 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
      Me.lblRegRUCDes = New DataDynamics.ActiveReports.TextBox
      Me.lblNroRUC = New DataDynamics.ActiveReports.TextBox
      Me.TextBox = New DataDynamics.ActiveReports.TextBox
      Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
      Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      CType(Me.txtCodControl, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIVA, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNeto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtVentaTasaCero, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtExento, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIceIehd, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaMonto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtRegRUCDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNroRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEstadoFac, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNroAutorizacion, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNroCorre, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblMes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblGestion, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEmpresaDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtEmpresaRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIVATot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtNetoTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDescuentoTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSubTotalTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtIceIehdTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtFacturaMontoTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtExentoTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtVentaTasaCeroTot, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblRegRUCDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblNroRUC, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtCodControl, Me.txtIVA, Me.txtNeto, Me.txtDescuento, Me.txtSubTotal, Me.txtVentaTasaCero, Me.pgbDetail, Me.txtExento, Me.txtIceIehd, Me.txtFacturaMonto, Me.txtRegRUCDes, Me.txtNroRUC, Me.txtEstadoFac, Me.txtNroAutorizacion, Me.txtFacturaNro, Me.txtFacturaFecha, Me.txtNroCorre})
      Me.Detail.Height = 0.125!
      Me.Detail.Name = "Detail"
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
      Me.txtCodControl.Left = 11.5!
      Me.txtCodControl.Name = "txtCodControl"
      Me.txtCodControl.Style = "ddo-char-set: 1; text-align: center; font-size: 7pt; "
      Me.txtCodControl.Text = "CodControl"
      Me.txtCodControl.Top = 0.0!
      Me.txtCodControl.Width = 0.9375!
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
      Me.txtIVA.Left = 10.875!
      Me.txtIVA.Name = "txtIVA"
      Me.txtIVA.OutputFormat = resources.GetString("txtIVA.OutputFormat")
      Me.txtIVA.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtIVA.Text = "IVA"
      Me.txtIVA.Top = 0.0!
      Me.txtIVA.Width = 0.625!
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
      Me.txtNeto.Left = 10.1875!
      Me.txtNeto.Name = "txtNeto"
      Me.txtNeto.OutputFormat = resources.GetString("txtNeto.OutputFormat")
      Me.txtNeto.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtNeto.Text = "Neto"
      Me.txtNeto.Top = 0.0!
      Me.txtNeto.Width = 0.6875!
      '
      'txtDescuento
      '
      Me.txtDescuento.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDescuento.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDescuento.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDescuento.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDescuento.Border.RightColor = System.Drawing.Color.Black
      Me.txtDescuento.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDescuento.Border.TopColor = System.Drawing.Color.Black
      Me.txtDescuento.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDescuento.DataField = "Descuento"
      Me.txtDescuento.Height = 0.125!
      Me.txtDescuento.Left = 9.5625!
      Me.txtDescuento.Name = "txtDescuento"
      Me.txtDescuento.OutputFormat = resources.GetString("txtDescuento.OutputFormat")
      Me.txtDescuento.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtDescuento.Text = "Descuento"
      Me.txtDescuento.Top = 0.0!
      Me.txtDescuento.Width = 0.625!
      '
      'txtSubTotal
      '
      Me.txtSubTotal.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSubTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSubTotal.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSubTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSubTotal.Border.RightColor = System.Drawing.Color.Black
      Me.txtSubTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSubTotal.Border.TopColor = System.Drawing.Color.Black
      Me.txtSubTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSubTotal.DataField = "SubTotal"
      Me.txtSubTotal.Height = 0.125!
      Me.txtSubTotal.Left = 8.8125!
      Me.txtSubTotal.Name = "txtSubTotal"
      Me.txtSubTotal.OutputFormat = resources.GetString("txtSubTotal.OutputFormat")
      Me.txtSubTotal.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtSubTotal.Text = "SubTotal"
      Me.txtSubTotal.Top = 0.0!
      Me.txtSubTotal.Width = 0.75!
      '
      'txtVentaTasaCero
      '
      Me.txtVentaTasaCero.Border.BottomColor = System.Drawing.Color.Black
      Me.txtVentaTasaCero.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtVentaTasaCero.Border.LeftColor = System.Drawing.Color.Black
      Me.txtVentaTasaCero.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtVentaTasaCero.Border.RightColor = System.Drawing.Color.Black
      Me.txtVentaTasaCero.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtVentaTasaCero.Border.TopColor = System.Drawing.Color.Black
      Me.txtVentaTasaCero.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtVentaTasaCero.DataField = "VentaTasaCero"
      Me.txtVentaTasaCero.Height = 0.125!
      Me.txtVentaTasaCero.Left = 8.125!
      Me.txtVentaTasaCero.Name = "txtVentaTasaCero"
      Me.txtVentaTasaCero.OutputFormat = resources.GetString("txtVentaTasaCero.OutputFormat")
      Me.txtVentaTasaCero.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtVentaTasaCero.Text = "VentaTasaCero"
      Me.txtVentaTasaCero.Top = 0.0!
      Me.txtVentaTasaCero.Width = 0.6875!
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
      Me.txtExento.Left = 7.5!
      Me.txtExento.Name = "txtExento"
      Me.txtExento.OutputFormat = resources.GetString("txtExento.OutputFormat")
      Me.txtExento.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtExento.Text = "Exento"
      Me.txtExento.Top = 0.0!
      Me.txtExento.Width = 0.625!
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
      Me.txtIceIehd.Left = 6.8125!
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
      Me.txtFacturaMonto.Left = 6.0625!
      Me.txtFacturaMonto.Name = "txtFacturaMonto"
      Me.txtFacturaMonto.OutputFormat = resources.GetString("txtFacturaMonto.OutputFormat")
      Me.txtFacturaMonto.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; "
      Me.txtFacturaMonto.Text = "FacturaMonto"
      Me.txtFacturaMonto.Top = 0.0!
      Me.txtFacturaMonto.Width = 0.75!
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
      Me.txtRegRUCDes.Left = 3.6875!
      Me.txtRegRUCDes.Name = "txtRegRUCDes"
      Me.txtRegRUCDes.Style = "ddo-char-set: 1; font-size: 7pt; "
      Me.txtRegRUCDes.Text = "RegRUCDes"
      Me.txtRegRUCDes.Top = 0.0!
      Me.txtRegRUCDes.Width = 2.375!
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
      Me.txtNroRUC.Left = 2.9375!
      Me.txtNroRUC.Name = "txtNroRUC"
      Me.txtNroRUC.Style = "ddo-char-set: 1; font-size: 7pt; "
      Me.txtNroRUC.Text = "NroRUC"
      Me.txtNroRUC.Top = 0.0!
      Me.txtNroRUC.Width = 0.75!
      '
      'txtEstadoFac
      '
      Me.txtEstadoFac.Border.BottomColor = System.Drawing.Color.Black
      Me.txtEstadoFac.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEstadoFac.Border.LeftColor = System.Drawing.Color.Black
      Me.txtEstadoFac.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoFac.Border.RightColor = System.Drawing.Color.Black
      Me.txtEstadoFac.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtEstadoFac.Border.TopColor = System.Drawing.Color.Black
      Me.txtEstadoFac.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtEstadoFac.DataField = "EstadoFac"
      Me.txtEstadoFac.Height = 0.125!
      Me.txtEstadoFac.Left = 2.6875!
      Me.txtEstadoFac.Name = "txtEstadoFac"
      Me.txtEstadoFac.Style = "ddo-char-set: 1; text-align: center; font-size: 7pt; "
      Me.txtEstadoFac.Text = "EstadoFac"
      Me.txtEstadoFac.Top = 0.0!
      Me.txtEstadoFac.Width = 0.25!
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
      Me.txtNroAutorizacion.Left = 1.75!
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
      Me.txtFacturaNro.Left = 1.0!
      Me.txtFacturaNro.Name = "txtFacturaNro"
      Me.txtFacturaNro.Style = "ddo-char-set: 1; font-size: 7pt; "
      Me.txtFacturaNro.Text = "FacturaNro"
      Me.txtFacturaNro.Top = 0.0!
      Me.txtFacturaNro.Width = 0.75!
      '
      'txtFacturaFecha
      '
      Me.txtFacturaFecha.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFacturaFecha.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaFecha.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFacturaFecha.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaFecha.Border.RightColor = System.Drawing.Color.Black
      Me.txtFacturaFecha.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaFecha.Border.TopColor = System.Drawing.Color.Black
      Me.txtFacturaFecha.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaFecha.DataField = "FacturaFecha"
      Me.txtFacturaFecha.Height = 0.125!
      Me.txtFacturaFecha.Left = 0.375!
      Me.txtFacturaFecha.Name = "txtFacturaFecha"
      Me.txtFacturaFecha.OutputFormat = resources.GetString("txtFacturaFecha.OutputFormat")
      Me.txtFacturaFecha.Style = "ddo-char-set: 1; text-align: center; font-size: 7pt; "
      Me.txtFacturaFecha.Text = "FacturaFecha"
      Me.txtFacturaFecha.Top = 0.0!
      Me.txtFacturaFecha.Width = 0.625!
      '
      'txtNroCorre
      '
      Me.txtNroCorre.Border.BottomColor = System.Drawing.Color.Black
      Me.txtNroCorre.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNroCorre.Border.LeftColor = System.Drawing.Color.Black
      Me.txtNroCorre.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNroCorre.Border.RightColor = System.Drawing.Color.Black
      Me.txtNroCorre.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNroCorre.Border.TopColor = System.Drawing.Color.Black
      Me.txtNroCorre.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtNroCorre.DataField = "NroCorre"
      Me.txtNroCorre.Height = 0.125!
      Me.txtNroCorre.Left = 0.0!
      Me.txtNroCorre.Name = "txtNroCorre"
      Me.txtNroCorre.Style = "ddo-char-set: 1; text-align: center; font-size: 7pt; "
      Me.txtNroCorre.Text = "NroCorre"
      Me.txtNroCorre.Top = 0.0!
      Me.txtNroCorre.Width = 0.375!
      '
      'ReportHeader
      '
      Me.ReportHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitle, Me.lblMes, Me.lblGestion, Me.Label, Me.txtEmpresaDes, Me.Label1, Me.txtEmpresaRUC, Me.Label10, Me.Label11, Me.Label12, Me.lblPeriodo})
      Me.ReportHeader.Height = 1.114583!
      Me.ReportHeader.Name = "ReportHeader"
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
      Me.lblTitle.Left = 4.5625!
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 13pt; "
      Me.lblTitle.Text = "LIBRO DE VENTAS ESTÁNDAR"
      Me.lblTitle.Top = 0.0!
      Me.lblTitle.Width = 2.9375!
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
      Me.lblMes.Left = 3.875!
      Me.lblMes.Name = "lblMes"
      Me.lblMes.Style = "text-align: center; font-weight: normal; font-size: 9.75pt; "
      Me.lblMes.Text = ""
      Me.lblMes.Top = 0.5625!
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
      Me.lblGestion.Left = 2.0625!
      Me.lblGestion.Name = "lblGestion"
      Me.lblGestion.Style = "text-align: center; font-weight: normal; font-size: 9.75pt; "
      Me.lblGestion.Text = ""
      Me.lblGestion.Top = 0.5625!
      Me.lblGestion.Width = 0.8125!
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
      Me.Label.Left = 0.375!
      Me.Label.Name = "Label"
      Me.Label.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label.Text = "NOMBRE O RAZÓN SOCIAL:"
      Me.Label.Top = 0.8125!
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
      Me.txtEmpresaDes.Left = 2.0625!
      Me.txtEmpresaDes.Name = "txtEmpresaDes"
      Me.txtEmpresaDes.Style = "ddo-char-set: 0; font-size: 9.75pt; vertical-align: middle; "
      Me.txtEmpresaDes.Text = Nothing
      Me.txtEmpresaDes.Top = 0.8125!
      Me.txtEmpresaDes.Width = 5.6875!
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
      Me.Label1.Left = 8.6875!
      Me.Label1.Name = "Label1"
      Me.Label1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label1.Text = "NIT:"
      Me.Label1.Top = 0.8125!
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
      Me.txtEmpresaRUC.Left = 9.0625!
      Me.txtEmpresaRUC.Name = "txtEmpresaRUC"
      Me.txtEmpresaRUC.Style = "ddo-char-set: 0; text-align: left; font-size: 9.75pt; vertical-align: middle; "
      Me.txtEmpresaRUC.Text = Nothing
      Me.txtEmpresaRUC.Top = 0.8125!
      Me.txtEmpresaRUC.Width = 1.1875!
      '
      'Label10
      '
      Me.Label10.Border.BottomColor = System.Drawing.Color.Black
      Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.LeftColor = System.Drawing.Color.Black
      Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.RightColor = System.Drawing.Color.Black
      Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Border.TopColor = System.Drawing.Color.Black
      Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label10.Height = 0.1875!
      Me.Label10.HyperLink = Nothing
      Me.Label10.Left = 1.3125!
      Me.Label10.Name = "Label10"
      Me.Label10.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label10.Text = "PERIODO:"
      Me.Label10.Top = 0.3125!
      Me.Label10.Width = 0.6875!
      '
      'Label11
      '
      Me.Label11.Border.BottomColor = System.Drawing.Color.Black
      Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.LeftColor = System.Drawing.Color.Black
      Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.RightColor = System.Drawing.Color.Black
      Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Border.TopColor = System.Drawing.Color.Black
      Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.Label11.Height = 0.1875!
      Me.Label11.HyperLink = Nothing
      Me.Label11.Left = 1.3125!
      Me.Label11.Name = "Label11"
      Me.Label11.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label11.Text = "AÑO:"
      Me.Label11.Top = 0.5625!
      Me.Label11.Width = 0.6875!
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
      Me.Label12.Height = 0.1875!
      Me.Label12.HyperLink = Nothing
      Me.Label12.Left = 3.4375!
      Me.Label12.Name = "Label12"
      Me.Label12.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label12.Text = "MES:"
      Me.Label12.Top = 0.5625!
      Me.Label12.Width = 0.375!
      '
      'lblPeriodo
      '
      Me.lblPeriodo.Border.BottomColor = System.Drawing.Color.Black
      Me.lblPeriodo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPeriodo.Border.LeftColor = System.Drawing.Color.Black
      Me.lblPeriodo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPeriodo.Border.RightColor = System.Drawing.Color.Black
      Me.lblPeriodo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPeriodo.Border.TopColor = System.Drawing.Color.Black
      Me.lblPeriodo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblPeriodo.Height = 0.1875!
      Me.lblPeriodo.HyperLink = Nothing
      Me.lblPeriodo.Left = 2.0625!
      Me.lblPeriodo.Name = "lblPeriodo"
      Me.lblPeriodo.Style = "text-align: center; font-weight: normal; font-size: 9.75pt; "
      Me.lblPeriodo.Text = ""
      Me.lblPeriodo.Top = 0.3125!
      Me.lblPeriodo.Width = 0.8125!
      '
      'ReportFooter
      '
      Me.ReportFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtIVATot, Me.txtNetoTot, Me.txtDescuentoTot, Me.txtSubTotalTot, Me.txtIceIehdTot, Me.txtFacturaMontoTot, Me.Label8, Me.txtExentoTot, Me.txtVentaTasaCeroTot})
      Me.ReportFooter.Height = 0.2604167!
      Me.ReportFooter.Name = "ReportFooter"
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
      Me.txtIVATot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIVATot.DataField = "IVA"
      Me.txtIVATot.Height = 0.1875!
      Me.txtIVATot.Left = 10.875!
      Me.txtIVATot.Name = "txtIVATot"
      Me.txtIVATot.OutputFormat = resources.GetString("txtIVATot.OutputFormat")
      Me.txtIVATot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtIVATot.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.txtIVATot.Text = "IVATot"
      Me.txtIVATot.Top = 0.0625!
      Me.txtIVATot.Width = 0.625!
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
      Me.txtNetoTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtNetoTot.DataField = "Neto"
      Me.txtNetoTot.Height = 0.1875!
      Me.txtNetoTot.Left = 10.1875!
      Me.txtNetoTot.Name = "txtNetoTot"
      Me.txtNetoTot.OutputFormat = resources.GetString("txtNetoTot.OutputFormat")
      Me.txtNetoTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtNetoTot.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.txtNetoTot.Text = "NetoTot"
      Me.txtNetoTot.Top = 0.0625!
      Me.txtNetoTot.Width = 0.6875!
      '
      'txtDescuentoTot
      '
      Me.txtDescuentoTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDescuentoTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDescuentoTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDescuentoTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDescuentoTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtDescuentoTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDescuentoTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtDescuentoTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtDescuentoTot.DataField = "Descuento"
      Me.txtDescuentoTot.Height = 0.1875!
      Me.txtDescuentoTot.Left = 9.5625!
      Me.txtDescuentoTot.Name = "txtDescuentoTot"
      Me.txtDescuentoTot.OutputFormat = resources.GetString("txtDescuentoTot.OutputFormat")
      Me.txtDescuentoTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtDescuentoTot.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.txtDescuentoTot.Text = "DescuentoTot"
      Me.txtDescuentoTot.Top = 0.0625!
      Me.txtDescuentoTot.Width = 0.625!
      '
      'txtSubTotalTot
      '
      Me.txtSubTotalTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSubTotalTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSubTotalTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSubTotalTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSubTotalTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtSubTotalTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSubTotalTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtSubTotalTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSubTotalTot.DataField = "SubTotal"
      Me.txtSubTotalTot.Height = 0.1875!
      Me.txtSubTotalTot.Left = 8.8125!
      Me.txtSubTotalTot.Name = "txtSubTotalTot"
      Me.txtSubTotalTot.OutputFormat = resources.GetString("txtSubTotalTot.OutputFormat")
      Me.txtSubTotalTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtSubTotalTot.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.txtSubTotalTot.Text = "SubTotalTot"
      Me.txtSubTotalTot.Top = 0.0625!
      Me.txtSubTotalTot.Width = 0.75!
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
      Me.txtIceIehdTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtIceIehdTot.DataField = "IceIehd"
      Me.txtIceIehdTot.Height = 0.1875!
      Me.txtIceIehdTot.Left = 6.8125!
      Me.txtIceIehdTot.Name = "txtIceIehdTot"
      Me.txtIceIehdTot.OutputFormat = resources.GetString("txtIceIehdTot.OutputFormat")
      Me.txtIceIehdTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtIceIehdTot.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.txtIceIehdTot.Text = "IceIehdTot"
      Me.txtIceIehdTot.Top = 0.0625!
      Me.txtIceIehdTot.Width = 0.6875!
      '
      'txtFacturaMontoTot
      '
      Me.txtFacturaMontoTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFacturaMontoTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFacturaMontoTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFacturaMontoTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtFacturaMontoTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtFacturaMontoTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtFacturaMontoTot.DataField = "FacturaMonto"
      Me.txtFacturaMontoTot.Height = 0.1875!
      Me.txtFacturaMontoTot.Left = 6.0625!
      Me.txtFacturaMontoTot.Name = "txtFacturaMontoTot"
      Me.txtFacturaMontoTot.OutputFormat = resources.GetString("txtFacturaMontoTot.OutputFormat")
      Me.txtFacturaMontoTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtFacturaMontoTot.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.txtFacturaMontoTot.Text = "FacturaMontoTot"
      Me.txtFacturaMontoTot.Top = 0.0625!
      Me.txtFacturaMontoTot.Width = 0.75!
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
      Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.Label8.Height = 0.1875!
      Me.Label8.HyperLink = Nothing
      Me.Label8.Left = 5.25!
      Me.Label8.Name = "Label8"
      Me.Label8.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
          "l-align: middle; "
      Me.Label8.Text = "TOTALES"
      Me.Label8.Top = 0.0625!
      Me.Label8.Width = 0.8125!
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
      Me.txtExentoTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtExentoTot.DataField = "Exento"
      Me.txtExentoTot.Height = 0.1875!
      Me.txtExentoTot.Left = 7.5!
      Me.txtExentoTot.Name = "txtExentoTot"
      Me.txtExentoTot.OutputFormat = resources.GetString("txtExentoTot.OutputFormat")
      Me.txtExentoTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtExentoTot.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.txtExentoTot.Text = "ExentoTot"
      Me.txtExentoTot.Top = 0.0625!
      Me.txtExentoTot.Width = 0.625!
      '
      'txtVentaTasaCeroTot
      '
      Me.txtVentaTasaCeroTot.Border.BottomColor = System.Drawing.Color.Black
      Me.txtVentaTasaCeroTot.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtVentaTasaCeroTot.Border.LeftColor = System.Drawing.Color.Black
      Me.txtVentaTasaCeroTot.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtVentaTasaCeroTot.Border.RightColor = System.Drawing.Color.Black
      Me.txtVentaTasaCeroTot.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtVentaTasaCeroTot.Border.TopColor = System.Drawing.Color.Black
      Me.txtVentaTasaCeroTot.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtVentaTasaCeroTot.DataField = "VentaTasaCero"
      Me.txtVentaTasaCeroTot.Height = 0.1875!
      Me.txtVentaTasaCeroTot.Left = 8.125!
      Me.txtVentaTasaCeroTot.Name = "txtVentaTasaCeroTot"
      Me.txtVentaTasaCeroTot.OutputFormat = resources.GetString("txtVentaTasaCeroTot.OutputFormat")
      Me.txtVentaTasaCeroTot.Style = "ddo-char-set: 1; text-align: right; font-size: 7pt; vertical-align: middle; "
      Me.txtVentaTasaCeroTot.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
      Me.txtVentaTasaCeroTot.Text = "VentaTasaCeroTot"
      Me.txtVentaTasaCeroTot.Top = 0.0625!
      Me.txtVentaTasaCeroTot.Width = 0.6875!
      '
      'PageHeader
      '
      Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox14, Me.TextBox19, Me.TextBox18, Me.TextBox12, Me.TextBox11, Me.TextBox17, Me.TextBox13, Me.TextBox8, Me.TextBox10, Me.TextBox7, Me.TextBox6, Me.TextBox29, Me.TextBox5, Me.TextBox15, Me.TextBox16, Me.lblRegRUCDes, Me.lblNroRUC, Me.TextBox, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox9, Me.TextBox21, Me.TextBox22})
      Me.PageHeader.Height = 0.4895833!
      Me.PageHeader.Name = "PageHeader"
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
      Me.TextBox14.Height = 0.5!
      Me.TextBox14.Left = 11.5!
      Me.TextBox14.Name = "TextBox14"
      Me.TextBox14.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox14.Text = "CÓDIGO DE CONTROL"
      Me.TextBox14.Top = 0.0!
      Me.TextBox14.Width = 0.9375!
      '
      'TextBox19
      '
      Me.TextBox19.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox19.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox19.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox19.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox19.Height = 0.125!
      Me.TextBox19.Left = 10.875!
      Me.TextBox19.Name = "TextBox19"
      Me.TextBox19.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6pt; vertical-" & _
          "align: middle; "
      Me.TextBox19.Text = "H = G * 13%"
      Me.TextBox19.Top = 0.375!
      Me.TextBox19.Width = 0.625!
      '
      'TextBox18
      '
      Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox18.Height = 0.375!
      Me.TextBox18.Left = 10.875!
      Me.TextBox18.Name = "TextBox18"
      Me.TextBox18.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox18.Text = "DÉBITO FISCAL"
      Me.TextBox18.Top = 0.0!
      Me.TextBox18.Width = 0.625!
      '
      'TextBox12
      '
      Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox12.Height = 0.125!
      Me.TextBox12.Left = 10.1875!
      Me.TextBox12.Name = "TextBox12"
      Me.TextBox12.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6pt; vertical-" & _
          "align: middle; "
      Me.TextBox12.Text = "G = E - F"
      Me.TextBox12.Top = 0.375!
      Me.TextBox12.Width = 0.6875!
      '
      'TextBox11
      '
      Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox11.Height = 0.375!
      Me.TextBox11.Left = 10.1875!
      Me.TextBox11.Name = "TextBox11"
      Me.TextBox11.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox11.Text = "IMP BASE PARA DÉBITO FISCAL"
      Me.TextBox11.Top = 0.0!
      Me.TextBox11.Width = 0.6875!
      '
      'TextBox17
      '
      Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox17.Height = 0.125!
      Me.TextBox17.Left = 9.5625!
      Me.TextBox17.Name = "TextBox17"
      Me.TextBox17.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6pt; vertical-" & _
          "align: middle; "
      Me.TextBox17.Text = "F"
      Me.TextBox17.Top = 0.375!
      Me.TextBox17.Width = 0.625!
      '
      'TextBox13
      '
      Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox13.Height = 0.375!
      Me.TextBox13.Left = 9.5625!
      Me.TextBox13.Name = "TextBox13"
      Me.TextBox13.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox13.Text = "DTOS, BONIFICA. Y REBAJAS"
      Me.TextBox13.Top = 0.0!
      Me.TextBox13.Width = 0.625!
      '
      'TextBox8
      '
      Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox8.Height = 0.375!
      Me.TextBox8.Left = 8.8125!
      Me.TextBox8.Name = "TextBox8"
      Me.TextBox8.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox8.Text = "SUBTOTAL"
      Me.TextBox8.Top = 0.0!
      Me.TextBox8.Width = 0.75!
      '
      'TextBox10
      '
      Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox10.Height = 0.125!
      Me.TextBox10.Left = 8.8125!
      Me.TextBox10.Name = "TextBox10"
      Me.TextBox10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6pt; vertical-" & _
          "align: middle; "
      Me.TextBox10.Text = "E = A - B - C- D"
      Me.TextBox10.Top = 0.375!
      Me.TextBox10.Width = 0.75!
      '
      'TextBox7
      '
      Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox7.Height = 0.125!
      Me.TextBox7.Left = 6.8125!
      Me.TextBox7.Name = "TextBox7"
      Me.TextBox7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6pt; vertical-" & _
          "align: middle; "
      Me.TextBox7.Text = "B"
      Me.TextBox7.Top = 0.375!
      Me.TextBox7.Width = 0.6875!
      '
      'TextBox6
      '
      Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox6.Height = 0.375!
      Me.TextBox6.Left = 6.8125!
      Me.TextBox6.Name = "TextBox6"
      Me.TextBox6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox6.Text = "IMPORTE ICE/ IEHD/ TASAS"
      Me.TextBox6.Top = 0.0!
      Me.TextBox6.Width = 0.6875!
      '
      'TextBox29
      '
      Me.TextBox29.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox29.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox29.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox29.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox29.Height = 0.375!
      Me.TextBox29.Left = 6.0625!
      Me.TextBox29.Name = "TextBox29"
      Me.TextBox29.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox29.Text = "IMPORTE TOTAL DE LA VENTA"
      Me.TextBox29.Top = 0.0!
      Me.TextBox29.Width = 0.75!
      '
      'TextBox5
      '
      Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox5.Height = 0.125!
      Me.TextBox5.Left = 6.0625!
      Me.TextBox5.Name = "TextBox5"
      Me.TextBox5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6pt; vertical-" & _
          "align: middle; "
      Me.TextBox5.Text = "A"
      Me.TextBox5.Top = 0.375!
      Me.TextBox5.Width = 0.75!
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
      Me.TextBox15.Height = 0.5!
      Me.TextBox15.Left = 1.75!
      Me.TextBox15.Name = "TextBox15"
      Me.TextBox15.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox15.Text = "Nº DE AUTORIZA CIÓN"
      Me.TextBox15.Top = 0.0!
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
      Me.TextBox16.Height = 0.5!
      Me.TextBox16.Left = 1.0!
      Me.TextBox16.Name = "TextBox16"
      Me.TextBox16.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox16.Text = "Nº DE LA FACTURA"
      Me.TextBox16.Top = 0.0!
      Me.TextBox16.Width = 0.75!
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
      Me.lblRegRUCDes.Height = 0.5!
      Me.lblRegRUCDes.Left = 3.6875!
      Me.lblRegRUCDes.Name = "lblRegRUCDes"
      Me.lblRegRUCDes.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.lblRegRUCDes.Text = "NOMBRE O RAZÓN SOCIAL"
      Me.lblRegRUCDes.Top = 0.0!
      Me.lblRegRUCDes.Width = 2.375!
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
      Me.lblNroRUC.Height = 0.5!
      Me.lblNroRUC.Left = 2.9375!
      Me.lblNroRUC.Name = "lblNroRUC"
      Me.lblNroRUC.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.lblNroRUC.Text = "NIT/CI  CLIENTE"
      Me.lblNroRUC.Top = 0.0!
      Me.lblNroRUC.Width = 0.75!
      '
      'TextBox
      '
      Me.TextBox.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox.CanGrow = False
      Me.TextBox.Height = 0.5!
      Me.TextBox.Left = 0.375!
      Me.TextBox.Name = "TextBox"
      Me.TextBox.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox.Text = "FECHA FACTURA"
      Me.TextBox.Top = 0.0!
      Me.TextBox.Width = 0.625!
      '
      'TextBox1
      '
      Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox1.Height = 0.5!
      Me.TextBox1.Left = 0.0!
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox1.Text = "Nº"
      Me.TextBox1.Top = 0.0!
      Me.TextBox1.Width = 0.375!
      '
      'TextBox2
      '
      Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox2.Height = 0.5!
      Me.TextBox2.Left = 2.6875!
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox2.Text = "ES TA DO"
      Me.TextBox2.Top = 0.0!
      Me.TextBox2.Width = 0.25!
      '
      'TextBox3
      '
      Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox3.Height = 0.125!
      Me.TextBox3.Left = 7.5!
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6pt; vertical-" & _
          "align: middle; "
      Me.TextBox3.Text = "C"
      Me.TextBox3.Top = 0.375!
      Me.TextBox3.Width = 0.625!
      '
      'TextBox9
      '
      Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox9.Height = 0.375!
      Me.TextBox9.Left = 7.5!
      Me.TextBox9.Name = "TextBox9"
      Me.TextBox9.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox9.Text = "EXPORT Y OPE EXENTAS"
      Me.TextBox9.Top = 0.0!
      Me.TextBox9.Width = 0.625!
      '
      'TextBox21
      '
      Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox21.Height = 0.125!
      Me.TextBox21.Left = 8.125!
      Me.TextBox21.Name = "TextBox21"
      Me.TextBox21.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6pt; vertical-" & _
          "align: middle; "
      Me.TextBox21.Text = "D"
      Me.TextBox21.Top = 0.375!
      Me.TextBox21.Width = 0.6875!
      '
      'TextBox22
      '
      Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
      Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
      Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
      Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
      Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.TextBox22.Height = 0.375!
      Me.TextBox22.Left = 8.125!
      Me.TextBox22.Name = "TextBox22"
      Me.TextBox22.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertic" & _
          "al-align: middle; "
      Me.TextBox22.Text = "VENTAS GRAVADAS A TASA CERO"
      Me.TextBox22.Top = 0.0!
      Me.TextBox22.Width = 0.6875!
      '
      'PageFooter
      '
      Me.PageFooter.Height = 0.0!
      Me.PageFooter.Name = "PageFooter"
      '
      'rptLibroIVAVenta
      '
      Me.MasterReport = False
      Me.PageSettings.DefaultPaperSize = False
      Me.PageSettings.Margins.Bottom = 0.3!
      Me.PageSettings.Margins.Left = 0.3!
      Me.PageSettings.Margins.Right = 0.3!
      Me.PageSettings.Margins.Top = 0.8!
      Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
      Me.PageSettings.PaperHeight = 14.0!
      Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
      Me.PageSettings.PaperName = "Legal"
      Me.PageSettings.PaperWidth = 8.5!
      Me.PrintWidth = 12.44792!
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
      CType(Me.txtCodControl, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIVA, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNeto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDescuento, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtVentaTasaCero, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtExento, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIceIehd, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaMonto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtRegRUCDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNroRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEstadoFac, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNroAutorizacion, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNroCorre, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblMes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblGestion, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEmpresaDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtEmpresaRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIVATot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtNetoTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDescuentoTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSubTotalTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtIceIehdTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtFacturaMontoTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtExentoTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtVentaTasaCeroTot, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblRegRUCDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblNroRUC, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.BeforePrint
      If txtRegRUCDes.Height > txtNroRUC.Height Then
         txtNroCorre.Height = txtRegRUCDes.Height
         txtFacturaFecha.Height = txtRegRUCDes.Height
         txtNroRUC.Height = txtRegRUCDes.Height
         txtRegRUCDes.Height = txtRegRUCDes.Height
         txtFacturaNro.Height = txtRegRUCDes.Height
         txtNroAutorizacion.Height = txtRegRUCDes.Height
         txtFacturaMonto.Height = txtRegRUCDes.Height
         txtVentaTasaCero.Height = txtRegRUCDes.Height
         txtSubTotal.Height = txtRegRUCDes.Height
         txtDescuento.Height = txtRegRUCDes.Height
         txtNeto.Height = txtRegRUCDes.Height
         txtIVA.Height = txtRegRUCDes.Height
         txtCodControl.Height = txtRegRUCDes.Height

         txtEstadoFac.Height = txtRegRUCDes.Height
         txtIceIehd.Height = txtRegRUCDes.Height
         txtExento.Height = txtRegRUCDes.Height
         txtVentaTasaCero.Height = txtRegRUCDes.Height

      Else
         txtNroCorre.Height = txtNroRUC.Height
         txtFacturaFecha.Height = txtNroRUC.Height
         txtNroRUC.Height = txtNroRUC.Height
         txtRegRUCDes.Height = txtNroRUC.Height
         txtFacturaNro.Height = txtNroRUC.Height
         txtNroAutorizacion.Height = txtNroRUC.Height
         txtFacturaMonto.Height = txtNroRUC.Height
         txtVentaTasaCero.Height = txtNroRUC.Height
         txtSubTotal.Height = txtNroRUC.Height
         txtDescuento.Height = txtNroRUC.Height
         txtNeto.Height = txtNroRUC.Height
         txtIVA.Height = txtNroRUC.Height
         txtCodControl.Height = txtNroRUC.Height

         txtEstadoFac.Height = txtNroRUC.Height
         txtIceIehd.Height = txtNroRUC.Height
         txtExento.Height = txtNroRUC.Height
         txtVentaTasaCero.Height = txtNroRUC.Height
      End If
   End Sub

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      Dim datFacturaFecha As Date = Me.Fields("FacturaFecha").Value

      If mlngMesId > 0 Then
         If datFacturaFecha.Month <> mlngMesId Then
            mlngAnio = datFacturaFecha.Year
            mlngMesId = datFacturaFecha.Month

            Me.pgbDetail.Enabled = True

         Else
            Me.pgbDetail.Enabled = False
         End If

      Else
         mlngAnio = datFacturaFecha.Year
         mlngMesId = datFacturaFecha.Month
      End If
   End Sub

   Private Sub PageHeader_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader.Format
      If mlngMesId > 0 Then
         lblGestion.Text = ToStr(mlngAnio)
         lblMes.Text = ToStr(mlngMesId)
         lblPeriodo.Text = lblMes.Text & "/" & lblGestion.Text
      End If
   End Sub

End Class