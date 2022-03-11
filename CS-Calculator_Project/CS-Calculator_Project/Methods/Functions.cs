namespace CS_Calculator_Project.Methods
{
    public class MathOperators
    {
        public static double ValueA, ValueB;
        public static double temp = 0;
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
             temp = output;
            return "The answer is: " + output;
        }
    }
}
