﻿namespace CS_Calculator_Project.Methods
{
    public class MathOperators
    {
        internal static double ValueA, ValueB;

        public static string Operators(string input)

        {
           
            double output = 0;
            string Operator = input.Trim();
            switch (Operator)
            {
                case "+":
                    output = ValueA + ValueB;
                    break;
                case "-":
                    output = ValueA - ValueB;
                    break;
                case "/":
                    output = ValueA / ValueB;
                    break;
                case "*":
                    output = ValueA * ValueB;
                    break;
                case "^":
                    output = Math.Pow(ValueA, ValueB);
                    break;

            }
            Options.temp = output;
            return "The answer is: " + output;
        }
    }
}
