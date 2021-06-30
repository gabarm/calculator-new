using Xunit;
using System;

namespace calculator_new.Test
{
    public class UnitTest1
    {
        [Fact]
        public void AddNumbers()
        {
            //Arrange
            double number1 = 5.5;
            double number2 = 4.5;
            double sumExpected = 10.0;
            //Act

            double result = Calculator.Addition(number1, number2);

            //Assert
            Assert.Equal(sumExpected, result);
        }
        [Fact]
        public void SubtractNumbers()
        {
            //Arrange
            double number1 = 5.5;
            double number2 = 4.5;
            double sumExpected = 1.0;
            //Act

            double result = Calculator.Subtraction(number1, number2);

            //Assert
            Assert.Equal(sumExpected, result);
        }
        
        [Fact]
        public void MultiPlyNumbers()
        {
            //Arrange
            double number1 = 5;
            double number2 = 4;
            double sumExpected = 20;
            //Act

            double result = Calculator.Multiply(number1, number2);

            //Assert
            Assert.Equal(sumExpected, result);

        }        
        [Fact]
        public void DivideNumbers()
        {
            //Arrange
            double number1 = 5;
            double number2 = 4;
            double sumExpected = 1.25;
            //Act

            double result = Calculator.Divide(number1, number2);

            //Assert
            Assert.Equal(sumExpected, result);

        }

        [Fact]
        public void AddArray()
        {
            //Arrange
            double[] numbers = new double[] { 1, -2, 3, 4, 5 };
            double sumExpected = 11;

            //Act
            double result = Calculator.Addition(numbers);

            //Assert
            Assert.Equal(result, sumExpected);
        }
        [Fact]
        public void SubtractArray()
        {
            //Arrange
            double[] numbers = new double[] { 15, 2, -1, -4, 5 };
            double sumExpected = -17;

            //Act
            double result = Calculator.Subtraction(numbers);

            //Assert
            Assert.Equal(result, sumExpected);
        }



    }
}
