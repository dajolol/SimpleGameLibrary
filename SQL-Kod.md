
Console-table query
--------------------------------------------------------------------
INSERT INTO Consoles(ConsoleName) VALUES (@UserInput)
--------------------------------------------------------------------
DELETE FROM Consoles WHERE ConsoleName = @OptionToRemove;
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



Genre-table query
--------------------------------------------------------------------
SELECT GenreName AS ColumnName FROM Genres;
--------------------------------------------------------------------
DELETE FROM Genres WHERE GenreName = @OptionToRemove;
--------------------------------------------------------------------
