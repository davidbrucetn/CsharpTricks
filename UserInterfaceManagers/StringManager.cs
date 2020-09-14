using System;
using System.Linq;
using System.Resources;
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
			Console.WriteLine(" 1) Reverse a string with a for loop");
            Console.WriteLine(" 2) Reverse a string with a string method");
			Console.WriteLine(" 0) Go Back");

			Console.Write("> ");
			string choice = Console.ReadLine();
			Console.Clear();

            switch (choice)
            {
                case "1":
                    ReverseAStringFor();
                    return this;
                case "2":
                    ReverseAStringMethod();
                    return this;
                case "0":
                    Console.Clear();
                    return _parentUI;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }

        }

        private void ReverseAStringFor()
        {
            var aString = "Hello, World!";
            Console.WriteLine($"{aString} Let's play with strings!");
            Console.WriteLine("Reversing a string with a for loop as an array");
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

        private void ReverseAStringMethod()
        {
            var aString = "Hello, World!";
            Console.WriteLine($"{aString} Let's play with strings!");
            Console.WriteLine("Reversing a string with a C# LINQ String Method - String.Reverse();");
            Console.WriteLine("string reversedString = new string(aString.ToCharArray().Reverse().ToArray())");
            string reversedString = new string(aString.ToCharArray().Reverse().ToArray());
            Console.WriteLine(reversedString);
            Console.WriteLine("");
            
            Console.WriteLine("Press ENTER to return to the menu..");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

