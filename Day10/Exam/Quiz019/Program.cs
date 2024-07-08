namespace Quiz019
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {

            int a = 3, b = 4;
            Console.WriteLine($"{a} {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"{a} {b}");

        }
    }
}