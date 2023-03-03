using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _063_Overriding
    {
        class Parent
        {
            public string name = "부모";
            public void Print()
            {
                Console.WriteLine("부모클래스");
            }
        }

        class Child : Parent
        {
            public string name = "자식";
            public void Print()
            {
                Console.WriteLine("자식클래스");
            }
        }

        class Newbie
        {
            public void Print()
            {
                Console.WriteLine("뉴비");
            }
        }

        class Warrior : Newbie
        {
            public void Print()
            {
                Console.WriteLine("워리어");
            }
        }

        static void Main1(string[] args)
        {
            // * 오버라이딩
            //- 부모클래스와 자식클래스의 멤버 이름이 같으면
            //- 자신의 멤버를 우선적으로 사용하는 것

            // * 함수 재정의
            //- 부모클래스와 자식클래스의 멤버함수 이름이 같은것

            Parent parent = new Parent();
            Console.WriteLine("이름 : " + parent.name);
            parent.Print(); //자신의 메멉함수가 우선시 된다.

            Child child = new Child();
            Console.WriteLine("이름 : " + child.name);
            child.Print();

            // * 정적 바인딩
            //- 부모객체에 자식 인스턴스를 넣으면 객체의 멤버가 호출되는 것
            //- 정적 : 컴파일시
            //- 바인딩 : 연결

            Parent super = new Child();
            super.Print();

            Console.WriteLine("=================================");

            Newbie newbie = new Newbie();
            newbie.Print();

            Warrior warrior = new Warrior();
            warrior.Print();

            Newbie newbie1 = new Warrior();
            newbie1.Print();
            // * 실습
            //-  Newbie클래스 만들기
            //- Warrior클래스 만들기
            //- 함수 재정의 하기
            //- 재정의한 함수 호출하기
            //- 정적바인딩 사용해보기
        }
    }
}
