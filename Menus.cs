using System.Transactions;

class Menus
{
    public static string[] mainMenu = [     "1. Search and sort by category in the library",
                                            "2. Handle games",
                                            "3. Handle consoles",
                                            "4. Handle genres",
                                            "5. Handle backlog",
                                            "6. Exit program"
                                        ];
    public static string[] searchAndSortMenu = [   "1. Search and sort by title",
                                                    "2. Search and sort by console",
                                                    "3. Search and sort by genre",
                                                    "4. Search and sort by personal grade",
                                                    "5. Go back to main menu"
                                                ];
    public static string[] handleGamesMenu = [      "1. Add a game to the library",
                                                    "2. Remove a game from the library",
                                                    "3. See all games in the library",
                                                    "4. Go back to main menu"
                                                ];
    public static string[] handleConsolesMenu = [   "1. Add a console to the library",
                                                    "2. Remove a console from the library",
                                                    "3. See all consoles in the library",
                                                    "4. Go back to main menu"
                                                ];
    public static string[] handleGenresMenu = [     "1. Add a new genre to the library",
                                                    "2. Remove a genre from the library",
                                                    "3. See all genres in the library",
                                                    "4. Go back to main menu"
                                                ];
    public static string[] handleBacklogMenu = [    "1. Add game to backlog list",
                                                "2. Update game on backlog list",
                                                "3. See backlog list",
                                                "4. Go back to main menu"
                                            ];
    public static string[] gamesListMenu;
    public static string[] consolesList;
    public static string[] genreList;

    public static void PrintDefaultMenuText()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Scroll through the menu by using the arrow keys.");
        Console.WriteLine("Press Enter to choose the option you've selected.");
        Console.WriteLine("Press the F12-key to exit the program at any time.");
        Console.WriteLine("------------------------------------------------");

        int originalLeft = Console.CursorLeft;
        int originalTop = Console.CursorTop;

        Console.SetCursorPosition(originalLeft, originalTop);
    }

    public static void PrintDefaultOptionsMenuText()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Scroll through the options by using the arrow keys.");
        Console.WriteLine("Press Enter to choose the option you've selected.");
        Console.WriteLine("Press the F12-key to exit the program at any time.");
        Console.WriteLine("------------------------------------------------");

        int originalLeft = Console.CursorLeft;
        int originalTop = Console.CursorTop;

        Console.SetCursorPosition(originalLeft, originalTop);
    }
}

