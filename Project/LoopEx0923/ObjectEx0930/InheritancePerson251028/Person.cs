namespace InheritancePerson251028 {
    
    internal partial class Person{
        public void speak() {
            Console.WriteLine("Person이 말한다");
        }

        public void see() {
            Console.WriteLine("Person이 본다");
        }
        public string? Name { get { return name; } set { name = value; } }

        public int Age { get { return age; } set { age = value; } }

        public double Height { get { return height; } set { height = value; } }
    }
}
