using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one");
            var parseResult1 = double.TryParse(Console.ReadLine(), out var value1);

            Console.WriteLine("Enter number two");
            var parseResult2 = double.TryParse(Console.ReadLine(), out var value2);

            if (!parseResult1 || !parseResult2)
            {
                Console.WriteLine("Incorrect number entered!");
                Console.ReadKey();
                return;
            }

            //TO DO CALCULATOR

            //var sum = Calculator.Add(value1, value2);
            //Console.WriteLine($"The sum of the {value1} and {value2} is {sum}"); 

            //var dif = Calculator.Sub(value1, value2);
            //Console.WriteLine($"The difference of the {value1} and {value2} is {dif}"); 

            //var mul = Calculator.Mul(value1, value2);
            //Console.WriteLine($"The multiplication of the {value1} and {value2} is {mul}");

            //var quot = Calculator.Div(value1, value2);
            //Console.WriteLine($"The quotient of the {value1} and {value2} is {quot}"); 

            //var secondDeg = Calculator.SecondDeg(value1);
            //Console.WriteLine($"The {value1} in the second degree is {binaryDeg}"); 

            //And so on...

            Console.ReadKey();
        }
    }

}