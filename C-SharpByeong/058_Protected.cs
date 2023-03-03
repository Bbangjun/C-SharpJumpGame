using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpByeong
{
    class _058_Protected
    {
        class Parent
        {
            private int numA = 10; //자신만 접근 가능
            public int numB = 20; //어디에서든 접근 가능
            protected int numC = 30; //자신과 자식만 접근 가능
        }

        class Child : Parent
        {
            public void Print()
            {
                //numA = 22; //private이므로 접근 불가
                numB = 33; //public은 접근 가능
                numC = 44; //protected는 접근 가능
            }
        }

        static void Main1(string[] args)
        {
            // * Protected
            //- 접근지정자
            //- 멤버변수, 멤버함수를 클래스내부 및 자식클래스에서만 접근 가능하게 해줌
            //- 클래스 외부에서 접근 불가

            Child child = new Child();
            //child.numA = 11; //접근 불가
            child.numB = 22; //접근 가능
            //child.numC = 33; //접근 불가
        }
    }
}
