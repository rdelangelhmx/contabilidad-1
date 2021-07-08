Imports System.Data
Imports System.Data.OleDb

Public Class clsEmpresa
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsEmpresaVM
   Public VMNew As New clsEmpresaVM

   Private mlngEmpresaId As Long
   Private mstrEmpresaDes As String
   Private mstrEmpresaRUC As String
   Private mstrDireccion As String
   Private mlngCiudadId As Long
   Private mstrTelefono1 As String
   Private mstrTelefono2 As String
   Private mstrMovil As String
   Private mstrFax As String
   Private mstrCodPostal As String
   Private mstrEmail As String
   Private mstrWeb As String
   Private mlngMesAperturaId As Long
   Private mlngMesCierreId As Long
   Private mlngMonedaId As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Property EmpresaDes() As String
      Get
         Return mstrEmpresaDes
      End Get

      Set(ByVal Value As String)
         mstrEmpresaDes = Value
      End Set
   End Property

   Property EmpresaRUC() As String
      Get
         Return mstrEmpresaRUC
      End Get

      Set(ByVal Value As String)
         mstrEmpresaRUC = Value
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

   Property CiudadId() As Long
      Get
         Return mlngCiudadId
      End Get

      Set(ByVal Value As Long)
         mlngCiudadId = Value
      End Set
   End Property

   Property Telefono1() As String
      Get
         Return mstrTelefono1
      End Get

      Set(ByVal Value As String)
         mstrTelefono1 = Value
      End Set
   End Property

   Property Telefono2() As String
      Get
         Return mstrTelefono2
      End Get

      Set(ByVal Value As String)
         mstrTelefono2 = Value
      End Set
   End Property

   Property Movil() As String
      Get
         Return mstrMovil
      End Get

      Set(ByVal Value As String)
         mstrMovil = Value
      End Set
   End Property

   Property Fax() As String
      Get
         Return mstrFax
      End Get

      Set(ByVal Value As String)
         mstrFax = Value
      End Set
   End Property

   Property CodPostal() As String
      Get
         Return mstrCodPostal
      End Get

      Set(ByVal Value As String)
         mstrCodPostal = Value
      End Set
   End Property

   Property Email() As String
      Get
         Return mstrEmail
      End Get

      Set(ByVal Value As String)
         mstrEmail = Value
      End Set
   End Property

   Property Web() As String
      Get
         Return mstrWeb
      End Get

      Set(ByVal Value As String)
         mstrWeb = Value
      End Set
   End Property

   Property MesAperturaId() As Long
      Get
         Return mlngMesAperturaId
      End Get

      Set(ByVal Value As Long)
         mlngMesAperturaId = Value
      End Set
   End Property

   Property MesCierreId() As Long
      Get
         Return mlngMesCierreId
      End Get

      Set(ByVal Value As Long)
         mlngMesCierreId = Value
      End Set
   End Property

   Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngMonedaId = Value
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
      Report = 3
      EmpresaGestion = 4
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      EmpresaDes = 2
      LIKEEmpresaDes = 3
      Grid = 4
      Report = 5
      EmpresaGestion = 6
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      EmpresaId = 1
      EmpresaDes = 2
      Grid = 3
      Report = 4
      EmpresaGestion = 5
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
      mstrTableName = "tblEmpresa"
      mstrClassName = "clsEmpresa"

      moConnection = New OleDbConnection
      VMNew = New clsEmpresaVM

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
      mlngEmpresaId = 0
      mstrEmpresaDes = ""
      mstrEmpresaRUC = ""
      mstrDireccion = ""
      mlngCiudadId = 0
      mstrTelefono1 = ""
      mstrTelefono2 = ""
      mstrMovil = ""
      mstrFax = ""
      mstrCodPostal = ""
      mstrEmail = ""
      mstrWeb = ""
      mlngMesAperturaId = 0
      mlngMesCierreId = 0
      mlngMonedaId = 0
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
            strSQL &= "    tblEmpresa.EmpresaId,  "
            strSQL &= "    tblEmpresa.EmpresaDes,  "
            strSQL &= "    tblEmpresa.EmpresaRUC,  "
            strSQL &= "    tblEmpresa.Direccion,  "
            strSQL &= "    tblEmpresa.CiudadId,  "
            strSQL &= "    tblEmpresa.Telefono1,  "
            strSQL &= "    tblEmpresa.Telefono2,  "
            strSQL &= "    tblEmpresa.Movil,  "
            strSQL &= "    tblEmpresa.Fax,  "
            strSQL &= "    tblEmpresa.CodPostal,  "
            strSQL &= "    tblEmpresa.Email,  "
            strSQL &= "    tblEmpresa.Web,  "
            strSQL &= "    tblEmpresa.MesAperturaId,  "
            strSQL &= "    tblEmpresa.MesCierreId,  "
            strSQL &= "    tblEmpresa.MonedaId,  "
            strSQL &= "    tblEmpresa.EstadoId,  "
            strSQL &= "    tblEmpresa.sLastUpdate_id,  "
            strSQL &= "    tblEmpresa.dtLastUpdate_dt,  "
            strSQL &= "    tblEmpresa.iConcurrency_id  "
            strSQL &= " FROM tblEmpresa "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblEmpresa.EmpresaId,  "
            strSQL &= "    tblEmpresa.EmpresaDes  "
            strSQL &= " FROM tblEmpresa "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblEmpresa.EmpresaId,  "
            strSQL &= "    tblEmpresa.EmpresaDes,  "
            strSQL &= "    tblEmpresa.EmpresaRUC,  "
            strSQL &= "    tblEmpresa.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    tblEmpresa.Telefono1,  "
            strSQL &= "    tblEmpresa.Telefono2,  "
            strSQL &= "    tblEmpresa.Movil,  "
            strSQL &= "    tblEmpresa.Fax,  "
            strSQL &= "    tblEmpresa.CodPostal,  "
            strSQL &= "    tblEmpresa.Email,  "
            strSQL &= "    tblEmpresa.Web,  "
            strSQL &= "    tblEmpresa.MesAperturaId,  "
            strSQL &= "    tblMesApertura.MesDes As MesAperturaDes,  "
            strSQL &= "    tblEmpresa.MesCierreId,  "
            strSQL &= "    tblMesCierre.MesDes As MesCierreDes,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblEmpresa, tblCiudad, tblEstado, tblMes As tblMesApertura, tblMes As tblMesCierre, tblMoneda "

         Case SelectFilters.EmpresaGestion
            strSQL = " SELECT  "
            strSQL &= "    tblEmpresa.EmpresaId, "
            strSQL &= "    tblEmpresa.EmpresaDes, "
            strSQL &= "    tblGestion.GestionId, "
            strSQL &= "    tblGestion.Gestion "
            strSQL &= " FROM tblEmpresa, tblGestion "
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
            strSQL = " WHERE  tblEmpresa.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.EmpresaDes
            strSQL = " WHERE  tblEmpresa.EmpresaDes = " & StringToField(mstrEmpresaDes)

         Case WhereFilters.LIKEEmpresaDes
            strSQL = " WHERE  tblEmpresa.EmpresaDes LIKE " & StringToField(mstrEmpresaDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblEmpresa.CiudadId = tblCiudad.CiudadId "
            strSQL &= " AND  tblEmpresa.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblEmpresa.MesAperturaId = tblMesApertura.MesId "
            strSQL &= " AND  tblEmpresa.MesCierreId = tblMesCierre.MesId "
            strSQL &= " AND  tblEmpresa.MonedaId = tblMoneda.MonedaId "

         Case WhereFilters.EmpresaGestion
            strSQL = " WHERE  tblEmpresa.EstadoId <> 0 "
            strSQL &= " AND  tblEmpresa.Empresaid = tblGestion.EmpresaId "
            strSQL &= " AND  tblGestion.EstadoId <> 12 "
      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.EmpresaId
            strSQL = " ORDER BY tblEmpresa.EmpresaId "

         Case OrderByFilters.EmpresaDes
            strSQL = " ORDER BY tblEmpresa.EmpresaDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblEmpresa.EmpresaDes "

         Case OrderByFilters.EmpresaGestion
            strSQL = " ORDER BY tblEmpresa.EmpresaId, tblGestion.Gestion ASC "

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
            strSQL = "INSERT INTO tblEmpresa ("
            strSQL &= "EmpresaId, "
            strSQL &= "EmpresaDes, "
            strSQL &= "EmpresaRUC, "
            strSQL &= "Direccion, "
            strSQL &= "CiudadId, "
            strSQL &= "Telefono1, "
            strSQL &= "Telefono2, "
            strSQL &= "Movil, "
            strSQL &= "Fax, "
            strSQL &= "CodPostal, "
            strSQL &= "Email, "
            strSQL &= "Web, "
            strSQL &= "MesAperturaId, "
            strSQL &= "MesCierreId, "
            strSQL &= "MonedaId, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrEmpresaDes) & ", "
            strSQL &= StringToField(mstrEmpresaRUC) & ", "
            strSQL &= StringToField(mstrDireccion) & ", "
            strSQL &= NumberToField(mlngCiudadId) & ", "
            strSQL &= StringToField(mstrTelefono1) & ", "
            strSQL &= StringToField(mstrTelefono2) & ", "
            strSQL &= StringToField(mstrMovil) & ", "
            strSQL &= StringToField(mstrFax) & ", "
            strSQL &= StringToField(mstrCodPostal) & ", "
            strSQL &= StringToField(mstrEmail) & ", "
            strSQL &= StringToField(mstrWeb) & ", "
            strSQL &= NumberToField(mlngMesAperturaId) & ", "
            strSQL &= NumberToField(mlngMesCierreId) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblEmpresa SET "
            strSQL &= "EmpresaDes = " & StringToField(mstrEmpresaDes) & ", "
            strSQL &= "EmpresaRUC = " & StringToField(mstrEmpresaRUC) & ", "
            strSQL &= "Direccion = " & StringToField(mstrDireccion) & ", "
            strSQL &= "CiudadId = " & NumberToField(mlngCiudadId) & ", "
            strSQL &= "Telefono1 = " & StringToField(mstrTelefono1) & ", "
            strSQL &= "Telefono2 = " & StringToField(mstrTelefono2) & ", "
            strSQL &= "Movil = " & StringToField(mstrMovil) & ", "
            strSQL &= "Fax = " & StringToField(mstrFax) & ", "
            strSQL &= "CodPostal = " & StringToField(mstrCodPostal) & ", "
            strSQL &= "Email = " & StringToField(mstrEmail) & ", "
            strSQL &= "Web = " & StringToField(mstrWeb) & ", "
            strSQL &= "MesAperturaId = " & NumberToField(mlngMesAperturaId) & ", "
            strSQL &= "MesCierreId = " & NumberToField(mlngMesCierreId) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " EmpresaId = " & NumberToField(mlngEmpresaId) & " "

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
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrEmpresaDes = ToStr(oDataRow("EmpresaDes"))
               mstrEmpresaRUC = ToStr(oDataRow("EmpresaRUC"))
               mstrDireccion = ToStr(oDataRow("Direccion"))
               mlngCiudadId = ToLong(oDataRow("CiudadId"))
               mstrTelefono1 = ToStr(oDataRow("Telefono1"))
               mstrTelefono2 = ToStr(oDataRow("Telefono2"))
               mstrMovil = ToStr(oDataRow("Movil"))
               mstrFax = ToStr(oDataRow("Fax"))
               mstrCodPostal = ToStr(oDataRow("CodPostal"))
               mstrEmail = ToStr(oDataRow("Email"))
               mstrWeb = ToStr(oDataRow("Web"))
               mlngMesAperturaId = ToLong(oDataRow("MesAperturaId"))
               mlngMesCierreId = ToLong(oDataRow("MesCierreId"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrEmpresaDes = ToStr(oDataRow("EmpresaDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngEmpresaId = TableIDGet(mstrTableName, "EmpresaId", moConnection)

         If mlngEmpresaId = -1 Then
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

      If mstrEmpresaDes.Length() = 0 Then
         strMsg &= "Ingrese el Empresa" & vbCrLf
      End If

      If mlngMesCierreId = 0 Then
         strMsg &= "Seleccione el Mes de Cierre" & vbCrLf
      End If

      If mlngMonedaId = 0 Then
         strMsg &= "Seleccione la Moneda" & vbCrLf
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
         strSQL &= " FROM tblEmpresa "

         If Not boolReplace Then
            strSQL &= " WHERE  tblEmpresa.EmpresaDes = " & StringToField(mstrEmpresaDes)
            strSQL &= " AND  tblEmpresa.EmpresaRUC = " & StringToField(mstrEmpresaRUC)
         Else
            strSQL &= " WHERE  tblEmpresa.EmpresaDes = " & StringToField(mstrEmpresaDes)
            strSQL &= " AND  tblEmpresa.EmpresaRUC = " & StringToField(mstrEmpresaRUC)
            strSQL &= " AND  tblEmpresa.EmpresaId <> " & NumberToField(mlngEmpresaId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngEmpresaId)
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
      ''Dim strSQL As String = ""
      ''Dim oCommand As OleDbCommand
      ''Dim intRecordsAffected As Integer

      ''Dim oDataTable As New DataTable
      ''Dim dbNull As System.DBNull
      ''Dim oRestrictions() As Object = {dbNull, dbNull, dbNull, "TABLE"}

      ''Try
      ''   Call OpenConection()
      ''   oDataTable = moConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, oRestrictions)

      ''   strSQL = " SELECT "
      ''   strSQL &= " Count(*) As NumRecs "
      ''   strSQL &= " FROM tblEmpresa "
      ''   strSQL &= " WHERE tblEmpresa.EmpresaId = " & NumberToField(mlngEmpresaId)

      ''   If TableFind(oDataTable, "tblGestion") Then
      ''      strSQL &= " AND (tblEmpresa.EmpresaId IN "
      ''      strSQL &= "     (SELECT DISTINCT EmpresaId "
      ''      strSQL &= "      FROM  tblGestion "
      ''      strSQL &= "      WHERE tblGestion.EmpresaId = " & NumberToField(mlngEmpresaId) & ")"
      ''   End If

      'acfActivoDatoTecnico(EmpresaId)
      'acfActivoFijo(EmpresaId)
      'acfActivoPara(EmpresaId)
      'acfActualizacion(EmpresaId)
      'acfBaja(EmpresaId)
      'acfBajaDet(EmpresaId)
      'acfDepreciacion(EmpresaId)
      'acfDepreciacionDet(EmpresaId)
      'acfLinea(EmpresaId)
      'acfRelocalizacion(EmpresaId)
      'acfRelocalizacionDet(EmpresaId)
      'acfUbicacion(EmpresaId)
      'agrAgricolaPara(EmpresaId)
      'agrAgricolaParaPlan(EmpresaId)
      'agrCultivo(EmpresaId)
      'agrLote(EmpresaId)
      'agrVariedad(EmpresaId)
      'apoAportePara(EmpresaId)
      'apoAporteParaCalc(EmpresaId)
      'apoClienteMov(EmpresaId)
      'apoCreditoMes(EmpresaId)
      'apoCreditoMesDet(EmpresaId)
      'apoPago(EmpresaId)
      'apoPagoDet(EmpresaId)
      'apoPlantilla(EmpresaId)
      'apoPlantillaDet(EmpresaId)
      'balBalanzaPara(EmpresaId)
      'balConductor(EmpresaId)
      'balContrato(EmpresaId)
      'balNotaVenta(EmpresaId)
      'balNotaVentaPara(EmpresaId)
      'balTipoBalanza(EmpresaId)
      'balVehiculo(EmpresaId)
      'comAjuste(EmpresaId)
      'comAjusteDet(EmpresaId)
      'comAnticipo(EmpresaId)
      'comAnticipoDet(EmpresaId)
      'comCompra(EmpresaId)
      'comCompraDescuento(EmpresaId)
      'comCompraDet(EmpresaId)
      'comCompraOtroCosto(EmpresaId)
      'comCompraPara(EmpresaId)
      'comCompraPedidoDet(EmpresaId)
      'comCompraRecargo(EmpresaId)
      'comCredito(EmpresaId)
      'comCreditoDet(EmpresaId)
      'comDevCompra(EmpresaId)
      'comDevCompraDet(EmpresaId)
      'comItemProveedor(EmpresaId)
      'comPago(EmpresaId)
      'comPagoDet(EmpresaId)
      'comPedCompra(EmpresaId)
      'comPedCompraDet(EmpresaId)
      'comPlanDescuento(EmpresaId)
      'comPlanOtroCosto(EmpresaId)
      'comPlanRecargo(EmpresaId)
      'comProrrateo(EmpresaId)
      'comProveedor(EmpresaId)
      'comProveedorMov(EmpresaId)
      'csmMovEqPara(EmpresaId)
      'csmMovEquipo(EmpresaId)
      'csmMovEquipoDet(EmpresaId)
      'csmPedMovEquipo(EmpresaId)
      'csmPedMovEquipoDet(EmpresaId)
      'cspAsistencia(EmpresaId)
      'cspAsistenciaDet(EmpresaId)
      'cspAsistenciaSup(EmpresaId)
      'cspAusencia(EmpresaId)
      'cspContrato(EmpresaId)
      'cspDotacion(EmpresaId)
      'cspElemento(EmpresaId)
      'cspElementoAsignado(EmpresaId)
      'cspIncidencia(EmpresaId)
      'cspNovedad(EmpresaId)
      'cspSupervision(EmpresaId)
      'inmCliente(EmpresaId)
      'inmClienteMov(EmpresaId)
      'inmContrato(EmpresaId)
      'inmCredito(EmpresaId)
      'inmCreditoDet(EmpresaId)
      'inmInmobiliariaPara(EmpresaId)
      'inmInmobiliariaParaCalc(EmpresaId)
      'inmLote(EmpresaId)
      'inmManzana(EmpresaId)
      'inmPago(EmpresaId)
      'inmPagoDet(EmpresaId)
      'inmPropietario(EmpresaId)
      'inmRepresentante(EmpresaId)
      'inmUbicacion(EmpresaId)
      'inmUnidadVecinal(EmpresaId)
      'invAjuste(EmpresaId)
      'invAjusteDet(EmpresaId)
      'invAjusteUFV(EmpresaId)
      'invAjusteUFVDet(EmpresaId)
      'invAlmacen(EmpresaId)
      'invComposicion(EmpresaId)
      'invDatoTecnico(EmpresaId)
      'invFabrica(EmpresaId)
      'invGrupo(EmpresaId)
      'invItem(EmpresaId)
      'invItemBarra(EmpresaId)
      'invItemHist(EmpresaId)
      'invItemLote(EmpresaId)
      'invItemNroSerie(EmpresaId)
      'invItemPeps(EmpresaId)
      'invItemPrecio(EmpresaId)
      'invItemSaldo(EmpresaId)
      'invItemUeps(EmpresaId)
      'invLinea(EmpresaId)
      'invMarca(EmpresaId)
      'invMedida(EmpresaId)
      'invNota(EmpresaId)
      'invNotaDet(EmpresaId)
      'invNotaPara(EmpresaId)
      'invPlanGrupo(EmpresaId)
      'invSubGrupo(EmpresaId)
      'invSustituto(EmpresaId)
      'invTipoDatoTecnico(EmpresaId)
      'mtoCombustible(EmpresaId)
      'mtoDatoTecnico(EmpresaId)
      'mtoEquipo(EmpresaId)
      'mtoFuncionamiento(EmpresaId)
      'mtoLugar(EmpresaId)
      'mtoManoObra(EmpresaId)
      'mtoMedicion(EmpresaId)
      'mtoOrdenDetencion(EmpresaId)
      'mtoOrdenMaterial(EmpresaId)
      'mtoOrdenPara(EmpresaId)
      'mtoOrdenPermiso(EmpresaId)
      'mtoOrdenTrabajo(EmpresaId)
      'mtoPedidoTrabajo(EmpresaId)
      'mtoPermiso(EmpresaId)
      'mtoPlanPrograma(EmpresaId)
      'mtoPlanProgramaPermiso(EmpresaId)
      'mtoPrograma(EmpresaId)
      'mtoProgramaPermiso(EmpresaId)
      'mtoPropietario(EmpresaId)
      'mtoServicioExterno(EmpresaId)
      'mtoSubTarea(EmpresaId)
      'mtoTaller(EmpresaId)
      'mtoTarea(EmpresaId)
      'mtoTipoDatoTecnico(EmpresaId)
      'mtoTipoEquipo(EmpresaId)
      'mtoUnidad(EmpresaId)
      'ordInstalador(EmpresaId)
      'ordMarca(EmpresaId)
      'ordMecanico(EmpresaId)
      'ordModelo(EmpresaId)
      'ordOrdenPara(EmpresaId)
      'ordOrdenTrabajo(EmpresaId)
      'ordOrdenTrabajoDet(EmpresaId)
      'ordOrdenTrabajoPara(EmpresaId)
      'ordVehiculo(EmpresaId)
      'pdeParteDiario(EmpresaId)
      'pdeParteDiarioConfig(EmpresaId)
      'pdeParteDiarioDet(EmpresaId)
      'pdeParteDiarioPara(EmpresaId)
      'pdeTarea(EmpresaId)
      'pdvCaja(EmpresaId)
      'pdvCajaMov(EmpresaId)
      'pdvCajero(EmpresaId)
      'pdvDespacho(EmpresaId)
      'pdvItemPromotor(EmpresaId)
      'pdvItemRep(EmpresaId)
      'pdvItemTouch(EmpresaId)
      'pdvLineaTouch(EmpresaId)
      'pdvPromotor(EmpresaId)
      'pdvPtoVenta(EmpresaId)
      'pdvPtoVentaDet(EmpresaId)
      'pdvPtoVentaPara(EmpresaId)
      'pfiPresuFin(EmpresaId)
      'pfiPresufinDet(EmpresaId)
      'pfiPresufinDetDet(EmpresaId)
      'pptModulo(EmpresaId)
      'pptModuloDet(EmpresaId)
      'pptPresupuesto(EmpresaId)
      'pptPresupuestoDet(EmpresaId)
      'pptPresupuestoDetDet(EmpresaId)
      'pptPresupuestoDetFis(EmpresaId)
      'pptPresupuestoPara(EmpresaId)
      'pptPresupuestoParaCalc(EmpresaId)
      'proProduccion(EmpresaId)
      'proProduccionNota(EmpresaId)
      'proProduccionNotaDet(EmpresaId)
      'proProduccionPara(EmpresaId)
      'proReceta(EmpresaId)
      'rrhAFP(EmpresaId)
      'rrhArea(EmpresaId)
      'rrhAscenso(EmpresaId)
      'rrhAsistencia(EmpresaId)
      'rrhAsistenciaCC(EmpresaId)
      'rrhAsistenciaCCDet(EmpresaId)
      'rrhAsistenciaPara(EmpresaId)
      'rrhAsistenciaXCCDet(EmpresaId)
      'rrhCalendario(EmpresaId)
      'rrhCapacitacion(EmpresaId)
      'rrhCargo(EmpresaId)
      'rrhCtaBanco(EmpresaId)
      'rrhDescuento(EmpresaId)
      'rrhDescuentoEmpleado(EmpresaId)
      'rrhDescuentoIndividual(EmpresaId)
      'rrhDescuentoMes(EmpresaId)
      'rrhDescuentoNoAplicable(EmpresaId)
      'rrhDescuentoNoAplicableDet(EmpresaId)
      'rrhDocumentacion(EmpresaId)
      'rrhEmpleado(EmpresaId)
      'rrhEmpleadoAna(EmpresaId)
      'rrhEntradaSalida(EmpresaId)
      'rrhEntradaSalidaXGrupo(EmpresaId)
      'rrhExpedido(EmpresaId)
      'rrhFiniquito(EmpresaId)
      'rrhIncrementoSalario(EmpresaId)
      'rrhIncrementoSalarioDet(EmpresaId)
      'rrhIngreso(EmpresaId)
      'rrhIngresoEmpleado(EmpresaId)
      'rrhIngresoIndividual(EmpresaId)
      'rrhIngresoMes(EmpresaId)
      'rrhIngresoNoAplicable(EmpresaId)
      'rrhIngresoNoAplicableDet(EmpresaId)
      'rrhNivel(EmpresaId)
      'rrhPlanilla(EmpresaId)
      'rrhPlanillaAguinaldo(EmpresaId)
      'rrhPlanillaPrima(EmpresaId)
      'rrhPlanillaPrimaRCIVA(EmpresaId)
      'rrhPlanillaRCIVA(EmpresaId)
      'rrhPostulante(EmpresaId)
      'rrhPreaviso(EmpresaId)
      'rrhPrima(EmpresaId)
      'rrhQuinquenio(EmpresaId)
      'rrhRetiroPersonal(EmpresaId)
      'rrhRRHHPara(EmpresaId)
      'rrhRRHHParaSuc(EmpresaId)
      'rrhRRHHPlan(EmpresaId)
      'rrhSeguroAccidente(EmpresaId)
      'rrhSeguroAccidenteDet(EmpresaId)
      'rrhSeguroAccidenteNivelDet(EmpresaId)
      'rrhSeguroNivelDet(EmpresaId)
      'rrhSeguroSalud(EmpresaId)
      'rrhSuceso(EmpresaId)
      'rrhTransferencia(EmpresaId)
      'rrhVacacion(EmpresaId)
      'rrhVacacionDet(EmpresaId)
      'secOpera(EmpresaId)
      'secPreference(EmpresaId)
      'surAsignacion(EmpresaId)
      'surAsignacionBomba(EmpresaId)
      'surAsignacionFactura(EmpresaId)
      'surAsignacionVale(EmpresaId)
      'surBomba(EmpresaId)
      'surCalibracion(EmpresaId)
      'surCheque(EmpresaId)
      'surConductor(EmpresaId)
      'surHistorialContab(EmpresaId)
      'surIsla(EmpresaId)
      'surMaquina(EmpresaId)
      'surSurtidorPara(EmpresaId)
      'surTarjeta(EmpresaId)
      'surVale(EmpresaId)
      'surVentaOrdenPara(EmpresaId)
      'tblBancariza(EmpresaId)
      'tblBanco(EmpresaId)
      'tblCentroCosto(EmpresaId)
      'tblCentroCostoDet(EmpresaId)
      'tblCheque(EmpresaId)
      'tblChequeImp(EmpresaId)
      'tblComp(EmpresaId)
      'tblCompCentroCostoDet(EmpresaId)
      'tblCompCheque(EmpresaId)
      'tblCompDet(EmpresaId)
      'tblCompPara(EmpresaId)
      'tblCompParaMes(EmpresaId)
      'tblCompPlanAdd(EmpresaId)
      'tblCompraFac(EmpresaId)
      'tblDosifica(EmpresaId)
      'tblDosificaDet(EmpresaId)
      'tblEmpresa(EmpresaId)
      'tblEmpresaPara(EmpresaId)
      'tblFactura(EmpresaId)
      'tblFacturaAgru(EmpresaId)
      'tblFacturaDet(EmpresaId)
      'tblFacturaPara(EmpresaId)
      'tblGestion(EmpresaId)
      'tblPersonal(EmpresaId)
      'tblPlan(EmpresaId)
      'tblPlanAdd(EmpresaId)
      'tblPoliza(EmpresaId)
      'tblRecibo(EmpresaId)
      'tblReciboPara(EmpresaId)
      'tblRegRUC(EmpresaId)
      'tblSucursal(EmpresaId)
      'tblTipoActEco(EmpresaId)
      'tblVentaFac(EmpresaId)
      'tblVentaFacDet(EmpresaId)
      'tesAplicacion(EmpresaId)
      'tesArqueo(EmpresaId)
      'tesArqueoDet(EmpresaId)
      'tesBilletaje(EmpresaId)
      'tesCambioMoneda(EmpresaId)
      'tesCatalogoCuenta(EmpresaId)
      'tesCobradorCuenta(EmpresaId)
      'tesCobradorDet(EmpresaId)
      'tesConcepto(EmpresaId)
      'tesEntidad(EmpresaId)
      'tesEntidadMov(EmpresaId)
      'tesFormaPago(EmpresaId)
      'tesGenerador(EmpresaId)
      'tesIngresoEgreso(EmpresaId)
      'tesIngresoEgresoDet(EmpresaId)
      'tesIngresoEgresoDetDet(EmpresaId)
      'tesPlanifica(EmpresaId)
      'tesPlanificaDet(EmpresaId)
      'tesRendicion(EmpresaId)
      'tesTesoreriaPara(EmpresaId)
      'tesTesoreriaParaDet(EmpresaId)
      'tesTransaccion(EmpresaId)
      'tesTransaccionDet(EmpresaId)
      'tesTransPlanifica(EmpresaId)
      'tesTraspasoCaja(EmpresaId)
      'tesTraspasoCuenta(EmpresaId)
      'tesTraspasoPlanAdd(EmpresaId)
      'tranAnticipoAlquiler(EmpresaId)
      'tranAnticipoVehiculo(EmpresaId)
      'tranCliente(EmpresaId)
      'tranClienteDet(EmpresaId)
      'tranClienteMov(EmpresaId)
      'tranClienteProv(EmpresaId)
      'tranConductor(EmpresaId)
      'tranConductorMov(EmpresaId)
      'tranConsignatario(EmpresaId)
      'tranCredito(EmpresaId)
      'tranCreditoDet(EmpresaId)
      'tranCRT(EmpresaId)
      'tranCRTDet(EmpresaId)
      'tranEmpTransporte(EmpresaId)
      'tranFactura(EmpresaId)
      'tranFacturaDet(EmpresaId)
      'tranFacturaEdit(EmpresaId)
      'tranLugares(EmpresaId)
      'tranMIC(EmpresaId)
      'tranMICDet(EmpresaId)
      'tranPago(EmpresaId)
      'tranPagoAlquiler(EmpresaId)
      'tranPagoChofer(EmpresaId)
      'tranPagoDet(EmpresaId)
      'tranPedido(EmpresaId)
      'tranProveedor(EmpresaId)
      'tranRemitente(EmpresaId)
      'tranSalida(EmpresaId)
      'tranSalidaDet(EmpresaId)
      'tranTIF(EmpresaId)
      'tranTIFDet(EmpresaId)
      'tranTramos(EmpresaId)
      'tranTransportePara(EmpresaId)
      'tranVehiculo(EmpresaId)
      'tranVehiculoDet(EmpresaId)
      'tranVehiculoMov(EmpresaId)
      'venAjuste(EmpresaId)
      'venAjusteDet(EmpresaId)
      'venAnticipo(EmpresaId)
      'venAnticipoDet(EmpresaId)
      'venAnticipoDis(EmpresaId)
      'venCliente(EmpresaId)
      'venClienteMov(EmpresaId)
      'venCobrador(EmpresaId)
      'venCredito(EmpresaId)
      'venCreditoDet(EmpresaId)
      'venDevEntrega(EmpresaId)
      'venDevEntregaDet(EmpresaId)
      'venDevGarantia(EmpresaId)
      'venDevGarantiaDet(EmpresaId)
      'venDevVenta(EmpresaId)
      'venDevVentaCred(EmpresaId)
      'venDevVentaDet(EmpresaId)
      'venEntrega(EmpresaId)
      'venEntregaDet(EmpresaId)
      'venEstimacion(EmpresaId)
      'venGarantia(EmpresaId)
      'venGarantiaDet(EmpresaId)
      'venItemVendedor(EmpresaId)
      'venPago(EmpresaId)
      'venPagoDet(EmpresaId)
      'venPedVenta(EmpresaId)
      'venPedVentaDet(EmpresaId)
      'venPlanDescuento(EmpresaId)
      'venPlanRecargo(EmpresaId)
      'venProforma(EmpresaId)
      'venProformaDet(EmpresaId)
      'venTarjeta(EmpresaId)
      'venTipoAnticipoDis(EmpresaId)
      'venTipoTarjeta(EmpresaId)
      'venTurno(EmpresaId)
      'venVendedor(EmpresaId)
      'venVenta(EmpresaId)
      'venVentaDescuento(EmpresaId)
      'venVentaDet(EmpresaId)
      'venVentaDetPaq(EmpresaId)
      'venVentaDifAju(EmpresaId)
      'venVentaDifAjuDet(EmpresaId)
      'venVentaPara(EmpresaId)
      'venVentaPedidoDet(EmpresaId)
      'venVentaProformaDet(EmpresaId)
      'venVentaRecargo(EmpresaId)
      'venZona(EmpresaId)

      ''strSQL &= " )"

      ''If strSQL <> "" Then
      ''   Call OpenConection()

      ''   oCommand = New OleDbCommand
      ''   oCommand.CommandText = strSQL
      ''   oCommand.Connection = moConnection

      ''   intRecordsAffected = oCommand.ExecuteScalar

      ''   If intRecordsAffected = 0 Then
      ''      IsDeleted = True
      ''   Else
      ''      IsDeleted = False
      ''   End If
      ''Else
      IsDeleted = True
      ''End If

      ''Catch exp As Exception
      ''   Throw exp

      ''End Try
   End Function
End Class
