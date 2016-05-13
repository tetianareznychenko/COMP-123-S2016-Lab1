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
 * Version: 0.2 - Added GetUserName method
 * 
 */ 

namespace COMP_123_S2016_Lesson1B
{
    class Program
    {
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
