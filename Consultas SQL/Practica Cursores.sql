--1.- Nombre de productos en BD TIENDA
--Utilizando la BD TIENDA, crea un script que recorra con cursores la tabla PRODUCTO y
--que muestre el nombre de cada producto por pantalla.
USE TIENDA;
-- DECLARACIÓN DEL CURSOR
DECLARE Cur_Producto CURSOR FOR
SELECT nombre
FROM FABRICANTE;
-- APERTURA DEL CURSOR
OPEN Cur_Producto
-- LECTURA DE LA PRIMERA FILA DEL CURSOR
FETCH NEXT FROM <NOMBRE_CURSOR> INTO <LISTA_VARIABLES>
WHILE (@@FETCH_STATUS = 0)
BEGIN
-- LECTURA DE LA SIGUIENTE FILA DE UN CURSOR
FETCH NEXT FROM <NOMBRE_CURSOR> INTO <LISTA_VARIABLES>
-- ACCIONES A REALIZAR PARA CADA REGISTRO
 ...
END -- FIN DEL BUCLE WHILE
-- CIERRA EL CURSOR
CLOSE <NOMBRE_CURSOR>
-- LIBERA LOS RECURSOS DEL CURSOR (MEMORIA)
DEALLOCATE <NOMBRE_CURSOR>