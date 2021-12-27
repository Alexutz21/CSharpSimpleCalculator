using System;

namespace simpleCalculator
{
    class Program
    {
        private static char userInput;

        static void Main(string[] args)
        {
            while (true)
            {
                calculator.runCalculator();
                Console.WriteLine("Do you like to continue ? Press y or n");
                char userInput = Convert.ToChar(Console.ReadLine());
           
           if (userInput == 'y')
            {
                calculator.runCalculator();
            }
            else if (userInput == 'n')
                {
                    Console.WriteLine("Thank you!");
                    break;
                }
            }

        }
    }
}
