Imports System.Data
Imports System.Data.OleDb

Public Class clsSucursal
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsSucursalVM
   Public VMNew As New clsSucursalVM

   Private mlngSucursalId As Long
   Private mlngEmpresaId As Long
   Private mstrSucursalDes As String
   Private mstrSucursalCod As String
   Private mstrDireccion As String
   Private mlngCiudadId As Long
   Private mstrTelefono As String
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
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

   Property SucursalDes() As String
      Get
         Return mstrSucursalDes
      End Get

      Set(ByVal Value As String)
         mstrSucursalDes = Value
      End Set
   End Property

   Property SucursalCod() As String
      Get
         Return mstrSucursalCod
      End Get

      Set(ByVal Value As String)
         mstrSucursalCod = Value
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
      CompId = 3
      GridCheck = 4
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      SucursalDes = 2
      LIKESucursalDes = 3
      Grid = 4
      CompId = 5
      EmpresaId = 6
      SucursalCod = 7
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      SucursalId = 1
      SucursalDes = 2
      Grid = 3
      CompId = 4
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
      mstrTableName = "tblSucursal"
      mstrClassName = "clsSucursal"

      moConnection = New OleDbConnection
      VMNew = New clsSucursalVM

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
      mlngSucursalId = 0
      mlngEmpresaId = 0
      mstrSucursalDes = ""
      mstrSucursalCod = ""
      mstrDireccion = ""
      mlngCiudadId = 0
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
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.Direccion,  "
            strSQL &= "    tblSucursal.CiudadId,  "
            strSQL &= "    tblSucursal.Telefono,  "
            strSQL &= "    tblSucursal.sLastUpdate_id,  "
            strSQL &= "    tblSucursal.dtLastUpdate_dt,  "
            strSQL &= "    tblSucursal.iConcurrency_id  "
            strSQL &= " FROM tblSucursal "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalDes  "
            strSQL &= " FROM tblSucursal "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblSucursal.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    tblSucursal.Telefono  "
            strSQL &= " FROM tblSucursal, tblCiudad "

         Case SelectFilters.CompId
            strSQL = " SELECT  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.EmpresaId,  "
            strSQL &= "    tblCompDet.CompId,  "
            strSQL &= "    tblCompDet.CompDetId,  "
            strSQL &= "    tblPlan.PlanId,  "
            strSQL &= "    tblPlan.PlanCta,  "
            strSQL &= "    tblPlan.PlanDes,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes  "
            strSQL &= " FROM tblSucursal, tblPlan, tblCompDet "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblSucursal.Direccion,  "
            strSQL &= "    tblCiudad.CiudadId,  "
            strSQL &= "    tblCiudad.CiudadDes,  "
            strSQL &= "    tblSucursal.Telefono  "
            strSQL &= " FROM tblSucursal, tblCiudad "

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
            strSQL = " WHERE  tblSucursal.SucursalId = " & NumberToField(mlngSucursalId)

         Case WhereFilters.SucursalDes
            strSQL = " WHERE  tblSucursal.SucursalDes = " & StringToField(mstrSucursalDes)

         Case WhereFilters.LIKESucursalDes
            strSQL = " WHERE  tblSucursal.SucursalDes LIKE " & StringToField(mstrSucursalDes & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.CiudadId = tblCiudad.CiudadId "

         Case WhereFilters.CompId
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.SucursalId = tblCompDet.SucursalId "
            strSQL &= " AND  tblCompDet.PlanId = tblPlan.PlanId "
            strSQL &= " AND  tblCompDet.CompId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblCompDet.SucursalId <> 0 "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.SucursalCod
            strSQL = " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.SucursalCod = " & StringToField(mstrSucursalCod)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.SucursalId
            strSQL = " ORDER BY tblSucursal.SucursalId "

         Case OrderByFilters.SucursalDes
            strSQL = " ORDER BY tblSucursal.SucursalDes "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblSucursal.SucursalDes "

         Case OrderByFilters.CompId
            strSQL = " ORDER BY tblPlan.PlanCta "

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
            strSQL = "INSERT INTO tblSucursal ("
            strSQL &= "SucursalId, "
            strSQL &= "EmpresaId, "
            strSQL &= "SucursalDes, "
            strSQL &= "SucursalCod, "
            strSQL &= "Direccion, "
            strSQL &= "CiudadId, "
            strSQL &= "Telefono, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrSucursalDes) & ", "
            strSQL &= StringToField(mstrSucursalCod) & ", "
            strSQL &= StringToField(mstrDireccion) & ", "
            strSQL &= NumberToField(mlngCiudadId) & ", "
            strSQL &= StringToField(mstrTelefono) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblSucursal SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "SucursalDes = " & StringToField(mstrSucursalDes) & ", "
            strSQL &= "SucursalCod = " & StringToField(mstrSucursalCod) & ", "
            strSQL &= "Direccion = " & StringToField(mstrDireccion) & ", "
            strSQL &= "CiudadId = " & NumberToField(mlngCiudadId) & ", "
            strSQL &= "Telefono = " & StringToField(mstrTelefono) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " SucursalId = " & NumberToField(mlngSucursalId) & " "

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
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrSucursalDes = ToStr(oDataRow("SucursalDes"))
               mstrSucursalCod = ToStr(oDataRow("SucursalCod"))
               mstrDireccion = ToStr(oDataRow("Direccion"))
               mlngCiudadId = ToLong(oDataRow("CiudadId"))
               mstrTelefono = ToStr(oDataRow("Telefono"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mstrSucursalDes = ToStr(oDataRow("SucursalDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngSucursalId = TableIDGet(mstrTableName, "SucursalId", moConnection)

         If mlngSucursalId = -1 Then
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

      If mstrSucursalDes.Length() = 0 Then
         strMsg &= "Ingrese el Sucursal" & vbCrLf
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
         strSQL &= " FROM tblSucursal "

         If Not boolReplace Then
            strSQL &= " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.SucursalCod = " & StringToField(mstrSucursalCod)
         Else
            strSQL &= " WHERE  tblSucursal.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblSucursal.SucursalCod = " & StringToField(mstrSucursalCod)
            strSQL &= " AND  tblSucursal.SucursalId <> " & NumberToField(mlngSucursalId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngSucursalId)
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
         strSQL &= " FROM tblSucursal "
         strSQL &= " WHERE tblSucursal.SucursalId = " & NumberToField(mlngSucursalId)

         ''tblCompDet(SucursalId)
         If TableFind(oDataTable, "tblCompDet") Then
            strSQL &= " AND (tblSucursal.SucursalId IN "
            strSQL &= "     (SELECT DISTINCT SucursalId "
            strSQL &= "      FROM  tblCompDet "
            strSQL &= "      WHERE tblCompDet.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tblBancariza(SucursalId)
         If TableFind(oDataTable, "tblBancariza") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  tblBancariza "
            strSQL &= "    WHERE tblBancariza.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tblDosifica(SucursalId)
         If TableFind(oDataTable, "tblDosifica") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  tblDosifica "
            strSQL &= "    WHERE tblDosifica.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tblFactura(SucursalId)
         If TableFind(oDataTable, "tblFactura") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  tblFactura "
            strSQL &= "    WHERE tblFactura.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tblFacturaAgru(SucursalId)
         If TableFind(oDataTable, "tblFacturaAgru") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  tblFacturaAgru "
            strSQL &= "    WHERE tblFacturaAgru.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tblPoliza(SucursalId)
         If TableFind(oDataTable, "tblPoliza") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  tblPoliza "
            strSQL &= "    WHERE tblPoliza.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''acfActivoFijo(SucursalId)
         If TableFind(oDataTable, "acfActivoFijo") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  acfActivoFijo "
            strSQL &= "    WHERE acfActivoFijo.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''comCompraDet(SucursalIdAct)
         If TableFind(oDataTable, "comCompraDet") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalIdAct "
            strSQL &= "    FROM  comCompraDet "
            strSQL &= "    WHERE comCompraDet.SucursalIdAct = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''comCompraOtroCosto(SucursalId)
         If TableFind(oDataTable, "comCompraOtroCosto") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  comCompraOtroCosto "
            strSQL &= "    WHERE comCompraOtroCosto.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''csmMovEquipoDet(SucursalId)
         If TableFind(oDataTable, "csmMovEquipoDet") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  csmMovEquipoDet "
            strSQL &= "    WHERE csmMovEquipoDet.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''invAlmacen(SucursalId)
         If TableFind(oDataTable, "invAlmacen") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  invAlmacen "
            strSQL &= "    WHERE invAlmacen.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''invNotaDet(SucursalId)
         If TableFind(oDataTable, "invNotaDet") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  invNotaDet "
            strSQL &= "    WHERE invNotaDet.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''pdvCaja(SucursalId)
         If TableFind(oDataTable, "pdvCaja") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  pdvCaja "
            strSQL &= "    WHERE pdvCaja.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''pdvCajero(SucursalId)
         If TableFind(oDataTable, "pdvCajero") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  pdvCajero "
            strSQL &= "    WHERE pdvCajero.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''rrhEmpleado(SucursalId)
         If TableFind(oDataTable, "rrhEmpleado") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  rrhEmpleado "
            strSQL &= "    WHERE rrhEmpleado.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''rrhRRHHParaSuc(SucursalId)
         If TableFind(oDataTable, "rrhRRHHParaSuc") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  rrhRRHHParaSuc "
            strSQL &= "    WHERE rrhRRHHParaSuc.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tesArqueo(SucursalId)
         If TableFind(oDataTable, "tesArqueo") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  tesArqueo "
            strSQL &= "    WHERE tesArqueo.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tesIngresoEgreso(SucursalId)
         ''tesIngresoEgresoDet(SucursalId)
         ''tesIngresoEgresoDetDet(SucursalId)
         If TableFind(oDataTable, "tesIngresoEgreso") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalId "
            strSQL &= "    FROM  tesIngresoEgreso "
            strSQL &= "    WHERE tesIngresoEgreso.SucursalId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tesPlanifica(SucursalConceptoId)
         ''tesPlanificaDet(SucursalConceptoId)
         If TableFind(oDataTable, "tesPlanifica") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalConceptoId "
            strSQL &= "    FROM  tesPlanifica "
            strSQL &= "    WHERE tesPlanifica.SucursalConceptoId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tesPlanifica(SucursalAplicacionId)
         ''tesPlanificaDet(SucursalAplicacionId)
         If TableFind(oDataTable, "tesPlanifica") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalAplicacionId "
            strSQL &= "    FROM  tesPlanifica "
            strSQL &= "    WHERE tesPlanifica.SucursalAplicacionId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tesTransaccion(SucursalAplicacionId)
         If TableFind(oDataTable, "tesTransaccion") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalAplicacionId "
            strSQL &= "    FROM  tesTransaccion "
            strSQL &= "    WHERE tesTransaccion.SucursalAplicacionId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tesTransaccionDet(SucursalConceptoId)
         If TableFind(oDataTable, "tesTransaccionDet") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalConceptoId "
            strSQL &= "    FROM  tesTransaccionDet "
            strSQL &= "    WHERE tesTransaccionDet.SucursalConceptoId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''tesTransPlanifica(SucursalConceptoId)
         If TableFind(oDataTable, "tesTransPlanifica") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalConceptoId "
            strSQL &= "    FROM  tesTransPlanifica "
            strSQL &= "    WHERE tesTransPlanifica.SucursalConceptoId = " & NumberToField(mlngSucursalId) & ")"
         End If

         ''venVentaDet(SucursalIdCos)
         ''venVentaDet(SucursalIdIng)
         If TableFind(oDataTable, "venVentaDet") Then
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalIdCos "
            strSQL &= "    FROM  venVentaDet "
            strSQL &= "    WHERE venVentaDet.SucursalIdCos = " & NumberToField(mlngSucursalId) & ")"
            strSQL &= " OR tblSucursal.SucursalId IN "
            strSQL &= "   (SELECT DISTINCT SucursalIdIng "
            strSQL &= "    FROM  venVentaDet "
            strSQL &= "    WHERE venVentaDet.SucursalIdIng = " & NumberToField(mlngSucursalId) & ")"
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
