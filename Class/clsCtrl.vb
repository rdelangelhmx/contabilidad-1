Imports System.Data
Imports System.Data.OleDb

Public Class clsCtrl
   Inherits clsBase
   Implements IDisposable

   Private mlngCtrlId As Long
   Private mlngAppId As Long
   Private mlngFormId As Long
   Private mstrCtrlName As String
   Private mstrCtrlText As String
   Private mstrCtrlType As String
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   'Private moConnection As OleDbConnection
   'Private moDataAdapter As OleDbDataAdapter
   'Private moDataSet As DataSet
   'Private mintRow As Integer
   'Private mintRowsCount As Integer

   'Private mstrConnectionString As String
   'Private mstrTableName As String
   'Private mstrClassName As String
   'Private mstrSQL As String

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CtrlId() As Long
      Get
         Return mlngCtrlId
      End Get

      Set(ByVal Value As Long)
         mlngCtrlId = Value
      End Set
   End Property

   Property AppId() As Long
      Get
         Return mlngAppId
      End Get

      Set(ByVal Value As Long)
         mlngAppId = Value
      End Set
   End Property

   Property FormId() As Long
      Get
         Return mlngFormId
      End Get

      Set(ByVal Value As Long)
         mlngFormId = Value
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

   Property CtrlText() As String
      Get
         Return mstrCtrlText
      End Get

      Set(ByVal Value As String)
         mstrCtrlText = Value
      End Set
   End Property

   Property CtrlType() As String
      Get
         Return mstrCtrlType
      End Get

      Set(ByVal Value As String)
         mstrCtrlType = Value
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

   'Property ConnectionString() As String
   '   Get
   '      Return mstrConnectionString
   '   End Get

   '   Set(ByVal Value As String)
   '      mstrConnectionString = Value
   '   End Set
   'End Property

   'Property DataSet() As DataSet
   '   Get
   '      Return moDataSet
   '   End Get

   '   Set(ByVal Value As DataSet)
   '      moDataSet = Value
   '   End Set
   'End Property

   'ReadOnly Property TableName() As String
   '   Get
   '      Return mstrTableName
   '   End Get
   'End Property

   'ReadOnly Property ClassName() As String
   '   Get
   '      Return mstrClassName
   '   End Get
   'End Property

   'ReadOnly Property SQL() As String
   '   Get
   '      Return mstrSQL
   '   End Get
   'End Property

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
      CtrlName = 2
      LIKECtrlName = 3
      Grid = 4
      FormId = 5
      AppId = 6
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CtrlId = 1
      CtrlType = 2
      'CtrlName = 2
      Grid = 3
      CtrlText = 4
      FormId = 5
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
      mstrTableName = "secCtrl"
      mstrClassName = "clsCtrl"

      moConnection = New OleDbConnection

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
      mlngCtrlId = 0
      mlngAppId = 0
      mlngFormId = 0
      mstrCtrlType = ""
      mstrCtrlText = ""
      mstrCtrlName = ""

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    secCtrl.CtrlId,  "
            strSQL &= "    secCtrl.AppId,  "
            strSQL &= "    secCtrl.FormId,  "
            strSQL &= "    secCtrl.CtrlName,  "
            strSQL &= "    secCtrl.CtrlText,  "
            strSQL &= "    secCtrl.CtrlType,  "
            strSQL &= "    secCtrl.sLastUpdate_id,  "
            strSQL &= "    secCtrl.dtLastUpdate_dt,  "
            strSQL &= "    secCtrl.iConcurrency_id  "
            strSQL &= " FROM secCtrl "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    secCtrl.CtrlId,  "
            strSQL &= "    secCtrl.CtrlText  "
            strSQL &= " FROM secCtrl "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    secCtrl.CtrlId,  "
            strSQL &= "    secCtrl.AppId,  "
            strSQL &= "    secForm.FormId,  "
            strSQL &= "    secForm.FormName,  "
            strSQL &= "    secForm.FormText,  "
            strSQL &= "    secCtrl.CtrlName,  "
            strSQL &= "    secCtrl.CtrlText,  "
            strSQL &= "    secCtrl.CtrlType  "
            strSQL &= " FROM secCtrl, secForm "

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
            strSQL = " WHERE  secCtrl.CtrlId = " & NumberToField(mlngCtrlId)

         Case WhereFilters.CtrlName
            strSQL = " WHERE  secCtrl.CtrlName = " & StringToField(mstrCtrlName)

         Case WhereFilters.LIKECtrlName
            strSQL = " WHERE  secCtrl.CtrlName LIKE " & StringToField(mstrCtrlName & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  secCtrl.AppId = " & NumberToField(mlngAppId)
            strSQL &= " AND  secCtrl.FormId = secForm.FormId "

         Case WhereFilters.FormId
            strSQL = " WHERE  secCtrl.AppId = " & NumberToField(mlngAppId)
            strSQL &= " AND  secCtrl.FormId = " & NumberToField(mlngFormId)

         Case WhereFilters.AppId
            strSQL = " WHERE  secCtrl.AppId = " & NumberToField(mlngAppId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CtrlId
            strSQL = " ORDER BY secCtrl.CtrlId "

            'Case OrderByFilters.CtrlName
            '   strSQL = " ORDER BY secCtrl.CtrlName "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY secForm.FormText "

         Case OrderByFilters.CtrlText
            strSQL = " ORDER BY secCtrl.CtrlText "

         Case OrderByFilters.FormId
            strSQL = " ORDER BY secCtrl.FormId, secCtrl.CtrlText "

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
            strSQL = "INSERT INTO secCtrl ("
            strSQL &= "CtrlId, "
            strSQL &= "AppId, "
            strSQL &= "FormId, "
            strSQL &= "CtrlName, "
            strSQL &= "CtrlText, "
            strSQL &= "CtrlType, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCtrlId) & ", "
            strSQL &= NumberToField(mlngAppId) & ", "
            strSQL &= NumberToField(mlngFormId) & ", "
            strSQL &= StringToField(mstrCtrlName) & ", "
            strSQL &= StringToField(mstrCtrlText) & ", "
            strSQL &= StringToField(mstrCtrlType) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE secCtrl SET "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "FormId = " & NumberToField(mlngFormId) & ", "
            strSQL &= "CtrlName = " & StringToField(mstrCtrlName) & ", "
            strSQL &= "CtrlText = " & StringToField(mstrCtrlText) & ", "
            strSQL &= "CtrlType = " & StringToField(mstrCtrlType) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CtrlId = " & NumberToField(mlngCtrlId) & " "

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
               mlngCtrlId = ToLong(oDataRow("CtrlId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mlngFormId = ToLong(oDataRow("FormId"))
               mstrCtrlName = ToStr(oDataRow("CtrlName"))
               mstrCtrlText = ToStr(oDataRow("CtrlText"))
               mstrCtrlType = ToStr(oDataRow("CtrlType"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCtrlId = ToLong(oDataRow("CtrlId"))
               mstrCtrlText = ToStr(oDataRow("CtrlText"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCtrlId = TableIDGet(mstrTableName, "CtrlId", moConnection)

         If mlngCtrlId = -1 Then
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

      If mlngAppId = 0 Then
         strMsg &= "Aplicación Inválida" & vbCrLf
      End If

      If mlngFormId = 0 Then
         strMsg &= "Ingrese el Formulario" & vbCrLf
      End If

      If mstrCtrlName.Length() = 0 Then
         strMsg &= "Ingrese el Nombre del Control" & vbCrLf
      End If

      If mstrCtrlText.Length() = 0 Then
         strMsg &= "Ingrese la Descripción del Control" & vbCrLf
      End If

      If mstrCtrlType.Length() = 0 Then
         strMsg &= "Ingrese el Tipo de Control" & vbCrLf
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
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM secCtrl "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  secCtrl.AppId = " & NumberToField(mlngAppId)
         '   strSQL &= " AND  secCtrl.FormId = " & NumberToField(mlngFormId)
         'Else
         '   strSQL &= " WHERE  secCtrl.AppId = " & NumberToField(mlngAppId)
         '   strSQL &= " AND  secCtrl.FormId = " & NumberToField(mlngFormId)
         '   strSQL &= " AND  secCtrl.CtrlId <> " & NumberToField(mlngCtrlId)
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

   'Public Function Open() As Boolean
   '   Try
   '      Open = False

   '      Call OpenConection()

   '      moDataSet = New DataSet

   '      moDataAdapter = New OleDbDataAdapter(SelectSQL, moConnection)

   '      moDataAdapter.Fill(moDataSet, mstrTableName)

   '      moDataAdapter.Dispose()

   '      mintRow = 0
   '      mintRowsCount = moDataSet.Tables(mstrTableName).Rows.Count()

   '      Open = True

   '   Catch exp As Exception
   '      Throw exp

   '   End Try
   'End Function

   'Public Function Read() As Boolean
   '   Dim oDataRow As Data.DataRow

   '   Read = False

   '   Try
   '      If mintRowsCount > 0 Then
   '         If mintRow <= mintRowsCount - 1 Then
   '            oDataRow = moDataSet.Tables(mstrTableName).Rows(mintRow)

   '            Call Retrieve(oDataRow)
   '            Read = True
   '         End If
   '      End If

   '   Catch exp As Exception
   '      Throw exp

   '   End Try
   'End Function

   'Public Function Find() As Boolean
   '   Find = False

   '   Try
   '      If Open() Then
   '         If Read() Then
   '            Find = True
   '         End If
   '      End If

   '   Catch exp As Exception
   '      Throw exp

   '   End Try
   'End Function

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

   'Public Sub MoveNext()
   '   If mintRowsCount > 0 Then
   '      If mintRow < mintRowsCount Then
   '         mintRow += 1
   '      End If
   '   End If
   'End Sub

   'Public Sub MovePrevious()
   '   If mintRowsCount > 0 Then
   '      If mintRow > 0 Then
   '         mintRow -= 1
   '      End If
   '   End If
   'End Sub

   'Public Sub MoveFirst()
   '   If mintRowsCount > 0 Then
   '      mintRow = 0
   '   End If
   'End Sub

   'Public Sub MoveLast()
   '   If mintRowsCount > 0 Then
   '      mintRow = mintRowsCount - 1
   '   End If
   'End Sub

   'Public Function Insert() As Boolean
   '   Dim oCommand As OleDbCommand
   '   Dim intRecordsAffected As Integer

   '   Insert = False

   '   Try
   '      If Validate() Then
   '         If NoDuplicates(False) Then
   '            If GetNewPrimaryKey() Then
   '               Call OpenConection()

   '               oCommand = New OleDbCommand
   '               oCommand.CommandText = InsertSQL()
   '               oCommand.Connection = moConnection

   '               intRecordsAffected = oCommand.ExecuteNonQuery()

   '               If intRecordsAffected > 0 Then
   '                  Insert = True
   '               End If
   '            End If
   '         Else
   '            Throw New Exception("Registro Duplicado")
   '            Return False
   '         End If
   '      End If

   '   Catch exp As Exception
   '      Throw exp

   '   End Try
   'End Function

   'Public Function Update() As Boolean
   '   Dim oCommand As OleDbCommand
   '   Dim intRecordsAffected As Integer

   '   Update = False

   '   Try
   '      If Validate() Then
   '         If NoDuplicates(True) Then
   '            Call OpenConection()

   '            oCommand = New OleDbCommand
   '            oCommand.CommandText = UpdateSQL()
   '            oCommand.Connection = moConnection

   '            intRecordsAffected = oCommand.ExecuteNonQuery()

   '            If intRecordsAffected > 0 Then
   '               Update = True
   '            End If
   '         Else
   '            Throw New Exception("Registro Duplicado")
   '            Return False
   '         End If
   '      End If

   '   Catch exp As Exception
   '      Throw exp

   '   End Try
   'End Function

   'Public Function Delete() As Boolean
   '   Dim oCommand As OleDbCommand
   '   Dim intRecordsAffected As Integer

   '   Delete = False

   '   Try
   '      Call OpenConection()

   '      oCommand = New OleDbCommand
   '      oCommand.CommandText = DeleteSQL()
   '      oCommand.Connection = moConnection

   '      intRecordsAffected = oCommand.ExecuteNonQuery()

   '      If intRecordsAffected > 0 Then
   '         Delete = True
   '      End If

   '   Catch exp As Exception
   '      Throw exp

   '   End Try
   'End Function

   'Public Function RowCount() As Integer
   '   Dim oCommand As OleDbCommand
   '   Dim intRecordsAffected As Integer

   '   Try
   '      Call OpenConection()

   '      oCommand = New OleDbCommand
   '      oCommand.CommandText = RowCountSQL()
   '      oCommand.Connection = moConnection

   '      intRecordsAffected = CInt(oCommand.ExecuteScalar)

   '      Return intRecordsAffected

   '   Catch exp As Exception
   '      Throw exp

   '   End Try
   'End Function

   Public Sub FilterInit()
      mintWhereFilter = 0
      mintOrderByFilter = 0
      mintSelectFilter = 0
      mintInsertFilter = 0
      mintUpdateFilter = 0
      mintDeleteFilter = 0
      mintRowCountFilter = 0
   End Sub

   'Private Sub OpenConection()
   '   If moConnection.State = ConnectionState.Closed Then
   '      moConnection = New OleDbConnection(mstrConnectionString)
   '      moConnection.Open()
   '   End If
   'End Sub

   'Public Sub CloseConection()
   '   If moConnection.State = ConnectionState.Open Then
   '      moConnection.Close()
   '   End If
   'End Sub

   Overridable Sub Dispose() Implements IDisposable.Dispose
      Call CloseConection()
   End Sub

   Public Overrides Function IsDeleted() As Boolean

   End Function
End Class
