using System;

public class GameLoop
{
    
    // Initial position of the character
    static (int x, int y) characterPos = (10, 10);

    static InputHandler ih = new InputHandler(characterPos);
    static MenuHandler mh = new MenuHandler();
    
    public static void SomeMethod()
    {
        
        // Hide the cursor
        Console.CursorVisible = false;
        Console.Clear();

        Console.CancelKeyPress += new ConsoleCancelEventHandler(CtrlCHandler);


        while (true)
        {

            mh.DrawMenu();
            mh.DrawMap(characterPos);
            ih.HandleInput();
            characterPos = ih.UpdateCharacterPos();

        }

    }

     // Event handler for Ctrl+C
    protected static void CtrlCHandler(object sender, ConsoleCancelEventArgs args)
    {
        
        Console.Clear();
        // Unhide the cursor
        Console.CursorVisible = true;

        // Perform cleanup actions, display a goodbye message, etc.
        Console.WriteLine("Goodbye! Thanks for playing Werecat fang.");

        // Ensure the program exits
        Environment.Exit(0);
    }

}
