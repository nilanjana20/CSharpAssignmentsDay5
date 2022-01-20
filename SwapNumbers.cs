using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay5
{
    internal class SwapNumbers
    {
          public static void SwapNumberProgram()
          {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
          }
    }
}