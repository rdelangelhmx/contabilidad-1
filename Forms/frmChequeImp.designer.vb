<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChequeImp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChequeImp))
      Me.lblStatus = New System.Windows.Forms.Label
      Me.panMain = New System.Windows.Forms.Panel
      Me.txtDeAnio = New System.Windows.Forms.TextBox
      Me.txtDeMes = New System.Windows.Forms.TextBox
      Me.txtConcepto = New System.Windows.Forms.TextBox
      Me.txtLiteral = New System.Windows.Forms.TextBox
      Me.txtPaguese = New System.Windows.Forms.TextBox
      Me.txtImporte = New System.Windows.Forms.TextBox
      Me.txtMes = New System.Windows.Forms.TextBox
      Me.txtDia = New System.Windows.Forms.TextBox
      Me.txtLugar = New System.Windows.Forms.TextBox
      Me.txtAnio = New System.Windows.Forms.TextBox
      Me.panProperties = New System.Windows.Forms.Panel
      Me.txtCtrlMaxLength = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.chkVisible = New Janus.Windows.EditControls.UICheckBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtCtrlHeight = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtCtrlWidth = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtCtrlTop = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtCtrlLeft = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.txtBancoCta = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Print1 = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.panCheque = New System.Windows.Forms.Panel
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.cboOrientacion = New Janus.Windows.EditControls.UIComboBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtChequeHeight = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtChequeWidth = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label8 = New System.Windows.Forms.Label
      Me.panMain.SuspendLayout()
      Me.panProperties.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.panCheque.SuspendLayout()
      Me.SuspendLayout()
      '
      'lblStatus
      '
      Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
      Me.lblStatus.ForeColor = System.Drawing.Color.Brown
      Me.lblStatus.Location = New System.Drawing.Point(8, 8)
      Me.lblStatus.Name = "lblStatus"
      Me.lblStatus.Size = New System.Drawing.Size(204, 16)
      Me.lblStatus.TabIndex = 17
      Me.lblStatus.Text = "lblStatus"
      '
      'panMain
      '
      Me.panMain.BackColor = System.Drawing.SystemColors.Control
      Me.panMain.BackgroundImage = CType(resources.GetObject("panMain.BackgroundImage"), System.Drawing.Image)
      Me.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panMain.Controls.Add(Me.txtDeAnio)
      Me.panMain.Controls.Add(Me.txtDeMes)
      Me.panMain.Controls.Add(Me.txtConcepto)
      Me.panMain.Controls.Add(Me.txtLiteral)
      Me.panMain.Controls.Add(Me.txtPaguese)
      Me.panMain.Controls.Add(Me.txtImporte)
      Me.panMain.Controls.Add(Me.txtMes)
      Me.panMain.Controls.Add(Me.txtDia)
      Me.panMain.Controls.Add(Me.txtLugar)
      Me.panMain.Controls.Add(Me.txtAnio)
      Me.panMain.Cursor = System.Windows.Forms.Cursors.Default
      Me.panMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.panMain.ForeColor = System.Drawing.SystemColors.ControlText
      Me.panMain.Location = New System.Drawing.Point(236, 36)
      Me.panMain.Name = "panMain"
      Me.panMain.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.panMain.Size = New System.Drawing.Size(780, 324)
      Me.panMain.TabIndex = 0
      Me.panMain.TabStop = True
      '
      'txtDeAnio
      '
      Me.txtDeAnio.AcceptsReturn = True
      Me.txtDeAnio.BackColor = System.Drawing.SystemColors.Window
      Me.txtDeAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtDeAnio.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtDeAnio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDeAnio.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtDeAnio.Location = New System.Drawing.Point(364, 72)
      Me.txtDeAnio.MaxLength = 0
      Me.txtDeAnio.Multiline = True
      Me.txtDeAnio.Name = "txtDeAnio"
      Me.txtDeAnio.ReadOnly = True
      Me.txtDeAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtDeAnio.Size = New System.Drawing.Size(24, 20)
      Me.txtDeAnio.TabIndex = 5
      Me.txtDeAnio.Text = "DE_AÑO"
      Me.txtDeAnio.WordWrap = False
      '
      'txtDeMes
      '
      Me.txtDeMes.AcceptsReturn = True
      Me.txtDeMes.BackColor = System.Drawing.SystemColors.Window
      Me.txtDeMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtDeMes.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtDeMes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDeMes.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtDeMes.Location = New System.Drawing.Point(260, 72)
      Me.txtDeMes.MaxLength = 0
      Me.txtDeMes.Multiline = True
      Me.txtDeMes.Name = "txtDeMes"
      Me.txtDeMes.ReadOnly = True
      Me.txtDeMes.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtDeMes.Size = New System.Drawing.Size(24, 20)
      Me.txtDeMes.TabIndex = 2
      Me.txtDeMes.Text = "DE_MES"
      Me.txtDeMes.WordWrap = False
      '
      'txtConcepto
      '
      Me.txtConcepto.AcceptsReturn = True
      Me.txtConcepto.BackColor = System.Drawing.SystemColors.Window
      Me.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtConcepto.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtConcepto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtConcepto.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtConcepto.Location = New System.Drawing.Point(124, 160)
      Me.txtConcepto.MaxLength = 0
      Me.txtConcepto.Multiline = True
      Me.txtConcepto.Name = "txtConcepto"
      Me.txtConcepto.ReadOnly = True
      Me.txtConcepto.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtConcepto.Size = New System.Drawing.Size(428, 20)
      Me.txtConcepto.TabIndex = 10
      Me.txtConcepto.Text = "CONCEPTO"
      Me.txtConcepto.WordWrap = False
      '
      'txtLiteral
      '
      Me.txtLiteral.AcceptsReturn = True
      Me.txtLiteral.BackColor = System.Drawing.SystemColors.Window
      Me.txtLiteral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtLiteral.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtLiteral.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtLiteral.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtLiteral.Location = New System.Drawing.Point(124, 120)
      Me.txtLiteral.MaxLength = 0
      Me.txtLiteral.Multiline = True
      Me.txtLiteral.Name = "txtLiteral"
      Me.txtLiteral.ReadOnly = True
      Me.txtLiteral.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtLiteral.Size = New System.Drawing.Size(428, 20)
      Me.txtLiteral.TabIndex = 9
      Me.txtLiteral.Text = "LA SUMA DE"
      Me.txtLiteral.WordWrap = False
      '
      'txtPaguese
      '
      Me.txtPaguese.AcceptsReturn = True
      Me.txtPaguese.BackColor = System.Drawing.SystemColors.Window
      Me.txtPaguese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtPaguese.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtPaguese.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtPaguese.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtPaguese.Location = New System.Drawing.Point(124, 96)
      Me.txtPaguese.MaxLength = 0
      Me.txtPaguese.Multiline = True
      Me.txtPaguese.Name = "txtPaguese"
      Me.txtPaguese.ReadOnly = True
      Me.txtPaguese.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtPaguese.Size = New System.Drawing.Size(428, 20)
      Me.txtPaguese.TabIndex = 8
      Me.txtPaguese.Text = "PAGUESE A LA ORDEN DE"
      Me.txtPaguese.WordWrap = False
      '
      'txtImporte
      '
      Me.txtImporte.AcceptsReturn = True
      Me.txtImporte.BackColor = System.Drawing.SystemColors.Window
      Me.txtImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtImporte.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtImporte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtImporte.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtImporte.Location = New System.Drawing.Point(452, 72)
      Me.txtImporte.MaxLength = 0
      Me.txtImporte.Multiline = True
      Me.txtImporte.Name = "txtImporte"
      Me.txtImporte.ReadOnly = True
      Me.txtImporte.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtImporte.Size = New System.Drawing.Size(100, 20)
      Me.txtImporte.TabIndex = 7
      Me.txtImporte.Text = "IMPORTE"
      Me.txtImporte.WordWrap = False
      '
      'txtMes
      '
      Me.txtMes.AcceptsReturn = True
      Me.txtMes.BackColor = System.Drawing.SystemColors.Window
      Me.txtMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtMes.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtMes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMes.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtMes.Location = New System.Drawing.Point(288, 72)
      Me.txtMes.MaxLength = 0
      Me.txtMes.Multiline = True
      Me.txtMes.Name = "txtMes"
      Me.txtMes.ReadOnly = True
      Me.txtMes.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtMes.Size = New System.Drawing.Size(72, 20)
      Me.txtMes.TabIndex = 4
      Me.txtMes.Text = "MES"
      Me.txtMes.WordWrap = False
      '
      'txtDia
      '
      Me.txtDia.AcceptsReturn = True
      Me.txtDia.BackColor = System.Drawing.SystemColors.Window
      Me.txtDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtDia.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtDia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDia.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtDia.Location = New System.Drawing.Point(228, 72)
      Me.txtDia.MaxLength = 0
      Me.txtDia.Multiline = True
      Me.txtDia.Name = "txtDia"
      Me.txtDia.ReadOnly = True
      Me.txtDia.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtDia.Size = New System.Drawing.Size(28, 20)
      Me.txtDia.TabIndex = 3
      Me.txtDia.Text = "DIA"
      Me.txtDia.WordWrap = False
      '
      'txtLugar
      '
      Me.txtLugar.AcceptsReturn = True
      Me.txtLugar.BackColor = System.Drawing.SystemColors.Window
      Me.txtLugar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtLugar.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtLugar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtLugar.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtLugar.Location = New System.Drawing.Point(124, 72)
      Me.txtLugar.MaxLength = 0
      Me.txtLugar.Multiline = True
      Me.txtLugar.Name = "txtLugar"
      Me.txtLugar.ReadOnly = True
      Me.txtLugar.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtLugar.Size = New System.Drawing.Size(100, 20)
      Me.txtLugar.TabIndex = 1
      Me.txtLugar.Text = "LUGAR"
      Me.txtLugar.WordWrap = False
      '
      'txtAnio
      '
      Me.txtAnio.AcceptsReturn = True
      Me.txtAnio.BackColor = System.Drawing.SystemColors.Window
      Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.txtAnio.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtAnio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtAnio.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtAnio.Location = New System.Drawing.Point(392, 72)
      Me.txtAnio.MaxLength = 0
      Me.txtAnio.Multiline = True
      Me.txtAnio.Name = "txtAnio"
      Me.txtAnio.ReadOnly = True
      Me.txtAnio.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtAnio.Size = New System.Drawing.Size(36, 20)
      Me.txtAnio.TabIndex = 6
      Me.txtAnio.Text = "AÑO"
      Me.txtAnio.WordWrap = False
      '
      'panProperties
      '
      Me.panProperties.BackColor = System.Drawing.Color.Transparent
      Me.panProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panProperties.Controls.Add(Me.txtCtrlMaxLength)
      Me.panProperties.Controls.Add(Me.chkVisible)
      Me.panProperties.Controls.Add(Me.Label15)
      Me.panProperties.Controls.Add(Me.Label13)
      Me.panProperties.Controls.Add(Me.Label11)
      Me.panProperties.Controls.Add(Me.Label10)
      Me.panProperties.Controls.Add(Me.lblStatus)
      Me.panProperties.Controls.Add(Me.Label9)
      Me.panProperties.Controls.Add(Me.txtCtrlHeight)
      Me.panProperties.Controls.Add(Me.txtCtrlWidth)
      Me.panProperties.Controls.Add(Me.Label1)
      Me.panProperties.Controls.Add(Me.Label2)
      Me.panProperties.Controls.Add(Me.txtCtrlTop)
      Me.panProperties.Controls.Add(Me.txtCtrlLeft)
      Me.panProperties.Controls.Add(Me.Label7)
      Me.panProperties.Controls.Add(Me.Label12)
      Me.panProperties.Cursor = System.Windows.Forms.Cursors.Default
      Me.panProperties.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.panProperties.ForeColor = System.Drawing.SystemColors.ControlText
      Me.panProperties.Location = New System.Drawing.Point(4, 160)
      Me.panProperties.Name = "panProperties"
      Me.panProperties.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.panProperties.Size = New System.Drawing.Size(224, 200)
      Me.panProperties.TabIndex = 16
      Me.panProperties.TabStop = True
      '
      'txtCtrlMaxLength
      '
      Me.txtCtrlMaxLength.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCtrlMaxLength.Location = New System.Drawing.Point(88, 172)
      Me.txtCtrlMaxLength.Name = "txtCtrlMaxLength"
      Me.txtCtrlMaxLength.Size = New System.Drawing.Size(100, 20)
      Me.txtCtrlMaxLength.TabIndex = 23
      Me.txtCtrlMaxLength.Text = "0"
      Me.txtCtrlMaxLength.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtCtrlMaxLength.Value = 0
      Me.txtCtrlMaxLength.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32
      Me.txtCtrlMaxLength.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'chkVisible
      '
      Me.chkVisible.BackColor = System.Drawing.Color.Transparent
      Me.chkVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkVisible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkVisible.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.chkVisible.Location = New System.Drawing.Point(8, 152)
      Me.chkVisible.Name = "chkVisible"
      Me.chkVisible.Size = New System.Drawing.Size(96, 16)
      Me.chkVisible.TabIndex = 22
      Me.chkVisible.Text = "Visible"
      Me.chkVisible.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label15.Location = New System.Drawing.Point(192, 120)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(24, 16)
      Me.Label15.TabIndex = 208
      Me.Label15.Text = "cm"
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label13.Location = New System.Drawing.Point(192, 96)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(24, 16)
      Me.Label13.TabIndex = 207
      Me.Label13.Text = "cm"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label11.Location = New System.Drawing.Point(192, 64)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(24, 16)
      Me.Label11.TabIndex = 206
      Me.Label11.Text = "cm"
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label10.Location = New System.Drawing.Point(192, 40)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(24, 16)
      Me.Label10.TabIndex = 205
      Me.Label10.Text = "cm"
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label9.Location = New System.Drawing.Point(8, 176)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(76, 16)
      Me.Label9.TabIndex = 200
      Me.Label9.Text = "Tam. Max."
      '
      'txtCtrlHeight
      '
      Me.txtCtrlHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.txtCtrlHeight.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCtrlHeight.FormatString = "##,##0.00"
      Me.txtCtrlHeight.Location = New System.Drawing.Point(88, 116)
      Me.txtCtrlHeight.Name = "txtCtrlHeight"
      Me.txtCtrlHeight.Size = New System.Drawing.Size(100, 20)
      Me.txtCtrlHeight.TabIndex = 21
      Me.txtCtrlHeight.Text = "0,00"
      Me.txtCtrlHeight.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCtrlHeight.Value = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.txtCtrlHeight.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCtrlWidth
      '
      Me.txtCtrlWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.txtCtrlWidth.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCtrlWidth.FormatString = "##,##0.00"
      Me.txtCtrlWidth.Location = New System.Drawing.Point(88, 92)
      Me.txtCtrlWidth.Name = "txtCtrlWidth"
      Me.txtCtrlWidth.Size = New System.Drawing.Size(100, 20)
      Me.txtCtrlWidth.TabIndex = 20
      Me.txtCtrlWidth.Text = "0,00"
      Me.txtCtrlWidth.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCtrlWidth.Value = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.txtCtrlWidth.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label1.Location = New System.Drawing.Point(8, 117)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(76, 16)
      Me.Label1.TabIndex = 198
      Me.Label1.Text = "Altura"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label2.Location = New System.Drawing.Point(8, 93)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(76, 16)
      Me.Label2.TabIndex = 197
      Me.Label2.Text = "Anchura"
      '
      'txtCtrlTop
      '
      Me.txtCtrlTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.txtCtrlTop.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCtrlTop.FormatString = "##,##0.00"
      Me.txtCtrlTop.Location = New System.Drawing.Point(88, 60)
      Me.txtCtrlTop.Name = "txtCtrlTop"
      Me.txtCtrlTop.Size = New System.Drawing.Size(100, 20)
      Me.txtCtrlTop.TabIndex = 19
      Me.txtCtrlTop.Text = "0,00"
      Me.txtCtrlTop.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCtrlTop.Value = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.txtCtrlTop.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtCtrlLeft
      '
      Me.txtCtrlLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.txtCtrlLeft.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtCtrlLeft.FormatString = "##,##0.00"
      Me.txtCtrlLeft.Location = New System.Drawing.Point(88, 36)
      Me.txtCtrlLeft.Name = "txtCtrlLeft"
      Me.txtCtrlLeft.Size = New System.Drawing.Size(100, 20)
      Me.txtCtrlLeft.TabIndex = 18
      Me.txtCtrlLeft.Text = "0,00"
      Me.txtCtrlLeft.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtCtrlLeft.Value = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.txtCtrlLeft.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label7.Location = New System.Drawing.Point(8, 61)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(76, 16)
      Me.Label7.TabIndex = 194
      Me.Label7.Text = "Superior"
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label12.Location = New System.Drawing.Point(8, 37)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(76, 16)
      Me.Label12.TabIndex = 193
      Me.Label12.Text = "Izquierda"
      '
      'txtBancoCta
      '
      Me.txtBancoCta.BackColor = System.Drawing.SystemColors.Info
      Me.txtBancoCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.txtBancoCta.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtBancoCta.Location = New System.Drawing.Point(88, 6)
      Me.txtBancoCta.MaxLength = 50
      Me.txtBancoCta.Name = "txtBancoCta"
      Me.txtBancoCta.ReadOnly = True
      Me.txtBancoCta.Size = New System.Drawing.Size(126, 20)
      Me.txtBancoCta.TabIndex = 12
      Me.txtBancoCta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtBancoCta.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label14.Location = New System.Drawing.Point(6, 8)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(78, 16)
      Me.Label14.TabIndex = 202
      Me.Label14.Text = "Cuenta"
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2, Me.Print})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("feeb061d-8c44-493e-b717-3618014c7169")
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
      Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save1, Me.Separator1, Me.Print1, Me.Separator2, Me.Exit1})
      Me.UiCommandBar1.Key = "tbrMain"
      Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
      Me.UiCommandBar1.Name = "UiCommandBar1"
      Me.UiCommandBar1.RowIndex = 0
      Me.UiCommandBar1.Size = New System.Drawing.Size(230, 28)
      Me.UiCommandBar1.Text = "tbrMain"
      '
      'Save1
      '
      Me.Save1.Key = "Save"
      Me.Save1.Name = "Save1"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'Print1
      '
      Me.Print1.Key = "Print"
      Me.Print1.Name = "Print1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'Exit1
      '
      Me.Exit1.Key = "Exit"
      Me.Exit1.Name = "Exit1"
      '
      'Save
      '
      Me.Save.ImageIndex = 0
      Me.Save.Key = "Save"
      Me.Save.Name = "Save"
      Me.Save.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Save.Text = "Guardar"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 2
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Exit2.Text = "Salir"
      '
      'Print
      '
      Me.Print.ImageIndex = 1
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Print.Text = "Imprimir"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      Me.ilsMain.Images.SetKeyName(2, "")
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
      Me.TopRebar1.Size = New System.Drawing.Size(1022, 28)
      '
      'panCheque
      '
      Me.panCheque.BackColor = System.Drawing.Color.Transparent
      Me.panCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panCheque.Controls.Add(Me.Label4)
      Me.panCheque.Controls.Add(Me.Label3)
      Me.panCheque.Controls.Add(Me.txtBancoCta)
      Me.panCheque.Controls.Add(Me.Label14)
      Me.panCheque.Controls.Add(Me.cboOrientacion)
      Me.panCheque.Controls.Add(Me.Label5)
      Me.panCheque.Controls.Add(Me.txtChequeHeight)
      Me.panCheque.Controls.Add(Me.txtChequeWidth)
      Me.panCheque.Controls.Add(Me.Label6)
      Me.panCheque.Controls.Add(Me.Label8)
      Me.panCheque.Cursor = System.Windows.Forms.Cursors.Default
      Me.panCheque.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.panCheque.ForeColor = System.Drawing.SystemColors.ControlText
      Me.panCheque.Location = New System.Drawing.Point(4, 37)
      Me.panCheque.Name = "panCheque"
      Me.panCheque.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.panCheque.Size = New System.Drawing.Size(224, 115)
      Me.panCheque.TabIndex = 11
      Me.panCheque.TabStop = True
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label4.Location = New System.Drawing.Point(192, 88)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(24, 16)
      Me.Label4.TabIndex = 204
      Me.Label4.Text = "cm"
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label3.Location = New System.Drawing.Point(192, 64)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(24, 16)
      Me.Label3.TabIndex = 203
      Me.Label3.Text = "cm"
      '
      'cboOrientacion
      '
      Me.cboOrientacion.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboOrientacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.cboOrientacion.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboOrientacion.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboOrientacion.Location = New System.Drawing.Point(90, 36)
      Me.cboOrientacion.Name = "cboOrientacion"
      Me.cboOrientacion.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboOrientacion.Size = New System.Drawing.Size(124, 20)
      Me.cboOrientacion.TabIndex = 13
      Me.cboOrientacion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label5.Location = New System.Drawing.Point(8, 40)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(80, 16)
      Me.Label5.TabIndex = 200
      Me.Label5.Text = "Orientación"
      '
      'txtChequeHeight
      '
      Me.txtChequeHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.txtChequeHeight.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeHeight.FormatString = "##,##0.00"
      Me.txtChequeHeight.Location = New System.Drawing.Point(90, 84)
      Me.txtChequeHeight.Name = "txtChequeHeight"
      Me.txtChequeHeight.Size = New System.Drawing.Size(98, 20)
      Me.txtChequeHeight.TabIndex = 15
      Me.txtChequeHeight.Text = "0,00"
      Me.txtChequeHeight.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtChequeHeight.Value = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.txtChequeHeight.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtChequeWidth
      '
      Me.txtChequeWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
      Me.txtChequeWidth.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtChequeWidth.FormatString = "##,##0.00"
      Me.txtChequeWidth.Location = New System.Drawing.Point(90, 60)
      Me.txtChequeWidth.Name = "txtChequeWidth"
      Me.txtChequeWidth.Size = New System.Drawing.Size(98, 20)
      Me.txtChequeWidth.TabIndex = 14
      Me.txtChequeWidth.Text = "0,00"
      Me.txtChequeWidth.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtChequeWidth.Value = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.txtChequeWidth.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label6.Location = New System.Drawing.Point(8, 85)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(80, 16)
      Me.Label6.TabIndex = 198
      Me.Label6.Text = "Altura"
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label8.Location = New System.Drawing.Point(8, 61)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(80, 16)
      Me.Label8.TabIndex = 197
      Me.Label8.Text = "Anchura"
      '
      'frmChequeImp
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.ClientSize = New System.Drawing.Size(1022, 368)
      Me.Controls.Add(Me.panCheque)
      Me.Controls.Add(Me.panProperties)
      Me.Controls.Add(Me.panMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmChequeImp"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Diseño de la Impresión del Cheque"
      Me.panMain.ResumeLayout(False)
      Me.panMain.PerformLayout()
      Me.panProperties.ResumeLayout(False)
      Me.panProperties.PerformLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.panCheque.ResumeLayout(False)
      Me.panCheque.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents panMain As System.Windows.Forms.Panel
   Friend WithEvents lblStatus As System.Windows.Forms.Label
   Friend WithEvents panProperties As System.Windows.Forms.Panel
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents txtCtrlTop As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtCtrlLeft As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtCtrlHeight As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtCtrlWidth As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtAnio As System.Windows.Forms.TextBox
   Friend WithEvents txtMes As System.Windows.Forms.TextBox
   Friend WithEvents txtDia As System.Windows.Forms.TextBox
   Friend WithEvents txtLugar As System.Windows.Forms.TextBox
   Friend WithEvents txtLiteral As System.Windows.Forms.TextBox
   Friend WithEvents txtPaguese As System.Windows.Forms.TextBox
   Friend WithEvents txtImporte As System.Windows.Forms.TextBox
   Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
   Friend WithEvents txtBancoCta As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Print1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents panCheque As System.Windows.Forms.Panel
   Friend WithEvents cboOrientacion As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtChequeHeight As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents txtChequeWidth As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents chkVisible As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents txtDeAnio As System.Windows.Forms.TextBox
   Friend WithEvents txtDeMes As System.Windows.Forms.TextBox
   Friend WithEvents txtCtrlMaxLength As Janus.Windows.GridEX.EditControls.NumericEditBox
End Class
