using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestISBN
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void GetAreaTriangele_WidthFourHeightFive_TEN()
        {
            //Arrange
            Triangle triangle = new Triangle(4, 5);
            //Act 
            var result = triangle.GetArea();

            //Assert
            Assert.AreEqual(10, result);
        }

    }
}
