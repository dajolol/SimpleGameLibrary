using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;
        PrintMenus.PrintDefaultMenuText();
        (int x, int y) = Console.GetCursorPosition();
        MenusLogic.inMainMenu = true;

        while (true)
        {
            if (MenusLogic.inMainMenu == true)
            {
                PrintMenus.PrintDefaultMenuText();
                PrintMenus.PrintMainMenu();
                MenusLogic.PrintColoredMenu(MenusLogic.mainMenu);
                switch (MenusLogic.GetCursorInputMainMenu(x, y))
                {
                    case 1:
                        PrintMenus.PrintDefaultMenuText();
                        PrintMenus.SetSearchAndSortCategoryMenu();
                        MenusLogic.inMainMenu = false;
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;
                }
            }
            else
            {

                // add if-statement to check which menu is active

                MenusLogic.PrintColoredMenu(MenusLogic.subMenu);
                switch (MenusLogic.GetCursorInputSubMenu(x, y))
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                }
            }
        }
    }
}