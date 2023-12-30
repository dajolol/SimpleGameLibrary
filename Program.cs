using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

internal class Program
{
    private static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;
        Menus.PrintDefaultMenuText();
        (int x, int y) = Console.GetCursorPosition();
        MenuFunctions.inMainMenu = true;

        while (true)
        {
            if (MenuFunctions.inMainMenu == true)
            {
                Menus.PrintDefaultMenuText();
                MenuFunctions.PrintColoredMenu(Menus.mainMenu);
                switch (MenuFunctions.GetCursorInputForCurrentMenu(x, y, Menus.mainMenu))
                {
                    case 1:
                        Menus.PrintDefaultMenuText();
                        MenuFunctions.currentOption = 1;
                        MenuFunctions.SetCurrentSubMenu(Menus.searchAndSortMenu);
                        MenuFunctions.inMainMenu = false;
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        Menus.PrintDefaultMenuText();
                        MenuFunctions.currentOption = 1;
                        MenuFunctions.SetCurrentSubMenu(Menus.handleGenresMenu);
                        MenuFunctions.inMainMenu = false;
                        break;

                    case 5:
                        break;

                    case 6:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }
            }
            else
            {

                if (MenuFunctions.currentSubMenu == Menus.searchAndSortMenu)
                {
                    MenuFunctions.PrintColoredMenu(Menus.searchAndSortMenu);
                    switch (MenuFunctions.GetCursorInputForCurrentMenu(x, y, Menus.searchAndSortMenu))
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

                        case 7:
                            break;

                        case 8:
                            MenuFunctions.currentOption = 1;
                            MenuFunctions.inMainMenu = true;
                            break;
                    }
                }

                else if (MenuFunctions.currentSubMenu == Menus.handleGenresMenu)
                {
                    MenuFunctions.PrintColoredMenu(Menus.handleGenresMenu);
                    switch (MenuFunctions.GetCursorInputForCurrentMenu(x, y, Menus.handleGenresMenu))
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            MenuFunctions.currentOption = 1;
                            MenuFunctions.inMainMenu = true;
                            break;
                    }
                }

            }
        }
    }
}