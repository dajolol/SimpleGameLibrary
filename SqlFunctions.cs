using System.Data;
using System.Data.SqlClient;
using Dapper;
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
        IEnumerable<dynamic> results = connection.Query<dynamic>("SELECT * FROM Genre;");
        return results;
    }
}