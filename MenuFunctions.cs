using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

class MenuFunctions
{
    public static string currentMenuMarker = "> \u001b[32m";
    public static int currentOption = 1;
    public static string[] currentSubMenu;
    public static bool inMainMenu;
    public static bool inSubMenu;
    public static bool inSecondSubMenu;
    public static bool outsideMenu;

    public static int GetCursorInputForCurrentMenu(int x, int y, string[] currentMenu)
    {
        Console.SetCursorPosition(x, y);
        int neverUsed = 0;
        ConsoleKeyInfo keyPressed;
        keyPressed = Console.ReadKey(true);
        switch (keyPressed.Key)
        {
            case ConsoleKey.UpArrow:
                currentOption = currentOption == 1 ? currentMenu.Length : currentOption - 1;
                break;

            case ConsoleKey.DownArrow:
                currentOption = currentOption == currentMenu.Length ? 1 : currentOption + 1;
                break;

            case ConsoleKey.Enter:
                return currentOption;

            case ConsoleKey.F12:
                Console.Clear();
                Environment.Exit(0);
                break;
        }
        return neverUsed;
    }

    public static void PrintColoredMenu(string[] currentMenu)
    {
        for (int i = 1; i <= currentMenu.Length; i++)
        {
            if (currentOption == i)
            {
                Console.WriteLine($"{currentMenuMarker}{currentMenu[i - 1]}\u001b[0m");
            }
            else
            {
                Console.WriteLine($"{currentMenu[i - 1]}  \u001b[0m");
            }
        }
    }

    public static void SetCurrentSubMenu(string[] menu)
    {
        currentSubMenu = menu;
    }

    public static void PrintTest(string[] genreListMenu)
    {
        for (int i = 0; i < genreListMenu.Length; i++)
        {
            Console.WriteLine(genreListMenu[i]);
        }
        // foreach (var row in genreListMenu)
        // {
        //     Console.WriteLine(row);
        // }
    }

    public static void SetGenresList()
    {
        var results = SqlFunctions.GetAllGenresFromDB();
        List<string> menu = new();
        foreach (var row in results)
        {
            menu.Add($"{row.GenreID}. {row.GenreName}");
        }
        Menus.genreList = menu.ToArray();
    }

}