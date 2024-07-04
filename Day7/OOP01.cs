namespace OOP01
{
    class Computer
    {
        public void Run()
        {
            Console.WriteLine("컴퓨터를 구동합니다.");
        }

    }

    class Notebook : Computer
    {

    }

    class Car
    {
        public string brand;

        public Car()
        {
            this.brand = "현대";
            Console.WriteLine("부모클래스 생성자가 호출되었습니다.");
        }
        public void Run()
        {
            Console.WriteLine("차가 달린다");
        }

    }

    class SuperCar : Car
    {
        public SuperCar() 
        {
            Console.WriteLine("자식클래스 생성자가 호출되었습니다.");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Run();
            Notebook notebook = new Notebook();
            notebook.Run();
            SuperCar spCar = new SuperCar();
            spCar.Run();
        }
    }
}
