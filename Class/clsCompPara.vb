Imports System.Data
Imports System.Data.OleDb

Public Class clsCompPara
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsCompParaVM
   Public VMNew As New clsCompParaVM

   Private mlngCompParaId As Long
   Private mlngEmpresaId As Long
   Private mlngGestionId As Long
   Private mlngTipoCompId As Long
   Private mlngNroIni As Long
   Private mlngNroActual As Long
   Private mlngNroIniFis As Long
   Private mlngNroActualFis As Long
   Private mbytNroAuto As Byte
   Private mbytNroAutoGestion As Byte
   Private mstrFirma As String
   Private mlngTipoHojaId As Long
   Private mlngTipoImpresionId As Long
   Private mlngTipoRespImpId As Long
   Private mlngRowsMax As Long
   Private mlngEstadoId As Long
   Private mbytBloqueoAuto As Byte
   Private mbytEncabezadoPorHoja As Byte
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property CompParaId() As Long
      Get
         Return mlngCompParaId
      End Get

      Set(ByVal Value As Long)
         mlngCompParaId = Value
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

   Property NroAuto() As Byte
      Get
         Return mbytNroAuto
      End Get

      Set(ByVal Value As Byte)
         mbytNroAuto = Value
      End Set
   End Property

   Property NroAutoGestion() As Byte
      Get
         Return mbytNroAutoGestion
      End Get

      Set(ByVal Value As Byte)
         mbytNroAutoGestion = Value
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

   Property TipoImpresionId() As Long
      Get
         Return mlngTipoImpresionId
      End Get

      Set(ByVal Value As Long)
         mlngTipoImpresionId = Value
      End Set
   End Property

   Property TipoRespImpId() As Long
      Get
         Return mlngTipoRespImpId
      End Get

      Set(ByVal Value As Long)
         mlngTipoRespImpId = Value
      End Set
   End Property

   Property RowsMax() As Long
      Get
         Return mlngRowsMax
      End Get

      Set(ByVal Value As Long)
         mlngRowsMax = Value
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

   Property BloqueoAuto() As Byte
      Get
         Return mbytBloqueoAuto
      End Get

      Set(ByVal Value As Byte)
         mbytBloqueoAuto = Value
      End Set
   End Property

   Property EncabezadoPorHoja() As Byte
      Get
         Return mbytEncabezadoPorHoja
      End Get
      Set(ByVal value As Byte)
         mbytEncabezadoPorHoja = value
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
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      CompParaId = 1
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
      mstrTableName = "tblCompPara"
      mstrClassName = "clsCompPara"

      moConnection = New OleDbConnection
      VMNew = New clsCompParaVM

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
      mlngCompParaId = 0
      mlngEmpresaId = 0
      mlngGestionId = 0
      mlngTipoCompId = 0
      mlngNroIni = 0
      mlngNroActual = 0
      mlngNroIniFis = 0
      mlngNroActualFis = 0
      mbytNroAuto = 0
      mbytNroAutoGestion = 0
      mstrFirma = ""
      mlngTipoHojaId = 0
      mlngTipoImpresionId = 0
      mlngTipoRespImpId = 0
      mlngRowsMax = 0
      mlngEstadoId = 0
      mbytBloqueoAuto = 0
      mbytEncabezadoPorHoja = 0
      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblCompPara.CompParaId,  "
            strSQL &= "    tblCompPara.EmpresaId,  "
            strSQL &= "    tblCompPara.GestionId,  "
            strSQL &= "    tblCompPara.TipoCompId,  "
            strSQL &= "    tblCompPara.NroIni,  "
            strSQL &= "    tblCompPara.NroActual,  "
            strSQL &= "    tblCompPara.NroIniFis,  "
            strSQL &= "    tblCompPara.NroActualFis,  "
            strSQL &= "    tblCompPara.NroAuto,  "
            strSQL &= "    tblCompPara.NroAutoGestion,  "
            strSQL &= "    tblCompPara.Firma,  "
            strSQL &= "    tblCompPara.TipoHojaId,  "
            strSQL &= "    tblCompPara.TipoImpresionId,  "
            strSQL &= "    tblCompPara.TipoRespImpId,  "
            strSQL &= "    tblCompPara.RowsMax,  "
            strSQL &= "    tblCompPara.EstadoId,  "
            strSQL &= "    tblCompPara.BloqueoAuto,  "
            strSQL &= "    tblCompPara.EncabezadoPorHoja,  "
            strSQL &= "    tblCompPara.sLastUpdate_id,  "
            strSQL &= "    tblCompPara.dtLastUpdate_dt,  "
            strSQL &= "    tblCompPara.iConcurrency_id  "
            strSQL &= " FROM tblCompPara "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblCompPara.CompParaId  "
            strSQL &= " FROM tblCompPara "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblCompPara.CompParaId,  "
            strSQL &= "    tblCompPara.EmpresaId,  "
            strSQL &= "    tblGestion.GestionId,  "
            strSQL &= "    tblGestion.Gestion,  "
            strSQL &= "    tblTipoComp.TipoCompId,  "
            strSQL &= "    tblTipoComp.TipoCompDes,  "
            strSQL &= "    tblCompPara.NroIni,  "
            strSQL &= "    tblCompPara.NroActual,  "
            strSQL &= "    tblCompPara.NroIniFis,  "
            strSQL &= "    tblCompPara.NroActualFis,  "
            strSQL &= "    tblCompPara.NroAuto,  "
            strSQL &= "    tblCompPara.NroAutoGestion,  "
            strSQL &= "    tblCompPara.Firma,  "
            strSQL &= "    tblTipoHoja.TipoHojaId,  "
            strSQL &= "    tblTipoHoja.TipoHojaDes,  "
            strSQL &= "    tblTipoImpresion.TipoImpresionId,  "
            strSQL &= "    tblTipoImpresion.TipoImpresionDes,  "
            strSQL &= "    tblTipoRespImp.TipoRespImpId,  "
            strSQL &= "    tblTipoRespImp.TipoRespImpDes,  "
            strSQL &= "    tblCompPara.RowsMax,  "
            strSQL &= "    tblCompPara.BloqueoAuto,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblCompPara, tblGestion, tblTipoComp, tblTipoHoja, tblTipoImpresion, tblTipoRespImp, tblEstado "

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
            strSQL = " WHERE  tblCompPara.CompParaId = " & NumberToField(mlngCompParaId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblCompPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPara.GestionId = " & NumberToField(mlngGestionId)
            strSQL &= " AND  tblCompPara.GestionId = tblGestion.GestionId "
            strSQL &= " AND  tblCompPara.TipoCompId = tblTipoComp.TipoCompId "
            strSQL &= " AND  tblCompPara.TipoHojaId = tblTipoHoja.TipoHojaId "
            strSQL &= " AND  tblCompPara.TipoImpresionId = tblTipoImpresion.TipoImpresionId "
            strSQL &= " AND  tblCompPara.TipoRespImpId = tblTipoRespImp.TipoRespImpId "
            strSQL &= " AND  tblCompPara.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblCompPara.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.TipoCompId
            strSQL = " WHERE  tblCompPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPara.TipoCompId = " & NumberToField(mlngTipoCompId)
            strSQL &= " AND  tblCompPara.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.GestionId
            strSQL = " WHERE  tblCompPara.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblCompPara.GestionId = " & NumberToField(mlngGestionId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblCompPara.EmpresaId = " & NumberToField(mlngEmpresaId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.CompParaId
            strSQL = " ORDER BY tblCompPara.CompParaId "

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
            strSQL = "INSERT INTO tblCompPara ("
            strSQL &= "CompParaId, "
            strSQL &= "EmpresaId, "
            strSQL &= "GestionId, "
            strSQL &= "TipoCompId, "
            strSQL &= "NroIni, "
            strSQL &= "NroActual, "
            strSQL &= "NroIniFis, "
            strSQL &= "NroActualFis, "
            strSQL &= "NroAuto, "
            strSQL &= "NroAutoGestion, "
            strSQL &= "Firma, "
            strSQL &= "TipoHojaId, "
            strSQL &= "TipoImpresionId, "
            strSQL &= "TipoRespImpId, "
            strSQL &= "RowsMax, "
            strSQL &= "EstadoId, "
            strSQL &= "BloqueoAuto, "
            strSQL &= "EncabezadoPorHoja, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngCompParaId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngTipoCompId) & ", "
            strSQL &= NumberToField(mlngNroIni) & ", "
            strSQL &= NumberToField(mlngNroActual) & ", "
            strSQL &= NumberToField(mlngNroIniFis) & ", "
            strSQL &= NumberToField(mlngNroActualFis) & ", "
            strSQL &= NumberToField(mbytNroAuto) & ", "
            strSQL &= NumberToField(mbytNroAutoGestion) & ", "
            strSQL &= StringToField(mstrFirma) & ", "
            strSQL &= NumberToField(mlngTipoHojaId) & ", "
            strSQL &= NumberToField(mlngTipoImpresionId) & ", "
            strSQL &= NumberToField(mlngTipoRespImpId) & ", "
            strSQL &= NumberToField(mlngRowsMax) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= NumberToField(mbytBloqueoAuto) & ", "
            strSQL &= NumberToField(mbytEncabezadoPorHoja) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblCompPara SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "TipoCompId = " & NumberToField(mlngTipoCompId) & ", "
            strSQL &= "NroIni = " & NumberToField(mlngNroIni) & ", "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual) & ", "
            strSQL &= "NroIniFis = " & NumberToField(mlngNroIniFis) & ", "
            strSQL &= "NroActualFis = " & NumberToField(mlngNroActualFis) & ", "
            strSQL &= "NroAuto = " & NumberToField(mbytNroAuto) & ", "
            strSQL &= "NroAutoGestion = " & NumberToField(mbytNroAutoGestion) & ", "
            strSQL &= "Firma = " & "'" & mstrFirma & "', "
            strSQL &= "TipoHojaId = " & NumberToField(mlngTipoHojaId) & ", "
            strSQL &= "TipoImpresionId = " & NumberToField(mlngTipoImpresionId) & ", "
            strSQL &= "TipoRespImpId = " & NumberToField(mlngTipoRespImpId) & ", "
            strSQL &= "RowsMax = " & NumberToField(mlngRowsMax) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= "BloqueoAuto = " & NumberToField(mbytBloqueoAuto) & ", "
            strSQL &= "EncabezadoPorHoja = " & NumberToField(mbytEncabezadoPorHoja) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompParaId = " & NumberToField(mlngCompParaId) & " "

         Case UpdateFilters.NroActual
            strSQL = "UPDATE tblCompPara SET "
            strSQL &= "NroActual = " & NumberToField(mlngNroActual) & ", "
            strSQL &= "NroActualFis = " & NumberToField(mlngNroActualFis) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " CompParaId = " & NumberToField(mlngCompParaId) & " "

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
               mlngCompParaId = ToLong(oDataRow("CompParaId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngTipoCompId = ToLong(oDataRow("TipoCompId"))
               mlngNroIni = ToLong(oDataRow("NroIni"))
               mlngNroActual = ToLong(oDataRow("NroActual"))
               mlngNroIniFis = ToLong(oDataRow("NroIniFis"))
               mlngNroActualFis = ToLong(oDataRow("NroActualFis"))
               mbytNroAuto = ToByte(oDataRow("NroAuto"))
               mbytNroAutoGestion = ToByte(oDataRow("NroAutoGestion"))
               mstrFirma = ToStr(oDataRow("Firma"))
               mlngTipoHojaId = ToLong(oDataRow("TipoHojaId"))
               mlngTipoImpresionId = ToLong(oDataRow("TipoImpresionId"))
               mlngTipoRespImpId = ToLong(oDataRow("TipoRespImpId"))
               mlngRowsMax = ToLong(oDataRow("RowsMax"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mbytBloqueoAuto = ToByte(oDataRow("BloqueoAuto"))
               mbytEncabezadoPorHoja = ToByte(oDataRow("EncabezadoPorHoja"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngCompParaId = ToLong(oDataRow("CompParaId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngCompParaId = TableIDGet(mstrTableName, "CompParaId", moConnection)

         If mlngCompParaId = -1 Then
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

      'If mstrCompParaDes.Length() = 0 Then
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
         'strSQL &= " FROM tblCompPara "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblCompPara.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompPara.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  tblCompPara.NroActual = " & NumberToField(mlngNroActual)
         'Else
         '   strSQL &= " WHERE  tblCompPara.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  tblCompPara.GestionId = " & NumberToField(mlngGestionId)
         '   strSQL &= " AND  tblCompPara.NroActual = " & NumberToField(mlngNroActual)
         '   strSQL &= " AND  tblCompPara.CompParaId <> " & NumberToField(mlngCompParaId)
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
