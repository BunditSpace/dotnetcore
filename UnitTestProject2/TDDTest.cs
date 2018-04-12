using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestISBN
{
    [TestClass]
    public class TDDTest
    {
        [TestMethod]
        public void  FindFizzBuzzNumber_InputThree_Fizz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 3;
            //Act 
            string result = fizzBuzz.FindFizzBuzzNumber(number);

            //Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void FindFizzBuzzNumber_InputFive_Buzz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 5;
            //Act 
            string result = fizzBuzz.FindFizzBuzzNumber(number);

            //Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void FindFizzBuzzNumber_InputOne_1()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 1;
            //Act 
            string result = fizzBuzz.FindFizzBuzzNumber(number);

            //Assert
            Assert.AreEqual("1", result);
        }

    }
}
