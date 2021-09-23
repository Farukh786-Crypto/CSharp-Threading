using System;
using System.Threading.Tasks;


namespace TPLMultiThreading8
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0,1000000, x=>RunMillionIterations());
        }

        private static void RunMillionIterations()
        {
            string x = "";
            for (int iIndex = 0; iIndex < 100000; iIndex++)
            {
                x = x + "s";
            }
        }
    }
}
