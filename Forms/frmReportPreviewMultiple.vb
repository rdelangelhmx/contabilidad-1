Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.IO
Imports DataDynamics.ActiveReports
Imports System.Data
Imports System.Runtime.InteropServices
Imports DataDynamics.ActiveReports.Document

Public Class frmReportPreviewMultiple
   Inherits System.Windows.Forms.Form
   Private WithEvents arvMain As Viewer.Viewer
   Private dlgPrint As System.Windows.Forms.PrintDialog
   Friend WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents mnuFile1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuExport As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSave As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPrinterSetup As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFile As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuExport1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSave1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPrinterSetup1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Private WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
   Private components As System.ComponentModel.IContainer

   Private maxPageSize As SizeF = SizeF.Empty
   Private currentPageIndex As Integer = 0
   Private pagesAcross As Integer = 0
   Private pagesDown As Integer = 0
   Public numberOfPagesPerPrinterPage As Integer = 2 ' needs to be an even number
   Private currentNumberOfPagesPrinted As Integer = 0
   Private numberOfPagesToPrint As Integer = 0
   Private pageCount As Integer = 0
   Private Const spaceBetweenPages As Single = 0.0F ' 50 document units
   Private pageScaledSize As SizeF = SizeF.Empty
   Private scaleFactor As Single = 0.0F

   Public TipoHojaId As Long

   ' Required designer variable.

   'Public Sub New(ByVal doc As Document.Document, ByVal parentForm As Form)
   Public Sub New(ByVal doc As DataDynamics.ActiveReports.Document.Document, ByVal parentForm As Form)
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()
      'Me.MdiParent = parentForm

      arvMain.Document = doc
      Me.Text = doc.Name

      Call MaximumPageSize()

      '*BITACORA INFORMES.
      Call modAuditoria.AudiOpeAdd(parentForm.Name, parentForm.Text, clsTipoOpera.IMPRESION_INFORME, "Impresion de Informe seleccionado")
   End Sub

   'Public Sub New(ByVal doc As Document.Document, ByVal parentForm As Form)
   Public Sub New(ByVal doc As DataDynamics.ActiveReports.Document.Document)
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()
      'Me.MdiParent = parentForm

      arvMain.Document = doc
      Me.Text = doc.Name

      Call MaximumPageSize()
   End Sub

   'Form overrides dispose to clean up the component list.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

#Region "Windows Form Designer generated code"

   'Required method for Designer support - do not modify
   'the contents of this method with the code editor.
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportPreviewMultiple))
      Me.arvMain = New DataDynamics.ActiveReports.Viewer.Viewer
      Me.dlgPrint = New System.Windows.Forms.PrintDialog
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.mnuFile1 = New Janus.Windows.UI.CommandBars.UICommand("mnuFile")
      Me.mnuExport = New Janus.Windows.UI.CommandBars.UICommand("mnuExport")
      Me.mnuSave = New Janus.Windows.UI.CommandBars.UICommand("mnuSave")
      Me.mnuPrinterSetup = New Janus.Windows.UI.CommandBars.UICommand("mnuPrinterSetup")
      Me.mnuFile = New Janus.Windows.UI.CommandBars.UICommand("mnuFile")
      Me.mnuExport1 = New Janus.Windows.UI.CommandBars.UICommand("mnuExport")
      Me.mnuSave1 = New Janus.Windows.UI.CommandBars.UICommand("mnuSave")
      Me.mnuPrinterSetup1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPrinterSetup")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.PrintDocument = New System.Drawing.Printing.PrintDocument
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'arvMain
      '
      Me.arvMain.BackColor = System.Drawing.SystemColors.Control
      Me.arvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.arvMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.arvMain.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
      Me.arvMain.Location = New System.Drawing.Point(0, 26)
      Me.arvMain.Name = "arvMain"
      Me.arvMain.ReportViewer.CurrentPage = 0
      Me.arvMain.ReportViewer.MultiplePageCols = 3
      Me.arvMain.ReportViewer.MultiplePageRows = 2
      Me.arvMain.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
      Me.arvMain.Size = New System.Drawing.Size(752, 394)
      Me.arvMain.TabIndex = 0
      Me.arvMain.TableOfContents.Text = "Contents"
      Me.arvMain.TableOfContents.Width = 200
      Me.arvMain.TabTitleLength = 35
      Me.arvMain.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      '
      'cdmMain
      '
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuExport, Me.mnuSave, Me.mnuPrinterSetup, Me.mnuFile})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("4b7c9e2d-f87f-4e21-ae4c-3f0ef4d485c4")
      Me.cdmMain.LeftRebar = Me.LeftRebar1
      Me.cdmMain.RightRebar = Me.RightRebar1
      Me.cdmMain.TopRebar = Me.TopRebar1
      Me.cdmMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'BottomRebar1
      '
      Me.BottomRebar1.CommandManager = Me.cdmMain
      Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.BottomRebar1.Location = New System.Drawing.Point(0, 420)
      Me.BottomRebar1.Name = "BottomRebar1"
      Me.BottomRebar1.Size = New System.Drawing.Size(752, 0)
      '
      'UiCommandBar1
      '
      Me.UiCommandBar1.CommandBarType = Janus.Windows.UI.CommandBars.CommandBarType.Menu
      Me.UiCommandBar1.CommandManager = Me.cdmMain
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuFile1})
      Me.UiCommandBar1.Key = "mnuMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(752, 26)
      Me.UiCommandBar1.Text = "CommandBar1"
      '
      'mnuFile1
      '
      Me.mnuFile1.Key = "mnuFile"
      Me.mnuFile1.Name = "mnuFile1"
      '
      'mnuExport
      '
      Me.mnuExport.Key = "mnuExport"
      Me.mnuExport.Name = "mnuExport"
      Me.mnuExport.Text = "Exportar"
      '
      'mnuSave
      '
      Me.mnuSave.Key = "mnuSave"
      Me.mnuSave.Name = "mnuSave"
      Me.mnuSave.Text = "Guardar"
      '
      'mnuPrinterSetup
      '
      Me.mnuPrinterSetup.Key = "mnuPrinterSetup"
      Me.mnuPrinterSetup.Name = "mnuPrinterSetup"
      Me.mnuPrinterSetup.Text = "Configurar Impresora"
      '
      'mnuFile
      '
      Me.mnuFile.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuExport1, Me.mnuSave1, Me.mnuPrinterSetup1})
      Me.mnuFile.Key = "mnuFile"
      Me.mnuFile.Name = "mnuFile"
      Me.mnuFile.Text = "&Archivo"
      '
      'mnuExport1
      '
      Me.mnuExport1.Key = "mnuExport"
      Me.mnuExport1.Name = "mnuExport1"
      '
      'mnuSave1
      '
      Me.mnuSave1.Key = "mnuSave"
      Me.mnuSave1.Name = "mnuSave1"
      '
      'mnuPrinterSetup1
      '
      Me.mnuPrinterSetup1.Key = "mnuPrinterSetup"
      Me.mnuPrinterSetup1.Name = "mnuPrinterSetup1"
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 26)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 394)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(752, 26)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 394)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(752, 26)
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "Save16x16.ico")
      Me.ilsMain.Images.SetKeyName(1, "Export16x16.ico")
      Me.ilsMain.Images.SetKeyName(2, "printmgr.ico")
      '
      'PrintDocument
      '
      '
      'frmReportPreviewMultiple
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(752, 420)
      Me.Controls.Add(Me.arvMain)
      Me.Controls.Add(Me.LeftRebar1)
      Me.Controls.Add(Me.RightRebar1)
      Me.Controls.Add(Me.TopRebar1)
      Me.Controls.Add(Me.BottomRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "frmReportPreviewMultiple"
      Me.Text = "Vista Preliminar"
      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub 'InitializeComponent 
#End Region

   Private Sub frmReportPreview_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
      ' add custom buttons to the viewer's toolbar
      'Dim _ico As New Icon([GetType]().Module.Assembly.GetManifestResourceStream("DataDynamics.ActiveReports.Samples.CustomPreview.Save16x16.ico"))
      'arvMain.Toolbar.Images.Images.Add(_ico)
      arvMain.Toolbar.Images.Images.Add(ilsMain.Images(0))

      '_ico = New Icon([GetType]().Module.Assembly.GetManifestResourceStream("DataDynamics.ActiveReports.Samples.CustomPreview.Export16x16.ico"))
      'arvMain.Toolbar.Images.Images.Add(_ico)
      arvMain.Toolbar.Images.Images.Add(ilsMain.Images(1))

      '_ico = New Icon([GetType]().Module.Assembly.GetManifestResourceStream("DataDynamics.ActiveReports.Samples.CustomPreview.Export16x16.ico"))
      'arvMain.Toolbar.Images.Images.Add(_ico)
      arvMain.Toolbar.Images.Images.Add(ilsMain.Images(2))

      'Add Export button to the toolbar
      Dim _btn As New DataDynamics.ActiveReports.Toolbar.Button
      _btn.ImageIndex = 14 ' new images were added to Toolbar.Images 
      _btn.ButtonStyle = DataDynamics.ActiveReports.Toolbar.ButtonStyle.Icon
      _btn.Caption = "Save"
      _btn.Id = 5001 ' unique identifier for the new tool
      _btn.ToolTip = "Save Report Document"
      arvMain.Toolbar.Tools.Insert(1, CType(_btn, DataDynamics.ActiveReports.Toolbar.Tool))

      'Add Export button to the toolbar
      _btn = New DataDynamics.ActiveReports.Toolbar.Button
      _btn.ImageIndex = 15
      _btn.Id = 5002
      _btn.ButtonStyle = DataDynamics.ActiveReports.Toolbar.ButtonStyle.Icon
      _btn.Caption = "Export"
      _btn.ToolTip = "Export Report Document"
      arvMain.Toolbar.Tools.Insert(2, CType(_btn, DataDynamics.ActiveReports.Toolbar.Tool))

      'Add Separator to the toolbar
      Dim _Sep As New DataDynamics.ActiveReports.Toolbar.Separator
      arvMain.Toolbar.Tools.Insert(3, CType(_Sep, DataDynamics.ActiveReports.Toolbar.Separator))

      'Add Save button to the toolbar
      _btn = New DataDynamics.ActiveReports.Toolbar.Button
      _btn.ImageIndex = 16
      _btn.Id = 5003
      _btn.ButtonStyle = DataDynamics.ActiveReports.Toolbar.ButtonStyle.TextAndIcon
      _btn.Caption = "&Print..."
      _btn.ToolTip = "Print Document"
      arvMain.Toolbar.Tools.Insert(4, CType(_btn, DataDynamics.ActiveReports.Toolbar.Tool))

      arvMain.Toolbar.Tools(5).Visible = False
      arvMain.Toolbar.Tools(6).Visible = False
   End Sub 'frmReportPreview_Load

   Private Sub arViewer_ToolClick(ByVal sender As Object, ByVal e As DataDynamics.ActiveReports.Toolbar.ToolClickEventArgs) Handles arvMain.ToolClick
      'Add code to run when new buttons are clicked
      Try
         Select Case e.Tool.Id
            Case 5001 'Save button
               Me.SaveDocument()

            Case 5002 'Export button
               Me.ExportDocument()

            Case 5003 'Print button
               Me.PrintReport()
         End Select

      Catch exp As System.IO.IOException
         MessageBox.Show(exp.ToString())
      End Try
   End Sub 'arViewer_ToolClick

   'Saves out an existing report document to the RDF format.
   Private Sub SaveDocument()
      Dim _dlgSave As New SaveFileDialog

      _dlgSave.Title = "Save Report Document"
      _dlgSave.Filter = "Report Document Files (*.rdf)|*.rdf"
      _dlgSave.DefaultExt = "rdf"
      _dlgSave.AddExtension = True

      If _dlgSave.ShowDialog(Me) = DialogResult.OK Then
         If File.Exists(_dlgSave.FileName) Then
            If MessageBox.Show(Me, "Overwrite Existing File?", "Overwrite", MessageBoxButtons.YesNo) <> DialogResult.Yes Then
               Return
            End If
         End If

         arvMain.Document.Save(_dlgSave.FileName)
      End If
   End Sub 'SaveDocument

   'Opens the export form to export out the current report document
   Private Sub ExportDocument()
      Dim _exportForm As New frmReportExport(arvMain.Document)
      _exportForm.ShowDialog(Me)
   End Sub 'ExportDocument

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Select Case e.Command.Key
         Case "mnuExport"
            Me.ExportDocument()

         Case "mnuSave"
            Me.SaveDocument()

         Case "mnuPrinterSetup"
            If Not (Me.arvMain.Document Is Nothing) Then
               Me.dlgPrint.UseEXDialog = True
               Me.dlgPrint.Document = Me.arvMain.Document.Printer
               dlgPrint.ShowDialog(Me)
            End If
      End Select
   End Sub

   Public Sub PrintReport()
      Me.dlgPrint.UseEXDialog = True
      Me.dlgPrint.Document = Me.PrintDocument

      If DialogResult.OK = Me.dlgPrint.ShowDialog(Me) Then
         If Me.numberOfPagesPerPrinterPage Mod 2 > 0 Then
            Me.numberOfPagesPerPrinterPage = Me.numberOfPagesPerPrinterPage / 2 * 2
         End If ' Setup defaults

         Me.currentNumberOfPagesPrinted = 0
         Me.numberOfPagesToPrint = Me.pageCount / Me.numberOfPagesPerPrinterPage
         Me.numberOfPagesToPrint += IIf(Me.pageCount Mod Me.numberOfPagesPerPrinterPage > 0, 1, 0)
         Me.PrintDocument.Print()
      End If
   End Sub

   Private Sub MaximumPageSize()
      ' Find the maximum page size
      Dim pages As PagesCollection = Me.arvMain.Document.Pages
      Dim page As Page
      Me.pageCount = pages.Count
      Dim pageIndex As Integer

      For pageIndex = 0 To (Me.pageCount) - 1
         page = pages(pageIndex)

         If Me.maxPageSize.Width < page.Size.Width Then
            Me.maxPageSize.Width = page.Size.Width
         End If

         If Me.maxPageSize.Height < page.Size.Height Then
            Me.maxPageSize.Height = page.Size.Height
         End If
      Next pageIndex

      ' Convert to document units
      Me.maxPageSize.Width *= 100
      Me.maxPageSize.Height *= 100

      If Me.pageCount > 0 Then
         arvMain.Toolbar.Tools.Item(6).Enabled = False
      End If
   End Sub

   Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
      If Me.currentPageIndex < Me.pageCount Then
         Dim bounds As RectangleF  '= e.PageBounds
         bounds.Width = e.Graphics.VisibleClipBounds.Width
         bounds.Height = e.Graphics.VisibleClipBounds.Height

         If Me.currentPageIndex = 0 Then
            Me.pagesAcross = numberOfPagesPerPrinterPage / 2
            Me.pagesDown = numberOfPagesPerPrinterPage / pagesAcross
            Me.pageScaledSize.Width = (bounds.Width - spaceBetweenPages * (pagesAcross - 1)) / pagesAcross
            Me.pageScaledSize.Height = (bounds.Height - spaceBetweenPages * (pagesDown - 1)) / pagesDown
            Me.scaleFactor = Me.pageScaledSize.Width / Me.maxPageSize.Width

            If Me.scaleFactor > Me.pageScaledSize.Height / Me.maxPageSize.Height Then
               Me.scaleFactor = Me.pageScaledSize.Height / Me.maxPageSize.Height
            End If
         End If

         Dim printRectangle As RectangleF = bounds
         printRectangle.Width = Me.pageScaledSize.Width
         printRectangle.Height = Me.pageScaledSize.Height
         Dim pageRectangleInches As RectangleF = RectangleF.Empty
         'Dim pageRectangle As RectangleF = RectangleF.Empty
         Dim page As Page
         Dim column As Integer = 0
         Dim startIndex As Integer = Me.currentPageIndex
         Dim pages As PagesCollection = Me.arvMain.Document.Pages

         While Me.currentPageIndex < Me.pageCount AndAlso (startIndex = Me.currentPageIndex OrElse Me.currentPageIndex Mod numberOfPagesPerPrinterPage <> 0)
            page = pages(Me.currentPageIndex)

            pageRectangleInches.X = printRectangle.X / 100
            pageRectangleInches.Y = printRectangle.Y / 100
            pageRectangleInches.Width = page.Width * Me.scaleFactor
            pageRectangleInches.Height = page.Height * Me.scaleFactor

            'pageRectangle = printRectangle
            'pageRectangle.Width = page.Width * 100 * Me.scaleFactor
            'pageRectangle.Height = page.Height * 100 * Me.scaleFactor
            'e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(pageRectangle))
            page.Draw(e.Graphics, pageRectangleInches, Me.scaleFactor, Me.scaleFactor, True)

            column += 1
            If column >= Me.pagesAcross Then
               column = 0
               printRectangle.X = bounds.X
               printRectangle.Y += printRectangle.Height + spaceBetweenPages
            Else
               printRectangle.X += printRectangle.Width + spaceBetweenPages
            End If
            Me.currentPageIndex = Me.currentPageIndex + 1
         End While
      End If

      Me.currentNumberOfPagesPrinted = Me.currentNumberOfPagesPrinted + 1
      e.HasMorePages = Me.currentNumberOfPagesPrinted < Me.numberOfPagesToPrint

      If Not e.HasMorePages Then
         Me.currentPageIndex = 0
      End If
   End Sub

   ''mnuExport_Click - called the ExportDocument() call to export out the
   ''current report document
   'Private Sub mnuExport_Click(ByVal sender As Object, ByVal e As System.EventArgs)
   '   Me.ExportDocument()
   'End Sub 'mnuExport_Click

   ''mnuSaveDocument_Click - called the SaveDocument() call to save the 
   ''current report document to the RDF format.
   'Private Sub mnuSaveDocument_Click(ByVal sender As Object, ByVal e As System.EventArgs)
   '   Me.SaveDocument()
   'End Sub 'mnuSaveDocument_Click

   ''mnuPrinterSetup_Click - opens the Printer Dialog box to assist in
   ''printer setup.
   'Private Sub mnuPrinterSetup_Click(ByVal sender As Object, ByVal e As System.EventArgs)
   '   If Not (Me.arvMain.Document Is Nothing) Then
   '      Me.dlgPrint.Document = Me.arvMain.Document.Printer
   '      dlgPrint.ShowDialog(Me)
   '   End If
   'End Sub 'mnuPrinterSetup_Click

End Class 'frmReportPreview