Imports System.Data
Imports System.Data.OleDb

Public Class clsBanco
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsBancoVM
   Public VMNew As New clsBancoVM

   Private mlngBancoId As Long
   Private mlngEmpresaId As Long
   Private mstrBancoDes As String
   Private mlngPlanId As Long
   Private mstrBancoCod As String
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property BancoId() As Long
      Get
         Return mlngBancoId
      End Get

      Set(ByVal Value As Long)
         mlngBancoId = Value
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

   Property BancoDes() As String
      Get
         Return mstrBancoDes
      End Get

      Set(ByVal Value As String)
         mstrBancoDes = Value
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

   Property BancoCod() As String
      Get
         Return mstrBancoCod
      End Get

      Set(ByVal Value As String)
         mstrBancoCod = Value
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
      BancoDes = 2
      LIKEBancoDes = 3
      Grid = 4
      EmpresaId = 5
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      BancoId = 1
      BancoDes = 2
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
      mstrTableName = "tblBanco"
      mstrClassName = "clsBanco"

      moConnection = New OleDbConnection
      VMNew = New clsBancoVM

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
      mlngBancoId = 0
      mlngEmpresaId = 0
      mstrBancoDes = ""
      mlngPlanId = 0
      mstrBancoCod = ""

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblBanco.BancoId,  "
            strSQL &= "    tblBanco.EmpresaId,  "
            strSQL &= "    tblBanco.BancoDes,  "
            strSQL &= "    tblBanco.PlanId,  "
            strSQL &= "    tblBanco.BancoCod,  "
            strSQL &= "    tblBanco.sLastUpdate_id,  "
            strSQL &= "    tblBanco.dtLastUpdate_dt,  "
            strSQL &= "    tblBanco.iConcurrency_id  "
            strSQL &= " FROM tblBanco "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblBanco.BancoId,  "
            strSQL &= "    tblBanco.BancoDes  "
            strSQL &= " FROM tblBanco "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblBanco.BancoId,  "
            strSQL &= "    tblBanco.EmpresaId,  "
            strSQL &= "    tblBanco.BancoDes,  "
            strSQL &= "    tblBanco.BancoCod,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanDes   "
            strSQL &= " FROM tblBanco, tblPlan "

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
            strSQL = " WHERE  tblBanco.BancoId = " & NumberToField(mlngBancoId)

         Case WhereFilters.BancoDes
            strSQL = " WHERE  tblBanco.BancoDes = " & StringToField(mstrBancoDes)

         Case WhereFilters.LIKEBancoDes
            strSQL = " WHERE  tblBanco.BancoDes LIKE " & StringToField(mstrBancoDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblBanco.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblBanco.PlanId = tblPlan.PlanId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblBanco.EmpresaId = " & NumberToField(mlngEmpresaId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.BancoId
            strSQL = " ORDER BY tblBanco.BancoId"

         Case OrderByFilters.BancoDes
            strSQL = " ORDER BY tblBanco.BancoDes"

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblBanco.BancoDes"

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
            strSQL = "INSERT INTO tblBanco ("
            strSQL &= "BancoId, "
            strSQL &= "EmpresaId, "
            strSQL &= "BancoDes, "
            strSQL &= "PlanId, "
            strSQL &= "BancoCod, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngBancoId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrBancoDes) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= StringToField(mstrBancoCod) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblBanco SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "BancoDes = " & StringToField(mstrBancoDes) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "BancoCod = " & StringToField(mstrBancoCod) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " BancoId = " & NumberToField(mlngBancoId) & " "

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
               mlngBancoId = ToLong(oDataRow("BancoId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrBancoDes = ToStr(oDataRow("BancoDes"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mstrBancoCod = ToStr(oDataRow("BancoCod"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngBancoId = ToLong(oDataRow("BancoId"))
               mstrBancoDes = ToStr(oDataRow("BancoDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngBancoId = TableIDGet(mstrTableName, "BancoId", moConnection)

         If mlngBancoId = -1 Then
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

      If mstrBancoDes.Length() = 0 Then
         strMsg &= "Ingrese el Banco" & vbCrLf
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
         strSQL &= " FROM tblBanco "

         If Not boolReplace Then
            strSQL &= " WHERE  tblBanco.BancoDes = " & StringToField(mstrBancoDes)
            strSQL &= " AND  tblBanco.EmpresaId = " & NumberToField(mlngEmpresaId)
         Else
            strSQL &= " WHERE  tblBanco.BancoDes = " & StringToField(mstrBancoDes)
            strSQL &= " AND  tblBanco.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblBanco.BancoId <> " & NumberToField(mlngBancoId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngBancoId)
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
         strSQL &= " FROM tblBanco "
         strSQL &= " WHERE tblBanco.BancoId = " & NumberToField(mlngBancoId)

         If TableFind(oDataTable, "tblCheque") Then
            strSQL &= " AND (tblBanco.BancoId IN "
            strSQL &= "     (SELECT DISTINCT BancoId "
            strSQL &= "      FROM  tblCheque "
            strSQL &= "      WHERE tblCheque.BancoId = " & NumberToField(mlngBancoId) & ")"
         End If

         If TableFind(oDataTable, "venTipoTarjeta") Then
            strSQL &= " OR tblBanco.BancoId IN "
            strSQL &= "   (SELECT DISTINCT BancoId "
            strSQL &= "    FROM  venTipoTarjeta "
            strSQL &= "    WHERE venTipoTarjeta.BancoId = " & NumberToField(mlngBancoId) & ")"
         End If

         If TableFind(oDataTable, "rrhEmpleado") Then
            strSQL &= " OR tblBanco.BancoId IN "
            strSQL &= "   (SELECT DISTINCT BancoId "
            strSQL &= "    FROM  rrhEmpleado "
            strSQL &= "    WHERE rrhEmpleado.BancoId = " & NumberToField(mlngBancoId) & ")"
         End If

         If TableFind(oDataTable, "rrhFiniquito") Then
            strSQL &= " OR tblBanco.BancoId IN "
            strSQL &= "   (SELECT DISTINCT BancoId "
            strSQL &= "    FROM  rrhFiniquito "
            strSQL &= "    WHERE rrhFiniquito.BancoId = " & NumberToField(mlngBancoId) & ")"
         End If

         If TableFind(oDataTable, "rrhQuinquenio") Then
            strSQL &= " OR tblBanco.BancoId IN "
            strSQL &= "   (SELECT DISTINCT BancoId "
            strSQL &= "    FROM  rrhQuinquenio "
            strSQL &= "    WHERE rrhQuinquenio.BancoId = " & NumberToField(mlngBancoId) & ")"
         End If

         If TableFind(oDataTable, "surCheque") Then
            strSQL &= " OR tblBanco.BancoId IN "
            strSQL &= "   (SELECT DISTINCT BancoId "
            strSQL &= "    FROM  surCheque "
            strSQL &= "    WHERE surCheque.BancoId = " & NumberToField(mlngBancoId) & ")"
         End If

         If TableFind(oDataTable, "rrhCtaBanco") Then
            strSQL &= " OR tblBanco.BancoId IN "
            strSQL &= "   (SELECT DISTINCT BancoId "
            strSQL &= "    FROM  rrhCtaBanco "
            strSQL &= "    WHERE rrhCtaBanco.BancoId = " & NumberToField(mlngBancoId) & ")"
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
