using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIntegerCalculator
{
    class IntegerCalculator
    {
        int a; 
        int b;

        public IntegerCalculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Add()
        {
            int sum = a + b;
            Console.WriteLine($"( {a} ) + ( {b} ) = {sum}");
        }

        public void Subtract()
        {
            int difference = a - b;
            Console.WriteLine($"( {a} ) - ( {b} ) = {difference}");
        }
        public void Multiply()
        {
            int product = a * b;
            Console.WriteLine($"( {a} ) x ( {b} ) = {product}");
        }

        public void Divide()
        {
            if (b != 0)
            {
                int quotient = a / b;
                int remainder = a % b;
                string message = (remainder == 0) ? $"( {a} ) / ( {b} ) = {quotient}" : $"{a} / {b} = {quotient} with remainder = {remainder}";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"( {a} ) / ( {b} ) => Error.");
            }
        }

        public void PrintAllCalculations()
        {
            Add();
            Subtract();
            Multiply();
            Divide();
        }
    }
}
