using System.Reflection.Metadata.Ecma335;

namespace PropertyPerson251028 {
    class Person {
        public static int iq = 150;
        private int age = 0;
        private string? name = null;
        private double height = 0.0;

        //기본생성자(default constructor)
        public Person() {
            Console.WriteLine("난 Person 기본생성자");
        }

        public Person(string name, int page, double pheight) {
            Console.WriteLine("난 인자가 3개인 Person 생성자");
            this.name = name;
            age = page;
            height = pheight;
        }

        public void speak() {
            Console.WriteLine("Person이 말한다");
        }

        public void see() {
            Console.WriteLine("Person이 본다");
        }

        /*
        public string? getName() {
            return name;
        }
        public void setName(string pname) {
            name = pname;
        }
        */

        public string? Name { get { return name; } set { name = value; } }
        /*
        public void setAge(int page) {
            age = page;
        }
        public int getAge() {
            return age;
        }
        */


        public int Age { get { return age; } set { age = value; } }

        /*
        public void setHeight(double pheight) {
            height = pheight;
        }
        public double getHeight() {
            return height;
        }
        */

        public double Height{ get { return height; } set { height = value; } }

    }

    internal class Program {
        static void Main(string[] args) {

            Person hodong = new Person();

            hodong.Name = "강호동";
            Console.WriteLine("hodong.name={0}", hodong.Name);

            hodong.Age = 49;
            Console.WriteLine("hodong.age={0}", hodong.Age);

            hodong.Height = 178.5;
            Console.WriteLine("hodong.Height={0}", hodong.Height);

            hodong.speak();
            hodong.see();

            
            Person chulsu = new Person("김철수", 23, 184.5);
            Person.iq = 140;

            Console.WriteLine("chulsu.name={0} ," + "chulsu.age={1} ," + "chulsu.height={2}",
                chulsu.Name, chulsu.Age, chulsu.Height);
            
        }
    }
}
