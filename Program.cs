using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;
        (int x, int y) = Console.GetCursorPosition();
        bool inRootMenu = true;

        while (inRootMenu)
        {
            PrintMenus.PrintDefaultMenuText();
            PrintMenus.PrintMainMenu();
            bool inSubmenu = MenusLogic.GetCursorInput(x, y);
            while (inSubmenu)
            {
                MenusLogic.GetCursorInput(x, y);
            }
        }
    }
}