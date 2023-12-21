using System.Transactions;

class PrintMenus
{
    public static void PrintDefaultMenuText()  //Currently not in use
    {
        Console.Clear();
        Console.WriteLine("################## GAME LIBRARY ##################\n");
        Console.ResetColor();
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
        MenusLogic.currentMenu = ["1. Search and sort by category in the library",
                                  "2. Handle games",
                                  "3. Handle consoles",
                                  "4. Handle genres",
                                  "5. Exit program"
                                 ];

        Console.ResetColor();
        ;
    }

    public static void SetSearchAndSortCategoryMenu()
    {
        MenusLogic.currentMenu = ["1. Search and sort by title",
                                  "2. Search and sort by console",
                                  "3. Search and sort by genre",
                                  "4. Search and sort by release date",
                                  "5. Go back to main menu"
                                 ];

        Console.ResetColor();
    }

    public static void SetHandleGamesMenu()
    {
        MenusLogic.currentMenu = ["1. Search and sort by title",
                                  "2. Search and sort by console",
                                  "3. Search and sort by genre",
                                  "4. Search and sort by release date",
                                  "5. Go back to main menu"
                                  ];

        Console.ResetColor();
    }

    public static void SetHandleConsolesMenu()
    {
        string[] menu = ["1. Search and sort by title",
                         "2. Search and sort by console",
                         "3. Search and sort by genre",
                         "4. Search and sort by release date",
                         "5. Go back to main menu"
                        ];

        MenusLogic.currentMenu = menu;

        Console.ResetColor();
    }
}

