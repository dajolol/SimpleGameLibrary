using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.SqlServer.Server;
class SqlFunctions
{
    static IDbConnection connection = new SqlConnection("Server=localhost,1433;User=sa;Password=apA123!#!;Database=GameLibrary;");

    private static void Open()
    {
        if (connection.State != ConnectionState.Open)
            connection.Open();
    }

    public static IEnumerable<dynamic> GetAllGamesFromDB()
    {
        Open();
        IEnumerable<dynamic> results = connection.Query<dynamic>("");
        return results;
    }
    public static IEnumerable<dynamic> GetAllConsolesFromDB()
    {
        Open();
        IEnumerable<dynamic> results = connection.Query<dynamic>("SELECT Consoles.ConsoleName AS 'ColumnName', Manufacturer.ManufacturerName AS 'Manufacturer' FROM Consoles INNER JOIN Manufacturer ON Consoles.ManufacturerID = Manufacturer.ManufacturerID;");
        return results;
    }
    public static IEnumerable<dynamic> GetAllGenresFromDB()
    {
        Open();
        IEnumerable<dynamic> results = connection.Query<dynamic>("SELECT GenreName AS ColumnName FROM Genres;");
        return results;
    }

    public static void AddGenreToDatabase(string userInput)
    {
        Open();
        bool containString = CheckIfContainsString(GetAllGenresFromDB(), userInput);

        if (containString == true)
        {
            Console.WriteLine("A value with that name does already exist in the list of genres. Press Enter to continue and try again.");
            Console.ReadLine();
        }
        else
        {
            connection.Execute($"INSERT INTO Genres(GenreName) VALUES (@UserInput);", new { UserInput = userInput });
            Console.WriteLine($"{userInput} was successfully added to the list of genres! Press Enter to continue.");
            Console.ReadLine();
        }
    }

    public static void RemoveGenreFromDatabase(int currentOption)
    {
        string optionToRemove = Menus.genreList[currentOption - 1];
        Console.Clear();
        connection.Execute($"DELETE FROM Genres WHERE GenreName = @OptionToRemove;", new { OptionToRemove = optionToRemove });
        Console.WriteLine($"\"{optionToRemove}\" was successfully deleted from the list of genres! Press Enter to continue.");
        Console.ReadLine();
    }
    public static void AddConsoleToDatabase(string userInput)
    {
        Open();
        bool containString = CheckIfContainsString(GetAllConsolesFromDB(), userInput);

        if (containString == true)
        {
            Console.WriteLine("A value with that name does already exist in the list of consoles. Press Enter to continue and try again.");
            Console.ReadLine();
        }
        else
        {
            connection.Execute($"INSERT INTO Consoles(ConsoleName) VALUES (@UserInput);", new { UserInput = userInput });
            Console.WriteLine($"{userInput} was successfully added to the list of consoles! Press Enter to continue.");
            Console.ReadLine();
        }
    }
    public static void RemoveConsoleFromDatabase(int currentOption)
    {
        string optionToRemove = Menus.consoleList[currentOption - 1];
        Console.Clear();
        connection.Execute($"DELETE FROM Consoles WHERE ConsoleName = @OptionToRemove;", new { OptionToRemove = optionToRemove });
        Console.WriteLine($"{optionToRemove} was successfully deleted from the list of genres! Press Enter to continue.");
        Console.ReadLine();
    }

    static bool CheckIfContainsString(IEnumerable<dynamic> resultsFromDb, string stringToCheck)
    {
        List<string> tempList = new();
        foreach (var row in resultsFromDb)
        {
            tempList.Add($"{row.ColumnName}");
        }

        foreach (var result in tempList)
        {
            if (result == stringToCheck)
            {
                return true;
            }
        }
        return false;
    }
}