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
        PrintMenus.PrintMainMenu();
        Console.Clear();

        while (true)
        {
            MenusLogic.PrintAndColorMenu(MenusLogic.currentMenu);

            switch (MenusLogic.GetCursorInput(x, y))
            {
                case 1:
                    Console.Clear();
                    PrintMenus.SetSearchAndSortCategoryMenu();
                    break;

                case 2:
                    Console.WriteLine("Menu choice 2");
                    break;

                case 3:
                    Console.WriteLine("Menu choice 3");
                    break;

                case 4:
                    Console.WriteLine("Menu choice 4");
                    break;

                case 5:
                    Console.Clear();
                    PrintMenus.PrintMainMenu();
                    break;
            }
        }
    }
}