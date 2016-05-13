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
 * Version: 0.3 - Updated comments for driver class Prodram
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

    class Program
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

            Console.Write("Enter User Name: ");
            UserName = Console.ReadLine();

            Console.WriteLine("=====================");
            Console.WriteLine("You Entered: {0}", UserName);

            return UserName;
        }
    }
}
