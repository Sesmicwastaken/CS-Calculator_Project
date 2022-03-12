using CS_Calculator_Project.Methods;

namespace CS_Calculator_Project.Input
{
    public class Input
    {
        public static void Main(string[] args)
        {
           

            while (true)
            {
                Options.Summary();
                Console.Write("\nEnter 1st value: ");
                string valueA = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(valueA))
                {
                    Console.WriteLine("Value cannot be null.");
                    return;
                }
               
                try { MathOperators.ValueA = Convert.ToDouble(valueA);}
                catch { throw new Exception("Invalid input"); }

                Console.Write("\nEnter the operator: ");

                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
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

                try { MathOperators.ValueB = Convert.ToDouble(valueB); }
                catch { throw new Exception("Invalid input"); }

                Console.WriteLine(MathOperators.Operators(input));

                Console.WriteLine("\nDo you want to continue?");
                string answer = Console.ReadLine().ToLower().Trim();
                if (answer == "no")
                {
                    return;
                }
                else if (answer == "yes")
                {
                    Console.Clear();
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



