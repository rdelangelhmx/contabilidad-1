Imports System.Data
Imports System.Data.OleDb

Public Class clsCompParaMes
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsCompParaMesVM
   Public VMNew As New clsCompParaMesVM

   Private mlngCompParaMesId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompId As Long
   Private mlngMesId As Long
   Private mlngNroIni As Long
   Private mlngNroActual As Long
   Private mlngNroIniFis As Long
   Private mlngNroActualFis As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CompParaMesId() As Long
      Get
         Return mlngCompParaMesId
      End Get

      Set(ByVal Value As Long)
         mlngCompParaMesId = Value
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

   Property TipoCompId() As Long
      Get
         Return mlngTipoCompId
      End Get

      Set(ByVal Value As Long)
         mlngTipoCompId = Value
      End Set
   End Property

   Property MesId() As Long
      Get
         Return mlngMesId
      End Get

      Set(ByVal Value As Long)
         mlngMesId = Value
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

   Property NroIniFis() As Long
      Get
         Return mlngNroIniFis
      End Get

      Set(ByVal Value As Long)
         mlngNroIniFis = Value
      End Set
   End Property

   Property NroActualFis() As Long
      Get
         Return mlngNroActualFis
      End Get

      Set(ByVal Value As Long)
         mlngNroActualFis = Value
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
      Grid = 2
      TipoCompId = 3
      GestionId = 4
      EmpresaId = 5
      MesId = 6
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompParaMesId = 1
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
      mstrTableName = "tblCompParaMes"
      mstrClassName = "clsCompParaMes"

      moConnection = New OleDbConnection
      VMNew = New clsCompParaMesVM

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
      mlngCompParaMesId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngTipoCompId = 0
      mlngMesId = 0
      mlngNroIni = 0
      mlngNroActual = 0
      mlngNroIniFis = 0
      mlngNroActualFis = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblCompParaMes.CompParaMesId,  "
            strSQL &= "    tblCompParaMes.EmpresaId,  "
            strSQL &= "    tblCompParaMes.GestionId,  "
            strSQL &= "    tblCompParaMes.TipoCompId,  "
            strSQL &= "    tblCompParaMes.MesId,  "
            strSQL &= "    tblCompParaMes.NroIni,  "
            strSQL &= "    tblCompParaMes.NroActual,  "
            strSQL &= "    tblCompParaMes.NroIniFis,  "
            strSQL &= "    tblCompParaMes.NroActualFis,  "
            strSQL &= "    tblCompParaMes.sLastUpdate_id,  "
            strSQL &= "    tblCompParaMes.dtLastUpdate_dt,  "
            strSQL &= "    tblCompParaMes.iConcurrency_id  "
            strSQL &= " FROM tblCompParaMes "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCompParaMes.CompParaMesId  "
            strSQL &= " FROM tblCompParaMes "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCompParaMes.CompParaMesId,  "
            strSQL &= "    tblCompParaMes.EmpresaId,  "
            strSQL &= "    tblGestion.GestionId,  "
            strSQL &= "    tblGestion.Gestion,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblMes.MesId,  "
            strSQL &= "    tblMes.MesDes,  "
            strSQL &= "    tblCompParaMes.NroIni,  "
            strSQL &= "    tblCompParaMes.NroActual,  "
            strSQL &= "    tblCompParaMes.NroIniFis,  "
            strSQL &= "    tblCompParaMes.NroActualFis  "
            strSQL &= " FROM tblCompParaMes, tblGestion, tblTipoComp, tblMes "

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
            strSQL = " WHERE  tblCompParaMes.CompParaMesId = " & NumberToField(mlngCompParaMesId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCompParaMes.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompParaMes.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompParaMes.GestionId = tblGestion.GestionId "
            strSQL &= " AND  tblCompParaMes.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompParaMes.MesId = tblMes.MesId "

         Case WhereFilters.TipoCompId
            strSQL = " WHERE  tblCompParaMes.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompParaMes.TipoCompId = " & NumberToField(mlngTipoCompId)
            strSQL &= " AND  tblCompParaMes.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.GestionId
            strSQL = " WHERE  tblCompParaMes.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompParaMes.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblCompParaMes.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.MesId
            strSQL = " WHERE  tblCompParaMes.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompParaMes.TipoCompId = " & NumberToField(mlngTipoCompId)
            strSQL &= " AND  tblCompParaMes.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompParaMes.MesId = " & NumberToField(mlngMesId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompParaMesId
            strSQL = " ORDER BY tblCompParaMes.CompParaMesId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblGestion.Gestion, tblTipoComp.TipoCompId "

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
            strSQL = "INSERT INTO tblCompParaMes ("
            strSQL &= "CompParaMesId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoCompId, "
            strSQL &= "MesId, "
            strSQL &= "NroIni, "
            strSQL &= "NroActual, "
            strSQL &= "NroIniFis, "
            strSQL &= "NroActualFis, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompParaMesId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            strSQL &= NumberToField(mlngMesId) & ", "
            strSQL &= NumberToField(mlngNroIni) & ", "
            strSQL &= NumberToField(mlngNroActual) & ", "
            strSQL &= NumberToField(mlngNroIniFis) & ", "
            strSQL &= NumberToField(mlngNroActualFis) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCompParaMes SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "MesId = " & NumberToField(mlngMesId) & ", "
            strSQL &= "NroIni = " & NumberToField(mlngNroIni) & ", "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual) & ", "
            strSQL &= "NroIniFis = " & NumberToField(mlngNroIniFis) & ", "
            strSQL &= "NroActualFis = " & NumberToField(mlngNroActualFis) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompParaMesId = " & NumberToField(mlngCompParaMesId) & " "

         Case UpdateFilters.NroActual
            strSQL = "UPDATE tblCompParaMes SET "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual) & ", "
            strSQL &= "NroActualFis = " & NumberToField(mlngNroActualFis) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompParaMesId = " & NumberToField(mlngCompParaMesId) & " "

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
               mlngCompParaMesId = ToLong(oDataRow("CompParaMesId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               mlngMesId = ToLong(oDataRow("MesId"))
               mlngNroIni = ToLong(oDataRow("NroIni"))
               mlngNroActual = ToLong(oDataRow("NroActual"))
               mlngNroIniFis = ToLong(oDataRow("NroIniFis"))
               mlngNroActualFis = ToLong(oDataRow("NroActualFis"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompParaMesId = ToLong(oDataRow("CompParaMesId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompParaMesId = TableIDGet(mstrTableName, "CompParaMesId", moConnection)

         If mlngCompParaMesId = -1 Then
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

      'If mstrCompParaMesDes.Length() = 0 Then
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

   Public Overrides Function NoDuplicates(ByVal boolReplace As Boolean) As Boolean
      Dim strSQL As String
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM tblCompParaMes "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblCompParaMes.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompParaMes.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  tblCompParaMes.NroActual = " & NumberToField(mlngNroActual)
         'Else
         '   strSQL &= " WHERE  tblCompParaMes.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompParaMes.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  tblCompParaMes.NroActual = " & NumberToField(mlngNroActual)
         '   strSQL &= " AND  tblCompParaMes.CompParaMesId <> " & NumberToField(mlngCompParaMesId)
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
