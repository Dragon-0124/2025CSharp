namespace ObjectEx0930
{
    class Person
    {
        public static int iq = 150;
        private int age = 0;
        private string? name = null;
        private double height = 0.0;

        //기본생성자(default constructor)
        public Person()
        {
            Console.WriteLine("난 Person 기본생성자");
        }

        public Person(string name, int page, double pheight)
        {
            Console.WriteLine("난 인자가 3개인 Person 생성자");
            this.name = name;
            age = page;
            height = pheight;
        }

        public void speak()
        {
            Console.WriteLine("Person이 말한다");
        }

        public void see()
        {
            Console.WriteLine("Person이 본다");
        }

        public string? getName()
        {
            return name;
        }
        public void setName(string pname)
        {
            name = pname;
        }

        public void setAge(int page)
        {
            age = page;
        }
        public int getAge()
        {
            return age;
        }

        public void setHeight(double pheight)
        {
            height = pheight;
        }
        public double getHeight()
        {
            return height;
        }

        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            //기본생성자(Default Constructor method)
            Person hodong = new Person();

            //hodong.name = "강호동";
            hodong.setName("강호동");
            Console.WriteLine("hodong.name={0}", hodong.getName());

            //hodong.age = 49;
            hodong.setAge(49);
            Console.WriteLine("hodong.age={0}", hodong.getAge());

            //hodong.height = 178.5;
            hodong.setHeight(178.5);
            Console.WriteLine("hodong.Height={0}", hodong.getHeight());

            // : 멤버접근연산자
            hodong.speak();
            hodong.see();

            Person chulsu = new Person("김철수", 23, 184.5);
            //chulsu.iq = 140;
            Person.iq = 140;
            Console.WriteLine("chulsu.name={0} ," + "chulsu.age={1} ," + "chulsu.height={2}",
                chulsu.getName(), chulsu.getAge(), chulsu.getHeight());

        }
    }
}
