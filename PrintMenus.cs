using System.Transactions;

class PrintMenus
{
    public static void PrintMainMenu()
    {
        Console.Clear();
        Console.WriteLine("################# GAME LIBRARY #################\n");
        Console.ResetColor();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Scroll through the menu by using the arrow keys,");
        Console.WriteLine("press Enter to choose the option you've selected");
        Console.WriteLine("------------------------------------------------");
        string[] menu = ["1. Search and sort by category in the library",
                         "2. Handle games",
                         "3. Handle Consoles",
                         "4. Handle Genres",
                         "5. Exit program"
                        ];

        MenusLogic.ColorMenuText(menu);

        Console.WriteLine("\n################################################");
        Console.ResetColor();
    }
}

