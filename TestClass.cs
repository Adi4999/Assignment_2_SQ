using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;


namespace TriangleTest
{
    public class Class1
    {

        [TestFixture]

        public class TriangleTest
        {
             //Equilateral
 [Test]
 public void AnalyzeTriangle_InputAllSidesEqual_ReturnsEquilateral()
 {
     // Arrange
     int firstSide = 8;
     int secondSide = 8;
     int thirdSide = 8;
     string expectedResult = "A triangle is formed and it is an EQUILATERAL";

     // Act
     string actualResult = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

     // Assert
     Assert.AreEqual(expectedResult, actualResult);
 }

            //Zero Cases

            [Test]
            public void AnalyzeTriangle_AllSidesZero_ReturnsInvalid()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 0;
                string expectedResult = "INVALID triangle - a zero was entered";
                //Act
                string actualResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }


            [Test]
            public void AnalyzeTriangle_TwoSidesZero_ReturnsInvalid()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 8;
                string expectedResult = "INVALID triangle - a zero was entered";
                //Act
                string actualResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void AnalyzeTriangle_OneSideZero_ReturnsInvalid()
            {
                //Arrange
                int firstSide = 0;
                int secondSide = 5;
                int thirdSide = 7;
                string expectedResult = "INVALID triangle - a zero was entered";
                //Act
                string actualResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            //Invalid Cases (non-zero)

            [Test]
            public void AnalyzeTriangle_NegativeSideLength_ReturnsInvalid()
            {
                //Arrange
                int firstSide = -1;
                int secondSide = 5;
                int thirdSide = 6;
                string expectedResult = "A triangle is not formed based on the input values";
                //Act
                string actualResult =Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void AnalyzeTriangle_AllSidesNegative_ReturnsInvalid()
            {
                //Arrange
                int firstSide = -4;
                int secondSide = -5;
                int thirdSide = -6;
                string expectedResult = "A triangle is not formed based on the input values";
                //Act
                string actualResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void AnalyzeTriangle_SidesViolateTriangleInequality_ReturnsInvalid()
            {
                //Arrange
                int firstSide = 2;
                int secondSide = 3;
                int thirdSide = 6;
                string expectedResult = "A triangle is not formed based on the input values";
                //Act
                string actualResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }




        }
    }
}
