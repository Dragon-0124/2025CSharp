namespace PrimeNum
{
    internal class Program
    {
        public class PrimeFinder
        {
            public static bool IsPrime(int n)
            {
                if (n < 2)
                {
                    return false;
                }
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            public static void Main(string[] args)
            {
                Console.WriteLine("소수구하기 프로그램");
                Console.Write("소수를 구할 정수 한개 입력:");


                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number < 1)
                    {
                        Console.WriteLine("1 이상의 양의 정수를 입력해주세요.");
                        return;
                    }

                    int primeCount = 0;

                    for (int i = 1; i <= number; i++)
                    {
                        if (IsPrime(i))
                        {
                            Console.WriteLine($"{i}은(는) 소수이다.");
                            primeCount++;
                        }
                    }


                    Console.WriteLine($"1~{number} 사이의 소수 개수={primeCount}");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 정수를 입력해주세요.");
                }
            }
        }
    }
}