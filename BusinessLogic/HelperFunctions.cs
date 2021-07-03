using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewValleyConstructionCalculator.BusinessLogic
{
    public static class HelperFunctions
    {
        public static string CenterString(string stringToCenter, int totalLength)
        {
            try
            {
                int stringLength = stringToCenter.Count();
                for (int i = stringLength; i < totalLength - 2; i += 2)
                {
                    stringToCenter += " ";
                    stringToCenter = " " + stringToCenter;
                }
                return stringToCenter;
            }
            catch (NullReferenceException Exception)
            {
                Console.WriteLine("!!! Null Reference passed to `HelperFunctions.CenterString()`");
                Console.WriteLine(Exception.Message);
                return "";
            }
        }
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Caotic Camper's Stardew Valley Construction Calculator!");
        }
        public static string GetFullCSVFilepath()
        {
                string Directory = System.IO.Directory.GetCurrentDirectory() + "\\Building List.csv";
                return Directory;
        }
        /// <summary>
        /// Capitalizes the first letter of a string.
        /// </summary>
        /// <param name="StringToCapitalize"></param>
        /// <returns>The string with the first character capital and all others lowercase. Returns empty string if null is passed.</returns>
        public static string CapitalizeWord(string StringToCapitalize)
        {
            try
            {
                return StringToCapitalize.First().ToString().ToUpper() + StringToCapitalize.Substring(1);
            }
            catch (NullReferenceException Exception)
            {
                Console.Write("!!! Null reference passed to `HelperFunctions.CapitalizString()`" +
                    "\n " + Exception.Message);
                return "";
            }
        }
    }
}
