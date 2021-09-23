using System;
using System.Threading;

namespace ThreadSync3
{
    class Program
    {
        static Maths objMaths = new Maths();
        static void Main(string[] args)
        {
           
            Thread t1 = new Thread(objMaths.Divide);
            t1.Start(); // Child Thread

            objMaths.Divide();

            Console.ReadKey();
        }
    }
    class Maths
    {
        public int Num1;
        public int Num2;

        Random o = new Random();
        public void Divide()
        {
            for (long i = 0; i < 10000; i++)
            {
                /* lock (this)
                 {*/
                Monitor.Enter(this);
                    Num1 = o.Next(1, 2); // 1 to 2
                    Num2 = o.Next(1, 2); // 1 to 2

                    int result = Num1 / Num2;

                    Num1 = 0; // o zero
                    Num2 = 0;
                Monitor.Exit(this);
                //}  
            }
        }
    }
}












