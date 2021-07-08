Imports System.Data
Imports System.Data.OleDb

Public Class clsCompraPara
   Implements IDisposable

   Private mlngCompraParaId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompraId As Long
   Private mlngNroIni As Long
   Private mlngNroActual As Long
   Private mbytConFac As Byte
   Private mstrFirma As String
   Private mlngTipoHojaId As Long
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
   Property CompraParaId() As Long
      Get
         Return mlngCompraParaId
      End Get

      Set(ByVal Value As Long)
         mlngCompraParaId = Value
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

   Property GestionId() As Long
      Get
         Return mlngGestionId
      End Get

      Set(ByVal Value As Long)
         mlngGestionId = Value
      End Set
   End Property

   Property TipoCompraId() As Long
      Get
         Return mlngTipoCompraId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCompraId = Value
      End Set
   End Property

   Property NroIni() As Long
      Get
         Return mlngNroIni
      End Get

      Set(ByVal Value As Long)
         mlngNroIni = Value
      End Set
   End Property

   Property NroActual() As Long
      Get
         Return mlngNroActual
      End Get

      Set(ByVal Value As Long)
         mlngNroActual = Value
      End Set
   End Property

   Property ConFac() As Byte
      Get
         Return mbytConFac
      End Get

      Set(ByVal Value As Byte)
         mbytConFac = Value
      End Set
   End Property

   Property Firma() As String
      Get
         Return mstrFirma
      End Get

      Set(ByVal Value As String)
         mstrFirma = Value
      End Set
   End Property

   Property TipoHojaId() As Long
      Get
         Return mlngTipoHojaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoHojaId = Value
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
      TipoCompraId = 3
      GestionId = 4
      EmpresaId = 5
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompraParaId = 1
      Grid = 3
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      NroActual = 1
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
      mstrTableName = "comCompraPara"
      mstrClassName = "clsCompraPara"

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
      mlngCompraParaId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngTipoCompraId = 0
      mlngNroIni = 0
      mlngNroActual = 0
      mbytConFac = 0
      mstrFirma = ""
      mlngTipoHojaId = 0
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
            strSQL &= "    comCompraPara.CompraParaId,  "
            strSQL &= "    comCompraPara.EmpresaId,  "
            strSQL &= "    comCompraPara.GestionId,  "
            strSQL &= "    comCompraPara.TipoCompraId,  "
            strSQL &= "    comCompraPara.NroIni,  "
            strSQL &= "    comCompraPara.NroActual,  "
            strSQL &= "    comCompraPara.ConFac,  "
            strSQL &= "    comCompraPara.Firma,  "
            strSQL &= "    comCompraPara.TipoHojaId,  "
            strSQL &= "    comCompraPara.EstadoId,  "
            strSQL &= "    comCompraPara.sLastUpdate_id,  "
            strSQL &= "    comCompraPara.dtLastUpdate_dt,  "
            strSQL &= "    comCompraPara.iConcurrency_id  "
            strSQL &= " FROM comCompraPara "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    comCompraPara.CompraParaId  "
            strSQL &= " FROM comCompraPara "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    comCompraPara.CompraParaId,  "
            strSQL &= "    comCompraPara.EmpresaId,  "
            strSQL &= "    tblGestion.GestionId,  "
            strSQL &= "    tblGestion.Gestion,  "
            strSQL &= "    comTipoCompra.TipoCompraId,  "
            strSQL &= "    comTipoCompra.TipoCompraDes,  "
            strSQL &= "    comCompraPara.NroIni,  "
            strSQL &= "    comCompraPara.NroActual,  "
            strSQL &= "    comCompraPara.Firma,  "
            strSQL &= "    tblTipoHoja.TipoHojaId,  "
            strSQL &= "    tblTipoHoja.TipoHojaDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM comCompraPara, tblGestion, comTipoCompra, tblTipoHoja, tblEstado "

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
            strSQL = " WHERE  comCompraPara.CompraParaId = " & NumberToField(mlngCompraParaId)

         Case WhereFilters.Grid
            strSQL = " WHERE  comCompraPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraPara.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  comCompraPara.GestionId = tblGestion.GestionId "
            strSQL &= " AND  comCompraPara.TipoCompraId = comTipoCompra.TipoCompraId "
            strSQL &= " AND  comCompraPara.TipoHojaId = tblTipoHoja.TipoHojaId "
            strSQL &= " AND  comCompraPara.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  comCompraPara.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.TipoCompraId
            strSQL = " WHERE  comCompraPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraPara.TipoCompraId = " & NumberToField(mlngTipoCompraId)
            strSQL &= " AND  comCompraPara.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.GestionId
            strSQL = " WHERE  comCompraPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  comCompraPara.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  comCompraPara.EmpresaId = " & NumberToField(mlngEmpresaId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompraParaId
            strSQL = " ORDER BY comCompraPara.CompraParaId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblGestion.Gestion, comTipoCompra.TipoCompraId "

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
            strSQL = "INSERT INTO comCompraPara ("
            strSQL &= "CompraParaId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoCompraId, "
            strSQL &= "NroIni, "
            strSQL &= "NroActual, "
            strSQL &= "ConFac, "
            strSQL &= "Firma, "
            strSQL &= "TipoHojaId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompraParaId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoCompraId) & ", "
            strSQL &= NumberToField(mlngNroIni) & ", "
            strSQL &= NumberToField(mlngNroActual) & ", "
            strSQL &= NumberToField(mbytConFac) & ", "
            strSQL &= StringToField(mstrFirma) & ", "
            strSQL &= NumberToField(mlngTipoHojaId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE comCompraPara SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoCompraId = " & NumberToField(mlngTipoCompraId) & ", "
            strSQL &= "NroIni = " & NumberToField(mlngNroIni) & ", "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual) & ", "
            strSQL &= "ConFac = " & NumberToField(mbytConFac) & ", "
            strSQL &= "Firma = " & "'" & mstrFirma & "', "
            strSQL &= "TipoHojaId = " & NumberToField(mlngTipoHojaId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompraParaId = " & NumberToField(mlngCompraParaId) & " "

         Case UpdateFilters.NroActual
            strSQL = "UPDATE comCompraPara SET "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompraParaId = " & NumberToField(mlngCompraParaId) & " "

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
               mlngCompraParaId = ToLong(oDataRow("CompraParaId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoCompraId = ToLong(oDataRow("TipoCompraId"))
               mlngNroIni = ToLong(oDataRow("NroIni"))
               mlngNroActual = ToLong(oDataRow("NroActual"))
               mbytConFac = ToByte(oDataRow("ConFac"))
               mstrFirma = ToStr(oDataRow("Firma"))
               mlngTipoHojaId = ToLong(oDataRow("TipoHojaId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompraParaId = ToLong(oDataRow("CompraParaId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompraParaId = TableIDGet(mstrTableName, "CompraParaId", moConnection)

         If mlngCompraParaId = -1 Then
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

      'If mstrCompraParaDes.Length() = 0 Then
      '   strMsg &= "Ingrese la Descripción" & vbCrLf
      'End If

      'If mstrFecha.Trim() <> String.Empty Then
      '   If Not IsDate(mstrFecha) Then
      '      strMsg &= "Fecha no es una fecha válida" & vbCrLf
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

   Public Function NoDuplicates(ByVal boolReplace As Boolean) As Boolean
      Dim strSQL As String
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM comCompraPara "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  comCompraPara.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCompraPara.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  comCompraPara.NroActual = " & NumberToField(mlngNroActual)
         'Else
         '   strSQL &= " WHERE  comCompraPara.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  comCompraPara.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  comCompraPara.NroActual = " & NumberToField(mlngNroActual)
         '   strSQL &= " AND  comCompraPara.CompraParaId <> " & NumberToField(mlngCompraParaId)
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
