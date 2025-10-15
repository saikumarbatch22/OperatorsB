using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsB
{
    /*
    * This is my first program.
     * What is operator:
     * It perform operation between two operands.
     * for ex:
     * c=a+b;
     * here a and b are called operands 
     * where "+" is an operator.
     * 
     * Types of Operator:
     * 1)Arithmetic
     * 2)Relational
     * 3)Assignment
     * 4)Logical
     * 5)Conditional or ternary
     * 6)Increment and Decrement
     * 7)Bit wise 
     * 
     * Arithmetic Operator is used to perform
     * arithmetic operations like addition,substraction,
     * multiplication,division and modulus.
     * 
     * This is a new line added in to 
     * the project.
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Sub();
            Mul();
            Div();
            Modulus();
        }
        private static void Add()
        {
            Console.WriteLine("Enter a value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("sum of {0} and {1} is {2}", a, b, c);

        }
        private static void Sub()
        {
            Console.WriteLine("Enter a value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int b = int.Parse(Console.ReadLine());
            int c = a - b;
            Console.WriteLine("diff of {0} and {1} is {2}", a, b, c);

        }
        private static void Mul()
        {
            Console.WriteLine("Enter a value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int b = int.Parse(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("mul of {0} and {1} is {2}", a, b, c);

        }
        private static void Div()
        {
            Console.WriteLine("Enter a value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int b = int.Parse(Console.ReadLine());
            int c = a / b;
            Console.WriteLine("div of {0} and {1} is {2}", a, b, c);

        }
        private static void Modulus()
        {
            Console.WriteLine("Enter a value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value");
            int b = int.Parse(Console.ReadLine());
            int c = a % b;
            Console.WriteLine("Mod of {0} and {1} is {2}", a, b, c);

        }
    }
}
