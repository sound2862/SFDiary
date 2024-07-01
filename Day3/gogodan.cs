namespace GuGuDan
{
    internal class Program
    {
        //구구단 9단부터 2단까지 
        static void Main(string[] args)
        {
            for(int i=9; i>1; i--)
            {
                for(int j=9; j>0; j--)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
            }
        }
    }
}
