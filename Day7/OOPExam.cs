namespace OOPExam
{
    abstract class Car  //추상클래스
    {
        public abstract void Run(); //추상메소드 abstract 메소드
    }
    class Bus : Car
    {
        public override void Run()
        {
            Console.WriteLine("버스가 달린다");
        }
    }
    class Taxi : Car
    {
        public override void Run()
        {
            Console.WriteLine("택시가 달린다");
        }
    }
    class Truck : Car
    {
        public override void Run()
        {
            Console.WriteLine("트럭이 달린다");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Car car1 = new Bus();
            Car car2 = new Taxi();
            Car car3 = new Truck();
            car1.Run();
            car2.Run();
            car3.Run();
            //////////////////////
            Car[] cars = new Car[3];
            cars[0] = new Bus();
            cars[1] = new Taxi();
            cars[2] = new Truck();

            for(int i=0; i<3; i++)
            {
                cars[i].Run();
            }

            //////////////////////
            Car car4 = new Bus();
            car4.Run();
            car4 = new Taxi();
            car4.Run();
            car4 = new Truck();
            car4.Run();
        }
    }
}
