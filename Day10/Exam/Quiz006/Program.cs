namespace Quiz006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bigCnt = 0, smlCnt = 0, numCnt = 0, speCnt = 0;

            string asdf = Console.ReadLine();

            for (int i = 0; i < asdf.Length; i++) 
            {
                if (asdf[i] >= 'A' && asdf[i] <= 'Z') 
                {
                    bigCnt++;
                }
                else if (asdf[i] >= 'a' && asdf[i] <= 'z')
                {
                    smlCnt++;
                }
                else if(asdf[i] >= '0' && asdf[i] <= '9')
                {
                    numCnt++;
                }
                else speCnt++;
            }

            Console.WriteLine($"알파벳 대문자 : {bigCnt}");
            Console.WriteLine($"알파벳 소문자 : {smlCnt}");
            Console.WriteLine($"숫자 : {numCnt}");
            Console.WriteLine($"특수문자 : {speCnt}");
        }
    }
}
