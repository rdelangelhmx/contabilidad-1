Imports System.Data
Imports System.Data.OleDb

Public Class clsCompPlanEEFF
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsCompPlanEEFFVM
   Public VMNew As clsCompPlanEEFFVM

   Private mlngCompPlanEEFFId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngCompId As Long
   Private mlngCompDetId As Long
   Private mstrFecha As String
   Private mlngPlanEEFFId As Long
   Private mlngMonedaId As Long
   Private mlngPlanId As Long
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
   Private mstrAux As String
   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CompPlanEEFFId() As Long
      Get
         Return mlngCompPlanEEFFId
      End Get

      Set(ByVal Value As Long)
         mlngCompPlanEEFFId = Value
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

   Property PlanEEFFId() As Long
      Get
         Return mlngPlanEEFFId
      End Get

      Set(ByVal Value As Long)
         mlngPlanEEFFId = Value
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

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
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

   Property Aux() As String
      Get
         Return mstrAux
      End Get

      Set(ByVal Value As String)
         mstrAux = Value
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
      '  PlanAddIdDistinct = 5
      LibroMayorCuentaSucCCO = 6
      PrintReport = 7
      FlujoEfectivo = 8
      FlujoEfectivoTipoPlan = 9
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      PlanEEFFId = 2
      Grid = 3
      CompId = 4
      CompDetId = 5
      LibroMayor = 6
      LibroMayorFecha = 7
      LibroMayorSaldoAnterior = 8
      PlanAddIdyCompId = 9
      LibroMayorSaldoAnteriorSucCCO = 10
      CompDetIdAutomatico = 11
      PrintReport = 12
      FlujoEfectivo = 13
      FlujoEfectivoTipoPlan = 14
      FindPlanEEFFId = 15
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompPlanEEFFId = 1
      Grid = 3
      LibroMayor = 4
      PlanEEFFCta = 5
      FlujoEfectivo = 6
   End Enum

   Public Enum GroupByFilters As Byte
      LibroMayorSaldoAnteriorSucCCO = 1
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      EstadoId = 1
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
      mstrTableName = "tblCompPlanEEFF"
      mstrClassName = "clsCompPlanEEFF"

      moConnection = New OleDbConnection
      VMNew = New clsCompPlanEEFFVM
      VMOld = New clsCompPlanEEFFVM

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
      mlngCompPlanEEFFId = 0
      mlngEmpresaId = 0
      mlngCompId = 0
      mlngCompDetId = 0
      mlngGestionId = 0
      mstrFecha = ""
      mlngPlanEEFFId = 0
      mlngMonedaId = 0
      mlngPlanId = 0
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
            strSQL &= "    tblCompPlanEEFF.CompPlanEEFFId,  "
            strSQL &= "    tblCompPlanEEFF.EmpresaId,  "
            strSQL &= "    tblCompPlanEEFF.CompId,  "
            strSQL &= "    tblCompPlanEEFF.CompDetId,  "
            strSQL &= "    tblCompPlanEEFF.GestionId,  "
            strSQL &= "    tblCompPlanEEFF.Fecha,  "
            strSQL &= "    tblCompPlanEEFF.PlanEEFFId,  "
            strSQL &= "    tblCompPlanEEFF.MonedaId,  "
            strSQL &= "    tblCompPlanEEFF.PlanId,  "
            strSQL &= "    tblCompPlanEEFF.DebeOrg,  "
            strSQL &= "    tblCompPlanEEFF.HaberOrg,  "
            strSQL &= "    tblCompPlanEEFF.DebeBs,  "
            strSQL &= "    tblCompPlanEEFF.HaberBs,  "
            strSQL &= "    tblCompPlanEEFF.DebeUs,  "
            strSQL &= "    tblCompPlanEEFF.HaberUs,  "
            strSQL &= "    tblCompPlanEEFF.EstadoId,  "
            strSQL &= "    tblCompPlanEEFF.sLastUpdate_id,  "
            strSQL &= "    tblCompPlanEEFF.dtLastUpdate_dt,  "
            strSQL &= "    tblCompPlanEEFF.iConcurrency_id  "
            strSQL &= " FROM tblCompPlanEEFF "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCompPlanEEFF.CompPlanEEFFId  "
            strSQL &= " FROM tblCompPlanEEFF "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCompPlanEEFF.CompPlanEEFFId,  "
            strSQL &= "    tblCompPlanEEFF.EmpresaId,  "
            strSQL &= "    tblCompPlanEEFF.CompId,  "
            strSQL &= "    tblCompPlanEEFF.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFId,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFCta,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFDes,  "
            strSQL &= "    tblCompPlanEEFF.DebeBs,  "
            strSQL &= "    tblCompPlanEEFF.HaberBs,  "
            strSQL &= "    tblCompPlanEEFF.DebeUs,  "
            strSQL &= "    tblCompPlanEEFF.HaberUs  "
            strSQL &= " FROM tblCompPlanEEFF, tblPlanEEFF, tblPlan "

         Case SelectFilters.LibroMayorCuenta
            strSQL = " SELECT  "
            strSQL &= "    tblCompPlanEEFF.CompDetId,  "
            strSQL &= "    tblCompPlanEEFF.CompId,  "
            strSQL &= "    tblCompPlanEEFF.PlanEEFFId,  "
            strSQL &= "    tblCompPlanEEFF.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.MonedaId,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompPlanEEFF.DebeBs,  "
            strSQL &= "    tblCompPlanEEFF.HaberBs,  "
            strSQL &= "    tblCompPlanEEFF.DebeUs,  "
            strSQL &= "    tblCompPlanEEFF.HaberUs  "
            strSQL &= " FROM tblCompPlanEEFF, tblTipoComp, tblComp, tblCompDet "

         Case SelectFilters.LibroMayorGeneral
            strSQL = " SELECT   "
            strSQL &= "    tblCompPlanEEFF.CompDetId,  "
            strSQL &= "    tblCompPlanEEFF.CompId,  "
            strSQL &= "    tblCompPlanEEFF.PlanEEFFId,  "
            strSQL &= "    tblCompPlanEEFF.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.MonedaId,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.EntregadoA As CompDetDes,  "
            strSQL &= "    tblCompPlanEEFF.DebeBs,  "
            strSQL &= "    tblCompPlanEEFF.HaberBs,  "
            strSQL &= "    tblCompPlanEEFF.DebeUs,  "
            strSQL &= "    tblCompPlanEEFF.HaberUs  "
            strSQL &= " FROM tblCompPlanEEFF, tblTipoComp, tblComp, tblCompDet "

            'Case SelectFilters.PlanAddIdDistinct
            '   strSQL = " SELECT DISTINCT  "
            '   strSQL &= "    tblCompPlanEEFF.PlanEEFFId,  "
            '   strSQL &= "    tblCompPlanEEFF.PlanAddId,  "
            '   strSQL &= "    tblPlanAdd.PlanAddCta  "
            '   strSQL &= " FROM tblCompPlanEEFF, tblPlanAdd "

         Case SelectFilters.LibroMayorCuentaSucCCO
            strSQL = " SELECT   "
            'strSQL &= "    tblCompPlanEEFF.CompDetId,  "
            'strSQL &= "    tblCompPlanEEFF.CompId,  "
            strSQL &= "    tblCompPlanEEFF.PlanEEFFId,  "
            'strSQL &= "    tblCompPlanEEFF.Fecha,  "
            'strSQL &= "    tblTipoComp.TipoCompId,  "
            'strSQL &= "    tblTipoComp.TipoCompDes,  "
            'strSQL &= "    tblComp.MonedaId,  "
            'strSQL &= "    tblComp.TipoCambio,  "
            'strSQL &= "    tblComp.CompNro,  "
            'strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    SUM(tblCompPlanEEFF.DebeBs) as DebeBs,  "
            strSQL &= "    SUM(tblCompPlanEEFF.HaberBs) as HaberBs,  "
            strSQL &= "    SUM(tblCompPlanEEFF.DebeUs) as DebeUs,  "
            strSQL &= "    SUM(tblCompPlanEEFF.HaberUs) as HaberUs  "
            strSQL &= " FROM tblCompPlanEEFF, tblCompDet "

         Case SelectFilters.PrintReport
            strSQL = " SELECT   "
            strSQL &= "    tblCompPlanEEFF.PlanEEFFId, "
            strSQL &= "    tblPlanEEFF.PlanEEFFCta, "
            strSQL &= "    tblPlanEEFF.PlanEEFFDes, "
            strSQL &= "    tblCompPlanEEFF.DebeOrg, "
            strSQL &= "    tblCompPlanEEFF.HaberOrg, "
            strSQL &= "    tblCompPlanEEFF.DebeBs, "
            strSQL &= "    tblCompPlanEEFF.DebeUs, "
            strSQL &= "    tblCompPlanEEFF.HaberBs, "
            strSQL &= "    tblCompPlanEEFF.HaberUs, "
            strSQL &= "    tblCompPlanEEFF.MonedaId, "
            strSQL &= "    tblMoneda.MonedaDes "
            strSQL &= "    FROM tblCompPlanEEFF, tblPlanEEFF, tblMoneda "

         Case SelectFilters.FlujoEfectivo
            strSQL = " SELECT "
            strSQL &= "    tblCompPlanEEFF.CompPlanEEFFId, "
            strSQL &= "    tblCompDet.CompDetId, "
            strSQL &= "    tblComp.CompId, "
            strSQL &= "    tblPlanEEFF.PlanEEFFId, "
            strSQL &= "    tblPlanEEFF.PlanEEFFCta, "
            strSQL &= "    tblPlanEEFF.PlanEEFFDes, "
            strSQL &= "    tblPlanPadreEEFF.PlanEEFFId as PlanPadreEEFFId, "
            strSQL &= "    tblPlanPadreEEFF.PlanEEFFCta as PlanPadreEEFFCta, "
            strSQL &= "    tblPlanPadreEEFF.PlanEEFFDes as PlanPadreEEFFDes, "
            strSQL &= "    tblComp.CompNro, "
            strSQL &= "    tblCompPlanEEFF.Fecha, "
            strSQL &= "    tblCompDet.CompDetDes, "
            strSQL &= "    tblComp.EntregadoA, "
            strSQL &= "    tblTipoComp.TipoCompDes, "
            strSQL &= "    tblCompPlanEEFF.DebeBs, "
            strSQL &= "    tblCompPlanEEFF.HaberBs, "
            strSQL &= "    tblCompPlanEEFF.DebeUs, "
            strSQL &= "    tblCompPlanEEFF.HaberUs, "
            strSQL &= "    tblComp.MonedaId, "
            strSQL &= "    tblComp.TipoCambio "
            strSQL &= "    FROM tblCompPlanEEFF, tblPlanEEFF, tblCompDet, tblComp, tblTipoComp, tblPlanEEFF as tblPlanPadreEEFF "

         Case SelectFilters.FlujoEfectivoTipoPlan
            strSQL = " SELECT "
            strSQL &= "    tblCompPlanEEFF.CompPlanEEFFId, "
            strSQL &= "    tblCompDet.CompDetId, "
            strSQL &= "    tblComp.CompId, "
            strSQL &= "    tblPlanEEFF.PlanEEFFId, "
            strSQL &= "    tblPlanEEFF.PlanEEFFCta, "
            strSQL &= "    tblPlanEEFF.PlanEEFFDes, "
            strSQL &= "    tblPlanPadreEEFF.PlanEEFFId as PlanPadreEEFFId, "
            strSQL &= "    tblPlanPadreEEFF.PlanEEFFCta as PlanPadreEEFFCta, "
            strSQL &= "    tblPlanPadreEEFF.PlanEEFFDes as PlanPadreEEFFDes, "
            strSQL &= "    tblComp.CompNro, "
            strSQL &= "    tblCompPlanEEFF.Fecha, "
            strSQL &= "    tblCompDet.CompDetDes, "
            strSQL &= "    tblComp.EntregadoA, "
            strSQL &= "    tblTipoComp.TipoCompDes, "
            strSQL &= "    tblCompPlanEEFF.DebeBs, "
            strSQL &= "    tblCompPlanEEFF.HaberBs, "
            strSQL &= "    tblCompPlanEEFF.DebeUs, "
            strSQL &= "    tblCompPlanEEFF.HaberUs, "
            strSQL &= "    tblComp.MonedaId, "
            strSQL &= "    tblComp.TipoCambio, "
            strSQL &= "    tblCompDet.PlanId, "
            strSQL &= "    tblComp.TipoAsientoId, "
            strSQL &= "    tblPlan.TipoPlanId "
            strSQL &= "    FROM tblCompPlanEEFF, tblPlanEEFF, tblCompDet, tblComp, tblTipoComp, tblPlanEEFF as tblPlanPadreEEFF, tblPlan "

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
            strSQL = " WHERE  tblCompPlanEEFF.CompPlanEEFFId = " & NumberToField(mlngCompPlanEEFFId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = tblPlanEEFF.PlanEEFFId "
            strSQL &= " AND  tblCompPlanEEFF.PlanId = tblPlan.PlanId "

         Case WhereFilters.PlanEEFFId
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)

         Case WhereFilters.CompId
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.CompDetIdAutomatico
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanEEFF.CompDetId IN "
            strSQL &= " (SELECT CompDetId FROM tblCompDet WHERE CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND Automatico = 1) "

         Case WhereFilters.CompDetId
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanEEFF.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.LibroMayor
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)
            If mlngCompId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCompId) 'CentroCostoId
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompPlanEEFF.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompPlanEEFF.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblCompPlanEEFF.EstadoId = 10 "
            strSQL &= " OR  tblCompPlanEEFF.EstadoId = 11) "

         Case WhereFilters.LibroMayorFecha
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)
            If mlngCompId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCompId) 'CentroCostoId
            If mlngCompDetId <> 0 Then strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngCompDetId) 'SucursalId
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompPlanEEFF.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompPlanEEFF.Fecha <= " & DateToField(mstrLastUpdateId)
            strSQL &= " AND  tblCompPlanEEFF.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompPlanEEFF.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblCompPlanEEFF.EstadoId = 10 "
            strSQL &= " OR  tblCompPlanEEFF.EstadoId = 11) "

         Case WhereFilters.LibroMayorSaldoAnterior
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)
            strSQL &= " AND  tblCompPlanEEFF.Fecha < " & DateToField(mstrFecha)
            If mlngCompId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCompId) 'CentroCostoId
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            strSQL &= " AND  tblCompPlanEEFF.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompPlanEEFF.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblCompPlanEEFF.EstadoId = 10 "
            strSQL &= " OR  tblCompPlanEEFF.EstadoId = 11) "
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.PlanAddIdyCompId
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.CompId = " & NumberToField(mlngCompId)
            '  strSQL &= " AND  tblCompPlanEEFF.PlanAddId = " & NumberToField(mlngPlanAddId)

            'Case WhereFilters.PlanAddIdDistinct
            '   strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            '   strSQL &= " AND  tblCompPlanEEFF.GestionId = " & NumberToField(mlngGestionId)
            '   strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)
            '   ' strSQL &= " AND  tblCompPlanEEFF.PlanAddId = tblPlanAdd.PlanAddId "

         Case WhereFilters.LibroMayorSaldoAnteriorSucCCO
            strSQL = " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)
            strSQL &= " AND  tblCompPlanEEFF.CompDetId = tblCompDet.CompDetId "
            If Not String.IsNullOrEmpty(mstrFecha) Then strSQL &= " AND  tblCompPlanEEFF.Fecha <= " & DateToField(mstrFecha)
            strSQL &= " AND  (tblCompPlanEEFF.EstadoId = 10 "
            strSQL &= " OR  tblCompPlanEEFF.EstadoId = 11) "
            If mlngCompDetId = 1 Then
               strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngCompId) 'SucursalId
            ElseIf mlngCompDetId = 2 Then
               strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCompId) 'CentroCostoId
            End If
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac

         Case WhereFilters.PrintReport
            strSQL = " WHERE  tblCompPlanEEFF.PlanEEFFId = tblPlanEEFF.PlanEEFFId "
            strSQL &= " AND   tblCompPlanEEFF.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND   tblCompPlanEEFF.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.FlujoEfectivo
            strSQL = " WHERE tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND tblCompPlanEEFF.GestionId = " & NumberToField(mlngGestionId)
            If Not mstrLastUpdateId.Equals("") Then strSQL &= " AND tblCompPlanEEFF.PlanEEFFId IN " & mstrLastUpdateId '(149, 153, 169, 176)
            strSQL &= " AND tblCompPlanEEFF.PlanEEFFId = tblPlanEEFF.PlanEEFFId "
            strSQL &= " AND tblPlanEEFF.PlanEEFFPadreId = tblPlanPadreEEFF.PlanEEFFId "
            strSQL &= " AND tblCompPlanEEFF.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND tblCompPlanEEFF.CompId = tblComp.CompId "
            strSQL &= " AND tblComp.TipoCompId = tblTipoComp.TipoCompId "
            If mlngCompPlanEEFFId = 1 Then
               strSQL &= " AND tblCompDet.Fecha >= " & DateToField(mstrFecha)
               strSQL &= " AND tblCompDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            End If
            strSQL &= " AND (tblCompDet.EstadoId = 10 OR tblCompDet.EstadoId = 11) "
            If mstrAux <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrAux & ") "

         Case WhereFilters.FlujoEfectivoTipoPlan
            strSQL = " WHERE tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND tblCompPlanEEFF.GestionId = " & NumberToField(mlngGestionId)
            If Not mstrLastUpdateId.Equals("") Then strSQL &= " AND tblCompPlanEEFF.PlanEEFFId IN " & mstrLastUpdateId '(149, 153, 169, 176)
            strSQL &= " AND tblCompPlanEEFF.PlanEEFFId = tblPlanEEFF.PlanEEFFId "
            strSQL &= " AND tblPlanEEFF.PlanEEFFPadreId = tblPlanPadreEEFF.PlanEEFFId "
            strSQL &= " AND tblCompPlanEEFF.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND tblCompPlanEEFF.CompId = tblComp.CompId "
            strSQL &= " AND tblComp.TipoCompId = tblTipoComp.TipoCompId "
            If mlngCompPlanEEFFId = 1 Then
               strSQL &= " AND tblCompDet.Fecha >= " & DateToField(mstrFecha)
               strSQL &= " AND tblCompDet.Fecha <= " & DateToField(mstrLastUpdateDate)
            End If
            strSQL &= " AND (tblCompDet.EstadoId = 10 OR tblCompDet.EstadoId = 11) "
            If mstrAux <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrAux & ") "

         Case WhereFilters.FindPlanEEFFId
            strSQL = " WHERE tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanEEFF.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)
            strSQL &= " AND  tblCompPlanEEFF.PlanId = " & NumberToField(mlngPlanId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompPlanEEFFId
            strSQL = " ORDER BY tblCompPlanEEFF.CompPlanEEFFId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblPlanEEFF.PlanEEFFCta "

         Case OrderByFilters.LibroMayor
            strSQL = " ORDER BY tblCompPlanEEFF.Fecha, tblComp.CompNro "

         Case OrderByFilters.PlanEEFFCta
            strSQL = " ORDER BY tblPlanEEFF.PlanEEFFCta "

         Case OrderByFilters.FlujoEfectivo
            strSQL = " ORDER BY tblPlanPadreEEFF.PlanEEFFCta, tblPlanEEFF.PlanEEFFCta, tblCompPlanEEFF.Fecha "

      End Select

      Return strSQL
   End Function

   Private Function GroupByFilterGet() As String
      Dim strSQL As String

      Select Case mintGroupByFilter
         Case GroupByFilters.LibroMayorSaldoAnteriorSucCCO
            'trSQL = " GROUP BY tblCompPlanEEFF.PlanEEFFId, "
            ' strSQL &= " tblCompPlanEEFF.PlanAddId  "
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
            strSQL = "INSERT INTO tblCompPlanEEFF ("
            strSQL &= "CompPlanEEFFId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CompId, "
            strSQL &= "CompDetId, "
            strSQL &= "GestionId, "
            strSQL &= "Fecha, "
            strSQL &= "PlanEEFFId, "
            strSQL &= "MonedaId, "
            strSQL &= "PlanId, "
            strSQL &= "DebeOrg, "
            strSQL &= "HaberOrg, "
            strSQL &= "DebeBs, "
            strSQL &= "HaberBs, "
            strSQL &= "DebeUs, "
            strSQL &= "HaberUs, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompPlanEEFFId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngCompDetId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngPlanEEFFId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
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
            strSQL = "UPDATE tblCompPlanEEFF SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "CompDetId = " & NumberToField(mlngCompDetId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "PlanEEFFId = " & NumberToField(mlngPlanEEFFId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "DebeOrg = " & DecimalToField(mdecDebeOrg) & ", "
            strSQL &= "HaberOrg = " & DecimalToField(mdecHaberOrg) & ", "
            strSQL &= "DebeBs = " & DecimalToField(mdecDebeBs) & ", "
            strSQL &= "HaberBs = " & DecimalToField(mdecHaberBs) & ", "
            strSQL &= "DebeUs = " & DecimalToField(mdecDebeUs) & ", "
            strSQL &= "HaberUs = " & DecimalToField(mdecHaberUs) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompPlanEEFFId = " & NumberToField(mlngCompPlanEEFFId) & " "

         Case UpdateFilters.EstadoId
            strSQL = "UPDATE tblCompPlanEEFF SET "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompPlanEEFFId = " & NumberToField(mlngCompPlanEEFFId) & " "

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
               mlngCompPlanEEFFId = ToLong(oDataRow("CompPlanEEFFId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngCompDetId = ToLong(oDataRow("CompDetId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngPlanEEFFId = ToLong(oDataRow("PlanEEFFId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
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
               mlngCompPlanEEFFId = ToLong(oDataRow("CompPlanEEFFId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompPlanEEFFId = TableIDGet(mstrTableName, "CompPlanEEFFId", moConnection)

         If mlngCompPlanEEFFId = -1 Then
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

      If mlngPlanEEFFId = 0 Then
         strMsg &= "Ingrese la Cuenta" & vbCrLf
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
         strSQL &= " FROM tblCompPlanEEFF "

         If Not boolReplace Then
            strSQL &= " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanEEFF.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)
            strSQL &= " AND  tblCompPlanEEFF.PlanId = " & NumberToField(mlngPlanId)
         Else
            strSQL &= " WHERE  tblCompPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanEEFF.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanEEFF.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompPlanEEFF.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)
            strSQL &= " AND  tblCompPlanEEFF.CompPlanEEFFId <> " & NumberToField(mlngCompPlanEEFFId)
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

   Public Overrides Function IsDeleted() As Boolean
      Dim strSQL As String = ""
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Dim oDataTable As New DataTable
      Dim dbNull As System.DBNull
      Dim oRestrictions() As Object = {dbNull, dbNull, dbNull, "TABLE"}

      Try
         Call OpenConection()
         oDataTable = moConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, oRestrictions)

         'strSQL = " SELECT "
         'strSQL &= " Count(*) As NumRecs "
         'strSQL &= " FROM tblBanco "
         'strSQL &= " WHERE tblBanco.BancoId = " & NumberToField(mlngBancoId)

         'If TableFind(oDataTable, "tblCheque") Then
         '   strSQL &= " AND (tblBanco.BancoId IN "
         '   strSQL &= "     (SELECT DISTINCT BancoId "
         '   strSQL &= "      FROM  tblCheque "
         '   strSQL &= "      WHERE tblCheque.BancoId = " & NumberToField(mlngBancoId) & ")"
         'End If

         'If TableFind(oDataTable, "venTipoTarjeta") Then
         '   strSQL &= " OR tblBanco.BancoId IN "
         '   strSQL &= "   (SELECT DISTINCT BancoId "
         '   strSQL &= "    FROM  venTipoTarjeta "
         '   strSQL &= "    WHERE venTipoTarjeta.BancoId = " & NumberToField(mlngBancoId) & ")"
         'End If

         'If TableFind(oDataTable, "rrhEmpleado") Then
         '   strSQL &= " OR tblBanco.BancoId IN "
         '   strSQL &= "   (SELECT DISTINCT BancoId "
         '   strSQL &= "    FROM  rrhEmpleado "
         '   strSQL &= "    WHERE rrhEmpleado.BancoId = " & NumberToField(mlngBancoId) & ")"
         'End If

         'strSQL &= " )"

         If strSQL <> "" Then
            Call OpenConection()

            oCommand = New OleDbCommand
            oCommand.CommandText = strSQL
            oCommand.Connection = moConnection

            intRecordsAffected = oCommand.ExecuteScalar

            If intRecordsAffected = 0 Then
               IsDeleted = True
            Else
               IsDeleted = False
            End If
         Else
            IsDeleted = True
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngCompPlanEEFFId)
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

End Class
