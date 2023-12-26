using System.Transactions;

class PrintMenus
{
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
    public static void PrintMainMenu()
    {
        MenuFunctions.mainMenu = ["1. Search and sort by category in the library",
                                  "2. Handle games",
                                  "3. Handle consoles",
                                  "4. Handle genres",
                                  "5. Handle backlog",
                                  "6. Exit program"
                                 ];

        Console.ResetColor();
    }

    public static void SetSearchAndSortCategoryMenu()
    {
        string[] menu = [ "1. Search and sort by title",
                                  "2. Search and sort by console",
                                  "3. Search and sort by genre",
                                  "4. Search and sort by release date",
                                  "5. Search and sort by completed games",
                                  "6. Search and sort by non-completed games",
                                  "7. Search and sort by personal grade",
                                  "8. Go back to main menu"
                                ];

        MenuFunctions.subMenu = menu;
        MenuFunctions.searchAndSortMenu = menu;
        Console.ResetColor();
    }

    // public static void SetHandleGamesMenu()
    // {
    //     MenusLogic.subMenu = ["1. Add a game to the library",
    //                               "2. Remove a game from the library",
    //                               "3. See all games in the library",
    //                               "4. Go back to main menu"
    //                              ];

    //     Console.ResetColor();
    // }

    // public static void SetHandleConsolesMenu()
    // {
    //     MenusLogic.subMenu = ["1. Add a console to the library",
    //                               "2. Remove a console from the library",
    //                               "3. See all consoles in the library",
    //                               "4. Go back to main menu"
    //                              ];

    //     Console.ResetColor();
    // }

    // public static void SetHandleGenresMenu()
    // {
    //     MenusLogic.subMenu = ["1. Add a new genre to the library",
    //                               "2. Remove a genre from the library",
    //                               "3. See all genres in the library",
    //                               "4. Go back to main menu"
    //                              ];

    //     Console.ResetColor();
    // }

    // public static void SetHandleBacklogMenu()
    // {
    //     MenusLogic.subMenu = ["1. Add a new completion to the library",
    //                               "2. Go back to main menu"
    //                              ];

    //     Console.ResetColor();
    // }
}

