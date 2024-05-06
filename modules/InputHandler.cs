using System;

public class InputHandler
{

    // Initial position of the character
    int characterX;
    int characterY;
    
    public String lastAction = "no";

    public InputHandler((int x, int y) characterPos)
    {
        this.characterX = characterPos.x;
        this.characterY = characterPos.y;
    }

    internal void ProvideCharacterPos(int characterX, int characterY)
    {
        this.characterX = characterX;
        this.characterY = characterY;
    }

    public void HandleInput()
    {
        // Read the user input
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        // Move the character based on user input
        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.W:
                characterY = Math.Max(0, characterY - 1);
                lastAction = "up";
                break;

            case ConsoleKey.DownArrow:
            case ConsoleKey.S:
                characterY = Math.Min(Console.WindowHeight - 6, characterY + 1);
                lastAction = "dn";
                break;

            case ConsoleKey.LeftArrow:
            case ConsoleKey.A:
                characterX = Math.Max(0, characterX - 1);
                lastAction = "lf";
                break;

            case ConsoleKey.RightArrow:
            case ConsoleKey.D:
                characterX = Math.Min(Console.WindowWidth - 1, characterX + 1);
                lastAction = "rg";
                break;

            default:
                // Handle other keys if needed
                break;
        }
    }

    internal (int x, int y) UpdateCharacterPos()
    {
        return (characterX, characterY);
    }
}

