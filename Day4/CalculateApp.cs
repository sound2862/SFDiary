namespace CalculatorApp
{

    class Calculate  
    {
        public string Number;                            //멤버 변수

        public  Calculate()                              //디폴트 생성자 //default Constructor
        {

        }

        public Calculate(string name)                   //인자가 있는 생성자
        {

        }
        public int Multiple(int a,int b)                //인스턴스 메소드
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            return (double)a / b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate cal = new Calculate();        //인스턴스
            Console.WriteLine(cal.Multiple(5, 6));
            Console.WriteLine(cal.Divide(100, 5));

        }
    }
}
