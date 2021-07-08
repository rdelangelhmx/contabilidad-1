Imports System.Data
Imports System.Data.OleDb

Public Class clsCheque
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsChequeVM
   Public VMNew As clsChequeVM

   Private mlngChequeId As Long
   Private mlngEmpresaId As Long
   Private mlngPlanId As Long
   Private mlngBancoId As Long
   Private mstrBancoCta As String
   Private mlngOrientacionId As Long
   Private mlngChequeWidth As Long
   Private mlngChequeHeight As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property ChequeId() As Long
      Get
         Return mlngChequeId
      End Get

      Set(ByVal Value As Long)
         mlngChequeId = Value
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

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
      End Set
   End Property

   Property BancoId() As Long
      Get
         Return mlngBancoId
      End Get

      Set(ByVal Value As Long)
         mlngBancoId = Value
      End Set
   End Property

   Property BancoCta() As String
      Get
         Return mstrBancoCta
      End Get

      Set(ByVal Value As String)
         mstrBancoCta = Value
      End Set
   End Property

   Property OrientacionId() As Long
      Get
         Return mlngOrientacionId
      End Get

      Set(ByVal Value As Long)
         mlngOrientacionId = Value
      End Set
   End Property

   Property ChequeWidth() As Long
      Get
         Return mlngChequeWidth
      End Get

      Set(ByVal Value As Long)
         mlngChequeWidth = Value
      End Set
   End Property

   Property ChequeHeight() As Long
      Get
         Return mlngChequeHeight
      End Get

      Set(ByVal Value As Long)
         mlngChequeHeight = Value
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
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 2
      PlanId = 3
      BancoCta = 4
      BancoMoneda = 5
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ChequeId = 1
      Grid = 2
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
      mstrTableName = "tblCheque"
      mstrClassName = "clsCheque"

      moConnection = New OleDbConnection
      VMNew = New clsChequeVM

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
      mlngChequeId = 0
      mlngEmpresaId = 0
      mlngPlanId = 0
      mlngBancoId = 0
      mstrBancoCta = ""
      mlngOrientacionId = 0
      mlngChequeWidth = 0
      mlngChequeHeight = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblCheque.ChequeId,  "
            strSQL &= "    tblCheque.EmpresaId,  "
            strSQL &= "    tblCheque.PlanId,  "
            strSQL &= "    tblCheque.BancoId,  "
            strSQL &= "    tblCheque.BancoCta,  "
            strSQL &= "    tblCheque.OrientacionId,  "
            strSQL &= "    tblCheque.ChequeWidth,  "
            strSQL &= "    tblCheque.ChequeHeight,  "
            strSQL &= "    tblCheque.sLastUpdate_id,  "
            strSQL &= "    tblCheque.dtLastUpdate_dt,  "
            strSQL &= "    tblCheque.iConcurrency_id  "
            strSQL &= " FROM tblCheque "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCheque.ChequeId  "
            strSQL &= " FROM tblCheque "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCheque.ChequeId,  "
            strSQL &= "    tblCheque.EmpresaId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblBanco.BancoId,  "
            strSQL &= "    tblBanco.BancoDes,  "
            strSQL &= "    tblCheque.BancoCta  "
            strSQL &= " FROM tblCheque, tblPlan, tblBanco "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblCheque.ChequeId,  "
            strSQL &= "    tblCheque.EmpresaId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblBanco.BancoId,  "
            strSQL &= "    tblBanco.BancoDes,  "
            strSQL &= "    tblCheque.BancoCta  "
            strSQL &= " FROM tblCheque, tblPlan, tblBanco "

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
            strSQL = " WHERE  tblCheque.ChequeId = " & NumberToField(mlngChequeId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCheque.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCheque.BancoId = tblBanco.BancoId "

         Case WhereFilters.PlanId
            strSQL = " WHERE  tblCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCheque.PlanId = " & NumberToField(mlngPlanId)

         Case WhereFilters.BancoCta
            strSQL = " WHERE  tblCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCheque.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCheque.BancoCta = " & StringToField(mstrBancoCta)

         Case WhereFilters.BancoMoneda
            strSQL = " WHERE  tblCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCheque.BancoId = " & NumberToField(mlngBancoId)
            strSQL &= " AND  tblCheque.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCheque.BancoId = tblBanco.BancoId "

            If mlngOrientacionId <> 0 Then
               strSQL &= " AND  tblPlan.MonedaId  = " & NumberToField(mlngOrientacionId)
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ChequeId
            strSQL = " ORDER BY tblCheque.ChequeId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblBanco.BancoDes "

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
            strSQL = "INSERT INTO tblCheque ("
            strSQL &= "ChequeId, "
            strSQL &= "EmpresaId, "
            strSQL &= "PlanId, "
            strSQL &= "BancoId, "
            strSQL &= "BancoCta, "
            strSQL &= "OrientacionId, "
            strSQL &= "ChequeWidth, "
            strSQL &= "ChequeHeight, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngChequeId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngBancoId) & ", "
            strSQL &= StringToField(mstrBancoCta) & ", "
            strSQL &= NumberToField(mlngOrientacionId) & ", "
            strSQL &= NumberToField(ChequeWidth) & ", "
            strSQL &= NumberToField(ChequeHeight) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCheque SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "BancoId = " & NumberToField(mlngBancoId) & ", "
            strSQL &= "BancoCta = " & StringToField(mstrBancoCta) & ", "
            strSQL &= "OrientacionId = " & NumberToField(mlngOrientacionId) & ", "
            strSQL &= "ChequeWidth = " & NumberToField(mlngChequeWidth) & ", "
            strSQL &= "ChequeHeight = " & NumberToField(mlngChequeHeight) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ChequeId = " & NumberToField(mlngChequeId) & " "

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
               mlngChequeId = ToLong(oDataRow("ChequeId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngBancoId = ToLong(oDataRow("BancoId"))
               mstrBancoCta = ToStr(oDataRow("BancoCta"))
               mlngOrientacionId = ToLong(oDataRow("OrientacionId"))
               mlngChequeWidth = ToLong(oDataRow("ChequeWidth"))
               mlngChequeHeight = ToLong(oDataRow("ChequeHeight"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngChequeId = ToLong(oDataRow("ChequeId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngChequeId = TableIDGet(mstrTableName, "ChequeId", moConnection)

         If mlngChequeId = -1 Then
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

      If mlngPlanId = 0 Then
         strMsg &= "Seleccione la Cuenta" & vbCrLf
      End If

      If mlngBancoId = 0 Then
         strMsg &= "Seleccione el Banco" & vbCrLf
      End If

      If mstrBancoCta.Trim() = String.Empty Then
         strMsg &= "Ingrese la Cuenta Bancaria" & vbCrLf
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
         strSQL &= " FROM tblCheque "

         If Not boolReplace Then
            strSQL &= " WHERE  tblCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCheque.PlanId = " & NumberToField(mlngPlanId)
         Else
            strSQL &= " WHERE  tblCheque.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCheque.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCheque.ChequeId <> " & NumberToField(mlngChequeId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngChequeId)
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
         strSQL &= " FROM tblCheque "
         strSQL &= " WHERE tblCheque.ChequeId = " & NumberToField(mlngChequeId)

         If TableFind(oDataTable, "tblCompCheque") Then
            strSQL &= " AND (tblCheque.ChequeId IN "
            strSQL &= "     (SELECT DISTINCT ChequeId "
            strSQL &= "      FROM  tblCompCheque "
            strSQL &= "      WHERE tblCompCheque.ChequeId = " & NumberToField(mlngChequeId) & ")"
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
