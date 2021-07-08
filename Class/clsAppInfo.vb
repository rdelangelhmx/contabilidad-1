Imports System.Configuration.ConfigurationSettings

Public Class clsAppInfo
   Private Shared mlngProviderId As Long
   Private Shared mstrConnectString As String

   Private Shared mlngAppId As Long
   Private Shared mstrAppDes As String

   Private Shared mlngUserId As Long
   Private Shared mlngGroupId As Long
   Private Shared mstrUserName As String
   Private Shared mstrDataBaseSource As String
   Private Shared mstrDataBaseName As String

   Private Shared mstrLoginId As String
   Private Shared mstrPassword As String

   Private Shared mlngEmpresaId As Long
   Private Shared mstrEmpresaDes As String
   Private Shared mstrEmpresaGral As String
   Private Shared mboolPlanCtaShow As Boolean
   Private Shared mboolFechaOpera As Boolean
   Private Shared mboolMultipleNro As Boolean
   Private Shared mboolSepararExento As Boolean
   Private Shared mboolAplicarDescuento As Boolean
   Private Shared mboolExigirEEFF As Boolean
   Private Shared mboolValidarSaldoCajaBanco As Boolean
   Private Shared mboolAplicarDosificaVend As Boolean
   Private Shared mboolExigirActAnaAdd As Boolean
   Private Shared mlngCiudadId As Long

   Private Shared mlngGestionId As Long
   Private Shared mlngGestion As Long
   Private Shared mlngMonedaId As Long

   Private Shared mdecIVA As Decimal
   Private Shared mdecIT As Decimal
   Private Shared mdecITF As Decimal
   Private Shared mdecIUEServicio As Decimal
   Private Shared mdecIUEBien As Decimal

   Private Shared mintDecimalNro As Integer
   Private Shared mlngPlanCreId As Long
   Private Shared mlngPlanCreDifId As Long
   Private Shared mlngPlanDebId As Long
   Private Shared mlngPlanDebDifId As Long
   Private Shared mlngPlanITId As Long
   Private Shared mlngPlanITPId As Long
   Private Shared mlngPlanITFId As Long
   Private Shared mlngPlanIceIehdId As Long
   Private Shared mlngPlanIceIehdDifId As Long
   Private Shared mlngPlanExentoId As Long
   Private Shared mlngPlanDifId As Long
   Private Shared mlngPlanAitbId As Long
   Private Shared mlngPlanResId As Long
   Private Shared mlngPlanCreRetId As Long
   Private Shared mlngPlanITRetId As Long
   Private Shared mlngPlanIUERetSerId As Long
   Private Shared mlngPlanIUERetBieId As Long
   Private Shared mlngTipoHojaId As Long
   Private Shared mboolCodBarra As Boolean

   Private Shared mqueMesLista As New Queue
   Private Shared mlngMesId As Long
   Private Shared mstrMesDes As String

   Private Shared mstrHelpIndex As String
   Private Shared mstrHelpVideo As String
   Private Shared mboolRegistrarBitacora As Boolean
   Private Shared mlngMinLength As Long
   Private Shared mlngNumUpper As Long
   Private Shared mlngNumLower As Long
   Private Shared mlngNumNumbers As Long
   Private Shared mlngNumSpecial As Long
   Private Shared mlngNumFailed As Long
   Private Shared mstrFormName As String
   Private Shared mstrFormText As String
   Private Shared mlngTipoOpera As Long

   Private Shared mstrConnectStringTemp As String
   Private Shared mstrServerTemp As String
   Private Shared mstrUserTemp As String
   Private Shared mstrPassTemp As String
   Private Shared mstrDataBaseTemp As String
   Private Shared mlngEmpresaIdTemp As Long
   Private Shared mstrEmpresaDesTemp As String
   Private Shared mlngGestionIdTemp As Long
   Private Shared mlngGestionTemp As Long
   Private Shared mboolRecordar As Long

   Shared Property ProviderId() As Long
      Get
         Return mlngProviderId
      End Get

      Set(ByVal Value As Long)
         mlngProviderId = Value
      End Set
   End Property

   Shared Property ConnectString() As String
      Get
         Return mstrConnectString
      End Get

      Set(ByVal Value As String)
         mstrConnectString = Value
      End Set
   End Property

   Shared Property AppId() As Long
      Get
         Return mlngAppId
      End Get

      Set(ByVal Value As Long)
         mlngAppId = Value
      End Set
   End Property

   Shared Property AppDes() As String
      Get
         Return mstrAppDes
      End Get

      Set(ByVal Value As String)
         mstrAppDes = Value
      End Set
   End Property

   Shared Property UserId() As Long
      Get
         Return mlngUserId
      End Get

      Set(ByVal Value As Long)
         mlngUserId = Value
      End Set
   End Property

   Shared Property GroupId() As Long
      Get
         Return mlngGroupId
      End Get

      Set(ByVal Value As Long)
         mlngGroupId = Value
      End Set
   End Property

   Shared Property UserName() As String
      Get
         Return mstrUserName
      End Get

      Set(ByVal Value As String)
         mstrUserName = Value
      End Set
   End Property

   Shared Property DataBaseSource() As String
      Get
         Return mstrDataBaseSource
      End Get

      Set(ByVal Value As String)
         mstrDataBaseSource = Value
      End Set
   End Property

   Shared Property DataBaseName() As String
      Get
         Return mstrDataBaseName
      End Get

      Set(ByVal Value As String)
         mstrDataBaseName = Value
      End Set
   End Property

   Shared Property LoginId() As String
      Get
         Return mstrLoginId
      End Get

      Set(ByVal Value As String)
         mstrLoginId = Value
      End Set
   End Property

   Shared Property Password() As String
      Get
         Return mstrPassword
      End Get

      Set(ByVal Value As String)
         mstrPassword = Value
      End Set
   End Property

   Shared Property EmpresaId() As Long
      Get
         Return mlngEmpresaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaId = Value
      End Set
   End Property

   Shared Property EmpresaDes() As String
      Get
         Return mstrEmpresaDes
      End Get

      Set(ByVal Value As String)
         mstrEmpresaDes = Value
      End Set
   End Property

   Shared Property EmpresaGral() As String
      Get
         Return mstrEmpresaGral
      End Get

      Set(ByVal Value As String)
         mstrEmpresaGral = Value
      End Set
   End Property

   Shared Property PlanCtaShow() As Boolean
      Get
         Return mboolPlanCtaShow
      End Get

      Set(ByVal Value As Boolean)
         mboolPlanCtaShow = Value
      End Set
   End Property

   Shared Property FechaOpera() As Boolean
      Get
         Return mboolFechaOpera
      End Get

      Set(ByVal Value As Boolean)
         mboolFechaOpera = Value
      End Set
   End Property

   Shared Property MultipleNro() As Boolean
      Get
         Return mboolMultipleNro
      End Get

      Set(ByVal Value As Boolean)
         mboolMultipleNro = Value
      End Set
   End Property

   Shared Property SepararExento() As Boolean
      Get
         Return mboolSepararExento
      End Get

      Set(ByVal Value As Boolean)
         mboolSepararExento = Value
      End Set
   End Property

   Shared Property AplicarDescuento() As Boolean
      Get
         Return mboolAplicarDescuento
      End Get

      Set(ByVal Value As Boolean)
         mboolAplicarDescuento = Value
      End Set
   End Property

   Shared Property ExigirEEFF() As Boolean
      Get
         Return mboolExigirEEFF
      End Get

      Set(ByVal Value As Boolean)
         mboolExigirEEFF = Value
      End Set
   End Property

   Shared Property ValidarSaldoCajaBanco() As Boolean
      Get
         Return mboolValidarSaldoCajaBanco
      End Get

      Set(ByVal Value As Boolean)
         mboolValidarSaldoCajaBanco = Value
      End Set
   End Property

   Shared Property AplicarDosificaVend() As Boolean
      Get
         Return mboolAplicarDosificaVend
      End Get

      Set(ByVal Value As Boolean)
         mboolAplicarDosificaVend = Value
      End Set
   End Property

   Shared Property ExigirActAnaAdd() As Boolean
      Get
         Return mboolExigirActAnaAdd
      End Get

      Set(ByVal Value As Boolean)
         mboolExigirActAnaAdd = Value
      End Set
   End Property

   Shared Property CiudadId() As Long
      Get
         Return mlngCiudadId
      End Get

      Set(ByVal Value As Long)
         mlngCiudadId = Value
      End Set
   End Property

   Shared Property GestionId() As Long
      Get
         Return mlngGestionId
      End Get

      Set(ByVal Value As Long)
         mlngGestionId = Value
      End Set
   End Property

   Shared Property Gestion() As Long
      Get
         Return mlngGestion
      End Get

      Set(ByVal Value As Long)
         mlngGestion = Value
      End Set
   End Property

   Shared Property MonedaId() As Long
      Get
         Return mlngMonedaId
      End Get

      Set(ByVal Value As Long)
         mlngMonedaId = Value
      End Set
   End Property

   Shared Property IVA() As Decimal
      Get
         Return mdecIVA
      End Get

      Set(ByVal Value As Decimal)
         mdecIVA = Value
      End Set
   End Property

   Shared Property IT() As Decimal
      Get
         Return mdecIT
      End Get

      Set(ByVal Value As Decimal)
         mdecIT = Value
      End Set
   End Property

   Shared Property ITF() As Decimal
      Get
         Return mdecITF
      End Get

      Set(ByVal Value As Decimal)
         mdecITF = Value
      End Set
   End Property

   Shared Property IUEServicio() As Decimal
      Get
         Return mdecIUEServicio
      End Get

      Set(ByVal Value As Decimal)
         mdecIUEServicio = Value
      End Set
   End Property

   Shared Property IUEBien() As Decimal
      Get
         Return mdecIUEBien
      End Get

      Set(ByVal Value As Decimal)
         mdecIUEBien = Value
      End Set
   End Property

   Shared Property DecimalNro() As Integer
      Get
         Return mintDecimalNro
      End Get

      Set(ByVal Value As Integer)
         mintDecimalNro = Value
      End Set
   End Property

   Shared Property PlanCreId() As Long
      Get
         Return mlngPlanCreId
      End Get

      Set(ByVal Value As Long)
         mlngPlanCreId = Value
      End Set
   End Property

   Shared Property PlanCreDifId() As Long
      Get
         Return mlngPlanCreDifId
      End Get

      Set(ByVal Value As Long)
         mlngPlanCreDifId = Value
      End Set
   End Property

   Shared Property PlanDebId() As Long
      Get
         Return mlngPlanDebId
      End Get

      Set(ByVal Value As Long)
         mlngPlanDebId = Value
      End Set
   End Property

   Shared Property PlanDebDifId() As Long
      Get
         Return mlngPlanDebDifId
      End Get

      Set(ByVal Value As Long)
         mlngPlanDebDifId = Value
      End Set
   End Property

   Shared Property PlanITId() As Long
      Get
         Return mlngPlanITId
      End Get

      Set(ByVal Value As Long)
         mlngPlanITId = Value
      End Set
   End Property

   Shared Property PlanITPId() As Long
      Get
         Return mlngPlanITPId
      End Get

      Set(ByVal Value As Long)
         mlngPlanITPId = Value
      End Set
   End Property

   Shared Property PlanITFId() As Long
      Get
         Return mlngPlanITFId
      End Get

      Set(ByVal Value As Long)
         mlngPlanITFId = Value
      End Set
   End Property

   Shared Property PlanDifId() As Long
      Get
         Return mlngPlanDifId
      End Get

      Set(ByVal Value As Long)
         mlngPlanDifId = Value
      End Set
   End Property

   Shared Property PlanIceIehdId() As Long
      Get
         Return mlngPlanIceIehdId
      End Get

      Set(ByVal Value As Long)
         mlngPlanIceIehdId = Value
      End Set
   End Property

   Shared Property PlanIceIehdDifId() As Long
      Get
         Return mlngPlanIceIehdDifId
      End Get

      Set(ByVal Value As Long)
         mlngPlanIceIehdDifId = Value
      End Set
   End Property

   Shared Property PlanExentoId() As Long
      Get
         Return mlngPlanExentoId
      End Get

      Set(ByVal Value As Long)
         mlngPlanExentoId = Value
      End Set
   End Property

   Shared Property PlanAitbId() As Long
      Get
         Return mlngPlanAitbId
      End Get

      Set(ByVal Value As Long)
         mlngPlanAitbId = Value
      End Set
   End Property

   Shared Property PlanResId() As Long
      Get
         Return mlngPlanResId
      End Get

      Set(ByVal Value As Long)
         mlngPlanResId = Value
      End Set
   End Property

   Shared Property PlanCreRetId() As Long
      Get
         Return mlngPlanCreRetId
      End Get

      Set(ByVal Value As Long)
         mlngPlanCreRetId = Value
      End Set
   End Property

   Shared Property PlanITRetId() As Long
      Get
         Return mlngPlanITRetId
      End Get

      Set(ByVal Value As Long)
         mlngPlanITRetId = Value
      End Set
   End Property

   Shared Property PlanIUERetSerId() As Long
      Get
         Return mlngPlanIUERetSerId
      End Get

      Set(ByVal Value As Long)
         mlngPlanIUERetSerId = Value
      End Set
   End Property

   Shared Property PlanIUERetBieId() As Long
      Get
         Return mlngPlanIUERetBieId
      End Get

      Set(ByVal Value As Long)
         mlngPlanIUERetBieId = Value
      End Set
   End Property

   Shared Property TipoHojaId() As Long
      Get
         Return mlngTipoHojaId
      End Get

      Set(ByVal Value As Long)
         mlngTipoHojaId = Value
      End Set
   End Property

   Shared Property CodBarra() As Boolean
      Get
         Return mboolCodBarra
      End Get

      Set(ByVal Value As Boolean)
         mboolCodBarra = Value
      End Set
   End Property

   Shared Property MesLista() As Queue
      Get
         Return mqueMesLista
      End Get

      Set(ByVal Value As Queue)
         mqueMesLista = Value
      End Set
   End Property

   Shared Property MesId() As Long
      Get
         Return mlngMesId
      End Get

      Set(ByVal Value As Long)
         mlngMesId = Value
      End Set
   End Property

   Shared Property MesDes() As String
      Get
         Return mstrMesDes
      End Get

      Set(ByVal Value As String)
         mstrMesDes = Value
      End Set
   End Property

   Shared Property HelpIndex() As String
      Get
         Return mstrHelpIndex
      End Get

      Set(ByVal Value As String)
         mstrHelpIndex = Value
      End Set
   End Property

   Shared Property HelpVideo() As String
      Get
         Return mstrHelpVideo
      End Get

      Set(ByVal Value As String)
         mstrHelpVideo = Value
      End Set
   End Property

   Public Shared Sub Init()
      Try
         mlngProviderId = ToLong(AppSettings("ProviderId"))
         mstrConnectString = AppSettings("ConnectString")
         mstrHelpIndex = AppSettings("HelpIndex")
         mstrHelpVideo = AppSettings("HelpVideo")

      Catch exp As Exception
         Throw exp

      End Try
   End Sub

   Shared Property RegistrarBitacora() As Boolean
      Get
         Return mboolRegistrarBitacora
      End Get

      Set(ByVal Value As Boolean)
         mboolRegistrarBitacora = Value
      End Set
   End Property

   Shared Property MinLength() As Long
      Get
         Return mlngMinLength
      End Get

      Set(ByVal Value As Long)
         mlngMinLength = Value
      End Set
   End Property

   Shared Property NumUpper() As Long
      Get
         Return mlngNumUpper
      End Get

      Set(ByVal Value As Long)
         mlngNumUpper = Value
      End Set
   End Property

   Shared Property NumLower() As Long
      Get
         Return mlngNumLower
      End Get

      Set(ByVal Value As Long)
         mlngNumLower = Value
      End Set
   End Property

   Shared Property NumNumbers() As Long
      Get
         Return mlngNumNumbers
      End Get

      Set(ByVal Value As Long)
         mlngNumNumbers = Value
      End Set
   End Property

   Shared Property NumSpecial() As Long
      Get
         Return mlngNumSpecial
      End Get

      Set(ByVal Value As Long)
         mlngNumSpecial = Value
      End Set
   End Property

   Shared Property NumFailed() As Long
      Get
         Return mlngNumFailed
      End Get

      Set(ByVal Value As Long)
         mlngNumFailed = Value
      End Set
   End Property

   Shared Property FormName() As String
      Get
         Return gfrmMain.ActiveForm.Name
      End Get

      Set(ByVal Value As String)
         mstrFormName = Value
      End Set
   End Property

   Shared Property FormText() As String
      Get
         Return gfrmMain.ActiveForm.Text
      End Get

      Set(ByVal Value As String)
         mstrFormText = Value
      End Set
   End Property

   Shared Property TipoOpera() As Long
      Get
         Return mlngTipoOpera
      End Get

      Set(ByVal Value As Long)
         mlngTipoOpera = Value
      End Set
   End Property

   Shared Property ConnectStringTemp() As String
      Get
         Return mstrConnectStringTemp
      End Get

      Set(ByVal Value As String)
         mstrConnectStringTemp = Value
      End Set
   End Property

   Shared Property ServerTemp() As String
      Get
         Return mstrServerTemp
      End Get

      Set(ByVal Value As String)
         mstrServerTemp = Value
      End Set
   End Property

   Shared Property UserTemp() As String
      Get
         Return mstrUserTemp
      End Get

      Set(ByVal Value As String)
         mstrUserTemp = Value
      End Set
   End Property

   Shared Property PassTemp() As String
      Get
         Return mstrPassTemp
      End Get

      Set(ByVal Value As String)
         mstrPassTemp = Value
      End Set
   End Property

   Shared Property DataBaseTemp() As String
      Get
         Return mstrDataBaseTemp
      End Get

      Set(ByVal Value As String)
         mstrDataBaseTemp = Value
      End Set
   End Property

   Shared Property EmpresaIdTemp() As Long
      Get
         Return mlngEmpresaIdTemp
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaIdTemp = Value
      End Set
   End Property

   Shared Property EmpresaDesTemp() As String
      Get
         Return mstrEmpresaDesTemp
      End Get

      Set(ByVal Value As String)
         mstrEmpresaDesTemp = Value
      End Set
   End Property

   Shared Property GestionIdTemp() As Long
      Get
         Return mlngGestionIdTemp
      End Get

      Set(ByVal Value As Long)
         mlngGestionIdTemp = Value
      End Set
   End Property

   Shared Property GestionTemp() As Long
      Get
         Return mlngGestionTemp
      End Get

      Set(ByVal Value As Long)
         mlngGestionTemp = Value
      End Set
   End Property

   Shared Property Recordar() As Boolean
      Get
         Return mboolRecordar
      End Get

      Set(ByVal Value As Boolean)
         mboolRecordar = Value
      End Set
   End Property
End Class
