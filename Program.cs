using CsharpTricks.UserInterfaceManagers;
using System;

namespace CsharpTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main Menu Manager implements the IUserInterface Interface
            IUserInterfaceManager ui = new MainMenuManager();

            // Display a welcome message
            Console.Clear();
            Console.WriteLine();
            string title = "Welcome to CSharp Tricks! Please enter a selection below.";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            
            while (ui != null)
            {
                // Each call to Execute will return the next IUserInterfaceManager we should execute
                // When it returns null, we should exit the program;
                ui = ui.Execute();
            }
        }
        
    }

    
}
