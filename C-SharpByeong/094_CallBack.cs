using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _094_CallBack
    {
        static int Plus(int a, int b) { return a + b; }
        static int Minus(int a, int b) { return a - b; }
        static int Multiply(int a, int b) { return a * b; }

        delegate int Operators(int a, int b);

        static void Calculator(int a, int b, Operators op)
        {
            Console.WriteLine(op(a, b));
        }
        static void Main1(string[] args)
        {
            // * 콜백함수
            //- 1. A함수를 호출할때 B함수를 넘겨주어 A함수가 B함수의 역할을 대신하는 것
            //- 2. 사용자가 호출하지 않아도 호출하늖 ㅏㅁ수

            Calculator(11, 22, new Operators(Plus));
            Calculator(33, 55, new Operators(Minus));
            Calculator(10, 4, new Operators(Multiply));
        }
    }
}
