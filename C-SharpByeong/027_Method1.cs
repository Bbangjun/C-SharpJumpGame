using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _027_Method1
    {
        static int global = 10; // 전역 변수

        static void Hello()
        {
            //함수는 코드의 모음이다.
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
        } //함수 정의
        static void Main1(string[] args)
        {
            global = 20;

            // * 메소드
            //- C, C++ : 함수라는 이름
            //- JAVA, C# : 메소드라는 이름
            //- 함수와 메소드는 같다.약간의 차이점 존재)
            //- 함수 외부에서 만들어야한다.
            //- 반환자료형 함수이름()
            //- { //코드; }

            // * 반환자료형
            //- 반환자료형에 맞는 값을 반환시켜주어야 한다.
            //- void : 반환값 없다는 의미
            //- int, string, float ... : 해당 자료형에 맞는 값을 반환해주어야 한다.

            // * static
            //- 정적함수 혹은 정적변수로만든다.
            //- 정적함수 정적함수만 사용할 수 있다.
            //- 예외경우도 있다.

            // * 함수이름 표기법/
            //- 파스칼 표기법을 사용한다.
            //- 단어의 첫글자를 대문자로 표기
            //ex)GetLocation(), MoveTo(), GetEnvQuerySystem()


            /*
            Hello(); // 함수 호출

            Console.WriteLine(One());
            Console.WriteLine("1.1 + 2.2 : " + OneTwo());

            int input1;
            int input2;

            Console.WriteLine("숫자 두개를 입력해주세요.");

            if(int.TryParse(Console.ReadLine(), out input1) && int.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("{0}, {1}", input1, input2 + " 의 합 : " + Add(input1, input2));
            }
            else
            {
                Console.WriteLine("정수만 입력해주세요.");
            }
            */

            // * 매개변수
            //- 함수 정의시 소괄호"()"안에
            //- 실행코드에 사용될 특정 데이터를 받을 수 있는
            //- 변수를 선언할 수 있다.
            //-매개변수는 여러개일 수도 있고 없을 수도 있다.
            // 0 호출시 괄호()안에 넣어주는 값을 "인자"라고 한다.


            // * 실습
            //- "유니티"를 출력하는 함수 만들기
            //- "Test"를 반환하는 함수 만들기
            //- float형 값 2개를 받아서 곱한 값을 반환하는 함수 만들기

            Unity();
            Console.WriteLine(Test());

            float input1;
            float input2;

            Console.WriteLine("숫자 두개를 입력해주세요.");

            if (float.TryParse(Console.ReadLine(), out input1) && float.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("{0}, {1}", input1, input2 + "의 곱 : " + multiple(input1, input2));
            }
            else
            {
                Console.WriteLine("실수만 입력해주세요.");
            }
        }

        static int One()
        {
            return 1;
            //return : 함수를 종료하고 값을 호출한곳으로 반환
        }

        static float OneTwo()
        {
            float result = 1.1f + 2.2f;
            return result;
        }

        static int Add(int x, int y)
        {
            int sum;
            sum = x + y;
            return sum;
        }

        static void Unity()
        {
            Console.WriteLine("유니티");
        }

        static string Test()
        {
            return "Test";
        }

        static float multiple(float x, float y)
        {
            return x * y;
        }
    }
}
