Imports System.Data
Imports System.Data.OleDb

Public Class clsDosificaDet
   Implements IDisposable

   Public VMOld As clsDosificaDetVM
   Public VMNew As clsDosificaDetVM

   Private mlngDosificaDetId As Long
   Private mlngEmpresaId As Long
   Private mlngDosificaId As Long
   Private mlngOrden As Long
   Private mlngTipoActEcoId As Long
   Private mbytImpTipoActEco As Byte
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
   Property DosificaDetId() As Long
      Get
         Return mlngDosificaDetId
      End Get

      Set(ByVal Value As Long)
         mlngDosificaDetId = Value
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

   Property DosificaId() As Long
      Get
         Return mlngDosificaId
      End Get

      Set(ByVal Value As Long)
         mlngDosificaId = Value
      End Set
   End Property

   Property Orden() As Long
      Get
         Return mlngOrden
      End Get

      Set(ByVal Value As Long)
         mlngOrden = Value
      End Set
   End Property

   Property TipoActEcoId() As Long
      Get
         Return mlngTipoActEcoId
      End Get

      Set(ByVal Value As Long)
         mlngTipoActEcoId = Value
      End Set
   End Property

   Property ImpTipoActEco() As Byte
      Get
         Return mbytImpTipoActEco
      End Get

      Set(ByVal Value As Byte)
         mbytImpTipoActEco = Value
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
      Grid = 3
      EstadoId = 4
      DosificaId = 5
      TipoActEcoId = 6
      ExisteActividad = 7
      GridVisible = 8
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      DosificaDetId = 1
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
      mstrTableName = "tblDosificaDet"
      mstrClassName = "clsDosificaDet"

      moConnection = New OleDbConnection
      VMNew = New clsDosificaDetVM

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
      mlngDosificaDetId = 0
      mlngEmpresaId = 0
      mlngDosificaId = 0
      mlngOrden = 0
      mlngTipoActEcoId = 0
      mbytImpTipoActEco = 0
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
            strSQL &= "    tblDosificaDet.DosificaDetId,  "
            strSQL &= "    tblDosificaDet.EmpresaId,  "
            strSQL &= "    tblDosificaDet.DosificaId,  "
            strSQL &= "    tblDosificaDet.Orden,  "
            strSQL &= "    tblDosificaDet.TipoActEcoId,  "
            strSQL &= "    tblDosificaDet.ImpTipoActEco,  "
            strSQL &= "    tblDosificaDet.EstadoId,  "
            strSQL &= "    tblDosificaDet.sLastUpdate_id,  "
            strSQL &= "    tblDosificaDet.dtLastUpdate_dt,  "
            strSQL &= "    tblDosificaDet.iConcurrency_id  "
            strSQL &= " FROM tblDosificaDet "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblDosificaDet.DosificaDetId  "
            strSQL &= " FROM tblDosificaDet "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblDosificaDet.DosificaDetId,  "
            strSQL &= "    tblDosificaDet.EmpresaId,  "
            strSQL &= "    tblDosificaDet.DosificaId,  "
            strSQL &= "    tblDosificaDet.Orden,  "
            strSQL &= "    tblTipoActEco.TipoActEcoId,  "
            strSQL &= "    tblTipoActEco.TipoActEcoDes,  "
            strSQL &= "    tblDosificaDet.ImpTipoActEco,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes   "
            strSQL &= " FROM tblDosificaDet, tblTipoActEco, tblEstado "

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
            strSQL = " WHERE  tblDosificaDet.DosificaDetId = " & NumberToField(mlngDosificaDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblDosificaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosificaDet.DosificaId = " & NumberToField(mlngDosificaId)
            strSQL &= " AND  tblDosificaDet.TipoActEcoId = tblTipoActEco.TipoActEcoId "
            strSQL &= " AND  tblDosificaDet.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EstadoId
            strSQL = " WHERE  tblDosificaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosificaDet.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.DosificaId
            strSQL = " WHERE  tblDosificaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosificaDet.DosificaId = " & NumberToField(mlngDosificaId)

         Case WhereFilters.TipoActEcoId
            strSQL = " WHERE  tblDosificaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosificaDet.TipoActEcoId = " & NumberToField(mlngTipoActEcoId)

         Case WhereFilters.ExisteActividad
            strSQL = " WHERE  tblDosificaDet.EmpresaId = " & NumberToField(mlngEmpresaId)

            If mstrLastUpdateDate <> String.Empty Then
               strSQL &= " AND tblDosificaDet.TipoActEcoId IN " & mstrLastUpdateDate & " "
               strSQL &= " AND tblDosifica.DosificaId NOT IN (SELECT Det.DosificaId FROM tblDosificaDet Det WHERE Det.TipoActEcoId NOT IN " & mstrLastUpdateDate & " )"
               strSQL &= " AND (SELECT COUNT(*) FROM tblDosificaDet det where det.DosificaId = tblDosificaDet.DosificaId ) = " & NumberToField(mlngDosificaDetId) & " "
            End If
            If mlngDosificaId <> 0 Then
               strSQL &= " AND  tblDosificaDet.DosificaId <> " & NumberToField(mlngDosificaId)
            End If

         Case WhereFilters.GridVisible
            strSQL = " WHERE  tblDosificaDet.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosificaDet.DosificaId = " & NumberToField(mlngDosificaId)
            strSQL &= " AND  tblDosificaDet.TipoActEcoId = tblTipoActEco.TipoActEcoId "
            strSQL &= " AND  tblDosificaDet.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblDosificaDet.ImpTipoActEco = 1 "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.DosificaDetId
            strSQL = " ORDER BY tblDosificaDet.DosificaDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblDosificaDet.Orden "

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
            strSQL = "INSERT INTO tblDosificaDet ("
            strSQL &= "DosificaDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "DosificaId, "
            strSQL &= "Orden, "
            strSQL &= "TipoActEcoId, "
            strSQL &= "ImpTipoActEco, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngDosificaDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngDosificaId) & ", "
            strSQL &= NumberToField(mlngOrden) & ", "
            strSQL &= NumberToField(mlngTipoActEcoId) & ", "
            strSQL &= NumberToField(mbytImpTipoActEco) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblDosificaDet SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "DosificaId = " & NumberToField(mlngDosificaId) & ", "
            strSQL &= "Orden = " & NumberToField(mlngOrden) & ", "
            strSQL &= "TipoActEcoId = " & NumberToField(mlngTipoActEcoId) & ", "
            strSQL &= "ImpTipoActEco = " & NumberToField(mbytImpTipoActEco) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " DosificaDetId = " & NumberToField(mlngDosificaDetId) & " "

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
               mlngDosificaDetId = ToLong(oDataRow("DosificaDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngDosificaId = ToLong(oDataRow("DosificaId"))
               mlngOrden = ToLong(oDataRow("Orden"))
               mlngTipoActEcoId = ToLong(oDataRow("TipoActEcoId"))
               mbytImpTipoActEco = ToByte(oDataRow("ImpTipoActEco"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngDosificaDetId = ToLong(oDataRow("DosificaDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngDosificaDetId = TableIDGet(mstrTableName, "DosificaDetId", moConnection)

         If mlngDosificaDetId = -1 Then
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

      If mlngOrden = 0 Then
         strMsg &= "Seleccione el Orden" & vbCrLf
      End If

      If mlngTipoActEcoId = 0 Then
         strMsg &= "Seleccione la Actividad" & vbCrLf
      End If

      'If mlngEstadoId = 0 Then
      '   strMsg &= "Seleccione el Estado" & vbCrLf
      'End If

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
         strSQL &= " FROM tblDosificaDet "

         If Not boolReplace Then
            strSQL &= " WHERE  tblDosificaDet.DosificaId = " & NumberToField(mlngDosificaId)
            strSQL &= " AND  tblDosificaDet.TipoActEcoId = " & NumberToField(mlngTipoActEcoId)
         Else
            strSQL &= " WHERE  tblDosificaDet.DosificaId = " & NumberToField(mlngDosificaId)
            strSQL &= " AND  tblDosificaDet.TipoActEcoId = " & NumberToField(mlngTipoActEcoId)
            strSQL &= " AND  tblDosificaDet.DosificaDetId <> " & NumberToField(mlngDosificaDetId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngDosificaDetId)
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
