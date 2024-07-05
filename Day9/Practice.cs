using System.Collections.Generic;

namespace Practice
{
    class Lotto
    {
        public void Second()    //리스트
        {
            List<int> numbers = new List<int>();
            Random random = new Random();
            
            while (numbers.Count < 7) 
            {
                int num = random.Next(1, 10);
                //중복방지 후 추가
                if (!numbers.Contains(num))
                numbers.Add(num);
            }
            
            //보너스 번호 떼기
            int bonusNum = numbers[numbers.Count-1];
            numbers.RemoveAt(numbers.Count-1);
            numbers.Sort();

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"보너스 번호 : {bonusNum}");
        }
        public void Third()
        {
            Random random = new Random();
            HashSet<int> numbers = new HashSet<int>();

            while (numbers.Count < 6)
            {
                int num = random.Next(1, 10);
                numbers.Add(num);
            }

            int bonusNum;
            do
            {
                bonusNum = random.Next(1, 10);
            } while (numbers.Contains(bonusNum));

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"보너스 번호는 : {bonusNum}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Lotto lo = new Lotto();
            lo.Second();
            lo.Third();
        }
    }
}
