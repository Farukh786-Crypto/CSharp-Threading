using System;
using System.Threading;
using System.Diagnostics;
namespace ThreadPoolThread7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Warm Up");
            for (int i = 0; i < 10; i++)
            {
                WithThreadPool();
                WithoutThreadPool();
            }
            Console.WriteLine("Ending Warm Up");


            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("recording with Thread pool");
            stopwatch.Start();
            WithThreadPool();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks.ToString());
            stopwatch.Reset();

            Console.WriteLine("recording without Thread pool");
            stopwatch.Start();
            WithoutThreadPool();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks.ToString());

            Console.ReadLine();
        }
        static void Function1(object o)
        {
            //Console.WriteLine("Called");
        }
        static void WithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Function1));
            }
        }
        static void WithoutThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread o = new Thread(Function1);
                o.Start();
            }
        }
    }
}
