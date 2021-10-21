using System;
using System.Collections.Generic;
using System.Text;

namespace consoleCalculator
{
    public static class Calculator
    {
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Substract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double Sqrt(double num1)
        {
            return Math.Sqrt(num1);
        }

        public static double Divide(double x , double y)
        {
            while (y == 0)
            {
                Console.WriteLine("It`s a 0");
                return 0;
            }
            return x / y;
        }

        public static double ReturnDouble()
        {
            string num = Console.ReadLine();
            bool check = Double.TryParse(num, out double x);
            if (!check)
            {
                Console.WriteLine("false input, try again:");
                num = Console.ReadLine();
                check = Double.TryParse(num, out x);

            }
            return x;
        }

    }
}
