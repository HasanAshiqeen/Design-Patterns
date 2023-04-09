using System;

namespace Abstract_Factory_Pattern
{
    class Program
    {

        public class FactoryProducer
        {
            public CarFactory GetFactory(string FactoryType)
            {
                if (FactoryType == "Toyota")
                {
                    return new Toyota();
                }

                else if(FactoryType == "Honda")
                {
                    return new Honda();
                }

                else { return null; }
            }
        }

        public abstract class CarFactory
        {
            public abstract Car getCar(string carType);
        }

        public class Honda : CarFactory
        {
            public override Car getCar(string carType)
            {
                if (carType == "Civic")
                {
                    return new Civic();
                }
                else if (carType == "City")
                {
                    return new City();
                }
                else
                {
                    return null;
                }
            }
        }
        public class Toyota : CarFactory
        {
            public override Car getCar(string carType)
            {
                if (carType == "Corolla")
                {
                    return new Corolla();
                }
                else if (carType == "Camry")
                {
                    return new Camry();
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

        public class Corolla : Car
        {
            public override void createCar()
            {
                Console.WriteLine("Corolla Is Created");
            }
        }

        public class Camry: Car
        {
            public override void createCar()
            {
                Console.WriteLine("Camry Is Created");
            }
        }

        public class Civic : Car
        {
            public override void createCar()
            {
                Console.WriteLine("Civic Is Created");
            }
        }

        public class City : Car
        {
            public override void createCar()
            {
                Console.WriteLine("City Is Created");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FactoryProducer factoryProducer = new FactoryProducer();
            
            CarFactory ToyotaFactory = factoryProducer.GetFactory("Toyota");

            CarFactory HondaFactory = factoryProducer.GetFactory("Honda");

            Car T1 = ToyotaFactory.getCar("Corolla");
            T1.createCar();

            Car H1 = HondaFactory.getCar("Civic");
            H1.createCar();

            Car T2 = ToyotaFactory.getCar("Camry");
            T2.createCar();

            Car H2 = HondaFactory.getCar("City");
            H2.createCar();



        }
    }
}
