using System.Security.Cryptography.X509Certificates;

class MenusLogic
{
    static readonly string currentMenuMarker = "> \u001b[32m";

    public static int currentOption = 1;

    public static void GetCursorInput(int x, int y)
    {
        Console.SetCursorPosition(x, y);

        PrintMenus.PrintMainMenu();

        ConsoleKeyInfo keyPressed;
        keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.UpArrow:
                currentOption = currentOption == 1 ? 5 : currentOption - 1;
                break;

            case ConsoleKey.DownArrow:
                currentOption = currentOption == 5 ? 1 : currentOption + 1;
                break;

            case ConsoleKey.Enter:
                break;

            case ConsoleKey.F12:
                Environment.Exit(0);
                break;
        }
    }

    public static void ColorMenuText(string[] menu)
    {
        for (int i = 1; i <= menu.Length; i++)
        {
            if (currentOption == i)
            {
                Console.WriteLine($"{currentMenuMarker}{menu[i - 1]}\u001b[0m");
            }
            else
            {
                Console.WriteLine($"{menu[i - 1]}  \u001b[0m");
            }
        }
    }

}