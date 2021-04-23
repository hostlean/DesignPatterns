using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.CheckForSingleton();

        }
    }

    public class Singleton
    {
        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        private Singleton()
        {
            Console.WriteLine("Singleton is active");
        }

        public void CheckForSingleton()
        {
            Console.WriteLine("Singleton is working");
        }
    }
}