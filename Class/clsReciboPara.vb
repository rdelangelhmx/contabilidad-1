Imports System.Data
Imports System.Data.OleDb

Public Class clsReciboPara
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsReciboParaVM
   Public VMNew As New clsReciboParaVM

   Private mlngReciboParaId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompId As Long
   Private mlngNroIni As Long
   Private mlngNroActual As Long
   Private mstrFirma As String
   Private mlngTipoHojaId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property ReciboParaId() As Long
      Get
         Return mlngReciboParaId
      End Get

      Set(ByVal Value As Long)
         mlngReciboParaId = Value
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
      TipoCompId = 3
      GestionId = 4
      EmpresaId = 5
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ReciboParaId = 1
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
      mstrTableName = "tblReciboPara"
      mstrClassName = "clsReciboPara"

      moConnection = New OleDbConnection
      VMNew = New clsReciboParaVM

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
      mlngReciboParaId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngTipoCompId = 0
      mlngNroIni = 0
      mlngNroActual = 0
      mstrFirma = ""
      mlngTipoHojaId = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblReciboPara.ReciboParaId,  "
            strSQL &= "    tblReciboPara.EmpresaId,  "
            strSQL &= "    tblReciboPara.GestionId,  "
            strSQL &= "    tblReciboPara.TipoCompId,  "
            strSQL &= "    tblReciboPara.NroIni,  "
            strSQL &= "    tblReciboPara.NroActual,  "
            strSQL &= "    tblReciboPara.Firma,  "
            strSQL &= "    tblReciboPara.TipoHojaId,  "
            strSQL &= "    tblReciboPara.sLastUpdate_id,  "
            strSQL &= "    tblReciboPara.dtLastUpdate_dt,  "
            strSQL &= "    tblReciboPara.iConcurrency_id  "
            strSQL &= " FROM tblReciboPara "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblReciboPara.ReciboParaId  "
            strSQL &= " FROM tblReciboPara "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblReciboPara.ReciboParaId,  "
            strSQL &= "    tblReciboPara.EmpresaId,  "
            strSQL &= "    tblGestion.GestionId,  "
            strSQL &= "    tblGestion.Gestion,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblReciboPara.NroIni,  "
            strSQL &= "    tblReciboPara.NroActual,  "
            strSQL &= "    tblReciboPara.Firma,  "
            strSQL &= "    tblTipoHoja.TipoHojaId,  "
            strSQL &= "    tblTipoHoja.TipoHojaDes  "
            strSQL &= " FROM tblReciboPara, tblGestion, tblTipoComp, tblTipoHoja "

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
            strSQL = " WHERE  tblReciboPara.ReciboParaId = " & NumberToField(mlngReciboParaId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblReciboPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblReciboPara.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblReciboPara.GestionId = tblGestion.GestionId "
            strSQL &= " AND  tblReciboPara.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblReciboPara.TipoHojaId = tblTipoHoja.TipoHojaId "

         Case WhereFilters.TipoCompId
            strSQL = " WHERE  tblReciboPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblReciboPara.TipoCompId = " & NumberToField(mlngTipoCompId)
            strSQL &= " AND  tblReciboPara.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.GestionId
            strSQL = " WHERE  tblReciboPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblReciboPara.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblReciboPara.EmpresaId = " & NumberToField(mlngEmpresaId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ReciboParaId
            strSQL = " ORDER BY tblReciboPara.ReciboParaId "

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
            strSQL = "INSERT INTO tblReciboPara ("
            strSQL &= "ReciboParaId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoCompId, "
            strSQL &= "NroIni, "
            strSQL &= "NroActual, "
            strSQL &= "Firma, "
            strSQL &= "TipoHojaId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngReciboParaId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            strSQL &= NumberToField(mlngNroIni) & ", "
            strSQL &= NumberToField(mlngNroActual) & ", "
            strSQL &= StringToField(mstrFirma) & ", "
            strSQL &= NumberToField(mlngTipoHojaId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblReciboPara SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "NroIni = " & NumberToField(mlngNroIni) & ", "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual) & ", "
            strSQL &= "Firma = " & "'" & mstrFirma & "', "
            strSQL &= "TipoHojaId = " & NumberToField(mlngTipoHojaId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ReciboParaId = " & NumberToField(mlngReciboParaId) & " "

         Case UpdateFilters.NroActual
            strSQL = "UPDATE tblReciboPara SET "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual)
            strSQL &= " WHERE "
            strSQL &= " ReciboParaId = " & NumberToField(mlngReciboParaId) & " "

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
               mlngReciboParaId = ToLong(oDataRow("ReciboParaId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               mlngNroIni = ToLong(oDataRow("NroIni"))
               mlngNroActual = ToLong(oDataRow("NroActual"))
               mstrFirma = ToStr(oDataRow("Firma"))
               mlngTipoHojaId = ToLong(oDataRow("TipoHojaId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngReciboParaId = ToLong(oDataRow("ReciboParaId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngReciboParaId = TableIDGet(mstrTableName, "ReciboParaId", moConnection)

         If mlngReciboParaId = -1 Then
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

      'If mstrReciboParaDes.Length() = 0 Then
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
         'strSQL &= " FROM tblReciboPara "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblReciboPara.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblReciboPara.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  tblReciboPara.NroActual = " & NumberToField(mlngNroActual)
         'Else
         '   strSQL &= " WHERE  tblReciboPara.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblReciboPara.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  tblReciboPara.NroActual = " & NumberToField(mlngNroActual)
         '   strSQL &= " AND  tblReciboPara.ReciboParaId <> " & NumberToField(mlngReciboParaId)
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
