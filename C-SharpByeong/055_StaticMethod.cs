using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _055_StaticMethod
    {
        class Method
        {
            public static int num1 = 10;
            public static void Print()
            {
                Console.WriteLine("정적 함수 호출");

            }
        }

        class MyClass
        {
            public void NormalPrint()
            {
                Console.WriteLine("일반 함수");
            }
            public static void StaticPrint()
            {
                Console.WriteLine("정적 함수");
            }
        }
        static void Main1(string[] args)
        {
            // * 정적 함수(정적 메소드)
            //- 클래스의 고정멤버가 된다.
            //- 객체를 생성하지 않고 호출할 수 있다.
            //- 객체를 통해서 호출할 수 없다.
            //- 클래스 명과 함께 사용해야 한다.
            MyClass myClass = new MyClass();
            myClass.NormalPrint();
            //일반함수는 객체를 통해 호출해야함

            MyClass.StaticPrint();

            Console.Clear();

            // * 실습
            //- 클래스만들기
            //- 정적변수 만들기
            //- main함수에서 값변경 및 출력
            //- 클래스에 정적함수 만들기
            //- main함수에서 호출
            Console.WriteLine("정적 변수 num1 : " + Method.num1);
            Method.num1 = 15;
            Console.WriteLine("정적 변수 num1 : " + Method.num1);
            Method.Print();
        }
    }
}
