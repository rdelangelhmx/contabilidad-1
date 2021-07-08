
Print 'Creating table dbo.TableIDs'
CREATE TABLE dbo.tblTableIDs
(
   szTable_nm varchar(40) NOT NULL,
   lNext_id int NULL,
   sLastUpdate_id char(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TablePK 
   PRIMARY KEY NONCLUSTERED(szTable_nm)
)

Print 'Creating table dbo.tblEstado'
CREATE TABLE dbo.tblEstado
(
   EstadoId int NOT NULL,
   EstadoDes varchar(100) NOT NULL,
   TipoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT EstadoPK 
   PRIMARY KEY NONCLUSTERED(EstadoId)
)

Print 'Creating table dbo.tblMoneda'
CREATE TABLE dbo.tblMoneda
(
   MonedaId int NOT NULL,
   MonedaDes varchar(100) NOT NULL,
   MonedaSigla varchar(10) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT MonedaPK 
   PRIMARY KEY NONCLUSTERED(MonedaId)
)

Print 'Creating table dbo.tblMes'
CREATE TABLE dbo.tblMes
(
   MesId int NOT NULL,
   MesDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT MesPK 
   PRIMARY KEY NONCLUSTERED(MesId)
)

Print 'Creating table dbo.tblCiudad'
CREATE TABLE dbo.tblCiudad
(
   CiudadId int NOT NULL,
   CiudadDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CiudadPK 
   PRIMARY KEY NONCLUSTERED(CiudadId)
)

Print 'Creating table dbo.tblEmpresa'
CREATE TABLE dbo.tblEmpresa
(
   EmpresaId int NOT NULL,
   EmpresaDes varchar(200) NOT NULL,
   EmpresaRUC varchar(50) NULL,
   Direccion varchar(200) NULL,
   CiudadId int NOT NULL,
   Telefono1 varchar(100) NULL,
   Telefono2 varchar(100) NULL,
   Movil varchar(100) NULL,
   Fax varchar(100) NULL,
   CodPostal varchar(100) NULL,
   Email varchar(200) NULL,
   Web varchar(200) NULL,
   MesAperturaId int NOT NULL,
   MesCierreId int NOT NULL,
   MonedaId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT EmpresaPK 
   PRIMARY KEY NONCLUSTERED(EmpresaId)
)

Print 'Creating table dbo.tblTipoPlan'
CREATE TABLE dbo.tblTipoPlan
(
   TipoPlanId int NOT NULL,
   TipoPlanDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoPlanPK 
   PRIMARY KEY NONCLUSTERED(TipoPlanId)
)

Print 'Creating table dbo.tblSucCCO'
CREATE TABLE dbo.tblSucCCO
(
   SucCCOId int NOT NULL,
   SucCCODes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT SucCCOPK 
   PRIMARY KEY NONCLUSTERED(SucCCOId)
)

Print 'Creating table dbo.tblPlan'
CREATE TABLE dbo.tblPlan
(
   PlanId int NOT NULL,
   EmpresaId int NOT NULL,
   PlanCta varchar(50) NOT NULL,
   PlanDes varchar(255) NOT NULL,
   PlanPadreId int NOT NULL,
   Orden int NOT NULL,
   Nivel int NOT NULL,
   EsAna bit NOT NULL,
   MonedaId int NOT NULL,
   TipoPlanId int NOT NULL,
   SucCCOId int NOT NULL,
   TieneAnaAdd bit NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PlanPK 
   PRIMARY KEY NONCLUSTERED(PlanId)
)

Print 'Creating table dbo.tblSucursal'
CREATE TABLE dbo.tblSucursal
(
   SucursalId int NOT NULL,
   EmpresaId int NOT NULL,
   SucursalCod varchar(50) NOT NULL,
   SucursalDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT SucursalPK 
   PRIMARY KEY NONCLUSTERED(SucursalId)
)

Print 'Creating table dbo.tblCentroCosto'
CREATE TABLE dbo.tblCentroCosto
(
   CentroCostoId int NOT NULL,
   EmpresaId int NOT NULL,
   CentroCostoCod varchar(50) NOT NULL,
   CentroCostoDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CentroCostoPK 
   PRIMARY KEY NONCLUSTERED(CentroCostoId)
)

Print 'Creating table dbo.tblCentroCostoDet'
CREATE TABLE dbo.tblCentroCostoDet
(
   CentroCostoDetId int NOT NULL,
   EmpresaId int NOT NULL,
   CentroCostoId int NOT NULL,
   CentroCostoDetCod varchar(50) NOT NULL,
   CentroCostoDetDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CentroCostoDetPK 
   PRIMARY KEY NONCLUSTERED(CentroCostoDetId)
)

Print 'Creating table dbo.tblCompCentroCostoDet'
CREATE TABLE dbo.tblCompCentroCostoDet
(
   CompCentroCostoDetId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompId int NOT NULL,
   CompDetId int NOT NULL,
   Fecha datetime NOT NULL,
   PlanId int NOT NULL,
   MonedaId int NOT NULL,
   CentroCostoId int NOT NULL,
   CentroCostoDetId int NOT NULL,
   DebeOrg decimal(18, 5) NOT NULL,
   HaberOrg decimal(18, 5) NOT NULL,
   DebeBs decimal(18, 5) NOT NULL,
   HaberBs decimal(18, 5) NOT NULL,
   DebeUs decimal(18, 5) NOT NULL,
   HaberUs decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompCentroCostoDetPK 
   PRIMARY KEY NONCLUSTERED(CompCentroCostoDetId)
)

Print 'Creating table dbo.tblPlanAdd'
CREATE TABLE dbo.tblPlanAdd
(
   PlanAddId int NOT NULL,
   EmpresaId int NOT NULL,
   PlanId int NOT NULL,
   PlanAddCta varchar(50) NOT NULL,
   PlanAddDes varchar(255) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PlanAddPK 
   PRIMARY KEY NONCLUSTERED(PlanAddId)
)

Print 'Creating table dbo.tblEmpresaPara'
CREATE TABLE dbo.tblEmpresaPara
(
   EmpresaParaId int NOT NULL,
   EmpresaId int NOT NULL,
   DecimalNro int NOT NULL,
   EmpresaGral varchar(255) NOT NULL,
   PlanCreId int NOT NULL,
   PlanDebId int NOT NULL,
   PlanITId int NOT NULL,
   PlanITPId int NOT NULL,
   PlanITFId int NOT NULL,
   PlanDifId int NOT NULL,
   PlanResId int NOT NULL,
   TipoHojaId int NOT NULL,
   Inventario bit NOT NULL,
   ItemCodShow bit NOT NULL,
   PlanCtaShow bit NOT NULL,
   MultipleNro bit NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT EmpresaParaPK 
   PRIMARY KEY NONCLUSTERED(EmpresaParaId)
)

Print 'Creating table dbo.tblGestion'
CREATE TABLE dbo.tblGestion
(
   GestionId int NOT NULL,
   EmpresaId int NOT NULL,
   Gestion int NOT NULL,
   FechaIni datetime NULL,
   FechaFin datetime NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT GestionPK 
   PRIMARY KEY NONCLUSTERED(GestionId)
)

Print 'Creating table dbo.tblTipoComp'
CREATE TABLE dbo.tblTipoComp
(
   TipoCompId int NOT NULL,
   TipoCompDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoCompPK 
   PRIMARY KEY NONCLUSTERED(TipoCompId)
)

Print 'Creating table dbo.tblCompPara'
CREATE TABLE dbo.tblCompPara
(
   CompParaId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   TipoCompId int NOT NULL,
   NroIni int NOT NULL,
   NroActual int NOT NULL,
   NroAuto bit NOT NULL,
   NroAutoGestion bit NOT NULL,
   Firma varchar(1000) NULL,
   TipoHojaId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompParaPK 
   PRIMARY KEY NONCLUSTERED(CompParaId)
)

Print 'Creating table dbo.tblCompParaMes'
CREATE TABLE dbo.tblCompParaMes
(
   CompParaMesId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   TipoCompId int NOT NULL,
   MesId int NOT NULL,
   NroIni int NOT NULL,
   NroActual int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompParaMesPK 
   PRIMARY KEY NONCLUSTERED(CompParaMesId)
)

Print 'Creating table dbo.tblBanco'
CREATE TABLE dbo.tblBanco
(
   BancoId int NOT NULL,
   BancoDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT BancoPK 
   PRIMARY KEY NONCLUSTERED(BancoId)
)

Print 'Creating table dbo.tblCheque'
CREATE TABLE dbo.tblCheque
(
   ChequeId int NOT NULL,
   EmpresaId int NOT NULL,
   PlanId int NOT NULL,
   BancoId int NOT NULL,
   BancoCta varchar(50) NOT NULL,
   ChequeIni int NOT NULL,
   ChequeFin int NOT NULL,
   ChequeActual int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT ChequePK 
   PRIMARY KEY NONCLUSTERED(ChequeId)
)

Print 'Creating table dbo.tblTipoCambio'
CREATE TABLE dbo.tblTipoCambio
(
   TipoCambioId int NOT NULL,
   Fecha datetime NOT NULL,
   Valor decimal(18, 5) NOT NULL,
   Ufv decimal(18, 5) NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoCambioPK 
   PRIMARY KEY NONCLUSTERED(TipoCambioId)
)

Print 'Creating table dbo.tblComp'
CREATE TABLE dbo.tblComp
(
   CompId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   TipoCompId int NOT NULL,
   CompNro int NOT NULL,
   Fecha datetime NOT NULL,
   MonedaId int NOT NULL,
   TipoCambio decimal(18, 5) NOT NULL,
   EntregadoA varchar(255),
   PorConcepto varchar(255),
   DebeBs decimal(18, 5) NOT NULL,
   HaberBs decimal(18, 5) NOT NULL,
   DebeUs decimal(18, 5) NOT NULL,
   HaberUs decimal(18, 5) NOT NULL,
   PorIVA decimal(18, 5) NOT NULL,
   PorIT decimal(18, 5) NOT NULL,
   PorITF decimal(18, 5) NOT NULL,
   ConFac bit NOT NULL,
   Automatico bit NOT NULL,
   Glosa text NULL,
   TipoNotaId int NOT NULL,
   NotaNro int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompPK 
   PRIMARY KEY NONCLUSTERED(CompId)
)

Print 'Creating table dbo.tblCompDet'
CREATE TABLE dbo.tblCompDet
(
   CompDetId int NOT NULL,
   EmpresaId int NOT NULL,
   CompId int NOT NULL,
   GestionId int NOT NULL,
   TipoCompId int NOT NULL,
   Fecha datetime NULL,
   PlanId int NOT NULL,
   CompDetDes varchar(255),
   SucursalId int NOT NULL,
   CentroCostoId int NOT NULL,
   MonedaId int NOT NULL,
   DebeOrg decimal(18, 5) NOT NULL,
   HaberOrg decimal(18, 5) NOT NULL,
   DebeBs decimal(18, 5) NOT NULL,
   HaberBs decimal(18, 5) NOT NULL,
   DebeUs decimal(18, 5) NOT NULL,
   HaberUs decimal(18, 5) NOT NULL,
   Orden int NOT NULL,
   Automatico bit NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompDetPK 
   PRIMARY KEY NONCLUSTERED(CompDetId)
)

Print 'Creating table dbo.tblCompCheque'
CREATE TABLE dbo.tblCompCheque
(
   CompChequeId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompId int NOT NULL,
   CompDetId int NOT NULL,
   PlanId int NOT NULL,
   ChequeId int NOT NULL,
   Fecha datetime NOT NULL,
   ChequeNro int NOT NULL,
   ChequeDes varchar(100) NOT NULL,
   ChequeMonto decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompChequePK 
   PRIMARY KEY NONCLUSTERED(CompChequeId)
)

Print 'Creating table dbo.tblRegRUC'
CREATE TABLE dbo.tblRegRUC
(
   RegRUCId int NOT NULL,
   EmpresaId int NOT NULL,
   NroRUC varchar(50) NOT NULL,
   RegRUCDes varchar(255) NOT NULL,
   NroAutorizacion varchar(50) NOT NULL,
   PlanId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT RegRUCPK 
   PRIMARY KEY NONCLUSTERED(RegRUCId)
)

Print 'Creating table dbo.tblFactura'
CREATE TABLE dbo.tblFactura
(
   FacturaId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   MesId int NOT NULL,
   SucursalId int NOT NULL,
   DosificaId int NOT NULL,
   TipoCompId int NOT NULL,
   CompId int NOT NULL,
   CompDetId int NOT NULL,
   TipoFacturaId int NOT NULL,
   FacturaFecha datetime NOT NULL,
   FacturaNro bigint NOT NULL,
   FacturaMonto decimal(18, 5) NOT NULL,
   RegRUCId int NOT NULL,
   NroRUC varchar(50) NOT NULL,
   RegRUCDes varchar(255) NOT NULL,
   NroAutorizacion varchar(50) NOT NULL,
   CodControl varchar(50) NOT NULL,
   IVA decimal(18, 5) NOT NULL,
   IceIehd decimal(18, 5) NOT NULL,
   Exento decimal(18, 5) NOT NULL,
   FacturaObs varchar(255) NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT FacturaPK 
   PRIMARY KEY NONCLUSTERED(FacturaId)
)

Print 'Creating table dbo.tblFacturaAgru'
CREATE TABLE dbo.tblFacturaAgru
(
   FacturaAgruId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   MesId int NOT NULL,
   SucursalId int NOT NULL,
   DosificaId int NOT NULL,
   TipoCompId int NOT NULL,
   CompId int NOT NULL,
   CompDetId int NOT NULL,
   FacturaFecha datetime NOT NULL,
   FacturaNroIni bigint NOT NULL,
   FacturaNroFin bigint NOT NULL,
   FacturaMonto decimal(18, 5) NOT NULL,
   NroAutorizacion varchar(50) NOT NULL,
   CodControl varchar(50) NOT NULL,
   IVA decimal(18, 5) NOT NULL,
   IceIehd decimal(18, 5) NOT NULL,
   Exento decimal(18, 5) NOT NULL,
   FacturaObs varchar(255) NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT FacturaAgruPK 
   PRIMARY KEY NONCLUSTERED(FacturaAgruId)
)

Print 'Creating table dbo.tblTipoFactura'
CREATE TABLE dbo.tblTipoFactura
(
   TipoFacturaId int NOT NULL,
   TipoFacturaDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoFacturaPK 
   PRIMARY KEY NONCLUSTERED(TipoFacturaId)
)

Print 'Creating table dbo.tblAduana'
CREATE TABLE dbo.tblAduana
(
   AduanaId int NOT NULL,
   AduanaNIT varchar(50) NOT NULL,
   AduanaDes varchar(255) NOT NULL,
   Direccion varchar(255) NOT NULL,
   Telefono varchar(50) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT AduanaPK 
   PRIMARY KEY NONCLUSTERED(AduanaId)
)

Print 'Creating table dbo.tblPoliza'
CREATE TABLE dbo.tblPoliza
(
   PolizaId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   MesId int NOT NULL,
   CompId int NOT NULL,
   PolizaFecha datetime NOT NULL,
   PolizaNro varchar(50) NOT NULL,
   AduanaId int NOT NULL,
   AduanaNIT varchar(50) NOT NULL,
   AduanaDes varchar(255) NOT NULL,
   PolizaMonto decimal(18, 5) NOT NULL,
   IVA decimal(18, 5) NOT NULL,
   IceIehd decimal(18, 5) NOT NULL,
   PlanId int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PolizaPK 
   PRIMARY KEY NONCLUSTERED(PolizaId)
)

Print 'Creating table dbo.tblImpuesto'
CREATE TABLE dbo.tblImpuesto
(
   ImpuestoId int NOT NULL,
   ImpuestoDes varchar(100) NOT NULL,
   Valor decimal(18, 5) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT ImpuestoPK 
   PRIMARY KEY NONCLUSTERED(ImpuestoId)
)

Print 'Creating table dbo.tblCompPlanAdd'
CREATE TABLE dbo.tblCompPlanAdd
(
   CompPlanAddId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   CompId int NOT NULL,
   CompDetId int NOT NULL,
   Fecha datetime NOT NULL,
   PlanId int NOT NULL,
   MonedaId int NOT NULL,
   PlanAddId int NOT NULL,
   DebeOrg decimal(18, 5) NOT NULL,
   HaberOrg decimal(18, 5) NOT NULL,
   DebeBs decimal(18, 5) NOT NULL,
   HaberBs decimal(18, 5) NOT NULL,
   DebeUs decimal(18, 5) NOT NULL,
   HaberUs decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT CompPlanAddPK 
   PRIMARY KEY NONCLUSTERED(CompPlanAddId)
)

Print 'Creating table dbo.tblReciboPara'
CREATE TABLE dbo.tblReciboPara
(
   ReciboParaId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   TipoCompId int NOT NULL,
   NroIni int NOT NULL,
   NroActual int NOT NULL,
   Firma varchar(1000) NULL,
   TipoHojaId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT ReciboParaPK 
   PRIMARY KEY NONCLUSTERED(ReciboParaId)
)

Print 'Creating table dbo.tblRespaldo'
CREATE TABLE dbo.tblRespaldo
(
   RespaldoId int NOT NULL,
   RespaldoDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT RespaldoPK 
   PRIMARY KEY NONCLUSTERED(RespaldoId)
)

Print 'Creating table dbo.tblRecibo'
CREATE TABLE dbo.tblRecibo
(
   ReciboId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   TipoCompId int NOT NULL,
   CompId int NOT NULL,
   CompNro int NOT NULL,
   Fecha datetime NOT NULL,
   ReciboNro int NOT NULL,
   EntregadoA varchar(255),
   PorConcepto varchar(255),
   Glosa varchar(255),
   MonedaId int NOT NULL,
   Monto decimal(18, 5) NOT NULL,
   RespaldoId int NOT NULL,
   RespaldoNro int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT ReciboPK 
   PRIMARY KEY NONCLUSTERED(ReciboId)
)

Print 'Creating table dbo.tblTipoHoja'
CREATE TABLE dbo.tblTipoHoja
(
   TipoHojaId int NOT NULL,
   TipoHojaDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoHojaPK 
   PRIMARY KEY NONCLUSTERED(TipoHojaId)
)

Print 'Creating table dbo.tblDosifica'
CREATE TABLE dbo.tblDosifica
(
   DosificaId int NOT NULL,
   EmpresaId int NOT NULL,
   SucursalId int NOT NULL,
   NroAutorizacion varchar(50) NOT NULL,
   LlaveDosifica varchar(300) NULL,
   NumeroIni bigint NOT NULL,
   NumeroFin bigint NOT NULL,
   NumeroActual bigint NOT NULL,
   FechaIni datetime NOT NULL,
   FechaFin datetime NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT DosificaPK 
   PRIMARY KEY NONCLUSTERED(DosificaId)
)

Print 'Creating table dbo.tblFacturaPara'
CREATE TABLE dbo.tblFacturaPara
(
   FacturaParaId int NOT NULL,
   EmpresaId int NOT NULL,
   TipoFacturaId int NOT NULL,
   PlanId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT FacturaParaPK 
   PRIMARY KEY NONCLUSTERED(FacturaParaId)
)

Print 'Creating table dbo.tblFacturaDet'
CREATE TABLE dbo.tblFacturaDet
(
   FacturaDetId int NOT NULL,
   EmpresaId int NOT NULL,
   GestionId int NOT NULL,
   FacturaId int NOT NULL,
   ItemId int NOT NULL,
   MedidaId int NOT NULL,
   Cantidad decimal(18, 5) NOT NULL,
   Precio decimal(18, 5) NOT NULL,
   Importe decimal(18, 5) NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT FacturaDetPK 
   PRIMARY KEY NONCLUSTERED(FacturaDetId)
)
