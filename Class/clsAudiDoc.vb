Imports System.Data
Imports System.Data.OleDb

Public Class clsAudiDoc
   Implements IDisposable

   Private mlngAudiDocId As Long
   Private mlngAppId As Long
   Private mstrAppDes As String
   Private mlngEmpresaId As Long
   Private mstrEmpresaDes As String
   Private mlngGestionId As Long
   Private mlngGestion As Long
   Private mlngNroDocId As Long
   Private mlngNroDoc As Long
   Private mstrTipoDocDes As String
   Private mstrFechaReg As String
   Private mlngTipoOperaId As Long
   Private mlngPersonaId As Long
   Private mstrNomPersona As String
   Private mlngUserIdReg As Long
   Private mstrLoginId As String
   Private mstrEquipoReg As String
   Private mstrObserReg As String
   Private mboolOrdenarFecha As Boolean

   Private mstrFechaIni As String
   Private mstrFechaFin As String
   Private moLista As New Queue

   Private moConnection As OleDbConnection
   Private moDataAdapter As OleDbDataAdapter
   Private moDataSet As DataSet
   Private mintRow As Integer
   Private mintRowsCount As Integer

   Private mstrConnectionString As String
   Private mstrTableName As String
   Private mstrClassName As String
   Private mstrSQL As String

   'Public Const NUEVO As String = "NUEVO"
   'Public Const MODIFICA As String = "MODIFICA"
   'Public Const ELIMINA As String = "ELIMINA"
   'Public Const ANULA As String = "ANULA"
   'Public Const CONSULTA As String = "CONSULTA"
   'Public Const CONSULTA_DOC As String = "CONSULTA_DOC"
   'Public Const IMPRIME_DOC As String = "IMPRIME_DOC"
   'Public Const INFORME As String = "INFORME"
   'Public Const CAMBIA_ESTADO As String = "CAMBIA_ESTADO"
   'Public Const CAMBIAR_EMPRESA As String = "CAMBIAR_EMPRESA"
   'Public Const CAMBIAR_GESTION As String = "CAMBIAR_GESTION"


   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property AudiDocId() As Long
      Get
         Return mlngAudiDocId
      End Get

      Set(ByVal Value As Long)
         mlngAudiDocId = Value
      End Set
   End Property


   Property AppId() As Long
      Get
         Return mlngAppId
      End Get

      Set(ByVal Value As Long)
         mlngAppId = Value
      End Set
   End Property

   Property AppDes() As String
      Get
         Return mstrAppDes
      End Get

      Set(ByVal Value As String)
         mstrAppDes = Value
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

   Property EmpresaDes() As String
      Get
         Return mstrEmpresaDes
      End Get

      Set(ByVal Value As String)
         mstrEmpresaDes = Value
      End Set
   End Property


   Property GestionId() As Long
      Get
         Return mlngGestionID
      End Get

      Set(ByVal Value As Long)
         mlngGestionID = Value
      End Set
   End Property


   Property Gestion() As Long
      Get
         Return mlngGestion
      End Get

      Set(ByVal Value As Long)
         mlngGestion = Value
      End Set
   End Property

   Property NroDocId() As Long
      Get
         Return mlngNroDocId
      End Get

      Set(ByVal Value As Long)
         mlngNroDocId = Value
      End Set
   End Property

   Property NroDoc() As Long
      Get
         Return mlngNroDoc
      End Get

      Set(ByVal Value As Long)
         mlngNroDoc = Value
      End Set
   End Property

   Property TipoDocDes() As String
      Get
         Return mstrTipoDocDes
      End Get

      Set(ByVal Value As String)
         mstrTipoDocDes = Value
      End Set
   End Property

   Property FechaReg() As String
      Get
         Return mstrFechaReg
      End Get

      Set(ByVal Value As String)
         mstrFechaReg = Value
      End Set
   End Property

   Property OrdenarFecha() As Boolean
      Get
         Return mboolOrdenarFecha
      End Get
      Set(ByVal value As Boolean)
         mboolOrdenarFecha = value
      End Set
   End Property

   '* Tipo de Operacion
   Property TipoOperaId() As Long
      Get
         Return mlngTipoOperaId
      End Get
      Set(ByVal value As Long)
         mlngTipoOperaId = value
      End Set
   End Property

   '* Id. de la persona
   Property PersonaId() As Long
      Get
         Return mlngPersonaId
      End Get

      Set(ByVal Value As Long)
         mlngPersonaId = Value
      End Set
   End Property


   '* Nombre de la persona
   Property NomPersona() As String
      Get
         Return mstrNomPersona
      End Get

      Set(ByVal Value As String)
         mstrNomPersona = Value
      End Set
   End Property

   '* Id. del usuario
   Property UserIdReg() As Long
      Get
         Return mlngUserIdReg
      End Get

      Set(ByVal Value As Long)
         mlngUserIdReg = Value
      End Set
   End Property

   '* Login del usuario
   Property LoginId() As String
      Get
         Return mstrLoginId
      End Get

      Set(ByVal Value As String)
         mstrLoginId = Value
      End Set
   End Property

   '* Equipo donde se registro
   Property EquipoReg() As String
      Get
         Return mstrEquipoReg
      End Get

      Set(ByVal Value As String)
         mstrEquipoReg = Value
      End Set
   End Property

   '* Observacion del Registro
   Property ObserReg() As String
      Get
         Return mstrObserReg
      End Get

      Set(ByVal Value As String)
         mstrObserReg = Value
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


   Property Lista() As Queue
      Get
         Return moLista
      End Get

      Set(ByVal Value As Queue)
         moLista = Value
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
      OrdCrono = 3
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      AudiDocTop = 2
      LIKEAudiDocObs = 3
      Grid = 4
      EmpresaId = 5
      OrdCrono = 6
      RangoFecha = 7
      OrdCrono1 = 8
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      AudiDocId = 1
      AudiDocTop = 2
      Grid = 3
      OrdCronoASC = 4
      OrdCronoDESC = 5
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
      mstrTableName = "secAudiDoc"
      mstrClassName = "clsAudiDoc"

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
      mlngAudiDocId = 0
      mlngAppId = 0
      mstrAppDes = ""
      mlngEmpresaId = 0
      mstrEmpresaDes = ""
      mlngGestionId = 0
      mlngGestion = 0
      mlngNroDocId = 0
      mlngNroDoc = 0
      mstrTipoDocDes = ""
      mstrFechaReg = ""
      mlngTipoOperaId = 0
      mlngPersonaId = 0
      mstrNomPersona = ""
      mlngUserIdReg = 0
      mstrLoginId = ""
      mstrEquipoReg = ""
      mstrObserReg = ""
      mstrFechaIni = ""
      mstrFechaFin = ""

   End Sub

   Private Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    secAudiDoc.AudiDocId,  "
            strSQL &= "    secAudiDoc.AppId,  "
            strSQL &= "    secAudiDoc.AppDes,  "
            strSQL &= "    secAudiDoc.EmpresaId,  "
            strSQL &= "    secAudiDoc.EmpresaDes,  "
            strSQL &= "    secAudiDoc.FechaReg,  "
            strSQL &= "    secAudiDoc.UserIdReg,  "
            strSQL &= "    secAudiDoc.LoginId,  "
            strSQL &= "    secAudiDoc.GestionId,  "
            strSQL &= "    secAudiDoc.Gestion,  "
            strSQL &= "    secAudiDoc.TipoDocDes,  "
            strSQL &= "    secAudiDoc.NroDocId,  "
            strSQL &= "    secAudiDoc.NroDoc,  "
            strSQL &= "    secAudiDoc.PersonaId,  "
            strSQL &= "    secAudiDoc.NomPersona,  "
            strSQL &= "    secAudiDoc.TipoOperaId,  "
            strSQL &= "    secAudiDoc.EquipoReg,  "
            strSQL &= "    secAudiDoc.ObserReg  "
            strSQL &= " FROM secAudiDoc "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    secAudiDoc.AudiDocId,  "
            strSQL &= "    secAudiDoc.TipoOperaId  "
            strSQL &= " FROM secAudiDoc "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    secAudiDoc.AudiDocId,  "
            strSQL &= "    secAudiDoc.AppId,  "
            strSQL &= "    secAudiDoc.AppDes,  "
            strSQL &= "    secAudiDoc.EmpresaId,  "
            strSQL &= "    secAudiDoc.EmpresaDes,  "
            strSQL &= "    secAudiDoc.GestionId,  "
            strSQL &= "    secAudiDoc.Gestion,  "
            strSQL &= "    secAudiDoc.NroDocId,  "
            strSQL &= "    secAudiDoc.NroDoc,  "
            strSQL &= "    secAudiDoc.TipoDocDes,  "
            strSQL &= "    secAudiDoc.FechaReg,  "
            strSQL &= "    secAudiDoc.TipoOperaId,  "
            strSQL &= "    secAudiDoc.PersonaId,  "
            strSQL &= "    secAudiDoc.NomPersona,  "
            strSQL &= "    secAudiDoc.UserIdReg,  "
            strSQL &= "    secAudiDoc.LoginId,  "
            strSQL &= "    secAudiDoc.EquipoReg,  "
            strSQL &= "    secAudiDoc.ObserReg  "
            strSQL &= " FROM secAudiDoc"

         Case SelectFilters.OrdCrono
            strSQL = " SELECT  "
            strSQL &= "    secAudiDoc.AudiDocId,  "
            strSQL &= "    secAudiDoc.AppId,  "
            strSQL &= "    secAudiDoc.AppDes,  "
            strSQL &= "    secAudiDoc.EmpresaId,  "
            strSQL &= "    secAudiDoc.EmpresaDes,  "
            strSQL &= "    secAudiDoc.FechaReg,  "
            strSQL &= "    secAudiDoc.UserIdReg,  "
            strSQL &= "    secAudiDoc.LoginId,  "
            strSQL &= "    secAudiDoc.GestionId,  "
            strSQL &= "    secAudiDoc.Gestion,  "
            strSQL &= "    secAudiDoc.TipoDocDes,  "
            strSQL &= "    secAudiDoc.NroDocId,  "
            strSQL &= "    secAudiDoc.NroDoc,  "
            strSQL &= "    secAudiDoc.PersonaId,  "
            strSQL &= "    secAudiDoc.NomPersona,  "
            strSQL &= "    secAudiDoc.TipoOperaId,  "
            strSQL &= "    secTipoOpera.TipoOperaDes,  "
            strSQL &= "    secAudiDoc.EquipoReg,  "
            strSQL &= "    secAudiDoc.ObserReg  "
            strSQL &= " FROM secAudiDoc, secTipoOpera "
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
            strSQL = " WHERE  secAudiDoc.AudiDocId = " & NumberToField(mlngAudiDocId)

         Case WhereFilters.AudiDocTop
            strSQL = " WHERE  secAudiDoc.TipoOperaId = " & NumberToField(mlngTipoOperaId)

         Case WhereFilters.LIKEAudiDocObs
            strSQL = " WHERE  secAudiDoc.ObserReg LIKE " & StringToField(mstrObserReg & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE secAudiDoc.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  secAudiDoc.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.OrdCrono
            strSQL = " WHERE  secAudiDoc.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngAppId <> 0 Then
               strSQL &= " AND  secAudiDoc.AppId = " & NumberToField(mlngAppId)
            End If

            'strSQL &= " AND  secAudiDoc.FechaReg >= " & DateTimeToField(mstrFechaIni, 0)
            'strSQL &= " AND  secAudiDoc.FechaReg <= " & DateTimeToField(msrtFechaFin, 1)

            strSQL &= " AND  secAudiDoc.FechaReg >= " & DateTimeToField(mstrFechaIni, 2) '0)
            strSQL &= " AND  secAudiDoc.FechaReg <= " & DateTimeToField(mstrFechaFin, 2) '1)

            If mlngTipoOperaId <> 0 Then
               strSQL &= " AND  secAudiDoc.TipoOperaId = " & NumberToField(mlngTipoOperaId)
            End If
            strSQL &= " AND  secAudiDoc.TipoOperaId = secTipoOpera.TipoOperaId "

         Case WhereFilters.OrdCrono1
            strSQL = " WHERE  secAudiDoc.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngAppId <> 0 Then
               strSQL &= " AND  secAudiDoc.AppId = " & NumberToField(mlngAppId)
            End If

            strSQL &= " AND  secAudiDoc.FechaReg >= " & DateTimeToField(mstrFechaIni, 0)
            strSQL &= " AND  secAudiDoc.FechaReg <= " & DateTimeToField(mstrFechaFin, 1)

            If mlngTipoOperaId <> 0 Then
               strSQL &= " AND  secAudiDoc.TipoOperaId = " & NumberToField(mlngTipoOperaId)
            End If
            strSQL &= " AND  secAudiDoc.TipoOperaId = secTipoOpera.TipoOperaId "

            If IsNumeric(mstrLoginId) Then strSQL &= " AND  secAudiDoc.NroDoc = " & NumberToField(mstrLoginId)

            strSQL &= " AND secAudiDoc.LoginId IN ( "
            For Each mstrLoginId As String In moLista
               strSQL &= StringToField(mstrLoginId) & " , "
            Next

            Dim pos As Long = strSQL.LastIndexOf(",")
            strSQL = strSQL.Remove(pos, 1)
            strSQL &= " )"

         Case WhereFilters.RangoFecha
            strSQL = " WHERE secAudiDoc.FechaReg >= " & DateTimeToField(mstrFechaIni, 0)
            strSQL &= " AND  secAudiDoc.FechaReg <= " & DateTimeToField(mstrFechaFin, 1)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.AudiDocId
            strSQL = " ORDER BY secAudiDoc.AudiDocId"

         Case OrderByFilters.AudiDocTop
            strSQL = " ORDER BY secAudiDoc.TipoOperaId"

         Case OrderByFilters.Grid
            strSQL = " ORDER BY secAudiDoc.TipoOperaId"

         Case OrderByFilters.OrdCronoASC
            strSQL = " ORDER BY secAudiDoc.AppId, secAudiDoc.FechaReg ASC"

         Case OrderByFilters.OrdCronoDESC
            strSQL = " ORDER BY secAudiDoc.AppId, secAudiDoc.FechaReg DESC"

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
            strSQL = "INSERT INTO secAudiDoc ("
            strSQL &= "AudiDocId, "
            strSQL &= "AppId, "
            strSQL &= "AppDes, "
            strSQL &= "EmpresaId, "
            strSQL &= "EmpresaDes, "
            strSQL &= "GestionId, "
            strSQL &= "Gestion, "
            strSQL &= "NroDocId, "
            strSQL &= "NroDoc, "
            strSQL &= "TipoDocDes, "
            strSQL &= "FechaReg, "
            strSQL &= "TipoOperaId, "
            strSQL &= "PersonaId, "
            strSQL &= "NomPersona, "
            strSQL &= "UserIdReg, "
            strSQL &= "LoginId, "
            strSQL &= "EquipoReg, "
            strSQL &= "ObserReg"
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngAudiDocId) & ", "
            strSQL &= NumberToField(mlngAppId) & ", "
            strSQL &= StringToField(mstrAppDes) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrEmpresaDes) & ", "
            strSQL &= NumberToField(mlngGestionId) & ", "
            strSQL &= NumberToField(mlngGestion) & ", "
            strSQL &= NumberToField(mlngNroDocId) & ", "
            strSQL &= NumberToField(mlngNroDoc) & ", "
            strSQL &= StringToField(mstrTipoDocDes) & ", "
            strSQL &= DateToField(mstrFechaReg) & ", "
            strSQL &= NumberToField(mlngTipoOperaId) & ", "
            strSQL &= NumberToField(mlngPersonaId) & ", "
            strSQL &= StringToField(mstrNomPersona) & ", "
            strSQL &= NumberToField(mlngUserIdReg) & ", "
            strSQL &= StringToField(mstrLoginId) & ", "
            strSQL &= StringToField(mstrEquipoReg) & ", "
            strSQL &= StringToField(mstrObserReg) & ")"

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE secAudiDoc SET "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "AppDes = " & StringToField(mstrAppDes) & ", "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "EmpresaDes = " & StringToField(mstrEmpresaDes) & ", "
            strSQL &= "GestionId = " & NumberToField(mlngGestionId) & ", "
            strSQL &= "Gestion = " & NumberToField(mlngGestion) & ", "
            strSQL &= "NroDocId = " & NumberToField(mlngNroDocId) & ", "
            strSQL &= "NroDoc = " & NumberToField(mlngNroDoc) & ", "
            strSQL &= "TipoDocDes = " & NumberToField(mstrTipoDocDes) & ", "
            strSQL &= "FechaReg = " & DateToField(mstrFechaReg) & ", "
            strSQL &= "TipoOperaId = " & NumberToField(mlngTipoOperaId) & ", "
            strSQL &= "PersonaId = " & NumberToField(mlngPersonaId) & ", "
            strSQL &= "NomPersona = " & StringToField(mstrNomPersona) & ", "
            strSQL &= "UserIdReg = " & NumberToField(mlngUserIdReg) & ", "
            strSQL &= "LoginId = " & StringToField(mstrLoginId) & ", "
            strSQL &= "EquipoReg = " & StringToField(mstrEquipoReg) & ", "
            strSQL &= "ObserReg = " & StringToField(mstrObserReg)
            strSQL &= " WHERE "
            strSQL &= " AudiDocId = " & NumberToField(mlngAudiDocId) & " "

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
               mlngAudiDocId = ToLong(oDataRow("AudiDocId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mstrAppDes = ToString(oDataRow("AppDes"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrEmpresaDes = ToString(oDataRow("EmpresaDes"))
               mlngGestionId = ToLong(oDataRow("GestionId"))
               mlngGestion = ToLong(oDataRow("Gestion"))
               mlngNroDocId = ToLong(oDataRow("NroDocId"))
               mlngNroDoc = ToLong(oDataRow("NroDoc"))
               mstrTipoDocDes = ToString(oDataRow("TipoDocDes"))
               mstrFechaReg = ToDateDMY(oDataRow("FechaReg"))
               mlngTipoOperaId = ToLong(oDataRow("TipoOperaId"))
               mlngPersonaId = ToLong(oDataRow("PersonaId"))
               mstrNomPersona = ToString(oDataRow("NomPersona"))
               mlngUserIdReg = ToLong(oDataRow("UserIdReg"))
               mstrLoginId = ToString(oDataRow("LoginId"))
               mstrEquipoReg = ToString(oDataRow("EquipoReg"))
               mstrObserReg = ToString(oDataRow("ObserReg"))


            Case SelectFilters.ListBox
               mlngAudiDocId = ToLong(oDataRow("AudiDocId"))
               mlngTipoOperaId = ToLong(oDataRow("TipoOperaId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Private Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngAudiDocId = TableIDGet(mstrTableName, "AudiDocId", moConnection)

         If mlngAudiDocId = -1 Then
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


      If mlngAppId < 0 Then
         strMsg &= "Aplicación Inválida" & vbCrLf
      End If

      If (mlngAppId > 0) And (mstrAppDes.Length() = 0) Then
         strMsg &= "Ingrese el nombre de la Aplicacion" & vbCrLf
      End If

      If mlngEmpresaId < 0 Then
         strMsg &= "Empresa Inválida" & vbCrLf
      End If

      If (mlngEmpresaId > 0) And (mstrEmpresaDes.Length() = 0) Then
         strMsg &= "Ingrese el nombre de la Empresa" & vbCrLf
      End If

      If mlngGestionId < 0 Then
         strMsg &= "Id. Gestion Inválida" & vbCrLf
      End If

      If mlngGestionId > 0 And mlngGestion = 0 Then
         strMsg &= "Gestion Inválida" & vbCrLf
      End If

      If mlngNroDocId = 0 Then
         strMsg &= "ID. Numero de Doc. Inválido" & vbCrLf
      End If

      If mlngNroDoc = 0 Then
         strMsg &= "Numero de Doc. Inválido" & vbCrLf
      End If


      If mstrTipoDocDes.Length() = 0 Then
         strMsg &= "Ingrese el tipo de Doc." & vbCrLf
      End If

      If mstrFechaReg.Length() = 0 Then
         strMsg &= "Ingrese la fecha de registro" & vbCrLf
      End If

      If mlngTipoOperaId = 0 Then
         strMsg &= "Ingrese la descripcion del Tipo de Operacion" & vbCrLf
      End If

      'If mlngPersonaId = 0 Then
      '   strMsg &= "Persona Inválida" & vbCrLf
      'End If

      'If mstrNomPersona.Length() = 0 Then
      '   strMsg &= "Ingrese el nombre de la persona" & vbCrLf
      'End If

      If mlngUserIdReg = 0 Then
         strMsg &= "Usuario Inválido" & vbCrLf
      End If

      If mstrLoginId.Length() = 0 Then
         strMsg &= "Ingrese el Login del usuario" & vbCrLf
      End If

      If mstrEquipoReg.Length() = 0 Then
         strMsg &= "Ingrese el Equipo del usuario" & vbCrLf
      End If

      If mstrObserReg.Length() = 0 Then
         strMsg &= "Ingrese la observacion" & vbCrLf
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
         'strSQL = " SELECT  "
         'strSQL &= " Count(*) As NumRecs  "
         'strSQL &= " FROM secAudiDoc "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  secAudiDoc.AudiDocId = " & StringToField(mlngAudiDocId)
         '   strSQL &= " AND  secAudiDoc.EmpresaId = " & NumberToField(mlngEmpresaId)
         'Else
         '   strSQL &= " WHERE  secAudiDoc.AudiDocId = " & StringToField(mlngAudiDocId)
         '   strSQL &= " AND  secAudiDoc.GestionId = " & NumberToField(mlngGestionID)
         '   strSQL &= " AND  secAudiDoc.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  secAudiDoc.AudiDocId <> " & NumberToField(mlngAudiDocId)
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

         'If intRecordsAffected > 0 Then
         Delete = True
         'End If

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
