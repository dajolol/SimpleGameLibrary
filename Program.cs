using System.Runtime.InteropServices;

internal class Program
{
    private static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;
        (int x, int y) = Console.GetCursorPosition();
        int option = 1;
        //bool inMenu = true;

        do
        {
            Console.SetCursorPosition(x, y);

            Menus.PrintMainMenu(option);

            ConsoleKeyInfo keyPressed;
            keyPressed = Console.ReadKey(false);
            switch (keyPressed.Key)
            {
                case ConsoleKey.UpArrow:
                    option = option == 1 ? 5 : option - 1;
                    break;

                case ConsoleKey.DownArrow:
                    option = option == 5 ? 1 : option + 1;
                    break;

                case ConsoleKey.Enter:
                    break;

                case ConsoleKey.F12:
                    Environment.Exit(0);
                    break;
            }
        } while (true);
    }
}