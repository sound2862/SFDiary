namespace ConsoleApp10
{
    class Person
    {
        private string name;
        public Person()
        {
            name = "이름 없음";
            Console.WriteLine("생성자 호출");
        }

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine($"인자가 하나있는 생성자 : {this.name}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ps1 = new Person("홍길동");
        }
    }
}
