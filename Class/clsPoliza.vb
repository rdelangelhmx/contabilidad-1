Imports System.Data
Imports System.Data.OleDb

Public Class clsPoliza
   Implements IDisposable

   Public VMOld As clsPolizaVM
   Public VMNew As clsPolizaVM

   Private mlngPolizaId As Long
   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngGestionId As Long
   Private mlngMesId As Long
   Private mstrPolizaFecha As String
   Private mstrPolizaNro As String
   Private mlngAduanaId As Long
   Private mstrAduanaNIT As String
   Private mstrAduanaDes As String
   Private mdecPolizaMonto As Decimal
   Private mdecIVA As Decimal
   Private mdecIceIehd As Decimal
   Private mlngPlanId As Long
   Private mlngPlanAddId As Long
   Private mlngCentroCostoId As Long
   Private mlngCentroCostoDetId As Long
   Private mlngSucursalId As Long
   Private mbytBancarizar As Byte
   Private mdecBancarizaMonto As Decimal
   Private mlngTipoFacCompraId As Long
   Private mlngEstadoId As Long
   Private mstrPolizaObs As String
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   Private moConnection As OleDbConnection
   Private moDataAdapter As OleDbDataAdapter
   Private moDataSet As DataSet
   Private mintRow As Integer
   Private mintRowsCount As Integer

   Private mstrConnectionString As String
   Private mstrTableName As String
   Private mstrClassName As String
   Private mstrSQL As String

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property PolizaId() As Long
      Get
         Return mlngPolizaId
      End Get

      Set(ByVal Value As Long)
         mlngPolizaId = Value
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

   Property MesId() As Long
      Get
         Return mlngMesId
      End Get

      Set(ByVal Value As Long)
         mlngMesId = Value
      End Set
   End Property

   Property PolizaFecha() As String
      Get
         Return mstrPolizaFecha
      End Get

      Set(ByVal Value As String)
         mstrPolizaFecha = Value
      End Set
   End Property

   Property PolizaNro() As String
      Get
         Return mstrPolizaNro
      End Get

      Set(ByVal Value As String)
         mstrPolizaNro = Value
      End Set
   End Property

   Property AduanaId() As Long
      Get
         Return mlngAduanaId
      End Get

      Set(ByVal Value As Long)
         mlngAduanaId = Value
      End Set
   End Property

   Property AduanaNIT() As String
      Get
         Return mstrAduanaNIT
      End Get

      Set(ByVal Value As String)
         mstrAduanaNIT = Value
      End Set
   End Property

   Property AduanaDes() As String
      Get
         Return mstrAduanaDes
      End Get

      Set(ByVal Value As String)
         mstrAduanaDes = Value
      End Set
   End Property

   Property PolizaMonto() As Decimal
      Get
         Return mdecPolizaMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecPolizaMonto = Value
      End Set
   End Property

   Property IVA() As Decimal
      Get
         Return mdecIVA
      End Get

      Set(ByVal Value As Decimal)
         mdecIVA = Value
      End Set
   End Property

   Property IceIehd() As Decimal
      Get
         Return mdecIceIehd
      End Get

      Set(ByVal Value As Decimal)
         mdecIceIehd = Value
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

   Property PlanAddId() As Long
      Get
         Return mlngPlanAddId
      End Get

      Set(ByVal Value As Long)
         mlngPlanAddId = Value
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

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
      End Set
   End Property

   Property Bancarizar() As Byte
      Get
         Return mbytBancarizar
      End Get

      Set(ByVal Value As Byte)
         mbytBancarizar = Value
      End Set
   End Property

   Property BancarizaMonto() As Decimal
      Get
         Return mdecBancarizaMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecBancarizaMonto = Value
      End Set
   End Property

   Property TipoFacCompraId() As Long
      Get
         Return mlngTipoFacCompraId
      End Get

      Set(ByVal Value As Long)
         mlngTipoFacCompraId = Value
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

   Property PolizaObs() As String
      Get
         Return mstrPolizaObs
      End Get
      Set(ByVal value As String)
         mstrPolizaObs = value
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

   Property ConnectionString() As String
      Get
         Return mstrConnectionString
      End Get

      Set(ByVal Value As String)
         mstrConnectionString = Value
      End Set
   End Property

   Property DataSet() As DataSet
      Get
         Return moDataSet
      End Get

      Set(ByVal Value As DataSet)
         moDataSet = Value
      End Set
   End Property

   ReadOnly Property TableName() As String
      Get
         Return mstrTableName
      End Get
   End Property

   ReadOnly Property ClassName() As String
      Get
         Return mstrClassName
      End Get
   End Property

   ReadOnly Property SQL() As String
      Get
         Return mstrSQL
      End Get
   End Property

   '******************************************************
   '* The following enumerations will change for each
   '* data access class
   '******************************************************
   Public Enum SelectFilters As Byte
      All = 0
      ListBox = 1
      Grid = 2
      LibroIVA = 3
      GridCompra = 4
      ListBoxBancariza = 5
      LibroIVANSF = 6
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      CompId = 4
      Poliza = 5
      LibroIVA = 6
      GridCompra = 7
      ListBoxBancarizaAdd = 8
      ListBoxBancarizaEdit = 9
      LibroIVANSF = 10
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PolizaId = 1
      Grid = 3
      LibroIVA = 4
      ListBoxBancariza = 5
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      BancarizaMonto = 1
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
      mstrTableName = "tblPoliza"
      mstrClassName = "clsPoliza"

      moConnection = New OleDbConnection
      VMNew = New clsPolizaVM

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
      mlngPolizaId = 0
      mlngEmpresaId = 0
      mlngCompId = 0
      mlngGestionId = 0
      mlngMesId = 0
      mstrPolizaFecha = ""
      mstrPolizaNro = ""
      mlngAduanaId = 0
      mstrAduanaNIT = ""
      mstrAduanaDes = ""
      mdecPolizaMonto = 0
      mdecIVA = 0
      mdecIceIehd = 0
      mlngPlanId = 0
      mlngPlanAddId = 0
      mlngCentroCostoId = 0
      mlngCentroCostoDetId = 0
      mlngSucursalId = 0
      mbytBancarizar = 0
      mdecBancarizaMonto = 0
      mlngTipoFacCompraId = 0
      mlngEstadoId = 0
      mstrPolizaObs = ""

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblPoliza.PolizaId,  "
            strSQL &= "    tblPoliza.EmpresaId,  "
            strSQL &= "    tblPoliza.CompId,  "
            strSQL &= "    tblPoliza.GestionId,  "
            strSQL &= "    tblPoliza.MesId,  "
            strSQL &= "    tblPoliza.PolizaFecha,  "
            strSQL &= "    tblPoliza.PolizaNro,  "
            strSQL &= "    tblPoliza.AduanaId,  "
            strSQL &= "    tblPoliza.AduanaNIT,  "
            strSQL &= "    tblPoliza.AduanaDes,  "
            strSQL &= "    tblPoliza.PolizaMonto,  "
            strSQL &= "    tblPoliza.IVA,  "
            strSQL &= "    tblPoliza.IceIehd,  "
            strSQL &= "    tblPoliza.PlanId,  "
            strSQL &= "    tblPoliza.PlanAddId,  "
            strSQL &= "    tblPoliza.CentroCostoId,  "
            strSQL &= "    tblPoliza.CentroCostoDetId,  "
            strSQL &= "    tblPoliza.SucursalId,  "
            strSQL &= "    tblPoliza.Bancarizar,  "
            strSQL &= "    tblPoliza.BancarizaMonto,  "
            strSQL &= "    tblPoliza.TipoFacCompraId,  "
            strSQL &= "    tblPoliza.EstadoId,  "
            strSQL &= "    tblPoliza.PolizaObs,  "
            strSQL &= "    tblPoliza.sLastUpdate_id,  "
            strSQL &= "    tblPoliza.dtLastUpdate_dt,  "
            strSQL &= "    tblPoliza.iConcurrency_id  "
            strSQL &= " FROM tblPoliza "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblPoliza.PolizaId  "
            strSQL &= " FROM tblPoliza "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblPoliza.PolizaId,  "
            strSQL &= "    tblPoliza.EmpresaId,  "
            strSQL &= "    tblPoliza.CompId,  "
            strSQL &= "    tblPoliza.GestionId,  "
            strSQL &= "    tblPoliza.MesId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblPoliza.PolizaFecha,  "
            strSQL &= "    tblPoliza.PolizaNro,  "
            strSQL &= "    tblPoliza.AduanaId,  "
            strSQL &= "    tblPoliza.AduanaNIT,  "
            strSQL &= "    tblPoliza.AduanaDes,  "
            strSQL &= "    tblPoliza.PolizaMonto,  "
            strSQL &= "    tblPoliza.IVA,  "
            strSQL &= "    tblPoliza.IceIehd,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPoliza, tblSucursal, tblEstado "

         Case SelectFilters.GridCompra
            strSQL = " SELECT  "
            strSQL &= "    tblPoliza.PolizaId,  "
            strSQL &= "    tblPoliza.CompId,  "
            strSQL &= "    tblPoliza.PolizaNro,  "
            strSQL &= "    tblPoliza.PolizaFecha,  "
            strSQL &= "    tblPoliza.AduanaId,  "
            strSQL &= "    tblPoliza.AduanaNIT,  "
            strSQL &= "    tblPoliza.AduanaDes,  "
            strSQL &= "    tblPoliza.PolizaMonto,  "
            strSQL &= "    tblPoliza.IVA,  "
            strSQL &= "    tblPoliza.IceIehd,  "
            strSQL &= "    tblPoliza.PlanId  "
            strSQL &= " FROM tblPoliza "

         Case SelectFilters.LibroIVA
            strSQL = " SELECT  "
            strSQL &= "    tblPoliza.PolizaId,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblPoliza.PolizaFecha,  "
            strSQL &= "    tblPoliza.PolizaNro,  "
            strSQL &= "    tblPoliza.AduanaId,  "
            strSQL &= "    tblPoliza.AduanaNIT,  "
            strSQL &= "    tblPoliza.AduanaDes,  "
            strSQL &= "    tblPoliza.PolizaMonto,  "
            strSQL &= "    tblPoliza.IVA,  "
            strSQL &= "    tblPoliza.IceIehd,  "
            strSQL &= "    tblPoliza.PlanId,  "
            strSQL &= "    tblPoliza.TipoFacCompraId,  "
            strSQL &= "    tblPoliza.EstadoId  "
            strSQL &= " FROM tblPoliza, tblSucursal, tblTipoComp, tblComp  "

         Case SelectFilters.ListBoxBancariza
            strSQL = " SELECT  "
            strSQL &= "    tblPoliza.PolizaId,  "
            strSQL &= "    tblPoliza.PolizaNro,  "
            strSQL &= "    tblPoliza.PolizaNro,  "
            strSQL &= "    tblPoliza.AduanaNIT,  "
            strSQL &= "    tblPoliza.AduanaDes  "
            strSQL &= " FROM tblPoliza "

         Case SelectFilters.LibroIVANSF
            strSQL = " SELECT  "
            strSQL &= "    tblPoliza.PolizaId,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblPoliza.PolizaFecha,  "
            strSQL &= "    tblPoliza.PolizaNro,  "
            strSQL &= "    tblPoliza.AduanaId,  "
            strSQL &= "    tblPoliza.AduanaNIT,  "
            strSQL &= "    tblPoliza.AduanaDes,  "
            strSQL &= "    tblPoliza.PolizaMonto,  "
            strSQL &= "    tblPoliza.IVA,  "
            strSQL &= "    tblPoliza.IceIehd,  "
            strSQL &= "    tblPoliza.PlanId,  "
            strSQL &= "    tblPoliza.EstadoId  "
            strSQL &= " FROM tblPoliza, tblSucursal, tblTipoComp, tblComp  "

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
            strSQL = " WHERE  tblPoliza.PolizaId = " & NumberToField(mlngPolizaId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblPoliza.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPoliza.GestionId = " & NumberToField(mlngGestionId)
            'strSQL &= " AND  tblPoliza.MesId = " & NumberToField(mlngMesId)
            strSQL &= " AND  tblPoliza.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  tblPoliza.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblPoliza.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPoliza.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.Poliza
            strSQL = " WHERE  tblPoliza.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPoliza.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.LibroIVA
            strSQL = " WHERE  tblPoliza.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblPoliza.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPoliza.MesId = " & NumberToField(mlngMesId)
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  tblPoliza.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            strSQL &= " AND  tblPoliza.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  tblPoliza.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblPoliza.EstadoId = 10 "
            strSQL &= " OR  tblPoliza.EstadoId = 11) "

         Case WhereFilters.GridCompra
            strSQL = " WHERE  tblPoliza.PolizaId = " & NumberToField(mlngPolizaId)
            strSQL &= " AND  tblPoliza.PolizaId > 0 "

         Case WhereFilters.ListBoxBancarizaAdd
            strSQL = " WHERE  tblPoliza.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPoliza.Bancarizar = 1 "
            strSQL &= " AND  tblPoliza.PolizaMonto > ISNULL(tblPoliza.BancarizaMonto, 0) "
            strSQL &= " AND  (tblPoliza.EstadoId = 10 "
            strSQL &= " OR  tblPoliza.EstadoId = 11) "

         Case WhereFilters.ListBoxBancarizaEdit
            strSQL = " WHERE  tblPoliza.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPoliza.Bancarizar = 1 "
            strSQL &= " AND  (tblPoliza.EstadoId = 10 "
            strSQL &= " OR  tblPoliza.EstadoId = 11) "

         Case WhereFilters.LibroIVANSF
            strSQL = " WHERE  tblPoliza.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblPoliza.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPoliza.MesId = " & NumberToField(mlngMesId)
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  tblPoliza.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            strSQL &= " AND  tblPoliza.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  tblPoliza.CompId = tblComp.CompId "
            strSQL &= " AND  tblComp.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblPoliza.EstadoId = 10 "
            strSQL &= " OR  tblPoliza.EstadoId = 11) "
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PolizaId
            strSQL = " ORDER BY tblPoliza.PolizaId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblPoliza.PolizaId desc, tblPoliza.PolizaFecha "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblPoliza.PolizaFecha, tblPoliza.AduanaNIT "

         Case OrderByFilters.LibroIVA
            strSQL = " ORDER BY tblPoliza.PolizaFecha, tblPoliza.AduanaNIT "

         Case OrderByFilters.ListBoxBancariza
            strSQL = " ORDER BY tblPoliza.PolizaNro "

      End Select

      Return strSQL
   End Function

   Private Function RowCountSQL() As String
      Dim strSQL As String

      Select Case mintRowCountFilter
         Case RowCountFilters.All
            strSQL = "SELECT Count(*) As NumRecs FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO tblPoliza ("
            strSQL &= "PolizaId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CompId, "
            strSQL &= "GestionId, "
            strSQL &= "MesId, "
            strSQL &= "PolizaFecha, "
            strSQL &= "PolizaNro, "
            strSQL &= "AduanaId, "
            strSQL &= "AduanaNIT, "
            strSQL &= "AduanaDes, "
            strSQL &= "PolizaMonto, "
            strSQL &= "IVA, "
            strSQL &= "IceIehd, "
            strSQL &= "PlanId, "
            strSQL &= "PlanAddId, "  'Lucely 09-11
            strSQL &= "CentroCostoId, "
            strSQL &= "CentroCostoDetId, "
            strSQL &= "SucursalId, "
            strSQL &= "Bancarizar, "
            strSQL &= "BancarizaMonto, "
            strSQL &= "TipoFacCompraId, "
            strSQL &= "EstadoId, "
            strSQL &= "PolizaObs, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPolizaId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngMesId) & ", "
            strSQL &= DateToField(mstrPolizaFecha) & ", "
            strSQL &= StringToField(mstrPolizaNro) & ", "
            strSQL &= NumberToField(mlngAduanaId) & ", "
            strSQL &= StringToField(mstrAduanaNIT) & ", "
            strSQL &= StringToField(mstrAduanaDes) & ", "
            strSQL &= DecimalToField(mdecPolizaMonto) & ", "
            strSQL &= DecimalToField(mdecIVA) & ", "
            strSQL &= DecimalToField(mdecIceIehd) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngPlanAddId) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mbytBancarizar) & ", "
            strSQL &= DecimalToField(mdecBancarizaMonto) & ", "
            strSQL &= NumberToField(mlngTipoFacCompraId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= StringToField(mstrPolizaObs) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblPoliza SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "MesId = " & NumberToField(mlngMesId) & ", "
            strSQL &= "PolizaFecha = " & DateToField(mstrPolizaFecha) & ", "
            strSQL &= "PolizaNro = " & StringToField(mstrPolizaNro) & ", "
            strSQL &= "AduanaId = " & NumberToField(mlngAduanaId) & ", "
            strSQL &= "AduanaNIT = " & StringToField(mstrAduanaNIT) & ", "
            strSQL &= "AduanaDes = " & StringToField(mstrAduanaDes) & ", "
            strSQL &= "PolizaMonto = " & DecimalToField(mdecPolizaMonto) & ", "
            strSQL &= "IVA = " & DecimalToField(mdecIVA) & ", "
            strSQL &= "IceIehd = " & DecimalToField(mdecIceIehd) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "PlanAddId = " & NumberToField(mlngPlanAddId) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "Bancarizar = " & NumberToField(mbytBancarizar) & ", "
            strSQL &= "BancarizaMonto = " & DecimalToField(mdecBancarizaMonto) & ", "
            strSQL &= "TipoFacCompraId = " & NumberToField(mlngTipoFacCompraId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= "PolizaObs = " & StringToField(mstrPolizaObs) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PolizaId = " & NumberToField(mlngPolizaId) & " "

         Case UpdateFilters.BancarizaMonto
            strSQL = "UPDATE tblPoliza SET "
            strSQL &= "BancarizaMonto = " & DecimalToField(mdecBancarizaMonto) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PolizaId = " & NumberToField(mlngPolizaId) & " "

      End Select

      Return strSQL
   End Function

   Private Function DeleteSQL() As String
      Dim strSQL As String

      Select Case mintDeleteFilter
         Case DeleteFilters.All
            strSQL = "DELETE FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Sub Retrieve(ByVal oDataRow As DataRow)
      Try
         Call PropertyInit()

         Select Case mintSelectFilter
            Case SelectFilters.All
               mlngPolizaId = ToLong(oDataRow("PolizaId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngMesId = ToLong(oDataRow("MesId"))
               mstrPolizaFecha = ToDateDMY(oDataRow("PolizaFecha"))
               mstrPolizaNro = ToStr(oDataRow("PolizaNro"))
               mlngAduanaId = ToLong(oDataRow("AduanaId"))
               mstrAduanaNIT = ToStr(oDataRow("AduanaNIT"))
               mstrAduanaDes = ToStr(oDataRow("AduanaDes"))
               mdecPolizaMonto = ToDecimal(oDataRow("PolizaMonto"))
               mdecIVA = ToDecimal(oDataRow("IVA"))
               mdecIceIehd = ToDecimal(oDataRow("IceIehd"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngPlanAddId = ToLong(oDataRow("PlanAddId"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngCentroCostoDetId = ToLong(oDataRow("CentroCostoDetId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mbytBancarizar = ToByte(oDataRow("Bancarizar"))
               mdecBancarizaMonto = ToDecimal(oDataRow("BancarizaMonto"))
               mlngTipoFacCompraId = ToLong(oDataRow("TipoFacCompraId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrPolizaObs = ToStr(oDataRow("PolizaObs"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPolizaId = ToLong(oDataRow("PolizaId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPolizaId = TableIDGet(mstrTableName, "PolizaId", moConnection)

         If mlngPolizaId = -1 Then
            Throw New Exception("No se puede generar un identificador unico para esta tabla: " & mstrTableName)
         Else
            GetNewPrimaryKey = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Validate() As Boolean
      Dim strMsg As String = String.Empty

      If mlngEmpresaId = 0 Then
         strMsg &= "Empresa Inválida" & vbCrLf
      End If

      If mlngGestionId = 0 Then
         strMsg &= "Gestión Inválida" & vbCrLf
      End If

      If mlngMesId = 0 Then
         strMsg &= "Periodo Inválida" & vbCrLf
      End If

      If mstrPolizaFecha.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrPolizaFecha)) Then
            strMsg &= "PolizaFecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La PolizaFecha no puede ser nula" & vbCrLf
      End If

      If mstrPolizaNro.Trim() = String.Empty Then
         strMsg &= "Ingrese el Número de la Poliza" & vbCrLf
      End If

      If mstrAduanaDes.Trim() = String.Empty Then
         strMsg &= "Ingrese la Agencia Aduanera" & vbCrLf
      End If

      If mstrAduanaNIT.Trim() = String.Empty Then
         strMsg &= "Ingrese el NIT de la Agencia Aduanera" & vbCrLf
      End If

      If mdecPolizaMonto <= 0 Then
         strMsg &= "Monto de la Poliza Inválido" & vbCrLf
      End If

      If mdecIVA <= 0 Then
         strMsg &= "IVA de la Poliza Inválido" & vbCrLf
      End If

      If mdecIceIehd < 0 Then
         strMsg &= "ICE Inválido" & vbCrLf
      End If

      If strMsg.Trim <> String.Empty Then
         Throw New Exception(strMsg)
         Validate = False
      Else
         Validate = True
      End If
   End Function

   Public Function NoDuplicates(ByVal boolReplace As Boolean) As Boolean
      Dim strSQL As String
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         strSQL = " SELECT  "
         strSQL &= " Count(*) As NumRecs  "
         strSQL &= " FROM tblPoliza "

         If Not boolReplace Then
            strSQL &= " WHERE  tblPoliza.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPoliza.PolizaNro = " & StringToField(mstrPolizaNro)
            strSQL &= " AND  (tblPoliza.EstadoId = 10 "
            strSQL &= " OR  tblPoliza.EstadoId = 11) "
         Else
            strSQL &= " WHERE  tblPoliza.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPoliza.PolizaNro = " & StringToField(mstrPolizaNro)
            strSQL &= " AND  (tblPoliza.EstadoId = 10 "
            strSQL &= " OR  tblPoliza.EstadoId = 11) "
            strSQL &= " AND  tblPoliza.PolizaId <> " & NumberToField(mlngPolizaId)
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

   Public Function Open() As Boolean
      Try
         Open = False

         Call OpenConection()

         moDataSet = New DataSet

         moDataAdapter = New OleDbDataAdapter(SelectSQL, moConnection)

         moDataAdapter.Fill(moDataSet, mstrTableName)

         moDataAdapter.Dispose()

         mintRow = 0
         mintRowsCount = moDataSet.Tables(mstrTableName).Rows.Count()

         Open = True

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Read() As Boolean
      Dim oDataRow As Data.DataRow

      Read = False

      Try
         If mintRowsCount > 0 Then
            If mintRow <= mintRowsCount - 1 Then
               oDataRow = moDataSet.Tables(mstrTableName).Rows(mintRow)

               Call Retrieve(oDataRow)
               Read = True
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Find() As Boolean
      Find = False

      Try
         If Open() Then
            If Read() Then
               Find = True
            End If
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

   Public Sub MoveNext()
      If mintRowsCount > 0 Then
         If mintRow < mintRowsCount Then
            mintRow += 1
         End If
      End If
   End Sub

   Public Sub MovePrevious()
      If mintRowsCount > 0 Then
         If mintRow > 0 Then
            mintRow -= 1
         End If
      End If
   End Sub

   Public Sub MoveFirst()
      If mintRowsCount > 0 Then
         mintRow = 0
      End If
   End Sub

   Public Sub MoveLast()
      If mintRowsCount > 0 Then
         mintRow = mintRowsCount - 1
      End If
   End Sub

   Public Function Insert() As Boolean
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
                     Insert = True
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngPolizaId)
                  End If
               End If
            Else
               Throw New Exception("Poliza Duplicada")
               Return False
            End If
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Update() As Boolean
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
                  Update = True
                  VMNew.ToChangeOpeUpdate(VMOld, clsTipoOpera.MODIFICA)
               End If
            Else
               Throw New Exception("Poliza Duplicada")
               Return False
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
            VMNew.ToChangeOpeUpdate(VMOld, clsTipoOpera.MODIFICA)
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Delete() As Boolean
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

   Public Function RowCount() As Integer
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowCountSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = CInt(oCommand.ExecuteScalar)

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

   Private Sub OpenConection()
      If moConnection.State = ConnectionState.Closed Then
         moConnection = New OleDbConnection(mstrConnectionString)
         moConnection.Open()
      End If
   End Sub

   Public Sub CloseConection()
      If moConnection.State = ConnectionState.Open Then
         moConnection.Close()
      End If
   End Sub

   Overridable Sub Dispose() Implements IDisposable.Dispose
      Call CloseConection()
   End Sub

End Class
