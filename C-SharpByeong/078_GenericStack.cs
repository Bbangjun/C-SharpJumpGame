using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _078_GenericStack
    {
        static void Main1(string[] args)
        {
            // * 스택(Stack)
            //- LIFO(Last In First Out)
            //- 후입선출

            // * 스택 활용 예시
            //- 웹 브라우저 뒤로가기 : 마지막에열린 페이지부터 뒤로감
            //- Ctrl + Z : 마지막에 수정한 내역부터 뒤로 되돌림

            Stack stack = new Stack(); //컬렉션
            // * 컬렉션은 Object타입으로 모든 데이터타입을 넣을 수 있다.
            stack.Push("유니티"); //데이터 추가
            stack.Push(1.1f);
            stack.Push(10);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
