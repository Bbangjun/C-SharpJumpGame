using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_SharpByeong
{
    class _079_GenericQueue
    {
        static void Main1(string[] args)
        {
            // * 큐(Queue)
            //- FIFO(First In First Out)
            //- 선입선출
            //- 처음들어온 데이터가 처음으로 나감


            // * 활용예시
            //- 서버 대기열 : 먼저 입장한 사람이 먼저 게임 접속
            //- 프린터 출력 : 가장 먼저 대기열에 오른 프린트가 먼저 출력

            Queue queue = new Queue();

            queue.Enqueue("유니티"); //데이터 추가
            queue.Enqueue(1.1f);
            queue.Enqueue(99);

            Console.WriteLine(queue.Peek());
            //peek : 다음에 제거될 데이터를 반환
            queue.Dequeue(); //데이터 제거
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
