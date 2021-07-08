Imports System.Data
Imports System.Data.OleDb

Public Class clsFacturaAgru
   Implements IDisposable

   Private mlngFacturaAgruId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngMesId As Long
   Private mlngSucursalId As Long
   Private mlngDosificaId As Long
   Private mlngCompId As Long
   Private mlngCompDetId As Long
   Private mlngTipoCompId As Long
   Private mstrFacturaFecha As String
   Private mlngFacturaNroIni As Long
   Private mlngFacturaNroFin As Long
   Private mdecFacturaMonto As Decimal
   Private mstrNroAutorizacion As String
   Private mstrCodControl As String
   Private mdecIVA As Decimal
   Private mdecIceIehd As Decimal
   Private mdecExento As Decimal
   Private mstrFacturaObs As String
   Private mlngEstadoId As Long
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
   Property FacturaAgruId() As Long
      Get
         Return mlngFacturaAgruId
      End Get

      Set(ByVal Value As Long)
         mlngFacturaAgruId = Value
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

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
      End Set
   End Property

   Property DosificaId() As Long
      Get
         Return mlngDosificaId
      End Get

      Set(ByVal Value As Long)
         mlngDosificaId = Value
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

   Property TipoCompId() As Long
      Get
         Return mlngTipoCompId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCompId = Value
      End Set
   End Property

   Property FacturaFecha() As String
      Get
         Return mstrFacturaFecha
      End Get

      Set(ByVal Value As String)
         mstrFacturaFecha = Value
      End Set
   End Property

   Property FacturaNroIni() As Long
      Get
         Return mlngFacturaNroIni
      End Get

      Set(ByVal Value As Long)
         mlngFacturaNroIni = Value
      End Set
   End Property

   Property FacturaNroFin() As Long
      Get
         Return mlngFacturaNroFin
      End Get

      Set(ByVal Value As Long)
         mlngFacturaNroFin = Value
      End Set
   End Property

   Property FacturaMonto() As Decimal
      Get
         Return mdecFacturaMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecFacturaMonto = Value
      End Set
   End Property

   Property NroAutorizacion() As String
      Get
         Return mstrNroAutorizacion
      End Get

      Set(ByVal Value As String)
         mstrNroAutorizacion = Value
      End Set
   End Property

   Property CodControl() As String
      Get
         Return mstrCodControl
      End Get

      Set(ByVal Value As String)
         mstrCodControl = Value
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

   Property Exento() As Decimal
      Get
         Return mdecExento
      End Get

      Set(ByVal Value As Decimal)
         mdecExento = Value
      End Set
   End Property

   Property FacturaObs() As String
      Get
         Return mstrFacturaObs
      End Get

      Set(ByVal Value As String)
         mstrFacturaObs = Value
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
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      CompId = 4
      CompDetId = 5
      FacturaIndi = 6
      FacturaGral = 7
      LibroIVA = 8
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      FacturaAgruId = 1
      Grid = 3
      LibroIVA = 4
      FacturaNro = 5
      Fecha = 6
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
      mstrTableName = "tblFacturaAgru"
      mstrClassName = "clsFacturaAgru"

      moConnection = New OleDbConnection

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
      mlngFacturaAgruId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngMesId = 0
      mlngSucursalId = 0
      mlngDosificaId = 0
      mlngCompId = 0
      mlngCompDetId = 0
      mlngTipoCompId = 0
      mstrFacturaFecha = ""
      mlngFacturaNroIni = 0
      mlngFacturaNroFin = 0
      mdecFacturaMonto = 0
      mstrNroAutorizacion = ""
      mstrCodControl = ""
      mdecIVA = 0
      mdecIceIehd = 0
      mdecExento = 0
      mstrFacturaObs = ""
      mlngEstadoId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblFacturaAgru.FacturaAgruId,  "
            strSQL &= "    tblFacturaAgru.EmpresaId,  "
            strSQL &= "    tblFacturaAgru.GestionId,  "
            strSQL &= "    tblFacturaAgru.MesId,  "
            strSQL &= "    tblFacturaAgru.SucursalId,  "
            strSQL &= "    tblFacturaAgru.DosificaId,  "
            strSQL &= "    tblFacturaAgru.CompId,  "
            strSQL &= "    tblFacturaAgru.CompDetId,  "
            strSQL &= "    tblFacturaAgru.TipoCompId,  "
            strSQL &= "    tblFacturaAgru.FacturaFecha,  "
            strSQL &= "    tblFacturaAgru.FacturaNroIni,  "
            strSQL &= "    tblFacturaAgru.FacturaNroFin,  "
            strSQL &= "    tblFacturaAgru.FacturaMonto,  "
            strSQL &= "    tblFacturaAgru.NroAutorizacion,  "
            strSQL &= "    tblFacturaAgru.CodControl,  "
            strSQL &= "    tblFacturaAgru.IVA,  "
            strSQL &= "    tblFacturaAgru.IceIehd,  "
            strSQL &= "    tblFacturaAgru.Exento,  "
            strSQL &= "    tblFacturaAgru.FacturaObs,  "
            strSQL &= "    tblFacturaAgru.EstadoId,  "
            strSQL &= "    tblFacturaAgru.sLastUpdate_id,  "
            strSQL &= "    tblFacturaAgru.dtLastUpdate_dt,  "
            strSQL &= "    tblFacturaAgru.iConcurrency_id  "
            strSQL &= " FROM tblFacturaAgru "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblFacturaAgru.FacturaAgruId  "
            strSQL &= " FROM tblFacturaAgru "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblFacturaAgru.FacturaAgruId,  "
            strSQL &= "    tblFacturaAgru.EmpresaId,  "
            strSQL &= "    tblFacturaAgru.CompId,  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblFacturaAgru.GestionId,  "
            strSQL &= "    tblFacturaAgru.TipoCompId,  "
            strSQL &= "    tblFacturaAgru.FacturaFecha,  "
            strSQL &= "    tblFacturaAgru.FacturaNroIni,  "
            strSQL &= "    tblFacturaAgru.FacturaNroFin,  "
            strSQL &= "    tblFacturaAgru.NroAutorizacion,  "
            strSQL &= "    tblFacturaAgru.FacturaMonto,  "
            strSQL &= "    tblFacturaAgru.IceIehd,  "
            strSQL &= "    tblFacturaAgru.Exento,  "
            strSQL &= "    (tblFacturaAgru.FacturaMonto - (tblFacturaAgru.Exento + tblFacturaAgru.IceIehd)) As Neto,  "
            strSQL &= "    tblFacturaAgru.IVA,  "
            strSQL &= "    (tblFacturaAgru.FacturaMonto - tblFacturaAgru.IVA) As ImporteIva,  "
            strSQL &= "    tblFacturaAgru.FacturaObs,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblFacturaAgru, tblEstado, tblCompDet, tblPlan "

         Case SelectFilters.LibroIVA
            strSQL = " SELECT  "
            strSQL &= "    tblFacturaAgru.FacturaAgruId,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblComp.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblFacturaAgru.FacturaFecha,  "
            strSQL &= "    tblFacturaAgru.FacturaNroIni,  "
            strSQL &= "    tblFacturaAgru.FacturaNroFin,  "
            strSQL &= "    tblFacturaAgru.NroAutorizacion,  "
            strSQL &= "    tblFacturaAgru.CodControl,  "
            strSQL &= "    tblFacturaAgru.FacturaMonto,  "
            strSQL &= "    tblFacturaAgru.IceIehd,  "
            strSQL &= "    tblFacturaAgru.Exento,  "
            strSQL &= "    (tblFacturaAgru.FacturaMonto - (tblFacturaAgru.Exento + tblFacturaAgru.IceIehd)) As Neto,  "
            strSQL &= "    tblFacturaAgru.IVA,  "
            strSQL &= "    tblFacturaAgru.FacturaObs,  "
            strSQL &= "    tblFacturaAgru.EstadoId  "
            strSQL &= " FROM tblFacturaAgru, tblTipoComp, tblComp, tblSucursal "

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
            strSQL = " WHERE  tblFacturaAgru.FacturaAgruId = " & NumberToField(mlngFacturaAgruId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblFacturaAgru.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFacturaAgru.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblFacturaAgru.CompDetId = tblCompDet.CompDetId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblFacturaAgru.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblFacturaAgru.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFacturaAgru.CompId = " & NumberToField(mlngCompId)

         Case WhereFilters.CompDetId
            strSQL = " WHERE  tblFacturaAgru.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFacturaAgru.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblFacturaAgru.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.FacturaIndi
            strSQL = " WHERE  tblFacturaAgru.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFacturaAgru.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblFacturaAgru.CompDetId <> " & NumberToField(mlngCompDetId)

         Case WhereFilters.FacturaGral
            strSQL = " WHERE  tblFacturaAgru.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblFacturaAgru.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblFacturaAgru.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.LibroIVA
            strSQL = " WHERE  tblFacturaAgru.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblFacturaAgru.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  tblFacturaAgru.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            strSQL &= " AND  tblFacturaAgru.MesId = " & NumberToField(mlngMesId)
            strSQL &= " AND  tblFacturaAgru.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  tblFacturaAgru.CompId = tblComp.CompId "
            strSQL &= " AND  tblFacturaAgru.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  (tblFacturaAgru.EstadoId = 10 "
            strSQL &= " OR  tblFacturaAgru.EstadoId = 11) "
            If mstrLastUpdateDate <> "" Then strSQL &= " AND  tblComp.TipoAsientoId IN (" & mstrLastUpdateDate & ") "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.FacturaAgruId
            strSQL = " ORDER BY tblFacturaAgru.FacturaAgruId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblFacturaAgru.FacturaFecha "

         Case OrderByFilters.FacturaNro
            strSQL = " ORDER BY tblFacturaAgru.DosificaId, tblFacturaAgru.FacturaNroIni "

         Case OrderByFilters.Fecha
            strSQL = " ORDER BY tblFacturaAgru.DosificaId, tblFacturaAgru.FacturaFecha, tblFacturaAgru.FacturaNroIni "

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
            strSQL = "INSERT INTO tblFacturaAgru ("
            strSQL &= "FacturaAgruId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "MesId, "
            strSQL &= "SucursalId, "
            strSQL &= "DosificaId, "
            strSQL &= "CompId, "
            strSQL &= "CompDetId, "
            strSQL &= "TipoCompId, "
            strSQL &= "FacturaFecha, "
            strSQL &= "FacturaNroIni, "
            strSQL &= "FacturaNroFin, "
            strSQL &= "FacturaMonto, "
            strSQL &= "NroAutorizacion, "
            strSQL &= "CodControl, "
            strSQL &= "IVA, "
            strSQL &= "IceIehd, "
            strSQL &= "Exento, "
            strSQL &= "FacturaObs, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngFacturaAgruId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngMesId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngDosificaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngCompDetId) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            strSQL &= DateToField(mstrFacturaFecha) & ", "
            strSQL &= NumberToField(mlngFacturaNroIni) & ", "
            strSQL &= NumberToField(mlngFacturaNroFin) & ", "
            strSQL &= DecimalToField(mdecFacturaMonto) & ", "
            strSQL &= StringToField(mstrNroAutorizacion) & ", "
            strSQL &= StringToField(mstrCodControl) & ", "
            strSQL &= DecimalToField(mdecIVA) & ", "
            strSQL &= DecimalToField(mdecIceIehd) & ", "
            strSQL &= DecimalToField(mdecExento) & ", "
            strSQL &= StringToField(mstrFacturaObs) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblFacturaAgru SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "MesId = " & NumberToField(mlngMesId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "DosificaId = " & NumberToField(mlngDosificaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "CompDetId = " & NumberToField(mlngCompDetId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "FacturaFecha = " & DateToField(mstrFacturaFecha) & ", "
            strSQL &= "FacturaNroIni = " & NumberToField(mlngFacturaNroIni) & ", "
            strSQL &= "FacturaNroFin = " & NumberToField(mlngFacturaNroFin) & ", "
            strSQL &= "FacturaMonto = " & DecimalToField(mdecFacturaMonto) & ", "
            strSQL &= "NroAutorizacion = " & StringToField(mstrNroAutorizacion) & ", "
            strSQL &= "CodControl = " & StringToField(mstrCodControl) & ", "
            strSQL &= "IVA = " & DecimalToField(mdecIVA) & ", "
            strSQL &= "IceIehd = " & DecimalToField(mdecIceIehd) & ", "
            strSQL &= "Exento = " & DecimalToField(mdecExento) & ", "
            strSQL &= "FacturaObs = " & StringToField(mstrFacturaObs) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " FacturaAgruId = " & NumberToField(mlngFacturaAgruId) & " "

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
               mlngFacturaAgruId = ToLong(oDataRow("FacturaAgruId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngMesId = ToLong(oDataRow("MesId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngDosificaId = ToLong(oDataRow("DosificaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngCompDetId = ToLong(oDataRow("CompDetId"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               mstrFacturaFecha = ToDateDMY(oDataRow("FacturaFecha"))
               mlngFacturaNroIni = ToLong(oDataRow("FacturaNroIni"))
               mlngFacturaNroFin = ToLong(oDataRow("FacturaNroFin"))
               mdecFacturaMonto = ToDecimal(oDataRow("FacturaMonto"))
               mstrNroAutorizacion = ToStr(oDataRow("NroAutorizacion"))
               mstrCodControl = ToStr(oDataRow("CodControl"))
               mdecIVA = ToDecimal(oDataRow("IVA"))
               mdecIceIehd = ToDecimal(oDataRow("IceIehd"))
               mdecExento = ToDecimal(oDataRow("Exento"))
               mstrFacturaObs = ToStr(oDataRow("FacturaObs"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngFacturaAgruId = ToLong(oDataRow("FacturaAgruId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngFacturaAgruId = TableIDGet(mstrTableName, "FacturaAgruId", moConnection)

         If mlngFacturaAgruId = -1 Then
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

      If mlngCompId = 0 Then
         strMsg &= "Comprobante ID Inválido" & vbCrLf
      End If

      If mlngTipoCompId = 0 Then
         strMsg &= "Tipo de Comprobante Inválido" & vbCrLf
      End If

      If mstrFacturaFecha.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFacturaFecha)) Then
            strMsg &= "FacturaFecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La FacturaFecha no puede ser nula" & vbCrLf
      End If

      If mstrNroAutorizacion.Trim() = String.Empty Then
         strMsg &= "Número de Autorización Inválido" & vbCrLf
      End If

      If mstrCodControl.Trim() = String.Empty Then
         strMsg &= "Código de Control" & vbCrLf
      End If

      If mlngFacturaNroIni = 0 Then
         strMsg &= "Ingrese el Número de la Factura Inicial" & vbCrLf
      End If

      If mlngFacturaNroFin = 0 Then
         strMsg &= "Ingrese el Número de la Factura Final" & vbCrLf
      End If

      If mstrNroAutorizacion.Trim() = String.Empty Then
         strMsg &= "Número de Autorización Inválido" & vbCrLf
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
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM tblFacturaAgru "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblFacturaAgru.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   'strSQL &= " AND  tblFacturaAgru.FacturaNroIni = " & NumberToField(mlngFacturaNroIni)
         '   strSQL &= " AND  tblFacturaAgru.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
         '   strSQL &= " AND  (tblFacturaAgru.EstadoId = 10 "
         '   strSQL &= " OR  tblFacturaAgru.EstadoId = 11) "
         'Else
         '   strSQL &= " WHERE  tblFacturaAgru.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   'strSQL &= " AND  tblFacturaAgru.FacturaNroIni = " & NumberToField(mlngFacturaNroIni)
         '   strSQL &= " AND  tblFacturaAgru.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
         '   strSQL &= " AND  (tblFacturaAgru.EstadoId = 10 "
         '   strSQL &= " OR  tblFacturaAgru.EstadoId = 11) "
         '   strSQL &= " AND  tblFacturaAgru.FacturaAgruId <> " & NumberToField(mlngFacturaAgruId)
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
                  End If
               End If
            Else
               Throw New Exception("Factura Duplicada")
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
               End If
            Else
               Throw New Exception("Factura Duplicada")
               Return False
            End If
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
