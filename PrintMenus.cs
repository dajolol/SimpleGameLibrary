using System.Transactions;

class PrintMenus
{
    public static void PrintDefaultMenuText()
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
        string[] menu = ["1. Search and sort by category in the library",
                         "2. Handle games",
                         "3. Handle Consoles",
                         "4. Handle Genres",
                         "5. Exit program"
                        ];

        MenusLogic.currentMenu = menu;
        MenusLogic.ColorMenuText(MenusLogic.currentMenu);

        Console.WriteLine("\n################################################");
        Console.ResetColor();
    }
}

