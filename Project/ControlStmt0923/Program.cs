namespace ControlStmt0923
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.Write("점수 입력 : ");
            //score = Int32.Parse(Console.ReadLine());
            score = Convert.ToInt32(Console.ReadLine());

            /*
            if(95 <= score && score<=100)
            { Console.WriteLine("A+학점"); }
            else if (90 <= score && score <= 94)
            { Console.WriteLine("A0학점"); }
            */

            if(90 <= score && score <= 100)
            {
                if (95 <= score && score <= 100)
                { Console.WriteLine("A+학점"); }
                else
                { Console.WriteLine("A0학점"); }
            }
            else if (80 <= score && score <= 89)
            { Console.WriteLine("B학점"); }
            else if (70 <= score && score <= 79)
            { Console.WriteLine("C학점"); }
            else if (60 <= score && score <= 69)
            { Console.WriteLine("D학점"); }
            else 
            { Console.WriteLine("F학점"); }


            //short-cut 적용

            if (90 <= score)
            { 
                if (95 <= score)
                    { Console.WriteLine("A+학점"); }
                else
                    { Console.WriteLine("A0학점"); }
            }

            else if (80 <= score)
            { Console.WriteLine("B학점"); }
            
            else if (70 <= score)
            { Console.WriteLine("C학점"); }
            
            else if (60 <= score)
            { Console.WriteLine("D학점"); }
            
            else
            { Console.WriteLine("F학점"); }
        }
    }
}
