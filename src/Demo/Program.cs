using System;
using System.Threading;

namespace Demo
{
    class Program
    {
        private static void Main(string[] args)
        {
            new Thread(A).Start();
            new Thread(B).Start();
            Console.ReadKey();
        }

        private static void A(object state)
        {
            while (true)
            {
                Thread.Sleep(1000);
            }
        }

        private static void B(object state)
        {
            while (true)
            {
                double d = new Random().NextDouble() * new Random().NextDouble();
            }
        }
    }

}
