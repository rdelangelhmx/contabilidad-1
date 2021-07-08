Imports System.Data
Imports System.Data.OleDb

Public Class clsPlan
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsPlanVM
   Public VMNew As New clsPlanVM

   Private mlngPlanId As Long
   Private mlngEmpresaId As Long
   Private mstrPlanDes As String
   Private mstrPlanCta As String
   Private mbytEsAna As Byte
   Private mlngPlanPadreId As Long
   Private mlngOrden As Long
   Private mlngNivel As Long
   Private mlngTipoPlanId As Long
   Private mlngTipoGrupoId As Long
   Private mlngMonedaId As Long
   Private mbytTieneAnaAdd As Byte
   Private mbytMostrarAnaAdd As Byte
   Private mlngSucCCOId As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
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

   Property PlanDes() As String
      Get
         Return mstrPlanDes
      End Get

      Set(ByVal Value As String)
         mstrPlanDes = Value
      End Set
   End Property

   Property PlanCta() As String
      Get
         Return mstrPlanCta
      End Get

      Set(ByVal Value As String)
         mstrPlanCta = Value
      End Set
   End Property

   Property EsAna() As Byte
      Get
         Return mbytEsAna
      End Get

      Set(ByVal Value As Byte)
         mbytEsAna = Value
      End Set
   End Property

   Property PlanPadreId() As Long
      Get
         Return mlngPlanPadreId
      End Get

      Set(ByVal Value As Long)
         mlngPlanPadreId = Value
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

   Property Nivel() As Long
      Get
         Return mlngNivel
      End Get

      Set(ByVal Value As Long)
         mlngNivel = Value
      End Set
   End Property

   Property TipoPlanId() As Long
      Get
         Return mlngTipoPlanId
      End Get

      Set(ByVal Value As Long)
         mlngTipoPlanId = Value
      End Set
   End Property

   Property TipoGrupoId() As Long
      Get
         Return mlngTipoGrupoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoGrupoId = Value
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

   Property TieneAnaAdd() As Byte
      Get
         Return mbytTieneAnaAdd
      End Get

      Set(ByVal Value As Byte)
         mbytTieneAnaAdd = Value
      End Set
   End Property

   Property MostrarAnaAdd() As Byte
      Get
         Return mbytMostrarAnaAdd
      End Get

      Set(ByVal Value As Byte)
         mbytMostrarAnaAdd = Value
      End Set
   End Property

   Property SucCCOId() As Long
      Get
         Return mlngSucCCOId
      End Get

      Set(ByVal Value As Long)
         mlngSucCCOId = Value
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
      GridCheck = 3
      GridFind = 4
      GridPadreCheck = 5
      MultiComboBox = 6
      AllconID = 7
      GridFindCheck = 8
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      PlanDes = 2
      LIKEPlanDes = 3
      Grid = 4
      GridEsAna = 5
      PlanPadreId = 6
      Orden = 7
      TieneAnaAdd = 8
      EsAna = 9
      TipoPlanId = 10
      MonedaId = 11
      GridEstadoResultado = 12
      GridBalance = 13
      EstadoResultado = 14
      OrdenDeudora = 15
      OrdenAcreedora = 16
      GridTipoPlanId = 17
      GridTieneAnaAdd = 18
      EmpresaId = 19
      CajaBanco = 20
      GridFind = 21
      GridSucCCOId = 22
      SucCCOId = 23
      PlanCta = 24
      EsAnaGrupo = 25
      GridTipoPlanId_MonedaId = 26
      GridTipoPlanId_INNER = 27
      GridTipoPlanId_EsAna = 28
      ConsolidarEstadoResultado = 29
      PlanIdInactivos = 30
      EsAnaTipoPlanId = 31
      GridFindCheck = 32
      GridBalanceEsAna = 33
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PlanId = 1
      PlanDes = 2
      PlanCta = 3
      Grid = 4
      Orden = 5
      TipoGrupoyPlanCta = 6
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

   Public Enum RowMaxFilters As Byte
      Orden = 1
   End Enum

   '*********************************************************
   '* The following filters will change for each
   '* data access class
   '*********************************************************
   Private mintSelectFilter As SelectFilters
   Private mintWhereFilter As WhereFilters
   Private mintOrderByFilter As OrderByFilters
   Private mintInsertFilter As InsertFilters
   Private mintUpdateFilter As UpdateFilters
   Private mintDeleteFilter As DeleteFilters
   Private mintRowCountFilter As RowCountFilters
   Private mintRowMaxFilter As RowMaxFilters

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

   Property RowMaxFilter() As RowMaxFilters
      Get
         Return mintRowMaxFilter
      End Get

      Set(ByVal Value As RowMaxFilters)
         mintRowMaxFilter = Value
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
      mstrTableName = "tblPlan"
      mstrClassName = "clsPlan"

      moConnection = New OleDbConnection
      VMNew = New clsPlanVM

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
      mlngPlanId = 0
      mlngEmpresaId = 0
      mstrPlanDes = ""
      mstrPlanCta = ""
      mbytEsAna = 0
      mlngPlanPadreId = 0
      mlngOrden = 0
      mlngNivel = 0
      mlngTipoPlanId = 0
      mlngTipoGrupoId = 0
      mlngMonedaId = 0
      mbytTieneAnaAdd = 0
      mbytMostrarAnaAdd = 0
      mlngSucCCOId = 0
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
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblPlan.TipoPlanId,  "
            strSQL &= "    tblPlan.TipoGrupoId,  "
            strSQL &= "    tblPlan.MonedaId,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblPlan.MostrarAnaAdd,  "
            strSQL &= "    tblPlan.SucCCOId,  "
            strSQL &= "    tblPlan.EstadoId,  "
            strSQL &= "    tblPlan.sLastUpdate_id,  "
            strSQL &= "    tblPlan.dtLastUpdate_dt,  "
            strSQL &= "    tblPlan.iConcurrency_id  "
            strSQL &= " FROM tblPlan "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanDes  "
            strSQL &= " FROM tblPlan "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.TipoGrupoId,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblTipoPlan.TipoPlanId,  "
            strSQL &= "    tblTipoPlan.TipoPlanDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblPlan.MostrarAnaAdd,  "
            strSQL &= "    tblSucCCO.SucCCOId,  "
            strSQL &= "    tblSucCCO.SucCCODes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlan, tblTipoPlan, tblMoneda, tblSucCCO, tblEstado "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblTipoPlan.TipoPlanId,  "
            strSQL &= "    tblTipoPlan.TipoPlanDes,  "
            strSQL &= "    tblPlan.TipoGrupoId,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblSucCCO.SucCCOId,  "
            strSQL &= "    tblSucCCO.SucCCODes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlan, tblTipoPlan, tblMoneda, tblSucCCO, tblEstado "

         Case SelectFilters.GridFind
            strSQL = " SELECT  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlanPadre.PlanCta As PlanCtaPadre,  "
            strSQL &= "    tblPlanPadre.PlanDes As PlanDesPadre,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblTipoPlan.TipoPlanId,  "
            strSQL &= "    tblTipoPlan.TipoPlanDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblSucCCO.SucCCOId,  "
            strSQL &= "    tblSucCCO.SucCCODes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlan, tblPlan As tblPlanPadre, tblTipoPlan, tblMoneda, tblSucCCO, tblEstado "

         Case SelectFilters.GridPadreCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlanPadre.PlanCta As PlanCtaPadre,  "
            strSQL &= "    tblPlanPadre.PlanDes As PlanDesPadre,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblTipoPlan.TipoPlanId,  "
            strSQL &= "    tblTipoPlan.TipoPlanDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblSucCCO.SucCCOId,  "
            strSQL &= "    tblSucCCO.SucCCODes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlan, tblPlan As tblPlanPadre, tblTipoPlan, tblMoneda, tblSucCCO, tblEstado "

         Case SelectFilters.MultiComboBox
            strSQL = " SELECT  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.TipoGrupoId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    (tblPlan.PlanDes + ' - ' + tblPlan.PlanCta) As PlanDes,  "
            strSQL &= "    tblPlan.EstadoId  "
            strSQL &= " FROM tblPlan "

         Case SelectFilters.AllconID
            strSQL = " SELECT  "
            strSQL &= "    " & mlngOrden & " as Id,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblPlan.TipoPlanId,  "
            strSQL &= "    tblTipoPlan.TipoPlanDes,  "
            strSQL &= "    tblPlan.TipoGrupoId,  "
            strSQL &= "    tblPlan.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblPlan.SucCCOId,  "
            strSQL &= "    tblSucCCO.SucCCODes,  "
            strSQL &= "    tblPlan.EstadoId  "
            strSQL &= " FROM tblPlan, tblTipoPlan, tblMoneda, tblSucCCO "

         Case SelectFilters.GridFindCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.EmpresaId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlanPadre.PlanCta As PlanCtaPadre,  "
            strSQL &= "    tblPlanPadre.PlanDes As PlanDesPadre,  "
            strSQL &= "    tblPlan.EsAna,  "
            strSQL &= "    tblPlan.PlanPadreId,  "
            strSQL &= "    tblPlan.Orden,  "
            strSQL &= "    tblPlan.Nivel,  "
            strSQL &= "    tblTipoPlan.TipoPlanId,  "
            strSQL &= "    tblTipoPlan.TipoPlanDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblPlan.TieneAnaAdd,  "
            strSQL &= "    tblSucCCO.SucCCOId,  "
            strSQL &= "    tblSucCCO.SucCCODes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlan, tblPlan As tblPlanPadre, tblTipoPlan, tblMoneda, tblSucCCO, tblEstado "
      End Select

      strSQL &= WhereFilterGet()

      strSQL &= OrderByFilterGet()

      mstrSQL = strSQL

      Return strSQL
   End Function

   Private Function WhereFilterGet() As String
      Dim strSQL As String

      Select Case mintWhereFilter
         Case WhereFilters.PrimaryKey
            strSQL = " WHERE  tblPlan.PlanId = " & NumberToField(mlngPlanId)

         Case WhereFilters.PlanDes
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND tblPlan.PlanDes = " & StringToField(mstrPlanDes)

         Case WhereFilters.LIKEPlanDes
            strSQL = " WHERE  tblPlan.PlanDes LIKE " & StringToField(mstrPlanDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)

         Case WhereFilters.GridEsAna
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)

         Case WhereFilters.GridTipoPlanId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.TipoPlanId = " & NumberToField(mlngTipoPlanId)

         Case WhereFilters.PlanPadreId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)
            If mlngPlanId <> 0 Then strSQL &= " AND  tblPlan.PlanId <> " & NumberToField(mlngPlanId)

         Case WhereFilters.Orden
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)
            strSQL &= " AND  tblPlan.Orden = " & NumberToField(mlngOrden)

         Case WhereFilters.TieneAnaAdd
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TieneAnaAdd = " & NumberToField(mbytTieneAnaAdd)

            If mlngEstadoId = clsEstado.ACTIVO Then
               If mlngPlanId = 0 Then
                  strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(clsEstado.ACTIVO)
               Else
                  strSQL &= " AND  (tblPlan.EstadoId = " & NumberToField(clsEstado.ACTIVO)
                  strSQL &= " OR    tblPlan.PlanId = " & NumberToField(mlngPlanId) & " )"
               End If
            End If
         Case WhereFilters.EsAna
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)

            If mlngEstadoId = clsEstado.ACTIVO Then
               If mlngPlanId = 0 Then
                  strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(clsEstado.ACTIVO)
               Else
                  strSQL &= " AND  (tblPlan.EstadoId = " & NumberToField(clsEstado.ACTIVO)
                  strSQL &= " OR    tblPlan.PlanId = " & NumberToField(mlngPlanId) & " )"
               End If
            End If

         Case WhereFilters.TipoPlanId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = " & NumberToField(mlngTipoPlanId)

            If mlngEstadoId = clsEstado.ACTIVO Then
               If mlngPlanId = 0 Then
                  strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(clsEstado.ACTIVO)
               Else
                  strSQL &= " AND  (tblPlan.EstadoId = " & NumberToField(clsEstado.ACTIVO)
                  strSQL &= " OR    tblPlan.PlanId = " & NumberToField(mlngPlanId) & " )"
               End If
            End If

         Case WhereFilters.MonedaId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  tblPlan.MonedaId = " & NumberToField(mlngMonedaId)

         Case WhereFilters.GridEstadoResultado
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)
            strSQL &= " AND  (tblPlan.PlanCTA = '4' "
            strSQL &= " OR  tblPlan.PlanCTA = '5' "
            strSQL &= " OR  tblPlan.PlanCTA = '6') "

         Case WhereFilters.GridBalance
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.PlanPadreId = " & NumberToField(mlngPlanPadreId)
            strSQL &= " AND  (tblPlan.PlanCTA = '1' "
            strSQL &= " OR  tblPlan.PlanCTA = '2' "
            strSQL &= " OR  tblPlan.PlanCTA = '3') "

         Case WhereFilters.EstadoResultado
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = 1 "
            strSQL &= " AND  tblPlan.TipoGrupoId IN (4,5,6) "

         Case WhereFilters.OrdenDeudora
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = 1 "
            strSQL &= " AND  tblPlan.PlanCTA LIKE " & StringToField("7" & LikeOperator)

         Case WhereFilters.OrdenAcreedora
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = 1 "
            strSQL &= " AND  tblPlan.PlanCTA LIKE " & StringToField("8" & LikeOperator)

         Case WhereFilters.GridTieneAnaAdd
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.TieneAnaAdd = " & NumberToField(mbytTieneAnaAdd)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.CajaBanco
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  (tblPlan.TipoPlanId = 2 "
            strSQL &= " OR  tblPlan.TipoPlanId = 3) "

         Case WhereFilters.GridFind
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanPadreId = tblPlanPadre.PlanId "
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)

         Case WhereFilters.GridSucCCOId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  tblPlan.SucCCOId = " & NumberToField(mlngSucCCOId)

         Case WhereFilters.SucCCOId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  tblPlan.SucCCOId = " & NumberToField(mlngSucCCOId)

         Case WhereFilters.PlanCta
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)

         Case WhereFilters.EsAnaGrupo
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  tblPlan.PlanCTA LIKE " & StringToField(mstrPlanCta & LikeOperator)

         Case WhereFilters.GridTipoPlanId_MonedaId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.TipoPlanId = " & NumberToField(mlngTipoPlanId)
            strSQL &= " AND  tblPlan.MonedaId = " & NumberToField(mlngMonedaId)

         Case WhereFilters.GridTipoPlanId_INNER
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.PlanId IN " & ToStr(mstrPlanDes)

         Case WhereFilters.GridTipoPlanId_EsAna
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.TipoPlanId = " & NumberToField(mlngTipoPlanId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)

         Case WhereFilters.ConsolidarEstadoResultado
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(clsEstado.ACTIVO)
            strSQL &= " AND  tblPlan.TipoGrupoId IN " & mstrPlanDes

         Case WhereFilters.PlanIdInactivos
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblPlan.PlanId IN " & mstrPlanDes

         Case WhereFilters.EsAnaTipoPlanId
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  tblPlan.TipoPlanId = " & NumberToField(mlngTipoPlanId)

            If mlngEstadoId = clsEstado.ACTIVO Then
               If mlngPlanId = 0 Then
                  strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(clsEstado.ACTIVO)
               Else
                  strSQL &= " AND  (tblPlan.EstadoId = " & NumberToField(clsEstado.ACTIVO)
                  strSQL &= " OR    tblPlan.PlanId = " & NumberToField(mlngPlanId) & " )"
               End If
            End If

         Case WhereFilters.GridFindCheck
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanPadreId = tblPlanPadre.PlanId "
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)

         Case WhereFilters.GridBalanceEsAna
            strSQL = " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.TipoPlanId = tblTipoPlan.TipoPlanId "
            strSQL &= " AND  tblPlan.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblPlan.SucCCOId = tblSucCCO.SucCCOId "
            strSQL &= " AND  tblPlan.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlan.EsAna = " & NumberToField(mbytEsAna)
            strSQL &= " AND  tblPlan.TipoGrupoId in (1,2,3) "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PlanId
            strSQL = " ORDER BY tblPlan.PlanId "

         Case OrderByFilters.PlanDes
            strSQL = " ORDER BY tblPlan.PlanDes "

         Case OrderByFilters.PlanCta
            strSQL = " ORDER BY tblPlan.PlanCta "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblPlan.PlanDes "

         Case OrderByFilters.Orden
            strSQL = " ORDER BY tblPlan.Orden "

         Case OrderByFilters.TipoGrupoyPlanCta
            strSQL = " ORDER BY tblPlan.TipoGrupoId, tblPlan.PlanCta "
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

   Private Function RowMaxSQL() As String
      Dim strSQL As String

      Select Case mintRowMaxFilter
         Case RowMaxFilters.Orden
            strSQL = "SELECT Max(Orden) FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Protected Overrides Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO tblPlan ("
            strSQL &= "PlanId, "
            strSQL &= "EmpresaId, "
            strSQL &= "PlanDes, "
            strSQL &= "PlanCta, "
            strSQL &= "EsAna, "
            strSQL &= "PlanPadreId, "
            strSQL &= "Orden, "
            strSQL &= "Nivel, "
            strSQL &= "TipoPlanId, "
            strSQL &= "TipoGrupoId, "
            strSQL &= "MonedaId, "
            strSQL &= "TieneAnaAdd, "
            strSQL &= "MostrarAnaAdd, "
            strSQL &= "SucCCOId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrPlanDes) & ", "
            strSQL &= StringToField(mstrPlanCta) & ", "
            strSQL &= NumberToField(mbytEsAna) & ", "
            strSQL &= NumberToField(mlngPlanPadreId) & ", "
            strSQL &= NumberToField(mlngOrden) & ", "
            strSQL &= NumberToField(mlngNivel) & ", "
            strSQL &= NumberToField(mlngTipoPlanId) & ", "
            strSQL &= NumberToField(mlngTipoGrupoId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= NumberToField(mbytTieneAnaAdd) & ", "
            strSQL &= NumberToField(mbytMostrarAnaAdd) & ", "
            strSQL &= NumberToField(mlngSucCCOId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblPlan SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "PlanDes = " & StringToField(mstrPlanDes) & ", "
            strSQL &= "PlanCta = " & StringToField(mstrPlanCta) & ", "
            strSQL &= "EsAna = " & NumberToField(mbytEsAna) & ", "
            strSQL &= "PlanPadreId = " & NumberToField(mlngPlanPadreId) & ", "
            strSQL &= "Orden = " & NumberToField(mlngOrden) & ", "
            strSQL &= "Nivel = " & NumberToField(mlngNivel) & ", "
            strSQL &= "TipoPlanId = " & NumberToField(mlngTipoPlanId) & ", "
            strSQL &= "TipoGrupoId = " & NumberToField(mlngTipoGrupoId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TieneAnaAdd = " & NumberToField(mbytTieneAnaAdd) & ", "
            strSQL &= "MostrarAnaAdd = " & NumberToField(mbytMostrarAnaAdd) & ", "
            strSQL &= "SucCCOId = " & NumberToField(mlngSucCCOId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PlanId = " & NumberToField(mlngPlanId) & " "

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
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrPlanDes = ToStr(oDataRow("PlanDes"))
               mstrPlanCta = ToStr(oDataRow("PlanCta"))
               mbytEsAna = ToByte(oDataRow("EsAna"))
               mlngPlanPadreId = ToLong(oDataRow("PlanPadreId"))
               mlngOrden = ToLong(oDataRow("Orden"))
               mlngNivel = ToLong(oDataRow("Nivel"))
               mlngTipoPlanId = ToLong(oDataRow("TipoPlanId"))
               mlngTipoGrupoId = ToLong(oDataRow("TipoGrupoId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mbytTieneAnaAdd = ToByte(oDataRow("TieneAnaAdd"))
               mbytMostrarAnaAdd = ToByte(oDataRow("MostrarAnaAdd"))
               mlngSucCCOId = ToLong(oDataRow("SucCCOId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mstrPlanDes = ToStr(oDataRow("PlanDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPlanId = TableIDGet(mstrTableName, "PlanId", moConnection)

         If mlngPlanId = -1 Then
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

      If mstrPlanDes.Length() = 0 Then
         strMsg &= "Descripción de Cuenta Inválida" & vbCrLf
      End If

      If mstrPlanCta.Length() = 0 Then
         strMsg &= "Código de Cuenta Inválido" & vbCrLf
      End If

      'If mlngPlanPadreId = 0 Then
      '   strMsg &= "Cuenta Padre Inválida" & vbCrLf
      'End If

      If mlngTipoGrupoId = 0 Then
         strMsg &= "Grupo de Cuenta Inválido" & vbCrLf
      End If

      If mlngOrden = 0 Then
         strMsg &= "Orden Inválido" & vbCrLf
      End If

      If mlngNivel = 0 Then
         strMsg &= "Nivel Inválido" & vbCrLf
      End If

      If mbytEsAna Then
         If mlngMonedaId = 0 Then
            strMsg &= "Moneda Inválida" & vbCrLf
         End If
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
         strSQL &= " FROM tblPlan "

         If Not boolReplace Then
            strSQL &= " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)
            strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
         Else
            strSQL &= " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)
            strSQL &= " AND  tblPlan.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblPlan.PlanId <> " & NumberToField(mlngPlanId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngPlanId)
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

   Public Function InsertOnly() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      InsertOnly = False

      Try
         If GetNewPrimaryKey() Then
            Call OpenConection()

            oCommand = New OleDbCommand
            oCommand.CommandText = InsertSQL()
            oCommand.Connection = moConnection

            intRecordsAffected = oCommand.ExecuteNonQuery()

            If intRecordsAffected > 0 Then
               InsertOnly = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function RowMax() As Integer
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowMaxSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = ToInteger(oCommand.ExecuteScalar)

         Return intRecordsAffected

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
      Dim strSQL As String = ""
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Dim oDataTable As New DataTable
      Dim dbNull As System.DBNull
      Dim oRestrictions() As Object = {dbNull, dbNull, dbNull, "TABLE"}

      Try
         Call OpenConection()
         oDataTable = moConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, oRestrictions)

         strSQL = " SELECT "
         strSQL &= " Count(*) As NumRecs "
         strSQL &= " FROM tblPlan "
         strSQL &= " WHERE tblPlan.PlanId = " & NumberToField(mlngPlanId)

         strSQL &= " AND (tblPlan.PlanId IN "
         strSQL &= "   (SELECT DISTINCT PlanPadreId "
         strSQL &= "    FROM  tblPlan "
         strSQL &= "    WHERE tblPlan.PlanPadreId = " & NumberToField(mlngPlanId) & ")"

         ''tblBanco(PlanId)
         If TableFind(oDataTable, "tblBanco") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanId "
            strSQL &= "      FROM  tblBanco "
            strSQL &= "      WHERE tblBanco.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tblCheque(PlanId)
         If TableFind(oDataTable, "tblCheque") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanId "
            strSQL &= "      FROM  tblCheque "
            strSQL &= "      WHERE tblCheque.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tblCompDet(PlanId)
         ''tblCompCentroCostoDet(PlanId)
         ''tblCompCheque(PlanId)
         ''tblCompPlanAdd(PlanId)
         If TableFind(oDataTable, "tblCompDet") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanId "
            strSQL &= "      FROM  tblCompDet "
            strSQL &= "      WHERE tblCompDet.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tblEmpresaPara(PlanAitbId)
         ''tblEmpresaPara(PlanCreDifId)
         ''tblEmpresaPara(PlanCreId)
         ''tblEmpresaPara(PlanCreRetId)
         ''tblEmpresaPara(PlanDebDifId)
         ''tblEmpresaPara(PlanDebId)
         ''tblEmpresaPara(PlanDifId)
         ''tblEmpresaPara(PlanExentoId)
         ''tblEmpresaPara(PlanIceIehdDifId)
         ''tblEmpresaPara(PlanIceIehdId)
         ''tblEmpresaPara(PlanITFId)
         ''tblEmpresaPara(PlanITId)
         ''tblEmpresaPara(PlanITPId)
         ''tblEmpresaPara(PlanITRetId)
         ''tblEmpresaPara(PlanIUERetBieId)
         ''tblEmpresaPara(PlanIUERetSerId)
         ''tblEmpresaPara(PlanResId)
         If TableFind(oDataTable, "tblEmpresaPara") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanAitbId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanAitbId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanCreDifId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanCreDifId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanCreId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanCreId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanCreRetId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanCreRetId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanDebDifId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanDebDifId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanDebId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanDebId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanDifId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanDifId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanExentoId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanExentoId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanIceIehdDifId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanIceIehdDifId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanIceIehdId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanIceIehdId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanITFId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanITFId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanITId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanITId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanITPId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanITPId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanITRetId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanITRetId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanIUERetBieId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanIUERetBieId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanIUERetSerId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanIUERetSerId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanResId "
            strSQL &= "      FROM  tblEmpresaPara "
            strSQL &= "      WHERE tblEmpresaPara.PlanResId = " & NumberToField(mlngPlanId) & ")"
         End If

         If TableFind(oDataTable, "tblFacturaPara") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanId "
            strSQL &= "      FROM  tblFacturaPara "
            strSQL &= "      WHERE tblFacturaPara.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         If TableFind(oDataTable, "tblFacturaPara") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanId "
            strSQL &= "      FROM  tblFacturaPara "
            strSQL &= "      WHERE tblFacturaPara.PlanId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "     (SELECT DISTINCT PlanIdIng "
            strSQL &= "      FROM  tblFacturaPara "
            strSQL &= "      WHERE tblFacturaPara.PlanIdIng = " & NumberToField(mlngPlanId) & ")"
         End If

         If TableFind(oDataTable, "tblPersonal") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tblPersonal "
            strSQL &= "    WHERE tblPersonal.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         If TableFind(oDataTable, "tblPlanAdd") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tblPlanAdd "
            strSQL &= "    WHERE tblPlanAdd.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         If TableFind(oDataTable, "tblPoliza") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tblPoliza "
            strSQL &= "    WHERE tblPoliza.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tblRegRUC(PlanId)
         If TableFind(oDataTable, "tblRegRUC") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tblRegRUC "
            strSQL &= "    WHERE tblRegRUC.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''acfActivoFijo(PlanDepAcuID)
         ''acfActivoFijo(PlanDepID)
         ''acfActivoFijo(PlanVOID)
         If TableFind(oDataTable, "acfActivoFijo") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanDepAcuID "
            strSQL &= "    FROM  acfActivoFijo "
            strSQL &= "    WHERE acfActivoFijo.PlanDepAcuID = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanDepID "
            strSQL &= "    FROM  acfActivoFijo "
            strSQL &= "    WHERE acfActivoFijo.PlanDepID = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanVOID "
            strSQL &= "    FROM  acfActivoFijo "
            strSQL &= "    WHERE acfActivoFijo.PlanVOID = " & NumberToField(mlngPlanId) & ")"
         End If

         ''acfActivoPara(PlanAjusteInflacionId)
         ''acfActivoPara(PlanBajaId)
         'If TableFind(oDataTable, "acfActivoPara") Then
         '   strSQL &= " OR tblPlan.PlanId IN "
         '   strSQL &= "   (SELECT DISTINCT PlanAjusteInflacionId "
         '   strSQL &= "    FROM  acfActivoPara "
         '   strSQL &= "    WHERE acfActivoPara.PlanAjusteInflacionId = " & NumberToField(mlngPlanId) & ")"
         '   strSQL &= " OR tblPlan.PlanId IN "
         '   strSQL &= "   (SELECT DISTINCT PlanBajaId "
         '   strSQL &= "    FROM  acfActivoPara "
         '   strSQL &= "    WHERE acfActivoPara.PlanBajaId = " & NumberToField(mlngPlanId) & ")"
         'End If

         ''agrAgricolaParaPlan(PlanIdCosIni)
         If TableFind(oDataTable, "agrAgricolaParaPlan") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdCosIni "
            strSQL &= "    FROM  agrAgricolaParaPlan "
            strSQL &= "    WHERE agrAgricolaParaPlan.PlanIdCosIni = " & NumberToField(mlngPlanId) & ")"
         End If

         ''apoClienteMov(PlanId)
         If TableFind(oDataTable, "apoClienteMov") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  apoClienteMov "
            strSQL &= "    WHERE apoClienteMov.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''apoPago(PlanId)
         If TableFind(oDataTable, "apoPago") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  apoPago "
            strSQL &= "    WHERE apoPago.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comAjuste(PlanId)
         If TableFind(oDataTable, "comAjuste") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comAjuste "
            strSQL &= "    WHERE comAjuste.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comAnticipo(PlanId)
         ''comAnticipoDet(PlanId)
         If TableFind(oDataTable, "comAnticipo") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comAnticipo "
            strSQL &= "    WHERE comAnticipo.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comCompra(PlanId)
         If TableFind(oDataTable, "comCompra") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comCompra "
            strSQL &= "    WHERE comCompra.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comCompraDet(PlanIdAct)
         If TableFind(oDataTable, "comCompraDet") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAct "
            strSQL &= "    FROM  comCompraDet "
            strSQL &= "    WHERE comCompraDet.PlanIdAct = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comCompraOtroCosto(PlanId)
         If TableFind(oDataTable, "comCompraOtroCosto") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comCompraOtroCosto "
            strSQL &= "    WHERE comCompraOtroCosto.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comDevCompra(PlanId)
         If TableFind(oDataTable, "comDevCompra") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comDevCompra "
            strSQL &= "    WHERE comDevCompra.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comPago(PlanId)
         If TableFind(oDataTable, "comPago") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comPago "
            strSQL &= "    WHERE comPago.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comPlanDescuento(PlanId)
         If TableFind(oDataTable, "comPlanDescuento") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comPlanDescuento "
            strSQL &= "    WHERE comPlanDescuento.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comPlanOtroCosto(PlanId)
         If TableFind(oDataTable, "comPlanOtroCosto") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comPlanOtroCosto "
            strSQL &= "    WHERE comPlanOtroCosto.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comPlanRecargo(PlanId)
         If TableFind(oDataTable, "comPlanRecargo") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comPlanRecargo "
            strSQL &= "    WHERE comPlanRecargo.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comProveedor(PlanIdAct)
         ''comProveedor(PlanIdInt)
         ''comProveedor(PlanIdPas)
         If TableFind(oDataTable, "comProveedor") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAct "
            strSQL &= "    FROM  comProveedor "
            strSQL &= "    WHERE comProveedor.PlanIdAct = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdInt "
            strSQL &= "    FROM  comProveedor "
            strSQL &= "    WHERE comProveedor.PlanIdInt = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPas "
            strSQL &= "    FROM  comProveedor "
            strSQL &= "    WHERE comProveedor.PlanIdPas = " & NumberToField(mlngPlanId) & ")"
         End If

         ''comProveedorMov(PlanId)
         If TableFind(oDataTable, "comProveedorMov") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  comProveedorMov "
            strSQL &= "    WHERE comProveedorMov.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''csmMovEquipo(PlanId)
         ''csmMovEquipoDet(PlanId)
         If TableFind(oDataTable, "csmMovEquipo") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  csmMovEquipo "
            strSQL &= "    WHERE csmMovEquipo.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''inmCliente(PlanIdAct)
         ''inmCliente(PlanIdForm)
         ''inmCliente(PlanIdInt)
         ''inmCliente(PlanIdIntPen)
         If TableFind(oDataTable, "inmCliente") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAct "
            strSQL &= "    FROM  inmCliente "
            strSQL &= "    WHERE inmCliente.PlanIdAct = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdForm "
            strSQL &= "    FROM  inmCliente "
            strSQL &= "    WHERE inmCliente.PlanIdForm = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdInt "
            strSQL &= "    FROM  inmCliente "
            strSQL &= "    WHERE inmCliente.PlanIdInt = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdIntPen "
            strSQL &= "    FROM  inmCliente "
            strSQL &= "    WHERE inmCliente.PlanIdIntPen = " & NumberToField(mlngPlanId) & ")"
         End If

         ''inmClienteMov(PlanId)
         If TableFind(oDataTable, "inmClienteMov") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  inmClienteMov "
            strSQL &= "    WHERE inmClienteMov.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''inmLote(PlanIdIng)
         If TableFind(oDataTable, "inmLote") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdIng "
            strSQL &= "    FROM  inmLote "
            strSQL &= "    WHERE inmLote.PlanIdIng = " & NumberToField(mlngPlanId) & ")"
         End If

         ''inmPago(PlanId)
         If TableFind(oDataTable, "inmPago") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  inmPago "
            strSQL &= "    WHERE inmPago.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''invAjuste(PlanId)
         If TableFind(oDataTable, "invAjuste") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  invAjuste "
            strSQL &= "    WHERE invAjuste.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''invAjusteUFV(PlanId)
         If TableFind(oDataTable, "invAjusteUFV") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  invAjusteUFV "
            strSQL &= "    WHERE invAjusteUFV.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''invNota(PlanId)
         If TableFind(oDataTable, "invNota") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  invNota "
            strSQL &= "    WHERE invNota.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''invPlanGrupo(PlanIdAct)
         ''invPlanGrupo(PlanIdCos)
         ''invPlanGrupo(PlanIdIng)
         ''invPlanGrupo(PlanIdTra)
         If TableFind(oDataTable, "invPlanGrupo") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAct "
            strSQL &= "    FROM  invPlanGrupo "
            strSQL &= "    WHERE invPlanGrupo.PlanIdAct = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdCos "
            strSQL &= "    FROM  invPlanGrupo "
            strSQL &= "    WHERE invPlanGrupo.PlanIdCos = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdIng "
            strSQL &= "    FROM  invPlanGrupo "
            strSQL &= "    WHERE invPlanGrupo.PlanIdIng = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdTra "
            strSQL &= "    FROM  invPlanGrupo "
            strSQL &= "    WHERE invPlanGrupo.PlanIdTra = " & NumberToField(mlngPlanId) & ")"
         End If

         ''pdeParteDiarioDet(PlanIdCos)
         ''pdeParteDiarioDet(PlanIdIng)
         If TableFind(oDataTable, "pdeParteDiarioDet") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdCos "
            strSQL &= "    FROM  pdeParteDiarioDet "
            strSQL &= "    WHERE pdeParteDiarioDet.PlanIdCos = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdIng "
            strSQL &= "    FROM  pdeParteDiarioDet "
            strSQL &= "    WHERE pdeParteDiarioDet.PlanIdIng = " & NumberToField(mlngPlanId) & ")"
         End If

         ''pdeTarea(PlanIdCos)
         ''pdeTarea(PlanIdIng)
         ''pdeTarea(PlanIdIngExt)
         If TableFind(oDataTable, "pdeTarea") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdCos "
            strSQL &= "    FROM  pdeTarea "
            strSQL &= "    WHERE pdeTarea.PlanIdCos = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdIng "
            strSQL &= "    FROM  pdeTarea "
            strSQL &= "    WHERE pdeTarea.PlanIdIng = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdIngExt "
            strSQL &= "    FROM  pdeTarea "
            strSQL &= "    WHERE pdeTarea.PlanIdIngExt = " & NumberToField(mlngPlanId) & ")"
         End If

         ''pdvCaja(PlanId)
         If TableFind(oDataTable, "pdvCaja") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  pdvCaja "
            strSQL &= "    WHERE pdvCaja.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''pdvPromotor(PlanId)
         If TableFind(oDataTable, "pdvPromotor") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  pdvPromotor "
            strSQL &= "    WHERE pdvPromotor.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''pfiPresufinDet(PlanId)
         ''pfiPresufinDetDet(PlanId)
         If TableFind(oDataTable, "pfiPresufinDet") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  pfiPresufinDet "
            strSQL &= "    WHERE pfiPresufinDet.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''proProduccionPara(PlanId)
         If TableFind(oDataTable, "proProduccionPara") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  proProduccionPara "
            strSQL &= "    WHERE proProduccionPara.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''rrhAFP(PlanIdApoNac)
         ''rrhAFP(PlanIdApoSol)
         ''rrhAFP(PlanIdComAfp)
         ''rrhAFP(PlanIdCuePer)
         ''rrhAFP(PlanIdPatRie)
         ''rrhAFP(PlanIdPatRiePas)
         ''rrhAFP(PlanIdPatSol)
         ''rrhAFP(PlanIdPatSolPas)
         ''rrhAFP(PlanIdPatViv)
         ''rrhAFP(PlanIdPatVivPas)
         ''rrhAFP(PlanIdRieCom)
         If TableFind(oDataTable, "rrhAFP") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdApoNac "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdApoNac = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdApoSol "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdApoSol = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdComAfp "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdComAfp = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdCuePer "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdCuePer = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPatRie "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdPatRie = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPatRiePas "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdPatRiePas = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPatSol "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdPatSol = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPatSolPas "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdPatSolPas = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPatViv "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdPatViv = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPatVivPas "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdPatVivPas = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdRieCom "
            strSQL &= "    FROM  rrhAFP "
            strSQL &= "    WHERE rrhAFP.PlanIdRieCom = " & NumberToField(mlngPlanId) & ")"
         End If

         ''rrhCtaBanco(PlanId)
         If TableFind(oDataTable, "rrhCtaBanco") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  rrhCtaBanco "
            strSQL &= "    WHERE rrhCtaBanco.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''rrhDescuento(PlanIdDesc)
         If TableFind(oDataTable, "rrhDescuento") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdDesc "
            strSQL &= "    FROM  rrhDescuento "
            strSQL &= "    WHERE rrhDescuento.PlanIdDesc = " & NumberToField(mlngPlanId) & ")"
         End If

         ''rrhEmpleado(PlanId)
         If TableFind(oDataTable, "rrhEmpleado") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  rrhEmpleado "
            strSQL &= "    WHERE rrhEmpleado.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''rrhEmpleadoAna(PlanId)
         If TableFind(oDataTable, "rrhEmpleadoAna") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  rrhEmpleadoAna "
            strSQL &= "    WHERE rrhEmpleadoAna.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''rrhIngreso(PlanIdIng)
         If TableFind(oDataTable, "rrhIngreso") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdIng "
            strSQL &= "    FROM  rrhIngreso "
            strSQL &= "    WHERE rrhIngreso.PlanIdIng = " & NumberToField(mlngPlanId) & ")"
         End If

         ''rrhRRHHPlan(PlanIdAgui)
         ''rrhRRHHPlan(PlanIdAguiPre)
         ''rrhRRHHPlan(PlanIdBonAnt)
         ''rrhRRHHPlan(PlanIdFini)
         ''rrhRRHHPlan(PlanIdFiniPre)
         ''rrhRRHHPlan(PlanIdHorExt)
         ''rrhRRHHPlan(PlanIdHorExtDom)
         ''rrhRRHHPlan(PlanIdHorExtFer)
         ''rrhRRHHPlan(PlanIdInde)
         ''rrhRRHHPlan(PlanIdIndePre)
         ''rrhRRHHPlan(PlanIdLiqPag)
         ''rrhRRHHPlan(PlanIdPrima)
         ''rrhRRHHPlan(PlanIdPrimaPre)
         ''rrhRRHHPlan(PlanIdRcIva)
         ''rrhRRHHPlan(PlanIdSalDom)
         ''rrhRRHHPlan(PlanIdSalGan)
         ''rrhRRHHPlan(PlanIdSegMed)
         ''rrhRRHHPlan(PlanIdSegMedPas)
         ''rrhRRHHPlan(PlanIdVaca)
         ''rrhRRHHPlan(PlanIdVacaPre)
         If TableFind(oDataTable, "rrhRRHHPlan") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAgui "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdAgui = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAguiPre "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdAguiPre = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdBonAnt "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdBonAnt = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdFini "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdFini = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdFiniPre "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdFiniPre = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdHorExt "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdHorExt = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdHorExtDom "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdHorExtDom = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdHorExtFer "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdHorExtFer = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdInde "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdInde = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdIndePre "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdIndePre = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdLiqPag "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdLiqPag = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdLiqPag "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdLiqPag = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPrima "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdPrima = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPrimaPre "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdPrimaPre = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdRcIva "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdRcIva = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdSalDom "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdSalDom = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdSalGan "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdSalGan = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdSegMed "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdSegMed = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdSegMedPas "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdSegMedPas = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdVaca "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdVaca = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdVacaPre "
            strSQL &= "    FROM  rrhRRHHPlan "
            strSQL &= "    WHERE rrhRRHHPlan.PlanIdVacaPre = " & NumberToField(mlngPlanId) & ")"
         End If

         ''surSurtidorPara(PlanAjusteDifId)
         ''surSurtidorPara(PlanAnticipoId)
         ''surSurtidorPara(PlanGastoBsId)
         ''surSurtidorPara(PlanGastoUsId)
         ''surSurtidorPara(PlanMonedaExtranjeraId)
         ''surSurtidorPara(PlanMonedaNacionalId)
         If TableFind(oDataTable, "surSurtidorPara") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanAjusteDifId "
            strSQL &= "    FROM  surSurtidorPara "
            strSQL &= "    WHERE surSurtidorPara.PlanAjusteDifId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanAnticipoId "
            strSQL &= "    FROM  surSurtidorPara "
            strSQL &= "    WHERE surSurtidorPara.PlanAnticipoId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanGastoBsId "
            strSQL &= "    FROM  surSurtidorPara "
            strSQL &= "    WHERE surSurtidorPara.PlanGastoBsId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanGastoUsId "
            strSQL &= "    FROM  surSurtidorPara "
            strSQL &= "    WHERE surSurtidorPara.PlanGastoUsId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanMonedaExtranjeraId "
            strSQL &= "    FROM  surSurtidorPara "
            strSQL &= "    WHERE surSurtidorPara.PlanMonedaExtranjeraId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanMonedaNacionalId "
            strSQL &= "    FROM  surSurtidorPara "
            strSQL &= "    WHERE surSurtidorPara.PlanMonedaNacionalId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesAplicacion(PlanId)
         If TableFind(oDataTable, "tesAplicacion") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesAplicacion "
            strSQL &= "    WHERE tesAplicacion.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesArqueo(PlanId)
         ''tesArqueoDet(PlanId)
         If TableFind(oDataTable, "tesArqueo") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesArqueo "
            strSQL &= "    WHERE tesArqueo.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesCatalogoCuenta(PlanId)
         If TableFind(oDataTable, "tesCatalogoCuenta") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesCatalogoCuenta "
            strSQL &= "    WHERE tesCatalogoCuenta.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesCobradorCuenta(PlanId)
         If TableFind(oDataTable, "tesCobradorCuenta") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesCobradorCuenta "
            strSQL &= "    WHERE tesCobradorCuenta.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesConcepto(PlanId)
         If TableFind(oDataTable, "tesConcepto") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesConcepto "
            strSQL &= "    WHERE tesConcepto.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesEntidadMov(PlanId)
         If TableFind(oDataTable, "tesEntidadMov") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesEntidadMov "
            strSQL &= "    WHERE tesEntidadMov.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesIngresoEgreso(PlanId)
         ''tesIngresoEgresoDet(PlanId)
         ''tesIngresoEgresoDetDet(PlanId)
         If TableFind(oDataTable, "tesIngresoEgreso") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesIngresoEgreso "
            strSQL &= "    WHERE tesIngresoEgreso.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesPlanifica(PlanId)
         ''tesPlanificaDet(PlanId)
         If TableFind(oDataTable, "tesPlanifica") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesPlanifica "
            strSQL &= "    WHERE tesPlanifica.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesRendicion(PlanId)
         ''tesRetencionDet(PlanId)
         If TableFind(oDataTable, "tesRendicion") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesRendicion "
            strSQL &= "    WHERE tesRendicion.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesTesoreriaPara(PlanArqId)
         ''tesTesoreriaPara(PlanIdMe)
         ''tesTesoreriaPara(PlanidMn)
         If TableFind(oDataTable, "tesTesoreriaPara") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanArqId "
            strSQL &= "    FROM  tesTesoreriaPara "
            strSQL &= "    WHERE tesTesoreriaPara.PlanArqId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdMe "
            strSQL &= "    FROM  tesTesoreriaPara "
            strSQL &= "    WHERE tesTesoreriaPara.PlanIdMe = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanidMn "
            strSQL &= "    FROM  tesTesoreriaPara "
            strSQL &= "    WHERE tesTesoreriaPara.PlanidMn = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesTransaccion(PlanId)
         If TableFind(oDataTable, "tesTransaccion") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesTransaccion "
            strSQL &= "    WHERE tesTransaccion.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesTransPlanifica(PlanId)
         If TableFind(oDataTable, "tesTransPlanifica") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesTransPlanifica "
            strSQL &= "    WHERE tesTransPlanifica.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tesTraspasoPlanAdd(PlanId)
         If TableFind(oDataTable, "tesTraspasoPlanAdd") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tesTraspasoPlanAdd "
            strSQL &= "    WHERE tesTraspasoPlanAdd.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tranCliente(PlanIdAct)
         ''tranCliente(PlanIdDev)
         ''tranCliente(PlanIdInt)
         ''tranCliente(PlanIdPas)
         If TableFind(oDataTable, "tranCliente") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAct "
            strSQL &= "    FROM  tranCliente "
            strSQL &= "    WHERE tranCliente.PlanIdAct = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdDev "
            strSQL &= "    FROM  tranCliente "
            strSQL &= "    WHERE tranCliente.PlanIdDev = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdInt "
            strSQL &= "    FROM  tranCliente "
            strSQL &= "    WHERE tranCliente.PlanIdInt = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPas "
            strSQL &= "    FROM  tranCliente "
            strSQL &= "    WHERE tranCliente.PlanIdPas = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tranClienteMov(PlanId)
         If TableFind(oDataTable, "tranClienteMov") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tranClienteMov "
            strSQL &= "    WHERE tranClienteMov.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tranConductor(PlanIdAct)
         ''tranConductor(PlanIdGast)
         If TableFind(oDataTable, "tranConductor") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAct "
            strSQL &= "    FROM  tranConductor "
            strSQL &= "    WHERE tranConductor.PlanIdAct = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdGast "
            strSQL &= "    FROM  tranConductor "
            strSQL &= "    WHERE tranConductor.PlanIdGast = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tranConductorMov(PlanId)
         If TableFind(oDataTable, "tranConductorMov") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tranConductorMov "
            strSQL &= "    WHERE tranConductorMov.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tranFactura(PlanId)
         If TableFind(oDataTable, "tranFactura") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tranFactura "
            strSQL &= "    WHERE tranFactura.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tranPago(PlanId)
         If TableFind(oDataTable, "tranPago") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tranPago "
            strSQL &= "    WHERE tranPago.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tranVehiculo(PlanIdAct)
         ''tranVehiculo(PlanIdGast)
         If TableFind(oDataTable, "tranVehiculo") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAct "
            strSQL &= "    FROM  tranVehiculo "
            strSQL &= "    WHERE tranVehiculo.PlanIdAct = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdGast "
            strSQL &= "    FROM  tranVehiculo "
            strSQL &= "    WHERE tranVehiculo.PlanIdGast = " & NumberToField(mlngPlanId) & ")"
         End If

         ''tranVehiculoMov(PlanId)
         If TableFind(oDataTable, "tranVehiculoMov") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  tranVehiculoMov "
            strSQL &= "    WHERE tranVehiculoMov.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venAjuste(PlanId)
         If TableFind(oDataTable, "venAjuste") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venAjuste "
            strSQL &= "    WHERE venAjuste.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venAnticipo(PlanId)
         ''venAnticipoDet(PlanId)
         If TableFind(oDataTable, "venAnticipo") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venAnticipo "
            strSQL &= "    WHERE venAnticipo.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venCliente(PlanIdAct)
         ''venCliente(PlanIdDev)
         ''venCliente(PlanIdInt)
         ''venCliente(PlanIdPas)
         If TableFind(oDataTable, "venCliente") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdAct "
            strSQL &= "    FROM  venCliente "
            strSQL &= "    WHERE venCliente.PlanIdAct = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdDev "
            strSQL &= "    FROM  venCliente "
            strSQL &= "    WHERE venCliente.PlanIdDev = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdInt "
            strSQL &= "    FROM  venCliente "
            strSQL &= "    WHERE venCliente.PlanIdInt = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdPas "
            strSQL &= "    FROM  venCliente "
            strSQL &= "    WHERE venCliente.PlanIdPas = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venClienteMov(PlanId)
         If TableFind(oDataTable, "venClienteMov") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venClienteMov "
            strSQL &= "    WHERE venClienteMov.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venCobrador(PlanId)
         ''venCobrador(PlanSoId)
         If TableFind(oDataTable, "venCobrador") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venCobrador "
            strSQL &= "    WHERE venCobrador.PlanId = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanSoId "
            strSQL &= "    FROM  venCobrador "
            strSQL &= "    WHERE venCobrador.PlanSoId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venDevVenta(PlanId)
         If TableFind(oDataTable, "venDevVenta") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venDevVenta "
            strSQL &= "    WHERE venDevVenta.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venPago(PlanId)
         If TableFind(oDataTable, "venPago") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venPago "
            strSQL &= "    WHERE venPago.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venTipoTarjeta(PlanId)
         If TableFind(oDataTable, "venTipoTarjeta") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venTipoTarjeta "
            strSQL &= "    WHERE venTipoTarjeta.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venVendedor(PlanId)
         If TableFind(oDataTable, "venVendedor") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venVendedor "
            strSQL &= "    WHERE venVendedor.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venVenta(PlanId)
         If TableFind(oDataTable, "venVenta") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venVenta "
            strSQL &= "    WHERE venVenta.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venVentaDet(PlanIdCos)
         ''venVentaDet(PlanIdIng)
         If TableFind(oDataTable, "venVentaDet") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdCos "
            strSQL &= "    FROM  venVentaDet "
            strSQL &= "    WHERE venVentaDet.PlanIdCos = " & NumberToField(mlngPlanId) & ")"
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanIdIng "
            strSQL &= "    FROM  venVentaDet "
            strSQL &= "    WHERE venVentaDet.PlanIdIng = " & NumberToField(mlngPlanId) & ")"
         End If

         ''venVentaDifAju(PlanId)
         If TableFind(oDataTable, "venVentaDifAju") Then
            strSQL &= " OR tblPlan.PlanId IN "
            strSQL &= "   (SELECT DISTINCT PlanId "
            strSQL &= "    FROM  venVentaDifAju "
            strSQL &= "    WHERE venVentaDifAju.PlanId = " & NumberToField(mlngPlanId) & ")"
         End If

         strSQL &= " )"

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
End Class
