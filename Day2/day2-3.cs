namespace Day2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = Int32.Parse(Console.ReadLine());
            int v2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{v1} {v2}");     //100, 200

            int temp = v1;
            v1 = v2;
            v2 = temp;

            Console.WriteLine($"{v1} {v2}");     //200, 100
        }
    }
}
