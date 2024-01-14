using System.Data;
using System.Data.SqlClient;
using System.Text.Json.Serialization;
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
        IEnumerable<dynamic> results = connection.Query<dynamic>("SELECT * FROM Genre;");
        return results;
    }

    public static IEnumerable<dynamic> GetAllConsolesFromDB()
    {
        Open();
        IEnumerable<dynamic> results = connection.Query<dynamic>("SELECT * FROM Genre;");
        return results;
    }

    public static IEnumerable<dynamic> GetAllGenresFromDB()
    {
        Open();
        IEnumerable<dynamic> results = connection.Query<dynamic>("SELECT GenreName FROM Genre;");
        return results;
    }

    public static void AddGenreToDatabase(string userInput)
    {
        Open();
        bool containString = CheckIfContainsString(GetAllGenresFromDB(), userInput);

        if (containString == true)
        {
            Console.WriteLine("A value with that name does already exist in the database. Press Enter to continue and try again.");
            Console.ReadLine();
        }
        else
        {
            connection.Execute($"INSERT INTO Genre(GenreName) VALUES ('{userInput}');");
            Console.WriteLine($"{userInput} was successfully added to the list of genres! Press Enter to continue.");
            Console.ReadLine();
        }
    }

    static bool CheckIfContainsString(IEnumerable<dynamic> resultsFromDb, string userInput)
    {
        foreach (var result in resultsFromDb)
        {
            if (result == userInput)
            {
                return true;
            }
        }
        return false;
    }
}