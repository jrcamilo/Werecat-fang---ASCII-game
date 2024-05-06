using System;

public class MenuHandler
{

        internal void DrawFrame()
    {
        // Draw frame
        int width = Console.WindowWidth;
        int height = Console.WindowHeight;

        // Draw top and bottom borders
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(new string('-', width));
        Console.SetCursorPosition(0, height - 5);
        Console.WriteLine(new string('-', width));

        // Draw left and right borders
        for (int i = 1; i < height - 5; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write("|");
            Console.SetCursorPosition(width - 1, i);
            Console.Write("|");
        }
    }

    internal void DrawMenu()
    {

        // Draw frame
        DrawFrame();

        // Draw menu
        string[] menuItems = { "1. Item 1", "2. Item 2", "3. Item 3", "4. Item 4" };
        int menuTop = Console.WindowHeight - 4;
        Console.SetCursorPosition(0, menuTop);
        Console.ForegroundColor = ConsoleColor.White;
        foreach (string item in menuItems)
        {
            Console.Write(item);
            Console.Write("   ");
        }
        Console.ResetColor();
    }

    
    // Previous position of the character
    static int prevCharacterX = 10;
    static int prevCharacterY = 10;

    public void DrawMap((int x, int y) characterPos)
    {
        // Draw only the elements that have changed
        Draw.DrawCharAtPosition(prevCharacterX, prevCharacterY, ' ', ConsoleColor.Black);
        Draw.DrawCharAtPosition(characterPos.x, characterPos.y, '@', ConsoleColor.White);


        Draw.DrawCharAtPosition(5, 5, '*', ConsoleColor.Red);
        Draw.DrawCharAtPosition(123, 25, 'T', ConsoleColor.Green); // Draw trees
        Draw.DrawCharAtPosition(99, 10, 'T', ConsoleColor.Green);
        Draw.DrawCharAtPosition(25, 5, 'c', ConsoleColor.Yellow);
        Draw.DrawCharAtPosition(27, 5, 'B', ConsoleColor.Green);
        Draw.DrawCharAtPosition(29, 5, 'R', ConsoleColor.Gray);

        
        // Store the previous position
        prevCharacterX = characterPos.x;
        prevCharacterY = characterPos.y;
    }
    
}