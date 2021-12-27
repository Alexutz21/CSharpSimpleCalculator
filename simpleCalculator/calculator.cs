using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    public class calculator
    {
        public static void ourCalculator()
        {
        int a, b;
        int sum;
        Console.WriteLine("SIMPLE CALCULATOR");
            Console.WriteLine();
            
            Console.Write("Please enter a number and press enter: ");
            
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Perfect,\nnow enter another number and press enter: ");
                b = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
            Console.Write("What operation do you want to perform: ");
                char operation = Convert.ToChar(Console.ReadLine()); Console.WriteLine();
            if (operation == '+')
            {
                Console.WriteLine("You chose addition of the numbers");
                sum = (a + b);
                Console.WriteLine($"Number {a} + {b} = {sum}");
                Console.WriteLine();
            }
            else if (operation == '-')
            {
                sum = (a - b);
                Console.WriteLine("You chose subtract the numbers ");
                Console.WriteLine($"Number {a} - {b} = {sum}"); Console.WriteLine();
            }
            else if (operation == '*')
            {
                int sumM = (a * b);
                Console.WriteLine("You have chosen to multiply the numbers");
                Console.WriteLine($"Number {a} * {b} = {sumM}"); Console.WriteLine();
            }
            else if (operation == '/')
            {
                double sumD = (a / b);
                Console.WriteLine("You have chosen to divide the numbers");
                Console.WriteLine($"Number {a} / {b} = {sumD}"); Console.WriteLine();
            }
        }
        public static void runCalculator()
        {
            ourCalculator();
        }
        
    }
}
