using System;


namespace CsharpTricks.UserInterfaceManagers
{
    public class MainMenuManager : IUserInterfaceManager
    {
        public IUserInterfaceManager Execute()
        {

            Console.WriteLine("Main Menu");

            Console.WriteLine(" 1) String Manager");
            Console.WriteLine(" 0) Exit");

            Console.Write("> ");
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1": return new StringManager(this);
                case "0":
                    Console.ResetColor();
                    Console.Clear();
                    Console.WriteLine("Good bye");
                    return null;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }
    }
}