namespace ReadLine250909
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                C# 8.0 이상에서 nullable reference type기능이 켜져 있다면
                String은 기본적으로 null불가(non-nullable)타입으로 간주됨
                그런데 string name = null;와 같은 코드에서는 null을 대입했으니
                ㄴ "null을 허용하지 않은 형식(string)에 null을 넣었다"는 경고가 발생함
            */

            int age = 0;

            //string 타입 변수에 null 허용 방법 (1)
            string? name = null;

            char? blood = '\0';

            Console.Write("나이 입력 = ");
            age = int.Parse(Console.ReadLine());
            // age = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("혈액형 입력 = ");
            //blood = char.Parse(Console.ReadLine());
            blood = (char)Console.Read();
            Console.ReadLine();
            
            Console.Write("이름 입력 = ");
            name = Console.ReadLine();
            if (name != null) { 
                Console.WriteLine($"나이 - {0}, 혈액형 - {1}, 이름 - {name}", age, blood);
            }

            /*
            char ch = (char)97;
            Console.WriteLine("ch={0}",ch);

            Double height = 0.0;
            Console.Write("키값 입력 : ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("height - {0}", height);

            //string 타입 변수에 null 허용 방법 (2)
            string addr = null;
            Console.Write("주소를 입력하세요");
            addr = Console.ReadLine() ??"";
            Console.WriteLine("addr - {0}", addr);
            */
        }
    }
}
