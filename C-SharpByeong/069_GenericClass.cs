using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _069_GenericClass
    {
        public class GenericClass<T>
        {
            public T member;
            public GenericClass() { }
            public GenericClass(T value)
            {
                member = value;
            }
            public T Print()
            {
                Console.WriteLine(member);
                return member;
            }
        }

        public class GenericTest<T1, T2, T3>
        {
            T1 numA;
            T2 numB;
            T3 numC;

            public GenericTest(T1 a, T2 b, T3 c)
            {
                numA = a; numB = b; numC = c;
            }
            public void Print()
            {
                Console.WriteLine(numA);
                Console.WriteLine(numB);
                Console.WriteLine(numC);
            }
        }
        
        public class Test<T>
        {
            T input;

            public Test(T a)
            {
                input = a;
            }
            public void Print()
            {
                Console.WriteLine(input);
            }
        }
        public class Test2<T1, T2>
        {
            T1 input1;
            T2 input2;

            public Test2(T1 a, T2 b)
            {
                input1 = a;
                input2 = b;
            }

            public void Print()
            {
                Console.WriteLine("input1 = " + input1 + " input2 = " + input2);
            }
        }

        static void Main1(string[] args)
        {
            // * 제네릭 클래스
            //- 클래스 내부의 멤버변수의 데이터타입을 일반화 한 클래스
            //- 타입에 국한되지 않고 모든 타입을 멤버변수의 타입으로 설정 가능
            //- 제네릭메소드와 다르게 객체선언시 타입을 반드시 지정해야함

            GenericClass<int> genericA = new GenericClass<int>(10);
            genericA.Print();

            GenericTest<int, float, string> genericTest = new GenericTest<int, float, string>(1, 1.2f, "유니티");
            genericTest.Print();

            // * 실습
            //- 멤버변수 1개의 자료형을 일반화 한 클래스 만들기
            //- 멤버변수 값 출력
            //- 멤버변수 2개의 자료형을 일반화 한 클래스 만들기
            //- 멤버변수 2개 값 출력
            Test<int> test = new Test<int>(10);
            test.Print();

            Test2<int, string> test2 = new Test2<int, string>(5, "유니티");
            test2.Print();

        }
    }
}
