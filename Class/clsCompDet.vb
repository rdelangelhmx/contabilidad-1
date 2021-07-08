Imports System.Data
Imports System.Data.OleDb

Public Class clsCompDet
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsCompDetVM
   Public VMNew As clsCompDetVM

   Private mlngCompDetId As Long
   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompId As Long
   Private mstrFecha As String
   Private mlngPlanId As Long
   Private mstrCompDetDes As String
   Private mlngSucursalId As Long
   Private mlngCentroCostoId As Long
   Private mlngTipoRetencionId As Long
   Private mlngMonedaId As Long
   Private mdecDebeOrg As Decimal
   Private mdecHaberOrg As Decimal
   Private mdecDebeBs As Decimal
   Private mdecHaberBs As Decimal
   Private mdecDebeUs As Decimal
   Private mdecHaberUs As Decimal
   Private mlngOrden As Long
   Private mbytAutomatico As Byte
   Private mlngEstadoId As Long
   Private mlngCompDetIdOrg As Long
   Private mlngTipoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   Public Const DESCUENTO As Byte = 1

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CompDetId() As Long
      Get
         Return mlngCompDetId
      End Get

      Set(ByVal Value As Long)
         mlngCompDetId = Value
      End Set
   End Property

   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property CompId() As Long
      Get
         Return mlngCompId
      End Get

      Set(ByVal Value As Long)
         mlngCompId = Value
      End Set
   End Property

   Property GestionId() As Long
      Get
         Return mlngGestionId
      End Get

      Set(ByVal Value As Long)
         mlngGestionId = Value
      End Set
   End Property

   Property TipoCompId() As Long
      Get
         Return mlngTipoCompId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCompId = Value
      End Set
   End Property

   Property Fecha() As String
      Get
         Return mstrFecha
      End Get

      Set(ByVal Value As String)
         mstrFecha = Value
      End Set
   End Property

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
      End Set
   End Property

   Property CompDetDes() As String
      Get
         Return mstrCompDetDes
      End Get

      Set(ByVal Value As String)
         mstrCompDetDes = Value
      End Set
   End Property

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
      End Set
   End Property

   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   Property TipoRetencionId() As Long
      Get
         Return mlngTipoRetencionId
      End Get

      Set(ByVal Value As Long)
         mlngTipoRetencionId = Value
      End Set
   End Property

   Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngMonedaId = Value
      End Set
   End Property

   Property DebeOrg() As Decimal
      Get
         Return mdecDebeOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecDebeOrg = Value
      End Set
   End Property

   Property HaberOrg() As Decimal
      Get
         Return mdecHaberOrg
      End Get

      Set(ByVal Value As Decimal)
         mdecHaberOrg = Value
      End Set
   End Property

   Property DebeBs() As Decimal
      Get
         Return mdecDebeBs
      End Get

      Set(ByVal Value As Decimal)
         mdecDebeBs = Value
      End Set
   End Property

   Property HaberBs() As Decimal
      Get
         Return mdecHaberBs
      End Get

      Set(ByVal Value As Decimal)
         mdecHaberBs = Value
      End Set
   End Property

   Property DebeUs() As Decimal
      Get
         Return mdecDebeUs
      End Get

      Set(ByVal Value As Decimal)
         mdecDebeUs = Value
      End Set
   End Property

   Property HaberUs() As Decimal
      Get
         Return mdecHaberUs
      End Get

      Set(ByVal Value As Decimal)
         mdecHaberUs = Value
      End Set
   End Property

   Property Orden() As Long
      Get
         Return mlngOrden
      End Get

      Set(ByVal Value As Long)
         mlngOrden = Value
      End Set
   End Property

   Property Automatico() As Byte
      Get
         Return mbytAutomatico
      End Get

      Set(ByVal Value As Byte)
         mbytAutomatico = Value
      End Set
   End Property

   Property EstadoId() As Long
      Get
         Return mlngEstadoId
      End Get

      Set(ByVal Value As Long)
         mlngEstadoId = Value
      End Set
   End Property

   Property CompDetIdOrg() As Long
      Get
         Return mlngCompDetIdOrg
      End Get
      Set(ByVal value As Long)
         mlngCompDetIdOrg = value
      End Set
   End Property

   Property TipoId() As Long
      Get
         Return mlngTipoId
      End Get
      Set(ByVal value As Long)
         mlngTipoId = value
      End Set
   End Property

   '******************************************************
   ' Private Data To Concurrency Table Definition
   '******************************************************
   Property LastUpdateId() As String
      Get
         Return mstrLastUpdateId
      End Get

      Set(ByVal Value As String)
         mstrLastUpdateId = Value
      End Set
   End Property

   Property LastUpdateDate() As String
      Get
         Return mstrLastUpdateDate
      End Get

      Set(ByVal Value As String)
         mstrLastUpdateDate = Value
      End Set
   End Property

   Property ConcurrencyId() As Integer
      Get
         Return mintConcurrencyId
      End Get

      Set(ByVal Value As Integer)
         mintConcurrencyId = Value
      End Set
   End Property

   '******************************************************
   '* The following enumerations will change for each
   '* data access class
   '******************************************************
   Public Enum SelectFilters As Byte
      All = 0
      ListBox = 1
      Grid = 2
      LibroMayorCuenta = 3
      LibroMayorGeneral = 4
      SumaSaldo = 5
      LibroBancoCuenta = 6
      LibroBancoGeneral = 7
      SucursalPlan = 8
      CentroCostoPlan = 9
      AllComp = 10
      CompIdPlan = 11
      CentroCostoDistinct = 12
      SucursalDistinct = 13
      LibroRetencionCuenta = 14
      LibroRetencionGeneral = 15
      LibroMayorCuentaSucCCO = 16
      SaldoCajaBanco = 17
      LibroMayorAnalisis = 18
      AllCompCentroCostoDet = 19
      LibroMayorEmpresas = 20
      AllCompCentroCosto = 21
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 2
      CompId = 3
      PlanId = 4
      PlanIdAutomatico = 5
      LibroMayor = 6
      LibroMayorFecha = 7
      LibroMayorSaldoAnterior = 8
      LibroMayorSaldoActual = 9
      SinMovimiento = 10
      PlanIdporCompId = 11
      RowSumGestion = 14
      RowSumFecha = 15
      LibroBanco = 16
      LibroBancoFecha = 17
      LibroBancoSaldoAnterior = 18
      SinMovimientoFecha = 20
      LibroMayorSaldoGestion = 21
      SucursalMovimientoGestion = 22
      SucursalMovimientoFecha = 23
      SucursalPlanGestion = 24
      SucursalPlanFecha = 25
      LibroMayorGestionSucursal = 26
      LibroMayorFechaSucursal = 27
      LibroMayorSaldoAnteriorSucursal = 28
      CentroCostoMovimientoGestion = 29
      CentroCostoMovimientoFecha = 30
      CentroCostoPlanGestion = 31
      CentroCostoPlanFecha = 32
      LibroMayorGestionCentroCosto = 33
      LibroMayorFechaCentroCosto = 34
      LibroMayorSaldoAnteriorCentroCosto = 35
      CompIdAutomatico = 36
      CentroCostoId = 37
      SucursalId = 38
      CentroCostoPlanMovimientoGestion = 39
      CentroCostoPlanMovimientoFecha = 40
      PlanIdMovimientoGestion = 41
      PlanIdMovimientoFecha = 42
      RowSumGestionMes = 43
      RowSumFechaMes = 44
      CompIdPlan = 45
      CentroCostoDistinct = 46
      SucursalDistinct = 47
      FlujoEfectivoDet = 48
      RowSumFechaTipoAsientoId = 49
      GridAutomatico = 50
      CompDetIdAutomatico = 51
      TipoRetencionId_INNER = 52
      TipoRetencionIdFecha_INNER = 53
      LibroMayorSaldoActualSucCCO = 54
      PlanIdAutomaticoSucCCO = 55
      SaldoCajaBanco = 56
      LibroMayorAnalisis = 57
      LibroMayorAnalisisFecha = 58
      RowSumFechaCentroCostoDet = 59
      RowSumFechaconActivoFijo = 60
      RowSumFechaSinGestion = 61
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompDetId = 1
      Grid = 2
      CompId = 3
      SumaSaldo = 4
      LibroBanco = 5
      SucursalPlan = 6
      CentroCostoPlan = 7
      Fecha = 8
      OrdenDesc = 9
      LibroMayorAnalisis = 10
   End Enum

   Public Enum GroupByFilters As Byte
      LibroMayorCuentaSucCCO = 1
      SaldoCajaBanco = 2
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      EstadoId = 1
      Orden = 2
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
   End Enum

   Public Enum RowCountFilters As Byte
      All = 0
   End Enum

   Public Enum RowSumFilters As Byte
      DebeBs = 1
      HaberBs = 2
      DebeUs = 3
      HaberUs = 4
   End Enum

   '*********************************************************
   '* The following filters will change for each
   '* data access class
   '*********************************************************
   Private mintSelectFilter As SelectFilters
   Private mintWhereFilter As WhereFilters
   Private mintOrderByFilter As OrderByFilters
   Private mintGroupByFilter As GroupByFilters
   Private mintInsertFilter As InsertFilters
   Private mintUpdateFilter As UpdateFilters
   Private mintDeleteFilter As DeleteFilters
   Private mintRowCountFilter As RowCountFilters
   Private mintRowSumFilter As RowSumFilters

   Property SelectFilter() As SelectFilters
      Get
         Return mintSelectFilter
      End Get

      Set(ByVal Value As SelectFilters)
         mintSelectFilter = Value
      End Set
   End Property

   Property WhereFilter() As WhereFilters
      Get
         Return mintWhereFilter
      End Get

      Set(ByVal Value As WhereFilters)
         mintWhereFilter = Value
      End Set
   End Property

   Property OrderByFilter() As OrderByFilters
      Get
         Return mintOrderByFilter
      End Get

      Set(ByVal Value As OrderByFilters)
         mintOrderByFilter = Value
      End Set
   End Property

   Property GroupByFilter() As GroupByFilters
      Get
         Return mintGroupByFilter
      End Get

      Set(ByVal Value As GroupByFilters)
         mintGroupByFilter = Value
      End Set
   End Property

   Property InsertFilter() As InsertFilters
      Get
         Return mintInsertFilter
      End Get

      Set(ByVal Value As InsertFilters)
         mintInsertFilter = Value
      End Set
   End Property

   Property UpdateFilter() As UpdateFilters
      Get
         Return mintUpdateFilter
      End Get

      Set(ByVal Value As UpdateFilters)
         mintUpdateFilter = Value
      End Set
   End Property

   Property DeleteFilter() As DeleteFilters
      Get
         Return mintDeleteFilter
      End Get

      Set(ByVal Value As DeleteFilters)
         mintDeleteFilter = Value
      End Set
   End Property

   Property RowCountFilter() As RowCountFilters
      Get
         Return mintRowCountFilter
      End Get

      Set(ByVal Value As RowCountFilters)
         mintRowCountFilter = Value
      End Set
   End Property

   Property RowSumFilter() As RowSumFilters
      Get
         Return mintRowSumFilter
      End Get

      Set(ByVal Value As RowSumFilters)
         mintRowSumFilter = Value
      End Set
   End Property

   '************************************************************
   '* Method Name  : New()
   '* Syntax       : Constructor
   '* Parameters   : None
   '*
   '* Description  : This event is called when the object is created.
   '* It can be used to initialize private data variables.
   '*
   '************************************************************
   Public Sub New()
      mstrTableName = "tblCompDet"
      mstrClassName = "clsCompDet"

      moConnection = New OleDbConnection
      VMNew = New clsCompDetVM
      VMOld = New clsCompDetVM

      Call PropertyInit()
      Call FilterInit()
   End Sub

   Public Sub New(ByVal ConnectString As String)
      Me.New()

      mstrConnectionString = ConnectString
   End Sub

   Public Sub New(ByVal ConnectString As String, ByVal bytSelectFilter As SelectFilters)
      Me.New()

      mstrConnectionString = ConnectString
      mintSelectFilter = bytSelectFilter
   End Sub

   Public Sub New(ByVal ConnectString As String, _
                  ByVal bytSelectFilter As SelectFilters, _
                  ByVal bytWhereFilter As WhereFilters)
      Me.New()

      mstrConnectionString = ConnectString
      mintSelectFilter = bytSelectFilter
      mintWhereFilter = bytWhereFilter
   End Sub

   Public Sub New(ByVal ConnectString As String, _
                  ByVal bytSelectFilter As SelectFilters, _
                  ByVal bytWhereFilter As WhereFilters, _
                  ByVal bytOrderByFilter As OrderByFilters)
      Me.New()

      mstrConnectionString = ConnectString
      mintSelectFilter = bytSelectFilter
      mintWhereFilter = bytWhereFilter
      mintOrderByFilter = bytOrderByFilter
   End Sub

   Public Sub PropertyInit()
      mlngCompDetId = 0
      mlngEmpresaId = 0
      mlngCompId = 0
      mlngGestionId = 0
      mlngTipoCompId = 0
      mstrFecha = ""
      mlngPlanId = 0
      mstrCompDetDes = ""
      mlngSucursalId = 0
      mlngCentroCostoId = 0
      mlngTipoRetencionId = 0
      mlngMonedaId = 0
      mdecDebeOrg = 0
      mdecHaberOrg = 0
      mdecDebeBs = 0
      mdecHaberBs = 0
      mdecDebeUs = 0
      mdecHaberUs = 0
      mlngOrden = 0
      mbytAutomatico = 0
      mlngEstadoId = 0
      mlngCompDetIdOrg = 0
      mlngTipoId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.EmpresaId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.GestionId,  "
            strSQL &= "    tblCompDet.TipoCompId,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblCompDet.PlanId,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompDet.SucursalId,  "
            strSQL &= "    tblCompDet.CentroCostoId,  "
            strSQL &= "    tblCompDet.TipoRetencionId,  "
            strSQL &= "    tblCompDet.MonedaId,  "
            strSQL &= "    tblCompDet.DebeOrg,  "
            strSQL &= "    tblCompDet.HaberOrg,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs,  "
            strSQL &= "    tblCompDet.Orden,  "
            strSQL &= "    tblCompDet.Automatico,  "
            strSQL &= "    tblCompDet.EstadoId,  "
            strSQL &= "    tblCompDet.CompDetIdOrg,  "
            strSQL &= "    tblCompDet.TipoId,  "
            strSQL &= "    tblCompDet.sLastUpdate_id,  "
            strSQL &= "    tblCompDet.dtLastUpdate_dt,  "
            strSQL &= "    tblCompDet.iConcurrency_id  "
            strSQL &= " FROM tblCompDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId  "
            strSQL &= " FROM tblCompDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.EmpresaId,  "
            strSQL &= "    tblCompDet.Orden,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.GestionId,  "
            strSQL &= "    tblCompDet.TipoCompId,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompDet.SucursalId,  "
            strSQL &= "    tblCompDet.CentroCostoId,  "
            strSQL &= "    tblCompDet.TipoRetencionId,  "
            strSQL &= "    tblCompDet.MonedaId,  "
            strSQL &= "    tblCompDet.DebeOrg,  "
            strSQL &= "    tblCompDet.HaberOrg,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs,  "
            strSQL &= "    tblCompDet.Automatico,  "
            strSQL &= "    tblPlan.TipoGrupoId,  "
            strSQL &= "    tblCompDet.TipoId,  "
            strSQL &= "    tblCompDet.EstadoId  "
            strSQL &= " FROM tblCompDet, tblPlan "

         Case SelectFilters.LibroMayorCuenta
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs  "
            strSQL &= " FROM tblCompDet, tblTipoComp, tblComp, tblPlan "

         Case SelectFilters.LibroMayorGeneral
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.EntregadoA As CompDetDes,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs  "
            strSQL &= " FROM tblCompDet, tblTipoComp, tblComp, tblPlan "

         Case SelectFilters.SumaSaldo
            strSQL = " SELECT  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs  "
            strSQL &= " FROM tblCompDet, tblPlan "

         Case SelectFilters.LibroBancoCuenta
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs,  "
            strSQL &= "    tblCompDet.Automatico  "
            strSQL &= " FROM tblCompDet, tblTipoComp, tblComp, tblPlan "

         Case SelectFilters.LibroBancoGeneral
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.EntregadoA As CompDetDes,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs,  "
            strSQL &= "    tblCompDet.Automatico  "
            strSQL &= " FROM tblCompDet, tblTipoComp, tblComp, tblPlan "

         Case SelectFilters.SucursalPlan
            strSQL = " SELECT DISTINCT "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.SucursalId  "
            strSQL &= " FROM tblCompDet, tblComp, tblPlan "

         Case SelectFilters.CentroCostoPlan
            strSQL = " SELECT DISTINCT "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.CentroCostoId  "
            strSQL &= " FROM tblCompDet, tblComp, tblPlan "

         Case SelectFilters.AllComp
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.EmpresaId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.GestionId,  "
            strSQL &= "    tblCompDet.TipoCompId,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblCompDet.PlanId,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompDet.SucursalId,  "
            strSQL &= "    tblCompDet.CentroCostoId,  "
            strSQL &= "    tblCompDet.MonedaId,  "
            strSQL &= "    tblCompDet.DebeOrg,  "
            strSQL &= "    tblCompDet.HaberOrg,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs,  "
            strSQL &= "    tblCompDet.Orden,  "
            strSQL &= "    tblCompDet.Automatico,  "
            strSQL &= "    tblCompDet.EstadoId  "
            strSQL &= " FROM tblCompDet, tblComp "

         Case SelectFilters.CompIdPlan
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.PlanId As CompDetPlanId,  "
            strSQL &= "    tblPlan.PlanId As PlanPlanId,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.TipoPlanId,  "
            strSQL &= "    tblPlan.MonedaId,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblPlan.SucCCOId  "
            strSQL &= " FROM tblCompDet LEFT OUTER JOIN tblPlan ON tblCompDet.PlanId = tblPlan.PlanId "

         Case SelectFilters.CentroCostoDistinct
            strSQL = " SELECT DISTINCT "
            strSQL &= "    tblCompDet.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoCod  "
            strSQL &= " FROM tblCompDet, tblCentroCosto "

         Case SelectFilters.SucursalDistinct
            strSQL = " SELECT DISTINCT "
            strSQL &= "    tblCompDet.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalCod  "
            strSQL &= " FROM tblCompDet, tblSucursal "

         Case SelectFilters.LibroRetencionCuenta
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompDet.DebeOrg,  "
            strSQL &= "    tblCompDet.HaberOrg,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs,  "
            strSQL &= "    tblCompDet.MonedaId,  "
            strSQL &= "    tblCompDet.Automatico,  "
            strSQL &= "    tblCompDet.TipoRetencionId  "
            strSQL &= " FROM tblCompDet, tblTipoComp, tblComp, tblPlan "

         Case SelectFilters.LibroRetencionGeneral
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.EntregadoA As CompDetDes,  "
            strSQL &= "    tblCompDet.DebeOrg,  "
            strSQL &= "    tblCompDet.HaberOrg,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs,  "
            strSQL &= "    tblCompDet.MonedaId,  "
            strSQL &= "    tblCompDet.Automatico,  "
            strSQL &= "    tblCompDet.TipoRetencionId  "
            strSQL &= " FROM tblCompDet, tblTipoComp, tblComp, tblPlan "

         Case SelectFilters.LibroMayorCuentaSucCCO
            strSQL = " SELECT  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.SucCCOId,  "
            If mlngSucursalId = 2 Then
               strSQL &= "    tblCentroCosto.CentroCostoId,  "
               strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            End If
            If mlngSucursalId = 1 Then
               strSQL &= "    tblSucursal.SucursalId,  "
               strSQL &= "    tblSucursal.SucursalDes,  "
            End If
            strSQL &= "    SUM(tblCompDet.DebeBs) as DebeBs,  "
            strSQL &= "    SUM(tblCompDet.HaberBs) as HaberBs,  "
            strSQL &= "    SUM(tblCompDet.DebeUs) as DebeUs,  "
            strSQL &= "    SUM(tblCompDet.HaberUs) as HaberUs  "
            strSQL &= " FROM tblCompDet, tblPlan, tblComp"
            If mlngSucursalId = 2 Then strSQL &= ", tblCentroCosto "
            If mlngSucursalId = 1 Then strSQL &= ", tblSucursal "

         Case SelectFilters.SaldoCajaBanco
            strSQL = " SELECT  "
            strSQL &= "    DISTINCT(tblCompDet.PlanId),  "
            strSQL &= "    tblPlan.PlanCta, "
            strSQL &= "    tblPlan.PlanDes, "
            strSQL &= "    SUM(tblCompDet.DebeBs) as DebeBs, "
            strSQL &= "    SUM(tblCompDet.haberBs) as HaberBs, "
            strSQL &= "    SUM(tblCompDet.DebeUs) as DebeUs, "
            strSQL &= "    SUM(tblCompDet.HaberUs) as HaberUs "
            strSQL &= "    FROM tblCompDet, tblPlan "

         Case SelectFilters.LibroMayorAnalisis
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompId, "
            strSQL &= "    tblPlan.PlanId, "
            strSQL &= "    tblPlan.PlanCta, "
            strSQL &= "    tblplan.PlanDes, "
            strSQL &= "    tblComp.CompNro, "
            strSQL &= "    CAST(tblComp.Fecha AS DATE) as Fecha, "
            strSQL &= "    CAST(tblCompDet.dtLastUpdate_dt AS DATE) as Fecha_Registro, "
            strSQL &= "    tblTipoComp.TipoCompId, "
            strSQL &= "    tblTipoComp.TipoCompDes, "
            strSQL &= "    tblCompDet.CompDetDes as Glosa, "
            strSQL &= "    tblMoneda.MonedaId, "
            strSQL &= "    tblMoneda.MonedaDes as MonedaDes, "
            strSQL &= "    (CASE  WHEN tblComp.MonedaId = 1 THEN tblCompDet.DebeBs ELSE tblCompDet.DebeUs END) as Debe, "
            strSQL &= "    (CASE  WHEN tblComp.MonedaId = 1 THEN tblCompDet.HaberBs ELSE tblCompDet.HaberUs END) as Haber, "
            strSQL &= "    tblCompDet.sLastUpdate_id as Usuario, "
            strSQL &= "    Convert(Time(0),tblCompdet.dtLastUpdate_dt,0) AS Hora, "
            '--(CASE  WHEN MONTH(tblComp.Fecha) - 3 <= 0  THEN MONTH(tblComp.Fecha) + 9  ELSE MONTH(tblComp.Fecha) - 3  END)  as Periodo, 
            strSQL &= "    MONTH(tblComp.Fecha) as Periodo, "
            strSQL &= "    tblComp.PorConcepto as Origen, "
            strSQL &= "    tblCompDet.EstadoId, tblEstado.EstadoDes "
            strSQL &= "    FROM tblComp, tblCompDet, tblPlan, tblTipoComp, tblMoneda, tblEstado "

         Case SelectFilters.AllCompCentroCostoDet
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.EmpresaId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.GestionId,  "
            strSQL &= "    tblCompDet.TipoCompId,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblCompDet.PlanId,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompDet.SucursalId,  "
            strSQL &= "    tblCompDet.CentroCostoId,  "
            strSQL &= "    tblCompDet.MonedaId,  "
            'strSQL &= "    tblCompDet.DebeOrg,  "
            'strSQL &= "    tblCompDet.HaberOrg,  "
            'strSQL &= "    tblCompDet.DebeBs,  "
            'strSQL &= "    tblCompDet.HaberBs,  "
            'strSQL &= "    tblCompDet.DebeUs,  "
            'strSQL &= "    tblCompDet.HaberUs,  "
            strSQL &= "    tblCompCentroCostoDet.DebeOrg,  "
            strSQL &= "    tblCompCentroCostoDet.HaberOrg,  "
            strSQL &= "    tblCompCentroCostoDet.DebeBs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberBs,  "
            strSQL &= "    tblCompCentroCostoDet.DebeUs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberUs,  "
            strSQL &= "    tblCompDet.Orden,  "
            strSQL &= "    tblCompDet.Automatico,  "
            strSQL &= "    tblCompDet.EstadoId  "
            strSQL &= " FROM tblCompDet, tblComp, tblCompCentroCostoDet "

         Case SelectFilters.LibroMayorEmpresas
            strSQL = " SELECT "
            strSQL &= " " & mlngCompDetIdOrg & " as Id,  "
            strSQL &= " (CASE WHEN MONTH(tblComp.Fecha) >= " & mlngCompDetId & " THEN (MONTH(tblComp.Fecha) - " & mlngCompDetId & " ) + 1 ELSE (MONTH(tblComp.Fecha) + (12 - " & mlngCompDetId & ") + 1) END) AS PERIODO, "
            strSQL &= " Month(tblComp.Fecha) as MesId, "
            strSQL &= " Day(tblComp.Fecha) as Dia, "
            strSQL &= " tblCompDet.CompDetId,  "
            strSQL &= " tblCompDet.CompId,  "
            strSQL &= " tblPlan.PlanId,  "
            strSQL &= " tblPlan.PlanCta,  "
            strSQL &= " tblPlan.PlanDes,  "
            strSQL &= " tblCompDet.Fecha,  "
            strSQL &= " tblTipoComp.TipoCompId,  "
            strSQL &= " tblTipoComp.TipoCompDes,  "
            strSQL &= " tblComp.CompNro,  "
            strSQL &= " tblComp.TipoCambio,  "
            strSQL &= " tblCompDet.CompDetDes,  "
            strSQL &= " tblComp.EntregadoA,  "
            strSQL &= " tblCompDet.DebeBs,  "
            strSQL &= " tblCompDet.HaberBs,  "
            strSQL &= " tblCompDet.DebeUs,  "
            strSQL &= " tblCompDet.HaberUs  "
            strSQL &= " FROM tblCompDet, tblTipoComp, tblComp, tblPlan "

         Case SelectFilters.AllCompCentroCosto
            strSQL = " SELECT  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.EmpresaId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.GestionId,  "
            strSQL &= "    tblCompDet.TipoCompId,  "
            strSQL &= "    tblCompDet.Fecha,  "
            strSQL &= "    tblCompDet.PlanId,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompDet.SucursalId,  "
            strSQL &= "    tblCompDet.CentroCostoId,  "
            strSQL &= "    tblCompDet.MonedaId,  "
            strSQL &= "    tblCompDet.DebeOrg,  "
            strSQL &= "    tblCompDet.HaberOrg,  "
            strSQL &= "    tblCompDet.DebeBs,  "
            strSQL &= "    tblCompDet.HaberBs,  "
            strSQL &= "    tblCompDet.DebeUs,  "
            strSQL &= "    tblCompDet.HaberUs,  "
            strSQL &= "    tblCompDet.Orden,  "
            strSQL &= "    tblCompDet.Automatico,  "
            strSQL &= "    tblPlan.SucCCOId,  "
            strSQL &= "    tblCompDet.EstadoId  "
            strSQL &= " FROM tblCompDet, tblComp, tblplan "

      End Select

      strSQL &= WhereFilterGet()

      strSQL &= OrderByFilterGet()

      strSQL &= GroupByFilterGet()

      mstrSQL = strSQL

      Return strSQL
   End Function

   Private Function WhereFilterGet() As String
      Dim strSQL As String

      Select Case mintWhereFilter

         Case WhereFilters.PrimaryKey
            strSQL = " WHERE  tblCompDet.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.CompIdAutomatico
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.Automatico = " & NumberToField(mbytAutomatico)

         Case WhereFilters.PlanId
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)

         Case WhereFilters.PlanIdAutomatico
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.Automatico = " & NumberToField(mbytAutomatico)

         Case WhereFilters.LibroMayor
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorSaldoAnterior
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.Fecha < " & DateToField(mstrFecha)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorSaldoActual
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrFecha)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.SinMovimiento
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.SinMovimientoFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.PlanIdporCompId
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)

         Case WhereFilters.RowSumGestion
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

         Case WhereFilters.RowSumFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

         Case WhereFilters.LibroBanco
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroBancoFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroBancoSaldoAnterior
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.Fecha < " & DateToField(mstrFecha)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorSaldoGestion 'Revisar SinFac
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "

         Case WhereFilters.SucursalMovimientoGestion
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.SucursalMovimientoFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.SucursalPlanGestion
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.SucursalPlanFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngPlanId <> 0 Then strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorGestionSucursal
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorFechaSucursal
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorSaldoAnteriorSucursal
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblCompDet.Fecha < " & DateToField(mstrFecha)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.CentroCostoMovimientoGestion
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            If mlngTipoId = clsSucCCO.CENTRO_COSTO Then strSQL &= " AND  tblPlan.SucCCOId = " & NumberToField(clsSucCCO.CENTRO_COSTO)
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.CentroCostoMovimientoFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            If mlngTipoId = clsSucCCO.CENTRO_COSTO Then strSQL &= " AND  tblPlan.SucCCOId = " & NumberToField(clsSucCCO.CENTRO_COSTO)
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "


         Case WhereFilters.CentroCostoPlanGestion
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            If mstrLastUpdateId <> "" Then strSQL &= " AND  tblCompDet.PlanId IN (" & mstrLastUpdateId & ") "
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblPlan.SucCCOId = 2 "
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

         Case WhereFilters.CentroCostoPlanFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            If mstrLastUpdateId <> "" Then strSQL &= " AND  tblCompDet.PlanId IN (" & mstrLastUpdateId & ") "
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblPlan.SucCCOId = 2 "
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

         Case WhereFilters.LibroMayorGestionCentroCosto
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorFechaCentroCosto
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorSaldoAnteriorCentroCosto
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.Fecha < " & DateToField(mstrFecha)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.CentroCostoId
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)

         Case WhereFilters.SucursalId
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)

         Case WhereFilters.CentroCostoPlanMovimientoGestion
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.CentroCostoPlanMovimientoFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.PlanIdMovimientoGestion
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

         Case WhereFilters.PlanIdMovimientoFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

         Case WhereFilters.RowSumGestionMes
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  MONTH(tblCompDet.Fecha) = " & NumberToField(mlngMonedaId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

         Case WhereFilters.RowSumFechaMes
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  MONTH(tblCompDet.Fecha) = " & NumberToField(mlngMonedaId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

         Case WhereFilters.CompIdPlan
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.CentroCostoDistinct
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.CentroCostoId = tblCentroCosto.CentroCostoId "

         Case WhereFilters.SucursalDistinct
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.SucursalId = tblSucursal.SucursalId "

         Case WhereFilters.FlujoEfectivoDet
            strSQL = " WHERE  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.Automatico = " & NumberToField(mbytAutomatico)
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  (tblPlan.TipoPlanId = 2 "
            strSQL &= " OR  tblPlan.TipoPlanId = 3) "

         Case WhereFilters.RowSumFechaTipoAsientoId
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoAsientoId IN " & mstrLastUpdateDate 'TipoAsientoId
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

         Case WhereFilters.GridAutomatico
            strSQL = " WHERE  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.Automatico = " & NumberToField(mbytAutomatico)
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "

         Case WhereFilters.CompDetIdAutomatico
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompDet.Automatico = " & NumberToField(mbytAutomatico)

         Case WhereFilters.TipoRetencionId_INNER
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.TipoRetencionId IN " & ToStr(mstrLastUpdateId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.TipoRetencionIdFecha_INNER
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.TipoRetencionId IN " & ToStr(mstrLastUpdateId)
            strSQL &= " AND  tblCompDet.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorSaldoActualSucCCO
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngSucursalId = 1 Then
               strSQL &= " AND  tblCompDet.SucursalId = tblSucursal.SucursalId  "
               'strSQL &= " AND  tblCompDet.SucursalId > 0  "
            End If
            If mlngSucursalId = 2 Then
               strSQL &= " AND  tblCompDet.CentroCostoId = tblCentroCosto.CentroCostoId "
               'strSQL &= " AND  tblCompDet.CentroCostoId > 0  "
            End If
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            If Not String.IsNullOrEmpty(mstrFecha) Then strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrFecha)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            If mlngCompId <> 0 Then strSQL &= " AND  tblComp.CompId <> " & NumberToField(mlngCompId)
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.PlanIdAutomaticoSucCCO
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.Automatico = " & NumberToField(mbytAutomatico)

         Case WhereFilters.SaldoCajaBanco
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblPlan.TipoPlanId IN (2,3) "
            strSQL &= " AND  tblCompDet.Automatico = " & NumberToField(mbytAutomatico)

         Case WhereFilters.LibroMayorAnalisisFecha
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblComp.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblCompDet.EstadoId = tblEstado.EstadoId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorAnalisis
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblComp.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblCompDet.EstadoId = tblEstado.EstadoId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.RowSumFechaCentroCostoDet
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompDet.CompDetId = tblCompCentroCostoDet.CompDetId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateId <> "" Then strSQL &= " AND tblCompCentroCostoDet.CentroCostoDetId IN (" & mstrLastUpdateId & ") "

         Case WhereFilters.RowSumFechaconActivoFijo
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac
            If mstrLastUpdateId <> "" Then strSQL &= " AND tblCompDet.CompId IN ( SELECT t.CompId FROM tblCompDet as t WHERE t.CompId = tblCompDet.CompId AND t.PlanId IN ( " & mstrLastUpdateId & " )) "

         Case WhereFilters.RowSumFechaSinGestion
            strSQL = " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            'If mlngGestionId <> 0 Then strSQL &= " AND  tblCompDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngSucursalId)
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompDet.Fecha <= " & DateToField(mstrCompDetDes)
            strSQL &= " AND  (tblCompDet.EstadoId = 10 "
            strSQL &= " OR  tblCompDet.EstadoId = 11) "
            strSQL &= " AND  tblCompDet.CompId = tblComp.CompId "
            If mlngOrden = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngOrden) 'SinFac
            If mbytAutomatico = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mbytAutomatico) 'ConFac

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompDetId
            strSQL = " ORDER BY tblCompDet.CompDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblCompDet.Automatico, tblCompDet.Orden, tblCompDet.CompDetId "

         Case OrderByFilters.CompId
            strSQL = " ORDER BY tblCompDet.CompId "

         Case OrderByFilters.LibroBanco
            strSQL = " ORDER BY tblCompDet.Fecha "

         Case OrderByFilters.SucursalPlan
            strSQL = " ORDER BY tblPlan.PlanCTA "

         Case OrderByFilters.CentroCostoPlan
            strSQL = " ORDER BY tblPlan.PlanCTA "

         Case OrderByFilters.Fecha
            strSQL = " ORDER BY tblCompDet.Fecha, tblCompDet.CompId "

         Case OrderByFilters.OrdenDesc
            strSQL = " ORDER BY tblCompDet.Orden Desc "

         Case OrderByFilters.LibroMayorAnalisis
            strSQL = " ORDER BY tblComp.Fecha ASC "
      End Select

      Return strSQL
   End Function

   Private Function GroupByFilterGet() As String
      Dim strSQL As String

      Select Case mintGroupByFilter
         Case GroupByFilters.LibroMayorCuentaSucCCO
            strSQL = " GROUP BY tblPlan.PlanId, tblplan.SucCCOId"
            If mlngSucursalId = 1 Then strSQL &= ", tblSucursal.SucursalId, tblSucursal.SucursalDes "
            If mlngSucursalId = 2 Then strSQL &= ", tblCentroCosto.CentroCostoId, tblCentroCosto.CentroCostoDes "

         Case GroupByFilters.SaldoCajaBanco
            strSQL = " GROUP BY tblCompDet.PlanId, tblPlan.PlanCta, tblPlan.PlanDes "

      End Select

      Return strSQL
   End Function

   Protected Overrides Function RowCountSQL() As String
      Dim strSQL As String

      Select Case mintRowCountFilter
         Case RowCountFilters.All
            strSQL = "SELECT Count(*) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function RowSumSQL() As String
      Dim strSQL As String

      Select Case mintRowSumFilter
         Case RowSumFilters.DebeBs
            strSQL = "SELECT Sum(tblCompDet.DebeBs) As NumRecs FROM tblComp, " & mstrTableName
            strSQL &= WhereFilterGet()

         Case RowSumFilters.HaberBs
            strSQL = "SELECT Sum(tblCompDet.HaberBs) As NumRecs FROM tblComp, " & mstrTableName
            strSQL &= WhereFilterGet()

         Case RowSumFilters.DebeUs
            strSQL = "SELECT Sum(tblCompDet.DebeUs) As NumRecs FROM tblComp, " & mstrTableName
            strSQL &= WhereFilterGet()

         Case RowSumFilters.HaberUs
            strSQL = "SELECT Sum(tblCompDet.HaberUs) As NumRecs FROM tblComp, " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Protected Overrides Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO tblCompDet ("
            strSQL &= "CompDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CompId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoCompId, "
            strSQL &= "Fecha, "
            strSQL &= "PlanId, "
            strSQL &= "CompDetDes, "
            strSQL &= "SucursalId, "
            strSQL &= "CentroCostoId, "
            strSQL &= "TipoRetencionId, "
            strSQL &= "MonedaId, "
            strSQL &= "DebeOrg, "
            strSQL &= "HaberOrg, "
            strSQL &= "DebeBs, "
            strSQL &= "HaberBs, "
            strSQL &= "DebeUs, "
            strSQL &= "HaberUs, "
            strSQL &= "Orden, "
            strSQL &= "Automatico, "
            strSQL &= "EstadoId, "
            strSQL &= "CompDetIdOrg, "
            strSQL &= "TipoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= StringToField(mstrCompDetDes) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngTipoRetencionId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecDebeOrg) & ", "
            strSQL &= DecimalToField(mdecHaberOrg) & ", "
            strSQL &= DecimalToField(mdecDebeBs) & ", "
            strSQL &= DecimalToField(mdecHaberBs) & ", "
            strSQL &= DecimalToField(mdecDebeUs) & ", "
            strSQL &= DecimalToField(mdecHaberUs) & ", "
            strSQL &= NumberToField(mlngOrden) & ", "
            strSQL &= NumberToField(mbytAutomatico) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= NumberToField(mlngCompDetIdOrg) & ", "
            strSQL &= NumberToField(mlngTipoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCompDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "CompDetDes = " & StringToField(mstrCompDetDes) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "TipoRetencionId = " & NumberToField(mlngTipoRetencionId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "DebeOrg = " & DecimalToField(mdecDebeOrg) & ", "
            strSQL &= "HaberOrg = " & DecimalToField(mdecHaberOrg) & ", "
            strSQL &= "DebeBs = " & DecimalToField(mdecDebeBs) & ", "
            strSQL &= "HaberBs = " & DecimalToField(mdecHaberBs) & ", "
            strSQL &= "DebeUs = " & DecimalToField(mdecDebeUs) & ", "
            strSQL &= "HaberUs = " & DecimalToField(mdecHaberUs) & ", "
            strSQL &= "Orden = " & NumberToField(mlngOrden) & ", "
            strSQL &= "Automatico = " & NumberToField(mbytAutomatico) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= "CompDetIdOrg = " & NumberToField(mlngCompDetIdOrg) & ", "
            strSQL &= "TipoId = " & NumberToField(mlngTipoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompDetId = " & NumberToField(mlngCompDetId) & " "

         Case UpdateFilters.EstadoId
            strSQL = "UPDATE tblCompDet SET "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompDetId = " & NumberToField(mlngCompDetId) & " "

         Case UpdateFilters.Orden
            strSQL = "UPDATE tblCompDet SET "
            strSQL &= "Orden = " & NumberToField(mlngOrden) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompDetId = " & NumberToField(mlngCompDetId) & " "

      End Select

      Return strSQL
   End Function

   Protected Overrides Function DeleteSQL() As String
      Dim strSQL As String

      Select Case mintDeleteFilter
         Case DeleteFilters.All
            strSQL = "DELETE FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Protected Overrides Sub Retrieve(ByVal oDataRow As DataRow)
      Try
         Call PropertyInit()

         Select Case mintSelectFilter
            Case SelectFilters.All
               mlngCompDetId = ToLong(oDataRow("CompDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mstrCompDetDes = ToStr(oDataRow("CompDetDes"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngTipoRetencionId = ToLong(oDataRow("TipoRetencionId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecDebeOrg = ToDecimal(oDataRow("DebeOrg"))
               mdecHaberOrg = ToDecimal(oDataRow("HaberOrg"))
               mdecDebeBs = ToDecimal(oDataRow("DebeBs"))
               mdecHaberBs = ToDecimal(oDataRow("HaberBs"))
               mdecDebeUs = ToDecimal(oDataRow("DebeUs"))
               mdecHaberUs = ToDecimal(oDataRow("HaberUs"))
               mlngOrden = ToLong(oDataRow("Orden"))
               mbytAutomatico = ToByte(oDataRow("Automatico"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mlngCompDetIdOrg = ToLong(oDataRow("CompDetIdOrg"))
               mlngTipoId = ToLong(oDataRow("TipoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompDetId = ToLong(oDataRow("CompDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompDetId = TableIDGet(mstrTableName, "CompDetId", moConnection)

         If mlngCompDetId = -1 Then
            Throw New Exception("No se puede generar un identificador unico para esta tabla: " & mstrTableName)
         Else
            GetNewPrimaryKey = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Overrides Function Validate() As Boolean
      Dim strMsg As String = String.Empty

      If mlngEmpresaId = 0 Then
         strMsg &= "Empresa Inválida" & vbCrLf
      End If

      If mlngCompId = 0 Then
         strMsg &= "Comprobante ID Inválido" & vbCrLf
      End If

      If mlngGestionId = 0 Then
         strMsg &= "Gestión Inválida" & vbCrLf
      End If

      If mlngTipoCompId = 0 Then
         strMsg &= "Tipo de Comprobante Inválido" & vbCrLf
      End If

      If mlngPlanId = 0 Then
         strMsg &= "Seleccione la Cuenta" & vbCrLf
      End If

      If (mdecDebeOrg = 0) And (mdecHaberOrg = 0) Then
         strMsg &= "Ingrese un Valor al Debe o al Haber" & vbCrLf

      ElseIf (mdecDebeOrg < 0) Or (mdecHaberOrg < 0) Then
         strMsg &= "Valores Negativos Inválidos" & vbCrLf

      ElseIf (mdecDebeOrg > 0) And (mdecHaberOrg > 0) Then
         strMsg &= "Debe y Haber no Pueden Tener Valores" & vbCrLf
      End If

      If mstrFecha.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha no puede ser nula" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Seleccione la Moneda" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         Validate = False
      Else
         Validate = True
      End If
   End Function

   Public Overrides Function NoDuplicates(ByVal boolReplace As Boolean) As Boolean
      Dim strSQL As String
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM tblCompDet "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
         '   strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
         'Else
         '   strSQL &= " WHERE  tblCompDet.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCompId)
         '   strSQL &= " AND  tblCompDet.PlanId = " & NumberToField(mlngPlanId)
         '   strSQL &= " AND  tblCompDet.CompDetId <> " & NumberToField(mlngCompDetId)
         'End If

         If strSQL <> "" Then
            Call OpenConection()

            oCommand = New OleDbCommand
            oCommand.CommandText = strSQL
            oCommand.Connection = moConnection

            intRecordsAffected = oCommand.ExecuteScalar

            If intRecordsAffected = 0 Then
               NoDuplicates = True
            Else
               NoDuplicates = False
            End If
         Else
            NoDuplicates = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function FindByPK() As Boolean
      FindByPK = False

      Try
         mintSelectFilter = SelectFilters.All
         mintWhereFilter = WhereFilters.PrimaryKey
         mintOrderByFilter = OrderByFilters.None

         If Open() Then
            If Read() Then
               FindByPK = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function UpdateOnly() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      UpdateOnly = False

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = UpdateSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = oCommand.ExecuteNonQuery()

         If intRecordsAffected > 0 Then
            VMNew.ToChangeOpeUpdate(VMOld, clsTipoOpera.MODIFICA)
            UpdateOnly = True
         End If
      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function RowSum() As Decimal
      Dim oCommand As OleDbCommand
      Dim decRecordsAffected As Decimal

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowSumSQL()
         oCommand.Connection = moConnection

         decRecordsAffected = ToDecimal(oCommand.ExecuteScalar)

         Return decRecordsAffected

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Overloads Function Insert() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Insert = False

      Try
         If Validate() Then
            If NoDuplicates(False) Then
               If GetNewPrimaryKey() Then
                  Call OpenConection()

                  oCommand = New OleDbCommand
                  oCommand.CommandText = InsertSQL()
                  oCommand.Connection = moConnection

                  intRecordsAffected = oCommand.ExecuteNonQuery()

                  If intRecordsAffected > 0 Then
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngCompDetId)
                     Insert = True
                  End If
               End If
            Else
               Throw New Exception("Registro Duplicado")
               Return False
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Overloads Function Update() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Update = False

      Try
         If Validate() Then
            If NoDuplicates(True) Then
               Call OpenConection()

               oCommand = New OleDbCommand
               oCommand.CommandText = UpdateSQL()
               oCommand.Connection = moConnection

               intRecordsAffected = oCommand.ExecuteNonQuery()

               If intRecordsAffected > 0 Then
                  VMNew.ToChangeOpeUpdate(VMOld, clsTipoOpera.MODIFICA)
                  Update = True
               End If
            Else
               Throw New Exception("Registro Duplicado")
               Return False
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Overloads Function Delete() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Delete = False

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = DeleteSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = oCommand.ExecuteNonQuery()

         If intRecordsAffected > 0 Then
            VMNew.ToDeleteOpe()
            Delete = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Sub FilterInit()
      mintWhereFilter = 0
      mintOrderByFilter = 0
      mintSelectFilter = 0
      mintInsertFilter = 0
      mintUpdateFilter = 0
      mintDeleteFilter = 0
      mintRowCountFilter = 0
   End Sub

   Overridable Sub Dispose() Implements IDisposable.Dispose
      Call CloseConection()
   End Sub

   Public Overrides Function IsDeleted() As Boolean
      Return True
   End Function

End Class



