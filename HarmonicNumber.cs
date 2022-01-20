using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay5
{
    internal class HarmonicNumber
    {
        public static void HarmonicNumberProgram()
        {
            Console.Write("Enter a number for harmonic value = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double harmonicValue = 0;
            if (n != 0)
            {
                for (int i = 1; i <= n; i++) harmonicValue += (double)1 / i;
                Console.WriteLine("Result: Harmonic of " + n + " is = " + harmonicValue);
            }
            else Console.WriteLine("Error: value must be greater than 0");
        }
    }
}