namespace QUIZ004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"{num1} {num2}");
        }
    }
}
