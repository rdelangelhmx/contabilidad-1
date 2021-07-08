Imports System.Data
Imports System.Data.OleDb

Public Class clsCentroCosto
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsCentroCostoVM
   Public VMNew As New clsCentroCostoVM

   Private mlngCentroCostoId As Long
   Private mlngEmpresaId As Long
   Private mstrCentroCostoDes As String
   Private mstrCentroCostoCod As String
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer


   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
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

   Property CentroCostoDes() As String
      Get
         Return mstrCentroCostoDes
      End Get

      Set(ByVal Value As String)
         mstrCentroCostoDes = Value
      End Set
   End Property

   Property CentroCostoCod() As String
      Get
         Return mstrCentroCostoCod
      End Get

      Set(ByVal Value As String)
         mstrCentroCostoCod = Value
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
      CompId = 3
      GridCheck = 4
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      CentroCostoDes = 2
      LIKECentroCostoDes = 3
      Grid = 4
      CompId = 5
      EmpresaId = 6
      CentroCostoCod = 7
      EstadoId = 8
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CentroCostoId = 1
      CentroCostoDes = 2
      Grid = 3
      CompId = 4
      CentroCostoCod = 5
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
      mstrTableName = "tblCentroCosto"
      mstrClassName = "clsCentroCosto"

      moConnection = New OleDbConnection
      VMNew = New clsCentroCostoVM

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
      mlngCentroCostoId = 0
      mlngEmpresaId = 0
      mstrCentroCostoDes = ""
      mstrCentroCostoCod = ""
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
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.EmpresaId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblCentroCosto.CentroCostoCod,  "
            strSQL &= "    tblCentroCosto.EstadoId,  "
            strSQL &= "    tblCentroCosto.sLastUpdate_id,  "
            strSQL &= "    tblCentroCosto.dtLastUpdate_dt,  "
            strSQL &= "    tblCentroCosto.iConcurrency_id  "
            strSQL &= " FROM tblCentroCosto "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes  "
            strSQL &= " FROM tblCentroCosto "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.EmpresaId,  "
            strSQL &= "    tblCentroCosto.CentroCostoCod,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblCentroCosto, tblEstado "

         Case SelectFilters.CompId
            strSQL = " SELECT  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.EmpresaId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCentroCosto.CentroCostoCod,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes  "
            strSQL &= " FROM tblCentroCosto, tblPlan, tblCompDet "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblCentroCosto.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.EmpresaId,  "
            strSQL &= "    tblCentroCosto.CentroCostoCod,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblCentroCosto, tblEstado "

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
            strSQL = " WHERE  tblCentroCosto.CentroCostoId = " & NumberToField(mlngCentroCostoId)

         Case WhereFilters.CentroCostoDes
            strSQL = " WHERE  tblCentroCosto.CentroCostoDes = " & StringToField(mstrCentroCostoDes)

         Case WhereFilters.LIKECentroCostoDes
            strSQL = " WHERE  tblCentroCosto.CentroCostoDes LIKE " & StringToField(mstrCentroCostoDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCentroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCosto.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblCentroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCosto.CentroCostoId = tblCompDet.CentroCostoId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblPlan.SucCCOId = 2 "
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCompDet.CentroCostoId <> 0 "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblCentroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.CentroCostoCod
            strSQL = " WHERE  tblCentroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCosto.CentroCostoCod = " & StringToField(mstrCentroCostoCod)

         Case WhereFilters.EstadoId
            strSQL = " WHERE  tblCentroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngCentroCostoId = 0 Then
               strSQL &= " AND  tblCentroCosto.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (tblCentroCosto.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  tblCentroCosto.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ") "
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CentroCostoId
            strSQL = " ORDER BY tblCentroCosto.CentroCostoId "

         Case OrderByFilters.CentroCostoDes
            strSQL = " ORDER BY tblCentroCosto.CentroCostoDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblCentroCosto.CentroCostoDes "

         Case OrderByFilters.CompId
            strSQL = " ORDER BY tblPlan.PlanCta "

         Case OrderByFilters.CentroCostoCod
            strSQL = " ORDER BY tblCentroCosto.CentroCostoCod "

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
            strSQL = "INSERT INTO tblCentroCosto ("
            strSQL &= "CentroCostoId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CentroCostoDes, "
            strSQL &= "CentroCostoCod, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrCentroCostoDes) & ", "
            strSQL &= StringToField(mstrCentroCostoCod) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCentroCosto SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CentroCostoDes = " & StringToField(mstrCentroCostoDes) & ", "
            strSQL &= "CentroCostoCod = " & StringToField(mstrCentroCostoCod) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CentroCostoId = " & NumberToField(mlngCentroCostoId) & " "

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
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrCentroCostoDes = ToStr(oDataRow("CentroCostoDes"))
               mstrCentroCostoCod = ToStr(oDataRow("CentroCostoCod"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mstrCentroCostoDes = ToStr(oDataRow("CentroCostoDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCentroCostoId = TableIDGet(mstrTableName, "CentroCostoId", moConnection)

         If mlngCentroCostoId = -1 Then
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

      If mstrCentroCostoDes.Length() = 0 Then
         strMsg &= "Ingrese el CentroCosto" & vbCrLf
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
         strSQL &= " FROM tblCentroCosto "

         If Not boolReplace Then
            strSQL &= " WHERE  tblCentroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCosto.CentroCostoCod = " & StringToField(mstrCentroCostoCod)
         Else
            strSQL &= " WHERE  tblCentroCosto.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCosto.CentroCostoCod = " & StringToField(mstrCentroCostoCod)
            strSQL &= " AND  tblCentroCosto.CentroCostoId <> " & NumberToField(mlngCentroCostoId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngCentroCostoId)
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
         strSQL &= " FROM tblCentroCosto "
         strSQL &= " WHERE tblCentroCosto.CentroCostoId = " & NumberToField(mlngCentroCostoId)

         strSQL &= " AND (tblCentroCosto.CentroCostoId IN "
         strSQL &= "     (SELECT DISTINCT CentroCostoId "
         strSQL &= "      FROM  tblCentroCostoDet "
         strSQL &= "      WHERE tblCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         strSQL &= " OR tblCentroCosto.CentroCostoId IN "
         strSQL &= "     (SELECT DISTINCT CentroCostoId "
         strSQL &= "      FROM  tblCompDet "
         strSQL &= "      WHERE tblCompDet.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         strSQL &= " OR tblCentroCosto.CentroCostoId IN "
         strSQL &= "     (SELECT DISTINCT CentroCostoId "
         strSQL &= "      FROM  tblPoliza "
         strSQL &= "      WHERE tblPoliza.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"


         If TableFind(oDataTable, "acfActivoFijo") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  acfActivoFijo "
            strSQL &= "      WHERE acfActivoFijo.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "acfRelocalizacionDet") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoOrigenid "
            strSQL &= "      FROM  acfRelocalizacionDet "
            strSQL &= "      WHERE acfRelocalizacionDet.CentroCostoOrigenid = " & NumberToField(mlngCentroCostoId) & ")"
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostodestinoId "
            strSQL &= "      FROM  acfRelocalizacionDet "
            strSQL &= "      WHERE acfRelocalizacionDet.CentroCostodestinoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "agrLote") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  agrLote "
            strSQL &= "      WHERE agrLote.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "balContrato") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  balContrato "
            strSQL &= "      WHERE balContrato.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "balNotaVenta") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  balNotaVenta "
            strSQL &= "      WHERE balNotaVenta.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comAjuste") Then 'comAjusteDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  comAjuste "
            strSQL &= "      WHERE comAjuste.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comAnticipo") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  comAnticipo "
            strSQL &= "      WHERE comAnticipo.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comCompra") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  comCompra "
            strSQL &= "      WHERE comCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comCompraDet") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoIdAct "
            strSQL &= "      FROM  comCompraDet "
            strSQL &= "      WHERE comCompraDet.CentroCostoIdAct = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comCompraOtroCosto") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  comCompraOtroCosto "
            strSQL &= "      WHERE comCompraOtroCosto.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comCredito") Then  'comCreditoDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  comCredito "
            strSQL &= "      WHERE comCredito.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comDevCompra") Then 'comDevCompraDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  comDevCompra "
            strSQL &= "      WHERE comDevCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comPago") Then 'comPagoDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  comPago "
            strSQL &= "      WHERE comPago.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comPedCompra") Then 'comPedCompraDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  comPedCompra "
            strSQL &= "      WHERE comPedCompra.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "comProveedorMov") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  comProveedorMov "
            strSQL &= "      WHERE comProveedorMov.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "csmMovEquipo") Then 'csmMovEquipoDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  csmMovEquipo "
            strSQL &= "      WHERE csmMovEquipo.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "csmPedMovEquipo") Then 'csmPedMovEquipoDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  csmPedMovEquipo "
            strSQL &= "      WHERE csmPedMovEquipo.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "inmContrato") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  inmContrato "
            strSQL &= "      WHERE inmContrato.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "inmLote") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  inmLote "
            strSQL &= "      WHERE inmLote.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "inmManzana") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  inmManzana "
            strSQL &= "      WHERE inmManzana.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "inmPago") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  inmPago "
            strSQL &= "      WHERE inmPago.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "inmUnidadVecinal") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  inmUnidadVecinal "
            strSQL &= "      WHERE inmUnidadVecinal.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "invAjuste") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  invAjuste "
            strSQL &= "      WHERE invAjuste.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "invNota") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoIdOrg "
            strSQL &= "      FROM  invNota "
            strSQL &= "      WHERE invNota.CentroCostoIdOrg = " & NumberToField(mlngCentroCostoId) & ")"
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoIdDes "
            strSQL &= "      FROM  invNota "
            strSQL &= "      WHERE invNota.CentroCostoIdDes = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "mtoEquipo") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  mtoEquipo "
            strSQL &= "      WHERE mtoEquipo.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "mtoOrdenTrabajo") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  mtoOrdenTrabajo "
            strSQL &= "      WHERE mtoOrdenTrabajo.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "mtoPedidoTrabajo") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  mtoPedidoTrabajo "
            strSQL &= "      WHERE mtoPedidoTrabajo.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "pdeParteDiario") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  pdeParteDiario "
            strSQL &= "      WHERE pdeParteDiario.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "pfiPresuFin") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  pfiPresuFin "
            strSQL &= "      WHERE pfiPresuFin.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "pptPresupuesto") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  pptPresupuesto "
            strSQL &= "      WHERE pptPresupuesto.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "rrhAsistencia") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  rrhAsistencia "
            strSQL &= "      WHERE rrhAsistencia.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "rrhAsistenciaCC") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  rrhAsistenciaCC "
            strSQL &= "      WHERE rrhAsistenciaCC.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "rrhDescuentoNoAplicable") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  rrhDescuentoNoAplicable "
            strSQL &= "      WHERE rrhDescuentoNoAplicable.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "rrhEmpleado") Then '
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  rrhEmpleado "
            strSQL &= "      WHERE rrhEmpleado.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoIdContrato "
            strSQL &= "      FROM  rrhEmpleado "
            strSQL &= "      WHERE rrhEmpleado.CentroCostoIdContrato = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "rrhIngresoNoAplicable") Then 'rrhIngresoNoAplicableDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  rrhIngresoNoAplicable "
            strSQL &= "      WHERE rrhIngresoNoAplicable.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "rrhPlanilla") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  rrhPlanilla "
            strSQL &= "      WHERE rrhPlanilla.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "rrhRetiroPersonal") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  rrhRetiroPersonal "
            strSQL &= "      WHERE rrhRetiroPersonal.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "tesIngresoEgreso") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  tesIngresoEgreso "
            strSQL &= "      WHERE tesIngresoEgreso.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "tesIngresoEgresoDet") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  tesIngresoEgresoDet "
            strSQL &= "      WHERE tesIngresoEgresoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "tesPlanifica") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoConceptoId "
            strSQL &= "      FROM  tesPlanifica "
            strSQL &= "      WHERE tesPlanifica.CentroCostoConceptoId = " & NumberToField(mlngCentroCostoId) & ")"
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoAplicacionId "
            strSQL &= "      FROM  tesPlanifica "
            strSQL &= "      WHERE tesPlanifica.CentroCostoAplicacionId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "tesRendicion") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  tesRendicion "
            strSQL &= "      WHERE tesRendicion.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "tesTransaccion") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoAplicacionId "
            strSQL &= "      FROM  tesTransaccion "
            strSQL &= "      WHERE tesTransaccion.CentroCostoAplicacionId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "tesTransaccionDet") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoConceptoId "
            strSQL &= "      FROM  tesTransaccionDet "
            strSQL &= "      WHERE tesTransaccionDet.CentroCostoConceptoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "tesTransPlanifica") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoConceptoId "
            strSQL &= "      FROM  tesTransPlanifica "
            strSQL &= "      WHERE tesTransPlanifica.CentroCostoConceptoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venAjuste") Then 'venAjusteDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venAjuste "
            strSQL &= "      WHERE venAjuste.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venAnticipo") Then 'venClienteMov
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venAnticipo "
            strSQL &= "      WHERE venAnticipo.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venCredito") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venCredito "
            strSQL &= "      WHERE venCredito.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venDevEntrega") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venDevEntrega "
            strSQL &= "      WHERE venDevEntrega.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venDevVenta") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venDevVenta "
            strSQL &= "      WHERE venDevVenta.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venEntrega") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venEntrega "
            strSQL &= "      WHERE venEntrega.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venPago") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venPago "
            strSQL &= "      WHERE venPago.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venPedVenta") Then   'venPedVentaDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venPedVenta "
            strSQL &= "      WHERE venPedVenta.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venProforma") Then   'venProformaDet
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venProforma "
            strSQL &= "      WHERE venProforma.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venVenta") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venVenta "
            strSQL &= "      WHERE venVenta.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venVentaDet") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoIdCos "
            strSQL &= "      FROM  venVentaDet "
            strSQL &= "      WHERE venVentaDet.CentroCostoIdCos = " & NumberToField(mlngCentroCostoId) & ")"
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoIdIng "
            strSQL &= "      FROM  venVentaDet "
            strSQL &= "      WHERE venVentaDet.CentroCostoIdIng = " & NumberToField(mlngCentroCostoId) & ")"
         End If

         If TableFind(oDataTable, "venVentaDifAju") Then
            strSQL &= " OR tblCentroCosto.CentroCostoId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoId "
            strSQL &= "      FROM  venVentaDifAju "
            strSQL &= "      WHERE venVentaDifAju.CentroCostoId = " & NumberToField(mlngCentroCostoId) & ")"
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
