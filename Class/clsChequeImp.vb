Imports System.Data
Imports System.Data.OleDb

Public Class clsChequeImp
   Implements IDisposable

   Public VMOld As New clsChequeImpVM
   Public VMNew As New clsChequeImpVM

   Private mlngChequeImpId As Long
   Private mlngEmpresaId As Long
   Private mlngChequeId As Long
   Private mstrCtrlName As String
   Private mlngCtrlLeft As Long
   Private mlngCtrlTop As Long
   Private mlngCtrlWidth As Long
   Private mlngCtrlHeight As Long
   Private mbytCtrlVisible As Byte
   Private mlngCtrlMaxLength As Long
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
   Property ChequeImpId() As Long
      Get
         Return mlngChequeImpId
      End Get

      Set(ByVal Value As Long)
         mlngChequeImpId = Value
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

   Property CtrlName() As String
      Get
         Return mstrCtrlName
      End Get

      Set(ByVal Value As String)
         mstrCtrlName = Value
      End Set
   End Property

   Property CtrlLeft() As Long
      Get
         Return mlngCtrlLeft
      End Get

      Set(ByVal Value As Long)
         mlngCtrlLeft = Value
      End Set
   End Property

   Property CtrlTop() As Long
      Get
         Return mlngCtrlTop
      End Get

      Set(ByVal Value As Long)
         mlngCtrlTop = Value
      End Set
   End Property

   Property CtrlWidth() As Long
      Get
         Return mlngCtrlWidth
      End Get

      Set(ByVal Value As Long)
         mlngCtrlWidth = Value
      End Set
   End Property

   Property CtrlHeight() As Long
      Get
         Return mlngCtrlHeight
      End Get

      Set(ByVal Value As Long)
         mlngCtrlHeight = Value
      End Set
   End Property

   Property CtrlVisible() As Byte
      Get
         Return mbytCtrlVisible
      End Get

      Set(ByVal Value As Byte)
         mbytCtrlVisible = Value
      End Set
   End Property

   Property CtrlMaxLength() As Long
      Get
         Return mlngCtrlMaxLength
      End Get

      Set(ByVal Value As Long)
         mlngCtrlMaxLength = Value
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
      ChequeId = 3
      CtrlName = 4
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ChequeImpId = 1
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
      mstrTableName = "tblChequeImp"
      mstrClassName = "clsChequeImp"

      moConnection = New OleDbConnection
      VMNew = New clsChequeImpVM

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
      mlngChequeImpId = 0
      mlngEmpresaId = 0
      mlngChequeId = 0
      mstrCtrlName = ""
      mlngCtrlLeft = 0
      mlngCtrlTop = 0
      mlngCtrlWidth = 0
      mlngCtrlHeight = 0
      mbytCtrlVisible = 0
      mlngCtrlMaxLength = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblChequeImp.ChequeImpId,  "
            strSQL &= "    tblChequeImp.EmpresaId,  "
            strSQL &= "    tblChequeImp.ChequeId,  "
            strSQL &= "    tblChequeImp.CtrlName,  "
            strSQL &= "    tblChequeImp.CtrlLeft,  "
            strSQL &= "    tblChequeImp.CtrlTop,  "
            strSQL &= "    tblChequeImp.CtrlWidth,  "
            strSQL &= "    tblChequeImp.CtrlHeight,  "
            strSQL &= "    tblChequeImp.CtrlVisible,  "
            strSQL &= "    tblChequeImp.CtrlMaxLength,  "
            strSQL &= "    tblChequeImp.sLastUpdate_id,  "
            strSQL &= "    tblChequeImp.dtLastUpdate_dt,  "
            strSQL &= "    tblChequeImp.iConcurrency_id  "
            strSQL &= " FROM tblChequeImp "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblChequeImp.ChequeImpId  "
            strSQL &= " FROM tblChequeImp "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblChequeImp.ChequeImpId,  "
            strSQL &= "    tblChequeImp.EmpresaId,  "
            strSQL &= "    tblChequeImp.ChequeId,  "
            strSQL &= "    tblChequeImp.CtrlName,  "
            strSQL &= "    tblChequeImp.CtrlLeft,  "
            strSQL &= "    tblChequeImp.CtrlTop,  "
            strSQL &= "    tblChequeImp.CtrlWidth,  "
            strSQL &= "    tblChequeImp.CtrlHeight,  "
            strSQL &= "    tblChequeImp.CtrlVisible,  "
            strSQL &= "    tblChequeImp.CtrlMaxLength  "
            strSQL &= " FROM tblChequeImp "

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
            strSQL = " WHERE  tblChequeImp.ChequeImpId = " & NumberToField(mlngChequeImpId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblChequeImp.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.ChequeId
            strSQL = " WHERE  tblChequeImp.ChequeId = " & NumberToField(mlngChequeId)

         Case WhereFilters.CtrlName
            strSQL = " WHERE  tblChequeImp.ChequeId = " & NumberToField(mlngChequeId)
            strSQL &= " AND  tblChequeImp.CtrlName = " & StringToField(mstrCtrlName)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ChequeImpId
            strSQL = " ORDER BY tblChequeImp.ChequeImpId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblBanco.BancoDes "

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
            strSQL = "INSERT INTO tblChequeImp ("
            strSQL &= "ChequeImpId, "
            strSQL &= "EmpresaId, "
            strSQL &= "ChequeId, "
            strSQL &= "CtrlName, "
            strSQL &= "CtrlLeft, "
            strSQL &= "CtrlTop, "
            strSQL &= "CtrlWidth, "
            strSQL &= "CtrlHeight, "
            strSQL &= "CtrlVisible, "
            strSQL &= "CtrlMaxLength, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngChequeImpId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngChequeId) & ", "
            strSQL &= StringToField(mstrCtrlName) & ", "
            strSQL &= NumberToField(mlngCtrlLeft) & ", "
            strSQL &= NumberToField(mlngCtrlTop) & ", "
            strSQL &= NumberToField(mlngCtrlWidth) & ", "
            strSQL &= NumberToField(mlngCtrlHeight) & ", "
            strSQL &= NumberToField(mbytCtrlVisible) & ", "
            strSQL &= NumberToField(mlngCtrlMaxLength) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblChequeImp SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "ChequeId = " & NumberToField(mlngChequeId) & ", "
            strSQL &= "CtrlName = " & StringToField(mstrCtrlName) & ", "
            strSQL &= "CtrlLeft = " & NumberToField(mlngCtrlLeft) & ", "
            strSQL &= "CtrlTop = " & NumberToField(mlngCtrlTop) & ", "
            strSQL &= "CtrlWidth = " & NumberToField(mlngCtrlWidth) & ", "
            strSQL &= "CtrlHeight = " & NumberToField(mlngCtrlHeight) & ", "
            strSQL &= "CtrlVisible = " & NumberToField(mbytCtrlVisible) & ", "
            strSQL &= "CtrlMaxLength = " & NumberToField(mlngCtrlMaxLength) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ChequeImpId = " & NumberToField(mlngChequeImpId) & " "

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
               mlngChequeImpId = ToLong(oDataRow("ChequeImpId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngChequeId = ToLong(oDataRow("ChequeId"))
               mstrCtrlName = ToStr(oDataRow("CtrlName"))
               mlngCtrlLeft = ToLong(oDataRow("CtrlLeft"))
               mlngCtrlTop = ToLong(oDataRow("CtrlTop"))
               mlngCtrlWidth = ToLong(oDataRow("CtrlWidth"))
               mlngCtrlHeight = ToLong(oDataRow("CtrlHeight"))
               mbytCtrlVisible = ToByte(oDataRow("CtrlVisible"))
               mlngCtrlMaxLength = ToLong(oDataRow("CtrlMaxLength"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngChequeImpId = ToLong(oDataRow("ChequeImpId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngChequeImpId = TableIDGet(mstrTableName, "ChequeImpId", moConnection)

         If mlngChequeImpId = -1 Then
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

      If mlngChequeId = 0 Then
         strMsg &= "Seleccione la Chequera" & vbCrLf
      End If

      If mstrCtrlName.Trim() = String.Empty Then
         strMsg &= "Ingrese el Nombre del Control" & vbCrLf
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
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM tblChequeImp "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblChequeImp.EmpresaId = " & NumberToField(mlngEmpresaId)
         'Else
         '   strSQL &= " WHERE  tblChequeImp.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblChequeImp.ChequeImpId <> " & NumberToField(mlngChequeImpId)
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
                     Insert = True
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngChequeImpId)
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
                  Update = True
                  VMNew.ToChangeOpeUpdate(VMOld, clsTipoOpera.MODIFICA)
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
            Delete = True
            VMNew.ToDeleteOpe()
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
