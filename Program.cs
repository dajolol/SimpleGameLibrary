using System.Runtime.InteropServices;

internal class Program
{
    private static void Main()
    {
        Console.Clear();
        Console.CursorVisible = false;
        (int x, int y) = Console.GetCursorPosition();
        int option = 1;
        string currentMarker = "> \u001b[32m";
        ConsoleKeyInfo keyPressed;
        bool inMenu = true;

        while (inMenu)
        {
            Console.SetCursorPosition(x, y);

            Menus.PrintMainMenu(option, currentMarker);

            keyPressed = Console.ReadKey(false);

            switch (keyPressed.Key)
            {
                case ConsoleKey.UpArrow:
                    if (option == 1)
                    {
                        option = 5;
                    }
                    else
                    {
                        option--;
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (option == 5)
                    {
                        option = 1;
                    }
                    else
                    {
                        option++;
                    }
                    break;

                case ConsoleKey.Enter:
                    inMenu = false;
                    break;
            }
        }
    }
}