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
            MenusLogic.GetCursorInput(x, y);
        }
        while (inMenu);
    }
}