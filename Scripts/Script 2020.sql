--14-04-2020

--Control de Registro de Actividades y Analiticos Adicionales
/*******************************************************************
MODULO		:	Contabilidad
AUTOR		:	Yovana Moron
FECHA		:	15/05/2020
DESCRIPCION	:	Si esta tickeado Controlara el Registro de Actividades y Analiticos Adicionales,
				Si la cuenta permite Centro de Costo y Analiticos Adicionales:
				Se validara que se registre una Actividad y varios Análiticos pero no le permitira que 
				añada otra actividad a la Cuenta.
				Por el contrario validara que registre un Análitico y varias Actividades pero no le permitira que
				añada otro Análitico a la cuenta. 
*******************************************************************/

ALTER TABLE tblEmpresaPara add ExigirActAnaAdd bit not null default 0;
GO

