using BasicCalculatorAppLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicCalculatorAppUnitTests
{
    [TestClass]
    public class SimpleCalcTests
    {
        [TestMethod]
        public void SimpleCalc_Add_TwoPositiveNumbers()
        {
            decimal num1 = 1;
            decimal num2 = 2;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Add_TwoNegativeNumbers()
        {
            decimal num1 = -1;
            decimal num2 = -2;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Add_NegativeFirstNumAndPositiveSecondNum()
        {
            decimal num1 = -1;
            decimal num2 = 2;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Add_PositiveFirstNumAndNegativeSecondNum()
        {
            decimal num1 = 1;
            decimal num2 = -2;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Add_ZeroFirstNumAndPositiveSecondNum()
        {
            decimal num1 = 0;
            decimal num2 = 2;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Add_PositiveFirstNumAndZeroSecondNum()
        {
            decimal num1 = 1;
            decimal num2 = 0;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Add_ZeroFirstNumAndNegativeSecondNum()
        {
            decimal num1 = 0;
            decimal num2 = -2;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Add_NegativeFirstNumAndZeroSecondNum()
        {
            decimal num1 = -1;
            decimal num2 = 0;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Add_TwoPositiveDecimalNumbers()
        {
            decimal num1 = 1.1M;
            decimal num2 = 2.2M;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Add_TwoNegativeDecimalNumbers()
        {
            decimal num1 = -1.1M;
            decimal num2 = -2.2M;
            decimal expected = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.additionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SimpleCalc_Subtract_TwoPositiveNumbers()
        {
            decimal num1 = 1;
            decimal num2 = 2;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Subtract_TwoNegativeNumbers()
        {
            decimal num1 = -1;
            decimal num2 = -2;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Subtract_NegativeFirstNumAndPositiveSecondNum()
        {
            decimal num1 = -1;
            decimal num2 = 2;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Subtract_PositiveFirstNumAndNegativeSecondNum()
        {
            decimal num1 = 1;
            decimal num2 = -2;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Subtract_ZeroFirstNumAndPositiveSecondNum()
        {
            decimal num1 = 0;
            decimal num2 = 2;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Subtract_PositiveFirstNumAndZeroSecondNum()
        {
            decimal num1 = 1;
            decimal num2 = 0;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Subtract_ZeroFirstNumAndNegativeSecondNum()
        {
            decimal num1 = 0;
            decimal num2 = -2;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Subtract_NegativeFirstNumAndZeroSecondNum()
        {
            decimal num1 = -1;
            decimal num2 = 0;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Subtract_TwoPositiveDecimalNumbers()
        {
            decimal num1 = 1.1M;
            decimal num2 = 2.2M;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Subtract_TwoNegativeDecimalNumbers()
        {
            decimal num1 = -1.1M;
            decimal num2 = -2.2M;
            decimal expected = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.subtractionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SimpleCalc_Multiply_TwoPositiveNumbers()
        {
            decimal num1 = 1;
            decimal num2 = 2;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Multiply_TwoNegativeNumbers()
        {
            decimal num1 = -1;
            decimal num2 = -2;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Multiply_NegativeFirstNumAndPositiveSecondNum()
        {
            decimal num1 = -1;
            decimal num2 = 2;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Multiply_PositiveFirstNumAndNegativeSecondNum()
        {
            decimal num1 = 1;
            decimal num2 = -2;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Multiply_ZeroFirstNumAndPositiveSecondNum()
        {
            decimal num1 = 0;
            decimal num2 = 2;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Multiply_PositiveFirstNumAndZeroSecondNum()
        {
            decimal num1 = 1;
            decimal num2 = 0;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Multiply_ZeroFirstNumAndNegativeSecondNum()
        {
            decimal num1 = 0;
            decimal num2 = -2;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Multiply_NegativeFirstNumAndZeroSecondNum()
        {
            decimal num1 = -1;
            decimal num2 = 0;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Multiply_TwoPositiveDecimalNumbers()
        {
            decimal num1 = 1.1M;
            decimal num2 = 2.2M;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Multiply_TwoNegativeDecimalNumbers()
        {
            decimal num1 = -1.1M;
            decimal num2 = -2.2M;
            decimal expected = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.multiplicationFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SimpleCalc_Divide_TwoPositiveNumbers()
        {
            decimal num1 = 1;
            decimal num2 = 2;
            decimal expected = num1 / num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Divide_TwoNegativeNumbers()
        {
            decimal num1 = -1;
            decimal num2 = -2;
            decimal expected = num1 / num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Divide_NegativeFirstNumAndPositiveSecondNum()
        {
            decimal num1 = -1;
            decimal num2 = 2;
            decimal expected = num1 / num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Divide_PositiveFirstNumAndNegativeSecondNum()
        {
            decimal num1 = 1;
            decimal num2 = -2;
            decimal expected = num1 / num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Divide_ZeroFirstNumAndPositiveSecondNum()
        {
            decimal num1 = 0;
            decimal num2 = 2;
            decimal expected = num1 / num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Divide_ZeroFirstNumAndPositiveDecimalSecondNum()
        {
            SimpleCalc calc = new SimpleCalc();
            decimal num1 = 0;
            decimal num2 = 1.1M;
            decimal expected = num1 / num2;

            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
           
        }
        [TestMethod]
        public void SimpleCalc_Divide_ZeroFirstNumAndNegativeSecondNum()
        {
            decimal num1 = 0;
            decimal num2 = -2;
            decimal expected = num1 / num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Divide_ZeroFirstNumAndNegativeDecimalSecondNum()
        {
            SimpleCalc calc = new SimpleCalc();
            decimal num1 = 0;
            decimal num2 = -2.2M;
            decimal expected = num1 / num2;

            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Divide_TwoPositiveDecimalNumbers()
        {
            decimal num1 = 1.1M;
            decimal num2 = 2.2M;
            decimal expected = num1 / num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_Divide_TwoNegativeDecimalNumbers()
        {
            decimal num1 = -1.1M;
            decimal num2 = -2.2M;
            decimal expected = num1 / num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = calc.divisionFunc(num1, num2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SimpleCalc_OperatorSwitch_Operator_Add() 
        {
            decimal num1 = 1;
            decimal num2 = 2;
            string op = "Add";
            decimal expectedResult = num1 + num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = System.Convert.ToDecimal(calc.OperatorSwitch(num1, num2, op));
            Assert.AreEqual(expectedResult,result);
        }
        [TestMethod]
        public void SimpleCalc_OperatorSwitch_Operator_Subtract()
        {
            decimal num1 = 1;
            decimal num2 = 2;
            string op = "Subtract";
            decimal expectedResult = num1 - num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = System.Convert.ToDecimal(calc.OperatorSwitch(num1, num2, op));
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void SimpleCalc_OperatorSwitch_Operator_Multiply()
        {
            decimal num1 = 1;
            decimal num2 = 2;
            string op = "Multiply";
            decimal expectedResult = num1 * num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = System.Convert.ToDecimal(calc.OperatorSwitch(num1, num2, op));
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void SimpleCalc_OperatorSwitch_Operator_Divide()
        {
            decimal num1 = 1;
            decimal num2 = 2;
            string op = "Divide";
            decimal expectedResult = num1 / num2;

            SimpleCalc calc = new SimpleCalc();
            decimal result = System.Convert.ToDecimal(calc.OperatorSwitch(num1, num2, op));
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void SimpleCalc_OperatorSwitch_Operator_Default()
        {
            decimal num1 = 1;
            decimal num2 = 2;
            string op = default;
            decimal expectedResult = 0;

            SimpleCalc calc = new SimpleCalc();
            decimal result = System.Convert.ToDecimal(calc.OperatorSwitch(num1, num2, op));
            Assert.AreEqual(expectedResult, result);
        }
    }
}
