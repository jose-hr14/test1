USE TIENDA;
GO
-- Declarar el cursos
DECLARE Cur_fabricante CURSOR FOR
SELECT codigo, nombre
FROM FABRICANTE
-- ABRIR EL CURSOR
OPEN Cur_fabricante

-- fetch - VARIABLES
DECLARE @CODIGO INT;
DECLARE @NOMBRE VARCHAR(100);
FETCH NEXT FROM Cur_fabricante INTO @CODIGO, @NOMBRE
WHILE (@@FETCH_STATUS = 0)
BEGIN
	PRINT CONCAT(@NOMBRE, ' ', @CODIGO);
	--FETCH NEXT FROM Cur_fabricante INTO @CODIGO, @NOMBRE
END

CLOSE Cur_fabricante;
DEALLOCATE Cur_fabricante;