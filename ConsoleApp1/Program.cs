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
            int num1;
            int num2;

            int result;

            string answer;

            Console.WriteLine("Hello, welcome to the calc(short for calculator) program!");
            Console.WriteLine("Please enter your first number for the calc(short for calculator)!!");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number for the calc(short for calculator chat).");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operation would you like to do for the calc(short for calculator chat).");
            Console.WriteLine("A for Addition, s for subtraction, m for multiplication, or any other key for division. for the calc(short for calculator chat).");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using my calc(short for calculator chat)!!!!");

                Console.ReadKey();
        }
    }
}