using System;
// step 1 : import nampace 
using System.Threading;

namespace Threading1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Running programme Sequentially.
             Function1();
             Function2();*/

            // Parallel Execution
            // step 2:create thread object
            Thread obj1 = new Thread(Function1);
            Thread obj2 = new Thread(Function2);

            // step 3: invoke thread
            obj1.Start();
            obj2.Start();
            Console.ReadKey();
            // if application is quit i.e main thread is exist still obj1 and obj2 is running i.e Foreground thread
        }
        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 is Executed :" + i.ToString());
                // wait for 4 seconds
                Thread.Sleep(4000);
            }
        }
        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 is Executed :" + i.ToString());
                // wait for 4 seconds
                Thread.Sleep(4000);
            }
        }

       
    }
}
/*Outpute:
Function 1 is Executed :0
Function 1 is Executed :1
Function 1 is Executed :2
Function 1 is Executed :3
Function 1 is Executed :4
Function 1 is Executed :5
Function 1 is Executed :6
Function 1 is Executed :7
Function 1 is Executed :8
Function 1 is Executed :9
Function 2 is Executed :0
Function 2 is Executed :1
Function 2 is Executed :2
Function 2 is Executed :3
Function 2 is Executed :4
Function 2 is Executed :5
Function 2 is Executed :6
Function 2 is Executed :7
Function 2 is Executed :8
Function 2 is Executed :9
*/