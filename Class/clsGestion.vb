Imports System.Data
Imports System.Data.OleDb

Public Class clsGestion
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsGestionVM
   Public VMNew As New clsGestionVM

   Private mlngGestionId As Long
   Private mlngEmpresaId As Long
   Private mlngGestion As Long
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property GestionId() As Long
      Get
         Return mlngGestionId
      End Get

      Set(ByVal Value As Long)
         mlngGestionId = Value
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

   Property Gestion() As Long
      Get
         Return mlngGestion
      End Get

      Set(ByVal Value As Long)
         mlngGestion = Value
      End Set
   End Property

   Property FechaIni() As String
      Get
         Return mstrFechaIni
      End Get

      Set(ByVal Value As String)
         mstrFechaIni = Value
      End Set
   End Property

   Property FechaFin() As String
      Get
         Return mstrFechaFin
      End Get

      Set(ByVal Value As String)
         mstrFechaFin = Value
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
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      FechaIni = 2
      LIKEFechaIni = 3
      Grid = 4
      FechaIntervalo = 5
      Gestion = 6
      EmpresaId = 7
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      GestionId = 1
      FechaIni = 2
      Grid = 3
      Gestion = 4
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
      mstrTableName = "tblGestion"
      mstrClassName = "clsGestion"

      moConnection = New OleDbConnection
      VMNew = New clsGestionVM

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
      mlngGestionId = 0
      mlngEmpresaId = 0
      mlngGestion = 0
      mstrFechaIni = ""
      mstrFechaFin = ""
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
            strSQL &= "    tblGestion.GestionId,  "
            strSQL &= "    tblGestion.EmpresaId,  "
            strSQL &= "    tblGestion.Gestion,  "
            strSQL &= "    tblGestion.FechaIni,  "
            strSQL &= "    tblGestion.FechaFin,  "
            strSQL &= "    tblGestion.EstadoId,  "
            strSQL &= "    tblGestion.sLastUpdate_id,  "
            strSQL &= "    tblGestion.dtLastUpdate_dt,  "
            strSQL &= "    tblGestion.iConcurrency_id  "
            strSQL &= " FROM tblGestion "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblGestion.GestionId,  "
            strSQL &= "    tblGestion.Gestion  "
            strSQL &= " FROM tblGestion "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblGestion.GestionId,  "
            strSQL &= "    tblGestion.EmpresaId,  "
            strSQL &= "    tblGestion.Gestion,  "
            strSQL &= "    tblGestion.FechaIni,  "
            strSQL &= "    tblGestion.FechaFin,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblGestion, tblEstado "

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
            strSQL = " WHERE  tblGestion.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.FechaIni
            strSQL = " WHERE  tblGestion.FechaIni = " & StringToField(mstrFechaIni)

         Case WhereFilters.LIKEFechaIni
            strSQL = " WHERE  tblGestion.FechaIni LIKE " & StringToField(mstrFechaIni & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblGestion.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblGestion.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.FechaIntervalo
            strSQL = " WHERE  tblGestion.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblGestion.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblGestion.FechaIni <= " & DateToField(mstrFechaIni)
            strSQL &= " AND  tblGestion.FechaFin >= " & DateToField(mstrFechaIni)

         Case WhereFilters.Gestion
            strSQL = " WHERE  tblGestion.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblGestion.Gestion = " & NumberToField(mlngGestion)
            strSQL &= " AND  tblGestion.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblGestion.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngEstadoId <> 0 Then
               strSQL &= " AND  tblGestion.EstadoId = " & NumberToField(mlngEstadoId)
            End If

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.GestionId
            strSQL = " ORDER BY tblGestion.GestionId "

         Case OrderByFilters.FechaIni
            strSQL = " ORDER BY tblGestion.FechaIni "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblGestion.Gestion "

         Case OrderByFilters.Gestion
            strSQL = " ORDER BY tblGestion.Gestion "

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
            strSQL = "INSERT INTO tblGestion ("
            strSQL &= "GestionId, "
            strSQL &= "EmpresaId, "
            strSQL &= "Gestion, "
            strSQL &= "FechaIni, "
            strSQL &= "FechaFin, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestion) & ", "
            strSQL &= DateToField(mstrFechaIni) & ", "
            strSQL &= DateToField(mstrFechaFin) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblGestion SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "Gestion = " & NumberToField(mlngGestion) & ", "
            strSQL &= "FechaIni = " & DateToField(mstrFechaIni) & ", "
            strSQL &= "FechaFin = " & DateToField(mstrFechaFin) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " GestionId = " & NumberToField(mlngGestionId) & " "

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
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestion = ToLong(oDataRow("Gestion"))
               mstrFechaIni = ToDateDMY(oDataRow("FechaIni"))
               mstrFechaFin = ToDateDMY(oDataRow("FechaFin"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngGestion = ToLong(oDataRow("Gestion"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngGestionId = TableIDGet(mstrTableName, "GestionId", moConnection)

         If mlngGestionId = -1 Then
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

      If mlngGestion = 0 Then
         strMsg &= "Ingrese la Gestión" & vbCrLf
      End If

      If mlngGestion.ToString.Length <> 4 Then
         strMsg &= "Ingrese los cuatro dígitos la Gestión" & vbCrLf
      End If

      If mstrFechaIni.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFechaIni)) Then
            strMsg &= "La Fecha de apertura no es válida" & vbCrLf
         End If
      Else
         strMsg &= "La fecha de apertura no puede ser nula" & vbCrLf
      End If

      If mstrFechaFin.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFechaFin)) Then
            strMsg &= "La Fecha de cierre no es válida" & vbCrLf
         End If
      Else
         strMsg &= "La fecha de cierre no puede ser nula" & vbCrLf
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
         strSQL &= " FROM tblGestion "

         If Not boolReplace Then
            strSQL &= " WHERE  tblGestion.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblGestion.Gestion = " & NumberToField(mlngGestion)
            strSQL &= " AND  tblGestion.EstadoId = " & NumberToField(mlngEstadoId)
         Else
            strSQL &= " WHERE  tblGestion.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblGestion.Gestion = " & NumberToField(mlngGestion)
            strSQL &= " AND  tblGestion.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblGestion.GestionId <> " & NumberToField(mlngGestionId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngGestionId)
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
      Return True
   End Function
End Class
