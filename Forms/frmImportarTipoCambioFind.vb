Imports Microsoft.Office.Interop

Public Class frmImportarTipoCambioFind
   Inherits System.Windows.Forms.Form

   Public moDataSet As System.Data.DataSet
   Private moDataAdapter As System.Data.OleDb.OleDbDataAdapter
   Private moConnection As System.Data.OleDb.OleDbConnection
   Private mlngOpcion As Long
   Private mboolShow As Boolean
   Private mboolChanged As Boolean
   Friend WithEvents txtHoja As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents btnRuta As Janus.Windows.EditControls.UIButton
   Friend WithEvents ofdDialogo As System.Windows.Forms.OpenFileDialog
   Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents optAmbos As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optUFV As Janus.Windows.EditControls.UIRadioButton
   Friend WithEvents optTipoCambio As Janus.Windows.EditControls.UIRadioButton
   Private mlngID As Long

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   Public ReadOnly Property DataObject() As DataSet
      Get
         Return moDataSet
      End Get
   End Property

   Public ReadOnly Property Opcion() As Long
      Get
         Return mlngOpcion
      End Get
   End Property

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
   Friend WithEvents OpenExcel As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents grpMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents lblRuta As System.Windows.Forms.Label
   Friend WithEvents txtRuta As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportarTipoCambioFind))
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("OpenExcel")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.OpenExcel = New Janus.Windows.UI.CommandBars.UICommand("OpenExcel")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.grpMain = New Janus.Windows.EditControls.UIGroupBox
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.optAmbos = New Janus.Windows.EditControls.UIRadioButton
      Me.optUFV = New Janus.Windows.EditControls.UIRadioButton
      Me.optTipoCambio = New Janus.Windows.EditControls.UIRadioButton
      Me.btnRuta = New Janus.Windows.EditControls.UIButton
      Me.txtHoja = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtRuta = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.lblRuta = New System.Windows.Forms.Label
      Me.ofdDialogo = New System.Windows.Forms.OpenFileDialog
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpMain.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.OpenExcel, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("0e9a011c-64a3-47fa-80f4-631873a99f25")
      Me.cdmMain.ImageList = Me.ilsMain
      Me.cdmMain.LeftRebar = Me.LeftRebar1
      Me.cdmMain.RightRebar = Me.RightRebar1
      Me.cdmMain.TopRebar = Me.TopRebar1
      Me.cdmMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'BottomRebar1
      '
      Me.BottomRebar1.CommandManager = Me.cdmMain
      Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
      Me.BottomRebar1.Name = "BottomRebar1"
      Me.BottomRebar1.Size = New System.Drawing.Size(0, 0)
      '
      'UiCommandBar1
      '
      Me.UiCommandBar1.CommandManager = Me.cdmMain
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(186, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Key = "OpenExcel"
      Me.Save1.Name = "Save1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'OpenExcel
      '
      Me.OpenExcel.ImageIndex = 4
      Me.OpenExcel.Key = "OpenExcel"
      Me.OpenExcel.Name = "OpenExcel"
      Me.OpenExcel.Text = "Importar Datos"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 1
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      Me.ilsMain.Images.SetKeyName(2, "Excel.JPG")
      Me.ilsMain.Images.SetKeyName(3, "search-icon-orange.gif")
      Me.ilsMain.Images.SetKeyName(4, "application-vnd.ms-excel.png")
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 0)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 0)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(470, 28)
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.grpMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(470, 115)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'grpMain
      '
      Me.grpMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.grpMain.Controls.Add(Me.UiGroupBox1)
      Me.grpMain.Controls.Add(Me.btnRuta)
      Me.grpMain.Controls.Add(Me.txtHoja)
      Me.grpMain.Controls.Add(Me.txtRuta)
      Me.grpMain.Controls.Add(Me.Label4)
      Me.grpMain.Controls.Add(Me.lblRuta)
      Me.grpMain.Location = New System.Drawing.Point(8, 0)
      Me.grpMain.Name = "grpMain"
      Me.grpMain.Size = New System.Drawing.Size(456, 108)
      Me.grpMain.TabIndex = 160
      Me.grpMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox1.Controls.Add(Me.optAmbos)
      Me.UiGroupBox1.Controls.Add(Me.optUFV)
      Me.UiGroupBox1.Controls.Add(Me.optTipoCambio)
      Me.UiGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.UiGroupBox1.Location = New System.Drawing.Point(12, 8)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(436, 40)
      Me.UiGroupBox1.TabIndex = 1
      Me.UiGroupBox1.Text = "Importar"
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'optAmbos
      '
      Me.optAmbos.Checked = True
      Me.optAmbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optAmbos.Location = New System.Drawing.Point(32, 16)
      Me.optAmbos.Name = "optAmbos"
      Me.optAmbos.Size = New System.Drawing.Size(64, 16)
      Me.optAmbos.TabIndex = 1
      Me.optAmbos.TabStop = True
      Me.optAmbos.Text = "Ambos"
      '
      'optUFV
      '
      Me.optUFV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optUFV.Location = New System.Drawing.Point(356, 16)
      Me.optUFV.Name = "optUFV"
      Me.optUFV.Size = New System.Drawing.Size(60, 16)
      Me.optUFV.TabIndex = 3
      Me.optUFV.Text = "U.F.V"
      '
      'optTipoCambio
      '
      Me.optTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.optTipoCambio.Location = New System.Drawing.Point(176, 16)
      Me.optTipoCambio.Name = "optTipoCambio"
      Me.optTipoCambio.Size = New System.Drawing.Size(96, 16)
      Me.optTipoCambio.TabIndex = 2
      Me.optTipoCambio.Text = "Tipo Cambio"
      '
      'btnRuta
      '
      Me.btnRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnRuta.ImageIndex = 3
      Me.btnRuta.ImageList = Me.ilsMain
      Me.btnRuta.Location = New System.Drawing.Point(428, 56)
      Me.btnRuta.Name = "btnRuta"
      Me.btnRuta.Size = New System.Drawing.Size(19, 20)
      Me.btnRuta.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.btnRuta.TabIndex = 3
      Me.btnRuta.TabStop = False
      Me.btnRuta.Tag = "Ruta"
      Me.btnRuta.ToolTipText = "Busca la Ruta de la Hoja de Excel"
      Me.btnRuta.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtHoja
      '
      Me.txtHoja.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtHoja.Location = New System.Drawing.Point(107, 80)
      Me.txtHoja.MaxLength = 255
      Me.txtHoja.Name = "txtHoja"
      Me.txtHoja.Size = New System.Drawing.Size(276, 20)
      Me.txtHoja.TabIndex = 4
      Me.txtHoja.Text = "TC-UFV"
      Me.txtHoja.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtHoja.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtRuta
      '
      Me.txtRuta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtRuta.Location = New System.Drawing.Point(106, 56)
      Me.txtRuta.MaxLength = 255
      Me.txtRuta.Name = "txtRuta"
      Me.txtRuta.Size = New System.Drawing.Size(320, 20)
      Me.txtRuta.TabIndex = 2
      Me.txtRuta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtRuta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 83)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(104, 16)
      Me.Label4.TabIndex = 171
      Me.Label4.Text = "Nombre de Hoja"
      '
      'lblRuta
      '
      Me.lblRuta.BackColor = System.Drawing.Color.Transparent
      Me.lblRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblRuta.Location = New System.Drawing.Point(8, 59)
      Me.lblRuta.Name = "lblRuta"
      Me.lblRuta.Size = New System.Drawing.Size(104, 16)
      Me.lblRuta.TabIndex = 168
      Me.lblRuta.Text = "Ruta"
      '
      'ofdDialogo
      '
      Me.ofdDialogo.Title = "Cargar Pedido de Excel"
      '
      'frmImportarTipoCambioFind
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(470, 143)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmImportarTipoCambioFind"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Importar Datos desde Excel"
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.grpMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpMain.ResumeLayout(False)
      Me.grpMain.PerformLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key

         Case "OpenExcel"
            If Abrir_Excel() Then
               mboolChanged = True
               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmImportarTipoCambioFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmImportarTipoCambioFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Call FormInit()

      Call ClearMemory()
      Me.Cursor = oCursor
   End Sub

   Private Function Abrir_Excel() As Boolean
      Dim oExcel As Excel.Application

      Try
         If FormCheck() Then

            If ExcelOpen(oExcel, txtRuta.Text) Then

               'Creamos un objeto OLEDBConnection con el nombre del archivo seleccionado
               ' como Data Source
               moConnection = New System.Data.OleDb.OleDbConnection( _
                     "Provider=Microsoft.ACE.OLEDB.12.0; " & _
                     "Data Source=" & txtRuta.Text.Trim & "; Extended Properties=""Excel 12.0 Xml; HDR=YES; IMEX=2"";")


               '* Si queremos seleccionar toda la hoja solo especificamos [Sheet1$]
               moDataAdapter = New System.Data.OleDb.OleDbDataAdapter( _
                    "select * from [" & txtHoja.Text & "$]  ", moConnection)
               'where [Sheet1$A4] = 'Aruba'

               moDataSet = New System.Data.DataSet
               moDataAdapter.Fill(moDataSet)
               moConnection.Close()

               Call ExcelKill(oExcel)

               Return True

            End If
         End If

      Catch ex As Exception
         MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Call ExcelKill(oExcel)
         Return False
      End Try
   End Function

   Private Function FormCheck() As Boolean
      Dim strMsg As String = String.Empty

      If txtRuta.Text.Length = 0 Then
         strMsg &= "Busque y Seleccione la Ruta del Excel" & vbCrLf
      End If

      If txtHoja.Text.Length = 0 Then
         strMsg &= "Escriba el nombre de la Hoja" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         FormCheck = False
      Else
         FormCheck = True
      End If
   End Function

   Private Sub btnRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuta.Click
      BuscarExcel()
   End Sub

   Private Sub BuscarExcel()
      ofdDialogo.DefaultExt = "*.xls"
      ofdDialogo.Filter = "Excel | *.xls|Excel 2007 (*.xlsx)| *.xlsx"
      If ofdDialogo.ShowDialog = DialogResult.Cancel Then
         Exit Sub
      End If

      txtRuta.Text = ofdDialogo.FileName
   End Sub

   Private Sub FormInit()
      Call FormCenter(Me)
      mlngOpcion = 1
   End Sub

   Private Sub frmImportarTipoCambioFind_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Insert) And (e.Shift = True) Then
            Call BuscarExcel()

         ElseIf (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If Abrir_Excel() Then
               mboolChanged = True
               Me.Close()

            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmImportarTipoCambioFind_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      Call ClearMemory()
   End Sub

   Private Sub SelectOption(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAmbos.CheckedChanged, optTipoCambio.CheckedChanged, optUFV.CheckedChanged
      If optAmbos.Checked Then
         mlngOpcion = 1
         txtHoja.Text = "TC-UFV"
      ElseIf optTipoCambio.Checked Then
         mlngOpcion = 2
         txtHoja.Text = "SoloTC"
      ElseIf optUFV.Checked Then
         mlngOpcion = 3
         txtHoja.Text = "SoloUFV"
      End If
   End Sub
End Class
