namespace ToStringEx250916
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 7;
            string? str = num.ToString();

            Console.WriteLine(str);
            Console.WriteLine(str.GetType());
            
            string? val = Convert.ToString(num);
            Console.WriteLine(val);
            Console.WriteLine(val.GetType());
            */


            double score = 0;
            Console.Write("점수 입력(0 ~ 100) : ");
            score = double.Parse(Console.ReadLine());
            
            switch (score)
            {
                case > 100: case < 0:
                    Console.WriteLine("점수 기입 오류입니다.");
                    break;
                case >= 90:
                    Console.WriteLine("A학점입니다");
                    break;

                case >= 80:
                    Console.WriteLine("B학점입니다");
                    break;

                case >= 70:
                    Console.WriteLine("C학점입니다");
                    break;

                case >= 60:
                    Console.WriteLine("D학점입니다");
                    break;

                default:
                    Console.WriteLine("F학점입니다");
                    break;
            }

            switch (score/10)
            {
                case > 10:
                case < 0:
                    Console.WriteLine("점수 기입 오류입니다.");
                    break;
                case >= 9:
                    Console.WriteLine("A학점입니다");
                    break;

                case >= 8:
                    Console.WriteLine("B학점입니다");
                    break;

                case >= 7:
                    Console.WriteLine("C학점입니다");
                    break;

                case >= 6:
                    Console.WriteLine("D학점입니다");
                    break;

                default:
                    Console.WriteLine("F학점입니다");
                    break;
            }
        }
    }
}
