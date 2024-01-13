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

            // MAINMENU-START

            if (MenuFunctions.inMainMenu == true)
            {
                Menus.PrintDefaultMenuText();
                MenuFunctions.PrintColoredMenu(Menus.mainMenu);
                switch (MenuFunctions.GetCursorInputForCurrentMenu(x, y, Menus.mainMenu))
                {
                    case 1:
                        MenuFunctions.currentOption = 1;
                        MenuFunctions.SetCurrentSubMenu(Menus.searchAndSortMenu);
                        MenuFunctions.inMainMenu = false;
                        MenuFunctions.inSubMenu = true;
                        break;

                    case 2:
                        MenuFunctions.currentOption = 1;
                        MenuFunctions.SetCurrentSubMenu(Menus.handleGamesMenu);
                        MenuFunctions.inMainMenu = false;
                        MenuFunctions.inSubMenu = true;
                        break;

                    case 3:
                        MenuFunctions.currentOption = 1;
                        MenuFunctions.SetCurrentSubMenu(Menus.handleConsolesMenu);
                        MenuFunctions.inMainMenu = false;
                        MenuFunctions.inSubMenu = true;
                        break;

                    case 4:
                        MenuFunctions.currentOption = 1;
                        MenuFunctions.SetCurrentSubMenu(Menus.handleGenresMenu);
                        MenuFunctions.inMainMenu = false;
                        MenuFunctions.inSubMenu = true;
                        break;

                    case 5:
                        MenuFunctions.currentOption = 1;
                        MenuFunctions.SetCurrentSubMenu(Menus.handleBacklogMenu);
                        MenuFunctions.inMainMenu = false;
                        MenuFunctions.inSubMenu = true;
                        break;

                    case 6:
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                }
            }

            // MAINMENU - END

            /*-------------------------------------------------------------------------------*/

            // SUBMENU - START

            else if (MenuFunctions.inSubMenu == true)
            {

                // SEARCH AND SORT MENU - START

                Menus.PrintDefaultMenuText();
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
                            MenuFunctions.currentOption = 1;
                            MenuFunctions.inSubMenu = false;
                            MenuFunctions.inMainMenu = true;
                            break;
                    }
                }

                // SEARCH AND SORT MENU - END

                /*-------------------------------------------------------------------------------*/

                // HANDLE GAMES MENU - START

                else if (MenuFunctions.currentSubMenu == Menus.handleGamesMenu)
                {
                    MenuFunctions.PrintColoredMenu(Menus.handleGamesMenu);
                    switch (MenuFunctions.GetCursorInputForCurrentMenu(x, y, Menus.handleGamesMenu))
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            MenuFunctions.currentOption = 1;
                            MenuFunctions.inSubMenu = false;
                            MenuFunctions.inMainMenu = true;
                            break;
                    }
                }

                // HANDLE GAMES MENU - END

                /*-------------------------------------------------------------------------------*/

                // HANDLE CONSOLES MENU - START

                else if (MenuFunctions.currentSubMenu == Menus.handleConsolesMenu)
                {
                    MenuFunctions.PrintColoredMenu(Menus.handleConsolesMenu);
                    switch (MenuFunctions.GetCursorInputForCurrentMenu(x, y, Menus.handleConsolesMenu))
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            MenuFunctions.currentOption = 1;
                            MenuFunctions.inSubMenu = false;
                            MenuFunctions.inMainMenu = true;
                            break;
                    }
                }

                // HANDLE CONSOLES MENU - END

                /*-------------------------------------------------------------------------------*/

                // HANDLE GENRES MENU - END

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
                            Console.Clear();
                            MenuFunctions.SetGenresList();
                            MenuFunctions.PrintTest(Menus.genreList);
                            Console.WriteLine();
                            Console.WriteLine("Press the Enter-key to exit/continue.");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 4:
                            MenuFunctions.currentOption = 1;
                            MenuFunctions.inMainMenu = true;
                            break;
                    }
                }

                // HANDLE GENRES MENU END

                /*-------------------------------------------------------------------------------*/

                // HANDLE BACKLOG MENU - START

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
                            Console.Clear();
                            MenuFunctions.SetGenresList();
                            MenuFunctions.PrintTest(Menus.genreList);
                            Console.WriteLine();
                            Console.WriteLine("Press the Enter-key to exit/continue.");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 4:
                            MenuFunctions.currentOption = 1;
                            MenuFunctions.inMainMenu = true;
                            break;
                    }
                }
            }
            else if (MenuFunctions.inSecondSubMenu == true)
            {

            }

            else if (MenuFunctions.outsideMenu == true)
            {

            }


        }
    }
}