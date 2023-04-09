using System;

namespace Factory_Pattern
{
    class Program
    {
        public class CarFactory
        {
            public Car getCar(String type)
            {
                if(type == "Corolla")
                {
                    return new Corolla();
                }

                else if(type == "Camry")
                {
                    return new Camry();
                }

                else if (type == "Prius")
                {
                    return new Prius();
                }
                else
                {
                    return null;
                }
            }
        }

        public abstract class Car
        {
            public abstract void createCar();
        }


        public class Corolla :Car
        {
            public override void createCar()
            {
                Console.WriteLine("Corolla Is Created");
            } 
        }

        public class Camry : Car
        {
            public override void createCar()
            {
                Console.WriteLine("Camry Is Created");
            }

        }

        public class Prius : Car
        {
            public override void createCar()
            {
                Console.WriteLine("Prius Is Created");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CarFactory carFactory = new CarFactory();
            
            Car car1 = carFactory.getCar("Corolla");
            car1.createCar();

            Car car2 = carFactory.getCar("Camry");
            car2.createCar();

            Car car3 = carFactory.getCar("Prius");
            car3.createCar();

        }
    }
}
