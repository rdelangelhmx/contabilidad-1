Imports System.Data
Imports System.Data.OleDb

Public Class clsCompCheque
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsCompChequeVM
   Public VMNew As clsCompChequeVM

   Private mlngCompChequeId As Long
   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngGestionId As Long
   Private mlngCompDetId As Long
   Private mstrFecha As String
   Private mlngPlanId As Long
   Private mlngCiudadId As Long
   Private mlngChequeId As Long
   Private mlngChequeDetId As Long
   Private mlngChequeNro As Long
   Private mstrChequeDes As String
   Private mlngMonedaId As Long
   Private mdecTipoCambio As Decimal
   Private mdecChequeMonto As Decimal
   Private mstrConcepto As String
   Private mstrFechaCob As String
   Private mstrChequeCobDes As String
   Private mlngEstadoIdCob As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CompChequeId() As Long
      Get
         Return mlngCompChequeId
      End Get

      Set(ByVal Value As Long)
         mlngCompChequeId = Value
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

   Property CompDetId() As Long
      Get
         Return mlngCompDetId
      End Get

      Set(ByVal Value As Long)
         mlngCompDetId = Value
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

   Property CiudadId() As Long
      Get
         Return mlngCiudadId
      End Get

      Set(ByVal Value As Long)
         mlngCiudadId = Value
      End Set
   End Property

   Property ChequeId() As Long
      Get
         Return mlngChequeId
      End Get

      Set(ByVal Value As Long)
         mlngChequeId = Value
      End Set
   End Property

   Property ChequeDetId() As Long
      Get
         Return mlngChequeDetId
      End Get

      Set(ByVal Value As Long)
         mlngChequeDetId = Value
      End Set
   End Property

   Property ChequeNro() As Long
      Get
         Return mlngChequeNro
      End Get

      Set(ByVal Value As Long)
         mlngChequeNro = Value
      End Set
   End Property

   Property ChequeDes() As String
      Get
         Return mstrChequeDes
      End Get

      Set(ByVal Value As String)
         mstrChequeDes = Value
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

   Property TipoCambio() As Decimal
      Get
         Return mdecTipoCambio
      End Get

      Set(ByVal Value As Decimal)
         mdecTipoCambio = Value
      End Set
   End Property

   Property ChequeMonto() As Decimal
      Get
         Return mdecChequeMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecChequeMonto = Value
      End Set
   End Property

   Property Concepto() As String
      Get
         Return mstrConcepto
      End Get

      Set(ByVal Value As String)
         mstrConcepto = Value
      End Set
   End Property

   Property FechaCob() As String
      Get
         Return mstrFechaCob
      End Get

      Set(ByVal Value As String)
         mstrFechaCob = Value
      End Set
   End Property

   Property ChequeCobDes() As String
      Get
         Return mstrChequeCobDes
      End Get

      Set(ByVal Value As String)
         mstrChequeCobDes = Value
      End Set
   End Property

   Property EstadoIdCob() As Long
      Get
         Return mlngEstadoIdCob
      End Get

      Set(ByVal Value As Long)
         mlngEstadoIdCob = Value
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

   Property RowPosition() As Integer
      Get
         Return mintRow
      End Get

      Set(ByVal Value As Integer)
         mintRow = Value
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
      Report = 3
      GridAll = 4
      LibroCheque = 5
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      CompId = 4
      CompDetId = 5
      Report = 6
      ChequeDup = 7
      GridAll = 8
      SinMovimiento = 9
      LibroCheque = 10
      LibroChequeFecha = 11
      LibroChequeFechaCob = 12
      ChequeId = 13
      ChequeDetId = 14
      CompDet = 15
      Grid1 = 16
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompChequeId = 1
      Grid = 3
      GridAll = 4
      LibroCheque = 5
      LibroChequeFecha = 6
      LibroChequeNro = 7
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      EstadoIdByCompId = 1
      ChequeCob = 2
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
      mstrTableName = "tblCompCheque"
      mstrClassName = "clsCompCheque"

      moConnection = New OleDbConnection
      VMNew = New clsCompChequeVM
      VMOld = New clsCompChequeVM

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
      mlngCompChequeId = 0
      mlngEmpresaId = 0
      mlngCompId = 0
      mlngGestionId = 0
      mlngCompDetId = 0
      mstrFecha = ""
      mlngPlanId = 0
      mlngCiudadId = 0
      mlngChequeId = 0
      mlngChequeDetId = 0
      mstrFecha = ""
      mlngChequeNro = 0
      mstrChequeDes = ""
      mlngMonedaId = 0
      mdecTipoCambio = 0
      mdecChequeMonto = 0
      mstrConcepto = ""
      mstrFechaCob = ""
      mstrChequeCobDes = ""
      mlngEstadoIdCob = 0
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
            strSQL &= "    tblCompCheque.CompChequeId,  "
            strSQL &= "    tblCompCheque.EmpresaId,  "
            strSQL &= "    tblCompCheque.CompId,  "
            strSQL &= "    tblCompCheque.GestionId,  "
            strSQL &= "    tblCompCheque.CompDetId,  "
            strSQL &= "    tblCompCheque.Fecha,  "
            strSQL &= "    tblCompCheque.PlanId,  "
            strSQL &= "    tblCompCheque.CiudadId,  "
            strSQL &= "    tblCompCheque.ChequeId,  "
            strSQL &= "    tblCompCheque.ChequeDetId,  "
            strSQL &= "    tblCompCheque.ChequeNro,  "
            strSQL &= "    tblCompCheque.ChequeDes,  "
            strSQL &= "    tblCompCheque.MonedaId,  "
            strSQL &= "    tblCompCheque.TipoCambio,  "
            strSQL &= "    tblCompCheque.ChequeMonto,  "
            strSQL &= "    tblCompCheque.Concepto,  "
            strSQL &= "    tblCompCheque.FechaCob,  "
            strSQL &= "    tblCompCheque.ChequeCobDes,  "
            strSQL &= "    tblCompCheque.EstadoIdCob,  "
            strSQL &= "    tblCompCheque.EstadoId,  "
            strSQL &= "    tblCompCheque.sLastUpdate_id,  "
            strSQL &= "    tblCompCheque.dtLastUpdate_dt,  "
            strSQL &= "    tblCompCheque.iConcurrency_id  "
            strSQL &= " FROM tblCompCheque "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCompCheque.CompChequeId  "
            strSQL &= " FROM tblCompCheque "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCompCheque.CompChequeId,  "
            strSQL &= "    tblCompCheque.EmpresaId,  "
            strSQL &= "    tblCompCheque.CompId,  "
            strSQL &= "    tblCompCheque.GestionId,  "
            strSQL &= "    tblCompCheque.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCompCheque.ChequeId,  "
            strSQL &= "    tblCompCheque.ChequeDetId,  "
            strSQL &= "    tblBanco.BancoDes,  "
            strSQL &= "    tblCheque.BancoCta,  "
            strSQL &= "    tblCompCheque.Fecha,  "
            strSQL &= "    tblCompCheque.ChequeNro,  "
            strSQL &= "    tblCompCheque.ChequeDes,  "
            strSQL &= "    tblCompCheque.ChequeMonto,  "
            strSQL &= "    tblEstadoCob.EstadoId As EstadoIdCob,  "
            strSQL &= "    tblEstadoCob.EstadoDes As EstadoDesCob,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblCompCheque, tblPlan, tblCheque, tblBanco, tblEstado, tblEstado tblEstadoCob "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    tblCompCheque.CompChequeId,  "
            strSQL &= "    tblCompCheque.EmpresaId,  "
            strSQL &= "    tblCompCheque.ChequeId,  "
            strSQL &= "    tblCompCheque.ChequeDetId,  "
            strSQL &= "    tblBanco.BancoDes,  "
            strSQL &= "    tblCheque.BancoCta,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    tblCompCheque.Fecha,  "
            strSQL &= "    tblCompCheque.ChequeNro,  "
            strSQL &= "    tblCompCheque.ChequeDes,  "
            strSQL &= "    tblCompCheque.ChequeMonto,  "
            strSQL &= "    tblCompCheque.Concepto  "
            strSQL &= " FROM tblCompCheque, tblCheque, tblBanco, tblCiudad "

         Case SelectFilters.GridAll
            strSQL = " SELECT  "
            strSQL &= "    tblCompCheque.CompChequeId,  "
            strSQL &= "    tblCompCheque.EmpresaId,  "
            strSQL &= "    tblCompCheque.GestionId,  "
            strSQL &= "    tblCompCheque.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblBanco.BancoDes,  "
            strSQL &= "    tblCheque.BancoCta,  "
            strSQL &= "    tblCompCheque.ChequeId,  "
            strSQL &= "    tblCompCheque.Fecha,  "
            strSQL &= "    tblCompCheque.ChequeDetId,  "
            strSQL &= "    tblChequeDet.ChequeDetNro,  "
            strSQL &= "    tblCompCheque.ChequeNro,  "
            strSQL &= "    tblEstadoCob.EstadoId As EstadoIdCob,  "
            strSQL &= "    tblEstadoCob.EstadoDes As EstadoDesCob,  "
            strSQL &= "    tblCompCheque.ChequeDes,  "
            strSQL &= "    tblCompCheque.ChequeMonto,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblCompCheque, tblPlan, tblCheque, tblChequeDet, tblBanco, tblTipoComp, tblComp, tblEstado, tblEstado tblEstadoCob "

         Case SelectFilters.LibroCheque
            strSQL = " SELECT  "
            strSQL &= "    tblCompCheque.CompChequeId,  "
            strSQL &= "    tblCompCheque.EmpresaId,  "
            strSQL &= "    tblCompCheque.GestionId,  "
            strSQL &= "    tblCompCheque.ChequeId,  "
            strSQL &= "    tblCompCheque.ChequeDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCheque.BancoCta,  "
            strSQL &= "    tblChequeDet.ChequeDetNro,  "
            strSQL &= "    tblCompCheque.Fecha,  "
            strSQL &= "    tblCompCheque.ChequeNro,  "
            strSQL &= "    tblCompCheque.ChequeDes,  "
            strSQL &= "    tblCompCheque.MonedaId,  "
            strSQL &= "    tblCompCheque.TipoCambio,  "
            strSQL &= "    tblCompCheque.ChequeMonto,  "
            strSQL &= "    tblCompCheque.FechaCob,  "
            strSQL &= "    tblCompCheque.ChequeCobDes,  "
            strSQL &= "    tblEstado.EstadoId As EstadoIdCob,  "
            strSQL &= "    tblEstado.EstadoDes As EstadoDesCob,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblCompDet.CompDetDes  "
            strSQL &= " FROM tblCompCheque, tblCheque, tblChequeDet, tblPlan, tblEstado, tblTipoComp, tblComp, tblCompDet "

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
            strSQL = " WHERE  tblCompCheque.CompChequeId = " & NumberToField(mlngCompChequeId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCompCheque.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCheque.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompCheque.ChequeId = tblCheque.ChequeId "
            strSQL &= " AND  tblCheque.BancoId = tblBanco.BancoId "
            strSQL &= " AND  tblCompCheque.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblCompCheque.EstadoIdCob = tblEstadoCob.EstadoId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.CompDetId
            strSQL = " WHERE  tblCompCheque.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.Report
            strSQL = " WHERE  tblCompCheque.CompChequeId = " & NumberToField(mlngCompChequeId)
            strSQL &= " AND  tblCompCheque.ChequeId = tblCheque.ChequeId "
            strSQL &= " AND  tblCheque.BancoId = tblBanco.BancoId "
            strSQL &= " AND  tblCompCheque.CiudadId = tblCiudad.CiudadId "

         Case WhereFilters.ChequeDup
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            ''strSQL &= " AND  tblCompCheque.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND  tblCompCheque.ChequeDetId = " & NumberToField(mlngChequeDetId)
            strSQL &= " AND  tblCompCheque.ChequeNro = " & NumberToField(mlngChequeNro)
            strSQL &= " AND  (tblCompCheque.EstadoId = 10 "
            strSQL &= " OR  tblCompCheque.EstadoId = 11 "
            strSQL &= " OR  tblCompCheque.EstadoId = 13) "
            If mlngCompChequeId <> 0 Then
               strSQL &= " AND  tblCompCheque.CompChequeId <> " & NumberToField(mlngCompChequeId)
            End If

         Case WhereFilters.GridAll
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCheque.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCheque.BancoId = tblBanco.BancoId "
            strSQL &= " AND  tblCompCheque.ChequeId = tblCheque.ChequeId "
            strSQL &= " AND  tblCompCheque.ChequeDetId = tblChequeDet.ChequeDetId "
            strSQL &= " AND  tblCompCheque.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompCheque.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblCompCheque.EstadoIdCob = tblEstadoCob.EstadoId "
            strSQL &= " AND  (tblCompCheque.EstadoId = 10 "
            strSQL &= " OR  tblCompCheque.EstadoId = 11 "
            strSQL &= " OR  tblCompCheque.EstadoId = 12 "
            strSQL &= " OR  tblCompCheque.EstadoId = 13) "

            If mlngPlanId <> 0 Then
               strSQL &= " AND  tblCompCheque.PlanId = " & NumberToField(mlngPlanId)
            End If

            If mlngChequeId <> 0 Then
               strSQL &= " AND  tblCompCheque.ChequeId = " & NumberToField(mlngChequeId)
            End If

         Case WhereFilters.SinMovimiento
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCheque.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND  (tblCompCheque.EstadoId = 10 "
            strSQL &= " OR  tblCompCheque.EstadoId = 11 "
            strSQL &= " OR  tblCompCheque.EstadoId = 13) "

         Case WhereFilters.LibroCheque
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCheque.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND  tblCompCheque.ChequeId = tblCheque.ChequeId "
            strSQL &= " AND  tblCompCheque.ChequeDetId = tblChequeDet.ChequeDetId "
            strSQL &= " AND  tblCompCheque.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompCheque.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompCheque.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompCheque.EstadoIdCob = tblEstado.EstadoId "
            strSQL &= " AND  tblCompCheque.EstadoId <> 12 "
            If mlngEstadoIdCob <> 0 Then
               strSQL &= " AND  tblCompCheque.EstadoIdCob = " & NumberToField(mlngEstadoIdCob)
            End If
            If mlngCiudadId <> 0 Then
               strSQL &= " AND  tblCompCheque.CiudadId = " & NumberToField(mlngCiudadId)
            End If

         Case WhereFilters.LibroChequeFecha
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCheque.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND  tblCompCheque.ChequeId = tblCheque.ChequeId "
            strSQL &= " AND  tblCompCheque.ChequeDetId = tblChequeDet.ChequeDetId "
            strSQL &= " AND  tblCompCheque.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompCheque.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompCheque.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompCheque.EstadoIdCob = tblEstado.EstadoId "
            strSQL &= " AND  tblCompCheque.EstadoId <> 12 "
            strSQL &= " AND  tblCompCheque.Fecha >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompCheque.Fecha <= " & DateToField(mstrLastUpdateDate)
            If mlngEstadoIdCob <> 0 Then
               strSQL &= " AND  tblCompCheque.EstadoIdCob = " & NumberToField(mlngEstadoIdCob)
            End If
            If mlngCiudadId <> 0 Then
               strSQL &= " AND  tblCompCheque.CiudadId = " & NumberToField(mlngCiudadId)
            End If

         Case WhereFilters.LibroChequeFechaCob
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompCheque.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND  tblCompCheque.ChequeId = tblCheque.ChequeId "
            strSQL &= " AND  tblCompCheque.ChequeDetId = tblChequeDet.ChequeDetId "
            strSQL &= " AND  tblCompCheque.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompCheque.CompId = tblComp.CompId "
            strSQL &= " AND  tblCompCheque.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblComp.CompId = tblCompDet.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompCheque.EstadoIdCob = tblEstado.EstadoId "
            strSQL &= " AND  tblCompCheque.EstadoId <> 12 "
            strSQL &= " AND  tblCompCheque.FechaCob >= " & DateToField(mstrFecha)
            strSQL &= " AND  tblCompCheque.FechaCob <= " & DateToField(mstrLastUpdateDate)
            If mlngEstadoIdCob <> 0 Then
               strSQL &= " AND  tblCompCheque.EstadoIdCob = " & NumberToField(mlngEstadoIdCob)
            End If
            If mlngCiudadId <> 0 Then
               strSQL &= " AND  tblCompCheque.CiudadId = " & NumberToField(mlngCiudadId)
            End If

         Case WhereFilters.ChequeId
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.ChequeId = " & NumberToField(mlngChequeId)

         Case WhereFilters.ChequeDetId
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND  tblCompCheque.ChequeDetId = " & NumberToField(mlngChequeDetId)

         Case WhereFilters.CompDet
            strSQL = " WHERE  tblCompCheque.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompCheque.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.Grid1
            strSQL = " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCheque.PlanId = " & NumberToField(mlngPlanId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompChequeId
            strSQL = " ORDER BY tblCompCheque.CompChequeId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblPlan.PlanCta "

         Case OrderByFilters.GridAll
            strSQL = " ORDER BY tblPlan.PlanCta, tblCompCheque.CompChequeId "

         Case OrderByFilters.LibroCheque
            strSQL = " ORDER BY tblCompCheque.Fecha "

         Case OrderByFilters.LibroChequeFecha
            strSQL = " ORDER BY tblCompCheque.Fecha "

         Case OrderByFilters.LibroChequeNro
            strSQL = " ORDER BY tblCompCheque.ChequeNro "

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
            strSQL = "INSERT INTO tblCompCheque ("
            strSQL &= "CompChequeId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CompId, "
            strSQL &= "GestionId, "
            strSQL &= "CompDetId, "
            strSQL &= "Fecha, "
            strSQL &= "PlanId, "
            strSQL &= "CiudadId, "
            strSQL &= "ChequeId, "
            strSQL &= "ChequeDetId, "
            strSQL &= "ChequeNro, "
            strSQL &= "ChequeDes, "
            strSQL &= "MonedaId, "
            strSQL &= "TipoCambio, "
            strSQL &= "ChequeMonto, "
            strSQL &= "Concepto, "
            strSQL &= "FechaCob, "
            strSQL &= "ChequeCobDes, "
            strSQL &= "EstadoIdCob, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompChequeId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngCompDetId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngCiudadId) & ", "
            strSQL &= NumberToField(mlngChequeId) & ", "
            strSQL &= NumberToField(mlngChequeDetId) & ", "
            strSQL &= NumberToField(mlngChequeNro) & ", "
            strSQL &= StringToField(mstrChequeDes) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecTipoCambio) & ", "
            strSQL &= DecimalToField(mdecChequeMonto) & ", "
            strSQL &= StringToField(mstrConcepto) & ", "
            strSQL &= DateToField(mstrFechaCob) & ", "
            strSQL &= StringToField(mstrChequeCobDes) & ", "
            strSQL &= NumberToField(mlngEstadoIdCob) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCompCheque SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "CompDetId = " & NumberToField(mlngCompDetId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "CiudadId = " & NumberToField(mlngCiudadId) & ", "
            strSQL &= "ChequeId = " & NumberToField(mlngChequeId) & ", "
            strSQL &= "ChequeDetId = " & NumberToField(mlngChequeDetId) & ", "
            strSQL &= "ChequeNro = " & NumberToField(mlngChequeNro) & ", "
            strSQL &= "ChequeDes = " & StringToField(mstrChequeDes) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "TipoCambio = " & DecimalToField(mdecTipoCambio) & ", "
            strSQL &= "ChequeMonto = " & DecimalToField(mdecChequeMonto) & ", "
            strSQL &= "Concepto = " & StringToField(mstrConcepto) & ", "
            strSQL &= "FechaCob = " & DateToField(mstrFechaCob) & ", "
            strSQL &= "ChequeCobDes = " & StringToField(mstrChequeCobDes) & ", "
            strSQL &= "EstadoIdCob = " & NumberToField(mlngEstadoIdCob) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompChequeId = " & NumberToField(mlngCompChequeId) & " "

         Case UpdateFilters.EstadoIdByCompId
            strSQL = "UPDATE tblCompCheque SET "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompId = " & NumberToField(mlngCompId) & " "

         Case UpdateFilters.ChequeCob
            strSQL = "UPDATE tblCompCheque SET "
            strSQL &= "FechaCob = " & DateToField(mstrFechaCob) & ", "
            strSQL &= "ChequeCobDes = " & StringToField(mstrChequeCobDes) & ", "
            strSQL &= "EstadoIdCob = " & NumberToField(mlngEstadoIdCob) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompChequeId = " & NumberToField(mlngCompChequeId) & " "

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
               mlngCompChequeId = ToLong(oDataRow("CompChequeId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngCompDetId = ToLong(oDataRow("CompDetId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngCiudadId = ToLong(oDataRow("CiudadId"))
               mlngChequeId = ToLong(oDataRow("ChequeId"))
               mlngChequeDetId = ToLong(oDataRow("ChequeDetId"))
               mlngChequeNro = ToLong(oDataRow("ChequeNro"))
               mstrChequeDes = ToStr(oDataRow("ChequeDes"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecTipoCambio = ToDecimal(oDataRow("TipoCambio"))
               mdecChequeMonto = ToDecimal(oDataRow("ChequeMonto"))
               mstrConcepto = ToStr(oDataRow("Concepto"))
               mstrFechaCob = ToDateDMY(oDataRow("FechaCob"))
               mstrChequeCobDes = ToStr(oDataRow("ChequeCobDes"))
               mlngEstadoIdCob = ToLong(oDataRow("EstadoIdCob"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompChequeId = ToLong(oDataRow("CompChequeId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompChequeId = TableIDGet(mstrTableName, "CompChequeId", moConnection)

         If mlngCompChequeId = -1 Then
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

      'If mlngCompId = 0 Then
      '   strMsg &= "Comprobante ID Inválido" & vbCrLf
      'End If

      'If mlngGestionId = 0 Then
      '   strMsg &= "Gestión Inválida" & vbCrLf
      'End If

      'If mlngCompDetId = 0 Then
      '   strMsg &= "Tipo de Comprobante Inválido" & vbCrLf
      'End If

      'If mlngPlanId = 0 Then
      '   strMsg &= "Seleccione la Cuenta" & vbCrLf
      'End If

      'If mstrChequeDes.Length() = 0 Then
      '   strMsg &= "Ingrese responsable del Cheque" & vbCrLf
      'End If

      If mlngMonedaId = 0 Then
         strMsg &= "Moneda Inválida" & vbCrLf
      End If

      If mdecTipoCambio = 0 Then
         strMsg &= "Tipo de Cambio Inválido" & vbCrLf
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
         strSQL &= " FROM tblCompCheque "

         If Not boolReplace Then
            strSQL &= " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCheque.CompId <> 0 "
            strSQL &= " AND  tblCompCheque.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompCheque.CompDetId <> 0 "
         Else
            strSQL &= " WHERE  tblCompCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompCheque.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompCheque.CompId <> 0 "
            strSQL &= " AND  tblCompCheque.CompDetId = " & NumberToField(mlngCompDetId)
            strSQL &= " AND  tblCompCheque.CompDetId <> 0 "
            strSQL &= " AND  tblCompCheque.CompChequeId <> " & NumberToField(mlngCompChequeId)
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
            UpdateOnly = True
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngCompChequeId)
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