using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _076_Boxing
    {
        static void Main1(string[] args)
        {
            // * Reference와 value
            //- 메모리는 4구역이 있다.
            //- Reference타입은 Heap영역에 저장
            //- Value타입은 Stack영역에 저장
            //- 두 영역은 데이터 저장 방식이 다름
            //- 타입을 변환하기 위해서는 시간이 많이 걸리게 됨

            // * Boxing
            //- Value타입을 Reference타입으로 변환

            // * UnBoxing
            //- Reference타입을 Value타입으로 변환

            // * 단순저장보다 Boxing은 약 20배, Unboxing은 약 4배정도의 시간 소요

            // * Value 타입 : int, float, bool, 구조체 등등
            // * Reference 타입 : string, class, object, delegate

            int a = 1; // value타입
            object boxing = a;
            //내부적으로 boxing과정을 거치게 됨

            object unboxing = 1;
            int b = (int)unboxing;
            //내부적으로 unboxing의 과정을 거치게 됨

        }
    }
}
