// File:    Menu.cs
// Purpose: Display a menu and capture user input in relation to the menu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_CorePortfolio2_mabdelaziz
{
    class Menu
    {
        public static char GetMenuChoice()
        {
            // declare variables
            char charValue;
            bool inputIsValid = false;
            string inputQuestion = "Option? ";
            string errorMessage = "*** Invalid menu choice {0}.";

            // loop to determine whether char is valid menu choice
            do
            {
                // ask for and capture an char value
                Console.Write(inputQuestion);

                // loop to determine whether the input is a character
                while (!char.TryParse(Console.ReadLine().Trim().ToUpper(), out charValue))
                {
                    Console.WriteLine(errorMessage, charValue);
                    Console.Write(inputQuestion);
                }
                if (!charValue.Equals('A') && !charValue.Equals('B') && !charValue.Equals('C') && !charValue.Equals('D') && !charValue.Equals('Q'))
                {
                    Console.WriteLine(errorMessage, charValue);
                }
                else
                {
                    inputIsValid = true;
                }
            } while (inputIsValid == false);

            return charValue;
        }

        public static void DisplayMenu()
        {
            // declare variables
            // set menu choices here to easily change if need be
            string menuHeader = "Please enter:";
            string menuOptionOne = "A - to enter a new Amount and/or Number of Years,";
            string menuOptionTwo = "B - to use the straight-line method,";
            string menuOptionThree = "C - to use the sum-of-years-digits method,";
            string menuOptionFour = "D - to use the double-declining balance method,";
            string menuOptionFive = "Q - to quit.";

            // place an empty line before
            Console.WriteLine("");
            // display menu
            Console.WriteLine("{0}", menuHeader);
            Console.WriteLine("         {0}", menuOptionOne);
            Console.WriteLine("         {0}", menuOptionTwo);
            Console.WriteLine("         {0}", menuOptionThree);
            Console.WriteLine("         {0}", menuOptionFour);
            Console.WriteLine("         {0}", menuOptionFive);
            // place an empty line afterwards
            Console.WriteLine("");
        }
    }
}
