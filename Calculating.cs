using System;
using System.Windows.Forms;

namespace calc
{
    internal class Calculating
    {
        public char operation;
        public static double dataNumber { get; set; }

        public double calculateData(double num)
        {
            switch (operation)
            {
                case '%':
                    return dataNumber / num * 100;
                case '^':
                    return Math.Pow(dataNumber, num);
                case '+':
                    return dataNumber + num;
                case '-':
                    return dataNumber - num;
                case '*':
                    return dataNumber * num;
                case '/':
                    return dataNumber / num;
                default: return 0;
            }
        }
        public double fib(double n)
        {
            return n == 0 || n == 1 ? n : fib(n - 1) + fib(n - 2);
        }
        public double Factorial(double n)
        {
            if (n == 1 || n == 0) return 1;

            return n * Factorial(n - 1);
        }
        public double CalculateSQRT(double num)
        {
            return Math.Sqrt(num);
        }
        public double CalculateDivisionByX(double num)
        {
            return 1 / num;
        }
        public string UpdateInput(Button button)
        {
            switch (button.Text)
            {
                case ",":
                    return ",";
                case "1":
                    return "1";
                case "2":
                    return "2";
                case "3":
                    return "3";
                case "4":
                    return "4";
                case "5":
                    return "5";
                case "6":
                    return "6";
                case "7":
                    return "7";
                case "8":
                    return "8";
                case "9":
                    return "9";
                case "0":
                    return "0";
                default:
                    return "-";
            }
        }
    }
}
