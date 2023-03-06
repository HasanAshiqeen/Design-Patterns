using System;

namespace ConsoleApp4
{

    public abstract class Shape
    {
        public abstract void draw();
    }

    public class Circle : Shape{
        public override void draw()
        {
            Console.WriteLine("Draw Circle");
        }

    }

    public class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Draw Square");
        }

    }

    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }

    public class ShapeFactory
    {
        public Shape GetShape(string type)
        {
            if (type == "Circle")
            {
                return new Circle();
            }
            else if (type == "Square")
            {
                return new Square();
            }

            else if (type == "Rectangle")
            {
                return new Rectangle();
            }
            return null;
        }


    }


    class ShapeDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ShapeFactory ob = new ShapeFactory();

            Shape A = ob.GetShape("Circle");
            Shape b = ob.GetShape("Square");
            A.draw();
            b.draw();

            Console.Read();

        }
    }
}
