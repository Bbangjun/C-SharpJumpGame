using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _068_GenericMethod
    {
        // * 함수 오버로딩
        //- 같은 이름으로 함수를 여러개 만드는 방법
        static void Print(int value)
        {
            Console.WriteLine(value);
        }
        static void Print(float value)
        {
            Console.WriteLine(value);
        }
        static void Print(string value)
        {
            Console.WriteLine(value);
        }
        static void Print<T>(T value)
        {
            Console.WriteLine(value);
            // * <T>
            //- 제네릭 메서드의 데이터 타입을 표시하는 기호
            //- 일반적으로 Type의 약자인 T로 작성하며
            //- 키워드 또는 예약어만 아니면 됨
        }

        static void Print2<T1, T2>(T1 value, T2 value2)
        {
            Console.WriteLine(value.ToString() + value2.ToString());
        }
        static Archer TestPrint<Archer>(Archer value)
        {
            Archer test = value;
            Console.WriteLine(test);
            return test;
        }

        static void Test<T>(T value)
        {
            Console.WriteLine("value : " + value);
        }
        static T2 Test2<T1, T2>(T1 value1, T2 value2)
        {
            Console.WriteLine("value1 : " + value1);
            return value2;
        }
        static void Main1(string[] args)
        {
            // * 일반화
            //- 연관성 있는 2개 이상의 개체 집합을 묶어내는 것

            // * 제네릭 함수(제네릭 메소드)
            //- 데이터 타입(자료형)을 일반화 한 함수

            Print(10);
            Print(12.34f);
            Print("유니티");
            Print2<int, float>(10, 23.45f);
            Print2<string, string>("유니티", "홍길동");
            Console.WriteLine("===============================");
            // * 실습
            //- 어떤 자료형이든 매개변수로 값을 1개 받아서 출력하는 함수 만들기
            //- 어떤 자료형이든 매개변수로 값을 2개 받아서 1개는 출력 1개는 반환하는 함수 만들기
            Test(10);
            Console.WriteLine("value 2 : " + Test2(5, 10));

        }
    }
}
