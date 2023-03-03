using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _065_Virtual
    {
        class Parent
        {
            public virtual void Print() //가상함수
            {
                Console.WriteLine("부모클래스");
            }//자식클래스에서 재정의 할것을 기대하고 만든 함수

        }

        class Child : Parent
        {
            public override void Print()
            {
                Console.WriteLine("자식클래스");
            }
        }


        static void Main1(string[] args)
        {
            // * 가상함수(다형성)
            //- 동적바인딩 시켜주는 역할

            // * 동적바인딩
            //- 런타임시 객체와 함수가 연결됨

            // * 정적바인딩
            //- 컴파일시 객체와 함수가 연결됨

            Parent parent = new Parent();
            parent.Print();

            Child child = new Child();
            child.Print();

            Parent super = new Child();
            super.Print();
            // * 가상함수를 쓰면 동적바인딩이 된다.
            //- 동적바인딩이 되면 부모객체에 자식인스턴스를 넣었을때
            //- 인스턴스에 해당하는 함수가 호출된다.

        }
    }
}
