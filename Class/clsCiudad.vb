Imports System.Data
Imports System.Data.OleDb

Public Class clsCiudad
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsCiudadVM
   Public VMNew As clsCiudadVM

   Private mlngCiudadId As Long
   Private mstrCiudadCod As String
   Private mstrCiudadDes As String
   Private mlngPaisId As Long
   Private mlngDepartamentoId As Long
   Private mlngProvinciaId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CiudadId() As Long
      Get
         Return mlngCiudadId
      End Get

      Set(ByVal Value As Long)
         mlngCiudadId = Value
      End Set
   End Property

   Property CiudadCod() As String
      Get
         Return mstrCiudadCod
      End Get

      Set(ByVal Value As String)
         mstrCiudadCod = Value
      End Set
   End Property

   Property CiudadDes() As String
      Get
         Return mstrCiudadDes
      End Get

      Set(ByVal Value As String)
         mstrCiudadDes = Value
      End Set
   End Property

   Property PaisId() As Long
      Get
         Return mlngPaisId
      End Get

      Set(ByVal Value As Long)
         mlngPaisId = Value
      End Set
   End Property

   Property DepartamentoId() As Long
      Get
         Return mlngDepartamentoId
      End Get

      Set(ByVal Value As Long)
         mlngDepartamentoId = Value
      End Set
   End Property

   Public Property ProvinciaId() As Long
      Get
         Return mlngProvinciaId
      End Get
      Set(ByVal value As Long)
         mlngProvinciaId = value
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
      CiudadDes = 2
      LIKECiudadDes = 3
      Grid = 4
      DepartamentoId = 5
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CiudadId = 1
      CiudadDes = 2
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
      mstrTableName = "tblCiudad"
      mstrClassName = "clsCiudad"

      moConnection = New OleDbConnection
      VMNew = New clsCiudadVM

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
      mlngCiudadId = 0
      mstrCiudadCod = ""
      mstrCiudadDes = ""
      mlngPaisId = 0
      mlngDepartamentoId = 0
      mlngProvinciaId = 0
      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadCod,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    tblCiudad.PaisId,  "
            strSQL &= "    tblCiudad.DepartamentoId,  "
            strSQL &= "    tblCiudad.ProvinciaId,  "
            strSQL &= "    tblCiudad.sLastUpdate_id,  "
            strSQL &= "    tblCiudad.dtLastUpdate_dt,  "
            strSQL &= "    tblCiudad.iConcurrency_id  "
            strSQL &= " FROM tblCiudad "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadCod,  "
            strSQL &= "    tblCiudad.CiudadDes  "
            strSQL &= " FROM tblCiudad "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblPais.PaisId,  "
            strSQL &= "    tblPais.PaisDes,  "
            strSQL &= "    tblDepartamento.DepartamentoId,  "
            strSQL &= "    tblDepartamento.DepartamentoDes,  "
            strSQL &= "    tblProvincia.ProvinciaId,  "
            strSQL &= "    tblProvincia.ProvinciaDes,  "
            strSQL &= "    tblCiudad.CiudadCod,  "
            strSQL &= "    tblCiudad.CiudadDes  "
            strSQL &= " FROM tblCiudad, tblPais, tblDepartamento, tblProvincia "

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
            strSQL = " WHERE  tblCiudad.CiudadId = " & NumberToField(mlngCiudadId)

         Case WhereFilters.CiudadDes
            strSQL = " WHERE  tblCiudad.CiudadDes = " & StringToField(mstrCiudadDes)

         Case WhereFilters.LIKECiudadDes
            strSQL = " WHERE  tblCiudad.CiudadDes LIKE " & StringToField(mstrCiudadDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCiudad.PaisId = tblPais.PaisId"
            strSQL &= " AND  tblCiudad.DepartamentoId = tblDepartamento.DepartamentoId"
            strSQL &= " AND  tblCiudad.ProvinciaId = tblProvincia.ProvinciaId "
            strSQL &= " AND  tblCiudad.CiudadId > 0 "

         Case WhereFilters.DepartamentoId
            strSQL = " WHERE  tblCiudad.DepartamentoId = " & NumberToField(mlngDepartamentoId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CiudadId
            strSQL = " ORDER BY tblCiudad.CiudadId"

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblDepartamento.DepartamentoDes, tblProvincia.ProvinciaDes, tblCiudad.CiudadDes"

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
            strSQL = "INSERT INTO tblCiudad ("
            strSQL &= "CiudadId, "
            strSQL &= "CiudadCod, "
            strSQL &= "CiudadDes, "
            strSQL &= "PaisId, "
            strSQL &= "DepartamentoId, "
            strSQL &= "ProvinciaId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCiudadId) & ", "
            strSQL &= StringToField(mstrCiudadCod) & ", "
            strSQL &= StringToField(mstrCiudadDes) & ", "
            strSQL &= NumberToField(mlngPaisId) & ", "
            strSQL &= NumberToField(mlngDepartamentoId) & ", "
            strSQL &= NumberToField(mlngProvinciaId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCiudad SET "
            strSQL &= "CiudadCod = " & StringToField(mstrCiudadCod) & ", "
            strSQL &= "CiudadDes = " & StringToField(mstrCiudadDes) & ", "
            strSQL &= "PaisId = " & NumberToField(mlngPaisId) & ", "
            strSQL &= "DepartamentoId = " & NumberToField(mlngDepartamentoId) & ", "
            strSQL &= "ProvinciaId = " & NumberToField(mlngProvinciaId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CiudadId = " & NumberToField(mlngCiudadId) & " "

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
               mlngCiudadId = ToLong(oDataRow("CiudadId"))
               mstrCiudadCod = ToStr(oDataRow("CiudadCod"))
               mstrCiudadDes = ToStr(oDataRow("CiudadDes"))
               mlngPaisId = ToLong(oDataRow("PaisId"))
               mlngDepartamentoId = ToLong(oDataRow("DepartamentoId"))
               mlngProvinciaId = ToLong(oDataRow("ProvinciaId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCiudadId = ToLong(oDataRow("CiudadId"))
               mstrCiudadCod = ToStr(oDataRow("CiudadCod"))
               mstrCiudadDes = ToStr(oDataRow("CiudadDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCiudadId = TableIDGet(mstrTableName, "CiudadId", moConnection)

         If mlngCiudadId = -1 Then
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

      If mstrCiudadDes.Length() = 0 Then
         strMsg &= "Ingrese la Ciudad" & vbCrLf
      End If

      'If mstrFecha.Trim() <> String.Empty Then
      '   If Not IsDate(mstrFecha) Then
      '      strMsg &= "Fecha no es una fecha v�lida" & vbCrLf
      '   End If
      'Else
      '   strMsg &= "La Fecha no puede ser nula" & vbCrLf
      'End If

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
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM tblPlan "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)
         '   strSQL &= " AND  tblPlan.CiudadId = " & NumberToField(mlngCiudadId)
         'Else
         '   strSQL &= " WHERE  tblPlan.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblPlan.PlanCta = " & StringToField(mstrPlanCta)
         '   strSQL &= " AND  tblPlan.CiudadId = " & NumberToField(mlngCiudadId)
         '   strSQL &= " AND  tblPlan.PlanId <> " & NumberToField(mlngPlanId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngCiudadId)
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
         strSQL &= " FROM tblCiudad "
         strSQL &= " WHERE tblCiudad.CiudadId = " & NumberToField(mlngCiudadId)

         If TableFind(oDataTable, "tblEmpresa") Then
            strSQL &= " AND (tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tblEmpresa "
            strSQL &= "      WHERE tblEmpresa.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "tblSucursal") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tblSucursal "
            strSQL &= "      WHERE tblSucursal.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "tblCompCheque") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tblCompCheque "
            strSQL &= "      WHERE tblCompCheque.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "comProveedor") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  comProveedor "
            strSQL &= "      WHERE comProveedor.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "inmCliente") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  inmCliente "
            strSQL &= "      WHERE inmCliente.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "rrhEmpleado") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  rrhEmpleado "
            strSQL &= "      WHERE rrhEmpleado.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "surConductor") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  surConductor "
            strSQL &= "      WHERE surConductor.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "tesEntidad") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tesEntidad "
            strSQL &= "      WHERE tesEntidad.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "tranCliente") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tranCliente "
            strSQL &= "      WHERE tranCliente.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "tranClienteProv") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tranClienteProv "
            strSQL &= "      WHERE tranClienteProv.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "tranConductor") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tranConductor "
            strSQL &= "      WHERE tranConductor.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "tranConsignatario") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tranConsignatario "
            strSQL &= "      WHERE tranConsignatario.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "tranProveedor") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tranProveedor "
            strSQL &= "      WHERE tranProveedor.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "tranRemitente") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  tranRemitente "
            strSQL &= "      WHERE tranRemitente.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "venCliente") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  venCliente "
            strSQL &= "      WHERE venCliente.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "venEstimacion") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  venEstimacion "
            strSQL &= "      WHERE venEstimacion.CiudadId = " & NumberToField(mlngCiudadId) & ")"
         End If

         If TableFind(oDataTable, "venVendedor") Then
            strSQL &= " OR  tblCiudad.CiudadId IN "
            strSQL &= "     (SELECT DISTINCT CiudadId "
            strSQL &= "      FROM  venVendedor "
            strSQL &= "      WHERE venVendedor.CiudadId = " & NumberToField(mlngCiudadId) & ")"
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
