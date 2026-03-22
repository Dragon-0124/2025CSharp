namespace Arr2DEx0923
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JAVA - int[][] val = new int[2][3];
            int[,] val = new int[2, 3];
            val[0, 0] = 1;
            val[0, 1] = 2;
            val[1, 2] = 6;


            /*
            C#에서 할당하지 않은 배열에는 자동으로 0이 할당됨.
            ㅡㅡㅡㅡ
            |1|2|0|
            |0|0|6|
            ㅡㅡㅡㅡ
            */
            Console.WriteLine("val[0,0]={0}", val[0, 0]);
            Console.WriteLine("val[1,2]={0}", val[1, 2]);
            Console.WriteLine("--------------------");


            int[ , ] num = new int[2, 3] { { 1, 2, 3 } , { 4, 5, 6 } };

            for (int row = 0; row < num.GetLength(0); row++)
            {
                for (int col = 0; col < num.GetLength(1); col++)
                {
                    Console.WriteLine("num[{0},{1}] = {2}", row, col, num[row, col]);
                }
            }
        }
     
    }
}
