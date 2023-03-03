using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _029_Method3
    {
        static void ThisCall(int cnt)
        {
            if (cnt == 0)
                return; //함수를 종료시켜줌
            Console.WriteLine("Hello");
            ThisCall(--cnt); // cnt의 값을 1감소 후 자신을 호출
        }
        static void Main29(string[] args)
        {
            // * 재귀함수
            //- 함수안에서 자신을 호출하는 함수
            //- 함수의 종료조건이나 텀을 만들어 주어야 함

            ThisCall(5);

            // * 팩토리얼
            //- 5! : 5 * 4 * 3 * 2 * 1
            //- 4! : 4 * 3 * 2 * 1

            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));
        }

        static int Factorial(int num)
        {
            if (num == 1)
                return 1;
            int result = num * Factorial(--num);
            return result;
        }
    }
}
