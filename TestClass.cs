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



            //Isoceles
            [Test]
            public void AnalyzeTriangle_InputLargeIsosceles_ReturnsIsosceles()
            {
                //Arrange
                int firstSide = 15;
                int secondSide = 15;
                int thirdSide = 20;
                string expectedResult = "A triangle is formed and it is an ISOSCELES";
                //Act
                string actualResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }


            [Test]
            public void AnalyzeTriangle_InputMediumIsosceles_ReturnsIsosceles()
            {
                //Arrange
                int firstSide = 10;
                int secondSide = 10;
                int thirdSide = 14;
                string expectedResult = "A triangle is formed and it is an ISOSCELES";
                //Act
                string actualResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }

            [Test]
            public void AnalyzeTriangle_InputSmallIsosceles_ReturnsIsosceles()
            {
                //Arrange
                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 8;
                string expectedResult = "A triangle is formed and it is an ISOSCELES";
                //Act
                string actualResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }



   //Scalene
   [Test]
   public void AnalyzeTriangle_Input9and10and11_ReturnsScalene()
   {
       //Arrange
       int firstSide = 9;
       int secondSide = 10;
       int thirdSide = 11;
       string expectedResult = "A triangle is formed and it is a SCALENE";
       //Act
       string actualResult = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
       //Assert
       Assert.AreEqual(expectedResult, actualResult);
   }


   [Test]
   public void AnalyzeTriangle_Input6and8and13_ReturnsScalene()
   {
       //Arrange
       int firstSide = 6;
       int secondSide = 8;
       int thirdSide = 13;
       string expectedResult = "A triangle is formed and it is a SCALENE";
       //Act
       string actualResult = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
       //Assert
       Assert.AreEqual(expectedResult, actualResult);
   }
   [Test]
   public void AnalyzeTriangle_Input12and14and15_ReturnsScalene()
   {
       //Arrange
       int firstSide = 12;
       int secondSide = 14;
       int thirdSide = 15;
       string expectedResult = "A triangle is formed and it is a SCALENE";
       //Act
       string actualResult = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
       //Assert
       Assert.AreEqual(expectedResult, actualResult);
   }

   [Test]
   public void AnalyzeTriangle_Input3and4and5_ReturnsScalene()
   {
       //Arrange
       int firstSide = 3;
       int secondSide = 4;
       int thirdSide = 5;
       string expectedResult = "A triangle is formed and it is a SCALENE";
       //Act
       string actualResult = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
       //Assert
       Assert.AreEqual(expectedResult, actualResult);
   }



   [Test]
   public void AnalyzeTriangle_Input5and7and10_ReturnsScalene()
   {
       //Arrange
       int firstSide = 5;
       int secondSide = 7;
       int thirdSide = 10;
       string expectedResult = "A triangle is formed and it is a SCALENE";
       //Act
       string actualResult = TriangleSolver.Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
       //Assert
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
