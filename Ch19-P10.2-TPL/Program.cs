using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ch19_P10._2_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowThreadInfo("Main Method");
            //Task.Factory.StartNew(() => Method1());
            //Task.Factory.StartNew(() => Method2());

            //Task.Run(() => Method1());
            //Task.Run(() => Method2());

            //Parallel.Invoke(() => Method1(), () => Method2());

            Action action1 = new Action(BossMethod1());
            Action action2 = new Action(BossMethod2());
            Action action3 = new Action(BossMethod3());
            Action action4 = new Action(BossMethod4());

            //Parallel.Invoke(action1 , action2 , )

            //Method1();

            ShowThreadInfo("Main Method");
            Console.WriteLine(" Press any key to terminate ");
            Console.ReadLine();
        }

        private static Action BossMethod4()
        {
            throw new NotImplementedException();
        }

        private static Action BossMethod3()
        {
            throw new NotImplementedException();
        }

        private static Action BossMethod2()
        {
            throw new NotImplementedException();
        }

        private static Action BossMethod1()
        {
            throw new NotImplementedException();
        }

        private static void ShowThreadInfo(object info)
        {
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine(" === Current Thread Information (  "+ info.ToString() +" ) === ");
            Console.WriteLine(" Thread ID   = " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(" ThreadState = " + Thread.CurrentThread.ThreadState);
            Console.WriteLine("_______________________________________________________________");
        }

        private static void Method2()
        {
            Console.WriteLine("\n ***** Method 2 ***** ");
            ShowThreadInfo("Method 2");
            Console.WriteLine(" Method 2 Working... \n");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(" "+i);
                Thread.Sleep(200);
            }
            Console.WriteLine("\n Exiting Method 2 \n");
        }

        private static void Method1()
        {
            Console.WriteLine("\n ***** Method 1 ***** ");
            ShowThreadInfo(" Method 1 ");
            Console.WriteLine(" Method 1 Working... \n");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(" " + i);
                Thread.Sleep(200);
            }
            Console.WriteLine("\n Exiting Method 1 \n");
        }
    }
}
