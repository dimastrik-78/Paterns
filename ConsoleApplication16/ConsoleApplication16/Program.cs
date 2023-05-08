using System;

namespace ConsoleApplication16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Singleton.Singleton singleton1 = Singleton.Singleton.GetSingleton;
            Singleton.Singleton singleton2 = Singleton.Singleton.GetSingleton;
            Console.WriteLine(singleton1.GetHashCode() == singleton2.GetHashCode());
        }
    }
}