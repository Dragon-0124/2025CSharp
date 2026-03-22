namespace InheritancePerson251028 {
    class Mammal : Object { //자바에서와 같이 C#에서도 가장 상위에 Object클래스가있음
        public Mammal() : base() {
            Console.WriteLine("나는 Mammal의 기본 생성자");
            }

    }
    partial class Person : Mammal{
        public static int iq = 150;
        protected int age = 0;
        protected string? name = null;
        protected double height = 0.0;
        public Person() : base() {
            Console.WriteLine("난 Person 기본생성자");
        }

        public Person(string name, int page, double pheight) {
            Console.WriteLine("난 인자가 3개인 Person 생성자");
            this.name = name;
            age = page;
            height = pheight;
        }

    }

    class Man : Person {
        private int money;
        private string? job;
        public Man() : base(){ // :base ≒ 자바의 super()

            name = "아무개";
            Console.WriteLine("난 Man의 기본 생성자");
        }
        
        public Man(String name, int age, double ph, int money, string job) : base(name, age, ph){
            
            this.money = money;
            this.job = job;
            }
        public int Money
        {
            set { money = value; }
            get { return money; }
        }

        public string? Job
        {
            set { job = value; }
            get { return job; }
        }

        public void speak() {
            Console.WriteLine("Man이 말한다");
        }
    }
    internal class Program {
        static void Main(string[] args) {
            //Man hyunjin = new Man();
            Person hyunjin = new Man();
            //Mammal hyunjin = new Man();

            hyunjin.Name = "류현진";
            Console.WriteLine("hyunjin.Name={0}", hyunjin.Name);


            Man jaesuk = new Man("유재석", 50, 183.7, 7000, "국민MC");
            Console.WriteLine("jaesuk.Name = {0}" + "jaesuk.job = {1}", jaesuk.Name, jaesuk.Job);
        }
    }
}
