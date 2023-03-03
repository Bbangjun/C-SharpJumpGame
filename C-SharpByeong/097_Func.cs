using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _097_Func
    {
        static int AAA()
        {
            return 1;
        }

        static float BBB(int a, string b)
        {
            return 1.2f;
        }
        static void Main1(string[] args)
        {
            // * Func델리게이트
            //- 반환자료형이 있는 함수를 참조할때 사용
            //- 정의가 있으므로 변수선언만 해주면 됨

            Func<int> funcA = AAA;
            //반환자료형 int, 매개변수 없는 함수를 참조

            Func<int, string, float> funcB = BBB;
            //Func<int, int, float> int형 두개를 매개변수로 받고 float형으로 반환
        }
    }
}
