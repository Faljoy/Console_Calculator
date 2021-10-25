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

        public static double Divide(double x, double y)
        {
            while (y == 0)
            {
                Console.WriteLine("It`s a 0");
                return 0;
            }
            return x % y;
        }


        public static double ReturnDouble()
        {
            string num = Console.ReadLine();
            bool check = Double.TryParse(num, out double x);
            while (!check)
            {
                Console.WriteLine("false input, try again:");
                num = Console.ReadLine();
                check = Double.TryParse(num, out x);

            }
            return x;
        }

        public static bool OperatorInput(out string mathOperator)
        {
            while (true)
            {
                mathOperator = Console.ReadLine();
                List<string> operatorWithSecondArguments = new List<string> { "+", "-", "*", "/", "%", "^" };
                List<string> operatorWithOneArguments = new List<string> { "sqrt", "!" };

                if (operatorWithSecondArguments.Contains(mathOperator))
                {
                    return true;//нужно второе число
                }
                else if (operatorWithOneArguments.Contains(mathOperator))
                {
                    return false;//ввод второго числа пропускается
                }
                Console.WriteLine();
                Console.WriteLine("false! Try again");
            }
        }

        public static double Factorial(double num1)
        {
            double result = num1;
            if (num1 <= 101)
            {
                for (int i = 1; i < num1; i++)
                    result *= i;
                return result;
            }
            Console.WriteLine("Big number!!");
            return 0;
        }

        public static double Sqrt(double num)
        {
            double sqrt;
            double i;

            for (i = 1; ; i++)
            {
                sqrt = i * i;
                if (num == sqrt)
                {
                    break;
                }
                if (num < sqrt)
                {
                    i = i - 1;
                    break;
                }
            }
            if (num == 0) i = 0;
            else if (num < 0) i = Double.NaN;
            return i;
        }

        public static double Power(double num1, double num2)
        {
            double resultat = 1;
            if (num2 >= 0)
            {

                for (int i = 0; i < num2; i++)
                {
                    resultat *= num1;
                }
            }
            else
            {
                for (int i = 1; ; i++)
                {
                    int sqrt = i;
                    for (int j = 1; j < -num2; j++) sqrt *= i;
                    if (num1 == sqrt)
                    {
                        resultat = i;
                        break;
                    }
                    if (num1 < sqrt)
                    {
                        resultat = i-1;
                        break;
                    }
                }
            }
            return resultat;
        }
    }
}
