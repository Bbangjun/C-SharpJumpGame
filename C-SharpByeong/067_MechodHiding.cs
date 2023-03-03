using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _067_MechodHiding
    {
        class Parent
        {
            public void NewPrint()
            {
                Console.WriteLine("부모 메서드 숨기기");
            }

            public virtual void Print()
            {
                Console.WriteLine("부모 클래스");
            }

            public void SecondPrint()
            {
                Console.WriteLine("부모 메서드");
            }
        }
        class Child : Parent
        {
            public new void NewPrint()
            {
                Console.WriteLine("자식 메서드 숨기기");
            }

            public override void Print()
            {
                Console.WriteLine("자식 클래스");
            }

            public new void SecondPrint()
            {
                Console.WriteLine("자식 메서드");
            }
        }
        static void Main1(string[] args)
        {
            // * 메서드 숨기기
            //- 가상함수와 유사해보이지만 정적바인딩이 된다.
            //- new키워드를 사용해서 함수가 재정의 되었다는것을 알려준다.

            Parent parent = new Parent();
            parent.NewPrint();

            Child child = new Child();
            child.NewPrint();

            Parent super = new Child();
            super.NewPrint();

            // * 시습
            //- 가상함수를 이용하여 동적바인딩 해보기
            //- 메서드 숨기기로 정적바인딩 해보기

            parent.Print();
            child.Print();
            super.Print();
            parent.SecondPrint();
            child.SecondPrint();
            super.SecondPrint();
        }
    }
}
