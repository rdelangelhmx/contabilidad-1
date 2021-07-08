Public Class frmWizard
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
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents btnEmpresa As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnGestion As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnDosifica As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnCompPara As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnEmpresaPara As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnCentroCosto As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnPlanAdd As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnPlan As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnSucursal As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnCentroCostoDet As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnCheque As Janus.Windows.EditControls.UIButton
   Friend WithEvents btnBanco As Janus.Windows.EditControls.UIButton
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Protected WithEvents bcgMain As Janus.Windows.EditControls.UIGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents btnExit As Janus.Windows.EditControls.UIButton
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWizard))
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.btnEmpresa = New Janus.Windows.EditControls.UIButton
      Me.btnGestion = New Janus.Windows.EditControls.UIButton
      Me.btnDosifica = New Janus.Windows.EditControls.UIButton
      Me.btnCompPara = New Janus.Windows.EditControls.UIButton
      Me.btnEmpresaPara = New Janus.Windows.EditControls.UIButton
      Me.btnCentroCosto = New Janus.Windows.EditControls.UIButton
      Me.btnPlanAdd = New Janus.Windows.EditControls.UIButton
      Me.btnPlan = New Janus.Windows.EditControls.UIButton
      Me.btnSucursal = New Janus.Windows.EditControls.UIButton
      Me.btnCentroCostoDet = New Janus.Windows.EditControls.UIButton
      Me.btnCheque = New Janus.Windows.EditControls.UIButton
      Me.btnBanco = New Janus.Windows.EditControls.UIButton
      Me.Label8 = New System.Windows.Forms.Label
      Me.bcgMain = New Janus.Windows.EditControls.UIGroupBox
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.btnExit = New Janus.Windows.EditControls.UIButton
      Me.Label11 = New System.Windows.Forms.Label
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label10 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bcgMain.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "Next.png")
      Me.ilsMain.Images.SetKeyName(1, "Exit-game2.png")
      '
      'btnEmpresa
      '
      Me.btnEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnEmpresa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnEmpresa.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnEmpresa.ImageIndex = 0
      Me.btnEmpresa.ImageList = Me.ilsMain
      Me.btnEmpresa.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnEmpresa.Location = New System.Drawing.Point(8, 144)
      Me.btnEmpresa.Name = "btnEmpresa"
      Me.btnEmpresa.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnEmpresa.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnEmpresa.Size = New System.Drawing.Size(136, 64)
      Me.btnEmpresa.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnEmpresa.TabIndex = 0
      Me.btnEmpresa.Text = "Empresas"
      Me.btnEmpresa.UseCompatibleTextRendering = True
      Me.btnEmpresa.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnGestion
      '
      Me.btnGestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnGestion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnGestion.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnGestion.ImageIndex = 0
      Me.btnGestion.ImageList = Me.ilsMain
      Me.btnGestion.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnGestion.Location = New System.Drawing.Point(288, 144)
      Me.btnGestion.Name = "btnGestion"
      Me.btnGestion.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnGestion.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnGestion.Size = New System.Drawing.Size(136, 64)
      Me.btnGestion.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnGestion.TabIndex = 2
      Me.btnGestion.Text = "Gestiones"
      Me.btnGestion.UseCompatibleTextRendering = True
      Me.btnGestion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnDosifica
      '
      Me.btnDosifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnDosifica.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnDosifica.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnDosifica.ImageIndex = 0
      Me.btnDosifica.ImageList = Me.ilsMain
      Me.btnDosifica.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnDosifica.Location = New System.Drawing.Point(568, 252)
      Me.btnDosifica.Name = "btnDosifica"
      Me.btnDosifica.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnDosifica.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnDosifica.Size = New System.Drawing.Size(136, 64)
      Me.btnDosifica.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnDosifica.TabIndex = 9
      Me.btnDosifica.Text = "Dosifica- ciones"
      Me.btnDosifica.UseCompatibleTextRendering = True
      Me.btnDosifica.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnCompPara
      '
      Me.btnCompPara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnCompPara.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnCompPara.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnCompPara.ImageIndex = 0
      Me.btnCompPara.ImageList = Me.ilsMain
      Me.btnCompPara.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnCompPara.Location = New System.Drawing.Point(428, 144)
      Me.btnCompPara.Name = "btnCompPara"
      Me.btnCompPara.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnCompPara.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnCompPara.Size = New System.Drawing.Size(136, 64)
      Me.btnCompPara.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnCompPara.TabIndex = 3
      Me.btnCompPara.Text = "Parámetros Documentos"
      Me.btnCompPara.UseCompatibleTextRendering = True
      Me.btnCompPara.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnEmpresaPara
      '
      Me.btnEmpresaPara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnEmpresaPara.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnEmpresaPara.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnEmpresaPara.ImageIndex = 0
      Me.btnEmpresaPara.ImageList = Me.ilsMain
      Me.btnEmpresaPara.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnEmpresaPara.Location = New System.Drawing.Point(148, 144)
      Me.btnEmpresaPara.Name = "btnEmpresaPara"
      Me.btnEmpresaPara.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnEmpresaPara.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnEmpresaPara.Size = New System.Drawing.Size(136, 64)
      Me.btnEmpresaPara.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnEmpresaPara.TabIndex = 1
      Me.btnEmpresaPara.Text = "Parámetros Empresas"
      Me.btnEmpresaPara.UseCompatibleTextRendering = True
      Me.btnEmpresaPara.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnCentroCosto
      '
      Me.btnCentroCosto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnCentroCosto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnCentroCosto.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnCentroCosto.ImageIndex = 0
      Me.btnCentroCosto.ImageList = Me.ilsMain
      Me.btnCentroCosto.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnCentroCosto.Location = New System.Drawing.Point(148, 252)
      Me.btnCentroCosto.Name = "btnCentroCosto"
      Me.btnCentroCosto.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnCentroCosto.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnCentroCosto.Size = New System.Drawing.Size(136, 64)
      Me.btnCentroCosto.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnCentroCosto.TabIndex = 6
      Me.btnCentroCosto.Text = "Centros de Costo"
      Me.btnCentroCosto.UseCompatibleTextRendering = True
      Me.btnCentroCosto.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnPlanAdd
      '
      Me.btnPlanAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnPlanAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnPlanAdd.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnPlanAdd.ImageIndex = 0
      Me.btnPlanAdd.ImageList = Me.ilsMain
      Me.btnPlanAdd.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnPlanAdd.Location = New System.Drawing.Point(8, 252)
      Me.btnPlanAdd.Name = "btnPlanAdd"
      Me.btnPlanAdd.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnPlanAdd.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnPlanAdd.Size = New System.Drawing.Size(136, 64)
      Me.btnPlanAdd.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnPlanAdd.TabIndex = 5
      Me.btnPlanAdd.Text = "Analíticos Adicionales"
      Me.btnPlanAdd.UseCompatibleTextRendering = True
      Me.btnPlanAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnPlan
      '
      Me.btnPlan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnPlan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnPlan.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnPlan.ImageIndex = 0
      Me.btnPlan.ImageList = Me.ilsMain
      Me.btnPlan.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnPlan.Location = New System.Drawing.Point(568, 144)
      Me.btnPlan.Name = "btnPlan"
      Me.btnPlan.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnPlan.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnPlan.Size = New System.Drawing.Size(136, 64)
      Me.btnPlan.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnPlan.TabIndex = 4
      Me.btnPlan.Text = "Plan de Cuentas"
      Me.btnPlan.UseCompatibleTextRendering = True
      Me.btnPlan.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnSucursal
      '
      Me.btnSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnSucursal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnSucursal.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnSucursal.ImageIndex = 0
      Me.btnSucursal.ImageList = Me.ilsMain
      Me.btnSucursal.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnSucursal.Location = New System.Drawing.Point(428, 252)
      Me.btnSucursal.Name = "btnSucursal"
      Me.btnSucursal.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnSucursal.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnSucursal.Size = New System.Drawing.Size(136, 64)
      Me.btnSucursal.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnSucursal.TabIndex = 8
      Me.btnSucursal.Text = "Sucursales"
      Me.btnSucursal.UseCompatibleTextRendering = True
      Me.btnSucursal.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnCentroCostoDet
      '
      Me.btnCentroCostoDet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnCentroCostoDet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnCentroCostoDet.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnCentroCostoDet.ImageIndex = 0
      Me.btnCentroCostoDet.ImageList = Me.ilsMain
      Me.btnCentroCostoDet.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnCentroCostoDet.Location = New System.Drawing.Point(288, 252)
      Me.btnCentroCostoDet.Name = "btnCentroCostoDet"
      Me.btnCentroCostoDet.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnCentroCostoDet.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnCentroCostoDet.Size = New System.Drawing.Size(136, 64)
      Me.btnCentroCostoDet.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnCentroCostoDet.TabIndex = 7
      Me.btnCentroCostoDet.Text = "Actividades de C. C."
      Me.btnCentroCostoDet.UseCompatibleTextRendering = True
      Me.btnCentroCostoDet.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnCheque
      '
      Me.btnCheque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnCheque.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnCheque.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnCheque.ImageIndex = 0
      Me.btnCheque.ImageList = Me.ilsMain
      Me.btnCheque.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnCheque.Location = New System.Drawing.Point(148, 360)
      Me.btnCheque.Name = "btnCheque"
      Me.btnCheque.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnCheque.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnCheque.Size = New System.Drawing.Size(136, 64)
      Me.btnCheque.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnCheque.TabIndex = 11
      Me.btnCheque.Text = "Chequeras"
      Me.btnCheque.UseCompatibleTextRendering = True
      Me.btnCheque.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'btnBanco
      '
      Me.btnBanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnBanco.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnBanco.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
      Me.btnBanco.ImageIndex = 0
      Me.btnBanco.ImageList = Me.ilsMain
      Me.btnBanco.ImageSize = New System.Drawing.Size(30, 45)
      Me.btnBanco.Location = New System.Drawing.Point(8, 360)
      Me.btnBanco.Name = "btnBanco"
      Me.btnBanco.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnBanco.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnBanco.Size = New System.Drawing.Size(136, 64)
      Me.btnBanco.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnBanco.TabIndex = 10
      Me.btnBanco.Text = "Bancos"
      Me.btnBanco.UseCompatibleTextRendering = True
      Me.btnBanco.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label8
      '
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.Color.DarkRed
      Me.Label8.Location = New System.Drawing.Point(12, 112)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(132, 32)
      Me.Label8.TabIndex = 218
      Me.Label8.Text = "1"
      Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'bcgMain
      '
      Me.bcgMain.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.Panel
      Me.bcgMain.Controls.Add(Me.PictureBox1)
      Me.bcgMain.Controls.Add(Me.btnExit)
      Me.bcgMain.Controls.Add(Me.Label11)
      Me.bcgMain.Controls.Add(Me.Label12)
      Me.bcgMain.Controls.Add(Me.Label5)
      Me.bcgMain.Controls.Add(Me.Label6)
      Me.bcgMain.Controls.Add(Me.Label7)
      Me.bcgMain.Controls.Add(Me.Label9)
      Me.bcgMain.Controls.Add(Me.btnSucursal)
      Me.bcgMain.Controls.Add(Me.Label10)
      Me.bcgMain.Controls.Add(Me.btnCentroCostoDet)
      Me.bcgMain.Controls.Add(Me.Label3)
      Me.bcgMain.Controls.Add(Me.Label4)
      Me.bcgMain.Controls.Add(Me.Label2)
      Me.bcgMain.Controls.Add(Me.Label1)
      Me.bcgMain.Dock = System.Windows.Forms.DockStyle.Fill
      Me.bcgMain.FrameStyle = Janus.Windows.EditControls.FrameStyle.None
      Me.bcgMain.Location = New System.Drawing.Point(0, 0)
      Me.bcgMain.Name = "bcgMain"
      Me.bcgMain.Size = New System.Drawing.Size(710, 432)
      Me.bcgMain.TabIndex = 219
      Me.bcgMain.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007
      '
      'PictureBox1
      '
      Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
      Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
      Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(710, 104)
      Me.PictureBox1.TabIndex = 230
      Me.PictureBox1.TabStop = False
      '
      'btnExit
      '
      Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
      Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
      Me.btnExit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
      Me.btnExit.ImageIndex = 1
      Me.btnExit.ImageList = Me.ilsMain
      Me.btnExit.ImageSize = New System.Drawing.Size(48, 48)
      Me.btnExit.Location = New System.Drawing.Point(632, 360)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom
      Me.btnExit.Office2007CustomColor = System.Drawing.Color.DodgerBlue
      Me.btnExit.Size = New System.Drawing.Size(72, 64)
      Me.btnExit.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.DarkBlue
      Me.btnExit.TabIndex = 12
      Me.btnExit.UseCompatibleTextRendering = True
      Me.btnExit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'Label11
      '
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.Color.DarkRed
      Me.Label11.Location = New System.Drawing.Point(12, 328)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(132, 32)
      Me.Label11.TabIndex = 228
      Me.Label11.Text = "11"
      Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label12
      '
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.ForeColor = System.Drawing.Color.DarkRed
      Me.Label12.Location = New System.Drawing.Point(152, 328)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(132, 32)
      Me.Label12.TabIndex = 229
      Me.Label12.Text = "12"
      Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label5
      '
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.Color.DarkRed
      Me.Label5.Location = New System.Drawing.Point(572, 220)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(132, 32)
      Me.Label5.TabIndex = 227
      Me.Label5.Text = "10"
      Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label6
      '
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.Color.DarkRed
      Me.Label6.Location = New System.Drawing.Point(12, 220)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(132, 32)
      Me.Label6.TabIndex = 223
      Me.Label6.Text = "6"
      Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label7
      '
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.Color.DarkRed
      Me.Label7.Location = New System.Drawing.Point(432, 220)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(132, 32)
      Me.Label7.TabIndex = 226
      Me.Label7.Text = "9"
      Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label9
      '
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.ForeColor = System.Drawing.Color.DarkRed
      Me.Label9.Location = New System.Drawing.Point(292, 220)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(132, 32)
      Me.Label9.TabIndex = 225
      Me.Label9.Text = "8"
      Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label10
      '
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.ForeColor = System.Drawing.Color.DarkRed
      Me.Label10.Location = New System.Drawing.Point(152, 220)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(132, 32)
      Me.Label10.TabIndex = 224
      Me.Label10.Text = "7"
      Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label3
      '
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.Color.DarkRed
      Me.Label3.Location = New System.Drawing.Point(572, 112)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(132, 32)
      Me.Label3.TabIndex = 222
      Me.Label3.Text = "5"
      Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label4
      '
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.Color.DarkRed
      Me.Label4.Location = New System.Drawing.Point(432, 112)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(132, 32)
      Me.Label4.TabIndex = 221
      Me.Label4.Text = "4"
      Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.Color.DarkRed
      Me.Label2.Location = New System.Drawing.Point(292, 112)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(132, 32)
      Me.Label2.TabIndex = 220
      Me.Label2.Text = "3"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.DarkRed
      Me.Label1.Location = New System.Drawing.Point(152, 112)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(132, 32)
      Me.Label1.TabIndex = 219
      Me.Label1.Text = "2"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'frmWizard
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
      Me.ClientSize = New System.Drawing.Size(710, 432)
      Me.Controls.Add(Me.Label8)
      Me.Controls.Add(Me.btnCheque)
      Me.Controls.Add(Me.btnBanco)
      Me.Controls.Add(Me.btnCentroCosto)
      Me.Controls.Add(Me.btnPlanAdd)
      Me.Controls.Add(Me.btnPlan)
      Me.Controls.Add(Me.btnEmpresaPara)
      Me.Controls.Add(Me.btnDosifica)
      Me.Controls.Add(Me.btnCompPara)
      Me.Controls.Add(Me.btnGestion)
      Me.Controls.Add(Me.btnEmpresa)
      Me.Controls.Add(Me.bcgMain)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmWizard"
      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Asistente de Implementación"
      CType(Me.bcgMain, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bcgMain.ResumeLayout(False)
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub btnEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresa.Click
      Dim frm As New frmEmpresa

      With frm
         .MdiParent = Me.MdiParent
         .Show()
      End With
   End Sub

   Private Sub btnEmpresaPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmpresaPara.Click
      Dim frm As New frmEmpresaPara

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnGestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestion.Click
      Dim frm As New frmGestion

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnCompPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompPara.Click
      Dim frm As New frmCompPara

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.Click
      Dim frm As New frmPlan

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnPlanAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlanAdd.Click
      Dim frm As New frmPlanAdd

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentroCosto.Click
      Dim frm As New frmCentroCosto

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnCentroCostoDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentroCostoDet.Click
      Dim frm As New frmCentroCostoDet

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSucursal.Click
      Dim frm As New frmSucursal

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnDosifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDosifica.Click
      Dim frm As New frmDosifica

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnBanco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBanco.Click
      Dim frm As New frmBanco

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnCheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheque.Click
      Dim frm As New frmCheque

      With frm
         .MdiParent = Me.MdiParent
         .EmpresaId = clsAppInfo.EmpresaId
         .Show()
      End With
   End Sub

   Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
      Me.Close()
   End Sub
End Class