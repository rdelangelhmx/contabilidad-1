

Print 'Creating table dbo.tblTipoEEFF'
CREATE TABLE dbo.tblTipoEEFF
(
   TipoEEFFId int NOT NULL,
   TipoEEFFDes varchar(100) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoEEFFPK 
   PRIMARY KEY NONCLUSTERED(TipoEEFFId)
)
GO

INSERT INTO tblTipoEEFF(TipoEEFFId, TipoEEFFDes) VALUES (1, 'Estado de Flujo de Efectivo')

Print 'Creating table dbo.tblPlanEEFF'
CREATE TABLE dbo.tblPlanEEFF
(
   PlanEEFFId int NOT NULL,
   EmpresaId int NOT NULL,
   TipoEEFFId int NOT NULL,
   PlanEEFFPadreId int NOT NULL,
   PlanEEFFCta varchar(50) NOT NULL,
   PlanEEFFDes varchar(255) NOT NULL,
   PlanId int NOT NULL,
   Nivel int NOT NULL,
   Orden int NOT NULL,
   Grupo int NOT NULL,
   EstadoId int NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT PlanEEFFPK 
   PRIMARY KEY NONCLUSTERED(PlanEEFFId)
)





Print 'Buscar un campo en una base de datos'
SELECT TABLE_NAME,*
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE COLUMN_NAME LIKE '%BancoId%'






Print 'Creating table dbo.tblTipoFacCompra'
CREATE TABLE dbo.tblTipoFacCompra
(
   TipoFacCompraId int NOT NULL,
   TipoFacCompraDes varchar(255) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoFacCompraPK 
   PRIMARY KEY NONCLUSTERED(TipoFacCompraId)
)
GO

INSERT INTO tblTipoFacCompra(TipoFacCompraId, TipoFacCompraDes) VALUES (0, 'Sin Definir')
INSERT INTO tblTipoFacCompra(TipoFacCompraId, TipoFacCompraDes) VALUES (1, 'Compras para mercado interno con destino a actividades gravadas')
INSERT INTO tblTipoFacCompra(TipoFacCompraId, TipoFacCompraDes) VALUES (2, 'Compras para mercado interno con destino a actividades no gravadas')
INSERT INTO tblTipoFacCompra(TipoFacCompraId, TipoFacCompraDes) VALUES (3, 'Compras sujetas a proporcionalidad')
INSERT INTO tblTipoFacCompra(TipoFacCompraId, TipoFacCompraDes) VALUES (4, 'Compras para exportaciones')
INSERT INTO tblTipoFacCompra(TipoFacCompraId, TipoFacCompraDes) VALUES (5, 'Compras tanto para el mercado interno como para exportaciones')

ALTER TABLE tblFactura ADD Descuento decimal(18,5) NOT NULL DEFAULT 0
ALTER TABLE tblFactura ADD TipoFacCompraId int NOT NULL DEFAULT 0
ALTER TABLE tblPoliza ADD TipoFacCompraId int NOT NULL DEFAULT 1

UPDATE tblFactura SET TipoFacCompraId = 1 WHERE TipoFacturaId = 2 

DELETE FROM tblRegRUC WHERE tblRegRUC.RegRUCId = 0
DELETE FROM tblRegRUC WHERE tblRegRUC.RegRUCId = 1
DELETE FROM tblRegRUC WHERE tblRegRUC.RegRUCId = 2
DELETE FROM tblRegRUC WHERE tblRegRUC.RegRUCId = 3
DELETE FROM tblRegRUC WHERE tblRegRUC.RegRUCId = 4
GO

INSERT INTO tblRegRUC(RegRUCId, EmpresaId, NroRUC, RegRUCDes, NroAutorizacion, PlanId) VALUES (0, 0, '0', 'Sin Definir', 0, 0)
INSERT INTO tblRegRUC(RegRUCId, EmpresaId, NroRUC, RegRUCDes, NroAutorizacion, PlanId) VALUES (1, 0, '0', 'ANULADA', 0, 0)
INSERT INTO tblRegRUC(RegRUCId, EmpresaId, NroRUC, RegRUCDes, NroAutorizacion, PlanId) VALUES (2, 0, '0', 'EXTRAVIADA', 0, 0)
INSERT INTO tblRegRUC(RegRUCId, EmpresaId, NroRUC, RegRUCDes, NroAutorizacion, PlanId) VALUES (3, 0, '0', 'NO UTILIZADA', 0, 0)
INSERT INTO tblRegRUC(RegRUCId, EmpresaId, NroRUC, RegRUCDes, NroAutorizacion, PlanId) VALUES (4, 0, '0', 'EMITIDA EN CONTINGENCIA', 0, 0)




Print 'Creating table dbo.tblTipoRespImp'
CREATE TABLE dbo.tblTipoRespImp
(
   TipoRespImpId int NOT NULL,
   TipoRespImpDes varchar(255) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoRespImpPK 
   PRIMARY KEY NONCLUSTERED(TipoRespImpId)
)
GO

INSERT INTO tblTipoRespImp(TipoRespImpId, TipoRespImpDes) VALUES (1, 'Usuario Conectado')
INSERT INTO tblTipoRespImp(TipoRespImpId, TipoRespImpDes) VALUES (2, 'Usuario Creador')

ALTER TABLE tblCompPara ADD TipoRespImpId int NOT NULL DEFAULT 1






ALTER TABLE tblEmpresaPara ADD SepararExento bit NOT NULL DEFAULT 0








Print 'Creating table dbo.tblTipoGrupo'
CREATE TABLE dbo.tblTipoGrupo
(
   TipoGrupoId int NOT NULL,
   TipoGrupoDes varchar(255) NOT NULL,
   sLastUpdate_id varchar(50) NULL,
   dtLastUpdate_dt datetime NULL,
   iConcurrency_id smallint NULL,
   CONSTRAINT TipoGrupoPK 
   PRIMARY KEY NONCLUSTERED(TipoGrupoId)
)
GO
INSERT INTO tblTipoGrupo(TipoGrupoId, TipoGrupoDes) VALUES (1, 'Activo')
INSERT INTO tblTipoGrupo(TipoGrupoId, TipoGrupoDes) VALUES (2, 'Pasivo')
INSERT INTO tblTipoGrupo(TipoGrupoId, TipoGrupoDes) VALUES (3, 'Patrimonio')
INSERT INTO tblTipoGrupo(TipoGrupoId, TipoGrupoDes) VALUES (4, 'Ingreso')
INSERT INTO tblTipoGrupo(TipoGrupoId, TipoGrupoDes) VALUES (5, 'Costo')
INSERT INTO tblTipoGrupo(TipoGrupoId, TipoGrupoDes) VALUES (6, 'Gasto')
INSERT INTO tblTipoGrupo(TipoGrupoId, TipoGrupoDes) VALUES (7, 'De Orden Deudoras')
INSERT INTO tblTipoGrupo(TipoGrupoId, TipoGrupoDes) VALUES (8, 'De Orden Acreedoras')

ALTER TABLE tblPlan ADD TipoGrupoId int NOT NULL DEFAULT 0
GO
Update tblPlan SET TipoGrupoId = SUBSTRING(PlanCta, 1, 1)



