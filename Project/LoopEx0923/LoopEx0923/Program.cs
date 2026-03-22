namespace LoopEx0923
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };

            /*
            foreach (int k in num)
            {
                Console.WriteLine("k = {0}", k);
            }
            
            foreach (var k in num)
            {
                Console.WriteLine("k = {0}", k);
            }

            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine("num[{0}] = {1}",i,num[i]);
            }
            

            Console.WriteLine("수직으로 구구단 출력");
            for (int i = 0; i < 10; ++i)
            {
                if (i == 0) { i =+ 1; }
                Console.WriteLine("{0}단", i);
                for (int j = 0; j < 10; ++j)
                {
                    int multi = i * j;
                    Console.WriteLine("{0} * {1} = {2}", i, j, multi);
                }
                
            }
            */

            Console.WriteLine("수평으로 구구단 출력\n");

            void gugudan(int start, int end) {
                for (int j = 1; j <= 9; ++j)
                {
                    for (int k = start; k <= end; ++k)
                    {
                        int multi = k * j;
                        Console.Write("{0} * {1} = {2}\t", k, j, multi);
                    }
                    Console.WriteLine();
                }
            }

            gugudan(2, 5);

            Console.WriteLine();

            gugudan(6, 9);



        }
    }
}
