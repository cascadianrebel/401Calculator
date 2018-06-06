using System;

namespace _401Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C@l<UL4t0R");

            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose 1 to add");
            Console.WriteLine("Choose 2 to subtract");
            Console.WriteLine("Choose 3 to divide");
            Console.WriteLine("Choose 4 to multiply");
            string opera1 = Console.ReadLine();

            Console.WriteLine("Enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (opera1 == "1") 
            {
                int sum = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {sum}");
            }

            if (opera1 == "2")
            {
                int difference = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {difference}");
            }

            if (opera1 == "3")
            {
                int quotient = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {quotient}");
            }

            if (opera1 == "4")
            {
                int product = num1 * num2;
                Console.WriteLine($"{num1} x {num2} = {product}");

            }
        }
    }

}
