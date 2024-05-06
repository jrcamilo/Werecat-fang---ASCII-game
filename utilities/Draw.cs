using System;

public class Draw
{

    public static void DrawCharAtPosition(int x, int y, char character, ConsoleColor color)
    {
        // Draw character at position (x, y)
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(character);
        Console.ResetColor(); // Reset the color to default
    }
}
