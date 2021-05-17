USE TIENDA;

DECLARE @nombre AS VARCHAR(100);
DECLARE Cur_fab CURSOR FOR
	SELECT nombre
	FROM FABRICANTE;

OPEN cur_fab;

FETCH NEXT FROM Cur_fab INTO @nombre;

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT @nombre;

	FETCH NEXT FROM Cur_fab INTO @nombre;
END;

CLOSE Cur_fab;
DEALLOCATE Cur_fab;