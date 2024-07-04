namespace P133
{
    class Circle
    {
        private double pi = 3.141592;

        public double Pi { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle o = new Circle();
            o.Pi = 3.14;                     //프로퍼티 쓰기
            double piValue = o.Pi;           //프로퍼티 읽기

            Console.WriteLine(piValue);
        }
    }
}
