namespace Quiz3
{
    internal class Program
    {
    //1.숫자를 입력하세요
    //2.연산자 (+,-,*,/)를 입력하세요
    //3.두번째 숫자를 입력하세요.
    //4.결과는 ?? 입니다.
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Write("첫번째 숫자를 입력하세요 : ");
                int num1 = Int32.Parse(Console.ReadLine());

                Console.Write("연산자 (+,-,*,/)를 입력하세요 : ");
                string oper = Console.ReadLine();

                Console.Write("두번째 숫자를 입력하세요 : ");
                int num2 = Int32.Parse(Console.ReadLine());

                switch (oper)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "/":
                        Console.WriteLine((double)num1 / num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    default:
                        Console.WriteLine("올바른 연산자를 입력해주세요");
                        break;
                }

                while (true)
                {
                    Console.Write("계산을 계속하시겠습니까? (y/n) : ");
                    string YN = Console.ReadLine().ToLower();

                    if (YN == "y")
                    {
                        break;
                    }
                    else if (YN == "n")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("다시 입력해주세요!");
                        continue;   //없어도 되긴함
                    }
                }
            }
        }
    }
}
