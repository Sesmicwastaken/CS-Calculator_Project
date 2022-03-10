namespace CS_Calculator.Functions
{
    public class MathOperators
    {
        public static double ValueA, ValueB;
        public static double Operators(string input)

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
            return output;
        }
    }
}
