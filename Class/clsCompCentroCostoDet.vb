Imports System.Data
Imports System.Data.OleDb

Public Class clsCompCentroCostoDet
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsCompCentroCostoDetVM
   Public VMNew As clsCompCentroCostoDetVM

   Private mlngCompCentroCostoDetId As Long
   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngCompDetId As Long
   Private mlngGestionId As Long
   Private mstrFecha As String
   Private mlngPlanId As Long
   Private mlngMonedaId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mdecDebeOrg As Decimal
   Private mdecHaberOrg As Decimal
   Private mdecDebeBs As Decimal
   Private mdecHaberBs As Decimal
   Private mdecDebeUs As Decimal
   Private mdecHaberUs As Decimal
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CompCentroCostoDetId() As Long
      Get
         Return mlngCompCentroCostoDetId
      End Get

      Set(ByVal Value As Long)
         mlngCompCentroCostoDetId = Value
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

   Property CompDetId() As Long
      Get
         Return mlngCompDetId
      End Get

      Set(ByVal Value As Long)
         mlngCompDetId = Value
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

   Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngMonedaId = Value
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

   Property CentroCostoDetId() As Long
      Get
         Return mlngCentroCostoDetId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoDetId = Value
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

   Property EstadoId() As Long
      Get
         Return mlngEstadoId
      End Get

      Set(ByVal Value As Long)
         mlngEstadoId = Value
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
      DistinctPlanId = 5
      CentroCostoDetIdDistinct = 6
      LibroMayorCuentaCentroCosto = 7
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      CompId = 4
      CompDetId = 5
      LibroMayor = 6
      LibroMayorFecha = 7
      CentroCostoDetId = 9
      CentroCostoId = 10
      DistinctPlanId = 11
      DistinctPlanIdFecha = 12
      CentroCostoDetIdDistinct = 13
      LibroMayorFechaCentroCosto = 14
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompCentroCostoDetId = 1
      Grid = 3
      LibroMayor = 4
      DistinctPlanId = 5
      DistinctPlanCta = 6
   End Enum

   Public Enum GroupByFilters As Byte
      LibroMayorFechaCentroCosto = 1
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
   End Enum

   Public Enum DeleteFilters As Byte
      All = 0
   End Enum

   Public Enum RowCountFilters As Byte
      All = 0
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
      mstrTableName = "tblCompCentroCostoDet"
      mstrClassName = "clsCompCentroCostoDet"

      moConnection = New OleDbConnection
      VMNew = New clsCompCentroCostoDetVM
      VMOld = New clsCompCentroCostoDetVM

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
      mlngCompCentroCostoDetId = 0
      mlngEmpresaId = 0
      mlngCompId = 0
      mlngCompDetId = 0
      mlngGestionId = 0
      mstrFecha = ""
      mlngPlanId = 0
      mlngMonedaId = 0
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
      mdecDebeOrg = 0
      mdecHaberOrg = 0
      mdecDebeBs = 0
      mdecHaberBs = 0
      mdecDebeUs = 0
      mdecHaberUs = 0
      mlngEstadoId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblCompCentroCostoDet.CompCentroCostoDetId,  "
            strSQL &= "    tblCompCentroCostoDet.EmpresaId,  "
            strSQL &= "    tblCompCentroCostoDet.CompId,  "
            strSQL &= "    tblCompCentroCostoDet.CompDetId,  "
            strSQL &= "    tblCompCentroCostoDet.GestionId,  "
            strSQL &= "    tblCompCentroCostoDet.Fecha,  "
            strSQL &= "    tblCompCentroCostoDet.PlanId,  "
            strSQL &= "    tblCompCentroCostoDet.MonedaId,  "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoId,  "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCompCentroCostoDet.DebeOrg,  "
            strSQL &= "    tblCompCentroCostoDet.HaberOrg,  "
            strSQL &= "    tblCompCentroCostoDet.DebeBs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberBs,  "
            strSQL &= "    tblCompCentroCostoDet.DebeUs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberUs,  "
            strSQL &= "    tblCompCentroCostoDet.EstadoId,  "
            strSQL &= "    tblCompCentroCostoDet.sLastUpdate_id,  "
            strSQL &= "    tblCompCentroCostoDet.dtLastUpdate_dt,  "
            strSQL &= "    tblCompCentroCostoDet.iConcurrency_id  "
            strSQL &= " FROM tblCompCentroCostoDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCompCentroCostoDet.CompCentroCostoDetId  "
            strSQL &= " FROM tblCompCentroCostoDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCompCentroCostoDet.CompCentroCostoDetId,  "
            strSQL &= "    tblCompCentroCostoDet.EmpresaId,  "
            strSQL &= "    tblCompCentroCostoDet.CompId,  "
            strSQL &= "    tblCompCentroCostoDet.CompDetId,  "
            strSQL &= "    tblCompCentroCostoDet.PlanId,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoCod,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetCod,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetDes,  "
            strSQL &= "    tblCompCentroCostoDet.DebeBs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberBs,  "
            strSQL &= "    tblCompCentroCostoDet.DebeUs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberUs  "
            strSQL &= " FROM tblCompCentroCostoDet, tblCentroCosto, tblCentroCostoDet, tblPlan "

         Case SelectFilters.LibroMayorCuenta
            strSQL = " SELECT  "
            strSQL &= "    tblCompCentroCostoDet.CompDetId,  "
            strSQL &= "    tblCompCentroCostoDet.CompId,  "
            strSQL &= "    tblCompCentroCostoDet.PlanId,  "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoId,  "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCompCentroCostoDet.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.MonedaId,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompCentroCostoDet.DebeBs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberBs,  "
            strSQL &= "    tblCompCentroCostoDet.DebeUs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberUs  "
            strSQL &= " FROM tblCompCentroCostoDet, tblTipoComp, tblComp, tblCompDet "

         Case SelectFilters.LibroMayorGeneral
            strSQL = " SELECT  "
            strSQL &= "    tblCompCentroCostoDet.CompDetId,  "
            strSQL &= "    tblCompCentroCostoDet.CompId,  "
            strSQL &= "    tblCompCentroCostoDet.PlanId,  "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoId,  "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCompCentroCostoDet.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.MonedaId,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.EntregadoA As CompDetDes,  "
            strSQL &= "    tblCompCentroCostoDet.DebeBs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberBs,  "
            strSQL &= "    tblCompCentroCostoDet.DebeUs,  "
            strSQL &= "    tblCompCentroCostoDet.HaberUs  "
            strSQL &= " FROM tblCompCentroCostoDet, tblTipoComp, tblComp, tblCompDet "

         Case SelectFilters.DistinctPlanId
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    tblCompCentroCostoDet.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes  "
            strSQL &= " FROM tblCompCentroCostoDet, tblPlan, tblComp "

         Case SelectFilters.CentroCostoDetIdDistinct
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoId,  "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetCod  "
            strSQL &= " FROM tblCompCentroCostoDet, tblCentroCostoDet "

         Case SelectFilters.LibroMayorCuentaCentroCosto
            strSQL = " SELECT "
            strSQL &= "    tblCompCentroCostoDet.PlanId, "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoId, "
            strSQL &= "    tblCompCentroCostoDet.CentroCostoDetId, "
            strSQL &= "    SUM(tblCompCentroCostoDet.DebeBs) as DebeBs, "
            strSQL &= "    SUM(tblCompCentroCostoDet.DebeUs) as DebeUs, "
            strSQL &= "    SUM(tblCompCentroCostoDet.HaberBs) as HaberBs, "
            strSQL &= "    SUM(tblCompCentroCostoDet.HaberUs) as HaberUs "
            strSQL &= " FROM tblCompCentroCostoDet, tblComp "

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
            strSQL = " WHERE  tblCompCentroCostoDet.CompCentroCostoDetId = " & NumberToField(mlngCompCentroCostoDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCentroCostoDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblPlan.SucCCOId = " & NumberToField(clsSucCCO.CENTRO_COSTO)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoDetId = tblCentroCostoDet.CentroCostoDetId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.CompDetId
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCentroCostoDet.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.LibroMayor
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCentroCostoDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)
            strSQL &= " AND  tblCompCentroCostoDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompCentroCostoDet.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblCompCentroCostoDet.EstadoId = 10 "
            strSQL &= " OR  tblCompCentroCostoDet.EstadoId = 11) "
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.LibroMayorFecha
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCentroCostoDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)
            strSQL &= " AND  tblCompCentroCostoDet.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompCentroCostoDet.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompCentroCostoDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompCentroCostoDet.Fecha <= " & DateToField(mstrLastUpdateId)
            strSQL &= " AND  (tblCompCentroCostoDet.EstadoId = 10 "
            strSQL &= " OR  tblCompCentroCostoDet.EstadoId = 11) "
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.CentroCostoDetId
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)

         Case WhereFilters.CentroCostoId
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCentroCostoDet.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)

         Case WhereFilters.DistinctPlanId
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)
            strSQL &= " AND  tblCompCentroCostoDet.PlanId = tblPlan.PlanId "
            If mlngCompCentroCostoDetId = clsSucCCO.CENTRO_COSTO Then strSQL &= " AND  tblPlan.SucCCOId = " & NumberToField(clsSucCCO.CENTRO_COSTO)
            strSQL &= " AND  (tblCompCentroCostoDet.EstadoId = 10 "
            strSQL &= " OR  tblCompCentroCostoDet.EstadoId = 11) "
            strSQL &= " AND  tblCompCentroCostoDet.CompId = tblComp.CompId "
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.DistinctPlanIdFecha
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)
            strSQL &= " AND  tblCompCentroCostoDet.PlanId = tblPlan.PlanId "
            If mlngCompCentroCostoDetId = clsSucCCO.CENTRO_COSTO Then strSQL &= " AND  tblPlan.SucCCOId = " & NumberToField(clsSucCCO.CENTRO_COSTO)
            strSQL &= " AND  tblCompCentroCostoDet.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompCentroCostoDet.Fecha <= " & DateToField(mstrLastUpdateId)
            strSQL &= " AND  (tblCompCentroCostoDet.EstadoId = 10 "
            strSQL &= " OR  tblCompCentroCostoDet.EstadoId = 11) "
            strSQL &= " AND  tblCompCentroCostoDet.CompId = tblComp.CompId "
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.CentroCostoDetIdDistinct
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoDetId = tblCentroCostoDet.CentroCostoDetId "

         Case WhereFilters.LibroMayorFechaCentroCosto
            strSQL = " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCentroCostoDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            If Not String.IsNullOrEmpty(mstrFecha) Then strSQL &= " AND  tblCompCentroCostoDet.Fecha <= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompCentroCostoDet.CompId = tblComp.CompId "
            strSQL &= " AND  (tblCompCentroCostoDet.EstadoId = 10 "
            strSQL &= " OR  tblCompCentroCostoDet.EstadoId = 11) "
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompCentroCostoDetId
            strSQL = " ORDER BY tblCompCentroCostoDet.CompCentroCostoDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblCentroCosto.CentroCostoDes, tblCentroCostoDet.CentroCostoDetDes "

         Case OrderByFilters.LibroMayor
            strSQL = " ORDER BY tblCompCentroCostoDet.Fecha "

         Case OrderByFilters.DistinctPlanId
            strSQL = " ORDER BY tblPlan.PlanDes "

         Case OrderByFilters.DistinctPlanCta
            strSQL = " ORDER BY tblPlan.PlanCta "


      End Select

      Return strSQL
   End Function

   Private Function GroupByFilterGet() As String
      Dim strSQL As String

      Select Case mintGroupByFilter
         Case GroupByFilters.LibroMayorFechaCentroCosto
            strSQL = " GROUP BY tblCompCentroCostoDet.PlanId, tblCompCentroCostoDet.CentroCostoId, tblCompCentroCostoDet.CentroCostoDetId "

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

   Protected Overrides Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO tblCompCentroCostoDet ("
            strSQL &= "CompCentroCostoDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CompId, "
            strSQL &= "CompDetId, "
            strSQL &= "GestionId, "
            strSQL &= "Fecha, "
            strSQL &= "PlanId, "
            strSQL &= "MonedaId, "
            strSQL &= "CentroCostoId, "
            strSQL &= "CentroCostoDetId, "
            strSQL &= "DebeOrg, "
            strSQL &= "HaberOrg, "
            strSQL &= "DebeBs, "
            strSQL &= "HaberBs, "
            strSQL &= "DebeUs, "
            strSQL &= "HaberUs, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompCentroCostoDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngCompDetId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= DecimalToField(mdecDebeOrg) & ", "
            strSQL &= DecimalToField(mdecHaberOrg) & ", "
            strSQL &= DecimalToField(mdecDebeBs) & ", "
            strSQL &= DecimalToField(mdecHaberBs) & ", "
            strSQL &= DecimalToField(mdecDebeUs) & ", "
            strSQL &= DecimalToField(mdecHaberUs) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCompCentroCostoDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "CompDetId = " & NumberToField(mlngCompDetId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= "DebeOrg = " & DecimalToField(mdecDebeOrg) & ", "
            strSQL &= "HaberOrg = " & DecimalToField(mdecHaberOrg) & ", "
            strSQL &= "DebeBs = " & DecimalToField(mdecDebeBs) & ", "
            strSQL &= "HaberBs = " & DecimalToField(mdecHaberBs) & ", "
            strSQL &= "DebeUs = " & DecimalToField(mdecDebeUs) & ", "
            strSQL &= "HaberUs = " & DecimalToField(mdecHaberUs) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompCentroCostoDetId = " & NumberToField(mlngCompCentroCostoDetId) & " "

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
               mlngCompCentroCostoDetId = ToLong(oDataRow("CompCentroCostoDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngCompDetId = ToLong(oDataRow("CompDetId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngCentroCostoDetId = ToLong(oDataRow("CentroCostoDetId"))
               mdecDebeOrg = ToDecimal(oDataRow("DebeOrg"))
               mdecHaberOrg = ToDecimal(oDataRow("HaberOrg"))
               mdecDebeBs = ToDecimal(oDataRow("DebeBs"))
               mdecHaberBs = ToDecimal(oDataRow("HaberBs"))
               mdecDebeUs = ToDecimal(oDataRow("DebeUs"))
               mdecHaberUs = ToDecimal(oDataRow("HaberUs"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompCentroCostoDetId = ToLong(oDataRow("CompCentroCostoDetId"))

            Case SelectFilters.LibroMayorCuentaCentroCosto
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngCentroCostoDetId = ToLong(oDataRow("CentroCostoDetId"))
               mdecDebeBs = ToDecimal(oDataRow("DebeBs"))
               mdecHaberBs = ToDecimal(oDataRow("HaberBs"))
               mdecDebeUs = ToDecimal(oDataRow("DebeUs"))
               mdecHaberUs = ToDecimal(oDataRow("HaberUs"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompCentroCostoDetId = TableIDGet(mstrTableName, "CompCentroCostoDetId", moConnection)

         If mlngCompCentroCostoDetId = -1 Then
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

      If mstrFecha.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha no puede ser nula" & vbCrLf
      End If

      If mlngPlanId = 0 Then
         strMsg &= "Ingrese la Cuenta" & vbCrLf
      End If

      If mlngCentroCostoDetId = 0 Then
         strMsg &= "Seleccione la Actividad" & vbCrLf
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
         strSQL = " SELECT  "
         strSQL &= " Count(*) As NumRecs  "
         strSQL &= " FROM tblCompCentroCostoDet "

         If Not boolReplace Then
            strSQL &= " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCentroCostoDet.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompCentroCostoDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)
         Else
            strSQL &= " WHERE  tblCompCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCentroCostoDet.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCentroCostoDet.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompCentroCostoDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)
            strSQL &= " AND  tblCompCentroCostoDet.CompCentroCostoDetId <> " & NumberToField(mlngCompCentroCostoDetId)
         End If

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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngCompCentroCostoDetId)
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
