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

    }
}
