Imports System.Data
Imports System.Data.OleDb

Public Class clsPlanEEFF
   Implements IDisposable

   Public VMOld As New clsPlanEEFFVM
   Public VMNew As New clsPlanEEFFVM

   Private mlngPlanEEFFId As Long
   Private mlngEmpresaId As Long
   Private mlngTipoEEFFId As Long
   Private mlngPlanEEFFPadreId As Long
   Private mstrPlanEEFFDes As String
   Private mstrPlanEEFFCta As String
   'Private mlngPlanId As Long
   Private mlngNivel As Long
   Private mlngOrden As Long
   'Private mlngGrupo As Long
   Private mbytEsAna As Byte
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
   Property PlanEEFFId() As Long
      Get
         Return mlngPlanEEFFId
      End Get

      Set(ByVal Value As Long)
         mlngPlanEEFFId = Value
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

   Property TipoEEFFId() As Long
      Get
         Return mlngTipoEEFFId
      End Get

      Set(ByVal Value As Long)
         mlngTipoEEFFId = Value
      End Set
   End Property

   Property PlanEEFFPadreId() As Long
      Get
         Return mlngPlanEEFFPadreId
      End Get

      Set(ByVal Value As Long)
         mlngPlanEEFFPadreId = Value
      End Set
   End Property

   Property PlanEEFFDes() As String
      Get
         Return mstrPlanEEFFDes
      End Get

      Set(ByVal Value As String)
         mstrPlanEEFFDes = Value
      End Set
   End Property

   Property PlanEEFFCta() As String
      Get
         Return mstrPlanEEFFCta
      End Get

      Set(ByVal Value As String)
         mstrPlanEEFFCta = Value
      End Set
   End Property

   Property Nivel() As Long
      Get
         Return mlngNivel
      End Get

      Set(ByVal Value As Long)
         mlngNivel = Value
      End Set
   End Property

   Property Orden() As Long
      Get
         Return mlngOrden
      End Get

      Set(ByVal Value As Long)
         mlngOrden = Value
      End Set
   End Property

   Property EsAna() As Byte
      Get
         Return mbytEsAna
      End Get

      Set(ByVal Value As Byte)
         mbytEsAna = Value
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
      GridCheck = 3
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 2
      PlanEEFFPadreId = 3
      Orden = 4
      EsAna = 5
      GridEsAna = 6
      GridEstado = 7
      TipoEEFFIdOrdenNivel = 8
      EmpresaId = 9
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      PlanEEFFId = 1
      PlanEEFFDes = 2
      PlanEEFFCta = 3
      Grid = 4
      Orden = 5
      GridEstado = 6
      TipoNivel = 7
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

   Public Enum RowMaxFilters As Byte
      Orden = 1
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
   Private mintRowMaxFilter As RowMaxFilters

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

   Property RowMaxFilter() As RowMaxFilters
      Get
         Return mintRowMaxFilter
      End Get

      Set(ByVal Value As RowMaxFilters)
         mintRowMaxFilter = Value
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
      mstrTableName = "tblPlanEEFF"
      mstrClassName = "clsPlanEEFF"

      moConnection = New OleDbConnection
      VMNew = New clsPlanEEFFVM

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
      mlngPlanEEFFId = 0
      mlngEmpresaId = 0
      mlngTipoEEFFId = 0
      mlngPlanEEFFPadreId = 0
      mstrPlanEEFFDes = ""
      mstrPlanEEFFCta = ""
      ' mlngPlanId = 0
      mlngNivel = 0
      mlngOrden = 0
      ' mlngGrupo = 0
      mbytEsAna = 0
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
            strSQL &= "    tblPlanEEFF.PlanEEFFId,  "
            strSQL &= "    tblPlanEEFF.EmpresaId,  "
            strSQL &= "    tblPlanEEFF.TipoEEFFId,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFPadreId,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFDes,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFCta,  "
            'strSQL &= "    tblPlanEEFF.PlanId,  "
            strSQL &= "    tblPlanEEFF.Nivel,  "
            strSQL &= "    tblPlanEEFF.Orden,  "
            ' strSQL &= "    tblPlanEEFF.Grupo,  "
            strSQL &= "    tblPlanEEFF.EsAna,  "
            strSQL &= "    tblPlanEEFF.EstadoId,  "
            strSQL &= "    tblPlanEEFF.sLastUpdate_id,  "
            strSQL &= "    tblPlanEEFF.dtLastUpdate_dt,  "
            strSQL &= "    tblPlanEEFF.iConcurrency_id  "
            strSQL &= " FROM tblPlanEEFF "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblPlanEEFF.PlanEEFFId,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFDes  "
            strSQL &= " FROM tblPlanEEFF "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblPlanEEFF.PlanEEFFId,  "
            strSQL &= "    tblPlanEEFF.EmpresaId,  "
            strSQL &= "    tblPlanEEFF.TipoEEFFId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFPadreId,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFDes,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFCta,  "
            strSQL &= "    tblPlanEEFF.Nivel,  "
            strSQL &= "    tblPlanEEFF.Orden,  "
            strSQL &= "    tblPlanEEFF.EsAna,  "
            strSQL &= "    tblPlanEEFF.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlanEEFF, tblTipoComp, tblEstado "

         Case SelectFilters.GridCheck
            strSQL = " SELECT  "
            strSQL &= "    '0' As Sel,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFId,  "
            strSQL &= "    tblPlanEEFF.EmpresaId,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFCta,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFDes,  "
            strSQL &= "    tblPlanEEFF.TipoEEFFId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblPlanEEFF.PlanEEFFPadreId,  "
            strSQL &= "    tblPlanEEFF.Nivel,  "
            strSQL &= "    tblPlanEEFF.Orden,  "
            strSQL &= "    tblPlanEEFF.EsAna,  "
            strSQL &= "    tblPlanEEFF.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblPlanEEFF, tblTipoComp, tblEstado "

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
            strSQL = " WHERE  tblPlanEEFF.PlanEEFFId = " & NumberToField(mlngPlanEEFFId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanEEFF.TipoEEFFId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblPlanEEFF.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlanEEFF.PlanEEFFPadreId = " & NumberToField(mlngPlanEEFFPadreId)

         Case WhereFilters.PlanEEFFPadreId
            strSQL = " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanEEFF.PlanEEFFPadreId = " & NumberToField(mlngPlanEEFFPadreId)
            If mlngPlanEEFFId <> 0 Then strSQL &= " AND  tblPlanEEFF.PlanEEFFId <> " & NumberToField(mlngPlanEEFFId)

         Case WhereFilters.Orden
            strSQL = " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanEEFF.PlanEEFFPadreId = " & NumberToField(mlngPlanEEFFPadreId)
            strSQL &= " AND  tblPlanEEFF.Orden = " & NumberToField(mlngOrden)

         Case WhereFilters.GridEsAna
            strSQL = " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanEEFF.TipoEEFFId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblPlanEEFF.EstadoId = tblEstado.EstadoId "
            strSQL &= " AND  tblPlanEEFF.EsAna = " & NumberToField(mbytEsAna)

         Case WhereFilters.GridEstado
            strSQL = " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            'strSQL &= " AND  tblPlanEEFF.TipoEEFFId = " & NumberToField(mlngTipoEEFFId)
            If mlngPlanEEFFPadreId > 0 Then strSQL &= " AND  tblPlanEEFF.PlanEEFFPadreId = " & NumberToField(mlngPlanEEFFPadreId)
            If mlngNivel > 0 Then strSQL &= " AND  tblPlanEEFF.Nivel = " & NumberToField(mlngNivel)

         Case WhereFilters.EsAna
            strSQL = " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanEEFF.EsAna = " & NumberToField(mbytEsAna)

         Case WhereFilters.TipoEEFFIdOrdenNivel
            strSQL = " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngTipoEEFFId <> 0 Then strSQL &= " AND  tblPlanEEFF.TipoEEFFId = " & NumberToField(mlngTipoEEFFId)
            If mlngOrden <> 0 Then strSQL &= " AND  tblPlanEEFF.Orden = " & NumberToField(mlngOrden)
            If mlngNivel <> 0 Then strSQL &= " AND  tblPlanEEFF.Nivel = " & NumberToField(mlngNivel)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.PlanEEFFId
            strSQL = " ORDER BY tblPlanEEFF.PlanEEFFId "

         Case OrderByFilters.PlanEEFFDes
            strSQL = " ORDER BY tblPlanEEFF.PlanEEFFDes "

         Case OrderByFilters.PlanEEFFCta
            strSQL = " ORDER BY tblPlanEEFF.PlanEEFFCta "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblPlanEEFF.PlanEEFFDes "

         Case OrderByFilters.Orden
            strSQL = " ORDER BY tblPlanEEFF.Orden, tblPlanEEFF.PlanEEFFCta "

         Case OrderByFilters.TipoNivel
            strSQL = " ORDER BY tblPlanEEFF.TipoEEFFId, tblPlanEEFF.Nivel "

            'Case OrderByFilters.GridEstado
            '   strSQL = " ORDER BY tblPlanEEFF.Orden "
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

   Private Function RowMaxSQL() As String
      Dim strSQL As String

      Select Case mintRowMaxFilter
         Case RowMaxFilters.Orden
            strSQL = "SELECT Max(Orden) FROM " & mstrTableName
            strSQL &= WhereFilterGet()

      End Select

      Return strSQL
   End Function

   Private Function InsertSQL() As String
      Dim strSQL As String

      Select Case mintInsertFilter
         Case InsertFilters.All
            strSQL = "INSERT INTO tblPlanEEFF ("
            strSQL &= "PlanEEFFId, "
            strSQL &= "EmpresaId, "
            strSQL &= "TipoEEFFId, "
            strSQL &= "PlanEEFFPadreId, "
            strSQL &= "PlanEEFFDes, "
            strSQL &= "PlanEEFFCta, "
            ' strSQL &= "PlanId, "
            strSQL &= "Nivel, "
            strSQL &= "Orden, "
            ' strSQL &= "Grupo, "
            strSQL &= "EsAna, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngPlanEEFFId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngTipoEEFFId) & ", "
            strSQL &= NumberToField(mlngPlanEEFFPadreId) & ", "
            strSQL &= StringToField(mstrPlanEEFFDes) & ", "
            strSQL &= StringToField(mstrPlanEEFFCta) & ", "
            '  strSQL &= NumberToField(mlngPlanId) & ", "
            strSQL &= NumberToField(mlngNivel) & ", "
            strSQL &= NumberToField(mlngOrden) & ", "
            '   strSQL &= NumberToField(mlngGrupo) & ", "
            strSQL &= NumberToField(mbytEsAna) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblPlanEEFF SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "TipoEEFFId = " & NumberToField(mlngTipoEEFFId) & ", "
            strSQL &= "PlanEEFFPadreId = " & NumberToField(mlngPlanEEFFPadreId) & ", "
            strSQL &= "PlanEEFFDes = " & StringToField(mstrPlanEEFFDes) & ", "
            strSQL &= "PlanEEFFCta = " & StringToField(mstrPlanEEFFCta) & ", "
            ' strSQL &= "PlanId = " & NumberToField(mlngPlanId) & ", "
            strSQL &= "Nivel = " & NumberToField(mlngNivel) & ", "
            strSQL &= "Orden = " & NumberToField(mlngOrden) & ", "
            ' strSQL &= "Grupo = " & NumberToField(mlngGrupo) & ", "
            strSQL &= "EsAna = " & NumberToField(mbytEsAna) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " PlanEEFFId = " & NumberToField(mlngPlanEEFFId) & " "

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
               mlngPlanEEFFId = ToLong(oDataRow("PlanEEFFId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngTipoEEFFId = ToLong(oDataRow("TipoEEFFId"))
               mlngPlanEEFFPadreId = ToLong(oDataRow("PlanEEFFPadreId"))
               mstrPlanEEFFDes = ToStr(oDataRow("PlanEEFFDes"))
               mstrPlanEEFFCta = ToStr(oDataRow("PlanEEFFCta"))
               '  mlngPlanId = ToLong(oDataRow("PlanId"))
               mlngNivel = ToLong(oDataRow("Nivel"))
               mlngOrden = ToLong(oDataRow("Orden"))
               '    mlngGrupo = ToLong(oDataRow("Grupo"))
               mbytEsAna = ToByte(oDataRow("EsAna"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngPlanEEFFId = ToLong(oDataRow("PlanEEFFId"))
               mstrPlanEEFFDes = ToStr(oDataRow("PlanEEFFDes"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngPlanEEFFId = TableIDGet(mstrTableName, "PlanEEFFId", moConnection)

         If mlngPlanEEFFId = -1 Then
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

      If mlngEmpresaId = 0 Then
         strMsg &= "Empresa Inválida" & vbCrLf
      End If

      'If mstrPlanEEFFDes.Length() = 0 Then
      '   strMsg &= "Descripción de Cuenta Inválida" & vbCrLf
      'End If

      'If mstrPlanEEFFCta.Length() = 0 Then
      '   strMsg &= "Código de Cuenta Inválido" & vbCrLf
      'End If

      'If mlngPlanEEFFPadreId = 0 Then
      '   strMsg &= "Cuenta Padre Inválida" & vbCrLf
      'End If

      If mlngNivel = 0 Then
         strMsg &= "Nivel Inválido" & vbCrLf
      End If

      If mlngOrden = 0 Then
         strMsg &= "Orden Inválido" & vbCrLf
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
         strSQL = " SELECT  "
         strSQL &= " Count(*) As NumRecs  "
         strSQL &= " FROM tblPlanEEFF "

         If Not boolReplace Then
            strSQL &= " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanEEFF.PlanEEFFCta = " & StringToField(mstrPlanEEFFCta)
            strSQL &= " AND  tblPlanEEFF.PlanEEFFCta <> '' "
            strSQL &= " AND  tblPlanEEFF.EstadoId = " & NumberToField(mlngEstadoId)
         Else
            strSQL &= " WHERE  tblPlanEEFF.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblPlanEEFF.PlanEEFFCta = " & StringToField(mstrPlanEEFFCta)
            strSQL &= " AND  tblPlanEEFF.PlanEEFFCta <> '' "
            strSQL &= " AND  tblPlanEEFF.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblPlanEEFF.PlanEEFFId <> " & NumberToField(mlngPlanEEFFId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngPlanEEFFId)
                     Insert = True
                  End If
               End If
            Else
               Throw New Exception("Registro Duplicado, Ya Existe una Cuenta con ese Código y o Descripción")
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
               Throw New Exception("Registro Duplicado, Ya Existe una Cuenta con ese Código y o Descripción")
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
            VMNew.ToDeleteOpe()
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

   Public Function RowMax() As Integer
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      Try
         Call OpenConection()

         oCommand = New OleDbCommand
         oCommand.CommandText = RowMaxSQL()
         oCommand.Connection = moConnection

         intRecordsAffected = ToInteger(oCommand.ExecuteScalar)

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

   Public Sub CloneVM(ByRef oVM As clsPlanEEFFVM, ByVal Name As String, ByVal Text As String)
      If clsAppInfo.RegistrarBitacora Then
         oVM = New clsPlanEEFFVM
         oVM.EmpresaId = mlngEmpresaId
         oVM.TipoEEFFId = mlngTipoEEFFId
         oVM.PlanEEFFPadreId = mlngPlanEEFFPadreId
         oVM.PlanEEFFDes = mstrPlanEEFFDes
         oVM.PlanEEFFCta = mstrPlanEEFFCta
         oVM.Nivel = mlngNivel
         oVM.Orden = mlngOrden
         oVM.EsAna = mbytEsAna
         oVM.EstadoId = mlngEstadoId
         oVM.FormName = Name
         oVM.FormText = Text
      End If
   End Sub

End Class
