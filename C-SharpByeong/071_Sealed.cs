using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _071_Sealed
    {
        sealed class Unit { }
        //class Warrior : Unit { }
        class A
        {
            public virtual void Print()
            {
                Console.WriteLine("A클래스");
            }
        }
        class B : A
        {
            public sealed override void Print()
            {
                //A클래스의 Print함수를 재정의 했고
                //자식에게 더이상 재정의를 못하게 함
                Console.WriteLine("B클래스");
            }
        }

        class C : B
        {
            
        }

        sealed partial class Test
        {
            public void Print()
            {
                Console.WriteLine("Test");
            }
        }
        partial class Test
        {
            public void Print2()
            {
                Console.WriteLine("Print2");
            }
        }
        
        class TestA
        {
            public virtual void Print()
            {
                Console.WriteLine("TestA");
            }
        }

        class TestB : TestA
        {
            public sealed override void Print()
            {
                Console.WriteLine("TestB");
            }
        }
        class TestC : TestB
        {
            //public override void Print() { }
        }
        static void Main1(string[] args)
        {
            // * Sealed
            //- 봉인이라는 의미
            //- 클래스에 사용하면 Sealed클래스가 된다.
            //- Sealed Class는 부모클래스가 될 수 없다.
            //- 부모클래스가 될 수 없으므로 가상함수를 사용할 수 없다.
            //- 컴파일러가 가상함수 검사 과정을 생략한다.
            //- 성능이 약간 향상된다.

            //- 함수에 사용하면 Sealed Method가 된다.
            //- Sealed Method는 자식에게 재정의를 못하게 하는 역할

            B b = new B();
            b.Print();

            // * 실습
            //- Sealed Partial 클래스 하나 만들어보기
            //- 클래스 3개를 만들어서 Sealed Method 만들기
        }
    }
}
