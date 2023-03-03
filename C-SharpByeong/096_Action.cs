using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _096_Action
    {

        static void Main1(string[] args)
        {
            // * Action델리게이트
            //- void형 함수를 참조하는 경우 사용
            //- 델리게이트가 이미 정의가 되어 있다.
            //- 변수선언만 해주면 됨

            Action actionA = () => Console.WriteLine("액션!");
            actionA();

            Action<int> actionB = (int a) => Console.WriteLine(a);
            actionB(10);

            Action<float, string> actionC = (float a, string b) => Console.WriteLine(a + b);
            actionC(1.1f, " Hello");
        }
    }
}
