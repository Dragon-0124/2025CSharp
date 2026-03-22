namespace Test251014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input = null;

            while (true)
            {
                Console.Write("정수의 갯수와 찾고자 하는 수를 공백으로 구분하여 입력:");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("아무런 내용도 입력되지 않았습니다. 숫자 2개를 입력해주세요.");
                    continue;
                }

                string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (numbers.Length != 2)
                {
                    Console.WriteLine("정수의 갯수와 찾고자 하는 수 2개만 입력해 주세요.");
                    continue;
                }

                int num1, num2;
                try
                {
                    num1 = int.Parse(numbers[0]);
                    num2 = int.Parse(numbers[1]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("잘못된 형식입니다. 숫자를 정확히 입력해주세요.");
                    continue;
                }
                break; // 메인 루프 탈출
            }
        }
    }
}