namespace Calc_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input = null;

            while (true)
            {
                Console.WriteLine("계산할 수 2개 입력:");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("아무런 내용도 입력되지 않았습니다. 숫자 2개를 입력해주세요.");
                    continue;
                }

                string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (numbers.Length != 2)
                {
                    Console.WriteLine("숫자는 정확히 2개를 입력해 주세요.");
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

                while (true)
                {
                    Console.WriteLine("연산자를 입력해주세요.:");
                    string? op = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(op) || op.Length != 1)
                    {
                        Console.WriteLine("(+, -, *, /)중 하나만 입력해주세요.");
                        continue;
                    }

                    if (op == "+")
                    {
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                    }
                    else if (op == "-")
                    {
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                    }
                    else if (op == "*")
                    {
                        Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                    }
                    else if (op == "/")
                    {
                        if (num2 == 0)
                        {
                            Console.WriteLine("0으로는 나눌 수 없습니다.");
                        }
                        else
                        {
                            Console.WriteLine("{0} / {1} = {2} ... {3}", num1, num2, num1 / num2, num1 % num2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("연산자는 (+, -, *, /)중 하나를 입력해주세요.");
                        continue;
                    }
                    break; // 연산자 루프 탈출
                }
                break; // 메인 루프 탈출
            }
        }
    }
}