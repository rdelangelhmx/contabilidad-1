Imports System.Data
Imports System.Data.OleDb

Public Class clsRespaldo
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsRespaldoVM
   Public VMNew As clsRespaldoVM

   Private mlngRespaldoId As Long
   Private mstrRespaldoDes As String
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property RespaldoId() As Long
      Get
         Return mlngRespaldoId
      End Get

      Set(ByVal Value As Long)
         mlngRespaldoId = Value
      End Set
   End Property

   Property RespaldoDes() As String
      Get
         Return mstrRespaldoDes
      End Get

      Set(ByVal Value As String)
         mstrRespaldoDes = Value
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
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      RespaldoDes = 2
      LIKERespaldoDes = 3
      Grid = 4
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      RespaldoId = 1
      RespaldoDes = 2
      Grid = 3
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
      mstrTableName = "tblRespaldo"
      mstrClassName = "clsRespaldo"

      moConnection = New OleDbConnection
      VMNew = New clsRespaldoVM

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
      mlngRespaldoId = 0
      mstrRespaldoDes = ""

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblRespaldo.RespaldoId,  "
            strSQL &= "    tblRespaldo.RespaldoDes,  "
            strSQL &= "    tblRespaldo.sLastUpdate_id,  "
            strSQL &= "    tblRespaldo.dtLastUpdate_dt,  "
            strSQL &= "    tblRespaldo.iConcurrency_id  "
            strSQL &= " FROM tblRespaldo "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblRespaldo.RespaldoId,  "
            strSQL &= "    tblRespaldo.RespaldoDes  "
            strSQL &= " FROM tblRespaldo "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblRespaldo.RespaldoId,  "
            strSQL &= "    tblRespaldo.RespaldoDes  "
            strSQL &= " FROM tblRespaldo "

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
            strSQL = " WHERE  tblRespaldo.RespaldoId = " & NumberToField(mlngRespaldoId)

         Case WhereFilters.RespaldoDes
            strSQL = " WHERE  tblRespaldo.RespaldoDes = " & StringToField(mstrRespaldoDes)

         Case WhereFilters.LIKERespaldoDes
            strSQL = " WHERE  tblRespaldo.RespaldoDes LIKE " & StringToField(mstrRespaldoDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblRespaldo.RespaldoId <> 0 "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.RespaldoId
            strSQL = " ORDER BY tblRespaldo.RespaldoId"

         Case OrderByFilters.RespaldoDes
            strSQL = " ORDER BY tblRespaldo.RespaldoDes"

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
            strSQL = "INSERT INTO tblRespaldo ("
            strSQL &= "RespaldoId, "
            strSQL &= "RespaldoDes, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngRespaldoId) & ", "
            strSQL &= StringToField(mstrRespaldoDes) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblRespaldo SET "
            strSQL &= "RespaldoDes = " & StringToField(mstrRespaldoDes) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " RespaldoId = " & NumberToField(mlngRespaldoId) & " "

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
               mlngRespaldoId = ToLong(oDataRow("RespaldoId"))
               mstrRespaldoDes = ToStr(oDataRow("RespaldoDes"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngRespaldoId = ToLong(oDataRow("RespaldoId"))
               mstrRespaldoDes = ToStr(oDataRow("RespaldoDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngRespaldoId = TableIDGet(mstrTableName, "RespaldoId", moConnection)

         If mlngRespaldoId = -1 Then
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

      If mstrRespaldoDes.Length() = 0 Then
         strMsg &= "Ingrese el Respaldo" & vbCrLf
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
         strSQL &= " FROM tblRespaldo "

         If Not boolReplace Then
            strSQL &= " WHERE  tblRespaldo.RespaldoDes = " & StringToField(mstrRespaldoDes)
         Else
            strSQL &= " WHERE  tblRespaldo.RespaldoDes = " & StringToField(mstrRespaldoDes)
            strSQL &= " AND  tblRespaldo.RespaldoId <> " & NumberToField(mlngRespaldoId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngRespaldoId)
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
         strSQL &= " FROM tblRespaldo "
         strSQL &= " WHERE tblRespaldo.RespaldoId = " & NumberToField(mlngRespaldoId)

         ''tblRecibo(RespaldoId)
         If TableFind(oDataTable, "tblRecibo") Then
            strSQL &= " AND (tblRespaldo.RespaldoId IN "
            strSQL &= "     (SELECT DISTINCT RespaldoId "
            strSQL &= "      FROM  tblRecibo "
            strSQL &= "      WHERE tblRecibo.RespaldoId = " & NumberToField(mlngRespaldoId) & ")"
         End If

         ''tesIngresoEgresoDet(RespaldoId)
         If TableFind(oDataTable, "tesIngresoEgresoDet") Then
            strSQL &= " OR tblRespaldo.RespaldoId IN "
            strSQL &= "   (SELECT DISTINCT RespaldoId "
            strSQL &= "    FROM  tesIngresoEgresoDet "
            strSQL &= "    WHERE tesIngresoEgresoDet.RespaldoId = " & NumberToField(mlngRespaldoId) & ")"
         End If

         ''tesPlanifica(RespaldoId)
         If TableFind(oDataTable, "tesPlanifica") Then
            strSQL &= " OR tblRespaldo.RespaldoId IN "
            strSQL &= "   (SELECT DISTINCT RespaldoId "
            strSQL &= "    FROM  tesPlanifica "
            strSQL &= "    WHERE tesPlanifica.RespaldoId = " & NumberToField(mlngRespaldoId) & ")"
         End If

         ''tesRetencion(RespaldoId)
         If TableFind(oDataTable, "tesRetencion") Then
            strSQL &= " OR tblRespaldo.RespaldoId IN "
            strSQL &= "   (SELECT DISTINCT RespaldoId "
            strSQL &= "    FROM  tesRetencion "
            strSQL &= "    WHERE tesRetencion.RespaldoId = " & NumberToField(mlngRespaldoId) & ")"
         End If

         ''tesTransaccion(RespaldoId)
         If TableFind(oDataTable, "tesTransaccion") Then
            strSQL &= " OR tblRespaldo.RespaldoId IN "
            strSQL &= "   (SELECT DISTINCT RespaldoId "
            strSQL &= "    FROM  tesTransaccion "
            strSQL &= "    WHERE tesTransaccion.RespaldoId = " & NumberToField(mlngRespaldoId) & ")"
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
