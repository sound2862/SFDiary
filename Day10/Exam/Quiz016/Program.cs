namespace Quiz016
{
    class Horse
    {

    }

    interface lWing
    {
        public void Fly();
    }
    class Unicon : Horse, lWing
    {
        public void Fly()
        {
            Console.WriteLine("날고 있습니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Unicon uni = new Unicon();
            uni.Fly();
        }
    }
}
