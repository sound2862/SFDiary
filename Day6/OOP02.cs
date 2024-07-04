namespace OOP02
{
    class Car
    {
        //멤버변수
        public int speed;
        public string brand;
        //생성자
        public Car()
        {
            this.speed = 0;
            this.brand = "현대";
        }
        public Car(string brand)
        {
            this.speed = 100;
            this.brand = brand;
        }
        //멤버메소드
        public string Run(int speed)
        {
            this.speed = speed;
            return this.speed + "km 속도로 달립니다";
        }
        public string Run()                 //오버 로딩
        {
            return this.speed + "km 속도로 달립니다";
        }
        public string ShowBrand()
        {
            return "제 브랜드명은 " + this.brand + "입니다";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car tony = new Car();
            Console.WriteLine(tony.ShowBrand());
            Console.WriteLine(tony.Run());
            Console.WriteLine(tony.Run(80));

            Car jack = new Car("제니시스");
            Console.WriteLine(jack.ShowBrand());
            Console.WriteLine(jack.Run(500));
        }
    }
}
