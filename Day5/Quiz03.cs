namespace Quiz03
{
    //1~100까지의 합은 5050. 이를 메소드로 만들어서, Main에서는 결과만 출력.
    //5050결과는 NumberAdd 메소드를 만들어서 동작시켜라.

    internal class Program
    {
        static int NumberAdd(int start, int end)
        {
            int sum = 0;
            for(int i = start; i<=end; i++)
            {
                sum += i;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NumberAdd(77, 700)); 
        }
    }
}
