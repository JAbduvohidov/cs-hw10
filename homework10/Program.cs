using System;

namespace homework10
{
    class Program
    {
        delegate T Calculate<T>(T a, T b);

        static void Main(string[] args)
        {
            var operand1 = 1.0;
            var operand2 = 2.0;
            Console.Write("enter sign: ");
            var sign = Console.ReadLine();
            Calculate<double> calculate = null;
            switch (sign)
            {
                case "+":
                    calculate = Calculator.Add;
                    break;
                case "-":
                    calculate = Calculator.Subtract;
                    break;
                case "*":
                    calculate = Calculator.Multiply;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("division by zero is not allowed");
                        break;
                    }

                    calculate = Calculator.Divide;
                    break;
                default:
                    Console.WriteLine("invalid sign");
                    break;
            }
            
            if (calculate != null) Console.WriteLine($"{operand1} {sign} {operand2} = {calculate.Invoke(operand1, operand2)}");
        }
    }
}