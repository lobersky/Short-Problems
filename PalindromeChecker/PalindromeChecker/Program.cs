﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if your string is a palindrome:");
            string userInputString = Console.ReadLine();

            string checkString = ReverseString(userInputString);

            if (userInputString == checkString)
            {
                Console.WriteLine("The string is a palindrome");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome");
            }

            Console.ReadLine();
        }

        // Helper method - String Reverser
        public static string ReverseString(string s)
        {
            char[] reverseArray = s.ToCharArray();
            Array.Reverse(reverseArray);
            return new string(reverseArray);
        }
    }
}
