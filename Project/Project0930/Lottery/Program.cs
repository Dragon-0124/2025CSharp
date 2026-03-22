namespace Lottery
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] lottoNumbers = new int[6];

            int count = 0;

            Console.WriteLine("#2-2. 로또 프로그램");
            Console.WriteLine("1부터 45 사이의 정수 6개를 입력하세요.");
            Console.WriteLine("-------------------------------------");

            while (count < 6)
            {
                Console.Write("{0}번째 로또번호 입력 : ",count+1);

                if (!int.TryParse(Console.ReadLine(), out int inputNumber))
                {
                    Console.WriteLine("=> 오류: 숫자만 입력해주세요!");
                    continue;
                }

                
                if (inputNumber < 1 || inputNumber > 45)
                {
                    Console.WriteLine("=> 오류: 1부터 45 사이의 번호를 입력해야 합니다!");
                    continue;
                }
 
                bool isDuplicate = false;
               
                for (int i = 0; i < count; i++)
                {
                    if (lottoNumbers[i] == inputNumber)
                    {
                        isDuplicate = true;
                        break; // 중복을 찾았으므로 더 이상 검사할 필요 없음
                    }
                }

                
                if (isDuplicate)
                {
                    Console.WriteLine("같은 번호가 있습니다!");
                }
                else
                {
                    lottoNumbers[count] = inputNumber;
                    count++;
                }
            }

            Console.Write("\n입력된 로또번호 : ");
            foreach (int number in lottoNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
