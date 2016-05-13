using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static COMP_123_S2016_Lesson1B.Program;

namespace Lesson1TestProject
{
    [TestClass]
    public class Lesson1TestProject
    {
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
