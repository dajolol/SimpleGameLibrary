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
        MenuFunctions.inMainMenu = true;

        while (true)
        {
            if (MenuFunctions.inMainMenu == true)
            {
                PrintMenus.PrintDefaultMenuText();
                PrintMenus.PrintMainMenu();
                MenuFunctions.PrintColoredMenu(MenuFunctions.mainMenu);
                switch (MenuFunctions.GetCursorInputMainMenu(x, y))
                {
                    case 1:
                        PrintMenus.PrintDefaultMenuText();
                        PrintMenus.SetSearchAndSortCategoryMenu();
                        MenuFunctions.inMainMenu = false;
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

                // add if-statements to check which menu is active

                MenuFunctions.PrintColoredMenu(MenuFunctions.subMenu);

                if (MenuFunctions.subMenu == MenuFunctions.searchAndSortMenu)

                    switch (MenuFunctions.GetCursorInputSubMenu(x, y))
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

                        case 6:
                            break;

                        case 8:
                            break;

                    }
            }
        }
    }
}