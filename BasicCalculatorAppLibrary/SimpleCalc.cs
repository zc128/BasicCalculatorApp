using System;

namespace BasicCalculatorAppLibrary
{
    public class SimpleCalc
    {
        public decimal additionFunc(decimal leftNumber, decimal rightNumber) 
        {
            return leftNumber + rightNumber;
        }
        public decimal subtractionFunc(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber - rightNumber;
        }
        public decimal multiplicationFunc(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber * rightNumber;
        }
        public decimal divisionFunc(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber / rightNumber;
        }

        public string OperatorSwitch(decimal leftNumber, decimal rightNumber, string operators)
        {
            string result;
            switch (operators)
            {
                case "Add":
                    result = (leftNumber + rightNumber).ToString();
                    break;
                case "Subtract":
                    result = (leftNumber - rightNumber).ToString();
                    break;
                case "Multiply":
                    result = (leftNumber * rightNumber).ToString();
                    break;
                case "Divide":
                    if (rightNumber != 0)
                    {
                        result = (leftNumber / rightNumber).ToString();
                    }
                    else
                    {
                        result = "ERROR: SecondNum CAN'T be 0 in Division!";
                    }
                    break;
                default:
                    result = 0.ToString();
                    break;
            }
            return result;
        }

    }
}
