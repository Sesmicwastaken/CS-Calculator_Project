using CS_Calculator.Functions;

namespace CS_Calculator.Input
{
    public class Input
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Enter 1st value:");
                string valueA = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(valueA))
                {
                    Console.WriteLine("Value cannot be null.");
                    return;
                }
                MathOperators.ValueA = Convert.ToDouble(valueA);

                Console.Write("Enter the operator:");
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Operator cannot be null");
                    return;
                }

                Console.Write("Enter 2nd value:");
                string valueB = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(valueB))
                {
                    Console.WriteLine("Value cannot be null.");
                    return;
                }

                MathOperators.ValueB = Convert.ToDouble(valueB);

                Console.WriteLine(MathOperators.Operators(input));

                Console.WriteLine("Do you want to continue?");
                string answer = Console.ReadLine().ToLower().Trim();
                if (answer == "no" || string.IsNullOrEmpty(answer))
                {
                    return;
                }
                else if (answer == "yes")
                {
                    continue;
                }

            }
        }
    }
}



