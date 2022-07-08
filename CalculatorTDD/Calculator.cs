using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDD
{
    public class Calculator      
    {
        private CalculatorFormatter _calculatorFormatter;

        public Calculator()
        {
            _calculatorFormatter = new CalculatorFormatter();
        }

        public float Calculate(string expression)
        {   

            var numberList = _calculatorFormatter.GetNumberFromExpression(expression);
            var operatorList = _calculatorFormatter.GetOperatorFromExpression(expression);
            float sum = 0;

            sum = numberList[0];

            for(int i = 0; i < operatorList.Count; i++)
            {
                if (operatorList[i] == '+')
                {
                    sum = Add(sum, numberList[i + 1]);
                }
                else if (operatorList[i] == '-')
                {
                    sum = Subtract(sum, numberList[i + 1]);
                }
            }
            return sum;
        }

        public float Add(float value1)
        {
            return value1;
        }
        public float Add(float value1, float value2)
        {
            return value1 + value2;
        }
        public float Add(params int[] value)
        {
            float totalSum = 0; 
            foreach (int i in value)
            {
                totalSum += i;
            }
            return totalSum;
        }
        public float Subtract(float value1)
        {
            return value1;
        }
        public float Subtract(float value1,float value2)
        {
            return value1- value2;
        }

    }
}
