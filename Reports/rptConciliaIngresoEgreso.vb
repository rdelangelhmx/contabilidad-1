Imports System 
Imports System.Drawing 
Imports System.Collections 
Imports System.ComponentModel 
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 

Public Class rptConciliaIngresoEgreso
   Inherits DataDynamics.ActiveReports.ActiveReport3
   Private mdecTotal As Decimal = 0

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
   Private WithEvents txtTipo As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtFecha As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtCompNro As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtChequeDes As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtMonto As DataDynamics.ActiveReports.TextBox
   Private WithEvents txtChequeNro As DataDynamics.ActiveReports.TextBox
   Public WithEvents txtSubTotal As DataDynamics.ActiveReports.TextBox
   Private WithEvents lblSubTotal As DataDynamics.ActiveReports.Label
   Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource

   'NOTE: The following procedure is required by the ActiveReports Designer
   'It can be modified using the ActiveReports Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim OleDBDataSource1 As DataDynamics.ActiveReports.DataSources.OleDBDataSource = New DataDynamics.ActiveReports.DataSources.OleDBDataSource
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptConciliaIngresoEgreso))
      Me.Detail = New DataDynamics.ActiveReports.Detail
      Me.txtFecha = New DataDynamics.ActiveReports.TextBox
      Me.txtCompNro = New DataDynamics.ActiveReports.TextBox
      Me.txtChequeDes = New DataDynamics.ActiveReports.TextBox
      Me.txtMonto = New DataDynamics.ActiveReports.TextBox
      Me.txtChequeNro = New DataDynamics.ActiveReports.TextBox
      Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
      Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
      Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
      Me.txtTipo = New DataDynamics.ActiveReports.TextBox
      Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
      Me.txtSubTotal = New DataDynamics.ActiveReports.TextBox
      Me.lblSubTotal = New DataDynamics.ActiveReports.Label
      CType(Me.txtFecha, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtCompNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtChequeDes, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtChequeNro, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtTipo, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'Detail
      '
      Me.Detail.ColumnSpacing = 0.0!
      Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtFecha, Me.txtCompNro, Me.txtChequeDes, Me.txtMonto, Me.txtChequeNro})
      Me.Detail.Height = 0.21875!
      Me.Detail.Name = "Detail"
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
      'txtCompNro
      '
      Me.txtCompNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtCompNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtCompNro.DataField = "CompNro"
      Me.txtCompNro.Height = 0.1889764!
      Me.txtCompNro.Left = 0.6875!
      Me.txtCompNro.Name = "txtCompNro"
      Me.txtCompNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtCompNro.Text = "CompNro"
      Me.txtCompNro.Top = 0.0!
      Me.txtCompNro.Width = 0.625!
      '
      'txtChequeDes
      '
      Me.txtChequeDes.Border.BottomColor = System.Drawing.Color.Black
      Me.txtChequeDes.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeDes.Border.LeftColor = System.Drawing.Color.Black
      Me.txtChequeDes.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeDes.Border.RightColor = System.Drawing.Color.Black
      Me.txtChequeDes.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeDes.Border.TopColor = System.Drawing.Color.Black
      Me.txtChequeDes.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeDes.DataField = "ChequeDes"
      Me.txtChequeDes.Height = 0.2!
      Me.txtChequeDes.Left = 1.919291!
      Me.txtChequeDes.Name = "txtChequeDes"
      Me.txtChequeDes.Style = "ddo-char-set: 1; font-size: 8pt; "
      Me.txtChequeDes.Text = "ChequeDes"
      Me.txtChequeDes.Top = 0.0!
      Me.txtChequeDes.Width = 1.75!
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
      Me.txtMonto.DataField = "DebeHaber"
      Me.txtMonto.Height = 0.2!
      Me.txtMonto.Left = 3.666339!
      Me.txtMonto.Name = "txtMonto"
      Me.txtMonto.OutputFormat = resources.GetString("txtMonto.OutputFormat")
      Me.txtMonto.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtMonto.Text = "Monto"
      Me.txtMonto.Top = 0.0!
      Me.txtMonto.Width = 0.75!
      '
      'txtChequeNro
      '
      Me.txtChequeNro.Border.BottomColor = System.Drawing.Color.Black
      Me.txtChequeNro.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeNro.Border.LeftColor = System.Drawing.Color.Black
      Me.txtChequeNro.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeNro.Border.RightColor = System.Drawing.Color.Black
      Me.txtChequeNro.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeNro.Border.TopColor = System.Drawing.Color.Black
      Me.txtChequeNro.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtChequeNro.DataField = "ChequeNro"
      Me.txtChequeNro.Height = 0.1889764!
      Me.txtChequeNro.Left = 1.304134!
      Me.txtChequeNro.Name = "txtChequeNro"
      Me.txtChequeNro.Style = "ddo-char-set: 1; text-align: center; font-size: 8pt; "
      Me.txtChequeNro.Text = "ChequeNro"
      Me.txtChequeNro.Top = 0.0!
      Me.txtChequeNro.Width = 0.625!
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
      Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtTipo})
      Me.GroupHeader1.DataField = "Tipo"
      Me.GroupHeader1.Height = 0.2291667!
      Me.GroupHeader1.Name = "GroupHeader1"
      '
      'txtTipo
      '
      Me.txtTipo.Border.BottomColor = System.Drawing.Color.Black
      Me.txtTipo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
      Me.txtTipo.Border.LeftColor = System.Drawing.Color.Black
      Me.txtTipo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipo.Border.RightColor = System.Drawing.Color.Black
      Me.txtTipo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipo.Border.TopColor = System.Drawing.Color.Black
      Me.txtTipo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtTipo.Height = 0.1968504!
      Me.txtTipo.Left = 0.0!
      Me.txtTipo.Name = "txtTipo"
      Me.txtTipo.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 8.25pt; vertical" & _
          "-align: middle; "
      Me.txtTipo.Text = "CHEQUES y Otros Egresos"
      Me.txtTipo.Top = 0.02!
      Me.txtTipo.Width = 2.362205!
      '
      'GroupFooter1
      '
      Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtSubTotal, Me.lblSubTotal})
      Me.GroupFooter1.Height = 0.2395833!
      Me.GroupFooter1.Name = "GroupFooter1"
      '
      'txtSubTotal
      '
      Me.txtSubTotal.Border.BottomColor = System.Drawing.Color.Black
      Me.txtSubTotal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSubTotal.Border.LeftColor = System.Drawing.Color.Black
      Me.txtSubTotal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSubTotal.Border.RightColor = System.Drawing.Color.Black
      Me.txtSubTotal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
      Me.txtSubTotal.Border.TopColor = System.Drawing.Color.Black
      Me.txtSubTotal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
      Me.txtSubTotal.DataField = "DebeHaber"
      Me.txtSubTotal.Height = 0.1968504!
      Me.txtSubTotal.Left = 3.6875!
      Me.txtSubTotal.Name = "txtSubTotal"
      Me.txtSubTotal.OutputFormat = resources.GetString("txtSubTotal.OutputFormat")
      Me.txtSubTotal.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; "
      Me.txtSubTotal.SummaryGroup = "GroupHeader1"
      Me.txtSubTotal.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
      Me.txtSubTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
      Me.txtSubTotal.Text = "SubTotal"
      Me.txtSubTotal.Top = 0.0!
      Me.txtSubTotal.Width = 0.75!
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
      Me.lblSubTotal.Height = 0.1968504!
      Me.lblSubTotal.HyperLink = Nothing
      Me.lblSubTotal.Left = 2.375!
      Me.lblSubTotal.Name = "lblSubTotal"
      Me.lblSubTotal.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8pt; vertical-align: middle; "
      Me.lblSubTotal.Text = "SUB TOTAL"
      Me.lblSubTotal.Top = 0.0!
      Me.lblSubTotal.Width = 1.304134!
      '
      'rptConciliaIngresoEgreso
      '
      Me.MasterReport = False
        OleDBDataSource1.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial " & _
            "Catalog=CONDOBO;Data Source=(LOCAL)"
      OleDBDataSource1.SQL = resources.GetString("OleDBDataSource1.SQL")
      Me.DataSource = OleDBDataSource1
      Me.PageSettings.PaperHeight = 11.0!
      Me.PageSettings.PaperWidth = 8.5!
      Me.PrintWidth = 4.458333!
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
      CType(Me.txtCompNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtChequeDes, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtChequeNro, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtTipo, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.txtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.lblSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

   Public Property Total() As Decimal
      Get
         Return mdecTotal
      End Get
      Set(ByVal value As Decimal)
         mdecTotal = value
      End Set
   End Property

   Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
      If ToStr(Me.Fields("ChequeDes").Value) = String.Empty Then
         txtChequeDes.Text = Me.Fields("CompDetDes").Value
      End If
   End Sub

   Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
      If ToLong(Me.Fields("Tipo").Value) = 1 Then
         txtTipo.Text = "* CHEQUES / DEBITO y Otros Egresos"
         txtTipo.Tag = 1
      ElseIf ToLong(Me.Fields("Tipo").Value) = 2 Then
         txtTipo.Text = "* DEPOSITOS y Otros Ingresos"
         txtTipo.Tag = 2
      End If
   End Sub

   Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
      If ToLong(txtTipo.Tag) = 1 Then
         lblSubTotal.Text = "Total Cheques     (-)"
         mdecTotal = mdecTotal - ToDecimal(txtSubTotal.Text)
      ElseIf ToLong(txtTipo.Tag) = 2 Then
         lblSubTotal.Text = "Total Depósitos   (+)"
         mdecTotal = mdecTotal + ToDecimal(txtSubTotal.Text)
      End If
   End Sub
End Class