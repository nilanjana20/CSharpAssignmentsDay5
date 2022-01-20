using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAssignmentsDay5
{
    internal class VowelConsonant
    {
        public static void VowelConsonantProgram()
        {
            Console.Write("insert an alphabet: ");
            string? val = Console.ReadLine();
            if (val != null)
            {
                switch (val.ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.WriteLine($"{val} is a Vowel");
                        break;
                    default:
                        Console.WriteLine($"{val} is consonant");
                        break;
                }
            }
        }
    }
}