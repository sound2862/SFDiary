namespace SwapByValue
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
            int x = 3, y = 4;
            Console.WriteLine($"{x} {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"{x} {y}");

        }
    }
}
