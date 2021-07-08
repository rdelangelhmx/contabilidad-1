Imports System.Data
Imports System.Data.OleDb

Public Class clsAudiOpe
   Implements IDisposable

   Private mlngAudiOpeId As Long
   Private mlngAppId As Long
   Private mstrAppDes As String
   Private mlngEmpresaId As Long
   Private mstrEmpresaDes As String
   Private mlngUserIdReg As Long
   Private mstrLoginId As String
   Private mstrFechaReg As String
   Private mstrFormName As String
   Private mstrFormText As String
   Private mlngTipoOperaId As Long
   Private mstrEquipoReg As String
   Private mstrObserReg As String

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
   Property AudiOpeId() As Long
      Get
         Return mlngAudiOpeId
      End Get

      Set(ByVal Value As Long)
         mlngAudiOpeId = Value
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

   Property FechaReg() As String
      Get
         Return mstrFechaReg
      End Get

      Set(ByVal Value As String)
         mstrFechaReg = Value
      End Set
   End Property



   '* Nombre de la forma
   Property FormName() As String
      Get
         Return mstrFormName
      End Get

      Set(ByVal Value As String)
         mstrFormName = Value
      End Set
   End Property

   Property FormText() As String
      Get
         Return mstrFormText
      End Get

      Set(ByVal Value As String)
         mstrFormText = Value
      End Set
   End Property


   '* Tipo de Operacion Descripcion
   Property TipoOperaId() As Long
      Get
         Return mlngTipoOperaId
      End Get
      Set(ByVal value As Long)
         mlngTipoOperaId = value
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
      AgruUsuario = 4
      UsuarioConexion = 5
   End Enum

   Public Enum WhereFilters As Byte
      None = 0
      PrimaryKey = 1
      AudiDocTop = 2
      LIKEAudiOpeObs = 3
      Grid = 4
      EmpresaId = 5
      OrdCrono = 6
      AgruUsuario = 7
      RangoFecha = 8
      OrdCronoDesc = 9
      UsuarioConexion = 10
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      AudiOpeId = 1
      AudiDocTop = 2
      Grid = 3
      ordCronoAsc = 4
      AgruUsuario = 5
      ordCronoDesc = 6
      UsuarioConexion = 7
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

   'Public Enum Lista_TipoOpera As Byte
   '   TODOS = 0
   '   NUEVO = 1
   '   MODIFICA = 2
   '   ELIMINA = 3
   '   ANULA = 4
   '   CONSULTA = 5
   '   CONSULTA_DOC = 6
   '   IMPRIME_DOC = 7
   '   INFORME = 8
   '   CAMBIA_ESTADO = 9
   '   CAMBIAR_EMPRESA = 10
   '   CAMBIAR_GESTION = 11
   '   INICIO_SESION = 12
   '   CIERRE_SESION = 13
   'End Enum




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
      mstrTableName = "secAudiOpe"
      mstrClassName = "clsAudiOpe"

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
      mlngAudiOpeId = 0
      mlngAppId = 0
      mstrAppDes = ""
      mlngEmpresaId = 0
      mstrEmpresaDes = 0
      mlngUserIdReg = 0
      mstrLoginId = ""
      mstrFechaReg = ""
      mstrFormName = ""
      mstrFormText = ""
      mlngTipoOperaId = 0
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
            strSQL &= "    secAudiOpe.AudiOpeId,  "
            strSQL &= "    secAudiOpe.AppId,  "
            strSQL &= "    secAudiOpe.AppDes,  "
            strSQL &= "    secAudiOpe.EmpresaId,  "
            strSQL &= "    secAudiOpe.EmpresaDes,  "
            strSQL &= "    secAudiOpe.UserIdReg,  "
            strSQL &= "    secAudiOpe.LoginId,  "
            strSQL &= "    secAudiOpe.FechaReg,  "
            strSQL &= "    secAudiOpe.FormName,  "
            strSQL &= "    secAudiOpe.FormText,  "
            strSQL &= "    secAudiOpe.TipoOperaId,  "
            strSQL &= "    secAudiOpe.EquipoReg,  "
            strSQL &= "    secAudiOpe.ObserReg  "
            strSQL &= " FROM secAudiOpe "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    secAudiOpe.AudiOpeId,  "
            strSQL &= "    secAudiOpe.TipoOperaId  "
            strSQL &= " FROM secAudiOpe "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    secAudiOpe.AudiOpeId,  "
            strSQL &= "    secAudiOpe.AppId,  "
            strSQL &= "    secAudiOpe.AppDes,  "
            strSQL &= "    secAudiOpe.EmpresaId,  "
            strSQL &= "    secAudiOpe.EmpresaDes,  "
            strSQL &= "    secAudiOpe.UserIdReg,  "
            strSQL &= "    secAudiOpe.LoginId,  "
            strSQL &= "    secAudiOpe.FechaReg,  "
            strSQL &= "    secAudiOpe.FormName,  "
            strSQL &= "    secAudiOpe.TipoOperaId,  "
            strSQL &= "    secAudiOpe.EquipoReg,  "
            strSQL &= "    secAudiOpe.ObserReg  "
            strSQL &= " FROM secAudiOpe"

         Case SelectFilters.OrdCrono
            strSQL = " SELECT  "
            strSQL &= "    secAudiOpe.Empresaid,  "
            strSQL &= "    secAudiOpe.AppId,  "
            strSQL &= "    secAudiOpe.AppDes,  "
            strSQL &= "    secAudiOpe.FechaReg,  "
            strSQL &= "    secAudiOpe.UserIdReg,  "
            strSQL &= "    secAudiOpe.LoginId,  "
            strSQL &= "    secAudiOpe.FormName,  "
            strSQL &= "    secAudiOpe.FormText,  "
            strSQL &= "    secAudiOpe.TipoOperaId,  "
            strSQL &= "    secTipoOpera.TipoOperaDes,  "
            strSQL &= "    secAudiOpe.EquipoReg,  "
            strSQL &= "    secAudiOpe.ObserReg  "
            strSQL &= " FROM secAudiOpe, secTipoOpera "

         Case SelectFilters.AgruUsuario
            strSQL = " SELECT  "
            strSQL &= "    secAudiOpe.LoginId,  "
            strSQL &= "    secAudiOpe.EquipoReg,  "
            strSQL &= "    secAudiOpe.AppId,  "
            strSQL &= "    secAudiOpe.AppDes,  "
            strSQL &= "    secAudiOpe.FormName,  "
            strSQL &= "    secAudiOpe.FormText,  "
            strSQL &= "    COUNT(secAudiOpe.ObserReg) as Contador  "
            strSQL &= " FROM secAudiOpe "

         Case SelectFilters.UsuarioConexion
            strSQL = " SELECT  "
            strSQL &= "    secApp.AppId, "
            strSQL &= "    secApp.AppDes, "
            strSQL &= "    secUser.UserId, "
            strSQL &= "    secUser.FirstName as Nombre, "
            strSQL &= "    secUser.LastName as Apellido, "
            strSQL &= "    secUser.LoginId as UserName, "
            'strSQL &= "    secUser.dtLastUpdate_dt as FechaCreacion, "
            strSQL &= "    secUser.FechaCreacion, "
            strSQL &= "    (select MAX(secAudiOpe.FechaReg) from secAudiOpe where secAudiOpe.UserIdReg = secUser.UserId) as  FechaRegOpe,  "
            strSQL &= "    (select MAX(secAudiDoc.FechaReg) from secAudiDoc where secAudiDoc.UserIdReg = secUser.UserId) as FechaRegDoc  "
            strSQL &= "    FROM secUser, secApp "
            
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
            strSQL = " WHERE  secAudiOpe.AudiOpeId = " & NumberToField(mlngAudiOpeId)

         Case WhereFilters.AudiDocTop
            strSQL = " WHERE  secAudiOpe.TipoOperaId = " & NumberToField(mlngTipoOperaId)

         Case WhereFilters.LIKEAudiOpeObs
            strSQL = " WHERE  secAudiOpe.ObserReg LIKE " & StringToField(mstrObserReg & LikeOperator)

         Case WhereFilters.Grid
            strSQL = " WHERE secAudiOpe.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  secAudiOpe.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.OrdCrono
            strSQL = " WHERE  (secAudiOpe.EmpresaId = " & NumberToField(mlngEmpresaId) & " OR secAudiOpe.EmpresaId = 0 ) "
            strSQL &= " AND  secAudiOpe.FechaReg >= " & DateTimeToField(mstrFechaIni, 2) '0)
            strSQL &= " AND  secAudiOpe.FechaReg <= " & DateTimeToField(mstrFechaFin, 2) '1)

            If mlngTipoOperaId <> 0 Then
               strSQL &= " AND  secAudiOpe.TipoOperaId = " & NumberToField(mlngTipoOperaId)
            End If
            strSQL &= " AND  secAudiOpe.TipoOperaId = secTipoOpera.TipoOperaId "

            If mlngUserIdReg <> 0 Then strSQL &= " AND  secAudiOpe.UserIdReg = " & NumberToField(mlngUserIdReg)

            strSQL &= " AND secAudiOpe.AppId IN " & mstrFormName

            strSQL &= " AND secAudiOpe.FormName IN ( "
            For Each mstrFormName As String In moLista
               strSQL &= StringToField(mstrFormName) & " , "
            Next
            Dim pos As Long = strSQL.LastIndexOf(",")
            strSQL = strSQL.Remove(pos, 1)
            strSQL &= " )"

         Case WhereFilters.OrdCronoDesc
            strSQL = " WHERE  secAudiOpe.EmpresaId = " & NumberToField(mlngEmpresaId)
            If mlngAppId <> 0 Then strSQL &= " AND  secAudiOpe.AppId = " & NumberToField(mlngAppId)
            strSQL &= " AND  secAudiOpe.FechaReg >= " & DateTimeToField(mstrFechaIni, 0)
            strSQL &= " AND  secAudiOpe.FechaReg <= " & DateTimeToField(mstrFechaFin, 1)
            If mlngTipoOperaId <> 0 Then strSQL &= " AND  secAudiOpe.TipoOperaId = " & NumberToField(mlngTipoOperaId)
            strSQL &= " AND  secAudiOpe.TipoOperaId = secTipoOpera.TipoOperaId "
            If mlngUserIdReg <> 0 Then strSQL &= " AND  secAudiOpe.UserIdReg = " & NumberToField(mlngUserIdReg)
            strSQL &= " AND secAudiOpe.FormName IN ( "
            For Each mstrFormName As String In moLista
               strSQL &= StringToField(mstrFormName) & " , "
            Next
            Dim pos As Long = strSQL.LastIndexOf(",")
            strSQL = strSQL.Remove(pos, 1)
            strSQL &= " )"

         Case WhereFilters.AgruUsuario
            strSQL = " WHERE  (secAudiOpe.EmpresaId = " & NumberToField(mlngEmpresaId) & " OR secAudiOpe.EmpresaId = 0 ) "

            If mlngAppId <> 0 Then
               strSQL &= " AND  secAudiOpe.AppId = " & NumberToField(mlngAppId)
            End If

            strSQL &= " AND  secAudiOpe.FechaReg >= " & DateTimeToField(mstrFechaIni, 0)
            strSQL &= " AND  secAudiOpe.FechaReg <= " & DateTimeToField(mstrFechaFin, 1)

            If mlngTipoOperaId <> 0 Then
               strSQL &= " AND  secAudiOpe.TipoOperaId = " & NumberToField(mlngTipoOperaId)
            End If

            If mlngUserIdReg <> 0 Then strSQL &= " AND  secAudiOpe.UserIdReg = " & NumberToField(mlngUserIdReg)

            strSQL &= " AND secAudiOpe.FormName IN ( "
            For Each mstrFormName As String In moLista
               strSQL &= StringToField(mstrFormName) & " , "
            Next

            Dim pos As Long = strSQL.LastIndexOf(",")
            strSQL = strSQL.Remove(pos, 1)
            strSQL &= " )"

         Case WhereFilters.RangoFecha
            strSQL = " WHERE secAudiOpe.FechaReg >= " & DateTimeToField(mstrFechaIni, 0)
            strSQL &= " AND  secAudiOpe.FechaReg <= " & DateTimeToField(mstrFechaFin, 1)

         Case WhereFilters.UsuarioConexion
            strSQL = " WHERE secApp.AppId = secUser.AppId "
            If mlngUserIdReg <> 0 Then strSQL &= " AND  secUser.UserId = " & NumberToField(mlngUserIdReg)
            If mlngAppId <> 0 Then strSQL &= " AND  secApp.AppId = " & NumberToField(mlngAppId)

            If moLista.Count > 0 Then
               strSQL &= " AND secApp.AppId IN ( "
               For Each mstrAppId As String In moLista
                  strSQL &= StringToField(mstrAppId) & " , "
               Next
               Dim pos As Long = strSQL.LastIndexOf(",")
               strSQL = strSQL.Remove(pos, 1)
               strSQL &= " )"
            End If
      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.AudiOpeId
            strSQL = " ORDER BY secAudiOpe.AudiOpeId"

         Case OrderByFilters.AudiDocTop
            strSQL = " ORDER BY secAudiOpe.TipoOperaId"

         Case OrderByFilters.Grid
            strSQL = " ORDER BY secAudiOpe.TipoOperaId"

         Case OrderByFilters.ordCronoAsc
            strSQL = " ORDER BY secAudiOpe.FechaReg ASC"
            '  strSQL = " ORDER BY secAudiOpe.AppId, secAudiOpe.FechaReg ASC"

         Case OrderByFilters.ordCronoDesc
            strSQL = " ORDER BY secAudiOpe.FechaReg DESC"
            ' strSQL = " ORDER BY secAudiOpe.FechaReg DESC, secAudiOpe.AppId, secAudiOpe.LoginId"
            'strSQL = " ORDER BY secAudiOpe.AppId, secAudiOpe.FechaReg DESC"

         Case OrderByFilters.AgruUsuario
            strSQL = " GROUP BY secAudiOpe.LoginId, secAudiOpe.EquipoReg, secAudiOpe.AppId, secAudiOpe.AppDes, secAudiOpe.FormName, secAudiOpe.FormText "
            strSQL &= " ORDER BY secAudiOpe.LoginId"

         Case OrderByFilters.UsuarioConexion
            strSQL &= " ORDER BY secApp.AppId ASC "

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
            strSQL = "INSERT INTO secAudiOpe ("
            strSQL &= "AudiOpeId, "
            strSQL &= "AppId, "
            strSQL &= "AppDes, "
            strSQL &= "EmpresaId, "
            strSQL &= "EmpresaDes, "
            strSQL &= "UserIdReg, "
            strSQL &= "LoginId, "
            strSQL &= "FechaReg, "
            strSQL &= "FormName, "
            strSQL &= "FormText, "
            strSQL &= "TipoOperaId, "
            strSQL &= "EquipoReg, "
            strSQL &= "ObserReg "
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngAudiOpeId) & ", "
            strSQL &= NumberToField(mlngAppId) & ", "
            strSQL &= StringToField(mstrAppDes) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= StringToField(mstrEmpresaDes) & ", "
            strSQL &= NumberToField(mlngUserIdReg) & ", "
            strSQL &= StringToField(mstrLoginId) & ", "
            strSQL &= DateToField(mstrFechaReg) & ", "
            strSQL &= StringToField(mstrFormName) & ", "
            strSQL &= StringToField(mstrFormText) & ", "
            strSQL &= NumberToField(mlngTipoOperaId) & ", "
            strSQL &= StringToField(mstrEquipoReg) & ", "
            strSQL &= StringToField(mstrObserReg) & ") "

      End Select

      Return strSQL
   End Function

   Private Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE secAudiOpe SET "
            strSQL &= "AppId = " & NumberToField(mlngAppId) & ", "
            strSQL &= "AppDes = " & StringToField(mstrAppDes) & ", "
            strSQL &= "EmpresaDes = " & StringToField(mstrEmpresaDes) & ", "
            strSQL &= "UserIdReg = " & NumberToField(mlngUserIdReg) & ", "
            strSQL &= "LoginId = " & StringToField(mstrLoginId) & ", "
            strSQL &= "FechaReg = " & DateToField(mstrFechaReg) & ", "
            strSQL &= "FormName = " & StringToField(mstrFormName) & ", "
            strSQL &= "FormText = " & StringToField(mstrFormText) & ", "
            strSQL &= "TipoOperaId = " & NumberToField(mlngTipoOperaId) & ", "
            strSQL &= "EquipoReg = " & StringToField(mstrEquipoReg) & ", "
            strSQL &= "ObserReg = " & StringToField(mstrObserReg) & " "
            strSQL &= " WHERE "
            strSQL &= " AudiOpeId = " & NumberToField(mlngAudiOpeId) & " "

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
               mlngAudiOpeId = ToLong(oDataRow("AudiOpeId"))
               mlngAppId = ToLong(oDataRow("AppId"))
               mstrAppDes = ToString(oDataRow("AppDes"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mstrEmpresaDes = ToString(oDataRow("EmpresaDes"))
               mlngUserIdReg = ToLong(oDataRow("UserIdReg"))
               mstrLoginId = ToString(oDataRow("LoginId"))
               mstrFechaReg = ToDateDMY(oDataRow("FechaReg"))
               mstrFormName = ToString(oDataRow("FormName"))
               mstrFormText = ToString(oDataRow("FormText"))
               mlngTipoOperaId = ToLong(oDataRow("TipoOperaId"))
               mstrEquipoReg = ToString(oDataRow("EquipoReg"))
               mstrObserReg = ToString(oDataRow("ObserReg"))

            Case SelectFilters.ListBox
               mlngAudiOpeId = ToLong(oDataRow("AudiOpeId"))
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

         mlngAudiOpeId = TableIDGet(mstrTableName, "AudiOpeId", moConnection)

         If mlngAudiOpeId = -1 Then
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

      'Se anulo esta validacion por razon de agregar la bitacora de un intento de inicio de 
      'sesion donde el usuario no es conocido (frmLogin-> UserTableCheck())

      'If mlngUserIdReg = 0 Then
      '   strMsg &= "Usuario Inválido" & vbCrLf
      'End If
      'If mstrLoginId.Length() = 0 Then
      '   strMsg &= "Ingrese el Login del usuario" & vbCrLf
      'End If

      If mstrFechaReg.Length() = 0 Then
         strMsg &= "Ingrese la fecha de registro" & vbCrLf
      End If


      'If mstrFormName.Length() = 0 Then
      '   strMsg &= "Ingrese el nombre del Formulario & vbCrLf"
      'End If

      If mlngTipoOperaId = 0 Then
         strMsg &= "Ingrese la descripcion del Tipo de Operacion" & vbCrLf
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
         'strSQL &= " FROM secAudiOpe "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  secAudiOpe.AudiOpeId = " & StringToField(mlngAudiOpeId)
         '   strSQL &= " AND  secAudiOpe.EmpresaId = " & NumberToField(mlngEmpresaId)
         'Else
         '   strSQL &= " WHERE  secAudiOpe.AudiOpeId = " & StringToField(mlngAudiOpeId)
         '   strSQL &= " AND  secAudiOpe.GestionId = " & NumberToField(mlngGestionID)
         '   strSQL &= " AND  secAudiOpe.EmpresaId = " & NumberToField(mlngEmpresaId)
         '   strSQL &= " AND  secAudiOpe.AudiOpeId <> " & NumberToField(mlngAudiOpeId)
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

   Public Function Open2() As Boolean
      Try
         Open2 = False

         Call OpenConection()

         moDataSet = New DataSet

         moDataAdapter = New OleDbDataAdapter(SelectSQL, moConnection)

         moDataAdapter.Fill(moDataSet, mstrTableName)

         moDataAdapter.Dispose()

         mintRow = 0
         mintRowsCount = moDataSet.Tables(mstrTableName).Rows.Count()

         Open2 = True

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

         ' If intRecordsAffected > 0 Then
         Delete = True
         ' End If

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
