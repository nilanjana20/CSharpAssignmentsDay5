using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay5
{
    internal class EvenOdd
    {
        public static void EvenOddProgram()
        {
            Console.Write("Enter number= ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num % 2 == 0 ? $"{num} is Even" : $"{num} is Odd");
        }
    }
}