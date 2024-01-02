// File:    DepreciationTables.cs
// Purpose: Calculate and display the depreciation tables

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_CorePortfolio2_mabdelaziz
{
    class DepreciationTables
    {
        public static void StraightLineDepreciation(double amount, int years)
        {
            // declare variables
            int loopCounter = 1;
            double depreciation;

            // display table header
            Console.WriteLine("{0,-4}{1,17}", "Year", "Depreciation");
            Console.WriteLine("{0,-4}{1,17}", "----", "----------------");

            // code the loop to fill and display the table
            for (loopCounter = 1; loopCounter <= years; loopCounter++)
            {
                depreciation = amount / years;
                Console.WriteLine("{0,4}{1,17:C2}", loopCounter, depreciation);
            }

            // place an empty line afterwards
            Console.WriteLine("");
        }

        public static void SumOfYearsDigitsDepreciation(double amount, int years)
        {
            // declare variables
            int loopCounter = 1;
            int sumOfYears;
            double depreciation;

            // calculate sum
            sumOfYears = (years * (years + 1)) / 2;

            // display table header
            Console.WriteLine("{0,-4}{1,17}", "Year", "Depreciation");
            Console.WriteLine("{0,-4}{1,17}", "----", "----------------");

            // code the loop to fill and display the table
            for (loopCounter = 1; loopCounter <= years; loopCounter++)
            {
                depreciation = (years - loopCounter + 1) * amount / sumOfYears;
                Console.WriteLine("{0,4}{1,17:C2}", loopCounter, depreciation);
            }

            // place an empty line afterwards
            Console.WriteLine("");
        }

        public static void DoubleDecliningBalanceDepreciation(double amount, int years)
        {
            // declare variables
            int loopCounter = 1;
            double depreciation;
            double revisedAmount = amount;

            // display table header
            Console.WriteLine("{0,-4}{1,17}", "Year", "Depreciation");
            Console.WriteLine("{0,-4}{1,17}", "----", "----------------");

            // code the loop to fill and display the table
            for (loopCounter = 1; loopCounter <= years; loopCounter++)
            {
                depreciation = (2.0 / years) * revisedAmount;
                revisedAmount = revisedAmount - depreciation;
                Console.WriteLine("{0,4}{1,17:C2}", loopCounter, depreciation);
            }

            // place an empty line afterwards
            Console.WriteLine("");
        }
    }
}
