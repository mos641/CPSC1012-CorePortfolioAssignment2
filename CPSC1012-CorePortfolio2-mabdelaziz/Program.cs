// File:    Program.cs
// Purpose: Calculate the depreciation of vehicles with user input

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_CorePortfolio2_mabdelaziz
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            char menuSelection;
            bool quitLoop = false;
            double depreciationAmount = 0;
            int depreciationYears = 0;

            // display program purpose
            Console.WriteLine("This program computes depreciation tables using various methods of depreciation.");

            // start loop
            while (quitLoop == false)
            {
                // display menu
                Menu.DisplayMenu();

                // ask for and capture input
                menuSelection = Menu.GetMenuChoice();

                // enact the corresponding decision
                switch (menuSelection)
                {
                    case 'A':
                        Console.WriteLine("How much money is to be depreciated?");
                        depreciationAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Over how many years?");
                        depreciationYears = int.Parse(Console.ReadLine());
                        break;
                    case 'B':
                        DepreciationTables.StraightLineDepreciation(depreciationAmount, depreciationYears);
                        break;
                    case 'C':
                        DepreciationTables.SumOfYearsDigitsDepreciation(depreciationAmount, depreciationYears);
                        break;
                    case 'D':
                        DepreciationTables.DoubleDecliningBalanceDepreciation(depreciationAmount, depreciationYears);
                        break;
                    default:
                        quitLoop = true;
                        break;
                }

            }

            // good bye message
            Console.WriteLine("Good-bye.");

            // keep the console window open
            Console.ReadLine();
        }
    }
}
