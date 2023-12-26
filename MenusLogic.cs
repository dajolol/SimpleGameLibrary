using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

class MenuFunctions
{
    public static string currentMenuMarker = "> \u001b[32m";

    public static int currentOption = 1;

    public static string[] mainMenu;

    public static string[] subMenu;

    public static string[] searchAndSortMenu;

    public static bool inMainMenu;

    public static bool inSubMenu;

    public static int GetCursorInputMainMenu(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        int neverUsed = 0;
        ConsoleKeyInfo keyPressed;
        keyPressed = Console.ReadKey(true);
        switch (keyPressed.Key)
        {
            case ConsoleKey.UpArrow:
                currentOption = currentOption == 1 ? mainMenu.Length : currentOption - 1;
                break;

            case ConsoleKey.DownArrow:
                currentOption = currentOption == mainMenu.Length ? 1 : currentOption + 1;
                break;

            case ConsoleKey.Enter:
                return currentOption;

            case ConsoleKey.F10:
                inMainMenu = true;
                break;

            case ConsoleKey.F12:
                Console.Clear();
                Environment.Exit(0);
                break;
        }
        return neverUsed;
    }

    public static int GetCursorInputSubMenu(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        int neverUsed = 100;
        ConsoleKeyInfo keyPressed;
        keyPressed = Console.ReadKey(true);
        switch (keyPressed.Key)
        {
            case ConsoleKey.UpArrow:
                currentOption = currentOption == 1 ? subMenu.Length : currentOption - 1;
                break;

            case ConsoleKey.DownArrow:
                currentOption = currentOption == subMenu.Length ? 1 : currentOption + 1;
                break;

            case ConsoleKey.Enter:
                return currentOption;

            case ConsoleKey.F10:
                inMainMenu = true;
                break;

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

}