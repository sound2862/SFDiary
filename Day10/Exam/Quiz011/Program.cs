namespace Qui011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            for (int i = a.Length - 1; i >= 0; i--) 
            {
                Console.Write(a[i]);
            }
        }
    }
}
