namespace RandomApp202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> lottoNumberList = new List<int>();

            while (lottoNumberList.Count < 7)
            {
                int number = random.Next(1, 10);

                //중복체크
                if(!lottoNumberList.Contains(number))
                    lottoNumberList.Add(number);
            }
            //보너스 번호 뽑기 0번지 첫번쨰 요소를 보너스번호로
            int bonusNumber = lottoNumberList[0];
            lottoNumberList.RemoveAt(0);
            lottoNumberList.Sort();
            foreach (int i in lottoNumberList)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            //보너스번호 출력
            Console.WriteLine($"보너스 번호 : {bonusNumber}");

        }
    }
}
