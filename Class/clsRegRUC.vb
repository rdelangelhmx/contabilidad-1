Imports System.Data
Imports System.Data.OleDb

Public Class clsRegRUC
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsRegRucVM
   Public VMNew As clsRegRucVM

   Private mlngRegRUCId As Long
   Private mlngEmpresaId As Long
   Private mstrRegRUCDes As String
   Private mstrNroRUC As String
   Private mlngPlanId As Long
   Private mstrNroAutorizacion As String
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property RegRUCId() As Long
      Get
         Return mlngRegRUCId
      End Get

      Set(ByVal Value As Long)
         mlngRegRUCId = Value
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

   Property RegRUCDes() As String
      Get
         Return mstrRegRUCDes
      End Get

      Set(ByVal Value As String)
         mstrRegRUCDes = Value
      End Set
   End Property

   Property NroRUC() As String
      Get
         Return mstrNroRUC
      End Get

      Set(ByVal Value As String)
         mstrNroRUC = Value
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

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
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
      RegRUCDes = 2
      LIKERegRUCDes = 3
      Grid = 4
      NroRUC = 5
      EmpresaId = 6
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      RegRUCId = 1
      RegRUCDes = 2
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
      mstrTableName = "tblRegRUC"
      mstrClassName = "clsRegRUC"

      moConnection = New OleDbConnection
      VMNew = New clsRegRucVM

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
      mlngRegRUCId = 0
      mlngEmpresaId = 0
      mstrRegRUCDes = ""
      mstrNroRUC = ""
      mstrNroAutorizacion = ""
      mlngPlanId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblRegRUC.RegRUCId,  "
            strSQL &= "    tblRegRUC.EmpresaId,  "
            strSQL &= "    tblRegRUC.RegRUCDes,  "
            strSQL &= "    tblRegRUC.NroRUC,  "
            strSQL &= "    tblRegRUC.NroAutorizacion,  "
            strSQL &= "    tblRegRUC.PlanId,  "
            strSQL &= "    tblRegRUC.sLastUpdate_id,  "
            strSQL &= "    tblRegRUC.dtLastUpdate_dt,  "
            strSQL &= "    tblRegRUC.iConcurrency_id  "
            strSQL &= " FROM tblRegRUC "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblRegRUC.RegRUCId,  "
            strSQL &= "    tblRegRUC.RegRUCDes  "
            strSQL &= " FROM tblRegRUC "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblRegRUC.RegRUCId,  "
            strSQL &= "    tblRegRUC.EmpresaId,  "
            strSQL &= "    tblRegRUC.NroRUC,  "
            strSQL &= "    tblRegRUC.RegRUCDes,  "
            strSQL &= "    tblRegRUC.NroAutorizacion,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanDes  "
            strSQL &= " FROM tblRegRUC, tblPlan "

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
            strSQL = " WHERE  tblRegRUC.RegRUCId = " & NumberToField(mlngRegRUCId)

         Case WhereFilters.RegRUCDes
            strSQL = " WHERE  tblRegRUC.RegRUCDes = " & StringToField(mstrRegRUCDes)

         Case WhereFilters.LIKERegRUCDes
            strSQL = " WHERE  tblRegRUC.RegRUCDes LIKE " & StringToField(mstrRegRUCDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblRegRUC.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblRegRUC.PlanId = tblPlan.PlanId "

         Case WhereFilters.NroRUC
            strSQL = " WHERE  tblRegRUC.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblRegRUC.NroRUC = " & StringToField(mstrNroRUC)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblRegRUC.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " OR  tblRegRUC.EmpresaId = 0 "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.RegRUCId
            strSQL = " ORDER BY tblRegRUC.RegRUCId"

         Case OrderByFilters.RegRUCDes
            strSQL = " ORDER BY tblRegRUC.RegRUCDes"

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblRegRUC.RegRUCDes"

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
            strSQL = "INSERT INTO tblRegRUC ("
            strSQL &= "RegRUCId, "
            strSQL &= "EmpresaId, "
            strSQL &= "RegRUCDes, "
            strSQL &= "NroRUC, "
            strSQL &= "NroAutorizacion, "
            strSQL &= "PlanId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngRegRUCId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrRegRUCDes) & ", "
            strSQL &= StringToField(mstrNroRUC) & ", "
            strSQL &= StringToField(mstrNroAutorizacion) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblRegRUC SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "RegRUCDes = " & StringToField(mstrRegRUCDes) & ", "
            strSQL &= "NroRUC = " & StringToField(mstrNroRUC) & ", "
            strSQL &= "NroAutorizacion = " & StringToField(mstrNroAutorizacion) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " RegRUCId = " & NumberToField(mlngRegRUCId) & " "

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
               mlngRegRUCId = ToLong(oDataRow("RegRUCId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrRegRUCDes = ToStr(oDataRow("RegRUCDes"))
               mstrNroRUC = ToStr(oDataRow("NroRUC"))
               mstrNroAutorizacion = ToStr(oDataRow("NroAutorizacion"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngRegRUCId = ToLong(oDataRow("RegRUCId"))
               mstrRegRUCDes = ToStr(oDataRow("RegRUCDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngRegRUCId = TableIDGet(mstrTableName, "RegRUCId", moConnection)

         If mlngRegRUCId = -1 Then
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

      If mstrNroRUC.Length() = 0 Then
         strMsg &= "Ingrese el N�mero de NIT" & vbCrLf
      End If

      If mstrRegRUCDes.Length() = 0 Then
         strMsg &= "Ingrese La Raz�n Social" & vbCrLf
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
         strSQL &= " FROM tblRegRUC "

         If Not boolReplace Then
            strSQL &= " WHERE  tblRegRUC.NroRUC = " & StringToField(mstrNroRUC)
            strSQL &= " AND  tblRegRUC.NroRUC <> '0' "
            strSQL &= " AND  tblRegRUC.EmpresaId = " & NumberToField(mlngEmpresaId)
         Else
            strSQL &= " WHERE  tblRegRUC.NroRUC = " & StringToField(mstrNroRUC)
            strSQL &= " AND  tblRegRUC.NroRUC <> '0' "
            strSQL &= " AND  tblRegRUC.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblRegRUC.RegRUCId <> " & NumberToField(mlngRegRUCId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngRegRUCId)
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
         strSQL &= " FROM tblRegRUC "
         strSQL &= " WHERE tblRegRUC.RegRUCId = " & NumberToField(mlngRegRUCId)

         If TableFind(oDataTable, "tblFactura") Then
            strSQL &= " AND (tblRegRUC.RegRUCId IN "
            strSQL &= "     (SELECT DISTINCT RegRUCId "
            strSQL &= "      FROM  tblFactura "
            strSQL &= "      WHERE tblFactura.RegRUCId = " & NumberToField(mlngRegRUCId) & ")"
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
