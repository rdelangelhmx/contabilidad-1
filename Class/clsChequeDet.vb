Imports System.Data
Imports System.Data.OleDb

Public Class clsChequeDet
   Implements IDisposable

   Public VMOld As clsChequeDetVM
   Public VMNew As clsChequeDetVM

   Private mlngChequeDetId As Long
   Private mlngEmpresaId As Long
   Private mlngChequeId As Long
   Private mlngPlanId As Long
   Private mlngBancoId As Long
   Private mlngChequeDetNro As Long
   Private mstrFecha As String
   Private mlngChequeIni As Long
   Private mlngChequeFin As Long
   Private mlngChequeActual As Long
   Private mstrChequeDetDes As String
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
   Property ChequeDetId() As Long
      Get
         Return mlngChequeDetId
      End Get

      Set(ByVal Value As Long)
         mlngChequeDetId = Value
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

   Property ChequeId() As Long
      Get
         Return mlngChequeId
      End Get

      Set(ByVal Value As Long)
         mlngChequeId = Value
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

   Property ChequeDetNro() As Long
      Get
         Return mlngChequeDetNro
      End Get

      Set(ByVal Value As Long)
         mlngChequeDetNro = Value
      End Set
   End Property

   Property Fecha() As String
      Get
         Return mstrFecha
      End Get

      Set(ByVal Value As String)
         mstrFecha = Value
      End Set
   End Property

   Property ChequeIni() As Long
      Get
         Return mlngChequeIni
      End Get

      Set(ByVal Value As Long)
         mlngChequeIni = Value
      End Set
   End Property

   Property ChequeFin() As Long
      Get
         Return mlngChequeFin
      End Get

      Set(ByVal Value As Long)
         mlngChequeFin = Value
      End Set
   End Property

   Property ChequeActual() As Long
      Get
         Return mlngChequeActual
      End Get

      Set(ByVal Value As Long)
         mlngChequeActual = Value
      End Set
   End Property

   Property ChequeDetDes() As String
      Get
         Return mstrChequeDetDes
      End Get

      Set(ByVal Value As String)
         mstrChequeDetDes = Value
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
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 2
      PlanId = 3
      ChequeId = 4

   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ChequeDetId = 1
      Grid = 2
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      ChequeActual = 1
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
   '* SIt can be used to initialize private data variables.
   '*
   '************************************************************
   Public Sub New()
      mstrTableName = "tblChequeDet"
      mstrClassName = "clsChequeDet"

      moConnection = New OleDbConnection
      VMNew = New clsChequeDetVM

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
      mlngChequeDetId = 0
      mlngEmpresaId = 0
      mlngChequeId = 0
      mlngPlanId = 0
      mlngBancoId = 0
      mlngChequeDetNro = 0
      mstrFecha = ""
      mlngChequeIni = 0
      mlngChequeFin = 0
      mlngChequeActual = 0
      mstrChequeDetDes = 0
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
            strSQL &= "    tblChequeDet.ChequeDetId,  "
            strSQL &= "    tblChequeDet.EmpresaId,  "
            strSQL &= "    tblChequeDet.ChequeId,  "
            strSQL &= "    tblChequeDet.PlanId,  "
            strSQL &= "    tblChequeDet.BancoId,  "
            strSQL &= "    tblChequeDet.ChequeDetNro,  "
            strSQL &= "    tblChequeDet.Fecha,  "
            strSQL &= "    tblChequeDet.ChequeIni,  "
            strSQL &= "    tblChequeDet.ChequeFin,  "
            strSQL &= "    tblChequeDet.ChequeActual,  "
            strSQL &= "    tblChequeDet.ChequeDetDes,  "
            strSQL &= "    tblChequeDet.EstadoId,  "
            strSQL &= "    tblChequeDet.sLastUpdate_id,  "
            strSQL &= "    tblChequeDet.dtLastUpdate_dt,  "
            strSQL &= "    tblChequeDet.iConcurrency_id  "
            strSQL &= " FROM tblChequeDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblChequeDet.ChequeDetId  "
            strSQL &= " FROM tblChequeDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblChequeDet.ChequeDetId,  "
            strSQL &= "    tblChequeDet.EmpresaId,  "
            strSQL &= "    tblChequeDet.ChequeId,  "
            strSQL &= "    tblChequeDet.ChequeDetNro,  "
            strSQL &= "    tblChequeDet.Fecha,  "
            strSQL &= "    tblChequeDet.ChequeIni,  "
            strSQL &= "    tblChequeDet.ChequeFin,  "
            strSQL &= "    tblChequeDet.ChequeActual,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblChequeDet, tblEstado "

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
            strSQL = " WHERE  tblChequeDet.ChequeDetId = " & NumberToField(mlngChequeDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblChequeDet.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND  tblChequeDet.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.PlanId
            strSQL = " WHERE  tblChequeDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblChequeDet.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblChequeDet.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.ChequeId
            strSQL = " WHERE  tblChequeDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblChequeDet.ChequeId = " & NumberToField(mlngChequeId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ChequeDetId
            strSQL = " ORDER BY tblChequeDet.ChequeDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblChequeDet.ChequeDetId "

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
            strSQL = "INSERT INTO tblChequeDet ("
            strSQL &= "ChequeDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "ChequeId, "
            strSQL &= "PlanId, "
            strSQL &= "BancoId, "
            strSQL &= "ChequeDetNro, "
            strSQL &= "Fecha, "
            strSQL &= "ChequeIni, "
            strSQL &= "ChequeFin, "
            strSQL &= "ChequeActual, "
            strSQL &= "ChequeDetDes, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngChequeDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngChequeId) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngBancoId) & ", "
            strSQL &= NumberToField(mlngChequeDetNro) & ", "
            strSQL &= StringToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngChequeIni) & ", "
            strSQL &= NumberToField(mlngChequeFin) & ", "
            strSQL &= NumberToField(mlngChequeActual) & ", "
            strSQL &= StringToField(ChequeDetDes) & ", "
            strSQL &= NumberToField(EstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblChequeDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "ChequeId = " & NumberToField(mlngChequeId) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "BancoId = " & NumberToField(mlngBancoId) & ", "
            strSQL &= "ChequeDetNro = " & NumberToField(mlngChequeDetNro) & ", "
            strSQL &= "Fecha = " & StringToField(mstrFecha) & ", "
            strSQL &= "ChequeIni = " & NumberToField(mlngChequeIni) & ", "
            strSQL &= "ChequeFin = " & NumberToField(mlngChequeFin) & ", "
            strSQL &= "ChequeActual = " & NumberToField(mlngChequeActual) & ", "
            strSQL &= "ChequeDetDes = " & StringToField(mstrChequeDetDes) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ChequeDetId = " & NumberToField(mlngChequeDetId) & " "

         Case UpdateFilters.ChequeActual
            strSQL = "UPDATE tblChequeDet SET "
            strSQL &= "ChequeActual = " & NumberToField(mlngChequeActual) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ChequeDetId = " & NumberToField(mlngChequeDetId) & " "

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
               mlngChequeDetId = ToLong(oDataRow("ChequeDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngChequeId = ToLong(oDataRow("ChequeId"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngBancoId = ToLong(oDataRow("BancoId"))
               mlngChequeDetNro = ToLong(oDataRow("ChequeDetNro"))
               mstrFecha = ToStr(oDataRow("Fecha"))
               mlngChequeIni = ToLong(oDataRow("ChequeIni"))
               mlngChequeFin = ToLong(oDataRow("ChequeFin"))
               mlngChequeActual = ToLong(oDataRow("ChequeActual"))
               mstrChequeDetDes = ToStr(oDataRow("ChequeDetDes"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngChequeDetId = ToLong(oDataRow("ChequeDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngChequeDetId = TableIDGet(mstrTableName, "ChequeDetId", moConnection)

         If mlngChequeDetId = -1 Then
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

      If mlngChequeId = 0 Then
         strMsg &= "Sucursal Inválida" & vbCrLf
      End If

      If mstrFecha.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha Inicial no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha Inicial no puede ser nula" & vbCrLf
      End If

      If mlngChequeDetNro = 0 Then
         strMsg &= "Nro Invàlido" & vbCrLf
      End If

      If mlngChequeIni <= 0 Then
         strMsg &= "Número Inicial Inválido" & vbCrLf
      End If

      If mlngChequeFin <= 0 Then
         strMsg &= "Número Final Inválido" & vbCrLf
      End If

      If mlngEstadoId = 0 Then
         strMsg &= "Seleccione el Estado" & vbCrLf
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
         strSQL = " SELECT  "
         strSQL &= " Count(*) As NumRecs  "
         strSQL &= " FROM tblChequeDet "

         If Not boolReplace Then
            strSQL &= " WHERE  tblChequeDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblChequeDet.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND ( tblChequeDet.ChequeDetNro = " & NumberToField(mlngChequeDetNro)
            strSQL &= " OR  (tblChequeDet.ChequeIni <= " & NumberToField(mlngChequeIni)
            strSQL &= "  AND  tblChequeDet.ChequeFin >= " & NumberToField(mlngChequeIni) & " )"
            strSQL &= " OR  (tblChequeDet.ChequeIni <= " & NumberToField(mlngChequeFin)
            strSQL &= "  AND  tblChequeDet.ChequeFin >= " & NumberToField(mlngChequeFin) & " ) )"
         Else
            strSQL &= " WHERE  tblChequeDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblChequeDet.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND ( tblChequeDet.ChequeDetNro = " & NumberToField(mlngChequeDetNro)
            strSQL &= " OR  (tblChequeDet.ChequeIni <= " & NumberToField(mlngChequeIni)
            strSQL &= "  AND  tblChequeDet.ChequeFin >= " & NumberToField(mlngChequeIni) & " )"
            strSQL &= " OR  (tblChequeDet.ChequeIni <= " & NumberToField(mlngChequeFin)
            strSQL &= "  AND  tblChequeDet.ChequeFin >= " & NumberToField(mlngChequeFin) & " ) )"
            strSQL &= " AND  tblChequeDet.ChequeDetId <> " & NumberToField(mlngChequeDetId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngChequeDetId)
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
            VMNew.ToDeleteOpe()
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
