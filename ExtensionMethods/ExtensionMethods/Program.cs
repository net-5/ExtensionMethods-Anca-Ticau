using System;
using System.Runtime.InteropServices;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capitalize word
            // Write an extension method that will capitalize a word.
            // Input: mom
            // Output: Mom

            string parent = "mom";

            string result = parent.CapitalizeFirstLetter();

            Console.WriteLine(result);


            //Pluralize
            //    Write an extension method that appends an ‘s’ to a string.
            //    Ex:
            //input: method
            //output:methods

            string givenString = "method";

            string result1 = givenString.Pluralize();

            Console.WriteLine(result1);

            //Capital letter
            //Write an extension method to check if a string starts with a capital letter or not.

            givenString = "This is a string";
            givenString.CheckIfFirstLetterIsCapital();

            //Character count
            //Write an extension method what will count the number of characters in a string.

            string givenString1 = "abc";

            int charCount = givenString1.CountChar();

            Console.WriteLine($"Number of characters in '{givenString1}' is '{charCount}'.");


            // Capitalize and pluralize
            // Write a program that will capitalize a string, and pluralize the same string.
            // You cand write a new extension method or use what you already have.

            string givenString2 = "house";

            Console.WriteLine(givenString2.CapitalizeAndPluralize());

            //Apply VAT
            //Write an extension method that will apply a VAT of 24 % on an input. This input can be a decimal value, or an integer on

            decimal givenValue = 100M;

            Console.WriteLine(givenValue.ApplyVat());
        }
    }
}

