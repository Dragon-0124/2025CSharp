using System;

namespace OperatorEx250909
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Hour > 3 && 8 > DateTime.Now.Hour);

            int a = 2147483640;
            int b = 52273;
            int c = 2147483647;
            int d = 1;
            int x = 2147483647;

            Console.WriteLine(" a + b = {0} ", a + b);
            Console.WriteLine(" c + d = {0} ", c + d);
            Console.WriteLine(" c + x = {0} ", c + x);

            Console.WriteLine("int.MaxValue = {0}", Int32.MaxValue);     // int에서 가장 큰 수
            Console.WriteLine("long.MaxValue = {0}", Int64.MaxValue); // 

            Console.WriteLine("int.MinValue = {0}", Int32.MinValue);     // int에서 가장 작은 수
            Console.WriteLine("long.MinValue = {0}", Int64.MinValue);

            char ch = 'a';
            char su = (char)65 ;

            Console.WriteLine("ch = {0}", ch);
            Console.WriteLine("ch = {0}", (int)ch);

            Console.WriteLine("su = {0}", su);
            Console.WriteLine("su = {0}", (int)su);

        }
    }
}
