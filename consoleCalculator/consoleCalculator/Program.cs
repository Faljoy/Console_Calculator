using System;

namespace consoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator");
            Console.WriteLine("Input you number:");
            double firstOperator = Calculator.ReturnDouble();
            Console.WriteLine();
            Console.WriteLine("chose operator(+ - / * % sqrt !)");
            string operatorInput;
            bool check = Calculator.OperatorInput(out operatorInput);
            double secondOperator=0;
            if (check)
            {
                Console.WriteLine("Input second number:");
                secondOperator = Calculator.ReturnDouble();
            }
            double result = 0;
            switch (operatorInput)
            {
                case "+":
                    result=Calculator.Sum(firstOperator, secondOperator);
                    break;
                case "-":
                    result = Calculator.Substract(firstOperator, secondOperator);
                    break;
                case "/":
                    result = Calculator.Division(firstOperator, secondOperator);
                    break;
                case "*":
                    result = Calculator.Multiply(firstOperator, secondOperator);
                    break;
                case "%":
                    result = Calculator.Divide(firstOperator, secondOperator);
                    break;
                case "sqrt":
                    result = Calculator.Sqrt(firstOperator);
                    break;
                //case "!":
                    //result = Calculator.factorial(firstOperator);
                   // break;
                default:
                    Console.WriteLine("False");
                    break;
            }
            Console.WriteLine("Result: ");
            Console.Write(result);
        }
    }
}
