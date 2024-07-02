namespace Quiz2
{
    internal class Program
    {

        static int Plus(int a, int b)
        {
            return (a + b);
        }

        static int Minus(int a, int b)
        {
            return (a - b);
        }

        static int Multiple(int a, int b)
        {
            return (a * b);
        }

        static double Divide(int a, int b)
        {
            return ((double)a / b);
        }

        static void Main(string[] args)
        {
            //사칙연산 /메소드로
            //메인 메소드 1개, 사칙연산 메소드 4개

            int a = 150;
            int b = 100;

            Console.WriteLine(Minus(a,b));
            Console.WriteLine(Plus(a, b));
            Console.WriteLine(Multiple(a, b));
            Console.WriteLine(Divide(a, b));
        }
    }
}
