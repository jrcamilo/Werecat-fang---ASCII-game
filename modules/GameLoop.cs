using System;

public class GameLoop
{
    
    // Initial position of the character
    static int characterX = 10;
    static int characterY = 10;

    // Previous position of the character
    static int prevCharacterX = characterX;
    static int prevCharacterY = characterY;
    
    public static void SomeMethod()
    {

        while (true)
        {

            DrawFrame();
            DrawMenu();
            DrawMap();
            HandleInput();

        }

    }


    static void HandleInput()
    {
        // Read the user input
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        // Store the previous position
        prevCharacterX = characterX;
        prevCharacterY = characterY;

        // Move the character based on user input
        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.W:
                characterY = Math.Max(0, characterY - 1);
                break;

            case ConsoleKey.DownArrow:
            case ConsoleKey.S:
                characterY = Math.Min(Console.WindowHeight - 6, characterY + 1);
                break;

            case ConsoleKey.LeftArrow:
            case ConsoleKey.A:
                characterX = Math.Max(0, characterX - 1);
                break;

            case ConsoleKey.RightArrow:
            case ConsoleKey.D:
                characterX = Math.Min(Console.WindowWidth - 1, characterX + 1);
                break;

            default:
                // Handle other keys if needed
                break;
        }
    }

    static void DrawMap()
    {
        // Draw only the elements that have changed
        DrawCharAtPosition(prevCharacterX, prevCharacterY, ' ', ConsoleColor.Black);
        DrawCharAtPosition(characterX, characterY, '@', ConsoleColor.White);


        DrawCharAtPosition(5, 5, '*', ConsoleColor.Red);
        DrawCharAtPosition(123, 25, 'T', ConsoleColor.Green); // Draw trees
        DrawCharAtPosition(99, 10, 'T', ConsoleColor.Green);
        DrawCharAtPosition(25, 5, 'c', ConsoleColor.Yellow);
        DrawCharAtPosition(27, 5, 'B', ConsoleColor.Green);
        DrawCharAtPosition(29, 5, 'R', ConsoleColor.Gray);
    }

    static void DrawFrame()
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

    static void DrawMenu()
    {
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

    static void DrawCharAtPosition(int x, int y, char character, ConsoleColor color)
    {
        // Draw character at position (x, y)
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(character);
        Console.ResetColor(); // Reset the color to default
    }
}
