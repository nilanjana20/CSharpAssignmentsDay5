using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay5
{
    internal class PowerOfTwo
    {
        public static void PowerOfTwoSolution()
        {
            Console.Write("Insert a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (0 <= n && n < 31)
            {
                for (int i = 1; i <= n; i++) Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
            else Console.WriteLine("Error: Out of range");
        }
    }
}


