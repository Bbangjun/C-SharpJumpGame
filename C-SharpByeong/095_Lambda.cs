using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _095_Lambda
    {
        delegate void Anonymous();

        delegate int AnonymousB(int a, int b);

        delegate float Multi(float a, float b);
        static void Main1(string[] args)
        {
            // * 익명메서드(익명함수)
            //- 이름이 없는 함수
            //- 델리게이트를 통해서만 호출할 수 있다.
            //- 델리게이트에 편하게 함수등록하기 위해 사용

            Anonymous ano = delegate () { Console.WriteLine("익명!"); };
            ano();

            AnonymousB anoB = delegate (int x, int y) { return x + y; };
            Console.WriteLine(anoB(11, 22));

            // * 람다식
            //- 익명메서드를 간단하게 표현한 식

            ano = () => { Console.WriteLine("람다식"); };
            ano();

            anoB = (int x, int y) => { return x * y; };

            Hello();

            Console.WriteLine("Add : " + Add(100, 200));

            // * 실습
            //- 람다식으로 델리게이트에 함수 넣어주기
            //- 화살표함수 1개 만들어보기

            Multi mul = (float a, float b) => { return a * b; };
            Console.WriteLine(mul(1.1f, 2.2f));

            Console.WriteLine(Str("Hello ", "World"));
        }
        // * 화살표 함수(람다식)
        //- 코드가 1줄인 함수를 만들 때 간편하게 사용하는 방법

        static void Hello() => Console.WriteLine("Hello");

        static int Add(int a, int b) => a + b;
        //화살표함수는 return을 생략할 수 있다.

        static string Str(string a, string b) => a + b;
    }
}
