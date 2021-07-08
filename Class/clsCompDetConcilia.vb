Imports System.Data
Imports System.Data.OleDb

Public Class clsCompDetConcilia
   Inherits clsBase
   Implements IDisposable

   Public VMOld As clsCompDetConciliaVM
   Public VMNew As clsCompDetConciliaVM

   Private mlngCompDetId As Long
   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompId As Long
   Private mstrFecha As String
   Private mlngPlanId As Long
   Private mstrFechaCon As String
   Private mbytConcilia As Byte
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CompDetId() As Long
      Get
         Return mlngCompDetId
      End Get

      Set(ByVal Value As Long)
         mlngCompDetId = Value
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

   Property CompId() As Long
      Get
         Return mlngCompId
      End Get

      Set(ByVal Value As Long)
         mlngCompId = Value
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

   Property Fecha() As String
      Get
         Return mstrFecha
      End Get

      Set(ByVal Value As String)
         mstrFecha = Value
      End Set
   End Property

   Property PlanId() As Long
      Get
         Return mlngPlanId
      End Get

      Set(ByVal Value As Long)
         mlngPlanId = Value
      End Set
   End Property

   Property FechaCon() As String
      Get
         Return mstrFechaCon
      End Get

      Set(ByVal Value As String)
         mstrFechaCon = Value
      End Set
   End Property

   ''Property MonedaId() As Long
   ''   Get
   ''      Return mlngMonedaId
   ''   End Get

   ''   Set(ByVal Value As Long)
   ''      mlngMonedaId = Value
   ''   End Set
   ''End Property

   ''Property DebeOrg() As Decimal
   ''   Get
   ''      Return mdecDebeOrg
   ''   End Get

   ''   Set(ByVal Value As Decimal)
   ''      mdecDebeOrg = Value
   ''   End Set
   ''End Property

   ''Property HaberOrg() As Decimal
   ''   Get
   ''      Return mdecHaberOrg
   ''   End Get

   ''   Set(ByVal Value As Decimal)
   ''      mdecHaberOrg = Value
   ''   End Set
   ''End Property

   ''Property DebeBs() As Decimal
   ''   Get
   ''      Return mdecDebeBs
   ''   End Get

   ''   Set(ByVal Value As Decimal)
   ''      mdecDebeBs = Value
   ''   End Set
   ''End Property

   ''Property HaberBs() As Decimal
   ''   Get
   ''      Return mdecHaberBs
   ''   End Get

   ''   Set(ByVal Value As Decimal)
   ''      mdecHaberBs = Value
   ''   End Set
   ''End Property

   ''Property DebeUs() As Decimal
   ''   Get
   ''      Return mdecDebeUs
   ''   End Get

   ''   Set(ByVal Value As Decimal)
   ''      mdecDebeUs = Value
   ''   End Set
   ''End Property

   ''Property HaberUs() As Decimal
   ''   Get
   ''      Return mdecHaberUs
   ''   End Get

   ''   Set(ByVal Value As Decimal)
   ''      mdecHaberUs = Value
   ''   End Set
   ''End Property

   Property Concilia() As Byte
      Get
         Return mbytConcilia
      End Get

      Set(ByVal Value As Byte)
         mbytConcilia = Value
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
      PlanId = 3
      PlanIdConcilia = 4
      EmpresaIdPlanId = 5
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompDetId = 1
      Grid = 2
      CompId = 3
      Fecha = 4
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

   Public Enum RowSumFilters As Byte
      DebeBs = 1
      HaberBs = 2
      DebeUs = 3
      HaberUs = 4
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
   Private mintRowSumFilter As RowSumFilters

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

   Property RowSumFilter() As RowSumFilters
      Get
         Return mintRowSumFilter
      End Get

      Set(ByVal Value As RowSumFilters)
         mintRowSumFilter = Value
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
      mstrTableName = "tblCompDetConcilia"
      mstrClassName = "clsCompDetConcilia"

      moConnection = New OleDbConnection
      VMNew = New clsCompDetConciliaVM
      VMOld = New clsCompDetConciliaVM

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
      mlngCompDetId = 0
      mlngEmpresaId = 0
      mlngCompId = 0
      mlngGestionId = 0
      mlngTipoCompId = 0
      mstrFecha = ""
      mlngPlanId = 0
      mstrFechaCon = ""
      mbytConcilia = 0

      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblCompDetConcilia.CompDetId,  "
            strSQL &= "    tblCompDetConcilia.EmpresaId,  "
            strSQL &= "    tblCompDetConcilia.CompId,  "
            strSQL &= "    tblCompDetConcilia.GestionId,  "
            strSQL &= "    tblCompDetConcilia.TipoCompId,  "
            strSQL &= "    tblCompDetConcilia.Fecha,  "
            strSQL &= "    tblCompDetConcilia.PlanId,  "
            strSQL &= "    tblCompDetConcilia.FechaCon,  "
            ''strSQL &= "    tblCompDetConcilia.MonedaId,  "
            ''strSQL &= "    tblCompDetConcilia.DebeOrg,  "
            ''strSQL &= "    tblCompDetConcilia.HaberOrg,  "
            ''strSQL &= "    tblCompDetConcilia.DebeBs,  "
            ''strSQL &= "    tblCompDetConcilia.HaberBs,  "
            ''strSQL &= "    tblCompDetConcilia.DebeUs,  "
            ''strSQL &= "    tblCompDetConcilia.HaberUs,  "
            strSQL &= "    tblCompDetConcilia.Concilia,  "
            strSQL &= "    tblCompDetConcilia.sLastUpdate_id,  "
            strSQL &= "    tblCompDetConcilia.dtLastUpdate_dt,  "
            strSQL &= "    tblCompDetConcilia.iConcurrency_id  "
            strSQL &= " FROM tblCompDetConcilia "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCompDetConcilia.CompDetId  "
            strSQL &= " FROM tblCompDetConcilia "

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
            strSQL = " WHERE  tblCompDetConcilia.CompDetId = " & NumberToField(mlngCompDetId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCompDetConcilia.CompId = " & NumberToField(mlngCompId)
            strSQL &= " AND  tblCompDetConcilia.PlanId = tblPlan.PlanId "

         Case WhereFilters.PlanId
            strSQL = " WHERE  tblCompDetConcilia.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDetConcilia.PlanId = " & NumberToField(mlngPlanId)

         Case WhereFilters.PlanIdConcilia
            strSQL = " WHERE  tblCompDetConcilia.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDetConcilia.PlanId = " & NumberToField(mlngPlanId)
            strSQL &= " AND  tblCompDetConcilia.Concilia = " & NumberToField(mbytConcilia)

         Case WhereFilters.EmpresaIdPlanId
            strSQL = " WHERE  tblCompDetConcilia.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompDetConcilia.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompDetConcilia.PlanId = " & NumberToField(mlngPlanId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompDetId
            strSQL = " ORDER BY tblCompDetConcilia.CompDetId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblCompDetConcilia.Concilia, tblCompDetConcilia.CompDetId "

         Case OrderByFilters.CompId
            strSQL = " ORDER BY tblCompDetConcilia.CompId "

         Case OrderByFilters.Fecha
            strSQL = " ORDER BY tblCompDetConcilia.Fecha, tblCompDetConcilia.CompId "

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

   Private Function RowSumSQL() As String
      Dim strSQL As String

      Select Case mintRowSumFilter
         Case RowSumFilters.DebeBs
            strSQL = "SELECT Sum(tblCompDetConcilia.DebeBs) As NumRecs FROM tblComp, " & mstrTableName
            strSQL &= WhereFilterGet()

         Case RowSumFilters.HaberBs
            strSQL = "SELECT Sum(tblCompDetConcilia.HaberBs) As NumRecs FROM tblComp, " & mstrTableName
            strSQL &= WhereFilterGet()

         Case RowSumFilters.DebeUs
            strSQL = "SELECT Sum(tblCompDetConcilia.DebeUs) As NumRecs FROM tblComp, " & mstrTableName
            strSQL &= WhereFilterGet()

         Case RowSumFilters.HaberUs
            strSQL = "SELECT Sum(tblCompDetConcilia.HaberUs) As NumRecs FROM tblComp, " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Protected Overrides Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO tblCompDetConcilia ("
            strSQL &= "CompDetId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CompId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoCompId, "
            strSQL &= "Fecha, "
            strSQL &= "PlanId, "
            strSQL &= "FechaCon, "
            ''strSQL &= "MonedaId, "
            ''strSQL &= "DebeOrg, "
            ''strSQL &= "HaberOrg, "
            ''strSQL &= "DebeBs, "
            ''strSQL &= "HaberBs, "
            ''strSQL &= "DebeUs, "
            ''strSQL &= "HaberUs, "
            strSQL &= "Concilia, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompDetId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= DateToField(mstrFechaCon) & ", "
            ''strSQL &= NumberToField(mlngMonedaId) & ", "
            ''strSQL &= DecimalToField(mdecDebeOrg) & ", "
            ''strSQL &= DecimalToField(mdecHaberOrg) & ", "
            ''strSQL &= DecimalToField(mdecDebeBs) & ", "
            ''strSQL &= DecimalToField(mdecHaberBs) & ", "
            ''strSQL &= DecimalToField(mdecDebeUs) & ", "
            ''strSQL &= DecimalToField(mdecHaberUs) & ", "
            strSQL &= NumberToField(mbytConcilia) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)


      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCompDetConcilia SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "FechaCon = " & DateToField(mstrFechaCon) & ", "
            ''strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            ''strSQL &= "DebeOrg = " & DecimalToField(mdecDebeOrg) & ", "
            ''strSQL &= "HaberOrg = " & DecimalToField(mdecHaberOrg) & ", "
            ''strSQL &= "DebeBs = " & DecimalToField(mdecDebeBs) & ", "
            ''strSQL &= "HaberBs = " & DecimalToField(mdecHaberBs) & ", "
            ''strSQL &= "DebeUs = " & DecimalToField(mdecDebeUs) & ", "
            ''strSQL &= "HaberUs = " & DecimalToField(mdecHaberUs) & ", "
            strSQL &= "Concilia = " & NumberToField(mbytConcilia) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompDetId = " & NumberToField(mlngCompDetId) & " "

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
               mlngCompDetId = ToLong(oDataRow("CompDetId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngPlanId = ToLong(oDataRow("PlanId"))
               mstrFechaCon = ToDateDMY(oDataRow("FechaCon"))
               ''mlngMonedaId = ToLong(oDataRow("MonedaId"))
               ''mdecDebeOrg = ToDecimal(oDataRow("DebeOrg"))
               ''mdecHaberOrg = ToDecimal(oDataRow("HaberOrg"))
               ''mdecDebeBs = ToDecimal(oDataRow("DebeBs"))
               ''mdecHaberBs = ToDecimal(oDataRow("HaberBs"))
               ''mdecDebeUs = ToDecimal(oDataRow("DebeUs"))
               ''mdecHaberUs = ToDecimal(oDataRow("HaberUs"))
               mbytConcilia = ToByte(oDataRow("Concilia"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompDetId = ToLong(oDataRow("CompDetId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompDetId = TableIDGet(mstrTableName, "CompDetId", moConnection)

         If mlngCompDetId = -1 Then
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

      If mlngEmpresaId = 0 Then
         strMsg &= "Empresa Inválida" & vbCrLf
      End If

      If mlngCompId = 0 Then
         strMsg &= "Comprobante ID Inválido" & vbCrLf
      End If

      If mlngGestionId = 0 Then
         strMsg &= "Gestión Inválida" & vbCrLf
      End If

      If mlngTipoCompId = 0 Then
         strMsg &= "Tipo de Comprobante Inválido" & vbCrLf
      End If

      If mlngPlanId = 0 Then
         strMsg &= "Seleccione la Cuenta" & vbCrLf
      End If

      ''If (mdecDebeOrg = 0) And (mdecHaberOrg = 0) Then
      ''   strMsg &= "Ingrese un Valor al Debe o al Haber" & vbCrLf

      ''ElseIf (mdecDebeOrg < 0) Or (mdecHaberOrg < 0) Then
      ''   strMsg &= "Valores Negativos Inválidos" & vbCrLf

      ''ElseIf (mdecDebeOrg > 0) And (mdecHaberOrg > 0) Then
      ''   strMsg &= "Debe y Haber no Pueden Tener Valores" & vbCrLf
      ''End If

      If mstrFecha.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha no puede ser nula" & vbCrLf
      End If

      ''If mlngMonedaId = 0 Then
      ''   strMsg &= "Seleccione la Moneda" & vbCrLf
      ''End If

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
         'strSQL &= " FROM tblCompDetConcilia "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblCompDetConcilia.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompDetConcilia.CompId = " & NumberToField(mlngCompId)
         '   strSQL &= " AND  tblCompDetConcilia.PlanId = " & NumberToField(mlngPlanId)
         'Else
         '   strSQL &= " WHERE  tblCompDetConcilia.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompDetConcilia.CompId = " & NumberToField(mlngCompId)
         '   strSQL &= " AND  tblCompDetConcilia.PlanId = " & NumberToField(mlngPlanId)
         '   strSQL &= " AND  tblCompDetConcilia.CompDetId <> " & NumberToField(mlngCompDetId)
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

   Public Function Insert() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Insert = False

      Try
         If Validate() Then
            If NoDuplicates(False) Then
               ''If GetNewPrimaryKey() Then
               Call OpenConection()

               oCommand = New OleDbCommand
               oCommand.CommandText = InsertSQL()
               oCommand.Connection = moConnection

               intRecordsAffected = oCommand.ExecuteNonQuery()

               If intRecordsAffected > 0 Then
                  VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngCompDetId)
                  Insert = True
               End If
               ''End If
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
            VMNew.ToChangeOpeUpdate(VMOld, clsTipoOpera.MODIFICA)
            UpdateOnly = True
         End If

      Catch exp As Exception
         Throw exp

      End Try
   End Function


   Public Function RowSum() As Decimal
      Dim oCommand As OleDbCommand
      Dim decRecordsAffected As Decimal

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowSumSQL()
         oCommand.Connection = moConnection

         decRecordsAffected = ToDecimal(oCommand.ExecuteScalar)

         Return decRecordsAffected

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

   End Function

End Class
