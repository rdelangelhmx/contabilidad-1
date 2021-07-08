Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.IO
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Export
Imports DataDynamics.ActiveReports.Export.Html
Imports DataDynamics.ActiveReports.Export.Pdf
Imports DataDynamics.ActiveReports.Export.Rtf
Imports DataDynamics.ActiveReports.Export.Text
Imports DataDynamics.ActiveReports.Export.Tiff
Imports DataDynamics.ActiveReports.Export.Xls

' ExportForm - used to export a report object to a selected format (PDF, HTML, XLS, TIFF, RTF, Text)

Public Class frmReportExport
   Inherits System.Windows.Forms.Form

   Private doc As Document.Document
   Private components As System.ComponentModel.IContainer

   'Required designer variable.
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Private WithEvents lblTitle As System.Windows.Forms.Label
   Private WithEvents pnlOptions As System.Windows.Forms.Panel
   Private WithEvents PropertyGridExport As System.Windows.Forms.PropertyGrid
   Private WithEvents lblFilename As System.Windows.Forms.Label
   Private WithEvents lblExportFormat As System.Windows.Forms.Label
   Private WithEvents cboExportFormat As System.Windows.Forms.ComboBox
   Friend WithEvents btnCancel As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnOk As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnSaveFile As Janus.Windows.EditControls.UIButton
   Friend WithEvents txtFilename As Janus.Windows.GridEX.EditControls.EditBox

   Private export As Object = Nothing

   Public Sub New(ByVal doc As Document.Document)
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()
      Me.doc = doc
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportExport))
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.btnCancel = New Janus.Windows.EditControls.UIButton
      Me.btnOk = New Janus.Windows.EditControls.UIButton
      Me.lblTitle = New System.Windows.Forms.Label
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.txtFilename = New Janus.Windows.GridEX.EditControls.EditBox
      Me.btnSaveFile = New Janus.Windows.EditControls.UIButton
      Me.pnlOptions = New System.Windows.Forms.Panel
      Me.PropertyGridExport = New System.Windows.Forms.PropertyGrid
      Me.lblFilename = New System.Windows.Forms.Label
      Me.lblExportFormat = New System.Windows.Forms.Label
      Me.cboExportFormat = New System.Windows.Forms.ComboBox
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      Me.pnlOptions.SuspendLayout()
      Me.SuspendLayout()
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.btnCancel)
      Me.bcgMain.Controls.Add(Me.btnOk)
      Me.bcgMain.Controls.Add(Me.lblTitle)
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 0)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(473, 233)
      Me.bcgMain.TabIndex = 162
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'btnCancel
      '
      Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnCancel.Location = New System.Drawing.Point(380, 200)
      Me.btnCancel.Name = "btnCancel"
      Me.btnCancel.Size = New System.Drawing.Size(76, 24)
      Me.btnCancel.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnCancel.TabIndex = 6
      Me.btnCancel.Text = "Cancelar"
      Me.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnOk
      '
      Me.btnOk.ActiveFormatStyle.ForeColor = System.Drawing.Color.White
      Me.btnOk.FlatBorderColor = System.Drawing.SystemColors.ControlDark
      Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnOk.Location = New System.Drawing.Point(296, 200)
      Me.btnOk.Name = "btnOk"
      Me.btnOk.Size = New System.Drawing.Size(76, 24)
      Me.btnOk.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnOk.TabIndex = 5
      Me.btnOk.Text = "Aceptar"
      Me.btnOk.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'lblTitle
      '
      Me.lblTitle.BackColor = System.Drawing.Color.Transparent
      Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblTitle.Location = New System.Drawing.Point(8, 8)
      Me.lblTitle.Name = "lblTitle"
      Me.lblTitle.Size = New System.Drawing.Size(444, 20)
      Me.lblTitle.TabIndex = 160
      Me.lblTitle.Text = "Seleccione el formato a exportar y opcionalmente ajuste las propiedades."
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.txtFilename)
      Me.grpMain.Controls.Add(Me.btnSaveFile)
      Me.grpMain.Controls.Add(Me.pnlOptions)
      Me.grpMain.Controls.Add(Me.lblFilename)
      Me.grpMain.Controls.Add(Me.lblExportFormat)
      Me.grpMain.Controls.Add(Me.cboExportFormat)
      Me.grpMain.Location = New System.Drawing.Point(8, 28)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(456, 164)
      Me.grpMain.TabIndex = 0
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'txtFilename
      '
      Me.txtFilename.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtFilename.Location = New System.Drawing.Point(68, 40)
      Me.txtFilename.MaxLength = 100
      Me.txtFilename.Name = "txtFilename"
      Me.txtFilename.Size = New System.Drawing.Size(344, 20)
      Me.txtFilename.TabIndex = 2
      Me.txtFilename.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtFilename.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'btnSaveFile
      '
      Me.btnSaveFile.ActiveFormatStyle.ForeColor = System.Drawing.Color.White
      Me.btnSaveFile.FlatBorderColor = System.Drawing.SystemColors.ControlDark
      Me.btnSaveFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnSaveFile.Location = New System.Drawing.Point(416, 40)
      Me.btnSaveFile.Name = "btnSaveFile"
      Me.btnSaveFile.Size = New System.Drawing.Size(32, 20)
      Me.btnSaveFile.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnSaveFile.TabIndex = 3
      Me.btnSaveFile.Text = "..."
      Me.btnSaveFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'pnlOptions
      '
      Me.pnlOptions.Controls.Add(Me.PropertyGridExport)
      Me.pnlOptions.Location = New System.Drawing.Point(8, 64)
      Me.pnlOptions.Name = "pnlOptions"
      Me.pnlOptions.Size = New System.Drawing.Size(440, 90)
      Me.pnlOptions.TabIndex = 17
      '
      'PropertyGridExport
      '
      Me.PropertyGridExport.CategoryForeColor = System.Drawing.SystemColors.HotTrack
      Me.PropertyGridExport.CommandsForeColor = System.Drawing.SystemColors.HotTrack
      Me.PropertyGridExport.Dock = System.Windows.Forms.DockStyle.Fill
      Me.PropertyGridExport.HelpVisible = False
      Me.PropertyGridExport.LineColor = System.Drawing.SystemColors.ScrollBar
      Me.PropertyGridExport.Location = New System.Drawing.Point(0, 0)
      Me.PropertyGridExport.Name = "PropertyGridExport"
      Me.PropertyGridExport.PropertySort = System.Windows.Forms.PropertySort.NoSort
      Me.PropertyGridExport.Size = New System.Drawing.Size(440, 90)
      Me.PropertyGridExport.TabIndex = 4
      Me.PropertyGridExport.ToolbarVisible = False
      Me.PropertyGridExport.ViewForeColor = System.Drawing.SystemColors.HotTrack
      '
      'lblFilename
      '
      Me.lblFilename.BackColor = System.Drawing.Color.Transparent
      Me.lblFilename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblFilename.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblFilename.Location = New System.Drawing.Point(8, 42)
      Me.lblFilename.Name = "lblFilename"
      Me.lblFilename.Size = New System.Drawing.Size(56, 16)
      Me.lblFilename.TabIndex = 14
      Me.lblFilename.Text = "Nombre"
      '
      'lblExportFormat
      '
      Me.lblExportFormat.BackColor = System.Drawing.Color.Transparent
      Me.lblExportFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblExportFormat.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.lblExportFormat.Location = New System.Drawing.Point(8, 18)
      Me.lblExportFormat.Name = "lblExportFormat"
      Me.lblExportFormat.Size = New System.Drawing.Size(56, 16)
      Me.lblExportFormat.TabIndex = 13
      Me.lblExportFormat.Text = "Formato"
      '
      'cboExportFormat
      '
      Me.cboExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboExportFormat.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.cboExportFormat.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboExportFormat.Items.AddRange(New Object() {"HTML Format (HTM)", "Portable Document Format (PDF)", "Rich Text Format (RTF)", "TIFF Format (TIF)", "Text Format (TXT)", "Microsoft Excel (XLS)"})
      Me.cboExportFormat.Location = New System.Drawing.Point(68, 16)
      Me.cboExportFormat.Name = "cboExportFormat"
      Me.cboExportFormat.Size = New System.Drawing.Size(380, 21)
      Me.cboExportFormat.TabIndex = 1
      '
      'frmReportExport
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(473, 233)
      Me.Controls.Add(Me.bcgMain)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmReportExport"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Exportar Reporte"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      Me.pnlOptions.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub 'InitializeComponent 
#End Region

   Private Sub cboExportFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboExportFormat.SelectedIndexChanged
      txtFilename.Text = ""
      Me.export = Nothing
      PropertyGridExport.SelectedObject = Nothing

      'Change export format type
      Select Case cboExportFormat.SelectedIndex
         Case 0 ' html
            Me.export = New HtmlExport()
         Case 1 ' pdf
            Me.export = New PdfExport()
            PropertyGridExport.SelectedObject = Me.export
         Case 2 ' rtf
            Me.export = New RtfExport()
         Case 3 ' tiff
            Me.export = New TiffExport()
            PropertyGridExport.SelectedObject = Me.export
         Case 4 ' txt
            Me.export = New TextExport()
         Case 5 ' xls
            Me.export = New XlsExport()
            PropertyGridExport.SelectedObject = Me.export
         Case Else
            Me.export = Nothing
      End Select

      'Update PropertyGrid
      PropertyGridExport.SelectedObject = Me.export
   End Sub 'cboExportFormat_SelectedIndexChanged

   Private Sub ExportForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
      cboExportFormat.SelectedIndex = 1 ' Set to pdf export
   End Sub 'ExportForm_Load

   Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
      Me.Close()
   End Sub 'btnCancel_Click

   Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
      Try
         If txtFilename.Text.Length = 0 Then
            Return
         End If
         If File.Exists(txtFilename.Text) Then
            If MessageBox.Show(Me, "Overwrite Existing File?", "Overwrite File", MessageBoxButtons.YesNo) = DialogResult.No Then
               Return
            End If
         End If

         'Export report based on export type to selected filename
         Select Case cboExportFormat.SelectedIndex
            Case 0
               CType(export, HtmlExport).Export(Me.doc, Me.txtFilename.Text)
            Case 1
               CType(export, PdfExport).Export(Me.doc, Me.txtFilename.Text)
            Case 2
               CType(export, RtfExport).Export(Me.doc, Me.txtFilename.Text)
            Case 3
               CType(export, TiffExport).Export(Me.doc, Me.txtFilename.Text)
            Case 4
               CType(export, TextExport).Export(Me.doc, Me.txtFilename.Text)
            Case 5
               CType(export, XlsExport).Export(Me.doc, Me.txtFilename.Text)
         End Select
         Me.Close()
      Catch exp As System.IO.IOException
         MessageBox.Show(Me, exp.ToString())
      End Try
      Return
   End Sub 'btnOk_Click

   'btnSaveFile_Click - selects filename to use to save the exported report
   Private Sub btnSaveFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveFile.Click
      Dim _dlgSaveFile As New SaveFileDialog()
      _dlgSaveFile.Title = "Export Report Document"
      _dlgSaveFile.AddExtension = True

      'Set filters based on export type
      Select Case cboExportFormat.SelectedIndex
         Case 0
            _dlgSaveFile.DefaultExt = "htm"
            _dlgSaveFile.Filter = "HTML Files (*.htm;*.html)|*.htm;*.htm"
         Case 1
            _dlgSaveFile.DefaultExt = "htm"
            _dlgSaveFile.Filter = "PDF Files (*.pdf)|*.pdf"
         Case 2
            _dlgSaveFile.DefaultExt = "rtf"
            _dlgSaveFile.Filter = "Rich Text Files (*.rtf)|*.rtf"
         Case 3
            _dlgSaveFile.DefaultExt = "tif"
            _dlgSaveFile.Filter = "Tiff Image Files (*.tif)|*.tif"
         Case 4
            _dlgSaveFile.DefaultExt = "txt"
            _dlgSaveFile.Filter = "Text Files (*.txt)|*.txt"
         Case 5
            _dlgSaveFile.DefaultExt = "xls"
            _dlgSaveFile.Filter = "Microsoft Excel Files (*.xls)|*.xls"
      End Select
      If _dlgSaveFile.ShowDialog() = DialogResult.OK Then
         txtFilename.Text = _dlgSaveFile.FileName
      End If
   End Sub 'btnSaveFile_Click

   Private Sub frmReportExport_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

End Class 'ExportForm