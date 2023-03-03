using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _092_Delegate
    {
        public static void Print()
        {
            Console.WriteLine("프린트");
        }
        public delegate void MyDelegate(); //델리게이트 정의
        //- 반환자료형이 void, 매개변수가 없는 함수를 대신하는 델리게이트

        public static int AddNum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }

        public static void Print_X(string x)
        {
            Console.WriteLine(x);
        }
        public delegate void Del1(string x);

        public static float MulFloat(float a, float b)
        {
            Console.WriteLine(a * b);
            return a * b;
        }
        public delegate float Del2(float a, float b);

        public delegate int MyInt(int numA, int numB);
        static void Main1(string[] args)
        {
            // * 델리게이트
            //- 대리자 라는 의미
            //- 함수의 변수역할(함수의 대리자)
            //- reference타입

            MyDelegate MyDel = new MyDelegate(Print);
            MyDel();

            MyInt MyDel2 = new MyInt(AddNum);
            Console.WriteLine(MyDel2(1, 2));

            // * 실습
            //- 반환자료형 void, 매개변수 x 함수 만들기
            //- 델리게이트에 넣고 델리게이트로 호출
            //- 반환자료형 float, 매개변수 float, float 함수 만들기
            //- 델리게이트에 넣고 델리게이트 호출

            Del1 del1 = new Del1(Print_X);
            del1("Hello World");
            Del2 del2 = new Del2(MulFloat);
            del2(1.1f, 2.2f);
        }
    }
}
