namespace Exam03
{
    class Calculate
    {
        public int Plus(int a, int b)
        {
            return (a + b);
        }

        public int Minus(int a, int b)
        {
            return (a - b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            Console.Write(cal.Plus(1, 2)); 
        }
    }
}
