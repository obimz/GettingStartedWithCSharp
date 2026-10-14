using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your operator(+, -, *, /): ");
            string myOperator = Console.ReadLine();

            if (myOperator == "+")
            {
                Console.WriteLine(firstNumber + secondNumber);
            }
            else if (myOperator == "-")
            {
                Console.WriteLine(firstNumber - secondNumber);
            }
            else if (myOperator == "*")
            {
                Console.WriteLine(firstNumber * secondNumber);
            }
            else if (myOperator == "/")
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }

            Console.ReadLine();
        }
    }
}
