using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;
        (int x, int y) = Console.GetCursorPosition();
        bool inMenu = true;

        do
        {
            PrintMenus.PrintDefaultMenuText();
            PrintMenus.PrintMainMenu();
            MenusLogic.GetCursorInput(x, y);
        }
        while (true);
    }
}