using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static COMP_123_S2016_Lesson1B.Program;

namespace Lesson1TestProject
{   
    /**
     * This class is used to test Lesson 1 Project
     * Used for development only
     * 
     * @class Lesson1UnitTest
     */ 
    [TestClass]
    public class Lesson1TestProject
    {
        /**
         * Unit Test for OutputStringToConsole Method of the Program class
         * 
         * @method OutputStringToConsoleMethod
         */

        [TestMethod]
        public void OutputStringToConsoleTestMethod()
        {
            //Arrange
            string outputString = "Enter the User Name: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult = "Enter the User Name: ";

            //Act
            actualResult = OutputStringToConsole(outputString, hasNewLine);

            //Assert
            Assert.AreEqual(expectedResult, actualResult); 
        }
    }
}
