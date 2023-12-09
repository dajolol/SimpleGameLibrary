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

            // Console.WriteLine($"{(option == 1 ? currentMarker : "  ")}1. Search and sort by category in the library\u001b[0m");
            // Console.WriteLine($"{(option == 2 ? currentMarker : "  ")}2. Handle games\u001b[0m");
            // Console.WriteLine($"{(option == 3 ? currentMarker : "  ")}3. Handle Consoles\u001b[0m");
            // Console.WriteLine($"{(option == 4 ? currentMarker : "  ")}4. Handle Genres\u001b[0m");
            // Console.WriteLine($"{(option == 5 ? currentMarker : "  ")}5. Exit program\u001b[0m");

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