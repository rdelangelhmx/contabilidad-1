Imports System.Data
Imports System.Data.OleDb

Public Class clsCentroCostoDet
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsCentroCostoDetVM
   Public VMNew As New clsCentroCostoDetVM

   Private mlngCentroCostoDetId As Long
   Private mlngEmpresaId As Long
   Private mlngCentroCostoId As Long
   Private mstrCentroCostoDetDes As String
   Private mstrCentroCostoDetCod As String
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CentroCostoDetId() As Long
      Get
         Return mlngCentroCostoDetId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoDetId = Value
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

   Property CentroCostoId() As Long
      Get
         Return mlngCentroCostoId
      End Get

      Set(ByVal Value As Long)
         mlngCentroCostoId = Value
      End Set
   End Property

   Property CentroCostoDetDes() As String
      Get
         Return mstrCentroCostoDetDes
      End Get

      Set(ByVal Value As String)
         mstrCentroCostoDetDes = Value
      End Set
   End Property

   Property CentroCostoDetCod() As String
      Get
         Return mstrCentroCostoDetCod
      End Get

      Set(ByVal Value As String)
         mstrCentroCostoDetCod = Value
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
      CentroCostoDetDes = 2
      LIKECentroCostoDetDes = 3
      Grid = 4
      CompId = 5
      EmpresaId = 6
      CentroCostoId = 7
      GridCheck = 8
      CentroCostoDetCod = 9
      EstadoId = 10
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CentroCostoDetId = 1
      CentroCostoDetDes = 2
      Grid = 3
      CompId = 4
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
      mstrTableName = "tblCentroCostoDet"
      mstrClassName = "clsCentroCostoDet"

      moConnection = New OleDbConnection
      VMNew = New clsCentroCostoDetVM

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
      mlngCentroCostoDetId = 0
      mlngEmpresaId = 0
      mlngCentroCostoId = 0
      mstrCentroCostoDetDes = ""
      mstrCentroCostoDetCod = ""
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
            strSQL &= "    tblCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCentroCostoDet.EmpresaId,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoId,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetDes,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetCod,  "
            strSQL &= "    tblCentroCostoDet.EstadoId,  "
            strSQL &= "    tblCentroCostoDet.sLastUpdate_id,  "
            strSQL &= "    tblCentroCostoDet.dtLastUpdate_dt,  "
            strSQL &= "    tblCentroCostoDet.iConcurrency_id  "
            strSQL &= " FROM tblCentroCostoDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetDes  "
            strSQL &= " FROM tblCentroCostoDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCentroCostoDet.EmpresaId,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoId,  "
            strSQL &= "    tblCentroCosto.CentroCostoCod,  "
            strSQL &= "    tblCentroCosto.CentroCostoDes,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetCod,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblCentroCostoDet, tblCentroCosto, tblEstado "

         Case SelectFilters.CompId
            strSQL = " SELECT  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCentroCostoDet.EmpresaId,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetCod,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetDes  "
            strSQL &= " FROM tblCentroCostoDet, tblPlan, tblCompDet "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetId,  "
            strSQL &= "    tblCentroCostoDet.EmpresaId,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoId,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetCod,  "
            strSQL &= "    tblCentroCostoDet.CentroCostoDetDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblCentroCostoDet, tblEstado "

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
            strSQL = " WHERE  tblCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)

         Case WhereFilters.CentroCostoDetDes
            strSQL = " WHERE  tblCentroCostoDet.CentroCostoDetDes = " & StringToField(mstrCentroCostoDetDes)

         Case WhereFilters.LIKECentroCostoDetDes
            strSQL = " WHERE  tblCentroCostoDet.CentroCostoDetDes LIKE " & StringToField(mstrCentroCostoDetDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoId = tblCentroCosto.CentroCostoId "
            strSQL &= " AND  tblCentroCostoDet.EstadoId = tblEstado.EstadoId "
            If mlngCentroCostoId <> 0 Then strSQL &= " AND  tblCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)

         Case WhereFilters.CompId
            'strSQL = " WHERE  tblCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            'strSQL &= " AND  tblCentroCostoDet.CentroCostoDetId = tblCompDet.CentroCostoDetId "
            'strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            'strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngCentroCostoDetId)
            'strSQL &= " AND  tblCompDet.CentroCostoDetId <> 0 "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.CentroCostoId
            strSQL = " WHERE  tblCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)

         Case WhereFilters.GridCheck
            strSQL = " WHERE  tblCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCentroCostoDet.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.CentroCostoDetCod
            strSQL = " WHERE  tblCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoDetCod = " & StringToField(mstrCentroCostoDetCod)

         Case WhereFilters.EstadoId
            strSQL = " WHERE  tblCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)

            If mlngCentroCostoDetId = 0 Then
               strSQL &= " AND  tblCentroCostoDet.EstadoId = " & NumberToField(mlngEstadoId)
            Else
               strSQL &= " AND  (tblCentroCostoDet.EstadoId = " & NumberToField(mlngEstadoId)
               strSQL &= " OR  tblCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ") "
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CentroCostoDetId
            strSQL = " ORDER BY tblCentroCostoDet.CentroCostoDetId "

         Case OrderByFilters.CentroCostoDetDes
            strSQL = " ORDER BY tblCentroCostoDet.CentroCostoDetDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblCentroCosto.CentroCostoDes, tblCentroCostoDet.CentroCostoDetDes "

         Case OrderByFilters.CompId
            strSQL = " ORDER BY tblPlan.PlanCta "

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
            strSQL = "INSERT INTO tblCentroCostoDet ("
            strSQL &= "CentroCostoDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CentroCostoId, "
            strSQL &= "CentroCostoDetDes, "
            strSQL &= "CentroCostoDetCod, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCentroCostoDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCentroCostoId) & ", "
            strSQL &= StringToField(mstrCentroCostoDetDes) & ", "
            strSQL &= StringToField(mstrCentroCostoDetCod) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCentroCostoDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CentroCostoId = " & NumberToField(mlngCentroCostoId) & ", "
            strSQL &= "CentroCostoDetDes = " & StringToField(mstrCentroCostoDetDes) & ", "
            strSQL &= "CentroCostoDetCod = " & StringToField(mstrCentroCostoDetCod) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & " "

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
               mlngCentroCostoDetId = ToLong(oDataRow("CentroCostoDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCentroCostoId = ToLong(oDataRow("CentroCostoId"))
               mstrCentroCostoDetDes = ToStr(oDataRow("CentroCostoDetDes"))
               mstrCentroCostoDetCod = ToStr(oDataRow("CentroCostoDetCod"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCentroCostoDetId = ToLong(oDataRow("CentroCostoDetId"))
               mstrCentroCostoDetDes = ToStr(oDataRow("CentroCostoDetDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCentroCostoDetId = TableIDGet(mstrTableName, "CentroCostoDetId", moConnection)

         If mlngCentroCostoDetId = -1 Then
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

      If mlngCentroCostoId = 0 Then
         strMsg &= "Ingrese el Centro de Costo" & vbCrLf
      End If

      If mstrCentroCostoDetDes.Length() = 0 Then
         strMsg &= "Ingrese el CentroCostoDet" & vbCrLf
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
         strSQL &= " FROM tblCentroCostoDet "

         If Not boolReplace Then
            strSQL &= " WHERE  tblCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoDetCod = " & StringToField(mstrCentroCostoDetCod)
         Else
            strSQL &= " WHERE  tblCentroCostoDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoId = " & NumberToField(mlngCentroCostoId)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoDetCod = " & StringToField(mstrCentroCostoDetCod)
            strSQL &= " AND  tblCentroCostoDet.CentroCostoDetId <> " & NumberToField(mlngCentroCostoDetId)
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
         strSQL &= " FROM tblCentroCostoDet "
         strSQL &= " WHERE tblCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId)

         If TableFind(oDataTable, "tblCompCentroCostoDet") Then
            strSQL &= " AND (tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  tblCompCentroCostoDet "
            strSQL &= "      WHERE tblCompCentroCostoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "tblPoliza") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  tblPoliza "
            strSQL &= "      WHERE tblPoliza.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "agrLote") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  agrLote "
            strSQL &= "      WHERE agrLote.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "balNotaVenta") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  balNotaVenta "
            strSQL &= "      WHERE balNotaVenta.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "comCompraDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetIdAct "
            strSQL &= "      FROM  comCompraDet "
            strSQL &= "      WHERE comCompraDet.CentroCostoDetIdAct = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "comCompraOtroCosto") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  comCompraOtroCosto "
            strSQL &= "      WHERE comCompraOtroCosto.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "comPedCompraDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  comPedCompraDet "
            strSQL &= "      WHERE comPedCompraDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "csmMovEquipoDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  csmMovEquipoDet "
            strSQL &= "      WHERE csmMovEquipoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "csmPedMovEquipoDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  csmPedMovEquipoDet "
            strSQL &= "      WHERE csmPedMovEquipoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "invNotaDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  invNotaDet "
            strSQL &= "      WHERE invNotaDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "mtoOrdenTrabajo") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  mtoOrdenTrabajo "
            strSQL &= "      WHERE mtoOrdenTrabajo.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "mtoPedidoTrabajo") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  mtoPedidoTrabajo "
            strSQL &= "      WHERE mtoPedidoTrabajo.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "pdeParteDiarioDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  pdeParteDiarioDet "
            strSQL &= "      WHERE pdeParteDiarioDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "pptPresupuestoDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  pptPresupuestoDet "
            strSQL &= "      WHERE pptPresupuestoDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "pptPresupuestoDetFis") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  pptPresupuestoDetFis "
            strSQL &= "      WHERE pptPresupuestoDetFis.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "tesIngresoEgreso") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  tesIngresoEgreso "
            strSQL &= "      WHERE tesIngresoEgreso.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "venPedVentaDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  venPedVentaDet "
            strSQL &= "      WHERE venPedVentaDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "venProformaDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetId "
            strSQL &= "      FROM  venProformaDet "
            strSQL &= "      WHERE venProformaDet.CentroCostoDetId = " & NumberToField(mlngCentroCostoDetId) & ")"
         End If

         If TableFind(oDataTable, "venVentaDet") Then
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetIdCos "
            strSQL &= "      FROM  venVentaDet "
            strSQL &= "      WHERE venVentaDet.CentroCostoDetIdCos = " & NumberToField(mlngCentroCostoDetId) & ")"
            strSQL &= " OR tblCentroCostoDet.CentroCostoDetId IN "
            strSQL &= "     (SELECT DISTINCT CentroCostoDetIdIng "
            strSQL &= "      FROM  venVentaDet "
            strSQL &= "      WHERE venVentaDet.CentroCostoDetIdIng = " & NumberToField(mlngCentroCostoDetId) & ")"
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
