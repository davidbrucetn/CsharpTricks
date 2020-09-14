using System;
using System.Text;

namespace CsharpTricks.UserInterfaceManagers
{
	class StringManager : IUserInterfaceManager
	{
		private readonly IUserInterfaceManager _parentUI;

		public StringManager(IUserInterfaceManager parentUI)
        {
			_parentUI = parentUI;

        }

		public IUserInterfaceManager Execute()
        {
			Console.WriteLine("String Menu");
			Console.WriteLine(" 1) Reverse a string");
			Console.WriteLine(" 0) Go Back");

			Console.Write("> ");
			string choice = Console.ReadLine();
			Console.Clear();

            switch (choice)
            {
                case "1":
                    ReverseAString();
                    return this;
                case "0":
                    Console.Clear();
                    return _parentUI;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }

        }

        private void ReverseAString()
        {
            var aString = "Hello, World!";
            Console.WriteLine($"{aString} Let's play with strings!");
            string tmpString = "";
            for (int i = aString.Length - 1; i >= 0; i--)
            {
                tmpString += aString[i];
            }

            Console.WriteLine($"Reversed: {tmpString}");
            Console.WriteLine("");
            Console.WriteLine("string aString = 'Hello, World!'");
            Console.WriteLine($"string newStr ='';");
            Console.WriteLine($"for (int i = aString.Length-1; i >= 0; i--) ");
            Console.WriteLine("{ newStr += aString[i] }");


            Console.WriteLine("Press ENTER to return to the menu..");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

