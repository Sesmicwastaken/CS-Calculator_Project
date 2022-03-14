using CS_Calculator_Project.Methods;

namespace CS_Calculator_Project.Input
{
    public class Input
    {
        public static void Main(string[] args)
        {

            Options.Summary();

            Console.Write("\nValue: ");
            string valueA = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(valueA))
            {
                Console.WriteLine("Value cannot be null.");
                return;
            }           
            
            else if (valueA.ToLower() == "exit")
            {
                Console.WriteLine("\nExiting the program...");
                return;
            }
            try { MathOperators.ValueA = Convert.ToDouble(valueA); }
            catch { throw new Exception("Invalid input"); }

            while (true)
            {
               

                Console.Write("\nOperator: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Operator cannot be null");
                    return;
                }
                else if (input.ToLower() == "%")
                {
                    MathOperators.Operators(input);
                    Console.WriteLine("\nLast Value: " + MathOperators.Values[0]);
                    MathOperators.ValueA = MathOperators.Values[0];
                    MathOperators.Values.Clear();
                    continue;
                }
                else if (input.ToLower() == "~")
                {
                    MathOperators.Operators(input);
                    Console.WriteLine("\nLast Value: " + MathOperators.Values[0]);
                    MathOperators.ValueA = MathOperators.Values[0];
                    MathOperators.Values.Clear();
                    continue;
                }

                else if (input.ToLower() == "exit")
                {
                    Console.WriteLine("\nExiting the program...");
                    return;
                }
                Console.Write("\nAnother Value: ");
                string valueB = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(valueB))
                {
                    Console.WriteLine("Value cannot be null.");
                    return;
                }
                else if (valueB.ToLower() == "exit")
                {
                    Console.WriteLine("\nExiting the program...");
                    return;
                }
                try { MathOperators.ValueB = Convert.ToDouble(valueB); }
                catch { throw new Exception("Invalid input"); }

                MathOperators.Operators(input);
                try
                {
                    Console.WriteLine("\nLast Value: " + MathOperators.Values[0]);
                    MathOperators.ValueA = MathOperators.Values[0];
                }
                catch 
                {
                    throw new Exception("\nUnfortunately the program crashed");
                    Console.WriteLine();
                    return;
                }
                MathOperators.Values.Clear();
                continue;

            }
        }
    }
}



