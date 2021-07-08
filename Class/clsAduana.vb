Imports System.Data
Imports System.Data.OleDb

Public Class clsAduana
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsAduanaVM
   Public VMNew As New clsAduanaVM

   Private mlngAduanaId As Long
   Private mstrAduanaDes As String
   Private mstrAduanaNIT As String
   Private mstrDireccion As String
   Private mstrTelefono As String
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property AduanaId() As Long
      Get
         Return mlngAduanaId
      End Get

      Set(ByVal Value As Long)
         mlngAduanaId = Value
      End Set
   End Property

   Property AduanaDes() As String
      Get
         Return mstrAduanaDes
      End Get

      Set(ByVal Value As String)
         mstrAduanaDes = Value
      End Set
   End Property

   Property AduanaNIT() As String
      Get
         Return mstrAduanaNIT
      End Get

      Set(ByVal Value As String)
         mstrAduanaNIT = Value
      End Set
   End Property

   Property Direccion() As String
      Get
         Return mstrDireccion
      End Get

      Set(ByVal Value As String)
         mstrDireccion = Value
      End Set
   End Property

   Property Telefono() As String
      Get
         Return mstrTelefono
      End Get

      Set(ByVal Value As String)
         mstrTelefono = Value
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
      AduanaDes = 2
      LIKEAduanaDes = 3
      Grid = 4
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      AduanaId = 1
      AduanaDes = 2
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
      mstrTableName = "tblAduana"
      mstrClassName = "clsAduana"

      moConnection = New OleDbConnection
      VMNew = New clsAduanaVM

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
      mlngAduanaId = 0
      mstrAduanaDes = ""
      mstrAduanaNIT = ""
      mstrDireccion = ""
      mstrTelefono = ""

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblAduana.AduanaId,  "
            strSQL &= "    tblAduana.AduanaDes,  "
            strSQL &= "    tblAduana.AduanaNIT,  "
            strSQL &= "    tblAduana.Direccion,  "
            strSQL &= "    tblAduana.Telefono,  "
            strSQL &= "    tblAduana.sLastUpdate_id,  "
            strSQL &= "    tblAduana.dtLastUpdate_dt,  "
            strSQL &= "    tblAduana.iConcurrency_id  "
            strSQL &= " FROM tblAduana "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblAduana.AduanaId,  "
            strSQL &= "    tblAduana.AduanaDes  "
            strSQL &= " FROM tblAduana "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblAduana.AduanaId,  "
            strSQL &= "    tblAduana.AduanaNIT,  "
            strSQL &= "    tblAduana.AduanaDes,  "
            strSQL &= "    tblAduana.Direccion,  "
            strSQL &= "    tblAduana.Telefono  "
            strSQL &= " FROM tblAduana "

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
            strSQL = " WHERE  tblAduana.AduanaId = " & NumberToField(mlngAduanaId)

         Case WhereFilters.AduanaDes
            strSQL = " WHERE  tblAduana.AduanaDes = " & StringToField(mstrAduanaDes)

         Case WhereFilters.LIKEAduanaDes
            strSQL = " WHERE  tblAduana.AduanaDes LIKE " & StringToField(mstrAduanaDes & LikeOperator)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.AduanaId
            strSQL = " ORDER BY tblAduana.AduanaId "

         Case OrderByFilters.AduanaDes
            strSQL = " ORDER BY tblAduana.AduanaDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblAduana.AduanaDes "

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
            strSQL = "INSERT INTO tblAduana ("
            strSQL &= "AduanaId, "
            strSQL &= "AduanaDes, "
            strSQL &= "AduanaNIT, "
            strSQL &= "Direccion, "
            strSQL &= "Telefono, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngAduanaId) & ", "
            strSQL &= StringToField(mstrAduanaDes) & ", "
            strSQL &= StringToField(mstrAduanaNIT) & ", "
            strSQL &= StringToField(mstrDireccion) & ", "
            strSQL &= StringToField(mstrTelefono) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblAduana SET "
            strSQL &= "AduanaDes = " & StringToField(mstrAduanaDes) & ", "
            strSQL &= "AduanaNIT = " & StringToField(mstrAduanaNIT) & ", "
            strSQL &= "Direccion = " & StringToField(mstrDireccion) & ", "
            strSQL &= "Telefono = " & StringToField(mstrTelefono) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " AduanaId = " & NumberToField(mlngAduanaId) & " "

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
               mlngAduanaId = ToLong(oDataRow("AduanaId"))
               mstrAduanaDes = ToStr(oDataRow("AduanaDes"))
               mstrAduanaNIT = ToStr(oDataRow("AduanaNIT"))
               mstrDireccion = ToStr(oDataRow("Direccion"))
               mstrTelefono = ToStr(oDataRow("Telefono"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngAduanaId = ToLong(oDataRow("AduanaId"))
               mstrAduanaDes = ToStr(oDataRow("AduanaDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngAduanaId = TableIDGet(mstrTableName, "AduanaId", moConnection)

         If mlngAduanaId = -1 Then
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

      If mstrAduanaNIT.Length() = 0 Then
         strMsg &= "Ingrese el Número de NIT" & vbCrLf
      End If

      If mstrAduanaDes.Length() = 0 Then
         strMsg &= "Ingrese La Razón Social" & vbCrLf
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
         strSQL &= " FROM tblAduana "

         If Not boolReplace Then
            strSQL &= " WHERE  tblAduana.AduanaNIT = " & StringToField(mstrAduanaNIT)
         Else
            strSQL &= " WHERE  tblAduana.AduanaNIT = " & StringToField(mstrAduanaNIT)
            strSQL &= " AND  tblAduana.AduanaId <> " & NumberToField(mlngAduanaId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngAduanaId)
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
         strSQL &= " FROM tblAduana "
         strSQL &= " WHERE tblAduana.AduanaId = " & NumberToField(mlngAduanaId)

         If TableFind(oDataTable, "tblPoliza") Then
            strSQL &= " AND (tblAduana.AduanaId IN "
            strSQL &= "     (SELECT DISTINCT AduanaId "
            strSQL &= "      FROM  tblPoliza "
            strSQL &= "      WHERE tblPoliza.AduanaId = " & NumberToField(mlngAduanaId) & ")"
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
