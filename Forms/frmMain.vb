Imports System.Diagnostics

Public Class frmMain
   Inherits System.Windows.Forms.Form
   Dim ctlMDI As MdiClient

#Region " Código generado por el Diseñador de Windows Forms "

   Public Sub New()
      MyBase.New()

      'El Diseñador de Windows Forms requiere esta llamada.
      InitializeComponent()

      'Agregar cualquier inicialización después de la llamada a InitializeComponent()

   End Sub

   'Form reemplaza a Dispose para limpiar la lista de componentes.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Requerido por el Diseñador de Windows Forms
   Private components As System.ComponentModel.IContainer

   'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
   'Puede modificarse utilizando el Diseñador de Windows Forms. 
   'No lo modifique con el editor de código.
   Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents mnuEmpresa2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
   Friend WithEvents mnuPlan2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlan1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanAdd2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCosto2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSucursal2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRegRUC2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanAdd1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCosto1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSucursal1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRegRUC1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCheque2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCiudad2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCheque1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCiudad1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTransaccion As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTransaccion1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuComp2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuComp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayor2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayor1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents frmLibroDiario1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAjuste2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreCuenta2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreGestion2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAjuste1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreCuenta1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreGestion1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReporte As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReporte1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalance2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultado2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldo2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVA2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroBanco2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalance1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultado1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVA1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroBanco1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroITF2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAdd2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroSucursal2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCosto2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroITF1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAdd1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroSucursal1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCosto1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametro2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametro1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresaPara2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompPara2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyuda2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyuda1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents New2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separador As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Edit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Delete As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ViewAll As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Print As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Exit2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Menu1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents ToolBar1 As Janus.Windows.UI.CommandBars.UICommandBar
   Public WithEvents cdmMain As Janus.Windows.UI.CommandBars.UICommandManager
   Friend WithEvents mnuVer As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuVer1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnEmpresa As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnPlan As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnPlan1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnComp As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnLibroMayor As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnBalance As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnEstadoResultado As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnLibroIVA As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnEmpresaPara As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnEmpresaPara1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnTipoCambio As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnTipoCambio1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuImpuesto As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuImpuesto1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnExit As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnExit1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnUserPass As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnUserPass1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator10 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnEmpresa1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnHelp As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnHelp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator11 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametroSub As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametroSub1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresaPara1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompPara1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReciboPara As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReciboPara1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRespaldo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRespaldo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRecibo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRecibo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDiario As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnHelpVideo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnHelpVideo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator12 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroAgruIVA As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroAgruIVA1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddCuenta As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddCuenta1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddAna As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddAna1 As Janus.Windows.UI.CommandBars.UICommand
   Public WithEvents sbrMain As Janus.Windows.UI.StatusBar.UIStatusBar
   Friend WithEvents mnuLibroDispo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFactura As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFacturaCompra As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFacturaVenta As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPoliza As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAduana As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAduana1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompFecha As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompFecha1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompBloqueo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompBloqueo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompParaMes As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompParaMes1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator14 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnCalculadora As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnCalculadora1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator15 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoComp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDosifica As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDosifica1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator16 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator17 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator18 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPoliza1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator13 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator19 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlan3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanAdd3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCosto3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSucursal3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator20 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCheque3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator21 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRegRUC3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAduana2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDosifica2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator22 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCiudad3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRespaldo2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuComp3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompBloqueo2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator23 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPoliza2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRecibo2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator24 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayor3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDiario1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator25 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAjuste3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreCuenta3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreGestion3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalance3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultado3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldo3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompFecha2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVA3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroAgruIVA2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroBanco3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroITF3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispo2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAdd3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroSucursal3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCosto3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoComp2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddCuenta2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddAna2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametroSub2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuImpuesto2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresaPara3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompPara3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompParaMes2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReciboPara2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlan4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanAdd4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCosto4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSucursal4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator30 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCheque4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator31 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRegRUC4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAduana3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDosifica3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator32 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCiudad4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRespaldo3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuComp4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompBloqueo3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator33 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPoliza3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRecibo3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator34 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayor4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDiario2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator35 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAjuste4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreCuenta4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreGestion4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalance4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultado4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldo4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompFecha3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVA4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroAgruIVA3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroBanco4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroITF4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispo3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAdd4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroSucursal4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCosto4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoComp3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddCuenta3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddAna3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametroSub3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuImpuesto3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresaPara4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompPara4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompParaMes3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReciboPara3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoComp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator36 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlan5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanAdd5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCosto5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSucursal5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator37 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCheque5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator38 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRegRUC5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAduana4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDosifica4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator39 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCiudad5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRespaldo4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuComp5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompBloqueo4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator40 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPoliza4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRecibo4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator41 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayor5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDiario3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator42 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAjuste5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreCuenta5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreGestion5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalance5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultado5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldo5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompFecha4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVA5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroAgruIVA4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroBanco5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroITF5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispo4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAdd5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroSucursal5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCosto5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator43 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddCuenta4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddAna4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametroSub4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuImpuesto4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresaPara5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompPara5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompParaMes4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReciboPara4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoMes As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoMes1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoMes1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuOpera1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCostoDet As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCostoDet1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator44 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator45 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSucursal6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator46 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlan6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanAdd6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator47 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCosto6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCostoDet2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator48 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCheque6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator49 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRegRUC6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAduana5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDosifica5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator50 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCiudad6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRespaldo5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuComp6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompBloqueo5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator51 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPoliza5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRecibo5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator52 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayor6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDiario4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator53 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAjuste6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreCuenta6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreGestion6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalance6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultado6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldo6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompFecha5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVA6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroAgruIVA5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroBanco6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroITF6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispo5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAdd6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroSucursal6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCosto6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator54 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoMes2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoMes2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddCuenta5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddAna5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuOpera2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametroSub5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuImpuesto5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresaPara6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompPara6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompParaMes5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReciboPara5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuComp7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompBloqueo6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator60 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPoliza6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRecibo6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator62 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAjuste7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreCuenta7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCierreGestion7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldo7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompFecha6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVA7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroAgruIVA6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroBanco7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroITF7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispo6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAdd7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroSucursal7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCosto7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator63 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoMes3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddCuenta6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroPlanAddAna6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuGestion7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuParametroSub6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoCambio7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuImpuesto6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAyudaDinamica6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAboutBox7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuToolBar6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuStatusBar6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresaPara7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompPara7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCompParaMes6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuReciboPara6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoDetMain As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoMain1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoDet As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoDet1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoDetAct As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDiario5 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator61 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ToolSet1 As Janus.Windows.UI.CommandBars.UICommandBar
   Friend WithEvents btnExcel As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnFilter As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnSort As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnExcel1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator26 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnFilter1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator27 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents btnSort1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents gexMain As Janus.Windows.GridEX.Export.GridEXExporter
   Friend WithEvents mnuPais As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDepartamento As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataBaseBackup1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataBaseBackup As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator28 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataBaseImport1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataBaseImport As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFlujoEfectivoDet1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFlujoEfectivoDet As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLabor As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataSecurityImport1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDataSecurityImport As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroRetencion1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroRetencion As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoActEco As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDosificaLey As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommand2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommand4 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommand1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents UiCommand3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuWizard1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuWizard As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorDuo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator29 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCheque1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuConciliaBanco1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator64 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCheque As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuConciliaBanco As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoComparativo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalanceComparativo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanEEFF As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFlujoEfectivoFind As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoFlujoEfectivoFind As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFlujoEfectivo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFlujoEfectivo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuFlujoEfectivoFind1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoFlujoEfectivoFind1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuChequeOpen As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator66 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuChequeOpen1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoCC As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoMenu1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoMenu As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoGeneral1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoCC1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoEmpresas1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalanceMenu1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalanceMenu As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalance7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBalanceComparativo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCatalogo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCatalogo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEmpresa7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSucursal7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator55 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlan7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanAdd7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPlanEEFF1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator56 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCosto7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCentroCostoDet3 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator57 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuBanco7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCheque7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator58 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDosifica6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuTipoActEco1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDosificaLey1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRegRUC7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuAduana6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents Separator59 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuPais1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuDepartamento1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuCiudad7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuRespaldo6 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorAnalisis As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoAct1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuEstadoResultadoAct As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorDet As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorMenu As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorMenu1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayor7 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorAnalisis1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorDet1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorDuo2 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVACC As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroIVACC1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoDetActEmpresa As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoDetActEmpresa1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldoGeneral As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldoGeneral1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldoAnalisis1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldoAnalisis As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents ilsMain As System.Windows.Forms.ImageList
   Friend WithEvents btnComp1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldoComparativo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldoComparativo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispoGeneral1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispoComparativo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispoGeneral As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroDispoComparativo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorComparativo As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroMayorComparativo1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldoComparativoCC1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuSumaSaldoComparativoCC As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProvincia1 As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuProvincia As Janus.Windows.UI.CommandBars.UICommand
   Friend WithEvents mnuLibroCentroCostoDetAct1 As Janus.Windows.UI.CommandBars.UICommand
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container
      Dim UiStatusBarPanel1 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
      Dim UiStatusBarPanel2 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
      Dim UiStatusBarPanel3 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
      Dim UiStatusBarPanel4 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
      Dim UiStatusBarPanel5 As Janus.Windows.UI.StatusBar.UIStatusBarPanel = New Janus.Windows.UI.StatusBar.UIStatusBarPanel
      Me.cdmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
      Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.Menu1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.mnuCatalogo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCatalogo")
      Me.mnuTransaccion1 = New Janus.Windows.UI.CommandBars.UICommand("mnuTransaccion")
      Me.mnuReporte1 = New Janus.Windows.UI.CommandBars.UICommand("mnuReporte")
      Me.mnuParametro1 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametro")
      Me.mnuVer1 = New Janus.Windows.UI.CommandBars.UICommand("mnuVer")
      Me.mnuAyuda1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyuda")
      Me.ToolBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.btnEmpresa1 = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresa")
      Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnPlan1 = New Janus.Windows.UI.CommandBars.UICommand("btnPlan")
      Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnComp1 = New Janus.Windows.UI.CommandBars.UICommand("btnComp")
      Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnEmpresaPara1 = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresaPara")
      Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnTipoCambio1 = New Janus.Windows.UI.CommandBars.UICommand("btnTipoCambio")
      Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnUserPass1 = New Janus.Windows.UI.CommandBars.UICommand("btnUserPass")
      Me.Separator10 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnCalculadora1 = New Janus.Windows.UI.CommandBars.UICommand("btnCalculadora")
      Me.Separator15 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnHelp1 = New Janus.Windows.UI.CommandBars.UICommand("btnHelp")
      Me.Separator11 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnHelpVideo1 = New Janus.Windows.UI.CommandBars.UICommand("btnHelpVideo")
      Me.Separator12 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnExit1 = New Janus.Windows.UI.CommandBars.UICommand("btnExit")
      Me.ToolSet1 = New Janus.Windows.UI.CommandBars.UICommandBar
      Me.btnExcel1 = New Janus.Windows.UI.CommandBars.UICommand("btnExcel")
      Me.Separator26 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnFilter1 = New Janus.Windows.UI.CommandBars.UICommand("btnFilter")
      Me.Separator27 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.btnSort1 = New Janus.Windows.UI.CommandBars.UICommand("btnSort")
      Me.mnuCatalogo = New Janus.Windows.UI.CommandBars.UICommand("mnuCatalogo")
      Me.mnuEmpresa7 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
      Me.mnuSucursal7 = New Janus.Windows.UI.CommandBars.UICommand("mnuSucursal")
      Me.Separator55 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPlan7 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlan")
      Me.mnuPlanAdd7 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanAdd")
      Me.mnuPlanEEFF1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanEEFF")
      Me.Separator56 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuCentroCosto7 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCosto")
      Me.mnuCentroCostoDet3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCostoDet")
      Me.Separator57 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuBanco7 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
      Me.mnuCheque7 = New Janus.Windows.UI.CommandBars.UICommand("mnuCheque")
      Me.Separator58 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuDosifica6 = New Janus.Windows.UI.CommandBars.UICommand("mnuDosifica")
      Me.mnuTipoActEco1 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoActEco")
      Me.mnuDosificaLey1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDosificaLey")
      Me.mnuRegRUC7 = New Janus.Windows.UI.CommandBars.UICommand("mnuRegRUC")
      Me.mnuAduana6 = New Janus.Windows.UI.CommandBars.UICommand("mnuAduana")
      Me.Separator59 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPais1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPais")
      Me.mnuDepartamento1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDepartamento")
      Me.mnuCiudad7 = New Janus.Windows.UI.CommandBars.UICommand("mnuCiudad")
      Me.mnuRespaldo6 = New Janus.Windows.UI.CommandBars.UICommand("mnuRespaldo")
      Me.mnuEmpresa2 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
      Me.mnuPlan2 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlan")
      Me.mnuPlanAdd2 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanAdd")
      Me.mnuCentroCosto2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCosto")
      Me.mnuSucursal2 = New Janus.Windows.UI.CommandBars.UICommand("mnuSucursal")
      Me.mnuRegRUC2 = New Janus.Windows.UI.CommandBars.UICommand("mnuRegRUC")
      Me.mnuBanco2 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
      Me.mnuCheque2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCheque")
      Me.mnuCiudad2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCiudad")
      Me.mnuTransaccion = New Janus.Windows.UI.CommandBars.UICommand("mnuTransaccion")
      Me.mnuComp7 = New Janus.Windows.UI.CommandBars.UICommand("mnuComp")
      Me.mnuCompBloqueo6 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompBloqueo")
      Me.Separator60 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPoliza6 = New Janus.Windows.UI.CommandBars.UICommand("mnuPoliza")
      Me.mnuRecibo6 = New Janus.Windows.UI.CommandBars.UICommand("mnuRecibo")
      Me.Separator66 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuChequeOpen1 = New Janus.Windows.UI.CommandBars.UICommand("mnuChequeOpen")
      Me.Separator62 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuAjuste7 = New Janus.Windows.UI.CommandBars.UICommand("mnuAjuste")
      Me.mnuCierreCuenta7 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreCuenta")
      Me.mnuCierreGestion7 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreGestion")
      Me.mnuComp2 = New Janus.Windows.UI.CommandBars.UICommand("mnuComp")
      Me.mnuLibroMayor2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayor")
      Me.mnuLibroDiario = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDiario")
      Me.mnuAjuste2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAjuste")
      Me.mnuCierreCuenta2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreCuenta")
      Me.mnuCierreGestion2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreGestion")
      Me.mnuReporte = New Janus.Windows.UI.CommandBars.UICommand("mnuReporte")
      Me.mnuBalanceMenu1 = New Janus.Windows.UI.CommandBars.UICommand("mnuBalanceMenu")
      Me.mnuEstadoResultadoMenu1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoMenu")
      Me.mnuSumaSaldo7 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldo")
      Me.mnuLibroMayorMenu1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorMenu")
      Me.mnuLibroDiario5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDiario")
      Me.mnuCompFecha6 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompFecha")
      Me.Separator61 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuLibroIVA7 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA")
      Me.mnuLibroAgruIVA6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroAgruIVA")
      Me.mnuLibroRetencion1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroRetencion")
      Me.Separator29 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuLibroBanco7 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroBanco")
      Me.mnuLibroCheque1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCheque")
      Me.mnuConciliaBanco1 = New Janus.Windows.UI.CommandBars.UICommand("mnuConciliaBanco")
      Me.mnuLibroITF7 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroITF")
      Me.mnuLibroDispo6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispo")
      Me.mnuFlujoEfectivoDet1 = New Janus.Windows.UI.CommandBars.UICommand("mnuFlujoEfectivoDet")
      Me.Separator64 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuLibroPlanAdd7 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAdd")
      Me.mnuLibroCentroCosto7 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCosto")
      Me.mnuLibroCentroCostoMes3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoMes")
      Me.mnuLibroCentroCostoMain1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoDetMain")
      Me.mnuLibroSucursal7 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroSucursal")
      Me.Separator63 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuFlujoEfectivo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuFlujoEfectivo")
      Me.mnuBalance2 = New Janus.Windows.UI.CommandBars.UICommand("mnuBalance")
      Me.mnuEstadoResultado2 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoGeneral")
      Me.mnuSumaSaldo2 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldo")
      Me.mnuSumaSaldoGeneral1 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldoGeneral")
      Me.mnuSumaSaldoComparativoCC1 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldoComparativoCC")
      Me.mnuSumaSaldoComparativo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldoComparativo")
      Me.mnuSumaSaldoAnalisis1 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldoAnalisis")
      Me.mnuLibroIVA2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA")
      Me.UiCommand2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA-NSF")
      Me.UiCommand4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA-SFV")
      Me.mnuLibroIVACC1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVACC")
      Me.mnuLibroBanco2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroBanco")
      Me.mnuLibroITF2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroITF")
      Me.mnuLibroPlanAdd2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAdd")
      Me.mnuLibroPlanAddCuenta6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddCuenta")
      Me.mnuLibroPlanAddAna6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddAna")
      Me.mnuLibroSucursal2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroSucursal")
      Me.mnuLibroCentroCosto2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCosto")
      Me.mnuParametro2 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametro")
      Me.mnuGestion7 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
      Me.mnuParametroSub6 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametroSub")
      Me.mnuTipoCambio7 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
      Me.mnuImpuesto6 = New Janus.Windows.UI.CommandBars.UICommand("mnuImpuesto")
      Me.mnuWizard1 = New Janus.Windows.UI.CommandBars.UICommand("mnuWizard")
      Me.Separator28 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuDataBaseBackup1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDataBaseBackup")
      Me.mnuDataBaseImport1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDataBaseImport")
      Me.mnuDataSecurityImport1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDataSecurityImport")
      Me.mnuEmpresaPara2 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresaPara")
      Me.mnuGestion2 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
      Me.mnuCompPara2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompPara")
      Me.mnuTipoCambio2 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
      Me.mnuAyuda2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyuda")
      Me.mnuAyudaDinamica6 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
      Me.mnuAboutBox7 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
      Me.mnuAyudaDinamica = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
      Me.mnuAboutBox2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
      Me.New2 = New Janus.Windows.UI.CommandBars.UICommand("New")
      Me.Separador = New Janus.Windows.UI.CommandBars.UICommand("Separador")
      Me.Edit = New Janus.Windows.UI.CommandBars.UICommand("Edit")
      Me.Delete = New Janus.Windows.UI.CommandBars.UICommand("Delete")
      Me.ViewAll = New Janus.Windows.UI.CommandBars.UICommand("ViewAll")
      Me.Print = New Janus.Windows.UI.CommandBars.UICommand("Print")
      Me.Exit2 = New Janus.Windows.UI.CommandBars.UICommand("Exit")
      Me.mnuVer = New Janus.Windows.UI.CommandBars.UICommand("mnuVer")
      Me.mnuToolBar6 = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
      Me.mnuStatusBar6 = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
      Me.mnuToolBar = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
      Me.mnuStatusBar = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
      Me.btnEmpresa = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresa")
      Me.btnPlan = New Janus.Windows.UI.CommandBars.UICommand("btnPlan")
      Me.btnComp = New Janus.Windows.UI.CommandBars.UICommand("btnComp")
      Me.btnLibroMayor = New Janus.Windows.UI.CommandBars.UICommand("btnLibroMayor")
      Me.btnBalance = New Janus.Windows.UI.CommandBars.UICommand("btnBalance")
      Me.btnEstadoResultado = New Janus.Windows.UI.CommandBars.UICommand("btnEstadoResultado")
      Me.btnLibroIVA = New Janus.Windows.UI.CommandBars.UICommand("btnLibroIVA")
      Me.btnEmpresaPara = New Janus.Windows.UI.CommandBars.UICommand("btnEmpresaPara")
      Me.btnTipoCambio = New Janus.Windows.UI.CommandBars.UICommand("btnTipoCambio")
      Me.mnuImpuesto = New Janus.Windows.UI.CommandBars.UICommand("mnuImpuesto")
      Me.btnExit = New Janus.Windows.UI.CommandBars.UICommand("btnExit")
      Me.btnUserPass = New Janus.Windows.UI.CommandBars.UICommand("btnUserPass")
      Me.btnHelp = New Janus.Windows.UI.CommandBars.UICommand("btnHelp")
      Me.mnuParametroSub = New Janus.Windows.UI.CommandBars.UICommand("mnuParametroSub")
      Me.mnuEmpresaPara7 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresaPara")
      Me.mnuCompPara7 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompPara")
      Me.mnuCompParaMes6 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompParaMes")
      Me.mnuReciboPara6 = New Janus.Windows.UI.CommandBars.UICommand("mnuReciboPara")
      Me.mnuReciboPara = New Janus.Windows.UI.CommandBars.UICommand("mnuReciboPara")
      Me.mnuRespaldo = New Janus.Windows.UI.CommandBars.UICommand("mnuRespaldo")
      Me.mnuRecibo = New Janus.Windows.UI.CommandBars.UICommand("mnuRecibo")
      Me.btnHelpVideo = New Janus.Windows.UI.CommandBars.UICommand("btnHelpVideo")
      Me.mnuLibroAgruIVA = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroAgruIVA")
      Me.mnuLibroPlanAddCuenta = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddCuenta")
      Me.mnuLibroPlanAddAna = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddAna")
      Me.mnuLibroDispo = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispo")
      Me.mnuLibroDispoGeneral1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispoGeneral")
      Me.mnuLibroDispoComparativo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispoComparativo")
      Me.mnuFactura = New Janus.Windows.UI.CommandBars.UICommand("mnuFactura")
      Me.mnuFacturaCompra = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturaCompra")
      Me.mnuFacturaVenta = New Janus.Windows.UI.CommandBars.UICommand("mnuFacturaVenta")
      Me.mnuPoliza = New Janus.Windows.UI.CommandBars.UICommand("mnuPoliza")
      Me.mnuAduana = New Janus.Windows.UI.CommandBars.UICommand("mnuAduana")
      Me.mnuCompFecha = New Janus.Windows.UI.CommandBars.UICommand("mnuCompFecha")
      Me.mnuCompBloqueo = New Janus.Windows.UI.CommandBars.UICommand("mnuCompBloqueo")
      Me.mnuCompParaMes = New Janus.Windows.UI.CommandBars.UICommand("mnuCompParaMes")
      Me.btnCalculadora = New Janus.Windows.UI.CommandBars.UICommand("btnCalculadora")
      Me.mnuLibroCentroCostoMes = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoMes")
      Me.mnuDosifica = New Janus.Windows.UI.CommandBars.UICommand("mnuDosifica")
      Me.mnuCentroCostoDet = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCostoDet")
      Me.mnuLibroCentroCostoDetMain = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoDetMain")
      Me.mnuLibroCentroCostoDet1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoDet")
      Me.mnuLibroCentroCostoDetAct1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoDetAct")
      Me.mnuLibroCentroCostoDetActEmpresa1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoDetActEmpresa")
      Me.mnuLibroCentroCostoDet = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoDet")
      Me.mnuLibroCentroCostoDetAct = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoDetAct")
      Me.btnExcel = New Janus.Windows.UI.CommandBars.UICommand("btnExcel")
      Me.btnFilter = New Janus.Windows.UI.CommandBars.UICommand("btnFilter")
      Me.btnSort = New Janus.Windows.UI.CommandBars.UICommand("btnSort")
      Me.mnuPais = New Janus.Windows.UI.CommandBars.UICommand("mnuPais")
      Me.mnuDepartamento = New Janus.Windows.UI.CommandBars.UICommand("mnuDepartamento")
      Me.mnuDataBaseBackup = New Janus.Windows.UI.CommandBars.UICommand("mnuDataBaseBackup")
      Me.mnuDataBaseImport = New Janus.Windows.UI.CommandBars.UICommand("mnuDataBaseImport")
      Me.mnuFlujoEfectivoDet = New Janus.Windows.UI.CommandBars.UICommand("mnuFlujoEfectivoDet")
      Me.mnuLabor = New Janus.Windows.UI.CommandBars.UICommand("mnuLabor")
      Me.mnuDataSecurityImport = New Janus.Windows.UI.CommandBars.UICommand("mnuDataSecurityImport")
      Me.mnuLibroRetencion = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroRetencion")
      Me.mnuTipoActEco = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoActEco")
      Me.mnuDosificaLey = New Janus.Windows.UI.CommandBars.UICommand("mnuDosificaLey")
      Me.UiCommand1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA-NSF")
      Me.UiCommand3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA-SFV")
      Me.mnuWizard = New Janus.Windows.UI.CommandBars.UICommand("mnuWizard")
      Me.mnuLibroMayorDuo = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorDuo")
      Me.mnuLibroCheque = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCheque")
      Me.mnuConciliaBanco = New Janus.Windows.UI.CommandBars.UICommand("mnuConciliaBanco")
      Me.mnuEstadoComparativo = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoEmpresas")
      Me.mnuBalanceComparativo = New Janus.Windows.UI.CommandBars.UICommand("mnuBalanceComparativo")
      Me.mnuPlanEEFF = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanEEFF")
      Me.mnuFlujoEfectivoFind = New Janus.Windows.UI.CommandBars.UICommand("mnuFlujoEfectivoFind")
      Me.mnuEstadoFlujoEfectivoFind = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoFlujoEfectivoFind")
      Me.mnuFlujoEfectivo = New Janus.Windows.UI.CommandBars.UICommand("mnuFlujoEfectivo")
      Me.mnuFlujoEfectivoFind1 = New Janus.Windows.UI.CommandBars.UICommand("mnuFlujoEfectivoFind")
      Me.mnuEstadoFlujoEfectivoFind1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoFlujoEfectivoFind")
      Me.mnuChequeOpen = New Janus.Windows.UI.CommandBars.UICommand("mnuChequeOpen")
      Me.mnuEstadoResultadoCC = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoCC")
      Me.mnuEstadoResultadoMenu = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoMenu")
      Me.mnuEstadoResultadoGeneral1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoGeneral")
      Me.mnuEstadoResultadoAct1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoAct")
      Me.mnuEstadoResultadoCC1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoCC")
      Me.mnuEstadoResultadoEmpresas1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoEmpresas")
      Me.mnuBalanceMenu = New Janus.Windows.UI.CommandBars.UICommand("mnuBalanceMenu")
      Me.mnuBalance7 = New Janus.Windows.UI.CommandBars.UICommand("mnuBalance")
      Me.mnuBalanceComparativo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuBalanceComparativo")
      Me.mnuLibroMayorAnalisis = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorAnalisis")
      Me.mnuEstadoResultadoAct = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoAct")
      Me.mnuLibroMayorDet = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorDet")
      Me.mnuLibroMayorMenu = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorMenu")
      Me.mnuLibroMayor7 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayor")
      Me.mnuLibroMayorDet1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorDet")
      Me.mnuLibroMayorAnalisis1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorAnalisis")
      Me.mnuLibroMayorDuo2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorDuo")
      Me.mnuLibroMayorComparativo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorComparativo")
      Me.mnuLibroIVACC = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVACC")
      Me.mnuLibroCentroCostoDetActEmpresa = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoDetActEmpresa")
      Me.mnuSumaSaldoGeneral = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldoGeneral")
      Me.mnuSumaSaldoAnalisis = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldoAnalisis")
      Me.mnuSumaSaldoComparativo = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldoComparativo")
      Me.mnuLibroDispoGeneral = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispoGeneral")
      Me.mnuLibroDispoComparativo = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispoComparativo")
      Me.mnuLibroMayorComparativo = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayorComparativo")
      Me.mnuSumaSaldoComparativoCC = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldoComparativoCC")
      Me.ilsMain = New System.Windows.Forms.ImageList(Me.components)
      Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
      Me.mnuEmpresa5 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
      Me.mnuSucursal5 = New Janus.Windows.UI.CommandBars.UICommand("mnuSucursal")
      Me.Separator45 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPlan5 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlan")
      Me.mnuPlanAdd5 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanAdd")
      Me.Separator44 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuCentroCosto5 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCosto")
      Me.mnuCentroCostoDet1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCostoDet")
      Me.Separator37 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuBanco5 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
      Me.mnuCheque5 = New Janus.Windows.UI.CommandBars.UICommand("mnuCheque")
      Me.Separator38 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuRegRUC5 = New Janus.Windows.UI.CommandBars.UICommand("mnuRegRUC")
      Me.mnuAduana4 = New Janus.Windows.UI.CommandBars.UICommand("mnuAduana")
      Me.mnuDosifica4 = New Janus.Windows.UI.CommandBars.UICommand("mnuDosifica")
      Me.Separator39 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuCiudad5 = New Janus.Windows.UI.CommandBars.UICommand("mnuCiudad")
      Me.mnuRespaldo4 = New Janus.Windows.UI.CommandBars.UICommand("mnuRespaldo")
      Me.mnuComp5 = New Janus.Windows.UI.CommandBars.UICommand("mnuComp")
      Me.mnuCompBloqueo4 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompBloqueo")
      Me.Separator40 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPoliza4 = New Janus.Windows.UI.CommandBars.UICommand("mnuPoliza")
      Me.mnuRecibo4 = New Janus.Windows.UI.CommandBars.UICommand("mnuRecibo")
      Me.Separator41 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuLibroMayor5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayor")
      Me.mnuLibroDiario3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDiario")
      Me.Separator42 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuAjuste5 = New Janus.Windows.UI.CommandBars.UICommand("mnuAjuste")
      Me.mnuCierreCuenta5 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreCuenta")
      Me.mnuCierreGestion5 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreGestion")
      Me.mnuBalance5 = New Janus.Windows.UI.CommandBars.UICommand("mnuBalance")
      Me.mnuEstadoResultado5 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultado")
      Me.mnuSumaSaldo5 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldo")
      Me.mnuCompFecha4 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompFecha")
      Me.mnuLibroIVA5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA")
      Me.mnuLibroAgruIVA4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroAgruIVA")
      Me.mnuLibroBanco5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroBanco")
      Me.mnuLibroITF5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroITF")
      Me.mnuLibroDispo4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispo")
      Me.mnuLibroPlanAdd5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAdd")
      Me.mnuLibroSucursal5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroSucursal")
      Me.mnuLibroCentroCosto5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCosto")
      Me.Separator43 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuEstadoResultadoMes1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoMes")
      Me.mnuLibroCentroCostoMes1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoMes")
      Me.mnuLibroPlanAddCuenta4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddCuenta")
      Me.mnuLibroPlanAddAna4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddAna")
      Me.mnuGestion5 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
      Me.mnuOpera1 = New Janus.Windows.UI.CommandBars.UICommand("mnuOpera")
      Me.mnuParametroSub4 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametroSub")
      Me.mnuTipoCambio5 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
      Me.mnuImpuesto4 = New Janus.Windows.UI.CommandBars.UICommand("mnuImpuesto")
      Me.mnuAyudaDinamica4 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
      Me.mnuAboutBox5 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
      Me.mnuToolBar4 = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
      Me.mnuStatusBar4 = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
      Me.mnuEmpresaPara5 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresaPara")
      Me.mnuCompPara5 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompPara")
      Me.mnuCompParaMes4 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompParaMes")
      Me.mnuReciboPara4 = New Janus.Windows.UI.CommandBars.UICommand("mnuReciboPara")
      Me.mnuEmpresa4 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
      Me.mnuPlan4 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlan")
      Me.mnuPlanAdd4 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanAdd")
      Me.mnuCentroCosto4 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCosto")
      Me.mnuSucursal4 = New Janus.Windows.UI.CommandBars.UICommand("mnuSucursal")
      Me.Separator30 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuBanco4 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
      Me.mnuCheque4 = New Janus.Windows.UI.CommandBars.UICommand("mnuCheque")
      Me.Separator31 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuRegRUC4 = New Janus.Windows.UI.CommandBars.UICommand("mnuRegRUC")
      Me.mnuAduana3 = New Janus.Windows.UI.CommandBars.UICommand("mnuAduana")
      Me.mnuDosifica3 = New Janus.Windows.UI.CommandBars.UICommand("mnuDosifica")
      Me.Separator32 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuCiudad4 = New Janus.Windows.UI.CommandBars.UICommand("mnuCiudad")
      Me.mnuRespaldo3 = New Janus.Windows.UI.CommandBars.UICommand("mnuRespaldo")
      Me.mnuComp4 = New Janus.Windows.UI.CommandBars.UICommand("mnuComp")
      Me.mnuCompBloqueo3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompBloqueo")
      Me.Separator33 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPoliza3 = New Janus.Windows.UI.CommandBars.UICommand("mnuPoliza")
      Me.mnuRecibo3 = New Janus.Windows.UI.CommandBars.UICommand("mnuRecibo")
      Me.Separator34 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuLibroMayor4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayor")
      Me.mnuLibroDiario2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDiario")
      Me.Separator35 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuAjuste4 = New Janus.Windows.UI.CommandBars.UICommand("mnuAjuste")
      Me.mnuCierreCuenta4 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreCuenta")
      Me.mnuCierreGestion4 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreGestion")
      Me.mnuBalance4 = New Janus.Windows.UI.CommandBars.UICommand("mnuBalance")
      Me.mnuEstadoResultado4 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultado")
      Me.mnuSumaSaldo4 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldo")
      Me.mnuCompFecha3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompFecha")
      Me.mnuLibroIVA4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA")
      Me.mnuLibroAgruIVA3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroAgruIVA")
      Me.mnuLibroBanco4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroBanco")
      Me.mnuLibroITF4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroITF")
      Me.mnuLibroDispo3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispo")
      Me.mnuLibroPlanAdd4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAdd")
      Me.mnuLibroSucursal4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroSucursal")
      Me.mnuLibroCentroCosto4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCosto")
      Me.mnuLibroCentroCostoComp3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoMes")
      Me.mnuLibroPlanAddCuenta3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddCuenta")
      Me.mnuLibroPlanAddAna3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddAna")
      Me.mnuGestion4 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
      Me.mnuParametroSub3 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametroSub")
      Me.mnuTipoCambio4 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
      Me.mnuImpuesto3 = New Janus.Windows.UI.CommandBars.UICommand("mnuImpuesto")
      Me.mnuAyudaDinamica3 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
      Me.mnuAboutBox4 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
      Me.mnuToolBar3 = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
      Me.mnuStatusBar3 = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
      Me.mnuEmpresaPara4 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresaPara")
      Me.mnuCompPara4 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompPara")
      Me.mnuCompParaMes3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompParaMes")
      Me.mnuReciboPara3 = New Janus.Windows.UI.CommandBars.UICommand("mnuReciboPara")
      Me.mnuEmpresa3 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
      Me.mnuPlan3 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlan")
      Me.mnuPlanAdd3 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanAdd")
      Me.mnuCentroCosto3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCosto")
      Me.mnuSucursal3 = New Janus.Windows.UI.CommandBars.UICommand("mnuSucursal")
      Me.Separator20 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuBanco3 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
      Me.mnuCheque3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCheque")
      Me.Separator21 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuRegRUC3 = New Janus.Windows.UI.CommandBars.UICommand("mnuRegRUC")
      Me.mnuAduana2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAduana")
      Me.mnuDosifica2 = New Janus.Windows.UI.CommandBars.UICommand("mnuDosifica")
      Me.Separator22 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuCiudad3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCiudad")
      Me.mnuRespaldo2 = New Janus.Windows.UI.CommandBars.UICommand("mnuRespaldo")
      Me.mnuComp3 = New Janus.Windows.UI.CommandBars.UICommand("mnuComp")
      Me.mnuCompBloqueo2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompBloqueo")
      Me.Separator23 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPoliza2 = New Janus.Windows.UI.CommandBars.UICommand("mnuPoliza")
      Me.mnuRecibo2 = New Janus.Windows.UI.CommandBars.UICommand("mnuRecibo")
      Me.Separator24 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuLibroMayor3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayor")
      Me.mnuLibroDiario1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDiario")
      Me.Separator25 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuAjuste3 = New Janus.Windows.UI.CommandBars.UICommand("mnuAjuste")
      Me.mnuCierreCuenta3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreCuenta")
      Me.mnuCierreGestion3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreGestion")
      Me.mnuBalance3 = New Janus.Windows.UI.CommandBars.UICommand("mnuBalance")
      Me.mnuEstadoResultado3 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultado")
      Me.mnuSumaSaldo3 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldo")
      Me.mnuCompFecha2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompFecha")
      Me.mnuLibroIVA3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA")
      Me.mnuLibroAgruIVA2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroAgruIVA")
      Me.mnuLibroBanco3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroBanco")
      Me.mnuLibroITF3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroITF")
      Me.mnuLibroDispo2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispo")
      Me.mnuLibroPlanAdd3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAdd")
      Me.mnuLibroSucursal3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroSucursal")
      Me.mnuLibroCentroCosto3 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCosto")
      Me.mnuLibroCentroCostoComp2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoComp")
      Me.mnuLibroPlanAddCuenta2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddCuenta")
      Me.mnuLibroPlanAddAna2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddAna")
      Me.mnuGestion3 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
      Me.mnuParametroSub2 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametroSub")
      Me.mnuTipoCambio3 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
      Me.mnuImpuesto2 = New Janus.Windows.UI.CommandBars.UICommand("mnuImpuesto")
      Me.mnuAyudaDinamica2 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
      Me.mnuAboutBox3 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
      Me.mnuToolBar2 = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
      Me.mnuStatusBar2 = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
      Me.mnuEmpresaPara3 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresaPara")
      Me.mnuCompPara3 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompPara")
      Me.mnuCompParaMes2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompParaMes")
      Me.mnuReciboPara2 = New Janus.Windows.UI.CommandBars.UICommand("mnuReciboPara")
      Me.mnuEmpresa1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
      Me.mnuPlan1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlan")
      Me.mnuPlanAdd1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanAdd")
      Me.mnuCentroCosto1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCosto")
      Me.mnuSucursal1 = New Janus.Windows.UI.CommandBars.UICommand("mnuSucursal")
      Me.Separator18 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuBanco1 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
      Me.mnuCheque1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCheque")
      Me.Separator16 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuRegRUC1 = New Janus.Windows.UI.CommandBars.UICommand("mnuRegRUC")
      Me.mnuAduana1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAduana")
      Me.mnuDosifica1 = New Janus.Windows.UI.CommandBars.UICommand("mnuDosifica")
      Me.Separator17 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuCiudad1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCiudad")
      Me.mnuRespaldo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuRespaldo")
      Me.mnuComp1 = New Janus.Windows.UI.CommandBars.UICommand("mnuComp")
      Me.mnuCompBloqueo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompBloqueo")
      Me.Separator13 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPoliza1 = New Janus.Windows.UI.CommandBars.UICommand("mnuPoliza")
      Me.mnuRecibo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuRecibo")
      Me.Separator19 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuLibroMayor1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayor")
      Me.frmLibroDiario1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDiario")
      Me.Separator14 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuAjuste1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAjuste")
      Me.mnuCierreCuenta1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreCuenta")
      Me.mnuCierreGestion1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreGestion")
      Me.mnuBalance1 = New Janus.Windows.UI.CommandBars.UICommand("mnuBalance")
      Me.mnuEstadoResultado1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultado")
      Me.mnuSumaSaldo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldo")
      Me.mnuCompFecha1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompFecha")
      Me.mnuLibroIVA1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA")
      Me.mnuLibroAgruIVA1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroAgruIVA")
      Me.mnuLibroBanco1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroBanco")
      Me.mnuLibroITF1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroITF")
      Me.mnuLibroDispo1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispo")
      Me.mnuLibroPlanAdd1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAdd")
      Me.mnuLibroSucursal1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroSucursal")
      Me.mnuLibroCentroCosto1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCosto")
      Me.mnuLibroCentroCostoComp1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoComp")
      Me.mnuLibroPlanAddCuenta1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddCuenta")
      Me.mnuLibroPlanAddAna1 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddAna")
      Me.mnuGestion1 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
      Me.mnuParametroSub1 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametroSub")
      Me.mnuTipoCambio1 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
      Me.mnuImpuesto1 = New Janus.Windows.UI.CommandBars.UICommand("mnuImpuesto")
      Me.mnuAyudaDinamica1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
      Me.mnuAboutBox1 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
      Me.mnuToolBar1 = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
      Me.mnuStatusBar1 = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
      Me.mnuEmpresaPara1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresaPara")
      Me.mnuCompPara1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompPara")
      Me.mnuCompParaMes1 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompParaMes")
      Me.mnuReciboPara1 = New Janus.Windows.UI.CommandBars.UICommand("mnuReciboPara")
      Me.sbrMain = New Janus.Windows.UI.StatusBar.UIStatusBar
      Me.mnuEstadoResultadoComp1 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoMes")
      Me.Separator36 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuEmpresa6 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresa")
      Me.mnuSucursal6 = New Janus.Windows.UI.CommandBars.UICommand("mnuSucursal")
      Me.Separator46 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPlan6 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlan")
      Me.mnuPlanAdd6 = New Janus.Windows.UI.CommandBars.UICommand("mnuPlanAdd")
      Me.Separator47 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuCentroCosto6 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCosto")
      Me.mnuCentroCostoDet2 = New Janus.Windows.UI.CommandBars.UICommand("mnuCentroCostoDet")
      Me.Separator48 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuBanco6 = New Janus.Windows.UI.CommandBars.UICommand("mnuBanco")
      Me.mnuCheque6 = New Janus.Windows.UI.CommandBars.UICommand("mnuCheque")
      Me.Separator49 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuRegRUC6 = New Janus.Windows.UI.CommandBars.UICommand("mnuRegRUC")
      Me.mnuAduana5 = New Janus.Windows.UI.CommandBars.UICommand("mnuAduana")
      Me.mnuDosifica5 = New Janus.Windows.UI.CommandBars.UICommand("mnuDosifica")
      Me.Separator50 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuCiudad6 = New Janus.Windows.UI.CommandBars.UICommand("mnuCiudad")
      Me.mnuRespaldo5 = New Janus.Windows.UI.CommandBars.UICommand("mnuRespaldo")
      Me.mnuComp6 = New Janus.Windows.UI.CommandBars.UICommand("mnuComp")
      Me.mnuCompBloqueo5 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompBloqueo")
      Me.Separator51 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuPoliza5 = New Janus.Windows.UI.CommandBars.UICommand("mnuPoliza")
      Me.mnuRecibo5 = New Janus.Windows.UI.CommandBars.UICommand("mnuRecibo")
      Me.Separator52 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuLibroMayor6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroMayor")
      Me.mnuLibroDiario4 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDiario")
      Me.Separator53 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuAjuste6 = New Janus.Windows.UI.CommandBars.UICommand("mnuAjuste")
      Me.mnuCierreCuenta6 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreCuenta")
      Me.mnuCierreGestion6 = New Janus.Windows.UI.CommandBars.UICommand("mnuCierreGestion")
      Me.mnuBalance6 = New Janus.Windows.UI.CommandBars.UICommand("mnuBalance")
      Me.mnuEstadoResultado6 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultado")
      Me.mnuSumaSaldo6 = New Janus.Windows.UI.CommandBars.UICommand("mnuSumaSaldo")
      Me.mnuCompFecha5 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompFecha")
      Me.mnuLibroIVA6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroIVA")
      Me.mnuLibroAgruIVA5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroAgruIVA")
      Me.mnuLibroBanco6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroBanco")
      Me.mnuLibroITF6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroITF")
      Me.mnuLibroDispo5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroDispo")
      Me.mnuLibroPlanAdd6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAdd")
      Me.mnuLibroSucursal6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroSucursal")
      Me.mnuLibroCentroCosto6 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCosto")
      Me.Separator54 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
      Me.mnuEstadoResultadoMes2 = New Janus.Windows.UI.CommandBars.UICommand("mnuEstadoResultadoMes")
      Me.mnuLibroCentroCostoMes2 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroCentroCostoMes")
      Me.mnuLibroPlanAddCuenta5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddCuenta")
      Me.mnuLibroPlanAddAna5 = New Janus.Windows.UI.CommandBars.UICommand("mnuLibroPlanAddAna")
      Me.mnuGestion6 = New Janus.Windows.UI.CommandBars.UICommand("mnuGestion")
      Me.mnuOpera2 = New Janus.Windows.UI.CommandBars.UICommand("mnuOpera")
      Me.mnuParametroSub5 = New Janus.Windows.UI.CommandBars.UICommand("mnuParametroSub")
      Me.mnuTipoCambio6 = New Janus.Windows.UI.CommandBars.UICommand("mnuTipoCambio")
      Me.mnuImpuesto5 = New Janus.Windows.UI.CommandBars.UICommand("mnuImpuesto")
      Me.mnuAyudaDinamica5 = New Janus.Windows.UI.CommandBars.UICommand("mnuAyudaDinamica")
      Me.mnuAboutBox6 = New Janus.Windows.UI.CommandBars.UICommand("mnuAboutBox")
      Me.mnuToolBar5 = New Janus.Windows.UI.CommandBars.UICommand("mnuToolBar")
      Me.mnuStatusBar5 = New Janus.Windows.UI.CommandBars.UICommand("mnuStatusBar")
      Me.mnuEmpresaPara6 = New Janus.Windows.UI.CommandBars.UICommand("mnuEmpresaPara")
      Me.mnuCompPara6 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompPara")
      Me.mnuCompParaMes5 = New Janus.Windows.UI.CommandBars.UICommand("mnuCompParaMes")
      Me.mnuReciboPara5 = New Janus.Windows.UI.CommandBars.UICommand("mnuReciboPara")
      Me.gexMain = New Janus.Windows.GridEX.Export.GridEXExporter(Me.components)
      Me.mnuProvincia = New Janus.Windows.UI.CommandBars.UICommand("mnuProvincia")
      Me.mnuProvincia1 = New Janus.Windows.UI.CommandBars.UICommand("mnuProvincia")
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.Menu1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.ToolSet1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TopRebar1.SuspendLayout()
      Me.SuspendLayout()
      '
      'cdmMain
      '
      Me.cdmMain.BottomRebar = Me.BottomRebar1
      Me.cdmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.Menu1, Me.ToolBar1, Me.ToolSet1})
      Me.cdmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuCatalogo, Me.mnuEmpresa2, Me.mnuPlan2, Me.mnuPlanAdd2, Me.mnuCentroCosto2, Me.mnuSucursal2, Me.mnuRegRUC2, Me.mnuBanco2, Me.mnuCheque2, Me.mnuCiudad2, Me.mnuTransaccion, Me.mnuComp2, Me.mnuLibroMayor2, Me.mnuLibroDiario, Me.mnuAjuste2, Me.mnuCierreCuenta2, Me.mnuCierreGestion2, Me.mnuReporte, Me.mnuBalance2, Me.mnuEstadoResultado2, Me.mnuSumaSaldo2, Me.mnuLibroIVA2, Me.mnuLibroBanco2, Me.mnuLibroITF2, Me.mnuLibroPlanAdd2, Me.mnuLibroSucursal2, Me.mnuLibroCentroCosto2, Me.mnuParametro2, Me.mnuEmpresaPara2, Me.mnuGestion2, Me.mnuCompPara2, Me.mnuTipoCambio2, Me.mnuAyuda2, Me.mnuAyudaDinamica, Me.mnuAboutBox2, Me.New2, Me.Separador, Me.Edit, Me.Delete, Me.ViewAll, Me.Print, Me.Exit2, Me.mnuVer, Me.mnuToolBar, Me.mnuStatusBar, Me.btnEmpresa, Me.btnPlan, Me.btnComp, Me.btnLibroMayor, Me.btnBalance, Me.btnEstadoResultado, Me.btnLibroIVA, Me.btnEmpresaPara, Me.btnTipoCambio, Me.mnuImpuesto, Me.btnExit, Me.btnUserPass, Me.btnHelp, Me.mnuParametroSub, Me.mnuReciboPara, Me.mnuRespaldo, Me.mnuRecibo, Me.btnHelpVideo, Me.mnuLibroAgruIVA, Me.mnuLibroPlanAddCuenta, Me.mnuLibroPlanAddAna, Me.mnuLibroDispo, Me.mnuFactura, Me.mnuFacturaCompra, Me.mnuFacturaVenta, Me.mnuPoliza, Me.mnuAduana, Me.mnuCompFecha, Me.mnuCompBloqueo, Me.mnuCompParaMes, Me.btnCalculadora, Me.mnuLibroCentroCostoMes, Me.mnuDosifica, Me.mnuCentroCostoDet, Me.mnuLibroCentroCostoDetMain, Me.mnuLibroCentroCostoDet, Me.mnuLibroCentroCostoDetAct, Me.btnExcel, Me.btnFilter, Me.btnSort, Me.mnuPais, Me.mnuDepartamento, Me.mnuDataBaseBackup, Me.mnuDataBaseImport, Me.mnuFlujoEfectivoDet, Me.mnuLabor, Me.mnuDataSecurityImport, Me.mnuLibroRetencion, Me.mnuTipoActEco, Me.mnuDosificaLey, Me.UiCommand1, Me.UiCommand3, Me.mnuWizard, Me.mnuLibroMayorDuo, Me.mnuLibroCheque, Me.mnuConciliaBanco, Me.mnuEstadoComparativo, Me.mnuBalanceComparativo, Me.mnuPlanEEFF, Me.mnuFlujoEfectivoFind, Me.mnuEstadoFlujoEfectivoFind, Me.mnuFlujoEfectivo, Me.mnuChequeOpen, Me.mnuEstadoResultadoCC, Me.mnuEstadoResultadoMenu, Me.mnuBalanceMenu, Me.mnuLibroMayorAnalisis, Me.mnuEstadoResultadoAct, Me.mnuLibroMayorDet, Me.mnuLibroMayorMenu, Me.mnuLibroIVACC, Me.mnuLibroCentroCostoDetActEmpresa, Me.mnuSumaSaldoGeneral, Me.mnuSumaSaldoAnalisis, Me.mnuSumaSaldoComparativo, Me.mnuLibroDispoGeneral, Me.mnuLibroDispoComparativo, Me.mnuLibroMayorComparativo, Me.mnuSumaSaldoComparativoCC, Me.mnuProvincia})
      Me.cdmMain.ContainerControl = Me
      Me.cdmMain.Id = New System.Guid("66f0864e-d3db-4555-a7cf-7cf347529f21")
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
      'Menu1
      '
      Me.Menu1.CommandBarType = Janus.Windows.UI.CommandBars.CommandBarType.Menu
      Me.Menu1.CommandManager = Me.cdmMain
      Me.Menu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuCatalogo1, Me.mnuTransaccion1, Me.mnuReporte1, Me.mnuParametro1, Me.mnuVer1, Me.mnuAyuda1})
      Me.Menu1.Key = "Menu"
      Me.Menu1.Location = New System.Drawing.Point(0, 0)
      Me.Menu1.Name = "Menu1"
      Me.Menu1.RowIndex = 0
      Me.Menu1.Size = New System.Drawing.Size(728, 26)
      Me.Menu1.Text = "Menu"
      '
      'mnuCatalogo1
      '
      Me.mnuCatalogo1.Key = "mnuCatalogo"
      Me.mnuCatalogo1.Name = "mnuCatalogo1"
      '
      'mnuTransaccion1
      '
      Me.mnuTransaccion1.Key = "mnuTransaccion"
      Me.mnuTransaccion1.Name = "mnuTransaccion1"
      '
      'mnuReporte1
      '
      Me.mnuReporte1.Key = "mnuReporte"
      Me.mnuReporte1.Name = "mnuReporte1"
      '
      'mnuParametro1
      '
      Me.mnuParametro1.Key = "mnuParametro"
      Me.mnuParametro1.Name = "mnuParametro1"
      '
      'mnuVer1
      '
      Me.mnuVer1.Key = "mnuVer"
      Me.mnuVer1.Name = "mnuVer1"
      '
      'mnuAyuda1
      '
      Me.mnuAyuda1.Key = "mnuAyuda"
      Me.mnuAyuda1.Name = "mnuAyuda1"
      '
      'ToolBar1
      '
      Me.ToolBar1.CommandManager = Me.cdmMain
      Me.ToolBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.btnEmpresa1, Me.Separator1, Me.btnPlan1, Me.Separator2, Me.btnComp1, Me.Separator7, Me.btnEmpresaPara1, Me.Separator8, Me.btnTipoCambio1, Me.Separator9, Me.btnUserPass1, Me.Separator10, Me.btnCalculadora1, Me.Separator15, Me.btnHelp1, Me.Separator11, Me.btnHelpVideo1, Me.Separator12, Me.btnExit1})
      Me.ToolBar1.Key = "ToolBar"
      Me.ToolBar1.Location = New System.Drawing.Point(104, 26)
      Me.ToolBar1.Name = "ToolBar1"
      Me.ToolBar1.RowIndex = 1
      Me.ToolBar1.Size = New System.Drawing.Size(307, 28)
      Me.ToolBar1.Text = "ToolBar"
      '
      'btnEmpresa1
      '
      Me.btnEmpresa1.ImageIndex = 3
      Me.btnEmpresa1.Key = "btnEmpresa"
      Me.btnEmpresa1.Name = "btnEmpresa1"
      Me.btnEmpresa1.ToolTipText = "Empresas"
      '
      'Separator1
      '
      Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator1.Key = "Separator"
      Me.Separator1.Name = "Separator1"
      '
      'btnPlan1
      '
      Me.btnPlan1.Key = "btnPlan"
      Me.btnPlan1.Name = "btnPlan1"
      '
      'Separator2
      '
      Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator2.Key = "Separator"
      Me.Separator2.Name = "Separator2"
      '
      'btnComp1
      '
      Me.btnComp1.Key = "btnComp"
      Me.btnComp1.Name = "btnComp1"
      '
      'Separator7
      '
      Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator7.Key = "Separator"
      Me.Separator7.Name = "Separator7"
      '
      'btnEmpresaPara1
      '
      Me.btnEmpresaPara1.Key = "btnEmpresaPara"
      Me.btnEmpresaPara1.Name = "btnEmpresaPara1"
      '
      'Separator8
      '
      Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator8.Key = "Separator"
      Me.Separator8.Name = "Separator8"
      '
      'btnTipoCambio1
      '
      Me.btnTipoCambio1.Key = "btnTipoCambio"
      Me.btnTipoCambio1.Name = "btnTipoCambio1"
      '
      'Separator9
      '
      Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator9.Key = "Separator"
      Me.Separator9.Name = "Separator9"
      '
      'btnUserPass1
      '
      Me.btnUserPass1.Key = "btnUserPass"
      Me.btnUserPass1.Name = "btnUserPass1"
      '
      'Separator10
      '
      Me.Separator10.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator10.Key = "Separator"
      Me.Separator10.Name = "Separator10"
      '
      'btnCalculadora1
      '
      Me.btnCalculadora1.Key = "btnCalculadora"
      Me.btnCalculadora1.Name = "btnCalculadora1"
      '
      'Separator15
      '
      Me.Separator15.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator15.Key = "Separator"
      Me.Separator15.Name = "Separator15"
      '
      'btnHelp1
      '
      Me.btnHelp1.Key = "btnHelp"
      Me.btnHelp1.Name = "btnHelp1"
      '
      'Separator11
      '
      Me.Separator11.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator11.Key = "Separator"
      Me.Separator11.Name = "Separator11"
      '
      'btnHelpVideo1
      '
      Me.btnHelpVideo1.Key = "btnHelpVideo"
      Me.btnHelpVideo1.Name = "btnHelpVideo1"
      '
      'Separator12
      '
      Me.Separator12.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator12.Key = "Separator"
      Me.Separator12.Name = "Separator12"
      '
      'btnExit1
      '
      Me.btnExit1.Key = "btnExit"
      Me.btnExit1.Name = "btnExit1"
      '
      'ToolSet1
      '
      Me.ToolSet1.CommandManager = Me.cdmMain
      Me.ToolSet1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.btnExcel1, Me.Separator26, Me.btnFilter1, Me.Separator27, Me.btnSort1})
      Me.ToolSet1.Key = "ToolSet"
      Me.ToolSet1.Location = New System.Drawing.Point(0, 26)
      Me.ToolSet1.Name = "ToolSet1"
      Me.ToolSet1.RowIndex = 1
      Me.ToolSet1.Size = New System.Drawing.Size(104, 28)
      Me.ToolSet1.Text = "ToolSet"
      '
      'btnExcel1
      '
      Me.btnExcel1.Key = "btnExcel"
      Me.btnExcel1.Name = "btnExcel1"
      '
      'Separator26
      '
      Me.Separator26.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator26.Key = "Separator"
      Me.Separator26.Name = "Separator26"
      '
      'btnFilter1
      '
      Me.btnFilter1.Key = "btnFilter"
      Me.btnFilter1.Name = "btnFilter1"
      '
      'Separator27
      '
      Me.Separator27.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator27.Key = "Separator"
      Me.Separator27.Name = "Separator27"
      '
      'btnSort1
      '
      Me.btnSort1.Key = "btnSort"
      Me.btnSort1.Name = "btnSort1"
      '
      'mnuCatalogo
      '
      Me.mnuCatalogo.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuEmpresa7, Me.mnuSucursal7, Me.Separator55, Me.mnuPlan7, Me.mnuPlanAdd7, Me.mnuPlanEEFF1, Me.Separator56, Me.mnuCentroCosto7, Me.mnuCentroCostoDet3, Me.Separator57, Me.mnuBanco7, Me.mnuCheque7, Me.Separator58, Me.mnuDosifica6, Me.mnuTipoActEco1, Me.mnuDosificaLey1, Me.mnuRegRUC7, Me.mnuAduana6, Me.Separator59, Me.mnuPais1, Me.mnuDepartamento1, Me.mnuProvincia1, Me.mnuCiudad7, Me.mnuRespaldo6})
      Me.mnuCatalogo.Key = "mnuCatalogo"
      Me.mnuCatalogo.Name = "mnuCatalogo"
      Me.mnuCatalogo.Tag = "mnuCatalogo"
      Me.mnuCatalogo.Text = "&Catálogos"
      '
      'mnuEmpresa7
      '
      Me.mnuEmpresa7.Key = "mnuEmpresa"
      Me.mnuEmpresa7.Name = "mnuEmpresa7"
      '
      'mnuSucursal7
      '
      Me.mnuSucursal7.Key = "mnuSucursal"
      Me.mnuSucursal7.Name = "mnuSucursal7"
      '
      'Separator55
      '
      Me.Separator55.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator55.Key = "Separator"
      Me.Separator55.Name = "Separator55"
      '
      'mnuPlan7
      '
      Me.mnuPlan7.Key = "mnuPlan"
      Me.mnuPlan7.Name = "mnuPlan7"
      '
      'mnuPlanAdd7
      '
      Me.mnuPlanAdd7.Key = "mnuPlanAdd"
      Me.mnuPlanAdd7.Name = "mnuPlanAdd7"
      '
      'mnuPlanEEFF1
      '
      Me.mnuPlanEEFF1.Key = "mnuPlanEEFF"
      Me.mnuPlanEEFF1.Name = "mnuPlanEEFF1"
      '
      'Separator56
      '
      Me.Separator56.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator56.Key = "Separator"
      Me.Separator56.Name = "Separator56"
      '
      'mnuCentroCosto7
      '
      Me.mnuCentroCosto7.Key = "mnuCentroCosto"
      Me.mnuCentroCosto7.Name = "mnuCentroCosto7"
      '
      'mnuCentroCostoDet3
      '
      Me.mnuCentroCostoDet3.Key = "mnuCentroCostoDet"
      Me.mnuCentroCostoDet3.Name = "mnuCentroCostoDet3"
      '
      'Separator57
      '
      Me.Separator57.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator57.Key = "Separator"
      Me.Separator57.Name = "Separator57"
      '
      'mnuBanco7
      '
      Me.mnuBanco7.Key = "mnuBanco"
      Me.mnuBanco7.Name = "mnuBanco7"
      '
      'mnuCheque7
      '
      Me.mnuCheque7.Key = "mnuCheque"
      Me.mnuCheque7.Name = "mnuCheque7"
      '
      'Separator58
      '
      Me.Separator58.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator58.Key = "Separator"
      Me.Separator58.Name = "Separator58"
      '
      'mnuDosifica6
      '
      Me.mnuDosifica6.Key = "mnuDosifica"
      Me.mnuDosifica6.Name = "mnuDosifica6"
      '
      'mnuTipoActEco1
      '
      Me.mnuTipoActEco1.Key = "mnuTipoActEco"
      Me.mnuTipoActEco1.Name = "mnuTipoActEco1"
      '
      'mnuDosificaLey1
      '
      Me.mnuDosificaLey1.Key = "mnuDosificaLey"
      Me.mnuDosificaLey1.Name = "mnuDosificaLey1"
      '
      'mnuRegRUC7
      '
      Me.mnuRegRUC7.Key = "mnuRegRUC"
      Me.mnuRegRUC7.Name = "mnuRegRUC7"
      '
      'mnuAduana6
      '
      Me.mnuAduana6.Key = "mnuAduana"
      Me.mnuAduana6.Name = "mnuAduana6"
      '
      'Separator59
      '
      Me.Separator59.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator59.Key = "Separator"
      Me.Separator59.Name = "Separator59"
      '
      'mnuPais1
      '
      Me.mnuPais1.Key = "mnuPais"
      Me.mnuPais1.Name = "mnuPais1"
      '
      'mnuDepartamento1
      '
      Me.mnuDepartamento1.Key = "mnuDepartamento"
      Me.mnuDepartamento1.Name = "mnuDepartamento1"
      '
      'mnuCiudad7
      '
      Me.mnuCiudad7.Key = "mnuCiudad"
      Me.mnuCiudad7.Name = "mnuCiudad7"
      '
      'mnuRespaldo6
      '
      Me.mnuRespaldo6.Key = "mnuRespaldo"
      Me.mnuRespaldo6.Name = "mnuRespaldo6"
      '
      'mnuEmpresa2
      '
      Me.mnuEmpresa2.Key = "mnuEmpresa"
      Me.mnuEmpresa2.Name = "mnuEmpresa2"
      Me.mnuEmpresa2.Tag = "mnuEmpresa"
      Me.mnuEmpresa2.Text = "Empresas"
      '
      'mnuPlan2
      '
      Me.mnuPlan2.Key = "mnuPlan"
      Me.mnuPlan2.Name = "mnuPlan2"
      Me.mnuPlan2.Text = "Plan de Cuentas "
      '
      'mnuPlanAdd2
      '
      Me.mnuPlanAdd2.Key = "mnuPlanAdd"
      Me.mnuPlanAdd2.Name = "mnuPlanAdd2"
      Me.mnuPlanAdd2.Text = "Analíticos Adicionales"
      '
      'mnuCentroCosto2
      '
      Me.mnuCentroCosto2.Key = "mnuCentroCosto"
      Me.mnuCentroCosto2.Name = "mnuCentroCosto2"
      Me.mnuCentroCosto2.Text = "Centros de Costo"
      '
      'mnuSucursal2
      '
      Me.mnuSucursal2.Key = "mnuSucursal"
      Me.mnuSucursal2.Name = "mnuSucursal2"
      Me.mnuSucursal2.Text = "Sucursales"
      '
      'mnuRegRUC2
      '
      Me.mnuRegRUC2.Key = "mnuRegRUC"
      Me.mnuRegRUC2.Name = "mnuRegRUC2"
      Me.mnuRegRUC2.Text = "Catálogo de NIT"
      '
      'mnuBanco2
      '
      Me.mnuBanco2.Key = "mnuBanco"
      Me.mnuBanco2.Name = "mnuBanco2"
      Me.mnuBanco2.Text = "Bancos"
      '
      'mnuCheque2
      '
      Me.mnuCheque2.Key = "mnuCheque"
      Me.mnuCheque2.Name = "mnuCheque2"
      Me.mnuCheque2.Text = "Chequeras"
      '
      'mnuCiudad2
      '
      Me.mnuCiudad2.Key = "mnuCiudad"
      Me.mnuCiudad2.Name = "mnuCiudad2"
      Me.mnuCiudad2.Text = "Ciudades"
      '
      'mnuTransaccion
      '
      Me.mnuTransaccion.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuComp7, Me.mnuCompBloqueo6, Me.Separator60, Me.mnuPoliza6, Me.mnuRecibo6, Me.Separator66, Me.mnuChequeOpen1, Me.Separator62, Me.mnuAjuste7, Me.mnuCierreCuenta7, Me.mnuCierreGestion7})
      Me.mnuTransaccion.Key = "mnuTransaccion"
      Me.mnuTransaccion.Name = "mnuTransaccion"
      Me.mnuTransaccion.Text = "&Transacciones"
      '
      'mnuComp7
      '
      Me.mnuComp7.Key = "mnuComp"
      Me.mnuComp7.Name = "mnuComp7"
      '
      'mnuCompBloqueo6
      '
      Me.mnuCompBloqueo6.Key = "mnuCompBloqueo"
      Me.mnuCompBloqueo6.Name = "mnuCompBloqueo6"
      '
      'Separator60
      '
      Me.Separator60.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator60.Key = "Separator"
      Me.Separator60.Name = "Separator60"
      '
      'mnuPoliza6
      '
      Me.mnuPoliza6.Key = "mnuPoliza"
      Me.mnuPoliza6.Name = "mnuPoliza6"
      '
      'mnuRecibo6
      '
      Me.mnuRecibo6.Key = "mnuRecibo"
      Me.mnuRecibo6.Name = "mnuRecibo6"
      '
      'Separator66
      '
      Me.Separator66.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator66.Key = "Separator"
      Me.Separator66.Name = "Separator66"
      '
      'mnuChequeOpen1
      '
      Me.mnuChequeOpen1.Key = "mnuChequeOpen"
      Me.mnuChequeOpen1.Name = "mnuChequeOpen1"
      '
      'Separator62
      '
      Me.Separator62.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator62.Key = "Separator"
      Me.Separator62.Name = "Separator62"
      '
      'mnuAjuste7
      '
      Me.mnuAjuste7.Key = "mnuAjuste"
      Me.mnuAjuste7.Name = "mnuAjuste7"
      '
      'mnuCierreCuenta7
      '
      Me.mnuCierreCuenta7.Key = "mnuCierreCuenta"
      Me.mnuCierreCuenta7.Name = "mnuCierreCuenta7"
      '
      'mnuCierreGestion7
      '
      Me.mnuCierreGestion7.Key = "mnuCierreGestion"
      Me.mnuCierreGestion7.Name = "mnuCierreGestion7"
      '
      'mnuComp2
      '
      Me.mnuComp2.Key = "mnuComp"
      Me.mnuComp2.Name = "mnuComp2"
      Me.mnuComp2.Text = "Registro de Comprobantes"
      '
      'mnuLibroMayor2
      '
      Me.mnuLibroMayor2.Key = "mnuLibroMayor"
      Me.mnuLibroMayor2.Name = "mnuLibroMayor2"
      Me.mnuLibroMayor2.Text = "Libro Mayor General"
      '
      'mnuLibroDiario
      '
      Me.mnuLibroDiario.Key = "mnuLibroDiario"
      Me.mnuLibroDiario.Name = "mnuLibroDiario"
      Me.mnuLibroDiario.Text = "Libro Diario"
      '
      'mnuAjuste2
      '
      Me.mnuAjuste2.Key = "mnuAjuste"
      Me.mnuAjuste2.Name = "mnuAjuste2"
      Me.mnuAjuste2.Text = "Ajuste Monetario"
      '
      'mnuCierreCuenta2
      '
      Me.mnuCierreCuenta2.Key = "mnuCierreCuenta"
      Me.mnuCierreCuenta2.Name = "mnuCierreCuenta2"
      Me.mnuCierreCuenta2.Text = "Cierre Cuentas de Resultado"
      '
      'mnuCierreGestion2
      '
      Me.mnuCierreGestion2.Key = "mnuCierreGestion"
      Me.mnuCierreGestion2.Name = "mnuCierreGestion2"
      Me.mnuCierreGestion2.Text = "Cierre de Gestión"
      '
      'mnuReporte
      '
      Me.mnuReporte.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuBalanceMenu1, Me.mnuEstadoResultadoMenu1, Me.mnuSumaSaldo7, Me.mnuLibroMayorMenu1, Me.mnuLibroDiario5, Me.mnuCompFecha6, Me.Separator61, Me.mnuLibroIVA7, Me.mnuLibroAgruIVA6, Me.mnuLibroRetencion1, Me.Separator29, Me.mnuLibroBanco7, Me.mnuLibroCheque1, Me.mnuConciliaBanco1, Me.mnuLibroITF7, Me.mnuLibroDispo6, Me.mnuFlujoEfectivoDet1, Me.Separator64, Me.mnuLibroPlanAdd7, Me.mnuLibroCentroCosto7, Me.mnuLibroCentroCostoMes3, Me.mnuLibroCentroCostoMain1, Me.mnuLibroSucursal7, Me.Separator63, Me.mnuFlujoEfectivo1})
      Me.mnuReporte.Key = "mnuReporte"
      Me.mnuReporte.Name = "mnuReporte"
      Me.mnuReporte.Text = "&Reportes"
      '
      'mnuBalanceMenu1
      '
      Me.mnuBalanceMenu1.Key = "mnuBalanceMenu"
      Me.mnuBalanceMenu1.Name = "mnuBalanceMenu1"
      '
      'mnuEstadoResultadoMenu1
      '
      Me.mnuEstadoResultadoMenu1.Key = "mnuEstadoResultadoMenu"
      Me.mnuEstadoResultadoMenu1.Name = "mnuEstadoResultadoMenu1"
      '
      'mnuSumaSaldo7
      '
      Me.mnuSumaSaldo7.Key = "mnuSumaSaldo"
      Me.mnuSumaSaldo7.Name = "mnuSumaSaldo7"
      '
      'mnuLibroMayorMenu1
      '
      Me.mnuLibroMayorMenu1.Key = "mnuLibroMayorMenu"
      Me.mnuLibroMayorMenu1.Name = "mnuLibroMayorMenu1"
      '
      'mnuLibroDiario5
      '
      Me.mnuLibroDiario5.Key = "mnuLibroDiario"
      Me.mnuLibroDiario5.Name = "mnuLibroDiario5"
      '
      'mnuCompFecha6
      '
      Me.mnuCompFecha6.Key = "mnuCompFecha"
      Me.mnuCompFecha6.Name = "mnuCompFecha6"
      Me.mnuCompFecha6.Text = "Listado de Comprobantes"
      '
      'Separator61
      '
      Me.Separator61.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator61.Key = "Separator"
      Me.Separator61.Name = "Separator61"
      '
      'mnuLibroIVA7
      '
      Me.mnuLibroIVA7.Key = "mnuLibroIVA"
      Me.mnuLibroIVA7.Name = "mnuLibroIVA7"
      '
      'mnuLibroAgruIVA6
      '
      Me.mnuLibroAgruIVA6.Key = "mnuLibroAgruIVA"
      Me.mnuLibroAgruIVA6.Name = "mnuLibroAgruIVA6"
      '
      'mnuLibroRetencion1
      '
      Me.mnuLibroRetencion1.Key = "mnuLibroRetencion"
      Me.mnuLibroRetencion1.Name = "mnuLibroRetencion1"
      '
      'Separator29
      '
      Me.Separator29.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator29.Key = "Separator"
      Me.Separator29.Name = "Separator29"
      '
      'mnuLibroBanco7
      '
      Me.mnuLibroBanco7.Key = "mnuLibroBanco"
      Me.mnuLibroBanco7.Name = "mnuLibroBanco7"
      '
      'mnuLibroCheque1
      '
      Me.mnuLibroCheque1.Key = "mnuLibroCheque"
      Me.mnuLibroCheque1.Name = "mnuLibroCheque1"
      '
      'mnuConciliaBanco1
      '
      Me.mnuConciliaBanco1.Key = "mnuConciliaBanco"
      Me.mnuConciliaBanco1.Name = "mnuConciliaBanco1"
      '
      'mnuLibroITF7
      '
      Me.mnuLibroITF7.Key = "mnuLibroITF"
      Me.mnuLibroITF7.Name = "mnuLibroITF7"
      '
      'mnuLibroDispo6
      '
      Me.mnuLibroDispo6.Key = "mnuLibroDispo"
      Me.mnuLibroDispo6.Name = "mnuLibroDispo6"
      '
      'mnuFlujoEfectivoDet1
      '
      Me.mnuFlujoEfectivoDet1.Key = "mnuFlujoEfectivoDet"
      Me.mnuFlujoEfectivoDet1.Name = "mnuFlujoEfectivoDet1"
      '
      'Separator64
      '
      Me.Separator64.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator64.Key = "Separator"
      Me.Separator64.Name = "Separator64"
      '
      'mnuLibroPlanAdd7
      '
      Me.mnuLibroPlanAdd7.Key = "mnuLibroPlanAdd"
      Me.mnuLibroPlanAdd7.Name = "mnuLibroPlanAdd7"
      '
      'mnuLibroCentroCosto7
      '
      Me.mnuLibroCentroCosto7.Key = "mnuLibroCentroCosto"
      Me.mnuLibroCentroCosto7.Name = "mnuLibroCentroCosto7"
      '
      'mnuLibroCentroCostoMes3
      '
      Me.mnuLibroCentroCostoMes3.Key = "mnuLibroCentroCostoMes"
      Me.mnuLibroCentroCostoMes3.Name = "mnuLibroCentroCostoMes3"
      '
      'mnuLibroCentroCostoMain1
      '
      Me.mnuLibroCentroCostoMain1.Key = "mnuLibroCentroCostoDetMain"
      Me.mnuLibroCentroCostoMain1.Name = "mnuLibroCentroCostoMain1"
      '
      'mnuLibroSucursal7
      '
      Me.mnuLibroSucursal7.Key = "mnuLibroSucursal"
      Me.mnuLibroSucursal7.Name = "mnuLibroSucursal7"
      '
      'Separator63
      '
      Me.Separator63.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator63.Key = "Separator"
      Me.Separator63.Name = "Separator63"
      '
      'mnuFlujoEfectivo1
      '
      Me.mnuFlujoEfectivo1.Key = "mnuFlujoEfectivo"
      Me.mnuFlujoEfectivo1.Name = "mnuFlujoEfectivo1"
      '
      'mnuBalance2
      '
      Me.mnuBalance2.Key = "mnuBalance"
      Me.mnuBalance2.Name = "mnuBalance2"
      Me.mnuBalance2.Text = "General"
      '
      'mnuEstadoResultado2
      '
      Me.mnuEstadoResultado2.Key = "mnuEstadoResultadoGeneral"
      Me.mnuEstadoResultado2.Name = "mnuEstadoResultado2"
      Me.mnuEstadoResultado2.Text = "General"
      '
      'mnuSumaSaldo2
      '
      Me.mnuSumaSaldo2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuSumaSaldoGeneral1, Me.mnuSumaSaldoComparativoCC1, Me.mnuSumaSaldoComparativo1, Me.mnuSumaSaldoAnalisis1})
      Me.mnuSumaSaldo2.Key = "mnuSumaSaldo"
      Me.mnuSumaSaldo2.Name = "mnuSumaSaldo2"
      Me.mnuSumaSaldo2.Text = "Balance de Sumas y Saldos"
      '
      'mnuSumaSaldoGeneral1
      '
      Me.mnuSumaSaldoGeneral1.Key = "mnuSumaSaldoGeneral"
      Me.mnuSumaSaldoGeneral1.Name = "mnuSumaSaldoGeneral1"
      '
      'mnuSumaSaldoComparativoCC1
      '
      Me.mnuSumaSaldoComparativoCC1.Key = "mnuSumaSaldoComparativoCC"
      Me.mnuSumaSaldoComparativoCC1.Name = "mnuSumaSaldoComparativoCC1"
      '
      'mnuSumaSaldoComparativo1
      '
      Me.mnuSumaSaldoComparativo1.Key = "mnuSumaSaldoComparativo"
      Me.mnuSumaSaldoComparativo1.Name = "mnuSumaSaldoComparativo1"
      '
      'mnuSumaSaldoAnalisis1
      '
      Me.mnuSumaSaldoAnalisis1.Key = "mnuSumaSaldoAnalisis"
      Me.mnuSumaSaldoAnalisis1.Name = "mnuSumaSaldoAnalisis1"
      '
      'mnuLibroIVA2
      '
      Me.mnuLibroIVA2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.UiCommand2, Me.UiCommand4, Me.mnuLibroIVACC1})
      Me.mnuLibroIVA2.Key = "mnuLibroIVA"
      Me.mnuLibroIVA2.Name = "mnuLibroIVA2"
      Me.mnuLibroIVA2.Text = "Libros IVA"
      '
      'UiCommand2
      '
      Me.UiCommand2.Key = "mnuLibroIVA-NSF"
      Me.UiCommand2.Name = "UiCommand2"
      '
      'UiCommand4
      '
      Me.UiCommand4.Key = "mnuLibroIVA-SFV"
      Me.UiCommand4.Name = "UiCommand4"
      '
      'mnuLibroIVACC1
      '
      Me.mnuLibroIVACC1.Key = "mnuLibroIVACC"
      Me.mnuLibroIVACC1.Name = "mnuLibroIVACC1"
      '
      'mnuLibroBanco2
      '
      Me.mnuLibroBanco2.Key = "mnuLibroBanco"
      Me.mnuLibroBanco2.Name = "mnuLibroBanco2"
      Me.mnuLibroBanco2.Text = "Libro de Bancos"
      '
      'mnuLibroITF2
      '
      Me.mnuLibroITF2.Key = "mnuLibroITF"
      Me.mnuLibroITF2.Name = "mnuLibroITF2"
      Me.mnuLibroITF2.Text = "Movimiento de ITF"
      '
      'mnuLibroPlanAdd2
      '
      Me.mnuLibroPlanAdd2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuLibroPlanAddCuenta6, Me.mnuLibroPlanAddAna6})
      Me.mnuLibroPlanAdd2.Key = "mnuLibroPlanAdd"
      Me.mnuLibroPlanAdd2.Name = "mnuLibroPlanAdd2"
      Me.mnuLibroPlanAdd2.Text = "Movimiento de Analíticos Adicionales"
      '
      'mnuLibroPlanAddCuenta6
      '
      Me.mnuLibroPlanAddCuenta6.Key = "mnuLibroPlanAddCuenta"
      Me.mnuLibroPlanAddCuenta6.Name = "mnuLibroPlanAddCuenta6"
      '
      'mnuLibroPlanAddAna6
      '
      Me.mnuLibroPlanAddAna6.Key = "mnuLibroPlanAddAna"
      Me.mnuLibroPlanAddAna6.Name = "mnuLibroPlanAddAna6"
      '
      'mnuLibroSucursal2
      '
      Me.mnuLibroSucursal2.Key = "mnuLibroSucursal"
      Me.mnuLibroSucursal2.Name = "mnuLibroSucursal2"
      Me.mnuLibroSucursal2.Text = "Movimiento de Sucursales"
      '
      'mnuLibroCentroCosto2
      '
      Me.mnuLibroCentroCosto2.Key = "mnuLibroCentroCosto"
      Me.mnuLibroCentroCosto2.Name = "mnuLibroCentroCosto2"
      Me.mnuLibroCentroCosto2.Text = "Movimiento de Centros de Costo"
      '
      'mnuParametro2
      '
      Me.mnuParametro2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuGestion7, Me.mnuParametroSub6, Me.mnuTipoCambio7, Me.mnuImpuesto6, Me.mnuWizard1, Me.Separator28, Me.mnuDataBaseBackup1, Me.mnuDataBaseImport1, Me.mnuDataSecurityImport1})
      Me.mnuParametro2.Key = "mnuParametro"
      Me.mnuParametro2.Name = "mnuParametro2"
      Me.mnuParametro2.Text = "&Parámetros"
      '
      'mnuGestion7
      '
      Me.mnuGestion7.Key = "mnuGestion"
      Me.mnuGestion7.Name = "mnuGestion7"
      '
      'mnuParametroSub6
      '
      Me.mnuParametroSub6.Key = "mnuParametroSub"
      Me.mnuParametroSub6.Name = "mnuParametroSub6"
      '
      'mnuTipoCambio7
      '
      Me.mnuTipoCambio7.Key = "mnuTipoCambio"
      Me.mnuTipoCambio7.Name = "mnuTipoCambio7"
      '
      'mnuImpuesto6
      '
      Me.mnuImpuesto6.Key = "mnuImpuesto"
      Me.mnuImpuesto6.Name = "mnuImpuesto6"
      '
      'mnuWizard1
      '
      Me.mnuWizard1.Key = "mnuWizard"
      Me.mnuWizard1.Name = "mnuWizard1"
      '
      'Separator28
      '
      Me.Separator28.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator28.Key = "Separator"
      Me.Separator28.Name = "Separator28"
      '
      'mnuDataBaseBackup1
      '
      Me.mnuDataBaseBackup1.Key = "mnuDataBaseBackup"
      Me.mnuDataBaseBackup1.Name = "mnuDataBaseBackup1"
      '
      'mnuDataBaseImport1
      '
      Me.mnuDataBaseImport1.Key = "mnuDataBaseImport"
      Me.mnuDataBaseImport1.Name = "mnuDataBaseImport1"
      '
      'mnuDataSecurityImport1
      '
      Me.mnuDataSecurityImport1.Key = "mnuDataSecurityImport"
      Me.mnuDataSecurityImport1.Name = "mnuDataSecurityImport1"
      '
      'mnuEmpresaPara2
      '
      Me.mnuEmpresaPara2.Key = "mnuEmpresaPara"
      Me.mnuEmpresaPara2.Name = "mnuEmpresaPara2"
      Me.mnuEmpresaPara2.Text = "Empresas"
      '
      'mnuGestion2
      '
      Me.mnuGestion2.Key = "mnuGestion"
      Me.mnuGestion2.Name = "mnuGestion2"
      Me.mnuGestion2.Text = "Gestiones"
      '
      'mnuCompPara2
      '
      Me.mnuCompPara2.Key = "mnuCompPara"
      Me.mnuCompPara2.Name = "mnuCompPara2"
      Me.mnuCompPara2.Text = "Comprobantes"
      '
      'mnuTipoCambio2
      '
      Me.mnuTipoCambio2.Key = "mnuTipoCambio"
      Me.mnuTipoCambio2.Name = "mnuTipoCambio2"
      Me.mnuTipoCambio2.Text = "Tipos de Cambio"
      '
      'mnuAyuda2
      '
      Me.mnuAyuda2.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuAyudaDinamica6, Me.mnuAboutBox7})
      Me.mnuAyuda2.Key = "mnuAyuda"
      Me.mnuAyuda2.Name = "mnuAyuda2"
      Me.mnuAyuda2.Text = "&Ayuda"
      '
      'mnuAyudaDinamica6
      '
      Me.mnuAyudaDinamica6.Key = "mnuAyudaDinamica"
      Me.mnuAyudaDinamica6.Name = "mnuAyudaDinamica6"
      '
      'mnuAboutBox7
      '
      Me.mnuAboutBox7.Key = "mnuAboutBox"
      Me.mnuAboutBox7.Name = "mnuAboutBox7"
      '
      'mnuAyudaDinamica
      '
      Me.mnuAyudaDinamica.Key = "mnuAyudaDinamica"
      Me.mnuAyudaDinamica.Name = "mnuAyudaDinamica"
      Me.mnuAyudaDinamica.Text = "Ayuda Dinámica"
      '
      'mnuAboutBox2
      '
      Me.mnuAboutBox2.Key = "mnuAboutBox"
      Me.mnuAboutBox2.Name = "mnuAboutBox2"
      Me.mnuAboutBox2.Text = "Acerca de ..."
      '
      'New2
      '
      Me.New2.ImageIndex = 4
      Me.New2.Key = "New"
      Me.New2.Name = "New2"
      Me.New2.Text = "Nuevo"
      '
      'Separador
      '
      Me.Separador.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separador.Key = "Separador"
      Me.Separador.Name = "Separador"
      '
      'Edit
      '
      Me.Edit.ImageIndex = 2
      Me.Edit.Key = "Edit"
      Me.Edit.Name = "Edit"
      Me.Edit.Text = "Editar"
      '
      'Delete
      '
      Me.Delete.ImageIndex = 3
      Me.Delete.Key = "Delete"
      Me.Delete.Name = "Delete"
      Me.Delete.Text = "Eliminar"
      '
      'ViewAll
      '
      Me.ViewAll.ImageIndex = 1
      Me.ViewAll.Key = "ViewAll"
      Me.ViewAll.Name = "ViewAll"
      Me.ViewAll.Text = "Ver Todos"
      '
      'Print
      '
      Me.Print.ImageIndex = 0
      Me.Print.Key = "Print"
      Me.Print.Name = "Print"
      Me.Print.Text = "Imprimir"
      '
      'Exit2
      '
      Me.Exit2.ImageIndex = 5
      Me.Exit2.Key = "Exit"
      Me.Exit2.Name = "Exit2"
      Me.Exit2.Text = "Salir"
      '
      'mnuVer
      '
      Me.mnuVer.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuToolBar6, Me.mnuStatusBar6})
      Me.mnuVer.Key = "mnuVer"
      Me.mnuVer.Name = "mnuVer"
      Me.mnuVer.Text = "&Ver"
      '
      'mnuToolBar6
      '
      Me.mnuToolBar6.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuToolBar6.Key = "mnuToolBar"
      Me.mnuToolBar6.Name = "mnuToolBar6"
      '
      'mnuStatusBar6
      '
      Me.mnuStatusBar6.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuStatusBar6.Key = "mnuStatusBar"
      Me.mnuStatusBar6.Name = "mnuStatusBar6"
      '
      'mnuToolBar
      '
      Me.mnuToolBar.Key = "mnuToolBar"
      Me.mnuToolBar.Name = "mnuToolBar"
      Me.mnuToolBar.Text = "Barra de Herramientas"
      '
      'mnuStatusBar
      '
      Me.mnuStatusBar.Key = "mnuStatusBar"
      Me.mnuStatusBar.Name = "mnuStatusBar"
      Me.mnuStatusBar.Text = "Barra de Estado"
      '
      'btnEmpresa
      '
      Me.btnEmpresa.ImageIndex = 3
      Me.btnEmpresa.Key = "btnEmpresa"
      Me.btnEmpresa.Name = "btnEmpresa"
      Me.btnEmpresa.ToolTipText = "Empresas"
      '
      'btnPlan
      '
      Me.btnPlan.ImageIndex = 4
      Me.btnPlan.Key = "btnPlan"
      Me.btnPlan.Name = "btnPlan"
      Me.btnPlan.ToolTipText = "Plan de Cuentas"
      '
      'btnComp
      '
      Me.btnComp.ImageIndex = 5
      Me.btnComp.Key = "btnComp"
      Me.btnComp.Name = "btnComp"
      Me.btnComp.ToolTipText = "Registro de Comprobantes"
      '
      'btnLibroMayor
      '
      Me.btnLibroMayor.ImageIndex = 3
      Me.btnLibroMayor.Key = "btnLibroMayor"
      Me.btnLibroMayor.Name = "btnLibroMayor"
      Me.btnLibroMayor.ToolTipText = "Libro Mayor"
      '
      'btnBalance
      '
      Me.btnBalance.ImageIndex = 4
      Me.btnBalance.Key = "btnBalance"
      Me.btnBalance.Name = "btnBalance"
      Me.btnBalance.ToolTipText = "Balance General"
      '
      'btnEstadoResultado
      '
      Me.btnEstadoResultado.ImageIndex = 5
      Me.btnEstadoResultado.Key = "btnEstadoResultado"
      Me.btnEstadoResultado.Name = "btnEstadoResultado"
      Me.btnEstadoResultado.ToolTipText = "Estado de Resultados"
      '
      'btnLibroIVA
      '
      Me.btnLibroIVA.ImageIndex = 6
      Me.btnLibroIVA.Key = "btnLibroIVA"
      Me.btnLibroIVA.Name = "btnLibroIVA"
      Me.btnLibroIVA.ToolTipText = "Libros IVA"
      '
      'btnEmpresaPara
      '
      Me.btnEmpresaPara.ImageIndex = 6
      Me.btnEmpresaPara.Key = "btnEmpresaPara"
      Me.btnEmpresaPara.Name = "btnEmpresaPara"
      Me.btnEmpresaPara.ToolTipText = "Parametros de la Empresa"
      '
      'btnTipoCambio
      '
      Me.btnTipoCambio.ImageIndex = 7
      Me.btnTipoCambio.Key = "btnTipoCambio"
      Me.btnTipoCambio.Name = "btnTipoCambio"
      Me.btnTipoCambio.ToolTipText = "Tipos de Cambio"
      '
      'mnuImpuesto
      '
      Me.mnuImpuesto.Key = "mnuImpuesto"
      Me.mnuImpuesto.Name = "mnuImpuesto"
      Me.mnuImpuesto.Text = "Impuestos"
      '
      'btnExit
      '
      Me.btnExit.ImageIndex = 12
      Me.btnExit.Key = "btnExit"
      Me.btnExit.Name = "btnExit"
      Me.btnExit.ToolTipText = "Salir del Sistema"
      '
      'btnUserPass
      '
      Me.btnUserPass.ImageIndex = 8
      Me.btnUserPass.Key = "btnUserPass"
      Me.btnUserPass.Name = "btnUserPass"
      Me.btnUserPass.ToolTipText = "Contraseña de Usuario"
      '
      'btnHelp
      '
      Me.btnHelp.ImageIndex = 10
      Me.btnHelp.Key = "btnHelp"
      Me.btnHelp.Name = "btnHelp"
      Me.btnHelp.ToolTipText = "Ayuda Dinámica"
      '
      'mnuParametroSub
      '
      Me.mnuParametroSub.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuEmpresaPara7, Me.mnuCompPara7, Me.mnuCompParaMes6, Me.mnuReciboPara6})
      Me.mnuParametroSub.Key = "mnuParametroSub"
      Me.mnuParametroSub.Name = "mnuParametroSub"
      Me.mnuParametroSub.Text = "Parámetros de"
      '
      'mnuEmpresaPara7
      '
      Me.mnuEmpresaPara7.Key = "mnuEmpresaPara"
      Me.mnuEmpresaPara7.Name = "mnuEmpresaPara7"
      '
      'mnuCompPara7
      '
      Me.mnuCompPara7.Key = "mnuCompPara"
      Me.mnuCompPara7.Name = "mnuCompPara7"
      '
      'mnuCompParaMes6
      '
      Me.mnuCompParaMes6.Key = "mnuCompParaMes"
      Me.mnuCompParaMes6.Name = "mnuCompParaMes6"
      '
      'mnuReciboPara6
      '
      Me.mnuReciboPara6.Key = "mnuReciboPara"
      Me.mnuReciboPara6.Name = "mnuReciboPara6"
      '
      'mnuReciboPara
      '
      Me.mnuReciboPara.Key = "mnuReciboPara"
      Me.mnuReciboPara.Name = "mnuReciboPara"
      Me.mnuReciboPara.Text = "Recibos"
      '
      'mnuRespaldo
      '
      Me.mnuRespaldo.Key = "mnuRespaldo"
      Me.mnuRespaldo.Name = "mnuRespaldo"
      Me.mnuRespaldo.Text = "Documentos de Respaldo"
      '
      'mnuRecibo
      '
      Me.mnuRecibo.Key = "mnuRecibo"
      Me.mnuRecibo.Name = "mnuRecibo"
      Me.mnuRecibo.Text = "Registro de Recibos"
      '
      'btnHelpVideo
      '
      Me.btnHelpVideo.ImageIndex = 11
      Me.btnHelpVideo.Key = "btnHelpVideo"
      Me.btnHelpVideo.Name = "btnHelpVideo"
      Me.btnHelpVideo.ToolTipText = "Video"
      '
      'mnuLibroAgruIVA
      '
      Me.mnuLibroAgruIVA.Key = "mnuLibroAgruIVA"
      Me.mnuLibroAgruIVA.Name = "mnuLibroAgruIVA"
      Me.mnuLibroAgruIVA.Text = "Libro de Ventas Agrupadas"
      '
      'mnuLibroPlanAddCuenta
      '
      Me.mnuLibroPlanAddCuenta.Key = "mnuLibroPlanAddCuenta"
      Me.mnuLibroPlanAddCuenta.Name = "mnuLibroPlanAddCuenta"
      Me.mnuLibroPlanAddCuenta.Text = "Por Cuentas"
      '
      'mnuLibroPlanAddAna
      '
      Me.mnuLibroPlanAddAna.Key = "mnuLibroPlanAddAna"
      Me.mnuLibroPlanAddAna.Name = "mnuLibroPlanAddAna"
      Me.mnuLibroPlanAddAna.Text = "Por Analíticos"
      '
      'mnuLibroDispo
      '
      Me.mnuLibroDispo.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuLibroDispoGeneral1, Me.mnuLibroDispoComparativo1})
      Me.mnuLibroDispo.Key = "mnuLibroDispo"
      Me.mnuLibroDispo.Name = "mnuLibroDispo"
      Me.mnuLibroDispo.Text = "Disponibilidad"
      '
      'mnuLibroDispoGeneral1
      '
      Me.mnuLibroDispoGeneral1.Key = "mnuLibroDispoGeneral"
      Me.mnuLibroDispoGeneral1.Name = "mnuLibroDispoGeneral1"
      '
      'mnuLibroDispoComparativo1
      '
      Me.mnuLibroDispoComparativo1.Key = "mnuLibroDispoComparativo"
      Me.mnuLibroDispoComparativo1.Name = "mnuLibroDispoComparativo1"
      '
      'mnuFactura
      '
      Me.mnuFactura.Key = "mnuFactura"
      Me.mnuFactura.Name = "mnuFactura"
      Me.mnuFactura.Text = "Facturas de"
      '
      'mnuFacturaCompra
      '
      Me.mnuFacturaCompra.Key = "mnuFacturaCompra"
      Me.mnuFacturaCompra.Name = "mnuFacturaCompra"
      Me.mnuFacturaCompra.Text = "Compra"
      '
      'mnuFacturaVenta
      '
      Me.mnuFacturaVenta.Key = "mnuFacturaVenta"
      Me.mnuFacturaVenta.Name = "mnuFacturaVenta"
      Me.mnuFacturaVenta.Text = "Venta"
      '
      'mnuPoliza
      '
      Me.mnuPoliza.Key = "mnuPoliza"
      Me.mnuPoliza.Name = "mnuPoliza"
      Me.mnuPoliza.Text = "Registro de Polizas"
      '
      'mnuAduana
      '
      Me.mnuAduana.Key = "mnuAduana"
      Me.mnuAduana.Name = "mnuAduana"
      Me.mnuAduana.Text = "Agencias Aduaneras"
      '
      'mnuCompFecha
      '
      Me.mnuCompFecha.Key = "mnuCompFecha"
      Me.mnuCompFecha.Name = "mnuCompFecha"
      Me.mnuCompFecha.Text = "Comprobantes entre Fechas"
      '
      'mnuCompBloqueo
      '
      Me.mnuCompBloqueo.Key = "mnuCompBloqueo"
      Me.mnuCompBloqueo.Name = "mnuCompBloqueo"
      Me.mnuCompBloqueo.Text = "Bloqueo / Desbloqueo de Comprobantes"
      '
      'mnuCompParaMes
      '
      Me.mnuCompParaMes.Key = "mnuCompParaMes"
      Me.mnuCompParaMes.Name = "mnuCompParaMes"
      Me.mnuCompParaMes.Text = "Correlativos de Periodos"
      '
      'btnCalculadora
      '
      Me.btnCalculadora.ImageIndex = 9
      Me.btnCalculadora.Key = "btnCalculadora"
      Me.btnCalculadora.Name = "btnCalculadora"
      Me.btnCalculadora.ToolTipText = "Calculadora de Windows"
      '
      'mnuLibroCentroCostoMes
      '
      Me.mnuLibroCentroCostoMes.Key = "mnuLibroCentroCostoMes"
      Me.mnuLibroCentroCostoMes.Name = "mnuLibroCentroCostoMes"
      Me.mnuLibroCentroCostoMes.Text = "Movimiento de Centros de Costo Comparativo"
      '
      'mnuDosifica
      '
      Me.mnuDosifica.Key = "mnuDosifica"
      Me.mnuDosifica.Name = "mnuDosifica"
      Me.mnuDosifica.Text = "Dosificaciones"
      '
      'mnuCentroCostoDet
      '
      Me.mnuCentroCostoDet.Key = "mnuCentroCostoDet"
      Me.mnuCentroCostoDet.Name = "mnuCentroCostoDet"
      Me.mnuCentroCostoDet.Text = "Actividades de Centros de Costo"
      '
      'mnuLibroCentroCostoDetMain
      '
      Me.mnuLibroCentroCostoDetMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuLibroCentroCostoDet1, Me.mnuLibroCentroCostoDetAct1, Me.mnuLibroCentroCostoDetActEmpresa1})
      Me.mnuLibroCentroCostoDetMain.Key = "mnuLibroCentroCostoDetMain"
      Me.mnuLibroCentroCostoDetMain.Name = "mnuLibroCentroCostoDetMain"
      Me.mnuLibroCentroCostoDetMain.Text = "Movimiento de Actividades de C.C."
      '
      'mnuLibroCentroCostoDet1
      '
      Me.mnuLibroCentroCostoDet1.Key = "mnuLibroCentroCostoDet"
      Me.mnuLibroCentroCostoDet1.Name = "mnuLibroCentroCostoDet1"
      '
      'mnuLibroCentroCostoDetAct1
      '
      Me.mnuLibroCentroCostoDetAct1.Key = "mnuLibroCentroCostoDetAct"
      Me.mnuLibroCentroCostoDetAct1.Name = "mnuLibroCentroCostoDetAct1"
      '
      'mnuLibroCentroCostoDetActEmpresa1
      '
      Me.mnuLibroCentroCostoDetActEmpresa1.Key = "mnuLibroCentroCostoDetActEmpresa"
      Me.mnuLibroCentroCostoDetActEmpresa1.Name = "mnuLibroCentroCostoDetActEmpresa1"
      '
      'mnuLibroCentroCostoDet
      '
      Me.mnuLibroCentroCostoDet.Key = "mnuLibroCentroCostoDet"
      Me.mnuLibroCentroCostoDet.Name = "mnuLibroCentroCostoDet"
      Me.mnuLibroCentroCostoDet.Text = "Por Centros de Costo"
      '
      'mnuLibroCentroCostoDetAct
      '
      Me.mnuLibroCentroCostoDetAct.Key = "mnuLibroCentroCostoDetAct"
      Me.mnuLibroCentroCostoDetAct.Name = "mnuLibroCentroCostoDetAct"
      Me.mnuLibroCentroCostoDetAct.Text = "Por Actividad"
      '
      'btnExcel
      '
      Me.btnExcel.ImageIndex = 0
      Me.btnExcel.Key = "btnExcel"
      Me.btnExcel.Name = "btnExcel"
      Me.btnExcel.ToolTipText = "Exportar Grilla a Excel"
      '
      'btnFilter
      '
      Me.btnFilter.ImageIndex = 1
      Me.btnFilter.Key = "btnFilter"
      Me.btnFilter.Name = "btnFilter"
      Me.btnFilter.ToolTipText = "Filtrar Grilla"
      '
      'btnSort
      '
      Me.btnSort.ImageIndex = 2
      Me.btnSort.Key = "btnSort"
      Me.btnSort.Name = "btnSort"
      Me.btnSort.ToolTipText = "Ordenar Grilla"
      '
      'mnuPais
      '
      Me.mnuPais.Key = "mnuPais"
      Me.mnuPais.Name = "mnuPais"
      Me.mnuPais.Text = "Países"
      '
      'mnuDepartamento
      '
      Me.mnuDepartamento.Key = "mnuDepartamento"
      Me.mnuDepartamento.Name = "mnuDepartamento"
      Me.mnuDepartamento.Text = "Departamentos"
      '
      'mnuDataBaseBackup
      '
      Me.mnuDataBaseBackup.Key = "mnuDataBaseBackup"
      Me.mnuDataBaseBackup.Name = "mnuDataBaseBackup"
      Me.mnuDataBaseBackup.Text = "Copia de Respaldo de la Base de Datos"
      '
      'mnuDataBaseImport
      '
      Me.mnuDataBaseImport.Key = "mnuDataBaseImport"
      Me.mnuDataBaseImport.Name = "mnuDataBaseImport"
      Me.mnuDataBaseImport.Text = "Importar Información Desde Otra Base de datos"
      '
      'mnuFlujoEfectivoDet
      '
      Me.mnuFlujoEfectivoDet.Key = "mnuFlujoEfectivoDet"
      Me.mnuFlujoEfectivoDet.Name = "mnuFlujoEfectivoDet"
      Me.mnuFlujoEfectivoDet.Text = "Flujo de Efectivo Detallado"
      '
      'mnuLabor
      '
      Me.mnuLabor.Key = "mnuLabor"
      Me.mnuLabor.Name = "mnuLabor"
      Me.mnuLabor.Text = "Labores"
      '
      'mnuDataSecurityImport
      '
      Me.mnuDataSecurityImport.Key = "mnuDataSecurityImport"
      Me.mnuDataSecurityImport.Name = "mnuDataSecurityImport"
      Me.mnuDataSecurityImport.Text = "Listado de Formularios y Controles"
      '
      'mnuLibroRetencion
      '
      Me.mnuLibroRetencion.Key = "mnuLibroRetencion"
      Me.mnuLibroRetencion.Name = "mnuLibroRetencion"
      Me.mnuLibroRetencion.Text = "Libro de Retenciones"
      '
      'mnuTipoActEco
      '
      Me.mnuTipoActEco.Key = "mnuTipoActEco"
      Me.mnuTipoActEco.Name = "mnuTipoActEco"
      Me.mnuTipoActEco.Text = "Actividades Económicas"
      '
      'mnuDosificaLey
      '
      Me.mnuDosificaLey.Key = "mnuDosificaLey"
      Me.mnuDosificaLey.Name = "mnuDosificaLey"
      Me.mnuDosificaLey.Text = "Leyendas de Derechos del Consumidor"
      '
      'UiCommand1
      '
      Me.UiCommand1.Key = "mnuLibroIVA-NSF"
      Me.UiCommand1.Name = "UiCommand1"
      Me.UiCommand1.Text = "Libros IVA (NSF)"
      '
      'UiCommand3
      '
      Me.UiCommand3.Key = "mnuLibroIVA-SFV"
      Me.UiCommand3.Name = "UiCommand3"
      Me.UiCommand3.Text = "Libros IVA (SFV)"
      '
      'mnuWizard
      '
      Me.mnuWizard.Key = "mnuWizard"
      Me.mnuWizard.Name = "mnuWizard"
      Me.mnuWizard.Text = "Asistente de Implementación"
      '
      'mnuLibroMayorDuo
      '
      Me.mnuLibroMayorDuo.Key = "mnuLibroMayorDuo"
      Me.mnuLibroMayorDuo.Name = "mnuLibroMayorDuo"
      Me.mnuLibroMayorDuo.Text = "Libro Mayor Comparativo por Base de Datos"
      '
      'mnuLibroCheque
      '
      Me.mnuLibroCheque.Key = "mnuLibroCheque"
      Me.mnuLibroCheque.Name = "mnuLibroCheque"
      Me.mnuLibroCheque.Text = "Libro de Cheques"
      '
      'mnuConciliaBanco
      '
      Me.mnuConciliaBanco.Key = "mnuConciliaBanco"
      Me.mnuConciliaBanco.Name = "mnuConciliaBanco"
      Me.mnuConciliaBanco.Text = "Conciliación Bancaria"
      '
      'mnuEstadoComparativo
      '
      Me.mnuEstadoComparativo.Key = "mnuEstadoResultadoEmpresas"
      Me.mnuEstadoComparativo.Name = "mnuEstadoComparativo"
      Me.mnuEstadoComparativo.Text = "Comparativo por Empresas"
      '
      'mnuBalanceComparativo
      '
      Me.mnuBalanceComparativo.Key = "mnuBalanceComparativo"
      Me.mnuBalanceComparativo.Name = "mnuBalanceComparativo"
      Me.mnuBalanceComparativo.Text = "Comparativo por Empresas"
      '
      'mnuPlanEEFF
      '
      Me.mnuPlanEEFF.Key = "mnuPlanEEFF"
      Me.mnuPlanEEFF.Name = "mnuPlanEEFF"
      Me.mnuPlanEEFF.Text = "Plan de Cuentas de Flujo de Efectivo"
      '
      'mnuFlujoEfectivoFind
      '
      Me.mnuFlujoEfectivoFind.Key = "mnuFlujoEfectivoFind"
      Me.mnuFlujoEfectivoFind.Name = "mnuFlujoEfectivoFind"
      Me.mnuFlujoEfectivoFind.Text = "Movimiento de Flujos de Efectivo"
      '
      'mnuEstadoFlujoEfectivoFind
      '
      Me.mnuEstadoFlujoEfectivoFind.Key = "mnuEstadoFlujoEfectivoFind"
      Me.mnuEstadoFlujoEfectivoFind.Name = "mnuEstadoFlujoEfectivoFind"
      Me.mnuEstadoFlujoEfectivoFind.Text = "Estado de Flujos de Efectivo"
      '
      'mnuFlujoEfectivo
      '
      Me.mnuFlujoEfectivo.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuFlujoEfectivoFind1, Me.mnuEstadoFlujoEfectivoFind1})
      Me.mnuFlujoEfectivo.Key = "mnuFlujoEfectivo"
      Me.mnuFlujoEfectivo.Name = "mnuFlujoEfectivo"
      Me.mnuFlujoEfectivo.Text = "Flujos de Efectivo"
      '
      'mnuFlujoEfectivoFind1
      '
      Me.mnuFlujoEfectivoFind1.Key = "mnuFlujoEfectivoFind"
      Me.mnuFlujoEfectivoFind1.Name = "mnuFlujoEfectivoFind1"
      '
      'mnuEstadoFlujoEfectivoFind1
      '
      Me.mnuEstadoFlujoEfectivoFind1.Key = "mnuEstadoFlujoEfectivoFind"
      Me.mnuEstadoFlujoEfectivoFind1.Name = "mnuEstadoFlujoEfectivoFind1"
      '
      'mnuChequeOpen
      '
      Me.mnuChequeOpen.Key = "mnuChequeOpen"
      Me.mnuChequeOpen.Name = "mnuChequeOpen"
      Me.mnuChequeOpen.Text = "Registrar Cheques"
      '
      'mnuEstadoResultadoCC
      '
      Me.mnuEstadoResultadoCC.Key = "mnuEstadoResultadoCC"
      Me.mnuEstadoResultadoCC.Name = "mnuEstadoResultadoCC"
      Me.mnuEstadoResultadoCC.Text = "Comparativo por Centros de costo"
      '
      'mnuEstadoResultadoMenu
      '
      Me.mnuEstadoResultadoMenu.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuEstadoResultadoGeneral1, Me.mnuEstadoResultadoAct1, Me.mnuEstadoResultadoCC1, Me.mnuEstadoResultadoEmpresas1})
      Me.mnuEstadoResultadoMenu.Key = "mnuEstadoResultadoMenu"
      Me.mnuEstadoResultadoMenu.Name = "mnuEstadoResultadoMenu"
      Me.mnuEstadoResultadoMenu.Text = "Estado de Resultados"
      '
      'mnuEstadoResultadoGeneral1
      '
      Me.mnuEstadoResultadoGeneral1.Key = "mnuEstadoResultadoGeneral"
      Me.mnuEstadoResultadoGeneral1.Name = "mnuEstadoResultadoGeneral1"
      '
      'mnuEstadoResultadoAct1
      '
      Me.mnuEstadoResultadoAct1.Key = "mnuEstadoResultadoAct"
      Me.mnuEstadoResultadoAct1.Name = "mnuEstadoResultadoAct1"
      '
      'mnuEstadoResultadoCC1
      '
      Me.mnuEstadoResultadoCC1.Key = "mnuEstadoResultadoCC"
      Me.mnuEstadoResultadoCC1.Name = "mnuEstadoResultadoCC1"
      '
      'mnuEstadoResultadoEmpresas1
      '
      Me.mnuEstadoResultadoEmpresas1.Key = "mnuEstadoResultadoEmpresas"
      Me.mnuEstadoResultadoEmpresas1.Name = "mnuEstadoResultadoEmpresas1"
      '
      'mnuBalanceMenu
      '
      Me.mnuBalanceMenu.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuBalance7, Me.mnuBalanceComparativo1})
      Me.mnuBalanceMenu.Key = "mnuBalanceMenu"
      Me.mnuBalanceMenu.Name = "mnuBalanceMenu"
      Me.mnuBalanceMenu.Text = "Balance General"
      '
      'mnuBalance7
      '
      Me.mnuBalance7.Key = "mnuBalance"
      Me.mnuBalance7.Name = "mnuBalance7"
      '
      'mnuBalanceComparativo1
      '
      Me.mnuBalanceComparativo1.Key = "mnuBalanceComparativo"
      Me.mnuBalanceComparativo1.Name = "mnuBalanceComparativo1"
      '
      'mnuLibroMayorAnalisis
      '
      Me.mnuLibroMayorAnalisis.Key = "mnuLibroMayorAnalisis"
      Me.mnuLibroMayorAnalisis.Name = "mnuLibroMayorAnalisis"
      Me.mnuLibroMayorAnalisis.Text = "Libro Mayor para Análisis"
      '
      'mnuEstadoResultadoAct
      '
      Me.mnuEstadoResultadoAct.Key = "mnuEstadoResultadoAct"
      Me.mnuEstadoResultadoAct.Name = "mnuEstadoResultadoAct"
      Me.mnuEstadoResultadoAct.Text = "Por Actividades"
      '
      'mnuLibroMayorDet
      '
      Me.mnuLibroMayorDet.Key = "mnuLibroMayorDet"
      Me.mnuLibroMayorDet.Name = "mnuLibroMayorDet"
      Me.mnuLibroMayorDet.Text = "Libro Mayor Detallado"
      '
      'mnuLibroMayorMenu
      '
      Me.mnuLibroMayorMenu.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.mnuLibroMayor7, Me.mnuLibroMayorDet1, Me.mnuLibroMayorAnalisis1, Me.mnuLibroMayorDuo2, Me.mnuLibroMayorComparativo1})
      Me.mnuLibroMayorMenu.Key = "mnuLibroMayorMenu"
      Me.mnuLibroMayorMenu.Name = "mnuLibroMayorMenu"
      Me.mnuLibroMayorMenu.Text = "Libro Mayor"
      '
      'mnuLibroMayor7
      '
      Me.mnuLibroMayor7.Key = "mnuLibroMayor"
      Me.mnuLibroMayor7.Name = "mnuLibroMayor7"
      '
      'mnuLibroMayorDet1
      '
      Me.mnuLibroMayorDet1.Key = "mnuLibroMayorDet"
      Me.mnuLibroMayorDet1.Name = "mnuLibroMayorDet1"
      '
      'mnuLibroMayorAnalisis1
      '
      Me.mnuLibroMayorAnalisis1.Key = "mnuLibroMayorAnalisis"
      Me.mnuLibroMayorAnalisis1.Name = "mnuLibroMayorAnalisis1"
      '
      'mnuLibroMayorDuo2
      '
      Me.mnuLibroMayorDuo2.Key = "mnuLibroMayorDuo"
      Me.mnuLibroMayorDuo2.Name = "mnuLibroMayorDuo2"
      '
      'mnuLibroMayorComparativo1
      '
      Me.mnuLibroMayorComparativo1.Key = "mnuLibroMayorComparativo"
      Me.mnuLibroMayorComparativo1.Name = "mnuLibroMayorComparativo1"
      '
      'mnuLibroIVACC
      '
      Me.mnuLibroIVACC.Key = "mnuLibroIVACC"
      Me.mnuLibroIVACC.Name = "mnuLibroIVACC"
      Me.mnuLibroIVACC.Text = "Libros IVA (SFV) por Centro de Costo"
      '
      'mnuLibroCentroCostoDetActEmpresa
      '
      Me.mnuLibroCentroCostoDetActEmpresa.Key = "mnuLibroCentroCostoDetActEmpresa"
      Me.mnuLibroCentroCostoDetActEmpresa.Name = "mnuLibroCentroCostoDetActEmpresa"
      Me.mnuLibroCentroCostoDetActEmpresa.Text = "Por Actividad Comparativo por Empresas"
      '
      'mnuSumaSaldoGeneral
      '
      Me.mnuSumaSaldoGeneral.Key = "mnuSumaSaldoGeneral"
      Me.mnuSumaSaldoGeneral.Name = "mnuSumaSaldoGeneral"
      Me.mnuSumaSaldoGeneral.Text = "Sumas y Saldos General"
      '
      'mnuSumaSaldoAnalisis
      '
      Me.mnuSumaSaldoAnalisis.Key = "mnuSumaSaldoAnalisis"
      Me.mnuSumaSaldoAnalisis.Name = "mnuSumaSaldoAnalisis"
      Me.mnuSumaSaldoAnalisis.Text = "Sumas y Saldos para Análisis"
      '
      'mnuSumaSaldoComparativo
      '
      Me.mnuSumaSaldoComparativo.Key = "mnuSumaSaldoComparativo"
      Me.mnuSumaSaldoComparativo.Name = "mnuSumaSaldoComparativo"
      Me.mnuSumaSaldoComparativo.Text = "Comparativo por Empresas"
      '
      'mnuLibroDispoGeneral
      '
      Me.mnuLibroDispoGeneral.Key = "mnuLibroDispoGeneral"
      Me.mnuLibroDispoGeneral.Name = "mnuLibroDispoGeneral"
      Me.mnuLibroDispoGeneral.Text = "General"
      '
      'mnuLibroDispoComparativo
      '
      Me.mnuLibroDispoComparativo.Key = "mnuLibroDispoComparativo"
      Me.mnuLibroDispoComparativo.Name = "mnuLibroDispoComparativo"
      Me.mnuLibroDispoComparativo.Text = "Comparativo por Empresas"
      '
      'mnuLibroMayorComparativo
      '
      Me.mnuLibroMayorComparativo.Key = "mnuLibroMayorComparativo"
      Me.mnuLibroMayorComparativo.Name = "mnuLibroMayorComparativo"
      Me.mnuLibroMayorComparativo.Text = "Comparativo por Empresas"
      '
      'mnuSumaSaldoComparativoCC
      '
      Me.mnuSumaSaldoComparativoCC.Key = "mnuSumaSaldoComparativoCC"
      Me.mnuSumaSaldoComparativoCC.Name = "mnuSumaSaldoComparativoCC"
      Me.mnuSumaSaldoComparativoCC.Text = "Comparativo por Centro de Costos"
      '
      'ilsMain
      '
      Me.ilsMain.ImageStream = CType(resources.GetObject("ilsMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilsMain.TransparentColor = System.Drawing.Color.Transparent
      Me.ilsMain.Images.SetKeyName(0, "Excel.png")
      Me.ilsMain.Images.SetKeyName(1, "Filter.png")
      Me.ilsMain.Images.SetKeyName(2, "Sort.png")
      Me.ilsMain.Images.SetKeyName(3, "Company.png")
      Me.ilsMain.Images.SetKeyName(4, "List.png")
      Me.ilsMain.Images.SetKeyName(5, "Registro.png")
      Me.ilsMain.Images.SetKeyName(6, "Parametro.png")
      Me.ilsMain.Images.SetKeyName(7, "TipoCambio.png")
      Me.ilsMain.Images.SetKeyName(8, "UserPass.png")
      Me.ilsMain.Images.SetKeyName(9, "Calculator.png")
      Me.ilsMain.Images.SetKeyName(10, "Help.png")
      Me.ilsMain.Images.SetKeyName(11, "Video.png")
      Me.ilsMain.Images.SetKeyName(12, "Exit.png")
      '
      'LeftRebar1
      '
      Me.LeftRebar1.CommandManager = Me.cdmMain
      Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
      Me.LeftRebar1.Location = New System.Drawing.Point(0, 50)
      Me.LeftRebar1.Name = "LeftRebar1"
      Me.LeftRebar1.Size = New System.Drawing.Size(0, 363)
      '
      'RightRebar1
      '
      Me.RightRebar1.CommandManager = Me.cdmMain
      Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
      Me.RightRebar1.Location = New System.Drawing.Point(728, 50)
      Me.RightRebar1.Name = "RightRebar1"
      Me.RightRebar1.Size = New System.Drawing.Size(0, 363)
      '
      'TopRebar1
      '
      Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.Menu1, Me.ToolBar1, Me.ToolSet1})
      Me.TopRebar1.CommandManager = Me.cdmMain
      Me.TopRebar1.Controls.Add(Me.Menu1)
      Me.TopRebar1.Controls.Add(Me.ToolBar1)
      Me.TopRebar1.Controls.Add(Me.ToolSet1)
      Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
      Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
      Me.TopRebar1.Name = "TopRebar1"
      Me.TopRebar1.Size = New System.Drawing.Size(728, 54)
      '
      'mnuEmpresa5
      '
      Me.mnuEmpresa5.Key = "mnuEmpresa"
      Me.mnuEmpresa5.Name = "mnuEmpresa5"
      '
      'mnuSucursal5
      '
      Me.mnuSucursal5.Key = "mnuSucursal"
      Me.mnuSucursal5.Name = "mnuSucursal5"
      '
      'Separator45
      '
      Me.Separator45.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator45.Key = "Separator"
      Me.Separator45.Name = "Separator45"
      '
      'mnuPlan5
      '
      Me.mnuPlan5.Key = "mnuPlan"
      Me.mnuPlan5.Name = "mnuPlan5"
      '
      'mnuPlanAdd5
      '
      Me.mnuPlanAdd5.Key = "mnuPlanAdd"
      Me.mnuPlanAdd5.Name = "mnuPlanAdd5"
      '
      'Separator44
      '
      Me.Separator44.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator44.Key = "Separator"
      Me.Separator44.Name = "Separator44"
      '
      'mnuCentroCosto5
      '
      Me.mnuCentroCosto5.Key = "mnuCentroCosto"
      Me.mnuCentroCosto5.Name = "mnuCentroCosto5"
      '
      'mnuCentroCostoDet1
      '
      Me.mnuCentroCostoDet1.Key = "mnuCentroCostoDet"
      Me.mnuCentroCostoDet1.Name = "mnuCentroCostoDet1"
      '
      'Separator37
      '
      Me.Separator37.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator37.Key = "Separator"
      Me.Separator37.Name = "Separator37"
      '
      'mnuBanco5
      '
      Me.mnuBanco5.Key = "mnuBanco"
      Me.mnuBanco5.Name = "mnuBanco5"
      '
      'mnuCheque5
      '
      Me.mnuCheque5.Key = "mnuCheque"
      Me.mnuCheque5.Name = "mnuCheque5"
      '
      'Separator38
      '
      Me.Separator38.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator38.Key = "Separator"
      Me.Separator38.Name = "Separator38"
      '
      'mnuRegRUC5
      '
      Me.mnuRegRUC5.Key = "mnuRegRUC"
      Me.mnuRegRUC5.Name = "mnuRegRUC5"
      '
      'mnuAduana4
      '
      Me.mnuAduana4.Key = "mnuAduana"
      Me.mnuAduana4.Name = "mnuAduana4"
      '
      'mnuDosifica4
      '
      Me.mnuDosifica4.Key = "mnuDosifica"
      Me.mnuDosifica4.Name = "mnuDosifica4"
      '
      'Separator39
      '
      Me.Separator39.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator39.Key = "Separator"
      Me.Separator39.Name = "Separator39"
      '
      'mnuCiudad5
      '
      Me.mnuCiudad5.Key = "mnuCiudad"
      Me.mnuCiudad5.Name = "mnuCiudad5"
      '
      'mnuRespaldo4
      '
      Me.mnuRespaldo4.Key = "mnuRespaldo"
      Me.mnuRespaldo4.Name = "mnuRespaldo4"
      '
      'mnuComp5
      '
      Me.mnuComp5.Key = "mnuComp"
      Me.mnuComp5.Name = "mnuComp5"
      '
      'mnuCompBloqueo4
      '
      Me.mnuCompBloqueo4.Key = "mnuCompBloqueo"
      Me.mnuCompBloqueo4.Name = "mnuCompBloqueo4"
      '
      'Separator40
      '
      Me.Separator40.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator40.Key = "Separator"
      Me.Separator40.Name = "Separator40"
      '
      'mnuPoliza4
      '
      Me.mnuPoliza4.Key = "mnuPoliza"
      Me.mnuPoliza4.Name = "mnuPoliza4"
      '
      'mnuRecibo4
      '
      Me.mnuRecibo4.Key = "mnuRecibo"
      Me.mnuRecibo4.Name = "mnuRecibo4"
      '
      'Separator41
      '
      Me.Separator41.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator41.Key = "Separator"
      Me.Separator41.Name = "Separator41"
      '
      'mnuLibroMayor5
      '
      Me.mnuLibroMayor5.Key = "mnuLibroMayor"
      Me.mnuLibroMayor5.Name = "mnuLibroMayor5"
      '
      'mnuLibroDiario3
      '
      Me.mnuLibroDiario3.Key = "mnuLibroDiario"
      Me.mnuLibroDiario3.Name = "mnuLibroDiario3"
      '
      'Separator42
      '
      Me.Separator42.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator42.Key = "Separator"
      Me.Separator42.Name = "Separator42"
      '
      'mnuAjuste5
      '
      Me.mnuAjuste5.Key = "mnuAjuste"
      Me.mnuAjuste5.Name = "mnuAjuste5"
      '
      'mnuCierreCuenta5
      '
      Me.mnuCierreCuenta5.Key = "mnuCierreCuenta"
      Me.mnuCierreCuenta5.Name = "mnuCierreCuenta5"
      '
      'mnuCierreGestion5
      '
      Me.mnuCierreGestion5.Key = "mnuCierreGestion"
      Me.mnuCierreGestion5.Name = "mnuCierreGestion5"
      '
      'mnuBalance5
      '
      Me.mnuBalance5.Key = "mnuBalance"
      Me.mnuBalance5.Name = "mnuBalance5"
      '
      'mnuEstadoResultado5
      '
      Me.mnuEstadoResultado5.Key = "mnuEstadoResultado"
      Me.mnuEstadoResultado5.Name = "mnuEstadoResultado5"
      '
      'mnuSumaSaldo5
      '
      Me.mnuSumaSaldo5.Key = "mnuSumaSaldo"
      Me.mnuSumaSaldo5.Name = "mnuSumaSaldo5"
      '
      'mnuCompFecha4
      '
      Me.mnuCompFecha4.Key = "mnuCompFecha"
      Me.mnuCompFecha4.Name = "mnuCompFecha4"
      Me.mnuCompFecha4.Text = "Listado de Comprobantes"
      '
      'mnuLibroIVA5
      '
      Me.mnuLibroIVA5.Key = "mnuLibroIVA"
      Me.mnuLibroIVA5.Name = "mnuLibroIVA5"
      '
      'mnuLibroAgruIVA4
      '
      Me.mnuLibroAgruIVA4.Key = "mnuLibroAgruIVA"
      Me.mnuLibroAgruIVA4.Name = "mnuLibroAgruIVA4"
      '
      'mnuLibroBanco5
      '
      Me.mnuLibroBanco5.Key = "mnuLibroBanco"
      Me.mnuLibroBanco5.Name = "mnuLibroBanco5"
      '
      'mnuLibroITF5
      '
      Me.mnuLibroITF5.Key = "mnuLibroITF"
      Me.mnuLibroITF5.Name = "mnuLibroITF5"
      '
      'mnuLibroDispo4
      '
      Me.mnuLibroDispo4.Key = "mnuLibroDispo"
      Me.mnuLibroDispo4.Name = "mnuLibroDispo4"
      '
      'mnuLibroPlanAdd5
      '
      Me.mnuLibroPlanAdd5.Key = "mnuLibroPlanAdd"
      Me.mnuLibroPlanAdd5.Name = "mnuLibroPlanAdd5"
      '
      'mnuLibroSucursal5
      '
      Me.mnuLibroSucursal5.Key = "mnuLibroSucursal"
      Me.mnuLibroSucursal5.Name = "mnuLibroSucursal5"
      '
      'mnuLibroCentroCosto5
      '
      Me.mnuLibroCentroCosto5.Key = "mnuLibroCentroCosto"
      Me.mnuLibroCentroCosto5.Name = "mnuLibroCentroCosto5"
      '
      'Separator43
      '
      Me.Separator43.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator43.Key = "Separator"
      Me.Separator43.Name = "Separator43"
      '
      'mnuEstadoResultadoMes1
      '
      Me.mnuEstadoResultadoMes1.Key = "mnuEstadoResultadoMes"
      Me.mnuEstadoResultadoMes1.Name = "mnuEstadoResultadoMes1"
      '
      'mnuLibroCentroCostoMes1
      '
      Me.mnuLibroCentroCostoMes1.Key = "mnuLibroCentroCostoMes"
      Me.mnuLibroCentroCostoMes1.Name = "mnuLibroCentroCostoMes1"
      '
      'mnuLibroPlanAddCuenta4
      '
      Me.mnuLibroPlanAddCuenta4.Key = "mnuLibroPlanAddCuenta"
      Me.mnuLibroPlanAddCuenta4.Name = "mnuLibroPlanAddCuenta4"
      '
      'mnuLibroPlanAddAna4
      '
      Me.mnuLibroPlanAddAna4.Key = "mnuLibroPlanAddAna"
      Me.mnuLibroPlanAddAna4.Name = "mnuLibroPlanAddAna4"
      '
      'mnuGestion5
      '
      Me.mnuGestion5.Key = "mnuGestion"
      Me.mnuGestion5.Name = "mnuGestion5"
      '
      'mnuOpera1
      '
      Me.mnuOpera1.Key = "mnuOpera"
      Me.mnuOpera1.Name = "mnuOpera1"
      '
      'mnuParametroSub4
      '
      Me.mnuParametroSub4.Key = "mnuParametroSub"
      Me.mnuParametroSub4.Name = "mnuParametroSub4"
      '
      'mnuTipoCambio5
      '
      Me.mnuTipoCambio5.Key = "mnuTipoCambio"
      Me.mnuTipoCambio5.Name = "mnuTipoCambio5"
      '
      'mnuImpuesto4
      '
      Me.mnuImpuesto4.Key = "mnuImpuesto"
      Me.mnuImpuesto4.Name = "mnuImpuesto4"
      '
      'mnuAyudaDinamica4
      '
      Me.mnuAyudaDinamica4.Key = "mnuAyudaDinamica"
      Me.mnuAyudaDinamica4.Name = "mnuAyudaDinamica4"
      '
      'mnuAboutBox5
      '
      Me.mnuAboutBox5.Key = "mnuAboutBox"
      Me.mnuAboutBox5.Name = "mnuAboutBox5"
      '
      'mnuToolBar4
      '
      Me.mnuToolBar4.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuToolBar4.Key = "mnuToolBar"
      Me.mnuToolBar4.Name = "mnuToolBar4"
      '
      'mnuStatusBar4
      '
      Me.mnuStatusBar4.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuStatusBar4.Key = "mnuStatusBar"
      Me.mnuStatusBar4.Name = "mnuStatusBar4"
      '
      'mnuEmpresaPara5
      '
      Me.mnuEmpresaPara5.Key = "mnuEmpresaPara"
      Me.mnuEmpresaPara5.Name = "mnuEmpresaPara5"
      '
      'mnuCompPara5
      '
      Me.mnuCompPara5.Key = "mnuCompPara"
      Me.mnuCompPara5.Name = "mnuCompPara5"
      '
      'mnuCompParaMes4
      '
      Me.mnuCompParaMes4.Key = "mnuCompParaMes"
      Me.mnuCompParaMes4.Name = "mnuCompParaMes4"
      '
      'mnuReciboPara4
      '
      Me.mnuReciboPara4.Key = "mnuReciboPara"
      Me.mnuReciboPara4.Name = "mnuReciboPara4"
      '
      'mnuEmpresa4
      '
      Me.mnuEmpresa4.Key = "mnuEmpresa"
      Me.mnuEmpresa4.Name = "mnuEmpresa4"
      '
      'mnuPlan4
      '
      Me.mnuPlan4.Key = "mnuPlan"
      Me.mnuPlan4.Name = "mnuPlan4"
      '
      'mnuPlanAdd4
      '
      Me.mnuPlanAdd4.Key = "mnuPlanAdd"
      Me.mnuPlanAdd4.Name = "mnuPlanAdd4"
      '
      'mnuCentroCosto4
      '
      Me.mnuCentroCosto4.Key = "mnuCentroCosto"
      Me.mnuCentroCosto4.Name = "mnuCentroCosto4"
      '
      'mnuSucursal4
      '
      Me.mnuSucursal4.Key = "mnuSucursal"
      Me.mnuSucursal4.Name = "mnuSucursal4"
      '
      'Separator30
      '
      Me.Separator30.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator30.Key = "Separator"
      Me.Separator30.Name = "Separator30"
      '
      'mnuBanco4
      '
      Me.mnuBanco4.Key = "mnuBanco"
      Me.mnuBanco4.Name = "mnuBanco4"
      '
      'mnuCheque4
      '
      Me.mnuCheque4.Key = "mnuCheque"
      Me.mnuCheque4.Name = "mnuCheque4"
      '
      'Separator31
      '
      Me.Separator31.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator31.Key = "Separator"
      Me.Separator31.Name = "Separator31"
      '
      'mnuRegRUC4
      '
      Me.mnuRegRUC4.Key = "mnuRegRUC"
      Me.mnuRegRUC4.Name = "mnuRegRUC4"
      '
      'mnuAduana3
      '
      Me.mnuAduana3.Key = "mnuAduana"
      Me.mnuAduana3.Name = "mnuAduana3"
      '
      'mnuDosifica3
      '
      Me.mnuDosifica3.Key = "mnuDosifica"
      Me.mnuDosifica3.Name = "mnuDosifica3"
      '
      'Separator32
      '
      Me.Separator32.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator32.Key = "Separator"
      Me.Separator32.Name = "Separator32"
      '
      'mnuCiudad4
      '
      Me.mnuCiudad4.Key = "mnuCiudad"
      Me.mnuCiudad4.Name = "mnuCiudad4"
      '
      'mnuRespaldo3
      '
      Me.mnuRespaldo3.Key = "mnuRespaldo"
      Me.mnuRespaldo3.Name = "mnuRespaldo3"
      '
      'mnuComp4
      '
      Me.mnuComp4.Key = "mnuComp"
      Me.mnuComp4.Name = "mnuComp4"
      '
      'mnuCompBloqueo3
      '
      Me.mnuCompBloqueo3.Key = "mnuCompBloqueo"
      Me.mnuCompBloqueo3.Name = "mnuCompBloqueo3"
      '
      'Separator33
      '
      Me.Separator33.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator33.Key = "Separator"
      Me.Separator33.Name = "Separator33"
      '
      'mnuPoliza3
      '
      Me.mnuPoliza3.Key = "mnuPoliza"
      Me.mnuPoliza3.Name = "mnuPoliza3"
      '
      'mnuRecibo3
      '
      Me.mnuRecibo3.Key = "mnuRecibo"
      Me.mnuRecibo3.Name = "mnuRecibo3"
      '
      'Separator34
      '
      Me.Separator34.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator34.Key = "Separator"
      Me.Separator34.Name = "Separator34"
      '
      'mnuLibroMayor4
      '
      Me.mnuLibroMayor4.Key = "mnuLibroMayor"
      Me.mnuLibroMayor4.Name = "mnuLibroMayor4"
      '
      'mnuLibroDiario2
      '
      Me.mnuLibroDiario2.Key = "mnuLibroDiario"
      Me.mnuLibroDiario2.Name = "mnuLibroDiario2"
      '
      'Separator35
      '
      Me.Separator35.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator35.Key = "Separator"
      Me.Separator35.Name = "Separator35"
      '
      'mnuAjuste4
      '
      Me.mnuAjuste4.Key = "mnuAjuste"
      Me.mnuAjuste4.Name = "mnuAjuste4"
      '
      'mnuCierreCuenta4
      '
      Me.mnuCierreCuenta4.Key = "mnuCierreCuenta"
      Me.mnuCierreCuenta4.Name = "mnuCierreCuenta4"
      '
      'mnuCierreGestion4
      '
      Me.mnuCierreGestion4.Key = "mnuCierreGestion"
      Me.mnuCierreGestion4.Name = "mnuCierreGestion4"
      '
      'mnuBalance4
      '
      Me.mnuBalance4.Key = "mnuBalance"
      Me.mnuBalance4.Name = "mnuBalance4"
      '
      'mnuEstadoResultado4
      '
      Me.mnuEstadoResultado4.Key = "mnuEstadoResultado"
      Me.mnuEstadoResultado4.Name = "mnuEstadoResultado4"
      '
      'mnuSumaSaldo4
      '
      Me.mnuSumaSaldo4.Key = "mnuSumaSaldo"
      Me.mnuSumaSaldo4.Name = "mnuSumaSaldo4"
      '
      'mnuCompFecha3
      '
      Me.mnuCompFecha3.Key = "mnuCompFecha"
      Me.mnuCompFecha3.Name = "mnuCompFecha3"
      Me.mnuCompFecha3.Text = "Listado de Comprobantes"
      '
      'mnuLibroIVA4
      '
      Me.mnuLibroIVA4.Key = "mnuLibroIVA"
      Me.mnuLibroIVA4.Name = "mnuLibroIVA4"
      '
      'mnuLibroAgruIVA3
      '
      Me.mnuLibroAgruIVA3.Key = "mnuLibroAgruIVA"
      Me.mnuLibroAgruIVA3.Name = "mnuLibroAgruIVA3"
      '
      'mnuLibroBanco4
      '
      Me.mnuLibroBanco4.Key = "mnuLibroBanco"
      Me.mnuLibroBanco4.Name = "mnuLibroBanco4"
      '
      'mnuLibroITF4
      '
      Me.mnuLibroITF4.Key = "mnuLibroITF"
      Me.mnuLibroITF4.Name = "mnuLibroITF4"
      '
      'mnuLibroDispo3
      '
      Me.mnuLibroDispo3.Key = "mnuLibroDispo"
      Me.mnuLibroDispo3.Name = "mnuLibroDispo3"
      '
      'mnuLibroPlanAdd4
      '
      Me.mnuLibroPlanAdd4.Key = "mnuLibroPlanAdd"
      Me.mnuLibroPlanAdd4.Name = "mnuLibroPlanAdd4"
      '
      'mnuLibroSucursal4
      '
      Me.mnuLibroSucursal4.Key = "mnuLibroSucursal"
      Me.mnuLibroSucursal4.Name = "mnuLibroSucursal4"
      '
      'mnuLibroCentroCosto4
      '
      Me.mnuLibroCentroCosto4.Key = "mnuLibroCentroCosto"
      Me.mnuLibroCentroCosto4.Name = "mnuLibroCentroCosto4"
      '
      'mnuLibroCentroCostoComp3
      '
      Me.mnuLibroCentroCostoComp3.Key = "mnuLibroCentroCostoMes"
      Me.mnuLibroCentroCostoComp3.Name = "mnuLibroCentroCostoComp3"
      '
      'mnuLibroPlanAddCuenta3
      '
      Me.mnuLibroPlanAddCuenta3.Key = "mnuLibroPlanAddCuenta"
      Me.mnuLibroPlanAddCuenta3.Name = "mnuLibroPlanAddCuenta3"
      '
      'mnuLibroPlanAddAna3
      '
      Me.mnuLibroPlanAddAna3.Key = "mnuLibroPlanAddAna"
      Me.mnuLibroPlanAddAna3.Name = "mnuLibroPlanAddAna3"
      '
      'mnuGestion4
      '
      Me.mnuGestion4.Key = "mnuGestion"
      Me.mnuGestion4.Name = "mnuGestion4"
      '
      'mnuParametroSub3
      '
      Me.mnuParametroSub3.Key = "mnuParametroSub"
      Me.mnuParametroSub3.Name = "mnuParametroSub3"
      '
      'mnuTipoCambio4
      '
      Me.mnuTipoCambio4.Key = "mnuTipoCambio"
      Me.mnuTipoCambio4.Name = "mnuTipoCambio4"
      '
      'mnuImpuesto3
      '
      Me.mnuImpuesto3.Key = "mnuImpuesto"
      Me.mnuImpuesto3.Name = "mnuImpuesto3"
      '
      'mnuAyudaDinamica3
      '
      Me.mnuAyudaDinamica3.Key = "mnuAyudaDinamica"
      Me.mnuAyudaDinamica3.Name = "mnuAyudaDinamica3"
      '
      'mnuAboutBox4
      '
      Me.mnuAboutBox4.Key = "mnuAboutBox"
      Me.mnuAboutBox4.Name = "mnuAboutBox4"
      '
      'mnuToolBar3
      '
      Me.mnuToolBar3.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuToolBar3.Key = "mnuToolBar"
      Me.mnuToolBar3.Name = "mnuToolBar3"
      '
      'mnuStatusBar3
      '
      Me.mnuStatusBar3.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuStatusBar3.Key = "mnuStatusBar"
      Me.mnuStatusBar3.Name = "mnuStatusBar3"
      '
      'mnuEmpresaPara4
      '
      Me.mnuEmpresaPara4.Key = "mnuEmpresaPara"
      Me.mnuEmpresaPara4.Name = "mnuEmpresaPara4"
      '
      'mnuCompPara4
      '
      Me.mnuCompPara4.Key = "mnuCompPara"
      Me.mnuCompPara4.Name = "mnuCompPara4"
      '
      'mnuCompParaMes3
      '
      Me.mnuCompParaMes3.Key = "mnuCompParaMes"
      Me.mnuCompParaMes3.Name = "mnuCompParaMes3"
      '
      'mnuReciboPara3
      '
      Me.mnuReciboPara3.Key = "mnuReciboPara"
      Me.mnuReciboPara3.Name = "mnuReciboPara3"
      '
      'mnuEmpresa3
      '
      Me.mnuEmpresa3.Key = "mnuEmpresa"
      Me.mnuEmpresa3.Name = "mnuEmpresa3"
      '
      'mnuPlan3
      '
      Me.mnuPlan3.Key = "mnuPlan"
      Me.mnuPlan3.Name = "mnuPlan3"
      '
      'mnuPlanAdd3
      '
      Me.mnuPlanAdd3.Key = "mnuPlanAdd"
      Me.mnuPlanAdd3.Name = "mnuPlanAdd3"
      '
      'mnuCentroCosto3
      '
      Me.mnuCentroCosto3.Key = "mnuCentroCosto"
      Me.mnuCentroCosto3.Name = "mnuCentroCosto3"
      '
      'mnuSucursal3
      '
      Me.mnuSucursal3.Key = "mnuSucursal"
      Me.mnuSucursal3.Name = "mnuSucursal3"
      '
      'Separator20
      '
      Me.Separator20.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator20.Key = "Separator"
      Me.Separator20.Name = "Separator20"
      '
      'mnuBanco3
      '
      Me.mnuBanco3.Key = "mnuBanco"
      Me.mnuBanco3.Name = "mnuBanco3"
      '
      'mnuCheque3
      '
      Me.mnuCheque3.Key = "mnuCheque"
      Me.mnuCheque3.Name = "mnuCheque3"
      '
      'Separator21
      '
      Me.Separator21.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator21.Key = "Separator"
      Me.Separator21.Name = "Separator21"
      '
      'mnuRegRUC3
      '
      Me.mnuRegRUC3.Key = "mnuRegRUC"
      Me.mnuRegRUC3.Name = "mnuRegRUC3"
      '
      'mnuAduana2
      '
      Me.mnuAduana2.Key = "mnuAduana"
      Me.mnuAduana2.Name = "mnuAduana2"
      '
      'mnuDosifica2
      '
      Me.mnuDosifica2.Key = "mnuDosifica"
      Me.mnuDosifica2.Name = "mnuDosifica2"
      '
      'Separator22
      '
      Me.Separator22.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator22.Key = "Separator"
      Me.Separator22.Name = "Separator22"
      '
      'mnuCiudad3
      '
      Me.mnuCiudad3.Key = "mnuCiudad"
      Me.mnuCiudad3.Name = "mnuCiudad3"
      '
      'mnuRespaldo2
      '
      Me.mnuRespaldo2.Key = "mnuRespaldo"
      Me.mnuRespaldo2.Name = "mnuRespaldo2"
      '
      'mnuComp3
      '
      Me.mnuComp3.Key = "mnuComp"
      Me.mnuComp3.Name = "mnuComp3"
      '
      'mnuCompBloqueo2
      '
      Me.mnuCompBloqueo2.Key = "mnuCompBloqueo"
      Me.mnuCompBloqueo2.Name = "mnuCompBloqueo2"
      '
      'Separator23
      '
      Me.Separator23.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator23.Key = "Separator"
      Me.Separator23.Name = "Separator23"
      '
      'mnuPoliza2
      '
      Me.mnuPoliza2.Key = "mnuPoliza"
      Me.mnuPoliza2.Name = "mnuPoliza2"
      '
      'mnuRecibo2
      '
      Me.mnuRecibo2.Key = "mnuRecibo"
      Me.mnuRecibo2.Name = "mnuRecibo2"
      '
      'Separator24
      '
      Me.Separator24.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator24.Key = "Separator"
      Me.Separator24.Name = "Separator24"
      '
      'mnuLibroMayor3
      '
      Me.mnuLibroMayor3.Key = "mnuLibroMayor"
      Me.mnuLibroMayor3.Name = "mnuLibroMayor3"
      '
      'mnuLibroDiario1
      '
      Me.mnuLibroDiario1.Key = "mnuLibroDiario"
      Me.mnuLibroDiario1.Name = "mnuLibroDiario1"
      '
      'Separator25
      '
      Me.Separator25.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator25.Key = "Separator"
      Me.Separator25.Name = "Separator25"
      '
      'mnuAjuste3
      '
      Me.mnuAjuste3.Key = "mnuAjuste"
      Me.mnuAjuste3.Name = "mnuAjuste3"
      '
      'mnuCierreCuenta3
      '
      Me.mnuCierreCuenta3.Key = "mnuCierreCuenta"
      Me.mnuCierreCuenta3.Name = "mnuCierreCuenta3"
      '
      'mnuCierreGestion3
      '
      Me.mnuCierreGestion3.Key = "mnuCierreGestion"
      Me.mnuCierreGestion3.Name = "mnuCierreGestion3"
      '
      'mnuBalance3
      '
      Me.mnuBalance3.Key = "mnuBalance"
      Me.mnuBalance3.Name = "mnuBalance3"
      '
      'mnuEstadoResultado3
      '
      Me.mnuEstadoResultado3.Key = "mnuEstadoResultado"
      Me.mnuEstadoResultado3.Name = "mnuEstadoResultado3"
      '
      'mnuSumaSaldo3
      '
      Me.mnuSumaSaldo3.Key = "mnuSumaSaldo"
      Me.mnuSumaSaldo3.Name = "mnuSumaSaldo3"
      '
      'mnuCompFecha2
      '
      Me.mnuCompFecha2.Key = "mnuCompFecha"
      Me.mnuCompFecha2.Name = "mnuCompFecha2"
      '
      'mnuLibroIVA3
      '
      Me.mnuLibroIVA3.Key = "mnuLibroIVA"
      Me.mnuLibroIVA3.Name = "mnuLibroIVA3"
      '
      'mnuLibroAgruIVA2
      '
      Me.mnuLibroAgruIVA2.Key = "mnuLibroAgruIVA"
      Me.mnuLibroAgruIVA2.Name = "mnuLibroAgruIVA2"
      '
      'mnuLibroBanco3
      '
      Me.mnuLibroBanco3.Key = "mnuLibroBanco"
      Me.mnuLibroBanco3.Name = "mnuLibroBanco3"
      '
      'mnuLibroITF3
      '
      Me.mnuLibroITF3.Key = "mnuLibroITF"
      Me.mnuLibroITF3.Name = "mnuLibroITF3"
      '
      'mnuLibroDispo2
      '
      Me.mnuLibroDispo2.Key = "mnuLibroDispo"
      Me.mnuLibroDispo2.Name = "mnuLibroDispo2"
      '
      'mnuLibroPlanAdd3
      '
      Me.mnuLibroPlanAdd3.Key = "mnuLibroPlanAdd"
      Me.mnuLibroPlanAdd3.Name = "mnuLibroPlanAdd3"
      '
      'mnuLibroSucursal3
      '
      Me.mnuLibroSucursal3.Key = "mnuLibroSucursal"
      Me.mnuLibroSucursal3.Name = "mnuLibroSucursal3"
      '
      'mnuLibroCentroCosto3
      '
      Me.mnuLibroCentroCosto3.Key = "mnuLibroCentroCosto"
      Me.mnuLibroCentroCosto3.Name = "mnuLibroCentroCosto3"
      '
      'mnuLibroCentroCostoComp2
      '
      Me.mnuLibroCentroCostoComp2.Key = "mnuLibroCentroCostoComp"
      Me.mnuLibroCentroCostoComp2.Name = "mnuLibroCentroCostoComp2"
      '
      'mnuLibroPlanAddCuenta2
      '
      Me.mnuLibroPlanAddCuenta2.Key = "mnuLibroPlanAddCuenta"
      Me.mnuLibroPlanAddCuenta2.Name = "mnuLibroPlanAddCuenta2"
      '
      'mnuLibroPlanAddAna2
      '
      Me.mnuLibroPlanAddAna2.Key = "mnuLibroPlanAddAna"
      Me.mnuLibroPlanAddAna2.Name = "mnuLibroPlanAddAna2"
      '
      'mnuGestion3
      '
      Me.mnuGestion3.Key = "mnuGestion"
      Me.mnuGestion3.Name = "mnuGestion3"
      '
      'mnuParametroSub2
      '
      Me.mnuParametroSub2.Key = "mnuParametroSub"
      Me.mnuParametroSub2.Name = "mnuParametroSub2"
      '
      'mnuTipoCambio3
      '
      Me.mnuTipoCambio3.Key = "mnuTipoCambio"
      Me.mnuTipoCambio3.Name = "mnuTipoCambio3"
      '
      'mnuImpuesto2
      '
      Me.mnuImpuesto2.Key = "mnuImpuesto"
      Me.mnuImpuesto2.Name = "mnuImpuesto2"
      '
      'mnuAyudaDinamica2
      '
      Me.mnuAyudaDinamica2.Key = "mnuAyudaDinamica"
      Me.mnuAyudaDinamica2.Name = "mnuAyudaDinamica2"
      '
      'mnuAboutBox3
      '
      Me.mnuAboutBox3.Key = "mnuAboutBox"
      Me.mnuAboutBox3.Name = "mnuAboutBox3"
      '
      'mnuToolBar2
      '
      Me.mnuToolBar2.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuToolBar2.Key = "mnuToolBar"
      Me.mnuToolBar2.Name = "mnuToolBar2"
      '
      'mnuStatusBar2
      '
      Me.mnuStatusBar2.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuStatusBar2.Key = "mnuStatusBar"
      Me.mnuStatusBar2.Name = "mnuStatusBar2"
      '
      'mnuEmpresaPara3
      '
      Me.mnuEmpresaPara3.Key = "mnuEmpresaPara"
      Me.mnuEmpresaPara3.Name = "mnuEmpresaPara3"
      '
      'mnuCompPara3
      '
      Me.mnuCompPara3.Key = "mnuCompPara"
      Me.mnuCompPara3.Name = "mnuCompPara3"
      '
      'mnuCompParaMes2
      '
      Me.mnuCompParaMes2.Key = "mnuCompParaMes"
      Me.mnuCompParaMes2.Name = "mnuCompParaMes2"
      '
      'mnuReciboPara2
      '
      Me.mnuReciboPara2.Key = "mnuReciboPara"
      Me.mnuReciboPara2.Name = "mnuReciboPara2"
      '
      'mnuEmpresa1
      '
      Me.mnuEmpresa1.Key = "mnuEmpresa"
      Me.mnuEmpresa1.Name = "mnuEmpresa1"
      '
      'mnuPlan1
      '
      Me.mnuPlan1.Key = "mnuPlan"
      Me.mnuPlan1.Name = "mnuPlan1"
      '
      'mnuPlanAdd1
      '
      Me.mnuPlanAdd1.Key = "mnuPlanAdd"
      Me.mnuPlanAdd1.Name = "mnuPlanAdd1"
      '
      'mnuCentroCosto1
      '
      Me.mnuCentroCosto1.Key = "mnuCentroCosto"
      Me.mnuCentroCosto1.Name = "mnuCentroCosto1"
      '
      'mnuSucursal1
      '
      Me.mnuSucursal1.Key = "mnuSucursal"
      Me.mnuSucursal1.Name = "mnuSucursal1"
      '
      'Separator18
      '
      Me.Separator18.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator18.Key = "Separator"
      Me.Separator18.Name = "Separator18"
      '
      'mnuBanco1
      '
      Me.mnuBanco1.Key = "mnuBanco"
      Me.mnuBanco1.Name = "mnuBanco1"
      '
      'mnuCheque1
      '
      Me.mnuCheque1.Key = "mnuCheque"
      Me.mnuCheque1.Name = "mnuCheque1"
      '
      'Separator16
      '
      Me.Separator16.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator16.Key = "Separator"
      Me.Separator16.Name = "Separator16"
      '
      'mnuRegRUC1
      '
      Me.mnuRegRUC1.Key = "mnuRegRUC"
      Me.mnuRegRUC1.Name = "mnuRegRUC1"
      '
      'mnuAduana1
      '
      Me.mnuAduana1.Key = "mnuAduana"
      Me.mnuAduana1.Name = "mnuAduana1"
      '
      'mnuDosifica1
      '
      Me.mnuDosifica1.Key = "mnuDosifica"
      Me.mnuDosifica1.Name = "mnuDosifica1"
      '
      'Separator17
      '
      Me.Separator17.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator17.Key = "Separator"
      Me.Separator17.Name = "Separator17"
      '
      'mnuCiudad1
      '
      Me.mnuCiudad1.Key = "mnuCiudad"
      Me.mnuCiudad1.Name = "mnuCiudad1"
      '
      'mnuRespaldo1
      '
      Me.mnuRespaldo1.Key = "mnuRespaldo"
      Me.mnuRespaldo1.Name = "mnuRespaldo1"
      '
      'mnuComp1
      '
      Me.mnuComp1.Key = "mnuComp"
      Me.mnuComp1.Name = "mnuComp1"
      '
      'mnuCompBloqueo1
      '
      Me.mnuCompBloqueo1.Key = "mnuCompBloqueo"
      Me.mnuCompBloqueo1.Name = "mnuCompBloqueo1"
      '
      'Separator13
      '
      Me.Separator13.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator13.Key = "Separator"
      Me.Separator13.Name = "Separator13"
      '
      'mnuPoliza1
      '
      Me.mnuPoliza1.Key = "mnuPoliza"
      Me.mnuPoliza1.Name = "mnuPoliza1"
      '
      'mnuRecibo1
      '
      Me.mnuRecibo1.Key = "mnuRecibo"
      Me.mnuRecibo1.Name = "mnuRecibo1"
      '
      'Separator19
      '
      Me.Separator19.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator19.Key = "Separator"
      Me.Separator19.Name = "Separator19"
      '
      'mnuLibroMayor1
      '
      Me.mnuLibroMayor1.Key = "mnuLibroMayor"
      Me.mnuLibroMayor1.Name = "mnuLibroMayor1"
      '
      'frmLibroDiario1
      '
      Me.frmLibroDiario1.Key = "mnuLibroDiario"
      Me.frmLibroDiario1.Name = "frmLibroDiario1"
      '
      'Separator14
      '
      Me.Separator14.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator14.Key = "Separator"
      Me.Separator14.Name = "Separator14"
      '
      'mnuAjuste1
      '
      Me.mnuAjuste1.Key = "mnuAjuste"
      Me.mnuAjuste1.Name = "mnuAjuste1"
      '
      'mnuCierreCuenta1
      '
      Me.mnuCierreCuenta1.Key = "mnuCierreCuenta"
      Me.mnuCierreCuenta1.Name = "mnuCierreCuenta1"
      '
      'mnuCierreGestion1
      '
      Me.mnuCierreGestion1.Key = "mnuCierreGestion"
      Me.mnuCierreGestion1.Name = "mnuCierreGestion1"
      '
      'mnuBalance1
      '
      Me.mnuBalance1.Key = "mnuBalance"
      Me.mnuBalance1.Name = "mnuBalance1"
      '
      'mnuEstadoResultado1
      '
      Me.mnuEstadoResultado1.Key = "mnuEstadoResultado"
      Me.mnuEstadoResultado1.Name = "mnuEstadoResultado1"
      '
      'mnuSumaSaldo1
      '
      Me.mnuSumaSaldo1.Key = "mnuSumaSaldo"
      Me.mnuSumaSaldo1.Name = "mnuSumaSaldo1"
      '
      'mnuCompFecha1
      '
      Me.mnuCompFecha1.Key = "mnuCompFecha"
      Me.mnuCompFecha1.Name = "mnuCompFecha1"
      '
      'mnuLibroIVA1
      '
      Me.mnuLibroIVA1.Key = "mnuLibroIVA"
      Me.mnuLibroIVA1.Name = "mnuLibroIVA1"
      '
      'mnuLibroAgruIVA1
      '
      Me.mnuLibroAgruIVA1.Key = "mnuLibroAgruIVA"
      Me.mnuLibroAgruIVA1.Name = "mnuLibroAgruIVA1"
      '
      'mnuLibroBanco1
      '
      Me.mnuLibroBanco1.Key = "mnuLibroBanco"
      Me.mnuLibroBanco1.Name = "mnuLibroBanco1"
      '
      'mnuLibroITF1
      '
      Me.mnuLibroITF1.Key = "mnuLibroITF"
      Me.mnuLibroITF1.Name = "mnuLibroITF1"
      '
      'mnuLibroDispo1
      '
      Me.mnuLibroDispo1.Key = "mnuLibroDispo"
      Me.mnuLibroDispo1.Name = "mnuLibroDispo1"
      '
      'mnuLibroPlanAdd1
      '
      Me.mnuLibroPlanAdd1.Key = "mnuLibroPlanAdd"
      Me.mnuLibroPlanAdd1.Name = "mnuLibroPlanAdd1"
      '
      'mnuLibroSucursal1
      '
      Me.mnuLibroSucursal1.Key = "mnuLibroSucursal"
      Me.mnuLibroSucursal1.Name = "mnuLibroSucursal1"
      '
      'mnuLibroCentroCosto1
      '
      Me.mnuLibroCentroCosto1.Key = "mnuLibroCentroCosto"
      Me.mnuLibroCentroCosto1.Name = "mnuLibroCentroCosto1"
      '
      'mnuLibroCentroCostoComp1
      '
      Me.mnuLibroCentroCostoComp1.Key = "mnuLibroCentroCostoComp"
      Me.mnuLibroCentroCostoComp1.Name = "mnuLibroCentroCostoComp1"
      '
      'mnuLibroPlanAddCuenta1
      '
      Me.mnuLibroPlanAddCuenta1.Key = "mnuLibroPlanAddCuenta"
      Me.mnuLibroPlanAddCuenta1.Name = "mnuLibroPlanAddCuenta1"
      '
      'mnuLibroPlanAddAna1
      '
      Me.mnuLibroPlanAddAna1.Key = "mnuLibroPlanAddAna"
      Me.mnuLibroPlanAddAna1.Name = "mnuLibroPlanAddAna1"
      '
      'mnuGestion1
      '
      Me.mnuGestion1.Key = "mnuGestion"
      Me.mnuGestion1.Name = "mnuGestion1"
      '
      'mnuParametroSub1
      '
      Me.mnuParametroSub1.Key = "mnuParametroSub"
      Me.mnuParametroSub1.Name = "mnuParametroSub1"
      '
      'mnuTipoCambio1
      '
      Me.mnuTipoCambio1.Key = "mnuTipoCambio"
      Me.mnuTipoCambio1.Name = "mnuTipoCambio1"
      '
      'mnuImpuesto1
      '
      Me.mnuImpuesto1.Key = "mnuImpuesto"
      Me.mnuImpuesto1.Name = "mnuImpuesto1"
      '
      'mnuAyudaDinamica1
      '
      Me.mnuAyudaDinamica1.Key = "mnuAyudaDinamica"
      Me.mnuAyudaDinamica1.Name = "mnuAyudaDinamica1"
      '
      'mnuAboutBox1
      '
      Me.mnuAboutBox1.Key = "mnuAboutBox"
      Me.mnuAboutBox1.Name = "mnuAboutBox1"
      '
      'mnuToolBar1
      '
      Me.mnuToolBar1.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuToolBar1.Key = "mnuToolBar"
      Me.mnuToolBar1.Name = "mnuToolBar1"
      '
      'mnuStatusBar1
      '
      Me.mnuStatusBar1.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuStatusBar1.Key = "mnuStatusBar"
      Me.mnuStatusBar1.Name = "mnuStatusBar1"
      '
      'mnuEmpresaPara1
      '
      Me.mnuEmpresaPara1.Key = "mnuEmpresaPara"
      Me.mnuEmpresaPara1.Name = "mnuEmpresaPara1"
      '
      'mnuCompPara1
      '
      Me.mnuCompPara1.Key = "mnuCompPara"
      Me.mnuCompPara1.Name = "mnuCompPara1"
      '
      'mnuCompParaMes1
      '
      Me.mnuCompParaMes1.Key = "mnuCompParaMes"
      Me.mnuCompParaMes1.Name = "mnuCompParaMes1"
      '
      'mnuReciboPara1
      '
      Me.mnuReciboPara1.Key = "mnuReciboPara"
      Me.mnuReciboPara1.Name = "mnuReciboPara1"
      '
      'sbrMain
      '
      Me.sbrMain.Location = New System.Drawing.Point(0, 390)
      Me.sbrMain.Name = "sbrMain"
      UiStatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
      UiStatusBarPanel1.BorderColor = System.Drawing.Color.Empty
      UiStatusBarPanel1.Image = CType(resources.GetObject("UiStatusBarPanel1.Image"), System.Drawing.Image)
      UiStatusBarPanel1.Key = "sbrDataBase"
      UiStatusBarPanel1.ProgressBarValue = 0
      UiStatusBarPanel1.Text = "Base de Datos"
      UiStatusBarPanel1.Width = 143
      UiStatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
      UiStatusBarPanel2.BorderColor = System.Drawing.Color.Empty
      UiStatusBarPanel2.Image = CType(resources.GetObject("UiStatusBarPanel2.Image"), System.Drawing.Image)
      UiStatusBarPanel2.Key = "sbrEnterprice"
      UiStatusBarPanel2.ProgressBarValue = 0
      UiStatusBarPanel2.Text = "Empresa"
      UiStatusBarPanel2.Width = 139
      UiStatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
      UiStatusBarPanel3.BorderColor = System.Drawing.Color.Empty
      UiStatusBarPanel3.Image = CType(resources.GetObject("UiStatusBarPanel3.Image"), System.Drawing.Image)
      UiStatusBarPanel3.Key = "sbrGestion"
      UiStatusBarPanel3.ProgressBarValue = 0
      UiStatusBarPanel3.Text = "Gestion"
      UiStatusBarPanel3.Width = 139
      UiStatusBarPanel4.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
      UiStatusBarPanel4.BorderColor = System.Drawing.Color.Empty
      UiStatusBarPanel4.Image = CType(resources.GetObject("UiStatusBarPanel4.Image"), System.Drawing.Image)
      UiStatusBarPanel4.Key = "sbrLogin"
      UiStatusBarPanel4.ProgressBarValue = 0
      UiStatusBarPanel4.Text = "Login"
      UiStatusBarPanel4.Width = 139
      UiStatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
      UiStatusBarPanel5.BorderColor = System.Drawing.Color.Empty
      UiStatusBarPanel5.Image = CType(resources.GetObject("UiStatusBarPanel5.Image"), System.Drawing.Image)
      UiStatusBarPanel5.Key = "sbrForm"
      UiStatusBarPanel5.ProgressBarValue = 0
      UiStatusBarPanel5.Text = "Formulario"
      UiStatusBarPanel5.Width = 139
      Me.sbrMain.Panels.AddRange(New Janus.Windows.UI.StatusBar.UIStatusBarPanel() {UiStatusBarPanel1, UiStatusBarPanel2, UiStatusBarPanel3, UiStatusBarPanel4, UiStatusBarPanel5})
      Me.sbrMain.PanelsBorderColor = System.Drawing.SystemColors.ControlDark
      Me.sbrMain.Size = New System.Drawing.Size(728, 23)
      Me.sbrMain.TabIndex = 31
      Me.sbrMain.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007
      '
      'mnuEstadoResultadoComp1
      '
      Me.mnuEstadoResultadoComp1.Key = "mnuEstadoResultadoMes"
      Me.mnuEstadoResultadoComp1.Name = "mnuEstadoResultadoComp1"
      '
      'Separator36
      '
      Me.Separator36.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator36.Key = "Separator"
      Me.Separator36.Name = "Separator36"
      '
      'mnuEmpresa6
      '
      Me.mnuEmpresa6.Key = "mnuEmpresa"
      Me.mnuEmpresa6.Name = "mnuEmpresa6"
      '
      'mnuSucursal6
      '
      Me.mnuSucursal6.Key = "mnuSucursal"
      Me.mnuSucursal6.Name = "mnuSucursal6"
      '
      'Separator46
      '
      Me.Separator46.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator46.Key = "Separator"
      Me.Separator46.Name = "Separator46"
      '
      'mnuPlan6
      '
      Me.mnuPlan6.Key = "mnuPlan"
      Me.mnuPlan6.Name = "mnuPlan6"
      '
      'mnuPlanAdd6
      '
      Me.mnuPlanAdd6.Key = "mnuPlanAdd"
      Me.mnuPlanAdd6.Name = "mnuPlanAdd6"
      '
      'Separator47
      '
      Me.Separator47.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator47.Key = "Separator"
      Me.Separator47.Name = "Separator47"
      '
      'mnuCentroCosto6
      '
      Me.mnuCentroCosto6.Key = "mnuCentroCosto"
      Me.mnuCentroCosto6.Name = "mnuCentroCosto6"
      '
      'mnuCentroCostoDet2
      '
      Me.mnuCentroCostoDet2.Key = "mnuCentroCostoDet"
      Me.mnuCentroCostoDet2.Name = "mnuCentroCostoDet2"
      '
      'Separator48
      '
      Me.Separator48.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator48.Key = "Separator"
      Me.Separator48.Name = "Separator48"
      '
      'mnuBanco6
      '
      Me.mnuBanco6.Key = "mnuBanco"
      Me.mnuBanco6.Name = "mnuBanco6"
      '
      'mnuCheque6
      '
      Me.mnuCheque6.Key = "mnuCheque"
      Me.mnuCheque6.Name = "mnuCheque6"
      '
      'Separator49
      '
      Me.Separator49.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator49.Key = "Separator"
      Me.Separator49.Name = "Separator49"
      '
      'mnuRegRUC6
      '
      Me.mnuRegRUC6.Key = "mnuRegRUC"
      Me.mnuRegRUC6.Name = "mnuRegRUC6"
      '
      'mnuAduana5
      '
      Me.mnuAduana5.Key = "mnuAduana"
      Me.mnuAduana5.Name = "mnuAduana5"
      '
      'mnuDosifica5
      '
      Me.mnuDosifica5.Key = "mnuDosifica"
      Me.mnuDosifica5.Name = "mnuDosifica5"
      '
      'Separator50
      '
      Me.Separator50.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator50.Key = "Separator"
      Me.Separator50.Name = "Separator50"
      '
      'mnuCiudad6
      '
      Me.mnuCiudad6.Key = "mnuCiudad"
      Me.mnuCiudad6.Name = "mnuCiudad6"
      '
      'mnuRespaldo5
      '
      Me.mnuRespaldo5.Key = "mnuRespaldo"
      Me.mnuRespaldo5.Name = "mnuRespaldo5"
      '
      'mnuComp6
      '
      Me.mnuComp6.Key = "mnuComp"
      Me.mnuComp6.Name = "mnuComp6"
      '
      'mnuCompBloqueo5
      '
      Me.mnuCompBloqueo5.Key = "mnuCompBloqueo"
      Me.mnuCompBloqueo5.Name = "mnuCompBloqueo5"
      '
      'Separator51
      '
      Me.Separator51.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator51.Key = "Separator"
      Me.Separator51.Name = "Separator51"
      '
      'mnuPoliza5
      '
      Me.mnuPoliza5.Key = "mnuPoliza"
      Me.mnuPoliza5.Name = "mnuPoliza5"
      '
      'mnuRecibo5
      '
      Me.mnuRecibo5.Key = "mnuRecibo"
      Me.mnuRecibo5.Name = "mnuRecibo5"
      '
      'Separator52
      '
      Me.Separator52.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator52.Key = "Separator"
      Me.Separator52.Name = "Separator52"
      '
      'mnuLibroMayor6
      '
      Me.mnuLibroMayor6.Key = "mnuLibroMayor"
      Me.mnuLibroMayor6.Name = "mnuLibroMayor6"
      '
      'mnuLibroDiario4
      '
      Me.mnuLibroDiario4.Key = "mnuLibroDiario"
      Me.mnuLibroDiario4.Name = "mnuLibroDiario4"
      '
      'Separator53
      '
      Me.Separator53.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator53.Key = "Separator"
      Me.Separator53.Name = "Separator53"
      '
      'mnuAjuste6
      '
      Me.mnuAjuste6.Key = "mnuAjuste"
      Me.mnuAjuste6.Name = "mnuAjuste6"
      '
      'mnuCierreCuenta6
      '
      Me.mnuCierreCuenta6.Key = "mnuCierreCuenta"
      Me.mnuCierreCuenta6.Name = "mnuCierreCuenta6"
      '
      'mnuCierreGestion6
      '
      Me.mnuCierreGestion6.Key = "mnuCierreGestion"
      Me.mnuCierreGestion6.Name = "mnuCierreGestion6"
      '
      'mnuBalance6
      '
      Me.mnuBalance6.Key = "mnuBalance"
      Me.mnuBalance6.Name = "mnuBalance6"
      '
      'mnuEstadoResultado6
      '
      Me.mnuEstadoResultado6.Key = "mnuEstadoResultado"
      Me.mnuEstadoResultado6.Name = "mnuEstadoResultado6"
      '
      'mnuSumaSaldo6
      '
      Me.mnuSumaSaldo6.Key = "mnuSumaSaldo"
      Me.mnuSumaSaldo6.Name = "mnuSumaSaldo6"
      '
      'mnuCompFecha5
      '
      Me.mnuCompFecha5.Key = "mnuCompFecha"
      Me.mnuCompFecha5.Name = "mnuCompFecha5"
      Me.mnuCompFecha5.Text = "Listado de Comprobantes"
      '
      'mnuLibroIVA6
      '
      Me.mnuLibroIVA6.Key = "mnuLibroIVA"
      Me.mnuLibroIVA6.Name = "mnuLibroIVA6"
      '
      'mnuLibroAgruIVA5
      '
      Me.mnuLibroAgruIVA5.Key = "mnuLibroAgruIVA"
      Me.mnuLibroAgruIVA5.Name = "mnuLibroAgruIVA5"
      '
      'mnuLibroBanco6
      '
      Me.mnuLibroBanco6.Key = "mnuLibroBanco"
      Me.mnuLibroBanco6.Name = "mnuLibroBanco6"
      '
      'mnuLibroITF6
      '
      Me.mnuLibroITF6.Key = "mnuLibroITF"
      Me.mnuLibroITF6.Name = "mnuLibroITF6"
      '
      'mnuLibroDispo5
      '
      Me.mnuLibroDispo5.Key = "mnuLibroDispo"
      Me.mnuLibroDispo5.Name = "mnuLibroDispo5"
      '
      'mnuLibroPlanAdd6
      '
      Me.mnuLibroPlanAdd6.Key = "mnuLibroPlanAdd"
      Me.mnuLibroPlanAdd6.Name = "mnuLibroPlanAdd6"
      '
      'mnuLibroSucursal6
      '
      Me.mnuLibroSucursal6.Key = "mnuLibroSucursal"
      Me.mnuLibroSucursal6.Name = "mnuLibroSucursal6"
      '
      'mnuLibroCentroCosto6
      '
      Me.mnuLibroCentroCosto6.Key = "mnuLibroCentroCosto"
      Me.mnuLibroCentroCosto6.Name = "mnuLibroCentroCosto6"
      '
      'Separator54
      '
      Me.Separator54.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
      Me.Separator54.Key = "Separator"
      Me.Separator54.Name = "Separator54"
      '
      'mnuEstadoResultadoMes2
      '
      Me.mnuEstadoResultadoMes2.Key = "mnuEstadoResultadoMes"
      Me.mnuEstadoResultadoMes2.Name = "mnuEstadoResultadoMes2"
      '
      'mnuLibroCentroCostoMes2
      '
      Me.mnuLibroCentroCostoMes2.Key = "mnuLibroCentroCostoMes"
      Me.mnuLibroCentroCostoMes2.Name = "mnuLibroCentroCostoMes2"
      '
      'mnuLibroPlanAddCuenta5
      '
      Me.mnuLibroPlanAddCuenta5.Key = "mnuLibroPlanAddCuenta"
      Me.mnuLibroPlanAddCuenta5.Name = "mnuLibroPlanAddCuenta5"
      '
      'mnuLibroPlanAddAna5
      '
      Me.mnuLibroPlanAddAna5.Key = "mnuLibroPlanAddAna"
      Me.mnuLibroPlanAddAna5.Name = "mnuLibroPlanAddAna5"
      '
      'mnuGestion6
      '
      Me.mnuGestion6.Key = "mnuGestion"
      Me.mnuGestion6.Name = "mnuGestion6"
      '
      'mnuOpera2
      '
      Me.mnuOpera2.Key = "mnuOpera"
      Me.mnuOpera2.Name = "mnuOpera2"
      '
      'mnuParametroSub5
      '
      Me.mnuParametroSub5.Key = "mnuParametroSub"
      Me.mnuParametroSub5.Name = "mnuParametroSub5"
      '
      'mnuTipoCambio6
      '
      Me.mnuTipoCambio6.Key = "mnuTipoCambio"
      Me.mnuTipoCambio6.Name = "mnuTipoCambio6"
      '
      'mnuImpuesto5
      '
      Me.mnuImpuesto5.Key = "mnuImpuesto"
      Me.mnuImpuesto5.Name = "mnuImpuesto5"
      '
      'mnuAyudaDinamica5
      '
      Me.mnuAyudaDinamica5.Key = "mnuAyudaDinamica"
      Me.mnuAyudaDinamica5.Name = "mnuAyudaDinamica5"
      '
      'mnuAboutBox6
      '
      Me.mnuAboutBox6.Key = "mnuAboutBox"
      Me.mnuAboutBox6.Name = "mnuAboutBox6"
      '
      'mnuToolBar5
      '
      Me.mnuToolBar5.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuToolBar5.Key = "mnuToolBar"
      Me.mnuToolBar5.Name = "mnuToolBar5"
      '
      'mnuStatusBar5
      '
      Me.mnuStatusBar5.Checked = Janus.Windows.UI.InheritableBoolean.[True]
      Me.mnuStatusBar5.Key = "mnuStatusBar"
      Me.mnuStatusBar5.Name = "mnuStatusBar5"
      '
      'mnuEmpresaPara6
      '
      Me.mnuEmpresaPara6.Key = "mnuEmpresaPara"
      Me.mnuEmpresaPara6.Name = "mnuEmpresaPara6"
      '
      'mnuCompPara6
      '
      Me.mnuCompPara6.Key = "mnuCompPara"
      Me.mnuCompPara6.Name = "mnuCompPara6"
      '
      'mnuCompParaMes5
      '
      Me.mnuCompParaMes5.Key = "mnuCompParaMes"
      Me.mnuCompParaMes5.Name = "mnuCompParaMes5"
      '
      'mnuReciboPara5
      '
      Me.mnuReciboPara5.Key = "mnuReciboPara"
      Me.mnuReciboPara5.Name = "mnuReciboPara5"
      '
      'gexMain
      '
      Me.gexMain.SheetName = "Hoja1"
      '
      'mnuProvincia
      '
      Me.mnuProvincia.Key = "mnuProvincia"
      Me.mnuProvincia.Name = "mnuProvincia"
      Me.mnuProvincia.Text = "Provincias"
      '
      'mnuProvincia1
      '
      Me.mnuProvincia1.Key = "mnuProvincia"
      Me.mnuProvincia1.Name = "mnuProvincia1"
      '
      'frmMain
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.Color.AliceBlue
      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.ClientSize = New System.Drawing.Size(728, 413)
      Me.Controls.Add(Me.sbrMain)
      Me.Controls.Add(Me.TopRebar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.IsMdiContainer = True
      Me.Name = "frmMain"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "DelfinNet - Módulo de Contabilidad"
      Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
      CType(Me.cdmMain, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.Menu1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ToolBar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.ToolSet1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TopRebar1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Call FormBackgroundImage()
      Call StatusDataBaseDisplay(clsAppInfo.DataBaseSource & "." & clsAppInfo.DataBaseName)
      Call SecurityParaLoad(1)

      Dim frm As New frmLogin
      frm.ShowDialog()

      Call PreferenceLoad(clsAppInfo.AppId, clsAppInfo.UserId)
      Call StatusGestionDisplay(ToStr(clsAppInfo.Gestion))
      Call EmpresaParaLoad(clsAppInfo.EmpresaId)
      Call StatusEnterpriseDisplay(clsAppInfo.EmpresaDes)
      Call ImpuestoLoad()
      Call CompParaCheck()

      Call SecuritySet(Me, AppExeName)

      Call TipoCambioCheck()

      Call ClearMemory()

      '*BITACORA
      Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.INICIO_SESION, "Inicio de Sesión Usuario Id. : " + clsAppInfo.UserId.ToString + _
                                    " Login : " + clsAppInfo.LoginId.ToString + "  " + clsAppInfo.UserName.ToString & "; Empresa: " & clsAppInfo.EmpresaDes & "; Gestión: " & clsAppInfo.Gestion)

   End Sub

   Private Sub TipoCambioCheck()
      Dim oTipoCambio As New clsTipoCambio(clsAppInfo.ConnectString)

      Try
         With oTipoCambio
            .SelectFilter = clsTipoCambio.SelectFilters.All
            .WhereFilter = clsTipoCambio.WhereFilters.Fecha
            .Fecha = ToDate(Now.Date)

            If Not .Find Then
               If MessageBox.Show("No Existe Tipo de Cambio para Hoy, ¿Desea Insertarlo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                  Dim frm As New frmTipoCambioEdit

                  With frm
                     .NewRecord = True
                     .Editing = False

                     oTipoCambio.Fecha = ToDateDMY(Now.Date)

                     .DataObject = oTipoCambio
                     .ShowDialog()

                     If .Changed Then
                     End If

                     frm.Dispose()
                  End With
               End If
            End If
         End With

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      Finally
         oTipoCambio.Dispose()

      End Try
   End Sub

   Private Sub FormBackgroundImage()
      Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
      Dim decDesktopScala As Decimal = Math.Truncate(desktopSize.Width / desktopSize.Height * 100) / 100
      Dim strDesktopSize As String

      Select Case decDesktopScala
         Case 1.33 '4x3
            strDesktopSize = "PC4x3.jpg"

         Case 1.77 '16x9
            strDesktopSize = "PC16x9.jpg"

         Case 1.6 '16x10
            strDesktopSize = "PC16x10.jpg"

         Case Else
            strDesktopSize = "Nothing.jpg"
      End Select

      Try
         If System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory() & strDesktopSize) Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & strDesktopSize)

         Else
            Call FormBackgroundImageStretch(desktopSize.Width, desktopSize.Height)
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End Try
   End Sub

   Private Sub FormBackgroundImageStretch(ByVal intWidth As Integer, ByVal intHeight As Integer)
      Dim strDirectory As String = Application.StartupPath
      Dim strDirFiles() As String = System.IO.Directory.GetFiles(strDirectory, "*.jpg")
      Dim intImageWidth As Long = 0
      Dim intImageHeight As Long = 0
      Dim strImage As String = ""
      Dim i As Integer

      For i = 0 To strDirFiles.Length - 1
         strImage = strDirFiles(i).Substring(strDirectory.Length + 1, strDirFiles(i).Length - strDirectory.Length - 5)
         intImageWidth = ToImageWidth(strImage)

         If intWidth = intImageWidth Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & strImage & ".jpg")

            Exit Sub
         End If
      Next

      For i = 0 To strDirFiles.Length - 1
         strImage = strDirFiles(i).Substring(strDirectory.Length + 1, strDirFiles(i).Length - strDirectory.Length - 5)
         intImageHeight = ToImageHeight(strImage)

         If intHeight = intImageHeight Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & strImage & ".jpg")

            Exit Sub
         End If
      Next

      If intImageWidth > 0 Then
         Me.BackgroundImage = System.Drawing.Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() & strImage & ".jpg")

      Else
         Call FormBackColor()
      End If
   End Sub

   Function ToImageWidth(ByVal strValue As String) As Integer
      If Len(strValue) > 0 Then
         Dim strAux As String = ""

         For i As Integer = 3 To strValue.Length
            If IsNumeric(Mid$(strValue, i, 1)) Then
               strAux &= Mid$(strValue, i, 1)
            Else
               Exit For
            End If
         Next

         If Len(strAux) > 0 Then
            Return ToInteger(strAux)
         Else
            Return 0
         End If

      Else
         Return strValue
      End If
   End Function

   Function ToImageHeight(ByVal strValue As String) As Integer
      If Len(strValue) > 0 Then
         Dim strAux As String = ""

         For i = strValue.Length To 1 Step -1
            If IsNumeric(Mid$(strValue, i, 1)) Then
               strAux = Mid$(strValue, i, 1) & strAux
            Else
               Exit For
            End If
         Next

         If Len(strAux) > 0 Then
            Return ToInteger(strAux)
         Else
            Return 0
         End If

      Else
         Return strValue
      End If
   End Function

   Private Sub FormBackColor()
      Dim ctl As Control

      For Each ctl In Me.Controls
         Try
            ctlMDI = CType(ctl, MdiClient)
            ctlMDI.BackColor = Color.AntiqueWhite

            AddHandler ctlMDI.Paint, AddressOf PintarFondo

         Catch ex As InvalidCastException

         End Try
      Next
   End Sub

   Private Sub PintarFondo(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
      If (ctlMDI.Width > 0) And (ctlMDI.Height > 0) Then
         Dim GradientePanel As New System.Drawing.Drawing2D.LinearGradientBrush(New RectangleF(0, 0, ctlMDI.Width, ctlMDI.Height), Color.MediumBlue, Color.WhiteSmoke, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
         e.Graphics.FillRectangle(GradientePanel, New RectangleF(0, 0, ctlMDI.Width, ctlMDI.Height))
      End If
   End Sub

   Private Sub TfrmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
      If Not (Me.ctlMDI Is Nothing) Then
         Me.PintarFondo(Me.ctlMDI, New PaintEventArgs(Me.ctlMDI.CreateGraphics, New Rectangle(Me.ctlMDI.Location, Me.ctlMDI.Size)))
      End If
   End Sub

   Private Sub cdmMain_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cdmMain.CommandClick
      Select Case e.Command.Key
         Case "mnuEmpresa"
            Dim frm As New frmEmpresa
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuSucursal"
            Dim frm As New frmSucursal
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPlan"
            Dim frm As New frmPlan
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPlanAdd"
            Dim frm As New frmPlanAdd
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCentroCosto"
            Dim frm As New frmCentroCosto
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCentroCostoDet"
            Dim frm As New frmCentroCostoDet
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuBanco"
            Dim frm As New frmBanco
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCheque"
            Dim frm As New frmCheque
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuRegRUC"
            Dim frm As New frmRegRUC
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuAduana"
            Dim frm As New frmAduana
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuDosifica"
            Dim frm As New frmDosifica
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuTipoActEco"
            Dim frm As New frmTipoActEco
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuDosificaLey"
            Dim frm As New frmDosificaLey
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPoliza"
            Dim frm As New frmPoliza
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPais"
            Dim frm As New frmPais
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuDepartamento"
            Dim frm As New frmDepartamento
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuProvincia"
            Dim frm As New frmProvincia
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuCiudad"
            Dim frm As New frmCiudad
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuRespaldo"
            Dim frm As New frmRespaldo
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuComp"
            Dim frm As New frmComp
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCompBloqueo"
            Dim frm As New frmCompBloqueoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCompFecha"
            Dim frm As New frmCompFechaFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroMayor"
            Dim frm As New frmLibroMayorFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroMayorAnalisis"
            Dim frm As New frmLibroMayorAnalisisFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroMayorDet"
            Dim frm As New frmLibroMayorDetFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroMayorDuo"
            Dim frm As New frmLibroMayorDuoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroMayorComparativo"
            Dim frm As New frmLibroMayorComparativoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroDiario"
            Dim frm As New frmLibroDiarioFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuHojaTrabajo"
            Dim frm As New frmSumaSaldoAnalisisFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuRecibo"
            Dim frm As New frmRecibo
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuAjuste"
            Dim frm As New frmAjusteMoneda
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCierreCuenta"
            'Dim frm As New frmAjusteUFV
            'With frm
            '   .MdiParent = Me
            '   .EmpresaId = clsAppInfo.EmpresaId
            '   .Show()
            'End With

            Dim frm As New frmCierreCuentaSucCCO
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCierreGestion"
            Dim frm As New frmCierreGestionSucCCO
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuBalance"
            Dim frm As New frmBalanceFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuEstadoResultadoGeneral"
            Dim frm As New frmEstadoResultadoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuEstadoResultadoAct"
            Dim frm As New frmEstadoResultadoActFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuSumaSaldoGeneral"
            Dim frm As New frmSumaSaldoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuSumaSaldoAnalisis"
            Dim frm As New frmSumaSaldoAnalisisFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuSumaSaldoComparativo"
            Dim frm As New frmSumaSaldoComparativoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuSumaSaldoComparativoCC"
            Dim frm As New frmSumaSaldoComparativoCCFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroIVA-NSF"
            Dim frm As New frmLibroIVANSFFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroIVA-SFV"
            Dim frm As New frmLibroIVAFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroIVACC"
            Dim frm As New frmLibroIVACCFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroAgruIVA"
            Dim frm As New frmLibroAgruIVAFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroRetencion"
            Dim frm As New frmLibroRetencionFind

            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroBanco"
            Dim frm As New frmLibroBancoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroCheque"
            Dim frm As New frmLibroChequeFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuConciliaBanco"
            Dim frm As New frmConciliaBancoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroITF"
            Dim frm As New frmLibroITFFind

            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroDispoGeneral"
            Dim frm As New frmLibroDispoFind

            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroDispoComparativo"
            Dim frm As New frmLibroDispoComparativoFind

            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuFlujoEfectivoDet"
            Dim frm As New frmFlujoEfectivoDetFind

            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroPlanAddCuenta"
            Dim frm As New frmLibroPlanAddFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroPlanAddAna"
            Dim frm As New frmLibroPlanAddAnaFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroCentroCostoDet"
            Dim frm As New frmLibroCentroCostoDetFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroCentroCostoDetAct"
            Dim frm As New frmLibroCentroCostoDetActFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroCentroCostoDetActEmpresa"
            Dim frm As New frmLibroCentroCostoDetActEmpresasFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroCentroCosto"
            Dim frm As New frmLibroCentroCostoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroSucursal"
            Dim frm As New frmLibroSucursalFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuLibroCentroCostoMes"
            Dim frm As New frmLibroCentroCostoMesFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuEstadoResultadoEmpresas"
            Dim frm As New frmEstadoResultadoComparativoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuBalanceComparativo"
            Dim frm As New frmBalanceComparativoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuFlujoEfectivoFind"
            Dim frm As New frmMovFlujoEfectivoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuEstadoFlujoEfectivoFind"
            Dim frm As New frmEstadoFlujoEfectivoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuPlanEEFF"
            Dim frm As New frmPlanEEFF
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuGestion"
            Dim frm As New frmGestion
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuEmpresaPara"
            Dim frm As New frmEmpresaPara

            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCompPara"
            Dim frm As New frmCompPara

            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuCompParaMes"
            Dim frm As New frmCompParaMes

            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuReciboPara"
            Dim frm As New frmReciboPara

            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuTipoCambio"
            Dim frm As New frmTipoCambio
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuImpuesto"
            Dim frm As New frmImpuesto
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuWizard"
            Dim frm As New frmWizard
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuDataBaseBackup"
            Dim frm As New frmDataBaseBackup
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuDataBaseImport"
            Dim frm As New frmDataBaseImport
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuDataSecurityImport"
            Dim frm As New frmDataSecurityImport
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "mnuChequeOpen"
            Dim frm As New frmCompChequeOpen
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuEstadoResultadoCC"
            Dim frm As New frmEstadoResultadoCCFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "mnuToolBar"
            mnuToolBar1.IsChecked = Not mnuToolBar1.IsChecked
            ToolBar1.Visible = mnuToolBar1.IsChecked

         Case "mnuStatusBar"
            mnuStatusBar1.IsChecked = Not mnuStatusBar1.IsChecked
            sbrMain.Visible = mnuStatusBar1.IsChecked

         Case "mnuAyudaDinamica"

         Case "mnuAboutBox"
            Dim frm As New frmAboutBox

            With frm
               .MdiParent = Me
               .Show()
            End With


            'ToolSet 
         Case "btnExcel"
            Call ExportToExcelActiveMdiChild()

         Case "btnFilter"
            Call FilterConditionActiveMdiChild()

         Case "btnSort"
            Call SortKeysActiveMdiChild()


            'ToolBar 
         Case "btnEmpresa"
            Dim frm As New frmEmpresa
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "btnPlan"
            Dim frm As New frmPlan
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnComp"
            Dim frm As New frmComp
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnLibroMayor"
            Dim frm As New frmLibroMayorFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnBalance"
            Dim frm As New frmBalanceFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnEstadoResultado"
            Dim frm As New frmEstadoResultadoFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnLibroIVA"
            Dim frm As New frmLibroIVAFind
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnEmpresaPara"
            Dim frm As New frmEmpresaPara
            With frm
               .MdiParent = Me
               .EmpresaId = clsAppInfo.EmpresaId
               .Show()
            End With

         Case "btnTipoCambio"
            Dim frm As New frmTipoCambio
            With frm
               .MdiParent = Me
               .Show()
            End With

         Case "btnCalculadora"
            Dim oProcess As New Process
            oProcess.StartInfo.FileName = "calc.exe"
            oProcess.StartInfo.Arguments = ""
            oProcess.Start()

         Case "btnUserPass"
            Dim frm As New frmUserPass
            With frm
               .UserId = clsAppInfo.UserId
               .MdiParent = Me
               .Show()
            End With

         Case "btnHelp"
            If Dir(clsAppInfo.HelpIndex) <> "" Then
               Dim proc As New Process
               proc.StartInfo.FileName = clsAppInfo.HelpIndex
               proc.StartInfo.Arguments = ""
               proc.Start()
            Else
               MessageBox.Show("Documento No Encontrado en la Ruta Especificada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "btnHelpVideo"
            If Dir(clsAppInfo.HelpVideo) <> "" Then
               Dim proc As New Process
               proc.StartInfo.FileName = clsAppInfo.HelpVideo
               proc.StartInfo.Arguments = ""
               proc.Start()
            Else
               MessageBox.Show("Documento No Encontrado en la Ruta Especificada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

         Case "btnExit"
            Me.Close()

         Case "btnSeguridad"
            Call ProcessStart(DLLPath, "Seguridad\Seguridad.exe")

         Case "btnContabilidad"
            Call ProcessStart(DLLPath, "Contabilidad\Contabilidad.exe")

         Case "btnInventario"
            Call ProcessStart(DLLPath, "Inventario\Inventario.exe")

         Case "btnCompras"
            Call ProcessStart(DLLPath, "Compras\Compras.exe")

         Case "btnVentas"
            Call ProcessStart(DLLPath, "Ventas\Ventas.exe")

      End Select
   End Sub

   Private Sub ExportToExcelActiveMdiChild()
      Try
         If Not Me.ActiveMdiChild Is Nothing Then
            For Each oControl01 In Me.ActiveMdiChild.Controls
               For Each oControl02 In oControl01.Controls
                  For Each oControl03 In oControl02.Controls
                     For Each oControl04 In oControl03.Controls
                        For Each oControl05 In oControl04.Controls
                           Call ExportToExcelActiveMdiChild(oControl05)
                        Next

                        Call ExportToExcelActiveMdiChild(oControl04)
                     Next

                     Call ExportToExcelActiveMdiChild(oControl03)
                  Next

                  Call ExportToExcelActiveMdiChild(oControl02)
               Next

               Call ExportToExcelActiveMdiChild(oControl01)
            Next
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub FilterConditionActiveMdiChild()
      Try
         If Not Me.ActiveMdiChild Is Nothing Then
            For Each oControl01 In Me.ActiveMdiChild.Controls
               For Each oControl02 In oControl01.Controls
                  For Each oControl03 In oControl02.Controls
                     For Each oControl04 In oControl03.Controls
                        For Each oControl05 In oControl04.Controls
                           Call FilterConditionActiveMdiChild(oControl05)
                        Next

                        Call FilterConditionActiveMdiChild(oControl04)
                     Next

                     Call FilterConditionActiveMdiChild(oControl03)
                  Next

                  Call FilterConditionActiveMdiChild(oControl02)
               Next

               Call FilterConditionActiveMdiChild(oControl01)
            Next
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub SortKeysActiveMdiChild()
      Try
         If Not Me.ActiveMdiChild Is Nothing Then
            For Each oControl01 In Me.ActiveMdiChild.Controls
               For Each oControl02 In oControl01.Controls
                  For Each oControl03 In oControl02.Controls
                     For Each oControl04 In oControl03.Controls
                        For Each oControl05 In oControl04.Controls
                           Call SortKeysActiveMdiChild(oControl05)
                        Next

                        Call SortKeysActiveMdiChild(oControl04)
                     Next

                     Call SortKeysActiveMdiChild(oControl03)
                  Next

                  Call SortKeysActiveMdiChild(oControl02)
               Next

               Call SortKeysActiveMdiChild(oControl01)
            Next
         End If

      Catch exp As Exception
         MessageBox.Show(exp.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      End Try
   End Sub

   Private Sub ExportToExcelActiveMdiChild(ByRef oControl As Control)
      If TypeOf oControl Is Janus.Windows.GridEX.GridEX Then
         Dim sfd As New SaveFileDialog
         sfd.Title = "Export Report Document"
         sfd.AddExtension = True
         sfd.DefaultExt = "xls"
         sfd.Filter = "Microsoft Excel Files (*.xls)|*.xls"

         If sfd.ShowDialog() = DialogResult.OK Then
            Dim fs As New System.IO.FileStream(sfd.FileName, IO.FileMode.Create, IO.FileAccess.ReadWrite)
            Dim oGrid As Janus.Windows.GridEX.GridEX = CType(oControl, Janus.Windows.GridEX.GridEX)

            gexMain.GridEX = oGrid
            gexMain.Export(fs)

            fs.Close()

            Call modAuditoria.AudiOpeAdd(Me.ActiveMdiChild.Name, Me.ActiveMdiChild.Text, clsTipoOpera.EXPORTAR, "Exportar grilla a Formato Excel")
         End If
      End If
   End Sub

   Private Sub FilterConditionActiveMdiChild(ByRef oControl As Control)
      If TypeOf oControl Is Janus.Windows.GridEX.GridEX Then
         Dim oGrid As Janus.Windows.GridEX.GridEX = CType(oControl, Janus.Windows.GridEX.GridEX)
         Dim frm As New frmFilter

         frm.oGrid = oGrid
         frm.ShowDialog()

         If frm.Changed Then
            CType(oControl, Janus.Windows.GridEX.GridEX).RootTable.FilterCondition = frm.oFilterCondition
         End If

         frm.Dispose()
      End If
   End Sub

   Private Sub SortKeysActiveMdiChild(ByRef oControl As Control)
      If TypeOf oControl Is Janus.Windows.GridEX.GridEX Then
         Dim oGrid As Janus.Windows.GridEX.GridEX = CType(oControl, Janus.Windows.GridEX.GridEX)
         Dim frm As New frmSort

         frm.oGrid = oGrid
         frm.ShowDialog()

         If frm.Changed Then
            CType(oControl, Janus.Windows.GridEX.GridEX).RootTable.SortKeys.Clear()
            CType(oControl, Janus.Windows.GridEX.GridEX).RootTable.SortKeys.AddRange(frm.oSortKeys)
         End If

         frm.Dispose()
      End If
   End Sub

   Public Sub CloseAllMdiChild()
      For Each frm As Form In Me.MdiChildren
         frm.Close()
      Next
   End Sub

   Private Sub ProcessStart(ByVal strPath As String, ByVal strApp As String)
      Do While Microsoft.VisualBasic.Right(strPath, 1) <> "\"
         strPath = Microsoft.VisualBasic.Left(strPath, strPath.Length - 1)
      Loop

      strPath &= strApp

      If Dir(strPath) <> "" Then
         Dim proc As New Process
         proc.StartInfo.FileName = strPath
         proc.StartInfo.Arguments = ""
         proc.Start()
      Else
         MessageBox.Show("Aplicación No Encontrada en la Ruta Especificada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
   End Sub

   Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
      If MessageBox.Show("¿Realmente Quiere Salir del Sistema?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
         e.Cancel = True
      Else
         '*BITACORA 
         Call modAuditoria.AudiOpeAdd(Me.Name, Me.Text, clsTipoOpera.CIERRE_SESION, "Cierre de Sesión. Usuario Id. : " + clsAppInfo.UserId.ToString + _
                                       " Login : " + clsAppInfo.LoginId.ToString + "  " + clsAppInfo.UserName.ToString)
      End If
   End Sub

End Class
