Imports System.Data
Imports System.Data.OleDb

Public Class clsPlanAdd
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsPlanAddVM
   Public VMNew As New clsPlanAddVM

   Private mlngPlanAddId As Long
   Private mlngEmpresaId As Long
   Private mlngPlanId As Long
   Private mstrPlanAddDes As String
   Private mstrPlanAddCta As String
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property PlanAddId() As Long
      Get
         Return mlngPlanAddId
      End Get

      Set(ByVal Value As Long)
         mlngPlanAddId = Value
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

   Property PlanAddDes() As String
      Get
         Return mstrPlanAddDes
      End Get

      Set(ByVal Value As String)
         mstrPlanAddDes = Value
      End Set
   End Property

   Property PlanAddCta() As String
      Get
         Return mstrPlanAddCta
      End Get

      Set(ByVal Value As String)
         mstrPlanAddCta = Value
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
      PlanAddDes = 2
      LIKEPlanAddDes = 3
      Grid = 4
      PlanId = 5
      CompId = 6
      PlanAddCta = 7
      PlanIdPlanAddActivos = 8
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PlanAddId = 1
      PlanAddDes = 2
      Grid = 3
      PlanAddCta = 4
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
      mstrTableName = "tblPlanAdd"
      mstrClassName = "clsPlanAdd"

      moConnection = New OleDbConnection
      VMNew = New clsPlanAddVM

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
      mlngPlanAddId = 0
      mlngEmpresaId = 0
      mlngPlanId = 0
      mstrPlanAddDes = ""
      mstrPlanAddCta = ""
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
            strSQL &= "    tblPlanAdd.PlanAddId,  "
            strSQL &= "    tblPlanAdd.EmpresaId,  "
            strSQL &= "    tblPlanAdd.PlanId,  "
            strSQL &= "    tblPlanAdd.PlanAddDes,  "
            strSQL &= "    tblPlanAdd.PlanAddCta,  "
            strSQL &= "    tblPlanAdd.EstadoId,  "
            strSQL &= "    tblPlanAdd.sLastUpdate_id,  "
            strSQL &= "    tblPlanAdd.dtLastUpdate_dt,  "
            strSQL &= "    tblPlanAdd.iConcurrency_id  "
            strSQL &= " FROM tblPlanAdd "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblPlanAdd.PlanAddId,  "
            strSQL &= "    tblPlanAdd.PlanAddDes  "
            strSQL &= " FROM tblPlanAdd "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblPlanAdd.PlanAddId,  "
            strSQL &= "    tblPlanAdd.EmpresaId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlanAdd.PlanAddCta,  "
            strSQL &= "    tblPlanAdd.PlanAddDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlanAdd, tblPlan, tblEstado "

         Case SelectFilters.CompId
            strSQL = " SELECT  "
            strSQL &= "    tblPlanAdd.PlanAddId,  "
            strSQL &= "    tblPlanAdd.EmpresaId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblPlanAdd.PlanAddCta,  "
            strSQL &= "    tblPlanAdd.PlanAddDes  "
            strSQL &= " FROM tblPlanAdd, tblPlan, tblCompDet "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblPlanAdd.PlanAddId,  "
            strSQL &= "    tblPlanAdd.EmpresaId,  "
            strSQL &= "    tblPlanAdd.PlanId,  "
            strSQL &= "    tblPlanAdd.PlanAddCta,  "
            strSQL &= "    tblPlanAdd.PlanAddDes  "
            strSQL &= " FROM tblPlanAdd "

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
            strSQL = " WHERE  tblPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId)

         Case WhereFilters.PlanAddDes
            strSQL = " WHERE  tblPlanAdd.PlanAddDes = " & StringToField(mstrPlanAddDes)

         Case WhereFilters.LIKEPlanAddDes
            strSQL = " WHERE  tblPlanAdd.PlanAddDes LIKE " & StringToField(mstrPlanAddDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanAdd.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblPlanAdd.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.PlanId
            strSQL = " WHERE  tblPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanAdd.PlanId = " & NumberToField(mlngPlanId)

         Case WhereFilters.CompId
            strSQL = " WHERE  tblPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanAdd.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblPlanAdd.PlanAddId = tblCompDet.PlanAddId "
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblCompDet.PlanAddId <> 0 "

         Case WhereFilters.PlanAddCta
            strSQL = " WHERE  tblPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblPlanAdd.PlanAddCta = " & StringToField(mstrPlanAddCta)

         Case WhereFilters.PlanIdPlanAddActivos
            strSQL = " WHERE  tblPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanAdd.PlanId = " & NumberToField(mlngPlanId)

            If mlngEstadoId = clsEstado.ACTIVO Then
               If mlngPlanAddId = 0 Then
                  strSQL &= " AND  tblPlanAdd.EstadoId = " & NumberToField(clsEstado.ACTIVO)
               Else
                  strSQL &= " AND  (tblPlanAdd.EstadoId = " & NumberToField(clsEstado.ACTIVO)
                  strSQL &= " OR    tblPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId) & " )"
               End If
            End If
      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PlanAddId
            strSQL = " ORDER BY tblPlanAdd.PlanAddId "

         Case OrderByFilters.PlanAddDes
            strSQL = " ORDER BY tblPlanAdd.PlanAddDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblPlan.PlanDes, tblPlanAdd.PlanAddDes "

         Case OrderByFilters.PlanAddCta
            strSQL = " ORDER BY tblPlanAdd.PlanAddCta DESC "

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
            strSQL = "INSERT INTO tblPlanAdd ("
            strSQL &= "PlanAddId, "
            strSQL &= "EmpresaId, "
            strSQL &= "PlanId, "
            strSQL &= "PlanAddDes, "
            strSQL &= "PlanAddCta, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPlanAddId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= StringToField(mstrPlanAddDes) & ", "
            strSQL &= StringToField(mstrPlanAddCta) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblPlanAdd SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "PlanAddDes = " & StringToField(mstrPlanAddDes) & ", "
            strSQL &= "PlanAddCta = " & StringToField(mstrPlanAddCta) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PlanAddId = " & NumberToField(mlngPlanAddId) & " "

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
               mlngPlanAddId = ToLong(oDataRow("PlanAddId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mstrPlanAddDes = ToStr(oDataRow("PlanAddDes"))
               mstrPlanAddCta = ToStr(oDataRow("PlanAddCta"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPlanAddId = ToLong(oDataRow("PlanAddId"))
               mstrPlanAddDes = ToStr(oDataRow("PlanAddDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPlanAddId = TableIDGet(mstrTableName, "PlanAddId", moConnection)

         If mlngPlanAddId = -1 Then
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

      If mlngPlanId = 0 Then
         strMsg &= "Cuenta Padre Inválida" & vbCrLf
      End If

      If mstrPlanAddDes.Length() = 0 Then
         strMsg &= "Descripción de Analítico Adicional Inválida" & vbCrLf
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
         strSQL &= " FROM tblPlanAdd "

         If Not boolReplace Then
            strSQL &= " WHERE  tblPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblPlanAdd.PlanAddCta = " & StringToField(mstrPlanAddCta)
            strSQL &= " AND  tblPlanAdd.EstadoId = " & NumberToField(mlngEstadoId)
         Else
            strSQL &= " WHERE  tblPlanAdd.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanAdd.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblPlanAdd.PlanAddCta = " & StringToField(mstrPlanAddCta)
            strSQL &= " AND  tblPlanAdd.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblPlanAdd.PlanAddId <> " & NumberToField(mlngPlanAddId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngPlanAddId)
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
         strSQL &= " FROM tblPlanAdd "
         strSQL &= " WHERE tblPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId)

         ''tblCompPlanAdd(PlanAddId)
         If TableFind(oDataTable, "tblCompPlanAdd") Then
            strSQL &= " AND (tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  tblCompPlanAdd "
            strSQL &= "      WHERE tblCompPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tblPersonal(PlanAddId)
         If TableFind(oDataTable, "tblPersonal") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  tblPersonal "
            strSQL &= "      WHERE tblPersonal.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tblPoliza(PlanAddId)
         If TableFind(oDataTable, "tblPoliza") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  tblPoliza "
            strSQL &= "      WHERE tblPoliza.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''acfActivoFijo(PlanAddDepAcuID)
         ''acfActivoFijo(PlanAddVOID)
         If TableFind(oDataTable, "acfActivoFijo") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "   (SELECT DISTINCT PlanAddDepAcuID "
            strSQL &= "    FROM  acfActivoFijo "
            strSQL &= "    WHERE acfActivoFijo.PlanAddDepAcuID = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "   (SELECT DISTINCT PlanAddVOID "
            strSQL &= "    FROM  acfActivoFijo "
            strSQL &= "    WHERE acfActivoFijo.PlanAddVOID = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''comCompraDet(PlanAddIdAct)
         If TableFind(oDataTable, "comCompraDet") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdAct "
            strSQL &= "      FROM  comCompraDet "
            strSQL &= "      WHERE comCompraDet.PlanAddIdAct = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''comCompraOtroCosto(PlanAddId)
         If TableFind(oDataTable, "comCompraOtroCosto") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  comCompraOtroCosto "
            strSQL &= "      WHERE comCompraOtroCosto.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''comProveedor(PlanAddIdAct)
         ''comProveedor(PlanAddIdInt)
         ''comProveedor(PlanAddIdPas)
         If TableFind(oDataTable, "comProveedor") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdAct "
            strSQL &= "      FROM  comProveedor "
            strSQL &= "      WHERE comProveedor.PlanAddIdAct = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdInt "
            strSQL &= "      FROM  comProveedor "
            strSQL &= "      WHERE comProveedor.PlanAddIdInt = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdPas "
            strSQL &= "      FROM  comProveedor "
            strSQL &= "      WHERE comProveedor.PlanAddIdPas = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''csmMovEquipoDet(PlanAddId)
         If TableFind(oDataTable, "csmMovEquipoDet") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  csmMovEquipoDet "
            strSQL &= "      WHERE csmMovEquipoDet.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''inmCliente(PlanAddIdAct)
         ''inmCliente(PlanAddIdForm)
         ''inmCliente(PlanAddIdInt)
         ''inmCliente(PlanAddIdIntPen)
         If TableFind(oDataTable, "inmCliente") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdAct "
            strSQL &= "      FROM  inmCliente "
            strSQL &= "      WHERE inmCliente.PlanAddIdAct = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdForm "
            strSQL &= "      FROM  inmCliente "
            strSQL &= "      WHERE inmCliente.PlanAddIdForm = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdInt "
            strSQL &= "      FROM  inmCliente "
            strSQL &= "      WHERE inmCliente.PlanAddIdInt = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdIntPen "
            strSQL &= "      FROM  inmCliente "
            strSQL &= "      WHERE inmCliente.PlanAddIdIntPen = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''inmLote(PlanAddIdIng)
         If TableFind(oDataTable, "inmLote") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdIng "
            strSQL &= "      FROM  inmLote "
            strSQL &= "      WHERE inmLote.PlanAddIdIng = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''pdeTarea(PlanAddIdCos)
         ''pdeTarea(PlanAddIdIng)
         ''pdeTarea(PlanAddIdIngExt)
         If TableFind(oDataTable, "pdeTarea") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdCos "
            strSQL &= "      FROM  pdeTarea "
            strSQL &= "      WHERE pdeTarea.PlanAddIdCos = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdIng "
            strSQL &= "      FROM  pdeTarea "
            strSQL &= "      WHERE pdeTarea.PlanAddIdIng = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdIngExt "
            strSQL &= "      FROM  pdeTarea "
            strSQL &= "      WHERE pdeTarea.PlanAddIdIngExt = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''pdvPromotor(PlanAddId)
         If TableFind(oDataTable, "pdvPromotor") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  pdvPromotor "
            strSQL &= "      WHERE pdvPromotor.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''rrhEmpleado(PlanAddId)
         If TableFind(oDataTable, "rrhEmpleado") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  rrhEmpleado "
            strSQL &= "      WHERE rrhEmpleado.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''rrhEmpleadoAna(PlanAddId)
         If TableFind(oDataTable, "rrhEmpleadoAna") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  rrhEmpleadoAna "
            strSQL &= "      WHERE rrhEmpleadoAna.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tesIngresoEgreso(PlanAddId)
         If TableFind(oDataTable, "tesIngresoEgreso") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  tesIngresoEgreso "
            strSQL &= "      WHERE tesIngresoEgreso.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tesPlanifica(PlanAddAplicacionId)
         ''tesPlanifica(PlanAddConceptoId)
         ''tesPlanificaDet(PlanAddAplicacionId)
         ''tesPlanificaDet(PlanAddConceptoId)
         If TableFind(oDataTable, "tesPlanifica") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddAplicacionId "
            strSQL &= "      FROM  tesPlanifica "
            strSQL &= "      WHERE tesPlanifica.PlanAddAplicacionId = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddConceptoId "
            strSQL &= "      FROM  tesPlanifica "
            strSQL &= "      WHERE tesPlanifica.PlanAddConceptoId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tesTransaccion(PlanAddAplicacionId)
         If TableFind(oDataTable, "tesTransaccion") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddAplicacionId "
            strSQL &= "      FROM  tesTransaccion "
            strSQL &= "      WHERE tesTransaccion.PlanAddAplicacionId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tesTransaccionDet(PlanAddConceptoId)
         If TableFind(oDataTable, "tesTransaccionDet") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddConceptoId "
            strSQL &= "      FROM  tesTransaccionDet "
            strSQL &= "      WHERE tesTransaccionDet.PlanAddConceptoId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tesTransPlanifica(PlanAddConceptoId)
         If TableFind(oDataTable, "tesTransPlanifica") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddConceptoId "
            strSQL &= "      FROM  tesTransPlanifica "
            strSQL &= "      WHERE tesTransPlanifica.PlanAddConceptoId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tesTraspasoPlanAdd(PlanAddId)
         If TableFind(oDataTable, "tesTraspasoPlanAdd") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  tesTraspasoPlanAdd "
            strSQL &= "      WHERE tesTraspasoPlanAdd.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tranCliente(PlanAddIdAct)
         ''tranCliente(PlanAddIdDev)
         ''tranCliente(PlanAddIdInt)
         ''tranCliente(PlanAddIdPas)
         If TableFind(oDataTable, "tranCliente") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdAct "
            strSQL &= "      FROM  tranCliente "
            strSQL &= "      WHERE tranCliente.PlanAddIdAct = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdDev "
            strSQL &= "      FROM  tranCliente "
            strSQL &= "      WHERE tranCliente.PlanAddIdDev = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdInt "
            strSQL &= "      FROM  tranCliente "
            strSQL &= "      WHERE tranCliente.PlanAddIdInt = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdPas "
            strSQL &= "      FROM  tranCliente "
            strSQL &= "      WHERE tranCliente.PlanAddIdPas = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tranConductor(PlanAddIdAct)
         ''tranConductor(PlanAddIdGast)
         If TableFind(oDataTable, "tranConductor") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdAct "
            strSQL &= "      FROM  tranConductor "
            strSQL &= "      WHERE tranConductor.PlanAddIdAct = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdGast "
            strSQL &= "      FROM  tranConductor "
            strSQL &= "      WHERE tranConductor.PlanAddIdGast = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''tranVehiculo(PlanAddIdAct)
         ''tranVehiculo(PlanAddIdGast)
         If TableFind(oDataTable, "tranVehiculo") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdAct "
            strSQL &= "      FROM  tranVehiculo "
            strSQL &= "      WHERE tranVehiculo.PlanAddIdAct = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdGast "
            strSQL &= "      FROM  tranVehiculo "
            strSQL &= "      WHERE tranVehiculo.PlanAddIdGast = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''venCliente(PlanAddIdAct)
         ''venCliente(PlanAddIdDev)
         ''venCliente(PlanAddIdInt)
         ''venCliente(PlanAddIdPas)
         If TableFind(oDataTable, "venCliente") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdAct "
            strSQL &= "      FROM  venCliente "
            strSQL &= "      WHERE venCliente.PlanAddIdAct = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdDev "
            strSQL &= "      FROM  venCliente "
            strSQL &= "      WHERE venCliente.PlanAddIdDev = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdInt "
            strSQL &= "      FROM  venCliente "
            strSQL &= "      WHERE venCliente.PlanAddIdInt = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdPas "
            strSQL &= "      FROM  venCliente "
            strSQL &= "      WHERE venCliente.PlanAddIdPas = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''venCobrador(PlanAddId)
         ''venCobrador(PlanAddSoId)
         If TableFind(oDataTable, "venCobrador") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  venCobrador "
            strSQL &= "      WHERE venCobrador.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddSoId "
            strSQL &= "      FROM  venCobrador "
            strSQL &= "      WHERE venCobrador.PlanAddSoId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''venVendedor(PlanAddId)
         If TableFind(oDataTable, "venVendedor") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddId "
            strSQL &= "      FROM  venVendedor "
            strSQL &= "      WHERE venVendedor.PlanAddId = " & NumberToField(mlngPlanAddId) & ")"
         End If

         ''venVentaDet(PlanAddIdCos)
         ''venVentaDet(PlanAddIdIng)
         If TableFind(oDataTable, "venVentaDet") Then
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdCos "
            strSQL &= "      FROM  venVentaDet "
            strSQL &= "      WHERE venVentaDet.PlanAddIdCos = " & NumberToField(mlngPlanAddId) & ")"
            strSQL &= " OR tblPlanAdd.PlanAddId IN "
            strSQL &= "     (SELECT DISTINCT PlanAddIdIng "
            strSQL &= "      FROM  venVentaDet "
            strSQL &= "      WHERE venVentaDet.PlanAddIdIng = " & NumberToField(mlngPlanAddId) & ")"
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
