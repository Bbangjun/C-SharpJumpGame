using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _089_RefOut
    {
        static void Plus(int num)
        {
            //value타입은 복사가 이루어진다.
            //매개변수를 통해 들어온 값이 복사되었으므로
            //인자로 들어온 변수값은 증가하지 않음
            num++;
        }

        static void PlusRef(ref int num)
        {
            // * 참조호출(ref)
            //- 매개변수 앞에 ref를 적으면 인자로 들어온 변수를 참조한다.
            //- 단, 인자로 들어오는 변수 값은 초기화를 해 주어야 함

            num++;
        }

        static void PlusOut(out int num)
        {
            // * out
            //- ref와 같이 매개변수로 들어온 변수를 참조
            //- out은 변수를 초기화 하지 않아도 된다.
            //- 호출한 곳으로 값을 넘기는데 사용
            num = 123;
        }
        static void Main1(string[] args)
        {
            int numA = 10;
            Plus(numA);
            Console.WriteLine("numA : " + numA);

            int numB = 10;
            PlusRef(ref numB);
            Console.WriteLine("numB : " + numB);

            int numC;
            PlusOut(out numC);
            Console.WriteLine("numC : " + numC);
        }
    }
}
