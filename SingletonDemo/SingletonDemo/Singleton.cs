using System;

namespace SingletonDemo
{
    // sealed : no child class can be made ie prevent class inheritance
    public sealed class Singleton
    {
        // static variable to hold the reference to a single instance created
        private static int counter = 0;
        private static Singleton? instance = null;

        // auto-property
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        // object can be created within this class only
        private Singleton() {
            counter++;
            Console.WriteLine("Counter value: "+ counter.ToString());
        }
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
