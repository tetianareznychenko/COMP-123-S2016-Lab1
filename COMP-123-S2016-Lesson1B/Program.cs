using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Tetiana Reznychenko
 * Date: May 13, 2016
 * ID: 300870231
 * 
 * Description: This program demonstrate GitHub and version control best practice. We also explore Unit Testing
 * 
 * Version: 0.6 - Refactored OutputStringToConsole
 * 
 */

namespace COMP_123_S2016_Lesson1B
{
    /**
     * This is a driver class for our program 
     * 
     * @class Program 
     * @constructor Main 
     */ 

    public class Program
    {
        /**
         * Main Method for class Program 
         * 
         * @param {string[]} args
         * @constructor Main 
         */
        static void Main(string[] args)
        {
            GetUserName();
        }

        /**
         * This method reads the User Name from the Console
         * 
         * @method GetUserName
         * @return {string} UserName
         */ 

        public static string GetUserName()
        {
            //Initial Variables
            string UserName = "";

            OutputStringToConsole("Enter the User Name: ", false);
            UserName = Console.ReadLine();

            Console.WriteLine("\n=====================\n");
            Console.WriteLine("You Entered: {0}", UserName + "\n");

            return UserName;
        }

        /**
         * This method writes a string to the console. Paramerers allow the user to choose to add a newLine character
         * 
         * @method OutputStringToConsole
         * @param {string} outputString 
         * @param {bool} has NewLine
         * @return {string} outputString 
         */

        public static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            // refactored using the ternary operator
            string suffixString = hasNewLine ? "\n": "";
            Console.Write(outputString + suffixString);

            return outputString;
        }
    }
}
