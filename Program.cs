using System.Runtime.InteropServices;

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
            Console.SetCursorPosition(x, y);

            Menus.PrintMainMenu();

            ConsoleKeyInfo keyPressed;
            keyPressed = Console.ReadKey(false);
            switch (keyPressed.Key)
            {
                case ConsoleKey.UpArrow:
                    Menus.currentOption = Menus.currentOption == 1 ? 5 : Menus.currentOption - 1;
                    break;

                case ConsoleKey.DownArrow:
                    Menus.currentOption = Menus.currentOption == 5 ? 1 : Menus.currentOption + 1;
                    break;

                case ConsoleKey.Enter:
                    break;

                case ConsoleKey.F12:
                    Environment.Exit(0);
                    break;
            }
        } while (inMenu);
    }
}