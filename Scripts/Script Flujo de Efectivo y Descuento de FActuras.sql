-------------------------------------05-07-2017-----------------------------------------
--------------------Contabilidad----------------------
-------------------- Flujo de Efectivo-------------
CREATE TABLE tblPlanEEFF(
	PlanEEFFId int NOT NULL,
	EmpresaId int NOT NULL,
	TipoEEFFId int NOT NULL,
	PlanEEFFPadreId int NOT NULL,
	PlanEEFFDes varchar(255) NOT NULL,
	PlanEEFFCta varchar(50) NOT NULL,
	Nivel int NOT NULL,
	Orden int NOT NULL,
	EsAna bit NOT NULL,
	EstadoId int NOT NULL,
	sLastUpdate_id varchar(50) NULL,
	dtLastUpdate_dt datetime NULL,
	iConcurrency_id smallint NULL,
CONSTRAINT PlanEEFF PRIMARY KEY NONCLUSTERED (PlanEEFFId)) 
GO

alter table tblEmpresaPara add ExigirEEFF bit not null default 0; 
GO

CREATE TABLE tblCompPlanEEFF(
	CompPlanEEFFId int NOT NULL,
	EmpresaId int NOT NULL,
	GestionId int NOT NULL,
	CompId int NOT NULL,
	CompDetId int NOT NULL,
	Fecha datetime NOT NULL,
	PlanEEFFId int NOT NULL,
	MonedaId int NOT NULL,
	PlanId int NOT NULL,
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
 CONSTRAINT CompPlanEEFFPK PRIMARY KEY NONCLUSTERED (CompPlanEEFFId))
GO

--CREACION DE CUENTAS DE PLAN DE EFECTIVO PARA EMPRESAID -1 
INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, 
PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna)
VALUES (0,0,0,0,'','',0,0,0,0);

INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, 
PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna)
VALUES (1,-1,1,0,'INGRESOS DE EFECTIVO','1',1,1,1,0);

INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, 
PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna)
VALUES (2,-1,2,0,'EGRESOS DE EFECTIVO','2',1,2,1,0);

INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, 
PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna)
VALUES (3,-1,1,1,'ACTIVIDADES DE OPERACION','101',2,1,1,0);

INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, 
PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna)
VALUES (4,-1,1,1,'ACTIVIDADES DE INVERSION','102',2,2,1,0);

INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, 
PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna)
VALUES (5,-1,1,1,'ACTIVIDADES DE FINANCIAMIENTO','103',2,3,1,0);

INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, 
PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna)
VALUES (6,-1,2,2,'ACTIVIDADES DE OPERACION','201',2,1,1,0);

INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, 
PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna)
VALUES (7,-1,2,2,'ACTIVIDADES DE INVERSION','202',2,2,1,0);

INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, 
PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna)
VALUES (8,-1,2,2,'ACTIVIDADES DE FINANCIAMIENTO','203',2,3,1,0);


--CURSOR PARA CREAR PLAN DE CUENTAS DE FLUJO DE EFECTIVO POR CADA EMPRESA
DECLARE @EmpresaId int, @i int, @PlanEEFFId int, @TipoEEFFId int, @PlanEEFFPadreId int, @PlanEEFFDes varchar(255), @PlanEEFFCta varchar(50), @Nivel int, @Orden int, @EstadoId int, @EsAna bit, @PlanEEFFIdNew int, @PlanEEFFIdPadreNew int
DECLARE tblEmpresa_Cur CURSOR FOR
SELECT EmpresaId
FROM tblEmpresa
WHERE EmpresaId > 0
ORDER BY EmpresaId

OPEN tblEmpresa_Cur
FETCH NEXT FROM tblEmpresa_Cur INTO @EmpresaId 

WHILE @@FETCH_STATUS = 0
BEGIN

	--PRINT @EmpresaId;
	set @i = (SELECT count(*) FROM tblPlanEEFF WHERE EmpresaId = @EmpresaId);
	PRINT @i;

	IF (@i = 0)
	BEGIN
		DECLARE tblPlanEEFF_Cur CURSOR FOR
		SELECT PlanEEFFId, TipoEEFFId, PlanEEFFPadreId, PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna
		FROM tblPlanEEFF
		WHERE tblPlanEEFF.EmpresaId = -1 
		ORDER BY TipoEEFFId, Nivel

		OPEN tblPlanEEFF_Cur
		FETCH NEXT FROM tblPlanEEFF_Cur INTO @PlanEEFFId, @TipoEEFFId, @PlanEEFFPadreId, @PlanEEFFDes, @PlanEEFFCta, @Nivel, @Orden, @EstadoId, @EsAna  
		
		WHILE @@FETCH_STATUS = 0
		BEGIN
			SET @PlanEEFFIdNew = (SELECT MAX(PlanEEFFId) + 1 FROM tblPlanEEFF);
			IF @PlanEEFFPadreId = 0
			BEGIN
				INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna) values
				(@PlanEEFFIdNew, @EmpresaId, @TipoEEFFId, 0, @PlanEEFFDes, @PlanEEFFCta, @Nivel, @Orden, @EstadoId, @EsAna);
			
				set @PlanEEFFIdPadreNew = @PlanEEFFIdNew;
			END 
			ELSE 
				SET @PlanEEFFIdPadreNew = (SELECT PlanEEFFId from tblPlanEEFF where EmpresaId = @EmpresaId and PlanEEFFCta = @PlanEEFFCta);
			

			DECLARE tblPlanEEFF_SubCur CURSOR FOR
			SELECT PlanEEFFId, TipoEEFFId, PlanEEFFPadreId, PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna
			FROM tblPlanEEFF
			WHERE tblPlanEEFF.EmpresaId = -1 and PlanEEFFPadreId = @PlanEEFFId
					
			OPEN tblPlanEEFF_SubCur
			FETCH NEXT FROM tblPlanEEFF_SubCur INTO @PlanEEFFId, @TipoEEFFId, @PlanEEFFPadreId, @PlanEEFFDes, @PlanEEFFCta, @Nivel, @Orden, @EstadoId, @EsAna

			WHILE @@FETCH_STATUS = 0
			BEGIN
				SET @PlanEEFFIdNew = (SELECT MAX(PlanEEFFId) + 1 FROM tblPlanEEFF);

				INSERT INTO tblPlanEEFF(PlanEEFFId, EmpresaId, TipoEEFFId, PlanEEFFPadreId, PlanEEFFDes, PlanEEFFCta, Nivel, Orden, EstadoId, EsAna) values
				(@PlanEEFFIdNew, @EmpresaId, @TipoEEFFId, @PlanEEFFIdPadreNew, @PlanEEFFDes, @PlanEEFFCta, @Nivel, @Orden, @EstadoId, @EsAna);

			FETCH NEXT FROM tblPlanEEFF_SubCur INTO @PlanEEFFId, @TipoEEFFId, @PlanEEFFPadreId, @PlanEEFFDes, @PlanEEFFCta, @Nivel, @Orden, @EstadoId, @EsAna
			END
			CLOSE tblPlanEEFF_SubCur	
			DEALLOCATE tblPlanEEFF_SubCur

		FETCH NEXT FROM tblPlanEEFF_Cur INTO @PlanEEFFId, @TipoEEFFId, @PlanEEFFPadreId, @PlanEEFFDes, @PlanEEFFCta, @Nivel, @Orden, @EstadoId, @EsAna  
		END
		CLOSE tblPlanEEFF_Cur 
		DEALLOCATE  tblPlanEEFF_Cur 
	END  
FETCH NEXT FROM tblEmpresa_Cur INTO @EmpresaId 
END 
CLOSE tblEmpresa_Cur 
DEALLOCATE  tblEmpresa_Cur 
GO

--PRINT @i
DELETE FROM tblTableIDs WHERE tblTableIDs.szTable_nm = 'tblPlanEEFF'
GO

-------------------------------Descuento en Facturas------------------------------------------
alter table tblEmpresaPara add AplicarDescuento bit not null default 0;
GO
alter table tblCompDet add TipoId int default 0;
GO
alter table tblFacturaPara add PlanDescuentoId int not null default 0;
GO
alter table tblCompDet add CompDetIdOrg int not null default 0;
GO