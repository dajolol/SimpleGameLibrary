using System.Transactions;

public class Menus
{
    private string currentMarker = "> \u001b[32m";
    public static void PrintMainMenu(int option, string currentMarker)
    {
        Console.Clear();
        Console.WriteLine("################# GAME LIBRARY #################\n");
        Console.ResetColor();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Scroll through the menu by using the arrow keys,");
        Console.WriteLine("press Enter to choose the option you've selected");
        Console.WriteLine("------------------------------------------------");
        string[] menu = ["1. Search and sort by category in the library", "2. Handle games", "3. Handle Consoles", "4. Handle Genres", "5. Exit program"];

        ColorMenuText(currentMarker, menu, option);

        Console.WriteLine("\n################################################");
        Console.ResetColor();
    }

    public static void ColorMenuText(string currentMarker, string[] menu, int option)
    {
        for (int i = 1; i <= menu.Length; i++)
        {
            if (option == i)
            {
                Console.WriteLine($"{currentMarker}{menu[i - 1]}\u001b[0m");
            }
            else
            {
                Console.WriteLine($"{menu[i - 1]}  \u001b[0m");
            }
        }
    }
}

