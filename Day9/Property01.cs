namespace Property01
{
    class Person
    {
        public Person() { }
        public Person(double d) { }
        public Person(string name) { this.Name = name; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ps = new Person("밥");
            //ps.Name = "Test";
            Console.WriteLine(ps.Name);
        }
    }
}
