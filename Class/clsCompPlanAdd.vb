Imports System.Data
Imports System.Data.OleDb

Public Class clsCompPlanAdd
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsCompPlanAddVM
   Public VMNew As clsCompPlanAddVM

   Private mlngCompPlanAddId As Long
   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngCompDetId As Long
   Private mlngGestionId As Long
   Private mstrFecha As String
   Private mlngPlanId As Long
   Private mlngMonedaId As Long
   Private mlngPlanAddId As Long
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
   Property CompPlanAddId() As Long
      Get
         Return mlngCompPlanAddId
      End Get

      Set(ByVal Value As Long)
         mlngCompPlanAddId = Value
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

   Property PlanAddId() As Long
      Get
         Return mlngPlanAddId
      End Get

      Set(ByVal Value As Long)
         mlngPlanAddId = Value
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
      PlanAddIdDistinct = 5
      LibroMayorCuentaSucCCO = 6
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      CompId = 4
      CompDetId = 5
      LibroMayor = 6
      LibroMayorFecha = 7
      LibroMayorSaldoAnterior = 8
      PlanAddId = 9
      PlanAddIdyCompId = 10
      PlanAddIdDistinct = 11
      LibroMayorSaldoAnteriorSucCCO = 12
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompPlanAddId = 1
      Grid = 3
      LibroMayor = 4
      PlanCta = 5
   End Enum

   Public Enum GroupByFilters As Byte
      LibroMayorSaldoAnteriorSucCCO = 1
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
      mstrTableName = "tblCompPlanAdd"
      mstrClassName = "clsCompPlanAdd"

      moConnection = New OleDbConnection
      VMNew = New clsCompPlanAddVM
      VMOld = New clsCompPlanAddVM

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
      mlngCompPlanAddId = 0
      mlngEmpresaId = 0
      mlngCompId = 0
      mlngCompDetId = 0
      mlngGestionId = 0
      mstrFecha = ""
      mlngPlanId = 0
      mlngMonedaId = 0
      mlngPlanAddId = 0
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
            strSQL &= "    tblCompPlanAdd.CompPlanAddId,  "
            strSQL &= "    tblCompPlanAdd.EmpresaId,  "
            strSQL &= "    tblCompPlanAdd.CompId,  "
            strSQL &= "    tblCompPlanAdd.CompDetId,  "
            strSQL &= "    tblCompPlanAdd.GestionId,  "
            strSQL &= "    tblCompPlanAdd.Fecha,  "
            strSQL &= "    tblCompPlanAdd.PlanId,  "
            strSQL &= "    tblCompPlanAdd.MonedaId,  "
            strSQL &= "    tblCompPlanAdd.PlanAddId,  "
            strSQL &= "    tblCompPlanAdd.DebeOrg,  "
            strSQL &= "    tblCompPlanAdd.HaberOrg,  "
            strSQL &= "    tblCompPlanAdd.DebeBs,  "
            strSQL &= "    tblCompPlanAdd.HaberBs,  "
            strSQL &= "    tblCompPlanAdd.DebeUs,  "
            strSQL &= "    tblCompPlanAdd.HaberUs,  "
            strSQL &= "    tblCompPlanAdd.EstadoId,  "
            strSQL &= "    tblCompPlanAdd.sLastUpdate_id,  "
            strSQL &= "    tblCompPlanAdd.dtLastUpdate_dt,  "
            strSQL &= "    tblCompPlanAdd.iConcurrency_id  "
            strSQL &= " FROM tblCompPlanAdd "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCompPlanAdd.CompPlanAddId  "
            strSQL &= " FROM tblCompPlanAdd "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCompPlanAdd.CompPlanAddId,  "
            strSQL &= "    tblCompPlanAdd.EmpresaId,  "
            strSQL &= "    tblCompPlanAdd.CompId,  "
            strSQL &= "    tblCompPlanAdd.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlanAdd.PlanAddId,  "
            strSQL &= "    tblPlanAdd.PlanAddCta,  "
            strSQL &= "    tblPlanAdd.PlanAddDes,  "
            strSQL &= "    tblCompPlanAdd.DebeBs,  "
            strSQL &= "    tblCompPlanAdd.HaberBs,  "
            strSQL &= "    tblCompPlanAdd.DebeUs,  "
            strSQL &= "    tblCompPlanAdd.HaberUs  "
            strSQL &= " FROM tblCompPlanAdd, tblPlan, tblPlanAdd "

         Case SelectFilters.LibroMayorCuenta
            strSQL = " SELECT  "
            strSQL &= "    tblCompPlanAdd.CompDetId,  "
            strSQL &= "    tblCompPlanAdd.CompId,  "
            strSQL &= "    tblCompPlanAdd.PlanId,  "
            strSQL &= "    tblCompPlanAdd.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.MonedaId,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblCompDet.CentroCostoId,  "
            strSQL &= "    tblCompDet.CompDetDes,  "
            strSQL &= "    tblCompPlanAdd.DebeBs,  "
            strSQL &= "    tblCompPlanAdd.HaberBs,  "
            strSQL &= "    tblCompPlanAdd.DebeUs,  "
            strSQL &= "    tblCompPlanAdd.HaberUs  "
            strSQL &= " FROM tblCompPlanAdd, tblTipoComp, tblComp, tblCompDet "

         Case SelectFilters.LibroMayorGeneral
            strSQL = " SELECT   "
            strSQL &= "    tblCompPlanAdd.CompDetId,  "
            strSQL &= "    tblCompPlanAdd.CompId,  "
            strSQL &= "    tblCompPlanAdd.PlanId,  "
            strSQL &= "    tblCompPlanAdd.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.MonedaId,  "
            strSQL &= "    tblComp.TipoCambio,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblComp.EntregadoA As CompDetDes,  "
            strSQL &= "    tblCompPlanAdd.DebeBs,  "
            strSQL &= "    tblCompPlanAdd.HaberBs,  "
            strSQL &= "    tblCompPlanAdd.DebeUs,  "
            strSQL &= "    tblCompPlanAdd.HaberUs  "
            strSQL &= " FROM tblCompPlanAdd, tblTipoComp, tblComp, tblCompDet "

         Case SelectFilters.PlanAddIdDistinct
            strSQL = " SELECT DISTINCT  "
            strSQL &= "    tblCompPlanAdd.PlanId,  "
            strSQL &= "    tblCompPlanAdd.PlanAddId,  "
            strSQL &= "    tblPlanAdd.PlanAddCta  "
            strSQL &= " FROM tblCompPlanAdd, tblPlanAdd "

         Case SelectFilters.LibroMayorCuentaSucCCO
            strSQL = " SELECT   "
            strSQL &= "    tblCompPlanAdd.PlanId,  "
            strSQL &= "    tblCompPlanAdd.PlanAddId,  "
            strSQL &= "    SUM(tblCompPlanAdd.DebeBs) as DebeBs,  "
            strSQL &= "    SUM(tblCompPlanAdd.HaberBs) as HaberBs,  "
            strSQL &= "    SUM(tblCompPlanAdd.DebeUs) as DebeUs,  "
            strSQL &= "    SUM(tblCompPlanAdd.HaberUs) as HaberUs  "
            strSQL &= " FROM tblCompPlanAdd, tblCompDet "

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
            strSQL = " WHERE  tblCompPlanAdd.CompPlanAddId = " & NumberToField(mlngCompPlanAddId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanAdd.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompPlanAdd.PlanAddId = tblPlanAdd.PlanAddId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.CompDetId
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanAdd.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.LibroMayor
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId)
            If mlngCompId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCompId) 'CentroCostoId
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompPlanAdd.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompPlanAdd.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblCompPlanAdd.EstadoId = 10 "
            strSQL &= " OR  tblCompPlanAdd.EstadoId = 11) "

         Case WhereFilters.LibroMayorFecha
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId)
            If mlngCompId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCompId) 'CentroCostoId
            If mlngCompDetId <> 0 Then strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngCompDetId) 'SucursalId
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "
            strSQL &= " AND  tblCompPlanAdd.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompPlanAdd.Fecha <= " & DateToField(mstrLastUpdateId)
            strSQL &= " AND  tblCompPlanAdd.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompPlanAdd.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblCompPlanAdd.EstadoId = 10 "
            strSQL &= " OR  tblCompPlanAdd.EstadoId = 11) "

         Case WhereFilters.LibroMayorSaldoAnterior
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId)
            strSQL &= " AND  tblCompPlanAdd.Fecha < " & DateToField(mstrFecha)
            If mlngCompId <> 0 Then strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCompId) 'CentroCostoId
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac
            strSQL &= " AND  tblCompPlanAdd.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompPlanAdd.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblCompPlanAdd.EstadoId = 10 "
            strSQL &= " OR  tblCompPlanAdd.EstadoId = 11) "
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

         Case WhereFilters.PlanAddId
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId)

         Case WhereFilters.PlanAddIdyCompId
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId)

         Case WhereFilters.PlanAddIdDistinct
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompPlanAdd.PlanAddId = tblPlanAdd.PlanAddId "

         Case WhereFilters.LibroMayorSaldoAnteriorSucCCO
            strSQL = " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompPlanAdd.CompDetId = tblCompDet.CompDetId "
            If Not String.IsNullOrEmpty(mstrFecha) Then strSQL &= " AND  tblCompPlanAdd.Fecha <= " & DateToField(mstrFecha)
            strSQL &= " AND  (tblCompPlanAdd.EstadoId = 10 "
            strSQL &= " OR  tblCompPlanAdd.EstadoId = 11) "
            If mlngCompDetId = 1 Then
               strSQL &= " AND  tblCompDet.SucursalId = " & NumberToField(mlngCompId) 'SucursalId
            ElseIf mlngCompDetId = 2 Then
               strSQL &= " AND  tblCompDet.CentroCostoId = " & NumberToField(mlngCompId) 'CentroCostoId
            End If
            If mlngMonedaId = 1 Then strSQL &= " AND  tblComp.SinFac = " & NumberToField(mlngMonedaId) 'SinFac
            If mlngEstadoId = 1 Then strSQL &= " AND  tblComp.ConFac = " & NumberToField(mlngEstadoId) 'ConFac

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompPlanAddId
            strSQL = " ORDER BY tblCompPlanAdd.CompPlanAddId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblPlan.PlanCta "

         Case OrderByFilters.LibroMayor
            strSQL = " ORDER BY tblCompPlanAdd.Fecha, tblComp.CompNro "

         Case OrderByFilters.PlanCta
            strSQL = " ORDER BY tblPlanAdd.PlanAddCta "

      End Select

      Return strSQL
   End Function

   Private Function GroupByFilterGet() As String
      Dim strSQL As String

      Select Case mintGroupByFilter
         Case GroupByFilters.LibroMayorSaldoAnteriorSucCCO
            strSQL = " GROUP BY tblCompPlanAdd.PlanId, "
            strSQL &= " tblCompPlanAdd.PlanAddId  "
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
            strSQL = "INSERT INTO tblCompPlanAdd ("
            strSQL &= "CompPlanAddId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CompId, "
            strSQL &= "CompDetId, "
            strSQL &= "GestionId, "
            strSQL &= "Fecha, "
            strSQL &= "PlanId, "
            strSQL &= "MonedaId, "
            strSQL &= "PlanAddId, "
            strSQL &= "DebeOrg, "
            strSQL &= "HaberOrg, "
            strSQL &= "DebeBs, "
            strSQL &= "HaberBs, "
            strSQL &= "DebeUs, "
            strSQL &= "HaberUs, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompPlanAddId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngCompDetId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= NumberToField(mlngPlanAddId) & ", "
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
            strSQL = "UPDATE tblCompPlanAdd SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "CompDetId = " & NumberToField(mlngCompDetId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "PlanAddId = " & NumberToField(mlngPlanAddId) & ", "
            strSQL &= "DebeOrg = " & DecimalToField(mdecDebeOrg) & ", "
            strSQL &= "HaberOrg = " & DecimalToField(mdecHaberOrg) & ", "
            strSQL &= "DebeBs = " & DecimalToField(mdecDebeBs) & ", "
            strSQL &= "HaberBs = " & DecimalToField(mdecHaberBs) & ", "
            strSQL &= "DebeUs = " & DecimalToField(mdecDebeUs) & ", "
            strSQL &= "HaberUs = " & DecimalToField(mdecHaberUs) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompPlanAddId = " & NumberToField(mlngCompPlanAddId) & " "

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
               mlngCompPlanAddId = ToLong(oDataRow("CompPlanAddId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngCompDetId = ToLong(oDataRow("CompDetId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mlngPlanAddId = ToLong(oDataRow("PlanAddId"))
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
               mlngCompPlanAddId = ToLong(oDataRow("CompPlanAddId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompPlanAddId = TableIDGet(mstrTableName, "CompPlanAddId", moConnection)

         If mlngCompPlanAddId = -1 Then
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

      If mlngPlanAddId = 0 Then
         strMsg &= "Seleccione el Analítico Adicional" & vbCrLf
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
         strSQL &= " FROM tblCompPlanAdd "

         If Not boolReplace Then
            strSQL &= " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanAdd.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId)
         Else
            strSQL &= " WHERE  tblCompPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPlanAdd.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompPlanAdd.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId)
            strSQL &= " AND  tblCompPlanAdd.CompPlanAddId <> " & NumberToField(mlngCompPlanAddId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngCompPlanAddId)
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

