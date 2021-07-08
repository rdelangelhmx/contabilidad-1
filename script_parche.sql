-- parche "Plan de cuentas"
-- Trabajado en Base de datos CONDOBO>tblPlan
-- Update rows in table 'tblPlan'

-- ACTIVO

-- Error de nivel y orden
UPDATE tblPlan
SET
    Orden = 4,
    Nivel = 4
WHERE PlanId = 199

-- Error de id en plan padre
UPDATE tblPlan
SET
    PlanPadreId = 10
WHERE PlanId BETWEEN 11 AND 17

UPDATE tblPlan
SET
    PlanPadreId = 18
WHERE PlanId BETWEEN 19 AND 24

UPDATE tblPlan
SET
    PlanPadreId = 59
WHERE PlanId BETWEEN 60 AND 75

UPDATE tblPlan
SET
    PlanPadreId = 76
WHERE PlanId BETWEEN 77 AND 80

UPDATE tblPlan
SET
    PlanPadreId = 89
WHERE PlanId = 90

UPDATE tblPlan
SET
    PlanPadreId = 88
WHERE PlanId BETWEEN 91 AND 93

UPDATE tblPlan
SET
    PlanPadreId = 94
WHERE PlanId = 95

UPDATE tblPlan
SET
    PlanPadreId = 95
WHERE PlanId BETWEEN 96 AND 97

UPDATE tblPlan
SET
    PlanPadreId = 98
WHERE PlanId BETWEEN 99 AND 101

UPDATE tblPlan
SET
    PlanPadreId = 102
WHERE PlanId = 103

UPDATE tblPlan
SET
    PlanPadreId = 103
WHERE PlanId BETWEEN 104 AND 122

UPDATE tblPlan
SET
    PlanPadreId = 123
WHERE PlanId = 124

UPDATE tblPlan
SET
    PlanPadreId = 124
WHERE PlanId BETWEEN 125 AND 126

UPDATE tblPlan
SET
    PlanPadreId = 127
WHERE PlanId = 128

UPDATE tblPlan
SET
    PlanPadreId = 128
WHERE PlanId BETWEEN 129 AND 131

UPDATE tblPlan
SET
    PlanPadreId = 132
WHERE PlanId BETWEEN 133 AND 135

UPDATE tblPlan
SET
    PlanPadreId = 205
WHERE PlanId BETWEEN 206 AND 208

UPDATE tblPlan
SET
    PlanPadreId = 209
WHERE PlanId = 210

-- PASIVO

-- Error de id en plan padre
UPDATE tblPlan
SET
    PlanPadreId = 301
WHERE PlanId BETWEEN 302 AND 305

UPDATE tblPlan
SET
    PlanPadreId = 306
WHERE PlanId BETWEEN 307 AND 309

UPDATE tblPlan
SET
    PlanPadreId = 311
WHERE PlanId BETWEEN 312 AND 318

UPDATE tblPlan
SET
    PlanPadreId = 348
WHERE PlanId BETWEEN 349 AND 353

-- PATRIMONIO