namespace _202230216
{
    internal class Program
{
    static void Main(string[] args)
    {
        string name = "";
        Console.WriteLine("이름을 입력하세요:");
        name = Console.ReadLine();

        string department = "";
        Console.WriteLine("학과를 입력하세요:");
        department = Console.ReadLine();

        int EngScore = 0;
        Console.WriteLine("영어 점수를 입력하세요:");
        EngScore = int.Parse(Console.ReadLine());
        int PhyScore = 0;
        Console.WriteLine("물리학 점수를 입력하세요:");
        PhyScore = int.Parse(Console.ReadLine());
        int CalScore = 0;
        Console.WriteLine("미적분 점수를 입력하세요:");
        CalScore = int.Parse(Console.ReadLine());

        int total = EngScore + PhyScore + CalScore;
        double average = total / 3;

        string address = null;
        while (true)
        {
            Console.WriteLine("주소를 입력하세요 : ");
            address = Console.ReadLine();

                if (address.Count(c => c == ' ') >= 2)
                { break; }
                else
                { Console.WriteLine("주소 입력시 시, 군, 구 이름을 반드시 띄워쓰기 해주세요  (예 : 경기도 안양시 동안구)"); }
            }

        Console.WriteLine($"\n이름 = {name}, 학과명 = {department}");
        Console.WriteLine($"영어 = {EngScore}, 물리학 = {PhyScore}, 미적분학 = {CalScore}");
        Console.WriteLine($"총점 = {total}, 평균 = {average}");
        Console.WriteLine($"주소 = {address}");

    }
}
}
