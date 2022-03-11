using System.Text;

namespace CS_Calculator_Project.Methods
{
    public class Options
    {
        public static void Summary()
        {
            StringBuilder Summary = new StringBuilder();
            Summary.Append("Following operations are supported:").AppendLine("\n");
            Summary.Append("Addition: '+'").AppendLine().Append("Substraction: '-'").AppendLine().Append("Multiplication: '*'").AppendLine().Append("Division: '/'").AppendLine().Append("Power: '^'").AppendLine("\n");
            Summary.Append("Note: The 2nd value that you will enter after using the power operator will act as the power of the 1st number.").AppendLine("\n");
            Summary.Append("Last answer: " + MathOperators.temp);
            Console.WriteLine(Summary);

        }
    }
}
