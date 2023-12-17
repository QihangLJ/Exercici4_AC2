using MyProgram;
using Newtonsoft.Json.Linq;

namespace MyProgramTest
{
    [TestClass]
    public class UnitTesting
    {

        //SquareArea Tests

        [TestMethod]
        public void SquareArea_PositiveValue_PositiveResult()
        {
            //Arrange
            decimal value = 5;

            //Act
            decimal result = ProgramCode.SquareArea(value);

            //Assert
            decimal expectedResult = 25;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SquareArea_DecimalValue_ResultWithDecimal()
        {
            //Arrange
            decimal value = 5.5m;

            //Act
            decimal result = ProgramCode.SquareArea(value);

            //Assert
            decimal expectedResult = 30.25m;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void SquareArea_ValueEqualZero_ZeroResult()
        {
            //Arrange
            decimal value = 0;

            //Act
            decimal result = ProgramCode.SquareArea(value);

            //Assert
            decimal expectedResult = 0;
            Assert.AreEqual(expectedResult, result);
        }

        //RectangleArea Tests

        [TestMethod]
        public void RectangleArea_PositiveValue_PositiveResult()
        {
            //Arrange
            decimal firstValue = 2, secondValue = 5;

            //Act
            decimal result = ProgramCode.RectangleArea(firstValue, secondValue);

            //Assert
            decimal expectedResult = 10;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void RectangleArea_DecimalValue_ResultWithDecimal()
        {
            //Arrange
            decimal firstValue = 4.6m, secondValue = 5.2m;

            //Act
            decimal result = ProgramCode.RectangleArea(firstValue, secondValue);

            //Assert
            decimal expectedResult = 23.92m;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void RectangleArea_ValueEqualZero_ZeroResult()
        {
            //Arrange
            decimal firstValue = 0, secondValue = 0;

            //Act
            decimal result = ProgramCode.RectangleArea(firstValue, secondValue);

            //Assert
            decimal expectedResult = 0;
            Assert.AreEqual(expectedResult, result);
        }

        //CircleArea Tests

        [TestMethod]
        public void CircleArea_PositiveValue_PositiveResult()
        {
            //Arrange
            decimal value = 5;

            //Act
            decimal result = ProgramCode.CircleArea(value);

            //Assert
            decimal expectedResult = (decimal)Math.PI * value * value;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CircleArea_DecimalValue_ResultWithDecimal()
        {
            //Arrange
            decimal value = 1.2m;

            //Act
            decimal result = ProgramCode.CircleArea(value);

            //Assert
            decimal expectedResult = (decimal)Math.PI * value * value;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CircleArea_ValueEqualZero_ZeroResult()
        {
            //Arrange
            decimal value = 0;

            //Act
            decimal result = ProgramCode.CircleArea(value);

            //Assert
            decimal expectedResult = 0;
            Assert.AreEqual(expectedResult, result);
        }

        //PentagonArea Tests

        [TestMethod]
        public void PentagonArea_PositiveValue_PositiveResult()
        {
            //Arrange
            decimal firstValue = 15, secondValue = 4;

            //Act
            decimal result = ProgramCode.PentagonArea(firstValue, secondValue);

            //Assert
            decimal expectedResult = (firstValue * secondValue) / 2;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PentagonArea_DecimalValue_ResultWithDecimal()
        {
            //Arrange
            decimal firstValue = 1.2m, secondValue = 5.4m;

            //Act
            decimal result = ProgramCode.PentagonArea(firstValue, secondValue);

            //Assert
            decimal expectedResult = (firstValue * secondValue) / 2;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PentagonArea_ValueEqualZero_ZeroResult()
        {
            //Arrange
            decimal firstValue = 0, secondValue = 0;

            //Act
            decimal result = ProgramCode.PentagonArea(firstValue, secondValue);

            //Assert
            decimal expectedResult = 0;
            Assert.AreEqual(expectedResult, result);
        }
    }
}