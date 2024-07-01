namespace Array03
{
    internal class Program
    {
        //1. 크기100인 정수형 배열을 만들고 1~100 까지 초기화 하세요.
        //2. 3의 배수는 배열의 요소값을 이용해서 콘솔 화면에 출력.
        //3. 7의 배수는 index값을 이용해서 출력.

        static void Main(string[] args)
        {
            int[] arr1 = new int[100];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i + 1;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 3 == 0)
                {
                    Console.WriteLine(arr1[i]);
                }
            }

            for (int i = 0; i < arr1.Length; i+=7)
            {
                Console.WriteLine(arr1[6+i]);
            }
        }
    }
}
