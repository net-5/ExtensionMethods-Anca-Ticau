using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static string CapitalizeFirstLetter(this string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString))
            {
                return inputString;
            }

            string firstLetter = (char.IsUpper(inputString[0]) ? inputString[0].ToString() : char.ToUpper(inputString[0]).ToString());

            return firstLetter + inputString.Substring(1);
        }

        public static string Pluralize(this string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString))
            {
                return inputString;
            }

            return inputString + "s";
        }

        public static bool CheckIfFirstLetterIsCapital(this string inputString)
        {
            if (inputString[0] == char.ToUpper(inputString[0]))
            {
                return true;
            }
           
                return false;
        }

        public static int CountChar(this string inputString)
        {
            return inputString.Count();
        }

        public static string CapitalizeAndPluralize(this string inputString)
        {
            return inputString.CapitalizeFirstLetter().Pluralize();
        }

        public static decimal ApplyVat(this decimal inputDecimal)
        {
            if (inputDecimal <= 0)
            {
                return inputDecimal;
            }
            return inputDecimal * 1.24M;
        }
    }
}

