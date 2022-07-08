using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDD
{
    public  class CalculatorFormatter
    {
        public List<float> GetNumberFromExpression(string expression)
        {
            List<float> floatList = new List<float>();
            var stringList = expression.Split(' ');
            for (int i = 0; i < stringList.Length; i++)
            {
                if (i % 2 == 0)
                {
                    floatList.Add(float.Parse(stringList[i]));
                }
                
            }
            return floatList;
        }
        public List<char> GetOperatorFromExpression(string expression)
        {
            List<char> charList = new List<char>();
            var stringList = expression.Split(' ');
            for (int i = 0; i < stringList.Length; i++)
            {
                if (i % 2 != 0)
                {
                    charList.Add(char.Parse(stringList[i]));
                }

            }
            return charList;
        }
    }
}
