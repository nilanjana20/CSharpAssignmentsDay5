using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay5
{
    internal class LeapYear
    {
            public static void LeapYearSolution()
            {
          
            Console.WriteLine("Enter Year : ");  
            int Year = Convert.ToInt32(Console.ReadLine());  
            if (Convert.ToString(Year).Length == 4)
            {
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);  
            else Console.WriteLine("{0} is not a Leap Year.", Year); 
            }  
            else Console.WriteLine("Error: Please enter a valid year");
        }
    }
}