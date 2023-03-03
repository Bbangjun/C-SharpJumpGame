using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace C_SharpByeong
{
    class _099_Thread
    {
        static void Hello() => Console.WriteLine("Hello");
        static void Bye() => Console.WriteLine("Bye");

        static void Main1(string[] args)
        {
            // * 스레드(Thread)
            //- 작업자(일꾼)을 의미
            //- 멀티스레드는 여러작업자로 여러작업을 동시에 작업

            // * Thread클래스의 주요 멤버
            //1. Priority
            //- 스레드의 우선배정을 의미
            //- 일의 우선순위가 아닌 배정의 우선 순위
            //- Highest, Normal, Lowest
            //2. Abort()
            //- 스레드 종료
            //3. Sleep()
            //- 스레드를 설정된 밀리초(1/1000초)만큼 대기
            //4. Start()
            //- 스레드 시작(작업 시작)

            Thread workerA = new Thread(new ThreadStart(Hello));
            Thread workerB = new Thread(new ThreadStart(Bye));
            
            workerA.Start(); //작업시작
            workerB.Start(); //작업시작
        }
    }
}
