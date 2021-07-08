Imports System.Data
Imports System.Data.OleDb

Public Class clsEmpresaPara
   Inherits clsBase
   Implements IDisposable

   Public VMOld As New clsEmpresaParaVM
   Public VMNew As New clsEmpresaParaVM

   Private mlngEmpresaParaId As Long
   Private mlngEmpresaId As Long
   Private mlngDecimalNro As Long
   Private mlngDecimalCant As Long
   Private mstrEmpresaGral As String
   Private mlngPlanCreId As Long
   Private mlngPlanCreDifId As Long
   Private mlngPlanDebId As Long
   Private mlngPlanDebDifId As Long
   Private mlngPlanITId As Long
   Private mlngPlanITPId As Long
   Private mlngPlanITFId As Long
   Private mlngPlanIceIehdId As Long
   Private mlngPlanIceIehdDifId As Long
   Private mlngPlanExentoId As Long
   Private mlngPlanDifId As Long
   Private mlngPlanAitbId As Long
   Private mlngPlanResId As Long
   Private mlngPlanCreRetId As Long
   Private mlngPlanITRetId As Long
   Private mlngPlanIUERetSerId As Long
   Private mlngPlanIUERetBieId As Long
   Private mlngTipoHojaId As Long
   Private mbytInventario As Byte
   Private mbytItemCodShow As Byte
   Private mbytPlanCtaShow As Byte
   Private mbytCodBarra As Byte
   Private mbytMultipleNro As Byte
   Private mbytFechaOpera As Byte
   Private mbytCentroCostoApli As Byte
   Private mbytSepararExento As Byte
   Private mbytAplicarDescuento As Byte
   Private mdecMontoMinOpe As Decimal
   Private mdecMontoMinFac As Decimal
   Private mbytAplicarITPDif As Byte
   Private mbytAplicarMedAlternativa As Byte
   Private mbytAplicarControlInv As Byte
   Private mbytAplicarDosificaVend As Byte
   Private mbytRepSinGestion As Byte
   Private mlngPlanITPDifId As Long
   Private mbytExigirEEFF As Byte
   Private mbytValidarSaldoCajaBanco As Byte
   Private mbytExigirActAnaAdd As Byte

   Private mstrRepositorio As String
   Private mstrLastUpdateId As String
   Private mstrLastUpdateDate As String
   Private mintConcurrencyId As Integer

   '******************************************************
   ' Private Data To Match the Table Definition
   '******************************************************
   Property EmpresaParaId() As Long
      Get
         Return mlngEmpresaParaId
      End Get

      Set(ByVal Value As Long)
         mlngEmpresaParaId = Value
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

   Property DecimalNro() As Long
      Get
         Return mlngDecimalNro
      End Get

      Set(ByVal Value As Long)
         mlngDecimalNro = Value
      End Set
   End Property

   Property DecimalCant() As Long
      Get
         Return mlngDecimalCant
      End Get

      Set(ByVal Value As Long)
         mlngDecimalCant = Value
      End Set
   End Property

   Property EmpresaGral() As String
      Get
         Return mstrEmpresaGral
      End Get

      Set(ByVal Value As String)
         mstrEmpresaGral = Value
      End Set
   End Property

   Property PlanCreId() As Long
      Get
         Return mlngPlanCreId
      End Get

      Set(ByVal Value As Long)
         mlngPlanCreId = Value
      End Set
   End Property

   Property PlanCreDifId() As Long
      Get
         Return mlngPlanCreDifId
      End Get

      Set(ByVal Value As Long)
         mlngPlanCreDifId = Value
      End Set
   End Property

   Property PlanDebId() As Long
      Get
         Return mlngPlanDebId
      End Get

      Set(ByVal Value As Long)
         mlngPlanDebId = Value
      End Set
   End Property

   Property PlanDebDifId() As Long
      Get
         Return mlngPlanDebDifId
      End Get

      Set(ByVal Value As Long)
         mlngPlanDebDifId = Value
      End Set
   End Property

   Property PlanITId() As Long
      Get
         Return mlngPlanITId
      End Get

      Set(ByVal Value As Long)
         mlngPlanITId = Value
      End Set
   End Property

   Property PlanITPId() As Long
      Get
         Return mlngPlanITPId
      End Get

      Set(ByVal Value As Long)
         mlngPlanITPId = Value
      End Set
   End Property

   Property PlanITFId() As Long
      Get
         Return mlngPlanITFId
      End Get

      Set(ByVal Value As Long)
         mlngPlanITFId = Value
      End Set
   End Property

   Property PlanIceIehdId() As Long
      Get
         Return mlngPlanIceIehdId
      End Get

      Set(ByVal Value As Long)
         mlngPlanIceIehdId = Value
      End Set
   End Property

   Property PlanIceIehdDifId() As Long
      Get
         Return mlngPlanIceIehdDifId
      End Get

      Set(ByVal Value As Long)
         mlngPlanIceIehdDifId = Value
      End Set
   End Property

   Property PlanExentoId() As Long
      Get
         Return mlngPlanExentoId
      End Get

      Set(ByVal Value As Long)
         mlngPlanExentoId = Value
      End Set
   End Property

   Property PlanDifId() As Long
      Get
         Return mlngPlanDifId
      End Get

      Set(ByVal Value As Long)
         mlngPlanDifId = Value
      End Set
   End Property

   Property PlanAitbId() As Long
      Get
         Return mlngPlanAitbId
      End Get

      Set(ByVal Value As Long)
         mlngPlanAitbId = Value
      End Set
   End Property

   Property PlanResId() As Long
      Get
         Return mlngPlanResId
      End Get

      Set(ByVal Value As Long)
         mlngPlanResId = Value
      End Set
   End Property

   Property PlanCreRetId() As Long
      Get
         Return mlngPlanCreRetId
      End Get

      Set(ByVal Value As Long)
         mlngPlanCreRetId = Value
      End Set
   End Property

   Property PlanITRetId() As Long
      Get
         Return mlngPlanITRetId
      End Get

      Set(ByVal Value As Long)
         mlngPlanITRetId = Value
      End Set
   End Property

   Property PlanIUERetSerId() As Long
      Get
         Return mlngPlanIUERetSerId
      End Get

      Set(ByVal Value As Long)
         mlngPlanIUERetSerId = Value
      End Set
   End Property

   Property PlanIUERetBieId() As Long
      Get
         Return mlngPlanIUERetBieId
      End Get

      Set(ByVal Value As Long)
         mlngPlanIUERetBieId = Value
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

   Property Inventario() As Byte
      Get
         Return mbytInventario
      End Get

      Set(ByVal Value As Byte)
         mbytInventario = Value
      End Set
   End Property

   Property RepSinGestion() As Byte
      Get
         Return mbytRepSinGestion
      End Get

      Set(ByVal Value As Byte)
         mbytRepSinGestion = Value
      End Set
   End Property

   Property ItemCodShow() As Byte
      Get
         Return mbytItemCodShow
      End Get

      Set(ByVal Value As Byte)
         mbytItemCodShow = Value
      End Set
   End Property

   Property PlanCtaShow() As Byte
      Get
         Return mbytPlanCtaShow
      End Get

      Set(ByVal Value As Byte)
         mbytPlanCtaShow = Value
      End Set
   End Property

   Property CodBarra() As Byte
      Get
         Return mbytCodBarra
      End Get

      Set(ByVal Value As Byte)
         mbytCodBarra = Value
      End Set
   End Property

   Property MultipleNro() As Byte
      Get
         Return mbytMultipleNro
      End Get

      Set(ByVal Value As Byte)
         mbytMultipleNro = Value
      End Set
   End Property

   Property FechaOpera() As Byte
      Get
         Return mbytFechaOpera
      End Get

      Set(ByVal Value As Byte)
         mbytFechaOpera = Value
      End Set
   End Property

   Property CentroCostoApli() As Byte
      Get
         Return mbytCentroCostoApli
      End Get

      Set(ByVal Value As Byte)
         mbytCentroCostoApli = Value
      End Set
   End Property

   Property SepararExento() As Byte
      Get
         Return mbytSepararExento
      End Get

      Set(ByVal Value As Byte)
         mbytSepararExento = Value
      End Set
   End Property

   Property AplicarDescuento() As Byte
      Get
         Return mbytAplicarDescuento
      End Get

      Set(ByVal Value As Byte)
         mbytAplicarDescuento = Value
      End Set
   End Property

   Property MontoMinOpe() As Decimal
      Get
         Return mdecMontoMinOpe
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoMinOpe = Value
      End Set
   End Property

   Property MontoMinFac() As Decimal
      Get
         Return mdecMontoMinFac
      End Get

      Set(ByVal Value As Decimal)
         mdecMontoMinFac = Value
      End Set
   End Property

   Property AplicarITPDif() As Byte
      Get
         Return mbytAplicarITPDif
      End Get

      Set(ByVal Value As Byte)
         mbytAplicarITPDif = Value
      End Set
   End Property

   Property AplicarMedAlternativa() As Byte
      Get
         Return mbytAplicarMedAlternativa
      End Get

      Set(ByVal Value As Byte)
         mbytAplicarMedAlternativa = Value
      End Set
   End Property

   Property AplicarControlInv() As Byte
      Get
         Return mbytAplicarControlInv
      End Get

      Set(ByVal Value As Byte)
         mbytAplicarControlInv = Value
      End Set
   End Property

   Property AplicarDosificaVend() As Byte
      Get
         Return mbytAplicarDosificaVend
      End Get

      Set(ByVal Value As Byte)
         mbytAplicarDosificaVend = Value
      End Set
   End Property

   Property PlanITPDifId() As Long
      Get
         Return mlngPlanITPDifId
      End Get

      Set(ByVal Value As Long)
         mlngPlanITPDifId = Value
      End Set
   End Property

   Property ExigirEEFF() As Byte
      Get
         Return mbytExigirEEFF
      End Get

      Set(ByVal Value As Byte)
         mbytExigirEEFF = Value
      End Set
   End Property

   Public Property ValidarSaldoCajaBanco() As Byte
      Get
         Return mbytValidarSaldoCajaBanco
      End Get
      Set(ByVal value As Byte)
         mbytValidarSaldoCajaBanco = value
      End Set
   End Property

   Property Repositorio() As String
      Get
         Return mstrRepositorio
      End Get

      Set(ByVal Value As String)
         mstrRepositorio = Value
      End Set
   End Property

   Public Property ExigirActAnaAdd() As Byte
      Get
         Return mbytExigirActAnaAdd
      End Get
      Set(ByVal value As Byte)
         mbytExigirActAnaAdd = value
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
      EmpresaId = 3
   End Enum

   Public Enum OrderByFilters As Byte
      None = 0
      EmpresaParaId = 1
      Grid = 2
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
      mstrTableName = "tblEmpresaPara"
      mstrClassName = "clsEmpresaPara"

      moConnection = New OleDbConnection
      VMNew = New clsEmpresaParaVM

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
      mlngEmpresaParaId = 0
      mlngEmpresaId = 0
      mlngDecimalNro = 0
      mlngDecimalCant = 0
      mstrEmpresaGral = ""
      mlngPlanCreId = 0
      mlngPlanCreDifId = 0
      mlngPlanDebId = 0
      mlngPlanDebDifId = 0
      mlngPlanITId = 0
      mlngPlanITPId = 0
      mlngPlanITFId = 0
      mlngPlanIceIehdId = 0
      mlngPlanIceIehdDifId = 0
      mlngPlanExentoId = 0
      mlngPlanDifId = 0
      mlngPlanAitbId = 0
      mlngPlanResId = 0
      mlngPlanCreRetId = 0
      mlngPlanITRetId = 0
      mlngPlanIUERetSerId = 0
      mlngPlanIUERetBieId = 0
      mlngTipoHojaId = 0
      mbytInventario = 0
      mbytRepSinGestion = 0
      mbytItemCodShow = 0
      mbytPlanCtaShow = 0
      mbytCodBarra = 0
      mbytMultipleNro = 0
      mbytFechaOpera = 0
      mbytCentroCostoApli = 0
      mbytSepararExento = 0
      mbytAplicarDescuento = 0
      mdecMontoMinOpe = 0
      mdecMontoMinFac = 0
      mbytAplicarITPDif = 0
      mbytAplicarMedAlternativa = 0
      mbytAplicarControlInv = 0
      mbytAplicarDosificaVend = 0
      mlngPlanITPDifId = 0
      mbytExigirEEFF = 0
      mbytValidarSaldoCajaBanco = 0
      mstrRepositorio = String.Empty
      mbytExigirActAnaAdd = 0
      mstrLastUpdateId = ""
      mstrLastUpdateDate = ""
      mintConcurrencyId = 0
   End Sub

   Protected Overrides Function SelectSQL() As String
      Dim strSQL As String

      Select Case mintSelectFilter
         Case SelectFilters.All
            strSQL = " SELECT  "
            strSQL &= "    tblEmpresaPara.EmpresaParaId,  "
            strSQL &= "    tblEmpresaPara.EmpresaId,  "
            strSQL &= "    tblEmpresaPara.DecimalNro,  "
            strSQL &= " tblEmpresaPara.DecimalCant, "
            strSQL &= "    tblEmpresaPara.EmpresaGral,  "
            strSQL &= "    tblEmpresaPara.PlanCreId,  "
            strSQL &= "    tblEmpresaPara.PlanCreDifId,  "
            strSQL &= "    tblEmpresaPara.PlanDebId,  "
            strSQL &= "    tblEmpresaPara.PlanDebDifId,  "
            strSQL &= "    tblEmpresaPara.PlanITId,  "
            strSQL &= "    tblEmpresaPara.PlanITPId,  "
            strSQL &= "    tblEmpresaPara.PlanITFId,  "
            strSQL &= "    tblEmpresaPara.PlanIceIehdId,  "
            strSQL &= "    tblEmpresaPara.PlanIceIehdDifId,  "
            strSQL &= "    tblEmpresaPara.PlanExentoId,  "
            strSQL &= "    tblEmpresaPara.PlanDifId,  "
            strSQL &= "    tblEmpresaPara.PlanAitbId,  "
            strSQL &= "    tblEmpresaPara.PlanResId,  "
            strSQL &= "    tblEmpresaPara.PlanCreRetId,  "
            strSQL &= "    tblEmpresaPara.PlanITRetId,  "
            strSQL &= "    tblEmpresaPara.PlanIUERetSerId,  "
            strSQL &= "    tblEmpresaPara.PlanIUERetBieId,  "
            strSQL &= "    tblEmpresaPara.TipoHojaId,  "
            strSQL &= "    tblEmpresaPara.Inventario,  "
            strSQL &= " tblEmpresaPara.RepSinGestion, "
            strSQL &= " tblEmpresaPara.Repositorio, "
            strSQL &= "    tblEmpresaPara.ItemCodShow,  "
            strSQL &= "    tblEmpresaPara.PlanCtaShow,  "
            strSQL &= "    tblEmpresaPara.CodBarra,  "
            strSQL &= "    tblEmpresaPara.MultipleNro,  "
            strSQL &= "    tblEmpresaPara.FechaOpera,  "
            strSQL &= "    tblEmpresaPara.CentroCostoApli,  "
            strSQL &= "    tblEmpresaPara.SepararExento,  "
            strSQL &= "    tblEmpresaPara.AplicarDescuento,  "
            strSQL &= "    tblEmpresaPara.MontoMinOpe,  "
            strSQL &= "    tblEmpresaPara.MontoMinFac,  "
            strSQL &= "    tblEmpresaPara.AplicarITPDif,  "
            strSQL &= " tblEmpresaPara.AplicarMedAlternativa, "
            strSQL &= " tblEmpresaPara.AplicarControlInv, "
            strSQL &= " tblEmpresaPara.AplicarDosificaVend, "
            strSQL &= "    tblEmpresaPara.PlanITPDifId,  "
            strSQL &= "    tblEmpresaPara.ExigirEEFF,  "
            strSQL &= "    tblEmpresaPara.ValidarSaldoCajaBanco,  "
            strSQL &= "    tblEmpresaPara.ExigirActAnaAdd,  "
            strSQL &= "    tblEmpresaPara.sLastUpdate_id,  "
            strSQL &= "    tblEmpresaPara.dtLastUpdate_dt,  "
            strSQL &= "    tblEmpresaPara.iConcurrency_id  "
            strSQL &= " FROM tblEmpresaPara "

         Case SelectFilters.ListBox
            strSQL = " SELECT  "
            strSQL &= "    tblEmpresaPara.EmpresaParaId  "
            strSQL &= " FROM tblEmpresaPara "

         Case SelectFilters.Grid
            strSQL = " SELECT  "
            strSQL &= "    tblEmpresaPara.EmpresaParaId,  "
            strSQL &= "    tblEmpresaPara.EmpresaId,  "
            strSQL &= "    tblEmpresaPara.DecimalNro,  "
            strSQL &= "    tblEmpresaPara.EmpresaGral,  "
            strSQL &= "    tblEmpresaPara.PlanCreId,  "
            strSQL &= "    tblEmpresaPara.PlanCreDifId,  "
            strSQL &= "    tblEmpresaPara.PlanDebId,  "
            strSQL &= "    tblEmpresaPara.PlanDebDifId,  "
            strSQL &= "    tblEmpresaPara.PlanITId,  "
            strSQL &= "    tblEmpresaPara.PlanITPId,  "
            strSQL &= "    tblEmpresaPara.PlanITFId,  "
            strSQL &= "    tblEmpresaPara.PlanIceIehdId,  "
            strSQL &= "    tblEmpresaPara.PlanIceIehdDifId,  "
            strSQL &= "    tblEmpresaPara.PlanExentoId,  "
            strSQL &= "    tblEmpresaPara.PlanDifId,  "
            strSQL &= "    tblEmpresaPara.PlanAitbId,  "
            strSQL &= "    tblEmpresaPara.PlanResId,  "
            strSQL &= "    tblEmpresaPara.PlanCreRetId,  "
            strSQL &= "    tblEmpresaPara.PlanITRetId,  "
            strSQL &= "    tblEmpresaPara.PlanIUERetSerId,  "
            strSQL &= "    tblEmpresaPara.PlanIUERetBieId,  "
            strSQL &= "    tblEmpresaPara.TipoHojaId,  "
            strSQL &= "    tblEmpresaPara.Inventario,  "
            strSQL &= "    tblEmpresaPara.ItemCodShow,  "
            strSQL &= "    tblEmpresaPara.PlanCtaShow,  "
            strSQL &= "    tblEmpresaPara.CodBarra,  "
            strSQL &= "    tblEmpresaPara.MultipleNro,  "
            strSQL &= "    tblEmpresaPara.FechaOpera,  "
            strSQL &= "    tblEmpresaPara.CentroCostoApli,  "
            strSQL &= "    tblEmpresaPara.SepararExento,  "
            strSQL &= "    tblEmpresaPara.MontoMinOpe,  "
            strSQL &= "    tblEmpresaPara.MontoMinFac,  "
            strSQL &= "    tblEmpresaPara.AplicarITPDif,  "
            strSQL &= "    tblEmpresaPara.PlanITPDifId,  "
            strSQL &= "    tblEmpresaPara.ExigirEEFF  "
            strSQL &= " FROM tblEmpresaPara "

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
            strSQL = " WHERE  tblEmpresaPara.EmpresaParaId = " & NumberToField(mlngEmpresaParaId)

         Case WhereFilters.Grid
            strSQL = " WHERE  tblEmpresaPara.EmpresaId = " & NumberToField(mlngEmpresaId)

         Case WhereFilters.EmpresaId
            strSQL = " WHERE  tblEmpresaPara.EmpresaId = " & NumberToField(mlngEmpresaId)

      End Select

      Return strSQL
   End Function

   Private Function OrderByFilterGet() As String
      Dim strSQL As String

      Select Case mintOrderByFilter
         Case OrderByFilters.EmpresaParaId
            strSQL = " ORDER BY tblEmpresaPara.EmpresaParaId "

         Case OrderByFilters.Grid

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
            strSQL = "INSERT INTO tblEmpresaPara ("
            strSQL &= "EmpresaParaId, "
            strSQL &= "EmpresaId, "
            strSQL &= "DecimalNro, "
            strSQL &= "DecimalCant, "
            strSQL &= "EmpresaGral, "
            strSQL &= "PlanCreId, "
            strSQL &= "PlanCreDifId, "
            strSQL &= "PlanDebId, "
            strSQL &= "PlanDebDifId, "
            strSQL &= "PlanITId, "
            strSQL &= "PlanITPId, "
            strSQL &= "PlanITFId, "
            strSQL &= "PlanIceIehdId, "
            strSQL &= "PlanIceIehdDifId, "
            strSQL &= "PlanExentoId, "
            strSQL &= "PlanDifId, "
            strSQL &= "PlanAitbId, "
            strSQL &= "PlanResId, "
            strSQL &= "PlanCreRetId, "
            strSQL &= "PlanITRetId, "
            strSQL &= "PlanIUERetSerId, "
            strSQL &= "PlanIUERetBieId, "
            strSQL &= "TipoHojaId, "
            strSQL &= "Inventario, "
            strSQL &= "RepSinGestion, "
            strSQL &= "Repositorio, "
            strSQL &= "ItemCodShow, "
            strSQL &= "PlanCtaShow, "
            strSQL &= "CodBarra, "
            strSQL &= "MultipleNro, "
            strSQL &= "FechaOpera, "
            strSQL &= "CentroCostoApli, "
            strSQL &= "SepararExento, "
            strSQL &= "AplicarDescuento, "
            strSQL &= "MontoMinOpe, "
            strSQL &= "MontoMinFac, "
            strSQL &= "AplicarITPDif, "
            strSQL &= "AplicarMedAlternativa, "
            strSQL &= "AplicarControlInv, "
            strSQL &= "AplicarDosificaVend, "
            strSQL &= "PlanITPDifId, "
            strSQL &= "ExigirEEFF, "
            strSQL &= "ValidarSaldoCajaBanco, "
            strSQL &= "ExigirActAnaAdd, "
            strSQL &= ConcurInsert()
            strSQL &= ") VALUES ("
            strSQL &= NumberToField(mlngEmpresaParaId) & ", "
            strSQL &= NumberToField(mlngEmpresaId) & ", "
            strSQL &= NumberToField(mlngDecimalNro) & ", "
            strSQL &= NumberToField(mlngDecimalCant) & ", "
            strSQL &= StringToField(mstrEmpresaGral) & ", "
            strSQL &= NumberToField(mlngPlanCreId) & ", "
            strSQL &= NumberToField(mlngPlanCreDifId) & ", "
            strSQL &= NumberToField(mlngPlanDebId) & ", "
            strSQL &= NumberToField(mlngPlanDebDifId) & ", "
            strSQL &= NumberToField(mlngPlanITId) & ", "
            strSQL &= NumberToField(mlngPlanITPId) & ", "
            strSQL &= NumberToField(mlngPlanITFId) & ", "
            strSQL &= NumberToField(mlngPlanIceIehdId) & ", "
            strSQL &= NumberToField(mlngPlanIceIehdDifId) & ", "
            strSQL &= NumberToField(mlngPlanExentoId) & ", "
            strSQL &= NumberToField(mlngPlanDifId) & ", "
            strSQL &= NumberToField(mlngPlanAitbId) & ", "
            strSQL &= NumberToField(mlngPlanResId) & ", "
            strSQL &= NumberToField(mlngPlanCreRetId) & ", "
            strSQL &= NumberToField(mlngPlanITRetId) & ", "
            strSQL &= NumberToField(mlngPlanIUERetSerId) & ", "
            strSQL &= NumberToField(mlngPlanIUERetBieId) & ", "
            strSQL &= NumberToField(mlngTipoHojaId) & ", "
            strSQL &= NumberToField(mbytInventario) & ", "
            strSQL &= NumberToField(mbytRepSinGestion) & ", "
            strSQL &= StringToField(mstrRepositorio) & ", "
            strSQL &= NumberToField(mbytItemCodShow) & ", "
            strSQL &= NumberToField(mbytPlanCtaShow) & ", "
            strSQL &= NumberToField(mbytCodBarra) & ", "
            strSQL &= NumberToField(mbytMultipleNro) & ", "
            strSQL &= NumberToField(mbytFechaOpera) & ", "
            strSQL &= NumberToField(mbytCentroCostoApli) & ", "
            strSQL &= NumberToField(mbytSepararExento) & ", "
            strSQL &= NumberToField(mbytAplicarDescuento) & ", "
            strSQL &= DecimalToField(mdecMontoMinOpe) & ", "
            strSQL &= DecimalToField(mdecMontoMinFac) & ", "
            strSQL &= NumberToField(mbytAplicarITPDif) & ", "
            strSQL &= NumberToField(mbytAplicarMedAlternativa) & ", "
            strSQL &= NumberToField(mbytAplicarControlInv) & ", "
            strSQL &= NumberToField(mbytAplicarDosificaVend) & ", "
            strSQL &= NumberToField(mlngPlanITPDifId) & ", "
            strSQL &= NumberToField(mbytExigirEEFF) & ", "
            strSQL &= NumberToField(mbytValidarSaldoCajaBanco) & ", "
            strSQL &= NumberToField(mbytExigirActAnaAdd) & ", "
            strSQL &= ConcurDateInserted(clsAppInfo.LoginId)

      End Select

      Return strSQL
   End Function

   Protected Overrides Function UpdateSQL() As String
      Dim strSQL As String

      Select Case mintUpdateFilter
         Case UpdateFilters.All
            strSQL = "UPDATE tblEmpresaPara SET "
            strSQL &= "EmpresaId = " & NumberToField(mlngEmpresaId) & ", "
            strSQL &= "DecimalNro = " & NumberToField(mlngDecimalNro) & ", "
            strSQL &= "DecimalCant = " & NumberToField(mlngDecimalCant) & ", "
            strSQL &= "EmpresaGral = " & StringToField(mstrEmpresaGral) & ", "
            strSQL &= "PlanCreId = " & NumberToField(mlngPlanCreId) & ", "
            strSQL &= "PlanCreDifId = " & NumberToField(mlngPlanCreDifId) & ", "
            strSQL &= "PlanDebId = " & NumberToField(mlngPlanDebId) & ", "
            strSQL &= "PlanDebDifId = " & NumberToField(mlngPlanDebDifId) & ", "
            strSQL &= "PlanITId = " & NumberToField(mlngPlanITId) & ", "
            strSQL &= "PlanITPId = " & NumberToField(mlngPlanITPId) & ", "
            strSQL &= "PlanITFId = " & NumberToField(mlngPlanITFId) & ", "
            strSQL &= "PlanIceIehdId = " & NumberToField(mlngPlanIceIehdId) & ", "
            strSQL &= "PlanIceIehdDifId = " & NumberToField(mlngPlanIceIehdDifId) & ", "
            strSQL &= "PlanExentoId = " & NumberToField(mlngPlanExentoId) & ", "
            strSQL &= "PlanDifId = " & NumberToField(mlngPlanDifId) & ", "
            strSQL &= "PlanAitbId = " & NumberToField(mlngPlanAitbId) & ", "
            strSQL &= "PlanResId = " & NumberToField(mlngPlanResId) & ", "
            strSQL &= "PlanCreRetId = " & NumberToField(mlngPlanCreRetId) & ", "
            strSQL &= "PlanITRetId = " & NumberToField(mlngPlanITRetId) & ", "
            strSQL &= "PlanIUERetSerId = " & NumberToField(mlngPlanIUERetSerId) & ", "
            strSQL &= "PlanIUERetBieId = " & NumberToField(mlngPlanIUERetBieId) & ", "
            strSQL &= "TipoHojaId = " & NumberToField(mlngTipoHojaId) & ", "
            strSQL &= "Inventario = " & NumberToField(mbytInventario) & ", "
            strSQL &= "RepSinGestion = " & NumberToField(mbytRepSinGestion) & ", "
            strSQL &= "Repositorio = " & StringToField(mstrRepositorio) & ", "
            strSQL &= "ItemCodShow = " & NumberToField(mbytItemCodShow) & ", "
            strSQL &= "PlanCtaShow = " & NumberToField(mbytPlanCtaShow) & ", "
            strSQL &= "CodBarra = " & NumberToField(mbytCodBarra) & ", "
            strSQL &= "MultipleNro = " & NumberToField(mbytMultipleNro) & ", "
            strSQL &= "FechaOpera = " & NumberToField(mbytFechaOpera) & ", "
            strSQL &= "CentroCostoApli = " & NumberToField(mbytCentroCostoApli) & ", "
            strSQL &= "SepararExento = " & NumberToField(mbytSepararExento) & ", "
            strSQL &= "AplicarDescuento = " & NumberToField(mbytAplicarDescuento) & ", "
            strSQL &= "MontoMinOpe = " & DecimalToField(mdecMontoMinOpe) & ", "
            strSQL &= "MontoMinFac = " & DecimalToField(mdecMontoMinFac) & ", "
            strSQL &= "AplicarITPDif = " & NumberToField(mbytAplicarITPDif) & ", "
            strSQL &= "AplicarMedAlternativa = " & NumberToField(mbytAplicarMedAlternativa) & ", "
            strSQL &= "AplicarControlInv = " & NumberToField(mbytAplicarControlInv) & ", "
            strSQL &= "AplicarDosificaVend = " & NumberToField(mbytAplicarDosificaVend) & ", "
            strSQL &= "PlanITPDifId = " & NumberToField(mlngPlanITPDifId) & ", "
            strSQL &= "ExigirEEFF = " & NumberToField(mbytExigirEEFF) & ", "
            strSQL &= "ValidarSaldoCajaBanco = " & NumberToField(mbytValidarSaldoCajaBanco) & ", "
            strSQL &= "ExigirActAnaAdd = " & NumberToField(mbytExigirActAnaAdd) & ", "
            strSQL &= ConcurDateUpdated(mintConcurrencyId, clsAppInfo.LoginId)
            strSQL &= " WHERE "
            strSQL &= " EmpresaParaId = " & NumberToField(mlngEmpresaParaId) & " "

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
               mlngEmpresaParaId = ToLong(oDataRow("EmpresaParaId"))
               mlngEmpresaId = ToLong(oDataRow("EmpresaId"))
               mlngDecimalNro = ToLong(oDataRow("DecimalNro"))
               mlngDecimalCant = ToLong(oDataRow("DecimalCant"))
               mstrEmpresaGral = ToStr(oDataRow("EmpresaGral"))
               mlngPlanCreId = ToLong(oDataRow("PlanCreId"))
               mlngPlanCreDifId = ToLong(oDataRow("PlanCreDifId"))
               mlngPlanDebId = ToLong(oDataRow("PlanDebId"))
               mlngPlanDebDifId = ToLong(oDataRow("PlanDebDifId"))
               mlngPlanITId = ToLong(oDataRow("PlanITId"))
               mlngPlanITPId = ToLong(oDataRow("PlanITPId"))
               mlngPlanITFId = ToLong(oDataRow("PlanITFId"))
               mlngPlanIceIehdId = ToLong(oDataRow("PlanIceIehdId"))
               mlngPlanIceIehdDifId = ToLong(oDataRow("PlanIceIehdDifId"))
               mlngPlanExentoId = ToLong(oDataRow("PlanExentoId"))
               mlngPlanDifId = ToLong(oDataRow("PlanDifId"))
               mlngPlanAitbId = ToLong(oDataRow("PlanAitbId"))
               mlngPlanResId = ToLong(oDataRow("PlanResId"))
               mlngPlanCreRetId = ToLong(oDataRow("PlanCreRetId"))
               mlngPlanITRetId = ToLong(oDataRow("PlanITRetId"))
               mlngPlanIUERetSerId = ToLong(oDataRow("PlanIUERetSerId"))
               mlngPlanIUERetBieId = ToLong(oDataRow("PlanIUERetBieId"))
               mlngTipoHojaId = ToLong(oDataRow("TipoHojaId"))
               mbytInventario = ToByte(oDataRow("Inventario"))
               mbytRepSinGestion = ToByte(oDataRow("RepSinGestion"))
               mstrRepositorio = ToStr(oDataRow("Repositorio"))
               mbytItemCodShow = ToByte(oDataRow("ItemCodShow"))
               mbytPlanCtaShow = ToByte(oDataRow("PlanCtaShow"))
               mbytCodBarra = ToByte(oDataRow("CodBarra"))
               mbytMultipleNro = ToByte(oDataRow("MultipleNro"))
               mbytFechaOpera = ToByte(oDataRow("FechaOpera"))
               mbytCentroCostoApli = ToByte(oDataRow("CentroCostoApli"))
               mbytSepararExento = ToByte(oDataRow("SepararExento"))
               mbytAplicarDescuento = ToByte(oDataRow("AplicarDescuento"))
               mdecMontoMinOpe = ToDecimal(oDataRow("MontoMinOpe"))
               mdecMontoMinFac = ToDecimal(oDataRow("MontoMinFac"))
               mbytAplicarITPDif = ToByte(oDataRow("AplicarITPDif"))
               mbytAplicarMedAlternativa = ToByte(oDataRow("AplicarMedAlternativa"))
               mbytAplicarControlInv = ToByte(oDataRow("AplicarControlInv"))
               mbytAplicarDosificaVend = ToByte(oDataRow("AplicarDosificaVend"))
               mlngPlanITPDifId = ToLong(oDataRow("PlanITPDifId"))
               mbytExigirEEFF = ToByte(oDataRow("ExigirEEFF"))
               mbytValidarSaldoCajaBanco = ToByte(oDataRow("ValidarSaldoCajaBanco"))
               mbytExigirActAnaAdd = ToByte(oDataRow("ExigirActAnaAdd"))
               mstrLastUpdateId = ToStr(oDataRow("sLastUpdate_id"))
               mstrLastUpdateDate = ToStr(oDataRow("dtLastUpdate_dt"))
               mintConcurrencyId = ToInteger(oDataRow("iConcurrency_id"))

            Case SelectFilters.ListBox
               mlngEmpresaParaId = ToLong(oDataRow("EmpresaParaId"))

         End Select

      Catch exp As Exception
         Throw exp
      End Try
   End Sub

   Protected Overrides Function GetNewPrimaryKey() As Boolean
      Try
         GetNewPrimaryKey = False

         Call OpenConection()

         mlngEmpresaParaId = TableIDGet(mstrTableName, "EmpresaParaId", moConnection)

         If mlngEmpresaParaId = -1 Then
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

      If mlngPlanCreId = 0 Then
         strMsg &= "Seleccione la Cuenta para Crédito Fiscal" & vbCrLf
      End If

      If mlngPlanCreDifId = 0 Then
         strMsg &= "Seleccione la Cuenta para Crédito Fiscal Diferido" & vbCrLf
      End If

      If mlngPlanDebId = 0 Then
         strMsg &= "Seleccione la Cuenta para Débito Fiscal" & vbCrLf
      End If

      If mlngPlanDebDifId = 0 Then
         strMsg &= "Seleccione la Cuenta para Débito Fiscal Diferido" & vbCrLf
      End If

      If mlngPlanITId = 0 Then
         strMsg &= "Seleccione la Cuenta para Impuesto a las Transacciones" & vbCrLf
      End If

      If mlngPlanITPId = 0 Then
         strMsg &= "Seleccione la Cuenta para Impuesto a las Transacciones por Pagar" & vbCrLf
      End If

      If mlngPlanITFId = 0 Then
         strMsg &= "Seleccione la Cuenta para Impuesto a las Transacciones Financieras" & vbCrLf
      End If

      If mlngPlanIceIehdId = 0 Then
         strMsg &= "Seleccione la Cuenta para Impuesto al Consumo Especifico ICE/IEHD" & vbCrLf
      End If

      If mlngPlanIceIehdId = 0 Then
         strMsg &= "Seleccione la Cuenta para Impuesto al Consumo Especifico ICE/IEHD Diferido" & vbCrLf
      End If

      If mlngPlanExentoId = 0 Then
         strMsg &= "Seleccione la Cuenta para Exento" & vbCrLf
      End If

      If mlngPlanDifId = 0 Then
         strMsg &= "Seleccione la Cuenta para Diferencia de Cambio" & vbCrLf
      End If

      If mlngPlanAitbId = 0 Then
         strMsg &= "Seleccione la Cuenta para A.I.T.B." & vbCrLf
      End If

      If mlngPlanResId = 0 Then
         strMsg &= "Seleccione la Cuenta para Resultado de la Gestion" & vbCrLf
      End If

      If mlngPlanCreRetId = 0 Then
         strMsg &= "Seleccione la Cuenta para Retención IVA" & vbCrLf
      End If

      If mlngPlanITRetId = 0 Then
         strMsg &= "Seleccione la Cuenta para Retención IT" & vbCrLf
      End If

      If mlngPlanIUERetSerId = 0 Then
         strMsg &= "Seleccione la Cuenta para Retención IUE Servicios" & vbCrLf
      End If

      If mlngPlanIUERetBieId = 0 Then
         strMsg &= "Seleccione la Cuenta para Retención IUE Bienes" & vbCrLf
      End If

      If mlngPlanITPDifId = 0 Then
         strMsg &= "Seleccione la Cuenta para Impuesto a las Transacciones Por Pagar Diferido" & vbCrLf
      End If

      If mlngTipoHojaId = 0 Then
         strMsg &= "Seleccione el Tipo de Hoja" & vbCrLf
      End If

      If mdecMontoMinOpe <= 0 Then
         strMsg &= "Monto Mínimo de Operación Inválido" & vbCrLf
      End If

      If mdecMontoMinFac <= 0 Then
         strMsg &= "Monto Mínimo de Factura Inválido" & vbCrLf
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
         'strSQL &= " FROM tblEmpresaPara "

         'If Not boolReplace Then
         '   strSQL &= " WHERE  tblEmpresaPara.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
         '   strSQL &= " AND  tblEmpresaPara.NroAutorizacion <> 0 "
         'Else
         '   strSQL &= " WHERE  tblEmpresaPara.NroAutorizacion = " & StringToField(mstrNroAutorizacion)
         '   strSQL &= " AND  tblEmpresaPara.NroAutorizacion <> 0 "
         '   strSQL &= " AND  tblEmpresaPara.EmpresaParaId <> " & NumberToField(mlngEmpresaParaId)
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

   Public Function InsertOnly() As Boolean
      Dim oCommand As OleDbCommand
      Dim intRecordsAffected As Integer

      InsertOnly = False

      Try
         If GetNewPrimaryKey() Then
            Call OpenConection()

            oCommand = New OleDbCommand
            oCommand.CommandText = InsertSQL()
            oCommand.Connection = moConnection

            intRecordsAffected = oCommand.ExecuteNonQuery()

            If intRecordsAffected > 0 Then
               Call VMNew.ToOpeAdd(clsTipoOpera.NUEVO)
               InsertOnly = True
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
