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
                PrintMenus.PrintAndSetMainMenu();
                MenuFunctions.PrintColoredMenu(PrintMenus.mainMenu);
                switch (MenuFunctions.GetCursorInputForCurrentMenu(x, y, PrintMenus.mainMenu))
                {
                    case 1:
                        PrintMenus.PrintDefaultMenuText();
                        MenuFunctions.currentOption = 1;
                        PrintMenus.PrintAndSetSearchAndSortCategoryMenu();
                        MenuFunctions.inMainMenu = false;
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        PrintMenus.PrintDefaultMenuText();
                        MenuFunctions.currentOption = 1;
                        PrintMenus.PrintAndSetHandleGenresMenu();
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

                if (MenuFunctions.currentSubMenu == PrintMenus.searchAndSortMenu)
                {
                    MenuFunctions.PrintColoredMenu(PrintMenus.searchAndSortMenu);
                    switch (MenuFunctions.GetCursorInputForCurrentMenu(x, y, PrintMenus.searchAndSortMenu))
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

                else if (MenuFunctions.currentSubMenu == PrintMenus.handleGenresMenu)
                {
                    MenuFunctions.PrintColoredMenu(PrintMenus.handleGenresMenu);
                    switch (MenuFunctions.GetCursorInputForCurrentMenu(x, y, PrintMenus.handleGenresMenu))
                    {
                        case 1:
                            break;

                        case 2:
                            Console.Clear();
                            PrintMenus.PrintAndSetGenresMenu();
                            MenuFunctions.PrintColoredMenu(PrintMenus.genreMenu);
                            Console.ReadLine();
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