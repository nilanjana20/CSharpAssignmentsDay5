using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay5
{
    internal class QuotientRemainder
    {
        public static void QuotientRemainderProgram()
        {
            Console.Write("Enter 1st integer = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd integer = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Quotient: {a} / {b} = {a/b}");
            Console.WriteLine($"Remainder: {a} % {b} = {a%b}");
        }
    }
}