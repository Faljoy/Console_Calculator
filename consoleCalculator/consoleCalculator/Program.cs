using System;

namespace consoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("---------------------------");
            double num1 = 0;
            double num2 = 0;


            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tq - Square root");
            Console.Write("Please, chose? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {Calculus.Sum(num1, num2)}");
                    break;
                case "s":
                    Console.WriteLine($"Your result: {Calculus.Substract(num1, num2)}");
                    break;
                case "m":
                    Console.WriteLine($"Your result: {Calculus.Multiply(num1, num2)}");
                    break;
                case "d":
                    try
                    {
                        num2 = 0;
                        Console.WriteLine("Error!!!");
                    }
                    catch
                    {
                        Console.WriteLine("Exeption!");
                    }
                    finally
                    {
                        Console.WriteLine("Not divide by zero!!!");
                    }
                    Console.WriteLine("End of program");
                    Console.Read();
                    Console.WriteLine($"Your result: {Calculus.Division(num1, num2)}");
                    break;
                case "q":
                    Console.WriteLine($"Your result: {Calculus.Sqrt(num1)}");
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
