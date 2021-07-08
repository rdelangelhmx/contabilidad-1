Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptConciliaDiferencia
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

   Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
   Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
   Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
   Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
   Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
   Private WithEvents txtFecha As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtDescripcion As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtMonto As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtTotal As DataDynamics.ActiveReports.TextBox
   Private WithEvents lblSubTotal As DataDynamics.ActiveReports.Label
   Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptConciliaDiferencia))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtDescripcion = New DataDynamics.ActiveReports.TextBox
      Me.txtMonto = New DataDynamics.ActiveReports.TextBox
      Me.txtTotal = New DataDynamics.ActiveReports.TextBox
      Me.lblSubTotal = New DataDynamics.ActiveReports.Label
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtFecha, Me.txtDescripcion, Me.txtMonto})
      Me.Detail.Height = 0.1979167!
      Me.Detail.Name = "Detail"
      '
      'PageHeader
      '
      Me.PageHeader.Height = 0.0!
      Me.PageHeader.Name = "PageHeader"
      '
      'PageFooter
      '
      Me.PageFooter.Height = 0.0!
      Me.PageFooter.Name = "PageFooter"
      '
      'GroupHeader1
      '
      Me.GroupHeader1.Height = 0.0!
      Me.GroupHeader1.Name = "GroupHeader1"
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTotal, Me.lblSubTotal})
      Me.GroupFooter1.Height = 0.2395833!
      Me.GroupFooter1.Name = "GroupFooter1"
      '
      'txtFecha
      '
      Me.txtFecha.Border.BottomColor = System.Drawing.Color.Black
      Me.txtFecha.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.LeftColor = System.Drawing.Color.Black
      Me.txtFecha.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.RightColor = System.Drawing.Color.Black
      Me.txtFecha.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.Border.TopColor = System.Drawing.Color.Black
      Me.txtFecha.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtFecha.DataField = "Fecha"
      Me.txtFecha.Height = 0.1889764!
      Me.txtFecha.Left = 0.0!
      Me.txtFecha.Name = "txtFecha"
      Me.txtFecha.OutputFormat = resources.GetString("txtFecha.OutputFormat")
      Me.txtFecha.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtFecha.Text = "Fecha"
      Me.txtFecha.Top = 0.0!
      Me.txtFecha.Width = 0.6875!
      '
      'txtDescripcion
      '
      Me.txtDescripcion.Border.BottomColor = System.Drawing.Color.Black
      Me.txtDescripcion.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDescripcion.Border.LeftColor = System.Drawing.Color.Black
      Me.txtDescripcion.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDescripcion.Border.RightColor = System.Drawing.Color.Black
      Me.txtDescripcion.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDescripcion.Border.TopColor = System.Drawing.Color.Black
      Me.txtDescripcion.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtDescripcion.DataField = "Descripcion"
      Me.txtDescripcion.Height = 0.1875!
      Me.txtDescripcion.Left = 0.6875!
      Me.txtDescripcion.Name = "txtDescripcion"
      Me.txtDescripcion.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtDescripcion.Text = "Descripcion"
      Me.txtDescripcion.Top = 0.0!
      Me.txtDescripcion.Width = 1.5!
      '
      'txtMonto
      '
      Me.txtMonto.Border.BottomColor = System.Drawing.Color.Black
      Me.txtMonto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonto.Border.LeftColor = System.Drawing.Color.Black
      Me.txtMonto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonto.Border.RightColor = System.Drawing.Color.Black
      Me.txtMonto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonto.Border.TopColor = System.Drawing.Color.Black
      Me.txtMonto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtMonto.DataField = "Monto"
      Me.txtMonto.Height = 0.1875!
      Me.txtMonto.Left = 2.1875!
      Me.txtMonto.Name = "txtMonto"
      Me.txtMonto.OutputFormat = resources.GetString("txtMonto.OutputFormat")
      Me.txtMonto.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMonto.Text = "Monto"
      Me.txtMonto.Top = 0.0!
      Me.txtMonto.Width = 0.8125!
      '
      'txtTotal
      '
      Me.txtTotal.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Border.RightColor = System.Drawing.Color.Black
      Me.txtTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTotal.Border.TopColor = System.Drawing.Color.Black
      Me.txtTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtTotal.DataField = "Monto"
      Me.txtTotal.Height = 0.1875!
      Me.txtTotal.Left = 2.1875!
      Me.txtTotal.Name = "txtTotal"
      Me.txtTotal.OutputFormat = resources.GetString("txtTotal.OutputFormat")
      Me.txtTotal.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtTotal.SummaryGroup = "GroupHeader1"
      Me.txtTotal.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
      Me.txtTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtTotal.Text = "Monto"
      Me.txtTotal.Top = 0.0!
      Me.txtTotal.Width = 0.8125!
      '
      'lblSubTotal
      '
      Me.lblSubTotal.Border.BottomColor = System.Drawing.Color.Black
      Me.lblSubTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSubTotal.Border.LeftColor = System.Drawing.Color.Black
      Me.lblSubTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSubTotal.Border.RightColor = System.Drawing.Color.Black
      Me.lblSubTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.lblSubTotal.Border.TopColor = System.Drawing.Color.Black
      Me.lblSubTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.lblSubTotal.Height = 0.1875!
      Me.lblSubTotal.HyperLink = Nothing
      Me.lblSubTotal.Left = 0.9375!
      Me.lblSubTotal.Name = "lblSubTotal"
      Me.lblSubTotal.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblSubTotal.Text = "TOTAL"
      Me.lblSubTotal.Top = 0.0!
      Me.lblSubTotal.Width = 1.25!
      '
      'rptConciliaDiferencia
      '
      Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
            "Catalog=CONDOBO;Data Source=(LOCAL)"
      OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
      Me.DataSource = OleDBDataSource1
      Me.PageSettings.PaperHeight = 11.0!
      Me.PageSettings.PaperWidth = 8.5!
      Me.PrintWidth = 3.020833!
      Me.Sections.Add(Me.PageHeader)
      Me.Sections.Add(Me.GroupHeader1)
      Me.Sections.Add(Me.Detail)
      Me.Sections.Add(Me.GroupFooter1)
      Me.Sections.Add(Me.PageFooter)
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading1", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" & _
                  "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading2", "Normal"))
      Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" & _
                  "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit; ", "Heading3", "Normal"))
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

End Class