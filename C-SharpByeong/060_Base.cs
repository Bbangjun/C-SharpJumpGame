using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _060_Base
    {
        class Parent
        {
            public string name = "부모";

            public void ParentMethod()
            {
                Console.WriteLine("이름 : " + name);
            }
        }
        class Child : Parent
        {
            public string name = "자식";
            public void ChildMethod()
            {
                Console.WriteLine("이름 : " + name);
            }
            public void ParentPrint()
            {
                Console.WriteLine("부모 이름 : " + base.name);
                // * base
                //- 부모를 가리키는 키워드
                //- 자식클래스에서 부모클래스에 접근해야 하는 경우 사용
                //- 함수, 프로퍼티, 생성자에서만 사용 가능
                //- static함수에서 사용 불가
                //- 변수명 혹은 함수명이 자식과 부모가 같으면 사용
            }
        }
        static void Main1(string[] args)
        {
            Child child = new Child();
            child.ChildMethod();
            child.ParentMethod();
        }
    }
}
