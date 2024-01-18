INNER JOIN för Consoles-table
--------------------------------------------------------------------
SELECT ConsoleName, ManufacturerName
FROM Consoles
INNER JOIN Manufacturer
ON Consoles.ManufacturerID = Manufacturer.ManufacturerID
ORDER BY ConsoleName;