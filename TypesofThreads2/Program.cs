using System;
using System.Threading;


namespace TypesofThreads2
{
    class Program
    {
        static void Main(string[] args)
        {

            // A Thread will be created to run
            // Function1 parallely

            Thread obj1=new Thread(Function1); // pass function name

            // To make Background Thread 
            obj1.IsBackground = true;
            obj1.Start();

            // the control will come here exit the main function
            Console.WriteLine("The main application is exited !!");
            Console.ReadKey();
        }

        private static void Function1()
        {
            Console.WriteLine("Function1 is entered..");
            // wait here until the user put any input
            Console.ReadKey();//wait here
            Console.WriteLine("Function1 is exited ...");
        }
    }
}
