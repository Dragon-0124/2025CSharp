using System.Text;

namespace AntArray;

internal class Program
{
    static void Main(string[] args)
    {
        string currentTerm = "1";
        int targetN = 20;

        Console.WriteLine($"1번째: {currentTerm}");

        for (int i = 2; i <= targetN; i++)
        {
            currentTerm = GetNextTerm(currentTerm);
            Console.WriteLine($"{i}번째: {currentTerm}");
        }

        string GetNextTerm(string term)
        {
            StringBuilder nextTermBuilder = new StringBuilder();
            int index = 0;

            while (index < term.Length)
            {
                char currentDigit = term[index];
                int count = 0;

                while (index < term.Length && term[index] == currentDigit)
                {
                    count++;
                    index++;
                }

                nextTermBuilder.Append(currentDigit);
                nextTermBuilder.Append(count);
            }

            return nextTermBuilder.ToString();
        }
    }
}
