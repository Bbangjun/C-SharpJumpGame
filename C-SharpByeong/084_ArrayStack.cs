using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _084_ArrayStack
    {
        class ArrayStack
        {
            int top; //스택의 상단
            int[] data = new int[20];
            public ArrayStack() { top = -1; }
            //-1을 넣어주는 이유는 배열의 값을 전위증가로 0번쨰부터 접근하기 위함

            bool isEmpty() { return top == -1; }
            bool isFull() { return top == data.Length; }

            void Error(string message)
            {
                Console.WriteLine(message);
            }

            // * 데이터 추가 함수
            public void Push(int value)
            {
                if(isFull())
                {
                    Error("Stack is Full");
                    return;
                }
                data[++top] = value;
                //top을 1 증가시킨 후 데이터 추가
            }

            // * 데이터 제거함수
            public int Pop()
            {
                if(isEmpty())
                {
                    Error("Stack is Empty");
                    return 0;
                }
                return data[top--];
            }

            public int Peek()
            {
                if(isEmpty())
                {
                    Error("Stack is Empty");
                    return 0;
                }
                return data[top];
            }
            
            public void Display()
            {
                Console.WriteLine("스택 갯수 : " + (top + 1));
                for(int i = 0; i<=top; i++)
                {
                    Console.WriteLine(" <" + data[i] + "> ");
                }
                Console.WriteLine();
            }
        }
        static void Main1(string[] args)
        {
            ArrayStack stack = new ArrayStack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Display();
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            stack.Display();
            stack.Push(40);
            stack.Display();
        }
    }
}
