namespace Arr3DxEx0930
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int [면, 행, 열]
            int[,,] num = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            for (int meon = 0; meon < num.GetLength(0); ++meon)
                for (int row = 0;row < num.GetLength(1); ++row)
                    for (int col = 0;col < num.GetLength(2); ++col) {
                        Console.WriteLine("num[{0},{1},{2}] = {3}", meon, row, col, num[meon, row, col]);
                    }
            
            string[] fruit = { "사과", "배", "포도", "딸기", "바나나" };
            
            Console.WriteLine();
            for (int i = 0; i < fruit.Length; ++i){
                Console.WriteLine("fruit[{0}] = {1}", i, fruit[i]);
            }
            
            Console.WriteLine();
            //foreach (string a in fruit) {
            foreach (var a in fruit){
                Console.WriteLine("fruit = {0}", a);
            }

        }
    }
}
