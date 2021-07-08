Imports System.Reflection
Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports Microsoft.Win32

'--
'-- Generic About Box Dialog
'--
'-- Jeff Atwood
'-- http://www.codinghorror.com
'--
'--
Public Class frmAboutBox
   Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

   Public Sub New()
      MyBase.New()

      'This call is required by the Windows Form Designer.
      InitializeComponent()

      'Add any initialization after the InitializeComponent() call

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

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   Private WithEvents btnOK As System.Windows.Forms.Button
   Private WithEvents lblAppTitle As System.Windows.Forms.Label
   Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Private WithEvents lblAppDescription As System.Windows.Forms.Label
   Private WithEvents lblAppVersion As System.Windows.Forms.Label
   Private WithEvents lblAppCopyright As System.Windows.Forms.Label
   Private WithEvents lblAppDate As System.Windows.Forms.Label
   Private WithEvents btnDetails As System.Windows.Forms.Button
   Private WithEvents btnSysInfo As System.Windows.Forms.Button
   Private WithEvents pbImage As System.Windows.Forms.PictureBox
   Friend WithEvents txtMore As System.Windows.Forms.TextBox
   Friend WithEvents lvwAppInfo As System.Windows.Forms.ListView
   Friend WithEvents colKey As System.Windows.Forms.ColumnHeader
   Friend WithEvents colValue As System.Windows.Forms.ColumnHeader
   Friend WithEvents lvwAssemblyInfo As System.Windows.Forms.ListView
   Friend WithEvents colAssemblyName As System.Windows.Forms.ColumnHeader
   Friend WithEvents colAssemblyVersion As System.Windows.Forms.ColumnHeader
   Friend WithEvents colAssemblyBuilt As System.Windows.Forms.ColumnHeader
   Friend WithEvents colAssemblyCodeBase As System.Windows.Forms.ColumnHeader
   Friend WithEvents TabPanelDetails As System.Windows.Forms.TabControl
   Friend WithEvents TabPageApplication As System.Windows.Forms.TabPage
   Friend WithEvents TabPageAssemblies As System.Windows.Forms.TabPage
   Friend WithEvents TabPageAssemblyDetails As System.Windows.Forms.TabPage
   Friend WithEvents lvwAssemblyDetails As System.Windows.Forms.ListView
   Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
   Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
   Friend WithEvents cboAssemblyNames As System.Windows.Forms.ComboBox
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAboutBox))
      Me.btnOK = New System.Windows.Forms.Button
      Me.lblAppTitle = New System.Windows.Forms.Label
      Me.GroupBox1 = New System.Windows.Forms.GroupBox
      Me.lblAppDescription = New System.Windows.Forms.Label
      Me.lblAppVersion = New System.Windows.Forms.Label
      Me.lblAppCopyright = New System.Windows.Forms.Label
      Me.btnSysInfo = New System.Windows.Forms.Button
      Me.lblAppDate = New System.Windows.Forms.Label
      Me.pbImage = New System.Windows.Forms.PictureBox
      Me.btnDetails = New System.Windows.Forms.Button
      Me.txtMore = New System.Windows.Forms.TextBox
      Me.TabPanelDetails = New System.Windows.Forms.TabControl
      Me.TabPageApplication = New System.Windows.Forms.TabPage
      Me.lvwAppInfo = New System.Windows.Forms.ListView
      Me.colKey = New System.Windows.Forms.ColumnHeader
      Me.colValue = New System.Windows.Forms.ColumnHeader
      Me.TabPageAssemblies = New System.Windows.Forms.TabPage
      Me.lvwAssemblyInfo = New System.Windows.Forms.ListView
      Me.colAssemblyName = New System.Windows.Forms.ColumnHeader
      Me.colAssemblyVersion = New System.Windows.Forms.ColumnHeader
      Me.colAssemblyBuilt = New System.Windows.Forms.ColumnHeader
      Me.colAssemblyCodeBase = New System.Windows.Forms.ColumnHeader
      Me.TabPageAssemblyDetails = New System.Windows.Forms.TabPage
      Me.lvwAssemblyDetails = New System.Windows.Forms.ListView
      Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
      Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
      Me.cboAssemblyNames = New System.Windows.Forms.ComboBox
      CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabPanelDetails.SuspendLayout()
      Me.TabPageApplication.SuspendLayout()
      Me.TabPageAssemblies.SuspendLayout()
      Me.TabPageAssemblyDetails.SuspendLayout()
      Me.SuspendLayout()
      '
      'btnOK
      '
      Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnOK.Location = New System.Drawing.Point(376, 244)
      Me.btnOK.Name = "btnOK"
      Me.btnOK.Size = New System.Drawing.Size(76, 23)
      Me.btnOK.TabIndex = 1
      Me.btnOK.Text = "OK"
      '
      'lblAppTitle
      '
      Me.lblAppTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblAppTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblAppTitle.Location = New System.Drawing.Point(60, 8)
      Me.lblAppTitle.Name = "lblAppTitle"
      Me.lblAppTitle.Size = New System.Drawing.Size(390, 16)
      Me.lblAppTitle.TabIndex = 2
      Me.lblAppTitle.Text = "%title%"
      '
      'GroupBox1
      '
      Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(442, 2)
      Me.GroupBox1.TabIndex = 3
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "GroupBox1"
      '
      'lblAppDescription
      '
      Me.lblAppDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblAppDescription.Location = New System.Drawing.Point(60, 28)
      Me.lblAppDescription.Name = "lblAppDescription"
      Me.lblAppDescription.Size = New System.Drawing.Size(390, 16)
      Me.lblAppDescription.TabIndex = 4
      Me.lblAppDescription.Text = "%description%"
      '
      'lblAppVersion
      '
      Me.lblAppVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblAppVersion.Location = New System.Drawing.Point(8, 60)
      Me.lblAppVersion.Name = "lblAppVersion"
      Me.lblAppVersion.Size = New System.Drawing.Size(442, 16)
      Me.lblAppVersion.TabIndex = 5
      Me.lblAppVersion.Text = "Versión %version%"
      '
      'lblAppCopyright
      '
      Me.lblAppCopyright.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblAppCopyright.Location = New System.Drawing.Point(8, 100)
      Me.lblAppCopyright.Name = "lblAppCopyright"
      Me.lblAppCopyright.Size = New System.Drawing.Size(442, 16)
      Me.lblAppCopyright.TabIndex = 6
      Me.lblAppCopyright.Text = "Copyright © %year%, %company%"
      '
      'btnSysInfo
      '
      Me.btnSysInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnSysInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnSysInfo.Location = New System.Drawing.Point(276, 244)
      Me.btnSysInfo.Name = "btnSysInfo"
      Me.btnSysInfo.Size = New System.Drawing.Size(92, 23)
      Me.btnSysInfo.TabIndex = 7
      Me.btnSysInfo.Text = "&Sistema Info..."
      Me.btnSysInfo.Visible = False
      '
      'lblAppDate
      '
      Me.lblAppDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblAppDate.Location = New System.Drawing.Point(8, 80)
      Me.lblAppDate.Name = "lblAppDate"
      Me.lblAppDate.Size = New System.Drawing.Size(442, 16)
      Me.lblAppDate.TabIndex = 8
      Me.lblAppDate.Text = "Revisión del %builddate% a las %buildtime%"
      '
      'pbImage
      '
      Me.pbImage.Location = New System.Drawing.Point(8, 8)
      Me.pbImage.Name = "pbImage"
      Me.pbImage.Size = New System.Drawing.Size(44, 36)
      Me.pbImage.TabIndex = 9
      Me.pbImage.TabStop = False
      '
      'btnDetails
      '
      Me.btnDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnDetails.Location = New System.Drawing.Point(292, 244)
      Me.btnDetails.Name = "btnDetails"
      Me.btnDetails.Size = New System.Drawing.Size(76, 23)
      Me.btnDetails.TabIndex = 10
      Me.btnDetails.Text = "&Detalles >>"
      '
      'txtMore
      '
      Me.txtMore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMore.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.txtMore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtMore.Location = New System.Drawing.Point(8, 124)
      Me.txtMore.Multiline = True
      Me.txtMore.Name = "txtMore"
      Me.txtMore.ReadOnly = True
      Me.txtMore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.txtMore.Size = New System.Drawing.Size(442, 112)
      Me.txtMore.TabIndex = 13
      Me.txtMore.Text = resources.GetString("txtMore.Text")
      '
      'TabPanelDetails
      '
      Me.TabPanelDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TabPanelDetails.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
      Me.TabPanelDetails.Controls.Add(Me.TabPageApplication)
      Me.TabPanelDetails.Controls.Add(Me.TabPageAssemblies)
      Me.TabPanelDetails.Controls.Add(Me.TabPageAssemblyDetails)
      Me.TabPanelDetails.Location = New System.Drawing.Point(8, 124)
      Me.TabPanelDetails.Name = "TabPanelDetails"
      Me.TabPanelDetails.SelectedIndex = 0
      Me.TabPanelDetails.Size = New System.Drawing.Size(440, 112)
      Me.TabPanelDetails.TabIndex = 15
      Me.TabPanelDetails.Visible = False
      '
      'TabPageApplication
      '
      Me.TabPageApplication.Controls.Add(Me.lvwAppInfo)
      Me.TabPageApplication.Location = New System.Drawing.Point(4, 25)
      Me.TabPageApplication.Name = "TabPageApplication"
      Me.TabPageApplication.Size = New System.Drawing.Size(432, 83)
      Me.TabPageApplication.TabIndex = 0
      Me.TabPageApplication.Text = "Application"
      '
      'lvwAppInfo
      '
      Me.lvwAppInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKey, Me.colValue})
      Me.lvwAppInfo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvwAppInfo.FullRowSelect = True
      Me.lvwAppInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
      Me.lvwAppInfo.Location = New System.Drawing.Point(0, 0)
      Me.lvwAppInfo.Name = "lvwAppInfo"
      Me.lvwAppInfo.Size = New System.Drawing.Size(432, 83)
      Me.lvwAppInfo.TabIndex = 16
      Me.lvwAppInfo.UseCompatibleStateImageBehavior = False
      Me.lvwAppInfo.View = System.Windows.Forms.View.Details
      '
      'colKey
      '
      Me.colKey.Text = "Application Key"
      Me.colKey.Width = 120
      '
      'colValue
      '
      Me.colValue.Text = "Value"
      Me.colValue.Width = 700
      '
      'TabPageAssemblies
      '
      Me.TabPageAssemblies.Controls.Add(Me.lvwAssemblyInfo)
      Me.TabPageAssemblies.Location = New System.Drawing.Point(4, 25)
      Me.TabPageAssemblies.Name = "TabPageAssemblies"
      Me.TabPageAssemblies.Size = New System.Drawing.Size(432, 83)
      Me.TabPageAssemblies.TabIndex = 1
      Me.TabPageAssemblies.Text = "Assemblies"
      '
      'lvwAssemblyInfo
      '
      Me.lvwAssemblyInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colAssemblyName, Me.colAssemblyVersion, Me.colAssemblyBuilt, Me.colAssemblyCodeBase})
      Me.lvwAssemblyInfo.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvwAssemblyInfo.FullRowSelect = True
      Me.lvwAssemblyInfo.Location = New System.Drawing.Point(0, 0)
      Me.lvwAssemblyInfo.MultiSelect = False
      Me.lvwAssemblyInfo.Name = "lvwAssemblyInfo"
      Me.lvwAssemblyInfo.Size = New System.Drawing.Size(432, 83)
      Me.lvwAssemblyInfo.Sorting = System.Windows.Forms.SortOrder.Ascending
      Me.lvwAssemblyInfo.TabIndex = 13
      Me.lvwAssemblyInfo.UseCompatibleStateImageBehavior = False
      Me.lvwAssemblyInfo.View = System.Windows.Forms.View.Details
      '
      'colAssemblyName
      '
      Me.colAssemblyName.Text = "Assembly"
      Me.colAssemblyName.Width = 123
      '
      'colAssemblyVersion
      '
      Me.colAssemblyVersion.Text = "Version"
      Me.colAssemblyVersion.Width = 100
      '
      'colAssemblyBuilt
      '
      Me.colAssemblyBuilt.Text = "Built"
      Me.colAssemblyBuilt.Width = 130
      '
      'colAssemblyCodeBase
      '
      Me.colAssemblyCodeBase.Text = "CodeBase"
      Me.colAssemblyCodeBase.Width = 750
      '
      'TabPageAssemblyDetails
      '
      Me.TabPageAssemblyDetails.Controls.Add(Me.lvwAssemblyDetails)
      Me.TabPageAssemblyDetails.Controls.Add(Me.cboAssemblyNames)
      Me.TabPageAssemblyDetails.Location = New System.Drawing.Point(4, 25)
      Me.TabPageAssemblyDetails.Name = "TabPageAssemblyDetails"
      Me.TabPageAssemblyDetails.Size = New System.Drawing.Size(432, 83)
      Me.TabPageAssemblyDetails.TabIndex = 2
      Me.TabPageAssemblyDetails.Text = "Assembly Details"
      '
      'lvwAssemblyDetails
      '
      Me.lvwAssemblyDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
      Me.lvwAssemblyDetails.Dock = System.Windows.Forms.DockStyle.Fill
      Me.lvwAssemblyDetails.FullRowSelect = True
      Me.lvwAssemblyDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
      Me.lvwAssemblyDetails.Location = New System.Drawing.Point(0, 21)
      Me.lvwAssemblyDetails.Name = "lvwAssemblyDetails"
      Me.lvwAssemblyDetails.Size = New System.Drawing.Size(432, 62)
      Me.lvwAssemblyDetails.TabIndex = 19
      Me.lvwAssemblyDetails.UseCompatibleStateImageBehavior = False
      Me.lvwAssemblyDetails.View = System.Windows.Forms.View.Details
      '
      'ColumnHeader1
      '
      Me.ColumnHeader1.Text = "Assembly Key"
      Me.ColumnHeader1.Width = 120
      '
      'ColumnHeader2
      '
      Me.ColumnHeader2.Text = "Value"
      Me.ColumnHeader2.Width = 700
      '
      'cboAssemblyNames
      '
      Me.cboAssemblyNames.Dock = System.Windows.Forms.DockStyle.Top
      Me.cboAssemblyNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboAssemblyNames.Location = New System.Drawing.Point(0, 0)
      Me.cboAssemblyNames.Name = "cboAssemblyNames"
      Me.cboAssemblyNames.Size = New System.Drawing.Size(432, 21)
      Me.cboAssemblyNames.Sorted = True
      Me.cboAssemblyNames.TabIndex = 18
      '
      'frmAboutBox
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.CancelButton = Me.btnOK
      Me.ClientSize = New System.Drawing.Size(458, 275)
      Me.Controls.Add(Me.btnDetails)
      Me.Controls.Add(Me.pbImage)
      Me.Controls.Add(Me.lblAppDate)
      Me.Controls.Add(Me.btnSysInfo)
      Me.Controls.Add(Me.lblAppCopyright)
      Me.Controls.Add(Me.lblAppVersion)
      Me.Controls.Add(Me.lblAppDescription)
      Me.Controls.Add(Me.GroupBox1)
      Me.Controls.Add(Me.lblAppTitle)
      Me.Controls.Add(Me.btnOK)
      Me.Controls.Add(Me.txtMore)
      Me.Controls.Add(Me.TabPanelDetails)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmAboutBox"
      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Acerca de %title%"
      CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabPanelDetails.ResumeLayout(False)
      Me.TabPageApplication.ResumeLayout(False)
      Me.TabPageAssemblies.ResumeLayout(False)
      Me.TabPageAssemblyDetails.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

#End Region

   Private _blnPainted As Boolean = False
   Private _strEntryAssemblyName As String
   Private _strCallingAssemblyName As String
   Private _strExecutingAssemblyName As String
   Private _objEntryAssembly As System.Reflection.Assembly
   Private _nvcEntryAssemblyAttribs As Specialized.NameValueCollection
   Private _intMinWindowHeight As Integer

#Region "Properties"

   Public Property AppEntryAssembly() As System.Reflection.Assembly
      Get
         Return _objEntryAssembly
      End Get
      Set(ByVal Value As System.Reflection.Assembly)
         _objEntryAssembly = Value
      End Set
   End Property

   Public Property AppTitle() As String
      Get
         Return lblAppTitle.Text
      End Get
      Set(ByVal Value As String)
         lblAppTitle.Text = Value
      End Set
   End Property

   Public Property AppDescription() As String
      Get
         Return lblAppDescription.Text
      End Get
      Set(ByVal Value As String)
         If Value = "" Then
            lblAppDescription.Visible = False
         Else
            lblAppDescription.Visible = True
            lblAppDescription.Text = Value
         End If
      End Set
   End Property

   Public Property AppVersion() As String
      Get
         Return lblAppVersion.Text
      End Get
      Set(ByVal Value As String)
         If Value = "" Then
            lblAppVersion.Visible = False
         Else
            lblAppVersion.Visible = True
            lblAppVersion.Text = Value
         End If
      End Set
   End Property

   Public Property AppCopyright() As String
      Get
         Return lblAppCopyright.Text
      End Get
      Set(ByVal Value As String)
         If Value = "" Then
            lblAppCopyright.Visible = False
         Else
            lblAppCopyright.Visible = True
            lblAppCopyright.Text = Value
         End If
      End Set
   End Property

   Public Property AppImage() As Image
      Get
         Return pbImage.Image
      End Get
      Set(ByVal Value As Image)
         pbImage.Image = Value
      End Set
   End Property

   Public Property AppMoreInfo() As String
      Get
         Return txtMore.Text
      End Get
      Set(ByVal Value As String)
         If Value = "" Then
            txtMore.Visible = False
         Else
            txtMore.Visible = True
            txtMore.Text = Value
         End If
      End Set
   End Property

   Public Property AppDetailsButton() As Boolean
      Get
         Return btnDetails.Visible
      End Get
      Set(ByVal Value As Boolean)
         btnDetails.Visible = Value
      End Set
   End Property

#End Region

   '--
   '-- codebase is returned as a URI, this isn't helpful for local files
   '-- (but it is, when the URI is a web URL)
   '--
   Private Function RemoveFileURI(ByVal strCodebase As String) As String
      Return strCodebase.Replace("file:///", "")
   End Function


   Private Function AssemblyVersion(ByVal objAssembly As System.Reflection.Assembly) As String
      Try
         If objAssembly.GetName.Version.Major = 0 And objAssembly.GetName.Version.Minor = 0 Then
            Return "(unknown)"
         Else
            Return objAssembly.GetName.Version.ToString
         End If
      Catch ex As Exception
         Return "(unknown)"
      End Try
   End Function

   '--
   '-- exception-safe file attrib retrieval; we don't care if this fails
   '--
   Private Function AssemblyFileTime(ByVal objAssembly As System.Reflection.Assembly) As DateTime
      Try
         Return System.IO.File.GetLastWriteTime(objAssembly.Location)
      Catch ex As Exception
         Return DateTime.MaxValue
      End Try
   End Function

   Private Function AssemblyCodeBase(ByVal objAssembly As System.Reflection.Assembly) As String
      Try
         Return objAssembly.CodeBase
      Catch ex As System.NotSupportedException
         Return "(not supported)"
      End Try
   End Function

   '-- 
   '-- exception-safe file location retrieval
   '--
   Private Function AssemblyLocation(ByVal objAssembly As System.Reflection.Assembly) As String
      Try
         Return objAssembly.Location
      Catch ex As System.NotSupportedException
         Return "(not supported)"
      End Try
   End Function

   '--
   '-- returns build datetime of assembly
   '-- assumes default assembly value in AssemblyInfo:
   '-- <Assembly: AssemblyVersion("1.0.*")> 
   '--
   '-- filesystem create time is used, if revision and build were overridden by user
   '--
   Private Function AssemblyBuildDate(ByVal objAssembly As System.Reflection.Assembly, _
       Optional ByVal blnForceFileDate As Boolean = False) As DateTime
      Dim objVersion As System.Version = objAssembly.GetName.Version
      Dim dtBuild As DateTime

      If blnForceFileDate Then
         dtBuild = AssemblyFileTime(objAssembly)
      Else
         dtBuild = CType("01/01/2000", DateTime). _
             AddDays(objVersion.Build). _
             AddSeconds(objVersion.Revision * 2)
         If TimeZone.IsDaylightSavingTime(DateTime.Now, TimeZone.CurrentTimeZone.GetDaylightChanges(DateTime.Now.Year)) Then
            dtBuild = dtBuild.AddHours(1)
         End If
         If dtBuild > DateTime.Now Or objVersion.Build < 730 Or objVersion.Revision = 0 Then
            dtBuild = AssemblyFileTime(objAssembly)
         End If
      End If

      Return dtBuild
   End Function

   Private Function AssemblyBuildDateString(ByVal objAssembly As System.Reflection.Assembly, _
       Optional ByVal blnForceFileDate As Boolean = False) As String
      Dim dtBuild As DateTime
      dtBuild = AssemblyBuildDate(objAssembly, blnForceFileDate)
      If dtBuild = DateTime.MaxValue Then
         Return "(unknown)"
      Else
         Return dtBuild.ToString("yyyy-MM-dd hh:mm tt")
      End If
   End Function

   '--
   '-- returns string name / string value pair of all attribs
   '-- for specified assembly
   '--
   '-- note that Assembly* values are pulled from AssemblyInfo file in project folder
   '--
   '-- Trademark       = AssemblyTrademark string
   '-- Debuggable      = True
   '-- GUID            = 7FDF68D5-8C6F-44C9-B391-117B5AFB5467
   '-- CLSCompliant    = True
   '-- Product         = AssemblyProduct string
   '-- Copyright       = AssemblyCopyright string
   '-- Company         = AssemblyCompany string
   '-- Description     = AssemblyDescription string
   '-- Title           = AssemblyTitle string
   '--
   Private Function AssemblyAttribs(ByVal objAssembly As System.Reflection.Assembly) As Specialized.NameValueCollection
      Dim objAttributes() As Object
      Dim objAttribute As Object
      Dim strAttribName As String
      Dim strAttribValue As String
      Dim objNameValueCollection As New Specialized.NameValueCollection

      objAttributes = objAssembly.GetCustomAttributes(False)
      For Each objAttribute In objAttributes
         strAttribName = objAttribute.GetType().ToString()
         strAttribValue = ""
         Select Case strAttribName
            Case "System.Diagnostics.DebuggableAttribute"
               strAttribName = "Debuggable"
               strAttribValue = CType(objAttribute, System.Diagnostics.DebuggableAttribute).IsJITTrackingEnabled.ToString
            Case "System.CLSCompliantAttribute"
               strAttribName = "CLSCompliant"
               strAttribValue = CType(objAttribute, System.CLSCompliantAttribute).IsCompliant.ToString
            Case "System.Runtime.InteropServices.GuidAttribute"
               strAttribName = "GUID"
               strAttribValue = CType(objAttribute, System.Runtime.InteropServices.GuidAttribute).Value.ToString
            Case "System.Reflection.AssemblyTrademarkAttribute"
               strAttribName = "Trademark"
               strAttribValue = CType(objAttribute, AssemblyTrademarkAttribute).Trademark.ToString
            Case "System.Reflection.AssemblyProductAttribute"
               strAttribName = "Product"
               strAttribValue = CType(objAttribute, AssemblyProductAttribute).Product.ToString
            Case "System.Reflection.AssemblyCopyrightAttribute"
               strAttribName = "Copyright"
               strAttribValue = CType(objAttribute, AssemblyCopyrightAttribute).Copyright.ToString
            Case "System.Reflection.AssemblyCompanyAttribute"
               strAttribName = "Company"
               strAttribValue = CType(objAttribute, AssemblyCompanyAttribute).Company.ToString
            Case "System.Reflection.AssemblyTitleAttribute"
               strAttribName = "Title"
               strAttribValue = CType(objAttribute, AssemblyTitleAttribute).Title.ToString
            Case "System.Reflection.AssemblyDescriptionAttribute"
               strAttribName = "Description"
               strAttribValue = CType(objAttribute, AssemblyDescriptionAttribute).Description.ToString
            Case Else
               'Console.WriteLine(strAttribName)
         End Select
         If strAttribValue <> "" Then
            If objNameValueCollection.Item(strAttribName) = "" Then
               objNameValueCollection.Add(strAttribName, strAttribValue)
            End If
         End If
      Next

      Return objNameValueCollection
   End Function

   '--
   '-- reads an HKLM Registry key value
   '--
   Private Function GetHKLMValue(ByVal KeyName As String, ByVal SubKeyRef As String, ByRef KeyVal As String) As Boolean
      Dim regSubKey As RegistryKey

      Try
         regSubKey = Registry.LocalMachine.OpenSubKey(KeyName)
         KeyVal = CType(regSubKey.GetValue(SubKeyRef, ""), String)
      Catch ex As Exception
      End Try

      Return KeyVal.Length > 0
   End Function

   '--
   '-- launch the MSInfo application
   '--
   Private Sub ShowSysInfo()
      Dim strSysInfoPath As String
      Dim strRegPath As String

      '--
      '-- Reg key paths
      '--
      Const REGKEYSYSINFOLOC As String = "SOFTWARE\Microsoft\Shared Tools Location"
      Const REGVALSYSINFOLOC As String = "MSINFO"
      Const REGKEYSYSINFO As String = "SOFTWARE\Microsoft\Shared Tools\MSINFO"
      Const REGVALSYSINFO As String = "PATH"
      Const MSINFOEXE As String = "\MSINFO32.EXE"

      '--
      '-- get location of MSInfo.exe and launch it
      '--
      Try
         If GetHKLMValue(REGKEYSYSINFO, REGVALSYSINFO, strSysInfoPath) Then
            strRegPath = "Reg path: HKLM\" & REGKEYSYSINFO & "\" & REGVALSYSINFO
         ElseIf GetHKLMValue(REGKEYSYSINFOLOC, REGVALSYSINFOLOC, strSysInfoPath) Then
            strSysInfoPath = strSysInfoPath & MSINFOEXE
            strRegPath = "Reg path: HKLM\" & REGKEYSYSINFOLOC & "\" & REGVALSYSINFOLOC
         Else
            strRegPath = "MSInfo Registry Entries not found"
         End If

         If strSysInfoPath.Length > 0 Then
            If File.Exists(strSysInfoPath) Then
               Process.Start(strSysInfoPath)
               Return
            Else
               strRegPath = "MSInfo path not found"
            End If
         End If
         MessageBox.Show("System Information is unavailable at this time (" & strRegPath & ").", "AboutBox", MessageBoxButtons.OK)

      Catch ex As Exception
         MessageBox.Show("System Information is unavailable at this time (error reading registry).", "AboutBox", MessageBoxButtons.OK)
      End Try
   End Sub

   Private Sub PopulateListView(ByVal lvwAny As ListView, ByVal strKey As String, ByVal strValue As String)
      If strValue = "" Then Return
      Dim objListViewItem As New Windows.Forms.ListViewItem
      objListViewItem.Text = strKey
      objListViewItem.SubItems.Add(strValue)
      lvwAny.Items.Add(objListViewItem)
   End Sub

   Private Sub GetAppInfo()
      Dim objDomain As System.AppDomain = System.AppDomain.CurrentDomain
      PopulateListView(lvwAppInfo, "Application Name", objDomain.SetupInformation.ApplicationName)
      PopulateListView(lvwAppInfo, "Application Base", objDomain.SetupInformation.ApplicationBase)
      PopulateListView(lvwAppInfo, "Cache Path", objDomain.SetupInformation.CachePath)
      PopulateListView(lvwAppInfo, "Configuration File", objDomain.SetupInformation.ConfigurationFile)
      PopulateListView(lvwAppInfo, "Dynamic Base", objDomain.SetupInformation.DynamicBase)
      PopulateListView(lvwAppInfo, "Friendly Name", objDomain.FriendlyName)
      PopulateListView(lvwAppInfo, "License File", objDomain.SetupInformation.LicenseFile)
      PopulateListView(lvwAppInfo, "Private Bin Path", objDomain.SetupInformation.PrivateBinPath)
      PopulateListView(lvwAppInfo, "Shadow Copy Directories", objDomain.SetupInformation.ShadowCopyDirectories)
      PopulateListView(lvwAppInfo, " ", " ")
      PopulateListView(lvwAppInfo, "Entry Assembly", _strEntryAssemblyName)
      PopulateListView(lvwAppInfo, "Executing Assembly", _strExecutingAssemblyName)
      PopulateListView(lvwAppInfo, "Calling Assembly", _strCallingAssemblyName)
   End Sub

   Private Sub GetAssemblies()
      Dim objAppDomain As AppDomain = AppDomain.CurrentDomain
      Dim objAssemblies As [Assembly]() = objAppDomain.GetAssemblies()

      Dim objAssembly As [Assembly]
      For Each objAssembly In objAssemblies
         PopulateAssemblySummary(objAssembly)
      Next
      cboAssemblyNames.SelectedIndex = cboAssemblyNames.FindStringExact(_strEntryAssemblyName)
   End Sub

   '--
   '-- populate assembly summary view
   '--
   Private Sub PopulateAssemblySummary(ByVal objAssembly As [Assembly])
      Dim nvcAttribs As Specialized.NameValueCollection
      Dim objListViewItem As New Windows.Forms.ListViewItem
      Dim strAssemblyName As String

      nvcAttribs = AssemblyAttribs(objAssembly)
      With objListViewItem
         .Text = objAssembly.GetName.Name
         .Tag = objAssembly.GetName.Name
         strAssemblyName = .Text
         If strAssemblyName = _strCallingAssemblyName Then
            .Text &= " (calling)"
         End If
         If strAssemblyName = _strExecutingAssemblyName Then
            .Text &= " (executing)"
         End If
         If strAssemblyName = _strEntryAssemblyName Then
            .Text &= " (entry)"
         End If
         .SubItems.Add(AssemblyVersion(objAssembly))
         .SubItems.Add(AssemblyBuildDateString(objAssembly, True))
         .SubItems.Add(RemoveFileURI(AssemblyCodeBase(objAssembly)))
      End With
      lvwAssemblyInfo.Items.Add(objListViewItem)
      cboAssemblyNames.Items.Add(strAssemblyName)
   End Sub

   Private Function EntryAssemblyValue(ByVal strName As String) As String
      If _nvcEntryAssemblyAttribs(strName) = "" Then
         Return "<Assembly: Assembly" & strName & "("""")>"
      Else
         Return _nvcEntryAssemblyAttribs(strName).ToString
      End If
   End Function

   Private Sub PopulateLabels()
      '-- get entry assembly attribs
      _nvcEntryAssemblyAttribs = AssemblyAttribs(_objEntryAssembly)

      '-- set icon from parent, if present
      'If Me.Owner Is Nothing Then
      '   pbImage.Visible = False
      '   lblAppTitle.Left = lblAppCopyright.Left
      '   lblAppDescription.Left = lblAppCopyright.Left
      'Else
      '   Me.Icon = Me.Owner.Icon
      '   pbImage.Image = Me.Icon.ToBitmap
      'End If

      Me.Icon = Me.ParentForm.Icon
      pbImage.Image = Me.Icon.ToBitmap

      '-- replace all labels and window title
      Me.Text = DoReplacements(Me.Text)
      lblAppTitle.Text = DoReplacements(lblAppTitle.Text)
      If lblAppDescription.Visible Then
         lblAppDescription.Text = DoReplacements(lblAppDescription.Text)
      End If
      If lblAppCopyright.Visible Then
         lblAppCopyright.Text = DoReplacements(lblAppCopyright.Text)
      End If
      If lblAppVersion.Visible Then
         lblAppVersion.Text = DoReplacements(lblAppVersion.Text)
      End If
      If lblAppDate.Visible Then
         lblAppDate.Text = DoReplacements(lblAppDate.Text)
      End If
      If txtMore.Visible Then
         txtMore.Text = DoReplacements(txtMore.Text)
      End If
   End Sub


   '--
   '-- perform assemblyinfo --> string replacements on labels
   '--
   Private Function DoReplacements(ByVal strAny As String) As String
      Dim dtBuilt As DateTime
      dtBuilt = AssemblyBuildDate(_objEntryAssembly)
      strAny = strAny.Replace("%title%", EntryAssemblyValue("title"))
      strAny = strAny.Replace("%copyright%", EntryAssemblyValue("copyright"))
      strAny = strAny.Replace("%description%", EntryAssemblyValue("description"))
      strAny = strAny.Replace("%company%", EntryAssemblyValue("company"))
      strAny = strAny.Replace("%product%", EntryAssemblyValue("product"))
      strAny = strAny.Replace("%trademark%", EntryAssemblyValue("trademark"))
      strAny = strAny.Replace("%year%", DateTime.Now.Year.ToString)
      strAny = strAny.Replace("%version%", AssemblyVersion(_objEntryAssembly))
      strAny = strAny.Replace("%builddate%", dtBuilt.ToLongDateString)
      strAny = strAny.Replace("%buildtime%", dtBuilt.ToShortTimeString)
      Return strAny
   End Function

   '--
   '-- populate details for a single assembly
   '--
   Private Function PopulateAssemblyDetails(ByVal objAssembly As System.Reflection.Assembly, ByVal lvwAny As ListView) As String
      lvwAny.Items.Clear()
      Dim nvcAttribs As Specialized.NameValueCollection

      PopulateListView(lvwAny, "FullName", objAssembly.FullName)
      'PopulateListView(lvwAny, "Name", objAssembly.GetName.Name)
      'PopulateListView(lvwAny, "Version", objAssembly.GetName.Version.ToString)
      Try
         '-- this only works for framework versions 1.1+
         '-- generates exception in 1.0
         'PopulateListView(lvwAny, "Image Runtime Version", objAssembly.ImageRuntimeVersion)
      Catch ex As Exception
      End Try
      PopulateListView(lvwAny, "Loaded from GAC", objAssembly.GlobalAssemblyCache.ToString)
      PopulateListView(lvwAny, "CodeBase", AssemblyCodeBase(objAssembly))
      PopulateListView(lvwAny, "Location", AssemblyLocation(objAssembly))

      PopulateListView(lvwAny, " ", " ")

      nvcAttribs = AssemblyAttribs(objAssembly)
      Dim strKey As String
      Dim strValue As String
      For Each strKey In nvcAttribs
         PopulateListView(lvwAny, strKey, nvcAttribs.Item(strKey))
      Next

   End Function

   '--
   '-- matches assembly by Assembly.GetName.Name; returns nothing if no match
   '--
   Private Function GetAssemblyFromName(ByVal strAssemblyName As String) As System.Reflection.Assembly
      Dim objAppDomain As AppDomain = AppDomain.CurrentDomain
      Dim objAssemblies As [Assembly]() = objAppDomain.GetAssemblies()

      Dim objAssembly As [Assembly]
      For Each objAssembly In objAssemblies
         If objAssembly.GetName.Name = strAssemblyName Then
            Return objAssembly
            Exit For
         End If
      Next
   End Function

   Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      '-- if the user didn't provide an assembly, try to guess which one is root
      If _objEntryAssembly Is Nothing Then
         _objEntryAssembly = System.Reflection.Assembly.GetEntryAssembly
      End If
      '-- for web hosted apps, GetEntryAssembly = nothing
      If _objEntryAssembly Is Nothing Then
         _objEntryAssembly = System.Reflection.Assembly.GetExecutingAssembly
      End If

      _strExecutingAssemblyName = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
      _strCallingAssemblyName = System.Reflection.Assembly.GetCallingAssembly.GetName.Name
      '-- for web hosted apps, GetEntryAssembly = nothing
      Try
         _strEntryAssemblyName = System.Reflection.Assembly.GetEntryAssembly.GetName.Name
      Catch ex As Exception
      End Try

      _intMinWindowHeight = lblAppCopyright.Top + lblAppCopyright.Height + btnOK.Height + 30

      Me.TabPanelDetails.Visible = False
      If Not txtMore.Visible Then
         Me.Height = Me.Height - txtMore.Height
      End If
   End Sub

   Private Sub AboutBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
      If Not _blnPainted Then
         Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
         Application.DoEvents()
         _blnPainted = True
         PopulateLabels()
         Cursor.Current = System.Windows.Forms.Cursors.Default
      End If
   End Sub

   Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click
      Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
      btnDetails.Visible = False
      Me.SuspendLayout()
      Me.MaximizeBox = True
      Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
      Me.SizeGripStyle = Windows.Forms.SizeGripStyle.Show
      Me.Size = New Size(580, Me.Size.Height + 200)
      txtMore.Visible = False
      TabPanelDetails.Visible = True
      btnSysInfo.Visible = True
      GetAssemblies()
      GetAppInfo()
      Me.CenterToParent()
      Me.ResumeLayout()
      Cursor.Current = System.Windows.Forms.Cursors.Default
   End Sub

   Private Sub btnSysInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSysInfo.Click
      ShowSysInfo()
   End Sub

   Private Sub lvwAssemblyInfo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwAssemblyInfo.DoubleClick
      Dim strAssemblyName As String
      If lvwAssemblyInfo.SelectedItems.Count > 0 Then
         strAssemblyName = Convert.ToString(lvwAssemblyInfo.SelectedItems(0).Tag)
         cboAssemblyNames.SelectedIndex = cboAssemblyNames.FindStringExact(strAssemblyName)
         Me.TabPanelDetails.SelectedTab = Me.TabPageAssemblyDetails
      End If
   End Sub

   Private Sub cboAssemblyNames_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAssemblyNames.SelectedIndexChanged
      Dim strAssemblyName As String
      strAssemblyName = Convert.ToString(cboAssemblyNames.SelectedItem)
      PopulateAssemblyDetails(GetAssemblyFromName(strAssemblyName), lvwAssemblyDetails)
   End Sub

   Private Sub lvwAssemblyInfo_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwAssemblyInfo.ColumnClick
      Dim intTargetCol As Integer = e.Column + 1

      If Not lvwAssemblyInfo.Tag Is Nothing Then
         If Math.Abs(Convert.ToInt32(lvwAssemblyInfo.Tag)) = intTargetCol Then
            intTargetCol = -Convert.ToInt32(lvwAssemblyInfo.Tag)
         End If
      End If

      lvwAssemblyInfo.Tag = intTargetCol
      lvwAssemblyInfo.ListViewItemSorter = New ListViewItemComparer(intTargetCol)
      Dim x As New ListViewItemComparer
   End Sub

   Class ListViewItemComparer
      Implements IComparer

      Private _intCol As Integer
      Private _blnAscending As Boolean = True

      Public Sub New()
         _intCol = 0
         _blnAscending = True
      End Sub

      Public Sub New(ByVal column As Integer, Optional ByVal ascending As Boolean = True)
         If column < 0 Then
            _blnAscending = False
         Else
            _blnAscending = ascending
         End If
         _intCol = Math.Abs(column) - 1
      End Sub

      Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
         Dim intResult As Integer = _
             [String].Compare(CType(x, ListViewItem).SubItems(_intCol).Text, _
             CType(y, ListViewItem).SubItems(_intCol).Text)

         If _blnAscending Then
            Return intResult
         Else
            Return -intResult
         End If
      End Function
   End Class

   Private Sub AboutBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
      'Me.CenterToScreen()
   End Sub

   Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
      Me.Close()
   End Sub

End Class