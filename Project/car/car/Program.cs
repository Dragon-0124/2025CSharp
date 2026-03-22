namespace car
{
    using System;

    public class Car {
        private int speed;
        private int number;
        private string carname;
        private string addr;
        private string carcolor;

        public Car(int speed, int number, string carname, string addr, string carcolor) {
            this.speed = speed;
            this.number = number;
            this.carname = carname;
            this.addr = addr;
            this.carcolor = carcolor;
        }

        public void ShowInfo() {
            Console.WriteLine($"speed={this.speed}");
            Console.WriteLine($"number={this.number}");
            Console.WriteLine($"carname={this.carname}");
            Console.WriteLine($"addr={this.addr}");
            Console.WriteLine($"carcolor={this.carcolor}");
        }

        public void SpeedUp(int up) {
            this.speed += up;
            Console.WriteLine($"증가된 차의 속도={this.speed}");
        }

        public void SpeedDown(int down) {
            this.speed -= down;
            Console.WriteLine($"감소된 차의 속도={this.speed}");
        }
    }

    public class Program {
        public static void Main(string[] args) {
            Console.Write("차의 속도를 입력: ");
            int speed = int.Parse(Console.ReadLine());

            Console.Write("차의 넘버를 입력: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("차의 이름을 입력: ");
            string? carname = Console.ReadLine();

            Console.Write("차 운전자의 주소를 입력: ");
            string? addr = Console.ReadLine();

            Console.Write("차의 색깔을 입력: ");
            string? carcolor = Console.ReadLine();

            Car myCar = new Car(speed, number, carname, addr, carcolor);

            myCar.ShowInfo();

            Console.Write("증가시킬 차의 속도 입력: ");
            int upSpeed = int.Parse(Console.ReadLine());
            myCar.SpeedUp(upSpeed);

            Console.Write("감소시킬 차의 속도 입력: ");
            int downSpeed = int.Parse(Console.ReadLine());
            myCar.SpeedDown(downSpeed);
        }
    }
}
