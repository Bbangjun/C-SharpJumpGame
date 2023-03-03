using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _085_ArrayQueue
    {
        class CircularQueue
        {
            int front; // 요소의 첫번째 위치
            int rear; // 요소의 마지막 위치

            int[] data = new int[20]; //요소

            public CircularQueue() { front = rear = 0; } //생성자

            // * 값이 없는지 확인하는 함수
            public bool isEmpty() { return front == rear; }

            // * 요소가 꽉 차있는지 확인하는 함수
            public bool isFull() { return (rear + 1 % data.Length) == front; }
            //rear +1을 한 값이 최대 갯수와 나머지 연산 후 그 값이 front와 같다면
            //즉 초과했따면 true 아니면 false

            void Error(string message) { Console.WriteLine(message); }

            public void Enqueue(int value)
            {
                if(isFull())
                {
                    Error("Queue is Full");
                }
                else
                {
                    rear = (rear + 1) % data.Length;
                    //rear의 값을 1 증가
                    data[rear] = value;
                    //마지막 위치에 값 추가
                }
            }

            public int Dequeue()
            {
                if(isEmpty())
                {
                    Error("Queue is Empty");
                    return 0;
                }
                else
                {
                    front = (front + 1) % data.Length;
                    return data[front]; //앞요소를 반환
                }
            }

            // * 다음 제거요소 확인 함수
            public int Peek()
            {
                if(isEmpty())
                {
                    Error("Queue is Empty");
                    return 0;
                }
                else
                {
                    return data[(front + 1) % data.Length];
                }
            }

            // * 요소를 출력하는 함수
            public void Display()
            {
                int max = (front < rear) ? rear - front : (rear + data.Length) - front; //요소의 갯수

                Console.WriteLine("큐의 갯수 : " + max);
                
                for (int i = front + 1; i <= rear; i++)
                {
                    Console.Write(" <" + data[i % data.Length] + "> ");
                }
                Console.WriteLine(); //개행
            }
        }
        static void Main1(string[] args)
        {
            // * 원형 큐
            //- 처음 값이 배열의 끝에 도달하면 다음 증가값은 처음값이 되는 구조
            //- 처음과 끝이 연결되어 있는 상태
            //- 데이터를 추가하면 front의 값은 변함이 없고 rear의 값이 증가된다.

            CircularQueue queue = new CircularQueue();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i); //0~9까지의 값을 큐에 추가
            }
            queue.Display();

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();
        }
    }
}
