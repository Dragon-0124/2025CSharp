using System.Runtime.CompilerServices;

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
            Console.WriteLine(
              "난 Person 기본생성자");
        }

        public Person(string name, int page,
                    double ph)
        {
            Console.WriteLine(
              "난 인자3개인 Person 생성자");
            this.name  = name;
            age = page;
            height = ph;
        }

        public double getHeight()
        {
            return height;
        }
        public void setHeight(double  ph)
        {
            height = ph;
        }
        public int getAge()
        {
            return age;
        }
        public void setAge(int page)
        {
            age = page;
        }

        public  string?  getName()
        {
            return name;
        }
        public void setName(string pname)
        {
            name = pname;
        }
        public void speak()
        {
            see();
            Console.WriteLine(
                "Person이 말한다");
        }
        public void see()
        {
            Console.WriteLine(
                "Person 이 본다");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            //기본생성자(Default Constructor method)
            Person hodong = new Person();
            //hodong.name = "강호동";
            hodong.setName("강호동");
            Console.WriteLine(
               "hodong.name={0}",
                    hodong.getName() );

            //hodong.age = 49;//error
            hodong.setAge(49);
            Console.WriteLine(
                    "hodong.age={0}",
                        hodong.getAge() );

            //hodong.height = 178.5;//error
            //hodong객체의 setHeight()메서드를
            //호출해서 키값 178.5를 넣어주는
            //코드 삽입
            hodong.setHeight(178.5);
            Console.WriteLine(
                    "hodong.height={0}",
                   hodong.getHeight() );

            Person chulsu = 
           new Person("김철수", 23, 184.5);
            //chulsu.iq = 140;
            Person.iq = 140;

            Console.WriteLine(
               "chulsu.name={0} ," +
               "chulsu.age={1} ," +
               "chulsu.height={2}",
               chulsu.getName(),
               chulsu.getAge(),
               chulsu.getHeight());
            
            chulsu.setAge(24);


            //. : 멤버접근연산자
            hodong.speak();
            hodong.see();

            
        }
    }
}
