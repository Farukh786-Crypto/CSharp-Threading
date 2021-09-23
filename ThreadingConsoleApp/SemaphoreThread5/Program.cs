using System;
using System.Threading;
namespace SemaphoreThread5
{
    class Program
    {
        static Semaphore s1 = null;
        static void Main(string[] args)
        {
            try
            {
                s1 = Semaphore.OpenExisting("SemaphoreThread5"); // line crashed
            }
            catch(Exception ex)
            {
                s1 = new Semaphore(3,3,"SemaphoreThread5");
            }
            Console.WriteLine("Acquiring!!");
            s1.WaitOne();
            // this area can be accessed only by 3 thread .
            Console.WriteLine("Thread Acquired !!");
            Console.ReadLine();
            s1.Release();
        }
    }
}
