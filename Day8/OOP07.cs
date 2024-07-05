namespace OOP07
{
    class Horse
    {
        public int legs;
        public string color;

        public void Run()
        {
            Console.WriteLine("말이 달리고있습니다");
        }
    }
    class Angel
    {

    }
    interface IWing
    {
        public void Fly(); //Abstract Method
    }
    interface IWing2
    {
        public void Fly();
    }
    class Unicon : Horse, IWing
    {
        public void Fly()
        {
            Console.WriteLine("유니콘이 난다");
        }
        public void PerforMagic()
        {
            Console.WriteLine("마법 사용");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Unicon jack = new Unicon();
            jack.Fly();
            jack.Run();
            jack.PerforMagic();
        }
    }
}
