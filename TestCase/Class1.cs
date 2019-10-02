using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle;
using NUnit.Framework;

namespace TestCase
{   
    //creating test cases//
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Analyze_test_input_sideA_8_sideB_8_sideC_8_returns_Formed_Triangle_is_Equilateral_Triangle()
        {

            //Arrange
            int sideA = 8;
            int sideB = 8;
            int sideC = 8;
            string expectedResult = "Triangle formed\n Formed Triangle is Equilateral Triangle\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_sideA_17_sideB_17_sideC_9_returns_Triangle_formed_is_Isosceles_Triangle()
        {

            //Arrange
            int sideA = 17;
            int sideB = 17;
            int sideC = 9;
            string expectedResult = "Triangle formed\nFormed Triangle is Isosceles\n";            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_sideA_8_sideB_4_sideC_6_returns_Triangle_formed_is_Scalene_Triangle()
        {

            //Arrange
            int sideA = 8;
            int sideB = 4;
            int sideC = 6;
            string expectedResult = "Triangle formed\n Formed Triangle is Scalene\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_sideA_1_sideB_4_sideC_9_returns_Input_Sides_Do_not_Form_any_Triangle()
        {

            //Arrange
            int sideA = 1;
            int sideB = 4;
            int sideC = 9;
            string expectedResult = "No triangle can be formed\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_sideA_5_sideB_40_sideC_900_returns_Input_Sides_Do_not_Form_any_Triangle()
        {

            //Arrange
            int sideA = 5;
            int sideB = 40;
            int sideC = 900;
            string expectedResult = "No triangle can be formed\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void Analyze_test_input_sideA_50_sideB_50_sideC_50_returns_Formed_Triangle_is_Equilateral_Triangle()
        {

            //Arrange
            int sideA = 50;
            int sideB = 50;
            int sideC = 50;
            string expectedResult = "Triangle formed\n Formed Triangle is Equilateral Triangle\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_sideA_88_sideB_88_sideC_100_returns_Triangle_formed_is_Isosceles_Triangle()
        {

            //Arrange
            int sideA = 88;
            int sideB = 88;
            int sideC = 100;
            string expectedResult = "Triangle formed\nFormed Triangle is Isosceles\n";            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_sideA_70_sideB_20_sideC_60_formed_Triangle_is_Scalene_Triangle()
        {

            //Arrange
            int sideA = 70;
            int sideB = 20;
            int sideC = 60;
            string expectedResult = "Triangle formed\n Formed Triangle is Scalene\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_sideA_180_sideB_5_sideC_40_returns_Input_Sides_Do_not_Form_any_Triangle()
        {

            //Arrange
            int sideA = 180;
            int sideB = 5;
            int sideC = 40;
            string expectedResult = "No triangle can be formed\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_test_input_sideA_43_sideB_43_sideC_43_returns_Formed_Triangle_is_Equilateral_Triangle()
        {

            //Arrange
            int sideA = 43;
            int sideB = 43;
            int sideC = 43;
            string expectedResult = "Triangle formed\n Formed Triangle is Equilateral Triangle\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_test_input_sideA_100_sideB_100_sideC_20_returns_Triangle_formed_is_Isosceles_Triangle()
        {

            //Arrange
            int sideA = 100;
            int sideB = 100;
            int sideC = 20;
            string expectedResult = "Triangle formed\nFormed Triangle is Isosceles\n";            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_sideA_580_sideB_220_sideC_600_returns_Triangle_formed_is_Scalene_Triangle()
        {

            //Arrange
            int sideA = 580;
            int sideB = 220;
            int sideC = 600;
            string expectedResult = "Triangle formed\n Formed Triangle is Scalene\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_test_input_sideA_285_sideB_5_sideC_1_returns_Input_Sides_Do_not_Form_any_Triangle()
        {

            //Arrange
            int sideA = 285;
            int sideB = 5;
            int sideC = 1;
            string expectedResult = "No triangle can be formed\n";
            //Act
            string actualResult = TriangleSolver.Analyze(sideA, sideB, sideC);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
