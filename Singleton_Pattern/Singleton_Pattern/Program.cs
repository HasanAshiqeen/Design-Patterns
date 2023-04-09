using System;

namespace Singleton_Pattern
{
    class Program
    {

        public class SingletonObject
        {
            private static SingletonObject instance = new SingletonObject();


            public static SingletonObject getInstance()
            {
                return instance;
            }
            private SingletonObject()
            {

            }

            public void Show()
            {
                Console.WriteLine("Hello World i am calling from object");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SingletonObject obj = SingletonObject.getInstance();
            obj.Show();
        }
    }
}
