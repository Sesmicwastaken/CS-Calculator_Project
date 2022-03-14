namespace CS_Calculator_Project.Methods
{
    public class MathOperators
    {
        internal static double ValueA, ValueB;
        internal static List<double> Values = new();
        internal static double output = 0;
        private static string[] operators = new string[] { "+", "-", "/", "*", "^", "~", "%" };
        public static void Operators(string input)

        {
            if (!operators.Contains(input))
            {
                return;
            }


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
                case "~":
                    output = Math.Sqrt(ValueA);
                    break;
                case "%":
                    output = (ValueA / 100);
                    break;
            }

            Values.Add(output);
            Console.WriteLine("\nResult: " + output);

            output = 0;
        }
    }
}
