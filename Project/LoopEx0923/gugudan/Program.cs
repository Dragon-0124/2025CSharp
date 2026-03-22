namespace gugudan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int a = 2; a <= 6; a++)
            {
                Console.WriteLine();

                switch (a)
                {

                    case 2:
                        for (int val = 1; val <= 9; ++val)
                        {
                            for (int dan = a; dan <= a + 3; ++dan)
                            {
                                Console.Write("{0} * {1} = {2}\t", dan, val, dan * val);
                            }
                            Console.WriteLine();
                        }
                        a = a + 3;
                        break;

                    case 6:
                        for (int val = 1; val <= 9; ++val)
                        {
                            for (int dan = a; dan <= a + 3; ++dan)
                            {
                                Console.Write("{0} * {1} = {2}\t", dan, val, dan * val);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}