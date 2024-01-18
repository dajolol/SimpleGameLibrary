INNER JOIN för Consoles-table
--------------------------------------------------------------------
SELECT ConsoleName, ManufacturerName
FROM Consoles
INNER JOIN Manufacturer
ON Consoles.ManufacturerID = Manufacturer.ManufacturerID
ORDER BY ConsoleName;
--------------------------------------------------------------------
SELECT Consoles.ConsoleName AS 'ColumnName', Manufacturer.ManufacturerName AS 'Manufacturer'
FROM Consoles
INNER JOIN Manufacturer
ON Consoles.ManufacturerID = Manufacturer.ManufacturerID;
--------------------------------------------------------------------