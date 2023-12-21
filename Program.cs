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
            MenusLogic.PrintColoredMenu(MenusLogic.currentMenu);

            switch (MenusLogic.GetCursorInput(x, y))
            {
                case 1:
                    Console.Clear();
                    PrintMenus.SetSearchAndSortCategoryMenu();
                    MenusLogic.PrintColoredMenu(MenusLogic.currentMenu);
                    switch (MenusLogic.GetCursorInput(x, y))
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Alternativ 1");
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Alternativ 2");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Alternativ 3");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Alternativ 4");
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Alternativ 5");
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Alternativ 6");
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Alternativ 7");
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("Alternativ 8");
                            break;
                    }
                    break;

                case 2:
                    Console.Clear();
                    PrintMenus.SetHandleGamesMenu();
                    break;

                case 3:
                    Console.Clear();
                    PrintMenus.SetHandleConsolesMenu();
                    break;

                case 4:
                    Console.Clear();
                    PrintMenus.SetHandleGenresMenu();
                    break;

                case 5:
                    Console.Clear();
                    PrintMenus.SetHandleBacklogMenu();
                    break;

                case 100:
                    Console.Clear();
                    PrintMenus.PrintMainMenu();
                    break;
            }
        }
    }
}