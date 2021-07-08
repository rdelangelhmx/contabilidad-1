Public Class frmEmpresaPara
   Inherits System.Windows.Forms.Form

   Private moEmpresaPara As clsEmpresaPara
   Private mlngEmpresaId As Long

   Private mboolLoading As Boolean
   Private mboolShow As Boolean
   Private mboolAdding As Boolean
   Private mboolEditing As Boolean
   Private mboolChanged As Boolean

   Friend WithEvents chkAplicarDescuento As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtMontoMinFac As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblMontoMinFac As System.Windows.Forms.Label
   Friend WithEvents lblMonedaMinFac As System.Windows.Forms.Label
   Friend WithEvents lblMonedaMinOpe As System.Windows.Forms.Label
   Friend WithEvents txtMontoMinOpe As Janus.Windows.GridEX.EditControls.NumericEditBox
   Friend WithEvents lblMontoMinOpe As System.Windows.Forms.Label
   Friend WithEvents cboPlanITPDif As Janus.Windows.GridEX.EditControls.MultiColumnCombo

   Friend WithEvents chkAplicarITPDif As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkExigirEEFF As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkValidarSaldoCajaBanco As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents dudDecimalCant As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
   Friend WithEvents txtDocTexto As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents Otros As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents chkAplicarDosificaVend As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkAplicarControlInv As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkRepSinGestion As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkAplicarMedAlternativa As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents chkExigirActAnaAdd As Janus.Windows.EditControls.UICheckBox
   Private mlngID As Long

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   WriteOnly Property NewRecord() As Boolean
      Set(ByVal Value As Boolean)
         mboolAdding = Value
      End Set
   End Property

   WriteOnly Property Editing() As Boolean
      Set(ByVal Value As Boolean)
         mboolEditing = Value
      End Set
   End Property

   ReadOnly Property Changed() As Boolean
      Get
         Return mboolChanged
      End Get
   End Property

   Property ID() As Long
      Get
         Return mlngID
      End Get

      Set(ByVal Value As Long)
         mlngID = Value
      End Set
   End Property

   WriteOnly Property DataObject() As clsEmpresaPara
      Set(ByVal Value As clsEmpresaPara)
         moEmpresaPara = Value
      End Set
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
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents Save As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Save1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents tabMain As Janus.Windows.UI.Tab.UITab
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
   Friend WithEvents chkInventario As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboPlanCre As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanDeb As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanIT As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanITP As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanDif As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanRes As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Public WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboTipoHoja As Janus.Windows.EditControls.UIComboBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dudDecimalNro As Janus.Windows.GridEX.EditControls.IntegerUpDown
   Friend WithEvents txtEmpresaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents txtEmpresaParaId As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cboPlanITF As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents chkItemCodShow As Janus.Windows.EditControls.UICheckBox
   Public WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
   Public WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents chkPlanCtaShow As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtEmpresaGral As Janus.Windows.GridEX.EditControls.EditBox
   Friend WithEvents chkMultipleNro As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents chkFechaOpera As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents cboPlanAitb As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents chkCodBarra As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents UiTabPage4 As Janus.Windows.UI.Tab.UITabPage
   Public WithEvents UiGroupBox4 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboPlanITRet As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanCreRet As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents cboPlanIUERetSer As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label25 As System.Windows.Forms.Label
   Friend WithEvents cboPlanIUERetBie As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents chkCentroCostoApli As Janus.Windows.EditControls.UICheckBox
   Friend WithEvents cboPlanIceIehd As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents UiTabPage5 As Janus.Windows.UI.Tab.UITabPage
   Public WithEvents UiGroupBox5 As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents cboPlanIceIehdDif As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents cboPlanDebDif As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents cboPlanCreDif As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents cboPlanExento As Janus.Windows.GridEX.EditControls.MultiColumnCombo
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents chkSepararExento As Janus.Windows.EditControls.UICheckBox

   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpresaPara))
      Dim cboPlanExento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanIceIehd_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanAitb_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanITP_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanDif_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanIT_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanDeb_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanCre_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanITF_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanRes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanITPDif_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanIceIehdDif_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanDebDif_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanCreDif_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanIUERetBie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanITRet_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanCreRet_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Dim cboPlanIUERetSer_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.tabMain = New Janus.Windows.UI.Tab.UITab
      Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
      Me.BtnBuscar = New Janus.Windows.EditControls.UIButton
      Me.txtDocTexto = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label23 = New System.Windows.Forms.Label
      Me.dudDecimalCant = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.lblMonedaMinOpe = New System.Windows.Forms.Label
      Me.lblMonedaMinFac = New System.Windows.Forms.Label
      Me.txtMontoMinOpe = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.txtMontoMinFac = New Janus.Windows.GridEX.EditControls.NumericEditBox
      Me.lblMontoMinFac = New System.Windows.Forms.Label
      Me.lblMontoMinOpe = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtEmpresaGral = New Janus.Windows.GridEX.EditControls.EditBox
      Me.cboTipoHoja = New Janus.Windows.EditControls.UIComboBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.dudDecimalNro = New Janus.Windows.GridEX.EditControls.IntegerUpDown
      Me.txtEmpresaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.txtEmpresaParaId = New Janus.Windows.GridEX.EditControls.EditBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboPlanExento = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label19 = New System.Windows.Forms.Label
      Me.cboPlanIceIehd = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label17 = New System.Windows.Forms.Label
      Me.cboPlanAitb = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label13 = New System.Windows.Forms.Label
      Me.cboPlanITP = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboPlanDif = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboPlanIT = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label14 = New System.Windows.Forms.Label
      Me.cboPlanDeb = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label10 = New System.Windows.Forms.Label
      Me.cboPlanCre = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboPlanITF = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.cboPlanRes = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label9 = New System.Windows.Forms.Label
      Me.UiTabPage5 = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox5 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboPlanITPDif = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label20 = New System.Windows.Forms.Label
      Me.cboPlanIceIehdDif = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label18 = New System.Windows.Forms.Label
      Me.cboPlanDebDif = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label7 = New System.Windows.Forms.Label
      Me.cboPlanCreDif = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label8 = New System.Windows.Forms.Label
      Me.UiTabPage4 = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox4 = New Janus.Windows.EditControls.UIGroupBox
      Me.cboPlanIUERetBie = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label16 = New System.Windows.Forms.Label
      Me.cboPlanITRet = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboPlanCreRet = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.cboPlanIUERetSer = New Janus.Windows.GridEX.EditControls.MultiColumnCombo
      Me.Label21 = New System.Windows.Forms.Label
      Me.Label22 = New System.Windows.Forms.Label
      Me.Label25 = New System.Windows.Forms.Label
      Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage
      Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
      Me.chkValidarSaldoCajaBanco = New Janus.Windows.EditControls.UICheckBox
      Me.chkAplicarDescuento = New Janus.Windows.EditControls.UICheckBox
      Me.chkExigirEEFF = New Janus.Windows.EditControls.UICheckBox
      Me.chkAplicarITPDif = New Janus.Windows.EditControls.UICheckBox
      Me.chkSepararExento = New Janus.Windows.EditControls.UICheckBox
      Me.chkCentroCostoApli = New Janus.Windows.EditControls.UICheckBox
      Me.chkCodBarra = New Janus.Windows.EditControls.UICheckBox
      Me.chkFechaOpera = New Janus.Windows.EditControls.UICheckBox
      Me.chkMultipleNro = New Janus.Windows.EditControls.UICheckBox
      Me.chkPlanCtaShow = New Janus.Windows.EditControls.UICheckBox
      Me.chkItemCodShow = New Janus.Windows.EditControls.UICheckBox
      Me.chkInventario = New Janus.Windows.EditControls.UICheckBox
      Me.Otros = New Janus.Windows.UI.Tab.UITabPage
      Me.chkExigirActAnaAdd = New Janus.Windows.EditControls.UICheckBox
      Me.chkAplicarMedAlternativa = New Janus.Windows.EditControls.UICheckBox
      Me.chkAplicarDosificaVend = New Janus.Windows.EditControls.UICheckBox
      Me.chkAplicarControlInv = New Janus.Windows.EditControls.UICheckBox
      Me.chkRepSinGestion = New Janus.Windows.EditControls.UICheckBox
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.Save1 = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.Exit1 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.Save = New Janus.Windows.UI.CommandBars.UICommand("Save")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabMain.SuspendLayout()
      Me.UiTabPage1.SuspendLayout()
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox1.SuspendLayout()
      Me.UiTabPage2.SuspendLayout()
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox2.SuspendLayout()
      CType(Me.cboPlanExento, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanIceIehd, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanAitb, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanITP, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanDif, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanIT, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanDeb, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanCre, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanITF, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanRes, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiTabPage5.SuspendLayout()
      CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox5.SuspendLayout()
      CType(Me.cboPlanITPDif, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanIceIehdDif, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanDebDif, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanCreDif, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiTabPage4.SuspendLayout()
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox4.SuspendLayout()
      CType(Me.cboPlanIUERetBie, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanITRet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanCreRet, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.cboPlanIUERetSer, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiTabPage3.SuspendLayout()
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.UiGroupBox3.SuspendLayout()
      Me.Otros.SuspendLayout()
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.tabMain)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 28)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(456, 346)
      Me.bcgMain.TabIndex = 161
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'tabMain
      '
      Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tabMain.Location = New System.Drawing.Point(8, 8)
      Me.tabMain.Name = "tabMain"
      Me.tabMain.Size = New System.Drawing.Size(440, 332)
      Me.tabMain.TabIndex = 0
      Me.tabMain.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2, Me.UiTabPage5, Me.UiTabPage4, Me.UiTabPage3, Me.Otros})
      Me.tabMain.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007
      '
      'UiTabPage1
      '
      Me.UiTabPage1.Controls.Add(Me.UiGroupBox1)
      Me.UiTabPage1.Key = "General"
      Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
      Me.UiTabPage1.Name = "UiTabPage1"
      Me.UiTabPage1.Size = New System.Drawing.Size(438, 310)
      Me.UiTabPage1.TabStop = True
      Me.UiTabPage1.Text = "General"
      '
      'UiGroupBox1
      '
      Me.UiGroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox1.Controls.Add(Me.BtnBuscar)
      Me.UiGroupBox1.Controls.Add(Me.txtDocTexto)
      Me.UiGroupBox1.Controls.Add(Me.Label23)
      Me.UiGroupBox1.Controls.Add(Me.dudDecimalCant)
      Me.UiGroupBox1.Controls.Add(Me.lblMonedaMinOpe)
      Me.UiGroupBox1.Controls.Add(Me.lblMonedaMinFac)
      Me.UiGroupBox1.Controls.Add(Me.txtMontoMinOpe)
      Me.UiGroupBox1.Controls.Add(Me.txtMontoMinFac)
      Me.UiGroupBox1.Controls.Add(Me.lblMontoMinFac)
      Me.UiGroupBox1.Controls.Add(Me.lblMontoMinOpe)
      Me.UiGroupBox1.Controls.Add(Me.Label6)
      Me.UiGroupBox1.Controls.Add(Me.txtEmpresaGral)
      Me.UiGroupBox1.Controls.Add(Me.cboTipoHoja)
      Me.UiGroupBox1.Controls.Add(Me.Label4)
      Me.UiGroupBox1.Controls.Add(Me.dudDecimalNro)
      Me.UiGroupBox1.Controls.Add(Me.txtEmpresaId)
      Me.UiGroupBox1.Controls.Add(Me.txtEmpresaParaId)
      Me.UiGroupBox1.Controls.Add(Me.Label1)
      Me.UiGroupBox1.Controls.Add(Me.Label2)
      Me.UiGroupBox1.Controls.Add(Me.Label3)
      Me.UiGroupBox1.Location = New System.Drawing.Point(8, 0)
      Me.UiGroupBox1.Name = "UiGroupBox1"
      Me.UiGroupBox1.Size = New System.Drawing.Size(424, 304)
      Me.UiGroupBox1.TabIndex = 0
      Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
      '
      'BtnBuscar
      '
      Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
      Me.BtnBuscar.Location = New System.Drawing.Point(392, 184)
      Me.BtnBuscar.Name = "BtnBuscar"
      Me.BtnBuscar.Size = New System.Drawing.Size(24, 20)
      Me.BtnBuscar.StateStyles.FormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.BtnBuscar.TabIndex = 222
      Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'txtDocTexto
      '
      Me.txtDocTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtDocTexto.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtDocTexto.Location = New System.Drawing.Point(124, 184)
      Me.txtDocTexto.Name = "txtDocTexto"
      Me.txtDocTexto.ReadOnly = True
      Me.txtDocTexto.Size = New System.Drawing.Size(269, 20)
      Me.txtDocTexto.TabIndex = 221
      Me.txtDocTexto.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtDocTexto.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label23
      '
      Me.Label23.BackColor = System.Drawing.Color.Transparent
      Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label23.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Label23.Location = New System.Drawing.Point(8, 188)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(100, 16)
      Me.Label23.TabIndex = 223
      Me.Label23.Text = "Repositorio"
      Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'dudDecimalCant
      '
      Me.dudDecimalCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudDecimalCant.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudDecimalCant.Location = New System.Drawing.Point(124, 64)
      Me.dudDecimalCant.Maximum = 5
      Me.dudDecimalCant.Minimum = 1
      Me.dudDecimalCant.Name = "dudDecimalCant"
      Me.dudDecimalCant.Size = New System.Drawing.Size(112, 20)
      Me.dudDecimalCant.TabIndex = 220
      Me.dudDecimalCant.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudDecimalCant.Value = 3
      Me.dudDecimalCant.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblMonedaMinOpe
      '
      Me.lblMonedaMinOpe.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.lblMonedaMinOpe.BackColor = System.Drawing.Color.Transparent
      Me.lblMonedaMinOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMonedaMinOpe.Location = New System.Drawing.Point(240, 140)
      Me.lblMonedaMinOpe.Name = "lblMonedaMinOpe"
      Me.lblMonedaMinOpe.Size = New System.Drawing.Size(156, 16)
      Me.lblMonedaMinOpe.TabIndex = 201
      '
      'lblMonedaMinFac
      '
      Me.lblMonedaMinFac.Anchor = System.Windows.Forms.AnchorStyles.Top
      Me.lblMonedaMinFac.BackColor = System.Drawing.Color.Transparent
      Me.lblMonedaMinFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMonedaMinFac.Location = New System.Drawing.Point(240, 164)
      Me.lblMonedaMinFac.Name = "lblMonedaMinFac"
      Me.lblMonedaMinFac.Size = New System.Drawing.Size(156, 16)
      Me.lblMonedaMinFac.TabIndex = 198
      '
      'txtMontoMinOpe
      '
      Me.txtMontoMinOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoMinOpe.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoMinOpe.FormatString = "##,##0.000"
      Me.txtMontoMinOpe.Location = New System.Drawing.Point(124, 136)
      Me.txtMontoMinOpe.Name = "txtMontoMinOpe"
      Me.txtMontoMinOpe.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoMinOpe.TabIndex = 199
      Me.txtMontoMinOpe.Text = "0.000"
      Me.txtMontoMinOpe.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoMinOpe.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoMinOpe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtMontoMinFac
      '
      Me.txtMontoMinFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtMontoMinFac.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtMontoMinFac.FormatString = "##,##0.000"
      Me.txtMontoMinFac.Location = New System.Drawing.Point(124, 160)
      Me.txtMontoMinFac.Name = "txtMontoMinFac"
      Me.txtMontoMinFac.Size = New System.Drawing.Size(108, 20)
      Me.txtMontoMinFac.TabIndex = 173
      Me.txtMontoMinFac.Text = "0.000"
      Me.txtMontoMinFac.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
      Me.txtMontoMinFac.Value = New Decimal(New Integer() {0, 0, 0, 196608})
      Me.txtMontoMinFac.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'lblMontoMinFac
      '
      Me.lblMontoMinFac.BackColor = System.Drawing.Color.Transparent
      Me.lblMontoMinFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMontoMinFac.Location = New System.Drawing.Point(8, 164)
      Me.lblMontoMinFac.Name = "lblMontoMinFac"
      Me.lblMontoMinFac.Size = New System.Drawing.Size(112, 16)
      Me.lblMontoMinFac.TabIndex = 174
      Me.lblMontoMinFac.Text = "M. Min Factura"
      '
      'lblMontoMinOpe
      '
      Me.lblMontoMinOpe.BackColor = System.Drawing.Color.Transparent
      Me.lblMontoMinOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblMontoMinOpe.Location = New System.Drawing.Point(8, 140)
      Me.lblMontoMinOpe.Name = "lblMontoMinOpe"
      Me.lblMontoMinOpe.Size = New System.Drawing.Size(112, 16)
      Me.lblMontoMinOpe.TabIndex = 200
      Me.lblMontoMinOpe.Text = "Monto Min Oper"
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(8, 116)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(112, 16)
      Me.Label6.TabIndex = 215
      Me.Label6.Text = "Cabecera Reporte"
      '
      'txtEmpresaGral
      '
      Me.txtEmpresaGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmpresaGral.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaGral.Location = New System.Drawing.Point(124, 112)
      Me.txtEmpresaGral.MaxLength = 255
      Me.txtEmpresaGral.Name = "txtEmpresaGral"
      Me.txtEmpresaGral.Size = New System.Drawing.Size(292, 20)
      Me.txtEmpresaGral.TabIndex = 5
      Me.txtEmpresaGral.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaGral.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboTipoHoja
      '
      Me.cboTipoHoja.FlatBorderColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboTipoHoja.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.ItemsFormatStyle.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboTipoHoja.Location = New System.Drawing.Point(124, 88)
      Me.cboTipoHoja.Name = "cboTipoHoja"
      Me.cboTipoHoja.SelectedItemFormatStyle.ForeColor = System.Drawing.Color.White
      Me.cboTipoHoja.Size = New System.Drawing.Size(292, 20)
      Me.cboTipoHoja.TabIndex = 4
      Me.cboTipoHoja.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(8, 92)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(112, 16)
      Me.Label4.TabIndex = 213
      Me.Label4.Text = "Tamaño Hoja"
      '
      'dudDecimalNro
      '
      Me.dudDecimalNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dudDecimalNro.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.dudDecimalNro.Location = New System.Drawing.Point(304, 64)
      Me.dudDecimalNro.Maximum = 5
      Me.dudDecimalNro.Minimum = 1
      Me.dudDecimalNro.Name = "dudDecimalNro"
      Me.dudDecimalNro.Size = New System.Drawing.Size(112, 20)
      Me.dudDecimalNro.TabIndex = 3
      Me.dudDecimalNro.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.dudDecimalNro.Value = 3
      Me.dudDecimalNro.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaId
      '
      Me.txtEmpresaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmpresaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaId.Location = New System.Drawing.Point(124, 40)
      Me.txtEmpresaId.Name = "txtEmpresaId"
      Me.txtEmpresaId.ReadOnly = True
      Me.txtEmpresaId.Size = New System.Drawing.Size(292, 20)
      Me.txtEmpresaId.TabIndex = 2
      Me.txtEmpresaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'txtEmpresaParaId
      '
      Me.txtEmpresaParaId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtEmpresaParaId.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.txtEmpresaParaId.Location = New System.Drawing.Point(124, 16)
      Me.txtEmpresaParaId.Name = "txtEmpresaParaId"
      Me.txtEmpresaParaId.ReadOnly = True
      Me.txtEmpresaParaId.Size = New System.Drawing.Size(112, 20)
      Me.txtEmpresaParaId.TabIndex = 1
      Me.txtEmpresaParaId.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.txtEmpresaParaId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(8, 68)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(112, 16)
      Me.Label1.TabIndex = 210
      Me.Label1.Text = "Decimales"
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(8, 44)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(112, 16)
      Me.Label2.TabIndex = 209
      Me.Label2.Text = "Empresa"
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(8, 20)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(112, 16)
      Me.Label3.TabIndex = 208
      Me.Label3.Text = "ID"
      '
      'UiTabPage2
      '
      Me.UiTabPage2.Controls.Add(Me.UiGroupBox2)
      Me.UiTabPage2.Key = "Cuentas"
      Me.UiTabPage2.Location = New System.Drawing.Point(1, 21)
      Me.UiTabPage2.Name = "UiTabPage2"
      Me.UiTabPage2.Size = New System.Drawing.Size(438, 310)
      Me.UiTabPage2.TabStop = True
      Me.UiTabPage2.Text = "Cuentas"
      '
      'UiGroupBox2
      '
      Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox2.Controls.Add(Me.cboPlanExento)
      Me.UiGroupBox2.Controls.Add(Me.Label19)
      Me.UiGroupBox2.Controls.Add(Me.cboPlanIceIehd)
      Me.UiGroupBox2.Controls.Add(Me.Label17)
      Me.UiGroupBox2.Controls.Add(Me.cboPlanAitb)
      Me.UiGroupBox2.Controls.Add(Me.Label13)
      Me.UiGroupBox2.Controls.Add(Me.cboPlanITP)
      Me.UiGroupBox2.Controls.Add(Me.cboPlanDif)
      Me.UiGroupBox2.Controls.Add(Me.cboPlanIT)
      Me.UiGroupBox2.Controls.Add(Me.Label14)
      Me.UiGroupBox2.Controls.Add(Me.cboPlanDeb)
      Me.UiGroupBox2.Controls.Add(Me.Label10)
      Me.UiGroupBox2.Controls.Add(Me.cboPlanCre)
      Me.UiGroupBox2.Controls.Add(Me.cboPlanITF)
      Me.UiGroupBox2.Controls.Add(Me.Label5)
      Me.UiGroupBox2.Controls.Add(Me.Label12)
      Me.UiGroupBox2.Controls.Add(Me.Label11)
      Me.UiGroupBox2.Controls.Add(Me.Label15)
      Me.UiGroupBox2.Controls.Add(Me.cboPlanRes)
      Me.UiGroupBox2.Controls.Add(Me.Label9)
      Me.UiGroupBox2.Location = New System.Drawing.Point(8, 0)
      Me.UiGroupBox2.Name = "UiGroupBox2"
      Me.UiGroupBox2.Size = New System.Drawing.Size(424, 304)
      Me.UiGroupBox2.TabIndex = 6
      Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboPlanExento
      '
      cboPlanExento_DesignTimeLayout.LayoutString = resources.GetString("cboPlanExento_DesignTimeLayout.LayoutString")
      Me.cboPlanExento.DesignTimeLayout = cboPlanExento_DesignTimeLayout
      Me.cboPlanExento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanExento.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanExento.Location = New System.Drawing.Point(124, 160)
      Me.cboPlanExento.Name = "cboPlanExento"
      Me.cboPlanExento.SelectedIndex = -1
      Me.cboPlanExento.SelectedItem = Nothing
      Me.cboPlanExento.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanExento.TabIndex = 13
      Me.cboPlanExento.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanExento.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label19
      '
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label19.Location = New System.Drawing.Point(8, 164)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(112, 16)
      Me.Label19.TabIndex = 187
      Me.Label19.Text = "Exento"
      '
      'cboPlanIceIehd
      '
      cboPlanIceIehd_DesignTimeLayout.LayoutString = resources.GetString("cboPlanIceIehd_DesignTimeLayout.LayoutString")
      Me.cboPlanIceIehd.DesignTimeLayout = cboPlanIceIehd_DesignTimeLayout
      Me.cboPlanIceIehd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanIceIehd.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanIceIehd.Location = New System.Drawing.Point(124, 136)
      Me.cboPlanIceIehd.Name = "cboPlanIceIehd"
      Me.cboPlanIceIehd.SelectedIndex = -1
      Me.cboPlanIceIehd.SelectedItem = Nothing
      Me.cboPlanIceIehd.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanIceIehd.TabIndex = 12
      Me.cboPlanIceIehd.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanIceIehd.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label17
      '
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label17.Location = New System.Drawing.Point(8, 140)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(112, 16)
      Me.Label17.TabIndex = 185
      Me.Label17.Text = "ICE / IEHD"
      '
      'cboPlanAitb
      '
      cboPlanAitb_DesignTimeLayout.LayoutString = resources.GetString("cboPlanAitb_DesignTimeLayout.LayoutString")
      Me.cboPlanAitb.DesignTimeLayout = cboPlanAitb_DesignTimeLayout
      Me.cboPlanAitb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanAitb.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanAitb.Location = New System.Drawing.Point(124, 208)
      Me.cboPlanAitb.Name = "cboPlanAitb"
      Me.cboPlanAitb.SelectedIndex = -1
      Me.cboPlanAitb.SelectedItem = Nothing
      Me.cboPlanAitb.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanAitb.TabIndex = 15
      Me.cboPlanAitb.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanAitb.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label13
      '
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.Location = New System.Drawing.Point(8, 212)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(112, 16)
      Me.Label13.TabIndex = 183
      Me.Label13.Text = "A.I.T.B."
      '
      'cboPlanITP
      '
      cboPlanITP_DesignTimeLayout.LayoutString = resources.GetString("cboPlanITP_DesignTimeLayout.LayoutString")
      Me.cboPlanITP.DesignTimeLayout = cboPlanITP_DesignTimeLayout
      Me.cboPlanITP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanITP.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanITP.Location = New System.Drawing.Point(124, 88)
      Me.cboPlanITP.Name = "cboPlanITP"
      Me.cboPlanITP.SelectedIndex = -1
      Me.cboPlanITP.SelectedItem = Nothing
      Me.cboPlanITP.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanITP.TabIndex = 10
      Me.cboPlanITP.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanITP.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanDif
      '
      cboPlanDif_DesignTimeLayout.LayoutString = resources.GetString("cboPlanDif_DesignTimeLayout.LayoutString")
      Me.cboPlanDif.DesignTimeLayout = cboPlanDif_DesignTimeLayout
      Me.cboPlanDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanDif.Location = New System.Drawing.Point(124, 184)
      Me.cboPlanDif.Name = "cboPlanDif"
      Me.cboPlanDif.SelectedIndex = -1
      Me.cboPlanDif.SelectedItem = Nothing
      Me.cboPlanDif.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanDif.TabIndex = 14
      Me.cboPlanDif.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanDif.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanIT
      '
      cboPlanIT_DesignTimeLayout.LayoutString = resources.GetString("cboPlanIT_DesignTimeLayout.LayoutString")
      Me.cboPlanIT.DesignTimeLayout = cboPlanIT_DesignTimeLayout
      Me.cboPlanIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanIT.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanIT.Location = New System.Drawing.Point(124, 64)
      Me.cboPlanIT.Name = "cboPlanIT"
      Me.cboPlanIT.SelectedIndex = -1
      Me.cboPlanIT.SelectedItem = Nothing
      Me.cboPlanIT.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanIT.TabIndex = 9
      Me.cboPlanIT.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanIT.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label14
      '
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label14.Location = New System.Drawing.Point(8, 188)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(112, 16)
      Me.Label14.TabIndex = 174
      Me.Label14.Text = "Dif. Cambio"
      '
      'cboPlanDeb
      '
      cboPlanDeb_DesignTimeLayout.LayoutString = resources.GetString("cboPlanDeb_DesignTimeLayout.LayoutString")
      Me.cboPlanDeb.DesignTimeLayout = cboPlanDeb_DesignTimeLayout
      Me.cboPlanDeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanDeb.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanDeb.Location = New System.Drawing.Point(124, 40)
      Me.cboPlanDeb.Name = "cboPlanDeb"
      Me.cboPlanDeb.SelectedIndex = -1
      Me.cboPlanDeb.SelectedItem = Nothing
      Me.cboPlanDeb.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanDeb.TabIndex = 8
      Me.cboPlanDeb.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanDeb.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.Location = New System.Drawing.Point(8, 44)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(112, 16)
      Me.Label10.TabIndex = 171
      Me.Label10.Text = "Débito Fiscal"
      '
      'cboPlanCre
      '
      cboPlanCre_DesignTimeLayout.LayoutString = resources.GetString("cboPlanCre_DesignTimeLayout.LayoutString")
      Me.cboPlanCre.DesignTimeLayout = cboPlanCre_DesignTimeLayout
      Me.cboPlanCre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanCre.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanCre.Location = New System.Drawing.Point(124, 16)
      Me.cboPlanCre.Name = "cboPlanCre"
      Me.cboPlanCre.SelectedIndex = -1
      Me.cboPlanCre.SelectedItem = Nothing
      Me.cboPlanCre.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanCre.TabIndex = 7
      Me.cboPlanCre.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanCre.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanITF
      '
      cboPlanITF_DesignTimeLayout.LayoutString = resources.GetString("cboPlanITF_DesignTimeLayout.LayoutString")
      Me.cboPlanITF.DesignTimeLayout = cboPlanITF_DesignTimeLayout
      Me.cboPlanITF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanITF.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanITF.Location = New System.Drawing.Point(124, 112)
      Me.cboPlanITF.Name = "cboPlanITF"
      Me.cboPlanITF.SelectedIndex = -1
      Me.cboPlanITF.SelectedItem = Nothing
      Me.cboPlanITF.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanITF.TabIndex = 11
      Me.cboPlanITF.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanITF.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 116)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(112, 16)
      Me.Label5.TabIndex = 177
      Me.Label5.Text = "I.T. F."
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.Location = New System.Drawing.Point(8, 92)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(112, 16)
      Me.Label12.TabIndex = 173
      Me.Label12.Text = "I.T. Por Pagar"
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 68)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(112, 16)
      Me.Label11.TabIndex = 172
      Me.Label11.Text = "Imp. Transac."
      '
      'Label15
      '
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label15.Location = New System.Drawing.Point(8, 236)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(112, 16)
      Me.Label15.TabIndex = 175
      Me.Label15.Text = "Resultado"
      '
      'cboPlanRes
      '
      cboPlanRes_DesignTimeLayout.LayoutString = resources.GetString("cboPlanRes_DesignTimeLayout.LayoutString")
      Me.cboPlanRes.DesignTimeLayout = cboPlanRes_DesignTimeLayout
      Me.cboPlanRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanRes.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanRes.Location = New System.Drawing.Point(124, 232)
      Me.cboPlanRes.Name = "cboPlanRes"
      Me.cboPlanRes.SelectedIndex = -1
      Me.cboPlanRes.SelectedItem = Nothing
      Me.cboPlanRes.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanRes.TabIndex = 16
      Me.cboPlanRes.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanRes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 20)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(112, 16)
      Me.Label9.TabIndex = 170
      Me.Label9.Text = "Crédito Fiscal"
      '
      'UiTabPage5
      '
      Me.UiTabPage5.Controls.Add(Me.UiGroupBox5)
      Me.UiTabPage5.Key = "Varios"
      Me.UiTabPage5.Location = New System.Drawing.Point(1, 21)
      Me.UiTabPage5.Name = "UiTabPage5"
      Me.UiTabPage5.Size = New System.Drawing.Size(438, 310)
      Me.UiTabPage5.TabStop = True
      Me.UiTabPage5.Tag = "Transitorio"
      Me.UiTabPage5.Text = "Varios"
      '
      'UiGroupBox5
      '
      Me.UiGroupBox5.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox5.Controls.Add(Me.cboPlanITPDif)
      Me.UiGroupBox5.Controls.Add(Me.Label20)
      Me.UiGroupBox5.Controls.Add(Me.cboPlanIceIehdDif)
      Me.UiGroupBox5.Controls.Add(Me.Label18)
      Me.UiGroupBox5.Controls.Add(Me.cboPlanDebDif)
      Me.UiGroupBox5.Controls.Add(Me.Label7)
      Me.UiGroupBox5.Controls.Add(Me.cboPlanCreDif)
      Me.UiGroupBox5.Controls.Add(Me.Label8)
      Me.UiGroupBox5.Location = New System.Drawing.Point(7, 3)
      Me.UiGroupBox5.Name = "UiGroupBox5"
      Me.UiGroupBox5.Size = New System.Drawing.Size(424, 301)
      Me.UiGroupBox5.TabIndex = 17
      Me.UiGroupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboPlanITPDif
      '
      cboPlanITPDif_DesignTimeLayout.LayoutString = resources.GetString("cboPlanITPDif_DesignTimeLayout.LayoutString")
      Me.cboPlanITPDif.DesignTimeLayout = cboPlanITPDif_DesignTimeLayout
      Me.cboPlanITPDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanITPDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanITPDif.Location = New System.Drawing.Point(128, 88)
      Me.cboPlanITPDif.Name = "cboPlanITPDif"
      Me.cboPlanITPDif.SelectedIndex = -1
      Me.cboPlanITPDif.SelectedItem = Nothing
      Me.cboPlanITPDif.Size = New System.Drawing.Size(288, 20)
      Me.cboPlanITPDif.TabIndex = 192
      Me.cboPlanITPDif.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanITPDif.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label20
      '
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.Location = New System.Drawing.Point(8, 92)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(120, 16)
      Me.Label20.TabIndex = 193
      Me.Label20.Text = "IT Diferido"
      '
      'cboPlanIceIehdDif
      '
      cboPlanIceIehdDif_DesignTimeLayout.LayoutString = resources.GetString("cboPlanIceIehdDif_DesignTimeLayout.LayoutString")
      Me.cboPlanIceIehdDif.DesignTimeLayout = cboPlanIceIehdDif_DesignTimeLayout
      Me.cboPlanIceIehdDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanIceIehdDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanIceIehdDif.Location = New System.Drawing.Point(128, 64)
      Me.cboPlanIceIehdDif.Name = "cboPlanIceIehdDif"
      Me.cboPlanIceIehdDif.SelectedIndex = -1
      Me.cboPlanIceIehdDif.SelectedItem = Nothing
      Me.cboPlanIceIehdDif.Size = New System.Drawing.Size(288, 20)
      Me.cboPlanIceIehdDif.TabIndex = 20
      Me.cboPlanIceIehdDif.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanIceIehdDif.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label18
      '
      Me.Label18.BackColor = System.Drawing.Color.Transparent
      Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 68)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(128, 16)
      Me.Label18.TabIndex = 191
      Me.Label18.Text = "ICE / IEHD Diferido"
      '
      'cboPlanDebDif
      '
      cboPlanDebDif_DesignTimeLayout.LayoutString = resources.GetString("cboPlanDebDif_DesignTimeLayout.LayoutString")
      Me.cboPlanDebDif.DesignTimeLayout = cboPlanDebDif_DesignTimeLayout
      Me.cboPlanDebDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanDebDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanDebDif.Location = New System.Drawing.Point(128, 40)
      Me.cboPlanDebDif.Name = "cboPlanDebDif"
      Me.cboPlanDebDif.SelectedIndex = -1
      Me.cboPlanDebDif.SelectedItem = Nothing
      Me.cboPlanDebDif.Size = New System.Drawing.Size(288, 20)
      Me.cboPlanDebDif.TabIndex = 19
      Me.cboPlanDebDif.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanDebDif.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 44)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(120, 16)
      Me.Label7.TabIndex = 189
      Me.Label7.Text = "Déb. Fis. Diferido"
      '
      'cboPlanCreDif
      '
      cboPlanCreDif_DesignTimeLayout.LayoutString = resources.GetString("cboPlanCreDif_DesignTimeLayout.LayoutString")
      Me.cboPlanCreDif.DesignTimeLayout = cboPlanCreDif_DesignTimeLayout
      Me.cboPlanCreDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanCreDif.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanCreDif.Location = New System.Drawing.Point(128, 16)
      Me.cboPlanCreDif.Name = "cboPlanCreDif"
      Me.cboPlanCreDif.SelectedIndex = -1
      Me.cboPlanCreDif.SelectedItem = Nothing
      Me.cboPlanCreDif.Size = New System.Drawing.Size(288, 20)
      Me.cboPlanCreDif.TabIndex = 18
      Me.cboPlanCreDif.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanCreDif.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.Location = New System.Drawing.Point(8, 20)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(120, 16)
      Me.Label8.TabIndex = 187
      Me.Label8.Text = "Créd. Fis. Diferido"
      '
      'UiTabPage4
      '
      Me.UiTabPage4.Controls.Add(Me.UiGroupBox4)
      Me.UiTabPage4.Key = "Retenciones"
      Me.UiTabPage4.Location = New System.Drawing.Point(1, 21)
      Me.UiTabPage4.Name = "UiTabPage4"
      Me.UiTabPage4.Size = New System.Drawing.Size(438, 310)
      Me.UiTabPage4.TabStop = True
      Me.UiTabPage4.Tag = "Retencion"
      Me.UiTabPage4.Text = "Retenciones"
      '
      'UiGroupBox4
      '
      Me.UiGroupBox4.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox4.Controls.Add(Me.cboPlanIUERetBie)
      Me.UiGroupBox4.Controls.Add(Me.Label16)
      Me.UiGroupBox4.Controls.Add(Me.cboPlanITRet)
      Me.UiGroupBox4.Controls.Add(Me.cboPlanCreRet)
      Me.UiGroupBox4.Controls.Add(Me.cboPlanIUERetSer)
      Me.UiGroupBox4.Controls.Add(Me.Label21)
      Me.UiGroupBox4.Controls.Add(Me.Label22)
      Me.UiGroupBox4.Controls.Add(Me.Label25)
      Me.UiGroupBox4.Location = New System.Drawing.Point(8, 0)
      Me.UiGroupBox4.Name = "UiGroupBox4"
      Me.UiGroupBox4.Size = New System.Drawing.Size(424, 304)
      Me.UiGroupBox4.TabIndex = 21
      Me.UiGroupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'cboPlanIUERetBie
      '
      cboPlanIUERetBie_DesignTimeLayout.LayoutString = resources.GetString("cboPlanIUERetBie_DesignTimeLayout.LayoutString")
      Me.cboPlanIUERetBie.DesignTimeLayout = cboPlanIUERetBie_DesignTimeLayout
      Me.cboPlanIUERetBie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanIUERetBie.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanIUERetBie.Location = New System.Drawing.Point(124, 88)
      Me.cboPlanIUERetBie.Name = "cboPlanIUERetBie"
      Me.cboPlanIUERetBie.SelectedIndex = -1
      Me.cboPlanIUERetBie.SelectedItem = Nothing
      Me.cboPlanIUERetBie.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanIUERetBie.TabIndex = 25
      Me.cboPlanIUERetBie.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanIUERetBie.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label16
      '
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label16.Location = New System.Drawing.Point(8, 92)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(112, 16)
      Me.Label16.TabIndex = 179
      Me.Label16.Text = "I.U.E. Bienes"
      '
      'cboPlanITRet
      '
      cboPlanITRet_DesignTimeLayout.LayoutString = resources.GetString("cboPlanITRet_DesignTimeLayout.LayoutString")
      Me.cboPlanITRet.DesignTimeLayout = cboPlanITRet_DesignTimeLayout
      Me.cboPlanITRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanITRet.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanITRet.Location = New System.Drawing.Point(124, 40)
      Me.cboPlanITRet.Name = "cboPlanITRet"
      Me.cboPlanITRet.SelectedIndex = -1
      Me.cboPlanITRet.SelectedItem = Nothing
      Me.cboPlanITRet.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanITRet.TabIndex = 23
      Me.cboPlanITRet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanITRet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanCreRet
      '
      cboPlanCreRet_DesignTimeLayout.LayoutString = resources.GetString("cboPlanCreRet_DesignTimeLayout.LayoutString")
      Me.cboPlanCreRet.DesignTimeLayout = cboPlanCreRet_DesignTimeLayout
      Me.cboPlanCreRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanCreRet.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanCreRet.Location = New System.Drawing.Point(124, 16)
      Me.cboPlanCreRet.Name = "cboPlanCreRet"
      Me.cboPlanCreRet.SelectedIndex = -1
      Me.cboPlanCreRet.SelectedItem = Nothing
      Me.cboPlanCreRet.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanCreRet.TabIndex = 22
      Me.cboPlanCreRet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanCreRet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'cboPlanIUERetSer
      '
      cboPlanIUERetSer_DesignTimeLayout.LayoutString = resources.GetString("cboPlanIUERetSer_DesignTimeLayout.LayoutString")
      Me.cboPlanIUERetSer.DesignTimeLayout = cboPlanIUERetSer_DesignTimeLayout
      Me.cboPlanIUERetSer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboPlanIUERetSer.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.cboPlanIUERetSer.Location = New System.Drawing.Point(124, 64)
      Me.cboPlanIUERetSer.Name = "cboPlanIUERetSer"
      Me.cboPlanIUERetSer.SelectedIndex = -1
      Me.cboPlanIUERetSer.SelectedItem = Nothing
      Me.cboPlanIUERetSer.Size = New System.Drawing.Size(292, 20)
      Me.cboPlanIUERetSer.TabIndex = 24
      Me.cboPlanIUERetSer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
      Me.cboPlanIUERetSer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
      '
      'Label21
      '
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label21.Location = New System.Drawing.Point(8, 68)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(112, 16)
      Me.Label21.TabIndex = 177
      Me.Label21.Text = "I.U.E. Servicios"
      '
      'Label22
      '
      Me.Label22.BackColor = System.Drawing.Color.Transparent
      Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label22.Location = New System.Drawing.Point(8, 44)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(112, 16)
      Me.Label22.TabIndex = 173
      Me.Label22.Text = "I.T."
      '
      'Label25
      '
      Me.Label25.BackColor = System.Drawing.Color.Transparent
      Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label25.Location = New System.Drawing.Point(8, 20)
      Me.Label25.Name = "Label25"
      Me.Label25.Size = New System.Drawing.Size(112, 16)
      Me.Label25.TabIndex = 170
      Me.Label25.Text = "IVA"
      '
      'UiTabPage3
      '
      Me.UiTabPage3.Controls.Add(Me.UiGroupBox3)
      Me.UiTabPage3.Key = "Integracion"
      Me.UiTabPage3.Location = New System.Drawing.Point(1, 21)
      Me.UiTabPage3.Name = "UiTabPage3"
      Me.UiTabPage3.Size = New System.Drawing.Size(438, 310)
      Me.UiTabPage3.TabStop = True
      Me.UiTabPage3.Tag = "Integracion"
      Me.UiTabPage3.Text = "Integración"
      '
      'UiGroupBox3
      '
      Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
      Me.UiGroupBox3.Controls.Add(Me.chkValidarSaldoCajaBanco)
      Me.UiGroupBox3.Controls.Add(Me.chkAplicarDescuento)
      Me.UiGroupBox3.Controls.Add(Me.chkExigirEEFF)
      Me.UiGroupBox3.Controls.Add(Me.chkAplicarITPDif)
      Me.UiGroupBox3.Controls.Add(Me.chkSepararExento)
      Me.UiGroupBox3.Controls.Add(Me.chkCentroCostoApli)
      Me.UiGroupBox3.Controls.Add(Me.chkCodBarra)
      Me.UiGroupBox3.Controls.Add(Me.chkFechaOpera)
      Me.UiGroupBox3.Controls.Add(Me.chkMultipleNro)
      Me.UiGroupBox3.Controls.Add(Me.chkPlanCtaShow)
      Me.UiGroupBox3.Controls.Add(Me.chkItemCodShow)
      Me.UiGroupBox3.Controls.Add(Me.chkInventario)
      Me.UiGroupBox3.Location = New System.Drawing.Point(8, 0)
      Me.UiGroupBox3.Name = "UiGroupBox3"
      Me.UiGroupBox3.Size = New System.Drawing.Size(424, 304)
      Me.UiGroupBox3.TabIndex = 26
      Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'chkValidarSaldoCajaBanco
      '
      Me.chkValidarSaldoCajaBanco.BackColor = System.Drawing.Color.Transparent
      Me.chkValidarSaldoCajaBanco.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkValidarSaldoCajaBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkValidarSaldoCajaBanco.Location = New System.Drawing.Point(8, 280)
      Me.chkValidarSaldoCajaBanco.Name = "chkValidarSaldoCajaBanco"
      Me.chkValidarSaldoCajaBanco.Size = New System.Drawing.Size(408, 20)
      Me.chkValidarSaldoCajaBanco.TabIndex = 38
      Me.chkValidarSaldoCajaBanco.Text = "Validar Saldos de Cuentas Caja / Banco. . . . . . . . . . . . . . . . . . . . ."
      Me.chkValidarSaldoCajaBanco.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkAplicarDescuento
      '
      Me.chkAplicarDescuento.BackColor = System.Drawing.Color.Transparent
      Me.chkAplicarDescuento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkAplicarDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkAplicarDescuento.Location = New System.Drawing.Point(8, 256)
      Me.chkAplicarDescuento.Name = "chkAplicarDescuento"
      Me.chkAplicarDescuento.Size = New System.Drawing.Size(408, 20)
      Me.chkAplicarDescuento.TabIndex = 37
      Me.chkAplicarDescuento.Text = "Aplicar Descuento de Facturas en Asientos Contables . . . . . . . . . . . . . . ." & _
          " . . . . . ."
      Me.chkAplicarDescuento.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkExigirEEFF
      '
      Me.chkExigirEEFF.BackColor = System.Drawing.Color.Transparent
      Me.chkExigirEEFF.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkExigirEEFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkExigirEEFF.Location = New System.Drawing.Point(8, 232)
      Me.chkExigirEEFF.Name = "chkExigirEEFF"
      Me.chkExigirEEFF.Size = New System.Drawing.Size(408, 20)
      Me.chkExigirEEFF.TabIndex = 36
      Me.chkExigirEEFF.Text = "Habilitar Flujo de Efectivo. . . . . . . . . . . . . . . . . . . . . . . . . . . " & _
          ". . . . . . . . . . . . . . . . . . . . . . ."
      Me.chkExigirEEFF.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkAplicarITPDif
      '
      Me.chkAplicarITPDif.BackColor = System.Drawing.Color.Transparent
      Me.chkAplicarITPDif.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkAplicarITPDif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkAplicarITPDif.Location = New System.Drawing.Point(8, 208)
      Me.chkAplicarITPDif.Name = "chkAplicarITPDif"
      Me.chkAplicarITPDif.Size = New System.Drawing.Size(408, 20)
      Me.chkAplicarITPDif.TabIndex = 35
      Me.chkAplicarITPDif.Text = "Aplicar IT por pagar Diferido en Asientos Contables . . . . . . . . . . . . . . ." & _
          " . . . . . ."
      Me.chkAplicarITPDif.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkSepararExento
      '
      Me.chkSepararExento.BackColor = System.Drawing.Color.Transparent
      Me.chkSepararExento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkSepararExento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkSepararExento.Location = New System.Drawing.Point(8, 184)
      Me.chkSepararExento.Name = "chkSepararExento"
      Me.chkSepararExento.Size = New System.Drawing.Size(408, 20)
      Me.chkSepararExento.TabIndex = 34
      Me.chkSepararExento.Text = "Separar Importe Exento en Asientos Contables . . . . . . . . . . . . . . . . . . " & _
          ". . ."
      Me.chkSepararExento.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkCentroCostoApli
      '
      Me.chkCentroCostoApli.BackColor = System.Drawing.Color.Transparent
      Me.chkCentroCostoApli.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkCentroCostoApli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkCentroCostoApli.Location = New System.Drawing.Point(8, 160)
      Me.chkCentroCostoApli.Name = "chkCentroCostoApli"
      Me.chkCentroCostoApli.Size = New System.Drawing.Size(408, 20)
      Me.chkCentroCostoApli.TabIndex = 33
      Me.chkCentroCostoApli.Text = "Aplicar Centros de Costos en Operaciones . . . . . . . . . . . . . . . . . . . . " & _
          ". . . ."
      Me.chkCentroCostoApli.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkCodBarra
      '
      Me.chkCodBarra.BackColor = System.Drawing.Color.Transparent
      Me.chkCodBarra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkCodBarra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkCodBarra.Location = New System.Drawing.Point(8, 112)
      Me.chkCodBarra.Name = "chkCodBarra"
      Me.chkCodBarra.Size = New System.Drawing.Size(408, 20)
      Me.chkCodBarra.TabIndex = 31
      Me.chkCodBarra.Text = "Permitir Uso de Lector de Código de Barra y/o QR . . . . . . . . . . . . ."
      Me.chkCodBarra.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkFechaOpera
      '
      Me.chkFechaOpera.BackColor = System.Drawing.Color.Transparent
      Me.chkFechaOpera.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkFechaOpera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkFechaOpera.Location = New System.Drawing.Point(8, 136)
      Me.chkFechaOpera.Name = "chkFechaOpera"
      Me.chkFechaOpera.Size = New System.Drawing.Size(408, 20)
      Me.chkFechaOpera.TabIndex = 32
      Me.chkFechaOpera.Text = "Control de Seguridad en Fechas de Operación . . . . . . . . . . . . . . . . . . ." & _
          " . ."
      Me.chkFechaOpera.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkMultipleNro
      '
      Me.chkMultipleNro.BackColor = System.Drawing.Color.Transparent
      Me.chkMultipleNro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkMultipleNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkMultipleNro.Location = New System.Drawing.Point(8, 40)
      Me.chkMultipleNro.Name = "chkMultipleNro"
      Me.chkMultipleNro.Size = New System.Drawing.Size(408, 20)
      Me.chkMultipleNro.TabIndex = 28
      Me.chkMultipleNro.Text = "Multiple Numeración en Contabilidad . . . . . . . . . . . . . . . . . . . . . . ." & _
          " . . . . ."
      Me.chkMultipleNro.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkPlanCtaShow
      '
      Me.chkPlanCtaShow.BackColor = System.Drawing.Color.Transparent
      Me.chkPlanCtaShow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkPlanCtaShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkPlanCtaShow.Location = New System.Drawing.Point(8, 64)
      Me.chkPlanCtaShow.Name = "chkPlanCtaShow"
      Me.chkPlanCtaShow.Size = New System.Drawing.Size(408, 20)
      Me.chkPlanCtaShow.TabIndex = 29
      Me.chkPlanCtaShow.Text = "Mostrar el Código de la Cuenta en Listas Desplegables . . . . . . . . . . . . . ." & _
          ""
      Me.chkPlanCtaShow.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkItemCodShow
      '
      Me.chkItemCodShow.BackColor = System.Drawing.Color.Transparent
      Me.chkItemCodShow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkItemCodShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkItemCodShow.Location = New System.Drawing.Point(8, 88)
      Me.chkItemCodShow.Name = "chkItemCodShow"
      Me.chkItemCodShow.Size = New System.Drawing.Size(408, 20)
      Me.chkItemCodShow.TabIndex = 30
      Me.chkItemCodShow.Text = "Mostrar el Código del Item en Listas Desplegables . . . . . . . . . . . . . . . ." & _
          " . ."
      Me.chkItemCodShow.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkInventario
      '
      Me.chkInventario.BackColor = System.Drawing.Color.Transparent
      Me.chkInventario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkInventario.Location = New System.Drawing.Point(8, 16)
      Me.chkInventario.Name = "chkInventario"
      Me.chkInventario.Size = New System.Drawing.Size(408, 20)
      Me.chkInventario.TabIndex = 27
      Me.chkInventario.Text = "Integrar el Módulo de Inventario a Contabilidad . . . . . . . . . . . . . . . . ." & _
          " . . ."
      Me.chkInventario.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Otros
      '
      Me.Otros.Controls.Add(Me.chkExigirActAnaAdd)
      Me.Otros.Controls.Add(Me.chkAplicarMedAlternativa)
      Me.Otros.Controls.Add(Me.chkAplicarDosificaVend)
      Me.Otros.Controls.Add(Me.chkAplicarControlInv)
      Me.Otros.Controls.Add(Me.chkRepSinGestion)
      Me.Otros.Key = "Otros"
      Me.Otros.Location = New System.Drawing.Point(1, 21)
      Me.Otros.Name = "Otros"
      Me.Otros.Size = New System.Drawing.Size(438, 310)
      Me.Otros.TabStop = True
      Me.Otros.Text = "Otros"
      '
      'chkExigirActAnaAdd
      '
      Me.chkExigirActAnaAdd.BackColor = System.Drawing.Color.Transparent
      Me.chkExigirActAnaAdd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkExigirActAnaAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkExigirActAnaAdd.Location = New System.Drawing.Point(12, 104)
      Me.chkExigirActAnaAdd.Name = "chkExigirActAnaAdd"
      Me.chkExigirActAnaAdd.Size = New System.Drawing.Size(408, 16)
      Me.chkExigirActAnaAdd.TabIndex = 43
      Me.chkExigirActAnaAdd.Text = "Control de Registro de Actividades y Analiticos Adicionales. . . . . . . . . . . " & _
          ". . . . . . ."
      Me.chkExigirActAnaAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkAplicarMedAlternativa
      '
      Me.chkAplicarMedAlternativa.BackColor = System.Drawing.Color.Transparent
      Me.chkAplicarMedAlternativa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkAplicarMedAlternativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkAplicarMedAlternativa.Location = New System.Drawing.Point(12, 8)
      Me.chkAplicarMedAlternativa.Name = "chkAplicarMedAlternativa"
      Me.chkAplicarMedAlternativa.Size = New System.Drawing.Size(408, 16)
      Me.chkAplicarMedAlternativa.TabIndex = 42
      Me.chkAplicarMedAlternativa.Text = "Aplicar Medida Alternativa en los Ítems. . . . . . . . . . . . . . . . . . . . . " & _
          ". . . . . ."
      Me.chkAplicarMedAlternativa.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkAplicarDosificaVend
      '
      Me.chkAplicarDosificaVend.BackColor = System.Drawing.Color.Transparent
      Me.chkAplicarDosificaVend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkAplicarDosificaVend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkAplicarDosificaVend.Location = New System.Drawing.Point(12, 80)
      Me.chkAplicarDosificaVend.Name = "chkAplicarDosificaVend"
      Me.chkAplicarDosificaVend.Size = New System.Drawing.Size(408, 16)
      Me.chkAplicarDosificaVend.TabIndex = 41
      Me.chkAplicarDosificaVend.Text = "Asignar Dosificaciones por Vendedor . . . . . . . . . . . . . . . . . ."
      Me.chkAplicarDosificaVend.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkAplicarControlInv
      '
      Me.chkAplicarControlInv.BackColor = System.Drawing.Color.Transparent
      Me.chkAplicarControlInv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkAplicarControlInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkAplicarControlInv.Location = New System.Drawing.Point(12, 56)
      Me.chkAplicarControlInv.Name = "chkAplicarControlInv"
      Me.chkAplicarControlInv.Size = New System.Drawing.Size(408, 16)
      Me.chkAplicarControlInv.TabIndex = 40
      Me.chkAplicarControlInv.Text = "Aplicar Control de Inventario . . . . . . . . . . . . . . . . . . . . . . . ."
      Me.chkAplicarControlInv.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'chkRepSinGestion
      '
      Me.chkRepSinGestion.BackColor = System.Drawing.Color.Transparent
      Me.chkRepSinGestion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.chkRepSinGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.chkRepSinGestion.Location = New System.Drawing.Point(12, 32)
      Me.chkRepSinGestion.Name = "chkRepSinGestion"
      Me.chkRepSinGestion.Size = New System.Drawing.Size(408, 16)
      Me.chkRepSinGestion.TabIndex = 39
      Me.chkRepSinGestion.Text = "Aplicar Reportes sin Gestiones en Módulo de Ventas. . . . . .. . . . . . . . . . " & _
          ". . . ."
      Me.chkRepSinGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "")
      Me.ilsMain.Images.SetKeyName(1, "")
      '
      'cdmMain
      '
      Me.cdmMain.AllowMerge = False
      Me.cdmMain.AlwaysShowFullMenus = True
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Save, Me.Exit2})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("4c8c1898-cf57-4167-a83a-3f64fbcd1d31")
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
      Me.UiCommandBar1.Size = New System.Drawing.Size(155, 28)
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
      Me.Save.Text = "Guardar"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 1
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
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
      Me.TopRebar1.Size = New System.Drawing.Size(456, 28)
      '
      'frmEmpresaPara
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(456, 374)
      Me.Controls.Add(Me.bcgMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.ForeColor = System.Drawing.SystemColors.HotTrack
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.KeyPreview = True
      Me.MaximizeBox = False
      Me.Name = "frmEmpresaPara"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Parámetros de la Empresa"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabMain.ResumeLayout(False)
      Me.UiTabPage1.ResumeLayout(False)
      CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox1.ResumeLayout(False)
      Me.UiGroupBox1.PerformLayout()
      Me.UiTabPage2.ResumeLayout(False)
      CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox2.ResumeLayout(False)
      Me.UiGroupBox2.PerformLayout()
      CType(Me.cboPlanExento, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanIceIehd, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanAitb, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanITP, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanDif, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanIT, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanDeb, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanCre, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanITF, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanRes, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiTabPage5.ResumeLayout(False)
      CType(Me.UiGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox5.ResumeLayout(False)
      Me.UiGroupBox5.PerformLayout()
      CType(Me.cboPlanITPDif, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanIceIehdDif, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanDebDif, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanCreDif, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiTabPage4.ResumeLayout(False)
      CType(Me.UiGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox4.ResumeLayout(False)
      Me.UiGroupBox4.PerformLayout()
      CType(Me.cboPlanIUERetBie, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanITRet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanCreRet, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.cboPlanIUERetSer, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiTabPage3.ResumeLayout(False)
      CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
      Me.UiGroupBox3.ResumeLayout(False)
      Me.Otros.ResumeLayout(False)
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      Select Case e.Command.Key
         Case "Save"
            If DataSave() Then
               mlngID = moEmpresaPara.EmpresaParaId
               Call EmpresaParaLoad(moEmpresaPara.EmpresaId)

               mboolChanged = True
               MessageBox.Show("Los Datos se Guardaron con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Me.Close()
            End If

         Case "Exit"
            Me.Close()
      End Select

      Me.Cursor = oCursor
   End Sub

   Private Sub frmEmpresaParaEdit_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      Call StatusFormDisplay(Me.Name)
   End Sub

   Private Sub frmEmpresaParaEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Dim oCursor As Cursor
      oCursor = Me.Cursor
      Me.Cursor = Cursors.WaitCursor

      mboolLoading = True

      Call FormInit()
      Call SecuritySet(Me, AppExeName)
      Call ComboLoad()
      Call FormFind()
      Call ClearMemory()

      mboolLoading = False

      Me.Cursor = oCursor
   End Sub

   Private Sub FormFind()
      moEmpresaPara = New clsEmpresaPara(clsAppInfo.ConnectString)

      Try
         With moEmpresaPara
            .SelectFilter = clsEmpresaPara.SelectFilters.All
            .WhereFilter = clsEmpresaPara.WhereFilters.EmpresaId
            .EmpresaId = mlngEmpresaId

            If .Find Then
               mboolAdding = False
               mboolEditing = True

               Call FormShow()
            Else
               mboolAdding = True
               mboolEditing = False

               FormNew()
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub FormShow()
      mboolShow = True
      With moEmpresaPara
         txtEmpresaParaId.Text = ToStr(.EmpresaParaId)
         Call txtEmpresaIdLoad(.EmpresaId)
         dudDecimalNro.Value = ToLong(.DecimalNro)
         dudDecimalCant.Value = ToLong(.DecimalCant)
         cboTipoHoja.SelectedIndex = ListFindItem(cboTipoHoja, .TipoHojaId)
         txtEmpresaGral.Text = ToStr(.EmpresaGral)
         txtMontoMinOpe.Text = ToDecStr(.MontoMinOpe)
         txtMontoMinFac.Text = ToDecStr(.MontoMinFac)
         txtDocTexto.Text = ToStr(.Repositorio)
         txtDocTexto.Tag = ToStr(.Repositorio)
         txtMontoMinOpe.ReadOnly = True
         Call txtMonedaIdLoad(clsAppInfo.MonedaId)

         cboPlanCre.Value = ListFindItem(cboPlanCre, .PlanCreId)
         cboPlanCreDif.Value = ListFindItem(cboPlanCreDif, .PlanCreDifId)
         cboPlanDeb.Value = ListFindItem(cboPlanDeb, .PlanDebId)
         cboPlanDebDif.Value = ListFindItem(cboPlanDebDif, .PlanDebDifId)
         cboPlanIT.Value = ListFindItem(cboPlanIT, .PlanITId)
         cboPlanITP.Value = ListFindItem(cboPlanITP, .PlanITPId)
         cboPlanITF.Value = ListFindItem(cboPlanITF, .PlanITFId)
         cboPlanIceIehd.Value = ListFindItem(cboPlanIceIehd, .PlanIceIehdId)
         cboPlanIceIehdDif.Value = ListFindItem(cboPlanIceIehdDif, .PlanIceIehdDifId)
         cboPlanExento.Value = ListFindItem(cboPlanExento, .PlanExentoId)
         cboPlanDif.Value = ListFindItem(cboPlanDif, .PlanDifId)
         cboPlanAitb.Value = ListFindItem(cboPlanAitb, .PlanAitbId)
         cboPlanRes.Value = ListFindItem(cboPlanRes, .PlanResId)
         cboPlanCreRet.Value = ListFindItem(cboPlanCreRet, .PlanCreRetId)
         cboPlanITRet.Value = ListFindItem(cboPlanITRet, .PlanITRetId)
         cboPlanIUERetSer.Value = ListFindItem(cboPlanIUERetSer, .PlanIUERetSerId)
         cboPlanIUERetBie.Value = ListFindItem(cboPlanIUERetBie, .PlanIUERetBieId)
         cboPlanITPDif.Value = ListFindItem(cboPlanITPDif, .PlanITPDifId)

         chkInventario.Checked = ToBoolean(.Inventario)
         chkRepSinGestion.Checked = ToBoolean(.RepSinGestion)
         chkItemCodShow.Checked = ToBoolean(.ItemCodShow)
         chkPlanCtaShow.Checked = ToBoolean(.PlanCtaShow)
         chkCodBarra.Checked = ToBoolean(.CodBarra)
         chkMultipleNro.Checked = ToBoolean(.MultipleNro)
         chkFechaOpera.Checked = ToBoolean(.FechaOpera)
         chkCentroCostoApli.Checked = ToBoolean(.CentroCostoApli)
         chkSepararExento.Checked = ToBoolean(.SepararExento)
         chkAplicarDescuento.Checked = ToBoolean(.AplicarDescuento)
         chkAplicarITPDif.Checked = ToBoolean(.AplicarITPDif)
         chkExigirEEFF.Checked = ToBoolean(.ExigirEEFF)
         chkValidarSaldoCajaBanco.Checked = ToBoolean(.ValidarSaldoCajaBanco)
         chkAplicarMedAlternativa.Checked = ToBoolean(.AplicarMedAlternativa)
         chkAplicarControlInv.Checked = ToBoolean(.AplicarControlInv)
         chkAplicarDosificaVend.Checked = ToBoolean(.AplicarDosificaVend)
         chkExigirActAnaAdd.Checked = ToBoolean(.ExigirActAnaAdd)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMOld)

            If Not mboolAdding And Not mboolEditing Then
               .VMOld.ToShowOpe()
            End If
         End If
      End With
      mboolShow = False
   End Sub

   Private Sub CloneVM(ByRef oVM As clsEmpresaParaVM)
      oVM = New clsEmpresaParaVM

      With oVM
         .EmpresaParaId = moEmpresaPara.EmpresaParaId
         .EmpresaId = moEmpresaPara.EmpresaId
         .DecimalCant = ToStr(moEmpresaPara.DecimalCant)
         .DecimalNro = ToStr(moEmpresaPara.DecimalNro)
         .TipoHojaId = moEmpresaPara.TipoHojaId
         .TipoHojaDes = cboTipoHoja.Text
         .EmpresaGral = moEmpresaPara.EmpresaGral
         .MontoMinOpe = moEmpresaPara.MontoMinOpe
         .MontoMinFac = moEmpresaPara.MontoMinFac
         .PlanCreId = moEmpresaPara.PlanCreId
         .PlanCreDes = cboPlanCre.Text
         .PlanDebId = moEmpresaPara.PlanDebId
         .PlanDebDes = cboPlanDeb.Text
         .PlanITId = moEmpresaPara.PlanITId
         .PlanITDes = cboPlanIT.Text
         .PlanITPId = moEmpresaPara.PlanITPId
         .PlanITPDes = cboPlanITP.Text
         .PlanITFId = moEmpresaPara.PlanITFId
         .PlanITFDes = cboPlanITF.Text
         .PlanIceIehdId = moEmpresaPara.PlanIceIehdId
         .PlanIceIehdDes = cboPlanIceIehd.Text
         .PlanExentoId = moEmpresaPara.PlanExentoId
         .PlanExentoDes = cboPlanExento.Text
         .PlanDifId = moEmpresaPara.PlanDifId
         .PlanDifDes = cboPlanDif.Text
         .PlanAitbId = moEmpresaPara.PlanAitbId
         .PlanAitbDes = cboPlanAitb.Text
         .PlanResId = moEmpresaPara.PlanResId
         .PlanResDes = cboPlanRes.Text
         .PlanCreDifId = moEmpresaPara.PlanCreDifId
         .PlanCreDifDes = cboPlanCreDif.Text
         .PlanDebDifId = moEmpresaPara.PlanDebDifId
         .PlanDebDifDes = cboPlanDebDif.Text
         .PlanIceIehdDifId = moEmpresaPara.PlanIceIehdDifId
         .PlanIceIehdDifDes = cboPlanIceIehdDif.Text
         .PlanITPDifId = moEmpresaPara.PlanITPDifId
         .PlanITPDifDes = cboPlanITPDif.Text
         .PlanCreRetId = moEmpresaPara.PlanCreRetId
         .PlanCreRetDes = cboPlanCreRet.Text
         .PlanITRetId = moEmpresaPara.PlanITRetId
         .PlanITRetDes = cboPlanITRet.Text
         .PlanIUERetSerId = moEmpresaPara.PlanIUERetSerId
         .PlanIUERetSerDes = cboPlanIUERetSer.Text
         .PlanIUERetBieId = moEmpresaPara.PlanIUERetBieId
         .PlanIUERetBieDes = cboPlanIUERetBie.Text

         .Inventario = ToByte(chkInventario.Checked)
         .MultipleNro = ToByte(chkMultipleNro.Checked)
         .Inventario = ToByte(chkInventario.Checked)
         .PlanCtaShow = ToByte(chkPlanCtaShow.Checked)
         .ItemCodShow = ToByte(chkItemCodShow.Checked)
         .CodBarra = ToByte(chkCodBarra.Checked)
         .FechaOpera = ToByte(chkFechaOpera.Checked)
         .CentroCostoApli = ToByte(chkCentroCostoApli.Checked)
         .SepararExento = ToByte(chkSepararExento.Checked)
         .AplicarITPDif = ToByte(chkAplicarITPDif.Checked)
         .ExigirEEFF = ToByte(chkExigirEEFF.Checked)
         .AplicarDescuento = ToByte(chkAplicarDescuento.Checked)
         .ValidarSaldoCajaBanco = ToByte(chkValidarSaldoCajaBanco.Checked)
         .RepSinGestion = ToByte(chkRepSinGestion.Checked)
         .AplicarMedAlternativa = ToByte(chkAplicarMedAlternativa.Checked)
         .AplicarControlInv = ToByte(chkAplicarControlInv.Checked)
         .AplicarDosificaVend = ToByte(chkAplicarDosificaVend.Checked)
         .Repositorio = moEmpresaPara.Repositorio
         .ExigirActAnaAdd = ToByte(chkExigirActAnaAdd.Checked)

         .FormName = Me.Name
         .FormText = Me.Text
      End With
   End Sub

   Private Sub DataClear()
      mboolShow = True
      With moEmpresaPara
         txtEmpresaParaId.Text = String.Empty
         Call txtEmpresaIdLoad(mlngEmpresaId)
         dudDecimalNro.Value = 3
         dudDecimalCant.Value = 2
         cboTipoHoja.SelectedIndex = -1
         txtEmpresaGral.Text = String.Empty
         txtMontoMinOpe.Text = ToDecStr(0.001)
         txtMontoMinFac.Text = ToDecStr(0.5)
         Call txtMonedaIdLoad(clsAppInfo.MonedaId)
         txtMontoMinOpe.ReadOnly = True
         txtDocTexto.Text = String.Empty

         cboPlanCre.Value = Nothing
         cboPlanCreDif.Value = Nothing
         cboPlanDeb.Value = Nothing
         cboPlanDebDif.Value = Nothing
         cboPlanIT.Value = Nothing
         cboPlanITP.Value = Nothing
         cboPlanITF.Value = Nothing
         cboPlanDif.Value = Nothing
         cboPlanIceIehd.Value = Nothing
         cboPlanIceIehdDif.Value = Nothing
         cboPlanExento.Value = Nothing
         cboPlanAitb.Value = Nothing
         cboPlanRes.Value = Nothing
         cboPlanCreRet.Value = Nothing
         cboPlanITRet.Value = Nothing
         cboPlanIUERetSer.Value = Nothing
         cboPlanIUERetBie.Value = Nothing
         cboPlanITPDif.Value = Nothing

         chkInventario.Checked = False
         chkItemCodShow.Checked = False
         chkPlanCtaShow.Checked = False
         chkCodBarra.Checked = False
         chkMultipleNro.Checked = False
         chkFechaOpera.Checked = False
         chkCentroCostoApli.Checked = False
         chkSepararExento.Checked = False
         chkAplicarDescuento.Checked = False
         chkAplicarITPDif.Checked = False
         chkExigirEEFF.Checked = False
         chkValidarSaldoCajaBanco.Checked = False
         chkAplicarMedAlternativa.Checked = False
         chkAplicarControlInv.Checked = False
         chkAplicarDosificaVend.Checked = False
         chkExigirActAnaAdd.Checked = False
      End With
      mboolShow = False
   End Sub

   Private Sub DataReadOnly()
      txtEmpresaParaId.ReadOnly = True
      txtEmpresaId.ReadOnly = True
      dudDecimalNro.ReadOnly = True
      dudDecimalCant.ReadOnly = True
      cboTipoHoja.ReadOnly = False
      txtEmpresaGral.ReadOnly = False
      txtMontoMinOpe.ReadOnly = True
      txtMontoMinFac.ReadOnly = False
      txtDocTexto.ReadOnly = True
      BtnBuscar.Enabled = False

      cboPlanCre.ReadOnly = False
      cboPlanCreDif.ReadOnly = False
      cboPlanDeb.ReadOnly = False
      cboPlanDebDif.ReadOnly = False
      cboPlanIT.ReadOnly = False
      cboPlanITP.ReadOnly = False
      cboPlanITF.ReadOnly = False
      cboPlanIceIehd.ReadOnly = False
      cboPlanIceIehdDif.ReadOnly = False
      cboPlanExento.ReadOnly = False
      cboPlanDif.ReadOnly = False
      cboPlanAitb.ReadOnly = False
      cboPlanRes.ReadOnly = False
      cboPlanCreRet.ReadOnly = False
      cboPlanITRet.ReadOnly = False
      cboPlanIUERetSer.ReadOnly = False
      cboPlanIUERetBie.ReadOnly = False
      cboPlanITPDif.ReadOnly = False

      chkInventario.Enabled = False
      chkRepSinGestion.Enabled = False
      chkItemCodShow.Enabled = False
      chkPlanCtaShow.Enabled = False
      chkCodBarra.Enabled = False
      chkMultipleNro.Enabled = False
      chkFechaOpera.Enabled = False
      chkCentroCostoApli.Enabled = False
      chkSepararExento.Enabled = False
      chkAplicarITPDif.Enabled = False
      chkExigirEEFF.Enabled = False
      chkAplicarDescuento.Enabled = False
      chkValidarSaldoCajaBanco.Enabled = False
      chkAplicarMedAlternativa.Enabled = False
      chkAplicarControlInv.Enabled = False
      chkAplicarDosificaVend.Enabled = False
      chkExigirActAnaAdd.Enabled = False

      cdmMain.Commands.Item("Save").Enabled = Janus.Windows.UI.InheritableBoolean.False
   End Sub

   Private Sub DataMove()
      With moEmpresaPara
         If Not mboolAdding Then
            .EmpresaParaId = ToLong(txtEmpresaParaId.Text)
         End If

         .EmpresaId = ToLong(txtEmpresaId.Tag)
         .DecimalNro = ToLong(dudDecimalNro.Value)
         .DecimalCant = ToLong(dudDecimalCant.Value)
         .TipoHojaId = ListPosition(cboTipoHoja, cboTipoHoja.SelectedIndex)
         .EmpresaGral = ToStr(txtEmpresaGral.Text)
         .MontoMinOpe = txtMontoMinOpe.Text
         .MontoMinFac = txtMontoMinFac.Text
         .Repositorio = ToStr(txtDocTexto.Tag)

         .PlanCreId = ListPosition(cboPlanCre)
         .PlanCreDifId = ListPosition(cboPlanCreDif)
         .PlanDebId = ListPosition(cboPlanDeb)
         .PlanDebDifId = ListPosition(cboPlanDebDif)
         .PlanITId = ListPosition(cboPlanIT)
         .PlanITPId = ListPosition(cboPlanITP)
         .PlanITFId = ListPosition(cboPlanITF)
         .PlanIceIehdId = ListPosition(cboPlanIceIehd)
         .PlanIceIehdDifId = ListPosition(cboPlanIceIehdDif)
         .PlanExentoId = ListPosition(cboPlanExento)
         .PlanDifId = ListPosition(cboPlanDif)
         .PlanAitbId = ListPosition(cboPlanAitb)
         .PlanResId = ListPosition(cboPlanRes)
         .PlanCreRetId = ListPosition(cboPlanCreRet)
         .PlanITRetId = ListPosition(cboPlanITRet)
         .PlanIUERetSerId = ListPosition(cboPlanIUERetSer)
         .PlanIUERetBieId = ListPosition(cboPlanIUERetBie)
         .PlanITPDifId = ListPosition(cboPlanITPDif)

         .Inventario = ToBoolean(chkInventario.Checked)
         .RepSinGestion = ToBoolean(chkRepSinGestion.Checked)
         .ItemCodShow = ToBoolean(chkItemCodShow.Checked)
         .PlanCtaShow = ToBoolean(chkPlanCtaShow.Checked)
         .CodBarra = ToBoolean(chkCodBarra.Checked)
         .MultipleNro = ToBoolean(chkMultipleNro.Checked)
         .FechaOpera = ToBoolean(chkFechaOpera.Checked)
         .CentroCostoApli = ToBoolean(chkCentroCostoApli.Checked)
         .SepararExento = ToBoolean(chkSepararExento.Checked)
         .AplicarDescuento = ToBoolean(chkAplicarDescuento.Checked)
         .AplicarITPDif = ToBoolean(chkAplicarITPDif.Checked)
         .ExigirEEFF = ToBoolean(chkExigirEEFF.Checked)
         .ValidarSaldoCajaBanco = ToBoolean(chkValidarSaldoCajaBanco.Checked)
         .AplicarMedAlternativa = ToBoolean(chkAplicarMedAlternativa.Checked)
         .AplicarControlInv = ToBoolean(chkAplicarControlInv.Checked)
         .AplicarDosificaVend = ToBoolean(chkAplicarDosificaVend.Checked)
         .ExigirActAnaAdd = ToBoolean(chkExigirActAnaAdd.Checked)

         If clsAppInfo.RegistrarBitacora Then
            Call CloneVM(.VMNew)
         End If
      End With
   End Sub

   Private Sub FormNew()
      mboolAdding = True

      Call DataClear()

      dudDecimalCant.Select()
   End Sub

   Private Function DataSave() As Boolean
      Try
         Call DataMove()

         If mboolAdding Then
            DataSave = DataAdd()
         Else
            DataSave = DataUpdate()
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         Return False

      End Try
   End Function

   Private Function DataAdd() As Boolean
      Try
         DataAdd = False

         If moEmpresaPara.Insert() Then
            mboolAdding = False
            DataAdd = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Function DataUpdate() As Boolean
      Try
         DataUpdate = False

         If moEmpresaPara.Update() Then
            DataUpdate = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Private Sub FormInit()
      Call FormCenter(Me)

      txtMontoMinOpe.FormatString = DecimalMask()
      txtMontoMinFac.FormatString = DecimalMask()

   End Sub

   Private Sub ComboLoad()
      Call cboPlanLoad()
      Call cboTipoHojaLoad()
   End Sub

   Private Sub txtEmpresaIdLoad(ByVal lngEmpresaId As Long)
      Dim oEmpresa As New clsEmpresa(clsAppInfo.ConnectString)

      Try
         With oEmpresa
            .EmpresaId = lngEmpresaId

            If .FindByPK Then
               txtEmpresaId.Tag = .EmpresaId
               txtEmpresaId.Text = ToStr(.EmpresaDes)
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oEmpresa.Dispose()

      End Try
   End Sub

   Private Sub cboTipoHojaLoad()
      Dim oTipoHoja As New clsTipoHoja(clsAppInfo.ConnectString)
      Dim oItem As clsListItem

      cboTipoHoja.Items.Clear()

      Try
         With oTipoHoja
            .SelectFilter = clsTipoHoja.SelectFilters.ListBox
            .OrderByFilter = clsTipoHoja.OrderByFilters.TipoHojaDes

            If .Open() Then
               Do While .Read()
                  oItem = New clsListItem(.TipoHojaId, .TipoHojaDes)

                  cboTipoHoja.Items.Add(oItem)
                  .MoveNext()
               Loop
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoHoja.Dispose()
         oItem = Nothing

      End Try
   End Sub

   Private Sub cboPlanLoad()
      Dim oPlan As New clsPlan(clsAppInfo.ConnectString)

      Try
         With oPlan
            .SelectFilter = clsPlan.SelectFilters.All
            .WhereFilter = clsPlan.WhereFilters.EsAna
            .OrderByFilter = clsPlan.OrderByFilters.PlanDes
            .EmpresaId = mlngEmpresaId
            .EsAna = 1
            .EstadoId = clsEstado.ACTIVO

            If .Open() Then
               With cboPlanCre
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanCreDif
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanDeb
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanDebDif
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanIT
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanITP
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanITF
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanIceIehd
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanIceIehdDif
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanExento
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanDif
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanRes
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanAitb
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanCreRet
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanITRet
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanIUERetSer
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanIUERetBie
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With

               With cboPlanITPDif
                  .DropDownList.Columns.Add("PlanId")
                  .DropDownList.Columns("PlanId").DataMember = "PlanId"
                  .DropDownList.Columns("PlanId").Visible = False

                  .DropDownList.Columns.Add("PlanCta")
                  .DropDownList.Columns("PlanCta").Caption = "Cuenta"
                  .DropDownList.Columns("PlanCta").DataMember = "PlanCta"
                  .DropDownList.Columns("PlanCta").Width = 100

                  .DropDownList.Columns.Add("PlanDes")
                  .DropDownList.Columns("PlanDes").Caption = "Descripción"
                  .DropDownList.Columns("PlanDes").DataMember = "PlanDes"
                  .DropDownList.Columns("PlanDes").Width = modForm.PlanDesWidth

                  .DataMember = oPlan.TableName
                  .DataSource = oPlan.DataSet

                  .ValueMember = "PlanId"
                  .DisplayMember = "PlanDes"
               End With
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oPlan.Dispose()

      End Try
   End Sub

   Private Sub txtMonedaIdLoad(ByVal lngMonedaId As Long)
      Dim oMoneda As New clsMoneda(clsAppInfo.ConnectString)

      Try
         With oMoneda
            .MonedaId = lngMonedaId

            If .FindByPK Then
               lblMonedaMinOpe.Text = .MonedaDes
               lblMonedaMinFac.Text = .MonedaDes
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oMoneda.Dispose()

      End Try
   End Sub

   Private Sub dudDecimalNro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dudDecimalNro.ValueChanged
      Select Case ToLong(dudDecimalNro.Value)
         Case 1
            txtMontoMinOpe.FormatString = "##,##0.0"
            txtMontoMinOpe.Text = 0.1
         Case 2
            txtMontoMinOpe.FormatString = "##,##0.00"
            txtMontoMinOpe.Text = ToDecStrDos(0.01)
         Case 3
            txtMontoMinOpe.FormatString = "##,##0.000"
            txtMontoMinOpe.Text = ToDecStrTres(0.001)
         Case 4
            txtMontoMinOpe.FormatString = "##,##0.0000"
            txtMontoMinOpe.Text = ToDecStrCuatro(0.0001)
         Case 5
            txtMontoMinOpe.FormatString = "##,##0.00000"
            txtMontoMinOpe.Text = ToDecStrCinco(0.00001)

      End Select

      txtMontoMinFac.FormatString = txtMontoMinOpe.FormatString

   End Sub

   Private Sub frmEmpresaParaEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      If Me.WindowState <> FormWindowState.Minimized Then
         If (e.KeyCode = Keys.Return) And (e.Shift = True) Then
            If DataSave() Then
               mlngID = moEmpresaPara.EmpresaParaId
               Call EmpresaParaLoad(moEmpresaPara.EmpresaId)

               mboolChanged = True
               MessageBox.Show("Los Datos se Guardaron con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

               Me.Close()
            End If

         ElseIf (e.KeyCode = Keys.Escape) And (e.Shift = True) Then
            Me.Close()
         End If
      End If
   End Sub

   Private Sub frmEmpresaParaEdit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
      moEmpresaPara.Dispose()
      Call ClearMemory()
   End Sub

   Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
      If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
         txtDocTexto.Text = FolderBrowserDialog1.SelectedPath
         txtDocTexto.Tag = FolderBrowserDialog1.SelectedPath
      End If
   End Sub

End Class
