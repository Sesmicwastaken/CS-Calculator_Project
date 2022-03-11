using CS_Calculator_Project.Methods;

namespace CS_Calculator_Project.Input
{
    public class Input
    {
        public static void Main(string[] args)
        {
            Options.Summary();

            while (true)
            {
               
                Console.Write("\nEnter 1st value: ");
                string valueA = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(valueA))
                {
                    Console.WriteLine("Value cannot be null.");
                    return;
                }
                MathOperators.ValueA = Convert.ToDouble(valueA);

                Console.Write("\nEnter the operator: ");
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Operator cannot be null");
                    return;
                }

                Console.Write("\nEnter 2nd value: ");
                string valueB = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(valueB))
                {
                    Console.WriteLine("Value cannot be null.");
                    return;
                }

                MathOperators.ValueB = Convert.ToDouble(valueB);

                Console.WriteLine(MathOperators.Operators(input));

                Console.WriteLine("\nDo you want to continue?");
                string answer = Console.ReadLine().ToLower().Trim();
                if (answer == "no")
                {
                    return;
                }
                else if (answer == "yes")
                {
                    continue;
                }
                
                else if (answer != "no" || answer != "yes" || string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("\nInvalid Response, exiting the program.");
                    return;
                }

            }
        }
    }
}



