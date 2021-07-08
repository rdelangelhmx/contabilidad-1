Imports System.Data
Imports System.Data.OleDb

Public Class clsRecibo
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsReciboVM
   Public VMNew As New clsReciboVM

   Private mlngReciboId As Long
   Private mlngEmpresaId As Long
   Private mlngCompId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompId As Long
   'Private mlngCompNro As Long
   Private mstrFecha As String
   Private mlngReciboNro As Long
   Private mstrEntregadoA As String
   Private mstrPorConcepto As String
   Private mstrGlosa As String
   Private mlngMonedaId As Long
   Private mdecMonto As Decimal
   Private mlngRespaldoId As Long
   Private mlngRespaldoNro As Long
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   Private mlngTipoOpera As Long
   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property ReciboId() As Long
      Get
         Return mlngReciboId
      End Get

      Set(ByVal Value As Long)
         mlngReciboId = Value
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

   'Property CompNro() As Long
   '   Get
   '      Return mlngCompNro
   '   End Get

   '   Set(ByVal Value As Long)
   '      mlngCompNro = Value
   '   End Set
   'End Property

   Property Fecha() As String
      Get
         Return mstrFecha
      End Get

      Set(ByVal Value As String)
         mstrFecha = Value
      End Set
   End Property

   Property ReciboNro() As Long
      Get
         Return mlngReciboNro
      End Get

      Set(ByVal Value As Long)
         mlngReciboNro = Value
      End Set
   End Property

   Property EntregadoA() As String
      Get
         Return mstrEntregadoA
      End Get

      Set(ByVal Value As String)
         mstrEntregadoA = Value
      End Set
   End Property

   Property PorConcepto() As String
      Get
         Return mstrPorConcepto
      End Get

      Set(ByVal Value As String)
         mstrPorConcepto = Value
      End Set
   End Property

   Property Glosa() As String
      Get
         Return mstrGlosa
      End Get

      Set(ByVal Value As String)
         mstrGlosa = Value
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

   Property Monto() As Decimal
      Get
         Return mdecMonto
      End Get

      Set(ByVal Value As Decimal)
         mdecMonto = Value
      End Set
   End Property

   Property RespaldoId() As Long
      Get
         Return mlngRespaldoId
      End Get

      Set(ByVal Value As Long)
         mlngRespaldoId = Value
      End Set
   End Property

   Property RespaldoNro() As Long
      Get
         Return mlngRespaldoNro
      End Get

      Set(ByVal Value As Long)
         mlngRespaldoNro = Value
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
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      Grid = 3
      Report = 4
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      ReciboId = 1
      Grid = 2
      Report = 3
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      CompId = 1
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
      mstrTableName = "tblRecibo"
      mstrClassName = "clsRecibo"

      moConnection = New OleDbConnection
      VMNew = New clsReciboVM

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
      mlngReciboId = 0
      mlngEmpresaId = 0
      mlngCompId = 0
      mlngGestionId = 0
      mlngTipoCompId = 0
      'mlngCompNro = 0
      mstrFecha = ""
      mlngReciboNro = 0
      mstrEntregadoA = ""
      mstrPorConcepto = ""
      mstrGlosa = ""
      mlngMonedaId = 0
      mdecMonto = 0
      mlngRespaldoId = 0
      mlngRespaldoNro = 0
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
            strSQL &= "    tblRecibo.ReciboId,  "
            strSQL &= "    tblRecibo.EmpresaId,  "
            strSQL &= "    tblRecibo.CompId,  "
            strSQL &= "    tblRecibo.GestionId,  "
            strSQL &= "    tblRecibo.TipoCompId,  "
            'strSQL &= "    tblRecibo.CompNro,  "
            strSQL &= "    tblRecibo.Fecha,  "
            strSQL &= "    tblRecibo.ReciboNro,  "
            strSQL &= "    tblRecibo.EntregadoA,  "
            strSQL &= "    tblRecibo.PorConcepto,  "
            strSQL &= "    tblRecibo.Glosa,  "
            strSQL &= "    tblRecibo.MonedaId,  "
            strSQL &= "    tblRecibo.Monto,  "
            strSQL &= "    tblRecibo.RespaldoId,  "
            strSQL &= "    tblRecibo.RespaldoNro,  "
            strSQL &= "    tblRecibo.EstadoId,  "
            strSQL &= "    tblRecibo.sLastUpdate_id,  "
            strSQL &= "    tblRecibo.dtLastUpdate_dt,  "
            strSQL &= "    tblRecibo.iConcurrency_id  "
            strSQL &= " FROM tblRecibo "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblRecibo.ReciboId,  "
            strSQL &= "    tblRecibo.EntregadoA  "
            strSQL &= " FROM tblRecibo "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblRecibo.ReciboId,  "
            strSQL &= "    tblRecibo.Fecha,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblRecibo.ReciboNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblRecibo.Monto,  "
            strSQL &= "    tblRecibo.EntregadoA,  "
            strSQL &= "    tblRecibo.PorConcepto,  "
            strSQL &= "    tblRecibo.Glosa,  "
            strSQL &= "    tblRespaldo.RespaldoId,  "
            strSQL &= "    tblRespaldo.RespaldoDes,  "
            strSQL &= "    tblRecibo.RespaldoNro,  "
            strSQL &= "    tblRecibo.CompId,  "
            strSQL &= "    tblComp.CompNro,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblRecibo, tblTipoComp, tblComp, tblMoneda, tblRespaldo, tblEstado "

         Case SelectFilters.Report
            strSQL = " SELECT  "
            strSQL &= "    tblRecibo.ReciboId,  "
            strSQL &= "    tblRecibo.Fecha,  "
            strSQL &= "    tblRecibo.TipoCompId,  "
            strSQL &= "    tblRecibo.ReciboNro,  "
            strSQL &= "    tblMoneda.MonedaId,  "
            strSQL &= "    tblMoneda.MonedaDes,  "
            strSQL &= "    tblRecibo.Monto,  "
            strSQL &= "    tblRecibo.EntregadoA,  "
            strSQL &= "    tblRecibo.PorConcepto,  "
            strSQL &= "    tblRecibo.Glosa,  "
            strSQL &= "    tblRespaldo.RespaldoId,  "
            strSQL &= "    tblRespaldo.RespaldoDes,  "
            strSQL &= "    tblRecibo.RespaldoNro  "
            strSQL &= " FROM tblRecibo, tblMoneda, tblRespaldo "

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
            strSQL = " WHERE  tblRecibo.ReciboId = " & NumberToField(mlngReciboId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblRecibo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblRecibo.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblRecibo.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblRecibo.CompId = tblComp.CompId "
            strSQL &= " AND  tblRecibo.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblRecibo.RespaldoId = tblRespaldo.RespaldoId "
            strSQL &= " AND  tblRecibo.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.Report
            strSQL = " WHERE  tblRecibo.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblRecibo.ReciboId = " & NumberToField(mlngReciboId)
            strSQL &= " AND  tblRecibo.MonedaId = tblMoneda.MonedaId "
            strSQL &= " AND  tblRecibo.RespaldoId = tblRespaldo.RespaldoId "

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.ReciboId
            strSQL = " ORDER BY tblRecibo.ReciboId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblRecibo.ReciboId DESC "

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
            strSQL = "INSERT INTO tblRecibo ("
            strSQL &= "ReciboId, "
            strSQL &= "EmpresaId, "
            strSQL &= "CompId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoCompId, "
            'strSQL &= "CompNro, "
            strSQL &= "Fecha, "
            strSQL &= "ReciboNro, "
            strSQL &= "EntregadoA, "
            strSQL &= "PorConcepto, "
            strSQL &= "Glosa, "
            strSQL &= "MonedaId, "
            strSQL &= "Monto, "
            strSQL &= "RespaldoId, "
            strSQL &= "RespaldoNro, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngReciboId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngCompId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            'strSQL &= NumberToField(mlngCompNro) & ", "
            strSQL &= DateToField(mstrFecha) & ", "
            strSQL &= NumberToField(mlngReciboNro) & ", "
            strSQL &= StringToField(mstrEntregadoA) & ", "
            strSQL &= StringToField(mstrPorConcepto) & ", "
            strSQL &= StringToField(mstrGlosa) & ", "
            strSQL &= NumberToField(mlngMonedaId) & ", "
            strSQL &= DecimalToField(mdecMonto) & ", "
            strSQL &= NumberToField(mlngRespaldoId) & ", "
            strSQL &= NumberToField(mlngRespaldoNro) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblRecibo SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            'strSQL &= "CompNro = " & NumberToField(mlngCompNro) & ", "
            strSQL &= "Fecha = " & DateToField(mstrFecha) & ", "
            strSQL &= "ReciboNro = " & NumberToField(mlngReciboNro) & ", "
            strSQL &= "EntregadoA = " & StringToField(mstrEntregadoA) & ", "
            strSQL &= "PorConcepto = " & StringToField(mstrPorConcepto) & ", "
            strSQL &= "Glosa = " & StringToField(mstrGlosa) & ", "
            strSQL &= "MonedaId = " & NumberToField(mlngMonedaId) & ", "
            strSQL &= "Monto = " & DecimalToField(mdecMonto) & ", "
            strSQL &= "RespaldoId = " & NumberToField(mlngRespaldoId) & ", "
            strSQL &= "RespaldoNro = " & NumberToField(mlngRespaldoNro) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " ReciboId = " & NumberToField(mlngReciboId) & " "

         Case UpdateFilters.CompId
            strSQL = "UPDATE tblRecibo SET "
            strSQL &= "CompId = " & NumberToField(mlngCompId) & " "
            'strSQL &= "CompNro = " & NumberToField(mlngCompNro) & " "
            strSQL &= " WHERE "
            strSQL &= " ReciboId = " & NumberToField(mlngReciboId) & " "

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
               mlngReciboId = ToLong(oDataRow("ReciboId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngCompId = ToLong(oDataRow("CompId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               'mlngCompNro = ToLong(oDataRow("CompNro"))
               mstrFecha = ToDateDMY(oDataRow("Fecha"))
               mlngReciboNro = ToLong(oDataRow("ReciboNro"))
               mstrEntregadoA = ToStr(oDataRow("EntregadoA"))
               mstrPorConcepto = ToStr(oDataRow("PorConcepto"))
               mstrGlosa = ToStr(oDataRow("Glosa"))
               mlngMonedaId = ToLong(oDataRow("MonedaId"))
               mdecMonto = ToDecimal(oDataRow("Monto"))
               mlngRespaldoId = ToLong(oDataRow("RespaldoId"))
               mlngRespaldoNro = ToLong(oDataRow("RespaldoNro"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngReciboId = ToLong(oDataRow("ReciboId"))
               mstrEntregadoA = ToStr(oDataRow("EntregadoA"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngReciboId = TableIDGet(mstrTableName, "ReciboId", moConnection)

         If mlngReciboId = -1 Then
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

      If mlngGestionId = 0 Then
         strMsg &= "Gestión Inválida" & vbCrLf
      End If

      If mlngTipoCompId = 0 Then
         strMsg &= "Tipo de Comprobante Inválido" & vbCrLf
      End If

      If mstrFecha.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFecha)) Then
            strMsg &= "Fecha no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha no puede ser nula" & vbCrLf
      End If

      If mstrPorConcepto.Trim() = String.Empty Then
         strMsg &= "Ingrese la Razón Social" & vbCrLf
      End If

      If mlngReciboNro = 0 Then
         strMsg &= "Ingrese el Número de Recibo" & vbCrLf
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
         'strSQL &= " FROM tblRecibo "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblRecibo.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblRecibo.ReciboNro = " & NumberToField(mlngReciboNro)
         '   strSQL &= " AND  tblRecibo.Glosa = " & StringToField(mstrGlosa)
         '   strSQL &= " AND  tblRecibo.CompNro = " & NumberToField(mlngCompNro)
         'Else
         '   strSQL &= " WHERE  tblRecibo.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblRecibo.ReciboNro = " & NumberToField(mlngReciboNro)
         '   strSQL &= " AND  tblRecibo.Glosa = " & StringToField(mstrGlosa)
         '   strSQL &= " AND  tblRecibo.CompNro = " & NumberToField(mlngCompNro)
         '   strSQL &= " AND  tblRecibo.ReciboId <> " & NumberToField(mlngReciboId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngReciboId)
                     Insert = True
                  End If
               End If
            Else
               Throw New Exception("Recibo Duplicado")
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
               Throw New Exception("Recibo Duplicado")
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
