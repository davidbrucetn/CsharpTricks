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
            Console.WriteLine(" 3) Is it a palindrome? (Same word backwards as left to right)");
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
                case "3":
                    IsItAPalidrome();
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
            Console.WriteLine("Reversing a string with a for loop as an array");
            string newText = GetText();
            
            if (newText != aString && newText != "") aString = newText;
            string tmpString = "";
            for (int i = aString.Length - 1; i >= 0; i--)
            {
                tmpString += aString[i];
            }

            Console.WriteLine($"Reversed: {tmpString}");
            Console.WriteLine("");
            Console.WriteLine($"string aString = {aString}");
            Console.WriteLine($"string newStr ='';");
            Console.WriteLine($"for (int i = aString.Length-1; i >= 0; i--) ");
            Console.WriteLine("{ newStr += aString[i] }");


            Console.WriteLine("Press ENTER to return to the menu..");
            Console.ReadLine();
            Console.Clear();
        }

        private void IsItAPalidrome()
        {
            var aString = "kayak";
            Console.WriteLine("Testing if a word is a palindrome - same letters coming or going..");
            string newText = GetWord();

            if (newText != aString && newText != "") aString = newText;
            string tmpString = "";
            for (int i = aString.Length - 1; i >= 0; i--)
            {
                tmpString += aString[i];
            }

            if (tmpString.ToLower() == aString.ToLower())
            {
                Console.WriteLine($"It is a palindrome! : {tmpString} = {aString}");
            } 
            else
            {
                Console.WriteLine($"It is not a palindrome! : {tmpString} <> {aString}");
            }
            
            Console.WriteLine("");
            Console.WriteLine($"string aString = {aString}");
            Console.WriteLine($"string newStr ='';");
            Console.WriteLine($"for (int i = aString.Length-1; i >= 0; i--) ");
            Console.WriteLine("{ newStr += aString[i] }");
            Console.WriteLine(" if newStr == aString Console.WriteLine(It is a palindrome!");


            Console.WriteLine("Press ENTER to return to the menu..");
            Console.ReadLine();
            Console.Clear();
        }
        private void ReverseAStringMethod()
        {
            var aString = "Hello, World!";
            Console.WriteLine($"{aString} Let's play with strings!");
            Console.WriteLine("Reversing a string with a C# LINQ String Method - String.Reverse();");
            string newText = GetText();
            if (newText != aString && newText != "") aString = newText;
            Console.WriteLine($"string reversedString = new string({aString}.ToCharArray().Reverse().ToArray())");
            string reversedString = new string(aString.ToCharArray().Reverse().ToArray());
            Console.WriteLine(reversedString);
            Console.WriteLine("");

            Console.WriteLine("Press ENTER to return to the menu..");
            Console.ReadLine();
            Console.Clear();
        }
        static string GetText()
        {
            string tmpString = "";
            Console.WriteLine("Let's play with strings!");
            do
            {
                Console.WriteLine("Enter some text - a word, a sentence, but nothing super long..");
                Console.WriteLine("Or hit ENTER to just use Hello, World! ");
                tmpString = Console.ReadLine();
            } while (tmpString.Length > 50);
            return tmpString;
        }

        static string GetWord()
        {
            string tmpString = "";
            Console.WriteLine("Let's play with strings!");
            do
            {
                if (tmpString.Contains(" ")) Console.WriteLine("No spaces - just one word");
                Console.WriteLine("Enter a word to test - only one word");
                Console.WriteLine("Or hit ENTER to just use kayak! ");
                tmpString = Console.ReadLine();
            } while (tmpString.Length > 50 || tmpString.Contains(" "));
            return tmpString;
        }

    }
}

