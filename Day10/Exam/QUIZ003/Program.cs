namespace QUIZ003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("N? ");
                int N = Int32.Parse(Console.ReadLine());

                if (N >= 90 && N <= 100)
                {
                    Console.WriteLine("A학점입니다.");
                }
                else if (N >= 80 && N < 90)
                {
                    Console.WriteLine("B학점입니다.");
                }
                else if (N >= 70 && N < 80)
                {
                    Console.WriteLine("C학점입니다.");
                }
                else if (N >= 60 && N < 70)
                {
                    Console.WriteLine("D학점입니다.");
                }
                else
                    Console.WriteLine("F학점입니다.");
            }
        }
    }
}
