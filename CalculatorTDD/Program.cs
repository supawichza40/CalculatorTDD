using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testing out the calculator function
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Calculate("1 + 3 - 4 + 5"));

        }
    }
}
