using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_SharpByeong
{
    class _100_Thread2
    {
        static void Start()
        {
            Thread.Sleep(3000); //3초 딜레이
            Console.WriteLine("Start");
        }

        static void Game()
        {
            Thread.Sleep(3000); //3초 딜레이
            Console.WriteLine("Game");
        }

        static void End()
        {
            Thread.Sleep(3000);
            Console.WriteLine("End");
        }

        static void Main1(string[] args)
        {
            Thread workerA = new Thread(new ThreadStart(Start));
            Thread workerB = new Thread(new ThreadStart(Game));
            Thread workerC = new Thread(new ThreadStart(End));

            workerA.Priority = ThreadPriority.Highest;
            workerB.Priority = ThreadPriority.Normal;
            workerC.Priority = ThreadPriority.Lowest;

            workerA.Start();
            workerB.Start();
            workerC.Start();
            //스레드는 동시에작업하므로 실행순서는 매번 다르다.
        }
    }
}
