using System.Net.Http.Headers;

namespace Method
{
    class Program
    {
        static int Plus( int a, int b)
        {
            return a + b;
        }
        static int Minus( int a, int b )
        {
            return a - b;
        }
        static void Main()
        {
            int v1 = 100;
            int v2 = 200;
            int plus = Plus(v1, v2);
            int min = Minus(v1, v2);

            Console.WriteLine($"{plus}, {min}");
        }
    }
}
