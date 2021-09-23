using System;
using System.Threading;

namespace EventThreading6
{
    class Program
    {
        // There are two thread main()  and somethod()
        static AutoResetEvent objAuto = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            new Thread(SomeMethod).Start();//it will invoke somemethod in different thread
            Console.ReadLine();
            // signled to start again
            objAuto.Set(); // proceed your event where u halt of main thread for waitone()
            Console.ReadLine();
            // signled to start again
            objAuto.Set(); // waitone fo 2
        }
        static void SomeMethod()
        {
            Console.WriteLine("Starting1..");
            // wait
            objAuto.WaitOne();// give signal to main thread to halt your process
            Console.WriteLine("Finishing1..");

            Console.WriteLine("Starting2..");
            // wait
            objAuto.WaitOne();//2
            Console.WriteLine("Finishing2..");
        }
    }
}
