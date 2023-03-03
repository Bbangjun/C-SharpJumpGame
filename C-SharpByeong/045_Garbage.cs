using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _045_Garbage
    {
        class Garbage
        {
            public int num;
        }
        static void Main1(string[] args)
        {
            // * 메모리 관리
            //- new를 사용하여 동적으로 할당한 메모리는 사용이 끝나면 반드시 해제해야 한다.
            //- C#에서는 가비지컬렉션이 메모리해제를 담당한다.

            Garbage garbage = new Garbage();
            garbage.num = 5;
            Console.WriteLine("garbage : " + garbage.num);

            //사용이 끝나면 메모리 해제를 해준다.
            // * 가비지컬렉션의 장점
            //- 편리하다.
            //- 이중해제버그(이미 해제된 메모리를 해제하는 것)에 자유로움
            //- 메모리 누수(더 이상 필요하지 않은 메모리가 해제하지 않고 남아있는 것)에 대한 신경을 안써도됨

            // * 가비지 컬렉션의 단점
            //- 비용이 크다
            //- 가비지 컬렉션이 일어나는 시간 예측이 어렵다.

            //Garbage :  불필요한 메모리 및 유효하지 않은 메모리주소를 의미
        }
    }
}
