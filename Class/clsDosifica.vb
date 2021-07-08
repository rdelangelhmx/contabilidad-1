Imports System.Data
Imports System.Data.OleDb

Public Class clsDosifica
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsDosificaVM
   Public VMNew As New clsDosificaVM

   Private mlngDosificaId As Long
   Private mlngEmpresaId As Long
   Private mlngSucursalId As Long
   Private mlngTipoDosificaId As Long
   Private mstrNroAutorizacion As String
   Private mstrLlaveDosifica As String
   Private mlngNumeroSFC As Long
   Private mlngNumeroIni As Long
   Private mlngNumeroFin As Long
   Private mlngNumeroActual As Long
   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private mlngDosificaLeyId As Long
   Private mbytImpDosificaLey As Byte
   Private mlngTipoImpresionId As Long
   Private mlngTipoFormImpId As Long
   Private mlngNroCopia As Long
   Private mbytPrintOrigCopia As Byte
   Private mlngCantItem As Long
   Private mlngDosificaVentaId As Long
   Private mstrDosificaDes As String
   Private mlngEstadoId As Long
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property DosificaId() As Long
      Get
         Return mlngDosificaId
      End Get

      Set(ByVal Value As Long)
         mlngDosificaId = Value
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

   Property SucursalId() As Long
      Get
         Return mlngSucursalId
      End Get

      Set(ByVal Value As Long)
         mlngSucursalId = Value
      End Set
   End Property

   Property TipoDosificaId() As Long
      Get
         Return mlngTipoDosificaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoDosificaId = Value
      End Set
   End Property

   Property NroAutorizacion() As String
      Get
         Return mstrNroAutorizacion
      End Get

      Set(ByVal Value As String)
         mstrNroAutorizacion = Value
      End Set
   End Property

   Property LlaveDosifica() As String
      Get
         Return mstrLlaveDosifica
      End Get

      Set(ByVal Value As String)
         mstrLlaveDosifica = Value
      End Set
   End Property

   Property NumeroSFC() As Long
      Get
         Return mlngNumeroSFC
      End Get

      Set(ByVal Value As Long)
         mlngNumeroSFC = Value
      End Set
   End Property

   Property NumeroIni() As Long
      Get
         Return mlngNumeroIni
      End Get

      Set(ByVal Value As Long)
         mlngNumeroIni = Value
      End Set
   End Property

   Property NumeroFin() As Long
      Get
         Return mlngNumeroFin
      End Get

      Set(ByVal Value As Long)
         mlngNumeroFin = Value
      End Set
   End Property

   Property NumeroActual() As Long
      Get
         Return mlngNumeroActual
      End Get

      Set(ByVal Value As Long)
         mlngNumeroActual = Value
      End Set
   End Property

   Property FechaIni() As String
      Get
         Return mstrFechaIni
      End Get

      Set(ByVal Value As String)
         mstrFechaIni = Value
      End Set
   End Property

   Property FechaFin() As String
      Get
         Return mstrFechaFin
      End Get

      Set(ByVal Value As String)
         mstrFechaFin = Value
      End Set
   End Property

   Property DosificaLeyId() As Long
      Get
         Return mlngDosificaLeyId
      End Get

      Set(ByVal Value As Long)
         mlngDosificaLeyId = Value
      End Set
   End Property

   Property ImpDosificaLey() As Byte
      Get
         Return mbytImpDosificaLey
      End Get

      Set(ByVal Value As Byte)
         mbytImpDosificaLey = Value
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

   Property TipoFormImpId() As Long
      Get
         Return mlngTipoFormImpId
      End Get

      Set(ByVal Value As Long)
         mlngTipoFormImpId = Value
      End Set
   End Property

   Property NroCopia() As Long
      Get
         Return mlngNroCopia
      End Get

      Set(ByVal Value As Long)
         mlngNroCopia = Value
      End Set
   End Property

   Property PrintOrigCopia() As Byte
      Get
         Return mbytPrintOrigCopia
      End Get

      Set(ByVal Value As Byte)
         mbytPrintOrigCopia = Value
      End Set
   End Property

   Property CantItem() As Long
      Get
         Return mlngCantItem
      End Get

      Set(ByVal Value As Long)
         mlngCantItem = Value
      End Set
   End Property

   Property DosificaVentaId() As Long
      Get
         Return mlngDosificaVentaId
      End Get

      Set(ByVal Value As Long)
         mlngDosificaVentaId = Value
      End Set
   End Property

   Property DosificaDes() As String
      Get
         Return mstrDosificaDes
      End Get

      Set(ByVal Value As String)
         mstrDosificaDes = Value
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
      ByActividad = 3
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      InActividadNew = 2
      Grid = 3
      EmpresaId = 4
      SucursalId = 5
      EstadoId = 6
      NroAutorizacion = 7
      TipoDosificaId = 8
      InFecha = 9
      InActividad = 10
      InActividadAbierta = 11
      ByActividad = 12
      DosificaLeyId = 13
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      DosificaId = 1
      Grid = 3
      NroAutorizacion = 4
      NumeroIni = 5
      ByActividad = 6
   End Enum

   Public Enum InsertFilters As Byte
      All = 0
   End Enum

   Public Enum UpdateFilters As Byte
      All = 0
      NumeroActual = 1
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
      mstrTableName = "tblDosifica"
      mstrClassName = "clsDosifica"

      moConnection = New OleDbConnection
      VMNew = New clsDosificaVM

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
      mlngDosificaId = 0
      mlngEmpresaId = 0
      mlngSucursalId = 0
      mlngTipoDosificaId = 0
      mstrNroAutorizacion = ""
      mstrLlaveDosifica = ""
      mlngNumeroSFC = 0
      mlngNumeroIni = 0
      mlngNumeroFin = 0
      mlngNumeroActual = 0
      mstrFechaIni = ""
      mstrFechaFin = ""
      mlngDosificaLeyId = 0
      mbytImpDosificaLey = 0
      mlngTipoImpresionId = 0
      mlngTipoFormImpId = 0
      mlngNroCopia = 1
      mbytPrintOrigCopia = 0
      mlngCantItem = 0
      mlngDosificaVentaId = 0
      mstrDosificaDes = ""
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
            strSQL &= "    tblDosifica.DosificaId,  "
            strSQL &= "    tblDosifica.EmpresaId,  "
            strSQL &= "    tblDosifica.SucursalId,  "
            strSQL &= "    tblDosifica.TipoDosificaId,  "
            strSQL &= "    tblDosifica.NroAutorizacion,  "
            strSQL &= "    tblDosifica.LlaveDosifica,  "
            strSQL &= "    tblDosifica.NumeroSFC,  "
            strSQL &= "    tblDosifica.NumeroIni,  "
            strSQL &= "    tblDosifica.NumeroFin,  "
            strSQL &= "    tblDosifica.NumeroActual,  "
            strSQL &= "    tblDosifica.FechaIni,  "
            strSQL &= "    tblDosifica.FechaFin,  "
            strSQL &= "    tblDosifica.DosificaLeyId,  "
            strSQL &= "    tblDosifica.ImpDosificaLey,  "
            strSQL &= "    tblDosifica.TipoImpresionId,  "
            strSQL &= "    tblDosifica.TipoFormImpId,  "
            strSQL &= "    tblDosifica.NroCopia,  "
            strSQL &= "    tblDosifica.PrintOrigCopia,  "
            strSQL &= "    tblDosifica.CantItem,  "
            strSQL &= "    tblDosifica.DosificaVentaId,  "
            strSQL &= "    tblDosifica.DosificaDes,  "
            strSQL &= "    tblDosifica.EstadoId,  "
            strSQL &= "    tblDosifica.sLastUpdate_id,  "
            strSQL &= "    tblDosifica.dtLastUpdate_dt,  "
            strSQL &= "    tblDosifica.iConcurrency_id  "
            strSQL &= " FROM tblDosifica "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblDosifica.DosificaId,  "
            strSQL &= "    tblDosifica.TipoDosificaId,  "
            strSQL &= "    tblDosifica.NroAutorizacion  "
            strSQL &= " FROM tblDosifica "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblDosifica.DosificaId,  "
            strSQL &= "    tblDosifica.EmpresaId,  "
            strSQL &= "    tblSucursal.SucursalId,  "
            strSQL &= "    tblSucursal.SucursalCod,  "
            strSQL &= "    tblSucursal.SucursalDes,  "
            strSQL &= "    tblDosificaVenta.DosificaVentaId,  "
            strSQL &= "    tblDosificaVenta.DosificaVentaDes,  "
            strSQL &= "    tblTipoDosifica.TipoDosificaId,  "
            strSQL &= "    tblTipoDosifica.TipoDosificaDes,  "
            strSQL &= "    tblDosifica.NroAutorizacion,  "
            strSQL &= "    tblDosifica.NumeroSFC,  "
            strSQL &= "    tblDosifica.LlaveDosifica,  "
            strSQL &= "    tblDosifica.NumeroIni,  "
            strSQL &= "    tblDosifica.NumeroFin,  "
            strSQL &= "    tblDosifica.NumeroActual,  "
            strSQL &= "    tblDosifica.FechaIni,  "
            strSQL &= "    tblDosifica.FechaFin,  "
            strSQL &= "    tblDosificaLey.DosificaLeyId,  "
            strSQL &= "    tblDosificaLey.DosificaLeyDes,  "
            strSQL &= "    tblDosifica.ImpDosificaLey,  "
            strSQL &= "    tblEstado.EstadoId,  "
            strSQL &= "    tblEstado.EstadoDes  "
            strSQL &= " FROM tblDosifica, tblTipoDosifica, tblSucursal, tblDosificaLey, tblDosificaVenta, tblEstado "

         Case SelectFilters.ByActividad
            strSQL = " SELECT  "
            strSQL &= "    tblDosifica.DosificaId,  "
            strSQL &= "    tblDosifica.EmpresaId,  "
            strSQL &= "    tblDosifica.SucursalId,  "
            strSQL &= "    tblDosifica.TipoDosificaId,  "
            strSQL &= "    tblDosifica.NroAutorizacion,  "
            strSQL &= "    tblDosifica.LlaveDosifica,  "
            strSQL &= "    tblDosifica.NumeroSFC,  "
            strSQL &= "    tblDosifica.NumeroIni,  "
            strSQL &= "    tblDosifica.NumeroFin,  "
            strSQL &= "    tblDosifica.NumeroActual,  "
            strSQL &= "    tblDosifica.FechaIni,  "
            strSQL &= "    tblDosifica.FechaFin,  "
            strSQL &= "    tblDosifica.DosificaLeyId,  "
            strSQL &= "    tblDosifica.ImpDosificaLey,  "
            strSQL &= "    tblDosifica.TipoImpresionId,  "
            strSQL &= "    tblDosifica.TipoFormImpId,  "
            strSQL &= "    tblDosifica.NroCopia,  "
            strSQL &= "    tblDosifica.PrintOrigCopia,  "
            strSQL &= "    tblDosifica.CantItem,  "
            strSQL &= "    tblDosifica.DosificaVentaId,  "
            strSQL &= "    tblDosifica.EstadoId,  "
            strSQL &= "    tblDosificaDet.DosificaDetId,   "
            strSQL &= "    tblDosifica.DosificaDes,  "
            strSQL &= "    tblDosificaDet.TipoActEcoId   "
            strSQL &= " FROM tblDosifica, tblDosificaDet "

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
            strSQL = " WHERE  tblDosifica.DosificaId = " & NumberToField(mlngDosificaId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.SucursalId = tblSucursal.SucursalId "
            strSQL &= " AND  tblDosifica.TipoDosificaId = tblTipoDosifica.TipoDosificaId "
            strSQL &= " AND  tblDosifica.DosificaLeyId = tblDosificaLey.DosificaLeyId "
            strSQL &= " AND  tblDosifica.DosificaVentaId = tblDosificaVenta.DosificaVentaId "
            strSQL &= " AND  tblDosifica.EstadoId = tblEstado.EstadoId "

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.SucursalId
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.SucursalId = " & NumberToField(mlngSucursalId)

         Case WhereFilters.EstadoId
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblDosifica.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngDosificaVentaId <> 0 Then strSQL &= " AND  tblDosifica.DosificaVentaId = " & NumberToField(mlngDosificaVentaId)
            strSQL &= " AND  tblDosifica.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.NroAutorizacion
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblDosifica.NroAutorizacion = " & StringToField(mstrNroAutorizacion)

         Case WhereFilters.TipoDosificaId
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.TipoDosificaId = " & NumberToField(mlngTipoDosificaId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblDosifica.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngEstadoId <> 0 Then strSQL &= " AND  tblDosifica.EstadoId = " & NumberToField(mlngEstadoId)

         Case WhereFilters.InFecha
            strSQL = " WHERE  tblDosifica.DosificaId = " & NumberToField(mlngDosificaId)
            strSQL &= " AND  tblDosifica.FechaIni <= " & DateToField(mstrFechaIni)
            strSQL &= " AND  tblDosifica.FechaFin >= " & DateToField(mstrFechaIni)

         Case WhereFilters.InActividad
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.TipoDosificaId = " & NumberToField(mlngTipoDosificaId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblDosifica.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngDosificaVentaId <> 0 Then strSQL &= " AND  tblDosifica.DosificaVentaId = " & NumberToField(mlngDosificaVentaId)
            strSQL &= " AND  tblDosifica.EstadoId = " & NumberToField(mlngEstadoId)

            If mstrLlaveDosifica <> String.Empty Then
               'strSQL &= " AND tblDosifica.DosificaId NOT IN (SELECT Det.DosificaId FROM tblDosificaDet Det WHERE Det.TipoActEcoId NOT IN " & mstrLlaveDosifica & " ) "
               strSQL &= " AND tblDosifica.DosificaId IN (SELECT Det.DosificaId FROM tblDosificaDet Det WHERE Det.TipoActEcoId IN " & mstrLlaveDosifica & " "
               strSQL &= "     GROUP BY Det.DosificaId HAVING 	COUNT(Det.DosificaId) = " & NumberToField(mlngDosificaLeyId) & " )"
            Else
               strSQL &= " AND tblDosifica.DosificaId NOT IN (SELECT Det.DosificaId FROM tblDosificaDet Det WHERE Det.EmpresaId = " & NumberToField(mlngEmpresaId) & " ) "
            End If

         Case WhereFilters.InActividadNew
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.TipoDosificaId = " & NumberToField(mlngTipoDosificaId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblDosifica.SucursalId = " & NumberToField(mlngSucursalId)
            If mlngDosificaVentaId <> 0 Then strSQL &= " AND  tblDosifica.DosificaVentaId = " & NumberToField(mlngDosificaVentaId)
            strSQL &= " AND  tblDosifica.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblDosifica.DosificaId = " & NumberToField(mlngDosificaId)
            If mstrLlaveDosifica <> String.Empty Then
               'strSQL &= " AND tblDosifica.DosificaId NOT IN (SELECT Det.DosificaId FROM tblDosificaDet Det WHERE Det.TipoActEcoId NOT IN " & mstrLlaveDosifica & " ) "
               strSQL &= " AND tblDosifica.DosificaId IN (SELECT Det.DosificaId FROM tblDosificaDet Det WHERE Det.TipoActEcoId IN " & mstrLlaveDosifica & " "
               strSQL &= "     GROUP BY Det.DosificaId HAVING 	COUNT(Det.DosificaId) = " & NumberToField(mlngDosificaLeyId) & " )"
            Else
               strSQL &= " AND tblDosifica.DosificaId NOT IN (SELECT Det.DosificaId FROM tblDosificaDet Det WHERE Det.EmpresaId = " & NumberToField(mlngEmpresaId) & " ) "
            End If

         Case WhereFilters.InActividadAbierta
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.TipoDosificaId = " & NumberToField(mlngTipoDosificaId)
            If mlngSucursalId <> 0 Then strSQL &= " AND  tblDosifica.SucursalId = " & NumberToField(mlngSucursalId)
            strSQL &= " AND  tblDosifica.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND  tblDosifica.DosificaVentaId = " & NumberToField(mlngDosificaVentaId)

            If mstrLlaveDosifica <> String.Empty Then
               strSQL &= " AND tblDosifica.DosificaId IN (SELECT Det.DosificaId FROM tblDosificaDet Det WHERE Det.TipoActEcoId IN " & mstrLlaveDosifica & "  )"
            Else
               strSQL &= " AND tblDosifica.DosificaId NOT IN (SELECT Det.DosificaId FROM tblDosificaDet Det WHERE Det.EmpresaId = " & NumberToField(mlngEmpresaId) & " ) "
            End If

         Case WhereFilters.ByActividad
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngTipoDosificaId <> 0 Then
               strSQL &= " AND  tblDosifica.TipoDosificaId = " & NumberToField(mlngTipoDosificaId)
            End If
            If mlngSucursalId <> 0 Then
               strSQL &= " AND  tblDosifica.SucursalId = " & NumberToField(mlngSucursalId)
            End If
            If mlngDosificaVentaId <> 0 Then
               strSQL &= " AND  tblDosifica.DosificaVentaId = " & NumberToField(mlngDosificaVentaId)
            End If
            strSQL &= " AND  tblDosifica.EstadoId = " & NumberToField(mlngEstadoId)
            strSQL &= " AND tblDosifica.DosificaId = tblDosificaDet.DosificaId "

            If mstrLlaveDosifica <> String.Empty And mstrLlaveDosifica <> "()" Then
               strSQL &= " AND tblDosificaDet.TipoActEcoId IN " & mstrLlaveDosifica & " "
            End If

         Case WhereFilters.DosificaLeyId
            strSQL = " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.DosificaLeyId = " & NumberToField(mlngDosificaLeyId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.DosificaId
            strSQL = " ORDER BY tblDosifica.DosificaId "

         Case OrderByFilters.Grid
            strSQL = " ORDER BY tblSucursal.SucursalDes, tblDosifica.NroAutorizacion "

         Case OrderByFilters.NroAutorizacion
            strSQL = " ORDER BY tblDosifica.NroAutorizacion "

         Case OrderByFilters.NumeroIni
            strSQL = " ORDER BY tblDosifica.NumeroIni "

         Case OrderByFilters.ByActividad
            strSQL = " ORDER BY tblDosifica.DosificaId "

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
            strSQL = "INSERT INTO tblDosifica ("
            strSQL &= "DosificaId, "
            strSQL &= "EmpresaId, "
            strSQL &= "SucursalId, "
            strSQL &= "TipoDosificaId, "
            strSQL &= "NroAutorizacion, "
            strSQL &= "LlaveDosifica, "
            strSQL &= "NumeroSFC, "
            strSQL &= "NumeroIni, "
            strSQL &= "NumeroFin, "
            strSQL &= "NumeroActual, "
            strSQL &= "FechaIni, "
            strSQL &= "FechaFin, "
            strSQL &= "DosificaLeyId, "
            strSQL &= "ImpDosificaLey, "
            strSQL &= "TipoImpresionId, "
            strSQL &= "TipoFormImpId, "
            strSQL &= "NroCopia,  "
            strSQL &= "PrintOrigCopia,  "
            strSQL &= "CantItem, "
            strSQL &= "DosificaVentaId, "
            strSQL &= "DosificaDes, "
            strSQL &= "EstadoId, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngDosificaId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngSucursalId) & ", "
            strSQL &= NumberToField(mlngTipoDosificaId) & ", "
            strSQL &= StringToField(mstrNroAutorizacion) & ", "
            strSQL &= StringToField(mstrLlaveDosifica) & ", "
            strSQL &= NumberToField(mlngNumeroSFC) & ", "
            strSQL &= NumberToField(mlngNumeroIni) & ", "
            strSQL &= NumberToField(mlngNumeroFin) & ", "
            strSQL &= NumberToField(mlngNumeroActual) & ", "
            strSQL &= DateToField(mstrFechaIni) & ", "
            strSQL &= DateToField(mstrFechaFin) & ", "
            strSQL &= NumberToField(mlngDosificaLeyId) & ", "
            strSQL &= NumberToField(mbytImpDosificaLey) & ", "
            strSQL &= NumberToField(mlngTipoImpresionId) & ", "
            strSQL &= NumberToField(mlngTipoFormImpId) & ", "
            strSQL &= NumberToField(mlngNroCopia) & ", "
            strSQL &= NumberToField(mbytPrintOrigCopia) & ", "
            strSQL &= NumberToField(mlngCantItem) & ", "
            strSQL &= NumberToField(mlngDosificaVentaId) & ", "
            strSQL &= StringToField(mstrDosificaDes) & ", "
            strSQL &= NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblDosifica SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "SucursalId = " & NumberToField(mlngSucursalId) & ", "
            strSQL &= "TipoDosificaId = " & NumberToField(mlngTipoDosificaId) & ", "
            strSQL &= "NroAutorizacion = " & StringToField(mstrNroAutorizacion) & ", "
            strSQL &= "LlaveDosifica = " & StringToField(mstrLlaveDosifica) & ", "
            strSQL &= "NumeroSFC = " & NumberToField(mlngNumeroSFC) & ", "
            strSQL &= "NumeroIni = " & NumberToField(mlngNumeroIni) & ", "
            strSQL &= "NumeroFin = " & NumberToField(mlngNumeroFin) & ", "
            strSQL &= "NumeroActual = " & NumberToField(mlngNumeroActual) & ", "
            strSQL &= "FechaIni = " & DateToField(mstrFechaIni) & ", "
            strSQL &= "FechaFin = " & DateToField(mstrFechaFin) & ", "
            strSQL &= "DosificaLeyId = " & NumberToField(mlngDosificaLeyId) & ", "
            strSQL &= "ImpDosificaLey = " & NumberToField(mbytImpDosificaLey) & ", "
            strSQL &= "TipoImpresionId = " & NumberToField(mlngTipoImpresionId) & ", "
            strSQL &= "TipoFormImpId = " & NumberToField(mlngTipoFormImpId) & ", "
            strSQL &= "NroCopia = " & NumberToField(mlngNroCopia) & ", "
            strSQL &= "PrintOrigCopia = " & NumberToField(mbytPrintOrigCopia) & ", "
            strSQL &= "CantItem = " & NumberToField(mlngCantItem) & ", "
            strSQL &= "DosificaVentaId = " & NumberToField(mlngDosificaVentaId) & ", "
            strSQL &= "DosificaDes = " & StringToField(mstrDosificaDes) & ", "
            strSQL &= "EstadoId = " & NumberToField(mlngEstadoId) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " DosificaId = " & NumberToField(mlngDosificaId) & " "

         Case UpdateFilters.NumeroActual
            strSQL = "UPDATE tblDosifica SET "
            strSQL &= "NumeroActual = " & NumberToField(mlngNumeroActual) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " DosificaId = " & NumberToField(mlngDosificaId) & " "

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
               mlngDosificaId = ToLong(oDataRow("DosificaId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngSucursalId = ToLong(oDataRow("SucursalId"))
               mlngTipoDosificaId = ToLong(oDataRow("TipoDosificaId"))
               mstrNroAutorizacion = ToStr(oDataRow("NroAutorizacion"))
               mstrLlaveDosifica = ToStr(oDataRow("LlaveDosifica"))
               mlngNumeroSFC = ToLong(oDataRow("NumeroSFC"))
               mlngNumeroIni = ToLong(oDataRow("NumeroIni"))
               mlngNumeroFin = ToLong(oDataRow("NumeroFin"))
               mlngNumeroActual = ToLong(oDataRow("NumeroActual"))
               mstrFechaIni = ToDateDMY(oDataRow("FechaIni"))
               mstrFechaFin = ToDateDMY(oDataRow("FechaFin"))
               mlngDosificaLeyId = ToLong(oDataRow("DosificaLeyId"))
               mbytImpDosificaLey = ToByte(oDataRow("ImpDosificaLey"))
               mlngTipoImpresionId = ToLong(oDataRow("TipoImpresionId"))
               mlngTipoFormImpId = ToLong(oDataRow("TipoFormImpId"))
               mlngNroCopia = ToLong(oDataRow("NroCopia"))
               mbytPrintOrigCopia = ToByte(oDataRow("PrintOrigCopia"))
               mlngCantItem = ToLong(oDataRow("CantItem"))
               mlngDosificaVentaId = ToLong(oDataRow("DosificaVentaId"))
               mstrDosificaDes = ToStr(oDataRow("DosificaDes"))
               mlngEstadoId = ToLong(oDataRow("EstadoId"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngDosificaId = ToLong(oDataRow("DosificaId"))
               mstrNroAutorizacion = ToStr(oDataRow("NroAutorizacion"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngDosificaId = TableIDGet(mstrTableName, "DosificaId", moConnection)

         If mlngDosificaId = -1 Then
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

      If mlngSucursalId = 0 Then
         strMsg &= "Sucursal Inválida" & vbCrLf
      End If

      If mlngTipoDosificaId = 0 Then
         strMsg &= "Tipo de Dosificación Inválida" & vbCrLf
      End If

      If mlngDosificaVentaId = 0 Then
         strMsg &= "Dosificación Inválida" & vbCrLf
      End If

      If mlngNumeroIni <= 0 Then
         strMsg &= "Número Inicial Iválido" & vbCrLf
      End If

      If mlngNumeroFin <= 0 Then
         strMsg &= "Número Final Iválido" & vbCrLf
      End If

      If mstrNroAutorizacion.Trim() = String.Empty Then
         strMsg &= "Número de Autorización Inválido" & vbCrLf
      End If

      If mstrFechaIni.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFechaIni)) Then
            strMsg &= "Fecha Inicial no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha Inicial no puede ser nula" & vbCrLf
      End If

      If mstrFechaFin.Trim() <> String.Empty Then
         If Not IsDate(ToDateDMY(mstrFechaFin)) Then
            strMsg &= "Fecha Final no Válida" & vbCrLf
         End If
      Else
         strMsg &= "La Fecha Final no puede ser nula" & vbCrLf
      End If

      If mlngDosificaLeyId = -1 Then
         strMsg &= "Leyenda Inválido" & vbCrLf
      End If

      If mlngEstadoId = 0 Then
         strMsg &= "Estado Inválido" & vbCrLf
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
         strSQL &= " FROM tblDosifica "

         If Not boolReplace Then
            strSQL &= " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
         Else
            strSQL &= " WHERE  tblDosifica.EmpresaId = " & NumberToField(mlngEmpresaId)
            strSQL &= " AND  tblDosifica.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
            strSQL &= " AND  tblDosifica.DosificaId <> " & NumberToField(mlngDosificaId)
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
                     VMNew.ToOpeAdd(clsTipoOpera.NUEVO, mlngDosificaId)
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
               Throw New Exception("Dosificación Duplicada")
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
         strSQL &= " FROM tblDosifica "
         strSQL &= " WHERE tblDosifica.DosificaId = " & NumberToField(mlngDosificaId)

         If TableFind(oDataTable, "tblFactura") Then
            strSQL &= " AND (tblDosifica.DosificaId IN "
            strSQL &= "   (SELECT DISTINCT DosificaId "
            strSQL &= "    FROM  tblFactura "
            strSQL &= "    WHERE tblFactura.DosificaId = " & NumberToField(mlngDosificaId) & ")"
         End If

         If TableFind(oDataTable, "tblFacturaAgru") Then
            strSQL &= " OR tblDosifica.DosificaId IN "
            strSQL &= "   (SELECT DISTINCT DosificaId "
            strSQL &= "    FROM  tblFacturaAgru "
            strSQL &= "    WHERE tblFacturaAgru.DosificaId = " & NumberToField(mlngDosificaId) & ")"
         End If

         If TableFind(oDataTable, "pdvCaja") Then
            strSQL &= " OR tblDosifica.DosificaId IN "
            strSQL &= "     (SELECT DISTINCT DosificaId "
            strSQL &= "      FROM  pdvCaja "
            strSQL &= "      WHERE pdvCaja.DosificaId = " & NumberToField(mlngDosificaId) & ")"
         End If

         If TableFind(oDataTable, "venVentaPara") Then
            strSQL &= " OR tblDosifica.DosificaId IN "
            strSQL &= "   (SELECT DISTINCT DosificaId "
            strSQL &= "    FROM  venVentaPara "
            strSQL &= "    WHERE venVentaPara.DosificaId = " & NumberToField(mlngDosificaId) & ")"
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