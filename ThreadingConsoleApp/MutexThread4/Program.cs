using System;
using System.Threading;

namespace MutexThread4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var m1=new Mutex(false, "MutexThread4"))
            {
                if (!m1.WaitOne(500, false))// checking if any other thread is running
                {
                    Console.WriteLine("already instance is running");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("App Running...");
                Console.ReadLine();
            }
                
            
        }
    }
}
