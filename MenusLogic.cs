using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

class MenusLogic
{
    static readonly string currentMenuMarker = "> \u001b[32m";

    public static int currentOption;

    public static string[] currentMenu;

    public static int GetCursorInput(int x, int y)
    {
        Console.SetCursorPosition(x, y);
        int neverUsed = 100;
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

}