using System;
using System.Threading;

namespace FinallyNot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new Thread(() => throw new ArithmeticException()).Start();
            }
            finally
            {
                Console.WriteLine("Finally!");
            }
        }
    }
}
