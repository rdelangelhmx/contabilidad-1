Imports System.Data.OleDb
Imports System.Reflection

Public MustInherit Class clsBase
   Protected moConnection As OleDbConnection
   Protected moDataAdapter As OleDbDataAdapter
   Protected moDataSet As DataSet

   Protected mintRow As Integer
   Protected mintRowsCount As Integer
   Protected mintRowsMax As Integer

   Protected mstrConnectionString As String
   Protected mstrTableName As String
   Protected mstrClassName As String
   Protected mstrSQL As String

   Protected mstrDataBaseSource As String
   Protected mstrDataBaseName As String

   Protected MustOverride Function SelectSQL() As String
   Protected MustOverride Function InsertSQL() As String
   Protected MustOverride Function UpdateSQL() As String
   Protected MustOverride Function DeleteSQL() As String
   Protected MustOverride Function RowCountSQL() As String

   Protected MustOverride Sub Retrieve(ByVal oDataRow As DataRow)
   Public MustOverride Function Validate() As Boolean
   Public MustOverride Function NoDuplicates(ByVal boolReplace As Boolean) As Boolean
   Public MustOverride Function IsDeleted() As Boolean
   Protected MustOverride Function GetNewPrimaryKey() As Boolean

   Public Property ConnectionString() As String
      Get
         Return mstrConnectionString
      End Get

      Set(ByVal Value As String)
         mstrConnectionString = Value
      End Set
   End Property

   Public Property DataSet() As DataSet
      Get
         Return moDataSet
      End Get

      Set(ByVal Value As DataSet)
         moDataSet = Value
      End Set
   End Property

   Property RowPosition() As Integer
      Get
         Return mintRow
      End Get

      Set(ByVal Value As Integer)
         mintRow = Value
      End Set
   End Property

   Property RowsCount() As Integer
      Get
         Return mintRowsCount
      End Get

      Set(ByVal Value As Integer)
         mintRowsCount = Value
      End Set
   End Property

   Property RowsMax() As Integer
      Get
         Return mintRowsMax
      End Get

      Set(ByVal Value As Integer)
         mintRowsMax = Value
      End Set
   End Property

   ReadOnly Property DataBaseSource() As String
      Get
         Return mstrDataBaseSource
      End Get
   End Property

   ReadOnly Property DataBaseName() As String
      Get
         Return mstrDataBaseName
      End Get
   End Property

   Public ReadOnly Property TableName() As String
      Get
         Return mstrTableName
      End Get
   End Property

   Public ReadOnly Property ClassName() As String
      Get
         Return mstrClassName
      End Get
   End Property

   Public ReadOnly Property SQL() As String
      Get
         Return mstrSQL
      End Get
   End Property

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

   Public Function FindOnly() As Boolean
      FindOnly = False

      Try
         If Open() Then
            If mintRowsCount > 0 Then
               FindOnly = True
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

   Public Function Insert(ByVal oTransaction As OleDbTransaction) As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Insert = False

      Try
         If Validate() Then
            If NoDuplicates(False) Then
               If GetNewPrimaryKey() Then
                  'Call OpenConection()

                  oCommand = New OleDbCommand
                  oCommand.CommandText = InsertSQL()
                  oCommand.Connection = oTransaction.Connection
                  oCommand.Transaction = oTransaction

                  intRecordsAffected = oCommand.ExecuteNonQuery()

                  If intRecordsAffected > 0 Then
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

   Public Function Update(ByVal oTransaction As OleDbTransaction) As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Update = False

      Try
         If Validate() Then
            If NoDuplicates(True) Then
               'Call OpenConection()

               oCommand = New OleDbCommand
               oCommand.CommandText = UpdateSQL()
               oCommand.Connection = oTransaction.Connection
               oCommand.Transaction = oTransaction

               intRecordsAffected = oCommand.ExecuteNonQuery()

               If intRecordsAffected > 0 Then
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

   Public Function UpdateOnly() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      UpdateOnly = False

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = UpdateSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = oCommand.ExecuteNonQuery()

         If intRecordsAffected > 0 Then
            UpdateOnly = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function UpdateOnly(ByVal oTransaction As OleDbTransaction) As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      UpdateOnly = False

      Try
         'Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = UpdateSQL()
         oCommand.Connection = oTransaction.Connection
         oCommand.Transaction = oTransaction

         intRecordsAffected = oCommand.ExecuteNonQuery()

         If intRecordsAffected > 0 Then
            UpdateOnly = True
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
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function

   Public Function Delete(ByVal oTransaction As OleDbTransaction) As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Delete = False

      Try
         ' Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = DeleteSQL()
         oCommand.Connection = oTransaction.Connection
         oCommand.Transaction = oTransaction

         intRecordsAffected = oCommand.ExecuteNonQuery()

         If intRecordsAffected > 0 Then
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

   Public Function TableFind(ByVal oDataTable As DataTable, ByVal strTablaName As String) As Boolean
      For Each oDataRow As DataRow In oDataTable.Rows
         If oDataRow("TABLE_NAME").ToString() = strTablaName Then
            Return True
         End If
      Next

      Return False
   End Function

   Protected Sub OpenConection()
      If moConnection.State = ConnectionState.Closed Then
         moConnection = New OleDbConnection(mstrConnectionString)
         mstrDataBaseSource = moConnection.DataSource
         mstrDataBaseName = moConnection.Database
         moConnection.Open()
      End If
   End Sub

   Public Sub CloseConection()
      If moConnection.State = ConnectionState.Open Then
         moConnection.Close()
      End If
   End Sub

   Public Function GetColumnsFind() As List(Of DataRow)

      Dim str As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = " & StringToField(mstrTableName)

      Try

         Call OpenConection()

         moDataSet = New DataSet

         moDataAdapter = New OleDbDataAdapter(str, moConnection)

         moDataAdapter.Fill(moDataSet, mstrTableName)

         moDataAdapter.Dispose()

         Call CloseConection()

         Return moDataSet.Tables(mstrTableName).AsEnumerable.ToList()

      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private mObjectState As clsBase

   Property GetState() As clsBase
      Get
         Return mObjectState
      End Get
      Set(ByVal value As clsBase)
         mObjectState = value
      End Set
   End Property

   Public Overrides Function Equals(ByVal obj As Object) As Boolean
      Dim columns As List(Of DataRow) = GetColumnsFind()
      Dim strValues As String = ""
      Dim t As Type = Me.GetType()
      Dim props() As PropertyInfo = t.GetProperties()
      Equals = True

      For Each prop In props
         If prop.GetIndexParameters().Length = 0 Then
            If columns.Exists(Function(s) s("COLUMN_NAME") = prop.Name) Then
               If TypeOf prop.GetValue(Me, Nothing) Is Byte Then 'prop.PropertyType.Name = UCase$("Byte") Then  'UCase$(oControl.GetType.Name) = UCase$("UIReBar")
                  If Not Object.Equals(ToBoolean(prop.GetValue(Me, Nothing)), ToBoolean(prop.GetValue(Me.mObjectState, Nothing))) Then
                     Equals = False
                  End If
               Else
                  If Not Object.Equals(prop.GetValue(Me, Nothing), prop.GetValue(Me.mObjectState, Nothing)) Then
                     Equals = False
                  End If
               End If
            End If
         End If
      Next
   End Function

   Public Overrides Function ToString() As String
      Dim strValues As String = ""
      Dim columns As List(Of DataRow) = GetColumnsFind()
      Dim t As Type = Me.GetType()
      Dim props() As PropertyInfo = t.GetProperties()

      For Each prop In props
         If prop.GetIndexParameters().Length = 0 Then
            If columns.Exists(Function(s) s("COLUMN_NAME") = prop.Name) Then
               If TypeOf prop.GetValue(Me, Nothing) Is Byte Then 'prop.PropertyType.Name = UCase$("Byte") Then  'UCase$(oControl.GetType.Name) = UCase$("UIReBar")
                  If Not Object.Equals(ToBoolean(prop.GetValue(Me, Nothing)), ToBoolean(prop.GetValue(Me.mObjectState, Nothing))) Then
                     strValues &= prop.Name & ": " & If(ToBoolean(prop.GetValue(Me, Nothing)), "Sí", "No") & "; "
                  End If
               Else
                  If Not Object.Equals(prop.GetValue(Me, Nothing), prop.GetValue(Me.mObjectState, Nothing)) Then
                     strValues &= prop.Name & ": " & prop.GetValue(Me, Nothing).ToString & "; "
                  End If
               End If
            End If
         End If
      Next
      Return strValues
   End Function

End Class

