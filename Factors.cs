using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay5
{
    internal class Factors
    {
        public static void FactorsProgram()
        {
            Console.Write("Please enter the numberto find prime factors = ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            string factString = "";
            for (int i = 2; input > 1; i++)
                if (input % i == 0)
                {
                    while (input % i == 0) input /= i;
                    factString += $"{i} ";
                }
            Console.WriteLine(factString.Trim());
        }
    }
}