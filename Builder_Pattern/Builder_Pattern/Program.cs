using System;

namespace Builder_Pattern
{
    class Program
    {

        public interface Item
        {
            public string name();
            public Packing packing();
            public float price();
        }

        public abstract class Burger :Item
        {
            public Packing packing()
            {
                return new Wrapper();
            }

            public abstract float price();
        } 
        
        public class ChickenBurger :Burger
        {
            public string name()
            {
                return "Chicken Burger";
            }
            override
            public float price()
            {
                return 250;
            }
        }

        public class VegBurger : Burger
        {
            public string name()
            {
                return "Veg Burger";
            }

            override
                public float price()
            {
                return 150;
            }
        }

        public abstract class Coldrink:Item
        {
            
            public Packing packing()
            {
                return new Bottle();
            }
            public abstract float price();
        }

        public class Coke : Coldrink
        {
            public string name()
            {
                return "Coka Cola";
            }

            override
            public float price()
            {
                return 150;
            }
        }

        public class Pepsi : Coldrink
        {
            public string name()
            {
                return "Pepsi";
            }

            override
            public float price()
            {
                return 100;
            }
        }

        public interface Packing
        {
            public string pack();
        }

        public class Wrapper : Packing
        {
            public string pack()
            {
                return "wrapper";
            }
        }

        public class Bottle : Packing
        {
            public string pack()
            {
                return "Bottle";
            }
        }

        public class Meal
        {
            private List
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
